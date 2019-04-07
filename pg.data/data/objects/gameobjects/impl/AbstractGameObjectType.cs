using System.Reflection;
using kv.util;
using pg.data.data.objects.gameobjects.interfaces;
using pg.data.data.objects.gameobjects.types;
using pg.data.data.objects.parameters.interfaces;

namespace pg.data.data.objects.gameobjects.impl
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
