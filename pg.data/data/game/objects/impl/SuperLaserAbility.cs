using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SuperLaserAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamagePerFrame { get; } = new StringParameter("damage_per_frame");
        public StringParameter FireFrame { get; } = new StringParameter("fire_frame");
        public StringParameter AttackAnimSubIndex { get; } = new StringParameter("attack_anim_sub_index");
        public StringParameter BeamTextureName { get; } = new StringParameter("beam_texture_name");
        public StringParameter NumAnimFrames { get; } = new StringParameter("num_anim_frames");
        public StringParameter LineWidth { get; } = new StringParameter("line_width");
        public StringParameter LineColor { get; } = new StringParameter("line_color");
        public StringParameter FaceTarget { get; } = new StringParameter("face_target");
        public StringParameter TurnRate { get; } = new StringParameter("turn_rate");
        public StringParameter FiringCone { get; } = new StringParameter("firing_cone");
        public StringParameter FireDelay { get; } = new StringParameter("fire_delay");
        public StringParameter FireContinuation { get; } = new StringParameter("fire_continuation");
        
        public SuperLaserAbility(string id) : base(id)
        {
        }
    }
}