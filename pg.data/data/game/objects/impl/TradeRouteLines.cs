using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class TradeRouteLines : AbstractGameObjectType
    {
        public StringParameter Width { get; } = new StringParameter("width");
        public StringParameter ColorZoomedOut { get; } = new StringParameter("color_zoomed_out");
        public StringParameter ColorZoomedIn { get; } = new StringParameter("color_zoomed_in");
        public StringParameter RenderMode { get; } = new StringParameter("render_mode");
        public StringParameter TextureName { get; } = new StringParameter("texture_name");
        public StringParameter SparkTextureName { get; } = new StringParameter("spark_texture_name");

        public TradeRouteLines(string id) : base(id)
        {
        }
    }
}
