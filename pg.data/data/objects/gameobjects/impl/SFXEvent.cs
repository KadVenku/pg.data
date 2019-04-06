using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SfxEvent : AbstractGameObjectType
    {
        public readonly StringParameter IsPreset = new StringParameter("is_preset");
        public readonly StringParameter UsePreset = new StringParameter("use_preset");
        public readonly StringParameter Samples = new StringParameter("samples");
        public readonly StringParameter PreSamples = new StringParameter("pre_samples");
        public readonly StringParameter PostSamples = new StringParameter("post_samples");
        public readonly StringParameter TextId = new StringParameter("text_id");
        public readonly StringParameter PlaySequentially = new StringParameter("play_sequentially");
        public readonly StringParameter Priority = new StringParameter("priority");
        public readonly StringParameter Probability = new StringParameter("probability");
        public readonly StringParameter PlayCount = new StringParameter("play_count");
        public readonly StringParameter LoopFadeInSeconds = new StringParameter("loop_fade_in_seconds");
        public readonly StringParameter LoopFadeOutSeconds = new StringParameter("loop_fade_out_seconds");
        public readonly StringParameter MaxInstances = new StringParameter("max_instances");
        public readonly StringParameter MinVolume = new StringParameter("min_volume");
        public readonly StringParameter MaxVolume = new StringParameter("max_volume");
        public readonly StringParameter MinPitch = new StringParameter("min_pitch");
        public readonly StringParameter MaxPitch = new StringParameter("max_pitch");
        public readonly StringParameter MinPan2D = new StringParameter("min_pan2d");
        public readonly StringParameter MaxPan2D = new StringParameter("max_pan2d");
        public readonly StringParameter MinPredelay = new StringParameter("min_predelay");
        public readonly StringParameter MaxPredelay = new StringParameter("max_predelay");
        public readonly StringParameter MinPostdelay = new StringParameter("min_postdelay");
        public readonly StringParameter MaxPostdelay = new StringParameter("max_postdelay");
        public readonly StringParameter VolumeSaturationDistance = new StringParameter("volume_saturation_distance");
        public readonly StringParameter KillsPreviousObjectSfx = new StringParameter("kills_previous_object_sfx");
        public readonly StringParameter OverlapTest = new StringParameter("overlap_test");
        public readonly StringParameter Localize = new StringParameter("localize");
        public readonly StringParameter Is2D = new StringParameter("is_2d");
        public readonly StringParameter Is3D = new StringParameter("is_3d");
        public readonly StringParameter IsGui = new StringParameter("is_gui");
        public readonly StringParameter IsHudvo = new StringParameter("is_hud_vo");
        public readonly StringParameter IsUnitResponseVo = new StringParameter("is_unit_response_vo");
        public readonly StringParameter IsAmbientVo = new StringParameter("is_ambient_vo");
        public readonly StringParameter ChainedSfxEvent = new StringParameter("chained_sfxevent");
    }
}