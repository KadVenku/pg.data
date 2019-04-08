using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class ReduceTechnologyPriceAbility : AbstractGameObjectType
    {
        public StringParameter PriceReductionPercentage { get; } = new StringParameter("price_reduction_percentage");
        
        public ReduceTechnologyPriceAbility(string id) : base(id)
        {
        }
    }
}