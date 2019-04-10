using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ForceCloakAbility : AbstractGameObjectType
    {
        public StringParameter ForceCloakColor { get; } = new StringParameter("force_cloak_color");
        public StringParameter ForceCloakTransitionInSecs { get; } = new StringParameter("force_cloak_transition_in_secs");
        
        public ForceCloakAbility(string id) : base(id)
        {
        }
    }
}