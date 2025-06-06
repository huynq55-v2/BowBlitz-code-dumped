class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestAssetBundle
        {
            static /*0x2ac418c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.Hash128 hash, uint crc);
        }

        class DownloadHandlerAssetBundle : UnityEngine.Networking.DownloadHandler
        {
            static /*0x2ac42f0*/ nint CreateCached(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, UnityEngine.Hash128 hash, uint crc);
            static /*0x2ac44c0*/ UnityEngine.AssetBundle GetContent(UnityEngine.Networking.UnityWebRequest www);
            static /*0x2ac4360*/ nint CreateCached_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, ref UnityEngine.Hash128 hash, uint crc);
            /*0x2ac4264*/ DownloadHandlerAssetBundle(string url, UnityEngine.Hash128 hash, uint crc);
            /*0x2ac43cc*/ void InternalCreateAssetBundleCached(string url, string name, UnityEngine.Hash128 hash, uint crc);
            /*0x2ac43e4*/ byte[] GetData();
            /*0x2ac4434*/ string GetText();
            /*0x2ac4484*/ UnityEngine.AssetBundle get_assetBundle();
        }
    }
}
