class <Module>
{
}

class KaLogEngineWriter : UnityEngineLogWriter
{
    /*0x24ac5f8*/ KaLogEngineWriter();
    /*0x24ac560*/ void InitLogWriter();
    /*0x24ac564*/ bool IsLogLevelValid(int level);
    /*0x24ac56c*/ bool IsLogWarning(int level);
}

class KaLogEx
{
    static int LogCore = 501;
    static int LogNet = 502;
    static int LogUI = 503;
    static int LogInput = 504;
    static int LogInGame = 505;
    static int LogDungeon = 506;
    static int LogSkill = 507;
    static int LogSubobj = 508;
    static int LogZY = 600;
    static int LogZn = 601;
    static /*0x0*/ bool IsDev;
    static /*0x8*/ LogWritersRoot RootWriters;

    static /*0x24ac600*/ void InitKaLog();
}

class LogWritersRoot : KaLogWriters
{
    /*0x18*/ int mCurLogLevelMax;

    /*0x24ac954*/ LogWritersRoot();
    /*0x24aca2c*/ int get_LogLevelMax();
    /*0x24aca34*/ void set_LogLevelMax(int value);
    /*0x24aca3c*/ bool IsLogLevelValid(int level);
}

enum ELogPlatform
{
    Android = 0,
    IOS = 1,
    Win = 2,
    Editor = 3,
    WinEditor = 4,
}

class KaLogFileWriter : IKaLogWriter
{
    static string PATH_END = "/";
    static int MAX_LOG_ENTRY_NUM = 10;
    /*0x10*/ ELogPlatform mLogPlatform;
    /*0x18*/ System.IO.StreamWriter mStreamWriter;
    /*0x20*/ bool mHasInit;
    /*0x28*/ string mDirectoryName;

    static /*0x24ad1f0*/ string[] GetLogFiles(string logFilePath);
    /*0x24ac9bc*/ KaLogFileWriter(ELogPlatform platform);
    /*0x24aca74*/ void InitLogWriter();
    /*0x24ad240*/ void WriteLog(string line, int level);
    /*0x24ad768*/ bool IsLogLevelValid(int level);
    /*0x24ad140*/ string GetLogDir();
}

enum EffectQualityType
{
    High = 0,
    Middle = 1,
    Low = 2,
}

class ParticleEffectProfilerData
{
    /*0x10*/ string effectName;
    /*0x18*/ bool loop;
    /*0x1c*/ int time;
    /*0x20*/ string memorySize;
    /*0x28*/ int textureCount;
    /*0x2c*/ int particleSystemCount;
    /*0x30*/ int materialCount;
    /*0x34*/ int maxDrawCall;
    /*0x38*/ int maxParticleCount;
    /*0x40*/ double maxOverDraw;

    /*0x24ad770*/ ParticleEffectProfilerData();
}

class ParticleEffectProfilerDataList
{
    /*0x10*/ System.Collections.Generic.List<ParticleEffectProfilerData> particleEffectProfilerDataList;

    /*0x24ad778*/ ParticleEffectProfilerDataList();
    /*0x24ad7f8*/ void Add(ParticleEffectProfilerData data);
}

namespace LitJson
{
    enum JsonType
    {
        None = 0,
        Object = 1,
        Array = 2,
        String = 3,
        Int = 4,
        Long = 5,
        Double = 6,
        Boolean = 7,
    }

    interface IJsonWrapper : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Collections.IDictionary
    {
        bool get_IsArray();
        bool get_IsBoolean();
        bool get_IsDouble();
        bool get_IsInt();
        bool get_IsLong();
        bool get_IsObject();
        bool get_IsString();
        bool GetBoolean();
        double GetDouble();
        int GetInt();
        LitJson.JsonType GetJsonType();
        long GetLong();
        string GetString();
        void SetBoolean(bool val);
        void SetDouble(double val);
        void SetInt(int val);
        void SetJsonType(LitJson.JsonType type);
        void SetLong(long val);
        void SetString(string val);
        string ToJson();
        void ToJson(LitJson.JsonWriter writer);
    }

    class JsonData : LitJson.IJsonWrapper, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Collections.IDictionary, System.IEquatable<LitJson.JsonData>
    {
        /*0x10*/ System.Collections.Generic.IList<LitJson.JsonData> inst_array;
        /*0x18*/ bool inst_boolean;
        /*0x20*/ double inst_double;
        /*0x28*/ int inst_int;
        /*0x30*/ long inst_long;
        /*0x38*/ System.Collections.Generic.IDictionary<string, LitJson.JsonData> inst_object;
        /*0x40*/ string inst_string;
        /*0x48*/ string json;
        /*0x50*/ LitJson.JsonType type;
        /*0x58*/ System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, LitJson.JsonData>> object_list;

