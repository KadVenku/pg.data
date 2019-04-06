using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class TerrainDecalFx : AbstractGameObjectType
    {
        public readonly StringParameter RenderMode = new StringParameter("render_mode");
        public readonly StringParameter Intensity = new StringParameter("intensity");
        public readonly StringParameter Scale = new StringParameter("scale");
        public readonly StringParameter ZAngle = new StringParameter("z_angle");
        public readonly StringParameter FadeoutTime = new StringParameter("fadeout_time");
        public readonly StringParameter Category = new StringParameter("category");
        public readonly StringParameter Permanent = new StringParameter("permanent");
        public readonly StringParameter RandomRotate = new StringParameter("random_rotate");
        public readonly StringParameter UvSlot = new StringParameter("uv_slot");
        public readonly StringParameter RandomSizeOffset = new StringParameter("random_size_offset");
        public readonly StringParameter SlotScale = new StringParameter("slot_scale");
    }
}

