using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BlastAbility : AbstractGameObjectType
    {
        public StringParameter ChargeUpSeconds { get; } = new StringParameter("charge_up_seconds");
        public StringParameter DamageMultiplier { get; } = new StringParameter("damage_multiplier");
        public StringParameter ChargingEffect { get; } = new StringParameter("charging_effect");
        public StringParameter ChargedEffect { get; } = new StringParameter("charged_effect");
        
        public BlastAbility(string id) : base(id)
        {
        }
    }
}