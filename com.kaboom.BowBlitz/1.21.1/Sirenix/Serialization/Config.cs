class <Module>
{
}

namespace Sirenix
{
    namespace Serialization
    {
        class CustomLogger : Sirenix.Serialization.ILogger
        {
            /*0x10*/ System.Action<string> logWarningDelegate;
            /*0x18*/ System.Action<string> logErrorDelegate;
            /*0x20*/ System.Action<System.Exception> logExceptionDelegate;

            /*0x228be1c*/ CustomLogger(System.Action<string> logWarningDelegate, System.Action<string> logErrorDelegate, System.Action<System.Exception> logExceptionDelegate);
            /*0x228bef8*/ void LogWarning(string warning);
            /*0x228bf1c*/ void LogError(string error);
            /*0x228bf40*/ void LogException(System.Exception exception);
        }

        enum DataFormat
        {
            Binary = 0,
            JSON = 1,
            Nodes = 2,
        }

        class DefaultLoggers
        {
            static /*0x0*/ object LOCK;
            static /*0x8*/ Sirenix.Serialization.ILogger unityLogger;

            static /*0x228c26c*/ DefaultLoggers();
            static /*0x228bf64*/ Sirenix.Serialization.ILogger get_DefaultLogger();
            static /*0x228bfb0*/ Sirenix.Serialization.ILogger get_UnityLogger();
        }

        enum ErrorHandlingPolicy
        {
            Resilient = 0,
            ThrowOnErrors = 1,
            ThrowOnWarningsAndErrors = 2,
        }

        class GlobalSerializationConfig : Sirenix.Utilities.GlobalConfig<Sirenix.Serialization.GlobalSerializationConfig>
        {
            static string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin's custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.

*Words of caution* 
However, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.

Warning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!";
            static string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.

Using prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.

Please keep all this in mind, if you wish to continue using Odin-serialized prefabs.";
            static string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I'm about, son. Hide message forever.";
            static string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I'm on my own. Hide message forever.";
            static /*0x0*/ Sirenix.Serialization.DataFormat[] BuildFormats;
            /*0x18*/ bool HideSerializationCautionaryMessage;
            /*0x19*/ bool HidePrefabCautionaryMessage;
            /*0x1a*/ bool HideOdinSerializeAttributeWarningMessages;
            /*0x1b*/ bool HideNonSerializedShowInInspectorWarningMessages;
            /*0x1c*/ Sirenix.Serialization.DataFormat buildSerializationFormat;
            /*0x20*/ Sirenix.Serialization.DataFormat editorSerializationFormat;
            /*0x24*/ Sirenix.Serialization.LoggingPolicy loggingPolicy;
            /*0x28*/ Sirenix.Serialization.ErrorHandlingPolicy errorHandlingPolicy;

            static /*0x228c818*/ GlobalSerializationConfig();
            /*0x228c7c8*/ GlobalSerializationConfig();
            /*0x228c2e4*/ Sirenix.Serialization.ILogger get_Logger();
            /*0x228c330*/ Sirenix.Serialization.DataFormat get_EditorSerializationFormat();
            /*0x228c338*/ void set_EditorSerializationFormat(Sirenix.Serialization.DataFormat value);
            /*0x228c340*/ Sirenix.Serialization.DataFormat get_BuildSerializationFormat();
            /*0x228c348*/ void set_BuildSerializationFormat(Sirenix.Serialization.DataFormat value);
            /*0x228c350*/ Sirenix.Serialization.LoggingPolicy get_LoggingPolicy();
            /*0x228c358*/ void set_LoggingPolicy(Sirenix.Serialization.LoggingPolicy value);
            /*0x228c360*/ Sirenix.Serialization.ErrorHandlingPolicy get_ErrorHandlingPolicy();
            /*0x228c368*/ void set_ErrorHandlingPolicy(Sirenix.Serialization.ErrorHandlingPolicy value);
            /*0x228c370*/ void OnInspectorGUI();
        }

        interface ILogger
        {
            void LogWarning(string warning);
            void LogError(string error);
            void LogException(System.Exception exception);
        }

        enum LoggingPolicy
        {
            LogErrors = 0,
            LogWarningsAndErrors = 1,
            Silent = 2,
        }
    }
}
