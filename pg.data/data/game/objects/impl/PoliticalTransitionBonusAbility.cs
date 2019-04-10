using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class PoliticalTransitionBonusAbility : AbstractGameObjectType
    {
        public StringParameter TimeReductionPercentage { get; } = new StringParameter("time_reduction_percentage");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        
        public PoliticalTransitionBonusAbility(string id) : base(id)
        {
        }
    }
}