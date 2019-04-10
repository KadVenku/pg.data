using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BlackMarketAbility : AbstractGameObjectType
    {
        public StringParameter MinRespawnTimes { get; } = new StringParameter("min_respawn_times");
        public StringParameter MaxRespawnTimes { get; } = new StringParameter("max_respawn_times");
        public StringParameter PriceModifier { get; } = new StringParameter("price_modifier");
        public StringParameter TechLevelAdjustment { get; } = new StringParameter("tech_level_adjustment");

        public BlackMarketAbility(string id) : base(id)
        {
        }
    }
}