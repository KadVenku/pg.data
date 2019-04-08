using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class BattlefieldModifierAbility : AbstractGameObjectType
    {
        public StringParameter FoWRevealRangeMultiplier { get; } = new StringParameter("fow_reveal_range_multiplier");
        public StringParameter ReinforcementTimeMultiplier { get; } = new StringParameter("reinforcement_time_multiplier");
        public StringParameter StealthDurationMultiplier { get; } = new StringParameter("stealth_duration_multiplier");
        public StringParameter CapturePointTimeMultiplier { get; } = new StringParameter("capture_point_time_multiplier");
        public StringParameter BaseShieldUpgrade { get; } = new StringParameter("base_shield_upgrade");
        public StringParameter EnableBombingRuns { get; } = new StringParameter("enable_bombing_runs");
        public StringParameter EnableSpecialWeapons { get; } = new StringParameter("enable_special_weapons");
        public StringParameter ApplyToAllAllies { get; } = new StringParameter("apply_to_all_allies");
        public StringParameter ReverseApplicationLogic { get; } = new StringParameter("reverse_application_logic");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter EnablePlanetaryBombardment { get; } = new StringParameter("enable_planetary_bombardment");
        public StringParameter ReinforcementDeployTimeMultiplier { get; } = new StringParameter("reinforcement_deploy_time_multiplier");
        public StringParameter DisableReinforcementVulnerability { get; } = new StringParameter("disable_reinforcement_vulnerability");
        
        public BattlefieldModifierAbility(string id) : base(id)
        {
        }
    }
}