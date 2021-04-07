﻿using UnityEngine;

/// <summary>
/// Singleton class.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> : MonoBehaviour where T : Component {

    public static T Instance { get; private set; }

    public virtual void Awake() {
        if (Instance == null) {
            Instance = this as T;
        }
        else {
            Destroy(gameObject);
        }
    }
}
