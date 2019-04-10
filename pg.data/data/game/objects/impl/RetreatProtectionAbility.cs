using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
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