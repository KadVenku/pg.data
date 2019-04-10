using System.Xml.Linq;
using pg.data.data.game.objects.interfaces;

namespace pg.data.data.builder.interfaces
{
    public interface IGameObjectBuilder<out T> where T : IGameObjectType
    {
        T Build(XElement xElement);
    }
}