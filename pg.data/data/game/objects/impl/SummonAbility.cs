using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SummonAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter ObjectType { get; } = new StringParameter("object_type");
        public StringParameter CreationDelayInSeconds { get; } = new StringParameter("creation_delay_in_seconds");
        public StringParameter SfxEventUnitSummoned { get; } = new StringParameter("sfxevent_unit_summoned");
        
        public SummonAbility(string id) : base(id)
        {
        }
    }
}