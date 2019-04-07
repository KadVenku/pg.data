using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class MaximumFirepowerAttackAbility : AbstractGameObjectType
    {
        public StringParameter Dummy { get; } = new StringParameter("dummy");
        public MaximumFirepowerAttackAbility(string id) : base(id)
        {
        }
    }
}
