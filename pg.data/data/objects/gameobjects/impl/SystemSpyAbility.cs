using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SystemSpyAbility : AbstractGameObjectType
    {
        public readonly StringParameter DurationInSecs = new StringParameter("duration_in_secs");
        public readonly StringParameter SeeBaseLevels = new StringParameter("see_base_levels");
        public readonly StringParameter SeeCreditIncome = new StringParameter("see_credit_income");
        public readonly StringParameter SeeCreditIncomeBreakdown = new StringParameter("see_credit_income_breakdown");
        public readonly StringParameter SeeNumFleets = new StringParameter("see_num_fleets");
        public readonly StringParameter SeeMostPowerfulShip = new StringParameter("see_most_powerful_ship");
        public readonly StringParameter SeeFleetContents = new StringParameter("see_fleet_contents");
        public readonly StringParameter SeeNumGroundCompanies = new StringParameter("see_num_ground_companies");
        public readonly StringParameter SeeGroundCompanyContents = new StringParameter("see_ground_company_contents");
        public readonly StringParameter SeeSpecialStructures = new StringParameter("see_special_structures");
        public readonly StringParameter SeePoliticalControl = new StringParameter("see_political_control");
        public readonly StringParameter SeePoliticalControlBreakdown = new StringParameter("see_political_control_breakdown");
        public readonly StringParameter SeeCurrentProduction = new StringParameter("see_current_production");
        public readonly StringParameter SeeMinorStealthHeroes = new StringParameter("see_minor_stealth_heroes");
        public readonly StringParameter SeeMajorStealthHeroes = new StringParameter("see_major_stealth_heroes");
        public readonly StringParameter SeeForceSensitiveHeroes = new StringParameter("see_force_sensitive_heroes");
        public readonly StringParameter SeeSuperWeapons = new StringParameter("see_super_weapons");
    }
}
