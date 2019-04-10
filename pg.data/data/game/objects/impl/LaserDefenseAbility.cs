using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class LaserDefenseAbility : AbstractGameObjectType
    {
        public StringParameter DefenseDurationInSecs { get; } = new StringParameter("defense_duration_in_secs");
        public StringParameter LaserColor { get; } = new StringParameter("laser_color");
        public StringParameter BoneNames { get; } = new StringParameter("bone_names");
        public StringParameter ProjectileTypesTargeted { get; } = new StringParameter("projectile_types_targeted");
        public StringParameter ProtectionRadius { get; } = new StringParameter("protection_radius");
        public StringParameter LaserBeamFrames { get; } = new StringParameter("laser_beam_frames");
        public StringParameter LaserBeamWidth { get; } = new StringParameter("laser_beam_width");
        public StringParameter ProjectileDistTravelled { get; } = new StringParameter("projectile_dist_travelled");
        public StringParameter LightningEffectName { get; } = new StringParameter("lightning_effect_name");
        public StringParameter LaserBeamTexture { get; } = new StringParameter("laser_beam_texture");
        public StringParameter RechargeTimeInSecs { get; } = new StringParameter("recharge_time_in_secs");
        public StringParameter ZapSfxEvent { get; } = new StringParameter("zap_sfxevent");
        
        public LaserDefenseAbility(string id) : base(id)
        {
        }
    }
}