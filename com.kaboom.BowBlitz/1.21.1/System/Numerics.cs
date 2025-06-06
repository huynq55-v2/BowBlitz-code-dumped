class <Module>
{
}

namespace System
{
    namespace Numerics
    {
        struct BigInteger : System.IFormattable, System.IComparable, System.IComparable<System.Numerics.BigInteger>, System.IEquatable<System.Numerics.BigInteger>
        {
            static /*0x0*/ System.Numerics.BigInteger s_bnMinInt;
            static /*0x10*/ System.Numerics.BigInteger s_bnOneInt;
            static /*0x20*/ System.Numerics.BigInteger s_bnZeroInt;
            static /*0x30*/ System.Numerics.BigInteger s_bnMinusOneInt;
            static /*0x40*/ byte[] s_success;
            /*0x10*/ int _sign;
            /*0x18*/ uint[] _bits;

            static /*0x23ce0bc*/ BigInteger();
            static /*0x23cc710*/ System.Numerics.BigInteger get_MinusOne();
            static /*0x23cd1cc*/ System.Numerics.BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x23cd51c*/ System.Numerics.BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x23cd8d4*/ System.Numerics.BigInteger op_Implicit(byte value);
            static /*0x23cd8fc*/ System.Numerics.BigInteger op_Implicit(int value);
            static /*0x23cd318*/ System.Numerics.BigInteger op_Implicit(long value);
            static /*0x23cd924*/ int op_Explicit(System.Numerics.BigInteger value);
            static /*0x23cda00*/ System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, int shift);
            static /*0x23cdc4c*/ System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, int shift);
            static /*0x23ce010*/ System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x23cdf50*/ bool GetPartsForBitManipulation(ref System.Numerics.BigInteger x, ref uint[] xd, ref int xl);
            static /*0x23cc8f0*/ int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu);
            /*0x23cbd44*/ BigInteger(int value);
            /*0x23cbdc0*/ BigInteger(long value);
            /*0x23cbed8*/ BigInteger(byte[] value);
            /*0x23cbf78*/ BigInteger(System.ReadOnlySpan<byte> value, bool isUnsigned, bool isBigEndian);
            /*0x23cc560*/ BigInteger(int n, uint[] rgu);
            /*0x23cc56c*/ BigInteger(uint[] value, bool negative);
            /*0x23cc768*/ int GetHashCode();
            /*0x23cc7bc*/ bool Equals(object obj);
            /*0x23cc834*/ bool Equals(System.Numerics.BigInteger other);
            /*0x23cc958*/ int CompareTo(System.Numerics.BigInteger other);
            /*0x23cca80*/ int CompareTo(object obj);
            /*0x23ccb58*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x23cd084*/ bool TryWriteOrCountBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x23ccb98*/ byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten);
            /*0x23cd0b8*/ string ToString();
            /*0x23cd194*/ string ToString(string format, System.IFormatProvider provider);

            enum GetBytesMode
            {
                AllocateArray = 0,
                Count = 1,
                Span = 2,
            }
        }

        class BigIntegerCalculator
        {
            static /*0x0*/ int ReducerThreshold;
            static /*0x4*/ int SquareThreshold;
            static /*0x8*/ int AllocationThreshold;
            static /*0xc*/ int MultiplyThreshold;

            static /*0x23ce2fc*/ BigIntegerCalculator();
            static /*0x23cd34c*/ uint[] Add(uint[] left, uint right);
            static /*0x23cd424*/ uint[] Add(uint[] left, uint[] right);
            static /*0x23ce1fc*/ void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x23cd69c*/ uint[] Subtract(uint[] left, uint right);
            static /*0x23cd7d4*/ uint[] Subtract(uint[] left, uint[] right);
            static /*0x23ce284*/ void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x23cd754*/ int Compare(uint[] left, uint[] right);
        }

        class BigNumber
        {
            static /*0x23ce34c*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
            static /*0x23ce43c*/ string FormatBigIntegerToHex(bool targetSpan, System.Numerics.BigInteger value, char format, int digits, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);
            static /*0x23cd0e8*/ string FormatBigInteger(System.Numerics.BigInteger value, string format, System.Globalization.NumberFormatInfo info);
            static /*0x23cf024*/ string FormatBigInteger(bool targetSpan, System.Numerics.BigInteger value, string formatString, System.ReadOnlySpan<char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);
        }

        class NumericsHelpers
        {
            static /*0x23cc4a4*/ void DangerousMakeTwosComplement(uint[] d);
            static /*0x23cfa24*/ ulong MakeUlong(uint uHi, uint uLo);
            static /*0x23cd340*/ uint Abs(int a);
            static /*0x23cfb74*/ uint CombineHash(uint u1, uint u2);
            static /*0x23cc7b4*/ int CombineHash(int n1, int n2);
        }
    }

    namespace Globalization
    {
        class FormatProvider
        {
            static /*0x23cfa34*/ void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo numberFormatInfo, char[] digits, int startIndex);

            class Number
            {
                static /*0x0*/ string[] s_posCurrencyFormats;
                static /*0x8*/ string[] s_negCurrencyFormats;
                static /*0x10*/ string[] s_posPercentFormats;
                static /*0x18*/ string[] s_negPercentFormats;
                static /*0x20*/ string[] s_negNumberFormats;
                static /*0x28*/ string s_posNumberFormat;

                static /*0x23d2bd0*/ Number();
                static /*0x23d1284*/ void Int32ToDecChars(char* buffer, ref int index, uint value, int digits);
                static /*0x23cfb7c*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
                static /*0x23cfcbc*/ void NumberToString(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal);
                static /*0x23d13b4*/ void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x23d25d0*/ int wcslen(char* s);
                static /*0x23d1614*/ void FormatFixed(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup);
                static /*0x23d1b50*/ void FormatNumber(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x23d1d98*/ void FormatScientific(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar);
                static /*0x23d27ac*/ void FormatExponent(ref System.Text.ValueStringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign);
                static /*0x23d1fd4*/ void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific);
                static /*0x23d2370*/ void FormatPercent(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x23d12e0*/ void RoundNumber(ref System.Globalization.FormatProvider.Number.NumberBuffer number, int pos);
                static /*0x23d2a9c*/ int FindSection(System.ReadOnlySpan<char> format, int section);
                static /*0x23d0204*/ void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info);

                struct NumberBuffer
                {
                    /*0x10*/ int precision;
                    /*0x14*/ int scale;
                    /*0x18*/ bool sign;
                    /*0x20*/ char* overrideDigits;

                    /*0x23d3720*/ char* get_digits();
                }
            }
        }
    }

    namespace Text
    {
        struct ValueStringBuilder
        {
            /*0x10*/ char[] _arrayToReturnToPool;
            /*0x18*/ System.Span<char> _chars;
            /*0x28*/ int _pos;

            /*0x23cea20*/ ValueStringBuilder(System.Span<char> initialBuffer);
            /*0x23d3728*/ int get_Length();
            /*0x23cee8c*/ string ToString();
            /*0x23cec00*/ bool TryCopyTo(System.Span<char> destination, ref int charsWritten);
            /*0x23cea30*/ void Insert(int index, char value, int count);
            /*0x23d3974*/ void Append(char c);
            /*0x23d3a70*/ void Append(string s);
            /*0x23d3b1c*/ void AppendSlow(string s);
            /*0x23d26d0*/ void Append(char c, int count);
            /*0x23d25f0*/ void Append(char* value, int length);
            /*0x23d3c4c*/ System.Span<char> AppendSpan(int length);
            /*0x23d39f0*/ void GrowAndAppend(char c);
            /*0x23d3730*/ void Grow(int requiredAdditionalCapacity);
            /*0x23d3d0c*/ void Dispose();
        }
    }
}
