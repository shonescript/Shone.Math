using System;

//All rights reserved to Shone, author of Shone.Math (https://github.com/shonescript/Shone.Math).
namespace Shone
{
    /// <summary>
    /// Helper class replacing the System.Convert implimentation 
    /// </summary>
    public static class MyConvert
    {
        public static bool ToBool(bool d) => d;
        public static byte ToByte(bool d) => (byte)(d ? 1 : 0);
        public static sbyte ToSByte(bool d) => (sbyte)(d ? 1 : 0);
        public static short ToShort(bool d) => (short)(d ? 1 : 0);
        public static ushort ToUShort(bool d) => (ushort)(d ? 1 : 0);
        public static char ToChar(bool d) => (char)(d ? 1 : 0);
        public static int ToInt(bool d) => d ? 1 : 0;
        public static uint ToUInt(bool d) => d ? 1u : 0u;
        public static long ToLong(bool d) => d ? 1L : 0L;
        public static ulong ToULong(bool d) => d ? 1ul : 0ul;
        public static float ToFloat(bool d) => d ? 1f : 0f;
        public static double ToDouble(bool d) => d ? 1d : 0d;
        public static decimal ToDecimal(bool d) => d ? 1m : 0m;

        public static bool ToBool(byte d) => d != 0;
        public static byte ToByte(byte d) => d;
        public static sbyte ToSByte(byte d) => (sbyte)d;
        public static short ToShort(byte d) => d;
        public static ushort ToUShort(byte d) => d;
        public static char ToChar(byte d) => (char)d;
        public static int ToInt(byte d) => d;
        public static uint ToUInt(byte d) => d;
        public static long ToLong(byte d) => d;
        public static ulong ToULong(byte d) => d;
        public static float ToFloat(byte d) => d;
        public static double ToDouble(byte d) => d;

        public static bool ToBool(sbyte d) => d != 0;
        public static byte ToByte(sbyte d) => (byte)d;
        public static sbyte ToSByte(sbyte d) => d;
        public static short ToShort(sbyte d) => d;
        public static ushort ToUShort(sbyte d) => (ushort)d;
        public static char ToChar(sbyte d) => (char)d;
        public static int ToInt(sbyte d) => d;
        public static uint ToUInt(sbyte d) => (uint)d;
        public static long ToLong(sbyte d) => d;
        public static ulong ToULong(sbyte d) => (ulong)d;
        public static float ToFloat(sbyte d) => d;
        public static double ToDouble(sbyte d) => d;

        public static bool ToBool(char d) => d != 0;
        public static byte ToByte(char d) => (byte)d;
        public static sbyte ToSByte(char d) => (sbyte)d;
        public static short ToShort(char d) => (short)d;
        public static ushort ToUShort(char d) => d;
        public static char ToChar(char d) => d;
        public static int ToInt(char d) => d;
        public static uint ToUInt(char d) => d;
        public static long ToLong(char d) => d;
        public static ulong ToULong(char d) => d;
        public static float ToFloat(char d) => d;
        public static double ToDouble(char d) => d;

        public static bool ToBool(short d) => d != 0;
        public static byte ToByte(short d) => (byte)d;
        public static sbyte ToSByte(short d) => (sbyte)d;
        public static short ToShort(short d) => d;
        public static ushort ToUShort(short d) => (ushort)d;
        public static char ToChar(short d) => (char)d;
        public static int ToInt(short d) => d;
        public static uint ToUInt(short d) => (uint)d;
        public static long ToLong(short d) => d;
        public static ulong ToULong(short d) => (ulong)d;
        public static float ToFloat(short d) => d;
        public static double ToDouble(short d) => d;

        public static bool ToBool(ushort d) => d != 0;
        public static byte ToByte(ushort d) => (byte)d;
        public static sbyte ToSByte(ushort d) => (sbyte)d;
        public static short ToShort(ushort d) => (short)d;
        public static ushort ToUShort(ushort d) => d;
        public static char ToChar(ushort d) => (char)d;
        public static int ToInt(ushort d) => d;
        public static uint ToUInt(ushort d) => d;
        public static long ToLong(ushort d) => d;
        public static ulong ToULong(ushort d) => d;
        public static float ToFloat(ushort d) => d;
        public static double ToDouble(ushort d) => d;

