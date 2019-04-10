using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class WeatherproofAbility : AbstractGameObjectType
    {
        public StringParameter ApplyToAllAllies = new StringParameter("apply_to_all_allies");
        
        public WeatherproofAbility(string id) : base(id)
        {
        }
    }
}