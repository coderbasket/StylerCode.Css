using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StylerCode.Css
{
    public class TextMaker
    {
        public static string Execute()
        {

            StringBuilder sb = new StringBuilder();
            var names = Enum.GetNames(typeof(Cp));
            foreach (var name in names)
            {
                //"+name.ToLower()+"
                var code = "string  _" + name.ToLower() + ";\n        /// <summary>\n        /// " + name.ToLower() + "\n        /// </summary>\n        public string " + name + "\n        {\n            get { return _" + name.ToLower() + "; }\n            set\n            {\n                if (!string.IsNullOrEmpty(value))\n                {\n                    _" + name.ToLower() + " = value;\n                    var key = GetStyleName(nameof(" + name + "));\n                    _stylesList[key] = value;\n                }\n            }\n        }\n\n";
                sb.AppendLine(code);
            }
            return sb.ToString();
        }
        public static string GetPropertiesCode(CssProperty property)
        {
            var title = property.Title;
            var enumName = GetEnumName(property.Title);
            var values = property.Values !=null ? string.Join(" | ", property.Values) : "";
            var code = $" /// <summary>\n        /// {property.Summary}\n        /// <example>\n        /// \n        /// <code>\n        /// {property.Example}\n        /// \n        /// </code>\n        /// {values}\n        /// </example>\n        /// </summary>\n        /// /// <remarks>\n        /// <a href=\"{property.Url}\">Learn more</a>\n        /// </remarks>\n        {enumName},\n";
            return code;
        }
        
        internal static string GetEnumName(string styleName)
        {
            var str = styleName;
           
            if (str.Contains("-"))
            {
                var list = new List<string>();
                var split = str.Split('-');
                foreach(var name in split)
                {
                    var cName = FirstCharToUpper(name);
                    list.Add(cName);
                }
                str = string.Join("_", list);
            }
            else
            {

               str = FirstCharToUpper(str);
            }
            return str;
        }
        internal static string FirstCharToUpper(string s)
        {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
   
    internal class CssProperty
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string Example { get; set; }
        public List<string> Values { get; set; }
    }
    internal class CssValue
    {
        public string Title { get; set; }
        public List<string> Values { get; set; }
    }
}
