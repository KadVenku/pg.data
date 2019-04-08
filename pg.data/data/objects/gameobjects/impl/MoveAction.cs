using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class MoveAction : AbstractGameObjectType
    {
        public StringParameter MoveType { get; } = new StringParameter("move_type");
        public StringParameter MoveSpeed { get; } = new StringParameter("move_speed");
        public StringParameter WaitForFinishIfTargetUsingJetpack { get; } = new StringParameter("wait_for_finish_if_target_using_jetpack");
        public StringParameter MoveAnimationOverride { get; } = new StringParameter("move_animation_override");
        public StringParameter MoveAnimationType { get; } = new StringParameter("move_animation_type");
        public StringParameter MoveAnimationSubindex { get; } = new StringParameter("move_animation_subindex");
        public StringParameter MoveAnimationSpeedup { get; } = new StringParameter("move_animation_speedup");
        public StringParameter MoveMinDistance { get; } = new StringParameter("move_min_distance");
        public StringParameter MoveMaxDistance { get; } = new StringParameter("move_max_distance");
        public StringParameter MoveUseJetpack { get; } = new StringParameter("move_use_jetpack");
        
        public MoveAction(string id) : base(id)
        {
        }
    }
}