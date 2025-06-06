class <Module>
{
}

namespace YooAsset
{
    class AssetReference
    {
        /*0x2acf5c8*/ AssetReference();
    }

    class AssetSystemImpl
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, YooAsset.SceneOperationHandle> _sceneHandles;
        static /*0x8*/ long _sceneCreateCount;
        /*0x10*/ System.Collections.Generic.Dictionary<string, YooAsset.BundleLoaderBase> _loaderDic;
        /*0x18*/ System.Collections.Generic.List<YooAsset.BundleLoaderBase> _loaderList;
        /*0x20*/ System.Collections.Generic.Dictionary<string, YooAsset.ProviderBase> _providerDic;
        /*0x28*/ System.Collections.Generic.List<YooAsset.ProviderBase> _providerList;
        /*0x30*/ bool _isUnloadSafe;
        /*0x38*/ string _packageName;
        /*0x40*/ bool _simulationOnEditor;
        /*0x48*/ long _loadingMaxTimeSlice;
        /*0x50*/ int <DownloadFailedTryAgain>k__BackingField;
        /*0x58*/ YooAsset.IDecryptionServices <DecryptionServices>k__BackingField;
        /*0x60*/ YooAsset.IBundleServices <BundleServices>k__BackingField;
        /*0x68*/ System.Diagnostics.Stopwatch _watch;
        /*0x70*/ long _frameTime;

        static /*0x2ad2894*/ AssetSystemImpl();
        /*0x2ad2734*/ AssetSystemImpl();
        /*0x2acf5d0*/ void set_DownloadFailedTryAgain(int value);
        /*0x2acf5d8*/ int get_DownloadFailedTryAgain();
        /*0x2acf5e0*/ void set_DecryptionServices(YooAsset.IDecryptionServices value);
        /*0x2acf5e8*/ YooAsset.IDecryptionServices get_DecryptionServices();
        /*0x2acf5f0*/ void set_BundleServices(YooAsset.IBundleServices value);
        /*0x2acf5f8*/ YooAsset.IBundleServices get_BundleServices();
        /*0x2acf600*/ bool get_IsBusy();
        /*0x2acf638*/ void Initialize(string packageName, bool simulationOnEditor, long loadingMaxTimeSlice, int downloadFailedTryAgain, YooAsset.IDecryptionServices decryptionServices, YooAsset.IBundleServices bundleServices);
        /*0x2acf6d8*/ void Update();
        /*0x2acf8d8*/ void DestroyAll();
        /*0x2ad0034*/ void UnloadUnusedAssets();
        /*0x2ad00a4*/ void UnloadUnusedAssetsInternal();
        /*0x2ad0544*/ void ForceUnloadAllAssets();
        /*0x2ad0890*/ YooAsset.SceneOperationHandle LoadSceneAsync(YooAsset.AssetInfo assetInfo, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        /*0x2ad10d8*/ YooAsset.AssetOperationHandle LoadAssetAsync(YooAsset.AssetInfo assetInfo);
        /*0x2ad1350*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync(YooAsset.AssetInfo assetInfo);
        /*0x2ad1550*/ YooAsset.RawFileOperationHandle LoadRawFileAsync(YooAsset.AssetInfo assetInfo);
        /*0x2ad1750*/ void UnloadSubScene(YooAsset.ProviderBase provider);
        /*0x2ad0c74*/ void UnloadAllScene();
        /*0x2acfc0c*/ void ClearSceneHandle();
        /*0x2ad18dc*/ YooAsset.BundleLoaderBase CreateOwnerAssetBundleLoader(YooAsset.AssetInfo assetInfo);
        /*0x2ad1b0c*/ System.Collections.Generic.List<YooAsset.BundleLoaderBase> CreateDependAssetBundleLoaders(YooAsset.AssetInfo assetInfo);
        /*0x2ad1cc8*/ void RemoveBundleProviders(System.Collections.Generic.List<YooAsset.ProviderBase> providers);
        /*0x2ad1e84*/ bool CheckBundleDestroyed(int bundleID);
        /*0x2ad1990*/ YooAsset.BundleLoaderBase CreateAssetBundleLoaderInternal(YooAsset.BundleInfo bundleInfo);
        /*0x2ad1f58*/ YooAsset.BundleLoaderBase TryGetAssetBundleLoader(string bundleName);
        /*0x2ad12d0*/ YooAsset.ProviderBase TryGetProvider(string providerGUID);
        /*0x2ad1fdc*/ System.Collections.Generic.List<YooAsset.DebugProviderInfo> GetDebugReportInfos();
        /*0x2ad252c*/ System.Collections.Generic.List<YooAsset.BundleInfo> GetLoadedBundleInfos();
    }

    class AssetOperationHandle : YooAsset.OperationHandleBase, System.IDisposable
    {
        /*0x20*/ System.Action<YooAsset.AssetOperationHandle> _callback;

