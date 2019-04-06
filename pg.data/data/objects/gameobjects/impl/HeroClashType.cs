using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class HeroClashType : AbstractGameObjectType
    {
        public readonly StringParameter ClashType = new StringParameter("clash_type");
        public readonly StringParameter ClashRange = new StringParameter("clash_range");
        public readonly StringParameter InvolvedHeroTypes = new StringParameter("involved_hero_types");
        public readonly StringParameter PlayConversationEvents = new StringParameter("play_conversation_events");
        public readonly StringParameter CombatDistance = new StringParameter("combat_distance");
        public readonly StringParameter DamageAmount = new StringParameter("damage_amount");
        public readonly StringParameter DamagePercentage = new StringParameter("damage_percentage");
        public readonly StringParameter FirstHeroDamageMultiplier = new StringParameter("first_hero_damage_multiplier");
        public readonly StringParameter SecondHeroDamageMultiplier = new StringParameter("second_hero_damage_multiplier");
        public readonly StringParameter FirstHeroWinExchangeChance = new StringParameter("first_hero_win_exchange_chance");
        public readonly StringParameter SecondHeroWinExchangeChance = new StringParameter("second_hero_win_exchange_chance");
        public readonly StringParameter FirstHeroType = new StringParameter("first_hero_type");
        public readonly StringParameter FirstHeroWinAnimType = new StringParameter("first_hero_win_anim_type");
        public readonly StringParameter FirstHeroLoseAnimType = new StringParameter("first_hero_lose_anim_type");
        public readonly StringParameter FirstHeroDrawAnimType = new StringParameter("first_hero_draw_anim_type");
        public readonly StringParameter FirstHeroConversationAnimType = new StringParameter("first_hero_conversation_anim_type");
        public readonly StringParameter SecondHeroType = new StringParameter("second_hero_type");
        public readonly StringParameter SecondHeroWinAnimType = new StringParameter("second_hero_win_anim_type");
        public readonly StringParameter SecondHeroLoseAnimType = new StringParameter("second_hero_lose_anim_type");
        public readonly StringParameter SecondHeroDrawAnimType = new StringParameter("second_hero_draw_anim_type");
        public readonly StringParameter SecondHeroConversationAnimType = new StringParameter("second_hero_conversation_anim_type");
        public readonly StringParameter FirstHeroWinSpeech = new StringParameter("first_hero_win_speech");
        public readonly StringParameter SecondHeroWinSpeech = new StringParameter("second_hero_win_speech");
        public readonly StringParameter ClashActions = new StringParameter("clash_actions");
    }
}
