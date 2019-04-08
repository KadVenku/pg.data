using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed  class FindWeaknessAbility : AbstractGameObjectType
    {
        public StringParameter DamageBonusPercentage { get; } = new StringParameter("damage_bonus_percentage");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        
        public FindWeaknessAbility(string id) : base(id)
        {
        }
    }
}