using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class Campaign : AbstractGameObjectType
    {
        public readonly StringParameter TextId = new StringParameter("text_id");
        public readonly StringParameter RebelStoryName = new StringParameter("rebel_story_name");
        public readonly StringParameter EmpireStoryName = new StringParameter("empire_story_name");
        public readonly StringParameter UnderworldStoryName = new StringParameter("underworld_story_name");
        public readonly StringParameter SortOrder = new StringParameter("sort_order");
        public readonly StringParameter CameraShiftX = new StringParameter("camera_shift_x");
        public readonly StringParameter CameraShiftY = new StringParameter("camera_shift_y");
        public readonly StringParameter CameraDistance = new StringParameter("camera_distance");
        public readonly StringParameter Locations = new StringParameter("locations");
        public readonly StringParameter TradeRoutes = new StringParameter("trade_routes");
        public readonly StringParameter StartingCredits = new StringParameter("starting_credits");
        public readonly StringParameter StartingTechLevel = new StringParameter("starting_tech_level");
        public readonly StringParameter StartingForces = new StringParameter("starting_forces");
        public readonly StringParameter SpecialCaseProduction = new StringParameter("special_case_production");
        public readonly StringParameter HomeLocation = new StringParameter("home_location");
        public readonly StringParameter AiPlayerControl = new StringParameter("ai_player_control");
        public readonly StringParameter StartingActivePlayer = new StringParameter("starting_active_player");
        public readonly StringParameter CampaignSet = new StringParameter("campaign_set");
        public readonly StringParameter IsMultiplayer = new StringParameter("is_multiplayer");
        public readonly StringParameter IsListed = new StringParameter("is_listed");
        public readonly StringParameter IsQuickmatchAllowed = new StringParameter("is_quickmatch_allowed");
        public readonly StringParameter MarkupFilename = new StringParameter("markup_filename");
        public readonly StringParameter PlanetAutoReveal = new StringParameter("planet_auto_reveal");
        public readonly StringParameter MaxTechLevel = new StringParameter("max_tech_level");
        public readonly StringParameter SupportsCustomSettings = new StringParameter("supports_custom_settings");
        public readonly StringParameter MinCustomTechLevel = new StringParameter("min_custom_tech_level");
        public readonly StringParameter MaxCustomTechLevel = new StringParameter("max_custom_tech_level");
        public readonly StringParameter MinCustomStartingCredits = new StringParameter("min_custom_starting_credits");
        public readonly StringParameter MaxCustomStartingCredits = new StringParameter("max_custom_starting_credits");
        public readonly StringParameter DescriptionText = new StringParameter("description_text");
        public readonly StringParameter Tutorial = new StringParameter("tutorial");
        public readonly StringParameter HumanVictoryConditions = new StringParameter("human_victory_conditions");
        public readonly StringParameter AiVictoryConditions = new StringParameter("ai_victory_conditions");
        public readonly StringParameter HumanVictoryCreditTarget = new StringParameter("human_victory_credit_target");
        public readonly StringParameter HumanVictoryGalacticControl = new StringParameter("human_victory_galactic_control");
        public readonly StringParameter HumanVictoryCycleLimit = new StringParameter("human_victory_cycle_limit");
        public readonly StringParameter HumanVictoryPlanetNames = new StringParameter("human_victory_planet_names");
        public readonly StringParameter HumanVictoryFactionNames = new StringParameter("human_victory_faction_names");
        public readonly StringParameter HumanVictoryLeaderNames = new StringParameter("human_victory_leader_names");
        public readonly StringParameter AiVictoryCreditTarget = new StringParameter("ai_victory_credit_target");
        public readonly StringParameter AiVictoryGalacticControl = new StringParameter("ai_victory_galactic_control");
        public readonly StringParameter AiVictoryCycleLimit = new StringParameter("ai_victory_cycle_limit");
        public readonly StringParameter AiVictoryPlanetNames = new StringParameter("ai_victory_planet_names");
        public readonly StringParameter AiVictoryFactionNames = new StringParameter("ai_victory_faction_names");
        public readonly StringParameter AiVictoryLeaderNames = new StringParameter("ai_victory_leader_names");
        public readonly StringParameter IsAutoresolveAllowed = new StringParameter("is_autoresolve_allowed");
        public readonly StringParameter ShowCompletedTab = new StringParameter("show_completed_tab");
        public readonly StringParameter IsStoryCampaign = new StringParameter("is_story_campaign");
        public readonly StringParameter AutoresolveExclusionLocations = new StringParameter("autoresolve_exclusion_locations");
        public readonly StringParameter CorruptionLevelOverride = new StringParameter("corruption_level_override");
    }
}
