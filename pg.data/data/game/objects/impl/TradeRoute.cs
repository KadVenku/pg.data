using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class TradeRoute : AbstractGameObjectType
    {
        public StringParameter PointA { get; } = new StringParameter("point_a");
        public StringParameter PointB { get; } = new StringParameter("point_b");
        public StringParameter PoliticalControlGain { get; } = new StringParameter("political_control_gain");
        public StringParameter CreditGainFactor { get; } = new StringParameter("credit_gain_factor");
        public StringParameter HsSpeedFactor { get; } = new StringParameter("hs_speed_factor");
        public StringParameter VesselSpeed { get; } = new StringParameter("vessel_speed");
        public StringParameter VisibleLineName { get; } = new StringParameter("visible_line_name");

        public TradeRoute(string id) : base(id)
        {
        }
    }
}
