using MarcusMedina.Fluent.TypedMath;

// Unit conversion utility using TypedMath

Console.WriteLine("=== Comprehensive Unit Converter ===\n");

// Distance conversions
Console.WriteLine("--- Distance Conversions ---");
var meters = new Meters(1000);
var kilometers = meters.ToKilometers();
var miles = meters.ToMiles();
var feet = meters.ToFeet();
Console.WriteLine($"1000 meters = {kilometers} km = {miles} mi = {feet} ft\n");

// Time conversions
Console.WriteLine("--- Time Conversions ---");
var seconds = new Seconds(3600);
var minutes = seconds.ToMinutes();
var hours = minutes.ToHours();
Console.WriteLine($"3600 seconds = {minutes} min = {hours} hours\n");

// Mass conversions
Console.WriteLine("--- Mass Conversions ---");
var kilograms = new Kilograms(1);
var grams = kilograms.ToGrams();
var pounds = kilograms.ToPounds();
var ounces = pounds.ToOunces();
Console.WriteLine($"1 kilogram = {grams} g = {pounds} lbs = {ounces} oz\n");

// Speed conversions
Console.WriteLine("--- Speed Conversions ---");
var mps = new MetersPerSecond(30);
var kmh = mps.ToKilometersPerHour();
var mph = mps.ToMilesPerHour();
Console.WriteLine($"30 m/s = {kmh} km/h = {mph} mph\n");

// Temperature conversions
Console.WriteLine("--- Temperature Conversions ---");
var temps = new[]
{
    new Celsius(0),
    new Celsius(20),
    new Celsius(100)
};

foreach (var temp in temps)
{
    var f = temp.ToFahrenheit();
    var k = temp.ToKelvin();
    Console.WriteLine($"{temp} = {f} = {k}");
}

Console.WriteLine("\n✓ All conversions completed!");
