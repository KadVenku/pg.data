using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class Draw3DTextCrawlData : AbstractGameObjectType
    {
        public readonly StringParameter TextIDs = new StringParameter("text_ids");
        public readonly StringParameter FontName = new StringParameter("font_name");
        public readonly StringParameter FontSize = new StringParameter("font_size");
        public readonly StringParameter TextureWidthPow2 = new StringParameter("texture_width_pow_2");
        public readonly StringParameter TextureHeightPow2 = new StringParameter("texture_height_pow_2");
        public readonly StringParameter HasHeader = new StringParameter("has_header");
        public readonly StringParameter HeaderTextIDs = new StringParameter("header_text_ids");
        public readonly StringParameter HeaderFontName = new StringParameter("header_font_name");
        public readonly StringParameter HeaderFontSize = new StringParameter("header_font_size");
        public readonly StringParameter HeaderTextureWidthPow2 = new StringParameter("header_texture_width_pow_2");
        public readonly StringParameter HeaderTextureHeightPow2 = new StringParameter("header_texture_height_pow_2");
        public readonly StringParameter PolygonShaderName = new StringParameter("polygon_shader_name");
        public readonly StringParameter PolygonTexParamName = new StringParameter("polygon_tex_param_name");
        public readonly StringParameter ModelName = new StringParameter("model_name");
        public readonly StringParameter ModelCameraBoneName = new StringParameter("model_camera_bone_name");
        public readonly StringParameter FadeoutStartFrame = new StringParameter("fadeout_start_frame");
        public readonly StringParameter FadeoutEndFrame = new StringParameter("fadeout_end_frame");
        public readonly StringParameter FadeinStartFrame = new StringParameter("fadein_start_frame");
        public readonly StringParameter FadeinEndFrame = new StringParameter("fadein_end_frame");
        public readonly StringParameter FontStretchFactor = new StringParameter("font_stretch_factor");
        public readonly StringParameter FontCharacterPadding = new StringParameter("font_character_padding");
        public readonly StringParameter HeaderFontStretchFactor = new StringParameter("header_font_stretch_factor");
        public readonly StringParameter HeaderFontCharacterPadding = new StringParameter("header_font_character_padding");
    }
}
