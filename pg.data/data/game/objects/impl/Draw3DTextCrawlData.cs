using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class Draw3DTextCrawlData : AbstractGameObjectType
    {
        public StringParameter TextIDs { get; } = new StringParameter("text_ids");
        public StringParameter FontName { get; } = new StringParameter("font_name");
        public StringParameter FontSize { get; } = new StringParameter("font_size");
        public StringParameter TextureWidthPow2 { get; } = new StringParameter("texture_width_pow_2");
        public StringParameter TextureHeightPow2 { get; } = new StringParameter("texture_height_pow_2");
        public StringParameter HasHeader { get; } = new StringParameter("has_header");
        public StringParameter HeaderTextIDs { get; } = new StringParameter("header_text_ids");
        public StringParameter HeaderFontName { get; } = new StringParameter("header_font_name");
        public StringParameter HeaderFontSize { get; } = new StringParameter("header_font_size");
        public StringParameter HeaderTextureWidthPow2 { get; } = new StringParameter("header_texture_width_pow_2");
        public StringParameter HeaderTextureHeightPow2 { get; } = new StringParameter("header_texture_height_pow_2");
        public StringParameter PolygonShaderName { get; } = new StringParameter("polygon_shader_name");
        public StringParameter PolygonTexParamName { get; } = new StringParameter("polygon_tex_param_name");
        public StringParameter ModelName { get; } = new StringParameter("model_name");
        public StringParameter ModelCameraBoneName { get; } = new StringParameter("model_camera_bone_name");
        public StringParameter FadeoutStartFrame { get; } = new StringParameter("fadeout_start_frame");
        public StringParameter FadeoutEndFrame { get; } = new StringParameter("fadeout_end_frame");
        public StringParameter FadeinStartFrame { get; } = new StringParameter("fadein_start_frame");
        public StringParameter FadeinEndFrame { get; } = new StringParameter("fadein_end_frame");
        public StringParameter FontStretchFactor { get; } = new StringParameter("font_stretch_factor");
        public StringParameter FontCharacterPadding { get; } = new StringParameter("font_character_padding");
        public StringParameter HeaderFontStretchFactor { get; } = new StringParameter("header_font_stretch_factor");
        public StringParameter HeaderFontCharacterPadding { get; } = new StringParameter("header_font_character_padding");

        public Draw3DTextCrawlData(string id) : base(id)
        {
        }
    }
}
