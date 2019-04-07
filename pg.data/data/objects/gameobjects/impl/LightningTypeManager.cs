using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class LightningTypeManager : AbstractGameObjectType
    {
        public StringParameter TextureName { get; } = new StringParameter("texture_name");
        public StringParameter TextureRepeat { get; } = new StringParameter("texture_repeat");
        public StringParameter TextureScroll { get; } = new StringParameter("texture_scroll");
        public StringParameter WidthMax { get; } = new StringParameter("width_max");
        public StringParameter WidthMin { get; } = new StringParameter("width_min");
        public StringParameter Displace { get; } = new StringParameter("displace");
        public StringParameter Detail { get; } = new StringParameter("detail");
        public StringParameter ColorStart { get; } = new StringParameter("color_start");
        public StringParameter ColorEnd { get; } = new StringParameter("color_end");
        public StringParameter FadeoutTimeMax { get; } = new StringParameter("fadeout_time_max");
        public StringParameter FadeoutTimeMin { get; } = new StringParameter("fadeout_time_min");
        public StringParameter NumberBolts { get; } = new StringParameter("number_bolts");
        public StringParameter BoltCreationIntervalMin { get; } = new StringParameter("bolt_creation_interval_min");
        public StringParameter BoltCreationIntervalMax { get; } = new StringParameter("bolt_creation_interval_max");
        public StringParameter Radius { get; } = new StringParameter("radius");
        public StringParameter CyclesPerDistance { get; } = new StringParameter("cycles_per_distance");
        public StringParameter RotationsPerSecond { get; } = new StringParameter("rotations_per_second");
        public StringParameter UpdateAll { get; } = new StringParameter("update_all");
        public StringParameter ReplaceFaded { get; } = new StringParameter("replace_faded");

        public LightningTypeManager(string id) : base(id)
        {
        }
    }
}
