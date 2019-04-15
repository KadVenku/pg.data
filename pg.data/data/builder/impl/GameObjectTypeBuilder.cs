using System;
using System.Linq;
using System.Xml.Linq;
using kv.util;
using pg.data.common.exceptions;
using pg.data.data.builder.interfaces;
using pg.data.data.game.objects.impl;
using pg.util.exceptions;

namespace pg.data.data.builder.impl
{
    public class GameObjectTypeBuilder : AbstractGameObjectBuilder<GameObjectType>
    {
        public override GameObjectType Build(XElement xElement)
        {
            ValidateXElement(xElement);
            string gameObjectId = xElement.Attribute("Name")?.Value;
            GameObjectType gameObjectType = new GameObjectType(gameObjectId);
#if DEBUG
            Console.Out.WriteLine($"[{DateTimeUtility.GetLogTimeStamp()}| **** INFO **** Parsing {typeof(GameObjectType)} with ID \'{gameObjectId}\'");
#endif
            foreach (XElement element in xElement.Elements())
            {
                gameObjectType.SetParameterById(element.Name.ToString(), element.Value);
            }
            return gameObjectType;
        }
    }
}