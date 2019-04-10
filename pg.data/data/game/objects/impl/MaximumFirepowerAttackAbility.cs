using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class MaximumFirepowerAttackAbility : AbstractGameObjectType
    {
        public StringParameter Dummy { get; } = new StringParameter("dummy");
        public MaximumFirepowerAttackAbility(string id) : base(id)
        {
        }
    }
}
