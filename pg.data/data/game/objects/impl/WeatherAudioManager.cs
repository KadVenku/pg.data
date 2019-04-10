using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class WeatherAudioManager : AbstractGameObjectType
    {
        public StringParameter WeatherSfxEventLoop { get; } = new StringParameter("weather_sfxevent_loop");
        public StringParameter WeatherSfxEventIntermittent { get; } = new StringParameter("weather_sfxevent_intermittent");
        public StringParameter AmbientSfxEventIntermittent { get; } = new StringParameter("ambient_sfxevent_intermittent");
        
        public WeatherAudioManager(string id) : base(id)
        {
        }
    }
}