        static /*0x24afc50*/ LitJson.JsonData op_Implicit(bool data);
        static /*0x24afcc0*/ LitJson.JsonData op_Implicit(double data);
        static /*0x24afd34*/ LitJson.JsonData op_Implicit(int data);
        static /*0x24afda0*/ LitJson.JsonData op_Implicit(long data);
        static /*0x24afe0c*/ LitJson.JsonData op_Implicit(string data);
        static /*0x24afe78*/ bool op_Explicit(LitJson.JsonData data);
        static /*0x24afee8*/ double op_Explicit(LitJson.JsonData data);
        static /*0x24aff58*/ int op_Explicit(LitJson.JsonData data);
        static /*0x24affd8*/ long op_Explicit(LitJson.JsonData data);
        static /*0x24b0058*/ string op_Explicit(LitJson.JsonData data);
        static /*0x24b1574*/ void WriteJson(LitJson.IJsonWrapper obj, LitJson.JsonWriter writer);
        /*0x24af934*/ JsonData();
        /*0x24af93c*/ JsonData(bool boolean);
        /*0x24af96c*/ JsonData(double number);
        /*0x24af99c*/ JsonData(int number);
        /*0x24af9cc*/ JsonData(long number);
        /*0x24af9fc*/ JsonData(object obj);
        /*0x24afc20*/ JsonData(string str);
        /*0x24ad8a0*/ int get_Count();
        /*0x24ada20*/ bool get_IsArray();
        /*0x24ada30*/ bool get_IsBoolean();
        /*0x24ada40*/ bool get_IsDouble();
        /*0x24ada50*/ bool get_IsInt();
        /*0x24ada60*/ bool get_IsLong();
        /*0x24ada70*/ bool get_IsObject();
        /*0x24ada80*/ bool get_IsString();
        /*0x24ada90*/ System.Collections.Generic.ICollection<string> get_Keys();
        /*0x24adcc8*/ bool ContainsKey(string key);
        /*0x24addf4*/ int System.Collections.ICollection.get_Count();
        /*0x24addf8*/ bool System.Collections.ICollection.get_IsSynchronized();
        /*0x24adea4*/ object System.Collections.ICollection.get_SyncRoot();
        /*0x24adf50*/ bool System.Collections.IDictionary.get_IsFixedSize();
        /*0x24adffc*/ bool System.Collections.IDictionary.get_IsReadOnly();
        /*0x24ae0a8*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
        /*0x24ae474*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
        /*0x24ae840*/ bool LitJson.IJsonWrapper.get_IsArray();
        /*0x24ae850*/ bool LitJson.IJsonWrapper.get_IsBoolean();
        /*0x24ae860*/ bool LitJson.IJsonWrapper.get_IsDouble();
        /*0x24ae870*/ bool LitJson.IJsonWrapper.get_IsInt();
        /*0x24ae880*/ bool LitJson.IJsonWrapper.get_IsLong();
        /*0x24ae890*/ bool LitJson.IJsonWrapper.get_IsObject();
        /*0x24ae8a0*/ bool LitJson.IJsonWrapper.get_IsString();
        /*0x24ae8b0*/ bool System.Collections.IList.get_IsFixedSize();
        /*0x24aea94*/ bool System.Collections.IList.get_IsReadOnly();
        /*0x24aeb40*/ object System.Collections.IDictionary.get_Item(object key);
        /*0x24aebf0*/ void System.Collections.IDictionary.set_Item(object key, object value);
        /*0x24af0e0*/ object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx);
        /*0x24af1a4*/ void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value);
        /*0x24af3b0*/ object System.Collections.IList.get_Item(int index);
        /*0x24af460*/ void System.Collections.IList.set_Item(int index, object value);
        /*0x24af734*/ LitJson.JsonData get_Item(string prop_name);
        /*0x24aed5c*/ void set_Item(string prop_name, LitJson.JsonData value);
        /*0x24af7e4*/ LitJson.JsonData get_Item(int index);
        /*0x24af498*/ void set_Item(int index, LitJson.JsonData value);
        /*0x24b00c8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
        /*0x24b0188*/ void System.Collections.IDictionary.Add(object key, object value);
        /*0x24b0348*/ void System.Collections.IDictionary.Clear();
        /*0x24b0474*/ bool System.Collections.IDictionary.Contains(object key);
        /*0x24b0528*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
        /*0x24b05c0*/ void System.Collections.IDictionary.Remove(object key);
        /*0x24b0844*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x24b08ec*/ bool LitJson.IJsonWrapper.GetBoolean();
        /*0x24b0954*/ double LitJson.IJsonWrapper.GetDouble();
        /*0x24b09bc*/ int LitJson.IJsonWrapper.GetInt();
        /*0x24b0a24*/ long LitJson.IJsonWrapper.GetLong();
        /*0x24b0a8c*/ string LitJson.IJsonWrapper.GetString();
        /*0x24b0af4*/ void LitJson.IJsonWrapper.SetBoolean(bool val);
        /*0x24b0b0c*/ void LitJson.IJsonWrapper.SetDouble(double val);
        /*0x24b0b20*/ void LitJson.IJsonWrapper.SetInt(int val);
        /*0x24b0b34*/ void LitJson.IJsonWrapper.SetLong(long val);
        /*0x24b0b48*/ void LitJson.IJsonWrapper.SetString(string val);
        /*0x24b0b58*/ string LitJson.IJsonWrapper.ToJson();
        /*0x24b0c10*/ void LitJson.IJsonWrapper.ToJson(LitJson.JsonWriter writer);
        /*0x24b0c44*/ int System.Collections.IList.Add(object value);
        /*0x24b0d0c*/ void System.Collections.IList.Clear();
        /*0x24b0dc0*/ bool System.Collections.IList.Contains(object value);
        /*0x24b0e74*/ int System.Collections.IList.IndexOf(object value);
        /*0x24b0f28*/ void System.Collections.IList.Insert(int index, object value);
        /*0x24b0ff4*/ void System.Collections.IList.Remove(object value);
        /*0x24b10b0*/ void System.Collections.IList.RemoveAt(int index);
        /*0x24b116c*/ System.Collections.IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator();
        /*0x24b127c*/ void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value);
        /*0x24b13c8*/ void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx);
        /*0x24ad94c*/ System.Collections.ICollection EnsureCollection();
        /*0x24adb3c*/ System.Collections.IDictionary EnsureDictionary();
        /*0x24ae95c*/ System.Collections.IList EnsureList();
        /*0x24aeccc*/ LitJson.JsonData ToJsonData(object obj);
        /*0x24b0c48*/ int Add(object value);
        /*0x24b2a34*/ bool Remove(object obj);
        /*0x24b2db8*/ void Clear();
        /*0x24b2ec8*/ bool Equals(LitJson.JsonData x);
        /*0x24b3010*/ LitJson.JsonType GetJsonType();
        /*0x24b3018*/ void SetJsonType(LitJson.JsonType type);
        /*0x24b0b5c*/ string ToJson();
        /*0x24b0c14*/ void ToJson(LitJson.JsonWriter writer);
        /*0x24b31fc*/ string ToString();
    }

    class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
    {
        /*0x10*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, LitJson.JsonData>> list_enumerator;

        /*0x24b1254*/ OrderedDictionaryEnumerator(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, LitJson.JsonData>> enumerator);
        /*0x24b32f0*/ object get_Current();
        /*0x24b3354*/ System.Collections.DictionaryEntry get_Entry();
        /*0x24b343c*/ object get_Key();
        /*0x24b34e8*/ object get_Value();
        /*0x24b359c*/ bool MoveNext();
        /*0x24b363c*/ void Reset();
    }

    class JsonException : System.ApplicationException
    {
        /*0x24b36e0*/ JsonException();
        /*0x24b36e8*/ JsonException(LitJson.ParserToken token);
        /*0x24b3784*/ JsonException(LitJson.ParserToken token, System.Exception inner_exception);
        /*0x24b3828*/ JsonException(int c);
        /*0x24b38c4*/ JsonException(int c, System.Exception inner_exception);
        /*0x24b3968*/ JsonException(string message);
        /*0x24b3970*/ JsonException(string message, System.Exception inner_exception);
    }

    struct PropertyMetadata
    {
        /*0x10*/ System.Reflection.MemberInfo Info;
        /*0x18*/ bool IsField;
        /*0x20*/ System.Type Type;
    }

    struct ArrayMetadata
    {
        /*0x10*/ System.Type element_type;
        /*0x18*/ bool is_array;
        /*0x19*/ bool is_list;

        /*0x24b3978*/ System.Type get_ElementType();
        /*0x24b3a20*/ void set_ElementType(System.Type value);
        /*0x24b3a28*/ bool get_IsArray();
        /*0x24b3a30*/ void set_IsArray(bool value);
        /*0x24b3a3c*/ bool get_IsList();
        /*0x24b3a44*/ void set_IsList(bool value);
    }

    struct ObjectMetadata
    {
        /*0x10*/ System.Type element_type;
        /*0x18*/ bool is_dictionary;
        /*0x20*/ System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> properties;

        /*0x24b3a50*/ System.Type get_ElementType();
        /*0x24b3af8*/ void set_ElementType(System.Type value);
        /*0x24b3b00*/ bool get_IsDictionary();
        /*0x24b3b08*/ void set_IsDictionary(bool value);
        /*0x24b3b14*/ System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> get_Properties();
        /*0x24b3b1c*/ void set_Properties(System.Collections.Generic.IDictionary<string, LitJson.PropertyMetadata> value);
    }

    class ExporterFunc : System.MulticastDelegate
    {
        /*0x24b3b24*/ ExporterFunc(object object, nint method);
        /*0x24b3c54*/ void Invoke(object obj, LitJson.JsonWriter writer);
        /*0x24b3c68*/ System.IAsyncResult BeginInvoke(object obj, LitJson.JsonWriter writer, System.AsyncCallback callback, object object);
        /*0x24b3c90*/ void EndInvoke(System.IAsyncResult result);
    }

    class ExporterFunc<T> : System.MulticastDelegate
    {
        ExporterFunc(object object, nint method);
        void Invoke(T obj, LitJson.JsonWriter writer);
        System.IAsyncResult BeginInvoke(T obj, LitJson.JsonWriter writer, System.AsyncCallback callback, object object);
        void EndInvoke(System.IAsyncResult result);
    }

    class ImporterFunc : System.MulticastDelegate
    {
        /*0x24b3c9c*/ ImporterFunc(object object, nint method);
        /*0x24b3dc8*/ object Invoke(object input);
        /*0x24b3ddc*/ System.IAsyncResult BeginInvoke(object input, System.AsyncCallback callback, object object);
        /*0x24b3dfc*/ object EndInvoke(System.IAsyncResult result);
    }

    class ImporterFunc<TJson, TValue> : System.MulticastDelegate
    {
        ImporterFunc(object object, nint method);
        TValue Invoke(TJson input);
        System.IAsyncResult BeginInvoke(TJson input, System.AsyncCallback callback, object object);
        TValue EndInvoke(System.IAsyncResult result);
    }

    class WrapperFactory : System.MulticastDelegate
    {
        /*0x24b3e08*/ WrapperFactory(object object, nint method);
        /*0x24b3ec4*/ LitJson.IJsonWrapper Invoke();
        /*0x24b3ed8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x24b3ef8*/ LitJson.IJsonWrapper EndInvoke(System.IAsyncResult result);
    }

    class JsonMapper
    {
        static /*0x0*/ int max_nesting_depth;
        static /*0x8*/ System.IFormatProvider datetime_format;
        static /*0x10*/ System.Collections.Generic.IDictionary<System.Type, LitJson.ExporterFunc> base_exporters_table;
        static /*0x18*/ System.Collections.Generic.IDictionary<System.Type, LitJson.ExporterFunc> custom_exporters_table;
        static /*0x20*/ System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, LitJson.ImporterFunc>> base_importers_table;
        static /*0x28*/ System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, LitJson.ImporterFunc>> custom_importers_table;
        static /*0x30*/ System.Collections.Generic.IDictionary<System.Type, LitJson.ArrayMetadata> array_metadata;
        static /*0x38*/ object array_metadata_lock;
        static /*0x40*/ System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, System.Reflection.MethodInfo>> conv_ops;
        static /*0x48*/ object conv_ops_lock;
        static /*0x50*/ System.Collections.Generic.IDictionary<System.Type, LitJson.ObjectMetadata> object_metadata;
        static /*0x58*/ object object_metadata_lock;
        static /*0x60*/ System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IList<LitJson.PropertyMetadata>> type_properties;
        static /*0x68*/ object type_properties_lock;
        static /*0x70*/ LitJson.JsonWriter static_writer;
        static /*0x78*/ object static_writer_lock;

        static /*0x24b3f04*/ JsonMapper();
        static /*0x24b5eb0*/ void AddArrayMetadata(System.Type type);
        static /*0x24b633c*/ void AddObjectMetadata(System.Type type);
        static /*0x24b6a34*/ void AddTypeProperties(System.Type type);
        static /*0x24b6f5c*/ System.Reflection.MethodInfo GetConvOp(System.Type t1, System.Type t2);
        static /*0x24b77dc*/ object ReadValue(System.Type inst_type, LitJson.JsonReader reader);
        static /*0x24b8cc4*/ LitJson.IJsonWrapper ReadValue(LitJson.WrapperFactory factory, LitJson.JsonReader reader);
        static /*0x24b8bc4*/ void ReadSkip(LitJson.JsonReader reader);
        static /*0x24b4340*/ void RegisterBaseExporters();
        static /*0x24b5014*/ void RegisterBaseImporters();
        static /*0x24b9384*/ void RegisterImporter(System.Collections.Generic.IDictionary<System.Type, System.Collections.Generic.IDictionary<System.Type, LitJson.ImporterFunc>> table, System.Type json_type, System.Type value_type, LitJson.ImporterFunc importer);
        static /*0x24b95c8*/ void WriteValue(object obj, LitJson.JsonWriter writer, bool writer_is_private, int depth);
        static /*0x24bb008*/ string ToJson(object obj, bool prettyPrint);
        static /*0x24bb270*/ void ToJson(object obj, LitJson.JsonWriter writer);
        static /*0x24bb2dc*/ LitJson.JsonData ToObject(LitJson.JsonReader reader);
        static /*0x24bb428*/ LitJson.JsonData ToObject(System.IO.TextReader reader);
        static /*0x24bb5ac*/ LitJson.JsonData ToObject(string json);
        static T ToObject<T>(LitJson.JsonReader reader);
        static T ToObject<T>(System.IO.TextReader reader);
        static T ToObject<T>(string json);
        static /*0x24bb78c*/ object ToObject(string json, System.Type ConvertType);
        static /*0x24b9320*/ LitJson.IJsonWrapper ToWrapper(LitJson.WrapperFactory factory, LitJson.JsonReader reader);
        static /*0x24bb6f8*/ LitJson.IJsonWrapper ToWrapper(LitJson.WrapperFactory factory, string json);
        static void RegisterExporter<T>(LitJson.ExporterFunc<T> exporter);
        static void RegisterImporter<TJson, TValue>(LitJson.ImporterFunc<TJson, TValue> importer);
        static /*0x24bb898*/ void UnregisterExporters();
        static /*0x24bb964*/ void UnregisterImporters();
        /*0x24bba30*/ JsonMapper();

        class <>c
        {
            static /*0x0*/ LitJson.JsonMapper.<> <>9;
            static /*0x8*/ LitJson.WrapperFactory <>9__23_0;
            static /*0x10*/ LitJson.ExporterFunc <>9__24_0;
            static /*0x18*/ LitJson.ExporterFunc <>9__24_1;
            static /*0x20*/ LitJson.ExporterFunc <>9__24_2;
            static /*0x28*/ LitJson.ExporterFunc <>9__24_3;
            static /*0x30*/ LitJson.ExporterFunc <>9__24_4;
            static /*0x38*/ LitJson.ExporterFunc <>9__24_5;
            static /*0x40*/ LitJson.ExporterFunc <>9__24_6;
            static /*0x48*/ LitJson.ExporterFunc <>9__24_7;
            static /*0x50*/ LitJson.ExporterFunc <>9__24_8;
            static /*0x58*/ LitJson.ExporterFunc <>9__24_9;
            static /*0x60*/ LitJson.ImporterFunc <>9__25_0;
            static /*0x68*/ LitJson.ImporterFunc <>9__25_1;
            static /*0x70*/ LitJson.ImporterFunc <>9__25_2;
            static /*0x78*/ LitJson.ImporterFunc <>9__25_3;
            static /*0x80*/ LitJson.ImporterFunc <>9__25_4;
            static /*0x88*/ LitJson.ImporterFunc <>9__25_5;
            static /*0x90*/ LitJson.ImporterFunc <>9__25_6;
            static /*0x98*/ LitJson.ImporterFunc <>9__25_7;
            static /*0xa0*/ LitJson.ImporterFunc <>9__25_8;
            static /*0xa8*/ LitJson.ImporterFunc <>9__25_9;
            static /*0xb0*/ LitJson.ImporterFunc <>9__25_10;
            static /*0xb8*/ LitJson.ImporterFunc <>9__25_11;
            static /*0xc0*/ LitJson.ImporterFunc <>9__25_12;
            static /*0xc8*/ LitJson.ImporterFunc <>9__25_13;
            static /*0xd0*/ LitJson.ImporterFunc <>9__25_14;
            static /*0xd8*/ LitJson.WrapperFactory <>9__30_0;
            static /*0xe0*/ LitJson.WrapperFactory <>9__31_0;
            static /*0xe8*/ LitJson.WrapperFactory <>9__32_0;

            static /*0x24bba38*/ <>c();
            /*0x24bba9c*/ <>c();
            /*0x24bbaa4*/ LitJson.IJsonWrapper <ReadSkip>b__23_0();
            /*0x24bbb08*/ void <RegisterBaseExporters>b__24_0(object obj, LitJson.JsonWriter writer);
            /*0x24bbbbc*/ void <RegisterBaseExporters>b__24_1(object obj, LitJson.JsonWriter writer);
            /*0x24bbc70*/ void <RegisterBaseExporters>b__24_2(object obj, LitJson.JsonWriter writer);
            /*0x24bbd5c*/ void <RegisterBaseExporters>b__24_3(object obj, LitJson.JsonWriter writer);
            /*0x24bbeb4*/ void <RegisterBaseExporters>b__24_4(object obj, LitJson.JsonWriter writer);
            /*0x24bbf68*/ void <RegisterBaseExporters>b__24_5(object obj, LitJson.JsonWriter writer);
            /*0x24bc01c*/ void <RegisterBaseExporters>b__24_6(object obj, LitJson.JsonWriter writer);
            /*0x24bc0d0*/ void <RegisterBaseExporters>b__24_7(object obj, LitJson.JsonWriter writer);
            /*0x24bc184*/ void <RegisterBaseExporters>b__24_8(object obj, LitJson.JsonWriter writer);
            /*0x24bc200*/ void <RegisterBaseExporters>b__24_9(object obj, LitJson.JsonWriter writer);
            /*0x24bc2f4*/ object <RegisterBaseImporters>b__25_0(object input);
            /*0x24bc3c4*/ object <RegisterBaseImporters>b__25_1(object input);
            /*0x24bc494*/ object <RegisterBaseImporters>b__25_2(object input);
            /*0x24bc564*/ object <RegisterBaseImporters>b__25_3(object input);
            /*0x24bc634*/ object <RegisterBaseImporters>b__25_4(object input);
            /*0x24bc704*/ object <RegisterBaseImporters>b__25_5(object input);
            /*0x24bc7d4*/ object <RegisterBaseImporters>b__25_6(object input);
            /*0x24bc8a4*/ object <RegisterBaseImporters>b__25_7(object input);
            /*0x24bc970*/ object <RegisterBaseImporters>b__25_8(object input);
            /*0x24bca3c*/ object <RegisterBaseImporters>b__25_9(object input);
            /*0x24bcb34*/ object <RegisterBaseImporters>b__25_10(object input);
            /*0x24bcc00*/ object <RegisterBaseImporters>b__25_11(object input);
            /*0x24bccd0*/ object <RegisterBaseImporters>b__25_12(object input);
            /*0x24bcd94*/ object <RegisterBaseImporters>b__25_13(object input);
            /*0x24bce90*/ object <RegisterBaseImporters>b__25_14(object input);
            /*0x24bcf78*/ LitJson.IJsonWrapper <ToObject>b__30_0();
            /*0x24bcfd4*/ LitJson.IJsonWrapper <ToObject>b__31_0();
            /*0x24bd030*/ LitJson.IJsonWrapper <ToObject>b__32_0();
        }

        class <>c__DisplayClass39_0<T>
        {
            /*0x0*/ LitJson.ExporterFunc<T> exporter;

            <>c__DisplayClass39_0();
            void <RegisterExporter>b__0(object obj, LitJson.JsonWriter writer);
        }

        class <>c__DisplayClass40_0<TJson, TValue>
        {
            /*0x0*/ LitJson.ImporterFunc<TJson, TValue> importer;

            <>c__DisplayClass40_0();
            object <RegisterImporter>b__0(object input);
        }
    }

    class JsonMockWrapper : LitJson.IJsonWrapper, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Collections.IDictionary
    {
        /*0x24bbb00*/ JsonMockWrapper();
        /*0x24bd08c*/ bool get_IsArray();
        /*0x24bd094*/ bool get_IsBoolean();
        /*0x24bd09c*/ bool get_IsDouble();
        /*0x24bd0a4*/ bool get_IsInt();
        /*0x24bd0ac*/ bool get_IsLong();
        /*0x24bd0b4*/ bool get_IsObject();
        /*0x24bd0bc*/ bool get_IsString();
        /*0x24bd0c4*/ bool GetBoolean();
        /*0x24bd0cc*/ double GetDouble();
        /*0x24bd0d4*/ int GetInt();
        /*0x24bd0dc*/ LitJson.JsonType GetJsonType();
        /*0x24bd0e4*/ long GetLong();
        /*0x24bd0ec*/ string GetString();
        /*0x24bd12c*/ void SetBoolean(bool val);
        /*0x24bd130*/ void SetDouble(double val);
        /*0x24bd134*/ void SetInt(int val);
        /*0x24bd138*/ void SetJsonType(LitJson.JsonType type);
        /*0x24bd13c*/ void SetLong(long val);
        /*0x24bd140*/ void SetString(string val);
        /*0x24bd144*/ string ToJson();
        /*0x24bd184*/ void ToJson(LitJson.JsonWriter writer);
        /*0x24bd188*/ bool System.Collections.IList.get_IsFixedSize();
        /*0x24bd190*/ bool System.Collections.IList.get_IsReadOnly();
        /*0x24bd198*/ object System.Collections.IList.get_Item(int index);
        /*0x24bd1a0*/ void System.Collections.IList.set_Item(int index, object value);
        /*0x24bd1a4*/ int System.Collections.IList.Add(object value);
        /*0x24bd1ac*/ void System.Collections.IList.Clear();
        /*0x24bd1b0*/ bool System.Collections.IList.Contains(object value);
        /*0x24bd1b8*/ int System.Collections.IList.IndexOf(object value);
        /*0x24bd1c0*/ void System.Collections.IList.Insert(int i, object v);
        /*0x24bd1c4*/ void System.Collections.IList.Remove(object value);
        /*0x24bd1c8*/ void System.Collections.IList.RemoveAt(int index);
        /*0x24bd1cc*/ int System.Collections.ICollection.get_Count();
        /*0x24bd1d4*/ bool System.Collections.ICollection.get_IsSynchronized();
        /*0x24bd1dc*/ object System.Collections.ICollection.get_SyncRoot();
        /*0x24bd1e4*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
        /*0x24bd1e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x24bd1f0*/ bool System.Collections.IDictionary.get_IsFixedSize();
        /*0x24bd1f8*/ bool System.Collections.IDictionary.get_IsReadOnly();
        /*0x24bd200*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
        /*0x24bd208*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
        /*0x24bd210*/ object System.Collections.IDictionary.get_Item(object key);
        /*0x24bd218*/ void System.Collections.IDictionary.set_Item(object key, object value);
        /*0x24bd21c*/ void System.Collections.IDictionary.Add(object k, object v);
        /*0x24bd220*/ void System.Collections.IDictionary.Clear();
        /*0x24bd224*/ bool System.Collections.IDictionary.Contains(object key);
        /*0x24bd22c*/ void System.Collections.IDictionary.Remove(object key);
        /*0x24bd230*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
        /*0x24bd238*/ object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx);
        /*0x24bd240*/ void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value);
        /*0x24bd244*/ System.Collections.IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator();
        /*0x24bd24c*/ void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v);
        /*0x24bd250*/ void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i);
    }

    enum JsonToken
    {
        None = 0,
        ObjectStart = 1,
        PropertyName = 2,
        ObjectEnd = 3,
        ArrayStart = 4,
        ArrayEnd = 5,
        Int = 6,
        Long = 7,
        Double = 8,
        String = 9,
        Boolean = 10,
        Null = 11,
    }

    class JsonReader
    {
        static /*0x0*/ System.Collections.Generic.IDictionary<int, System.Collections.Generic.IDictionary<int, System.Int32[]>> parse_table;
        /*0x10*/ System.Collections.Generic.Stack<int> automaton_stack;
        /*0x18*/ int current_input;
        /*0x1c*/ int current_symbol;
        /*0x20*/ bool end_of_json;
        /*0x21*/ bool end_of_input;
        /*0x28*/ LitJson.Lexer lexer;
        /*0x30*/ bool parser_in_string;
        /*0x31*/ bool parser_return;
        /*0x32*/ bool read_started;
        /*0x38*/ System.IO.TextReader reader;
        /*0x40*/ bool reader_is_owned;
        /*0x41*/ bool skip_non_members;
        /*0x48*/ object token_value;
        /*0x50*/ LitJson.JsonToken token;

        static /*0x24bd300*/ JsonReader();
        static /*0x24bd34c*/ System.Collections.Generic.IDictionary<int, System.Collections.Generic.IDictionary<int, System.Int32[]>> PopulateParseTable();
        static /*0x24bddf0*/ void TableAddCol(System.Collections.Generic.IDictionary<int, System.Collections.Generic.IDictionary<int, System.Int32[]>> parse_table, LitJson.ParserToken row, int col, int[] symbols);
        static /*0x24bdcfc*/ void TableAddRow(System.Collections.Generic.IDictionary<int, System.Collections.Generic.IDictionary<int, System.Int32[]>> parse_table, LitJson.ParserToken rule);
        /*0x24bb820*/ JsonReader(string json_text);
        /*0x24bb5a4*/ JsonReader(System.IO.TextReader reader);
        /*0x24bdab4*/ JsonReader(System.IO.TextReader reader, bool owned);
        /*0x24bd254*/ bool get_AllowComments();
        /*0x24bd270*/ void set_AllowComments(bool value);
        /*0x24bd290*/ bool get_AllowSingleQuotedStrings();
        /*0x24bd2ac*/ void set_AllowSingleQuotedStrings(bool value);
        /*0x24bd2cc*/ bool get_SkipNonMembers();
        /*0x24bd2d4*/ void set_SkipNonMembers(bool value);
        /*0x24bd2e0*/ bool get_EndOfInput();
        /*0x24bd2e8*/ bool get_EndOfJson();
        /*0x24bd2f0*/ LitJson.JsonToken get_Token();
        /*0x24bd2f8*/ object get_Value();
        /*0x24bdf24*/ void ProcessNumber(string number);
        /*0x24be160*/ void ProcessSymbol();
        /*0x24be2ec*/ bool ReadToken();
        /*0x24be504*/ void Close();
        /*0x24b8760*/ bool Read();
    }

    enum Condition
    {
        InArray = 0,
        InObject = 1,
        NotAProperty = 2,
        Property = 3,
        Value = 4,
    }

    class WriterContext
    {
        /*0x10*/ int Count;
        /*0x14*/ bool InArray;
        /*0x15*/ bool InObject;
        /*0x16*/ bool ExpectingValue;
        /*0x18*/ int Padding;

        /*0x24be5c0*/ WriterContext();
    }

    class JsonWriter
    {
        static /*0x0*/ System.Globalization.NumberFormatInfo number_format;
        /*0x10*/ LitJson.WriterContext context;
        /*0x18*/ System.Collections.Generic.Stack<LitJson.WriterContext> ctx_stack;
        /*0x20*/ bool has_reached_end;
        /*0x28*/ char[] hex_seq;
        /*0x30*/ int indentation;
        /*0x34*/ int indent_value;
        /*0x38*/ System.Text.StringBuilder inst_string_builder;
        /*0x40*/ bool pretty_print;
        /*0x41*/ bool validate;
        /*0x42*/ bool lower_case_properties;
        /*0x48*/ System.IO.TextWriter writer;

        static /*0x24be628*/ JsonWriter();
        static /*0x24be998*/ void IntToHex(int n, char[] hex);
        /*0x24b429c*/ JsonWriter();
        /*0x24be788*/ JsonWriter(System.Text.StringBuilder sb);
        /*0x24b3180*/ JsonWriter(System.IO.TextWriter writer);
        /*0x24be5c8*/ int get_IndentValue();
        /*0x24be5d0*/ void set_IndentValue(int value);
        /*0x24be5e4*/ bool get_PrettyPrint();
        /*0x24be5ec*/ void set_PrettyPrint(bool value);
        /*0x24be5f8*/ System.IO.TextWriter get_TextWriter();
        /*0x24be600*/ bool get_Validate();
        /*0x24be608*/ void set_Validate(bool value);
        /*0x24be614*/ bool get_LowerCaseProperties();
        /*0x24be61c*/ void set_LowerCaseProperties(bool value);
        /*0x24be7fc*/ void DoValidation(LitJson.Condition cond);
        /*0x24be678*/ void Init();
        /*0x24bea10*/ void Indent();
        /*0x24bea28*/ void Put(string str);
        /*0x24beab4*/ void PutNewline();
        /*0x24beabc*/ void PutNewline(bool add_comma);
        /*0x24beb50*/ void PutString(string str);
        /*0x24bee58*/ void Unindent();
        /*0x24bee70*/ string ToString();
        /*0x24bb190*/ void Reset();
        /*0x24b21ec*/ void Write(bool boolean);
        /*0x24bbdd8*/ void Write(decimal number);
        /*0x24b2284*/ void Write(double number);
        /*0x24bae60*/ void Write(float number);
        /*0x24b23c0*/ void Write(int number);
        /*0x24b2494*/ void Write(long number);
        /*0x24b2160*/ void Write(string str);
        /*0x24baf34*/ void Write(ulong number);
        /*0x24b264c*/ void WriteArrayEnd();
        /*0x24b2568*/ void WriteArrayStart();
        /*0x24b2948*/ void WriteObjectEnd();
        /*0x24b2738*/ void WriteObjectStart();
        /*0x24b281c*/ void WritePropertyName(string property_name);
    }

    class FsmContext
    {
        /*0x10*/ bool Return;
        /*0x14*/ int NextState;
        /*0x18*/ LitJson.Lexer L;
        /*0x20*/ int StateStack;

        /*0x24beed8*/ FsmContext();
    }

    class Lexer
    {
        static /*0x0*/ int[] fsm_return_table;
        static /*0x8*/ LitJson.Lexer.StateHandler[] fsm_handler_table;
        /*0x10*/ bool allow_comments;
        /*0x11*/ bool allow_single_quoted_strings;
        /*0x12*/ bool end_of_input;
        /*0x18*/ LitJson.FsmContext fsm_context;
        /*0x20*/ int input_buffer;
        /*0x24*/ int input_char;
        /*0x28*/ System.IO.TextReader reader;
        /*0x30*/ int state;
        /*0x38*/ System.Text.StringBuilder string_buffer;
        /*0x40*/ string string_value;
        /*0x48*/ int token;
        /*0x4c*/ int unichar;

        static /*0x24bef20*/ Lexer();
        static /*0x24bf978*/ int HexValue(int digit);
        static /*0x24bef68*/ void PopulateFsmTables(ref LitJson.Lexer.StateHandler[] fsm_handler_table, ref int[] fsm_return_table);
        static /*0x24bfb28*/ char ProcessEscChar(int esc_char);
        static /*0x24bfc18*/ bool State1(LitJson.FsmContext ctx);
        static /*0x24bfe1c*/ bool State2(LitJson.FsmContext ctx);
        static /*0x24bfec0*/ bool State3(LitJson.FsmContext ctx);
        static /*0x24bfffc*/ bool State4(LitJson.FsmContext ctx);
        static /*0x24c00f8*/ bool State5(LitJson.FsmContext ctx);
        static /*0x24c0178*/ bool State6(LitJson.FsmContext ctx);
        static /*0x24c0274*/ bool State7(LitJson.FsmContext ctx);
        static /*0x24c0308*/ bool State8(LitJson.FsmContext ctx);
        static /*0x24c03c4*/ bool State9(LitJson.FsmContext ctx);
        static /*0x24c0430*/ bool State10(LitJson.FsmContext ctx);
        static /*0x24c049c*/ bool State11(LitJson.FsmContext ctx);
        static /*0x24c0508*/ bool State12(LitJson.FsmContext ctx);
        static /*0x24c0574*/ bool State13(LitJson.FsmContext ctx);
        static /*0x24c05e0*/ bool State14(LitJson.FsmContext ctx);
        static /*0x24c064c*/ bool State15(LitJson.FsmContext ctx);
        static /*0x24c06b8*/ bool State16(LitJson.FsmContext ctx);
        static /*0x24c0724*/ bool State17(LitJson.FsmContext ctx);
        static /*0x24c0790*/ bool State18(LitJson.FsmContext ctx);
        static /*0x24c07fc*/ bool State19(LitJson.FsmContext ctx);
        static /*0x24c08a4*/ bool State20(LitJson.FsmContext ctx);
        static /*0x24c0910*/ bool State21(LitJson.FsmContext ctx);
        static /*0x24c0a48*/ bool State22(LitJson.FsmContext ctx);
        static /*0x24c0bc4*/ bool State23(LitJson.FsmContext ctx);
        static /*0x24c0c6c*/ bool State24(LitJson.FsmContext ctx);
        static /*0x24c0ce0*/ bool State25(LitJson.FsmContext ctx);
        static /*0x24c0d5c*/ bool State26(LitJson.FsmContext ctx);
        static /*0x24c0dc4*/ bool State27(LitJson.FsmContext ctx);
        static /*0x24c0e2c*/ bool State28(LitJson.FsmContext ctx);
        /*0x24bdc30*/ Lexer(System.IO.TextReader reader);
        /*0x24beee0*/ bool get_AllowComments();
        /*0x24beee8*/ void set_AllowComments(bool value);
        /*0x24beef4*/ bool get_AllowSingleQuotedStrings();
        /*0x24beefc*/ void set_AllowSingleQuotedStrings(bool value);
        /*0x24bef08*/ bool get_EndOfInput();
        /*0x24bef10*/ int get_Token();
        /*0x24bef18*/ string get_StringValue();
        /*0x24bfdf0*/ bool GetChar();
        /*0x24c0ea4*/ int NextChar();
        /*0x24be340*/ bool NextToken();
        /*0x24bfff0*/ void UngetChar();

        class StateHandler : System.MulticastDelegate
        {
            /*0x24bf9fc*/ StateHandler(object object, nint method);
            /*0x24c0edc*/ bool Invoke(LitJson.FsmContext ctx);
            /*0x24c0ef0*/ System.IAsyncResult BeginInvoke(LitJson.FsmContext ctx, System.AsyncCallback callback, object object);
            /*0x24c0f10*/ bool EndInvoke(System.IAsyncResult result);
        }
    }

    enum ParserToken
    {
        None = 65536,
        Number = 65537,
        True = 65538,
        False = 65539,
        Null = 65540,
        CharSeq = 65541,
        Char = 65542,
        Text = 65543,
        Object = 65544,
        ObjectPrime = 65545,
        Pair = 65546,
        PairRest = 65547,
        Array = 65548,
        ArrayPrime = 65549,
        Value = 65550,
        ValueRest = 65551,
        String = 65552,
        End = 65553,
        Epsilon = 65554,
    }

    class UnityTypeBindings
    {
        static /*0x0*/ bool registerd;

        static /*0x24c0f38*/ UnityTypeBindings();
        static /*0x24c0f3c*/ void Register();

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Action<UnityEngine.Vector2, LitJson.JsonWriter> writeVector2;
            /*0x18*/ System.Action<UnityEngine.Vector3, LitJson.JsonWriter> writeVector3;

            /*0x24c1884*/ <>c__DisplayClass2_0();
            /*0x24c188c*/ void <Register>b__3(UnityEngine.Vector2 v, LitJson.JsonWriter w);
            /*0x24c18b0*/ void <Register>b__5(UnityEngine.Vector3 v, LitJson.JsonWriter w);
            /*0x24c18d4*/ void <Register>b__10(UnityEngine.Bounds v, LitJson.JsonWriter w);
        }

        class <>c
        {
            static /*0x0*/ LitJson.UnityTypeBindings.<> <>9;
            static /*0x8*/ LitJson.ExporterFunc<System.Type> <>9__2_0;
            static /*0x10*/ LitJson.ImporterFunc<string, System.Type> <>9__2_1;
            static /*0x18*/ System.Action<UnityEngine.Vector2, LitJson.JsonWriter> <>9__2_2;
            static /*0x20*/ System.Action<UnityEngine.Vector3, LitJson.JsonWriter> <>9__2_4;
            static /*0x28*/ LitJson.ExporterFunc<UnityEngine.Vector4> <>9__2_6;
            static /*0x30*/ LitJson.ExporterFunc<UnityEngine.Quaternion> <>9__2_7;
            static /*0x38*/ LitJson.ExporterFunc<UnityEngine.Color> <>9__2_8;
            static /*0x40*/ LitJson.ExporterFunc<UnityEngine.Color32> <>9__2_9;
            static /*0x48*/ LitJson.ExporterFunc<UnityEngine.Rect> <>9__2_11;
            static /*0x50*/ LitJson.ExporterFunc<UnityEngine.RectOffset> <>9__2_12;

            static /*0x24c19b4*/ <>c();
            /*0x24c1a18*/ <>c();
            /*0x24c1a20*/ void <Register>b__2_0(System.Type v, LitJson.JsonWriter w);
            /*0x24c1a58*/ System.Type <Register>b__2_1(string s);
            /*0x24c1adc*/ void <Register>b__2_2(UnityEngine.Vector2 v, LitJson.JsonWriter w);
            /*0x24c1ba4*/ void <Register>b__2_4(UnityEngine.Vector3 v, LitJson.JsonWriter w);
            /*0x24c1c74*/ void <Register>b__2_6(UnityEngine.Vector4 v, LitJson.JsonWriter w);
            /*0x24c1d6c*/ void <Register>b__2_7(UnityEngine.Quaternion v, LitJson.JsonWriter w);
            /*0x24c1e64*/ void <Register>b__2_8(UnityEngine.Color v, LitJson.JsonWriter w);
            /*0x24c1f5c*/ void <Register>b__2_9(UnityEngine.Color32 v, LitJson.JsonWriter w);
            /*0x24c2074*/ void <Register>b__2_11(UnityEngine.Rect v, LitJson.JsonWriter w);
            /*0x24c2190*/ void <Register>b__2_12(UnityEngine.RectOffset v, LitJson.JsonWriter w);
        }
    }

    namespace Extensions
    {
        class Extensions
        {
            static /*0x24c2044*/ void WriteProperty(LitJson.JsonWriter w, string name, long value);
            static /*0x24c22a8*/ void WriteProperty(LitJson.JsonWriter w, string name, string value);
            static /*0x24c22d8*/ void WriteProperty(LitJson.JsonWriter w, string name, bool value);
            static /*0x24c1b74*/ void WriteProperty(LitJson.JsonWriter w, string name, double value);
        }

        class JsonIgnore : System.Attribute
        {
            /*0x24c2308*/ JsonIgnore();
        }
    }
}

namespace DataStructures
{
    namespace ViliWonka
    {
        namespace KDTree
        {
            struct KDBounds
            {
                /*0x10*/ UnityEngine.Vector3 min;
                /*0x1c*/ UnityEngine.Vector3 max;

                /*0x24c2310*/ UnityEngine.Vector3 get_size();
                /*0x24c2330*/ UnityEngine.Bounds get_Bounds();
                /*0x24c2378*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point);
            }

            class KDNode
            {
                /*0x10*/ float partitionCoordinate;
                /*0x14*/ int partitionAxis;
                /*0x18*/ DataStructures.ViliWonka.KDTree.KDNode negativeChild;
                /*0x20*/ DataStructures.ViliWonka.KDTree.KDNode positiveChild;
                /*0x28*/ int start;
                /*0x2c*/ int end;
                /*0x30*/ DataStructures.ViliWonka.KDTree.KDBounds bounds;

                /*0x24c23ec*/ KDNode();
                /*0x24c23d0*/ int get_Count();
                /*0x24c23dc*/ bool get_Leaf();
            }

            class KDQuery
            {
                /*0x10*/ DataStructures.ViliWonka.KDTree.KDQueryNode[] queueArray;
                /*0x18*/ DataStructures.ViliWonka.Heap.MinHeap<DataStructures.ViliWonka.KDTree.KDQueryNode> minHeap;
                /*0x20*/ int count;
                /*0x24*/ int queryIndex;
                /*0x28*/ System.Collections.Generic.SortedList<int, DataStructures.ViliWonka.Heap.KSmallestHeap<int>> _heaps;

                /*0x24c2780*/ KDQuery(int queryNodesContainersInitialSize);
                /*0x24c23fc*/ DataStructures.ViliWonka.KDTree.KDQueryNode PushGetQueue();
                /*0x24c2554*/ void PushToQueue(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint);
                /*0x24c2598*/ void PushToHeap(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint, UnityEngine.Vector3 queryPosition);
                /*0x24c2658*/ int get_LeftToProcess();
                /*0x24c2664*/ DataStructures.ViliWonka.KDTree.KDQueryNode PopFromQueue();
                /*0x24c26a4*/ DataStructures.ViliWonka.KDTree.KDQueryNode PopFromHeap();
                /*0x24c275c*/ void Reset();
                /*0x24c2878*/ void DrawLastQuery();
                /*0x24c29a8*/ void ClosestPoint(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, System.Collections.Generic.List<int> resultIndices, System.Collections.Generic.List<float> resultDistances);
                /*0x24c2e1c*/ void Interval(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 min, UnityEngine.Vector3 max, System.Collections.Generic.List<int> resultIndices);
                /*0x24c331c*/ void KNearest(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, int k, System.Collections.Generic.List<int> resultIndices, System.Collections.Generic.List<float> resultDistances);
                /*0x24c37c0*/ void Radius(DataStructures.ViliWonka.KDTree.KDTree tree, UnityEngine.Vector3 queryPosition, float queryRadius, System.Collections.Generic.List<int> resultIndices);
            }

            class KDQueryNode
            {
                /*0x10*/ DataStructures.ViliWonka.KDTree.KDNode node;
                /*0x18*/ UnityEngine.Vector3 tempClosestPoint;
                /*0x24*/ float distance;

