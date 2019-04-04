namespace pg.data.data.objects.parameters.interfaces
{
    public interface IParameter<T> : IParam
    {
        T GetValue();
        void SetValueByString(string value);
        void SetValue(T value);
    }
}