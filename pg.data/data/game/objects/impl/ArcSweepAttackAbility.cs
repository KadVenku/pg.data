using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ArcSweepAttackAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamagePercentage { get; } = new StringParameter("damage_percentage");
        public StringParameter DamageType { get; } = new StringParameter("damage_type");
        public StringParameter AttackAnimation { get; } = new StringParameter("attack_animation");
        public StringParameter AttackAnimationSpeedup { get; } = new StringParameter("attack_animation_speedup");
        public StringParameter AttackAnimationSubindex { get; } = new StringParameter("attack_animation_subindex");
        public StringParameter ArcWidthInDegrees { get; } = new StringParameter("arc_width_in_degrees");
        public StringParameter ArcMinRange { get; } = new StringParameter("arc_min_range");
        public StringParameter ArcMaxRange { get; } = new StringParameter("arc_max_range");
        public StringParameter DamageSweepTimeInSecs { get; } = new StringParameter("damage_sweep_time_in_secs");
        public StringParameter BeginApplyingDamageFrame { get; } = new StringParameter("begin_applying_damage_frame");
        public StringParameter ApplyDamageRightToLeft { get; } = new StringParameter("apply_damage_right_to_left");
        
        public ArcSweepAttackAbility(string id) : base(id)
        {
        }
    }
}