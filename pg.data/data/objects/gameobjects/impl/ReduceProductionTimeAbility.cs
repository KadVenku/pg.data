using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class ReduceProductionTimeAbility : AbstractGameObjectType
    {
        public StringParameter TimeReductionPercentage { get; } = new StringParameter("time_reduction_percentage");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter GalaxyWide { get; } = new StringParameter("galaxy_wide");
        public ReduceProductionTimeAbility(string id) : base(id)
        {
        }
    }
}
