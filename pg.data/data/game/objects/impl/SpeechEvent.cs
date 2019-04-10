using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SpeechEvent : AbstractGameObjectType
    {
        public StringParameter Files { get; } = new StringParameter("files");
        public StringParameter TextId { get; } = new StringParameter("text_id");
        public StringParameter VolumePercent { get; } = new StringParameter("volume_percent");

        public SpeechEvent(string id) : base(id)
        {
        }
    }
}
