using System;
using pg.data.data.parameters.types;

namespace pg.data.data.parameters.interfaces
{
    public interface IParam
    {
        string ToString();
        string GetId();
        Type GetValueType();
        PetroglyphParameterType GetParameterType();
    }
}