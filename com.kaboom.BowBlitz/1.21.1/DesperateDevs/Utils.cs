class <Module>
{
}

namespace DesperateDevs
{
    namespace Utils
    {
        class ObjectCache
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, object> _objectPools;

            /*0xde8a00*/ ObjectCache();
            DesperateDevs.Utils.ObjectPool<T> GetObjectPool<T>();
            T Get<T>();
            void Push<T>(T obj);
            void RegisterCustomObjectPool<T>(DesperateDevs.Utils.ObjectPool<T> objectPool);
            /*0xde8a80*/ void Reset();

            class <>c__2<T>
            {
                static /*0x0*/ DesperateDevs.Utils.ObjectCache.<>c__2<T> <>9;
                static /*0x0*/ System.Func<T> <>9__2_0;

                static <>c__2();
                <>c__2();
                T <GetObjectPool>b__2_0();
            }
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Func<T> _factoryMethod;
            /*0x0*/ System.Action<T> _resetMethod;
            /*0x0*/ System.Collections.Generic.Stack<T> _objectPool;

            ObjectPool(System.Func<T> factoryMethod, System.Action<T> resetMethod);
            T Get();
            void Push(T obj);
        }

        class ConsoleColors
        {
            /*0x10*/ System.ConsoleColor <highlightedBackground>k__BackingField;
            /*0x14*/ System.ConsoleColor <highlightedForeground>k__BackingField;
            /*0x18*/ System.Collections.Generic.Dictionary<DesperateDevs.Logging.LogLevel, System.ConsoleColor> logLevelColors;

            /*0xde8af0*/ ConsoleColors();
            /*0xde8ad0*/ System.ConsoleColor get_highlightedBackground();
            /*0xde8ad8*/ void set_highlightedBackground(System.ConsoleColor value);
            /*0xde8ae0*/ System.ConsoleColor get_highlightedForeground();
            /*0xde8ae8*/ void set_highlightedForeground(System.ConsoleColor value);
        }

        class AppDomainExtension
        {
            static /*0xde8c04*/ System.Type[] GetAllTypes(System.AppDomain appDomain);
            static /*0xde8c20*/ System.Type[] GetAllTypes(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
            static System.Type[] GetNonAbstractTypes<T>(System.AppDomain appDomain);
            static System.Type[] GetNonAbstractTypes<T>(System.Type[] types);
            static T[] GetInstancesOf<T>(System.AppDomain appDomain);
            static T[] GetInstancesOf<T>(System.Type[] types);

            class <>c
            {
                static /*0x0*/ DesperateDevs.Utils.AppDomainExtension.<> <>9;
                static /*0x8*/ System.Func<System.Type, bool> <>9__1_0;

                static /*0xde919c*/ <>c();
                /*0xde9200*/ <>c();
                /*0xde9208*/ bool <GetAllTypes>b__1_0(System.Type type);
            }

            class <>c__3<T>
            {
                static /*0x0*/ DesperateDevs.Utils.AppDomainExtension.<>c__3<T> <>9;
                static /*0x0*/ System.Func<System.Type, bool> <>9__3_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__3_1;

                static <>c__3();
                <>c__3();
                bool <GetNonAbstractTypes>b__3_0(System.Type type);
                bool <GetNonAbstractTypes>b__3_1(System.Type type);
            }

            class <>c__5<T>
            {
                static /*0x0*/ DesperateDevs.Utils.AppDomainExtension.<>c__5<T> <>9;
                static /*0x0*/ System.Func<System.Type, T> <>9__5_0;

                static <>c__5();
                <>c__5();
                T <GetInstancesOf>b__5_0(System.Type type);
            }
        }

        class DictionaryExtension
        {
            static System.Collections.Generic.Dictionary<TKey, TValue> Merge<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary, System.Collections.Generic.Dictionary<TKey, TValue> dictionaries);

            class <>c__0<TKey, TValue>
            {
                static /*0x0*/ DesperateDevs.Utils.DictionaryExtension.<>c__0<TKey, TValue> <>9;
                static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TKey> <>9__0_1;
                static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TValue> <>9__0_2;
                static /*0x0*/ System.Func<System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.Dictionary<TKey, TValue>> <>9__0_0;

