using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class TradeRouteLines : AbstractGameObjectType
    {
        public readonly StringParameter Width = new StringParameter("width");
        public readonly StringParameter ColorZoomedOut = new StringParameter("color_zoomed_out");
        public readonly StringParameter ColorZoomedIn = new StringParameter("color_zoomed_in");
        public readonly StringParameter RenderMode = new StringParameter("render_mode");
        public readonly StringParameter TextureName = new StringParameter("texture_name");
        public readonly StringParameter SparkTextureName = new StringParameter("spark_texture_name");
    }
}
