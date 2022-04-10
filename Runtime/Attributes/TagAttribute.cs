//=========== Copyright (c) GameBuilders, All rights reserved. ================//

using System;
using UnityEngine;

namespace TwiiK.Utility {

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class TagAttribute : PropertyAttribute {
        public bool AllowUntagged = false;
    }

}