                /*0x24c254c*/ KDQueryNode();
                /*0x24c3b64*/ KDQueryNode(DataStructures.ViliWonka.KDTree.KDNode node, UnityEngine.Vector3 tempClosestPoint);
            }

            class KDTree
            {
                /*0x10*/ DataStructures.ViliWonka.KDTree.KDNode <RootNode>k__BackingField;
                /*0x18*/ UnityEngine.Vector3[] points;
                /*0x20*/ int[] permutation;
                /*0x28*/ int <Count>k__BackingField;
                /*0x2c*/ int maxPointsPerLeafNode;
                /*0x30*/ DataStructures.ViliWonka.KDTree.KDNode[] kdNodesStack;
                /*0x38*/ int kdNodesCount;

                /*0x24c3be0*/ KDTree(int maxPointsPerLeafNode);
                /*0x24c3ca8*/ KDTree(UnityEngine.Vector3[] points, int maxPointsPerLeafNode);
                /*0x24c3bb0*/ DataStructures.ViliWonka.KDTree.KDNode get_RootNode();
                /*0x24c3bb8*/ void set_RootNode(DataStructures.ViliWonka.KDTree.KDNode value);
                /*0x24c3bc0*/ UnityEngine.Vector3[] get_Points();
                /*0x24c3bc8*/ int[] get_Permutation();
                /*0x24c3bd0*/ int get_Count();
                /*0x24c3bd8*/ void set_Count(int value);
                /*0x24c3dbc*/ void Build(UnityEngine.Vector3[] newPoints, int maxPointsPerLeafNode);
                /*0x24c3ef4*/ void Build(System.Collections.Generic.List<UnityEngine.Vector3> newPoints, int maxPointsPerLeafNode);
                /*0x24c3d60*/ void Rebuild(int maxPointsPerLeafNode);
                /*0x24c3e58*/ void SetCount(int newSize);
                /*0x24c3fd0*/ void BuildTree();
                /*0x24c4044*/ DataStructures.ViliWonka.KDTree.KDNode GetKDNode();
                /*0x24c403c*/ void ResetKDNodeStack();
                /*0x24c41b0*/ DataStructures.ViliWonka.KDTree.KDBounds MakeBounds();
                /*0x24c43ec*/ void SplitNode(DataStructures.ViliWonka.KDTree.KDNode parent);
                /*0x24c4664*/ float CalculatePivot(int start, int end, float boundsStart, float boundsEnd, int axis);
                /*0x24c4918*/ int Partition(int start, int end, float partitionPivot, int axis);
                /*0x24c4aa4*/ bool ContinueSplit(DataStructures.ViliWonka.KDTree.KDNode node);
            }
        }

        namespace Heap
        {
            class BaseHeap
            {
                /*0x10*/ int nodesCount;
                /*0x14*/ int maxSize;
                /*0x18*/ float[] heap;
                /*0x20*/ float tempHeap;

                /*0x24c4acc*/ BaseHeap(int initialSize);
                /*0x24c4b38*/ int get_Count();
                /*0x24c4b40*/ float get_HeadValue();
                /*0x24c4b6c*/ void Clear();
                /*0x24c4b74*/ int Parent(int index);
                /*0x24c4b7c*/ int Left(int index);
                /*0x24c4b84*/ int Right(int index);
                /*0x24c4b90*/ void BubbleDownMax(int index);
                /*0x24c4cf0*/ void BubbleUpMax(int index);
                /*0x24c4d74*/ void BubbleDownMin(int index);
                /*0x24c4ed4*/ void BubbleUpMin(int index);
                /*0x24c4f58*/ void Swap(int A, int B);
                /*0x24c4fa8*/ void UpsizeHeap();
                /*0x24c5004*/ void PushValue(float h);
                /*0x24c5044*/ float PopValue();
                /*0x24c5084*/ void FlushHeapResult(System.Collections.Generic.List<float> heapList);
            }

            class KSmallestHeap : DataStructures.ViliWonka.Heap.BaseHeap
            {
                /*0x24c5170*/ KSmallestHeap(int maxEntries);
                /*0x24c5174*/ bool get_Full();
                /*0x24c5184*/ void PushValue(float h);
                /*0x24c5224*/ float PopValue();
                /*0x24c52d4*/ void Print();
                /*0x24c538c*/ bool HeapPropertyHolds(int index, int depth);
            }

            class KSmallestHeap<T> : DataStructures.ViliWonka.Heap.KSmallestHeap
            {
                /*0x0*/ T[] objs;
                /*0x0*/ T tempObjs;

                KSmallestHeap(int maxEntries);
                T get_HeadHeapObject();
                void Swap(int A, int B);
                void PushValue(float h);
                void PushObj(T obj, float h);
                float PopValue();
                T PopObj();
                T PopObj(ref float heapValue);
                void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<float> heapList);
            }

            class MaxHeap : DataStructures.ViliWonka.Heap.BaseHeap
            {
                /*0x24c5664*/ MaxHeap(int initialSize);
                /*0x24c5668*/ void PushValue(float h);
                /*0x24c56d4*/ float PopValue();
            }

            class MaxHeap<T> : DataStructures.ViliWonka.Heap.MaxHeap
            {
                /*0x0*/ T[] objs;
                /*0x0*/ T tempObjs;

                MaxHeap(int maxNodes);
                T get_HeadHeapObject();
                void Swap(int A, int B);
                void PushValue(float h);
                float PopValue();
                void PushObj(T obj, float h);
                T PopObj();
                T PopObj(ref float heapValue);
                void UpsizeHeap();
                void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<float> heapList);
            }

            class MinHeap : DataStructures.ViliWonka.Heap.BaseHeap
            {
                /*0x24c5784*/ MinHeap(int initialSize);
                /*0x24c5788*/ void PushValue(float h);
                /*0x24c57f4*/ float PopValue();
            }

            class MinHeap<T> : DataStructures.ViliWonka.Heap.MinHeap
            {
                /*0x0*/ T[] objs;
                /*0x0*/ T tempObjs;

                MinHeap(int maxNodes);
                T get_HeadHeapObject();
                void Swap(int A, int B);
                void PushValue(float h);
                float PopValue();
                void PushObj(T obj, float h);
                T PopObj();
                T PopObj(ref float heapValue);
                void UpsizeHeap();
                void FlushResult(System.Collections.Generic.List<T> resultList, System.Collections.Generic.List<float> heapList);
            }
        }
    }
}

namespace IngameDebugConsole
{
    class DebugLogLogcatListener : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ System.Collections.Generic.Queue<string> queuedLogs;
        /*0x28*/ UnityEngine.AndroidJavaObject nativeObject;

