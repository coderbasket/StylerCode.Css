using System;
using System.Collections.Generic;
using System.Text;

namespace StylerCode.Css
{
    /// <summary>
    /// Css values
    /// </summary>
    public static class Cv
    {
        public const string Stretch = "stretch";
        public const string Flex_Start = "flex-start";
        public const string Flex_End = "flex-end";
        public const string Center = "center";
        public const string Space_Between = "space-between";
        public const string Space_Around = "space-around";
        public const string Normal = "normal";
        public const string Baseline = "baseline";
        public const string FirstBaseline = "first baseline";
        public const string LastBaseline = "last baseline";
        public const string Space_Evenly = "space-evenly";
        public const string Start = "start";
        public const string End = "end";
        public const string CenterSafe = "center safe";
        public const string CenterUnsafe = "center unsafe";
        public const string Safe = "safe";
        public const string Unsafe = "unsafe";
        public const string Self_Start = "self-start";
        public const string Self_End = "self-end";
        public const string Auto = "auto";
        public const string Initial = "initial";
        public const string Inherit = "inherit";
        public const string Unset = "unset";
        public const string Revert = "revert";
        public const string Reverse = "reverse";
        public const string Alternate_Reverse = "alternate-reverse";
        public const string Alternate = "alternate";
        public const string None = "none";
        public const string Forwards = "forwards";
        public const string Both = "both";
        public const string Backwards = "backwards";
        public const string Animation_Name = "animation-name";
        public const string Infinite = "infinite";
        public const string Running = "running";
        public const string Paused = "paused";
        public const string Ease = "ease";
        public const string Linear = "linear";
        public const string Step_Start = "step-start";
        public const string Step_End = "step-end";
        public const string Ease_In = "ease-in";
        public const string Ease_Out = "ease-out";
        public const string Ease_In_Out = "ease-in-out";
        public static string Steps(string animationName, int number, string start = "start", string Infinite = "infinite")
        {
            return $"{animationName} {number}s steps({number}, {start}) {Infinite}";
        }

        public static string Cubic_Bezier(double x1, double y1, double x2, double y2)
        {
            return $"cubic-bezier({x1},{y1},{x2},{y2})";
        }
        public const string Textfield = "textfield";
        public const string Menulist_Button = "menulist-button";
        public const string Searchfield = "searchfield";
        public const string Textarea = "textarea";
        public const string Push_Button = "push-button";
        public const string Slider_Horizontal = "slider-horizontal";
        public const string Checkbox = "checkbox";
        public const string Radio = "radio";
        public const string Square_Button = "square-button";
        public const string Menulist = "menulist";
        public const string Listbox = "listbox";
        public const string Meter = "meter";
        public const string Progress_Bar = "progress-bar";
        public const string Button = "button";
        public const string _Webkit_Appearance = "-webkit-appearance";
        public const string Visible = "visible";
        public const string Hidden = "hidden";
        public const string Background_Size = "background-size";
        public const string Background_Position = "background-position";
        public const string Background_Origin = "background-origin";
        public const string Background_Clip = "background-clip";
        public const string Scroll = "scroll";
        public const string Fixed = "fixed";
        public const string Local = "local";
        public const string Background_Attachment = "background-attachment";
        public const string Multiply = "multiply";
        public const string Screen = "screen";
        public const string Overlay = "overlay";
        public const string Darken = "darken";
        public const string Lighten = "lighten";
        public const string Color_Dodge = "color-dodge";
        public const string Color_Burn = "color-burn";
        public const string Hard_Light = "hard-light";
        public const string Soft_Light = "soft-light";
        public const string Difference = "difference";
        public const string Exclusion = "exclusion";
        public const string Hue = "hue";
        public const string Saturation = "saturation";
        public const string Color = "color";
        public const string Luminosity = "luminosity";
        public const string Border_Box = "border-box";
        public const string Padding_Box = "padding-box";
        public const string Content_Box = "content-box";
        public const string Text = "text";
        public const string Transparent = "transparent";
        public static string ColorRGB(int r, int g, int b)
        {
            return $"rgb({r}, {g}, {b})";
        }
        public static string ColorRGBA(int r, int g, int b, double a)
        {
            return $"rgba({r}, {g}, {b}, {a})";
        }
        public static string ColorHSL(int hue, int saturation, int lightness)
        {
            return $"hsl({hue}, {saturation}%, {lightness}%)";
        }
        public static string ColorHSLA(int hue, int saturation, int lightness, double alpha)
        {
            return $"hsl({hue}, {saturation}%, {lightness}%, {alpha})";
        }

