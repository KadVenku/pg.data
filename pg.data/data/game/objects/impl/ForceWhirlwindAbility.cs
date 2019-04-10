using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ForceWhirlwindAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamageRange { get; } = new StringParameter("damage_range");
        public StringParameter TravelTimeInSecs { get; } = new StringParameter("travel_time_in_secs");
        
        public ForceWhirlwindAbility(string id) : base(id)
        {
        }
    }
}