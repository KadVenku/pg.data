using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class ClusterBombAbility : AbstractGameObjectType
    {
        public StringParameter DetonationTimeInSecs { get; } = new StringParameter("detonation_time_in_secs");
        public StringParameter BombType { get; } = new StringParameter("bomb_type");
        public StringParameter NumberOfBombs { get; } = new StringParameter("number_of_bombs");
        
        public ClusterBombAbility(string id) : base(id)
        {
        }
    }
}