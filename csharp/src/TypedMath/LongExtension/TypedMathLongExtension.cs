// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathLongExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

using MarcusMedinaPro.TypedMath.Core;

namespace MarcusMedinaPro.TypedMath.LongExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for long
/// </summary>
public static class TypedMathLongExtension
{

    /// <summary>
    /// Adds byte to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, byte addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds char to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, char addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds decimal to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, decimal addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds double to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, double addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds float to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, float addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds int to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, int addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds long to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, long addend) => TypedMathCore.Add(x, addend);

    /// <summary>
    /// Adds sbyte to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, sbyte addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds short to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, short addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds uint to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, uint addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds ulong to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, ulong addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds ushort to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, ushort addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, byte percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, char percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, decimal percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, double percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, float percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, int percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, long percent) => TypedMathCore.AddPercent(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, sbyte percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, short percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, uint percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, ulong percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, ushort percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Returns long if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, byte other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, char other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, decimal other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, double other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, float other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, int other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, long other) => TypedMathCore.ChooseIfHigher(x, other);

    /// <summary>
    /// Returns long if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, sbyte other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, short other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, uint other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, ulong other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, ushort other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns long if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, byte other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, char other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, decimal other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, double other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, float other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, int other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, long other) => TypedMathCore.ChooseIfLower(x, other);

    /// <summary>
    /// Returns long if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, sbyte other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, short other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, uint other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, ulong other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns long if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, ushort other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, byte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, char other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, decimal other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, double other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, float other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, int other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, long other) => TypedMathCore.DifferenceFrom(x, other);

    /// <summary>
    /// Gets absolute difference between long and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, sbyte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, short other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, uint other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, ulong other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, ushort other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, byte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, char other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, decimal other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, double other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, float other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, int other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, long other) => TypedMathCore.DifferenceFrom(x, other);

    /// <summary>
    /// Gets absolute difference between long and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, sbyte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, short other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, uint other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, ulong other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between long and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, ushort other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Divides long by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, byte divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, char divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, decimal divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, double divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, float divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, int divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, long divisor) => TypedMathCore.DividedBy(x, divisor);

    /// <summary>
    /// Divides long by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, sbyte divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, short divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, uint divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, ulong divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides long by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, ushort divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Checks if long is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, byte other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, char other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, decimal other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, double other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, float other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, int other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, long other) => TypedMathCore.GreaterThan(x, other);

    /// <summary>
    /// Checks if long is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, sbyte other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, short other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, uint other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, ulong other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, ushort other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if long equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, byte other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, char other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, decimal other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, double other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, float other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, int other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, long other) => TypedMathCore.IsEqualTo(x, other);

    /// <summary>
    /// Checks if long equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, sbyte other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, short other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, uint other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, ulong other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if long equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, ushort other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Gets boolean true if long is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this long x) => TypedMathCore.IsNegative(x);

    /// <summary>
    /// Checks if long does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, byte other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, char other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, decimal other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, double other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, float other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, int other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, long other) => TypedMathCore.IsNotEqualTo(x, other);

    /// <summary>
    /// Checks if long does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, sbyte other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, short other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, uint other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, ulong other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if long does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, ushort other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Gets boolean true if long is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this long x) => TypedMathCore.IsPositive(x);

    /// <summary>
    /// Checks if long is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, byte other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, char other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, decimal other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, double other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, float other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, int other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, long other) => TypedMathCore.LessThan(x, other);

    /// <summary>
    /// Checks if long is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, sbyte other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, short other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, uint other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, ulong other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if long is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, ushort other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Gets remainder of long divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, byte divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, char divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, decimal divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, double divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, float divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, int divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, long divisor) => TypedMathCore.Modulus(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, sbyte divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, short divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, uint divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, ulong divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of long divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, ushort divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Multiplies long with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, byte multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, char multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, decimal multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, double multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, float multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, int multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, long multiplier) => TypedMathCore.MultipliedWith(x, multiplier);

    /// <summary>
    /// Multiplies long with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, sbyte multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, short multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, uint multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, ulong multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies long with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, ushort multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Calculates long percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, byte number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, char number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, decimal number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, double number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, float number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, int number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, long number) => TypedMathCore.PercentOf(x, number);

    /// <summary>
    /// Calculates long percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, sbyte number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, short number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, uint number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, ulong number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates long percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, ushort number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Subtracts byte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, byte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts char from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, char subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts decimal from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, decimal subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts double from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, double subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts float from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, float subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts int from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, int subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts long from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, long subtrahend) => TypedMathCore.Subtract(x, subtrahend);

    /// <summary>
    /// Subtracts sbyte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, sbyte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts short from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, short subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts uint from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, uint subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ulong from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, ulong subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ushort from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, ushort subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, byte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, char percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, decimal percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, double percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, float percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, int percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, long percent) => TypedMathCore.SubtractPercent(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, sbyte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, short percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, uint percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, ulong percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, ushort percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts byte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, byte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts char from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, char subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts decimal from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, decimal subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts double from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, double subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts float from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, float subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts int from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, int subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts long from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, long subtrahend) => TypedMathCore.Subtract(x, subtrahend);

    /// <summary>
    /// Subtracts sbyte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, sbyte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts short from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, short subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts uint from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, uint subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ulong from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, ulong subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ushort from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, ushort subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, byte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, char percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, decimal percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, double percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, float percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, int percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, long percent) => TypedMathCore.SubtractPercent(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, sbyte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, short percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, uint percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, ulong percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, ushort percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static long[] DecreaseAllValuesWith(this long[] array, long dec) => TypedMathCore.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this long[] array) => TypedMathCore.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static long[] GetFirstHalf(this long[] array) => TypedMathCore.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static long GetFirstValue(this long[] array) => TypedMathCore.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static long GetHighestValue(this long[] array) => TypedMathCore.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static long[] GetLastHalf(this long[] array) => TypedMathCore.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static long GetLastValue(this long[] array) => TypedMathCore.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static long GetLowestValue(this long[] array) => TypedMathCore.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static long[] GetMiddle(this long[] array) => TypedMathCore.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static long GetMiddleValue(this long[] array) => TypedMathCore.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static long[] GetValuesHigherThan(this long[] array, long x) => TypedMathCore.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static long[] GetValuesLowerThan(this long[] array, long x) => TypedMathCore.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static long[] IncreaseAllValuesWith(this long[] array, long add) => TypedMathCore.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static long[] RotateLeft(this long[] array) => TypedMathCore.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static long[] RotateRight(this long[] array) => TypedMathCore.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static long[] SetNewArraySize(this long[] array, int size) => TypedMathCore.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static long[] SortArrayAsc(this long[] array) => TypedMathCore.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static long[] SortArrayDesc(this long[] array) => TypedMathCore.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static long SumAllValues(this long[] array) => TypedMathCore.SumAllValues(array);
}