                static <>c__0();
                <>c__0();
                System.Collections.Generic.Dictionary<TKey, TValue> <Merge>b__0_0(System.Collections.Generic.Dictionary<TKey, TValue> current, System.Collections.Generic.Dictionary<TKey, TValue> dict);
                TKey <Merge>b__0_1(System.Collections.Generic.KeyValuePair<TKey, TValue> kv);
                TValue <Merge>b__0_2(System.Collections.Generic.KeyValuePair<TKey, TValue> kv);
            }
        }

        class InterfaceTypeExtension
        {
            static bool ImplementsInterface<T>(System.Type type);
        }

        class SerializationTypeExtension
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, string> _builtInTypesToString;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, string> _builtInTypeStrings;

            static /*0xde9be8*/ SerializationTypeExtension();
            static /*0xde9214*/ string ToCompilableString(System.Type type);
            static /*0xde9628*/ System.Type ToType(string typeString);
            static /*0xde9844*/ string ShortTypeName(string fullTypeName);
            static /*0xde98dc*/ string RemoveDots(string fullTypeName);
            static /*0xde9760*/ string generateTypeString(string typeString);
            static /*0xde9950*/ string generateGenericArguments(string typeString);
            static /*0xde9abc*/ string generateArray(string typeString);

            class <>c
            {
                static /*0x0*/ DesperateDevs.Utils.SerializationTypeExtension.<> <>9;
                static /*0x8*/ System.Func<System.Type, string> <>9__0_0;
                static /*0x10*/ System.Text.RegularExpressions.MatchEvaluator <>9__6_0;

                static /*0xdea29c*/ <>c();
                /*0xdea300*/ <>c();
                /*0xdea308*/ string <ToCompilableString>b__0_0(System.Type argType);
                /*0xdea35c*/ string <generateArray>b__6_0(System.Text.RegularExpressions.Match m);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ string[] separator;

