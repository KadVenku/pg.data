using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class TacticalCameraConstants : AbstractGameObjectType
    {
        public StringParameter PitchDefault { get; } = new StringParameter("pitch_default");
        public StringParameter PitchMin { get; } = new StringParameter("pitch_min");
        public StringParameter PitchMax { get; } = new StringParameter("pitch_max");
        public StringParameter PitchPerMouseUnit { get; } = new StringParameter("pitch_per_mouse_unit");
        public StringParameter PitchPerZoomUnit { get; } = new StringParameter("pitch_per_zoom_unit");
        public StringParameter PitchWhenZoomedIn { get; } = new StringParameter("pitch_when_zoomed_in");
        public StringParameter PitchZoomBeginFraction { get; } = new StringParameter("pitch_zoom_begin_fraction");
        public StringParameter YawDefault { get; } = new StringParameter("yaw_default");
        public StringParameter YawMin { get; } = new StringParameter("yaw_min");
        public StringParameter YawMax { get; } = new StringParameter("yaw_max");
        public StringParameter YawPerMouseUnit { get; } = new StringParameter("yaw_per_mouse_unit");
        public StringParameter FovDefault { get; } = new StringParameter("fov_default");
        public StringParameter FovMin { get; } = new StringParameter("fov_min");
        public StringParameter FovMax { get; } = new StringParameter("fov_max");
        public StringParameter FovPerMouseUnit { get; } = new StringParameter("fov_per_mouse_unit");
        public StringParameter FovSmoothTime { get; } = new StringParameter("fov_smooth_time");
        public StringParameter DistanceDefault { get; } = new StringParameter("distance_default");
        public StringParameter DistanceMin { get; } = new StringParameter("distance_min");
        public StringParameter DistanceMax { get; } = new StringParameter("distance_max");
        public StringParameter DistancePerMouseUnit { get; } = new StringParameter("distance_per_mouse_unit");
        public StringParameter DistanceSmoothTime { get; } = new StringParameter("distance_smooth_time");
        public StringParameter UseSplines { get; } = new StringParameter("use_splines");
        public StringParameter DistanceSpline { get; } = new StringParameter("distance_spline");
        public StringParameter PitchSpline { get; } = new StringParameter("pitch_spline");
        public StringParameter SplineSteps { get; } = new StringParameter("spline_steps");
        public StringParameter SplineSmoothTime { get; } = new StringParameter("spline_smooth_time");
        public StringParameter TacticalOverviewDistance { get; } = new StringParameter("tactical_overview_distance");
        public StringParameter TacticalOverviewPitch { get; } = new StringParameter("tactical_overview_pitch");
        public StringParameter TacticalOverviewFov { get; } = new StringParameter("tactical_overview_fov");
        public StringParameter TacticalOverviewClicks { get; } = new StringParameter("tactical_overview_clicks");
        public StringParameter TacticalOverviewClickTime { get; } = new StringParameter("tactical_overview_click_time");
        public StringParameter TacticalOverviewDistance2 { get; } = new StringParameter("tactical_overview_distance2");
        public StringParameter TacticalOverviewPitch2 { get; } = new StringParameter("tactical_overview_pitch2");
        public StringParameter TacticalOverviewFov2 { get; } = new StringParameter("tactical_overview_fov2");
        public StringParameter LocationFollowsTerrain { get; } = new StringParameter("location_follows_terrain");
        public StringParameter LocationHeightUpSmoothTime { get; } = new StringParameter("location_height_up_smooth_time");
        public StringParameter LocationHeightDownSmoothTime { get; } = new StringParameter("location_height_down_smooth_time");
        public StringParameter MinHeightAboveTerrain { get; } = new StringParameter("min_height_above_terrain");
        public StringParameter NearClip { get; } = new StringParameter("near_clip");
        public StringParameter FarClip { get; } = new StringParameter("far_clip");
        public StringParameter ObjectFadeBegin { get; } = new StringParameter("object_fade_begin");
        public StringParameter ObjectFadeEnd { get; } = new StringParameter("object_fade_end");
        public StringParameter SideBoundsBuffer { get; } = new StringParameter("side_bounds_buffer");
        public StringParameter TopBoundsBuffer { get; } = new StringParameter("top_bounds_buffer");
        public StringParameter BottomBoundsBuffer { get; } = new StringParameter("bottom_bounds_buffer");
        
        public TacticalCameraConstants(string id) : base(id)
        {
        }
    }
}