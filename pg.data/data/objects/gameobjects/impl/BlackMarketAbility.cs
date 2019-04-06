using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class BlackMarketAbility : AbstractGameObjectType
    {
        public readonly StringParameter MinRespawnTimes = new StringParameter("min_respawn_times");
        public readonly StringParameter MaxRespawnTimes = new StringParameter("max_respawn_times");
        public readonly StringParameter PriceModifier = new StringParameter("price_modifier");
        public readonly StringParameter TechLevelAdjustment = new StringParameter("tech_level_adjustment");
    }
}