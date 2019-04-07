using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class IonCannonShotAttackAbility : AbstractGameObjectType
    {
        public StringParameter Dummy { get; } = new StringParameter("dummy");
        public IonCannonShotAttackAbility(string id) : base(id)
        {
        }
    }
}
