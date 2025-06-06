class <Module>
{
}

namespace HybridCLR
{
    enum HomologousImageMode
    {
        Consistent = 0,
        SuperSet = 1,
    }

    enum LoadImageErrorCode
    {
        OK = 0,
        BAD_IMAGE = 1,
        NOT_IMPLEMENT = 2,
        AOT_ASSEMBLY_NOT_FIND = 3,
        HOMOLOGOUS_ONLY_SUPPORT_AOT_ASSEMBLY = 4,
        HOMOLOGOUS_ASSEMBLY_HAS_LOADED = 5,
        INVALID_HOMOLOGOUS_MODE = 6,
    }

    class ReversePInvokeWrapperGenerationAttribute : System.Attribute
    {
        /*0x10*/ int <ReserveWrapperCount>k__BackingField;

        /*0x1e94918*/ ReversePInvokeWrapperGenerationAttribute(int reserveWrapperCount);
        /*0x1e94910*/ int get_ReserveWrapperCount();
    }

    class RuntimeApi
    {
        static string dllName = "il2cpp";

        static /*0x1e94940*/ HybridCLR.LoadImageErrorCode LoadMetadataForAOTAssembly(byte[] dllBytes, HybridCLR.HomologousImageMode mode);
        static /*0x1e94968*/ int LoadMetadataForAOTAssembly(byte* dllBytes, int dllSize, int mode);
        static /*0x1e949fc*/ int GetInterpreterThreadObjectStackSize();
        static /*0x1e94a64*/ void SetInterpreterThreadObjectStackSize(int size);
        static /*0x1e94ae0*/ int GetInterpreterThreadFrameStackSize();
        static /*0x1e94b48*/ void SetInterpreterThreadFrameStackSize(int size);
    }
}
