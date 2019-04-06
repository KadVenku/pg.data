using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class EnhanceDefenseAbility : AbstractGameObjectType
    {
        public readonly StringParameter EnhancementPercentage = new StringParameter("enhancement_percentage");
        public readonly StringParameter StackingCategory = new StringParameter("stacking_category");
        public readonly StringParameter ApplyToAllAllies = new StringParameter("apply_to_all_allies");
    }
}
