using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class StoryParser : AbstractGameObjectType
    {
        public StringParameter EventType { get; } = new StringParameter("event_type");
        public StringParameter EventParam1 { get; } = new StringParameter("event_param1");
        public StringParameter EventParam2 { get; } = new StringParameter("event_param2");
        public StringParameter EventParam3 { get; } = new StringParameter("event_param3");
        public StringParameter EventParam4 { get; } = new StringParameter("event_param4");
        public StringParameter EventParam5 { get; } = new StringParameter("event_param5");
        public StringParameter EventParam6 { get; } = new StringParameter("event_param6");
        public StringParameter EventParam7 { get; } = new StringParameter("event_param7");
        public StringParameter EventFilter { get; } = new StringParameter("event_filter");
        public StringParameter RewardType { get; } = new StringParameter("reward_type");
        public StringParameter RewardParam1 { get; } = new StringParameter("reward_param1");
        public StringParameter RewardParam2 { get; } = new StringParameter("reward_param2");
        public StringParameter RewardParam3 { get; } = new StringParameter("reward_param3");
        public StringParameter RewardParam4 { get; } = new StringParameter("reward_param4");
        public StringParameter RewardParam5 { get; } = new StringParameter("reward_param5");
        public StringParameter RewardParam6 { get; } = new StringParameter("reward_param6");
        public StringParameter RewardParam7 { get; } = new StringParameter("reward_param7");
        public StringParameter RewardParam8 { get; } = new StringParameter("reward_param8");
        public StringParameter RewardParam9 { get; } = new StringParameter("reward_param9");
        public StringParameter RewardParam10 { get; } = new StringParameter("reward_param10");
        public StringParameter RewardParam11 { get; } = new StringParameter("reward_param11");
        public StringParameter RewardParam12 { get; } = new StringParameter("reward_param12");
        public StringParameter RewardParam13 { get; } = new StringParameter("reward_param13");
        public StringParameter RewardParam14 { get; } = new StringParameter("reward_param14");
        public StringParameter RewardParamList { get; } = new StringParameter("reward_param_list");
        public StringParameter Prereq { get; } = new StringParameter("prereq");
        public StringParameter StoryDialog { get; } = new StringParameter("story_dialog");
        public StringParameter StoryChapter { get; } = new StringParameter("story_chapter");
        public StringParameter StoryVar { get; } = new StringParameter("story_var");
        public StringParameter StoryTag { get; } = new StringParameter("story_tag");
        public StringParameter StoryIncoming { get; } = new StringParameter("story_incoming");
        public StringParameter StoryDialogPopup { get; } = new StringParameter("story_dialog_popup");
        public StringParameter StoryDialogSfx { get; } = new StringParameter("story_dialog_sfx");
        public StringParameter Multiplayer { get; } = new StringParameter("multiplayer");
        public StringParameter InactiveDelay { get; } = new StringParameter("inactive_delay");
        public StringParameter RewardPosition { get; } = new StringParameter("reward_position");
        public StringParameter Branch { get; } = new StringParameter("branch");
        public StringParameter Perpetual { get; } = new StringParameter("perpetual");
        public StringParameter Timeout { get; } = new StringParameter("timeout");
        
        public StoryParser(string id) : base(id)
        {
        }
    }
}