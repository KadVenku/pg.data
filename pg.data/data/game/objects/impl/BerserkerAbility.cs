using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class BerserkerAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter BerserkerSpeed { get; } = new StringParameter("berserker_speed");
        public StringParameter BerserkerDamage { get; } = new StringParameter("berserker_damage");
        public StringParameter BerserkerDamageRange { get; } = new StringParameter("berserker_damage_range");
        public StringParameter BerserkerDurationInSecs { get; } = new StringParameter("berserker_duration_in_secs");
        
        public BerserkerAbility(string id) : base(id)
        {
        }
    }
}