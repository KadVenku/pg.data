using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BaseDestructionAbility : AbstractGameObjectType
    {
        public StringParameter DestroyStarbase { get; } = new StringParameter("destroy_starbase");
        public StringParameter DestroyLandBase { get; } = new StringParameter("destroy_land_base");
        
        public BaseDestructionAbility(string id) : base(id)
        {
        }
    }
}