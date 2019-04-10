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
    public class GameObjectTypeBuilder : IGameObjectBuilder<GameObjectType>
    {
        public GameObjectType Build(XElement xElement)
        {
            if (xElement == null)
            {
                throw new AttributeNullException($"Expected valid {typeof(XElement)} {nameof(xElement)}, but received null instead.");
            }

            if (!xElement.HasAttributes)
            {
                throw new InvalidXElementException($"The provided attribute {nameof(xElement)} should contain a \'Name\' attribute; but it didn't.");
            }
            
            if (StringUtility.IsNullEmptyOrWhitespace(xElement.Attribute("Name")?.Value))
            {
                throw new InvalidXElementException($"The provided attribute {nameof(xElement)} should contain a \'Name\' attribute; but it didn't.");
            }

            if (!xElement.Elements().Any())
            {
                throw new InvalidXElementException($"The provided attribute {nameof(xElement)} does not contain any data.");
            }

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