using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class ForceLightningAbility : AbstractGameObjectType
    {
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter DamageAmount { get; } = new StringParameter("damage_amount");
        public StringParameter DamageApplicationTimeInSecs { get; } = new StringParameter("damage_application_time_in_secs");
        public StringParameter StartLightningFrameNumber { get; } = new StringParameter("start_lightning_frame_number");
        public StringParameter LightningEffectName { get; } = new StringParameter("lightning_effect_name");
        public StringParameter LightningSourceBoneName { get; } = new StringParameter("lightning_source_bone_name");
        public StringParameter LightningTargetBoneName { get; } = new StringParameter("lightning_target_bone_name");
        public StringParameter LightningMaxTargets { get; } = new StringParameter("lightning_max_targets");
        public StringParameter LightningTargetsRadius { get; } = new StringParameter("lightning_targets_radius");
        
        public ForceLightningAbility(string id) : base(id)
        {
        }
    }
}