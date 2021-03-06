﻿using kv.util;
using pg.util;

namespace pg.data.data.parameters.impl
{
    public class FloatParameter : AbstractParameter<float>
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

        public override bool IsSingleton()
        {
            return true;
        }

        protected override float GetDefaultValue()
        {
            return 0f;
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
