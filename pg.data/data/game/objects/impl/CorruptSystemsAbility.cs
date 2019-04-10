using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class CorruptSystemsAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DurationInSeconds { get; } = new StringParameter("duration_in_seconds");
        public StringParameter ShieldDrainPerSecond { get; } = new StringParameter("shield_drain_per_second");
        public StringParameter InaccuracyRadius { get; } = new StringParameter("inaccuracy_radius");
        
        public CorruptSystemsAbility(string id) : base(id)
        {
        }
    }
}