using System;
using System.Collections.Generic;
using System.Text;

namespace StylerCode.Css
{
    public class TextMaker
    {
        public static string Execute()
        {

            StringBuilder sb = new StringBuilder();
            var names = Enum.GetNames(typeof(CssProperties));
            foreach (var name in names)
            {
                //"+name.ToLower()+"
                var code = "string  _" + name.ToLower() + ";\n        /// <summary>\n        /// " + name.ToLower() + "\n        /// </summary>\n        public string " + name + "\n        {\n            get { return _" + name.ToLower() + "; }\n            set\n            {\n                if (!string.IsNullOrEmpty(value))\n                {\n                    _" + name.ToLower() + " = value;\n                    var key = GetStyleName(nameof(" + name + "));\n                    _stylesList[key] = value;\n                }\n            }\n        }\n\n";
                sb.AppendLine(code);
            }
            return sb.ToString();
        }
    }
}
