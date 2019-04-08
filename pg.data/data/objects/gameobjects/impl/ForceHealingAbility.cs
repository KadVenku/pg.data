using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class ForceHealingAbility : AbstractGameObjectType
    {
        public StringParameter HealRange { get; } = new StringParameter("heal_range");
        public StringParameter HealPercent { get; } = new StringParameter("heal_percent");
        public StringParameter HealAmount { get; } = new StringParameter("heal_amount");
        public StringParameter HealIntervalInSecs { get; } = new StringParameter("heal_interval_in_secs");
        public StringParameter SingleTargetHeal { get; } = new StringParameter("single_target_heal");
        public StringParameter HealRangeBlobMaterial { get; } = new StringParameter("heal_range_blob_material");
        public StringParameter BlobColor { get; } = new StringParameter("blob_color");
        
        public ForceHealingAbility(string id) : base(id)
        {
        }
    }
}