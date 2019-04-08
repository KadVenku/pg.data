using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
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