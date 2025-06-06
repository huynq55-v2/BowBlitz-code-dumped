class <Module>
{
}

namespace DesperateDevs
{
    namespace Logging
    {
        class fabl
        {
            static /*0x0*/ DesperateDevs.Logging.LogLevel _globalLogLevel;
            static /*0x8*/ DesperateDevs.Logging.LogDelegate _appenders;
            static /*0x10*/ System.Collections.Generic.Dictionary<string, DesperateDevs.Logging.Logger> _loggers;
            static /*0x18*/ DesperateDevs.Logging.Logger _logger;

            static /*0xde869c*/ fabl();
            static /*0xde771c*/ DesperateDevs.Logging.LogLevel get_globalLogLevel();
            static /*0xde7774*/ void set_globalLogLevel(DesperateDevs.Logging.LogLevel value);
            static /*0xde78f8*/ void Trace(string message);
            static /*0xde79c8*/ void Debug(string message);
            static /*0xde7a98*/ void Info(string message);
            static /*0xde7b68*/ void Warn(string message);
            static /*0xde7c38*/ void Error(string message);
            static /*0xde7d08*/ void Fatal(string message);
            static /*0xde7dd8*/ void Assert(bool condition, string message);
            static /*0xde7ea0*/ void AddAppender(DesperateDevs.Logging.LogDelegate appender);
            static /*0xde8134*/ void RemoveAppender(DesperateDevs.Logging.LogDelegate appender);
            static /*0xde83c8*/ DesperateDevs.Logging.Logger GetLogger(System.Type type);
            static /*0xde8440*/ DesperateDevs.Logging.Logger GetLogger(string name);
            static /*0xde85cc*/ void ResetLoggers();
            static /*0xde8644*/ void ResetAppenders();
        }

        class LogDelegate : System.MulticastDelegate
        {
            /*0xde8750*/ LogDelegate(object object, nint method);
            /*0xde8880*/ void Invoke(DesperateDevs.Logging.Logger logger, DesperateDevs.Logging.LogLevel logLevel, string message);
            /*0xde8894*/ System.IAsyncResult BeginInvoke(DesperateDevs.Logging.Logger logger, DesperateDevs.Logging.LogLevel logLevel, string message, System.AsyncCallback callback, object object);
            /*0xde892c*/ void EndInvoke(System.IAsyncResult result);
        }

        class Logger
        {
            /*0x10*/ DesperateDevs.Logging.LogDelegate OnLog;
            /*0x18*/ DesperateDevs.Logging.LogLevel <logLevel>k__BackingField;
            /*0x20*/ string <name>k__BackingField;

            /*0xde85a4*/ Logger(string name);
            /*0xde8098*/ void add_OnLog(DesperateDevs.Logging.LogDelegate value);
            /*0xde832c*/ void remove_OnLog(DesperateDevs.Logging.LogDelegate value);
            /*0xde8938*/ DesperateDevs.Logging.LogLevel get_logLevel();
            /*0xde8940*/ void set_logLevel(DesperateDevs.Logging.LogLevel value);
            /*0xde8948*/ string get_name();
            /*0xde8950*/ void set_name(string value);
            /*0xde7990*/ void Trace(string message);
            /*0xde7a60*/ void Debug(string message);
            /*0xde7b30*/ void Info(string message);
            /*0xde7c00*/ void Warn(string message);
            /*0xde7cd0*/ void Error(string message);
            /*0xde7da0*/ void Fatal(string message);
            /*0xde7e50*/ void Assert(bool condition, string message);
            /*0xde8958*/ void log(DesperateDevs.Logging.LogLevel logLvl, string message);
            /*0xde89f8*/ void Reset();
        }

        class FablAssertException : System.Exception
        {
            /*0xde8990*/ FablAssertException(string message);
        }

        enum LogLevel
        {
            On = 0,
            Trace = 1,
            Debug = 2,
            Info = 3,
            Warn = 4,
            Error = 5,
            Fatal = 6,
            Off = 7,
        }
    }
}
