using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SpecialAbility : AbstractGameObjectType
    {
        public StringParameter InitiallyEnabled { get; } = new StringParameter("initially_enabled");
        public StringParameter ActivationStyle { get; } = new StringParameter("activation_style");
        public StringParameter CausesDespawn { get; } = new StringParameter("causes_despawn");
        public StringParameter TerminateEffectOnMoveCommand { get; } = new StringParameter("terminate_effect_on_move_command");
        public StringParameter UnitStrengthCategory { get; } = new StringParameter("unit_strength_category");
        public StringParameter UnitStrengthFactor { get; } = new StringParameter("unit_strength_factor");
        public StringParameter ApplicableUnitCategories { get; } = new StringParameter("applicable_unit_categories");
        public StringParameter ApplicableUnitTypes { get; } = new StringParameter("applicable_unit_types");
        public StringParameter ExcludedUnitCategories { get; } = new StringParameter("excluded_unit_categories");
        public StringParameter ExcludedUnitTypes { get; } = new StringParameter("excluded_unit_types");
        public StringParameter OwnerLightEffectType { get; } = new StringParameter("owner_light_effect_type");
        public StringParameter OwnerLightEffectColor { get; } = new StringParameter("owner_light_effect_color");
        public StringParameter OwnerLightEffectColor2 { get; } = new StringParameter("owner_light_effect_color2");
        public StringParameter OwnerLightEffectDuration { get; } = new StringParameter("owner_light_effect_duration");
        public StringParameter OwnerLightEffectPulseCount { get; } = new StringParameter("owner_light_effect_pulse_count");
        public StringParameter TargetLightEffectType { get; } = new StringParameter("target_light_effect_type");
        public StringParameter TargetLightEffectColor { get; } = new StringParameter("target_light_effect_color");
        public StringParameter TargetLightEffectColor2 { get; } = new StringParameter("target_light_effect_color2");
        public StringParameter TargetLightEffectDuration { get; } = new StringParameter("target_light_effect_duration");
        public StringParameter TargetLightEffectPulseCount { get; } = new StringParameter("target_light_effect_pulse_count");
        public StringParameter OwnerParticleEffect { get; } = new StringParameter("owner_particle_effect");
        public StringParameter OwnerParticleBoneName { get; } = new StringParameter("owner_particle_bone_name");
        public StringParameter TargetParticleEffect { get; } = new StringParameter("target_particle_effect");
        public StringParameter TargetParticleBoneName { get; } = new StringParameter("target_particle_bone_name");
        public StringParameter SfXEventActivate { get; } = new StringParameter("sfxevent_activate");
        public StringParameter SfXEventTargetAffected { get; } = new StringParameter("sfxevent_target_affected");
        public StringParameter MinRespawnTime { get; } = new StringParameter("min_respawn_time");
        public StringParameter MaxRespawnTime { get; } = new StringParameter("max_respawn_time");
        public StringParameter MustBeBoughtOnBlackMarket { get; } = new StringParameter("must_be_bought_on_black_market");

        public SpecialAbility(string id) : base(id)
        {
        }
    }
}
