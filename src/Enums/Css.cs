using System;
using System.Collections.Generic;
using System.Text;

namespace StylerCode.Css
{
    public static class Css
    {
        /// <summary>
        /// center
        /// </summary>
        public const string Center = "center";
        /// <summary>
        /// start
        /// </summary>
        public const string Start = "start";    /* Pack items from the start */
        /// <summary>
        /// end
        /// </summary>
        public const string End = "end";    /* Pack items from the end */
        /// <summary>
        /// flex-start
        /// </summary>
        public const string Flex_Start = "flex-start"; /* Pack flex items from the start */
        /// <summary>
        /// flex-end
        /// </summary>
        public const string Flex_End = "flex-end";   /* Pack flex items from the end */

        /// <summary>
        /// normal
        /// </summary>
        public const string Normal = "normal"; /* Normal alignment */

        /* Baseline alignment */
        /// <summary>
        /// baseline
        /// </summary>
        public const string Baseline = "baseline";
        /// <summary>
        /// first baseline
        /// </summary>
        public const string FirstBaseline = "first baseline";
        /// <summary>
        /// last baseline
        /// </summary>
        public const string LastBaseline = "last baseline";

        /* Distributed alignment */
        /// <summary>
        /// space-between
        /// </summary>
        public const string Space_Between = "space-between"; /* Distribute items evenly
                                 The first item is flush with the start,
                                 the last is flush with the end */
        /// <summary>
        /// space-around
        /// </summary>
        public const string Space_Around = "space-around";  /* Distribute items evenly
                                 Items have a half-size space
                                 on either end */
        /// <summary>
        /// space-evenly
        /// </summary>
        public const string Space_Evenly = "space-evenly"; /* Distribute items evenly
                                 Items have equal space around them */
        /// <summary>
        /// stretch
        /// </summary>
        public const string Stretch = "stretch";      /* Distribute items evenly
                                 Stretch 'auto'-sized items to fit
                                 the container */

        /* Overflow alignment */
        /// <summary>
        /// safe center
        /// </summary>
        public const string SafeCenter = "safe center";
        /// <summary>
        /// unsafe center
        /// </summary>
        public const string UnsafeCenter = "unsafe center";

        /* Global values */
        /// <summary>
        /// inherit
        /// </summary>
        public const string Inherit = "inherit";
        /// <summary>
        /// initial
        /// </summary>
        public const string Initial = "initial";
        /// <summary>
        /// revert
        /// </summary>
        public const string Revert = "revert";
        /// <summary>
        /// unset
        /// </summary>
        public const string Unset = "unset";

        public const string Auto = "auto";

      
    }
}
