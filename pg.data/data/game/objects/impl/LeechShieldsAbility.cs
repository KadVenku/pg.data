using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class LeechShieldsAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DurationInSecs { get; } = new StringParameter("duration_in_secs");
        public StringParameter ShieldDamagePerSecond { get; } = new StringParameter("shield_damage_per_second");
        public StringParameter DamageMultiplier { get; } = new StringParameter("damage_multiplier");
        public StringParameter BeamColor { get; } = new StringParameter("beam_color");
        public StringParameter BeamBoneName { get; } = new StringParameter("beam_bone_name");
        public StringParameter BeamFrames { get; } = new StringParameter("beam_frames");
        public StringParameter BeamWidth { get; } = new StringParameter("beam_width");
        public StringParameter BeamTextureName { get; } = new StringParameter("beam_texture_name");
        public StringParameter BeamEffectName { get; } = new StringParameter("beam_effect_name");
        public StringParameter LeechEffect { get; } = new StringParameter("leech_effect");
        
        public LeechShieldsAbility(string id) : base(id)
        {
        }
    }
}