using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class LightningTypeManager : AbstractGameObjectType
    {
        public readonly StringParameter TextureName = new StringParameter("texture_name");
        public readonly StringParameter TextureRepeat = new StringParameter("texture_repeat");
        public readonly StringParameter TextureScroll = new StringParameter("texture_scroll");
        public readonly StringParameter WidthMax = new StringParameter("width_max");
        public readonly StringParameter WidthMin = new StringParameter("width_min");
        public readonly StringParameter Displace = new StringParameter("displace");
        public readonly StringParameter Detail = new StringParameter("detail");
        public readonly StringParameter ColorStart = new StringParameter("color_start");
        public readonly StringParameter ColorEnd = new StringParameter("color_end");
        public readonly StringParameter FadeoutTimeMax = new StringParameter("fadeout_time_max");
        public readonly StringParameter FadeoutTimeMin = new StringParameter("fadeout_time_min");
        public readonly StringParameter NumberBolts = new StringParameter("number_bolts");
        public readonly StringParameter BoltCreationIntervalMin = new StringParameter("bolt_creation_interval_min");
        public readonly StringParameter BoltCreationIntervalMax = new StringParameter("bolt_creation_interval_max");
        public readonly StringParameter Radius = new StringParameter("radius");
        public readonly StringParameter CyclesPerDistance = new StringParameter("cycles_per_distance");
        public readonly StringParameter RotationsPerSecond = new StringParameter("rotations_per_second");
        public readonly StringParameter UpdateAll = new StringParameter("update_all");
        public readonly StringParameter ReplaceFaded = new StringParameter("replace_faded");
    }
}
