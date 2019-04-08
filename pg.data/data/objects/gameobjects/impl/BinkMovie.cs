using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class BinkMovie : AbstractGameObjectType
    {
        public StringParameter MovieFile { get; } = new StringParameter("movie_file");
        public StringParameter MovieStartFrame { get; } = new StringParameter("movie_start_frame");
        public StringParameter CaptionFrame { get; } = new StringParameter("caption_frame");
        public StringParameter CaptionDuration { get; } = new StringParameter("caption_duration");
        public StringParameter SfXEventFrame { get; } = new StringParameter("sfxevent_frame");
        public StringParameter SpeechEventFrame { get; } = new StringParameter("speechevent_frame");
        public StringParameter MusicEventFrame { get; } = new StringParameter("musicevent_frame");
        public StringParameter TextCrawlName { get; } = new StringParameter("text_crawl_name");
        public StringParameter TextCrawlStartFrame { get; } = new StringParameter("text_crawl_start_frame");
        public StringParameter TextCrawlEndFrame { get; } = new StringParameter("text_crawl_end_frame");
        public StringParameter HasCredits { get; } = new StringParameter("has_credits");
        public StringParameter Overlay { get; } = new StringParameter("overlay");
        public StringParameter Alpha { get; } = new StringParameter("alpha");
        public StringParameter CommandbarOffset { get; } = new StringParameter("commandbar_offset");
        public StringParameter PauseGameWhilePlaying { get; } = new StringParameter("pause_game_while_playing");
        public StringParameter HaltGameMusic { get; } = new StringParameter("halt_game_music");
        public StringParameter CannotSkip { get; } = new StringParameter("cannot_skip");
        
        public BinkMovie(string id) : base(id)
        {
        }
    }
}