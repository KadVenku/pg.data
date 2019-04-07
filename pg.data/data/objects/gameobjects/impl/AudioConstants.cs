using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class AudioConstants : AbstractGameObjectType
    {
        public StringParameter AudioGalactic3DSaturationDistanceMod { get; } = new StringParameter("audio_galactic_3d_saturation_distance_mod");
        public StringParameter AudioSpace3DSaturationDistanceMod { get; } = new StringParameter("audio_space_3d_saturation_distance_mod");
        public StringParameter AudioLand3DSaturationDistanceMod { get; } = new StringParameter("audio_land_3d_saturation_distance_mod");
        public StringParameter AudioGalactic3DRolloffDistanceMod { get; } = new StringParameter("audio_galactic_3d_rolloff_distance_mod");
        public StringParameter AudioSpace3DRolloffDistanceMod { get; } = new StringParameter("audio_space_3d_rolloff_distance_mod");
        public StringParameter AudioLand3DRolloffDistanceMod { get; } = new StringParameter("audio_land_3d_rolloff_distance_mod");
        public StringParameter AudioGalactic3DListenerZPullbackDist { get; } = new StringParameter("audio_galactic_3d_listener_z_pullback_dist");
        public StringParameter AudioSpace3DListenerZPullbackDist { get; } = new StringParameter("audio_space_3d_listener_z_pullback_dist");
        public StringParameter AudioLand3DListenerZPullbackDist { get; } = new StringParameter("audio_land_3d_listener_z_pullback_dist");
        public StringParameter SfXEventPlanetCaptureBonusReward { get; } = new StringParameter("sfxevent_planet_capture_bonus_reward");
        public StringParameter SfXEventGuiNegativeFeedback { get; } = new StringParameter("sfxevent_gui_negative_feedback");
        public StringParameter SfXEventPlanetRevealed { get; } = new StringParameter("sfxevent_planet_revealed");
        public StringParameter SfXEventMpGiveTeammateCredits { get; } = new StringParameter("sfxevent_mp_give_teammate_credits");
        public StringParameter MusicLandBattleToAmbientPeaceSeconds { get; } = new StringParameter("music_land_battle_to_ambient_peace_seconds");
        public StringParameter MusicSpaceBattleToAmbientPeaceSeconds { get; } = new StringParameter("music_space_battle_to_ambient_peace_seconds");
        public StringParameter TelekinesisSfxEventLoop { get; } = new StringParameter("telekinesis_sfxevent_loop");
        public StringParameter TelekinesisSfxEventDamage { get; } = new StringParameter("telekinesis_sfxevent_damage");
        public StringParameter TelekinesisSfxEventSlam { get; } = new StringParameter("telekinesis_sfxevent_slam");
        public StringParameter MsS3DProviderName { get; } = new StringParameter("mss_3d_provider_name");
        public StringParameter SfXEventCommandBarAttack { get; } = new StringParameter("sfxevent_command_bar_attack");
        public StringParameter SfXEventCommandBarAttackMove { get; } = new StringParameter("sfxevent_command_bar_attack_move");
        public StringParameter SfXEventCommandBarMove { get; } = new StringParameter("sfxevent_command_bar_move");
        public StringParameter SfXEventCommandBarWaypoint { get; } = new StringParameter("sfxevent_command_bar_waypoint");
        public StringParameter SfXEventCommandBarStop { get; } = new StringParameter("sfxevent_command_bar_stop");
        public StringParameter SfXEventCommandBarGuard { get; } = new StringParameter("sfxevent_command_bar_guard");
        public StringParameter DelayBetweenSpaceBaseAttackAnnouncementSeconds { get; } = new StringParameter("delay_between_space_base_attack_announcement_seconds");
        public StringParameter DelayBetweenLandBaseAttackAnnouncementSeconds { get; } = new StringParameter("delay_between_land_base_attack_announcement_seconds");
        public StringParameter MusicEventBattleLoadScreen { get; } = new StringParameter("music_event_battle_load_screen");
        public StringParameter MusicEventBattleEndSummaryScreenWin { get; } = new StringParameter("music_event_battle_end_summary_screen_win");
        public StringParameter MusicEventBattleEndSummaryScreenLose { get; } = new StringParameter("music_event_battle_end_summary_screen_lose");
        public StringParameter DefaultMssdigdsfragmentcnt { get; } = new StringParameter("default_mss_dig_ds_fragment_cnt");
        public StringParameter DefaultMssdigdsmixfragmentcnt { get; } = new StringParameter("default_mss_dig_ds_mix_fragment_cnt");
        public StringParameter SustainedIomssdigdsfragmentcnt { get; } = new StringParameter("sustained_io_mss_dig_ds_fragment_cnt");
        public StringParameter SustainedIomssdigdsmixfragmentcnt { get; } = new StringParameter("sustained_io_mss_dig_ds_mix_fragment_cnt");
        public StringParameter TestDisableWeaponFireSfx { get; } = new StringParameter("test_disable_weapon_fire_sfx");

        public AudioConstants(string id) : base(id)
        {
        }
    }
}
