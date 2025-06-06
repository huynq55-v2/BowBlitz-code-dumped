class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x1e19808*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsByRefLikeAttribute : System.Attribute
            {
                /*0x1e19810*/ IsByRefLikeAttribute();
            }
        }
    }
}

namespace Google
{
    namespace Protobuf
    {
        class ByteArray
        {
            static int CopyThreshold = 12;

            static /*0x1e19818*/ void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            static /*0x1e19898*/ void Reverse(byte[] bytes);
        }

        class ByteString : System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable, System.IEquatable<Google.Protobuf.ByteString>
        {
            static /*0x0*/ Google.Protobuf.ByteString empty;
            /*0x10*/ System.ReadOnlyMemory<byte> bytes;

            static /*0x1e1af18*/ ByteString();
            static /*0x1e19910*/ Google.Protobuf.ByteString AttachBytes(System.ReadOnlyMemory<byte> bytes);
            static /*0x1e199ac*/ Google.Protobuf.ByteString AttachBytes(byte[] bytes);
            static /*0x1e19a50*/ Google.Protobuf.ByteString get_Empty();
            static /*0x1e19cb4*/ Google.Protobuf.ByteString FromBase64(string bytes);
            static /*0x1e19de4*/ Google.Protobuf.ByteString FromStream(System.IO.Stream stream);
            static /*0x1e19fb0*/ System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            static /*0x1e1a120*/ Google.Protobuf.ByteString CopyFrom(byte[] bytes);
            static /*0x1e1a1f0*/ Google.Protobuf.ByteString CopyFrom(byte[] bytes, int offset, int count);
            static /*0x1e1a2d0*/ Google.Protobuf.ByteString CopyFrom(System.ReadOnlySpan<byte> bytes);
            static /*0x1e1a388*/ Google.Protobuf.ByteString CopyFrom(string text, System.Text.Encoding encoding);
            static /*0x1e1a438*/ Google.Protobuf.ByteString CopyFromUtf8(string text);
            static /*0x1e1aa18*/ bool op_Equality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs);
            static /*0x1e1aba0*/ bool op_Inequality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs);
            /*0x1e19980*/ ByteString(System.ReadOnlyMemory<byte> bytes);
            /*0x1e19aa8*/ int get_Length();
            /*0x1e19af0*/ bool get_IsEmpty();
            /*0x1e19b08*/ System.ReadOnlySpan<byte> get_Span();
            /*0x1e19b50*/ System.ReadOnlyMemory<byte> get_Memory();
            /*0x1e19b5c*/ byte[] ToByteArray();
            /*0x1e19ba4*/ string ToBase64();
            /*0x1e1a4a0*/ byte get_Item(int index);
            /*0x1e1a508*/ string ToString(System.Text.Encoding encoding);
            /*0x1e1a608*/ string ToStringUtf8();
            /*0x1e1a628*/ System.Collections.Generic.IEnumerator<byte> GetEnumerator();
            /*0x1e1a6e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1e1a6ec*/ Google.Protobuf.CodedInputStream CreateCodedInput();
            /*0x1e1ac10*/ bool Equals(object obj);
            /*0x1e1ac90*/ int GetHashCode();
            /*0x1e1ad1c*/ bool Equals(Google.Protobuf.ByteString other);
            /*0x1e1ad80*/ void CopyTo(byte[] array, int position);
            /*0x1e1ae18*/ void WriteTo(System.IO.Stream outputStream);
        }

        class ByteStringAsync
        {
            static /*0x1e1a028*/ System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsyncCore(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);

            struct <FromStreamAsyncCore>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Google.Protobuf.ByteString> <>t__builder;
                /*0x30*/ System.IO.Stream stream;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.IO.MemoryStream <memoryStream>5__2;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                /*0x1e1afcc*/ void MoveNext();
                /*0x1e1b380*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class CodedInputStream : System.IDisposable
        {
            static int DefaultRecursionLimit = 100;
            static int DefaultSizeLimit = 2147483647;
            static int BufferSize = 4096;
            /*0x10*/ bool leaveOpen;
            /*0x18*/ byte[] buffer;
            /*0x20*/ System.IO.Stream input;
            /*0x28*/ Google.Protobuf.ParserInternalState state;

            static /*0x1e1b64c*/ Google.Protobuf.CodedInputStream CreateWithLimits(System.IO.Stream input, int sizeLimit, int recursionLimit);
            static /*0x1e1c840*/ uint ReadRawVarint32(System.IO.Stream input);
            /*0x1e1a988*/ CodedInputStream(byte[] buffer);
            /*0x1e1a830*/ CodedInputStream(byte[] buffer, int offset, int length);
            /*0x1e1b4b8*/ CodedInputStream(System.IO.Stream input);
            /*0x1e1b4c0*/ CodedInputStream(System.IO.Stream input, bool leaveOpen);
            /*0x1e1b3d8*/ CodedInputStream(System.IO.Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen);
            /*0x1e1b57c*/ CodedInputStream(System.IO.Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen);
            /*0x1e1b70c*/ long get_Position();
            /*0x1e1b750*/ uint get_LastTag();
            /*0x1e1b758*/ int get_SizeLimit();
            /*0x1e1b760*/ int get_RecursionLimit();
            /*0x1e1b768*/ bool get_DiscardUnknownFields();
            /*0x1e1b770*/ void set_DiscardUnknownFields(bool value);
            /*0x1e1b77c*/ Google.Protobuf.ExtensionRegistry get_ExtensionRegistry();
            /*0x1e1b784*/ void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value);
            /*0x1e1b78c*/ byte[] get_InternalBuffer();
            /*0x1e1b794*/ System.IO.Stream get_InternalInputStream();
            /*0x1e1b79c*/ ref Google.Protobuf.ParserInternalState get_InternalState();
            /*0x1e1b7a4*/ void Dispose();
            /*0x1e1b7d0*/ void CheckReadEndOfStreamTag();
            /*0x1e1b82c*/ uint PeekTag();
            /*0x1e1b8fc*/ uint ReadTag();
            /*0x1e1ba78*/ void SkipLastField();
            /*0x1e1bb14*/ void SkipGroup(uint startGroupTag);
            /*0x1e1bbb8*/ double ReadDouble();
            /*0x1e1bd54*/ float ReadFloat();
            /*0x1e1bedc*/ ulong ReadUInt64();
            /*0x1e1bf50*/ long ReadInt64();
            /*0x1e1bf54*/ int ReadInt32();
            /*0x1e1bfc8*/ ulong ReadFixed64();
            /*0x1e1c03c*/ uint ReadFixed32();
            /*0x1e1c0b0*/ bool ReadBool();
            /*0x1e1c0c8*/ string ReadString();
            /*0x1e1c14c*/ void ReadMessage(Google.Protobuf.IMessage builder);
            /*0x1e1c2dc*/ void ReadGroup(Google.Protobuf.IMessage builder);
            /*0x1e1c44c*/ Google.Protobuf.ByteString ReadBytes();
            /*0x1e1c518*/ uint ReadUInt32();
            /*0x1e1c51c*/ int ReadEnum();
            /*0x1e1c520*/ int ReadSFixed32();
            /*0x1e1c524*/ long ReadSFixed64();
            /*0x1e1c528*/ int ReadSInt32();
            /*0x1e1c554*/ long ReadSInt64();
            /*0x1e1c580*/ int ReadLength();
            /*0x1e1c5f0*/ bool MaybeConsumeTag(uint tag);
            /*0x1e1bf58*/ uint ReadRawVarint32();
            /*0x1e1bee0*/ ulong ReadRawVarint64();
            /*0x1e1c040*/ uint ReadRawLittleEndian32();
            /*0x1e1bfcc*/ ulong ReadRawLittleEndian64();
            /*0x1e1ccac*/ int PushLimit(int byteLimit);
            /*0x1e1ccb8*/ void PopLimit(int oldLimit);
            /*0x1e1ccc4*/ bool get_ReachedLimit();
            /*0x1e1ccd0*/ bool get_IsAtEnd();
            /*0x1e1cd6c*/ bool RefillBuffer(bool mustSucceed);
            /*0x1e1cdf0*/ byte[] ReadRawBytes(int size);
            /*0x1e1cfe0*/ void SkipRawBytes(int size);
            /*0x1e1d104*/ void ReadRawMessage(Google.Protobuf.IMessage message);
        }

        class CodedOutputStream : System.IDisposable
        {
            static int LittleEndian64Size = 8;
            static int LittleEndian32Size = 4;
            static int DoubleSize = 8;
            static int FloatSize = 4;
            static int BoolSize = 1;
            static /*0x0*/ int DefaultBufferSize;
            /*0x10*/ bool leaveOpen;
            /*0x18*/ byte[] buffer;
            /*0x20*/ Google.Protobuf.WriterInternalState state;
            /*0x38*/ System.IO.Stream output;

            static /*0x1e204fc*/ CodedOutputStream();
            static /*0x1e1d274*/ int ComputeDoubleSize(double value);
            static /*0x1e1d27c*/ int ComputeFloatSize(float value);
            static /*0x1e1d284*/ int ComputeUInt64Size(ulong value);
            static /*0x1e1d368*/ int ComputeInt64Size(long value);
            static /*0x1e1d3bc*/ int ComputeInt32Size(int value);
            static /*0x1e1d49c*/ int ComputeFixed64Size(ulong value);
            static /*0x1e1d4a4*/ int ComputeFixed32Size(uint value);
            static /*0x1e1d4ac*/ int ComputeBoolSize(bool value);
            static /*0x1e1d4b4*/ int ComputeStringSize(string value);
            static /*0x1e1d5f4*/ int ComputeGroupSize(Google.Protobuf.IMessage value);
            static /*0x1e1d694*/ int ComputeMessageSize(Google.Protobuf.IMessage value);
            static /*0x1e1d770*/ int ComputeBytesSize(Google.Protobuf.ByteString value);
            static /*0x1e1d7f0*/ int ComputeUInt32Size(uint value);
            static /*0x1e1d880*/ int ComputeEnumSize(int value);
            static /*0x1e1d8d4*/ int ComputeSFixed32Size(int value);
            static /*0x1e1d8dc*/ int ComputeSFixed64Size(long value);
            static /*0x1e1d8e4*/ int ComputeSInt32Size(int value);
            static /*0x1e1d9ac*/ int ComputeSInt64Size(long value);
            static /*0x1e1d564*/ int ComputeLengthSize(int length);
            static /*0x1e1d458*/ int ComputeRawVarint32Size(uint value);
            static /*0x1e1d2d8*/ int ComputeRawVarint64Size(ulong value);
            static /*0x1e1da38*/ int ComputeTagSize(int fieldNumber);
            /*0x1e1dae0*/ CodedOutputStream(byte[] flatArray);
            /*0x1e1dafc*/ CodedOutputStream(byte[] buffer, int offset, int length);
            /*0x1e1dba4*/ CodedOutputStream(System.IO.Stream output, byte[] buffer, bool leaveOpen);
            /*0x1e1dc58*/ CodedOutputStream(System.IO.Stream output);
            /*0x1e1dd44*/ CodedOutputStream(System.IO.Stream output, int bufferSize);
            /*0x1e1ddb0*/ CodedOutputStream(System.IO.Stream output, bool leaveOpen);
            /*0x1e1dccc*/ CodedOutputStream(System.IO.Stream output, int bufferSize, bool leaveOpen);
            /*0x1e1de28*/ long get_Position();
            /*0x1e1de60*/ void WriteDouble(double value);
            /*0x1e1df2c*/ void WriteFloat(float value);
            /*0x1e1dff8*/ void WriteUInt64(ulong value);
            /*0x1e1e0c4*/ void WriteInt64(long value);
            /*0x1e1e190*/ void WriteInt32(int value);
            /*0x1e1e25c*/ void WriteFixed64(ulong value);
            /*0x1e1e328*/ void WriteFixed32(uint value);
            /*0x1e1e3f4*/ void WriteBool(bool value);
            /*0x1e1e4c0*/ void WriteString(string value);
            /*0x1e1e58c*/ void WriteMessage(Google.Protobuf.IMessage value);
            /*0x1e1ea18*/ void WriteRawMessage(Google.Protobuf.IMessage value);
            /*0x1e1edec*/ void WriteGroup(Google.Protobuf.IMessage value);
            /*0x1e1f1c0*/ void WriteBytes(Google.Protobuf.ByteString value);
            /*0x1e1f28c*/ void WriteUInt32(uint value);
            /*0x1e1f358*/ void WriteEnum(int value);
            /*0x1e1f424*/ void WriteSFixed32(int value);
            /*0x1e1f4f0*/ void WriteSFixed64(long value);
            /*0x1e1f5bc*/ void WriteSInt32(int value);
            /*0x1e1f688*/ void WriteSInt64(long value);
            /*0x1e1f754*/ void WriteLength(int length);
            /*0x1e1f820*/ void WriteTag(int fieldNumber, Google.Protobuf.WireFormat.WireType type);
            /*0x1e1f8f4*/ void WriteTag(uint tag);
            /*0x1e1f9c0*/ void WriteRawTag(byte b1);
            /*0x1e1fa8c*/ void WriteRawTag(byte b1, byte b2);
            /*0x1e1fb60*/ void WriteRawTag(byte b1, byte b2, byte b3);
            /*0x1e1fc44*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4);
            /*0x1e1fd30*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5);
            /*0x1e1fe2c*/ void WriteRawVarint32(uint value);
            /*0x1e1fef8*/ void WriteRawVarint64(ulong value);
            /*0x1e1ffc4*/ void WriteRawLittleEndian32(uint value);
            /*0x1e20090*/ void WriteRawLittleEndian64(ulong value);
            /*0x1e2015c*/ void WriteRawBytes(byte[] value);
            /*0x1e20178*/ void WriteRawBytes(byte[] value, int offset, int length);
            /*0x1e2025c*/ void Dispose();
            /*0x1e20290*/ void Flush();
            /*0x1e203b0*/ void CheckNoSpaceLeft();
            /*0x1e2046c*/ int get_SpaceLeft();
            /*0x1e204e4*/ byte[] get_InternalBuffer();
            /*0x1e204ec*/ System.IO.Stream get_InternalOutputStream();
            /*0x1e204f4*/ ref Google.Protobuf.WriterInternalState get_InternalState();

            class OutOfSpaceException : System.IO.IOException
            {
                /*0x1e20548*/ OutOfSpaceException();
            }
        }

        class Extension
        {
            /*0x10*/ int <FieldNumber>k__BackingField;

            /*0x1e20594*/ Extension(int fieldNumber);
            System.Type get_TargetType();
            Google.Protobuf.IExtensionValue CreateValue();
            /*0x1e205bc*/ int get_FieldNumber();
            bool get_IsRepeated();
        }

        class Extension<TTarget, TValue> : Google.Protobuf.Extension
        {
            /*0x0*/ Google.Protobuf.FieldCodec<TValue> codec;

            Extension(int fieldNumber, Google.Protobuf.FieldCodec<TValue> codec);
            TValue get_DefaultValue();
            System.Type get_TargetType();
            bool get_IsRepeated();
            Google.Protobuf.IExtensionValue CreateValue();
        }

        class RepeatedExtension<TTarget, TValue> : Google.Protobuf.Extension
        {
            /*0x0*/ Google.Protobuf.FieldCodec<TValue> codec;

            RepeatedExtension(int fieldNumber, Google.Protobuf.FieldCodec<TValue> codec);
            System.Type get_TargetType();
            bool get_IsRepeated();
            Google.Protobuf.IExtensionValue CreateValue();
        }

        class ExtensionRegistry : System.Collections.Generic.ICollection<Google.Protobuf.Extension>, System.Collections.Generic.IEnumerable<Google.Protobuf.Extension>, System.Collections.IEnumerable, Google.Protobuf.IDeepCloneable<Google.Protobuf.ExtensionRegistry>
        {
            /*0x10*/ System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> extensions;

            /*0x1e205c4*/ ExtensionRegistry();
            /*0x1e20644*/ ExtensionRegistry(System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> collection);
            /*0x1e207ec*/ int get_Count();
            /*0x1e2088c*/ bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly();
            /*0x1e20894*/ bool ContainsInputField(uint lastTag, System.Type target, ref Google.Protobuf.Extension extension);
            /*0x1e209ac*/ void Add(Google.Protobuf.Extension extension);
            /*0x1e20af0*/ void AddRange(System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> extensions);
            /*0x1e20e00*/ void Clear();
            /*0x1e20ea4*/ bool Contains(Google.Protobuf.Extension item);
            /*0x1e20fe8*/ void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Google.Protobuf.Extension[] array, int arrayIndex);
            /*0x1e21220*/ System.Collections.Generic.IEnumerator<Google.Protobuf.Extension> GetEnumerator();
            /*0x1e21338*/ bool Remove(Google.Protobuf.Extension item);
            /*0x1e2147c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1e21480*/ Google.Protobuf.ExtensionRegistry Clone();

            class ExtensionComparer : System.Collections.Generic.IEqualityComparer<Google.Protobuf.Extension>
            {
                static /*0x0*/ Google.Protobuf.ExtensionRegistry.ExtensionComparer Instance;

                static /*0x1e2166c*/ ExtensionComparer();
                /*0x1e21664*/ ExtensionComparer();
                /*0x1e214e4*/ bool Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b);
                /*0x1e215c0*/ int GetHashCode(Google.Protobuf.Extension a);
            }

            class <>c
            {
                static /*0x0*/ Google.Protobuf.ExtensionRegistry.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension>, Google.Protobuf.ObjectIntPair<System.Type>> <>9__3_0;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension>, Google.Protobuf.Extension> <>9__3_1;

                static /*0x1e216d0*/ <>c();
                /*0x1e21734*/ <>c();
                /*0x1e2173c*/ Google.Protobuf.ObjectIntPair<System.Type> <.ctor>b__3_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> k);
                /*0x1e21778*/ Google.Protobuf.Extension <.ctor>b__3_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> v);
            }
        }

        class ExtensionSet
        {
            static bool TryGetValue<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension extension, ref Google.Protobuf.IExtensionValue value);
            static TValue Get<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension);
            static Google.Protobuf.Collections.RepeatedField<TValue> Get<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.RepeatedExtension<TTarget, TValue> extension);
            static Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.RepeatedExtension<TTarget, TValue> extension);
            static void Set<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension, TValue value);
            static bool Has<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension);
            static void Clear<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension);
            static void Clear<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.RepeatedExtension<TTarget, TValue> extension);
            static bool TryMergeFieldFrom<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.CodedInputStream stream);
            static bool TryMergeFieldFrom<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> set, ref Google.Protobuf.ParseContext ctx);
            static void MergeFrom<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> first, Google.Protobuf.ExtensionSet<TTarget> second);
            static Google.Protobuf.ExtensionSet<TTarget> Clone<TTarget>(Google.Protobuf.ExtensionSet<TTarget> set);
        }

        class ExtensionSet<TTarget>
        {
            /*0x0*/ System.Collections.Generic.Dictionary<int, Google.Protobuf.IExtensionValue> <ValuesByNumber>k__BackingField;

            ExtensionSet();
            System.Collections.Generic.Dictionary<int, Google.Protobuf.IExtensionValue> get_ValuesByNumber();
            int GetHashCode();
            bool Equals(object other);
            int CalculateSize();
            void WriteTo(Google.Protobuf.CodedOutputStream stream);
            void WriteTo(ref Google.Protobuf.WriteContext ctx);
            bool IsInitialized();

            class <>c<TTarget>
            {
                static /*0x0*/ Google.Protobuf.ExtensionSet.<>c<TTarget> <>9;
                static /*0x0*/ System.Func<Google.Protobuf.IExtensionValue, bool> <>9__8_0;

                static <>c();
                <>c();
                bool <IsInitialized>b__8_0(Google.Protobuf.IExtensionValue v);
            }
        }

        interface IExtensionValue : System.IEquatable<Google.Protobuf.IExtensionValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.IExtensionValue>
        {
            void MergeFrom(ref Google.Protobuf.ParseContext ctx);
            void MergeFrom(Google.Protobuf.IExtensionValue value);
            void WriteTo(ref Google.Protobuf.WriteContext ctx);
            int CalculateSize();
            bool IsInitialized();
        }

        class ExtensionValue<T> : Google.Protobuf.IExtensionValue, System.IEquatable<Google.Protobuf.IExtensionValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.IExtensionValue>
        {
            /*0x0*/ T field;
            /*0x0*/ Google.Protobuf.FieldCodec<T> codec;

            ExtensionValue(Google.Protobuf.FieldCodec<T> codec);
            int CalculateSize();
            Google.Protobuf.IExtensionValue Clone();
            bool Equals(Google.Protobuf.IExtensionValue other);
            int GetHashCode();
            void MergeFrom(ref Google.Protobuf.ParseContext ctx);
            void MergeFrom(Google.Protobuf.IExtensionValue value);
            void WriteTo(ref Google.Protobuf.WriteContext ctx);
            T GetValue();
            void SetValue(T value);
            bool IsInitialized();
        }

        class RepeatedExtensionValue<T> : Google.Protobuf.IExtensionValue, System.IEquatable<Google.Protobuf.IExtensionValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.IExtensionValue>
        {
            /*0x0*/ Google.Protobuf.Collections.RepeatedField<T> field;
            /*0x0*/ Google.Protobuf.FieldCodec<T> codec;

            RepeatedExtensionValue(Google.Protobuf.FieldCodec<T> codec);
            int CalculateSize();
            Google.Protobuf.IExtensionValue Clone();
            bool Equals(Google.Protobuf.IExtensionValue other);
            int GetHashCode();
            void MergeFrom(ref Google.Protobuf.ParseContext ctx);
            void MergeFrom(Google.Protobuf.IExtensionValue value);
            void WriteTo(ref Google.Protobuf.WriteContext ctx);
            Google.Protobuf.Collections.RepeatedField<T> GetValue();
            bool IsInitialized();
        }

        class FieldCodec
        {
            static /*0x1e217b4*/ Google.Protobuf.FieldCodec<string> ForString(uint tag);
            static /*0x1e21a08*/ Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(uint tag);
            static /*0x1e21ca4*/ Google.Protobuf.FieldCodec<bool> ForBool(uint tag);
            static /*0x1e21e70*/ Google.Protobuf.FieldCodec<int> ForInt32(uint tag);
            static /*0x1e22084*/ Google.Protobuf.FieldCodec<int> ForSInt32(uint tag);
            static /*0x1e22298*/ Google.Protobuf.FieldCodec<uint> ForFixed32(uint tag);
            static /*0x1e22464*/ Google.Protobuf.FieldCodec<int> ForSFixed32(uint tag);
            static /*0x1e22630*/ Google.Protobuf.FieldCodec<uint> ForUInt32(uint tag);
            static /*0x1e22844*/ Google.Protobuf.FieldCodec<long> ForInt64(uint tag);
            static /*0x1e22a58*/ Google.Protobuf.FieldCodec<long> ForSInt64(uint tag);
            static /*0x1e22c6c*/ Google.Protobuf.FieldCodec<ulong> ForFixed64(uint tag);
            static /*0x1e22e38*/ Google.Protobuf.FieldCodec<long> ForSFixed64(uint tag);
            static /*0x1e23004*/ Google.Protobuf.FieldCodec<ulong> ForUInt64(uint tag);
            static /*0x1e23218*/ Google.Protobuf.FieldCodec<float> ForFloat(uint tag);
            static /*0x1e233e4*/ Google.Protobuf.FieldCodec<double> ForDouble(uint tag);
            static Google.Protobuf.FieldCodec<T> ForEnum<T>(uint tag, System.Func<T, int> toInt32, System.Func<int, T> fromInt32);
            static /*0x1e217fc*/ Google.Protobuf.FieldCodec<string> ForString(uint tag, string defaultValue);
            static /*0x1e21a98*/ Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(uint tag, Google.Protobuf.ByteString defaultValue);
            static /*0x1e21cac*/ Google.Protobuf.FieldCodec<bool> ForBool(uint tag, bool defaultValue);
            static /*0x1e21e78*/ Google.Protobuf.FieldCodec<int> ForInt32(uint tag, int defaultValue);
            static /*0x1e2208c*/ Google.Protobuf.FieldCodec<int> ForSInt32(uint tag, int defaultValue);
            static /*0x1e222a0*/ Google.Protobuf.FieldCodec<uint> ForFixed32(uint tag, uint defaultValue);
            static /*0x1e2246c*/ Google.Protobuf.FieldCodec<int> ForSFixed32(uint tag, int defaultValue);
            static /*0x1e22638*/ Google.Protobuf.FieldCodec<uint> ForUInt32(uint tag, uint defaultValue);
            static /*0x1e2284c*/ Google.Protobuf.FieldCodec<long> ForInt64(uint tag, long defaultValue);
            static /*0x1e22a60*/ Google.Protobuf.FieldCodec<long> ForSInt64(uint tag, long defaultValue);
            static /*0x1e22c74*/ Google.Protobuf.FieldCodec<ulong> ForFixed64(uint tag, ulong defaultValue);
            static /*0x1e22e40*/ Google.Protobuf.FieldCodec<long> ForSFixed64(uint tag, long defaultValue);
            static /*0x1e2300c*/ Google.Protobuf.FieldCodec<ulong> ForUInt64(uint tag, ulong defaultValue);
            static /*0x1e23220*/ Google.Protobuf.FieldCodec<float> ForFloat(uint tag, float defaultValue);
            static /*0x1e233ec*/ Google.Protobuf.FieldCodec<double> ForDouble(uint tag, double defaultValue);
            static Google.Protobuf.FieldCodec<T> ForEnum<T>(uint tag, System.Func<T, int> toInt32, System.Func<int, T> fromInt32, T defaultValue);
            static Google.Protobuf.FieldCodec<T> ForMessage<T>(uint tag, Google.Protobuf.MessageParser<T> parser);
            static Google.Protobuf.FieldCodec<T> ForGroup<T>(uint startTag, uint endTag, Google.Protobuf.MessageParser<T> parser);
            static Google.Protobuf.FieldCodec<T> ForClassWrapper<T>(uint tag);
            static Google.Protobuf.FieldCodec<System.Nullable<T>> ForStructWrapper<T>(uint tag);

            class WrapperCodecs
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> Codecs;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, object> Readers;

                static /*0x1e235b0*/ WrapperCodecs();
                static Google.Protobuf.FieldCodec<T> GetCodec<T>();
                static Google.Protobuf.ValueReader<System.Nullable<T>> GetReader<T>();
                static T Read<T>(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.FieldCodec<T> codec);
                static void Write<T>(ref Google.Protobuf.WriteContext ctx, T value, Google.Protobuf.FieldCodec<T> codec);
                static int CalculateSize<T>(T value, Google.Protobuf.FieldCodec<T> codec);

                class <>c__DisplayClass3_0<T>
                {
                    /*0x0*/ Google.Protobuf.FieldCodec<T> nestedCoded;

                    <>c__DisplayClass3_0();
                    System.Nullable<T> <GetReader>b__0(ref Google.Protobuf.ParseContext ctx);
                }
            }

            class <>c
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<> <>9;
                static /*0x8*/ Google.Protobuf.ValueReader<string> <>9__16_0;
                static /*0x10*/ Google.Protobuf.ValueWriter<string> <>9__16_1;
                static /*0x18*/ Google.Protobuf.ValueReader<Google.Protobuf.ByteString> <>9__17_0;
                static /*0x20*/ Google.Protobuf.ValueWriter<Google.Protobuf.ByteString> <>9__17_1;
                static /*0x28*/ Google.Protobuf.ValueReader<bool> <>9__18_0;
                static /*0x30*/ Google.Protobuf.ValueWriter<bool> <>9__18_1;
                static /*0x38*/ Google.Protobuf.ValueReader<int> <>9__19_0;
                static /*0x40*/ Google.Protobuf.ValueWriter<int> <>9__19_1;
                static /*0x48*/ Google.Protobuf.ValueReader<int> <>9__20_0;
                static /*0x50*/ Google.Protobuf.ValueWriter<int> <>9__20_1;
                static /*0x58*/ Google.Protobuf.ValueReader<uint> <>9__21_0;
                static /*0x60*/ Google.Protobuf.ValueWriter<uint> <>9__21_1;
                static /*0x68*/ Google.Protobuf.ValueReader<int> <>9__22_0;
                static /*0x70*/ Google.Protobuf.ValueWriter<int> <>9__22_1;
                static /*0x78*/ Google.Protobuf.ValueReader<uint> <>9__23_0;
                static /*0x80*/ Google.Protobuf.ValueWriter<uint> <>9__23_1;
                static /*0x88*/ Google.Protobuf.ValueReader<long> <>9__24_0;
                static /*0x90*/ Google.Protobuf.ValueWriter<long> <>9__24_1;
                static /*0x98*/ Google.Protobuf.ValueReader<long> <>9__25_0;
                static /*0xa0*/ Google.Protobuf.ValueWriter<long> <>9__25_1;
                static /*0xa8*/ Google.Protobuf.ValueReader<ulong> <>9__26_0;
                static /*0xb0*/ Google.Protobuf.ValueWriter<ulong> <>9__26_1;
                static /*0xb8*/ Google.Protobuf.ValueReader<long> <>9__27_0;
                static /*0xc0*/ Google.Protobuf.ValueWriter<long> <>9__27_1;
                static /*0xc8*/ Google.Protobuf.ValueReader<ulong> <>9__28_0;
                static /*0xd0*/ Google.Protobuf.ValueWriter<ulong> <>9__28_1;
                static /*0xd8*/ Google.Protobuf.ValueReader<float> <>9__29_0;
                static /*0xe0*/ Google.Protobuf.ValueWriter<float> <>9__29_1;
                static /*0xe8*/ Google.Protobuf.ValueReader<double> <>9__30_0;
                static /*0xf0*/ Google.Protobuf.ValueWriter<double> <>9__30_1;

                static /*0x1e23de4*/ <>c();
                /*0x1e23e48*/ <>c();
                /*0x1e23e50*/ string <ForString>b__16_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23e84*/ void <ForString>b__16_1(ref Google.Protobuf.WriteContext ctx, string value);
                /*0x1e23e94*/ Google.Protobuf.ByteString <ForBytes>b__17_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23f10*/ void <ForBytes>b__17_1(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.ByteString value);
                /*0x1e23f20*/ bool <ForBool>b__18_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23f40*/ void <ForBool>b__18_1(ref Google.Protobuf.WriteContext ctx, bool value);
                /*0x1e23f54*/ int <ForInt32>b__19_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23f60*/ void <ForInt32>b__19_1(ref Google.Protobuf.WriteContext output, int value);
                /*0x1e23f70*/ int <ForSInt32>b__20_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23f94*/ void <ForSInt32>b__20_1(ref Google.Protobuf.WriteContext output, int value);
                /*0x1e23fa4*/ uint <ForFixed32>b__21_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23fb0*/ void <ForFixed32>b__21_1(ref Google.Protobuf.WriteContext output, uint value);
                /*0x1e23fc0*/ int <ForSFixed32>b__22_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23fcc*/ void <ForSFixed32>b__22_1(ref Google.Protobuf.WriteContext output, int value);
                /*0x1e23fdc*/ uint <ForUInt32>b__23_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e23fe8*/ void <ForUInt32>b__23_1(ref Google.Protobuf.WriteContext output, uint value);
                /*0x1e23ff8*/ long <ForInt64>b__24_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e24004*/ void <ForInt64>b__24_1(ref Google.Protobuf.WriteContext output, long value);
                /*0x1e24014*/ long <ForSInt64>b__25_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e24038*/ void <ForSInt64>b__25_1(ref Google.Protobuf.WriteContext output, long value);
                /*0x1e24048*/ ulong <ForFixed64>b__26_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e24054*/ void <ForFixed64>b__26_1(ref Google.Protobuf.WriteContext output, ulong value);
                /*0x1e24064*/ long <ForSFixed64>b__27_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e24070*/ void <ForSFixed64>b__27_1(ref Google.Protobuf.WriteContext output, long value);
                /*0x1e24080*/ ulong <ForUInt64>b__28_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e2408c*/ void <ForUInt64>b__28_1(ref Google.Protobuf.WriteContext output, ulong value);
                /*0x1e2409c*/ float <ForFloat>b__29_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e240a8*/ void <ForFloat>b__29_1(ref Google.Protobuf.WriteContext output, float value);
                /*0x1e240b4*/ double <ForDouble>b__30_0(ref Google.Protobuf.ParseContext ctx);
                /*0x1e240c0*/ void <ForDouble>b__30_1(ref Google.Protobuf.WriteContext output, double value);
            }

            class <>c__DisplayClass31_0<T>
            {
                /*0x0*/ System.Func<int, T> fromInt32;
                /*0x0*/ System.Func<T, int> toInt32;

                <>c__DisplayClass31_0();
                T <ForEnum>b__0(ref Google.Protobuf.ParseContext ctx);
                void <ForEnum>b__1(ref Google.Protobuf.WriteContext output, T value);
                int <ForEnum>b__2(T value);
            }

            class <>c__DisplayClass32_0<T>
            {
                /*0x0*/ Google.Protobuf.MessageParser<T> parser;

                <>c__DisplayClass32_0();
                T <ForMessage>b__0(ref Google.Protobuf.ParseContext ctx);
                void <ForMessage>b__2(ref Google.Protobuf.ParseContext ctx, ref T v);
            }

            class <>c__32<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__32<T> <>9;
                static /*0x0*/ Google.Protobuf.ValueWriter<T> <>9__32_1;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__32_3;
                static /*0x0*/ System.Func<T, int> <>9__32_4;

                static <>c__32();
                <>c__32();
                void <ForMessage>b__32_1(ref Google.Protobuf.WriteContext output, T value);
                bool <ForMessage>b__32_3(ref T v, T v2);
                int <ForMessage>b__32_4(T message);
            }

            class <>c__DisplayClass33_0<T>
            {
                /*0x0*/ Google.Protobuf.MessageParser<T> parser;

                <>c__DisplayClass33_0();
                T <ForGroup>b__0(ref Google.Protobuf.ParseContext ctx);
                void <ForGroup>b__2(ref Google.Protobuf.ParseContext ctx, ref T v);
            }

            class <>c__33<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__33<T> <>9;
                static /*0x0*/ Google.Protobuf.ValueWriter<T> <>9__33_1;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__33_3;
                static /*0x0*/ System.Func<T, int> <>9__33_4;

                static <>c__33();
                <>c__33();
                void <ForGroup>b__33_1(ref Google.Protobuf.WriteContext output, T value);
                bool <ForGroup>b__33_3(ref T v, T v2);
                int <ForGroup>b__33_4(T message);
            }

            class <>c__DisplayClass34_0<T>
            {
                /*0x0*/ Google.Protobuf.FieldCodec<T> nestedCodec;

                <>c__DisplayClass34_0();
                T <ForClassWrapper>b__0(ref Google.Protobuf.ParseContext ctx);
                void <ForClassWrapper>b__1(ref Google.Protobuf.WriteContext output, T value);
                void <ForClassWrapper>b__2(ref Google.Protobuf.ParseContext ctx, ref T v);
                int <ForClassWrapper>b__4(T value);
            }

            class <>c__34<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__34<T> <>9;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__34_3;

                static <>c__34();
                <>c__34();
                bool <ForClassWrapper>b__34_3(ref T v, T v2);
            }

            class <>c__DisplayClass35_0<T>
            {
                /*0x0*/ Google.Protobuf.FieldCodec<T> nestedCodec;

                <>c__DisplayClass35_0();
                void <ForStructWrapper>b__0(ref Google.Protobuf.WriteContext output, System.Nullable<T> value);
                void <ForStructWrapper>b__1(ref Google.Protobuf.ParseContext ctx, ref System.Nullable<T> v);
                int <ForStructWrapper>b__3(System.Nullable<T> value);
            }

            class <>c__35<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__35<T> <>9;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<System.Nullable<T>> <>9__35_2;

                static <>c__35();
                <>c__35();
                bool <ForStructWrapper>b__35_2(ref System.Nullable<T> v, System.Nullable<T> v2);
            }
        }

        class ValueReader<TValue> : System.MulticastDelegate
        {
            ValueReader(object object, nint method);
            TValue Invoke(ref Google.Protobuf.ParseContext ctx);
            System.IAsyncResult BeginInvoke(ref Google.Protobuf.ParseContext ctx, System.AsyncCallback callback, object object);
            TValue EndInvoke(ref Google.Protobuf.ParseContext ctx, System.IAsyncResult result);
        }

        class ValueWriter<T> : System.MulticastDelegate
        {
            ValueWriter(object object, nint method);
            void Invoke(ref Google.Protobuf.WriteContext ctx, T value);
            System.IAsyncResult BeginInvoke(ref Google.Protobuf.WriteContext ctx, T value, System.AsyncCallback callback, object object);
            void EndInvoke(ref Google.Protobuf.WriteContext ctx, System.IAsyncResult result);
        }

        class FieldCodec<T>
        {
            static /*0x0*/ System.Collections.Generic.EqualityComparer<T> EqualityComparer;
            static /*0x0*/ T DefaultDefault;
            static /*0x0*/ bool TypeSupportsPacking;
            /*0x0*/ bool <PackedRepeatedField>k__BackingField;
            /*0x0*/ Google.Protobuf.ValueWriter<T> <ValueWriter>k__BackingField;
            /*0x0*/ System.Func<T, int> <ValueSizeCalculator>k__BackingField;
            /*0x0*/ Google.Protobuf.ValueReader<T> <ValueReader>k__BackingField;
            /*0x0*/ Google.Protobuf.FieldCodec.InputMerger<T> <ValueMerger>k__BackingField;
            /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <FieldMerger>k__BackingField;
            /*0x0*/ int <FixedSize>k__BackingField;
            /*0x0*/ uint <Tag>k__BackingField;
            /*0x0*/ uint <EndTag>k__BackingField;
            /*0x0*/ T <DefaultValue>k__BackingField;
            /*0x0*/ int tagSize;

            static FieldCodec();
            static bool IsPackedRepeatedField(uint tag);
            FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, int fixedSize, uint tag, T defaultValue);
            FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Func<T, int> sizeCalculator, uint tag, T defaultValue);
            FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T, int> sizeCalculator, uint tag, uint endTag);
            FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue);
            bool get_PackedRepeatedField();
            Google.Protobuf.ValueWriter<T> get_ValueWriter();
            System.Func<T, int> get_ValueSizeCalculator();
            Google.Protobuf.ValueReader<T> get_ValueReader();
            Google.Protobuf.FieldCodec.InputMerger<T> get_ValueMerger();
            Google.Protobuf.FieldCodec.ValuesMerger<T> get_FieldMerger();
            int get_FixedSize();
            uint get_Tag();
            uint get_EndTag();
            T get_DefaultValue();
            void WriteTagAndValue(Google.Protobuf.CodedOutputStream output, T value);
            void WriteTagAndValue(ref Google.Protobuf.WriteContext ctx, T value);
            T Read(Google.Protobuf.CodedInputStream input);
            T Read(ref Google.Protobuf.ParseContext ctx);
            int CalculateSizeWithTag(T value);
            int CalculateUnconditionalSizeWithTag(T value);
            bool IsDefault(T value);

            class InputMerger<T> : System.MulticastDelegate
            {
                InputMerger(object object, nint method);
                void Invoke(ref Google.Protobuf.ParseContext ctx, ref T value);
                System.IAsyncResult BeginInvoke(ref Google.Protobuf.ParseContext ctx, ref T value, System.AsyncCallback callback, object object);
                void EndInvoke(ref Google.Protobuf.ParseContext ctx, ref T value, System.IAsyncResult result);
            }

            class ValuesMerger<T> : System.MulticastDelegate
            {
                ValuesMerger(object object, nint method);
                bool Invoke(ref T value, T other);
                System.IAsyncResult BeginInvoke(ref T value, T other, System.AsyncCallback callback, object object);
                bool EndInvoke(ref T value, System.IAsyncResult result);
            }

            class <>c__DisplayClass38_0<T>
            {
                /*0x0*/ int fixedSize;

                <>c__DisplayClass38_0();
                int <.ctor>b__0(T _);
            }

            class <>c__DisplayClass39_0<T>
            {
                /*0x0*/ Google.Protobuf.ValueReader<T> reader;

                <>c__DisplayClass39_0();
                void <.ctor>b__0(ref Google.Protobuf.ParseContext ctx, ref T v);
            }

            class <>c<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c<T> <>9;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__39_1;

                static <>c();
                <>c();
                bool <.ctor>b__39_1(ref T v, T v2);
            }
        }

        class FieldMaskTree
        {
            static char FIELD_PATH_SEPARATOR = 46;
            /*0x10*/ Google.Protobuf.FieldMaskTree.Node root;

            /*0x1e240cc*/ FieldMaskTree();
            /*0x1e241ac*/ FieldMaskTree(Google.Protobuf.WellKnownTypes.FieldMask mask);
            /*0x1e244b4*/ string ToString();
            /*0x1e245fc*/ Google.Protobuf.FieldMaskTree AddFieldPath(string path);
            /*0x1e24228*/ Google.Protobuf.FieldMaskTree MergeFromFieldMask(Google.Protobuf.WellKnownTypes.FieldMask mask);
            /*0x1e244d4*/ Google.Protobuf.WellKnownTypes.FieldMask ToFieldMask();
            /*0x1e247ec*/ void GetFieldPaths(Google.Protobuf.FieldMaskTree.Node node, string path, System.Collections.Generic.List<string> paths);
            /*0x1e24a3c*/ void IntersectFieldPath(string path, Google.Protobuf.FieldMaskTree output);
            /*0x1e24d1c*/ void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options);
            /*0x1e24f08*/ void Merge(Google.Protobuf.FieldMaskTree.Node node, string path, Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options);

            class Node
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.FieldMaskTree.Node> <Children>k__BackingField;

                /*0x1e24130*/ Node();
                /*0x1e2611c*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.FieldMaskTree.Node> get_Children();
            }
        }

        class FrameworkPortability
        {
            static /*0x0*/ System.Text.RegularExpressions.RegexOptions CompiledRegexWhereAvailable;

            static /*0x1e26124*/ FrameworkPortability();
        }

        interface IBufferMessage : Google.Protobuf.IMessage
        {
            void InternalMergeFrom(ref Google.Protobuf.ParseContext ctx);
            void InternalWriteTo(ref Google.Protobuf.WriteContext ctx);
        }

        interface ICustomDiagnosticMessage : Google.Protobuf.IMessage
        {
            string ToDiagnosticString();
        }

        interface IDeepCloneable<T>
        {
            T Clone();
        }

        interface IExtendableMessage<T> : Google.Protobuf.IMessage<T>, Google.Protobuf.IMessage, System.IEquatable<T>, Google.Protobuf.IDeepCloneable<T>
        {
            TValue GetExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension);
            Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<T, TValue> extension);
            Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<T, TValue> extension);
            void SetExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension, TValue value);
            bool HasExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension);
            void ClearExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension);
            void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<T, TValue> extension);
        }

        interface IMessage
        {
            void MergeFrom(Google.Protobuf.CodedInputStream input);
            void WriteTo(Google.Protobuf.CodedOutputStream output);
            int CalculateSize();
            Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
        }

        interface IMessage<T> : Google.Protobuf.IMessage, System.IEquatable<T>, Google.Protobuf.IDeepCloneable<T>
        {
            void MergeFrom(T message);
        }

        class InvalidJsonException : System.IO.IOException
        {
            /*0x1e2622c*/ InvalidJsonException(string message);
        }

        class InvalidProtocolBufferException : System.IO.IOException
        {
            static /*0x1e2623c*/ Google.Protobuf.InvalidProtocolBufferException MoreDataAvailable();
            static /*0x1e262b0*/ Google.Protobuf.InvalidProtocolBufferException TruncatedMessage();
            static /*0x1e26324*/ Google.Protobuf.InvalidProtocolBufferException NegativeSize();
            static /*0x1e26398*/ Google.Protobuf.InvalidProtocolBufferException MalformedVarint();
            static /*0x1e2640c*/ Google.Protobuf.InvalidProtocolBufferException InvalidTag();
            static /*0x1e26480*/ Google.Protobuf.InvalidProtocolBufferException InvalidWireType();
            static /*0x1e264f4*/ Google.Protobuf.InvalidProtocolBufferException InvalidBase64(System.Exception innerException);
            static /*0x1e26570*/ Google.Protobuf.InvalidProtocolBufferException InvalidEndTag();
            static /*0x1e265e4*/ Google.Protobuf.InvalidProtocolBufferException RecursionLimitExceeded();
            static /*0x1e26658*/ Google.Protobuf.InvalidProtocolBufferException JsonRecursionLimitExceeded();
            static /*0x1e266cc*/ Google.Protobuf.InvalidProtocolBufferException SizeLimitExceeded();
            static /*0x1e26740*/ Google.Protobuf.InvalidProtocolBufferException InvalidMessageStreamTag();
            static /*0x1e267b4*/ Google.Protobuf.InvalidProtocolBufferException MissingFields();
            /*0x1e24f00*/ InvalidProtocolBufferException(string message);
            /*0x1e26234*/ InvalidProtocolBufferException(string message, System.Exception innerException);
        }

        class JsonFormatter
        {
            static string AnyTypeUrlField = "@type";
            static string AnyDiagnosticValueField = "@value";
            static string AnyWellKnownTypeValueField = "value";
            static string TypeUrlPrefix = "type.googleapis.com";
            static string NameValueSeparator = ": ";
            static string PropertySeparator = ", ";
            static string Hex = "0123456789abcdef";
            static /*0x0*/ Google.Protobuf.JsonFormatter <Default>k__BackingField;
            static /*0x8*/ Google.Protobuf.JsonFormatter diagnosticFormatter;
            static /*0x10*/ string[] CommonRepresentations;
            /*0x10*/ Google.Protobuf.JsonFormatter.Settings settings;

            static /*0x1e26880*/ JsonFormatter();
            static /*0x1e26828*/ Google.Protobuf.JsonFormatter get_Default();
            static /*0x1e29698*/ string ToDiagnosticString(Google.Protobuf.IMessage message);
            static /*0x1e2af90*/ string ToJsonName(string name);
            static /*0x1e2b0ac*/ string FromJsonName(string name);
            static /*0x1e29740*/ void WriteNull(System.IO.TextWriter writer);
            static /*0x1e2aaec*/ bool IsDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor, object value);
            static /*0x1e29e78*/ void WriteString(System.IO.TextWriter writer, string text);
            static /*0x1e2dc3c*/ void HexEncodeUtf16CodeUnit(System.IO.TextWriter writer, char c);
            /*0x1e28b84*/ JsonFormatter(Google.Protobuf.JsonFormatter.Settings settings);
            /*0x1e28c04*/ bool get_DiagnosticOnly();
            /*0x1e28c68*/ string Format(Google.Protobuf.IMessage message);
            /*0x1e28cec*/ void Format(Google.Protobuf.IMessage message, System.IO.TextWriter writer);
            /*0x1e294f8*/ void WriteMessage(System.IO.TextWriter writer, Google.Protobuf.IMessage message);
            /*0x1e2979c*/ bool WriteMessageFields(System.IO.TextWriter writer, Google.Protobuf.IMessage message, bool assumeFirstFieldWritten);
            /*0x1e29d48*/ bool ShouldFormatFieldValue(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, object value);
            /*0x1e2a1c4*/ void WriteValue(System.IO.TextWriter writer, object value);
            /*0x1e28ec0*/ void WriteWellKnownTypeValue(System.IO.TextWriter writer, Google.Protobuf.Reflection.MessageDescriptor descriptor, object value);
            /*0x1e2bfe0*/ void WriteTimestamp(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x1e2c2e8*/ void WriteDuration(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x1e2c5f0*/ void WriteFieldMask(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x1e2d2dc*/ void WriteAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x1e2d810*/ void WriteDiagnosticOnlyAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x1e2c7d8*/ void WriteStruct(System.IO.TextWriter writer, Google.Protobuf.IMessage message);
            /*0x1e2ceb8*/ void WriteStructFieldValue(System.IO.TextWriter writer, Google.Protobuf.IMessage message);
            /*0x1e2b9d8*/ void WriteList(System.IO.TextWriter writer, System.Collections.IList list);
            /*0x1e2b1d4*/ void WriteDictionary(System.IO.TextWriter writer, System.Collections.IDictionary dictionary);

            class Settings
            {
                static /*0x0*/ Google.Protobuf.JsonFormatter.Settings <Default>k__BackingField;
                /*0x10*/ bool <FormatDefaultValues>k__BackingField;
                /*0x18*/ Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;
                /*0x20*/ bool <FormatEnumsAsIntegers>k__BackingField;

                static /*0x1e2ddbc*/ Settings();
                static /*0x1e2dd64*/ Google.Protobuf.JsonFormatter.Settings get_Default();
                /*0x1e2de20*/ Settings(bool formatDefaultValues);
                /*0x1e2dedc*/ Settings(bool formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry);
                /*0x1e2dee8*/ Settings(bool formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry, bool formatEnumsAsIntegers);
                /*0x1e2dec4*/ bool get_FormatDefaultValues();
                /*0x1e2decc*/ Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry();
                /*0x1e2ded4*/ bool get_FormatEnumsAsIntegers();
                /*0x1e2dfa4*/ Google.Protobuf.JsonFormatter.Settings WithFormatDefaultValues(bool formatDefaultValues);
                /*0x1e2e024*/ Google.Protobuf.JsonFormatter.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry);
                /*0x1e2e0a8*/ Google.Protobuf.JsonFormatter.Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers);
            }

            class OriginalEnumValueHelper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<object, string>> dictionaries;

                static /*0x1e2e438*/ OriginalEnumValueHelper();
                static /*0x1e2bdc4*/ string GetOriginalName(object value);
                static /*0x1e2e128*/ System.Collections.Generic.Dictionary<object, string> GetNameMapping(System.Type enumType);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.JsonFormatter.OriginalEnumValueHelper.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.FieldInfo, bool> <>9__2_0;
                    static /*0x10*/ System.Func<System.Reflection.FieldInfo, bool> <>9__2_1;
                    static /*0x18*/ System.Func<System.Reflection.FieldInfo, object> <>9__2_2;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, string> <>9__2_3;

                    static /*0x1e2e4c4*/ <>c();
                    /*0x1e2e528*/ <>c();
                    /*0x1e2e530*/ bool <GetNameMapping>b__2_0(System.Reflection.FieldInfo f);
                    /*0x1e2e548*/ bool <GetNameMapping>b__2_1(System.Reflection.FieldInfo f);
                    /*0x1e2e5d0*/ object <GetNameMapping>b__2_2(System.Reflection.FieldInfo f);
                    /*0x1e2e5f8*/ string <GetNameMapping>b__2_3(System.Reflection.FieldInfo f);
                }
            }
        }

        class JsonParser
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex TimestampRegex;
            static /*0x8*/ System.Text.RegularExpressions.Regex DurationRegex;
            static /*0x10*/ int[] SubsecondScalingFactors;
            static /*0x18*/ char[] FieldMaskPathSeparators;
            static /*0x20*/ Google.Protobuf.Reflection.EnumDescriptor NullValueDescriptor;
            static /*0x28*/ Google.Protobuf.JsonParser defaultInstance;
            static /*0x30*/ System.Collections.Generic.Dictionary<string, System.Action<Google.Protobuf.JsonParser, Google.Protobuf.IMessage, Google.Protobuf.JsonTokenizer>> WellKnownTypeHandlers;
            /*0x10*/ Google.Protobuf.JsonParser.Settings settings;

            static /*0x1e33758*/ JsonParser();
            static /*0x1e2e69c*/ void MergeWrapperField(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            static /*0x1e2e9e4*/ Google.Protobuf.JsonParser get_Default();
            static /*0x1e2f2c8*/ bool IsGoogleProtobufValueField(Google.Protobuf.Reflection.FieldDescriptor field);
            static /*0x1e2f36c*/ bool IsGoogleProtobufNullValueField(Google.Protobuf.Reflection.FieldDescriptor field);
            static /*0x1e2fe04*/ object ParseMapKey(Google.Protobuf.Reflection.FieldDescriptor field, string keyText);
            static /*0x1e30930*/ object ParseSingleNumberValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonToken token);
            static /*0x1e31eec*/ void CheckInteger(double value);
            static /*0x1e30250*/ object ParseSingleStringValue(Google.Protobuf.Reflection.FieldDescriptor field, string text);
            static /*0x1e30214*/ Google.Protobuf.IMessage NewMessageForField(Google.Protobuf.Reflection.FieldDescriptor field);
            static T ParseNumericString<T>(string text, System.Func<string, System.Globalization.NumberStyles, System.IFormatProvider, T> parser);
            static /*0x1e32050*/ void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN);
            static /*0x1e3216c*/ void MergeTimestamp(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token);
            static /*0x1e32b60*/ void MergeDuration(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token);
            static /*0x1e33298*/ void MergeFieldMask(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token);
            static /*0x1e33590*/ string ToSnakeCase(string text);
            /*0x1e2ea3c*/ JsonParser(Google.Protobuf.JsonParser.Settings settings);
            /*0x1e2eabc*/ void Merge(Google.Protobuf.IMessage message, string json);
            /*0x1e2eb38*/ void Merge(Google.Protobuf.IMessage message, System.IO.TextReader jsonReader);
            /*0x1e2ecb8*/ void Merge(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e2e77c*/ void MergeField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e2f7c4*/ void MergeRepeatedField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e2f4ac*/ void MergeMapField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e2fa7c*/ object ParseSingleValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            T Parse<T>(string json);
            T Parse<T>(System.IO.TextReader jsonReader);
            /*0x1e30f38*/ Google.Protobuf.IMessage Parse(string json, Google.Protobuf.Reflection.MessageDescriptor descriptor);
            /*0x1e31034*/ Google.Protobuf.IMessage Parse(System.IO.TextReader jsonReader, Google.Protobuf.Reflection.MessageDescriptor descriptor);
            /*0x1e31130*/ void MergeStructValue(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e316ac*/ void MergeStruct(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e317f8*/ void MergeAny(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1e31dcc*/ void MergeWellKnownTypeAnyBody(Google.Protobuf.IMessage body, Google.Protobuf.JsonTokenizer tokenizer);

            class Settings
            {
                static /*0x0*/ Google.Protobuf.JsonParser.Settings <Default>k__BackingField;
                /*0x10*/ int <RecursionLimit>k__BackingField;
                /*0x18*/ Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;
                /*0x20*/ bool <IgnoreUnknownFields>k__BackingField;

                static /*0x1e342e8*/ Settings();
                static /*0x1e34290*/ Google.Protobuf.JsonParser.Settings get_Default();
                /*0x1e34408*/ Settings(int recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry, bool ignoreUnknownFields);
                /*0x1e3434c*/ Settings(int recursionLimit);
                /*0x1e344a0*/ Settings(int recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry);
                /*0x1e343f0*/ int get_RecursionLimit();
                /*0x1e343f8*/ Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry();
                /*0x1e34400*/ bool get_IgnoreUnknownFields();
                /*0x1e344a8*/ Google.Protobuf.JsonParser.Settings WithIgnoreUnknownFields(bool ignoreUnknownFields);
                /*0x1e34524*/ Google.Protobuf.JsonParser.Settings WithRecursionLimit(int recursionLimit);
                /*0x1e345a4*/ Google.Protobuf.JsonParser.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry);
            }

            class <>c
            {
                static /*0x0*/ Google.Protobuf.JsonParser.<> <>9;

                static /*0x1e3466c*/ <>c();
                /*0x1e346d0*/ <>c();
                /*0x1e346d8*/ bool <.cctor>b__41_0(Google.Protobuf.Reflection.EnumDescriptor ed);
                /*0x1e34764*/ void <.cctor>b__41_1(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x1e347d8*/ void <.cctor>b__41_2(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x1e3484c*/ void <.cctor>b__41_3(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x1e34868*/ void <.cctor>b__41_4(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x1e34948*/ void <.cctor>b__41_5(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x1e34964*/ void <.cctor>b__41_6(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x1e34980*/ void <.cctor>b__41_7(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            }
        }

        class JsonToken : System.IEquatable<Google.Protobuf.JsonToken>
        {
            static /*0x0*/ Google.Protobuf.JsonToken _true;
            static /*0x8*/ Google.Protobuf.JsonToken _false;
            static /*0x10*/ Google.Protobuf.JsonToken _null;
            static /*0x18*/ Google.Protobuf.JsonToken startObject;
            static /*0x20*/ Google.Protobuf.JsonToken endObject;
            static /*0x28*/ Google.Protobuf.JsonToken startArray;
            static /*0x30*/ Google.Protobuf.JsonToken endArray;
            static /*0x38*/ Google.Protobuf.JsonToken endDocument;
            /*0x10*/ Google.Protobuf.JsonToken.TokenType type;
            /*0x18*/ string stringValue;
            /*0x20*/ double numberValue;

            static /*0x1e3523c*/ JsonToken();
            static /*0x1e349f4*/ Google.Protobuf.JsonToken get_Null();
            static /*0x1e34a4c*/ Google.Protobuf.JsonToken get_False();
            static /*0x1e34aa4*/ Google.Protobuf.JsonToken get_True();
            static /*0x1e34afc*/ Google.Protobuf.JsonToken get_StartObject();
            static /*0x1e34b54*/ Google.Protobuf.JsonToken get_EndObject();
            static /*0x1e34bac*/ Google.Protobuf.JsonToken get_StartArray();
            static /*0x1e34c04*/ Google.Protobuf.JsonToken get_EndArray();
            static /*0x1e34c5c*/ Google.Protobuf.JsonToken get_EndDocument();
            static /*0x1e34cb4*/ Google.Protobuf.JsonToken Name(string name);
            static /*0x1e34d60*/ Google.Protobuf.JsonToken Value(string value);
            static /*0x1e34dcc*/ Google.Protobuf.JsonToken Value(double value);
            /*0x1e34d20*/ JsonToken(Google.Protobuf.JsonToken.TokenType type, string stringValue, double numberValue);
            /*0x1e34e44*/ Google.Protobuf.JsonToken.TokenType get_Type();
            /*0x1e34e4c*/ string get_StringValue();
            /*0x1e34e54*/ double get_NumberValue();
            /*0x1e34e5c*/ bool Equals(object obj);
            /*0x1e34f2c*/ int GetHashCode();
            /*0x1e35004*/ string ToString();
            /*0x1e34ec0*/ bool Equals(Google.Protobuf.JsonToken other);

            enum TokenType
            {
                Null = 0,
                False = 1,
                True = 2,
                StringValue = 3,
                Number = 4,
                Name = 5,
                StartObject = 6,
                EndObject = 7,
                StartArray = 8,
                EndArray = 9,
                EndDocument = 10,
            }
        }

        class JsonTokenizer
        {
            /*0x10*/ Google.Protobuf.JsonToken bufferedToken;
            /*0x18*/ int <ObjectDepth>k__BackingField;

            static /*0x1e2ec58*/ Google.Protobuf.JsonTokenizer FromTextReader(System.IO.TextReader reader);
            static /*0x1e31d5c*/ Google.Protobuf.JsonTokenizer FromReplayedTokens(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer continuation);
            /*0x1e35508*/ JsonTokenizer();
            /*0x1e354f8*/ int get_ObjectDepth();
            /*0x1e35500*/ void set_ObjectDepth(int value);
            /*0x1e2f414*/ void PushBack(Google.Protobuf.JsonToken token);
            /*0x1e2f1fc*/ Google.Protobuf.JsonToken Next();
            Google.Protobuf.JsonToken NextImpl();
            /*0x1e2f260*/ void SkipValue();

            class JsonReplayTokenizer : Google.Protobuf.JsonTokenizer
            {
                /*0x20*/ System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens;
                /*0x28*/ Google.Protobuf.JsonTokenizer nextTokenizer;
                /*0x30*/ int nextTokenIndex;

                /*0x1e354cc*/ JsonReplayTokenizer(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer nextTokenizer);
                /*0x1e35510*/ Google.Protobuf.JsonToken NextImpl();
            }

            class JsonTextTokenizer : Google.Protobuf.JsonTokenizer
            {
                static /*0x0*/ Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ValueStates;
                /*0x20*/ System.Collections.Generic.Stack<Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack;
                /*0x28*/ Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReader reader;
                /*0x30*/ Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State state;

                static /*0x1e37278*/ JsonTextTokenizer();
                /*0x1e353e0*/ JsonTextTokenizer(System.IO.TextReader reader);
                /*0x1e3567c*/ Google.Protobuf.JsonToken NextImpl();
                /*0x1e35f98*/ void ValidateState(Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, string errorPrefix);
                /*0x1e36038*/ string ReadString();
                /*0x1e36a04*/ char ReadEscapedCharacter();
                /*0x1e36bd0*/ char ReadUnicodeEscape();
                /*0x1e3648c*/ void ConsumeLiteral(string text);
                /*0x1e365b4*/ double ReadNumber(char initialCharacter);
                /*0x1e36e20*/ System.Nullable<char> ReadInt(System.Text.StringBuilder builder);
                /*0x1e36f20*/ System.Nullable<char> ReadFrac(System.Text.StringBuilder builder);
                /*0x1e36fac*/ System.Nullable<char> ReadExp(System.Text.StringBuilder builder);
                /*0x1e37190*/ System.Nullable<char> ConsumeDigits(System.Text.StringBuilder builder, ref int count);
                /*0x1e36264*/ void ValidateAndModifyStateForValue(string errorPrefix);
                /*0x1e36368*/ void PopContainer();

                enum ContainerType
                {
                    Document = 0,
                    Object = 1,
                    Array = 2,
                }

                enum State
                {
                    StartOfDocument = 1,
                    ExpectedEndOfDocument = 2,
                    ReaderExhausted = 4,
                    ObjectStart = 8,
                    ObjectBeforeColon = 16,
                    ObjectAfterColon = 32,
                    ObjectAfterProperty = 64,
                    ObjectAfterComma = 128,
                    ArrayStart = 256,
                    ArrayAfterValue = 512,
                    ArrayAfterComma = 1024,
                }

                class PushBackReader
                {
                    /*0x10*/ System.IO.TextReader reader;
                    /*0x18*/ System.Nullable<char> nextChar;

                    /*0x1e35654*/ PushBackReader(System.IO.TextReader reader);
                    /*0x1e35ef0*/ System.Nullable<char> Read();
                    /*0x1e36968*/ char ReadOrFail(string messageOnFailure);
                    /*0x1e36d58*/ void PushBack(char c);
                    /*0x1e36904*/ Google.Protobuf.InvalidJsonException CreateException(string message);
                }
            }
        }

        class LimitedInputStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream proxied;
            /*0x30*/ int bytesLeft;

            /*0x1e372c4*/ LimitedInputStream(System.IO.Stream proxied, int size);
            /*0x1e37338*/ bool get_CanRead();
            /*0x1e37340*/ bool get_CanSeek();
            /*0x1e37348*/ bool get_CanWrite();
            /*0x1e37350*/ void Flush();
            /*0x1e37354*/ long get_Length();
            /*0x1e37394*/ long get_Position();
            /*0x1e373d4*/ void set_Position(long value);
            /*0x1e37414*/ int Read(byte[] buffer, int offset, int count);
            /*0x1e374dc*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x1e3751c*/ void SetLength(long value);
            /*0x1e3755c*/ void Write(byte[] buffer, int offset, int count);
        }

        class MessageExtensions
        {
            static /*0x1e3759c*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data);
            static /*0x1e37724*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data, int offset, int length);
            static /*0x1e260c0*/ void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data);
            static /*0x1e37a18*/ void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input);
            static /*0x1e37ba4*/ void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<byte> span);
            static /*0x1e37cbc*/ void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input);
            static /*0x1e37de4*/ byte[] ToByteArray(Google.Protobuf.IMessage message);
            static /*0x1e37f8c*/ void WriteTo(Google.Protobuf.IMessage message, System.IO.Stream output);
            static /*0x1e380f0*/ void WriteDelimitedTo(Google.Protobuf.IMessage message, System.IO.Stream output);
            static /*0x1e2601c*/ Google.Protobuf.ByteString ToByteString(Google.Protobuf.IMessage message);
            static /*0x1e382bc*/ void WriteTo(Google.Protobuf.IMessage message, System.Buffers.IBufferWriter<byte> output);
            static /*0x1e38648*/ void WriteTo(Google.Protobuf.IMessage message, System.Span<byte> output);
            static /*0x1e389a8*/ bool IsInitialized(Google.Protobuf.IMessage message);
            static /*0x1e375a8*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x1e37730*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x1e378bc*/ void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x1e37a24*/ void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x1e38c20*/ void MergeFrom(Google.Protobuf.IMessage message, System.Buffers.ReadOnlySequence<byte> data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x1e37bb0*/ void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<byte> data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x1e37cc8*/ void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);

            class <>c__DisplayClass12_0
            {
                /*0x10*/ Google.Protobuf.IMessage message;

                /*0x1e38c18*/ <>c__DisplayClass12_0();
                /*0x1e38f00*/ bool <IsInitialized>b__0(Google.Protobuf.Reflection.FieldDescriptor f);
            }
        }

        class MessageParser
        {
            /*0x10*/ System.Func<Google.Protobuf.IMessage> factory;
            /*0x18*/ bool <DiscardUnknownFields>k__BackingField;
            /*0x20*/ Google.Protobuf.ExtensionRegistry <Extensions>k__BackingField;

            /*0x1e39418*/ MessageParser(System.Func<Google.Protobuf.IMessage> factory, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions);
            /*0x1e39408*/ bool get_DiscardUnknownFields();
            /*0x1e39410*/ Google.Protobuf.ExtensionRegistry get_Extensions();
            /*0x1e25ff8*/ Google.Protobuf.IMessage CreateTemplate();
            /*0x1e39458*/ Google.Protobuf.IMessage ParseFrom(byte[] data);
            /*0x1e394a8*/ Google.Protobuf.IMessage ParseFrom(byte[] data, int offset, int length);
            /*0x1e260cc*/ Google.Protobuf.IMessage ParseFrom(Google.Protobuf.ByteString data);
            /*0x1e39510*/ Google.Protobuf.IMessage ParseFrom(System.IO.Stream input);
            /*0x1e39560*/ Google.Protobuf.IMessage ParseFrom(System.Buffers.ReadOnlySequence<byte> data);
            /*0x1e395c8*/ Google.Protobuf.IMessage ParseFrom(System.ReadOnlySpan<byte> data);
            /*0x1e39620*/ Google.Protobuf.IMessage ParseDelimitedFrom(System.IO.Stream input);
            /*0x1e39670*/ Google.Protobuf.IMessage ParseFrom(Google.Protobuf.CodedInputStream input);
            /*0x1e397ec*/ Google.Protobuf.IMessage ParseJson(string json);
            /*0x1e396c0*/ void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.CodedInputStream codedInput);
            /*0x1e398bc*/ Google.Protobuf.MessageParser WithDiscardUnknownFields(bool discardUnknownFields);
            /*0x1e39940*/ Google.Protobuf.MessageParser WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry);
        }

        class MessageParser<T> : Google.Protobuf.MessageParser
        {
            /*0x0*/ System.Func<T> factory;

            MessageParser(System.Func<T> factory);
            MessageParser(System.Func<T> factory, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions);
            T CreateTemplate();
            T ParseFrom(byte[] data);
            T ParseFrom(byte[] data, int offset, int length);
            T ParseFrom(Google.Protobuf.ByteString data);
            T ParseFrom(System.IO.Stream input);
            T ParseFrom(System.Buffers.ReadOnlySequence<byte> data);
            T ParseFrom(System.ReadOnlySpan<byte> data);
            T ParseDelimitedFrom(System.IO.Stream input);
            T ParseFrom(Google.Protobuf.CodedInputStream input);
            T ParseJson(string json);
            Google.Protobuf.MessageParser<T> WithDiscardUnknownFields(bool discardUnknownFields);
            Google.Protobuf.MessageParser<T> WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry);

            class <>c__DisplayClass2_0<T>
            {
                /*0x0*/ System.Func<T> factory;

                <>c__DisplayClass2_0();
                Google.Protobuf.IMessage <.ctor>b__0();
            }
        }

        struct ObjectIntPair<T> : System.IEquatable<Google.Protobuf.ObjectIntPair<T>>
        {
            /*0x0*/ int number;
            /*0x0*/ T obj;

            ObjectIntPair(T obj, int number);
            bool Equals(Google.Protobuf.ObjectIntPair<T> other);
            bool Equals(object obj);
            int GetHashCode();
        }

        struct ParseContext
        {
            static int DefaultRecursionLimit = 100;
            static int DefaultSizeLimit = 2147483647;
            /*0x10*/ System.ReadOnlySpan<byte> buffer;
            /*0x20*/ Google.Protobuf.ParserInternalState state;

            static /*0x1e399c0*/ void Initialize(System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParseContext ctx);
            static /*0x1e39a44*/ void Initialize(System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, ref Google.Protobuf.ParseContext ctx);
            static /*0x1e39a68*/ void Initialize(Google.Protobuf.CodedInputStream input, ref Google.Protobuf.ParseContext ctx);
            static /*0x1e39adc*/ void Initialize(System.Buffers.ReadOnlySequence<byte> input, ref Google.Protobuf.ParseContext ctx);
            static /*0x1e39d1c*/ void Initialize(System.Buffers.ReadOnlySequence<byte> input, int recursionLimit, ref Google.Protobuf.ParseContext ctx);
            /*0x1e39f54*/ uint get_LastTag();
            /*0x1e39f5c*/ bool get_DiscardUnknownFields();
            /*0x1e38eec*/ void set_DiscardUnknownFields(bool value);
            /*0x1e39f64*/ Google.Protobuf.ExtensionRegistry get_ExtensionRegistry();
            /*0x1e38ef8*/ void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value);
            /*0x1e39f6c*/ uint ReadTag();
            /*0x1e39f74*/ double ReadDouble();
            /*0x1e39f7c*/ float ReadFloat();
            /*0x1e39f84*/ ulong ReadUInt64();
            /*0x1e39f8c*/ long ReadInt64();
            /*0x1e39f94*/ int ReadInt32();
            /*0x1e39f9c*/ ulong ReadFixed64();
            /*0x1e39fa4*/ uint ReadFixed32();
            /*0x1e39fac*/ bool ReadBool();
            /*0x1e39fc8*/ string ReadString();
            /*0x1e39ff8*/ void ReadMessage(Google.Protobuf.IMessage message);
            /*0x1e3a060*/ void ReadGroup(Google.Protobuf.IMessage message);
            /*0x1e3a0c8*/ Google.Protobuf.ByteString ReadBytes();
            /*0x1e3a144*/ uint ReadUInt32();
            /*0x1e3a14c*/ int ReadEnum();
            /*0x1e3a154*/ int ReadSFixed32();
            /*0x1e3a15c*/ long ReadSFixed64();
            /*0x1e3a164*/ int ReadSInt32();
            /*0x1e3a184*/ long ReadSInt64();
            /*0x1e3a1a4*/ int ReadLength();
            /*0x1e3a1ac*/ void CopyStateTo(Google.Protobuf.CodedInputStream input);
            /*0x1e3a1d4*/ void LoadStateFrom(Google.Protobuf.CodedInputStream input);
        }

        struct ParserInternalState
        {
            /*0x10*/ int bufferPos;
            /*0x14*/ int bufferSize;
            /*0x18*/ int bufferSizeAfterLimit;
            /*0x1c*/ int currentLimit;
            /*0x20*/ int totalBytesRetired;
            /*0x24*/ int recursionDepth;
            /*0x28*/ Google.Protobuf.SegmentedBufferHelper segmentedBufferHelper;
            /*0x70*/ uint lastTag;
            /*0x74*/ uint nextTag;
            /*0x78*/ bool hasNextTag;
            /*0x7c*/ int sizeLimit;
            /*0x80*/ int recursionLimit;
            /*0x84*/ bool <DiscardUnknownFields>k__BackingField;
            /*0x88*/ Google.Protobuf.ExtensionRegistry <ExtensionRegistry>k__BackingField;

            /*0x1e3a1f8*/ Google.Protobuf.CodedInputStream get_CodedInputStream();
            /*0x1e3a200*/ bool get_DiscardUnknownFields();
            /*0x1e3a208*/ void set_DiscardUnknownFields(bool value);
            /*0x1e3a214*/ Google.Protobuf.ExtensionRegistry get_ExtensionRegistry();
            /*0x1e3a21c*/ void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value);
        }

        class ParsingPrimitives
        {
            static int StackallocThreshold = 256;

            static /*0x1e3a224*/ int ParseLength(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1b96c*/ uint ParseTag(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1c66c*/ bool MaybeConsumeTag(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, uint tag);
            static /*0x1e1b8bc*/ uint PeekTag(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1c904*/ ulong ParseRawVarint64(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3a228*/ ulong ParseRawVarint64SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1c6c8*/ uint ParseRawVarint32(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3a308*/ uint ParseRawVarint32SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1c9bc*/ uint ParseRawLittleEndian32(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3a40c*/ uint ParseRawLittleEndian32SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1cb30*/ ulong ParseRawLittleEndian64(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3a474*/ ulong ParseRawLittleEndian64SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1bc28*/ double ParseDouble(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1bdc4*/ float ParseFloat(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3a53c*/ float ParseFloatSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1ce68*/ byte[] ReadRawBytes(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x1e3a674*/ byte[] ReadRawBytesSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x1e1d058*/ void SkipRawBytes(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x1e3ae84*/ string ReadString(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3af50*/ Google.Protobuf.ByteString ReadBytes(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3aeb0*/ string ReadRawString(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int length);
            static /*0x1e3afd4*/ string ReadStringSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int length);
            static /*0x1e3ab98*/ void ValidateCurrentLimit(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x1e3a2a4*/ byte ReadRawByte(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e1c844*/ uint ReadRawVarint32(System.IO.Stream input);
            static /*0x1e1c544*/ int DecodeZigZag32(uint n);
            static /*0x1e1c570*/ long DecodeZigZag64(ulong n);
            static /*0x1e3b084*/ bool IsDataAvailable(ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x1e3abe8*/ bool IsDataAvailableInSource(ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x1e3acc0*/ void ReadRawBytesIntoSpan(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int length, System.Span<byte> byteSpan);
        }

        class ParsingPrimitivesMessages
        {
            static /*0x0*/ byte[] ZeroLengthMessageStreamData;

            static /*0x1e3cb18*/ ParsingPrimitivesMessages();
            static /*0x1e3c0a0*/ void SkipLastField(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3c238*/ void SkipGroup(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, uint startGroupTag);
            static /*0x1e3c3dc*/ void ReadMessage(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.IMessage message);
            static System.Collections.Generic.KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
            static /*0x1e3c8f4*/ void ReadGroup(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.IMessage message);
            static /*0x1e3ca00*/ void ReadGroup(ref Google.Protobuf.ParseContext ctx, int fieldNumber, Google.Protobuf.UnknownFieldSet set);
            static /*0x1e3c5a4*/ void ReadRawMessage(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.IMessage message);
            static /*0x1e3c858*/ void CheckReadEndOfStreamTag(ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3c9c4*/ void CheckLastTagWas(ref Google.Protobuf.ParserInternalState state, uint expectedTag);
        }

        class ParsingPrimitivesWrappers
        {
            static /*0x1e3cb80*/ System.Nullable<float> ReadFloatWrapperLittleEndian(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3cc74*/ System.Nullable<float> ReadFloatWrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3cd84*/ System.Nullable<double> ReadDoubleWrapperLittleEndian(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3ce78*/ System.Nullable<double> ReadDoubleWrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3cf90*/ System.Nullable<bool> ReadBoolWrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d140*/ System.Nullable<uint> ReadUInt32Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d258*/ System.Nullable<uint> ReadUInt32WrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d360*/ System.Nullable<int> ReadInt32Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d028*/ System.Nullable<ulong> ReadUInt64Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d3f8*/ System.Nullable<ulong> ReadUInt64WrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d508*/ System.Nullable<long> ReadInt64Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3d59c*/ System.Nullable<float> ReadFloatWrapperLittleEndian(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5a4*/ System.Nullable<float> ReadFloatWrapperSlow(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5ac*/ System.Nullable<double> ReadDoubleWrapperLittleEndian(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5b4*/ System.Nullable<double> ReadDoubleWrapperSlow(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5bc*/ System.Nullable<bool> ReadBoolWrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5d4*/ System.Nullable<uint> ReadUInt32Wrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5dc*/ System.Nullable<int> ReadInt32Wrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5e4*/ System.Nullable<ulong> ReadUInt64Wrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5ec*/ System.Nullable<ulong> ReadUInt64WrapperSlow(ref Google.Protobuf.ParseContext ctx);
            static /*0x1e3d5f4*/ System.Nullable<long> ReadInt64Wrapper(ref Google.Protobuf.ParseContext ctx);
        }

        class ProtoPreconditions
        {
            static T CheckNotNull<T>(T value, string name);
            static T CheckNotNullUnconstrained<T>(T value, string name);
        }

        struct SegmentedBufferHelper
        {
            /*0x10*/ System.Nullable<int> totalLength;
            /*0x18*/ System.Buffers.ReadOnlySequence.Enumerator<byte> readOnlySequenceEnumerator;
            /*0x50*/ Google.Protobuf.CodedInputStream codedInputStream;

            static /*0x1e3d5fc*/ void Initialize(Google.Protobuf.CodedInputStream codedInputStream, ref Google.Protobuf.SegmentedBufferHelper instance);
            static /*0x1e3d698*/ void Initialize(System.Buffers.ReadOnlySequence<byte> sequence, ref Google.Protobuf.SegmentedBufferHelper instance, ref System.ReadOnlySpan<byte> firstSpan);
            static /*0x1e3c51c*/ int PushLimit(ref Google.Protobuf.ParserInternalState state, int byteLimit);
            static /*0x1e3c8c0*/ void PopLimit(ref Google.Protobuf.ParserInternalState state, int oldLimit);
            static /*0x1e3c890*/ bool IsReachedLimit(ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3dbbc*/ bool IsAtEnd(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3db8c*/ void RecomputeBufferSizeAfterLimit(ref Google.Protobuf.ParserInternalState state);
            static /*0x1e3dbf8*/ void CheckCurrentBufferIsEmpty(ref Google.Protobuf.ParserInternalState state);
            /*0x1e3d874*/ bool RefillBuffer(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, bool mustSucceed);
            /*0x1e3db7c*/ System.Nullable<int> get_TotalLength();
            /*0x1e3db84*/ Google.Protobuf.CodedInputStream get_CodedInputStream();
            /*0x1e3d9fc*/ bool RefillFromReadOnlySequence(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, bool mustSucceed);
            /*0x1e3d88c*/ bool RefillFromCodedInputStream(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, bool mustSucceed);
        }

        class UnknownField
        {
            /*0x10*/ System.Collections.Generic.List<ulong> varintList;
            /*0x18*/ System.Collections.Generic.List<uint> fixed32List;
            /*0x20*/ System.Collections.Generic.List<ulong> fixed64List;
            /*0x28*/ System.Collections.Generic.List<Google.Protobuf.ByteString> lengthDelimitedList;
            /*0x30*/ System.Collections.Generic.List<Google.Protobuf.UnknownFieldSet> groupList;

            static System.Collections.Generic.List<T> AddAll<T>(System.Collections.Generic.List<T> current, System.Collections.Generic.IList<T> extras);
            static System.Collections.Generic.List<T> Add<T>(System.Collections.Generic.List<T> list, T value);
            /*0x1e3dc5c*/ UnknownField();
            /*0x1e3dc64*/ bool Equals(object other);
            /*0x1e3dd94*/ int GetHashCode();
            /*0x1e3de9c*/ void WriteTo(int fieldNumber, ref Google.Protobuf.WriteContext output);
            /*0x1e3e94c*/ int GetSerializedSize(int fieldNumber);
            /*0x1e3f160*/ Google.Protobuf.UnknownField MergeFrom(Google.Protobuf.UnknownField other);
            /*0x1e3f260*/ Google.Protobuf.UnknownField AddVarint(ulong value);
            /*0x1e3f2c4*/ Google.Protobuf.UnknownField AddFixed32(uint value);
            /*0x1e3f328*/ Google.Protobuf.UnknownField AddFixed64(ulong value);
            /*0x1e3f38c*/ Google.Protobuf.UnknownField AddLengthDelimited(Google.Protobuf.ByteString value);
            /*0x1e3f3f0*/ Google.Protobuf.UnknownField AddGroup(Google.Protobuf.UnknownFieldSet value);
        }

        class UnknownFieldSet
        {
            /*0x10*/ System.Collections.Generic.IDictionary<int, Google.Protobuf.UnknownField> fields;
            /*0x18*/ int lastFieldNumber;
            /*0x20*/ Google.Protobuf.UnknownField lastField;

            static /*0x1e4039c*/ Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.CodedInputStream input);
            static /*0x1e404cc*/ Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, ref Google.Protobuf.ParseContext ctx);
            static /*0x1e40998*/ Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.UnknownFieldSet other);
            static /*0x1e40a0c*/ Google.Protobuf.UnknownFieldSet Clone(Google.Protobuf.UnknownFieldSet other);
            /*0x1e3f454*/ UnknownFieldSet();
            /*0x1e3f4d4*/ bool HasField(int field);
            /*0x1e3f580*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x1e3e644*/ void WriteTo(ref Google.Protobuf.WriteContext ctx);
            /*0x1e3ee58*/ int CalculateSize();
            /*0x1e3f6e4*/ bool Equals(object other);
            /*0x1e3fbcc*/ int GetHashCode();
            /*0x1e3ff08*/ Google.Protobuf.UnknownField GetOrAddField(int number);
            /*0x1e4003c*/ Google.Protobuf.UnknownFieldSet AddOrReplaceField(int number, Google.Protobuf.UnknownField field);
            /*0x1e40164*/ bool MergeFieldFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x1e3cad4*/ void MergeGroupFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x1e405d4*/ Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet other);
            /*0x1e408d8*/ Google.Protobuf.UnknownFieldSet MergeField(int number, Google.Protobuf.UnknownField field);
        }

        class UnsafeByteOperations
        {
            static /*0x1e40a80*/ Google.Protobuf.ByteString UnsafeWrap(System.ReadOnlyMemory<byte> bytes);
        }

        class WireFormat
        {
            static int TagTypeBits = 3;
            static uint TagTypeMask = 7;

            static /*0x1e3c230*/ Google.Protobuf.WireFormat.WireType GetTagWireType(uint tag);
            static /*0x1e3c3d4*/ int GetTagFieldNumber(uint tag);
            static /*0x1e3c9bc*/ uint MakeTag(int fieldNumber, Google.Protobuf.WireFormat.WireType wireType);

            enum WireType
            {
                Varint = 0,
                Fixed64 = 1,
                LengthDelimited = 2,
                StartGroup = 3,
                EndGroup = 4,
                Fixed32 = 5,
            }
        }

        struct WriteBufferHelper
        {
            /*0x10*/ System.Buffers.IBufferWriter<byte> bufferWriter;
            /*0x18*/ Google.Protobuf.CodedOutputStream codedOutputStream;

            static /*0x1e40af0*/ void Initialize(Google.Protobuf.CodedOutputStream codedOutputStream, ref Google.Protobuf.WriteBufferHelper instance);
            static /*0x1e40af8*/ void Initialize(System.Buffers.IBufferWriter<byte> bufferWriter, ref Google.Protobuf.WriteBufferHelper instance, ref System.Span<byte> buffer);
            static /*0x1e40b04*/ void InitializeNonRefreshable(ref Google.Protobuf.WriteBufferHelper instance);
            static /*0x1e40b0c*/ void CheckNoSpaceLeft(ref Google.Protobuf.WriterInternalState state);
            static /*0x1e40bc8*/ int GetSpaceLeft(ref Google.Protobuf.WriterInternalState state);
            static /*0x1e40c40*/ void RefreshBuffer(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state);
            static /*0x1e40de8*/ void Flush(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state);
            /*0x1e40ae8*/ Google.Protobuf.CodedOutputStream get_CodedOutputStream();
        }

        struct WriteContext
        {
            /*0x10*/ System.Span<byte> buffer;
            /*0x20*/ Google.Protobuf.WriterInternalState state;

            static /*0x1e40ed8*/ void Initialize(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ref Google.Protobuf.WriteContext ctx);
            static /*0x1e40ef4*/ void Initialize(Google.Protobuf.CodedOutputStream output, ref Google.Protobuf.WriteContext ctx);
            static /*0x1e40fa4*/ void Initialize(System.Buffers.IBufferWriter<byte> output, ref Google.Protobuf.WriteContext ctx);
            static /*0x1e40fec*/ void Initialize(ref System.Span<byte> buffer, ref Google.Protobuf.WriteContext ctx);
            /*0x1e41044*/ void WriteDouble(double value);
            /*0x1e4114c*/ void WriteFloat(float value);
            /*0x1e3e494*/ void WriteUInt64(ulong value);
            /*0x1e41398*/ void WriteInt64(long value);
            /*0x1e41470*/ void WriteInt32(int value);
            /*0x1e3e56c*/ void WriteFixed64(ulong value);
            /*0x1e3e500*/ void WriteFixed32(uint value);
            /*0x1e41644*/ void WriteBool(bool value);
            /*0x1e41720*/ void WriteString(string value);
            /*0x1e41974*/ void WriteMessage(Google.Protobuf.IMessage value);
            /*0x1e41ce0*/ void WriteGroup(Google.Protobuf.IMessage value);
            /*0x1e3e5d8*/ void WriteBytes(Google.Protobuf.ByteString value);
            /*0x1e4203c*/ void WriteUInt32(uint value);
            /*0x1e42114*/ void WriteEnum(int value);
            /*0x1e421ec*/ void WriteSFixed32(int value);
            /*0x1e422c4*/ void WriteSFixed64(long value);
            /*0x1e4239c*/ void WriteSInt32(int value);
            /*0x1e42478*/ void WriteSInt64(long value);
            /*0x1e42554*/ void WriteLength(int length);
            /*0x1e3e420*/ void WriteTag(int fieldNumber, Google.Protobuf.WireFormat.WireType type);
            /*0x1e426a8*/ void WriteTag(uint tag);
            /*0x1e42780*/ void WriteRawTag(byte b1);
            /*0x1e42858*/ void WriteRawTag(byte b1, byte b2);
            /*0x1e429b0*/ void WriteRawTag(byte b1, byte b2, byte b3);
            /*0x1e42b4c*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4);
            /*0x1e42d18*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5);
            /*0x1e42f28*/ void Flush();
            /*0x1e4300c*/ void CheckNoSpaceLeft();
            /*0x1e430c8*/ void CopyStateTo(Google.Protobuf.CodedOutputStream output);
            /*0x1e430fc*/ void LoadStateFrom(Google.Protobuf.CodedOutputStream output);
        }

        struct WriterInternalState
        {
            /*0x10*/ int limit;
            /*0x14*/ int position;
            /*0x18*/ Google.Protobuf.WriteBufferHelper writeBufferHelper;

            /*0x1e43130*/ Google.Protobuf.CodedOutputStream get_CodedOutputStream();
        }

        class WritingPrimitives
        {
            static /*0x0*/ System.Text.Encoding Utf8Encoding;

            static /*0x1e445cc*/ WritingPrimitives();
            static /*0x1e410b0*/ void WriteDouble(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, double value);
            static /*0x1e411b8*/ void WriteFloat(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, float value);
            static /*0x1e43304*/ void WriteFloatSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, float value);
            static /*0x1e4132c*/ void WriteUInt64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x1e41404*/ void WriteInt64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, long value);
            static /*0x1e414dc*/ void WriteInt32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x1e4156c*/ void WriteFixed64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x1e415d8*/ void WriteFixed32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x1e416b0*/ void WriteBool(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, bool value);
            static /*0x1e4178c*/ void WriteString(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, string value);
            static /*0x1e43a7c*/ void WriteAsciiStringToBuffer(System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, string value, int length);
            static /*0x1e43d98*/ void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value);
            static /*0x1e43928*/ int WriteStringToBuffer(System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, string value);
            static /*0x1e41f94*/ void WriteBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, Google.Protobuf.ByteString value);
            static /*0x1e420a8*/ void WriteUInt32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x1e42180*/ void WriteEnum(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x1e42258*/ void WriteSFixed32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x1e42330*/ void WriteSFixed64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, long value);
            static /*0x1e42408*/ void WriteSInt32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x1e424e4*/ void WriteSInt64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, long value);
            static /*0x1e425c0*/ void WriteLength(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int length);
            static /*0x1e43634*/ void WriteRawVarint32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x1e43504*/ void WriteRawVarint64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x1e43764*/ void WriteRawLittleEndian32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x1e440d8*/ void WriteRawLittleEndian32SlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x1e43138*/ void WriteRawLittleEndian64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x1e44174*/ void WriteRawLittleEndian64SlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x1e4347c*/ void WriteRawByte(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte value);
            static /*0x1e43d08*/ void WriteRawBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte[] value);
            static /*0x1e44250*/ void WriteRawBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte[] value, int offset, int length);
            static /*0x1e43e3c*/ void WriteRawBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, System.ReadOnlySpan<byte> value);
            static /*0x1e4262c*/ void WriteTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int fieldNumber, Google.Protobuf.WireFormat.WireType type);
            static /*0x1e42714*/ void WriteTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint tag);
            static /*0x1e427ec*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1);
            static /*0x1e428cc*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2);
            static /*0x1e44324*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2);
            static /*0x1e42a34*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3);
            static /*0x1e443ac*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3);
            static /*0x1e42bd8*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4);
            static /*0x1e44448*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4);
            static /*0x1e42db4*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5);
            static /*0x1e44500*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5);
            static /*0x1e440c0*/ uint EncodeZigZag32(int n);
            static /*0x1e440cc*/ ulong EncodeZigZag64(long n);
        }

        class WritingPrimitivesMessages
        {
            static /*0x1e4461c*/ void WriteMessage(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.IMessage value);
            static /*0x1e44990*/ void WriteGroup(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.IMessage value);
            static /*0x1e44c44*/ void WriteRawMessage(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.IMessage message);
        }

        namespace WellKnownTypes
        {
            class AnyReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e44f50*/ AnyReflection();
                static /*0x1e44ef8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Any : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Any>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Any>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Any>, Google.Protobuf.IBufferMessage
            {
                static int TypeUrlFieldNumber = 1;
                static int ValueFieldNumber = 2;
                static string DefaultPrefix = "type.googleapis.com";
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string typeUrl_;
                /*0x20*/ Google.Protobuf.ByteString value_;

                static /*0x1e46104*/ Any();
                static /*0x1e453d4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> get_Parser();
                static /*0x1e4542c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x1e45cf0*/ string GetTypeUrl(Google.Protobuf.Reflection.MessageDescriptor descriptor, string prefix);
                static /*0x1e45d7c*/ string GetTypeName(string typeUrl);
                static /*0x1e45ef4*/ Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message);
                static /*0x1e45f60*/ Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message, string typeUrlPrefix);
                /*0x1e4557c*/ Any();
                /*0x1e45638*/ Any(Google.Protobuf.WellKnownTypes.Any other);
                /*0x1e45530*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e45674*/ Google.Protobuf.WellKnownTypes.Any Clone();
                /*0x1e456d4*/ string get_TypeUrl();
                /*0x1e456dc*/ void set_TypeUrl(string value);
                /*0x1e45750*/ Google.Protobuf.ByteString get_Value();
                /*0x1e45758*/ void set_Value(Google.Protobuf.ByteString value);
                /*0x1e457cc*/ bool Equals(object other);
                /*0x1e45830*/ bool Equals(Google.Protobuf.WellKnownTypes.Any other);
                /*0x1e458f0*/ int GetHashCode();
                /*0x1e4597c*/ string ToString();
                /*0x1e459d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e459f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e45a80*/ int CalculateSize();
                /*0x1e45b4c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Any other);
                /*0x1e45bb8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e45bd8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1e45e3c*/ bool Is(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                T Unpack<T>();
                bool TryUnpack<T>(ref T result);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Any.<> <>9;

                    static /*0x1e4620c*/ <>c();
                    /*0x1e46270*/ <>c();
                    /*0x1e46278*/ Google.Protobuf.WellKnownTypes.Any <.cctor>b__40_0();
                }
            }

            class ApiReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e46328*/ ApiReflection();
                static /*0x1e462d0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Api : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Api>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Api>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Api>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int MethodsFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static int VersionFieldNumber = 4;
                static int SourceContextFieldNumber = 5;
                static int MixinsFieldNumber = 6;
                static int SyntaxFieldNumber = 7;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Mixin> _repeated_mixins_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x30*/ string version_;
                /*0x38*/ Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> mixins_;
                /*0x48*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x1e48234*/ Api();
                static /*0x1e470e4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> get_Parser();
                static /*0x1e4713c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e4728c*/ Api();
                /*0x1e473b8*/ Api(Google.Protobuf.WellKnownTypes.Api other);
                /*0x1e47240*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e47504*/ Google.Protobuf.WellKnownTypes.Api Clone();
                /*0x1e47564*/ string get_Name();
                /*0x1e4756c*/ void set_Name(string value);
                /*0x1e475e0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> get_Methods();
                /*0x1e475e8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x1e475f0*/ string get_Version();
                /*0x1e475f8*/ void set_Version(string value);
                /*0x1e4766c*/ Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext();
                /*0x1e47674*/ void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value);
                /*0x1e4767c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> get_Mixins();
                /*0x1e47684*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x1e4768c*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x1e47694*/ bool Equals(object other);
                /*0x1e476f8*/ bool Equals(Google.Protobuf.WellKnownTypes.Api other);
                /*0x1e4782c*/ int GetHashCode();
                /*0x1e47940*/ string ToString();
                /*0x1e47998*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e479b8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e47b78*/ int CalculateSize();
                /*0x1e47d84*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Api other);
                /*0x1e47f64*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e47f84*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Api.<> <>9;

                    static /*0x1e484e8*/ <>c();
                    /*0x1e4854c*/ <>c();
                    /*0x1e48554*/ Google.Protobuf.WellKnownTypes.Api <.cctor>b__57_0();
                }
            }

            class Method : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Method>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Method>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Method>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int RequestTypeUrlFieldNumber = 2;
                static int RequestStreamingFieldNumber = 3;
                static int ResponseTypeUrlFieldNumber = 4;
                static int ResponseStreamingFieldNumber = 5;
                static int OptionsFieldNumber = 6;
                static int SyntaxFieldNumber = 7;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ string requestTypeUrl_;
                /*0x28*/ bool requestStreaming_;
                /*0x30*/ string responseTypeUrl_;
                /*0x38*/ bool responseStreaming_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x48*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x1e49408*/ Method();
                static /*0x1e485ac*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> get_Parser();
                static /*0x1e48604*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e48754*/ Method();
                /*0x1e487f8*/ Method(Google.Protobuf.WellKnownTypes.Method other);
                /*0x1e48708*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e48894*/ Google.Protobuf.WellKnownTypes.Method Clone();
                /*0x1e488f4*/ string get_Name();
                /*0x1e488fc*/ void set_Name(string value);
                /*0x1e48970*/ string get_RequestTypeUrl();
                /*0x1e48978*/ void set_RequestTypeUrl(string value);
                /*0x1e489ec*/ bool get_RequestStreaming();
                /*0x1e489f4*/ void set_RequestStreaming(bool value);
                /*0x1e48a00*/ string get_ResponseTypeUrl();
                /*0x1e48a08*/ void set_ResponseTypeUrl(string value);
                /*0x1e48a7c*/ bool get_ResponseStreaming();
                /*0x1e48a84*/ void set_ResponseStreaming(bool value);
                /*0x1e48a90*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x1e48a98*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x1e48aa0*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x1e48aa8*/ bool Equals(object other);
                /*0x1e48b0c*/ bool Equals(Google.Protobuf.WellKnownTypes.Method other);
                /*0x1e48c28*/ int GetHashCode();
                /*0x1e48d44*/ string ToString();
                /*0x1e48d9c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e48dbc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e48f48*/ int CalculateSize();
                /*0x1e490f0*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Method other);
                /*0x1e491cc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e491ec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Method.<> <>9;

                    static /*0x1e495a4*/ <>c();
                    /*0x1e49608*/ <>c();
                    /*0x1e49610*/ Google.Protobuf.WellKnownTypes.Method <.cctor>b__57_0();
                }
            }

            class Mixin : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Mixin>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Mixin>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Mixin>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int RootFieldNumber = 2;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ string root_;

                static /*0x1e49e5c*/ Mixin();
                static /*0x1e49668*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> get_Parser();
                static /*0x1e496c0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e49810*/ Mixin();
                /*0x1e49860*/ Mixin(Google.Protobuf.WellKnownTypes.Mixin other);
                /*0x1e497c4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e4989c*/ Google.Protobuf.WellKnownTypes.Mixin Clone();
                /*0x1e498fc*/ string get_Name();
                /*0x1e49904*/ void set_Name(string value);
                /*0x1e49978*/ string get_Root();
                /*0x1e49980*/ void set_Root(string value);
                /*0x1e499f4*/ bool Equals(object other);
                /*0x1e49a58*/ bool Equals(Google.Protobuf.WellKnownTypes.Mixin other);
                /*0x1e49acc*/ int GetHashCode();
                /*0x1e49b4c*/ string ToString();
                /*0x1e49ba4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e49bc4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e49c4c*/ int CalculateSize();
                /*0x1e49d18*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Mixin other);
                /*0x1e49d7c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e49d9c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Mixin.<> <>9;

                    static /*0x1e49f64*/ <>c();
                    /*0x1e49fc8*/ <>c();
                    /*0x1e49fd0*/ Google.Protobuf.WellKnownTypes.Mixin <.cctor>b__32_0();
                }
            }

            class DurationReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e4a080*/ DurationReflection();
                static /*0x1e4a028*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Duration : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Duration>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Duration>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Duration>, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage
            {
                static int SecondsFieldNumber = 1;
                static int NanosFieldNumber = 2;
                static int NanosecondsPerSecond = 1000000000;
                static int NanosecondsPerTick = 100;
                static long MaxSeconds = 315576000000;
                static long MinSeconds = -315576000000;
                static int MaxNanoseconds = 999999999;
                static int MinNanoseconds = -999999999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ long seconds_;
                /*0x20*/ int nanos_;

                static /*0x1e4b790*/ Duration();
                static /*0x1e4a544*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> get_Parser();
                static /*0x1e4a59c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x1e4ab6c*/ bool IsNormalized(long seconds, int nanoseconds);
                static /*0x1e4adb0*/ Google.Protobuf.WellKnownTypes.Duration FromTimeSpan(System.TimeSpan timeSpan);
                static /*0x1e4ae7c*/ Google.Protobuf.WellKnownTypes.Duration op_UnaryNegation(Google.Protobuf.WellKnownTypes.Duration value);
                static /*0x1e4b024*/ Google.Protobuf.WellKnownTypes.Duration op_Addition(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x1e4b15c*/ Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x1e4af5c*/ Google.Protobuf.WellKnownTypes.Duration Normalize(long seconds, int nanoseconds);
                static /*0x1e4b29c*/ string ToJson(long seconds, int nanoseconds, bool diagnosticOnly);
                static /*0x1e4b5c0*/ void AppendNanoseconds(System.Text.StringBuilder builder, int nanos);
                /*0x1e4a6ec*/ Duration();
                /*0x1e4a6f4*/ Duration(Google.Protobuf.WellKnownTypes.Duration other);
                /*0x1e4a6a0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e4a73c*/ Google.Protobuf.WellKnownTypes.Duration Clone();
                /*0x1e4a79c*/ long get_Seconds();
                /*0x1e4a7a4*/ void set_Seconds(long value);
                /*0x1e4a7ac*/ int get_Nanos();
                /*0x1e4a7b4*/ void set_Nanos(int value);
                /*0x1e4a7bc*/ bool Equals(object other);
                /*0x1e4a820*/ bool Equals(Google.Protobuf.WellKnownTypes.Duration other);
                /*0x1e4a86c*/ int GetHashCode();
                /*0x1e4a8ec*/ string ToString();
                /*0x1e4a944*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e4a964*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e4a9d8*/ int CalculateSize();
                /*0x1e4aa88*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Duration other);
                /*0x1e4aac4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e4aae4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1e4ac2c*/ System.TimeSpan ToTimeSpan();
                /*0x1e4b72c*/ string ToDiagnosticString();

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Duration.<> <>9;

                    static /*0x1e4b898*/ <>c();
                    /*0x1e4b8fc*/ <>c();
                    /*0x1e4b904*/ Google.Protobuf.WellKnownTypes.Duration <.cctor>b__48_0();
                }
            }

            class EmptyReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e4b9b8*/ EmptyReflection();
                static /*0x1e4b960*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Empty : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Empty>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Empty>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Empty>, Google.Protobuf.IBufferMessage
            {
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                static /*0x1e4c1f0*/ Empty();
                static /*0x1e4bda4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> get_Parser();
                static /*0x1e4bdfc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e4bf4c*/ Empty();
                /*0x1e4bf54*/ Empty(Google.Protobuf.WellKnownTypes.Empty other);
                /*0x1e4bf00*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e4bf8c*/ Google.Protobuf.WellKnownTypes.Empty Clone();
                /*0x1e4bfec*/ bool Equals(object other);
                /*0x1e4c070*/ bool Equals(Google.Protobuf.WellKnownTypes.Empty other);
                /*0x1e4c09c*/ int GetHashCode();
                /*0x1e4c0c8*/ string ToString();
                /*0x1e4c120*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e4c140*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e4c150*/ int CalculateSize();
                /*0x1e4c160*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Empty other);
                /*0x1e4c184*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e4c1a4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Empty.<> <>9;

                    static /*0x1e4c2f8*/ <>c();
                    /*0x1e4c35c*/ <>c();
                    /*0x1e4c364*/ Google.Protobuf.WellKnownTypes.Empty <.cctor>b__22_0();
                }
            }

            class FieldMaskReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e4c418*/ FieldMaskReflection();
                static /*0x1e4c3c0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class FieldMask : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.FieldMask>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.FieldMask>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.FieldMask>, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage
            {
                static int PathsFieldNumber = 1;
                static char FIELD_PATH_SEPARATOR = 44;
                static char FIELD_SEPARATOR_REGEX = 46;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<string> _repeated_paths_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<string> paths_;

                static /*0x1e4de9c*/ FieldMask();
                static /*0x1e4c85c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> get_Parser();
                static /*0x1e4c8b4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x1e4cfd4*/ string ToJson(System.Collections.Generic.IList<string> paths, bool diagnosticOnly);
                static /*0x1e4d3bc*/ Google.Protobuf.WellKnownTypes.FieldMask FromString(string value);
                static Google.Protobuf.WellKnownTypes.FieldMask FromString<T>(string value);
                static Google.Protobuf.WellKnownTypes.FieldMask FromStringEnumerable<T>(System.Collections.Generic.IEnumerable<string> paths);
                static Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers<T>(int[] fieldNumbers);
                static Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers<T>(System.Collections.Generic.IEnumerable<int> fieldNumbers);
                static /*0x1e4d4cc*/ bool IsPathValid(string input);
                static bool IsValid<T>(Google.Protobuf.WellKnownTypes.FieldMask fieldMask);
                static /*0x1e4d57c*/ bool IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, Google.Protobuf.WellKnownTypes.FieldMask fieldMask);
                static bool IsValid<T>(string path);
                static /*0x1e4d860*/ bool IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, string path);
                /*0x1e4ca04*/ FieldMask();
                /*0x1e4ca80*/ FieldMask(Google.Protobuf.WellKnownTypes.FieldMask other);
                /*0x1e4c9b8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e4caf4*/ Google.Protobuf.WellKnownTypes.FieldMask Clone();
                /*0x1e4cb54*/ Google.Protobuf.Collections.RepeatedField<string> get_Paths();
                /*0x1e4cb5c*/ bool Equals(object other);
                /*0x1e4cbc0*/ bool Equals(Google.Protobuf.WellKnownTypes.FieldMask other);
                /*0x1e4cc50*/ int GetHashCode();
                /*0x1e4cc9c*/ string ToString();
                /*0x1e4ccf4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e4cd14*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e4cdc8*/ int CalculateSize();
                /*0x1e4ce6c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.FieldMask other);
                /*0x1e4cedc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e4cefc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1e4d360*/ string ToDiagnosticString();
                /*0x1e4d97c*/ Google.Protobuf.WellKnownTypes.FieldMask Normalize();
                /*0x1e4d9e4*/ Google.Protobuf.WellKnownTypes.FieldMask Union(Google.Protobuf.WellKnownTypes.FieldMask[] otherMasks);
                /*0x1e4daa0*/ Google.Protobuf.WellKnownTypes.FieldMask Intersection(Google.Protobuf.WellKnownTypes.FieldMask additionalMask);
                /*0x1e4dd88*/ void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options);
                /*0x1e4de18*/ void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination);

                class MergeOptions
                {
                    /*0x10*/ bool <ReplaceMessageFields>k__BackingField;
                    /*0x11*/ bool <ReplaceRepeatedFields>k__BackingField;
                    /*0x12*/ bool <ReplacePrimitiveFields>k__BackingField;

                    /*0x1e4de94*/ MergeOptions();
                    /*0x1e4dfbc*/ bool get_ReplaceMessageFields();
                    /*0x1e4dfc4*/ void set_ReplaceMessageFields(bool value);
                    /*0x1e4dfd0*/ bool get_ReplaceRepeatedFields();
                    /*0x1e4dfd8*/ void set_ReplaceRepeatedFields(bool value);
                    /*0x1e4dfe4*/ bool get_ReplacePrimitiveFields();
                    /*0x1e4dfec*/ void set_ReplacePrimitiveFields(bool value);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.FieldMask.<> <>9;
                    static /*0x8*/ System.Func<string, bool> <>9__29_0;

                    static /*0x1e4dff8*/ <>c();
                    /*0x1e4e05c*/ <>c();
                    /*0x1e4e064*/ bool <ToJson>b__29_0(string p);
                    /*0x1e4e0c4*/ Google.Protobuf.WellKnownTypes.FieldMask <.cctor>b__47_0();
                }
            }

            class SourceContextReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e4e174*/ SourceContextReflection();
                static /*0x1e4e11c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class SourceContext : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.SourceContext>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.SourceContext>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.SourceContext>, Google.Protobuf.IBufferMessage
            {
                static int FileNameFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string fileName_;

                static /*0x1e4eb88*/ SourceContext();
                static /*0x1e4e5f8*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> get_Parser();
                static /*0x1e4e650*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e47ec8*/ SourceContext();
                /*0x1e4e7a0*/ SourceContext(Google.Protobuf.WellKnownTypes.SourceContext other);
                /*0x1e4e754*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e474a4*/ Google.Protobuf.WellKnownTypes.SourceContext Clone();
                /*0x1e4e7dc*/ string get_FileName();
                /*0x1e4e7e4*/ void set_FileName(string value);
                /*0x1e4e858*/ bool Equals(object other);
                /*0x1e4e8bc*/ bool Equals(Google.Protobuf.WellKnownTypes.SourceContext other);
                /*0x1e4e91c*/ int GetHashCode();
                /*0x1e4e97c*/ string ToString();
                /*0x1e4e9d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e4e9f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e4ea54*/ int CalculateSize();
                /*0x1e47f18*/ void MergeFrom(Google.Protobuf.WellKnownTypes.SourceContext other);
                /*0x1e4eae4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e4eb04*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.SourceContext.<> <>9;

                    static /*0x1e4ec90*/ <>c();
                    /*0x1e4ecf4*/ <>c();
                    /*0x1e4ecfc*/ Google.Protobuf.WellKnownTypes.SourceContext <.cctor>b__27_0();
                }
            }

            class StructReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e4edac*/ StructReflection();
                static /*0x1e4ed54*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            enum NullValue
            {
                NullValue = 0,
            }

            class Struct : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Struct>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Struct>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Struct>, Google.Protobuf.IBufferMessage
            {
                static int FieldsFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> _parser;
                static /*0x8*/ Google.Protobuf.Collections.MapField.Codec<string, Google.Protobuf.WellKnownTypes.Value> _map_fields_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.MapField<string, Google.Protobuf.WellKnownTypes.Value> fields_;

                static /*0x1e50068*/ Struct();
                static /*0x1e4f8f0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> get_Parser();
                static /*0x1e4f948*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e4fa98*/ Struct();
                /*0x1e4fb14*/ Struct(Google.Protobuf.WellKnownTypes.Struct other);
                /*0x1e4fa4c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e4fb88*/ Google.Protobuf.WellKnownTypes.Struct Clone();
                /*0x1e4fbe8*/ Google.Protobuf.Collections.MapField<string, Google.Protobuf.WellKnownTypes.Value> get_Fields();
                /*0x1e4fbf0*/ bool Equals(object other);
                /*0x1e4fc54*/ bool Equals(Google.Protobuf.WellKnownTypes.Struct other);
                /*0x1e4fce4*/ int GetHashCode();
                /*0x1e4fd30*/ string ToString();
                /*0x1e4fd88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e4fda8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e4fe5c*/ int CalculateSize();
                /*0x1e4ff00*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Struct other);
                /*0x1e4ff70*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e4ff90*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Struct.<> <>9;

                    static /*0x1e50284*/ <>c();
                    /*0x1e502e8*/ <>c();
                    /*0x1e502f0*/ Google.Protobuf.WellKnownTypes.Struct <.cctor>b__27_0();
                }
            }

            class Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Value>, Google.Protobuf.IBufferMessage
            {
                static int NullValueFieldNumber = 1;
                static int NumberValueFieldNumber = 2;
                static int StringValueFieldNumber = 3;
                static int BoolValueFieldNumber = 4;
                static int StructValueFieldNumber = 5;
                static int ListValueFieldNumber = 6;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ object kind_;
                /*0x20*/ Google.Protobuf.WellKnownTypes.Value.KindOneofCase kindCase_;

                static /*0x1e51be0*/ Value();
                static /*0x1e50348*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> get_Parser();
                static /*0x1e503a0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x1e5183c*/ Google.Protobuf.WellKnownTypes.Value ForString(string value);
                static /*0x1e518e8*/ Google.Protobuf.WellKnownTypes.Value ForNumber(double value);
                static /*0x1e5195c*/ Google.Protobuf.WellKnownTypes.Value ForBool(bool value);
                static /*0x1e519c8*/ Google.Protobuf.WellKnownTypes.Value ForNull();
                static /*0x1e51a30*/ Google.Protobuf.WellKnownTypes.Value ForList(Google.Protobuf.WellKnownTypes.Value[] values);
                static /*0x1e51b2c*/ Google.Protobuf.WellKnownTypes.Value ForStruct(Google.Protobuf.WellKnownTypes.Struct value);
                /*0x1e504f0*/ Value();
                /*0x1e504f8*/ Value(Google.Protobuf.WellKnownTypes.Value other);
                /*0x1e504a4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e50b4c*/ Google.Protobuf.WellKnownTypes.Value Clone();
                /*0x1e50600*/ Google.Protobuf.WellKnownTypes.NullValue get_NullValue();
                /*0x1e50684*/ void set_NullValue(Google.Protobuf.WellKnownTypes.NullValue value);
                /*0x1e506ec*/ double get_NumberValue();
                /*0x1e5076c*/ void set_NumberValue(double value);
                /*0x1e507d4*/ string get_StringValue();
                /*0x1e50854*/ void set_StringValue(string value);
                /*0x1e508d0*/ bool get_BoolValue();
                /*0x1e5095c*/ void set_BoolValue(bool value);
                /*0x1e509c4*/ Google.Protobuf.WellKnownTypes.Struct get_StructValue();
                /*0x1e50a30*/ void set_StructValue(Google.Protobuf.WellKnownTypes.Struct value);
                /*0x1e50a58*/ Google.Protobuf.WellKnownTypes.ListValue get_ListValue();
                /*0x1e50b24*/ void set_ListValue(Google.Protobuf.WellKnownTypes.ListValue value);
                /*0x1e50bac*/ Google.Protobuf.WellKnownTypes.Value.KindOneofCase get_KindCase();
                /*0x1e50bb4*/ void ClearKind();
                /*0x1e50bc0*/ bool Equals(object other);
                /*0x1e50c24*/ bool Equals(Google.Protobuf.WellKnownTypes.Value other);
                /*0x1e50df4*/ int GetHashCode();
                /*0x1e50fb8*/ string ToString();
                /*0x1e51010*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e51030*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e51168*/ int CalculateSize();
                /*0x1e512e8*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Value other);
                /*0x1e51574*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e51594*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                enum KindOneofCase
                {
                    None = 0,
                    NullValue = 1,
                    NumberValue = 2,
                    StringValue = 3,
                    BoolValue = 4,
                    StructValue = 5,
                    ListValue = 6,
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Value.<> <>9;

                    static /*0x1e51ce8*/ <>c();
                    /*0x1e51d4c*/ <>c();
                    /*0x1e51d54*/ Google.Protobuf.WellKnownTypes.Value <.cctor>b__58_0();
                }
            }

            class ListValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.ListValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.ListValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.ListValue>, Google.Protobuf.IBufferMessage
            {
                static int ValuesFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_;

                static /*0x1e523dc*/ ListValue();
                static /*0x1e51db0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> get_Parser();
                static /*0x1e51e08*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e51488*/ ListValue();
                /*0x1e51f58*/ ListValue(Google.Protobuf.WellKnownTypes.ListValue other);
                /*0x1e51f0c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e50ac4*/ Google.Protobuf.WellKnownTypes.ListValue Clone();
                /*0x1e51fcc*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> get_Values();
                /*0x1e51fd4*/ bool Equals(object other);
                /*0x1e52038*/ bool Equals(Google.Protobuf.WellKnownTypes.ListValue other);
                /*0x1e520c8*/ int GetHashCode();
                /*0x1e52114*/ string ToString();
                /*0x1e5216c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5218c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e52240*/ int CalculateSize();
                /*0x1e51504*/ void MergeFrom(Google.Protobuf.WellKnownTypes.ListValue other);
                /*0x1e522e4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e52304*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.ListValue.<> <>9;

                    static /*0x1e52578*/ <>c();
                    /*0x1e525dc*/ <>c();
                    /*0x1e525e4*/ Google.Protobuf.WellKnownTypes.ListValue <.cctor>b__27_0();
                }
            }

            class TimeExtensions
            {
                static /*0x1e5263c*/ Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTime dateTime);
                static /*0x1e527f0*/ Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTimeOffset dateTimeOffset);
                static /*0x1e528c8*/ Google.Protobuf.WellKnownTypes.Duration ToDuration(System.TimeSpan timeSpan);
            }

            class TimestampReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e52974*/ TimestampReflection();
                static /*0x1e5291c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Timestamp : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Timestamp>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Timestamp>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Timestamp>, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage, System.IComparable<Google.Protobuf.WellKnownTypes.Timestamp>
            {
                static int SecondsFieldNumber = 1;
                static int NanosFieldNumber = 2;
                static long BclSecondsAtUnixEpoch = 62135596800;
                static long UnixSecondsAtBclMaxValue = 253402300799;
                static long UnixSecondsAtBclMinValue = -62135596800;
                static int MaxNanos = 999999999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> _parser;
                static /*0x8*/ System.DateTime UnixEpoch;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ long seconds_;
                /*0x20*/ int nanos_;

                static /*0x1e540e8*/ Timestamp();
                static /*0x1e52e38*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> get_Parser();
                static /*0x1e52e90*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x1e534d8*/ bool IsNormalized(long seconds, int nanoseconds);
                static /*0x1e53518*/ Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Timestamp rhs);
                static /*0x1e53658*/ Google.Protobuf.WellKnownTypes.Timestamp op_Addition(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x1e53858*/ Google.Protobuf.WellKnownTypes.Timestamp op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x1e52690*/ Google.Protobuf.WellKnownTypes.Timestamp FromDateTime(System.DateTime dateTime);
                static /*0x1e52854*/ Google.Protobuf.WellKnownTypes.Timestamp FromDateTimeOffset(System.DateTimeOffset dateTimeOffset);
                static /*0x1e537a0*/ Google.Protobuf.WellKnownTypes.Timestamp Normalize(long seconds, int nanoseconds);
                static /*0x1e53b7c*/ string ToJson(long seconds, int nanoseconds, bool diagnosticOnly);
                static /*0x1e53f78*/ bool op_LessThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x1e53f94*/ bool op_GreaterThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x1e53fb4*/ bool op_LessThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x1e53fd4*/ bool op_GreaterThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x1e5340c*/ bool op_Equality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x1e53ff4*/ bool op_Inequality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                /*0x1e52fe0*/ Timestamp();
                /*0x1e52fe8*/ Timestamp(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x1e52f94*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e53030*/ Google.Protobuf.WellKnownTypes.Timestamp Clone();
                /*0x1e53090*/ long get_Seconds();
                /*0x1e53098*/ void set_Seconds(long value);
                /*0x1e530a0*/ int get_Nanos();
                /*0x1e530a8*/ void set_Nanos(int value);
                /*0x1e530b0*/ bool Equals(object other);
                /*0x1e53114*/ bool Equals(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x1e53160*/ int GetHashCode();
                /*0x1e531e0*/ string ToString();
                /*0x1e53238*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e53258*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e532cc*/ int CalculateSize();
                /*0x1e5337c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x1e53430*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e53450*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1e539a8*/ System.DateTime ToDateTime();
                /*0x1e53af0*/ System.DateTimeOffset ToDateTimeOffset();
                /*0x1e53ed8*/ int CompareTo(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x1e54084*/ string ToDiagnosticString();

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Timestamp.<> <>9;

                    static /*0x1e54230*/ <>c();
                    /*0x1e54294*/ <>c();
                    /*0x1e5429c*/ Google.Protobuf.WellKnownTypes.Timestamp <.cctor>b__55_0();
                }
            }

            class TypeReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e54350*/ TypeReflection();
                static /*0x1e542f8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            enum Syntax
            {
                Proto2 = 0,
                Proto3 = 1,
            }

            class Type : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Type>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Type>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Type>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int FieldsFieldNumber = 2;
                static int OneofsFieldNumber = 3;
                static int OptionsFieldNumber = 4;
                static int SourceContextFieldNumber = 5;
                static int SyntaxFieldNumber = 6;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec;
                static /*0x10*/ Google.Protobuf.FieldCodec<string> _repeated_oneofs_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<string> oneofs_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x38*/ Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
                /*0x40*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x1e569f8*/ Type();
                static /*0x1e55b40*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> get_Parser();
                static /*0x1e55b98*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e55ce8*/ Type();
                /*0x1e55e10*/ Type(Google.Protobuf.WellKnownTypes.Type other);
                /*0x1e55c9c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e55ef4*/ Google.Protobuf.WellKnownTypes.Type Clone();
                /*0x1e55f54*/ string get_Name();
                /*0x1e55f5c*/ void set_Name(string value);
                /*0x1e55fd0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> get_Fields();
                /*0x1e55fd8*/ Google.Protobuf.Collections.RepeatedField<string> get_Oneofs();
                /*0x1e55fe0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x1e55fe8*/ Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext();
                /*0x1e55ff0*/ void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value);
                /*0x1e55ff8*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x1e56000*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x1e56008*/ bool Equals(object other);
                /*0x1e5606c*/ bool Equals(Google.Protobuf.WellKnownTypes.Type other);
                /*0x1e5618c*/ int GetHashCode();
                /*0x1e56284*/ string ToString();
                /*0x1e562dc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e562fc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e56480*/ int CalculateSize();
                /*0x1e56640*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Type other);
                /*0x1e5676c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5678c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Type.<> <>9;

                    static /*0x1e56c38*/ <>c();
                    /*0x1e56c9c*/ <>c();
                    /*0x1e56ca4*/ Google.Protobuf.WellKnownTypes.Type <.cctor>b__52_0();
                }
            }

            class Field : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Field>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Field>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Field>, Google.Protobuf.IBufferMessage
            {
                static int KindFieldNumber = 1;
                static int CardinalityFieldNumber = 2;
                static int NumberFieldNumber = 3;
                static int NameFieldNumber = 4;
                static int TypeUrlFieldNumber = 6;
                static int OneofIndexFieldNumber = 7;
                static int PackedFieldNumber = 8;
                static int OptionsFieldNumber = 9;
                static int JsonNameFieldNumber = 10;
                static int DefaultValueFieldNumber = 11;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.WellKnownTypes.Field.Types.Kind kind_;
                /*0x1c*/ Google.Protobuf.WellKnownTypes.Field.Types.Cardinality cardinality_;
                /*0x20*/ int number_;
                /*0x28*/ string name_;
                /*0x30*/ string typeUrl_;
                /*0x38*/ int oneofIndex_;
                /*0x3c*/ bool packed_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x48*/ string jsonName_;
                /*0x50*/ string defaultValue_;

                static /*0x1e57e44*/ Field();
                static /*0x1e56cfc*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> get_Parser();
                static /*0x1e56d54*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e56ea4*/ Field();
                /*0x1e56f4c*/ Field(Google.Protobuf.WellKnownTypes.Field other);
                /*0x1e56e58*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e56ff0*/ Google.Protobuf.WellKnownTypes.Field Clone();
                /*0x1e57050*/ Google.Protobuf.WellKnownTypes.Field.Types.Kind get_Kind();
                /*0x1e57058*/ void set_Kind(Google.Protobuf.WellKnownTypes.Field.Types.Kind value);
                /*0x1e57060*/ Google.Protobuf.WellKnownTypes.Field.Types.Cardinality get_Cardinality();
                /*0x1e57068*/ void set_Cardinality(Google.Protobuf.WellKnownTypes.Field.Types.Cardinality value);
                /*0x1e57070*/ int get_Number();
                /*0x1e57078*/ void set_Number(int value);
                /*0x1e57080*/ string get_Name();
                /*0x1e57088*/ void set_Name(string value);
                /*0x1e570fc*/ string get_TypeUrl();
                /*0x1e57104*/ void set_TypeUrl(string value);
                /*0x1e57178*/ int get_OneofIndex();
                /*0x1e57180*/ void set_OneofIndex(int value);
                /*0x1e57188*/ bool get_Packed();
                /*0x1e57190*/ void set_Packed(bool value);
                /*0x1e5719c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x1e571a4*/ string get_JsonName();
                /*0x1e571ac*/ void set_JsonName(string value);
                /*0x1e57220*/ string get_DefaultValue();
                /*0x1e57228*/ void set_DefaultValue(string value);
                /*0x1e5729c*/ bool Equals(object other);
                /*0x1e57300*/ bool Equals(Google.Protobuf.WellKnownTypes.Field other);
                /*0x1e57440*/ int GetHashCode();
                /*0x1e575bc*/ string ToString();
                /*0x1e57614*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e57634*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e57828*/ int CalculateSize();
                /*0x1e57a80*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Field other);
                /*0x1e57b8c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e57bac*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    enum Kind
                    {
                        TypeUnknown = 0,
                        TypeDouble = 1,
                        TypeFloat = 2,
                        TypeInt64 = 3,
                        TypeUint64 = 4,
                        TypeInt32 = 5,
                        TypeFixed64 = 6,
                        TypeFixed32 = 7,
                        TypeBool = 8,
                        TypeString = 9,
                        TypeGroup = 10,
                        TypeMessage = 11,
                        TypeBytes = 12,
                        TypeUint32 = 13,
                        TypeEnum = 14,
                        TypeSfixed32 = 15,
                        TypeSfixed64 = 16,
                        TypeSint32 = 17,
                        TypeSint64 = 18,
                    }

                    enum Cardinality
                    {
                        Unknown = 0,
                        Optional = 1,
                        Required = 2,
                        Repeated = 3,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Field.<> <>9;

                    static /*0x1e58fe0*/ <>c();
                    /*0x1e59044*/ <>c();
                    /*0x1e5904c*/ Google.Protobuf.WellKnownTypes.Field <.cctor>b__73_0();
                }
            }

            class Enum : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Enum>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Enum>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Enum>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int EnumvalueFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static int SourceContextFieldNumber = 4;
                static int SyntaxFieldNumber = 5;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.EnumValue> _repeated_enumvalue_codec;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> enumvalue_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x30*/ Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
                /*0x38*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x1e59df8*/ Enum();
                static /*0x1e590a8*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> get_Parser();
                static /*0x1e59100*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e59250*/ Enum();
                /*0x1e59334*/ Enum(Google.Protobuf.WellKnownTypes.Enum other);
                /*0x1e59204*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e593f8*/ Google.Protobuf.WellKnownTypes.Enum Clone();
                /*0x1e59458*/ string get_Name();
                /*0x1e59460*/ void set_Name(string value);
                /*0x1e594d4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> get_Enumvalue();
                /*0x1e594dc*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x1e594e4*/ Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext();
                /*0x1e594ec*/ void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value);
                /*0x1e594f4*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x1e594fc*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x1e59504*/ bool Equals(object other);
                /*0x1e59568*/ bool Equals(Google.Protobuf.WellKnownTypes.Enum other);
                /*0x1e5965c*/ int GetHashCode();
                /*0x1e5972c*/ string ToString();
                /*0x1e59784*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e597a4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e59910*/ int CalculateSize();
                /*0x1e59a98*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Enum other);
                /*0x1e59ba8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e59bc8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Enum.<> <>9;

                    static /*0x1e5a020*/ <>c();
                    /*0x1e5a084*/ <>c();
                    /*0x1e5a08c*/ Google.Protobuf.WellKnownTypes.Enum <.cctor>b__47_0();
                }
            }

            class EnumValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.EnumValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.EnumValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.EnumValue>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int NumberFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ int number_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;

                static /*0x1e5ab04*/ EnumValue();
                static /*0x1e5a0e4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> get_Parser();
                static /*0x1e5a13c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5a28c*/ EnumValue();
                /*0x1e5a32c*/ EnumValue(Google.Protobuf.WellKnownTypes.EnumValue other);
                /*0x1e5a240*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5a3b4*/ Google.Protobuf.WellKnownTypes.EnumValue Clone();
                /*0x1e5a414*/ string get_Name();
                /*0x1e5a41c*/ void set_Name(string value);
                /*0x1e5a490*/ int get_Number();
                /*0x1e5a498*/ void set_Number(int value);
                /*0x1e5a4a0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x1e5a4a8*/ bool Equals(object other);
                /*0x1e5a50c*/ bool Equals(Google.Protobuf.WellKnownTypes.EnumValue other);
                /*0x1e5a5c0*/ int GetHashCode();
                /*0x1e5a65c*/ string ToString();
                /*0x1e5a6b4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5a6d4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5a7e4*/ int CalculateSize();
                /*0x1e5a90c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.EnumValue other);
                /*0x1e5a9a4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5a9c4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.EnumValue.<> <>9;

                    static /*0x1e5aca0*/ <>c();
                    /*0x1e5ad04*/ <>c();
                    /*0x1e5ad0c*/ Google.Protobuf.WellKnownTypes.EnumValue <.cctor>b__37_0();
                }
            }

            class Option : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Option>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Option>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Option>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int ValueFieldNumber = 2;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.WellKnownTypes.Any value_;

                static /*0x1e5b5d4*/ Option();
                static /*0x1e5ad64*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> get_Parser();
                static /*0x1e5adbc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5af0c*/ Option();
                /*0x1e5af5c*/ Option(Google.Protobuf.WellKnownTypes.Option other);
                /*0x1e5aec0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5afb0*/ Google.Protobuf.WellKnownTypes.Option Clone();
                /*0x1e5b010*/ string get_Name();
                /*0x1e5b018*/ void set_Name(string value);
                /*0x1e5b08c*/ Google.Protobuf.WellKnownTypes.Any get_Value();
                /*0x1e5b094*/ void set_Value(Google.Protobuf.WellKnownTypes.Any value);
                /*0x1e5b09c*/ bool Equals(object other);
                /*0x1e5b100*/ bool Equals(Google.Protobuf.WellKnownTypes.Option other);
                /*0x1e5b174*/ int GetHashCode();
                /*0x1e5b1ec*/ string ToString();
                /*0x1e5b244*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5b264*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5b2f8*/ int CalculateSize();
                /*0x1e5b3c0*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Option other);
                /*0x1e5b474*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5b494*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Option.<> <>9;

                    static /*0x1e5b6dc*/ <>c();
                    /*0x1e5b740*/ <>c();
                    /*0x1e5b748*/ Google.Protobuf.WellKnownTypes.Option <.cctor>b__32_0();
                }
            }

            class WrappersReflection
            {
                static int WrapperValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e5b7f8*/ WrappersReflection();
                static /*0x1e5b7a0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class DoubleValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.DoubleValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.DoubleValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.DoubleValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ double value_;

                static /*0x1e5cd04*/ DoubleValue();
                static /*0x1e5c6a4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> get_Parser();
                static /*0x1e5c6fc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5c84c*/ DoubleValue();
                /*0x1e5c854*/ DoubleValue(Google.Protobuf.WellKnownTypes.DoubleValue other);
                /*0x1e5c800*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5c898*/ Google.Protobuf.WellKnownTypes.DoubleValue Clone();
                /*0x1e5c8f8*/ double get_Value();
                /*0x1e5c900*/ void set_Value(double value);
                /*0x1e5c908*/ bool Equals(object other);
                /*0x1e5c96c*/ bool Equals(Google.Protobuf.WellKnownTypes.DoubleValue other);
                /*0x1e5ca58*/ int GetHashCode();
                /*0x1e5cb30*/ string ToString();
                /*0x1e5cb88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5cba8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5cc0c*/ int CalculateSize();
                /*0x1e5cc40*/ void MergeFrom(Google.Protobuf.WellKnownTypes.DoubleValue other);
                /*0x1e5cc78*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5cc98*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.DoubleValue.<> <>9;

                    static /*0x1e5ce0c*/ <>c();
                    /*0x1e5ce70*/ <>c();
                    /*0x1e5ce78*/ Google.Protobuf.WellKnownTypes.DoubleValue <.cctor>b__27_0();
                }
            }

            class FloatValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.FloatValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.FloatValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.FloatValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ float value_;

                static /*0x1e5d534*/ FloatValue();
                static /*0x1e5ced4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> get_Parser();
                static /*0x1e5cf2c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5d07c*/ FloatValue();
                /*0x1e5d084*/ FloatValue(Google.Protobuf.WellKnownTypes.FloatValue other);
                /*0x1e5d030*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5d0c8*/ Google.Protobuf.WellKnownTypes.FloatValue Clone();
                /*0x1e5d128*/ float get_Value();
                /*0x1e5d130*/ void set_Value(float value);
                /*0x1e5d138*/ bool Equals(object other);
                /*0x1e5d19c*/ bool Equals(Google.Protobuf.WellKnownTypes.FloatValue other);
                /*0x1e5d288*/ int GetHashCode();
                /*0x1e5d360*/ string ToString();
                /*0x1e5d3b8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5d3d8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5d43c*/ int CalculateSize();
                /*0x1e5d470*/ void MergeFrom(Google.Protobuf.WellKnownTypes.FloatValue other);
                /*0x1e5d4a8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5d4c8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.FloatValue.<> <>9;

                    static /*0x1e5d63c*/ <>c();
                    /*0x1e5d6a0*/ <>c();
                    /*0x1e5d6a8*/ Google.Protobuf.WellKnownTypes.FloatValue <.cctor>b__27_0();
                }
            }

            class Int64Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Int64Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Int64Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Int64Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ long value_;

                static /*0x1e5dc7c*/ Int64Value();
                static /*0x1e5d704*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> get_Parser();
                static /*0x1e5d75c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5d8ac*/ Int64Value();
                /*0x1e5d8b4*/ Int64Value(Google.Protobuf.WellKnownTypes.Int64Value other);
                /*0x1e5d860*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5d8f8*/ Google.Protobuf.WellKnownTypes.Int64Value Clone();
                /*0x1e5d958*/ long get_Value();
                /*0x1e5d960*/ void set_Value(long value);
                /*0x1e5d968*/ bool Equals(object other);
                /*0x1e5d9cc*/ bool Equals(Google.Protobuf.WellKnownTypes.Int64Value other);
                /*0x1e5da08*/ int GetHashCode();
                /*0x1e5da64*/ string ToString();
                /*0x1e5dabc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5dadc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5db3c*/ int CalculateSize();
                /*0x1e5dbbc*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Int64Value other);
                /*0x1e5dbf0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5dc10*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Int64Value.<> <>9;

                    static /*0x1e5dd84*/ <>c();
                    /*0x1e5dde8*/ <>c();
                    /*0x1e5ddf0*/ Google.Protobuf.WellKnownTypes.Int64Value <.cctor>b__27_0();
                }
            }

            class UInt64Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.UInt64Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.UInt64Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.UInt64Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ ulong value_;

                static /*0x1e5e3c4*/ UInt64Value();
                static /*0x1e5de4c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> get_Parser();
                static /*0x1e5dea4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5dff4*/ UInt64Value();
                /*0x1e5dffc*/ UInt64Value(Google.Protobuf.WellKnownTypes.UInt64Value other);
                /*0x1e5dfa8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5e040*/ Google.Protobuf.WellKnownTypes.UInt64Value Clone();
                /*0x1e5e0a0*/ ulong get_Value();
                /*0x1e5e0a8*/ void set_Value(ulong value);
                /*0x1e5e0b0*/ bool Equals(object other);
                /*0x1e5e114*/ bool Equals(Google.Protobuf.WellKnownTypes.UInt64Value other);
                /*0x1e5e150*/ int GetHashCode();
                /*0x1e5e1ac*/ string ToString();
                /*0x1e5e204*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5e224*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5e284*/ int CalculateSize();
                /*0x1e5e304*/ void MergeFrom(Google.Protobuf.WellKnownTypes.UInt64Value other);
                /*0x1e5e338*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5e358*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.UInt64Value.<> <>9;

                    static /*0x1e5e4cc*/ <>c();
                    /*0x1e5e530*/ <>c();
                    /*0x1e5e538*/ Google.Protobuf.WellKnownTypes.UInt64Value <.cctor>b__27_0();
                }
            }

            class Int32Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Int32Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Int32Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Int32Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int value_;

                static /*0x1e5eb0c*/ Int32Value();
                static /*0x1e5e594*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> get_Parser();
                static /*0x1e5e5ec*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5e73c*/ Int32Value();
                /*0x1e5e744*/ Int32Value(Google.Protobuf.WellKnownTypes.Int32Value other);
                /*0x1e5e6f0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5e788*/ Google.Protobuf.WellKnownTypes.Int32Value Clone();
                /*0x1e5e7e8*/ int get_Value();
                /*0x1e5e7f0*/ void set_Value(int value);
                /*0x1e5e7f8*/ bool Equals(object other);
                /*0x1e5e85c*/ bool Equals(Google.Protobuf.WellKnownTypes.Int32Value other);
                /*0x1e5e898*/ int GetHashCode();
                /*0x1e5e8f4*/ string ToString();
                /*0x1e5e94c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5e96c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5e9cc*/ int CalculateSize();
                /*0x1e5ea4c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Int32Value other);
                /*0x1e5ea80*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5eaa0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Int32Value.<> <>9;

                    static /*0x1e5ec14*/ <>c();
                    /*0x1e5ec78*/ <>c();
                    /*0x1e5ec80*/ Google.Protobuf.WellKnownTypes.Int32Value <.cctor>b__27_0();
                }
            }

            class UInt32Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.UInt32Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.UInt32Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.UInt32Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ uint value_;

                static /*0x1e5f254*/ UInt32Value();
                static /*0x1e5ecdc*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> get_Parser();
                static /*0x1e5ed34*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5ee84*/ UInt32Value();
                /*0x1e5ee8c*/ UInt32Value(Google.Protobuf.WellKnownTypes.UInt32Value other);
                /*0x1e5ee38*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5eed0*/ Google.Protobuf.WellKnownTypes.UInt32Value Clone();
                /*0x1e5ef30*/ uint get_Value();
                /*0x1e5ef38*/ void set_Value(uint value);
                /*0x1e5ef40*/ bool Equals(object other);
                /*0x1e5efa4*/ bool Equals(Google.Protobuf.WellKnownTypes.UInt32Value other);
                /*0x1e5efe0*/ int GetHashCode();
                /*0x1e5f03c*/ string ToString();
                /*0x1e5f094*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5f0b4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5f114*/ int CalculateSize();
                /*0x1e5f194*/ void MergeFrom(Google.Protobuf.WellKnownTypes.UInt32Value other);
                /*0x1e5f1c8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5f1e8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.UInt32Value.<> <>9;

                    static /*0x1e5f35c*/ <>c();
                    /*0x1e5f3c0*/ <>c();
                    /*0x1e5f3c8*/ Google.Protobuf.WellKnownTypes.UInt32Value <.cctor>b__27_0();
                }
            }

            class BoolValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.BoolValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.BoolValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.BoolValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ bool value_;

                static /*0x1e5f960*/ BoolValue();
                static /*0x1e5f424*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> get_Parser();
                static /*0x1e5f47c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5f5cc*/ BoolValue();
                /*0x1e5f5d4*/ BoolValue(Google.Protobuf.WellKnownTypes.BoolValue other);
                /*0x1e5f580*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5f618*/ Google.Protobuf.WellKnownTypes.BoolValue Clone();
                /*0x1e5f678*/ bool get_Value();
                /*0x1e5f680*/ void set_Value(bool value);
                /*0x1e5f68c*/ bool Equals(object other);
                /*0x1e5f6f0*/ bool Equals(Google.Protobuf.WellKnownTypes.BoolValue other);
                /*0x1e5f73c*/ int GetHashCode();
                /*0x1e5f794*/ string ToString();
                /*0x1e5f7ec*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5f80c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e5f86c*/ int CalculateSize();
                /*0x1e5f898*/ void MergeFrom(Google.Protobuf.WellKnownTypes.BoolValue other);
                /*0x1e5f8cc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e5f8ec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.BoolValue.<> <>9;

                    static /*0x1e5fa68*/ <>c();
                    /*0x1e5facc*/ <>c();
                    /*0x1e5fad4*/ Google.Protobuf.WellKnownTypes.BoolValue <.cctor>b__27_0();
                }
            }

            class StringValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.StringValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.StringValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.StringValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string value_;

                static /*0x1e601d8*/ StringValue();
                static /*0x1e5fb30*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> get_Parser();
                static /*0x1e5fb88*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e5fcd8*/ StringValue();
                /*0x1e5fd28*/ StringValue(Google.Protobuf.WellKnownTypes.StringValue other);
                /*0x1e5fc8c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e5fd68*/ Google.Protobuf.WellKnownTypes.StringValue Clone();
                /*0x1e5fdc8*/ string get_Value();
                /*0x1e5fdd0*/ void set_Value(string value);
                /*0x1e5fe44*/ bool Equals(object other);
                /*0x1e5fea8*/ bool Equals(Google.Protobuf.WellKnownTypes.StringValue other);
                /*0x1e5ff08*/ int GetHashCode();
                /*0x1e5ff68*/ string ToString();
                /*0x1e5ffc0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e5ffe0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e6004c*/ int CalculateSize();
                /*0x1e600e0*/ void MergeFrom(Google.Protobuf.WellKnownTypes.StringValue other);
                /*0x1e60130*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e60150*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.StringValue.<> <>9;

                    static /*0x1e602e0*/ <>c();
                    /*0x1e60344*/ <>c();
                    /*0x1e6034c*/ Google.Protobuf.WellKnownTypes.StringValue <.cctor>b__27_0();
                }
            }

            class BytesValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.BytesValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.BytesValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.BytesValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ByteString value_;

                static /*0x1e60b58*/ BytesValue();
                static /*0x1e603a4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> get_Parser();
                static /*0x1e603fc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e6054c*/ BytesValue();
                /*0x1e605e4*/ BytesValue(Google.Protobuf.WellKnownTypes.BytesValue other);
                /*0x1e60500*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e60624*/ Google.Protobuf.WellKnownTypes.BytesValue Clone();
                /*0x1e60684*/ Google.Protobuf.ByteString get_Value();
                /*0x1e6068c*/ void set_Value(Google.Protobuf.ByteString value);
                /*0x1e60700*/ bool Equals(object other);
                /*0x1e60764*/ bool Equals(Google.Protobuf.WellKnownTypes.BytesValue other);
                /*0x1e60810*/ int GetHashCode();
                /*0x1e6087c*/ string ToString();
                /*0x1e608d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e608f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e60964*/ int CalculateSize();
                /*0x1e60a00*/ void MergeFrom(Google.Protobuf.WellKnownTypes.BytesValue other);
                /*0x1e60a58*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e60a78*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.BytesValue.<> <>9;

                    static /*0x1e60c60*/ <>c();
                    /*0x1e60cc4*/ <>c();
                    /*0x1e60ccc*/ Google.Protobuf.WellKnownTypes.BytesValue <.cctor>b__27_0();
                }
            }
        }

        namespace Reflection
        {
            class CustomOptions
            {
                static /*0x0*/ object[] EmptyParameters;
                /*0x10*/ System.Collections.Generic.IDictionary<int, Google.Protobuf.IExtensionValue> values;

                static /*0x1e6117c*/ CustomOptions();
                /*0x1e60d24*/ CustomOptions(System.Collections.Generic.IDictionary<int, Google.Protobuf.IExtensionValue> values);
                /*0x1e60d4c*/ bool TryGetBool(int field, ref bool value);
                /*0x1e60dac*/ bool TryGetInt32(int field, ref int value);
                /*0x1e60e0c*/ bool TryGetInt64(int field, ref long value);
                /*0x1e60e6c*/ bool TryGetFixed32(int field, ref uint value);
                /*0x1e60ed0*/ bool TryGetFixed64(int field, ref ulong value);
                /*0x1e60f34*/ bool TryGetSFixed32(int field, ref int value);
                /*0x1e60f38*/ bool TryGetSFixed64(int field, ref long value);
                /*0x1e60f3c*/ bool TryGetSInt32(int field, ref int value);
                /*0x1e60f9c*/ bool TryGetSInt64(int field, ref long value);
                /*0x1e60e70*/ bool TryGetUInt32(int field, ref uint value);
                /*0x1e60ed4*/ bool TryGetUInt64(int field, ref ulong value);
                /*0x1e60ffc*/ bool TryGetFloat(int field, ref float value);
                /*0x1e6105c*/ bool TryGetDouble(int field, ref double value);
                /*0x1e610bc*/ bool TryGetString(int field, ref string value);
                /*0x1e6111c*/ bool TryGetBytes(int field, ref Google.Protobuf.ByteString value);
                bool TryGetMessage<T>(int field, ref T value);
                bool TryGetPrimitiveValue<T>(int field, ref T value);

                class <>c__18<T>
                {
                    static /*0x0*/ Google.Protobuf.Reflection.CustomOptions.<>c__18<T> <>9;
                    static /*0x0*/ System.Func<T, Google.Protobuf.ByteString> <>9__18_0;
                    static /*0x0*/ System.Func<T, Google.Protobuf.ByteString, T> <>9__18_1;

                    static <>c__18();
                    <>c__18();
                    Google.Protobuf.ByteString <TryGetMessage>b__18_0(T v);
                    T <TryGetMessage>b__18_1(T t, Google.Protobuf.ByteString b);
                }
            }

            class DescriptorReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x1e6123c*/ DescriptorReflection();
                static /*0x1e611e4*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class FileDescriptorSet : Google.Protobuf.IMessage<Google.Protobuf.Reflection.FileDescriptorSet>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FileDescriptorSet>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FileDescriptorSet>, Google.Protobuf.IBufferMessage
            {
                static int FileFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FileDescriptorProto> _repeated_file_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> file_;

                static /*0x1e676c8*/ FileDescriptorSet();
                static /*0x1e66f3c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> get_Parser();
                static /*0x1e66f94*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e670e4*/ FileDescriptorSet();
                /*0x1e67160*/ FileDescriptorSet(Google.Protobuf.Reflection.FileDescriptorSet other);
                /*0x1e67098*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e671d8*/ Google.Protobuf.Reflection.FileDescriptorSet Clone();
                /*0x1e67238*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> get_File();
                /*0x1e67240*/ bool Equals(object other);
                /*0x1e672a4*/ bool Equals(Google.Protobuf.Reflection.FileDescriptorSet other);
                /*0x1e67334*/ int GetHashCode();
                /*0x1e67380*/ string ToString();
                /*0x1e673d8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e673f8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e674b0*/ int CalculateSize();
                /*0x1e67558*/ void MergeFrom(Google.Protobuf.Reflection.FileDescriptorSet other);
                /*0x1e675cc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e675ec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileDescriptorSet.<> <>9;

                    static /*0x1e67864*/ <>c();
                    /*0x1e678c8*/ <>c();
                    /*0x1e678d0*/ Google.Protobuf.Reflection.FileDescriptorSet <.cctor>b__27_0();
                }
            }

            class FileDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.FileDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FileDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FileDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int PackageFieldNumber = 2;
                static int DependencyFieldNumber = 3;
                static int PublicDependencyFieldNumber = 10;
                static int WeakDependencyFieldNumber = 11;
                static int MessageTypeFieldNumber = 4;
                static int EnumTypeFieldNumber = 5;
                static int ServiceFieldNumber = 6;
                static int ExtensionFieldNumber = 7;
                static int OptionsFieldNumber = 8;
                static int SourceCodeInfoFieldNumber = 9;
                static int SyntaxFieldNumber = 12;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ string PackageDefaultValue;
                static /*0x18*/ Google.Protobuf.FieldCodec<string> _repeated_dependency_codec;
                static /*0x20*/ Google.Protobuf.FieldCodec<int> _repeated_publicDependency_codec;
                static /*0x28*/ Google.Protobuf.FieldCodec<int> _repeated_weakDependency_codec;
                static /*0x30*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_messageType_codec;
                static /*0x38*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;
                static /*0x40*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.ServiceDescriptorProto> _repeated_service_codec;
                static /*0x48*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;
                static /*0x50*/ string SyntaxDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ string package_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<string> dependency_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<int> publicDependency_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<int> weakDependency_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> messageType_;
                /*0x48*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;
                /*0x50*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> service_;
                /*0x58*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;
                /*0x60*/ Google.Protobuf.Reflection.FileOptions options_;
                /*0x68*/ Google.Protobuf.Reflection.SourceCodeInfo sourceCodeInfo_;
                /*0x70*/ string syntax_;

                static /*0x1e69358*/ FileDescriptorProto();
                static /*0x1e67928*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> get_Parser();
                static /*0x1e67980*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e67ad0*/ FileDescriptorProto();
                /*0x1e67cc4*/ FileDescriptorProto(Google.Protobuf.Reflection.FileDescriptorProto other);
                /*0x1e67a84*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e67e50*/ Google.Protobuf.Reflection.FileDescriptorProto Clone();
                /*0x1e67eb0*/ string get_Name();
                /*0x1e67f14*/ void set_Name(string value);
                /*0x1e67f88*/ bool get_HasName();
                /*0x1e67f98*/ void ClearName();
                /*0x1e67fa0*/ string get_Package();
                /*0x1e68004*/ void set_Package(string value);
                /*0x1e68078*/ bool get_HasPackage();
                /*0x1e68088*/ void ClearPackage();
                /*0x1e68090*/ Google.Protobuf.Collections.RepeatedField<string> get_Dependency();
                /*0x1e68098*/ Google.Protobuf.Collections.RepeatedField<int> get_PublicDependency();
                /*0x1e680a0*/ Google.Protobuf.Collections.RepeatedField<int> get_WeakDependency();
                /*0x1e680a8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_MessageType();
                /*0x1e680b0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType();
                /*0x1e680b8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Service();
                /*0x1e680c0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension();
                /*0x1e680c8*/ Google.Protobuf.Reflection.FileOptions get_Options();
                /*0x1e680d0*/ void set_Options(Google.Protobuf.Reflection.FileOptions value);
                /*0x1e680d8*/ Google.Protobuf.Reflection.SourceCodeInfo get_SourceCodeInfo();
                /*0x1e680e0*/ void set_SourceCodeInfo(Google.Protobuf.Reflection.SourceCodeInfo value);
                /*0x1e680e8*/ string get_Syntax();
                /*0x1e6814c*/ void set_Syntax(string value);
                /*0x1e681c0*/ bool get_HasSyntax();
                /*0x1e681d0*/ void ClearSyntax();
                /*0x1e681d8*/ bool Equals(object other);
                /*0x1e6823c*/ bool Equals(Google.Protobuf.Reflection.FileDescriptorProto other);
                /*0x1e68460*/ int GetHashCode();
                /*0x1e68624*/ string ToString();
                /*0x1e6867c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e6869c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e6896c*/ int CalculateSize();
                /*0x1e68c9c*/ void MergeFrom(Google.Protobuf.Reflection.FileDescriptorProto other);
                /*0x1e68ee0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e68f00*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileDescriptorProto.<> <>9;

                    static /*0x1e69708*/ <>c();
                    /*0x1e6976c*/ <>c();
                    /*0x1e69774*/ Google.Protobuf.Reflection.FileDescriptorProto <.cctor>b__94_0();
                }
            }

            class DescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.DescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.DescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.DescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int FieldFieldNumber = 2;
                static int ExtensionFieldNumber = 6;
                static int NestedTypeFieldNumber = 3;
                static int EnumTypeFieldNumber = 4;
                static int ExtensionRangeFieldNumber = 5;
                static int OneofDeclFieldNumber = 8;
                static int OptionsFieldNumber = 7;
                static int ReservedRangeFieldNumber = 9;
                static int ReservedNameFieldNumber = 10;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_field_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;
                static /*0x20*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_nestedType_codec;
                static /*0x28*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;
                static /*0x30*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec;
                static /*0x38*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.OneofDescriptorProto> _repeated_oneofDecl_codec;
                static /*0x40*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec;
                static /*0x48*/ Google.Protobuf.FieldCodec<string> _repeated_reservedName_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> field_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> nestedType_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> extensionRange_;
                /*0x48*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> oneofDecl_;
                /*0x50*/ Google.Protobuf.Reflection.MessageOptions options_;
                /*0x58*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> reservedRange_;
                /*0x60*/ Google.Protobuf.Collections.RepeatedField<string> reservedName_;

                static /*0x1e6ae2c*/ DescriptorProto();
                static /*0x1e697cc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> get_Parser();
                static /*0x1e69824*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e69974*/ DescriptorProto();
                /*0x1e69bac*/ DescriptorProto(Google.Protobuf.Reflection.DescriptorProto other);
                /*0x1e69928*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e69d44*/ Google.Protobuf.Reflection.DescriptorProto Clone();
                /*0x1e69da4*/ string get_Name();
                /*0x1e69e08*/ void set_Name(string value);
                /*0x1e69e7c*/ bool get_HasName();
                /*0x1e69e8c*/ void ClearName();
                /*0x1e69e94*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Field();
                /*0x1e69e9c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension();
                /*0x1e69ea4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_NestedType();
                /*0x1e69eac*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType();
                /*0x1e69eb4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_ExtensionRange();
                /*0x1e69ebc*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> get_OneofDecl();
                /*0x1e69ec4*/ Google.Protobuf.Reflection.MessageOptions get_Options();
                /*0x1e69ecc*/ void set_Options(Google.Protobuf.Reflection.MessageOptions value);
                /*0x1e69ed4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_ReservedRange();
                /*0x1e69edc*/ Google.Protobuf.Collections.RepeatedField<string> get_ReservedName();
                /*0x1e69ee4*/ bool Equals(object other);
                /*0x1e69f48*/ bool Equals(Google.Protobuf.Reflection.DescriptorProto other);
                /*0x1e6a134*/ int GetHashCode();
                /*0x1e6a2b0*/ string ToString();
                /*0x1e6a308*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e6a328*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e6a5a4*/ int CalculateSize();
                /*0x1e6a878*/ void MergeFrom(Google.Protobuf.Reflection.DescriptorProto other);
                /*0x1e6aa5c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e6aa7c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class ExtensionRange : Google.Protobuf.IMessage<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>, Google.Protobuf.IBufferMessage
                    {
                        static int StartFieldNumber = 1;
                        static int EndFieldNumber = 2;
                        static int OptionsFieldNumber = 3;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _parser;
                        static /*0x8*/ int StartDefaultValue;
                        static /*0xc*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x1c*/ int start_;
                        /*0x20*/ int end_;
                        /*0x28*/ Google.Protobuf.Reflection.ExtensionRangeOptions options_;

                        static /*0x1e6be10*/ ExtensionRange();
                        static /*0x1e6b2ec*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_Parser();
                        static /*0x1e6b344*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x1e6b45c*/ ExtensionRange();
                        /*0x1e6b464*/ ExtensionRange(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other);
                        /*0x1e6b410*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x1e6b520*/ Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange Clone();
                        /*0x1e6b580*/ int get_Start();
                        /*0x1e6b5f0*/ void set_Start(int value);
                        /*0x1e6b600*/ bool get_HasStart();
                        /*0x1e6b60c*/ void ClearStart();
                        /*0x1e6b61c*/ int get_End();
                        /*0x1e6b68c*/ void set_End(int value);
                        /*0x1e6b6a0*/ bool get_HasEnd();
                        /*0x1e6b6ac*/ void ClearEnd();
                        /*0x1e6b6bc*/ Google.Protobuf.Reflection.ExtensionRangeOptions get_Options();
                        /*0x1e6b6c4*/ void set_Options(Google.Protobuf.Reflection.ExtensionRangeOptions value);
                        /*0x1e6b6cc*/ bool Equals(object other);
                        /*0x1e6b730*/ bool Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other);
                        /*0x1e6b7c8*/ int GetHashCode();
                        /*0x1e6b86c*/ string ToString();
                        /*0x1e6b8c4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x1e6b8e4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x1e6b9a4*/ int CalculateSize();
                        /*0x1e6bab0*/ void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other);
                        /*0x1e6bc94*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x1e6bcb4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange.<> <>9;

                            static /*0x1e6bf24*/ <>c();
                            /*0x1e6bf88*/ <>c();
                            /*0x1e6bf90*/ Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange <.cctor>b__46_0();
                        }
                    }

                    class ReservedRange : Google.Protobuf.IMessage<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>, Google.Protobuf.IBufferMessage
                    {
                        static int StartFieldNumber = 1;
                        static int EndFieldNumber = 2;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _parser;
                        static /*0x8*/ int StartDefaultValue;
                        static /*0xc*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x1c*/ int start_;
                        /*0x20*/ int end_;

                        static /*0x1e6c7d8*/ ReservedRange();
                        static /*0x1e6bfec*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_Parser();
                        static /*0x1e6c044*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x1e6c15c*/ ReservedRange();
                        /*0x1e6c164*/ ReservedRange(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other);
                        /*0x1e6c110*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x1e6c1b0*/ Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange Clone();
                        /*0x1e6c210*/ int get_Start();
                        /*0x1e6c280*/ void set_Start(int value);
                        /*0x1e6c290*/ bool get_HasStart();
                        /*0x1e6c29c*/ void ClearStart();
                        /*0x1e6c2ac*/ int get_End();
                        /*0x1e6c31c*/ void set_End(int value);
                        /*0x1e6c330*/ bool get_HasEnd();
                        /*0x1e6c33c*/ void ClearEnd();
                        /*0x1e6c34c*/ bool Equals(object other);
                        /*0x1e6c3b0*/ bool Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other);
                        /*0x1e6c434*/ int GetHashCode();
                        /*0x1e6c4c0*/ string ToString();
                        /*0x1e6c518*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x1e6c538*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x1e6c5d0*/ int CalculateSize();
                        /*0x1e6c6a8*/ void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other);
                        /*0x1e6c718*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x1e6c738*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange.<> <>9;

                            static /*0x1e6c8ec*/ <>c();
                            /*0x1e6c950*/ <>c();
                            /*0x1e6c958*/ Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange <.cctor>b__41_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.DescriptorProto.<> <>9;

                    static /*0x1e6c9b4*/ <>c();
                    /*0x1e6ca18*/ <>c();
                    /*0x1e6ca20*/ Google.Protobuf.Reflection.DescriptorProto <.cctor>b__77_0();
                }
            }

            class ExtensionRangeOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IBufferMessage
            {
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> _extensions;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e6d19c*/ ExtensionRangeOptions();
                static /*0x1e6ca80*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> get_Parser();
                static /*0x1e6cad8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e6bb80*/ ExtensionRangeOptions();
                /*0x1e6cc28*/ ExtensionRangeOptions(Google.Protobuf.Reflection.ExtensionRangeOptions other);
                /*0x1e6ca78*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> get__Extensions();
                /*0x1e6cbdc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e6b4c0*/ Google.Protobuf.Reflection.ExtensionRangeOptions Clone();
                /*0x1e6ccc4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e6cccc*/ bool Equals(object other);
                /*0x1e6cd30*/ bool Equals(Google.Protobuf.Reflection.ExtensionRangeOptions other);
                /*0x1e6cdd4*/ int GetHashCode();
                /*0x1e6ce40*/ string ToString();
                /*0x1e6ce98*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e6ceb8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e6cf98*/ int CalculateSize();
                /*0x1e6bbfc*/ void MergeFrom(Google.Protobuf.Reflection.ExtensionRangeOptions other);
                /*0x1e6d068*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e6d088*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ExtensionRangeOptions.<> <>9;

                    static /*0x1e6d338*/ <>c();
                    /*0x1e6d39c*/ <>c();
                    /*0x1e6d3a4*/ Google.Protobuf.Reflection.ExtensionRangeOptions <.cctor>b__37_0();
                }
            }

            class FieldDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.FieldDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FieldDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FieldDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int NumberFieldNumber = 3;
                static int LabelFieldNumber = 4;
                static int TypeFieldNumber = 5;
                static int TypeNameFieldNumber = 6;
                static int ExtendeeFieldNumber = 2;
                static int DefaultValueFieldNumber = 7;
                static int OneofIndexFieldNumber = 9;
                static int JsonNameFieldNumber = 10;
                static int OptionsFieldNumber = 8;
                static int Proto3OptionalFieldNumber = 17;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ int NumberDefaultValue;
                static /*0x14*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label LabelDefaultValue;
                static /*0x18*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type TypeDefaultValue;
                static /*0x20*/ string TypeNameDefaultValue;
                static /*0x28*/ string ExtendeeDefaultValue;
                static /*0x30*/ string DefaultValueDefaultValue;
                static /*0x38*/ int OneofIndexDefaultValue;
                static /*0x40*/ string JsonNameDefaultValue;
                static /*0x48*/ bool Proto3OptionalDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ string name_;
                /*0x28*/ int number_;
                /*0x2c*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label label_;
                /*0x30*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type_;
                /*0x38*/ string typeName_;
                /*0x40*/ string extendee_;
                /*0x48*/ string defaultValue_;
                /*0x50*/ int oneofIndex_;
                /*0x58*/ string jsonName_;
                /*0x60*/ Google.Protobuf.Reflection.FieldOptions options_;
                /*0x68*/ bool proto3Optional_;

                static /*0x1e6ed34*/ FieldDescriptorProto();
                static /*0x1e6d3fc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> get_Parser();
                static /*0x1e6d454*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e6d5a4*/ FieldDescriptorProto();
                /*0x1e6d5ac*/ FieldDescriptorProto(Google.Protobuf.Reflection.FieldDescriptorProto other);
                /*0x1e6d558*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e6d644*/ Google.Protobuf.Reflection.FieldDescriptorProto Clone();
                /*0x1e6d6a4*/ string get_Name();
                /*0x1e6d708*/ void set_Name(string value);
                /*0x1e6d77c*/ bool get_HasName();
                /*0x1e6d78c*/ void ClearName();
                /*0x1e6d794*/ int get_Number();
                /*0x1e6d804*/ void set_Number(int value);
                /*0x1e6d818*/ bool get_HasNumber();
                /*0x1e6d824*/ void ClearNumber();
                /*0x1e6d834*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label get_Label();
                /*0x1e6d8a4*/ void set_Label(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label value);
                /*0x1e6d8b8*/ bool get_HasLabel();
                /*0x1e6d8c4*/ void ClearLabel();
                /*0x1e6d8d4*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type get_Type();
                /*0x1e6d944*/ void set_Type(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type value);
                /*0x1e6d958*/ bool get_HasType();
                /*0x1e6d964*/ void ClearType();
                /*0x1e6d974*/ string get_TypeName();
                /*0x1e6d9d8*/ void set_TypeName(string value);
                /*0x1e6da4c*/ bool get_HasTypeName();
                /*0x1e6da5c*/ void ClearTypeName();
                /*0x1e6da64*/ string get_Extendee();
                /*0x1e6dac8*/ void set_Extendee(string value);
                /*0x1e6db3c*/ bool get_HasExtendee();
                /*0x1e6db4c*/ void ClearExtendee();
                /*0x1e6db54*/ string get_DefaultValue();
                /*0x1e6dbb8*/ void set_DefaultValue(string value);
                /*0x1e6dc2c*/ bool get_HasDefaultValue();
                /*0x1e6dc3c*/ void ClearDefaultValue();
                /*0x1e6dc44*/ int get_OneofIndex();
                /*0x1e6dcb4*/ void set_OneofIndex(int value);
                /*0x1e6dcc8*/ bool get_HasOneofIndex();
                /*0x1e6dcd4*/ void ClearOneofIndex();
                /*0x1e6dce4*/ string get_JsonName();
                /*0x1e6dd48*/ void set_JsonName(string value);
                /*0x1e6ddbc*/ bool get_HasJsonName();
                /*0x1e6ddcc*/ void ClearJsonName();
                /*0x1e6ddd4*/ Google.Protobuf.Reflection.FieldOptions get_Options();
                /*0x1e6dddc*/ void set_Options(Google.Protobuf.Reflection.FieldOptions value);
                /*0x1e6dde4*/ bool get_Proto3Optional();
                /*0x1e6de54*/ void set_Proto3Optional(bool value);
                /*0x1e6de6c*/ bool get_HasProto3Optional();
                /*0x1e6de78*/ void ClearProto3Optional();
                /*0x1e6de88*/ bool Equals(object other);
                /*0x1e6deec*/ bool Equals(Google.Protobuf.Reflection.FieldDescriptorProto other);
                /*0x1e6e0a0*/ int GetHashCode();
                /*0x1e6e280*/ string ToString();
                /*0x1e6e2d8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e6e2f8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e6e548*/ int CalculateSize();
                /*0x1e6e810*/ void MergeFrom(Google.Protobuf.Reflection.FieldDescriptorProto other);
                /*0x1e6e9e8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e6ea08*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    enum Type
                    {
                        Double = 1,
                        Float = 2,
                        Int64 = 3,
                        Uint64 = 4,
                        Int32 = 5,
                        Fixed64 = 6,
                        Fixed32 = 7,
                        Bool = 8,
                        String = 9,
                        Group = 10,
                        Message = 11,
                        Bytes = 12,
                        Uint32 = 13,
                        Enum = 14,
                        Sfixed32 = 15,
                        Sfixed64 = 16,
                        Sint32 = 17,
                        Sint64 = 18,
                    }

                    enum Label
                    {
                        Optional = 1,
                        Required = 2,
                        Repeated = 3,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FieldDescriptorProto.<> <>9;

                    static /*0x1e6ee90*/ <>c();
                    /*0x1e6eef4*/ <>c();
                    /*0x1e6eefc*/ Google.Protobuf.Reflection.FieldDescriptorProto <.cctor>b__119_0();
                }
            }

            class OneofDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.OneofDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.OneofDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.OneofDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int OptionsFieldNumber = 2;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Reflection.OneofOptions options_;

                static /*0x1e6f814*/ OneofDescriptorProto();
                static /*0x1e6ef58*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> get_Parser();
                static /*0x1e6efb0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e6f100*/ OneofDescriptorProto();
                /*0x1e6f108*/ OneofDescriptorProto(Google.Protobuf.Reflection.OneofDescriptorProto other);
                /*0x1e6f0b4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e6f160*/ Google.Protobuf.Reflection.OneofDescriptorProto Clone();
                /*0x1e6f1c0*/ string get_Name();
                /*0x1e6f224*/ void set_Name(string value);
                /*0x1e6f298*/ bool get_HasName();
                /*0x1e6f2a8*/ void ClearName();
                /*0x1e6f2b0*/ Google.Protobuf.Reflection.OneofOptions get_Options();
                /*0x1e6f2b8*/ void set_Options(Google.Protobuf.Reflection.OneofOptions value);
                /*0x1e6f2c0*/ bool Equals(object other);
                /*0x1e6f324*/ bool Equals(Google.Protobuf.Reflection.OneofDescriptorProto other);
                /*0x1e6f3ac*/ int GetHashCode();
                /*0x1e6f428*/ string ToString();
                /*0x1e6f480*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e6f4a0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e6f530*/ int CalculateSize();
                /*0x1e6f5fc*/ void MergeFrom(Google.Protobuf.Reflection.OneofDescriptorProto other);
                /*0x1e6f6b4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e6f6d4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.OneofDescriptorProto.<> <>9;

                    static /*0x1e6f948*/ <>c();
                    /*0x1e6f9ac*/ <>c();
                    /*0x1e6f9b4*/ Google.Protobuf.Reflection.OneofDescriptorProto <.cctor>b__36_0();
                }
            }

            class EnumDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int ValueFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static int ReservedRangeFieldNumber = 4;
                static int ReservedNameFieldNumber = 5;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumValueDescriptorProto> _repeated_value_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec;
                static /*0x20*/ Google.Protobuf.FieldCodec<string> _repeated_reservedName_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> value_;
                /*0x28*/ Google.Protobuf.Reflection.EnumOptions options_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> reservedRange_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<string> reservedName_;

                static /*0x1e708cc*/ EnumDescriptorProto();
                static /*0x1e6fa10*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> get_Parser();
                static /*0x1e6fa68*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e6fbb8*/ EnumDescriptorProto();
                /*0x1e6fcbc*/ EnumDescriptorProto(Google.Protobuf.Reflection.EnumDescriptorProto other);
                /*0x1e6fb6c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e6fda0*/ Google.Protobuf.Reflection.EnumDescriptorProto Clone();
                /*0x1e6fe00*/ string get_Name();
                /*0x1e6fe64*/ void set_Name(string value);
                /*0x1e6fed8*/ bool get_HasName();
                /*0x1e6fee8*/ void ClearName();
                /*0x1e6fef0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Value();
                /*0x1e6fef8*/ Google.Protobuf.Reflection.EnumOptions get_Options();
                /*0x1e6ff00*/ void set_Options(Google.Protobuf.Reflection.EnumOptions value);
                /*0x1e6ff08*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_ReservedRange();
                /*0x1e6ff10*/ Google.Protobuf.Collections.RepeatedField<string> get_ReservedName();
                /*0x1e6ff18*/ bool Equals(object other);
                /*0x1e6ff7c*/ bool Equals(Google.Protobuf.Reflection.EnumDescriptorProto other);
                /*0x1e700a0*/ int GetHashCode();
                /*0x1e70170*/ string ToString();
                /*0x1e701c8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e701e8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e70374*/ int CalculateSize();
                /*0x1e70524*/ void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto other);
                /*0x1e70654*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e70674*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class EnumReservedRange : Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, Google.Protobuf.IBufferMessage
                    {
                        static int StartFieldNumber = 1;
                        static int EndFieldNumber = 2;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _parser;
                        static /*0x8*/ int StartDefaultValue;
                        static /*0xc*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x1c*/ int start_;
                        /*0x20*/ int end_;

                        static /*0x1e7131c*/ EnumReservedRange();
                        static /*0x1e70b30*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_Parser();
                        static /*0x1e70b88*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x1e70ca0*/ EnumReservedRange();
                        /*0x1e70ca8*/ EnumReservedRange(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other);
                        /*0x1e70c54*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x1e70cf4*/ Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone();
                        /*0x1e70d54*/ int get_Start();
                        /*0x1e70dc4*/ void set_Start(int value);
                        /*0x1e70dd4*/ bool get_HasStart();
                        /*0x1e70de0*/ void ClearStart();
                        /*0x1e70df0*/ int get_End();
                        /*0x1e70e60*/ void set_End(int value);
                        /*0x1e70e74*/ bool get_HasEnd();
                        /*0x1e70e80*/ void ClearEnd();
                        /*0x1e70e90*/ bool Equals(object other);
                        /*0x1e70ef4*/ bool Equals(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other);
                        /*0x1e70f78*/ int GetHashCode();
                        /*0x1e71004*/ string ToString();
                        /*0x1e7105c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x1e7107c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x1e71114*/ int CalculateSize();
                        /*0x1e711ec*/ void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other);
                        /*0x1e7125c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x1e7127c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange.<> <>9;

                            static /*0x1e71430*/ <>c();
                            /*0x1e71494*/ <>c();
                            /*0x1e7149c*/ Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange <.cctor>b__41_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumDescriptorProto.<> <>9;

                    static /*0x1e714f8*/ <>c();
                    /*0x1e7155c*/ <>c();
                    /*0x1e71564*/ Google.Protobuf.Reflection.EnumDescriptorProto <.cctor>b__52_0();
                }
            }

            class EnumValueDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumValueDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumValueDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumValueDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int NumberFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ int NumberDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ string name_;
                /*0x28*/ int number_;
                /*0x30*/ Google.Protobuf.Reflection.EnumValueOptions options_;

                static /*0x1e7202c*/ EnumValueDescriptorProto();
                static /*0x1e715bc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Parser();
                static /*0x1e71614*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e71764*/ EnumValueDescriptorProto();
                /*0x1e7176c*/ EnumValueDescriptorProto(Google.Protobuf.Reflection.EnumValueDescriptorProto other);
                /*0x1e71718*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e717d4*/ Google.Protobuf.Reflection.EnumValueDescriptorProto Clone();
                /*0x1e71834*/ string get_Name();
                /*0x1e71898*/ void set_Name(string value);
                /*0x1e7190c*/ bool get_HasName();
                /*0x1e7191c*/ void ClearName();
                /*0x1e71924*/ int get_Number();
                /*0x1e71994*/ void set_Number(int value);
                /*0x1e719a8*/ bool get_HasNumber();
                /*0x1e719b4*/ void ClearNumber();
                /*0x1e719c4*/ Google.Protobuf.Reflection.EnumValueOptions get_Options();
                /*0x1e719cc*/ void set_Options(Google.Protobuf.Reflection.EnumValueOptions value);
                /*0x1e719d4*/ bool Equals(object other);
                /*0x1e71a38*/ bool Equals(Google.Protobuf.Reflection.EnumValueDescriptorProto other);
                /*0x1e71adc*/ int GetHashCode();
                /*0x1e71b80*/ string ToString();
                /*0x1e71bd8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e71bf8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e71cb8*/ int CalculateSize();
                /*0x1e71dc0*/ void MergeFrom(Google.Protobuf.Reflection.EnumValueDescriptorProto other);
                /*0x1e71e98*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e71eb8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumValueDescriptorProto.<> <>9;

                    static /*0x1e72164*/ <>c();
                    /*0x1e721c8*/ <>c();
                    /*0x1e721d0*/ Google.Protobuf.Reflection.EnumValueDescriptorProto <.cctor>b__46_0();
                }
            }

            class ServiceDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.ServiceDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.ServiceDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.ServiceDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int MethodFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.MethodDescriptorProto> _repeated_method_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> method_;
                /*0x28*/ Google.Protobuf.Reflection.ServiceOptions options_;

                static /*0x1e72d80*/ ServiceDescriptorProto();
                static /*0x1e7222c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Parser();
                static /*0x1e72284*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e723d4*/ ServiceDescriptorProto();
                /*0x1e72450*/ ServiceDescriptorProto(Google.Protobuf.Reflection.ServiceDescriptorProto other);
                /*0x1e72388*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e724e4*/ Google.Protobuf.Reflection.ServiceDescriptorProto Clone();
                /*0x1e72544*/ string get_Name();
                /*0x1e725a8*/ void set_Name(string value);
                /*0x1e7261c*/ bool get_HasName();
                /*0x1e7262c*/ void ClearName();
                /*0x1e72634*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> get_Method();
                /*0x1e7263c*/ Google.Protobuf.Reflection.ServiceOptions get_Options();
                /*0x1e72644*/ void set_Options(Google.Protobuf.Reflection.ServiceOptions value);
                /*0x1e7264c*/ bool Equals(object other);
                /*0x1e726b0*/ bool Equals(Google.Protobuf.Reflection.ServiceDescriptorProto other);
                /*0x1e7277c*/ int GetHashCode();
                /*0x1e72814*/ string ToString();
                /*0x1e7286c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7288c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7299c*/ int CalculateSize();
                /*0x1e72ac8*/ void MergeFrom(Google.Protobuf.Reflection.ServiceDescriptorProto other);
                /*0x1e72ba8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e72bc8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ServiceDescriptorProto.<> <>9;

                    static /*0x1e73f40*/ <>c();
                    /*0x1e73fa4*/ <>c();
                    /*0x1e73fac*/ Google.Protobuf.Reflection.ServiceDescriptorProto <.cctor>b__41_0();
                }
            }

            class MethodDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.MethodDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.MethodDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.MethodDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int InputTypeFieldNumber = 2;
                static int OutputTypeFieldNumber = 3;
                static int OptionsFieldNumber = 4;
                static int ClientStreamingFieldNumber = 5;
                static int ServerStreamingFieldNumber = 6;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ string InputTypeDefaultValue;
                static /*0x18*/ string OutputTypeDefaultValue;
                static /*0x20*/ bool ClientStreamingDefaultValue;
                static /*0x21*/ bool ServerStreamingDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ string name_;
                /*0x28*/ string inputType_;
                /*0x30*/ string outputType_;
                /*0x38*/ Google.Protobuf.Reflection.MethodOptions options_;
                /*0x40*/ bool clientStreaming_;
                /*0x41*/ bool serverStreaming_;

                static /*0x1e751a0*/ MethodDescriptorProto();
                static /*0x1e74008*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> get_Parser();
                static /*0x1e74060*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e741b0*/ MethodDescriptorProto();
                /*0x1e741b8*/ MethodDescriptorProto(Google.Protobuf.Reflection.MethodDescriptorProto other);
                /*0x1e74164*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7428c*/ Google.Protobuf.Reflection.MethodDescriptorProto Clone();
                /*0x1e742ec*/ string get_Name();
                /*0x1e74350*/ void set_Name(string value);
                /*0x1e743c4*/ bool get_HasName();
                /*0x1e743d4*/ void ClearName();
                /*0x1e743dc*/ string get_InputType();
                /*0x1e74440*/ void set_InputType(string value);
                /*0x1e744b4*/ bool get_HasInputType();
                /*0x1e744c4*/ void ClearInputType();
                /*0x1e744cc*/ string get_OutputType();
                /*0x1e74530*/ void set_OutputType(string value);
                /*0x1e745a4*/ bool get_HasOutputType();
                /*0x1e745b4*/ void ClearOutputType();
                /*0x1e745bc*/ Google.Protobuf.Reflection.MethodOptions get_Options();
                /*0x1e745c4*/ void set_Options(Google.Protobuf.Reflection.MethodOptions value);
                /*0x1e745cc*/ bool get_ClientStreaming();
                /*0x1e7463c*/ void set_ClientStreaming(bool value);
                /*0x1e74654*/ bool get_HasClientStreaming();
                /*0x1e74660*/ void ClearClientStreaming();
                /*0x1e74670*/ bool get_ServerStreaming();
                /*0x1e746e0*/ void set_ServerStreaming(bool value);
                /*0x1e746f8*/ bool get_HasServerStreaming();
                /*0x1e74704*/ void ClearServerStreaming();
                /*0x1e74714*/ bool Equals(object other);
                /*0x1e74778*/ bool Equals(Google.Protobuf.Reflection.MethodDescriptorProto other);
                /*0x1e74888*/ int GetHashCode();
                /*0x1e749a0*/ string ToString();
                /*0x1e749f8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e74a18*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e74b68*/ int CalculateSize();
                /*0x1e74cc8*/ void MergeFrom(Google.Protobuf.Reflection.MethodDescriptorProto other);
                /*0x1e74f50*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e74f70*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MethodDescriptorProto.<> <>9;

                    static /*0x1e752dc*/ <>c();
                    /*0x1e75340*/ <>c();
                    /*0x1e75348*/ Google.Protobuf.Reflection.MethodDescriptorProto <.cctor>b__73_0();
                }
            }

            class FileOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IBufferMessage
            {
                static int JavaPackageFieldNumber = 1;
                static int JavaOuterClassnameFieldNumber = 8;
                static int JavaMultipleFilesFieldNumber = 10;
                static int JavaGenerateEqualsAndHashFieldNumber = 20;
                static int JavaStringCheckUtf8FieldNumber = 27;
                static int OptimizeForFieldNumber = 9;
                static int GoPackageFieldNumber = 11;
                static int CcGenericServicesFieldNumber = 16;
                static int JavaGenericServicesFieldNumber = 17;
                static int PyGenericServicesFieldNumber = 18;
                static int PhpGenericServicesFieldNumber = 42;
                static int DeprecatedFieldNumber = 23;
                static int CcEnableArenasFieldNumber = 31;
                static int ObjcClassPrefixFieldNumber = 36;
                static int CsharpNamespaceFieldNumber = 37;
                static int SwiftPrefixFieldNumber = 39;
                static int PhpClassPrefixFieldNumber = 40;
                static int PhpNamespaceFieldNumber = 41;
                static int PhpMetadataNamespaceFieldNumber = 44;
                static int RubyPackageFieldNumber = 45;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> _parser;
                static /*0x8*/ string JavaPackageDefaultValue;
                static /*0x10*/ string JavaOuterClassnameDefaultValue;
                static /*0x18*/ bool JavaMultipleFilesDefaultValue;
                static /*0x19*/ bool JavaGenerateEqualsAndHashDefaultValue;
                static /*0x1a*/ bool JavaStringCheckUtf8DefaultValue;
                static /*0x1c*/ Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode OptimizeForDefaultValue;
                static /*0x20*/ string GoPackageDefaultValue;
                static /*0x28*/ bool CcGenericServicesDefaultValue;
                static /*0x29*/ bool JavaGenericServicesDefaultValue;
                static /*0x2a*/ bool PyGenericServicesDefaultValue;
                static /*0x2b*/ bool PhpGenericServicesDefaultValue;
                static /*0x2c*/ bool DeprecatedDefaultValue;
                static /*0x2d*/ bool CcEnableArenasDefaultValue;
                static /*0x30*/ string ObjcClassPrefixDefaultValue;
                static /*0x38*/ string CsharpNamespaceDefaultValue;
                static /*0x40*/ string SwiftPrefixDefaultValue;
                static /*0x48*/ string PhpClassPrefixDefaultValue;
                static /*0x50*/ string PhpNamespaceDefaultValue;
                static /*0x58*/ string PhpMetadataNamespaceDefaultValue;
                static /*0x60*/ string RubyPackageDefaultValue;
                static /*0x68*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x28*/ string javaPackage_;
                /*0x30*/ string javaOuterClassname_;
                /*0x38*/ bool javaMultipleFiles_;
                /*0x39*/ bool javaGenerateEqualsAndHash_;
                /*0x3a*/ bool javaStringCheckUtf8_;
                /*0x3c*/ Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode optimizeFor_;
                /*0x40*/ string goPackage_;
                /*0x48*/ bool ccGenericServices_;
                /*0x49*/ bool javaGenericServices_;
                /*0x4a*/ bool pyGenericServices_;
                /*0x4b*/ bool phpGenericServices_;
                /*0x4c*/ bool deprecated_;
                /*0x4d*/ bool ccEnableArenas_;
                /*0x50*/ string objcClassPrefix_;
                /*0x58*/ string csharpNamespace_;
                /*0x60*/ string swiftPrefix_;
                /*0x68*/ string phpClassPrefix_;
                /*0x70*/ string phpNamespace_;
                /*0x78*/ string phpMetadataNamespace_;
                /*0x80*/ string rubyPackage_;
                /*0x88*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e780bc*/ FileOptions();
                static /*0x1e753ac*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> get_Parser();
                static /*0x1e75404*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e75554*/ FileOptions();
                /*0x1e755d0*/ FileOptions(Google.Protobuf.Reflection.FileOptions other);
                /*0x1e753a4*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> get__Extensions();
                /*0x1e75508*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e756f4*/ Google.Protobuf.Reflection.FileOptions Clone();
                /*0x1e75754*/ string get_JavaPackage();
                /*0x1e757b8*/ void set_JavaPackage(string value);
                /*0x1e7582c*/ bool get_HasJavaPackage();
                /*0x1e7583c*/ void ClearJavaPackage();
                /*0x1e75844*/ string get_JavaOuterClassname();
                /*0x1e758a8*/ void set_JavaOuterClassname(string value);
                /*0x1e7591c*/ bool get_HasJavaOuterClassname();
                /*0x1e7592c*/ void ClearJavaOuterClassname();
                /*0x1e75934*/ bool get_JavaMultipleFiles();
                /*0x1e759a4*/ void set_JavaMultipleFiles(bool value);
                /*0x1e759bc*/ bool get_HasJavaMultipleFiles();
                /*0x1e759c8*/ void ClearJavaMultipleFiles();
                /*0x1e759d8*/ bool get_JavaGenerateEqualsAndHash();
                /*0x1e75a48*/ void set_JavaGenerateEqualsAndHash(bool value);
                /*0x1e75a60*/ bool get_HasJavaGenerateEqualsAndHash();
                /*0x1e75a6c*/ void ClearJavaGenerateEqualsAndHash();
                /*0x1e75a7c*/ bool get_JavaStringCheckUtf8();
                /*0x1e75aec*/ void set_JavaStringCheckUtf8(bool value);
                /*0x1e75b04*/ bool get_HasJavaStringCheckUtf8();
                /*0x1e75b10*/ void ClearJavaStringCheckUtf8();
                /*0x1e75b20*/ Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode get_OptimizeFor();
                /*0x1e75b90*/ void set_OptimizeFor(Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode value);
                /*0x1e75ba4*/ bool get_HasOptimizeFor();
                /*0x1e75bb0*/ void ClearOptimizeFor();
                /*0x1e75bc0*/ string get_GoPackage();
                /*0x1e75c24*/ void set_GoPackage(string value);
                /*0x1e75c98*/ bool get_HasGoPackage();
                /*0x1e75ca8*/ void ClearGoPackage();
                /*0x1e75cb0*/ bool get_CcGenericServices();
                /*0x1e75d20*/ void set_CcGenericServices(bool value);
                /*0x1e75d38*/ bool get_HasCcGenericServices();
                /*0x1e75d44*/ void ClearCcGenericServices();
                /*0x1e75d54*/ bool get_JavaGenericServices();
                /*0x1e75dc4*/ void set_JavaGenericServices(bool value);
                /*0x1e75ddc*/ bool get_HasJavaGenericServices();
                /*0x1e75de8*/ void ClearJavaGenericServices();
                /*0x1e75df8*/ bool get_PyGenericServices();
                /*0x1e75e68*/ void set_PyGenericServices(bool value);
                /*0x1e75e80*/ bool get_HasPyGenericServices();
                /*0x1e75e8c*/ void ClearPyGenericServices();
                /*0x1e75e9c*/ bool get_PhpGenericServices();
                /*0x1e75f0c*/ void set_PhpGenericServices(bool value);
                /*0x1e75f24*/ bool get_HasPhpGenericServices();
                /*0x1e75f30*/ void ClearPhpGenericServices();
                /*0x1e75f40*/ bool get_Deprecated();
                /*0x1e75fb0*/ void set_Deprecated(bool value);
                /*0x1e75fc8*/ bool get_HasDeprecated();
                /*0x1e75fd4*/ void ClearDeprecated();
                /*0x1e75fe4*/ bool get_CcEnableArenas();
                /*0x1e76054*/ void set_CcEnableArenas(bool value);
                /*0x1e7606c*/ bool get_HasCcEnableArenas();
                /*0x1e76078*/ void ClearCcEnableArenas();
                /*0x1e76088*/ string get_ObjcClassPrefix();
                /*0x1e760ec*/ void set_ObjcClassPrefix(string value);
                /*0x1e76160*/ bool get_HasObjcClassPrefix();
                /*0x1e76170*/ void ClearObjcClassPrefix();
                /*0x1e76178*/ string get_CsharpNamespace();
                /*0x1e761dc*/ void set_CsharpNamespace(string value);
                /*0x1e76250*/ bool get_HasCsharpNamespace();
                /*0x1e76260*/ void ClearCsharpNamespace();
                /*0x1e76268*/ string get_SwiftPrefix();
                /*0x1e762cc*/ void set_SwiftPrefix(string value);
                /*0x1e76340*/ bool get_HasSwiftPrefix();
                /*0x1e76350*/ void ClearSwiftPrefix();
                /*0x1e76358*/ string get_PhpClassPrefix();
                /*0x1e763bc*/ void set_PhpClassPrefix(string value);
                /*0x1e76430*/ bool get_HasPhpClassPrefix();
                /*0x1e76440*/ void ClearPhpClassPrefix();
                /*0x1e76448*/ string get_PhpNamespace();
                /*0x1e764ac*/ void set_PhpNamespace(string value);
                /*0x1e76520*/ bool get_HasPhpNamespace();
                /*0x1e76530*/ void ClearPhpNamespace();
                /*0x1e76538*/ string get_PhpMetadataNamespace();
                /*0x1e7659c*/ void set_PhpMetadataNamespace(string value);
                /*0x1e76610*/ bool get_HasPhpMetadataNamespace();
                /*0x1e76620*/ void ClearPhpMetadataNamespace();
                /*0x1e76628*/ string get_RubyPackage();
                /*0x1e7668c*/ void set_RubyPackage(string value);
                /*0x1e76700*/ bool get_HasRubyPackage();
                /*0x1e76710*/ void ClearRubyPackage();
                /*0x1e76718*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e76720*/ bool Equals(object other);
                /*0x1e76784*/ bool Equals(Google.Protobuf.Reflection.FileOptions other);
                /*0x1e76ad0*/ int GetHashCode();
                /*0x1e76e68*/ string ToString();
                /*0x1e76ec0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e76ee0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e773d8*/ int CalculateSize();
                /*0x1e777cc*/ void MergeFrom(Google.Protobuf.Reflection.FileOptions other);
                /*0x1e77b08*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e77b28*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, TValue> extension);

                class Types
                {
                    enum OptimizeMode
                    {
                        Speed = 1,
                        CodeSize = 2,
                        LiteRuntime = 3,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileOptions.<> <>9;

                    static /*0x1e782ac*/ <>c();
                    /*0x1e78310*/ <>c();
                    /*0x1e78318*/ Google.Protobuf.Reflection.FileOptions <.cctor>b__219_0();
                }
            }

            class MessageOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IBufferMessage
            {
                static int MessageSetWireFormatFieldNumber = 1;
                static int NoStandardDescriptorAccessorFieldNumber = 2;
                static int DeprecatedFieldNumber = 3;
                static int MapEntryFieldNumber = 7;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> _parser;
                static /*0x8*/ bool MessageSetWireFormatDefaultValue;
                static /*0x9*/ bool NoStandardDescriptorAccessorDefaultValue;
                static /*0xa*/ bool DeprecatedDefaultValue;
                static /*0xb*/ bool MapEntryDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool messageSetWireFormat_;
                /*0x25*/ bool noStandardDescriptorAccessor_;
                /*0x26*/ bool deprecated_;
                /*0x27*/ bool mapEntry_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e79264*/ MessageOptions();
                static /*0x1e78378*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> get_Parser();
                static /*0x1e783d0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e78520*/ MessageOptions();
                /*0x1e7859c*/ MessageOptions(Google.Protobuf.Reflection.MessageOptions other);
                /*0x1e78370*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> get__Extensions();
                /*0x1e784d4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e78660*/ Google.Protobuf.Reflection.MessageOptions Clone();
                /*0x1e786c0*/ bool get_MessageSetWireFormat();
                /*0x1e78730*/ void set_MessageSetWireFormat(bool value);
                /*0x1e78748*/ bool get_HasMessageSetWireFormat();
                /*0x1e78754*/ void ClearMessageSetWireFormat();
                /*0x1e78764*/ bool get_NoStandardDescriptorAccessor();
                /*0x1e787d4*/ void set_NoStandardDescriptorAccessor(bool value);
                /*0x1e787ec*/ bool get_HasNoStandardDescriptorAccessor();
                /*0x1e787f8*/ void ClearNoStandardDescriptorAccessor();
                /*0x1e78808*/ bool get_Deprecated();
                /*0x1e78878*/ void set_Deprecated(bool value);
                /*0x1e78890*/ bool get_HasDeprecated();
                /*0x1e7889c*/ void ClearDeprecated();
                /*0x1e788ac*/ bool get_MapEntry();
                /*0x1e7891c*/ void set_MapEntry(bool value);
                /*0x1e78934*/ bool get_HasMapEntry();
                /*0x1e78940*/ void ClearMapEntry();
                /*0x1e78950*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e78958*/ bool Equals(object other);
                /*0x1e789bc*/ bool Equals(Google.Protobuf.Reflection.MessageOptions other);
                /*0x1e78ad0*/ int GetHashCode();
                /*0x1e78bf4*/ string ToString();
                /*0x1e78c4c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e78c6c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e78e18*/ int CalculateSize();
                /*0x1e78f1c*/ void MergeFrom(Google.Protobuf.Reflection.MessageOptions other);
                /*0x1e79054*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e79074*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MessageOptions.<> <>9;

                    static /*0x1e7940c*/ <>c();
                    /*0x1e79470*/ <>c();
                    /*0x1e79478*/ Google.Protobuf.Reflection.MessageOptions <.cctor>b__74_0();
                }
            }

            class FieldOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IBufferMessage
            {
                static int CtypeFieldNumber = 1;
                static int PackedFieldNumber = 2;
                static int JstypeFieldNumber = 6;
                static int LazyFieldNumber = 5;
                static int DeprecatedFieldNumber = 3;
                static int WeakFieldNumber = 10;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> _parser;
                static /*0x8*/ Google.Protobuf.Reflection.FieldOptions.Types.CType CtypeDefaultValue;
                static /*0xc*/ bool PackedDefaultValue;
                static /*0x10*/ Google.Protobuf.Reflection.FieldOptions.Types.JSType JstypeDefaultValue;
                static /*0x14*/ bool LazyDefaultValue;
                static /*0x15*/ bool DeprecatedDefaultValue;
                static /*0x16*/ bool WeakDefaultValue;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ Google.Protobuf.Reflection.FieldOptions.Types.CType ctype_;
                /*0x28*/ bool packed_;
                /*0x2c*/ Google.Protobuf.Reflection.FieldOptions.Types.JSType jstype_;
                /*0x30*/ bool lazy_;
                /*0x31*/ bool deprecated_;
                /*0x32*/ bool weak_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e7a73c*/ FieldOptions();
                static /*0x1e794d8*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> get_Parser();
                static /*0x1e79530*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e79680*/ FieldOptions();
                /*0x1e796fc*/ FieldOptions(Google.Protobuf.Reflection.FieldOptions other);
                /*0x1e794d0*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> get__Extensions();
                /*0x1e79634*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e797c8*/ Google.Protobuf.Reflection.FieldOptions Clone();
                /*0x1e79828*/ Google.Protobuf.Reflection.FieldOptions.Types.CType get_Ctype();
                /*0x1e79898*/ void set_Ctype(Google.Protobuf.Reflection.FieldOptions.Types.CType value);
                /*0x1e798a8*/ bool get_HasCtype();
                /*0x1e798b4*/ void ClearCtype();
                /*0x1e798c4*/ bool get_Packed();
                /*0x1e79934*/ void set_Packed(bool value);
                /*0x1e7994c*/ bool get_HasPacked();
                /*0x1e79958*/ void ClearPacked();
                /*0x1e79968*/ Google.Protobuf.Reflection.FieldOptions.Types.JSType get_Jstype();
                /*0x1e799d8*/ void set_Jstype(Google.Protobuf.Reflection.FieldOptions.Types.JSType value);
                /*0x1e799ec*/ bool get_HasJstype();
                /*0x1e799f8*/ void ClearJstype();
                /*0x1e79a08*/ bool get_Lazy();
                /*0x1e79a78*/ void set_Lazy(bool value);
                /*0x1e79a90*/ bool get_HasLazy();
                /*0x1e79a9c*/ void ClearLazy();
                /*0x1e79aac*/ bool get_Deprecated();
                /*0x1e79b1c*/ void set_Deprecated(bool value);
                /*0x1e79b34*/ bool get_HasDeprecated();
                /*0x1e79b40*/ void ClearDeprecated();
                /*0x1e79b50*/ bool get_Weak();
                /*0x1e79bc0*/ void set_Weak(bool value);
                /*0x1e79bd8*/ bool get_HasWeak();
                /*0x1e79be4*/ void ClearWeak();
                /*0x1e79bf4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e79bfc*/ bool Equals(object other);
                /*0x1e79c60*/ bool Equals(Google.Protobuf.Reflection.FieldOptions other);
                /*0x1e79dac*/ int GetHashCode();
                /*0x1e79f30*/ string ToString();
                /*0x1e79f88*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e79fa8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7a1bc*/ int CalculateSize();
                /*0x1e7a358*/ void MergeFrom(Google.Protobuf.Reflection.FieldOptions other);
                /*0x1e7a4d4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7a4f4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);

                class Types
                {
                    enum CType
                    {
                        String = 0,
                        Cord = 1,
                        StringPiece = 2,
                    }

                    enum JSType
                    {
                        JsNormal = 0,
                        JsString = 1,
                        JsNumber = 2,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FieldOptions.<> <>9;

                    static /*0x1e7a8f0*/ <>c();
                    /*0x1e7a954*/ <>c();
                    /*0x1e7a95c*/ Google.Protobuf.Reflection.FieldOptions <.cctor>b__93_0();
                }
            }

            class OneofOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IBufferMessage
            {
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> _extensions;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e7b24c*/ OneofOptions();
                static /*0x1e7a9bc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> get_Parser();
                static /*0x1e7aa14*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e7ab64*/ OneofOptions();
                /*0x1e7abe0*/ OneofOptions(Google.Protobuf.Reflection.OneofOptions other);
                /*0x1e7a9b4*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> get__Extensions();
                /*0x1e7ab18*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7ac7c*/ Google.Protobuf.Reflection.OneofOptions Clone();
                /*0x1e7acdc*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e7ace4*/ bool Equals(object other);
                /*0x1e7ad48*/ bool Equals(Google.Protobuf.Reflection.OneofOptions other);
                /*0x1e7adec*/ int GetHashCode();
                /*0x1e7ae58*/ string ToString();
                /*0x1e7aeb0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7aed0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7afb0*/ int CalculateSize();
                /*0x1e7b080*/ void MergeFrom(Google.Protobuf.Reflection.OneofOptions other);
                /*0x1e7b118*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7b138*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.OneofOptions.<> <>9;

                    static /*0x1e7b3e8*/ <>c();
                    /*0x1e7b44c*/ <>c();
                    /*0x1e7b454*/ Google.Protobuf.Reflection.OneofOptions <.cctor>b__37_0();
                }
            }

            class EnumOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IBufferMessage
            {
                static int AllowAliasFieldNumber = 2;
                static int DeprecatedFieldNumber = 3;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> _parser;
                static /*0x8*/ bool AllowAliasDefaultValue;
                static /*0x9*/ bool DeprecatedDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool allowAlias_;
                /*0x25*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e7c070*/ EnumOptions();
                static /*0x1e7b4b4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> get_Parser();
                static /*0x1e7b50c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e7b65c*/ EnumOptions();
                /*0x1e7b6d8*/ EnumOptions(Google.Protobuf.Reflection.EnumOptions other);
                /*0x1e7b4ac*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> get__Extensions();
                /*0x1e7b610*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7b78c*/ Google.Protobuf.Reflection.EnumOptions Clone();
                /*0x1e7b7ec*/ bool get_AllowAlias();
                /*0x1e7b85c*/ void set_AllowAlias(bool value);
                /*0x1e7b874*/ bool get_HasAllowAlias();
                /*0x1e7b880*/ void ClearAllowAlias();
                /*0x1e7b890*/ bool get_Deprecated();
                /*0x1e7b900*/ void set_Deprecated(bool value);
                /*0x1e7b918*/ bool get_HasDeprecated();
                /*0x1e7b924*/ void ClearDeprecated();
                /*0x1e7b934*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e7b93c*/ bool Equals(object other);
                /*0x1e7b9a0*/ bool Equals(Google.Protobuf.Reflection.EnumOptions other);
                /*0x1e7ba7c*/ int GetHashCode();
                /*0x1e7bb48*/ string ToString();
                /*0x1e7bba0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7bbc0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7bd00*/ int CalculateSize();
                /*0x1e7bdec*/ void MergeFrom(Google.Protobuf.Reflection.EnumOptions other);
                /*0x1e7becc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7beec*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumOptions.<> <>9;

                    static /*0x1e7c218*/ <>c();
                    /*0x1e7c27c*/ <>c();
                    /*0x1e7c284*/ Google.Protobuf.Reflection.EnumOptions <.cctor>b__56_0();
                }
            }

            class EnumValueOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IBufferMessage
            {
                static int DeprecatedFieldNumber = 1;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> _parser;
                static /*0x8*/ bool DeprecatedDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e7cd10*/ EnumValueOptions();
                static /*0x1e7c2e4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> get_Parser();
                static /*0x1e7c33c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e7c48c*/ EnumValueOptions();
                /*0x1e7c508*/ EnumValueOptions(Google.Protobuf.Reflection.EnumValueOptions other);
                /*0x1e7c2dc*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> get__Extensions();
                /*0x1e7c440*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7c5b4*/ Google.Protobuf.Reflection.EnumValueOptions Clone();
                /*0x1e7c614*/ bool get_Deprecated();
                /*0x1e7c684*/ void set_Deprecated(bool value);
                /*0x1e7c69c*/ bool get_HasDeprecated();
                /*0x1e7c6a8*/ void ClearDeprecated();
                /*0x1e7c6b8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e7c6c0*/ bool Equals(object other);
                /*0x1e7c724*/ bool Equals(Google.Protobuf.Reflection.EnumValueOptions other);
                /*0x1e7c7e4*/ int GetHashCode();
                /*0x1e7c884*/ string ToString();
                /*0x1e7c8dc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7c8fc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7ca0c*/ int CalculateSize();
                /*0x1e7caec*/ void MergeFrom(Google.Protobuf.Reflection.EnumValueOptions other);
                /*0x1e7cba8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7cbc8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumValueOptions.<> <>9;

                    static /*0x1e7ceb8*/ <>c();
                    /*0x1e7cf1c*/ <>c();
                    /*0x1e7cf24*/ Google.Protobuf.Reflection.EnumValueOptions <.cctor>b__47_0();
                }
            }

            class ServiceOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IBufferMessage
            {
                static int DeprecatedFieldNumber = 33;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> _parser;
                static /*0x8*/ bool DeprecatedDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e7d9b8*/ ServiceOptions();
                static /*0x1e7cf84*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> get_Parser();
                static /*0x1e7cfdc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e7d12c*/ ServiceOptions();
                /*0x1e7d1a8*/ ServiceOptions(Google.Protobuf.Reflection.ServiceOptions other);
                /*0x1e7cf7c*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> get__Extensions();
                /*0x1e7d0e0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7d254*/ Google.Protobuf.Reflection.ServiceOptions Clone();
                /*0x1e7d2b4*/ bool get_Deprecated();
                /*0x1e7d324*/ void set_Deprecated(bool value);
                /*0x1e7d33c*/ bool get_HasDeprecated();
                /*0x1e7d348*/ void ClearDeprecated();
                /*0x1e7d358*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e7d360*/ bool Equals(object other);
                /*0x1e7d3c4*/ bool Equals(Google.Protobuf.Reflection.ServiceOptions other);
                /*0x1e7d484*/ int GetHashCode();
                /*0x1e7d524*/ string ToString();
                /*0x1e7d57c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7d59c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7d6b0*/ int CalculateSize();
                /*0x1e7d794*/ void MergeFrom(Google.Protobuf.Reflection.ServiceOptions other);
                /*0x1e7d850*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7d870*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ServiceOptions.<> <>9;

                    static /*0x1e7db60*/ <>c();
                    /*0x1e7dbc4*/ <>c();
                    /*0x1e7dbcc*/ Google.Protobuf.Reflection.ServiceOptions <.cctor>b__47_0();
                }
            }

            class MethodOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IBufferMessage
            {
                static int DeprecatedFieldNumber = 33;
                static int IdempotencyLevelFieldNumber = 34;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> _parser;
                static /*0x8*/ bool DeprecatedDefaultValue;
                static /*0xc*/ Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyLevelDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel idempotencyLevel_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x1e7e66c*/ MethodOptions();
                static /*0x1e7dc2c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> get_Parser();
                static /*0x1e7dc84*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e74df8*/ MethodOptions();
                /*0x1e7ddd4*/ MethodOptions(Google.Protobuf.Reflection.MethodOptions other);
                /*0x1e7dc24*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> get__Extensions();
                /*0x1e7dd88*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7422c*/ Google.Protobuf.Reflection.MethodOptions Clone();
                /*0x1e7de88*/ bool get_Deprecated();
                /*0x1e7def8*/ void set_Deprecated(bool value);
                /*0x1e7df10*/ bool get_HasDeprecated();
                /*0x1e7df1c*/ void ClearDeprecated();
                /*0x1e7df2c*/ Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel get_IdempotencyLevel();
                /*0x1e7df9c*/ void set_IdempotencyLevel(Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel value);
                /*0x1e7dfb0*/ bool get_HasIdempotencyLevel();
                /*0x1e7dfbc*/ void ClearIdempotencyLevel();
                /*0x1e7dfcc*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x1e7dfd4*/ bool Equals(object other);
                /*0x1e7e038*/ bool Equals(Google.Protobuf.Reflection.MethodOptions other);
                /*0x1e7e114*/ int GetHashCode();
                /*0x1e7e1e0*/ string ToString();
                /*0x1e7e238*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7e258*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7e3a0*/ int CalculateSize();
                /*0x1e74e74*/ void MergeFrom(Google.Protobuf.Reflection.MethodOptions other);
                /*0x1e7e4d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7e4f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension, TValue value);
                bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);

                class Types
                {
                    enum IdempotencyLevel
                    {
                        IdempotencyUnknown = 0,
                        NoSideEffects = 1,
                        Idempotent = 2,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MethodOptions.<> <>9;

                    static /*0x1e7e818*/ <>c();
                    /*0x1e7e87c*/ <>c();
                    /*0x1e7e884*/ Google.Protobuf.Reflection.MethodOptions <.cctor>b__57_0();
                }
            }

            class UninterpretedOption : Google.Protobuf.IMessage<Google.Protobuf.Reflection.UninterpretedOption>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.UninterpretedOption>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.UninterpretedOption>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 2;
                static int IdentifierValueFieldNumber = 3;
                static int PositiveIntValueFieldNumber = 4;
                static int NegativeIntValueFieldNumber = 5;
                static int DoubleValueFieldNumber = 6;
                static int StringValueFieldNumber = 7;
                static int AggregateValueFieldNumber = 8;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _repeated_name_codec;
                static /*0x10*/ string IdentifierValueDefaultValue;
                static /*0x18*/ ulong PositiveIntValueDefaultValue;
                static /*0x20*/ long NegativeIntValueDefaultValue;
                static /*0x28*/ double DoubleValueDefaultValue;
                static /*0x30*/ Google.Protobuf.ByteString StringValueDefaultValue;
                static /*0x38*/ string AggregateValueDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> name_;
                /*0x28*/ string identifierValue_;
                /*0x30*/ ulong positiveIntValue_;
                /*0x38*/ long negativeIntValue_;
                /*0x40*/ double doubleValue_;
                /*0x48*/ Google.Protobuf.ByteString stringValue_;
                /*0x50*/ string aggregateValue_;

                static /*0x1e7fd74*/ UninterpretedOption();
                static /*0x1e7e8dc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> get_Parser();
                static /*0x1e7e934*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e7ea84*/ UninterpretedOption();
                /*0x1e7eb00*/ UninterpretedOption(Google.Protobuf.Reflection.UninterpretedOption other);
                /*0x1e7ea38*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e7eb98*/ Google.Protobuf.Reflection.UninterpretedOption Clone();
                /*0x1e7ebf8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Name();
                /*0x1e7ec00*/ string get_IdentifierValue();
                /*0x1e7ec64*/ void set_IdentifierValue(string value);
                /*0x1e7ecd8*/ bool get_HasIdentifierValue();
                /*0x1e7ece8*/ void ClearIdentifierValue();
                /*0x1e7ecf0*/ ulong get_PositiveIntValue();
                /*0x1e7ed60*/ void set_PositiveIntValue(ulong value);
                /*0x1e7ed74*/ bool get_HasPositiveIntValue();
                /*0x1e7ed80*/ void ClearPositiveIntValue();
                /*0x1e7ed90*/ long get_NegativeIntValue();
                /*0x1e7ee00*/ void set_NegativeIntValue(long value);
                /*0x1e7ee14*/ bool get_HasNegativeIntValue();
                /*0x1e7ee20*/ void ClearNegativeIntValue();
                /*0x1e7ee30*/ double get_DoubleValue();
                /*0x1e7eea0*/ void set_DoubleValue(double value);
                /*0x1e7eeb4*/ bool get_HasDoubleValue();
                /*0x1e7eec0*/ void ClearDoubleValue();
                /*0x1e7eed0*/ Google.Protobuf.ByteString get_StringValue();
                /*0x1e7ef34*/ void set_StringValue(Google.Protobuf.ByteString value);
                /*0x1e7efa8*/ bool get_HasStringValue();
                /*0x1e7f008*/ void ClearStringValue();
                /*0x1e7f010*/ string get_AggregateValue();
                /*0x1e7f074*/ void set_AggregateValue(string value);
                /*0x1e7f0e8*/ bool get_HasAggregateValue();
                /*0x1e7f0f8*/ void ClearAggregateValue();
                /*0x1e7f100*/ bool Equals(object other);
                /*0x1e7f164*/ bool Equals(Google.Protobuf.Reflection.UninterpretedOption other);
                /*0x1e7f37c*/ int GetHashCode();
                /*0x1e7f544*/ string ToString();
                /*0x1e7f59c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e7f5bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e7f7a0*/ int CalculateSize();
                /*0x1e7f9a0*/ void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption other);
                /*0x1e7fad8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e7faf8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class NamePart : Google.Protobuf.IMessage<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, Google.Protobuf.IBufferMessage
                    {
                        static int NamePart_FieldNumber = 1;
                        static int IsExtensionFieldNumber = 2;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _parser;
                        static /*0x8*/ string NamePart_DefaultValue;
                        static /*0x10*/ bool IsExtensionDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x20*/ string namePart_;
                        /*0x28*/ bool isExtension_;

                        static /*0x1e807e8*/ NamePart();
                        static /*0x1e7ffa4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Parser();
                        static /*0x1e7fffc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x1e80114*/ NamePart();
                        /*0x1e8011c*/ NamePart(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other);
                        /*0x1e800c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x1e80170*/ Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone();
                        /*0x1e801d0*/ string get_NamePart_();
                        /*0x1e80234*/ void set_NamePart_(string value);
                        /*0x1e802a8*/ bool get_HasNamePart_();
                        /*0x1e802b8*/ void ClearNamePart_();
                        /*0x1e802c0*/ bool get_IsExtension();
                        /*0x1e80330*/ void set_IsExtension(bool value);
                        /*0x1e80348*/ bool get_HasIsExtension();
                        /*0x1e80354*/ void ClearIsExtension();
                        /*0x1e80364*/ bool Equals(object other);
                        /*0x1e803c8*/ bool Equals(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other);
                        /*0x1e80458*/ int GetHashCode();
                        /*0x1e804e8*/ string ToString();
                        /*0x1e80540*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x1e80560*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x1e805f8*/ int CalculateSize();
                        /*0x1e80698*/ void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other);
                        /*0x1e8070c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x1e8072c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart.<> <>9;

                            static /*0x1e80920*/ <>c();
                            /*0x1e80984*/ <>c();
                            /*0x1e8098c*/ Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart <.cctor>b__41_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.UninterpretedOption.<> <>9;

                    static /*0x1e809e8*/ <>c();
                    /*0x1e80a4c*/ <>c();
                    /*0x1e80a54*/ Google.Protobuf.Reflection.UninterpretedOption <.cctor>b__83_0();
                }
            }

            class SourceCodeInfo : Google.Protobuf.IMessage<Google.Protobuf.Reflection.SourceCodeInfo>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.SourceCodeInfo>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.SourceCodeInfo>, Google.Protobuf.IBufferMessage
            {
                static int LocationFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _repeated_location_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> location_;

                static /*0x1e81238*/ SourceCodeInfo();
                static /*0x1e80aac*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> get_Parser();
                static /*0x1e80b04*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e80c54*/ SourceCodeInfo();
                /*0x1e80cd0*/ SourceCodeInfo(Google.Protobuf.Reflection.SourceCodeInfo other);
                /*0x1e80c08*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e80d48*/ Google.Protobuf.Reflection.SourceCodeInfo Clone();
                /*0x1e80da8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Location();
                /*0x1e80db0*/ bool Equals(object other);
                /*0x1e80e14*/ bool Equals(Google.Protobuf.Reflection.SourceCodeInfo other);
                /*0x1e80ea4*/ int GetHashCode();
                /*0x1e80ef0*/ string ToString();
                /*0x1e80f48*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e80f68*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e81020*/ int CalculateSize();
                /*0x1e810c8*/ void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo other);
                /*0x1e8113c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e8115c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class Location : Google.Protobuf.IMessage<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, Google.Protobuf.IBufferMessage
                    {
                        static int PathFieldNumber = 1;
                        static int SpanFieldNumber = 2;
                        static int LeadingCommentsFieldNumber = 3;
                        static int TrailingCommentsFieldNumber = 4;
                        static int LeadingDetachedCommentsFieldNumber = 6;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _parser;
                        static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_path_codec;
                        static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_span_codec;
                        static /*0x18*/ string LeadingCommentsDefaultValue;
                        static /*0x20*/ string TrailingCommentsDefaultValue;
                        static /*0x28*/ Google.Protobuf.FieldCodec<string> _repeated_leadingDetachedComments_codec;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> path_;
                        /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> span_;
                        /*0x28*/ string leadingComments_;
                        /*0x30*/ string trailingComments_;
                        /*0x38*/ Google.Protobuf.Collections.RepeatedField<string> leadingDetachedComments_;

                        static /*0x1e82250*/ Location();
                        static /*0x1e813d4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Parser();
                        static /*0x1e8142c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x1e81544*/ Location();
                        /*0x1e81628*/ Location(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other);
                        /*0x1e814f8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x1e816e4*/ Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone();
                        /*0x1e81744*/ Google.Protobuf.Collections.RepeatedField<int> get_Path();
                        /*0x1e8174c*/ Google.Protobuf.Collections.RepeatedField<int> get_Span();
                        /*0x1e81754*/ string get_LeadingComments();
                        /*0x1e817b8*/ void set_LeadingComments(string value);
                        /*0x1e8182c*/ bool get_HasLeadingComments();
                        /*0x1e8183c*/ void ClearLeadingComments();
                        /*0x1e81844*/ string get_TrailingComments();
                        /*0x1e818a8*/ void set_TrailingComments(string value);
                        /*0x1e8191c*/ bool get_HasTrailingComments();
                        /*0x1e8192c*/ void ClearTrailingComments();
                        /*0x1e81934*/ Google.Protobuf.Collections.RepeatedField<string> get_LeadingDetachedComments();
                        /*0x1e8193c*/ bool Equals(object other);
                        /*0x1e819a0*/ bool Equals(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other);
                        /*0x1e81ac4*/ int GetHashCode();
                        /*0x1e81b98*/ string ToString();
                        /*0x1e81bf0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x1e81c10*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x1e81d90*/ int CalculateSize();
                        /*0x1e81f38*/ void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other);
                        /*0x1e82020*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x1e82040*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.SourceCodeInfo.Types.Location.<> <>9;

                            static /*0x1e823c4*/ <>c();
                            /*0x1e82428*/ <>c();
                            /*0x1e82430*/ Google.Protobuf.Reflection.SourceCodeInfo.Types.Location <.cctor>b__55_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.SourceCodeInfo.<> <>9;

                    static /*0x1e82488*/ <>c();
                    /*0x1e824ec*/ <>c();
                    /*0x1e824f4*/ Google.Protobuf.Reflection.SourceCodeInfo <.cctor>b__28_0();
                }
            }

            class GeneratedCodeInfo : Google.Protobuf.IMessage<Google.Protobuf.Reflection.GeneratedCodeInfo>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.GeneratedCodeInfo>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.GeneratedCodeInfo>, Google.Protobuf.IBufferMessage
            {
                static int AnnotationFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _repeated_annotation_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> annotation_;

                static /*0x1e82cd8*/ GeneratedCodeInfo();
                static /*0x1e8254c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> get_Parser();
                static /*0x1e825a4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x1e826f4*/ GeneratedCodeInfo();
                /*0x1e82770*/ GeneratedCodeInfo(Google.Protobuf.Reflection.GeneratedCodeInfo other);
                /*0x1e826a8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x1e827e8*/ Google.Protobuf.Reflection.GeneratedCodeInfo Clone();
                /*0x1e82848*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Annotation();
                /*0x1e82850*/ bool Equals(object other);
                /*0x1e828b4*/ bool Equals(Google.Protobuf.Reflection.GeneratedCodeInfo other);
                /*0x1e82944*/ int GetHashCode();
                /*0x1e82990*/ string ToString();
                /*0x1e829e8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x1e82a08*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x1e82ac0*/ int CalculateSize();
                /*0x1e82b68*/ void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo other);
                /*0x1e82bdc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x1e82bfc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class Annotation : Google.Protobuf.IMessage<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>, Google.Protobuf.IBufferMessage
                    {
                        static int PathFieldNumber = 1;
                        static int SourceFileFieldNumber = 2;
                        static int BeginFieldNumber = 3;
                        static int EndFieldNumber = 4;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _parser;
                        static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_path_codec;
                        static /*0x10*/ string SourceFileDefaultValue;
                        static /*0x18*/ int BeginDefaultValue;
                        static /*0x1c*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> path_;
                        /*0x28*/ string sourceFile_;
                        /*0x30*/ int begin_;
                        /*0x34*/ int end_;

                        static /*0x1e83b48*/ Annotation();
                        static /*0x1e82e74*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Parser();
                        static /*0x1e82ecc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x1e82fe4*/ Annotation();
                        /*0x1e83060*/ Annotation(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other);
                        /*0x1e82f98*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x1e830f0*/ Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation Clone();
                        /*0x1e83150*/ Google.Protobuf.Collections.RepeatedField<int> get_Path();
                        /*0x1e83158*/ string get_SourceFile();
                        /*0x1e831bc*/ void set_SourceFile(string value);
                        /*0x1e83230*/ bool get_HasSourceFile();
                        /*0x1e83240*/ void ClearSourceFile();
                        /*0x1e83248*/ int get_Begin();
                        /*0x1e832b8*/ void set_Begin(int value);
                        /*0x1e832cc*/ bool get_HasBegin();
                        /*0x1e832d8*/ void ClearBegin();
                        /*0x1e832e8*/ int get_End();
                        /*0x1e83358*/ void set_End(int value);
                        /*0x1e8336c*/ bool get_HasEnd();
                        /*0x1e83378*/ void ClearEnd();
                        /*0x1e83388*/ bool Equals(object other);
                        /*0x1e833ec*/ bool Equals(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other);
                        /*0x1e834dc*/ int GetHashCode();
                        /*0x1e8359c*/ string ToString();
                        /*0x1e835f4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x1e83614*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x1e8375c*/ int CalculateSize();
                        /*0x1e838d0*/ void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other);
                        /*0x1e839a0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x1e839c0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation.<> <>9;

                            static /*0x1e83c8c*/ <>c();
                            /*0x1e83cf0*/ <>c();
                            /*0x1e83cf8*/ Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation <.cctor>b__55_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.GeneratedCodeInfo.<> <>9;

                    static /*0x1e83d50*/ <>c();
                    /*0x1e83db4*/ <>c();
                    /*0x1e83dbc*/ Google.Protobuf.Reflection.GeneratedCodeInfo <.cctor>b__28_0();
                }
            }

            class DescriptorBase : Google.Protobuf.Reflection.IDescriptor
            {
                /*0x10*/ int <Index>k__BackingField;
                /*0x18*/ string <FullName>k__BackingField;
                /*0x20*/ Google.Protobuf.Reflection.FileDescriptor <File>k__BackingField;

                /*0x1e83e14*/ DescriptorBase(Google.Protobuf.Reflection.FileDescriptor file, string fullName, int index);
                /*0x1e83e50*/ int get_Index();
                string get_Name();
                /*0x1e83e58*/ string get_FullName();
                /*0x1e83e60*/ Google.Protobuf.Reflection.FileDescriptor get_File();
                /*0x1e83e68*/ Google.Protobuf.Reflection.DescriptorDeclaration get_Declaration();
                /*0x1e83f14*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
            }

            class DescriptorDeclaration
            {
                /*0x10*/ Google.Protobuf.Reflection.IDescriptor <Descriptor>k__BackingField;
                /*0x18*/ int <StartLine>k__BackingField;
                /*0x1c*/ int <StartColumn>k__BackingField;
                /*0x20*/ int <EndLine>k__BackingField;
                /*0x24*/ int <EndColumn>k__BackingField;
                /*0x28*/ string <LeadingComments>k__BackingField;
                /*0x30*/ string <TrailingComments>k__BackingField;
                /*0x38*/ System.Collections.Generic.IReadOnlyList<string> <LeadingDetachedComments>k__BackingField;

                static /*0x1e840ec*/ Google.Protobuf.Reflection.DescriptorDeclaration FromProto(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location);
                /*0x1e83f5c*/ DescriptorDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location);
                /*0x1e83f1c*/ Google.Protobuf.Reflection.IDescriptor get_Descriptor();
                /*0x1e83f24*/ int get_StartLine();
                /*0x1e83f2c*/ int get_StartColumn();
                /*0x1e83f34*/ int get_EndLine();
                /*0x1e83f3c*/ int get_EndColumn();
                /*0x1e83f44*/ string get_LeadingComments();
                /*0x1e83f4c*/ string get_TrailingComments();
                /*0x1e83f54*/ System.Collections.Generic.IReadOnlyList<string> get_LeadingDetachedComments();
            }

            class DescriptorPool
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex ValidationRegex;
                /*0x10*/ System.Collections.Generic.IDictionary<string, Google.Protobuf.Reflection.IDescriptor> descriptorsByName;
                /*0x18*/ System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>, Google.Protobuf.Reflection.FieldDescriptor> fieldsByNumber;
                /*0x20*/ System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>, Google.Protobuf.Reflection.EnumValueDescriptor> enumValuesByNumber;
                /*0x28*/ System.Collections.Generic.HashSet<Google.Protobuf.Reflection.FileDescriptor> dependencies;

                static /*0x1e8641c*/ DescriptorPool();
                static /*0x1e856cc*/ void ValidateSymbolName(Google.Protobuf.Reflection.IDescriptor descriptor);
                /*0x1e8415c*/ DescriptorPool(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencyFiles);
                /*0x1e84804*/ void ImportPublicDependencies(Google.Protobuf.Reflection.FileDescriptor file);
                T FindSymbol<T>(string fullName);
                /*0x1e84b44*/ void AddPackage(string fullName, Google.Protobuf.Reflection.FileDescriptor file);
                /*0x1e85068*/ void AddSymbol(Google.Protobuf.Reflection.IDescriptor descriptor);
                /*0x1e85918*/ Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, int number);
                /*0x1e85a1c*/ Google.Protobuf.Reflection.EnumValueDescriptor FindEnumValueByNumber(Google.Protobuf.Reflection.EnumDescriptor enumDescriptor, int number);
                /*0x1e85b20*/ void AddFieldByNumber(Google.Protobuf.Reflection.FieldDescriptor field);
                /*0x1e85f8c*/ void AddEnumValueByNumber(Google.Protobuf.Reflection.EnumValueDescriptor enumValue);
                /*0x1e86134*/ Google.Protobuf.Reflection.IDescriptor LookupSymbol(string name, Google.Protobuf.Reflection.IDescriptor relativeTo);
            }

            class DescriptorUtil
            {
                static System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(System.Collections.Generic.IList<TInput> input, Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput, TOutput> converter);

                class IndexedConverter<TInput, TOutput> : System.MulticastDelegate
                {
                    IndexedConverter(object object, nint method);
                    TOutput Invoke(TInput element, int index);
                    System.IAsyncResult BeginInvoke(TInput element, int index, System.AsyncCallback callback, object object);
                    TOutput EndInvoke(System.IAsyncResult result);
                }
            }

            class DescriptorValidationException : System.Exception
            {
                /*0x90*/ string name;
                /*0x98*/ string description;

                /*0x1e84eec*/ DescriptorValidationException(Google.Protobuf.Reflection.IDescriptor problemDescriptor, string description);
                /*0x1e864f0*/ DescriptorValidationException(Google.Protobuf.Reflection.IDescriptor problemDescriptor, string description, System.Exception cause);
                /*0x1e864e0*/ string get_ProblemSymbolName();
                /*0x1e864e8*/ string get_Description();
            }

            class EnumDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.EnumDescriptorProto proto;
                /*0x30*/ Google.Protobuf.Reflection.MessageDescriptor containingType;
                /*0x38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> values;
                /*0x40*/ System.Type clrType;

                /*0x1e86674*/ EnumDescriptor(Google.Protobuf.Reflection.EnumDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int index, System.Type clrType);
                /*0x1e868ec*/ Google.Protobuf.Reflection.EnumDescriptorProto get_Proto();
                /*0x1e868f4*/ string get_Name();
                /*0x1e86910*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x1e86988*/ System.Type get_ClrType();
                /*0x1e86990*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x1e86998*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> get_Values();
                /*0x1e869a0*/ Google.Protobuf.Reflection.EnumValueDescriptor FindValueByNumber(int number);
                /*0x1e869cc*/ Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(string name);
                /*0x1e86a58*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e86aec*/ Google.Protobuf.Reflection.EnumOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, T> extension);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor file;
                    /*0x18*/ Google.Protobuf.Reflection.EnumDescriptor <>4__this;

                    /*0x1e86834*/ <>c__DisplayClass4_0();
                    /*0x1e86b14*/ Google.Protobuf.Reflection.EnumValueDescriptor <.ctor>b__0(Google.Protobuf.Reflection.EnumValueDescriptorProto value, int i);
                }
            }

            class EnumValueDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.EnumDescriptor enumDescriptor;
                /*0x30*/ Google.Protobuf.Reflection.EnumValueDescriptorProto proto;

                /*0x1e86b94*/ EnumValueDescriptor(Google.Protobuf.Reflection.EnumValueDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.EnumDescriptor parent, int index);
                /*0x1e86c60*/ Google.Protobuf.Reflection.EnumValueDescriptorProto get_Proto();
                /*0x1e86c68*/ string get_Name();
                /*0x1e86118*/ int get_Number();
                /*0x1e86c84*/ Google.Protobuf.Reflection.EnumDescriptor get_EnumDescriptor();
                /*0x1e86c8c*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e86d20*/ Google.Protobuf.Reflection.EnumValueOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, T> extension);
            }

            class ExtensionAccessor : Google.Protobuf.Reflection.IFieldAccessor
            {
                /*0x10*/ Google.Protobuf.Extension extension;
                /*0x18*/ Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper helper;
                /*0x20*/ Google.Protobuf.Reflection.FieldDescriptor <Descriptor>k__BackingField;

                /*0x1e86d48*/ ExtensionAccessor(Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x1e86dcc*/ Google.Protobuf.Reflection.FieldDescriptor get_Descriptor();
                /*0x1e86dd4*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1e86e80*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x1e86f2c*/ object GetValue(Google.Protobuf.IMessage message);
                /*0x1e86fd4*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class ExtensionCollection
            {
                /*0x10*/ System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInDeclarationOrder;
                /*0x18*/ System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInNumberOrder;
                /*0x20*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <UnorderedExtensions>k__BackingField;

                /*0x1e87090*/ ExtensionCollection(Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Extension[] extensions);
                /*0x1e87198*/ ExtensionCollection(Google.Protobuf.Reflection.MessageDescriptor message, Google.Protobuf.Extension[] extensions);
                /*0x1e872a0*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_UnorderedExtensions();
                /*0x1e872a8*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInDeclarationOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                /*0x1e87350*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInNumberOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                /*0x1e873f8*/ void CrossLink();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Google.Protobuf.Extension[] extensions;
                    /*0x18*/ Google.Protobuf.Reflection.FileDescriptor file;

                    /*0x1e87190*/ <>c__DisplayClass2_0();
                    /*0x1e87f08*/ Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, int i);
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Protobuf.Extension[] extensions;
                    /*0x18*/ Google.Protobuf.Reflection.MessageDescriptor message;

                    /*0x1e87298*/ <>c__DisplayClass3_0();
                    /*0x1e88320*/ Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, int i);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ExtensionCollection.<> <>9;
                    static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, Google.Protobuf.Reflection.MessageDescriptor> <>9__9_0;
                    static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> <>9__9_1;
                    static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, Google.Protobuf.Reflection.MessageDescriptor> <>9__9_2;
                    static /*0x20*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, int> <>9__9_4;
                    static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> <>9__9_3;

                    static /*0x1e88428*/ <>c();
                    /*0x1e8848c*/ <>c();
                    /*0x1e88494*/ Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x1e884d0*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x1e88554*/ Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_2(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x1e88590*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_3(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x1e88704*/ int <CrossLink>b__9_4(Google.Protobuf.Reflection.FieldDescriptor field);
                }
            }

            class FieldAccessorBase : Google.Protobuf.Reflection.IFieldAccessor
            {
                /*0x10*/ System.Func<Google.Protobuf.IMessage, object> getValueDelegate;
                /*0x18*/ Google.Protobuf.Reflection.FieldDescriptor descriptor;

                /*0x1e88724*/ FieldAccessorBase(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x1e887c0*/ Google.Protobuf.Reflection.FieldDescriptor get_Descriptor();
                /*0x1e887c8*/ object GetValue(Google.Protobuf.IMessage message);
                bool HasValue(Google.Protobuf.IMessage message);
                void Clear(Google.Protobuf.IMessage message);
                void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class FieldDescriptor : Google.Protobuf.Reflection.DescriptorBase, System.IComparable<Google.Protobuf.Reflection.FieldDescriptor>
            {
                /*0x28*/ Google.Protobuf.Reflection.EnumDescriptor enumType;
                /*0x30*/ Google.Protobuf.Reflection.MessageDescriptor extendeeType;
                /*0x38*/ Google.Protobuf.Reflection.MessageDescriptor messageType;
                /*0x40*/ Google.Protobuf.Reflection.FieldType fieldType;
                /*0x48*/ Google.Protobuf.Reflection.IFieldAccessor accessor;
                /*0x50*/ Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;
                /*0x58*/ Google.Protobuf.Reflection.OneofDescriptor <ContainingOneof>k__BackingField;
                /*0x60*/ string <JsonName>k__BackingField;
                /*0x68*/ string <PropertyName>k__BackingField;
                /*0x70*/ Google.Protobuf.Reflection.FieldDescriptorProto <Proto>k__BackingField;
                /*0x78*/ Google.Protobuf.Extension <Extension>k__BackingField;

                static /*0x1e88928*/ Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type);
                /*0x1e87fec*/ FieldDescriptor(Google.Protobuf.Reflection.FieldDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int index, string propertyName, Google.Protobuf.Extension extension);
                /*0x1e887ec*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x1e887f4*/ Google.Protobuf.Reflection.OneofDescriptor get_ContainingOneof();
                /*0x1e887fc*/ Google.Protobuf.Reflection.OneofDescriptor get_RealContainingOneof();
                /*0x1e8881c*/ string get_JsonName();
                /*0x1e88824*/ string get_PropertyName();
                /*0x1e8882c*/ bool get_HasPresence();
                /*0x1e88918*/ Google.Protobuf.Reflection.FieldDescriptorProto get_Proto();
                /*0x1e88920*/ Google.Protobuf.Extension get_Extension();
                /*0x1e88998*/ string get_Name();
                /*0x1e889b4*/ Google.Protobuf.Reflection.IFieldAccessor get_Accessor();
                /*0x1e888b0*/ bool get_IsRepeated();
                /*0x1e889bc*/ bool get_IsRequired();
                /*0x1e888d8*/ bool get_IsMap();
                /*0x1e889e4*/ bool get_IsPacked();
                /*0x1e88a34*/ bool get_IsExtension();
                /*0x1e88a50*/ Google.Protobuf.Reflection.FieldType get_FieldType();
                /*0x1e85f70*/ int get_FieldNumber();
                /*0x1e88a58*/ int CompareTo(Google.Protobuf.Reflection.FieldDescriptor other);
                /*0x1e88af8*/ Google.Protobuf.Reflection.EnumDescriptor get_EnumType();
                /*0x1e88b60*/ Google.Protobuf.Reflection.MessageDescriptor get_MessageType();
                /*0x1e85ef8*/ Google.Protobuf.Reflection.MessageDescriptor get_ExtendeeType();
                /*0x1e88bcc*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e88c60*/ Google.Protobuf.Reflection.FieldOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, T> extension);
                /*0x1e87b20*/ void CrossLink();
                /*0x1e88c88*/ Google.Protobuf.Reflection.IFieldAccessor CreateAccessor();
            }

            enum FieldType
            {
                Double = 0,
                Float = 1,
                Int64 = 2,
                UInt64 = 3,
                Int32 = 4,
                Fixed64 = 5,
                Fixed32 = 6,
                Bool = 7,
                String = 8,
                Group = 9,
                Message = 10,
                Bytes = 11,
                UInt32 = 12,
                SFixed32 = 13,
                SFixed64 = 14,
                SInt32 = 15,
                SInt64 = 16,
                Enum = 17,
            }

            enum Syntax
            {
                Proto2 = 0,
                Proto3 = 1,
                Unknown = 2,
            }

            class FileDescriptor : Google.Protobuf.Reflection.IDescriptor
            {
                /*0x10*/ System.Lazy<System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor, Google.Protobuf.Reflection.DescriptorDeclaration>> declarations;
                /*0x18*/ Google.Protobuf.Reflection.FileDescriptorProto <Proto>k__BackingField;
                /*0x20*/ Google.Protobuf.Reflection.Syntax <Syntax>k__BackingField;
                /*0x28*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <MessageTypes>k__BackingField;
                /*0x30*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;
                /*0x38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> <Services>k__BackingField;
                /*0x40*/ Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;
                /*0x48*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <Dependencies>k__BackingField;
                /*0x50*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <PublicDependencies>k__BackingField;
                /*0x58*/ Google.Protobuf.ByteString <SerializedData>k__BackingField;
                /*0x60*/ Google.Protobuf.Reflection.DescriptorPool <DescriptorPool>k__BackingField;

                static /*0x1e88e60*/ FileDescriptor();
                static /*0x1e89368*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(Google.Protobuf.Reflection.FileDescriptor this, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, bool allowUnknownDependencies);
                static /*0x1e8a0cc*/ Google.Protobuf.Reflection.FileDescriptor BuildFrom(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor[] dependencies, bool allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                static /*0x1e8a7a0*/ Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(byte[] descriptorData, Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                static /*0x1e8ab40*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllExtensions(Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedInfo);
                static /*0x1e8ac9c*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(Google.Protobuf.Reflection.GeneratedClrTypeInfo generated);
                static /*0x1e8ae38*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(Google.Protobuf.Reflection.FileDescriptor descriptor);
                static /*0x1e8b14c*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                static /*0x1e8b3ac*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData, Google.Protobuf.ExtensionRegistry registry);
                static /*0x1e8be74*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData);
                static /*0x1e8bf30*/ Google.Protobuf.Reflection.FileDescriptor get_DescriptorProtoFileDescriptor();
                static void ForceReflectionInitialization<T>();
                /*0x1e88f20*/ FileDescriptor(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, Google.Protobuf.Reflection.DescriptorPool pool, bool allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                /*0x1e89710*/ System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor, Google.Protobuf.Reflection.DescriptorDeclaration> CreateDeclarationMap();
                /*0x1e89aec*/ Google.Protobuf.Reflection.IDescriptor FindDescriptorForPath(System.Collections.Generic.IList<int> path);
                /*0x1e89ee8*/ Google.Protobuf.Reflection.DescriptorBase GetDescriptorFromList(System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> list, int index);
                /*0x1e89e4c*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x1e83e84*/ Google.Protobuf.Reflection.DescriptorDeclaration GetDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor);
                /*0x1e8683c*/ string ComputeFullName(Google.Protobuf.Reflection.MessageDescriptor parent, string name);
                /*0x1e8a05c*/ Google.Protobuf.Reflection.FileDescriptorProto get_Proto();
                /*0x1e8a064*/ Google.Protobuf.Reflection.Syntax get_Syntax();
                /*0x1e84ed0*/ string get_Name();
                /*0x1e84b28*/ string get_Package();
                /*0x1e8a06c*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_MessageTypes();
                /*0x1e8a074*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes();
                /*0x1e8a07c*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> get_Services();
                /*0x1e8a084*/ Google.Protobuf.Reflection.ExtensionCollection get_Extensions();
                /*0x1e8a08c*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_Dependencies();
                /*0x1e8a094*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_PublicDependencies();
                /*0x1e8a09c*/ Google.Protobuf.ByteString get_SerializedData();
                /*0x1e8a0a4*/ string Google.Protobuf.Reflection.IDescriptor.get_FullName();
                /*0x1e8a0c0*/ Google.Protobuf.Reflection.FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File();
                /*0x1e8a0c4*/ Google.Protobuf.Reflection.DescriptorPool get_DescriptorPool();
                T FindTypeByName<T>(string name);
                /*0x1e8a234*/ void CrossLink();
                /*0x1e8becc*/ string ToString();
                /*0x1e8bfb8*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e8c04c*/ Google.Protobuf.Reflection.FileOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, T> extension);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor <>4__this;
                    /*0x18*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo;

                    /*0x1e8c074*/ <>c__DisplayClass2_0();
                    /*0x1e8c07c*/ Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__0(Google.Protobuf.Reflection.DescriptorProto message, int index);
                    /*0x1e8c99c*/ Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__1(Google.Protobuf.Reflection.EnumDescriptorProto enumType, int index);
                    /*0x1e8ca50*/ Google.Protobuf.Reflection.ServiceDescriptor <.ctor>b__2(Google.Protobuf.Reflection.ServiceDescriptorProto service, int index);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.Reflection.FileDescriptor, string> <>9__9_0;
                    static /*0x10*/ System.Func<Google.Protobuf.Reflection.GeneratedClrTypeInfo, bool> <>9__53_0;
                    static /*0x18*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, Google.Protobuf.Extension> <>9__54_0;
                    static /*0x20*/ System.Func<Google.Protobuf.Extension, bool> <>9__54_1;
                    static /*0x28*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, Google.Protobuf.Extension> <>9__55_0;
                    static /*0x30*/ System.Func<Google.Protobuf.Extension, bool> <>9__55_1;

                    static /*0x1e8cc1c*/ <>c();
                    /*0x1e8cc80*/ <>c();
                    /*0x1e8cc88*/ string <DeterminePublicDependencies>b__9_0(Google.Protobuf.Reflection.FileDescriptor file);
                    /*0x1e8cca0*/ bool <GetAllGeneratedExtensions>b__53_0(Google.Protobuf.Reflection.GeneratedClrTypeInfo t);
                    /*0x1e8ccac*/ Google.Protobuf.Extension <GetAllDependedExtensions>b__54_0(Google.Protobuf.Reflection.FieldDescriptor s);
                    /*0x1e8ccc4*/ bool <GetAllDependedExtensions>b__54_1(Google.Protobuf.Extension e);
                    /*0x1e8ccd0*/ Google.Protobuf.Extension <GetAllDependedExtensionsFromMessage>b__55_0(Google.Protobuf.Reflection.FieldDescriptor s);
                    /*0x1e8cce8*/ bool <GetAllDependedExtensionsFromMessage>b__55_1(Google.Protobuf.Extension e);
                }
            }

            class GeneratedClrTypeInfo
            {
                static /*0x0*/ string[] EmptyNames;
                static /*0x8*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo[] EmptyCodeInfo;
                static /*0x10*/ Google.Protobuf.Extension[] EmptyExtensions;
                /*0x10*/ System.Type <ClrType>k__BackingField;
                /*0x18*/ Google.Protobuf.MessageParser <Parser>k__BackingField;
                /*0x20*/ string[] <PropertyNames>k__BackingField;
                /*0x28*/ Google.Protobuf.Extension[] <Extensions>k__BackingField;
                /*0x30*/ string[] <OneofNames>k__BackingField;
                /*0x38*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo[] <NestedTypes>k__BackingField;
                /*0x40*/ System.Type[] <NestedEnums>k__BackingField;

                static /*0x1e8cf14*/ GeneratedClrTypeInfo();
                /*0x1e8cd34*/ GeneratedClrTypeInfo(System.Type clrType, Google.Protobuf.MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x1e8ce8c*/ GeneratedClrTypeInfo(System.Type clrType, Google.Protobuf.MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x1e8ceac*/ GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x1e8cee0*/ GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x1e8ccf4*/ System.Type get_ClrType();
                /*0x1e8ccfc*/ void set_ClrType(System.Type value);
                /*0x1e8cd04*/ Google.Protobuf.MessageParser get_Parser();
                /*0x1e8cd0c*/ string[] get_PropertyNames();
                /*0x1e8cd14*/ Google.Protobuf.Extension[] get_Extensions();
                /*0x1e8cd1c*/ string[] get_OneofNames();
                /*0x1e8cd24*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo[] get_NestedTypes();
                /*0x1e8cd2c*/ System.Type[] get_NestedEnums();
            }

            interface IDescriptor
            {
                string get_Name();
                string get_FullName();
                Google.Protobuf.Reflection.FileDescriptor get_File();
            }

            interface IFieldAccessor
            {
                Google.Protobuf.Reflection.FieldDescriptor get_Descriptor();
                void Clear(Google.Protobuf.IMessage message);
                object GetValue(Google.Protobuf.IMessage message);
                bool HasValue(Google.Protobuf.IMessage message);
                void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class MapFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
            {
                /*0x1e8cfdc*/ MapFieldAccessor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x1e8cfe4*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1e8d0dc*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x1e8d12c*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class MessageDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                static /*0x0*/ System.Collections.Generic.HashSet<string> WellKnownTypeNames;
                /*0x28*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder;
                /*0x30*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder;
                /*0x38*/ System.Collections.Generic.IDictionary<string, Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap;
                /*0x40*/ System.Func<Google.Protobuf.IMessage, bool> extensionSetIsInitialized;
                /*0x48*/ Google.Protobuf.Reflection.DescriptorProto <Proto>k__BackingField;
                /*0x50*/ System.Type <ClrType>k__BackingField;
                /*0x58*/ Google.Protobuf.MessageParser <Parser>k__BackingField;
                /*0x60*/ Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;
                /*0x68*/ Google.Protobuf.Reflection.MessageDescriptor.FieldCollection <Fields>k__BackingField;
                /*0x70*/ Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;
                /*0x78*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <NestedTypes>k__BackingField;
                /*0x80*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;
                /*0x88*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> <Oneofs>k__BackingField;
                /*0x90*/ int <RealOneofCount>k__BackingField;

                static /*0x1e8e7c8*/ MessageDescriptor();
                static /*0x1e8d184*/ System.Collections.ObjectModel.ReadOnlyDictionary<string, Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields);
                /*0x1e8c12c*/ MessageDescriptor(Google.Protobuf.Reflection.DescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int typeIndex, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                /*0x1e8d560*/ string get_Name();
                /*0x1e8d57c*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x1e8d618*/ Google.Protobuf.Reflection.DescriptorProto get_Proto();
                /*0x1e8d620*/ bool IsExtensionsInitialized(Google.Protobuf.IMessage message);
                /*0x1e8d894*/ System.Type get_ClrType();
                /*0x1e8d89c*/ Google.Protobuf.MessageParser get_Parser();
                /*0x1e8d8a4*/ bool get_IsWellKnownType();
                /*0x1e8d980*/ bool get_IsWrapperType();
                /*0x1e8da20*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x1e8da28*/ Google.Protobuf.Reflection.MessageDescriptor.FieldCollection get_Fields();
                /*0x1e8da30*/ Google.Protobuf.Reflection.ExtensionCollection get_Extensions();
                /*0x1e8da38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_NestedTypes();
                /*0x1e8da40*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes();
                /*0x1e8da48*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> get_Oneofs();
                /*0x1e8da50*/ int get_RealOneofCount();
                /*0x1e8da58*/ Google.Protobuf.Reflection.FieldDescriptor FindFieldByName(string name);
                /*0x1e8dae4*/ Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(int number);
                T FindDescriptor<T>(string name);
                /*0x1e8db14*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e8dba8*/ Google.Protobuf.Reflection.MessageOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, T> extension);
                /*0x1e8dbd4*/ void CrossLink();

                class FieldCollection
                {
                    /*0x10*/ Google.Protobuf.Reflection.MessageDescriptor messageDescriptor;

                    /*0x1e8d538*/ FieldCollection(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor);
                    /*0x1e8e9f0*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder();
                    /*0x1e8ea0c*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder();
                    /*0x1e8ea28*/ System.Collections.Generic.IDictionary<string, Google.Protobuf.Reflection.FieldDescriptor> ByJsonName();
                    /*0x1e8ea44*/ Google.Protobuf.Reflection.FieldDescriptor get_Item(int number);
                    /*0x1e8eab0*/ Google.Protobuf.Reflection.FieldDescriptor get_Item(string name);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor file;
                    /*0x18*/ Google.Protobuf.Reflection.MessageDescriptor <>4__this;
                    /*0x20*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo;

                    /*0x1e8d17c*/ <>c__DisplayClass5_0();
                    /*0x1e8eb1c*/ Google.Protobuf.Reflection.OneofDescriptor <.ctor>b__0(Google.Protobuf.Reflection.OneofDescriptorProto oneof, int index);
                    /*0x1e8ed64*/ Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__1(Google.Protobuf.Reflection.DescriptorProto type, int index);
                    /*0x1e8ee20*/ Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__2(Google.Protobuf.Reflection.EnumDescriptorProto type, int index);
                    /*0x1e8eee0*/ Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__3(Google.Protobuf.Reflection.FieldDescriptorProto field, int index);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MessageDescriptor.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, int> <>9__5_4;

                    static /*0x1e8efa4*/ <>c();
                    /*0x1e8f008*/ <>c();
                    /*0x1e8f010*/ int <.ctor>b__5_4(Google.Protobuf.Reflection.FieldDescriptor field);
                }
            }

            class MethodDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.MethodDescriptorProto proto;
                /*0x30*/ Google.Protobuf.Reflection.ServiceDescriptor service;
                /*0x38*/ Google.Protobuf.Reflection.MessageDescriptor inputType;
                /*0x40*/ Google.Protobuf.Reflection.MessageDescriptor outputType;

                /*0x1e8f138*/ MethodDescriptor(Google.Protobuf.Reflection.MethodDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.ServiceDescriptor parent, int index);
                /*0x1e8f028*/ Google.Protobuf.Reflection.ServiceDescriptor get_Service();
                /*0x1e8f030*/ Google.Protobuf.Reflection.MessageDescriptor get_InputType();
                /*0x1e8f038*/ Google.Protobuf.Reflection.MessageDescriptor get_OutputType();
                /*0x1e8f040*/ bool get_IsClientStreaming();
                /*0x1e8f05c*/ bool get_IsServerStreaming();
                /*0x1e8f078*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e8f10c*/ Google.Protobuf.Reflection.MethodOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, T> extension);
                /*0x1e8f1f8*/ Google.Protobuf.Reflection.MethodDescriptorProto get_Proto();
                /*0x1e8f200*/ string get_Name();
                /*0x1e8f21c*/ void CrossLink();
            }

            class OneofAccessor
            {
                /*0x10*/ System.Func<Google.Protobuf.IMessage, int> caseDelegate;
                /*0x18*/ System.Action<Google.Protobuf.IMessage> clearDelegate;
                /*0x20*/ Google.Protobuf.Reflection.OneofDescriptor <Descriptor>k__BackingField;

                static /*0x1e8f400*/ Google.Protobuf.Reflection.OneofAccessor ForRegularOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Reflection.PropertyInfo caseProperty, System.Reflection.MethodInfo clearMethod);
                static /*0x1e8f72c*/ Google.Protobuf.Reflection.OneofAccessor ForSyntheticOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor);
                /*0x1e8f3c4*/ OneofAccessor(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Func<Google.Protobuf.IMessage, int> caseDelegate, System.Action<Google.Protobuf.IMessage> clearDelegate);
                /*0x1e8f864*/ Google.Protobuf.Reflection.OneofDescriptor get_Descriptor();
                /*0x1e8f86c*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1e8f890*/ Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(Google.Protobuf.IMessage message);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.OneofDescriptor descriptor;

                    /*0x1e8f85c*/ <>c__DisplayClass4_0();
                    /*0x1e8f8e4*/ int <ForSyntheticOneof>b__0(Google.Protobuf.IMessage message);
                    /*0x1e8faac*/ void <ForSyntheticOneof>b__1(Google.Protobuf.IMessage message);
                }
            }

            class OneofDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.OneofDescriptorProto proto;
                /*0x30*/ Google.Protobuf.Reflection.MessageDescriptor containingType;
                /*0x38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields;
                /*0x40*/ Google.Protobuf.Reflection.OneofAccessor accessor;
                /*0x48*/ bool <IsSynthetic>k__BackingField;

                /*0x1e8ebd8*/ OneofDescriptor(Google.Protobuf.Reflection.OneofDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int index, string clrName);
                /*0x1e8fe1c*/ string get_Name();
                /*0x1e8fe38*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x1e8fe40*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_Fields();
                /*0x1e8fe48*/ bool get_IsSynthetic();
                /*0x1e8fe50*/ Google.Protobuf.Reflection.OneofAccessor get_Accessor();
                /*0x1e8fe58*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e8feec*/ Google.Protobuf.Reflection.OneofOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, T> extension);
                /*0x1e8e3c8*/ void CrossLink();
                /*0x1e8fbe4*/ Google.Protobuf.Reflection.OneofAccessor CreateAccessor(string clrName);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ int index;

                    /*0x1e8fbdc*/ <>c__DisplayClass4_0();
                    /*0x1e8ff18*/ bool <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto fieldProto);
                }
            }

            class OriginalNameAttribute : System.Attribute
            {
                /*0x10*/ string <Name>k__BackingField;
                /*0x18*/ bool <PreferredAlias>k__BackingField;

                /*0x1e8ff90*/ OriginalNameAttribute(string name);
                /*0x1e8ff6c*/ string get_Name();
                /*0x1e8ff74*/ void set_Name(string value);
                /*0x1e8ff7c*/ bool get_PreferredAlias();
                /*0x1e8ff84*/ void set_PreferredAlias(bool value);
            }

            class PackageDescriptor : Google.Protobuf.Reflection.IDescriptor
            {
                /*0x10*/ string name;
                /*0x18*/ string fullName;
                /*0x20*/ Google.Protobuf.Reflection.FileDescriptor file;

                /*0x1e90018*/ PackageDescriptor(string name, string fullName, Google.Protobuf.Reflection.FileDescriptor file);
                /*0x1e90054*/ string get_Name();
                /*0x1e9005c*/ string get_FullName();
                /*0x1e90064*/ Google.Protobuf.Reflection.FileDescriptor get_File();
            }

            class ReflectionUtil
            {
                static /*0x0*/ System.Type[] EmptyTypes;
                static /*0x8*/ bool <CanConvertEnumFuncToInt32Func>k__BackingField;

                static /*0x1e9006c*/ ReflectionUtil();
                static void ForceInitialize<T>();
                static /*0x1e90430*/ System.Func<Google.Protobuf.IMessage, object> CreateFuncIMessageObject(System.Reflection.MethodInfo method);
                static /*0x1e8f4d0*/ System.Func<Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(System.Reflection.MethodInfo method);
                static /*0x1e906ac*/ System.Action<Google.Protobuf.IMessage, object> CreateActionIMessageObject(System.Reflection.MethodInfo method);
                static /*0x1e8f5dc*/ System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method);
                static /*0x1e907e4*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBool(System.Reflection.MethodInfo method);
                static /*0x1e8d6dc*/ System.Func<Google.Protobuf.IMessage, bool> CreateIsInitializedCaller(System.Type msg);
                static /*0x1e908f4*/ Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension);
                static /*0x1e90540*/ Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2);
                static /*0x1e90b00*/ bool get_CanConvertEnumFuncToInt32Func();
                static /*0x1e902c4*/ bool CheckCanConvertEnumFuncToInt32Func();
                static /*0x1e90428*/ Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod();

                interface IReflectionHelper
                {
                    System.Func<Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(System.Reflection.MethodInfo method);
                    System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method);
                    System.Func<Google.Protobuf.IMessage, object> CreateFuncIMessageObject(System.Reflection.MethodInfo method);
                    System.Action<Google.Protobuf.IMessage, object> CreateActionIMessageObject(System.Reflection.MethodInfo method);
                    System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBool(System.Reflection.MethodInfo method);
                }

                interface IExtensionReflectionHelper
                {
                    object GetExtension(Google.Protobuf.IMessage message);
                    void SetExtension(Google.Protobuf.IMessage message, object value);
                    bool HasExtension(Google.Protobuf.IMessage message);
                    void ClearExtension(Google.Protobuf.IMessage message);
                }

                interface IExtensionSetReflector
                {
                    System.Func<Google.Protobuf.IMessage, bool> CreateIsInitializedCaller();
                }

                class ReflectionHelper<T1, T2> : Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper
                {
                    ReflectionHelper();
                    System.Func<Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(System.Reflection.MethodInfo method);
                    System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method);
                    System.Func<Google.Protobuf.IMessage, object> CreateFuncIMessageObject(System.Reflection.MethodInfo method);
                    System.Action<Google.Protobuf.IMessage, object> CreateActionIMessageObject(System.Reflection.MethodInfo method);
                    System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBool(System.Reflection.MethodInfo method);

                    class <>c__DisplayClass0_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, int> del;

                        <>c__DisplayClass0_0();
                        int <CreateFuncIMessageInt32>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass0_1<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, T2> del;

                        <>c__DisplayClass0_1();
                        int <CreateFuncIMessageInt32>b__1(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass1_0<T1, T2>
                    {
                        /*0x0*/ System.Action<T1> del;

                        <>c__DisplayClass1_0();
                        void <CreateActionIMessage>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass2_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, T2> del;

                        <>c__DisplayClass2_0();
                        object <CreateFuncIMessageObject>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass3_0<T1, T2>
                    {
                        /*0x0*/ System.Action<T1, T2> del;

                        <>c__DisplayClass3_0();
                        void <CreateActionIMessageObject>b__0(Google.Protobuf.IMessage message, object arg);
                    }

                    class <>c__DisplayClass4_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, bool> del;

                        <>c__DisplayClass4_0();
                        bool <CreateFuncIMessageBool>b__0(Google.Protobuf.IMessage message);
                    }
                }

                class ExtensionReflectionHelper<T1, T3> : Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper
                {
                    /*0x0*/ Google.Protobuf.Extension extension;

                    ExtensionReflectionHelper(Google.Protobuf.Extension extension);
                    object GetExtension(Google.Protobuf.IMessage message);
                    bool HasExtension(Google.Protobuf.IMessage message);
                    void SetExtension(Google.Protobuf.IMessage message, object value);
                    void ClearExtension(Google.Protobuf.IMessage message);
                }

                class ExtensionSetReflector<T1> : Google.Protobuf.Reflection.ReflectionUtil.IExtensionSetReflector
                {
                    ExtensionSetReflector();
                    System.Func<Google.Protobuf.IMessage, bool> CreateIsInitializedCaller();

                    class <>c__DisplayClass0_0<T1>
                    {
                        /*0x0*/ System.Func<T1, Google.Protobuf.ExtensionSet<T1>> getFunc;
                        /*0x0*/ System.Func<Google.Protobuf.ExtensionSet<T1>, bool> initializedFunc;

                        <>c__DisplayClass0_0();
                        bool <CreateIsInitializedCaller>b__0(Google.Protobuf.IMessage m);
                    }
                }

                enum SampleEnum
                {
                    X = 0,
                }
            }

            class RepeatedFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
            {
                /*0x1e90b58*/ RepeatedFieldAccessor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x1e90b60*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1e90c58*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x1e90ca8*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class ServiceDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.ServiceDescriptorProto proto;
                /*0x30*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> methods;

                /*0x1e8cacc*/ ServiceDescriptor(Google.Protobuf.Reflection.ServiceDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, int index);
                /*0x1e90d00*/ string get_Name();
                /*0x1e90d1c*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x1e90d94*/ Google.Protobuf.Reflection.ServiceDescriptorProto get_Proto();
                /*0x1e90d9c*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> get_Methods();
                /*0x1e90da4*/ Google.Protobuf.Reflection.MethodDescriptor FindMethodByName(string name);
                /*0x1e90e30*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x1e90ec4*/ Google.Protobuf.Reflection.ServiceOptions GetOptions();
                T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, T> extension);
                Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, T> extension);
                /*0x1e90ef0*/ void CrossLink();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor file;
                    /*0x18*/ Google.Protobuf.Reflection.ServiceDescriptor <>4__this;

                    /*0x1e90cf8*/ <>c__DisplayClass2_0();
                    /*0x1e911c0*/ Google.Protobuf.Reflection.MethodDescriptor <.ctor>b__0(Google.Protobuf.Reflection.MethodDescriptorProto method, int i);
                }
            }

            class SingleFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
            {
                /*0x20*/ System.Action<Google.Protobuf.IMessage, object> setValueDelegate;
                /*0x28*/ System.Action<Google.Protobuf.IMessage> clearDelegate;
                /*0x30*/ System.Func<Google.Protobuf.IMessage, bool> hasDelegate;

                /*0x1e91240*/ SingleFieldAccessor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x1e918e8*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1e9190c*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x1e91930*/ void SetValue(Google.Protobuf.IMessage message, object value);

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.SingleFieldAccessor <>4__this;
                    /*0x18*/ Google.Protobuf.Reflection.FieldDescriptor descriptor;

                    /*0x1e918d0*/ <>c__DisplayClass3_0();
                    /*0x1e91954*/ bool <.ctor>b__0(Google.Protobuf.IMessage message);
                    /*0x1e9197c*/ void <.ctor>b__1(Google.Protobuf.IMessage message);
                }

                class <>c__DisplayClass3_1
                {
                    /*0x10*/ Google.Protobuf.Reflection.OneofAccessor oneofAccessor;
                    /*0x18*/ Google.Protobuf.Reflection.SingleFieldAccessor.<> CS$<>8__locals1;

                    /*0x1e918d8*/ <>c__DisplayClass3_1();
                    /*0x1e919a0*/ bool <.ctor>b__2(Google.Protobuf.IMessage message);
                    /*0x1e919d4*/ void <.ctor>b__3(Google.Protobuf.IMessage message);
                }

                class <>c__DisplayClass3_2
                {
                    /*0x10*/ object defaultValue;
                    /*0x18*/ Google.Protobuf.Reflection.SingleFieldAccessor.<> CS$<>8__locals2;

                    /*0x1e918e0*/ <>c__DisplayClass3_2();
                    /*0x1e91a40*/ void <.ctor>b__5(Google.Protobuf.IMessage message);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.SingleFieldAccessor.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.IMessage, bool> <>9__3_4;

                    static /*0x1e91a70*/ <>c();
                    /*0x1e91ad4*/ <>c();
                    /*0x1e91adc*/ bool <.ctor>b__3_4(Google.Protobuf.IMessage message);
                }
            }

            class TypeRegistry
            {
                static /*0x0*/ Google.Protobuf.Reflection.TypeRegistry <Empty>k__BackingField;
                /*0x10*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap;

                static /*0x1e9282c*/ TypeRegistry();
                static /*0x1e91b2c*/ Google.Protobuf.Reflection.TypeRegistry get_Empty();
                static /*0x1e91c1c*/ Google.Protobuf.Reflection.TypeRegistry FromFiles(Google.Protobuf.Reflection.FileDescriptor[] fileDescriptors);
                static /*0x1e91c70*/ Google.Protobuf.Reflection.TypeRegistry FromFiles(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> fileDescriptors);
                static /*0x1e92674*/ Google.Protobuf.Reflection.TypeRegistry FromMessages(Google.Protobuf.Reflection.MessageDescriptor[] messageDescriptors);
                static /*0x1e926c8*/ Google.Protobuf.Reflection.TypeRegistry FromMessages(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.MessageDescriptor> messageDescriptors);
                /*0x1e91b84*/ TypeRegistry(System.Collections.Generic.Dictionary<string, Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap);
                /*0x1e91bac*/ Google.Protobuf.Reflection.MessageDescriptor Find(string fullName);

                class Builder
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.Reflection.MessageDescriptor> types;
                    /*0x18*/ System.Collections.Generic.HashSet<string> fileDescriptorNames;

                    /*0x1e91fa0*/ Builder();
                    /*0x1e92064*/ void AddFile(Google.Protobuf.Reflection.FileDescriptor fileDescriptor);
                    /*0x1e928d4*/ void AddMessage(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor);
                    /*0x1e9260c*/ Google.Protobuf.Reflection.TypeRegistry Build();
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.TypeRegistry.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.Reflection.MessageDescriptor, Google.Protobuf.Reflection.FileDescriptor> <>9__9_0;

                    static /*0x1e92bdc*/ <>c();
                    /*0x1e92c40*/ <>c();
                    /*0x1e92c48*/ Google.Protobuf.Reflection.FileDescriptor <FromMessages>b__9_0(Google.Protobuf.Reflection.MessageDescriptor md);
                }
            }
        }

        namespace Compatibility
        {
            class PropertyInfoExtensions
            {
                static /*0x1e92c60*/ System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo target);
                static /*0x1e92cb8*/ System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo target);
            }

            class TypeExtensions
            {
                static /*0x1e92d10*/ bool IsAssignableFrom(System.Type target, System.Type c);
                static /*0x1e92d5c*/ System.Reflection.PropertyInfo GetProperty(System.Type target, string name);
                static /*0x1e92eac*/ System.Reflection.MethodInfo GetMethod(System.Type target, string name);
            }
        }

        namespace Collections
        {
            class Lists
            {
                static bool Equals<T>(System.Collections.Generic.List<T> left, System.Collections.Generic.List<T> right);
                static int GetHashCode<T>(System.Collections.Generic.List<T> list);
            }

            class MapField<TKey, TValue> : Google.Protobuf.IDeepCloneable<Google.Protobuf.Collections.MapField<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.IEquatable<Google.Protobuf.Collections.MapField<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                static /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> ValueEqualityComparer;
                static /*0x0*/ System.Collections.Generic.EqualityComparer<TKey> KeyEqualityComparer;
                /*0x0*/ System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.LinkedListNode<System.Collections.Generic.KeyValuePair<TKey, TValue>>> map;
                /*0x0*/ System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<TKey, TValue>> list;

                static MapField();
                static int CalculateEntrySize(Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec, System.Collections.Generic.KeyValuePair<TKey, TValue> entry);
                MapField();
                Google.Protobuf.Collections.MapField<TKey, TValue> Clone();
                void Add(TKey key, TValue value);
                bool ContainsKey(TKey key);
                bool ContainsValue(TValue value);
                bool Remove(TKey key);
                bool TryGetValue(TKey key, ref TValue value);
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                System.Collections.Generic.ICollection<TKey> get_Keys();
                System.Collections.Generic.ICollection<TValue> get_Values();
                void Add(System.Collections.Generic.IDictionary<TKey, TValue> entries);
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                void Clear();
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                int get_Count();
                bool get_IsReadOnly();
                bool Equals(object other);
                int GetHashCode();
                bool Equals(Google.Protobuf.Collections.MapField<TKey, TValue> other);
                void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                void AddEntriesFrom(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                void WriteTo(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                int CalculateSize(Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                string ToString();
                void System.Collections.IDictionary.Add(object key, object value);
                bool System.Collections.IDictionary.Contains(object key);
                System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                void System.Collections.IDictionary.Remove(object key);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                bool System.Collections.IDictionary.get_IsFixedSize();
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                System.Collections.ICollection System.Collections.IDictionary.get_Values();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                object System.Collections.IDictionary.get_Item(object key);
                void System.Collections.IDictionary.set_Item(object key, object value);
                System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();

                class DictionaryEnumerator<TKey, TValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> enumerator;

                    DictionaryEnumerator(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> enumerator);
                    bool MoveNext();
                    void Reset();
                    object get_Current();
                    System.Collections.DictionaryEntry get_Entry();
                    object get_Key();
                    object get_Value();
                }

                class Codec<TKey, TValue>
                {
                    /*0x0*/ Google.Protobuf.FieldCodec<TKey> keyCodec;
                    /*0x0*/ Google.Protobuf.FieldCodec<TValue> valueCodec;
                    /*0x0*/ uint mapTag;

                    Codec(Google.Protobuf.FieldCodec<TKey> keyCodec, Google.Protobuf.FieldCodec<TValue> valueCodec, uint mapTag);
                    Google.Protobuf.FieldCodec<TKey> get_KeyCodec();
                    Google.Protobuf.FieldCodec<TValue> get_ValueCodec();
                    uint get_MapTag();
                }

                class MapView`1<TKey, TValue, T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ Google.Protobuf.Collections.MapField<TKey, TValue> parent;
                    /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, T> projection;
                    /*0x0*/ System.Func<T, bool> containsCheck;

                    MapView`1(Google.Protobuf.Collections.MapField<TKey, TValue> parent, System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, T> projection, System.Func<T, bool> containsCheck);
                    int get_Count();
                    bool get_IsReadOnly();
                    bool get_IsSynchronized();
                    object get_SyncRoot();
                    void Add(T item);
                    void Clear();
                    bool Contains(T item);
                    void CopyTo(T[] array, int arrayIndex);
                    System.Collections.Generic.IEnumerator<T> GetEnumerator();
                    bool Remove(T item);
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    void CopyTo(System.Array array, int index);
                }

                class <>c__DisplayClass7_0<TKey, TValue>
                {
                    /*0x0*/ TValue value;

                    <>c__DisplayClass7_0();
                    bool <ContainsValue>b__0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ Google.Protobuf.Collections.MapField.<>c<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TKey> <>9__14_0;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TValue> <>9__16_0;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Collections.DictionaryEntry> <>9__43_0;

                    static <>c();
                    <>c();
                    TKey <get_Keys>b__14_0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                    TValue <get_Values>b__16_0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                    System.Collections.DictionaryEntry <System.Collections.ICollection.CopyTo>b__43_0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                }
            }

            class ProtobufEqualityComparers
            {
                static /*0x0*/ System.Collections.Generic.EqualityComparer<double> <BitwiseDoubleEqualityComparer>k__BackingField;
                static /*0x8*/ System.Collections.Generic.EqualityComparer<float> <BitwiseSingleEqualityComparer>k__BackingField;
                static /*0x10*/ System.Collections.Generic.EqualityComparer<System.Nullable<double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField;
                static /*0x18*/ System.Collections.Generic.EqualityComparer<System.Nullable<float>> <BitwiseNullableSingleEqualityComparer>k__BackingField;

                static /*0x1e930f4*/ ProtobufEqualityComparers();
                static System.Collections.Generic.EqualityComparer<T> GetEqualityComparer<T>();
                static /*0x1e92f94*/ System.Collections.Generic.EqualityComparer<double> get_BitwiseDoubleEqualityComparer();
                static /*0x1e92fec*/ System.Collections.Generic.EqualityComparer<float> get_BitwiseSingleEqualityComparer();
                static /*0x1e93044*/ System.Collections.Generic.EqualityComparer<System.Nullable<double>> get_BitwiseNullableDoubleEqualityComparer();
                static /*0x1e9309c*/ System.Collections.Generic.EqualityComparer<System.Nullable<float>> get_BitwiseNullableSingleEqualityComparer();

                class BitwiseDoubleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<double>
                {
                    /*0x1e93204*/ BitwiseDoubleEqualityComparerImpl();
                    /*0x1e93324*/ bool Equals(double x, double y);
                    /*0x1e93390*/ int GetHashCode(double obj);
                }

                class BitwiseSingleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<float>
                {
                    /*0x1e9324c*/ BitwiseSingleEqualityComparerImpl();
                    /*0x1e93404*/ bool Equals(float x, float y);
                    /*0x1e93478*/ int GetHashCode(float obj);
                }

                class BitwiseNullableDoubleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<System.Nullable<double>>
                {
                    /*0x1e93294*/ BitwiseNullableDoubleEqualityComparerImpl();
                    /*0x1e934f0*/ bool Equals(System.Nullable<double> x, System.Nullable<double> y);
                    /*0x1e93614*/ int GetHashCode(System.Nullable<double> obj);
                }

                class BitwiseNullableSingleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<System.Nullable<float>>
                {
                    /*0x1e932dc*/ BitwiseNullableSingleEqualityComparerImpl();
                    /*0x1e93704*/ bool Equals(System.Nullable<float> x, System.Nullable<float> y);
                    /*0x1e93828*/ int GetHashCode(System.Nullable<float> obj);
                }
            }

            class ReadOnlyDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TKey, TValue> wrapped;

                ReadOnlyDictionary(System.Collections.Generic.IDictionary<TKey, TValue> wrapped);
                void Add(TKey key, TValue value);
                bool ContainsKey(TKey key);
                System.Collections.Generic.ICollection<TKey> get_Keys();
                bool Remove(TKey key);
                bool TryGetValue(TKey key, ref TValue value);
                System.Collections.Generic.ICollection<TValue> get_Values();
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                void Clear();
                bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                int get_Count();
                bool get_IsReadOnly();
                bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                bool Equals(object obj);
                int GetHashCode();
                string ToString();
            }

            class RepeatedField<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, Google.Protobuf.IDeepCloneable<Google.Protobuf.Collections.RepeatedField<T>>, System.IEquatable<Google.Protobuf.Collections.RepeatedField<T>>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>
            {
                static int MinArraySize = 8;
                static /*0x0*/ System.Collections.Generic.EqualityComparer<T> EqualityComparer;
                static /*0x0*/ T[] EmptyArray;
                /*0x0*/ T[] array;
                /*0x0*/ int count;

                static RepeatedField();
                RepeatedField();
                Google.Protobuf.Collections.RepeatedField<T> Clone();
                void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.FieldCodec<T> codec);
                void AddEntriesFrom(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.FieldCodec<T> codec);
                int CalculateSize(Google.Protobuf.FieldCodec<T> codec);
                int CalculatePackedDataSize(Google.Protobuf.FieldCodec<T> codec);
                void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.FieldCodec<T> codec);
                void WriteTo(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.FieldCodec<T> codec);
                int get_Capacity();
                void set_Capacity(int value);
                void EnsureSize(int size);
                void SetSize(int size);
                void Add(T item);
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int arrayIndex);
                bool Remove(T item);
                int get_Count();
                bool get_IsReadOnly();
                void AddRange(System.Collections.Generic.IEnumerable<T> values);
                void Add(System.Collections.Generic.IEnumerable<T> values);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                bool Equals(object obj);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                int GetHashCode();
                bool Equals(Google.Protobuf.Collections.RepeatedField<T> other);
                int IndexOf(T item);
                void Insert(int index, T item);
                void RemoveAt(int index);
                string ToString();
                T get_Item(int index);
                void set_Item(int index, T value);
                bool System.Collections.IList.get_IsFixedSize();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                object System.Collections.IList.get_Item(int index);
                void System.Collections.IList.set_Item(int index, object value);
                int System.Collections.IList.Add(object value);
                bool System.Collections.IList.Contains(object value);
                int System.Collections.IList.IndexOf(object value);
                void System.Collections.IList.Insert(int index, object value);
                void System.Collections.IList.Remove(object value);

                class <GetEnumerator>d__28<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ Google.Protobuf.Collections.RepeatedField<T> <>4__this;
                    /*0x0*/ int <i>5__2;

                    <GetEnumerator>d__28(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    T System.Collections.Generic.IEnumerator<T>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1EFF1891409D680B30DE202BD7A16F945ED09F02601C0E7B90FD917BE1162300;

    struct __StaticArrayInitTypeSize=44
    {
    }
}
