class <Module>
{
}

class <>f__AnonymousType0<<Assembly>j__TPar, <Attribute>j__TPar>
{
    /*0x0*/ <Assembly> <Assembly>i__Field;
    /*0x0*/ <Attribute> <Attribute>i__Field;

    <>f__AnonymousType0(<Assembly> Assembly, <Attribute> Attribute);
    <Assembly> get_Assembly();
    <Attribute> get_Attribute();
    bool Equals(object value);
    int GetHashCode();
    string ToString();
}

namespace Sirenix
{
    namespace OdinInspector
    {
        class SerializedBehaviour : UnityEngine.Behaviour, UnityEngine.ISerializationCallbackReceiver, Sirenix.Serialization.ISupportsPrefabSerialization
        {
            /*0x18*/ Sirenix.Serialization.SerializationData serializationData;

            /*0x228c9cc*/ SerializedBehaviour();
            /*0x228c8a0*/ Sirenix.Serialization.SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData();
            /*0x228c8bc*/ void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(Sirenix.Serialization.SerializationData value);
            /*0x228c8d8*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x228c94c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x228c9c4*/ void OnAfterDeserialize();
            /*0x228c9c8*/ void OnBeforeSerialize();
        }

        class SerializedComponent : UnityEngine.Component, UnityEngine.ISerializationCallbackReceiver, Sirenix.Serialization.ISupportsPrefabSerialization
        {
            /*0x18*/ Sirenix.Serialization.SerializationData serializationData;

            /*0x228cb00*/ SerializedComponent();
            /*0x228c9d4*/ Sirenix.Serialization.SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData();
            /*0x228c9f0*/ void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(Sirenix.Serialization.SerializationData value);
            /*0x228ca0c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x228ca80*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x228caf8*/ void OnAfterDeserialize();
            /*0x228cafc*/ void OnBeforeSerialize();
        }

        class SerializedMonoBehaviour : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, Sirenix.Serialization.ISupportsPrefabSerialization
        {
            /*0x18*/ Sirenix.Serialization.SerializationData serializationData;

            /*0x228cc34*/ SerializedMonoBehaviour();
            /*0x228cb08*/ Sirenix.Serialization.SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData();
            /*0x228cb24*/ void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(Sirenix.Serialization.SerializationData value);
            /*0x228cb40*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x228cbb4*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x228cc2c*/ void OnAfterDeserialize();
            /*0x228cc30*/ void OnBeforeSerialize();
        }

        class SerializedScriptableObject : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ Sirenix.Serialization.SerializationData serializationData;

            /*0x228cd30*/ SerializedScriptableObject();
            /*0x228cc3c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x228ccb0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x228cd28*/ void OnAfterDeserialize();
            /*0x228cd2c*/ void OnBeforeSerialize();
        }

        class SerializedStateMachineBehaviour : UnityEngine.StateMachineBehaviour, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ Sirenix.Serialization.SerializationData serializationData;

