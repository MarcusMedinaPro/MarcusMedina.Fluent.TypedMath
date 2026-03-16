# Advanced Topics

Master TypedMath with advanced techniques.

---

## Custom Types

### Creating Custom Units

```csharp
public class EnergyJoules : TypedNumber<EnergyJoules>
{
    public EnergyJoules(double value) : base(value) { }

    public EnergyPower ToPower(Seconds duration)
    {
        return new EnergyPower(Value / duration.Value);
    }
}
```

### Using Custom Types

```csharp
var energy = new EnergyJoules(1000);
var time = new Seconds(10);
var power = energy.ToPower(time);  // 100 Watts
```

---

## Derived Units

### Creating Derived Quantities

```csharp
// Speed = Distance / Time
var distance = new Meters(100);
var time = new Seconds(5);
var speed = distance.Divide(time);  // 20 m/s

// Acceleration = Speed / Time
var speedChange = new MetersPerSecond(20);
var timeElapsed = new Seconds(2);
var acceleration = speedChange.Divide(timeElapsed);  // 10 m/s²
```

---

## Performance Optimization

### Caching Converted Values

```csharp
// Cache conversions if used multiple times
var meters = new Meters(1000);
var kilometers = meters.ToKilometers();  // Convert once
var doubleKm = kilometers.Multiply(2);   // Use cached value
```

### Batch Operations

```csharp
// Group related calculations
var distances = new[] { new Meters(10), new Meters(20), new Meters(30) };
var total = distances.Aggregate((a, b) => a.Add(b));  // 60 meters
```

---

## Integration Patterns

### With LINQ

```csharp
var measurements = new[]
{
    new Meters(10),
    new Meters(20),
    new Meters(30)
};

var average = measurements
    .Aggregate((a, b) => a.Add(b))
    .Divide(measurements.Length);
```

### With Collections

```csharp
var readings = new List<Meters>
{
    new Meters(100),
    new Meters(102),
    new Meters(98)
};

var total = readings.Aggregate((a, b) => a.Add(b));
```

---

## Best Practices

✅ **Do**
- Use typed values to prevent unit errors
- Cache frequently converted values
- Use meaningful variable names with units
- Document expected unit inputs/outputs

❌ **Don't**
- Mix unit types without explicit conversion
- Assume unit conversions are automatic
- Store raw doubles without type information
- Ignore precision in financial calculations

---

## Common Patterns

### Physics Calculations

```csharp
// F = ma (Force = Mass × Acceleration)
var mass = new Kilograms(2);
var acceleration = new MetersPerSecond2(9.8);
var force = mass.Multiply(acceleration);  // Newtons

// E = mc² (Einstein's equation)
var mass2 = new Kilograms(1);
var c = new MetersPerSecond(299792458);
var energy = mass2.Multiply(c.Multiply(c).Value);
```

### Unit Conversions

```csharp
// Imperial to Metric
var miles = new Miles(10);
var kilometers = miles.ToKilometers();

// Temperature conversion
var fahrenheit = new Fahrenheit(32);
var celsius = fahrenheit.ToCelsius();
```

---

**Last Updated:** 2025-03-16 | **Version:** 0.2.0
