using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SabotagePoliticalControlAbility : AbstractGameObjectType
    {
        public readonly StringParameter PoliticalChange = new StringParameter("political_change");
        public readonly StringParameter ChangeDurationInSeconds = new StringParameter("change_duration_in_seconds");
    }
}
