using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class GalacticStealthAbility : AbstractGameObjectType
    {
        public StringParameter EvadeDetectionChance { get; } = new StringParameter("evade_detection_chance");

        public GalacticStealthAbility(string id) : base(id)
        {
        }
    }
}