        /*0x2ad2930*/ AssetOperationHandle(YooAsset.ProviderBase provider);
        /*0x2ad296c*/ void InvokeCallback();
        /*0x2ad298c*/ void add_Completed(System.Action<YooAsset.AssetOperationHandle> value);
        /*0x2ad2c08*/ void remove_Completed(System.Action<YooAsset.AssetOperationHandle> value);
        /*0x2ad2d08*/ void WaitForAsyncComplete();
        /*0x2ad2e08*/ void Release();
        /*0x2ad2e0c*/ void Dispose();
        /*0x2ad2e10*/ UnityEngine.Object get_AssetObject();
        TAsset GetAssetObject<TAsset>();
        /*0x2ad2e40*/ UnityEngine.GameObject InstantiateSync();
        /*0x2ad301c*/ UnityEngine.GameObject InstantiateSync(UnityEngine.Transform parent);
        /*0x2ad30d4*/ UnityEngine.GameObject InstantiateSync(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x2ad3198*/ UnityEngine.GameObject InstantiateSync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x2ad31a8*/ UnityEngine.GameObject InstantiateSync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x2ad31b8*/ YooAsset.InstantiateOperation InstantiateAsync();
        /*0x2ad3378*/ YooAsset.InstantiateOperation InstantiateAsync(UnityEngine.Transform parent);
        /*0x2ad3430*/ YooAsset.InstantiateOperation InstantiateAsync(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x2ad34f4*/ YooAsset.InstantiateOperation InstantiateAsync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x2ad3504*/ YooAsset.InstantiateOperation InstantiateAsync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        /*0x2ad2ef4*/ UnityEngine.GameObject InstantiateSyncInternal(bool setPositionAndRotation, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x2ad326c*/ YooAsset.InstantiateOperation InstantiateAsyncInternal(bool setPositionAndRotation, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool worldPositionStays);
    }

    class OperationHandleBase : System.Collections.IEnumerator
    {
        /*0x10*/ YooAsset.AssetInfo _assetInfo;
        /*0x18*/ YooAsset.ProviderBase <Provider>k__BackingField;

        /*0x2ad2934*/ OperationHandleBase(YooAsset.ProviderBase provider);
        /*0x2ad38f4*/ void set_Provider(YooAsset.ProviderBase value);
        /*0x2ad38fc*/ YooAsset.ProviderBase get_Provider();
        void InvokeCallback();
        /*0x2ad3904*/ YooAsset.AssetInfo GetAssetInfo();
        /*0x2ad390c*/ YooAsset.DownloadReport GetDownloadReport();
        /*0x2ad3b38*/ YooAsset.EOperationStatus get_Status();
        /*0x2ad3b80*/ string get_LastError();
        /*0x2ad3bec*/ float get_Progress();
        /*0x2ad3c18*/ bool get_IsDone();
        /*0x2ad3c54*/ bool get_IsValid();
        /*0x2ad2acc*/ bool get_IsValidWithWarning();
        /*0x2ad18ac*/ void ReleaseInternal();
        /*0x2ad3d58*/ System.Threading.Tasks.Task get_Task();
        /*0x2ad3e38*/ bool System.Collections.IEnumerator.MoveNext();
        /*0x2ad3e50*/ void System.Collections.IEnumerator.Reset();
        /*0x2ad3e54*/ object System.Collections.IEnumerator.get_Current();
    }

    class RawFileOperationHandle : YooAsset.OperationHandleBase, System.IDisposable
    {
        /*0x20*/ System.Action<YooAsset.RawFileOperationHandle> _callback;

        /*0x2ad3e5c*/ RawFileOperationHandle(YooAsset.ProviderBase provider);
        /*0x2ad3e60*/ void InvokeCallback();
        /*0x2ad3e80*/ void add_Completed(System.Action<YooAsset.RawFileOperationHandle> value);
        /*0x2ad3fc0*/ void remove_Completed(System.Action<YooAsset.RawFileOperationHandle> value);
        /*0x2ad40c0*/ void WaitForAsyncComplete();
        /*0x2ad40ec*/ void Release();
        /*0x2ad40f0*/ void Dispose();
        /*0x2ad40f4*/ byte[] GetRawFileData();
        /*0x2ad4140*/ string GetRawFileText();
        /*0x2ad4198*/ string GetRawFilePath();
    }

    class SceneOperationHandle : YooAsset.OperationHandleBase
    {
        /*0x20*/ System.Action<YooAsset.SceneOperationHandle> _callback;
        /*0x28*/ string <PackageName>k__BackingField;

        /*0x2ad4214*/ SceneOperationHandle(YooAsset.ProviderBase provider);
        /*0x2ad4204*/ void set_PackageName(string value);
        /*0x2ad420c*/ string get_PackageName();
        /*0x2ad4218*/ void InvokeCallback();
        /*0x2ad4238*/ void add_Completed(System.Action<YooAsset.SceneOperationHandle> value);
        /*0x2ad4378*/ void remove_Completed(System.Action<YooAsset.SceneOperationHandle> value);
        /*0x2ad4478*/ UnityEngine.SceneManagement.Scene get_SceneObject();
        /*0x2ad44a8*/ bool ActivateScene();
        /*0x2ad45b8*/ bool IsMainScene();
        /*0x2ad468c*/ YooAsset.UnloadSceneOperation UnloadAsync();
    }

    class SubAssetsOperationHandle : YooAsset.OperationHandleBase, System.IDisposable
    {
        /*0x20*/ System.Action<YooAsset.SubAssetsOperationHandle> _callback;

        /*0x2ad4838*/ SubAssetsOperationHandle(YooAsset.ProviderBase provider);
        /*0x2ad483c*/ void InvokeCallback();
        /*0x2ad485c*/ void add_Completed(System.Action<YooAsset.SubAssetsOperationHandle> value);
        /*0x2ad499c*/ void remove_Completed(System.Action<YooAsset.SubAssetsOperationHandle> value);
        /*0x2ad4a9c*/ void WaitForAsyncComplete();
        /*0x2ad4ac8*/ void Release();
        /*0x2ad4acc*/ void Dispose();
        /*0x2ad4ad0*/ UnityEngine.Object[] get_AllAssetObjects();
        TObject GetSubAssetObject<TObject>(string assetName);
        TObject[] GetSubAssetObjects<TObject>();
    }

    class AssetBundleFileLoader : YooAsset.BundleLoaderBase
    {
        /*0x60*/ YooAsset.AssetBundleFileLoader.ESteps _steps;
        /*0x64*/ bool _isWaitForAsyncComplete;
        /*0x65*/ bool _isShowWaitForAsyncError;
        /*0x68*/ YooAsset.DownloaderBase _unpacker;
        /*0x70*/ YooAsset.DownloaderBase _downloader;
        /*0x78*/ UnityEngine.AssetBundleCreateRequest _createRequest;
        /*0x80*/ System.IO.Stream _stream;

        /*0x2ad1fd8*/ AssetBundleFileLoader(YooAsset.AssetSystemImpl impl, YooAsset.BundleInfo bundleInfo);
        /*0x2ad4b9c*/ void Update();
        /*0x2ad5964*/ void Destroy(bool forceDestroy);
        /*0x2ad5afc*/ void WaitForAsyncComplete();

        enum ESteps
        {
            None = 0,
            Download = 1,
            CheckDownload = 2,
            Unpack = 3,
            CheckUnpack = 4,
            LoadFile = 5,
            CheckLoadFile = 6,
            Done = 7,
        }
    }

    class AssetBundleWebLoader : YooAsset.BundleLoaderBase
    {
        /*0x60*/ YooAsset.AssetBundleWebLoader.ESteps _steps;
        /*0x64*/ float _tryTimer;
        /*0x68*/ YooAsset.DownloaderBase _downloader;
        /*0x70*/ UnityEngine.Networking.UnityWebRequest _webRequest;
        /*0x78*/ UnityEngine.AssetBundleCreateRequest _createRequest;

        /*0x2ad5c1c*/ AssetBundleWebLoader(YooAsset.AssetSystemImpl impl, YooAsset.BundleInfo bundleInfo);
        /*0x2ad5c20*/ void Update();
        /*0x2ad6254*/ void WaitForAsyncComplete();

        enum ESteps
        {
            None = 0,
            Download = 1,
            CheckDownload = 2,
            LoadCacheFile = 3,
            CheckLoadCacheFile = 4,
            LoadWebFile = 5,
            CheckLoadWebFile = 6,
            TryLoadWebFile = 7,
            Done = 8,
        }
    }

    class BundleLoaderBase
    {
        /*0x10*/ YooAsset.AssetSystemImpl <Impl>k__BackingField;
        /*0x18*/ YooAsset.BundleInfo <MainBundleInfo>k__BackingField;
        /*0x20*/ int <RefCount>k__BackingField;
        /*0x24*/ YooAsset.BundleLoaderBase.EStatus <Status>k__BackingField;
        /*0x28*/ string <LastError>k__BackingField;
        /*0x30*/ bool <IsDestroyed>k__BackingField;
        /*0x38*/ System.Collections.Generic.List<YooAsset.ProviderBase> _providers;
        /*0x40*/ UnityEngine.AssetBundle <CacheBundle>k__BackingField;
        /*0x48*/ string <FileLoadPath>k__BackingField;
        /*0x50*/ float <DownloadProgress>k__BackingField;
        /*0x58*/ ulong <DownloadedBytes>k__BackingField;

        /*0x2ad4b00*/ BundleLoaderBase(YooAsset.AssetSystemImpl impl, YooAsset.BundleInfo bundleInfo);
        /*0x2ad62c4*/ void set_Impl(YooAsset.AssetSystemImpl value);
        /*0x2ad62cc*/ YooAsset.AssetSystemImpl get_Impl();
        /*0x2ad62d4*/ void set_MainBundleInfo(YooAsset.BundleInfo value);
        /*0x2ad62dc*/ YooAsset.BundleInfo get_MainBundleInfo();
        /*0x2ad62e4*/ void set_RefCount(int value);
        /*0x2ad62ec*/ int get_RefCount();
        /*0x2ad62f4*/ void set_Status(YooAsset.BundleLoaderBase.EStatus value);
        /*0x2ad62fc*/ YooAsset.BundleLoaderBase.EStatus get_Status();
        /*0x2ad6304*/ void set_LastError(string value);
        /*0x2ad630c*/ string get_LastError();
        /*0x2ad6314*/ void set_IsDestroyed(bool value);
        /*0x2ad6320*/ bool get_IsDestroyed();
        /*0x2ad6328*/ void set_CacheBundle(UnityEngine.AssetBundle value);
        /*0x2ad6330*/ UnityEngine.AssetBundle get_CacheBundle();
        /*0x2ad6338*/ void set_FileLoadPath(string value);
        /*0x2ad6340*/ string get_FileLoadPath();
        /*0x2ad6348*/ void set_DownloadProgress(float value);
        /*0x2ad6350*/ float get_DownloadProgress();
        /*0x2ad6358*/ void set_DownloadedBytes(ulong value);
        /*0x2ad6360*/ ulong get_DownloadedBytes();
        /*0x2ad6368*/ void AddProvider(YooAsset.ProviderBase provider);
        /*0x2ad643c*/ void Reference();
        /*0x2ad644c*/ void Release();
        /*0x2ad5c08*/ bool IsDone();
        /*0x2ad0498*/ bool CanDestroy();
        /*0x2ad01f0*/ void TryDestroyAllProviders();
        void Update();
        /*0x2ad59ac*/ void Destroy(bool forceDestroy);
        void WaitForAsyncComplete();

        enum EStatus
        {
            None = 0,
            Succeed = 1,
            Failed = 2,
        }
    }

    class DependAssetBundleGroup
    {
        /*0x10*/ System.Collections.Generic.List<YooAsset.BundleLoaderBase> DependBundles;

        /*0x2ad6484*/ DependAssetBundleGroup(System.Collections.Generic.List<YooAsset.BundleLoaderBase> dpendBundles);
        /*0x2ad64ac*/ bool IsDone();
        /*0x2ad6614*/ bool IsSucceed();
        /*0x2ad6778*/ string GetLastError();
        /*0x2ad68f0*/ void WaitForAsyncComplete();
        /*0x2ad6a54*/ void Reference();
        /*0x2ad6ba0*/ void Release();
        /*0x2ad6cec*/ void GetBundleDebugInfos(System.Collections.Generic.List<YooAsset.DebugBundleInfo> output);
    }

    enum EBundleLoadMethod
    {
        Normal = 0,
        LoadFromFileOffset = 1,
        LoadFromMemory = 2,
        LoadFromStream = 3,
    }

    class RawBundleFileLoader : YooAsset.BundleLoaderBase
    {
        /*0x60*/ YooAsset.RawBundleFileLoader.ESteps _steps;
        /*0x68*/ YooAsset.DownloaderBase _unpacker;
        /*0x70*/ YooAsset.DownloaderBase _downloader;

        /*0x2ad1fd4*/ RawBundleFileLoader(YooAsset.AssetSystemImpl impl, YooAsset.BundleInfo bundleInfo);
        /*0x2ad6f7c*/ void Update();
        /*0x2ad727c*/ void WaitForAsyncComplete();

        enum ESteps
        {
            None = 0,
            Download = 1,
            CheckDownload = 2,
            Unpack = 3,
            CheckUnpack = 4,
            CheckFile = 5,
            Done = 6,
        }
    }

    class RawBundleWebLoader : YooAsset.BundleLoaderBase
    {
        /*0x60*/ YooAsset.RawBundleWebLoader.ESteps _steps;
        /*0x68*/ YooAsset.DownloaderBase _website;
        /*0x70*/ YooAsset.DownloaderBase _downloader;

        /*0x2ad7390*/ RawBundleWebLoader(YooAsset.AssetSystemImpl impl, YooAsset.BundleInfo bundleInfo);
        /*0x2ad7394*/ void Update();
        /*0x2ad7694*/ void WaitForAsyncComplete();

        enum ESteps
        {
            None = 0,
            Download = 1,
            CheckDownload = 2,
            Website = 3,
            CheckWebsite = 4,
            CheckFile = 5,
            Done = 6,
        }
    }

    class VirtualBundleFileLoader : YooAsset.BundleLoaderBase
    {
        /*0x60*/ YooAsset.VirtualBundleFileLoader.ESteps _steps;

        /*0x2ad1fd0*/ VirtualBundleFileLoader(YooAsset.AssetSystemImpl impl, YooAsset.BundleInfo bundleInfo);
        /*0x2ad7704*/ void Update();
        /*0x2ad77f8*/ void WaitForAsyncComplete();

        enum ESteps
        {
            None = 0,
            CheckFile = 1,
            Done = 2,
        }
    }

    class InstantiateOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ YooAsset.AssetOperationHandle _handle;
        /*0x40*/ bool _setPositionAndRotation;
        /*0x44*/ UnityEngine.Vector3 _position;
        /*0x50*/ UnityEngine.Quaternion _rotation;
        /*0x60*/ UnityEngine.Transform _parent;
        /*0x68*/ bool _worldPositionStays;
        /*0x6c*/ YooAsset.InstantiateOperation.ESteps _steps;
        /*0x70*/ UnityEngine.GameObject Result;

        static /*0x2ad3514*/ UnityEngine.GameObject InstantiateInternal(UnityEngine.Object assetObject, bool setPositionAndRotation, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x2ad3780*/ InstantiateOperation(YooAsset.AssetOperationHandle handle, bool setPositionAndRotation, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool worldPositionStays);
        /*0x2ad78e4*/ void Start();
        /*0x2ad78f0*/ void Update();
        /*0x2ad7a1c*/ void Cancel();
        /*0x2ad7a94*/ void WaitForAsyncComplete();

        enum ESteps
        {
            None = 0,
            Clone = 1,
            Done = 2,
        }
    }

    class UnloadSceneOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ YooAsset.UnloadSceneOperation.EFlag _flag;
        /*0x3c*/ YooAsset.UnloadSceneOperation.ESteps _steps;
        /*0x40*/ UnityEngine.SceneManagement.Scene _scene;
        /*0x48*/ UnityEngine.AsyncOperation _asyncOp;

        /*0x2ad47dc*/ UnloadSceneOperation(string error);
        /*0x2ad480c*/ UnloadSceneOperation(UnityEngine.SceneManagement.Scene scene);
        /*0x2ad7ad4*/ void Start();
        /*0x2ad7b90*/ void Update();

        enum EFlag
        {
            Normal = 0,
            Error = 1,
        }

        enum ESteps
        {
            None = 0,
            UnLoad = 1,
            Checking = 2,
            Done = 3,
        }
    }

    class BundledAssetProvider : YooAsset.ProviderBase
    {
        /*0xb0*/ UnityEngine.AssetBundleRequest _cacheRequest;

        /*0x2ad134c*/ BundledAssetProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad7df0*/ void Update();
    }

    class BundledRawFileProvider : YooAsset.ProviderBase
    {
        /*0x2ad174c*/ BundledRawFileProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad84ec*/ void Update();
    }

    class BundledSceneProvider : YooAsset.ProviderBase
    {
        /*0xb0*/ UnityEngine.SceneManagement.LoadSceneMode SceneMode;
        /*0xb8*/ string _sceneName;
        /*0xc0*/ bool _activateOnLoad;
        /*0xc4*/ int _priority;
        /*0xc8*/ UnityEngine.AsyncOperation _asyncOp;

        /*0x2ad0fd8*/ BundledSceneProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        /*0x2ad85a8*/ void Update();
    }

    class BundledSubAssetsProvider : YooAsset.ProviderBase
    {
        /*0xb0*/ UnityEngine.AssetBundleRequest _cacheRequest;

        /*0x2ad154c*/ BundledSubAssetsProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad88cc*/ void Update();
    }

    class CompletedProvider : YooAsset.ProviderBase
    {
        /*0x2ad0bf4*/ CompletedProvider(YooAsset.AssetInfo assetInfo);
        /*0x2ad8cdc*/ void Update();
        /*0x2ad0c58*/ void SetCompleted(string error);
    }

    class DatabaseAssetProvider : YooAsset.ProviderBase
    {
        /*0x2ad1348*/ DatabaseAssetProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad8ce0*/ void Update();
    }

    class DatabaseRawFileProvider : YooAsset.ProviderBase
    {
        /*0x2ad1748*/ DatabaseRawFileProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad8ce4*/ void Update();
    }

    class DatabaseSceneProvider : YooAsset.ProviderBase
    {
        /*0xb0*/ UnityEngine.SceneManagement.LoadSceneMode SceneMode;
        /*0xb4*/ bool _activateOnLoad;
        /*0xb8*/ int _priority;
        /*0xc0*/ UnityEngine.AsyncOperation _asyncOp;

        /*0x2ad0f9c*/ DatabaseSceneProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        /*0x2ad8ce8*/ void Update();
    }

    class DatabaseSubAssetsProvider : YooAsset.ProviderBase
    {
        /*0x2ad1548*/ DatabaseSubAssetsProvider(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad8cec*/ void Update();
    }

    class ProviderBase
    {
        /*0x10*/ string <ProviderGUID>k__BackingField;
        /*0x18*/ YooAsset.AssetSystemImpl <Impl>k__BackingField;
        /*0x20*/ YooAsset.AssetInfo <MainAssetInfo>k__BackingField;
        /*0x28*/ UnityEngine.Object <AssetObject>k__BackingField;
        /*0x30*/ UnityEngine.Object[] <AllAssetObjects>k__BackingField;
        /*0x38*/ UnityEngine.SceneManagement.Scene <SceneObject>k__BackingField;
        /*0x40*/ string <RawFilePath>k__BackingField;
        /*0x48*/ YooAsset.ProviderBase.EStatus <Status>k__BackingField;
        /*0x50*/ string <LastError>k__BackingField;
        /*0x58*/ float <Progress>k__BackingField;
        /*0x5c*/ int <RefCount>k__BackingField;
        /*0x60*/ bool <IsDestroyed>k__BackingField;
        /*0x68*/ YooAsset.BundleLoaderBase <OwnerBundle>k__BackingField;
        /*0x70*/ YooAsset.DependAssetBundleGroup <DependBundleGroup>k__BackingField;
        /*0x78*/ bool <IsWaitForAsyncComplete>k__BackingField;
        /*0x80*/ System.Collections.Generic.List<YooAsset.OperationHandleBase> _handles;
        /*0x88*/ System.Threading.Tasks.TaskCompletionSource<object> _taskCompletionSource;
        /*0x90*/ string SpawnScene;
        /*0x98*/ string SpawnTime;
        /*0xa0*/ long <LoadingTime>k__BackingField;
        /*0xa8*/ System.Diagnostics.Stopwatch _watch;

        /*0x2ad7ca0*/ ProviderBase(YooAsset.AssetSystemImpl impl, string providerGUID, YooAsset.AssetInfo assetInfo);
        /*0x2ad8cf0*/ void set_ProviderGUID(string value);
        /*0x2ad8cf8*/ string get_ProviderGUID();
        /*0x2ad8d00*/ void set_Impl(YooAsset.AssetSystemImpl value);
        /*0x2ad8d08*/ YooAsset.AssetSystemImpl get_Impl();
        /*0x2ad8d10*/ void set_MainAssetInfo(YooAsset.AssetInfo value);
        /*0x2ad8d18*/ YooAsset.AssetInfo get_MainAssetInfo();
        /*0x2ad8d20*/ void set_AssetObject(UnityEngine.Object value);
        /*0x2ad8d28*/ UnityEngine.Object get_AssetObject();
        /*0x2ad8d30*/ void set_AllAssetObjects(UnityEngine.Object[] value);
        /*0x2ad8d38*/ UnityEngine.Object[] get_AllAssetObjects();
        /*0x2ad8d40*/ void set_SceneObject(UnityEngine.SceneManagement.Scene value);
        /*0x2ad8d48*/ UnityEngine.SceneManagement.Scene get_SceneObject();
        /*0x2ad8d50*/ void set_RawFilePath(string value);
        /*0x2ad8d58*/ string get_RawFilePath();
        /*0x2ad8d60*/ void set_Status(YooAsset.ProviderBase.EStatus value);
        /*0x2ad8d68*/ YooAsset.ProviderBase.EStatus get_Status();
        /*0x2ad8d70*/ void set_LastError(string value);
        /*0x2ad8d78*/ string get_LastError();
        /*0x2ad8d80*/ void set_Progress(float value);
        /*0x2ad8d88*/ float get_Progress();
        /*0x2ad8d90*/ void set_RefCount(int value);
        /*0x2ad8d98*/ int get_RefCount();
        /*0x2ad8da0*/ void set_IsDestroyed(bool value);
        /*0x2ad8dac*/ bool get_IsDestroyed();
        /*0x2ad2bf4*/ bool get_IsDone();
        /*0x2ad8db4*/ void set_OwnerBundle(YooAsset.BundleLoaderBase value);
        /*0x2ad8dbc*/ YooAsset.BundleLoaderBase get_OwnerBundle();
        /*0x2ad8dc4*/ void set_DependBundleGroup(YooAsset.DependAssetBundleGroup value);
        /*0x2ad8dcc*/ YooAsset.DependAssetBundleGroup get_DependBundleGroup();
        /*0x2ad8dd4*/ void set_IsWaitForAsyncComplete(bool value);
        /*0x2ad8de0*/ bool get_IsWaitForAsyncComplete();
        void Update();
        /*0x2ad8de8*/ void Destroy();
        /*0x2ad645c*/ bool CanDestroy();
        /*0x2ad8e28*/ bool IsSceneProvider();
        T CreateHandle<T>();
        /*0x2ad3c74*/ void ReleaseHandle(YooAsset.OperationHandleBase handle);
        /*0x2ad2d34*/ void WaitForAsyncComplete();
        /*0x2ad3d70*/ System.Threading.Tasks.Task get_Task();
        /*0x2ad8314*/ void InvokeCompletion();
        /*0x2ad8eac*/ void set_LoadingTime(long value);
        /*0x2ad8eb4*/ long get_LoadingTime();
        /*0x2ad8ebc*/ void InitSpawnDebugInfo();
        /*0x2ad8f44*/ string SpawnTimeToString(float spawnTime);
        /*0x2ad9268*/ void DebugBeginRecording();
        /*0x2ad92cc*/ void DebugEndRecording();
        /*0x2ad3974*/ YooAsset.DownloadReport GetDownloadReport();
        /*0x2ad23dc*/ void GetBundleDebugInfos(System.Collections.Generic.List<YooAsset.DebugBundleInfo> output);

        enum EStatus
        {
            None = 0,
            CheckBundle = 1,
            Loading = 2,
            Checking = 3,
            Succeed = 4,
            Failed = 5,
        }
    }

    class CacheFileInfo
    {
        static /*0x0*/ YooAsset.BufferWriter SharedBuffer;

        static /*0x2ad95f8*/ CacheFileInfo();
        static /*0x2ad92f0*/ void WriteInfoToFile(string filePath, string dataFileCRC, long dataFileSize);
        static /*0x2ad954c*/ void ReadInfoFromFile(string filePath, ref string dataFileCRC, ref long dataFileSize);
        /*0x2ad95f0*/ CacheFileInfo();
    }

    class CacheSystem
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, YooAsset.PackageCache> _cachedDic;
        static /*0x8*/ YooAsset.EVerifyLevel <InitVerifyLevel>k__BackingField;

        static /*0x2ada570*/ CacheSystem();
        static /*0x2ad9674*/ void set_InitVerifyLevel(YooAsset.EVerifyLevel value);
        static /*0x2ad96d0*/ YooAsset.EVerifyLevel get_InitVerifyLevel();
        static /*0x2ad9728*/ void ClearAll();
        static /*0x2ad97a0*/ int GetCachedFilesCount(string packageName);
        static /*0x2ad9960*/ bool IsCached(string packageName, string cacheGUID);
        static /*0x2ad9a28*/ void RecordFile(string packageName, string cacheGUID, YooAsset.PackageCache.RecordWrapper wrapper);
        static /*0x2ad57a8*/ void DiscardFile(string packageName, string cacheGUID);
        static /*0x2ad9c88*/ YooAsset.EVerifyResult VerifyingCacheFile(YooAsset.VerifyCacheElement element);
        static /*0x2ad9fc0*/ YooAsset.EVerifyResult VerifyingTempFile(YooAsset.VerifyTempElement element);
        static /*0x2ad56f0*/ YooAsset.EVerifyResult VerifyingRecordFile(string packageName, string cacheGUID);
        static /*0x2ada034*/ System.Collections.Generic.List<string> GetUnusedCacheGUIDs(YooAsset.ResourcePackage package);
        static /*0x2ad9ea4*/ YooAsset.EVerifyResult VerifyingInternal(string filePath, long fileSize, string fileCRC, YooAsset.EVerifyLevel verifyLevel);
        static /*0x2ad9800*/ YooAsset.PackageCache GetOrCreateCache(string packageName);
    }

    enum EVerifyLevel
    {
        Low = 0,
        Middle = 1,
        High = 2,
    }

    enum EVerifyResult
    {
        CacheNotFound = -6,
        InfoFileNotExisted = -5,
        DataFileNotExisted = -4,
        FileNotComplete = -3,
        FileOverflow = -2,
        FileCrcError = -1,
        Exception = 0,
        Succeed = 1,
    }

    class ClearUnusedCacheFilesOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ YooAsset.ResourcePackage _package;
        /*0x40*/ System.Collections.Generic.List<string> _unusedCacheGUIDs;
        /*0x48*/ int _unusedFileTotalCount;
        /*0x4c*/ YooAsset.ClearUnusedCacheFilesOperation.ESteps _steps;

        /*0x2ada610*/ ClearUnusedCacheFilesOperation(YooAsset.ResourcePackage package);
        /*0x2ada638*/ void Start();
        /*0x2ada644*/ void Update();

        enum ESteps
        {
            None = 0,
            GetUnusedCacheFiles = 1,
            ClearUnusedCacheFiles = 2,
            Done = 3,
        }
    }

