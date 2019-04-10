using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GenericAttackAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamagePercentage { get; } = new StringParameter("damage_percentage");
        public StringParameter DamageType { get; } = new StringParameter("damage_type");
        public StringParameter AttackAnimation { get; } = new StringParameter("attack_animation");
        public StringParameter AttackAnimationSpeedup { get; } = new StringParameter("attack_animation_speedup");
        public StringParameter DamageFrameNumber { get; } = new StringParameter("damage_frame_number");
        
        public GenericAttackAbility(string id) : base(id)
        {
        }
    }
}