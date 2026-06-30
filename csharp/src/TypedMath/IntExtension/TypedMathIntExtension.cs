// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathIntExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

using MarcusMedinaPro.TypedMath.Core;

namespace MarcusMedinaPro.TypedMath.IntExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for int
/// </summary>
public static class TypedMathIntExtension
{

    /// <summary>
    /// Adds byte to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, byte addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds char to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, char addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds decimal to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, decimal addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds double to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, double addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds float to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, float addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds int to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, int addend) => TypedMathCore.Add(x, addend);

    /// <summary>
    /// Adds long to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, long addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds sbyte to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, sbyte addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds short to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, short addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds uint to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, uint addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds ulong to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, ulong addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds ushort to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, ushort addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, byte percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, char percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, decimal percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, double percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, float percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, int percent) => TypedMathCore.AddPercent(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, long percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, sbyte percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, short percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, uint percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, ulong percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, ushort percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Returns int if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, byte other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, char other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, decimal other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, double other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, float other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, int other) => TypedMathCore.ChooseIfHigher(x, other);

    /// <summary>
    /// Returns int if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, long other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, sbyte other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, short other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, uint other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, ulong other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, ushort other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns int if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, byte other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, char other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, decimal other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, double other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, float other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, int other) => TypedMathCore.ChooseIfLower(x, other);

    /// <summary>
    /// Returns int if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, long other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, sbyte other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, short other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, uint other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, ulong other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns int if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, ushort other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, byte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, char other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, decimal other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, double other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, float other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, int other) => TypedMathCore.DifferenceFrom(x, other);

    /// <summary>
    /// Gets absolute difference between int and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, long other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, sbyte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, short other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, uint other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, ulong other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, ushort other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, byte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, char other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, decimal other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, double other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, float other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, int other) => TypedMathCore.DifferenceFrom(x, other);

    /// <summary>
    /// Gets absolute difference between int and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, long other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, sbyte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, short other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, uint other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, ulong other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between int and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, ushort other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Divides int by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, byte divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, char divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, decimal divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, double divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, float divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, int divisor) => TypedMathCore.DividedBy(x, divisor);

    /// <summary>
    /// Divides int by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, long divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, sbyte divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, short divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, uint divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, ulong divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides int by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, ushort divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Checks if int is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, byte other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, char other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, decimal other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, double other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, float other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, int other) => TypedMathCore.GreaterThan(x, other);

    /// <summary>
    /// Checks if int is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, long other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, sbyte other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, short other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, uint other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, ulong other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, ushort other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if int equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, byte other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, char other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, decimal other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, double other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, float other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, int other) => TypedMathCore.IsEqualTo(x, other);

    /// <summary>
    /// Checks if int equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, long other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, sbyte other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, short other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, uint other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, ulong other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if int equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, ushort other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Gets boolean true if int is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this int x) => TypedMathCore.IsNegative(x);

    /// <summary>
    /// Checks if int does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, byte other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, char other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, decimal other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, double other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, float other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, int other) => TypedMathCore.IsNotEqualTo(x, other);

    /// <summary>
    /// Checks if int does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, long other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, sbyte other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, short other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, uint other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, ulong other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if int does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, ushort other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Gets boolean true if int is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this int x) => TypedMathCore.IsPositive(x);

    /// <summary>
    /// Checks if int is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, byte other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, char other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, decimal other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, double other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, float other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, int other) => TypedMathCore.LessThan(x, other);

    /// <summary>
    /// Checks if int is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, long other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, sbyte other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, short other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, uint other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, ulong other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if int is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, ushort other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Gets remainder of int divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, byte divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, char divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, decimal divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, double divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, float divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, int divisor) => TypedMathCore.Modulus(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, long divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, sbyte divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, short divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, uint divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, ulong divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of int divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, ushort divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Multiplies int with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, byte multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, char multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, decimal multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, double multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, float multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, int multiplier) => TypedMathCore.MultipliedWith(x, multiplier);

    /// <summary>
    /// Multiplies int with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, long multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, sbyte multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, short multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, uint multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, ulong multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies int with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, ushort multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Calculates int percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, byte number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, char number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, decimal number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, double number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, float number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, int number) => TypedMathCore.PercentOf(x, number);

    /// <summary>
    /// Calculates int percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, long number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, sbyte number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, short number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, uint number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, ulong number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates int percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, ushort number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Subtracts byte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, byte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts char from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, char subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts decimal from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, decimal subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts double from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, double subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts float from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, float subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts int from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, int subtrahend) => TypedMathCore.Subtract(x, subtrahend);

    /// <summary>
    /// Subtracts long from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, long subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts sbyte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, sbyte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts short from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, short subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts uint from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, uint subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ulong from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, ulong subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ushort from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, ushort subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, byte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, char percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, decimal percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, double percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, float percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, int percent) => TypedMathCore.SubtractPercent(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, long percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, sbyte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, short percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, uint percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, ulong percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, ushort percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts byte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, byte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts char from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, char subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts decimal from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, decimal subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts double from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, double subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts float from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, float subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts int from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, int subtrahend) => TypedMathCore.Subtract(x, subtrahend);

    /// <summary>
    /// Subtracts long from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, long subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts sbyte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, sbyte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts short from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, short subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts uint from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, uint subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ulong from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, ulong subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ushort from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, ushort subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, byte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, char percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, decimal percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, double percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, float percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, int percent) => TypedMathCore.SubtractPercent(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, long percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, sbyte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, short percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, uint percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, ulong percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, ushort percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static int[] DecreaseAllValuesWith(this int[] array, int dec) => TypedMathCore.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this int[] array) => TypedMathCore.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static int[] GetFirstHalf(this int[] array) => TypedMathCore.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static int GetFirstValue(this int[] array) => TypedMathCore.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static int GetHighestValue(this int[] array) => TypedMathCore.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static int[] GetLastHalf(this int[] array) => TypedMathCore.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static int GetLastValue(this int[] array) => TypedMathCore.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static int GetLowestValue(this int[] array) => TypedMathCore.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static int[] GetMiddle(this int[] array) => TypedMathCore.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static int GetMiddleValue(this int[] array) => TypedMathCore.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static int[] GetValuesHigherThan(this int[] array, int x) => TypedMathCore.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static int[] GetValuesLowerThan(this int[] array, int x) => TypedMathCore.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static int[] IncreaseAllValuesWith(this int[] array, int add) => TypedMathCore.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static int[] RotateLeft(this int[] array) => TypedMathCore.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static int[] RotateRight(this int[] array) => TypedMathCore.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static int[] SetNewArraySize(this int[] array, int size) => TypedMathCore.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static int[] SortArrayAsc(this int[] array) => TypedMathCore.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static int[] SortArrayDesc(this int[] array) => TypedMathCore.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static int SumAllValues(this int[] array) => TypedMathCore.SumAllValues(array);
}