    class FindCacheFilesOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _packageName;
        /*0x40*/ float _verifyStartTime;
        /*0x48*/ System.Collections.Generic.IEnumerator<System.IO.DirectoryInfo> _bundleFilesEnumerator;
        /*0x50*/ System.Collections.Generic.IEnumerator<System.IO.DirectoryInfo> _rawFilesEnumerator;
        /*0x58*/ YooAsset.FindCacheFilesOperation.ESteps _steps;
        /*0x60*/ System.Collections.Generic.List<YooAsset.VerifyCacheElement> VerifyElements;

        /*0x2ada8d0*/ FindCacheFilesOperation(string packageName);
        /*0x2ada964*/ void Start();
        /*0x2ada988*/ void Update();
        /*0x2adac00*/ bool UpdateFindBundleFiles();
        /*0x2adaf28*/ bool UpdateFindRawFiles();

        enum ESteps
        {
            None = 0,
            FindPrepare = 1,
            FindBundleFiles = 2,
            FindRawFiles = 3,
            Done = 4,
        }
    }

    class VerifyCacheFilesOperation : YooAsset.AsyncOperationBase
    {
        static /*0x2adb388*/ YooAsset.VerifyCacheFilesOperation CreateOperation(System.Collections.Generic.List<YooAsset.VerifyCacheElement> elements);
        /*0x2adb460*/ VerifyCacheFilesOperation();
    }

    class VerifyCacheFilesWithThreadOperation : YooAsset.VerifyCacheFilesOperation
    {
        /*0x38*/ YooAsset.ThreadSyncContext _syncContext;
        /*0x40*/ System.Collections.Generic.List<YooAsset.VerifyCacheElement> _waitingList;
        /*0x48*/ System.Collections.Generic.List<YooAsset.VerifyCacheElement> _verifyingList;
        /*0x50*/ int _verifyMaxNum;
        /*0x54*/ int _verifyTotalCount;
        /*0x58*/ float _verifyStartTime;
        /*0x5c*/ int _succeedCount;
        /*0x60*/ int _failedCount;
        /*0x64*/ YooAsset.VerifyCacheFilesWithThreadOperation.ESteps _steps;

        /*0x2adb3e8*/ VerifyCacheFilesWithThreadOperation(System.Collections.Generic.List<YooAsset.VerifyCacheElement> elements);
        /*0x2adb4e4*/ void Start();
        /*0x2adb508*/ void Update();
        /*0x2adb874*/ float GetProgress();
        /*0x2adb89c*/ bool BeginVerifyFileWithThread(YooAsset.VerifyCacheElement element);
        /*0x2adb92c*/ void VerifyInThread(object obj);
        /*0x2adba4c*/ void VerifyCallback(object obj);

        enum ESteps
        {
            None = 0,
            InitVerify = 1,
            UpdateVerify = 2,
            Done = 3,
        }
    }

    class VerifyCacheFilesWithoutThreadOperation : YooAsset.VerifyCacheFilesOperation
    {
        /*0x38*/ System.Collections.Generic.List<YooAsset.VerifyCacheElement> _waitingList;
        /*0x40*/ System.Collections.Generic.List<YooAsset.VerifyCacheElement> _verifyingList;
        /*0x48*/ int _verifyMaxNum;
        /*0x4c*/ int _verifyTotalCount;
        /*0x50*/ float _verifyStartTime;
        /*0x54*/ int _succeedCount;
        /*0x58*/ int _failedCount;
        /*0x5c*/ YooAsset.VerifyCacheFilesWithoutThreadOperation.ESteps _steps;

        /*0x2adbc70*/ VerifyCacheFilesWithoutThreadOperation(System.Collections.Generic.List<YooAsset.VerifyCacheElement> elements);
        /*0x2adbc98*/ void Start();
        /*0x2adbcbc*/ void Update();
        /*0x2adbf54*/ float GetProgress();
        /*0x2adbf7c*/ void BeginVerifyFileWithoutThread(YooAsset.VerifyCacheElement element);

        enum ESteps
        {
            None = 0,
            InitVerify = 1,
            UpdateVerify = 2,
            Done = 3,
        }
    }

    class VerifyTempFileOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ YooAsset.EVerifyResult <VerifyResult>k__BackingField;

