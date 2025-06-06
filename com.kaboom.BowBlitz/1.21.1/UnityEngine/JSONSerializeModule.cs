class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x2905b40*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x2905b84*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x2905bd8*/ string ToJson(object obj);
        static /*0x2905be0*/ string ToJson(object obj, bool prettyPrint);
        static T FromJson<T>(string json);
        static /*0x2905d54*/ object FromJson(string json, System.Type type);
        static /*0x2905f28*/ void FromJsonOverwrite(string json, object objectToOverwrite);
    }
}