        public static string Radial_Gradient(string c1, string c2, string c3)
        {
            return $"radial-gradient({c1}, {c2}, {c3})";
        }

        public static string Linear_Gradient(string direction, string color_stop1, string color_stop2)
        {
            return $"linear-gradient({direction}, {color_stop1}, {color_stop2})";
        }
        public static string Element(string values)
        {
            return $"element({values})";
        }
        public static string Image(string values)
        {
            return $"image({values})";
        }
        public static string Image_Set(string values)
        {
            return $"image-set({values})";
        }
        public static string Cross_Fade(string values)
        {
            return $"cross-fade({values})";
        }
        public const string Top = "top";
        public const string Bottom = "bottom";
        public const string Left = "left";
        public const string Right = "right";
        public const string RightBottom = "right bottom";
        public const string LeftTop = "left top";
        public const string CenterCenter = "center center";
        public const string Repeat = "repeat";
        public const string No_Repeat = "no-repeat";
        public const string Space = "space";
        public const string Round = "round";
        public const string Repeat_Y = "repeat-y";
        public const string Repeat_X = "repeat-x";
        public const string RepeatNo_Repeat = "repeat no-repeat";
        public const string RoundRound = "round round";
        public const string SpaceSpace = "space space";
        public const string Background_Repeat = "background-repeat";
        public const string AutoAuto = "auto auto";
        public const string Cover = "cover";
        public const string Contain = "contain";
        public static string AutoPercent(int percentage)
        {
            return $"auto {percentage}";
        }
        public const string Max_Content = "max-content";
        public const string Min_Content = "min-content";
        public const string Available = "available";
        public const string Fit_Content = "fit-content";
        public const string Border_Image = "border-image";
        public const string Dotted = "dotted";
        public const string Dashed = "dashed";
        public const string Solid = "solid";
        public const string Double = "double";
        public const string Groove = "groove";
        public const string Ridge = "ridge";
        public const string Inset = "inset";
        public const string Outset = "outset";
        public const string Medium = "medium";
        public const string Thin = "thin";
        public const string Thick = "thick";
        public const string Separate = "separate";
        public const string Collapse = "collapse";
        public const string SpaceRound = "space round";
        public const string StretchRepeat = "stretch repeat";
        public const string Fill = "fill";
        public const string Slice = "slice";
        public const string Clone = "clone";
        public static string BoxShadow(string s1, string s2, string color)
        {
            return $"{s1} {s2} {color}";
        }
        public const string Avoid = "avoid";
        public const string Always = "always";
        public const string All = "all";
        public const string Avoid_Page = "avoid-page";
        public const string Page = "page";
        public const string Recto = "recto";
        public const string Verso = "verso";
        public const string Avoid_Column = "avoid-column";
        public const string Column = "column";
        public const string Avoid_Region = "avoid-region";
        public const string Region = "region";
        public const string Inline_Start = "inline-start";
        public const string Inline_End = "inline-end";
        public static string InsetApply(int px1, int px2, int px3, int px4)
        {
            return $"{px1} {px2} {px3} {px4}";
        }
        public static string Circle(string value)
        {
            return $"circle({value})";
        }
        public static string Ellipse(string value)
        {
            return $"ellipse({value})";
        }
        public static string Polygon(string value)
        {
            return $"polygon({value})";
        }
        public static string Path(string data)
        {
            return $"path({data})";
        }
        public const string Margin_Box = "margin-box";
        public const string Fill_Box = "fill-box";
        public const string Stroke_Box = "stroke-box";
        public const string View_Box = "view-box";
        public const string Clip = "clip";
        public const string Economy = "economy";
        public const string Exact = "exact";
        public const string Balance = "balance";
        public const string Balance_All = "balance-all";
        public const string Grid_Column_Gap = "grid-column-gap";

