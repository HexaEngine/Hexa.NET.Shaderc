namespace Generator
{
    using CppAst;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static partial class CsCodeGenerator
    {
        private static void GenerateStructAndUnions(CppCompilation compilation, string outputPath)
        {
            // Generate Structures
            using var writer = new CodeWriter(Path.Combine(outputPath, "Structures.cs"),
                "System",
                "System.Runtime.InteropServices"
                );

            // Print All classes, structs
            foreach (CppClass? cppClass in compilation.Classes)
            {
                if (cppClass.ClassKind == CppClassKind.Class ||
                    cppClass.SizeOf == 0 ||
                    cppClass.Name.EndsWith("_T"))
                {
                    continue;
                }

                bool isUnion = cppClass.ClassKind == CppClassKind.Union;

                string csName = GetCsCleanName(cppClass.Name);
                if (isUnion)
                {
                    writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");
                }
                else
                {
                    writer.WriteLine("[StructLayout(LayoutKind.Sequential)]");
                }

                bool isReadOnly = false;
                string modifier = "partial";

                WriteCsSummary(cppClass.Comment, writer);
                using (writer.PushBlock($"public {modifier} struct {csName}"))
                {
                    if (CsCodeGeneratorSettings.Default.GenerateSizeOfStructs && cppClass.SizeOf > 0)
                    {
                        writer.WriteLine("/// <summary>");
                        writer.WriteLine($"/// The size of the <see cref=\"{csName}\"/> type, in bytes.");
                        writer.WriteLine("/// </summary>");
                        writer.WriteLine($"public static readonly int SizeInBytes = {cppClass.SizeOf};");
                        writer.WriteLine();
                    }

                    foreach (CppField cppField in cppClass.Fields)
                    {
                        WriteField(writer, cppField, isUnion, isReadOnly);
                    }
                }

                writer.WriteLine();
            }
        }

        private static void WriteField(CodeWriter writer, CppField field, bool isUnion = false, bool isReadOnly = false)
        {
            string csFieldName = NormalizeFieldName(field.Name);
            WriteCsSummary(field.Comment, writer);
            if (isUnion)
            {
                writer.WriteLine("[FieldOffset(0)]");
            }

            if (field.Type is CppArrayType arrayType)
            {
                bool canUseFixed = false;
                if (arrayType.ElementType is CppPrimitiveType)
                {
                    canUseFixed = true;
                }
                else if (arrayType.ElementType is CppTypedef typedef
                    && typedef.ElementType is CppPrimitiveType)
                {
                    canUseFixed = true;
                }

                if (canUseFixed)
                {
                    string csFieldType = GetCsTypeName(arrayType.ElementType, false);
                    writer.WriteLine($"public unsafe fixed {csFieldType} {csFieldName}[{arrayType.Size}];");
                }
                else
                {
                    string unsafePrefix = string.Empty;
                    string csFieldType = GetCsTypeName(arrayType.ElementType, false);
                    if (csFieldType.EndsWith('*'))
                    {
                        unsafePrefix = "unsafe ";
                    }

                    for (int i = 0; i < arrayType.Size; i++)
                    {
                        writer.WriteLine($"public {unsafePrefix}{csFieldType} {csFieldName}_{i};");
                    }
                }
            }
            else
            {
                // VkAllocationCallbacks members
                if (field.Type is CppTypedef typedef &&
                    typedef.ElementType is CppPointerType pointerType &&
                    pointerType.ElementType is CppFunctionType functionType)
                {
                    StringBuilder builder = new();
                    foreach (CppParameter parameter in functionType.Parameters)
                    {
                        string paramCsType = GetCsTypeName(parameter.Type, false);
                        // Otherwise we get interop issues with non blittable types

                        builder.Append(paramCsType).Append(", ");
                    }

                    string returnCsName = GetCsTypeName(functionType.ReturnType, false);

                    builder.Append(returnCsName);

                    return;
                }

                string csFieldType = GetCsTypeName(field.Type, false);

                string fieldPrefix = isReadOnly ? "readonly " : string.Empty;
                if (csFieldType.EndsWith('*'))
                {
                    fieldPrefix += "unsafe ";
                }

                writer.WriteLine($"public {fieldPrefix}{csFieldType} {csFieldName};");
            }
        }

        private static string NormalizeFieldName(string name)
        {
            var parts = name.Split('_', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new();
            for (int i = 0; i < parts.Length; i++)
            {
                sb.Append(char.ToUpper(parts[i][0]));
                sb.Append(parts[i][1..]);
            }
            name = sb.ToString();
            if (CsCodeGeneratorSettings.Default.Keywords.Contains(name))
                return "@" + name;

            return name;
        }
    }
}