using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SlicerAbility : AbstractGameObjectType
    {
        public readonly StringParameter MinRespawnTimePerTechLevel = new StringParameter("min_respawn_time_per_tech_level");
        public readonly StringParameter MaxRespawnTimePerTechLevel = new StringParameter("max_respawn_time_per_tech_level");
        public readonly StringParameter ChanceModifierByBaseLevel = new StringParameter("chance_modifier_by_base_level");
        public readonly StringParameter ChanceModifierByPlanetDifficulty = new StringParameter("chance_modifier_by_planet_difficulty");
        public readonly StringParameter CostMultiplierByPlanetTechAvailability = new StringParameter("cost_multiplier_by_planet_tech_availability");
        public readonly StringParameter ChanceAffinityModifier = new StringParameter("chance_affinity_modifier");
        public readonly StringParameter CostAffinityModifier = new StringParameter("cost_affinity_modifier");
    }
}