        public const string Open_Quote = "open-quote";
        public const string Close_Quote = "close-quote";
        public const string No_Open_Quote = "no-open-quote";
        public const string No_Close_Quote = "no-close-quote";
        public const string Contents = "contents";

        public const string Default = "default";
        public const string Context_Menu = "context-menu";
        public const string Help = "help";
        public const string Pointer = "pointer";
        public const string Progress = "progress";
        public const string Wait = "wait";
        public const string Cell = "cell";
        public const string Crosshair = "crosshair";
        public const string Vertical_Text = "vertical-text";
        public const string Alias = "alias";
        public const string Copy = "copy";
        public const string Move = "move";
        public const string No_Drop = "no-drop";
        public const string Not_Allowed = "not-allowed";
        public const string Grab = "grab";
        public const string Grabbing = "grabbing";
        public const string All_Scroll = "all-scroll";
        public const string Col_Resize = "col-resize";
        public const string Row_Resize = "row-resize";
        public const string N_Resize = "n-resize";
        public const string S_Resize = "s-resize";
        public const string W_Resize = "w-resize";
        public const string Ne_Resize = "ne-resize";
        public const string Nw_Resize = "nw-resize";
        public const string Se_Resize = "se-resize";
        public const string Sw_Resize = "sw-resize";
        public const string Ew_Resize = "ew-resize";
        public const string Ns_Resize = "ns-resize";
        public const string Nesw_Resize = "nesw-resize";
        public const string Nwse_Resize = "nwse-resize";
        public const string Zoom_In = "zoom-in";
        public const string Zoom_Out = "zoom-out";
        public const string Ltr = "ltr";
        public const string Rtl = "rtl";
        public const string Inline = "inline";
        public const string Block = "block";
        public const string Inline_Block = "inline-block";
        public const string Inline_Table = "inline-table";
        public const string Run_In = "run-in";
        public const string Flow = "flow";
        public const string Flow_Root = "flow-root";
        public const string Table = "table";
        public const string Flex = "flex";
        public const string Grid = "grid";
        public const string Ruby = "ruby";
        public const string List_Item = "list-item";
        public const string Table_Row_Group = "table-row-group";
        public const string Table_Header_Group = "table-header-group";
        public const string Table_Footer_Group = "table-footer-group";
        public const string Table_Row = "table-row";
        public const string Table_Cell = "table-cell";
        public const string Table_Column_Group = "table-column-group";
        public const string Table_Column = "table-column";
        public const string Table_Caption = "table-caption";
        public const string Ruby_Base = "ruby-base";
        public const string Ruby_Text = "ruby-text";
        public const string Ruby_Base_Container = "ruby-base-container";
        public const string Ruby_Text_Container = "ruby-text-container";
        public const string Inline_Flex = "inline-flex";
        public const string Inline_Grid = "inline-grid";
        public const string Show = "show";
        public const string Hide = "hide";
        public static string Blur(string value)
        {
            return $"blur({value})";
        }
        public static string Brightness(string percentage)
        {
            return $"brightness({percentage})";
        }
        public static string Contrast(string percentage)
        {
            return $"contrast({percentage})";
        }
        public static string Drop_Shadow(string values)
        {
            return $"drop-shadow({values})";
        }
        public static string Grayscale(string percentage)
        {
            return $"grayscale({percentage})";
        }
        public static string Hue_Rotate(string angle)
        {
            return $"hue-rotate({angle})";
        }
        public static string Invert(string invert)
        {
            return $"invert({invert})";
        }
        public static string Opacity(string percentage)
        {
            return $"opacity({percentage})";
        }
        public static string Saturate(string percentage)
        {
            return $"saturate({percentage})";
        }
        public static string Sepia(string percentage)
        {
            return $"sepia({percentage})";
        }
        public static string Contrast(string contrastPercentage, string blurPercentage)
        {
            return $"contrast({contrastPercentage}) blur({blurPercentage})";
        }
        public const string Box_Shadow = "box-shadow";
        public const string Text_Shadow = "text-shadow";
        public const string Content = "content";
        public const string Row = "row";
        public const string Row_Reverse = "row-reverse";
        public const string Column_Reverse = "column-reverse";
        public const string Nowrap = "nowrap";
        public const string Wrap = "wrap";
        public const string Wrap_Reverse = "wrap-reverse";
        public const string Block_Start = "block-start";
        public const string Block_End = "block-end";
        public const string Snap_Block = "snap-block";
        public const string Snap_Inline = "snap-inline";
        public const string Caption = "caption";
        public const string Icon = "icon";
        public const string Menu = "menu";
        public const string Message_Box = "message-box";
        public const string Small_Caption = "small-caption";
        public const string Status_Bar = "status-bar";
        public const string Serif = "serif";
        public const string Sans_Serif = "sans-serif";
        public const string Cursive = "cursive";
        public const string Fantasy = "fantasy";
        public const string Monospace = "monospace";
        public const string System_Ui = "system-ui";
        public const string Emoji = "emoji";
        public const string Math = "math";
        public const string Fangsong = "fangsong";
        public const string Ui_Serif = "ui-serif";
        public const string Ui_Sans_Serif = "ui-sans-serif";
        public const string Ui_Monospace = "ui-monospace";
        public const string Ui_Rounded = "ui-rounded";
        public const string Xx_Small = "xx-small";
        public const string X_Small = "x-small";
        public const string Small = "small";
        public const string Large = "large";
        public const string X_Large = "x-large";
        public const string Xx_Large = "xx-large";
        public const string Xxx_Large = "xxx-large";
        public const string Smaller = "smaller";
        public const string Larger = "larger";
        public const string Semi_Condensed = "semi-condensed";
        public const string Condensed = "condensed";
        public const string Extra_Condensed = "extra-condensed";
        public const string Ultra_Condensed = "ultra-condensed";
        public const string Semi_Expanded = "semi-expanded";
        public const string Expanded = "expanded";
        public const string Extra_Expanded = "extra-expanded";
        public const string Ultra_Expanded = "ultra-expanded";
        public const string Italic = "italic";
        public const string Oblique = "oblique";
        public static string ObliqueApply(string angle)
        {
            return $"oblique {angle}";
        }
        public const string Style = "style";
        public const string Small_Caps = "small-caps";
        public const string All_Small_Caps = "all-small-caps";
        public const string Petite_Caps = "petite-caps";
        public const string All_Petite_Caps = "all-petite-caps";
        public const string Unicase = "unicase";
        public const string Titling_Caps = "titling-caps";
        public const string Jis78 = "jis78";
        public const string Jis83 = "jis83";
        public const string Jis90 = "jis90";
        public const string Jis04 = "jis04";
        public const string Simplified = "simplified";
        public const string Traditional = "traditional";
        public const string Full_Width = "full-width";
        public const string Proportional_Width = "proportional-width";
        public const string Unicode = "unicode";
        public const string Common_Ligatures = "common-ligatures";
        public const string No_Common_Ligatures = "no-common-ligatures";
        public const string Discretionary_Ligatures = "discretionary-ligatures";
        public const string No_Discretionary_Ligatures = "no-discretionary-ligatures";
        public const string Historical_Ligatures = "historical-ligatures";
        public const string No_Historical_Ligatures = "no-historical-ligatures";
        public const string Contextual = "contextual";
        public const string No_Contextual = "no-contextual";
        public const string Ordinal = "ordinal";
        public const string Slashed_Zero = "slashed-zero";
        public const string Lining_Nums = "lining-nums";
        public const string Oldstyle_Nums = "oldstyle-nums";
        public const string Proportional_Nums = "proportional-nums";
        public const string Tabular_Nums = "tabular-nums";
        public const string Diagonal_Fractions = "diagonal-fractions";
        public const string Stacked_Fractions = "stacked-fractions";
        public const string Sub = "sub";
        public const string Super = "super";
        public const string Bold = "bold";
        public const string Lighter = "lighter";
        public const string Bolder = "bolder";
        public const string Num900 = "900";
        public const string Num800 = "800";
        public const string Num700 = "700";
        public const string Num600 = "600";
        public const string Num500 = "500";
        public const string Num400 = "400";
        public const string Num300 = "300";
        public const string Num200 = "200";
        public const string Num100 = "100";
        public const string Line = "line";
        public const string Grid_Gap = "grid-gap";

