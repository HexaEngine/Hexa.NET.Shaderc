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
	/// Resource limits.<br/>
	/// </summary>
	[Flags]
	public enum ShadercLimit : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		MaxLights = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxClipPlanes = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTextureUnits = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTextureCoords = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexAttribs = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexUniformComponents = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVaryingFloats = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexTextureImageUnits = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedTextureImageUnits = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTextureImageUnits = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentUniformComponents = unchecked(10),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxDrawBuffers = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexUniformVectors = unchecked(12),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVaryingVectors = unchecked(13),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentUniformVectors = unchecked(14),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexOutputVectors = unchecked(15),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentInputVectors = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		MinProgramTexelOffset = unchecked(17),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxProgramTexelOffset = unchecked(18),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxClipDistances = unchecked(19),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeWorkGroupCountX = unchecked(20),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeWorkGroupCountY = unchecked(21),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeWorkGroupCountZ = unchecked(22),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeWorkGroupSizeX = unchecked(23),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeWorkGroupSizeY = unchecked(24),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeWorkGroupSizeZ = unchecked(25),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeUniformComponents = unchecked(26),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeTextureImageUnits = unchecked(27),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeImageUniforms = unchecked(28),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeAtomicCounters = unchecked(29),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxComputeAtomicCounterBuffers = unchecked(30),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVaryingComponents = unchecked(31),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexOutputComponents = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryInputComponents = unchecked(33),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryOutputComponents = unchecked(34),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentInputComponents = unchecked(35),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxImageUnits = unchecked(36),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedImageUnitsAndFragmentOutputs = unchecked(37),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedShaderOutputResources = unchecked(38),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxImageSamples = unchecked(39),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexImageUniforms = unchecked(40),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlImageUniforms = unchecked(41),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationImageUniforms = unchecked(42),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryImageUniforms = unchecked(43),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentImageUniforms = unchecked(44),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedImageUniforms = unchecked(45),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryTextureImageUnits = unchecked(46),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryOutputVertices = unchecked(47),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryTotalOutputComponents = unchecked(48),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryUniformComponents = unchecked(49),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryVaryingComponents = unchecked(50),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlInputComponents = unchecked(51),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlOutputComponents = unchecked(52),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlTextureImageUnits = unchecked(53),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlUniformComponents = unchecked(54),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlTotalOutputComponents = unchecked(55),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationInputComponents = unchecked(56),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationOutputComponents = unchecked(57),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationTextureImageUnits = unchecked(58),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationUniformComponents = unchecked(59),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessPatchComponents = unchecked(60),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxPatchVertices = unchecked(61),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessGenLevel = unchecked(62),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxViewports = unchecked(63),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexAtomicCounters = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlAtomicCounters = unchecked(65),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationAtomicCounters = unchecked(66),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryAtomicCounters = unchecked(67),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentAtomicCounters = unchecked(68),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedAtomicCounters = unchecked(69),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxAtomicCounterBindings = unchecked(70),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxVertexAtomicCounterBuffers = unchecked(71),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessControlAtomicCounterBuffers = unchecked(72),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTessEvaluationAtomicCounterBuffers = unchecked(73),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxGeometryAtomicCounterBuffers = unchecked(74),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxFragmentAtomicCounterBuffers = unchecked(75),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedAtomicCounterBuffers = unchecked(76),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxAtomicCounterBufferSize = unchecked(77),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTransformFeedbackBuffers = unchecked(78),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTransformFeedbackInterleavedComponents = unchecked(79),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCullDistances = unchecked(80),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxCombinedClipAndCullDistances = unchecked(81),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxSamples = unchecked(82),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshOutputVerticesNv = unchecked(83),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshOutputPrimitivesNv = unchecked(84),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshWorkGroupSizeXNv = unchecked(85),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshWorkGroupSizeYNv = unchecked(86),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshWorkGroupSizeZNv = unchecked(87),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTaskWorkGroupSizeXNv = unchecked(88),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTaskWorkGroupSizeYNv = unchecked(89),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTaskWorkGroupSizeZNv = unchecked(90),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshViewCountNv = unchecked(91),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshOutputVerticesExt = unchecked(92),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshOutputPrimitivesExt = unchecked(93),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshWorkGroupSizeXExt = unchecked(94),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshWorkGroupSizeYExt = unchecked(95),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshWorkGroupSizeZExt = unchecked(96),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTaskWorkGroupSizeXExt = unchecked(97),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTaskWorkGroupSizeYExt = unchecked(98),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxTaskWorkGroupSizeZExt = unchecked(99),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxMeshViewCountExt = unchecked(100),

		/// <summary>
		/// To be documented.
		/// </summary>
		MaxDualSourceDrawBuffersExt = unchecked(101),
	}
}
