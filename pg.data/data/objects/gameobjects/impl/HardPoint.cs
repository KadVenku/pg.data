using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class HardPoint : AbstractGameObjectType
    {
        public readonly StringParameter Type = new StringParameter("type");
        public readonly StringParameter IsTargetable = new StringParameter("is_targetable");
        public readonly StringParameter IsDestroyable = new StringParameter("is_destroyable");
        public readonly StringParameter Health = new StringParameter("health");
        public readonly StringParameter ModelToAttach = new StringParameter("model_to_attach");
        public readonly StringParameter AttachmentBone = new StringParameter("attachment_bone");
        public readonly StringParameter CollisionMesh = new StringParameter("collision_mesh");
        public readonly StringParameter DamageDecal = new StringParameter("damage_decal");
        public readonly StringParameter DamageParticles = new StringParameter("damage_particles");
        public readonly StringParameter EngineParticles = new StringParameter("engine_particles");
        public readonly StringParameter TooltipText = new StringParameter("tooltip_text");
        public readonly StringParameter FireBoneA = new StringParameter("fire_bone_a");
        public readonly StringParameter FireBoneB = new StringParameter("fire_bone_b");
        public readonly StringParameter RandomizeBetweenFireBones = new StringParameter("randomize_between_fire_bones");
        public readonly StringParameter FireConeWidth = new StringParameter("fire_cone_width");
        public readonly StringParameter FireConeHeight = new StringParameter("fire_cone_height");
        public readonly StringParameter FireProjectileType = new StringParameter("fire_projectile_type");
        public readonly StringParameter FireMinRechargeSeconds = new StringParameter("fire_min_recharge_seconds");
        public readonly StringParameter FireMaxRechargeSeconds = new StringParameter("fire_max_recharge_seconds");
        public readonly StringParameter FirePulseCount = new StringParameter("fire_pulse_count");
        public readonly StringParameter FirePulseDelaySeconds = new StringParameter("fire_pulse_delay_seconds");
        public readonly StringParameter FireRangeDistance = new StringParameter("fire_range_distance");
        public readonly StringParameter FireSfxEvent = new StringParameter("fire_sfxevent");
        public readonly StringParameter FireInaccuracyDistance = new StringParameter("fire_inaccuracy_distance");
        public readonly StringParameter FireCategoryRestrictions = new StringParameter("fire_category_restrictions");
        public readonly StringParameter FireWhenDeployed = new StringParameter("fire_when_deployed");
        public readonly StringParameter FireWhenUndeployed = new StringParameter("fire_when_undeployed");
        public readonly StringParameter FireWhenInRocketAttackMode = new StringParameter("fire_when_in_rocket_attack_mode");
        public readonly StringParameter FireWhenInNormalAttackMode = new StringParameter("fire_when_in_normal_attack_mode");
        public readonly StringParameter DeathExplosionParticles = new StringParameter("death_explosion_particles");
        public readonly StringParameter DeathExplosionSfxEvent = new StringParameter("death_explosion_sfxevent");
        public readonly StringParameter DeathBreakoffProp = new StringParameter("death_breakoff_prop");
        public readonly StringParameter DefendModeWeaponDelayMultiplier = new StringParameter("defend_mode_weapon_delay_multiplier");
        public readonly StringParameter TurboModeWeaponDelayMultiplier = new StringParameter("turbo_mode_weapon_delay_multiplier");
        public readonly StringParameter FireMinRangeDistance = new StringParameter("fire_min_range_distance");
        public readonly StringParameter AllowOpportunityFireWhenIdle = new StringParameter("allow_opportunity_fire_when_idle");
        public readonly StringParameter AllowOpportunityFireWhenTargeting = new StringParameter("allow_opportunity_fire_when_targeting");
        public readonly StringParameter FighterBayFlyoutDistance = new StringParameter("fighter_bay_flyout_distance");
        public readonly StringParameter SpecialAbilityName = new StringParameter("special_ability_name");
        public readonly StringParameter RepairCostPerFrame = new StringParameter("repair_cost_per_frame");
        public readonly StringParameter RepairAmountPerFrame = new StringParameter("repair_amount_per_frame");
        public readonly StringParameter ProjectileDamage = new StringParameter("projectile_damage");
        public readonly StringParameter DamageType = new StringParameter("damage_type");
        public readonly StringParameter ProjectileAppearanceDelayFrames = new StringParameter("projectile_appearance_delay_frames");
        public readonly StringParameter PowerToWeaponsModeWeaponDelayMultiplier = new StringParameter("power_to_weapons_mode_weapon_delay_multiplier");
        public readonly StringParameter FullSalvoWeaponDelayMultiplier = new StringParameter("full_salvo_weapon_delay_multiplier");
        public readonly StringParameter FireWhenInDefendMode = new StringParameter("fire_when_in_defend_mode");
        public readonly StringParameter FireWhenInTurboMode = new StringParameter("fire_when_in_turbo_mode");
        public readonly StringParameter FireWhenInPowerToWeaponsMode = new StringParameter("fire_when_in_power_to_weapons_mode");
        public readonly StringParameter EngineDeathHideEngineParticles = new StringParameter("engine_death_hide_engine_particles");
        public readonly StringParameter IsTurret = new StringParameter("is_turret");
        public readonly StringParameter TurretRestAngle = new StringParameter("turret_rest_angle");
        public readonly StringParameter TurretRotationOffset = new StringParameter("turret_rotation_offset");
        public readonly StringParameter TurretRotateSpeed = new StringParameter("turret_rotate_speed");
        public readonly StringParameter TurretRotateExtentDegrees = new StringParameter("turret_rotate_extent_degrees");
        public readonly StringParameter TurretElevateExtentDegrees = new StringParameter("turret_elevate_extent_degrees");
        public readonly StringParameter TurretBoneName = new StringParameter("turret_bone_name");
        public readonly StringParameter BarrelBoneName = new StringParameter("barrel_bone_name");
        public readonly StringParameter RequiresManualTargetAssignment = new StringParameter("requires_manual_target_assignment");
        public readonly StringParameter ManualHardpointFiringCooldownSecs = new StringParameter("manual_hardpoint_firing_cooldown_secs");
        public readonly StringParameter AllowsSpecialWeaponUse = new StringParameter("allows_special_weapon_use");
        public readonly StringParameter BlastAbilityFireProjectileType = new StringParameter("blast_ability_fire_projectile_type");
    }
}
