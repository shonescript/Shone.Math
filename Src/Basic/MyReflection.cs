using System;
using System.Collections.Generic;
using System.Reflection;

namespace Shone
{
    public static class MyReflection
    {
        public static BindingFlags PublicStatic = BindingFlags.Public | BindingFlags.Static;

        public static Dictionary<string, string> MethodNameMaps = new Dictionary<string, string>{
        { "op_UnaryNegation", "Negate" },
        { "op_Increment", "Increase" },
        { "op_Decrement", "Decrease" },
        { "op_Complement", "Not" },
        { "op_OnesComplement", "Comp" },
        { "op_Addition", "Add" },
        { "op_Subtraction", "Subtract" },
        { "op_Multiply", "Multiply" },
        { "op_Division", "Divide" },
        { "op_Modulus", "Modulus" },
        { "op_And", "And" },
        { "op_Or", "Or" },
        { "op_BitwiseAnd", "BitAnd" },
        { "op_BitwiseOr", "BitOr" },
        { "op_ExclusiveOr", "BitXOr" },
        { "op_LeftShift", "LeftShift" },
        { "op_RightShif", "RightShift" },
        { "op_Equality", "Equal" },
        { "op_Inequality", "NotEqual" },
        { "op_LessThan", "LessThan" },
        { "op_GreaterThan", "GreatThan" },
        { "op_LessThanOrEqual", "LessEqual" },
        { "op_GreaterThanOrEqual", "GreatEqual" }};

        public static Dictionary<string, string> Op1NameMaps = new Dictionary<string, string>{
        { "Negate", "-" },
        { "Increment", "++" },
        { "Decrement", "--" },
        { "OnesComplement", "~" }};

        public static Dictionary<string, string> Op1bNameMaps = new Dictionary<string, string>{
        { "Complement", "!" }};

        public static Dictionary<string, string> Op2NameMaps = new Dictionary<string, string>{
        { "Add", "+" },
        { "Subtract", "-" },
        { "Multiply", "*" },
        { "Divide", "/" },
        { "Modulus", "%" },
        { "BitAnd", "&" },
        { "BitOr", "|" },
        { "BitXOr", "^" },
        { "LeftShift", "<<" },
        { "RightShif", ">>" }};

        public static Dictionary<string, string> Op2bNameMaps = new Dictionary<string, string>{
        { "And", "&&" },
        { "Or", "||" },
        { "Equal", "==" },
        { "NotEqual", "!=" },
        { "LessThan", "<" },
        { "GreatThan", ">" },
        { "LessEqual", "<=" },
        { "GreatEqual", ">=" }};
    }
}
