using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GalaxyWideUpgradeAbility : AbstractGameObjectType
    {
        public StringParameter SpaceUpgradeType { get; } = new StringParameter("space_upgrade_type");
        public StringParameter LandUpgradeType { get; } = new StringParameter("land_upgrade_type");
        
        public GalaxyWideUpgradeAbility(string id) : base(id)
        {
        }
    }
}