using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class CommandBarComponent : AbstractGameObjectType
    {
        public StringParameter SelectedTextureName { get; } = new StringParameter("selected_texture_name");
        public StringParameter BlankTextureName { get; } = new StringParameter("blank_texture_name");
        public StringParameter IconTextureName { get; } = new StringParameter("icon_texture_name");
        public StringParameter IconAlternateTextureName { get; } = new StringParameter("icon_alternate_texture_name");
        public StringParameter MouseOverTextureName { get; } = new StringParameter("mouse_over_texture_name");
        public StringParameter DisabledTextureName { get; } = new StringParameter("disabled_texture_name");
        public StringParameter FlashTextureName { get; } = new StringParameter("flash_texture_name");
        public StringParameter BarTextureName { get; } = new StringParameter("bar_texture_name");
        public StringParameter BarOverlayName { get; } = new StringParameter("bar_overlay_name");
        public StringParameter BuildTextureName { get; } = new StringParameter("build_texture_name");
        public StringParameter ModelName { get; } = new StringParameter("model_name");
        public StringParameter BoneName { get; } = new StringParameter("bone_name");
        public StringParameter CursorTextureName { get; } = new StringParameter("cursor_texture_name");
        public StringParameter FontName { get; } = new StringParameter("font_name");
        public StringParameter AlternateFontName { get; } = new StringParameter("alternate_font_name");
        public StringParameter TooltipText { get; } = new StringParameter("tooltip_text");
        public StringParameter ClickSfx { get; } = new StringParameter("click_sfx");
        public StringParameter MouseOverSfx { get; } = new StringParameter("mouse_over_sfx");
        public StringParameter LowerEffectTextureName { get; } = new StringParameter("lower_effect_texture_name");
        public StringParameter UpperEffectTextureName { get; } = new StringParameter("upper_effect_texture_name");
        public StringParameter OverlayTextureName { get; } = new StringParameter("overlay_texture_name");
        public StringParameter Overlay2TextureName { get; } = new StringParameter("overlay2_texture_name");
        public StringParameter RightClickSfx { get; } = new StringParameter("right_click_sfx");
        public StringParameter Type { get; } = new StringParameter("type");
        public StringParameter Group { get; } = new StringParameter("group");
        public StringParameter DragAndDrop { get; } = new StringParameter("drag_and_drop");
        public StringParameter DragSelect { get; } = new StringParameter("drag_select");
        public StringParameter Receptor { get; } = new StringParameter("receptor");
        public StringParameter Toggle { get; } = new StringParameter("toggle");
        public StringParameter Tab { get; } = new StringParameter("tab");
        public StringParameter AssociatedText { get; } = new StringParameter("associated_text");
        public StringParameter Hidden { get; } = new StringParameter("hidden");
        public StringParameter Scale { get; } = new StringParameter("scale");
        public StringParameter Color { get; } = new StringParameter("color");
        public StringParameter TextColor { get; } = new StringParameter("text_color");
        public StringParameter TextColor2 { get; } = new StringParameter("text_color2");
        public StringParameter Size { get; } = new StringParameter("size");
        public StringParameter ClearColor { get; } = new StringParameter("clear_color");
        public StringParameter Disabled { get; } = new StringParameter("disabled");
        public StringParameter SwapTexture { get; } = new StringParameter("swap_texture");
        public StringParameter BaseLayer { get; } = new StringParameter("base_layer");
        public StringParameter DrawAdditive { get; } = new StringParameter("draw_additive");
        public StringParameter TextOffset { get; } = new StringParameter("text_offset");
        public StringParameter TextOffset2 { get; } = new StringParameter("text_offset2");
        public StringParameter Offset { get; } = new StringParameter("offset");
        public StringParameter DefaultOffset { get; } = new StringParameter("default_offset");
        public StringParameter DefaultOffsetWidescreen { get; } = new StringParameter("default_offset_widescreen");
        public StringParameter IconOffset { get; } = new StringParameter("icon_offset");
        public StringParameter MouseOverOffset { get; } = new StringParameter("mouse_over_offset");
        public StringParameter DisabledOffset { get; } = new StringParameter("disabled_offset");
        public StringParameter BuildDialOffset { get; } = new StringParameter("build_dial_offset");
        public StringParameter BuildDial2Offset { get; } = new StringParameter("build_dial2_offset");
        public StringParameter LowerEffectOffset { get; } = new StringParameter("lower_effect_offset");
        public StringParameter UpperEffectOffset { get; } = new StringParameter("upper_effect_offset");
        public StringParameter OverlayOffset { get; } = new StringParameter("overlay_offset");
        public StringParameter Overlay2Offset { get; } = new StringParameter("overlay2_offset");
        public StringParameter Editable { get; } = new StringParameter("editable");
        public StringParameter MaxTextLength { get; } = new StringParameter("max_text_length");
        public StringParameter BlinkRate { get; } = new StringParameter("blink_rate");
        public StringParameter FontPointSize { get; } = new StringParameter("font_point_size");
        public StringParameter TextOutline { get; } = new StringParameter("text_outline");
        public StringParameter MaxTextWidth { get; } = new StringParameter("max_text_width");
        public StringParameter Stackable { get; } = new StringParameter("stackable");
        public StringParameter ModelOffsetX { get; } = new StringParameter("model_offset_x");
        public StringParameter ModelOffsetY { get; } = new StringParameter("model_offset_y");
        public StringParameter ScaleModelX { get; } = new StringParameter("scale_model_x");
        public StringParameter ScaleModelY { get; } = new StringParameter("scale_model_y");
        public StringParameter Collideable { get; } = new StringParameter("collideable");
        public StringParameter TextEmboss { get; } = new StringParameter("text_emboss");
        public StringParameter ShouldGhost { get; } = new StringParameter("should_ghost");
        public StringParameter GhostBaseOnly { get; } = new StringParameter("ghost_base_only");
        public StringParameter MaxBarLevel { get; } = new StringParameter("max_bar_level");
        public StringParameter MaxBarColor { get; } = new StringParameter("max_bar_color");
        public StringParameter CrossFade { get; } = new StringParameter("cross_fade");
        public StringParameter LeftJustified { get; } = new StringParameter("left_justified");
        public StringParameter RightJustified { get; } = new StringParameter("right_justified");
        public StringParameter NoShell { get; } = new StringParameter("no_shell");
        public StringParameter SnapDrag { get; } = new StringParameter("snap_drag");
        public StringParameter SnapLocation { get; } = new StringParameter("snap_location");
        public StringParameter BlinkDuration { get; } = new StringParameter("blink_duration");
        public StringParameter ScaleDuration { get; } = new StringParameter("scale_duration");
        public StringParameter OffsetRender { get; } = new StringParameter("offset_render");
        public StringParameter BlinkFade { get; } = new StringParameter("blink_fade");
        public StringParameter NoHiddenCollision { get; } = new StringParameter("no_hidden_collision");
        public StringParameter ManualOffset { get; } = new StringParameter("manual_offset");
        public StringParameter SelectedAlpha { get; } = new StringParameter("selected_alpha");
        public StringParameter PixelAlign { get; } = new StringParameter("pixel_align");
        public StringParameter CanDragStack { get; } = new StringParameter("can_drag_stack");
        public StringParameter CanAnimate { get; } = new StringParameter("can_animate");
        public StringParameter AnimFps { get; } = new StringParameter("anim_fps");
        public StringParameter LoopAnim { get; } = new StringParameter("loop_anim");
        public StringParameter SmoothBar { get; } = new StringParameter("smooth_bar");
        public StringParameter OutlinedBar { get; } = new StringParameter("outlined_bar");
        public StringParameter DragBack { get; } = new StringParameter("drag_back");
        public StringParameter LowerEffectAdditive { get; } = new StringParameter("lower_effect_additive");
        public StringParameter UpperEffectAdditive { get; } = new StringParameter("upper_effect_additive");
        public StringParameter ClickShift { get; } = new StringParameter("click_shift");
        public StringParameter TutorialScene { get; } = new StringParameter("tutorial_scene");
        public StringParameter DialogScene { get; } = new StringParameter("dialog_scene");
        public StringParameter ShouldRenderAtDragPos { get; } = new StringParameter("should_render_at_drag_pos");
        public StringParameter DisableDarken { get; } = new StringParameter("disable_darken");
        public StringParameter AnimateBack { get; } = new StringParameter("animate_back");
        public StringParameter AnimateUpperEffec { get; } = new StringParameter("animate_upper_effect");

        public CommandBarComponent(string id) : base(id)
        {
        }
    }
}
