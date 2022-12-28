using UnityEditor;
using UnityEngine;

namespace TwiiK.Utility {

    /// <summary>
    /// Fix the default Quaternion inspector GUI.
    /// 
    /// For some reason Quaternions suddenly started displaying wrong in the inspector for me,
    /// ref. https://forum.unity.com/threads/quaternion-inspector-broken.1358618/
    ///
    /// This ensures they always display correctly. Can probably be removed at some point in the
    /// future?
    /// </summary>
    [CustomPropertyDrawer(typeof(Quaternion))]
    public class QuaternionPropertyDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.PropertyField(position, property, label);
        }
    }

}
