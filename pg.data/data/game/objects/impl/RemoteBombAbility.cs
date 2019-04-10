using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class RemoteBombAbility : AbstractGameObjectType
    {
        public StringParameter BombType { get; } = new StringParameter("bomb_type");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter TossAnim { get; } = new StringParameter("toss_anim");
        public StringParameter SpawnFrame { get; } = new StringParameter("spawn_frame");
        public StringParameter SpawnBone { get; } = new StringParameter("spawn_bone");
        
        public RemoteBombAbility(string id) : base(id)
        {
        }
    }
}