using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class DrainLifeAbility : AbstractGameObjectType
    {
        public StringParameter DurationInSeconds { get; } = new StringParameter("duration_in_seconds");
        public StringParameter ChargingTimeInSeconds { get; } = new StringParameter("charging_time_in_seconds");
        public StringParameter DamagePerSecond { get; } = new StringParameter("damage_per_second");
        public StringParameter DrainEffectName { get; } = new StringParameter("drain_effect_name");
        public StringParameter DrainSourceBoneName { get; } = new StringParameter("drain_source_bone_name");
        public StringParameter DrainTargetBoneName { get; } = new StringParameter("drain_target_bone_name");
        public StringParameter DrainRadius { get; } = new StringParameter("drain_radius");
        public StringParameter MaxDrainVictims { get; } = new StringParameter("max_drain_victims");
        public StringParameter ShouldHeal { get; } = new StringParameter("should_heal");
        
        public DrainLifeAbility(string id) : base(id)
        {
        }
    }
}