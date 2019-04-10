using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class MousePointerData : AbstractGameObjectType
    {
        public StringParameter BaseTexture { get; } = new StringParameter("base_texture");
        public StringParameter HotX { get; } = new StringParameter("hot_x");
        public StringParameter HotY { get; } = new StringParameter("hot_y");
        public StringParameter AnimFrameDelay { get; } = new StringParameter("anim_frame_delay");
        
        public MousePointerData(string id) : base(id)
        {
        }
    }
}