            /*0x228ce34*/ SerializedStateMachineBehaviour();
            /*0x228cd38*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x228cdb0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x228ce2c*/ void OnAfterDeserialize();
            /*0x228ce30*/ void OnBeforeSerialize();
        }

        class SerializedUnityObject : UnityEngine.Object, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ Sirenix.Serialization.SerializationData serializationData;

            /*0x228cf30*/ SerializedUnityObject();
            /*0x228ce3c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x228ceb0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x228cf28*/ void OnAfterDeserialize();
            /*0x228cf2c*/ void OnBeforeSerialize();
        }
    }

    namespace Serialization
    {
        class BaseDataReader : Sirenix.Serialization.BaseDataReaderWriter, Sirenix.Serialization.IDataReader, System.IDisposable
        {
            /*0x20*/ Sirenix.Serialization.DeserializationContext context;
            /*0x28*/ System.IO.Stream stream;

            /*0x228cf88*/ BaseDataReader(System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context);
            /*0x228d02c*/ int get_CurrentNodeId();
            /*0x228d0e8*/ int get_CurrentNodeDepth();
            /*0x228d0f0*/ string get_CurrentNodeName();
            /*0x228d110*/ System.IO.Stream get_Stream();
            /*0x228d118*/ void set_Stream(System.IO.Stream value);
            /*0x228d1d4*/ Sirenix.Serialization.DeserializationContext get_Context();
            /*0x228d240*/ void set_Context(Sirenix.Serialization.DeserializationContext value);
            bool EnterNode(ref System.Type type);
            bool ExitNode();
            bool EnterArray(ref long length);
            bool ExitArray();
            bool ReadPrimitiveArray<T>(ref T[] array);
            Sirenix.Serialization.EntryType PeekEntry(ref string name);
            bool ReadInternalReference(ref int id);
            bool ReadExternalReference(ref int index);
            bool ReadExternalReference(ref System.Guid guid);
            bool ReadExternalReference(ref string id);
            bool ReadChar(ref char value);
            bool ReadString(ref string value);
            bool ReadGuid(ref System.Guid value);
            bool ReadSByte(ref sbyte value);
            bool ReadInt16(ref short value);
            bool ReadInt32(ref int value);
            bool ReadInt64(ref long value);
            bool ReadByte(ref byte value);
            bool ReadUInt16(ref ushort value);
            bool ReadUInt32(ref uint value);
            bool ReadUInt64(ref ulong value);
            bool ReadDecimal(ref decimal value);
            bool ReadSingle(ref float value);
            bool ReadDouble(ref double value);
            bool ReadBoolean(ref bool value);
            bool ReadNull();
            /*0x228d248*/ void SkipEntry();
            void Dispose();
            /*0x228d7d4*/ void PrepareNewSerializationSession();
            string GetDataDump();
            Sirenix.Serialization.EntryType PeekEntry();
            Sirenix.Serialization.EntryType ReadToNextEntry();
        }

        class BaseDataReaderWriter
        {
            /*0x10*/ Sirenix.Serialization.NodeInfo[] nodes;
            /*0x18*/ int nodesLength;

            /*0x228cfd4*/ BaseDataReaderWriter();
            /*0x228d7e4*/ Sirenix.Serialization.TwoWaySerializationBinder get_Binder();
            /*0x228d9b4*/ void set_Binder(Sirenix.Serialization.TwoWaySerializationBinder value);
            /*0x228db28*/ bool get_IsInArrayNode();
            /*0x228db78*/ int get_NodeDepth();
            /*0x228db80*/ Sirenix.Serialization.NodeInfo[] get_NodesArray();
            /*0x228d04c*/ Sirenix.Serialization.NodeInfo get_CurrentNode();
            /*0x228db88*/ void PushNode(Sirenix.Serialization.NodeInfo node);
            /*0x228dd00*/ void PushNode(string name, int id, System.Type type);
            /*0x228ddc4*/ void PushArray();
            /*0x228dc2c*/ void ExpandNodes();
            /*0x228ded8*/ void PopNode(string name);
            /*0x228df40*/ void PopArray();
            /*0x228d7dc*/ void ClearNodes();
        }

        class BaseDataWriter : Sirenix.Serialization.BaseDataReaderWriter, Sirenix.Serialization.IDataWriter, System.IDisposable
        {
            /*0x20*/ Sirenix.Serialization.SerializationContext context;
            /*0x28*/ System.IO.Stream stream;

            /*0x228dff8*/ BaseDataWriter(System.IO.Stream stream, Sirenix.Serialization.SerializationContext context);
            /*0x228e044*/ System.IO.Stream get_Stream();
            /*0x228e04c*/ void set_Stream(System.IO.Stream value);
            /*0x228e108*/ Sirenix.Serialization.SerializationContext get_Context();
            /*0x228e174*/ void set_Context(Sirenix.Serialization.SerializationContext value);
            /*0x228e17c*/ void FlushToStream();
            void BeginReferenceNode(string name, System.Type type, int id);
            void BeginStructNode(string name, System.Type type);
            void EndNode(string name);
            void BeginArrayNode(long length);
            void EndArrayNode();
            void WritePrimitiveArray<T>(T[] array);
            void WriteNull(string name);
            void WriteInternalReference(string name, int id);
            void WriteExternalReference(string name, int index);
            void WriteExternalReference(string name, System.Guid guid);
            void WriteExternalReference(string name, string id);
            void WriteChar(string name, char value);
            void WriteString(string name, string value);
            void WriteGuid(string name, System.Guid value);
            void WriteSByte(string name, sbyte value);
            void WriteInt16(string name, short value);
            void WriteInt32(string name, int value);
            void WriteInt64(string name, long value);
            void WriteByte(string name, byte value);
            void WriteUInt16(string name, ushort value);
            void WriteUInt32(string name, uint value);
            void WriteUInt64(string name, ulong value);
            void WriteDecimal(string name, decimal value);
            void WriteSingle(string name, float value);
            void WriteDouble(string name, double value);
            void WriteBoolean(string name, bool value);
            void Dispose();
            /*0x228e1ac*/ void PrepareNewSerializationSession();
            string GetDataDump();
        }

        class BinaryDataReader : Sirenix.Serialization.BaseDataReader
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Delegate> PrimitiveFromByteMethods;
            /*0x30*/ byte[] internalBufferBackup;
            /*0x38*/ byte[] buffer;
            /*0x40*/ int bufferIndex;
            /*0x44*/ int bufferEnd;
            /*0x48*/ System.Nullable<Sirenix.Serialization.EntryType> peekedEntryType;
            /*0x4a*/ Sirenix.Serialization.BinaryEntryType peekedBinaryEntryType;
            /*0x50*/ string peekedEntryName;
            /*0x58*/ System.Collections.Generic.Dictionary<int, System.Type> types;

            static /*0x229be50*/ BinaryDataReader();
            /*0x228e1b4*/ BinaryDataReader();
            /*0x228e270*/ BinaryDataReader(System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context);
            /*0x228e358*/ void Dispose();
            /*0x228e35c*/ Sirenix.Serialization.EntryType PeekEntry(ref string name);
            /*0x2292494*/ bool EnterArray(ref long length);
            /*0x229275c*/ bool EnterNode(ref System.Type type);
            /*0x2293b48*/ bool ExitArray();
            /*0x2293c68*/ bool ExitNode();
            bool ReadPrimitiveArray<T>(ref T[] array);
            /*0x2293d9c*/ bool ReadBoolean(ref bool value);
            /*0x2293eb0*/ bool ReadSByte(ref sbyte value);
            /*0x2293fc0*/ bool ReadByte(ref byte value);
            /*0x22940d0*/ bool ReadInt16(ref short value);
            /*0x22941e0*/ bool ReadUInt16(ref ushort value);
            /*0x22942f0*/ bool ReadInt32(ref int value);
            /*0x2294404*/ bool ReadUInt32(ref uint value);
            /*0x2294514*/ bool ReadInt64(ref long value);
            /*0x2294da4*/ bool ReadUInt64(ref ulong value);
            /*0x22955ec*/ bool ReadChar(ref char value);
            /*0x2295abc*/ bool ReadSingle(ref float value);
            /*0x22960f8*/ bool ReadDouble(ref double value);
            /*0x2296738*/ bool ReadDecimal(ref decimal value);
            /*0x2296e90*/ bool ReadExternalReference(ref System.Guid guid);
            /*0x22970f0*/ bool ReadGuid(ref System.Guid value);
            /*0x2297350*/ bool ReadExternalReference(ref int index);
            /*0x22974f0*/ bool ReadExternalReference(ref string id);
            /*0x22978bc*/ bool ReadNull();
            /*0x2297954*/ bool ReadInternalReference(ref int id);
            /*0x2297af4*/ bool ReadString(ref string value);
            /*0x2297ec0*/ void PrepareNewSerializationSession();
            /*0x2297f2c*/ string GetDataDump();
            /*0x2298028*/ string ReadStringValue();
            /*0x2298358*/ void SkipStringValue();
            /*0x22984d4*/ void SkipPeekedEntryContent();
            /*0x229a100*/ bool SkipBuffer(int amount);
            /*0x229a120*/ System.Type ReadTypeEntry();
            /*0x229aa78*/ void MarkEntryContentConsumed();
            /*0x229aa88*/ Sirenix.Serialization.EntryType PeekEntry();
            /*0x229aaac*/ Sirenix.Serialization.EntryType ReadToNextEntry();
            /*0x229aae4*/ bool UNSAFE_Read_1_Byte(ref byte value);
            /*0x229ab60*/ bool UNSAFE_Read_1_SByte(ref sbyte value);
            /*0x229abdc*/ bool UNSAFE_Read_2_Int16(ref short value);
            /*0x229ace0*/ bool UNSAFE_Read_2_UInt16(ref ushort value);
            /*0x229ade4*/ bool UNSAFE_Read_2_Char(ref char value);
            /*0x229aee8*/ bool UNSAFE_Read_4_Int32(ref int value);
            /*0x229affc*/ bool UNSAFE_Read_4_UInt32(ref uint value);
            /*0x229b110*/ bool UNSAFE_Read_4_Float32(ref float value);
            /*0x229b248*/ bool UNSAFE_Read_8_Int64(ref long value);
            /*0x229b3e0*/ bool UNSAFE_Read_8_UInt64(ref ulong value);
            /*0x229b578*/ bool UNSAFE_Read_8_Float64(ref double value);
            /*0x229b710*/ bool UNSAFE_Read_16_Decimal(ref decimal value);
            /*0x229b914*/ bool UNSAFE_Read_16_Guid(ref System.Guid value);
            /*0x229baf8*/ bool HasBufferData(int amount);
            /*0x229bb38*/ void ReadEntireStreamToBuffer();

            struct Struct256Bit
            {
                /*0x10*/ decimal d1;
                /*0x20*/ decimal d2;
            }

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.BinaryDataReader.<> <>9;

                static /*0x229c6bc*/ <>c();
                /*0x229c720*/ <>c();
                /*0x229c728*/ char <.cctor>b__64_0(byte[] b, int i);
                /*0x229c790*/ byte <.cctor>b__64_1(byte[] b, int i);
                /*0x229c7bc*/ sbyte <.cctor>b__64_2(byte[] b, int i);
                /*0x229c7e8*/ bool <.cctor>b__64_3(byte[] b, int i);
            }
        }

        class BinaryDataWriter : Sirenix.Serialization.BaseDataWriter
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Delegate> PrimitiveGetBytesMethods;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, int> PrimitiveSizes;
            static /*0x10*/ System.Collections.Generic.Dictionary<System.Type, System.Action<Sirenix.Serialization.BinaryDataWriter, object>> PrimitiveArrayWriters;
            /*0x30*/ byte[] small_buffer;
            /*0x38*/ byte[] buffer;
            /*0x40*/ int bufferIndex;
            /*0x48*/ System.Collections.Generic.Dictionary<System.Type, int> types;
            /*0x50*/ bool CompressStringsTo8BitWhenPossible;

            static /*0x22a8694*/ BinaryDataWriter();
            static /*0x229e27c*/ void WritePrimitiveArray_byte(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x229e538*/ void WritePrimitiveArray_sbyte(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x229ea5c*/ void WritePrimitiveArray_bool(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x229ef80*/ void WritePrimitiveArray_char(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x229f690*/ void WritePrimitiveArray_short(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x229fda0*/ void WritePrimitiveArray_int(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a04bc*/ void WritePrimitiveArray_long(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a0c48*/ void WritePrimitiveArray_ushort(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a1358*/ void WritePrimitiveArray_uint(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a1a78*/ void WritePrimitiveArray_ulong(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a2204*/ void WritePrimitiveArray_decimal(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a2a14*/ void WritePrimitiveArray_float(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a3190*/ void WritePrimitiveArray_double(Sirenix.Serialization.BinaryDataWriter writer, object o);
            static /*0x22a3918*/ void WritePrimitiveArray_Guid(Sirenix.Serialization.BinaryDataWriter writer, object o);
            /*0x229c81c*/ BinaryDataWriter();
            /*0x229c914*/ BinaryDataWriter(System.IO.Stream stream, Sirenix.Serialization.SerializationContext context);
            /*0x229ca48*/ void BeginArrayNode(long length);
            /*0x229cc48*/ void BeginReferenceNode(string name, System.Type type, int id);
            /*0x229dbc0*/ void BeginStructNode(string name, System.Type type);
            /*0x229e0cc*/ void Dispose();
            /*0x229e0dc*/ void EndArrayNode();
            /*0x229e1ac*/ void EndNode(string name);
            void WritePrimitiveArray<T>(T[] array);
            /*0x22a412c*/ void WriteBoolean(string name, bool value);
            /*0x22a42f8*/ void WriteByte(string name, byte value);
            /*0x22a44c0*/ void WriteChar(string name, char value);
            /*0x22a4778*/ void WriteDecimal(string name, decimal value);
            /*0x22a4abc*/ void WriteDouble(string name, double value);
            /*0x22a4d7c*/ void WriteGuid(string name, System.Guid value);
            /*0x22a5094*/ void WriteExternalReference(string name, System.Guid guid);
            /*0x22a53ac*/ void WriteExternalReference(string name, int index);
            /*0x22a5684*/ void WriteExternalReference(string name, string id);
            /*0x22a57d4*/ void WriteInt32(string name, int value);
            /*0x22a5aac*/ void WriteInt64(string name, long value);
            /*0x22a5d68*/ void WriteNull(string name);
            /*0x22a5e6c*/ void WriteInternalReference(string name, int id);
            /*0x22a6144*/ void WriteSByte(string name, sbyte value);
            /*0x22a630c*/ void WriteInt16(string name, short value);
            /*0x22a65c4*/ void WriteSingle(string name, float value);
            /*0x22a6958*/ void WriteString(string name, string value);
            /*0x22a6a64*/ void WriteUInt32(string name, uint value);
            /*0x22a6d3c*/ void WriteUInt64(string name, ulong value);
            /*0x22a6ff8*/ void WriteUInt16(string name, ushort value);
            /*0x22a72b0*/ void PrepareNewSerializationSession();
            /*0x22a730c*/ string GetDataDump();
            /*0x22a752c*/ void WriteType(System.Type type);
            /*0x229d21c*/ void WriteStringFast(string value);
            /*0x22a7984*/ void FlushToStream();
            /*0x22a79e0*/ void UNSAFE_WriteToBuffer_2_Char(char value);
            /*0x22a7a98*/ void UNSAFE_WriteToBuffer_2_Int16(short value);
            /*0x22a7b50*/ void UNSAFE_WriteToBuffer_2_UInt16(ushort value);
            /*0x22a7c08*/ void UNSAFE_WriteToBuffer_4_Int32(int value);
            /*0x22a7cd0*/ void UNSAFE_WriteToBuffer_4_UInt32(uint value);
            /*0x22a7d98*/ void UNSAFE_WriteToBuffer_4_Float32(float value);
            /*0x22a7ec0*/ void UNSAFE_WriteToBuffer_8_Int64(long value);
            /*0x22a7ff8*/ void UNSAFE_WriteToBuffer_8_UInt64(ulong value);
            /*0x22a8130*/ void UNSAFE_WriteToBuffer_8_Float64(double value);
            /*0x22a826c*/ void UNSAFE_WriteToBuffer_16_Decimal(decimal value);
            /*0x22a8420*/ void UNSAFE_WriteToBuffer_16_Guid(System.Guid value);
            /*0x22a85b0*/ void EnsureBufferSpace(int space);
            /*0x22a8644*/ bool TryEnsureBufferSpace(int space);

            struct Struct256Bit
            {
                /*0x10*/ decimal d1;
                /*0x20*/ decimal d2;
            }

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.BinaryDataWriter.<> <>9;

                static /*0x22a9794*/ <>c();
                /*0x22a97f8*/ <>c();
                /*0x22a9800*/ void <.cctor>b__70_0(byte[] b, int i, char v);
                /*0x22a9870*/ void <.cctor>b__70_1(byte[] b, int i, byte v);
                /*0x22a989c*/ void <.cctor>b__70_2(byte[] b, int i, sbyte v);
                /*0x22a98c8*/ void <.cctor>b__70_3(byte[] b, int i, bool v);
            }
        }

        enum BinaryEntryType
        {
            Invalid = 0,
            NamedStartOfReferenceNode = 1,
            UnnamedStartOfReferenceNode = 2,
            NamedStartOfStructNode = 3,
            UnnamedStartOfStructNode = 4,
            EndOfNode = 5,
            StartOfArray = 6,
            EndOfArray = 7,
            PrimitiveArray = 8,
            NamedInternalReference = 9,
            UnnamedInternalReference = 10,
            NamedExternalReferenceByIndex = 11,
            UnnamedExternalReferenceByIndex = 12,
            NamedExternalReferenceByGuid = 13,
            UnnamedExternalReferenceByGuid = 14,
            NamedSByte = 15,
            UnnamedSByte = 16,
            NamedByte = 17,
            UnnamedByte = 18,
            NamedShort = 19,
            UnnamedShort = 20,
            NamedUShort = 21,
            UnnamedUShort = 22,
            NamedInt = 23,
            UnnamedInt = 24,
            NamedUInt = 25,
            UnnamedUInt = 26,
            NamedLong = 27,
            UnnamedLong = 28,
            NamedULong = 29,
            UnnamedULong = 30,
            NamedFloat = 31,
            UnnamedFloat = 32,
            NamedDouble = 33,
            UnnamedDouble = 34,
            NamedDecimal = 35,
            UnnamedDecimal = 36,
            NamedChar = 37,
            UnnamedChar = 38,
            NamedString = 39,
            UnnamedString = 40,
            NamedGuid = 41,
            UnnamedGuid = 42,
            NamedBoolean = 43,
            UnnamedBoolean = 44,
            NamedNull = 45,
            UnnamedNull = 46,
            TypeName = 47,
            TypeID = 48,
            EndOfStream = 49,
            NamedExternalReferenceByString = 50,
            UnnamedExternalReferenceByString = 51,
        }

        interface IDataReader : System.IDisposable
        {
            Sirenix.Serialization.TwoWaySerializationBinder get_Binder();
            void set_Binder(Sirenix.Serialization.TwoWaySerializationBinder value);
            System.IO.Stream get_Stream();
            void set_Stream(System.IO.Stream value);
            bool get_IsInArrayNode();
            string get_CurrentNodeName();
            int get_CurrentNodeId();
            int get_CurrentNodeDepth();
            Sirenix.Serialization.DeserializationContext get_Context();
            void set_Context(Sirenix.Serialization.DeserializationContext value);
            string GetDataDump();
            bool EnterNode(ref System.Type type);
            bool ExitNode();
            bool EnterArray(ref long length);
            bool ExitArray();
            bool ReadPrimitiveArray<T>(ref T[] array);
            Sirenix.Serialization.EntryType PeekEntry(ref string name);
            bool ReadInternalReference(ref int id);
            bool ReadExternalReference(ref int index);
            bool ReadExternalReference(ref System.Guid guid);
            bool ReadExternalReference(ref string id);
            bool ReadChar(ref char value);
            bool ReadString(ref string value);
            bool ReadGuid(ref System.Guid value);
            bool ReadSByte(ref sbyte value);
            bool ReadInt16(ref short value);
            bool ReadInt32(ref int value);
            bool ReadInt64(ref long value);
            bool ReadByte(ref byte value);
            bool ReadUInt16(ref ushort value);
            bool ReadUInt32(ref uint value);
            bool ReadUInt64(ref ulong value);
            bool ReadDecimal(ref decimal value);
            bool ReadSingle(ref float value);
            bool ReadDouble(ref double value);
            bool ReadBoolean(ref bool value);
            bool ReadNull();
            void SkipEntry();
            void PrepareNewSerializationSession();
        }

        interface IDataWriter : System.IDisposable
        {
            Sirenix.Serialization.TwoWaySerializationBinder get_Binder();
            void set_Binder(Sirenix.Serialization.TwoWaySerializationBinder value);
            System.IO.Stream get_Stream();
            void set_Stream(System.IO.Stream value);
            bool get_IsInArrayNode();
            Sirenix.Serialization.SerializationContext get_Context();
            void set_Context(Sirenix.Serialization.SerializationContext value);
            string GetDataDump();
            void FlushToStream();
            void BeginReferenceNode(string name, System.Type type, int id);
            void BeginStructNode(string name, System.Type type);
            void EndNode(string name);
            void BeginArrayNode(long length);
            void EndArrayNode();
            void WritePrimitiveArray<T>(T[] array);
            void WriteNull(string name);
            void WriteInternalReference(string name, int id);
            void WriteExternalReference(string name, int index);
            void WriteExternalReference(string name, System.Guid guid);
            void WriteExternalReference(string name, string id);
            void WriteChar(string name, char value);
            void WriteString(string name, string value);
            void WriteGuid(string name, System.Guid value);
            void WriteSByte(string name, sbyte value);
            void WriteInt16(string name, short value);
            void WriteInt32(string name, int value);
            void WriteInt64(string name, long value);
            void WriteByte(string name, byte value);
            void WriteUInt16(string name, ushort value);
            void WriteUInt32(string name, uint value);
            void WriteUInt64(string name, ulong value);
            void WriteDecimal(string name, decimal value);
            void WriteSingle(string name, float value);
            void WriteDouble(string name, double value);
            void WriteBoolean(string name, bool value);
            void PrepareNewSerializationSession();
        }

        class JsonConfig
        {
            static string ID_SIG = "$id";
            static string TYPE_SIG = "$type";
            static string REGULAR_ARRAY_LENGTH_SIG = "$rlength";
            static string PRIMITIVE_ARRAY_LENGTH_SIG = "$plength";
            static string REGULAR_ARRAY_CONTENT_SIG = "$rcontent";
            static string PRIMITIVE_ARRAY_CONTENT_SIG = "$pcontent";
            static string INTERNAL_REF_SIG = "$iref";
            static string EXTERNAL_INDEX_REF_SIG = "$eref";
            static string EXTERNAL_GUID_REF_SIG = "$guidref";
            static string EXTERNAL_STRING_REF_SIG_OLD = "$strref";
            static string EXTERNAL_STRING_REF_SIG_FIXED = "$fstrref";
        }

        class JsonDataReader : Sirenix.Serialization.BaseDataReader
        {
            /*0x30*/ Sirenix.Serialization.JsonTextReader reader;
            /*0x38*/ System.Nullable<Sirenix.Serialization.EntryType> peekedEntryType;
            /*0x40*/ string peekedEntryName;
            /*0x48*/ string peekedEntryContent;
            /*0x50*/ System.Collections.Generic.Dictionary<int, System.Type> seenTypes;
            /*0x58*/ System.Collections.Generic.Dictionary<System.Type, System.Delegate> primitiveArrayReaders;

            /*0x22a98f8*/ JsonDataReader();
            /*0x22a9904*/ JsonDataReader(System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context);
            /*0x22aa174*/ System.IO.Stream get_Stream();
            /*0x22aa17c*/ void set_Stream(System.IO.Stream value);
            /*0x22aa210*/ void Dispose();
            /*0x22aa22c*/ Sirenix.Serialization.EntryType PeekEntry(ref string name);
            /*0x22aa304*/ bool EnterNode(ref System.Type type);
            /*0x22aa7cc*/ bool ExitNode();
            /*0x22aa914*/ bool EnterArray(ref long length);
            /*0x22aab64*/ bool ExitArray();
            bool ReadPrimitiveArray<T>(ref T[] array);
            /*0x22aac98*/ bool ReadBoolean(ref bool value);
            /*0x22aadc8*/ bool ReadInternalReference(ref int id);
            /*0x22ab0bc*/ bool ReadExternalReference(ref int index);
            /*0x22ab1d4*/ bool ReadExternalReference(ref System.Guid guid);
            /*0x22ab4a4*/ bool ReadExternalReference(ref string id);
            /*0x22ab66c*/ bool ReadChar(ref char value);
            /*0x22ab790*/ bool ReadString(ref string value);
            /*0x22ab8bc*/ bool ReadGuid(ref System.Guid value);
            /*0x22abb24*/ bool ReadSByte(ref sbyte value);
            /*0x22abc34*/ bool ReadInt16(ref short value);
            /*0x22abd44*/ bool ReadInt32(ref int value);
            /*0x22abe58*/ bool ReadInt64(ref long value);
            /*0x22ac034*/ bool ReadByte(ref byte value);
            /*0x22ac144*/ bool ReadUInt16(ref ushort value);
            /*0x22ac254*/ bool ReadUInt32(ref uint value);
            /*0x22ac364*/ bool ReadUInt64(ref ulong value);
            /*0x22ac540*/ bool ReadDecimal(ref decimal value);
            /*0x22ac750*/ bool ReadSingle(ref float value);
            /*0x22ac934*/ bool ReadDouble(ref double value);
            /*0x22acb18*/ bool ReadNull();
            /*0x22acbb0*/ void PrepareNewSerializationSession();
            /*0x22acc1c*/ string GetDataDump();
            /*0x22acdfc*/ Sirenix.Serialization.EntryType PeekEntry();
            /*0x22ace20*/ Sirenix.Serialization.EntryType ReadToNextEntry();
            /*0x22ab5fc*/ void MarkEntryConsumed();
            /*0x22aaee0*/ bool ReadAnyIntReference(ref int value);
            /*0x22ace48*/ char <.ctor>b__7_0();
            /*0x22ace70*/ sbyte <.ctor>b__7_1();
            /*0x22ace98*/ short <.ctor>b__7_2();
            /*0x22acec0*/ int <.ctor>b__7_3();
            /*0x22acee8*/ long <.ctor>b__7_4();
            /*0x22acf10*/ byte <.ctor>b__7_5();
            /*0x22acf38*/ ushort <.ctor>b__7_6();
            /*0x22acf60*/ uint <.ctor>b__7_7();
            /*0x22acf88*/ ulong <.ctor>b__7_8();
            /*0x22acfb0*/ decimal <.ctor>b__7_9();
            /*0x22ad000*/ bool <.ctor>b__7_10();
            /*0x22ad028*/ float <.ctor>b__7_11();
            /*0x22ad050*/ double <.ctor>b__7_12();
            /*0x22ad078*/ System.Guid <.ctor>b__7_13();
        }

        class JsonDataWriter : Sirenix.Serialization.BaseDataWriter
        {
            static /*0x0*/ uint[] ByteToHexCharLookup;
            static /*0x8*/ string NEW_LINE;
            /*0x30*/ bool justStarted;
            /*0x31*/ bool forceNoSeparatorNextLine;
            /*0x38*/ System.Collections.Generic.Dictionary<System.Type, System.Delegate> primitiveTypeWriters;
            /*0x40*/ System.Collections.Generic.Dictionary<System.Type, int> seenTypes;
            /*0x48*/ byte[] buffer;
            /*0x50*/ int bufferIndex;
            /*0x54*/ bool FormatAsReadable;
            /*0x55*/ bool EnableTypeOptimization;

            static /*0x22af94c*/ JsonDataWriter();
            static /*0x22af830*/ uint[] CreateByteToHexLookup();
            /*0x22ad0a8*/ JsonDataWriter();
            /*0x22ad0b8*/ JsonDataWriter(System.IO.Stream stream, Sirenix.Serialization.SerializationContext context, bool formatAsReadable);
            /*0x22ad874*/ void MarkJustStarted();
            /*0x22ad880*/ void FlushToStream();
            /*0x22ad8e0*/ void BeginReferenceNode(string name, System.Type type, int id);
            /*0x22addf0*/ void BeginStructNode(string name, System.Type type);
            /*0x22adecc*/ void EndNode(string name);
            /*0x22ae180*/ void BeginArrayNode(long length);
            /*0x22ae238*/ void EndArrayNode();
            void WritePrimitiveArray<T>(T[] array);
            /*0x22ae29c*/ void WriteBoolean(string name, bool value);
            /*0x22ae31c*/ void WriteByte(string name, byte value);
            /*0x22ae330*/ void WriteChar(string name, char value);
            /*0x22ae3c4*/ void WriteDecimal(string name, decimal value);
            /*0x22ae48c*/ void WriteDouble(string name, double value);
            /*0x22ae52c*/ void WriteInt32(string name, int value);
            /*0x22ae540*/ void WriteInt64(string name, long value);
            /*0x22ae5e0*/ void WriteNull(string name);
            /*0x22ae638*/ void WriteInternalReference(string name, int id);
            /*0x22ae700*/ void WriteSByte(string name, sbyte value);
            /*0x22ae714*/ void WriteInt16(string name, short value);
            /*0x22ae728*/ void WriteSingle(string name, float value);
            /*0x22ae7c8*/ void WriteString(string name, string value);
            /*0x22aef34*/ void WriteGuid(string name, System.Guid value);
            /*0x22aefdc*/ void WriteUInt32(string name, uint value);
            /*0x22aeff0*/ void WriteUInt64(string name, ulong value);
            /*0x22af090*/ void WriteExternalReference(string name, int index);
            /*0x22af158*/ void WriteExternalReference(string name, System.Guid guid);
            /*0x22af228*/ void WriteExternalReference(string name, string id);
            /*0x22af380*/ void WriteUInt16(string name, ushort value);
            /*0x22af394*/ void Dispose();
            /*0x22af398*/ void PrepareNewSerializationSession();
            /*0x22af400*/ string GetDataDump();
            /*0x22ad9fc*/ void WriteEntry(string name, string contents);
            /*0x22af5f8*/ void WriteEntry(string name, string contents, char surroundContentsWith);
            /*0x22adbd8*/ void WriteTypeEntry(System.Type type);
            /*0x22adf30*/ void StartNewLine(bool noSeparator);
            /*0x22ae0ec*/ void EnsureBufferSpace(int space);
            /*0x22ae9b4*/ void Buffer_WriteString_WithEscape(string str);
        }

        class JsonTextReader : System.IDisposable
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<char, System.Nullable<Sirenix.Serialization.EntryType>> EntryDelineators;
            static /*0x8*/ System.Collections.Generic.Dictionary<char, char> UnescapeDictionary;
            /*0x10*/ System.IO.StreamReader reader;
            /*0x18*/ int bufferIndex;
            /*0x20*/ char[] buffer;
            /*0x28*/ System.Nullable<char> lastReadChar;
            /*0x2c*/ System.Nullable<char> peekedChar;
            /*0x30*/ System.Collections.Generic.Queue<char> emergencyPlayback;
            /*0x38*/ Sirenix.Serialization.DeserializationContext <Context>k__BackingField;

            static /*0x22b1510*/ JsonTextReader();
            /*0x22af9bc*/ JsonTextReader(System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context);
            /*0x22af9ac*/ Sirenix.Serialization.DeserializationContext get_Context();
            /*0x22af9b4*/ void set_Context(Sirenix.Serialization.DeserializationContext value);
            /*0x22afb28*/ void Reset();
            /*0x22afb84*/ void Dispose();
            /*0x22afb88*/ void ReadToNextEntry(ref string name, ref string valueContent, ref Sirenix.Serialization.EntryType entry);
            /*0x22b0c24*/ void ParseEntryFromBuffer(ref string name, ref string valueContent, ref Sirenix.Serialization.EntryType entry, int valueSeparatorIndex, System.Nullable<Sirenix.Serialization.EntryType> hintEntry);
            /*0x22b09a0*/ bool IsHex(char c);
            /*0x22b14b8*/ uint ParseSingleChar(char c, uint multiplier);
            /*0x22b09dc*/ char ParseHexChar(char c1, char c2, char c3, char c4);
            /*0x22b0b1c*/ char ReadCharIntoBuffer();
            /*0x22b12c8*/ System.Nullable<Sirenix.Serialization.EntryType> GuessPrimitiveType(string content);
            /*0x22b0720*/ char PeekChar();
            /*0x22b082c*/ void SkipChar();
            /*0x22b08d4*/ char ConsumeChar();
        }

        struct SerializationNode
        {
            /*0x10*/ string Name;
            /*0x18*/ Sirenix.Serialization.EntryType Entry;
            /*0x20*/ string Data;
        }

        class SerializationNodeDataReader : Sirenix.Serialization.BaseDataReader
        {
            /*0x30*/ string peekedEntryName;
            /*0x38*/ System.Nullable<Sirenix.Serialization.EntryType> peekedEntryType;
            /*0x40*/ string peekedEntryData;
            /*0x48*/ int currentIndex;
            /*0x50*/ System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> nodes;
            /*0x58*/ System.Collections.Generic.Dictionary<System.Type, System.Delegate> primitiveTypeReaders;

            /*0x22b1774*/ SerializationNodeDataReader(Sirenix.Serialization.DeserializationContext context);
            /*0x22b1f8c*/ bool get_IndexIsValid();
            /*0x22b1fe8*/ System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> get_Nodes();
            /*0x22b2068*/ void set_Nodes(System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> value);
            /*0x22b20b8*/ System.IO.Stream get_Stream();
            /*0x22b2108*/ void set_Stream(System.IO.Stream value);
            /*0x22b2158*/ void Dispose();
            /*0x22b2168*/ void PrepareNewSerializationSession();
            /*0x22b2188*/ Sirenix.Serialization.EntryType PeekEntry(ref string name);
            /*0x22b22e4*/ bool EnterArray(ref long length);
            /*0x22b24c8*/ bool EnterNode(ref System.Type type);
            /*0x22b2890*/ bool ExitArray();
            /*0x22b29d4*/ bool ExitNode();
            /*0x22b2b28*/ bool ReadBoolean(ref bool value);
            /*0x22b2c4c*/ bool ReadByte(ref byte value);
            /*0x22b2d5c*/ bool ReadChar(ref char value);
            /*0x22b2f00*/ bool ReadDecimal(ref decimal value);
            /*0x22b312c*/ bool ReadDouble(ref double value);
            /*0x22b332c*/ bool ReadExternalReference(ref System.Guid guid);
            /*0x22b3600*/ bool ReadExternalReference(ref string id);
            /*0x22b36a8*/ bool ReadExternalReference(ref int index);
            /*0x22b38a0*/ bool ReadGuid(ref System.Guid value);
            /*0x22b3b74*/ bool ReadInt16(ref short value);
            /*0x22b3c84*/ bool ReadInt32(ref int value);
            /*0x22b3d98*/ bool ReadInt64(ref long value);
            /*0x22b3f90*/ bool ReadInternalReference(ref int id);
            /*0x22b4188*/ bool ReadNull();
            bool ReadPrimitiveArray<T>(ref T[] array);
            /*0x22b4220*/ bool ReadSByte(ref sbyte value);
            /*0x22b4330*/ bool ReadSingle(ref float value);
            /*0x22b4530*/ bool ReadString(ref string value);
            /*0x22b45d8*/ bool ReadUInt16(ref ushort value);
            /*0x22b46e8*/ bool ReadUInt32(ref uint value);
            /*0x22b47f8*/ bool ReadUInt64(ref ulong value);
            /*0x22b49f0*/ string GetDataDump();
            /*0x22b2460*/ void ConsumeCurrentEntry();
            /*0x22b4bf8*/ Sirenix.Serialization.EntryType PeekEntry();
            /*0x22b4c1c*/ Sirenix.Serialization.EntryType ReadToNextEntry();
            /*0x22b4c54*/ char <.ctor>b__6_0();
            /*0x22b4c7c*/ sbyte <.ctor>b__6_1();
            /*0x22b4ca4*/ short <.ctor>b__6_2();
            /*0x22b4ccc*/ int <.ctor>b__6_3();
            /*0x22b4cf4*/ long <.ctor>b__6_4();
            /*0x22b4d1c*/ byte <.ctor>b__6_5();
            /*0x22b4d44*/ ushort <.ctor>b__6_6();
            /*0x22b4d6c*/ uint <.ctor>b__6_7();
            /*0x22b4d94*/ ulong <.ctor>b__6_8();
            /*0x22b4dbc*/ decimal <.ctor>b__6_9();
            /*0x22b4e0c*/ bool <.ctor>b__6_10();
            /*0x22b4e34*/ float <.ctor>b__6_11();
            /*0x22b4e5c*/ double <.ctor>b__6_12();
            /*0x22b4e84*/ System.Guid <.ctor>b__6_13();
        }

        class SerializationNodeDataReaderWriterConfig
        {
            static string NodeIdSeparator = "|";
        }

        class SerializationNodeDataWriter : Sirenix.Serialization.BaseDataWriter
        {
            /*0x30*/ System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> nodes;
            /*0x38*/ System.Collections.Generic.Dictionary<System.Type, System.Delegate> primitiveTypeWriters;

            /*0x22b4f84*/ SerializationNodeDataWriter(Sirenix.Serialization.SerializationContext context);
            /*0x22b4eb4*/ System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> get_Nodes();
            /*0x22b4f34*/ void set_Nodes(System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> value);
            /*0x22b56b8*/ System.IO.Stream get_Stream();
            /*0x22b5708*/ void set_Stream(System.IO.Stream value);
            /*0x22b5758*/ void BeginArrayNode(long length);
            /*0x22b58f0*/ void BeginReferenceNode(string name, System.Type type, int id);
            /*0x22b5b34*/ void BeginStructNode(string name, System.Type type);
            /*0x22b5d14*/ void Dispose();
            /*0x22b5d1c*/ void EndArrayNode();
            /*0x22b5e50*/ void EndNode(string name);
            /*0x22b5f94*/ void PrepareNewSerializationSession();
            /*0x22b5f9c*/ void WriteBoolean(string name, bool value);
            /*0x22b60e0*/ void WriteByte(string name, byte value);
            /*0x22b6268*/ void WriteChar(string name, char value);
            /*0x22b63d8*/ void WriteDecimal(string name, decimal value);
            /*0x22b6580*/ void WriteSingle(string name, float value);
            /*0x22b6708*/ void WriteDouble(string name, double value);
            /*0x22b6890*/ void WriteExternalReference(string name, System.Guid guid);
            /*0x22b6a18*/ void WriteExternalReference(string name, string id);
            /*0x22b6b30*/ void WriteExternalReference(string name, int index);
            /*0x22b6cb8*/ void WriteGuid(string name, System.Guid value);
            /*0x22b6e40*/ void WriteInt16(string name, short value);
            /*0x22b6fc8*/ void WriteInt32(string name, int value);
            /*0x22b7150*/ void WriteInt64(string name, long value);
            /*0x22b72d8*/ void WriteInternalReference(string name, int id);
            /*0x22b7460*/ void WriteNull(string name);
            void WritePrimitiveArray<T>(T[] array);
            /*0x22b7594*/ void WriteSByte(string name, sbyte value);
            /*0x22b771c*/ void WriteString(string name, string value);
            /*0x22b7834*/ void WriteUInt16(string name, ushort value);
            /*0x22b79bc*/ void WriteUInt32(string name, uint value);
            /*0x22b7b44*/ void WriteUInt64(string name, ulong value);
            /*0x22b7ccc*/ void FlushToStream();
            /*0x22b7cd0*/ string GetDataDump();
        }

        class ArrayFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22b8838*/ ArrayFormatterLocator();
            /*0x22b7e90*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class DelegateFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22b8ba8*/ DelegateFormatterLocator();
            /*0x22b8840*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class FormatterLocator
        {
            static /*0x0*/ object StrongFormatters_LOCK;
            static /*0x8*/ object WeakFormatters_LOCK;
            static /*0x10*/ System.Collections.Generic.Dictionary<System.Type, Sirenix.Serialization.IFormatter> FormatterInstances;
            static /*0x18*/ Sirenix.Serialization.Utilities.DoubleLookupDictionary<System.Type, Sirenix.Serialization.ISerializationPolicy, Sirenix.Serialization.IFormatter> StrongTypeFormatterMap;
            static /*0x20*/ Sirenix.Serialization.Utilities.DoubleLookupDictionary<System.Type, Sirenix.Serialization.ISerializationPolicy, Sirenix.Serialization.IFormatter> WeakTypeFormatterMap;
            static /*0x28*/ System.Collections.Generic.List<Sirenix.Serialization.FormatterLocator.FormatterLocatorInfo> FormatterLocators;
            static /*0x30*/ System.Collections.Generic.List<Sirenix.Serialization.FormatterLocator.FormatterInfo> FormatterInfos;

            static /*0x22b8bb0*/ FormatterLocator();
            static /*0x22b9dd8*/ void add_FormatterResolve(System.Func<System.Type, Sirenix.Serialization.IFormatter> value);
            static /*0x22b9e18*/ void remove_FormatterResolve(System.Func<System.Type, Sirenix.Serialization.IFormatter> value);
            static Sirenix.Serialization.IFormatter<T> GetFormatter<T>(Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22b9e58*/ Sirenix.Serialization.IFormatter GetFormatter(System.Type type, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22b9ec0*/ Sirenix.Serialization.IFormatter GetFormatter(System.Type type, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters);
            static /*0x22bb778*/ void LogAOTError(System.Type type, System.Exception ex);
            static /*0x22bba44*/ System.Collections.Generic.IEnumerable<string> GetAllPossibleMissingAOTTypes(System.Type type);
            static /*0x22bbaf0*/ System.Collections.Generic.List<Sirenix.Serialization.IFormatter> GetAllCompatiblePredefinedFormatters(System.Type type, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22ba424*/ Sirenix.Serialization.IFormatter CreateFormatter(System.Type type, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFormatters);
            static /*0x22bc940*/ Sirenix.Serialization.IFormatter GetFormatterInstance(System.Type type);

            struct FormatterInfo
            {
                /*0x10*/ System.Type FormatterType;
                /*0x18*/ System.Type TargetType;
                /*0x20*/ System.Type WeakFallbackType;
                /*0x28*/ bool AskIfCanFormatTypes;
                /*0x2c*/ int Priority;
            }

            struct FormatterLocatorInfo
            {
                /*0x10*/ Sirenix.Serialization.IFormatterLocator LocatorInstance;
                /*0x18*/ int Priority;
            }

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.FormatterLocator.<> <>9;

                static /*0x22bcc7c*/ <>c();
                /*0x22bcce0*/ <>c();
                /*0x22bcce8*/ int <.cctor>b__9_0(Sirenix.Serialization.FormatterLocator.FormatterInfo a, Sirenix.Serialization.FormatterLocator.FormatterInfo b);
                /*0x22bcd78*/ int <.cctor>b__9_1(Sirenix.Serialization.FormatterLocator.FormatterLocatorInfo a, Sirenix.Serialization.FormatterLocator.FormatterLocatorInfo b);
            }

            class <GetAllPossibleMissingAOTTypes>d__17 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Type[] <>7__wrap1;
                /*0x40*/ int <>7__wrap2;
                /*0x48*/ System.Type <arg>5__4;
                /*0x50*/ System.Collections.Generic.IEnumerator<string> <>7__wrap4;

                /*0x22bbabc*/ <GetAllPossibleMissingAOTTypes>d__17(int <>1__state);
                /*0x22bce20*/ void System.IDisposable.Dispose();
                /*0x22bce3c*/ bool MoveNext();
                /*0x22bd39c*/ void <>m__Finally1();
                /*0x22bd44c*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x22bd454*/ void System.Collections.IEnumerator.Reset();
                /*0x22bd494*/ object System.Collections.IEnumerator.get_Current();
                /*0x22bd49c*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x22bd540*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class GenericCollectionFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22bdeec*/ GenericCollectionFormatterLocator();
            /*0x22bd544*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        interface IFormatterLocator
        {
            bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class ISerializableFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22be1f0*/ ISerializableFormatterLocator();
            /*0x22bdef4*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class SelfFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22be538*/ SelfFormatterLocator();
            /*0x22be1f8*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class TypeFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22be620*/ TypeFormatterLocator();
            /*0x22be540*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class ArrayFormatter<T> : Sirenix.Serialization.BaseFormatter<T[]>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<T> valueReaderWriter;

            static ArrayFormatter();
            ArrayFormatter();
            T[] GetUninitializedObject();
            void DeserializeImplementation(ref T[] value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T[] value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakArrayFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ValueReaderWriter;
            /*0x48*/ System.Type ElementType;

            /*0x22b871c*/ WeakArrayFormatter(System.Type arrayType, System.Type elementType);
            /*0x22bea5c*/ object GetUninitializedObject();
            /*0x22bea64*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22bf174*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class ArrayListFormatter : Sirenix.Serialization.BaseFormatter<System.Collections.ArrayList>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<object> ObjectSerializer;

            static /*0x22c0104*/ ArrayListFormatter();
            /*0x22c0098*/ ArrayListFormatter();
            /*0x22bf410*/ System.Collections.ArrayList GetUninitializedObject();
            /*0x22bf418*/ void DeserializeImplementation(ref System.Collections.ArrayList value, Sirenix.Serialization.IDataReader reader);
            /*0x22bfc70*/ void SerializeImplementation(ref System.Collections.ArrayList value, Sirenix.Serialization.IDataWriter writer);
        }

        class BaseFormatter<T> : Sirenix.Serialization.IFormatter<T>, Sirenix.Serialization.IFormatter
        {
            static /*0x0*/ Sirenix.Serialization.BaseFormatter.SerializationCallback<T> OnSerializingCallbacks;
            static /*0x0*/ Sirenix.Serialization.BaseFormatter.SerializationCallback<T> OnSerializedCallbacks;
            static /*0x0*/ Sirenix.Serialization.BaseFormatter.SerializationCallback<T> OnDeserializingCallbacks;
            static /*0x0*/ Sirenix.Serialization.BaseFormatter.SerializationCallback<T> OnDeserializedCallbacks;
            static /*0x0*/ bool IsValueType;
            static /*0x0*/ bool ImplementsISerializationCallbackReceiver;
            static /*0x0*/ bool ImplementsIDeserializationCallback;
            static /*0x0*/ bool ImplementsIObjectReference;

            static BaseFormatter();
            static Sirenix.Serialization.BaseFormatter.SerializationCallback<T> GetCallbacks(System.Reflection.MethodInfo[] methods, System.Type callbackAttribute, ref System.Collections.Generic.List<Sirenix.Serialization.BaseFormatter.SerializationCallback<T>> list);
            static Sirenix.Serialization.BaseFormatter.SerializationCallback<T> CreateCallback(System.Reflection.MethodInfo info);
            BaseFormatter();
            System.Type get_SerializedType();
            void Sirenix.Serialization.IFormatter.Serialize(object value, Sirenix.Serialization.IDataWriter writer);
            object Sirenix.Serialization.IFormatter.Deserialize(Sirenix.Serialization.IDataReader reader);
            T Deserialize(Sirenix.Serialization.IDataReader reader);
            void Serialize(T value, Sirenix.Serialization.IDataWriter writer);
            T GetUninitializedObject();
            void RegisterReferenceID(T value, Sirenix.Serialization.IDataReader reader);
            void InvokeOnDeserializingCallbacks(T value, Sirenix.Serialization.DeserializationContext context);
            void InvokeOnDeserializingCallbacks(ref T value, Sirenix.Serialization.DeserializationContext context);
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);

            class SerializationCallback<T> : System.MulticastDelegate
            {
                SerializationCallback(object object, nint method);
                void Invoke(ref T value, System.Runtime.Serialization.StreamingContext context);
                System.IAsyncResult BeginInvoke(ref T value, System.Runtime.Serialization.StreamingContext context, System.AsyncCallback callback, object object);
                void EndInvoke(ref T value, System.IAsyncResult result);
            }

            class <>c__DisplayClass11_0<T>
            {
                /*0x0*/ System.Reflection.MethodInfo info;

                <>c__DisplayClass11_0();
                void <CreateCallback>b__0(ref T value, System.Runtime.Serialization.StreamingContext context);
                void <CreateCallback>b__1(ref T value, System.Runtime.Serialization.StreamingContext context);
            }
        }

        class WeakBaseFormatter : Sirenix.Serialization.IFormatter
        {
            /*0x10*/ System.Type SerializedType;
            /*0x18*/ Sirenix.Serialization.WeakBaseFormatter.SerializationCallback[] OnSerializingCallbacks;
            /*0x20*/ Sirenix.Serialization.WeakBaseFormatter.SerializationCallback[] OnSerializedCallbacks;
            /*0x28*/ Sirenix.Serialization.WeakBaseFormatter.SerializationCallback[] OnDeserializingCallbacks;
            /*0x30*/ Sirenix.Serialization.WeakBaseFormatter.SerializationCallback[] OnDeserializedCallbacks;
            /*0x38*/ bool IsValueType;
            /*0x39*/ bool ImplementsISerializationCallbackReceiver;
            /*0x3a*/ bool ImplementsIDeserializationCallback;
            /*0x3b*/ bool ImplementsIObjectReference;

            static /*0x22c0194*/ Sirenix.Serialization.WeakBaseFormatter.SerializationCallback[] GetCallbacks(System.Reflection.MethodInfo[] methods, System.Type callbackAttribute, ref System.Collections.Generic.List<Sirenix.Serialization.WeakBaseFormatter.SerializationCallback> list);
            static /*0x22c0318*/ Sirenix.Serialization.WeakBaseFormatter.SerializationCallback CreateCallback(System.Reflection.MethodInfo info);
            /*0x22be628*/ WeakBaseFormatter(System.Type serializedType);
            /*0x22c018c*/ System.Type Sirenix.Serialization.IFormatter.get_SerializedType();
            /*0x22c0708*/ void Serialize(object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c0bf0*/ object Deserialize(Sirenix.Serialization.IDataReader reader);
            /*0x22beff0*/ void RegisterReferenceID(object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c1240*/ void InvokeOnDeserializingCallbacks(object value, Sirenix.Serialization.DeserializationContext context);
            /*0x22c1394*/ object GetUninitializedObject();
            void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);

            class SerializationCallback : System.MulticastDelegate
            {
                /*0x22c05d8*/ SerializationCallback(object object, nint method);
                /*0x22c140c*/ void Invoke(object value, System.Runtime.Serialization.StreamingContext context);
                /*0x22c1420*/ System.IAsyncResult BeginInvoke(object value, System.Runtime.Serialization.StreamingContext context, System.AsyncCallback callback, object object);
                /*0x22c14b4*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ System.Reflection.MethodInfo info;

                /*0x22c05d0*/ <>c__DisplayClass14_0();
                /*0x22c14c0*/ void <CreateCallback>b__0(object value, System.Runtime.Serialization.StreamingContext context);
                /*0x22c14e0*/ void <CreateCallback>b__1(object value, System.Runtime.Serialization.StreamingContext context);
            }
        }

        class DateTimeFormatter : Sirenix.Serialization.MinimalBaseFormatter<System.DateTime>
        {
            /*0x22c17ec*/ DateTimeFormatter();
            /*0x22c15d4*/ void Read(ref System.DateTime value, Sirenix.Serialization.IDataReader reader);
            /*0x22c1730*/ void Write(ref System.DateTime value, Sirenix.Serialization.IDataWriter writer);
        }

        class DateTimeOffsetFormatter : Sirenix.Serialization.MinimalBaseFormatter<System.DateTimeOffset>
        {
            /*0x22c1ac0*/ DateTimeOffsetFormatter();
            /*0x22c1858*/ void Read(ref System.DateTimeOffset value, Sirenix.Serialization.IDataReader reader);
            /*0x22c19b4*/ void Write(ref System.DateTimeOffset value, Sirenix.Serialization.IDataWriter writer);
        }

        class DelegateFormatter<T> : Sirenix.Serialization.BaseFormatter<T>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<object> ObjectSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<string> StringSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Type> TypeSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Type[]> TypeArraySerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Delegate[]> DelegateArraySerializer;
            /*0x0*/ System.Type DelegateType;

            static DelegateFormatter();
            DelegateFormatter();
            DelegateFormatter(System.Type delegateType);
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);
            T GetUninitializedObject();

            class <>c<T>
            {
                static /*0x0*/ Sirenix.Serialization.DelegateFormatter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Type, string> <>9__8_0;
                static /*0x0*/ System.Func<System.Type, string> <>9__8_1;

                static <>c();
                <>c();
                string <DeserializeImplementation>b__8_0(System.Type p);
                string <DeserializeImplementation>b__8_1(System.Type p);
            }
        }

        class WeakDelegateFormatter : Sirenix.Serialization.DelegateFormatter<System.Delegate>
        {
            /*0x22b8b2c*/ WeakDelegateFormatter(System.Type delegateType);
        }

        class DerivedDictionaryFormatter<TDictionary, TKey, TValue> : Sirenix.Serialization.BaseFormatter<TDictionary>
        {
            static /*0x0*/ bool KeyIsValueType;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Collections.Generic.IEqualityComparer<TKey>> EqualityComparerSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<TKey> KeyReaderWriter;
            static /*0x0*/ Sirenix.Serialization.Serializer<TValue> ValueReaderWriter;
            static /*0x0*/ System.Reflection.ConstructorInfo ComparerConstructor;

            static DerivedDictionaryFormatter();
            DerivedDictionaryFormatter();
            TDictionary GetUninitializedObject();
            void DeserializeImplementation(ref TDictionary value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref TDictionary value, Sirenix.Serialization.IDataWriter writer);
        }

        class DictionaryFormatter<TKey, TValue> : Sirenix.Serialization.BaseFormatter<System.Collections.Generic.Dictionary<TKey, TValue>>
        {
            static /*0x0*/ bool KeyIsValueType;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Collections.Generic.IEqualityComparer<TKey>> EqualityComparerSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<TKey> KeyReaderWriter;
            static /*0x0*/ Sirenix.Serialization.Serializer<TValue> ValueReaderWriter;

            static DictionaryFormatter();
            DictionaryFormatter();
            System.Collections.Generic.Dictionary<TKey, TValue> GetUninitializedObject();
            void DeserializeImplementation(ref System.Collections.Generic.Dictionary<TKey, TValue> value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref System.Collections.Generic.Dictionary<TKey, TValue> value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakDictionaryFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x3c*/ bool KeyIsValueType;
            /*0x40*/ Sirenix.Serialization.Serializer EqualityComparerSerializer;
            /*0x48*/ Sirenix.Serialization.Serializer KeyReaderWriter;
            /*0x50*/ Sirenix.Serialization.Serializer ValueReaderWriter;
            /*0x58*/ System.Reflection.ConstructorInfo ComparerConstructor;
            /*0x60*/ System.Reflection.PropertyInfo ComparerProperty;
            /*0x68*/ System.Reflection.PropertyInfo CountProperty;
            /*0x70*/ System.Type KeyType;
            /*0x78*/ System.Type ValueType;

            /*0x22c1b2c*/ WeakDictionaryFormatter(System.Type serializedType);
            /*0x22c1f8c*/ object GetUninitializedObject();
            /*0x22c1f94*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c2e34*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class DoubleLookupDictionaryFormatter<TPrimary, TSecondary, TValue> : Sirenix.Serialization.BaseFormatter<Sirenix.Serialization.Utilities.DoubleLookupDictionary<TPrimary, TSecondary, TValue>>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<TPrimary> PrimaryReaderWriter;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Collections.Generic.Dictionary<TSecondary, TValue>> InnerReaderWriter;

            static DoubleLookupDictionaryFormatter();
            DoubleLookupDictionaryFormatter();
            Sirenix.Serialization.Utilities.DoubleLookupDictionary<TPrimary, TSecondary, TValue> GetUninitializedObject();
            void SerializeImplementation(ref Sirenix.Serialization.Utilities.DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, Sirenix.Serialization.IDataWriter writer);
            void DeserializeImplementation(ref Sirenix.Serialization.Utilities.DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, Sirenix.Serialization.IDataReader reader);
        }

        class WeakDoubleLookupDictionaryFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer PrimaryReaderWriter;
            /*0x48*/ Sirenix.Serialization.Serializer InnerReaderWriter;

            /*0x22c3794*/ WeakDoubleLookupDictionaryFormatter(System.Type serializedType);
            /*0x22c38c8*/ object GetUninitializedObject();
            /*0x22c38d0*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c417c*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
        }

        class EasyBaseFormatter<T> : Sirenix.Serialization.BaseFormatter<T>
        {
            EasyBaseFormatter();
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);
            void ReadDataEntry(ref T value, string entryName, Sirenix.Serialization.EntryType entryType, Sirenix.Serialization.IDataReader reader);
            void WriteDataEntries(ref T value, Sirenix.Serialization.IDataWriter writer);
        }

        class EmittedFormatterAttribute : System.Attribute
        {
            /*0x22c4d50*/ EmittedFormatterAttribute();
        }

        class EmptyTypeFormatter<T> : Sirenix.Serialization.EasyBaseFormatter<T>
        {
            EmptyTypeFormatter();
            void ReadDataEntry(ref T value, string entryName, Sirenix.Serialization.EntryType entryType, Sirenix.Serialization.IDataReader reader);
            void WriteDataEntries(ref T value, Sirenix.Serialization.IDataWriter writer);
        }

        class FormatterEmitter
        {
            static string PRE_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.AOTGenerated";
            static string RUNTIME_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.RuntimeEmitted";
            static /*0x0*/ int helperFormatterNameId;

            static /*0x22bcc0c*/ Sirenix.Serialization.IFormatter GetEmittedFormatter(System.Type type, Sirenix.Serialization.ISerializationPolicy policy);

            class AOTEmittedFormatter<T> : Sirenix.Serialization.EasyBaseFormatter<T>
            {
                AOTEmittedFormatter();
            }

            class EmptyAOTEmittedFormatter<T> : Sirenix.Serialization.FormatterEmitter.AOTEmittedFormatter<T>
            {
                EmptyAOTEmittedFormatter();
                void ReadDataEntry(ref T value, string entryName, Sirenix.Serialization.EntryType entryType, Sirenix.Serialization.IDataReader reader);
                void WriteDataEntries(ref T value, Sirenix.Serialization.IDataWriter writer);
            }
        }

        class GenericCollectionFormatter
        {
            static /*0x22bd848*/ bool CanFormat(System.Type type, ref System.Type elementType);
        }

        class GenericCollectionFormatter<TCollection, TElement> : Sirenix.Serialization.BaseFormatter<TCollection>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<TElement> valueReaderWriter;

            static GenericCollectionFormatter();
            GenericCollectionFormatter();
            TCollection GetUninitializedObject();
            void DeserializeImplementation(ref TCollection value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref TCollection value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakGenericCollectionFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ValueReaderWriter;
            /*0x48*/ System.Type ElementType;
            /*0x50*/ System.Reflection.PropertyInfo CountProperty;
            /*0x58*/ System.Reflection.MethodInfo AddMethod;

            /*0x22bda88*/ WeakGenericCollectionFormatter(System.Type collectionType, System.Type elementType);
            /*0x22c4d58*/ object GetUninitializedObject();
            /*0x22c4d64*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c586c*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class HashSetFormatter<T> : Sirenix.Serialization.BaseFormatter<System.Collections.Generic.HashSet<T>>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<T> TSerializer;

            static HashSetFormatter();
            HashSetFormatter();
            System.Collections.Generic.HashSet<T> GetUninitializedObject();
            void DeserializeImplementation(ref System.Collections.Generic.HashSet<T> value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref System.Collections.Generic.HashSet<T> value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakHashSetFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ElementSerializer;
            /*0x48*/ System.Reflection.MethodInfo AddMethod;
            /*0x50*/ System.Reflection.PropertyInfo CountProperty;

            /*0x22c5dcc*/ WeakHashSetFormatter(System.Type serializedType);
            /*0x22c60ac*/ object GetUninitializedObject();
            /*0x22c60b4*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c68f4*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        interface IFormatter
        {
            System.Type get_SerializedType();
            void Serialize(object value, Sirenix.Serialization.IDataWriter writer);
            object Deserialize(Sirenix.Serialization.IDataReader reader);
        }

        interface IFormatter<T> : Sirenix.Serialization.IFormatter
        {
            void Serialize(T value, Sirenix.Serialization.IDataWriter writer);
            T Deserialize(Sirenix.Serialization.IDataReader reader);
        }

        class KeyValuePairFormatter<TKey, TValue> : Sirenix.Serialization.BaseFormatter<System.Collections.Generic.KeyValuePair<TKey, TValue>>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<TKey> KeySerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<TValue> ValueSerializer;

            static KeyValuePairFormatter();
            KeyValuePairFormatter();
            void SerializeImplementation(ref System.Collections.Generic.KeyValuePair<TKey, TValue> value, Sirenix.Serialization.IDataWriter writer);
            void DeserializeImplementation(ref System.Collections.Generic.KeyValuePair<TKey, TValue> value, Sirenix.Serialization.IDataReader reader);
        }

        class WeakKeyValuePairFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer KeySerializer;
            /*0x48*/ Sirenix.Serialization.Serializer ValueSerializer;
            /*0x50*/ System.Reflection.PropertyInfo KeyProperty;
            /*0x58*/ System.Reflection.PropertyInfo ValueProperty;

            /*0x22c6f98*/ WeakKeyValuePairFormatter(System.Type serializedType);
            /*0x22c70b0*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c7150*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
        }

        class ListFormatter<T> : Sirenix.Serialization.BaseFormatter<System.Collections.Generic.List<T>>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<T> TSerializer;

            static ListFormatter();
            ListFormatter();
            System.Collections.Generic.List<T> GetUninitializedObject();
            void DeserializeImplementation(ref System.Collections.Generic.List<T> value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref System.Collections.Generic.List<T> value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakListFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ElementSerializer;

            /*0x22c7270*/ WeakListFormatter(System.Type serializedType);
            /*0x22c7388*/ object GetUninitializedObject();
            /*0x22c7390*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c7ca4*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class MethodInfoFormatter<T> : Sirenix.Serialization.BaseFormatter<T>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<string> StringSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Type> TypeSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<System.Type[]> TypeArraySerializer;

            static MethodInfoFormatter();
            MethodInfoFormatter();
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);
            T GetUninitializedObject();

            class <>c<T>
            {
                static /*0x0*/ Sirenix.Serialization.MethodInfoFormatter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Type, string> <>9__3_0;
                static /*0x0*/ System.Func<System.Type, string> <>9__3_1;

                static <>c();
                <>c();
                string <DeserializeImplementation>b__3_0(System.Type p);
                string <DeserializeImplementation>b__3_1(System.Type p);
            }
        }

        class WeakMethodInfoFormatter : Sirenix.Serialization.MethodInfoFormatter<System.Reflection.MethodInfo>
        {
            /*0x22c818c*/ WeakMethodInfoFormatter();
        }

        class MinimalBaseFormatter<T> : Sirenix.Serialization.IFormatter<T>, Sirenix.Serialization.IFormatter
        {
            static /*0x0*/ bool IsValueType;

            static MinimalBaseFormatter();
            MinimalBaseFormatter();
            System.Type get_SerializedType();
            T Deserialize(Sirenix.Serialization.IDataReader reader);
            void Serialize(T value, Sirenix.Serialization.IDataWriter writer);
            void Sirenix.Serialization.IFormatter.Serialize(object value, Sirenix.Serialization.IDataWriter writer);
            object Sirenix.Serialization.IFormatter.Deserialize(Sirenix.Serialization.IDataReader reader);
            T GetUninitializedObject();
            void Read(ref T value, Sirenix.Serialization.IDataReader reader);
            void Write(ref T value, Sirenix.Serialization.IDataWriter writer);
            void RegisterReferenceID(T value, Sirenix.Serialization.IDataReader reader);
        }

        class WeakMinimalBaseFormatter : Sirenix.Serialization.IFormatter
        {
            /*0x10*/ System.Type SerializedType;
            /*0x18*/ bool IsValueType;

            /*0x22c8200*/ WeakMinimalBaseFormatter(System.Type serializedType);
            /*0x22c81f8*/ System.Type Sirenix.Serialization.IFormatter.get_SerializedType();
            /*0x22c8244*/ object Deserialize(Sirenix.Serialization.IDataReader reader);
            /*0x22c8434*/ void Serialize(object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c8454*/ object GetUninitializedObject();
            void Read(ref object value, Sirenix.Serialization.IDataReader reader);
            void Write(ref object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c82b0*/ void RegisterReferenceID(object value, Sirenix.Serialization.IDataReader reader);
        }

        class MultiDimensionalArrayFormatter<TArray, TElement> : Sirenix.Serialization.BaseFormatter<TArray>
        {
            static string RANKS_NAME = "ranks";
            static char RANKS_SEPARATOR = 124;
            static /*0x0*/ int ArrayRank;
            static /*0x0*/ Sirenix.Serialization.Serializer<TElement> ValueReaderWriter;

            static MultiDimensionalArrayFormatter();
            MultiDimensionalArrayFormatter();
            TArray GetUninitializedObject();
            void DeserializeImplementation(ref TArray value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref TArray value, Sirenix.Serialization.IDataWriter writer);
            void IterateArrayWrite(System.Array a, System.Func<TElement> write);
            void IterateArrayWrite(System.Array a, int rank, int[] indices, System.Func<TElement> write);
            void IterateArrayRead(System.Array a, System.Action<TElement> read);
            void IterateArrayRead(System.Array a, int rank, int[] indices, System.Action<TElement> read);

            class <>c__DisplayClass6_0<TArray, TElement>
            {
                /*0x0*/ Sirenix.Serialization.IDataReader reader;
                /*0x0*/ string name;
                /*0x0*/ int elements;
                /*0x0*/ long length;

                <>c__DisplayClass6_0();
                TElement <DeserializeImplementation>b__0();
            }

            class <>c__DisplayClass7_0<TArray, TElement>
            {
                /*0x0*/ Sirenix.Serialization.IDataWriter writer;

                <>c__DisplayClass7_0();
                void <SerializeImplementation>b__0(TElement v);
            }
        }

        class WeakMultiDimensionalArrayFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            static string RANKS_NAME = "ranks";
            static char RANKS_SEPARATOR = 124;
            /*0x3c*/ int ArrayRank;
            /*0x40*/ System.Type ElementType;
            /*0x48*/ Sirenix.Serialization.Serializer ValueReaderWriter;

            /*0x22b8798*/ WeakMultiDimensionalArrayFormatter(System.Type arrayType, System.Type elementType);
            /*0x22c84cc*/ object GetUninitializedObject();
            /*0x22c84d4*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c8cfc*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c8c8c*/ void IterateArrayWrite(System.Array a, System.Func<object> write);
            /*0x22c92b0*/ void IterateArrayWrite(System.Array a, int rank, int[] indices, System.Func<object> write);
            /*0x22c9240*/ void IterateArrayRead(System.Array a, System.Action<object> read);
            /*0x22c93ac*/ void IterateArrayRead(System.Array a, int rank, int[] indices, System.Action<object> read);

            class <>c__DisplayClass7_0
            {
                /*0x10*/ Sirenix.Serialization.IDataReader reader;
                /*0x18*/ string name;
                /*0x20*/ Sirenix.Serialization.WeakMultiDimensionalArrayFormatter <>4__this;
                /*0x28*/ int elements;
                /*0x30*/ long length;

                /*0x22c8c84*/ <>c__DisplayClass7_0();
                /*0x22c94a8*/ object <DeserializeImplementation>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ Sirenix.Serialization.WeakMultiDimensionalArrayFormatter <>4__this;
                /*0x18*/ Sirenix.Serialization.IDataWriter writer;

                /*0x22c9238*/ <>c__DisplayClass8_0();
                /*0x22c988c*/ void <SerializeImplementation>b__0(object v);
            }
        }

        class NullableFormatter<T> : Sirenix.Serialization.BaseFormatter<System.Nullable<T>>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<T> TSerializer;

            static NullableFormatter();
            NullableFormatter();
            void DeserializeImplementation(ref System.Nullable<T> value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref System.Nullable<T> value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakNullableFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ValueSerializer;

            /*0x22c98b8*/ WeakNullableFormatter(System.Type nullableType);
            /*0x22c995c*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22c9aa4*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22c9b80*/ object GetUninitializedObject();
        }

        class PrimitiveArrayFormatter<T> : Sirenix.Serialization.MinimalBaseFormatter<T[]>
        {
            PrimitiveArrayFormatter();
            T[] GetUninitializedObject();
            void Read(ref T[] value, Sirenix.Serialization.IDataReader reader);
            void Write(ref T[] value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakPrimitiveArrayFormatter : Sirenix.Serialization.WeakMinimalBaseFormatter
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Sirenix.Serialization.WeakPrimitiveArrayFormatter.PrimitiveArrayType> PrimitiveTypes;
            /*0x20*/ System.Type ElementType;
            /*0x28*/ Sirenix.Serialization.WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveType;

            static /*0x22cad50*/ WeakPrimitiveArrayFormatter();
            /*0x22b85dc*/ WeakPrimitiveArrayFormatter(System.Type arrayType, System.Type elementType);
            /*0x22c9b88*/ object GetUninitializedObject();
            /*0x22c9b90*/ void Read(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22ca4c4*/ void Write(ref object value, Sirenix.Serialization.IDataWriter writer);

            enum PrimitiveArrayType
            {
                PrimitiveArray_char = 0,
                PrimitiveArray_sbyte = 1,
                PrimitiveArray_short = 2,
                PrimitiveArray_int = 3,
                PrimitiveArray_long = 4,
                PrimitiveArray_byte = 5,
                PrimitiveArray_ushort = 6,
                PrimitiveArray_uint = 7,
                PrimitiveArray_ulong = 8,
                PrimitiveArray_decimal = 9,
                PrimitiveArray_bool = 10,
                PrimitiveArray_float = 11,
                PrimitiveArray_double = 12,
                PrimitiveArray_Guid = 13,
            }
        }

        class QueueFormatter<TQueue, TValue> : Sirenix.Serialization.BaseFormatter<TQueue>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<TValue> TSerializer;
            static /*0x0*/ bool IsPlainQueue;

            static QueueFormatter();
            QueueFormatter();
            TQueue GetUninitializedObject();
            void DeserializeImplementation(ref TQueue value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref TQueue value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakQueueFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ElementSerializer;
            /*0x48*/ bool IsPlainQueue;
            /*0x50*/ System.Reflection.MethodInfo EnqueueMethod;

            /*0x22cb144*/ WeakQueueFormatter(System.Type serializedType);
            /*0x22cb41c*/ object GetUninitializedObject();
            /*0x22cb424*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22cbd54*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class ReflectionFormatter<T> : Sirenix.Serialization.BaseFormatter<T>
        {
            /*0x0*/ Sirenix.Serialization.ISerializationPolicy <OverridePolicy>k__BackingField;

            ReflectionFormatter();
            ReflectionFormatter(Sirenix.Serialization.ISerializationPolicy overridePolicy);
            Sirenix.Serialization.ISerializationPolicy get_OverridePolicy();
            void set_OverridePolicy(Sirenix.Serialization.ISerializationPolicy value);
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakReflectionFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x22cd3e0*/ WeakReflectionFormatter(System.Type serializedType);
            /*0x22cd3e8*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22ceb90*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class ReflectionOrEmittedBaseFormatter<T> : Sirenix.Serialization.ReflectionFormatter<T>
        {
            ReflectionOrEmittedBaseFormatter();
        }

        class SelfFormatterFormatter<T> : Sirenix.Serialization.BaseFormatter<T>
        {
            SelfFormatterFormatter();
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakSelfFormatterFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x22cf2fc*/ WeakSelfFormatterFormatter(System.Type serializedType);
            /*0x22cf304*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22cf3fc*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class SerializableFormatter<T> : Sirenix.Serialization.BaseFormatter<T>
        {
            static /*0x0*/ System.Func<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext, T> ISerializableConstructor;
            static /*0x0*/ Sirenix.Serialization.ReflectionFormatter<T> ReflectionFormatter;

            static SerializableFormatter();
            SerializableFormatter();
            T GetUninitializedObject();
            void DeserializeImplementation(ref T value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref T value, Sirenix.Serialization.IDataWriter writer);
            System.Runtime.Serialization.SerializationInfo ReadSerializationInfo(Sirenix.Serialization.IDataReader reader);
            void WriteSerializationInfo(System.Runtime.Serialization.SerializationInfo info, Sirenix.Serialization.IDataWriter writer);

            class <>c__DisplayClass2_0<T>
            {
                /*0x0*/ System.Reflection.ConstructorInfo constructor;

                <>c__DisplayClass2_0();
                T <.cctor>b__0(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }
        }

        class WeakSerializableFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ System.Func<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext, System.Runtime.Serialization.ISerializable> ISerializableConstructor;
            /*0x48*/ Sirenix.Serialization.WeakReflectionFormatter ReflectionFormatter;

            /*0x22cf4f0*/ WeakSerializableFormatter(System.Type serializedType);
            /*0x22cfa40*/ object GetUninitializedObject();
            /*0x22cfa48*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22d0498*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22cfdc0*/ System.Runtime.Serialization.SerializationInfo ReadSerializationInfo(Sirenix.Serialization.IDataReader reader);
            /*0x22d07d4*/ void WriteSerializationInfo(System.Runtime.Serialization.SerializationInfo info, Sirenix.Serialization.IDataWriter writer);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ Sirenix.Serialization.WeakSerializableFormatter <>4__this;
                /*0x18*/ System.Reflection.ConstructorInfo constructor;

                /*0x22cfa38*/ <>c__DisplayClass2_0();
                /*0x22d0e24*/ System.Runtime.Serialization.ISerializable <.ctor>b__0(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }
        }

        class StackFormatter<TStack, TValue> : Sirenix.Serialization.BaseFormatter<TStack>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<TValue> TSerializer;
            static /*0x0*/ bool IsPlainStack;

            static StackFormatter();
            StackFormatter();
            TStack GetUninitializedObject();
            void DeserializeImplementation(ref TStack value, Sirenix.Serialization.IDataReader reader);
            void SerializeImplementation(ref TStack value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakStackFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            /*0x40*/ Sirenix.Serialization.Serializer ElementSerializer;
            /*0x48*/ bool IsPlainStack;
            /*0x50*/ System.Reflection.MethodInfo PushMethod;

            /*0x22d0fc0*/ WeakStackFormatter(System.Type serializedType);
            /*0x22d1264*/ object GetUninitializedObject();
            /*0x22d126c*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22d1b44*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class TimeSpanFormatter : Sirenix.Serialization.MinimalBaseFormatter<System.TimeSpan>
        {
            /*0x22d2638*/ TimeSpanFormatter();
            /*0x22d245c*/ void Read(ref System.TimeSpan value, Sirenix.Serialization.IDataReader reader);
            /*0x22d2588*/ void Write(ref System.TimeSpan value, Sirenix.Serialization.IDataWriter writer);
        }

        class TypeFormatter : Sirenix.Serialization.MinimalBaseFormatter<System.Type>
        {
            /*0x22d2ae4*/ TypeFormatter();
            /*0x22d26a4*/ void Read(ref System.Type value, Sirenix.Serialization.IDataReader reader);
            /*0x22d2930*/ void Write(ref System.Type value, Sirenix.Serialization.IDataWriter writer);
            /*0x22d2adc*/ System.Type GetUninitializedObject();
        }

        class VersionFormatter : Sirenix.Serialization.MinimalBaseFormatter<System.Version>
        {
            /*0x22d3010*/ VersionFormatter();
            /*0x22d2b50*/ System.Version GetUninitializedObject();
            /*0x22d2b58*/ void Read(ref System.Version value, Sirenix.Serialization.IDataReader reader);
            /*0x22d2e00*/ void Write(ref System.Version value, Sirenix.Serialization.IDataWriter writer);
        }

        class AllowDeserializeInvalidDataAttribute : System.Attribute
        {
            /*0x22d307c*/ AllowDeserializeInvalidDataAttribute();
        }

        class AlwaysFormatsSelfAttribute : System.Attribute
        {
            /*0x22d3084*/ AlwaysFormatsSelfAttribute();
        }

        class ArchitectureInfo
        {
            static /*0x0*/ bool Architecture_Supports_Unaligned_Float32_Reads;
            static /*0x1*/ bool Architecture_Supports_All_Unaligned_ReadWrites;

            static /*0x22d308c*/ ArchitectureInfo();
            static /*0x22d3114*/ void SetRuntimePlatform(UnityEngine.RuntimePlatform platform);
        }

        class Buffer<T> : System.IDisposable
        {
            static /*0x0*/ object LOCK;
            static /*0x0*/ System.Collections.Generic.List<Sirenix.Serialization.Buffer<T>> FreeBuffers;
            /*0x0*/ int count;
            /*0x0*/ T[] array;
            /*0x0*/ bool isFree;

            static Buffer();
            static Sirenix.Serialization.Buffer<T> Claim(int minimumCapacity);
            static void Free(Sirenix.Serialization.Buffer<T> buffer);
            static int NextPowerOfTwo(int v);
            Buffer(int count);
            int get_Count();
            T[] get_Array();
            bool get_IsFree();
            void Free();
            void Dispose();
        }

        class CachedMemoryStream : Sirenix.Serialization.Utilities.ICacheNotificationReceiver
        {
            static /*0x0*/ int InitialCapacity;
            static /*0x4*/ int MaxCapacity;
            /*0x10*/ System.IO.MemoryStream memoryStream;

            static /*0x22d38dc*/ CachedMemoryStream();
            static /*0x22d3744*/ Sirenix.Serialization.Utilities.Cache<Sirenix.Serialization.CachedMemoryStream> Claim(int minCapacity);
            static /*0x22d380c*/ Sirenix.Serialization.Utilities.Cache<Sirenix.Serialization.CachedMemoryStream> Claim(byte[] bytes);
            /*0x22d355c*/ CachedMemoryStream();
            /*0x22d34a4*/ System.IO.MemoryStream get_MemoryStream();
            /*0x22d35fc*/ void OnFreed();
            /*0x22d36fc*/ void OnClaimed();
        }

        class CustomFormatterAttribute : System.Attribute
        {
            /*0x10*/ int Priority;

            /*0x22d392c*/ CustomFormatterAttribute();
            /*0x22d3948*/ CustomFormatterAttribute(int priority);
        }

        class CustomGenericFormatterAttribute : Sirenix.Serialization.CustomFormatterAttribute
        {
            /*0x18*/ System.Type SerializedGenericTypeDefinition;

            /*0x22d3970*/ CustomGenericFormatterAttribute(System.Type serializedGenericTypeDefinition, int priority);
        }

        class CustomSerializationPolicy : Sirenix.Serialization.ISerializationPolicy
        {
            /*0x10*/ string id;
            /*0x18*/ bool allowNonSerializableTypes;
            /*0x20*/ System.Func<System.Reflection.MemberInfo, bool> shouldSerializeFunc;

            /*0x22d3ae8*/ CustomSerializationPolicy(string id, bool allowNonSerializableTypes, System.Func<System.Reflection.MemberInfo, bool> shouldSerializeFunc);
            /*0x22d3ba4*/ string get_ID();
            /*0x22d3bac*/ bool get_AllowNonSerializableTypes();
            /*0x22d3bb4*/ bool ShouldSerializeMember(System.Reflection.MemberInfo member);
        }

        class BindTypeNameToTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type NewType;
            /*0x18*/ string OldTypeName;

            /*0x22d3bd8*/ BindTypeNameToTypeAttribute(string oldFullTypeName, System.Type newType);
        }

        class DefaultSerializationBinder : Sirenix.Serialization.TwoWaySerializationBinder
        {
            static /*0x0*/ object ASSEMBLY_LOOKUP_LOCK;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, System.Reflection.Assembly> assemblyNameLookUp;
            static /*0x10*/ System.Collections.Generic.Dictionary<string, System.Type> customTypeNameToTypeBindings;
            static /*0x18*/ object TYPETONAME_LOCK;
            static /*0x20*/ System.Collections.Generic.Dictionary<System.Type, string> nameMap;
            static /*0x28*/ object NAMETOTYPE_LOCK;
            static /*0x30*/ System.Collections.Generic.Dictionary<string, System.Type> typeMap;
            static /*0x38*/ object ASSEMBLY_REGISTER_QUEUE_LOCK;
            static /*0x40*/ System.Collections.Generic.List<System.Reflection.Assembly> assembliesQueuedForRegister;
            static /*0x48*/ System.Collections.Generic.List<System.AssemblyLoadEventArgs> assemblyLoadEventsQueuedForRegister;

            static /*0x22d3c04*/ DefaultSerializationBinder();
            static /*0x22d427c*/ void RegisterAllQueuedAssembliesRepeating();
            static /*0x22d42e0*/ bool RegisterQueuedAssemblies();
            static /*0x22d4540*/ bool RegisterQueuedAssemblyLoadEvents();
            static /*0x22d4828*/ void RegisterAssembly(System.Reflection.Assembly assembly);
            static /*0x22d6928*/ void ParseName(string fullName, ref string typeName, ref string assemblyName);
            static /*0x22d6aac*/ bool TryParseGenericAndOrArrayTypeName(string typeName, ref string actualTypeName, ref bool isGeneric, ref System.Collections.Generic.List<string> genericArgNames, ref bool isArray, ref int arrayRank);
            static /*0x22d6e18*/ char Peek(string str, int i, int ahead);
            static /*0x22d6e4c*/ bool ReadGenericArg(string typeName, ref int i, ref string argName);
            /*0x22d6f34*/ DefaultSerializationBinder();
            /*0x22d4d4c*/ string BindToName(System.Type type, Sirenix.Serialization.DebugContext debugContext);
            /*0x22d54f4*/ bool ContainsType(string typeName);
            /*0x22d5644*/ System.Type BindToType(string typeName, Sirenix.Serialization.DebugContext debugContext);
            /*0x22d5914*/ System.Type ParseTypeName(string typeName, Sirenix.Serialization.DebugContext debugContext);
            /*0x22d6060*/ System.Type ParseGenericAndOrArrayType(string typeName, Sirenix.Serialization.DebugContext debugContext);

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.DefaultSerializationBinder.<> <>9;

                static /*0x22d6f94*/ <>c();
                /*0x22d6ff8*/ <>c();
                /*0x22d7000*/ void <.cctor>b__10_0(object sender, System.AssemblyLoadEventArgs args);
            }
        }

        class DeserializationContext : Sirenix.Serialization.Utilities.ICacheNotificationReceiver
        {
            /*0x10*/ Sirenix.Serialization.SerializationConfig config;
            /*0x18*/ System.Collections.Generic.Dictionary<int, object> internalIdReferenceMap;
            /*0x20*/ System.Runtime.Serialization.StreamingContext streamingContext;
            /*0x30*/ System.Runtime.Serialization.IFormatterConverter formatterConverter;
            /*0x38*/ Sirenix.Serialization.TwoWaySerializationBinder binder;
            /*0x40*/ Sirenix.Serialization.IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField;
            /*0x48*/ Sirenix.Serialization.IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField;
            /*0x50*/ Sirenix.Serialization.IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField;

            /*0x22d7190*/ DeserializationContext();
            /*0x22d72f8*/ DeserializationContext(System.Runtime.Serialization.StreamingContext context);
            /*0x22d7374*/ DeserializationContext(System.Runtime.Serialization.FormatterConverter formatterConverter);
            /*0x22d71fc*/ DeserializationContext(System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.FormatterConverter formatterConverter);
            /*0x22d0d54*/ Sirenix.Serialization.TwoWaySerializationBinder get_Binder();
            /*0x22d73f0*/ void set_Binder(Sirenix.Serialization.TwoWaySerializationBinder value);
            /*0x22d73f8*/ Sirenix.Serialization.IExternalStringReferenceResolver get_StringReferenceResolver();
            /*0x22d7400*/ void set_StringReferenceResolver(Sirenix.Serialization.IExternalStringReferenceResolver value);
            /*0x22d7408*/ Sirenix.Serialization.IExternalGuidReferenceResolver get_GuidReferenceResolver();
            /*0x22d7410*/ void set_GuidReferenceResolver(Sirenix.Serialization.IExternalGuidReferenceResolver value);
            /*0x22d7418*/ Sirenix.Serialization.IExternalIndexReferenceResolver get_IndexReferenceResolver();
            /*0x22d7420*/ void set_IndexReferenceResolver(Sirenix.Serialization.IExternalIndexReferenceResolver value);
            /*0x22d7428*/ System.Runtime.Serialization.StreamingContext get_StreamingContext();
            /*0x22d7434*/ System.Runtime.Serialization.IFormatterConverter get_FormatterConverter();
            /*0x22cdde0*/ Sirenix.Serialization.SerializationConfig get_Config();
            /*0x22d74ac*/ void set_Config(Sirenix.Serialization.SerializationConfig value);
            /*0x22d74b4*/ void RegisterInternalReference(int id, object reference);
            /*0x22d751c*/ object GetInternalReference(int id);
            /*0x22d758c*/ object GetExternalObject(int index);
            /*0x22d7704*/ object GetExternalObject(System.Guid guid);
            /*0x22d791c*/ object GetExternalObject(string id);
            /*0x22d7384*/ void Reset();
            /*0x22d7be8*/ void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed();
            /*0x22d7bec*/ void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed();
        }

        class EmittedAssemblyAttribute : System.Attribute
        {
            /*0x22d7bf0*/ EmittedAssemblyAttribute();
        }

        enum EntryType
        {
            Invalid = 0,
            String = 1,
            Guid = 2,
            Integer = 3,
            FloatingPoint = 4,
            Boolean = 5,
            Null = 6,
            StartOfNode = 7,
            EndOfNode = 8,
            InternalReference = 9,
            ExternalReferenceByIndex = 10,
            ExternalReferenceByGuid = 11,
            StartOfArray = 12,
            EndOfArray = 13,
            PrimitiveArray = 14,
            EndOfStream = 15,
            ExternalReferenceByString = 16,
        }

        class ExcludeDataFromInspectorAttribute : System.Attribute
        {
            /*0x22d7bf8*/ ExcludeDataFromInspectorAttribute();
        }

        enum FormatterLocationStep
        {
            BeforeRegisteredFormatters = 0,
            AfterRegisteredFormatters = 1,
        }

        class FormatterUtilities
        {
            static string UnityObjectRuntimeErrorString = "The variable nullValue of {0} has not been assigned.
You probably need to assign the nullValue variable of the {0} script in the inspector.";
            static /*0x0*/ Sirenix.Serialization.Utilities.DoubleLookupDictionary<Sirenix.Serialization.ISerializationPolicy, System.Type, System.Reflection.MemberInfo[]> MemberArrayCache;
            static /*0x8*/ Sirenix.Serialization.Utilities.DoubleLookupDictionary<Sirenix.Serialization.ISerializationPolicy, System.Type, System.Collections.Generic.Dictionary<string, System.Reflection.MemberInfo>> MemberMapCache;
            static /*0x10*/ object LOCK;
            static /*0x18*/ System.Collections.Generic.HashSet<System.Type> PrimitiveArrayTypes;
            static /*0x20*/ System.Reflection.FieldInfo UnityObjectRuntimeErrorStringField;

            static /*0x22d7c00*/ FormatterUtilities();
            static /*0x22cdf80*/ System.Collections.Generic.Dictionary<string, System.Reflection.MemberInfo> GetSerializableMembersMap(System.Type type, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22cef0c*/ System.Reflection.MemberInfo[] GetSerializableMembers(System.Type type, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22d91bc*/ UnityEngine.Object CreateUnityNull(System.Type nullType, System.Type owningType);
            static /*0x22d956c*/ bool IsPrimitiveType(System.Type type);
            static /*0x22d96bc*/ bool IsPrimitiveArrayType(System.Type type);
            static /*0x22ce57c*/ System.Type GetContainedType(System.Reflection.MemberInfo member);
            static /*0x22cf17c*/ object GetMemberValue(System.Reflection.MemberInfo member, object obj);
            static /*0x22ce724*/ void SetMemberValue(System.Reflection.MemberInfo member, object obj, object value);
            static /*0x22d8328*/ System.Collections.Generic.Dictionary<string, System.Reflection.MemberInfo> FindSerializableMembersMap(System.Type type, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22d89c0*/ void FindSerializableMembers(System.Type type, System.Collections.Generic.List<System.Reflection.MemberInfo> members, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22d98f0*/ System.Reflection.MemberInfo GetPrivateMemberAlias(System.Reflection.MemberInfo member, string prefixString, string separatorString);
            static /*0x22d9744*/ bool MemberIsPrivate(System.Reflection.MemberInfo member);

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.FormatterUtilities.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MemberInfo, string> <>9__15_0;
                static /*0x10*/ System.Func<System.Reflection.MemberInfo, System.Reflection.MemberInfo> <>9__15_1;
                static /*0x18*/ System.Func<System.Reflection.MemberInfo, bool> <>9__16_0;

                static /*0x22d9c54*/ <>c();
                /*0x22d9cb8*/ <>c();
                /*0x22d9cc0*/ string <FindSerializableMembersMap>b__15_0(System.Reflection.MemberInfo n);
                /*0x22d9ce4*/ System.Reflection.MemberInfo <FindSerializableMembersMap>b__15_1(System.Reflection.MemberInfo n);
                /*0x22d9cec*/ bool <FindSerializableMembers>b__16_0(System.Reflection.MemberInfo n);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ System.Reflection.MemberInfo member;

                /*0x22d973c*/ <>c__DisplayClass16_0();
                /*0x22d9da4*/ bool <FindSerializableMembers>b__1(System.Reflection.MemberInfo n);
            }
        }

        interface IAskIfCanFormatTypes
        {
            bool CanFormatType(System.Type type);
        }

        interface IExternalGuidReferenceResolver
        {
            Sirenix.Serialization.IExternalGuidReferenceResolver get_NextResolver();
            void set_NextResolver(Sirenix.Serialization.IExternalGuidReferenceResolver value);
            bool TryResolveReference(System.Guid guid, ref object value);
            bool CanReference(object value, ref System.Guid guid);
        }

        interface IExternalIndexReferenceResolver
        {
            bool TryResolveReference(int index, ref object value);
            bool CanReference(object value, ref int index);
        }

        interface IExternalStringReferenceResolver
        {
            Sirenix.Serialization.IExternalStringReferenceResolver get_NextResolver();
            void set_NextResolver(Sirenix.Serialization.IExternalStringReferenceResolver value);
            bool TryResolveReference(string id, ref object value);
            bool CanReference(object value, ref string id);
        }

        interface ISelfFormatter
        {
            void Serialize(Sirenix.Serialization.IDataWriter writer);
            void Deserialize(Sirenix.Serialization.IDataReader reader);
        }

        interface ISerializationPolicy
        {
            string get_ID();
            bool get_AllowNonSerializableTypes();
            bool ShouldSerializeMember(System.Reflection.MemberInfo member);
        }

        struct NodeInfo
        {
            static /*0x0*/ Sirenix.Serialization.NodeInfo Empty;
            /*0x10*/ string Name;
            /*0x18*/ int Id;
            /*0x20*/ System.Type Type;
            /*0x28*/ bool IsArray;
            /*0x29*/ bool IsEmpty;

            static /*0x22da190*/ NodeInfo();
            static /*0x22d9e38*/ bool op_Equality(Sirenix.Serialization.NodeInfo a, Sirenix.Serialization.NodeInfo b);
            static /*0x22d9f00*/ bool op_Inequality(Sirenix.Serialization.NodeInfo a, Sirenix.Serialization.NodeInfo b);
            /*0x22d9e00*/ NodeInfo(string name, int id, System.Type type, bool isArray);
            /*0x22d9e1c*/ NodeInfo(bool parameter);
            /*0x22d9f98*/ bool Equals(object obj);
            /*0x22da060*/ int GetHashCode();
        }

        class OdinSerializeAttribute : System.Attribute
        {
            /*0x22da1f4*/ OdinSerializeAttribute();
        }

        class PrefabModification
        {
            /*0x10*/ Sirenix.Serialization.PrefabModificationType ModificationType;
            /*0x18*/ string Path;
            /*0x20*/ System.Collections.Generic.List<string> ReferencePaths;
            /*0x28*/ object ModifiedValue;
            /*0x30*/ int NewLength;
            /*0x38*/ object[] DictionaryKeysAdded;
            /*0x40*/ object[] DictionaryKeysRemoved;

            static /*0x22db418*/ void ReplaceAllReferencesInGraph(object graph, object oldReference, object newReference, System.Collections.Generic.HashSet<object> processedReferences);
            static /*0x22db28c*/ object GetInstanceFromPath(string path, object instance);
            static /*0x22dbbdc*/ object GetInstanceOfStep(string step, object instance);
            static /*0x22db364*/ void SetInstanceToPath(string path, object instance, object value);
            static /*0x22dc918*/ void SetInstanceToPath(string path, string[] steps, int index, object instance, object value, ref bool setParentInstance);
            static /*0x22dca00*/ bool TrySetInstanceOfStep(string step, object instance, object value, ref bool setParentInstance);
            /*0x22dd9a8*/ PrefabModification();
            /*0x22da1fc*/ void Apply(UnityEngine.Object unityObject);
            /*0x22da2c4*/ void ApplyValue(UnityEngine.Object unityObject);
            /*0x22da49c*/ void ApplyListLength(UnityEngine.Object unityObject);
            /*0x22dae1c*/ void ApplyDictionaryModifications(UnityEngine.Object unityObject);

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.PrefabModification.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MemberInfo, bool> <>9__13_0;
                static /*0x10*/ System.Func<System.Reflection.MemberInfo, bool> <>9__16_0;

                static /*0x22dd9b0*/ <>c();
                /*0x22dda14*/ <>c();
                /*0x22dda1c*/ bool <GetInstanceOfStep>b__13_0(System.Reflection.MemberInfo n);
                /*0x22ddad4*/ bool <TrySetInstanceOfStep>b__16_0(System.Reflection.MemberInfo n);
            }
        }

        enum PrefabModificationType
        {
            Value = 0,
            ListLength = 1,
            Dictionary = 2,
        }

        class PreviouslySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x22ddb9c*/ PreviouslySerializedAsAttribute(string name);
            /*0x22ddb8c*/ string get_Name();
            /*0x22ddb94*/ void set_Name(string value);
        }

        class ProperBitConverter
        {
            static /*0x0*/ uint[] ByteToHexCharLookupLowerCase;
            static /*0x8*/ uint[] ByteToHexCharLookupUpperCase;
            static /*0x10*/ byte[] HexToByteLookup;

            static /*0x22e0664*/ ProperBitConverter();
            static /*0x22ddbc4*/ uint[] CreateByteToHexLookup(bool upperCase);
            static /*0x22ddd90*/ string BytesToHexString(byte[] bytes, bool lowerCaseHexChars);
            static /*0x22ddebc*/ byte[] HexStringToBytes(string hex);
            static /*0x22de878*/ short ToInt16(byte[] buffer, int index);
            static /*0x22de8b8*/ ushort ToUInt16(byte[] buffer, int index);
            static /*0x22de8f8*/ int ToInt32(byte[] buffer, int index);
            static /*0x22de960*/ uint ToUInt32(byte[] buffer, int index);
            static /*0x22de9c8*/ long ToInt64(byte[] buffer, int index);
            static /*0x22dea80*/ ulong ToUInt64(byte[] buffer, int index);
            static /*0x22deb38*/ float ToSingle(byte[] buffer, int index);
            static /*0x22dec48*/ double ToDouble(byte[] buffer, int index);
            static /*0x22dedf8*/ decimal ToDecimal(byte[] buffer, int index);
            static /*0x22df0f8*/ System.Guid ToGuid(byte[] buffer, int index);
            static /*0x22df3a0*/ void GetBytes(byte[] buffer, int index, short value);
            static /*0x22df474*/ void GetBytes(byte[] buffer, int index, ushort value);
            static /*0x22df548*/ void GetBytes(byte[] buffer, int index, int value);
            static /*0x22df68c*/ void GetBytes(byte[] buffer, int index, uint value);
            static /*0x22df7d0*/ void GetBytes(byte[] buffer, int index, long value);
            static /*0x22df9f4*/ void GetBytes(byte[] buffer, int index, ulong value);
            static /*0x22dfc18*/ void GetBytes(byte[] buffer, int index, float value);
            static /*0x22dfd70*/ void GetBytes(byte[] buffer, int index, double value);
            static /*0x22dffa8*/ void GetBytes(byte[] buffer, int index, decimal value);
            static /*0x22e0394*/ void GetBytes(byte[] buffer, int index, System.Guid value);

            struct SingleByteUnion
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x10*/ float Value;
            }

            struct DoubleByteUnion
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x10*/ double Value;
            }

            struct DecimalByteUnion
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x18*/ byte Byte8;
                /*0x19*/ byte Byte9;
                /*0x1a*/ byte Byte10;
                /*0x1b*/ byte Byte11;
                /*0x1c*/ byte Byte12;
                /*0x1d*/ byte Byte13;
                /*0x1e*/ byte Byte14;
                /*0x1f*/ byte Byte15;
                /*0x10*/ decimal Value;
            }

            struct GuidByteUnion
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x18*/ byte Byte8;
                /*0x19*/ byte Byte9;
                /*0x1a*/ byte Byte10;
                /*0x1b*/ byte Byte11;
                /*0x1c*/ byte Byte12;
                /*0x1d*/ byte Byte13;
                /*0x1e*/ byte Byte14;
                /*0x1f*/ byte Byte15;
                /*0x10*/ System.Guid Value;
            }
        }

        class RegisterFormatterAttribute : System.Attribute
        {
            /*0x10*/ System.Type <FormatterType>k__BackingField;
            /*0x18*/ System.Type <WeakFallback>k__BackingField;
            /*0x20*/ int <Priority>k__BackingField;

            /*0x22e0750*/ RegisterFormatterAttribute(System.Type formatterType, int priority);
            /*0x22e0780*/ RegisterFormatterAttribute(System.Type formatterType, System.Type weakFallback, int priority);
            /*0x22e0720*/ System.Type get_FormatterType();
            /*0x22e0728*/ void set_FormatterType(System.Type value);
            /*0x22e0730*/ System.Type get_WeakFallback();
            /*0x22e0738*/ void set_WeakFallback(System.Type value);
            /*0x22e0740*/ int get_Priority();
            /*0x22e0748*/ void set_Priority(int value);
        }

        class RegisterFormatterLocatorAttribute : System.Attribute
        {
            /*0x10*/ System.Type <FormatterLocatorType>k__BackingField;
            /*0x18*/ int <Priority>k__BackingField;

            /*0x22e07dc*/ RegisterFormatterLocatorAttribute(System.Type formatterLocatorType, int priority);
            /*0x22e07bc*/ System.Type get_FormatterLocatorType();
            /*0x22e07c4*/ void set_FormatterLocatorType(System.Type value);
            /*0x22e07cc*/ int get_Priority();
            /*0x22e07d4*/ void set_Priority(int value);
        }

        class SerializationAbortException : System.Exception
        {
            /*0x22d11fc*/ SerializationAbortException(string message);
            /*0x22e080c*/ SerializationAbortException(string message, System.Exception innerException);
        }

        class SerializationConfig
        {
            /*0x10*/ object LOCK;
            /*0x18*/ Sirenix.Serialization.ISerializationPolicy serializationPolicy;
            /*0x20*/ Sirenix.Serialization.DebugContext debugContext;
            /*0x28*/ bool AllowDeserializeInvalidData;

            /*0x22d743c*/ SerializationConfig();
            /*0x22cde48*/ Sirenix.Serialization.ISerializationPolicy get_SerializationPolicy();
            /*0x22e0c10*/ void set_SerializationPolicy(Sirenix.Serialization.ISerializationPolicy value);
            /*0x22ce17c*/ Sirenix.Serialization.DebugContext get_DebugContext();
            /*0x22e0d3c*/ void set_DebugContext(Sirenix.Serialization.DebugContext value);
            /*0x22d7afc*/ void ResetToDefault();
        }

        class DebugContext
        {
            /*0x10*/ object LOCK;
            /*0x18*/ Sirenix.Serialization.ILogger logger;
            /*0x20*/ Sirenix.Serialization.LoggingPolicy loggingPolicy;
            /*0x24*/ Sirenix.Serialization.ErrorHandlingPolicy errorHandlingPolicy;

            /*0x22e0cd4*/ DebugContext();
            /*0x22e0ecc*/ Sirenix.Serialization.ILogger get_Logger();
            /*0x22e1008*/ void set_Logger(Sirenix.Serialization.ILogger value);
            /*0x22e10cc*/ Sirenix.Serialization.LoggingPolicy get_LoggingPolicy();
            /*0x22e10e4*/ void set_LoggingPolicy(Sirenix.Serialization.LoggingPolicy value);
            /*0x22e1108*/ Sirenix.Serialization.ErrorHandlingPolicy get_ErrorHandlingPolicy();
            /*0x22e1120*/ void set_ErrorHandlingPolicy(Sirenix.Serialization.ErrorHandlingPolicy value);
            /*0x22ce418*/ void LogWarning(string message);
            /*0x22ce2b4*/ void LogError(string message);
            /*0x22ce97c*/ void LogException(System.Exception exception);
            /*0x22e0e00*/ void ResetToDefault();
        }

        class SerializationContext : Sirenix.Serialization.Utilities.ICacheNotificationReceiver
        {
            /*0x10*/ Sirenix.Serialization.SerializationConfig config;
            /*0x18*/ System.Collections.Generic.Dictionary<object, int> internalReferenceIdMap;
            /*0x20*/ System.Runtime.Serialization.StreamingContext streamingContext;
            /*0x30*/ System.Runtime.Serialization.IFormatterConverter formatterConverter;
            /*0x38*/ Sirenix.Serialization.TwoWaySerializationBinder binder;
            /*0x40*/ Sirenix.Serialization.IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField;
            /*0x48*/ Sirenix.Serialization.IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField;
            /*0x50*/ Sirenix.Serialization.IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField;

            /*0x22e1144*/ SerializationContext();
            /*0x22e12e0*/ SerializationContext(System.Runtime.Serialization.StreamingContext context);
            /*0x22e135c*/ SerializationContext(System.Runtime.Serialization.FormatterConverter formatterConverter);
            /*0x22e11b0*/ SerializationContext(System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.FormatterConverter formatterConverter);
            /*0x22d0dbc*/ Sirenix.Serialization.TwoWaySerializationBinder get_Binder();
            /*0x22e13d8*/ void set_Binder(Sirenix.Serialization.TwoWaySerializationBinder value);
            /*0x22e13e0*/ System.Runtime.Serialization.StreamingContext get_StreamingContext();
            /*0x22e13ec*/ System.Runtime.Serialization.IFormatterConverter get_FormatterConverter();
            /*0x22e13f4*/ Sirenix.Serialization.IExternalIndexReferenceResolver get_IndexReferenceResolver();
            /*0x22e13fc*/ void set_IndexReferenceResolver(Sirenix.Serialization.IExternalIndexReferenceResolver value);
            /*0x22e1404*/ Sirenix.Serialization.IExternalStringReferenceResolver get_StringReferenceResolver();
            /*0x22e140c*/ void set_StringReferenceResolver(Sirenix.Serialization.IExternalStringReferenceResolver value);
            /*0x22e1414*/ Sirenix.Serialization.IExternalGuidReferenceResolver get_GuidReferenceResolver();
            /*0x22e141c*/ void set_GuidReferenceResolver(Sirenix.Serialization.IExternalGuidReferenceResolver value);
            /*0x22ceea4*/ Sirenix.Serialization.SerializationConfig get_Config();
            /*0x22e1424*/ void set_Config(Sirenix.Serialization.SerializationConfig value);
            /*0x22e142c*/ bool TryGetInternalReferenceId(object reference, ref int id);
            /*0x22e1494*/ bool TryRegisterInternalReference(object reference, ref int id);
            /*0x22e1564*/ bool TryRegisterExternalReference(object obj, ref int index);
            /*0x22e1638*/ bool TryRegisterExternalReference(object obj, ref System.Guid guid);
            /*0x22e179c*/ bool TryRegisterExternalReference(object obj, ref string id);
            /*0x22e18cc*/ void ResetInternalReferences();
            /*0x22e136c*/ void ResetToDefault();
            /*0x22e191c*/ void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed();
            /*0x22e1920*/ void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed();
        }

        class SerializationPolicies
        {
            static /*0x0*/ object LOCK;
            static /*0x8*/ Sirenix.Serialization.ISerializationPolicy everythingPolicy;
            static /*0x10*/ Sirenix.Serialization.ISerializationPolicy unityPolicy;
            static /*0x18*/ Sirenix.Serialization.ISerializationPolicy strictPolicy;

            static /*0x22e1a4c*/ SerializationPolicies();
            static /*0x22e1924*/ bool TryGetByID(string name, ref Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22db940*/ Sirenix.Serialization.ISerializationPolicy get_Everything();
            static /*0x22e087c*/ Sirenix.Serialization.ISerializationPolicy get_Unity();
            static /*0x22d808c*/ Sirenix.Serialization.ISerializationPolicy get_Strict();

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.SerializationPolicies.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MemberInfo, bool> <>9__6_0;
                static /*0x10*/ System.Func<System.Reflection.MemberInfo, bool> <>9__10_0;

                static /*0x22e1ac4*/ <>c();
                /*0x22e1b28*/ <>c();
                /*0x22e1b30*/ bool <get_Everything>b__6_0(System.Reflection.MemberInfo member);
                /*0x22e1c00*/ bool <get_Strict>b__10_0(System.Reflection.MemberInfo member);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ System.Type tupleInterface;

                /*0x22e1a44*/ <>c__DisplayClass8_0();
                /*0x22e1e84*/ bool <get_Unity>b__0(System.Reflection.MemberInfo member);
            }
        }

        class SerializationUtility
        {
            static /*0x22e21e8*/ Sirenix.Serialization.IDataWriter CreateWriter(System.IO.Stream stream, Sirenix.Serialization.SerializationContext context, Sirenix.Serialization.DataFormat format);
            static /*0x22e23d4*/ Sirenix.Serialization.IDataReader CreateReader(System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context, Sirenix.Serialization.DataFormat format);
            static /*0x22e25bc*/ Sirenix.Serialization.IDataWriter GetCachedWriter(ref System.IDisposable cache, Sirenix.Serialization.DataFormat format, System.IO.Stream stream, Sirenix.Serialization.SerializationContext context);
            static /*0x22e27c8*/ Sirenix.Serialization.IDataReader GetCachedReader(ref System.IDisposable cache, Sirenix.Serialization.DataFormat format, System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context);
            static /*0x22e29d4*/ void SerializeValueWeak(object value, Sirenix.Serialization.IDataWriter writer);
            static /*0x22e2b80*/ void SerializeValueWeak(object value, Sirenix.Serialization.IDataWriter writer, ref System.Collections.Generic.List<UnityEngine.Object> unityObjects);
            static void SerializeValue<T>(T value, Sirenix.Serialization.IDataWriter writer);
            static void SerializeValue<T>(T value, Sirenix.Serialization.IDataWriter writer, ref System.Collections.Generic.List<UnityEngine.Object> unityObjects);
            static /*0x22e2e98*/ void SerializeValueWeak(object value, System.IO.Stream stream, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.SerializationContext context);
            static /*0x22e3268*/ void SerializeValueWeak(object value, System.IO.Stream stream, Sirenix.Serialization.DataFormat format, ref System.Collections.Generic.List<UnityEngine.Object> unityObjects, Sirenix.Serialization.SerializationContext context);
            static void SerializeValue<T>(T value, System.IO.Stream stream, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.SerializationContext context);
            static void SerializeValue<T>(T value, System.IO.Stream stream, Sirenix.Serialization.DataFormat format, ref System.Collections.Generic.List<UnityEngine.Object> unityObjects, Sirenix.Serialization.SerializationContext context);
            static /*0x22e3644*/ byte[] SerializeValueWeak(object value, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.SerializationContext context);
            static /*0x22e384c*/ byte[] SerializeValueWeak(object value, Sirenix.Serialization.DataFormat format, ref System.Collections.Generic.List<UnityEngine.Object> unityObjects);
            static byte[] SerializeValue<T>(T value, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.SerializationContext context);
            static byte[] SerializeValue<T>(T value, Sirenix.Serialization.DataFormat format, ref System.Collections.Generic.List<UnityEngine.Object> unityObjects, Sirenix.Serialization.SerializationContext context);
            static /*0x22e3a58*/ object DeserializeValueWeak(Sirenix.Serialization.IDataReader reader);
            static /*0x22e3b1c*/ object DeserializeValueWeak(Sirenix.Serialization.IDataReader reader, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            static T DeserializeValue<T>(Sirenix.Serialization.IDataReader reader);
            static T DeserializeValue<T>(Sirenix.Serialization.IDataReader reader, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            static /*0x22e3e24*/ object DeserializeValueWeak(System.IO.Stream stream, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.DeserializationContext context);
            static /*0x22e4208*/ object DeserializeValueWeak(System.IO.Stream stream, Sirenix.Serialization.DataFormat format, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DeserializationContext context);
            static T DeserializeValue<T>(System.IO.Stream stream, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.DeserializationContext context);
            static T DeserializeValue<T>(System.IO.Stream stream, Sirenix.Serialization.DataFormat format, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DeserializationContext context);
            static /*0x22e45f8*/ object DeserializeValueWeak(byte[] bytes, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.DeserializationContext context);
            static /*0x22e47c4*/ object DeserializeValueWeak(byte[] bytes, Sirenix.Serialization.DataFormat format, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            static T DeserializeValue<T>(byte[] bytes, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.DeserializationContext context);
            static T DeserializeValue<T>(byte[] bytes, Sirenix.Serialization.DataFormat format, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DeserializationContext context);
            static /*0x22e4994*/ object CreateCopy(object obj);
        }

        class TwoWaySerializationBinder
        {
            static /*0x0*/ Sirenix.Serialization.TwoWaySerializationBinder Default;

            static /*0x22e51fc*/ TwoWaySerializationBinder();
            /*0x22d6f8c*/ TwoWaySerializationBinder();
            string BindToName(System.Type type, Sirenix.Serialization.DebugContext debugContext);
            System.Type BindToType(string typeName, Sirenix.Serialization.DebugContext debugContext);
            bool ContainsType(string typeName);
        }

        class AnySerializer : Sirenix.Serialization.Serializer
        {
            static /*0x0*/ Sirenix.Serialization.ISerializationPolicy UnityPolicy;
            static /*0x8*/ Sirenix.Serialization.ISerializationPolicy StrictPolicy;
            static /*0x10*/ Sirenix.Serialization.ISerializationPolicy EverythingPolicy;
            /*0x10*/ System.Type SerializedType;
            /*0x18*/ bool IsEnum;
            /*0x19*/ bool IsValueType;
            /*0x1a*/ bool MayBeBoxedValueType;
            /*0x1b*/ bool IsAbstract;
            /*0x1c*/ bool IsNullable;
            /*0x1d*/ bool AllowDeserializeInvalidData;
            /*0x20*/ Sirenix.Serialization.IFormatter UnityPolicyFormatter;
            /*0x28*/ Sirenix.Serialization.IFormatter StrictPolicyFormatter;
            /*0x30*/ Sirenix.Serialization.IFormatter EverythingPolicyFormatter;
            /*0x38*/ System.Collections.Generic.Dictionary<Sirenix.Serialization.ISerializationPolicy, Sirenix.Serialization.IFormatter> FormattersByPolicy;
            /*0x40*/ object FormattersByPolicy_LOCK;

            static /*0x22ea0b8*/ AnySerializer();
            /*0x22e5270*/ AnySerializer(System.Type serializedType);
            /*0x22e560c*/ object ReadValueWeak(Sirenix.Serialization.IDataReader reader);
            /*0x22e91e0*/ void WriteValueWeak(string name, object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22e8ecc*/ Sirenix.Serialization.IFormatter GetBaseFormatter(Sirenix.Serialization.ISerializationPolicy serializationPolicy);
        }

        class BooleanSerializer : Sirenix.Serialization.Serializer<bool>
        {
            /*0x22ea6d4*/ BooleanSerializer();
            /*0x22ea148*/ bool ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ea61c*/ void WriteValue(string name, bool value, Sirenix.Serialization.IDataWriter writer);
        }

        class ByteSerializer : Sirenix.Serialization.Serializer<byte>
        {
            /*0x22eaca0*/ ByteSerializer();
            /*0x22ea71c*/ byte ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22eabe8*/ void WriteValue(string name, byte value, Sirenix.Serialization.IDataWriter writer);
        }

        class CharSerializer : Sirenix.Serialization.Serializer<char>
        {
            /*0x22eb26c*/ CharSerializer();
            /*0x22eace8*/ char ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22eb1b4*/ void WriteValue(string name, char value, Sirenix.Serialization.IDataWriter writer);
        }

        class ComplexTypeSerializer<T> : Sirenix.Serialization.Serializer<T>
        {
            static /*0x0*/ bool ComplexTypeMayBeBoxedValueType;
            static /*0x0*/ bool ComplexTypeIsAbstract;
            static /*0x0*/ bool ComplexTypeIsNullable;
            static /*0x0*/ bool ComplexTypeIsValueType;
            static /*0x0*/ System.Type TypeOf_T;
            static /*0x0*/ bool AllowDeserializeInvalidDataForT;
            static /*0x0*/ System.Collections.Generic.Dictionary<Sirenix.Serialization.ISerializationPolicy, Sirenix.Serialization.IFormatter<T>> FormattersByPolicy;
            static /*0x0*/ object FormattersByPolicy_LOCK;
            static /*0x0*/ Sirenix.Serialization.ISerializationPolicy UnityPolicy;
            static /*0x0*/ Sirenix.Serialization.ISerializationPolicy StrictPolicy;
            static /*0x0*/ Sirenix.Serialization.ISerializationPolicy EverythingPolicy;
            static /*0x0*/ Sirenix.Serialization.IFormatter<T> UnityPolicyFormatter;
            static /*0x0*/ Sirenix.Serialization.IFormatter<T> StrictPolicyFormatter;
            static /*0x0*/ Sirenix.Serialization.IFormatter<T> EverythingPolicyFormatter;

            static ComplexTypeSerializer();
            static Sirenix.Serialization.IFormatter<T> GetBaseFormatter(Sirenix.Serialization.ISerializationPolicy serializationPolicy);
            ComplexTypeSerializer();
            T ReadValue(Sirenix.Serialization.IDataReader reader);
            void WriteValue(string name, T value, Sirenix.Serialization.IDataWriter writer);
        }

        class DecimalSerializer : Sirenix.Serialization.Serializer<decimal>
        {
            /*0x22eb8a0*/ DecimalSerializer();
            /*0x22eb2b4*/ decimal ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22eb7e0*/ void WriteValue(string name, decimal value, Sirenix.Serialization.IDataWriter writer);
        }

        class DoubleSerializer : Sirenix.Serialization.Serializer<double>
        {
            /*0x22ebef4*/ DoubleSerializer();
            /*0x22eb8e8*/ double ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ebe3c*/ void WriteValue(string name, double value, Sirenix.Serialization.IDataWriter writer);
        }

        class EnumSerializer<T> : Sirenix.Serialization.Serializer<T>
        {
            static EnumSerializer();
            EnumSerializer();
            T ReadValue(Sirenix.Serialization.IDataReader reader);
            void WriteValue(string name, T value, Sirenix.Serialization.IDataWriter writer);
        }

        class GuidSerializer : Sirenix.Serialization.Serializer<System.Guid>
        {
            /*0x22ec4cc*/ GuidSerializer();
            /*0x22ebf3c*/ System.Guid ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ec40c*/ void WriteValue(string name, System.Guid value, Sirenix.Serialization.IDataWriter writer);
        }

        class Int16Serializer : Sirenix.Serialization.Serializer<short>
        {
            /*0x22eca98*/ Int16Serializer();
            /*0x22ec514*/ short ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ec9e0*/ void WriteValue(string name, short value, Sirenix.Serialization.IDataWriter writer);
        }

        class Int32Serializer : Sirenix.Serialization.Serializer<int>
        {
            /*0x22ed064*/ Int32Serializer();
            /*0x22ecae0*/ int ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ecfac*/ void WriteValue(string name, int value, Sirenix.Serialization.IDataWriter writer);
        }

        class Int64Serializer : Sirenix.Serialization.Serializer<long>
        {
            /*0x22ed62c*/ Int64Serializer();
            /*0x22ed0ac*/ long ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ed574*/ void WriteValue(string name, long value, Sirenix.Serialization.IDataWriter writer);
        }

        class IntPtrSerializer : Sirenix.Serialization.Serializer<nint>
        {
            /*0x22edc18*/ IntPtrSerializer();
            /*0x22ed674*/ nint ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22edb50*/ void WriteValue(string name, nint value, Sirenix.Serialization.IDataWriter writer);
        }

        class SByteSerializer : Sirenix.Serialization.Serializer<sbyte>
        {
            /*0x22ee1e4*/ SByteSerializer();
            /*0x22edc60*/ sbyte ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ee12c*/ void WriteValue(string name, sbyte value, Sirenix.Serialization.IDataWriter writer);
        }

        class Serializer
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> PrimitiveReaderWriterTypes;
            static /*0x8*/ object LOCK;
            static /*0x10*/ System.Collections.Generic.Dictionary<System.Type, Sirenix.Serialization.Serializer> Weak_ReaderWriterCache;
            static /*0x18*/ System.Collections.Generic.Dictionary<System.Type, Sirenix.Serialization.Serializer> Strong_ReaderWriterCache;

            static /*0x22eec60*/ Serializer();
            static /*0x22ee22c*/ void FireOnSerializedType(System.Type type);
            static /*0x22e2ac8*/ Sirenix.Serialization.Serializer GetForValue(object value);
            static Sirenix.Serialization.Serializer<T> Get<T>();
            static /*0x22ce6cc*/ Sirenix.Serialization.Serializer Get(System.Type type);
            static /*0x22ee230*/ Sirenix.Serialization.Serializer Get(System.Type type, bool allowWeakFallback);
            static /*0x22ee484*/ Sirenix.Serialization.Serializer Create(System.Type type, bool allowWeakfallback);
            static /*0x22eea68*/ void LogAOTError(System.Type type, System.ExecutionEngineException ex);
            /*0x22e5604*/ Serializer();
            object ReadValueWeak(Sirenix.Serialization.IDataReader reader);
            /*0x22d2444*/ void WriteValueWeak(object value, Sirenix.Serialization.IDataWriter writer);
            void WriteValueWeak(string name, object value, Sirenix.Serialization.IDataWriter writer);
        }

        class Serializer<T> : Sirenix.Serialization.Serializer
        {
            static void FireOnSerializedType();
            Serializer();
            object ReadValueWeak(Sirenix.Serialization.IDataReader reader);
            void WriteValueWeak(string name, object value, Sirenix.Serialization.IDataWriter writer);
            T ReadValue(Sirenix.Serialization.IDataReader reader);
            void WriteValue(T value, Sirenix.Serialization.IDataWriter writer);
            void WriteValue(string name, T value, Sirenix.Serialization.IDataWriter writer);
        }

        class SingleSerializer : Sirenix.Serialization.Serializer<float>
        {
            /*0x22efa78*/ SingleSerializer();
            /*0x22ef450*/ float ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22ef9c0*/ void WriteValue(string name, float value, Sirenix.Serialization.IDataWriter writer);
        }

        class StringSerializer : Sirenix.Serialization.Serializer<string>
        {
            /*0x22f0280*/ StringSerializer();
            /*0x22efac0*/ string ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22f0164*/ void WriteValue(string name, string value, Sirenix.Serialization.IDataWriter writer);
        }

        class UInt16Serializer : Sirenix.Serialization.Serializer<ushort>
        {
            /*0x22f0864*/ UInt16Serializer();
            /*0x22f02c8*/ ushort ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22f07ac*/ void WriteValue(string name, ushort value, Sirenix.Serialization.IDataWriter writer);
        }

        class UInt32Serializer : Sirenix.Serialization.Serializer<uint>
        {
            /*0x22f0e48*/ UInt32Serializer();
            /*0x22f08ac*/ uint ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22f0d90*/ void WriteValue(string name, uint value, Sirenix.Serialization.IDataWriter writer);
        }

        class UInt64Serializer : Sirenix.Serialization.Serializer<ulong>
        {
            /*0x22f1428*/ UInt64Serializer();
            /*0x22f0e90*/ ulong ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22f1370*/ void WriteValue(string name, ulong value, Sirenix.Serialization.IDataWriter writer);
        }

        class UIntPtrSerializer : Sirenix.Serialization.Serializer<nuint>
        {
            /*0x22f1a50*/ UIntPtrSerializer();
            /*0x22f1470*/ nuint ReadValue(Sirenix.Serialization.IDataReader reader);
            /*0x22f1964*/ void WriteValue(string name, nuint value, Sirenix.Serialization.IDataWriter writer);
        }

        class BaseDictionaryKeyPathProvider<T> : Sirenix.Serialization.IDictionaryKeyPathProvider<T>, Sirenix.Serialization.IDictionaryKeyPathProvider, System.Collections.Generic.IComparer<T>
        {
            BaseDictionaryKeyPathProvider();
            string get_ProviderID();
            T GetKeyFromPathString(string pathStr);
            string GetPathStringFromKey(T key);
            int Compare(T x, T y);
            int Sirenix.Serialization.IDictionaryKeyPathProvider.Compare(object x, object y);
            object Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString(string pathStr);
            string Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey(object key);
        }

        class DictionaryKeyUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, bool> GetSupportedDictionaryKeyTypesResults;
            static /*0x8*/ System.Collections.Generic.HashSet<System.Type> BaseSupportedDictionaryKeyTypes;
            static /*0x10*/ System.Collections.Generic.HashSet<char> AllowedSpecialKeyStrChars;
            static /*0x18*/ System.Collections.Generic.Dictionary<System.Type, Sirenix.Serialization.IDictionaryKeyPathProvider> TypeToKeyPathProviders;
            static /*0x20*/ System.Collections.Generic.Dictionary<string, Sirenix.Serialization.IDictionaryKeyPathProvider> IDToKeyPathProviders;
            static /*0x28*/ System.Collections.Generic.Dictionary<Sirenix.Serialization.IDictionaryKeyPathProvider, string> ProviderToID;
            static /*0x30*/ System.Collections.Generic.Dictionary<object, string> ObjectsToTempKeys;
            static /*0x38*/ System.Collections.Generic.Dictionary<string, object> TempKeysToObjects;
            static /*0x40*/ long tempKeyCounter;

            static /*0x22f1a98*/ DictionaryKeyUtility();
            static /*0x22f3a78*/ void LogInvalidKeyPathProvider(System.Type type, System.Reflection.Assembly assembly, string reason);
            static /*0x22f4300*/ System.Collections.Generic.IEnumerable<System.Type> GetPersistentPathKeyTypes();
            static /*0x22f43a4*/ bool KeyTypeSupportsPersistentPaths(System.Type type);
            static /*0x22f4490*/ bool PrivateIsSupportedDictionaryKeyType(System.Type type);
            static /*0x22f4580*/ string GetDictionaryKeyString(object key);
            static /*0x22f5a78*/ object GetDictionaryKeyValue(string keyStr, System.Type expectedType);
            static /*0x22f6600*/ string FromTo(string str, int from, int to);

            class UnityObjectKeyComparer<T> : System.Collections.Generic.IComparer<T>
            {
                UnityObjectKeyComparer();
                int Compare(T x, T y);
            }

            class FallbackKeyComparer<T> : System.Collections.Generic.IComparer<T>
            {
                FallbackKeyComparer();
                int Compare(T x, T y);
            }

            class KeyComparer<T> : System.Collections.Generic.IComparer<T>
            {
                static /*0x0*/ Sirenix.Serialization.DictionaryKeyUtility.KeyComparer<T> Default;
                /*0x0*/ System.Collections.Generic.IComparer<T> actualComparer;

                static KeyComparer();
                KeyComparer();
                int Compare(T x, T y);
            }

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.DictionaryKeyUtility.<> <>9;

                static /*0x22f6618*/ <>c();
                /*0x22f667c*/ <>c();
                /*0x22f6684*/ System.Collections.Generic.IEnumerable<<>f__AnonymousType0<System.Reflection.Assembly, Sirenix.Serialization.RegisterDictionaryKeyPathProviderAttribute>> <.cctor>b__12_0(System.Reflection.Assembly ass);
                /*0x22f6898*/ bool <.cctor>b__12_1(<>f__AnonymousType0<System.Reflection.Assembly, Sirenix.Serialization.RegisterDictionaryKeyPathProviderAttribute> n);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ System.Reflection.Assembly ass;

                /*0x22f67e0*/ <>c__DisplayClass12_0();
                /*0x22f6914*/ <>f__AnonymousType0<System.Reflection.Assembly, Sirenix.Serialization.RegisterDictionaryKeyPathProviderAttribute> <.cctor>b__2(object attr);
            }

            class <GetPersistentPathKeyTypes>d__14 : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Type <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Collections.Generic.HashSet.Enumerator<System.Type> <>7__wrap1;
                /*0x40*/ System.Collections.Generic.Dictionary.KeyCollection.Enumerator<System.Type, Sirenix.Serialization.IDictionaryKeyPathProvider> <>7__wrap2;

                /*0x22f4370*/ <GetPersistentPathKeyTypes>d__14(int <>1__state);
                /*0x22f69d4*/ void System.IDisposable.Dispose();
                /*0x22f6a08*/ bool MoveNext();
                /*0x22f6cb8*/ void <>m__Finally1();
                /*0x22f6d08*/ void <>m__Finally2();
                /*0x22f6d58*/ System.Type System.Collections.Generic.IEnumerator<System.Type>.get_Current();
                /*0x22f6d60*/ void System.Collections.IEnumerator.Reset();
                /*0x22f6da0*/ object System.Collections.IEnumerator.get_Current();
                /*0x22f6da8*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                /*0x22f6e40*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        interface IDictionaryKeyPathProvider
        {
            string get_ProviderID();
            string GetPathStringFromKey(object key);
            object GetKeyFromPathString(string pathStr);
            int Compare(object x, object y);
        }

        interface IDictionaryKeyPathProvider<T> : Sirenix.Serialization.IDictionaryKeyPathProvider
        {
            string GetPathStringFromKey(T key);
            T GetKeyFromPathString(string pathStr);
            int Compare(T x, T y);
        }

        class RegisterDictionaryKeyPathProviderAttribute : System.Attribute
        {
            /*0x10*/ System.Type ProviderType;

            /*0x22f6e44*/ RegisterDictionaryKeyPathProviderAttribute(System.Type providerType);
        }

        class Vector2DictionaryKeyPathProvider : Sirenix.Serialization.BaseDictionaryKeyPathProvider<UnityEngine.Vector2>
        {
            /*0x22f71c0*/ Vector2DictionaryKeyPathProvider();
            /*0x22f6e6c*/ string get_ProviderID();
            /*0x22f6eac*/ int Compare(UnityEngine.Vector2 x, UnityEngine.Vector2 y);
            /*0x22f6ef0*/ UnityEngine.Vector2 GetKeyFromPathString(string pathStr);
            /*0x22f6fa0*/ string GetPathStringFromKey(UnityEngine.Vector2 key);
        }

        class Vector3DictionaryKeyPathProvider : Sirenix.Serialization.BaseDictionaryKeyPathProvider<UnityEngine.Vector3>
        {
            /*0x22f7668*/ Vector3DictionaryKeyPathProvider();
            /*0x22f7208*/ string get_ProviderID();
            /*0x22f7248*/ int Compare(UnityEngine.Vector3 x, UnityEngine.Vector3 y);
            /*0x22f72b0*/ UnityEngine.Vector3 GetKeyFromPathString(string pathStr);
            /*0x22f73bc*/ string GetPathStringFromKey(UnityEngine.Vector3 key);
        }

        class Vector4DictionaryKeyPathProvider : Sirenix.Serialization.BaseDictionaryKeyPathProvider<UnityEngine.Vector4>
        {
            /*0x22f7c0c*/ Vector4DictionaryKeyPathProvider();
            /*0x22f76b0*/ string get_ProviderID();
            /*0x22f76f0*/ int Compare(UnityEngine.Vector4 x, UnityEngine.Vector4 y);
            /*0x22f7778*/ UnityEngine.Vector4 GetKeyFromPathString(string pathStr);
            /*0x22f78e8*/ string GetPathStringFromKey(UnityEngine.Vector4 key);
        }

        class AnimationCurveFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.AnimationCurve>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<UnityEngine.Keyframe[]> KeyframeSerializer;
            static /*0x8*/ Sirenix.Serialization.Serializer<UnityEngine.WrapMode> WrapModeSerializer;

            static /*0x22f7f0c*/ AnimationCurveFormatter();
            /*0x22f7ea0*/ AnimationCurveFormatter();
            /*0x22f7c54*/ UnityEngine.AnimationCurve GetUninitializedObject();
            /*0x22f7c5c*/ void Read(ref UnityEngine.AnimationCurve value, Sirenix.Serialization.IDataReader reader);
            /*0x22f7d7c*/ void Write(ref UnityEngine.AnimationCurve value, Sirenix.Serialization.IDataWriter writer);
        }

        class BoundsFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Bounds>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<UnityEngine.Vector3> Vector3Serializer;

            static /*0x22f81a4*/ BoundsFormatter();
            /*0x22f8138*/ BoundsFormatter();
            /*0x22f7fbc*/ void Read(ref UnityEngine.Bounds value, Sirenix.Serialization.IDataReader reader);
            /*0x22f8070*/ void Write(ref UnityEngine.Bounds value, Sirenix.Serialization.IDataWriter writer);
        }

        class Color32Formatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Color32>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<byte> ByteSerializer;

            static /*0x22f8478*/ Color32Formatter();
            /*0x22f840c*/ Color32Formatter();
            /*0x22f822c*/ void Read(ref UnityEngine.Color32 value, Sirenix.Serialization.IDataReader reader);
            /*0x22f831c*/ void Write(ref UnityEngine.Color32 value, Sirenix.Serialization.IDataWriter writer);
        }

        class ColorBlockFormatterLocator : Sirenix.Serialization.IFormatterLocator
        {
            /*0x22f8924*/ ColorBlockFormatterLocator();
            /*0x22f8500*/ bool TryGetFormatter(System.Type type, Sirenix.Serialization.FormatterLocationStep step, Sirenix.Serialization.ISerializationPolicy policy, bool allowWeakFallbackFormatters, ref Sirenix.Serialization.IFormatter formatter);
        }

        class ColorBlockFormatter<T> : Sirenix.Serialization.MinimalBaseFormatter<T>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;
            static /*0x0*/ Sirenix.Serialization.Serializer<UnityEngine.Color> ColorSerializer;
            static /*0x0*/ System.Reflection.PropertyInfo normalColor;
            static /*0x0*/ System.Reflection.PropertyInfo highlightedColor;
            static /*0x0*/ System.Reflection.PropertyInfo pressedColor;
            static /*0x0*/ System.Reflection.PropertyInfo disabledColor;
            static /*0x0*/ System.Reflection.PropertyInfo colorMultiplier;
            static /*0x0*/ System.Reflection.PropertyInfo fadeDuration;

            static ColorBlockFormatter();
            ColorBlockFormatter();
            void Read(ref T value, Sirenix.Serialization.IDataReader reader);
            void Write(ref T value, Sirenix.Serialization.IDataWriter writer);
        }

        class WeakColorBlockFormatter : Sirenix.Serialization.WeakBaseFormatter
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;
            static /*0x8*/ Sirenix.Serialization.Serializer<UnityEngine.Color> ColorSerializer;
            /*0x40*/ System.Reflection.PropertyInfo normalColor;
            /*0x48*/ System.Reflection.PropertyInfo highlightedColor;
            /*0x50*/ System.Reflection.PropertyInfo pressedColor;
            /*0x58*/ System.Reflection.PropertyInfo disabledColor;
            /*0x60*/ System.Reflection.PropertyInfo colorMultiplier;
            /*0x68*/ System.Reflection.PropertyInfo fadeDuration;

            static /*0x22f8f28*/ WeakColorBlockFormatter();
            /*0x22f87dc*/ WeakColorBlockFormatter(System.Type colorBlockType);
            /*0x22f892c*/ void DeserializeImplementation(ref object value, Sirenix.Serialization.IDataReader reader);
            /*0x22f8c00*/ void SerializeImplementation(ref object value, Sirenix.Serialization.IDataWriter writer);
        }

        class ColorFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Color>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22f9224*/ ColorFormatter();
            /*0x22f91b8*/ ColorFormatter();
            /*0x22f8fd8*/ void Read(ref UnityEngine.Color value, Sirenix.Serialization.IDataReader reader);
            /*0x22f90c8*/ void Write(ref UnityEngine.Color value, Sirenix.Serialization.IDataWriter writer);
        }

        class CoroutineFormatter : Sirenix.Serialization.IFormatter<UnityEngine.Coroutine>, Sirenix.Serialization.IFormatter
        {
            /*0x22f9330*/ CoroutineFormatter();
            /*0x22f92ac*/ System.Type get_SerializedType();
            /*0x22f9318*/ object Sirenix.Serialization.IFormatter.Deserialize(Sirenix.Serialization.IDataReader reader);
            /*0x22f9320*/ UnityEngine.Coroutine Deserialize(Sirenix.Serialization.IDataReader reader);
            /*0x22f9328*/ void Serialize(object value, Sirenix.Serialization.IDataWriter writer);
            /*0x22f932c*/ void Serialize(UnityEngine.Coroutine value, Sirenix.Serialization.IDataWriter writer);
        }

        class GradientAlphaKeyFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.GradientAlphaKey>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22f94fc*/ GradientAlphaKeyFormatter();
            /*0x22f9490*/ GradientAlphaKeyFormatter();
            /*0x22f9338*/ void Read(ref UnityEngine.GradientAlphaKey value, Sirenix.Serialization.IDataReader reader);
            /*0x22f93e0*/ void Write(ref UnityEngine.GradientAlphaKey value, Sirenix.Serialization.IDataWriter writer);
        }

        class GradientColorKeyFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.GradientColorKey>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<UnityEngine.Color> ColorSerializer;
            static /*0x8*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22f9764*/ GradientColorKeyFormatter();
            /*0x22f96f8*/ GradientColorKeyFormatter();
            /*0x22f9584*/ void Read(ref UnityEngine.GradientColorKey value, Sirenix.Serialization.IDataReader reader);
            /*0x22f9630*/ void Write(ref UnityEngine.GradientColorKey value, Sirenix.Serialization.IDataWriter writer);
        }

        class GradientFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Gradient>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<UnityEngine.GradientAlphaKey[]> AlphaKeysSerializer;
            static /*0x8*/ Sirenix.Serialization.Serializer<UnityEngine.GradientColorKey[]> ColorKeysSerializer;
            static /*0x10*/ System.Reflection.PropertyInfo ModeProperty;
            static /*0x18*/ Sirenix.Serialization.Serializer<object> EnumSerializer;

            static /*0x22f9f20*/ GradientFormatter();
            /*0x22f9eb4*/ GradientFormatter();
            /*0x22f9814*/ UnityEngine.Gradient GetUninitializedObject();
            /*0x22f9870*/ void Read(ref UnityEngine.Gradient value, Sirenix.Serialization.IDataReader reader);
            /*0x22f9c00*/ void Write(ref UnityEngine.Gradient value, Sirenix.Serialization.IDataWriter writer);
        }

        class KeyframeFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Keyframe>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;
            static /*0x8*/ Sirenix.Serialization.Serializer<int> IntSerializer;
            static /*0x10*/ bool Is_In_2018_1_Or_Above;
            static /*0x18*/ Sirenix.Serialization.IFormatter<UnityEngine.Keyframe> Formatter;

            static /*0x22fa0b0*/ KeyframeFormatter();
            /*0x22faa30*/ KeyframeFormatter();
            /*0x22fa364*/ void Read(ref UnityEngine.Keyframe value, Sirenix.Serialization.IDataReader reader);
            /*0x22fa738*/ void Write(ref UnityEngine.Keyframe value, Sirenix.Serialization.IDataWriter writer);
        }

        class LayerMaskFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.LayerMask>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<int> IntSerializer;

            static /*0x22fac34*/ LayerMaskFormatter();
            /*0x22fabc8*/ LayerMaskFormatter();
            /*0x22faa9c*/ void Read(ref UnityEngine.LayerMask value, Sirenix.Serialization.IDataReader reader);
            /*0x22fab28*/ void Write(ref UnityEngine.LayerMask value, Sirenix.Serialization.IDataWriter writer);
        }

        class QuaternionFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Quaternion>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22faf08*/ QuaternionFormatter();
            /*0x22fae9c*/ QuaternionFormatter();
            /*0x22facbc*/ void Read(ref UnityEngine.Quaternion value, Sirenix.Serialization.IDataReader reader);
            /*0x22fadac*/ void Write(ref UnityEngine.Quaternion value, Sirenix.Serialization.IDataWriter writer);
        }

        class RectFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Rect>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22fb228*/ RectFormatter();
            /*0x22fb1bc*/ RectFormatter();
            /*0x22faf90*/ void Read(ref UnityEngine.Rect value, Sirenix.Serialization.IDataReader reader);
            /*0x22fb09c*/ void Write(ref UnityEngine.Rect value, Sirenix.Serialization.IDataWriter writer);
        }

        class UnityEventFormatter<T> : Sirenix.Serialization.ReflectionFormatter<T>
        {
            UnityEventFormatter();
            T GetUninitializedObject();
        }

        class WeakUnityEventFormatter : Sirenix.Serialization.WeakReflectionFormatter
        {
            /*0x22fb2b0*/ WeakUnityEventFormatter(System.Type serializedType);
            /*0x22fb2b8*/ object GetUninitializedObject();
        }

        class Vector2Formatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Vector2>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22fb488*/ Vector2Formatter();
            /*0x22fb41c*/ Vector2Formatter();
            /*0x22fb2c4*/ void Read(ref UnityEngine.Vector2 value, Sirenix.Serialization.IDataReader reader);
            /*0x22fb36c*/ void Write(ref UnityEngine.Vector2 value, Sirenix.Serialization.IDataWriter writer);
        }

        class Vector3Formatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Vector3>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22fb718*/ Vector3Formatter();
            /*0x22fb6ac*/ Vector3Formatter();
            /*0x22fb510*/ void Read(ref UnityEngine.Vector3 value, Sirenix.Serialization.IDataReader reader);
            /*0x22fb5dc*/ void Write(ref UnityEngine.Vector3 value, Sirenix.Serialization.IDataWriter writer);
        }

        class Vector4Formatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Vector4>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<float> FloatSerializer;

            static /*0x22fb9ec*/ Vector4Formatter();
            /*0x22fb980*/ Vector4Formatter();
            /*0x22fb7a0*/ void Read(ref UnityEngine.Vector4 value, Sirenix.Serialization.IDataReader reader);
            /*0x22fb890*/ void Write(ref UnityEngine.Vector4 value, Sirenix.Serialization.IDataWriter writer);
        }

        class Vector2IntFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Vector2Int>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<int> Serializer;

            static /*0x22fbc38*/ Vector2IntFormatter();
            /*0x22fbbcc*/ Vector2IntFormatter();
            /*0x22fba74*/ void Read(ref UnityEngine.Vector2Int value, Sirenix.Serialization.IDataReader reader);
            /*0x22fbb1c*/ void Write(ref UnityEngine.Vector2Int value, Sirenix.Serialization.IDataWriter writer);
        }

        class Vector3IntFormatter : Sirenix.Serialization.MinimalBaseFormatter<UnityEngine.Vector3Int>
        {
            static /*0x0*/ Sirenix.Serialization.Serializer<int> Serializer;

            static /*0x22fbec8*/ Vector3IntFormatter();
            /*0x22fbe5c*/ Vector3IntFormatter();
            /*0x22fbcc0*/ void Read(ref UnityEngine.Vector3Int value, Sirenix.Serialization.IDataReader reader);
            /*0x22fbd8c*/ void Write(ref UnityEngine.Vector3Int value, Sirenix.Serialization.IDataWriter writer);
        }

        interface IOverridesSerializationFormat
        {
            Sirenix.Serialization.DataFormat GetFormatToSerializeAs(bool isPlayer);
        }

        interface IOverridesSerializationPolicy
        {
            Sirenix.Serialization.ISerializationPolicy get_SerializationPolicy();
            bool get_OdinSerializesUnityFields();
        }

        interface ISupportsPrefabSerialization
        {
            Sirenix.Serialization.SerializationData get_SerializationData();
            void set_SerializationData(Sirenix.Serialization.SerializationData value);
        }

        struct SerializationData
        {
            static string PrefabModificationsReferencedUnityObjectsFieldName = "PrefabModificationsReferencedUnityObjects";
            static string PrefabModificationsFieldName = "PrefabModifications";
            static string PrefabFieldName = "Prefab";
            /*0x10*/ Sirenix.Serialization.DataFormat SerializedFormat;
            /*0x18*/ byte[] SerializedBytes;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Object> ReferencedUnityObjects;
            /*0x28*/ string SerializedBytesString;
            /*0x30*/ UnityEngine.Object Prefab;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Object> PrefabModificationsReferencedUnityObjects;
            /*0x40*/ System.Collections.Generic.List<string> PrefabModifications;
            /*0x48*/ System.Collections.Generic.List<Sirenix.Serialization.SerializationNode> SerializationNodes;

            /*0x22fbf50*/ bool get_HasEditorData();
            /*0x22fc108*/ bool get_ContainsData();
            /*0x22fc138*/ void Reset();
        }

        class UnityReferenceResolver : Sirenix.Serialization.IExternalIndexReferenceResolver, Sirenix.Serialization.Utilities.ICacheNotificationReceiver
        {
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Object, int> referenceIndexMapping;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects;

            /*0x22fc2e8*/ UnityReferenceResolver();
            /*0x22fc3ec*/ UnityReferenceResolver(System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            /*0x22fc644*/ System.Collections.Generic.List<UnityEngine.Object> GetReferencedUnityObjects();
            /*0x22fc4b8*/ void SetReferencedUnityObjects(System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            /*0x22fc64c*/ bool CanReference(object value, ref int index);
            /*0x22fc820*/ bool TryResolveReference(int index, ref object value);
            /*0x22fc8b8*/ void Reset();
            /*0x22fc90c*/ void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed();
            /*0x22fc910*/ void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed();
        }

        class UnitySerializationInitializer
        {
            static /*0x0*/ object LOCK;
            static /*0x8*/ bool initialized;
            static /*0xc*/ UnityEngine.RuntimePlatform <CurrentPlatform>k__BackingField;

            static /*0x22fcd50*/ UnitySerializationInitializer();
            static /*0x22fc914*/ bool get_Initialized();
            static /*0x22fc96c*/ UnityEngine.RuntimePlatform get_CurrentPlatform();
            static /*0x22fc9c4*/ void set_CurrentPlatform(UnityEngine.RuntimePlatform value);
            static /*0x22fca20*/ void Initialize();
            static /*0x22fcd04*/ void InitializeRuntime();
        }

        class UnitySerializationUtility
        {
            static /*0x0*/ System.Type SerializeReferenceAttributeType;
            static /*0x8*/ System.Reflection.Assembly String_Assembly;
            static /*0x10*/ System.Reflection.Assembly HashSet_Assembly;
            static /*0x18*/ System.Reflection.Assembly LinkedList_Assembly;
            static /*0x20*/ System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, Sirenix.Serialization.Utilities.WeakValueGetter> UnityMemberGetters;
            static /*0x28*/ System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, Sirenix.Serialization.Utilities.WeakValueSetter> UnityMemberSetters;
            static /*0x30*/ System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, bool> UnityWillSerializeMembersCache;
            static /*0x38*/ System.Collections.Generic.Dictionary<System.Type, bool> UnityWillSerializeTypesCache;
            static /*0x40*/ System.Collections.Generic.HashSet<System.Type> UnityNeverSerializesTypes;
            static /*0x48*/ System.Collections.Generic.HashSet<string> UnityNeverSerializesTypeNames;
            static /*0x50*/ Sirenix.Serialization.ISerializationPolicy UnityPolicy;
            static /*0x58*/ Sirenix.Serialization.ISerializationPolicy EverythingPolicy;
            static /*0x60*/ Sirenix.Serialization.ISerializationPolicy StrictPolicy;
            static /*0x68*/ System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, Sirenix.Serialization.UnitySerializationUtility.CachedSerializationBackendResult> OdinWillSerializeCache_UnityPolicy;
            static /*0x70*/ System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, Sirenix.Serialization.UnitySerializationUtility.CachedSerializationBackendResult> OdinWillSerializeCache_EverythingPolicy;
            static /*0x78*/ System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, Sirenix.Serialization.UnitySerializationUtility.CachedSerializationBackendResult> OdinWillSerializeCache_StrictPolicy;
            static /*0x80*/ System.Collections.Generic.Dictionary<Sirenix.Serialization.ISerializationPolicy, System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, Sirenix.Serialization.UnitySerializationUtility.CachedSerializationBackendResult>> OdinWillSerializeCache_CustomPolicies;

            static /*0x23072d4*/ UnitySerializationUtility();
            static /*0x22fcdd4*/ bool OdinWillSerialize(System.Reflection.MemberInfo member, bool serializeUnityFields, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22fd3a8*/ bool CalculateOdinWillSerialize(System.Reflection.MemberInfo member, bool serializeUnityFields, Sirenix.Serialization.ISerializationPolicy policy);
            static /*0x22fd6c4*/ bool GuessIfUnityWillSerialize(System.Reflection.MemberInfo member);
            static /*0x22fd8f8*/ bool GuessIfUnityWillSerializePrivate(System.Reflection.MemberInfo member);
            static /*0x22fdc24*/ bool GuessIfUnityWillSerialize(System.Type type);
            static /*0x22fde7c*/ bool GuessIfUnityWillSerializePrivate(System.Type type);
            static /*0x22fec08*/ void SerializeUnityObject(UnityEngine.Object unityObject, ref Sirenix.Serialization.SerializationData data, bool serializeUnityFields, Sirenix.Serialization.SerializationContext context);
            static /*0x22ffec0*/ void SerializeUnityObject(UnityEngine.Object unityObject, ref string base64Bytes, ref System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DataFormat format, bool serializeUnityFields, Sirenix.Serialization.SerializationContext context);
            static /*0x22fefe0*/ void SerializeUnityObject(UnityEngine.Object unityObject, ref byte[] bytes, ref System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DataFormat format, bool serializeUnityFields, Sirenix.Serialization.SerializationContext context);
            static /*0x2300248*/ void SerializeUnityObject(UnityEngine.Object unityObject, Sirenix.Serialization.IDataWriter writer, bool serializeUnityFields);
            static /*0x2300f7c*/ void DeserializeUnityObject(UnityEngine.Object unityObject, ref Sirenix.Serialization.SerializationData data, Sirenix.Serialization.DeserializationContext context);
            static /*0x2300ff0*/ void DeserializeUnityObject(UnityEngine.Object unityObject, ref Sirenix.Serialization.SerializationData data, Sirenix.Serialization.DeserializationContext context, bool isPrefabData, System.Collections.Generic.List<UnityEngine.Object> prefabInstanceUnityObjects);
            static /*0x2304388*/ void DeserializeUnityObject(UnityEngine.Object unityObject, ref string base64Bytes, ref System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.DeserializationContext context);
            static /*0x23020b0*/ void DeserializeUnityObject(UnityEngine.Object unityObject, ref byte[] bytes, ref System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects, Sirenix.Serialization.DataFormat format, Sirenix.Serialization.DeserializationContext context);
            static /*0x230325c*/ void DeserializeUnityObject(UnityEngine.Object unityObject, Sirenix.Serialization.IDataReader reader);
            static /*0x2304ba0*/ System.Collections.Generic.List<string> SerializePrefabModifications(System.Collections.Generic.List<Sirenix.Serialization.PrefabModification> modifications, ref System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            static /*0x2305ab8*/ string GetStringFromStreamAndReset(System.IO.Stream stream);
            static /*0x2305ba4*/ System.Collections.Generic.List<Sirenix.Serialization.PrefabModification> DeserializePrefabModifications(System.Collections.Generic.List<string> modifications, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            static /*0x2306b7c*/ object CreateDefaultUnityInitializedObject(System.Type type);
            static /*0x2306bd4*/ object CreateDefaultUnityInitializedObject(System.Type type, int depth);
            static /*0x2302fc0*/ void ApplyPrefabModifications(UnityEngine.Object unityObject, System.Collections.Generic.List<string> modificationData, System.Collections.Generic.List<UnityEngine.Object> referencedUnityObjects);
            static /*0x2300bac*/ Sirenix.Serialization.Utilities.WeakValueGetter GetCachedUnityMemberGetter(System.Reflection.MemberInfo member);
            static /*0x23047d0*/ Sirenix.Serialization.Utilities.WeakValueSetter GetCachedUnityMemberSetter(System.Reflection.MemberInfo member);
            static /*0x22fff94*/ Sirenix.Serialization.Utilities.ICache GetCachedUnityWriter(Sirenix.Serialization.DataFormat format, System.IO.Stream stream, Sirenix.Serialization.SerializationContext context);
            static /*0x230451c*/ Sirenix.Serialization.Utilities.ICache GetCachedUnityReader(Sirenix.Serialization.DataFormat format, System.IO.Stream stream, Sirenix.Serialization.DeserializationContext context);

            struct CachedSerializationBackendResult
            {
                /*0x10*/ bool HasCalculatedSerializeUnityFieldsTrueResult;
                /*0x11*/ bool HasCalculatedSerializeUnityFieldsFalseResult;
                /*0x12*/ bool SerializeUnityFieldsTrueResult;
                /*0x13*/ bool SerializeUnityFieldsFalseResult;
            }

            class <>c
            {
                static /*0x0*/ Sirenix.Serialization.UnitySerializationUtility.<> <>9;
                static /*0x8*/ System.Comparison<Sirenix.Serialization.PrefabModification> <>9__33_0;

                static /*0x2307884*/ <>c();
                /*0x23078e8*/ <>c();
                /*0x23078f0*/ int <SerializePrefabModifications>b__33_0(Sirenix.Serialization.PrefabModification a, Sirenix.Serialization.PrefabModification b);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ System.Reflection.MemberInfo member;

                /*0x23072c4*/ <>c__DisplayClass39_0();
                /*0x230796c*/ object <GetCachedUnityMemberGetter>b__0(ref object instance);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ System.Reflection.MemberInfo member;

                /*0x23072cc*/ <>c__DisplayClass40_0();
                /*0x23079dc*/ void <GetCachedUnityMemberSetter>b__0(ref object instance, object value);
            }
        }

        namespace Utilities
        {
            class FieldInfoExtensions
            {
                static /*0x2307a54*/ bool IsAliasField(System.Reflection.FieldInfo fieldInfo);
                static /*0x2307ab0*/ System.Reflection.FieldInfo DeAliasField(System.Reflection.FieldInfo fieldInfo, bool throwOnNotAliased);
            }

            class GarbageFreeIterators
            {
                static Sirenix.Serialization.Utilities.GarbageFreeIterators.ListIterator<T> GFIterator<T>(System.Collections.Generic.List<T> list);
                static Sirenix.Serialization.Utilities.GarbageFreeIterators.DictionaryIterator<T1, T2> GFIterator<T1, T2>(System.Collections.Generic.Dictionary<T1, T2> dictionary);
                static Sirenix.Serialization.Utilities.GarbageFreeIterators.DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(System.Collections.Generic.Dictionary<T1, T2> dictionary);
                static Sirenix.Serialization.Utilities.GarbageFreeIterators.HashsetIterator<T> GFIterator<T>(System.Collections.Generic.HashSet<T> hashset);

                struct ListIterator<T> : System.IDisposable
                {
                    /*0x0*/ bool isNull;
                    /*0x0*/ System.Collections.Generic.List<T> list;
                    /*0x0*/ System.Collections.Generic.List.Enumerator<T> enumerator;

                    ListIterator(System.Collections.Generic.List<T> list);
                    Sirenix.Serialization.Utilities.GarbageFreeIterators.ListIterator<T> GetEnumerator();
                    T get_Current();
                    bool MoveNext();
                    void Dispose();
                }

                struct HashsetIterator<T> : System.IDisposable
                {
                    /*0x0*/ bool isNull;
                    /*0x0*/ System.Collections.Generic.HashSet<T> hashset;
                    /*0x0*/ System.Collections.Generic.HashSet.Enumerator<T> enumerator;

                    HashsetIterator(System.Collections.Generic.HashSet<T> hashset);
                    Sirenix.Serialization.Utilities.GarbageFreeIterators.HashsetIterator<T> GetEnumerator();
                    T get_Current();
                    bool MoveNext();
                    void Dispose();
                }

                struct DictionaryIterator<T1, T2> : System.IDisposable
                {
                    /*0x0*/ System.Collections.Generic.Dictionary<T1, T2> dictionary;
                    /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<T1, T2> enumerator;
                    /*0x0*/ bool isNull;

                    DictionaryIterator(System.Collections.Generic.Dictionary<T1, T2> dictionary);
                    Sirenix.Serialization.Utilities.GarbageFreeIterators.DictionaryIterator<T1, T2> GetEnumerator();
                    System.Collections.Generic.KeyValuePair<T1, T2> get_Current();
                    bool MoveNext();
                    void Dispose();
                }

                struct DictionaryValueIterator<T1, T2> : System.IDisposable
                {
                    /*0x0*/ System.Collections.Generic.Dictionary<T1, T2> dictionary;
                    /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<T1, T2> enumerator;
                    /*0x0*/ bool isNull;

                    DictionaryValueIterator(System.Collections.Generic.Dictionary<T1, T2> dictionary);
                    Sirenix.Serialization.Utilities.GarbageFreeIterators.DictionaryValueIterator<T1, T2> GetEnumerator();
                    T2 get_Current();
                    bool MoveNext();
                    void Dispose();
                }
            }

            class LinqExtensions
            {
                static System.Collections.Generic.IEnumerable<T> ForEach<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T> action);
                static System.Collections.Generic.IEnumerable<T> ForEach<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T, int> action);
                static System.Collections.Generic.IEnumerable<T> Append<T>(System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IEnumerable<T> append);

                class <Append>d__2<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> append;
                    /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__append;
                    /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                    <Append>d__2(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    void <>m__Finally1();
                    void <>m__Finally2();
                    T System.Collections.Generic.IEnumerator<T>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class MemberInfoExtensions
            {
                static bool IsDefined<T>(System.Reflection.ICustomAttributeProvider member, bool inherit);
                static bool IsDefined<T>(System.Reflection.ICustomAttributeProvider member);
                static T GetAttribute<T>(System.Reflection.ICustomAttributeProvider member, bool inherit);
                static T GetAttribute<T>(System.Reflection.ICustomAttributeProvider member);
                static System.Collections.Generic.IEnumerable<T> GetAttributes<T>(System.Reflection.ICustomAttributeProvider member);
                static System.Collections.Generic.IEnumerable<T> GetAttributes<T>(System.Reflection.ICustomAttributeProvider member, bool inherit);
                static /*0x2307c90*/ System.Attribute[] GetAttributes(System.Reflection.ICustomAttributeProvider member);
                static /*0x2307d84*/ System.Attribute[] GetAttributes(System.Reflection.ICustomAttributeProvider member, bool inherit);
                static /*0x2307bdc*/ string GetNiceName(System.Reflection.MemberInfo member);
                static /*0x2308058*/ bool IsStatic(System.Reflection.MemberInfo member);
                static /*0x2308458*/ bool IsAlias(System.Reflection.MemberInfo memberInfo);
                static /*0x23084f8*/ System.Reflection.MemberInfo DeAlias(System.Reflection.MemberInfo memberInfo, bool throwOnNotAliased);
            }

            class MethodInfoExtensions
            {
                static /*0x230868c*/ string GetFullName(System.Reflection.MethodBase method, string extensionMethodPrefix);
                static /*0x2308898*/ string GetParamsNames(System.Reflection.MethodBase method);
                static /*0x2307e8c*/ string GetFullName(System.Reflection.MethodBase method);
                static /*0x23087a4*/ bool IsExtensionMethod(System.Reflection.MethodBase method);
                static /*0x2308a94*/ bool IsAliasMethod(System.Reflection.MethodInfo methodInfo);
                static /*0x2308af0*/ System.Reflection.MethodInfo DeAliasMethod(System.Reflection.MethodInfo methodInfo, bool throwOnNotAliased);
            }

            enum Operator
            {
                Equality = 0,
                Inequality = 1,
                Addition = 2,
                Subtraction = 3,
                Multiply = 4,
                Division = 5,
                LessThan = 6,
                GreaterThan = 7,
                LessThanOrEqual = 8,
                GreaterThanOrEqual = 9,
                Modulus = 10,
                RightShift = 11,
                LeftShift = 12,
                BitwiseAnd = 13,
                BitwiseOr = 14,
                ExclusiveOr = 15,
                BitwiseComplement = 16,
                LogicalAnd = 17,
                LogicalOr = 18,
                LogicalNot = 19,
            }

            class PathUtilities
            {
                static /*0x2308c1c*/ bool HasSubDirectory(System.IO.DirectoryInfo parentDir, System.IO.DirectoryInfo subDir);
            }

            class PropertyInfoExtensions
            {
                static /*0x2308d70*/ bool IsAutoProperty(System.Reflection.PropertyInfo propInfo, bool allowVirtual);
                static /*0x2308f78*/ bool IsAliasProperty(System.Reflection.PropertyInfo propertyInfo);
                static /*0x2308fd4*/ System.Reflection.PropertyInfo DeAliasProperty(System.Reflection.PropertyInfo propertyInfo, bool throwOnNotAliased);
            }

            class StringExtensions
            {
                static /*0x2307ed4*/ string ToTitleCase(string input);
                static /*0x22fc044*/ bool IsNullOrWhitespace(string str);
            }

            class TypeExtensions
            {
                static /*0x0*/ System.Func<float, float, bool> FloatEqualityComparerFunc;
                static /*0x8*/ System.Func<double, double, bool> DoubleEqualityComparerFunc;
                static /*0x10*/ System.Func<UnityEngine.Quaternion, UnityEngine.Quaternion, bool> QuaternionEqualityComparerFunc;
                static /*0x18*/ object GenericConstraintsSatisfaction_LOCK;
                static /*0x20*/ System.Collections.Generic.Dictionary<System.Type, System.Type> GenericConstraintsSatisfactionInferredParameters;
                static /*0x28*/ System.Collections.Generic.Dictionary<System.Type, System.Type> GenericConstraintsSatisfactionResolvedMap;
                static /*0x30*/ System.Collections.Generic.HashSet<System.Type> GenericConstraintsSatisfactionProcessedParams;
                static /*0x38*/ System.Collections.Generic.HashSet<System.Type> GenericConstraintsSatisfactionTypesToCheck;
                static /*0x40*/ System.Collections.Generic.List<System.Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd;
                static /*0x48*/ System.Type GenericListInterface;
                static /*0x50*/ System.Type GenericCollectionInterface;
                static /*0x58*/ object WeaklyTypedTypeCastDelegates_LOCK;
                static /*0x60*/ object StronglyTypedTypeCastDelegates_LOCK;
                static /*0x68*/ Sirenix.Serialization.Utilities.DoubleLookupDictionary<System.Type, System.Type, System.Func<object, object>> WeaklyTypedTypeCastDelegates;
                static /*0x70*/ Sirenix.Serialization.Utilities.DoubleLookupDictionary<System.Type, System.Type, System.Delegate> StronglyTypedTypeCastDelegates;
                static /*0x78*/ System.Type[] TwoLengthTypeArray_Cached;
                static /*0x80*/ System.Collections.Generic.Stack<System.Type> GenericArgumentsContainsTypes_ArgsToCheckCached;
                static /*0x88*/ System.Collections.Generic.HashSet<string> ReservedCSharpKeywords;
                static /*0x90*/ System.Collections.Generic.Dictionary<string, string> TypeNameAlternatives;
                static /*0x98*/ object CachedNiceNames_LOCK;
                static /*0xa0*/ System.Collections.Generic.Dictionary<System.Type, string> CachedNiceNames;
                static /*0xa8*/ System.Type VoidPointerType;
                static /*0xb0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.HashSet<System.Type>> PrimitiveImplicitCasts;
                static /*0xb8*/ System.Collections.Generic.HashSet<System.Type> ExplicitCastIntegrals;

                static /*0x231048c*/ TypeExtensions();
                static /*0x2309100*/ string GetCachedNiceName(System.Type type);
                static /*0x23092cc*/ string CreateNiceName(System.Type type);
                static /*0x2309978*/ bool HasCastDefined(System.Type from, System.Type to, bool requireImplicitCast);
                static /*0x230a7e8*/ bool IsValidIdentifier(string identifier);
                static /*0x230a9d4*/ bool IsValidIdentifierStartCharacter(char c);
                static /*0x230aa64*/ bool IsValidIdentifierPartCharacter(char c);
                static /*0x2309da4*/ bool IsCastableTo(System.Type from, System.Type to, bool requireImplicitCast);
                static /*0x230ab08*/ System.Func<object, object> GetCastMethodDelegate(System.Type from, System.Type to, bool requireImplicitCast);
                static System.Func<TFrom, TTo> GetCastMethodDelegate<TFrom, TTo>(bool requireImplicitCast);
                static /*0x2309f38*/ System.Reflection.MethodInfo GetCastMethod(System.Type from, System.Type to, bool requireImplicitCast);
                static /*0x230ad9c*/ bool FloatEqualityComparer(float a, float b);
                static /*0x230ae60*/ bool DoubleEqualityComparer(double a, double b);
                static /*0x230af24*/ bool QuaternionEqualityComparer(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
                static System.Func<T, T, bool> GetEqualityComparerDelegate<T>();
                static T GetAttribute<T>(System.Type type, bool inherit);
                static /*0x230af54*/ bool ImplementsOrInherits(System.Type type, System.Type to);
                static /*0x230af80*/ bool ImplementsOpenGenericType(System.Type candidateType, System.Type openGenericType);
                static /*0x22f3cb4*/ bool ImplementsOpenGenericInterface(System.Type candidateType, System.Type openGenericInterfaceType);
                static /*0x22fe9a0*/ bool ImplementsOpenGenericClass(System.Type candidateType, System.Type openGenericType);
                static /*0x230b008*/ System.Type[] GetArgumentsOfInheritedOpenGenericType(System.Type candidateType, System.Type openGenericType);
                static /*0x22feacc*/ System.Type[] GetArgumentsOfInheritedOpenGenericClass(System.Type candidateType, System.Type openGenericType);
                static /*0x22f3f14*/ System.Type[] GetArgumentsOfInheritedOpenGenericInterface(System.Type candidateType, System.Type openGenericInterfaceType);
                static /*0x230b090*/ System.Reflection.MethodInfo GetOperatorMethod(System.Type type, Sirenix.Serialization.Utilities.Operator op, System.Type leftOperand, System.Type rightOperand);
                static /*0x230b7a0*/ System.Reflection.MethodInfo GetOperatorMethod(System.Type type, Sirenix.Serialization.Utilities.Operator op);
                static /*0x230bae4*/ System.Reflection.MethodInfo[] GetOperatorMethods(System.Type type, Sirenix.Serialization.Utilities.Operator op);
                static /*0x230be44*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetAllMembers(System.Type type, System.Reflection.BindingFlags flags);
                static /*0x230bebc*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetAllMembers(System.Type type, string name, System.Reflection.BindingFlags flags);
                static System.Collections.Generic.IEnumerable<T> GetAllMembers<T>(System.Type type, System.Reflection.BindingFlags flags);
                static /*0x230bf3c*/ System.Type GetGenericBaseType(System.Type type, System.Type baseType);
                static /*0x230bfac*/ System.Type GetGenericBaseType(System.Type type, System.Type baseType, ref int depthCount);
                static /*0x230c454*/ System.Collections.Generic.IEnumerable<System.Type> GetBaseTypes(System.Type type, bool includeSelf);
                static /*0x230c584*/ System.Collections.Generic.IEnumerable<System.Type> GetBaseClasses(System.Type type, bool includeSelf);
                static /*0x2309894*/ string TypeNameGauntlet(System.Type type);
                static /*0x22f3e20*/ string GetNiceName(System.Type type);
                static /*0x22f41c8*/ string GetNiceFullName(System.Type type);
                static /*0x230c600*/ string GetCompilableNiceName(System.Type type);
                static /*0x230c6d4*/ string GetCompilableNiceFullName(System.Type type);
                static T GetCustomAttribute<T>(System.Type type, bool inherit);
                static T GetCustomAttribute<T>(System.Type type);
                static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(System.Type type);
                static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(System.Type type, bool inherit);
                static bool IsDefined<T>(System.Type type);
                static bool IsDefined<T>(System.Type type, bool inherit);
                static bool InheritsFrom<TBase>(System.Type type);
                static /*0x23096c4*/ bool InheritsFrom(System.Type type, System.Type baseType);
                static /*0x230c7a8*/ int GetInheritanceDistance(System.Type type, System.Type baseType);
                static /*0x230cba8*/ bool HasParamaters(System.Reflection.MethodInfo methodInfo, System.Collections.Generic.IList<System.Type> paramTypes, bool inherit);
                static /*0x230ce68*/ System.Type GetReturnType(System.Reflection.MemberInfo memberInfo);
                static /*0x230d07c*/ object GetMemberValue(System.Reflection.MemberInfo member, object obj);
                static /*0x230d1fc*/ void SetMemberValue(System.Reflection.MemberInfo member, object obj, object value);
                static /*0x230d454*/ bool TryInferGenericParameters(System.Type genericTypeDefinition, ref System.Type[] inferredParams, System.Type[] knownParameters);
                static /*0x230e578*/ bool AreGenericConstraintsSatisfiedBy(System.Type genericType, System.Type[] parameters);
                static /*0x230e918*/ bool AreGenericConstraintsSatisfiedBy(System.Reflection.MethodBase genericMethod, System.Type[] parameters);
                static /*0x230e6fc*/ bool AreGenericConstraintsSatisfiedBy(System.Type[] definitions, System.Type[] parameters);
                static /*0x230f310*/ bool GenericParameterIsFulfilledBy(System.Type genericParameterDefinition, System.Type parameterType);
                static /*0x230ea70*/ bool GenericParameterIsFulfilledBy(System.Type genericParameterDefinition, System.Type parameterType, System.Collections.Generic.Dictionary<System.Type, System.Type> resolvedMap, System.Collections.Generic.HashSet<System.Type> processedParams);
                static /*0x230f47c*/ string GetGenericConstraintsString(System.Type type, bool useFullTypeNames);
                static /*0x230f704*/ string GetGenericParameterConstraintsString(System.Type type, bool useFullTypeNames);
                static /*0x230fb94*/ bool GenericArgumentsContainsTypes(System.Type type, System.Type[] types);
                static /*0x230e384*/ bool IsFullyConstructedGenericType(System.Type type);
                static /*0x2310104*/ bool IsNullableType(System.Type type);
                static /*0x231015c*/ ulong GetEnumBitmask(object value, System.Type enumType);
                static /*0x2310324*/ System.Type[] SafeGetTypes(System.Reflection.Assembly assembly);
                static /*0x23103e8*/ bool SafeIsDefined(System.Reflection.Assembly assembly, System.Type attribute, bool inherit);
                static /*0x22f67e8*/ object[] SafeGetCustomAttributes(System.Reflection.Assembly assembly, System.Type type, bool inherit);

                class <>c__37<T>
                {
                    static /*0x0*/ Sirenix.Serialization.Utilities.TypeExtensions.<>c__37<T> <>9;
                    static /*0x0*/ System.Func<T, T, bool> <>9__37_0;
                    static /*0x0*/ System.Func<T, T, bool> <>9__37_1;

                    static <>c__37();
                    <>c__37();
                    bool <GetEqualityComparerDelegate>b__37_0(T a, T b);
                    bool <GetEqualityComparerDelegate>b__37_1(T a, T b);
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Reflection.MethodInfo method;

                    /*0x2313ad0*/ <>c__DisplayClass31_0();
                    /*0x2313ad8*/ object <GetCastMethodDelegate>b__0(object obj);
                }

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ string methodName;

                    /*0x2313b88*/ <>c__DisplayClass47_0();
                    /*0x2313b90*/ bool <GetOperatorMethod>b__0(System.Reflection.MethodInfo m);
                }

                class <>c__DisplayClass48_0
                {
                    /*0x10*/ string methodName;

                    /*0x2313bc8*/ <>c__DisplayClass48_0();
                    /*0x2313bd0*/ bool <GetOperatorMethods>b__0(System.Reflection.MethodInfo x);
                }

                class <GetAllMembers>d__49 : System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Reflection.MemberInfo <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Type type;
                    /*0x30*/ System.Type <>3__type;
                    /*0x38*/ System.Reflection.BindingFlags flags;
                    /*0x3c*/ System.Reflection.BindingFlags <>3__flags;
                    /*0x40*/ System.Type <currentType>5__2;
                    /*0x48*/ System.Reflection.MemberInfo[] <>7__wrap2;
                    /*0x50*/ int <>7__wrap3;

                    /*0x2313c08*/ <GetAllMembers>d__49(int <>1__state);
                    /*0x2313c3c*/ void System.IDisposable.Dispose();
                    /*0x2313c40*/ bool MoveNext();
                    /*0x2313e00*/ System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current();
                    /*0x2313e08*/ void System.Collections.IEnumerator.Reset();
                    /*0x2313e48*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2313e50*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator();
                    /*0x2313efc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <GetAllMembers>d__50 : System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Reflection.MemberInfo <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Type type;
                    /*0x30*/ System.Type <>3__type;
                    /*0x38*/ System.Reflection.BindingFlags flags;
                    /*0x3c*/ System.Reflection.BindingFlags <>3__flags;
                    /*0x40*/ string name;
                    /*0x48*/ string <>3__name;
                    /*0x50*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> <>7__wrap1;

                    /*0x2313f00*/ <GetAllMembers>d__50(int <>1__state);
                    /*0x2313f34*/ void System.IDisposable.Dispose();
                    /*0x2313f50*/ bool MoveNext();
                    /*0x2314258*/ void <>m__Finally1();
                    /*0x2314308*/ System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current();
                    /*0x2314310*/ void System.Collections.IEnumerator.Reset();
                    /*0x2314350*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2314358*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator();
                    /*0x231440c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <GetAllMembers>d__5<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Type type;
                    /*0x0*/ System.Type <>3__type;
                    /*0x0*/ System.Reflection.BindingFlags flags;
                    /*0x0*/ System.Reflection.BindingFlags <>3__flags;
                    /*0x0*/ System.Type <currentType>5__2;
                    /*0x0*/ System.Reflection.MemberInfo[] <>7__wrap2;
                    /*0x0*/ int <>7__wrap3;

                    <GetAllMembers>d__5(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    T System.Collections.Generic.IEnumerator<T>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <GetBaseClasses>d__55 : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Type <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Type type;
                    /*0x30*/ System.Type <>3__type;
                    /*0x38*/ bool includeSelf;
                    /*0x39*/ bool <>3__includeSelf;
                    /*0x40*/ System.Type <current>5__2;

                    /*0x2314410*/ <GetBaseClasses>d__55(int <>1__state);
                    /*0x2314444*/ void System.IDisposable.Dispose();
                    /*0x2314448*/ bool MoveNext();
                    /*0x23145a8*/ System.Type System.Collections.Generic.IEnumerator<System.Type>.get_Current();
                    /*0x23145b0*/ void System.Collections.IEnumerator.Reset();
                    /*0x23145f0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x23145f8*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                    /*0x23146a4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <GetCustomAttributes>d__64<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ T <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ System.Type type;
                    /*0x0*/ System.Type <>3__type;
                    /*0x0*/ bool inherit;
                    /*0x0*/ bool <>3__inherit;
                    /*0x0*/ object[] <attrs>5__2;
                    /*0x0*/ int <i>5__3;

                    <GetCustomAttributes>d__64(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    T System.Collections.Generic.IEnumerator<T>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class UnityExtensions
            {
                static /*0x0*/ Sirenix.Serialization.Utilities.ValueGetter<UnityEngine.Object, nint> UnityObjectCachedPtrFieldGetter;

                static /*0x23146a8*/ UnityExtensions();
                static /*0x23147c4*/ bool SafeIsUnityNull(UnityEngine.Object obj);
            }

            interface ICache : System.IDisposable
            {
                object get_Value();
            }

            class Cache<T> : Sirenix.Serialization.Utilities.ICache, System.IDisposable
            {
                static /*0x0*/ bool IsNotificationReceiver;
                static /*0x0*/ object[] FreeValues;
                static /*0x0*/ int THREAD_LOCK_TOKEN;
                static /*0x0*/ int maxCacheSize;
                /*0x0*/ bool isFree;
                /*0x0*/ T Value;

                static Cache();
                static int get_MaxCacheSize();
                static void set_MaxCacheSize(int value);
                static Sirenix.Serialization.Utilities.Cache<T> Claim();
                static void Release(Sirenix.Serialization.Utilities.Cache<T> cache);
                static T op_Implicit(Sirenix.Serialization.Utilities.Cache<T> cache);
                Cache();
                bool get_IsFree();
                object Sirenix.Serialization.Utilities.ICache.get_Value();
                void Release();
                void System.IDisposable.Dispose();
            }

            class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : System.Collections.Generic.Dictionary<TFirstKey, System.Collections.Generic.Dictionary<TSecondKey, TValue>>
            {
                /*0x0*/ System.Collections.Generic.IEqualityComparer<TSecondKey> secondKeyComparer;

                DoubleLookupDictionary();
                DoubleLookupDictionary(System.Collections.Generic.IEqualityComparer<TFirstKey> firstKeyComparer, System.Collections.Generic.IEqualityComparer<TSecondKey> secondKeyComparer);
                System.Collections.Generic.Dictionary<TSecondKey, TValue> get_Item(TFirstKey firstKey);
                int InnerCount(TFirstKey firstKey);
                int TotalInnerCount();
                bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey);
                bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, ref TValue value);
                TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value);
                bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey);
                void RemoveWhere(System.Func<TValue, bool> predicate);
            }

            class WeakValueGetter : System.MulticastDelegate
            {
                /*0x23148e0*/ WeakValueGetter(object object, nint method);
                /*0x23149b4*/ object Invoke(ref object instance);
                /*0x23149c8*/ System.IAsyncResult BeginInvoke(ref object instance, System.AsyncCallback callback, object object);
                /*0x23149ec*/ object EndInvoke(ref object instance, System.IAsyncResult result);
            }

            class WeakValueSetter : System.MulticastDelegate
            {
                /*0x2314a08*/ WeakValueSetter(object object, nint method);
                /*0x2314ae0*/ void Invoke(ref object instance, object value);
                /*0x2314af4*/ System.IAsyncResult BeginInvoke(ref object instance, object value, System.AsyncCallback callback, object object);
                /*0x2314b20*/ void EndInvoke(ref object instance, System.IAsyncResult result);
            }

            class WeakValueGetter<FieldType> : System.MulticastDelegate
            {
                WeakValueGetter(object object, nint method);
                FieldType Invoke(ref object instance);
                System.IAsyncResult BeginInvoke(ref object instance, System.AsyncCallback callback, object object);
                FieldType EndInvoke(ref object instance, System.IAsyncResult result);
            }

            class WeakValueSetter<FieldType> : System.MulticastDelegate
            {
                WeakValueSetter(object object, nint method);
                void Invoke(ref object instance, FieldType value);
                System.IAsyncResult BeginInvoke(ref object instance, FieldType value, System.AsyncCallback callback, object object);
                void EndInvoke(ref object instance, System.IAsyncResult result);
            }

            class ValueGetter<InstanceType, FieldType> : System.MulticastDelegate
            {
                ValueGetter(object object, nint method);
                FieldType Invoke(ref InstanceType instance);
                System.IAsyncResult BeginInvoke(ref InstanceType instance, System.AsyncCallback callback, object object);
                FieldType EndInvoke(ref InstanceType instance, System.IAsyncResult result);
            }

            class ValueSetter<InstanceType, FieldType> : System.MulticastDelegate
            {
                ValueSetter(object object, nint method);
                void Invoke(ref InstanceType instance, FieldType value);
                System.IAsyncResult BeginInvoke(ref InstanceType instance, FieldType value, System.AsyncCallback callback, object object);
                void EndInvoke(ref InstanceType instance, System.IAsyncResult result);
            }

            class EmitUtilities
            {
                static /*0x0*/ System.Reflection.Assembly EngineAssembly;

                static /*0x2315bc0*/ EmitUtilities();
                static /*0x2314b3c*/ bool get_CanEmit();
                static /*0x2314b44*/ bool EmitIsIllegalForMember(System.Reflection.MemberInfo member);
                static System.Func<FieldType> CreateStaticFieldGetter<FieldType>(System.Reflection.FieldInfo fieldInfo);
                static /*0x2314c44*/ System.Func<object> CreateWeakStaticFieldGetter(System.Reflection.FieldInfo fieldInfo);
                static System.Action<FieldType> CreateStaticFieldSetter<FieldType>(System.Reflection.FieldInfo fieldInfo);
                static /*0x2314db8*/ System.Action<object> CreateWeakStaticFieldSetter(System.Reflection.FieldInfo fieldInfo);
                static Sirenix.Serialization.Utilities.ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter<InstanceType, FieldType>(System.Reflection.FieldInfo fieldInfo);
                static Sirenix.Serialization.Utilities.WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter<FieldType>(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
                static /*0x2314f2c*/ Sirenix.Serialization.Utilities.WeakValueGetter CreateWeakInstanceFieldGetter(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
                static Sirenix.Serialization.Utilities.ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter<InstanceType, FieldType>(System.Reflection.FieldInfo fieldInfo);
                static Sirenix.Serialization.Utilities.WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter<FieldType>(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
                static /*0x2315104*/ Sirenix.Serialization.Utilities.WeakValueSetter CreateWeakInstanceFieldSetter(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
                static /*0x23152dc*/ Sirenix.Serialization.Utilities.WeakValueGetter CreateWeakInstancePropertyGetter(System.Type instanceType, System.Reflection.PropertyInfo propertyInfo);
                static /*0x231554c*/ Sirenix.Serialization.Utilities.WeakValueSetter CreateWeakInstancePropertySetter(System.Type instanceType, System.Reflection.PropertyInfo propertyInfo);
                static System.Action<PropType> CreateStaticPropertySetter<PropType>(System.Reflection.PropertyInfo propertyInfo);
                static System.Func<PropType> CreateStaticPropertyGetter<PropType>(System.Reflection.PropertyInfo propertyInfo);
                static Sirenix.Serialization.Utilities.ValueSetter<InstanceType, PropType> CreateInstancePropertySetter<InstanceType, PropType>(System.Reflection.PropertyInfo propertyInfo);
                static Sirenix.Serialization.Utilities.ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter<InstanceType, PropType>(System.Reflection.PropertyInfo propertyInfo);
                static System.Func<InstanceType, ReturnType> CreateMethodReturner<InstanceType, ReturnType>(System.Reflection.MethodInfo methodInfo);
                static /*0x2315780*/ System.Action CreateStaticMethodCaller(System.Reflection.MethodInfo methodInfo);
                static System.Action<object, TArg1> CreateWeakInstanceMethodCaller<TArg1>(System.Reflection.MethodInfo methodInfo);
                static /*0x231599c*/ System.Action<object> CreateWeakInstanceMethodCaller(System.Reflection.MethodInfo methodInfo);
                static System.Func<object, TArg1, TResult> CreateWeakInstanceMethodCaller<TResult, TArg1>(System.Reflection.MethodInfo methodInfo);
                static System.Func<object, TResult> CreateWeakInstanceMethodCallerFunc<TResult>(System.Reflection.MethodInfo methodInfo);
                static System.Func<object, TArg, TResult> CreateWeakInstanceMethodCallerFunc<TArg, TResult>(System.Reflection.MethodInfo methodInfo);
                static System.Action<InstanceType> CreateInstanceMethodCaller<InstanceType>(System.Reflection.MethodInfo methodInfo);
                static System.Action<InstanceType, Arg1> CreateInstanceMethodCaller<InstanceType, Arg1>(System.Reflection.MethodInfo methodInfo);
                static Sirenix.Serialization.Utilities.EmitUtilities.InstanceRefMethodCaller<InstanceType> CreateInstanceRefMethodCaller<InstanceType>(System.Reflection.MethodInfo methodInfo);
                static Sirenix.Serialization.Utilities.EmitUtilities.InstanceRefMethodCaller<InstanceType, Arg1> CreateInstanceRefMethodCaller<InstanceType, Arg1>(System.Reflection.MethodInfo methodInfo);

                class InstanceRefMethodCaller<InstanceType> : System.MulticastDelegate
                {
                    InstanceRefMethodCaller(object object, nint method);
                    void Invoke(ref InstanceType instance);
                    System.IAsyncResult BeginInvoke(ref InstanceType instance, System.AsyncCallback callback, object object);
                    void EndInvoke(ref InstanceType instance, System.IAsyncResult result);
                }

                class InstanceRefMethodCaller<InstanceType, TArg1> : System.MulticastDelegate
                {
                    InstanceRefMethodCaller(object object, nint method);
                    void Invoke(ref InstanceType instance, TArg1 arg1);
                    System.IAsyncResult BeginInvoke(ref InstanceType instance, TArg1 arg1, System.AsyncCallback callback, object object);
                    void EndInvoke(ref InstanceType instance, System.IAsyncResult result);
                }

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x23150fc*/ <>c__DisplayClass10_0();
                    /*0x2315c68*/ object <CreateWeakInstanceFieldGetter>b__0(ref object classInstance);
                }

                class <>c__DisplayClass11_0<InstanceType, FieldType>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass11_0();
                    void <CreateInstanceFieldSetter>b__0(ref InstanceType classInstance, FieldType value);
                }

                class <>c__DisplayClass12_0<FieldType>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass12_0();
                    void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, FieldType value);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x23152d4*/ <>c__DisplayClass13_0();
                    /*0x2315c90*/ void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, object value);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x2315544*/ <>c__DisplayClass14_0();
                    /*0x2315cb0*/ object <CreateWeakInstancePropertyGetter>b__0(ref object classInstance);
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo propertyInfo;

                    /*0x2315778*/ <>c__DisplayClass15_0();
                    /*0x2315cdc*/ void <CreateWeakInstancePropertySetter>b__0(ref object classInstance, object value);
                }

                class <>c__DisplayClass16_0<PropType>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    <>c__DisplayClass16_0();
                    void <CreateStaticPropertySetter>b__0(PropType value);
                }

                class <>c__DisplayClass17_0<PropType>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    <>c__DisplayClass17_0();
                    PropType <CreateStaticPropertyGetter>b__0();
                }

                class <>c__DisplayClass18_0<InstanceType, PropType>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    <>c__DisplayClass18_0();
                    void <CreateInstancePropertySetter>b__0(ref InstanceType classInstance, PropType value);
                }

                class <>c__DisplayClass19_0<InstanceType, PropType>
                {
                    /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                    <>c__DisplayClass19_0();
                    PropType <CreateInstancePropertyGetter>b__0(ref InstanceType classInstance);
                }

                class <>c__DisplayClass22_0<TArg1>
                {
                    /*0x0*/ System.Reflection.MethodInfo methodInfo;

                    <>c__DisplayClass22_0();
                    void <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ System.Reflection.MethodInfo methodInfo;

                    /*0x2315bb8*/ <>c__DisplayClass23_0();
                    /*0x2315d08*/ void <CreateWeakInstanceMethodCaller>b__0(object classInstance);
                }

                class <>c__DisplayClass24_0<TResult, TArg1>
                {
                    /*0x0*/ System.Reflection.MethodInfo methodInfo;

                    <>c__DisplayClass24_0();
                    TResult <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg1);
                }

                class <>c__DisplayClass25_0<TResult>
                {
                    /*0x0*/ System.Reflection.MethodInfo methodInfo;

                    <>c__DisplayClass25_0();
                    TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance);
                }

                class <>c__DisplayClass26_0<TArg, TResult>
                {
                    /*0x0*/ System.Reflection.MethodInfo methodInfo;

                    <>c__DisplayClass26_0();
                    TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance, TArg arg);
                }

                class <>c__DisplayClass31_0<InstanceType>
                {
                    /*0x0*/ System.Reflection.MethodInfo methodInfo;

                    <>c__DisplayClass31_0();
                    void <CreateInstanceRefMethodCaller>b__0(ref InstanceType instance);
                }

                class <>c__DisplayClass32_0<InstanceType, Arg1>
                {
                    /*0x0*/ System.Reflection.MethodInfo methodInfo;

                    <>c__DisplayClass32_0();
                    void <CreateInstanceRefMethodCaller>b__0(ref InstanceType instance, Arg1 arg1);
                }

                class <>c__DisplayClass4_0<FieldType>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass4_0();
                    FieldType <CreateStaticFieldGetter>b__0();
                }

                class <>c__DisplayClass4_<FieldType>
                {
                    /*0x0*/ FieldType value;

                    <>c__DisplayClass4_();
                    FieldType <CreateStaticFieldGetter>b__1();
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x2314db0*/ <>c__DisplayClass5_0();
                    /*0x2315d28*/ object <CreateWeakStaticFieldGetter>b__0();
                }

                class <>c__DisplayClass6_0<FieldType>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass6_0();
                    void <CreateStaticFieldSetter>b__0(FieldType value);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                    /*0x2314f24*/ <>c__DisplayClass7_0();
                    /*0x2315d50*/ void <CreateWeakStaticFieldSetter>b__0(object value);
                }

                class <>c__DisplayClass8_0<InstanceType, FieldType>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass8_0();
                    FieldType <CreateInstanceFieldGetter>b__0(ref InstanceType classInstance);
                }

                class <>c__DisplayClass9_0<FieldType>
                {
                    /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                    <>c__DisplayClass9_0();
                    FieldType <CreateWeakInstanceFieldGetter>b__0(ref object classInstance);
                }
            }

            class FastTypeComparer : System.Collections.Generic.IEqualityComparer<System.Type>
            {
                static /*0x0*/ Sirenix.Serialization.Utilities.FastTypeComparer Instance;

                static /*0x2315e14*/ FastTypeComparer();
                /*0x2315e0c*/ FastTypeComparer();
                /*0x2315d74*/ bool Equals(System.Type x, System.Type y);
                /*0x2315dec*/ int GetHashCode(System.Type obj);
            }

            class Flags
            {
                static System.Reflection.BindingFlags AnyVisibility = 48;
                static System.Reflection.BindingFlags InstancePublic = 20;
                static System.Reflection.BindingFlags InstancePrivate = 36;
                static System.Reflection.BindingFlags InstanceAnyVisibility = 52;
                static System.Reflection.BindingFlags StaticPublic = 24;
                static System.Reflection.BindingFlags StaticPrivate = 40;
                static System.Reflection.BindingFlags StaticAnyVisibility = 56;
                static System.Reflection.BindingFlags InstancePublicDeclaredOnly = 22;
                static System.Reflection.BindingFlags InstancePrivateDeclaredOnly = 38;
                static System.Reflection.BindingFlags InstanceAnyDeclaredOnly = 54;
                static System.Reflection.BindingFlags StaticPublicDeclaredOnly = 26;
                static System.Reflection.BindingFlags StaticPrivateDeclaredOnly = 42;
                static System.Reflection.BindingFlags StaticAnyDeclaredOnly = 58;
                static System.Reflection.BindingFlags StaticInstanceAnyVisibility = 60;
                static System.Reflection.BindingFlags AllMembers = 124;
            }

            interface ICacheNotificationReceiver
            {
                void OnFreed();
                void OnClaimed();
            }

            interface IImmutableList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
            }

            interface IImmutableList<T> : Sirenix.Serialization.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>
            {
                T get_Item(int index);
            }

            class ImmutableList : Sirenix.Serialization.Utilities.IImmutableList<object>, Sirenix.Serialization.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<object>, System.Collections.Generic.ICollection<object>, System.Collections.Generic.IEnumerable<object>
            {
                /*0x10*/ System.Collections.IList innerList;

                /*0x2315e78*/ ImmutableList(System.Collections.IList innerList);
                /*0x2315ef0*/ int get_Count();
                /*0x2315f94*/ bool get_IsFixedSize();
                /*0x2315f9c*/ bool get_IsReadOnly();
                /*0x2315fa4*/ bool get_IsSynchronized();
                /*0x2316048*/ object get_SyncRoot();
                /*0x23160ec*/ object System.Collections.IList.get_Item(int index);
                /*0x2316194*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x23161e4*/ object System.Collections.Generic.IList<System.Object>.get_Item(int index);
                /*0x231628c*/ void System.Collections.Generic.IList<System.Object>.set_Item(int index, object value);
                /*0x23162dc*/ object get_Item(int index);
                /*0x2316384*/ bool Contains(object value);
                /*0x2316430*/ void CopyTo(object[] array, int arrayIndex);
                /*0x23164e8*/ void CopyTo(System.Array array, int index);
                /*0x23165a0*/ System.Collections.IEnumerator GetEnumerator();
                /*0x2316640*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x2316644*/ System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
                /*0x23166d4*/ int System.Collections.IList.Add(object value);
                /*0x2316724*/ void System.Collections.IList.Clear();
                /*0x2316774*/ void System.Collections.IList.Insert(int index, object value);
                /*0x23167c4*/ void System.Collections.IList.Remove(object value);
                /*0x2316814*/ void System.Collections.IList.RemoveAt(int index);
                /*0x2316864*/ int IndexOf(object value);
                /*0x2316910*/ void System.Collections.Generic.IList<System.Object>.RemoveAt(int index);
                /*0x2316960*/ void System.Collections.Generic.IList<System.Object>.Insert(int index, object item);
                /*0x23169b0*/ void System.Collections.Generic.ICollection<System.Object>.Add(object item);
                /*0x2316a00*/ void System.Collections.Generic.ICollection<System.Object>.Clear();
                /*0x2316a50*/ bool System.Collections.Generic.ICollection<System.Object>.Remove(object item);

                class <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25 : System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ Sirenix.Serialization.Utilities.ImmutableList <>4__this;
                    /*0x28*/ System.Collections.IEnumerator <>7__wrap1;

                    /*0x23166ac*/ <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25(int <>1__state);
                    /*0x2316aa0*/ void System.IDisposable.Dispose();
                    /*0x2316abc*/ bool MoveNext();
                    /*0x2316d50*/ void <>m__Finally1();
                    /*0x2316e0c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2316e14*/ void System.Collections.IEnumerator.Reset();
                    /*0x2316e54*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class ImmutableList<T> : Sirenix.Serialization.Utilities.IImmutableList<T>, Sirenix.Serialization.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>
            {
                /*0x0*/ System.Collections.Generic.IList<T> innerList;

                ImmutableList(System.Collections.Generic.IList<T> innerList);
                int get_Count();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                bool System.Collections.IList.get_IsFixedSize();
                bool System.Collections.IList.get_IsReadOnly();
                bool get_IsReadOnly();
                object System.Collections.IList.get_Item(int index);
                void System.Collections.IList.set_Item(int index, object value);
                T System.Collections.Generic.IList<T>.get_Item(int index);
                void System.Collections.Generic.IList<T>.set_Item(int index, T value);
                T get_Item(int index);
                bool Contains(T item);
                void CopyTo(T[] array, int arrayIndex);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                void System.Collections.Generic.ICollection<T>.Add(T item);
                void System.Collections.Generic.ICollection<T>.Clear();
                bool System.Collections.Generic.ICollection<T>.Remove(T item);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                int System.Collections.IList.Add(object value);
                void System.Collections.IList.Clear();
                bool System.Collections.IList.Contains(object value);
                int System.Collections.IList.IndexOf(object value);
                void System.Collections.IList.Insert(int index, object value);
                void System.Collections.IList.Remove(object value);
                void System.Collections.Generic.IList<T>.Insert(int index, T item);
                void System.Collections.IList.RemoveAt(int index);
                int IndexOf(T item);
                void System.Collections.Generic.IList<T>.RemoveAt(int index);
            }

            class ImmutableList<TList, TElement> : Sirenix.Serialization.Utilities.IImmutableList<TElement>, Sirenix.Serialization.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<TElement>, System.Collections.Generic.ICollection<TElement>, System.Collections.Generic.IEnumerable<TElement>
            {
                /*0x0*/ TList innerList;

                ImmutableList(TList innerList);
                int get_Count();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                bool System.Collections.IList.get_IsFixedSize();
                bool System.Collections.IList.get_IsReadOnly();
                bool get_IsReadOnly();
                object System.Collections.IList.get_Item(int index);
                void System.Collections.IList.set_Item(int index, object value);
                TElement System.Collections.Generic.IList<TElement>.get_Item(int index);
                void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value);
                TElement get_Item(int index);
                bool Contains(TElement item);
                void CopyTo(TElement[] array, int arrayIndex);
                System.Collections.Generic.IEnumerator<TElement> GetEnumerator();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                void System.Collections.Generic.ICollection<TElement>.Add(TElement item);
                void System.Collections.Generic.ICollection<TElement>.Clear();
                bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                int System.Collections.IList.Add(object value);
                void System.Collections.IList.Clear();
                bool System.Collections.IList.Contains(object value);
                int System.Collections.IList.IndexOf(object value);
                void System.Collections.IList.Insert(int index, object value);
                void System.Collections.IList.Remove(object value);
                void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item);
                void System.Collections.IList.RemoveAt(int index);
                int IndexOf(TElement item);
                void System.Collections.Generic.IList<TElement>.RemoveAt(int index);
            }

            class MemberAliasFieldInfo : System.Reflection.FieldInfo
            {
                static string FAKE_NAME_SEPARATOR_STRING = "+";
                /*0x10*/ System.Reflection.FieldInfo aliasedField;
                /*0x18*/ string mangledName;

                /*0x2316e5c*/ MemberAliasFieldInfo(System.Reflection.FieldInfo field, string namePrefix);
                /*0x2316ef0*/ MemberAliasFieldInfo(System.Reflection.FieldInfo field, string namePrefix, string separatorString);
                /*0x2316f5c*/ System.Reflection.FieldInfo get_AliasedField();
                /*0x2316f64*/ System.Reflection.Module get_Module();
                /*0x2316f88*/ int get_MetadataToken();
                /*0x2316fac*/ string get_Name();
                /*0x2316fb4*/ System.Type get_DeclaringType();
                /*0x2316fd8*/ System.Type get_ReflectedType();
                /*0x2316ffc*/ System.Type get_FieldType();
                /*0x2317020*/ System.RuntimeFieldHandle get_FieldHandle();
                /*0x2317044*/ System.Reflection.FieldAttributes get_Attributes();
                /*0x2317068*/ object[] GetCustomAttributes(bool inherit);
                /*0x2317090*/ object[] GetCustomAttributes(System.Type attributeType, bool inherit);
                /*0x23170b8*/ bool IsDefined(System.Type attributeType, bool inherit);
                /*0x23170e0*/ object GetValue(object obj);
                /*0x2317104*/ void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture);
            }

            class MemberAliasMethodInfo : System.Reflection.MethodInfo
            {
                static string FAKE_NAME_SEPARATOR_STRING = "+";
                /*0x10*/ System.Reflection.MethodInfo aliasedMethod;
                /*0x18*/ string mangledName;

                /*0x2317128*/ MemberAliasMethodInfo(System.Reflection.MethodInfo method, string namePrefix);
                /*0x23171bc*/ MemberAliasMethodInfo(System.Reflection.MethodInfo method, string namePrefix, string separatorString);
                /*0x2317228*/ System.Reflection.MethodInfo get_AliasedMethod();
                /*0x2317230*/ System.Reflection.ICustomAttributeProvider get_ReturnTypeCustomAttributes();
                /*0x2317254*/ System.RuntimeMethodHandle get_MethodHandle();
                /*0x2317278*/ System.Reflection.MethodAttributes get_Attributes();
                /*0x231729c*/ System.Type get_ReturnType();
                /*0x23172c0*/ System.Type get_DeclaringType();
                /*0x23172e4*/ string get_Name();
                /*0x23172ec*/ System.Type get_ReflectedType();
                /*0x2317310*/ System.Reflection.MethodInfo GetBaseDefinition();
                /*0x2317334*/ object[] GetCustomAttributes(bool inherit);
                /*0x231735c*/ object[] GetCustomAttributes(System.Type attributeType, bool inherit);
                /*0x2317384*/ System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
                /*0x23173a8*/ System.Reflection.ParameterInfo[] GetParameters();
                /*0x23173cc*/ object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
                /*0x23173f0*/ bool IsDefined(System.Type attributeType, bool inherit);
            }

            class MemberAliasPropertyInfo : System.Reflection.PropertyInfo
            {
                static string FakeNameSeparatorString = "+";
                /*0x10*/ System.Reflection.PropertyInfo aliasedProperty;
                /*0x18*/ string mangledName;

                /*0x2317418*/ MemberAliasPropertyInfo(System.Reflection.PropertyInfo prop, string namePrefix);
                /*0x23174ac*/ MemberAliasPropertyInfo(System.Reflection.PropertyInfo prop, string namePrefix, string separatorString);
                /*0x2317518*/ System.Reflection.PropertyInfo get_AliasedProperty();
                /*0x2317520*/ System.Reflection.Module get_Module();
                /*0x2317544*/ int get_MetadataToken();
                /*0x2317568*/ string get_Name();
                /*0x2317570*/ System.Type get_DeclaringType();
                /*0x2317594*/ System.Type get_ReflectedType();
                /*0x23175b8*/ System.Type get_PropertyType();
                /*0x23175dc*/ System.Reflection.PropertyAttributes get_Attributes();
                /*0x2317600*/ bool get_CanRead();
                /*0x2317624*/ bool get_CanWrite();
                /*0x2317648*/ object[] GetCustomAttributes(bool inherit);
                /*0x2317670*/ object[] GetCustomAttributes(System.Type attributeType, bool inherit);
                /*0x2317698*/ bool IsDefined(System.Type attributeType, bool inherit);
                /*0x23176c0*/ System.Reflection.MethodInfo[] GetAccessors(bool nonPublic);
                /*0x23176e8*/ System.Reflection.MethodInfo GetGetMethod(bool nonPublic);
                /*0x2317710*/ System.Reflection.ParameterInfo[] GetIndexParameters();
                /*0x2317734*/ System.Reflection.MethodInfo GetSetMethod(bool nonPublic);
                /*0x231775c*/ object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
                /*0x2317780*/ void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
            }

            class ReferenceEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
            {
                static /*0x0*/ Sirenix.Serialization.Utilities.ReferenceEqualityComparer<T> Default;

                static ReferenceEqualityComparer();
                ReferenceEqualityComparer();
                bool Equals(T x, T y);
                int GetHashCode(T obj);
            }

            class UnityVersion
            {
                static /*0x0*/ int Major;
                static /*0x4*/ int Minor;

                static /*0x23177a4*/ UnityVersion();
                static /*0x2317bec*/ void EnsureLoaded();
                static /*0x2317bf0*/ bool IsVersionOrGreater(int major, int minor);
            }

            namespace Unsafe
            {
                class UnsafeUtilities
                {
                    static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength);
                    static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset);
                    static byte[] StructArrayToBytes<T>(T[] array);
                    static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset);
                    static /*0x2317cb0*/ string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport);
                    static /*0x2318104*/ int StringToBytes(byte[] buffer, string value, bool needs16BitSupport);
                    static /*0x2318544*/ void MemoryCopy(void* from, void* to, int bytes);
                    static /*0x231859c*/ void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset);

                    struct Struct256Bit
                    {
                        /*0x10*/ decimal d1;
                        /*0x20*/ decimal d2;
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B;

    static /*0x2318810*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=256
    {
    }
}
