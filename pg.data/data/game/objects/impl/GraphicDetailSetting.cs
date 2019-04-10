using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GraphicDetailSetting : AbstractGameObjectType
    {
        public StringParameter ScreenResolutionWidth { get; } = new StringParameter("screenresolutionwidth");
        public StringParameter ScreenResolutionHeight { get; } = new StringParameter("screenresolutionheight");
        public StringParameter ScreenAALevel { get; } = new StringParameter("screenaalevel");
        public StringParameter TextureMipLevel { get; } = new StringParameter("texturemiplevel");
        public StringParameter ShaderDetailLevel { get; } = new StringParameter("shaderdetaillevel");
        public StringParameter WaterDetailLevel { get; } = new StringParameter("waterdetaillevel");
        public StringParameter ShadowDetail { get; } = new StringParameter("shadowdetail");
        public StringParameter ShadowVolumes { get; } = new StringParameter("shadowvolumes");
        public StringParameter SoftShadows { get; } = new StringParameter("softshadows");
        public StringParameter HeatDistortions { get; } = new StringParameter("heatdistortions");
        public StringParameter Bloom { get; } = new StringParameter("bloom");
        public StringParameter DynamicLighting { get; } = new StringParameter("dynamiclighting");
        public StringParameter ParticleDetail { get; } = new StringParameter("particledetail");
        public StringParameter MeshDetail { get; } = new StringParameter("meshdetail");
        public StringParameter EnvironmentDetail { get; } = new StringParameter("environmentdetail");
        
        public GraphicDetailSetting(string id) : base(id)
        {
        }
    }
}