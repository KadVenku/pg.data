using kv.util;
using pg.util;

namespace pg.data.data.parameters.impl
{
    public class BooleanParameter : AbstractParameter<bool>
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

        public string ToString(BooleanUtility.PetroglyphBoolType boolType)
        {
            return BooleanUtility.Parse(GetValue(), boolType);
        }

        public override bool IsSingleton()
        {
            return true;
        }

        protected override bool GetDefaultValue()
        {
            return false;
        }

        public BooleanParameter(string id) : base(id)
        {
        }
    }
}
