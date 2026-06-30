// <copyright file="TypedMathCore.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro
// </copyright>
namespace MarcusMedinaPro.TypedMath.Core;
using System.Linq;
using System.Numerics;

/// <summary>
/// Internal generic core. JIT specializes per value type — zero overhead vs explicit typed methods.
/// </summary>
internal static class TypedMathCore
{
    internal static T Add<T>(T x, T addend) where T : INumber<T> => x + addend;
    internal static T Subtract<T>(T x, T subtrahend) where T : INumber<T> => x - subtrahend;
    internal static T MultipliedWith<T>(T x, T multiplier) where T : INumber<T> => x * multiplier;
    internal static T DividedBy<T>(T x, T divisor) where T : INumber<T> => x / divisor;
    internal static T Modulus<T>(T x, T divisor) where T : INumber<T> => x % divisor;
    internal static T ChooseIfHigher<T>(T x, T other) where T : INumber<T> => x > other ? x : other;
    internal static T ChooseIfLower<T>(T x, T other) where T : INumber<T> => x < other ? x : other;
    internal static T DifferenceFrom<T>(T x, T other) where T : INumber<T>
        => x > other ? x - other : other > x ? other - x : T.Zero;
    internal static bool GreaterThan<T>(T x, T other) where T : INumber<T> => x > other;
    internal static bool LessThan<T>(T x, T other) where T : INumber<T> => x < other;
    internal static bool IsEqualTo<T>(T x, T other) where T : INumber<T> => x == other;
    internal static bool IsNotEqualTo<T>(T x, T other) where T : INumber<T> => x != other;
    internal static bool IsPositive<T>(T x) where T : INumber<T> => T.IsPositive(x);
    internal static bool IsNegative<T>(T x) where T : INumber<T> => T.IsNegative(x);
    internal static T AddPercent<T>(T x, T percent) where T : INumber<T>
        => x + (x * percent / T.CreateChecked(100));
    internal static T SubtractPercent<T>(T x, T percent) where T : INumber<T>
        => x - (x * percent / T.CreateChecked(100));
    internal static T PercentOf<T>(T x, T total) where T : INumber<T>
        => x / T.CreateChecked(100) * total;
    internal static bool IsEqualToFloat<T>(T x, T other, T epsilon) where T : IFloatingPoint<T>
        => T.Abs(x - other) < epsilon;
    internal static bool IsEqualToFloatOther<T, TOther>(T x, TOther other, T epsilon)
        where T : IFloatingPoint<T> where TOther : INumber<TOther>
        => T.Abs(x - T.CreateChecked(other)) < epsilon;
    internal static T AddOther<T, TOther>(T x, TOther addend)
        where T : INumber<T> where TOther : INumber<TOther> => x + T.CreateChecked(addend);
    internal static T SubtractOther<T, TOther>(T x, TOther subtrahend)
        where T : INumber<T> where TOther : INumber<TOther> => x - T.CreateChecked(subtrahend);
    internal static T MultipliedWithOther<T, TOther>(T x, TOther multiplier)
        where T : INumber<T> where TOther : INumber<TOther> => x * T.CreateChecked(multiplier);
    internal static T DividedByOther<T, TOther>(T x, TOther divisor)
        where T : INumber<T> where TOther : INumber<TOther> => x / T.CreateChecked(divisor);
    internal static T ModulusOther<T, TOther>(T x, TOther divisor)
        where T : INumber<T> where TOther : INumber<TOther> => x % T.CreateChecked(divisor);
    internal static T ChooseIfHigherOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther>
    { var c = T.CreateChecked(other); return x > c ? x : c; }
    internal static T ChooseIfLowerOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther>
    { var c = T.CreateChecked(other); return x < c ? x : c; }
    internal static T DifferenceFromOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther>
    { var c = T.CreateChecked(other); return x > c ? x - c : c > x ? c - x : T.Zero; }
    internal static bool GreaterThanOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther> => x > T.CreateChecked(other);
    internal static bool LessThanOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther> => x < T.CreateChecked(other);
    internal static bool IsEqualToOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther> => x == T.CreateChecked(other);
    internal static bool IsNotEqualToOther<T, TOther>(T x, TOther other)
        where T : INumber<T> where TOther : INumber<TOther> => x != T.CreateChecked(other);
    internal static T AddPercentOther<T, TOther>(T x, TOther percent)
        where T : INumber<T> where TOther : INumber<TOther>
        => x + (x * T.CreateChecked(percent) / T.CreateChecked(100));
    internal static T SubtractPercentOther<T, TOther>(T x, TOther percent)
        where T : INumber<T> where TOther : INumber<TOther>
        => x - (x * T.CreateChecked(percent) / T.CreateChecked(100));
    internal static T PercentOfOther<T, TOther>(T x, TOther total)
        where T : INumber<T> where TOther : INumber<TOther>
        => x / T.CreateChecked(100) * T.CreateChecked(total);
    internal static T[] IncreaseAllValuesWith<T>(T[] array, T value) where T : INumber<T>
        => [.. array.Select(x => x + value)];
    internal static T[] DecreaseAllValuesWith<T>(T[] array, T value) where T : INumber<T>
        => [.. array.Select(x => x - value)];
    internal static T SumAllValues<T>(T[] array) where T : INumber<T>
        => array.Aggregate(T.Zero, (acc, x) => acc + x);
    internal static double GetAverage<T>(T[] array) where T : INumber<T>
        => array.Select(x => double.CreateChecked(x)).Average();
    internal static T GetHighestValue<T>(T[] array) where T : INumber<T> => array.Max()!;
    internal static T GetLowestValue<T>(T[] array) where T : INumber<T> => array.Min()!;
    internal static T[] GetValuesHigherThan<T>(T[] array, T x) where T : INumber<T>
        => [.. array.Where(v => v > x)];
    internal static T[] GetValuesLowerThan<T>(T[] array, T x) where T : INumber<T>
        => [.. array.Where(v => v < x)];
    internal static T GetFirstValue<T>(T[] array) where T : INumber<T> => array[0];
    internal static T GetLastValue<T>(T[] array) where T : INumber<T> => array[^1];
    internal static T GetMiddleValue<T>(T[] array) where T : INumber<T> => array[array.Length / 2];
    internal static T[] GetFirstHalf<T>(T[] array) where T : INumber<T>
        => [.. array.Take(array.Length / 2)];
    internal static T[] GetLastHalf<T>(T[] array) where T : INumber<T>
        => [.. array.Skip(array.Length / 2)];
    internal static T[] GetMiddle<T>(T[] array) where T : INumber<T>
        => [.. array.Skip(array.Length / 4).Take(array.Length / 2)];
    internal static T[] SortArrayAsc<T>(T[] array) where T : INumber<T> => [.. array.Order()];
    internal static T[] SortArrayDesc<T>(T[] array) where T : INumber<T> => [.. array.OrderDescending()];
    internal static T[] RotateLeft<T>(T[] array) where T : INumber<T>
        => [.. array[1..], array[0]];
    internal static T[] RotateRight<T>(T[] array) where T : INumber<T>
        => [array[^1], .. array[..^1]];
    internal static T[] SetNewArraySize<T>(T[] array, int size) where T : INumber<T>
    {
        var result = new T[size];
        Array.Copy(array, result, Math.Min(array.Length, size));
        return result;
    }
}
