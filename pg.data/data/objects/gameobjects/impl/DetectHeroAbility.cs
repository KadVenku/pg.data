using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class DetectHeroAbility : AbstractGameObjectType
    {
        public readonly StringParameter DetectIntervalInSeconds = new StringParameter("detect_interval_in_seconds");
        public readonly StringParameter DetectionChance = new StringParameter("detection_chance");
        public readonly StringParameter DetectCreditSiphonEffects = new StringParameter("detect_credit_siphon_effects");
    }
}
