using UnrealBuildTool;

public class DeadFraternityClientTarget : TargetRules
{
	public DeadFraternityClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DeadFraternity");
	}
}
