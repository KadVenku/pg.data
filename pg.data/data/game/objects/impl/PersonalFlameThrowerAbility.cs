using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class PersonalFlameThrowerAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageArcInDegrees { get; } = new StringParameter("damage_arc_in_degrees");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter FireTimeInSecs { get; } = new StringParameter("fire_time_in_secs");
        public StringParameter RechargeTimeInSecs { get; } = new StringParameter("recharge_time_in_secs");
        public StringParameter DamageDelayInSecs { get; } = new StringParameter("damage_delay_in_secs");
        public StringParameter FlameEmitterModelName { get; } = new StringParameter("flame_emitter_model_name");
        public StringParameter DamageType { get; } = new StringParameter("damage_type");
        
        public PersonalFlameThrowerAbility(string id) : base(id)
        {
        }
    }
}