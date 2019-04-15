using System.Collections.Generic;

namespace pg.data.data.parameters.impl
{
    public abstract class AbstractListParameter<T> : AbstractParameter<List<T>>
    {
        private List<T> _value;

        protected AbstractListParameter(string id) : base(id)
        {
            _value = new List<T>();
        }

        protected abstract string GetConfiguredSeparator();

        public virtual void SetValue(T value)
        {
            if (GetValue() == null)
            {
                SetValue(GetDefaultValue());
            }
            GetValue().Add(value);
        }
    }
}
