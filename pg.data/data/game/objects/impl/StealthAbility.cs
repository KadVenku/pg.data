using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class StealthAbility : AbstractGameObjectType
    {
        public StringParameter StealthColor { get; } = new StringParameter("stealth_color");
        public StringParameter StealthTransitionTime { get; } = new StringParameter("stealth_transition_time");
        
        public StealthAbility(string id) : base(id)
        {
        }
    }
}