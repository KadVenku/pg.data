using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class TractorBeamAttackAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter TargetSpeedDecreasePercent { get; } = new StringParameter("target_speed_decrease_percent");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public TractorBeamAttackAbility(string id) : base(id)
        {
        }
    }
}
