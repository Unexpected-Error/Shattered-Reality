// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Shattered_RealityEditorTarget : TargetRules
{
	public Shattered_RealityEditorTarget( TargetInfo Target) : base(Target)
	{
		//UE4_PROJECT_STEAMSHIPPINGID = 480;
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Shattered_Reality" } );
		bUsesSteam = true;
	}
}
