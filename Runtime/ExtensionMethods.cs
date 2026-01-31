using UnityEngine;

namespace TwiiK.Utility {

    public static class ExtensionMethods {

        /// <summary>
        /// Reset a transform the same way you can in the inspector, ie. zero local position, rotation and scale.
        /// </summary>
        /// <param name="transform"></param>
        public static void Reset(this Transform transform) {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = new Vector3(1, 1, 1);
        }

        /// <summary>
        /// Remaps a value from a current minimum a1 and maximum a2 to a new minimum b1 and maximum b2.
        ///
        /// Let's say you have a value going from 5 to 20 and you want it to go from 0 to 1 so you can use the value in
        /// a slider or whatnot, or the reverse of that. This method handles such use cases for you.
        /// </summary>
        /// <param name="value">The value to remap.</param>
        /// <param name="a1">The current minimum</param>
        /// <param name="a2">The current maximum</param>
        /// <param name="b1">The new minimum</param>
        /// <param name="b2">The new maximum</param>
        /// <returns></returns>
        public static float Remap(this float value, float a1, float a2, float b1, float b2) {
            return b1 + (value - a1) * (b2 - b1) / (a2 - a1);
        }
        
        /// <summary>
        /// Returns a random value between the x and y components of a Vector2.
        /// </summary>
        /// <param name="vector2"></param>
        public static float Random(this Vector2 vector2) {
            return UnityEngine.Random.Range(vector2.x, vector2.y);
        }

    }

}
