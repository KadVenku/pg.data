using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public class DynamicTrackFx : AbstractGameObjectType
    {
        public StringParameter TextureName = new StringParameter("texture_name");
        public StringParameter Width = new StringParameter("width");
        public StringParameter Opacity = new StringParameter("opacity");
        public StringParameter SegmentLength = new StringParameter("segment_length");
        public StringParameter RenderMode = new StringParameter("render_mode");
        public StringParameter FadeBeginDistance = new StringParameter("fade_begin_distance");
        public StringParameter FadeEndDistance = new StringParameter("fade_end_distance");
        public StringParameter FadeDistancePerSecond = new StringParameter("fade_distance_per_second");
        public StringParameter MinGeometryLod = new StringParameter("min_geometry_lod");
    }
}
