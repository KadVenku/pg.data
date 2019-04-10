using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BountyOnFactionAbility : AbstractGameObjectType
    {
        public StringParameter BountyPercentageAmount { get; } = new StringParameter("bounty_percentage_amount");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter TargetFactionNames { get; } = new StringParameter("target_faction_names");
        public StringParameter ApplyToAllAllies { get; } = new StringParameter("apply_to_all_allies");

        public BountyOnFactionAbility(string id) : base(id)
        {
        }
    }
}