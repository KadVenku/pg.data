using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class NeutralizeHeroAbility : AbstractGameObjectType
    {
        public StringParameter CostModByBaseLevel { get; } = new StringParameter("cost_mod_by_base_level");
        public StringParameter CostModByPreviousNeutralizations { get; } = new StringParameter("cost_mod_by_previous_neutralizations");
        public StringParameter CostModByPlanetaryCorruptionLevel { get; } = new StringParameter("cost_mod_by_planetary_corruption_level");
        public StringParameter GeneralMinorHeroCostMod { get; } = new StringParameter("general_minor_hero_cost_mod");
        public StringParameter GeneralMajorHeroCostMod { get; } = new StringParameter("general_major_hero_cost_mod");
        public StringParameter OwnerRespawnTimeInSecs { get; } = new StringParameter("owner_respawn_time_in_secs");
        public StringParameter TargetRespawnTimeInSecs { get; } = new StringParameter("target_respawn_time_in_secs");
        public StringParameter CanNeutralizeMinorHeroes { get; } = new StringParameter("can_neutralize_minor_heroes");
        public StringParameter CanNeutralizeMajorHeroes { get; } = new StringParameter("can_neutralize_major_heroes");
        
        public NeutralizeHeroAbility(string id) : base(id)
        {
        }
    }
}