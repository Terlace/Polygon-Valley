using UnrealBuildTool;

public class JV1_ES_GabaritClientTarget : TargetRules
{
	public JV1_ES_GabaritClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("JV1_ES_Gabarit");
	}
}
