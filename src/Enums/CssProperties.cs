using System;
using System.Collections.Generic;
using System.Text;

namespace StylerCode.Css
{
    public enum CssProperties
    {
        /// <summary>
        /// Specifies the alignment between the lines inside a flexible container when the items do not use all available space.
        /// <example>
        /// 
        /// <code>
        /// style="align-content: center;"
        /// 
        /// </code>
        /// stretch | center | flex-start | flex-end | space-between | space-around | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_align-content.asp">Learn more</a>
        /// </remarks>
        Align_Content,
        /// <summary>
        /// Specifies the alignment for items inside a flexible container.
        /// <example>
        /// 
        /// <code>
        /// style="align-items: center;"
        /// 
        /// </code>
        /// stretch | center | flex-start | flex-end | baseline | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_align-items.asp">Learn more</a>
        /// </remarks>
        Align_Items,
        /// <summary>
        /// Specifies the alignment for selected items inside a flexible container
        /// <example>
        /// 
        /// <code>
        /// style="align-self: center;"
        /// 
        /// </code>
        /// auto | stretch | center | flex-start | flex-end | baseline | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_align-self.asp">Learn more</a>
        /// </remarks>
        Align_Self,
        /// <summary>
        /// Resets all properties (except unicode-bidi and direction)
        /// <example>
        /// 
        /// <code>
        /// style="all: initial;"
        /// 
        /// </code>
        /// initial | inherit | unset
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_all.asp">Learn more</a>
        /// </remarks>
        All,
        /// <summary>
        /// A shorthand property for all the animation-* properties
        /// <example>
        /// 
        /// <code>
        /// style="animation: mymove 5s infinite;"
        /// 
        /// </code>
        /// CSS Syntax => animation: name duration timing-function delay iteration-count direction fill-mode play-state;
        /// </example>
        /// </summary>
        ///  /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation.asp">Learn more</a>
        /// </remarks>
        Animation,
        /// <summary>
        /// Specifies a delay for the start of an animation
        /// <example>
        /// 
        /// <code>
        /// style="animation-delay: 2s;"
        /// 
        /// </code>
        /// time | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-delay.asp">Learn more</a>
        /// </remarks>
        Animation_Delay,
        /// <summary>
        /// Specifies whether an animation should be played forwards, backwards or in alternate cycles.
        /// <example>
        /// 
        /// <code>
        /// style="animation-direction: alternate;"
        /// 
        /// </code>
        /// normal | reverse | alternate | alternate-reverse | initial|inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-direction.asp">Learn more</a>
        /// </remarks>
        Animation_Direction,
        /// <summary>
        /// Specifies how long an animation should take to complete one cycle.
        /// <example>
        /// 
        /// <code>
        /// style="animation-duration: 3s;"
        /// 
        /// </code>
        /// time | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-duration.asp">Learn more</a>
        /// </remarks>
        Animation_Duration,
        /// <summary>
        /// Specifies a style for the element when the animation is not playing (before it starts, after it ends, or both).
        /// <example>
        /// 
        /// <code>
        /// style="animation-fill-mode: forwards;"
        /// 
        /// </code>
        /// none | forwards | backwards | both | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-fill-mode.asp">Learn more</a>
        /// </remarks>
        Animation_Fill_Mode,
        /// <summary>
        /// Specifies the number of times an animation should be played.
        /// <example>
        /// 
        /// <code>
        /// style="animation-iteration-count: 2;"
        /// 
        /// </code>
        /// number | infinite | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-iteration-count.asp">Learn more</a>
        /// </remarks>
        Animation_Iteration_Count,
        /// <summary>
        /// Specifies a name for the @keyframes animation.
        /// <example>
        /// 
        /// <code>
        /// style="animation-name: mymove;"
        /// 
        /// </code>
        /// keyframename | none | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-name.asp">Learn more</a>
        /// </remarks>
        Animation_Name,
        /// <summary>
        /// Specifies whether the animation is running or paused.
        /// <example>
        /// 
        /// <code>
        /// style="animation-play-state: paused;"
        /// 
        /// </code>
        /// paused | running | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-play-state.asp">Learn more</a>
        /// </remarks>
        Animation_Play_State,
        /// <summary>
        /// Specifies the speed curve of an animation.
        /// <example>
        /// 
        /// <code>
        /// style="animation-timing-function: linear;"
        /// 
        /// </code>
        /// linear | ease | ease-in | ease-out | ease-in-out | step-start | step-end | steps(int,start|end) | cubic-bezier(n,n,n,n) | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-timing-function.asp">Learn more</a>
        /// </remarks>
        Animation_Timing_Function,
        /// <summary>
        /// Defines whether or not the back face of an element should be visible when facing the user.
        /// <example>
        /// 
        /// <code>
        /// style="backface-visibility: hidden;" | style="-webkit-backface-visibility: hidden; /* Safari */"
        /// 
        /// </code>
        /// visible | hidden | initial | inherit;
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_backface-visibility.asp">Learn more</a>
        /// </remarks>
        Backface_Visibility,
        /// <summary>
        /// A shorthand property for all the background-* properties
        /// <example>
        /// 
        /// <code>
        /// style="background: lightblue url("img_tree.gif") no-repeat fixed center;"
        /// 
        /// </code>
        /// bg-color bg-image position/bg-size bg-repeat bg-origin bg-clip bg-attachment initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_background.asp">Learn more</a>
        /// </remarks>
        Background,
        /// <summary>
        /// Sets whether a background image scrolls with the rest of the page, or is fixed.
        /// <example>
        /// 
        /// <code>
        /// style="background-attachment: fixed;"
        /// 
        /// </code>
        /// scroll | fixed | local | initial | inherit
        /// </example>
        /// </summary>
        /// /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_background-attachment.asp">Learn more</a>
        /// </remarks>
        Background_Attachment,
        /// <summary>
        /// Specifies the blending mode of each background layer (color/image).
        /// <example>
        /// 
        /// <code>
        /// style="background-blend-mode: lighten;"
        /// 
        /// </code>
        /// normal | multiply | screen | overlay | darken | lighten | color-dodge | saturation | color | luminosity
        /// </example>
        /// </summary>\/// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_background-blend-mode.asp">Learn more</a>
        /// </remarks>
        Background_Blend_Mode,
        /// <summary>
        /// Defines how far the background (color or image) should extend within an element.
        /// <example>
        /// 
        /// <code>
        /// style="background-clip: padding-box;"
        /// 
        /// </code>
        /// border-box | padding-box | content-box | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_background-clip.asp">Learn more</a>
        /// </remarks>
        Background_Clip,
        /// <summary>
        /// Specifies the background color of an element.
        /// <example>
        /// 
        /// <code>
        /// style="background-color: coral;"
        /// 
        /// </code>
        /// color | transparent | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_background-color.asp">Learn more</a>
        /// </remarks>
        Background_Color,
        /// <summary>
        /// Specifies one or more background images for an element.
        /// <example>
        /// 
        /// <code>
        /// style="background-image: url("paper.gif");"
        /// 
        /// </code>
        /// url | none | initial | inherit;
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_background-image.asp">Learn more</a>
        /// </remarks>
        Background_Image,
        /// <summary>
        /// Specifies the origin position of a background image.
        /// <example>
        /// 
        /// <code>
        /// style="background-origin: content-box;"
        /// 
        /// </code>
        /// padding-box | border-box | content-box | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_background-origin.asp">Learn more</a>
        /// </remarks>
        Background_Origin,
        /// <summary>
        /// Specifies the origin position of a background image.
        /// <example>
        /// 
        /// <code>
        /// style="background-position: center;"
        /// 
        /// </code>
        /// left top | left center | left bottom | right top | right center  | right bottom | center top | center center | center bottom
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_background-position.asp">Learn more</a>
        /// </remarks>
        Background_Position,
        /// <summary>
        /// Sets if/how a background image will be repeated.
        /// <example>
        /// 
        /// <code>
        /// style="background-repeat: repeat-y;"
        /// 
        /// </code>
        /// repeat | repeat-x | repeat-y | no-repeat | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_background-repeat.asp">Learn more</a>
        /// </remarks>
        Background_Repeat,
        /// <summary>
        /// Specifies the size of the background images.
        /// <example>
        /// 
        /// <code>
        /// style="background-size: auto;"
        /// 
        /// </code>
        /// auto | length | cover | contain | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_background-size.asp">Learn more</a>
        /// </remarks>
        Background_Size,
        /// <summary>
        /// SA shorthand property for border-width, border-style and border-color.
        /// <example>
        /// 
        /// <code>
        /// style="border: 5px solid red;" | style="border: 4px dotted blue;" | style="border: double;"
        /// 
        /// </code>
        /// border-width border-style border-color | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border.asp">Learn more</a>
        /// </remarks>
        Border,
        /// <summary>
        /// A shorthand property for border-bottom-width, border-bottom-style and border-bottom-color.
        /// <example>
        /// 
        /// <code>
        /// style="border-bottom: 5px solid red;" | style="border-bottom: 4px dotted blue;" | style="border-bottom: double;"
        /// 
        /// </code>
        /// border-width border-style border-color | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-bottom.asp">Learn more</a>
        /// </remarks>
        Border_Bottom,
        /// <summary>
        /// Sets the color of the bottom border.
        /// <example>
        /// 
        /// <code>
        /// style="border-bottom-color: coral;"
        /// 
        /// </code>
        /// color | transparent | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-bottom_color.asp">Learn more</a>
        /// </remarks>
        Border_Bottom_Color,
        /// <summary>
        /// Defines the radius of the border of the bottom-left corner.
        /// <example>
        /// 
        /// <code>
        /// style="border-bottom-left-radius: 25px;" | style="border-bottom-left-radius: 50px 20px;"
        /// 
        /// </code>
        /// length | % [length | %] | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-bottom-left-radius.asp">Learn more</a>
        /// </remarks>
        Border_Bottom_Left_Radius,
        /// <summary>
        /// Defines the radius of the border of the bottom-right corner.
        /// <example>
        /// 
        /// <code>
        /// style="border-bottom-right-radius: 25px;" | style="border-bottom-right-radius: 50px 20px;"
        /// 
        /// </code>
        /// length | % [length | %] | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-bottom-right-radius.asp">Learn more</a>
        /// </remarks>
        Border_Bottom_Right_Radius,
        /// <summary>
        /// Sets the style of the bottom border.
        /// <example>
        /// 
        /// <code>
        /// style="border-bottom-style: dotted;"
        /// 
        /// </code>
        /// none | hidden | dotted | dashed | solid | double | groove | ridge | inset | outset | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-bottom_style.asp">Learn more</a>
        /// </remarks>
        Border_Bottom_Style,
        /// <summary>
        /// Sets the width of the bottom border.
        /// <example>
        /// 
        /// <code>
        /// style="border-bottom-width: thin;"
        /// 
        /// </code>
        /// medium | thin | thick | length | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-bottom_width.asp">Learn more</a>
        /// </remarks>
        Border_Bottom_Width,
        /// <summary>
        /// Sets whether table borders should collapse into a single border or be separated.
        /// <example>
        /// 
        /// <code>
        /// style="border-collapse: separate;" | style="border-collapse: collapse;"
        /// 
        /// </code>
        /// separate | collapse | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-collapse.asp">Learn more</a>
        /// </remarks>
        Border_Collapse,
        /// <summary>
        /// Sets the color of the four borders.
        /// <example>
        /// 
        /// <code>
        /// style="border-color: coral;"
        /// 
        /// </code>
        /// color | transparent | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-color.asp">Learn more</a>
        /// </remarks>
        Border_Color,
        /// <summary>
        /// A shorthand property for all the border-image-* properties.
        /// <example>
        /// 
        /// <code>
        /// style="border-image: url(border.png) 30 round;"
        /// 
        /// </code>
        /// source slice width outset repeat | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-image.asp">Learn more</a>
        /// </remarks>
        Border_Image,
        /// <summary>
        /// Specifies the amount by which the border image area extends beyond the border box.
        /// <example>
        /// 
        /// <code>
        /// style="border-image-outset: 10px;"
        /// 
        /// </code>
        /// length | number | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-image-outset.asp">Learn more</a>
        /// </remarks>
        Border_Image_Outset,
        /// <summary>
        /// Specifies whether the border image should be repeated, rounded or stretched.
        /// <example>
        /// 
        /// <code>
        /// style="border-image-repeat: repeat;"
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-image-repeat.asp">Learn more</a>
        /// </remarks>
        Border_Image_Repeat,

