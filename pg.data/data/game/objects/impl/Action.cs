using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class Action : AbstractGameObjectType
    {
        public StringParameter ActionObject { get; } = new StringParameter("action_object");
        public StringParameter ActionTarget { get; } = new StringParameter("action_target");
        public StringParameter ActionRelevanceType { get; } = new StringParameter("action_relevance_type");
        public StringParameter ActionRelevanceConstant { get; } = new StringParameter("action_relevance_constant");
        public StringParameter ActionDistanceFromTargetCurve { get; } = new StringParameter("action_distance_from_target_curve");
        public StringParameter ActionHealthPercentageCurve { get; } = new StringParameter("action_health_percentage_curve");
        
        public Action(string id) : base(id)
        {
        }
    }
}