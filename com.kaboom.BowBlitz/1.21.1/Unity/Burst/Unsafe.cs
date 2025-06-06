class <Module>
{
}

namespace Unity
{
    namespace Burst
    {
        class Unsafe
        {
            static T Read<T>(void* source);
            static T ReadUnaligned<T>(void* source);
            static T ReadUnaligned<T>(ref byte source);
            static void Write<T>(void* destination, T value);
            static void WriteUnaligned<T>(void* destination, T value);
            static void WriteUnaligned<T>(ref byte destination, T value);
            static void Copy<T>(void* destination, ref T source);
            static void Copy<T>(ref T destination, void* source);
            static void* AsPointer<T>(ref T value);
            static int SizeOf<T>();
            static /*0x2518da0*/ void CopyBlock(void* destination, void* source, uint byteCount);
            static /*0x2518da8*/ void CopyBlock(ref byte destination, ref byte source, uint byteCount);
            static /*0x2518db0*/ void CopyBlockUnaligned(void* destination, void* source, uint byteCount);
            static /*0x2518db8*/ void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount);
            static /*0x2518dc0*/ void InitBlock(void* startAddress, byte value, uint byteCount);
            static /*0x2518dc8*/ void InitBlock(ref byte startAddress, byte value, uint byteCount);
            static /*0x2518dd0*/ void InitBlockUnaligned(void* startAddress, byte value, uint byteCount);
            static /*0x2518dd8*/ void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount);
            static T As<T>(object o);
            static ref T AsRef<T>(void* source);
            static ref T AsRef<T>(ref T source);
            static ref TTo As<TFrom, TTo>(ref TFrom source);
            static ref T Unbox<T>(object box);
            static ref T Add<T>(ref T source, int elementOffset);
            static void* Add<T>(void* source, int elementOffset);
            static ref T Add<T>(ref T source, nint elementOffset);
            static ref T AddByteOffset<T>(ref T source, nint byteOffset);
            static ref T Subtract<T>(ref T source, int elementOffset);
            static void* Subtract<T>(void* source, int elementOffset);
            static ref T Subtract<T>(ref T source, nint elementOffset);
            static ref T SubtractByteOffset<T>(ref T source, nint byteOffset);
            static nint ByteOffset<T>(ref T origin, ref T target);
            static bool AreSame<T>(ref T left, ref T right);
            static bool IsAddressGreaterThan<T>(ref T left, ref T right);
            static bool IsAddressLessThan<T>(ref T left, ref T right);
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x2518de0*/ NonVersionableAttribute();
            }
        }

        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x2518de8*/ IsReadOnlyAttribute();
            }
        }
    }
}
