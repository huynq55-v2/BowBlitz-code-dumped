class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2640fac*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x2640fb4*/ IsUnmanagedAttribute();
            }
        }
    }
}

class SceneRenderPipeline : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Rendering.RenderPipelineAsset renderPipelineAsset;

    /*0x2640fd4*/ SceneRenderPipeline();
    /*0x2640fbc*/ void OnEnable();
    /*0x2640fc8*/ void OnValidate();
}

namespace UnityEngine
{
    class LightAnchor : UnityEngine.MonoBehaviour
    {
        static float k_ArcRadius = 5;
        static float k_AxisLength = 10;
        static float k_MaxDistance = 10000;
        /*0x18*/ float m_Distance;
        /*0x1c*/ UnityEngine.LightAnchor.UpDirection m_FrameSpace;
        /*0x20*/ UnityEngine.Transform m_AnchorPositionOverride;
        /*0x28*/ UnityEngine.Vector3 m_AnchorPositionOffset;
        /*0x34*/ float m_Yaw;
        /*0x38*/ float m_Pitch;
        /*0x3c*/ float m_Roll;

        static /*0x264101c*/ float NormalizeAngleDegree(float angle);
        /*0x26426d0*/ LightAnchor();
        /*0x2640fdc*/ float get_yaw();
        /*0x2640fe4*/ void set_yaw(float value);
        /*0x2641050*/ float get_pitch();
        /*0x2641058*/ void set_pitch(float value);
        /*0x2641090*/ float get_roll();
        /*0x2641098*/ void set_roll(float value);
        /*0x26410d0*/ float get_distance();
        /*0x26410d8*/ void set_distance(float value);
        /*0x26410f8*/ UnityEngine.LightAnchor.UpDirection get_frameSpace();
        /*0x2641100*/ void set_frameSpace(UnityEngine.LightAnchor.UpDirection value);
        /*0x2641108*/ UnityEngine.Vector3 get_anchorPosition();
        /*0x2641214*/ UnityEngine.Transform get_anchorPositionOverride();
        /*0x264121c*/ void set_anchorPositionOverride(UnityEngine.Transform value);
        /*0x2641224*/ UnityEngine.Vector3 get_anchorPositionOffset();
        /*0x2641230*/ void set_anchorPositionOffset(UnityEngine.Vector3 value);
        /*0x264123c*/ void SynchronizeOnTransform(UnityEngine.Camera camera);
        /*0x26421b0*/ void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x26418f8*/ UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera);
        /*0x2642500*/ void Update();
        /*0x2642600*/ void OnDrawGizmosSelected();
        /*0x2642218*/ void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor);

        enum UpDirection
        {
            World = 0,
            Local = 1,
        }

        struct Axes
        {
            /*0x10*/ UnityEngine.Vector3 up;
            /*0x1c*/ UnityEngine.Vector3 right;
            /*0x28*/ UnityEngine.Vector3 forward;
        }
    }

    namespace Experimental
    {
        namespace Rendering
        {
            class ProbeBrickIndex
            {
                static int kMaxSubdivisionLevels = 7;
                static int kIndexChunkSize = 243;
                /*0x10*/ System.Collections.BitArray m_IndexChunks;
                /*0x18*/ int m_IndexInChunks;
                /*0x1c*/ int m_NextFreeChunk;
                /*0x20*/ UnityEngine.ComputeBuffer m_PhysicalIndexBuffer;
                /*0x28*/ int[] m_PhysicalIndexBufferData;
                /*0x30*/ int <estimatedVMemCost>k__BackingField;
                /*0x34*/ UnityEngine.Vector3Int m_CenterRS;
                /*0x40*/ System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta>> m_VoxelToBricks;
                /*0x48*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId, UnityEngine.Experimental.Rendering.ProbeBrickIndex.BrickMeta> m_BricksToVoxels;
                /*0x50*/ bool m_NeedUpdateIndexComputeBuffer;

                /*0x26427d0*/ ProbeBrickIndex(UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
                /*0x26426d8*/ int get_estimatedVMemCost();
                /*0x26426e0*/ void set_estimatedVMemCost(int value);
                /*0x26426e8*/ int GetVoxelSubdivLevel();
                /*0x264278c*/ int SizeOfPhysicalIndexFromBudget(UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
                /*0x2642af4*/ void UploadIndexData();
                /*0x2642a1c*/ void Clear();
                /*0x2642b20*/ void MapBrickToVoxels(UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick brick, System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels);
                /*0x2642e58*/ void ClearVoxel(UnityEngine.Vector3Int pos, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
                /*0x2643350*/ void GetRuntimeResources(ref UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources rr);
                /*0x2643384*/ void Cleanup();
                /*0x26433e8*/ int MergeIndex(int index, int size);
                /*0x26433f4*/ bool AssignIndexChunksToCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, int bricksCount, ref UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo);
                /*0x264356c*/ void AddBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
                /*0x2644030*/ void RemoveBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
                /*0x2643e2c*/ void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
                /*0x26430ac*/ void UpdatePhysicalIndex(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, int value, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
                /*0x2642f00*/ void ClipToIndexSpace(UnityEngine.Vector3Int pos, int subdiv, ref UnityEngine.Vector3Int outMinpos, ref UnityEngine.Vector3Int outMaxpos, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
                /*0x2644440*/ void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.ReservedBrick> bricks, System.Collections.Generic.List<ushort> indices, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);

                struct Brick : System.IEquatable<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick>
                {
                    /*0x10*/ UnityEngine.Vector3Int position;
                    /*0x1c*/ int subdivisionLevel;

                    /*0x264476c*/ Brick(UnityEngine.Vector3Int position, int subdivisionLevel);
                    /*0x2644778*/ bool Equals(UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick other);
                }

                struct ReservedBrick
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick brick;
                    /*0x20*/ int flattenedIdx;
                }

                struct VoxelMeta
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id;
                    /*0x18*/ System.Collections.Generic.List<ushort> brickIndices;
                }

                struct BrickMeta
                {
                    /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.ReservedBrick> bricks;
                }

                struct CellIndexUpdateInfo
                {
                    /*0x10*/ int firstChunkIndex;
                    /*0x14*/ int numberOfChunks;
                    /*0x18*/ int minSubdivInCell;
                    /*0x1c*/ UnityEngine.Vector3Int minValidBrickIndexForCellAtMaxRes;
                    /*0x28*/ UnityEngine.Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;
                    /*0x34*/ UnityEngine.Vector3Int cellPositionInBricksAtMaxRes;
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id;
                    /*0x18*/ System.Predicate<UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta> <>9__0;

                    /*0x2643e10*/ <>c__DisplayClass31_0();
                    /*0x26447c4*/ bool <AddBricks>b__0(UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta lhs);
                }

                class <>c__DisplayClass32_0
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id;
                    /*0x18*/ System.Predicate<UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta> <>9__0;

                    /*0x2644438*/ <>c__DisplayClass32_0();
                    /*0x26447e0*/ bool <RemoveBricks>b__0(UnityEngine.Experimental.Rendering.ProbeBrickIndex.VoxelMeta lhs);
                }
            }

            class ProbeBrickPool
            {
                static int kBrickCellCount = 3;
                static int kBrickProbeCountPerDim = 4;
                static int kBrickProbeCountTotal = 64;
                static int kMaxPoolWidth = 2048;
                /*0x10*/ int <estimatedVMemCost>k__BackingField;
                /*0x14*/ int m_AllocationSize;
                /*0x18*/ UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
                /*0x20*/ UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation m_Pool;
                /*0x68*/ UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk;
                /*0x78*/ System.Collections.Generic.Stack<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> m_FreeList;
                /*0x80*/ UnityEngine.Experimental.Rendering.ProbeVolumeSHBands m_SHBands;

                static /*0x26454c4*/ UnityEngine.Vector3Int ProbeCountToDataLocSize(int numProbes);
                static /*0x2644908*/ UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands, ref int allocatedBytes);
                static /*0x2645534*/ void SetPixel(ref UnityEngine.Color[] data, int x, int y, int z, int dataLocWidth, int dataLocHeight, UnityEngine.Color value);
                static /*0x2645574*/ void FillDataLocation(ref UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation loc, UnityEngine.Rendering.SphericalHarmonicsL2[] shl2, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands);
                /*0x2644800*/ ProbeBrickPool(int allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands);
                /*0x26447f0*/ int get_estimatedVMemCost();
                /*0x26447f8*/ void set_estimatedVMemCost(int value);
                /*0x2644c14*/ void EnsureTextureValidity();
                /*0x2644d94*/ int GetChunkSize();
                /*0x2644d9c*/ int GetChunkSizeInProbeCount();
                /*0x2644da8*/ int GetPoolWidth();
                /*0x2644db0*/ int GetPoolHeight();
                /*0x2644db8*/ UnityEngine.Vector3Int GetPoolDimensions();
                /*0x2644dc4*/ void GetRuntimeResources(ref UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources rr);
                /*0x2644de8*/ void Clear();
                /*0x2644e44*/ void Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations);
                /*0x2645034*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
                /*0x26451a0*/ void Update(UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands);
                /*0x26448f4*/ void DerivePoolSizeFromBudget(int allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, ref int width, ref int height, ref int depth);
                /*0x2645e14*/ void Cleanup();

                struct BrickChunkAlloc
                {
                    /*0x10*/ int x;
                    /*0x14*/ int y;
                    /*0x18*/ int z;

                    /*0x2643e18*/ int flattenIndex(int sx, int sy);
                }

                struct DataLocation
                {
                    /*0x10*/ UnityEngine.Texture3D TexL0_L1rx;
                    /*0x18*/ UnityEngine.Texture3D TexL1_G_ry;
                    /*0x20*/ UnityEngine.Texture3D TexL1_B_rz;
                    /*0x28*/ UnityEngine.Texture3D TexL2_0;
                    /*0x30*/ UnityEngine.Texture3D TexL2_1;
                    /*0x38*/ UnityEngine.Texture3D TexL2_2;
                    /*0x40*/ UnityEngine.Texture3D TexL2_3;
                    /*0x48*/ int width;
                    /*0x4c*/ int height;
                    /*0x50*/ int depth;

                    /*0x2644cdc*/ void Cleanup();
                }
            }

            class ProbeCellIndices
            {
                static int kUintPerEntry = 3;
                /*0x10*/ int <estimatedVMemCost>k__BackingField;
                /*0x18*/ UnityEngine.ComputeBuffer m_IndexOfIndicesBuffer;
                /*0x20*/ uint[] m_IndexOfIndicesData;
                /*0x28*/ UnityEngine.Vector3Int m_CellCount;
                /*0x34*/ UnityEngine.Vector3Int m_CellMin;
                /*0x40*/ int m_CellSizeInMinBricks;
                /*0x44*/ bool m_NeedUpdateComputeBuffer;

                /*0x2645e60*/ ProbeCellIndices(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, int cellSizeInMinBricks);
                /*0x2645e1c*/ int get_estimatedVMemCost();
                /*0x2645e24*/ void set_estimatedVMemCost(int value);
                /*0x2645e2c*/ UnityEngine.Vector3Int GetCellIndexDimension();
                /*0x2645e3c*/ UnityEngine.Vector3Int GetCellMinPosition();
                /*0x2645e4c*/ int GetFlatIndex(UnityEngine.Vector3Int normalizedPos);
                /*0x2646038*/ int GetFlatIdxForCell(UnityEngine.Vector3Int cellPosition);
                /*0x2646064*/ void AddCell(int cellFlatIdx, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo);
                /*0x26462d8*/ void MarkCellAsUnloaded(int cellFlatIdx);
                /*0x2646338*/ void PushComputeData();
                /*0x2646364*/ void GetRuntimeResources(ref UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources rr);
                /*0x2646398*/ void Cleanup();

                struct IndexMetaData
                {
                    /*0x10*/ UnityEngine.Vector3Int minLocalIdx;
                    /*0x1c*/ UnityEngine.Vector3Int maxLocalIdx;
                    /*0x28*/ int firstChunkIndex;
                    /*0x2c*/ int minSubdiv;

                    /*0x26461cc*/ void Pack(ref uint[] vals);
                }
            }

            struct ProbeVolumeSystemParameters
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget;
                /*0x18*/ UnityEngine.Mesh probeDebugMesh;
                /*0x20*/ UnityEngine.Shader probeDebugShader;
                /*0x28*/ UnityEngine.Experimental.Rendering.ProbeVolumeSceneData sceneData;
                /*0x30*/ UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands;
            }

            struct ProbeVolumeShadingParameters
            {
                /*0x10*/ float normalBias;
                /*0x14*/ float viewBias;
                /*0x18*/ bool scaleBiasByMinDistanceBetweenProbes;
                /*0x1c*/ float samplingNoise;
            }

            enum ProbeVolumeTextureMemoryBudget
            {
                MemoryBudgetLow = 512,
                MemoryBudgetMedium = 1024,
                MemoryBudgetHigh = 2048,
            }

            enum ProbeVolumeSHBands
            {
                SphericalHarmonicsL1 = 1,
                SphericalHarmonicsL2 = 2,
            }

            class ProbeReferenceVolume
            {
                static int kProbeIndexPoolAllocationSize = 128;
                static int kProbesPerBatch = 1023;
                static /*0x0*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume _instance;
                /*0x10*/ bool m_IsInitialized;
                /*0x14*/ int m_ID;
                /*0x18*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RefVolTransform m_Transform;
                /*0x78*/ int m_MaxSubdivision;
                /*0x80*/ UnityEngine.Experimental.Rendering.ProbeBrickPool m_Pool;
                /*0x88*/ UnityEngine.Experimental.Rendering.ProbeBrickIndex m_Index;
                /*0x90*/ UnityEngine.Experimental.Rendering.ProbeCellIndices m_CellIndices;
                /*0x98*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;
                /*0xa0*/ float[] m_PositionOffsets;
                /*0xa8*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc>> m_Registry;
                /*0xb0*/ UnityEngine.Bounds m_CurrGlobalBounds;
                /*0xc8*/ System.Collections.Generic.Dictionary<int, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell> cells;
                /*0xd0*/ System.Collections.Generic.Dictionary<int, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellChunkInfo> m_ChunkInfo;
                /*0xd8*/ UnityEngine.Experimental.Rendering.ProbeVolumeSceneData sceneData;
                /*0xe0*/ System.Action<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction;
                /*0xe8*/ bool m_BricksLoaded;
                /*0xf0*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId> m_CellToBricks;
                /*0xf8*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo> m_BricksToCellUpdateInfo;
                /*0x100*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.ProbeVolumeAsset> m_PendingAssetsToBeLoaded;
                /*0x108*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.ProbeVolumeAsset> m_PendingAssetsToBeUnloaded;
                /*0x110*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.ProbeVolumeAsset> m_ActiveAssets;
                /*0x118*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellSortInfo> m_CellsToBeLoaded;
                /*0x120*/ System.Collections.Generic.Dictionary<int, int> m_CellRefCounting;
                /*0x128*/ bool m_NeedLoadAsset;
                /*0x129*/ bool m_ProbeReferenceVolumeInit;
                /*0x12a*/ bool m_EnabledBySRP;
                /*0x12c*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.InitInfo m_PendingInitInfo;
                /*0x144*/ bool m_NeedsIndexRebuild;
                /*0x145*/ bool m_HasChangedIndex;
                /*0x148*/ int m_CBShaderID;
                /*0x14c*/ int m_NumberOfCellsLoadedPerFrame;
                /*0x150*/ UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
                /*0x154*/ UnityEngine.Experimental.Rendering.ProbeVolumeSHBands m_SHBands;
                /*0x158*/ bool clearAssetsOnVolumeClear;
                /*0x160*/ UnityEngine.Experimental.Rendering.ProbeVolumeDebug <debugDisplay>k__BackingField;
                /*0x168*/ UnityEngine.Color[] <subdivisionDebugColors>k__BackingField;
                /*0x170*/ UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;
                /*0x178*/ UnityEngine.Mesh m_DebugMesh;
                /*0x180*/ UnityEngine.Material m_DebugMaterial;
                /*0x188*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes> m_CellDebugData;
                /*0x190*/ UnityEngine.Plane[] m_DebugFrustumPlanes;
                /*0x198*/ float dilationValidtyThreshold;
                /*0x1a0*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick>> realtimeSubdivisionInfo;

                static /*0x264c3b0*/ ProbeReferenceVolume();
                static /*0x264646c*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume get_instance();
                static /*0x2642e28*/ int CellSize(int subdivisionLevel);
                /*0x264955c*/ ProbeReferenceVolume();
                /*0x26463fc*/ void InvalidateAllCellRefs();
                /*0x264644c*/ bool get_isInitialized();
                /*0x2646454*/ bool get_enabledBySRP();
                /*0x264645c*/ UnityEngine.Experimental.Rendering.ProbeVolumeSHBands get_shBands();
                /*0x2646464*/ UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget();
                /*0x26464c4*/ void SetNumberOfCellsLoadedPerFrame(int numberOfCells);
                /*0x26464d4*/ void Initialize(ref UnityEngine.Experimental.Rendering.ProbeVolumeSystemParameters parameters);
                /*0x26468c4*/ void SetEnableStateFromSRP(bool srpEnablesPV);
                /*0x26468d0*/ void ForceSHBand(UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands);
                /*0x2646964*/ void Cleanup();
                /*0x2646a68*/ int GetVideoMemoryCost();
                /*0x2646ab4*/ void RemoveCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell);
                /*0x2646eac*/ void AddCell(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> chunks);
                /*0x264703c*/ bool CheckCompatibilityWithCollection(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset, System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.ProbeVolumeAsset> collection);
                /*0x26472ac*/ void AddPendingAssetLoading(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset);
                /*0x264782c*/ void AddPendingAssetRemoval(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset);
                /*0x26478e4*/ void RemovePendingAsset(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset);
                /*0x2647ba4*/ void PerformPendingIndexChangeAndInit();
                /*0x2647be4*/ void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv);
                /*0x2647e18*/ void LoadAsset(UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset);
                /*0x26480d4*/ void PerformPendingLoading();
                /*0x2648408*/ void PerformPendingDeletion();
                /*0x26485ac*/ int GetNumberOfBricksAtSubdiv(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, ref UnityEngine.Vector3Int minValidLocalIdxAtMaxRes, ref UnityEngine.Vector3Int sizeOfValidIndicesAtMaxRes);
                /*0x2648b78*/ bool GetCellIndexUpdate(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell, ref UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo);
                /*0x2648ccc*/ void LoadPendingCells(bool loadAll);
                /*0x2649398*/ void PerformPendingOperations(bool loadAllCells);
                /*0x264670c*/ void InitProbeReferenceVolume(int allocationSize, UnityEngine.Experimental.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Experimental.Rendering.ProbeVolumeSHBands shBands);
                /*0x26493d0*/ void SortPendingCells(UnityEngine.Vector3 cameraPosition);
                /*0x2649aac*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources();
                /*0x2647ca4*/ void SetTRS(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, float minBrickSize);
                /*0x2647da8*/ void SetMaxSubdivision(int maxSubdivision);
                /*0x2649b4c*/ float BrickSize(int subdivisionLevel);
                /*0x2648b70*/ float MinBrickSize();
                /*0x26480c8*/ float MaxBrickSize();
                /*0x2649be4*/ UnityEngine.Matrix4x4 GetRefSpaceToWS();
                /*0x2649c00*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RefVolTransform GetTransform();
                /*0x2649c10*/ int GetMaxSubdivision();
                /*0x2649c18*/ int GetMaxSubdivision(float multiplier);
                /*0x2649c90*/ float GetDistanceBetweenProbes(int subdivisionLevel);
                /*0x2649ca8*/ float MinDistanceBetweenProbes();
                /*0x2649cc4*/ bool DataHasBeenLoaded();
                /*0x2649ccc*/ void Clear();
                /*0x264906c*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId AddBricks(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks, UnityEngine.Experimental.Rendering.ProbeBrickPool.DataLocation dataloc, UnityEngine.Experimental.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, ref System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> ch_list);
                /*0x2646ce8*/ void ReleaseBricks(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId id);
                /*0x2649da8*/ void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Experimental.Rendering.ProbeVolumeShadingParameters parameters);
                /*0x2646914*/ void CleanupLoadedData();
                /*0x2649f64*/ UnityEngine.Experimental.Rendering.ProbeVolumeDebug get_debugDisplay();
                /*0x2649f6c*/ UnityEngine.Color[] get_subdivisionDebugColors();
                /*0x2649f74*/ void RenderDebug(UnityEngine.Camera camera);
                /*0x26465a0*/ void InitializeDebug(UnityEngine.Mesh debugProbeMesh, UnityEngine.Shader debugProbeShader);
                /*0x2646a00*/ void CleanupDebug();
                void RefreshDebug<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
                void DebugCellIndexChanged<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
                /*0x264a4cc*/ void RegisterDebug();
                /*0x264b47c*/ void UnregisterDebug(bool destroyPanel);
                /*0x264b554*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes);
                /*0x2649fe4*/ void DrawProbeDebug(UnityEngine.Camera camera);
                /*0x2647b1c*/ void ClearDebugData();
                /*0x264b7cc*/ void CreateInstancedProbes();
                /*0x264c3ac*/ void OnClearLightingdata();
                /*0x264c410*/ bool <RegisterDebug>b__119_0();
                /*0x264c42c*/ void <RegisterDebug>b__119_1(bool value);
                /*0x264c44c*/ bool <RegisterDebug>b__119_2();
                /*0x264c468*/ void <RegisterDebug>b__119_3(bool value);
                /*0x264c488*/ float <RegisterDebug>b__119_4();
                /*0x264c4a4*/ void <RegisterDebug>b__119_5(float value);
                /*0x264c4c0*/ bool <RegisterDebug>b__119_7();
                /*0x264c4dc*/ void <RegisterDebug>b__119_8(bool value);
                /*0x264c4fc*/ int <RegisterDebug>b__119_9();
                /*0x264c518*/ void <RegisterDebug>b__119_10(int value);
                /*0x264c534*/ int <RegisterDebug>b__119_11();
                /*0x264c550*/ void <RegisterDebug>b__119_12(int value);
                /*0x264c56c*/ float <RegisterDebug>b__119_13();
                /*0x264c588*/ void <RegisterDebug>b__119_14(float value);
                /*0x264c5a4*/ float <RegisterDebug>b__119_17();
                /*0x264c5c0*/ void <RegisterDebug>b__119_18(float value);
                /*0x264c5dc*/ float <RegisterDebug>b__119_19();
                /*0x264c5f8*/ void <RegisterDebug>b__119_20(float value);
                /*0x264c614*/ int <RegisterDebug>b__119_22();
                /*0x264c630*/ void <RegisterDebug>b__119_23(int v);

                class Cell
                {
                    /*0x10*/ int index;
                    /*0x14*/ UnityEngine.Vector3Int position;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickIndex.Brick> bricks;
                    /*0x28*/ UnityEngine.Vector3[] probePositions;
                    /*0x30*/ UnityEngine.Rendering.SphericalHarmonicsL2[] sh;
                    /*0x38*/ float[] validity;
                    /*0x40*/ int minSubdiv;
                    /*0x44*/ int flatIdxInCellIndices;
                    /*0x48*/ bool loaded;

                    /*0x264c6e8*/ Cell();
                }

                class CellChunkInfo
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeBrickPool.BrickChunkAlloc> chunks;

                    /*0x2647034*/ CellChunkInfo();
                }

                class CellSortInfo : System.IComparable
                {
                    /*0x10*/ string sourceAsset;
                    /*0x18*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell cell;
                    /*0x20*/ float distanceToCamera;
                    /*0x24*/ UnityEngine.Vector3 position;

                    /*0x26480c0*/ CellSortInfo();
                    /*0x264c6f8*/ int CompareTo(object obj);
                }

                struct Volume : System.IEquatable<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume>
                {
                    /*0x10*/ UnityEngine.Vector3 corner;
                    /*0x1c*/ UnityEngine.Vector3 X;
                    /*0x28*/ UnityEngine.Vector3 Y;
                    /*0x34*/ UnityEngine.Vector3 Z;
                    /*0x40*/ float maxSubdivisionMultiplier;
                    /*0x44*/ float minSubdivisionMultiplier;

                    /*0x264c78c*/ Volume(UnityEngine.Matrix4x4 trs, float maxSubdivision, float minSubdivision);
                    /*0x264c870*/ Volume(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, float maxSubdivision, float minSubdivision);
                    /*0x264c8ac*/ Volume(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume copy);
                    /*0x264c94c*/ UnityEngine.Bounds CalculateAABB();
                    /*0x264ca58*/ void CalculateCenterAndSize(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
                    /*0x264cc10*/ void Transform(UnityEngine.Matrix4x4 trs);
                    /*0x264ccc0*/ string ToString();
                    /*0x264cee0*/ bool Equals(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Volume other);
                }

                struct RefVolTransform
                {
                    /*0x10*/ UnityEngine.Matrix4x4 refSpaceToWS;
                    /*0x50*/ UnityEngine.Vector3 posWS;
                    /*0x5c*/ UnityEngine.Quaternion rot;
                    /*0x6c*/ float scale;
                }

                struct RuntimeResources
                {
                    /*0x10*/ UnityEngine.ComputeBuffer index;
                    /*0x18*/ UnityEngine.ComputeBuffer cellIndices;
                    /*0x20*/ UnityEngine.Texture3D L0_L1rx;
                    /*0x28*/ UnityEngine.Texture3D L1_G_ry;
                    /*0x30*/ UnityEngine.Texture3D L1_B_rz;
                    /*0x38*/ UnityEngine.Texture3D L2_0;
                    /*0x40*/ UnityEngine.Texture3D L2_1;
                    /*0x48*/ UnityEngine.Texture3D L2_2;
                    /*0x50*/ UnityEngine.Texture3D L2_3;
                }

                struct RegId
                {
                    /*0x10*/ int id;

                    static /*0x26447d4*/ bool op_Equality(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId lhs, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId rhs);
                    static /*0x264cffc*/ bool op_Inequality(UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId lhs, UnityEngine.Experimental.Rendering.ProbeReferenceVolume.RegId rhs);
                    /*0x264cfe4*/ bool IsValid();
                    /*0x264cff4*/ void Invalidate();
                    /*0x264d008*/ bool Equals(object obj);
                    /*0x264d0e8*/ int GetHashCode();
                }

                struct ExtraDataActionInput
                {
                }

                struct InitInfo
                {
                    /*0x10*/ UnityEngine.Vector3Int pendingMinCellPosition;
                    /*0x1c*/ UnityEngine.Vector3Int pendingMaxCellPosition;
                }

                class CellInstancedDebugProbes
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Matrix4x4[]> probeBuffers;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> props;
                    /*0x20*/ UnityEngine.Hash128 cellHash;
                    /*0x30*/ UnityEngine.Vector3 cellPosition;

                    /*0x264c3a4*/ CellInstancedDebugProbes();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolume.<> <>9;
                    static /*0x8*/ System.Func<float> <>9__119_6;
                    static /*0x10*/ System.Func<float> <>9__119_15;
                    static /*0x18*/ System.Func<float> <>9__119_16;
                    static /*0x20*/ System.Func<float> <>9__119_21;
                    static /*0x28*/ System.Func<int> <>9__119_24;
                    static /*0x30*/ System.Func<int> <>9__119_25;

                    static /*0x264d0f0*/ <>c();
                    /*0x264d154*/ <>c();
                    /*0x264d15c*/ float <RegisterDebug>b__119_6();
                    /*0x264d164*/ float <RegisterDebug>b__119_15();
                    /*0x264d170*/ float <RegisterDebug>b__119_16();
                    /*0x264d178*/ float <RegisterDebug>b__119_21();
                    /*0x264d180*/ int <RegisterDebug>b__119_24();
                    /*0x264d188*/ int <RegisterDebug>b__119_25();
                }
            }

            enum DebugProbeShadingMode
            {
                SH = 0,
                Validity = 1,
                ValidityOverDilationThreshold = 2,
                Size = 3,
            }

            class ProbeVolumeDebug
            {
                /*0x10*/ bool drawProbes;
                /*0x11*/ bool drawBricks;
                /*0x12*/ bool drawCells;
                /*0x13*/ bool realtimeSubdivision;
                /*0x14*/ int subdivisionCellUpdatePerFrame;
                /*0x18*/ float subdivisionDelayInSeconds;
                /*0x1c*/ UnityEngine.Experimental.Rendering.DebugProbeShadingMode probeShading;
                /*0x20*/ float probeSize;
                /*0x24*/ float subdivisionViewCullingDistance;
                /*0x28*/ float probeCullingDistance;
                /*0x2c*/ int maxSubdivToVisualize;
                /*0x30*/ float exposureCompensation;

                /*0x2649a80*/ ProbeVolumeDebug();
            }

            class ProbeReferenceVolumeProfile : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile.Version version;
                /*0x1c*/ int simplificationLevels;
                /*0x20*/ float minDistanceBetweenProbes;

                /*0x264d418*/ ProbeReferenceVolumeProfile();
                /*0x264d21c*/ int get_cellSizeInBricks();
                /*0x264d250*/ int get_maxSubdivision();
                /*0x264d25c*/ float get_minBrickSize();
                /*0x264d278*/ float get_cellSizeInMeters();
                /*0x264d2dc*/ void OnEnable();
                /*0x264d340*/ bool IsEquivalent(UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile otherProfile);

                enum Version
                {
                    Initial = 0,
                }
            }

            class ProbeVolume : UnityEngine.MonoBehaviour
            {
                /*0x18*/ bool globalVolume;
                /*0x1c*/ UnityEngine.Vector3 size;
                /*0x28*/ float geometryDistanceOffset;
                /*0x2c*/ UnityEngine.LayerMask objectLayerMask;
                /*0x30*/ int lowestSubdivLevelOverride;
                /*0x34*/ int highestSubdivLevelOverride;
                /*0x38*/ bool overridesSubdivLevels;
                /*0x39*/ bool mightNeedRebaking;
                /*0x3c*/ UnityEngine.Matrix4x4 cachedTransform;
                /*0x7c*/ int cachedHashCode;

                /*0x264d49c*/ ProbeVolume();
            }

            class ProbeVolumeAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ int m_Version;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeReferenceVolume.Cell> cells;
                /*0x28*/ UnityEngine.Vector3Int maxCellPosition;
                /*0x34*/ UnityEngine.Vector3Int minCellPosition;
                /*0x40*/ UnityEngine.Bounds globalBounds;
                /*0x58*/ UnityEngine.Experimental.Rendering.ProbeVolumeSHBands bands;
                /*0x60*/ string m_AssetFullPath;
                /*0x68*/ int cellSizeInBricks;
                /*0x6c*/ float minDistanceBetweenProbes;
                /*0x70*/ int simplificationLevels;

                /*0x264d4f0*/ ProbeVolumeAsset();
                /*0x264d4e0*/ int get_Version();
                /*0x26480b4*/ int get_maxSubdivision();
                /*0x2648098*/ float get_minBrickSize();
                /*0x2647244*/ bool CompatibleWith(UnityEngine.Experimental.Rendering.ProbeVolumeAsset otherAsset);
                /*0x264d4e8*/ string GetSerializedFullPath();

                enum AssetVersion
                {
                    First = 0,
                    AddProbeVolumesAtlasEncodingModes = 1,
                    PV2 = 2,
                    ChunkBasedIndex = 3,
                    Max = 4,
                    Current = 3,
                }
            }

            struct ProbeDilationSettings
            {
                /*0x10*/ bool enableDilation;
                /*0x14*/ float dilationDistance;
                /*0x18*/ float dilationValidityThreshold;
                /*0x1c*/ int dilationIterations;
                /*0x20*/ bool squaredDistWeighting;
            }

            struct VirtualOffsetSettings
            {
                /*0x10*/ bool useVirtualOffset;
                /*0x14*/ float outOfGeoOffset;
                /*0x18*/ float searchMultiplier;
            }

            struct ProbeVolumeBakingProcessSettings
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.ProbeDilationSettings dilationSettings;
                /*0x24*/ UnityEngine.Experimental.Rendering.VirtualOffsetSettings virtualOffsetSettings;
            }

            enum ProbeVolumeState
            {
                Default = 0,
                Invalid = 999,
            }

            class ProbeVolumePerSceneData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.ProbeVolumeState, UnityEngine.Experimental.Rendering.ProbeVolumeAsset> assets;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumePerSceneData.SerializableAssetItem> serializedAssets;
                /*0x28*/ UnityEngine.Experimental.Rendering.ProbeVolumeState m_CurrentState;
                /*0x2c*/ UnityEngine.Experimental.Rendering.ProbeVolumeState m_PreviousState;

                /*0x264e12c*/ ProbeVolumePerSceneData();
                /*0x264d590*/ void OnAfterDeserialize();
                /*0x264d754*/ void OnBeforeSerialize();
                /*0x264d9b0*/ void StoreAssetForState(UnityEngine.Experimental.Rendering.ProbeVolumeState state, UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset);
                /*0x264da18*/ void InvalidateAllAssets();
                /*0x264dc64*/ UnityEngine.Experimental.Rendering.ProbeVolumeAsset GetCurrentStateAsset();
                /*0x264dcf4*/ void QueueAssetLoading();
                /*0x264de50*/ void QueueAssetRemoval();
                /*0x264dfb0*/ void OnEnable();
                /*0x264dfb4*/ void OnDisable();
                /*0x264dfb8*/ void OnDestroy();
                /*0x264dfbc*/ void Update();

                struct SerializableAssetItem
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.ProbeVolumeState state;
                    /*0x18*/ UnityEngine.Experimental.Rendering.ProbeVolumeAsset asset;
                }
            }

            class ProbeVolumeSceneData : UnityEngine.ISerializationCallbackReceiver
            {
                static /*0x0*/ System.Reflection.PropertyInfo s_SceneGUID;
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializableBoundItem> serializedBounds;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializableHasPVItem> serializedHasVolumes;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVProfile> serializedProfiles;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVBakeSettings> serializedBakeSettings;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet> serializedBakingSets;
                /*0x38*/ UnityEngine.Object parentAsset;
                /*0x40*/ string parentSceneDataPropertyName;
                /*0x48*/ System.Collections.Generic.Dictionary<string, UnityEngine.Bounds> sceneBounds;
                /*0x50*/ System.Collections.Generic.Dictionary<string, bool> hasProbeVolumes;
                /*0x58*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile> sceneProfiles;
                /*0x60*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings> sceneBakingSettings;
                /*0x68*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet> bakingSets;

                static /*0x26500b8*/ ProbeVolumeSceneData();
                /*0x264e27c*/ ProbeVolumeSceneData(UnityEngine.Object parentAsset, string parentSceneDataPropertyName);
                /*0x264e1b0*/ string GetSceneGUID(UnityEngine.SceneManagement.Scene scene);
                /*0x264e824*/ void SetParentObject(UnityEngine.Object parent, string parentSceneDataPropertyName);
                /*0x264e82c*/ void OnAfterDeserialize();
                /*0x264e534*/ void UpdateBakingSets();
                /*0x264f504*/ void OnBeforeSerialize();
                /*0x264f120*/ UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet CreateNewBakingSet(string name);
                /*0x264f07c*/ void InitializeBakingSet(UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.BakingSet set, string name);
                /*0x264f204*/ void SyncBakingSetSettings();

                struct SerializableBoundItem
                {
                    /*0x10*/ string sceneGUID;
                    /*0x18*/ UnityEngine.Bounds bounds;
                }

                struct SerializableHasPVItem
                {
                    /*0x10*/ string sceneGUID;
                    /*0x18*/ bool hasProbeVolumes;
                }

                struct SerializablePVProfile
                {
                    /*0x10*/ string sceneGUID;
                    /*0x18*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile profile;
                }

                struct SerializablePVBakeSettings
                {
                    /*0x10*/ string sceneGUID;
                    /*0x18*/ UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings settings;
                }

                class BakingSet
                {
                    /*0x10*/ string name;
                    /*0x18*/ System.Collections.Generic.List<string> sceneGUIDs;
                    /*0x20*/ UnityEngine.Experimental.Rendering.ProbeVolumeBakingProcessSettings settings;
                    /*0x40*/ UnityEngine.Experimental.Rendering.ProbeReferenceVolumeProfile profile;

                    /*0x265003c*/ BakingSet();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVProfile, string> <>9__22_0;

                    static /*0x2650174*/ <>c();
                    /*0x26501d8*/ <>c();
                    /*0x26501e0*/ string <UpdateBakingSets>b__22_0(UnityEngine.Experimental.Rendering.ProbeVolumeSceneData.SerializablePVProfile s);
                }
            }

            struct RendererList
            {
                static /*0x0*/ UnityEngine.Rendering.ShaderTagId s_EmptyName;
                static /*0x8*/ UnityEngine.Experimental.Rendering.RendererList nullRendererList;
                /*0x10*/ bool <isValid>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.CullingResults cullingResult;
                /*0x28*/ UnityEngine.Rendering.DrawingSettings drawSettings;
                /*0x164*/ UnityEngine.Rendering.FilteringSettings filteringSettings;
                /*0x17c*/ System.Nullable<UnityEngine.Rendering.RenderStateBlock> stateBlock;

                static /*0x2650680*/ RendererList();
                static /*0x26501fc*/ UnityEngine.Experimental.Rendering.RendererList Create(ref UnityEngine.Experimental.Rendering.RendererListDesc desc);
                /*0x26501e8*/ bool get_isValid();
                /*0x26501f0*/ void set_isValid(bool value);
            }

            struct RendererListDesc
            {
                /*0x10*/ UnityEngine.Rendering.SortingCriteria sortingCriteria;
                /*0x14*/ UnityEngine.Rendering.PerObjectData rendererConfiguration;
                /*0x18*/ UnityEngine.Rendering.RenderQueueRange renderQueueRange;
                /*0x20*/ System.Nullable<UnityEngine.Rendering.RenderStateBlock> stateBlock;
                /*0x90*/ UnityEngine.Material overrideMaterial;
                /*0x98*/ bool excludeObjectMotionVectors;
                /*0x9c*/ int layerMask;
                /*0xa0*/ int overrideMaterialPassIndex;
                /*0xa8*/ UnityEngine.Rendering.CullingResults <cullingResult>k__BackingField;
                /*0xb8*/ UnityEngine.Camera <camera>k__BackingField;
                /*0xc0*/ UnityEngine.Rendering.ShaderTagId <passName>k__BackingField;
                /*0xc8*/ UnityEngine.Rendering.ShaderTagId[] <passNames>k__BackingField;

                /*0x265074c*/ RendererListDesc(UnityEngine.Rendering.ShaderTagId passName, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera);
                /*0x26507a0*/ RendererListDesc(UnityEngine.Rendering.ShaderTagId[] passNames, UnityEngine.Rendering.CullingResults cullingResult, UnityEngine.Camera camera);
                /*0x2650708*/ UnityEngine.Rendering.CullingResults get_cullingResult();
                /*0x2650714*/ void set_cullingResult(UnityEngine.Rendering.CullingResults value);
                /*0x265071c*/ UnityEngine.Camera get_camera();
                /*0x2650724*/ void set_camera(UnityEngine.Camera value);
                /*0x265072c*/ UnityEngine.Rendering.ShaderTagId get_passName();
                /*0x2650734*/ void set_passName(UnityEngine.Rendering.ShaderTagId value);
                /*0x265073c*/ UnityEngine.Rendering.ShaderTagId[] get_passNames();
                /*0x2650744*/ void set_passNames(UnityEngine.Rendering.ShaderTagId[] value);
                /*0x26505cc*/ bool IsValid();
            }

            namespace RenderGraphModule
            {
                enum DepthAccess
                {
                    Read = 1,
                    Write = 2,
                    ReadWrite = 3,
                }

                class RenderGraphContext
                {
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext renderContext;
                    /*0x18*/ UnityEngine.Rendering.CommandBuffer cmd;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool renderGraphPool;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources defaultResources;

                    /*0x2650834*/ RenderGraphContext();
                }

                struct RenderGraphParameters
                {
                    /*0x10*/ string executionName;
                    /*0x18*/ int currentFrameIndex;
                    /*0x1c*/ bool rendererListCulling;
                    /*0x20*/ UnityEngine.Rendering.ScriptableRenderContext scriptableRenderContext;
                    /*0x28*/ UnityEngine.Rendering.CommandBuffer commandBuffer;
                }

                struct RenderGraphExecution : System.IDisposable
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph;

                    /*0x265083c*/ RenderGraphExecution(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph);
                    /*0x2650844*/ void Dispose();
                }

                class RenderGraphDebugParams
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;
                    /*0x18*/ UnityEngine.Rendering.DebugUI.Panel m_DebugPanel;
                    /*0x20*/ bool clearRenderTargetsAtCreation;
                    /*0x21*/ bool clearRenderTargetsAtRelease;
                    /*0x22*/ bool disablePassCulling;
                    /*0x23*/ bool immediateMode;
                    /*0x24*/ bool enableLogging;
                    /*0x25*/ bool logFrameInformation;
                    /*0x26*/ bool logResources;

                    /*0x26511a8*/ RenderGraphDebugParams();
                    /*0x2650a74*/ void RegisterDebug(string name, UnityEngine.Rendering.DebugUI.Panel debugPanel);
                    /*0x2651144*/ void UnRegisterDebug(string name);
                    /*0x26511b0*/ bool <RegisterDebug>b__10_0();
                    /*0x26511b8*/ void <RegisterDebug>b__10_1(bool value);
                    /*0x26511c4*/ bool <RegisterDebug>b__10_2();
                    /*0x26511cc*/ void <RegisterDebug>b__10_3(bool value);
                    /*0x26511d8*/ bool <RegisterDebug>b__10_4();
                    /*0x26511e0*/ void <RegisterDebug>b__10_5(bool value);
                    /*0x26511ec*/ bool <RegisterDebug>b__10_6();
                    /*0x26511f4*/ void <RegisterDebug>b__10_7(bool value);
                    /*0x2651200*/ void <RegisterDebug>b__10_8();
                    /*0x2651280*/ void <RegisterDebug>b__10_9();

                    class Strings
                    {
                        static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;
                        static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip DisablePassCulling;
                        static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ImmediateMode;
                        static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip EnableLogging;
                        static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogFrameInformation;
                        static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogResources;

                        static /*0x2651300*/ Strings();
                    }
                }

                class RenderFunc<PassData> : System.MulticastDelegate
                {
                    RenderFunc(object object, nint method);
                    void Invoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext);
                    System.IAsyncResult BeginInvoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext, System.AsyncCallback callback, object object);
                    void EndInvoke(System.IAsyncResult result);
                }

                class RenderGraphDebugData
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.PassDebugData> passList;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData> resourceLists;

                    /*0x2651664*/ RenderGraphDebugData();
                    /*0x26514cc*/ void Clear();

                    struct PassDebugData
                    {
                        /*0x10*/ string name;
                        /*0x18*/ System.Collections.Generic.List<int> resourceReadLists;
                        /*0x20*/ System.Collections.Generic.List<int> resourceWriteLists;
                        /*0x28*/ bool culled;
                        /*0x29*/ bool generateDebugData;
                    }

                    struct ResourceDebugData
                    {
                        /*0x10*/ string name;
                        /*0x18*/ bool imported;
                        /*0x1c*/ int creationPassIndex;
                        /*0x20*/ int releasePassIndex;
                        /*0x28*/ System.Collections.Generic.List<int> consumerList;
                        /*0x30*/ System.Collections.Generic.List<int> producerList;
                    }
                }

                class RenderGraph
                {
                    static /*0x0*/ int kMaxMRTCount;
                    static /*0x8*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> s_RegisteredGraphs;
                    static /*0x10*/ bool <requireDebugData>k__BackingField;
                    static /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphRegistered;
                    static /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered;
                    static /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered;
                    static /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool m_RenderGraphPool;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass> m_RenderPasses;
                    /*0x28*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> m_RendererLists;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams m_DebugParameters;
                    /*0x38*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources m_DefaultResources;
                    /*0x48*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProfilingSampler> m_DefaultProfilingSamplers;
                    /*0x50*/ bool m_ExecutionExceptionWasRaised;
                    /*0x58*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext m_RenderGraphContext;
                    /*0x60*/ UnityEngine.Rendering.CommandBuffer m_PreviousCommandBuffer;
                    /*0x68*/ int m_CurrentImmediatePassIndex;
                    /*0x70*/ System.Collections.Generic.List<int> m_ImmediateModeResourceList;
                    /*0x78*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> m_CompiledResourcesInfos;
                    /*0x80*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> m_CompiledPassInfos;
                    /*0x88*/ System.Collections.Generic.Stack<int> m_CullingStack;
                    /*0x90*/ int m_ExecutionCount;
                    /*0x94*/ int m_CurrentFrameIndex;
                    /*0x98*/ bool m_HasRenderGraphBegun;
                    /*0xa0*/ string m_CurrentExecutionName;
                    /*0xa8*/ bool m_RendererListCulling;
                    /*0xb0*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData> m_DebugData;
                    /*0xb8*/ string <name>k__BackingField;

                    static /*0x2658cc8*/ RenderGraph();
                    static /*0x2651714*/ bool get_requireDebugData();
                    static /*0x265176c*/ void set_requireDebugData(bool value);
                    static /*0x2651dd8*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs();
                    static /*0x26530cc*/ void add_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x26531a8*/ void remove_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x2653284*/ void add_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x2653360*/ void remove_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x265343c*/ void add_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    static /*0x2653518*/ void remove_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    static /*0x26535f4*/ void add_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    static /*0x26536d0*/ void remove_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    /*0x26517d0*/ RenderGraph(string name);
                    /*0x2651704*/ string get_name();
                    /*0x265170c*/ void set_name(string value);
                    /*0x26517c8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                    /*0x2651cbc*/ void Cleanup();
                    /*0x2651d9c*/ void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel);
                    /*0x2651dc0*/ void UnRegisterDebug();
                    /*0x2651e30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData GetDebugData(string executionName);
                    /*0x2651ea8*/ void EndFrame();
                    /*0x2651f70*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                    /*0x2651f8c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                    /*0x2651fd8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x2651ff8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                    /*0x265206c*/ void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x26520dc*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x265215c*/ void CreateTextureIfInvalid(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x26521ac*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x26521f4*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                    /*0x2652210*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer);
                    /*0x265222c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc);
                    /*0x265224c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle computeBuffer);
                    /*0x26522a8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle computeBuffer);
                    UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler);
                    UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData);
                    /*0x26522e8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphExecution RecordAndExecute(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphParameters parameters);
                    /*0x265085c*/ void Execute();
                    /*0x26529a0*/ void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x2652bb8*/ void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x2652dd0*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos();
                    /*0x2652dd8*/ void ClearCompiledGraph();
                    /*0x2653048*/ void InvalidateContext();
                    /*0x2653068*/ void OnPassAdded(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x26537ac*/ void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, int count);
                    /*0x2653864*/ void InitializeCompilationData();
                    /*0x26539d4*/ void CountReferences();
                    /*0x2654198*/ void CullUnusedPasses();
                    /*0x2654b2c*/ void UpdatePassSynchronization(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo currentPassInfo, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex);
                    /*0x2654b54*/ void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo resource);
                    /*0x2654c80*/ int GetLatestProducerIndex(int passIndex, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x2654dd0*/ int GetLatestValidReadIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x2654eb4*/ int GetFirstValidWriteIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x2654fa8*/ int GetLatestValidWriteIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x265508c*/ void CreateRendererLists();
                    /*0x2655170*/ void UpdateResourceAllocationAndSynchronization();
                    /*0x2655a08*/ bool AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists);
                    /*0x2655be0*/ void TryCullPassAtIndex(int passIndex);
                    /*0x2655cd8*/ void CullRendererLists();
                    /*0x2652724*/ void CompileRenderGraph();
                    /*0x2655eec*/ ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo CompilePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x26530a8*/ void ExecutePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x26567e4*/ void ExecuteCompiledPass(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, int passIndex);
                    /*0x2652848*/ void ExecuteRenderGraph();
                    /*0x2657300*/ void PreRenderPassSetRenderTargets(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x2656e3c*/ void PreRenderPassExecute(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x26570cc*/ void PostRenderPassExecute(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x2652ebc*/ void ClearRenderPasses();
                    /*0x26576c0*/ void ReleaseImmediateModeResources();
                    /*0x2652548*/ void LogFrameInformation();
                    /*0x2655dd8*/ void LogRendererListsCreation();
                    /*0x2656b44*/ void LogRenderPassBegin(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                    /*0x2654780*/ void LogCulledPasses();
                    /*0x2657858*/ UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(string name);
                    /*0x2657948*/ void UpdateImportedResourceLifeTime(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData data, System.Collections.Generic.List<int> passList);
                    /*0x2657b1c*/ void GenerateDebugData();
                    /*0x2658af8*/ void CleanupDebugData();

                    struct CompiledResourceInfo
                    {
                        /*0x10*/ System.Collections.Generic.List<int> producers;
                        /*0x18*/ System.Collections.Generic.List<int> consumers;
                        /*0x20*/ int refCount;
                        /*0x24*/ bool imported;

                        /*0x2658d68*/ void Reset();
                    }

                    struct CompiledPassInfo
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass;
                        /*0x18*/ System.Collections.Generic.List<int> resourceCreateList;
                        /*0x20*/ System.Collections.Generic.List<int> resourceReleaseList;
                        /*0x28*/ int refCount;
                        /*0x2c*/ bool culled;
                        /*0x2d*/ bool hasSideEffect;
                        /*0x30*/ int syncToPassIndex;
                        /*0x34*/ int syncFromPassIndex;
                        /*0x38*/ bool needGraphicsFence;
                        /*0x40*/ UnityEngine.Rendering.GraphicsFence fence;
                        /*0x50*/ bool enableAsyncCompute;

                        /*0x2658e48*/ bool get_allowPassCulling();
                        /*0x2658e64*/ void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    }

                    class ProfilingScopePassData
                    {
                        /*0x10*/ UnityEngine.Rendering.ProfilingSampler sampler;

                        /*0x2659050*/ ProfilingScopePassData();
                    }

                    class OnGraphRegisteredDelegate : System.MulticastDelegate
                    {
                        /*0x2659058*/ OnGraphRegisteredDelegate(object object, nint method);
                        /*0x2659184*/ void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph);
                        /*0x2659198*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, object object);
                        /*0x26591b8*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class OnExecutionRegisteredDelegate : System.MulticastDelegate
                    {
                        /*0x26591c4*/ OnExecutionRegisteredDelegate(object object, nint method);
                        /*0x26592f4*/ void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, string executionName);
                        /*0x2659308*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, string executionName, System.AsyncCallback callback, object object);
                        /*0x2659330*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData> <>9__61_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData> <>9__62_0;

                        static /*0x265933c*/ <>c();
                        /*0x26593a0*/ <>c();
                        /*0x26593a8*/ void <BeginProfilingSampler>b__61_0(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext ctx);
                        /*0x26593d0*/ void <EndProfilingSampler>b__62_0(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext ctx);
                    }
                }

                struct RenderGraphProfilingScope : System.IDisposable
                {
                    /*0x10*/ bool m_Disposed;
                    /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;

                    /*0x26593f8*/ RenderGraphProfilingScope(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x2659420*/ void Dispose();
                    /*0x2659428*/ void Dispose(bool disposing);
                }

                struct RenderGraphBuilder : System.IDisposable
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                    /*0x28*/ bool m_Disposed;

                    /*0x265a450*/ RenderGraphBuilder(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph);
                    /*0x2659464*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input, int index);
                    /*0x2659620*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags);
                    /*0x2659844*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input);
                    /*0x26597b4*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle WriteTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input);
                    /*0x2659c9c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input);
                    /*0x2659cec*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x2659ef8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x2659f88*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle UseRendererList(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle input);
                    /*0x265a058*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ReadComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle input);
                    /*0x265a07c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle WriteComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle input);
                    /*0x265a0bc*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc);
                    /*0x265a1e4*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle computebuffer);
                    void SetRenderFunc<PassData>(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc);
                    /*0x265a364*/ void EnableAsyncCompute(bool value);
                    /*0x265a390*/ void AllowPassCulling(bool value);
                    /*0x265a3bc*/ void Dispose();
                    /*0x265a3fc*/ void AllowRendererListCulling(bool value);
                    /*0x265a428*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle DependsOn(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle input);
                    /*0x265a3c4*/ void Dispose(bool disposing);
                    /*0x26594ac*/ void CheckResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res, bool dontCheckTransientReadWrite);
                    /*0x265a460*/ void GenerateDebugData(bool value);
                }

                class RenderGraphDefaultResources
                {
                    /*0x10*/ bool m_IsValid;
                    /*0x18*/ UnityEngine.Rendering.RTHandle m_BlackTexture2D;
                    /*0x20*/ UnityEngine.Rendering.RTHandle m_WhiteTexture2D;
                    /*0x28*/ UnityEngine.Rendering.RTHandle m_ShadowTexture2D;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTexture>k__BackingField;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <whiteTexture>k__BackingField;
                    /*0x50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <clearTextureXR>k__BackingField;
                    /*0x60*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <magentaTextureXR>k__BackingField;
                    /*0x70*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTextureXR>k__BackingField;
                    /*0x80*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTextureArrayXR>k__BackingField;
                    /*0x90*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackUIntTextureXR>k__BackingField;
                    /*0xa0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTexture3DXR>k__BackingField;
                    /*0xb0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <whiteTextureXR>k__BackingField;
                    /*0xc0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <defaultShadowTexture>k__BackingField;

                    /*0x265a554*/ RenderGraphDefaultResources();
                    /*0x265a48c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture();
                    /*0x265a498*/ void set_blackTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a4a0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTexture();
                    /*0x265a4ac*/ void set_whiteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a4b4*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR();
                    /*0x265a4c0*/ void set_clearTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a4c8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR();
                    /*0x265a4d4*/ void set_magentaTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a4dc*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR();
                    /*0x265a4e8*/ void set_blackTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a4f0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR();
                    /*0x265a4fc*/ void set_blackTextureArrayXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a504*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR();
                    /*0x265a510*/ void set_blackUIntTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a518*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR();
                    /*0x265a524*/ void set_blackTexture3DXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a52c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR();
                    /*0x265a538*/ void set_whiteTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a540*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture();
                    /*0x265a54c*/ void set_defaultShadowTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265a65c*/ void Cleanup();
                    /*0x265a69c*/ void InitializeForRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph);
                }

                struct RenderGraphLogIndent : System.IDisposable
                {
                    /*0x10*/ int m_Indentation;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_Logger;
                    /*0x20*/ bool m_Disposed;

                    /*0x265a868*/ RenderGraphLogIndent(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger, int indentation);
                    /*0x265a900*/ void Dispose();
                    /*0x265a930*/ void Dispose(bool disposing);
                }

                class RenderGraphLogger
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, System.Text.StringBuilder> m_LogMap;
                    /*0x18*/ System.Text.StringBuilder m_CurrentBuilder;
                    /*0x20*/ int m_CurrentIndentation;

                    /*0x265ad90*/ RenderGraphLogger();
                    /*0x265a9e0*/ void Initialize(string logName);
                    /*0x265a890*/ void IncrementIndentation(int value);
                    /*0x265a964*/ void DecrementIndentation(int value);
                    /*0x265aac4*/ void LogLine(string format, object[] args);
                    /*0x265ab3c*/ string GetLog(string logName);
                    /*0x265abdc*/ string GetAllLogs();
                }

                class RenderGraphObjectPool
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, int>, System.Collections.Generic.Stack<object>> m_ArrayPool;
                    /*0x18*/ System.Collections.Generic.List<System.ValueTuple<object, System.ValueTuple<System.Type, int>>> m_AllocatedArrays;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

                    /*0x265ae0c*/ RenderGraphObjectPool();
                    T[] GetTempArray<T>(int size);
                    /*0x265af10*/ UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock();
                    /*0x265b024*/ void ReleaseAllTempAlloc();
                    T Get<T>();
                    void Release<T>(T value);
                    /*0x265b3e0*/ void Cleanup();

                    class SharedObjectPoolBase
                    {
                        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools;

                        static /*0x265b648*/ SharedObjectPoolBase();
                        static /*0x265b4c8*/ void ClearAll();
                        /*0x265b640*/ SharedObjectPoolBase();
                        void Clear();
                    }

                    class SharedObjectPool<T> : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase
                    {
                        static /*0x0*/ System.Lazy<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T>> s_Instance;
                        /*0x0*/ System.Collections.Generic.Stack<T> m_Pool;

                        static SharedObjectPool();
                        static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> AllocatePool();
                        static UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> get_sharedPool();
                        SharedObjectPool();
                        T Get();
                        void Release(T value);
                        void Clear();
                    }
                }

                class RenderGraphPass
                {
                    /*0x10*/ string <name>k__BackingField;
                    /*0x18*/ int <index>k__BackingField;
                    /*0x20*/ UnityEngine.Rendering.ProfilingSampler <customSampler>k__BackingField;
                    /*0x28*/ bool <enableAsyncCompute>k__BackingField;
                    /*0x29*/ bool <allowPassCulling>k__BackingField;
                    /*0x2c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <depthBuffer>k__BackingField;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] <colorBuffers>k__BackingField;
                    /*0x48*/ int <colorBufferMaxIndex>k__BackingField;
                    /*0x4c*/ int <refCount>k__BackingField;
                    /*0x50*/ bool <generateDebugData>k__BackingField;
                    /*0x51*/ bool <allowRendererListCulling>k__BackingField;
                    /*0x58*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle> resourceReadLists;
                    /*0x60*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle> resourceWriteLists;
                    /*0x68*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle> transientResourceList;
                    /*0x70*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> usedRendererListList;
                    /*0x78*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> dependsOnRendererListList;

                    /*0x265b7a0*/ RenderGraphPass();
                    UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> GetExecuteDelegate<PassData>();
                    void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext);
                    void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                    bool HasRenderFunc();
                    /*0x265b6d4*/ string get_name();
                    /*0x265b6dc*/ void set_name(string value);
                    /*0x265b6e4*/ int get_index();
                    /*0x265b6ec*/ void set_index(int value);
                    /*0x265b6f4*/ UnityEngine.Rendering.ProfilingSampler get_customSampler();
                    /*0x265b6fc*/ void set_customSampler(UnityEngine.Rendering.ProfilingSampler value);
                    /*0x265b704*/ bool get_enableAsyncCompute();
                    /*0x265b70c*/ void set_enableAsyncCompute(bool value);
                    /*0x265b718*/ bool get_allowPassCulling();
                    /*0x265b720*/ void set_allowPassCulling(bool value);
                    /*0x265b72c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_depthBuffer();
                    /*0x265b73c*/ void set_depthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x265b748*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] get_colorBuffers();
                    /*0x265b750*/ void set_colorBuffers(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] value);
                    /*0x265b758*/ int get_colorBufferMaxIndex();
                    /*0x265b760*/ void set_colorBufferMaxIndex(int value);
                    /*0x265b768*/ int get_refCount();
                    /*0x265b770*/ void set_refCount(int value);
                    /*0x265b778*/ bool get_generateDebugData();
                    /*0x265b780*/ void set_generateDebugData(bool value);
                    /*0x265b78c*/ bool get_allowRendererListCulling();
                    /*0x265b794*/ void set_allowRendererListCulling(bool value);
                    /*0x265ba00*/ void Clear();
                    /*0x2659bd0*/ void AddResourceWrite(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x2659b04*/ void AddResourceRead(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x2659e2c*/ void AddTransientResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x2659fb0*/ void UseRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList);
                    /*0x265bc60*/ void DependsOnRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList);
                    /*0x265a384*/ void EnableAsyncCompute(bool value);
                    /*0x265a3b0*/ void AllowPassCulling(bool value);
                    /*0x265a41c*/ void AllowRendererListCulling(bool value);
                    /*0x265a480*/ void GenerateDebugData(bool value);
                    /*0x265955c*/ void SetColorBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, int index);
                    /*0x26597f4*/ void SetDepthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags);
                }

                class RenderGraphPass<PassData> : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass
                {
                    /*0x0*/ PassData data;
                    /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc;

                    RenderGraphPass();
                    void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext);
                    void Initialize(int passIndex, PassData passData, string passName, UnityEngine.Rendering.ProfilingSampler sampler);
                    void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                    bool HasRenderFunc();
                }

                enum RenderGraphProfileId
                {
                    CompileRenderGraph = 0,
                    ExecuteRenderGraph = 1,
                    RenderGraphClear = 2,
                    RenderGraphClearDebug = 3,
                }

                struct ComputeBufferHandle
                {
                    static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle s_NullHandle;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle;

                    static /*0x265bfd4*/ ComputeBufferHandle();
                    static /*0x265bd08*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle get_nullHandle();
                    static /*0x265be24*/ UnityEngine.ComputeBuffer op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle buffer);
                    /*0x265bd60*/ ComputeBufferHandle(int handle, bool shared);
                    /*0x265be94*/ bool IsValid();
                }

                struct ComputeBufferDesc
                {
                    /*0x10*/ int count;
                    /*0x14*/ int stride;
                    /*0x18*/ UnityEngine.ComputeBufferType type;
                    /*0x20*/ string name;

                    /*0x265bfd8*/ ComputeBufferDesc(int count, int stride);
                    /*0x265bfec*/ ComputeBufferDesc(int count, int stride, UnityEngine.ComputeBufferType type);
                    /*0x265c000*/ int GetHashCode();
                }

                class ComputeBufferResource : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc, UnityEngine.ComputeBuffer>
                {
                    /*0x265c6dc*/ ComputeBufferResource();
                    /*0x265c024*/ string GetName();
                    /*0x265c078*/ void CreatePooledGraphicsResource();
                    /*0x265c20c*/ void ReleasePooledGraphicsResource(int frameIndex);
                    /*0x265c37c*/ void CreateGraphicsResource(string name);
                    /*0x265c4e4*/ void ReleaseGraphicsResource();
                    /*0x265c53c*/ void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x265c60c*/ void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                }

                class ComputeBufferPool : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.ComputeBuffer>
                {
                    /*0x265cd74*/ ComputeBufferPool();
                    /*0x265c724*/ void ReleaseInternalResource(UnityEngine.ComputeBuffer res);
                    /*0x265c73c*/ string GetResourceName(UnityEngine.ComputeBuffer res);
                    /*0x265c77c*/ long GetResourceSize(UnityEngine.ComputeBuffer res);
                    /*0x265c7c0*/ string GetResourceTypeName();
                    /*0x265c800*/ int GetSortIndex(UnityEngine.ComputeBuffer res);
                    /*0x265c820*/ void PurgeUnusedResources(int currentFrameIndex);
                }

                class IRenderGraphResourcePool
                {
                    /*0x265cdbc*/ IRenderGraphResourcePool();
                    void PurgeUnusedResources(int currentFrameIndex);
                    void Cleanup();
                    void CheckFrameAllocation(bool onException, int frameIndex);
                    void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                }

                class RenderGraphResourcePool<Type> : UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool
                {
                    static int kStaleResourceLifetime = 10;
                    static /*0x0*/ int s_CurrentFrameIndex;
                    /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<Type, int>>> m_ResourcePool;
                    /*0x0*/ System.Collections.Generic.List<int> m_RemoveList;
                    /*0x0*/ System.Collections.Generic.List<System.ValueTuple<int, Type>> m_FrameAllocatedResources;

                    static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
                    RenderGraphResourcePool();
                    void ReleaseInternalResource(Type res);
                    string GetResourceName(Type res);
                    long GetResourceSize(Type res);
                    string GetResourceTypeName();
                    int GetSortIndex(Type res);
                    void ReleaseResource(int hash, Type resource, int currentFrameIndex);
                    bool TryGetResource(int hashCode, ref Type resource);
                    void Cleanup();
                    void RegisterFrameAllocation(int hash, Type value);
                    void UnregisterFrameAllocation(int hash, Type value);
                    void CheckFrameAllocation(bool onException, int frameIndex);
                    void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);

                    struct ResourceLogInfo<Type>
                    {
                        /*0x0*/ string name;
                        /*0x0*/ long size;
                    }

                    class <>c<Type>
                    {
                        static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.<>c<Type> <>9;
                        static /*0x0*/ System.Comparison<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type>> <>9__17_0;

                        static <>c();
                        <>c();
                        int <LogResources>b__17_0(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> a, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> b);
                    }
                }

                class RenderGraphResourceRegistry
                {
                    static int kSharedResourceLifetime = 30;
                    static int kInitialRendererListCount = 256;
                    static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_CurrentRegistry;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.RenderGraphResourcesData[] m_RenderGraphResources;
                    /*0x18*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListResource> m_RendererListResources;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams m_RenderGraphDebug;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_ResourceLogger;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;
                    /*0x38*/ int m_CurrentFrameIndex;
                    /*0x3c*/ int m_ExecutionCount;
                    /*0x40*/ UnityEngine.Rendering.RTHandle m_CurrentBackbuffer;
                    /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.RendererUtils.RendererList> m_ActiveRendererLists;

                    static /*0x265cdc4*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current();
                    static /*0x265ce0c*/ void set_current(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry value);
                    /*0x265d2e0*/ RenderGraphResourceRegistry();
                    /*0x265d3fc*/ RenderGraphResourceRegistry(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger);
                    /*0x265ce58*/ UnityEngine.Rendering.RTHandle GetTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle handle);
                    /*0x2659750*/ bool TextureNeedsFallback(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle handle);
                    /*0x265d11c*/ UnityEngine.Rendering.RendererUtils.RendererList GetRendererList(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle handle);
                    /*0x265be98*/ UnityEngine.ComputeBuffer GetComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle handle);
                    /*0x265d8e8*/ void BeginRenderGraph(int executionCount);
                    /*0x265da54*/ void BeginExecute(int currentFrameIndex);
                    /*0x265dc04*/ void EndExecute();
                    /*0x265dc44*/ void CheckHandleValidity(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x265dc5c*/ void CheckHandleValidity(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x26594b0*/ void IncrementWriteCount(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x265dd78*/ string GetRenderGraphResourceName(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x265de24*/ string GetRenderGraphResourceName(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x26596a8*/ bool IsRenderGraphResourceImported(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x265ded0*/ bool IsRenderGraphResourceShared(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x265df28*/ bool IsGraphicsResourceCreated(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x265dfd4*/ bool IsRendererListCreated(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle res);
                    /*0x265e038*/ bool IsRenderGraphResourceImported(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x265e0e0*/ int GetRenderGraphResourceTransientIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x265e188*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                    /*0x265e2cc*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                    /*0x265e4a0*/ void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x265e5d8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                    /*0x2659d50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, int transientPassIndex);
                    /*0x265e720*/ int GetTextureResourceCount();
                    /*0x265d020*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureResource GetTextureResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x2659998*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x2659a9c*/ void ForceTextureClear(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Color clearColor);
                    /*0x265e784*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                    /*0x265e854*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer);
                    /*0x265a110*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc, int transientPassIndex);
                    /*0x265a258*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferResourceDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x265e90c*/ int GetComputeBufferResourceCount();
                    /*0x265d1e8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferResource GetComputeBufferResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x265e974*/ void UpdateSharedResourceLastFrameIndex(int type, int index);
                    /*0x265daa8*/ void ManageSharedRenderGraphResources();
                    /*0x265ea10*/ void CreatePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, int type, int index);
                    /*0x265eb38*/ void CreateTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x265ed7c*/ void ReleasePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, int type, int index);
                    /*0x265eea8*/ void ReleaseTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x265e71c*/ void ValidateTextureDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x265e824*/ void ValidateRendererListDesc(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                    /*0x265e908*/ void ValidateComputeBufferDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc);
                    /*0x265f06c*/ void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, bool manualDispatch);
                    /*0x265f2e8*/ void Clear(bool onException);
                    /*0x265f5b8*/ void PurgeUnusedGraphicsResources();
                    /*0x265f640*/ void Cleanup();
                    /*0x265f774*/ void FlushLogs();
                    /*0x265f3b4*/ void LogResources();

                    class ResourceCallback : System.MulticastDelegate
                    {
                        /*0x265d770*/ ResourceCallback(object object, nint method);
                        /*0x265f7e4*/ void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                        /*0x265f7f8*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                        /*0x265f820*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class RenderGraphResourcesData
                    {
                        /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource> resourceArray;
                        /*0x18*/ int sharedResourcesCount;
                        /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool;
                        /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback createResourceCallback;
                        /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;

                        /*0x265d6f4*/ RenderGraphResourcesData();
                        /*0x265f534*/ void Clear(bool onException, int frameIndex);
                        /*0x265f6d8*/ void Cleanup();
                        /*0x265f620*/ void PurgeUnusedGraphicsResources(int frameIndex);
                        int AddNewRenderGraphResource<ResType>(ref ResType outRes, bool pooledResource);
                    }
                }

                struct RendererListHandle
                {
                    /*0x10*/ bool m_IsValid;
                    /*0x14*/ int <handle>k__BackingField;

                    static /*0x265d1e0*/ int op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle handle);
                    static /*0x265f83c*/ UnityEngine.Rendering.RendererUtils.RendererList op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList);
                    /*0x265e844*/ RendererListHandle(int handle);
                    /*0x265f82c*/ int get_handle();
                    /*0x265f834*/ void set_handle(int value);
                    /*0x265f8ec*/ bool IsValid();
                }

                struct RendererListResource
                {
                    /*0x10*/ UnityEngine.Rendering.RendererUtils.RendererListDesc desc;
                    /*0xd0*/ UnityEngine.Rendering.RendererUtils.RendererList rendererList;

                    /*0x265e828*/ RendererListResource(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                }

                enum RenderGraphResourceType
                {
                    Texture = 0,
                    ComputeBuffer = 1,
                    Count = 2,
                }

                struct ResourceHandle
                {
                    static uint kValidityMask = 4294901760;
                    static uint kIndexMask = 65535;
                    static /*0x0*/ uint s_CurrentValidBit;
                    static /*0x4*/ uint s_SharedResourceValidBit;
                    /*0x10*/ uint m_Value;
                    /*0x14*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType <type>k__BackingField;

                    static /*0x265f904*/ ResourceHandle();
                    static /*0x265d114*/ int op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    static /*0x265d994*/ void NewFrame(int executionIndex);
                    /*0x265bd94*/ ResourceHandle(int value, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, bool shared);
                    /*0x265dc54*/ int get_index();
                    /*0x265f8f4*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType get_type();
                    /*0x265f8fc*/ void set_type(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType value);
                    /*0x265bc58*/ int get_iType();
                    /*0x265bf34*/ bool IsValid();
                }

                class IRenderGraphResource
                {
                    /*0x10*/ bool imported;
                    /*0x11*/ bool shared;
                    /*0x12*/ bool sharedExplicitRelease;
                    /*0x13*/ bool requestFallBack;
                    /*0x14*/ uint writeCount;
                    /*0x18*/ int cachedHash;
                    /*0x1c*/ int transientPassIndex;
                    /*0x20*/ int sharedResourceLastFrameUsed;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool m_Pool;

                    /*0x265fa04*/ IRenderGraphResource();
                    /*0x265f954*/ void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                    /*0x265f96c*/ string GetName();
                    /*0x265f9ac*/ bool IsCreated();
                    /*0x265f9b4*/ void IncrementWriteCount();
                    /*0x265f9c4*/ bool NeedsFallBack();
                    /*0x265f9e4*/ void CreatePooledGraphicsResource();
                    /*0x265f9e8*/ void CreateGraphicsResource(string name);
                    /*0x265f9ec*/ void ReleasePooledGraphicsResource(int frameIndex);
                    /*0x265f9f0*/ void ReleaseGraphicsResource();
                    /*0x265f9f4*/ void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x265f9f8*/ void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x265f9fc*/ int GetSortIndex();
                }

                class RenderGraphResource<DescType, ResType> : UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource
                {
                    /*0x0*/ DescType desc;
                    /*0x0*/ ResType graphicsResource;

                    RenderGraphResource();
                    void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                    bool IsCreated();
                    void ReleaseGraphicsResource();
                }

                struct TextureHandle
                {
                    static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle s_NullHandle;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle fallBackResource;

                    static /*0x265fc68*/ TextureHandle();
                    static /*0x265fa0c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_nullHandle();
                    static /*0x265fa64*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    static /*0x265fb08*/ UnityEngine.Texture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    static /*0x265fb7c*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    static /*0x265fbf0*/ UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x265e234*/ TextureHandle(int handle, bool shared);
                    /*0x265d01c*/ bool IsValid();
                    /*0x265fc60*/ void SetFallBackResource(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                }

                enum TextureSizeMode
                {
                    Explicit = 0,
                    Scale = 1,
                    Functor = 2,
                }

                struct FastMemoryDesc
                {
                    /*0x10*/ bool inFastMemory;
                    /*0x14*/ UnityEngine.Rendering.FastMemoryFlags flags;
                    /*0x18*/ float residencyFraction;
                }

                struct TextureDesc
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode sizeMode;
                    /*0x14*/ int width;
                    /*0x18*/ int height;
                    /*0x1c*/ int slices;
                    /*0x20*/ UnityEngine.Vector2 scale;
                    /*0x28*/ UnityEngine.Rendering.ScaleFunc func;
                    /*0x30*/ UnityEngine.Rendering.DepthBits depthBufferBits;
                    /*0x34*/ UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat;
                    /*0x38*/ UnityEngine.FilterMode filterMode;
                    /*0x3c*/ UnityEngine.TextureWrapMode wrapMode;
                    /*0x40*/ UnityEngine.Rendering.TextureDimension dimension;
                    /*0x44*/ bool enableRandomWrite;
                    /*0x45*/ bool useMipMap;
                    /*0x46*/ bool autoGenerateMips;
                    /*0x47*/ bool isShadowMap;
                    /*0x48*/ int anisoLevel;
                    /*0x4c*/ float mipMapBias;
                    /*0x50*/ UnityEngine.Rendering.MSAASamples msaaSamples;
                    /*0x54*/ bool bindTextureMS;
                    /*0x55*/ bool useDynamicScale;
                    /*0x58*/ UnityEngine.RenderTextureMemoryless memoryless;
                    /*0x60*/ string name;
                    /*0x68*/ UnityEngine.Experimental.Rendering.RenderGraphModule.FastMemoryDesc fastMemoryDesc;
                    /*0x74*/ bool fallBackToBlackTexture;
                    /*0x75*/ bool clearBuffer;
                    /*0x78*/ UnityEngine.Color clearColor;

                    /*0x265fd30*/ TextureDesc(int width, int height, bool dynamicResolution, bool xrReady);
                    /*0x265fd68*/ TextureDesc(UnityEngine.Vector2 scale, bool dynamicResolution, bool xrReady);
                    /*0x265fdb0*/ TextureDesc(UnityEngine.Rendering.ScaleFunc func, bool dynamicResolution, bool xrReady);
                    /*0x265fdf8*/ TextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc input);
                    /*0x265fc6c*/ void InitDefaultValues(bool dynamicResolution, bool xrReady);
                    /*0x265fe0c*/ int GetHashCode();
                }

                class TextureResource : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc, UnityEngine.Rendering.RTHandle>
                {
                    static /*0x0*/ int m_TextureCreationIndex;

                    /*0x2660878*/ TextureResource();
                    /*0x265ff28*/ string GetName();
                    /*0x265ff94*/ void CreatePooledGraphicsResource();
                    /*0x2660114*/ void ReleasePooledGraphicsResource(int frameIndex);
                    /*0x2660284*/ void CreateGraphicsResource(string name);
                    /*0x2660640*/ void ReleaseGraphicsResource();
                    /*0x2660698*/ void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x26607a8*/ void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                }

                class TexturePool : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.Rendering.RTHandle>
                {
                    /*0x265d8a0*/ TexturePool();
                    /*0x26608c0*/ void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res);
                    /*0x26608d8*/ string GetResourceName(UnityEngine.Rendering.RTHandle res);
                    /*0x26608f8*/ long GetResourceSize(UnityEngine.Rendering.RTHandle res);
                    /*0x2660914*/ string GetResourceTypeName();
                    /*0x2660954*/ int GetSortIndex(UnityEngine.Rendering.RTHandle res);
                    /*0x266096c*/ void PurgeUnusedResources(int currentFrameIndex);
                }
            }
        }
    }

    namespace Rendering
    {
        class CameraSwitcher : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.Camera[] m_Cameras;
            /*0x20*/ int m_CurrentCameraIndex;
            /*0x28*/ UnityEngine.Camera m_OriginalCamera;
            /*0x30*/ UnityEngine.Vector3 m_OriginalCameraPosition;
            /*0x3c*/ UnityEngine.Quaternion m_OriginalCameraRotation;
            /*0x50*/ UnityEngine.Camera m_CurrentCamera;
            /*0x58*/ UnityEngine.GUIContent[] m_CameraNames;
            /*0x60*/ int[] m_CameraIndices;
            /*0x68*/ UnityEngine.Rendering.DebugUI.EnumField m_DebugEntry;
            /*0x70*/ int m_DebugEntryEnumIndex;

            /*0x2661a8c*/ CameraSwitcher();
            /*0x2660ec0*/ void OnEnable();
            /*0x2661798*/ void OnDisable();
            /*0x26613d8*/ int GetCameraCount();
            /*0x2661828*/ UnityEngine.Camera GetNextCamera();
            /*0x2661870*/ void SetCameraIndex(int index);
            /*0x2661a9c*/ int <OnEnable>b__10_0();
            /*0x2661aa4*/ void <OnEnable>b__10_1(int value);
            /*0x2661aa8*/ int <OnEnable>b__10_2();
            /*0x2661ab0*/ void <OnEnable>b__10_3(int value);
        }

        class FreeCamera : UnityEngine.MonoBehaviour
        {
            static float k_MouseSensitivityMultiplier = 0.009999999776482582;
            static /*0x0*/ string kMouseX;
            static /*0x8*/ string kMouseY;
            static /*0x10*/ string kRightStickX;
            static /*0x18*/ string kRightStickY;
            static /*0x20*/ string kVertical;
            static /*0x28*/ string kHorizontal;
            static /*0x30*/ string kYAxis;
            static /*0x38*/ string kSpeedAxis;
            /*0x18*/ float m_LookSpeedController;
            /*0x1c*/ float m_LookSpeedMouse;
            /*0x20*/ float m_MoveSpeed;
            /*0x24*/ float m_MoveSpeedIncrement;
            /*0x28*/ float m_Turbo;
            /*0x2c*/ float inputRotateAxisX;
            /*0x30*/ float inputRotateAxisY;
            /*0x34*/ float inputChangeSpeed;
            /*0x38*/ float inputVertical;
            /*0x3c*/ float inputHorizontal;
            /*0x40*/ float inputYAxis;
            /*0x44*/ bool leftShiftBoost;
            /*0x45*/ bool leftShift;
            /*0x46*/ bool fire1;

            static /*0x26620d0*/ FreeCamera();
            /*0x26620b4*/ FreeCamera();
            /*0x2661ab8*/ void OnEnable();
            /*0x2661abc*/ void RegisterInputs();
            /*0x2661ac0*/ void UpdateInputs();
            /*0x2661c8c*/ void Update();
        }

        class CommandBufferPool
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer> s_BufferPool;

            static /*0x26623dc*/ CommandBufferPool();
            static /*0x266221c*/ UnityEngine.Rendering.CommandBuffer Get();
            static /*0x26622c4*/ UnityEngine.Rendering.CommandBuffer Get(string name);
            static /*0x266235c*/ void Release(UnityEngine.Rendering.CommandBuffer buffer);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CommandBufferPool.<> <>9;

                static /*0x26624ec*/ <>c();
                /*0x2662550*/ <>c();
                /*0x2662558*/ void <.cctor>b__4_0(UnityEngine.Rendering.CommandBuffer x);
            }
        }

        enum ClearFlag
        {
            None = 0,
            Color = 1,
            Depth = 2,
            Stencil = 4,
            DepthStencil = 6,
            ColorStencil = 5,
            All = 7,
        }

        class ComponentSingleton<TType>
        {
            static /*0x0*/ TType s_Instance;

            static TType get_instance();
            static void Release();
        }

        class ConstantBuffer
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase> m_RegisteredConstantBuffers;

            static /*0x2662810*/ ConstantBuffer();
            static void PushGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            static void PushGlobal<CBType>(ref CBType data, int shaderId);
            static void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static void Push<CBType>(ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.Material mat, int shaderId);
            static void Push<CBType>(ref CBType data, UnityEngine.Material mat, int shaderId);
            static void UpdateData<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            static void UpdateData<CBType>(ref CBType data);
            static void SetGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            static void SetGlobal<CBType>(int shaderId);
            static void Set<CBType>(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            static void Set<CBType>(UnityEngine.ComputeShader cs, int shaderId);
            static void Set<CBType>(UnityEngine.Material mat, int shaderId);
            static /*0x2662570*/ void ReleaseAll();
            static /*0x2662738*/ void Register(UnityEngine.Rendering.ConstantBufferBase cb);
            /*0x2662808*/ ConstantBuffer();
        }

        class ConstantBufferBase
        {
            /*0x266289c*/ ConstantBufferBase();
            void Release();
        }

        class ConstantBuffer<CBType> : UnityEngine.Rendering.ConstantBufferBase
        {
            /*0x0*/ System.Collections.Generic.HashSet<int> m_GlobalBindings;
            /*0x0*/ CBType[] m_Data;
            /*0x0*/ UnityEngine.ComputeBuffer m_GPUConstantBuffer;

            ConstantBuffer();
            void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            void UpdateData(ref CBType data);
            void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            void SetGlobal(int shaderId);
            void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            void Set(UnityEngine.ComputeShader cs, int shaderId);
            void Set(UnityEngine.Material mat, int shaderId);
            void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            void PushGlobal(ref CBType data, int shaderId);
            void Release();
        }

        class ConstantBufferSingleton<CBType> : UnityEngine.Rendering.ConstantBuffer<CBType>
        {
            static /*0x0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> s_Instance;

            static UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance();
            static void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value);
            ConstantBufferSingleton();
            void Release();
        }

        class DisplayInfoAttribute : System.Attribute
        {
            /*0x10*/ string name;
            /*0x18*/ int order;

            /*0x26628a4*/ DisplayInfoAttribute();
        }

        class AdditionalPropertyAttribute : System.Attribute
        {
            /*0x26628ac*/ AdditionalPropertyAttribute();
        }

        enum CoreProfileId
        {
            BlitTextureInPotAtlas = 0,
        }

        class CoreUnsafeUtils
        {
            static void CopyTo<T>(System.Collections.Generic.List<T> list, void* dest, int count);
            static void CopyTo<T>(T[] list, void* dest, int count);
            static /*0x26628b4*/ void CalculateRadixParams(int radixBits, ref int bitStates);
            static /*0x266292c*/ int CalculateRadixSupportSize(int bitStates, int arrayLength);
            static /*0x2662938*/ void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, ref uint* bucketIndices, ref uint* bucketSizes, ref uint* bucketPrefix, ref uint* arrayOutput);
            static /*0x2662958*/ void MergeSort(uint* array, uint* support, int length);
            static /*0x2662a88*/ void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray);
            static /*0x2662b94*/ void MergeSort(Unity.Collections.NativeArray<uint> arr, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray);
            static /*0x2662cc0*/ void InsertionSort(uint* arr, int length);
            static /*0x2662d18*/ void InsertionSort(uint[] arr, int sortSize);
            static /*0x2662da8*/ void InsertionSort(Unity.Collections.NativeArray<uint> arr, int sortSize);
            static /*0x2662e74*/ void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length);
            static /*0x2662f9c*/ void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits);
            static /*0x26630c8*/ void RadixSort(Unity.Collections.NativeArray<uint> array, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray, int radixBits);
            static /*0x2663224*/ void QuickSort(uint[] arr, int left, int right);
            static void QuickSort<T>(int count, void* data);
            static void QuickSort<TValue, TKey, TGetter>(int count, void* data);
            static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right);
            static int IndexOf<T>(void* data, int count, T v);
            static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x2663298*/ int CompareHashes(int oldHashCount, UnityEngine.Hash128* oldHashes, int newHashCount, UnityEngine.Hash128* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static void CombineHashes<TValue, TGetter>(int count, void* hashes, UnityEngine.Hash128* outHash);
            static /*0x266333c*/ void CombineHashes(int count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash);
            static int Partition<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x266339c*/ bool HaveDuplicates(int[] arr);

            struct FixedBufferStringQueue
            {
                /*0x10*/ byte* m_ReadCursor;
                /*0x18*/ byte* m_WriteCursor;
                /*0x20*/ byte* m_BufferEnd;
                /*0x28*/ byte* m_BufferStart;
                /*0x30*/ int m_BufferLength;
                /*0x34*/ int <Count>k__BackingField;

                /*0x2663524*/ FixedBufferStringQueue(byte* ptr, int length);
                /*0x2663514*/ int get_Count();
                /*0x266351c*/ void set_Count(int value);
                /*0x2663564*/ bool TryPush(string v);
                /*0x2663610*/ bool TryPop(ref string v);
                /*0x2663548*/ void Clear();
            }

            interface IKeyGetter<TValue, TKey>
            {
                TKey Get(ref TValue v);
            }

            struct DefaultKeyGetter<T> : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<T, T>
            {
                T Get(ref T v);
            }

            struct UintKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<uint, uint>
            {
                /*0x2663678*/ uint Get(ref uint v);
            }
        }

        class DynamicArray<T>
        {
            /*0x0*/ T[] m_Array;
            /*0x0*/ int <size>k__BackingField;

            static T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            DynamicArray();
            DynamicArray(int size);
            int get_size();
            void set_size(int value);
            int get_capacity();
            void Clear();
            bool Contains(T item);
            int Add(ref T value);
            void AddRange(UnityEngine.Rendering.DynamicArray<T> array);
            bool Remove(T item);
            void RemoveAt(int index);
            void RemoveRange(int index, int count);
            int FindIndex(int startIndex, int count, System.Predicate<T> match);
            int IndexOf(T item, int index, int count);
            int IndexOf(T item, int index);
            int IndexOf(T item);
            void Resize(int newSize, bool keepContent);
            void Reserve(int newCapacity, bool keepContent);
            ref T get_Item(int index);
        }

        class DynamicArrayExtensions
        {
            static int Partition<T>(T[] data, int left, int right);
            static void QuickSort<T>(T[] data, int left, int right);
            static void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array);
        }

        class PerformDynamicRes : System.MulticastDelegate
        {
            /*0x2663680*/ PerformDynamicRes(object object, nint method);
            /*0x266373c*/ float Invoke();
            /*0x2663750*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2663770*/ float EndInvoke(System.IAsyncResult result);
        }

        enum DynamicResScalePolicyType
        {
            ReturnsPercentage = 0,
            ReturnsMinMaxLerpFactor = 1,
        }

        enum DynamicResScalerSlot
        {
            User = 0,
            System = 1,
            Count = 2,
        }

        class DynamicResolutionHandler
        {
            static int CameraDictionaryMaxcCapacity = 32;
            static /*0x0*/ UnityEngine.Rendering.DynamicResScalerSlot s_ActiveScalerSlot;
            static /*0x8*/ UnityEngine.Rendering.DynamicResolutionHandler.ScalerContainer[] s_ScalerContainers;
            static /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.DynamicResUpscaleFilter> s_CameraUpscaleFilters;
            static /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.DynamicResolutionHandler> s_CameraInstances;
            static /*0x20*/ UnityEngine.Rendering.DynamicResolutionHandler s_DefaultInstance;
            static /*0x28*/ int s_ActiveCameraId;
            static /*0x30*/ UnityEngine.Rendering.DynamicResolutionHandler s_ActiveInstance;
            static /*0x38*/ bool s_ActiveInstanceDirty;
            static /*0x3c*/ float s_GlobalHwFraction;
            static /*0x40*/ bool s_GlobalHwUpresActive;
            /*0x10*/ bool m_Enabled;
            /*0x11*/ bool m_UseMipBias;
            /*0x14*/ float m_MinScreenFraction;
            /*0x18*/ float m_MaxScreenFraction;
            /*0x1c*/ float m_CurrentFraction;
            /*0x20*/ bool m_ForcingRes;
            /*0x21*/ bool m_CurrentCameraRequest;
            /*0x24*/ float m_PrevFraction;
            /*0x28*/ bool m_ForceSoftwareFallback;
            /*0x29*/ bool m_RunUpscalerFilterOnFullResolution;
            /*0x2c*/ float m_PrevHWScaleWidth;
            /*0x30*/ float m_PrevHWScaleHeight;
            /*0x34*/ UnityEngine.Vector2Int m_LastScaledSize;
            /*0x3c*/ UnityEngine.Vector2Int cachedOriginalSize;
            /*0x44*/ UnityEngine.Rendering.DynamicResUpscaleFilter <filter>k__BackingField;
            /*0x48*/ UnityEngine.Vector2Int <finalViewport>k__BackingField;
            /*0x50*/ UnityEngine.Rendering.DynamicResolutionType type;
            /*0x54*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings m_CachedSettings;
            /*0x80*/ System.WeakReference m_OwnerCameraWeakRef;
            /*0x88*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule;

            static /*0x2664c74*/ DynamicResolutionHandler();
            static /*0x266398c*/ UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera);
            static /*0x2663e50*/ UnityEngine.Rendering.DynamicResolutionHandler get_instance();
            static /*0x2663eec*/ float DefaultDynamicResMethod();
            static /*0x2664194*/ void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x2664218*/ void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x26642a0*/ void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot);
            static /*0x26642fc*/ void ClearSelectedCamera();
            static /*0x2664364*/ void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter);
            static /*0x2664494*/ void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange);
            /*0x2663da8*/ DynamicResolutionHandler();
            /*0x2663798*/ void Reset();
            /*0x26637d4*/ UnityEngine.Rendering.DynamicResUpscaleFilter get_filter();
            /*0x26637dc*/ void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value);
            /*0x26637e4*/ UnityEngine.Vector2Int get_finalViewport();
            /*0x26637ec*/ void set_finalViewport(UnityEngine.Vector2Int value);
            /*0x26637f4*/ void set_runUpscalerFilterOnFullResolution(bool value);
            /*0x2663800*/ bool get_runUpscalerFilterOnFullResolution();
            /*0x2663820*/ bool FlushScalableBufferManagerState();
            /*0x2663e40*/ void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value);
            /*0x2663e48*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule();
            /*0x2663ef4*/ void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings);
            /*0x2664098*/ UnityEngine.Vector2 GetResolvedScale();
            /*0x2664104*/ float CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, bool forceApply);
            /*0x2664488*/ void SetCurrentCameraRequest(bool cameraRequest);
            /*0x2664674*/ void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange);
            /*0x26648d4*/ bool SoftwareDynamicResIsEnabled();
            /*0x266395c*/ bool HardwareDynamicResIsEnabled();
            /*0x2664930*/ bool RequestsHardwareDynamicResolution();
            /*0x2664950*/ bool DynamicResolutionEnabled();
            /*0x2664998*/ void ForceSoftwareFallback();
            /*0x26649a4*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size);
            /*0x26649f4*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size);
            /*0x2664a1c*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales);
            /*0x2664ba4*/ float GetCurrentScale();
            /*0x2664bc0*/ UnityEngine.Vector2Int GetLastScaledSize();
            /*0x2664bc8*/ float GetLowResMultiplier(float targetLowRes);

            struct ScalerContainer
            {
                /*0x10*/ UnityEngine.Rendering.DynamicResScalePolicyType type;
                /*0x18*/ UnityEngine.Rendering.PerformDynamicRes method;
            }

            enum UpsamplerScheduleType
            {
                BeforePost = 0,
                AfterPost = 1,
            }
        }

        enum DynamicResolutionType
        {
            Software = 0,
            Hardware = 1,
        }

        enum DynamicResUpscaleFilter
        {
            Bilinear = 0,
            CatmullRom = 1,
            Lanczos = 2,
            ContrastAdaptiveSharpen = 3,
            EdgeAdaptiveScalingUpres = 4,
            TAAU = 5,
        }

        struct GlobalDynamicResolutionSettings
        {
            /*0x10*/ bool enabled;
            /*0x11*/ bool useMipBias;
            /*0x12*/ bool enableDLSS;
            /*0x14*/ uint DLSSPerfQualitySetting;
            /*0x18*/ bool DLSSUseOptimalSettings;
            /*0x1c*/ float DLSSSharpness;
            /*0x20*/ float maxPercentage;
            /*0x24*/ float minPercentage;
            /*0x28*/ UnityEngine.Rendering.DynamicResolutionType dynResType;
            /*0x29*/ UnityEngine.Rendering.DynamicResUpscaleFilter upsampleFilter;
            /*0x2a*/ bool forceResolution;
            /*0x2c*/ float forcedPercentage;
            /*0x30*/ float lowResTransparencyMinimumThreshold;
            /*0x34*/ float rayTracingHalfResThreshold;

            static /*0x2663ea8*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault();
        }

        interface IAdditionalData
        {
        }

        interface IVirtualTexturingEnabledRenderPipeline
        {
            bool get_virtualTexturingEnabled();
        }

        struct ListBuffer<T>
        {
            /*0x0*/ T* m_BufferPtr;
            /*0x0*/ int m_Capacity;
            /*0x0*/ int* m_CountPtr;

            ListBuffer(T* bufferPtr, int* countPtr, int capacity);
            T* get_BufferPtr();
            int get_Count();
            int get_Capacity();
            ref T get_Item(ref int index);
            ref T GetUnchecked(ref int index);
            bool TryAdd(ref T value);
            void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
            bool TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other);
            bool TryCopyFrom(T* srcPtr, int count);
        }

        class ListBufferExtensions
        {
            static void QuickSort<T>(UnityEngine.Rendering.ListBuffer<T> self);
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <countAll>k__BackingField;

            ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, bool collectionCheck);
            int get_countAll();
            void set_countAll(int value);
            int get_countActive();
            int get_countInactive();
            T Get();
            UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T v);
            void Release(T element);

            struct PooledObject<T> : System.IDisposable
            {
                /*0x0*/ T m_ToReturn;
                /*0x0*/ UnityEngine.Rendering.ObjectPool<T> m_Pool;

                PooledObject(T value, UnityEngine.Rendering.ObjectPool<T> pool);
                void System.IDisposable.Dispose();
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static GenericPool();
            static T Get();
            static UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static void Release(T toRelease);
        }

        class UnsafeGenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static UnsafeGenericPool();
            static T Get();
            static UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static void Release(T toRelease);
        }

        class ListPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>> s_Pool;

            static ListPool();
            static System.Collections.Generic.List<T> Get();
            static UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(ref System.Collections.Generic.List<T> value);
            static void Release(System.Collections.Generic.List<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ListPool.<>c<T> <>9;

                static <>c();
                <>c();
                void <.cctor>b__4_0(System.Collections.Generic.List<T> l);
            }
        }

        class HashSetPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>> s_Pool;

            static HashSetPool();
            static System.Collections.Generic.HashSet<T> Get();
            static UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(ref System.Collections.Generic.HashSet<T> value);
            static void Release(System.Collections.Generic.HashSet<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.HashSetPool.<>c<T> <>9;

                static <>c();
                <>c();
                void <.cctor>b__4_0(System.Collections.Generic.HashSet<T> l);
            }
        }

        class DictionaryPool<TKey, TValue>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey, TValue>> s_Pool;

            static DictionaryPool();
            static System.Collections.Generic.Dictionary<TKey, TValue> Get();
            static UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey, TValue>> Get(ref System.Collections.Generic.Dictionary<TKey, TValue> value);
            static void Release(System.Collections.Generic.Dictionary<TKey, TValue> toRelease);

            class <>c<TKey, TValue>
            {
                static /*0x0*/ UnityEngine.Rendering.DictionaryPool.<>c<TKey, TValue> <>9;

                static <>c();
                <>c();
                void <.cctor>b__4_0(System.Collections.Generic.Dictionary<TKey, TValue> l);
            }
        }

        class ListChangedEventArgs<T> : System.EventArgs
        {
            /*0x0*/ int index;
            /*0x0*/ T item;

            ListChangedEventArgs(int index, T item);
        }

        class ListChangedEventHandler<T> : System.MulticastDelegate
        {
            ListChangedEventHandler(object object, nint method);
            void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e);
            System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class ObservableList<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.IList<T> m_List;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemAdded;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemRemoved;

            ObservableList();
            ObservableList(int capacity);
            ObservableList(System.Collections.Generic.IEnumerable<T> collection);
            void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            T get_Item(int index);
            void set_Item(int index, T value);
            int get_Count();
            bool get_IsReadOnly();
            void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, int index, T item);
            bool Contains(T item);
            int IndexOf(T item);
            void Add(T item);
            void Add(T[] items);
            void Insert(int index, T item);
            bool Remove(T item);
            int Remove(T[] items);
            void RemoveAt(int index);
            void Clear();
            void CopyTo(T[] array, int arrayIndex);
            System.Collections.Generic.IEnumerator<T> GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class SerializableEnum
        {
            /*0x10*/ string m_EnumValueAsString;
            /*0x18*/ System.Type m_EnumType;

            /*0x2664f44*/ SerializableEnum(System.Type enumType);
            /*0x2664e5c*/ System.Enum get_value();
            /*0x2664f14*/ void set_value(System.Enum value);
        }

        class SerializedDictionary<K, V> : UnityEngine.Rendering.SerializedDictionary<K, V, K, V>
        {
            SerializedDictionary();
            K SerializeKey(K key);
            V SerializeValue(V val);
            K DeserializeKey(K key);
            V DeserializeValue(V val);
        }

        class SerializedDictionary<K, V, SK, SV> : System.Collections.Generic.Dictionary<K, V>, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x0*/ System.Collections.Generic.List<SK> m_Keys;
            /*0x0*/ System.Collections.Generic.List<SV> m_Values;

            SerializedDictionary();
            SK SerializeKey(K key);
            SV SerializeValue(V value);
            K DeserializeKey(SK serializedKey);
            V DeserializeValue(SV serializedValue);
            void OnBeforeSerialize();
            void OnAfterDeserialize();
        }

        class XRGraphics
        {
            static /*0x2664fd8*/ float get_eyeTextureResolutionScale();
            static /*0x2665008*/ void set_eyeTextureResolutionScale(float value);
            static /*0x2665010*/ float get_renderViewportScale();
            static /*0x2665000*/ bool get_enabled();
            static /*0x2665038*/ bool get_isDeviceActive();
            static /*0x2665060*/ string get_loadedDeviceName();
            static /*0x26650b0*/ string[] get_supportedDevices();
            static /*0x2665104*/ UnityEngine.Rendering.XRGraphics.StereoRenderingMode get_stereoRenderingMode();
            static /*0x266512c*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x26651a4*/ int get_eyeTextureWidth();
            static /*0x26651cc*/ int get_eyeTextureHeight();
            /*0x26651f4*/ XRGraphics();

            enum StereoRenderingMode
            {
                MultiPass = 0,
                SinglePass = 1,
                SinglePassInstanced = 2,
                SinglePassMultiView = 3,
            }
        }

        enum DebugAction
        {
            EnableDebugMenu = 0,
            PreviousDebugPanel = 1,
            NextDebugPanel = 2,
            Action = 3,
            MakePersistent = 4,
            MoveVertical = 5,
            MoveHorizontal = 6,
            Multiplier = 7,
            ResetAll = 8,
            DebugActionCount = 9,
        }

        enum DebugActionRepeatMode
        {
            Never = 0,
            Delay = 1,
        }

        class DebugManager
        {
            static string kEnableDebugBtn1 = "Enable Debug Button 1";
            static string kEnableDebugBtn2 = "Enable Debug Button 2";
            static string kDebugPreviousBtn = "Debug Previous";
            static string kDebugNextBtn = "Debug Next";
            static string kValidateBtn = "Debug Validate";
            static string kPersistentBtn = "Debug Persistent";
            static string kDPadVertical = "Debug Vertical";
            static string kDPadHorizontal = "Debug Horizontal";
            static string kMultiplierBtn = "Debug Multiplier";
            static string kResetBtn = "Debug Reset";
            static string kEnableDebug = "Enable Debug";
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.DebugManager> s_Instance;
            /*0x10*/ UnityEngine.Rendering.DebugActionDesc[] m_DebugActions;
            /*0x18*/ UnityEngine.Rendering.DebugActionState[] m_DebugActionStates;
            /*0x20*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> m_ReadOnlyPanels;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Panel> m_Panels;
            /*0x30*/ System.Action<bool> onDisplayRuntimeUIChanged;
            /*0x38*/ System.Action onSetDirty;
            /*0x40*/ System.Action resetData;
            /*0x48*/ bool refreshEditorRequested;
            /*0x4c*/ System.Nullable<int> m_RequestedPanelIndex;
            /*0x58*/ UnityEngine.GameObject m_Root;
            /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas m_RootUICanvas;
            /*0x68*/ UnityEngine.GameObject m_PersistentRoot;
            /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas;
            /*0x78*/ bool m_EditorOpen;
            /*0x79*/ bool m_EnableRuntimeUI;

            static /*0x26680cc*/ DebugManager();
            static /*0x2661440*/ UnityEngine.Rendering.DebugManager get_instance();
            /*0x2666f2c*/ DebugManager();
            /*0x26651fc*/ void RegisterActions();
            /*0x2665cd0*/ void EnableInputActions();
            /*0x2665bf0*/ void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc);
            /*0x2665d24*/ void SampleAction(int actionIndex);
            /*0x2666094*/ void UpdateAction(int actionIndex);
            /*0x26662e8*/ void UpdateActions();
            /*0x2666340*/ float GetAction(UnityEngine.Rendering.DebugAction action);
            /*0x2666378*/ bool GetActionToggleDebugMenuWithTouch();
            /*0x26664c8*/ bool GetActionReleaseScrollTarget();
            /*0x2666554*/ void RegisterInputs();
            /*0x2666558*/ void UpdateReadOnlyCollection();
            /*0x26665d4*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels();
            /*0x26665f8*/ void add_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x26666a8*/ void remove_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x2666758*/ void add_onSetDirty(System.Action value);
            /*0x26667f4*/ void remove_onSetDirty(System.Action value);
            /*0x2666890*/ void add_resetData(System.Action value);
            /*0x266692c*/ void remove_resetData(System.Action value);
            /*0x26669c8*/ bool get_displayEditorUI();
            /*0x26669d0*/ void ToggleEditorUI(bool open);
            /*0x26669dc*/ bool get_enableRuntimeUI();
            /*0x26669e4*/ void set_enableRuntimeUI(bool value);
            /*0x266202c*/ bool get_displayRuntimeUI();
            /*0x2666a08*/ void set_displayRuntimeUI(bool value);
            /*0x2666c30*/ bool get_displayPersistentRuntimeUI();
            /*0x2666cb8*/ void set_displayPersistentRuntimeUI(bool value);
            /*0x26670e8*/ void RefreshEditor();
            /*0x26670f4*/ void Reset();
            /*0x2667120*/ void ReDrawOnScreenDebug();
            /*0x266714c*/ void RegisterData(UnityEngine.Rendering.IDebugData data);
            /*0x26671f8*/ void UnregisterData(UnityEngine.Rendering.IDebugData data);
            /*0x26672a4*/ int GetState();
            /*0x266740c*/ void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root);
            /*0x2667440*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
            /*0x2667460*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
            /*0x2666d38*/ void EnsurePersistentCanvas();
            /*0x26674f8*/ void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget);
            /*0x26675e0*/ void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x2667604*/ void RequestEditorWindowPanelIndex(int index);
            /*0x266766c*/ System.Nullable<int> GetRequestedEditorWindowPanelIndex();
            /*0x26614b8*/ UnityEngine.Rendering.DebugUI.Panel GetPanel(string displayName, bool createIfNull, int groupIndex, bool overrideIfExist);
            /*0x2667a24*/ void RemovePanel(string displayName);
            /*0x266772c*/ void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x2667bf0*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath);
            /*0x2667d54*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath, UnityEngine.Rendering.DebugUI.IContainer container);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.DebugManager.<> <>9;
                static /*0x8*/ System.Action<bool> <>9__60_0;
                static /*0x10*/ System.Action <>9__60_1;

                static /*0x26681d4*/ <>c();
                /*0x2668238*/ <>c();
                /*0x2668240*/ void <.ctor>b__60_0(bool <p0>);
                /*0x2668244*/ void <.ctor>b__60_1();
                /*0x2668248*/ UnityEngine.Rendering.DebugManager <.cctor>b__80_0();
            }
        }

        class DebugActionDesc
        {
            /*0x10*/ string axisTrigger;
            /*0x18*/ System.Collections.Generic.List<System.String[]> buttonTriggerList;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.KeyCode[]> keyTriggerList;
            /*0x28*/ UnityEngine.Rendering.DebugActionRepeatMode repeatMode;
            /*0x2c*/ float repeatDelay;

            /*0x2665b0c*/ DebugActionDesc();
        }

        class DebugActionState
        {
            /*0x10*/ UnityEngine.Rendering.DebugActionState.DebugActionKeyType m_Type;
            /*0x18*/ string[] m_PressedButtons;
            /*0x20*/ string m_PressedAxis;
            /*0x28*/ UnityEngine.KeyCode[] m_PressedKeys;
            /*0x30*/ bool[] m_TriggerPressedUp;
            /*0x38*/ float m_Timer;
            /*0x3c*/ bool <runningAction>k__BackingField;
            /*0x40*/ float <actionState>k__BackingField;

            /*0x2665cd4*/ DebugActionState();
            /*0x26682a0*/ bool get_runningAction();
            /*0x26682a8*/ void set_runningAction(bool value);
            /*0x26682b4*/ float get_actionState();
            /*0x26682bc*/ void set_actionState(float value);
            /*0x26682c4*/ void Trigger(int triggerCount, float state);
            /*0x2665f88*/ void TriggerWithButton(string[] buttons, float state);
            /*0x2666000*/ void TriggerWithAxis(string axis, float state);
            /*0x2666018*/ void TriggerWithKey(UnityEngine.KeyCode[] keys, float state);
            /*0x266837c*/ void Reset();
            /*0x26660f8*/ void Update(UnityEngine.Rendering.DebugActionDesc desc);

            enum DebugActionKeyType
            {
                Button = 0,
                Axis = 1,
                Key = 2,
            }
        }

        interface IDebugData
        {
            System.Action GetReset();
        }

        class DebugShapes
        {
            static /*0x0*/ UnityEngine.Rendering.DebugShapes s_Instance;
            /*0x10*/ UnityEngine.Mesh m_sphereMesh;
            /*0x18*/ UnityEngine.Mesh m_boxMesh;
            /*0x20*/ UnityEngine.Mesh m_coneMesh;
            /*0x28*/ UnityEngine.Mesh m_pyramidMesh;

            static /*0x266838c*/ UnityEngine.Rendering.DebugShapes get_instance();
            /*0x266840c*/ DebugShapes();
            /*0x2668414*/ void BuildSphere(ref UnityEngine.Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv);
            /*0x2668b10*/ void BuildBox(ref UnityEngine.Mesh outputMesh, float length, float width, float height);
            /*0x2669270*/ void BuildCone(ref UnityEngine.Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides);
            /*0x2669b98*/ void BuildPyramid(ref UnityEngine.Mesh outputMesh, float width, float height, float depth);
            /*0x2669e84*/ void BuildShapes();
            /*0x2669f88*/ void RebuildResources();
            /*0x266a078*/ UnityEngine.Mesh RequestSphereMesh();
            /*0x266a090*/ UnityEngine.Mesh RequestBoxMesh();
            /*0x266a0a8*/ UnityEngine.Mesh RequestConeMesh();
            /*0x266a0c0*/ UnityEngine.Mesh RequestPyramidMesh();
        }

        class DebugUI
        {
            /*0x266a0d8*/ DebugUI();

            class Container : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IContainer
            {
                /*0x48*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;

                /*0x266a398*/ Container();
                /*0x266a4ec*/ Container(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children);
                /*0x266a0e0*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x266a0e8*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x266a0f0*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x266a0f8*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x266a5e4*/ void GenerateQueryPath();
                /*0x266a958*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x266ac60*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x266acc8*/ int GetHashCode();
            }

            class Foldout : UnityEngine.Rendering.DebugUI.Container, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x50*/ bool opened;
                /*0x51*/ bool isHeader;
                /*0x58*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Foldout.ContextMenuItem> contextMenuItems;
                /*0x60*/ string[] <columnLabels>k__BackingField;
                /*0x68*/ string[] <columnTooltips>k__BackingField;

                /*0x266afac*/ Foldout();
                /*0x266afb0*/ Foldout(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, string[] columnLabels, string[] columnTooltips);
                /*0x266af84*/ bool get_isReadOnly();
                /*0x266af8c*/ string[] get_columnLabels();
                /*0x266af94*/ void set_columnLabels(string[] value);
                /*0x266af9c*/ string[] get_columnTooltips();
                /*0x266afa4*/ void set_columnTooltips(string[] value);
                /*0x266afd8*/ bool GetValue();
                /*0x266afe0*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x266b03c*/ void SetValue(object value);
                /*0x266b0b4*/ object ValidateValue(object value);
                /*0x266b0bc*/ void SetValue(bool value);

                struct ContextMenuItem
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ System.Action action;
                }
            }

            class HBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x266b0c8*/ HBox();
            }

            class VBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x266b118*/ VBox();
            }

            class Table : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x50*/ bool isReadOnly;
                /*0x58*/ bool[] m_Header;

                /*0x266b168*/ Table();
                /*0x266b1b8*/ void SetColumnVisibility(int index, bool visible);
                /*0x266b43c*/ bool GetColumnVisibility(int index);
                /*0x266b204*/ bool[] get_VisibleColumns();
                /*0x266b488*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x266b4a0*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);

                class Row : UnityEngine.Rendering.DebugUI.Foldout
                {
                    /*0x266b4b8*/ Row();
                }
            }

            enum Flags
            {
                None = 0,
                EditorOnly = 2,
                RuntimeOnly = 4,
                EditorForceUpdate = 8,
            }

            class Widget
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Panel m_Panel;
                /*0x18*/ UnityEngine.Rendering.DebugUI.IContainer m_Parent;
                /*0x20*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x28*/ string <displayName>k__BackingField;
                /*0x30*/ string <tooltip>k__BackingField;
                /*0x38*/ string <queryPath>k__BackingField;
                /*0x40*/ System.Func<bool> isHiddenCallback;

                /*0x266a4e4*/ Widget();
                /*0x266b508*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x266b510*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x266b518*/ UnityEngine.Rendering.DebugUI.IContainer get_parent();
                /*0x266b520*/ void set_parent(UnityEngine.Rendering.DebugUI.IContainer value);
                /*0x266b528*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x266b530*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x266b538*/ string get_displayName();
                /*0x266b540*/ void set_displayName(string value);
                /*0x266b548*/ string get_tooltip();
                /*0x266b550*/ void set_tooltip(string value);
                /*0x266b558*/ string get_queryPath();
                /*0x266b560*/ void set_queryPath(string value);
                /*0x266b568*/ bool get_isEditorOnly();
                /*0x266b574*/ bool get_isRuntimeOnly();
                /*0x266b580*/ bool get_isInactiveInEditor();
                /*0x266b5ac*/ bool get_isHidden();
                /*0x266a874*/ void GenerateQueryPath();
                /*0x266b5cc*/ int GetHashCode();
                /*0x266b5ec*/ void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value);

                struct NameAndTooltip
                {
                    /*0x10*/ string name;
                    /*0x18*/ string tooltip;
                }
            }

            interface IContainer
            {
                UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                string get_displayName();
                void set_displayName(string value);
                string get_queryPath();
            }

            interface IValueField
            {
                object GetValue();
                void SetValue(object value);
                object ValidateValue(object value);
            }

            class Button : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Action <action>k__BackingField;

                /*0x266b604*/ Button();
                /*0x266b5f4*/ System.Action get_action();
                /*0x266b5fc*/ void set_action(System.Action value);
            }

            class Value : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Func<object> <getter>k__BackingField;
                /*0x50*/ float refreshRate;

                /*0x266b61c*/ Value();
                /*0x266b60c*/ System.Func<object> get_getter();
                /*0x266b614*/ void set_getter(System.Func<object> value);
                /*0x266b67c*/ object GetValue();
            }

            class Field<T> : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x0*/ System.Func<T> <getter>k__BackingField;
                /*0x0*/ System.Action<T> <setter>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.Rendering.DebugUI.Field<T>, T> onValueChanged;

                Field();
                System.Func<T> get_getter();
                void set_getter(System.Func<T> value);
                System.Action<T> get_setter();
                void set_setter(System.Action<T> value);
                object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value);
                T ValidateValue(T value);
                object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                T GetValue();
                void SetValue(object value);
                void SetValue(T value);
            }

            class BoolField : UnityEngine.Rendering.DebugUI.Field<bool>
            {
                /*0x266b6a0*/ BoolField();
            }

            class HistoryBoolField : UnityEngine.Rendering.DebugUI.BoolField
            {
                /*0x60*/ System.Func<bool> <historyGetter>k__BackingField;

                /*0x266b750*/ HistoryBoolField();
                /*0x266b6e8*/ System.Func<bool> get_historyGetter();
                /*0x266b6f0*/ void set_historyGetter(System.Func<bool> value);
                /*0x266b6f8*/ int get_historyDepth();
                /*0x266b710*/ bool GetHistoryValue(int historyIndex);
            }

            class IntField : UnityEngine.Rendering.DebugUI.Field<int>
            {
                /*0x60*/ System.Func<int> min;
                /*0x68*/ System.Func<int> max;
                /*0x70*/ int incStep;
                /*0x74*/ int intStepMult;

                /*0x266b7b4*/ IntField();
                /*0x266b754*/ int ValidateValue(int value);
            }

            class UIntField : UnityEngine.Rendering.DebugUI.Field<uint>
            {
                /*0x60*/ System.Func<uint> min;
                /*0x68*/ System.Func<uint> max;
                /*0x70*/ uint incStep;
                /*0x74*/ uint intStepMult;

                /*0x266b868*/ UIntField();
                /*0x266b808*/ uint ValidateValue(uint value);
            }

            class FloatField : UnityEngine.Rendering.DebugUI.Field<float>
            {
                /*0x60*/ System.Func<float> min;
                /*0x68*/ System.Func<float> max;
                /*0x70*/ float incStep;
                /*0x74*/ float incStepMult;
                /*0x78*/ int decimals;

                /*0x266b91c*/ FloatField();
                /*0x266b8bc*/ float ValidateValue(float value);
            }

            class EnumUtility
            {
                static /*0x266b978*/ UnityEngine.GUIContent[] MakeEnumNames(System.Type enumType);
                static /*0x266bab4*/ int[] MakeEnumValues(System.Type enumType);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumUtility.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.FieldInfo, UnityEngine.GUIContent> <>9__0_0;

                    static /*0x266bbf0*/ <>c();
                    /*0x266bc54*/ <>c();
                    /*0x266bc5c*/ UnityEngine.GUIContent <MakeEnumNames>b__0_0(System.Reflection.FieldInfo fieldInfo);
                }
            }

            class EnumField : UnityEngine.Rendering.DebugUI.Field<int>
            {
                /*0x60*/ UnityEngine.GUIContent[] enumNames;
                /*0x68*/ int[] enumValues;
                /*0x70*/ int[] quickSeparators;
                /*0x78*/ int[] indexes;
                /*0x80*/ System.Func<int> <getIndex>k__BackingField;
                /*0x88*/ System.Action<int> <setIndex>k__BackingField;

                /*0x26613f8*/ EnumField();
                /*0x266be30*/ System.Func<int> get_getIndex();
                /*0x266be38*/ void set_getIndex(System.Func<int> value);
                /*0x266be40*/ System.Action<int> get_setIndex();
                /*0x266be48*/ void set_setIndex(System.Action<int> value);
                /*0x266be50*/ int get_currentIndex();
                /*0x266be74*/ void set_currentIndex(int value);
                /*0x266be98*/ void set_autoEnum(System.Type value);
                /*0x266bfa8*/ void InitQuickSeparators();
                /*0x266bed8*/ void InitIndexes();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.GUIContent, string> <>9__17_0;

                    static /*0x266c1b0*/ <>c();
                    /*0x266c214*/ <>c();
                    /*0x266c21c*/ string <InitQuickSeparators>b__17_0(UnityEngine.GUIContent x);
                }
            }

            class HistoryEnumField : UnityEngine.Rendering.DebugUI.EnumField
            {
                /*0x90*/ System.Func<int> <historyIndexGetter>k__BackingField;

                /*0x266c310*/ HistoryEnumField();
                /*0x266c2a8*/ System.Func<int> get_historyIndexGetter();
                /*0x266c2b0*/ void set_historyIndexGetter(System.Func<int> value);
                /*0x266c2b8*/ int get_historyDepth();
                /*0x266c2d0*/ int GetHistoryValue(int historyIndex);
            }

            class BitField : UnityEngine.Rendering.DebugUI.Field<System.Enum>
            {
                /*0x60*/ UnityEngine.GUIContent[] <enumNames>k__BackingField;
                /*0x68*/ int[] <enumValues>k__BackingField;
                /*0x70*/ System.Type m_EnumType;

                /*0x266c374*/ BitField();
                /*0x266c314*/ UnityEngine.GUIContent[] get_enumNames();
                /*0x266c31c*/ void set_enumNames(UnityEngine.GUIContent[] value);
                /*0x266c324*/ int[] get_enumValues();
                /*0x266c32c*/ void set_enumValues(int[] value);
                /*0x266c334*/ System.Type get_enumType();
                /*0x266c33c*/ void set_enumType(System.Type value);
            }

            class ColorField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Color>
            {
                /*0x60*/ bool hdr;
                /*0x61*/ bool showAlpha;
                /*0x62*/ bool showPicker;
                /*0x64*/ float incStep;
                /*0x68*/ float incStepMult;
                /*0x6c*/ int decimals;

                /*0x266c40c*/ ColorField();
                /*0x266c3bc*/ UnityEngine.Color ValidateValue(UnityEngine.Color value);
            }

            class Vector2Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector2>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x266c470*/ Vector2Field();
            }

            class Vector3Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector3>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x266c4cc*/ Vector3Field();
            }

            class Vector4Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector4>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x266c528*/ Vector4Field();
            }

            class MessageBox : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.MessageBox.Style style;

                /*0x266c584*/ MessageBox();

                enum Style
                {
                    Info = 0,
                    Warning = 1,
                    Error = 2,
                }
            }

            class Panel : UnityEngine.Rendering.DebugUI.IContainer, System.IComparable<UnityEngine.Rendering.DebugUI.Panel>
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x18*/ string <displayName>k__BackingField;
                /*0x20*/ int <groupIndex>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;
                /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> onSetDirty;

                /*0x266779c*/ Panel();
                /*0x266c58c*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x266c594*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x266c59c*/ string get_displayName();
                /*0x266c5a4*/ void set_displayName(string value);
                /*0x266c5ac*/ int get_groupIndex();
                /*0x266c5b4*/ void set_groupIndex(int value);
                /*0x266c5bc*/ string get_queryPath();
                /*0x266c5c4*/ bool get_isEditorOnly();
                /*0x266c5d0*/ bool get_isRuntimeOnly();
                /*0x266c5dc*/ bool get_isInactiveInEditor();
                /*0x266c608*/ bool get_editorForceUpdate();
                /*0x266c614*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x266c61c*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x2667974*/ void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x266767c*/ void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x266c624*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x266c67c*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x266a9c0*/ void SetDirty();
                /*0x266c6d4*/ int GetHashCode();
                /*0x266c990*/ int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Panel.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> <>9__29_0;

                    static /*0x266d9c4*/ <>c();
                    /*0x266da28*/ <>c();
                    /*0x266da30*/ void <.ctor>b__29_0(UnityEngine.Rendering.DebugUI.Panel <p0>);
                }
            }
        }

        class DebugUpdater : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ UnityEngine.Rendering.DebugUpdater s_Instance;
            /*0x18*/ UnityEngine.ScreenOrientation m_Orientation;
            /*0x1c*/ bool m_RuntimeUiWasVisibleLastFrame;

            static /*0x266da34*/ void RuntimeInit();
            static /*0x266da38*/ void SetEnabled(bool enabled);
            static /*0x266da44*/ void EnableRuntime();
            static /*0x266dbc8*/ void DisableRuntime();
            static /*0x266dcf8*/ void HandleInternalEventSystemComponents(bool uiEnabled);
            static /*0x266e430*/ System.Collections.IEnumerator RefreshRuntimeUINextFrame();
            /*0x266e4b8*/ DebugUpdater();
            /*0x266ddbc*/ void EnsureExactlyOneEventSystem();
            /*0x266e0f4*/ System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action);
            /*0x266e184*/ void CheckInputModuleExists();
            /*0x266e070*/ void CreateDebugEventSystem();
            /*0x266df90*/ void DestroyDebugEventSystem();
            /*0x266e2b0*/ void Update();

            class <DoAfterInputModuleUpdated>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.Action action;

                /*0x266e15c*/ <DoAfterInputModuleUpdated>d__9(int <>1__state);
                /*0x266e4c0*/ void System.IDisposable.Dispose();
                /*0x266e4c4*/ bool MoveNext();
                /*0x266e5a8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x266e5b0*/ void System.Collections.IEnumerator.Reset();
                /*0x266e5f0*/ object System.Collections.IEnumerator.get_Current();
            }

            class <RefreshRuntimeUINextFrame>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0x266e490*/ <RefreshRuntimeUINextFrame>d__14(int <>1__state);
                /*0x266e5f8*/ void System.IDisposable.Dispose();
                /*0x266e5fc*/ bool MoveNext();
                /*0x266e690*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x266e698*/ void System.Collections.IEnumerator.Reset();
                /*0x266e6d8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class MousePositionDebug
        {
            static /*0x0*/ UnityEngine.Rendering.MousePositionDebug s_Instance;

            static /*0x266e6e0*/ UnityEngine.Rendering.MousePositionDebug get_instance();
            /*0x266e760*/ MousePositionDebug();
            /*0x266e768*/ void Build();
            /*0x266e76c*/ void Cleanup();
            /*0x266e770*/ UnityEngine.Vector2 GetMousePosition(float ScreenHeight, bool sceneView);
            /*0x266e778*/ UnityEngine.Vector2 GetInputMousePosition();
            /*0x266e780*/ UnityEngine.Vector2 GetMouseClickPosition(float ScreenHeight);
        }

        class TProfilingSampler<TEnum> : UnityEngine.Rendering.ProfilingSampler
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<TEnum, UnityEngine.Rendering.TProfilingSampler<TEnum>> samples;

            static TProfilingSampler();
            TProfilingSampler(string name);
        }

        class ProfilingSampler
        {
            /*0x10*/ UnityEngine.Profiling.CustomSampler <sampler>k__BackingField;
            /*0x18*/ UnityEngine.Profiling.CustomSampler <inlineSampler>k__BackingField;
            /*0x20*/ string <name>k__BackingField;
            /*0x28*/ UnityEngine.Profiling.Recorder m_Recorder;
            /*0x30*/ UnityEngine.Profiling.Recorder m_InlineRecorder;

            static UnityEngine.Rendering.ProfilingSampler Get<TEnum>(TEnum marker);
            /*0x266e7c0*/ ProfilingSampler(string name);
            /*0x266ebbc*/ ProfilingSampler();
            /*0x266e8bc*/ void Begin(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x266e920*/ void End(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x266e984*/ bool IsValid();
            /*0x266e9a4*/ UnityEngine.Profiling.CustomSampler get_sampler();
            /*0x266e9ac*/ void set_sampler(UnityEngine.Profiling.CustomSampler value);
            /*0x266e9b4*/ UnityEngine.Profiling.CustomSampler get_inlineSampler();
            /*0x266e9bc*/ void set_inlineSampler(UnityEngine.Profiling.CustomSampler value);
            /*0x266e9c4*/ string get_name();
            /*0x266e9cc*/ void set_name(string value);
            /*0x266e9d4*/ void set_enableRecording(bool value);
            /*0x266ea18*/ float get_gpuElapsedTime();
            /*0x266ea64*/ int get_gpuSampleCount();
            /*0x266eaa4*/ float get_cpuElapsedTime();
            /*0x266eaf0*/ int get_cpuSampleCount();
            /*0x266eb30*/ float get_inlineCpuElapsedTime();
            /*0x266eb7c*/ int get_inlineCpuSampleCount();
        }

        struct ProfilingScope : System.IDisposable
        {
            /*0x266ebc4*/ ProfilingScope(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x266ebc8*/ void Dispose();
        }

        struct ProfilingSample : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_Cmd;
            /*0x18*/ string m_Name;
            /*0x20*/ bool m_Disposed;
            /*0x28*/ UnityEngine.Profiling.CustomSampler m_Sampler;

            /*0x266ebcc*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string name, UnityEngine.Profiling.CustomSampler sampler);
            /*0x266ec54*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object arg);
            /*0x266ec90*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object[] args);
            /*0x266eccc*/ void Dispose();
            /*0x266ecd4*/ void Dispose(bool disposing);
        }

        class CoreRPHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x266ed60*/ CoreRPHelpURLAttribute(string pageName, string packageName);
        }

        class DocumentationInfo
        {
            static string fallbackVersion = "12.1";
            static string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html";

            static /*0x266ee0c*/ string get_version();
            static /*0x266ed84*/ string GetPageLink(string packageName, string pageName);
            /*0x266ee4c*/ DocumentationInfo();
        }

        class DocumentationUtils
        {
            static string GetHelpURL<TEnum>(TEnum mask);
        }

        enum APVConstantBufferRegister
        {
            GlobalRegister = 5,
        }

        struct ShaderVariablesProbeVolumes
        {
            /*0x10*/ UnityEngine.Vector3 _PoolDim;
            /*0x1c*/ float _ViewBias;
            /*0x20*/ UnityEngine.Vector3 _MinCellPosition;
            /*0x2c*/ float _PVSamplingNoise;
            /*0x30*/ UnityEngine.Vector3 _CellIndicesDim;
            /*0x3c*/ float _CellInMeters;
            /*0x40*/ float _CellInMinBricks;
            /*0x44*/ float _MinBrickSize;
            /*0x48*/ int _IndexChunkSize;
            /*0x4c*/ float _NormalBias;
        }

        struct SphericalHarmonicsL1
        {
            static /*0x0*/ UnityEngine.Rendering.SphericalHarmonicsL1 zero;
            /*0x10*/ UnityEngine.Vector4 shAr;
            /*0x20*/ UnityEngine.Vector4 shAg;
            /*0x30*/ UnityEngine.Vector4 shAb;

            static /*0x266f248*/ SphericalHarmonicsL1();
            static /*0x266ee54*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x266ee7c*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x266eea4*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x266eec4*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x266eee8*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x266ef9c*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            /*0x266f054*/ bool Equals(object other);
            /*0x266f134*/ int GetHashCode();
        }

        class SphericalHarmonicsL2Utils
        {
            static /*0x266f2dc*/ void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L1_R, ref UnityEngine.Vector3 L1_G, ref UnityEngine.Vector3 L1_B);
            static /*0x266f3f0*/ void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L2_0, ref UnityEngine.Vector3 L2_1, ref UnityEngine.Vector3 L2_2, ref UnityEngine.Vector3 L2_3, ref UnityEngine.Vector3 L2_4);
            static /*0x266f5ac*/ void SetL0(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L0);
            static /*0x266f608*/ void SetL1R(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R);
            static /*0x266f664*/ void SetL1G(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_G);
            static /*0x266f6c0*/ void SetL1B(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_B);
            static /*0x266f71c*/ void SetL1(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B);
            static /*0x266f780*/ void SetCoefficient(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index, UnityEngine.Vector3 coefficient);
            static /*0x266f7e8*/ UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index);
            /*0x266f858*/ SphericalHarmonicsL2Utils();
        }

        class LensFlareCommonSRP
        {
            static /*0x0*/ UnityEngine.Rendering.LensFlareCommonSRP m_Instance;
            static /*0x8*/ object m_Padlock;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> m_Data;
            static /*0x18*/ int maxLensFlareWithOcclusion;
            static /*0x1c*/ int maxLensFlareWithOcclusionTemporalSample;
            static /*0x20*/ int mergeNeeded;
            static /*0x28*/ UnityEngine.Rendering.RTHandle occlusionRT;
            static /*0x30*/ int frameIdx;

            static /*0x26745d0*/ LensFlareCommonSRP();
            static /*0x266f868*/ void Initialize();
            static /*0x266fb34*/ void Dispose();
            static /*0x266fc58*/ UnityEngine.Rendering.LensFlareCommonSRP get_Instance();
            static /*0x2670028*/ float ShapeAttenuationPointLight();
            static /*0x2670030*/ float ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x2670050*/ float ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, float spotAngle, float innerSpotPercent01);
            static /*0x26700fc*/ float ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x2670124*/ float ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x26701c4*/ float ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, float lightWidth, UnityEngine.Camera cam);
            static /*0x26706e0*/ float ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x2670778*/ float ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x2670810*/ UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, UnityEngine.Vector2 positionOffset, bool autoRotate);
            static /*0x2670a1c*/ UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, float position, float globalCos0, float globalSin0);
            static /*0x2670a54*/ UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, bool isLocalLight, bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS);
            static /*0x2670b88*/ UnityEngine.Vector3 WorldToViewportLocal(bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS);
            static /*0x2670c04*/ UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS);
            static /*0x2670cf4*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Rendering.LensFlareCommonSRP lensFlares, UnityEngine.Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x2671df4*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Rendering.LensFlareCommonSRP lensFlares, UnityEngine.Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x2671bcc*/ UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance);
            static /*0x2674498*/ UnityEngine.Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView);
            static /*0x26744d8*/ UnityEngine.Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d);
            static /*0x267459c*/ UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, float d);
            static /*0x26746bc*/ float <ShapeAttenuationAreaTubeLight>g__Fpo|23_0(float d, float l);
            static /*0x26746fc*/ float <ShapeAttenuationAreaTubeLight>g__Fwt|23_1(float d, float l);
            static /*0x26703f8*/ float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|23_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
            static /*0x2674224*/ UnityEngine.Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|32_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, ref UnityEngine.Rendering.LensFlareCommonSRP.<> , ref UnityEngine.Rendering.LensFlareCommonSRP.<> );
            static /*0x26743c0*/ float <DoLensFlareDataDrivenCommon>g__RandomRange|32_1(float min, float max);
            /*0x266f860*/ LensFlareCommonSRP();
            /*0x266fde8*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> get_Data();
            /*0x266fe40*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareComponentSRP> GetData();
            /*0x266fe90*/ bool IsEmpty();
            /*0x266ff14*/ void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData);
            /*0x26743c8*/ void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data);

            struct <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareDataElementSRP element;
            }

            struct <>c__DisplayClass32_1
            {
                /*0x10*/ UnityEngine.Vector2 screenPos;
                /*0x18*/ float position;
                /*0x1c*/ float globalCos0;
                /*0x20*/ float globalSin0;
                /*0x24*/ float combinedScale;
                /*0x28*/ float usedAspectRatio;
            }
        }

        class LensFlareComponentSRP : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ float sCelestialAngularRadius;
            /*0x18*/ UnityEngine.Rendering.LensFlareDataSRP m_LensFlareData;
            /*0x20*/ float intensity;
            /*0x24*/ float maxAttenuationDistance;
            /*0x28*/ float maxAttenuationScale;
            /*0x30*/ UnityEngine.AnimationCurve distanceAttenuationCurve;
            /*0x38*/ UnityEngine.AnimationCurve scaleByDistanceCurve;
            /*0x40*/ bool attenuationByLightShape;
            /*0x48*/ UnityEngine.AnimationCurve radialScreenAttenuationCurve;
            /*0x50*/ bool useOcclusion;
            /*0x54*/ float occlusionRadius;
            /*0x58*/ uint sampleCount;
            /*0x5c*/ float occlusionOffset;
            /*0x60*/ float scale;
            /*0x64*/ bool allowOffScreen;

            static /*0x2674c18*/ LensFlareComponentSRP();
            /*0x2674904*/ LensFlareComponentSRP();
            /*0x2674714*/ UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData();
            /*0x267471c*/ void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value);
            /*0x2671d2c*/ float celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam);
            /*0x26747f8*/ void OnEnable();
            /*0x26748a4*/ void OnDisable();
            /*0x2674724*/ void OnValidate();
        }

        enum SRPLensFlareBlendMode
        {
            Additive = 0,
            Screen = 1,
            Premultiply = 2,
            Lerp = 3,
        }

        enum SRPLensFlareDistribution
        {
            Uniform = 0,
            Curve = 1,
            Random = 2,
        }

        enum SRPLensFlareType
        {
            Image = 0,
            Circle = 1,
            Polygon = 2,
        }

        class LensFlareDataElementSRP
        {
            /*0x10*/ bool visible;
            /*0x14*/ float position;
            /*0x18*/ UnityEngine.Vector2 positionOffset;
            /*0x20*/ float angularOffset;
            /*0x24*/ UnityEngine.Vector2 translationScale;
            /*0x2c*/ float m_LocalIntensity;
            /*0x30*/ UnityEngine.Texture lensFlareTexture;
            /*0x38*/ float uniformScale;
            /*0x3c*/ UnityEngine.Vector2 sizeXY;
            /*0x44*/ bool allowMultipleElement;
            /*0x48*/ int m_Count;
            /*0x4c*/ bool preserveAspectRatio;
            /*0x50*/ float rotation;
            /*0x54*/ UnityEngine.Color tint;
            /*0x64*/ UnityEngine.Rendering.SRPLensFlareBlendMode blendMode;
            /*0x68*/ bool autoRotate;
            /*0x6c*/ UnityEngine.Rendering.SRPLensFlareType flareType;
            /*0x70*/ bool modulateByLightColor;
            /*0x71*/ bool isFoldOpened;
            /*0x74*/ UnityEngine.Rendering.SRPLensFlareDistribution distribution;
            /*0x78*/ float lengthSpread;
            /*0x80*/ UnityEngine.AnimationCurve positionCurve;
            /*0x88*/ UnityEngine.AnimationCurve scaleCurve;
            /*0x90*/ int seed;
            /*0x98*/ UnityEngine.Gradient colorGradient;
            /*0xa0*/ float m_IntensityVariation;
            /*0xa4*/ UnityEngine.Vector2 positionVariation;
            /*0xac*/ float scaleVariation;
            /*0xb0*/ float rotationVariation;
            /*0xb4*/ bool enableRadialDistortion;
            /*0xb8*/ UnityEngine.Vector2 targetSizeDistortion;
            /*0xc0*/ UnityEngine.AnimationCurve distortionCurve;
            /*0xc8*/ bool distortionRelativeToCenter;
            /*0xcc*/ float m_FallOff;
            /*0xd0*/ float m_EdgeOffset;
            /*0xd4*/ int m_SideCount;
            /*0xd8*/ float m_SdfRoundness;
            /*0xdc*/ bool inverseSDF;
            /*0xe0*/ float uniformAngle;
            /*0xe8*/ UnityEngine.AnimationCurve uniformAngleCurve;

            /*0x2674c68*/ LensFlareDataElementSRP();
            /*0x2675364*/ float get_localIntensity();
            /*0x26752cc*/ void set_localIntensity(float value);
            /*0x267536c*/ int get_count();
            /*0x26752dc*/ void set_count(int value);
            /*0x2675374*/ float get_intensityVariation();
            /*0x26752ec*/ void set_intensityVariation(float value);
            /*0x267537c*/ float get_fallOff();
            /*0x26752fc*/ void set_fallOff(float value);
            /*0x2675384*/ float get_edgeOffset();
            /*0x2675318*/ void set_edgeOffset(float value);
            /*0x267538c*/ int get_sideCount();
            /*0x2675350*/ void set_sideCount(int value);
            /*0x2675394*/ float get_sdfRoundness();
            /*0x2675334*/ void set_sdfRoundness(float value);
        }

        class LensFlareDataSRP : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Rendering.LensFlareDataElementSRP[] elements;

            /*0x267539c*/ LensFlareDataSRP();
        }

        class RenderPipelineResources : UnityEngine.ScriptableObject
        {
            /*0x26753cc*/ RenderPipelineResources();
            /*0x26753b8*/ string get_packagePath();
            /*0x26753c0*/ string get_packagePath_Internal();
        }

        enum PackingRules
        {
            Exact = 0,
            Aggressive = 1,
        }

        enum FieldPacking
        {
            NoPacking = 0,
            R11G11B10 = 1,
            PackedFloat = 2,
            PackedUint = 3,
        }

        enum FieldPrecision
        {
            Half = 0,
            Real = 1,
            Default = 2,
        }

        class GenerateHLSL : System.Attribute
        {
            /*0x10*/ UnityEngine.Rendering.PackingRules packingRules;
            /*0x14*/ bool containsPackedFields;
            /*0x15*/ bool needAccessors;
            /*0x16*/ bool needSetters;
            /*0x17*/ bool needParamDebug;
            /*0x18*/ int paramDefinesStart;
            /*0x1c*/ bool omitStructDeclaration;
            /*0x1d*/ bool generateCBuffer;
            /*0x20*/ int constantRegister;
            /*0x28*/ string sourcePath;

            /*0x26753d4*/ GenerateHLSL(UnityEngine.Rendering.PackingRules rules, bool needAccessors, bool needSetters, bool needParamDebug, int paramDefinesStart, bool omitStructDeclaration, bool containsPackedFields, bool generateCBuffer, int constantRegister, string sourcePath);
        }

        class SurfaceDataAttributes : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ bool isDirection;
            /*0x19*/ bool sRGBDisplay;
            /*0x1c*/ UnityEngine.Rendering.FieldPrecision precision;
            /*0x20*/ bool checkIsNormalized;
            /*0x28*/ string preprocessor;

            /*0x2675468*/ SurfaceDataAttributes(string displayName, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
            /*0x2675554*/ SurfaceDataAttributes(string[] displayNames, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
        }

        class HLSLArray : System.Attribute
        {
            /*0x10*/ int arraySize;
            /*0x18*/ System.Type elementType;

            /*0x26755b4*/ HLSLArray(int arraySize, System.Type elementType);
        }

        class PackingAttribute : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ float[] range;
            /*0x20*/ UnityEngine.Rendering.FieldPacking packingScheme;
            /*0x24*/ int offsetInSource;
            /*0x28*/ int sizeInBits;
            /*0x2c*/ bool isDirection;
            /*0x2d*/ bool sRGBDisplay;
            /*0x2e*/ bool checkIsNormalized;
            /*0x30*/ string preprocessor;

            /*0x26755e4*/ PackingAttribute(string[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
            /*0x26756d0*/ PackingAttribute(string displayName, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
        }

        struct ShaderGenUInt4
        {
        }

        class Hammersley
        {
            static /*0x0*/ float[] k_Hammersley2dSeq16;
            static /*0x8*/ float[] k_Hammersley2dSeq32;
            static /*0x10*/ float[] k_Hammersley2dSeq64;
            static /*0x18*/ float[] k_Hammersley2dSeq256;
            static /*0x20*/ int s_hammersley2DSeq16Id;
            static /*0x24*/ int s_hammersley2DSeq32Id;
            static /*0x28*/ int s_hammersley2DSeq64Id;
            static /*0x2c*/ int s_hammersley2DSeq256Id;

            static /*0x2675cc4*/ Hammersley();
            static /*0x2675820*/ void Initialize();
            static /*0x2675b70*/ void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs);

            struct Hammersley2dSeq16
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq16.<hammersley2dSeq16> hammersley2dSeq16;

                struct <hammersley2dSeq16>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            struct Hammersley2dSeq32
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq32.<hammersley2dSeq32> hammersley2dSeq32;

                struct <hammersley2dSeq32>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            struct Hammersley2dSeq64
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq64.<hammersley2dSeq64> hammersley2dSeq64;

                struct <hammersley2dSeq64>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            struct Hammersley2dSeq256
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq256.<hammersley2dSeq256> hammersley2dSeq256;

                struct <hammersley2dSeq256>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }
        }

        class BufferedRTHandleSystem : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RTHandle[]> m_RTHandles;
            /*0x18*/ UnityEngine.Rendering.RTHandleSystem m_RTHandleSystem;
            /*0x20*/ bool m_DisposedValue;

            /*0x2676ba0*/ BufferedRTHandleSystem();
            /*0x2675ed4*/ int get_maxWidth();
            /*0x2675ef0*/ int get_maxHeight();
            /*0x2675f0c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x2675f34*/ UnityEngine.Rendering.RTHandle GetFrameRT(int bufferId, int frameIndex);
            /*0x2675fec*/ void AllocBuffer(int bufferId, System.Func<UnityEngine.Rendering.RTHandleSystem, int, UnityEngine.Rendering.RTHandle> allocator, int bufferCount);
            /*0x2676278*/ void ReleaseBuffer(int bufferId);
            /*0x2676378*/ void SwapAndSetReferenceSize(int width, int height);
            /*0x2676670*/ void ResetReferenceSize(int width, int height);
            /*0x267669c*/ int GetNumFramesAllocated(int bufferId);
            /*0x2676734*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
            /*0x26763b4*/ void Swap();
            /*0x2676968*/ void Dispose(bool disposing);
            /*0x2676b98*/ void Dispose();
            /*0x26769ac*/ void ReleaseAll();
        }

        enum DepthBits
        {
            None = 0,
            Depth8 = 8,
            Depth16 = 16,
            Depth24 = 24,
            Depth32 = 32,
        }

        enum MSAASamples
        {
            None = 1,
            MSAA2x = 2,
            MSAA4x = 4,
            MSAA8x = 8,
        }

        class PowerOfTwoTextureAtlas : UnityEngine.Rendering.Texture2DAtlas
        {
            static float k_MipmapFactorApprox = 1.3300000429153442;
            /*0x48*/ int m_MipPadding;
            /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> m_RequestedTextures;

            static /*0x26771e8*/ UnityEngine.Vector4 GetPayloadScaleOffset(ref UnityEngine.Vector2 textureSize, ref UnityEngine.Vector2 paddingSize, ref UnityEngine.Vector4 scaleOffset);
            static /*0x26788e4*/ long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x26789b0*/ int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x2676cf4*/ PowerOfTwoTextureAtlas(int size, int mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, string name, bool useMipMap);
            /*0x2677070*/ int get_mipPadding();
            /*0x2677078*/ int GetTexturePadding();
            /*0x26770a8*/ UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset);
            /*0x2677220*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType);
            /*0x2677684*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x26778b8*/ void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x26779bc*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x2677ac0*/ void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x2677bc4*/ void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, ref int width, ref int height);
            /*0x267717c*/ UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture);
            /*0x2677c00*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x2678030*/ void ResetRequestedTexture();
            /*0x2678080*/ bool ReserveSpace(UnityEngine.Texture texture);
            /*0x26780d8*/ bool ReserveSpace(UnityEngine.Texture texture, int width, int height);
            /*0x2678258*/ bool ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, int width, int height);
            /*0x2678134*/ bool ReserveSpace(int id, int width, int height);
            /*0x26783d0*/ bool RelayoutEntries();

            enum BlitType
            {
                Padding = 0,
                PaddingMultiply = 1,
                OctahedralPadding = 2,
                OctahedralPaddingMultiply = 3,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.PowerOfTwoTextureAtlas.<> <>9;
                static /*0x8*/ System.Comparison<System.ValueTuple<int, UnityEngine.Vector2Int>> <>9__23_0;

                static /*0x2678a90*/ <>c();
                /*0x2678af4*/ <>c();
                /*0x2678afc*/ int <RelayoutEntries>b__23_0(System.ValueTuple<int, UnityEngine.Vector2Int> c1, System.ValueTuple<int, UnityEngine.Vector2Int> c2);
            }
        }

        class RTHandle
        {
            /*0x10*/ UnityEngine.Rendering.RTHandleSystem m_Owner;
            /*0x18*/ UnityEngine.RenderTexture m_RT;
            /*0x20*/ UnityEngine.Texture m_ExternalTexture;
            /*0x28*/ UnityEngine.Rendering.RenderTargetIdentifier m_NameID;
            /*0x50*/ bool m_EnableMSAA;
            /*0x51*/ bool m_EnableRandomWrite;
            /*0x52*/ bool m_EnableHWDynamicScale;
            /*0x58*/ string m_Name;
            /*0x60*/ bool m_UseCustomHandleScales;
            /*0x64*/ UnityEngine.Rendering.RTHandleProperties m_CustomHandleProperties;
            /*0x94*/ UnityEngine.Vector2 <scaleFactor>k__BackingField;
            /*0xa0*/ UnityEngine.Rendering.ScaleFunc scaleFunc;
            /*0xa8*/ bool <useScaling>k__BackingField;
            /*0xac*/ UnityEngine.Vector2Int <referenceSize>k__BackingField;

            static /*0x26741f8*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x2678c34*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x2678cb4*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            /*0x2678c0c*/ RTHandle(UnityEngine.Rendering.RTHandleSystem owner);
            /*0x2678b40*/ void SetCustomHandleProperties(ref UnityEngine.Rendering.RTHandleProperties properties);
            /*0x2678b60*/ void ClearCustomHandleProperties();
            /*0x2678b68*/ UnityEngine.Vector2 get_scaleFactor();
            /*0x2678b70*/ void set_scaleFactor(UnityEngine.Vector2 value);
            /*0x2678b78*/ bool get_useScaling();
            /*0x2678b80*/ void set_useScaling(bool value);
            /*0x2678b8c*/ UnityEngine.Vector2Int get_referenceSize();
            /*0x2678b94*/ void set_referenceSize(UnityEngine.Vector2Int value);
            /*0x2678b9c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x2678bdc*/ UnityEngine.RenderTexture get_rt();
            /*0x2678be4*/ UnityEngine.Rendering.RenderTargetIdentifier get_nameID();
            /*0x2678bfc*/ string get_name();
            /*0x2678c04*/ bool get_isMSAAEnabled();
            /*0x2678cc0*/ void SetRenderTexture(UnityEngine.RenderTexture rt);
            /*0x2678d08*/ void SetTexture(UnityEngine.Texture tex);
            /*0x2678d50*/ void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex);
            /*0x2678d6c*/ int GetInstanceID();
            /*0x2678e28*/ void Release();
            /*0x2678f3c*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int refSize);
            /*0x2679140*/ UnityEngine.Vector2Int GetScaledSize();
            /*0x2679334*/ void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, bool copyContents);
            /*0x26793b8*/ void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags);
            /*0x26793c0*/ void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, bool copyContents);
        }

        class RTHandles
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandleSystem s_DefaultInstance;

            static /*0x267af3c*/ RTHandles();
            static /*0x267941c*/ int get_maxWidth();
            static /*0x2679480*/ int get_maxHeight();
            static /*0x26794e4*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            static /*0x266f9e8*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            static /*0x2679604*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            static /*0x2679ccc*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            static /*0x267a108*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            static /*0x267a384*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex);
            static /*0x267a4b8*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex);
            static /*0x267a5ec*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex);
            static /*0x267a6f4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, string name);
            static /*0x267a848*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            static /*0x267a8b8*/ void Initialize(int width, int height);
            static /*0x266fbe0*/ void Release(UnityEngine.Rendering.RTHandle rth);
            static /*0x267abdc*/ void SetHardwareDynamicResolutionState(bool hwDynamicResRequested);
            static /*0x267adb8*/ void SetReferenceSize(int width, int height);
            static /*0x267ae34*/ void ResetReferenceSize(int width, int height);
            static /*0x267aeb4*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
        }

        class ScaleFunc : System.MulticastDelegate
        {
            /*0x267afb0*/ ScaleFunc(object object, nint method);
            /*0x267b074*/ UnityEngine.Vector2Int Invoke(UnityEngine.Vector2Int size);
            /*0x267b088*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2Int size, System.AsyncCallback callback, object object);
            /*0x267b10c*/ UnityEngine.Vector2Int EndInvoke(System.IAsyncResult result);
        }

        struct RTHandleProperties
        {
            /*0x10*/ UnityEngine.Vector2Int previousViewportSize;
            /*0x18*/ UnityEngine.Vector2Int previousRenderTargetSize;
            /*0x20*/ UnityEngine.Vector2Int currentViewportSize;
            /*0x28*/ UnityEngine.Vector2Int currentRenderTargetSize;
            /*0x30*/ UnityEngine.Vector4 rtHandleScale;
        }

        class RTHandleSystem : System.IDisposable
        {
            /*0x10*/ bool m_HardwareDynamicResRequested;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.RTHandle> m_AutoSizedRTs;
            /*0x20*/ UnityEngine.Rendering.RTHandle[] m_AutoSizedRTsArray;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.RTHandle> m_ResizeOnDemandRTs;
            /*0x30*/ UnityEngine.Rendering.RTHandleProperties m_RTHandleProperties;
            /*0x60*/ int m_MaxWidths;
            /*0x64*/ int m_MaxHeights;

            static /*0x267bf18*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            /*0x2676c48*/ RTHandleSystem();
            /*0x267b134*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x2676b90*/ void Dispose();
            /*0x267a930*/ void Initialize(int width, int height);
            /*0x2676368*/ void Release(UnityEngine.Rendering.RTHandle rth);
            /*0x2678ee4*/ void Remove(UnityEngine.Rendering.RTHandle rth);
            /*0x2676690*/ void ResetReferenceSize(int width, int height);
            /*0x2676668*/ void SetReferenceSize(int width, int height);
            /*0x267b2fc*/ void SetReferenceSize(int width, int height, bool reset);
            /*0x2676760*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(ref UnityEngine.Vector2Int viewportSize);
            /*0x267ac44*/ void SetHardwareDynamicResolutionState(bool enableHWDynamicRes);
            /*0x267616c*/ void SwitchResizeMode(UnityEngine.Rendering.RTHandle rth, UnityEngine.Rendering.RTHandleSystem.ResizeMode mode);
            /*0x267b77c*/ void DemandResize(UnityEngine.Rendering.RTHandle rth);
            /*0x267b9d0*/ int GetMaxWidth();
            /*0x267b9d8*/ int GetMaxHeight();
            /*0x267b148*/ void Dispose(bool disposing);
            /*0x267b494*/ void Resize(int width, int height, bool sizeChanged);
            /*0x2679558*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            /*0x2679758*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            /*0x2679e14*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            /*0x267a244*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            /*0x267b9e0*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, string name);
            /*0x267a520*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture);
            /*0x267a3ec*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture);
            /*0x267a680*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture);
            /*0x267a798*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, string name);
            /*0x267bf88*/ string DumpRTInfo();

            enum ResizeMode
            {
                Auto = 0,
                OnDemand = 1,
            }
        }

        class AtlasAllocator
        {
            /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_Root;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;
            /*0x20*/ bool powerOfTwoPadding;
            /*0x28*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> m_NodePool;

            /*0x267c280*/ AtlasAllocator(int width, int height, bool potPadding);
            /*0x267c498*/ bool Allocate(ref UnityEngine.Vector4 result, int width, int height);
            /*0x267c700*/ void Reset();

            class AtlasNode
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_RightChild;
                /*0x18*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_BottomChild;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x267c48c*/ AtlasNode();
                /*0x267c518*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding);
                /*0x267c73c*/ void Release(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.AtlasAllocator.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_1;

                static /*0x267c814*/ <>c();
                /*0x267c878*/ <>c();
                /*0x267c880*/ void <.ctor>b__6_0(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
                /*0x267c884*/ void <.ctor>b__6_1(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
            }
        }

        class Texture2DAtlas
        {
            static int kGPUTexInvalid = 0;
            static int kGPUTexValidMip0 = 1;
            static int kGPUTexValidMipAll = 2;
            static /*0x0*/ UnityEngine.Vector4 fullScaleOffset;
            static /*0x10*/ int s_MaxMipLevelPadding;
            /*0x10*/ UnityEngine.Rendering.RTHandle m_AtlasTexture;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;
            /*0x20*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;
            /*0x24*/ bool m_UseMipMaps;
            /*0x25*/ bool m_IsAtlasTextureOwner;
            /*0x28*/ UnityEngine.Rendering.AtlasAllocator m_AtlasAllocator;
            /*0x30*/ System.Collections.Generic.Dictionary<int, System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector2Int>> m_AllocationCache;
            /*0x38*/ System.Collections.Generic.Dictionary<int, int> m_IsGPUTextureUpToDate;
            /*0x40*/ System.Collections.Generic.Dictionary<int, int> m_TextureHashes;

            static /*0x267e100*/ Texture2DAtlas();
            static /*0x267c888*/ int get_maxMipLevelPadding();
            /*0x2676dec*/ Texture2DAtlas(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, bool powerOfTwoPadding, string name, bool useMipMap);
            /*0x267c8e0*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x267c8e8*/ void Release();
            /*0x2678864*/ void ResetAllocator();
            /*0x267c95c*/ void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x26775b0*/ int GetTextureMipmapCount(int width, int height);
            /*0x2677788*/ bool Is2D(UnityEngine.Texture texture);
            /*0x267cb18*/ bool IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination);
            /*0x267cd5c*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType);
            /*0x2677848*/ void MarkGPUTextureValid(int instanceId, bool mipAreValid);
            /*0x267cff8*/ void MarkGPUTextureInvalid(int instanceId);
            /*0x267d054*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x267d1f4*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x267d204*/ void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, bool blitMips, int overrideInstanceID);
            /*0x2677e58*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x267d388*/ bool AllocateTextureWithoutBlit(UnityEngine.Texture texture, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x267d3e4*/ bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x267d570*/ int GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x267811c*/ int GetTextureID(UnityEngine.Texture texture);
            /*0x267828c*/ int GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x267d5f0*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x267d624*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x2678348*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int id);
            /*0x26782d4*/ UnityEngine.Vector2Int GetCachedTextureSize(int id);
            /*0x267d660*/ bool NeedsUpdate(UnityEngine.Texture texture, bool needMips);
            /*0x267d8c0*/ bool NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, bool needMips);
            /*0x267dcc0*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x267dd60*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Vector4 sourceScaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x267dee0*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x267df90*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleBias, int key, int width, int height);

            enum BlitType
            {
                Default = 0,
                CubeTo2DOctahedral = 1,
                SingleChannel = 2,
                CubeTo2DOctahedralSingleChannel = 3,
            }
        }

        class AtlasAllocatorDynamic
        {
            /*0x10*/ int m_Width;
            /*0x14*/ int m_Height;
            /*0x18*/ UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool m_Pool;
            /*0x20*/ short m_Root;
            /*0x28*/ System.Collections.Generic.Dictionary<int, short> m_NodeFromID;

            /*0x267e160*/ AtlasAllocatorDynamic(int width, int height, int capacityAllocations);
            /*0x267e430*/ bool Allocate(ref UnityEngine.Vector4 result, int key, int width, int height);
            /*0x267e8d8*/ void Release(int key);
            /*0x267ea58*/ void Release();
            /*0x267eb08*/ string DebugStringFromRoot(int depthMax);
            /*0x267eb78*/ void DebugStringFromNode(ref string res, short n, int depthCurrent, int depthMax);

            class AtlasNodePool
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNode[] m_Nodes;
                /*0x18*/ short m_Next;
                /*0x1a*/ short m_FreelistHead;

                /*0x267e280*/ AtlasNodePool(short capacity);
                /*0x267f148*/ void Dispose();
                /*0x267eafc*/ void Clear();
                /*0x267e2f0*/ short AtlasNodeCreate(short parent);
                /*0x267f1b8*/ void AtlasNodeFree(short index);
            }

            struct AtlasNode
            {
                /*0x10*/ short m_Self;
                /*0x12*/ short m_Parent;
                /*0x14*/ short m_LeftChild;
                /*0x16*/ short m_RightChild;
                /*0x18*/ short m_FreelistNext;
                /*0x1a*/ ushort m_Flags;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x267f158*/ AtlasNode(short self, short parent);
                /*0x267f13c*/ bool IsOccupied();
                /*0x267f1f4*/ void SetIsOccupied();
                /*0x267f204*/ void ClearIsOccupied();
                /*0x267f214*/ bool IsLeafNode();
                /*0x267e55c*/ short Allocate(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool, int width, int height);
                /*0x267f224*/ void ReleaseChildren(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool);
                /*0x267e9a4*/ void ReleaseAndMerge(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool);
                /*0x267f2cc*/ bool IsMergeNeeded(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool);

                enum AtlasNodeFlags
                {
                    IsOccupied = 1,
                }
            }
        }

        class Texture2DAtlasDynamic
        {
            /*0x10*/ UnityEngine.Rendering.RTHandle m_AtlasTexture;
            /*0x18*/ bool isAtlasTextureOwner;
            /*0x1c*/ int m_Width;
            /*0x20*/ int m_Height;
            /*0x24*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;
            /*0x28*/ UnityEngine.Rendering.AtlasAllocatorDynamic m_AtlasAllocator;
            /*0x30*/ System.Collections.Generic.Dictionary<int, UnityEngine.Vector4> m_AllocationCache;

            /*0x267f354*/ Texture2DAtlasDynamic(int width, int height, int capacity, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x267f4e0*/ Texture2DAtlasDynamic(int width, int height, int capacity, UnityEngine.Rendering.RTHandle atlasTexture);
            /*0x267f34c*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x267f5e0*/ void Release();
            /*0x267f654*/ void ResetAllocator();
            /*0x267f6b0*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x267f938*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int key);
            /*0x267f9a0*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleOffset, int key, int width, int height);
            /*0x267fab0*/ void ReleaseTextureSlot(int key);
        }

        class TextureXR
        {
            static /*0x0*/ int m_MaxViews;
            static /*0x8*/ UnityEngine.Texture m_BlackUIntTexture2DArray;
            static /*0x10*/ UnityEngine.Texture m_BlackUIntTexture;
            static /*0x18*/ UnityEngine.Rendering.RTHandle m_BlackUIntTexture2DArrayRTH;
            static /*0x20*/ UnityEngine.Rendering.RTHandle m_BlackUIntTextureRTH;
            static /*0x28*/ UnityEngine.Texture2DArray m_ClearTexture2DArray;
            static /*0x30*/ UnityEngine.Texture2D m_ClearTexture;
            static /*0x38*/ UnityEngine.Rendering.RTHandle m_ClearTexture2DArrayRTH;
            static /*0x40*/ UnityEngine.Rendering.RTHandle m_ClearTextureRTH;
            static /*0x48*/ UnityEngine.Texture2DArray m_MagentaTexture2DArray;
            static /*0x50*/ UnityEngine.Texture2D m_MagentaTexture;
            static /*0x58*/ UnityEngine.Rendering.RTHandle m_MagentaTexture2DArrayRTH;
            static /*0x60*/ UnityEngine.Rendering.RTHandle m_MagentaTextureRTH;
            static /*0x68*/ UnityEngine.Texture2D m_BlackTexture;
            static /*0x70*/ UnityEngine.Texture3D m_BlackTexture3D;
            static /*0x78*/ UnityEngine.Texture2DArray m_BlackTexture2DArray;
            static /*0x80*/ UnityEngine.Rendering.RTHandle m_BlackTexture2DArrayRTH;
            static /*0x88*/ UnityEngine.Rendering.RTHandle m_BlackTextureRTH;
            static /*0x90*/ UnityEngine.Rendering.RTHandle m_BlackTexture3DRTH;
            static /*0x98*/ UnityEngine.Texture2DArray m_WhiteTexture2DArray;
            static /*0xa0*/ UnityEngine.Rendering.RTHandle m_WhiteTexture2DArrayRTH;
            static /*0xa8*/ UnityEngine.Rendering.RTHandle m_WhiteTextureRTH;

            static /*0x2680cb4*/ TextureXR();
            static /*0x267fb18*/ void set_maxViews(int value);
            static /*0x267fb74*/ int get_slices();
            static /*0x267fbcc*/ bool get_useTexArray();
            static /*0x267fc2c*/ UnityEngine.Rendering.TextureDimension get_dimension();
            static /*0x267fc8c*/ UnityEngine.Rendering.RTHandle GetBlackUIntTexture();
            static /*0x267fd10*/ UnityEngine.Rendering.RTHandle GetClearTexture();
            static /*0x267fd94*/ UnityEngine.Rendering.RTHandle GetMagentaTexture();
            static /*0x267fe18*/ UnityEngine.Rendering.RTHandle GetBlackTexture();
            static /*0x267fe9c*/ UnityEngine.Rendering.RTHandle GetBlackTextureArray();
            static /*0x267fef4*/ UnityEngine.Rendering.RTHandle GetBlackTexture3D();
            static /*0x267ff4c*/ UnityEngine.Rendering.RTHandle GetWhiteTexture();
            static /*0x267ffd0*/ void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x2680a0c*/ UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, string name);
            static /*0x2680564*/ UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x26807b8*/ UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x2680bf4*/ UnityEngine.Texture3D CreateBlackTexture3D(string name);
        }

        class ArrayExtensions
        {
            static void ResizeArray<T>(ref Unity.Collections.NativeArray<T> array, int capacity);
            static /*0x2680d00*/ void ResizeArray(ref UnityEngine.Jobs.TransformAccessArray array, int capacity);
            static void ResizeArray<T>(ref T[] array, int capacity);
        }

        interface IBitArray
        {
            uint get_capacity();
            bool get_allFalse();
            bool get_allTrue();
            bool get_Item(uint index);
            void set_Item(uint index, bool value);
            string get_humanizedData();
            UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            UnityEngine.Rendering.IBitArray BitNot();
        }

        struct BitArray8 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ byte data;

            static /*0x2680ff0*/ UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a);
            static /*0x2680ffc*/ UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x2681008*/ UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x26811a4*/ bool op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x26811b4*/ bool op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            /*0x2680f38*/ BitArray8(byte initValue);
            /*0x2680f40*/ BitArray8(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x2680da0*/ uint get_capacity();
            /*0x2680da8*/ bool get_allFalse();
            /*0x2680db8*/ bool get_allTrue();
            /*0x2680dc8*/ string get_humanizedData();
            /*0x2680ec0*/ bool get_Item(uint index);
            /*0x2680ef0*/ void set_Item(uint index, bool value);
            /*0x2681014*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x26810ac*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x2681144*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x26811c4*/ bool Equals(object obj);
            /*0x268123c*/ int GetHashCode();
        }

        struct BitArray16 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ushort data;

            static /*0x2681524*/ UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a);
            static /*0x2681530*/ UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x268153c*/ UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x26816d8*/ bool op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x26816e8*/ bool op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            /*0x268146c*/ BitArray16(ushort initValue);
            /*0x2681474*/ BitArray16(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x268125c*/ uint get_capacity();
            /*0x2681264*/ bool get_allFalse();
            /*0x2681274*/ bool get_allTrue();
            /*0x2681284*/ string get_humanizedData();
            /*0x26813f4*/ bool get_Item(uint index);
            /*0x2681424*/ void set_Item(uint index, bool value);
            /*0x2681548*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x26815e0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x2681678*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x26816f8*/ bool Equals(object obj);
            /*0x2681770*/ int GetHashCode();
        }

        struct BitArray32 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ uint data;

            static /*0x2681c54*/ UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a);
            static /*0x2681bec*/ UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x2681b4c*/ UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x2681c5c*/ bool op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x2681c68*/ bool op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            /*0x26819fc*/ BitArray32(uint initValue);
            /*0x2681a04*/ BitArray32(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x2681790*/ uint get_capacity();
            /*0x2681798*/ bool get_allFalse();
            /*0x26817a8*/ bool get_allTrue();
            /*0x26817b8*/ string get_humanizedVersion();
            /*0x2681818*/ string get_humanizedData();
            /*0x2681988*/ bool get_Item(uint index);
            /*0x26819b4*/ void set_Item(uint index, bool value);
            /*0x2681ab4*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x2681b54*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x2681bf4*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x2681c74*/ bool Equals(object obj);
            /*0x2681cec*/ int GetHashCode();
        }

        struct BitArray64 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data;

            static /*0x2681fd0*/ UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a);
            static /*0x2681fd8*/ UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x2681fe0*/ UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x2682178*/ bool op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x2682184*/ bool op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            /*0x2681f18*/ BitArray64(ulong initValue);
            /*0x2681f20*/ BitArray64(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x2681d0c*/ uint get_capacity();
            /*0x2681d14*/ bool get_allFalse();
            /*0x2681d24*/ bool get_allTrue();
            /*0x2681d34*/ string get_humanizedData();
            /*0x2681ea4*/ bool get_Item(uint index);
            /*0x2681ed0*/ void set_Item(uint index, bool value);
            /*0x2681fe8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x2682080*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x2682118*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x2682190*/ bool Equals(object obj);
            /*0x2682208*/ int GetHashCode();
        }

        struct BitArray128 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;

            static /*0x26825f8*/ UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a);
            static /*0x2682604*/ UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x2682610*/ UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x26827c4*/ bool op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x26827dc*/ bool op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            /*0x2682520*/ BitArray128(ulong initValue1, ulong initValue2);
            /*0x2682528*/ BitArray128(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x2682228*/ uint get_capacity();
            /*0x2682230*/ bool get_allFalse();
            /*0x2682250*/ bool get_allTrue();
            /*0x2682274*/ string get_humanizedData();
            /*0x2682470*/ bool get_Item(uint index);
            /*0x26824b0*/ void set_Item(uint index, bool value);
            /*0x268261c*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x26826c0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x2682764*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x26827f4*/ bool Equals(object obj);
            /*0x26828b0*/ int GetHashCode();
        }

        struct BitArray256 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;
            /*0x20*/ ulong data3;
            /*0x28*/ ulong data4;

            static /*0x2682eac*/ UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a);
            static /*0x2682ec0*/ UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x2682ed8*/ UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x26830d4*/ bool op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x2683120*/ bool op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            /*0x2682da4*/ BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4);
            /*0x2682db0*/ BitArray256(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x26828f8*/ uint get_capacity();
            /*0x2682900*/ bool get_allFalse();
            /*0x2682930*/ bool get_allTrue();
            /*0x268296c*/ string get_humanizedData();
            /*0x2682c6c*/ bool get_Item(uint index);
            /*0x2682d08*/ void set_Item(uint index, bool value);
            /*0x2682ef0*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x2682fb0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x2683070*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x268316c*/ bool Equals(object obj);
            /*0x26832a4*/ int GetHashCode();
        }

        class BitArrayUtilities
        {
            static /*0x2680ed8*/ bool Get8(uint index, byte data);
            static /*0x268140c*/ bool Get16(uint index, ushort data);
            static /*0x26819a0*/ bool Get32(uint index, uint data);
            static /*0x2681ebc*/ bool Get64(uint index, ulong data);
            static /*0x2682494*/ bool Get128(uint index, ulong data1, ulong data2);
            static /*0x2682cbc*/ bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4);
            static /*0x2680f14*/ void Set8(uint index, ref byte data, bool value);
            static /*0x2681448*/ void Set16(uint index, ref ushort data, bool value);
            static /*0x26819d8*/ void Set32(uint index, ref uint data, bool value);
            static /*0x2681ef4*/ void Set64(uint index, ref ulong data, bool value);
            static /*0x26824e0*/ void Set128(uint index, ref ulong data1, ref ulong data2, bool value);
            static /*0x2682d2c*/ void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value);
        }

        class Blitter
        {
            static /*0x0*/ UnityEngine.Material s_Blit;
            static /*0x8*/ UnityEngine.Material s_BlitTexArray;
            static /*0x10*/ UnityEngine.Material s_BlitTexArraySingleSlice;
            static /*0x18*/ UnityEngine.Material s_BlitColorAndDepth;
            static /*0x20*/ UnityEngine.MaterialPropertyBlock s_PropertyBlock;
            static /*0x28*/ UnityEngine.Mesh s_TriangleMesh;
            static /*0x30*/ UnityEngine.Mesh s_QuadMesh;

            static /*0x2685da8*/ Blitter();
            static /*0x2683320*/ void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS);
            static /*0x2683b18*/ void Cleanup();
            static /*0x2683c44*/ UnityEngine.Material GetBlitMaterial(UnityEngine.Rendering.TextureDimension dimension, bool singleSlice);
            static /*0x2683cd8*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x2683e80*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x2684028*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x26842b4*/ void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x26843e4*/ void BlitColorAndDepth(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x268417c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x26845d0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x2684790*/ void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x26848ac*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int pass);
            static /*0x26849c0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x2684ab8*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, float mipLevel, bool bilinear);
            static /*0x2684c0c*/ void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear);
            static /*0x2684de8*/ void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x2685064*/ void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x26852e0*/ void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x26854f8*/ void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x2685710*/ void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x26858a8*/ void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x2685b18*/ void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x2683828*/ UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|8_0(float z);
            static /*0x26838dc*/ UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|8_1();
            static /*0x26839a4*/ UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|8_2(float z);
            static /*0x2683a54*/ UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|8_3();

            class BlitShaderIDs
            {
                static /*0x0*/ int _BlitTexture;
                static /*0x4*/ int _BlitCubeTexture;
                static /*0x8*/ int _BlitScaleBias;
                static /*0xc*/ int _BlitScaleBiasRt;
                static /*0x10*/ int _BlitMipLevel;
                static /*0x14*/ int _BlitTextureSize;
                static /*0x18*/ int _BlitPaddingSize;
                static /*0x1c*/ int _InputDepth;

                static /*0x2685e20*/ BlitShaderIDs();
            }
        }

        class CameraCaptureBridge
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Camera, System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>>> actionDict;
            static /*0x8*/ bool _enabled;

            static /*0x26863e8*/ CameraCaptureBridge();
            static /*0x2685fdc*/ bool get_enabled();
            static /*0x2686034*/ void set_enabled(bool value);
            static /*0x2686090*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera);
            static /*0x268619c*/ void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
            static /*0x26862ec*/ void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
        }

        class ColorUtils
        {
            static /*0x0*/ float s_LightMeterCalibrationConstant;
            static /*0x4*/ float s_LensAttenuation;

            static /*0x2686f98*/ ColorUtils();
            static /*0x2686474*/ float get_lensImperfectionExposureScale();
            static /*0x26864e4*/ float StandardIlluminantY(float x);
            static /*0x2686510*/ UnityEngine.Vector3 CIExyToLMS(float x, float y);
            static /*0x26865a0*/ UnityEngine.Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint);
            static /*0x26866fc*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inMidtones, ref UnityEngine.Vector4 inHighlights);
            static /*0x2686908*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareLiftGammaGain(ref UnityEngine.Vector4 inLift, ref UnityEngine.Vector4 inGamma, ref UnityEngine.Vector4 inGain);
            static /*0x2686bb8*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4> PrepareSplitToning(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inHighlights, float balance);
            static /*0x2686b80*/ float Luminance(ref UnityEngine.Color color);
            static /*0x2686c44*/ float ComputeEV100(float aperture, float shutterSpeed, float ISO);
            static /*0x2686cc0*/ float ConvertEV100ToExposure(float EV100);
            static /*0x2686d34*/ float ConvertExposureToEV100(float exposure);
            static /*0x2686de8*/ float ComputeEV100FromAvgLuminance(float avgLuminance);
            static /*0x2686ea8*/ float ComputeISO(float aperture, float shutterSpeed, float targetEV100);
            static /*0x2686ee4*/ uint ToHex(UnityEngine.Color c);
            static /*0x2686f4c*/ UnityEngine.Color ToRGBA(uint hex);
        }

        class CoreMatrixUtils
        {
            static /*0x2686fe8*/ void MatrixTimesTranslation(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x2687044*/ void TranslationTimesMatrix(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x26870cc*/ UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs);
            static /*0x2687174*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x268720c*/ UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x26872e0*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, bool centered);
            static /*0x26873bc*/ UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, bool orthoCentered);
        }

        class CoreUtils
        {
            static string obsoletePriorityMessage = "Use CoreUtils.Priorities instead";
            static int editMenuPriority1 = 320;
            static int editMenuPriority2 = 331;
            static int editMenuPriority3 = 342;
            static int editMenuPriority4 = 353;
            static int assetCreateMenuPriority1 = 230;
            static int assetCreateMenuPriority2 = 241;
            static int assetCreateMenuPriority3 = 300;
            static int gameObjectMenuPriority = 10;
            static /*0x0*/ UnityEngine.Vector3[] lookAtList;
            static /*0x8*/ UnityEngine.Vector3[] upVectorList;
            static /*0x10*/ UnityEngine.Cubemap m_BlackCubeTexture;
            static /*0x18*/ UnityEngine.Cubemap m_MagentaCubeTexture;
            static /*0x20*/ UnityEngine.CubemapArray m_MagentaCubeTextureArray;
            static /*0x28*/ UnityEngine.Cubemap m_WhiteCubeTexture;
            static /*0x30*/ UnityEngine.RenderTexture m_EmptyUAV;
            static /*0x38*/ UnityEngine.Texture3D m_BlackVolumeTexture;
            static /*0x40*/ System.Collections.Generic.IEnumerable<System.Type> m_AssemblyTypes;

            static /*0x268af80*/ CoreUtils();
            static /*0x2687468*/ UnityEngine.Cubemap get_blackCubeTexture();
            static /*0x26875e0*/ UnityEngine.Cubemap get_magentaCubeTexture();
            static /*0x2687758*/ UnityEngine.CubemapArray get_magentaCubeTextureArray();
            static /*0x2687928*/ UnityEngine.Cubemap get_whiteCubeTexture();
            static /*0x2687aa0*/ UnityEngine.RenderTexture get_emptyUAV();
            static /*0x2687bd0*/ UnityEngine.Texture3D get_blackVolumeTexture();
            static /*0x2687d4c*/ void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x2687d70*/ int FixupDepthSlice(int depthSlice, UnityEngine.Rendering.RTHandle buffer);
            static /*0x2687dac*/ int FixupDepthSlice(int depthSlice, UnityEngine.CubemapFace cubemapFace);
            static /*0x2687dc4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2687ed4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2687fa4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x26881d8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2688098*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x26882d8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer);
            static /*0x2688474*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x2688384*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x268852c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x2688620*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x26886e0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x268881c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x2688928*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x2688a30*/ void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x2688b64*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x26846ec*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2688c90*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2688f30*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2688d8c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x2689038*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer);
            static /*0x268910c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x26891e4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x2688ad4*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target);
            static /*0x26892ec*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.RenderTextureFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x2689634*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x268972c*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes);
            static /*0x26893e4*/ string GetRenderTargetAutoName(int width, int height, int depth, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes);
            static /*0x2689830*/ string GetTextureAutoName(int width, int height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x2689cd0*/ string GetTextureAutoName(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x2689918*/ string GetTextureAutoName(int width, int height, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x2689db8*/ void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips);
            static /*0x2689f6c*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x268a028*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x268a104*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x268a20c*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x268a2f0*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x268a3b8*/ UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color);
            static /*0x268a434*/ UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color);
            static /*0x268a4b0*/ UnityEngine.Material CreateEngineMaterial(string shaderPath);
            static /*0x2683730*/ UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader);
            static bool HasFlag<T>(T mask, T flag);
            static void Swap<T>(ref T a, ref T b);
            static /*0x268a5ec*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, string keyword, bool state);
            static /*0x268a60c*/ void SetKeyword(UnityEngine.Material material, string keyword, bool state);
            static /*0x268a62c*/ void SetKeyword(UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x2683bbc*/ void Destroy(UnityEngine.Object obj);
            static /*0x268a64c*/ System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes();
            static System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
            static /*0x268a7dc*/ void SafeRelease(UnityEngine.ComputeBuffer buffer);
            static /*0x268a7ec*/ UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
            static /*0x268ab90*/ bool ArePostProcessesEnabled(UnityEngine.Camera camera);
            static /*0x268ab98*/ bool AreAnimatedMaterialsEnabled(UnityEngine.Camera camera);
            static /*0x268aba0*/ bool IsSceneLightingDisabled(UnityEngine.Camera camera);
            static /*0x268aba8*/ bool IsLightOverlapDebugEnabled(UnityEngine.Camera camera);
            static /*0x268abb0*/ bool IsSceneViewFogEnabled(UnityEngine.Camera camera);
            static /*0x268abb8*/ bool IsSceneFilteringEnabled();
            static /*0x268abc0*/ bool IsSceneViewPrefabStageContextHidden();
            static /*0x268abc8*/ void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Experimental.Rendering.RendererList rendererList);
            static /*0x268ad14*/ void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList);
            static /*0x268ada4*/ int GetTextureHash(UnityEngine.Texture texture);
            static /*0x268af14*/ int PreviousPowerOfTwo(int size);
            static T GetLastEnumValue<T>();
            static /*0x268af40*/ string GetCorePath();

            class Sections
            {
                static int section1 = 10000;
                static int section2 = 20000;
                static int section3 = 30000;
                static int section4 = 40000;
                static int section5 = 50000;
                static int section6 = 60000;
                static int section7 = 70000;
                static int section8 = 80000;
            }

            class Priorities
            {
                static int assetsCreateShaderMenuPriority = 83;
                static int assetsCreateRenderingMenuPriority = 308;
                static int editMenuPriority = 320;
                static int gameObjectMenuPriority = 10;
                static int srpLensFlareMenuPriority = 303;
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>9__81_0;

                static /*0x268b108*/ <>c();
                /*0x268b16c*/ <>c();
                /*0x268b174*/ System.Collections.Generic.IEnumerable<System.Type> <GetAllAssemblyTypes>b__81_0(System.Reflection.Assembly t);
            }

            class <>c__82<T>
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<>c__82<T> <>9;
                static /*0x0*/ System.Func<System.Type, bool> <>9__82_0;

                static <>c__82();
                <>c__82();
                bool <GetAllTypesDerivedFrom>b__82_0(System.Type t);
            }
        }

        class DelegateUtility
        {
            static /*0x268b258*/ System.Delegate Cast(System.Delegate source, System.Type type);
        }

        class FSRUtils
        {
            static float kMaxSharpnessStops = 2.5;
            static float kDefaultSharpnessStops = 0.20000000298023224;
            static float kDefaultSharpnessLinear = 0.9200000166893005;

            static /*0x268b3d4*/ void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x268b548*/ void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessStops);
            static /*0x268b618*/ void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessLinear);
            static /*0x268b62c*/ bool IsSupported();

            class ShaderConstants
            {
                static /*0x0*/ int _FsrEasuConstants0;
                static /*0x4*/ int _FsrEasuConstants1;
                static /*0x8*/ int _FsrEasuConstants2;
                static /*0xc*/ int _FsrEasuConstants3;
                static /*0x10*/ int _FsrRcasConstants;

                static /*0x268b648*/ ShaderConstants();
            }
        }

        class HableCurve
        {
            /*0x10*/ float <whitePoint>k__BackingField;
            /*0x14*/ float <inverseWhitePoint>k__BackingField;
            /*0x18*/ float <x0>k__BackingField;
            /*0x1c*/ float <x1>k__BackingField;
            /*0x20*/ UnityEngine.Rendering.HableCurve.Segment[] segments;
            /*0x28*/ UnityEngine.Rendering.HableCurve.Uniforms uniforms;

            /*0x268b7b0*/ HableCurve();
            /*0x268b770*/ float get_whitePoint();
            /*0x268b778*/ void set_whitePoint(float value);
            /*0x268b780*/ float get_inverseWhitePoint();
            /*0x268b788*/ void set_inverseWhitePoint(float value);
            /*0x268b790*/ float get_x0();
            /*0x268b798*/ void set_x0(float value);
            /*0x268b7a0*/ float get_x1();
            /*0x268b7a8*/ void set_x1(float value);
            /*0x268b900*/ float Eval(float x);
            /*0x268ba0c*/ void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
            /*0x268bb24*/ void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams);
            /*0x268be44*/ void SolveAB(ref float lnA, ref float B, float x0, float y0, float m);
            /*0x268bde0*/ void AsSlopeIntercept(ref float m, ref float b, float x0, float x1, float y0, float y1);
            /*0x268be0c*/ float EvalDerivativeLinearGamma(float m, float b, float g, float x);

            class Segment
            {
                /*0x10*/ float offsetX;
                /*0x14*/ float offsetY;
                /*0x18*/ float scaleX;
                /*0x1c*/ float scaleY;
                /*0x20*/ float lnA;
                /*0x24*/ float B;

                /*0x268b8d0*/ Segment();
                /*0x268b9b0*/ float Eval(float x);
            }

            struct DirectParams
            {
                /*0x10*/ float x0;
                /*0x14*/ float y0;
                /*0x18*/ float x1;
                /*0x1c*/ float y1;
                /*0x20*/ float W;
                /*0x24*/ float overshootX;
                /*0x28*/ float overshootY;
                /*0x2c*/ float gamma;
            }

            class Uniforms
            {
                /*0x10*/ UnityEngine.Rendering.HableCurve parent;

                /*0x268b8d8*/ Uniforms(UnityEngine.Rendering.HableCurve parent);
                /*0x268be94*/ UnityEngine.Vector4 get_curve();
                /*0x268beb8*/ UnityEngine.Vector4 get_toeSegmentA();
                /*0x268bef4*/ UnityEngine.Vector4 get_toeSegmentB();
                /*0x268bf34*/ UnityEngine.Vector4 get_midSegmentA();
                /*0x268bf74*/ UnityEngine.Vector4 get_midSegmentB();
                /*0x268bfb8*/ UnityEngine.Vector4 get_shoSegmentA();
                /*0x268bff8*/ UnityEngine.Vector4 get_shoSegmentB();
            }
        }

        class HaltonSequence
        {
            static /*0x268c03c*/ float Get(int index, int radix);
        }

        enum MaterialQuality
        {
            Low = 1,
            Medium = 2,
            High = 4,
        }

        class MaterialQualityUtilities
        {
            static /*0x0*/ string[] KeywordNames;
            static /*0x8*/ string[] EnumNames;
            static /*0x10*/ UnityEngine.Rendering.ShaderKeyword[] Keywords;

            static /*0x268c4a4*/ MaterialQualityUtilities();
            static /*0x268c080*/ UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels);
            static /*0x268c10c*/ UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel);
            static /*0x268c2e8*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level);
            static /*0x268c3c0*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd);
            static /*0x268c240*/ int ToFirstIndex(UnityEngine.Rendering.MaterialQuality level);
            static /*0x268c2dc*/ UnityEngine.Rendering.MaterialQuality FromIndex(int index);
        }

        class MeshGizmo : System.IDisposable
        {
            static /*0x0*/ int vertexCountPerCube;
            /*0x10*/ UnityEngine.Mesh mesh;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Vector3> vertices;
            /*0x20*/ System.Collections.Generic.List<int> indices;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Color> colors;
            /*0x30*/ UnityEngine.Material wireMaterial;
            /*0x38*/ UnityEngine.Material dottedWireMaterial;
            /*0x40*/ UnityEngine.Material solidMaterial;

            static /*0x268d0ec*/ MeshGizmo();
            /*0x268c778*/ MeshGizmo(int capacity);
            /*0x268c8e8*/ void Clear();
            /*0x268c978*/ void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color);
            /*0x268cea4*/ void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x268d054*/ void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x268d094*/ void Dispose();
            /*0x268cb98*/ void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, ref UnityEngine.Rendering.MeshGizmo.<> );

            struct <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Rendering.MeshGizmo <>4__this;
                /*0x18*/ UnityEngine.Color color;
            }
        }

        class ReloadAttribute : System.Attribute
        {
            /*0x268d138*/ ReloadAttribute(string[] paths, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x268d140*/ ReloadAttribute(string path, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x268d1e0*/ ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package);

            enum Package
            {
                Builtin = 0,
                Root = 1,
            }
        }

        class ReloadGroupAttribute : System.Attribute
        {
            /*0x268d1e8*/ ReloadGroupAttribute();
        }

        class TextureCurve : System.IDisposable
        {
            static int k_Precision = 128;
            static float k_Step = 0.0078125;
            /*0x10*/ int <length>k__BackingField;
            /*0x14*/ bool m_Loop;
            /*0x18*/ float m_ZeroValue;
            /*0x1c*/ float m_Range;
            /*0x20*/ UnityEngine.AnimationCurve m_Curve;
            /*0x28*/ UnityEngine.AnimationCurve m_LoopingCurve;
            /*0x30*/ UnityEngine.Texture2D m_Texture;
            /*0x38*/ bool m_IsCurveDirty;
            /*0x39*/ bool m_IsTextureDirty;

            static /*0x268d414*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x268d240*/ TextureCurve(UnityEngine.AnimationCurve baseCurve, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x268d294*/ TextureCurve(UnityEngine.Keyframe[] keys, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x268d1f0*/ int get_length();
            /*0x268d1f8*/ void set_length(int value);
            /*0x268d200*/ UnityEngine.Keyframe get_Item(int index);
            /*0x268d39c*/ void Finalize();
            /*0x268d3a4*/ void Dispose();
            /*0x268d3a8*/ void Release();
            /*0x268d408*/ void SetDirty();
            /*0x268d460*/ UnityEngine.Texture2D GetTexture();
            /*0x268d63c*/ float Evaluate(float time);
            /*0x268d860*/ int AddKey(float time, float value);
            /*0x268d898*/ int MoveKey(int index, ref UnityEngine.Keyframe key);
            /*0x268d8f0*/ void RemoveKey(int index);
            /*0x268d91c*/ void SmoothTangents(int index, float weight);
        }

        class TextureCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureCurve>
        {
            /*0x268d948*/ TextureCurveParameter(UnityEngine.Rendering.TextureCurve value, bool overrideState);
            /*0x268d9a8*/ void Release();
        }

        class TileLayoutUtils
        {
            static /*0x268d9c0*/ bool TryLayoutByTiles(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt topRow, ref UnityEngine.RectInt rightCol, ref UnityEngine.RectInt topRight);
            static /*0x268dcd0*/ bool TryLayoutByRow(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
            static /*0x268de70*/ bool TryLayoutByCol(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
        }

        class XRUtils
        {
            static /*0x268e010*/ void DrawOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, bool stereoEnabled);
        }

        interface IVolume
        {
            bool get_isGlobal();
            void set_isGlobal(bool value);
            System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
        }

        class Volume : UnityEngine.MonoBehaviour, UnityEngine.Rendering.IVolume
        {
            /*0x18*/ bool m_IsGlobal;
            /*0x1c*/ float priority;
            /*0x20*/ float blendDistance;
            /*0x24*/ float weight;
            /*0x28*/ UnityEngine.Rendering.VolumeProfile sharedProfile;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Collider> m_Colliders;
            /*0x38*/ int m_PreviousLayer;
            /*0x3c*/ float m_PreviousPriority;
            /*0x40*/ UnityEngine.Rendering.VolumeProfile m_InternalProfile;

            /*0x268ed58*/ Volume();
            /*0x268e0b0*/ bool get_isGlobal();
            /*0x268e0b8*/ void set_isGlobal(bool value);
            /*0x268e0c4*/ UnityEngine.Rendering.VolumeProfile get_profile();
            /*0x268e388*/ void set_profile(UnityEngine.Rendering.VolumeProfile value);
            /*0x268e390*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
            /*0x268e398*/ UnityEngine.Rendering.VolumeProfile get_profileRef();
            /*0x268e410*/ bool HasInstantiatedProfile();
            /*0x268e470*/ void OnEnable();
            /*0x268e82c*/ void OnDisable();
            /*0x268ea58*/ void Update();
            /*0x268eafc*/ void UpdateLayer();
        }

        class VolumeComponentMenu : System.Attribute
        {
            /*0x10*/ string menu;

            /*0x268ede4*/ VolumeComponentMenu(string menu);
        }

        class VolumeComponentMenuForRenderPipeline : UnityEngine.Rendering.VolumeComponentMenu
        {
            /*0x18*/ System.Type[] <pipelineTypes>k__BackingField;

            /*0x268ee14*/ VolumeComponentMenuForRenderPipeline(string menu, System.Type[] pipelineTypes);
            /*0x268ee0c*/ System.Type[] get_pipelineTypes();
        }

        class VolumeComponentDeprecated : System.Attribute
        {
            /*0x268eff4*/ VolumeComponentDeprecated();
        }

        class VolumeComponent : UnityEngine.ScriptableObject
        {
            /*0x18*/ bool active;
            /*0x20*/ string <displayName>k__BackingField;
            /*0x28*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> <parameters>k__BackingField;

            static /*0x268f01c*/ void FindParameters(object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo, bool> filter);
            /*0x2690478*/ VolumeComponent();
            /*0x268effc*/ string get_displayName();
            /*0x268f004*/ void set_displayName(string value);
            /*0x268f00c*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x268f014*/ void set_parameters(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> value);
            /*0x268f648*/ void OnEnable();
            /*0x268f9fc*/ void OnDisable();
            /*0x268fc80*/ void Override(UnityEngine.Rendering.VolumeComponent state, float interpFactor);
            /*0x268fdb4*/ void SetAllOverridesTo(bool state);
            /*0x268fdc4*/ void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, bool state);
            /*0x26902e8*/ int GetHashCode();
            /*0x26903b0*/ void OnDestroy();
            /*0x26903b4*/ void Release();

            class Indent : UnityEngine.PropertyAttribute
            {
                /*0x14*/ int relativeAmount;

                /*0x26904d0*/ Indent(int relativeAmount);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeComponent.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, int> <>9__10_0;

                static /*0x26904f8*/ <>c();
                /*0x269055c*/ <>c();
                /*0x2690564*/ int <FindParameters>b__10_0(System.Reflection.FieldInfo t);
            }
        }

        class VolumeManager
        {
            static int k_MaxLayerCount = 32;
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.VolumeManager> s_Instance;
            /*0x10*/ UnityEngine.Rendering.VolumeStack <stack>k__BackingField;
            /*0x18*/ System.Type[] <baseComponentTypeArray>k__BackingField;
            /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Rendering.Volume>> m_SortedVolumes;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> m_Volumes;
            /*0x30*/ System.Collections.Generic.Dictionary<int, bool> m_SortNeeded;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> m_ComponentsDefaultState;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Collider> m_TempColliders;
            /*0x48*/ UnityEngine.Rendering.VolumeStack m_DefaultStack;

            static /*0x2692384*/ VolumeManager();
            static /*0x268e514*/ UnityEngine.Rendering.VolumeManager get_instance();
            static /*0x2692250*/ void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes);
            static /*0x269237c*/ bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera);
            /*0x269060c*/ VolumeManager();
            /*0x2690588*/ UnityEngine.Rendering.VolumeStack get_stack();
            /*0x2690590*/ void set_stack(UnityEngine.Rendering.VolumeStack value);
            /*0x2690598*/ System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes();
            /*0x26905a0*/ void set_baseComponentTypes(System.Collections.Generic.IEnumerable<System.Type> value);
            /*0x26905fc*/ System.Type[] get_baseComponentTypeArray();
            /*0x2690604*/ void set_baseComponentTypeArray(System.Type[] value);
            /*0x2690ac4*/ UnityEngine.Rendering.VolumeStack CreateStack();
            /*0x2690f98*/ void ResetMainStack();
            /*0x2690fa4*/ void DestroyStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x26907b8*/ void ReloadBaseTypes();
            /*0x268e58c*/ void Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x268e8b0*/ void Unregister(UnityEngine.Rendering.Volume volume, int layer);
            bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
            /*0x268eba4*/ void SetLayerDirty(int layer);
            /*0x268ed28*/ void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer);
            /*0x2691150*/ void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, float interpFactor);
            /*0x2691368*/ void ReplaceData(UnityEngine.Rendering.VolumeStack stack);
            /*0x2691408*/ void CheckBaseTypes();
            /*0x26914c4*/ void CheckStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x26916c0*/ bool CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack);
            /*0x2691734*/ void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x2691748*/ void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x2692118*/ UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask);
            /*0x2691d34*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeManager.<> <>9;
                static /*0x8*/ System.Func<System.Type, bool> <>9__25_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.Volume> <>9__38_0;

                static /*0x269248c*/ <>c();
                /*0x26924f0*/ <>c();
                /*0x26924f8*/ bool <ReloadBaseTypes>b__25_0(System.Type t);
                /*0x2692520*/ bool <GetVolumes>b__38_0(UnityEngine.Rendering.Volume v);
                /*0x269257c*/ UnityEngine.Rendering.VolumeManager <.cctor>b__42_0();
            }
        }

        struct VolumeIsolationScope : System.IDisposable
        {
            /*0x26925d4*/ VolumeIsolationScope(bool unused);
            /*0x26925d8*/ void System.IDisposable.Dispose();
        }

        class VolumeParameter
        {
            static string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
            /*0x10*/ bool m_OverrideState;

            static /*0x26901b4*/ bool IsObjectParameter(System.Type type);
            /*0x26925fc*/ VolumeParameter();
            /*0x26925dc*/ bool get_overrideState();
            /*0x26925e4*/ void set_overrideState(bool value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            T GetValue<T>();
            void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x26925f0*/ void OnEnable();
            /*0x26925f4*/ void OnDisable();
            /*0x26925f8*/ void Release();
        }

        class VolumeParameter<T> : UnityEngine.Rendering.VolumeParameter, System.IEquatable<UnityEngine.Rendering.VolumeParameter<T>>
        {
            /*0x0*/ T m_Value;

            static bool op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static bool op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop);
            VolumeParameter();
            VolumeParameter(T value, bool overrideState);
            T get_value();
            void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            void Interp(T from, T to, float t);
            void Override(T x);
            void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            int GetHashCode();
            string ToString();
            bool Equals(UnityEngine.Rendering.VolumeParameter<T> other);
            bool Equals(object obj);
        }

        class BoolParameter : UnityEngine.Rendering.VolumeParameter<bool>
        {
            /*0x2692604*/ BoolParameter(bool value, bool overrideState);
        }

        class LayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.LayerMask>
        {
            /*0x2692664*/ LayerMaskParameter(UnityEngine.LayerMask value, bool overrideState);
        }

        class IntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x26926c4*/ IntParameter(int value, bool overrideState);
            /*0x2692724*/ void Interp(int from, int to, float t);
        }

        class NoInterpIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x2692758*/ NoInterpIntParameter(int value, bool overrideState);
        }

        class MinIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;

            /*0x26927d4*/ MinIntParameter(int value, int min, bool overrideState);
            /*0x26927b8*/ int get_value();
            /*0x26927c0*/ void set_value(int value);
        }

        class NoInterpMinIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;

            /*0x2692818*/ NoInterpMinIntParameter(int value, int min, bool overrideState);
            /*0x26927fc*/ int get_value();
            /*0x2692804*/ void set_value(int value);
        }

        class MaxIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int max;

            /*0x26928a8*/ MaxIntParameter(int value, int max, bool overrideState);
            /*0x269288c*/ int get_value();
            /*0x2692894*/ void set_value(int value);
        }

        class NoInterpMaxIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int max;

            /*0x26928ec*/ NoInterpMaxIntParameter(int value, int max, bool overrideState);
            /*0x26928d0*/ int get_value();
            /*0x26928d8*/ void set_value(int value);
        }

        class ClampedIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x2692984*/ ClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x2692960*/ int get_value();
            /*0x2692968*/ void set_value(int value);
        }

        class NoInterpClampedIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x26929d4*/ NoInterpClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x26929b0*/ int get_value();
            /*0x26929b8*/ void set_value(int value);
        }

        class FloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x2692a4c*/ FloatParameter(float value, bool overrideState);
            /*0x2692ab4*/ void Interp(float from, float to, float t);
        }

        class NoInterpFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x2692ac8*/ NoInterpFloatParameter(float value, bool overrideState);
        }

        class MinFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;

            /*0x2692b4c*/ MinFloatParameter(float value, float min, bool overrideState);
            /*0x2692b30*/ float get_value();
            /*0x2692b38*/ void set_value(float value);
        }

        class NoInterpMinFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;

            /*0x2692b90*/ NoInterpMinFloatParameter(float value, float min, bool overrideState);
            /*0x2692b74*/ float get_value();
            /*0x2692b7c*/ void set_value(float value);
        }

        class MaxFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float max;

            /*0x2692c20*/ MaxFloatParameter(float value, float max, bool overrideState);
            /*0x2692c04*/ float get_value();
            /*0x2692c0c*/ void set_value(float value);
        }

        class NoInterpMaxFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float max;

            /*0x2692c64*/ NoInterpMaxFloatParameter(float value, float max, bool overrideState);
            /*0x2692c48*/ float get_value();
            /*0x2692c50*/ void set_value(float value);
        }

        class ClampedFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x2692cfc*/ ClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x2692cd8*/ float get_value();
            /*0x2692ce0*/ void set_value(float value);
        }

        class NoInterpClampedFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x2692d4c*/ NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x2692d28*/ float get_value();
            /*0x2692d30*/ void set_value(float value);
        }

        class FloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x2692df0*/ FloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x2692dcc*/ UnityEngine.Vector2 get_value();
            /*0x2692dd4*/ void set_value(UnityEngine.Vector2 value);
            /*0x2692e78*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpFloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x2692ebc*/ NoInterpFloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x2692e98*/ UnityEngine.Vector2 get_value();
            /*0x2692ea0*/ void set_value(UnityEngine.Vector2 value);
        }

        class ColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x2692f44*/ ColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x2692fd4*/ ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
            /*0x269309c*/ void Interp(UnityEngine.Color from, UnityEngine.Color to, float t);
        }

        class NoInterpColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x26930cc*/ NoInterpColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x269315c*/ NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
        }

        class Vector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x2693224*/ Vector2Parameter(UnityEngine.Vector2 value, bool overrideState);
            /*0x2693294*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpVector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x26932b4*/ NoInterpVector2Parameter(UnityEngine.Vector2 value, bool overrideState);
        }

        class Vector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x2693324*/ Vector3Parameter(UnityEngine.Vector3 value, bool overrideState);
            /*0x26933a4*/ void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float t);
        }

        class NoInterpVector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x26933d4*/ NoInterpVector3Parameter(UnityEngine.Vector3 value, bool overrideState);
        }

        class Vector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x2693454*/ Vector4Parameter(UnityEngine.Vector4 value, bool overrideState);
            /*0x26934dc*/ void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, float t);
        }

        class NoInterpVector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x269350c*/ NoInterpVector4Parameter(UnityEngine.Vector4 value, bool overrideState);
        }

        class TextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x20*/ UnityEngine.Rendering.TextureDimension dimension;

            /*0x2693594*/ TextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x26935a0*/ TextureParameter(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, bool overrideState);
            /*0x2693614*/ int GetHashCode();
        }

        class NoInterpTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x269370c*/ NoInterpTextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x269376c*/ int GetHashCode();
        }

        class Texture2DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x2693864*/ Texture2DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x26938c4*/ int GetHashCode();
        }

        class Texture3DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x26939bc*/ Texture3DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x2693a1c*/ int GetHashCode();
        }

        class RenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x2693b14*/ RenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x2693b74*/ int GetHashCode();
        }

        class NoInterpRenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x2693c6c*/ NoInterpRenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x2693ccc*/ int GetHashCode();
        }

        class CubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x2693dc4*/ CubemapParameter(UnityEngine.Texture value, bool overrideState);
            /*0x2693e24*/ int GetHashCode();
        }

        class NoInterpCubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Cubemap>
        {
            /*0x2693f1c*/ NoInterpCubemapParameter(UnityEngine.Cubemap value, bool overrideState);
            /*0x2693f7c*/ int GetHashCode();
        }

        class ObjectParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x0*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> <parameters>k__BackingField;

            ObjectParameter(T value);
            System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            void set_parameters(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> value);
            bool get_overrideState();
            void set_overrideState(bool value);
            T get_value();
            void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            UnityEngine.Rendering.VolumeParameter <set_value>b__9_2(System.Reflection.FieldInfo t);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ObjectParameter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__9_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, int> <>9__9_1;

                static <>c();
                <>c();
                bool <set_value>b__9_0(System.Reflection.FieldInfo t);
                int <set_value>b__9_1(System.Reflection.FieldInfo t);
            }
        }

        class AnimationCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.AnimationCurve>
        {
            /*0x2694074*/ AnimationCurveParameter(UnityEngine.AnimationCurve value, bool overrideState);
        }

        class VolumeProfile : UnityEngine.ScriptableObject
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components;
            /*0x20*/ bool isDirty;

            /*0x2694b0c*/ VolumeProfile();
            /*0x26940d4*/ void OnEnable();
            /*0x26941d4*/ void OnDisable();
            /*0x26942b8*/ void Reset();
            T Add<T>(bool overrides);
            /*0x26942c4*/ UnityEngine.Rendering.VolumeComponent Add(System.Type type, bool overrides);
            void Remove<T>();
            /*0x26945f8*/ void Remove(System.Type type);
            bool Has<T>();
            /*0x2694448*/ bool Has(System.Type type);
            /*0x2694710*/ bool HasSubclassOf(System.Type type);
            bool TryGet<T>(ref T component);
            bool TryGet<T>(System.Type type, ref T component);
            bool TryGetSubclassOf<T>(System.Type type, ref T component);
            bool TryGetAllSubclassOf<T>(System.Type type, System.Collections.Generic.List<T> result);
            /*0x26948b0*/ int GetHashCode();
            /*0x269495c*/ int GetComponentListHashCode();
            /*0x2694a14*/ void Sanitize();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeProfile.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.VolumeComponent> <>9__2_0;

                static /*0x2694b90*/ <>c();
                /*0x2694bf4*/ <>c();
                /*0x2694bfc*/ bool <OnEnable>b__2_0(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class VolumeStack : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.VolumeComponent> components;
            /*0x18*/ System.ValueTuple<UnityEngine.Rendering.VolumeParameter, UnityEngine.Rendering.VolumeParameter> defaultParameters;
            /*0x20*/ bool requiresReset;

            /*0x2690b2c*/ VolumeStack();
            /*0x2690bb0*/ void Reload(System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentDefaultStates);
            T GetComponent<T>();
            /*0x26912f8*/ UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type);
            /*0x2690fb8*/ void Dispose();
        }

        class XRGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;
            static /*0x1*/ bool running;

            static /*0x2694cb8*/ XRGraphicsAutomatedTests();
            static /*0x2694c58*/ bool get_activatedFromCommandLine();
            static /*0x2694c60*/ bool get_enabled();
        }

        namespace LookDev
        {
            interface IDataProvider
            {
                void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                System.Collections.Generic.IEnumerable<string> get_supportedDebugModes();
                void UpdateDebugMode(int debugIndex);
                void GetShadowMask(ref UnityEngine.RenderTexture output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI);
            }

            struct Sky
            {
                /*0x10*/ UnityEngine.Cubemap cubemap;
                /*0x18*/ float longitudeOffset;
                /*0x1c*/ float exposure;
            }

            class StageRuntimeInterface
            {
                /*0x10*/ System.Func<bool, UnityEngine.GameObject> m_AddGameObject;
                /*0x18*/ System.Func<UnityEngine.Camera> m_GetCamera;
                /*0x20*/ System.Func<UnityEngine.Light> m_GetSunLight;
                /*0x28*/ object SRPData;

                /*0x2694d00*/ StageRuntimeInterface(System.Func<bool, UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight);
                /*0x2694d3c*/ UnityEngine.GameObject AddGameObject(bool persistent);
                /*0x2694d60*/ UnityEngine.Camera get_camera();
                /*0x2694d80*/ UnityEngine.Light get_sunLight();
            }
        }

        namespace UI
        {
            class DebugUIHandlerBitField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x68*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle> toggles;
                /*0x70*/ UnityEngine.Rendering.DebugUI.BitField m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x2695af0*/ DebugUIHandlerBitField();
                /*0x2694da0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x2695184*/ bool GetValue(int index);
                /*0x2695234*/ void SetValue(int index, bool value);
                /*0x2695584*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x26957fc*/ void OnDeselection();
                /*0x269582c*/ void OnIncrement(bool fast);
                /*0x269584c*/ void OnDecrement(bool fast);
                /*0x269586c*/ void OnAction();
                /*0x2695894*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerButton : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.DebugUI.Button m_Field;

                /*0x2695c50*/ DebugUIHandlerButton();
                /*0x2695b30*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x2695bb4*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x2695bec*/ void OnDeselection();
                /*0x2695c1c*/ void OnAction();
            }

            class DebugUIPrefabBundle
            {
                /*0x10*/ string type;
                /*0x18*/ UnityEngine.RectTransform prefab;

                /*0x2695c70*/ DebugUIPrefabBundle();
            }

            class DebugUIHandlerCanvas : UnityEngine.MonoBehaviour
            {
                /*0x18*/ int m_DebugTreeState;
                /*0x20*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Transform> m_PrefabsMap;
                /*0x28*/ UnityEngine.Transform panelPrefab;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIPrefabBundle> prefabs;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerPanel> m_UIPanels;
                /*0x40*/ int m_SelectedPanel;
                /*0x48*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget m_SelectedWidget;
                /*0x50*/ string m_CurrentQueryPath;

                /*0x2697e9c*/ DebugUIHandlerCanvas();
                /*0x2695c78*/ void OnEnable();
                /*0x2695dc4*/ void Update();
                /*0x26965a4*/ void RequestHierarchyReset();
                /*0x2695eec*/ void ResetAllHierarchy();
                /*0x26965b0*/ void Rebuild();
                /*0x269703c*/ void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, ref UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedHandler);
                /*0x26976bc*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(string queryPath);
                /*0x26974c8*/ void ActivatePanel(int index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget);
                /*0x2697860*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
                /*0x2697b70*/ void SelectPreviousItem();
                /*0x2697c34*/ void SelectNextPanel();
                /*0x2697ca8*/ void SelectPreviousPanel();
                /*0x2697aac*/ void SelectNextItem();
                /*0x2697d28*/ void ChangeSelectionValue(float multiplier);
                /*0x2697e14*/ void ActivateSelection();
                /*0x26961f8*/ void HandleInput();
                /*0x26979d4*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, bool> <>9__12_0;
                    static /*0x10*/ System.Action<UnityEngine.Rendering.UI.DebugUIHandlerPanel> <>9__15_0;

                    static /*0x2697ea4*/ <>c();
                    /*0x2697f08*/ <>c();
                    /*0x2697f10*/ bool <Rebuild>b__12_0(UnityEngine.Rendering.DebugUI.Widget x);
                    /*0x2697f54*/ void <ActivatePanel>b__15_0(UnityEngine.Rendering.UI.DebugUIHandlerPanel p);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ string queryPath;

                    /*0x2697804*/ <>c__DisplayClass14_0();
                    /*0x2697f80*/ bool <GetWidgetFromPath>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget w);
                }
            }

            class DebugUIHandlerColor : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x68*/ UnityEngine.UI.Image colorImage;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldR;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldG;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldB;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldA;
                /*0x90*/ UnityEngine.Rendering.DebugUI.ColorField m_Field;
                /*0x98*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x26987fc*/ DebugUIHandlerColor();
                /*0x2697fac*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x26984ec*/ void SetValue(float x, bool r, bool g, bool b, bool a);
                /*0x2698334*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x26985b8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269869c*/ void OnDeselection();
                /*0x26986cc*/ void OnIncrement(bool fast);
                /*0x26986ec*/ void OnDecrement(bool fast);
                /*0x269870c*/ void OnAction();
                /*0x2698438*/ void UpdateColor();
                /*0x2698734*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x269881c*/ float <SetWidget>b__9_0();
                /*0x269886c*/ void <SetWidget>b__9_1(float x);
                /*0x2698880*/ float <SetWidget>b__9_2();
                /*0x26988d8*/ void <SetWidget>b__9_3(float x);
                /*0x26988ec*/ float <SetWidget>b__9_4();
                /*0x2698944*/ void <SetWidget>b__9_5(float x);
                /*0x2698958*/ float <SetWidget>b__9_6();
                /*0x26989b0*/ void <SetWidget>b__9_7(float x);
                /*0x26989c4*/ float <SetupSettings>b__11_0();
                /*0x26989e0*/ float <SetupSettings>b__11_1();
                /*0x26989fc*/ float <SetupSettings>b__11_2();
            }

            class DebugUIHandlerContainer : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.RectTransform contentHolder;

                /*0x2698e48*/ DebugUIHandlerContainer();
                /*0x2695a60*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x269576c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem();
                /*0x2695668*/ bool IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
                /*0x2698a1c*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget widget;

                    /*0x2698e40*/ <>c__DisplayClass3_0();
                    /*0x2698e50*/ bool <IsDirectChild>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget x);
                }
            }

            class DebugUIHandlerEnumField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nextButtonText;
                /*0x60*/ UnityEngine.UI.Text previousButtonText;
                /*0x68*/ UnityEngine.UI.Text nameLabel;
                /*0x70*/ UnityEngine.UI.Text valueLabel;
                /*0x78*/ UnityEngine.Rendering.DebugUI.EnumField m_Field;

                /*0x2699560*/ DebugUIHandlerEnumField();
                /*0x2698ebc*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x2698f54*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269906c*/ void OnDeselection();
                /*0x269917c*/ void OnAction();
                /*0x269918c*/ void OnIncrement(bool fast);
                /*0x26992f4*/ void OnDecrement(bool fast);
                /*0x2699488*/ void UpdateValueLabel();
            }

            class DebugUIHandlerEnumHistory : UnityEngine.Rendering.UI.DebugUIHandlerEnumField
            {
                static float xDecal = 60;
                /*0x80*/ UnityEngine.UI.Text[] historyValues;

                /*0x2699a90*/ DebugUIHandlerEnumHistory();
                /*0x2699580*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x26997e4*/ void UpdateValueLabel();
                /*0x2699a00*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory <>4__this;

                    /*0x2699a68*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x2699ab0*/ void System.IDisposable.Dispose();
                    /*0x2699ab4*/ bool MoveNext();
                    /*0x2699b90*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2699b98*/ void System.Collections.IEnumerator.Reset();
                    /*0x2699bd8*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Text valueLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.FloatField m_Field;

                /*0x2699ea0*/ DebugUIHandlerFloatField();
                /*0x2699be0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x2699d34*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x2699d8c*/ void OnDeselection();
                /*0x2699ddc*/ void OnIncrement(bool fast);
                /*0x2699e94*/ void OnDecrement(bool fast);
                /*0x2699de8*/ void ChangeValue(bool fast, float multiplier);
                /*0x2699c6c*/ void UpdateValueLabel();
            }

            class DebugUIHandlerFoldout : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static float xDecal = 60;
                static float xDecalInit = 230;
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Foldout m_Field;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269a478*/ DebugUIHandlerFoldout();
                /*0x2699ec0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269a23c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269a320*/ void OnDeselection();
                /*0x269a350*/ void OnIncrement(bool fast);
                /*0x269a370*/ void OnDecrement(bool fast);
                /*0x269a38c*/ void OnAction();
                /*0x269a214*/ void UpdateValue();
                /*0x269a3b0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerGroup : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Transform header;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Container m_Field;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269a6f4*/ DebugUIHandlerGroup();
                /*0x269a498*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269a584*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269a63c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerHBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269a8e4*/ DebugUIHandlerHBox();
                /*0x269a714*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269a774*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269a82c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerIndirectFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Text valueLabel;
                /*0x68*/ System.Func<float> getter;
                /*0x70*/ System.Action<float> setter;
                /*0x78*/ System.Func<float> incStepGetter;
                /*0x80*/ System.Func<float> incStepMultGetter;
                /*0x88*/ System.Func<float> decimalsGetter;

                /*0x269ab90*/ DebugUIHandlerIndirectFloatField();
                /*0x26985b4*/ void Init();
                /*0x269aa18*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269aa70*/ void OnDeselection();
                /*0x269aac0*/ void OnIncrement(bool fast);
                /*0x269ab84*/ void OnDecrement(bool fast);
                /*0x269aacc*/ void ChangeValue(bool fast, float multiplier);
                /*0x269a904*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIndirectToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Toggle valueToggle;
                /*0x68*/ UnityEngine.UI.Image checkmarkImage;
                /*0x70*/ System.Func<int, bool> getter;
                /*0x78*/ System.Action<int, bool> setter;
                /*0x80*/ int index;

                /*0x269ace4*/ DebugUIHandlerIndirectToggle();
                /*0x26950d4*/ void Init();
                /*0x269abb0*/ void OnToggleValueChanged(bool value);
                /*0x269abe0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269ac38*/ void OnDeselection();
                /*0x269ac88*/ void OnAction();
                /*0x26954dc*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Text valueLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.IntField m_Field;

                /*0x269afe0*/ DebugUIHandlerIntField();
                /*0x269ad04*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269ae74*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269aecc*/ void OnDeselection();
                /*0x269af1c*/ void OnIncrement(bool fast);
                /*0x269afd4*/ void OnDecrement(bool fast);
                /*0x269af28*/ void ChangeValue(bool fast, int multiplier);
                /*0x269ad90*/ void UpdateValueLabel();
            }

            class DebugUIHandlerMessageBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color32 k_WarningBackgroundColor;
                static /*0x4*/ UnityEngine.Color32 k_WarningTextColor;
                static /*0x8*/ UnityEngine.Color32 k_ErrorBackgroundColor;
                static /*0xc*/ UnityEngine.Color32 k_ErrorTextColor;
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.DebugUI.MessageBox m_Field;

                static /*0x269b1a0*/ DebugUIHandlerMessageBox();
                /*0x269b180*/ DebugUIHandlerMessageBox();
                /*0x269b000*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269b178*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
            }

            class DebugUIHandlerPanel : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.UI.Text nameLabel;
                /*0x20*/ UnityEngine.UI.ScrollRect scrollRect;
                /*0x28*/ UnityEngine.RectTransform viewport;
                /*0x30*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas Canvas;
                /*0x38*/ UnityEngine.RectTransform m_ScrollTransform;
                /*0x40*/ UnityEngine.RectTransform m_ContentTransform;
                /*0x48*/ UnityEngine.RectTransform m_MaskTransform;
                /*0x50*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget m_ScrollTarget;
                /*0x58*/ UnityEngine.Rendering.DebugUI.Panel m_Panel;

                /*0x269b504*/ DebugUIHandlerPanel();
                /*0x269b228*/ void OnEnable();
                /*0x269700c*/ void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x269b2e0*/ UnityEngine.Rendering.DebugUI.Panel GetPanel();
                /*0x269b2e8*/ void SelectNextItem();
                /*0x269b300*/ void SelectPreviousItem();
                /*0x269b318*/ void OnScrollbarClicked();
                /*0x269b37c*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target);
                /*0x2696408*/ void UpdateScroll();
                /*0x269b384*/ float GetYPosInScroll(UnityEngine.RectTransform target);
                /*0x269780c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x269b4a4*/ void ResetDebugManager();
            }

            class DebugUIHandlerPersistentCanvas : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.RectTransform panel;
                /*0x20*/ UnityEngine.RectTransform valuePrefab;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue> m_Items;

                /*0x269b980*/ DebugUIHandlerPersistentCanvas();
                /*0x269b50c*/ void Toggle(UnityEngine.Rendering.DebugUI.Value widget);
                /*0x269b7c8*/ void Clear();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Value widget;

                    /*0x269b7c0*/ <>c__DisplayClass3_0();
                    /*0x269b9fc*/ bool <Toggle>b__0(UnityEngine.Rendering.UI.DebugUIHandlerValue x);
                }
            }

            class DebugUIHandlerRow : UnityEngine.Rendering.UI.DebugUIHandlerFoldout
            {
                /*0x78*/ float m_Timer;

                /*0x269bda4*/ DebugUIHandlerRow();
                /*0x269ba20*/ void OnEnable();
                /*0x269ba28*/ void Update();
            }

            class DebugUIHandlerToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Toggle valueToggle;
                /*0x68*/ UnityEngine.UI.Image checkmarkImage;
                /*0x70*/ UnityEngine.Rendering.DebugUI.BoolField m_Field;

                /*0x269c11c*/ DebugUIHandlerToggle();
                /*0x269bdc4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269bed8*/ void OnToggleValueChanged(bool value);
                /*0x269bf30*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269bf88*/ void OnDeselection();
                /*0x269bfd8*/ void OnAction();
                /*0x269c06c*/ void UpdateValueLabel();
            }

            class DebugUIHandlerToggleHistory : UnityEngine.Rendering.UI.DebugUIHandlerToggle
            {
                static float xDecal = 60;
                /*0x78*/ UnityEngine.UI.Toggle[] historyToggles;

                /*0x269c700*/ DebugUIHandlerToggleHistory();
                /*0x269c13c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269c4e0*/ void UpdateValueLabel();
                /*0x269c670*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory <>4__this;

                    /*0x269c6d8*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x269c720*/ void System.IDisposable.Dispose();
                    /*0x269c724*/ bool MoveNext();
                    /*0x269c7cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x269c7d4*/ void System.Collections.IEnumerator.Reset();
                    /*0x269c814*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerUIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Text valueLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.UIntField m_Field;

                /*0x269cb10*/ DebugUIHandlerUIntField();
                /*0x269c81c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269c98c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269c9e4*/ void OnDeselection();
                /*0x269ca34*/ void OnIncrement(bool fast);
                /*0x269cb04*/ void OnDecrement(bool fast);
                /*0x269ca40*/ void ChangeValue(bool fast, int multiplier);
                /*0x269c8a8*/ void UpdateValueLabel();
            }

            class DebugUIHandlerValue : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.UI.Text valueLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Value m_Field;
                /*0x70*/ float m_Timer;

                /*0x269cd00*/ DebugUIHandlerValue();
                /*0x269cb30*/ void OnEnable();
                /*0x269cb38*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269cbbc*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269cc14*/ void OnDeselection();
                /*0x269cc64*/ void Update();
            }

            class DebugUIHandlerVBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269cef0*/ DebugUIHandlerVBox();
                /*0x269cd20*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269cd80*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269ce38*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerVector2 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x68*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x78*/ UnityEngine.Rendering.DebugUI.Vector2Field m_Field;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269d4f8*/ DebugUIHandlerVector2();
                /*0x269cf10*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269d214*/ void SetValue(float v, bool x, bool y);
                /*0x269d110*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x269d2b4*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269d398*/ void OnDeselection();
                /*0x269d3c8*/ void OnIncrement(bool fast);
                /*0x269d3e8*/ void OnDecrement(bool fast);
                /*0x269d408*/ void OnAction();
                /*0x269d430*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x269d518*/ float <SetWidget>b__6_0();
                /*0x269d568*/ void <SetWidget>b__6_1(float x);
                /*0x269d574*/ float <SetWidget>b__6_2();
                /*0x269d5cc*/ void <SetWidget>b__6_3(float x);
                /*0x269d5d8*/ float <SetupSettings>b__8_0();
                /*0x269d5f4*/ float <SetupSettings>b__8_1();
                /*0x269d610*/ float <SetupSettings>b__8_2();
            }

            class DebugUIHandlerVector3 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x68*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldZ;
                /*0x80*/ UnityEngine.Rendering.DebugUI.Vector3Field m_Field;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269dcc4*/ DebugUIHandlerVector3();
                /*0x269d630*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269d9d4*/ void SetValue(float v, bool x, bool y, bool z);
                /*0x269d8d0*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x269da80*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269db64*/ void OnDeselection();
                /*0x269db94*/ void OnIncrement(bool fast);
                /*0x269dbb4*/ void OnDecrement(bool fast);
                /*0x269dbd4*/ void OnAction();
                /*0x269dbfc*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x269dce4*/ float <SetWidget>b__7_0();
                /*0x269dd34*/ void <SetWidget>b__7_1(float v);
                /*0x269dd44*/ float <SetWidget>b__7_2();
                /*0x269dd9c*/ void <SetWidget>b__7_3(float v);
                /*0x269ddac*/ float <SetWidget>b__7_4();
                /*0x269de04*/ void <SetWidget>b__7_5(float v);
                /*0x269de14*/ float <SetupSettings>b__9_0();
                /*0x269de30*/ float <SetupSettings>b__9_1();
                /*0x269de4c*/ float <SetupSettings>b__9_2();
            }

            class DebugUIHandlerVector4 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x58*/ UnityEngine.UI.Text nameLabel;
                /*0x60*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x68*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldZ;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldW;
                /*0x88*/ UnityEngine.Rendering.DebugUI.Vector4Field m_Field;
                /*0x90*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x269e5b4*/ DebugUIHandlerVector4();
                /*0x269de6c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269e2b0*/ void SetValue(float v, bool x, bool y, bool z, bool w);
                /*0x269e1ac*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x269e370*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269e454*/ void OnDeselection();
                /*0x269e484*/ void OnIncrement(bool fast);
                /*0x269e4a4*/ void OnDecrement(bool fast);
                /*0x269e4c4*/ void OnAction();
                /*0x269e4ec*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x269e5d4*/ float <SetWidget>b__8_0();
                /*0x269e624*/ void <SetWidget>b__8_1(float x);
                /*0x269e638*/ float <SetWidget>b__8_2();
                /*0x269e690*/ void <SetWidget>b__8_3(float x);
                /*0x269e6a4*/ float <SetWidget>b__8_4();
                /*0x269e6fc*/ void <SetWidget>b__8_5(float x);
                /*0x269e710*/ float <SetWidget>b__8_6();
                /*0x269e768*/ void <SetWidget>b__8_7(float x);
                /*0x269e77c*/ float <SetupSettings>b__10_0();
                /*0x269e798*/ float <SetupSettings>b__10_1();
                /*0x269e7b4*/ float <SetupSettings>b__10_2();
            }

            class DebugUIHandlerWidget : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.Color colorDefault;
                /*0x28*/ UnityEngine.Color colorSelected;
                /*0x38*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <parentUIHandler>k__BackingField;
                /*0x40*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <previousUIHandler>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <nextUIHandler>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.DebugUI.Widget m_Widget;

                /*0x2695b10*/ DebugUIHandlerWidget();
                /*0x269e7d4*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler();
                /*0x269e7dc*/ void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x269e7e4*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler();
                /*0x269e7ec*/ void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x269e7f4*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler();
                /*0x269e7fc*/ void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x269e804*/ void OnEnable();
                /*0x269e808*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x269e810*/ UnityEngine.Rendering.DebugUI.Widget GetWidget();
                T CastWidget<T>();
                /*0x269e818*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x269e820*/ void OnDeselection();
                /*0x269e824*/ void OnAction();
                /*0x269e828*/ void OnIncrement(bool fast);
                /*0x269e82c*/ void OnDecrement(bool fast);
                /*0x269e830*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous();
                /*0x269595c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class UIFoldout : UnityEngine.UI.Toggle
            {
                /*0x120*/ UnityEngine.GameObject content;
                /*0x128*/ UnityEngine.GameObject arrowOpened;
                /*0x130*/ UnityEngine.GameObject arrowClosed;

                /*0x269eb90*/ UIFoldout();
                /*0x269e8dc*/ void Start();
                /*0x269e9a4*/ void OnValidate();
                /*0x269e998*/ void SetState(bool state);
                /*0x269e9b0*/ void SetState(bool state, bool rebuildLayout);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097;
    static /*0x100*/ <PrivateImplementationDetails> 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A;
    static /*0x300*/ <PrivateImplementationDetails> 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4;
    static /*0x700*/ <PrivateImplementationDetails> BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158;
    static /*0x790*/ <PrivateImplementationDetails> C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF;
    static /*0x1790*/ <PrivateImplementationDetails> FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE;

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=144
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

    struct __StaticArrayInitTypeSize=4096
    {
    }
}
