using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class AIGoalProposalFunction : AbstractGameObjectType
    {
        public StringParameter Function { get; } = new StringParameter("function");
        public StringParameter Goal { get; } = new StringParameter("goal");
        
        public AIGoalProposalFunction(string id) : base(id)
        {
        }
    }
}