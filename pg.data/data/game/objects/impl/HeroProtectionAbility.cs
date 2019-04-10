using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class HeroProtectionAbility : AbstractGameObjectType
    {
        public StringParameter NeutralizationCostMultiplier { get; } = new StringParameter("neutralization_cost_multiplier");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        
        public HeroProtectionAbility(string id) : base(id)
        {
        }
    }
}