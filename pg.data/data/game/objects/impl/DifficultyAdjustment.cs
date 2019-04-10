using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class DifficultyAdjustment : AbstractGameObjectType
    {
        public StringParameter CreditMultiplier { get; } = new StringParameter("credit_multiplier");
        public StringParameter DamageMultiplier { get; } = new StringParameter("damage_multiplier");
        public StringParameter GalacticBuildTimeMultiplier { get; } = new StringParameter("galactic_build_time_multiplier");
        public StringParameter LandBuildTimeMultiplier { get; } = new StringParameter("land_build_time_multiplier");
        public StringParameter SpaceBuildTimeMultiplier { get; } = new StringParameter("space_build_time_multiplier");
        public StringParameter GalacticAiContrastMultiplier { get; } = new StringParameter("galactic_ai_contrast_multiplier");
        public StringParameter SpaceAiContrastMultiplier { get; } = new StringParameter("space_ai_contrast_multiplier");
        public StringParameter LandAiContrastMultiplier { get; } = new StringParameter("land_ai_contrast_multiplier");
        public StringParameter GalacticAiGoalCycleSleepDuration { get; } = new StringParameter("galactic_ai_goal_cycle_sleep_duration");
        public StringParameter SpaceAiGoalCycleSleepDuration { get; } = new StringParameter("space_ai_goal_cycle_sleep_duration");
        public StringParameter LandAiGoalCycleSleepDuration { get; } = new StringParameter("land_ai_goal_cycle_sleep_duration");
        public StringParameter BribeCostMultiplier { get; } = new StringParameter("bribe_cost_multiplier");
        public StringParameter HealthMultiplier { get; } = new StringParameter("health_multiplier");
        public StringParameter ShieldMultiplier { get; } = new StringParameter("shield_multiplier");
        
        public DifficultyAdjustment(string id) : base(id)
        {
        }
    }
}