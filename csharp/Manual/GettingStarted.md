# Getting Started with TypedMath

Get up and running with type-safe mathematics in 5 minutes.

---

## Installation

```bash
dotnet add package MarcusMedina.Fluent.TypedMath
```

**Requirements:**
- .NET 10.0 or later
- C# 14.0 or later

---

## Your First Calculation

### Step 1: Add Using Statements

```csharp
using MarcusMedina.Fluent.TypedMath;
using MarcusMedina.Fluent.TypedMath.Builders;
```

### Step 2: Create a Typed Number

```csharp
// Create a distance of 5 meters
var distance = new Meters(5);
```

### Step 3: Perform Type-Safe Operations

```csharp
// Multiply by a scalar
var doubleDistance = distance.Multiply(2);  // 10 meters

// Calculate area (meters * meters = square meters)
var length = new Meters(5);
var width = new Meters(3);
var area = length.Multiply(width);  // 15 square meters
```

---

## Basic Operations

```csharp
// Addition (same types)
var distance1 = new Meters(5);
var distance2 = new Meters(3);
var total = distance1.Add(distance2);  // 8 meters

// Multiplication
var meters = new Meters(4);
var multiplied = meters.Multiply(2);  // 8 meters

// Division
var speed = new Meters(100).Divide(new Seconds(5));  // 20 m/s

// Type checking at compile time
var meters = new Meters(5);
var seconds = new Seconds(2);
// var wrong = meters.Add(seconds);  // ❌ Compile error!
```

---

## Type Safety Benefits

✅ **Prevent unit mismatch errors**
```csharp
// This won't compile - preventing runtime bugs
var distance = new Meters(5);
var time = new Seconds(10);
// var result = distance + time;  // ❌ Compile error!
```

✅ **Self-documenting code**
```csharp
// Clear what units are being used
var height = new Meters(1.8);
var width = new Centimeters(50);
var area = height.Multiply(width);  // Clear the calculation
```

✅ **Automatic conversions**
```csharp
var meters = new Meters(1000);
var kilometers = meters.ToKilometers();  // 1 km
```

---

## Common Patterns

### Pattern 1: Basic Calculation
```csharp
var distance = new Meters(100);
var time = new Seconds(10);
var speed = distance.Divide(time);  // m/s
```

### Pattern 2: Unit Conversion
```csharp
var miles = new Miles(1);
var kilometers = miles.ToKilometers();  // ~1.609 km
```

### Pattern 3: Complex Formulas
```csharp
// E = mc²
var mass = new Kilograms(1);
var c = new MetersPerSecond(299792458);
var energy = mass.Multiply(c.Multiply(c));
```

---

## Quick Reference

```csharp
// Create values
new Meters(5)
new Seconds(10)
new Kilograms(2)

// Operations
value.Add(other)
value.Subtract(other)
value.Multiply(scalar)
value.Divide(scalar)

// Conversions
meters.ToKilometers()
seconds.ToMinutes()
kilograms.ToGrams()

// Derived units
distance.Divide(time)  // speed
mass.Multiply(acceleration)  // force
```

---

**Next:** See [Examples](./Examples/) for more practical usage!
