using UnrealBuildTool;

public class DeadFraternityEditorTarget : TargetRules
{
	public DeadFraternityEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DeadFraternity");
	}
}