        /*0x24c58a8*/ DebugLogLogcatListener();
        /*0x24c5968*/ void Finalize();
        /*0x24c5ac4*/ void Start(string arguments);
        /*0x24c5a10*/ void Stop();
        /*0x24c5c50*/ void OnLogReceived(string log);
        /*0x24c5ca8*/ string GetLog();
    }

    class CircularBuffer<T>
    {
        /*0x0*/ T[] arr;
        /*0x0*/ int startIndex;
        /*0x0*/ int <Count>k__BackingField;

        CircularBuffer(int capacity);
        int get_Count();
        void set_Count(int value);
        T get_Item(int index);
        void Add(T value);
    }

    class DynamicCircularBuffer<T>
    {
        /*0x0*/ T[] arr;
        /*0x0*/ int startIndex;
        /*0x0*/ int <Count>k__BackingField;

        DynamicCircularBuffer(int initialCapacity);
        int get_Count();
        void set_Count(int value);
        T get_Item(int index);
        void set_Item(int index, T value);
        void Add(T value);
        T RemoveFirst();
        T RemoveLast();
    }

    class ConsoleMethodAttribute : System.Attribute
    {
        /*0x10*/ string m_command;
        /*0x18*/ string m_description;
        /*0x20*/ string[] m_parameterNames;

        /*0x24c5d38*/ ConsoleMethodAttribute(string command, string description, string[] parameterNames);
        /*0x24c5d20*/ string get_Command();
        /*0x24c5d28*/ string get_Description();
        /*0x24c5d30*/ string[] get_ParameterNames();
    }

    class ConsoleMethodInfo
    {
        /*0x10*/ System.Reflection.MethodInfo method;
        /*0x18*/ System.Type[] parameterTypes;
        /*0x20*/ object instance;
        /*0x28*/ string command;
        /*0x30*/ string signature;
        /*0x38*/ string[] parameters;

        /*0x24c5d74*/ ConsoleMethodInfo(System.Reflection.MethodInfo method, System.Type[] parameterTypes, object instance, string command, string signature, string[] parameters);
        /*0x24c5dc8*/ bool IsValid();
    }

    class DebugLogConsole
    {
        static /*0x0*/ System.Collections.Generic.List<IngameDebugConsole.ConsoleMethodInfo> methods;
        static /*0x8*/ System.Collections.Generic.List<IngameDebugConsole.ConsoleMethodInfo> matchingMethods;
        static /*0x10*/ System.Collections.Generic.Dictionary<System.Type, IngameDebugConsole.DebugLogConsole.ParseFunction> parseFunctions;
        static /*0x18*/ System.Collections.Generic.Dictionary<System.Type, string> typeReadableNames;
        static /*0x20*/ System.Collections.Generic.List<string> commandArguments;
        static /*0x28*/ string[] inputDelimiters;
        static /*0x30*/ System.Globalization.CompareInfo caseInsensitiveComparer;

        static /*0x24c5e18*/ DebugLogConsole();
        static /*0x24c874c*/ void LogAllCommands();
        static /*0x24c8bf4*/ void LogAllCommandsWithName(string commandName);
        static /*0x24c938c*/ void LogSystemInfo();
        static /*0x24c9d4c*/ System.Text.StringBuilder AppendSysInfoIfPresent(System.Text.StringBuilder sb, string info, string postfix);
        static /*0x24c9e04*/ System.Text.StringBuilder AppendSysInfoIfPresent(System.Text.StringBuilder sb, int info, string postfix);
        static /*0x24c9e9c*/ void AddCustomParameterType(System.Type type, IngameDebugConsole.DebugLogConsole.ParseFunction parseFunction, string typeReadableName);
        static /*0x24ca044*/ void RemoveCustomParameterType(System.Type type);
        static /*0x24ca0f4*/ void AddCommandInstance(string command, string description, string methodName, object instance, string[] parameterNames);
        static /*0x24ca330*/ void AddCommandStatic(string command, string description, string methodName, System.Type ownerType, string[] parameterNames);
        static /*0x24c7b1c*/ void AddCommand(string command, string description, System.Action method);
        static void AddCommand<T1>(string command, string description, System.Action<T1> method);
        static void AddCommand<T1>(string command, string description, System.Func<T1> method);
        static void AddCommand<T1, T2>(string command, string description, System.Action<T1, T2> method);
        static void AddCommand<T1, T2>(string command, string description, System.Func<T1, T2> method);
        static void AddCommand<T1, T2, T3>(string command, string description, System.Action<T1, T2, T3> method);
        static void AddCommand<T1, T2, T3>(string command, string description, System.Func<T1, T2, T3> method);
        static void AddCommand<T1, T2, T3, T4>(string command, string description, System.Action<T1, T2, T3, T4> method);
        static void AddCommand<T1, T2, T3, T4>(string command, string description, System.Func<T1, T2, T3, T4> method);
        static void AddCommand<T1, T2, T3, T4, T5>(string command, string description, System.Func<T1, T2, T3, T4, T5> method);
        static /*0x24ca3b8*/ void AddCommand(string command, string description, System.Delegate method);
        static void AddCommand<T1>(string command, string description, System.Action<T1> method, string parameterName);
        static void AddCommand<T1, T2>(string command, string description, System.Action<T1, T2> method, string parameterName1, string parameterName2);
        static void AddCommand<T1, T2>(string command, string description, System.Func<T1, T2> method, string parameterName);
        static void AddCommand<T1, T2, T3>(string command, string description, System.Action<T1, T2, T3> method, string parameterName1, string parameterName2, string parameterName3);
        static void AddCommand<T1, T2, T3>(string command, string description, System.Func<T1, T2, T3> method, string parameterName1, string parameterName2);
        static void AddCommand<T1, T2, T3, T4>(string command, string description, System.Action<T1, T2, T3, T4> method, string parameterName1, string parameterName2, string parameterName3, string parameterName4);
        static void AddCommand<T1, T2, T3, T4>(string command, string description, System.Func<T1, T2, T3, T4> method, string parameterName1, string parameterName2, string parameterName3);
        static void AddCommand<T1, T2, T3, T4, T5>(string command, string description, System.Func<T1, T2, T3, T4, T5> method, string parameterName1, string parameterName2, string parameterName3, string parameterName4);
        static /*0x24ca44c*/ void AddCommand(string command, string description, System.Delegate method, string[] parameterNames);
        static /*0x24ca1e8*/ void AddCommand(string command, string description, string methodName, System.Type ownerType, object instance, string[] parameterNames);
        static /*0x24c7bb0*/ void AddCommand(string command, string description, System.Reflection.MethodInfo method, object instance, string[] parameterNames);
        static /*0x24ca9c4*/ void RemoveCommand(string command);
        static /*0x24cab20*/ void RemoveCommand(System.Action method);
        static void RemoveCommand<T1>(System.Action<T1> method);
        static void RemoveCommand<T1>(System.Func<T1> method);
        static void RemoveCommand<T1, T2>(System.Action<T1, T2> method);
        static void RemoveCommand<T1, T2>(System.Func<T1, T2> method);
        static void RemoveCommand<T1, T2, T3>(System.Action<T1, T2, T3> method);
        static void RemoveCommand<T1, T2, T3>(System.Func<T1, T2, T3> method);
        static void RemoveCommand<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> method);
        static void RemoveCommand<T1, T2, T3, T4>(System.Func<T1, T2, T3, T4> method);
        static void RemoveCommand<T1, T2, T3, T4, T5>(System.Func<T1, T2, T3, T4, T5> method);
        static /*0x24cacdc*/ void RemoveCommand(System.Delegate method);
        static /*0x24cab90*/ void RemoveCommand(System.Reflection.MethodInfo method);
        static /*0x24cad4c*/ string GetAutoCompleteCommand(string commandStart, string previousSuggestion);
        static /*0x24cb070*/ void ExecuteCommand(string command);
        static /*0x24cbdcc*/ void FetchArgumentsFromCommand(string command, System.Collections.Generic.List<string> commandArguments);
        static /*0x24c9054*/ void FindCommands(string commandName, bool allowSubstringMatching, System.Collections.Generic.List<IngameDebugConsole.ConsoleMethodInfo> matchingCommands);
        static /*0x24cc478*/ void GetCommandSuggestions(string command, System.Collections.Generic.List<IngameDebugConsole.ConsoleMethodInfo> matchingCommands, System.Collections.Generic.List<int> caretIndexIncrements, ref string commandName, ref int numberOfParameters);
        static /*0x24cc244*/ int IndexOfDelimiterGroup(char c);
        static /*0x24cc318*/ int IndexOfDelimiterGroupEnd(string command, int delimiterIndex, int startIndex);
        static /*0x24cc450*/ int IndexOfChar(string command, char c, int startIndex);
        static /*0x24ca6f4*/ int FindCommandIndex(string command);
        static /*0x24ca4e4*/ bool IsSupportedArrayType(System.Type type);
        static /*0x24ca828*/ string GetTypeReadableName(System.Type type);
        static /*0x24cc064*/ bool ParseArgument(string input, System.Type argumentType, ref object output);
        static /*0x24cd3d0*/ bool ParseString(string input, ref object output);
        static /*0x24cd3e0*/ bool ParseBool(string input, ref object output);
        static /*0x24cd528*/ bool ParseInt(string input, ref object output);
        static /*0x24cd5ac*/ bool ParseUInt(string input, ref object output);
        static /*0x24cd630*/ bool ParseLong(string input, ref object output);
        static /*0x24cd704*/ bool ParseULong(string input, ref object output);
        static /*0x24cd7d8*/ bool ParseByte(string input, ref object output);
        static /*0x24cd85c*/ bool ParseSByte(string input, ref object output);
        static /*0x24cd8e0*/ bool ParseShort(string input, ref object output);
        static /*0x24cd964*/ bool ParseUShort(string input, ref object output);
        static /*0x24cd9e8*/ bool ParseChar(string input, ref object output);
        static /*0x24cda7c*/ bool ParseFloat(string input, ref object output);
        static /*0x24cdb50*/ bool ParseDouble(string input, ref object output);
        static /*0x24cdc24*/ bool ParseDecimal(string input, ref object output);
        static /*0x24cdd2c*/ bool ParseVector2(string input, ref object output);
        static /*0x24cfdf8*/ bool ParseVector3(string input, ref object output);
        static /*0x24cfeb0*/ bool ParseVector4(string input, ref object output);
        static /*0x24cff68*/ bool ParseQuaternion(string input, ref object output);
        static /*0x24d0020*/ bool ParseColor(string input, ref object output);
        static /*0x24d00d8*/ bool ParseColor32(string input, ref object output);
        static /*0x24d0190*/ bool ParseRect(string input, ref object output);
        static /*0x24d0248*/ bool ParseRectOffset(string input, ref object output);
        static /*0x24d0300*/ bool ParseBounds(string input, ref object output);
        static /*0x24d03b8*/ bool ParseVector2Int(string input, ref object output);
        static /*0x24d0470*/ bool ParseVector3Int(string input, ref object output);
        static /*0x24d0528*/ bool ParseRectInt(string input, ref object output);
        static /*0x24d05e0*/ bool ParseBoundsInt(string input, ref object output);
        static /*0x24d0698*/ bool ParseGameObject(string input, ref object output);
        static /*0x24cccb4*/ bool ParseComponent(string input, System.Type componentType, ref object output);
        static /*0x24ccd88*/ bool ParseEnum(string input, System.Type enumType, ref object output);
        static /*0x24cd018*/ bool ParseArray(string input, System.Type arrayType, ref object output);
        static /*0x24cdde4*/ bool ParseVector(string input, System.Type vectorType, ref object output);

        class ParseFunction : System.MulticastDelegate
        {
            /*0x24c7a44*/ ParseFunction(object object, nint method);
            /*0x24d0714*/ bool Invoke(string input, ref object output);
            /*0x24d0728*/ System.IAsyncResult BeginInvoke(string input, ref object output, System.AsyncCallback callback, object object);
            /*0x24d0754*/ bool EndInvoke(ref object output, System.IAsyncResult result);
        }
    }

    class DebugLogEntry : System.IEquatable<IngameDebugConsole.DebugLogEntry>
    {
        static int HASH_NOT_CALCULATED = -623218;
        /*0x10*/ string logString;
        /*0x18*/ string stackTrace;
        /*0x20*/ string completeLog;
        /*0x28*/ UnityEngine.Sprite logTypeSpriteRepresentation;
        /*0x30*/ int count;
        /*0x34*/ int hashValue;

        /*0x24d0924*/ DebugLogEntry();
        /*0x24d0780*/ void Initialize(string logString, string stackTrace);
        /*0x24d0798*/ bool Equals(IngameDebugConsole.DebugLogEntry other);
        /*0x24d07ec*/ bool MatchesSearchTerm(string searchTerm);
        /*0x24d084c*/ string ToString();
        /*0x24d08a8*/ int GetHashCode();
    }

    struct QueuedDebugLogEntry
    {
        /*0x10*/ string logString;
        /*0x18*/ string stackTrace;
        /*0x20*/ UnityEngine.LogType logType;

        /*0x24d092c*/ QueuedDebugLogEntry(string logString, string stackTrace, UnityEngine.LogType logType);
        /*0x24d0938*/ bool MatchesSearchTerm(string searchTerm);
    }

    struct DebugLogEntryTimestamp
    {
        /*0x10*/ System.DateTime dateTime;
        /*0x18*/ float elapsedSeconds;
        /*0x1c*/ int frameCount;

        /*0x24d0998*/ DebugLogEntryTimestamp(System.TimeSpan localTimeUtcOffset);
        /*0x24d0a24*/ void AppendTime(System.Text.StringBuilder sb);
        /*0x24d0bcc*/ void AppendFullTimestamp(System.Text.StringBuilder sb);
    }

    class DebugLogIndexList<T>
    {
        /*0x0*/ T[] indices;
        /*0x0*/ int size;

        DebugLogIndexList();
        int get_Count();
        T get_Item(int index);
        void set_Item(int index, T value);
        void Add(T value);
        void Clear();
        int IndexOf(T value);
    }

    class DebugLogItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        /*0x18*/ UnityEngine.RectTransform transformComponent;
        /*0x20*/ UnityEngine.UI.Image imageComponent;
        /*0x28*/ UnityEngine.CanvasGroup canvasGroupComponent;
        /*0x30*/ UnityEngine.UI.Text logText;
        /*0x38*/ UnityEngine.UI.Image logTypeImage;
        /*0x40*/ UnityEngine.GameObject logCountParent;
        /*0x48*/ UnityEngine.UI.Text logCountText;
        /*0x50*/ UnityEngine.RectTransform copyLogButton;
        /*0x58*/ IngameDebugConsole.DebugLogEntry logEntry;
        /*0x60*/ System.Nullable<IngameDebugConsole.DebugLogEntryTimestamp> logEntryTimestamp;
        /*0x78*/ int entryIndex;
        /*0x7c*/ bool isExpanded;
        /*0x80*/ UnityEngine.Vector2 logTextOriginalPosition;
        /*0x88*/ UnityEngine.Vector2 logTextOriginalSize;
        /*0x90*/ float copyLogButtonHeight;
        /*0x98*/ IngameDebugConsole.DebugLogRecycledListView listView;

        /*0x24d1634*/ DebugLogItem();
        /*0x24d0d00*/ UnityEngine.RectTransform get_Transform();
        /*0x24d0d08*/ UnityEngine.UI.Image get_Image();
        /*0x24d0d10*/ UnityEngine.CanvasGroup get_CanvasGroup();
        /*0x24d0d18*/ IngameDebugConsole.DebugLogEntry get_Entry();
        /*0x24d0d20*/ System.Nullable<IngameDebugConsole.DebugLogEntryTimestamp> get_Timestamp();
        /*0x24d0d34*/ int get_Index();
        /*0x24d0d3c*/ bool get_Expanded();
        /*0x24d0d44*/ void Initialize(IngameDebugConsole.DebugLogRecycledListView listView);
        /*0x24d0dd8*/ void SetContent(IngameDebugConsole.DebugLogEntry logEntry, System.Nullable<IngameDebugConsole.DebugLogEntryTimestamp> logEntryTimestamp, int entryIndex, bool isExpanded);
        /*0x24d11c8*/ void ShowCount();
        /*0x24d1248*/ void HideCount();
        /*0x24d1288*/ void UpdateTimestamp(IngameDebugConsole.DebugLogEntryTimestamp timestamp);
        /*0x24d0ff0*/ void SetText(IngameDebugConsole.DebugLogEntry logEntry, System.Nullable<IngameDebugConsole.DebugLogEntryTimestamp> logEntryTimestamp, bool isExpanded);
        /*0x24d1374*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x24d13ac*/ void CopyLog();
        /*0x24d13dc*/ string GetCopyContent();
        /*0x24d1504*/ float CalculateExpandedHeight(IngameDebugConsole.DebugLogEntry logEntry, System.Nullable<IngameDebugConsole.DebugLogEntryTimestamp> logEntryTimestamp);
        /*0x24d1614*/ string ToString();
    }

    enum DebugLogFilter
    {
        None = 0,
        Info = 1,
        Warning = 2,
        Error = 4,
        All = 7,
    }

    class DebugLogManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ IngameDebugConsole.DebugLogManager <Instance>k__BackingField;
        /*0x18*/ bool singleton;
        /*0x1c*/ float minimumHeight;
        /*0x20*/ bool enableHorizontalResizing;
        /*0x21*/ bool resizeFromRight;
        /*0x24*/ float minimumWidth;
        /*0x28*/ bool enablePopup;
        /*0x29*/ bool startInPopupMode;
        /*0x2a*/ bool startMinimized;
        /*0x2b*/ bool toggleWithKey;
        /*0x2c*/ UnityEngine.KeyCode toggleKey;
        /*0x30*/ bool enableSearchbar;
        /*0x34*/ float topSearchbarMinWidth;
        /*0x38*/ bool captureLogTimestamps;
        /*0x39*/ bool alwaysDisplayTimestamps;
        /*0x3a*/ bool clearCommandAfterExecution;
        /*0x3c*/ int commandHistorySize;
        /*0x40*/ bool showCommandSuggestions;
        /*0x41*/ bool receiveLogcatLogsInAndroid;
        /*0x48*/ string logcatArguments;
        /*0x50*/ bool avoidScreenCutout;
        /*0x54*/ int maxLogLength;
        /*0x58*/ IngameDebugConsole.DebugLogItem logItemPrefab;
        /*0x60*/ UnityEngine.UI.Text commandSuggestionPrefab;
        /*0x68*/ UnityEngine.Sprite infoLog;
        /*0x70*/ UnityEngine.Sprite warningLog;
        /*0x78*/ UnityEngine.Sprite errorLog;
        /*0x80*/ UnityEngine.Sprite resizeIconAllDirections;
        /*0x88*/ UnityEngine.Sprite resizeIconVerticalOnly;
        /*0x90*/ System.Collections.Generic.Dictionary<UnityEngine.LogType, UnityEngine.Sprite> logSpriteRepresentations;
        /*0x98*/ UnityEngine.Color collapseButtonNormalColor;
        /*0xa8*/ UnityEngine.Color collapseButtonSelectedColor;
        /*0xb8*/ UnityEngine.Color filterButtonsNormalColor;
        /*0xc8*/ UnityEngine.Color filterButtonsSelectedColor;
        /*0xd8*/ string commandSuggestionHighlightStart;
        /*0xe0*/ string commandSuggestionHighlightEnd;
        /*0xe8*/ UnityEngine.RectTransform logWindowTR;
        /*0xf0*/ UnityEngine.RectTransform canvasTR;
        /*0xf8*/ UnityEngine.RectTransform logItemsContainer;
        /*0x100*/ UnityEngine.RectTransform commandSuggestionsContainer;
        /*0x108*/ UnityEngine.UI.InputField commandInputField;
        /*0x110*/ UnityEngine.UI.Button hideButton;
        /*0x118*/ UnityEngine.UI.Button clearButton;
        /*0x120*/ UnityEngine.UI.Image collapseButton;
        /*0x128*/ UnityEngine.UI.Image filterInfoButton;
        /*0x130*/ UnityEngine.UI.Image filterWarningButton;
        /*0x138*/ UnityEngine.UI.Image filterErrorButton;
        /*0x140*/ UnityEngine.UI.Text infoEntryCountText;
        /*0x148*/ UnityEngine.UI.Text warningEntryCountText;
        /*0x150*/ UnityEngine.UI.Text errorEntryCountText;
        /*0x158*/ UnityEngine.RectTransform searchbar;
        /*0x160*/ UnityEngine.RectTransform searchbarSlotTop;
        /*0x168*/ UnityEngine.RectTransform searchbarSlotBottom;
        /*0x170*/ UnityEngine.UI.Image resizeButton;
        /*0x178*/ UnityEngine.GameObject snapToBottomButton;
        /*0x180*/ UnityEngine.CanvasGroup logWindowCanvasGroup;
        /*0x188*/ IngameDebugConsole.DebugLogPopup popupManager;
        /*0x190*/ UnityEngine.UI.ScrollRect logItemsScrollRect;
        /*0x198*/ UnityEngine.RectTransform logItemsScrollRectTR;
        /*0x1a0*/ UnityEngine.Vector2 logItemsScrollRectOriginalSize;
        /*0x1a8*/ IngameDebugConsole.DebugLogRecycledListView recycledListView;
        /*0x1b0*/ bool isLogWindowVisible;
        /*0x1b1*/ bool screenDimensionsChanged;
        /*0x1b4*/ float logWindowPreviousWidth;
        /*0x1b8*/ int infoEntryCount;
        /*0x1bc*/ int warningEntryCount;
        /*0x1c0*/ int errorEntryCount;
        /*0x1c4*/ int newInfoEntryCount;
        /*0x1c8*/ int newWarningEntryCount;
        /*0x1cc*/ int newErrorEntryCount;
        /*0x1d0*/ bool isCollapseOn;
        /*0x1d4*/ IngameDebugConsole.DebugLogFilter logFilter;
        /*0x1d8*/ string searchTerm;
        /*0x1e0*/ bool isInSearchMode;
        /*0x1e1*/ bool snapToBottom;
        /*0x1e8*/ System.Collections.Generic.List<IngameDebugConsole.DebugLogEntry> collapsedLogEntries;
        /*0x1f0*/ System.Collections.Generic.List<IngameDebugConsole.DebugLogEntryTimestamp> collapsedLogEntriesTimestamps;
        /*0x1f8*/ System.Collections.Generic.Dictionary<IngameDebugConsole.DebugLogEntry, int> collapsedLogEntriesMap;
        /*0x200*/ IngameDebugConsole.DebugLogIndexList<int> uncollapsedLogEntriesIndices;
        /*0x208*/ IngameDebugConsole.DebugLogIndexList<IngameDebugConsole.DebugLogEntryTimestamp> uncollapsedLogEntriesTimestamps;
        /*0x210*/ IngameDebugConsole.DebugLogIndexList<int> indicesOfListEntriesToShow;
        /*0x218*/ IngameDebugConsole.DebugLogIndexList<IngameDebugConsole.DebugLogEntryTimestamp> timestampsOfListEntriesToShow;
        /*0x220*/ int indexOfLogEntryToSelectAndFocus;
        /*0x224*/ bool shouldUpdateRecycledListView;
        /*0x228*/ IngameDebugConsole.DynamicCircularBuffer<IngameDebugConsole.QueuedDebugLogEntry> queuedLogEntries;
        /*0x230*/ object logEntriesLock;
        /*0x238*/ int pendingLogToAutoExpand;
        /*0x240*/ System.Collections.Generic.List<UnityEngine.UI.Text> commandSuggestionInstances;
        /*0x248*/ int visibleCommandSuggestionInstances;
        /*0x250*/ System.Collections.Generic.List<IngameDebugConsole.ConsoleMethodInfo> matchingCommandSuggestions;
        /*0x258*/ System.Collections.Generic.List<int> commandCaretIndexIncrements;
        /*0x260*/ string commandInputFieldPrevCommand;
        /*0x268*/ string commandInputFieldPrevCommandName;
        /*0x270*/ int commandInputFieldPrevParamCount;
        /*0x274*/ int commandInputFieldPrevCaretPos;
        /*0x278*/ int commandInputFieldPrevCaretArgumentIndex;
        /*0x280*/ string commandInputFieldAutoCompleteBase;
        /*0x288*/ bool commandInputFieldAutoCompletedNow;
        /*0x290*/ System.Collections.Generic.List<IngameDebugConsole.DebugLogEntry> pooledLogEntries;
        /*0x298*/ System.Collections.Generic.List<IngameDebugConsole.DebugLogItem> pooledLogItems;
        /*0x2a0*/ IngameDebugConsole.CircularBuffer<string> commandHistory;
        /*0x2a8*/ int commandHistoryIndex;
        /*0x2b0*/ string unfinishedCommand;
        /*0x2b8*/ System.Text.StringBuilder sharedStringBuilder;
        /*0x2c0*/ System.TimeSpan localTimeUtcOffset;
        /*0x2c8*/ UnityEngine.EventSystems.PointerEventData nullPointerEventData;
        /*0x2d0*/ System.Action OnLogWindowShown;
        /*0x2d8*/ System.Action OnLogWindowHidden;
        /*0x2e0*/ IngameDebugConsole.DebugLogLogcatListener logcatListener;

        static /*0x24d163c*/ IngameDebugConsole.DebugLogManager get_Instance();
        static /*0x24d1684*/ void set_Instance(IngameDebugConsole.DebugLogManager value);
        /*0x24d6540*/ DebugLogManager();
        /*0x24d16d0*/ bool get_IsLogWindowVisible();
        /*0x24d16d8*/ bool get_PopupEnabled();
        /*0x24d1700*/ void set_PopupEnabled(bool value);
        /*0x24d1730*/ void Awake();
        /*0x24d28a0*/ void OnEnable();
        /*0x24d2b4c*/ void OnDisable();
        /*0x24d2c90*/ void Start();
        /*0x24d2ddc*/ void OnRectTransformDimensionsChange();
        /*0x24d2de8*/ void Update();
        /*0x24d2e30*/ void LateUpdate();
        /*0x24d2d54*/ void ShowLogWindow();
        /*0x24d2cd4*/ void HideLogWindow();
        /*0x24d4e4c*/ char OnValidateCommand(string text, int charIndex, char addedChar);
        /*0x24d4b80*/ void ReceivedLog(string logString, string stackTrace, UnityEngine.LogType logType);
        /*0x24d36f4*/ void ProcessLog(IngameDebugConsole.QueuedDebugLogEntry queuedLogEntry);
        /*0x24d50fc*/ void SetSnapToBottom(bool snapToBottom);
        /*0x24d5108*/ void ValidateScrollPosition();
        /*0x24c8ad4*/ void ExpandLatestPendingLog();
        /*0x24c8b20*/ void StripStackTraceFromLatestPendingLog();
        /*0x24d51a0*/ void ClearLogs();
        /*0x24d53e8*/ void CollapseButtonPressed();
        /*0x24d5ae4*/ void FilterLogButtonPressed();
        /*0x24d5b40*/ void FilterWarningButtonPressed();
        /*0x24d5b9c*/ void FilterErrorButtonPressed();
        /*0x24d5bf8*/ void SearchTermChanged(string searchTerm);
        /*0x24d3fec*/ void RefreshCommandSuggestions(string command);
        /*0x24d5ca8*/ void OnEditCommand(string command);
        /*0x24d5c50*/ void OnEndEditCommand(string command);
        /*0x24d5cd0*/ void Resize(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x24d5478*/ void FilterLogs();
        /*0x24d5f2c*/ string GetAllLogs();
        /*0x24d6178*/ void SaveLogsToFile();
        /*0x24d6284*/ void SaveLogsToFile(string filePath);
        /*0x24d4804*/ void CheckScreenCutout();
        /*0x24d632c*/ void PoolLogItem(IngameDebugConsole.DebugLogItem logItem);
        /*0x24d6400*/ IngameDebugConsole.DebugLogItem PopLogItem();
        /*0x24d6630*/ void <Awake>b__117_0();
    }

    class DebugLogPopup : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        /*0x18*/ UnityEngine.RectTransform popupTransform;
        /*0x20*/ UnityEngine.Vector2 halfSize;
        /*0x28*/ UnityEngine.UI.Image backgroundImage;
        /*0x30*/ UnityEngine.CanvasGroup canvasGroup;
        /*0x38*/ IngameDebugConsole.DebugLogManager debugManager;
        /*0x40*/ UnityEngine.UI.Text newInfoCountText;
        /*0x48*/ UnityEngine.UI.Text newWarningCountText;
        /*0x50*/ UnityEngine.UI.Text newErrorCountText;
        /*0x58*/ UnityEngine.Color alertColorInfo;
        /*0x68*/ UnityEngine.Color alertColorWarning;
        /*0x78*/ UnityEngine.Color alertColorError;
        /*0x88*/ int newInfoCount;
        /*0x8c*/ int newWarningCount;
        /*0x90*/ int newErrorCount;
        /*0x94*/ UnityEngine.Color normalColor;
        /*0xa4*/ bool isPopupBeingDragged;
        /*0xa8*/ UnityEngine.Vector2 normalizedPosition;
        /*0xb0*/ System.Collections.IEnumerator moveToPosCoroutine;

        /*0x24d6aac*/ DebugLogPopup();
        /*0x24d663c*/ void Awake();
        /*0x24d3d4c*/ void NewLogsArrived(int newInfo, int newWarning, int newError);
        /*0x24d6820*/ void Reset();
        /*0x24d68dc*/ System.Collections.IEnumerator MoveToPosAnimation(UnityEngine.Vector2 targetPos);
        /*0x24d6980*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d4e00*/ void Show();
        /*0x24d4dc0*/ void Hide();
        /*0x24d69a8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d69d4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d6aa0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d4678*/ void UpdatePosition(bool immediately);

        class <MoveToPosAnimation>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ IngameDebugConsole.DebugLogPopup <>4__this;
            /*0x28*/ UnityEngine.Vector2 targetPos;
            /*0x30*/ float <modifier>5__2;
            /*0x34*/ UnityEngine.Vector2 <initialPos>5__3;

            /*0x24d6958*/ <MoveToPosAnimation>d__21(int <>1__state);
            /*0x24d6ab4*/ void System.IDisposable.Dispose();
            /*0x24d6ab8*/ bool MoveNext();
            /*0x24d6b98*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x24d6ba0*/ void System.Collections.IEnumerator.Reset();
            /*0x24d6be0*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class DebugLogRecycledListView : UnityEngine.MonoBehaviour
    {
        /*0x18*/ UnityEngine.RectTransform transformComponent;
        /*0x20*/ UnityEngine.RectTransform viewportTransform;
        /*0x28*/ UnityEngine.Color logItemNormalColor1;
        /*0x38*/ UnityEngine.Color logItemNormalColor2;
        /*0x48*/ UnityEngine.Color logItemSelectedColor;
        /*0x58*/ IngameDebugConsole.DebugLogManager manager;
        /*0x60*/ UnityEngine.UI.ScrollRect scrollView;
        /*0x68*/ float logItemHeight;
        /*0x6c*/ float _1OverLogItemHeight;
        /*0x70*/ float viewportHeight;
        /*0x78*/ System.Collections.Generic.List<IngameDebugConsole.DebugLogEntry> collapsedLogEntries;
        /*0x80*/ IngameDebugConsole.DebugLogIndexList<int> indicesOfEntriesToShow;
        /*0x88*/ IngameDebugConsole.DebugLogIndexList<IngameDebugConsole.DebugLogEntryTimestamp> timestampsOfEntriesToShow;
        /*0x90*/ int indexOfSelectedLogEntry;
        /*0x94*/ float positionOfSelectedLogEntry;
        /*0x98*/ float heightOfSelectedLogEntry;
        /*0x9c*/ float deltaHeightOfSelectedLogEntry;
        /*0xa0*/ System.Collections.Generic.Dictionary<int, IngameDebugConsole.DebugLogItem> logItemsAtIndices;
        /*0xa8*/ bool isCollapseOn;
        /*0xac*/ int currentTopIndex;
        /*0xb0*/ int currentBottomIndex;

        /*0x24d7408*/ DebugLogRecycledListView();
        /*0x24d6be8*/ float get_ItemHeight();
        /*0x24d6bf0*/ float get_SelectedItemHeight();
        /*0x24d6bf8*/ void Awake();
        /*0x24d25d4*/ void Initialize(IngameDebugConsole.DebugLogManager manager, System.Collections.Generic.List<IngameDebugConsole.DebugLogEntry> collapsedLogEntries, IngameDebugConsole.DebugLogIndexList<int> indicesOfEntriesToShow, IngameDebugConsole.DebugLogIndexList<IngameDebugConsole.DebugLogEntryTimestamp> timestampsOfEntriesToShow, float logItemHeight);
        /*0x24d6cfc*/ void SetCollapseMode(bool collapse);
        /*0x24d1390*/ void OnLogItemClicked(IngameDebugConsole.DebugLogItem item);
        /*0x24d3f20*/ void SelectAndFocusOnLogItemAtIndex(int itemIndex);
        /*0x24d6d08*/ void OnLogItemClickedInternal(int itemIndex, IngameDebugConsole.DebugLogItem referenceItem);
        /*0x24d5344*/ void DeselectSelectedLogItem();
        /*0x24d3e98*/ void OnLogEntriesUpdated(bool updateAllVisibleItemContents);
        /*0x24d5038*/ void OnCollapsedLogEntryAtIndexUpdated(int index);
        /*0x24d4978*/ void OnViewportWidthChanged();
        /*0x24d4624*/ void OnViewportHeightChanged();
        /*0x24d707c*/ void HardResetItems();
        /*0x24d7008*/ void CalculateContentHeight();
        /*0x24d25f0*/ void UpdateItemsInTheList(bool updateAllVisibleItemContents);
        /*0x24d7138*/ void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex);
        /*0x24d7350*/ void CreateLogItemAtIndex(int index);
        /*0x24d70a8*/ void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex);
        /*0x24d7178*/ void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex);
        /*0x24d6f94*/ void ColorLogItem(IngameDebugConsole.DebugLogItem logItem, int index);
        /*0x24d749c*/ void <Awake>b__25_0(UnityEngine.Vector2 pos);
    }

    class DebugLogResizeListener : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler
    {
        /*0x18*/ IngameDebugConsole.DebugLogManager debugManager;

        /*0x24d74c0*/ DebugLogResizeListener();
        /*0x24d74a4*/ void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x24d74a8*/ void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class DebugsOnScrollListener : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        /*0x18*/ UnityEngine.UI.ScrollRect debugsScrollRect;
        /*0x20*/ IngameDebugConsole.DebugLogManager debugLogManager;

        /*0x24d75a8*/ DebugsOnScrollListener();
        /*0x24d74c8*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d7520*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d753c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData data);
        /*0x24d7564*/ void OnScrollbarDragStart(UnityEngine.EventSystems.BaseEventData data);
        /*0x24d7580*/ void OnScrollbarDragEnd(UnityEngine.EventSystems.BaseEventData data);
        /*0x24d74f0*/ bool IsScrollbarAtBottom();
    }

    namespace Commands
    {
        class PlayerPrefsCommands
        {
            static /*0x24d75b0*/ string PlayerPrefsGetInt(string key);
            static /*0x24d7628*/ void PlayerPrefsSetInt(string key, int value);
            static /*0x24d7630*/ string PlayerPrefsGetFloat(string key);
            static /*0x24d76a8*/ void PlayerPrefsSetFloat(string key, float value);
            static /*0x24d76b0*/ string PlayerPrefsGetString(string key);
            static /*0x24d7718*/ void PlayerPrefsSetString(string key, string value);
            static /*0x24d7720*/ void PlayerPrefsDelete(string key);
            static /*0x24d7728*/ void PlayerPrefsClear();
            /*0x24d7730*/ PlayerPrefsCommands();
        }

        class SceneCommands
        {
            static /*0x24d7738*/ void LoadScene(string sceneName);
            static /*0x24d7874*/ void LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x24d7880*/ void LoadSceneAsync(string sceneName);
            static /*0x24d788c*/ void LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x24d7744*/ void LoadSceneInternal(string sceneName, bool isAsync, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x24d7898*/ void UnloadScene(string sceneName);
            static /*0x24d78f0*/ void RestartScene();
            /*0x24d7964*/ SceneCommands();
        }

        class TimeCommands
        {
            static /*0x24d796c*/ void SetTimeScale(float value);
            static /*0x24d797c*/ float GetTimeScale();
            /*0x24d7984*/ TimeCommands();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class AsyncMethodBuilderAttribute : System.Attribute
            {
                /*0x10*/ System.Type <BuilderType>k__BackingField;

                /*0x24d7994*/ AsyncMethodBuilderAttribute(System.Type builderType);
                /*0x24d798c*/ System.Type get_BuilderType();
            }
        }
    }
}

namespace ET
{
    struct AsyncETTaskCompletedMethodBuilder
    {
        static /*0x24d79bc*/ ET.AsyncETTaskCompletedMethodBuilder Create();
        /*0x24d79c4*/ ET.ETTaskCompleted get_Task();
        /*0x24d79cc*/ void SetException(System.Exception e);
        /*0x24d7a40*/ void SetResult();
        void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void Start<TStateMachine>(ref TStateMachine stateMachine);
        /*0x24d7a44*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct ETAsyncTaskMethodBuilder
    {
        /*0x10*/ ET.ETTask tcs;

        static /*0x24d7a48*/ ET.ETAsyncTaskMethodBuilder Create();
        /*0x24d7b90*/ ET.ETTask get_Task();
        /*0x24d7b98*/ void SetException(System.Exception exception);
        /*0x24d7c80*/ void SetResult();
        void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void Start<TStateMachine>(ref TStateMachine stateMachine);
        /*0x24d7d68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct ETAsyncTaskMethodBuilder<T>
    {
        /*0x0*/ ET.ETTask<T> tcs;

        static ET.ETAsyncTaskMethodBuilder<T> Create();
        ET.ETTask<T> get_Task();
        void SetException(System.Exception exception);
        void SetResult(T ret);
        void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void Start<TStateMachine>(ref TStateMachine stateMachine);
        void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct AsyncETVoidMethodBuilder
    {
        static /*0x24d7d6c*/ ET.AsyncETVoidMethodBuilder Create();
        /*0x24d7d74*/ ET.ETVoid get_Task();
        /*0x24d7d7c*/ void SetException(System.Exception e);
        /*0x24d7df0*/ void SetResult();
        void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        void Start<TStateMachine>(ref TStateMachine stateMachine);
        /*0x24d7df4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    class ETCancellationToken
    {
        /*0x10*/ System.Collections.Generic.HashSet<System.Action> actions;

        /*0x24d80f4*/ ETCancellationToken();
        /*0x24d7df8*/ void Add(System.Action callback);
        /*0x24d7e50*/ void Remove(System.Action callback);
        /*0x24d7eb0*/ bool IsCancel();
        /*0x24d7ec0*/ void Cancel();
        /*0x24d7ed0*/ void Invoke();
    }

    class ETTask : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        static /*0x0*/ System.Action<System.Exception> ExceptionHandler;
        static /*0x8*/ System.Collections.Generic.Queue<ET.ETTask> queue;
        /*0x10*/ bool fromPool;
        /*0x11*/ ET.AwaiterStatus state;
        /*0x18*/ object callback;

        static /*0x24d8530*/ ETTask();
        static /*0x24d8170*/ ET.ETTaskCompleted get_CompletedTask();
        static /*0x24d7a98*/ ET.ETTask Create(bool fromPool);
        /*0x24d8178*/ ETTask();
        /*0x24d8180*/ void Recycle();
        /*0x24d8280*/ ET.ETVoid InnerCoroutine();
        /*0x24d82ec*/ void Coroutine();
        /*0x24d830c*/ ET.ETTask GetAwaiter();
        /*0x24d8310*/ bool get_IsCompleted();
        /*0x24d8320*/ void UnsafeOnCompleted(System.Action action);
        /*0x24d8344*/ void OnCompleted(System.Action action);
        /*0x24d8368*/ void GetResult();
        /*0x24d7c98*/ void SetResult();
        /*0x24d8450*/ void SetException(System.Exception e);

        struct <InnerCoroutine>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x14*/ ET.AsyncETVoidMethodBuilder <>t__builder;
            /*0x18*/ ET.ETTask <>4__this;
            /*0x20*/ object <>u__1;

            /*0x24d95bc*/ void MoveNext();
            /*0x24d9788*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class ETTask<T> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        static /*0x0*/ System.Collections.Generic.Queue<ET.ETTask<T>> queue;
        /*0x0*/ bool fromPool;
        /*0x0*/ ET.AwaiterStatus state;
        /*0x0*/ T value;
        /*0x0*/ object callback;

        static ETTask();
        static ET.ETTask<T> Create(bool fromPool);
        ETTask();
        void Recycle();
        ET.ETVoid InnerCoroutine();
        void Coroutine();
        ET.ETTask<T> GetAwaiter();
        T GetResult();
        bool get_IsCompleted();
        void UnsafeOnCompleted(System.Action action);
        void OnCompleted(System.Action action);
        void SetResult(T result);
        void SetException(System.Exception e);

