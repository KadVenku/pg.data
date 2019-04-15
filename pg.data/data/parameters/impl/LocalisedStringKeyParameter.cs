namespace pg.data.data.parameters.impl
{
    public class LocalisedStringKeyParameter : AbstractParameter<string>
    {
        public LocalisedStringKeyParameter(string id) : base(id)
        {
        }

        public override void SetValueByString(string value)
        {
            string key = value.Trim();
            SetValue(key);
        }

        public override bool IsSingleton()
        {
            return true;
        }

        public override string ToString()
        {
            return GetValue();
        }

        protected override string GetDefaultValue()
        {
            return "MISSING";
        }
    }
}