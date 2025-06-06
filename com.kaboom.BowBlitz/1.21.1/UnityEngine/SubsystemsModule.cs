class <Module>
{
}

namespace UnityEngine
{
    class IntegratedSubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ nint m_Ptr;

        /*0x293af3c*/ IntegratedSubsystemDescriptor();
        /*0x293aec4*/ string get_id();
    }

    class IntegratedSubsystemDescriptor<TSubsystem> : UnityEngine.IntegratedSubsystemDescriptor
    {
        IntegratedSubsystemDescriptor();
    }

    class SubsystemDescriptorBindings
    {
        static /*0x293af00*/ string GetId(nint descriptorPtr);
    }

    class SubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ string <id>k__BackingField;

        /*0x293af4c*/ SubsystemDescriptor();
        /*0x293af44*/ string get_id();
    }

    class Internal_SubsystemDescriptors
    {
        static /*0x293af54*/ void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor);
    }

    class IntegratedSubsystem : UnityEngine.ISubsystem
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor;

        /*0x293b148*/ IntegratedSubsystem();
        /*0x293b020*/ void SetHandle(UnityEngine.IntegratedSubsystem subsystem);
        /*0x293b064*/ bool get_running();
        /*0x293b0b8*/ bool get_valid();
        /*0x293b10c*/ bool IsRunning();
    }

    class IntegratedSubsystem<TSubsystemDescriptor> : UnityEngine.IntegratedSubsystem
    {
        IntegratedSubsystem();
    }

    interface ISubsystem
    {
    }

    class SubsystemManager
    {
        static /*0x0*/ System.Action reloadSubsytemsStarted;
        static /*0x8*/ System.Action reloadSubsytemsCompleted;
        static /*0x10*/ System.Action beforeReloadSubsystems;
        static /*0x18*/ System.Action afterReloadSubsystems;
        static /*0x20*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystem> s_IntegratedSubsystems;
        static /*0x28*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems;
        static /*0x30*/ System.Collections.Generic.List<UnityEngine.Subsystem> s_DeprecatedSubsystems;

        static /*0x293b150*/ SubsystemManager();
        static void GetInstances<T>(System.Collections.Generic.List<T> subsystems);
        static void GetSubsystems<T>(System.Collections.Generic.List<T> subsystems);
        static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<TQueryType> copyTo);
        static /*0x293b2b8*/ UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(nint ptr);
        static /*0x293b43c*/ void ReloadSubsystemsStarted();
        static /*0x293b51c*/ void ReloadSubsystemsCompleted();
        static /*0x293b5fc*/ void InitializeIntegratedSubsystem(nint ptr, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x293b704*/ void ClearSubsystems();
        static /*0x293b290*/ void StaticConstructScriptingClassMap();
    }

    class Subsystem : UnityEngine.ISubsystem
    {
        /*0x293b978*/ Subsystem();
    }

    interface ISubsystemDescriptor
    {
        string get_id();
    }

    namespace SubsystemsImplementation
    {
        class SubsystemDescriptorStore
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors;

            static /*0x293bc7c*/ SubsystemDescriptorStore();
            static /*0x293afa8*/ void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor);
            static /*0x293b980*/ void InitializeManagedDescriptor(nint ptr, UnityEngine.IntegratedSubsystemDescriptor desc);
            static /*0x293ba5c*/ void ClearManagedDescriptors();
            static /*0x293bc40*/ void ReportSingleSubsystemAnalytics(string id);
            static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList);
        }

        class SubsystemDescriptorWithProvider : UnityEngine.ISubsystemDescriptor
        {
            /*0x10*/ string <id>k__BackingField;

            /*0x293bda8*/ SubsystemDescriptorWithProvider();
            /*0x293bda0*/ string get_id();
        }

        class SubsystemWithProvider : UnityEngine.ISubsystem
        {
            /*0x293bdb0*/ SubsystemWithProvider();
        }
    }
}
