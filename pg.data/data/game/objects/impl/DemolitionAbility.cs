using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class DemolitionAbility : AbstractGameObjectType
    {
        public StringParameter ActivationChance { get; } = new StringParameter("activation_chance");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamagePercentage { get; } = new StringParameter("damage_percentage");
        public StringParameter BombType { get; } = new StringParameter("bomb_type");
        public StringParameter BombPositionOffset { get; } = new StringParameter("bomb_position_offset");
        public StringParameter BombSpawnFrame { get; } = new StringParameter("bomb_spawn_frame");
        public StringParameter BombDamageType { get; } = new StringParameter("bomb_damage_type");
        public StringParameter BombTimerInSecs { get; } = new StringParameter("bomb_timer_in_secs");
        
        public DemolitionAbility(string id) : base(id)
        {
        }
    }
}