# TwiiK Utility

A utility package with a few helper classes and extension methods. Tiny at the moment, but I'll keep adding to it as I go.

## Features

### Singleton

A generic MonoBehaviour singleton base class.

```csharp
using TwiiK.Utility;

public class GameManager : Singleton<GameManager> {
    public override void Awake() {
        base.Awake();
        // Your initialization code
    }
}

// Access from anywhere
GameManager.Instance.DoSomething();
```

### Extension Methods

#### Transform.Reset()
Reset a transform the same way you can in the inspector, ie. zero local position, rotation and scale.

```csharp
transform.Reset();
```

#### float.Remap()
Remaps a value from one range to another.

```csharp
// Remap a value from range 5-20 to range 0-1
float normalized = myValue.Remap(5f, 20f, 0f, 1f);
```

#### Vector2.Random()
Returns a random value between the x and y components of a Vector2.

```csharp
Vector2 range = new Vector2(1f, 5f);
float randomValue = range.Random(); // Returns value between 1 and 5
```

## License

MIT
