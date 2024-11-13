// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;

List<string> files = [.. Directory.GetFiles("shaderc")];

CsCodeGeneratorConfig generatorSettings = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(generatorSettings);
generator.LogToConsole();
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Shaderc"], NamingPatchOptions.None));
generator.Generate(files, "../../../../Hexa.NET.Shaderc/Generated");