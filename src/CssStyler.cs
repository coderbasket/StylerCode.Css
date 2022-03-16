using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace StylerCode.Css
{
    public class CssStyler : CssStyleBase
    {
        
        
        public CssStyler() : base()
        {
           
        }
        public CssStyler(CssStyler currentStyles) : base()
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
        public CssStyler AddStyle(string key, string value)
        {
            _stylesList[key] = value;
            this.NotifyChanged();
            return this;
        }
        
        
        /// <summary>
        /// CssProperties
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public CssStyler AddStyle(CssProperties key, string value)
        {
            var keyString = GetStyleName(key);
            _stylesList[keyString] = value;
            this.NotifyChanged();
            return this;
        }

        public new void Clear()
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
        public void Remove(CssProperties key)
        {
            var keyString = GetStyleName(key);
            if (_stylesList.ContainsKey(keyString))
            {
                _stylesList.Remove(keyString);
                this.NotifyChanged();

            }
        }
        public event EventHandler<CssStyler> StyleChanged;
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
        public CssStyler Clone()
        {
            return new CssStyler(this);
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
        public static explicit operator string(CssStyler cssStyler)
        {
            return cssStyler.ToString();
        }
        public static implicit operator CssStyler(string attributeStyles)
        {
            if(string.IsNullOrEmpty(attributeStyles))
                return null;
            if (!attributeStyles.Contains(";"))
                return null;
            var splits = attributeStyles.Split(';');
            CssStyler cssStyler = new CssStyler();
            foreach(var spl in splits)
            {
                //"background-color: #111;"
                
                var styles = spl.Split(':');
                if(styles.Length == 2)
                {
                    cssStyler.AddStyle(styles[0], styles[1]);
                }
            }
            return cssStyler;
        }
        
    }

}