        struct <InnerCoroutine>d__8<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ ET.AsyncETVoidMethodBuilder <>t__builder;
            /*0x0*/ ET.ETTask<T> <>4__this;
            /*0x0*/ object <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct ETTaskCompleted : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        /*0x24d9794*/ ET.ETTaskCompleted GetAwaiter();
        /*0x24d979c*/ bool get_IsCompleted();
        /*0x24d97a4*/ void GetResult();
        /*0x24d97a8*/ void OnCompleted(System.Action continuation);
        /*0x24d97ac*/ void UnsafeOnCompleted(System.Action continuation);
    }

    class ETTaskHelper
    {
        static ET.ETTask<bool> WaitAny<T>(ET.ETTask<T> tasks, ET.ETCancellationToken cancellationToken);
        static /*0x24d97b0*/ ET.ETTask<bool> WaitAny(ET.ETTask[] tasks, ET.ETCancellationToken cancellationToken);
        static ET.ETTask<bool> WaitAll<T>(ET.ETTask<T> tasks, ET.ETCancellationToken cancellationToken);
        static ET.ETTask<bool> WaitAll<T>(System.Collections.Generic.List<ET.ETTask<T>> tasks, ET.ETCancellationToken cancellationToken);
        static /*0x24d9860*/ ET.ETTask<bool> WaitAll(ET.ETTask[] tasks, ET.ETCancellationToken cancellationToken);
        static /*0x24d9910*/ ET.ETTask<bool> WaitAll(System.Collections.Generic.List<ET.ETTask> tasks, ET.ETCancellationToken cancellationToken);

        class CoroutineBlocker
        {
            /*0x10*/ int count;
            /*0x18*/ System.Collections.Generic.List<ET.ETTask> tcss;

            /*0x24d99c0*/ CoroutineBlocker(int count);
            /*0x24d9a50*/ ET.ETTask WaitAsync();

            struct <WaitAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ ET.ETAsyncTaskMethodBuilder <>t__builder;
                /*0x20*/ ET.ETTaskHelper.CoroutineBlocker <>4__this;
                /*0x28*/ object <>u__1;

                /*0x24d9ad0*/ void MoveNext();
                /*0x24d9eb4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class <>c__DisplayClass1_0<T>
        {
            /*0x0*/ ET.ETTaskHelper.CoroutineBlocker coroutineBlocker;

            <>c__DisplayClass1_0();
            ET.ETVoid <WaitAny>g__RunOneTask|0(ET.ETTask<T> task);

            struct <<WaitAny>g__RunOneTask|0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ ET.AsyncETVoidMethodBuilder <>t__builder;
                /*0x0*/ ET.ETTask<T> task;
                /*0x0*/ ET.ETTaskHelper.<>c__DisplayClass1_0<T> <>4__this;
                /*0x0*/ object <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        struct <WaitAny>d__<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ ET.ETAsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x0*/ ET.ETTask<T> tasks;
            /*0x0*/ ET.ETCancellationToken cancellationToken;
            /*0x0*/ object <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ ET.ETTaskHelper.CoroutineBlocker coroutineBlocker;

            /*0x24d9ec0*/ <>c__DisplayClass2_0();
            /*0x24d9ec8*/ ET.ETVoid <WaitAny>g__RunOneTask|0(ET.ETTask task);

            struct <<WaitAny>g__RunOneTask|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ ET.AsyncETVoidMethodBuilder <>t__builder;
                /*0x18*/ ET.ETTask task;
                /*0x20*/ ET.ETTaskHelper.<> <>4__this;
                /*0x28*/ object <>u__1;

                /*0x24d9f64*/ void MoveNext();
                /*0x24da22c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        struct <WaitAny>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ ET.ETAsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x20*/ ET.ETTask[] tasks;
            /*0x28*/ ET.ETCancellationToken cancellationToken;
            /*0x30*/ object <>u__1;

            /*0x24da238*/ void MoveNext();
            /*0x24da550*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        class <>c__DisplayClass3_0<T>
        {
            /*0x0*/ ET.ETTaskHelper.CoroutineBlocker coroutineBlocker;

            <>c__DisplayClass3_0();
            ET.ETVoid <WaitAll>g__RunOneTask|0(ET.ETTask<T> task);

            struct <<WaitAll>g__RunOneTask|0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ ET.AsyncETVoidMethodBuilder <>t__builder;
                /*0x0*/ ET.ETTask<T> task;
                /*0x0*/ ET.ETTaskHelper.<>c__DisplayClass3_0<T> <>4__this;
                /*0x0*/ object <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        struct <WaitAll>d__3<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ ET.ETAsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x0*/ ET.ETTask<T> tasks;
            /*0x0*/ ET.ETCancellationToken cancellationToken;
            /*0x0*/ object <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        class <>c__DisplayClass4_0<T>
        {
            /*0x0*/ ET.ETTaskHelper.CoroutineBlocker coroutineBlocker;

            <>c__DisplayClass4_0();
            ET.ETVoid <WaitAll>g__RunOneTask|0(ET.ETTask<T> task);

            struct <<WaitAll>g__RunOneTask|0>d<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ ET.AsyncETVoidMethodBuilder <>t__builder;
                /*0x0*/ ET.ETTask<T> task;
                /*0x0*/ ET.ETTaskHelper.<>c__DisplayClass4_0<T> <>4__this;
                /*0x0*/ object <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        struct <WaitAll>d__4<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ ET.ETAsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x0*/ System.Collections.Generic.List<ET.ETTask<T>> tasks;
            /*0x0*/ ET.ETCancellationToken cancellationToken;
            /*0x0*/ object <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ ET.ETTaskHelper.CoroutineBlocker coroutineBlocker;

            /*0x24da5a8*/ <>c__DisplayClass5_0();
            /*0x24da5b0*/ ET.ETVoid <WaitAll>g__RunOneTask|0(ET.ETTask task);

            struct <<WaitAll>g__RunOneTask|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ ET.AsyncETVoidMethodBuilder <>t__builder;
                /*0x18*/ ET.ETTask task;
                /*0x20*/ ET.ETTaskHelper.<> <>4__this;
                /*0x28*/ object <>u__1;

                /*0x24da64c*/ void MoveNext();
                /*0x24da914*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        struct <WaitAll>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ ET.ETAsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x20*/ ET.ETTask[] tasks;
            /*0x28*/ ET.ETCancellationToken cancellationToken;
            /*0x30*/ object <>u__1;

            /*0x24da920*/ void MoveNext();
            /*0x24dac38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ ET.ETTaskHelper.CoroutineBlocker coroutineBlocker;

            /*0x24dac90*/ <>c__DisplayClass6_0();
            /*0x24dac98*/ ET.ETVoid <WaitAll>g__RunOneTask|0(ET.ETTask task);

            struct <<WaitAll>g__RunOneTask|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ ET.AsyncETVoidMethodBuilder <>t__builder;
                /*0x18*/ ET.ETTask task;
                /*0x20*/ ET.ETTaskHelper.<> <>4__this;
                /*0x28*/ object <>u__1;

                /*0x24dad34*/ void MoveNext();
                /*0x24daffc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        struct <WaitAll>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ ET.ETAsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x20*/ System.Collections.Generic.List<ET.ETTask> tasks;
            /*0x28*/ ET.ETCancellationToken cancellationToken;
            /*0x30*/ object <>u__1;

            /*0x24db008*/ void MoveNext();
            /*0x24db424*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct ETVoid : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        /*0x24da54c*/ void Coroutine();
        /*0x24db47c*/ bool get_IsCompleted();
        /*0x24db484*/ void OnCompleted(System.Action continuation);
        /*0x24db488*/ void UnsafeOnCompleted(System.Action continuation);
    }

    enum AwaiterStatus
    {
        Pending = 0,
        Succeeded = 1,
        Faulted = 2,
    }
}

namespace Entitas
{
    class Collector<TEntity> : Entitas.ICollector<TEntity>, Entitas.ICollector
    {
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _collectedEntities;
        /*0x0*/ Entitas.IGroup<TEntity> _groups;
        /*0x0*/ Entitas.GroupEvent[] _groupEvents;
        /*0x0*/ Entitas.GroupChanged<TEntity> _addEntityCache;
        /*0x0*/ string _toStringCache;
        /*0x0*/ System.Text.StringBuilder _toStringBuilder;

        Collector(Entitas.IGroup<TEntity> group, Entitas.GroupEvent groupEvent);
        Collector(Entitas.IGroup<TEntity> groups, Entitas.GroupEvent[] groupEvents);
        System.Collections.Generic.HashSet<TEntity> get_collectedEntities();
        int get_count();
        void Activate();
        void Deactivate();
        System.Collections.Generic.IEnumerable<TCast> GetCollectedEntities<TCast>();
        void ClearCollectedEntities();
        void addEntity(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent component);
        string ToString();
        void Finalize();
    }

    class CollectorContextExtension
    {
        static Entitas.ICollector<TEntity> CreateCollector<TEntity>(Entitas.IContext<TEntity> context, Entitas.IMatcher<TEntity> matcher);
        static Entitas.ICollector<TEntity> CreateCollector<TEntity>(Entitas.IContext<TEntity> context, Entitas.TriggerOnEvent<TEntity> triggers);
    }

    class CollectorException : Entitas.EntitasException
    {
        /*0x24db48c*/ CollectorException(string message, string hint);
    }

    interface ICollector
    {
        int get_count();
        void Activate();
        void Deactivate();
        void ClearCollectedEntities();
        System.Collections.Generic.IEnumerable<TCast> GetCollectedEntities<TCast>();
    }

    interface ICollector<TEntity> : Entitas.ICollector
    {
        System.Collections.Generic.HashSet<TEntity> get_collectedEntities();
    }

    struct TriggerOnEvent<TEntity>
    {
        /*0x0*/ Entitas.IMatcher<TEntity> matcher;
        /*0x0*/ Entitas.GroupEvent groupEvent;

        TriggerOnEvent(Entitas.IMatcher<TEntity> matcher, Entitas.GroupEvent groupEvent);
    }

    class TriggerOnEventMatcherExtension
    {
        static Entitas.TriggerOnEvent<TEntity> Added<TEntity>(Entitas.IMatcher<TEntity> matcher);
        static Entitas.TriggerOnEvent<TEntity> Removed<TEntity>(Entitas.IMatcher<TEntity> matcher);
        static Entitas.TriggerOnEvent<TEntity> AddedOrRemoved<TEntity>(Entitas.IMatcher<TEntity> matcher);
    }

    class Context<TEntity> : Entitas.IContext<TEntity>, Entitas.IContext
    {
        /*0x0*/ Entitas.ContextEntityChanged OnEntityCreated;
        /*0x0*/ Entitas.ContextEntityChanged OnEntityWillBeDestroyed;
        /*0x0*/ Entitas.ContextEntityChanged OnEntityDestroyed;
        /*0x0*/ Entitas.ContextGroupChanged OnGroupCreated;
        /*0x0*/ int _totalComponents;
        /*0x0*/ System.Collections.Generic.Stack<Entitas.IComponent> _componentPools;
        /*0x0*/ Entitas.ContextInfo _contextInfo;
        /*0x0*/ System.Func<Entitas.IEntity, Entitas.IAERC> _aercFactory;
        /*0x0*/ System.Func<TEntity> _entityFactory;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _entities;
        /*0x0*/ System.Collections.Generic.Stack<TEntity> _reusableEntities;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _retainedEntities;
        /*0x0*/ System.Collections.Generic.Dictionary<Entitas.IMatcher<TEntity>, Entitas.IGroup<TEntity>> _groups;
        /*0x0*/ System.Collections.Generic.List<Entitas.IGroup<TEntity>> _groupsForIndex;
        /*0x0*/ DesperateDevs.Utils.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<TEntity>>> _groupChangedListPool;
        /*0x0*/ System.Collections.Generic.Dictionary<string, Entitas.IEntityIndex> _entityIndices;
        /*0x0*/ int _creationIndex;
        /*0x0*/ TEntity[] _entitiesCache;
        /*0x0*/ Entitas.EntityComponentChanged _cachedEntityChanged;
        /*0x0*/ Entitas.EntityComponentReplaced _cachedComponentReplaced;
        /*0x0*/ Entitas.EntityEvent _cachedEntityReleased;
        /*0x0*/ Entitas.EntityEvent _cachedDestroyEntity;

        Context(int totalComponents, System.Func<TEntity> entityFactory);
        Context(int totalComponents, int startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity, Entitas.IAERC> aercFactory, System.Func<TEntity> entityFactory);
        void add_OnEntityCreated(Entitas.ContextEntityChanged value);
        void remove_OnEntityCreated(Entitas.ContextEntityChanged value);
        void add_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value);
        void remove_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value);
        void add_OnEntityDestroyed(Entitas.ContextEntityChanged value);
        void remove_OnEntityDestroyed(Entitas.ContextEntityChanged value);
        void add_OnGroupCreated(Entitas.ContextGroupChanged value);
        void remove_OnGroupCreated(Entitas.ContextGroupChanged value);
        int get_totalComponents();
        System.Collections.Generic.Stack<Entitas.IComponent> get_componentPools();
        Entitas.ContextInfo get_contextInfo();
        int get_count();
        int get_reusableEntitiesCount();
        int get_retainedEntitiesCount();
        Entitas.ContextInfo createDefaultContextInfo();
        TEntity CreateEntity();
        void DestroyAllEntities();
        bool HasEntity(TEntity entity);
        TEntity[] GetEntities();
        Entitas.IGroup<TEntity> GetGroup(Entitas.IMatcher<TEntity> matcher);
        void AddEntityIndex(Entitas.IEntityIndex entityIndex);
        Entitas.IEntityIndex GetEntityIndex(string name);
        void ResetCreationIndex();
        void ClearComponentPool(int index);
        void ClearComponentPools();
        void Reset();
        void RemoveAllEventHandlers();
        string ToString();
        void updateGroupsComponentAddedOrRemoved(Entitas.IEntity entity, int index, Entitas.IComponent component);
        void updateGroupsComponentReplaced(Entitas.IEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        void onEntityReleased(Entitas.IEntity entity);
        void onDestroyEntity(Entitas.IEntity entity);

        class <>c<TEntity>
        {
            static /*0x0*/ Entitas.Context.<>c<TEntity> <>9;
            static /*0x0*/ System.Func<Entitas.IEntity, Entitas.IAERC> <>9__43_0;
            static /*0x0*/ System.Func<System.Collections.Generic.List<Entitas.GroupChanged<TEntity>>> <>9__43_1;
            static /*0x0*/ System.Action<System.Collections.Generic.List<Entitas.GroupChanged<TEntity>>> <>9__43_2;

            static <>c();
            <>c();
            Entitas.IAERC <.ctor>b__43_0(Entitas.IEntity entity);
            System.Collections.Generic.List<Entitas.GroupChanged<TEntity>> <.ctor>b__43_1();
            void <.ctor>b__43_2(System.Collections.Generic.List<Entitas.GroupChanged<TEntity>> list);
        }
    }

    class ContextExtension
    {
        static TEntity[] GetEntities<TEntity>(Entitas.IContext<TEntity> context, Entitas.IMatcher<TEntity> matcher);
        static TEntity CloneEntity<TEntity>(Entitas.IContext<TEntity> context, Entitas.IEntity entity, bool replaceExisting, int[] indices);
    }

    class ContextDoesNotContainEntityException : Entitas.EntitasException
    {
        /*0x24db52c*/ ContextDoesNotContainEntityException(string message, string hint);
    }

    class ContextEntityIndexDoesAlreadyExistException : Entitas.EntitasException
    {
        /*0x24db598*/ ContextEntityIndexDoesAlreadyExistException(Entitas.IContext context, string name);
    }

    class ContextEntityIndexDoesNotExistException : Entitas.EntitasException
    {
        /*0x24db760*/ ContextEntityIndexDoesNotExistException(Entitas.IContext context, string name);
    }

    class ContextInfoException : Entitas.EntitasException
    {
        /*0x24db928*/ ContextInfoException(Entitas.IContext context, Entitas.ContextInfo contextInfo);
    }

    class ContextStillHasRetainedEntitiesException : Entitas.EntitasException
    {
        /*0x24dbc34*/ ContextStillHasRetainedEntitiesException(Entitas.IContext context, Entitas.IEntity[] entities);

        class <>c
        {
            static /*0x0*/ Entitas.ContextStillHasRetainedEntitiesException.<> <>9;
            static /*0x8*/ System.Func<object, string> <>9__0_1;
            static /*0x10*/ System.Func<Entitas.IEntity, string> <>9__0_0;

            static /*0x24dbe28*/ <>c();
            /*0x24dbe8c*/ <>c();
            /*0x24dbe94*/ string <.ctor>b__0_0(Entitas.IEntity e);
            /*0x24dc0e4*/ string <.ctor>b__0_1(object o);
        }
    }

    class EntityIsNotDestroyedException : Entitas.EntitasException
    {
        /*0x24dc104*/ EntityIsNotDestroyedException(string message);
    }

    class ContextEntityChanged : System.MulticastDelegate
    {
        /*0x24dc180*/ ContextEntityChanged(object object, nint method);
        /*0x24dc2b0*/ void Invoke(Entitas.IContext context, Entitas.IEntity entity);
        /*0x24dc2c4*/ System.IAsyncResult BeginInvoke(Entitas.IContext context, Entitas.IEntity entity, System.AsyncCallback callback, object object);
        /*0x24dc2ec*/ void EndInvoke(System.IAsyncResult result);
    }

    class ContextGroupChanged : System.MulticastDelegate
    {
        /*0x24dc2f8*/ ContextGroupChanged(object object, nint method);
        /*0x24dc428*/ void Invoke(Entitas.IContext context, Entitas.IGroup group);
        /*0x24dc43c*/ System.IAsyncResult BeginInvoke(Entitas.IContext context, Entitas.IGroup group, System.AsyncCallback callback, object object);
        /*0x24dc464*/ void EndInvoke(System.IAsyncResult result);
    }

