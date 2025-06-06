class <Module>
{
}

interface IKaLogWriter
{
    void InitLogWriter();
    void WriteLog(string line, int level);
    bool IsLogLevelValid(int level);
}

class KaLog
{
    static /*0x0*/ int LOG_LEVEL_DEBUG;
    static /*0x4*/ int LOG_LEVEL_INFO;
    static /*0x8*/ int LOG_LEVEL_WARNING;
    static /*0xc*/ int LOG_LEVEL_ERROR;
    static /*0x10*/ int LOG_LEVEL_CRITICAL;
    static /*0x18*/ IKaLogWriter mLogWriter;
    static /*0x20*/ bool mIsEnabled;

    static /*0x1e955d0*/ KaLog();
    static /*0x1e94bc4*/ IKaLogWriter get_LogWriter();
    static /*0x1e94c1c*/ void set_LogWriter(IKaLogWriter value);
    static /*0x1e94d10*/ bool get_Enabled();
    static /*0x1e94d68*/ void set_Enabled(bool value);
    static /*0x1e94dc4*/ bool CheckLogLevel(int level);
    static /*0x1e94ee0*/ string ToStrBuff(object[] data);
    static /*0x1e94fb4*/ void LogLine(int level, string info);
    static /*0x1e950c4*/ void LogDebug(object[] data);
    static /*0x1e9514c*/ void LogDebug(string info);
    static /*0x1e951ac*/ void LogInfo(object[] data);
    static /*0x1e95234*/ void LogInfo(string info);
    static /*0x1e95294*/ void LogWarning(object[] data);
    static /*0x1e9531c*/ void LogWarning(string info);
    static /*0x1e9537c*/ void LogError(object[] data);
    static /*0x1e95404*/ void LogError(string info);
    static /*0x1e95464*/ void LogCritical(object[] data);
    static /*0x1e954ec*/ void LogCritical(string info);
    static /*0x1e9554c*/ void Exception(System.Exception exp);
    /*0x1e955c8*/ KaLog();
}

class UnityEngineLogWriter : IKaLogWriter
{
    /*0x1e95820*/ UnityEngineLogWriter();
    /*0x1e95634*/ void InitLogWriter();
    /*0x1e95638*/ void WriteLog(string line, int level);
    /*0x1e95748*/ bool IsLogLevelValid(int level);
    /*0x1e95750*/ bool IsLogError(int level);
    /*0x1e957b4*/ bool IsLogWarning(int level);
    /*0x1e95818*/ bool IsLogInfo(int level);
}

class KaLogWriters : IKaLogWriter
{
    /*0x10*/ System.Collections.Generic.List<IKaLogWriter> mWriters;

    /*0x1e95ce4*/ KaLogWriters();
    /*0x1e95828*/ void InitLogWriter();
    /*0x1e95924*/ void WriteLog(string line, int level);
    /*0x1e95abc*/ bool IsLogLevelValid(int level);
    /*0x1e95bdc*/ System.Collections.Generic.List<IKaLogWriter> GetLogWriters();
    /*0x1e95be4*/ void AddLogWriter(IKaLogWriter logWriter);
    /*0x1e95c8c*/ void RemoveLogWriter(IKaLogWriter logWriter);
}
