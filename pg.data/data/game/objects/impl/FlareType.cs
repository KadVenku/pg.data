using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class FlareType : AbstractGameObjectType
    {
        public StringParameter Diffuse { get; } = new StringParameter("diffuse");
        public StringParameter Radius { get; } = new StringParameter("radius");
        public StringParameter Fraction { get; } = new StringParameter("fraction");
        public StringParameter SlotX { get; } = new StringParameter("slot_x");
        public StringParameter SlotY { get; } = new StringParameter("slot_y");
        public StringParameter NumSlots { get; } = new StringParameter("num_slots");
        
        public FlareType(string id) : base(id)
        {
        }
    }
}