using UnrealBuildTool;

public class DeadFraternityTarget : TargetRules
{
	public DeadFraternityTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DeadFraternity");
	}
}
