using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SlicerAbility : AbstractGameObjectType
    {
        public StringParameter MinRespawnTimePerTechLevel { get; } = new StringParameter("min_respawn_time_per_tech_level");
        public StringParameter MaxRespawnTimePerTechLevel { get; } = new StringParameter("max_respawn_time_per_tech_level");
        public StringParameter ChanceModifierByBaseLevel { get; } = new StringParameter("chance_modifier_by_base_level");
        public StringParameter ChanceModifierByPlanetDifficulty { get; } = new StringParameter("chance_modifier_by_planet_difficulty");
        public StringParameter CostMultiplierByPlanetTechAvailability { get; } = new StringParameter("cost_multiplier_by_planet_tech_availability");
        public StringParameter ChanceAffinityModifier { get; } = new StringParameter("chance_affinity_modifier");
        public StringParameter CostAffinityModifier { get; } = new StringParameter("cost_affinity_modifier");

        public SlicerAbility(string id) : base(id)
        {
        }
    }
}
