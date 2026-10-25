using UnrealBuildTool;

public class JV1_ES_GabaritEditorTarget : TargetRules
{
	public JV1_ES_GabaritEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("JV1_ES_Gabarit");
	}
}
