using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BuzzDroidsAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter ObjectType { get; } = new StringParameter("object_type");
        public StringParameter ChaseRadius { get; } = new StringParameter("chase_radius");
        public StringParameter DamageRadius { get; } = new StringParameter("damage_radius");
        public StringParameter EnemyDamagePerSecond { get; } = new StringParameter("enemy_damage_per_second");
        public StringParameter OwnDamagePerSecond { get; } = new StringParameter("own_damage_per_second");
        public StringParameter ActivationTimeInSeconds { get; } = new StringParameter("activation_time_in_seconds");
        public StringParameter ActivateSfx { get; } = new StringParameter("activate_sfx");
        
        public BuzzDroidsAbility(string id) : base(id)
        {
        }
    }
}