using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class AudioConstants : AbstractGameObjectType
    {
        public readonly StringParameter AudioGalactic3DSaturationDistanceMod = new StringParameter("audio_galactic_3d_saturation_distance_mod");
        public readonly StringParameter AudioSpace3DSaturationDistanceMod = new StringParameter("audio_space_3d_saturation_distance_mod");
        public readonly StringParameter AudioLand3DSaturationDistanceMod = new StringParameter("audio_land_3d_saturation_distance_mod");
        public readonly StringParameter AudioGalactic3DRolloffDistanceMod = new StringParameter("audio_galactic_3d_rolloff_distance_mod");
        public readonly StringParameter AudioSpace3DRolloffDistanceMod = new StringParameter("audio_space_3d_rolloff_distance_mod");
        public readonly StringParameter AudioLand3DRolloffDistanceMod = new StringParameter("audio_land_3d_rolloff_distance_mod");
        public readonly StringParameter AudioGalactic3DListenerZPullbackDist = new StringParameter("audio_galactic_3d_listener_z_pullback_dist");
        public readonly StringParameter AudioSpace3DListenerZPullbackDist = new StringParameter("audio_space_3d_listener_z_pullback_dist");
        public readonly StringParameter AudioLand3DListenerZPullbackDist = new StringParameter("audio_land_3d_listener_z_pullback_dist");
        public readonly StringParameter SfXEventPlanetCaptureBonusReward = new StringParameter("sfxevent_planet_capture_bonus_reward");
        public readonly StringParameter SfXEventGuiNegativeFeedback = new StringParameter("sfxevent_gui_negative_feedback");
        public readonly StringParameter SfXEventPlanetRevealed = new StringParameter("sfxevent_planet_revealed");
        public readonly StringParameter SfXEventMpGiveTeammateCredits = new StringParameter("sfxevent_mp_give_teammate_credits");
        public readonly StringParameter MusicLandBattleToAmbientPeaceSeconds = new StringParameter("music_land_battle_to_ambient_peace_seconds");
        public readonly StringParameter MusicSpaceBattleToAmbientPeaceSeconds = new StringParameter("music_space_battle_to_ambient_peace_seconds");
        public readonly StringParameter TelekinesisSfxEventLoop = new StringParameter("telekinesis_sfxevent_loop");
        public readonly StringParameter TelekinesisSfxEventDamage = new StringParameter("telekinesis_sfxevent_damage");
        public readonly StringParameter TelekinesisSfxEventSlam = new StringParameter("telekinesis_sfxevent_slam");
        public readonly StringParameter MsS3DProviderName = new StringParameter("mss_3d_provider_name");
        public readonly StringParameter SfXEventCommandBarAttack = new StringParameter("sfxevent_command_bar_attack");
        public readonly StringParameter SfXEventCommandBarAttackMove = new StringParameter("sfxevent_command_bar_attack_move");
        public readonly StringParameter SfXEventCommandBarMove = new StringParameter("sfxevent_command_bar_move");
        public readonly StringParameter SfXEventCommandBarWaypoint = new StringParameter("sfxevent_command_bar_waypoint");
        public readonly StringParameter SfXEventCommandBarStop = new StringParameter("sfxevent_command_bar_stop");
        public readonly StringParameter SfXEventCommandBarGuard = new StringParameter("sfxevent_command_bar_guard");
        public readonly StringParameter DelayBetweenSpaceBaseAttackAnnouncementSeconds = new StringParameter("delay_between_space_base_attack_announcement_seconds");
        public readonly StringParameter DelayBetweenLandBaseAttackAnnouncementSeconds = new StringParameter("delay_between_land_base_attack_announcement_seconds");
        public readonly StringParameter MusicEventBattleLoadScreen = new StringParameter("music_event_battle_load_screen");
        public readonly StringParameter MusicEventBattleEndSummaryScreenWin = new StringParameter("music_event_battle_end_summary_screen_win");
        public readonly StringParameter MusicEventBattleEndSummaryScreenLose = new StringParameter("music_event_battle_end_summary_screen_lose");
        public readonly StringParameter DefaultMssdigdsfragmentcnt = new StringParameter("default_mss_dig_ds_fragment_cnt");
        public readonly StringParameter DefaultMssdigdsmixfragmentcnt = new StringParameter("default_mss_dig_ds_mix_fragment_cnt");
        public readonly StringParameter SustainedIomssdigdsfragmentcnt = new StringParameter("sustained_io_mss_dig_ds_fragment_cnt");
        public readonly StringParameter SustainedIomssdigdsmixfragmentcnt = new StringParameter("sustained_io_mss_dig_ds_mix_fragment_cnt");
        public readonly StringParameter TestDisableWeaponFireSfx = new StringParameter("test_disable_weapon_fire_sfx");
    }
}