        static /*0x2adc0c8*/ YooAsset.VerifyTempFileOperation CreateOperation(YooAsset.VerifyTempElement element);
        /*0x2adc154*/ VerifyTempFileOperation();
        /*0x2adc0b8*/ void set_VerifyResult(YooAsset.EVerifyResult value);
        /*0x2adc0c0*/ YooAsset.EVerifyResult get_VerifyResult();
    }

    class VerifyTempFileWithThreadOperation : YooAsset.VerifyTempFileOperation
    {
        /*0x40*/ YooAsset.VerifyTempElement _element;
        /*0x48*/ YooAsset.VerifyTempFileWithThreadOperation.ESteps _steps;

        /*0x2adc12c*/ VerifyTempFileWithThreadOperation(YooAsset.VerifyTempElement element);
        /*0x2adc15c*/ void Start();
        /*0x2adc168*/ void Update();
        /*0x2adc274*/ bool BeginVerifyFileWithThread(YooAsset.VerifyTempElement element);
        /*0x2adc304*/ void VerifyInThread(object obj);

        enum ESteps
        {
            None = 0,
            VerifyFile = 1,
            Waiting = 2,
            Done = 3,
        }
    }

    class VerifyTempFileWithoutThreadOperation : YooAsset.VerifyTempFileOperation
    {
        /*0x40*/ YooAsset.VerifyTempElement _element;
        /*0x48*/ YooAsset.VerifyTempFileWithoutThreadOperation.ESteps _steps;

        /*0x2adc3bc*/ VerifyTempFileWithoutThreadOperation(YooAsset.VerifyTempElement element);
        /*0x2adc3e4*/ void Start();
        /*0x2adc3f0*/ void Update();

        enum ESteps
        {
            None = 0,
            VerifyFile = 1,
            Done = 2,
        }
    }

    class PackageCachingOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _packageName;
        /*0x40*/ YooAsset.FindCacheFilesOperation _findCacheFilesOp;
        /*0x48*/ YooAsset.VerifyCacheFilesOperation _verifyCacheFilesOp;
        /*0x50*/ YooAsset.PackageCachingOperation.ESteps _steps;

        /*0x2adc4f8*/ PackageCachingOperation(string packageName);
        /*0x2adc520*/ void Start();
        /*0x2adc52c*/ void Update();

        enum ESteps
        {
            None = 0,
            FindCacheFiles = 1,
            VerifyCacheFiles = 2,
            Done = 3,
        }
    }

    class PackageCache
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, YooAsset.PackageCache.RecordWrapper> _wrappers;
        /*0x18*/ string <PackageName>k__BackingField;

        /*0x2ada4e0*/ PackageCache(string packageName);
        /*0x2adc6ac*/ void set_PackageName(string value);
        /*0x2adc6b4*/ string get_PackageName();
        /*0x2adc6bc*/ void ClearAll();
        /*0x2ad9910*/ int GetCachedFilesCount();
        /*0x2ad99d0*/ bool IsCached(string cacheGUID);
        /*0x2ad9aa0*/ void Record(string cacheGUID, YooAsset.PackageCache.RecordWrapper wrapper);
        /*0x2ad9bf8*/ void Discard(string cacheGUID);
        /*0x2ad9b80*/ YooAsset.PackageCache.RecordWrapper TryGetWrapper(string cacheGUID);
        /*0x2ada298*/ System.Collections.Generic.List<string> GetAllKeys();

        class RecordWrapper
        {
            /*0x10*/ string <InfoFilePath>k__BackingField;
            /*0x18*/ string <DataFilePath>k__BackingField;
            /*0x20*/ string <DataFileCRC>k__BackingField;
            /*0x28*/ long <DataFileSize>k__BackingField;

            /*0x2adbbe4*/ RecordWrapper(string infoFilePath, string dataFilePath, string dataFileCRC, long dataFileSize);
            /*0x2adc70c*/ void set_InfoFilePath(string value);
            /*0x2adc714*/ string get_InfoFilePath();
            /*0x2adc71c*/ void set_DataFilePath(string value);
            /*0x2adc724*/ string get_DataFilePath();
            /*0x2adc72c*/ void set_DataFileCRC(string value);
            /*0x2adc734*/ string get_DataFileCRC();
            /*0x2adc73c*/ void set_DataFileSize(long value);
            /*0x2adc744*/ long get_DataFileSize();
        }
    }

    class VerifyCacheElement
    {
        /*0x10*/ string <PackageName>k__BackingField;
        /*0x18*/ string <CacheGUID>k__BackingField;
        /*0x20*/ string <FileRootPath>k__BackingField;
        /*0x28*/ string <DataFilePath>k__BackingField;
        /*0x30*/ string <InfoFilePath>k__BackingField;
        /*0x38*/ YooAsset.EVerifyResult Result;
        /*0x40*/ string DataFileCRC;
        /*0x48*/ long DataFileSize;

        /*0x2adb338*/ VerifyCacheElement(string packageName, string cacheGUID, string fileRootPath, string dataFilePath, string infoFilePath);
        /*0x2adc74c*/ void set_PackageName(string value);
        /*0x2adc754*/ string get_PackageName();
        /*0x2adc75c*/ void set_CacheGUID(string value);
        /*0x2adc764*/ string get_CacheGUID();
        /*0x2adc76c*/ void set_FileRootPath(string value);
        /*0x2adc774*/ string get_FileRootPath();
        /*0x2adc77c*/ void set_DataFilePath(string value);
        /*0x2adc784*/ string get_DataFilePath();
        /*0x2adc78c*/ void set_InfoFilePath(string value);
        /*0x2adc794*/ string get_InfoFilePath();
        /*0x2adbc24*/ void DeleteFiles();
    }

    class VerifyTempElement
    {
        /*0x10*/ string <TempDataFilePath>k__BackingField;
        /*0x18*/ string <FileCRC>k__BackingField;
        /*0x20*/ long <FileSize>k__BackingField;
        /*0x28*/ bool IsDone;
        /*0x2c*/ YooAsset.EVerifyResult Result;

        /*0x2adc7cc*/ VerifyTempElement(string tempDataFilePath, string fileCRC, long fileSize);
        /*0x2adc79c*/ void set_TempDataFilePath(string value);
        /*0x2adc7a4*/ string get_TempDataFilePath();
        /*0x2adc7ac*/ void set_FileCRC(string value);
        /*0x2adc7b4*/ string get_FileCRC();
        /*0x2adc7bc*/ void set_FileSize(long value);
        /*0x2adc7c4*/ long get_FileSize();
    }

    class DebugBundleInfo : System.Collections.Generic.IComparer<YooAsset.DebugBundleInfo>, System.IComparable<YooAsset.DebugBundleInfo>
    {
        /*0x10*/ string <PackageName>k__BackingField;
        /*0x18*/ string BundleName;
        /*0x20*/ int RefCount;
        /*0x28*/ string Status;

        /*0x2ad6f74*/ DebugBundleInfo();
        /*0x2adc808*/ void set_PackageName(string value);
        /*0x2adc810*/ string get_PackageName();
        /*0x2adc818*/ int CompareTo(YooAsset.DebugBundleInfo other);
        /*0x2adc824*/ int Compare(YooAsset.DebugBundleInfo a, YooAsset.DebugBundleInfo b);
    }

    class DebugPackageData
    {
        /*0x10*/ string PackageName;
        /*0x18*/ System.Collections.Generic.List<YooAsset.DebugProviderInfo> ProviderInfos;

        /*0x2adc848*/ DebugPackageData();
    }

    class DebugProviderInfo : System.Collections.Generic.IComparer<YooAsset.DebugProviderInfo>, System.IComparable<YooAsset.DebugProviderInfo>
    {
        /*0x10*/ string <PackageName>k__BackingField;
        /*0x18*/ string AssetPath;
        /*0x20*/ string SpawnScene;
        /*0x28*/ string SpawnTime;
        /*0x30*/ long LoadingTime;
        /*0x38*/ int RefCount;
        /*0x40*/ string Status;
        /*0x48*/ System.Collections.Generic.List<YooAsset.DebugBundleInfo> DependBundleInfos;

        /*0x2ad2378*/ DebugProviderInfo();
        /*0x2adc8c8*/ void set_PackageName(string value);
        /*0x2adc8d0*/ string get_PackageName();
        /*0x2adc8d8*/ int CompareTo(YooAsset.DebugProviderInfo other);
        /*0x2adc8e4*/ int Compare(YooAsset.DebugProviderInfo a, YooAsset.DebugProviderInfo b);
    }

    class DebugReport
    {
        /*0x10*/ int FrameCount;
        /*0x18*/ System.Collections.Generic.List<YooAsset.DebugPackageData> PackageDatas;

        static /*0x2adc908*/ byte[] Serialize(YooAsset.DebugReport debugReport);
        static /*0x2adc954*/ YooAsset.DebugReport Deserialize(byte[] data);
        /*0x2adc9bc*/ DebugReport();
    }

    enum ERemoteCommand
    {
        SampleOnce = 0,
    }

    class RemoteCommand
    {
        /*0x10*/ int CommandType;
        /*0x18*/ string CommandParam;

        static /*0x2adca3c*/ byte[] Serialize(YooAsset.RemoteCommand command);
        static /*0x2adca88*/ YooAsset.RemoteCommand Deserialize(byte[] data);
        /*0x2adcaf0*/ RemoteCommand();
    }

    class RemoteDebuggerDefine
    {
        static /*0x0*/ System.Guid kMsgSendPlayerToEditor;
        static /*0x10*/ System.Guid kMsgSendEditorToPlayer;

        static /*0x2adcb00*/ RemoteDebuggerDefine();
        /*0x2adcaf8*/ RemoteDebuggerDefine();
    }

    class RemoteDebuggerInRuntime : UnityEngine.MonoBehaviour
    {
        /*0x2adce90*/ RemoteDebuggerInRuntime();
        /*0x2adcbbc*/ void OnEnable();
        /*0x2adcc94*/ void OnDisable();
        /*0x2adcd6c*/ void OnHandleEditorMessage(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
    }

    class DownloaderBase
    {
        /*0x10*/ YooAsset.BundleInfo _bundleInfo;
        /*0x18*/ YooAsset.DownloaderBase.ESteps _steps;
        /*0x1c*/ int _timeout;
        /*0x20*/ int _failedTryAgain;
        /*0x24*/ int _requestCount;
        /*0x28*/ string _requestURL;
        /*0x30*/ string _lastError;
        /*0x38*/ long _lastCode;
        /*0x40*/ float _downloadProgress;
        /*0x48*/ ulong _downloadedBytes;
        /*0x50*/ bool WaitForAsyncComplete;

        /*0x2adcea8*/ DownloaderBase(YooAsset.BundleInfo bundleInfo);
        /*0x2adce98*/ float get_DownloadProgress();
        /*0x2adcea0*/ ulong get_DownloadedBytes();
        /*0x2adcf14*/ void SendRequest(int failedTryAgain, int timeout);
        void Update();
        void Abort();
        /*0x2adcf30*/ string GetRequestURL();
        /*0x2adcf68*/ YooAsset.BundleInfo GetBundleInfo();
        /*0x2ad55a8*/ bool IsDone();
        /*0x2ad55bc*/ bool HasError();
        /*0x2adcf70*/ void ReportError();
        /*0x2adcf84*/ void ReportWarning();
        /*0x2ad55cc*/ string GetLastError();

        enum ESteps
        {
            None = 0,
            CheckTempFile = 1,
            WaitingCheckTempFile = 2,
            PrepareDownload = 3,
            CreateResumeDownloader = 4,
            CreateGeneralDownloader = 5,
            CheckDownload = 6,
            VerifyTempFile = 7,
            WaitingVerifyTempFile = 8,
            CachingFile = 9,
            TryAgain = 10,
            Succeed = 11,
            Failed = 12,
        }
    }

    class DownloadHandlerFileRange : UnityEngine.Networking.DownloadHandlerScript
    {
        /*0x18*/ string _fileSavePath;
        /*0x20*/ long _fileTotalSize;
        /*0x28*/ UnityEngine.Networking.UnityWebRequest _webRequest;
        /*0x30*/ System.IO.FileStream _fileStream;
        /*0x38*/ long _localFileSize;
        /*0x40*/ long _curFileSize;

        /*0x2adcf98*/ DownloadHandlerFileRange(string fileSavePath, long fileTotalSize, UnityEngine.Networking.UnityWebRequest webRequest);
        /*0x2add0b4*/ bool ReceiveData(byte[] data, int dataLength);
        /*0x2add138*/ byte[] GetData();
        /*0x2add140*/ string GetText();
        /*0x2add148*/ float GetProgress();
        /*0x2add16c*/ void Cleanup();
    }

    class FileDownloader : YooAsset.DownloaderBase
    {
        /*0x51*/ bool _breakResume;
        /*0x58*/ string _tempFilePath;
        /*0x60*/ UnityEngine.Networking.UnityWebRequest _webRequest;
        /*0x68*/ YooAsset.DownloadHandlerFileRange _downloadHandle;
        /*0x70*/ YooAsset.VerifyTempFileOperation _checkFileOp;
        /*0x78*/ YooAsset.VerifyTempFileOperation _verifyFileOp;
        /*0x80*/ bool _isAbort;
        /*0x88*/ ulong _fileOriginLength;
        /*0x90*/ ulong _latestDownloadBytes;
        /*0x98*/ float _latestDownloadRealtime;
        /*0x9c*/ float _tryAgainTimer;

        /*0x2add1ac*/ FileDownloader(YooAsset.BundleInfo bundleInfo, bool breakResume);
        /*0x2add1f0*/ void Update();
        /*0x2adde68*/ void Abort();
        /*0x2addd78*/ void CheckTimeout();
        /*0x2adde34*/ void DisposeWebRequest();
    }

    class TempDownloader : YooAsset.DownloaderBase
    {
        /*0x2added8*/ TempDownloader(YooAsset.BundleInfo bundleInfo);
        /*0x2addf20*/ void Update();
        /*0x2addf24*/ void Abort();
    }

    struct DownloadReport
    {
        /*0x10*/ float Progress;
        /*0x18*/ ulong TotalSize;
        /*0x20*/ ulong DownloadedBytes;

        static /*0x2ad3968*/ YooAsset.DownloadReport CreateDefaultReport();
    }

    class DownloadRequestDelegate : System.MulticastDelegate
    {
        /*0x2addf28*/ DownloadRequestDelegate(object object, nint method);
        /*0x2addffc*/ UnityEngine.Networking.UnityWebRequest Invoke(string url);
        /*0x2ade010*/ System.IAsyncResult BeginInvoke(string url, System.AsyncCallback callback, object object);
        /*0x2ade030*/ UnityEngine.Networking.UnityWebRequest EndInvoke(System.IAsyncResult result);
    }

    class DownloadSystem
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, YooAsset.DownloaderBase> _downloaderDic;
        static /*0x8*/ System.Collections.Generic.List<string> _removeList;
        static /*0x10*/ YooAsset.DownloadRequestDelegate RequestDelegate;
        static /*0x18*/ UnityEngine.Networking.CertificateHandler CertificateHandlerInstance;
        static /*0x20*/ int <BreakpointResumeFileSize>k__BackingField;
        static /*0x28*/ System.Collections.Generic.List<long> <ClearFileResponseCodes>k__BackingField;

        static /*0x2ade8ac*/ DownloadSystem();
        static /*0x2ade03c*/ void set_BreakpointResumeFileSize(int value);
        static /*0x2ade098*/ int get_BreakpointResumeFileSize();
        static /*0x2ade0f0*/ void set_ClearFileResponseCodes(System.Collections.Generic.List<long> value);
        static /*0x2ade14c*/ System.Collections.Generic.List<long> get_ClearFileResponseCodes();
        static /*0x2ade1a4*/ void Initialize();
        static /*0x2ade1a8*/ void Update();
        static /*0x2ade594*/ void DestroyAll();
        static /*0x2ad535c*/ YooAsset.DownloaderBase BeginDownload(YooAsset.BundleInfo bundleInfo, int failedTryAgain, int timeout);
        static /*0x2addc90*/ UnityEngine.Networking.UnityWebRequest NewRequest(string requestURL);
        static /*0x2ade834*/ int GetDownloaderTotalCount();
    }

    class ThreadSyncContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Concurrent.ConcurrentQueue<System.Action> _safeQueue;

        /*0x2adb468*/ ThreadSyncContext();
        /*0x2adb7f4*/ void Update();
        /*0x2ade994*/ void Post(System.Threading.SendOrPostCallback callback, object state);

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Threading.SendOrPostCallback callback;
            /*0x18*/ object state;

            /*0x2adea70*/ <>c__DisplayClass2_0();
            /*0x2adea78*/ void <Post>b__0();
        }
    }

    class UnityWebDataRequester
    {
        /*0x10*/ UnityEngine.Networking.UnityWebRequest _webRequest;
        /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation _operationHandle;
        /*0x20*/ string <URL>k__BackingField;

        /*0x2aded68*/ UnityWebDataRequester();
        /*0x2adeaa0*/ void set_URL(string value);
        /*0x2adeaa8*/ string get_URL();
        /*0x2adeab0*/ void SendRequest(string url, int timeout);
        /*0x2adeb9c*/ byte[] GetData();
        /*0x2adec04*/ string GetText();
        /*0x2adec58*/ void Dispose();
        /*0x2adebf0*/ bool IsDone();
        /*0x2adec7c*/ float Progress();
        /*0x2adec94*/ bool HasError();
        /*0x2adecbc*/ string GetError();
    }

    class UnityWebFileRequester
    {
        /*0x10*/ UnityEngine.Networking.UnityWebRequest _webRequest;
        /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation _operationHandle;
        /*0x20*/ float _timeout;
        /*0x24*/ bool _isAbort;
        /*0x28*/ ulong _latestDownloadBytes;
        /*0x30*/ float _latestDownloadRealtime;
        /*0x38*/ string <URL>k__BackingField;

        /*0x2adf048*/ UnityWebFileRequester();
        /*0x2aded70*/ void set_URL(string value);
        /*0x2aded78*/ string get_URL();
        /*0x2aded80*/ void SendRequest(string url, string savePath, float timeout);
        /*0x2adee90*/ void Dispose();
        /*0x2adeeb4*/ bool IsDone();
        /*0x2adeec8*/ float Progress();
        /*0x2adeee0*/ bool HasError();
        /*0x2adef08*/ string GetError();
        /*0x2adefb4*/ void CheckTimeout();
    }

    enum EPlayMode
    {
        EditorSimulateMode = 0,
        OfflinePlayMode = 1,
        HostPlayMode = 2,
    }

    class InitializeParameters
    {
        /*0x10*/ bool LocationToLower;
        /*0x18*/ YooAsset.IDecryptionServices DecryptionServices;
        /*0x20*/ long LoadingMaxTimeSlice;
        /*0x28*/ int DownloadFailedTryAgain;

        /*0x2adf050*/ InitializeParameters();
    }

    class EditorSimulateModeParameters : YooAsset.InitializeParameters
    {
        /*0x30*/ string SimulateManifestFilePath;

        /*0x2adf068*/ EditorSimulateModeParameters();
    }

    class OfflinePlayModeParameters : YooAsset.InitializeParameters
    {
        /*0x2adf0d0*/ OfflinePlayModeParameters();
    }

    class HostPlayModeParameters : YooAsset.InitializeParameters
    {
        /*0x30*/ string DefaultHostServer;
        /*0x38*/ string FallbackHostServer;
        /*0x40*/ YooAsset.IQueryServices QueryServices;

        /*0x2adf0e8*/ HostPlayModeParameters();
    }

    class AsyncOperationBase : System.Collections.IEnumerator
    {
        /*0x10*/ System.Action<YooAsset.AsyncOperationBase> _callback;
        /*0x18*/ YooAsset.EOperationStatus <Status>k__BackingField;
        /*0x20*/ string <Error>k__BackingField;
        /*0x28*/ float <Progress>k__BackingField;
        /*0x30*/ System.Threading.Tasks.TaskCompletionSource<object> _taskCompletionSource;

        /*0x2ad78dc*/ AsyncOperationBase();
        /*0x2adf150*/ YooAsset.EOperationStatus get_Status();
        /*0x2adf158*/ void set_Status(YooAsset.EOperationStatus value);
        /*0x2adf160*/ string get_Error();
        /*0x2adf168*/ void set_Error(string value);
        /*0x2adf170*/ float get_Progress();
        /*0x2adf178*/ void set_Progress(float value);
        /*0x2ad7a80*/ bool get_IsDone();
        /*0x2adf180*/ void add_Completed(System.Action<YooAsset.AsyncOperationBase> value);
        /*0x2adf260*/ void remove_Completed(System.Action<YooAsset.AsyncOperationBase> value);
        /*0x2adf308*/ System.Threading.Tasks.Task get_Task();
        void Start();
        void Update();
        /*0x2adf3d0*/ void Finish();
        /*0x2adf450*/ void ClearCompletedCallback();
        /*0x2adf458*/ bool System.Collections.IEnumerator.MoveNext();
        /*0x2adf46c*/ void System.Collections.IEnumerator.Reset();
        /*0x2adf470*/ object System.Collections.IEnumerator.get_Current();
    }

    enum EOperationStatus
    {
        None = 0,
        Succeed = 1,
        Failed = 2,
    }

    class GameAsyncOperation : YooAsset.AsyncOperationBase
    {
        /*0x2adf4dc*/ GameAsyncOperation();
        /*0x2adf478*/ void Start();
        /*0x2adf484*/ void Update();
        void OnStart();
        void OnUpdate();
        /*0x2adf490*/ bool IsBusy();
    }

    class OperationSystem
    {
        static /*0x0*/ System.Collections.Generic.List<YooAsset.AsyncOperationBase> _operations;
        static /*0x8*/ System.Collections.Generic.List<YooAsset.AsyncOperationBase> _addList;
        static /*0x10*/ System.Collections.Generic.List<YooAsset.AsyncOperationBase> _removeList;
        static /*0x18*/ System.Diagnostics.Stopwatch _watch;
        static /*0x20*/ long _frameTime;
        static /*0x28*/ long <MaxTimeSlice>k__BackingField;

        static /*0x2adfcb8*/ OperationSystem();
        static /*0x2adf4e4*/ void set_MaxTimeSlice(long value);
        static /*0x2adf540*/ long get_MaxTimeSlice();
        static /*0x2ada808*/ bool get_IsBusy();
        static /*0x2adf598*/ void Initialize();
        static /*0x2adf624*/ void Update();
        static /*0x2adfb70*/ void DestroyAll();
        static /*0x2ad3814*/ void StartOperation(YooAsset.AsyncOperationBase operation);
        /*0x2adfcb0*/ OperationSystem();
    }

    class AssetInfo
    {
        /*0x10*/ YooAsset.PackageAsset _packageAsset;
        /*0x18*/ string _providerGUID;
        /*0x20*/ System.Type <AssetType>k__BackingField;
        /*0x28*/ string <Error>k__BackingField;

        /*0x2adfe24*/ AssetInfo();
        /*0x2adfe2c*/ AssetInfo(YooAsset.PackageAsset packageAsset, System.Type assetType);
        /*0x2adfeec*/ AssetInfo(YooAsset.PackageAsset packageAsset);
        /*0x2adffa0*/ AssetInfo(string error);
        /*0x2adfda8*/ void set_AssetType(System.Type value);
        /*0x2adfdb0*/ System.Type get_AssetType();
        /*0x2adfdb8*/ void set_Error(string value);
        /*0x2adfdc0*/ string get_Error();
        /*0x2ad0e44*/ string get_GUID();
        /*0x2ad0be4*/ bool get_IsInvalid();
        /*0x2adfdc8*/ string get_Address();
        /*0x2ad2380*/ string get_AssetPath();
    }

    class BundleInfo
    {
        /*0x10*/ YooAsset.PackageBundle Bundle;
        /*0x18*/ YooAsset.BundleInfo.ELoadMode LoadMode;
        /*0x20*/ string <RemoteMainURL>k__BackingField;
        /*0x28*/ string <RemoteFallbackURL>k__BackingField;
        /*0x30*/ string <EditorAssetPath>k__BackingField;

        static /*0x2ae01c8*/ bool IsBuildinJarFile(string streamingPath);
        /*0x2ae003c*/ BundleInfo();
        /*0x2ae0044*/ BundleInfo(YooAsset.PackageBundle bundle, YooAsset.BundleInfo.ELoadMode loadMode, string mainURL, string fallbackURL);
        /*0x2ae00cc*/ BundleInfo(YooAsset.PackageBundle bundle, YooAsset.BundleInfo.ELoadMode loadMode, string editorAssetPath);
        /*0x2ae0150*/ BundleInfo(YooAsset.PackageBundle bundle, YooAsset.BundleInfo.ELoadMode loadMode);
        /*0x2ae000c*/ void set_RemoteMainURL(string value);
        /*0x2ae0014*/ string get_RemoteMainURL();
        /*0x2ae001c*/ void set_RemoteFallbackURL(string value);
        /*0x2ae0024*/ string get_RemoteFallbackURL();
        /*0x2ae002c*/ void set_EditorAssetPath(string value);
        /*0x2ae0034*/ string get_EditorAssetPath();

        enum ELoadMode
        {
            None = 0,
            LoadFromStreaming = 1,
            LoadFromCache = 2,
            LoadFromRemote = 3,
            LoadFromEditor = 4,
        }
    }

    class ManifestTools
    {
        static /*0x2ae021c*/ string GetRemoteBundleFileExtension(string bundleName);
        static /*0x2ae0274*/ string GetRemoteBundleFileName(int nameStyle, string bundleName, string fileExtension, string fileHash);
        static /*0x2ad5664*/ YooAsset.BundleInfo GetUnpackInfo(YooAsset.PackageBundle packageBundle);
    }

    class DownloaderOperation : YooAsset.AsyncOperationBase
    {
        static int MAX_LOADER_COUNT = 64;
        /*0x38*/ int _downloadingMaxNumber;
        /*0x3c*/ int _failedTryAgain;
        /*0x40*/ int _timeout;
        /*0x48*/ System.Collections.Generic.List<YooAsset.BundleInfo> _downloadList;
        /*0x50*/ System.Collections.Generic.List<YooAsset.DownloaderBase> _downloaders;
        /*0x58*/ System.Collections.Generic.List<YooAsset.DownloaderBase> _removeList;
        /*0x60*/ System.Collections.Generic.List<YooAsset.DownloaderBase> _failedList;
        /*0x68*/ bool _isPause;
        /*0x70*/ long _lastDownloadBytes;
        /*0x78*/ int _lastDownloadCount;
        /*0x80*/ long _cachedDownloadBytes;
        /*0x88*/ int _cachedDownloadCount;
        /*0x8c*/ YooAsset.DownloaderOperation.ESteps _steps;
        /*0x90*/ int <TotalDownloadCount>k__BackingField;
        /*0x98*/ long <TotalDownloadBytes>k__BackingField;
        /*0xa0*/ YooAsset.DownloaderOperation.OnDownloadOver <OnDownloadOverCallback>k__BackingField;
        /*0xa8*/ YooAsset.DownloaderOperation.OnDownloadProgress <OnDownloadProgressCallback>k__BackingField;
        /*0xb0*/ YooAsset.DownloaderOperation.OnDownloadError <OnDownloadErrorCallback>k__BackingField;
        /*0xb8*/ YooAsset.DownloaderOperation.OnStartDownloadFile <OnStartDownloadFileCallback>k__BackingField;

        /*0x2ae0478*/ DownloaderOperation(System.Collections.Generic.List<YooAsset.BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae0408*/ void set_TotalDownloadCount(int value);
        /*0x2ae0410*/ int get_TotalDownloadCount();
        /*0x2ae0418*/ void set_TotalDownloadBytes(long value);
        /*0x2ae0420*/ long get_TotalDownloadBytes();
        /*0x2ae0428*/ int get_CurrentDownloadCount();
        /*0x2ae0430*/ long get_CurrentDownloadBytes();
        /*0x2ae0438*/ void set_OnDownloadOverCallback(YooAsset.DownloaderOperation.OnDownloadOver value);
        /*0x2ae0440*/ YooAsset.DownloaderOperation.OnDownloadOver get_OnDownloadOverCallback();
        /*0x2ae0448*/ void set_OnDownloadProgressCallback(YooAsset.DownloaderOperation.OnDownloadProgress value);
        /*0x2ae0450*/ YooAsset.DownloaderOperation.OnDownloadProgress get_OnDownloadProgressCallback();
        /*0x2ae0458*/ void set_OnDownloadErrorCallback(YooAsset.DownloaderOperation.OnDownloadError value);
        /*0x2ae0460*/ YooAsset.DownloaderOperation.OnDownloadError get_OnDownloadErrorCallback();
        /*0x2ae0468*/ void set_OnStartDownloadFileCallback(YooAsset.DownloaderOperation.OnStartDownloadFile value);
        /*0x2ae0470*/ YooAsset.DownloaderOperation.OnStartDownloadFile get_OnStartDownloadFileCallback();
        /*0x2ae06b8*/ void Start();
        /*0x2ae06c4*/ void Update();
        /*0x2ae0e18*/ void BeginDownload();
        /*0x2ae0e80*/ void PauseDownload();
        /*0x2ae0e8c*/ void ResumeDownload();
        /*0x2ae0e94*/ void CancelDownload();

        enum ESteps
        {
            None = 0,
            Check = 1,
            Loading = 2,
            Done = 3,
        }

        class OnDownloadOver : System.MulticastDelegate
        {
            /*0x2ae0ef8*/ OnDownloadOver(object object, nint method);
            /*0x2ae0fbc*/ void Invoke(bool isSucceed);
            /*0x2ae0fd4*/ System.IAsyncResult BeginInvoke(bool isSucceed, System.AsyncCallback callback, object object);
            /*0x2ae105c*/ void EndInvoke(System.IAsyncResult result);
        }

        class OnDownloadProgress : System.MulticastDelegate
        {
            /*0x2ae1068*/ OnDownloadProgress(object object, nint method);
            /*0x2ae112c*/ void Invoke(int totalDownloadCount, int currentDownloadCount, long totalDownloadBytes, long currentDownloadBytes);
            /*0x2ae1140*/ System.IAsyncResult BeginInvoke(int totalDownloadCount, int currentDownloadCount, long totalDownloadBytes, long currentDownloadBytes, System.AsyncCallback callback, object object);
            /*0x2ae1220*/ void EndInvoke(System.IAsyncResult result);
        }

        class OnDownloadError : System.MulticastDelegate
        {
            /*0x2ae122c*/ OnDownloadError(object object, nint method);
            /*0x2ae1304*/ void Invoke(string fileName, string error);
            /*0x2ae1318*/ System.IAsyncResult BeginInvoke(string fileName, string error, System.AsyncCallback callback, object object);
            /*0x2ae1340*/ void EndInvoke(System.IAsyncResult result);
        }

        class OnStartDownloadFile : System.MulticastDelegate
        {
            /*0x2ae134c*/ OnStartDownloadFile(object object, nint method);
            /*0x2ae1424*/ void Invoke(string fileName, long sizeBytes);
            /*0x2ae1438*/ System.IAsyncResult BeginInvoke(string fileName, long sizeBytes, System.AsyncCallback callback, object object);
            /*0x2ae14c8*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class ResourceDownloaderOperation : YooAsset.DownloaderOperation
    {
        static /*0x2ae14d8*/ YooAsset.ResourceDownloaderOperation CreateEmptyDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae14d4*/ ResourceDownloaderOperation(System.Collections.Generic.List<YooAsset.BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout);
    }

    class ResourceUnpackerOperation : YooAsset.DownloaderOperation
    {
        static /*0x2ae1598*/ YooAsset.ResourceUnpackerOperation CreateEmptyUnpacker(int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae1594*/ ResourceUnpackerOperation(System.Collections.Generic.List<YooAsset.BundleInfo> downloadList, int downloadingMaxNumber, int failedTryAgain, int timeout);
    }

    class InitializationOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string <PackageVersion>k__BackingField;

        /*0x2ae1660*/ InitializationOperation();
        /*0x2ae1650*/ void set_PackageVersion(string value);
        /*0x2ae1658*/ string get_PackageVersion();
    }

    class EditorSimulateModeInitializationOperation : YooAsset.InitializationOperation
    {
        /*0x40*/ YooAsset.EditorSimulateModeImpl _impl;
        /*0x48*/ string _simulateManifestFilePath;
        /*0x50*/ YooAsset.LoadEditorManifestOperation _loadEditorManifestOp;
        /*0x58*/ YooAsset.EditorSimulateModeInitializationOperation.ESteps _steps;

        /*0x2ae1668*/ EditorSimulateModeInitializationOperation(YooAsset.EditorSimulateModeImpl impl, string simulateManifestFilePath);
        /*0x2ae1694*/ void Start();
        /*0x2ae16a0*/ void Update();

        enum ESteps
        {
            None = 0,
            LoadEditorManifest = 1,
            Done = 2,
        }
    }

    class OfflinePlayModeInitializationOperation : YooAsset.InitializationOperation
    {
        /*0x40*/ YooAsset.OfflinePlayModeImpl _impl;
        /*0x48*/ string _packageName;
        /*0x50*/ YooAsset.QueryBuildinPackageVersionOperation _queryBuildinPackageVersionOp;
        /*0x58*/ YooAsset.LoadBuildinManifestOperation _loadBuildinManifestOp;
        /*0x60*/ YooAsset.PackageCachingOperation _cachingOperation;
        /*0x68*/ YooAsset.OfflinePlayModeInitializationOperation.ESteps _steps;

        /*0x2ae17b8*/ OfflinePlayModeInitializationOperation(YooAsset.OfflinePlayModeImpl impl, string packageName);
        /*0x2ae17e4*/ void Start();
        /*0x2ae17f0*/ void Update();

        enum ESteps
        {
            None = 0,
            QueryBuildinPackageVersion = 1,
            LoadBuildinManifest = 2,
            PackageCaching = 3,
            Done = 4,
        }
    }

    class HostPlayModeInitializationOperation : YooAsset.InitializationOperation
    {
        /*0x40*/ YooAsset.HostPlayModeImpl _impl;
        /*0x48*/ string _packageName;
        /*0x50*/ YooAsset.QueryBuildinPackageVersionOperation _queryBuildinPackageVersionOp;
        /*0x58*/ YooAsset.QueryCachePackageVersionOperation _queryCachePackageVersionOp;
        /*0x60*/ YooAsset.UnpackBuildinManifestOperation _unpackBuildinManifestOp;
        /*0x68*/ YooAsset.LoadBuildinManifestOperation _loadBuildinManifestOp;
        /*0x70*/ YooAsset.LoadCacheManifestOperation _loadCacheManifestOp;
        /*0x78*/ YooAsset.PackageCachingOperation _cachingOperation;
        /*0x80*/ YooAsset.HostPlayModeInitializationOperation.ESteps _steps;

        /*0x2ae1a34*/ HostPlayModeInitializationOperation(YooAsset.HostPlayModeImpl impl, string packageName);
        /*0x2ae1a60*/ void Start();
        /*0x2ae1a6c*/ void Update();

        enum ESteps
        {
            None = 0,
            CheckAppFootPrint = 1,
            QueryCachePackageVersion = 2,
            TryLoadCacheManifest = 3,
            QueryBuildinPackageVersion = 4,
            UnpackBuildinManifest = 5,
            LoadBuildinManifest = 6,
            PackageCaching = 7,
            Done = 8,
        }
    }

    class AppFootPrint
    {
        /*0x10*/ string _footPrint;

        /*0x2ae32cc*/ AppFootPrint();
        /*0x2ae2ef0*/ void Load();
        /*0x2ae3090*/ bool IsDirty();
        /*0x2ae302c*/ void Coverage();
    }

    class DeserializeManifestOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ YooAsset.BufferReader _buffer;
        /*0x40*/ int _packageAssetCount;
        /*0x44*/ int _packageBundleCount;
        /*0x48*/ int _progressTotalValue;
        /*0x4c*/ YooAsset.DeserializeManifestOperation.ESteps _steps;
        /*0x50*/ YooAsset.PackageManifest <Manifest>k__BackingField;

        /*0x2ae32e4*/ DeserializeManifestOperation(byte[] binaryData);
        /*0x2ae32d4*/ void set_Manifest(YooAsset.PackageManifest value);
        /*0x2ae32dc*/ YooAsset.PackageManifest get_Manifest();
        /*0x2ae3388*/ void Start();
        /*0x2ae3394*/ void Update();

        enum ESteps
        {
            None = 0,
            DeserializeFileHeader = 1,
            PrepareAssetList = 2,
            DeserializeAssetList = 3,
            PrepareBundleList = 4,
            DeserializeBundleList = 5,
            Done = 6,
        }
    }

    class DownloadManifestOperation : YooAsset.AsyncOperationBase
    {
        static /*0x0*/ int RequestCount;
        /*0x38*/ YooAsset.IRemoteServices _remoteServices;
        /*0x40*/ string _packageName;
        /*0x48*/ string _packageVersion;
        /*0x50*/ int _timeout;
        /*0x58*/ YooAsset.UnityWebFileRequester _downloader1;
        /*0x60*/ YooAsset.UnityWebFileRequester _downloader2;
        /*0x68*/ YooAsset.DownloadManifestOperation.ESteps _steps;

        /*0x2ae4488*/ DownloadManifestOperation(YooAsset.IRemoteServices remoteServices, string packageName, string packageVersion, int timeout);
        /*0x2ae44cc*/ void Start();
        /*0x2ae4528*/ void Update();
        /*0x2ae49d0*/ string GetDownloadRequestURL(string fileName);

        enum ESteps
        {
            None = 0,
            DownloadPackageHashFile = 1,
            DownloadManifestFile = 2,
            Done = 3,
        }
    }

    class LoadBuildinManifestOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _buildinPackageName;
        /*0x40*/ string _buildinPackageVersion;
        /*0x48*/ YooAsset.UnityWebDataRequester _downloader;
        /*0x50*/ YooAsset.DeserializeManifestOperation _deserializer;
        /*0x58*/ YooAsset.LoadBuildinManifestOperation.ESteps _steps;
        /*0x60*/ YooAsset.PackageManifest <Manifest>k__BackingField;

        /*0x2ae4d00*/ LoadBuildinManifestOperation(string buildinPackageName, string buildinPackageVersion);
        /*0x2ae4cf0*/ void set_Manifest(YooAsset.PackageManifest value);
        /*0x2ae4cf8*/ YooAsset.PackageManifest get_Manifest();
        /*0x2ae4d2c*/ void Start();
        /*0x2ae4d38*/ void Update();

        enum ESteps
        {
            None = 0,
            LoadBuildinManifest = 1,
            CheckDeserializeManifest = 2,
            Done = 3,
        }
    }

    class LoadCacheManifestOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _packageName;
        /*0x40*/ string _packageVersion;
        /*0x48*/ YooAsset.QueryCachePackageHashOperation _queryCachePackageHashOp;
        /*0x50*/ YooAsset.DeserializeManifestOperation _deserializer;
        /*0x58*/ string _manifestFilePath;
        /*0x60*/ YooAsset.LoadCacheManifestOperation.ESteps _steps;
        /*0x68*/ YooAsset.PackageManifest <Manifest>k__BackingField;

        /*0x2ae5054*/ LoadCacheManifestOperation(string packageName, string packageVersion);
        /*0x2ae5044*/ void set_Manifest(YooAsset.PackageManifest value);
        /*0x2ae504c*/ YooAsset.PackageManifest get_Manifest();
        /*0x2ae5080*/ void Start();
        /*0x2ae508c*/ void Update();
        /*0x2ae53a8*/ void ClearCacheFile();

        enum ESteps
        {
            None = 0,
            QueryCachePackageHash = 1,
            VerifyFileHash = 2,
            LoadCacheManifest = 3,
            CheckDeserializeManifest = 4,
            Done = 5,
        }
    }

    class LoadEditorManifestOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _manifestFilePath;
        /*0x40*/ YooAsset.DeserializeManifestOperation _deserializer;
        /*0x48*/ YooAsset.LoadEditorManifestOperation.ESteps _steps;
        /*0x50*/ YooAsset.PackageManifest <Manifest>k__BackingField;

        /*0x2ae580c*/ LoadEditorManifestOperation(string manifestFilePath);
        /*0x2ae57fc*/ void set_Manifest(YooAsset.PackageManifest value);
        /*0x2ae5804*/ YooAsset.PackageManifest get_Manifest();
        /*0x2ae5834*/ void Start();
        /*0x2ae5840*/ void Update();

        enum ESteps
        {
            None = 0,
            LoadEditorManifest = 1,
            CheckDeserializeManifest = 2,
            Done = 3,
        }
    }

    class QueryBuildinPackageVersionOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _packageName;
        /*0x40*/ YooAsset.UnityWebDataRequester _downloader;
        /*0x48*/ YooAsset.QueryBuildinPackageVersionOperation.ESteps _steps;
        /*0x50*/ string <PackageVersion>k__BackingField;

        /*0x2ae5a0c*/ QueryBuildinPackageVersionOperation(string packageName);
        /*0x2ae59fc*/ void set_PackageVersion(string value);
        /*0x2ae5a04*/ string get_PackageVersion();
        /*0x2ae5a34*/ void Start();
        /*0x2ae5a40*/ void Update();

        enum ESteps
        {
            None = 0,
            LoadBuildinPackageVersionFile = 1,
            Done = 2,
        }
    }

    class QueryCachePackageHashOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _packageName;
        /*0x40*/ string _packageVersion;
        /*0x48*/ YooAsset.QueryCachePackageHashOperation.ESteps _steps;
        /*0x50*/ string <PackageHash>k__BackingField;

        /*0x2ae537c*/ QueryCachePackageHashOperation(string packageName, string packageVersion);
        /*0x2ae5c08*/ void set_PackageHash(string value);
        /*0x2ae5c10*/ string get_PackageHash();
        /*0x2ae5c18*/ void Start();
        /*0x2ae5c24*/ void Update();

        enum ESteps
        {
            None = 0,
            LoadCachePackageHashFile = 1,
            Done = 2,
        }
    }

    class QueryCachePackageVersionOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _packageName;
        /*0x40*/ YooAsset.QueryCachePackageVersionOperation.ESteps _steps;
        /*0x48*/ string <PackageVersion>k__BackingField;

        /*0x2ae5d34*/ QueryCachePackageVersionOperation(string packageName);
        /*0x2ae5d24*/ void set_PackageVersion(string value);
        /*0x2ae5d2c*/ string get_PackageVersion();
        /*0x2ae5d5c*/ void Start();
        /*0x2ae5d68*/ void Update();

        enum ESteps
        {
            None = 0,
            LoadCachePackageVersionFile = 1,
            Done = 2,
        }
    }

    class QueryRemotePackageVersionOperation : YooAsset.AsyncOperationBase
    {
        static /*0x0*/ int RequestCount;
        /*0x38*/ YooAsset.IRemoteServices _remoteServices;
        /*0x40*/ string _packageName;
        /*0x48*/ bool _appendTimeTicks;
        /*0x4c*/ int _timeout;
        /*0x50*/ YooAsset.UnityWebDataRequester _downloader;
        /*0x58*/ YooAsset.QueryRemotePackageVersionOperation.ESteps _steps;
        /*0x60*/ string <PackageVersion>k__BackingField;

        /*0x2ae5ed0*/ QueryRemotePackageVersionOperation(YooAsset.IRemoteServices remoteServices, string packageName, bool appendTimeTicks, int timeout);
        /*0x2ae5ec0*/ void set_PackageVersion(string value);
        /*0x2ae5ec8*/ string get_PackageVersion();
        /*0x2ae5f14*/ void Start();
        /*0x2ae5f70*/ void Update();
        /*0x2ae60f0*/ string GetPackageVersionRequestURL(string fileName);

        enum ESteps
        {
            None = 0,
            DownloadPackageVersion = 1,
            Done = 2,
        }
    }

    class UnpackBuildinManifestOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string _buildinPackageName;
        /*0x40*/ string _buildinPackageVersion;
        /*0x48*/ YooAsset.UnityWebFileRequester _downloader1;
        /*0x50*/ YooAsset.UnityWebFileRequester _downloader2;
        /*0x58*/ YooAsset.UnpackBuildinManifestOperation.ESteps _steps;

        /*0x2ae62b0*/ UnpackBuildinManifestOperation(string buildinPackageName, string buildinPackageVersion);
        /*0x2ae62dc*/ void Start();
        /*0x2ae62e8*/ void Update();

        enum ESteps
        {
            None = 0,
            UnpackManifestHashFile = 1,
            UnpackManifestFile = 2,
            Done = 3,
        }
    }

    class PreDownloadContentOperation : YooAsset.AsyncOperationBase
    {
        /*0x2ae65b0*/ PreDownloadContentOperation();
        /*0x2ae654c*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae6560*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae6574*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae6588*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae659c*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout);
    }

    class EditorPlayModePreDownloadContentOperation : YooAsset.PreDownloadContentOperation
    {
        /*0x2ae65c8*/ EditorPlayModePreDownloadContentOperation();
        /*0x2ae65b8*/ void Start();
        /*0x2ae65c4*/ void Update();
    }

    class OfflinePlayModePreDownloadContentOperation : YooAsset.PreDownloadContentOperation
    {
        /*0x2ae65e0*/ OfflinePlayModePreDownloadContentOperation();
        /*0x2ae65d0*/ void Start();
        /*0x2ae65dc*/ void Update();
    }

    class HostPlayModePreDownloadContentOperation : YooAsset.PreDownloadContentOperation
    {
        /*0x38*/ YooAsset.HostPlayModeImpl _impl;
        /*0x40*/ string _packageName;
        /*0x48*/ string _packageVersion;
        /*0x50*/ int _timeout;
        /*0x58*/ YooAsset.LoadCacheManifestOperation _tryLoadCacheManifestOp;
        /*0x60*/ YooAsset.LoadCacheManifestOperation _loadCacheManifestOp;
        /*0x68*/ YooAsset.DownloadManifestOperation _downloadManifestOp;
        /*0x70*/ YooAsset.PackageManifest _manifest;
        /*0x78*/ YooAsset.HostPlayModePreDownloadContentOperation.ESteps _steps;

        /*0x2ae65e8*/ HostPlayModePreDownloadContentOperation(YooAsset.HostPlayModeImpl impl, string packageName, string packageVersion, int timeout);
        /*0x2ae662c*/ void Start();
        /*0x2ae6638*/ void Update();
        /*0x2ae68c4*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae6be8*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae7004*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae70fc*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae7820*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout);

        enum ESteps
        {
            None = 0,
            CheckActiveManifest = 1,
            TryLoadCacheManifest = 2,
            DownloadManifest = 3,
            LoadCacheManifest = 4,
            CheckDeserializeManifest = 5,
            Done = 6,
        }
    }

    class UpdatePackageManifestOperation : YooAsset.AsyncOperationBase
    {
        /*0x2ae7a4c*/ UpdatePackageManifestOperation();
        /*0x2ae7a48*/ void SavePackageVersion();
    }

    class EditorPlayModeUpdatePackageManifestOperation : YooAsset.UpdatePackageManifestOperation
    {
        /*0x2ae7a54*/ EditorPlayModeUpdatePackageManifestOperation();
        /*0x2ae7a5c*/ void Start();
        /*0x2ae7a68*/ void Update();
    }

    class OfflinePlayModeUpdatePackageManifestOperation : YooAsset.UpdatePackageManifestOperation
    {
        /*0x2ae7a6c*/ OfflinePlayModeUpdatePackageManifestOperation();
        /*0x2ae7a74*/ void Start();
        /*0x2ae7a80*/ void Update();
    }

    class HostPlayModeUpdatePackageManifestOperation : YooAsset.UpdatePackageManifestOperation
    {
        /*0x38*/ YooAsset.HostPlayModeImpl _impl;
        /*0x40*/ string _packageName;
        /*0x48*/ string _packageVersion;
        /*0x50*/ int _timeout;
        /*0x58*/ YooAsset.LoadCacheManifestOperation _tryLoadCacheManifestOp;
        /*0x60*/ YooAsset.LoadCacheManifestOperation _loadCacheManifestOp;
        /*0x68*/ YooAsset.DownloadManifestOperation _downloadManifestOp;
        /*0x70*/ YooAsset.HostPlayModeUpdatePackageManifestOperation.ESteps _steps;

        /*0x2ae7a84*/ HostPlayModeUpdatePackageManifestOperation(YooAsset.HostPlayModeImpl impl, string packageName, string packageVersion, int timeout);
        /*0x2ae7ac8*/ void Start();
        /*0x2ae7ad4*/ void Update();
        /*0x2ae7d7c*/ void SavePackageVersion();

        enum ESteps
        {
            None = 0,
            CheckActiveManifest = 1,
            TryLoadCacheManifest = 2,
            DownloadManifest = 3,
            LoadCacheManifest = 4,
            CheckDeserializeManifest = 5,
            Done = 6,
        }
    }

    class UpdatePackageVersionOperation : YooAsset.AsyncOperationBase
    {
        /*0x38*/ string <PackageVersion>k__BackingField;

        /*0x2ae7e18*/ UpdatePackageVersionOperation();
        /*0x2ae7e08*/ void set_PackageVersion(string value);
        /*0x2ae7e10*/ string get_PackageVersion();
    }

    class EditorPlayModeUpdatePackageVersionOperation : YooAsset.UpdatePackageVersionOperation
    {
        /*0x2ae7e30*/ EditorPlayModeUpdatePackageVersionOperation();
        /*0x2ae7e20*/ void Start();
        /*0x2ae7e2c*/ void Update();
    }

    class OfflinePlayModeUpdatePackageVersionOperation : YooAsset.UpdatePackageVersionOperation
    {
        /*0x2ae7e48*/ OfflinePlayModeUpdatePackageVersionOperation();
        /*0x2ae7e38*/ void Start();
        /*0x2ae7e44*/ void Update();
    }

    class HostPlayModeUpdatePackageVersionOperation : YooAsset.UpdatePackageVersionOperation
    {
        /*0x40*/ YooAsset.HostPlayModeImpl _impl;
        /*0x48*/ string _packageName;
        /*0x50*/ bool _appendTimeTicks;
        /*0x54*/ int _timeout;
        /*0x58*/ YooAsset.QueryRemotePackageVersionOperation _queryRemotePackageVersionOp;
        /*0x60*/ YooAsset.HostPlayModeUpdatePackageVersionOperation.ESteps _steps;

        /*0x2ae7e50*/ HostPlayModeUpdatePackageVersionOperation(YooAsset.HostPlayModeImpl impl, string packageName, bool appendTimeTicks, int timeout);
        /*0x2ae7e94*/ void Start();
        /*0x2ae7ea0*/ void Update();

        enum ESteps
        {
            None = 0,
            QueryRemotePackageVersion = 1,
            Done = 2,
        }
    }

    class PackageAsset
    {
        /*0x10*/ string Address;
        /*0x18*/ string AssetPath;
        /*0x20*/ string[] AssetTags;
        /*0x28*/ int BundleID;
        /*0x30*/ int[] DependIDs;

        /*0x2ae40b4*/ PackageAsset();
        /*0x2ae7fc4*/ bool HasTag(string[] tags);
    }

    class PackageBundle
    {
        /*0x10*/ string BundleName;
        /*0x18*/ string FileHash;
        /*0x20*/ string FileCRC;
        /*0x28*/ long FileSize;
        /*0x30*/ bool IsRawFile;
        /*0x31*/ byte LoadMethod;
        /*0x38*/ string[] Tags;
        /*0x40*/ int[] ReferenceIDs;
        /*0x48*/ string <PackageName>k__BackingField;
        /*0x50*/ string _cachedDataFilePath;
        /*0x58*/ string _cachedInfoFilePath;
        /*0x60*/ string _tempDataFilePath;
        /*0x68*/ string _streamingFilePath;
        /*0x70*/ string _fileName;
        /*0x78*/ string _fileExtension;

        /*0x2ae424c*/ PackageBundle();
        /*0x2ae807c*/ void set_PackageName(string value);
        /*0x2ae8084*/ string get_PackageName();
        /*0x2ae808c*/ string get_CacheGUID();
        /*0x2ae8094*/ string get_CachedDataFilePath();
        /*0x2ae8684*/ string get_CachedInfoFilePath();
        /*0x2ae88b0*/ string get_TempDataFilePath();
        /*0x2ae8920*/ string get_StreamingFilePath();
        /*0x2ae8958*/ string get_FileName();
        /*0x2ae89c8*/ string get_FileExtension();
        /*0x2ae4440*/ void ParseBundle(string packageName, int nameStype);
        /*0x2ae8a38*/ bool HasTag(string[] tags);
        /*0x2ae8af0*/ bool HasAnyTags();
        /*0x2ae8b10*/ bool Equals(YooAsset.PackageBundle otherBundle);
    }

    class PackageManifest
    {
        /*0x10*/ string FileVersion;
        /*0x18*/ bool EnableAddressable;
        /*0x1c*/ int OutputNameStyle;
        /*0x20*/ string PackageName;
        /*0x28*/ string PackageVersion;
        /*0x30*/ System.Collections.Generic.List<YooAsset.PackageAsset> AssetList;
        /*0x38*/ System.Collections.Generic.List<YooAsset.PackageBundle> BundleList;
        /*0x40*/ System.Collections.Generic.Dictionary<string, YooAsset.PackageBundle> BundleDic;
        /*0x48*/ System.Collections.Generic.Dictionary<string, YooAsset.PackageAsset> AssetDic;
        /*0x50*/ System.Collections.Generic.Dictionary<string, string> AssetPathMapping;
        /*0x58*/ bool _isInitAssetPathMapping;
        /*0x59*/ bool _locationToLower;

        /*0x2ae3ec4*/ PackageManifest();
        /*0x2ae8b30*/ void InitAssetPathMapping(bool locationToLower);
        /*0x2ae9224*/ string MappingToAssetPath(string location);
        /*0x2ae932c*/ string TryMappingToAssetPath(string location);
        /*0x2ae93ec*/ YooAsset.PackageBundle GetMainPackageBundle(string assetPath);
        /*0x2ae9570*/ YooAsset.PackageBundle[] GetAllDependencies(string assetPath);
        /*0x2ae981c*/ string GetBundleName(int bundleID);
        /*0x2ae991c*/ bool TryGetPackageAsset(string assetPath, ref YooAsset.PackageAsset result);
        /*0x2ae9984*/ bool TryGetPackageBundle(string bundleName, ref YooAsset.PackageBundle result);
        /*0x2ae99ec*/ bool IsIncludeBundleFile(string cacheGUID);
        /*0x2ae9b70*/ YooAsset.AssetInfo[] GetAssetsInfoByTags(string[] tags);
        /*0x2ae72dc*/ YooAsset.AssetInfo ConvertLocationToAssetInfo(string location, System.Type assetType);
        /*0x2ae9dfc*/ void DebugCheckLocation(string location);
    }

    class EditorSimulateModeHelper
    {
        static /*0x2ae9f30*/ string SimulateBuild(string packageName);
    }

    class EditorSimulateModeImpl : YooAsset.IPlayModeServices, YooAsset.IBundleServices
    {
        /*0x10*/ YooAsset.PackageManifest _activeManifest;
        /*0x18*/ bool _locationToLower;

        /*0x2aea5e4*/ EditorSimulateModeImpl();
        /*0x2ae9f80*/ YooAsset.InitializationOperation InitializeAsync(bool locationToLower, string simulateManifestFilePath);
        /*0x2aea02c*/ void set_ActiveManifest(YooAsset.PackageManifest value);
        /*0x2aea050*/ YooAsset.PackageManifest get_ActiveManifest();
        /*0x2aea058*/ void FlushManifestVersionFile();
        /*0x2aea05c*/ YooAsset.UpdatePackageVersionOperation YooAsset.IPlayModeServices.UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);
        /*0x2aea0e8*/ YooAsset.UpdatePackageManifestOperation YooAsset.IPlayModeServices.UpdatePackageManifestAsync(string packageVersion, int timeout);
        /*0x2aea174*/ YooAsset.PreDownloadContentOperation YooAsset.IPlayModeServices.PreDownloadContentAsync(string packageVersion, int timeout);
        /*0x2aea200*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aea214*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aea228*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByPaths(YooAsset.AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aea23c*/ YooAsset.ResourceUnpackerOperation YooAsset.IPlayModeServices.CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aea250*/ YooAsset.ResourceUnpackerOperation YooAsset.IPlayModeServices.CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aea264*/ YooAsset.BundleInfo CreateBundleInfo(YooAsset.PackageBundle packageBundle, YooAsset.AssetInfo assetInfo);
        /*0x2aea33c*/ YooAsset.BundleInfo YooAsset.IBundleServices.GetBundleInfo(YooAsset.AssetInfo assetInfo);
        /*0x2aea3e4*/ YooAsset.BundleInfo[] YooAsset.IBundleServices.GetAllDependBundleInfos(YooAsset.AssetInfo assetInfo);
        /*0x2aea5bc*/ string YooAsset.IBundleServices.GetBundleName(int bundleID);
        /*0x2aea5d4*/ bool YooAsset.IBundleServices.IsServicesValid();
    }

    class HostPlayModeImpl : YooAsset.IPlayModeServices, YooAsset.IBundleServices, YooAsset.IRemoteServices
    {
        /*0x10*/ YooAsset.PackageManifest _activeManifest;
        /*0x18*/ string _packageName;
        /*0x20*/ bool _locationToLower;
        /*0x28*/ string _defaultHostServer;
        /*0x30*/ string _fallbackHostServer;
        /*0x38*/ YooAsset.IQueryServices _queryServices;

        /*0x2aebba8*/ HostPlayModeImpl();
        /*0x2aea5ec*/ YooAsset.InitializationOperation InitializeAsync(string packageName, bool locationToLower, string defaultHostServer, string fallbackHostServer, YooAsset.IQueryServices queryServices);
        /*0x2aea6c0*/ System.Collections.Generic.List<YooAsset.BundleInfo> ConvertToDownloadList(System.Collections.Generic.List<YooAsset.PackageBundle> downloadList);
        /*0x2aea8dc*/ YooAsset.BundleInfo ConvertToDownloadInfo(YooAsset.PackageBundle packageBundle);
        /*0x2aeaa48*/ System.Collections.Generic.List<YooAsset.BundleInfo> ConvertToUnpackList(System.Collections.Generic.List<YooAsset.PackageBundle> unpackList);
        /*0x2aeac58*/ YooAsset.BundleInfo ConvertToUnpackInfo(YooAsset.PackageBundle packageBundle);
        /*0x2aea990*/ string GetRemoteMainURL(string fileName);
        /*0x2aea9ec*/ string GetRemoteFallbackURL(string fileName);
        /*0x2ae7d58*/ void set_ActiveManifest(YooAsset.PackageManifest value);
        /*0x2aeac64*/ YooAsset.PackageManifest get_ActiveManifest();
        /*0x2ae7d94*/ void FlushManifestVersionFile();
        /*0x2aeacd4*/ bool IsBuildinPackageBundle(YooAsset.PackageBundle packageBundle);
        /*0x2aead8c*/ bool IsCachedPackageBundle(YooAsset.PackageBundle packageBundle);
        /*0x2aeadf8*/ YooAsset.UpdatePackageVersionOperation YooAsset.IPlayModeServices.UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);
        /*0x2aeaeb4*/ YooAsset.UpdatePackageManifestOperation YooAsset.IPlayModeServices.UpdatePackageManifestAsync(string packageVersion, int timeout);
        /*0x2aeaf6c*/ YooAsset.PreDownloadContentOperation YooAsset.IPlayModeServices.PreDownloadContentAsync(string packageVersion, int timeout);
        /*0x2aeb024*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae69a8*/ System.Collections.Generic.List<YooAsset.BundleInfo> GetDownloadListByAll(YooAsset.PackageManifest manifest);
        /*0x2aeb0c4*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae6d44*/ System.Collections.Generic.List<YooAsset.BundleInfo> GetDownloadListByTags(YooAsset.PackageManifest manifest, string[] tags);
        /*0x2aeb16c*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByPaths(YooAsset.AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2ae73f0*/ System.Collections.Generic.List<YooAsset.BundleInfo> GetDownloadListByPaths(YooAsset.PackageManifest manifest, YooAsset.AssetInfo[] assetInfos);
        /*0x2aeb214*/ YooAsset.ResourceUnpackerOperation YooAsset.IPlayModeServices.CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aeb2b4*/ System.Collections.Generic.List<YooAsset.BundleInfo> GetUnpackListByAll(YooAsset.PackageManifest manifest);
        /*0x2aeb4f4*/ YooAsset.ResourceUnpackerOperation YooAsset.IPlayModeServices.CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aeb59c*/ System.Collections.Generic.List<YooAsset.BundleInfo> GetUnpackListByTags(YooAsset.PackageManifest manifest, string[] tags);
        /*0x2aeb7f8*/ YooAsset.BundleInfo CreateBundleInfo(YooAsset.PackageBundle packageBundle);
        /*0x2aeb900*/ YooAsset.BundleInfo YooAsset.IBundleServices.GetBundleInfo(YooAsset.AssetInfo assetInfo);
        /*0x2aeb9a8*/ YooAsset.BundleInfo[] YooAsset.IBundleServices.GetAllDependBundleInfos(YooAsset.AssetInfo assetInfo);
        /*0x2aebb80*/ string YooAsset.IBundleServices.GetBundleName(int bundleID);
        /*0x2aebb98*/ bool YooAsset.IBundleServices.IsServicesValid();
    }

    class OfflinePlayModeImpl : YooAsset.IPlayModeServices, YooAsset.IBundleServices
    {
        /*0x10*/ YooAsset.PackageManifest _activeManifest;
        /*0x18*/ bool _locationToLower;

        /*0x2aec238*/ OfflinePlayModeImpl();
        /*0x2aebbb0*/ YooAsset.InitializationOperation InitializeAsync(string packageName, bool locationToLower);
        /*0x2aebc5c*/ void set_ActiveManifest(YooAsset.PackageManifest value);
        /*0x2aebc80*/ YooAsset.PackageManifest get_ActiveManifest();
        /*0x2aebc88*/ void FlushManifestVersionFile();
        /*0x2aebc8c*/ YooAsset.UpdatePackageVersionOperation YooAsset.IPlayModeServices.UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);
        /*0x2aebd18*/ YooAsset.UpdatePackageManifestOperation YooAsset.IPlayModeServices.UpdatePackageManifestAsync(string packageVersion, int timeout);
        /*0x2aebda4*/ YooAsset.PreDownloadContentOperation YooAsset.IPlayModeServices.PreDownloadContentAsync(string packageVersion, int timeout);
        /*0x2aebe30*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aebe44*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aebe58*/ YooAsset.ResourceDownloaderOperation YooAsset.IPlayModeServices.CreateResourceDownloaderByPaths(YooAsset.AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aebe6c*/ YooAsset.ResourceUnpackerOperation YooAsset.IPlayModeServices.CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aebe80*/ YooAsset.ResourceUnpackerOperation YooAsset.IPlayModeServices.CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aebe94*/ YooAsset.BundleInfo CreateBundleInfo(YooAsset.PackageBundle packageBundle);
        /*0x2aebfa0*/ YooAsset.BundleInfo YooAsset.IBundleServices.GetBundleInfo(YooAsset.AssetInfo assetInfo);
        /*0x2aec044*/ YooAsset.BundleInfo[] YooAsset.IBundleServices.GetAllDependBundleInfos(YooAsset.AssetInfo assetInfo);
        /*0x2aec210*/ string YooAsset.IBundleServices.GetBundleName(int bundleID);
        /*0x2aec228*/ bool YooAsset.IBundleServices.IsServicesValid();
    }

    class ResourcePackage
    {
        /*0x10*/ bool _isInitialize;
        /*0x18*/ string _initializeError;
        /*0x20*/ YooAsset.EOperationStatus _initializeStatus;
        /*0x24*/ YooAsset.EPlayMode _playMode;
        /*0x28*/ YooAsset.IBundleServices _bundleServices;
        /*0x30*/ YooAsset.IPlayModeServices _playModeServices;
        /*0x38*/ YooAsset.AssetSystemImpl _assetSystemImpl;
        /*0x40*/ string <PackageName>k__BackingField;

        /*0x2aec258*/ ResourcePackage();
        /*0x2aec2b0*/ ResourcePackage(string packageName);
        /*0x2aec240*/ void set_PackageName(string value);
        /*0x2aec248*/ string get_PackageName();
        /*0x2aec250*/ YooAsset.EOperationStatus get_InitializeStatus();
        /*0x2aec31c*/ void UpdatePackage();
        /*0x2aec330*/ void DestroyPackage();
        /*0x2aec3a8*/ YooAsset.InitializationOperation InitializeAsync(YooAsset.InitializeParameters parameters);
        /*0x2aec6f0*/ void ResetInitializeAfterFailed();
        /*0x2aec764*/ void CheckInitializeParameters(YooAsset.InitializeParameters parameters);
        /*0x2aecb04*/ void InitializeOperation_Completed(YooAsset.AsyncOperationBase op);
        /*0x2aecb28*/ YooAsset.UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);
        /*0x2aecbe4*/ YooAsset.UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, int timeout);
        /*0x2aecca0*/ YooAsset.PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout);
        /*0x2aecd5c*/ YooAsset.ClearUnusedCacheFilesOperation ClearUnusedCacheFilesAsync();
        /*0x2aecdf0*/ string GetPackageVersion();
        /*0x2aecf2c*/ void UnloadUnusedAssets();
        /*0x2aecf5c*/ void ForceUnloadAllAssets();
        /*0x2aecf78*/ bool IsNeedDownloadFromRemote(string location);
        /*0x2aed12c*/ bool IsNeedDownloadFromRemote(YooAsset.AssetInfo assetInfo);
        /*0x2aed20c*/ YooAsset.AssetInfo[] GetAssetInfos(string tag);
        /*0x2aed324*/ YooAsset.AssetInfo[] GetAssetInfos(string[] tags);
        /*0x2aed3d8*/ YooAsset.AssetInfo GetAssetInfo(string location);
        /*0x2aed3e0*/ bool CheckLocationValid(string location);
        /*0x2aed4a8*/ YooAsset.RawFileOperationHandle LoadRawFileSync(YooAsset.AssetInfo assetInfo);
        /*0x2aed4f8*/ YooAsset.RawFileOperationHandle LoadRawFileSync(string location);
        /*0x2aed51c*/ YooAsset.RawFileOperationHandle LoadRawFileAsync(YooAsset.AssetInfo assetInfo);
        /*0x2aed538*/ YooAsset.RawFileOperationHandle LoadRawFileAsync(string location);
        /*0x2aed4b0*/ YooAsset.RawFileOperationHandle LoadRawFileInternal(YooAsset.AssetInfo assetInfo, bool waitForAsyncComplete);
        /*0x2aed568*/ YooAsset.SceneOperationHandle LoadSceneAsync(string location, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        /*0x2aed5c0*/ YooAsset.SceneOperationHandle LoadSceneAsync(YooAsset.AssetInfo assetInfo, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        /*0x2aed5e0*/ YooAsset.AssetOperationHandle LoadAssetSync(YooAsset.AssetInfo assetInfo);
        YooAsset.AssetOperationHandle LoadAssetSync<TObject>(string location);
        /*0x2aed630*/ YooAsset.AssetOperationHandle LoadAssetSync(string location, System.Type type);
        /*0x2aed650*/ YooAsset.AssetOperationHandle LoadAssetAsync(YooAsset.AssetInfo assetInfo);
        YooAsset.AssetOperationHandle LoadAssetAsync<TObject>(string location);
        /*0x2aed66c*/ YooAsset.AssetOperationHandle LoadAssetAsync(string location, System.Type type);
        /*0x2aed5e8*/ YooAsset.AssetOperationHandle LoadAssetInternal(YooAsset.AssetInfo assetInfo, bool waitForAsyncComplete);
        /*0x2aed698*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsSync(YooAsset.AssetInfo assetInfo);
        YooAsset.SubAssetsOperationHandle LoadSubAssetsSync<TObject>(string location);
        /*0x2aed6e8*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsSync(string location, System.Type type);
        /*0x2aed708*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync(YooAsset.AssetInfo assetInfo);
        YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync<TObject>(string location);
        /*0x2aed724*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync(string location, System.Type type);
        /*0x2aed6a0*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsInternal(YooAsset.AssetInfo assetInfo, bool waitForAsyncComplete);
        /*0x2aed750*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aed814*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aed944*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aeda18*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aedb60*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aedd58*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(YooAsset.AssetInfo assetInfo, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aede88*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(YooAsset.AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);
        /*0x2aedf5c*/ YooAsset.ResourceUnpackerOperation CreateResourceUnpacker(string tag, int unpackingMaxNumber, int failedTryAgain);
        /*0x2aee088*/ YooAsset.ResourceUnpackerOperation CreateResourceUnpacker(string[] tags, int unpackingMaxNumber, int failedTryAgain);
        /*0x2aee150*/ YooAsset.ResourceUnpackerOperation CreateResourceUnpacker(int unpackingMaxNumber, int failedTryAgain);
        /*0x2aee210*/ bool IsIncludeBundleFile(string cacheGUID);
        /*0x2aed068*/ YooAsset.AssetInfo ConvertLocationToAssetInfo(string location, System.Type assetType);
        /*0x2aee2dc*/ void DebugCheckInitialize();
        /*0x2aee3ac*/ void DebugCheckUpdateManifest();
        /*0x2aee42c*/ YooAsset.DebugPackageData GetDebugPackageData();
    }

    struct DecryptFileInfo
    {
        /*0x10*/ string BundleName;
        /*0x18*/ string FilePath;
    }

    interface IDecryptionServices
    {
        ulong LoadFromFileOffset(YooAsset.DecryptFileInfo fileInfo);
        byte[] LoadFromMemory(YooAsset.DecryptFileInfo fileInfo);
        System.IO.Stream LoadFromStream(YooAsset.DecryptFileInfo fileInfo);
        uint GetManagedReadBufferSize();
    }

    struct EncryptResult
    {
        /*0x10*/ YooAsset.EBundleLoadMethod LoadMethod;
        /*0x18*/ byte[] EncryptedData;
    }

    struct EncryptFileInfo
    {
        /*0x10*/ string BundleName;
        /*0x18*/ string FilePath;
    }

    interface IEncryptionServices
    {
        YooAsset.EncryptResult Encrypt(YooAsset.EncryptFileInfo fileInfo);
    }

    interface IBundleServices
    {
        YooAsset.BundleInfo GetBundleInfo(YooAsset.AssetInfo assetInfo);
        YooAsset.BundleInfo[] GetAllDependBundleInfos(YooAsset.AssetInfo assetPath);
        string GetBundleName(int bundleID);
        bool IsServicesValid();
    }

    interface IPlayModeServices
    {
        void set_ActiveManifest(YooAsset.PackageManifest value);
        YooAsset.PackageManifest get_ActiveManifest();
        void FlushManifestVersionFile();
        YooAsset.UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);
        YooAsset.UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, int timeout);
        YooAsset.PreDownloadContentOperation PreDownloadContentAsync(string packageVersion, int timeout);
        YooAsset.ResourceDownloaderOperation CreateResourceDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout);
        YooAsset.ResourceDownloaderOperation CreateResourceDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
        YooAsset.ResourceDownloaderOperation CreateResourceDownloaderByPaths(YooAsset.AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);
        YooAsset.ResourceUnpackerOperation CreateResourceUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout);
        YooAsset.ResourceUnpackerOperation CreateResourceUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout);
    }

    interface IRemoteServices
    {
        string GetRemoteMainURL(string fileName);
        string GetRemoteFallbackURL(string fileName);
    }

    interface IQueryServices
    {
        bool QueryStreamingAssets(string fileName);
    }

    class YooAssetSettings : UnityEngine.ScriptableObject
    {
        static uint ManifestFileSign = 5853007;
        static int ManifestFileMaxSize = 104857600;
        static string ManifestFileVersion = "1.4.6";
        static string CacheBundleDataFileName = "__data";
        static string CacheBundleInfoFileName = "__info";
        static string OutputFolderName = "OutputCache";
        static string ReportFileName = "BuildReport";
        static string StreamingAssetsBuildinFolder = "BuildinFiles";
        /*0x18*/ string ManifestFileName;

        /*0x2aee4a8*/ YooAssetSettings();
    }

    class YooAssetSettingsData
    {
        static /*0x0*/ YooAsset.YooAssetSettings _setting;

        static /*0x2aee4f8*/ YooAsset.YooAssetSettings get_Setting();
        static /*0x2aee588*/ void LoadSettingData();
        static /*0x2aee678*/ string GetReportFileName(string packageName, string packageVersion);
        static /*0x2ae4b48*/ string GetManifestBinaryFileName(string packageName, string packageVersion);
        static /*0x2aee800*/ string GetManifestJsonFileName(string packageName, string packageVersion);
        static /*0x2ae4828*/ string GetPackageHashFileName(string packageName, string packageVersion);
        static /*0x2ae5b94*/ string GetPackageVersionFileName(string packageName);
    }

    class BufferReader
    {
        /*0x10*/ byte[] _buffer;
        /*0x18*/ int _index;

        /*0x2ae3360*/ BufferReader(byte[] data);
        /*0x2ae3e04*/ bool get_IsValid();
        /*0x2aee9a8*/ int get_Capacity();
        /*0x2aee9c4*/ byte[] ReadBytes(int count);
        /*0x2ae4404*/ byte ReadByte();
        /*0x2ae3f84*/ bool ReadBool();
        /*0x2aeea50*/ short ReadInt16();
        /*0x2aeeb00*/ ushort ReadUInt16();
        /*0x2ae3fc8*/ int ReadInt32();
        /*0x2ae3e24*/ uint ReadUInt32();
        /*0x2ae4254*/ long ReadInt64();
        /*0x2aeeb04*/ ulong ReadUInt64();
        /*0x2ae3e28*/ string ReadUTF8();
        /*0x2ae419c*/ int[] ReadInt32Array();
        /*0x2aeeb08*/ long[] ReadInt64Array();
        /*0x2ae40bc*/ string[] ReadUTF8Array();
        /*0x2aeebb8*/ void CheckReaderIndex(int length);
    }

    class BufferWriter
    {
        /*0x10*/ byte[] _buffer;
        /*0x18*/ int _index;

        /*0x2aeec20*/ BufferWriter(int capacity);
        /*0x2aeec88*/ int get_Capacity();
        /*0x2aeeca4*/ void Clear();
        /*0x2aeecac*/ void WriteToStream(System.IO.FileStream fileStream);
        /*0x2aeece0*/ void WriteBytes(byte[] data);
        /*0x2aeed2c*/ void WriteByte(byte value);
        /*0x2aeed68*/ void WriteBool(bool value);
        /*0x2aeed7c*/ void WriteInt16(short value);
        /*0x2aeed80*/ void WriteUInt16(ushort value);
        /*0x2aeede8*/ void WriteInt32(int value);
        /*0x2aeedec*/ void WriteUInt32(uint value);
        /*0x2aeeeac*/ void WriteInt64(long value);
        /*0x2aeeeb0*/ void WriteUInt64(ulong value);
        /*0x2aef020*/ void WriteUTF8(string value);
        /*0x2aef178*/ void WriteInt32Array(int[] values);
        /*0x2aef2d8*/ void WriteInt64Array(long[] values);
        /*0x2aef438*/ void WriteUTF8Array(string[] values);
        /*0x2aef598*/ void CheckWriterIndex(int length);
    }

    class SafeProxy
    {
        static uint Poly = 3988292384;
        /*0x10*/ uint[] _table;

        /*0x2aef600*/ SafeProxy();
        /*0x2aef668*/ void Init(uint poly);
        /*0x2aef70c*/ uint Append(uint crc, byte[] input, int offset, int length);
    }

    class CRC32Algorithm : System.Security.Cryptography.HashAlgorithm
    {
        static /*0x0*/ YooAsset.SafeProxy _proxy;
        /*0x24*/ uint _currentCrc;

        static /*0x2af032c*/ CRC32Algorithm();
        static /*0x2aefd10*/ uint Append(uint initial, byte[] input, int offset, int length);
        static /*0x2aefe24*/ uint Append(uint initial, byte[] input);
        static /*0x2aefec8*/ uint Compute(byte[] input, int offset, int length);
        static /*0x2aeff38*/ uint Compute(byte[] input);
        static /*0x2aeff90*/ uint ComputeAndWriteToEnd(byte[] input, int offset, int length);
        static /*0x2af00ec*/ uint ComputeAndWriteToEnd(byte[] input);
        static /*0x2af01c0*/ bool IsValidWithCrcAtEnd(byte[] input, int offset, int lengthWithCrc);
        static /*0x2af0244*/ bool IsValidWithCrcAtEnd(byte[] input);
        static /*0x2aefb5c*/ uint AppendInternal(uint initial, byte[] input, int offset, int length);
        /*0x2aefaac*/ CRC32Algorithm();
        /*0x2aefacc*/ void Initialize();
        /*0x2aefad4*/ void HashCore(byte[] input, int offset, int length);
        /*0x2aefc00*/ byte[] HashFinal();
    }

    class PathHelper
    {
        static /*0x0*/ string _buildinPath;
        static /*0x8*/ string _sandboxPath;

        static /*0x2ae4f38*/ string MakeStreamingLoadPath(string path);
        static /*0x2af04a8*/ string MakePersistentLoadPath(string path);
        static /*0x2af0524*/ string GetPersistentRootPath();
        static /*0x2af06e0*/ string GetRegularPath(string path);
        static /*0x2ae5040*/ string ConvertToWWWPath(string path);
    }

    class PersistentHelper
    {
        static string CacheFolderName = "CacheFiles";
        static string CachedBundleFileFolder = "BundleFiles";
        static string CachedRawFileFolder = "RawFiles";
        static string ManifestFolderName = "ManifestFiles";
        static string AppFootPrintFileName = "ApplicationFootPrint.bytes";
        static /*0x0*/ System.Collections.Generic.Dictionary<string, string> _cachedBundleFileFolder;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, string> _cachedRawFileFolder;

        static /*0x2af08ac*/ PersistentHelper();
        static /*0x2af0760*/ void DeleteSandbox();
        static /*0x2af07d4*/ void DeleteCacheFolder();
        static /*0x2af0840*/ void DeleteManifestFolder();
        static /*0x2ae8544*/ string GetCachedBundleFileFolderPath(string packageName);
        static /*0x2ae8404*/ string GetCachedRawFileFolderPath(string packageName);
        static /*0x2ae2f70*/ string GetAppFootPrintFilePath();
        static /*0x2ae4adc*/ string GetCacheManifestFilePath(string packageName, string packageVersion);
        static /*0x2ae47bc*/ string GetCachePackageHashFilePath(string packageName, string packageVersion);
        static /*0x2ae5e64*/ string GetCachePackageVersionFilePath(string packageName);
        static /*0x2aeac6c*/ void SaveCachePackageVersionFile(string packageName, string version);
    }

    interface ILogger
    {
        void Log(string message);
        void Warning(string message);
        void Error(string message);
        void Exception(System.Exception exception);
    }

    class YooLogger
    {
        static /*0x0*/ YooAsset.ILogger Logger;

        static /*0x2af096c*/ void Log(string info);
        static /*0x2ae5704*/ void Warning(string info);
        static /*0x2ae90a0*/ void Error(string info);
        static /*0x2af0a60*/ void Exception(System.Exception exception);
    }

    class StringUtility
    {
        [ThreadStatic] static System.Text.StringBuilder _cacheBuilder;

        static /*0x2af0de4*/ StringUtility();
        static /*0x2af05e8*/ string Format(string format, object arg0);
        static /*0x2af03a0*/ string Format(string format, object arg0, object arg1);
        static /*0x2af0b58*/ string Format(string format, object arg0, object arg1, object arg2);
        static /*0x2af0c68*/ string Format(string format, object[] args);
        static /*0x2af0d64*/ string RemoveFirstChar(string str);
        static /*0x2af0da0*/ string RemoveLastChar(string str);
        static /*0x2ae9198*/ string RemoveExtension(string str);
    }

    class FileUtility
    {
        static /*0x2ae2fb0*/ string ReadAllText(string filePath);
        static /*0x2ae59cc*/ byte[] ReadAllBytes(string filePath);
        static /*0x2ae30b4*/ void CreateFile(string filePath, string content);
        static /*0x2af0ee4*/ void CreateFile(string filePath, byte[] data);
        static /*0x2af0e64*/ void CreateFileDirectory(string filePath);
        static /*0x2af10d4*/ void CreateDirectory(string directory);
        static /*0x2af1100*/ long GetFileSize(string filePath);
    }

    class HashUtility
    {
        static /*0x2af1168*/ string ToString(byte[] hashBytes);
        static /*0x2af120c*/ string StringSHA1(string str);
        static /*0x2af126c*/ string FileSHA1(string filePath);
        static /*0x2af14d8*/ string StreamSHA1(System.IO.Stream stream);
        static /*0x2af1240*/ string BytesSHA1(byte[] buffer);
        static /*0x2af1504*/ string StringMD5(string str);
        static /*0x2ae5498*/ string FileMD5(string filePath);
        static /*0x2af15a4*/ string StreamMD5(System.IO.Stream stream);
        static /*0x2af1538*/ string BytesMD5(byte[] buffer);
        static /*0x2af1610*/ string StringCRC32(string str);
        static /*0x2af16b8*/ string FileCRC32(string filePath);
        static /*0x2af1924*/ string StreamCRC32(System.IO.Stream stream);
        static /*0x2af1644*/ string BytesCRC32(byte[] buffer);
    }

    class YooAssets
    {
        static /*0x0*/ bool _isInitialize;
        static /*0x8*/ UnityEngine.GameObject _driver;
        static /*0x10*/ System.Collections.Generic.List<YooAsset.ResourcePackage> _packages;
        static /*0x18*/ YooAsset.ResourcePackage _defaultPackage;

        static /*0x2af3d00*/ YooAssets();
        static /*0x2af1998*/ void Initialize(YooAsset.ILogger logger);
        static /*0x2af1bbc*/ void Destroy();
        static /*0x2af1ebc*/ void Update();
        static /*0x2af200c*/ YooAsset.ResourcePackage CreatePackage(string packageName);
        static /*0x2af244c*/ YooAsset.ResourcePackage GetPackage(string packageName);
        static /*0x2af24d8*/ YooAsset.ResourcePackage TryGetPackage(string packageName);
        static /*0x2af2238*/ bool HasPackage(string packageName);
        static /*0x2af2724*/ void StartOperation(YooAsset.GameAsyncOperation operation);
        static /*0x2af277c*/ void SetDownloadSystemBreakpointResumeFileSize(int fileBytes);
        static /*0x2af2808*/ void SetDownloadSystemClearFileResponseCode(System.Collections.Generic.List<long> codes);
        static /*0x2af2894*/ void SetDownloadSystemCertificateHandler(UnityEngine.Networking.CertificateHandler instance);
        static /*0x2af28f0*/ void SetDownloadSystemUnityWebRequest(YooAsset.DownloadRequestDelegate requestDelegate);
        static /*0x2af294c*/ void SetOperationSystemMaxTimeSlice(long milliseconds);
        static /*0x2af2a00*/ void SetCacheSystemCachedFileVerifyLevel(YooAsset.EVerifyLevel verifyLevel);
        static /*0x2af2a8c*/ string GetStreamingAssetBuildinFolderName();
        static /*0x2af2acc*/ string GetSandboxRoot();
        static /*0x2af2ad0*/ void ClearSandbox();
        static /*0x2af2b1c*/ YooAsset.DebugReport GetDebugReport();
        static /*0x2af2d60*/ void SetDefaultPackage(YooAsset.ResourcePackage package);
        static /*0x2af2dbc*/ bool IsNeedDownloadFromRemote(string location);
        static /*0x2af2e24*/ bool IsNeedDownloadFromRemote(YooAsset.AssetInfo assetInfo);
        static /*0x2af2e8c*/ YooAsset.AssetInfo[] GetAssetInfos(string tag);
        static /*0x2af2ef4*/ YooAsset.AssetInfo[] GetAssetInfos(string[] tags);
        static /*0x2af2f5c*/ YooAsset.AssetInfo GetAssetInfo(string location);
        static /*0x2af2fc8*/ bool CheckLocationValid(string location);
        static /*0x2af3030*/ YooAsset.RawFileOperationHandle LoadRawFileSync(YooAsset.AssetInfo assetInfo);
        static /*0x2af309c*/ YooAsset.RawFileOperationHandle LoadRawFileSync(string location);
        static /*0x2af311c*/ YooAsset.RawFileOperationHandle LoadRawFileAsync(YooAsset.AssetInfo assetInfo);
        static /*0x2af3190*/ YooAsset.RawFileOperationHandle LoadRawFileAsync(string location);
        static /*0x2af31f8*/ YooAsset.SceneOperationHandle LoadSceneAsync(string location, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        static /*0x2af3288*/ YooAsset.SceneOperationHandle LoadSceneAsync(YooAsset.AssetInfo assetInfo, UnityEngine.SceneManagement.LoadSceneMode sceneMode, bool activateOnLoad, int priority);
        static /*0x2af3324*/ YooAsset.AssetOperationHandle LoadAssetSync(YooAsset.AssetInfo assetInfo);
        static YooAsset.AssetOperationHandle LoadAssetSync<TObject>(string location);
        static /*0x2af3390*/ YooAsset.AssetOperationHandle LoadAssetSync(string location, System.Type type);
        static /*0x2af341c*/ YooAsset.AssetOperationHandle LoadAssetAsync(YooAsset.AssetInfo assetInfo);
        static YooAsset.AssetOperationHandle LoadAssetAsync<TObject>(string location);
        static /*0x2af3490*/ YooAsset.AssetOperationHandle LoadAssetAsync(string location, System.Type type);
        static /*0x2af3508*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsSync(YooAsset.AssetInfo assetInfo);
        static YooAsset.SubAssetsOperationHandle LoadSubAssetsSync<TObject>(string location);
        static /*0x2af3574*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsSync(string location, System.Type type);
        static /*0x2af3600*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync(YooAsset.AssetInfo assetInfo);
        static YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync<TObject>(string location);
        static /*0x2af3674*/ YooAsset.SubAssetsOperationHandle LoadSubAssetsAsync(string location, System.Type type);
        static /*0x2af36ec*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af3768*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af384c*/ YooAsset.ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af38d0*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af3954*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af39d8*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(YooAsset.AssetInfo assetInfo, int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af3a5c*/ YooAsset.ResourceDownloaderOperation CreateBundleDownloader(YooAsset.AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain);
        static /*0x2af3ae0*/ YooAsset.ResourceUnpackerOperation CreateResourceUnpacker(string tag, int unpackingMaxNumber, int failedTryAgain);
        static /*0x2af3b60*/ YooAsset.ResourceUnpackerOperation CreateResourceUnpacker(string[] tags, int unpackingMaxNumber, int failedTryAgain);
        static /*0x2af3be0*/ YooAsset.ResourceUnpackerOperation CreateResourceUnpacker(int unpackingMaxNumber, int failedTryAgain);
        static /*0x2af3c58*/ void DebugCheckDefaultPackageValid();
    }

    class YooAssetsDriver : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ int LastestUpdateFrame;

        /*0x2af3e78*/ YooAssetsDriver();
        /*0x2af3d9c*/ void Update();
        /*0x2af3de8*/ void DebugCheckDuplicateDriver();
    }
}