        public static string Minmax(string min, string max)
        {
            return $"minmax({min}, {min})";
        }


        public const string Dense = "dense";
        public const string RowDense = "row dense";
        public const string ColumnDense = "column dense";
  
                public const string Subgrid = "subgrid";
        public const string Masonry = "masonry";

        public const string First = "first";
        public const string Last = "last";
        public const string Force_End = "force-end";
        public const string Allow_End = "allow-end";
        public const string LastForce_End = "last force-end";
        public const string FirstAllow_EndLast = "first allow-end last";
        public const string Manual = "manual";
        public const string From_Image = "from-image";

        public const string Smooth = "smooth";
        public const string High_Quality = "high-quality";
        public const string Crisp_Edges = "crisp-edges";
        public const string Pixelated = "pixelated";

        public const string Alphabetic = "alphabetic";
        public const string Ideographic = "ideographic";
        public const string Hebrew = "hebrew";
        public const string Hanging = "hanging";

        public const string Isolate = "isolate";
        public const string Legacy = "legacy";

        public const string White = "white";
        public const string Strict = "strict";
        public const string Loose = "loose";
        public const string Anywhere = "anywhere";
        public const string _Webkit_Line_Clamp = "-webkit-line-clamp";
        public const string Match_Parent = "match-parent";
        public const string Create = "create";

