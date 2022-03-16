using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StylerCode.Css
{
    public class CssStyleBase
    {
        internal Dictionary<string, string> _stylesList { get; } = new Dictionary<string, string>();
        
       
        
        string _align_content;
        /// <summary>
        /// align_content
        /// </summary>
        public string Align_Content
        {
            get { return _align_content; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _align_content = value;
                    var key = GetStyleName(nameof(Align_Content));
                    _stylesList[key] = value;
                }
            }
        }


        string _align_items;
        /// <summary>
        /// align_items
        /// </summary>
        public string Align_Items
        {
            get { return _align_items; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _align_items = value;
                    var key = GetStyleName(nameof(Align_Items));
                    _stylesList[key] = value;
                }
            }
        }


        string _align_self;
        /// <summary>
        /// align_self
        /// </summary>
        public string Align_Self
        {
            get { return _align_self; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _align_self = value;
                    var key = GetStyleName(nameof(Align_Self));
                    _stylesList[key] = value;
                }
            }
        }


        string _all;
        /// <summary>
        /// all
        /// </summary>
        public string All
        {
            get { return _all; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _all = value;
                    var key = GetStyleName(nameof(All));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation;
        /// <summary>
        /// animation
        /// </summary>
        public string Animation
        {
            get { return _animation; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation = value;
                    var key = GetStyleName(nameof(Animation));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_delay;
        /// <summary>
        /// animation_delay
        /// </summary>
        public string Animation_Delay
        {
            get { return _animation_delay; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_delay = value;
                    var key = GetStyleName(nameof(Animation_Delay));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_direction;
        /// <summary>
        /// animation_direction
        /// </summary>
        public string Animation_Direction
        {
            get { return _animation_direction; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_direction = value;
                    var key = GetStyleName(nameof(Animation_Direction));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_duration;
        /// <summary>
        /// animation_duration
        /// </summary>
        public string Animation_Duration
        {
            get { return _animation_duration; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_duration = value;
                    var key = GetStyleName(nameof(Animation_Duration));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_fill_mode;
        /// <summary>
        /// animation_fill_mode
        /// </summary>
        public string Animation_Fill_Mode
        {
            get { return _animation_fill_mode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_fill_mode = value;
                    var key = GetStyleName(nameof(Animation_Fill_Mode));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_iteration_count;
        /// <summary>
        /// animation_iteration_count
        /// </summary>
        public string Animation_Iteration_Count
        {
            get { return _animation_iteration_count; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_iteration_count = value;
                    var key = GetStyleName(nameof(Animation_Iteration_Count));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_name;
        /// <summary>
        /// animation_name
        /// </summary>
        public string Animation_Name
        {
            get { return _animation_name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_name = value;
                    var key = GetStyleName(nameof(Animation_Name));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_play_state;
        /// <summary>
        /// animation_play_state
        /// </summary>
        public string Animation_Play_State
        {
            get { return _animation_play_state; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_play_state = value;
                    var key = GetStyleName(nameof(Animation_Play_State));
                    _stylesList[key] = value;
                }
            }
        }


        string _animation_timing_function;
        /// <summary>
        /// animation_timing_function
        /// </summary>
        public string Animation_Timing_Function
        {
            get { return _animation_timing_function; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _animation_timing_function = value;
                    var key = GetStyleName(nameof(Animation_Timing_Function));
                    _stylesList[key] = value;
                }
            }
        }


        string _backface_visibility;
        /// <summary>
        /// backface_visibility
        /// </summary>
        public string Backface_Visibility
        {
            get { return _backface_visibility; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _backface_visibility = value;
                    var key = GetStyleName(nameof(Backface_Visibility));
                    _stylesList[key] = value;
                }
            }
        }


        string _background;
        /// <summary>
        /// background
        /// </summary>
        public string Background
        {
            get { return _background; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background = value;
                    var key = GetStyleName(nameof(Background));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_attachment;
        /// <summary>
        /// background_attachment
        /// </summary>
        public string Background_Attachment
        {
            get { return _background_attachment; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_attachment = value;
                    var key = GetStyleName(nameof(Background_Attachment));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_blend_mode;
        /// <summary>
        /// background_blend_mode
        /// </summary>
        public string Background_Blend_Mode
        {
            get { return _background_blend_mode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_blend_mode = value;
                    var key = GetStyleName(nameof(Background_Blend_Mode));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_clip;
        /// <summary>
        /// background_clip
        /// </summary>
        public string Background_Clip
        {
            get { return _background_clip; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_clip = value;
                    var key = GetStyleName(nameof(Background_Clip));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_color;
        /// <summary>
        /// background_color
        /// </summary>
        public string Background_Color
        {
            get { return _background_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_color = value;
                    var key = GetStyleName(nameof(Background_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_image;
        /// <summary>
        /// background_image
        /// </summary>
        public string Background_Image
        {
            get { return _background_image; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_image = value;
                    var key = GetStyleName(nameof(Background_Image));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_origin;
        /// <summary>
        /// background_origin
        /// </summary>
        public string Background_Origin
        {
            get { return _background_origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_origin = value;
                    var key = GetStyleName(nameof(Background_Origin));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_position;
        /// <summary>
        /// background_position
        /// </summary>
        public string Background_Position
        {
            get { return _background_position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_position = value;
                    var key = GetStyleName(nameof(Background_Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_repeat;
        /// <summary>
        /// background_repeat
        /// </summary>
        public string Background_Repeat
        {
            get { return _background_repeat; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_repeat = value;
                    var key = GetStyleName(nameof(Background_Repeat));
                    _stylesList[key] = value;
                }
            }
        }


        string _background_size;
        /// <summary>
        /// background_size
        /// </summary>
        public string Background_Size
        {
            get { return _background_size; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _background_size = value;
                    var key = GetStyleName(nameof(Background_Size));
                    _stylesList[key] = value;
                }
            }
        }


        string _border;
        /// <summary>
        /// border
        /// </summary>
        public string Border
        {
            get { return _border; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border = value;
                    var key = GetStyleName(nameof(Border));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_bottom;
        /// <summary>
        /// border_bottom
        /// </summary>
        public string Border_Bottom
        {
            get { return _border_bottom; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_bottom = value;
                    var key = GetStyleName(nameof(Border_Bottom));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_bottom_color;
        /// <summary>
        /// border_bottom_color
        /// </summary>
        public string Border_Bottom_Color
        {
            get { return _border_bottom_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_bottom_color = value;
                    var key = GetStyleName(nameof(Border_Bottom_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_bottom_left_radius;
        /// <summary>
        /// border_bottom_left_radius
        /// </summary>
        public string Border_Bottom_Left_Radius
        {
            get { return _border_bottom_left_radius; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_bottom_left_radius = value;
                    var key = GetStyleName(nameof(Border_Bottom_Left_Radius));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_bottom_right_radius;
        /// <summary>
        /// border_bottom_right_radius
        /// </summary>
        public string Border_Bottom_Right_Radius
        {
            get { return _border_bottom_right_radius; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_bottom_right_radius = value;
                    var key = GetStyleName(nameof(Border_Bottom_Right_Radius));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_bottom_style;
        /// <summary>
        /// border_bottom_style
        /// </summary>
        public string Border_Bottom_Style
        {
            get { return _border_bottom_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_bottom_style = value;
                    var key = GetStyleName(nameof(Border_Bottom_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_bottom_width;
        /// <summary>
        /// border_bottom_width
        /// </summary>
        public string Border_Bottom_Width
        {
            get { return _border_bottom_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_bottom_width = value;
                    var key = GetStyleName(nameof(Border_Bottom_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_collapse;
        /// <summary>
        /// border_collapse
        /// </summary>
        public string Border_Collapse
        {
            get { return _border_collapse; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_collapse = value;
                    var key = GetStyleName(nameof(Border_Collapse));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_color;
        /// <summary>
        /// border_color
        /// </summary>
        public string Border_Color
        {
            get { return _border_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_color = value;
                    var key = GetStyleName(nameof(Border_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_image;
        /// <summary>
        /// border_image
        /// </summary>
        public string Border_Image
        {
            get { return _border_image; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_image = value;
                    var key = GetStyleName(nameof(Border_Image));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_image_outset;
        /// <summary>
        /// border_image_outset
        /// </summary>
        public string Border_Image_Outset
        {
            get { return _border_image_outset; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_image_outset = value;
                    var key = GetStyleName(nameof(Border_Image_Outset));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_image_repeat;
        /// <summary>
        /// border_image_repeat
        /// </summary>
        public string Border_Image_Repeat
        {
            get { return _border_image_repeat; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_image_repeat = value;
                    var key = GetStyleName(nameof(Border_Image_Repeat));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_image_slice;
        /// <summary>
        /// border_image_slice
        /// </summary>
        public string Border_Image_Slice
        {
            get { return _border_image_slice; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_image_slice = value;
                    var key = GetStyleName(nameof(Border_Image_Slice));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_image_source;
        /// <summary>
        /// border_image_source
        /// </summary>
        public string Border_Image_Source
        {
            get { return _border_image_source; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_image_source = value;
                    var key = GetStyleName(nameof(Border_Image_Source));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_image_width;
        /// <summary>
        /// border_image_width
        /// </summary>
        public string Border_Image_Width
        {
            get { return _border_image_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_image_width = value;
                    var key = GetStyleName(nameof(Border_Image_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_left;
        /// <summary>
        /// border_left
        /// </summary>
        public string Border_Left
        {
            get { return _border_left; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_left = value;
                    var key = GetStyleName(nameof(Border_Left));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_left_color;
        /// <summary>
        /// border_left_color
        /// </summary>
        public string Border_Left_Color
        {
            get { return _border_left_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_left_color = value;
                    var key = GetStyleName(nameof(Border_Left_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_left_style;
        /// <summary>
        /// border_left_style
        /// </summary>
        public string Border_Left_Style
        {
            get { return _border_left_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_left_style = value;
                    var key = GetStyleName(nameof(Border_Left_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_left_width;
        /// <summary>
        /// border_left_width
        /// </summary>
        public string Border_Left_Width
        {
            get { return _border_left_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_left_width = value;
                    var key = GetStyleName(nameof(Border_Left_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_radius;
        /// <summary>
        /// border_radius
        /// </summary>
        public string Border_Radius
        {
            get { return _border_radius; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_radius = value;
                    var key = GetStyleName(nameof(Border_Radius));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_right;
        /// <summary>
        /// border_right
        /// </summary>
        public string Border_Right
        {
            get { return _border_right; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_right = value;
                    var key = GetStyleName(nameof(Border_Right));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_right_color;
        /// <summary>
        /// border_right_color
        /// </summary>
        public string Border_Right_Color
        {
            get { return _border_right_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_right_color = value;
                    var key = GetStyleName(nameof(Border_Right_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_right_style;
        /// <summary>
        /// border_right_style
        /// </summary>
        public string Border_Right_Style
        {
            get { return _border_right_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_right_style = value;
                    var key = GetStyleName(nameof(Border_Right_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_right_width;
        /// <summary>
        /// border_right_width
        /// </summary>
        public string Border_Right_Width
        {
            get { return _border_right_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_right_width = value;
                    var key = GetStyleName(nameof(Border_Right_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_spacing;
        /// <summary>
        /// border_spacing
        /// </summary>
        public string Border_Spacing
        {
            get { return _border_spacing; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_spacing = value;
                    var key = GetStyleName(nameof(Border_Spacing));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_style;
        /// <summary>
        /// border_style
        /// </summary>
        public string Border_Style
        {
            get { return _border_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_style = value;
                    var key = GetStyleName(nameof(Border_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_top;
        /// <summary>
        /// border_top
        /// </summary>
        public string Border_Top
        {
            get { return _border_top; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_top = value;
                    var key = GetStyleName(nameof(Border_Top));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_top_color;
        /// <summary>
        /// border_top_color
        /// </summary>
        public string Border_Top_Color
        {
            get { return _border_top_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_top_color = value;
                    var key = GetStyleName(nameof(Border_Top_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_top_left_radius;
        /// <summary>
        /// border_top_left_radius
        /// </summary>
        public string Border_Top_Left_Radius
        {
            get { return _border_top_left_radius; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_top_left_radius = value;
                    var key = GetStyleName(nameof(Border_Top_Left_Radius));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_top_right_radius;
        /// <summary>
        /// border_top_right_radius
        /// </summary>
        public string Border_Top_Right_Radius
        {
            get { return _border_top_right_radius; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_top_right_radius = value;
                    var key = GetStyleName(nameof(Border_Top_Right_Radius));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_top_style;
        /// <summary>
        /// border_top_style
        /// </summary>
        public string Border_Top_Style
        {
            get { return _border_top_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_top_style = value;
                    var key = GetStyleName(nameof(Border_Top_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_top_width;
        /// <summary>
        /// border_top_width
        /// </summary>
        public string Border_Top_Width
        {
            get { return _border_top_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_top_width = value;
                    var key = GetStyleName(nameof(Border_Top_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _border_width;
        /// <summary>
        /// border_width
        /// </summary>
        public string Border_Width
        {
            get { return _border_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _border_width = value;
                    var key = GetStyleName(nameof(Border_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _bottom;
        /// <summary>
        /// bottom
        /// </summary>
        public string Bottom
        {
            get { return _bottom; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _bottom = value;
                    var key = GetStyleName(nameof(Bottom));
                    _stylesList[key] = value;
                }
            }
        }


        string _box_decoration_break;
        /// <summary>
        /// box_decoration_break
        /// </summary>
        public string Box_Decoration_Break
        {
            get { return _box_decoration_break; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _box_decoration_break = value;
                    var key = GetStyleName(nameof(Box_Decoration_Break));
                    _stylesList[key] = value;
                }
            }
        }


        string _box_shadow;
        /// <summary>
        /// box_shadow
        /// </summary>
        public string Box_Shadow
        {
            get { return _box_shadow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _box_shadow = value;
                    var key = GetStyleName(nameof(Box_Shadow));
                    _stylesList[key] = value;
                }
            }
        }


        string _box_sizing;
        /// <summary>
        /// box_sizing
        /// </summary>
        public string Box_Sizing
        {
            get { return _box_sizing; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _box_sizing = value;
                    var key = GetStyleName(nameof(Box_Sizing));
                    _stylesList[key] = value;
                }
            }
        }


        string _break_after;
        /// <summary>
        /// break_after
        /// </summary>
        public string Break_After
        {
            get { return _break_after; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _break_after = value;
                    var key = GetStyleName(nameof(Break_After));
                    _stylesList[key] = value;
                }
            }
        }


        string _break_before;
        /// <summary>
        /// break_before
        /// </summary>
        public string Break_Before
        {
            get { return _break_before; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _break_before = value;
                    var key = GetStyleName(nameof(Break_Before));
                    _stylesList[key] = value;
                }
            }
        }


        string _break_inside;
        /// <summary>
        /// break_inside
        /// </summary>
        public string Break_Inside
        {
            get { return _break_inside; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _break_inside = value;
                    var key = GetStyleName(nameof(Break_Inside));
                    _stylesList[key] = value;
                }
            }
        }


        string _caption_side;
        /// <summary>
        /// caption_side
        /// </summary>
        public string Caption_Side
        {
            get { return _caption_side; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _caption_side = value;
                    var key = GetStyleName(nameof(Caption_Side));
                    _stylesList[key] = value;
                }
            }
        }


        string _caret_color;
        /// <summary>
        /// caret_color
        /// </summary>
        public string Caret_Color
        {
            get { return _caret_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _caret_color = value;
                    var key = GetStyleName(nameof(Caret_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _charset;
        /// <summary>
        /// charset
        /// </summary>
        public string charset
        {
            get { return _charset; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _charset = value;
                    var key = GetStyleName(nameof(charset));
                    _stylesList[key] = value;
                }
            }
        }


        string _clear;
        /// <summary>
        /// clear
        /// </summary>
        public string Clear
        {
            get { return _clear; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _clear = value;
                    var key = GetStyleName(nameof(Clear));
                    _stylesList[key] = value;
                }
            }
        }


        string _clip;
        /// <summary>
        /// clip
        /// </summary>
        public string Clip
        {
            get { return _clip; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _clip = value;
                    var key = GetStyleName(nameof(Clip));
                    _stylesList[key] = value;
                }
            }
        }


        string _color;
        /// <summary>
        /// color
        /// </summary>
        public string Color
        {
            get { return _color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value;
                    var key = GetStyleName(nameof(Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_count;
        /// <summary>
        /// column_count
        /// </summary>
        public string Column_Count
        {
            get { return _column_count; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_count = value;
                    var key = GetStyleName(nameof(Column_Count));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_fill;
        /// <summary>
        /// column_fill
        /// </summary>
        public string Column_Fill
        {
            get { return _column_fill; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_fill = value;
                    var key = GetStyleName(nameof(Column_Fill));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_gap;
        /// <summary>
        /// column_gap
        /// </summary>
        public string Column_Gap
        {
            get { return _column_gap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_gap = value;
                    var key = GetStyleName(nameof(Column_Gap));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_rule;
        /// <summary>
        /// column_rule
        /// </summary>
        public string Column_Rule
        {
            get { return _column_rule; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_rule = value;
                    var key = GetStyleName(nameof(Column_Rule));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_rule_color;
        /// <summary>
        /// column_rule_color
        /// </summary>
        public string Column_Rule_Color
        {
            get { return _column_rule_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_rule_color = value;
                    var key = GetStyleName(nameof(Column_Rule_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_rule_style;
        /// <summary>
        /// column_rule_style
        /// </summary>
        public string Column_Rule_Style
        {
            get { return _column_rule_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_rule_style = value;
                    var key = GetStyleName(nameof(Column_Rule_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_rule_width;
        /// <summary>
        /// column_rule_width
        /// </summary>
        public string Column_Rule_Width
        {
            get { return _column_rule_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_rule_width = value;
                    var key = GetStyleName(nameof(Column_Rule_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_span;
        /// <summary>
        /// column_span
        /// </summary>
        public string Column_Span
        {
            get { return _column_span; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_span = value;
                    var key = GetStyleName(nameof(Column_Span));
                    _stylesList[key] = value;
                }
            }
        }


        string _column_width;
        /// <summary>
        /// column_width
        /// </summary>
        public string Column_Width
        {
            get { return _column_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _column_width = value;
                    var key = GetStyleName(nameof(Column_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _columns;
        /// <summary>
        /// columns
        /// </summary>
        public string Columns
        {
            get { return _columns; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _columns = value;
                    var key = GetStyleName(nameof(Columns));
                    _stylesList[key] = value;
                }
            }
        }


        string _content;
        /// <summary>
        /// content
        /// </summary>
        public string Content
        {
            get { return _content; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _content = value;
                    var key = GetStyleName(nameof(Content));
                    _stylesList[key] = value;
                }
            }
        }


        string _counter_increment;
        /// <summary>
        /// counter_increment
        /// </summary>
        public string Counter_Increment
        {
            get { return _counter_increment; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _counter_increment = value;
                    var key = GetStyleName(nameof(Counter_Increment));
                    _stylesList[key] = value;
                }
            }
        }


        string _counter_reset;
        /// <summary>
        /// counter_reset
        /// </summary>
        public string Counter_Reset
        {
            get { return _counter_reset; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _counter_reset = value;
                    var key = GetStyleName(nameof(Counter_Reset));
                    _stylesList[key] = value;
                }
            }
        }


        string _cursor;
        /// <summary>
        /// cursor
        /// </summary>
        public string Cursor
        {
            get { return _cursor; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _cursor = value;
                    var key = GetStyleName(nameof(Cursor));
                    _stylesList[key] = value;
                }
            }
        }


        string _direction;
        /// <summary>
        /// direction
        /// </summary>
        public string Direction
        {
            get { return _direction; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _direction = value;
                    var key = GetStyleName(nameof(Direction));
                    _stylesList[key] = value;
                }
            }
        }


        string _display;
        /// <summary>
        /// display
        /// </summary>
        public string Display
        {
            get { return _display; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _display = value;
                    var key = GetStyleName(nameof(Display));
                    _stylesList[key] = value;
                }
            }
        }


        string _empty_cells;
        /// <summary>
        /// empty_cells
        /// </summary>
        public string Empty_Cells
        {
            get { return _empty_cells; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _empty_cells = value;
                    var key = GetStyleName(nameof(Empty_Cells));
                    _stylesList[key] = value;
                }
            }
        }


        string _filter;
        /// <summary>
        /// filter
        /// </summary>
        public string Filter
        {
            get { return _filter; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _filter = value;
                    var key = GetStyleName(nameof(Filter));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex;
        /// <summary>
        /// flex
        /// </summary>
        public string Flex
        {
            get { return _flex; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex = value;
                    var key = GetStyleName(nameof(Flex));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex_basis;
        /// <summary>
        /// flex_basis
        /// </summary>
        public string Flex_Basis
        {
            get { return _flex_basis; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex_basis = value;
                    var key = GetStyleName(nameof(Flex_Basis));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex_direction;
        /// <summary>
        /// flex_direction
        /// </summary>
        public string Flex_Direction
        {
            get { return _flex_direction; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex_direction = value;
                    var key = GetStyleName(nameof(Flex_Direction));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex_flow;
        /// <summary>
        /// flex_flow
        /// </summary>
        public string Flex_Flow
        {
            get { return _flex_flow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex_flow = value;
                    var key = GetStyleName(nameof(Flex_Flow));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex_grow;
        /// <summary>
        /// flex_grow
        /// </summary>
        public string Flex_Grow
        {
            get { return _flex_grow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex_grow = value;
                    var key = GetStyleName(nameof(Flex_Grow));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex_shrink;
        /// <summary>
        /// flex_shrink
        /// </summary>
        public string Flex_Shrink
        {
            get { return _flex_shrink; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex_shrink = value;
                    var key = GetStyleName(nameof(Flex_Shrink));
                    _stylesList[key] = value;
                }
            }
        }


        string _flex_wrap;
        /// <summary>
        /// flex_wrap
        /// </summary>
        public string Flex_Wrap
        {
            get { return _flex_wrap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _flex_wrap = value;
                    var key = GetStyleName(nameof(Flex_Wrap));
                    _stylesList[key] = value;
                }
            }
        }


        string _float;
        /// <summary>
        /// float
        /// </summary>
        public string Float
        {
            get { return _float; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _float = value;
                    var key = GetStyleName(nameof(Float));
                    _stylesList[key] = value;
                }
            }
        }


        string _font;
        /// <summary>
        /// font
        /// </summary>
        public string Font
        {
            get { return _font; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font = value;
                    var key = GetStyleName(nameof(Font));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_face;
        /// <summary>
        /// font_face
        /// </summary>
        public string font_Face
        {
            get { return _font_face; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_face = value;
                    var key = GetStyleName(nameof(font_Face));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_family;
        /// <summary>
        /// font_family
        /// </summary>
        public string Font_Family
        {
            get { return _font_family; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_family = value;
                    var key = GetStyleName(nameof(Font_Family));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_feature_settings;
        /// <summary>
        /// font_feature_settings
        /// </summary>
        public string Font_Feature_Settings
        {
            get { return _font_feature_settings; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_feature_settings = value;
                    var key = GetStyleName(nameof(Font_Feature_Settings));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_feature_values;
        /// <summary>
        /// font_feature_values
        /// </summary>
        public string font_Feature_Values
        {
            get { return _font_feature_values; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_feature_values = value;
                    var key = GetStyleName(nameof(font_Feature_Values));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_kerning;
        /// <summary>
        /// font_kerning
        /// </summary>
        public string Font_Kerning
        {
            get { return _font_kerning; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_kerning = value;
                    var key = GetStyleName(nameof(Font_Kerning));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_language_override;
        /// <summary>
        /// font_language_override
        /// </summary>
        public string Font_Language_Override
        {
            get { return _font_language_override; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_language_override = value;
                    var key = GetStyleName(nameof(Font_Language_Override));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_size;
        /// <summary>
        /// font_size
        /// </summary>
        public string Font_Size
        {
            get { return _font_size; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_size = value;
                    var key = GetStyleName(nameof(Font_Size));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_size_adjust;
        /// <summary>
        /// font_size_adjust
        /// </summary>
        public string Font_Size_Adjust
        {
            get { return _font_size_adjust; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_size_adjust = value;
                    var key = GetStyleName(nameof(Font_Size_Adjust));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_stretch;
        /// <summary>
        /// font_stretch
        /// </summary>
        public string Font_Stretch
        {
            get { return _font_stretch; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_stretch = value;
                    var key = GetStyleName(nameof(Font_Stretch));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_style;
        /// <summary>
        /// font_style
        /// </summary>
        public string Font_Style
        {
            get { return _font_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_style = value;
                    var key = GetStyleName(nameof(Font_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_synthesis;
        /// <summary>
        /// font_synthesis
        /// </summary>
        public string Font_Synthesis
        {
            get { return _font_synthesis; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_synthesis = value;
                    var key = GetStyleName(nameof(Font_Synthesis));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant;
        /// <summary>
        /// font_variant
        /// </summary>
        public string Font_Variant
        {
            get { return _font_variant; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant = value;
                    var key = GetStyleName(nameof(Font_Variant));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant_alternates;
        /// <summary>
        /// font_variant_alternates
        /// </summary>
        public string Font_Variant_Alternates
        {
            get { return _font_variant_alternates; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant_alternates = value;
                    var key = GetStyleName(nameof(Font_Variant_Alternates));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant_caps;
        /// <summary>
        /// font_variant_caps
        /// </summary>
        public string Font_Variant_Caps
        {
            get { return _font_variant_caps; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant_caps = value;
                    var key = GetStyleName(nameof(Font_Variant_Caps));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant_east_asian;
        /// <summary>
        /// font_variant_east_asian
        /// </summary>
        public string Font_Variant_East_Asian
        {
            get { return _font_variant_east_asian; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant_east_asian = value;
                    var key = GetStyleName(nameof(Font_Variant_East_Asian));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant_ligatures;
        /// <summary>
        /// font_variant_ligatures
        /// </summary>
        public string Font_Variant_Ligatures
        {
            get { return _font_variant_ligatures; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant_ligatures = value;
                    var key = GetStyleName(nameof(Font_Variant_Ligatures));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant_numeric;
        /// <summary>
        /// font_variant_numeric
        /// </summary>
        public string Font_Variant_Numeric
        {
            get { return _font_variant_numeric; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant_numeric = value;
                    var key = GetStyleName(nameof(Font_Variant_Numeric));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_variant_position;
        /// <summary>
        /// font_variant_position
        /// </summary>
        public string Font_Variant_Position
        {
            get { return _font_variant_position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_variant_position = value;
                    var key = GetStyleName(nameof(Font_Variant_Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _font_weight;
        /// <summary>
        /// font_weight
        /// </summary>
        public string Font_Weight
        {
            get { return _font_weight; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _font_weight = value;
                    var key = GetStyleName(nameof(Font_Weight));
                    _stylesList[key] = value;
                }
            }
        }


        string _gap;
        /// <summary>
        /// gap
        /// </summary>
        public string Gap
        {
            get { return _gap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _gap = value;
                    var key = GetStyleName(nameof(Gap));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid;
        /// <summary>
        /// grid
        /// </summary>
        public string Grid
        {
            get { return _grid; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid = value;
                    var key = GetStyleName(nameof(Grid));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_area;
        /// <summary>
        /// grid_area
        /// </summary>
        public string Grid_Area
        {
            get { return _grid_area; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_area = value;
                    var key = GetStyleName(nameof(Grid_Area));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_auto_columns;
        /// <summary>
        /// grid_auto_columns
        /// </summary>
        public string Grid_Auto_Columns
        {
            get { return _grid_auto_columns; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_auto_columns = value;
                    var key = GetStyleName(nameof(Grid_Auto_Columns));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_auto_flow;
        /// <summary>
        /// grid_auto_flow
        /// </summary>
        public string Grid_Auto_Flow
        {
            get { return _grid_auto_flow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_auto_flow = value;
                    var key = GetStyleName(nameof(Grid_Auto_Flow));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_auto_rows;
        /// <summary>
        /// grid_auto_rows
        /// </summary>
        public string Grid_Auto_Rows
        {
            get { return _grid_auto_rows; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_auto_rows = value;
                    var key = GetStyleName(nameof(Grid_Auto_Rows));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_column;
        /// <summary>
        /// grid_column
        /// </summary>
        public string Grid_Column
        {
            get { return _grid_column; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_column = value;
                    var key = GetStyleName(nameof(Grid_Column));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_column_end;
        /// <summary>
        /// grid_column_end
        /// </summary>
        public string Grid_Column_End
        {
            get { return _grid_column_end; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_column_end = value;
                    var key = GetStyleName(nameof(Grid_Column_End));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_column_gap;
        /// <summary>
        /// grid_column_gap
        /// </summary>
        public string Grid_Column_Gap
        {
            get { return _grid_column_gap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_column_gap = value;
                    var key = GetStyleName(nameof(Grid_Column_Gap));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_column_start;
        /// <summary>
        /// grid_column_start
        /// </summary>
        public string Grid_Column_Start
        {
            get { return _grid_column_start; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_column_start = value;
                    var key = GetStyleName(nameof(Grid_Column_Start));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_gap;
        /// <summary>
        /// grid_gap
        /// </summary>
        public string Grid_Gap
        {
            get { return _grid_gap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_gap = value;
                    var key = GetStyleName(nameof(Grid_Gap));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_row;
        /// <summary>
        /// grid_row
        /// </summary>
        public string Grid_Row
        {
            get { return _grid_row; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_row = value;
                    var key = GetStyleName(nameof(Grid_Row));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_row_end;
        /// <summary>
        /// grid_row_end
        /// </summary>
        public string Grid_Row_End
        {
            get { return _grid_row_end; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_row_end = value;
                    var key = GetStyleName(nameof(Grid_Row_End));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_row_gap;
        /// <summary>
        /// grid_row_gap
        /// </summary>
        public string Grid_Row_Gap
        {
            get { return _grid_row_gap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_row_gap = value;
                    var key = GetStyleName(nameof(Grid_Row_Gap));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_row_start;
        /// <summary>
        /// grid_row_start
        /// </summary>
        public string Grid_Row_Start
        {
            get { return _grid_row_start; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_row_start = value;
                    var key = GetStyleName(nameof(Grid_Row_Start));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_template;
        /// <summary>
        /// grid_template
        /// </summary>
        public string Grid_Template
        {
            get { return _grid_template; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_template = value;
                    var key = GetStyleName(nameof(Grid_Template));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_template_areas;
        /// <summary>
        /// grid_template_areas
        /// </summary>
        public string Grid_Template_Areas
        {
            get { return _grid_template_areas; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_template_areas = value;
                    var key = GetStyleName(nameof(Grid_Template_Areas));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_template_columns;
        /// <summary>
        /// grid_template_columns
        /// </summary>
        public string Grid_Template_Columns
        {
            get { return _grid_template_columns; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_template_columns = value;
                    var key = GetStyleName(nameof(Grid_Template_Columns));
                    _stylesList[key] = value;
                }
            }
        }


        string _grid_template_rows;
        /// <summary>
        /// grid_template_rows
        /// </summary>
        public string Grid_Template_Rows
        {
            get { return _grid_template_rows; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _grid_template_rows = value;
                    var key = GetStyleName(nameof(Grid_Template_Rows));
                    _stylesList[key] = value;
                }
            }
        }


        string _hanging_punctuation;
        /// <summary>
        /// hanging_punctuation
        /// </summary>
        public string Hanging_Punctuation
        {
            get { return _hanging_punctuation; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _hanging_punctuation = value;
                    var key = GetStyleName(nameof(Hanging_Punctuation));
                    _stylesList[key] = value;
                }
            }
        }


        string _height;
        /// <summary>
        /// height
        /// </summary>
        public string Height
        {
            get { return _height; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _height = value;
                    var key = GetStyleName(nameof(Height));
                    _stylesList[key] = value;
                }
            }
        }


        string _hyphens;
        /// <summary>
        /// hyphens
        /// </summary>
        public string Hyphens
        {
            get { return _hyphens; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _hyphens = value;
                    var key = GetStyleName(nameof(Hyphens));
                    _stylesList[key] = value;
                }
            }
        }


        string _image_rendering;
        /// <summary>
        /// image_rendering
        /// </summary>
        public string Image_Rendering
        {
            get { return _image_rendering; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _image_rendering = value;
                    var key = GetStyleName(nameof(Image_Rendering));
                    _stylesList[key] = value;
                }
            }
        }


        string _import;
        /// <summary>
        /// import
        /// </summary>
        public string import
        {
            get { return _import; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _import = value;
                    var key = GetStyleName(nameof(import));
                    _stylesList[key] = value;
                }
            }
        }


        string _isolation;
        /// <summary>
        /// isolation
        /// </summary>
        public string Isolation
        {
            get { return _isolation; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _isolation = value;
                    var key = GetStyleName(nameof(Isolation));
                    _stylesList[key] = value;
                }
            }
        }


        string _justify_content;
        /// <summary>
        /// justify_content
        /// </summary>
        public string Justify_Content
        {
            get { return _justify_content; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _justify_content = value;
                    var key = GetStyleName(nameof(Justify_Content));
                    _stylesList[key] = value;
                }
            }
        }


        string _keyframes;
        /// <summary>
        /// keyframes
        /// </summary>
        public string keyframes
        {
            get { return _keyframes; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _keyframes = value;
                    var key = GetStyleName(nameof(keyframes));
                    _stylesList[key] = value;
                }
            }
        }


        string _left;
        /// <summary>
        /// left
        /// </summary>
        public string Left
        {
            get { return _left; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _left = value;
                    var key = GetStyleName(nameof(Left));
                    _stylesList[key] = value;
                }
            }
        }


        string _letter_spacing;
        /// <summary>
        /// letter_spacing
        /// </summary>
        public string Letter_Spacing
        {
            get { return _letter_spacing; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _letter_spacing = value;
                    var key = GetStyleName(nameof(Letter_Spacing));
                    _stylesList[key] = value;
                }
            }
        }


        string _line_break;
        /// <summary>
        /// line_break
        /// </summary>
        public string Line_Break
        {
            get { return _line_break; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _line_break = value;
                    var key = GetStyleName(nameof(Line_Break));
                    _stylesList[key] = value;
                }
            }
        }


        string _line_height;
        /// <summary>
        /// line_height
        /// </summary>
        public string Line_Height
        {
            get { return _line_height; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _line_height = value;
                    var key = GetStyleName(nameof(Line_Height));
                    _stylesList[key] = value;
                }
            }
        }


        string _list_style;
        /// <summary>
        /// list_style
        /// </summary>
        public string List_Style
        {
            get { return _list_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _list_style = value;
                    var key = GetStyleName(nameof(List_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _list_style_image;
        /// <summary>
        /// list_style_image
        /// </summary>
        public string List_Style_Image
        {
            get { return _list_style_image; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _list_style_image = value;
                    var key = GetStyleName(nameof(List_Style_Image));
                    _stylesList[key] = value;
                }
            }
        }


        string _list_style_position;
        /// <summary>
        /// list_style_position
        /// </summary>
        public string List_Style_Position
        {
            get { return _list_style_position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _list_style_position = value;
                    var key = GetStyleName(nameof(List_Style_Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _list_style_type;
        /// <summary>
        /// list_style_type
        /// </summary>
        public string List_Style_Type
        {
            get { return _list_style_type; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _list_style_type = value;
                    var key = GetStyleName(nameof(List_Style_Type));
                    _stylesList[key] = value;
                }
            }
        }


        string _margin;
        /// <summary>
        /// margin
        /// </summary>
        public string Margin
        {
            get { return _margin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _margin = value;
                    var key = GetStyleName(nameof(Margin));
                    _stylesList[key] = value;
                }
            }
        }


        string _margin_bottom;
        /// <summary>
        /// margin_bottom
        /// </summary>
        public string Margin_Bottom
        {
            get { return _margin_bottom; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _margin_bottom = value;
                    var key = GetStyleName(nameof(Margin_Bottom));
                    _stylesList[key] = value;
                }
            }
        }


        string _margin_left;
        /// <summary>
        /// margin_left
        /// </summary>
        public string Margin_Left
        {
            get { return _margin_left; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _margin_left = value;
                    var key = GetStyleName(nameof(Margin_Left));
                    _stylesList[key] = value;
                }
            }
        }


        string _margin_right;
        /// <summary>
        /// margin_right
        /// </summary>
        public string Margin_Right
        {
            get { return _margin_right; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _margin_right = value;
                    var key = GetStyleName(nameof(Margin_Right));
                    _stylesList[key] = value;
                }
            }
        }


        string _margin_top;
        /// <summary>
        /// margin_top
        /// </summary>
        public string Margin_Top
        {
            get { return _margin_top; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _margin_top = value;
                    var key = GetStyleName(nameof(Margin_Top));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask;
        /// <summary>
        /// mask
        /// </summary>
        public string Mask
        {
            get { return _mask; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask = value;
                    var key = GetStyleName(nameof(Mask));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_clip;
        /// <summary>
        /// mask_clip
        /// </summary>
        public string Mask_Clip
        {
            get { return _mask_clip; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_clip = value;
                    var key = GetStyleName(nameof(Mask_Clip));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_composite;
        /// <summary>
        /// mask_composite
        /// </summary>
        public string Mask_Composite
        {
            get { return _mask_composite; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_composite = value;
                    var key = GetStyleName(nameof(Mask_Composite));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_image;
        /// <summary>
        /// mask_image
        /// </summary>
        public string Mask_Image
        {
            get { return _mask_image; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_image = value;
                    var key = GetStyleName(nameof(Mask_Image));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_mode;
        /// <summary>
        /// mask_mode
        /// </summary>
        public string Mask_Mode
        {
            get { return _mask_mode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_mode = value;
                    var key = GetStyleName(nameof(Mask_Mode));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_origin;
        /// <summary>
        /// mask_origin
        /// </summary>
        public string Mask_Origin
        {
            get { return _mask_origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_origin = value;
                    var key = GetStyleName(nameof(Mask_Origin));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_position;
        /// <summary>
        /// mask_position
        /// </summary>
        public string Mask_Position
        {
            get { return _mask_position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_position = value;
                    var key = GetStyleName(nameof(Mask_Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_repeat;
        /// <summary>
        /// mask_repeat
        /// </summary>
        public string Mask_Repeat
        {
            get { return _mask_repeat; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_repeat = value;
                    var key = GetStyleName(nameof(Mask_Repeat));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_size;
        /// <summary>
        /// mask_size
        /// </summary>
        public string Mask_Size
        {
            get { return _mask_size; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_size = value;
                    var key = GetStyleName(nameof(Mask_Size));
                    _stylesList[key] = value;
                }
            }
        }


        string _mask_type;
        /// <summary>
        /// mask_type
        /// </summary>
        public string Mask_Type
        {
            get { return _mask_type; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mask_type = value;
                    var key = GetStyleName(nameof(Mask_Type));
                    _stylesList[key] = value;
                }
            }
        }


        string _max_height;
        /// <summary>
        /// max_height
        /// </summary>
        public string Max_Height
        {
            get { return _max_height; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _max_height = value;
                    var key = GetStyleName(nameof(Max_Height));
                    _stylesList[key] = value;
                }
            }
        }


        string _max_width;
        /// <summary>
        /// max_width
        /// </summary>
        public string Max_Width
        {
            get { return _max_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _max_width = value;
                    var key = GetStyleName(nameof(Max_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _media;
        /// <summary>
        /// media
        /// </summary>
        public string media
        {
            get { return _media; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _media = value;
                    var key = GetStyleName(nameof(media));
                    _stylesList[key] = value;
                }
            }
        }


        string _min_height;
        /// <summary>
        /// min_height
        /// </summary>
        public string Min_Height
        {
            get { return _min_height; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _min_height = value;
                    var key = GetStyleName(nameof(Min_Height));
                    _stylesList[key] = value;
                }
            }
        }


        string _min_width;
        /// <summary>
        /// min_width
        /// </summary>
        public string Min_Width
        {
            get { return _min_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _min_width = value;
                    var key = GetStyleName(nameof(Min_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _mix_blend_mode;
        /// <summary>
        /// mix_blend_mode
        /// </summary>
        public string Mix_Blend_Mode
        {
            get { return _mix_blend_mode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mix_blend_mode = value;
                    var key = GetStyleName(nameof(Mix_Blend_Mode));
                    _stylesList[key] = value;
                }
            }
        }


        string _object_fit;
        /// <summary>
        /// object_fit
        /// </summary>
        public string Object_Fit
        {
            get { return _object_fit; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _object_fit = value;
                    var key = GetStyleName(nameof(Object_Fit));
                    _stylesList[key] = value;
                }
            }
        }


        string _object_position;
        /// <summary>
        /// object_position
        /// </summary>
        public string Object_Position
        {
            get { return _object_position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _object_position = value;
                    var key = GetStyleName(nameof(Object_Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _opacity;
        /// <summary>
        /// opacity
        /// </summary>
        public string Opacity
        {
            get { return _opacity; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _opacity = value;
                    var key = GetStyleName(nameof(Opacity));
                    _stylesList[key] = value;
                }
            }
        }


        string _order;
        /// <summary>
        /// order
        /// </summary>
        public string Order
        {
            get { return _order; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _order = value;
                    var key = GetStyleName(nameof(Order));
                    _stylesList[key] = value;
                }
            }
        }


        string _orphans;
        /// <summary>
        /// orphans
        /// </summary>
        public string Orphans
        {
            get { return _orphans; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _orphans = value;
                    var key = GetStyleName(nameof(Orphans));
                    _stylesList[key] = value;
                }
            }
        }


        string _outline;
        /// <summary>
        /// outline
        /// </summary>
        public string Outline
        {
            get { return _outline; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _outline = value;
                    var key = GetStyleName(nameof(Outline));
                    _stylesList[key] = value;
                }
            }
        }


        string _outline_color;
        /// <summary>
        /// outline_color
        /// </summary>
        public string Outline_Color
        {
            get { return _outline_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _outline_color = value;
                    var key = GetStyleName(nameof(Outline_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _outline_offset;
        /// <summary>
        /// outline_offset
        /// </summary>
        public string Outline_Offset
        {
            get { return _outline_offset; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _outline_offset = value;
                    var key = GetStyleName(nameof(Outline_Offset));
                    _stylesList[key] = value;
                }
            }
        }


        string _outline_style;
        /// <summary>
        /// outline_style
        /// </summary>
        public string Outline_Style
        {
            get { return _outline_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _outline_style = value;
                    var key = GetStyleName(nameof(Outline_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _outline_width;
        /// <summary>
        /// outline_width
        /// </summary>
        public string Outline_Width
        {
            get { return _outline_width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _outline_width = value;
                    var key = GetStyleName(nameof(Outline_Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _overflow;
        /// <summary>
        /// overflow
        /// </summary>
        public string Overflow
        {
            get { return _overflow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _overflow = value;
                    var key = GetStyleName(nameof(Overflow));
                    _stylesList[key] = value;
                }
            }
        }


        string _overflow_wrap;
        /// <summary>
        /// overflow_wrap
        /// </summary>
        public string Overflow_Wrap
        {
            get { return _overflow_wrap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _overflow_wrap = value;
                    var key = GetStyleName(nameof(Overflow_Wrap));
                    _stylesList[key] = value;
                }
            }
        }


        string _overflow_x;
        /// <summary>
        /// overflow_x
        /// </summary>
        public string Overflow_X
        {
            get { return _overflow_x; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _overflow_x = value;
                    var key = GetStyleName(nameof(Overflow_X));
                    _stylesList[key] = value;
                }
            }
        }


        string _overflow_y;
        /// <summary>
        /// overflow_y
        /// </summary>
        public string Overflow_Y
        {
            get { return _overflow_y; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _overflow_y = value;
                    var key = GetStyleName(nameof(Overflow_Y));
                    _stylesList[key] = value;
                }
            }
        }


        string _padding;
        /// <summary>
        /// padding
        /// </summary>
        public string Padding
        {
            get { return _padding; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _padding = value;
                    var key = GetStyleName(nameof(Padding));
                    _stylesList[key] = value;
                }
            }
        }


        string _padding_bottom;
        /// <summary>
        /// padding_bottom
        /// </summary>
        public string Padding_Bottom
        {
            get { return _padding_bottom; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _padding_bottom = value;
                    var key = GetStyleName(nameof(Padding_Bottom));
                    _stylesList[key] = value;
                }
            }
        }


        string _padding_left;
        /// <summary>
        /// padding_left
        /// </summary>
        public string Padding_Left
        {
            get { return _padding_left; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _padding_left = value;
                    var key = GetStyleName(nameof(Padding_Left));
                    _stylesList[key] = value;
                }
            }
        }


        string _padding_right;
        /// <summary>
        /// padding_right
        /// </summary>
        public string Padding_Right
        {
            get { return _padding_right; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _padding_right = value;
                    var key = GetStyleName(nameof(Padding_Right));
                    _stylesList[key] = value;
                }
            }
        }


        string _padding_top;
        /// <summary>
        /// padding_top
        /// </summary>
        public string Padding_Top
        {
            get { return _padding_top; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _padding_top = value;
                    var key = GetStyleName(nameof(Padding_Top));
                    _stylesList[key] = value;
                }
            }
        }


        string _page_break_after;
        /// <summary>
        /// page_break_after
        /// </summary>
        public string Page_Break_After
        {
            get { return _page_break_after; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _page_break_after = value;
                    var key = GetStyleName(nameof(Page_Break_After));
                    _stylesList[key] = value;
                }
            }
        }


        string _page_break_before;
        /// <summary>
        /// page_break_before
        /// </summary>
        public string Page_Break_Before
        {
            get { return _page_break_before; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _page_break_before = value;
                    var key = GetStyleName(nameof(Page_Break_Before));
                    _stylesList[key] = value;
                }
            }
        }


        string _page_break_inside;
        /// <summary>
        /// page_break_inside
        /// </summary>
        public string Page_Break_Inside
        {
            get { return _page_break_inside; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _page_break_inside = value;
                    var key = GetStyleName(nameof(Page_Break_Inside));
                    _stylesList[key] = value;
                }
            }
        }


        string _perspective;
        /// <summary>
        /// perspective
        /// </summary>
        public string Perspective
        {
            get { return _perspective; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _perspective = value;
                    var key = GetStyleName(nameof(Perspective));
                    _stylesList[key] = value;
                }
            }
        }


        string _perspective_origin;
        /// <summary>
        /// perspective_origin
        /// </summary>
        public string Perspective_Origin
        {
            get { return _perspective_origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _perspective_origin = value;
                    var key = GetStyleName(nameof(Perspective_Origin));
                    _stylesList[key] = value;
                }
            }
        }


        string _pointer_events;
        /// <summary>
        /// pointer_events
        /// </summary>
        public string Pointer_Events
        {
            get { return _pointer_events; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _pointer_events = value;
                    var key = GetStyleName(nameof(Pointer_Events));
                    _stylesList[key] = value;
                }
            }
        }


        string _position;
        /// <summary>
        /// position
        /// </summary>
        public string Position
        {
            get { return _position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _position = value;
                    var key = GetStyleName(nameof(Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _quotes;
        /// <summary>
        /// quotes
        /// </summary>
        public string Quotes
        {
            get { return _quotes; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _quotes = value;
                    var key = GetStyleName(nameof(Quotes));
                    _stylesList[key] = value;
                }
            }
        }


        string _resize;
        /// <summary>
        /// resize
        /// </summary>
        public string Resize
        {
            get { return _resize; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _resize = value;
                    var key = GetStyleName(nameof(Resize));
                    _stylesList[key] = value;
                }
            }
        }


        string _right;
        /// <summary>
        /// right
        /// </summary>
        public string Right
        {
            get { return _right; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _right = value;
                    var key = GetStyleName(nameof(Right));
                    _stylesList[key] = value;
                }
            }
        }


        string _row_gap;
        /// <summary>
        /// row_gap
        /// </summary>
        public string Row_Gap
        {
            get { return _row_gap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _row_gap = value;
                    var key = GetStyleName(nameof(Row_Gap));
                    _stylesList[key] = value;
                }
            }
        }


        string _scroll_behavior;
        /// <summary>
        /// scroll_behavior
        /// </summary>
        public string Scroll_Behavior
        {
            get { return _scroll_behavior; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _scroll_behavior = value;
                    var key = GetStyleName(nameof(Scroll_Behavior));
                    _stylesList[key] = value;
                }
            }
        }


        string _tab_size;
        /// <summary>
        /// tab_size
        /// </summary>
        public string Tab_Size
        {
            get { return _tab_size; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _tab_size = value;
                    var key = GetStyleName(nameof(Tab_Size));
                    _stylesList[key] = value;
                }
            }
        }


        string _table_layout;
        /// <summary>
        /// table_layout
        /// </summary>
        public string Table_Layout
        {
            get { return _table_layout; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _table_layout = value;
                    var key = GetStyleName(nameof(Table_Layout));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_align;
        /// <summary>
        /// text_align
        /// </summary>
        public string Text_Align
        {
            get { return _text_align; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_align = value;
                    var key = GetStyleName(nameof(Text_Align));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_align_last;
        /// <summary>
        /// text_align_last
        /// </summary>
        public string Text_Align_Last
        {
            get { return _text_align_last; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_align_last = value;
                    var key = GetStyleName(nameof(Text_Align_Last));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_combine_upright;
        /// <summary>
        /// text_combine_upright
        /// </summary>
        public string Text_Combine_Upright
        {
            get { return _text_combine_upright; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_combine_upright = value;
                    var key = GetStyleName(nameof(Text_Combine_Upright));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_decoration;
        /// <summary>
        /// text_decoration
        /// </summary>
        public string Text_Decoration
        {
            get { return _text_decoration; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_decoration = value;
                    var key = GetStyleName(nameof(Text_Decoration));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_decoration_color;
        /// <summary>
        /// text_decoration_color
        /// </summary>
        public string Text_Decoration_Color
        {
            get { return _text_decoration_color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_decoration_color = value;
                    var key = GetStyleName(nameof(Text_Decoration_Color));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_decoration_line;
        /// <summary>
        /// text_decoration_line
        /// </summary>
        public string Text_Decoration_Line
        {
            get { return _text_decoration_line; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_decoration_line = value;
                    var key = GetStyleName(nameof(Text_Decoration_Line));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_decoration_style;
        /// <summary>
        /// text_decoration_style
        /// </summary>
        public string Text_Decoration_Style
        {
            get { return _text_decoration_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_decoration_style = value;
                    var key = GetStyleName(nameof(Text_Decoration_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_decoration_thickness;
        /// <summary>
        /// text_decoration_thickness
        /// </summary>
        public string Text_Decoration_Thickness
        {
            get { return _text_decoration_thickness; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_decoration_thickness = value;
                    var key = GetStyleName(nameof(Text_Decoration_Thickness));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_indent;
        /// <summary>
        /// text_indent
        /// </summary>
        public string Text_Indent
        {
            get { return _text_indent; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_indent = value;
                    var key = GetStyleName(nameof(Text_Indent));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_justify;
        /// <summary>
        /// text_justify
        /// </summary>
        public string Text_Justify
        {
            get { return _text_justify; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_justify = value;
                    var key = GetStyleName(nameof(Text_Justify));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_orientation;
        /// <summary>
        /// text_orientation
        /// </summary>
        public string Text_Orientation
        {
            get { return _text_orientation; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_orientation = value;
                    var key = GetStyleName(nameof(Text_Orientation));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_overflow;
        /// <summary>
        /// text_overflow
        /// </summary>
        public string Text_Overflow
        {
            get { return _text_overflow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_overflow = value;
                    var key = GetStyleName(nameof(Text_Overflow));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_shadow;
        /// <summary>
        /// text_shadow
        /// </summary>
        public string Text_Shadow
        {
            get { return _text_shadow; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_shadow = value;
                    var key = GetStyleName(nameof(Text_Shadow));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_transform;
        /// <summary>
        /// text_transform
        /// </summary>
        public string Text_Transform
        {
            get { return _text_transform; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_transform = value;
                    var key = GetStyleName(nameof(Text_Transform));
                    _stylesList[key] = value;
                }
            }
        }


        string _text_underline_position;
        /// <summary>
        /// text_underline_position
        /// </summary>
        public string Text_Underline_Position
        {
            get { return _text_underline_position; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _text_underline_position = value;
                    var key = GetStyleName(nameof(Text_Underline_Position));
                    _stylesList[key] = value;
                }
            }
        }


        string _top;
        /// <summary>
        /// top
        /// </summary>
        public string Top
        {
            get { return _top; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _top = value;
                    var key = GetStyleName(nameof(Top));
                    _stylesList[key] = value;
                }
            }
        }


        string _transform;
        /// <summary>
        /// transform
        /// </summary>
        public string Transform
        {
            get { return _transform; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transform = value;
                    var key = GetStyleName(nameof(Transform));
                    _stylesList[key] = value;
                }
            }
        }


        string _transform_origin;
        /// <summary>
        /// transform_origin
        /// </summary>
        public string Transform_Origin
        {
            get { return _transform_origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transform_origin = value;
                    var key = GetStyleName(nameof(Transform_Origin));
                    _stylesList[key] = value;
                }
            }
        }


        string _transform_style;
        /// <summary>
        /// transform_style
        /// </summary>
        public string Transform_Style
        {
            get { return _transform_style; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transform_style = value;
                    var key = GetStyleName(nameof(Transform_Style));
                    _stylesList[key] = value;
                }
            }
        }


        string _transition;
        /// <summary>
        /// transition
        /// </summary>
        public string Transition
        {
            get { return _transition; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transition = value;
                    var key = GetStyleName(nameof(Transition));
                    _stylesList[key] = value;
                }
            }
        }


        string _transition_delay;
        /// <summary>
        /// transition_delay
        /// </summary>
        public string Transition_Delay
        {
            get { return _transition_delay; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transition_delay = value;
                    var key = GetStyleName(nameof(Transition_Delay));
                    _stylesList[key] = value;
                }
            }
        }


        string _transition_duration;
        /// <summary>
        /// transition_duration
        /// </summary>
        public string Transition_Duration
        {
            get { return _transition_duration; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transition_duration = value;
                    var key = GetStyleName(nameof(Transition_Duration));
                    _stylesList[key] = value;
                }
            }
        }


        string _transition_property;
        /// <summary>
        /// transition_property
        /// </summary>
        public string Transition_Property
        {
            get { return _transition_property; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transition_property = value;
                    var key = GetStyleName(nameof(Transition_Property));
                    _stylesList[key] = value;
                }
            }
        }


        string _transition_timing_function;
        /// <summary>
        /// transition_timing_function
        /// </summary>
        public string Transition_Timing_Function
        {
            get { return _transition_timing_function; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _transition_timing_function = value;
                    var key = GetStyleName(nameof(Transition_Timing_Function));
                    _stylesList[key] = value;
                }
            }
        }


        string _unicode_bidi;
        /// <summary>
        /// unicode_bidi
        /// </summary>
        public string Unicode_Bidi
        {
            get { return _unicode_bidi; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _unicode_bidi = value;
                    var key = GetStyleName(nameof(Unicode_Bidi));
                    _stylesList[key] = value;
                }
            }
        }


        string _user_select;
        /// <summary>
        /// user_select
        /// </summary>
        public string User_Select
        {
            get { return _user_select; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _user_select = value;
                    var key = GetStyleName(nameof(User_Select));
                    _stylesList[key] = value;
                }
            }
        }


        string _vertical_align;
        /// <summary>
        /// vertical_align
        /// </summary>
        public string Vertical_Align
        {
            get { return _vertical_align; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _vertical_align = value;
                    var key = GetStyleName(nameof(Vertical_Align));
                    _stylesList[key] = value;
                }
            }
        }


        string _visibility;
        /// <summary>
        /// visibility
        /// </summary>
        public string Visibility
        {
            get { return _visibility; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _visibility = value;
                    var key = GetStyleName(nameof(Visibility));
                    _stylesList[key] = value;
                }
            }
        }


        string _white_space;
        /// <summary>
        /// white_space
        /// </summary>
        public string White_Space
        {
            get { return _white_space; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _white_space = value;
                    var key = GetStyleName(nameof(White_Space));
                    _stylesList[key] = value;
                }
            }
        }


        string _widows;
        /// <summary>
        /// widows
        /// </summary>
        public string Widows
        {
            get { return _widows; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _widows = value;
                    var key = GetStyleName(nameof(Widows));
                    _stylesList[key] = value;
                }
            }
        }


        string _width;
        /// <summary>
        /// width
        /// </summary>
        public string Width
        {
            get { return _width; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _width = value;
                    var key = GetStyleName(nameof(Width));
                    _stylesList[key] = value;
                }
            }
        }


        string _word_break;
        /// <summary>
        /// word_break
        /// </summary>
        public string Word_Break
        {
            get { return _word_break; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _word_break = value;
                    var key = GetStyleName(nameof(Word_Break));
                    _stylesList[key] = value;
                }
            }
        }


        string _word_spacing;
        /// <summary>
        /// word_spacing
        /// </summary>
        public string Word_Spacing
        {
            get { return _word_spacing; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _word_spacing = value;
                    var key = GetStyleName(nameof(Word_Spacing));
                    _stylesList[key] = value;
                }
            }
        }


        string _word_wrap;
        /// <summary>
        /// word_wrap
        /// </summary>
        public string Word_Wrap
        {
            get { return _word_wrap; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _word_wrap = value;
                    var key = GetStyleName(nameof(Word_Wrap));
                    _stylesList[key] = value;
                }
            }
        }


        string _writing_mode;
        /// <summary>
        /// writing_mode
        /// </summary>
        public string Writing_Mode
        {
            get { return _writing_mode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _writing_mode = value;
                    var key = GetStyleName(nameof(Writing_Mode));
                    _stylesList[key] = value;
                }
            }
        }


        string _z_index;
        /// <summary>
        /// z_index
        /// </summary>
        public string Z_Index
        {
            get { return _z_index; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _z_index = value;
                    var key = GetStyleName(nameof(Z_Index));
                    _stylesList[key] = value;
                }
            }
        }




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
        public static string ValueStyle(CssProperties key, string value)
        {
            var keyString = GetStyleName(key);
            return (key + ": " + value + "; ");
        }
        #endregion
    }
}
