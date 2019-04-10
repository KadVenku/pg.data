using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class EnableAbilityAbility : AbstractGameObjectType
    {
        public StringParameter AbilityName { get; } = new StringParameter("ability_name");
        public StringParameter AffectsAllAllies { get; } = new StringParameter("affects_all_allies");
        
        public EnableAbilityAbility(string id) : base(id)
        {
        }
    }
}