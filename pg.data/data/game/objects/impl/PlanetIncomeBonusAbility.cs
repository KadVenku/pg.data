using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class PlanetIncomeBonusAbility : AbstractGameObjectType
    {
        public StringParameter PercentageIncomeModifier { get; } = new StringParameter("percentage_income_modifier");
        public StringParameter AbsoluteIncomeModifier { get; } = new StringParameter("absolute_income_modifier");
        public StringParameter AdditionalMultiplierOnMiningColonies { get; } = new StringParameter("additional_multiplier_on_mining_colonies");
        public StringParameter SpecificModSourceText { get; } = new StringParameter("specific_mod_source_text");
        
        public PlanetIncomeBonusAbility(string id) : base(id)
        {
        }
    }
}