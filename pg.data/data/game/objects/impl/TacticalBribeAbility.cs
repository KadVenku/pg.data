using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class TacticalBribeAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter BribedEffect { get; } = new StringParameter("bribed_effect");
        public StringParameter BribedEffectSmall { get; } = new StringParameter("bribed_effect_small");
        public StringParameter EffectZOffset { get; } = new StringParameter("effect_z_offset");
        public StringParameter SfxEventSuccess { get; } = new StringParameter("sfxevent_success");
        public StringParameter SfxEventFail { get; } = new StringParameter("sfxevent_fail");
        
        public TacticalBribeAbility(string id) : base(id)
        {
        }
    }
}