        public const string Outside = "outside";
        public const string Inside = "inside";
        public const string Disc = "disc";
        public const string Square = "square";
        public const string Decimal = "decimal";
        public const string Cjk_Decimal = "cjk-decimal";
        public const string Decimal_Leading_Zero = "decimal-leading-zero";
        public const string Lower_Roman = "lower-roman";
        public const string Upper_Roman = "upper-roman";
        public const string Lower_Greek = "lower-greek";
        public const string Lower_Alpha = "lower-alpha";
        public const string Lower_Latin = "lower-latin";
        public const string Upper_Alpha = "upper-alpha";
        public const string Upper_Latin = "upper-latin";
        public const string Arabic_Indic = "arabic-indic";
        public const string Armenian = "armenian";
        public const string Bengali = "bengali";
        public const string Cambodian = "cambodian";
        public const string Cjk_Earthly_Branch = "cjk-earthly-branch";
        public const string Cjk_Heavenly_Stem = "cjk-heavenly-stem";
        public const string Cjk_Ideographic = "cjk-ideographic";
        public const string Devanagari = "devanagari";
        public const string Ethiopic_Numeric = "ethiopic-numeric";
        public const string Georgian = "georgian";
        public const string Gujarati = "gujarati";
        public const string Gurmukhi = "gurmukhi";
        public const string Hiragana = "hiragana";
        public const string Hiragana_Iroha = "hiragana-iroha";
        public const string Japanese_Formal = "japanese-formal";
        public const string Japanese_Informal = "japanese-informal";
        public const string Kannada = "kannada";
        public const string Katakana = "katakana";
        public const string Katakana_Iroha = "katakana-iroha";
        public const string Khmer = "khmer";
        public const string Korean_Hangul_Formal = "korean-hangul-formal";
        public const string Korean_Hanja_Formal = "korean-hanja-formal";
        public const string Korean_Hanja_Informal = "korean-hanja-informal";
        public const string Lao = "lao";
        public const string Lower_Armenian = "lower-armenian";
        public const string Malayalam = "malayalam";
        public const string Mongolian = "mongolian";
        public const string Myanmar = "myanmar";
        public const string Oriya = "oriya";
        public const string Persian = "persian";
        public const string Simp_Chinese_Formal = "simp-chinese-formal";
        public const string Simp_Chinese_Informal = "simp-chinese-informal";
        public const string Tamil = "tamil";
        public const string Telugu = "telugu";
        public const string Thai = "thai";
        public const string Tibetan = "tibetan";
        public const string Trad_Chinese_Formal = "trad-chinese-formal";
        public const string Trad_Chinese_Informal = "trad-chinese-informal";
        public const string Upper_Armenian = "upper-armenian";
        public const string Disclosure_Open = "disclosure-open";
        public const string Disclosure_Closed = "disclosure-closed";
        public const string Discard = "discard";
        public const string In_Flow = "in-flow";
        public const string Alpha = "alpha";
        public const string Luminance = "luminance";
        public const string StretchSpace = "stretch space";
        public const string RepeatRound = "repeat round";
        public const string No_Clip = "no-clip";
        public const string Add = "add";
        public const string Subtract = "subtract";
        public const string Intersect = "intersect";
        public const string Exclude = "exclude";
        public const string Match_Source = "match-source";
        public const string Current = "current";
        public const string Scale_Down = "scale-down";
        public const string ContainScale_Down = "contain scale-down";
        public const string CoverScale_Down = "cover scale-down";
        public static string Url(string path)
        {
            return $"url({path})";
        }

