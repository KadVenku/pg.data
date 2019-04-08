using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class RetreatProtectionAbility : AbstractGameObjectType
    {
        public StringParameter RetreatLossMitigation { get; } = new StringParameter("retreat_loss_mitigation");
        public StringParameter StackingCategory { get; } = new StringParameter("stacking_category");
        
        public RetreatProtectionAbility(string id) : base(id)
        {
        }
    }
}