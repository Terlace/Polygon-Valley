using UnrealBuildTool;

public class JV1_ES_GabaritTarget : TargetRules
{
	public JV1_ES_GabaritTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("JV1_ES_Gabarit");
	}
}
