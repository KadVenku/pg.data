using System;

namespace pg.data.data.parameters.interfaces
{
    public interface IParameterWrapper
    {
        string ToString();
        string GetId();
        void SetValueByString(string value);
        Type GetValueType();
        bool IsSingleton();
    }
}