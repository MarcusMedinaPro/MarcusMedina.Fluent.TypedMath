# Use Case 1: Physics Calculator

**Problem Solved:** Perform type-safe physics calculations with automatic unit validation

This example demonstrates how TypedMath prevents unit mismatch errors in scientific calculations while keeping code clean and maintainable.

---

## The Problem

Physics calculations are error-prone:
- Easy to mix incompatible units
- Hard to track what units variables represent
- Unit errors can go undetected until runtime

**Example of unsafe code:**
```csharp
double distance = 100;  // Meters? Kilometers? Unclear!
double time = 10;       // Seconds? Hours? Who knows!
double speed = distance / time;  // Result could be nonsense
```

---

## The Solution

**TypedMath prevents these errors at compile time:**

```csharp
var distance = new Meters(100);
var time = new Seconds(10);
var speed = distance.Divide(time);  // Clear units throughout!

// This won't compile - preventing unit mismatch:
// var wrong = distance.Add(time);  // ❌ Compile error!
```

---

## How to Run

```bash
cd usecases/UseCase1.PhysicsCalculator
dotnet run
```

---

## Key Benefits

✅ **Type Safety** - Unit mismatches caught at compile time
✅ **Self-Documenting** - Code clearly shows which units are used
✅ **Correctness** - Calculations are mathematically sound
✅ **Maintenance** - Easy to understand and modify years later

---

## Real-World Applications

- **Engineering** - Structural calculations, stress analysis
- **Aerospace** - Navigation, trajectory calculations
- **Physics** - Laboratory calculations, simulations
- **Automotive** - Speed, distance, fuel consumption tracking

---

## Calculations in Example

1. **Motion** - Speed = Distance / Time
2. **Force** - F = ma (Mass × Acceleration)
3. **Temperature** - Celsius ↔ Fahrenheit ↔ Kelvin
4. **Projectile Motion** - Velocity components at angles
5. **Unit Conversions** - mph to km/h, etc.

---

## See Also

- [Getting Started Guide](../../csharp/Manual/GettingStarted.md)
- [API Reference](../../csharp/Manual/API.md)
- [Use Case 2: Unit Converter](../UseCase2.UnitConverter/)
- [Use Case 3: Engineering Solver](../UseCase3.EngineeringSolver/)
