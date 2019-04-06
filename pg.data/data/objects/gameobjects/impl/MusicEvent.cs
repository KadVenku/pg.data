using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class MusicEvent : AbstractGameObjectType
    {
        public readonly StringParameter Files = new StringParameter("files");
        public readonly StringParameter VolumePercent = new StringParameter("volume_percent");
        public readonly StringParameter FadeInSeconds = new StringParameter("fade_in_seconds");
        public readonly StringParameter FadeOutPreviousSeconds = new StringParameter("fade_out_previous_seconds");
        public readonly StringParameter Loop = new StringParameter("loop");
        public readonly StringParameter MssInternalLoop = new StringParameter("mss_internal_loop");
    }
}
