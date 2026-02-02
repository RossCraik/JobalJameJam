using UnrealBuildTool;

public class DeadFraternityServerTarget : TargetRules
{
	public DeadFraternityServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DeadFraternity");
	}
}