        public const string Overflow_X = "overflow-x";
        public const string Break_Word = "break-word";
        public const string Word_Wrap = "word-wrap";

        public const string Break_After = "break-after";
        public const string Break_Before = "break-before";
        public const string Break_Inside = "break-inside";
        public const string Upright = "upright";
        public const string Rotate_Left = "rotate-left";
        public const string Rotate_Right = "rotate-right";
        public const string @page = "@page";

        public const string Static = "static";
        public const string Relative = "relative";
        public const string Absolute = "absolute";
        public const string Sticky = "sticky";

        public const string Horizontal = "horizontal";
        public const string Vertical = "vertical";
        public const string Overflow = "overflow";

        public const string Grid_Row_Gap = "grid-row-gap";


        public const string StartEnd = "start end";
        public const string EndCenter = "end center";
        public const string BlockProximity = "block proximity";
        public const string Mandatory = "mandatory";
        public const string Proximity = "proximity";
        public const string Dark = "dark";
        public const string Light = "light";
        public const string Stable = "stable";
        public const string StableBothForce = "stable both force";
        public const string AlwaysBothForce = "always both force";
        public const string Outside_Shape = "outside-shape";
        public const string Display = "display";

        public const string Focus = "focus";

        public const string Justify = "justify";
        public const string Justify_All = "justify-all";
        public const string Digits = "digits";

        public const string Underline = "underline";
        public const string Overline = "overline";
        public const string Line_Through = "line-through";
        public const string Blink = "blink";
        public const string UnderlineOverline = "underline overline";
        public const string UnderlineLine_ThroughBlink = "underline line-through blink";
        public const string UnderlineOverlineLine_ThroughBlink = "underline overline line-through blink";
        public const string Spelling_Error = "spelling-error";
        public const string Grammar_Error = "grammar-error";
        public const string Wavy = "wavy";
        public const string From_Font = "from-font";
        public const string OverRight = "over right";
        public const string OverAll = "over all";
        public const string UnderRight = "under right";
        public const string UnderAll = "under all";
        public const string Filled = "filled";
        public const string Open = "open";
        public const string Dot = "dot";
        public const string Double_Circle = "double-circle";
        public const string Triangle = "triangle";
        public const string Sesame = "sesame";
        public const string FilledCircle = "filled circle";
        public const string OpenSesame = "open sesame";

