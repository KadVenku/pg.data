using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class CorruptionAbility : AbstractGameObjectType
    {
        public StringParameter Foo { get; } = new StringParameter("foo");
        
        public CorruptionAbility(string id) : base(id)
        {
        }
    }
}