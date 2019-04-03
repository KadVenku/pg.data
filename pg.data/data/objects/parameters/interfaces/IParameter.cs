namespace pg.data.data.objects.parameters.interfaces
{
    public interface IParameter<TParameter, in TParameterType>
    {
        TParameter GetValue();
        void SetValue(string value, TParameterType type);
        void SetValue(TParameter value);
        string ToString();
    }
}