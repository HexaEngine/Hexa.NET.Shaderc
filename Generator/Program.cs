namespace Generator
{
    using CppAst;

    internal class Program
    {
        private static int Main(string[] args)
        {
            string headerFile = "shaderc/shaderc.h";

            var options = new CppParserOptions
            {
                ParseMacros = true,
            };

            var compilation = CppParser.ParseFile(headerFile, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                for (int i = 0; i < compilation.Diagnostics.Messages.Count; i++)
                {
                    CppDiagnosticMessage? message = compilation.Diagnostics.Messages[i];
                    if (message.Type == CppLogMessageType.Error)
                    {
                        var currentColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(message);
                        Console.ForegroundColor = currentColor;
                    }
                }

                return 0;
            }

            CsCodeGenerator.Generate(compilation, "../../../../HexaEngine.Shaderc/Generated");

            return 0;
        }
    }
}