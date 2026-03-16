# Use Case 2: Unit Converter

**Problem Solved:** Convert between different measurement units safely and accurately

TypedMath provides built-in conversions for all common units while preventing accidental unit mismatches.

---

## The Problem

Unit conversions are tedious and error-prone:
- Easy to look up wrong conversion factors
- Hard to remember all conversion formulas
- Easy to apply conversions backwards

---

## The Solution

**TypedMath handles conversions automatically:**

```csharp
var meters = new Meters(1000);
var kilometers = meters.ToKilometers();  // 1 km
var miles = meters.ToMiles();             // ~0.621 mi
```

---

## How to Run

```bash
cd usecases/UseCase2.UnitConverter
dotnet run
```

---

## Supported Conversions

### Distance
- Meters ↔ Kilometers, Miles, Feet, Centimeters, Inches

### Time
- Seconds ↔ Minutes, Hours, Days

### Mass
- Kilograms ↔ Grams, Pounds, Ounces

### Speed
- m/s ↔ km/h, mph

### Temperature
- Celsius ↔ Fahrenheit ↔ Kelvin

---

## Real-World Applications

- **Travel** - Convert mph to km/h
- **Cooking** - Convert Fahrenheit to Celsius
- **Science** - Convert between metric and imperial
- **Engineering** - Multi-unit calculations
- **Sports** - Performance metrics conversion

---

## Benefits

✅ **Accurate** - Verified conversion factors
✅ **Type-Safe** - No unit mismatch possible
✅ **Easy** - Clear, intuitive syntax
✅ **Comprehensive** - All common units supported

---

## See Also

- [Getting Started Guide](../../csharp/Manual/GettingStarted.md)
- [Use Case 1: Physics Calculator](../UseCase1.PhysicsCalculator/)
- [Use Case 3: Engineering Solver](../UseCase3.EngineeringSolver/)
