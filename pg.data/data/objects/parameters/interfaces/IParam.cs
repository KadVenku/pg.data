using System;
using pg.data.data.objects.parameters.types;

namespace pg.data.data.objects.parameters.interfaces
{
    public interface IParam
    {
        string ToString();
        string GetId();
        Type GetValueType();
        PetroglyphParameterType GetParameterType();
    }
}