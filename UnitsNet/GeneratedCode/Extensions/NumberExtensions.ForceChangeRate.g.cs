﻿// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions
{
    public static partial class NumberExtensions
    {
        #region CentinewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double)"/>
        public static ForceChangeRate CentinewtonsPerSecond(this int value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? CentinewtonsPerSecond(this int? value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double)"/>
        public static ForceChangeRate CentinewtonsPerSecond(this long value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? CentinewtonsPerSecond(this long? value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double)"/>
        public static ForceChangeRate CentinewtonsPerSecond(this double value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? CentinewtonsPerSecond(this double? value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double)"/>
        public static ForceChangeRate CentinewtonsPerSecond(this float value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? CentinewtonsPerSecond(this float? value) => ForceChangeRate.FromCentinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double)"/>
        public static ForceChangeRate CentinewtonsPerSecond(this decimal value) => ForceChangeRate.FromCentinewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromCentinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? CentinewtonsPerSecond(this decimal? value) => ForceChangeRate.FromCentinewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecinewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double)"/>
        public static ForceChangeRate DecinewtonsPerSecond(this int value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? DecinewtonsPerSecond(this int? value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double)"/>
        public static ForceChangeRate DecinewtonsPerSecond(this long value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? DecinewtonsPerSecond(this long? value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double)"/>
        public static ForceChangeRate DecinewtonsPerSecond(this double value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? DecinewtonsPerSecond(this double? value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double)"/>
        public static ForceChangeRate DecinewtonsPerSecond(this float value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? DecinewtonsPerSecond(this float? value) => ForceChangeRate.FromDecinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double)"/>
        public static ForceChangeRate DecinewtonsPerSecond(this decimal value) => ForceChangeRate.FromDecinewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromDecinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? DecinewtonsPerSecond(this decimal? value) => ForceChangeRate.FromDecinewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double)"/>
        public static ForceChangeRate KilonewtonsPerSecond(this int value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? KilonewtonsPerSecond(this int? value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double)"/>
        public static ForceChangeRate KilonewtonsPerSecond(this long value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? KilonewtonsPerSecond(this long? value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double)"/>
        public static ForceChangeRate KilonewtonsPerSecond(this double value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? KilonewtonsPerSecond(this double? value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double)"/>
        public static ForceChangeRate KilonewtonsPerSecond(this float value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? KilonewtonsPerSecond(this float? value) => ForceChangeRate.FromKilonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double)"/>
        public static ForceChangeRate KilonewtonsPerSecond(this decimal value) => ForceChangeRate.FromKilonewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromKilonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? KilonewtonsPerSecond(this decimal? value) => ForceChangeRate.FromKilonewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicronewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double)"/>
        public static ForceChangeRate MicronewtonsPerSecond(this int value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MicronewtonsPerSecond(this int? value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double)"/>
        public static ForceChangeRate MicronewtonsPerSecond(this long value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MicronewtonsPerSecond(this long? value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double)"/>
        public static ForceChangeRate MicronewtonsPerSecond(this double value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MicronewtonsPerSecond(this double? value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double)"/>
        public static ForceChangeRate MicronewtonsPerSecond(this float value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MicronewtonsPerSecond(this float? value) => ForceChangeRate.FromMicronewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double)"/>
        public static ForceChangeRate MicronewtonsPerSecond(this decimal value) => ForceChangeRate.FromMicronewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromMicronewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MicronewtonsPerSecond(this decimal? value) => ForceChangeRate.FromMicronewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillinewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double)"/>
        public static ForceChangeRate MillinewtonsPerSecond(this int value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MillinewtonsPerSecond(this int? value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double)"/>
        public static ForceChangeRate MillinewtonsPerSecond(this long value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MillinewtonsPerSecond(this long? value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double)"/>
        public static ForceChangeRate MillinewtonsPerSecond(this double value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MillinewtonsPerSecond(this double? value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double)"/>
        public static ForceChangeRate MillinewtonsPerSecond(this float value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MillinewtonsPerSecond(this float? value) => ForceChangeRate.FromMillinewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double)"/>
        public static ForceChangeRate MillinewtonsPerSecond(this decimal value) => ForceChangeRate.FromMillinewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromMillinewtonsPerSecond(double?)"/>
        public static ForceChangeRate? MillinewtonsPerSecond(this decimal? value) => ForceChangeRate.FromMillinewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanonewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double)"/>
        public static ForceChangeRate NanonewtonsPerSecond(this int value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NanonewtonsPerSecond(this int? value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double)"/>
        public static ForceChangeRate NanonewtonsPerSecond(this long value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NanonewtonsPerSecond(this long? value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double)"/>
        public static ForceChangeRate NanonewtonsPerSecond(this double value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NanonewtonsPerSecond(this double? value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double)"/>
        public static ForceChangeRate NanonewtonsPerSecond(this float value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NanonewtonsPerSecond(this float? value) => ForceChangeRate.FromNanonewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double)"/>
        public static ForceChangeRate NanonewtonsPerSecond(this decimal value) => ForceChangeRate.FromNanonewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromNanonewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NanonewtonsPerSecond(this decimal? value) => ForceChangeRate.FromNanonewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSecond

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double)"/>
        public static ForceChangeRate NewtonsPerSecond(this int value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NewtonsPerSecond(this int? value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double)"/>
        public static ForceChangeRate NewtonsPerSecond(this long value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NewtonsPerSecond(this long? value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double)"/>
        public static ForceChangeRate NewtonsPerSecond(this double value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NewtonsPerSecond(this double? value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double)"/>
        public static ForceChangeRate NewtonsPerSecond(this float value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NewtonsPerSecond(this float? value) => ForceChangeRate.FromNewtonsPerSecond(value);

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double)"/>
        public static ForceChangeRate NewtonsPerSecond(this decimal value) => ForceChangeRate.FromNewtonsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="ForceChangeRate.FromNewtonsPerSecond(double?)"/>
        public static ForceChangeRate? NewtonsPerSecond(this decimal? value) => ForceChangeRate.FromNewtonsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif