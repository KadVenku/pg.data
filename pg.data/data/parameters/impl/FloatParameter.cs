using kv.util;
using pg.data.data.parameters.types;
using pg.util;

namespace pg.data.data.parameters.impl
{
    public sealed class FloatParameter : AbstractParameter<float>
    {
        public override void SetValueByString(string value)
        {
            string normalisedString = StringUtility.NormalizeString(value);
            SetValue(FloatUtility.Parse(normalisedString));
        }

        public override string ToString()
        {
            return FloatUtility.Parse(GetValue());
        }

        public override PetroglyphParameterType GetParameterType()
        {
            return PetroglyphParameterType.FloatType;
        }

        public string ToString(int decimalPlaces)
        {
            return FloatUtility.Parse(GetValue(), decimalPlaces);
        }

        public FloatParameter(string id) : base(id)
        {
        }
    }
}
