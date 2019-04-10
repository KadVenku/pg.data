using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class EatAttackAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamagePercentage { get; } = new StringParameter("damage_percentage");
        public StringParameter DamageType { get; } = new StringParameter("damage_type");
        public StringParameter AttackAnimation { get; } = new StringParameter("attack_animation");
        public StringParameter AttackAnimationSpeedup { get; } = new StringParameter("attack_animation_speedup");
        public StringParameter OwnerAttachmentBone { get; } = new StringParameter("owner_attachment_bone");
        public StringParameter TargetAttachmentBone { get; } = new StringParameter("target_attachment_bone");
        public StringParameter AttachmentFrame { get; } = new StringParameter("attachment_frame");
        public StringParameter TargetDestructionFrame { get; } = new StringParameter("target_destruction_frame");
        public StringParameter TargetGrabbedAnimation { get; } = new StringParameter("target_grabbed_animation");
        public StringParameter NeedsToRotate { get; } = new StringParameter("needs_to_rotate");
        public StringParameter RotationBaseBoneName { get; } = new StringParameter("rotation_base_bone_name");
        public StringParameter HealthPerVictim { get; } = new StringParameter("health_per_victim");
        
        public EatAttackAbility(string id) : base(id)
        {
        }
    }
}