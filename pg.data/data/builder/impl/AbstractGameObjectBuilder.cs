using System.Linq;
using System.Xml.Linq;
using kv.util;
using pg.data.common.exceptions;
using pg.data.data.builder.interfaces;
using pg.data.data.game.objects.impl;
using pg.data.data.game.objects.interfaces;
using pg.util.exceptions;

namespace pg.data.data.builder.impl
{
    public abstract class AbstractGameObjectBuilder<T> : IGameObjectBuilder<T> where T : IGameObjectType
    {
        public abstract T Build(XElement xElement);

        protected static void ValidateXElement(XElement xElement)
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
        }
    }
}