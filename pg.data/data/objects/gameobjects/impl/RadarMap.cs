using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class RadarMap : AbstractGameObjectType
    {
        public readonly StringParameter Color = new StringParameter("color");
        public readonly StringParameter SpacePositionRightBottom = new StringParameter("space_position_rightbottom");
        public readonly StringParameter SpacePositionLeftTop = new StringParameter("space_position_lefttop");
        public readonly StringParameter LandPositionRightBottom = new StringParameter("land_position_rightbottom");
        public readonly StringParameter LandPositionLeftTop = new StringParameter("land_position_lefttop");
        public readonly StringParameter SpaceBackdropTextureName = new StringParameter("space_backdrop_texture_name");
        public readonly StringParameter LandBackdropTextureName = new StringParameter("land_backdrop_texture_name");
        public readonly StringParameter LandFowColor = new StringParameter("land_fow_color");
        public readonly StringParameter SpaceFowColor = new StringParameter("space_fow_color");
        public readonly StringParameter SpaceIsGuideRectangle = new StringParameter("space_is_guide_rectangle");
        public readonly StringParameter LandIsGuideRectangle = new StringParameter("land_is_guide_rectangle");
        public readonly StringParameter SpaceAsteroidFieldColor = new StringParameter("space_asteroid_field_color");
        public readonly StringParameter SpaceAsteroidFieldBorderColor = new StringParameter("space_asteroid_field_border_color");
        public readonly StringParameter UseEventSystem = new StringParameter("use_event_system");
        public readonly StringParameter EventModelName = new StringParameter("event_model_name");
        public readonly StringParameter EventModelScale = new StringParameter("event_model_scale");
        public readonly StringParameter EventDuration = new StringParameter("event_duration");
        public readonly StringParameter EventSingleInstance = new StringParameter("event_single_instance");
        public readonly StringParameter EventPersistent = new StringParameter("event_persistent");
    }
}
