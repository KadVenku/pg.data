using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GraphicDetailHardwareProfile : AbstractGameObjectType
    {
        public StringParameter DefaultGraphicDetailLevel { get; } = new StringParameter("defaultgraphicdetaillevel");
        public StringParameter GraphicDetailSettingName { get; } = new StringParameter("graphicdetailsettingname");
        public StringParameter CPUSpeed { get; } = new StringParameter("cpuspeed");
        public StringParameter TextureMemory { get; } = new StringParameter("texturememory");
        public StringParameter PixelShaderVersionHEX { get; } = new StringParameter("pixelshaderversionhex");
        public StringParameter VertexShaderVersionHEX { get; } = new StringParameter("vertexshaderversionhex");
        public StringParameter VendorIDHEX { get; } = new StringParameter("vendoridhex");
        public StringParameter DeviceIDListHEX { get; } = new StringParameter("deviceidlisthex");
        public StringParameter FillRateMpsPS13 { get; } = new StringParameter("fillratempsps13");
        public StringParameter FillRateMpsPS14 { get; } = new StringParameter("fillratempsps14");
        public StringParameter FillRateMpsPS20 { get; } = new StringParameter("fillratempsps20");
        public StringParameter VertexRateMvsVS11 { get; } = new StringParameter("vertexratemvsvs11");
        
        public GraphicDetailHardwareProfile(string id) : base(id)
        {
        }
    }
}