    interface IContext
    {
        void add_OnEntityCreated(Entitas.ContextEntityChanged value);
        void remove_OnEntityCreated(Entitas.ContextEntityChanged value);
        void add_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value);
        void remove_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value);
        void add_OnEntityDestroyed(Entitas.ContextEntityChanged value);
        void remove_OnEntityDestroyed(Entitas.ContextEntityChanged value);
        void add_OnGroupCreated(Entitas.ContextGroupChanged value);
        void remove_OnGroupCreated(Entitas.ContextGroupChanged value);
        int get_totalComponents();
        System.Collections.Generic.Stack<Entitas.IComponent> get_componentPools();
        Entitas.ContextInfo get_contextInfo();
        int get_count();
        int get_reusableEntitiesCount();
        int get_retainedEntitiesCount();
        void DestroyAllEntities();
        void AddEntityIndex(Entitas.IEntityIndex entityIndex);
        Entitas.IEntityIndex GetEntityIndex(string name);
        void ResetCreationIndex();
        void ClearComponentPool(int index);
        void ClearComponentPools();
        void RemoveAllEventHandlers();
        void Reset();
    }

    interface IContext<TEntity> : Entitas.IContext
    {
        TEntity CreateEntity();
        bool HasEntity(TEntity entity);
        TEntity[] GetEntities();
        Entitas.IGroup<TEntity> GetGroup(Entitas.IMatcher<TEntity> matcher);
    }

    interface IContexts
    {
        Entitas.IContext[] get_allContexts();
    }

    class ContextInfo
    {
        /*0x10*/ string name;
        /*0x18*/ string[] componentNames;
        /*0x20*/ System.Type[] componentTypes;

        /*0x24dc470*/ ContextInfo(string name, string[] componentNames, System.Type[] componentTypes);
    }

    class EntitasException : System.Exception
    {
        /*0x24db490*/ EntitasException(string message, string hint);
    }

    class EntitasResources
    {
        static /*0x24dc4ac*/ string GetVersion();
    }

    class Entity : Entitas.IEntity, Entitas.IAERC
    {
        /*0x10*/ Entitas.EntityComponentChanged OnComponentAdded;
        /*0x18*/ Entitas.EntityComponentChanged OnComponentRemoved;
        /*0x20*/ Entitas.EntityComponentReplaced OnComponentReplaced;
        /*0x28*/ Entitas.EntityEvent OnEntityReleased;
        /*0x30*/ Entitas.EntityEvent OnDestroyEntity;
        /*0x38*/ System.Collections.Generic.List<Entitas.IComponent> _componentBuffer;
        /*0x40*/ System.Collections.Generic.List<int> _indexBuffer;
        /*0x48*/ int _creationIndex;
        /*0x4c*/ bool _isEnabled;
        /*0x50*/ int _totalComponents;
        /*0x58*/ Entitas.IComponent[] _components;
        /*0x60*/ System.Collections.Generic.Stack<Entitas.IComponent> _componentPools;
        /*0x68*/ Entitas.ContextInfo _contextInfo;
        /*0x70*/ Entitas.IAERC _aerc;
        /*0x78*/ Entitas.IComponent[] _componentsCache;
        /*0x80*/ int[] _componentIndicesCache;
        /*0x88*/ string _toStringCache;
        /*0x90*/ System.Text.StringBuilder _toStringBuilder;

        /*0x24dcb34*/ Entity();
        /*0x24dc4ec*/ void add_OnComponentAdded(Entitas.EntityComponentChanged value);
        /*0x24dc588*/ void remove_OnComponentAdded(Entitas.EntityComponentChanged value);
        /*0x24dc624*/ void add_OnComponentRemoved(Entitas.EntityComponentChanged value);
        /*0x24dc6c0*/ void remove_OnComponentRemoved(Entitas.EntityComponentChanged value);
        /*0x24dc75c*/ void add_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        /*0x24dc7f8*/ void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        /*0x24dc894*/ void add_OnEntityReleased(Entitas.EntityEvent value);
        /*0x24dc930*/ void remove_OnEntityReleased(Entitas.EntityEvent value);
        /*0x24dc9cc*/ void add_OnDestroyEntity(Entitas.EntityEvent value);
        /*0x24dca68*/ void remove_OnDestroyEntity(Entitas.EntityEvent value);
        /*0x24dcb04*/ int get_totalComponents();
        /*0x24dcb0c*/ int get_creationIndex();
        /*0x24dcb14*/ bool get_isEnabled();
        /*0x24dcb1c*/ System.Collections.Generic.Stack<Entitas.IComponent> get_componentPools();
        /*0x24dcb24*/ Entitas.ContextInfo get_contextInfo();
        /*0x24dcb2c*/ Entitas.IAERC get_aerc();
        /*0x24dcbf8*/ void Initialize(int creationIndex, int totalComponents, System.Collections.Generic.Stack<Entitas.IComponent> componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc);
        /*0x24dcce0*/ Entitas.ContextInfo createDefaultContextInfo();
        /*0x24dccd0*/ void Reactivate(int creationIndex);
        /*0x24dce94*/ void AddComponent(int index, Entitas.IComponent component);
        /*0x24dd3f8*/ void RemoveComponent(int index);
        /*0x24dd9bc*/ void ReplaceComponent(int index, Entitas.IComponent component);
        /*0x24dd844*/ void replaceComponent(int index, Entitas.IComponent replacement);
        /*0x24ddcbc*/ Entitas.IComponent GetComponent(int index);
        /*0x24ddec8*/ Entitas.IComponent[] GetComponents();
        /*0x24de014*/ int[] GetComponentIndices();
        /*0x24dd31c*/ bool HasComponent(int index);
        /*0x24de148*/ bool HasComponents(int[] indices);
        /*0x24de1b0*/ bool HasAnyComponent(int[] indices);
        /*0x24de218*/ void RemoveAllComponents();
        /*0x24ddbd8*/ System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(int index);
        /*0x24de284*/ Entitas.IComponent CreateComponent(int index, System.Type type);
        T CreateComponent<T>(int index);
        /*0x24de358*/ int get_retainCount();
        /*0x24de3f8*/ void Retain(object owner);
        /*0x24de4a4*/ void Release(object owner);
        /*0x24de5e8*/ void Destroy();
        /*0x24de6bc*/ void InternalDestroy();
        /*0x24de6e0*/ void RemoveAllOnEntityReleasedHandlers();
        /*0x24de6e8*/ string ToString();
    }

    class EntityEqualityComparer<TEntity> : System.Collections.Generic.IEqualityComparer<TEntity>
    {
        static /*0x0*/ System.Collections.Generic.IEqualityComparer<TEntity> comparer;

        static EntityEqualityComparer();
        EntityEqualityComparer();
        bool Equals(TEntity x, TEntity y);
        int GetHashCode(TEntity obj);
    }

    class EntityAlreadyHasComponentException : Entitas.EntitasException
    {
        /*0x24dd354*/ EntityAlreadyHasComponentException(int index, string message, string hint);
    }

    class EntityDoesNotHaveComponentException : Entitas.EntitasException
    {
        /*0x24dd7a0*/ EntityDoesNotHaveComponentException(int index, string message, string hint);
    }

    class EntityIsAlreadyRetainedByOwnerException : Entitas.EntitasException
    {
        /*0x24de8cc*/ EntityIsAlreadyRetainedByOwnerException(Entitas.IEntity entity, object owner);
    }

    class EntityIsNotEnabledException : Entitas.EntitasException
    {
        /*0x24dd2a0*/ EntityIsNotEnabledException(string message);
    }

    class EntityIsNotRetainedByOwnerException : Entitas.EntitasException
    {
        /*0x24deaac*/ EntityIsNotRetainedByOwnerException(Entitas.IEntity entity, object owner);
    }

    interface IAERC
    {
        int get_retainCount();
        void Retain(object owner);
        void Release(object owner);
    }

    class EntityComponentChanged : System.MulticastDelegate
    {
        /*0x24dec8c*/ EntityComponentChanged(object object, nint method);
        /*0x24dedbc*/ void Invoke(Entitas.IEntity entity, int index, Entitas.IComponent component);
        /*0x24dedd0*/ System.IAsyncResult BeginInvoke(Entitas.IEntity entity, int index, Entitas.IComponent component, System.AsyncCallback callback, object object);
        /*0x24dee68*/ void EndInvoke(System.IAsyncResult result);
    }

    class EntityComponentReplaced : System.MulticastDelegate
    {
        /*0x24dee74*/ EntityComponentReplaced(object object, nint method);
        /*0x24defa4*/ void Invoke(Entitas.IEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        /*0x24defb8*/ System.IAsyncResult BeginInvoke(Entitas.IEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent, System.AsyncCallback callback, object object);
        /*0x24df060*/ void EndInvoke(System.IAsyncResult result);
    }

    class EntityEvent : System.MulticastDelegate
    {
        /*0x24df06c*/ EntityEvent(object object, nint method);
        /*0x24df198*/ void Invoke(Entitas.IEntity entity);
        /*0x24df1ac*/ System.IAsyncResult BeginInvoke(Entitas.IEntity entity, System.AsyncCallback callback, object object);
        /*0x24df1cc*/ void EndInvoke(System.IAsyncResult result);
    }

    interface IEntity : Entitas.IAERC
    {
        void add_OnComponentAdded(Entitas.EntityComponentChanged value);
        void remove_OnComponentAdded(Entitas.EntityComponentChanged value);
        void add_OnComponentRemoved(Entitas.EntityComponentChanged value);
        void remove_OnComponentRemoved(Entitas.EntityComponentChanged value);
        void add_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value);
        void add_OnEntityReleased(Entitas.EntityEvent value);
        void remove_OnEntityReleased(Entitas.EntityEvent value);
        void add_OnDestroyEntity(Entitas.EntityEvent value);
        void remove_OnDestroyEntity(Entitas.EntityEvent value);
        int get_totalComponents();
        int get_creationIndex();
        bool get_isEnabled();
        System.Collections.Generic.Stack<Entitas.IComponent> get_componentPools();
        Entitas.ContextInfo get_contextInfo();
        Entitas.IAERC get_aerc();
        void Initialize(int creationIndex, int totalComponents, System.Collections.Generic.Stack<Entitas.IComponent> componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc);
        void Reactivate(int creationIndex);
        void AddComponent(int index, Entitas.IComponent component);
        void RemoveComponent(int index);
        void ReplaceComponent(int index, Entitas.IComponent component);
        Entitas.IComponent GetComponent(int index);
        Entitas.IComponent[] GetComponents();
        int[] GetComponentIndices();
        bool HasComponent(int index);
        bool HasComponents(int[] indices);
        bool HasAnyComponent(int[] indices);
        void RemoveAllComponents();
        System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(int index);
        Entitas.IComponent CreateComponent(int index, System.Type type);
        T CreateComponent<T>(int index);
        void Destroy();
        void InternalDestroy();
        void RemoveAllOnEntityReleasedHandlers();
    }

    class SafeAERC : Entitas.IAERC
    {
        /*0x10*/ Entitas.IEntity _entity;
        /*0x18*/ System.Collections.Generic.HashSet<object> _owners;

        /*0x24dce04*/ SafeAERC(Entitas.IEntity entity);
        /*0x24df1d8*/ int get_retainCount();
        /*0x24df220*/ System.Collections.Generic.HashSet<object> get_owners();
        /*0x24df228*/ void Retain(object owner);
        /*0x24df2cc*/ void Release(object owner);
    }

    class UnsafeAERC : Entitas.IAERC
    {
        /*0x10*/ int _retainCount;

        /*0x24df398*/ UnsafeAERC();
        /*0x24df370*/ int get_retainCount();
        /*0x24df378*/ void Retain(object owner);
        /*0x24df388*/ void Release(object owner);
    }

    class AbstractEntityIndex<TEntity, TKey> : Entitas.IEntityIndex
    {
        /*0x0*/ string _name;
        /*0x0*/ Entitas.IGroup<TEntity> _group;
        /*0x0*/ System.Func<TEntity, Entitas.IComponent, TKey> _getKey;
        /*0x0*/ System.Func<TEntity, Entitas.IComponent, TKey[]> _getKeys;
        /*0x0*/ bool _isSingleKey;

        AbstractEntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey> getKey);
        AbstractEntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey[]> getKeys);
        string get_name();
        void Activate();
        void Deactivate();
        string ToString();
        void indexEntities(Entitas.IGroup<TEntity> group);
        void onEntityAdded(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent component);
        void onEntityRemoved(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent component);
        void addEntity(TKey key, TEntity entity);
        void removeEntity(TKey key, TEntity entity);
        void clear();
        void Finalize();
    }

    class EntityIndex<TEntity, TKey> : Entitas.AbstractEntityIndex<TEntity, TKey>
    {
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.HashSet<TEntity>> _index;

        EntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey> getKey);
        EntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey[]> getKeys);
        EntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey> getKey, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        EntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey[]> getKeys, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        void Activate();
        System.Collections.Generic.HashSet<TEntity> GetEntities(TKey key);
        string ToString();
        void clear();
        void addEntity(TKey key, TEntity entity);
        void removeEntity(TKey key, TEntity entity);
    }

    class EntityIndexException : Entitas.EntitasException
    {
        /*0x24df3a0*/ EntityIndexException(string message, string hint);
    }

    interface IEntityIndex
    {
        string get_name();
        void Activate();
        void Deactivate();
    }

    class PrimaryEntityIndex<TEntity, TKey> : Entitas.AbstractEntityIndex<TEntity, TKey>
    {
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, TEntity> _index;

        PrimaryEntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey> getKey);
        PrimaryEntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey[]> getKeys);
        PrimaryEntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey> getKey, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        PrimaryEntityIndex(string name, Entitas.IGroup<TEntity> group, System.Func<TEntity, Entitas.IComponent, TKey[]> getKeys, System.Collections.Generic.IEqualityComparer<TKey> comparer);
        void Activate();
        TEntity GetEntity(TKey key);
        string ToString();
        void clear();
        void addEntity(TKey key, TEntity entity);
        void removeEntity(TKey key, TEntity entity);
    }

    class CollectionExtension
    {
        static /*0x24df3a4*/ Entitas.IEntity SingleEntity(System.Collections.Generic.ICollection<Entitas.IEntity> collection);
        static TEntity SingleEntity<TEntity>(System.Collections.Generic.ICollection<TEntity> collection);
    }

    class SingleEntityException : Entitas.EntitasException
    {
        /*0x24df4cc*/ SingleEntityException(int count);
    }

    class EntitasStringExtension
    {
        static string CONTEXT_SUFFIX = "Context";
        static string ENTITY_SUFFIX = "Entity";
        static string COMPONENT_SUFFIX = "Component";
        static string SYSTEM_SUFFIX = "System";
        static string MATCHER_SUFFIX = "Matcher";
        static string LISTENER_SUFFIX = "Listener";

        static /*0x24df57c*/ string AddContextSuffix(string str);
        static /*0x24df614*/ string RemoveContextSuffix(string str);
        static /*0x24df6bc*/ bool HasContextSuffix(string str);
        static /*0x24df72c*/ string AddEntitySuffix(string str);
        static /*0x24df774*/ string RemoveEntitySuffix(string str);
        static /*0x24df7bc*/ bool HasEntitySuffix(string str);
        static /*0x24df814*/ string AddComponentSuffix(string str);
        static /*0x24df85c*/ string RemoveComponentSuffix(string str);
        static /*0x24df8a4*/ bool HasComponentSuffix(string str);
        static /*0x24df8fc*/ string AddSystemSuffix(string str);
        static /*0x24df944*/ string RemoveSystemSuffix(string str);
        static /*0x24df98c*/ bool HasSystemSuffix(string str);
        static /*0x24df9e4*/ string AddMatcherSuffix(string str);
        static /*0x24dfa2c*/ string RemoveMatcherSuffix(string str);
        static /*0x24dfa74*/ bool HasMatcherSuffix(string str);
        static /*0x24dfacc*/ string AddListenerSuffix(string str);
        static /*0x24dfb14*/ string RemoveListenerSuffix(string str);
        static /*0x24dfb5c*/ bool HasListenerSuffix(string str);
        static /*0x24df5c4*/ string addSuffix(string str, string suffix);
        static /*0x24df65c*/ string removeSuffix(string str, string suffix);
        static /*0x24df714*/ bool hasSuffix(string str, string suffix);
    }

    class PublicMemberInfoEntityExtension
    {
        static /*0x24dfbb4*/ void CopyTo(Entitas.IEntity entity, Entitas.IEntity target, bool replaceExisting, int[] indices);
    }

    class Group<TEntity> : Entitas.IGroup<TEntity>, Entitas.IGroup
    {
        /*0x0*/ Entitas.GroupChanged<TEntity> OnEntityAdded;
        /*0x0*/ Entitas.GroupChanged<TEntity> OnEntityRemoved;
        /*0x0*/ Entitas.GroupUpdated<TEntity> OnEntityUpdated;
        /*0x0*/ Entitas.IMatcher<TEntity> _matcher;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _entities;
        /*0x0*/ TEntity[] _entitiesCache;
        /*0x0*/ TEntity _singleEntityCache;
        /*0x0*/ string _toStringCache;

        Group(Entitas.IMatcher<TEntity> matcher);
        void add_OnEntityAdded(Entitas.GroupChanged<TEntity> value);
        void remove_OnEntityAdded(Entitas.GroupChanged<TEntity> value);
        void add_OnEntityRemoved(Entitas.GroupChanged<TEntity> value);
        void remove_OnEntityRemoved(Entitas.GroupChanged<TEntity> value);
        void add_OnEntityUpdated(Entitas.GroupUpdated<TEntity> value);
        void remove_OnEntityUpdated(Entitas.GroupUpdated<TEntity> value);
        int get_count();
        Entitas.IMatcher<TEntity> get_matcher();
        void HandleEntitySilently(TEntity entity);
        void HandleEntity(TEntity entity, int index, Entitas.IComponent component);
        void UpdateEntity(TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        void RemoveAllEventHandlers();
        Entitas.GroupChanged<TEntity> HandleEntity(TEntity entity);
        bool addEntitySilently(TEntity entity);
        void addEntity(TEntity entity, int index, Entitas.IComponent component);
        bool removeEntitySilently(TEntity entity);
        void removeEntity(TEntity entity, int index, Entitas.IComponent component);
        bool ContainsEntity(TEntity entity);
        TEntity[] GetEntities();
        System.Collections.Generic.List<TEntity> GetEntities(System.Collections.Generic.List<TEntity> buffer);
        System.Collections.Generic.IEnumerable<TEntity> AsEnumerable();
        System.Collections.Generic.HashSet.Enumerator<TEntity> GetEnumerator();
        TEntity GetSingleEntity();
        string ToString();
    }

    enum GroupEvent
    {
        Added = 0,
        Removed = 1,
        AddedOrRemoved = 2,
    }

    class GroupExtension
    {
        static Entitas.ICollector<TEntity> CreateCollector<TEntity>(Entitas.IGroup<TEntity> group, Entitas.GroupEvent groupEvent);
    }

    class GroupSingleEntityException<TEntity> : Entitas.EntitasException
    {
        GroupSingleEntityException(Entitas.IGroup<TEntity> group);

        class <>c<TEntity>
        {
            static /*0x0*/ Entitas.GroupSingleEntityException.<>c<TEntity> <>9;
            static /*0x0*/ System.Func<TEntity, string> <>9__0_0;

            static <>c();
            <>c();
            string <.ctor>b__0_0(TEntity e);
        }
    }

    class GroupChanged<TEntity> : System.MulticastDelegate
    {
        GroupChanged(object object, nint method);
        void Invoke(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent component);
        System.IAsyncResult BeginInvoke(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent component, System.AsyncCallback callback, object object);
        void EndInvoke(System.IAsyncResult result);
    }

    class GroupUpdated<TEntity> : System.MulticastDelegate
    {
        GroupUpdated(object object, nint method);
        void Invoke(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        System.IAsyncResult BeginInvoke(Entitas.IGroup<TEntity> group, TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent, System.AsyncCallback callback, object object);
        void EndInvoke(System.IAsyncResult result);
    }

    interface IGroup
    {
        int get_count();
        void RemoveAllEventHandlers();
    }

    interface IGroup<TEntity> : Entitas.IGroup
    {
        void add_OnEntityAdded(Entitas.GroupChanged<TEntity> value);
        void remove_OnEntityAdded(Entitas.GroupChanged<TEntity> value);
        void add_OnEntityRemoved(Entitas.GroupChanged<TEntity> value);
        void remove_OnEntityRemoved(Entitas.GroupChanged<TEntity> value);
        void add_OnEntityUpdated(Entitas.GroupUpdated<TEntity> value);
        void remove_OnEntityUpdated(Entitas.GroupUpdated<TEntity> value);
        Entitas.IMatcher<TEntity> get_matcher();
        void HandleEntitySilently(TEntity entity);
        void HandleEntity(TEntity entity, int index, Entitas.IComponent component);
        Entitas.GroupChanged<TEntity> HandleEntity(TEntity entity);
        void UpdateEntity(TEntity entity, int index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent);
        bool ContainsEntity(TEntity entity);
        TEntity[] GetEntities();
        System.Collections.Generic.List<TEntity> GetEntities(System.Collections.Generic.List<TEntity> buffer);
        TEntity GetSingleEntity();
        System.Collections.Generic.IEnumerable<TEntity> AsEnumerable();
        System.Collections.Generic.HashSet.Enumerator<TEntity> GetEnumerator();
    }

    interface IComponent
    {
    }

    interface IAllOfMatcher<TEntity> : Entitas.IAnyOfMatcher<TEntity>, Entitas.INoneOfMatcher<TEntity>, Entitas.ICompoundMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
        Entitas.IAnyOfMatcher<TEntity> AnyOf(int[] indices);
        Entitas.IAnyOfMatcher<TEntity> AnyOf(Entitas.IMatcher<TEntity> matchers);
    }

    interface IAnyOfMatcher<TEntity> : Entitas.INoneOfMatcher<TEntity>, Entitas.ICompoundMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
        Entitas.INoneOfMatcher<TEntity> NoneOf(int[] indices);
        Entitas.INoneOfMatcher<TEntity> NoneOf(Entitas.IMatcher<TEntity> matchers);
    }

    interface ICompoundMatcher<TEntity> : Entitas.IMatcher<TEntity>
    {
        int[] get_allOfIndices();
        int[] get_anyOfIndices();
        int[] get_noneOfIndices();
    }

    interface IMatcher<TEntity>
    {
        int[] get_indices();
        bool Matches(TEntity entity);
    }

    interface INoneOfMatcher<TEntity> : Entitas.ICompoundMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
    }

    class Matcher<TEntity> : Entitas.IAllOfMatcher<TEntity>, Entitas.IAnyOfMatcher<TEntity>, Entitas.INoneOfMatcher<TEntity>, Entitas.ICompoundMatcher<TEntity>, Entitas.IMatcher<TEntity>
    {
        static /*0x0*/ System.Collections.Generic.List<int> _indexBuffer;
        static /*0x0*/ System.Collections.Generic.HashSet<int> _indexSetBuffer;
        /*0x0*/ string[] <componentNames>k__BackingField;
        /*0x0*/ int[] _indices;
        /*0x0*/ int[] _allOfIndices;
        /*0x0*/ int[] _anyOfIndices;
        /*0x0*/ int[] _noneOfIndices;
        /*0x0*/ int _hash;
        /*0x0*/ bool _isHashCached;
        /*0x0*/ string _toStringCache;
        /*0x0*/ System.Text.StringBuilder _toStringBuilder;

        static Matcher();
        static bool equalIndices(int[] i1, int[] i2);
        static int applyHash(int hash, int[] indices, int i1, int i2);
        static Entitas.IAllOfMatcher<TEntity> AllOf(int[] indices);
        static Entitas.IAllOfMatcher<TEntity> AllOf(Entitas.IMatcher<TEntity> matchers);
        static Entitas.IAnyOfMatcher<TEntity> AnyOf(int[] indices);
        static Entitas.IAnyOfMatcher<TEntity> AnyOf(Entitas.IMatcher<TEntity> matchers);
        static int[] mergeIndices(int[] allOfIndices, int[] anyOfIndices, int[] noneOfIndices);
        static int[] mergeIndices(Entitas.IMatcher<TEntity> matchers);
        static string[] getComponentNames(Entitas.IMatcher<TEntity> matchers);
        static void setComponentNames(Entitas.Matcher<TEntity> matcher, Entitas.IMatcher<TEntity> matchers);
        static int[] distinctIndices(System.Collections.Generic.IList<int> indices);
        static void appendIndices(System.Text.StringBuilder sb, string prefix, int[] indexArray, string[] componentNames);
        Matcher();
        int[] get_indices();
        int[] get_allOfIndices();
        int[] get_anyOfIndices();
        int[] get_noneOfIndices();
        string[] get_componentNames();
        void set_componentNames(string[] value);
        Entitas.IAnyOfMatcher<TEntity> Entitas.IAllOfMatcher<TEntity>.AnyOf(int[] indices);
        Entitas.IAnyOfMatcher<TEntity> Entitas.IAllOfMatcher<TEntity>.AnyOf(Entitas.IMatcher<TEntity> matchers);
        Entitas.INoneOfMatcher<TEntity> NoneOf(int[] indices);
        Entitas.INoneOfMatcher<TEntity> NoneOf(Entitas.IMatcher<TEntity> matchers);
        bool Matches(TEntity entity);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }

    class MatcherException : System.Exception
    {
        /*0x24dfe5c*/ MatcherException(int indices);
    }

    interface ICleanupSystem : Entitas.ISystem
    {
        void Cleanup();
    }

    interface IExecuteSystem : Entitas.ISystem
    {
        void Execute();
    }

    interface IInitializeSystem : Entitas.ISystem
    {
        void Initialize();
    }

    interface IReactiveSystem : Entitas.IExecuteSystem, Entitas.ISystem
    {
        void Activate();
        void Deactivate();
        void Clear();
    }

    interface ISystem
    {
    }

    interface ITearDownSystem : Entitas.ISystem
    {
        void TearDown();
    }

    class JobSystem<TEntity> : Entitas.IExecuteSystem, Entitas.ISystem
    {
        /*0x0*/ Entitas.IGroup<TEntity> _group;
        /*0x0*/ int _threads;
        /*0x0*/ Entitas.Job<TEntity> _jobs;
        /*0x0*/ int _threadsRunning;

        JobSystem(Entitas.IGroup<TEntity> group, int threads);
        JobSystem(Entitas.IGroup<TEntity> group);
        void Execute();
        void queueOnThread(object state);
        void Execute(TEntity entity);
    }

    class Job<TEntity>
    {
        /*0x0*/ TEntity[] entities;
        /*0x0*/ int from;
        /*0x0*/ int to;
        /*0x0*/ System.Exception exception;

        Job();
        void Set(TEntity[] entities, int from, int to);
    }

    class MultiReactiveSystem<TEntity, TContexts> : Entitas.IReactiveSystem, Entitas.IExecuteSystem, Entitas.ISystem
    {
        /*0x0*/ Entitas.ICollector[] _collectors;
        /*0x0*/ System.Collections.Generic.HashSet<TEntity> _collectedEntities;
        /*0x0*/ System.Collections.Generic.List<TEntity> _buffer;
        /*0x0*/ string _toStringCache;

        MultiReactiveSystem(TContexts contexts);
        MultiReactiveSystem(Entitas.ICollector[] collectors);
        Entitas.ICollector[] GetTrigger(TContexts contexts);
        bool Filter(TEntity entity);
        void Execute(System.Collections.Generic.List<TEntity> entities);
        void Activate();
        void Deactivate();
        void Clear();
        void Execute();
        string ToString();
        void Finalize();
    }

    class ReactiveSystem<TEntity> : Entitas.IReactiveSystem, Entitas.IExecuteSystem, Entitas.ISystem
    {
        /*0x0*/ Entitas.ICollector<TEntity> _collector;
        /*0x0*/ System.Collections.Generic.List<TEntity> _buffer;
        /*0x0*/ string _toStringCache;

        ReactiveSystem(Entitas.IContext<TEntity> context);
        ReactiveSystem(Entitas.ICollector<TEntity> collector);
        Entitas.ICollector<TEntity> GetTrigger(Entitas.IContext<TEntity> context);
        bool Filter(TEntity entity);
        void Execute(System.Collections.Generic.List<TEntity> entities);
        void Activate();
        void Deactivate();
        void Clear();
        void Execute();
        string ToString();
        void Finalize();
    }

    class Systems : Entitas.IInitializeSystem, Entitas.ISystem, Entitas.IExecuteSystem, Entitas.ICleanupSystem, Entitas.ITearDownSystem
    {
        /*0x10*/ System.Collections.Generic.List<Entitas.IInitializeSystem> _initializeSystems;
        /*0x18*/ System.Collections.Generic.List<Entitas.IExecuteSystem> _executeSystems;
        /*0x20*/ System.Collections.Generic.List<Entitas.ICleanupSystem> _cleanupSystems;
        /*0x28*/ System.Collections.Generic.List<Entitas.ITearDownSystem> _tearDownSystems;

        /*0x24dff04*/ Systems();
        /*0x24e0050*/ Entitas.Systems Add(Entitas.ISystem system);
        /*0x24e02e0*/ void Initialize();
        /*0x24e03dc*/ void Execute();
        /*0x24e04d8*/ void Cleanup();
        /*0x24e05d4*/ void TearDown();
        /*0x24e06d0*/ void ActivateReactiveSystems();
        /*0x24e082c*/ void DeactivateReactiveSystems();
        /*0x24e098c*/ void ClearReactiveSystems();
    }

    namespace VisualDebugging
    {
        namespace Unity
        {
            class ContextObserver
            {
                /*0x10*/ Entitas.IContext _context;
                /*0x18*/ System.Collections.Generic.List<Entitas.IGroup> _groups;
                /*0x20*/ UnityEngine.GameObject _gameObject;
                /*0x28*/ System.Collections.Generic.Stack<Entitas.VisualDebugging.Unity.EntityBehaviour> _entityBehaviourPool;
                /*0x30*/ System.Text.StringBuilder _toStringBuilder;

                /*0x24e0b4c*/ ContextObserver(Entitas.IContext context);
                /*0x24e0aec*/ Entitas.IContext get_context();
                /*0x24e0af4*/ Entitas.IGroup[] get_groups();
                /*0x24e0b44*/ UnityEngine.GameObject get_gameObject();
                /*0x24e0e18*/ void Deactivate();
                /*0x24e0fb8*/ void onEntityCreated(Entitas.IContext context, Entitas.IEntity entity);
                /*0x24e1224*/ void onGroupCreated(Entitas.IContext context, Entitas.IGroup group);
                /*0x24e12cc*/ string ToString();
            }

            class ContextObserverBehaviour : UnityEngine.MonoBehaviour
            {
                /*0x18*/ Entitas.VisualDebugging.Unity.ContextObserver _contextObserver;

                /*0x24e17f0*/ ContextObserverBehaviour();
                /*0x24e1698*/ Entitas.VisualDebugging.Unity.ContextObserver get_contextObserver();
                /*0x24e0e10*/ void Init(Entitas.VisualDebugging.Unity.ContextObserver contextObserver);
                /*0x24e16a0*/ void Update();
                /*0x24e17d8*/ void OnDestroy();
            }

            class ContextObserverExtension
            {
                static /*0x24e17f8*/ Entitas.VisualDebugging.Unity.ContextObserverBehaviour FindContextObserver(Entitas.IContext context);
            }

            enum AvgResetInterval
            {
                Always = 1,
                VeryFast = 30,
                Fast = 60,
                Normal = 120,
                Slow = 300,
                Never = 2147483647,
            }

            class DebugSystems : Entitas.Systems
            {
                static /*0x0*/ Entitas.VisualDebugging.Unity.AvgResetInterval avgResetInterval;
                /*0x30*/ bool paused;
                /*0x38*/ string _name;
                /*0x40*/ System.Collections.Generic.List<Entitas.ISystem> _systems;
                /*0x48*/ UnityEngine.GameObject _gameObject;
                /*0x50*/ Entitas.VisualDebugging.Unity.SystemInfo _systemInfo;
                /*0x58*/ System.Collections.Generic.List<Entitas.VisualDebugging.Unity.SystemInfo> _initializeSystemInfos;
                /*0x60*/ System.Collections.Generic.List<Entitas.VisualDebugging.Unity.SystemInfo> _executeSystemInfos;
                /*0x68*/ System.Collections.Generic.List<Entitas.VisualDebugging.Unity.SystemInfo> _cleanupSystemInfos;
                /*0x70*/ System.Collections.Generic.List<Entitas.VisualDebugging.Unity.SystemInfo> _tearDownSystemInfos;
                /*0x78*/ System.Diagnostics.Stopwatch _stopwatch;
                /*0x80*/ double _executeDuration;
                /*0x88*/ double _cleanupDuration;

                static /*0x24e3414*/ DebugSystems();
                /*0x24e2304*/ DebugSystems(string name);
                /*0x24e2504*/ DebugSystems(bool noInit);
                /*0x24e18ac*/ int get_totalInitializeSystemsCount();
                /*0x24e1a3c*/ int get_totalExecuteSystemsCount();
                /*0x24e1bcc*/ int get_totalCleanupSystemsCount();
                /*0x24e1d5c*/ int get_totalTearDownSystemsCount();
                /*0x24e1eec*/ int get_totalSystemsCount();
                /*0x24e207c*/ int get_initializeSystemsCount();
                /*0x24e20c4*/ int get_executeSystemsCount();
                /*0x24e210c*/ int get_cleanupSystemsCount();
                /*0x24e2154*/ int get_tearDownSystemsCount();
                /*0x24e219c*/ string get_name();
                /*0x24e21a4*/ UnityEngine.GameObject get_gameObject();
                /*0x24e21ac*/ Entitas.VisualDebugging.Unity.SystemInfo get_systemInfo();
                /*0x24e21b4*/ double get_executeDuration();
                /*0x24e21bc*/ double get_cleanupDuration();
                /*0x24e21c4*/ Entitas.VisualDebugging.Unity.SystemInfo[] get_initializeSystemInfos();
                /*0x24e2214*/ Entitas.VisualDebugging.Unity.SystemInfo[] get_executeSystemInfos();
                /*0x24e2264*/ Entitas.VisualDebugging.Unity.SystemInfo[] get_cleanupSystemInfos();
                /*0x24e22b4*/ Entitas.VisualDebugging.Unity.SystemInfo[] get_tearDownSystemInfos();
                /*0x24e232c*/ void initialize(string name);
                /*0x24e25d4*/ Entitas.Systems Add(Entitas.ISystem system);
                /*0x24e2944*/ void ResetDurations();
                /*0x24e2bf0*/ void Initialize();
                /*0x24e2d94*/ void Execute();
                /*0x24e2fe8*/ void Cleanup();
                /*0x24e2da4*/ void StepExecute();
                /*0x24e2ff8*/ void StepCleanup();
                /*0x24e3270*/ void TearDown();
            }

            class DebugSystemsBehaviour : UnityEngine.MonoBehaviour
            {
                /*0x18*/ Entitas.VisualDebugging.Unity.DebugSystems _systems;

                /*0x24e3470*/ DebugSystemsBehaviour();
                /*0x24e3460*/ Entitas.VisualDebugging.Unity.DebugSystems get_systems();
                /*0x24e3468*/ void Init(Entitas.VisualDebugging.Unity.DebugSystems systems);
            }

            enum SystemInterfaceFlags
            {
                None = 0,
                IInitializeSystem = 2,
                IExecuteSystem = 4,
                ICleanupSystem = 8,
                ITearDownSystem = 16,
                IReactiveSystem = 32,
            }

            class SystemInfo
            {
                /*0x10*/ double <initializationDuration>k__BackingField;
                /*0x18*/ double <cleanupDuration>k__BackingField;
                /*0x20*/ double <teardownDuration>k__BackingField;
                /*0x28*/ Entitas.VisualDebugging.Unity.SystemInfo parentSystemInfo;
                /*0x30*/ bool isActive;
                /*0x38*/ Entitas.ISystem _system;
                /*0x40*/ Entitas.VisualDebugging.Unity.SystemInterfaceFlags _interfaceFlags;
                /*0x48*/ string _systemName;
                /*0x50*/ double _accumulatedExecutionDuration;
                /*0x58*/ double _minExecutionDuration;
                /*0x60*/ double _maxExecutionDuration;
                /*0x68*/ int _executionDurationsCount;
                /*0x70*/ double _accumulatedCleanupDuration;
                /*0x78*/ double _minCleanupDuration;
                /*0x80*/ double _maxCleanupDuration;
                /*0x88*/ int _cleanupDurationsCount;

                static /*0x24e3548*/ Entitas.VisualDebugging.Unity.SystemInterfaceFlags getInterfaceFlags(Entitas.ISystem system);
                /*0x24e2508*/ SystemInfo(Entitas.ISystem system);
                /*0x24e3478*/ Entitas.ISystem get_system();
                /*0x24e3480*/ string get_systemName();
                /*0x24e2908*/ bool get_isInitializeSystems();
                /*0x24e2914*/ bool get_isExecuteSystems();
                /*0x24e292c*/ bool get_isCleanupSystems();
                /*0x24e2938*/ bool get_isTearDownSystems();
                /*0x24e2920*/ bool get_isReactiveSystems();
                /*0x24e3488*/ double get_initializationDuration();
                /*0x24e3490*/ void set_initializationDuration(double value);
                /*0x24e3498*/ double get_accumulatedExecutionDuration();
                /*0x24e34a0*/ double get_minExecutionDuration();
                /*0x24e34a8*/ double get_maxExecutionDuration();
                /*0x24e34b0*/ double get_averageExecutionDuration();
                /*0x24e34d0*/ double get_accumulatedCleanupDuration();
                /*0x24e34d8*/ double get_minCleanupDuration();
                /*0x24e34e0*/ double get_maxCleanupDuration();
                /*0x24e34e8*/ double get_averageCleanupDuration();
                /*0x24e3508*/ double get_cleanupDuration();
                /*0x24e3510*/ void set_cleanupDuration(double value);
                /*0x24e3518*/ double get_teardownDuration();
                /*0x24e3520*/ void set_teardownDuration(double value);
                /*0x24e3528*/ bool get_areAllParentsActive();
                /*0x24e31e8*/ void AddExecutionDuration(double executionDuration);
                /*0x24e322c*/ void AddCleanupDuration(double cleanupDuration);
                /*0x24e2bdc*/ void ResetDurations();
            }

            class DontDrawComponentAttribute : System.Attribute
            {
                /*0x24e3658*/ DontDrawComponentAttribute();
            }

            class EntityBehaviour : UnityEngine.MonoBehaviour
            {
                /*0x18*/ Entitas.IContext _context;
                /*0x20*/ Entitas.IEntity _entity;
                /*0x28*/ System.Collections.Generic.Stack<Entitas.VisualDebugging.Unity.EntityBehaviour> _entityBehaviourPool;
                /*0x30*/ string _cachedName;

                /*0x24e3968*/ EntityBehaviour();
                /*0x24e3660*/ Entitas.IContext get_context();
                /*0x24e3668*/ Entitas.IEntity get_entity();
                /*0x24e10d8*/ void Init(Entitas.IContext context, Entitas.IEntity entity, System.Collections.Generic.Stack<Entitas.VisualDebugging.Unity.EntityBehaviour> entityBehaviourPool);
                /*0x24e36e8*/ void onEntityReleased(Entitas.IEntity e);
                /*0x24e3670*/ void Update();
                /*0x24e3864*/ void OnDestroy();
            }

            class GameObjectDestroyExtension
            {
                static /*0x24e1760*/ void DestroyGameObject(UnityEngine.GameObject gameObject);
            }
        }
    }

    namespace Unity
    {
        class EntityLink : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Entitas.IEntity _entity;
            /*0x20*/ bool _applicationIsQuitting;

            /*0x24e3d14*/ EntityLink();
            /*0x24e3970*/ Entitas.IEntity get_entity();
            /*0x24e3978*/ void Link(Entitas.IEntity entity);
            /*0x24e3ac4*/ void Unlink();
            /*0x24e3bbc*/ void OnDestroy();
            /*0x24e3c84*/ void OnApplicationQuit();
            /*0x24e3c90*/ string ToString();
        }

        class EntityLinkExtension
        {
            static /*0x24e3d1c*/ Entitas.Unity.EntityLink GetEntityLink(UnityEngine.GameObject gameObject);
            static /*0x24e3d6c*/ Entitas.Unity.EntityLink Link(UnityEngine.GameObject gameObject, Entitas.IEntity entity);
            static /*0x24e3e2c*/ void Unlink(UnityEngine.GameObject gameObject);
        }
    }

    namespace CodeGeneration
    {
        namespace Attributes
        {
            class CleanupAttribute : System.Attribute
            {
                /*0x10*/ Entitas.CodeGeneration.Attributes.CleanupMode cleanupMode;

                /*0x24e3e44*/ CleanupAttribute(Entitas.CodeGeneration.Attributes.CleanupMode cleanupMode);
            }

            enum CleanupMode
            {
                RemoveComponent = 0,
                DestroyEntity = 1,
            }

            class ComponentNameAttribute : System.Attribute
            {
                /*0x10*/ string[] componentNames;

                /*0x24e3e6c*/ ComponentNameAttribute(string[] componentNames);
            }

            class CustomComponentNameAttribute : System.Attribute
            {
                /*0x10*/ string[] componentNames;

                /*0x24e3e94*/ CustomComponentNameAttribute(string[] componentNames);
            }

            class ContextAttribute : System.Attribute
            {
                /*0x10*/ string contextName;

                /*0x24e3ebc*/ ContextAttribute(string contextName);
            }

            class CustomEntityIndexAttribute : System.Attribute
            {
                /*0x10*/ System.Type contextType;

                /*0x24e3ee4*/ CustomEntityIndexAttribute(System.Type contextType);
            }

            class DontGenerateAttribute : System.Attribute
            {
                /*0x10*/ bool generateIndex;

                /*0x24e3f0c*/ DontGenerateAttribute(bool generateIndex);
            }

            class AbstractEntityIndexAttribute : System.Attribute
            {
                /*0x10*/ Entitas.CodeGeneration.Attributes.EntityIndexType entityIndexType;

                /*0x24e3f34*/ AbstractEntityIndexAttribute(Entitas.CodeGeneration.Attributes.EntityIndexType entityIndexType);
            }

            class EntityIndexAttribute : Entitas.CodeGeneration.Attributes.AbstractEntityIndexAttribute
            {
                /*0x24e3f5c*/ EntityIndexAttribute();
            }

            class EntityIndexGetMethodAttribute : System.Attribute
            {
                /*0x24e3f78*/ EntityIndexGetMethodAttribute();
            }

            enum EntityIndexType
            {
                EntityIndex = 0,
                PrimaryEntityIndex = 1,
            }

            class PrimaryEntityIndexAttribute : Entitas.CodeGeneration.Attributes.AbstractEntityIndexAttribute
            {
                /*0x24e3f80*/ PrimaryEntityIndexAttribute();
            }

            class EventAttribute : System.Attribute
            {
                /*0x10*/ Entitas.CodeGeneration.Attributes.EventTarget eventTarget;
                /*0x14*/ Entitas.CodeGeneration.Attributes.EventType eventType;
                /*0x18*/ int priority;

                /*0x24e3fa0*/ EventAttribute(Entitas.CodeGeneration.Attributes.EventTarget eventTarget, Entitas.CodeGeneration.Attributes.EventType eventType, int priority);
            }

            enum EventTarget
            {
                Any = 0,
                Self = 1,
            }

            enum EventType
            {
                Added = 0,
                Removed = 1,
            }

            class FlagPrefixAttribute : System.Attribute
            {
                /*0x10*/ string prefix;

                /*0x24e3fdc*/ FlagPrefixAttribute(string prefix);
            }

            class PostConstructorAttribute : System.Attribute
            {
                /*0x24e4004*/ PostConstructorAttribute();
            }

            class UniqueAttribute : System.Attribute
            {
                /*0x24e400c*/ UniqueAttribute();
            }
        }
    }
}

