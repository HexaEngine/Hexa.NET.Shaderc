// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.Shaderc
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum ShadercProfile : int
	{
		/// <summary>
		/// Used if and only if GLSL version did not specify<br/>
		/// profiles.<br/>
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		Core = unchecked(1),

		/// <summary>
		/// Disabled. This generates an error<br/>
		/// </summary>
		Compatibility = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		Es = unchecked(3),
	}
}
