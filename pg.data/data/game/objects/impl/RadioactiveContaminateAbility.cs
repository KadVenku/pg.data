using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class RadioactiveContaminateAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("Activation_Min_Range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("Activation_Max_Range");
        public StringParameter SprayTimeInSecs { get; } = new StringParameter("Spray_Time_In_Secs");
        public StringParameter EmitterName { get; } = new StringParameter("Emitter_Name");
        public StringParameter ContaminationObjectName { get; } = new StringParameter("Contamination_Object_Name");
        public StringParameter SfXEventRadioactive { get; } = new StringParameter("SFXEvent_Radioactive");
        
        public RadioactiveContaminateAbility(string id) : base(id)
        {
        }
    }
}