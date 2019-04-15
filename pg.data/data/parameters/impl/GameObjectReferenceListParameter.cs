using System.Collections.Generic;
using System.Linq;
using System.Text;
using kv.util;

namespace pg.data.data.parameters.impl
{
    public class GameObjectReferenceListParameter : AbstractListParameter<string>
    {
        public GameObjectReferenceListParameter(string id) : base(id)
        {
        }

        public override void SetValueByString(string value)
        {
            value = value.Trim();
            value = value.Replace("\r\n", string.Empty);
            value = value.Replace("\n", string.Empty);
            string[] tempHardpointArray = value.Split(',');
            List<string> hardpointReferenceList = tempHardpointArray.Select(s => s.Trim()).Where(hp => !StringUtility.IsNullEmptyOrWhitespace(hp)).ToList();
            SetValue(hardpointReferenceList);
        }

        public override bool IsSingleton()
        {
            return true;
        }

        protected override List<string> GetDefaultValue()
        {
            return new List<string>();
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
            StringBuilder hpList = new StringBuilder();
            for (int i = 0; i < GetValue().Count; i++)
            {
                hpList.Append(GetValue()[i]);
                if (i < GetValue().Count - 1)
                {
                    hpList.Append(GetConfiguredSeparator());
                }
            }

            return hpList.ToString();
        }
    }
}