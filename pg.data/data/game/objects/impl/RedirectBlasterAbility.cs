using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class RedirectBlasterAbility : AbstractGameObjectType
    {
        public StringParameter RedirectChance { get; } = new StringParameter("redirect_chance");
        public StringParameter BlockChance { get; } = new StringParameter("block_chance");
        public StringParameter ReactionArcInDegrees { get; } = new StringParameter("reaction_arc_in_degrees");
        public StringParameter MaxProjectileRedirectionAngleInDegrees { get; } = new StringParameter("max_projectile_redirection_angle_in_degrees");
        public StringParameter TurnToFaceUnblockableShots { get; } = new StringParameter("turn_to_face_unblockable_shots");
        
        public RedirectBlasterAbility(string id) : base(id)
        {
        }
    }
}