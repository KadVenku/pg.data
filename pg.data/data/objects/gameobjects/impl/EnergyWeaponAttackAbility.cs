using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class EnergyWeaponAttackAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamagePerFrame { get; } = new StringParameter("damage_per_frame");
        public StringParameter BeamColor { get; } = new StringParameter("beam_color");
        public StringParameter BeamFrames { get; } = new StringParameter("beam_frames");
        public StringParameter BeamWidth { get; } = new StringParameter("beam_width");
        public StringParameter BeamTexture { get; } = new StringParameter("beam_texture");
        public EnergyWeaponAttackAbility(string id) : base(id)
        {
        }
    }
}
