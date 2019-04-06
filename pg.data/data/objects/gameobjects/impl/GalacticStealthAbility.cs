using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class GalacticStealthAbility : AbstractGameObjectType
    {
        public readonly StringParameter EvadeDetectionChance = new StringParameter("evade_detection_chance");
    }
}
