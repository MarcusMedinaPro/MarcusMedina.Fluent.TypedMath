// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathSbyteExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

using MarcusMedinaPro.TypedMath.Core;

namespace MarcusMedinaPro.TypedMath.SbyteExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for sbyte
/// </summary>
public static class TypedMathSbyteExtension
{

    /// <summary>
    /// Adds byte to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, byte addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds char to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, char addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds decimal to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, decimal addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds double to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, double addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds float to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, float addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds int to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, int addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds long to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, long addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds sbyte to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, sbyte addend) => TypedMathCore.Add(x, addend);

    /// <summary>
    /// Adds short to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, short addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds uint to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, uint addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds ulong to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, ulong addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds ushort to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static sbyte Add(this sbyte x, ushort addend) => TypedMathCore.AddOther(x, addend);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, byte percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, char percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, decimal percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, double percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, float percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, int percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, long percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, sbyte percent) => TypedMathCore.AddPercent(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, short percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, uint percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, ulong percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Adds percentage to sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static sbyte AddPercent(this sbyte x, ushort percent) => TypedMathCore.AddPercentOther(x, percent);

    /// <summary>
    /// Returns sbyte if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, byte other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, char other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, decimal other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, double other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, float other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, int other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, long other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, sbyte other) => TypedMathCore.ChooseIfHigher(x, other);

    /// <summary>
    /// Returns sbyte if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, short other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, uint other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, ulong other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static sbyte ChooseIfHigher(this sbyte x, ushort other) => TypedMathCore.ChooseIfHigherOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, byte other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, char other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, decimal other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, double other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, float other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, int other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, long other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, sbyte other) => TypedMathCore.ChooseIfLower(x, other);

    /// <summary>
    /// Returns sbyte if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, short other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, uint other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, ulong other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Returns sbyte if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static sbyte ChooseIfLower(this sbyte x, ushort other) => TypedMathCore.ChooseIfLowerOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, byte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, char other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, decimal other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, double other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, float other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, int other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, long other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, sbyte other) => TypedMathCore.DifferenceFrom(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, short other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, uint other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, ulong other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static sbyte DiferenceFrom(this sbyte x, ushort other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, byte other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, char other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, decimal other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, double other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, float other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, int other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, long other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, sbyte other) => TypedMathCore.DifferenceFrom(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, short other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, uint other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, ulong other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Gets absolute difference between sbyte and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static sbyte DifferenceFrom(this sbyte x, ushort other) => TypedMathCore.DifferenceFromOther(x, other);

    /// <summary>
    /// Divides sbyte by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, byte divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, char divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, decimal divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, double divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, float divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, int divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, long divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, sbyte divisor) => TypedMathCore.DividedBy(x, divisor);

    /// <summary>
    /// Divides sbyte by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, short divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, uint divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, ulong divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Divides sbyte by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static sbyte DividedBy(this sbyte x, ushort divisor) => TypedMathCore.DividedByOther(x, divisor);

    /// <summary>
    /// Checks if sbyte is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, byte other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, char other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, decimal other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, double other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, float other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, int other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, long other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, sbyte other) => TypedMathCore.GreaterThan(x, other);

    /// <summary>
    /// Checks if sbyte is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, short other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, uint other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, ulong other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this sbyte x, ushort other) => TypedMathCore.GreaterThanOther(x, other);

    /// <summary>
    /// Checks if sbyte equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, byte other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, char other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, decimal other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, double other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, float other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, int other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, long other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, sbyte other) => TypedMathCore.IsEqualTo(x, other);

    /// <summary>
    /// Checks if sbyte equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, short other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, uint other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, ulong other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this sbyte x, ushort other) => TypedMathCore.IsEqualToOther(x, other);

    /// <summary>
    /// Gets boolean true if sbyte is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this sbyte x) => TypedMathCore.IsNegative(x);

    /// <summary>
    /// Checks if sbyte does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, byte other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, char other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, decimal other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, double other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, float other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, int other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, long other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, sbyte other) => TypedMathCore.IsNotEqualTo(x, other);

    /// <summary>
    /// Checks if sbyte does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, short other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, uint other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, ulong other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Checks if sbyte does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this sbyte x, ushort other) => TypedMathCore.IsNotEqualToOther(x, other);

    /// <summary>
    /// Gets boolean true if sbyte is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this sbyte x) => TypedMathCore.IsPositive(x);

    /// <summary>
    /// Checks if sbyte is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, byte other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, char other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, decimal other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, double other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, float other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, int other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, long other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, sbyte other) => TypedMathCore.LessThan(x, other);

    /// <summary>
    /// Checks if sbyte is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, short other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, uint other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, ulong other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Checks if sbyte is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this sbyte x, ushort other) => TypedMathCore.LessThanOther(x, other);

