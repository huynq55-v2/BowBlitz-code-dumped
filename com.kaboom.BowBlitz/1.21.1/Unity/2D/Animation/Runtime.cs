class <Module>
{
}

namespace UnityEngine
{
    namespace U2D
    {
        namespace Animation
        {
            class Bone : UnityEngine.MonoBehaviour
            {
                /*0x18*/ string m_Guid;

                /*0x24a1030*/ Bone();
                /*0x24a1020*/ string get_guid();
                /*0x24a1028*/ void set_guid(string value);
            }

            class VertexBuffer
            {
                /*0x10*/ int m_Id;
                /*0x14*/ bool m_IsActive;
                /*0x18*/ int m_DeactivateFrame;
                /*0x20*/ UnityEngine.U2D.Animation.NativeByteArray[] m_Buffers;
                /*0x28*/ int m_ActiveIndex;

                static /*0x24a1220*/ int GetCurrentFrame();
                /*0x24a1054*/ VertexBuffer(int id, int size, bool needDoubleBuffering);
                /*0x24a1038*/ int get_bufferCount();
                /*0x24a1218*/ int GetHashCode();
                /*0x24a1228*/ UnityEngine.U2D.Animation.NativeByteArray GetBuffer(int size);
                /*0x24a1374*/ void ResizeBuffer(int bufferId, int newSize);
                /*0x24a14ec*/ void Deactivate();
                /*0x24a1514*/ void Dispose();
                /*0x24a15f4*/ bool IsSafeToDispose();
            }

            class BufferManager : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.U2D.Animation.BufferManager s_Instance;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.U2D.Animation.VertexBuffer> m_Buffers;
                /*0x20*/ System.Collections.Generic.Queue<UnityEngine.U2D.Animation.VertexBuffer> m_BuffersToDispose;
                /*0x28*/ bool <needDoubleBuffering>k__BackingField;

                static /*0x24a17bc*/ UnityEngine.U2D.Animation.BufferManager get_instance();
                /*0x24a20e8*/ BufferManager();
                /*0x24a1628*/ int get_bufferCount();
                /*0x24a17a8*/ bool get_needDoubleBuffering();
                /*0x24a17b0*/ void set_needDoubleBuffering(bool value);
                /*0x24a18d4*/ void OnEnable();
                /*0x24a19d4*/ void OnDisable();
                /*0x24a1ac8*/ void ForceClearBuffers();
                /*0x24a1d9c*/ UnityEngine.U2D.Animation.NativeByteArray GetBuffer(int id, int bufferSize);
                /*0x24a1e3c*/ UnityEngine.U2D.Animation.VertexBuffer CreateBuffer(int id, int bufferSize);
                /*0x24a1f3c*/ void ReturnBuffer(int id);
                /*0x24a201c*/ void Update();
            }

            class NativeArrayHelpers
            {
                static void ResizeIfNeeded<T>(ref Unity.Collections.NativeArray<T> nativeArray, int size, Unity.Collections.Allocator allocator);
                static void ResizeAndCopyIfNeeded<T>(ref Unity.Collections.NativeArray<T> nativeArray, int size, Unity.Collections.Allocator allocator);
                static void DisposeIfCreated<T>(Unity.Collections.NativeArray<T> nativeArray);
                static void CopyFromNativeSlice<T, S>(Unity.Collections.NativeArray<T> nativeArray, int dstStartIndex, int dstEndIndex, Unity.Collections.NativeSlice<S> slice, int srcStartIndex, int srcEndIndex);
            }

            struct NativeCustomSlice<T>
            {
                /*0x0*/ nint data;
                /*0x0*/ int length;
                /*0x0*/ int stride;

                static UnityEngine.U2D.Animation.NativeCustomSlice<T> Default();
                NativeCustomSlice(Unity.Collections.NativeSlice<T> nativeSlice);
                NativeCustomSlice(Unity.Collections.NativeSlice<byte> slice, int length, int stride);
                T get_Item(int index);
                int get_Length();
            }

