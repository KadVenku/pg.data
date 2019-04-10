using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SystemSpyAbility : AbstractGameObjectType
    {
        public StringParameter DurationInSecs { get; } = new StringParameter("duration_in_secs");
        public StringParameter SeeBaseLevels { get; } = new StringParameter("see_base_levels");
        public StringParameter SeeCreditIncome { get; } = new StringParameter("see_credit_income");
        public StringParameter SeeCreditIncomeBreakdown { get; } = new StringParameter("see_credit_income_breakdown");
        public StringParameter SeeNumFleets { get; } = new StringParameter("see_num_fleets");
        public StringParameter SeeMostPowerfulShip { get; } = new StringParameter("see_most_powerful_ship");
        public StringParameter SeeFleetContents { get; } = new StringParameter("see_fleet_contents");
        public StringParameter SeeNumGroundCompanies { get; } = new StringParameter("see_num_ground_companies");
        public StringParameter SeeGroundCompanyContents { get; } = new StringParameter("see_ground_company_contents");
        public StringParameter SeeSpecialStructures { get; } = new StringParameter("see_special_structures");
        public StringParameter SeePoliticalControl { get; } = new StringParameter("see_political_control");
        public StringParameter SeePoliticalControlBreakdown { get; } = new StringParameter("see_political_control_breakdown");
        public StringParameter SeeCurrentProduction { get; } = new StringParameter("see_current_production");
        public StringParameter SeeMinorStealthHeroes { get; } = new StringParameter("see_minor_stealth_heroes");
        public StringParameter SeeMajorStealthHeroes { get; } = new StringParameter("see_major_stealth_heroes");
        public StringParameter SeeForceSensitiveHeroes { get; } = new StringParameter("see_force_sensitive_heroes");
        public StringParameter SeeSuperWeapons { get; } = new StringParameter("see_super_weapons");

        public SystemSpyAbility(string id) : base(id)
        {
        }
    }
}
