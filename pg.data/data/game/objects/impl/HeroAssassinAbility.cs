using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class HeroAssassinAbility : AbstractGameObjectType
    {
        public StringParameter CanAssassinateMinorHeroes { get; } = new StringParameter("can_assassinate_minor_heroes");
        public StringParameter CanAssassinateMajorHeroes { get; } = new StringParameter("can_assassinate_major_heroes");
        public StringParameter TriggerOnlyOnDefense { get; } = new StringParameter("trigger_only_on_defense");
        public StringParameter ChanceToSucceed { get; } = new StringParameter("chance_to_succeed");
        public StringParameter ChanceToBeCaughtUponFailure { get; } = new StringParameter("chance_to_be_caught_upon_failure");
        
        public HeroAssassinAbility(string id) : base(id)
        {
        }
    }
}