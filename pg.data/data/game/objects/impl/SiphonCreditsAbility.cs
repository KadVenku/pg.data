using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SiphonCreditsAbility : AbstractGameObjectType
    {
        public StringParameter MinSiphonPercentage { get; } = new StringParameter("min_siphon_percentage");
        public StringParameter MaxSiphonPercentage { get; } = new StringParameter("max_siphon_percentage");
        public StringParameter SiphonDurationInCycles { get; } = new StringParameter("siphon_duration_in_cycles");

        public SiphonCreditsAbility(string id) : base(id)
        {
        }
    }
}
