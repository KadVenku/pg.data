using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class TradeRoute : AbstractGameObjectType
    {
        public readonly StringParameter PointA = new StringParameter("point_a");
        public readonly StringParameter PointB = new StringParameter("point_b");
        public readonly StringParameter PoliticalControlGain = new StringParameter("political_control_gain");
        public readonly StringParameter CreditGainFactor = new StringParameter("credit_gain_factor");
        public readonly StringParameter HsSpeedFactor = new StringParameter("hs_speed_factor");
        public readonly StringParameter VesselSpeed = new StringParameter("vessel_speed");
        public readonly StringParameter VisibleLineName = new StringParameter("visible_line_name");
    }
}
