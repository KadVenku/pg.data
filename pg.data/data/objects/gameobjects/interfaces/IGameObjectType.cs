using pg.data.data.objects.gameobjects.types;
using pg.data.data.objects.parameters.interfaces;

namespace pg.data.data.objects.gameobjects.interfaces
{
    public interface IGameObjectType
    {
        string GetObjectId();
        PetroglyphGameObjectType GetObjectType();
        IParam GetParameterById(string id);
    }
}