namespace HexaEngine.Shaderc
{
    public static unsafe partial class Shaderc
    {
        static Shaderc()
        {
            LibraryLoader.SetImportResolver();
        }
    }
}