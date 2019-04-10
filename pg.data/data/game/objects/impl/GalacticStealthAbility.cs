using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class GalacticStealthAbility : AbstractGameObjectType
    {
        public StringParameter EvadeDetectionChance { get; } = new StringParameter("evade_detection_chance");

        public GalacticStealthAbility(string id) : base(id)
        {
        }
    }
}
