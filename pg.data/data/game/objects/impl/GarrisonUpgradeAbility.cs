using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GarrisonUpgradeAbility : AbstractGameObjectType
    {
        public StringParameter AdditionalGarrisonUnits { get; } = new StringParameter("additional_garrison_units");
        public StringParameter ApplyToAllAllies { get; } = new StringParameter("apply_to_all_allies");
        
        public GarrisonUpgradeAbility(string id) : base(id)
        {
        }
    }
}