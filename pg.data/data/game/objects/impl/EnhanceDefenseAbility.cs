using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class EnhanceDefenseAbility : AbstractGameObjectType
    {
        public StringParameter EnhancementPercentage { get; } = new StringParameter("enhancement_percentage");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter ApplyToAllAllies { get; } = new StringParameter("apply_to_all_allies");

        public EnhanceDefenseAbility(string id) : base(id)
        {
        }
    }
}
