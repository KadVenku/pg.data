using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SaberThrowAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter CatchDist { get; } = new StringParameter("catch_dist");
        public StringParameter SaberName { get; } = new StringParameter("saber_name");
        
        public SaberThrowAbility(string id) : base(id)
        {
        }
    }
}