namespace DesperateDevs
{
    namespace CodeGeneration
    {
        namespace CodeGenerator
        {
            namespace Unity
            {
                namespace Editor
                {
                    class Compile
                    {
                        /*0x24e4014*/ Compile();
                    }
                }
            }
        }
    }
}

namespace DamageNumbersPro
{
    class DamageNumberGUI : DamageNumbersPro.DamageNumber
    {
        /*0x550*/ UnityEngine.RectTransform myRect;
        /*0x558*/ TMPro.TextMeshProUGUI textMeshProA;
        /*0x560*/ TMPro.TextMeshProUGUI textMeshProB;
        /*0x568*/ UnityEngine.RectTransform textRectA;
        /*0x570*/ UnityEngine.RectTransform textRectB;
        /*0x578*/ System.Collections.Generic.List<TMPro.TMP_SubMeshUI> subMeshs;
        /*0x580*/ float realStartTime;
        /*0x584*/ bool skipFrames;
        /*0x588*/ int skippedFrames;

        /*0x24e5114*/ DamageNumberGUI();
        /*0x24e401c*/ void OnPreSpawn();
        /*0x24e40bc*/ void OnStart();
        /*0x24e41dc*/ void OnLateUpdate();
        /*0x24e42c4*/ void OnStop();
        /*0x24e42c8*/ void OnUpdate(float deltaTime);
        /*0x24e42d8*/ void OnAbsorb(float number, float newSum);
        /*0x24e42dc*/ void OnTextUpdate();
        /*0x24e42e0*/ void GetReferencesIfNecessary();
        /*0x24e4360*/ void GetReferences();
        /*0x24e449c*/ TMPro.TMP_Text[] GetTextMeshs();
        /*0x24e455c*/ TMPro.TMP_Text GetTextMesh();
        /*0x24e4564*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x24e4588*/ UnityEngine.Material[] GetMaterials();
        /*0x24e45ac*/ UnityEngine.Material GetSharedMaterial();
        /*0x24e45d0*/ UnityEngine.Material GetMaterial();
        /*0x24e45ec*/ void SetTextString(string fullString);
        /*0x24e4b5c*/ UnityEngine.Vector3 GetPosition();
        /*0x24e4b78*/ void SetPosition(UnityEngine.Vector3 newPosition);
        /*0x24e4bcc*/ void SetAnchoredPosition(UnityEngine.Transform rectParent, UnityEngine.Vector2 anchoredPosition);
        /*0x24e4cd8*/ void SetAnchoredPosition(UnityEngine.Transform rectParent, UnityEngine.Transform rectPosition, UnityEngine.Vector2 relativeAnchoredPosition);
        /*0x24e4e1c*/ void SetLocalPositionA(UnityEngine.Vector3 localPosition);
        /*0x24e4e48*/ void SetLocalPositionB(UnityEngine.Vector3 localPosition);
        /*0x24e4e74*/ float GetPositionFactor();
        /*0x24e4e80*/ void OnFade(float currentFade);
        /*0x24e5080*/ void UpdateRotationZ();
        /*0x24e5104*/ void CheckAndEnable3D();
        /*0x24e510c*/ bool IsMesh();
    }

    class DamageNumberMesh : DamageNumbersPro.DamageNumber
    {
        /*0x24e57dc*/ DamageNumberMesh();
        /*0x24e57c4*/ void OnStart();
        /*0x24e57c8*/ void OnStop();
        /*0x24e57cc*/ void OnUpdate(float deltaTime);
        /*0x24e57d0*/ void OnFade(float currentFade);
        /*0x24e57d4*/ void OnTextUpdate();
        /*0x24e57d8*/ void OnAbsorb(float number, float newSum);
    }

    class DamageNumber : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<DamageNumbersPro.DamageNumber>> spamGroupDictionary;
        static /*0x8*/ UnityEngine.Transform poolParent;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.HashSet<DamageNumbersPro.DamageNumber>> pools;
        /*0x18*/ bool permanent;
        /*0x1c*/ float lifetime;
        /*0x20*/ bool unscaledTime;
        /*0x21*/ bool enable3DGame;
        /*0x22*/ bool faceCameraView;
        /*0x23*/ bool renderThroughWalls;
        /*0x24*/ bool consistentScreenSize;
        /*0x28*/ DamageNumbersPro.DistanceScalingSettings distanceScalingSettings;
        /*0x40*/ UnityEngine.Transform cameraOverride;
        /*0x48*/ bool enableNumber;
        /*0x4c*/ float number;
        /*0x50*/ DamageNumbersPro.TextSettings numberSettings;
        /*0x90*/ DamageNumbersPro.DigitSettings digitSettings;
        /*0xd0*/ bool enableLeftText;
        /*0xd8*/ string leftText;
        /*0xe0*/ DamageNumbersPro.TextSettings leftTextSettings;
        /*0x120*/ bool enableRightText;
        /*0x128*/ string rightText;
        /*0x130*/ DamageNumbersPro.TextSettings rightTextSettings;
        /*0x170*/ bool enableTopText;
        /*0x178*/ string topText;
        /*0x180*/ DamageNumbersPro.TextSettings topTextSettings;
        /*0x1c0*/ bool enableBottomText;
        /*0x1c8*/ string bottomText;
        /*0x1d0*/ DamageNumbersPro.TextSettings bottomTextSettings;
        /*0x210*/ bool enableColorByNumber;
        /*0x218*/ DamageNumbersPro.ColorByNumberSettings colorByNumberSettings;
        /*0x228*/ float durationFadeIn;
        /*0x22c*/ bool enableOffsetFadeIn;
        /*0x230*/ UnityEngine.Vector2 offsetFadeIn;
        /*0x238*/ bool enableScaleFadeIn;
        /*0x23c*/ UnityEngine.Vector2 scaleFadeIn;
        /*0x244*/ bool enableCrossScaleFadeIn;
        /*0x248*/ UnityEngine.Vector2 crossScaleFadeIn;
        /*0x250*/ bool enableShakeFadeIn;
        /*0x254*/ UnityEngine.Vector2 shakeOffsetFadeIn;
        /*0x25c*/ float shakeFrequencyFadeIn;
        /*0x260*/ float durationFadeOut;
        /*0x264*/ bool enableOffsetFadeOut;
        /*0x268*/ UnityEngine.Vector2 offsetFadeOut;
        /*0x270*/ bool enableScaleFadeOut;
        /*0x274*/ UnityEngine.Vector2 scaleFadeOut;
        /*0x27c*/ bool enableCrossScaleFadeOut;
        /*0x280*/ UnityEngine.Vector2 crossScaleFadeOut;
        /*0x288*/ bool enableShakeFadeOut;
        /*0x28c*/ UnityEngine.Vector2 shakeOffsetFadeOut;
        /*0x294*/ float shakeFrequencyFadeOut;
        /*0x298*/ bool enableLerp;
        /*0x29c*/ DamageNumbersPro.LerpSettings lerpSettings;
        /*0x2b4*/ bool enableVelocity;
        /*0x2b8*/ DamageNumbersPro.VelocitySettings velocitySettings;
        /*0x2d8*/ bool enableShaking;
        /*0x2dc*/ DamageNumbersPro.ShakeSettings shakeSettings;
        /*0x2e8*/ bool enableFollowing;
        /*0x2f0*/ UnityEngine.Transform followedTarget;
        /*0x2f8*/ DamageNumbersPro.FollowSettings followSettings;
        /*0x300*/ bool enableStartRotation;
        /*0x304*/ float minRotation;
        /*0x308*/ float maxRotation;
        /*0x30c*/ bool rotationRandomFlip;
        /*0x30d*/ bool enableRotateOverTime;
        /*0x310*/ float minRotationSpeed;
        /*0x314*/ float maxRotationSpeed;
        /*0x318*/ bool rotationSpeedRandomFlip;
        /*0x320*/ UnityEngine.AnimationCurve rotateOverTime;
        /*0x328*/ bool enableScaleByNumber;
        /*0x32c*/ DamageNumbersPro.ScaleByNumberSettings scaleByNumberSettings;
        /*0x33c*/ bool enableScaleOverTime;
        /*0x340*/ UnityEngine.AnimationCurve scaleOverTime;
        /*0x348*/ bool enableChangePosition;
        /*0x350*/ UnityEngine.AnimationCurve changePositionTime;
        /*0x358*/ string spamGroup;
        /*0x360*/ bool enableCombination;
        /*0x368*/ DamageNumbersPro.CombinationSettings combinationSettings;
        /*0x3a0*/ bool enableDestruction;
        /*0x3a8*/ DamageNumbersPro.DestructionSettings destructionSettings;
        /*0x3c8*/ bool enableCollision;
        /*0x3cc*/ DamageNumbersPro.CollisionSettings collisionSettings;
        /*0x3e0*/ bool enablePush;
        /*0x3e4*/ DamageNumbersPro.PushSettings pushSettings;
        /*0x3ec*/ float updateDelay;
        /*0x3f0*/ bool enablePooling;
        /*0x3f4*/ int poolSize;
        /*0x3f8*/ TMPro.TextMeshPro textMeshPro;
        /*0x400*/ UnityEngine.MeshRenderer textMeshRenderer;
        /*0x408*/ UnityEngine.MeshRenderer meshRendererA;
        /*0x410*/ UnityEngine.MeshRenderer meshRendererB;
        /*0x418*/ UnityEngine.MeshFilter meshFilterA;
        /*0x420*/ UnityEngine.MeshFilter meshFilterB;
        /*0x428*/ UnityEngine.Transform transformA;
        /*0x430*/ UnityEngine.Transform transformB;
        /*0x438*/ System.Collections.Generic.List<System.Tuple<UnityEngine.MeshRenderer, UnityEngine.MeshRenderer>> subMeshRenderers;
        /*0x440*/ System.Collections.Generic.List<System.Tuple<UnityEngine.MeshFilter, UnityEngine.MeshFilter>> subMeshFilters;
        /*0x448*/ System.Collections.Generic.List<UnityEngine.Mesh> meshs;
        /*0x450*/ System.Collections.Generic.List<UnityEngine.Color[]> colors;
        /*0x458*/ System.Collections.Generic.List<System.Single[]> alphas;
        /*0x460*/ float currentFade;
        /*0x464*/ float startTime;
        /*0x468*/ float startLifeTime;
        /*0x46c*/ float currentLifetime;
        /*0x470*/ float fadeInSpeed;
        /*0x474*/ float fadeOutSpeed;
        /*0x478*/ float baseAlpha;
        /*0x47c*/ UnityEngine.Vector2 currentScaleInOffset;
        /*0x484*/ UnityEngine.Vector2 currentScaleOutOffset;
        /*0x48c*/ UnityEngine.Vector3 position;
        /*0x498*/ UnityEngine.Vector3 finalPosition;
        /*0x4a4*/ UnityEngine.Vector3 remainingOffset;
        /*0x4b0*/ UnityEngine.Vector2 currentVelocity;
        /*0x4b8*/ UnityEngine.Vector3 originalScale;
        /*0x4c4*/ float numberScale;
        /*0x4c8*/ float combinationScale;
        /*0x4cc*/ float destructionScale;
        /*0x4d0*/ float renderThroughWallsScale;
        /*0x4d4*/ float lastScaleFactor;
        /*0x4d8*/ bool firstFrameScale;
        /*0x4dc*/ float currentRotationSpeed;
        /*0x4e0*/ float currentRotation;
        /*0x4e4*/ UnityEngine.Vector3 lastTargetPosition;
        /*0x4f0*/ UnityEngine.Vector3 targetOffset;
        /*0x4fc*/ float currentFollowSpeed;
        /*0x500*/ bool removedFromDictionary;
        /*0x508*/ DamageNumbersPro.DamageNumber myAbsorber;
        /*0x510*/ bool givenNumber;
        /*0x514*/ float absorbStartTime;
        /*0x518*/ UnityEngine.Vector3 absorbStartPosition;
        /*0x528*/ UnityEngine.Transform targetCamera;
        /*0x530*/ float simulatedScale;
        /*0x534*/ bool isDestroyed;
        /*0x538*/ float destructionStartTime;
        /*0x53c*/ bool collided;
        /*0x53d*/ bool pushed;
        /*0x540*/ DamageNumbersPro.DamageNumber originalPrefab;
        /*0x548*/ int poolingID;
        /*0x54c*/ bool performRestart;
        /*0x54d*/ bool destroyAfterSpawning;
        /*0x54e*/ bool isFadingOut;

