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
	/// Uniform resource kinds.<br/>
	/// In Vulkan, uniform resources are bound to the pipeline via descriptors<br/>
	/// with numbered bindings and sets.<br/>
	/// </summary>
	[Flags]
	public enum ShadercUniformKind : int
	{
		/// <summary>
		/// Image and image buffer.<br/>
		/// </summary>
		Image = unchecked(0),

		/// <summary>
		/// Pure sampler.<br/>
		/// </summary>
		Sampler = unchecked(1),

		/// <summary>
		/// Sampled texture in GLSL, and Shader Resource View in HLSL.<br/>
		/// </summary>
		Texture = unchecked(2),

		/// <summary>
		/// Uniform Buffer Object (UBO) in GLSL.  Cbuffer in HLSL.<br/>
		/// </summary>
		Buffer = unchecked(3),

		/// <summary>
		/// Shader Storage Buffer Object (SSBO) in GLSL.<br/>
		/// </summary>
		StorageBuffer = unchecked(4),

		/// <summary>
		/// Unordered Access View, in HLSL.  (Writable storage image or storage<br/>
		/// buffer.)<br/>
		/// </summary>
		UnorderedAccessView = unchecked(5),
	}
}
