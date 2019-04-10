using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ProximityMinesAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter MineType { get; } = new StringParameter("mine_type");
        public StringParameter TriggerRadius { get; } = new StringParameter("trigger_radius");
        public StringParameter NumberOfMines { get; } = new StringParameter("number_of_mines");
        public StringParameter ActivationTimeInSeconds { get; } = new StringParameter("activation_time_in_seconds");
        public StringParameter ActivateSfx { get; } = new StringParameter("activate_sfx");
        
        public ProximityMinesAbility(string id) : base(id)
        {
        }
    }
}