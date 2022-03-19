using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace StylerCode.Css
{
    public class Css 
    {
        
        
        public Css() 
        {
           
        }
        public Css(Css currentStyles)
        {
            if(currentStyles?._stylesList?.Count > 0)
            {
                foreach(var dictionary in currentStyles._stylesList)
                {
                    _stylesList[dictionary.Key] = dictionary.Value;
                }
            }
            
           
        }

       
        /// <summary>
        /// Custom
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Css Add(string key, string value)
        {
            _stylesList[key] = value;
            this.NotifyChanged();
            return this;
        }
        
        
        /// <summary>
        /// Add Style
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Css Add(Cp key, string value)
        {
            var keyString = GetStyleName(key);
            _stylesList[keyString] = value;
            this.NotifyChanged();
            return this;
        }

        public void Clear()
        {
            this._stylesList.Clear();
            this.NotifyChanged();
        }
        public void Remove(string key)
        {
            if (_stylesList.ContainsKey(key))
            {
                _stylesList.Remove(key);
                this.NotifyChanged();
               
            }
        }
        
        public void Remove(Cp key)
        {
            var keyString = GetStyleName(key);
            if (_stylesList.ContainsKey(keyString))
            {
                _stylesList.Remove(keyString);
                this.NotifyChanged();

            }
        }
        public event EventHandler<Css> StyleChanged;
        void NotifyChanged()
        {
            StyleChanged?.Invoke(this, this);
        }
        
        
         string CreateValue()
        {
            if (this._stylesList.Count <= 0)
                return null;
            string style = "";
            foreach (var st in _stylesList)
            {
                style += (st.Key + ": " + st.Value + "; ");
            }
            return style;
        }
        public string ToAttributeStyles()
        {
            string style = CreateValue();
            if (style == null)
                return null;
            return "style=\"" + style + "\"";
        }
        public Css Clone()
        {
            return new Css(this);
        }
        public string ToValueStyles()
        {
            return CreateValue();
        }
        
        public string ToString(bool attributeStyle = false)
        {           
            if(attributeStyle)
                return ToAttributeStyles();
            else
                return ToValueStyles();
        }
        public override string ToString()
        {

            string style = CreateValue();
            if (style == null)
                return null;
            return style;
        }
        public static explicit operator string(Css cssStyler)
        {
            return cssStyler.ToString();
        }
        public static implicit operator Css(string attributeStyles)
        {
            if(string.IsNullOrEmpty(attributeStyles))
                return null;
            if (!attributeStyles.Contains(";"))
                return null;
            var splits = attributeStyles.Split(';');
            Css cssStyler = new Css();
            foreach(var spl in splits)
            {
                //"background-color: #111;"
                
                var styles = spl.Split(':');
                if(styles.Length == 2)
                {
                    cssStyler.Add(styles[0], styles[1]);
                }
            }
            return cssStyler;
        }
        internal Dictionary<string, string> _stylesList { get; } = new Dictionary<string, string>();
        #region Static
        // 2 or more than Uppercase will become space: FirstBaseline -> first baseline.
        // Underscore _ will be replaced with - : Align_Content -> align-content.
        internal static string GetStyleName(object enumName)
        {
            var str = enumName.ToString();
            if (str.Contains("_"))
                str = str.ToString().ToLower().Replace("_", "-");
            else
            {
                var split = Regex.Split(str, @"(?<!^)(?=[A-Z])");
                if (split.Length == 1)
                    str = str.ToLower().ToLower();
                else
                {
                    var line = new List<string>();
                    foreach (var sp in split)
                    {
                        line.Add(sp);
                    }
                    str = string.Join(" ", line);
                    str = str.ToLower();
                }

            }
            return str;
        }
        public static string ValueStyle(string key, string value)
        {
            return (key + ": " + value + "; ");
        }
        public static string ValueStyle(Cp key, string value)
        {
            var keyString = GetStyleName(key);
            return (key + ": " + value + "; ");
        }
        #endregion
    }

}

