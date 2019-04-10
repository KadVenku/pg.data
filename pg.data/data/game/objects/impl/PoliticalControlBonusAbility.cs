using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class PoliticalControlBonusAbility : AbstractGameObjectType
    {
        public StringParameter PoliticalChange { get; } = new StringParameter("political_change");
        public StringParameter ChangeDurationInSeconds { get; } = new StringParameter("change_duration_in_seconds");
        
        public PoliticalControlBonusAbility(string id) : base(id)
        {
        }
    }
}