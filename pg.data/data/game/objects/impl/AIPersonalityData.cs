using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class AIPersonalityData : AbstractGameObjectType
    {
        public StringParameter Aggressiveness { get; } = new StringParameter("aggressiveness");
        public StringParameter Focus { get; } = new StringParameter("focus");
        
        public AIPersonalityData(string id) : base(id)
        {
        }
    }
}