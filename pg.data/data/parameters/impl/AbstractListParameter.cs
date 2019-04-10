using System.Collections.Generic;

namespace pg.data.data.parameters.impl
{
    public abstract class AbstractListParameter<T> : AbstractParameter<List<T>>
    {
        protected static string SEPARATOR = ",";
        private List<T> _value;

        protected AbstractListParameter(string id) : base(id)
        {
            _value = new List<T>();
        }
    }
}
