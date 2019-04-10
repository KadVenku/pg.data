using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GalacticSabotageAbility : AbstractGameObjectType
    {
        public StringParameter CanReduceGroundBaseLevel { get; } = new StringParameter("can_reduce_ground_base_level");
        public StringParameter CanReduceStarbaseLevel { get; } = new StringParameter("can_reduce_starbase_level");
        public StringParameter CanCancelProduction { get; } = new StringParameter("can_cancel_production");
        public StringParameter CanDestroySpecialStructure { get; } = new StringParameter("can_destroy_special_structure");
        public StringParameter CanHaltCreditProduction { get; } = new StringParameter("can_halt_credit_production");
        public StringParameter DurationOfCreditHalt { get; } = new StringParameter("duration_of_credit_halt");
        public StringParameter SabotageCostIncreaseFactor { get; } = new StringParameter("sabotage_cost_increase_factor");
        
        public GalacticSabotageAbility(string id) : base(id)
        {
        }
    }
}