            struct NativeCustomSliceEnumerator<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ UnityEngine.U2D.Animation.NativeCustomSlice<T> nativeCustomSlice;
                /*0x0*/ int index;

                NativeCustomSliceEnumerator(Unity.Collections.NativeSlice<byte> slice, int length, int stride);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                bool MoveNext();
                void Reset();
                T get_Current();
                object System.Collections.IEnumerator.get_Current();
                void System.IDisposable.Dispose();
            }

            class SkeletonAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.U2D.SpriteBone[] m_SpriteBones;

                /*0x24a21b8*/ SkeletonAsset();
                /*0x24a21a8*/ UnityEngine.U2D.SpriteBone[] GetSpriteBones();
                /*0x24a21b0*/ void SetSpriteBones(UnityEngine.U2D.SpriteBone[] spriteBones);
            }

            class SpriteLibrary : UnityEngine.MonoBehaviour
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> m_Library;
                /*0x20*/ UnityEngine.U2D.Animation.SpriteLibraryAsset m_SpriteLibraryAsset;
                /*0x28*/ System.Collections.Generic.Dictionary<int, UnityEngine.U2D.Animation.SpriteLibrary.CategoryEntrySprite> m_CategoryEntryHashCache;
                /*0x30*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>> m_CategoryEntryCache;
                /*0x38*/ int m_PreviousSpriteLibraryAsset;
                /*0x40*/ long m_PreviousModificationHash;

                static /*0x24a2c08*/ int GetHashForCategoryAndEntry(string category, string entry);
                /*0x24a3d28*/ SpriteLibrary();
                /*0x24a21c0*/ void set_spriteLibraryAsset(UnityEngine.U2D.Animation.SpriteLibraryAsset value);
                /*0x24a2bd8*/ UnityEngine.U2D.Animation.SpriteLibraryAsset get_spriteLibraryAsset();
                /*0x24a2be0*/ void OnEnable();
                /*0x24a2be4*/ UnityEngine.Sprite GetSprite(string category, string label);
                /*0x24a2cb0*/ UnityEngine.Sprite GetSprite(int hash);
                /*0x24a2d50*/ void UpdateCacheOverridesIfNeeded();
                /*0x24a2e5c*/ bool GetCategoryAndEntryNameFromHash(int hash, ref string category, ref string entry);
                /*0x24a2f44*/ UnityEngine.Sprite GetSpriteFromCategoryAndEntryHash(int hash, ref bool validEntry);
                /*0x24a3004*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> GetEntries(string category, bool addIfNotExist);
                /*0x24a32d4*/ UnityEngine.U2D.Animation.SpriteCategoryEntry GetEntry(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> entries, string entry, bool addIfNotExist);
                /*0x24a3544*/ void AddOverride(UnityEngine.U2D.Animation.SpriteLibraryAsset spriteLib, string category, string label);
                /*0x24a3670*/ void AddOverride(UnityEngine.U2D.Animation.SpriteLibraryAsset spriteLib, string category);
                /*0x24a3858*/ void AddOverride(UnityEngine.Sprite sprite, string category, string label);
                /*0x24a38b0*/ void RemoveOverride(string category);
                /*0x24a39e0*/ void RemoveOverride(string category, string label);
                /*0x24a3b20*/ bool HasOverride(string category, string label);
                /*0x24a2b44*/ void RefreshSpriteResolvers();
                /*0x24a3c34*/ System.Collections.Generic.IEnumerable<string> get_categoryNames();
                /*0x24a3c8c*/ System.Collections.Generic.IEnumerable<string> GetEntryNames(string category);
                /*0x24a2254*/ void CacheOverrides();

                struct CategoryEntrySprite
                {
                    /*0x10*/ string category;
                    /*0x18*/ string entry;
                    /*0x20*/ UnityEngine.Sprite sprite;
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ string category;

                    /*0x24a3238*/ <>c__DisplayClass17_0();
                    /*0x24a3da4*/ bool <GetEntries>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ string entry;

                    /*0x24a34a8*/ <>c__DisplayClass18_0();
                    /*0x24a3dc8*/ bool <GetEntry>b__0(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ int categoryHash;

                    /*0x24a3850*/ <>c__DisplayClass20_0();
                    /*0x24a3dec*/ bool <AddOverride>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ string category;

                    /*0x24a39d8*/ <>c__DisplayClass22_0();
                    /*0x24a3e10*/ bool <RemoveOverride>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ string label;

                    /*0x24a3b18*/ <>c__DisplayClass23_0();
                    /*0x24a3e34*/ bool <RemoveOverride>b__0(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }
            }

            interface INameHash
            {
                string get_name();
                void set_name(string value);
                int get_hash();
            }

            class SpriteCategoryEntry : UnityEngine.U2D.Animation.INameHash
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Hash;
                /*0x20*/ UnityEngine.Sprite m_Sprite;

                /*0x24a34b0*/ SpriteCategoryEntry();
                /*0x24a3e58*/ string get_name();
                /*0x24a34b8*/ void set_name(string value);
                /*0x24a3e60*/ int get_hash();
                /*0x24a3e68*/ UnityEngine.Sprite get_sprite();
                /*0x24a3e70*/ void set_sprite(UnityEngine.Sprite value);
                /*0x24a3e78*/ void UpdateHash();
            }

            class SpriteLibCategory : UnityEngine.U2D.Animation.INameHash
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Hash;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> m_CategoryList;

                /*0x24a3240*/ SpriteLibCategory();
                /*0x24a3ef4*/ string get_name();
                /*0x24a3248*/ void set_name(string value);
                /*0x24a3efc*/ int get_hash();
                /*0x24a3f04*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> get_categoryList();
                /*0x24a3f0c*/ void set_categoryList(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> value);
                /*0x24a3f14*/ void UpdateHash();
                /*0x24a40ac*/ void ValidateLabels();

                class <>c
                {
                    static /*0x0*/ UnityEngine.U2D.Animation.SpriteLibCategory.<> <>9;
                    static /*0x8*/ System.Action<string, string> <>9__12_0;

                    static /*0x24a4648*/ <>c();
                    /*0x24a46ac*/ <>c();
                    /*0x24a46b4*/ void <ValidateLabels>b__12_0(string originalName, string newName);
                }
            }

            class SpriteLibraryAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> m_Labels;
                /*0x20*/ long m_ModificationHash;

                static /*0x24a4748*/ UnityEngine.U2D.Animation.SpriteLibraryAsset CreateAsset(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> categories, string assetName, long version);
                static /*0x24a4190*/ void RenameDuplicate(System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.INameHash> nameHashList, System.Action<string, string> onRename);
                /*0x24a58ec*/ SpriteLibraryAsset();
                /*0x24a4a5c*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> get_categories();
                /*0x24a4a64*/ void set_categories(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> value);
                /*0x24a4b20*/ long get_modificationHash();
                /*0x24a4b28*/ UnityEngine.Sprite GetSprite(int categoryHash, int labelHash);
                /*0x24a4c8c*/ UnityEngine.Sprite GetSprite(int categoryHash, int labelHash, ref bool validEntry);
                /*0x24a35b4*/ UnityEngine.Sprite GetSprite(string category, string label);
                /*0x24a4dec*/ System.Collections.Generic.IEnumerable<string> GetCategoryNames();
                /*0x24a4ee8*/ System.Collections.Generic.IEnumerable<string> GetCategorylabelNames(string category);
                /*0x24a4eec*/ System.Collections.Generic.IEnumerable<string> GetCategoryLabelNames(string category);
                /*0x24a50c8*/ void AddCategoryLabel(UnityEngine.Sprite sprite, string category, string label);
                /*0x24a55e4*/ void RemoveCategoryLabel(string category, string label, bool deleteCategory);
                /*0x24a4914*/ void UpdateHashes();
                /*0x24a47d4*/ void ValidateCategories();
                /*0x24a4a80*/ void UpdateModificationHash();

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ int categoryHash;
                    /*0x14*/ int labelHash;

                    /*0x24a4c84*/ <>c__DisplayClass8_0();
                    /*0x24a5968*/ bool <GetSprite>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x24a598c*/ bool <GetSprite>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.U2D.Animation.SpriteLibraryAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.U2D.Animation.SpriteLibCategory, string> <>9__11_0;
                    static /*0x10*/ System.Func<UnityEngine.U2D.Animation.SpriteCategoryEntry, string> <>9__13_1;
                    static /*0x18*/ System.Action<string, string> <>9__17_0;

                    static /*0x24a59b0*/ <>c();
                    /*0x24a5a14*/ <>c();
                    /*0x24a5a1c*/ string <GetCategoryNames>b__11_0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x24a5a34*/ string <GetCategoryLabelNames>b__13_1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                    /*0x24a5a4c*/ void <ValidateCategories>b__17_0(string originalName, string newName);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ string category;

                    /*0x24a50c0*/ <>c__DisplayClass13_0();
                    /*0x24a5c0c*/ bool <GetCategoryLabelNames>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ int catHash;

                    /*0x24a55d4*/ <>c__DisplayClass14_0();
                    /*0x24a5c30*/ bool <AddCategoryLabel>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass14_1
                {
                    /*0x10*/ int labelHash;

                    /*0x24a55dc*/ <>c__DisplayClass14_1();
                    /*0x24a5c54*/ bool <AddCategoryLabel>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry y);
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ int catHash;
                    /*0x18*/ UnityEngine.U2D.Animation.SpriteLibCategory libCategory;

                    /*0x24a58c4*/ <>c__DisplayClass15_0();
                    /*0x24a5c78*/ bool <RemoveCategoryLabel>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x24a5c9c*/ bool <RemoveCategoryLabel>b__2(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass15_1
                {
                    /*0x10*/ int labelHash;

                    /*0x24a58cc*/ <>c__DisplayClass15_1();
                    /*0x24a5cc8*/ bool <RemoveCategoryLabel>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ UnityEngine.U2D.Animation.INameHash category;

                    /*0x24a58d4*/ <>c__DisplayClass18_0();
                    /*0x24a5cec*/ bool <RenameDuplicate>b__0(UnityEngine.U2D.Animation.INameHash x);
                }

                class <>c__DisplayClass18_1
                {
                    /*0x10*/ UnityEngine.U2D.Animation.INameHash categoryClash;

                    /*0x24a58dc*/ <>c__DisplayClass18_1();
                }

                class <>c__DisplayClass18_2
                {
                    /*0x10*/ int nameHash;
                    /*0x18*/ string name;
                    /*0x20*/ UnityEngine.U2D.Animation.SpriteLibraryAsset.<> CS$<>8__locals1;

                    /*0x24a58e4*/ <>c__DisplayClass18_2();
                    /*0x24a5ef0*/ bool <RenameDuplicate>b__1(UnityEngine.U2D.Animation.INameHash x);
                }
            }

            class SpriteCategoryEntryOverride : UnityEngine.U2D.Animation.SpriteCategoryEntry
            {
                /*0x28*/ bool m_FromMain;
                /*0x30*/ UnityEngine.Sprite m_SpriteOverride;

                /*0x24a604c*/ SpriteCategoryEntryOverride();
                /*0x24a6028*/ bool get_fromMain();
                /*0x24a6030*/ void set_fromMain(bool value);
                /*0x24a603c*/ UnityEngine.Sprite get_spriteOverride();
                /*0x24a6044*/ void set_spriteOverride(UnityEngine.Sprite value);
            }

            class SpriteLibCategoryOverride : UnityEngine.U2D.Animation.SpriteLibCategory
            {
                /*0x28*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> m_OverrideEntries;
                /*0x30*/ bool m_FromMain;
                /*0x34*/ int m_EntryOverrideCount;

                /*0x24a6088*/ SpriteLibCategoryOverride();
                /*0x24a6054*/ bool get_fromMain();
                /*0x24a605c*/ void set_fromMain(bool value);
                /*0x24a6068*/ int get_entryOverrideCount();
                /*0x24a6070*/ void set_entryOverrideCount(int value);
                /*0x24a6078*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> get_overrideEntries();
                /*0x24a6080*/ void set_overrideEntries(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> value);
            }

            class SpriteLibrarySourceAsset : UnityEngine.ScriptableObject
            {
                static string defaultName = "New Sprite Library Asset";
                static string extension = ".spriteLib";
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> m_Library;
                /*0x20*/ string m_PrimaryLibraryGUID;

                /*0x24a63c0*/ SpriteLibrarySourceAsset();
                /*0x24a6090*/ System.Collections.Generic.IReadOnlyList<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> get_library();
                /*0x24a6098*/ void InitializeWithAsset(UnityEngine.U2D.Animation.SpriteLibrarySourceAsset source);
                /*0x24a612c*/ void SetLibrary(System.Collections.Generic.IList<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> newLibrary);
                /*0x24a61c4*/ void SetPrimaryLibraryGUID(string newPrimaryLibraryGUID);
                /*0x24a61cc*/ void AddCategory(UnityEngine.U2D.Animation.SpriteLibCategoryOverride newCategory);
                /*0x24a62a0*/ void RemoveCategory(UnityEngine.U2D.Animation.SpriteLibCategoryOverride categoryToRemove);
                /*0x24a6330*/ void RemoveCategory(int indexToRemove);
                /*0x24a63b0*/ string get_primaryLibraryID();
                /*0x24a63b8*/ void set_primaryLibraryID(string value);
            }

            class SpriteLibraryUtility
            {
                static /*0x0*/ System.Func<string, int> GetStringHash;

                static /*0x24a6568*/ SpriteLibraryUtility();
                static /*0x24a643c*/ int Convert32BitTo30BitHash(int input);
                static /*0x24a6498*/ int Bit30Hash_GetStringHash(string value);
                static /*0x24a6490*/ int PreserveFirst30Bits(int input);
                static /*0x24a6500*/ long GenerateHash();
            }

            class SpriteResolver : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x18*/ float m_CategoryHash;
                /*0x1c*/ float m_labelHash;
                /*0x20*/ float m_SpriteKey;
                /*0x24*/ int m_CategoryHashInt;
                /*0x28*/ int m_LabelHashInt;
                /*0x2c*/ int m_SpriteKeyInt;
                /*0x30*/ int m_PreviousCategoryHash;
                /*0x34*/ int m_PreviousLabelHash;
                /*0x38*/ int m_PreviousSpriteKeyInt;

                static /*0x24a6f78*/ float ConvertCategoryLabelHashToSpriteKey(UnityEngine.U2D.Animation.SpriteLibrary library, int categoryHash, int labelHash);
                static /*0x24a6f70*/ int ConvertFloatToInt(float f);
                static /*0x24a7644*/ float ConvertIntToFloat(int f);
                /*0x24a7a0c*/ SpriteResolver();
                /*0x24a65fc*/ void Reset();
                /*0x24a66e0*/ void SetSprite(UnityEngine.Sprite sprite);
                /*0x24a6db0*/ void OnEnable();
                /*0x24a6698*/ UnityEngine.SpriteRenderer get_spriteRenderer();
                /*0x24a764c*/ void SetCategoryAndLabel(string category, string label);
                /*0x24a7678*/ string GetCategory();
                /*0x24a773c*/ string GetLabel();
                /*0x24a6d48*/ UnityEngine.U2D.Animation.SpriteLibrary get_spriteLibrary();
                /*0x24a7800*/ void LateUpdate();
                /*0x24a794c*/ UnityEngine.Sprite GetSprite(ref bool validEntry);
                /*0x24a3b54*/ void ResolveSpriteToSpriteRenderer();
                /*0x24a79f8*/ void OnTransformParentChanged();
                /*0x24a79fc*/ int get_spriteKeyInt();
                /*0x24a6da4*/ void set_spriteKeyInt(int value);
                /*0x24a7a04*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x24a7a08*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            }

            struct PositionVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
            }

            struct PositionTangentVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Vector4 tangent;
            }

            class SpriteSkin : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x18*/ UnityEngine.Transform m_RootBone;
                /*0x20*/ UnityEngine.Transform[] m_BoneTransforms;
                /*0x28*/ UnityEngine.Bounds m_Bounds;
                /*0x40*/ bool m_UseBatching;
                /*0x41*/ bool m_AlwaysUpdate;
                /*0x42*/ bool m_AutoRebind;
                /*0x48*/ UnityEngine.U2D.Animation.NativeByteArray m_DeformedVertices;
                /*0x50*/ int m_CurrentDeformVerticesLength;
                /*0x58*/ UnityEngine.SpriteRenderer m_SpriteRenderer;
                /*0x60*/ int m_CurrentDeformSprite;
                /*0x64*/ bool m_ForceSkinning;
                /*0x65*/ bool m_BatchSkinning;
                /*0x66*/ bool m_IsValid;
                /*0x68*/ int m_TransformsHash;

                static /*0x24a8de8*/ bool GetSpriteBonesTransforms(UnityEngine.U2D.SpriteBone[] spriteBones, UnityEngine.Transform rootBone, UnityEngine.Transform[] outTransform);
                static /*0x24a919c*/ bool GetSpriteBonesTranformFromPath(UnityEngine.U2D.SpriteBone[] spriteBones, UnityEngine.Transform rootBone, UnityEngine.Transform[] outNewBoneTransform);
                static /*0x24a937c*/ void CalculateBoneTransformsPath(int index, UnityEngine.U2D.SpriteBone[] spriteBones, string[] paths);
                /*0x24a9748*/ SpriteSkin();
                /*0x24a7a14*/ bool get_batchSkinning();
                /*0x24a7a1c*/ void set_batchSkinning(bool value);
                /*0x24a7a28*/ bool get_autoRebind();
                /*0x24a7a30*/ void set_autoRebind(bool value);
                /*0x24a7b50*/ int GetSpriteInstanceID();
                /*0x24a7c14*/ void Awake();
                /*0x24a7c64*/ void OnEnable();
                /*0x24a7c88*/ void OnEditorEnable();
                /*0x24a7c8c*/ void CacheValidFlag();
                /*0x24a7da4*/ void Reset();
                /*0x24a7dd8*/ void UseBatching(bool value);
                /*0x24a7df4*/ UnityEngine.U2D.Animation.NativeByteArray GetDeformedVertices(int spriteVertexCount);
                /*0x24a7ec0*/ bool HasCurrentDeformedVertices();
                /*0x24a7ef8*/ Unity.Collections.NativeArray<byte> GetCurrentDeformedVertices();
                /*0x24a7fac*/ Unity.Collections.NativeSlice<UnityEngine.U2D.Animation.PositionVertex> GetCurrentDeformedVertexPositions();
                /*0x24a80e4*/ Unity.Collections.NativeSlice<UnityEngine.U2D.Animation.PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents();
                /*0x24a821c*/ System.Collections.Generic.IEnumerable<UnityEngine.Vector3> GetDeformedVertexPositionData();
                /*0x24a84ec*/ System.Collections.Generic.IEnumerable<UnityEngine.Vector4> GetDeformedVertexTangentData();
                /*0x24a86c8*/ void OnDisable();
                /*0x24a870c*/ void LateUpdate();
                /*0x24a7a3c*/ void CacheCurrentSprite(bool rebind);
                /*0x24a7bf8*/ UnityEngine.Sprite get_sprite();
                /*0x24a9130*/ UnityEngine.SpriteRenderer get_spriteRenderer();
                /*0x24a9138*/ UnityEngine.Transform[] get_boneTransforms();
                /*0x24a9124*/ void set_boneTransforms(UnityEngine.Transform[] value);
                /*0x24a9144*/ UnityEngine.Transform get_rootBone();
                /*0x24a914c*/ void set_rootBone(UnityEngine.Transform value);
                /*0x24a9158*/ UnityEngine.Bounds get_bounds();
                /*0x24a916c*/ void set_bounds(UnityEngine.Bounds value);
                /*0x24a9180*/ bool get_alwaysUpdate();
                /*0x24a9188*/ void set_alwaysUpdate(bool value);
                /*0x24a7cbc*/ bool get_isValid();
                /*0x24a7cd4*/ void DeactivateSkinning();
                /*0x24a9730*/ void ResetSprite();
                /*0x24a9738*/ void OnBeforeSerialize();
                /*0x24a9740*/ void OnAfterDeserialize();
                /*0x24a7c84*/ void OnEnableBatch();
                /*0x24a912c*/ void UpdateSpriteDeform();
                /*0x24a7dd4*/ void OnResetBatch();
                /*0x24a7df0*/ void UseBatchingBatch();
                /*0x24a8708*/ void OnDisableBatch();
                /*0x24a9140*/ void OnBoneTransformChanged();
                /*0x24a9154*/ void OnRootBoneTransformChanged();
                /*0x24a973c*/ void OnBeforeSerializeBatch();
                /*0x24a9744*/ void OnAfterSerializeBatch();

                class <>c__DisplayClass53_0
                {
                    /*0x10*/ string boneHash;

                    /*0x24a9194*/ <>c__DisplayClass53_0();
                    /*0x24a97a8*/ bool <GetSpriteBonesTransforms>b__0(UnityEngine.U2D.Animation.Bone x);
                }
            }

            class SpriteSkinUpdateHelper : UnityEngine.MonoBehaviour
            {
                /*0x18*/ System.Action<UnityEngine.GameObject> <onDestroyingComponent>k__BackingField;
                /*0x20*/ Unity.Profiling.ProfilerMarker m_ProfilerMarker;

                /*0x24a9818*/ SpriteSkinUpdateHelper();
                /*0x24a97cc*/ System.Action<UnityEngine.GameObject> get_onDestroyingComponent();
                /*0x24a97d4*/ void set_onDestroyingComponent(System.Action<UnityEngine.GameObject> value);
                /*0x24a97dc*/ void OnDestroy();
                /*0x24a9814*/ void LateUpdate();
            }

            enum SpriteSkinValidationResult
            {
                SpriteNotFound = 0,
                SpriteHasNoSkinningInformation = 1,
                SpriteHasNoWeights = 2,
                RootTransformNotFound = 3,
                InvalidTransformArray = 4,
                InvalidTransformArrayLength = 5,
                TransformArrayContainsNull = 6,
                RootNotFoundInTransformArray = 7,
                InvalidBoneWeights = 8,
                Ready = 9,
            }

            class NativeByteArray
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> <array>k__BackingField;

                /*0x24a11ec*/ NativeByteArray(Unity.Collections.NativeArray<byte> array);
                /*0x24a136c*/ int get_Length();
                /*0x24a1594*/ bool get_IsCreated();
                /*0x24a987c*/ byte get_Item(int index);
                /*0x24a9888*/ Unity.Collections.NativeArray<byte> get_array();
                /*0x24a1490*/ void Dispose();
            }

            class SpriteSkinUtility
            {
                static /*0x24a9518*/ UnityEngine.U2D.Animation.SpriteSkinValidationResult Validate(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x24a98f8*/ void CreateBoneHierarchy(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x24a849c*/ int GetVertexStreamSize(UnityEngine.Sprite sprite);
                static /*0x24a83f8*/ int GetVertexStreamOffset(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
                static /*0x24a9ae8*/ void CreateGameObject(int index, UnityEngine.U2D.SpriteBone[] spriteBones, UnityEngine.Transform[] transforms, UnityEngine.Transform root);
                static /*0x24a9d44*/ void ResetBindPose(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x24a9f00*/ int GetHash(UnityEngine.Matrix4x4 matrix);
                static /*0x24a8930*/ int CalculateTransformHash(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x24a9f10*/ void Deform(UnityEngine.Sprite sprite, UnityEngine.Matrix4x4 rootInv, Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> boneTransforms, Unity.Collections.NativeSlice<UnityEngine.Matrix4x4> bindPoses, Unity.Collections.NativeArray<byte> deformableVertices);
                static /*0x24aaeb0*/ void Deform(Unity.Mathematics.float4x4 rootInv, Unity.Collections.NativeSlice<Unity.Mathematics.float3> vertices, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransforms, Unity.Collections.NativeSlice<Unity.Mathematics.float4x4> bindPoses, Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformed);
                static /*0x24aa248*/ void Deform(Unity.Mathematics.float4x4 rootInv, Unity.Collections.NativeSlice<Unity.Mathematics.float3> vertices, Unity.Collections.NativeSlice<Unity.Mathematics.float4> tangents, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransforms, Unity.Collections.NativeSlice<Unity.Mathematics.float4x4> bindPoses, Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformed, Unity.Collections.NativeSlice<Unity.Mathematics.float4> deformedTangents);
                static /*0x24a8a48*/ void Deform(UnityEngine.Sprite sprite, UnityEngine.Matrix4x4 invRoot, UnityEngine.Transform[] boneTransformsArray, Unity.Collections.NativeArray<byte> deformVertexData);
                static /*0x24ab7b8*/ void Bake(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, Unity.Collections.NativeArray<byte> deformVertexData);
                static /*0x24ab8b8*/ void CalculateBounds(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x24aba58*/ UnityEngine.Bounds CalculateSpriteSkinBounds(Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformablePositions);
                static /*0x24a8ca4*/ void UpdateBounds(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, Unity.Collections.NativeArray<byte> deformedVertices);
            }

            class BurstedSpriteSkinUtilities
            {
                static /*0x24a9894*/ bool ValidateBoneWeights(ref Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                static /*0x24abfcc*/ bool ValidateBoneWeights$BurstManaged(ref Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);

                class ValidateBoneWeights_000000E1$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x24ac118*/ ValidateBoneWeights_000000E1$PostfixBurstDelegate(object , nint );
                    /*0x24ac1f0*/ bool Invoke(ref Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                    /*0x24ac204*/ System.IAsyncResult BeginInvoke(ref Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount, System.AsyncCallback , object );
                    /*0x24ac2bc*/ bool EndInvoke(System.IAsyncResult );
                }

                class ValidateBoneWeights_000000E1$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;
                    static /*0x8*/ nint DeferredCompilation;

                    static /*0x24ac508*/ ValidateBoneWeights_000000E1$BurstDirectCall();
                    static /*0x24ac2e4*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x24ac400*/ nint GetFunctionPointer();
                    static /*0x24ac45c*/ void Constructor();
                    static /*0x24ac504*/ void Initialize();
                    static /*0x24abde8*/ bool Invoke(ref Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                }
            }
        }
    }
}

class $BurstDirectCallInitializer
{
    static /*0x24ac50c*/ void Initialize();
}
