using System;
using pg.data.data.parameters.interfaces;

namespace pg.data.data.parameters.impl
{
    public abstract class AbstractParameter<T> : IParameter<T>
    {
        private readonly string _id;
        private T _value;
        private bool _valueInitallySet = false;

        protected AbstractParameter(string id)
        {
            _id = id;
        }

        public virtual T GetValue()
        {
            return _valueInitallySet ? _value : GetDefaultValue();
        }

        public abstract void SetValueByString(string value);

        public abstract override string ToString();

        public virtual string GetId()
        {
            return _id;
        }

        public virtual Type GetValueType()
        {
            return typeof(T);
        }

        protected abstract T GetDefaultValue();

        public virtual void SetValue(T value)
        {
            _valueInitallySet = true;
            _value = value;
        }

        public abstract bool IsSingleton();
    }
}
