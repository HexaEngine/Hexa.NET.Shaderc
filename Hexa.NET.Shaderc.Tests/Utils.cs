namespace Hexa.NET.Shaderc.Tests
{
    using System.Runtime.InteropServices;
    using System.Text;

    public static unsafe class Utils
    {
        public static byte* GetStringUTF8(string str)
        {
            int size = str.Length + 1;
            byte* ptr = (byte*)Marshal.AllocHGlobal(str.Length + 1);
            fixed (char* p = str)
                Encoding.UTF8.GetBytes(p, str.Length, ptr, str.Length);
            ptr[size - 1] = 0;
            return ptr;
        }

        public static string ToStringUTF16(byte* ptr)
        {
            return Marshal.PtrToStringUTF8((nint)ptr) ?? string.Empty;
        }

        public static void Free<T>(T* ptr) where T : unmanaged
        {
            Marshal.FreeHGlobal((nint)ptr);
        }
    }
}