using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class LightSource : AbstractGameObjectType
    {
        public StringParameter Diffuse { get; } = new StringParameter("diffuse");
        public StringParameter Intensity { get; } = new StringParameter("intensity");
        public StringParameter Radius { get; } = new StringParameter("radius");
        public StringParameter FalloffStart { get; } = new StringParameter("falloff_start");
        public StringParameter AutoDestructTime { get; } = new StringParameter("auto_destruct_time");
        public StringParameter AutoDestructFadeTime { get; } = new StringParameter("auto_destruct_fade_time");
        public StringParameter BlobRadius { get; } = new StringParameter("blob_radius");
        public StringParameter BlobColor { get; } = new StringParameter("blob_color");
        public StringParameter BlobIntensity { get; } = new StringParameter("blob_intensity");
        
        public LightSource(string id) : base(id)
        {
        }
    }
}