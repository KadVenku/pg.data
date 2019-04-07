using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class LuckyShotAttackAbility : AbstractGameObjectType
    {
        public StringParameter TargetDamageIncreasePercent { get; } = new StringParameter("target_damage_increase_percent");
        public StringParameter TargetSpeedDecreasePercent { get; } = new StringParameter("target_speed_decrease_percent");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");

        public LuckyShotAttackAbility(string id) : base(id)
        {
        }
    }
}
