using MarcusMedina.Fluent.TypedMath;

// Physics calculations using TypedMath
// Demonstrates type-safe scientific computations

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable emoji support

Console.WriteLine("=== Physics Calculator ===\n");

// Example 1: Motion calculations
Console.WriteLine("--- Motion Calculations ---");
var distance = new Meters(100);
var time = new Seconds(10);
var speed = distance.Divide(time.Value);
Console.WriteLine($"Distance: {distance}");
Console.WriteLine($"Time: {time}");
Console.WriteLine($"Speed: ~{speed} m/s\n");

// Example 2: Force calculations (F = ma)
Console.WriteLine("--- Force Calculation (F = ma) ---");
var mass = new Kilograms(2);
var acceleration = 9.8;  // m/s²
var force = mass.Multiply(acceleration);
Console.WriteLine($"Mass: {mass}");
Console.WriteLine($"Acceleration: {acceleration} m/s²");
Console.WriteLine($"Force: {force} N\n");

// Example 3: Temperature conversions
Console.WriteLine("--- Temperature Conversions ---");
var fahrenheit = new Fahrenheit(98.6);
var celsius = fahrenheit.ToCelsius();
var kelvin = celsius.ToKelvin();
Console.WriteLine($"Fahrenheit: {fahrenheit}");
Console.WriteLine($"Celsius: {celsius}");
Console.WriteLine($"Kelvin: {kelvin}\n");

// Example 4: Projectile motion
Console.WriteLine("--- Projectile Motion ---");
var initialVelocity = new MetersPerSecond(20);
var angle = Math.PI / 4;  // 45 degrees
var horizontalVelocity = initialVelocity.Multiply(Math.Cos(angle));
var verticalVelocity = initialVelocity.Multiply(Math.Sin(angle));
Console.WriteLine($"Initial velocity: {initialVelocity}");
Console.WriteLine($"Angle: 45°");
Console.WriteLine($"Horizontal velocity: ~{horizontalVelocity} m/s");
Console.WriteLine($"Vertical velocity: ~{verticalVelocity} m/s\n");

// Example 5: Unit conversions
Console.WriteLine("--- Unit Conversions ---");
var speedMph = new MilesPerHour(60);
var speedKmh = speedMph.ToKilometersPerHour();
Console.WriteLine($"Speed: {speedMph}");
Console.WriteLine($"In km/h: {speedKmh}\n");

Console.WriteLine("✓ All calculations completed successfully!");
