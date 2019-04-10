using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class IncomeStreamModAbility : AbstractGameObjectType
    {
        public StringParameter IncomeMultiplier { get; } = new StringParameter("income_multiplier");
        public StringParameter IncomeAdditiveValue { get; } = new StringParameter("income_additive_value");
        public StringParameter IntervalMultiplier { get; } = new StringParameter("interval_multiplier");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter TargetStreamSource { get; } = new StringParameter("target_stream_source");
        public StringParameter AffectsAllAlliedSources { get; } = new StringParameter("affects_all_allied_sources");
        public StringParameter ReverseApplicationLogic { get; } = new StringParameter("reverse_application_logic");
        
        public IncomeStreamModAbility(string id) : base(id)
        {
        }
    }
}