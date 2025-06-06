class <Module>
{
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class Unsafe
            {
                static T ReadUnaligned<T>(ref byte source);
                static void WriteUnaligned<T>(ref byte destination, T value);
                static ref TTo As<TFrom, TTo>(ref TFrom source);
                static ref T Add<T>(ref T source, int elementOffset);
                static ref T AddByteOffset<T>(ref T source, nint byteOffset);
            }
        }

        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x23d3e04*/ NonVersionableAttribute();
            }
        }
    }
}
