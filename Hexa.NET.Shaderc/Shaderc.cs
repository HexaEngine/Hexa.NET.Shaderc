namespace Hexa.NET.Shaderc
{
    using System.Runtime.InteropServices;

    public static unsafe partial class Shaderc
    {
        static Shaderc()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "shaderc_shared";
            }
            return "libshaderc_shared";
        }
    }
}