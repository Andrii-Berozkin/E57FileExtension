// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class E57FileExtensionLib : ModuleRules
{
	public E57FileExtensionLib(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		bool bBuildE57InPluginModule = false;

		if(bBuildE57InPluginModule == true)
        {
			LoadE57(Target);
        }

	}

	public void LoadE57(ReadOnlyTargetRules Target)
    {
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			//Use in Plugin module
			string IncludeDir = "$(PluginDir)/Source/ThirdParty/Include";
			string StaticLibDir = "$(PluginDir)/Source/ThirdParty/lib";
			string DynamicLibDir = "$(PluginDir)/Source/ThirdParty/DynamicLib";
			string E57Dir = "$(PluginDir)/Source/ThirdParty/LibE57_x64-windows";

			//Use in Project module
			//string IncludeDir = "$(ProjectDir)/Plugins/E57FileExtension/Source/ThirdParty/Include";
			//string StaticLibDir = "$(ProjectDir)/Plugins/E57FileExtension/Source/ThirdParty/lib";
			//string DynamicLibDir = "$(ProjectDir)/Plugins/E57FileExtension/Source/ThirdParty/DynamicLib";
			//string E57Dir = "$(ProjectDir)/Plugins/E57FileExtension/Source/ThirdParty/LibE57_x64-windows";

			
			//Add headers from include
			{
				//Add include dir which contains boost, xerces-c, etc. .hpp
				PublicIncludePaths.Add(IncludeDir);

				//Add include dir for e57
				PublicIncludePaths.Add(Path.Combine(E57Dir, "include"));
			}

			//Add boost static library
			{

				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_atomic-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_chrono-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_container-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_context-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_contract-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_coroutine-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_date_time-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_exception-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_fiber-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_filesystem-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_graph-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_iostreams-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_json-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_locale-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_log_setup-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_log-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_math_c99f-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_math_c99l-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_math_c99-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_math_tr1f-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_math_tr1l-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_math_tr1-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_nowide-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_program_options-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_python310-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_random-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_regex-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_serialization-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_stacktrace_noop-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_stacktrace_windbg_cached-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_stacktrace_windbg-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_system-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_thread-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_timer-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_type_erasure-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_unit_test_framework-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_wave-vc140-mt.lib"));
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "boost_wserialization-vc140-mt.lib"));
			}

			//Add E57 static library
			{
				PublicAdditionalLibraries.Add(Path.Combine(E57Dir, "lib/E57RefImpl.lib"));
			}

			//Add Xerces-c static library
			{
				PublicAdditionalLibraries.Add(Path.Combine(StaticLibDir, "xerces-c_3.lib"));
			}

			//Add Xerces-c dynamic library
			{
				//Add possibility to manual load dll
				PublicDelayLoadDLLs.Add(Path.Combine(DynamicLibDir, "xerces-c_3_2.dll"));


				//Add .dll lib to Dependencies and assign to automatation copy to Build Dir
				RuntimeDependencies.Add("$(TargetOutputDir)/xerces-c_3_2.dll", Path.Combine(DynamicLibDir, "xerces-c_3_2.dll"));
			}
		}
	}

}
