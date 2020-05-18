# Shone.Math
# A generic-types math library for .NET Framework 4.0 and .NET Core 3.1/5.0

Create a dotnet generic math type is never easy. 
This libray wrappers all math methods from Math,MathF,Convert and number classes into one generic Math\<T\> class.
With the Math\<T\> class from Shone.Math, you can write .NET generic math codes EASILY and HAPPILY!

# 0. Support all system number types in generic:

    bool, sbyte, byte, short, ushort, char, int, uint, long, ulong, float, double, decimal

# 1. Very easy to use:

    using Shone;                       // import Shone namespace

    var d = Math\<double\>.Pow(5,3);     // use just like Math.Pow, but it is generic now!


# 2. Support all the system methods by delegates:

    var func = Math\<double\>.Pow;    // it is a Func<double,double,double>


# 3. Support dot method extension:

    var d = 5d.Pow(3);     // write in dot style


# 4. Include generic array extension:

    var ds = new double[]{5d, 6d, 7d}.Pow(3);      // calculate array easily
