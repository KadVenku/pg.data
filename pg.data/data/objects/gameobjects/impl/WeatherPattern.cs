using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class WeatherPattern : AbstractGameObjectType
    {
        public readonly StringParameter EmitterIntensity = new StringParameter("emitter_intensity");
        public readonly StringParameter LightningIntensity = new StringParameter("lightning_intensity");
        public readonly StringParameter Duration = new StringParameter("duration");
        public readonly StringParameter EaseOutDuration = new StringParameter("ease_out_duration");
        public readonly StringParameter FogPlaneInterpolationAlpha = new StringParameter("fog_plane_interpolation_alpha");
    }
}
