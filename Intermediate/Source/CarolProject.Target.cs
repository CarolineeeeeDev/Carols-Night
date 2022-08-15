using UnrealBuildTool;

public class CarolProjectTarget : TargetRules
{
	public CarolProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CarolProject");
	}
}
