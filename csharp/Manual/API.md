# API Reference

Complete API documentation for TypedMath.

---

## Core Types

### Base Classes

All typed numbers inherit from a common base:

```csharp
public abstract class TypedNumber<T>
{
    public T Value { get; }

    public TypedNumber<T> Add(TypedNumber<T> other);
    public TypedNumber<T> Subtract(TypedNumber<T> other);
    public TypedNumber<T> Multiply(double scalar);
    public TypedNumber<T> Divide(double scalar);

    public string ToString();
}
```

---

## Common Units

### Distance
- `Meters`
- `Centimeters`
- `Kilometers`
- `Miles`
- `Feet`
- `Inches`

### Time
- `Seconds`
- `Minutes`
- `Hours`
- `Days`

### Mass
- `Kilograms`
- `Grams`
- `Pounds`
- `Ounces`

### Temperature
- `Celsius`
- `Fahrenheit`
- `Kelvin`

---

## Operations

### Arithmetic

```csharp
// Same-type operations
var distance1 = new Meters(5);
var distance2 = new Meters(3);
var sum = distance1.Add(distance2);  // Meters(8)

// Scalar operations
var distance = new Meters(10);
var doubled = distance.Multiply(2);  // Meters(20)
var halved = distance.Divide(2);     // Meters(5)
```

### Derived Quantities

```csharp
// Speed = Distance / Time
var distance = new Meters(100);
var time = new Seconds(10);
var speed = distance.Divide(time);   // m/s

// Force = Mass × Acceleration
var mass = new Kilograms(2);
var acceleration = new MetersPerSecond2(9.8);
var force = mass.Multiply(acceleration);  // Newtons
```

---

## Unit Conversions

```csharp
// Convert meters to kilometers
var meters = new Meters(1000);
var kilometers = meters.ToKilometers();  // 1

// Convert minutes to seconds
var minutes = new Minutes(5);
var seconds = minutes.ToSeconds();  // 300
```

---

## Error Handling

### Type Safety Prevents Errors

```csharp
// This won't compile - preventing unit mismatch
var distance = new Meters(5);
var time = new Seconds(10);
// var wrong = distance.Add(time);  // Compiler error!
```

### Invalid Operations

```csharp
try
{
    var distance = new Meters(-5);  // May throw validation error
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Invalid value: {ex.Message}");
}
```

---

## Formatting

```csharp
var distance = new Meters(5.5);
var formatted = distance.ToString();  // "5.5 m"

// Custom formatting
var label = $"Distance: {distance}";  // "Distance: 5.5 m"
```

---

## Performance Characteristics

| Operation | Complexity | Notes |
|-----------|-----------|-------|
| Creation | O(1) | Lightweight wrapper |
| Add/Subtract | O(1) | Direct arithmetic |
| Multiply | O(1) | Scalar multiplication |
| Divide | O(1) | Scalar division |
| Convert | O(1) | Conversion factor multiplication |

---

**Last Updated:** 2025-03-16 | **Version:** 0.2.0
