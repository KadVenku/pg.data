using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BlackMarketItem : AbstractGameObjectType
    {
        public StringParameter Name { get; } = new StringParameter("name");
        public StringParameter IconName { get; } = new StringParameter("icon_name");
        public StringParameter UncommonPriceMultiplier { get; } = new StringParameter("uncommon_price_multiplier");
        public StringParameter Faction { get; } = new StringParameter("faction");
        public StringParameter TechLevel { get; } = new StringParameter("tech_level");
        public StringParameter AbilityNames { get; } = new StringParameter("ability_names");
        public StringParameter BaseCostCredits { get; } = new StringParameter("base_cost_credits");
        public StringParameter LocalizedName { get; } = new StringParameter("localized_name");
        public StringParameter LocalizedDescription { get; } = new StringParameter("localized_description");
        public StringParameter UsedByUnits { get; } = new StringParameter("used_by_units");
        public StringParameter TutorialTechLevel { get; } = new StringParameter("tutorial_tech_level");
        public StringParameter TutorialBaseCostCredits { get; } = new StringParameter("tutorial_base_cost_credits");
        
        public BlackMarketItem(string id) : base(id)
        {
        }
    }
}