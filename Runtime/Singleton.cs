using UnityEngine;

namespace TwiiK.Utility {

    /// <summary>
    /// Inherit from this base class to create a singleton.
    /// </summary>
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

        /// <summary>
        /// Access singleton instance through this propriety.
        /// </summary>
        public static T Instance { get; private set; }

        public virtual void Awake() {
            if (Instance != this) {
                Instance = this as T;
            }
        }

        public virtual void OnDestroy() {
            if (Instance == this) {
                Instance = null;
            }
        }

        private void OnApplicationQuit() {
            if (Instance == this) {
                Instance = null;
            }
        }

    }

}
