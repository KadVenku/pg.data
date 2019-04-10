using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class CableAttackAbility : AbstractGameObjectType
    {
        public StringParameter CableWidth { get; } = new StringParameter("cable_width");
        public StringParameter CableFadeoutTime { get; } = new StringParameter("cable_fadeout_time");
        public StringParameter CableTextureName { get; } = new StringParameter("cable_texture_name");
        public StringParameter CableRenderMode { get; } = new StringParameter("cable_render_mode");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter DropPhaseDuration { get; } = new StringParameter("drop_phase_duration");
        public StringParameter PullPhaseDuration { get; } = new StringParameter("pull_phase_duration");
        public StringParameter ParalyzePhaseDuration { get; } = new StringParameter("paralyze_phase_duration");
        public StringParameter CableLengthFraction { get; } = new StringParameter("cable_length_fraction");
        public StringParameter CableEndSpeedFraction { get; } = new StringParameter("cable_end_speed_fraction");
        
        public CableAttackAbility(string id) : base(id)
        {
        }
    }
}