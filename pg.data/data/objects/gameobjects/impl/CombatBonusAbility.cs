using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class CombatBonusAbility : AbstractGameObjectType
    {
        public StringParameter HealthBonusPercentage { get; } = new StringParameter("health_bonus_percentage");
        public StringParameter DamageBonusPercentage { get; } = new StringParameter("damage_bonus_percentage");
        public StringParameter EnergyPoolBonusPercentage { get; } = new StringParameter("energy_pool_bonus_percentage");
        public StringParameter ShieldBonusPercentage { get; } = new StringParameter("shield_bonus_percentage");
        public StringParameter MovementSpeedBonusPercentage { get; } = new StringParameter("movement_speed_bonus_percentage");
        public StringParameter DefenseBonusPercentage { get; } = new StringParameter("defense_bonus_percentage");
        public StringParameter AbilityRechargeBonusPercentage { get; } = new StringParameter("ability_recharge_bonus_percentage");
        public StringParameter FireRangeBonusPercentage { get; } = new StringParameter("fire_range_bonus_percentage");
        public StringParameter TacticalBuildTimeBonusPercentage { get; } = new StringParameter("tactical_build_time_bonus_percentage");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        public StringParameter SpecificFaction { get; } = new StringParameter("specific_faction");

        public CombatBonusAbility(string id) : base(id)
        {
        }
    }
}
