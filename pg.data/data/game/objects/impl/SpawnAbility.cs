using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SpawnAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter ObjectType { get; } = new StringParameter("object_type");
        public StringParameter CreationDelayInSeconds { get; } = new StringParameter("creation_delay_in_seconds");
        public StringParameter RechargeTimeInSeconds { get; } = new StringParameter("recharge_time_in_seconds");
        public StringParameter SpawnBoneName { get; } = new StringParameter("spawn_bone_name");
        public StringParameter SelfDestructRadius { get; } = new StringParameter("self_destruct_radius");
        public StringParameter ExplosionType { get; } = new StringParameter("explosion_type");
        
        public SpawnAbility(string id) : base(id)
        {
        }
    }
}