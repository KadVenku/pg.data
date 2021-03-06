using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SpecialAbilityAction : AbstractGameObjectType
    {
        public StringParameter AbilityName { get; } = new StringParameter("ability_name");
        public StringParameter AbilityCooldownTimeInSecs { get; } = new StringParameter("ability_cooldown_time_in_secs");
        
        public SpecialAbilityAction(string id) : base(id)
        {
        }
    }
}