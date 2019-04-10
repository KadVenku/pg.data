using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class InfectionAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter ShootAnim { get; } = new StringParameter("shoot_anim");
        public StringParameter SpawnFrame { get; } = new StringParameter("spawn_frame");
        public StringParameter SpawnBone { get; } = new StringParameter("spawn_bone");
        public StringParameter DamagePerSecond { get; } = new StringParameter("damage_per_second");
        public StringParameter DurationOfInfection { get; } = new StringParameter("duration_of_infection");
        public StringParameter ProjectileType { get; } = new StringParameter("projectile_type");
        public StringParameter InfectionCategoryMask { get; } = new StringParameter("infection_categorymask");
        public StringParameter DistanceToInfect { get; } = new StringParameter("distance_to_infect");
        public StringParameter InfectionParticle { get; } = new StringParameter("infection_particle");
        public StringParameter SecondsToInfect { get; } = new StringParameter("seconds_to_infect");
        
        public InfectionAbility(string id) : base(id)
        {
        }
    }
}