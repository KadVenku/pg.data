using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class DetectHeroAbility : AbstractGameObjectType
    {
        public StringParameter DetectIntervalInSeconds { get; } = new StringParameter("detect_interval_in_seconds");
        public StringParameter DetectionChance { get; } = new StringParameter("detection_chance");
        public StringParameter DetectCreditSiphonEffects { get; } = new StringParameter("detect_credit_siphon_effects");

        public DetectHeroAbility(string id) : base(id)
        {
        }
    }
}
