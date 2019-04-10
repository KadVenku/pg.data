using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class IonCannonShotAttackAbility : AbstractGameObjectType
    {
        public StringParameter Dummy { get; } = new StringParameter("dummy");
        public IonCannonShotAttackAbility(string id) : base(id)
        {
        }
    }
}
