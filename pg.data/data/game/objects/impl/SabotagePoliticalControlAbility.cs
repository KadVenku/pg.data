using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SabotagePoliticalControlAbility : AbstractGameObjectType
    {
        public StringParameter PoliticalChange { get; } = new StringParameter("political_change");
        public StringParameter ChangeDurationInSeconds { get; } = new StringParameter("change_duration_in_seconds");

        public SabotagePoliticalControlAbility(string id) : base(id)
        {
        }
    }
}