                /*0xde9be0*/ <>c__DisplayClass5_0();
                /*0xdea454*/ string <generateGenericArguments>b__0(System.Text.RegularExpressions.Match m);
            }
        }

        class StringExtension
        {
            static /*0xdea69c*/ string UppercaseFirst(string str);
            static /*0xdea768*/ string LowercaseFirst(string str);
            static /*0xdea834*/ string ToUnixLineEndings(string str);
            static /*0xdea8c8*/ string ToUnixPath(string str);
            static /*0xdea934*/ string ToCSV(string[] values);
            static /*0xdeab2c*/ string[] ArrayFromCSV(string values);
            static /*0xdeac9c*/ string ToSpacedCamelCase(string text);
            static /*0xdeae14*/ string MakePathRelativeTo(string path, string currentDirectory);
            static /*0xdeaeec*/ string CreateUri(string path);

            class <>c
            {
                static /*0x0*/ DesperateDevs.Utils.StringExtension.<> <>9;
                static /*0x8*/ System.Func<string, bool> <>9__4_0;
                static /*0x10*/ System.Func<string, string> <>9__4_1;
                static /*0x18*/ System.Func<string, string> <>9__5_0;

                static /*0xdeaf98*/ <>c();
                /*0xdeaffc*/ <>c();
                /*0xdeb004*/ bool <ToCSV>b__4_0(string value);
                /*0xdeb024*/ string <ToCSV>b__4_1(string value);
                /*0xdeb03c*/ string <ArrayFromCSV>b__5_0(string value);
            }
        }

        class AssemblyResolver
        {
            /*0x10*/ DesperateDevs.Logging.Logger _logger;
            /*0x18*/ bool _reflectionOnly;
            /*0x20*/ string[] _basePaths;
            /*0x28*/ System.Collections.Generic.HashSet<System.Reflection.Assembly> _assemblies;
            /*0x30*/ System.AppDomain _appDomain;

            static /*0xdebb94*/ DesperateDevs.Utils.AssemblyResolver LoadAssemblies(bool allDirectories, string[] basePaths);
            static System.Reflection.Assembly[] GetAssembliesContainingType<T>(bool allDirectories, string[] basePaths);
            static DesperateDevs.Utils.AssemblyResolver LoadAssembliesContainingType<T>(bool allDirectories, string[] basePaths);
            static /*0xdebc58*/ string[] getAssemblyFiles(bool allDirectories, string[] basePaths);
            /*0xdeb09c*/ AssemblyResolver(bool reflectionOnly, string[] basePaths);
            /*0xdeb054*/ System.Reflection.Assembly[] get_assemblies();
            /*0xdeb294*/ void Load(string path);
            /*0xdeb618*/ void Close();
            /*0xdeb3d0*/ System.Reflection.Assembly resolveAndLoad(string name, System.Func<string, System.Reflection.Assembly> loadMethod, bool isDependency);
            /*0xdeba20*/ System.Reflection.Assembly onAssemblyResolve(object sender, System.ResolveEventArgs args);
            /*0xdebab4*/ System.Reflection.Assembly onReflectionOnlyAssemblyResolve(object sender, System.ResolveEventArgs args);
            /*0xdeb700*/ void addAssembly(System.Reflection.Assembly assembly);
            /*0xdeb758*/ string resolvePath(string name);
            /*0xdebb48*/ System.Type[] GetTypes();

            class <>c__DisplayClass17_0<T>
            {
                /*0x0*/ string interfaceName;

                <>c__DisplayClass17_0();
                bool <GetAssembliesContainingType>b__0(System.Type type);
            }

            class <>c__17<T>
            {
                static /*0x0*/ DesperateDevs.Utils.AssemblyResolver.<>c__17<T> <>9;
                static /*0x0*/ System.Func<System.Type, System.Reflection.Assembly> <>9__17_1;

                static <>c__17();
                <>c__17();
                System.Reflection.Assembly <GetAssembliesContainingType>b__17_1(System.Type type);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ bool allDirectories;

                /*0xdebef0*/ <>c__DisplayClass19_0();
            }

            class <>c__DisplayClass19_1
            {
                /*0x10*/ string pattern;
                /*0x18*/ DesperateDevs.Utils.AssemblyResolver.<> CS$<>8__locals1;

                /*0xdebef8*/ <>c__DisplayClass19_1();
                /*0xdebf00*/ System.Collections.Generic.IEnumerable<string> <getAssemblyFiles>b__0(string s);
            }
        }

        class AttributeInfo
        {
            /*0x10*/ object attribute;
            /*0x18*/ System.Collections.Generic.List<DesperateDevs.Utils.PublicMemberInfo> memberInfos;

            /*0xdebf2c*/ AttributeInfo(object attribute, System.Collections.Generic.List<DesperateDevs.Utils.PublicMemberInfo> memberInfos);
        }

        class PublicMemberInfo
        {
            /*0x10*/ System.Type type;
            /*0x18*/ string name;
            /*0x20*/ DesperateDevs.Utils.AttributeInfo[] attributes;
            /*0x28*/ System.Reflection.FieldInfo _fieldInfo;
            /*0x30*/ System.Reflection.PropertyInfo _propertyInfo;

            static /*0xdebfe8*/ DesperateDevs.Utils.AttributeInfo[] getAttributes(object[] attributes);
            /*0xdebf58*/ PublicMemberInfo(System.Reflection.FieldInfo info);
            /*0xdec114*/ PublicMemberInfo(System.Reflection.PropertyInfo info);
            /*0xdec1a4*/ PublicMemberInfo(System.Type type, string name, DesperateDevs.Utils.AttributeInfo[] attributes);
            /*0xdec1e0*/ object GetValue(object obj);
            /*0xdec228*/ void SetValue(object obj, object value);
        }

        class PublicMemberInfoExtension
        {
            static /*0xdec268*/ System.Collections.Generic.List<DesperateDevs.Utils.PublicMemberInfo> GetPublicMemberInfos(System.Type type);
            static /*0xdec508*/ object PublicMemberClone(object obj);
            static T PublicMemberClone<T>(object obj);
            static /*0xdec54c*/ void CopyPublicMemberValues(object source, object target);
        }
    }
}
