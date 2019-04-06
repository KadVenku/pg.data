using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SiphonCreditsAbility : AbstractGameObjectType
    {
        public readonly StringParameter MinSiphonPercentage = new StringParameter("min_siphon_percentage");
        public readonly StringParameter MaxSiphonPercentage = new StringParameter("max_siphon_percentage");
        public readonly StringParameter SiphonDurationInCycles = new StringParameter("siphon_duration_in_cycles");
    }
}
