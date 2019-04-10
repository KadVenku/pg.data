using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class CorruptPlanetAbility : AbstractGameObjectType
    {
        public StringParameter RequiredCorruptionLevel { get; } = new StringParameter("required_corruption_level");
        public StringParameter TransitionTimeInSecs { get; } = new StringParameter("transition_time_in_secs");
        
        public CorruptPlanetAbility(string id) : base(id)
        {
        }
    }
}