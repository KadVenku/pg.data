using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SpeechEvent : AbstractGameObjectType
    {
        public readonly StringParameter Files = new StringParameter("files");
        public readonly StringParameter TextId = new StringParameter("text_id");
        public readonly StringParameter VolumePercent = new StringParameter("volume_percent");
    }
}
