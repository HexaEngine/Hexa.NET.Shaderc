// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;

namespace HexaEngine.Shaderc
{
	public enum ShadercTargetEnv
	{
		Vulkan = unchecked(0),
		Opengl = unchecked(1),
		OpenglCompat = unchecked(2),
		Webgpu = unchecked(3),
		Default = Vulkan,
	}

	public enum ShadercEnvVersion
	{
		Vulkan10 = unchecked((int)((1u<<22))),
		Vulkan11 = unchecked((int)((1u<<22)|(1<<12))),
		Vulkan12 = unchecked((int)((1u<<22)|(2<<12))),
		Vulkan13 = unchecked((int)((1u<<22)|(3<<12))),
		Opengl45 = unchecked(450),
		Webgpu = unchecked(451),
	}

	public enum ShadercSpirvVersion
	{
		_10 = unchecked((int)0x010000u),
		_11 = unchecked((int)0x010100u),
		_12 = unchecked((int)0x010200u),
		_13 = unchecked((int)0x010300u),
		_14 = unchecked((int)0x010400u),
		_15 = unchecked((int)0x010500u),
		_16 = unchecked((int)0x010600u),
	}

	public enum ShadercCompilationStatus
	{
		Success = unchecked(0),
		InvalidStage = unchecked(1),
		CompilationError = unchecked(2),
		InternalError = unchecked(3),
		NullResultObject = unchecked(4),
		InvalidAssembly = unchecked(5),
		ValidationError = unchecked(6),
		TransformationError = unchecked(7),
		ConfigurationError = unchecked(8),
	}

	public enum ShadercSourceLanguage
	{
		Glsl = unchecked(0),
		Hlsl = unchecked(1),
	}

	public enum ShadercShaderKind
	{
		ShadercVertexShader = unchecked(0),
		ShadercFragmentShader = unchecked(1),
		ShadercComputeShader = unchecked(2),
		ShadercGeometryShader = unchecked(3),
		ShadercTessControlShader = unchecked(4),
		ShadercTessEvaluationShader = unchecked(5),
		ShadercGlslVertexShader = ShadercVertexShader,
		ShadercGlslFragmentShader = ShadercFragmentShader,
		ShadercGlslComputeShader = ShadercComputeShader,
		ShadercGlslGeometryShader = ShadercGeometryShader,
		ShadercGlslTessControlShader = ShadercTessControlShader,
		ShadercGlslTessEvaluationShader = ShadercTessEvaluationShader,
		ShadercGlslInferFromSource = unchecked(6),
		ShadercGlslDefaultVertexShader = unchecked(7),
		ShadercGlslDefaultFragmentShader = unchecked(8),
		ShadercGlslDefaultComputeShader = unchecked(9),
		ShadercGlslDefaultGeometryShader = unchecked(10),
		ShadercGlslDefaultTessControlShader = unchecked(11),
		ShadercGlslDefaultTessEvaluationShader = unchecked(12),
		ShadercSpirvAssembly = unchecked(13),
		ShadercRaygenShader = unchecked(14),
		ShadercAnyhitShader = unchecked(15),
		ShadercClosesthitShader = unchecked(16),
		ShadercMissShader = unchecked(17),
		ShadercIntersectionShader = unchecked(18),
		ShadercCallableShader = unchecked(19),
		ShadercGlslRaygenShader = ShadercRaygenShader,
		ShadercGlslAnyhitShader = ShadercAnyhitShader,
		ShadercGlslClosesthitShader = ShadercClosesthitShader,
		ShadercGlslMissShader = ShadercMissShader,
		ShadercGlslIntersectionShader = ShadercIntersectionShader,
		ShadercGlslCallableShader = ShadercCallableShader,
		ShadercGlslDefaultRaygenShader = unchecked(20),
		ShadercGlslDefaultAnyhitShader = unchecked(21),
		ShadercGlslDefaultClosesthitShader = unchecked(22),
		ShadercGlslDefaultMissShader = unchecked(23),
		ShadercGlslDefaultIntersectionShader = unchecked(24),
		ShadercGlslDefaultCallableShader = unchecked(25),
		ShadercTaskShader = unchecked(26),
		ShadercMeshShader = unchecked(27),
		ShadercGlslTaskShader = ShadercTaskShader,
		ShadercGlslMeshShader = ShadercMeshShader,
		ShadercGlslDefaultTaskShader = unchecked(28),
		ShadercGlslDefaultMeshShader = unchecked(29),
	}

	public enum ShadercProfile
	{
		None = unchecked(0),
		Core = unchecked(1),
		Compatibility = unchecked(2),
		Es = unchecked(3),
	}

	public enum ShadercOptimizationLevel
	{
		Zero = unchecked(0),
		Size = unchecked(1),
		Performance = unchecked(2),
	}

