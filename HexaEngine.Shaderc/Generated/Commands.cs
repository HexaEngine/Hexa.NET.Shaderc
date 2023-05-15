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
	public unsafe partial class Shaderc
	{
		internal const string LibName = "shaderc_shared";

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compiler_initialize")]
		public static extern ShadercCompiler ShadercCompilerInitialize();

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compiler_release")]
		public static extern void ShadercCompilerRelease(ShadercCompiler shaderc_compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_initialize")]
		public static extern ShadercCompileOptions ShadercCompileOptionsInitialize();

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_clone")]
		public static extern ShadercCompileOptions ShadercCompileOptionsClone(ShadercCompileOptions options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_release")]
		public static extern void ShadercCompileOptionsRelease(ShadercCompileOptions options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_add_macro_definition")]
		public static extern void ShadercCompileOptionsAddMacroDefinition(ShadercCompileOptions options, byte* name, nuint name_length, byte* value, nuint value_length);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_source_language")]
		public static extern void ShadercCompileOptionsSetSourceLanguage(ShadercCompileOptions options, ShadercSourceLanguage lang);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_generate_debug_info")]
		public static extern void ShadercCompileOptionsSetGenerateDebugInfo(ShadercCompileOptions options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_optimization_level")]
		public static extern void ShadercCompileOptionsSetOptimizationLevel(ShadercCompileOptions options, ShadercOptimizationLevel level);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_forced_version_profile")]
		public static extern void ShadercCompileOptionsSetForcedVersionProfile(ShadercCompileOptions options, int version, ShadercProfile profile);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_include_callbacks")]
		public static extern void ShadercCompileOptionsSetIncludeCallbacks(ShadercCompileOptions options, ShadercIncludeResolveFn resolver, ShadercIncludeResultReleaseFn result_releaser, void* user_data);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_suppress_warnings")]
		public static extern void ShadercCompileOptionsSetSuppressWarnings(ShadercCompileOptions options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_target_env")]
		public static extern void ShadercCompileOptionsSetTargetEnv(ShadercCompileOptions options, ShadercTargetEnv target, uint version);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_target_spirv")]
		public static extern void ShadercCompileOptionsSetTargetSpirv(ShadercCompileOptions options, ShadercSpirvVersion version);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_warnings_as_errors")]
		public static extern void ShadercCompileOptionsSetWarningsAsErrors(ShadercCompileOptions options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_limit")]
		public static extern void ShadercCompileOptionsSetLimit(ShadercCompileOptions options, ShadercLimit limit, int value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_auto_bind_uniforms")]
		public static extern void ShadercCompileOptionsSetAutoBindUniforms(ShadercCompileOptions options, bool auto_bind);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_auto_combined_image_sampler")]
		public static extern void ShadercCompileOptionsSetAutoCombinedImageSampler(ShadercCompileOptions options, bool upgrade);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_hlsl_io_mapping")]
		public static extern void ShadercCompileOptionsSetHlslIoMapping(ShadercCompileOptions options, bool hlsl_iomap);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_hlsl_offsets")]
		public static extern void ShadercCompileOptionsSetHlslOffsets(ShadercCompileOptions options, bool hlsl_offsets);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_binding_base")]
		public static extern void ShadercCompileOptionsSetBindingBase(ShadercCompileOptions options, ShadercUniformKind kind, uint @base);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_binding_base_for_stage")]
		public static extern void ShadercCompileOptionsSetBindingBaseForStage(ShadercCompileOptions options, ShadercShaderKind shader_kind, ShadercUniformKind kind, uint @base);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_preserve_bindings")]
		public static extern void ShadercCompileOptionsSetPreserveBindings(ShadercCompileOptions options, bool preserve_bindings);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_auto_map_locations")]
		public static extern void ShadercCompileOptionsSetAutoMapLocations(ShadercCompileOptions options, bool auto_map);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage")]
		public static extern void ShadercCompileOptionsSetHlslRegisterSetAndBindingForStage(ShadercCompileOptions options, ShadercShaderKind shader_kind, byte* reg, byte* set, byte* binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding")]
		public static extern void ShadercCompileOptionsSetHlslRegisterSetAndBinding(ShadercCompileOptions options, byte* reg, byte* set, byte* binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_hlsl_functionality1")]
		public static extern void ShadercCompileOptionsSetHlslFunctionality1(ShadercCompileOptions options, bool enable);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_hlsl_16bit_types")]
		public static extern void ShadercCompileOptionsSetHlsl16bitTypes(ShadercCompileOptions options, bool enable);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_invert_y")]
		public static extern void ShadercCompileOptionsSetInvertY(ShadercCompileOptions options, bool enable);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_options_set_nan_clamp")]
		public static extern void ShadercCompileOptionsSetNanClamp(ShadercCompileOptions options, bool enable);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_into_spv")]
		public static extern ShadercCompilationResult ShadercCompileIntoSpv(ShadercCompiler compiler, byte* source_text, nuint source_text_size, ShadercShaderKind shader_kind, byte* input_file_name, byte* entry_point_name, ShadercCompileOptions additional_options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_into_spv_assembly")]
		public static extern ShadercCompilationResult ShadercCompileIntoSpvAssembly(ShadercCompiler compiler, byte* source_text, nuint source_text_size, ShadercShaderKind shader_kind, byte* input_file_name, byte* entry_point_name, ShadercCompileOptions additional_options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_compile_into_preprocessed_text")]
		public static extern ShadercCompilationResult ShadercCompileIntoPreprocessedText(ShadercCompiler compiler, byte* source_text, nuint source_text_size, ShadercShaderKind shader_kind, byte* input_file_name, byte* entry_point_name, ShadercCompileOptions additional_options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_assemble_into_spv")]
		public static extern ShadercCompilationResult ShadercAssembleIntoSpv(ShadercCompiler compiler, byte* source_assembly, nuint source_assembly_size, ShadercCompileOptions additional_options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_release")]
		public static extern void ShadercResultRelease(ShadercCompilationResult result);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_get_length")]
		public static extern nuint ShadercResultGetLength(ShadercCompilationResult result);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_get_num_warnings")]
		public static extern nuint ShadercResultGetNumWarnings(ShadercCompilationResult result);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_get_num_errors")]
		public static extern nuint ShadercResultGetNumErrors(ShadercCompilationResult result);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_get_compilation_status")]
		public static extern ShadercCompilationStatus ShadercResultGetCompilationStatus(ShadercCompilationResult shaderc_compilation_result_t);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_get_bytes")]
		public static extern byte* ShadercResultGetBytes(ShadercCompilationResult result);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_result_get_error_message")]
		public static extern byte* ShadercResultGetErrorMessage(ShadercCompilationResult result);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_get_spv_version")]
		public static extern void ShadercGetSpvVersion(uint* version, uint* revision);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "shaderc_parse_version_profile")]
		public static extern bool ShadercParseVersionProfile(byte* str, int* version, ShadercProfile* profile);

	}
}