        public static bool ToBool(int d) => d != 0;
        public static byte ToByte(int d) => (byte)d;
        public static sbyte ToSByte(int d) => (sbyte)d;
        public static short ToShort(int d) => (short)d;
        public static ushort ToUShort(int d) => (ushort)d;
        public static char ToChar(int d) => (char)d;
        public static int ToInt(int d) => d;
        public static uint ToUInt(int d) => (uint)d;
        public static long ToLong(int d) => d;
        public static ulong ToULong(int d) => (ulong)d;
        public static float ToFloat(int d) => d;
        public static double ToDouble(int d) => d;

        public static bool ToBool(uint d) => d != 0;
        public static byte ToByte(uint d) => (byte)d;
        public static sbyte ToSByte(uint d) => (sbyte)d;
        public static short ToShort(uint d) => (short)d;
        public static ushort ToUShort(uint d) => (ushort)d;
        public static char ToChar(uint d) => (char)d;
        public static int ToInt(uint d) => (int)d;
        public static uint ToUInt(uint d) => d;
        public static long ToLong(uint d) => d;
        public static ulong ToULong(uint d) => d;
        public static float ToFloat(uint d) => d;
        public static double ToDouble(uint d) => d;

        public static bool ToBool(long d) => d != 0;
        public static byte ToByte(long d) => (byte)d;
        public static sbyte ToSByte(long d) => (sbyte)d;
        public static short ToShort(long d) => (short)d;
        public static ushort ToUShort(long d) => (ushort)d;
        public static char ToChar(long d) => (char)d;
        public static int ToInt(long d) => (int)d;
        public static uint ToUInt(long d) => (uint)d;
        public static long ToLong(long d) => d;
        public static ulong ToULong(long d) => (ulong)d;
        public static float ToFloat(long d) => d;
        public static double ToDouble(long d) => d;

        public static bool ToBool(ulong d) => d != 0;
        public static byte ToByte(ulong d) => (byte)d;
        public static sbyte ToSByte(ulong d) => (sbyte)d;
        public static short ToShort(ulong d) => (short)d;
        public static ushort ToUShort(ulong d) => (ushort)d;
        public static char ToChar(ulong d) => (char)d;
        public static int ToInt(ulong d) => (int)d;
        public static uint ToUInt(ulong d) => (uint)d;
        public static long ToLong(ulong d) => (long)d;
        public static ulong ToULong(ulong d) => d;
        public static float ToFloat(ulong d) => d;
        public static double ToDouble(ulong d) => d;

        public static bool ToBool(float d) => d != 0;
        public static byte ToByte(float d) => (byte)d;
        public static sbyte ToSByte(float d) => (sbyte)d;
        public static short ToShort(float d) => (short)d;
        public static ushort ToUShort(float d) => (ushort)d;
        public static char ToChar(float d) => (char)d;
        public static int ToInt(float d) => (int)d;
        public static uint ToUInt(float d) => (uint)d;
        public static long ToLong(float d) => (long)d;
        public static ulong ToULong(float d) => (ulong)d;
        public static float ToFloat(float d) => d;
        public static double ToDouble(float d) => d;

        public static bool ToBool(double d) => d != 0;
        public static byte ToByte(double d) => (byte)d;
        public static sbyte ToSByte(double d) => (sbyte)d;
        public static short ToShort(double d) => (short)d;
        public static ushort ToUShort(double d) => (ushort)d;
        public static char ToChar(double d) => (char)d;
        public static int ToInt(double d) => (int)d;
        public static uint ToUInt(double d) => (uint)d;
        public static long ToLong(double d) => (long)d;
        public static ulong ToULong(double d) => (ulong)d;
        public static float ToFloat(double d) => (float)d;
        public static double ToDouble(double d) => d;

        public static bool ToBool(decimal d) => d != 0;
        public static decimal ToDecimal(decimal d) => d;

        public static Real ToReal(Real r) => r;
    }
}