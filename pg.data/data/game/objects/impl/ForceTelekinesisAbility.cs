using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ForceTelekinesisAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamagePercentage { get; } = new StringParameter("damage_percentage");
        public StringParameter DamageIntervalInSecs { get; } = new StringParameter("damage_interval_in_secs");
        
        public ForceTelekinesisAbility(string id) : base(id)
        {
        }
    }
}