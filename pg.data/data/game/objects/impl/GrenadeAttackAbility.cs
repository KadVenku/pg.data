using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GrenadeAttackAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter RequiresDirectPlayerCommand { get; } = new StringParameter("requires_direct_player_command");
        public StringParameter GrenadeType { get; } = new StringParameter("grenade_type");
        public StringParameter GrenadeTossAnim { get; } = new StringParameter("grenade_toss_anim");
        public StringParameter GrenadeSpawnFrame { get; } = new StringParameter("grenade_spawn_frame");
        public StringParameter GrenadeSpawnBone { get; } = new StringParameter("grenade_spawn_bone");
        public StringParameter GrenadeExplodeTimerInSecs { get; } = new StringParameter("grenade_explode_timer_in_secs");
        
        public GrenadeAttackAbility(string id) : base(id)
        {
        }
    }
}