using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class VehicleThiefAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        
        public VehicleThiefAbility(string id) : base(id)
        {
        }
    }
}