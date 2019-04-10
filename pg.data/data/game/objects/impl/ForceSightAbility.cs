using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ForceSightAbility : AbstractGameObjectType
    {
        public StringParameter ForceSightDurationInSecs { get; } = new StringParameter("force_sight_duration_in_secs");
        
        public ForceSightAbility(string id) : base(id)
        {
        }
    }
}