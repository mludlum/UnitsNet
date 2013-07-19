// Copyright � 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/SIUnits
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

namespace UnitsNet
{
//    /// <summary>
//    /// Enumeration for all the SI units implemented.
//    /// This is used for converting between values in the same unit domain such as distance, electricity etc.
//    /// </summary>
//    public static class SiUnits
//    {
//        public const double Gravity = 9.80665;

//        /// <summary>
//        /// Returns a SiUnit based on the string representation for that unit.
//        /// Example: Parse("kg"); or Parse("Kilogram");
//        /// </summary>
//        /// <param name="unitText"></param>
//        /// <returns></returns>
//        public static SiUnit Parse(string unitText)
//        {
//            const StringComparison ignoreCase = StringComparison.OrdinalIgnoreCase;

//            if (String.IsNullOrEmpty(unitText)) 
//                throw new ArgumentException("Invalid unit description. Should for instance be kg or Kilogram to represent SiUnit.Kilogram type.");

//            // Iterate over all the unit types and look for matching names or abbreviations
//            foreach (SiUnit unitType in Enum.GetValues(typeof(SiUnit)))
//                if (unitText.Equals(GetAbbreviation(unitType), ignoreCase) ||
//                    unitText.Equals(GetName(unitType), ignoreCase))
//                    return unitType;

//            return SiUnit.Undefined;
//        }

//        /// <summary>
//        /// Returns the abbreviation string for this unit type, such as "kg" for kilogram.
//        /// </summary>
//        /// <param name="d"></param>
//        /// <returns></returns>
//        public static string GetAbbreviation(SiUnit d)
//        {
//            try
//            {
//                return StringEnum.GetStringValue(d);
//            }
//            catch (Exception e)
//            {
//                throw new Exception(string.Format("Could not get unit string for unit [{0}]", d), e);
//            }
//        }

//        /// <summary>
//        /// Returns the enumeration name of the unit type.
//        /// </summary>
//        /// <param name="d"></param>
//        /// <returns></returns>
//        public static string GetName(SiUnit d)
//        {
//            return d.ToString();
//        }

//        /// <summary>
//        /// A method for easier converting a metric distance value to meters.
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="fromUnit"></param>
//        /// <returns></returns>
//        public static double ToMeter(double value, SiUnit fromUnit)
//        {
//            const SiUnit toUnit = SiUnit.Meter;

////            if (!IsCompatible(fromUnit, toUnit))
////                throw new ArgumentException(String.Format("Can't convert from unit domain {0} to {1}.", fromUnit, toUnit), "fromUnit");

//            switch (fromUnit)
//            {
//                case toUnit:
//                    return value;

//                case SiUnit.Centimeter:
//                    return value/100.0;

//                case SiUnit.Millimeter:
//                    return value/1000;

//                default:
//                    throw new ArgumentException(String.Format("Conversion between {0} and {1} is not implemented", GetName(fromUnit), GetName(toUnit)));
//            }
//        }


//        /// <summary>
//        /// A method for easier converting a metric distance value to meters.
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="fromUnit"></param>
//        /// <returns></returns>
//        public static double ToCentimeter(double value, SiUnit fromUnit)
//        {
//            const SiUnit toUnit = SiUnit.Centimeter;

////            if (!IsCompatible(fromUnit, toUnit))
////                throw new ArgumentException(String.Format("Can't convert from unit domain {0} to {1}.", fromUnit, toUnit), "fromUnit");

//            switch (fromUnit)
//            {
//                case toUnit:
//                    return value;

//                case SiUnit.Meter:
//                    return value * 100.0;

//                case SiUnit.Millimeter:
//                    return value / 10;

//                default:
//                    throw new ArgumentException(String.Format("Conversion between {0} and {1} is not implemented", GetName(fromUnit), GetName(toUnit)));
//            }
//        }


//        /// <summary>
//        /// A method for easier converting a metric distance value to meters.
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="fromUnit"></param>
//        /// <returns></returns>
//        public static double ToMillimeter(double value, SiUnit fromUnit)
//        {
//            const SiUnit toUnit = SiUnit.Millimeter;

////            if (!IsCompatible(fromUnit, toUnit))
////                throw new ArgumentException(String.Format("Can't convert from unit domain {0} to {1}.", fromUnit, toUnit), "fromUnit");

//            switch (fromUnit)
//            {
//                case toUnit:
//                    return value;

//                case SiUnit.Meter:
//                    return value * 1000.0;

//                case SiUnit.Centimeter:
//                    return value * 10;

//                default:
//                    throw new ArgumentException(String.Format("Conversion between {0} and {1} is not implemented", GetName(fromUnit), GetName(toUnit)));
//            }
//        }

//        /// <summary>
//        /// Returns whether the two unit types are in the same unit domain, in other words if they can be
//        /// converted between.
//        /// Kilograms and Meters are for instance not compatible, while Meters and Centimeters are.
//        /// </summary>
//        /// <param name="unitA"></param>
//        /// <param name="unitB"></param>
//        /// <returns></returns>
//        public static bool IsCompatible(SiUnit unitA, SiUnit unitB)
//        {
//            // Force and mass are compatible because they are tied together by the gravitational constant 
//            // when considering vertical force. Not a good design but it works.
//            return (IsForce(unitA) && IsForce(unitB) ||
//                    IsForce(unitA) && IsMass(unitB) ||
//                    IsDistance(unitA) && IsDistance(unitB) ||
//                    IsMass(unitA) && IsMass(unitB) ||
//                    IsMass(unitA) && IsForce(unitB) ||
//                    IsVoltage(unitA) && IsVoltage(unitB) ||
//                    IsTorque(unitA) && IsTorque(unitB));
//        }

//        private static bool IsTorque(SiUnit type)
//        {
//            return (type == SiUnit.Newtonmeter);
//        }

//        private static bool IsVoltage(SiUnit type)
//        {
//            return (type == SiUnit.Volt);
//        }


//        /// <summary>
//        /// A general method for converting a value in a given metric unit domain to the respective value in a compatible unit domain,
//        /// such as converting from milimeters to meters.
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="fromUnit"></param>
//        /// <param name="toUnit"></param>
//        /// <returns></returns>
//        public static double ToUnit(double value, SiUnit fromUnit, SiUnit toUnit)
//        {
//            if (fromUnit == toUnit)
//                return value;

//            // Earlier reflection was used here for more elegant code, but reflections is dead slow 
//            // and the switch is not too much to maintain since the unit types don't change too often.
//            // An exception is thrown if a new unit is added but not implemented and this method is called with the 
//            // new type as argument.
//            switch (toUnit)
//            {
//                case SiUnit.KiloNewton:
//                    return ToKiloNewton(value, fromUnit);

//                case SiUnit.Kilogram:
//                    return ToKilogram(value, fromUnit);

//                case SiUnit.Newton:
//                    return ToNewton(value, fromUnit);

//                case SiUnit.Meter:
//                    return ToMeter(value, fromUnit);

//                case SiUnit.Centimeter:
//                    return ToCentimeter(value, fromUnit);

//                case SiUnit.Millimeter:
//                    return ToMillimeter(value, fromUnit);

//                case SiUnit.Volt:
//                    return ToVolt(value, fromUnit);

//                case SiUnit.Newtonmeter:
//                    return ToNewtonmeter(value, fromUnit);

//                case SiUnit.Undefined:
//                case SiUnit.Error:
//                case SiUnit.Generic:
//                    throw new Exception("Can't convert to generic and undefined units.");

//                default:
//                    throw new ArgumentException("Could not find conversion method for " + GetName(toUnit) + ", it may not be implemented yet.");
//            }
//        }

//        public static double ToNewtonmeter(double value, SiUnit fromUnit)
//        {
//            const SiUnit toUnit = SiUnit.Newtonmeter;

////            if (!IsCompatible(fromUnit, toUnit))
////                throw new ArgumentException(String.Format("Can't convert from unit domain {0} to {1}.", fromUnit, toUnit), "fromUnit");

//            switch (fromUnit)
//            {
//                case toUnit:
//                    return value;

//                default:
//                    throw new ArgumentException(String.Format("Conversion between {0} and {1} is not implemented", GetName(fromUnit), GetName(toUnit)));
//            }
//        }


//        public static double ToKilogram(double value, SiUnit fromUnit)
//        {
//            const SiUnit toUnit = SiUnit.Kilogram;

////            if (!IsCompatible(fromUnit, toUnit))
////                throw new ArgumentException(String.Format("Can't convert from unit domain {0} to {1}.", fromUnit, toUnit), "fromUnit");

//            switch (fromUnit)
//            {
//                case toUnit:
//                    return value;

//                case SiUnit.Newton:
//                    return value / Gravity;

//                case SiUnit.KiloNewton:
//                    return ToKilogram(ToNewton(value, fromUnit), SiUnit.Newton);

//                default:
//                    throw new ArgumentException(String.Format("Conversion between {0} and {1} is not implemented", GetName(fromUnit), GetName(toUnit)));
//            }
//        }


//        public static double ToVolt(double value, SiUnit fromUnit)
//        {
//            const SiUnit toUnit = SiUnit.Volt;

////            if (!IsCompatible(fromUnit, toUnit))
////                throw new ArgumentException(String.Format("Can't convert from unit domain {0} to {1}.", fromUnit, toUnit), "fromUnit");

//            switch (fromUnit)
//            {
//                case toUnit:
//                    return value;

//                default:
//                    throw new ArgumentException(String.Format("Conversion between {0} and {1} is not implemented", GetName(fromUnit), GetName(toUnit)));
//            }
//        }


//        public static double ToNewton(double value, SiUnit oldUnit)
//        {
//            switch (oldUnit)
//            {
//                case SiUnit.Generic:
//                    throw new Exception("Can't convert from a generic unit, there are no reference values to convert from");

//                case SiUnit.Kilogram:
//                    return value * Gravity;

//                case SiUnit.Newton:
//                    return value; // Already in newtons

//                case SiUnit.KiloNewton:
//                    return value * 1000;

//                default:
//                    throw new Exception("The unit you are trying to convert from [" + GetName(oldUnit) +
//                                        "], has not been implemented.");
//            }
//        }

//        /// <summary>
//        /// Do not delete this. It is used via reflection by the ToUnit() method.
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="oldUnit"></param>
//        /// <returns></returns>
//        // ReSharper disable UnusedPrivateMember
//        private static double ToKiloNewton(double value, SiUnit oldUnit)
//            // ReSharper restore UnusedPrivateMember
//        {
//            switch (oldUnit)
//            {
//                case SiUnit.Generic:
//                    throw new Exception("Can't convert from a generic unit, there are no reference values to convert from");

//                case SiUnit.Kilogram:
//                    return ToKilogram(ToNewton(value, oldUnit), SiUnit.Newton);

//                case SiUnit.Newton:
//                    return value / 1000.0;

//                case SiUnit.KiloNewton:
//                    return value; // Already in kilonewtons

//                default:
//                    throw new Exception("The unit you are trying to convert from [" + GetName(oldUnit) +
//                                        "], has not been implemented.");
//            }
//        }


//        public static bool IsMass(SiUnit type)
//        {
//            return (type == SiUnit.Kilogram);
//        }

//        public static bool IsForce(SiUnit u)
//        {
//            switch (u)
//            {
//                case SiUnit.Newton:
//                case SiUnit.KiloNewton:
//                    return true;
//            }

//            return false;
//        }


//        public static bool IsDistance(SiUnit u)
//        {
//            switch (u)
//            {
//                case SiUnit.Meter:
//                case SiUnit.Centimeter:
//                case SiUnit.Millimeter:
//                    return true;
//            }

//            return false;
//        }
//    }
}