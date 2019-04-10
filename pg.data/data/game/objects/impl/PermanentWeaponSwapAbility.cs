using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class PermanentWeaponSwapAbility : AbstractGameObjectType
    {
        public StringParameter WeaponIndex { get; } = new StringParameter("weapon_index");
        
        public PermanentWeaponSwapAbility(string id) : base(id)
        {
        }
    }
}