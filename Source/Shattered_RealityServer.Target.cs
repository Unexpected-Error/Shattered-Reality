using UnrealBuildTool;
using System.Collections.Generic;

public class Shattered_RealityServerTarget : TargetRules //Change this line according to the name of your project
{
    public Shattered_RealityServerTarget(TargetInfo Target) : base(Target) //Change this line according to the name of your project
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.AddRange(new string[] { "Shattered_Reality" } ); //Change this line according to the name of your project
        bUsesSteam = true;
        GlobalDefinitions.Add("UE_PROJECT_STEAMGAMEDESC=\"Dedicated Server Tutorial\"" ); //match to desc in steamworks dedicated server (left hand drop down server)
        GlobalDefinitions.Add("UE4_PROJECT_STEAMPRODUCTNAME=\"spacewar\""); //steamworks stuff again
        GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"spacewar\"");
    }
}