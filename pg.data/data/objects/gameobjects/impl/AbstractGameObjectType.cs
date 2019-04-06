using System;
using pg.data.data.objects.gameobjects.interfaces;
using pg.data.data.objects.gameobjects.types;
using pg.data.data.objects.parameters.interfaces;

namespace pg.data.data.objects.gameobjects.impl
{
    public abstract class AbstractGameObjectType : IGameObjectType
    {
        private readonly string _gameObjectId;
        protected readonly PetroglyphGameObjectType GameObjectType;
        public string GetObjectId()
        {
            return _gameObjectId;
        }

        public PetroglyphGameObjectType GetObjectType()
        {
            return GameObjectType;
        }

        public IParam GetParameterById(string id)
        {
            throw new NotImplementedException();
        }


    }
}
