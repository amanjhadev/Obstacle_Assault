// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Object_Assault1 : ModuleRules
{
	public Object_Assault1(ReadOnlyTargetRules Target) : base(Target)
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
			"Object_Assault1",
			"Object_Assault1/Variant_Platforming",
			"Object_Assault1/Variant_Platforming/Animation",
			"Object_Assault1/Variant_Combat",
			"Object_Assault1/Variant_Combat/AI",
			"Object_Assault1/Variant_Combat/Animation",
			"Object_Assault1/Variant_Combat/Gameplay",
			"Object_Assault1/Variant_Combat/Interfaces",
			"Object_Assault1/Variant_Combat/UI",
			"Object_Assault1/Variant_SideScrolling",
			"Object_Assault1/Variant_SideScrolling/AI",
			"Object_Assault1/Variant_SideScrolling/Gameplay",
			"Object_Assault1/Variant_SideScrolling/Interfaces",
			"Object_Assault1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