        /// <summary>
        /// Specifies how to slice the border image.
        /// <example>
        /// 
        /// <code>
        /// style="border-image-slice: 30%;"
        /// 
        /// </code>
        /// number | % | fill | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-image-slice.asp">Learn more</a>
        /// </remarks>
        Border_Image_Slice,
        /// <summary>
        /// Specifies the path to the image to be used as a border.
        /// <example>
        /// 
        /// <code>
        /// style="border-image-source: url(border.png);"
        /// 
        /// </code>
        /// snone | image | initial | inherit;
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-image-source.asp">Learn more</a>
        /// </remarks>
        Border_Image_Source,
        /// <summary>
        /// Specifies the width of the border image.
        /// <example>
        /// 
        /// <code>
        /// style="border-image-width: 10px;"
        /// 
        /// </code>
        /// number | % | auto | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-image-width.asp">Learn more</a>
        /// </remarks>
        Border_Image_Width,
        /// <summary>
        /// A shorthand property for all the border-left-* properties.
        /// <example>
        /// 
        /// <code>
        /// style="border-left: 5px solid red;" | style="border-left: 4px dotted blue;" | style="border-left: double;"
        /// 
        /// </code>
        /// border-width border-style border-color | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-left.asp">Learn more</a>
        /// </remarks>
        Border_Left,
        /// <summary>
        /// Sets the color of the left border.
        /// <example>
        /// 
        /// <code>
        /// style="border-left-color: coral;"
        /// 
        /// </code>
        /// color | transparent | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-left_color.asp">Learn more</a>
        /// </remarks>
        Border_Left_Color,
        /// <summary>
        /// Sets the style of the left border.
        /// <example>
        /// 
        /// <code>
        /// style="border-left-style: dotted;"
        /// 
        /// </code>
        /// none | hidden | dotted | dashed | solid | double | groove | ridge | inset | outset | initial | inherit;
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-left_style.asp">Learn more</a>
        /// </remarks>
        Border_Left_Style,
        /// <summary>
        /// Sets the width of the left border.
        /// <example>
        /// 
        /// <code>
        /// style="border-left-width: thin;"
        /// 
        /// </code>
        /// medium | thin | thick | length | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-left_width.asp">Learn more</a>
        /// </remarks>
        Border_Left_Width,
        /// <summary>
        /// A shorthand property for the four border-*-radius properties.
        /// <example>
        /// 
        /// <code>
        /// style="border-radius: 25px;" | style="border-radius: 50px 20px;"
        /// 
        /// </code>
        /// 1-4 length | % / 1-4 length | % | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-radius.asp">Learn more</a>
        /// </remarks>
      
        
        Border_Radius,
        /// <summary>
        /// A shorthand property for all the border-right-* properties.
        /// <example>
        /// 
        /// <code>
        /// style="border-right: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-right.asp">Learn more</a>
        /// </remarks>
        Border_Right,
        /// <summary>
        /// Sets the color of the right border.
        /// <example>
        /// 
        /// <code>
        /// style="border-right-color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-right_color.asp">Learn more</a>
        /// </remarks>
        Border_Right_Color,
        /// <summary>
        /// Sets the style of the right border.
        /// <example>
        /// 
        /// <code>
        /// style="border-right-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-right_style.asp">Learn more</a>
        /// </remarks>
        Border_Right_Style,
        /// <summary>
        /// Sets the width of the right border.
        /// <example>
        /// 
        /// <code>
        /// style="border-right-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-right_width.asp">Learn more</a>
        /// </remarks>
        Border_Right_Width,
        /// <summary>
        /// Sets the distance between the borders of adjacent cells.
        /// <example>
        /// 
        /// <code>
        /// style="border-spacing: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-spacing.asp">Learn more</a>
        /// </remarks>
        Border_Spacing,
        /// <summary>
        /// Sets the style of the four borders.
        /// <example>
        /// 
        /// <code>
        /// style="border-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-style.asp">Learn more</a>
        /// </remarks>
        Border_Style,
        /// <summary>
        /// A shorthand property for border-top-width, border-top-style and                  border-top-color.
        /// <example>
        /// 
        /// <code>
        /// style="border-top: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-top.asp">Learn more</a>
        /// </remarks>
        Border_Top,
        /// <summary>
        /// Sets the color of the top border.
        /// <example>
        /// 
        /// <code>
        /// style="border-top-color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-top_color.asp">Learn more</a>
        /// </remarks>
        Border_Top_Color,
        /// <summary>
        /// Defines the radius of the border of the top-left corner.
        /// <example>
        /// 
        /// <code>
        /// style="border-top-left-radius: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-top-left-radius.asp">Learn more</a>
        /// </remarks>
        Border_Top_Left_Radius,
        /// <summary>
        /// Defines the radius of the border of the top-right corner.
        /// <example>
        /// 
        /// <code>
        /// style="border-top-right-radius: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_border-top-right-radius.asp">Learn more</a>
        /// </remarks>
        Border_Top_Right_Radius,
        /// <summary>
        /// Sets the style of the top border.
        /// <example>
        /// 
        /// <code>
        /// style="border-top-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-top_style.asp">Learn more</a>
        /// </remarks>
        Border_Top_Style,
        /// <summary>
        /// Sets the width of the top border.
        /// <example>
        /// 
        /// <code>
        /// style="border-top-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-top_width.asp">Learn more</a>
        /// </remarks>
        Border_Top_Width,
        /// <summary>
        /// Sets the width of the four borders.
        /// <example>
        /// 
        /// <code>
        /// style="border-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_border-width.asp">Learn more</a>
        /// </remarks>
        Border_Width,
        /// <summary>
        /// Sets the elements position, from the bottom of its parent element.
        /// <example>
        /// 
        /// <code>
        /// style="bottom: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_bottom.asp">Learn more</a>
        /// </remarks>
        Bottom,
        /// <summary>
        /// Sets the behavior of the background and border of an element at page-break, or, for in-line elements, at                  line-break..
        /// <example>
        /// 
        /// <code>
        /// style="box-decoration-break: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_box-decoration-break.asp">Learn more</a>
        /// </remarks>
        Box_Decoration_Break,
        /// <summary>
        /// Attaches one or more shadows to an element.
        /// <example>
        /// 
        /// <code>
        /// style="box-shadow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_box-shadow.asp">Learn more</a>
        /// </remarks>
        Box_Shadow,
        /// <summary>
        /// Defines how the width and height of an element are calculated: should                  they include padding and borders, or not.
        /// <example>
        /// 
        /// <code>
        /// style="box-sizing: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_box-sizing.asp">Learn more</a>
        /// </remarks>
        Box_Sizing,
        /// <summary>
        /// Specifies whether or not a page-, column-, or region-break should occur                  after the specified element.
        /// <example>
        /// 
        /// <code>
        /// style="break-after: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_break-after.asp">Learn more</a>
        /// </remarks>
        Break_After,
        /// <summary>
        /// Specifies whether or not a page-, column-, or region-break should occur                  before the specified element.
        /// <example>
        /// 
        /// <code>
        /// style="break-before: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_break-before.asp">Learn more</a>
        /// </remarks>
        Break_Before,
        /// <summary>
        /// Specifies whether or not a page-, column-, or region-break should occur                  inside the specified element.
        /// <example>
        /// 
        /// <code>
        /// style="break-inside: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_break-inside.asp">Learn more</a>
        /// </remarks>
        Break_Inside,
        /// <summary>
        /// Specifies the placement of a table caption.
        /// <example>
        /// 
        /// <code>
        /// style="caption-side: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_tab_caption-side.asp">Learn more</a>
        /// </remarks>
        Caption_Side,
        /// <summary>
        /// Specifies the color of the cursor (caret) in inputs, textareas, or any                  element that is editable.
        /// <example>
        /// 
        /// <code>
        /// style="caret-color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_caret-color.asp">Learn more</a>
        /// </remarks>
        Caret_Color,
        /// <summary>
        /// Specifies the character encoding used in the style sheet.
        /// <example>
        /// 
        /// <code>
        /// style="@charset: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_charset_rule.asp">Learn more</a>
        /// </remarks>
        @charset,
        /// <summary>
        /// Specifies what should happen with the element that is next to a floating                  element.
        /// <example>
        /// 
        /// <code>
        /// style="clear: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_class_clear.asp">Learn more</a>
        /// </remarks>
        Clear,
        /// <summary>
        /// Clips an absolutely positioned element.
        /// <example>
        /// 
        /// <code>
        /// style="clip: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_clip.asp">Learn more</a>
        /// </remarks>
        Clip,
        /// <summary>
        /// Sets the color of text.
        /// <example>
        /// 
        /// <code>
        /// style="color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_color.asp">Learn more</a>
        /// </remarks>
        Color,
        /// <summary>
        /// Specifies the number of columns an element should be divided into.
        /// <example>
        /// 
        /// <code>
        /// style="column-count: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-count.asp">Learn more</a>
        /// </remarks>
        Column_Count,
        /// <summary>
        /// Specifies how to fill columns, balanced or not.
        /// <example>
        /// 
        /// <code>
        /// style="column-fill: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-fill.asp">Learn more</a>
        /// </remarks>
        Column_Fill,
        /// <summary>
        /// Specifies the gap between the columns.
        /// <example>
        /// 
        /// <code>
        /// style="column-gap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-gap.asp">Learn more</a>
        /// </remarks>
        Column_Gap,
        /// <summary>
        /// A shorthand property for all the column-rule-* properties.
        /// <example>
        /// 
        /// <code>
        /// style="column-rule: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-rule.asp">Learn more</a>
        /// </remarks>
        Column_Rule,
        /// <summary>
        /// Specifies the color of the rule between columns.
        /// <example>
        /// 
        /// <code>
        /// style="column-rule-color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-rule-color.asp">Learn more</a>
        /// </remarks>
        Column_Rule_Color,
        /// <summary>
        /// Specifies the style of the rule between columns.
        /// <example>
        /// 
        /// <code>
        /// style="column-rule-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-rule-style.asp">Learn more</a>
        /// </remarks>
        Column_Rule_Style,
        /// <summary>
        /// Specifies the width of the rule between columns.
        /// <example>
        /// 
        /// <code>
        /// style="column-rule-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-rule-width.asp">Learn more</a>
        /// </remarks>
        Column_Rule_Width,
        /// <summary>
        /// Specifies how many columns an element should span across.
        /// <example>
        /// 
        /// <code>
        /// style="column-span: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-span.asp">Learn more</a>
        /// </remarks>
        Column_Span,
        /// <summary>
        /// Specifies the column width.
        /// <example>
        /// 
        /// <code>
        /// style="column-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_column-width.asp">Learn more</a>
        /// </remarks>
        Column_Width,
        /// <summary>
        /// A shorthand property for column-width and column-count.
        /// <example>
        /// 
        /// <code>
        /// style="columns: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_columns.asp">Learn more</a>
        /// </remarks>
        Columns,
        /// <summary>
        /// Used with the :before and :after pseudo-elements, to insert generated content.
        /// <example>
        /// 
        /// <code>
        /// style="content: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_gen_content.asp">Learn more</a>
        /// </remarks>
        Content,
        /// <summary>
        /// Increases or decreases the value of one or more CSS counters.
        /// <example>
        /// 
        /// <code>
        /// style="counter-increment: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_gen_counter-increment.asp">Learn more</a>
        /// </remarks>
        Counter_Increment,
        /// <summary>
        /// Creates or resets one or more CSS counters.
        /// <example>
        /// 
        /// <code>
        /// style="counter-reset: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_gen_counter-reset.asp">Learn more</a>
        /// </remarks>
        Counter_Reset,
        /// <summary>
        /// Specifies the mouse cursor to be displayed when pointing over an element.
        /// <example>
        /// 
        /// <code>
        /// style="cursor: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_class_cursor.asp">Learn more</a>
        /// </remarks>
        Cursor,
        /// <summary>
        /// Specifies the text direction/writing direction.
        /// <example>
        /// 
        /// <code>
        /// style="direction: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_direction.asp">Learn more</a>
        /// </remarks>
        Direction,
        /// <summary>
        /// Specifies how a certain HTML element should be displayed.
        /// <example>
        /// 
        /// <code>
        /// style="display: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_class_display.asp">Learn more</a>
        /// </remarks>
        Display,
        /// <summary>
        /// Specifies whether or not to display borders and background on empty cells in a table.
        /// <example>
        /// 
        /// <code>
        /// style="empty-cells: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_tab_empty-cells.asp">Learn more</a>
        /// </remarks>
        Empty_Cells,
        /// <summary>
        /// Defines effects (e.g. blurring or color shifting) on an element before the element is                  displayed.
        /// <example>
        /// 
        /// <code>
        /// style="filter: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_filter.asp">Learn more</a>
        /// </remarks>
        Filter,
        /// <summary>
        /// A shorthand property for the flex-grow, flex-shrink, and the                  flex-basis                  properties.
        /// <example>
        /// 
        /// <code>
        /// style="flex: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex.asp">Learn more</a>
        /// </remarks>
        Flex,
        /// <summary>
        /// Specifies the initial length of a flexible item.
        /// <example>
        /// 
        /// <code>
        /// style="flex-basis: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex-basis.asp">Learn more</a>
        /// </remarks>
        Flex_Basis,
        /// <summary>
        /// Specifies the direction of the flexible items.
        /// <example>
        /// 
        /// <code>
        /// style="flex-direction: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex-direction.asp">Learn more</a>
        /// </remarks>
        Flex_Direction,
        /// <summary>
        /// A shorthand property for the flex-direction and the flex-wrap properties.
        /// <example>
        /// 
        /// <code>
        /// style="flex-flow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex-flow.asp">Learn more</a>
        /// </remarks>
        Flex_Flow,
        /// <summary>
        /// Specifies how much the item will grow relative to the rest.
        /// <example>
        /// 
        /// <code>
        /// style="flex-grow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex-grow.asp">Learn more</a>
        /// </remarks>
        Flex_Grow,
        /// <summary>
        /// Specifies how the item will shrink relative to the rest.
        /// <example>
        /// 
        /// <code>
        /// style="flex-shrink: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex-shrink.asp">Learn more</a>
        /// </remarks>
        Flex_Shrink,
        /// <summary>
        /// Specifies whether the flexible items should wrap or not.
        /// <example>
        /// 
        /// <code>
        /// style="flex-wrap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_flex-wrap.asp">Learn more</a>
        /// </remarks>
        Flex_Wrap,
        /// <summary>
        /// Specifies whether an element should float to the left, right, or not at                  all.
        /// <example>
        /// 
        /// <code>
        /// style="float: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_class_float.asp">Learn more</a>
        /// </remarks>
        Float,
        /// <summary>
        /// A shorthand property for the font-style, font-variant, font-weight,                      font-size/line-height, and the font-family properties.
        /// <example>
        /// 
        /// <code>
        /// style="font: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_font_font.asp">Learn more</a>
        /// </remarks>
        Font,
        /// <summary>
        /// A rule that allows websites to download and use fonts other than the "web-safe" fonts.
        /// <example>
        /// 
        /// <code>
        /// style="@font-face: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_font-face_rule.asp">Learn more</a>
        /// </remarks>
        @font_Face,
        /// <summary>
        /// Specifies the font family for text.
        /// <example>
        /// 
        /// <code>
        /// style="font-family: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_font_font-family.asp">Learn more</a>
        /// </remarks>
        Font_Family,
        /// <summary>
        /// Allows control over advanced typographic features in OpenType fonts.
        /// <example>
        /// 
        /// <code>
        /// style="font-feature-settings: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_font-feature-settings.asp">Learn more</a>
        /// </remarks>
        Font_Feature_Settings,
        /// <summary>
        /// Allows authors to use a common name in font-variant-alternate for feature activated                  differently in OpenType.
        /// <example>
        /// 
        /// <code>
        /// style="@font-feature-values: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        @font_Feature_Values,
        /// <summary>
        /// Controls the usage of the kerning information (how letters are spaced).
        /// <example>
        /// 
        /// <code>
        /// style="font-kerning: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_font-kerning.asp">Learn more</a>
        /// </remarks>
        Font_Kerning,
        /// <summary>
        /// Controls the usage of language-specific glyphs in a typeface.
        /// <example>
        /// 
        /// <code>
        /// style="font-language-override: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Language_Override,
        /// <summary>
        /// Specifies the font size of text.
        /// <example>
        /// 
        /// <code>
        /// style="font-size: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_font_font-size.asp">Learn more</a>
        /// </remarks>
        Font_Size,
        /// <summary>
        /// Preserves the readability of text when font fallback occurs.
        /// <example>
        /// 
        /// <code>
        /// style="font-size-adjust: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_font-size-adjust.asp">Learn more</a>
        /// </remarks>
        Font_Size_Adjust,
        /// <summary>
        /// Selects a normal, condensed, or expanded face from a font family.
        /// <example>
        /// 
        /// <code>
        /// style="font-stretch: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_font-stretch.asp">Learn more</a>
        /// </remarks>
        Font_Stretch,
        /// <summary>
        /// Specifies the font style for text.
        /// <example>
        /// 
        /// <code>
        /// style="font-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_font_font-style.asp">Learn more</a>
        /// </remarks>
        Font_Style,
        /// <summary>
        /// Controls which missing typefaces (bold or italic) may be synthesized by the browser.
        /// <example>
        /// 
        /// <code>
        /// style="font-synthesis: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Synthesis,
        /// <summary>
        /// Specifies whether or not a text should be displayed in a small-caps font.
        /// <example>
        /// 
        /// <code>
        /// style="font-variant: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_font_font-variant.asp">Learn more</a>
        /// </remarks>
        Font_Variant,
        /// <summary>
        /// Controls the usage of alternate glyphs associated to alternative names defined in                  @font-feature-values.
        /// <example>
        /// 
        /// <code>
        /// style="font-variant-alternates: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Variant_Alternates,
        /// <summary>
        /// Controls the usage of alternate glyphs for capital letters.
        /// <example>
        /// 
        /// <code>
        /// style="font-variant-caps: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_font-variant-caps.asp">Learn more</a>
        /// </remarks>
        Font_Variant_Caps,
        /// <summary>
        /// Controls the usage of alternate glyphs for East Asian scripts (e.g Japanese and Chinese).
        /// <example>
        /// 
        /// <code>
        /// style="font-variant-east-asian: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Variant_East_Asian,
        /// <summary>
        /// Controls which ligatures and contextual forms are used in textual content of the elements it                  applies to.
        /// <example>
        /// 
        /// <code>
        /// style="font-variant-ligatures: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Variant_Ligatures,
        /// <summary>
        /// Controls the usage of alternate glyphs for numbers, fractions, and ordinal markers.
        /// <example>
        /// 
        /// <code>
        /// style="font-variant-numeric: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Variant_Numeric,
        /// <summary>
        /// Controls the usage of alternate glyphs of smaller size positioned as superscript or                  subscript regarding the baseline of the font.
        /// <example>
        /// 
        /// <code>
        /// style="font-variant-position: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Font_Variant_Position,
        /// <summary>
        /// Specifies the weight of a font.
        /// <example>
        /// 
        /// <code>
        /// style="font-weight: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_font_weight.asp">Learn more</a>
        /// </remarks>
        Font_Weight,
        /// <summary>
        /// A shorthand property for the row-gap and the column-gap properties.
        /// <example>
        /// 
        /// <code>
        /// style="gap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_gap.asp">Learn more</a>
        /// </remarks>
        Gap,
        /// <summary>
        /// A shorthand property for the grid-template-rows,                      grid-template-columns, grid-template-areas, grid-auto-rows,                      grid-auto-columns, and the grid-auto-flow properties.
        /// <example>
        /// 
        /// <code>
        /// style="grid: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid.asp">Learn more</a>
        /// </remarks>
        Grid,
        /// <summary>
        /// Either specifies a name for the grid item, or this property is a shorthand property for the                  grid-row-start, grid-column-start, grid-row-end, and                  grid-column-end properties.
        /// <example>
        /// 
        /// <code>
        /// style="grid-area: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-area.asp">Learn more</a>
        /// </remarks>
        Grid_Area,
        /// <summary>
        /// Specifies a default column size.
        /// <example>
        /// 
        /// <code>
        /// style="grid-auto-columns: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-auto-columns.asp">Learn more</a>
        /// </remarks>
        Grid_Auto_Columns,
        /// <summary>
        /// Specifies how auto-placed items are inserted in the grid.
        /// <example>
        /// 
        /// <code>
        /// style="grid-auto-flow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-auto-flow.asp">Learn more</a>
        /// </remarks>
        Grid_Auto_Flow,
        /// <summary>
        /// Specifies a default row size.
        /// <example>
        /// 
        /// <code>
        /// style="grid-auto-rows: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-auto-rows.asp">Learn more</a>
        /// </remarks>
        Grid_Auto_Rows,
        /// <summary>
        /// A shorthand property for the grid-column-start and the grid-column-end                  properties.
        /// <example>
        /// 
        /// <code>
        /// style="grid-column: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-column.asp">Learn more</a>
        /// </remarks>
        Grid_Column,
        /// <summary>
        /// Specifies where to end the grid item.
        /// <example>
        /// 
        /// <code>
        /// style="grid-column-end: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-column-end.asp">Learn more</a>
        /// </remarks>
        Grid_Column_End,
        /// <summary>
        /// Specifies the size of the gap between columns.
        /// <example>
        /// 
        /// <code>
        /// style="grid-column-gap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-column-gap.asp">Learn more</a>
        /// </remarks>
        Grid_Column_Gap,
        /// <summary>
        /// Specifies where to start the grid item.
        /// <example>
        /// 
        /// <code>
        /// style="grid-column-start: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-column-start.asp">Learn more</a>
        /// </remarks>
        Grid_Column_Start,
        /// <summary>
        /// A shorthand property for the grid-row-gap and grid-column-gap properties.
        /// <example>
        /// 
        /// <code>
        /// style="grid-gap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-gap.asp">Learn more</a>
        /// </remarks>
        Grid_Gap,
        /// <summary>
        /// A shorthand property for the grid-row-start and the grid-row-end                  properties.
        /// <example>
        /// 
        /// <code>
        /// style="grid-row: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-row.asp">Learn more</a>
        /// </remarks>
        Grid_Row,
        /// <summary>
        /// Specifies where to end the grid item.
        /// <example>
        /// 
        /// <code>
        /// style="grid-row-end: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-row-end.asp">Learn more</a>
        /// </remarks>
        Grid_Row_End,
        /// <summary>
        /// Specifies the size of the gap between rows.
        /// <example>
        /// 
        /// <code>
        /// style="grid-row-gap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-row-gap.asp">Learn more</a>
        /// </remarks>
        Grid_Row_Gap,
        /// <summary>
        /// Specifies where to start the grid item.
        /// <example>
        /// 
        /// <code>
        /// style="grid-row-start: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-row-start.asp">Learn more</a>
        /// </remarks>
        Grid_Row_Start,
        /// <summary>
        /// A shorthand property for the grid-template-rows, grid-template-columns                  and grid-areas properties.
        /// <example>
        /// 
        /// <code>
        /// style="grid-template: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-template.asp">Learn more</a>
        /// </remarks>
        Grid_Template,
        /// <summary>
        /// Specifies how to display columns and rows, using named grid items.
        /// <example>
        /// 
        /// <code>
        /// style="grid-template-areas: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-template-areas.asp">Learn more</a>
        /// </remarks>
        Grid_Template_Areas,
        /// <summary>
        /// Specifies the size of the columns, and how many columns in a grid layout.
        /// <example>
        /// 
        /// <code>
        /// style="grid-template-columns: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-template-columns.asp">Learn more</a>
        /// </remarks>
        Grid_Template_Columns,
        /// <summary>
        /// Specifies the size of the rows in a grid layout.
        /// <example>
        /// 
        /// <code>
        /// style="grid-template-rows: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_grid-template-rows.asp">Learn more</a>
        /// </remarks>
        Grid_Template_Rows,
        /// <summary>
        /// Specifies whether a punctuation character may be placed outside the line box.
        /// <example>
        /// 
        /// <code>
        /// style="hanging-punctuation: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_hanging-punctuation.asp">Learn more</a>
        /// </remarks>
        Hanging_Punctuation,
        /// <summary>
        /// Sets the height of an element.
        /// <example>
        /// 
        /// <code>
        /// style="height: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_height.asp">Learn more</a>
        /// </remarks>
        Height,
        /// <summary>
        /// Sets how to split words to improve the layout of paragraphs.
        /// <example>
        /// 
        /// <code>
        /// style="hyphens: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_hyphens.asp">Learn more</a>
        /// </remarks>
        Hyphens,
        /// <summary>
        /// Specifies the type of algorithm to use for image scaling.
        /// <example>
        /// 
        /// <code>
        /// style="image-rendering: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_image-rendering.asp">Learn more</a>
        /// </remarks>
        Image_Rendering,
        /// <summary>
        /// Allows you to import a style sheet into another style sheet.
        /// <example>
        /// 
        /// <code>
        /// style="@import: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_import_rule.asp">Learn more</a>
        /// </remarks>
        @import,
        /// <summary>
        /// Defines whether an element must create a new stacking content.
        /// <example>
        /// 
        /// <code>
        /// style="isolation: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_isolation.asp">Learn more</a>
        /// </remarks>
        Isolation,
        /// <summary>
        /// Specifies the alignment between the items inside a flexible container when the items do not                  use all available space.
        /// <example>
        /// 
        /// <code>
        /// style="justify-content: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_justify-content.asp">Learn more</a>
        /// </remarks>
        Justify_Content,
        /// <summary>
        /// Specifies the animation code.
        /// <example>
        /// 
        /// <code>
        /// style="@keyframes: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_animation-keyframes.asp">Learn more</a>
        /// </remarks>
        @keyframes,
        /// <summary>
        /// Specifies the left position of a positioned element.
        /// <example>
        /// 
        /// <code>
        /// style="left: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_left.asp">Learn more</a>
        /// </remarks>
        Left,
        /// <summary>
        /// Increases or decreases the space between characters in a text.
        /// <example>
        /// 
        /// <code>
        /// style="letter-spacing: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_letter-spacing.asp">Learn more</a>
        /// </remarks>
        Letter_Spacing,
        /// <summary>
        /// Specifies how/if to break lines.
        /// <example>
        /// 
        /// <code>
        /// style="line-break: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Line_Break,
        /// <summary>
        /// Sets the line height.
        /// <example>
        /// 
        /// <code>
        /// style="line-height: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_line-height.asp">Learn more</a>
        /// </remarks>
        Line_Height,
        /// <summary>
        /// Sets all the properties for a list in one declaration.
        /// <example>
        /// 
        /// <code>
        /// style="list-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_list-style.asp">Learn more</a>
        /// </remarks>
        List_Style,
        /// <summary>
        /// Specifies an image as the list-item marker.
        /// <example>
        /// 
        /// <code>
        /// style="list-style-image: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_list-style-image.asp">Learn more</a>
        /// </remarks>
        List_Style_Image,
        /// <summary>
        /// Specifies the position of the list-item markers (bullet points).
        /// <example>
        /// 
        /// <code>
        /// style="list-style-position: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_list-style-position.asp">Learn more</a>
        /// </remarks>
        List_Style_Position,
        /// <summary>
        /// Specifies the type of list-item marker.
        /// <example>
        /// 
        /// <code>
        /// style="list-style-type: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_list-style-type.asp">Learn more</a>
        /// </remarks>
        List_Style_Type,
        /// <summary>
        /// Sets all the margin properties in one declaration.
        /// <example>
        /// 
        /// <code>
        /// style="margin: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_margin.asp">Learn more</a>
        /// </remarks>
        Margin,
        /// <summary>
        /// Sets the bottom margin of an element.
        /// <example>
        /// 
        /// <code>
        /// style="margin-bottom: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_margin-bottom.asp">Learn more</a>
        /// </remarks>
        Margin_Bottom,
        /// <summary>
        /// Sets the left margin of an element.
        /// <example>
        /// 
        /// <code>
        /// style="margin-left: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_margin-left.asp">Learn more</a>
        /// </remarks>
        Margin_Left,
        /// <summary>
        /// Sets the right margin of an element.
        /// <example>
        /// 
        /// <code>
        /// style="margin-right: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_margin-right.asp">Learn more</a>
        /// </remarks>
        Margin_Right,
        /// <summary>
        /// Sets the top margin of an element.
        /// <example>
        /// 
        /// <code>
        /// style="margin-top: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_margin-top.asp">Learn more</a>
        /// </remarks>
        Margin_Top,
        /// <summary>
        /// Hides parts of an element by masking or clipping an image at specific places.
        /// <example>
        /// 
        /// <code>
        /// style="mask: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Mask,
        /// <summary>
        /// Specifies the mask area.
        /// <example>
        /// 
        /// <code>
        /// style="mask-clip: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Mask_Clip,
        /// <summary>
        /// Represents a compositing operation used on the current mask layer with                  the mask layers below it.
        /// <example>
        /// 
        /// <code>
        /// style="mask-composite: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Mask_Composite,
        /// <summary>
        /// Specifies an image to be used as a mask layer for an element.
        /// <example>
        /// 
        /// <code>
        /// style="mask-image: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mask-image.asp">Learn more</a>
        /// </remarks>
        Mask_Image,
        /// <summary>
        /// Specifies whether the mask layer image is treated as a luminance mask or                  as an alpha mask.
        /// <example>
        /// 
        /// <code>
        /// style="mask-mode: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mask-mode.asp">Learn more</a>
        /// </remarks>
        Mask_Mode,
        /// <summary>
        /// Specifies the origin position (the mask                  position area) of a mask layer image.
        /// <example>
        /// 
        /// <code>
        /// style="mask-origin: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mask-origin.asp">Learn more</a>
        /// </remarks>
        Mask_Origin,
        /// <summary>
        /// Sets the starting position of a mask layer image (relative to the                  mask position area).
        /// <example>
        /// 
        /// <code>
        /// style="mask-position: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mask-position.asp">Learn more</a>
        /// </remarks>
        Mask_Position,
        /// <summary>
        /// Specifies how the mask layer image is repeated.
        /// <example>
        /// 
        /// <code>
        /// style="mask-repeat: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mask-repeat.asp">Learn more</a>
        /// </remarks>
        Mask_Repeat,
        /// <summary>
        /// Specifies the size of a mask layer image.
        /// <example>
        /// 
        /// <code>
        /// style="mask-size: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mask-size.asp">Learn more</a>
        /// </remarks>
        Mask_Size,
        /// <summary>
        /// Specifies whether an SVG &lt;mask&gt; element is treated as a luminance                  mask or as an alpha mask.
        /// <example>
        /// 
        /// <code>
        /// style="mask-type: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Mask_Type,
        /// <summary>
        /// Sets the maximum height of an element.
        /// <example>
        /// 
        /// <code>
        /// style="max-height: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_max-height.asp">Learn more</a>
        /// </remarks>
        Max_Height,
        /// <summary>
        /// Sets the maximum width of an element.
        /// <example>
        /// 
        /// <code>
        /// style="max-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_max-width.asp">Learn more</a>
        /// </remarks>
        Max_Width,
        /// <summary>
        /// Sets the style rules for different media types/devices/sizes.
        /// <example>
        /// 
        /// <code>
        /// style="@media: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_mediaquery.asp">Learn more</a>
        /// </remarks>
        @media,
        /// <summary>
        /// Sets the minimum height of an element.
        /// <example>
        /// 
        /// <code>
        /// style="min-height: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_min-height.asp">Learn more</a>
        /// </remarks>
        Min_Height,
        /// <summary>
        /// Sets the minimum width of an element.
        /// <example>
        /// 
        /// <code>
        /// style="min-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_min-width.asp">Learn more</a>
        /// </remarks>
        Min_Width,
        /// <summary>
        /// Specifies how an element's content should blend with its direct parent background.
        /// <example>
        /// 
        /// <code>
        /// style="mix-blend-mode: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_mix-blend-mode.asp">Learn more</a>
        /// </remarks>
        Mix_Blend_Mode,
        /// <summary>
        /// Specifies how the contents of a replaced element should be fitted to the box established by                  its used height and width.
        /// <example>
        /// 
        /// <code>
        /// style="object-fit: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_object-fit.asp">Learn more</a>
        /// </remarks>
        Object_Fit,
        /// <summary>
        /// Specifies the alignment of the replaced element inside its box.
        /// <example>
        /// 
        /// <code>
        /// style="object-position: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_object-position.asp">Learn more</a>
        /// </remarks>
        Object_Position,
        /// <summary>
        /// Sets the opacity level for an element.
        /// <example>
        /// 
        /// <code>
        /// style="opacity: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_opacity.asp">Learn more</a>
        /// </remarks>
        Opacity,
        /// <summary>
        /// Sets the order of the flexible item, relative to the rest.
        /// <example>
        /// 
        /// <code>
        /// style="order: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_order.asp">Learn more</a>
        /// </remarks>
        Order,
        /// <summary>
        /// Sets the minimum number of lines that must be left at the bottom of a                  page or column.
        /// <example>
        /// 
        /// <code>
        /// style="orphans: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_orphans.asp">Learn more</a>
        /// </remarks>
        Orphans,
        /// <summary>
        /// A shorthand property for the outline-width, outline-style, and                  the outline-color properties.
        /// <example>
        /// 
        /// <code>
        /// style="outline: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_outline.asp">Learn more</a>
        /// </remarks>
        Outline,
        /// <summary>
        /// Sets the color of an outline.
        /// <example>
        /// 
        /// <code>
        /// style="outline-color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_outline-color.asp">Learn more</a>
        /// </remarks>
        Outline_Color,
        /// <summary>
        /// Offsets an outline, and draws it beyond the border edge.
        /// <example>
        /// 
        /// <code>
        /// style="outline-offset: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_outline-offset.asp">Learn more</a>
        /// </remarks>
        Outline_Offset,
        /// <summary>
        /// Sets the style of an outline.
        /// <example>
        /// 
        /// <code>
        /// style="outline-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_outline-style.asp">Learn more</a>
        /// </remarks>
        Outline_Style,
        /// <summary>
        /// Sets the width of an outline.
        /// <example>
        /// 
        /// <code>
        /// style="outline-width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_outline-width.asp">Learn more</a>
        /// </remarks>
        Outline_Width,
        /// <summary>
        /// Specifies what happens if content overflows an element's box.
        /// <example>
        /// 
        /// <code>
        /// style="overflow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_overflow.asp">Learn more</a>
        /// </remarks>
        Overflow,
        /// <summary>
        /// Specifies whether or not the browser can break lines with long words, if                  they overflow the container.
        /// <example>
        /// 
        /// <code>
        /// style="overflow-wrap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_overflow-wrap.asp">Learn more</a>
        /// </remarks>
        Overflow_Wrap,
        /// <summary>
        /// Specifies whether or not to clip the left/right edges of the content, if it overflows the                  element's content area.
        /// <example>
        /// 
        /// <code>
        /// style="overflow-x: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_overflow-x.asp">Learn more</a>
        /// </remarks>
        Overflow_X,
        /// <summary>
        /// Specifies whether or not to clip the top/bottom edges of the content, if it overflows the                  element's content area.
        /// <example>
        /// 
        /// <code>
        /// style="overflow-y: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_overflow-y.asp">Learn more</a>
        /// </remarks>
        Overflow_Y,
        /// <summary>
        /// A shorthand property for all the padding-* properties.
        /// <example>
        /// 
        /// <code>
        /// style="padding: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_padding.asp">Learn more</a>
        /// </remarks>
        Padding,
        /// <summary>
        /// Sets the bottom padding of an element.
        /// <example>
        /// 
        /// <code>
        /// style="padding-bottom: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_padding-bottom.asp">Learn more</a>
        /// </remarks>
        Padding_Bottom,
        /// <summary>
        /// Sets the left padding of an element.
        /// <example>
        /// 
        /// <code>
        /// style="padding-left: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_padding-left.asp">Learn more</a>
        /// </remarks>
        Padding_Left,
        /// <summary>
        /// Sets the right padding of an element.
        /// <example>
        /// 
        /// <code>
        /// style="padding-right: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_padding-right.asp">Learn more</a>
        /// </remarks>
        Padding_Right,
        /// <summary>
        /// Sets the top padding of an element.
        /// <example>
        /// 
        /// <code>
        /// style="padding-top: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_padding-top.asp">Learn more</a>
        /// </remarks>
        Padding_Top,
        /// <summary>
        /// Sets the page-break behavior after an element.
        /// <example>
        /// 
        /// <code>
        /// style="page-break-after: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_print_pageba.asp">Learn more</a>
        /// </remarks>
        Page_Break_After,
        /// <summary>
        /// Sets the page-break behavior before an element.
        /// <example>
        /// 
        /// <code>
        /// style="page-break-before: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_print_pagebb.asp">Learn more</a>
        /// </remarks>
        Page_Break_Before,
        /// <summary>
        /// Sets the page-break behavior inside an element.
        /// <example>
        /// 
        /// <code>
        /// style="page-break-inside: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_print_pagebi.asp">Learn more</a>
        /// </remarks>
        Page_Break_Inside,
        /// <summary>
        /// Gives a 3D-positioned element some perspective.
        /// <example>
        /// 
        /// <code>
        /// style="perspective: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_perspective.asp">Learn more</a>
        /// </remarks>
        Perspective,
        /// <summary>
        /// Defines at which position the user is looking at the 3D-positioned element.
        /// <example>
        /// 
        /// <code>
        /// style="perspective-origin: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_perspective-origin.asp">Learn more</a>
        /// </remarks>
        Perspective_Origin,
        /// <summary>
        /// Defines whether or not an element reacts to pointer events.
        /// <example>
        /// 
        /// <code>
        /// style="pointer-events: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_pointer-events.asp">Learn more</a>
        /// </remarks>
        Pointer_Events,
        /// <summary>
        /// Specifies the type of positioning method used for an element (static, relative, absolute or                  fixed).
        /// <example>
        /// 
        /// <code>
        /// style="position: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_class_position.asp">Learn more</a>
        /// </remarks>
        Position,
        /// <summary>
        /// Sets the type of quotation marks for embedded quotations.
        /// <example>
        /// 
        /// <code>
        /// style="quotes: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_gen_quotes.asp">Learn more</a>
        /// </remarks>
        Quotes,
        /// <summary>
        /// Defines if (and how) an element is resizable by the user.
        /// <example>
        /// 
        /// <code>
        /// style="resize: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_resize.asp">Learn more</a>
        /// </remarks>
        Resize,
        /// <summary>
        /// Specifies the right position of a positioned element.
        /// <example>
        /// 
        /// <code>
        /// style="right: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_right.asp">Learn more</a>
        /// </remarks>
        Right,
        /// <summary>
        /// Specifies the gap between the grid rows.
        /// <example>
        /// 
        /// <code>
        /// style="row-gap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_row-gap.asp">Learn more</a>
        /// </remarks>
        Row_Gap,
        /// <summary>
        /// Specifies whether to smoothly animate the scroll position in a scrollable box, instead of a                  straight jump.
        /// <example>
        /// 
        /// <code>
        /// style="scroll-behavior: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_scroll-behavior.asp">Learn more</a>
        /// </remarks>
        Scroll_Behavior,
        /// <summary>
        /// Specifies the width of a tab character.
        /// <example>
        /// 
        /// <code>
        /// style="tab-size: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_tab-size.asp">Learn more</a>
        /// </remarks>
        Tab_Size,
        /// <summary>
        /// Defines the algorithm used to lay out table cells, rows, and columns.
        /// <example>
        /// 
        /// <code>
        /// style="table-layout: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_tab_table-layout.asp">Learn more</a>
        /// </remarks>
        Table_Layout,
        /// <summary>
        /// Specifies the horizontal alignment of text.
        /// <example>
        /// 
        /// <code>
        /// style="text-align: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_text-align.asp">Learn more</a>
        /// </remarks>
        Text_Align,
        /// <summary>
        /// Describes how the last line of a block or a line right before a forced line break is aligned                  when text-align is "justify".
        /// <example>
        /// 
        /// <code>
        /// style="text-align-last: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-align-last.asp">Learn more</a>
        /// </remarks>
        Text_Align_Last,
        /// <summary>
        /// Specifies the combination of multiple characters into the space of a single character.
        /// <example>
        /// 
        /// <code>
        /// style="text-combine-upright: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Text_Combine_Upright,
        /// <summary>
        /// Specifies the decoration added to text.
        /// <example>
        /// 
        /// <code>
        /// style="text-decoration: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_text-decoration.asp">Learn more</a>
        /// </remarks>
        Text_Decoration,
        /// <summary>
        /// Specifies the color of the text-decoration.
        /// <example>
        /// 
        /// <code>
        /// style="text-decoration-color: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-decoration-color.asp">Learn more</a>
        /// </remarks>
        Text_Decoration_Color,
        /// <summary>
        /// Specifies the type of line in a text-decoration.
        /// <example>
        /// 
        /// <code>
        /// style="text-decoration-line: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-decoration-line.asp">Learn more</a>
        /// </remarks>
        Text_Decoration_Line,
        /// <summary>
        /// Specifies the style of the line in a text decoration.
        /// <example>
        /// 
        /// <code>
        /// style="text-decoration-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-decoration-style.asp">Learn more</a>
        /// </remarks>
        Text_Decoration_Style,
        /// <summary>
        /// Specifies the thickness of the decoration line.
        /// <example>
        /// 
        /// <code>
        /// style="text-decoration-thickness: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_text-decoration-thickness.asp">Learn more</a>
        /// </remarks>
        Text_Decoration_Thickness,
        /// <summary>
        /// Specifies the indentation of the first line in a text-block.
        /// <example>
        /// 
        /// <code>
        /// style="text-indent: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_text-indent.asp">Learn more</a>
        /// </remarks>
        Text_Indent,
        /// <summary>
        /// Specifies the justification method used when text-align is "justify".
        /// <example>
        /// 
        /// <code>
        /// style="text-justify: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-justify.asp">Learn more</a>
        /// </remarks>
        Text_Justify,
        /// <summary>
        /// Defines the orientation of the text in a line.
        /// <example>
        /// 
        /// <code>
        /// style="text-orientation: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Text_Orientation,
        /// <summary>
        /// Specifies what should happen when text overflows the containing element.
        /// <example>
        /// 
        /// <code>
        /// style="text-overflow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-overflow.asp">Learn more</a>
        /// </remarks>
        Text_Overflow,
        /// <summary>
        /// Adds shadow to text.
        /// <example>
        /// 
        /// <code>
        /// style="text-shadow: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_text-shadow.asp">Learn more</a>
        /// </remarks>
        Text_Shadow,
        /// <summary>
        /// Controls the capitalization of text.
        /// <example>
        /// 
        /// <code>
        /// style="text-transform: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_text-transform.asp">Learn more</a>
        /// </remarks>
        Text_Transform,
        /// <summary>
        /// Specifies the position of the underline which is set using the text-decoration property.
        /// <example>
        /// 
        /// <code>
        /// style="text-underline-position: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/https://www.w3schools.com/">Learn more</a>
        /// </remarks>
        Text_Underline_Position,
        /// <summary>
        /// Specifies the top position of a positioned element.
        /// <example>
        /// 
        /// <code>
        /// style="top: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_top.asp">Learn more</a>
        /// </remarks>
        Top,
        /// <summary>
        /// Applies a 2D or 3D transformation to an element.
        /// <example>
        /// 
        /// <code>
        /// style="transform: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transform.asp">Learn more</a>
        /// </remarks>
        Transform,
        /// <summary>
        /// Allows you to change the position on transformed elements.
        /// <example>
        /// 
        /// <code>
        /// style="transform-origin: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transform-origin.asp">Learn more</a>
        /// </remarks>
        Transform_Origin,
        /// <summary>
        /// Specifies how nested elements are rendered in 3D space.
        /// <example>
        /// 
        /// <code>
        /// style="transform-style: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transform-style.asp">Learn more</a>
        /// </remarks>
        Transform_Style,
        /// <summary>
        /// A shorthand property for all the transition-* properties.
        /// <example>
        /// 
        /// <code>
        /// style="transition: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transition.asp">Learn more</a>
        /// </remarks>
        Transition,
        /// <summary>
        /// Specifies when the transition effect will start.
        /// <example>
        /// 
        /// <code>
        /// style="transition-delay: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transition-delay.asp">Learn more</a>
        /// </remarks>
        Transition_Delay,
        /// <summary>
        /// Specifies how many seconds or milliseconds a transition effect takes to complete.
        /// <example>
        /// 
        /// <code>
        /// style="transition-duration: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transition-duration.asp">Learn more</a>
        /// </remarks>
        Transition_Duration,
        /// <summary>
        /// Specifies the name of the CSS property the transition effect is for.
        /// <example>
        /// 
        /// <code>
        /// style="transition-property: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transition-property.asp">Learn more</a>
        /// </remarks>
        Transition_Property,
        /// <summary>
        /// Specifies the speed curve of the transition effect.
        /// <example>
        /// 
        /// <code>
        /// style="transition-timing-function: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_transition-timing-function.asp">Learn more</a>
        /// </remarks>
        Transition_Timing_Function,
        /// <summary>
        /// Used together with the direction property to set or                  return whether the text should be overridden to support multiple languages in the same                  document.
        /// <example>
        /// 
        /// <code>
        /// style="unicode-bidi: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_unicode-bidi.asp">Learn more</a>
        /// </remarks>
        Unicode_Bidi,
        /// <summary>
        /// Specifies whether the text of an element can be selected.
        /// <example>
        /// 
        /// <code>
        /// style="user-select: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_user-select.asp">Learn more</a>
        /// </remarks>
        User_Select,
        /// <summary>
        /// Sets the vertical alignment of an element.
        /// <example>
        /// 
        /// <code>
        /// style="vertical-align: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_vertical-align.asp">Learn more</a>
        /// </remarks>
        Vertical_Align,
        /// <summary>
        /// Specifies whether or not an element is visible.
        /// <example>
        /// 
        /// <code>
        /// style="visibility: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_class_visibility.asp">Learn more</a>
        /// </remarks>
        Visibility,
        /// <summary>
        /// Specifies how white-space inside an element is handled.
        /// <example>
        /// 
        /// <code>
        /// style="white-space: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_white-space.asp">Learn more</a>
        /// </remarks>
        White_Space,
        /// <summary>
        /// Sets the minimum number of lines that must be left at the top of a page                  or column.
        /// <example>
        /// 
        /// <code>
        /// style="widows: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_widows.asp">Learn more</a>
        /// </remarks>
        Widows,
        /// <summary>
        /// Sets the width of an element.
        /// <example>
        /// 
        /// <code>
        /// style="width: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_dim_width.asp">Learn more</a>
        /// </remarks>
        Width,
        /// <summary>
        /// Specifies how words should break when reaching the end of a line.
        /// <example>
        /// 
        /// <code>
        /// style="word-break: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_word-break.asp">Learn more</a>
        /// </remarks>
        Word_Break,
        /// <summary>
        /// Increases or decreases the space between words in a text.
        /// <example>
        /// 
        /// <code>
        /// style="word-spacing: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_text_word-spacing.asp">Learn more</a>
        /// </remarks>
        Word_Spacing,
        /// <summary>
        /// Allows long, unbreakable words to be broken and wrap to the next line.
        /// <example>
        /// 
        /// <code>
        /// style="word-wrap: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_word-wrap.asp">Learn more</a>
        /// </remarks>
        Word_Wrap,
        /// <summary>
        /// Specifies whether lines of text are laid out horizontally or vertically.
        /// <example>
        /// 
        /// <code>
        /// style="writing-mode: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/css3_pr_writing-mode.asp">Learn more</a>
        /// </remarks>
        Writing_Mode,
        /// <summary>
        /// Sets the stack order of a positioned element.
        /// <example>
        /// 
        /// <code>
        /// style="z-index: "
        /// 
        /// </code>
        /// stretch | repeat | round | space | initial | inherit
        /// </example>
        /// </summary>
        /// <remarks>
        /// <a href="https://www.w3schools.com/cssref/pr_pos_z-index.asp">Learn more</a>
        /// </remarks>
        Z_Index,

    }
}
