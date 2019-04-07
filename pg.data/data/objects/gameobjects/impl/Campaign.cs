using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class Campaign : AbstractGameObjectType
    {
        public StringParameter TextId { get; } = new StringParameter("text_id");
        public StringParameter RebelStoryName { get; } = new StringParameter("rebel_story_name");
        public StringParameter EmpireStoryName { get; } = new StringParameter("empire_story_name");
        public StringParameter UnderworldStoryName { get; } = new StringParameter("underworld_story_name");
        public StringParameter SortOrder { get; } = new StringParameter("sort_order");
        public StringParameter CameraShiftX { get; } = new StringParameter("camera_shift_x");
        public StringParameter CameraShiftY { get; } = new StringParameter("camera_shift_y");
        public StringParameter CameraDistance { get; } = new StringParameter("camera_distance");
        public StringParameter Locations { get; } = new StringParameter("locations");
        public StringParameter TradeRoutes { get; } = new StringParameter("trade_routes");
        public StringParameter StartingCredits { get; } = new StringParameter("starting_credits");
        public StringParameter StartingTechLevel { get; } = new StringParameter("starting_tech_level");
        public StringParameter StartingForces { get; } = new StringParameter("starting_forces");
        public StringParameter SpecialCaseProduction { get; } = new StringParameter("special_case_production");
        public StringParameter HomeLocation { get; } = new StringParameter("home_location");
        public StringParameter AiPlayerControl { get; } = new StringParameter("ai_player_control");
        public StringParameter StartingActivePlayer { get; } = new StringParameter("starting_active_player");
        public StringParameter CampaignSet { get; } = new StringParameter("campaign_set");
        public StringParameter IsMultiplayer { get; } = new StringParameter("is_multiplayer");
        public StringParameter IsListed { get; } = new StringParameter("is_listed");
        public StringParameter IsQuickmatchAllowed { get; } = new StringParameter("is_quickmatch_allowed");
        public StringParameter MarkupFilename { get; } = new StringParameter("markup_filename");
        public StringParameter PlanetAutoReveal { get; } = new StringParameter("planet_auto_reveal");
        public StringParameter MaxTechLevel { get; } = new StringParameter("max_tech_level");
        public StringParameter SupportsCustomSettings { get; } = new StringParameter("supports_custom_settings");
        public StringParameter MinCustomTechLevel { get; } = new StringParameter("min_custom_tech_level");
        public StringParameter MaxCustomTechLevel { get; } = new StringParameter("max_custom_tech_level");
        public StringParameter MinCustomStartingCredits { get; } = new StringParameter("min_custom_starting_credits");
        public StringParameter MaxCustomStartingCredits { get; } = new StringParameter("max_custom_starting_credits");
        public StringParameter DescriptionText { get; } = new StringParameter("description_text");
        public StringParameter Tutorial { get; } = new StringParameter("tutorial");
        public StringParameter HumanVictoryConditions { get; } = new StringParameter("human_victory_conditions");
        public StringParameter AiVictoryConditions { get; } = new StringParameter("ai_victory_conditions");
        public StringParameter HumanVictoryCreditTarget { get; } = new StringParameter("human_victory_credit_target");
        public StringParameter HumanVictoryGalacticControl { get; } = new StringParameter("human_victory_galactic_control");
        public StringParameter HumanVictoryCycleLimit { get; } = new StringParameter("human_victory_cycle_limit");
        public StringParameter HumanVictoryPlanetNames { get; } = new StringParameter("human_victory_planet_names");
        public StringParameter HumanVictoryFactionNames { get; } = new StringParameter("human_victory_faction_names");
        public StringParameter HumanVictoryLeaderNames { get; } = new StringParameter("human_victory_leader_names");
        public StringParameter AiVictoryCreditTarget { get; } = new StringParameter("ai_victory_credit_target");
        public StringParameter AiVictoryGalacticControl { get; } = new StringParameter("ai_victory_galactic_control");
        public StringParameter AiVictoryCycleLimit { get; } = new StringParameter("ai_victory_cycle_limit");
        public StringParameter AiVictoryPlanetNames { get; } = new StringParameter("ai_victory_planet_names");
        public StringParameter AiVictoryFactionNames { get; } = new StringParameter("ai_victory_faction_names");
        public StringParameter AiVictoryLeaderNames { get; } = new StringParameter("ai_victory_leader_names");
        public StringParameter IsAutoresolveAllowed { get; } = new StringParameter("is_autoresolve_allowed");
        public StringParameter ShowCompletedTab { get; } = new StringParameter("show_completed_tab");
        public StringParameter IsStoryCampaign { get; } = new StringParameter("is_story_campaign");
        public StringParameter AutoresolveExclusionLocations { get; } = new StringParameter("autoresolve_exclusion_locations");
        public StringParameter CorruptionLevelOverride { get; } = new StringParameter("corruption_level_override");

        public Campaign(string id) : base(id)
        {
        }
    }
}
