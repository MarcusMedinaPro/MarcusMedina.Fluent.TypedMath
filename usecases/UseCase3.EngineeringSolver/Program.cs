using MarcusMedina.Fluent.TypedMath;

// Engineering problem solver using TypedMath

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable emoji support

Console.WriteLine("=== Engineering Problem Solver ===\n");

// Problem 1: Material strength
Console.WriteLine("--- Problem 1: Stress Calculation ---");
Console.WriteLine("A steel beam supports a load.");
var loadForce = new Newtons(10000);
var beamArea = new SquareMillimeters(100);  // 100 mm²
var stress = loadForce.Divide(beamArea.Value);
Console.WriteLine($"Load: {loadForce}");
Console.WriteLine($"Beam cross-section: {beamArea}");
Console.WriteLine($"Stress: ~{stress:F2} MPa\n");

// Problem 2: Thermal expansion
Console.WriteLine("--- Problem 2: Thermal Expansion ---");
var originalLength = new Meters(10);
var temperatureChange = 50;  // °C
var expansionCoefficient = 0.000011;  // per °C for steel
var lengthChange = new Meters(originalLength.Value * temperatureChange * expansionCoefficient);
var newLength = originalLength.Add(lengthChange);
Console.WriteLine($"Original length: {originalLength}");
Console.WriteLine($"Temperature change: {temperatureChange}°C");
Console.WriteLine($"Length increase: {lengthChange}");
Console.WriteLine($"New length: {newLength}\n");

// Problem 3: Power transmission
Console.WriteLine("--- Problem 3: Power Transmission ---");
var voltage = 230;  // Volts
var current = 10;   // Amperes
var power = voltage * current;  // Watts
Console.WriteLine($"Voltage: {voltage} V");
Console.WriteLine($"Current: {current} A");
Console.WriteLine($"Power: {power} W ({power / 1000.0} kW)\n");

// Problem 4: Fluid flow
Console.WriteLine("--- Problem 4: Fluid Flow Rate ---");
var pipeArea = 0.005;  // m²
var flowVelocity = new MetersPerSecond(2);
var flowRate = pipeArea * flowVelocity.Value;  // m³/s
Console.WriteLine($"Pipe area: {pipeArea} m²");
Console.WriteLine($"Flow velocity: {flowVelocity}");
Console.WriteLine($"Flow rate: {flowRate} m³/s ({flowRate * 1000} liters/s)\n");

// Problem 5: Energy calculation
Console.WriteLine("--- Problem 5: Kinetic Energy ---");
var mass = new Kilograms(1000);
var velocity = new MetersPerSecond(20);
var kineticEnergy = 0.5 * mass.Value * velocity.Value * velocity.Value;
Console.WriteLine($"Mass: {mass}");
Console.WriteLine($"Velocity: {velocity}");
Console.WriteLine($"Kinetic Energy: {kineticEnergy} Joules\n");

Console.WriteLine("✓ All engineering problems solved!");
