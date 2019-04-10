using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class EnableRadarAbility : AbstractGameObjectType
    {
        public StringParameter AffectsAllAllies { get; } = new StringParameter("affects_all_allies");
        
        public EnableRadarAbility(string id) : base(id)
        {
        }
    }
}