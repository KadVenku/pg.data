using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class StunAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter StunTimeInSecs { get; } = new StringParameter("stun_time_in_secs");
        public StringParameter StunRange { get; } = new StringParameter("stun_range");
        public StringParameter StunTravelTimeInSecs { get; } = new StringParameter("stun_travel_time_in_secs");
        public StringParameter StunnedEffect { get; } = new StringParameter("stunned_effect");
        
        public StunAbility(string id) : base(id)
        {
        }
    }
}