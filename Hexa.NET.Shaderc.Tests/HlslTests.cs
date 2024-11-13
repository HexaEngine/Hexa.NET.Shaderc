namespace Hexa.NET.Shaderc.Tests
{
    [TestFixture]
    public class HlslTests
    {
        private ShadercCompiler compiler;
        private ShadercCompileOptions options;
        private static readonly string filename = "vs.hlsl";
        private static readonly string entrypoint = "main";
        private static readonly string source = File.ReadAllText(filename);
        private readonly nuint sourceSize = (nuint)source.Length;


        [SetUp]
        public void Setup()
        {
            compiler = Shaderc.CompilerInitialize();
          
            options = Shaderc.CompileOptionsInitialize();
            options.SetOptimizationLevel(ShadercOptimizationLevel.Performance);
            options.SetSourceLanguage(ShadercSourceLanguage.Hlsl);
        }

        [Test]
        public void HLSLCompile()
        {
            ShadercCompilationResult result = compiler.CompileIntoSpv(source, sourceSize, ShadercShaderKind.VertexShader, filename, entrypoint, options);

            CheckResult(result);
            CloneResult(result);

            result.Release();
        }

        [Test]
        public void HLSLPreprocess()
        {
            ShadercCompilationResult result = compiler.CompileIntoPreprocessedText(source, sourceSize, ShadercShaderKind.VertexShader, filename, entrypoint, options);

            CheckResult(result);
            var text = ResultAsString(result);

            result.Release();

            Assert.Pass(text);
        }

        [Test]
        public unsafe void HLSLAssemble()
        {
            ShadercCompilationResult asmResult = compiler.CompileIntoSpvAssembly(source, sourceSize, ShadercShaderKind.VertexShader, filename, entrypoint, options);

            CheckResult(asmResult);
            CloneResult(asmResult);

            var length = asmResult.GetLength();
            var bytecode = asmResult.GetBytes();

            ShadercCompilationResult spvResult = compiler.AssembleIntoSpv(bytecode, length, options);

            asmResult.Release();

            CheckResult(spvResult);
            CloneResult(spvResult);

            Assert.Pass();
        }

        [TearDown]
        public void Teardown()
        {
            options.Release();
            compiler.Release();
        }

        private static void CheckResult(ShadercCompilationResult result)
        {
            var status = result.GetCompilationStatus();
            if (status != ShadercCompilationStatus.Success)
            {
                string message = result.GetErrorMessageS();
                Assert.Fail(message);
            }

            if (result.GetNumWarnings() > 0)
            {
                string message = result.GetErrorMessageS();
                Assert.Warn(message);
            }
        }

        private unsafe static void CloneResult(ShadercCompilationResult result)
        {
            var length = result.GetLength();
            var bytecode = result.GetBytes();

            byte[] bytes = new byte[length];
            fixed (byte* ptr = bytes)
                Buffer.MemoryCopy(bytecode, ptr, length, length);
        }

        private unsafe static string ResultAsString(ShadercCompilationResult result)
        {
            var bytecode = result.GetBytes();
            var text = ToStringUTF16(bytecode);
            return text;
        }
    }
}