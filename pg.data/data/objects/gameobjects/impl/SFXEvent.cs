using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class SfxEvent : AbstractGameObjectType
    {
        public StringParameter IsPreset { get; } = new StringParameter("is_preset");
        public StringParameter UsePreset { get; } = new StringParameter("use_preset");
        public StringParameter Samples { get; } = new StringParameter("samples");
        public StringParameter PreSamples { get; } = new StringParameter("pre_samples");
        public StringParameter PostSamples { get; } = new StringParameter("post_samples");
        public StringParameter TextId { get; } = new StringParameter("text_id");
        public StringParameter PlaySequentially { get; } = new StringParameter("play_sequentially");
        public StringParameter Priority { get; } = new StringParameter("priority");
        public StringParameter Probability { get; } = new StringParameter("probability");
        public StringParameter PlayCount { get; } = new StringParameter("play_count");
        public StringParameter LoopFadeInSeconds { get; } = new StringParameter("loop_fade_in_seconds");
        public StringParameter LoopFadeOutSeconds { get; } = new StringParameter("loop_fade_out_seconds");
        public StringParameter MaxInstances { get; } = new StringParameter("max_instances");
        public StringParameter MinVolume { get; } = new StringParameter("min_volume");
        public StringParameter MaxVolume { get; } = new StringParameter("max_volume");
        public StringParameter MinPitch { get; } = new StringParameter("min_pitch");
        public StringParameter MaxPitch { get; } = new StringParameter("max_pitch");
        public StringParameter MinPan2D { get; } = new StringParameter("min_pan2d");
        public StringParameter MaxPan2D { get; } = new StringParameter("max_pan2d");
        public StringParameter MinPredelay { get; } = new StringParameter("min_predelay");
        public StringParameter MaxPredelay { get; } = new StringParameter("max_predelay");
        public StringParameter MinPostdelay { get; } = new StringParameter("min_postdelay");
        public StringParameter MaxPostdelay { get; } = new StringParameter("max_postdelay");
        public StringParameter VolumeSaturationDistance { get; } = new StringParameter("volume_saturation_distance");
        public StringParameter KillsPreviousObjectSfx { get; } = new StringParameter("kills_previous_object_sfx");
        public StringParameter OverlapTest { get; } = new StringParameter("overlap_test");
        public StringParameter Localize { get; } = new StringParameter("localize");
        public StringParameter Is2D { get; } = new StringParameter("is_2d");
        public StringParameter Is3D { get; } = new StringParameter("is_3d");
        public StringParameter IsGui { get; } = new StringParameter("is_gui");
        public StringParameter IsHudvo { get; } = new StringParameter("is_hud_vo");
        public StringParameter IsUnitResponseVo { get; } = new StringParameter("is_unit_response_vo");
        public StringParameter IsAmbientVo { get; } = new StringParameter("is_ambient_vo");
        public StringParameter ChainedSfxEvent { get; } = new StringParameter("chained_sfxevent");

        public SfxEvent(string id) : base(id)
        {
        }
    }
}