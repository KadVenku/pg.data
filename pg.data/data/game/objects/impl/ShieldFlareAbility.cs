using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ShieldFlareAbility : AbstractGameObjectType
    {
        public StringParameter MaxDamagePerVictim { get; } = new StringParameter("max_damage_per_victim");
        public StringParameter DamageRadius { get; } = new StringParameter("damage_radius");
        public StringParameter ChargeUpSeconds { get; } = new StringParameter("charge_up_seconds");
        
        public ShieldFlareAbility(string id) : base(id)
        {
        }
    }
}