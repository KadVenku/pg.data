using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class RemoveCorruptionAbility : AbstractGameObjectType
    {
        public StringParameter NumCorruptionLevelsToRemove { get; } = new StringParameter("num_corruption_levels_to_remove");
        public StringParameter CorruptionRemovalCostMultiplier { get; } = new StringParameter("corruption_removal_cost_multiplier");
        public StringParameter CorruptionRemovalTimeInSecs { get; } = new StringParameter("corruption_removal_time_in_secs");
        
        public RemoveCorruptionAbility(string id) : base(id)
        {
        }
    }
}