        public const string Inter_Word = "inter-word";
        public const string Inter_Character = "inter-character";
        public const string Mixed = "mixed";
        public const string Sideways = "sideways";
        public const string Ellipsis = "ellipsis";
        public const string Fade = "fade";
        public static string FadeApply(string percentage)
        {
            return $"fade({percentage})";
        }
        public const string OptimizeSpeed = "optimizeSpeed";
        public const string OptimizeLegibility = "optimizeLegibility";
        public const string GeometricPrecision = "geometricPrecision";
        public const string Trim_Inner = "trim-inner";
        public const string Discard_Before = "discard-before";
        public const string Discard_After = "discard-after";
        public const string Trim_Start = "trim-start";
        public const string Space_Start = "space-start";
        public const string Space_First = "space-first";
        public const string Trim_End = "trim-end";
        public const string Space_End = "space-end";
        public const string Trim_Adjacent = "trim-adjacent";
        public const string Space_Adjacent = "space-adjacent";
        public const string No_Compress = "no-compress";
        public const string Ideograph_Alpha = "ideograph-alpha";
        public const string Ideograph_Numeric = "ideograph-numeric";
        public const string Punctuation = "punctuation";
        public const string Capitalize = "capitalize";
        public const string Uppercase = "uppercase";
        public const string Lowercase = "lowercase";
        public const string Full_Size_Kana = "full-size-kana";
        public const string Under = "under";
        public const string From_FontLeft = "from-font left";
        public const string From_FontRight = "from-font right";
        public const string UnderLeft = "under left";
        public const string Pretty = "pretty";
        public const string Pan_X = "pan-x";
        public const string Pan_Left = "pan-left";
        public const string Pan_Right = "pan-right";
        public const string Pan_Y = "pan-y";
        public const string Pan_Up = "pan-up";
        public const string Pan_Down = "pan-down";
        public const string Manipulation = "manipulation";
        public static string Matrix(string values)
        {
            return $"matrix({values})";
        }
        public static string Matrix3d(string values)
        {
            return $"matrix3d({values})";
        }
        public static string Translate(string values)
        {
            return $"translate({values})";
        }
        public static string TranslateX(string values)
        {
            return $"translateX({values})";
        }
        public static string Translate3d(string values)
        {
            return $"translate3d({values})";
        }
        public static string TranslateZ(string values)
        {
            return $"translateZ({values})";
        }
        public static string Scale(string values)
        {
            return $"scale({values})";
        }
        public static string ScaleX(string values)
        {
            return $"scaleX({values})";
        }
        public static string ScaleY(string values)
        {
            return $"scaleY({values})";
        }
        public static string ScaleZ(string values)
        {
            return $"scaleZ({values})";
        }
        public static string Rotate(string values)
        {
            return $"rotate({values})";
        }
        public static string Rotate3d(string values)
        {
            return $"rotate3d({values})";
        }
        public static string RotateX(string values)
        {
            return $"rotateX({values})";
        }
        public static string RotateY(string values)
        {
            return $"rotateY({values})";
        }
        public static string RotateZ(string values)
        {
            return $"rotateZ({values})";
        }
        public static string Perspective(string values)
        {
            return $"perspective({values})";
        }
        public static string Skew(string values)
        {
            return $"skew({values})";
        }
        public static string SkewX(string values)
        {
            return $"skewX({values})";
        }
        public static string SkewY(string values)
        {
            return $"skewY({values})";
        }
        public const string Flat = "flat";
        public const string Preserve_3d = "preserve-3d";
        public const string Embed = "embed";
        public const string Bidi_Override = "bidi-override";
        public const string Isolate_Override = "isolate-override";
        public const string Plaintext = "plaintext";
        public const string Middle = "middle";
        public const string Text_Top = "text-top";
        public const string Text_Bottom = "text-bottom";
        public const string Pre = "pre";
        public const string Pre_Wrap = "pre-wrap";
        public const string Pre_Line = "pre-line";
        public const string Scroll_Position = "scroll-position";
        public const string Transform = "transform";
        public const string Keep_All = "keep-all";
        public const string Break_All = "break-all";
        public const string Overflow_Wrap = "overflow-wrap";
        public const string Avoid_Line = "avoid-line";
        public const string Avoid_Flex = "avoid-flex";
        public const string Minimum = "minimum";
        public const string Maximum = "maximum";
        public const string Clear = "clear";
        public const string Horizontal_Tb = "horizontal-tb";
        public const string Vertical_Rl = "vertical-rl";
        public const string Vertical_Lr = "vertical-lr";
        public const string Sideways_Rl = "sideways-rl";
        public const string Sideways_Lr = "sideways-lr";


    }
}
