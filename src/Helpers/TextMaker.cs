using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StylerCode.Css
{
    public class TextMaker
    {
        public static List<string> GenerateCsharpValues(List<CssValue_ForJson> cssValues)
        {
            var result = new List<string>();
            foreach(var value in cssValues)
            {
                var list = GetValuesJson(value);
                if (list != null)
                    result.AddRange(list);
            }
            _checker.Clear();
            return result;
        }
        static Dictionary<string, string> _checker = new Dictionary<string, string>();
        static List<string> GetValuesJson(CssValue_ForJson cssValue)
        {
            var result = new List<string>();
            
            if (cssValue.Values == null)
                return null;
            foreach(var value in cssValue.Values)
            {
                var names = value.Split('|').ToList();
                var name = System.Net.WebUtility.HtmlDecode(value);
               
                if (!_checker.ContainsKey(name))
                {
                    result.Add($"public const string {GetEnumName(name)} = \"{name}\";");
                    _checker[name] = name;
                }
            }
            return result;
        }
        public static string GetPropertiesCode(CssProperty_ForJson property)
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
                var list = new List<string>();
                var split = Regex.Split(str, @"(?<!^)(?=[A-Z])");
                if (split.Length == 1)
                {
                    str = FirstCharToUpper(str);
                }
                else
                {
                    foreach (var name in split)
                    {
                        var cName = FirstCharToUpper(name);
                        list.Add(cName);
                    }
                    str = string.Join(" ", list);
                    
                }
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
        public class CssProperty_ForJson
        {
            public string Title { get; set; }
            public string Summary { get; set; }
            public string Url { get; set; }
            public string Example { get; set; }
            public List<string> Values { get; set; }
        }
        public class CssValue_ForJson
        {
            public string Title { get; set; }
            public List<string> Values { get; set; }
        }
    }
    

}
