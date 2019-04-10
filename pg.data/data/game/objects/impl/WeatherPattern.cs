using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class WeatherPattern : AbstractGameObjectType
    {
        public StringParameter EmitterIntensity { get; } = new StringParameter("emitter_intensity");
        public StringParameter LightningIntensity { get; } = new StringParameter("lightning_intensity");
        public StringParameter Duration { get; } = new StringParameter("duration");
        public StringParameter EaseOutDuration { get; } = new StringParameter("ease_out_duration");
        public StringParameter FogPlaneInterpolationAlpha { get; } = new StringParameter("fog_plane_interpolation_alpha");

        public WeatherPattern(string id) : base(id)
        {
        }
    }
}
