using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class IncomeStreamAbility : AbstractGameObjectType
    {
        public StringParameter BaseIncomeValue { get; } = new StringParameter("base_income_value");
        public StringParameter BaseIntervalInSecs { get; } = new StringParameter("base_interval_in_secs");
        public StringParameter OwnerIncomePercentage { get; } = new StringParameter("owner_income_percentage");
        public StringParameter SplitIncomeWithAllies { get; } = new StringParameter("split_income_with_allies");
        public StringParameter SplitFavorsOwner { get; } = new StringParameter("split_favors_owner");
        public StringParameter FullAmountToEveryone { get; } = new StringParameter("full_amount_to_everyone");
        
        public IncomeStreamAbility(string id) : base(id)
        {
        }
    }
}