        static /*0x24e8cc0*/ UnityEngine.GameObject NewMesh(string tmName, UnityEngine.Transform parent);
        /*0x24e5118*/ DamageNumber();
        /*0x24e57e0*/ void Start();
        /*0x24e592c*/ void Update();
        /*0x24e594c*/ void LateUpdate();
        /*0x24e607c*/ void UpdateDamageNumber(float delta, float time);
        /*0x24e6b9c*/ DamageNumbersPro.DamageNumber Spawn();
        /*0x24e718c*/ DamageNumbersPro.DamageNumber SpawnInPool();
        /*0x24e75e8*/ DamageNumbersPro.DamageNumber SpawnInPool(UnityEngine.Vector3 newPosition);
        /*0x24e76ac*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition);
        /*0x24e7704*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, float newNumber);
        /*0x24e7764*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, float newNumber, UnityEngine.Transform followedTransform);
        /*0x24e7840*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, UnityEngine.Transform followedTransform);
        /*0x24e78b0*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, string newLeftText);
        /*0x24e7920*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, string newLeftText, UnityEngine.Transform followedTransform);
        /*0x24e79a0*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, float newNumber, UnityEngine.Color newColor);
        /*0x24e7af0*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, string newLeftText, UnityEngine.Color newColor);
        /*0x24e7b98*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, float newNumber, UnityEngine.Transform followedTransform, UnityEngine.Color newColor);
        /*0x24e7c48*/ DamageNumbersPro.DamageNumber Spawn(UnityEngine.Vector3 newPosition, string newLeftText, UnityEngine.Transform followedTransform, UnityEngine.Color newColor);
        /*0x24e77dc*/ void SetFollowedTarget(UnityEngine.Transform followedTransform);
        /*0x24e7a38*/ void SetColor(UnityEngine.Color newColor);
        /*0x24e7d00*/ void SetGradientColor(TMPro.VertexGradient newGradient);
        /*0x24e7dc0*/ void SetRandomColor(UnityEngine.Color from, UnityEngine.Color to);
        /*0x24e7e60*/ void SetRandomColor(UnityEngine.Gradient gradient);
        /*0x24e7e9c*/ void SetGradientColor(UnityEngine.Color topLeft, UnityEngine.Color topRight, UnityEngine.Color bottomLeft, UnityEngine.Color bottomRight);
        /*0x24e7ed0*/ void SetFontMaterial(TMPro.TMP_FontAsset font);
        /*0x24e7f5c*/ TMPro.TMP_FontAsset GetFontMaterial();
        /*0x24e803c*/ void SetScale(float newScale);
        /*0x24e8074*/ void GetReferences();
        /*0x24e852c*/ void GetReferencesIfNecessary();
        /*0x24e85b4*/ void FadeOut();
        /*0x24e85c4*/ TMPro.TMP_Text[] GetTextMeshs();
        /*0x24e8658*/ TMPro.TMP_Text GetTextMesh();
        /*0x24e8660*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x24e867c*/ UnityEngine.Material[] GetMaterials();
        /*0x24e8698*/ UnityEngine.Material GetSharedMaterial();
        /*0x24e86b4*/ UnityEngine.Material GetMaterial();
        /*0x24e86d0*/ bool IsAlive(float time);
        /*0x24e86f8*/ void DestroyDNP();
        /*0x24e8bf4*/ void CheckAndEnable3D();
        /*0x24e8cb8*/ bool IsMesh();
        /*0x24e8eb0*/ void PrewarmPool();
        /*0x24e5800*/ void Restart();
        /*0x24e909c*/ void Initialize(float time);
        /*0x24e8a88*/ void PreparePooling();
        /*0x24e6e68*/ bool PoolAvailable(int id);
        /*0x24e6f38*/ void SetPoolingID(int id);
        /*0x24ea720*/ void UpdateText();
        /*0x24ebe80*/ void SetTextString(string fullString);
        /*0x24eafd8*/ string ProcessIntegers(string integers, ref bool shortened);
        /*0x24eb210*/ string ApplyTextSettings(string text, DamageNumbersPro.TextSettings settings);
        /*0x24e73a8*/ void ClearMeshs();
        /*0x24e6234*/ void HandleFadeIn(float delta);
        /*0x24e62b0*/ void HandleFadeOut(float delta);
        /*0x24ec79c*/ void UpdateFade(bool enablePositionOffset, UnityEngine.Vector2 positionOffset, bool enableScaleOffset, UnityEngine.Vector2 scaleOffset, bool enableScale, UnityEngine.Vector2 scale, bool enableShake, UnityEngine.Vector2 shakeOffset, float shakeFrequency, bool enableChangePos);
        /*0x24ebc8c*/ void UpdateAlpha(float progress);
        /*0x24e6518*/ void HandleFollowing(float deltaTime);
        /*0x24e6380*/ void HandleLerp(float deltaTime);
        /*0x24e63d0*/ void HandleVelocity(float deltaTime);
        /*0x24e67d4*/ UnityEngine.Vector3 ApplyShake(UnityEngine.Vector3 vector, DamageNumbersPro.ShakeSettings shakeSettings, float time);
        /*0x24ecb78*/ UnityEngine.Vector3 GetTargetPosition();
        /*0x24ecb9c*/ UnityEngine.Vector3 GetPosition();
        /*0x24ecbbc*/ void SetLocalPositionA(UnityEngine.Vector3 localPosition);
        /*0x24ecbd8*/ void SetLocalPositionB(UnityEngine.Vector3 localPosition);
        /*0x24ecbf4*/ void SetPosition(UnityEngine.Vector3 newPosition);
        /*0x24ecc3c*/ void SetToMousePosition(UnityEngine.RectTransform rectParent, UnityEngine.Camera canvasCamera);
        /*0x24ecd30*/ void SetAnchoredPosition(UnityEngine.Transform rectParent, UnityEngine.Vector2 anchoredPosition);
        /*0x24ece44*/ void SetAnchoredPosition(UnityEngine.Transform rectParent, UnityEngine.Transform rectPosition, UnityEngine.Vector2 relativeAnchoredPosition);
        /*0x24ecf78*/ float GetPositionFactor();
        /*0x24ea4f8*/ void AddToDictionary();
        /*0x24e8940*/ void RemoveFromDictionary();
        /*0x24e68f0*/ void HandleCombination(float delta, float time);
        /*0x24e9554*/ void TryCombination(float time);
        /*0x24ed080*/ void GetAbsorbed(DamageNumbersPro.DamageNumber otherNumber, float time);
        /*0x24ecf80*/ void GiveNumber(float time);
        /*0x24ed150*/ void OnAbsorb(float number, float newSum);
        /*0x24e6ae0*/ void HandleDestruction(float time);
        /*0x24e9eb4*/ void TryDestruction(float time);
        /*0x24ea190*/ void TryCollision();
        /*0x24ed154*/ void TryCollision(UnityEngine.Vector3 sourcePosition);
        /*0x24ea344*/ void TryPush();
        /*0x24ed638*/ void TryPush(UnityEngine.Vector3 sourcePosition);
        /*0x24ed9e0*/ void UpdateRotationZ();
        /*0x24e50c8*/ void SetRotationZ(UnityEngine.Transform transformTarget);
        /*0x24e6774*/ void HandleRotateOverTime(float delta, float time);
        /*0x24e597c*/ void UpdateScaleAnd3D();
        /*0x24eda28*/ void OnFade(float currentFade);
        /*0x24eda2c*/ void OnTextUpdate();
        /*0x24eda30*/ void OnUpdate(float deltaTime);
        /*0x24eda34*/ void OnStart();
        /*0x24eda38*/ void OnStop();
        /*0x24eda3c*/ void OnLateUpdate();
        /*0x24eda40*/ void OnPreSpawn();
        /*0x24eda44*/ void OnDestroy();
        /*0x24edb74*/ void Reset();
    }

    struct CollisionSettings
    {
        /*0x10*/ float radius;
        /*0x14*/ float pushFactor;
        /*0x18*/ UnityEngine.Vector3 desiredDirection;

        /*0x24ee64c*/ CollisionSettings(float customDefault);
    }

    struct ColorByNumberSettings
    {
        /*0x10*/ UnityEngine.Gradient colorGradient;
        /*0x18*/ float fromNumber;
        /*0x1c*/ float toNumber;

        /*0x24edf4c*/ ColorByNumberSettings(float customValue);
    }

    struct CombinationSettings
    {
        /*0x10*/ DamageNumbersPro.CombinationMethod method;
        /*0x14*/ float maxDistance;
        /*0x18*/ float spawnDelay;
        /*0x1c*/ float absorbDuration;
        /*0x20*/ UnityEngine.AnimationCurve scaleCurve;
        /*0x28*/ UnityEngine.AnimationCurve alphaCurve;
        /*0x30*/ bool moveToAbsorber;
        /*0x31*/ bool teleportToAbsorber;
        /*0x34*/ float absorberScaleFactor;
        /*0x38*/ float absorberScaleFade;
        /*0x3c*/ bool instantGain;
        /*0x40*/ float bonusLifetime;

        /*0x24ee14c*/ CombinationSettings(float customDefault);
    }

    enum CombinationMethod
    {
        ABSORB_NEW = 0,
        REPLACE_OLD = 1,
        IS_ALWAYS_ABSORBER = 2,
        IS_ALWAYS_VICTIM = 3,
    }

    struct DestructionSettings
    {
        /*0x10*/ float maxDistance;
        /*0x14*/ float spawnDelay;
        /*0x18*/ float duration;
        /*0x20*/ UnityEngine.AnimationCurve scaleCurve;
        /*0x28*/ UnityEngine.AnimationCurve alphaCurve;

        /*0x24ee42c*/ DestructionSettings(float customDefault);
    }

    struct DigitSettings
    {
        /*0x10*/ int decimals;
        /*0x18*/ string decimalChar;
        /*0x20*/ bool hideZeros;
        /*0x21*/ bool dotSeparation;
        /*0x24*/ int dotDistance;
        /*0x28*/ string dotChar;
        /*0x30*/ bool suffixShorten;
        /*0x38*/ System.Collections.Generic.List<string> suffixes;
        /*0x40*/ System.Collections.Generic.List<int> suffixDigits;
        /*0x48*/ int maxDigits;

        /*0x24edbc0*/ DigitSettings(float customDefault);
    }

    struct DistanceScalingSettings
    {
        /*0x10*/ float baseDistance;
        /*0x14*/ float closeDistance;
        /*0x18*/ float farDistance;
        /*0x1c*/ float closeScale;
        /*0x20*/ float farScale;

        /*0x24edba8*/ DistanceScalingSettings(float customDefault);
    }

    struct FollowSettings
    {
        /*0x10*/ float speed;
        /*0x14*/ float drag;

        /*0x24ee12c*/ FollowSettings(float customDefault);
    }

    struct LerpSettings
    {
        /*0x10*/ float speed;
        /*0x14*/ float minX;
        /*0x18*/ float maxX;
        /*0x1c*/ float minY;
        /*0x20*/ float maxY;
        /*0x24*/ bool randomFlip;

        /*0x24ee100*/ LerpSettings(int customDefault);
    }

    struct PushSettings
    {
        /*0x10*/ float radius;
        /*0x14*/ float pushOffset;

        /*0x24ee660*/ PushSettings(float customDefault);
    }

    struct ScaleByNumberSettings
    {
        /*0x10*/ float fromNumber;
        /*0x14*/ float toNumber;
        /*0x18*/ float fromScale;
        /*0x1c*/ float toScale;

        /*0x24ee13c*/ ScaleByNumberSettings(float customDefault);
    }

    struct ShakeSettings
    {
        /*0x10*/ UnityEngine.Vector2 offset;
        /*0x18*/ float frequency;

        /*0x24ee11c*/ ShakeSettings(UnityEngine.Vector2 customDefault);
    }

    struct TextSettings
    {
        /*0x10*/ bool bold;
        /*0x11*/ bool italic;
        /*0x12*/ bool underline;
        /*0x13*/ bool strike;
        /*0x14*/ float alpha;
        /*0x18*/ bool customColor;
        /*0x1c*/ UnityEngine.Color color;
        /*0x2c*/ bool mark;
        /*0x30*/ UnityEngine.Color markColor;
        /*0x40*/ float horizontal;
        /*0x44*/ float vertical;
        /*0x48*/ float characterSpacing;
        /*0x4c*/ float size;

        /*0x24ee670*/ TextSettings(float customDefault);
    }

    struct VelocitySettings
    {
        /*0x10*/ float minX;
        /*0x14*/ float maxX;
        /*0x18*/ float minY;
        /*0x1c*/ float maxY;
        /*0x20*/ bool randomFlip;
        /*0x24*/ float dragX;
        /*0x28*/ float dragY;
        /*0x2c*/ float gravity;

        /*0x24ee6a8*/ VelocitySettings(float customDefault);
    }

    namespace Internal
    {
        class DNPPreset : UnityEngine.ScriptableObject
        {
            /*0x18*/ bool changeFontAsset;
            /*0x20*/ TMPro.TMP_FontAsset fontAsset;
            /*0x28*/ bool changeColor;
            /*0x2c*/ UnityEngine.Color color;
            /*0x3c*/ bool enableGradient;
            /*0x40*/ TMPro.VertexGradient gradient;
            /*0x80*/ bool changeNumber;
            /*0x81*/ bool enableNumber;
            /*0x84*/ DamageNumbersPro.TextSettings numberSettings;
            /*0xc8*/ DamageNumbersPro.DigitSettings digitSettings;
            /*0x108*/ bool changeLeftText;
            /*0x109*/ bool enableLeftText;
            /*0x110*/ string leftText;
            /*0x118*/ DamageNumbersPro.TextSettings leftTextSettings;
            /*0x158*/ bool changeRightText;
            /*0x159*/ bool enableRightText;
            /*0x160*/ string rightText;
            /*0x168*/ DamageNumbersPro.TextSettings rightTextSettings;
            /*0x1a8*/ bool hideVerticalTexts;
            /*0x1a9*/ bool changeFadeIn;
            /*0x1ac*/ float durationFadeIn;
            /*0x1b0*/ bool enableOffsetFadeIn;
            /*0x1b4*/ UnityEngine.Vector2 offsetFadeIn;
            /*0x1bc*/ bool enableScaleFadeIn;
            /*0x1c0*/ UnityEngine.Vector2 scaleFadeIn;
            /*0x1c8*/ bool enableCrossScaleFadeIn;
            /*0x1cc*/ UnityEngine.Vector2 crossScaleFadeIn;
            /*0x1d4*/ bool enableShakeFadeIn;
            /*0x1d8*/ UnityEngine.Vector2 shakeOffsetFadeIn;
            /*0x1e0*/ float shakeFrequencyFadeIn;
            /*0x1e4*/ bool changeFadeOut;
            /*0x1e8*/ float durationFadeOut;
            /*0x1ec*/ bool enableOffsetFadeOut;
            /*0x1f0*/ UnityEngine.Vector2 offsetFadeOut;
            /*0x1f8*/ bool enableScaleFadeOut;
            /*0x1fc*/ UnityEngine.Vector2 scaleFadeOut;
            /*0x204*/ bool enableCrossScaleFadeOut;
            /*0x208*/ UnityEngine.Vector2 crossScaleFadeOut;
            /*0x210*/ bool enableShakeFadeOut;
            /*0x214*/ UnityEngine.Vector2 shakeOffsetFadeOut;
            /*0x21c*/ float shakeFrequencyFadeOut;
            /*0x220*/ bool changeMovement;
            /*0x221*/ bool enableLerp;
            /*0x224*/ DamageNumbersPro.LerpSettings lerpSettings;
            /*0x23c*/ bool enableVelocity;
            /*0x240*/ DamageNumbersPro.VelocitySettings velocitySettings;
            /*0x260*/ bool enableShaking;
            /*0x264*/ DamageNumbersPro.ShakeSettings shakeSettings;
            /*0x270*/ bool enableFollowing;
            /*0x274*/ DamageNumbersPro.FollowSettings followSettings;
            /*0x27c*/ bool changeRotation;
            /*0x27d*/ bool enableStartRotation;
            /*0x280*/ float minRotation;
            /*0x284*/ float maxRotation;
            /*0x288*/ bool enableRotateOverTime;
            /*0x28c*/ float minRotationSpeed;
            /*0x290*/ float maxRotationSpeed;
            /*0x298*/ UnityEngine.AnimationCurve rotateOverTime;
            /*0x2a0*/ bool changeScaling;
            /*0x2a1*/ bool enableScaleByNumber;
            /*0x2a4*/ DamageNumbersPro.ScaleByNumberSettings scaleByNumberSettings;
            /*0x2b4*/ bool enableScaleOverTime;
            /*0x2b8*/ UnityEngine.AnimationCurve scaleOverTime;
            /*0x2c0*/ bool changeSpamControl;
            /*0x2c8*/ string spamGroup;
            /*0x2d0*/ bool enableCombination;
            /*0x2d8*/ DamageNumbersPro.CombinationSettings combinationSettings;
            /*0x310*/ bool enableDestruction;
            /*0x318*/ DamageNumbersPro.DestructionSettings destructionSettings;
            /*0x338*/ bool enableCollision;
            /*0x33c*/ DamageNumbersPro.CollisionSettings collisionSettings;
            /*0x350*/ bool enablePush;
            /*0x354*/ DamageNumbersPro.PushSettings pushSettings;

            /*0x24ef9bc*/ DNPPreset();
            /*0x24ee6d0*/ bool IsApplied(DamageNumbersPro.DamageNumber dn);
            /*0x24ef1f0*/ void Apply(DamageNumbersPro.DamageNumber dn);
            /*0x24ef60c*/ void Get(DamageNumbersPro.DamageNumber dn);
        }

        class DNPUpdater : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<float, DamageNumbersPro.Internal.DNPUpdater> unscaledUpdaters;
            static /*0x8*/ System.Collections.Generic.Dictionary<float, DamageNumbersPro.Internal.DNPUpdater> scaledUpdaters;
            static /*0x10*/ UnityEngine.Vector3 upVector;
            static /*0x1c*/ UnityEngine.Vector3 rightVector;
            static /*0x28*/ bool vectorsNeedUpdate;
            static /*0x2c*/ UnityEngine.Quaternion cameraRotation;
            static /*0x3c*/ bool cameraNeedsUpdate;
            /*0x18*/ bool isUnscaled;
            /*0x1c*/ float updateDelay;
            /*0x20*/ System.Collections.Generic.HashSet<DamageNumbersPro.DamageNumber> activePopups;
            /*0x28*/ System.Collections.Generic.HashSet<DamageNumbersPro.DamageNumber> removedPopups;
            /*0x30*/ float lastUpdateTime;
            /*0x34*/ float delta;
            /*0x38*/ float time;

            static /*0x24f0100*/ void RegisterPopup(bool unscaledTime, float updateDelay, DamageNumbersPro.DamageNumber popup);
            static /*0x24f0404*/ void UnregisterPopup(bool unscaledTime, float updateDelay, DamageNumbersPro.DamageNumber popup);
            static /*0x24f0544*/ void UpdateVectors(UnityEngine.Transform popup);
            /*0x24f05d0*/ DNPUpdater();
            /*0x24f0004*/ void Start();
            /*0x24f008c*/ void Update();
            /*0x24f0024*/ System.Collections.IEnumerator UpdatePopups();

            class <UpdatePopups>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ DamageNumbersPro.Internal.DNPUpdater <>4__this;
                /*0x28*/ UnityEngine.WaitForSecondsRealtime <delay>5__2;

                /*0x24f00d8*/ <UpdatePopups>d__16(int <>1__state);
                /*0x24f05e4*/ void System.IDisposable.Dispose();
                /*0x24f05e8*/ bool MoveNext();
                /*0x24f0a08*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x24f0a10*/ void System.Collections.IEnumerator.Reset();
                /*0x24f0a50*/ object System.Collections.IEnumerator.get_Current();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 59B7E757844D3BF9299877BD1C17451611BFBAB493374D6B18D973FDE534151A;
    static /*0xc*/ <PrivateImplementationDetails> 5B979F69B96A61586A09DD4ED26F20534C629B08732AE32FA34B6F8A0049ACDD;
    static /*0x18*/ <PrivateImplementationDetails> 7FCA397EF25DB53B2C58A05F9BBFA4E8E0685FDBC8AAF39536123447056895C0;
    static /*0x24*/ <PrivateImplementationDetails> B257E85A5D3CAB5E738D5A0FD1A7AE96624BFE92CB7915726CBBE1518C3225CF;
    static /*0x30*/ <PrivateImplementationDetails> B7A918F6F138CA8137025633559198B529D28CCEC5A51B005376CC69A5B83D85;
    static /*0x3c*/ <PrivateImplementationDetails> C84227140A8A7787B30DFF8BD5693C19AA5A430C4E89FFD0256D7F77B3FEAD82;
    static /*0xac*/ <PrivateImplementationDetails> FC03ECB1D62767A5B31230F548FA4D4C02F01E3DA8CA1FC66C7C332EA16BF206;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=112
    {
    }
}
