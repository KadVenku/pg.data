using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SpecialAbility : AbstractGameObjectType
    {
        public readonly StringParameter InitiallyEnabled = new StringParameter("initially_enabled");
        public readonly StringParameter ActivationStyle = new StringParameter("activation_style");
        public readonly StringParameter CausesDespawn = new StringParameter("causes_despawn");
        public readonly StringParameter TerminateEffectOnMoveCommand = new StringParameter("terminate_effect_on_move_command");
        public readonly StringParameter UnitStrengthCategory = new StringParameter("unit_strength_category");
        public readonly StringParameter UnitStrengthFactor = new StringParameter("unit_strength_factor");
        public readonly StringParameter ApplicableUnitCategories = new StringParameter("applicable_unit_categories");
        public readonly StringParameter ApplicableUnitTypes = new StringParameter("applicable_unit_types");
        public readonly StringParameter ExcludedUnitCategories = new StringParameter("excluded_unit_categories");
        public readonly StringParameter ExcludedUnitTypes = new StringParameter("excluded_unit_types");
        public readonly StringParameter OwnerLightEffectType = new StringParameter("owner_light_effect_type");
        public readonly StringParameter OwnerLightEffectColor = new StringParameter("owner_light_effect_color");
        public readonly StringParameter OwnerLightEffectColor2 = new StringParameter("owner_light_effect_color2");
        public readonly StringParameter OwnerLightEffectDuration = new StringParameter("owner_light_effect_duration");
        public readonly StringParameter OwnerLightEffectPulseCount = new StringParameter("owner_light_effect_pulse_count");
        public readonly StringParameter TargetLightEffectType = new StringParameter("target_light_effect_type");
        public readonly StringParameter TargetLightEffectColor = new StringParameter("target_light_effect_color");
        public readonly StringParameter TargetLightEffectColor2 = new StringParameter("target_light_effect_color2");
        public readonly StringParameter TargetLightEffectDuration = new StringParameter("target_light_effect_duration");
        public readonly StringParameter TargetLightEffectPulseCount = new StringParameter("target_light_effect_pulse_count");
        public readonly StringParameter OwnerParticleEffect = new StringParameter("owner_particle_effect");
        public readonly StringParameter OwnerParticleBoneName = new StringParameter("owner_particle_bone_name");
        public readonly StringParameter TargetParticleEffect = new StringParameter("target_particle_effect");
        public readonly StringParameter TargetParticleBoneName = new StringParameter("target_particle_bone_name");
        public readonly StringParameter SfXEventActivate = new StringParameter("sfxevent_activate");
        public readonly StringParameter SfXEventTargetAffected = new StringParameter("sfxevent_target_affected");
        public readonly StringParameter MinRespawnTime = new StringParameter("min_respawn_time");
        public readonly StringParameter MaxRespawnTime = new StringParameter("max_respawn_time");
        public readonly StringParameter MustBeBoughtOnBlackMarket = new StringParameter("must_be_bought_on_black_market");
    }
}
