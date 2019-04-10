using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class HackAbility : AbstractGameObjectType
    {
        public StringParameter TeamMemberWithAbility { get; } = new StringParameter("team_member_with_ability");
        public StringParameter ActivationMinRange { get; } = new StringParameter("activation_min_range");
        public StringParameter ActivationMaxRange { get; } = new StringParameter("activation_max_range");
        public StringParameter LightningEffectName { get; } = new StringParameter("lightning_effect_name");
        public StringParameter LightningSourceBoneName { get; } = new StringParameter("lightning_source_bone_name");
        public StringParameter LightningTargetBoneName { get; } = new StringParameter("lightning_target_bone_name");
        public StringParameter LightningMaxTargets { get; } = new StringParameter("lightning_max_targets");
        public StringParameter LightningTargetsRadius { get; } = new StringParameter("lightning_targets_radius");
        
        public HackAbility(string id) : base(id)
        {
        }
    }
}