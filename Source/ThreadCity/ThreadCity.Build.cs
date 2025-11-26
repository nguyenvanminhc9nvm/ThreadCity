// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class ThreadCity : ModuleRules
{
	public ThreadCity(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new[]
		{
			"GameplayCameras","Core", "CoreUObject", "Engine", "InputCore", "AnimationWarpingRuntime", "UMG", "CommonUI", "CommonInput", "DeveloperSettings",
			"EnhancedInput", "MotionWarping", "PoseSearch", "GameplayAbilities", "GameplayTags", "AnimGraphRuntime",
			"GameplayTasks", "ModularGameplay", "Niagara", "NetCore","GameplayCameras", "PhysicsCore",
			"Iris", "Slate", "SlateCore", "GameFeatures", "ApplicationCore", "InputCore", "CommonInput", "PreLoadScreen", "ControlFlows", "HairStrandsCore",
			"MetasoundEngine", "ChaosVehicles"
		});
		
		// Editor-only modules for K2Node support
		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.AddRange(new[]
			{
				"KismetCompiler",
				"BlueprintGraph"
			});
		}
		
	}
}
