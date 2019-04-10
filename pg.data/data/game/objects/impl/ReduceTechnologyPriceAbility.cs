using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ReduceTechnologyPriceAbility : AbstractGameObjectType
    {
        public StringParameter PriceReductionPercentage { get; } = new StringParameter("price_reduction_percentage");
        
        public ReduceTechnologyPriceAbility(string id) : base(id)
        {
        }
    }
}