    /// <summary>
    /// Gets remainder of sbyte divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, byte divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, char divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, decimal divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, double divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, float divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, int divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, long divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, sbyte divisor) => TypedMathCore.Modulus(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, short divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, uint divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, ulong divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Gets remainder of sbyte divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static sbyte Modulus(this sbyte x, ushort divisor) => TypedMathCore.ModulusOther(x, divisor);

    /// <summary>
    /// Multiplies sbyte with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, byte multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, char multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, decimal multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, double multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, float multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, int multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, long multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, sbyte multiplier) => TypedMathCore.MultipliedWith(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, short multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, uint multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, ulong multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Multiplies sbyte with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static sbyte MultipliedWith(this sbyte x, ushort multiplier) => TypedMathCore.MultipliedWithOther(x, multiplier);

    /// <summary>
    /// Calculates sbyte percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, byte number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, char number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, decimal number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, double number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, float number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, int number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, long number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, sbyte number) => TypedMathCore.PercentOf(x, number);

    /// <summary>
    /// Calculates sbyte percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, short number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, uint number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, ulong number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Calculates sbyte percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static sbyte PercentOf(this sbyte x, ushort number) => TypedMathCore.PercentOfOther(x, number);

    /// <summary>
    /// Subtracts byte from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, byte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts char from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, char subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts decimal from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, decimal subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts double from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, double subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts float from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, float subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts int from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, int subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts long from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, long subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts sbyte from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, sbyte subtrahend) => TypedMathCore.Subtract(x, subtrahend);

    /// <summary>
    /// Subtracts short from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, short subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts uint from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, uint subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ulong from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, ulong subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ushort from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static sbyte Substract(this sbyte x, ushort subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, byte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, char percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, decimal percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, double percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, float percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, int percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, long percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, sbyte percent) => TypedMathCore.SubtractPercent(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, short percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, uint percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, ulong percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static sbyte SubstractPercent(this sbyte x, ushort percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts byte from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, byte subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts char from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, char subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts decimal from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, decimal subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts double from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, double subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts float from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, float subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts int from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, int subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts long from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, long subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts sbyte from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, sbyte subtrahend) => TypedMathCore.Subtract(x, subtrahend);

    /// <summary>
    /// Subtracts short from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, short subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts uint from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, uint subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ulong from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, ulong subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts ushort from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static sbyte Subtract(this sbyte x, ushort subtrahend) => TypedMathCore.SubtractOther(x, subtrahend);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, byte percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, char percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, decimal percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, double percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, float percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, int percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, long percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, sbyte percent) => TypedMathCore.SubtractPercent(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, short percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, uint percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, ulong percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Subtracts percentage from sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static sbyte SubtractPercent(this sbyte x, ushort percent) => TypedMathCore.SubtractPercentOther(x, percent);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static sbyte[] DecreaseAllValuesWith(this sbyte[] array, sbyte dec) => TypedMathCore.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this sbyte[] array) => TypedMathCore.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static sbyte[] GetFirstHalf(this sbyte[] array) => TypedMathCore.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static sbyte GetFirstValue(this sbyte[] array) => TypedMathCore.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static sbyte GetHighestValue(this sbyte[] array) => TypedMathCore.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static sbyte[] GetLastHalf(this sbyte[] array) => TypedMathCore.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static sbyte GetLastValue(this sbyte[] array) => TypedMathCore.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static sbyte GetLowestValue(this sbyte[] array) => TypedMathCore.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static sbyte[] GetMiddle(this sbyte[] array) => TypedMathCore.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static sbyte GetMiddleValue(this sbyte[] array) => TypedMathCore.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static sbyte[] GetValuesHigherThan(this sbyte[] array, sbyte x) => TypedMathCore.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static sbyte[] GetValuesLowerThan(this sbyte[] array, sbyte x) => TypedMathCore.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static sbyte[] IncreaseAllValuesWith(this sbyte[] array, sbyte add) => TypedMathCore.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static sbyte[] RotateLeft(this sbyte[] array) => TypedMathCore.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static sbyte[] RotateRight(this sbyte[] array) => TypedMathCore.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static sbyte[] SetNewArraySize(this sbyte[] array, int size) => TypedMathCore.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static sbyte[] SortArrayAsc(this sbyte[] array) => TypedMathCore.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static sbyte[] SortArrayDesc(this sbyte[] array) => TypedMathCore.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.SbyteCollections.TypedMathSbyteCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static sbyte SumAllValues(this sbyte[] array) => TypedMathCore.SumAllValues(array);
}
