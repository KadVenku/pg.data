using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class HardPoint : AbstractGameObjectType
    {
        public StringParameter Type { get; } = new StringParameter("type");
        public StringParameter IsTargetable { get; } = new StringParameter("is_targetable");
        public StringParameter IsDestroyable { get; } = new StringParameter("is_destroyable");
        public StringParameter Health { get; } = new StringParameter("health");
        public StringParameter ModelToAttach { get; } = new StringParameter("model_to_attach");
        public StringParameter AttachmentBone { get; } = new StringParameter("attachment_bone");
        public StringParameter CollisionMesh { get; } = new StringParameter("collision_mesh");
        public StringParameter DamageDecal { get; } = new StringParameter("damage_decal");
        public StringParameter DamageParticles { get; } = new StringParameter("damage_particles");
        public StringParameter EngineParticles { get; } = new StringParameter("engine_particles");
        public StringParameter TooltipText { get; } = new StringParameter("tooltip_text");
        public StringParameter FireBoneA { get; } = new StringParameter("fire_bone_a");
        public StringParameter FireBoneB { get; } = new StringParameter("fire_bone_b");
        public StringParameter RandomizeBetweenFireBones { get; } = new StringParameter("randomize_between_fire_bones");
        public StringParameter FireConeWidth { get; } = new StringParameter("fire_cone_width");
        public StringParameter FireConeHeight { get; } = new StringParameter("fire_cone_height");
        public StringParameter FireProjectileType { get; } = new StringParameter("fire_projectile_type");
        public StringParameter FireMinRechargeSeconds { get; } = new StringParameter("fire_min_recharge_seconds");
        public StringParameter FireMaxRechargeSeconds { get; } = new StringParameter("fire_max_recharge_seconds");
        public StringParameter FirePulseCount { get; } = new StringParameter("fire_pulse_count");
        public StringParameter FirePulseDelaySeconds { get; } = new StringParameter("fire_pulse_delay_seconds");
        public StringParameter FireRangeDistance { get; } = new StringParameter("fire_range_distance");
        public StringParameter FireSfxEvent { get; } = new StringParameter("fire_sfxevent");
        public StringParameter FireInaccuracyDistance { get; } = new StringParameter("fire_inaccuracy_distance");
        public StringParameter FireCategoryRestrictions { get; } = new StringParameter("fire_category_restrictions");
        public StringParameter FireWhenDeployed { get; } = new StringParameter("fire_when_deployed");
        public StringParameter FireWhenUndeployed { get; } = new StringParameter("fire_when_undeployed");
        public StringParameter FireWhenInRocketAttackMode { get; } = new StringParameter("fire_when_in_rocket_attack_mode");
        public StringParameter FireWhenInNormalAttackMode { get; } = new StringParameter("fire_when_in_normal_attack_mode");
        public StringParameter DeathExplosionParticles { get; } = new StringParameter("death_explosion_particles");
        public StringParameter DeathExplosionSfxEvent { get; } = new StringParameter("death_explosion_sfxevent");
        public StringParameter DeathBreakoffProp { get; } = new StringParameter("death_breakoff_prop");
        public StringParameter DefendModeWeaponDelayMultiplier { get; } = new StringParameter("defend_mode_weapon_delay_multiplier");
        public StringParameter TurboModeWeaponDelayMultiplier { get; } = new StringParameter("turbo_mode_weapon_delay_multiplier");
        public StringParameter FireMinRangeDistance { get; } = new StringParameter("fire_min_range_distance");
        public StringParameter AllowOpportunityFireWhenIdle { get; } = new StringParameter("allow_opportunity_fire_when_idle");
        public StringParameter AllowOpportunityFireWhenTargeting { get; } = new StringParameter("allow_opportunity_fire_when_targeting");
        public StringParameter FighterBayFlyoutDistance { get; } = new StringParameter("fighter_bay_flyout_distance");
        public StringParameter SpecialAbilityName { get; } = new StringParameter("special_ability_name");
        public StringParameter RepairCostPerFrame { get; } = new StringParameter("repair_cost_per_frame");
        public StringParameter RepairAmountPerFrame { get; } = new StringParameter("repair_amount_per_frame");
        public StringParameter ProjectileDamage { get; } = new StringParameter("projectile_damage");
        public StringParameter DamageType { get; } = new StringParameter("damage_type");
        public StringParameter ProjectileAppearanceDelayFrames { get; } = new StringParameter("projectile_appearance_delay_frames");
        public StringParameter PowerToWeaponsModeWeaponDelayMultiplier { get; } = new StringParameter("power_to_weapons_mode_weapon_delay_multiplier");
        public StringParameter FullSalvoWeaponDelayMultiplier { get; } = new StringParameter("full_salvo_weapon_delay_multiplier");
        public StringParameter FireWhenInDefendMode { get; } = new StringParameter("fire_when_in_defend_mode");
        public StringParameter FireWhenInTurboMode { get; } = new StringParameter("fire_when_in_turbo_mode");
        public StringParameter FireWhenInPowerToWeaponsMode { get; } = new StringParameter("fire_when_in_power_to_weapons_mode");
        public StringParameter EngineDeathHideEngineParticles { get; } = new StringParameter("engine_death_hide_engine_particles");
        public StringParameter IsTurret { get; } = new StringParameter("is_turret");
        public StringParameter TurretRestAngle { get; } = new StringParameter("turret_rest_angle");
        public StringParameter TurretRotationOffset { get; } = new StringParameter("turret_rotation_offset");
        public StringParameter TurretRotateSpeed { get; } = new StringParameter("turret_rotate_speed");
        public StringParameter TurretRotateExtentDegrees { get; } = new StringParameter("turret_rotate_extent_degrees");
        public StringParameter TurretElevateExtentDegrees { get; } = new StringParameter("turret_elevate_extent_degrees");
        public StringParameter TurretBoneName { get; } = new StringParameter("turret_bone_name");
        public StringParameter BarrelBoneName { get; } = new StringParameter("barrel_bone_name");
        public StringParameter RequiresManualTargetAssignment { get; } = new StringParameter("requires_manual_target_assignment");
        public StringParameter ManualHardpointFiringCooldownSecs { get; } = new StringParameter("manual_hardpoint_firing_cooldown_secs");
        public StringParameter AllowsSpecialWeaponUse { get; } = new StringParameter("allows_special_weapon_use");
        public StringParameter BlastAbilityFireProjectileType { get; } = new StringParameter("blast_ability_fire_projectile_type");

        public HardPoint(string id) : base(id)
        {
        }
    }
}
