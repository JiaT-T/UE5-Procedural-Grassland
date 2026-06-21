// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Proceduarl_Grass : ModuleRules
{
	public Proceduarl_Grass(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Proceduarl_Grass",
			"Proceduarl_Grass/Variant_Platforming",
			"Proceduarl_Grass/Variant_Platforming/Animation",
			"Proceduarl_Grass/Variant_Combat",
			"Proceduarl_Grass/Variant_Combat/AI",
			"Proceduarl_Grass/Variant_Combat/Animation",
			"Proceduarl_Grass/Variant_Combat/Gameplay",
			"Proceduarl_Grass/Variant_Combat/Interfaces",
			"Proceduarl_Grass/Variant_Combat/UI",
			"Proceduarl_Grass/Variant_SideScrolling",
			"Proceduarl_Grass/Variant_SideScrolling/AI",
			"Proceduarl_Grass/Variant_SideScrolling/Gameplay",
			"Proceduarl_Grass/Variant_SideScrolling/Interfaces",
			"Proceduarl_Grass/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
