# Shone.Math .NET library
## An elementary math library supporting generic Math\<T\> and Rational/Irrational number in .NET 4/5
    
Create a dotnet generic math type is never easy. 

This libray wrappers all math methods from Math,MathF,DecimalMath(from NumSharp),Convert and all the system numeric classes into ONE generic Math\<T\> class.

With the Math\<T\> class from Shone.Math, you can write .NET generic math codes EASILY and HAPPILY!

### 1. Support all system number types in generic:
``` csharp
    Math<T>        // T can be any of the following numeric types
    bool, sbyte, byte, short, ushort, char, int, uint, long, ulong, float, double, decimal     // system type
    Real, Ration, Irration(IrratE,Pi,Exp,Xp,Lg,Ln,Log,Pow,Sqt,Sqd)            // the new types added in Shone.Math
```

### 2. Very easy to use:
``` csharp
    using Shone;                       // import Shone namespace

    var d = Math<double>.Pow(5,3);     // use just like Math.Pow, but it is generic now!
```

### 3. Support all the system methods by delegates:
``` csharp
    var func = Math<double>.Pow;    // it is a Func<double,double,double>
```

### 4. Support dot method extension:
``` csharp
    var d = 5d.Pow(3);     // write in dot style
```

### 5. Include generic array extension:
``` csharp
    var ds = new double[]{5d, 6d, 7d}.Pow(3);      // calculate array easily
```
