using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class HeroClashType : AbstractGameObjectType
    {
        public StringParameter ClashType { get; } = new StringParameter("clash_type");
        public StringParameter ClashRange { get; } = new StringParameter("clash_range");
        public StringParameter InvolvedHeroTypes { get; } = new StringParameter("involved_hero_types");
        public StringParameter PlayConversationEvents { get; } = new StringParameter("play_conversation_events");
        public StringParameter CombatDistance { get; } = new StringParameter("combat_distance");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamagePercentage { get; } = new StringParameter("damage_percentage");
        public StringParameter FirstHeroDamageMultiplier { get; } = new StringParameter("first_hero_damage_multiplier");
        public StringParameter SecondHeroDamageMultiplier { get; } = new StringParameter("second_hero_damage_multiplier");
        public StringParameter FirstHeroWinExchangeChance { get; } = new StringParameter("first_hero_win_exchange_chance");
        public StringParameter SecondHeroWinExchangeChance { get; } = new StringParameter("second_hero_win_exchange_chance");
        public StringParameter FirstHeroType { get; } = new StringParameter("first_hero_type");
        public StringParameter FirstHeroWinAnimType { get; } = new StringParameter("first_hero_win_anim_type");
        public StringParameter FirstHeroLoseAnimType { get; } = new StringParameter("first_hero_lose_anim_type");
        public StringParameter FirstHeroDrawAnimType { get; } = new StringParameter("first_hero_draw_anim_type");
        public StringParameter FirstHeroConversationAnimType { get; } = new StringParameter("first_hero_conversation_anim_type");
        public StringParameter SecondHeroType { get; } = new StringParameter("second_hero_type");
        public StringParameter SecondHeroWinAnimType { get; } = new StringParameter("second_hero_win_anim_type");
        public StringParameter SecondHeroLoseAnimType { get; } = new StringParameter("second_hero_lose_anim_type");
        public StringParameter SecondHeroDrawAnimType { get; } = new StringParameter("second_hero_draw_anim_type");
        public StringParameter SecondHeroConversationAnimType { get; } = new StringParameter("second_hero_conversation_anim_type");
        public StringParameter FirstHeroWinSpeech { get; } = new StringParameter("first_hero_win_speech");
        public StringParameter SecondHeroWinSpeech { get; } = new StringParameter("second_hero_win_speech");
        public StringParameter ClashActions { get; } = new StringParameter("clash_actions");

        public HeroClashType(string id) : base(id)
        {
        }
    }
}
