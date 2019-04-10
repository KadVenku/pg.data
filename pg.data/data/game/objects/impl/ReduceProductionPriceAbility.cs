using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ReduceProductionPriceAbility : AbstractGameObjectType
    {
        public StringParameter PriceReductionPercentage { get; } = new StringParameter("price_reduction_percentage");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter GalaxyWide { get; } = new StringParameter("galaxy_wide");
        public ReduceProductionPriceAbility(string id) : base(id)
        {
        }
    }
}
