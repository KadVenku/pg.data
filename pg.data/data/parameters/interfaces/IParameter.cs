namespace pg.data.data.parameters.interfaces
{
    public interface IParameter<T> : IParameterWrapper
    {
        T GetValue();
        void SetValue(T value);
    }
}