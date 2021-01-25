// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Shattered_RealityTarget : TargetRules
{
	public Shattered_RealityTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Shattered_Reality" } );
		bUsesSteam = true;
		GlobalDefinitions.Add("UE_PROJECT_STEAMGAMEDESC=\"Dedicated Server Tutorial\""); //match to desc in steamworks dedicated server (left hand drop down server)
		GlobalDefinitions.Add("UE4_PROJECT_STEAMPRODUCTNAME=\"spacewar\""); //steamworks stuff again
		GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"spacewar\"");
	}
}
