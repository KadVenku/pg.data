using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class RadarMap : AbstractGameObjectType
    {
        public StringParameter Color { get; } = new StringParameter("color");
        public StringParameter SpacePositionRightBottom { get; } = new StringParameter("space_position_rightbottom");
        public StringParameter SpacePositionLeftTop { get; } = new StringParameter("space_position_lefttop");
        public StringParameter LandPositionRightBottom { get; } = new StringParameter("land_position_rightbottom");
        public StringParameter LandPositionLeftTop { get; } = new StringParameter("land_position_lefttop");
        public StringParameter SpaceBackdropTextureName { get; } = new StringParameter("space_backdrop_texture_name");
        public StringParameter LandBackdropTextureName { get; } = new StringParameter("land_backdrop_texture_name");
        public StringParameter LandFowColor { get; } = new StringParameter("land_fow_color");
        public StringParameter SpaceFowColor { get; } = new StringParameter("space_fow_color");
        public StringParameter SpaceIsGuideRectangle { get; } = new StringParameter("space_is_guide_rectangle");
        public StringParameter LandIsGuideRectangle { get; } = new StringParameter("land_is_guide_rectangle");
        public StringParameter SpaceAsteroidFieldColor { get; } = new StringParameter("space_asteroid_field_color");
        public StringParameter SpaceAsteroidFieldBorderColor { get; } = new StringParameter("space_asteroid_field_border_color");
        public StringParameter UseEventSystem { get; } = new StringParameter("use_event_system");
        public StringParameter EventModelName { get; } = new StringParameter("event_model_name");
        public StringParameter EventModelScale { get; } = new StringParameter("event_model_scale");
        public StringParameter EventDuration { get; } = new StringParameter("event_duration");
        public StringParameter EventSingleInstance { get; } = new StringParameter("event_single_instance");
        public StringParameter EventPersistent { get; } = new StringParameter("event_persistent");

        public RadarMap(string id) : base(id)
        {
        }
    }
}
