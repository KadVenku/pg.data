using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ForceConfuseAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter ConfuseTimeInSecs { get; } = new StringParameter("confuse_time_in_secs");
        public StringParameter ConfuseRange { get; } = new StringParameter("confuse_range");
        public StringParameter ConfuseTravelTimeInSecs { get; } = new StringParameter("confuse_travel_time_in_secs");
        public StringParameter ConfuseEffect { get; } = new StringParameter("confuse_effect");
        
        public ForceConfuseAbility(string id) : base(id)
        {
        }
    }
}