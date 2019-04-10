using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SpecialAbilityData : AbstractGameObjectType
    {
        public StringParameter Type { get; } = new StringParameter("type");
        public StringParameter ActiveByDefault { get; } = new StringParameter("active_by_default");
        public StringParameter EffectiveRadius { get; } = new StringParameter("effective_radius");
        public StringParameter RechargeSeconds { get; } = new StringParameter("recharge_seconds");
        public StringParameter ExpirationSeconds { get; } = new StringParameter("expiration_seconds");
        public StringParameter IsPulsing { get; } = new StringParameter("is_pulsing");
        public StringParameter PulseFrequencySecs { get; } = new StringParameter("pulse_frequency_secs");
        public StringParameter TargetTypes { get; } = new StringParameter("target_types");
        public StringParameter MaxNumberOfPulses { get; } = new StringParameter("max_number_of_pulses");
        public StringParameter ParticleEffect { get; } = new StringParameter("particle_effect");
        public StringParameter GuiActivatedAbilityName { get; } = new StringParameter("gui_activated_ability_name");
        public StringParameter ModMultiplier { get; } = new StringParameter("mod_multiplier");
        public StringParameter ModFlag { get; } = new StringParameter("mod_flag");
        public StringParameter SpawnedObjectType { get; } = new StringParameter("spawned_object_type");
        public StringParameter MaxNumSpawnedObjects { get; } = new StringParameter("max_num_spawned_objects");
        public StringParameter AreaEffectDecalDistance { get; } = new StringParameter("area_effect_decal_distance");
        public StringParameter BombCountdownSeconds { get; } = new StringParameter("bomb_countdown_seconds");
        public StringParameter ProjectileTypesOverride { get; } = new StringParameter("projectile_types_override");
        public StringParameter TargetingMaxAttackDistance { get; } = new StringParameter("targeting_max_attack_distance");
        public StringParameter OwnerAttachmentBone { get; } = new StringParameter("owner_attachment_bone");
        public StringParameter DisableMovement { get; } = new StringParameter("disable_movement");
        public StringParameter ArmorType { get; } = new StringParameter("armor_type");
        public StringParameter SfXEventTargetAbility { get; } = new StringParameter("sfxevent_target_ability");
        public StringParameter SfxEventGuiUnitAbilityActivated { get; } = new StringParameter("sfxevent_gui_unit_ability_activated");
        public StringParameter SfxEventGuiUnitAbilityDeactivated { get; } = new StringParameter("sfxevent_gui_unit_ability_deactivated");
        public StringParameter SfXEventSpecialAbilityLoop { get; } = new StringParameter("sfxevent_special_ability_loop");
        public StringParameter FriendlyAbility { get; } = new StringParameter("friendly_ability");
        public StringParameter TargetingFireInaccuracyFixedRadiusOverride { get; } = new StringParameter("targeting_fire_inaccuracy_fixed_radius_override");
        public StringParameter TargetPositionZOffset { get; } = new StringParameter("target_position_z_offset");
        public StringParameter StopWhenActivated { get; } = new StringParameter("stop_when_activated");
        public StringParameter AlternateNameText { get; } = new StringParameter("alternate_name_text");
        public StringParameter AlternateDescriptionText { get; } = new StringParameter("alternate_description_text");
        public StringParameter AlternateIconName { get; } = new StringParameter("alternate_icon_name");
        public StringParameter MustBeBoughtOnBlackMarket { get; } = new StringParameter("must_be_bought_on_black_market");
        public StringParameter DamagePercentWhenActivated { get; } = new StringParameter("damage_percent_when_activated");
        public StringParameter SupportsAutofire { get; } = new StringParameter("supports_autofire");
        
        public SpecialAbilityData(string id) : base(id)
        {
        }
    }
}