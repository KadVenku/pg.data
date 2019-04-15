using System.Collections.Generic;
using System.Linq;
using System.Text;
using kv.util;

namespace pg.data.data.parameters.impl
{
    public class LocalisedStringKeyListParameter : AbstractListParameter<string>
    {
        public LocalisedStringKeyListParameter(string id) : base(id)
        {
        }

        public override void SetValueByString(string value)
        {
            value = value.Trim();
            value = value.Replace("\r\n", string.Empty);
            value = value.Replace("\n", string.Empty);
            string[] temTextReferenceArray = value.Split(',');
            List<string> textKeyReferenceList = temTextReferenceArray.Select(s => s.Trim()).Where(hp => !StringUtility.IsNullEmptyOrWhitespace(hp)).ToList();
            SetValue(textKeyReferenceList);
        }

        public override bool IsSingleton()
        {
            return true;
        }

        protected override string GetConfiguredSeparator()
        {
            return ",";
        }

        public override void SetValue(string value)
        {
            string reference = value.Trim();
            if (GetValue() == null)
            {
                SetValue(GetDefaultValue());
            }
            GetValue().Add(reference);
        }

        public override string ToString()
        {
            StringBuilder textKeyReferences = new StringBuilder();
            for (int i = 0; i < GetValue().Count; i++)
            {
                textKeyReferences.Append(GetValue()[i]);
                if (i < GetValue().Count - 1)
                {
                    textKeyReferences.Append(GetConfiguredSeparator());
                }
            }

            return textKeyReferences.ToString();
        }

        protected override List<string> GetDefaultValue()
        {
            return new List<string>();
        }
    }
}