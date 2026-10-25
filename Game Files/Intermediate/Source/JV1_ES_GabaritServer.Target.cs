using UnrealBuildTool;

public class JV1_ES_GabaritServerTarget : TargetRules
{
	public JV1_ES_GabaritServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("JV1_ES_Gabarit");
	}
}
