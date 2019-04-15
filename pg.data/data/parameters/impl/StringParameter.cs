namespace pg.data.data.parameters.impl
{
    public class StringParameter : AbstractParameter<string>
    {
        public override void SetValueByString(string value)
        {
            SetValue(value.Trim());
        }

        public override string ToString()
        {
            return GetValue();
        }

        public override bool IsSingleton()
        {
            return true;
        }

        protected override string GetDefaultValue()
        {
            return string.Empty;
        }

        public StringParameter(string id) : base(id)
        {
        }
    }
}
