using kv.util;
using pg.data.data.objects.parameters.types;
using pg.util;

namespace pg.data.data.objects.parameters.impl
{
    public sealed class BooleanParameter : AbstractParameter<bool>
    {
        public override void SetValueByString(string value)
        {
            string normalizedValue = StringUtility.NormalizeString(value);
            SetValue(BooleanUtility.Parse(normalizedValue));
        }

        public override string ToString()
        {
            return BooleanUtility.Parse(GetValue());
        }

        public override PetroglyphParameterType GetParameterType()
        {
            return PetroglyphParameterType.BooleanType;
        }

        public BooleanParameter(string id) : base(id)
        {
        }
    }
}
