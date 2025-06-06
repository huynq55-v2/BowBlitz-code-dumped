class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x24f0a58*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x24f0a60*/ IsReadOnlyAttribute();
            }

            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x24f0a68*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace Unity
{
    namespace Burst
    {
        enum OptimizeFor
        {
            Default = 0,
            Performance = 1,
            Size = 2,
            FastCompilation = 3,
            Balanced = 4,
        }

        enum FloatMode
        {
            Default = 0,
            Strict = 1,
            Deterministic = 2,
            Fast = 3,
        }

        enum FloatPrecision
        {
            Standard = 0,
            High = 1,
            Medium = 2,
            Low = 3,
        }

        class BurstCompileAttribute : System.Attribute
        {
            /*0x10*/ Unity.Burst.FloatMode <FloatMode>k__BackingField;
            /*0x14*/ Unity.Burst.FloatPrecision <FloatPrecision>k__BackingField;
            /*0x18*/ System.Nullable<bool> _compileSynchronously;
            /*0x1a*/ System.Nullable<bool> _debug;
            /*0x1c*/ System.Nullable<bool> _disableSafetyChecks;
            /*0x1e*/ System.Nullable<bool> _disableDirectCall;
            /*0x20*/ Unity.Burst.OptimizeFor <OptimizeFor>k__BackingField;
            /*0x28*/ string[] <Options>k__BackingField;

            /*0x24f0e00*/ BurstCompileAttribute();
            /*0x24f0e08*/ BurstCompileAttribute(Unity.Burst.FloatPrecision floatPrecision, Unity.Burst.FloatMode floatMode);
            /*0x24f0e34*/ BurstCompileAttribute(string[] options);
            /*0x24f0a70*/ Unity.Burst.FloatMode get_FloatMode();
            /*0x24f0a78*/ void set_FloatMode(Unity.Burst.FloatMode value);
            /*0x24f0a80*/ Unity.Burst.FloatPrecision get_FloatPrecision();
            /*0x24f0a88*/ void set_FloatPrecision(Unity.Burst.FloatPrecision value);
            /*0x24f0a90*/ bool get_CompileSynchronously();
            /*0x24f0afc*/ void set_CompileSynchronously(bool value);
            /*0x24f0b64*/ bool get_Debug();
            /*0x24f0bd0*/ void set_Debug(bool value);
            /*0x24f0c38*/ bool get_DisableSafetyChecks();
            /*0x24f0ca4*/ void set_DisableSafetyChecks(bool value);
            /*0x24f0d0c*/ bool get_DisableDirectCall();
            /*0x24f0d78*/ void set_DisableDirectCall(bool value);
            /*0x24f0de0*/ Unity.Burst.OptimizeFor get_OptimizeFor();
            /*0x24f0de8*/ void set_OptimizeFor(Unity.Burst.OptimizeFor value);
            /*0x24f0df0*/ string[] get_Options();
            /*0x24f0df8*/ void set_Options(string[] value);
        }

        class BurstCompiler
        {
            static /*0x0*/ bool _IsEnabled;
            static /*0x8*/ Unity.Burst.BurstCompilerOptions Options;
            static /*0x10*/ System.Action OnCompileILPPMethod2;
            static /*0x18*/ System.Reflection.MethodInfo DummyMethodInfo;
            [ThreadStatic] static Unity.Burst.BurstCompiler.CommandBuilder _cmdBuilder;

            static /*0x24f25e4*/ BurstCompiler();
            static /*0x24f0e5c*/ bool IsLoadAdditionalLibrarySupported();
            static /*0x24f0f4c*/ Unity.Burst.BurstCompiler.CommandBuilder BeginCompilerCommand(string cmd);
            static /*0x24f10dc*/ bool get_IsEnabled();
            static /*0x24f1178*/ void SetExecutionMode(Unity.Burst.BurstExecutionEnvironment mode);
            static /*0x24f1180*/ Unity.Burst.BurstExecutionEnvironment GetExecutionMode();
            static T CompileDelegate<T>(T delegateMethod);
            static void VerifyDelegateIsNotMulticast<T>(T delegateMethod);
            static void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute<T>(T delegateMethod);
            static /*0x24f1188*/ nint CompileILPPMethod(System.RuntimeMethodHandle burstMethodHandle, System.RuntimeMethodHandle managedMethodHandle, System.RuntimeTypeHandle delegateTypeHandle);
            static /*0x24f11c8*/ nint CompileILPPMethod2(System.RuntimeMethodHandle burstMethodHandle);
            static /*0x24f17e4*/ void* GetILPPMethodFunctionPointer(nint ilppMethod);
            static /*0x24f1824*/ void* GetILPPMethodFunctionPointer2(nint ilppMethod, System.RuntimeMethodHandle managedMethodHandle, System.RuntimeTypeHandle delegateTypeHandle);
            static /*0x24f1960*/ void* CompileUnsafeStaticMethod(System.RuntimeMethodHandle handle);
            static Unity.Burst.FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod);
            static /*0x24f19a0*/ void* Compile(object delegateObj, bool isFunctionPointer);
            static /*0x24f1394*/ void* Compile(object delegateObj, System.Reflection.MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing);
            static /*0x24f1b80*/ void Shutdown();
            static /*0x24f1b84*/ void Cancel();
            static /*0x24f1b88*/ bool IsCurrentCompilationDone();
            static /*0x24f1b90*/ void Enable();
            static /*0x24f1b94*/ void Disable();
            static /*0x24f1b98*/ bool IsHostEditorArm();
            static /*0x24f1ba0*/ void TriggerUnsafeStaticMethodRecompilation();
            static /*0x24f20c0*/ void TriggerRecompilation();
            static /*0x24f20c4*/ void UnloadAdditionalLibraries();
            static /*0x24f21f8*/ void InitialiseDebuggerHooks();
            static /*0x24f0ec0*/ bool IsApiAvailable(string apiName);
            static /*0x24f22a4*/ int RequestSetProtocolVersion(int version);
            static /*0x24f240c*/ void NotifyCompilationStarted();
            static /*0x24f2410*/ void NotifyAssemblyCompilationNotRequired(string assemblyName);
            static /*0x24f2414*/ void NotifyAssemblyCompilationFinished(string assemblyName);
            static /*0x24f2418*/ void NotifyCompilationFinished();
            static /*0x24f241c*/ string AotCompilation(string[] assemblyFolders, string[] assemblyRoots, string options);
            static /*0x24f245c*/ void SetProfilerCallbacks();
            static /*0x24f2460*/ string SendRawCommandToCompiler(string command);
            static /*0x24f212c*/ string SendCommandToCompiler(string commandName, string commandArgs);
            static /*0x24f25e0*/ void DummyMethod();

            class CommandBuilder
            {
                /*0x10*/ System.Text.StringBuilder _builder;
                /*0x18*/ bool _hasArgs;

                /*0x24f1020*/ CommandBuilder();
                /*0x24f1090*/ Unity.Burst.BurstCompiler.CommandBuilder Begin(string cmd);
                /*0x24f2510*/ Unity.Burst.BurstCompiler.CommandBuilder With(string arg);
                /*0x24f2748*/ Unity.Burst.BurstCompiler.CommandBuilder With(nint arg);
                /*0x24f2810*/ Unity.Burst.BurstCompiler.CommandBuilder And(char sep);
                /*0x24f256c*/ string SendToCompiler();
            }

            class StaticTypeReinitAttribute : System.Attribute
            {
                /*0x10*/ System.Type reinitType;

                /*0x24f2838*/ StaticTypeReinitAttribute(System.Type toReinit);
            }

            class BurstCompilerHelper
            {
                static /*0x0*/ Unity.Burst.BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate IsBurstEnabledImpl;
                static /*0x8*/ bool IsBurstGenerated;

                static /*0x24f2920*/ BurstCompilerHelper();
                static /*0x24f2860*/ bool IsBurstEnabled();
                static /*0x24f28b0*/ void DiscardedMethod(ref bool value);
                static /*0x24f28b8*/ bool IsCompiledByBurst(System.Delegate del);

                class IsBurstEnabledDelegate : System.MulticastDelegate
                {
                    /*0x24f29d0*/ IsBurstEnabledDelegate(object object, nint method);
                    /*0x24f2a8c*/ bool Invoke();
                    /*0x24f2aa0*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0x24f2ac0*/ bool EndInvoke(System.IAsyncResult result);
                }
            }

            class FakeDelegate
            {
                /*0x10*/ System.Reflection.MethodInfo <Method>k__BackingField;

                /*0x24f136c*/ FakeDelegate(System.Reflection.MethodInfo method);
                /*0x24f2ae8*/ System.Reflection.MethodInfo get_Method();
            }

            class <>c
            {
                static /*0x0*/ Unity.Burst.BurstCompiler.<> <>9;
                static /*0x8*/ System.Func<System.Attribute, bool> <>9__22_0;
                static /*0x10*/ System.Func<System.Attribute, bool> <>9__29_0;

                static /*0x24f2af0*/ <>c();
                /*0x24f2b54*/ <>c();
                /*0x24f2b5c*/ bool <Compile>b__22_0(System.Attribute s);
                /*0x24f2bcc*/ bool <TriggerUnsafeStaticMethodRecompilation>b__29_0(System.Attribute x);
            }
        }

        enum GlobalSafetyChecksSettingKind
        {
            Off = 0,
            On = 1,
            ForceOn = 2,
        }

        class BurstCompilerOptions
        {
            static string DisableCompilationArg = "--burst-disable-compilation";
            static string ForceSynchronousCompilationArg = "--burst-force-sync-compilation";
            static string DefaultLibraryName = "lib_burst_generated";
            static string BurstInitializeName = "burst.initialize";
            static string BurstInitializeExternalsName = "burst.initialize.externals";
            static string BurstInitializeStaticsName = "burst.initialize.statics";
            static string OptionBurstcSwitch = "+burstc";
            static string OptionGroup = "group";
            static string OptionPlatform = "platform=";
            static string OptionBackend = "backend=";
            static string OptionGlobalSafetyChecksSetting = "global-safety-checks-setting=";
            static string OptionDisableSafetyChecks = "disable-safety-checks";
            static string OptionDisableOpt = "disable-opt";
            static string OptionFastMath = "fastmath";
            static string OptionTarget = "target=";
            static string OptionOptLevel = "opt-level=";
            static string OptionLogTimings = "log-timings";
            static string OptionOptForSize = "opt-for-size";
            static string OptionFloatPrecision = "float-precision=";
            static string OptionFloatMode = "float-mode=";
            static string OptionBranchProtection = "branch-protection=";
            static string OptionDisableWarnings = "disable-warnings=";
            static string OptionCompilationDefines = "compilation-defines=";
            static string OptionDump = "dump=";
            static string OptionFormat = "format=";
            static string OptionDebugTrap = "debugtrap";
            static string OptionDisableVectors = "disable-vectors";
            static string OptionDebug = "debug=";
            static string OptionDebugMode = "debugMode";
            static string OptionStaticLinkage = "generate-static-linkage-methods";
            static string OptionJobMarshalling = "generate-job-marshalling-methods";
            static string OptionTempDirectory = "temp-folder=";
            static string OptionEnableDirectExternalLinking = "enable-direct-external-linking";
            static string OptionLinkerOptions = "linker-options=";
            static string OptionEnableAutoLayoutFallbackCheck = "enable-autolayout-fallback-check";
            static string OptionGenerateLinkXml = "generate-link-xml=";
            static string OptionMetaDataGeneration = "meta-data-generation=";
            static string OptionCacheDirectory = "cache-directory=";
            static string OptionJitDisableFunctionCaching = "disable-function-caching";
            static string OptionJitDisableAssemblyCaching = "disable-assembly-caching";
            static string OptionJitEnableAssemblyCachingLogs = "enable-assembly-caching-logs";
            static string OptionJitEnableSynchronousCompilation = "enable-synchronous-compilation";
            static string OptionJitCompilationPriority = "compilation-priority=";
            static string OptionJitIsForFunctionPointer = "is-for-function-pointer";
            static string OptionJitManagedFunctionPointer = "managed-function-pointer=";
            static string OptionJitManagedDelegateHandle = "managed-delegate-handle=";
            static string OptionEnableInterpreter = "enable-interpreter";
            static string OptionAotAssemblyFolder = "assembly-folder=";
            static string OptionRootAssembly = "root-assembly=";
            static string OptionIncludeRootAssemblyReferences = "include-root-assembly-references=";
            static string OptionAotMethod = "method=";
            static string OptionAotType = "type=";
            static string OptionAotAssembly = "assembly=";
            static string OptionAotOutputPath = "output=";
            static string OptionAotKeepIntermediateFiles = "keep-intermediate-files";
            static string OptionAotNoLink = "nolink";
            static string OptionAotPatchedAssembliesOutputFolder = "patch-assemblies-into=";
            static string OptionAotPinvokeNameToPatch = "pinvoke-name=";
            static string OptionAotExecuteMethodNameToFind = "execute-method-name=";
            static string OptionAotOnlyStaticMethods = "only-static-methods";
            static string OptionMethodPrefix = "method-prefix=";
            static string OptionAotNoNativeToolchain = "no-native-toolchain";
            static string OptionAotEmitLlvmObjects = "emit-llvm-objects";
            static string OptionAotKeyFolder = "key-folder=";
            static string OptionAotDecodeFolder = "decode-folder=";
            static string OptionVerbose = "verbose";
            static string OptionValidateExternalToolChain = "validate-external-tool-chain";
            static string OptionCompilerThreads = "threads=";
            static string OptionChunkSize = "chunk-size=";
            static string OptionPrintLogOnMissingPInvokeCallbackAttribute = "print-monopinvokecallbackmissing-message";
            static string OptionOutputMode = "output-mode=";
            static string OptionAlwaysCreateOutput = "always-create-output=";
            static string OptionAotPdbSearchPaths = "pdb-search-paths=";
            static string OptionSafetyChecks = "safety-checks";
            static string CompilerCommandShutdown = "$shutdown";
            static string CompilerCommandCancel = "$cancel";
            static string CompilerCommandEnableCompiler = "$enable_compiler";
            static string CompilerCommandDisableCompiler = "$disable_compiler";
            static string CompilerCommandSetDefaultOptions = "$set_default_options";
            static string CompilerCommandTriggerSetupRecompilation = "$trigger_setup_recompilation";
            static string CompilerCommandIsCurrentCompilationDone = "$is_current_compilation_done";
            static string CompilerCommandTriggerRecompilation = "$trigger_recompilation";
            static string CompilerCommandDomainReload = "$domain_reload";
            static string CompilerCommandVersionNotification = "$version";
            static string CompilerCommandSetProfileCallbacks = "$set_profile_callbacks";
            static string CompilerCommandUnloadBurstNatives = "$unload_burst_natives";
            static string CompilerCommandIsNativeApiAvailable = "$is_native_api_available";
            static string CompilerCommandILPPCompilation = "$ilpp_compilation";
            static string CompilerCommandIsArmTestEnv = "$is_arm_test_env";
            static string CompilerCommandNotifyAssemblyCompilationNotRequired = "$notify_assembly_compilation_not_required";
            static string CompilerCommandNotifyAssemblyCompilationFinished = "$notify_assembly_compilation_finished";
            static string CompilerCommandNotifyCompilationStarted = "$notify_compilation_started";
            static string CompilerCommandNotifyCompilationFinished = "$notify_compilation_finished";
            static string CompilerCommandAotCompilation = "$aot_compilation";
            static string CompilerCommandRequestInitialiseDebuggerCommmand = "$request_debug_command";
            static string CompilerCommandInitialiseDebuggerCommmand = "$load_debugger_interface";
            static string CompilerCommandRequestSetProtocolVersionEditor = "$request_set_protocol_version_editor";
            static string CompilerCommandSetProtocolVersionBurst = "$set_protocol_version_burst";
            static /*0x0*/ bool ForceDisableBurstCompilation;
            static /*0x1*/ bool ForceBurstCompilationSynchronously;
            static /*0x2*/ bool IsSecondaryUnityProcess;
            /*0x10*/ bool _enableBurstCompilation;
            /*0x11*/ bool _enableBurstCompileSynchronously;
            /*0x12*/ bool _enableBurstSafetyChecks;
            /*0x13*/ bool _enableBurstTimings;
            /*0x14*/ bool _enableBurstDebug;
            /*0x15*/ bool _forceEnableBurstSafetyChecks;
            /*0x16*/ bool <IsGlobal>k__BackingField;
            /*0x18*/ System.Action <OptionsChanged>k__BackingField;

            static /*0x24f44e0*/ BurstCompilerOptions();
            static /*0x24f2c3c*/ string SerialiseStringArraySafe(string[] array);
            static /*0x24f2d64*/ string[] DeserialiseStringArraySafe(string input);
            static /*0x24f2edc*/ string SerialiseCompilationOptionsSafe(string[] roots, string[] folders, string options);
            static /*0x24f3014*/ System.ValueTuple<System.String[], System.String[], string> DeserialiseCompilationOptionsSafe(string from);
            static /*0x24f35b0*/ bool TryGetAttribute(System.Reflection.MemberInfo member, ref Unity.Burst.BurstCompileAttribute attribute);
            static /*0x24f3a88*/ bool TryGetAttribute(System.Reflection.Assembly assembly, ref Unity.Burst.BurstCompileAttribute attribute);
            static /*0x24f363c*/ Unity.Burst.BurstCompileAttribute GetBurstCompileAttribute(System.Reflection.MemberInfo memberInfo);
            static /*0x24f1abc*/ bool HasBurstCompileAttribute(System.Reflection.MemberInfo member);
            static /*0x24f3b04*/ void MergeAttributes(ref Unity.Burst.BurstCompileAttribute memberAttribute, ref Unity.Burst.BurstCompileAttribute assemblyAttribute);
            static /*0x24f4494*/ void AddOption(System.Text.StringBuilder builder, string option);
            static /*0x24f43ac*/ string GetOption(string optionName, object value);
            static /*0x24f45f0*/ bool CheckIsSecondaryUnityProcess();
            /*0x24f30ec*/ BurstCompilerOptions();
            /*0x24f26e0*/ BurstCompilerOptions(bool isGlobal);
            /*0x24f3224*/ bool get_IsGlobal();
            /*0x24f322c*/ bool get_IsEnabled();
            /*0x24f32a0*/ bool get_EnableBurstCompilation();
            /*0x24f30f4*/ void set_EnableBurstCompilation(bool value);
            /*0x24f32c8*/ bool get_EnableBurstCompileSynchronously();
            /*0x24f32d0*/ void set_EnableBurstCompileSynchronously(bool value);
            /*0x24f3304*/ bool get_EnableBurstSafetyChecks();
            /*0x24f31f4*/ void set_EnableBurstSafetyChecks(bool value);
            /*0x24f3310*/ bool get_ForceEnableBurstSafetyChecks();
            /*0x24f3318*/ void set_ForceEnableBurstSafetyChecks(bool value);
            /*0x24f3348*/ bool get_EnableBurstDebug();
            /*0x24f3350*/ void set_EnableBurstDebug(bool value);
            /*0x24f3380*/ bool get_DisableOptimizations();
            /*0x24f3388*/ void set_DisableOptimizations(bool value);
            /*0x24f338c*/ bool get_EnableFastMath();
            /*0x24f3394*/ void set_EnableFastMath(bool value);
            /*0x24f3398*/ bool get_EnableBurstTimings();
            /*0x24f33a0*/ void set_EnableBurstTimings(bool value);
            /*0x24f33d4*/ bool get_RequiresSynchronousCompilation();
            /*0x24f3448*/ System.Action get_OptionsChanged();
            /*0x24f3450*/ void set_OptionsChanged(System.Action value);
            /*0x24f3458*/ Unity.Burst.BurstCompilerOptions Clone();
            /*0x24f3c2c*/ bool TryGetOptions(System.Reflection.MemberInfo member, bool isJit, ref string flagsOut, bool isForILPostProcessing);
            /*0x24f3d50*/ string GetOptions(bool isJit, Unity.Burst.BurstCompileAttribute attr, bool isForILPostProcessing);
            /*0x24f32ac*/ void OnOptionsChanged();
            /*0x24f330c*/ void MaybeTriggerRecompilation();
            /*0x24f32a8*/ void MaybePreventChangingOption();
        }

        enum BurstTargetCpu
        {
            Auto = 0,
            X86_SSE2 = 1,
            X86_SSE4 = 2,
            X64_SSE2 = 3,
            X64_SSE4 = 4,
            AVX = 5,
            AVX2 = 6,
            WASM32 = 7,
            ARMV7A_NEON32 = 8,
            ARMV8A_AARCH64 = 9,
            THUMB2_NEON32 = 10,
            ARMV8A_AARCH64_HALFFP = 11,
            ARMV9A = 12,
        }

        enum NativeDumpFlags
        {
            None = 0,
            IL = 1,
            Unused = 2,
            IR = 4,
            IROptimized = 8,
            Asm = 16,
            Function = 32,
            Analysis = 64,
            IRPassAnalysis = 128,
            ILPre = 256,
            IRPerEntryPoint = 512,
            All = 1021,
        }

        enum CompilationPriority
        {
            EagerCompilationSynchronous = 0,
            Asynchronous = 1,
            ILPP = 2,
            EagerCompilationAsynchronous = 3,
        }

        enum BurstExecutionEnvironment
        {
            Default = 0,
            NonDeterministic = 0,
            Deterministic = 1,
        }

        class BurstRuntime
        {
            static int GetHashCode32<T>();
            static /*0x24f45f8*/ int GetHashCode32(System.Type type);
            static long GetHashCode64<T>();
            static /*0x24f46a0*/ long GetHashCode64(System.Type type);
            static /*0x24f461c*/ int HashStringWithFNV1A32(string text);
            static /*0x24f46c4*/ long HashStringWithFNV1A64(string text);
            static /*0x24f4750*/ bool LoadAdditionalLibrary(string pathToLibBurstGenerated);
            static /*0x24f47bc*/ bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated);
            static /*0x24f4918*/ void Initialize();
            static /*0x24f491c*/ void PreventDiscardAttributeStrip();
            static /*0x24f496c*/ void Log(byte* message, int logType, byte* fileName, int lineNumber);
            static /*0x24f4984*/ byte* GetUTF8LiteralPointer(string str, ref int byteCount);

            struct HashCode32<T>
            {
                static /*0x0*/ int Value;

                static HashCode32();
            }

            struct HashCode64<T>
            {
                static /*0x0*/ long Value;

                static HashCode64();
            }

            class PreserveAttribute : System.Attribute
            {
                /*0x24f49d4*/ PreserveAttribute();
            }
        }

        class BurstString
        {
            static int SinglePrecision = 9;
            static int DoublePrecision = 17;
            static int SingleNumberBufferLength = 10;
            static int DoubleNumberBufferLength = 18;
            static int SinglePrecisionCustomFormat = 7;
            static int DoublePrecisionCustomFormat = 15;
            static /*0x0*/ char[] SplitByColon;
            static /*0x8*/ byte[] logTable;
            static /*0x10*/ uint[] g_PowerOf10_U32;
            static /*0x18*/ byte[] InfinityString;
            static /*0x20*/ byte[] NanString;

            static /*0x24f89a0*/ BurstString();
            static /*0x24f49dc*/ void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength);
            static /*0x24f4a00*/ void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw);
            static /*0x24f4c44*/ void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw);
            static /*0x24f4f64*/ void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw);
            static /*0x24f527c*/ void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw);
            static /*0x24f544c*/ void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw);
            static /*0x24f5658*/ void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw);
            static /*0x24f5760*/ void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw);
            static /*0x24f57e4*/ void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw);
            static /*0x24f56dc*/ void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw);
            static /*0x24f5a08*/ void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw);
            static /*0x24f5c7c*/ void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw);
            static /*0x24f5d34*/ void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw);
            static /*0x24f5dec*/ void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw);
            static /*0x24f5868*/ void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, Unity.Burst.BurstString.FormatOptions options);
            static /*0x24f6180*/ int GetLengthIntegerToString(long value, int basis, int zeroPadding);
            static /*0x24f5ac0*/ void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, Unity.Burst.BurstString.FormatOptions options);
            static /*0x24f5f14*/ void FormatNumber(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits, Unity.Burst.BurstString.FormatOptions options);
            static /*0x24f61ac*/ void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int zeroPadding, bool outputPositiveSign);
            static /*0x24f5eb8*/ byte ValueToIntegerChar(int value, bool uppercase);
            static /*0x24f66bc*/ void OptsSplit(string fullFormat, ref string padding, ref string format);
            static /*0x24f6844*/ Unity.Burst.BurstString.FormatOptions ParseFormatToFormatOptions(string fullFormat);
            static /*0x24f4b7c*/ bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length);
            static /*0x24f4b30*/ bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length);
            static /*0x24f637c*/ int GetLengthForFormatGeneral(ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits);
            static /*0x24f64c8*/ void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits, byte expChar);
            static /*0x24f624c*/ void RoundNumber(ref Unity.Burst.BurstString.NumberBuffer number, int pos, bool isCorrectlyRounded);
            static /*0x24f6c74*/ bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded);
            static /*0x24f6c98*/ uint LogBase2(uint val);
            static /*0x24f6dbc*/ int BigInt_Compare(ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x24f6e0c*/ void BigInt_Add(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x24f6e94*/ void BigInt_Add_internal(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt pLarge, ref Unity.Burst.BurstString.tBigInt pSmall);
            static /*0x24f6f18*/ void BigInt_Multiply(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x24f6fa0*/ void BigInt_Multiply_internal(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt pLarge, ref Unity.Burst.BurstString.tBigInt pSmall);
            static /*0x24f7050*/ void BigInt_Multiply(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, uint rhs);
            static /*0x24f70b0*/ void BigInt_Multiply2(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt input);
            static /*0x24f710c*/ void BigInt_Multiply2(ref Unity.Burst.BurstString.tBigInt pResult);
            static /*0x24f7164*/ void BigInt_Multiply10(ref Unity.Burst.BurstString.tBigInt pResult);
            static /*0x24f71c0*/ Unity.Burst.BurstString.tBigInt g_PowerOf10_Big(int i);
            static /*0x24f7408*/ void BigInt_Pow10(ref Unity.Burst.BurstString.tBigInt pResult, uint exponent);
            static /*0x24f7598*/ void BigInt_MultiplyPow10(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt input, uint exponent);
            static /*0x24f7724*/ void BigInt_Pow2(ref Unity.Burst.BurstString.tBigInt pResult, uint exponent);
            static /*0x24f7780*/ uint BigInt_DivideWithRemainder_MaxQuotient9(ref Unity.Burst.BurstString.tBigInt pDividend, ref Unity.Burst.BurstString.tBigInt divisor);
            static /*0x24f7924*/ void BigInt_ShiftLeft(ref Unity.Burst.BurstString.tBigInt pResult, uint shift);
            static /*0x24f7a50*/ uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, Unity.Burst.BurstString.CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, ref int pOutExponent);
            static /*0x24f82a4*/ int FormatPositional(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision);
            static /*0x24f84ec*/ int FormatScientific(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision);
            static /*0x24f875c*/ void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, Unity.Burst.BurstString.FormatOptions formatOptions);
            static /*0x24f4cd0*/ void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, Unity.Burst.BurstString.FormatOptions formatOptions);
            static /*0x24f4ff0*/ void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, Unity.Burst.BurstString.FormatOptions formatOptions);

            class PreserveAttribute : System.Attribute
            {
                /*0x24f8b4c*/ PreserveAttribute();
            }

            enum NumberBufferKind
            {
                Integer = 0,
                Float = 1,
            }

            struct NumberBuffer
            {
                /*0x10*/ byte* _buffer;
                /*0x18*/ Unity.Burst.BurstString.NumberBufferKind Kind;
                /*0x1c*/ int DigitsCount;
                /*0x20*/ int Scale;
                /*0x24*/ bool IsNegative;

                /*0x24f5efc*/ NumberBuffer(Unity.Burst.BurstString.NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative);
                /*0x24f8b54*/ byte* GetDigitsPointer();
            }

            enum NumberFormatKind
            {
                General = 0,
                Decimal = 1,
                DecimalForceSigned = 2,
                Hexadecimal = 3,
            }

            struct FormatOptions
            {
                /*0x10*/ Unity.Burst.BurstString.NumberFormatKind Kind;
                /*0x11*/ sbyte AlignAndSize;
                /*0x12*/ byte Specifier;
                /*0x13*/ bool Lowercase;

                /*0x24f6c5c*/ FormatOptions(Unity.Burst.BurstString.NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase);
                /*0x24f5ea8*/ bool get_Uppercase();
                /*0x24f8b5c*/ int EncodeToRaw();
                /*0x24f5e90*/ int GetBase();
                /*0x24f8b64*/ string ToString();
            }

            struct tBigInt
            {
                static int c_BigInt_MaxBlocks = 35;
                /*0x10*/ int m_length;
                /*0x14*/ Unity.Burst.BurstString.tBigInt.<m_blocks> m_blocks;

                /*0x24f8e50*/ int GetLength();
                /*0x24f8288*/ uint GetBlock(int idx);
                /*0x24f8e58*/ void SetZero();
                /*0x24f8294*/ bool IsZero();
                /*0x24f8258*/ void SetU64(ulong val);
                /*0x24f757c*/ void SetU32(uint val);
                /*0x24f8e60*/ uint GetU32();

                struct <m_blocks>e__FixedBuffer
                {
                    /*0x10*/ uint FixedElementField;
                }
            }

            enum CutoffMode
            {
                Unique = 0,
                TotalLength = 1,
                FractionLength = 2,
            }

            enum PrintFloatFormat
            {
                Positional = 0,
                Scientific = 1,
            }

            struct tFloatUnion32
            {
                /*0x10*/ float m_floatingPoint;
                /*0x10*/ uint m_integer;

                /*0x24f8970*/ bool IsNegative();
                /*0x24f8958*/ uint GetExponent();
                /*0x24f8964*/ uint GetMantissa();
            }

            struct tFloatUnion64
            {
                /*0x10*/ double m_floatingPoint;
                /*0x10*/ ulong m_integer;

                /*0x24f8994*/ bool IsNegative();
                /*0x24f897c*/ uint GetExponent();
                /*0x24f8988*/ ulong GetMantissa();
            }
        }

        enum DiagnosticId
        {
            ERR_InternalCompilerErrorInBackend = 100,
            ERR_InternalCompilerErrorInFunction = 101,
            ERR_InternalCompilerErrorInInstruction = 102,
            ERR_OnlyStaticMethodsAllowed = 1000,
            ERR_UnableToAccessManagedMethod = 1001,
            ERR_UnableToFindInterfaceMethod = 1002,
            ERR_UnexpectedEmptyMethodBody = 1003,
            ERR_ManagedArgumentsNotSupported = 1004,
            ERR_CatchConstructionNotSupported = 1006,
            ERR_CatchAndFilterConstructionNotSupported = 1007,
            ERR_LdfldaWithFixedArrayExpected = 1008,
            ERR_PointerExpected = 1009,
            ERR_LoadingFieldFromManagedObjectNotSupported = 1010,
            ERR_LoadingFieldWithManagedTypeNotSupported = 1011,
            ERR_LoadingArgumentWithManagedTypeNotSupported = 1012,
            ERR_CallingBurstDiscardMethodWithReturnValueNotSupported = 1015,
            ERR_CallingManagedMethodNotSupported = 1016,
            ERR_InstructionUnboxNotSupported = 1019,
            ERR_InstructionBoxNotSupported = 1020,
            ERR_InstructionNewobjWithManagedTypeNotSupported = 1021,
            ERR_AccessingManagedArrayNotSupported = 1022,
            ERR_InstructionLdtokenFieldNotSupported = 1023,
            ERR_InstructionLdtokenMethodNotSupported = 1024,
            ERR_InstructionLdtokenTypeNotSupported = 1025,
            ERR_InstructionLdtokenNotSupported = 1026,
            ERR_InstructionLdvirtftnNotSupported = 1027,
            ERR_InstructionNewarrNotSupported = 1028,
            ERR_InstructionRethrowNotSupported = 1029,
            ERR_InstructionCastclassNotSupported = 1030,
            ERR_InstructionLdftnNotSupported = 1032,
            ERR_InstructionLdstrNotSupported = 1033,
            ERR_InstructionStsfldNotSupported = 1034,
            ERR_InstructionEndfilterNotSupported = 1035,
            ERR_InstructionEndfinallyNotSupported = 1036,
            ERR_InstructionLeaveNotSupported = 1037,
            ERR_InstructionNotSupported = 1038,
            ERR_LoadingFromStaticFieldNotSupported = 1039,
            ERR_LoadingFromNonReadonlyStaticFieldNotSupported = 1040,
            ERR_LoadingFromManagedStaticFieldNotSupported = 1041,
            ERR_LoadingFromManagedNonReadonlyStaticFieldNotSupported = 1042,
            ERR_InstructionStfldToManagedObjectNotSupported = 1043,
            ERR_InstructionLdlenNonConstantLengthNotSupported = 1044,
            ERR_StructWithAutoLayoutNotSupported = 1045,
            ERR_StructWithGenericParametersAndExplicitLayoutNotSupported = 1047,
            ERR_StructSizeNotSupported = 1048,
            ERR_StructZeroSizeNotSupported = 1049,
            ERR_MarshalAsOnFieldNotSupported = 1050,
            ERR_TypeNotSupported = 1051,
            ERR_RequiredTypeModifierNotSupported = 1052,
            ERR_ErrorWhileProcessingVariable = 1053,
            ERR_UnableToResolveType = 1054,
            ERR_UnableToResolveMethod = 1055,
            ERR_ConstructorNotSupported = 1056,
            ERR_FunctionPointerMethodMissingBurstCompileAttribute = 1057,
            ERR_FunctionPointerTypeMissingBurstCompileAttribute = 1058,
            ERR_FunctionPointerMethodAndTypeMissingBurstCompileAttribute = 1059,
            INF_FunctionPointerMethodAndTypeMissingMonoPInvokeCallbackAttribute = 10590,
            ERR_MarshalAsOnParameterNotSupported = 1061,
            ERR_MarshalAsOnReturnTypeNotSupported = 1062,
            ERR_TypeNotBlittableForFunctionPointer = 1063,
            ERR_StructByValueNotSupported = 1064,
            ERR_StructsWithNonUnicodeCharsNotSupported = 1066,
            ERR_VectorsByValueNotSupported = 1067,
            ERR_MissingExternBindings = 1068,
            ERR_MarshalAsNativeTypeOnReturnTypeNotSupported = 1069,
            ERR_AssertTypeNotSupported = 1071,
            ERR_StoringToReadOnlyFieldNotAllowed = 1072,
            ERR_StoringToFieldInReadOnlyParameterNotAllowed = 1073,
            ERR_StoringToReadOnlyParameterNotAllowed = 1074,
            ERR_TypeManagerStaticFieldNotCompatible = 1075,
            ERR_UnableToFindTypeIndexForTypeManagerType = 1076,
            ERR_UnableToFindFieldForTypeManager = 1077,
            ERR_CircularStaticConstructorUsage = 1090,
            ERR_ExternalInternalCallsInStaticConstructorsNotSupported = 1091,
            ERR_PlatformNotSupported = 1092,
            ERR_InitModuleVerificationError = 1093,
            ERR_ModuleVerificationError = 1094,
            ERR_UnableToFindTypeRequiredForTypeManager = 1095,
            ERR_UnexpectedIntegerTypesForBinaryOperation = 1096,
            ERR_BinaryOperationNotSupported = 1097,
            ERR_CalliWithThisNotSupported = 1098,
            ERR_CalliNonCCallingConventionNotSupported = 1099,
            ERR_StringLiteralTooBig = 1100,
            ERR_LdftnNonCCallingConventionNotSupported = 1101,
            ERR_InstructionTargetCpuFeatureNotAllowedInThisBlock = 1200,
            ERR_AssumeRangeTypeMustBeInteger = 1201,
            ERR_AssumeRangeTypeMustBeSameSign = 1202,
            ERR_UnsupportedSpillTransform = 1300,
            ERR_UnsupportedSpillTransformTooManyUsers = 1301,
            ERR_MethodNotSupported = 1302,
            ERR_VectorsLoadFieldIsAddress = 1303,
            ERR_ConstantExpressionRequired = 1304,
            ERR_PointerArgumentsUnexpectedAliasing = 1310,
            ERR_LoopIntrinsicMustBeCalledInsideLoop = 1320,
            ERR_LoopUnexpectedAutoVectorization = 1321,
            WRN_LoopIntrinsicCalledButLoopOptimizedAway = 1322,
            ERR_AssertArgTypesDiffer = 1330,
            ERR_StringInternalCompilerFixedStringTooManyUsers = 1340,
            ERR_StringInvalidFormatMissingClosingBrace = 1341,
            ERR_StringInvalidIntegerForArgumentIndex = 1342,
            ERR_StringInvalidFormatForArgument = 1343,
            ERR_StringArgumentIndexOutOfRange = 1344,
            ERR_StringInvalidArgumentType = 1345,
            ERR_DebugLogNotSupported = 1346,
            ERR_StringInvalidNonLiteralFormat = 1347,
            ERR_StringInvalidStringFormatMethod = 1348,
            ERR_StringInvalidArgument = 1349,
            ERR_StringArrayInvalidArrayCreation = 1350,
            ERR_StringArrayInvalidArraySize = 1351,
            ERR_StringArrayInvalidControlFlow = 1352,
            ERR_StringArrayInvalidArrayIndex = 1353,
            ERR_StringArrayInvalidArrayIndexOutOfRange = 1354,
            ERR_UnmanagedStringMethodMissing = 1355,
            ERR_UnmanagedStringMethodInvalid = 1356,
            ERR_ManagedStaticConstructor = 1360,
            ERR_StaticConstantArrayInStaticConstructor = 1361,
            WRN_ExceptionThrownInNonSafetyCheckGuardedFunction = 1370,
            WRN_ACallToMethodHasBeenDiscarded = 1371,
            ERR_AccessingNestedManagedArrayNotSupported = 1380,
            ERR_LdobjFromANonPointerNonReference = 1381,
            ERR_StringLiteralRequired = 1382,
            ERR_MultiDimensionalArrayUnsupported = 1383,
            ERR_NonBlittableAndNonManagedSequentialStructNotSupported = 1384,
            ERR_VarArgFunctionNotSupported = 1385,
        }

        interface IFunctionPointer
        {
            Unity.Burst.IFunctionPointer FromIntPtr(nint ptr);
        }

        struct FunctionPointer<T> : Unity.Burst.IFunctionPointer
        {
            /*0x0*/ nint _ptr;

            FunctionPointer(nint ptr);
            nint get_Value();
            void CheckIsCreated();
            T get_Invoke();
            bool get_IsCreated();
            Unity.Burst.IFunctionPointer Unity.Burst.IFunctionPointer.FromIntPtr(nint ptr);
        }

        class NoAliasAttribute : System.Attribute
        {
            /*0x24f8e78*/ NoAliasAttribute();
        }

        struct SharedStatic<T>
        {
            static uint DefaultAlignment = 16;
            /*0x0*/ void* _buffer;

            static Unity.Burst.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
            static Unity.Burst.SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment);
            static Unity.Burst.SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode);
            static Unity.Burst.SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode<TSubContext>(uint alignment, long hashCode);
            static Unity.Burst.SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode<TContext>(uint alignment, long subHashCode);
            static Unity.Burst.SharedStatic<T> GetOrCreate(System.Type contextType, uint alignment);
            static Unity.Burst.SharedStatic<T> GetOrCreate(System.Type contextType, System.Type subContextType, uint alignment);
            static void CheckIf_T_IsUnmanagedOrThrow();
            SharedStatic(void* buffer);
            ref T get_Data();
            void* get_UnsafeDataPointer();
        }

        class SharedStatic
        {
            static /*0x24f8e80*/ void CheckSizeOf(uint sizeOf);
            static /*0x24f8ef0*/ void CheckResult(void* result);
            static /*0x24f8f48*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);

            class PreserveAttribute : System.Attribute
            {
                /*0x24f8f98*/ PreserveAttribute();
            }
        }

        namespace Intrinsics
        {
            class Arm
            {
                class Neon
                {
                    static /*0x24f8fa0*/ bool get_IsNeonSupported();
                    static /*0x24f8fa8*/ Unity.Burst.Intrinsics.v64 vadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f8fe8*/ Unity.Burst.Intrinsics.v128 vaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9028*/ Unity.Burst.Intrinsics.v64 vadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9068*/ Unity.Burst.Intrinsics.v128 vaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f90a8*/ Unity.Burst.Intrinsics.v64 vadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f90e8*/ Unity.Burst.Intrinsics.v128 vaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9128*/ Unity.Burst.Intrinsics.v64 vadd_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9168*/ Unity.Burst.Intrinsics.v128 vaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f91a8*/ Unity.Burst.Intrinsics.v64 vadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f91b0*/ Unity.Burst.Intrinsics.v128 vaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f91b8*/ Unity.Burst.Intrinsics.v64 vadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f91c0*/ Unity.Burst.Intrinsics.v128 vaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f91c8*/ Unity.Burst.Intrinsics.v64 vadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f91d0*/ Unity.Burst.Intrinsics.v128 vaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f91d8*/ Unity.Burst.Intrinsics.v64 vadd_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f91e0*/ Unity.Burst.Intrinsics.v128 vaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f91e8*/ Unity.Burst.Intrinsics.v64 vadd_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9228*/ Unity.Burst.Intrinsics.v128 vaddq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9268*/ Unity.Burst.Intrinsics.v128 vaddl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f92a8*/ Unity.Burst.Intrinsics.v128 vaddl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f92e8*/ Unity.Burst.Intrinsics.v128 vaddl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9328*/ Unity.Burst.Intrinsics.v128 vaddl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9368*/ Unity.Burst.Intrinsics.v128 vaddl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f93a8*/ Unity.Burst.Intrinsics.v128 vaddl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f93e8*/ Unity.Burst.Intrinsics.v128 vaddw_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9428*/ Unity.Burst.Intrinsics.v128 vaddw_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9468*/ Unity.Burst.Intrinsics.v128 vaddw_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f94a8*/ Unity.Burst.Intrinsics.v128 vaddw_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f94e8*/ Unity.Burst.Intrinsics.v128 vaddw_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9528*/ Unity.Burst.Intrinsics.v128 vaddw_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9568*/ Unity.Burst.Intrinsics.v64 vhadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f95a8*/ Unity.Burst.Intrinsics.v128 vhaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f95e8*/ Unity.Burst.Intrinsics.v64 vhadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9628*/ Unity.Burst.Intrinsics.v128 vhaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9668*/ Unity.Burst.Intrinsics.v64 vhadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f96a8*/ Unity.Burst.Intrinsics.v128 vhaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f96e8*/ Unity.Burst.Intrinsics.v64 vhadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9728*/ Unity.Burst.Intrinsics.v128 vhaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9768*/ Unity.Burst.Intrinsics.v64 vhadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f97a8*/ Unity.Burst.Intrinsics.v128 vhaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f97e8*/ Unity.Burst.Intrinsics.v64 vhadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9828*/ Unity.Burst.Intrinsics.v128 vhaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9868*/ Unity.Burst.Intrinsics.v64 vrhadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f98a8*/ Unity.Burst.Intrinsics.v128 vrhaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f98e8*/ Unity.Burst.Intrinsics.v64 vrhadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9928*/ Unity.Burst.Intrinsics.v128 vrhaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9968*/ Unity.Burst.Intrinsics.v64 vrhadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f99a8*/ Unity.Burst.Intrinsics.v128 vrhaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f99e8*/ Unity.Burst.Intrinsics.v64 vrhadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9a28*/ Unity.Burst.Intrinsics.v128 vrhaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9a68*/ Unity.Burst.Intrinsics.v64 vrhadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9aa8*/ Unity.Burst.Intrinsics.v128 vrhaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9ae8*/ Unity.Burst.Intrinsics.v64 vrhadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9b28*/ Unity.Burst.Intrinsics.v128 vrhaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9b68*/ Unity.Burst.Intrinsics.v64 vqadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9ba8*/ Unity.Burst.Intrinsics.v128 vqaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9be8*/ Unity.Burst.Intrinsics.v64 vqadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9c28*/ Unity.Burst.Intrinsics.v128 vqaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9c68*/ Unity.Burst.Intrinsics.v64 vqadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9ca8*/ Unity.Burst.Intrinsics.v128 vqaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9ce8*/ Unity.Burst.Intrinsics.v64 vqadd_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9d28*/ Unity.Burst.Intrinsics.v128 vqaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9d68*/ Unity.Burst.Intrinsics.v64 vqadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9da8*/ Unity.Burst.Intrinsics.v128 vqaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9de8*/ Unity.Burst.Intrinsics.v64 vqadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9e28*/ Unity.Burst.Intrinsics.v128 vqaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9e68*/ Unity.Burst.Intrinsics.v64 vqadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9ea8*/ Unity.Burst.Intrinsics.v128 vqaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9ee8*/ Unity.Burst.Intrinsics.v64 vqadd_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24f9f28*/ Unity.Burst.Intrinsics.v128 vqaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9f68*/ Unity.Burst.Intrinsics.v64 vaddhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9fa8*/ Unity.Burst.Intrinsics.v64 vaddhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24f9fe8*/ Unity.Burst.Intrinsics.v64 vaddhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa028*/ Unity.Burst.Intrinsics.v64 vaddhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa030*/ Unity.Burst.Intrinsics.v64 vaddhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa038*/ Unity.Burst.Intrinsics.v64 vaddhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa040*/ Unity.Burst.Intrinsics.v64 vraddhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa080*/ Unity.Burst.Intrinsics.v64 vraddhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa0c0*/ Unity.Burst.Intrinsics.v64 vraddhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa100*/ Unity.Burst.Intrinsics.v64 vraddhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa108*/ Unity.Burst.Intrinsics.v64 vraddhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa110*/ Unity.Burst.Intrinsics.v64 vraddhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa118*/ Unity.Burst.Intrinsics.v64 vmul_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa158*/ Unity.Burst.Intrinsics.v128 vmulq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa198*/ Unity.Burst.Intrinsics.v64 vmul_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa1d8*/ Unity.Burst.Intrinsics.v128 vmulq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa218*/ Unity.Burst.Intrinsics.v64 vmul_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa258*/ Unity.Burst.Intrinsics.v128 vmulq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa298*/ Unity.Burst.Intrinsics.v64 vmul_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa2a0*/ Unity.Burst.Intrinsics.v128 vmulq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa2a8*/ Unity.Burst.Intrinsics.v64 vmul_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa2b0*/ Unity.Burst.Intrinsics.v128 vmulq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa2b8*/ Unity.Burst.Intrinsics.v64 vmul_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa2c0*/ Unity.Burst.Intrinsics.v128 vmulq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa2c8*/ Unity.Burst.Intrinsics.v64 vmul_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fa308*/ Unity.Burst.Intrinsics.v128 vmulq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fa348*/ Unity.Burst.Intrinsics.v64 vmla_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa388*/ Unity.Burst.Intrinsics.v128 vmlaq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa3c8*/ Unity.Burst.Intrinsics.v64 vmla_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa408*/ Unity.Burst.Intrinsics.v128 vmlaq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa448*/ Unity.Burst.Intrinsics.v64 vmla_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa488*/ Unity.Burst.Intrinsics.v128 vmlaq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa4c8*/ Unity.Burst.Intrinsics.v64 vmla_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa4d0*/ Unity.Burst.Intrinsics.v128 vmlaq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa4d8*/ Unity.Burst.Intrinsics.v64 vmla_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa4e0*/ Unity.Burst.Intrinsics.v128 vmlaq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa4e8*/ Unity.Burst.Intrinsics.v64 vmla_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa4f0*/ Unity.Burst.Intrinsics.v128 vmlaq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa4f8*/ Unity.Burst.Intrinsics.v64 vmla_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa538*/ Unity.Burst.Intrinsics.v128 vmlaq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa578*/ Unity.Burst.Intrinsics.v128 vmlal_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa5b8*/ Unity.Burst.Intrinsics.v128 vmlal_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa5f8*/ Unity.Burst.Intrinsics.v128 vmlal_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa638*/ Unity.Burst.Intrinsics.v128 vmlal_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa678*/ Unity.Burst.Intrinsics.v128 vmlal_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa6b8*/ Unity.Burst.Intrinsics.v128 vmlal_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa6f8*/ Unity.Burst.Intrinsics.v64 vmls_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa738*/ Unity.Burst.Intrinsics.v128 vmlsq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa778*/ Unity.Burst.Intrinsics.v64 vmls_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa7b8*/ Unity.Burst.Intrinsics.v128 vmlsq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa7f8*/ Unity.Burst.Intrinsics.v64 vmls_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa838*/ Unity.Burst.Intrinsics.v128 vmlsq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa878*/ Unity.Burst.Intrinsics.v64 vmls_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa880*/ Unity.Burst.Intrinsics.v128 vmlsq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa888*/ Unity.Burst.Intrinsics.v64 vmls_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa890*/ Unity.Burst.Intrinsics.v128 vmlsq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa898*/ Unity.Burst.Intrinsics.v64 vmls_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa8a0*/ Unity.Burst.Intrinsics.v128 vmlsq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa8a8*/ Unity.Burst.Intrinsics.v64 vmls_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa8e8*/ Unity.Burst.Intrinsics.v128 vmlsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fa928*/ Unity.Burst.Intrinsics.v128 vmlsl_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa968*/ Unity.Burst.Intrinsics.v128 vmlsl_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa9a8*/ Unity.Burst.Intrinsics.v128 vmlsl_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fa9e8*/ Unity.Burst.Intrinsics.v128 vmlsl_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24faa28*/ Unity.Burst.Intrinsics.v128 vmlsl_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24faa68*/ Unity.Burst.Intrinsics.v128 vmlsl_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24faaa8*/ Unity.Burst.Intrinsics.v64 vfma_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24faae8*/ Unity.Burst.Intrinsics.v128 vfmaq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fab28*/ Unity.Burst.Intrinsics.v64 vfms_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fab68*/ Unity.Burst.Intrinsics.v128 vfmsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24faba8*/ Unity.Burst.Intrinsics.v64 vqdmulh_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fabe8*/ Unity.Burst.Intrinsics.v128 vqdmulhq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fac28*/ Unity.Burst.Intrinsics.v64 vqdmulh_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fac68*/ Unity.Burst.Intrinsics.v128 vqdmulhq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24faca8*/ Unity.Burst.Intrinsics.v64 vqrdmulh_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24face8*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fad28*/ Unity.Burst.Intrinsics.v64 vqrdmulh_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fad68*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fada8*/ Unity.Burst.Intrinsics.v128 vqdmlal_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fade8*/ Unity.Burst.Intrinsics.v128 vqdmlal_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fae28*/ Unity.Burst.Intrinsics.v128 vqdmlsl_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fae68*/ Unity.Burst.Intrinsics.v128 vqdmlsl_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24faea8*/ Unity.Burst.Intrinsics.v128 vmull_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24faee8*/ Unity.Burst.Intrinsics.v128 vmull_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24faf28*/ Unity.Burst.Intrinsics.v128 vmull_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24faf68*/ Unity.Burst.Intrinsics.v128 vmull_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fafa8*/ Unity.Burst.Intrinsics.v128 vmull_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fafe8*/ Unity.Burst.Intrinsics.v128 vmull_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb028*/ Unity.Burst.Intrinsics.v128 vqdmull_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb068*/ Unity.Burst.Intrinsics.v128 vqdmull_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb0a8*/ Unity.Burst.Intrinsics.v64 vsub_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb0e8*/ Unity.Burst.Intrinsics.v128 vsubq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb128*/ Unity.Burst.Intrinsics.v64 vsub_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb168*/ Unity.Burst.Intrinsics.v128 vsubq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb1a8*/ Unity.Burst.Intrinsics.v64 vsub_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb1e8*/ Unity.Burst.Intrinsics.v128 vsubq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb228*/ Unity.Burst.Intrinsics.v64 vsub_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb268*/ Unity.Burst.Intrinsics.v128 vsubq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb2a8*/ Unity.Burst.Intrinsics.v64 vsub_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb2b0*/ Unity.Burst.Intrinsics.v128 vsubq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb2b8*/ Unity.Burst.Intrinsics.v64 vsub_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb2c0*/ Unity.Burst.Intrinsics.v128 vsubq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb2c8*/ Unity.Burst.Intrinsics.v64 vsub_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb2d0*/ Unity.Burst.Intrinsics.v128 vsubq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb2d8*/ Unity.Burst.Intrinsics.v64 vsub_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb2e0*/ Unity.Burst.Intrinsics.v128 vsubq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb2e8*/ Unity.Burst.Intrinsics.v64 vsub_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb328*/ Unity.Burst.Intrinsics.v128 vsubq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb368*/ Unity.Burst.Intrinsics.v128 vsubl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb3a8*/ Unity.Burst.Intrinsics.v128 vsubl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb3e8*/ Unity.Burst.Intrinsics.v128 vsubl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb428*/ Unity.Burst.Intrinsics.v128 vsubl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb468*/ Unity.Burst.Intrinsics.v128 vsubl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb4a8*/ Unity.Burst.Intrinsics.v128 vsubl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb4e8*/ Unity.Burst.Intrinsics.v128 vsubw_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb528*/ Unity.Burst.Intrinsics.v128 vsubw_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb568*/ Unity.Burst.Intrinsics.v128 vsubw_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb5a8*/ Unity.Burst.Intrinsics.v128 vsubw_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb5e8*/ Unity.Burst.Intrinsics.v128 vsubw_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb628*/ Unity.Burst.Intrinsics.v128 vsubw_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb668*/ Unity.Burst.Intrinsics.v64 vhsub_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb6a8*/ Unity.Burst.Intrinsics.v128 vhsubq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb6e8*/ Unity.Burst.Intrinsics.v64 vhsub_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb728*/ Unity.Burst.Intrinsics.v128 vhsubq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb768*/ Unity.Burst.Intrinsics.v64 vhsub_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb7a8*/ Unity.Burst.Intrinsics.v128 vhsubq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb7e8*/ Unity.Burst.Intrinsics.v64 vhsub_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb828*/ Unity.Burst.Intrinsics.v128 vhsubq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb868*/ Unity.Burst.Intrinsics.v64 vhsub_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb8a8*/ Unity.Burst.Intrinsics.v128 vhsubq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb8e8*/ Unity.Burst.Intrinsics.v64 vhsub_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb928*/ Unity.Burst.Intrinsics.v128 vhsubq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb968*/ Unity.Burst.Intrinsics.v64 vqsub_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fb9a8*/ Unity.Burst.Intrinsics.v128 vqsubq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fb9e8*/ Unity.Burst.Intrinsics.v64 vqsub_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fba28*/ Unity.Burst.Intrinsics.v128 vqsubq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fba68*/ Unity.Burst.Intrinsics.v64 vqsub_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbaa8*/ Unity.Burst.Intrinsics.v128 vqsubq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbae8*/ Unity.Burst.Intrinsics.v64 vqsub_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbb28*/ Unity.Burst.Intrinsics.v128 vqsubq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbb68*/ Unity.Burst.Intrinsics.v64 vqsub_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbba8*/ Unity.Burst.Intrinsics.v128 vqsubq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbbe8*/ Unity.Burst.Intrinsics.v64 vqsub_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbc28*/ Unity.Burst.Intrinsics.v128 vqsubq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbc68*/ Unity.Burst.Intrinsics.v64 vqsub_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbca8*/ Unity.Burst.Intrinsics.v128 vqsubq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbce8*/ Unity.Burst.Intrinsics.v64 vqsub_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbd28*/ Unity.Burst.Intrinsics.v128 vqsubq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbd68*/ Unity.Burst.Intrinsics.v64 vsubhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbda8*/ Unity.Burst.Intrinsics.v64 vsubhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbde8*/ Unity.Burst.Intrinsics.v64 vsubhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbe28*/ Unity.Burst.Intrinsics.v64 vsubhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbe30*/ Unity.Burst.Intrinsics.v64 vsubhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbe38*/ Unity.Burst.Intrinsics.v64 vsubhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbe40*/ Unity.Burst.Intrinsics.v64 vrsubhn_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbe80*/ Unity.Burst.Intrinsics.v64 vrsubhn_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbec0*/ Unity.Burst.Intrinsics.v64 vrsubhn_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbf00*/ Unity.Burst.Intrinsics.v64 vrsubhn_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbf08*/ Unity.Burst.Intrinsics.v64 vrsubhn_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbf10*/ Unity.Burst.Intrinsics.v64 vrsubhn_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbf18*/ Unity.Burst.Intrinsics.v64 vceq_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbf58*/ Unity.Burst.Intrinsics.v128 vceqq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fbf98*/ Unity.Burst.Intrinsics.v64 vceq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fbfd8*/ Unity.Burst.Intrinsics.v128 vceqq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc018*/ Unity.Burst.Intrinsics.v64 vceq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc058*/ Unity.Burst.Intrinsics.v128 vceqq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc098*/ Unity.Burst.Intrinsics.v64 vceq_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc0a0*/ Unity.Burst.Intrinsics.v128 vceqq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc0a8*/ Unity.Burst.Intrinsics.v64 vceq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc0b0*/ Unity.Burst.Intrinsics.v128 vceqq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc0b8*/ Unity.Burst.Intrinsics.v64 vceq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc0c0*/ Unity.Burst.Intrinsics.v128 vceqq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc0c8*/ Unity.Burst.Intrinsics.v64 vceq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc108*/ Unity.Burst.Intrinsics.v128 vceqq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc148*/ Unity.Burst.Intrinsics.v64 vcge_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc188*/ Unity.Burst.Intrinsics.v128 vcgeq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc1c8*/ Unity.Burst.Intrinsics.v64 vcge_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc208*/ Unity.Burst.Intrinsics.v128 vcgeq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc248*/ Unity.Burst.Intrinsics.v64 vcge_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc288*/ Unity.Burst.Intrinsics.v128 vcgeq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc2c8*/ Unity.Burst.Intrinsics.v64 vcge_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc308*/ Unity.Burst.Intrinsics.v128 vcgeq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc348*/ Unity.Burst.Intrinsics.v64 vcge_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc388*/ Unity.Burst.Intrinsics.v128 vcgeq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc3c8*/ Unity.Burst.Intrinsics.v64 vcge_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc408*/ Unity.Burst.Intrinsics.v128 vcgeq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc448*/ Unity.Burst.Intrinsics.v64 vcge_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc488*/ Unity.Burst.Intrinsics.v128 vcgeq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc4c8*/ Unity.Burst.Intrinsics.v64 vcle_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc508*/ Unity.Burst.Intrinsics.v128 vcleq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc548*/ Unity.Burst.Intrinsics.v64 vcle_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc588*/ Unity.Burst.Intrinsics.v128 vcleq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc5c8*/ Unity.Burst.Intrinsics.v64 vcle_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc608*/ Unity.Burst.Intrinsics.v128 vcleq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc648*/ Unity.Burst.Intrinsics.v64 vcle_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc688*/ Unity.Burst.Intrinsics.v128 vcleq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc6c8*/ Unity.Burst.Intrinsics.v64 vcle_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc708*/ Unity.Burst.Intrinsics.v128 vcleq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc748*/ Unity.Burst.Intrinsics.v64 vcle_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc788*/ Unity.Burst.Intrinsics.v128 vcleq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc7c8*/ Unity.Burst.Intrinsics.v64 vcle_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc808*/ Unity.Burst.Intrinsics.v128 vcleq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc848*/ Unity.Burst.Intrinsics.v64 vcgt_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc888*/ Unity.Burst.Intrinsics.v128 vcgtq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc8c8*/ Unity.Burst.Intrinsics.v64 vcgt_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc908*/ Unity.Burst.Intrinsics.v128 vcgtq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc948*/ Unity.Burst.Intrinsics.v64 vcgt_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fc988*/ Unity.Burst.Intrinsics.v128 vcgtq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fc9c8*/ Unity.Burst.Intrinsics.v64 vcgt_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fca08*/ Unity.Burst.Intrinsics.v128 vcgtq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fca48*/ Unity.Burst.Intrinsics.v64 vcgt_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fca88*/ Unity.Burst.Intrinsics.v128 vcgtq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcac8*/ Unity.Burst.Intrinsics.v64 vcgt_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcb08*/ Unity.Burst.Intrinsics.v128 vcgtq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcb48*/ Unity.Burst.Intrinsics.v64 vcgt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcb88*/ Unity.Burst.Intrinsics.v128 vcgtq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcbc8*/ Unity.Burst.Intrinsics.v64 vclt_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcc08*/ Unity.Burst.Intrinsics.v128 vcltq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcc48*/ Unity.Burst.Intrinsics.v64 vclt_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcc88*/ Unity.Burst.Intrinsics.v128 vcltq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fccc8*/ Unity.Burst.Intrinsics.v64 vclt_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcd08*/ Unity.Burst.Intrinsics.v128 vcltq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcd48*/ Unity.Burst.Intrinsics.v64 vclt_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcd88*/ Unity.Burst.Intrinsics.v128 vcltq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcdc8*/ Unity.Burst.Intrinsics.v64 vclt_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fce08*/ Unity.Burst.Intrinsics.v128 vcltq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fce48*/ Unity.Burst.Intrinsics.v64 vclt_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fce88*/ Unity.Burst.Intrinsics.v128 vcltq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcec8*/ Unity.Burst.Intrinsics.v64 vclt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcf08*/ Unity.Burst.Intrinsics.v128 vcltq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcf48*/ Unity.Burst.Intrinsics.v64 vcage_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fcf88*/ Unity.Burst.Intrinsics.v128 vcageq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fcfc8*/ Unity.Burst.Intrinsics.v64 vcale_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd008*/ Unity.Burst.Intrinsics.v128 vcaleq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd048*/ Unity.Burst.Intrinsics.v64 vcagt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd088*/ Unity.Burst.Intrinsics.v128 vcagtq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd0c8*/ Unity.Burst.Intrinsics.v64 vcalt_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd108*/ Unity.Burst.Intrinsics.v128 vcaltq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd148*/ Unity.Burst.Intrinsics.v64 vtst_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd188*/ Unity.Burst.Intrinsics.v128 vtstq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd1c8*/ Unity.Burst.Intrinsics.v64 vtst_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd208*/ Unity.Burst.Intrinsics.v128 vtstq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd248*/ Unity.Burst.Intrinsics.v64 vtst_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd288*/ Unity.Burst.Intrinsics.v128 vtstq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd2c8*/ Unity.Burst.Intrinsics.v64 vtst_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd2d0*/ Unity.Burst.Intrinsics.v128 vtstq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd2d8*/ Unity.Burst.Intrinsics.v64 vtst_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd2e0*/ Unity.Burst.Intrinsics.v128 vtstq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd2e8*/ Unity.Burst.Intrinsics.v64 vtst_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd2f0*/ Unity.Burst.Intrinsics.v128 vtstq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd2f8*/ Unity.Burst.Intrinsics.v64 vabd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd338*/ Unity.Burst.Intrinsics.v128 vabdq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd378*/ Unity.Burst.Intrinsics.v64 vabd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd3b8*/ Unity.Burst.Intrinsics.v128 vabdq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd3f8*/ Unity.Burst.Intrinsics.v64 vabd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd438*/ Unity.Burst.Intrinsics.v128 vabdq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd478*/ Unity.Burst.Intrinsics.v64 vabd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd4b8*/ Unity.Burst.Intrinsics.v128 vabdq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd4f8*/ Unity.Burst.Intrinsics.v64 vabd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd538*/ Unity.Burst.Intrinsics.v128 vabdq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd578*/ Unity.Burst.Intrinsics.v64 vabd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd5b8*/ Unity.Burst.Intrinsics.v128 vabdq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd5f8*/ Unity.Burst.Intrinsics.v64 vabd_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd638*/ Unity.Burst.Intrinsics.v128 vabdq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fd678*/ Unity.Burst.Intrinsics.v128 vabdl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd6b8*/ Unity.Burst.Intrinsics.v128 vabdl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd6f8*/ Unity.Burst.Intrinsics.v128 vabdl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd738*/ Unity.Burst.Intrinsics.v128 vabdl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd778*/ Unity.Burst.Intrinsics.v128 vabdl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd7b8*/ Unity.Burst.Intrinsics.v128 vabdl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fd7f8*/ Unity.Burst.Intrinsics.v64 vaba_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fd838*/ Unity.Burst.Intrinsics.v128 vabaq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fd878*/ Unity.Burst.Intrinsics.v64 vaba_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fd8b8*/ Unity.Burst.Intrinsics.v128 vabaq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fd8f8*/ Unity.Burst.Intrinsics.v64 vaba_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fd938*/ Unity.Burst.Intrinsics.v128 vabaq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fd978*/ Unity.Burst.Intrinsics.v64 vaba_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fd9b8*/ Unity.Burst.Intrinsics.v128 vabaq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fd9f8*/ Unity.Burst.Intrinsics.v64 vaba_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fda38*/ Unity.Burst.Intrinsics.v128 vabaq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fda78*/ Unity.Burst.Intrinsics.v64 vaba_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdab8*/ Unity.Burst.Intrinsics.v128 vabaq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x24fdaf8*/ Unity.Burst.Intrinsics.v128 vabal_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdb38*/ Unity.Burst.Intrinsics.v128 vabal_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdb78*/ Unity.Burst.Intrinsics.v128 vabal_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdbb8*/ Unity.Burst.Intrinsics.v128 vabal_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdbf8*/ Unity.Burst.Intrinsics.v128 vabal_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdc38*/ Unity.Burst.Intrinsics.v128 vabal_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x24fdc78*/ Unity.Burst.Intrinsics.v64 vmax_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fdcb8*/ Unity.Burst.Intrinsics.v128 vmaxq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fdcf8*/ Unity.Burst.Intrinsics.v64 vmax_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fdd38*/ Unity.Burst.Intrinsics.v128 vmaxq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fdd78*/ Unity.Burst.Intrinsics.v64 vmax_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fddb8*/ Unity.Burst.Intrinsics.v128 vmaxq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fddf8*/ Unity.Burst.Intrinsics.v64 vmax_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fde38*/ Unity.Burst.Intrinsics.v128 vmaxq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fde78*/ Unity.Burst.Intrinsics.v64 vmax_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fdeb8*/ Unity.Burst.Intrinsics.v128 vmaxq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fdef8*/ Unity.Burst.Intrinsics.v64 vmax_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fdf38*/ Unity.Burst.Intrinsics.v128 vmaxq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fdf78*/ Unity.Burst.Intrinsics.v64 vmax_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fdfb8*/ Unity.Burst.Intrinsics.v128 vmaxq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fdff8*/ Unity.Burst.Intrinsics.v64 vmin_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe038*/ Unity.Burst.Intrinsics.v128 vminq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe078*/ Unity.Burst.Intrinsics.v64 vmin_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe0b8*/ Unity.Burst.Intrinsics.v128 vminq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe0f8*/ Unity.Burst.Intrinsics.v64 vmin_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe138*/ Unity.Burst.Intrinsics.v128 vminq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe178*/ Unity.Burst.Intrinsics.v64 vmin_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe1b8*/ Unity.Burst.Intrinsics.v128 vminq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe1f8*/ Unity.Burst.Intrinsics.v64 vmin_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe238*/ Unity.Burst.Intrinsics.v128 vminq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe278*/ Unity.Burst.Intrinsics.v64 vmin_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe2b8*/ Unity.Burst.Intrinsics.v128 vminq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe2f8*/ Unity.Burst.Intrinsics.v64 vmin_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe338*/ Unity.Burst.Intrinsics.v128 vminq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe378*/ Unity.Burst.Intrinsics.v64 vshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe3b8*/ Unity.Burst.Intrinsics.v128 vshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe3f8*/ Unity.Burst.Intrinsics.v64 vshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe438*/ Unity.Burst.Intrinsics.v128 vshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe478*/ Unity.Burst.Intrinsics.v64 vshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe4b8*/ Unity.Burst.Intrinsics.v128 vshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe4f8*/ Unity.Burst.Intrinsics.v64 vshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe538*/ Unity.Burst.Intrinsics.v128 vshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe578*/ Unity.Burst.Intrinsics.v64 vshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe5b8*/ Unity.Burst.Intrinsics.v128 vshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe5f8*/ Unity.Burst.Intrinsics.v64 vshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe638*/ Unity.Burst.Intrinsics.v128 vshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe678*/ Unity.Burst.Intrinsics.v64 vshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe6b8*/ Unity.Burst.Intrinsics.v128 vshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe6f8*/ Unity.Burst.Intrinsics.v64 vshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe738*/ Unity.Burst.Intrinsics.v128 vshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe778*/ Unity.Burst.Intrinsics.v64 vqshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe7b8*/ Unity.Burst.Intrinsics.v128 vqshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe7f8*/ Unity.Burst.Intrinsics.v64 vqshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe838*/ Unity.Burst.Intrinsics.v128 vqshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe878*/ Unity.Burst.Intrinsics.v64 vqshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe8b8*/ Unity.Burst.Intrinsics.v128 vqshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe8f8*/ Unity.Burst.Intrinsics.v64 vqshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe938*/ Unity.Burst.Intrinsics.v128 vqshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe978*/ Unity.Burst.Intrinsics.v64 vqshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fe9b8*/ Unity.Burst.Intrinsics.v128 vqshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fe9f8*/ Unity.Burst.Intrinsics.v64 vqshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fea38*/ Unity.Burst.Intrinsics.v128 vqshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fea78*/ Unity.Burst.Intrinsics.v64 vqshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24feab8*/ Unity.Burst.Intrinsics.v128 vqshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24feaf8*/ Unity.Burst.Intrinsics.v64 vqshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24feb38*/ Unity.Burst.Intrinsics.v128 vqshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24feb78*/ Unity.Burst.Intrinsics.v64 vrshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24febb8*/ Unity.Burst.Intrinsics.v128 vrshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24febf8*/ Unity.Burst.Intrinsics.v64 vrshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fec38*/ Unity.Burst.Intrinsics.v128 vrshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fec78*/ Unity.Burst.Intrinsics.v64 vrshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fecb8*/ Unity.Burst.Intrinsics.v128 vrshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fecf8*/ Unity.Burst.Intrinsics.v64 vrshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fed38*/ Unity.Burst.Intrinsics.v128 vrshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fed78*/ Unity.Burst.Intrinsics.v64 vrshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fedb8*/ Unity.Burst.Intrinsics.v128 vrshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fedf8*/ Unity.Burst.Intrinsics.v64 vrshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fee38*/ Unity.Burst.Intrinsics.v128 vrshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fee78*/ Unity.Burst.Intrinsics.v64 vrshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24feeb8*/ Unity.Burst.Intrinsics.v128 vrshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24feef8*/ Unity.Burst.Intrinsics.v64 vrshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fef38*/ Unity.Burst.Intrinsics.v128 vrshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24fef78*/ Unity.Burst.Intrinsics.v64 vqrshl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24fefb8*/ Unity.Burst.Intrinsics.v128 vqrshlq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24feff8*/ Unity.Burst.Intrinsics.v64 vqrshl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff038*/ Unity.Burst.Intrinsics.v128 vqrshlq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff078*/ Unity.Burst.Intrinsics.v64 vqrshl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff0b8*/ Unity.Burst.Intrinsics.v128 vqrshlq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff0f8*/ Unity.Burst.Intrinsics.v64 vqrshl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff138*/ Unity.Burst.Intrinsics.v128 vqrshlq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff178*/ Unity.Burst.Intrinsics.v64 vqrshl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff1b8*/ Unity.Burst.Intrinsics.v128 vqrshlq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff1f8*/ Unity.Burst.Intrinsics.v64 vqrshl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff238*/ Unity.Burst.Intrinsics.v128 vqrshlq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff278*/ Unity.Burst.Intrinsics.v64 vqrshl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff2b8*/ Unity.Burst.Intrinsics.v128 vqrshlq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff2f8*/ Unity.Burst.Intrinsics.v64 vqrshl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x24ff338*/ Unity.Burst.Intrinsics.v128 vqrshlq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x24ff378*/ Unity.Burst.Intrinsics.v64 vshr_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff3b8*/ Unity.Burst.Intrinsics.v128 vshrq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff3f8*/ Unity.Burst.Intrinsics.v64 vshr_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff438*/ Unity.Burst.Intrinsics.v128 vshrq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff478*/ Unity.Burst.Intrinsics.v64 vshr_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff4b8*/ Unity.Burst.Intrinsics.v128 vshrq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff4f8*/ Unity.Burst.Intrinsics.v64 vshr_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff538*/ Unity.Burst.Intrinsics.v128 vshrq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff578*/ Unity.Burst.Intrinsics.v64 vshr_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff5b8*/ Unity.Burst.Intrinsics.v128 vshrq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff5f8*/ Unity.Burst.Intrinsics.v64 vshr_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff638*/ Unity.Burst.Intrinsics.v128 vshrq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff678*/ Unity.Burst.Intrinsics.v64 vshr_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff6b8*/ Unity.Burst.Intrinsics.v128 vshrq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff6f8*/ Unity.Burst.Intrinsics.v64 vshr_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff738*/ Unity.Burst.Intrinsics.v128 vshrq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff778*/ Unity.Burst.Intrinsics.v64 vshl_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff7b8*/ Unity.Burst.Intrinsics.v128 vshlq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff7f8*/ Unity.Burst.Intrinsics.v64 vshl_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff838*/ Unity.Burst.Intrinsics.v128 vshlq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff878*/ Unity.Burst.Intrinsics.v64 vshl_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff8b8*/ Unity.Burst.Intrinsics.v128 vshlq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff8f8*/ Unity.Burst.Intrinsics.v64 vshl_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff938*/ Unity.Burst.Intrinsics.v128 vshlq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff978*/ Unity.Burst.Intrinsics.v64 vshl_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ff9b8*/ Unity.Burst.Intrinsics.v128 vshlq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ff9f8*/ Unity.Burst.Intrinsics.v64 vshl_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffa38*/ Unity.Burst.Intrinsics.v128 vshlq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffa78*/ Unity.Burst.Intrinsics.v64 vshl_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffab8*/ Unity.Burst.Intrinsics.v128 vshlq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffaf8*/ Unity.Burst.Intrinsics.v64 vshl_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffb38*/ Unity.Burst.Intrinsics.v128 vshlq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffb78*/ Unity.Burst.Intrinsics.v64 vrshr_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffb94*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffbb4*/ Unity.Burst.Intrinsics.v64 vrshr_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffbd0*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffbf0*/ Unity.Burst.Intrinsics.v64 vrshr_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffc0c*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffc2c*/ Unity.Burst.Intrinsics.v64 vrshr_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffc4c*/ Unity.Burst.Intrinsics.v128 vrshrq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffc70*/ Unity.Burst.Intrinsics.v64 vrshr_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffc8c*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffcac*/ Unity.Burst.Intrinsics.v64 vrshr_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffcc8*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffce8*/ Unity.Burst.Intrinsics.v64 vrshr_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffd04*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffd24*/ Unity.Burst.Intrinsics.v64 vrshr_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x24ffd44*/ Unity.Burst.Intrinsics.v128 vrshrq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x24ffd68*/ Unity.Burst.Intrinsics.v64 vsra_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x24ffda8*/ Unity.Burst.Intrinsics.v128 vsraq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x24ffde8*/ Unity.Burst.Intrinsics.v64 vsra_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x24ffe28*/ Unity.Burst.Intrinsics.v128 vsraq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x24ffe68*/ Unity.Burst.Intrinsics.v64 vsra_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x24ffea8*/ Unity.Burst.Intrinsics.v128 vsraq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x24ffee8*/ Unity.Burst.Intrinsics.v64 vsra_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x24fff28*/ Unity.Burst.Intrinsics.v128 vsraq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x24fff68*/ Unity.Burst.Intrinsics.v64 vsra_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x24fffa8*/ Unity.Burst.Intrinsics.v128 vsraq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x24fffe8*/ Unity.Burst.Intrinsics.v64 vsra_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500028*/ Unity.Burst.Intrinsics.v128 vsraq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500068*/ Unity.Burst.Intrinsics.v64 vsra_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25000a8*/ Unity.Burst.Intrinsics.v128 vsraq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25000e8*/ Unity.Burst.Intrinsics.v64 vsra_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500128*/ Unity.Burst.Intrinsics.v128 vsraq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500168*/ Unity.Burst.Intrinsics.v64 vrsra_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500174*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500188*/ Unity.Burst.Intrinsics.v64 vrsra_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500194*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25001a8*/ Unity.Burst.Intrinsics.v64 vrsra_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25001b4*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25001c8*/ Unity.Burst.Intrinsics.v64 vrsra_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25001d4*/ Unity.Burst.Intrinsics.v128 vrsraq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25001e8*/ Unity.Burst.Intrinsics.v64 vrsra_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25001f4*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500208*/ Unity.Burst.Intrinsics.v64 vrsra_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500214*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500228*/ Unity.Burst.Intrinsics.v64 vrsra_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500234*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500248*/ Unity.Burst.Intrinsics.v64 vrsra_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500254*/ Unity.Burst.Intrinsics.v128 vrsraq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500268*/ Unity.Burst.Intrinsics.v64 vqshl_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500280*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25002a0*/ Unity.Burst.Intrinsics.v64 vqshl_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25002b8*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25002d8*/ Unity.Burst.Intrinsics.v64 vqshl_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25002f0*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500310*/ Unity.Burst.Intrinsics.v64 vqshl_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250032c*/ Unity.Burst.Intrinsics.v128 vqshlq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250034c*/ Unity.Burst.Intrinsics.v64 vqshl_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500364*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500384*/ Unity.Burst.Intrinsics.v64 vqshl_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250039c*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25003bc*/ Unity.Burst.Intrinsics.v64 vqshl_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25003d4*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25003f4*/ Unity.Burst.Intrinsics.v64 vqshl_n_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500410*/ Unity.Burst.Intrinsics.v128 vqshlq_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500430*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500470*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25004b0*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25004f0*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500530*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500570*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25005b0*/ Unity.Burst.Intrinsics.v64 vqshlu_n_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25005f0*/ Unity.Burst.Intrinsics.v128 vqshluq_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500630*/ Unity.Burst.Intrinsics.v64 vshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500670*/ Unity.Burst.Intrinsics.v64 vshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25006b0*/ Unity.Burst.Intrinsics.v64 vshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25006f0*/ Unity.Burst.Intrinsics.v64 vshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500730*/ Unity.Burst.Intrinsics.v64 vshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500770*/ Unity.Burst.Intrinsics.v64 vshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25007b0*/ Unity.Burst.Intrinsics.v64 vqshrun_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25007f0*/ Unity.Burst.Intrinsics.v64 vqshrun_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500830*/ Unity.Burst.Intrinsics.v64 vqshrun_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500870*/ Unity.Burst.Intrinsics.v64 vqrshrun_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25008b0*/ Unity.Burst.Intrinsics.v64 vqrshrun_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25008f0*/ Unity.Burst.Intrinsics.v64 vqrshrun_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500930*/ Unity.Burst.Intrinsics.v64 vqshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500970*/ Unity.Burst.Intrinsics.v64 vqshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25009b0*/ Unity.Burst.Intrinsics.v64 vqshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25009f0*/ Unity.Burst.Intrinsics.v64 vqshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500a30*/ Unity.Burst.Intrinsics.v64 vqshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500a70*/ Unity.Burst.Intrinsics.v64 vqshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500ab0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500af0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500b30*/ Unity.Burst.Intrinsics.v64 vrshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500b70*/ Unity.Burst.Intrinsics.v64 vrshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500bb0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500bf0*/ Unity.Burst.Intrinsics.v64 vrshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500c30*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500c70*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500cb0*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500cf0*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500d30*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500d70*/ Unity.Burst.Intrinsics.v64 vqrshrn_n_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2500db0*/ Unity.Burst.Intrinsics.v128 vshll_n_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500df0*/ Unity.Burst.Intrinsics.v128 vshll_n_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500e30*/ Unity.Burst.Intrinsics.v128 vshll_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500e70*/ Unity.Burst.Intrinsics.v128 vshll_n_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500eb0*/ Unity.Burst.Intrinsics.v128 vshll_n_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500ef0*/ Unity.Burst.Intrinsics.v128 vshll_n_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2500f30*/ Unity.Burst.Intrinsics.v64 vsri_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500f70*/ Unity.Burst.Intrinsics.v128 vsriq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2500fb0*/ Unity.Burst.Intrinsics.v64 vsri_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2500ff0*/ Unity.Burst.Intrinsics.v128 vsriq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501030*/ Unity.Burst.Intrinsics.v64 vsri_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501070*/ Unity.Burst.Intrinsics.v128 vsriq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25010b0*/ Unity.Burst.Intrinsics.v64 vsri_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25010f0*/ Unity.Burst.Intrinsics.v128 vsriq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501130*/ Unity.Burst.Intrinsics.v64 vsri_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501170*/ Unity.Burst.Intrinsics.v128 vsriq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25011b0*/ Unity.Burst.Intrinsics.v64 vsri_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25011f0*/ Unity.Burst.Intrinsics.v128 vsriq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501230*/ Unity.Burst.Intrinsics.v64 vsri_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501270*/ Unity.Burst.Intrinsics.v128 vsriq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25012b0*/ Unity.Burst.Intrinsics.v64 vsri_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25012f0*/ Unity.Burst.Intrinsics.v128 vsriq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501330*/ Unity.Burst.Intrinsics.v64 vsli_n_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501370*/ Unity.Burst.Intrinsics.v128 vsliq_n_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25013b0*/ Unity.Burst.Intrinsics.v64 vsli_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25013f0*/ Unity.Burst.Intrinsics.v128 vsliq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501430*/ Unity.Burst.Intrinsics.v64 vsli_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501470*/ Unity.Burst.Intrinsics.v128 vsliq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25014b0*/ Unity.Burst.Intrinsics.v64 vsli_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25014f0*/ Unity.Burst.Intrinsics.v128 vsliq_n_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501530*/ Unity.Burst.Intrinsics.v64 vsli_n_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501570*/ Unity.Burst.Intrinsics.v128 vsliq_n_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25015b0*/ Unity.Burst.Intrinsics.v64 vsli_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25015f0*/ Unity.Burst.Intrinsics.v128 vsliq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501630*/ Unity.Burst.Intrinsics.v64 vsli_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2501670*/ Unity.Burst.Intrinsics.v128 vsliq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25016b0*/ Unity.Burst.Intrinsics.v64 vsli_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25016f0*/ Unity.Burst.Intrinsics.v128 vsliq_n_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2501730*/ Unity.Burst.Intrinsics.v64 vcvt_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501770*/ Unity.Burst.Intrinsics.v128 vcvtq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25017b0*/ Unity.Burst.Intrinsics.v64 vcvt_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25017f0*/ Unity.Burst.Intrinsics.v128 vcvtq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501830*/ Unity.Burst.Intrinsics.v64 vcvt_n_s32_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2501870*/ Unity.Burst.Intrinsics.v128 vcvtq_n_s32_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25018b0*/ Unity.Burst.Intrinsics.v64 vcvt_n_u32_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25018f0*/ Unity.Burst.Intrinsics.v128 vcvtq_n_u32_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2501930*/ Unity.Burst.Intrinsics.v64 vcvt_f32_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501970*/ Unity.Burst.Intrinsics.v128 vcvtq_f32_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25019b0*/ Unity.Burst.Intrinsics.v64 vcvt_f32_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25019f0*/ Unity.Burst.Intrinsics.v128 vcvtq_f32_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501a30*/ Unity.Burst.Intrinsics.v64 vcvt_n_f32_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2501a70*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f32_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2501ab0*/ Unity.Burst.Intrinsics.v64 vcvt_n_f32_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2501af0*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f32_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2501b30*/ Unity.Burst.Intrinsics.v64 vmovn_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501b70*/ Unity.Burst.Intrinsics.v64 vmovn_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501bb0*/ Unity.Burst.Intrinsics.v64 vmovn_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501bf0*/ Unity.Burst.Intrinsics.v64 vmovn_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501bf8*/ Unity.Burst.Intrinsics.v64 vmovn_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501c00*/ Unity.Burst.Intrinsics.v64 vmovn_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501c08*/ Unity.Burst.Intrinsics.v128 vmovn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2501c48*/ Unity.Burst.Intrinsics.v128 vmovn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2501c88*/ Unity.Burst.Intrinsics.v128 vmovn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2501cc8*/ Unity.Burst.Intrinsics.v128 vmovn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2501cd0*/ Unity.Burst.Intrinsics.v128 vmovn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2501cd8*/ Unity.Burst.Intrinsics.v128 vmovn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2501ce0*/ Unity.Burst.Intrinsics.v128 vmovl_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501d20*/ Unity.Burst.Intrinsics.v128 vmovl_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501d60*/ Unity.Burst.Intrinsics.v128 vmovl_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501da0*/ Unity.Burst.Intrinsics.v128 vmovl_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501de0*/ Unity.Burst.Intrinsics.v128 vmovl_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501e20*/ Unity.Burst.Intrinsics.v128 vmovl_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2501e60*/ Unity.Burst.Intrinsics.v64 vqmovn_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501ea0*/ Unity.Burst.Intrinsics.v64 vqmovn_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501ee0*/ Unity.Burst.Intrinsics.v64 vqmovn_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501f20*/ Unity.Burst.Intrinsics.v64 vqmovn_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501f60*/ Unity.Burst.Intrinsics.v64 vqmovn_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501fa0*/ Unity.Burst.Intrinsics.v64 vqmovn_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2501fe0*/ Unity.Burst.Intrinsics.v64 vqmovun_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2502020*/ Unity.Burst.Intrinsics.v64 vqmovun_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2502060*/ Unity.Burst.Intrinsics.v64 vqmovun_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25020a0*/ Unity.Burst.Intrinsics.v64 vmla_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25020e0*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502120*/ Unity.Burst.Intrinsics.v64 vmla_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502160*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25021a0*/ Unity.Burst.Intrinsics.v64 vmla_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25021e0*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502220*/ Unity.Burst.Intrinsics.v64 vmla_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502260*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25022a0*/ Unity.Burst.Intrinsics.v64 vmla_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25022e0*/ Unity.Burst.Intrinsics.v128 vmlaq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502320*/ Unity.Burst.Intrinsics.v128 vmlal_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502360*/ Unity.Burst.Intrinsics.v128 vmlal_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25023a0*/ Unity.Burst.Intrinsics.v128 vmlal_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25023e0*/ Unity.Burst.Intrinsics.v128 vmlal_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502420*/ Unity.Burst.Intrinsics.v128 vqdmlal_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502460*/ Unity.Burst.Intrinsics.v128 vqdmlal_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25024a0*/ Unity.Burst.Intrinsics.v64 vmls_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25024e0*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502520*/ Unity.Burst.Intrinsics.v64 vmls_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502560*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25025a0*/ Unity.Burst.Intrinsics.v64 vmls_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25025e0*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502620*/ Unity.Burst.Intrinsics.v64 vmls_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502660*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25026a0*/ Unity.Burst.Intrinsics.v64 vmls_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25026e0*/ Unity.Burst.Intrinsics.v128 vmlsq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502720*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502760*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25027a0*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25027e0*/ Unity.Burst.Intrinsics.v128 vmlsl_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502820*/ Unity.Burst.Intrinsics.v128 vqdmlsl_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2502860*/ Unity.Burst.Intrinsics.v128 vqdmlsl_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25028a0*/ Unity.Burst.Intrinsics.v64 vmul_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x25028e0*/ Unity.Burst.Intrinsics.v128 vmulq_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x2502920*/ Unity.Burst.Intrinsics.v64 vmul_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2502960*/ Unity.Burst.Intrinsics.v128 vmulq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25029a0*/ Unity.Burst.Intrinsics.v64 vmul_n_u16(Unity.Burst.Intrinsics.v64 a0, ushort a1);
                    static /*0x25029e0*/ Unity.Burst.Intrinsics.v128 vmulq_n_u16(Unity.Burst.Intrinsics.v128 a0, ushort a1);
                    static /*0x2502a20*/ Unity.Burst.Intrinsics.v64 vmul_n_u32(Unity.Burst.Intrinsics.v64 a0, uint a1);
                    static /*0x2502a60*/ Unity.Burst.Intrinsics.v128 vmulq_n_u32(Unity.Burst.Intrinsics.v128 a0, uint a1);
                    static /*0x2502aa0*/ Unity.Burst.Intrinsics.v64 vmul_n_f32(Unity.Burst.Intrinsics.v64 a0, float a1);
                    static /*0x2502ae0*/ Unity.Burst.Intrinsics.v128 vmulq_n_f32(Unity.Burst.Intrinsics.v128 a0, float a1);
                    static /*0x2502b20*/ Unity.Burst.Intrinsics.v64 vmul_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502b60*/ Unity.Burst.Intrinsics.v128 vmulq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502ba0*/ Unity.Burst.Intrinsics.v64 vmul_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502be0*/ Unity.Burst.Intrinsics.v128 vmulq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502c20*/ Unity.Burst.Intrinsics.v64 vmul_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502c60*/ Unity.Burst.Intrinsics.v128 vmulq_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502ca0*/ Unity.Burst.Intrinsics.v64 vmul_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502ce0*/ Unity.Burst.Intrinsics.v128 vmulq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502d20*/ Unity.Burst.Intrinsics.v64 vmul_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502d60*/ Unity.Burst.Intrinsics.v128 vmulq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502da0*/ Unity.Burst.Intrinsics.v128 vmull_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x2502de0*/ Unity.Burst.Intrinsics.v128 vmull_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2502e20*/ Unity.Burst.Intrinsics.v128 vmull_n_u16(Unity.Burst.Intrinsics.v64 a0, ushort a1);
                    static /*0x2502e60*/ Unity.Burst.Intrinsics.v128 vmull_n_u32(Unity.Burst.Intrinsics.v64 a0, uint a1);
                    static /*0x2502ea0*/ Unity.Burst.Intrinsics.v128 vmull_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502ee0*/ Unity.Burst.Intrinsics.v128 vmull_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502f20*/ Unity.Burst.Intrinsics.v128 vmull_lane_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502f60*/ Unity.Burst.Intrinsics.v128 vmull_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2502fa0*/ Unity.Burst.Intrinsics.v128 vqdmull_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x2502fe0*/ Unity.Burst.Intrinsics.v128 vqdmull_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2503020*/ Unity.Burst.Intrinsics.v128 vqdmull_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503060*/ Unity.Burst.Intrinsics.v128 vqdmull_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25030a0*/ Unity.Burst.Intrinsics.v64 vqdmulh_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x25030e0*/ Unity.Burst.Intrinsics.v128 vqdmulhq_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x2503120*/ Unity.Burst.Intrinsics.v64 vqdmulh_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2503160*/ Unity.Burst.Intrinsics.v128 vqdmulhq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25031a0*/ Unity.Burst.Intrinsics.v64 vqdmulh_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25031e0*/ Unity.Burst.Intrinsics.v128 vqdmulhq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503220*/ Unity.Burst.Intrinsics.v64 vqdmulh_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503260*/ Unity.Burst.Intrinsics.v128 vqdmulhq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25032a0*/ Unity.Burst.Intrinsics.v64 vqrdmulh_n_s16(Unity.Burst.Intrinsics.v64 a0, short a1);
                    static /*0x25032e0*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x2503320*/ Unity.Burst.Intrinsics.v64 vqrdmulh_n_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2503360*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25033a0*/ Unity.Burst.Intrinsics.v64 vqrdmulh_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25033e0*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503420*/ Unity.Burst.Intrinsics.v64 vqrdmulh_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503460*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25034a0*/ Unity.Burst.Intrinsics.v64 vmla_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x25034e0*/ Unity.Burst.Intrinsics.v128 vmlaq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x2503520*/ Unity.Burst.Intrinsics.v64 vmla_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503560*/ Unity.Burst.Intrinsics.v128 vmlaq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25035a0*/ Unity.Burst.Intrinsics.v64 vmla_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x25035e0*/ Unity.Burst.Intrinsics.v128 vmlaq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x2503620*/ Unity.Burst.Intrinsics.v64 vmla_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x2503660*/ Unity.Burst.Intrinsics.v128 vmlaq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x25036a0*/ Unity.Burst.Intrinsics.v64 vmla_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x25036e0*/ Unity.Burst.Intrinsics.v128 vmlaq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x2503720*/ Unity.Burst.Intrinsics.v128 vmlal_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x2503760*/ Unity.Burst.Intrinsics.v128 vmlal_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25037a0*/ Unity.Burst.Intrinsics.v128 vmlal_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x25037e0*/ Unity.Burst.Intrinsics.v128 vmlal_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x2503820*/ Unity.Burst.Intrinsics.v128 vqdmlal_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x2503860*/ Unity.Burst.Intrinsics.v128 vqdmlal_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25038a0*/ Unity.Burst.Intrinsics.v64 vmls_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x25038e0*/ Unity.Burst.Intrinsics.v128 vmlsq_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x2503920*/ Unity.Burst.Intrinsics.v64 vmls_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503960*/ Unity.Burst.Intrinsics.v128 vmlsq_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25039a0*/ Unity.Burst.Intrinsics.v64 vmls_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x25039e0*/ Unity.Burst.Intrinsics.v128 vmlsq_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x2503a20*/ Unity.Burst.Intrinsics.v64 vmls_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x2503a60*/ Unity.Burst.Intrinsics.v128 vmlsq_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x2503aa0*/ Unity.Burst.Intrinsics.v64 vmls_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x2503ae0*/ Unity.Burst.Intrinsics.v128 vmlsq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x2503b20*/ Unity.Burst.Intrinsics.v128 vmlsl_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x2503b60*/ Unity.Burst.Intrinsics.v128 vmlsl_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503ba0*/ Unity.Burst.Intrinsics.v128 vmlsl_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, ushort a2);
                    static /*0x2503be0*/ Unity.Burst.Intrinsics.v128 vmlsl_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, uint a2);
                    static /*0x2503c20*/ Unity.Burst.Intrinsics.v128 vqdmlsl_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, short a2);
                    static /*0x2503c60*/ Unity.Burst.Intrinsics.v128 vqdmlsl_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2503ca0*/ Unity.Burst.Intrinsics.v64 vabs_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503ce0*/ Unity.Burst.Intrinsics.v128 vabsq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2503d20*/ Unity.Burst.Intrinsics.v64 vabs_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503d60*/ Unity.Burst.Intrinsics.v128 vabsq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2503da0*/ Unity.Burst.Intrinsics.v64 vabs_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503de0*/ Unity.Burst.Intrinsics.v128 vabsq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2503e20*/ Unity.Burst.Intrinsics.v64 vabs_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503e60*/ Unity.Burst.Intrinsics.v128 vabsq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2503ea0*/ Unity.Burst.Intrinsics.v64 vqabs_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503ee0*/ Unity.Burst.Intrinsics.v128 vqabsq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2503f20*/ Unity.Burst.Intrinsics.v64 vqabs_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503f60*/ Unity.Burst.Intrinsics.v128 vqabsq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2503fa0*/ Unity.Burst.Intrinsics.v64 vqabs_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2503fe0*/ Unity.Burst.Intrinsics.v128 vqabsq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504020*/ Unity.Burst.Intrinsics.v64 vneg_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504060*/ Unity.Burst.Intrinsics.v128 vnegq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25040a0*/ Unity.Burst.Intrinsics.v64 vneg_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25040e0*/ Unity.Burst.Intrinsics.v128 vnegq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504120*/ Unity.Burst.Intrinsics.v64 vneg_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504160*/ Unity.Burst.Intrinsics.v128 vnegq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25041a0*/ Unity.Burst.Intrinsics.v64 vneg_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25041e0*/ Unity.Burst.Intrinsics.v128 vnegq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504220*/ Unity.Burst.Intrinsics.v64 vqneg_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504260*/ Unity.Burst.Intrinsics.v128 vqnegq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25042a0*/ Unity.Burst.Intrinsics.v64 vqneg_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25042e0*/ Unity.Burst.Intrinsics.v128 vqnegq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504320*/ Unity.Burst.Intrinsics.v64 vqneg_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504360*/ Unity.Burst.Intrinsics.v128 vqnegq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25043a0*/ Unity.Burst.Intrinsics.v64 vcls_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25043e0*/ Unity.Burst.Intrinsics.v128 vclsq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504420*/ Unity.Burst.Intrinsics.v64 vcls_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504460*/ Unity.Burst.Intrinsics.v128 vclsq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25044a0*/ Unity.Burst.Intrinsics.v64 vcls_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25044e0*/ Unity.Burst.Intrinsics.v128 vclsq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504520*/ Unity.Burst.Intrinsics.v64 vclz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504560*/ Unity.Burst.Intrinsics.v128 vclzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25045a0*/ Unity.Burst.Intrinsics.v64 vclz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25045e0*/ Unity.Burst.Intrinsics.v128 vclzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504620*/ Unity.Burst.Intrinsics.v64 vclz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504660*/ Unity.Burst.Intrinsics.v128 vclzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25046a0*/ Unity.Burst.Intrinsics.v64 vclz_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25046a8*/ Unity.Burst.Intrinsics.v128 vclzq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25046b0*/ Unity.Burst.Intrinsics.v64 vclz_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25046b8*/ Unity.Burst.Intrinsics.v128 vclzq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25046c0*/ Unity.Burst.Intrinsics.v64 vclz_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25046c8*/ Unity.Burst.Intrinsics.v128 vclzq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25046d0*/ Unity.Burst.Intrinsics.v64 vcnt_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504710*/ Unity.Burst.Intrinsics.v128 vcntq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504750*/ Unity.Burst.Intrinsics.v64 vcnt_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504758*/ Unity.Burst.Intrinsics.v128 vcntq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504760*/ Unity.Burst.Intrinsics.v64 vrecpe_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25047a0*/ Unity.Burst.Intrinsics.v128 vrecpeq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25047e0*/ Unity.Burst.Intrinsics.v64 vrecpe_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504820*/ Unity.Burst.Intrinsics.v128 vrecpeq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504860*/ Unity.Burst.Intrinsics.v64 vrecps_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25048a0*/ Unity.Burst.Intrinsics.v128 vrecpsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25048e0*/ Unity.Burst.Intrinsics.v64 vrsqrte_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504920*/ Unity.Burst.Intrinsics.v128 vrsqrteq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504960*/ Unity.Burst.Intrinsics.v64 vrsqrte_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25049a0*/ Unity.Burst.Intrinsics.v128 vrsqrteq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25049e0*/ Unity.Burst.Intrinsics.v64 vrsqrts_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504a20*/ Unity.Burst.Intrinsics.v128 vrsqrtsq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504a60*/ Unity.Burst.Intrinsics.v64 vmvn_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504aa0*/ Unity.Burst.Intrinsics.v128 vmvnq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504ae0*/ Unity.Burst.Intrinsics.v64 vmvn_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504ae8*/ Unity.Burst.Intrinsics.v128 vmvnq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504af0*/ Unity.Burst.Intrinsics.v64 vmvn_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504af8*/ Unity.Burst.Intrinsics.v128 vmvnq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504b00*/ Unity.Burst.Intrinsics.v64 vmvn_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504b08*/ Unity.Burst.Intrinsics.v128 vmvnq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504b10*/ Unity.Burst.Intrinsics.v64 vmvn_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504b18*/ Unity.Burst.Intrinsics.v128 vmvnq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504b20*/ Unity.Burst.Intrinsics.v64 vmvn_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2504b28*/ Unity.Burst.Intrinsics.v128 vmvnq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2504b30*/ Unity.Burst.Intrinsics.v64 vand_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504b70*/ Unity.Burst.Intrinsics.v128 vandq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504bb0*/ Unity.Burst.Intrinsics.v64 vand_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504bb8*/ Unity.Burst.Intrinsics.v128 vandq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504bc0*/ Unity.Burst.Intrinsics.v64 vand_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504bc8*/ Unity.Burst.Intrinsics.v128 vandq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504bd0*/ Unity.Burst.Intrinsics.v64 vand_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504bd8*/ Unity.Burst.Intrinsics.v128 vandq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504be0*/ Unity.Burst.Intrinsics.v64 vand_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504be8*/ Unity.Burst.Intrinsics.v128 vandq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504bf0*/ Unity.Burst.Intrinsics.v64 vand_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504bf8*/ Unity.Burst.Intrinsics.v128 vandq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504c00*/ Unity.Burst.Intrinsics.v64 vand_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504c08*/ Unity.Burst.Intrinsics.v128 vandq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504c10*/ Unity.Burst.Intrinsics.v64 vand_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504c18*/ Unity.Burst.Intrinsics.v128 vandq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504c20*/ Unity.Burst.Intrinsics.v64 vorr_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504c60*/ Unity.Burst.Intrinsics.v128 vorrq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ca0*/ Unity.Burst.Intrinsics.v64 vorr_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504ca8*/ Unity.Burst.Intrinsics.v128 vorrq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504cb0*/ Unity.Burst.Intrinsics.v64 vorr_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504cb8*/ Unity.Burst.Intrinsics.v128 vorrq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504cc0*/ Unity.Burst.Intrinsics.v64 vorr_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504cc8*/ Unity.Burst.Intrinsics.v128 vorrq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504cd0*/ Unity.Burst.Intrinsics.v64 vorr_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504cd8*/ Unity.Burst.Intrinsics.v128 vorrq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ce0*/ Unity.Burst.Intrinsics.v64 vorr_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504ce8*/ Unity.Burst.Intrinsics.v128 vorrq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504cf0*/ Unity.Burst.Intrinsics.v64 vorr_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504cf8*/ Unity.Burst.Intrinsics.v128 vorrq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504d00*/ Unity.Burst.Intrinsics.v64 vorr_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504d08*/ Unity.Burst.Intrinsics.v128 vorrq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504d10*/ Unity.Burst.Intrinsics.v64 veor_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504d50*/ Unity.Burst.Intrinsics.v128 veorq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504d90*/ Unity.Burst.Intrinsics.v64 veor_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504d98*/ Unity.Burst.Intrinsics.v128 veorq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504da0*/ Unity.Burst.Intrinsics.v64 veor_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504da8*/ Unity.Burst.Intrinsics.v128 veorq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504db0*/ Unity.Burst.Intrinsics.v64 veor_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504db8*/ Unity.Burst.Intrinsics.v128 veorq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504dc0*/ Unity.Burst.Intrinsics.v64 veor_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504dc8*/ Unity.Burst.Intrinsics.v128 veorq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504dd0*/ Unity.Burst.Intrinsics.v64 veor_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504dd8*/ Unity.Burst.Intrinsics.v128 veorq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504de0*/ Unity.Burst.Intrinsics.v64 veor_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504de8*/ Unity.Burst.Intrinsics.v128 veorq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504df0*/ Unity.Burst.Intrinsics.v64 veor_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504df8*/ Unity.Burst.Intrinsics.v128 veorq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504e00*/ Unity.Burst.Intrinsics.v64 vbic_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504e40*/ Unity.Burst.Intrinsics.v128 vbicq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504e80*/ Unity.Burst.Intrinsics.v64 vbic_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504e88*/ Unity.Burst.Intrinsics.v128 vbicq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504e90*/ Unity.Burst.Intrinsics.v64 vbic_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504e98*/ Unity.Burst.Intrinsics.v128 vbicq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ea0*/ Unity.Burst.Intrinsics.v64 vbic_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504ea8*/ Unity.Burst.Intrinsics.v128 vbicq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504eb0*/ Unity.Burst.Intrinsics.v64 vbic_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504eb8*/ Unity.Burst.Intrinsics.v128 vbicq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ec0*/ Unity.Burst.Intrinsics.v64 vbic_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504ec8*/ Unity.Burst.Intrinsics.v128 vbicq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ed0*/ Unity.Burst.Intrinsics.v64 vbic_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504ed8*/ Unity.Burst.Intrinsics.v128 vbicq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ee0*/ Unity.Burst.Intrinsics.v64 vbic_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504ee8*/ Unity.Burst.Intrinsics.v128 vbicq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504ef0*/ Unity.Burst.Intrinsics.v64 vorn_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504f30*/ Unity.Burst.Intrinsics.v128 vornq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504f70*/ Unity.Burst.Intrinsics.v64 vorn_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504f78*/ Unity.Burst.Intrinsics.v128 vornq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504f80*/ Unity.Burst.Intrinsics.v64 vorn_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504f88*/ Unity.Burst.Intrinsics.v128 vornq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504f90*/ Unity.Burst.Intrinsics.v64 vorn_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504f98*/ Unity.Burst.Intrinsics.v128 vornq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504fa0*/ Unity.Burst.Intrinsics.v64 vorn_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504fa8*/ Unity.Burst.Intrinsics.v128 vornq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504fb0*/ Unity.Burst.Intrinsics.v64 vorn_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504fb8*/ Unity.Burst.Intrinsics.v128 vornq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504fc0*/ Unity.Burst.Intrinsics.v64 vorn_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504fc8*/ Unity.Burst.Intrinsics.v128 vornq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504fd0*/ Unity.Burst.Intrinsics.v64 vorn_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2504fd8*/ Unity.Burst.Intrinsics.v128 vornq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2504fe0*/ Unity.Burst.Intrinsics.v64 vbsl_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2505020*/ Unity.Burst.Intrinsics.v128 vbslq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2505060*/ Unity.Burst.Intrinsics.v64 vbsl_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2505068*/ Unity.Burst.Intrinsics.v128 vbslq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2505070*/ Unity.Burst.Intrinsics.v64 vbsl_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2505078*/ Unity.Burst.Intrinsics.v128 vbslq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2505080*/ Unity.Burst.Intrinsics.v64 vbsl_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2505088*/ Unity.Burst.Intrinsics.v128 vbslq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2505090*/ Unity.Burst.Intrinsics.v64 vbsl_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2505098*/ Unity.Burst.Intrinsics.v128 vbslq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25050a0*/ Unity.Burst.Intrinsics.v64 vbsl_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25050a8*/ Unity.Burst.Intrinsics.v128 vbslq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25050b0*/ Unity.Burst.Intrinsics.v64 vbsl_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25050b8*/ Unity.Burst.Intrinsics.v128 vbslq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25050c0*/ Unity.Burst.Intrinsics.v64 vbsl_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25050c8*/ Unity.Burst.Intrinsics.v128 vbslq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25050d0*/ Unity.Burst.Intrinsics.v64 vbsl_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25050d8*/ Unity.Burst.Intrinsics.v128 vbslq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25050e0*/ Unity.Burst.Intrinsics.v64 vdup_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505120*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505160*/ Unity.Burst.Intrinsics.v64 vdup_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25051a0*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25051e0*/ Unity.Burst.Intrinsics.v64 vdup_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505220*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505260*/ Unity.Burst.Intrinsics.v64 vdup_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505264*/ Unity.Burst.Intrinsics.v128 vdupq_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25052b4*/ Unity.Burst.Intrinsics.v64 vdup_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25052f4*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505334*/ Unity.Burst.Intrinsics.v64 vdup_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505374*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25053b4*/ Unity.Burst.Intrinsics.v64 vdup_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25053f4*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505434*/ Unity.Burst.Intrinsics.v64 vdup_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505438*/ Unity.Burst.Intrinsics.v128 vdupq_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505488*/ Unity.Burst.Intrinsics.v64 vdup_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25054c8*/ Unity.Burst.Intrinsics.v128 vdupq_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2505508*/ Unity.Burst.Intrinsics.v64 vpadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505548*/ Unity.Burst.Intrinsics.v64 vpadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505588*/ Unity.Burst.Intrinsics.v64 vpadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25055c8*/ Unity.Burst.Intrinsics.v64 vpadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25055d0*/ Unity.Burst.Intrinsics.v64 vpadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25055d8*/ Unity.Burst.Intrinsics.v64 vpadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25055e0*/ Unity.Burst.Intrinsics.v64 vpadd_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505620*/ Unity.Burst.Intrinsics.v64 vpaddl_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2505660*/ Unity.Burst.Intrinsics.v128 vpaddlq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25056a0*/ Unity.Burst.Intrinsics.v64 vpaddl_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25056e0*/ Unity.Burst.Intrinsics.v128 vpaddlq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2505720*/ Unity.Burst.Intrinsics.v64 vpaddl_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2505760*/ Unity.Burst.Intrinsics.v128 vpaddlq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25057a0*/ Unity.Burst.Intrinsics.v64 vpaddl_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25057e0*/ Unity.Burst.Intrinsics.v128 vpaddlq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2505820*/ Unity.Burst.Intrinsics.v64 vpaddl_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2505860*/ Unity.Burst.Intrinsics.v128 vpaddlq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25058a0*/ Unity.Burst.Intrinsics.v64 vpaddl_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25058e0*/ Unity.Burst.Intrinsics.v128 vpaddlq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2505920*/ Unity.Burst.Intrinsics.v64 vpadal_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505960*/ Unity.Burst.Intrinsics.v128 vpadalq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25059a0*/ Unity.Burst.Intrinsics.v64 vpadal_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25059e0*/ Unity.Burst.Intrinsics.v128 vpadalq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2505a20*/ Unity.Burst.Intrinsics.v64 vpadal_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505a60*/ Unity.Burst.Intrinsics.v128 vpadalq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2505aa0*/ Unity.Burst.Intrinsics.v64 vpadal_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505ae0*/ Unity.Burst.Intrinsics.v128 vpadalq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2505b20*/ Unity.Burst.Intrinsics.v64 vpadal_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505b60*/ Unity.Burst.Intrinsics.v128 vpadalq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2505ba0*/ Unity.Burst.Intrinsics.v64 vpadal_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505be0*/ Unity.Burst.Intrinsics.v128 vpadalq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2505c20*/ Unity.Burst.Intrinsics.v64 vpmax_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505c60*/ Unity.Burst.Intrinsics.v64 vpmax_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505ca0*/ Unity.Burst.Intrinsics.v64 vpmax_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505ce0*/ Unity.Burst.Intrinsics.v64 vpmax_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505d20*/ Unity.Burst.Intrinsics.v64 vpmax_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505d60*/ Unity.Burst.Intrinsics.v64 vpmax_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505da0*/ Unity.Burst.Intrinsics.v64 vpmax_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505de0*/ Unity.Burst.Intrinsics.v64 vpmin_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505e20*/ Unity.Burst.Intrinsics.v64 vpmin_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505e60*/ Unity.Burst.Intrinsics.v64 vpmin_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505ea0*/ Unity.Burst.Intrinsics.v64 vpmin_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505ee0*/ Unity.Burst.Intrinsics.v64 vpmin_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505f20*/ Unity.Burst.Intrinsics.v64 vpmin_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505f60*/ Unity.Burst.Intrinsics.v64 vpmin_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2505fa0*/ Unity.Burst.Intrinsics.v64 vext_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2505fe0*/ Unity.Burst.Intrinsics.v128 vextq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506020*/ Unity.Burst.Intrinsics.v64 vext_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506060*/ Unity.Burst.Intrinsics.v128 vextq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25060a0*/ Unity.Burst.Intrinsics.v64 vext_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25060e0*/ Unity.Burst.Intrinsics.v128 vextq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506120*/ Unity.Burst.Intrinsics.v64 vext_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506124*/ Unity.Burst.Intrinsics.v128 vextq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506164*/ Unity.Burst.Intrinsics.v64 vext_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25061a4*/ Unity.Burst.Intrinsics.v128 vextq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25061e4*/ Unity.Burst.Intrinsics.v64 vext_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506224*/ Unity.Burst.Intrinsics.v128 vextq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506264*/ Unity.Burst.Intrinsics.v64 vext_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25062a4*/ Unity.Burst.Intrinsics.v128 vextq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25062e4*/ Unity.Burst.Intrinsics.v64 vext_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25062e8*/ Unity.Burst.Intrinsics.v128 vextq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506328*/ Unity.Burst.Intrinsics.v64 vext_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506368*/ Unity.Burst.Intrinsics.v128 vextq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25063a8*/ Unity.Burst.Intrinsics.v64 vrev64_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25063e8*/ Unity.Burst.Intrinsics.v128 vrev64q_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506428*/ Unity.Burst.Intrinsics.v64 vrev64_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506468*/ Unity.Burst.Intrinsics.v128 vrev64q_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25064a8*/ Unity.Burst.Intrinsics.v64 vrev64_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25064e8*/ Unity.Burst.Intrinsics.v128 vrev64q_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506528*/ Unity.Burst.Intrinsics.v64 vrev64_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506530*/ Unity.Burst.Intrinsics.v128 vrev64q_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506538*/ Unity.Burst.Intrinsics.v64 vrev64_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506540*/ Unity.Burst.Intrinsics.v128 vrev64q_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506548*/ Unity.Burst.Intrinsics.v64 vrev64_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506550*/ Unity.Burst.Intrinsics.v128 vrev64q_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506558*/ Unity.Burst.Intrinsics.v64 vrev64_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506560*/ Unity.Burst.Intrinsics.v128 vrev64q_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506568*/ Unity.Burst.Intrinsics.v64 vrev32_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25065a8*/ Unity.Burst.Intrinsics.v128 vrev32q_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25065e8*/ Unity.Burst.Intrinsics.v64 vrev32_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506628*/ Unity.Burst.Intrinsics.v128 vrev32q_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506668*/ Unity.Burst.Intrinsics.v64 vrev32_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506670*/ Unity.Burst.Intrinsics.v128 vrev32q_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506678*/ Unity.Burst.Intrinsics.v64 vrev32_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506680*/ Unity.Burst.Intrinsics.v128 vrev32q_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506688*/ Unity.Burst.Intrinsics.v64 vrev16_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25066c8*/ Unity.Burst.Intrinsics.v128 vrev16q_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506708*/ Unity.Burst.Intrinsics.v64 vrev16_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2506710*/ Unity.Burst.Intrinsics.v128 vrev16q_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2506718*/ Unity.Burst.Intrinsics.v64 vtbl1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2506758*/ Unity.Burst.Intrinsics.v64 vtbl1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2506760*/ Unity.Burst.Intrinsics.v64 vtbx1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25067a0*/ Unity.Burst.Intrinsics.v64 vtbx1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25067a8*/ byte vget_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25067e8*/ ushort vget_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2506828*/ uint vget_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2506868*/ ulong vget_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250686c*/ sbyte vget_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25068ac*/ short vget_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25068ec*/ int vget_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250692c*/ long vget_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2506930*/ float vget_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2506970*/ byte vgetq_lane_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25069b0*/ ushort vgetq_lane_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25069f0*/ uint vgetq_lane_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506a30*/ ulong vgetq_lane_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506a70*/ sbyte vgetq_lane_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506ab0*/ short vgetq_lane_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506af0*/ int vgetq_lane_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506b30*/ long vgetq_lane_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506b70*/ float vgetq_lane_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2506bb0*/ Unity.Burst.Intrinsics.v64 vset_lane_u8(byte a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506bf0*/ Unity.Burst.Intrinsics.v64 vset_lane_u16(ushort a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506c30*/ Unity.Burst.Intrinsics.v64 vset_lane_u32(uint a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506c70*/ Unity.Burst.Intrinsics.v64 vset_lane_u64(ulong a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506c94*/ Unity.Burst.Intrinsics.v64 vset_lane_s8(sbyte a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506cd4*/ Unity.Burst.Intrinsics.v64 vset_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506d14*/ Unity.Burst.Intrinsics.v64 vset_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506d54*/ Unity.Burst.Intrinsics.v64 vset_lane_s64(long a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506d78*/ Unity.Burst.Intrinsics.v64 vset_lane_f32(float a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2506db8*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u8(byte a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506df8*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u16(ushort a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506e38*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u32(uint a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506e78*/ Unity.Burst.Intrinsics.v128 vsetq_lane_u64(ulong a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506eb8*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s8(sbyte a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506ef8*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506f38*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506f78*/ Unity.Burst.Intrinsics.v128 vsetq_lane_s64(long a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506fb8*/ Unity.Burst.Intrinsics.v128 vsetq_lane_f32(float a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2506ff8*/ Unity.Burst.Intrinsics.v64 vfma_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x2507038*/ Unity.Burst.Intrinsics.v128 vfmaq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x2507078*/ bool get_IsNeonArmv82FeaturesSupported();
                    static /*0x2507080*/ Unity.Burst.Intrinsics.v64 vadd_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25070c0*/ Unity.Burst.Intrinsics.v128 vaddq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507100*/ long vaddd_s64(long a0, long a1);
                    static /*0x2507140*/ ulong vaddd_u64(ulong a0, ulong a1);
                    static /*0x2507180*/ Unity.Burst.Intrinsics.v128 vaddl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25071c0*/ Unity.Burst.Intrinsics.v128 vaddl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507200*/ Unity.Burst.Intrinsics.v128 vaddl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507240*/ Unity.Burst.Intrinsics.v128 vaddl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507280*/ Unity.Burst.Intrinsics.v128 vaddl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25072c0*/ Unity.Burst.Intrinsics.v128 vaddl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507300*/ Unity.Burst.Intrinsics.v128 vaddw_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507340*/ Unity.Burst.Intrinsics.v128 vaddw_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507380*/ Unity.Burst.Intrinsics.v128 vaddw_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25073c0*/ Unity.Burst.Intrinsics.v128 vaddw_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507400*/ Unity.Burst.Intrinsics.v128 vaddw_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507440*/ Unity.Burst.Intrinsics.v128 vaddw_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507480*/ sbyte vqaddb_s8(sbyte a0, sbyte a1);
                    static /*0x25074c0*/ short vqaddh_s16(short a0, short a1);
                    static /*0x2507500*/ int vqadds_s32(int a0, int a1);
                    static /*0x2507540*/ long vqaddd_s64(long a0, long a1);
                    static /*0x2507580*/ byte vqaddb_u8(byte a0, byte a1);
                    static /*0x25075c0*/ ushort vqaddh_u16(ushort a0, ushort a1);
                    static /*0x2507600*/ uint vqadds_u32(uint a0, uint a1);
                    static /*0x2507640*/ ulong vqaddd_u64(ulong a0, ulong a1);
                    static /*0x2507680*/ Unity.Burst.Intrinsics.v64 vuqadd_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25076c0*/ Unity.Burst.Intrinsics.v128 vuqaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507700*/ Unity.Burst.Intrinsics.v64 vuqadd_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507740*/ Unity.Burst.Intrinsics.v128 vuqaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507780*/ Unity.Burst.Intrinsics.v64 vuqadd_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25077c0*/ Unity.Burst.Intrinsics.v128 vuqaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507800*/ Unity.Burst.Intrinsics.v64 vuqadd_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507840*/ Unity.Burst.Intrinsics.v128 vuqaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507880*/ sbyte vuqaddb_s8(sbyte a0, byte a1);
                    static /*0x25078c0*/ short vuqaddh_s16(short a0, ushort a1);
                    static /*0x2507900*/ int vuqadds_s32(int a0, uint a1);
                    static /*0x2507940*/ long vuqaddd_s64(long a0, ulong a1);
                    static /*0x2507980*/ Unity.Burst.Intrinsics.v64 vsqadd_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25079c0*/ Unity.Burst.Intrinsics.v128 vsqaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507a00*/ Unity.Burst.Intrinsics.v64 vsqadd_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507a40*/ Unity.Burst.Intrinsics.v128 vsqaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507a80*/ Unity.Burst.Intrinsics.v64 vsqadd_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507ac0*/ Unity.Burst.Intrinsics.v128 vsqaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507b00*/ Unity.Burst.Intrinsics.v64 vsqadd_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507b40*/ Unity.Burst.Intrinsics.v128 vsqaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507b80*/ byte vsqaddb_u8(byte a0, sbyte a1);
                    static /*0x2507bc0*/ ushort vsqaddh_u16(ushort a0, short a1);
                    static /*0x2507c00*/ uint vsqadds_u32(uint a0, int a1);
                    static /*0x2507c40*/ ulong vsqaddd_u64(ulong a0, long a1);
                    static /*0x2507c80*/ Unity.Burst.Intrinsics.v128 vaddhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507cc0*/ Unity.Burst.Intrinsics.v128 vaddhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507d00*/ Unity.Burst.Intrinsics.v128 vaddhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507d40*/ Unity.Burst.Intrinsics.v128 vaddhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507d48*/ Unity.Burst.Intrinsics.v128 vaddhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507d50*/ Unity.Burst.Intrinsics.v128 vaddhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507d58*/ Unity.Burst.Intrinsics.v128 vraddhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507d98*/ Unity.Burst.Intrinsics.v128 vraddhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507dd8*/ Unity.Burst.Intrinsics.v128 vraddhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507e18*/ Unity.Burst.Intrinsics.v128 vraddhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507e20*/ Unity.Burst.Intrinsics.v128 vraddhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507e28*/ Unity.Burst.Intrinsics.v128 vraddhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2507e30*/ Unity.Burst.Intrinsics.v64 vmul_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507e70*/ Unity.Burst.Intrinsics.v128 vmulq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507eb0*/ Unity.Burst.Intrinsics.v64 vmulx_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507ef0*/ Unity.Burst.Intrinsics.v128 vmulxq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507f30*/ Unity.Burst.Intrinsics.v64 vmulx_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2507f70*/ Unity.Burst.Intrinsics.v128 vmulxq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2507fb0*/ float vmulxs_f32(float a0, float a1);
                    static /*0x2507ff0*/ double vmulxd_f64(double a0, double a1);
                    static /*0x2508030*/ Unity.Burst.Intrinsics.v64 vmulx_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2508070*/ Unity.Burst.Intrinsics.v128 vmulxq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25080b0*/ Unity.Burst.Intrinsics.v64 vmulx_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25080b8*/ Unity.Burst.Intrinsics.v128 vmulxq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25080f8*/ float vmulxs_lane_f32(float a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2508138*/ double vmulxd_lane_f64(double a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2508140*/ Unity.Burst.Intrinsics.v64 vmulx_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2508180*/ Unity.Burst.Intrinsics.v128 vmulxq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25081c0*/ Unity.Burst.Intrinsics.v64 vmulx_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2508200*/ Unity.Burst.Intrinsics.v128 vmulxq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2508240*/ float vmulxs_laneq_f32(float a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2508280*/ double vmulxd_laneq_f64(double a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25082c0*/ Unity.Burst.Intrinsics.v64 vdiv_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2508300*/ Unity.Burst.Intrinsics.v128 vdivq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2508340*/ Unity.Burst.Intrinsics.v64 vdiv_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2508380*/ Unity.Burst.Intrinsics.v128 vdivq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25083c0*/ Unity.Burst.Intrinsics.v64 vmla_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2508400*/ Unity.Burst.Intrinsics.v128 vmlaq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508440*/ Unity.Burst.Intrinsics.v128 vmlal_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508480*/ Unity.Burst.Intrinsics.v128 vmlal_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25084c0*/ Unity.Burst.Intrinsics.v128 vmlal_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508500*/ Unity.Burst.Intrinsics.v128 vmlal_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508540*/ Unity.Burst.Intrinsics.v128 vmlal_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508580*/ Unity.Burst.Intrinsics.v128 vmlal_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25085c0*/ Unity.Burst.Intrinsics.v64 vmls_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2508600*/ Unity.Burst.Intrinsics.v128 vmlsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508640*/ Unity.Burst.Intrinsics.v128 vmlsl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508680*/ Unity.Burst.Intrinsics.v128 vmlsl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25086c0*/ Unity.Burst.Intrinsics.v128 vmlsl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508700*/ Unity.Burst.Intrinsics.v128 vmlsl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508740*/ Unity.Burst.Intrinsics.v128 vmlsl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508780*/ Unity.Burst.Intrinsics.v128 vmlsl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x25087c0*/ Unity.Burst.Intrinsics.v64 vfma_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2508800*/ Unity.Burst.Intrinsics.v128 vfmaq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508840*/ Unity.Burst.Intrinsics.v64 vfma_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508880*/ Unity.Burst.Intrinsics.v128 vfmaq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25088c0*/ Unity.Burst.Intrinsics.v64 vfma_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25088c8*/ Unity.Burst.Intrinsics.v128 vfmaq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508908*/ float vfmas_lane_f32(float a0, float a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508948*/ double vfmad_lane_f64(double a0, double a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508980*/ Unity.Burst.Intrinsics.v64 vfma_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25089c0*/ Unity.Burst.Intrinsics.v128 vfmaq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508a00*/ Unity.Burst.Intrinsics.v64 vfma_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508a40*/ Unity.Burst.Intrinsics.v128 vfmaq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508a80*/ float vfmas_laneq_f32(float a0, float a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508ac0*/ double vfmad_laneq_f64(double a0, double a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508b00*/ Unity.Burst.Intrinsics.v64 vfms_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2508b40*/ Unity.Burst.Intrinsics.v128 vfmsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2508b80*/ Unity.Burst.Intrinsics.v64 vfms_lane_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508bc0*/ Unity.Burst.Intrinsics.v128 vfmsq_lane_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508c00*/ Unity.Burst.Intrinsics.v64 vfms_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508c08*/ Unity.Burst.Intrinsics.v128 vfmsq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508c48*/ float vfmss_lane_f32(float a0, float a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508c88*/ double vfmsd_lane_f64(double a0, double a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2508cc0*/ Unity.Burst.Intrinsics.v64 vfms_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508d00*/ Unity.Burst.Intrinsics.v128 vfmsq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508d40*/ Unity.Burst.Intrinsics.v64 vfms_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508d80*/ Unity.Burst.Intrinsics.v128 vfmsq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508dc0*/ float vfmss_laneq_f32(float a0, float a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508e00*/ double vfmsd_laneq_f64(double a0, double a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2508e40*/ short vqdmulhh_s16(short a0, short a1);
                    static /*0x2508e80*/ int vqdmulhs_s32(int a0, int a1);
                    static /*0x2508ec0*/ short vqrdmulhh_s16(short a0, short a1);
                    static /*0x2508f00*/ int vqrdmulhs_s32(int a0, int a1);
                    static /*0x2508f40*/ int vqdmlalh_s16(int a0, short a1, short a2);
                    static /*0x2508f80*/ long vqdmlals_s32(long a0, int a1, int a2);
                    static /*0x2508fc0*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509000*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509040*/ int vqdmlslh_s16(int a0, short a1, short a2);
                    static /*0x2509080*/ long vqdmlsls_s32(long a0, int a1, int a2);
                    static /*0x25090c0*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509100*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509140*/ Unity.Burst.Intrinsics.v128 vmull_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509180*/ Unity.Burst.Intrinsics.v128 vmull_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25091c0*/ Unity.Burst.Intrinsics.v128 vmull_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509200*/ Unity.Burst.Intrinsics.v128 vmull_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509240*/ Unity.Burst.Intrinsics.v128 vmull_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509280*/ Unity.Burst.Intrinsics.v128 vmull_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25092c0*/ int vqdmullh_s16(short a0, short a1);
                    static /*0x2509300*/ long vqdmulls_s32(int a0, int a1);
                    static /*0x2509340*/ Unity.Burst.Intrinsics.v128 vqdmull_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509380*/ Unity.Burst.Intrinsics.v128 vqdmull_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25093c0*/ Unity.Burst.Intrinsics.v64 vsub_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2509400*/ Unity.Burst.Intrinsics.v128 vsubq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509440*/ long vsubd_s64(long a0, long a1);
                    static /*0x2509480*/ ulong vsubd_u64(ulong a0, ulong a1);
                    static /*0x25094c0*/ Unity.Burst.Intrinsics.v128 vsubl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509500*/ Unity.Burst.Intrinsics.v128 vsubl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509540*/ Unity.Burst.Intrinsics.v128 vsubl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509580*/ Unity.Burst.Intrinsics.v128 vsubl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25095c0*/ Unity.Burst.Intrinsics.v128 vsubl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509600*/ Unity.Burst.Intrinsics.v128 vsubl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509640*/ Unity.Burst.Intrinsics.v128 vsubw_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509680*/ Unity.Burst.Intrinsics.v128 vsubw_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25096c0*/ Unity.Burst.Intrinsics.v128 vsubw_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509700*/ Unity.Burst.Intrinsics.v128 vsubw_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509740*/ Unity.Burst.Intrinsics.v128 vsubw_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509780*/ Unity.Burst.Intrinsics.v128 vsubw_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25097c0*/ sbyte vqsubb_s8(sbyte a0, sbyte a1);
                    static /*0x2509800*/ short vqsubh_s16(short a0, short a1);
                    static /*0x2509840*/ int vqsubs_s32(int a0, int a1);
                    static /*0x2509880*/ long vqsubd_s64(long a0, long a1);
                    static /*0x25098c0*/ byte vqsubb_u8(byte a0, byte a1);
                    static /*0x2509900*/ ushort vqsubh_u16(ushort a0, ushort a1);
                    static /*0x2509940*/ uint vqsubs_u32(uint a0, uint a1);
                    static /*0x2509980*/ ulong vqsubd_u64(ulong a0, ulong a1);
                    static /*0x25099c0*/ Unity.Burst.Intrinsics.v128 vsubhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509a00*/ Unity.Burst.Intrinsics.v128 vsubhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509a40*/ Unity.Burst.Intrinsics.v128 vsubhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509a80*/ Unity.Burst.Intrinsics.v128 vsubhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509a88*/ Unity.Burst.Intrinsics.v128 vsubhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509a90*/ Unity.Burst.Intrinsics.v128 vsubhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509a98*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509ad8*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509b18*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509b58*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509b60*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509b68*/ Unity.Burst.Intrinsics.v128 vrsubhn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2509b70*/ Unity.Burst.Intrinsics.v64 vceq_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2509bb0*/ Unity.Burst.Intrinsics.v128 vceqq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509bf0*/ Unity.Burst.Intrinsics.v64 vceq_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2509bf8*/ Unity.Burst.Intrinsics.v128 vceqq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509c00*/ Unity.Burst.Intrinsics.v64 vceq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2509c40*/ Unity.Burst.Intrinsics.v128 vceqq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2509c80*/ ulong vceqd_s64(long a0, long a1);
                    static /*0x2509cc0*/ ulong vceqd_u64(ulong a0, ulong a1);
                    static /*0x2509d00*/ uint vceqs_f32(float a0, float a1);
                    static /*0x2509d40*/ ulong vceqd_f64(double a0, double a1);
                    static /*0x2509d80*/ Unity.Burst.Intrinsics.v64 vceqz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509dc0*/ Unity.Burst.Intrinsics.v128 vceqzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509e00*/ Unity.Burst.Intrinsics.v64 vceqz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509e40*/ Unity.Burst.Intrinsics.v128 vceqzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509e80*/ Unity.Burst.Intrinsics.v64 vceqz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509ec0*/ Unity.Burst.Intrinsics.v128 vceqzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509f00*/ Unity.Burst.Intrinsics.v64 vceqz_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509f08*/ Unity.Burst.Intrinsics.v128 vceqzq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509f10*/ Unity.Burst.Intrinsics.v64 vceqz_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509f18*/ Unity.Burst.Intrinsics.v128 vceqzq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509f20*/ Unity.Burst.Intrinsics.v64 vceqz_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509f28*/ Unity.Burst.Intrinsics.v128 vceqzq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509f30*/ Unity.Burst.Intrinsics.v64 vceqz_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509f70*/ Unity.Burst.Intrinsics.v128 vceqzq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2509fb0*/ Unity.Burst.Intrinsics.v64 vceqz_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2509ff0*/ Unity.Burst.Intrinsics.v128 vceqzq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a030*/ Unity.Burst.Intrinsics.v64 vceqz_u64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a038*/ Unity.Burst.Intrinsics.v128 vceqzq_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a040*/ Unity.Burst.Intrinsics.v64 vceqz_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a080*/ Unity.Burst.Intrinsics.v128 vceqzq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a0c0*/ ulong vceqzd_s64(long a0);
                    static /*0x250a100*/ ulong vceqzd_u64(ulong a0);
                    static /*0x250a140*/ uint vceqzs_f32(float a0);
                    static /*0x250a180*/ ulong vceqzd_f64(double a0);
                    static /*0x250a1c0*/ Unity.Burst.Intrinsics.v64 vcge_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250a200*/ Unity.Burst.Intrinsics.v128 vcgeq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250a240*/ Unity.Burst.Intrinsics.v64 vcge_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250a280*/ Unity.Burst.Intrinsics.v128 vcgeq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250a2c0*/ Unity.Burst.Intrinsics.v64 vcge_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250a300*/ Unity.Burst.Intrinsics.v128 vcgeq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250a340*/ ulong vcged_s64(long a0, long a1);
                    static /*0x250a380*/ ulong vcged_u64(ulong a0, ulong a1);
                    static /*0x250a3c0*/ uint vcges_f32(float a0, float a1);
                    static /*0x250a400*/ ulong vcged_f64(double a0, double a1);
                    static /*0x250a440*/ Unity.Burst.Intrinsics.v64 vcgez_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a480*/ Unity.Burst.Intrinsics.v128 vcgezq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a4c0*/ Unity.Burst.Intrinsics.v64 vcgez_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a500*/ Unity.Burst.Intrinsics.v128 vcgezq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a540*/ Unity.Burst.Intrinsics.v64 vcgez_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a580*/ Unity.Burst.Intrinsics.v128 vcgezq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a5c0*/ Unity.Burst.Intrinsics.v64 vcgez_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a600*/ Unity.Burst.Intrinsics.v128 vcgezq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a640*/ Unity.Burst.Intrinsics.v64 vcgez_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a680*/ Unity.Burst.Intrinsics.v128 vcgezq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a6c0*/ Unity.Burst.Intrinsics.v64 vcgez_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250a700*/ Unity.Burst.Intrinsics.v128 vcgezq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250a740*/ ulong vcgezd_s64(long a0);
                    static /*0x250a780*/ uint vcgezs_f32(float a0);
                    static /*0x250a7c0*/ ulong vcgezd_f64(double a0);
                    static /*0x250a800*/ Unity.Burst.Intrinsics.v64 vcle_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250a840*/ Unity.Burst.Intrinsics.v128 vcleq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250a880*/ Unity.Burst.Intrinsics.v64 vcle_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250a8c0*/ Unity.Burst.Intrinsics.v128 vcleq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250a900*/ Unity.Burst.Intrinsics.v64 vcle_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250a940*/ Unity.Burst.Intrinsics.v128 vcleq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250a980*/ ulong vcled_s64(long a0, long a1);
                    static /*0x250a9c0*/ ulong vcled_u64(ulong a0, ulong a1);
                    static /*0x250aa00*/ uint vcles_f32(float a0, float a1);
                    static /*0x250aa40*/ ulong vcled_f64(double a0, double a1);
                    static /*0x250aa80*/ Unity.Burst.Intrinsics.v64 vclez_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250aac0*/ Unity.Burst.Intrinsics.v128 vclezq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ab00*/ Unity.Burst.Intrinsics.v64 vclez_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250ab40*/ Unity.Burst.Intrinsics.v128 vclezq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ab80*/ Unity.Burst.Intrinsics.v64 vclez_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250abc0*/ Unity.Burst.Intrinsics.v128 vclezq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ac00*/ Unity.Burst.Intrinsics.v64 vclez_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250ac40*/ Unity.Burst.Intrinsics.v128 vclezq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ac80*/ Unity.Burst.Intrinsics.v64 vclez_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250acc0*/ Unity.Burst.Intrinsics.v128 vclezq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ad00*/ Unity.Burst.Intrinsics.v64 vclez_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250ad40*/ Unity.Burst.Intrinsics.v128 vclezq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ad80*/ ulong vclezd_s64(long a0);
                    static /*0x250adc0*/ uint vclezs_f32(float a0);
                    static /*0x250ae00*/ ulong vclezd_f64(double a0);
                    static /*0x250ae40*/ Unity.Burst.Intrinsics.v64 vcgt_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250ae80*/ Unity.Burst.Intrinsics.v128 vcgtq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250aec0*/ Unity.Burst.Intrinsics.v64 vcgt_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250af00*/ Unity.Burst.Intrinsics.v128 vcgtq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250af40*/ Unity.Burst.Intrinsics.v64 vcgt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250af80*/ Unity.Burst.Intrinsics.v128 vcgtq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250afc0*/ ulong vcgtd_s64(long a0, long a1);
                    static /*0x250b000*/ ulong vcgtd_u64(ulong a0, ulong a1);
                    static /*0x250b040*/ uint vcgts_f32(float a0, float a1);
                    static /*0x250b080*/ ulong vcgtd_f64(double a0, double a1);
                    static /*0x250b0c0*/ Unity.Burst.Intrinsics.v64 vcgtz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b100*/ Unity.Burst.Intrinsics.v128 vcgtzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b140*/ Unity.Burst.Intrinsics.v64 vcgtz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b180*/ Unity.Burst.Intrinsics.v128 vcgtzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b1c0*/ Unity.Burst.Intrinsics.v64 vcgtz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b200*/ Unity.Burst.Intrinsics.v128 vcgtzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b240*/ Unity.Burst.Intrinsics.v64 vcgtz_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b280*/ Unity.Burst.Intrinsics.v128 vcgtzq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b2c0*/ Unity.Burst.Intrinsics.v64 vcgtz_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b300*/ Unity.Burst.Intrinsics.v128 vcgtzq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b340*/ Unity.Burst.Intrinsics.v64 vcgtz_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b380*/ Unity.Burst.Intrinsics.v128 vcgtzq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b3c0*/ ulong vcgtzd_s64(long a0);
                    static /*0x250b400*/ uint vcgtzs_f32(float a0);
                    static /*0x250b440*/ ulong vcgtzd_f64(double a0);
                    static /*0x250b480*/ Unity.Burst.Intrinsics.v64 vclt_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250b4c0*/ Unity.Burst.Intrinsics.v128 vcltq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250b500*/ Unity.Burst.Intrinsics.v64 vclt_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250b540*/ Unity.Burst.Intrinsics.v128 vcltq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250b580*/ Unity.Burst.Intrinsics.v64 vclt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250b5c0*/ Unity.Burst.Intrinsics.v128 vcltq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250b600*/ ulong vcltd_s64(long a0, long a1);
                    static /*0x250b640*/ ulong vcltd_u64(ulong a0, ulong a1);
                    static /*0x250b680*/ uint vclts_f32(float a0, float a1);
                    static /*0x250b6c0*/ ulong vcltd_f64(double a0, double a1);
                    static /*0x250b700*/ Unity.Burst.Intrinsics.v64 vcltz_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b740*/ Unity.Burst.Intrinsics.v128 vcltzq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b780*/ Unity.Burst.Intrinsics.v64 vcltz_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b7c0*/ Unity.Burst.Intrinsics.v128 vcltzq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b800*/ Unity.Burst.Intrinsics.v64 vcltz_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b840*/ Unity.Burst.Intrinsics.v128 vcltzq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b880*/ Unity.Burst.Intrinsics.v64 vcltz_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b8c0*/ Unity.Burst.Intrinsics.v128 vcltzq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b900*/ Unity.Burst.Intrinsics.v64 vcltz_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b940*/ Unity.Burst.Intrinsics.v128 vcltzq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250b980*/ Unity.Burst.Intrinsics.v64 vcltz_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250b9c0*/ Unity.Burst.Intrinsics.v128 vcltzq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ba00*/ ulong vcltzd_s64(long a0);
                    static /*0x250ba40*/ uint vcltzs_f32(float a0);
                    static /*0x250ba80*/ ulong vcltzd_f64(double a0);
                    static /*0x250bac0*/ Unity.Burst.Intrinsics.v64 vcage_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250bb00*/ Unity.Burst.Intrinsics.v128 vcageq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250bb40*/ uint vcages_f32(float a0, float a1);
                    static /*0x250bb80*/ ulong vcaged_f64(double a0, double a1);
                    static /*0x250bbc0*/ Unity.Burst.Intrinsics.v64 vcale_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250bc00*/ Unity.Burst.Intrinsics.v128 vcaleq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250bc40*/ uint vcales_f32(float a0, float a1);
                    static /*0x250bc80*/ ulong vcaled_f64(double a0, double a1);
                    static /*0x250bcc0*/ Unity.Burst.Intrinsics.v64 vcagt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250bd00*/ Unity.Burst.Intrinsics.v128 vcagtq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250bd40*/ uint vcagts_f32(float a0, float a1);
                    static /*0x250bd80*/ ulong vcagtd_f64(double a0, double a1);
                    static /*0x250bdc0*/ Unity.Burst.Intrinsics.v64 vcalt_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250be00*/ Unity.Burst.Intrinsics.v128 vcaltq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250be40*/ uint vcalts_f32(float a0, float a1);
                    static /*0x250be80*/ ulong vcaltd_f64(double a0, double a1);
                    static /*0x250bec0*/ Unity.Burst.Intrinsics.v64 vtst_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250bf00*/ Unity.Burst.Intrinsics.v128 vtstq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250bf40*/ Unity.Burst.Intrinsics.v64 vtst_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250bf48*/ Unity.Burst.Intrinsics.v128 vtstq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250bf50*/ ulong vtstd_s64(long a0, long a1);
                    static /*0x250bf90*/ ulong vtstd_u64(ulong a0, ulong a1);
                    static /*0x250bfd0*/ Unity.Burst.Intrinsics.v64 vabd_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c010*/ Unity.Burst.Intrinsics.v128 vabdq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c050*/ float vabds_f32(float a0, float a1);
                    static /*0x250c090*/ double vabdd_f64(double a0, double a1);
                    static /*0x250c0d0*/ Unity.Burst.Intrinsics.v128 vabdl_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c110*/ Unity.Burst.Intrinsics.v128 vabdl_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c150*/ Unity.Burst.Intrinsics.v128 vabdl_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c190*/ Unity.Burst.Intrinsics.v128 vabdl_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c1d0*/ Unity.Burst.Intrinsics.v128 vabdl_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c210*/ Unity.Burst.Intrinsics.v128 vabdl_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c250*/ Unity.Burst.Intrinsics.v128 vabal_high_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x250c290*/ Unity.Burst.Intrinsics.v128 vabal_high_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x250c2d0*/ Unity.Burst.Intrinsics.v128 vabal_high_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x250c310*/ Unity.Burst.Intrinsics.v128 vabal_high_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x250c350*/ Unity.Burst.Intrinsics.v128 vabal_high_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x250c390*/ Unity.Burst.Intrinsics.v128 vabal_high_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x250c3d0*/ Unity.Burst.Intrinsics.v64 vmax_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c410*/ Unity.Burst.Intrinsics.v128 vmaxq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c450*/ Unity.Burst.Intrinsics.v64 vmin_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c490*/ Unity.Burst.Intrinsics.v128 vminq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c4d0*/ Unity.Burst.Intrinsics.v64 vmaxnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c510*/ Unity.Burst.Intrinsics.v128 vmaxnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c550*/ Unity.Burst.Intrinsics.v64 vmaxnm_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c590*/ Unity.Burst.Intrinsics.v128 vmaxnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c5d0*/ Unity.Burst.Intrinsics.v64 vminnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c610*/ Unity.Burst.Intrinsics.v128 vminnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c650*/ Unity.Burst.Intrinsics.v64 vminnm_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x250c690*/ Unity.Burst.Intrinsics.v128 vminnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250c6d0*/ long vshld_s64(long a0, long a1);
                    static /*0x250c710*/ ulong vshld_u64(ulong a0, long a1);
                    static /*0x250c750*/ sbyte vqshlb_s8(sbyte a0, sbyte a1);
                    static /*0x250c790*/ short vqshlh_s16(short a0, short a1);
                    static /*0x250c7d0*/ int vqshls_s32(int a0, int a1);
                    static /*0x250c810*/ long vqshld_s64(long a0, long a1);
                    static /*0x250c850*/ byte vqshlb_u8(byte a0, sbyte a1);
                    static /*0x250c890*/ ushort vqshlh_u16(ushort a0, short a1);
                    static /*0x250c8d0*/ uint vqshls_u32(uint a0, int a1);
                    static /*0x250c910*/ ulong vqshld_u64(ulong a0, long a1);
                    static /*0x250c950*/ long vrshld_s64(long a0, long a1);
                    static /*0x250c990*/ ulong vrshld_u64(ulong a0, long a1);
                    static /*0x250c9d0*/ sbyte vqrshlb_s8(sbyte a0, sbyte a1);
                    static /*0x250ca10*/ short vqrshlh_s16(short a0, short a1);
                    static /*0x250ca50*/ int vqrshls_s32(int a0, int a1);
                    static /*0x250ca90*/ long vqrshld_s64(long a0, long a1);
                    static /*0x250cad0*/ byte vqrshlb_u8(byte a0, sbyte a1);
                    static /*0x250cb10*/ ushort vqrshlh_u16(ushort a0, short a1);
                    static /*0x250cb50*/ uint vqrshls_u32(uint a0, int a1);
                    static /*0x250cb90*/ ulong vqrshld_u64(ulong a0, long a1);
                    static /*0x250cbd0*/ long vshrd_n_s64(long a0, int a1);
                    static /*0x250cbd8*/ ulong vshrd_n_u64(ulong a0, int a1);
                    static /*0x250cbe0*/ long vshld_n_s64(long a0, int a1);
                    static /*0x250cbe8*/ ulong vshld_n_u64(ulong a0, int a1);
                    static /*0x250cbf0*/ long vrshrd_n_s64(long a0, int a1);
                    static /*0x250cc30*/ ulong vrshrd_n_u64(ulong a0, int a1);
                    static /*0x250cc70*/ long vsrad_n_s64(long a0, long a1, int a2);
                    static /*0x250cc7c*/ ulong vsrad_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x250cc88*/ long vrsrad_n_s64(long a0, long a1, int a2);
                    static /*0x250ccc8*/ ulong vrsrad_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x250cd08*/ sbyte vqshlb_n_s8(sbyte a0, int a1);
                    static /*0x250cd48*/ short vqshlh_n_s16(short a0, int a1);
                    static /*0x250cd88*/ int vqshls_n_s32(int a0, int a1);
                    static /*0x250cdc8*/ long vqshld_n_s64(long a0, int a1);
                    static /*0x250ce08*/ byte vqshlb_n_u8(byte a0, int a1);
                    static /*0x250ce48*/ ushort vqshlh_n_u16(ushort a0, int a1);
                    static /*0x250ce88*/ uint vqshls_n_u32(uint a0, int a1);
                    static /*0x250cec8*/ ulong vqshld_n_u64(ulong a0, int a1);
                    static /*0x250cf08*/ byte vqshlub_n_s8(sbyte a0, int a1);
                    static /*0x250cf48*/ ushort vqshluh_n_s16(short a0, int a1);
                    static /*0x250cf88*/ uint vqshlus_n_s32(int a0, int a1);
                    static /*0x250cfc8*/ ulong vqshlud_n_s64(long a0, int a1);
                    static /*0x250d008*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d048*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d088*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d0c8*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d108*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d148*/ Unity.Burst.Intrinsics.v128 vshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d188*/ byte vqshrunh_n_s16(short a0, int a1);
                    static /*0x250d1c8*/ ushort vqshruns_n_s32(int a0, int a1);
                    static /*0x250d208*/ uint vqshrund_n_s64(long a0, int a1);
                    static /*0x250d248*/ Unity.Burst.Intrinsics.v128 vqshrun_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d288*/ Unity.Burst.Intrinsics.v128 vqshrun_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d2c8*/ Unity.Burst.Intrinsics.v128 vqshrun_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d308*/ byte vqrshrunh_n_s16(short a0, int a1);
                    static /*0x250d348*/ ushort vqrshruns_n_s32(int a0, int a1);
                    static /*0x250d388*/ uint vqrshrund_n_s64(long a0, int a1);
                    static /*0x250d3c8*/ Unity.Burst.Intrinsics.v128 vqrshrun_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d408*/ Unity.Burst.Intrinsics.v128 vqrshrun_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d448*/ Unity.Burst.Intrinsics.v128 vqrshrun_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d488*/ sbyte vqshrnh_n_s16(short a0, int a1);
                    static /*0x250d4c8*/ short vqshrns_n_s32(int a0, int a1);
                    static /*0x250d508*/ int vqshrnd_n_s64(long a0, int a1);
                    static /*0x250d548*/ byte vqshrnh_n_u16(ushort a0, int a1);
                    static /*0x250d588*/ ushort vqshrns_n_u32(uint a0, int a1);
                    static /*0x250d5c8*/ uint vqshrnd_n_u64(ulong a0, int a1);
                    static /*0x250d608*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d648*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d688*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d6c8*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d708*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d748*/ Unity.Burst.Intrinsics.v128 vqshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d788*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d7c8*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d808*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d848*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d888*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d8c8*/ Unity.Burst.Intrinsics.v128 vrshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250d908*/ sbyte vqrshrnh_n_s16(short a0, int a1);
                    static /*0x250d948*/ short vqrshrns_n_s32(int a0, int a1);
                    static /*0x250d988*/ int vqrshrnd_n_s64(long a0, int a1);
                    static /*0x250d9c8*/ byte vqrshrnh_n_u16(ushort a0, int a1);
                    static /*0x250da08*/ ushort vqrshrns_n_u32(uint a0, int a1);
                    static /*0x250da48*/ uint vqrshrnd_n_u64(ulong a0, int a1);
                    static /*0x250da88*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250dac8*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250db08*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250db48*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250db88*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250dbc8*/ Unity.Burst.Intrinsics.v128 vqrshrn_high_n_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x250dc08*/ Unity.Burst.Intrinsics.v128 vshll_high_n_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250dc48*/ Unity.Burst.Intrinsics.v128 vshll_high_n_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250dc88*/ Unity.Burst.Intrinsics.v128 vshll_high_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250dcc8*/ Unity.Burst.Intrinsics.v128 vshll_high_n_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250dd08*/ Unity.Burst.Intrinsics.v128 vshll_high_n_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250dd48*/ Unity.Burst.Intrinsics.v128 vshll_high_n_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250dd88*/ long vsrid_n_s64(long a0, long a1, int a2);
                    static /*0x250ddc8*/ ulong vsrid_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x250de08*/ long vslid_n_s64(long a0, long a1, int a2);
                    static /*0x250de48*/ ulong vslid_n_u64(ulong a0, ulong a1, int a2);
                    static /*0x250de88*/ Unity.Burst.Intrinsics.v64 vcvtn_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250dec8*/ Unity.Burst.Intrinsics.v128 vcvtnq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250df08*/ Unity.Burst.Intrinsics.v64 vcvtn_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250df48*/ Unity.Burst.Intrinsics.v128 vcvtnq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250df88*/ Unity.Burst.Intrinsics.v64 vcvtm_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250dfc8*/ Unity.Burst.Intrinsics.v128 vcvtmq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e008*/ Unity.Burst.Intrinsics.v64 vcvtm_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e048*/ Unity.Burst.Intrinsics.v128 vcvtmq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e088*/ Unity.Burst.Intrinsics.v64 vcvtp_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e0c8*/ Unity.Burst.Intrinsics.v128 vcvtpq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e108*/ Unity.Burst.Intrinsics.v64 vcvtp_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e148*/ Unity.Burst.Intrinsics.v128 vcvtpq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e188*/ Unity.Burst.Intrinsics.v64 vcvta_s32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e1c8*/ Unity.Burst.Intrinsics.v128 vcvtaq_s32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e208*/ Unity.Burst.Intrinsics.v64 vcvta_u32_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e248*/ Unity.Burst.Intrinsics.v128 vcvtaq_u32_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e288*/ int vcvts_s32_f32(float a0);
                    static /*0x250e2c8*/ uint vcvts_u32_f32(float a0);
                    static /*0x250e308*/ int vcvtns_s32_f32(float a0);
                    static /*0x250e348*/ uint vcvtns_u32_f32(float a0);
                    static /*0x250e388*/ int vcvtms_s32_f32(float a0);
                    static /*0x250e3c8*/ uint vcvtms_u32_f32(float a0);
                    static /*0x250e408*/ int vcvtps_s32_f32(float a0);
                    static /*0x250e448*/ uint vcvtps_u32_f32(float a0);
                    static /*0x250e488*/ int vcvtas_s32_f32(float a0);
                    static /*0x250e4c8*/ uint vcvtas_u32_f32(float a0);
                    static /*0x250e508*/ Unity.Burst.Intrinsics.v64 vcvt_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e548*/ Unity.Burst.Intrinsics.v128 vcvtq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e588*/ Unity.Burst.Intrinsics.v64 vcvt_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e5c8*/ Unity.Burst.Intrinsics.v128 vcvtq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e608*/ Unity.Burst.Intrinsics.v64 vcvtn_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e648*/ Unity.Burst.Intrinsics.v128 vcvtnq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e688*/ Unity.Burst.Intrinsics.v64 vcvtn_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e6c8*/ Unity.Burst.Intrinsics.v128 vcvtnq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e708*/ Unity.Burst.Intrinsics.v64 vcvtm_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e748*/ Unity.Burst.Intrinsics.v128 vcvtmq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e788*/ Unity.Burst.Intrinsics.v64 vcvtm_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e7c8*/ Unity.Burst.Intrinsics.v128 vcvtmq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e808*/ Unity.Burst.Intrinsics.v64 vcvtp_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e848*/ Unity.Burst.Intrinsics.v128 vcvtpq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e888*/ Unity.Burst.Intrinsics.v64 vcvtp_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e8c8*/ Unity.Burst.Intrinsics.v128 vcvtpq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e908*/ Unity.Burst.Intrinsics.v64 vcvta_s64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e948*/ Unity.Burst.Intrinsics.v128 vcvtaq_s64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250e988*/ Unity.Burst.Intrinsics.v64 vcvta_u64_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250e9c8*/ Unity.Burst.Intrinsics.v128 vcvtaq_u64_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ea08*/ long vcvtd_s64_f64(double a0);
                    static /*0x250ea48*/ ulong vcvtd_u64_f64(double a0);
                    static /*0x250ea88*/ long vcvtnd_s64_f64(double a0);
                    static /*0x250eac8*/ ulong vcvtnd_u64_f64(double a0);
                    static /*0x250eb08*/ long vcvtmd_s64_f64(double a0);
                    static /*0x250eb48*/ ulong vcvtmd_u64_f64(double a0);
                    static /*0x250eb88*/ long vcvtpd_s64_f64(double a0);
                    static /*0x250ebc8*/ ulong vcvtpd_u64_f64(double a0);
                    static /*0x250ec08*/ long vcvtad_s64_f64(double a0);
                    static /*0x250ec48*/ ulong vcvtad_u64_f64(double a0);
                    static /*0x250ec88*/ int vcvts_n_s32_f32(float a0, int a1);
                    static /*0x250ecc8*/ uint vcvts_n_u32_f32(float a0, int a1);
                    static /*0x250ed08*/ Unity.Burst.Intrinsics.v64 vcvt_n_s64_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250ed48*/ Unity.Burst.Intrinsics.v128 vcvtq_n_s64_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250ed88*/ Unity.Burst.Intrinsics.v64 vcvt_n_u64_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250edc8*/ Unity.Burst.Intrinsics.v128 vcvtq_n_u64_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250ee08*/ long vcvtd_n_s64_f64(double a0, int a1);
                    static /*0x250ee48*/ ulong vcvtd_n_u64_f64(double a0, int a1);
                    static /*0x250ee88*/ float vcvts_f32_s32(int a0);
                    static /*0x250eec8*/ float vcvts_f32_u32(uint a0);
                    static /*0x250ef08*/ Unity.Burst.Intrinsics.v64 vcvt_f64_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250ef48*/ Unity.Burst.Intrinsics.v128 vcvtq_f64_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250ef88*/ Unity.Burst.Intrinsics.v64 vcvt_f64_u64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250efc8*/ Unity.Burst.Intrinsics.v128 vcvtq_f64_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f008*/ double vcvtd_f64_s64(long a0);
                    static /*0x250f048*/ double vcvtd_f64_u64(ulong a0);
                    static /*0x250f088*/ float vcvts_n_f32_s32(int a0, int a1);
                    static /*0x250f0c8*/ float vcvts_n_f32_u32(uint a0, int a1);
                    static /*0x250f108*/ Unity.Burst.Intrinsics.v64 vcvt_n_f64_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250f148*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f64_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250f188*/ Unity.Burst.Intrinsics.v64 vcvt_n_f64_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x250f1c8*/ Unity.Burst.Intrinsics.v128 vcvtq_n_f64_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x250f208*/ double vcvtd_n_f64_s64(long a0, int a1);
                    static /*0x250f248*/ double vcvtd_n_f64_u64(ulong a0, int a1);
                    static /*0x250f288*/ Unity.Burst.Intrinsics.v64 vcvt_f32_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f2c8*/ Unity.Burst.Intrinsics.v128 vcvt_high_f32_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250f308*/ Unity.Burst.Intrinsics.v128 vcvt_f64_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f348*/ Unity.Burst.Intrinsics.v128 vcvt_high_f64_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f388*/ Unity.Burst.Intrinsics.v64 vcvtx_f32_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f3c8*/ float vcvtxd_f32_f64(double a0);
                    static /*0x250f408*/ Unity.Burst.Intrinsics.v128 vcvtx_high_f32_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250f448*/ Unity.Burst.Intrinsics.v64 vrnd_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f488*/ Unity.Burst.Intrinsics.v128 vrndq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f4c8*/ Unity.Burst.Intrinsics.v64 vrnd_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f508*/ Unity.Burst.Intrinsics.v128 vrndq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f548*/ Unity.Burst.Intrinsics.v64 vrndn_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f588*/ Unity.Burst.Intrinsics.v128 vrndnq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f5c8*/ Unity.Burst.Intrinsics.v64 vrndn_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f608*/ Unity.Burst.Intrinsics.v128 vrndnq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f648*/ float vrndns_f32(float a0);
                    static /*0x250f688*/ Unity.Burst.Intrinsics.v64 vrndm_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f6c8*/ Unity.Burst.Intrinsics.v128 vrndmq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f708*/ Unity.Burst.Intrinsics.v64 vrndm_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f748*/ Unity.Burst.Intrinsics.v128 vrndmq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f788*/ Unity.Burst.Intrinsics.v64 vrndp_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f7c8*/ Unity.Burst.Intrinsics.v128 vrndpq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f808*/ Unity.Burst.Intrinsics.v64 vrndp_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f848*/ Unity.Burst.Intrinsics.v128 vrndpq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f888*/ Unity.Burst.Intrinsics.v64 vrnda_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f8c8*/ Unity.Burst.Intrinsics.v128 vrndaq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f908*/ Unity.Burst.Intrinsics.v64 vrnda_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f948*/ Unity.Burst.Intrinsics.v128 vrndaq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250f988*/ Unity.Burst.Intrinsics.v64 vrndi_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250f9c8*/ Unity.Burst.Intrinsics.v128 vrndiq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fa08*/ Unity.Burst.Intrinsics.v64 vrndi_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250fa48*/ Unity.Burst.Intrinsics.v128 vrndiq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fa88*/ Unity.Burst.Intrinsics.v64 vrndx_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250fac8*/ Unity.Burst.Intrinsics.v128 vrndxq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fb08*/ Unity.Burst.Intrinsics.v64 vrndx_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x250fb48*/ Unity.Burst.Intrinsics.v128 vrndxq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fb88*/ Unity.Burst.Intrinsics.v128 vmovl_high_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fbc8*/ Unity.Burst.Intrinsics.v128 vmovl_high_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fc08*/ Unity.Burst.Intrinsics.v128 vmovl_high_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fc48*/ Unity.Burst.Intrinsics.v128 vmovl_high_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fc88*/ Unity.Burst.Intrinsics.v128 vmovl_high_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fcc8*/ Unity.Burst.Intrinsics.v128 vmovl_high_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x250fd08*/ sbyte vqmovnh_s16(short a0);
                    static /*0x250fd48*/ short vqmovns_s32(int a0);
                    static /*0x250fd88*/ int vqmovnd_s64(long a0);
                    static /*0x250fdc8*/ byte vqmovnh_u16(ushort a0);
                    static /*0x250fe08*/ ushort vqmovns_u32(uint a0);
                    static /*0x250fe48*/ uint vqmovnd_u64(ulong a0);
                    static /*0x250fe88*/ Unity.Burst.Intrinsics.v128 vqmovn_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250fec8*/ Unity.Burst.Intrinsics.v128 vqmovn_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250ff08*/ Unity.Burst.Intrinsics.v128 vqmovn_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250ff48*/ Unity.Burst.Intrinsics.v128 vqmovn_high_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250ff88*/ Unity.Burst.Intrinsics.v128 vqmovn_high_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x250ffc8*/ Unity.Burst.Intrinsics.v128 vqmovn_high_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2510008*/ byte vqmovunh_s16(short a0);
                    static /*0x2510048*/ ushort vqmovuns_s32(int a0);
                    static /*0x2510088*/ uint vqmovund_s64(long a0);
                    static /*0x25100c8*/ Unity.Burst.Intrinsics.v128 vqmovun_high_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2510108*/ Unity.Burst.Intrinsics.v128 vqmovun_high_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2510148*/ Unity.Burst.Intrinsics.v128 vqmovun_high_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2510188*/ Unity.Burst.Intrinsics.v64 vmla_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25101c8*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510208*/ Unity.Burst.Intrinsics.v64 vmla_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510248*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510288*/ Unity.Burst.Intrinsics.v64 vmla_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25102c8*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510308*/ Unity.Burst.Intrinsics.v64 vmla_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510348*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510388*/ Unity.Burst.Intrinsics.v64 vmla_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25103c8*/ Unity.Burst.Intrinsics.v128 vmlaq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510408*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510448*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510488*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25104c8*/ Unity.Burst.Intrinsics.v128 vmlal_high_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510508*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510548*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510588*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25105c8*/ Unity.Burst.Intrinsics.v128 vmlal_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510608*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510648*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510688*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25106c8*/ Unity.Burst.Intrinsics.v128 vmlal_high_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510708*/ int vqdmlalh_lane_s16(int a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510748*/ long vqdmlals_lane_s32(long a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510788*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25107c8*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510808*/ Unity.Burst.Intrinsics.v128 vqdmlal_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510848*/ Unity.Burst.Intrinsics.v128 vqdmlal_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510888*/ int vqdmlalh_laneq_s16(int a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25108c8*/ long vqdmlals_laneq_s32(long a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510908*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510948*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510988*/ Unity.Burst.Intrinsics.v64 vmls_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25109c8*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510a08*/ Unity.Burst.Intrinsics.v64 vmls_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510a48*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510a88*/ Unity.Burst.Intrinsics.v64 vmls_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510ac8*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510b08*/ Unity.Burst.Intrinsics.v64 vmls_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510b48*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510b88*/ Unity.Burst.Intrinsics.v64 vmls_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510bc8*/ Unity.Burst.Intrinsics.v128 vmlsq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510c08*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510c48*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510c88*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510cc8*/ Unity.Burst.Intrinsics.v128 vmlsl_high_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510d08*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510d48*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510d88*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510dc8*/ Unity.Burst.Intrinsics.v128 vmlsl_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510e08*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510e48*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510e88*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510ec8*/ Unity.Burst.Intrinsics.v128 vmlsl_high_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2510f08*/ int vqdmlslh_lane_s16(int a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510f48*/ long vqdmlsls_lane_s32(long a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510f88*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2510fc8*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2511008*/ Unity.Burst.Intrinsics.v128 vqdmlsl_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2511048*/ Unity.Burst.Intrinsics.v128 vqdmlsl_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2511088*/ int vqdmlslh_laneq_s16(int a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25110c8*/ long vqdmlsls_laneq_s32(long a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2511108*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2511148*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2511188*/ Unity.Burst.Intrinsics.v64 vmul_n_f64(Unity.Burst.Intrinsics.v64 a0, double a1);
                    static /*0x25111c8*/ Unity.Burst.Intrinsics.v128 vmulq_n_f64(Unity.Burst.Intrinsics.v128 a0, double a1);
                    static /*0x2511208*/ Unity.Burst.Intrinsics.v64 vmul_lane_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511210*/ Unity.Burst.Intrinsics.v128 vmulq_lane_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511250*/ float vmuls_lane_f32(float a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511290*/ double vmuld_lane_f64(double a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x251129c*/ Unity.Burst.Intrinsics.v64 vmul_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25112dc*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251131c*/ Unity.Burst.Intrinsics.v64 vmul_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251135c*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251139c*/ Unity.Burst.Intrinsics.v64 vmul_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25113dc*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251141c*/ Unity.Burst.Intrinsics.v64 vmul_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251145c*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251149c*/ Unity.Burst.Intrinsics.v64 vmul_laneq_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25114dc*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251151c*/ Unity.Burst.Intrinsics.v64 vmul_laneq_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251155c*/ Unity.Burst.Intrinsics.v128 vmulq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251159c*/ float vmuls_laneq_f32(float a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25115dc*/ double vmuld_laneq_f64(double a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251161c*/ Unity.Burst.Intrinsics.v128 vmull_high_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x251165c*/ Unity.Burst.Intrinsics.v128 vmull_high_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x251169c*/ Unity.Burst.Intrinsics.v128 vmull_high_n_u16(Unity.Burst.Intrinsics.v128 a0, ushort a1);
                    static /*0x25116dc*/ Unity.Burst.Intrinsics.v128 vmull_high_n_u32(Unity.Burst.Intrinsics.v128 a0, uint a1);
                    static /*0x251171c*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x251175c*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x251179c*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x25117dc*/ Unity.Burst.Intrinsics.v128 vmull_high_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x251181c*/ Unity.Burst.Intrinsics.v128 vmull_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251185c*/ Unity.Burst.Intrinsics.v128 vmull_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251189c*/ Unity.Burst.Intrinsics.v128 vmull_laneq_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25118dc*/ Unity.Burst.Intrinsics.v128 vmull_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251191c*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251195c*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251199c*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25119dc*/ Unity.Burst.Intrinsics.v128 vmull_high_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511a1c*/ Unity.Burst.Intrinsics.v128 vqdmull_high_n_s16(Unity.Burst.Intrinsics.v128 a0, short a1);
                    static /*0x2511a5c*/ Unity.Burst.Intrinsics.v128 vqdmull_high_n_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2511a9c*/ int vqdmullh_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511adc*/ long vqdmulls_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511b1c*/ Unity.Burst.Intrinsics.v128 vqdmull_high_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511b5c*/ Unity.Burst.Intrinsics.v128 vqdmull_high_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511b9c*/ Unity.Burst.Intrinsics.v128 vqdmull_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511bdc*/ Unity.Burst.Intrinsics.v128 vqdmull_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511c1c*/ int vqdmullh_laneq_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511c5c*/ long vqdmulls_laneq_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511c9c*/ Unity.Burst.Intrinsics.v128 vqdmull_high_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511cdc*/ Unity.Burst.Intrinsics.v128 vqdmull_high_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511d1c*/ short vqdmulhh_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511d5c*/ int vqdmulhs_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511d9c*/ Unity.Burst.Intrinsics.v64 vqdmulh_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511ddc*/ Unity.Burst.Intrinsics.v128 vqdmulhq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511e1c*/ Unity.Burst.Intrinsics.v64 vqdmulh_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511e5c*/ Unity.Burst.Intrinsics.v128 vqdmulhq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511e9c*/ short vqdmulhh_laneq_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511edc*/ int vqdmulhs_laneq_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511f1c*/ short vqrdmulhh_lane_s16(short a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511f5c*/ int vqrdmulhs_lane_s32(int a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2511f9c*/ Unity.Burst.Intrinsics.v64 vqrdmulh_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2511fdc*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251201c*/ Unity.Burst.Intrinsics.v64 vqrdmulh_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251205c*/ Unity.Burst.Intrinsics.v128 vqrdmulhq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251209c*/ short vqrdmulhh_laneq_s16(short a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x25120dc*/ int vqrdmulhs_laneq_s32(int a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251211c*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x251215c*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251219c*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x25121dc*/ Unity.Burst.Intrinsics.v128 vmlal_high_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x251221c*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x251225c*/ Unity.Burst.Intrinsics.v128 vqdmlal_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251229c*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x25122dc*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251231c*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, ushort a2);
                    static /*0x251235c*/ Unity.Burst.Intrinsics.v128 vmlsl_high_n_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, uint a2);
                    static /*0x251239c*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_n_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, short a2);
                    static /*0x25123dc*/ Unity.Burst.Intrinsics.v128 vqdmlsl_high_n_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x251241c*/ Unity.Burst.Intrinsics.v64 vabs_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x251245c*/ long vabsd_s64(long a0);
                    static /*0x251249c*/ Unity.Burst.Intrinsics.v128 vabsq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25124dc*/ Unity.Burst.Intrinsics.v64 vabs_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x251251c*/ Unity.Burst.Intrinsics.v128 vabsq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x251255c*/ Unity.Burst.Intrinsics.v64 vqabs_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x251259c*/ Unity.Burst.Intrinsics.v128 vqabsq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25125dc*/ sbyte vqabsb_s8(sbyte a0);
                    static /*0x251261c*/ short vqabsh_s16(short a0);
                    static /*0x251265c*/ int vqabss_s32(int a0);
                    static /*0x251269c*/ long vqabsd_s64(long a0);
                    static /*0x25126dc*/ Unity.Burst.Intrinsics.v64 vneg_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x251271c*/ long vnegd_s64(long a0);
                    static /*0x251275c*/ Unity.Burst.Intrinsics.v128 vnegq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x251279c*/ Unity.Burst.Intrinsics.v64 vneg_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25127dc*/ Unity.Burst.Intrinsics.v128 vnegq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x251281c*/ Unity.Burst.Intrinsics.v64 vqneg_s64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x251285c*/ Unity.Burst.Intrinsics.v128 vqnegq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x251289c*/ sbyte vqnegb_s8(sbyte a0);
                    static /*0x25128dc*/ short vqnegh_s16(short a0);
                    static /*0x251291c*/ int vqnegs_s32(int a0);
                    static /*0x251295c*/ long vqnegd_s64(long a0);
                    static /*0x251299c*/ Unity.Burst.Intrinsics.v64 vrecpe_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25129dc*/ Unity.Burst.Intrinsics.v128 vrecpeq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2512a1c*/ float vrecpes_f32(float a0);
                    static /*0x2512a5c*/ double vrecped_f64(double a0);
                    static /*0x2512a9c*/ Unity.Burst.Intrinsics.v64 vrecps_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2512adc*/ Unity.Burst.Intrinsics.v128 vrecpsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2512b1c*/ float vrecpss_f32(float a0, float a1);
                    static /*0x2512b5c*/ double vrecpsd_f64(double a0, double a1);
                    static /*0x2512b9c*/ Unity.Burst.Intrinsics.v64 vsqrt_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2512bdc*/ Unity.Burst.Intrinsics.v128 vsqrtq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2512c1c*/ Unity.Burst.Intrinsics.v64 vsqrt_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2512c5c*/ Unity.Burst.Intrinsics.v128 vsqrtq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2512c9c*/ Unity.Burst.Intrinsics.v64 vrsqrte_f64(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2512cdc*/ Unity.Burst.Intrinsics.v128 vrsqrteq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2512d1c*/ float vrsqrtes_f32(float a0);
                    static /*0x2512d5c*/ double vrsqrted_f64(double a0);
                    static /*0x2512d9c*/ Unity.Burst.Intrinsics.v64 vrsqrts_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2512ddc*/ Unity.Burst.Intrinsics.v128 vrsqrtsq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2512e1c*/ float vrsqrtss_f32(float a0, float a1);
                    static /*0x2512e5c*/ double vrsqrtsd_f64(double a0, double a1);
                    static /*0x2512e9c*/ Unity.Burst.Intrinsics.v64 vbsl_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2512ea4*/ Unity.Burst.Intrinsics.v128 vbslq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2512eac*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2512eec*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2512f2c*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2512f6c*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2512fac*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2512fec*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x251302c*/ Unity.Burst.Intrinsics.v64 vcopy_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2513034*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_s64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2513074*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25130b4*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25130f4*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2513134*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2513174*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25131b4*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25131f4*/ Unity.Burst.Intrinsics.v64 vcopy_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25131fc*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_u64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x251323c*/ Unity.Burst.Intrinsics.v64 vcopy_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x251327c*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_f32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25132bc*/ Unity.Burst.Intrinsics.v64 vcopy_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25132c4*/ Unity.Burst.Intrinsics.v128 vcopyq_lane_f64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2513304*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513344*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513384*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25133c4*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513404*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513444*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513484*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_s64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25134c4*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513504*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u8(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513544*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513584*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u16(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25135c4*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513604*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513644*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513684*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_u64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25136c4*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513704*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_f32(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513744*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513784*/ Unity.Burst.Intrinsics.v64 vcopy_laneq_f64(Unity.Burst.Intrinsics.v64 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25137c4*/ Unity.Burst.Intrinsics.v128 vcopyq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2513804*/ Unity.Burst.Intrinsics.v64 vrbit_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2513844*/ Unity.Burst.Intrinsics.v128 vrbitq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2513884*/ Unity.Burst.Intrinsics.v64 vrbit_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x251388c*/ Unity.Burst.Intrinsics.v128 vrbitq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2513894*/ Unity.Burst.Intrinsics.v64 vdup_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513898*/ Unity.Burst.Intrinsics.v128 vdupq_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x25138e8*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513928*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513968*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25139a8*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25139e8*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513a28*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513a68*/ Unity.Burst.Intrinsics.v64 vdup_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513aa8*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513ae8*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513b28*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513b68*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513ba8*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513be8*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513c28*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513c68*/ Unity.Burst.Intrinsics.v64 vdup_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513ca8*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513ce8*/ Unity.Burst.Intrinsics.v64 vdup_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513d28*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513d68*/ Unity.Burst.Intrinsics.v64 vdup_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513da8*/ Unity.Burst.Intrinsics.v128 vdupq_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513de8*/ sbyte vdupb_lane_s8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513e28*/ short vduph_lane_s16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513e68*/ int vdups_lane_s32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513ea8*/ long vdupd_lane_s64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513eac*/ byte vdupb_lane_u8(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513eec*/ ushort vduph_lane_u16(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513f2c*/ uint vdups_lane_u32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513f6c*/ ulong vdupd_lane_u64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513f70*/ float vdups_lane_f32(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513fb0*/ double vdupd_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2513fb8*/ sbyte vdupb_laneq_s8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2513ff8*/ short vduph_laneq_s16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2514038*/ int vdups_laneq_s32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2514078*/ long vdupd_laneq_s64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25140b8*/ byte vdupb_laneq_u8(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25140f8*/ ushort vduph_laneq_u16(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2514138*/ uint vdups_laneq_u32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2514178*/ ulong vdupd_laneq_u64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25141b8*/ float vdups_laneq_f32(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x25141f8*/ double vdupd_laneq_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2514238*/ Unity.Burst.Intrinsics.v128 vpaddq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514278*/ Unity.Burst.Intrinsics.v128 vpaddq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25142b8*/ Unity.Burst.Intrinsics.v128 vpaddq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25142f8*/ Unity.Burst.Intrinsics.v128 vpaddq_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514338*/ Unity.Burst.Intrinsics.v128 vpaddq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514340*/ Unity.Burst.Intrinsics.v128 vpaddq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514348*/ Unity.Burst.Intrinsics.v128 vpaddq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514350*/ Unity.Burst.Intrinsics.v128 vpaddq_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514358*/ Unity.Burst.Intrinsics.v128 vpaddq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514398*/ Unity.Burst.Intrinsics.v128 vpaddq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25143d8*/ Unity.Burst.Intrinsics.v128 vpmaxq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514418*/ Unity.Burst.Intrinsics.v128 vpmaxq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514458*/ Unity.Burst.Intrinsics.v128 vpmaxq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514498*/ Unity.Burst.Intrinsics.v128 vpmaxq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25144d8*/ Unity.Burst.Intrinsics.v128 vpmaxq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514518*/ Unity.Burst.Intrinsics.v128 vpmaxq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514558*/ Unity.Burst.Intrinsics.v128 vpmaxq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514598*/ Unity.Burst.Intrinsics.v128 vpmaxq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25145d8*/ Unity.Burst.Intrinsics.v128 vpminq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514618*/ Unity.Burst.Intrinsics.v128 vpminq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514658*/ Unity.Burst.Intrinsics.v128 vpminq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514698*/ Unity.Burst.Intrinsics.v128 vpminq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25146d8*/ Unity.Burst.Intrinsics.v128 vpminq_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514718*/ Unity.Burst.Intrinsics.v128 vpminq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514758*/ Unity.Burst.Intrinsics.v128 vpminq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514798*/ Unity.Burst.Intrinsics.v128 vpminq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25147d8*/ Unity.Burst.Intrinsics.v64 vpmaxnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2514818*/ Unity.Burst.Intrinsics.v128 vpmaxnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514858*/ Unity.Burst.Intrinsics.v128 vpmaxnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514898*/ Unity.Burst.Intrinsics.v64 vpminnm_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25148d8*/ Unity.Burst.Intrinsics.v128 vpminnmq_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514918*/ Unity.Burst.Intrinsics.v128 vpminnmq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2514958*/ long vpaddd_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514998*/ ulong vpaddd_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25149d8*/ float vpadds_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514a18*/ double vpaddd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514a58*/ float vpmaxs_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514a98*/ double vpmaxqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514ad8*/ float vpmins_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514b18*/ double vpminqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514b58*/ float vpmaxnms_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514b98*/ double vpmaxnmqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514bd8*/ float vpminnms_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514c18*/ double vpminnmqd_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514c58*/ sbyte vaddv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514c98*/ sbyte vaddvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514cd8*/ short vaddv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514d18*/ short vaddvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514d58*/ int vaddv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514d98*/ int vaddvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514dd8*/ long vaddvq_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514e18*/ byte vaddv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514e58*/ byte vaddvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514e98*/ ushort vaddv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514ed8*/ ushort vaddvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514f18*/ uint vaddv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2514f58*/ uint vaddvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514f98*/ ulong vaddvq_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2514fd8*/ float vaddv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515018*/ float vaddvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515058*/ double vaddvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515098*/ short vaddlv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25150d8*/ short vaddlvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515118*/ int vaddlv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515158*/ int vaddlvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515198*/ long vaddlv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25151d8*/ long vaddlvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515218*/ ushort vaddlv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515258*/ ushort vaddlvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515298*/ uint vaddlv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25152d8*/ uint vaddlvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515318*/ ulong vaddlv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515358*/ ulong vaddlvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515398*/ sbyte vmaxv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25153d8*/ sbyte vmaxvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515418*/ short vmaxv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515458*/ short vmaxvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515498*/ int vmaxv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25154d8*/ int vmaxvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515518*/ byte vmaxv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515558*/ byte vmaxvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515598*/ ushort vmaxv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25155d8*/ ushort vmaxvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515618*/ uint vmaxv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515658*/ uint vmaxvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515698*/ float vmaxv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x25156d8*/ float vmaxvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515718*/ double vmaxvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515758*/ sbyte vminv_s8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515798*/ sbyte vminvq_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25157d8*/ short vminv_s16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515818*/ short vminvq_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515858*/ int vminv_s32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515898*/ int vminvq_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25158d8*/ byte vminv_u8(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515918*/ byte vminvq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515958*/ ushort vminv_u16(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515998*/ ushort vminvq_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x25159d8*/ uint vminv_u32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515a18*/ uint vminvq_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515a58*/ float vminv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515a98*/ float vminvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515ad8*/ double vminvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515b18*/ float vmaxnmv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515b58*/ float vmaxnmvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515b98*/ double vmaxnmvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515bd8*/ float vminnmv_f32(Unity.Burst.Intrinsics.v64 a0);
                    static /*0x2515c18*/ float vminnmvq_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515c58*/ double vminnmvq_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2515c98*/ Unity.Burst.Intrinsics.v64 vext_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2515c9c*/ Unity.Burst.Intrinsics.v128 vextq_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2515cdc*/ Unity.Burst.Intrinsics.v64 vzip1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515d1c*/ Unity.Burst.Intrinsics.v128 vzip1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515d5c*/ Unity.Burst.Intrinsics.v64 vzip1_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515d9c*/ Unity.Burst.Intrinsics.v128 vzip1q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515ddc*/ Unity.Burst.Intrinsics.v64 vzip1_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515e1c*/ Unity.Burst.Intrinsics.v128 vzip1q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515e5c*/ Unity.Burst.Intrinsics.v128 vzip1q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515e9c*/ Unity.Burst.Intrinsics.v64 vzip1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515ea4*/ Unity.Burst.Intrinsics.v128 vzip1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515eac*/ Unity.Burst.Intrinsics.v64 vzip1_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515eb4*/ Unity.Burst.Intrinsics.v128 vzip1q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515ebc*/ Unity.Burst.Intrinsics.v64 vzip1_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515ec4*/ Unity.Burst.Intrinsics.v128 vzip1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515ecc*/ Unity.Burst.Intrinsics.v128 vzip1q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515ed4*/ Unity.Burst.Intrinsics.v64 vzip1_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515edc*/ Unity.Burst.Intrinsics.v128 vzip1q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515ee4*/ Unity.Burst.Intrinsics.v128 vzip1q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515eec*/ Unity.Burst.Intrinsics.v64 vzip2_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515f2c*/ Unity.Burst.Intrinsics.v128 vzip2q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515f6c*/ Unity.Burst.Intrinsics.v64 vzip2_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2515fac*/ Unity.Burst.Intrinsics.v128 vzip2q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2515fec*/ Unity.Burst.Intrinsics.v64 vzip2_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251602c*/ Unity.Burst.Intrinsics.v128 vzip2q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251606c*/ Unity.Burst.Intrinsics.v128 vzip2q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160ac*/ Unity.Burst.Intrinsics.v64 vzip2_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25160b4*/ Unity.Burst.Intrinsics.v128 vzip2q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160bc*/ Unity.Burst.Intrinsics.v64 vzip2_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25160c4*/ Unity.Burst.Intrinsics.v128 vzip2q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160cc*/ Unity.Burst.Intrinsics.v64 vzip2_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25160d4*/ Unity.Burst.Intrinsics.v128 vzip2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160dc*/ Unity.Burst.Intrinsics.v128 vzip2q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160e4*/ Unity.Burst.Intrinsics.v64 vzip2_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25160ec*/ Unity.Burst.Intrinsics.v128 vzip2q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160f4*/ Unity.Burst.Intrinsics.v128 vzip2q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25160fc*/ Unity.Burst.Intrinsics.v64 vuzp1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251613c*/ Unity.Burst.Intrinsics.v128 vuzp1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251617c*/ Unity.Burst.Intrinsics.v64 vuzp1_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25161bc*/ Unity.Burst.Intrinsics.v128 vuzp1q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25161fc*/ Unity.Burst.Intrinsics.v64 vuzp1_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251623c*/ Unity.Burst.Intrinsics.v128 vuzp1q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251627c*/ Unity.Burst.Intrinsics.v128 vuzp1q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25162bc*/ Unity.Burst.Intrinsics.v64 vuzp1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25162c4*/ Unity.Burst.Intrinsics.v128 vuzp1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25162cc*/ Unity.Burst.Intrinsics.v64 vuzp1_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25162d4*/ Unity.Burst.Intrinsics.v128 vuzp1q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25162dc*/ Unity.Burst.Intrinsics.v64 vuzp1_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25162e4*/ Unity.Burst.Intrinsics.v128 vuzp1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25162ec*/ Unity.Burst.Intrinsics.v128 vuzp1q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25162f4*/ Unity.Burst.Intrinsics.v64 vuzp1_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25162fc*/ Unity.Burst.Intrinsics.v128 vuzp1q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516304*/ Unity.Burst.Intrinsics.v128 vuzp1q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251630c*/ Unity.Burst.Intrinsics.v64 vuzp2_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251634c*/ Unity.Burst.Intrinsics.v128 vuzp2q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251638c*/ Unity.Burst.Intrinsics.v64 vuzp2_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25163cc*/ Unity.Burst.Intrinsics.v128 vuzp2q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251640c*/ Unity.Burst.Intrinsics.v64 vuzp2_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251644c*/ Unity.Burst.Intrinsics.v128 vuzp2q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251648c*/ Unity.Burst.Intrinsics.v128 vuzp2q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25164cc*/ Unity.Burst.Intrinsics.v64 vuzp2_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25164d4*/ Unity.Burst.Intrinsics.v128 vuzp2q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25164dc*/ Unity.Burst.Intrinsics.v64 vuzp2_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25164e4*/ Unity.Burst.Intrinsics.v128 vuzp2q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25164ec*/ Unity.Burst.Intrinsics.v64 vuzp2_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25164f4*/ Unity.Burst.Intrinsics.v128 vuzp2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25164fc*/ Unity.Burst.Intrinsics.v128 vuzp2q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516504*/ Unity.Burst.Intrinsics.v64 vuzp2_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251650c*/ Unity.Burst.Intrinsics.v128 vuzp2q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516514*/ Unity.Burst.Intrinsics.v128 vuzp2q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251651c*/ Unity.Burst.Intrinsics.v64 vtrn1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251655c*/ Unity.Burst.Intrinsics.v128 vtrn1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251659c*/ Unity.Burst.Intrinsics.v64 vtrn1_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25165dc*/ Unity.Burst.Intrinsics.v128 vtrn1q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251661c*/ Unity.Burst.Intrinsics.v64 vtrn1_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251665c*/ Unity.Burst.Intrinsics.v128 vtrn1q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251669c*/ Unity.Burst.Intrinsics.v128 vtrn1q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25166dc*/ Unity.Burst.Intrinsics.v64 vtrn1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25166e4*/ Unity.Burst.Intrinsics.v128 vtrn1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25166ec*/ Unity.Burst.Intrinsics.v64 vtrn1_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25166f4*/ Unity.Burst.Intrinsics.v128 vtrn1q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25166fc*/ Unity.Burst.Intrinsics.v64 vtrn1_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2516704*/ Unity.Burst.Intrinsics.v128 vtrn1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251670c*/ Unity.Burst.Intrinsics.v128 vtrn1q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516714*/ Unity.Burst.Intrinsics.v64 vtrn1_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251671c*/ Unity.Burst.Intrinsics.v128 vtrn1q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516724*/ Unity.Burst.Intrinsics.v128 vtrn1q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251672c*/ Unity.Burst.Intrinsics.v64 vtrn2_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251676c*/ Unity.Burst.Intrinsics.v128 vtrn2q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25167ac*/ Unity.Burst.Intrinsics.v64 vtrn2_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25167ec*/ Unity.Burst.Intrinsics.v128 vtrn2q_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251682c*/ Unity.Burst.Intrinsics.v64 vtrn2_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251686c*/ Unity.Burst.Intrinsics.v128 vtrn2q_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25168ac*/ Unity.Burst.Intrinsics.v128 vtrn2q_s64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25168ec*/ Unity.Burst.Intrinsics.v64 vtrn2_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25168f4*/ Unity.Burst.Intrinsics.v128 vtrn2q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25168fc*/ Unity.Burst.Intrinsics.v64 vtrn2_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2516904*/ Unity.Burst.Intrinsics.v128 vtrn2q_u16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251690c*/ Unity.Burst.Intrinsics.v64 vtrn2_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2516914*/ Unity.Burst.Intrinsics.v128 vtrn2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251691c*/ Unity.Burst.Intrinsics.v128 vtrn2q_u64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516924*/ Unity.Burst.Intrinsics.v64 vtrn2_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251692c*/ Unity.Burst.Intrinsics.v128 vtrn2q_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516934*/ Unity.Burst.Intrinsics.v128 vtrn2q_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251693c*/ Unity.Burst.Intrinsics.v64 vqtbl1_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x251697c*/ Unity.Burst.Intrinsics.v128 vqtbl1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25169bc*/ Unity.Burst.Intrinsics.v64 vqtbl1_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25169c4*/ Unity.Burst.Intrinsics.v128 vqtbl1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25169cc*/ Unity.Burst.Intrinsics.v64 vqtbx1_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2516a0c*/ Unity.Burst.Intrinsics.v128 vqtbx1q_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516a4c*/ Unity.Burst.Intrinsics.v64 vqtbx1_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2516a54*/ Unity.Burst.Intrinsics.v128 vqtbx1q_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516a5c*/ double vget_lane_f64(Unity.Burst.Intrinsics.v64 a0, int a1);
                    static /*0x2516a64*/ double vgetq_lane_f64(Unity.Burst.Intrinsics.v128 a0, int a1);
                    static /*0x2516aa4*/ Unity.Burst.Intrinsics.v64 vset_lane_f64(double a0, Unity.Burst.Intrinsics.v64 a1, int a2);
                    static /*0x2516ac4*/ Unity.Burst.Intrinsics.v128 vsetq_lane_f64(double a0, Unity.Burst.Intrinsics.v128 a1, int a2);
                    static /*0x2516b04*/ float vrecpxs_f32(float a0);
                    static /*0x2516b44*/ double vrecpxd_f64(double a0);
                    static /*0x2516b84*/ Unity.Burst.Intrinsics.v64 vfms_n_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, float a2);
                    static /*0x2516bc4*/ Unity.Burst.Intrinsics.v128 vfmsq_n_f32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, float a2);
                    static /*0x2516c04*/ Unity.Burst.Intrinsics.v64 vfma_n_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, double a2);
                    static /*0x2516c44*/ Unity.Burst.Intrinsics.v128 vfmaq_n_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, double a2);
                    static /*0x2516c84*/ Unity.Burst.Intrinsics.v64 vfms_n_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, double a2);
                    static /*0x2516cc4*/ Unity.Burst.Intrinsics.v128 vfmsq_n_f64(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, double a2);
                    static /*0x2516d04*/ bool get_IsNeonCryptoSupported();
                    static /*0x2516d0c*/ Unity.Burst.Intrinsics.v128 vsha1cq_u32(Unity.Burst.Intrinsics.v128 a0, uint a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516d4c*/ Unity.Burst.Intrinsics.v128 vsha1pq_u32(Unity.Burst.Intrinsics.v128 a0, uint a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516d8c*/ Unity.Burst.Intrinsics.v128 vsha1mq_u32(Unity.Burst.Intrinsics.v128 a0, uint a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516dcc*/ uint vsha1h_u32(uint a0);
                    static /*0x2516e0c*/ Unity.Burst.Intrinsics.v128 vsha1su0q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516e4c*/ Unity.Burst.Intrinsics.v128 vsha1su1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516e8c*/ Unity.Burst.Intrinsics.v128 vsha256hq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516ecc*/ Unity.Burst.Intrinsics.v128 vsha256h2q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516f0c*/ Unity.Burst.Intrinsics.v128 vsha256su0q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2516f4c*/ Unity.Burst.Intrinsics.v128 vsha256su1q_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2516f8c*/ uint __crc32b(uint a0, byte a1);
                    static /*0x2516fcc*/ uint __crc32h(uint a0, ushort a1);
                    static /*0x251700c*/ uint __crc32w(uint a0, uint a1);
                    static /*0x251704c*/ uint __crc32d(uint a0, ulong a1);
                    static /*0x251708c*/ uint __crc32cb(uint a0, byte a1);
                    static /*0x25170cc*/ uint __crc32ch(uint a0, ushort a1);
                    static /*0x251710c*/ uint __crc32cw(uint a0, uint a1);
                    static /*0x251714c*/ uint __crc32cd(uint a0, ulong a1);
                    static /*0x251718c*/ Unity.Burst.Intrinsics.v128 vaeseq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x25171cc*/ Unity.Burst.Intrinsics.v128 vaesdq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x251720c*/ Unity.Burst.Intrinsics.v128 vaesmcq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x251724c*/ Unity.Burst.Intrinsics.v128 vaesimcq_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x251728c*/ bool get_IsNeonDotProdSupported();
                    static /*0x2517294*/ Unity.Burst.Intrinsics.v64 vdot_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25172d4*/ Unity.Burst.Intrinsics.v64 vdot_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x2517314*/ Unity.Burst.Intrinsics.v128 vdotq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2517354*/ Unity.Burst.Intrinsics.v128 vdotq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x2517394*/ Unity.Burst.Intrinsics.v64 vdot_lane_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25173d4*/ Unity.Burst.Intrinsics.v64 vdot_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517414*/ Unity.Burst.Intrinsics.v128 vdotq_laneq_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517454*/ Unity.Burst.Intrinsics.v128 vdotq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517494*/ Unity.Burst.Intrinsics.v64 vdot_laneq_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x25174d4*/ Unity.Burst.Intrinsics.v64 vdot_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517514*/ Unity.Burst.Intrinsics.v128 vdotq_lane_u32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517554*/ Unity.Burst.Intrinsics.v128 vdotq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517594*/ bool get_IsNeonRDMASupported();
                    static /*0x251759c*/ Unity.Burst.Intrinsics.v64 vqrdmlah_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25175dc*/ Unity.Burst.Intrinsics.v64 vqrdmlah_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x251761c*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x251765c*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x251769c*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x25176dc*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2);
                    static /*0x251771c*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x251775c*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2);
                    static /*0x251779c*/ Unity.Burst.Intrinsics.v64 vqrdmlah_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25177dc*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x251781c*/ Unity.Burst.Intrinsics.v64 vqrdmlah_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x251785c*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x251789c*/ Unity.Burst.Intrinsics.v64 vqrdmlah_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25178dc*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x251791c*/ Unity.Burst.Intrinsics.v64 vqrdmlah_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x251795c*/ Unity.Burst.Intrinsics.v128 vqrdmlahq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x251799c*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_lane_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x25179dc*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_lane_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517a1c*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_laneq_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517a5c*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_laneq_s16(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517a9c*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_lane_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517adc*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_lane_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517b1c*/ Unity.Burst.Intrinsics.v64 vqrdmlsh_laneq_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517b5c*/ Unity.Burst.Intrinsics.v128 vqrdmlshq_laneq_s32(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517b9c*/ short vqrdmlahh_s16(short a0, short a1, short a2);
                    static /*0x2517bdc*/ int vqrdmlahs_s32(int a0, int a1, int a2);
                    static /*0x2517c1c*/ short vqrdmlshh_s16(short a0, short a1, short a2);
                    static /*0x2517c5c*/ int vqrdmlshs_s32(int a0, int a1, int a2);
                    static /*0x2517c9c*/ short vqrdmlahh_lane_s16(short a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517cdc*/ short vqrdmlahh_laneq_s16(short a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517d1c*/ int vqrdmlahs_lane_s32(int a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517d5c*/ short vqrdmlshh_lane_s16(short a0, short a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517d9c*/ short vqrdmlshh_laneq_s16(short a0, short a1, Unity.Burst.Intrinsics.v128 a2, int a3);
                    static /*0x2517ddc*/ int vqrdmlshs_lane_s32(int a0, int a1, Unity.Burst.Intrinsics.v64 a2, int a3);
                    static /*0x2517e1c*/ Unity.Burst.Intrinsics.v64 vcreate_s8(ulong a0);
                    static /*0x2517e40*/ Unity.Burst.Intrinsics.v64 vcreate_s16(ulong a0);
                    static /*0x2517e64*/ Unity.Burst.Intrinsics.v64 vcreate_s32(ulong a0);
                    static /*0x2517e88*/ Unity.Burst.Intrinsics.v64 vcreate_s64(ulong a0);
                    static /*0x2517eac*/ Unity.Burst.Intrinsics.v64 vcreate_u8(ulong a0);
                    static /*0x2517ed0*/ Unity.Burst.Intrinsics.v64 vcreate_u16(ulong a0);
                    static /*0x2517ef4*/ Unity.Burst.Intrinsics.v64 vcreate_u32(ulong a0);
                    static /*0x2517f18*/ Unity.Burst.Intrinsics.v64 vcreate_u64(ulong a0);
                    static /*0x2517f3c*/ Unity.Burst.Intrinsics.v64 vcreate_f16(ulong a0);
                    static /*0x2517f60*/ Unity.Burst.Intrinsics.v64 vcreate_f32(ulong a0);
                    static /*0x2517f84*/ Unity.Burst.Intrinsics.v64 vcreate_f64(ulong a0);
                    static /*0x2517fa8*/ Unity.Burst.Intrinsics.v64 vdup_n_s8(sbyte a0);
                    static /*0x2517fcc*/ Unity.Burst.Intrinsics.v128 vdupq_n_s8(sbyte a0);
                    static /*0x2518018*/ Unity.Burst.Intrinsics.v64 vdup_n_s16(short a0);
                    static /*0x251803c*/ Unity.Burst.Intrinsics.v128 vdupq_n_s16(short a0);
                    static /*0x2518088*/ Unity.Burst.Intrinsics.v64 vdup_n_s32(int a0);
                    static /*0x25180ac*/ Unity.Burst.Intrinsics.v128 vdupq_n_s32(int a0);
                    static /*0x25180f8*/ Unity.Burst.Intrinsics.v64 vdup_n_s64(long a0);
                    static /*0x251811c*/ Unity.Burst.Intrinsics.v128 vdupq_n_s64(long a0);
                    static /*0x2518168*/ Unity.Burst.Intrinsics.v64 vdup_n_u8(byte a0);
                    static /*0x251818c*/ Unity.Burst.Intrinsics.v128 vdupq_n_u8(byte a0);
                    static /*0x25181d8*/ Unity.Burst.Intrinsics.v64 vdup_n_u16(ushort a0);
                    static /*0x25181fc*/ Unity.Burst.Intrinsics.v128 vdupq_n_u16(ushort a0);
                    static /*0x2518248*/ Unity.Burst.Intrinsics.v64 vdup_n_u32(uint a0);
                    static /*0x251826c*/ Unity.Burst.Intrinsics.v128 vdupq_n_u32(uint a0);
                    static /*0x25182b8*/ Unity.Burst.Intrinsics.v64 vdup_n_u64(ulong a0);
                    static /*0x25182dc*/ Unity.Burst.Intrinsics.v128 vdupq_n_u64(ulong a0);
                    static /*0x2518328*/ Unity.Burst.Intrinsics.v64 vdup_n_f32(float a0);
                    static /*0x2518348*/ Unity.Burst.Intrinsics.v128 vdupq_n_f32(float a0);
                    static /*0x2518390*/ Unity.Burst.Intrinsics.v64 vdup_n_f64(double a0);
                    static /*0x25183b0*/ Unity.Burst.Intrinsics.v128 vdupq_n_f64(double a0);
                    static /*0x25183f8*/ Unity.Burst.Intrinsics.v64 vmov_n_s8(sbyte a0);
                    static /*0x251841c*/ Unity.Burst.Intrinsics.v128 vmovq_n_s8(sbyte a0);
                    static /*0x2518468*/ Unity.Burst.Intrinsics.v64 vmov_n_s16(short a0);
                    static /*0x251848c*/ Unity.Burst.Intrinsics.v128 vmovq_n_s16(short a0);
                    static /*0x25184d8*/ Unity.Burst.Intrinsics.v64 vmov_n_s32(int a0);
                    static /*0x25184fc*/ Unity.Burst.Intrinsics.v128 vmovq_n_s32(int a0);
                    static /*0x2518548*/ Unity.Burst.Intrinsics.v64 vmov_n_s64(long a0);
                    static /*0x251856c*/ Unity.Burst.Intrinsics.v128 vmovq_n_s64(long a0);
                    static /*0x25185b8*/ Unity.Burst.Intrinsics.v64 vmov_n_u8(byte a0);
                    static /*0x25185dc*/ Unity.Burst.Intrinsics.v128 vmovq_n_u8(byte a0);
                    static /*0x2518628*/ Unity.Burst.Intrinsics.v64 vmov_n_u16(ushort a0);
                    static /*0x251864c*/ Unity.Burst.Intrinsics.v128 vmovq_n_u16(ushort a0);
                    static /*0x2518698*/ Unity.Burst.Intrinsics.v64 vmov_n_u32(uint a0);
                    static /*0x25186bc*/ Unity.Burst.Intrinsics.v128 vmovq_n_u32(uint a0);
                    static /*0x2518708*/ Unity.Burst.Intrinsics.v64 vmov_n_u64(ulong a0);
                    static /*0x251872c*/ Unity.Burst.Intrinsics.v128 vmovq_n_u64(ulong a0);
                    static /*0x2518778*/ Unity.Burst.Intrinsics.v64 vmov_n_f32(float a0);
                    static /*0x2518798*/ Unity.Burst.Intrinsics.v128 vmovq_n_f32(float a0);
                    static /*0x25187e0*/ Unity.Burst.Intrinsics.v64 vmov_n_f64(double a0);
                    static /*0x2518800*/ Unity.Burst.Intrinsics.v128 vmovq_n_f64(double a0);
                    static /*0x2518848*/ Unity.Burst.Intrinsics.v128 vcombine_s8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518898*/ Unity.Burst.Intrinsics.v128 vcombine_s16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25188e8*/ Unity.Burst.Intrinsics.v128 vcombine_s32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518938*/ Unity.Burst.Intrinsics.v128 vcombine_s64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518988*/ Unity.Burst.Intrinsics.v128 vcombine_u8(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x25189d8*/ Unity.Burst.Intrinsics.v128 vcombine_u16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518a28*/ Unity.Burst.Intrinsics.v128 vcombine_u32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518a78*/ Unity.Burst.Intrinsics.v128 vcombine_u64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518ac8*/ Unity.Burst.Intrinsics.v128 vcombine_f16(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518b18*/ Unity.Burst.Intrinsics.v128 vcombine_f32(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518b68*/ Unity.Burst.Intrinsics.v128 vcombine_f64(Unity.Burst.Intrinsics.v64 a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518bb8*/ Unity.Burst.Intrinsics.v64 vget_high_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518bc0*/ Unity.Burst.Intrinsics.v64 vget_high_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518bc8*/ Unity.Burst.Intrinsics.v64 vget_high_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518bd0*/ Unity.Burst.Intrinsics.v64 vget_high_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518bd8*/ Unity.Burst.Intrinsics.v64 vget_high_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518be0*/ Unity.Burst.Intrinsics.v64 vget_high_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518be8*/ Unity.Burst.Intrinsics.v64 vget_high_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518bf0*/ Unity.Burst.Intrinsics.v64 vget_high_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518bf8*/ Unity.Burst.Intrinsics.v64 vget_high_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c00*/ Unity.Burst.Intrinsics.v64 vget_high_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c08*/ Unity.Burst.Intrinsics.v64 vget_low_s8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c0c*/ Unity.Burst.Intrinsics.v64 vget_low_s16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c10*/ Unity.Burst.Intrinsics.v64 vget_low_s32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c14*/ Unity.Burst.Intrinsics.v64 vget_low_s64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c18*/ Unity.Burst.Intrinsics.v64 vget_low_u8(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c1c*/ Unity.Burst.Intrinsics.v64 vget_low_u16(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c20*/ Unity.Burst.Intrinsics.v64 vget_low_u32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c24*/ Unity.Burst.Intrinsics.v64 vget_low_u64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c28*/ Unity.Burst.Intrinsics.v64 vget_low_f32(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c2c*/ Unity.Burst.Intrinsics.v64 vget_low_f64(Unity.Burst.Intrinsics.v128 a0);
                    static /*0x2518c30*/ Unity.Burst.Intrinsics.v64 vld1_s8(sbyte* a0);
                    static /*0x2518c38*/ Unity.Burst.Intrinsics.v128 vld1q_s8(sbyte* a0);
                    static /*0x2518c44*/ Unity.Burst.Intrinsics.v64 vld1_s16(short* a0);
                    static /*0x2518c4c*/ Unity.Burst.Intrinsics.v128 vld1q_s16(short* a0);
                    static /*0x2518c58*/ Unity.Burst.Intrinsics.v64 vld1_s32(int* a0);
                    static /*0x2518c60*/ Unity.Burst.Intrinsics.v128 vld1q_s32(int* a0);
                    static /*0x2518c6c*/ Unity.Burst.Intrinsics.v64 vld1_s64(long* a0);
                    static /*0x2518c74*/ Unity.Burst.Intrinsics.v128 vld1q_s64(long* a0);
                    static /*0x2518c80*/ Unity.Burst.Intrinsics.v64 vld1_u8(byte* a0);
                    static /*0x2518c88*/ Unity.Burst.Intrinsics.v128 vld1q_u8(byte* a0);
                    static /*0x2518c94*/ Unity.Burst.Intrinsics.v64 vld1_u16(ushort* a0);
                    static /*0x2518c9c*/ Unity.Burst.Intrinsics.v128 vld1q_u16(ushort* a0);
                    static /*0x2518ca8*/ Unity.Burst.Intrinsics.v64 vld1_u32(uint* a0);
                    static /*0x2518cb0*/ Unity.Burst.Intrinsics.v128 vld1q_u32(uint* a0);
                    static /*0x2518cbc*/ Unity.Burst.Intrinsics.v64 vld1_u64(ulong* a0);
                    static /*0x2518cc4*/ Unity.Burst.Intrinsics.v128 vld1q_u64(ulong* a0);
                    static /*0x2518cd0*/ Unity.Burst.Intrinsics.v64 vld1_f32(float* a0);
                    static /*0x2518cd8*/ Unity.Burst.Intrinsics.v128 vld1q_f32(float* a0);
                    static /*0x2518ce4*/ Unity.Burst.Intrinsics.v64 vld1_f64(double* a0);
                    static /*0x2518cec*/ Unity.Burst.Intrinsics.v128 vld1q_f64(double* a0);
                    static /*0x2518cf8*/ void vst1_s8(sbyte* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d00*/ void vst1q_s8(sbyte* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d08*/ void vst1_s16(short* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d10*/ void vst1q_s16(short* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d18*/ void vst1_s32(int* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d20*/ void vst1q_s32(int* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d28*/ void vst1_s64(long* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d30*/ void vst1q_s64(long* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d38*/ void vst1_u8(byte* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d40*/ void vst1q_u8(byte* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d48*/ void vst1_u16(ushort* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d50*/ void vst1q_u16(ushort* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d58*/ void vst1_u32(uint* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d60*/ void vst1q_u32(uint* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d68*/ void vst1_u64(ulong* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d70*/ void vst1q_u64(ulong* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d78*/ void vst1_f32(float* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d80*/ void vst1q_f32(float* a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x2518d88*/ void vst1_f64(double* a0, Unity.Burst.Intrinsics.v64 a1);
                    static /*0x2518d90*/ void vst1q_f64(double* a0, Unity.Burst.Intrinsics.v128 a1);
                    /*0x2518d98*/ Neon();
                }
            }

            class Common
            {
                static /*0x2518df0*/ void Pause();
                static /*0x2518df4*/ ulong umul128(ulong x, ulong y, ref ulong high);
            }

            class BurstTargetCpuAttribute : System.Attribute
            {
                /*0x10*/ Unity.Burst.BurstTargetCpu TargetCpu;

                /*0x2518e30*/ BurstTargetCpuAttribute(Unity.Burst.BurstTargetCpu TargetCpu);
            }

            class V64DebugView
            {
                /*0x10*/ Unity.Burst.Intrinsics.v64 m_Value;

                /*0x2518e58*/ V64DebugView(Unity.Burst.Intrinsics.v64 value);
                /*0x2518e80*/ byte[] get_Byte();
                /*0x2518f58*/ sbyte[] get_SByte();
                /*0x2519030*/ ushort[] get_UShort();
                /*0x25190c8*/ short[] get_SShort();
                /*0x2519160*/ uint[] get_UInt();
                /*0x25191d8*/ int[] get_SInt();
                /*0x2519250*/ float[] get_Float();
                /*0x25192c8*/ long[] get_SLong();
                /*0x2519330*/ ulong[] get_ULong();
                /*0x2519398*/ double[] get_Double();
            }

            class V128DebugView
            {
                /*0x10*/ Unity.Burst.Intrinsics.v128 m_Value;

                /*0x2519400*/ V128DebugView(Unity.Burst.Intrinsics.v128 value);
                /*0x251942c*/ byte[] get_Byte();
                /*0x2519584*/ sbyte[] get_SByte();
                /*0x25196dc*/ ushort[] get_UShort();
                /*0x25197b4*/ short[] get_SShort();
                /*0x251988c*/ uint[] get_UInt();
                /*0x2519924*/ int[] get_SInt();
                /*0x25199bc*/ float[] get_Float();
                /*0x2519a54*/ long[] get_SLong();
                /*0x2519acc*/ ulong[] get_ULong();
                /*0x2519b44*/ double[] get_Double();
            }

            class V256DebugView
            {
                /*0x10*/ Unity.Burst.Intrinsics.v256 m_Value;

                /*0x2519bbc*/ V256DebugView(Unity.Burst.Intrinsics.v256 value);
                /*0x2519be8*/ byte[] get_Byte();
                /*0x2519e40*/ sbyte[] get_SByte();
                /*0x251a098*/ ushort[] get_UShort();
                /*0x251a1f0*/ short[] get_SShort();
                /*0x251a348*/ uint[] get_UInt();
                /*0x251a420*/ int[] get_SInt();
                /*0x251a4f8*/ float[] get_Float();
                /*0x251a5d0*/ long[] get_SLong();
                /*0x251a668*/ ulong[] get_ULong();
                /*0x251a700*/ double[] get_Double();
            }

            struct v128
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
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x18*/ sbyte SByte8;
                /*0x19*/ sbyte SByte9;
                /*0x1a*/ sbyte SByte10;
                /*0x1b*/ sbyte SByte11;
                /*0x1c*/ sbyte SByte12;
                /*0x1d*/ sbyte SByte13;
                /*0x1e*/ sbyte SByte14;
                /*0x1f*/ sbyte SByte15;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x18*/ ushort UShort4;
                /*0x1a*/ ushort UShort5;
                /*0x1c*/ ushort UShort6;
                /*0x1e*/ ushort UShort7;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x18*/ short SShort4;
                /*0x1a*/ short SShort5;
                /*0x1c*/ short SShort6;
                /*0x1e*/ short SShort7;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x18*/ uint UInt2;
                /*0x1c*/ uint UInt3;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x18*/ int SInt2;
                /*0x1c*/ int SInt3;
                /*0x10*/ ulong ULong0;
                /*0x18*/ ulong ULong1;
                /*0x10*/ long SLong0;
                /*0x18*/ long SLong1;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x18*/ float Float2;
                /*0x1c*/ float Float3;
                /*0x10*/ double Double0;
                /*0x18*/ double Double1;
                /*0x10*/ Unity.Burst.Intrinsics.v64 Lo64;
                /*0x18*/ Unity.Burst.Intrinsics.v64 Hi64;

                /*0x251a798*/ v128(byte b);
                /*0x251a7ac*/ v128(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p);
                /*0x251a814*/ v128(sbyte b);
                /*0x251a828*/ v128(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p);
                /*0x251a890*/ v128(short v);
                /*0x251a89c*/ v128(short a, short b, short c, short d, short e, short f, short g, short h);
                /*0x251a8c4*/ v128(ushort v);
                /*0x251a8d0*/ v128(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h);
                /*0x251a8f8*/ v128(int v);
                /*0x251a904*/ v128(int a, int b, int c, int d);
                /*0x251a910*/ v128(uint v);
                /*0x251a91c*/ v128(uint a, uint b, uint c, uint d);
                /*0x251a928*/ v128(float f);
                /*0x251a934*/ v128(float a, float b, float c, float d);
                /*0x251a940*/ v128(double f);
                /*0x251a948*/ v128(double a, double b);
                /*0x251a950*/ v128(long f);
                /*0x251a958*/ v128(long a, long b);
                /*0x251a960*/ v128(ulong f);
                /*0x251a968*/ v128(ulong a, ulong b);
                /*0x251a970*/ v128(Unity.Burst.Intrinsics.v64 lo, Unity.Burst.Intrinsics.v64 hi);
            }

            struct v256
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
                /*0x20*/ byte Byte16;
                /*0x21*/ byte Byte17;
                /*0x22*/ byte Byte18;
                /*0x23*/ byte Byte19;
                /*0x24*/ byte Byte20;
                /*0x25*/ byte Byte21;
                /*0x26*/ byte Byte22;
                /*0x27*/ byte Byte23;
                /*0x28*/ byte Byte24;
                /*0x29*/ byte Byte25;
                /*0x2a*/ byte Byte26;
                /*0x2b*/ byte Byte27;
                /*0x2c*/ byte Byte28;
                /*0x2d*/ byte Byte29;
                /*0x2e*/ byte Byte30;
                /*0x2f*/ byte Byte31;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x18*/ sbyte SByte8;
                /*0x19*/ sbyte SByte9;
                /*0x1a*/ sbyte SByte10;
                /*0x1b*/ sbyte SByte11;
                /*0x1c*/ sbyte SByte12;
                /*0x1d*/ sbyte SByte13;
                /*0x1e*/ sbyte SByte14;
                /*0x1f*/ sbyte SByte15;
                /*0x20*/ sbyte SByte16;
                /*0x21*/ sbyte SByte17;
                /*0x22*/ sbyte SByte18;
                /*0x23*/ sbyte SByte19;
                /*0x24*/ sbyte SByte20;
                /*0x25*/ sbyte SByte21;
                /*0x26*/ sbyte SByte22;
                /*0x27*/ sbyte SByte23;
                /*0x28*/ sbyte SByte24;
                /*0x29*/ sbyte SByte25;
                /*0x2a*/ sbyte SByte26;
                /*0x2b*/ sbyte SByte27;
                /*0x2c*/ sbyte SByte28;
                /*0x2d*/ sbyte SByte29;
                /*0x2e*/ sbyte SByte30;
                /*0x2f*/ sbyte SByte31;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x18*/ ushort UShort4;
                /*0x1a*/ ushort UShort5;
                /*0x1c*/ ushort UShort6;
                /*0x1e*/ ushort UShort7;
                /*0x20*/ ushort UShort8;
                /*0x22*/ ushort UShort9;
                /*0x24*/ ushort UShort10;
                /*0x26*/ ushort UShort11;
                /*0x28*/ ushort UShort12;
                /*0x2a*/ ushort UShort13;
                /*0x2c*/ ushort UShort14;
                /*0x2e*/ ushort UShort15;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x18*/ short SShort4;
                /*0x1a*/ short SShort5;
                /*0x1c*/ short SShort6;
                /*0x1e*/ short SShort7;
                /*0x20*/ short SShort8;
                /*0x22*/ short SShort9;
                /*0x24*/ short SShort10;
                /*0x26*/ short SShort11;
                /*0x28*/ short SShort12;
                /*0x2a*/ short SShort13;
                /*0x2c*/ short SShort14;
                /*0x2e*/ short SShort15;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x18*/ uint UInt2;
                /*0x1c*/ uint UInt3;
                /*0x20*/ uint UInt4;
                /*0x24*/ uint UInt5;
                /*0x28*/ uint UInt6;
                /*0x2c*/ uint UInt7;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x18*/ int SInt2;
                /*0x1c*/ int SInt3;
                /*0x20*/ int SInt4;
                /*0x24*/ int SInt5;
                /*0x28*/ int SInt6;
                /*0x2c*/ int SInt7;
                /*0x10*/ ulong ULong0;
                /*0x18*/ ulong ULong1;
                /*0x20*/ ulong ULong2;
                /*0x28*/ ulong ULong3;
                /*0x10*/ long SLong0;
                /*0x18*/ long SLong1;
                /*0x20*/ long SLong2;
                /*0x28*/ long SLong3;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x18*/ float Float2;
                /*0x1c*/ float Float3;
                /*0x20*/ float Float4;
                /*0x24*/ float Float5;
                /*0x28*/ float Float6;
                /*0x2c*/ float Float7;
                /*0x10*/ double Double0;
                /*0x18*/ double Double1;
                /*0x20*/ double Double2;
                /*0x28*/ double Double3;
                /*0x10*/ Unity.Burst.Intrinsics.v128 Lo128;
                /*0x20*/ Unity.Burst.Intrinsics.v128 Hi128;

                /*0x251a978*/ v256(byte b);
                /*0x251a990*/ v256(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p, byte q, byte r, byte s, byte t, byte u, byte v, byte w, byte x, byte y, byte z, byte A, byte B, byte C, byte D, byte E, byte F);
                /*0x251aa78*/ v256(sbyte b);
                /*0x251aa90*/ v256(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p, sbyte q, sbyte r, sbyte s, sbyte t, sbyte u, sbyte v, sbyte w, sbyte x, sbyte y, sbyte z, sbyte A, sbyte B, sbyte C, sbyte D, sbyte E, sbyte F);
                /*0x251ab78*/ v256(short v);
                /*0x251ab84*/ v256(short a, short b, short c, short d, short e, short f, short g, short h, short i, short j, short k, short l, short m, short n, short o, short p);
                /*0x251abec*/ v256(ushort v);
                /*0x251abf8*/ v256(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h, ushort i, ushort j, ushort k, ushort l, ushort m, ushort n, ushort o, ushort p);
                /*0x251ac60*/ v256(int v);
                /*0x251ac6c*/ v256(int a, int b, int c, int d, int e, int f, int g, int h);
                /*0x251ac84*/ v256(uint v);
                /*0x251ac90*/ v256(uint a, uint b, uint c, uint d, uint e, uint f, uint g, uint h);
                /*0x251aca8*/ v256(float f);
                /*0x251acb4*/ v256(float a, float b, float c, float d, float e, float f, float g, float h);
                /*0x251acc8*/ v256(double f);
                /*0x251acd4*/ v256(double a, double b, double c, double d);
                /*0x251ace0*/ v256(long f);
                /*0x251acec*/ v256(long a, long b, long c, long d);
                /*0x251acf8*/ v256(ulong f);
                /*0x251ad04*/ v256(ulong a, ulong b, ulong c, ulong d);
                /*0x251ad10*/ v256(Unity.Burst.Intrinsics.v128 lo, Unity.Burst.Intrinsics.v128 hi);
            }

            struct v64
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x10*/ ulong ULong0;
                /*0x10*/ long SLong0;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x10*/ double Double0;

                /*0x251ad1c*/ v64(byte b);
                /*0x251ad28*/ v64(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h);
                /*0x251ad50*/ v64(sbyte b);
                /*0x251ad5c*/ v64(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h);
                /*0x251ad84*/ v64(short v);
                /*0x251ad90*/ v64(short a, short b, short c, short d);
                /*0x251ada4*/ v64(ushort v);
                /*0x251adb0*/ v64(ushort a, ushort b, ushort c, ushort d);
                /*0x251adc4*/ v64(int v);
                /*0x251adcc*/ v64(int a, int b);
                /*0x251add4*/ v64(uint v);
                /*0x251addc*/ v64(uint a, uint b);
                /*0x251ade4*/ v64(float f);
                /*0x251adec*/ v64(float a, float b);
                /*0x251adf4*/ v64(double a);
                /*0x251adfc*/ v64(long a);
                /*0x251ae04*/ v64(ulong a);
            }

            class X86
            {
                static /*0x251ae0c*/ Unity.Burst.Intrinsics.v128 GenericCSharpLoad(void* ptr);
                static /*0x251ae18*/ void GenericCSharpStore(void* ptr, Unity.Burst.Intrinsics.v128 val);
                static /*0x251ae20*/ sbyte Saturate_To_Int8(int val);
                static /*0x251ae40*/ byte Saturate_To_UnsignedInt8(int val);
                static /*0x251ae58*/ short Saturate_To_Int16(int val);
                static /*0x251ae78*/ ushort Saturate_To_UnsignedInt16(int val);
                static /*0x251ae90*/ bool IsNaN(uint v);
                static /*0x251aea4*/ bool IsNaN(ulong v);
                static /*0x251aeb8*/ void BurstIntrinsicSetCSRFromManaged(int _);
                static /*0x251aebc*/ int BurstIntrinsicGetCSRFromManaged();
                static /*0x251aec4*/ int getcsr_raw();
                static /*0x251aed4*/ void setcsr_raw(int bits);
                static /*0x251aed8*/ void DoSetCSRTrampoline(int bits);
                static /*0x251aecc*/ int DoGetCSRTrampoline();
                static /*0x251aee4*/ Unity.Burst.Intrinsics.X86.MXCSRBits get_MXCSR();
                static /*0x251aeec*/ void set_MXCSR(Unity.Burst.Intrinsics.X86.MXCSRBits value);

                class Avx
                {
                    static /*0x251aef0*/ bool get_IsAvxSupported();
                    static /*0x251aef8*/ Unity.Burst.Intrinsics.v256 mm256_add_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251af58*/ Unity.Burst.Intrinsics.v256 mm256_add_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b00c*/ Unity.Burst.Intrinsics.v256 mm256_addsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b06c*/ Unity.Burst.Intrinsics.v256 mm256_addsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b0cc*/ Unity.Burst.Intrinsics.v256 mm256_and_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b12c*/ Unity.Burst.Intrinsics.v256 mm256_and_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b150*/ Unity.Burst.Intrinsics.v256 mm256_andnot_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b1b0*/ Unity.Burst.Intrinsics.v256 mm256_andnot_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b1ec*/ Unity.Burst.Intrinsics.v256 mm256_blend_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251b25c*/ Unity.Burst.Intrinsics.v256 mm256_blend_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251b2cc*/ Unity.Burst.Intrinsics.v256 mm256_blendv_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x251b338*/ Unity.Burst.Intrinsics.v256 mm256_blendv_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x251b3a4*/ Unity.Burst.Intrinsics.v256 mm256_div_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b404*/ Unity.Burst.Intrinsics.v256 mm256_div_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b4b8*/ Unity.Burst.Intrinsics.v256 mm256_dp_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251b524*/ Unity.Burst.Intrinsics.v256 mm256_hadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b584*/ Unity.Burst.Intrinsics.v256 mm256_hadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b5e4*/ Unity.Burst.Intrinsics.v256 mm256_hsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b644*/ Unity.Burst.Intrinsics.v256 mm256_hsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b6a4*/ Unity.Burst.Intrinsics.v256 mm256_max_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b704*/ Unity.Burst.Intrinsics.v256 mm256_max_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b864*/ Unity.Burst.Intrinsics.v256 mm256_min_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251b8c4*/ Unity.Burst.Intrinsics.v256 mm256_min_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ba24*/ Unity.Burst.Intrinsics.v256 mm256_mul_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ba84*/ Unity.Burst.Intrinsics.v256 mm256_mul_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251bb38*/ Unity.Burst.Intrinsics.v256 mm256_or_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251bb98*/ Unity.Burst.Intrinsics.v256 mm256_or_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251bbbc*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251bc2c*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251bd08*/ Unity.Burst.Intrinsics.v256 mm256_sub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251bd68*/ Unity.Burst.Intrinsics.v256 mm256_sub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251be1c*/ Unity.Burst.Intrinsics.v256 mm256_xor_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251be7c*/ Unity.Burst.Intrinsics.v256 mm256_xor_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251bea0*/ Unity.Burst.Intrinsics.v128 cmp_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251c1a0*/ Unity.Burst.Intrinsics.v256 mm256_cmp_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251c204*/ Unity.Burst.Intrinsics.v128 cmp_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251c910*/ Unity.Burst.Intrinsics.v256 mm256_cmp_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251c974*/ Unity.Burst.Intrinsics.v128 cmp_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251c98c*/ Unity.Burst.Intrinsics.v128 cmp_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251c9b8*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi32_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251c9dc*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi32_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251ca28*/ Unity.Burst.Intrinsics.v128 mm256_cvtpd_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251ca64*/ Unity.Burst.Intrinsics.v256 mm256_cvtps_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251cab0*/ Unity.Burst.Intrinsics.v256 mm256_cvtps_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251cae4*/ Unity.Burst.Intrinsics.v128 mm256_cvttpd_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251cb40*/ Unity.Burst.Intrinsics.v128 mm256_cvtpd_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251cb7c*/ Unity.Burst.Intrinsics.v256 mm256_cvttps_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251cbc8*/ float mm256_cvtss_f32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251cbd0*/ Unity.Burst.Intrinsics.v128 mm256_extractf128_ps(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x251cbf4*/ Unity.Burst.Intrinsics.v128 mm256_extractf128_pd(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x251cc18*/ Unity.Burst.Intrinsics.v128 mm256_extractf128_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x251cc3c*/ void mm256_zeroall();
                    static /*0x251cc40*/ void mm256_zeroupper();
                    static /*0x251cc44*/ Unity.Burst.Intrinsics.v128 permutevar_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251ccb8*/ Unity.Burst.Intrinsics.v256 mm256_permutevar_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251cd10*/ Unity.Burst.Intrinsics.v128 permute_ps(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x251cd18*/ Unity.Burst.Intrinsics.v256 mm256_permute_ps(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x251cd78*/ Unity.Burst.Intrinsics.v128 permutevar_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251cdd4*/ Unity.Burst.Intrinsics.v256 mm256_permutevar_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ce70*/ Unity.Burst.Intrinsics.v256 mm256_permute_pd(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x251cef0*/ Unity.Burst.Intrinsics.v128 permute_pd(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x251cf44*/ Unity.Burst.Intrinsics.v128 Select4(Unity.Burst.Intrinsics.v256 src1, Unity.Burst.Intrinsics.v256 src2, int control);
                    static /*0x251cf94*/ Unity.Burst.Intrinsics.v256 mm256_permute2f128_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251d018*/ Unity.Burst.Intrinsics.v256 mm256_permute2f128_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251d09c*/ Unity.Burst.Intrinsics.v256 mm256_permute2f128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x251d120*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_ss(void* ptr);
                    static /*0x251d12c*/ Unity.Burst.Intrinsics.v128 broadcast_ss(void* ptr);
                    static /*0x251d13c*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_sd(void* ptr);
                    static /*0x251d14c*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_ps(void* ptr);
                    static /*0x251d168*/ Unity.Burst.Intrinsics.v256 mm256_broadcast_pd(void* ptr);
                    static /*0x251d178*/ Unity.Burst.Intrinsics.v256 mm256_insertf128_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251d1ac*/ Unity.Burst.Intrinsics.v256 mm256_insertf128_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251d1d4*/ Unity.Burst.Intrinsics.v256 mm256_insertf128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251d1fc*/ Unity.Burst.Intrinsics.v256 mm256_load_ps(void* ptr);
                    static /*0x251d208*/ void mm256_store_ps(void* ptr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x251d214*/ Unity.Burst.Intrinsics.v256 mm256_load_pd(void* ptr);
                    static /*0x251d220*/ void mm256_store_pd(void* ptr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d22c*/ Unity.Burst.Intrinsics.v256 mm256_loadu_pd(void* ptr);
                    static /*0x251d238*/ void mm256_storeu_pd(void* ptr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d244*/ Unity.Burst.Intrinsics.v256 mm256_loadu_ps(void* ptr);
                    static /*0x251d250*/ void mm256_storeu_ps(void* ptr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d25c*/ Unity.Burst.Intrinsics.v256 mm256_load_si256(void* ptr);
                    static /*0x251d268*/ void mm256_store_si256(void* ptr, Unity.Burst.Intrinsics.v256 v);
                    static /*0x251d274*/ Unity.Burst.Intrinsics.v256 mm256_loadu_si256(void* ptr);
                    static /*0x251d280*/ void mm256_storeu_si256(void* ptr, Unity.Burst.Intrinsics.v256 v);
                    static /*0x251d28c*/ Unity.Burst.Intrinsics.v256 mm256_loadu2_m128(void* hiaddr, void* loaddr);
                    static /*0x251d2a8*/ Unity.Burst.Intrinsics.v256 mm256_loadu2_m128d(void* hiaddr, void* loaddr);
                    static /*0x251d2b8*/ Unity.Burst.Intrinsics.v256 mm256_loadu2_m128i(void* hiaddr, void* loaddr);
                    static /*0x251d29c*/ Unity.Burst.Intrinsics.v256 mm256_set_m128(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x251d2c8*/ void mm256_storeu2_m128(void* hiaddr, void* loaddr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x251d2e4*/ void mm256_storeu2_m128d(void* hiaddr, void* loaddr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x251d2f8*/ void mm256_storeu2_m128i(void* hiaddr, void* loaddr, Unity.Burst.Intrinsics.v256 val);
                    static /*0x251d30c*/ Unity.Burst.Intrinsics.v128 maskload_pd(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x251d334*/ Unity.Burst.Intrinsics.v256 mm256_maskload_pd(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x251d388*/ void maskstore_pd(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x251d3a4*/ void mm256_maskstore_pd(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d3f0*/ Unity.Burst.Intrinsics.v128 maskload_ps(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x251d440*/ Unity.Burst.Intrinsics.v256 mm256_maskload_ps(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x251d490*/ void maskstore_ps(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x251d4d0*/ void mm256_maskstore_ps(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d50c*/ Unity.Burst.Intrinsics.v256 mm256_movehdup_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d530*/ Unity.Burst.Intrinsics.v256 mm256_moveldup_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d554*/ Unity.Burst.Intrinsics.v256 mm256_movedup_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d568*/ Unity.Burst.Intrinsics.v256 mm256_lddqu_si256(void* mem_addr);
                    static /*0x251d574*/ void mm256_stream_si256(void* mem_addr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d580*/ void mm256_stream_pd(void* mem_addr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d58c*/ void mm256_stream_ps(void* mem_addr, Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d598*/ Unity.Burst.Intrinsics.v256 mm256_rcp_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d628*/ Unity.Burst.Intrinsics.v256 mm256_rsqrt_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d72c*/ Unity.Burst.Intrinsics.v256 mm256_sqrt_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d778*/ Unity.Burst.Intrinsics.v256 mm256_sqrt_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251d868*/ Unity.Burst.Intrinsics.v256 mm256_round_pd(Unity.Burst.Intrinsics.v256 a, int rounding);
                    static /*0x251d8c8*/ Unity.Burst.Intrinsics.v256 mm256_ceil_pd(Unity.Burst.Intrinsics.v256 val);
                    static /*0x251d92c*/ Unity.Burst.Intrinsics.v256 mm256_floor_pd(Unity.Burst.Intrinsics.v256 val);
                    static /*0x251d990*/ Unity.Burst.Intrinsics.v256 mm256_round_ps(Unity.Burst.Intrinsics.v256 a, int rounding);
                    static /*0x251d9f0*/ Unity.Burst.Intrinsics.v256 mm256_ceil_ps(Unity.Burst.Intrinsics.v256 val);
                    static /*0x251da54*/ Unity.Burst.Intrinsics.v256 mm256_floor_ps(Unity.Burst.Intrinsics.v256 val);
                    static /*0x251dab8*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251db18*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251db78*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dbc0*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dc04*/ int mm256_testz_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dc50*/ int mm256_testc_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dc9c*/ int mm256_testnzc_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dd30*/ int mm256_testz_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dd60*/ int mm256_testc_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dd94*/ int mm256_testnzc_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251de5c*/ int testz_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251decc*/ int testc_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251df40*/ int testnzc_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251df94*/ int mm256_testz_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dfc4*/ int mm256_testc_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251dff8*/ int mm256_testnzc_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251e0c0*/ int testz_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251e130*/ int testc_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251e1a4*/ int testnzc_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251e1f8*/ int mm256_movemask_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e230*/ int mm256_movemask_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e2b0*/ Unity.Burst.Intrinsics.v256 mm256_setzero_pd();
                    static /*0x251e2bc*/ Unity.Burst.Intrinsics.v256 mm256_setzero_ps();
                    static /*0x251e2c8*/ Unity.Burst.Intrinsics.v256 mm256_setzero_si256();
                    static /*0x251e2d4*/ Unity.Burst.Intrinsics.v256 mm256_set_pd(double d, double c, double b, double a);
                    static /*0x251e2e0*/ Unity.Burst.Intrinsics.v256 mm256_set_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0);
                    static /*0x251e2f4*/ Unity.Burst.Intrinsics.v256 mm256_set_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_);
                    static /*0x251e3d8*/ Unity.Burst.Intrinsics.v256 mm256_set_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_);
                    static /*0x251e43c*/ Unity.Burst.Intrinsics.v256 mm256_set_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0);
                    static /*0x251e450*/ Unity.Burst.Intrinsics.v256 mm256_set_epi64x(long e3, long e2, long e1, long e0);
                    static /*0x251e45c*/ Unity.Burst.Intrinsics.v256 mm256_set_m128d(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x251e468*/ Unity.Burst.Intrinsics.v256 mm256_set_m128i(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x251e474*/ Unity.Burst.Intrinsics.v256 mm256_setr_pd(double d, double c, double b, double a);
                    static /*0x251e480*/ Unity.Burst.Intrinsics.v256 mm256_setr_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0);
                    static /*0x251e494*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_);
                    static /*0x251e578*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_);
                    static /*0x251e5dc*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0);
                    static /*0x251e5f0*/ Unity.Burst.Intrinsics.v256 mm256_setr_epi64x(long e3, long e2, long e1, long e0);
                    static /*0x251e5fc*/ Unity.Burst.Intrinsics.v256 mm256_setr_m128(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x251e608*/ Unity.Burst.Intrinsics.v256 mm256_setr_m128d(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x251e614*/ Unity.Burst.Intrinsics.v256 mm256_setr_m128i(Unity.Burst.Intrinsics.v128 hi, Unity.Burst.Intrinsics.v128 lo);
                    static /*0x251e620*/ Unity.Burst.Intrinsics.v256 mm256_set1_pd(double a);
                    static /*0x251e62c*/ Unity.Burst.Intrinsics.v256 mm256_set1_ps(float a);
                    static /*0x251e638*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi8(byte a);
                    static /*0x251e650*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi16(short a);
                    static /*0x251e65c*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi32(int a);
                    static /*0x251e668*/ Unity.Burst.Intrinsics.v256 mm256_set1_epi64x(long a);
                    static /*0x251e674*/ Unity.Burst.Intrinsics.v256 mm256_castpd_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e680*/ Unity.Burst.Intrinsics.v256 mm256_castps_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e68c*/ Unity.Burst.Intrinsics.v256 mm256_castps_si256(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e698*/ Unity.Burst.Intrinsics.v256 mm256_castpd_si256(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e6a4*/ Unity.Burst.Intrinsics.v256 mm256_castsi256_ps(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e6b0*/ Unity.Burst.Intrinsics.v256 mm256_castsi256_pd(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e6bc*/ Unity.Burst.Intrinsics.v128 mm256_castps256_ps128(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e6c8*/ Unity.Burst.Intrinsics.v128 mm256_castpd256_pd128(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e6d4*/ Unity.Burst.Intrinsics.v128 mm256_castsi256_si128(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e6e0*/ Unity.Burst.Intrinsics.v256 mm256_castps128_ps256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251e6f8*/ Unity.Burst.Intrinsics.v256 mm256_castpd128_pd256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251e704*/ Unity.Burst.Intrinsics.v256 mm256_castsi128_si256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251e710*/ Unity.Burst.Intrinsics.v128 undefined_ps();
                    static /*0x251e71c*/ Unity.Burst.Intrinsics.v128 undefined_pd();
                    static /*0x251e728*/ Unity.Burst.Intrinsics.v128 undefined_si128();
                    static /*0x251e734*/ Unity.Burst.Intrinsics.v256 mm256_undefined_ps();
                    static /*0x251e740*/ Unity.Burst.Intrinsics.v256 mm256_undefined_pd();
                    static /*0x251e74c*/ Unity.Burst.Intrinsics.v256 mm256_undefined_si256();
                    static /*0x251e758*/ Unity.Burst.Intrinsics.v256 mm256_zextps128_ps256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251e764*/ Unity.Burst.Intrinsics.v256 mm256_zextpd128_pd256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251e770*/ Unity.Burst.Intrinsics.v256 mm256_zextsi128_si256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251e77c*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi8(Unity.Burst.Intrinsics.v256 a, int i, int index);
                    static /*0x251e7cc*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi16(Unity.Burst.Intrinsics.v256 a, int i, int index);
                    static /*0x251e820*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi32(Unity.Burst.Intrinsics.v256 a, int i, int index);
                    static /*0x251e874*/ Unity.Burst.Intrinsics.v256 mm256_insert_epi64(Unity.Burst.Intrinsics.v256 a, long i, int index);
                    static /*0x251e8c8*/ int mm256_extract_epi32(Unity.Burst.Intrinsics.v256 a, int index);
                    static /*0x251e8d8*/ long mm256_extract_epi64(Unity.Burst.Intrinsics.v256 a, int index);

                    enum CMP
                    {
                        EQ_OQ = 0,
                        LT_OS = 1,
                        LE_OS = 2,
                        UNORD_Q = 3,
                        NEQ_UQ = 4,
                        NLT_US = 5,
                        NLE_US = 6,
                        ORD_Q = 7,
                        EQ_UQ = 8,
                        NGE_US = 9,
                        NGT_US = 10,
                        FALSE_OQ = 11,
                        NEQ_OQ = 12,
                        GE_OS = 13,
                        GT_OS = 14,
                        TRUE_UQ = 15,
                        EQ_OS = 16,
                        LT_OQ = 17,
                        LE_OQ = 18,
                        UNORD_S = 19,
                        NEQ_US = 20,
                        NLT_UQ = 21,
                        NLE_UQ = 22,
                        ORD_S = 23,
                        EQ_US = 24,
                        NGE_UQ = 25,
                        NGT_UQ = 26,
                        FALSE_OS = 27,
                        NEQ_OS = 28,
                        GE_OQ = 29,
                        GT_OQ = 30,
                        TRUE_US = 31,
                    }
                }

                class Avx2
                {
                    static /*0x251e8e8*/ bool get_IsAvx2Supported();
                    static /*0x251e8f0*/ int mm256_movemask_epi8(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e924*/ int mm256_extract_epi8(Unity.Burst.Intrinsics.v256 a, int index);
                    static /*0x251e930*/ int mm256_extract_epi16(Unity.Burst.Intrinsics.v256 a, int index);
                    static /*0x251e940*/ double mm256_cvtsd_f64(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e948*/ int mm256_cvtsi256_si32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e950*/ long mm256_cvtsi256_si64(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251e958*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251e9b8*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ea18*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ea78*/ Unity.Burst.Intrinsics.v256 mm256_cmpeq_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ead8*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251eb38*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251eb98*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ebf8*/ Unity.Burst.Intrinsics.v256 mm256_cmpgt_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251eca4*/ Unity.Burst.Intrinsics.v256 mm256_max_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ed04*/ Unity.Burst.Intrinsics.v256 mm256_max_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ed64*/ Unity.Burst.Intrinsics.v256 mm256_max_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251edc4*/ Unity.Burst.Intrinsics.v256 mm256_max_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ee24*/ Unity.Burst.Intrinsics.v256 mm256_max_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ee84*/ Unity.Burst.Intrinsics.v256 mm256_max_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251eee4*/ Unity.Burst.Intrinsics.v256 mm256_min_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ef44*/ Unity.Burst.Intrinsics.v256 mm256_min_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251efa4*/ Unity.Burst.Intrinsics.v256 mm256_min_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f004*/ Unity.Burst.Intrinsics.v256 mm256_min_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f064*/ Unity.Burst.Intrinsics.v256 mm256_min_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f0c4*/ Unity.Burst.Intrinsics.v256 mm256_min_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f124*/ Unity.Burst.Intrinsics.v256 mm256_and_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f184*/ Unity.Burst.Intrinsics.v256 mm256_andnot_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f1e4*/ Unity.Burst.Intrinsics.v256 mm256_or_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f244*/ Unity.Burst.Intrinsics.v256 mm256_xor_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f2a4*/ Unity.Burst.Intrinsics.v256 mm256_abs_epi8(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251f2f0*/ Unity.Burst.Intrinsics.v256 mm256_abs_epi16(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251f33c*/ Unity.Burst.Intrinsics.v256 mm256_abs_epi32(Unity.Burst.Intrinsics.v256 a);
                    static /*0x251f388*/ Unity.Burst.Intrinsics.v256 mm256_add_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f3e8*/ Unity.Burst.Intrinsics.v256 mm256_add_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f448*/ Unity.Burst.Intrinsics.v256 mm256_add_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f4a8*/ Unity.Burst.Intrinsics.v256 mm256_add_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f508*/ Unity.Burst.Intrinsics.v256 mm256_adds_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f568*/ Unity.Burst.Intrinsics.v256 mm256_adds_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f5c8*/ Unity.Burst.Intrinsics.v256 mm256_adds_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f628*/ Unity.Burst.Intrinsics.v256 mm256_adds_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f688*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f6e8*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f748*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f7a8*/ Unity.Burst.Intrinsics.v256 mm256_sub_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f808*/ Unity.Burst.Intrinsics.v256 mm256_subs_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f868*/ Unity.Burst.Intrinsics.v256 mm256_subs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f8c8*/ Unity.Burst.Intrinsics.v256 mm256_subs_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f928*/ Unity.Burst.Intrinsics.v256 mm256_subs_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f988*/ Unity.Burst.Intrinsics.v256 mm256_avg_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251f9e8*/ Unity.Burst.Intrinsics.v256 mm256_avg_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fa48*/ Unity.Burst.Intrinsics.v256 mm256_hadd_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251faa8*/ Unity.Burst.Intrinsics.v256 mm256_hadd_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fb08*/ Unity.Burst.Intrinsics.v256 mm256_hadds_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fb68*/ Unity.Burst.Intrinsics.v256 mm256_hsub_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fbc8*/ Unity.Burst.Intrinsics.v256 mm256_hsub_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fc28*/ Unity.Burst.Intrinsics.v256 mm256_hsubs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fc88*/ Unity.Burst.Intrinsics.v256 mm256_madd_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fce8*/ Unity.Burst.Intrinsics.v256 mm256_maddubs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fd48*/ Unity.Burst.Intrinsics.v256 mm256_mulhi_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fda8*/ Unity.Burst.Intrinsics.v256 mm256_mulhi_epu16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fe08*/ Unity.Burst.Intrinsics.v256 mm256_mullo_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fe68*/ Unity.Burst.Intrinsics.v256 mm256_mullo_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251fec8*/ Unity.Burst.Intrinsics.v256 mm256_mul_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ff28*/ Unity.Burst.Intrinsics.v256 mm256_mul_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ff88*/ Unity.Burst.Intrinsics.v256 mm256_sign_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x251ffe8*/ Unity.Burst.Intrinsics.v256 mm256_sign_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2520048*/ Unity.Burst.Intrinsics.v256 mm256_sign_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x25200a8*/ Unity.Burst.Intrinsics.v256 mm256_mulhrs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2520108*/ Unity.Burst.Intrinsics.v256 mm256_sad_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2520168*/ Unity.Burst.Intrinsics.v256 mm256_mpsadbw_epu8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x25201d8*/ Unity.Burst.Intrinsics.v256 mm256_slli_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2520238*/ Unity.Burst.Intrinsics.v256 mm256_bslli_epi128(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2520298*/ Unity.Burst.Intrinsics.v256 mm256_srli_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x25202f8*/ Unity.Burst.Intrinsics.v256 mm256_bsrli_epi128(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2520358*/ Unity.Burst.Intrinsics.v256 mm256_sll_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x25203c4*/ Unity.Burst.Intrinsics.v256 mm256_sll_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520430*/ Unity.Burst.Intrinsics.v256 mm256_sll_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x252049c*/ Unity.Burst.Intrinsics.v256 mm256_slli_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x25204fc*/ Unity.Burst.Intrinsics.v256 mm256_slli_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x252055c*/ Unity.Burst.Intrinsics.v256 mm256_slli_epi64(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x25205bc*/ Unity.Burst.Intrinsics.v256 mm256_sllv_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x2520694*/ Unity.Burst.Intrinsics.v256 mm256_sllv_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x2520614*/ Unity.Burst.Intrinsics.v128 sllv_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x25206ec*/ Unity.Burst.Intrinsics.v128 sllv_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520764*/ Unity.Burst.Intrinsics.v256 mm256_sra_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x25207d0*/ Unity.Burst.Intrinsics.v256 mm256_sra_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x252083c*/ Unity.Burst.Intrinsics.v256 mm256_srai_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x252089c*/ Unity.Burst.Intrinsics.v256 mm256_srai_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x25208fc*/ Unity.Burst.Intrinsics.v256 mm256_srav_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x2520954*/ Unity.Burst.Intrinsics.v128 srav_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520a40*/ Unity.Burst.Intrinsics.v256 mm256_srl_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520aac*/ Unity.Burst.Intrinsics.v256 mm256_srl_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520b18*/ Unity.Burst.Intrinsics.v256 mm256_srl_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520b84*/ Unity.Burst.Intrinsics.v256 mm256_srli_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2520be4*/ Unity.Burst.Intrinsics.v256 mm256_srli_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2520c44*/ Unity.Burst.Intrinsics.v256 mm256_srli_epi64(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2520ca4*/ Unity.Burst.Intrinsics.v256 mm256_srlv_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x2520d7c*/ Unity.Burst.Intrinsics.v256 mm256_srlv_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 count);
                    static /*0x2520cfc*/ Unity.Burst.Intrinsics.v128 srlv_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520dd4*/ Unity.Burst.Intrinsics.v128 srlv_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2520e4c*/ Unity.Burst.Intrinsics.v128 blend_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2520e54*/ Unity.Burst.Intrinsics.v256 mm256_blend_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x2520ec0*/ Unity.Burst.Intrinsics.v256 mm256_alignr_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x2520f2c*/ Unity.Burst.Intrinsics.v256 mm256_blendv_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x2520f98*/ Unity.Burst.Intrinsics.v256 mm256_blend_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x2521004*/ Unity.Burst.Intrinsics.v256 mm256_packs_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521064*/ Unity.Burst.Intrinsics.v256 mm256_packs_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x25210c4*/ Unity.Burst.Intrinsics.v256 mm256_packus_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521124*/ Unity.Burst.Intrinsics.v256 mm256_packus_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521184*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x25211e4*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521244*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x25212a4*/ Unity.Burst.Intrinsics.v256 mm256_unpackhi_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521304*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521364*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi16(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x25213c4*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521424*/ Unity.Burst.Intrinsics.v256 mm256_unpacklo_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x2521484*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_epi8(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x25214e4*/ Unity.Burst.Intrinsics.v256 mm256_shuffle_epi32(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2521544*/ Unity.Burst.Intrinsics.v256 mm256_shufflehi_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x25215a4*/ Unity.Burst.Intrinsics.v256 mm256_shufflelo_epi16(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2521604*/ Unity.Burst.Intrinsics.v128 mm256_extracti128_si256(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2521628*/ Unity.Burst.Intrinsics.v256 mm256_inserti128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2521650*/ Unity.Burst.Intrinsics.v128 broadcastss_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252165c*/ Unity.Burst.Intrinsics.v256 mm256_broadcastss_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521668*/ Unity.Burst.Intrinsics.v128 broadcastsd_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521670*/ Unity.Burst.Intrinsics.v256 mm256_broadcastsd_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252167c*/ Unity.Burst.Intrinsics.v128 broadcastb_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521690*/ Unity.Burst.Intrinsics.v128 broadcastw_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216ac*/ Unity.Burst.Intrinsics.v128 broadcastd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216b8*/ Unity.Burst.Intrinsics.v128 broadcastq_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216c0*/ Unity.Burst.Intrinsics.v256 mm256_broadcastb_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216d8*/ Unity.Burst.Intrinsics.v256 mm256_broadcastw_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216e4*/ Unity.Burst.Intrinsics.v256 mm256_broadcastd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216f0*/ Unity.Burst.Intrinsics.v256 mm256_broadcastq_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25216fc*/ Unity.Burst.Intrinsics.v256 mm256_broadcastsi128_si256(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521708*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521770*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25217d8*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521840*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25218a8*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521910*/ Unity.Burst.Intrinsics.v256 mm256_cvtepi32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521978*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25219e0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521a48*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521ab0*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521b18*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521b80*/ Unity.Burst.Intrinsics.v256 mm256_cvtepu32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521be8*/ Unity.Burst.Intrinsics.v128 maskload_epi32(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x2521c50*/ Unity.Burst.Intrinsics.v128 maskload_epi64(void* mem_addr, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x2521cb8*/ void maskstore_epi32(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521d1c*/ void maskstore_epi64(void* mem_addr, Unity.Burst.Intrinsics.v128 mask, Unity.Burst.Intrinsics.v128 a);
                    static /*0x2521d80*/ Unity.Burst.Intrinsics.v256 mm256_maskload_epi32(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x2521de8*/ Unity.Burst.Intrinsics.v256 mm256_maskload_epi64(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x2521e50*/ void mm256_maskstore_epi32(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x2521e74*/ void mm256_maskstore_epi64(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                    static /*0x2521e98*/ Unity.Burst.Intrinsics.v256 mm256_permutevar8x32_epi32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 idx);
                    static /*0x2521f04*/ Unity.Burst.Intrinsics.v256 mm256_permutevar8x32_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 idx);
                    static /*0x2521f88*/ Unity.Burst.Intrinsics.v256 mm256_permute4x64_epi64(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x2521ff4*/ Unity.Burst.Intrinsics.v256 mm256_permute4x64_pd(Unity.Burst.Intrinsics.v256 a, int imm8);
                    static /*0x252206c*/ Unity.Burst.Intrinsics.v256 mm256_permute2x128_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, int imm8);
                    static /*0x25220f0*/ Unity.Burst.Intrinsics.v256 mm256_stream_load_si256(void* mem_addr);
                    static void EmulatedGather<T, U>(T* dptr, void* base_addr, long* indexPtr, int scale, int n, U* mask);
                    static void EmulatedGather<T, U>(T* dptr, void* base_addr, int* indexPtr, int scale, int n, U* mask);
                    static /*0x25220fc*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x25221b0*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_pd(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x2522264*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_ps(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x2522318*/ Unity.Burst.Intrinsics.v256 mm256_i64gather_pd(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x25223cc*/ Unity.Burst.Intrinsics.v128 mm256_i64gather_ps(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x2522474*/ Unity.Burst.Intrinsics.v128 i32gather_pd(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x2522514*/ Unity.Burst.Intrinsics.v128 i32gather_ps(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x25225b4*/ Unity.Burst.Intrinsics.v128 i64gather_pd(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x2522654*/ Unity.Burst.Intrinsics.v128 i64gather_ps(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x25226f4*/ Unity.Burst.Intrinsics.v256 mm256_i32gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x25227a8*/ Unity.Burst.Intrinsics.v128 mm256_i64gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x2522850*/ Unity.Burst.Intrinsics.v256 mm256_i64gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v256 vindex, int scale);
                    static /*0x2522904*/ Unity.Burst.Intrinsics.v128 i32gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x25229a4*/ Unity.Burst.Intrinsics.v128 i32gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x2522a44*/ Unity.Burst.Intrinsics.v128 i64gather_epi32(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x2522ae4*/ Unity.Burst.Intrinsics.v128 i64gather_epi64(void* base_addr, Unity.Burst.Intrinsics.v128 vindex, int scale);
                    static /*0x2522b84*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_pd(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x2522c48*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_ps(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x2522d0c*/ Unity.Burst.Intrinsics.v256 mm256_mask_i64gather_pd(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x2522dd0*/ Unity.Burst.Intrinsics.v128 mm256_mask_i64gather_ps(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x2522e8c*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_epi32(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x2522f50*/ Unity.Burst.Intrinsics.v256 mm256_mask_i32gather_epi64(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x2523014*/ Unity.Burst.Intrinsics.v256 mm256_mask_i64gather_epi64(Unity.Burst.Intrinsics.v256 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v256 mask, int scale);
                    static /*0x25230d8*/ Unity.Burst.Intrinsics.v128 mm256_mask_i64gather_epi32(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v256 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x2523194*/ Unity.Burst.Intrinsics.v128 mask_i32gather_pd(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x2523248*/ Unity.Burst.Intrinsics.v128 mask_i32gather_ps(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x25232fc*/ Unity.Burst.Intrinsics.v128 mask_i64gather_pd(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x25233b0*/ Unity.Burst.Intrinsics.v128 mask_i64gather_ps(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x2523460*/ Unity.Burst.Intrinsics.v128 mask_i32gather_epi32(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x2523514*/ Unity.Burst.Intrinsics.v128 mask_i32gather_epi64(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x25235c8*/ Unity.Burst.Intrinsics.v128 mask_i64gather_epi32(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                    static /*0x2523678*/ Unity.Burst.Intrinsics.v128 mask_i64gather_epi64(Unity.Burst.Intrinsics.v128 src, void* base_addr, Unity.Burst.Intrinsics.v128 vindex, Unity.Burst.Intrinsics.v128 mask, int scale);
                }

                class Bmi1
                {
                    static /*0x252372c*/ bool get_IsBmi1Supported();
                    static /*0x2523734*/ uint andn_u32(uint a, uint b);
                    static /*0x252373c*/ ulong andn_u64(ulong a, ulong b);
                    static /*0x2523744*/ uint bextr_u32(uint a, uint start, uint len);
                    static /*0x2523774*/ ulong bextr_u64(ulong a, uint start, uint len);
                    static /*0x25237a4*/ uint bextr2_u32(uint a, uint control);
                    static /*0x25237d8*/ ulong bextr2_u64(ulong a, ulong control);
                    static /*0x252380c*/ uint blsi_u32(uint a);
                    static /*0x2523818*/ ulong blsi_u64(ulong a);
                    static /*0x2523824*/ uint blsmsk_u32(uint a);
                    static /*0x2523830*/ ulong blsmsk_u64(ulong a);
                    static /*0x252383c*/ uint blsr_u32(uint a);
                    static /*0x2523848*/ ulong blsr_u64(ulong a);
                    static /*0x2523854*/ uint tzcnt_u32(uint a);
                    static /*0x25238ac*/ ulong tzcnt_u64(ulong a);
                }

                class Bmi2
                {
                    static /*0x2523910*/ bool get_IsBmi2Supported();
                    static /*0x2523918*/ uint bzhi_u32(uint a, uint index);
                    static /*0x2523934*/ ulong bzhi_u64(ulong a, ulong index);
                    static /*0x2523950*/ uint mulx_u32(uint a, uint b, ref uint hi);
                    static /*0x2523960*/ ulong mulx_u64(ulong a, ulong b, ref ulong hi);
                    static /*0x252399c*/ uint pdep_u32(uint a, uint mask);
                    static /*0x25239e0*/ ulong pdep_u64(ulong a, ulong mask);
                    static /*0x2523a24*/ uint pext_u32(uint a, uint mask);
                    static /*0x2523a68*/ ulong pext_u64(ulong a, ulong mask);
                }

                enum MXCSRBits
                {
                    FlushToZero = 32768,
                    RoundingControlMask = 24576,
                    RoundToNearest = 0,
                    RoundDown = 8192,
                    RoundUp = 16384,
                    RoundTowardZero = 24576,
                    PrecisionMask = 4096,
                    UnderflowMask = 2048,
                    OverflowMask = 1024,
                    DivideByZeroMask = 512,
                    DenormalOperationMask = 256,
                    InvalidOperationMask = 128,
                    ExceptionMask = 8064,
                    DenormalsAreZeroes = 64,
                    PrecisionFlag = 32,
                    UnderflowFlag = 16,
                    OverflowFlag = 8,
                    DivideByZeroFlag = 4,
                    DenormalFlag = 2,
                    InvalidOperationFlag = 1,
                    FlagMask = 63,
                }

                enum RoundingMode
                {
                    FROUND_TO_NEAREST_INT = 0,
                    FROUND_TO_NEG_INF = 1,
                    FROUND_TO_POS_INF = 2,
                    FROUND_TO_ZERO = 3,
                    FROUND_CUR_DIRECTION = 4,
                    FROUND_RAISE_EXC = 0,
                    FROUND_NO_EXC = 8,
                    FROUND_NINT = 0,
                    FROUND_FLOOR = 1,
                    FROUND_CEIL = 2,
                    FROUND_TRUNC = 3,
                    FROUND_RINT = 4,
                    FROUND_NEARBYINT = 12,
                    FROUND_NINT_NOEXC = 8,
                    FROUND_FLOOR_NOEXC = 9,
                    FROUND_CEIL_NOEXC = 10,
                    FROUND_TRUNC_NOEXC = 11,
                    FROUND_RINT_NOEXC = 12,
                }

                struct RoundingScope : System.IDisposable
                {
                    /*0x10*/ Unity.Burst.Intrinsics.X86.MXCSRBits OldBits;

                    /*0x2523aac*/ RoundingScope(Unity.Burst.Intrinsics.X86.MXCSRBits roundingMode);
                    /*0x2523ab4*/ void Dispose();
                }

                class F16C
                {
                    static /*0x0*/ ushort[] BaseTable;
                    static /*0x8*/ sbyte[] ShiftTable;

                    static /*0x252409c*/ F16C();
                    static /*0x2523ab8*/ bool get_IsF16CSupported();
                    static /*0x2523ac0*/ uint HalfToFloat(ushort h);
                    static /*0x2523b1c*/ Unity.Burst.Intrinsics.v128 cvtph_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2523bc0*/ Unity.Burst.Intrinsics.v256 mm256_cvtph_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2523cb4*/ ushort FloatToHalf(uint f, int rounding);
                    static /*0x2523e84*/ Unity.Burst.Intrinsics.v128 cvtps_ph(Unity.Burst.Intrinsics.v128 a, int rounding);
                    static /*0x2523f58*/ Unity.Burst.Intrinsics.v128 mm256_cvtps_ph(Unity.Burst.Intrinsics.v256 a, int rounding);
                }

                class Fma
                {
                    static /*0x2524188*/ bool get_IsFmaSupported();
                    static /*0x2524190*/ float FmaHelper(float a, float b, float c);
                    static /*0x25241ac*/ float FnmaHelper(float a, float b, float c);
                    static /*0x25241c8*/ Unity.Burst.Intrinsics.v128 fmadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524218*/ Unity.Burst.Intrinsics.v256 mm256_fmadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524268*/ Unity.Burst.Intrinsics.v128 fmadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x252432c*/ Unity.Burst.Intrinsics.v256 mm256_fmadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x25243c4*/ Unity.Burst.Intrinsics.v128 fmadd_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524414*/ Unity.Burst.Intrinsics.v128 fmadd_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524448*/ Unity.Burst.Intrinsics.v128 fmaddsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524498*/ Unity.Burst.Intrinsics.v256 mm256_fmaddsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x25244e8*/ Unity.Burst.Intrinsics.v128 fmaddsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x25245ac*/ Unity.Burst.Intrinsics.v256 mm256_fmaddsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524674*/ Unity.Burst.Intrinsics.v128 fmsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x25246c4*/ Unity.Burst.Intrinsics.v256 mm256_fmsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524714*/ Unity.Burst.Intrinsics.v128 fmsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524798*/ Unity.Burst.Intrinsics.v256 mm256_fmsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524830*/ Unity.Burst.Intrinsics.v128 fmsub_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524880*/ Unity.Burst.Intrinsics.v128 fmsub_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x25248b4*/ Unity.Burst.Intrinsics.v128 fmsubadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524904*/ Unity.Burst.Intrinsics.v256 mm256_fmsubadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524954*/ Unity.Burst.Intrinsics.v128 fmsubadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524a18*/ Unity.Burst.Intrinsics.v256 mm256_fmsubadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524ad0*/ Unity.Burst.Intrinsics.v128 fnmadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524b20*/ Unity.Burst.Intrinsics.v256 mm256_fnmadd_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524b70*/ Unity.Burst.Intrinsics.v128 fnmadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524bf4*/ Unity.Burst.Intrinsics.v256 mm256_fnmadd_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524c8c*/ Unity.Burst.Intrinsics.v128 fnmadd_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524cdc*/ Unity.Burst.Intrinsics.v128 fnmadd_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524d10*/ Unity.Burst.Intrinsics.v128 fnmsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524d60*/ Unity.Burst.Intrinsics.v256 mm256_fnmsub_pd(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524db0*/ Unity.Burst.Intrinsics.v128 fnmsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524e3c*/ Unity.Burst.Intrinsics.v256 mm256_fnmsub_ps(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b, Unity.Burst.Intrinsics.v256 c);
                    static /*0x2524ed4*/ Unity.Burst.Intrinsics.v128 fnmsub_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);
                    static /*0x2524f24*/ Unity.Burst.Intrinsics.v128 fnmsub_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 c);

                    struct Union
                    {
                        /*0x10*/ float f;
                        /*0x10*/ uint u;
                    }
                }

                class Popcnt
                {
                    static /*0x2524f5c*/ bool get_IsPopcntSupported();
                    static /*0x2524fac*/ int popcnt_u32(uint v);
                    static /*0x2524fcc*/ int popcnt_u64(ulong v);
                }

                class Sse
                {
                    static /*0x251aedc*/ bool get_IsSseSupported();
                    static /*0x2524fec*/ Unity.Burst.Intrinsics.v128 load_ps(void* ptr);
                    static /*0x251d15c*/ Unity.Burst.Intrinsics.v128 loadu_ps(void* ptr);
                    static /*0x2524ff8*/ void store_ps(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0x251d2dc*/ void storeu_ps(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0x2525000*/ void stream_ps(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x2525008*/ Unity.Burst.Intrinsics.v128 cvtsi32_ss(Unity.Burst.Intrinsics.v128 a, int b);
                    static /*0x252501c*/ Unity.Burst.Intrinsics.v128 cvtsi64_ss(Unity.Burst.Intrinsics.v128 a, long b);
                    static /*0x2525030*/ Unity.Burst.Intrinsics.v128 add_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251afb0*/ Unity.Burst.Intrinsics.v128 add_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252504c*/ Unity.Burst.Intrinsics.v128 sub_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251bdc0*/ Unity.Burst.Intrinsics.v128 sub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525068*/ Unity.Burst.Intrinsics.v128 mul_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251badc*/ Unity.Burst.Intrinsics.v128 mul_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525084*/ Unity.Burst.Intrinsics.v128 div_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251b45c*/ Unity.Burst.Intrinsics.v128 div_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25250a0*/ Unity.Burst.Intrinsics.v128 sqrt_ss(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251d7bc*/ Unity.Burst.Intrinsics.v128 sqrt_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252511c*/ Unity.Burst.Intrinsics.v128 rcp_ss(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251d5e0*/ Unity.Burst.Intrinsics.v128 rcp_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2525138*/ Unity.Burst.Intrinsics.v128 rsqrt_ss(Unity.Burst.Intrinsics.v128 a);
                    static /*0x251d66c*/ Unity.Burst.Intrinsics.v128 rsqrt_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25251bc*/ Unity.Burst.Intrinsics.v128 min_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251b91c*/ Unity.Burst.Intrinsics.v128 min_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525248*/ Unity.Burst.Intrinsics.v128 max_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251b75c*/ Unity.Burst.Intrinsics.v128 max_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251b144*/ Unity.Burst.Intrinsics.v128 and_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251b1c8*/ Unity.Burst.Intrinsics.v128 andnot_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251bbb0*/ Unity.Burst.Intrinsics.v128 or_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251be94*/ Unity.Burst.Intrinsics.v128 xor_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25252d4*/ Unity.Burst.Intrinsics.v128 cmpeq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c480*/ Unity.Burst.Intrinsics.v128 cmpeq_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25252f4*/ Unity.Burst.Intrinsics.v128 cmplt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c510*/ Unity.Burst.Intrinsics.v128 cmplt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525314*/ Unity.Burst.Intrinsics.v128 cmple_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c5a0*/ Unity.Burst.Intrinsics.v128 cmple_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525334*/ Unity.Burst.Intrinsics.v128 cmpgt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c8f4*/ Unity.Burst.Intrinsics.v128 cmpgt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525358*/ Unity.Burst.Intrinsics.v128 cmpge_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c8d8*/ Unity.Burst.Intrinsics.v128 cmpge_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252537c*/ Unity.Burst.Intrinsics.v128 cmpneq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c690*/ Unity.Burst.Intrinsics.v128 cmpneq_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252539c*/ Unity.Burst.Intrinsics.v128 cmpnlt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c720*/ Unity.Burst.Intrinsics.v128 cmpnlt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25253bc*/ Unity.Burst.Intrinsics.v128 cmpnle_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c7b0*/ Unity.Burst.Intrinsics.v128 cmpnle_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25253dc*/ Unity.Burst.Intrinsics.v128 cmpngt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c8bc*/ Unity.Burst.Intrinsics.v128 cmpngt_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525400*/ Unity.Burst.Intrinsics.v128 cmpnge_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c8a0*/ Unity.Burst.Intrinsics.v128 cmpnge_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525424*/ Unity.Burst.Intrinsics.v128 cmpord_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c840*/ Unity.Burst.Intrinsics.v128 cmpord_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525460*/ Unity.Burst.Intrinsics.v128 cmpunord_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251c630*/ Unity.Burst.Intrinsics.v128 cmpunord_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252549c*/ int comieq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25254b0*/ int comilt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25254c4*/ int comile_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25254d8*/ int comigt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25254ec*/ int comige_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525500*/ int comineq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525514*/ int ucomieq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525528*/ int ucomilt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252553c*/ int ucomile_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525550*/ int ucomigt_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525564*/ int ucomige_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525578*/ int ucomineq_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252558c*/ int cvtss_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25255ac*/ int cvt_ss2si(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25255cc*/ long cvtss_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25255ec*/ float cvtss_f32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25255f4*/ int cvttss_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2525614*/ int cvtt_ss2si(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2525634*/ long cvttss_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2525654*/ Unity.Burst.Intrinsics.v128 set_ss(float a);
                    static /*0x2525660*/ Unity.Burst.Intrinsics.v128 set1_ps(float a);
                    static /*0x2525670*/ Unity.Burst.Intrinsics.v128 set_ps1(float a);
                    static /*0x2525680*/ Unity.Burst.Intrinsics.v128 set_ps(float e3, float e2, float e1, float e0);
                    static /*0x252569c*/ Unity.Burst.Intrinsics.v128 setr_ps(float e3, float e2, float e1, float e0);
                    static /*0x25256b8*/ Unity.Burst.Intrinsics.v128 move_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25256c0*/ int SHUFFLE(int d, int c, int b, int a);
                    static /*0x251bc90*/ Unity.Burst.Intrinsics.v128 shuffle_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x251dbac*/ Unity.Burst.Intrinsics.v128 unpackhi_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251dbf4*/ Unity.Burst.Intrinsics.v128 unpacklo_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25256d4*/ Unity.Burst.Intrinsics.v128 movehl_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25256dc*/ Unity.Burst.Intrinsics.v128 movelh_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x251e288*/ int movemask_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25256e4*/ void TRANSPOSE4_PS(ref Unity.Burst.Intrinsics.v128 row0, ref Unity.Burst.Intrinsics.v128 row1, ref Unity.Burst.Intrinsics.v128 row2, ref Unity.Burst.Intrinsics.v128 row3);
                    static /*0x251e6ec*/ Unity.Burst.Intrinsics.v128 setzero_ps();
                    static /*0x25257e4*/ Unity.Burst.Intrinsics.v128 loadu_si16(void* mem_addr);
                    static /*0x25257f0*/ void storeu_si16(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x25257f8*/ Unity.Burst.Intrinsics.v128 loadu_si64(void* mem_addr);
                    static /*0x2525804*/ void storeu_si64(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                }

                class Sse2
                {
                    static /*0x252580c*/ bool get_IsSse2Supported();
                    static /*0x2525814*/ int SHUFFLE2(int x, int y);
                    static /*0x252581c*/ void stream_si32(int* mem_addr, int a);
                    static /*0x2525824*/ void stream_si64(long* mem_addr, long a);
                    static /*0x252582c*/ void stream_pd(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x2525834*/ void stream_si128(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x252583c*/ Unity.Burst.Intrinsics.v128 add_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25258ac*/ Unity.Burst.Intrinsics.v128 add_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252591c*/ Unity.Burst.Intrinsics.v128 add_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525948*/ Unity.Burst.Intrinsics.v128 add_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525954*/ Unity.Burst.Intrinsics.v128 adds_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25259dc*/ Unity.Burst.Intrinsics.v128 adds_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525a64*/ Unity.Burst.Intrinsics.v128 adds_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525aec*/ Unity.Burst.Intrinsics.v128 adds_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525b74*/ Unity.Burst.Intrinsics.v128 avg_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525bec*/ Unity.Burst.Intrinsics.v128 avg_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525c64*/ Unity.Burst.Intrinsics.v128 madd_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525ce8*/ Unity.Burst.Intrinsics.v128 max_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525dbc*/ Unity.Burst.Intrinsics.v128 max_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525e90*/ Unity.Burst.Intrinsics.v128 min_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2525f64*/ Unity.Burst.Intrinsics.v128 min_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2526038*/ Unity.Burst.Intrinsics.v128 mulhi_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25260ac*/ Unity.Burst.Intrinsics.v128 mulhi_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2526120*/ Unity.Burst.Intrinsics.v128 mullo_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2526190*/ Unity.Burst.Intrinsics.v128 mul_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25261ac*/ Unity.Burst.Intrinsics.v128 sad_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25262dc*/ Unity.Burst.Intrinsics.v128 sub_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252634c*/ Unity.Burst.Intrinsics.v128 sub_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25263bc*/ Unity.Burst.Intrinsics.v128 sub_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252642c*/ Unity.Burst.Intrinsics.v128 sub_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252649c*/ Unity.Burst.Intrinsics.v128 subs_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2526524*/ Unity.Burst.Intrinsics.v128 subs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25265ac*/ Unity.Burst.Intrinsics.v128 subs_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2526634*/ Unity.Burst.Intrinsics.v128 subs_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25266bc*/ Unity.Burst.Intrinsics.v128 slli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x25267ac*/ Unity.Burst.Intrinsics.v128 bslli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x25267b0*/ Unity.Burst.Intrinsics.v128 bsrli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x25268a0*/ Unity.Burst.Intrinsics.v128 slli_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2526918*/ Unity.Burst.Intrinsics.v128 sll_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x25269ec*/ Unity.Burst.Intrinsics.v128 slli_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2526ac0*/ Unity.Burst.Intrinsics.v128 sll_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2526b94*/ Unity.Burst.Intrinsics.v128 slli_epi64(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2526c68*/ Unity.Burst.Intrinsics.v128 sll_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2526d3c*/ Unity.Burst.Intrinsics.v128 srai_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2526e20*/ Unity.Burst.Intrinsics.v128 sra_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2526f04*/ Unity.Burst.Intrinsics.v128 srai_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2526fe8*/ Unity.Burst.Intrinsics.v128 sra_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x25270cc*/ Unity.Burst.Intrinsics.v128 srli_si128(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x25270d0*/ Unity.Burst.Intrinsics.v128 srli_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x25271b4*/ Unity.Burst.Intrinsics.v128 srl_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2527298*/ Unity.Burst.Intrinsics.v128 srli_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x252737c*/ Unity.Burst.Intrinsics.v128 srl_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x2527460*/ Unity.Burst.Intrinsics.v128 srli_epi64(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2527544*/ Unity.Burst.Intrinsics.v128 srl_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 count);
                    static /*0x252762c*/ Unity.Burst.Intrinsics.v128 and_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527638*/ Unity.Burst.Intrinsics.v128 andnot_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527644*/ Unity.Burst.Intrinsics.v128 or_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527650*/ Unity.Burst.Intrinsics.v128 xor_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252765c*/ Unity.Burst.Intrinsics.v128 cmpeq_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25276d0*/ Unity.Burst.Intrinsics.v128 cmpeq_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527744*/ Unity.Burst.Intrinsics.v128 cmpeq_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25277b8*/ Unity.Burst.Intrinsics.v128 cmpgt_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252782c*/ Unity.Burst.Intrinsics.v128 cmpgt_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25278a0*/ Unity.Burst.Intrinsics.v128 cmpgt_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527914*/ Unity.Burst.Intrinsics.v128 cmplt_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527930*/ Unity.Burst.Intrinsics.v128 cmplt_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252794c*/ Unity.Burst.Intrinsics.v128 cmplt_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527968*/ Unity.Burst.Intrinsics.v128 cvtepi32_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2527980*/ Unity.Burst.Intrinsics.v128 cvtsi32_sd(Unity.Burst.Intrinsics.v128 a, int b);
                    static /*0x252798c*/ Unity.Burst.Intrinsics.v128 cvtsi64_sd(Unity.Burst.Intrinsics.v128 a, long b);
                    static /*0x2527998*/ Unity.Burst.Intrinsics.v128 cvtsi64x_sd(Unity.Burst.Intrinsics.v128 a, long b);
                    static /*0x25279a4*/ Unity.Burst.Intrinsics.v128 cvtepi32_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25279d8*/ Unity.Burst.Intrinsics.v128 cvtsi32_si128(int a);
                    static /*0x25279e4*/ Unity.Burst.Intrinsics.v128 cvtsi64_si128(long a);
                    static /*0x25279ec*/ Unity.Burst.Intrinsics.v128 cvtsi64x_si128(long a);
                    static /*0x25279f4*/ int cvtsi128_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25279f8*/ long cvtsi128_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25279fc*/ long cvtsi128_si64x(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2527a00*/ Unity.Burst.Intrinsics.v128 set_epi64x(long e1, long e0);
                    static /*0x2527a10*/ Unity.Burst.Intrinsics.v128 set_epi32(int e3, int e2, int e1, int e0);
                    static /*0x2527a28*/ Unity.Burst.Intrinsics.v128 set_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0);
                    static /*0x2527a5c*/ Unity.Burst.Intrinsics.v128 set_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_);
                    static /*0x2527ad8*/ Unity.Burst.Intrinsics.v128 set1_epi64x(long a);
                    static /*0x2527ae0*/ Unity.Burst.Intrinsics.v128 set1_epi32(int a);
                    static /*0x2527af0*/ Unity.Burst.Intrinsics.v128 set1_epi16(short a);
                    static /*0x2527b44*/ Unity.Burst.Intrinsics.v128 set1_epi8(sbyte a);
                    static /*0x2527b98*/ Unity.Burst.Intrinsics.v128 setr_epi32(int e3, int e2, int e1, int e0);
                    static /*0x2527bb0*/ Unity.Burst.Intrinsics.v128 setr_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0);
                    static /*0x2527be0*/ Unity.Burst.Intrinsics.v128 setr_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_);
                    static /*0x2527c58*/ Unity.Burst.Intrinsics.v128 setzero_si128();
                    static /*0x2527c64*/ Unity.Burst.Intrinsics.v128 move_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2527c6c*/ Unity.Burst.Intrinsics.v128 packs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527d14*/ Unity.Burst.Intrinsics.v128 packs_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527dbc*/ Unity.Burst.Intrinsics.v128 packus_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2527e64*/ ushort extract_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2527eac*/ Unity.Burst.Intrinsics.v128 insert_epi16(Unity.Burst.Intrinsics.v128 a, int i, int imm8);
                    static /*0x2527ef8*/ int movemask_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2527f60*/ Unity.Burst.Intrinsics.v128 shuffle_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2527fe4*/ Unity.Burst.Intrinsics.v128 shufflehi_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x252807c*/ Unity.Burst.Intrinsics.v128 shufflelo_epi16(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2528114*/ Unity.Burst.Intrinsics.v128 unpackhi_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528190*/ Unity.Burst.Intrinsics.v128 unpackhi_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252820c*/ Unity.Burst.Intrinsics.v128 unpackhi_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528220*/ Unity.Burst.Intrinsics.v128 unpackhi_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252822c*/ Unity.Burst.Intrinsics.v128 unpacklo_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25282a0*/ Unity.Burst.Intrinsics.v128 unpacklo_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528314*/ Unity.Burst.Intrinsics.v128 unpacklo_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528324*/ Unity.Burst.Intrinsics.v128 unpacklo_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252832c*/ Unity.Burst.Intrinsics.v128 add_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528340*/ Unity.Burst.Intrinsics.v128 add_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528364*/ Unity.Burst.Intrinsics.v128 div_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528378*/ Unity.Burst.Intrinsics.v128 div_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252839c*/ Unity.Burst.Intrinsics.v128 max_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528424*/ Unity.Burst.Intrinsics.v128 max_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25284cc*/ Unity.Burst.Intrinsics.v128 min_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528554*/ Unity.Burst.Intrinsics.v128 min_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25285fc*/ Unity.Burst.Intrinsics.v128 mul_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528610*/ Unity.Burst.Intrinsics.v128 mul_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528634*/ Unity.Burst.Intrinsics.v128 sqrt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25286a8*/ Unity.Burst.Intrinsics.v128 sqrt_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528724*/ Unity.Burst.Intrinsics.v128 sub_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528738*/ Unity.Burst.Intrinsics.v128 sub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252875c*/ Unity.Burst.Intrinsics.v128 and_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528768*/ Unity.Burst.Intrinsics.v128 andnot_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528774*/ Unity.Burst.Intrinsics.v128 or_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528780*/ Unity.Burst.Intrinsics.v128 xor_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252878c*/ Unity.Burst.Intrinsics.v128 cmpeq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25287a0*/ Unity.Burst.Intrinsics.v128 cmplt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25287b4*/ Unity.Burst.Intrinsics.v128 cmple_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25287c8*/ Unity.Burst.Intrinsics.v128 cmpgt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25287e0*/ Unity.Burst.Intrinsics.v128 cmpge_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25287f8*/ Unity.Burst.Intrinsics.v128 cmpord_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528840*/ Unity.Burst.Intrinsics.v128 cmpunord_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528888*/ Unity.Burst.Intrinsics.v128 cmpneq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252889c*/ Unity.Burst.Intrinsics.v128 cmpnlt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25288b0*/ Unity.Burst.Intrinsics.v128 cmpnle_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25288c4*/ Unity.Burst.Intrinsics.v128 cmpngt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25288dc*/ Unity.Burst.Intrinsics.v128 cmpnge_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25288f4*/ Unity.Burst.Intrinsics.v128 cmpeq_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528918*/ Unity.Burst.Intrinsics.v128 cmplt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252893c*/ Unity.Burst.Intrinsics.v128 cmple_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528960*/ Unity.Burst.Intrinsics.v128 cmpgt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528984*/ Unity.Burst.Intrinsics.v128 cmpge_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25289a8*/ Unity.Burst.Intrinsics.v128 cmpord_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528a20*/ Unity.Burst.Intrinsics.v128 cmpunord_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528a90*/ Unity.Burst.Intrinsics.v128 cmpneq_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528ab4*/ Unity.Burst.Intrinsics.v128 cmpnlt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528ad8*/ Unity.Burst.Intrinsics.v128 cmpnle_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528afc*/ Unity.Burst.Intrinsics.v128 cmpngt_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528b20*/ Unity.Burst.Intrinsics.v128 cmpnge_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528b44*/ int comieq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528b58*/ int comilt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528b6c*/ int comile_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528b80*/ int comigt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528b94*/ int comige_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528ba8*/ int comineq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528bbc*/ int ucomieq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528bd0*/ int ucomilt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528be4*/ int ucomile_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528bf8*/ int ucomigt_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528c0c*/ int ucomige_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528c20*/ int ucomineq_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528c34*/ Unity.Burst.Intrinsics.v128 cvtpd_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528c58*/ Unity.Burst.Intrinsics.v128 cvtps_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528c78*/ Unity.Burst.Intrinsics.v128 cvtpd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528dfc*/ int cvtsd_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528ed8*/ long cvtsd_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528fb4*/ long cvtsd_si64x(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528fb8*/ Unity.Burst.Intrinsics.v128 cvtsd_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528fd0*/ double cvtsd_f64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2528fd8*/ Unity.Burst.Intrinsics.v128 cvtss_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2528ff4*/ Unity.Burst.Intrinsics.v128 cvttpd_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529034*/ int cvttsd_si32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529054*/ long cvttsd_si64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529074*/ long cvttsd_si64x(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529094*/ Unity.Burst.Intrinsics.v128 cvtps_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529328*/ Unity.Burst.Intrinsics.v128 cvttps_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529394*/ Unity.Burst.Intrinsics.v128 set_sd(double a);
                    static /*0x25293a0*/ Unity.Burst.Intrinsics.v128 set1_pd(double a);
                    static /*0x25293ac*/ Unity.Burst.Intrinsics.v128 set_pd1(double a);
                    static /*0x25293b8*/ Unity.Burst.Intrinsics.v128 set_pd(double e1, double e0);
                    static /*0x25293c4*/ Unity.Burst.Intrinsics.v128 setr_pd(double e1, double e0);
                    static /*0x25293d0*/ Unity.Burst.Intrinsics.v128 unpackhi_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25293dc*/ Unity.Burst.Intrinsics.v128 unpacklo_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25293e4*/ int movemask_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x25293f8*/ Unity.Burst.Intrinsics.v128 shuffle_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2529454*/ Unity.Burst.Intrinsics.v128 move_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252945c*/ Unity.Burst.Intrinsics.v128 loadu_si32(void* mem_addr);
                    static /*0x25294b4*/ void storeu_si32(void* mem_addr, Unity.Burst.Intrinsics.v128 a);
                    static /*0x25294bc*/ Unity.Burst.Intrinsics.v128 load_si128(void* ptr);
                    static /*0x25294c4*/ Unity.Burst.Intrinsics.v128 loadu_si128(void* ptr);
                    static /*0x25294cc*/ void store_si128(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0x25294d4*/ void storeu_si128(void* ptr, Unity.Burst.Intrinsics.v128 val);
                    static /*0x25294dc*/ void clflush(void* ptr);
                }

                class Sse3
                {
                    static /*0x25294e0*/ bool get_IsSse3Supported();
                    static /*0x25294e8*/ Unity.Burst.Intrinsics.v128 addsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2529544*/ Unity.Burst.Intrinsics.v128 addsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2529568*/ Unity.Burst.Intrinsics.v128 hadd_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252958c*/ Unity.Burst.Intrinsics.v128 hadd_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x25295e8*/ Unity.Burst.Intrinsics.v128 hsub_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252960c*/ Unity.Burst.Intrinsics.v128 hsub_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2529668*/ Unity.Burst.Intrinsics.v128 movedup_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x2529670*/ Unity.Burst.Intrinsics.v128 movehdup_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252967c*/ Unity.Burst.Intrinsics.v128 moveldup_ps(Unity.Burst.Intrinsics.v128 a);
                }

                class Sse4_1
                {
                    static /*0x2529688*/ bool get_IsSse41Supported();
                    static /*0x2529690*/ Unity.Burst.Intrinsics.v128 stream_load_si128(void* mem_addr);
                    static /*0x2529698*/ Unity.Burst.Intrinsics.v128 blend_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2529718*/ Unity.Burst.Intrinsics.v128 blend_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2529798*/ Unity.Burst.Intrinsics.v128 blendv_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x2529814*/ Unity.Burst.Intrinsics.v128 blendv_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x2529890*/ Unity.Burst.Intrinsics.v128 blendv_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x252990c*/ Unity.Burst.Intrinsics.v128 blend_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252998c*/ Unity.Burst.Intrinsics.v128 dp_pd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x25299d0*/ Unity.Burst.Intrinsics.v128 dp_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2529aa8*/ int extract_ps(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2529af0*/ float extractf_ps(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2529b38*/ byte extract_epi8(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2529b7c*/ int extract_epi32(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2529bc4*/ long extract_epi64(Unity.Burst.Intrinsics.v128 a, int imm8);
                    static /*0x2529c0c*/ Unity.Burst.Intrinsics.v128 insert_ps(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x2529c94*/ Unity.Burst.Intrinsics.v128 insert_epi8(Unity.Burst.Intrinsics.v128 a, byte i, int imm8);
                    static /*0x2529cdc*/ Unity.Burst.Intrinsics.v128 insert_epi32(Unity.Burst.Intrinsics.v128 a, int i, int imm8);
                    static /*0x2529d28*/ Unity.Burst.Intrinsics.v128 insert_epi64(Unity.Burst.Intrinsics.v128 a, long i, int imm8);
                    static /*0x2529d74*/ Unity.Burst.Intrinsics.v128 max_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2529e48*/ Unity.Burst.Intrinsics.v128 max_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2529f1c*/ Unity.Burst.Intrinsics.v128 max_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x2529ff0*/ Unity.Burst.Intrinsics.v128 max_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a0c4*/ Unity.Burst.Intrinsics.v128 min_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a198*/ Unity.Burst.Intrinsics.v128 min_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a26c*/ Unity.Burst.Intrinsics.v128 min_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a340*/ Unity.Burst.Intrinsics.v128 min_epu16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a414*/ Unity.Burst.Intrinsics.v128 packus_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a4f4*/ Unity.Burst.Intrinsics.v128 cmpeq_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a508*/ Unity.Burst.Intrinsics.v128 cvtepi8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a568*/ Unity.Burst.Intrinsics.v128 cvtepi8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a5c8*/ Unity.Burst.Intrinsics.v128 cvtepi8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a608*/ Unity.Burst.Intrinsics.v128 cvtepi16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a668*/ Unity.Burst.Intrinsics.v128 cvtepi16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a6a8*/ Unity.Burst.Intrinsics.v128 cvtepi32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a6e8*/ Unity.Burst.Intrinsics.v128 cvtepu8_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a748*/ Unity.Burst.Intrinsics.v128 cvtepu8_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a7a8*/ Unity.Burst.Intrinsics.v128 cvtepu8_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a7e8*/ Unity.Burst.Intrinsics.v128 cvtepu16_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a848*/ Unity.Burst.Intrinsics.v128 cvtepu16_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a888*/ Unity.Burst.Intrinsics.v128 cvtepu32_epi64(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252a8c8*/ Unity.Burst.Intrinsics.v128 mul_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a8e4*/ Unity.Burst.Intrinsics.v128 mullo_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a954*/ int testz_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a970*/ int testc_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a98c*/ int testnzc_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252a9c4*/ int test_all_zeros(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x252a9d8*/ int test_mix_ones_zeroes(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 mask);
                    static /*0x252a9dc*/ int test_all_ones(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252aa1c*/ double RoundDImpl(double d, int roundingMode);
                    static /*0x252abfc*/ Unity.Burst.Intrinsics.v128 round_pd(Unity.Burst.Intrinsics.v128 a, int rounding);
                    static /*0x252ac3c*/ Unity.Burst.Intrinsics.v128 floor_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252ac78*/ Unity.Burst.Intrinsics.v128 ceil_pd(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252acb4*/ Unity.Burst.Intrinsics.v128 round_ps(Unity.Burst.Intrinsics.v128 a, int rounding);
                    static /*0x252ad58*/ Unity.Burst.Intrinsics.v128 floor_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252ad60*/ Unity.Burst.Intrinsics.v128 ceil_ps(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252ad68*/ Unity.Burst.Intrinsics.v128 round_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int rounding);
                    static /*0x252ad8c*/ Unity.Burst.Intrinsics.v128 floor_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252adb0*/ Unity.Burst.Intrinsics.v128 ceil_sd(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252add4*/ Unity.Burst.Intrinsics.v128 round_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int rounding);
                    static /*0x252ae10*/ Unity.Burst.Intrinsics.v128 floor_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252ae4c*/ Unity.Burst.Intrinsics.v128 ceil_ss(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252ae88*/ Unity.Burst.Intrinsics.v128 minpos_epu16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252aefc*/ Unity.Burst.Intrinsics.v128 mpsadbw_epu8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252b024*/ int MK_INSERTPS_NDX(int srcField, int dstField, int zeroMask);
                }

                class Sse4_2
                {
                    static /*0x0*/ uint[] crctab;

                    static /*0x252c378*/ Sse4_2();
                    static /*0x252b034*/ bool get_IsSse42Supported();
                    static Unity.Burst.Intrinsics.v128 cmpistrm_emulation<T>(T* a, T* b, int len, int imm8, int allOnes, T allOnesT);
                    static Unity.Burst.Intrinsics.v128 cmpestrm_emulation<T>(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT);
                    static Unity.Burst.Intrinsics.v128 ComputeStrmOutput<T>(int len, int imm8, T allOnesT, int intRes2);
                    static int cmpistri_emulation<T>(T* a, T* b, int len, int imm8, int allOnes, T allOnesT);
                    static int cmpestri_emulation<T>(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT);
                    static /*0x252b03c*/ int ComputeStriOutput(int len, int imm8, int intRes2);
                    static int ComputeStringLength<T>(T* ptr, int max);
                    static int ComputeStrCmpIntRes2<T>(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes);
                    static /*0x252b098*/ Unity.Burst.Intrinsics.v128 cmpistrm(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252b218*/ int cmpistri(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252b398*/ Unity.Burst.Intrinsics.v128 cmpestrm(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252b558*/ int cmpestri(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252b718*/ int cmpistrz(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252b808*/ int cmpistrc(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252b8b4*/ int cmpistrs(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252b9a4*/ int cmpistro(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252bbf0*/ int cmpistra(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int imm8);
                    static /*0x252bc98*/ int cmpestrz(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252bcb4*/ int cmpestrc(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252be5c*/ int cmpestrs(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252be78*/ int cmpestro(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252c01c*/ int cmpestra(Unity.Burst.Intrinsics.v128 a, int la, Unity.Burst.Intrinsics.v128 b, int lb, int imm8);
                    static /*0x252c0e0*/ Unity.Burst.Intrinsics.v128 cmpgt_epi64(Unity.Burst.Intrinsics.v128 val1, Unity.Burst.Intrinsics.v128 val2);
                    static /*0x252c0f4*/ uint crc32_u32(uint crc, uint v);
                    static /*0x252c170*/ uint crc32_u8(uint crc, byte v);
                    static /*0x252c204*/ uint crc32_u16(uint crc, ushort v);
                    static /*0x252c270*/ ulong crc32_u64(ulong crc_ul, long v);
                    static /*0x252c2d4*/ ulong crc32_u64(ulong crc_ul, ulong v);

                    enum SIDD
                    {
                        UBYTE_OPS = 0,
                        UWORD_OPS = 1,
                        SBYTE_OPS = 2,
                        SWORD_OPS = 3,
                        CMP_EQUAL_ANY = 0,
                        CMP_RANGES = 4,
                        CMP_EQUAL_EACH = 8,
                        CMP_EQUAL_ORDERED = 12,
                        POSITIVE_POLARITY = 0,
                        NEGATIVE_POLARITY = 16,
                        MASKED_POSITIVE_POLARITY = 32,
                        MASKED_NEGATIVE_POLARITY = 48,
                        LEAST_SIGNIFICANT = 0,
                        MOST_SIGNIFICANT = 64,
                        BIT_MASK = 0,
                        UNIT_MASK = 64,
                    }

                    struct StrBoolArray
                    {
                        /*0x10*/ Unity.Burst.Intrinsics.X86.Sse4_2.StrBoolArray.<Bits> Bits;

                        /*0x252c40c*/ void SetBit(int aindex, int bindex, bool val);
                        /*0x252c430*/ bool GetBit(int aindex, int bindex);

                        struct <Bits>e__FixedBuffer
                        {
                            /*0x10*/ ushort FixedElementField;
                        }
                    }
                }

                class Ssse3
                {
                    static /*0x252c448*/ bool get_IsSsse3Supported();
                    static /*0x252c450*/ Unity.Burst.Intrinsics.v128 abs_epi8(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252c508*/ Unity.Burst.Intrinsics.v128 abs_epi16(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252c5c0*/ Unity.Burst.Intrinsics.v128 abs_epi32(Unity.Burst.Intrinsics.v128 a);
                    static /*0x252c678*/ Unity.Burst.Intrinsics.v128 shuffle_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252c6f8*/ Unity.Burst.Intrinsics.v128 alignr_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b, int count);
                    static /*0x252c798*/ Unity.Burst.Intrinsics.v128 hadd_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252c824*/ Unity.Burst.Intrinsics.v128 hadds_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252c8d0*/ Unity.Burst.Intrinsics.v128 hadd_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252c8fc*/ Unity.Burst.Intrinsics.v128 hsub_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252c988*/ Unity.Burst.Intrinsics.v128 hsubs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252ca34*/ Unity.Burst.Intrinsics.v128 hsub_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252ca60*/ Unity.Burst.Intrinsics.v128 maddubs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252cafc*/ Unity.Burst.Intrinsics.v128 mulhrs_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252cb78*/ Unity.Burst.Intrinsics.v128 sign_epi8(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252cbf8*/ Unity.Burst.Intrinsics.v128 sign_epi16(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                    static /*0x252cc78*/ Unity.Burst.Intrinsics.v128 sign_epi32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                }
            }
        }

        namespace CompilerServices
        {
            class Aliasing
            {
                static /*0x252ccf8*/ void ExpectAliased(void* a, void* b);
                static void ExpectAliased<A, B>(ref A a, ref B b);
                static void ExpectAliased<B>(void* a, ref B b);
                static void ExpectAliased<A>(ref A a, void* b);
                static /*0x252ccfc*/ void ExpectNotAliased(void* a, void* b);
                static void ExpectNotAliased<A, B>(ref A a, ref B b);
                static void ExpectNotAliased<B>(void* a, ref B b);
                static void ExpectNotAliased<A>(ref A a, void* b);
            }

            class AssumeRangeAttribute : System.Attribute
            {
                /*0x252cd00*/ AssumeRangeAttribute(long min, long max);
                /*0x252cd08*/ AssumeRangeAttribute(ulong min, ulong max);
            }

            class Constant
            {
                static bool IsConstantExpression<T>(T t);
                static /*0x252cd10*/ bool IsConstantExpression(void* t);
            }

            class Hint
            {
                static /*0x252cd18*/ bool Likely(bool condition);
                static /*0x252cd20*/ bool Unlikely(bool condition);
                static /*0x252cd28*/ void Assume(bool condition);
            }

            class IgnoreWarningAttribute : System.Attribute
            {
                /*0x252cd2c*/ IgnoreWarningAttribute(int warning);
            }

            class SkipLocalsInitAttribute : System.Attribute
            {
                /*0x252cd34*/ SkipLocalsInitAttribute();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA;
    static /*0x100*/ <PrivateImplementationDetails> 6AC12597E10FFB084DEE014EEBFD52580EB845FD6B5CCA643AEAC527F7B02F2A;
    static /*0x500*/ <PrivateImplementationDetails> 80E69247CBC7E738ECDB10A5DCF3EF62BB27B3AB61C6ECF146B2C57CEFFB212F;
    static /*0x900*/ <PrivateImplementationDetails> A199F717FBA4D1378A33D65E9660E45ADC176876A3450BACF2A80DA985FBDF14;
    static /*0xb00*/ <PrivateImplementationDetails> C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C;
    static /*0xb20*/ long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010;
    static /*0xb28*/ <PrivateImplementationDetails> D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E;

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=512
    {
    }

    struct __StaticArrayInitTypeSize=1024
    {
    }
}
