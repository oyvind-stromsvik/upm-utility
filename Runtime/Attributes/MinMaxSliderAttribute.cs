﻿//=========== Copyright (c) GameBuilders, All rights reserved. ================//

using System;
using UnityEngine;

namespace TwiiK.Utility {

    [AttributeUsage(AttributeTargets.Field)]
    public class MinMaxSliderAttribute : PropertyAttribute {
        public readonly float MinLimit;
        public readonly float MaxLimit;
        public readonly string Tooltip;
        public readonly string Format;

        public MinMaxSliderAttribute(float min = 0, float max = 1, string tooltip = "", string format = "F1") {
            MinLimit = min;
            MaxLimit = max;
            Tooltip = tooltip;
            Format = format;
        }
    }

}
