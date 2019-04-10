using System.Reflection;
using kv.util;
using pg.data.data.game.objects.interfaces;
using pg.data.data.game.objects.types;
using pg.data.data.parameters.interfaces;

namespace pg.data.data.game.objects.impl
{
    public abstract class AbstractGameObjectType : IGameObjectType
    {
        private readonly string _gameObjectId;

        public string GetObjectId()
        {
            return _gameObjectId;
        }

        protected AbstractGameObjectType(string id)
        {
            _gameObjectId = id;
        }

        public virtual PetroglyphGameObjectType GetObjectType() => PetroglyphGameObjectType.Invalid;

        public IParam GetParameterById(string id)
        {
            foreach (PropertyInfo property in GetType().GetProperties())
            {
                if (!(property.GetValue(this) is IParam param)) continue;
                if (StringUtility.IsEqual(param.GetId(), id, StringUtility.Comparison.IgnoreCase))
                {
                    return param;
                }
            }
            return null;
        }
    }
}
