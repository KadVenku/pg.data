using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class AttackAction : AbstractGameObjectType
    {
        public StringParameter AttackProjectileType { get; } = new StringParameter("attack_projectile_type");
        public StringParameter AttackAnimationType { get; } = new StringParameter("attack_animation_type");
        public StringParameter AttackAnimationSubindex { get; } = new StringParameter("attack_animation_subindex");
        public StringParameter AttackAnimationSpeedup { get; } = new StringParameter("attack_animation_speedup");
        public StringParameter AttackFiringBoneName { get; } = new StringParameter("attack_firing_bone_name");
        public StringParameter AttackNumberOfShots { get; } = new StringParameter("attack_number_of_shots");
        public StringParameter AttackAccuracyModifier { get; } = new StringParameter("attack_accuracy_modifier");
        public StringParameter AttackSfxEvent { get; } = new StringParameter("attack_sfxevent");
        
        public AttackAction(string id) : base(id)
        {
        }
    }
}