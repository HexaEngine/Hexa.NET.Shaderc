// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace HexaEngine.Shaderc
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ShadercIncludeResult
	{
		public unsafe byte* SourceName;
		public nuint SourceNameLength;
		public unsafe byte* Content;
		public nuint ContentLength;
		public unsafe void* UserData;
	}

}