using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class ConcentrateFireAttackAbility : AbstractGameObjectType
    {
        public StringParameter TargetDamageIncreasePercent { get; } = new StringParameter("target_damage_increase_percent");
        public StringParameter TargetSpeedDecreasePercent { get; } = new StringParameter("target_speed_decrease_percent");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");

        public ConcentrateFireAttackAbility(string id) : base(id)
        {
        }
    }
}
