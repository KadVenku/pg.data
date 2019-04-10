using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class PlanetIncomeGamblingAbility : AbstractGameObjectType
    {
        public StringParameter EvaluationIntervalInSecs { get; } = new StringParameter("evaluation_interval_in_secs");
        public StringParameter MinIncomeModifier { get; } = new StringParameter("min_income_modifier");
        public StringParameter MaxIncomeModifier { get; } = new StringParameter("max_income_modifier");
        public StringParameter ChanceToWin { get; } = new StringParameter("chance_to_win");
        
        public PlanetIncomeGamblingAbility(string id) : base(id)
        {
        }
    }
}