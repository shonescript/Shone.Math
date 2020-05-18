# Shone.Math
A generic-types math library for .NET Standard 2.0

1. Very easy to use:

using Shone;                       // import Shone namespace

var d = Math\<double\>.Pow(5,3);     // use just like Math.Pow, but it is generic now!


2. Support all the system methods by delegates:

var func = Math\<double\>.Pow;    // it is a Func<double,double,double>


3. Support dot method extension:

var d = 5d.Pow(3);     // write in dot style


4. Include generic array extension:

var ds = new double[]{5d, 6d, 7d}.Pow(3);      // calculate array easily
