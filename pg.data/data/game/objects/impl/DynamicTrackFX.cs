using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public class DynamicTrackFx : AbstractGameObjectType
    {
        public StringParameter TextureName { get; } = new StringParameter("texture_name");
        public StringParameter Width { get; } = new StringParameter("width");
        public StringParameter Opacity { get; } = new StringParameter("opacity");
        public StringParameter SegmentLength { get; } = new StringParameter("segment_length");
        public StringParameter RenderMode { get; } = new StringParameter("render_mode");
        public StringParameter FadeBeginDistance { get; } = new StringParameter("fade_begin_distance");
        public StringParameter FadeEndDistance { get; } = new StringParameter("fade_end_distance");
        public StringParameter FadeDistancePerSecond { get; } = new StringParameter("fade_distance_per_second");
        public StringParameter MinGeometryLod { get; } = new StringParameter("min_geometry_lod");

        public DynamicTrackFx(string id) : base(id)
        {
        }
    }
}
