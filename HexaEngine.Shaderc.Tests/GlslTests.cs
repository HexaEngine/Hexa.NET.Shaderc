namespace HexaEngine.Shaderc.Tests
{
    [TestFixture]
    public unsafe class GlslTests
    {
        private ShadercCompiler compiler;
        private ShadercCompileOptions options;
        private nuint sourceSize;
        private byte* pSource;
        private byte* pFilename;
        private byte* pEntrypoint;

        [SetUp]
        public void Setup()
        {
            // GLSL
            string filename = "vs.glsl";
            string entrypoint = "main";
            string source = File.ReadAllText(filename);
            sourceSize = (nuint)source.Length;
            pSource = GetStringUTF8(source);
            pFilename = GetStringUTF8(filename);
            pEntrypoint = GetStringUTF8(entrypoint);

            compiler = Shaderc.ShadercCompilerInitialize();

            options = Shaderc.ShadercCompileOptionsInitialize();
            Shaderc.ShadercCompileOptionsSetOptimizationLevel(options, ShadercOptimizationLevel.Performance);
            Shaderc.ShadercCompileOptionsSetSourceLanguage(options, ShadercSourceLanguage.Glsl);
        }

        [Test]
        public void GLSLCompile()
        {
            ShadercCompilationResult result = Shaderc.ShadercCompileIntoSpv(compiler, pSource, sourceSize, ShadercShaderKind.VertexShader, pFilename, pEntrypoint, options);

            CheckResult(result);
            CloneResult(result);

            Shaderc.ShadercResultRelease(result);

            Assert.Pass();
        }

        [Test]
        public void GLSLPreprocess()
        {
            ShadercCompilationResult result = compiler.CompileIntoPreprocessedText(pSource, sourceSize, ShadercShaderKind.VertexShader, pFilename, pEntrypoint, options);
            CheckResult(result);
            var text = ResultAsString(result);

            Shaderc.ShadercResultRelease(result);

            Assert.Pass(text);
        }

        [Test, Theory]
        public void GLSLAssemble()
        {
            ShadercCompilationResult asmResult = Shaderc.ShadercCompileIntoSpvAssembly(compiler, pSource, sourceSize, ShadercShaderKind.VertexShader, pFilename, pEntrypoint, options);

            CheckResult(asmResult);
            CloneResult(asmResult);

            var length = Shaderc.ShadercResultGetLength(asmResult);
            var bytecode = Shaderc.ShadercResultGetBytes(asmResult);

            ShadercCompilationResult spvResult = Shaderc.ShadercAssembleIntoSpv(compiler, bytecode, length, options);

            Shaderc.ShadercResultRelease(asmResult);

            CheckResult(spvResult);
            CloneResult(spvResult);

            Assert.Pass();
        }

        [TearDown]
        public void Teardown()
        {
            Free(pSource);
            Free(pFilename);
            Free(pEntrypoint);
            Shaderc.ShadercCompileOptionsRelease(options);
            Shaderc.ShadercCompilerRelease(compiler);
        }

        private static void CheckResult(ShadercCompilationResult result)
        {
            var status = Shaderc.ShadercResultGetCompilationStatus(result);
            if (status != ShadercCompilationStatus.Success)
            {
                string message = ToStringUTF16(Shaderc.ShadercResultGetErrorMessage(result));
                Assert.Fail(message);
            }

            if (Shaderc.ShadercResultGetNumWarnings(result) > 0)
            {
                string message = ToStringUTF16(Shaderc.ShadercResultGetErrorMessage(result));
                Assert.Warn(message);
            }
        }

        private static void CloneResult(ShadercCompilationResult result)
        {
            var length = Shaderc.ShadercResultGetLength(result);
            var bytecode = Shaderc.ShadercResultGetBytes(result);

            byte[] bytes = new byte[length];
            fixed (byte* ptr = bytes)
                Buffer.MemoryCopy(bytecode, ptr, length, length);
        }

        private static string ResultAsString(ShadercCompilationResult result)
        {
            var bytecode = Shaderc.ShadercResultGetBytes(result);
            var text = ToStringUTF16(bytecode);
            return text;
        }
    }
}