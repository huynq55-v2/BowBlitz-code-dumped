class <Module>
{
}

namespace UnityEngine
{
    class AssetBundle : UnityEngine.Object
    {
        static /*0x28057b4*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset);
        static /*0x2805808*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path);
        static /*0x280584c*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset);
        static /*0x28058a0*/ UnityEngine.AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset);
        static /*0x28058f4*/ UnityEngine.AssetBundle LoadFromFile(string path);
        static /*0x2805938*/ UnityEngine.AssetBundle LoadFromFile(string path, uint crc, ulong offset);
        static /*0x280598c*/ UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc);
        static /*0x28059d0*/ UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary);
        static /*0x2805a10*/ UnityEngine.AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc);
        static /*0x2805a54*/ UnityEngine.AssetBundle LoadFromMemory(byte[] binary);
        static /*0x2805a94*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x2805ba4*/ UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream, uint crc, uint managedReadBufferSize);
        static /*0x2805c50*/ UnityEngine.AssetBundle LoadFromStream(System.IO.Stream stream, uint crc, uint managedReadBufferSize);
        static /*0x2805bfc*/ UnityEngine.AssetBundleCreateRequest LoadFromStreamAsyncInternal(System.IO.Stream stream, uint crc, uint managedReadBufferSize);
        static /*0x2805ca8*/ UnityEngine.AssetBundle LoadFromStreamInternal(System.IO.Stream stream, uint crc, uint managedReadBufferSize);
        /*0x280575c*/ AssetBundle();
        /*0x2805cfc*/ UnityEngine.Object LoadAsset(string name);
        /*0x2805d88*/ UnityEngine.Object LoadAsset(string name, System.Type type);
        /*0x2805e94*/ UnityEngine.Object LoadAsset_Internal(string name, System.Type type);
        /*0x2805ee8*/ UnityEngine.AssetBundleRequest LoadAssetAsync(string name);
        /*0x2805f74*/ UnityEngine.AssetBundleRequest LoadAssetAsync(string name, System.Type type);
        /*0x28060d4*/ UnityEngine.Object[] LoadAssetWithSubAssets(string name);
        /*0x2806160*/ UnityEngine.Object[] LoadAssetWithSubAssets(string name, System.Type type);
        /*0x28062c0*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name);
        /*0x280634c*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, System.Type type);
        /*0x2806080*/ UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type);
        /*0x28064ac*/ void Unload(bool unloadAllLoadedObjects);
        /*0x280626c*/ UnityEngine.Object[] LoadAssetWithSubAssets_Internal(string name, System.Type type);
        /*0x2806458*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, System.Type type);
    }

    class AssetBundleRecompressOperation : UnityEngine.AsyncOperation
    {
    }

    class AssetBundleRequest : UnityEngine.ResourceRequest
    {
        /*0x2806574*/ AssetBundleRequest();
        /*0x28064f0*/ UnityEngine.Object GetResult();
        /*0x280652c*/ UnityEngine.Object get_asset();
        /*0x2806538*/ UnityEngine.Object[] get_allAssets();
    }

    class AssetBundleCreateRequest : UnityEngine.AsyncOperation
    {
        /*0x28065b8*/ AssetBundleCreateRequest();
        /*0x280657c*/ UnityEngine.AssetBundle get_assetBundle();
    }
}
