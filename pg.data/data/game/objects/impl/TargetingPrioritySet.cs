using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class TargetingPrioritySet : AbstractGameObjectType
    {
        public StringParameter AttackPriorities { get; } = new StringParameter("attack_priorities");
        public StringParameter UnitExclusions { get; } = new StringParameter("unit_exclusions");
        public StringParameter CategoryExclusions { get; } = new StringParameter("category_exclusions");
        public StringParameter PropertyExclusions { get; } = new StringParameter("property_exclusions");
        public StringParameter HardPointPriorities { get; } = new StringParameter("hard_point_priorities");
        public StringParameter HardPointExclusions { get; } = new StringParameter("hard_point_exclusions");
        
        public TargetingPrioritySet(string id) : base(id)
        {
        }
    }
}