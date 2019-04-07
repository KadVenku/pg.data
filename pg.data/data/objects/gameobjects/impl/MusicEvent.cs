using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class MusicEvent : AbstractGameObjectType
    {
        public StringParameter Files { get; } = new StringParameter("files");
        public StringParameter VolumePercent { get; } = new StringParameter("volume_percent");
        public StringParameter FadeInSeconds { get; } = new StringParameter("fade_in_seconds");
        public StringParameter FadeOutPreviousSeconds { get; } = new StringParameter("fade_out_previous_seconds");
        public StringParameter Loop { get; } = new StringParameter("loop");
        public StringParameter MssInternalLoop { get; } = new StringParameter("mss_internal_loop");

        public MusicEvent(string id) : base(id)
        {
        }
    }
}
