using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
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