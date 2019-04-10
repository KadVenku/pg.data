using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class AIGoalType : AbstractGameObjectType
    {
        public StringParameter AiGoalApplicationFlags { get; } = new StringParameter("aigoalapplicationflags");
        public StringParameter GameMode { get; } = new StringParameter("gamemode");
        public StringParameter Category { get; } = new StringParameter("category");
        public StringParameter Reachability { get; } = new StringParameter("reachability");
        public StringParameter TimeLimit { get; } = new StringParameter("time_limit");
        public StringParameter BuildTimeDelayTolerance { get; } = new StringParameter("build_time_delay_tolerance");
        public StringParameter IsLike { get; } = new StringParameter("is_like");
        public StringParameter GlobalExclusions { get; } = new StringParameter("global_exclusions");
        public StringParameter TrackingDuration { get; } = new StringParameter("tracking_duration");
        public StringParameter PerFailureDesireAdjust { get; } = new StringParameter("per_failure_desire_adjust");
        public StringParameter ActivationTrackingDuration { get; } = new StringParameter("activation_tracking_duration");
        public StringParameter PerActivationFailureDesireAdjust { get; } = new StringParameter("per_activation_failure_desire_adjust");
        
        public AIGoalType(string id) : base(id)
        {
        }
    }
}