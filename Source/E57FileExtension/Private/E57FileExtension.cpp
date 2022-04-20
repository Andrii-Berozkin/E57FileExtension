// Copyright Epic Games, Inc. All Rights Reserved.

#include "E57FileExtension.h"
#include <Core.h>
#include <Modules/ModuleManager.h>
#include <Interfaces/IPluginManager.h>

THIRD_PARTY_INCLUDES_START
#include <e57/E57Foundation.h>
THIRD_PARTY_INCLUDES_END

DEFINE_LOG_CATEGORY(E57Log);

#define LOCTEXT_NAMESPACE "FE57FileExtensionModule"

void FE57FileExtensionModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
	
	FString BaseDir = IPluginManager::Get().FindPlugin("E57FileExtension")->GetBaseDir();
	
	FString XercesDll = FPaths::Combine(*BaseDir, TEXT("Source/ThirdParty/DynamicLib/xerces-c_3_2.dll"));

	XercesHanlde = !XercesDll.IsEmpty() ? FPlatformProcess::GetDllHandle(*XercesDll) : nullptr;
	{
		if (XercesHanlde)
		{
			UE_LOG(E57Log, Display, TEXT("Xerces-c dll found and loaded"));
		}
		else
		{
			UE_LOG(E57Log, Display, TEXT("Xerces-c dll not found and not loaded"));
		}
	}

	//e57::ImageFile Imgf("foo.e57", "w");
}

void FE57FileExtensionModule::ShutdownModule()
{
	//FPlatformProcess::FreeDllHandle(XercesHanlde);
	XercesHanlde = nullptr;
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FE57FileExtensionModule, E57FileExtension)