using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class TerrainDecalFx : AbstractGameObjectType
    {
        public StringParameter RenderMode { get; } = new StringParameter("render_mode");
        public StringParameter Intensity { get; } = new StringParameter("intensity");
        public StringParameter Scale { get; } = new StringParameter("scale");
        public StringParameter ZAngle { get; } = new StringParameter("z_angle");
        public StringParameter FadeoutTime { get; } = new StringParameter("fadeout_time");
        public StringParameter Category { get; } = new StringParameter("category");
        public StringParameter Permanent { get; } = new StringParameter("permanent");
        public StringParameter RandomRotate { get; } = new StringParameter("random_rotate");
        public StringParameter UvSlot { get; } = new StringParameter("uv_slot");
        public StringParameter RandomSizeOffset { get; } = new StringParameter("random_size_offset");
        public StringParameter SlotScale { get; } = new StringParameter("slot_scale");

        public TerrainDecalFx(string id) : base(id)
        {
        }
    }
}

