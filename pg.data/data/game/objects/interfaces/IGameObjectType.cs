using pg.data.data.game.objects.types;
using pg.data.data.parameters.interfaces;

namespace pg.data.data.game.objects.interfaces
{
    public interface IGameObjectType
    {
        string GetObjectId();
        PetroglyphGameObjectType GetObjectType();
        IParam GetParameterById(string id);
    }
}