	public enum ShadercLimit
	{
		MaxLights = unchecked(0),
		MaxClipPlanes = unchecked(1),
		MaxTextureUnits = unchecked(2),
		MaxTextureCoords = unchecked(3),
		MaxVertexAttribs = unchecked(4),
		MaxVertexUniformComponents = unchecked(5),
		MaxVaryingFloats = unchecked(6),
		MaxVertexTextureImageUnits = unchecked(7),
		MaxCombinedTextureImageUnits = unchecked(8),
		MaxTextureImageUnits = unchecked(9),
		MaxFragmentUniformComponents = unchecked(10),
		MaxDrawBuffers = unchecked(11),
		MaxVertexUniformVectors = unchecked(12),
		MaxVaryingVectors = unchecked(13),
		MaxFragmentUniformVectors = unchecked(14),
		MaxVertexOutputVectors = unchecked(15),
		MaxFragmentInputVectors = unchecked(16),
		MinProgramTexelOffset = unchecked(17),
		MaxProgramTexelOffset = unchecked(18),
		MaxClipDistances = unchecked(19),
		MaxComputeWorkGroupCountX = unchecked(20),
		MaxComputeWorkGroupCountY = unchecked(21),
		MaxComputeWorkGroupCountZ = unchecked(22),
		MaxComputeWorkGroupSizeX = unchecked(23),
		MaxComputeWorkGroupSizeY = unchecked(24),
		MaxComputeWorkGroupSizeZ = unchecked(25),
		MaxComputeUniformComponents = unchecked(26),
		MaxComputeTextureImageUnits = unchecked(27),
		MaxComputeImageUniforms = unchecked(28),
		MaxComputeAtomicCounters = unchecked(29),
		MaxComputeAtomicCounterBuffers = unchecked(30),
		MaxVaryingComponents = unchecked(31),
		MaxVertexOutputComponents = unchecked(32),
		MaxGeometryInputComponents = unchecked(33),
		MaxGeometryOutputComponents = unchecked(34),
		MaxFragmentInputComponents = unchecked(35),
		MaxImageUnits = unchecked(36),
		MaxCombinedImageUnitsAndFragmentOutputs = unchecked(37),
		MaxCombinedShaderOutputResources = unchecked(38),
		MaxImageSamples = unchecked(39),
		MaxVertexImageUniforms = unchecked(40),
		MaxTessControlImageUniforms = unchecked(41),
		MaxTessEvaluationImageUniforms = unchecked(42),
		MaxGeometryImageUniforms = unchecked(43),
		MaxFragmentImageUniforms = unchecked(44),
		MaxCombinedImageUniforms = unchecked(45),
		MaxGeometryTextureImageUnits = unchecked(46),
		MaxGeometryOutputVertices = unchecked(47),
		MaxGeometryTotalOutputComponents = unchecked(48),
		MaxGeometryUniformComponents = unchecked(49),
		MaxGeometryVaryingComponents = unchecked(50),
		MaxTessControlInputComponents = unchecked(51),
		MaxTessControlOutputComponents = unchecked(52),
		MaxTessControlTextureImageUnits = unchecked(53),
		MaxTessControlUniformComponents = unchecked(54),
		MaxTessControlTotalOutputComponents = unchecked(55),
		MaxTessEvaluationInputComponents = unchecked(56),
		MaxTessEvaluationOutputComponents = unchecked(57),
		MaxTessEvaluationTextureImageUnits = unchecked(58),
		MaxTessEvaluationUniformComponents = unchecked(59),
		MaxTessPatchComponents = unchecked(60),
		MaxPatchVertices = unchecked(61),
		MaxTessGenLevel = unchecked(62),
		MaxViewports = unchecked(63),
		MaxVertexAtomicCounters = unchecked(64),
		MaxTessControlAtomicCounters = unchecked(65),
		MaxTessEvaluationAtomicCounters = unchecked(66),
		MaxGeometryAtomicCounters = unchecked(67),
		MaxFragmentAtomicCounters = unchecked(68),
		MaxCombinedAtomicCounters = unchecked(69),
		MaxAtomicCounterBindings = unchecked(70),
		MaxVertexAtomicCounterBuffers = unchecked(71),
		MaxTessControlAtomicCounterBuffers = unchecked(72),
		MaxTessEvaluationAtomicCounterBuffers = unchecked(73),
		MaxGeometryAtomicCounterBuffers = unchecked(74),
		MaxFragmentAtomicCounterBuffers = unchecked(75),
		MaxCombinedAtomicCounterBuffers = unchecked(76),
		MaxAtomicCounterBufferSize = unchecked(77),
		MaxTransformFeedbackBuffers = unchecked(78),
		MaxTransformFeedbackInterleavedComponents = unchecked(79),
		MaxCullDistances = unchecked(80),
		MaxCombinedClipAndCullDistances = unchecked(81),
		MaxSamples = unchecked(82),
		MaxMeshOutputVerticesNv = unchecked(83),
		MaxMeshOutputPrimitivesNv = unchecked(84),
		MaxMeshWorkGroupSizeXNv = unchecked(85),
		MaxMeshWorkGroupSizeYNv = unchecked(86),
		MaxMeshWorkGroupSizeZNv = unchecked(87),
		MaxTaskWorkGroupSizeXNv = unchecked(88),
		MaxTaskWorkGroupSizeYNv = unchecked(89),
		MaxTaskWorkGroupSizeZNv = unchecked(90),
		MaxMeshViewCountNv = unchecked(91),
		MaxMeshOutputVerticesExt = unchecked(92),
		MaxMeshOutputPrimitivesExt = unchecked(93),
		MaxMeshWorkGroupSizeXExt = unchecked(94),
		MaxMeshWorkGroupSizeYExt = unchecked(95),
		MaxMeshWorkGroupSizeZExt = unchecked(96),
		MaxTaskWorkGroupSizeXExt = unchecked(97),
		MaxTaskWorkGroupSizeYExt = unchecked(98),
		MaxTaskWorkGroupSizeZExt = unchecked(99),
		MaxMeshViewCountExt = unchecked(100),
		MaxDualSourceDrawBuffersExt = unchecked(101),
	}

	public enum ShadercUniformKind
	{
		Image = unchecked(0),
		Sampler = unchecked(1),
		Texture = unchecked(2),
		Buffer = unchecked(3),
		StorageBuffer = unchecked(4),
		UnorderedAccessView = unchecked(5),
	}

	public enum ShadercIncludeType
	{
		Relative = unchecked(0),
		Standard = unchecked(1),
	}

}
