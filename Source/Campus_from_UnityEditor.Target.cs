// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Campus_from_UnityEditorTarget : TargetRules
{
	public Campus_from_UnityEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Campus_from_Unity" } );
	}
}
