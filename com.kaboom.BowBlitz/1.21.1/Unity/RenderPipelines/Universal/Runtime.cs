class <Module>
{
}

namespace UnityEngine
{
    namespace Experimental
    {
        namespace Rendering
        {
            namespace Universal
            {
                class PixelPerfectCamera : UnityEngine.MonoBehaviour, UnityEngine.Rendering.Universal.IPixelPerfectCamera, UnityEngine.ISerializationCallbackReceiver
                {
                    /*0x18*/ int m_AssetsPPU;
                    /*0x1c*/ int m_RefResolutionX;
                    /*0x20*/ int m_RefResolutionY;
                    /*0x24*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.CropFrame m_CropFrame;
                    /*0x28*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.GridSnapping m_GridSnapping;
                    /*0x30*/ UnityEngine.Camera m_Camera;
                    /*0x38*/ UnityEngine.Rendering.Universal.PixelPerfectCameraInternal m_Internal;
                    /*0x40*/ bool m_CinemachineCompatibilityMode;

                    /*0x269f784*/ PixelPerfectCamera();
                    /*0x269eb98*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.CropFrame get_cropFrame();
                    /*0x269eba0*/ void set_cropFrame(UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.CropFrame value);
                    /*0x269eba8*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.GridSnapping get_gridSnapping();
                    /*0x269ebb0*/ void set_gridSnapping(UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.GridSnapping value);
                    /*0x269ebb8*/ float get_orthographicSize();
                    /*0x269ebd4*/ int get_assetsPPU();
                    /*0x269ebdc*/ void set_assetsPPU(int value);
                    /*0x269ebfc*/ int get_refResolutionX();
                    /*0x269ec04*/ void set_refResolutionX(int value);
                    /*0x269ec24*/ int get_refResolutionY();
                    /*0x269ec2c*/ void set_refResolutionY(int value);
                    /*0x269ec4c*/ bool get_upscaleRT();
                    /*0x269ec5c*/ void set_upscaleRT(bool value);
                    /*0x269ec80*/ bool get_pixelSnapping();
                    /*0x269ec90*/ void set_pixelSnapping(bool value);
                    /*0x269ecac*/ bool get_cropFrameX();
                    /*0x269ecd0*/ void set_cropFrameX(bool value);
                    /*0x269ed1c*/ bool get_cropFrameY();
                    /*0x269ed40*/ void set_cropFrameY(bool value);
                    /*0x269ed8c*/ bool get_stretchFill();
                    /*0x269ed9c*/ void set_stretchFill(bool value);
                    /*0x269edb0*/ int get_pixelRatio();
                    /*0x269edfc*/ UnityEngine.Vector3 RoundToPixel(UnityEngine.Vector3 position);
                    /*0x269eff4*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
                    /*0x269f014*/ UnityEngine.FilterMode get_finalBlitFilterMode();
                    /*0x269f030*/ UnityEngine.Vector2Int get_offscreenRTSize();
                    /*0x269f04c*/ UnityEngine.Vector2Int get_cameraRTSize();
                    /*0x269f118*/ void PixelSnap();
                    /*0x269f298*/ void Awake();
                    /*0x269f32c*/ void UpdateCameraProperties();
                    /*0x269f3f0*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x269f4bc*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x269f548*/ void OnEnable();
                    /*0x269f638*/ void OnDisable();
                    /*0x269f77c*/ void OnBeforeSerialize();
                    /*0x269f780*/ void OnAfterDeserialize();

                    enum CropFrame
                    {
                        None = 0,
                        Pillarbox = 1,
                        Letterbox = 2,
                        Windowbox = 3,
                        StretchFill = 4,
                    }

                    enum GridSnapping
                    {
                        None = 0,
                        PixelSnapping = 1,
                        UpscaleRenderTexture = 2,
                    }

                    enum ComponentVersions
                    {
                        Version_Unserialized = 0,
                        Version_1 = 1,
                    }
                }

                class RenderObjectsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Experimental.Rendering.Universal.RenderQueueType renderQueueType;
                    /*0xdc*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0xf8*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings m_CameraSettings;
                    /*0x100*/ string m_ProfilerTag;
                    /*0x108*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x110*/ UnityEngine.Material <overrideMaterial>k__BackingField;
                    /*0x118*/ int <overrideMaterialPassIndex>k__BackingField;
                    /*0x120*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                    /*0x128*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;

                    /*0x269f914*/ RenderObjectsPass(string profilerTag, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Experimental.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                    /*0x269fd78*/ RenderObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Experimental.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                    /*0x269f7a0*/ UnityEngine.Material get_overrideMaterial();
                    /*0x269f7a8*/ void set_overrideMaterial(UnityEngine.Material value);
                    /*0x269f7b0*/ int get_overrideMaterialPassIndex();
                    /*0x269f7b8*/ void set_overrideMaterialPassIndex(int value);
                    /*0x269f7c0*/ void SetDetphState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                    /*0x269f82c*/ void SetStencilState(int reference, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOp, UnityEngine.Rendering.StencilOp failOp, UnityEngine.Rendering.StencilOp zFailOp);
                    /*0x269fe64*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.Universal.DebugHandler.DrawFunction <>9__19_0;

                        static /*0x26a059c*/ <>c();
                        /*0x26a0600*/ <>c();
                        /*0x26a0608*/ void <Execute>b__19_0(UnityEngine.Rendering.ScriptableRenderContext ctx, ref UnityEngine.Rendering.Universal.RenderingData data, ref UnityEngine.Rendering.DrawingSettings ds, ref UnityEngine.Rendering.FilteringSettings fs, ref UnityEngine.Rendering.RenderStateBlock rsb);
                    }
                }

                enum RenderQueueType
                {
                    Opaque = 0,
                    Transparent = 1,
                }

                class RenderObjects : UnityEngine.Rendering.Universal.ScriptableRendererFeature
                {
                    /*0x20*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.RenderObjectsSettings settings;
                    /*0x28*/ UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass renderObjectsPass;

                    /*0x26a07b8*/ RenderObjects();
                    /*0x26a0628*/ void Create();
                    /*0x26a0770*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x26a0794*/ bool SupportsNativeRenderPass();

                    class RenderObjectsSettings
                    {
                        /*0x10*/ string passTag;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent Event;
                        /*0x20*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.FilterSettings filterSettings;
                        /*0x28*/ UnityEngine.Material overrideMaterial;
                        /*0x30*/ int overrideMaterialPassIndex;
                        /*0x34*/ bool overrideDepthState;
                        /*0x38*/ UnityEngine.Rendering.CompareFunction depthCompareFunction;
                        /*0x3c*/ bool enableWrite;
                        /*0x40*/ UnityEngine.Rendering.Universal.StencilStateData stencilSettings;
                        /*0x48*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings;

                        /*0x26a081c*/ RenderObjectsSettings();
                    }

                    class FilterSettings
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.Universal.RenderQueueType RenderQueueType;
                        /*0x14*/ UnityEngine.LayerMask LayerMask;
                        /*0x18*/ string[] PassNames;

                        /*0x26a0944*/ FilterSettings();
                    }

                    class CustomCameraSettings
                    {
                        /*0x10*/ bool overrideCamera;
                        /*0x11*/ bool restoreCamera;
                        /*0x14*/ UnityEngine.Vector4 offset;
                        /*0x24*/ float cameraFieldOfView;

                        /*0x26a0970*/ CustomCameraSettings();
                    }
                }
            }
        }
    }

    namespace Rendering
    {
        namespace Universal
        {
            class CinemachineUniversalPixelPerfect : UnityEngine.MonoBehaviour
            {
                /*0x26a09f0*/ CinemachineUniversalPixelPerfect();
                /*0x26a0988*/ void OnEnable();
            }

            struct DoublePoint
            {
                /*0x10*/ double X;
                /*0x18*/ double Y;

                /*0x26a09f8*/ DoublePoint(double x, double y);
                /*0x26a0a00*/ DoublePoint(UnityEngine.Rendering.Universal.DoublePoint dp);
                /*0x26a0a08*/ DoublePoint(UnityEngine.Rendering.Universal.IntPoint ip);
            }

            class PolyTree : UnityEngine.Rendering.Universal.PolyNode
            {
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.PolyNode> m_AllPolys;

                /*0x26a0c30*/ PolyTree();
                /*0x26a0a24*/ void Clear();
                /*0x26a0b0c*/ UnityEngine.Rendering.Universal.PolyNode GetFirst();
                /*0x26a0b88*/ int get_Total();
            }

            class PolyNode
            {
                /*0x10*/ UnityEngine.Rendering.Universal.PolyNode m_Parent;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> m_polygon;
                /*0x20*/ int m_Index;
                /*0x24*/ UnityEngine.Rendering.Universal.JoinType m_jointype;
                /*0x28*/ UnityEngine.Rendering.Universal.EndType m_endtype;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.PolyNode> m_Childs;
                /*0x38*/ bool <IsOpen>k__BackingField;

                /*0x26a0ca8*/ PolyNode();
                /*0x26a0d68*/ bool IsHoleNode();
                /*0x26a0d84*/ int get_ChildCount();
                /*0x26a0dcc*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> get_Contour();
                /*0x26a0dd4*/ void AddChild(UnityEngine.Rendering.Universal.PolyNode Child);
                /*0x26a0e94*/ UnityEngine.Rendering.Universal.PolyNode GetNext();
                /*0x26a0f10*/ UnityEngine.Rendering.Universal.PolyNode GetNextSiblingUp();
                /*0x26a0fb0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.PolyNode> get_Childs();
                /*0x26a0fb8*/ UnityEngine.Rendering.Universal.PolyNode get_Parent();
                /*0x26a0fc0*/ bool get_IsHole();
                /*0x26a0fdc*/ bool get_IsOpen();
                /*0x26a0fe4*/ void set_IsOpen(bool value);
            }

            struct Int128
            {
                /*0x10*/ long hi;
                /*0x18*/ ulong lo;

                static /*0x26a1018*/ bool op_Equality(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x26a10c4*/ bool op_Inequality(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x26a1198*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x26a11b0*/ bool op_LessThan(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x26a11c8*/ UnityEngine.Rendering.Universal.Int128 op_Addition(UnityEngine.Rendering.Universal.Int128 lhs, UnityEngine.Rendering.Universal.Int128 rhs);
                static /*0x26a11d8*/ UnityEngine.Rendering.Universal.Int128 op_Subtraction(UnityEngine.Rendering.Universal.Int128 lhs, UnityEngine.Rendering.Universal.Int128 rhs);
                static /*0x26a11fc*/ UnityEngine.Rendering.Universal.Int128 op_UnaryNegation(UnityEngine.Rendering.Universal.Int128 val);
                static /*0x26a1214*/ double op_Explicit(UnityEngine.Rendering.Universal.Int128 val);
                static /*0x26a1274*/ UnityEngine.Rendering.Universal.Int128 Int128Mul(long lhs, long rhs);
                /*0x26a0ff0*/ Int128(long _lo);
                /*0x26a0ffc*/ Int128(long _hi, ulong _lo);
                /*0x26a1004*/ Int128(UnityEngine.Rendering.Universal.Int128 val);
                /*0x26a100c*/ bool IsNegative();
                /*0x26a10dc*/ bool Equals(object obj);
                /*0x26a1164*/ int GetHashCode();
            }

            struct IntPoint
            {
                /*0x10*/ long N;
                /*0x18*/ long X;
                /*0x20*/ long Y;
                /*0x28*/ long D;
                /*0x30*/ double NX;
                /*0x38*/ double NY;

                static /*0x26a1358*/ bool op_Equality(UnityEngine.Rendering.Universal.IntPoint a, UnityEngine.Rendering.Universal.IntPoint b);
                static /*0x26a1384*/ bool op_Inequality(UnityEngine.Rendering.Universal.IntPoint a, UnityEngine.Rendering.Universal.IntPoint b);
                /*0x26a12d8*/ IntPoint(long X, long Y);
                /*0x26a12ec*/ IntPoint(double x, double y);
                /*0x26a1324*/ IntPoint(UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x26a13b0*/ bool Equals(object obj);
                /*0x26a1438*/ int GetHashCode();
            }

            struct IntRect
            {
                /*0x10*/ long left;
                /*0x18*/ long top;
                /*0x20*/ long right;
                /*0x28*/ long bottom;

                /*0x26a14a4*/ IntRect(long l, long t, long r, long b);
                /*0x26a14b0*/ IntRect(UnityEngine.Rendering.Universal.IntRect ir);
            }

            enum ClipType
            {
                ctIntersection = 0,
                ctUnion = 1,
                ctDifference = 2,
                ctXor = 3,
            }

            enum PolyType
            {
                ptSubject = 0,
                ptClip = 1,
            }

            enum PolyFillType
            {
                pftEvenOdd = 0,
                pftNonZero = 1,
                pftPositive = 2,
                pftNegative = 3,
            }

            enum JoinType
            {
                jtRound = 0,
            }

            enum EndType
            {
                etClosedPolygon = 0,
                etClosedLine = 1,
            }

            enum EdgeSide
            {
                esLeft = 0,
                esRight = 1,
            }

            enum Direction
            {
                dRightToLeft = 0,
                dLeftToRight = 1,
            }

            class TEdge
            {
                /*0x10*/ UnityEngine.Rendering.Universal.IntPoint Bot;
                /*0x40*/ UnityEngine.Rendering.Universal.IntPoint Curr;
                /*0x70*/ UnityEngine.Rendering.Universal.IntPoint Top;
                /*0xa0*/ UnityEngine.Rendering.Universal.IntPoint Delta;
                /*0xd0*/ double Dx;
                /*0xd8*/ UnityEngine.Rendering.Universal.PolyType PolyTyp;
                /*0xdc*/ UnityEngine.Rendering.Universal.EdgeSide Side;
                /*0xe0*/ int WindDelta;
                /*0xe4*/ int WindCnt;
                /*0xe8*/ int WindCnt2;
                /*0xec*/ int OutIdx;
                /*0xf0*/ UnityEngine.Rendering.Universal.TEdge Next;
                /*0xf8*/ UnityEngine.Rendering.Universal.TEdge Prev;
                /*0x100*/ UnityEngine.Rendering.Universal.TEdge NextInLML;
                /*0x108*/ UnityEngine.Rendering.Universal.TEdge NextInAEL;
                /*0x110*/ UnityEngine.Rendering.Universal.TEdge PrevInAEL;
                /*0x118*/ UnityEngine.Rendering.Universal.TEdge NextInSEL;
                /*0x120*/ UnityEngine.Rendering.Universal.TEdge PrevInSEL;

                /*0x26a14d4*/ TEdge();
            }

            class IntersectNode
            {
                /*0x10*/ UnityEngine.Rendering.Universal.TEdge Edge1;
                /*0x18*/ UnityEngine.Rendering.Universal.TEdge Edge2;
                /*0x20*/ UnityEngine.Rendering.Universal.IntPoint Pt;

                /*0x26a14dc*/ IntersectNode();
            }

            class MyIntersectNodeSort : System.Collections.Generic.IComparer<UnityEngine.Rendering.Universal.IntersectNode>
            {
                /*0x26a151c*/ MyIntersectNodeSort();
                /*0x26a14e4*/ int Compare(UnityEngine.Rendering.Universal.IntersectNode node1, UnityEngine.Rendering.Universal.IntersectNode node2);
            }

            class LocalMinima
            {
                /*0x10*/ long Y;
                /*0x18*/ UnityEngine.Rendering.Universal.TEdge LeftBound;
                /*0x20*/ UnityEngine.Rendering.Universal.TEdge RightBound;
                /*0x28*/ UnityEngine.Rendering.Universal.LocalMinima Next;

                /*0x26a1524*/ LocalMinima();
            }

            class Scanbeam
            {
                /*0x10*/ long Y;
                /*0x18*/ UnityEngine.Rendering.Universal.Scanbeam Next;

                /*0x26a152c*/ Scanbeam();
            }

            class Maxima
            {
                /*0x10*/ long X;
                /*0x18*/ UnityEngine.Rendering.Universal.Maxima Next;
                /*0x20*/ UnityEngine.Rendering.Universal.Maxima Prev;

                /*0x26a1534*/ Maxima();
            }

            class OutRec
            {
                /*0x10*/ int Idx;
                /*0x14*/ bool IsHole;
                /*0x15*/ bool IsOpen;
                /*0x18*/ UnityEngine.Rendering.Universal.OutRec FirstLeft;
                /*0x20*/ UnityEngine.Rendering.Universal.OutPt Pts;
                /*0x28*/ UnityEngine.Rendering.Universal.OutPt BottomPt;
                /*0x30*/ UnityEngine.Rendering.Universal.PolyNode PolyNode;

                /*0x26a153c*/ OutRec();
            }

            class OutPt
            {
                /*0x10*/ int Idx;
                /*0x18*/ UnityEngine.Rendering.Universal.IntPoint Pt;
                /*0x48*/ UnityEngine.Rendering.Universal.OutPt Next;
                /*0x50*/ UnityEngine.Rendering.Universal.OutPt Prev;

                /*0x26a1544*/ OutPt();
            }

            class Join
            {
                /*0x10*/ UnityEngine.Rendering.Universal.OutPt OutPt1;
                /*0x18*/ UnityEngine.Rendering.Universal.OutPt OutPt2;
                /*0x20*/ UnityEngine.Rendering.Universal.IntPoint OffPt;

                /*0x26a154c*/ Join();
            }

            class ClipperBase
            {
                static double horizontal = -3.4e+38;
                static int Skip = -2;
                static int Unassigned = -1;
                static double tolerance = 1e-20;
                static long loRange = 1073741823;
                static long hiRange = 4611686018427387903;
                /*0x10*/ UnityEngine.Rendering.Universal.LocalMinima m_MinimaList;
                /*0x18*/ UnityEngine.Rendering.Universal.LocalMinima m_CurrentLM;
                /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.TEdge>> m_edges;
                /*0x28*/ UnityEngine.Rendering.Universal.Scanbeam m_Scanbeam;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.OutRec> m_PolyOuts;
                /*0x38*/ UnityEngine.Rendering.Universal.TEdge m_ActiveEdges;
                /*0x40*/ bool m_UseFullRange;
                /*0x41*/ bool m_HasOpenPaths;
                /*0x42*/ bool <PreserveCollinear>k__BackingField;

                static /*0x26a1554*/ bool near_zero(double val);
                static /*0x26a15a4*/ bool IsHorizontal(UnityEngine.Rendering.Universal.TEdge e);
                static /*0x26a1848*/ bool SlopesEqual(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, bool UseFullRange);
                static /*0x26a18cc*/ bool SlopesEqual(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3, bool UseFullRange);
                static /*0x26a197c*/ bool SlopesEqual(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3, UnityEngine.Rendering.Universal.IntPoint pt4, bool UseFullRange);
                static /*0x26a31f4*/ UnityEngine.Rendering.Universal.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths);
                /*0x26a1a48*/ ClipperBase();
                /*0x26a157c*/ bool get_PreserveCollinear();
                /*0x26a1584*/ void set_PreserveCollinear(bool value);
                /*0x26a1590*/ void Swap(ref long val1, ref long val2);
                /*0x26a15c4*/ bool PointIsVertex(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.OutPt pp);
                /*0x26a1614*/ bool PointOnLineSegment(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.IntPoint linePt1, UnityEngine.Rendering.Universal.IntPoint linePt2, bool UseFullRange);
                /*0x26a177c*/ bool PointOnPolygon(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.OutPt pp, bool UseFullRange);
                /*0x26a1ad0*/ void Clear();
                /*0x26a1c4c*/ void DisposeLocalMinimaList();
                /*0x26a1c68*/ void RangeTest(UnityEngine.Rendering.Universal.IntPoint Pt, ref bool useFullRange);
                /*0x26a1d68*/ void InitEdge(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.TEdge eNext, UnityEngine.Rendering.Universal.TEdge ePrev, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x26a1d98*/ void InitEdge2(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.PolyType polyType);
                /*0x26a1e6c*/ UnityEngine.Rendering.Universal.TEdge FindNextLocMin(UnityEngine.Rendering.Universal.TEdge E);
                /*0x26a1f5c*/ UnityEngine.Rendering.Universal.TEdge ProcessBound(UnityEngine.Rendering.Universal.TEdge E, bool LeftBoundIsForward);
                /*0x26a23d0*/ bool AddPath(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pg, UnityEngine.Rendering.Universal.PolyType polyType, bool Closed);
                /*0x26a2f80*/ bool AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> ppg, UnityEngine.Rendering.Universal.PolyType polyType, bool closed);
                /*0x26a2f04*/ bool Pt2IsBetweenPt1AndPt3(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3);
                /*0x26a2ed0*/ UnityEngine.Rendering.Universal.TEdge RemoveEdge(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a1e20*/ void SetDx(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a235c*/ void InsertLocalMinima(UnityEngine.Rendering.Universal.LocalMinima newLm);
                /*0x26a304c*/ bool PopLocalMinima(long Y, ref UnityEngine.Rendering.Universal.LocalMinima current);
                /*0x26a23ac*/ void ReverseHorizontal(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a3080*/ void Reset();
                /*0x26a30fc*/ void InsertScanbeam(long Y);
                /*0x26a34ec*/ bool PopScanbeam(ref long Y);
                /*0x26a3518*/ bool LocalMinimaPending();
                /*0x26a3528*/ UnityEngine.Rendering.Universal.OutRec CreateOutRec();
                /*0x26a3630*/ void DisposeOutRec(int index);
                /*0x26a36bc*/ void UpdateEdgeIntoAEL(ref UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a37bc*/ void SwapPositionsInAEL(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                /*0x26a3894*/ void DeleteFromAEL(UnityEngine.Rendering.Universal.TEdge e);
            }

            class Clipper : UnityEngine.Rendering.Universal.ClipperBase
            {
                static int ioReverseSolution = 1;
                static int ioStrictlySimple = 2;
                static int ioPreserveCollinear = 4;
                /*0x44*/ UnityEngine.Rendering.Universal.ClipType m_ClipType;
                /*0x48*/ UnityEngine.Rendering.Universal.Maxima m_Maxima;
                /*0x50*/ UnityEngine.Rendering.Universal.TEdge m_SortedEdges;
                /*0x58*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntersectNode> m_IntersectList;
                /*0x60*/ System.Collections.Generic.IComparer<UnityEngine.Rendering.Universal.IntersectNode> m_IntersectNodeComparer;
                /*0x68*/ bool m_ExecuteLocked;
                /*0x6c*/ UnityEngine.Rendering.Universal.PolyFillType m_ClipFillType;
                /*0x70*/ UnityEngine.Rendering.Universal.PolyFillType m_SubjFillType;
                /*0x78*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Join> m_Joins;
                /*0x80*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Join> m_GhostJoins;
                /*0x88*/ bool m_UsingPolyTree;
                /*0x8c*/ int <LastIndex>k__BackingField;
                /*0x90*/ bool <ReverseSolution>k__BackingField;
                /*0x91*/ bool <StrictlySimple>k__BackingField;

                static /*0x26a7b24*/ void SwapSides(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                static /*0x26a7b4c*/ void SwapPolyIndexes(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                static /*0x26a8d98*/ int IntersectNodeSort(UnityEngine.Rendering.Universal.IntersectNode node1, UnityEngine.Rendering.Universal.IntersectNode node2);
                static /*0x26a8dbc*/ long Round(double value);
                static /*0x26a6ebc*/ long TopX(UnityEngine.Rendering.Universal.TEdge edge, long currentY);
                static /*0x26a8ff0*/ void ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polys);
                static /*0x26a9158*/ bool Orientation(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly);
                static /*0x26a9e60*/ int PointInPolygon(UnityEngine.Rendering.Universal.IntPoint pt, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path);
                static /*0x26aa034*/ int PointInPolygon(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.OutPt op);
                static /*0x26aa130*/ bool Poly2ContainsPoly1(UnityEngine.Rendering.Universal.OutPt outPt1, UnityEngine.Rendering.Universal.OutPt outPt2);
                static /*0x26aa338*/ UnityEngine.Rendering.Universal.OutRec ParseFirstLeft(UnityEngine.Rendering.Universal.OutRec FirstLeft);
                static /*0x26a9170*/ double Area(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly);
                static /*0x26aa6f0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> SimplifyPolygon(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly, UnityEngine.Rendering.Universal.PolyFillType fillType);
                static /*0x26aa7d0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> SimplifyPolygons(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polys, UnityEngine.Rendering.Universal.PolyFillType fillType);
                static /*0x26aa8b0*/ double DistanceSqrd(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2);
                static /*0x26aa8d0*/ double DistanceFromLineSqrd(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.IntPoint ln1, UnityEngine.Rendering.Universal.IntPoint ln2);
                static /*0x26aa930*/ bool SlopesNearCollinear(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3, double distSqrd);
                static /*0x26aabf8*/ bool PointsAreClose(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, double distSqrd);
                static /*0x26aac20*/ UnityEngine.Rendering.Universal.OutPt ExcludeOp(UnityEngine.Rendering.Universal.OutPt op);
                static /*0x26aac58*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> CleanPolygon(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, double distance);
                static /*0x26ab098*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> CleanPolygons(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polys, double distance);
                static /*0x26ab1f0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> Minkowski(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pattern, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, bool IsSum, bool IsClosed);
                static /*0x26abcec*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> MinkowskiSum(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pattern, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, bool pathIsClosed);
                static /*0x26abda4*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> TranslatePath(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, UnityEngine.Rendering.Universal.IntPoint delta);
                static /*0x26abf70*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> MinkowskiSum(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pattern, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths, bool pathIsClosed);
                static /*0x26ac140*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> MinkowskiDiff(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly1, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly2);
                static /*0x26ac1f4*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> PolyTreeToPaths(UnityEngine.Rendering.Universal.PolyTree polytree);
                static /*0x26ac2a8*/ void AddPolyNodeToPaths(UnityEngine.Rendering.Universal.PolyNode polynode, UnityEngine.Rendering.Universal.Clipper.NodeType nt, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths);
                static /*0x26ac4a8*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> OpenPathsFromPolyTree(UnityEngine.Rendering.Universal.PolyTree polytree);
                static /*0x26ac634*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> ClosedPathsFromPolyTree(UnityEngine.Rendering.Universal.PolyTree polytree);
                /*0x26a38e4*/ Clipper(int InitOptions);
                /*0x26a3a70*/ void InsertMaxima(long X);
                /*0x26a3b40*/ int get_LastIndex();
                /*0x26a3b48*/ void set_LastIndex(int value);
                /*0x26a3b50*/ bool get_ReverseSolution();
                /*0x26a3b58*/ void set_ReverseSolution(bool value);
                /*0x26a3b64*/ bool get_StrictlySimple();
                /*0x26a3b6c*/ void set_StrictlySimple(bool value);
                /*0x26a3b78*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> solution, UnityEngine.Rendering.Universal.PolyFillType FillType);
                /*0x26a3d24*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, UnityEngine.Rendering.Universal.PolyTree polytree, UnityEngine.Rendering.Universal.PolyFillType FillType);
                /*0x26a3b80*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> solution, UnityEngine.Rendering.Universal.PolyFillType subjFillType, UnityEngine.Rendering.Universal.PolyFillType clipFillType);
                /*0x26a3d2c*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, UnityEngine.Rendering.Universal.PolyTree polytree, UnityEngine.Rendering.Universal.PolyFillType subjFillType, UnityEngine.Rendering.Universal.PolyFillType clipFillType);
                /*0x26a4938*/ void FixHoleLinkage(UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x26a3e18*/ bool ExecuteInternal();
                /*0x26a5cf8*/ void DisposeAllPolyPts();
                /*0x26a5d9c*/ void AddJoin(UnityEngine.Rendering.Universal.OutPt Op1, UnityEngine.Rendering.Universal.OutPt Op2, UnityEngine.Rendering.Universal.IntPoint OffPt);
                /*0x26a5ea4*/ void AddGhostJoin(UnityEngine.Rendering.Universal.OutPt Op, UnityEngine.Rendering.Universal.IntPoint OffPt);
                /*0x26a4990*/ void InsertLocalMinimaIntoAEL(long botY);
                /*0x26a5f9c*/ void InsertEdgeIntoAEL(UnityEngine.Rendering.Universal.TEdge edge, UnityEngine.Rendering.Universal.TEdge startEdge);
                /*0x26a6e50*/ bool E2InsertsBeforeE1(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2);
                /*0x26a6f2c*/ bool IsEvenOddFillType(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x26a6f60*/ bool IsEvenOddAltFillType(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x26a6270*/ bool IsContributing(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x26a6044*/ void SetWindingCount(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x26a67a4*/ void AddEdgeToSEL(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x26a6f94*/ bool PopEdgeFromSEL(ref UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a6fc8*/ void CopyAELToSEL();
                /*0x26a6fe8*/ void SwapPositionsInSEL(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                /*0x26a70c4*/ void AddLocalMaxPoly(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x26a65b0*/ UnityEngine.Rendering.Universal.OutPt AddLocalMinPoly(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x26a63dc*/ UnityEngine.Rendering.Universal.OutPt AddOutPt(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x26a74a8*/ UnityEngine.Rendering.Universal.OutPt GetLastOutPt(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a7520*/ void SwapPoints(ref UnityEngine.Rendering.Universal.IntPoint pt1, ref UnityEngine.Rendering.Universal.IntPoint pt2);
                /*0x26a67dc*/ bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b);
                /*0x26a73cc*/ void SetHoleState(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x26a7544*/ double GetDx(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2);
                /*0x26a757c*/ bool FirstIsBottomPt(UnityEngine.Rendering.Universal.OutPt btmPt1, UnityEngine.Rendering.Universal.OutPt btmPt2);
                /*0x26a7888*/ UnityEngine.Rendering.Universal.OutPt GetBottomPt(UnityEngine.Rendering.Universal.OutPt pp);
                /*0x26a7984*/ UnityEngine.Rendering.Universal.OutRec GetLowermostRec(UnityEngine.Rendering.Universal.OutRec outRec1, UnityEngine.Rendering.Universal.OutRec outRec2);
                /*0x26a7a54*/ bool OutRec1RightOfOutRec2(UnityEngine.Rendering.Universal.OutRec outRec1, UnityEngine.Rendering.Universal.OutRec outRec2);
                /*0x26a7a84*/ UnityEngine.Rendering.Universal.OutRec GetOutRec(int idx);
                /*0x26a7190*/ void AppendPolygon(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2);
                /*0x26a551c*/ void ReversePolyPtLinks(UnityEngine.Rendering.Universal.OutPt pp);
                /*0x26a680c*/ void IntersectEdges(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x26a7b74*/ void DeleteFromSEL(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a4e6c*/ void ProcessHorizontals();
                /*0x26a831c*/ void GetHorzDirection(UnityEngine.Rendering.Universal.TEdge HorzEdge, ref UnityEngine.Rendering.Universal.Direction Dir, ref long Left, ref long Right);
                /*0x26a7bc4*/ void ProcessHorizontal(UnityEngine.Rendering.Universal.TEdge horzEdge);
                /*0x26a83cc*/ UnityEngine.Rendering.Universal.TEdge GetNextInAEL(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.Direction Direction);
                /*0x26a83f4*/ bool IsMinima(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a8438*/ bool IsMaxima(UnityEngine.Rendering.Universal.TEdge e, double Y);
                /*0x26a8464*/ bool IsIntermediate(UnityEngine.Rendering.Universal.TEdge e, double Y);
                /*0x26a835c*/ UnityEngine.Rendering.Universal.TEdge GetMaximaPair(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a849c*/ UnityEngine.Rendering.Universal.TEdge GetMaximaPairEx(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a4eac*/ bool ProcessIntersections(long topY);
                /*0x26a84d8*/ void BuildIntersectList(long topY);
                /*0x26a8d58*/ bool EdgesAdjacent(UnityEngine.Rendering.Universal.IntersectNode inode);
                /*0x26a86bc*/ bool FixupIntersectionOrder();
                /*0x26a88b4*/ void ProcessIntersectList();
                /*0x26a89b8*/ void IntersectPoint(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2, ref UnityEngine.Rendering.Universal.IntPoint ip);
                /*0x26a5028*/ void ProcessEdgesAtTopOfScanbeam(long topY);
                /*0x26a8df0*/ void DoMaxima(UnityEngine.Rendering.Universal.TEdge e);
                /*0x26a929c*/ int PointCount(UnityEngine.Rendering.Universal.OutPt pts);
                /*0x26a4314*/ void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polyg);
                /*0x26a45cc*/ void BuildResult2(UnityEngine.Rendering.Universal.PolyTree polytree);
                /*0x26a5870*/ void FixupOutPolyline(UnityEngine.Rendering.Universal.OutRec outrec);
                /*0x26a5914*/ void FixupOutPolygon(UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x26a92cc*/ UnityEngine.Rendering.Universal.OutPt DupOutPt(UnityEngine.Rendering.Universal.OutPt outPt, bool InsertAfter);
                /*0x26a9398*/ bool GetOverlap(long a1, long a2, long b1, long b2, ref long Left, ref long Right);
                /*0x26a94b0*/ bool JoinHorz(UnityEngine.Rendering.Universal.OutPt op1, UnityEngine.Rendering.Universal.OutPt op1b, UnityEngine.Rendering.Universal.OutPt op2, UnityEngine.Rendering.Universal.OutPt op2b, UnityEngine.Rendering.Universal.IntPoint Pt, bool DiscardLeft);
                /*0x26a981c*/ bool JoinPoints(UnityEngine.Rendering.Universal.Join j, UnityEngine.Rendering.Universal.OutRec outRec1, UnityEngine.Rendering.Universal.OutRec outRec2);
                /*0x26aa1a0*/ void FixupFirstLefts1(UnityEngine.Rendering.Universal.OutRec OldOutRec, UnityEngine.Rendering.Universal.OutRec NewOutRec);
                /*0x26aa350*/ void FixupFirstLefts2(UnityEngine.Rendering.Universal.OutRec innerOutRec, UnityEngine.Rendering.Universal.OutRec outerOutRec);
                /*0x26aa550*/ void FixupFirstLefts3(UnityEngine.Rendering.Universal.OutRec OldOutRec, UnityEngine.Rendering.Universal.OutRec NewOutRec);
                /*0x26a554c*/ void JoinCommonEdges();
                /*0x26aa6bc*/ void UpdateOutPtIdxs(UnityEngine.Rendering.Universal.OutRec outrec);
                /*0x26a5af4*/ void DoSimplePolygons();
                /*0x26a5504*/ double Area(UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x26a782c*/ double Area(UnityEngine.Rendering.Universal.OutPt op);

                enum NodeType
                {
                    ntAny = 0,
                    ntOpen = 1,
                    ntClosed = 2,
                }
            }

            class ClipperOffset
            {
                static double two_pi = 6.283185307179586;
                static double def_arc_tolerance = 0.25;
                /*0x10*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> m_destPolys;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> m_srcPoly;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> m_destPoly;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DoublePoint> m_normals;
                /*0x30*/ double m_delta;
                /*0x38*/ double m_sinA;
                /*0x40*/ double m_sin;
                /*0x48*/ double m_cos;
                /*0x50*/ double m_StepsPerRad;
                /*0x58*/ UnityEngine.Rendering.Universal.IntPoint m_lowest;
                /*0x88*/ UnityEngine.Rendering.Universal.PolyNode m_polyNodes;
                /*0x90*/ double <ArcTolerance>k__BackingField;

                static /*0x26ac838*/ long Round(double value);
                static /*0x26ad0d4*/ UnityEngine.Rendering.Universal.DoublePoint GetUnitNormal(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2);
                /*0x26ac6f8*/ ClipperOffset(double arcTolerance);
                /*0x26ac6e8*/ double get_ArcTolerance();
                /*0x26ac6f0*/ void set_ArcTolerance(double value);
                /*0x26ac7c0*/ void Clear();
                /*0x26ac86c*/ void AddPath(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, UnityEngine.Rendering.Universal.JoinType joinType, UnityEngine.Rendering.Universal.EndType endType);
                /*0x26acdf4*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths, UnityEngine.Rendering.Universal.JoinType joinType, UnityEngine.Rendering.Universal.EndType endType);
                /*0x26acf48*/ void FixOrientations();
                /*0x26ad194*/ void DoOffset(double delta);
                /*0x26aed08*/ void Execute(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> solution, double delta, int inputSize);
                /*0x26af1f4*/ void Execute(ref UnityEngine.Rendering.Universal.PolyTree solution, double delta);
                /*0x26adf60*/ void OffsetPoint(int j, ref int k, UnityEngine.Rendering.Universal.JoinType jointype);
                /*0x26af810*/ void DoSquare(int j, int k);
                /*0x26afddc*/ void DoMiter(int j, int k, double r);
                /*0x26ae7d8*/ void DoRound(int j, int k);
            }

            class ClipperException : System.Exception
            {
                /*0x26b00b8*/ ClipperException(string description);
            }

            class Light2D : UnityEngine.U2D.Light2DBase, UnityEngine.ISerializationCallbackReceiver
            {
                static UnityEngine.Rendering.Universal.Light2D.ComponentVersions k_CurrentComponentVersion = 1;
                /*0x18*/ UnityEngine.Rendering.Universal.Light2D.ComponentVersions m_ComponentVersion;
                /*0x1c*/ UnityEngine.Rendering.Universal.Light2D.LightType m_LightType;
                /*0x20*/ int m_BlendStyleIndex;
                /*0x24*/ float m_FalloffIntensity;
                /*0x28*/ UnityEngine.Color m_Color;
                /*0x38*/ float m_Intensity;
                /*0x3c*/ float m_LightVolumeIntensity;
                /*0x40*/ bool m_LightVolumeIntensityEnabled;
                /*0x48*/ int[] m_ApplyToSortingLayers;
                /*0x50*/ UnityEngine.Sprite m_LightCookieSprite;
                /*0x58*/ UnityEngine.Sprite m_DeprecatedPointLightCookieSprite;
                /*0x60*/ int m_LightOrder;
                /*0x64*/ bool m_AlphaBlendOnOverlap;
                /*0x68*/ UnityEngine.Rendering.Universal.Light2D.OverlapOperation m_OverlapOperation;
                /*0x6c*/ float m_NormalMapDistance;
                /*0x70*/ UnityEngine.Rendering.Universal.Light2D.NormalMapQuality m_NormalMapQuality;
                /*0x74*/ bool m_UseNormalMap;
                /*0x75*/ bool m_ShadowIntensityEnabled;
                /*0x78*/ float m_ShadowIntensity;
                /*0x7c*/ bool m_ShadowVolumeIntensityEnabled;
                /*0x80*/ float m_ShadowVolumeIntensity;
                /*0x88*/ UnityEngine.Mesh m_Mesh;
                /*0x90*/ UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex[] m_Vertices;
                /*0x98*/ ushort[] m_Triangles;
                /*0xa0*/ int m_PreviousLightCookieSprite;
                /*0xa4*/ UnityEngine.Vector3 m_CachedPosition;
                /*0xb0*/ UnityEngine.Bounds m_LocalBounds;
                /*0xc8*/ UnityEngine.BoundingSphere <boundingSphere>k__BackingField;
                /*0xd8*/ bool forceUpdate;
                /*0xdc*/ float m_PointLightInnerAngle;
                /*0xe0*/ float m_PointLightOuterAngle;
                /*0xe4*/ float m_PointLightInnerRadius;
                /*0xe8*/ float m_PointLightOuterRadius;
                /*0xec*/ int m_ShapeLightParametricSides;
                /*0xf0*/ float m_ShapeLightParametricAngleOffset;
                /*0xf4*/ float m_ShapeLightParametricRadius;
                /*0xf8*/ float m_ShapeLightFalloffSize;
                /*0xfc*/ UnityEngine.Vector2 m_ShapeLightFalloffOffset;
                /*0x108*/ UnityEngine.Vector3[] m_ShapePath;
                /*0x110*/ float m_PreviousShapeLightFalloffSize;
                /*0x114*/ int m_PreviousShapeLightParametricSides;
                /*0x118*/ float m_PreviousShapeLightParametricAngleOffset;
                /*0x11c*/ float m_PreviousShapeLightParametricRadius;
                /*0x120*/ int m_PreviousShapePathHash;
                /*0x124*/ UnityEngine.Rendering.Universal.Light2D.LightType m_PreviousLightType;

                /*0x26b2990*/ Light2D();
                /*0x26b0120*/ UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex[] get_vertices();
                /*0x26b0128*/ void set_vertices(UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex[] value);
                /*0x26b0130*/ ushort[] get_indices();
                /*0x26b0138*/ void set_indices(ushort[] value);
                /*0x26b0140*/ int[] get_affectedSortingLayers();
                /*0x26b0148*/ int get_lightCookieSpriteInstanceID();
                /*0x26b015c*/ UnityEngine.BoundingSphere get_boundingSphere();
                /*0x26b0168*/ void set_boundingSphere(UnityEngine.BoundingSphere value);
                /*0x26b0174*/ UnityEngine.Mesh get_lightMesh();
                /*0x26b021c*/ bool get_hasCachedMesh();
                /*0x26b025c*/ UnityEngine.Rendering.Universal.Light2D.LightType get_lightType();
                /*0x26b0264*/ void set_lightType(UnityEngine.Rendering.Universal.Light2D.LightType value);
                /*0x26b05c8*/ int get_blendStyleIndex();
                /*0x26b05d0*/ void set_blendStyleIndex(int value);
                /*0x26b05d8*/ float get_shadowIntensity();
                /*0x26b05e0*/ void set_shadowIntensity(float value);
                /*0x26b05fc*/ bool get_shadowsEnabled();
                /*0x26b0604*/ void set_shadowsEnabled(bool value);
                /*0x26b0610*/ float get_shadowVolumeIntensity();
                /*0x26b0618*/ void set_shadowVolumeIntensity(float value);
                /*0x26b0634*/ bool get_volumetricShadowsEnabled();
                /*0x26b063c*/ void set_volumetricShadowsEnabled(bool value);
                /*0x26b0648*/ UnityEngine.Color get_color();
                /*0x26b0654*/ void set_color(UnityEngine.Color value);
                /*0x26b0660*/ float get_intensity();
                /*0x26b0668*/ void set_intensity(float value);
                /*0x26b0670*/ float get_volumeOpacity();
                /*0x26b0678*/ float get_volumeIntensity();
                /*0x26b0680*/ bool get_volumeIntensityEnabled();
                /*0x26b0688*/ void set_volumeIntensityEnabled(bool value);
                /*0x26b0694*/ UnityEngine.Sprite get_lightCookieSprite();
                /*0x26b06b0*/ void set_lightCookieSprite(UnityEngine.Sprite value);
                /*0x26b06b8*/ float get_falloffIntensity();
                /*0x26b06c0*/ void set_falloffIntensity(float value);
                /*0x26b06dc*/ bool get_alphaBlendOnOverlap();
                /*0x26b06ec*/ UnityEngine.Rendering.Universal.Light2D.OverlapOperation get_overlapOperation();
                /*0x26b06f4*/ void set_overlapOperation(UnityEngine.Rendering.Universal.Light2D.OverlapOperation value);
                /*0x26b06fc*/ int get_lightOrder();
                /*0x26b0704*/ void set_lightOrder(int value);
                /*0x26b070c*/ float get_normalMapDistance();
                /*0x26b0714*/ UnityEngine.Rendering.Universal.Light2D.NormalMapQuality get_normalMapQuality();
                /*0x26b071c*/ bool get_renderVolumetricShadows();
                /*0x26b073c*/ void MarkForUpdate();
                /*0x26b0748*/ void CacheValues();
                /*0x26b0778*/ int GetTopMostLitLayer();
                /*0x26b094c*/ UnityEngine.Bounds UpdateSpriteMesh();
                /*0x26b02d8*/ void UpdateMesh(bool forceUpdate);
                /*0x26b21dc*/ void UpdateBoundingSphere();
                /*0x26b23e8*/ bool IsLitLayer(int layer);
                /*0x26b2440*/ void Awake();
                /*0x26b25d4*/ void OnEnable();
                /*0x26b273c*/ void OnDisable();
                /*0x26b2840*/ void LateUpdate();
                /*0x26b2870*/ void OnBeforeSerialize();
                /*0x26b287c*/ void OnAfterDeserialize();
                /*0x26b28f0*/ float get_pointLightInnerAngle();
                /*0x26b28f8*/ void set_pointLightInnerAngle(float value);
                /*0x26b2900*/ float get_pointLightOuterAngle();
                /*0x26b2908*/ void set_pointLightOuterAngle(float value);
                /*0x26b2910*/ float get_pointLightInnerRadius();
                /*0x26b2918*/ void set_pointLightInnerRadius(float value);
                /*0x26b2920*/ float get_pointLightOuterRadius();
                /*0x26b2928*/ void set_pointLightOuterRadius(float value);
                /*0x26b2930*/ float get_pointLightDistance();
                /*0x26b2938*/ UnityEngine.Rendering.Universal.Light2D.NormalMapQuality get_pointLightQuality();
                /*0x26b23d8*/ bool get_isPointLight();
                /*0x26b2940*/ int get_shapeLightParametricSides();
                /*0x26b2948*/ float get_shapeLightParametricAngleOffset();
                /*0x26b2950*/ float get_shapeLightParametricRadius();
                /*0x26b2958*/ void set_shapeLightParametricRadius(float value);
                /*0x26b2960*/ float get_shapeLightFalloffSize();
                /*0x26b2968*/ void set_shapeLightFalloffSize(float value);
                /*0x26b2978*/ UnityEngine.Vector3[] get_shapePath();
                /*0x26b2980*/ void set_shapePath(UnityEngine.Vector3[] value);
                /*0x26b2988*/ void SetShapePath(UnityEngine.Vector3[] path);

                enum DeprecatedLightType
                {
                    Parametric = 0,
                }

                enum LightType
                {
                    Parametric = 0,
                    Freeform = 1,
                    Sprite = 2,
                    Point = 3,
                    Global = 4,
                }

                enum NormalMapQuality
                {
                    Disabled = 2,
                    Fast = 0,
                    Accurate = 1,
                }

                enum OverlapOperation
                {
                    Additive = 0,
                    AlphaBlend = 1,
                }

                enum ComponentVersions
                {
                    Version_Unserialized = 0,
                    Version_1 = 1,
                }
            }

            struct Light2DBlendStyle
            {
                /*0x10*/ string name;
                /*0x18*/ UnityEngine.Rendering.Universal.Light2DBlendStyle.TextureChannel maskTextureChannel;
                /*0x1c*/ UnityEngine.Rendering.Universal.Light2DBlendStyle.BlendMode blendMode;
                /*0x20*/ bool <isDirty>k__BackingField;
                /*0x21*/ bool <hasRenderTarget>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.Universal.RenderTargetHandle renderTargetHandle;

                /*0x26b2aec*/ UnityEngine.Vector2 get_blendFactors();
                /*0x26b2b20*/ UnityEngine.Rendering.Universal.Light2DBlendStyle.MaskChannelFilter get_maskTextureChannelFilter();
                /*0x26b2c74*/ bool get_isDirty();
                /*0x26b2c7c*/ void set_isDirty(bool value);
                /*0x26b2c88*/ bool get_hasRenderTarget();
                /*0x26b2c90*/ void set_hasRenderTarget(bool value);

                enum TextureChannel
                {
                    None = 0,
                    R = 1,
                    G = 2,
                    B = 3,
                    A = 4,
                    OneMinusR = 5,
                    OneMinusG = 6,
                    OneMinusB = 7,
                    OneMinusA = 8,
                }

                struct MaskChannelFilter
                {
                    /*0x10*/ UnityEngine.Vector4 <mask>k__BackingField;
                    /*0x20*/ UnityEngine.Vector4 <inverted>k__BackingField;

                    /*0x26b2c60*/ MaskChannelFilter(UnityEngine.Vector4 m, UnityEngine.Vector4 i);
                    /*0x26b2c9c*/ UnityEngine.Vector4 get_mask();
                    /*0x26b2ca8*/ void set_mask(UnityEngine.Vector4 value);
                    /*0x26b2cb4*/ UnityEngine.Vector4 get_inverted();
                    /*0x26b2cc0*/ void set_inverted(UnityEngine.Vector4 value);
                }

                enum BlendMode
                {
                    Additive = 0,
                    Multiply = 1,
                    Subtractive = 2,
                }

                struct BlendFactors
                {
                    /*0x10*/ float multiplicative;
                    /*0x14*/ float additive;
                }
            }

            struct LightStats
            {
                /*0x10*/ int totalLights;
                /*0x14*/ int totalNormalMapUsage;
                /*0x18*/ int totalVolumetricUsage;
                /*0x1c*/ uint blendStylesUsed;
                /*0x20*/ uint blendStylesWithLights;
            }

            interface ILight2DCullResult
            {
                System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> get_visibleLights();
                UnityEngine.Rendering.Universal.LightStats GetLightStatsByLayer(int layer);
                bool IsSceneLit();
            }

            class Light2DCullResult : UnityEngine.Rendering.Universal.ILight2DCullResult
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> m_VisibleLights;

                /*0x26b3448*/ Light2DCullResult();
                /*0x26b2ccc*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> get_visibleLights();
                /*0x26b2cd4*/ bool IsSceneLit();
                /*0x26b2d7c*/ UnityEngine.Rendering.Universal.LightStats GetLightStatsByLayer(int layer);
                /*0x26b2f44*/ void SetupCulling(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, UnityEngine.Camera camera);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Light2DCullResult.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Rendering.Universal.Light2D> <>9__5_0;

                    static /*0x26b34c4*/ <>c();
                    /*0x26b3528*/ <>c();
                    /*0x26b3530*/ int <SetupCulling>b__5_0(UnityEngine.Rendering.Universal.Light2D l1, UnityEngine.Rendering.Universal.Light2D l2);
                }
            }

            class Light2DManager
            {
                static /*0x0*/ UnityEngine.SortingLayer[] s_SortingLayers;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> <lights>k__BackingField;

                static /*0x26b39bc*/ Light2DManager();
                static /*0x26b3554*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> get_lights();
                static /*0x26b263c*/ void RegisterLight(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26b2790*/ void DeregisterLight(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26b044c*/ void ErrorIfDuplicateGlobalLight(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26b37ac*/ bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, ref UnityEngine.Color color);
                static /*0x26b35ac*/ bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex);
                static /*0x26b08a8*/ UnityEngine.SortingLayer[] GetCachedSortingLayer();
            }

            class LightUtility
            {
                static /*0x26b0ffc*/ bool CheckForChange(UnityEngine.Rendering.Universal.Light2D.LightType a, ref UnityEngine.Rendering.Universal.Light2D.LightType b);
                static /*0x26b0fe4*/ bool CheckForChange(int a, ref int b);
                static /*0x26b0fcc*/ bool CheckForChange(float a, ref float b);
                static /*0x26b3a48*/ bool CheckForChange(bool a, ref bool b);
                static /*0x26b3a60*/ void Tessellate(UnityEngine.Rendering.Universal.LibTessDotNet.Tess tess, UnityEngine.Rendering.Universal.LibTessDotNet.ElementType boundaryType, Unity.Collections.NativeArray<ushort> indices, Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex> vertices, UnityEngine.Color c, ref int VCount, ref int ICount);
                static /*0x26b41f0*/ bool TestPivot(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, int activePoint, long lastPoint);
                static /*0x26b42c4*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> DegeneratePivots(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> inPath);
                static /*0x26b46a0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> SortPivots(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> outPath, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> inPath);
                static /*0x26b48b8*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> FixPivots(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> outPath, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> inPath);
                static /*0x26b4bb8*/ System.Collections.Generic.List<UnityEngine.Vector2> GetOutlinePath(UnityEngine.Vector3[] shapePath, float offsetDistance);
                static /*0x26b4fc8*/ void TransferToMesh(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex> vertices, int vertexCount, Unity.Collections.NativeArray<ushort> indices, int indexCount, UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26b1014*/ UnityEngine.Bounds GenerateShapeMesh(UnityEngine.Rendering.Universal.Light2D light, UnityEngine.Vector3[] shapePath, float falloffDistance);
                static /*0x26b1a20*/ UnityEngine.Bounds GenerateParametricMesh(UnityEngine.Rendering.Universal.Light2D light, float radius, float falloffDistance, float angle, int sides);
                static /*0x26b0a58*/ UnityEngine.Bounds GenerateSpriteMesh(UnityEngine.Rendering.Universal.Light2D light, UnityEngine.Sprite sprite);
                static /*0x26b0ee0*/ int GetShapePathHash(UnityEngine.Vector3[] path);

                enum PivotType
                {
                    PivotBase = 0,
                    PivotCurve = 1,
                    PivotIntersect = 2,
                    PivotSkip = 3,
                    PivotClip = 4,
                }

                struct LightMeshVertex
                {
                    static /*0x0*/ UnityEngine.Rendering.VertexAttributeDescriptor[] VertexLayout;
                    /*0x10*/ UnityEngine.Vector3 position;
                    /*0x1c*/ UnityEngine.Color color;
                    /*0x2c*/ UnityEngine.Vector2 uv;

                    static /*0x26b51b0*/ LightMeshVertex();
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ UnityEngine.Color c;

                    /*0x26b41e8*/ <>c__DisplayClass6_0();
                    /*0x26b52c8*/ UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex <Tessellate>b__1(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex v);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.LightUtility.<> <>9;
                    static /*0x8*/ System.Func<int, int> <>9__6_0;

                    static /*0x26b5308*/ <>c();
                    /*0x26b536c*/ <>c();
                    /*0x26b5374*/ int <Tessellate>b__6_0(int i);
                }
            }

            interface IRenderPass2D
            {
                UnityEngine.Rendering.Universal.Renderer2DData get_rendererData();
            }

            class PixelPerfectBackgroundPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingScope;

                static /*0x26b5578*/ PixelPerfectBackgroundPass();
                /*0x26b537c*/ PixelPerfectBackgroundPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x26b53a4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class Render2DLightingPass : UnityEngine.Rendering.Universal.ScriptableRenderPass, UnityEngine.Rendering.Universal.IRenderPass2D
            {
                static /*0x0*/ int k_HDREmulationScaleID;
                static /*0x4*/ int k_InverseHDREmulationScaleID;
                static /*0x8*/ int k_UseSceneLightingID;
                static /*0xc*/ int k_RendererColorID;
                static /*0x10*/ int k_CameraSortingLayerTextureID;
                static /*0x18*/ int[] k_ShapeLightTextureIDs;
                static /*0x20*/ UnityEngine.Rendering.ShaderTagId k_CombinedRenderingPassName;
                static /*0x24*/ UnityEngine.Rendering.ShaderTagId k_NormalsRenderingPassName;
                static /*0x28*/ UnityEngine.Rendering.ShaderTagId k_LegacyPassName;
                static /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_ShaderTags;
                static /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawLights;
                static /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawLightTextures;
                static /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawRenderers;
                static /*0x50*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawLayerBatch;
                static /*0x58*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerUnlit;
                /*0xd8*/ UnityEngine.Material m_BlitMaterial;
                /*0xe0*/ UnityEngine.Material m_SamplingMaterial;
                /*0xe8*/ UnityEngine.Rendering.Universal.Renderer2DData m_Renderer2DData;
                /*0xf0*/ bool m_NeedsDepth;
                /*0xf2*/ short m_CameraSortingLayerBoundsIndex;

                static /*0x26b9c74*/ Render2DLightingPass();
                /*0x26b5608*/ Render2DLightingPass(UnityEngine.Rendering.Universal.Renderer2DData rendererData, UnityEngine.Material blitMaterial, UnityEngine.Material samplingMaterial);
                /*0x26b5730*/ void Setup(bool useDepth);
                /*0x26b573c*/ void GetTransparencySortingMode(UnityEngine.Camera camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
                /*0x26b57dc*/ void CopyCameraSortingLayerRenderTexture(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.RenderBufferStoreAction mainTargetStoreAction);
                /*0x26b5650*/ short GetCameraSortingLayerBoundsIndex();
                /*0x26b5c90*/ void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, UnityEngine.Rendering.Universal.LayerBatch[] layerBatches, ref int resolveDuringBatch, ref bool resolveIsAfterCopy);
                /*0x26b5f24*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.DrawingSettings drawSettings);
                /*0x26b60cc*/ int DrawLayerBatches(UnityEngine.Rendering.Universal.LayerBatch[] layerBatches, int batchCount, int startIndex, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.FilteringSettings filterSettings, ref UnityEngine.Rendering.DrawingSettings normalsDrawSettings, ref UnityEngine.Rendering.DrawingSettings drawSettings, ref UnityEngine.RenderTextureDescriptor desc);
                /*0x26b873c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26b9c6c*/ UnityEngine.Rendering.Universal.Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.get_rendererData();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Render2DLightingPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.Universal.DebugHandler.DrawFunction <>9__26_0;

                    static /*0x26ba1b0*/ <>c();
                    /*0x26ba214*/ <>c();
                    /*0x26ba21c*/ void <Render>b__26_0(UnityEngine.Rendering.ScriptableRenderContext ctx, ref UnityEngine.Rendering.Universal.RenderingData data, ref UnityEngine.Rendering.DrawingSettings ds, ref UnityEngine.Rendering.FilteringSettings fs, ref UnityEngine.Rendering.RenderStateBlock rsb);
                }
            }

            struct LayerBatch
            {
                /*0x10*/ int startLayerID;
                /*0x14*/ int endLayerValue;
                /*0x18*/ UnityEngine.Rendering.SortingLayerRange layerRange;
                /*0x1c*/ UnityEngine.Rendering.Universal.LightStats lightStats;
                /*0x30*/ UnityEngine.Rendering.Universal.LayerBatch.<renderTargetIds> renderTargetIds;
                /*0x40*/ UnityEngine.Rendering.Universal.LayerBatch.<renderTargetUsed> renderTargetUsed;

                /*0x26ba23c*/ void InitRTIds(int index);
                /*0x26b7d58*/ UnityEngine.Rendering.RenderTargetIdentifier GetRTId(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor desc, int index);
                /*0x26b86dc*/ void ReleaseRT(UnityEngine.Rendering.CommandBuffer cmd);

                struct <renderTargetIds>e__FixedBuffer
                {
                    /*0x10*/ int FixedElementField;
                }

                struct <renderTargetUsed>e__FixedBuffer
                {
                    /*0x10*/ bool FixedElementField;
                }
            }

            class LayerUtility
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.LayerBatch[] s_LayerBatches;
                static /*0x8*/ uint <maxTextureCount>k__BackingField;

                static /*0x26ba310*/ uint get_maxTextureCount();
                static /*0x26ba358*/ void set_maxTextureCount(uint value);
                static /*0x26b915c*/ void InitializeBudget(uint maxTextureCount);
                static /*0x26ba3a4*/ bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, UnityEngine.SortingLayer[] sortingLayers, UnityEngine.Rendering.Universal.ILight2DCullResult lightCullResult);
                static /*0x26ba618*/ int FindUpperBoundInBatch(int startLayerIndex, UnityEngine.SortingLayer[] sortingLayers, UnityEngine.Rendering.Universal.ILight2DCullResult lightCullResult);
                static /*0x26ba680*/ void InitializeBatchInfos(UnityEngine.SortingLayer[] cachedSortingLayers);
                static /*0x26b970c*/ UnityEngine.Rendering.Universal.LayerBatch[] CalculateBatches(UnityEngine.Rendering.Universal.ILight2DCullResult lightCullResult, ref int batchCount);
            }

            class Light2DLookupTexture
            {
                static /*0x0*/ UnityEngine.Texture2D s_PointLightLookupTexture;

                static /*0x26ba758*/ UnityEngine.Texture GetLightLookupTexture();
                static /*0x26ba7f4*/ UnityEngine.Texture2D CreatePointLightLookupTexture();
            }

            class RendererLighting
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                static /*0x8*/ UnityEngine.Rendering.ShaderTagId k_NormalsRenderingPassName;
                static /*0xc*/ UnityEngine.Color k_NormalClearColor;
                static /*0x20*/ string k_SpriteLightKeyword;
                static /*0x28*/ string k_UsePointLightCookiesKeyword;
                static /*0x30*/ string k_LightQualityFastKeyword;
                static /*0x38*/ string k_UseNormalMap;
                static /*0x40*/ string k_UseAdditiveBlendingKeyword;
                static /*0x48*/ string[] k_UseBlendStyleKeywords;
                static /*0x50*/ int[] k_BlendFactorsPropIDs;
                static /*0x58*/ int[] k_MaskFilterPropIDs;
                static /*0x60*/ int[] k_InvertedFilterPropIDs;
                static /*0x68*/ UnityEngine.Experimental.Rendering.GraphicsFormat s_RenderTextureFormatToUse;
                static /*0x6c*/ bool s_HasSetupRenderTextureFormatToUse;
                static /*0x70*/ int k_SrcBlendID;
                static /*0x74*/ int k_DstBlendID;
                static /*0x78*/ int k_FalloffIntensityID;
                static /*0x7c*/ int k_FalloffDistanceID;
                static /*0x80*/ int k_LightColorID;
                static /*0x84*/ int k_VolumeOpacityID;
                static /*0x88*/ int k_CookieTexID;
                static /*0x8c*/ int k_FalloffLookupID;
                static /*0x90*/ int k_LightPositionID;
                static /*0x94*/ int k_LightInvMatrixID;
                static /*0x98*/ int k_InnerRadiusMultID;
                static /*0x9c*/ int k_OuterAngleID;
                static /*0xa0*/ int k_InnerAngleMultID;
                static /*0xa4*/ int k_LightLookupID;
                static /*0xa8*/ int k_IsFullSpotlightID;
                static /*0xac*/ int k_LightZDistanceID;
                static /*0xb0*/ int k_PointLightCookieTexID;

                static /*0x26bca2c*/ RendererLighting();
                static /*0x26bab88*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetRenderTextureFormat();
                static /*0x26bac90*/ void CreateNormalMapRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, float renderScale);
                static /*0x26b9550*/ UnityEngine.RenderTextureDescriptor GetBlendStyleRenderTextureDesc(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x26b5ab0*/ void CreateCameraSortingLayerRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Downsampling downsamplingMethod);
                static /*0x26b7e28*/ void EnableBlendStyle(UnityEngine.Rendering.CommandBuffer cmd, int blendStyleIndex, bool enabled);
                static /*0x26b9968*/ void DisableAllKeywords(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x26b9a1c*/ void ReleaseRenderTextures(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x26bb0d0*/ void DrawPointLight(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Light2D light, UnityEngine.Mesh lightMesh, UnityEngine.Material material);
                static /*0x26bb1f4*/ bool CanCastShadows(UnityEngine.Rendering.Universal.Light2D light, int layerToRender);
                static /*0x26bb228*/ bool CanCastVolumetricShadows(UnityEngine.Rendering.Universal.Light2D light, int endLayerValue);
                static /*0x26bb278*/ bool ShouldRenderLight(UnityEngine.Rendering.Universal.Light2D light, int blendStyleIndex, int layerToRender);
                static /*0x26bb328*/ void RenderLightSet(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, int blendStyleIndex, UnityEngine.Rendering.CommandBuffer cmd, int layerToRender, UnityEngine.Rendering.RenderTargetIdentifier renderTexture, System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> lights);
                static /*0x26b7ed4*/ void RenderLightVolumes(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, int layerToRender, int endLayerValue, UnityEngine.Rendering.RenderTargetIdentifier renderTexture, UnityEngine.Rendering.RenderTargetIdentifier depthTexture, UnityEngine.Rendering.RenderBufferStoreAction intermediateStoreAction, UnityEngine.Rendering.RenderBufferStoreAction finalStoreAction, bool requiresRTInit, System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> lights);
                static /*0x26b91b0*/ void SetShapeLightShaderGlobals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x26bc11c*/ float GetNormalizedInnerRadius(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26bc138*/ float GetNormalizedAngle(float angle);
                static /*0x26bc148*/ void GetScaledLightInvMatrix(UnityEngine.Rendering.Universal.Light2D light, ref UnityEngine.Matrix4x4 retMatrix);
                static /*0x26bbc0c*/ void SetGeneralLightShaderGlobals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26bbd18*/ void SetPointLightShaderGlobals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Light2D light);
                static /*0x26bc2a0*/ void ClearDirtyLighting(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd, uint blendStylesUsed);
                static /*0x26b7220*/ void RenderNormals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.DrawingSettings drawSettings, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.RenderTargetIdentifier depthTarget, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.LightStats lightStats);
                static /*0x26b77f8*/ void RenderLights(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, int layerToRender, ref UnityEngine.Rendering.Universal.LayerBatch layerBatch, ref UnityEngine.RenderTextureDescriptor rtDesc);
                static /*0x26bc57c*/ void SetBlendModes(UnityEngine.Material material, UnityEngine.Rendering.BlendMode src, UnityEngine.Rendering.BlendMode dst);
                static /*0x26bc618*/ uint GetLightMaterialIndex(UnityEngine.Rendering.Universal.Light2D light, bool isVolume);
                static /*0x26bc770*/ UnityEngine.Material CreateLightMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, UnityEngine.Rendering.Universal.Light2D light, bool isVolume);
                static /*0x26bbb04*/ UnityEngine.Material GetLightMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, UnityEngine.Rendering.Universal.Light2D light, bool isVolume);
            }

            interface IPixelPerfectCamera
            {
                int get_assetsPPU();
                void set_assetsPPU(int value);
                int get_refResolutionX();
                void set_refResolutionX(int value);
                int get_refResolutionY();
                void set_refResolutionY(int value);
                bool get_upscaleRT();
                void set_upscaleRT(bool value);
                bool get_pixelSnapping();
                void set_pixelSnapping(bool value);
                bool get_cropFrameX();
                void set_cropFrameX(bool value);
                bool get_cropFrameY();
                void set_cropFrameY(bool value);
                bool get_stretchFill();
                void set_stretchFill(bool value);
            }

            class PixelPerfectCameraInternal : UnityEngine.ISerializationCallbackReceiver
            {
                /*0x10*/ UnityEngine.Rendering.Universal.IPixelPerfectCamera m_Component;
                /*0x18*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera m_SerializableComponent;
                /*0x20*/ float originalOrthoSize;
                /*0x24*/ bool hasPostProcessLayer;
                /*0x25*/ bool cropFrameXAndY;
                /*0x26*/ bool cropFrameXOrY;
                /*0x27*/ bool useStretchFill;
                /*0x28*/ int zoom;
                /*0x2c*/ bool useOffscreenRT;
                /*0x30*/ int offscreenRTWidth;
                /*0x34*/ int offscreenRTHeight;
                /*0x38*/ UnityEngine.Rect pixelRect;
                /*0x48*/ float orthoSize;
                /*0x4c*/ float unitsPerPixel;
                /*0x50*/ int cinemachineVCamZoom;

                /*0x26bd2a0*/ PixelPerfectCameraInternal(UnityEngine.Rendering.Universal.IPixelPerfectCamera component);
                /*0x26bd2f0*/ void OnBeforeSerialize();
                /*0x26bd378*/ void OnAfterDeserialize();
                /*0x26bd3e8*/ void CalculateCameraProperties(int screenWidth, int screenHeight);
                /*0x26bda9c*/ UnityEngine.Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight);
                /*0x26bde10*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
            }

            class Renderer2D : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static int k_DepthBufferBits = 32;
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x190*/ UnityEngine.Rendering.Universal.Render2DLightingPass m_Render2DLightingPass;
                /*0x198*/ UnityEngine.Rendering.Universal.PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass;
                /*0x1a0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass m_FinalBlitPass;
                /*0x1a8*/ UnityEngine.Rendering.Universal.Light2DCullResult m_LightCullResult;
                /*0x1b0*/ bool m_UseDepthStencilBuffer;
                /*0x1b1*/ bool m_CreateColorTexture;
                /*0x1b2*/ bool m_CreateDepthTexture;
                /*0x1b8*/ UnityEngine.Rendering.Universal.RenderTargetHandle k_ColorTextureHandle;
                /*0x1e8*/ UnityEngine.Rendering.Universal.RenderTargetHandle k_DepthTextureHandle;
                /*0x218*/ UnityEngine.Material m_BlitMaterial;
                /*0x220*/ UnityEngine.Material m_SamplingMaterial;
                /*0x228*/ UnityEngine.Rendering.Universal.Renderer2DData m_Renderer2DData;
                /*0x230*/ UnityEngine.Rendering.Universal.PostProcessPasses m_PostProcessPasses;

                static /*0x26bf2cc*/ Renderer2D();
                /*0x26be2ac*/ Renderer2D(UnityEngine.Rendering.Universal.Renderer2DData data);
                /*0x26be234*/ bool get_createColorTexture();
                /*0x26be23c*/ bool get_createDepthTexture();
                /*0x26be244*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x26be24c*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass get_postProcessPass();
                /*0x26be254*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass get_finalPostProcessPass();
                /*0x26be25c*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_afterPostProcessColorHandle();
                /*0x26be280*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_colorGradingLutHandle();
                /*0x26be2a4*/ int SupportedCameraStackingTypes();
                /*0x26be538*/ void Dispose(bool disposing);
                /*0x26be544*/ UnityEngine.Rendering.Universal.Renderer2DData GetRenderer2DData();
                /*0x26be54c*/ void CreateRenderTextures(ref UnityEngine.Rendering.Universal.CameraData cameraData, bool forceCreateColorTexture, UnityEngine.FilterMode colorTextureFilterMode, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderTargetHandle colorTargetHandle, ref UnityEngine.Rendering.Universal.RenderTargetHandle depthTargetHandle);
                /*0x26be8fc*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26bf1f8*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26bf26c*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Renderer2D.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__34_0;

                    static /*0x26bf35c*/ <>c();
                    /*0x26bf3c0*/ <>c();
                    /*0x26bf3c8*/ bool <Setup>b__34_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                }
            }

            class Renderer2DData : UnityEngine.Rendering.Universal.ScriptableRendererData
            {
                /*0x3c*/ UnityEngine.TransparencySortMode m_TransparencySortMode;
                /*0x40*/ UnityEngine.Vector3 m_TransparencySortAxis;
                /*0x4c*/ float m_HDREmulationScale;
                /*0x50*/ float m_LightRenderTextureScale;
                /*0x58*/ UnityEngine.Rendering.Universal.Light2DBlendStyle[] m_LightBlendStyles;
                /*0x60*/ bool m_UseDepthStencilBuffer;
                /*0x61*/ bool m_UseCameraSortingLayersTexture;
                /*0x64*/ int m_CameraSortingLayersTextureBound;
                /*0x68*/ UnityEngine.Rendering.Universal.Downsampling m_CameraSortingLayerDownsamplingMethod;
                /*0x6c*/ uint m_MaxLightRenderTextureCount;
                /*0x70*/ uint m_MaxShadowRenderTextureCount;
                /*0x78*/ UnityEngine.Shader m_ShapeLightShader;
                /*0x80*/ UnityEngine.Shader m_ShapeLightVolumeShader;
                /*0x88*/ UnityEngine.Shader m_PointLightShader;
                /*0x90*/ UnityEngine.Shader m_PointLightVolumeShader;
                /*0x98*/ UnityEngine.Shader m_BlitShader;
                /*0xa0*/ UnityEngine.Shader m_SamplingShader;
                /*0xa8*/ UnityEngine.Shader m_ProjectedShadowShader;
                /*0xb0*/ UnityEngine.Shader m_SpriteShadowShader;
                /*0xb8*/ UnityEngine.Shader m_SpriteUnshadowShader;
                /*0xc0*/ UnityEngine.Shader m_GeometryUnshadowShader;
                /*0xc8*/ UnityEngine.Shader m_FallbackErrorShader;
                /*0xd0*/ UnityEngine.Rendering.Universal.PostProcessData m_PostProcessData;
                /*0xd8*/ UnityEngine.Texture2D m_FallOffLookup;
                /*0xe0*/ System.Collections.Generic.Dictionary<uint, UnityEngine.Material> <lightMaterials>k__BackingField;
                /*0xe8*/ UnityEngine.Material[] <spriteSelfShadowMaterial>k__BackingField;
                /*0xf0*/ UnityEngine.Material[] <spriteUnshadowMaterial>k__BackingField;
                /*0xf8*/ UnityEngine.Material[] <geometryUnshadowMaterial>k__BackingField;
                /*0x100*/ UnityEngine.Material[] <projectedShadowMaterial>k__BackingField;
                /*0x108*/ UnityEngine.Material[] <stencilOnlyShadowMaterial>k__BackingField;
                /*0x110*/ bool <isNormalsRenderTargetValid>k__BackingField;
                /*0x114*/ float <normalsRenderTargetScale>k__BackingField;
                /*0x118*/ UnityEngine.Rendering.Universal.RenderTargetHandle normalsRenderTarget;
                /*0x148*/ UnityEngine.Rendering.Universal.RenderTargetHandle shadowsRenderTarget;
                /*0x178*/ UnityEngine.Rendering.Universal.RenderTargetHandle cameraSortingLayerRenderTarget;
                /*0x1a8*/ UnityEngine.Rendering.Universal.ILight2DCullResult <lightCullResult>k__BackingField;

                /*0x26bf6d4*/ Renderer2DData();
                /*0x26bf3e8*/ float get_hdrEmulationScale();
                /*0x26bf3f0*/ float get_lightRenderTextureScale();
                /*0x26bf3f8*/ UnityEngine.Rendering.Universal.Light2DBlendStyle[] get_lightBlendStyles();
                /*0x26bf400*/ bool get_useDepthStencilBuffer();
                /*0x26bf408*/ UnityEngine.Texture2D get_fallOffLookup();
                /*0x26bf410*/ UnityEngine.Shader get_shapeLightShader();
                /*0x26bf418*/ UnityEngine.Shader get_shapeLightVolumeShader();
                /*0x26bf420*/ UnityEngine.Shader get_pointLightShader();
                /*0x26bf428*/ UnityEngine.Shader get_pointLightVolumeShader();
                /*0x26bf430*/ UnityEngine.Shader get_blitShader();
                /*0x26bf438*/ UnityEngine.Shader get_samplingShader();
                /*0x26bf440*/ UnityEngine.Rendering.Universal.PostProcessData get_postProcessData();
                /*0x26bf448*/ void set_postProcessData(UnityEngine.Rendering.Universal.PostProcessData value);
                /*0x26bf450*/ UnityEngine.Shader get_spriteShadowShader();
                /*0x26bf458*/ UnityEngine.Shader get_spriteUnshadowShader();
                /*0x26bf460*/ UnityEngine.Shader get_geometryUnshadowShader();
                /*0x26bf468*/ UnityEngine.Shader get_projectedShadowShader();
                /*0x26bf470*/ UnityEngine.TransparencySortMode get_transparencySortMode();
                /*0x26bf478*/ UnityEngine.Vector3 get_transparencySortAxis();
                /*0x26bf484*/ uint get_lightRenderTextureMemoryBudget();
                /*0x26bf48c*/ uint get_shadowRenderTextureMemoryBudget();
                /*0x26bf494*/ bool get_useCameraSortingLayerTexture();
                /*0x26bf49c*/ int get_cameraSortingLayerTextureBound();
                /*0x26bf4a4*/ UnityEngine.Rendering.Universal.Downsampling get_cameraSortingLayerDownsamplingMethod();
                /*0x26bf4ac*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x26bf50c*/ void OnEnable();
                /*0x26bf648*/ System.Collections.Generic.Dictionary<uint, UnityEngine.Material> get_lightMaterials();
                /*0x26bf650*/ UnityEngine.Material[] get_spriteSelfShadowMaterial();
                /*0x26bf658*/ void set_spriteSelfShadowMaterial(UnityEngine.Material[] value);
                /*0x26bf660*/ UnityEngine.Material[] get_spriteUnshadowMaterial();
                /*0x26bf668*/ void set_spriteUnshadowMaterial(UnityEngine.Material[] value);
                /*0x26bf670*/ UnityEngine.Material[] get_geometryUnshadowMaterial();
                /*0x26bf678*/ void set_geometryUnshadowMaterial(UnityEngine.Material[] value);
                /*0x26bf680*/ UnityEngine.Material[] get_projectedShadowMaterial();
                /*0x26bf688*/ void set_projectedShadowMaterial(UnityEngine.Material[] value);
                /*0x26bf690*/ UnityEngine.Material[] get_stencilOnlyShadowMaterial();
                /*0x26bf698*/ void set_stencilOnlyShadowMaterial(UnityEngine.Material[] value);
                /*0x26bf6a0*/ bool get_isNormalsRenderTargetValid();
                /*0x26bf6a8*/ void set_isNormalsRenderTargetValid(bool value);
                /*0x26bf6b4*/ float get_normalsRenderTargetScale();
                /*0x26bf6bc*/ void set_normalsRenderTargetScale(float value);
                /*0x26bf6c4*/ UnityEngine.Rendering.Universal.ILight2DCullResult get_lightCullResult();
                /*0x26bf6cc*/ void set_lightCullResult(UnityEngine.Rendering.Universal.ILight2DCullResult value);

                enum Renderer2DDefaultMaterialType
                {
                    Lit = 0,
                    Unlit = 1,
                    Custom = 2,
                }
            }

            class CompositeShadowCaster2D : UnityEngine.Rendering.Universal.ShadowCasterGroup2D
            {
                /*0x26bf7c0*/ CompositeShadowCaster2D();
                /*0x26bf7b0*/ void OnEnable();
                /*0x26bf7b8*/ void OnDisable();
            }

            class ShadowCaster2D : UnityEngine.Rendering.Universal.ShadowCasterGroup2D, UnityEngine.ISerializationCallbackReceiver
            {
                static UnityEngine.Rendering.Universal.ShadowCaster2D.ComponentVersions k_CurrentComponentVersion = 1;
                /*0x28*/ UnityEngine.Rendering.Universal.ShadowCaster2D.ComponentVersions m_ComponentVersion;
                /*0x2c*/ bool m_HasRenderer;
                /*0x2d*/ bool m_UseRendererSilhouette;
                /*0x2e*/ bool m_CastsShadows;
                /*0x2f*/ bool m_SelfShadows;
                /*0x30*/ int[] m_ApplyToSortingLayers;
                /*0x38*/ UnityEngine.Vector3[] m_ShapePath;
                /*0x40*/ int m_ShapePathHash;
                /*0x48*/ UnityEngine.Mesh m_Mesh;
                /*0x50*/ int m_InstanceId;
                /*0x58*/ UnityEngine.Rendering.Universal.ShadowCasterGroup2D m_ShadowCasterGroup;
                /*0x60*/ UnityEngine.Rendering.Universal.ShadowCasterGroup2D m_PreviousShadowCasterGroup;
                /*0x68*/ UnityEngine.BoundingSphere m_ProjectedBoundingSphere;
                /*0x78*/ int m_PreviousShadowGroup;
                /*0x7c*/ bool m_PreviousCastsShadows;
                /*0x80*/ int m_PreviousPathHash;
                /*0x84*/ UnityEngine.Vector3 m_CachedPosition;
                /*0x90*/ UnityEngine.Vector3 m_CachedLossyScale;
                /*0x9c*/ UnityEngine.Quaternion m_CachedRotation;
                /*0xac*/ UnityEngine.Matrix4x4 m_CachedShadowMatrix;
                /*0xec*/ UnityEngine.Matrix4x4 m_CachedInverseShadowMatrix;
                /*0x12c*/ UnityEngine.Matrix4x4 m_CachedLocalToWorldMatrix;

                static /*0x26bf9e4*/ int[] SetDefaultSortingLayers();
                /*0x26c0288*/ ShadowCaster2D();
                /*0x26bf7c8*/ UnityEngine.Mesh get_mesh();
                /*0x26bf7d0*/ UnityEngine.Vector3[] get_shapePath();
                /*0x26bf7d8*/ int get_shapePathHash();
                /*0x26bf7e0*/ void set_shapePathHash(int value);
                /*0x26bf7e8*/ void CacheValues();
                /*0x26bf990*/ void set_useRendererSilhouette(bool value);
                /*0x26bf99c*/ bool get_useRendererSilhouette();
                /*0x26bf9bc*/ void set_selfShadows(bool value);
                /*0x26bf9c8*/ bool get_selfShadows();
                /*0x26bf9d0*/ void set_castsShadows(bool value);
                /*0x26bf9dc*/ bool get_castsShadows();
                /*0x26bfab0*/ bool IsLit(UnityEngine.Rendering.Universal.Light2D light);
                /*0x26bfb18*/ bool IsShadowedLayer(int layer);
                /*0x26bfb78*/ void Awake();
                /*0x26bffa4*/ void OnEnable();
                /*0x26c0084*/ void OnDisable();
                /*0x26c0090*/ void Update();
                /*0x26c024c*/ void OnBeforeSerialize();
                /*0x26c0258*/ void OnAfterDeserialize();

                enum ComponentVersions
                {
                    Version_Unserialized = 0,
                    Version_1 = 1,
                }
            }

            class ShadowCasterGroup2D : UnityEngine.MonoBehaviour
            {
                /*0x18*/ int m_ShadowGroup;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCaster2D> m_ShadowCasters;

                /*0x26c1490*/ ShadowCasterGroup2D();
                /*0x26c12a0*/ void CacheValues();
                /*0x26c1330*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCaster2D> GetShadowCasters();
                /*0x26c1338*/ int GetShadowGroup();
                /*0x26c1340*/ void RegisterShadowCaster2D(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster2D);
                /*0x26c1430*/ void UnregisterShadowCaster2D(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster2D);
            }

            class ShadowCasterGroup2DManager
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> s_ShadowCasterGroups;

                static /*0x26c1498*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> get_shadowCasterGroups();
                static /*0x26c14e0*/ void CacheValues();
                static /*0x26c1648*/ void AddShadowCasterGroupToList(UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCaster, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> list);
                static /*0x26c171c*/ void RemoveShadowCasterGroupFromList(UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCaster, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> list);
                static /*0x26c1774*/ UnityEngine.Rendering.Universal.CompositeShadowCaster2D FindTopMostCompositeShadowCaster(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster);
                static /*0x26c1858*/ bool AddToShadowCasterGroup(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster, ref UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCasterGroup);
                static /*0x26c1970*/ void RemoveFromShadowCasterGroup(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster, UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCasterGroup);
                static /*0x26c1a00*/ void AddGroup(UnityEngine.Rendering.Universal.ShadowCasterGroup2D group);
                static /*0x26c1af4*/ void RemoveGroup(UnityEngine.Rendering.Universal.ShadowCasterGroup2D group);
                /*0x26c1b8c*/ ShadowCasterGroup2DManager();
            }

            class ShadowRendering
            {
                static /*0x0*/ int k_LightPosID;
                static /*0x4*/ int k_SelfShadowingID;
                static /*0x8*/ int k_ShadowStencilGroupID;
                static /*0xc*/ int k_ShadowIntensityID;
                static /*0x10*/ int k_ShadowVolumeIntensityID;
                static /*0x14*/ int k_ShadowRadiusID;
                static /*0x18*/ int k_ShadowColorMaskID;
                static /*0x1c*/ int k_ShadowModelMatrixID;
                static /*0x20*/ int k_ShadowModelInvMatrixID;
                static /*0x24*/ int k_ShadowModelScaleID;
                static /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadows;
                static /*0x30*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsA;
                static /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsR;
                static /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsG;
                static /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsB;
                static /*0x50*/ UnityEngine.Rendering.Universal.RenderTargetHandle[] m_RenderTargets;
                static /*0x58*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_LightInputTextures;
                static /*0x60*/ UnityEngine.Color[] k_ColorLookup;
                static /*0x68*/ UnityEngine.Rendering.ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup;
                static /*0x70*/ uint <maxTextureCount>k__BackingField;

                static /*0x26c3afc*/ ShadowRendering();
                static /*0x26c1b94*/ uint get_maxTextureCount();
                static /*0x26c1bec*/ void set_maxTextureCount(uint value);
                static /*0x26c1c48*/ void InitializeBudget(uint maxTextureCount);
                static /*0x26c1eb4*/ UnityEngine.Material[] CreateMaterials(UnityEngine.Shader shader, int pass);
                static /*0x26c2014*/ UnityEngine.Material GetProjectedShadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x26c2118*/ UnityEngine.Material GetStencilOnlyShadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x26c221c*/ UnityEngine.Material GetSpriteSelfShadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x26c2320*/ UnityEngine.Material GetSpriteUnshadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x26c2424*/ UnityEngine.Material GetGeometryUnshadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x26c2528*/ void CreateShadowRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer, int shadowIndex);
                static /*0x26c27cc*/ bool PrerenderShadows(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer, int layerToRender, UnityEngine.Rendering.Universal.Light2D light, int shadowIndex, float shadowIntensity);
                static /*0x26c3730*/ void SetGlobalShadowTexture(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.Rendering.Universal.Light2D light, int shadowIndex);
                static /*0x26c38b4*/ void DisableGlobalShadowTexture(UnityEngine.Rendering.CommandBuffer cmdBuffer);
                static /*0x26c2600*/ void CreateShadowRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderTargetHandle rtHandle, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer);
                static /*0x26c394c*/ void ReleaseShadowRenderTexture(UnityEngine.Rendering.CommandBuffer cmdBuffer, int shadowIndex);
                static /*0x26c3a00*/ void SetShadowProjectionGlobals(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster);
                static /*0x26c2a80*/ bool RenderShadows(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer, int layerToRender, UnityEngine.Rendering.Universal.Light2D light, float shadowIntensity, UnityEngine.Rendering.RenderTargetIdentifier renderTexture, int colorBit);
            }

            class ShadowUtility
            {
                static /*0x26c3fe8*/ UnityEngine.Rendering.Universal.ShadowUtility.Edge CreateEdge(int triangleIndexA, int triangleIndexB, System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<int> triangles);
                static /*0x26c421c*/ void PopulateEdgeArray(System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<int> triangles, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edges);
                static /*0x26c44b8*/ bool IsOutsideEdge(int edgeIndex, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edgesToProcess);
                static /*0x26c4628*/ void SortEdges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edgesToProcess);
                static /*0x26c4678*/ void CreateShadowTriangles(System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<UnityEngine.Color> colors, System.Collections.Generic.List<int> triangles, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edges);
                static /*0x26c4aa0*/ object InterpCustomVertexData(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 position, object[] data, float[] weights);
                static /*0x26c4ac4*/ void InitializeTangents(int tangentsToAdd, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
                static /*0x26c4bbc*/ void ComputeBoundingSphere(UnityEngine.Vector3[] shapePath, ref UnityEngine.BoundingSphere boundingSphere);
                static /*0x26c4c84*/ UnityEngine.BoundingSphere GenerateShadowMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3[] shapePath);
                /*0x26c5490*/ ShadowUtility();

                struct Edge : System.IComparable<UnityEngine.Rendering.Universal.ShadowUtility.Edge>
                {
                    /*0x10*/ int vertexIndex0;
                    /*0x14*/ int vertexIndex1;
                    /*0x18*/ UnityEngine.Vector4 tangent;
                    /*0x28*/ bool compareReversed;

                    /*0x26c4208*/ void AssignVertexIndices(int vi0, int vi1);
                    /*0x26c5498*/ int Compare(UnityEngine.Rendering.Universal.ShadowUtility.Edge a, UnityEngine.Rendering.Universal.ShadowUtility.Edge b);
                    /*0x26c45f0*/ int CompareTo(UnityEngine.Rendering.Universal.ShadowUtility.Edge edgeToCompare);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ShadowUtility.<> <>9;
                    static /*0x8*/ System.Func<int, int> <>9__9_0;
                    static /*0x10*/ System.Func<UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex, UnityEngine.Vector3> <>9__9_1;
                    static /*0x18*/ System.Func<UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex, UnityEngine.Color> <>9__9_2;

                    static /*0x26c54d8*/ <>c();
                    /*0x26c553c*/ <>c();
                    /*0x26c5544*/ int <GenerateShadowMesh>b__9_0(int i);
                    /*0x26c554c*/ UnityEngine.Vector3 <GenerateShadowMesh>b__9_1(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex v);
                    /*0x26c5558*/ UnityEngine.Color <GenerateShadowMesh>b__9_2(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex v);
                }
            }

            class ComponentUtility
            {
                static /*0x26c566c*/ bool IsUniversalCamera(UnityEngine.Camera camera);
                static /*0x26c56f8*/ bool IsUniversalLight(UnityEngine.Light light);
            }

            class PostProcessData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessData.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessData.TextureResources textures;

                /*0x26c5784*/ PostProcessData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader stopNanPS;
                    /*0x18*/ UnityEngine.Shader subpixelMorphologicalAntialiasingPS;
                    /*0x20*/ UnityEngine.Shader gaussianDepthOfFieldPS;
                    /*0x28*/ UnityEngine.Shader bokehDepthOfFieldPS;
                    /*0x30*/ UnityEngine.Shader cameraMotionBlurPS;
                    /*0x38*/ UnityEngine.Shader paniniProjectionPS;
                    /*0x40*/ UnityEngine.Shader lutBuilderLdrPS;
                    /*0x48*/ UnityEngine.Shader lutBuilderHdrPS;
                    /*0x50*/ UnityEngine.Shader bloomPS;
                    /*0x58*/ UnityEngine.Shader LensFlareDataDrivenPS;
                    /*0x60*/ UnityEngine.Shader scalingSetupPS;
                    /*0x68*/ UnityEngine.Shader easuPS;
                    /*0x70*/ UnityEngine.Shader uberPostPS;
                    /*0x78*/ UnityEngine.Shader finalPostPassPS;

                    /*0x26c578c*/ ShaderResources();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D[] blueNoise16LTex;
                    /*0x18*/ UnityEngine.Texture2D[] filmGrainTex;
                    /*0x20*/ UnityEngine.Texture2D smaaAreaTex;
                    /*0x28*/ UnityEngine.Texture2D smaaSearchTex;

                    /*0x26c5794*/ TextureResources();
                }
            }

            class StencilStateData
            {
                /*0x10*/ bool overrideStencilState;
                /*0x14*/ int stencilReference;
                /*0x18*/ UnityEngine.Rendering.CompareFunction stencilCompareFunction;
                /*0x1c*/ UnityEngine.Rendering.StencilOp passOperation;
                /*0x20*/ UnityEngine.Rendering.StencilOp failOperation;
                /*0x24*/ UnityEngine.Rendering.StencilOp zFailOperation;

                /*0x26c579c*/ StencilStateData();
            }

            enum ShadowQuality
            {
                Disabled = 0,
                HardShadows = 1,
                SoftShadows = 2,
            }

            enum ShadowResolution
            {
                _256 = 256,
                _512 = 512,
                _1024 = 1024,
                _2048 = 2048,
                _4096 = 4096,
            }

            enum LightCookieResolution
            {
                _256 = 256,
                _512 = 512,
                _1024 = 1024,
                _2048 = 2048,
                _4096 = 4096,
            }

            enum LightCookieFormat
            {
                GrayscaleLow = 0,
                GrayscaleHigh = 1,
                ColorLow = 2,
                ColorHigh = 3,
                ColorHDR = 4,
            }

            enum MsaaQuality
            {
                Disabled = 1,
                _2x = 2,
                _4x = 4,
                _8x = 8,
            }

            enum Downsampling
            {
                None = 0,
                _2xBilinear = 1,
                _4xBox = 2,
                _4xBilinear = 3,
            }

            enum DefaultMaterialType
            {
                Standard = 0,
                Particle = 1,
                Terrain = 2,
                Sprite = 3,
                UnityBuiltinDefault = 4,
                SpriteMask = 5,
                Decal = 6,
            }

            enum LightRenderingMode
            {
                Disabled = 0,
                PerVertex = 2,
                PerPixel = 1,
            }

            enum ShaderVariantLogLevel
            {
                Disabled = 0,
                OnlyUniversalRPShaders = 1,
                AllShaders = 2,
            }

            enum PipelineDebugLevel
            {
                Disabled = 0,
                Profiling = 1,
            }

            enum RendererType
            {
                Custom = 0,
                UniversalRenderer = 1,
                _2DRenderer = 2,
                ForwardRenderer = 1,
            }

            enum ColorGradingMode
            {
                LowDynamicRange = 0,
                HighDynamicRange = 1,
            }

            enum StoreActionsOptimization
            {
                Auto = 0,
                Discard = 1,
                Store = 2,
            }

            enum VolumeFrameworkUpdateMode
            {
                EveryFrame = 0,
                ViaScripting = 1,
                UsePipelineSettings = 2,
            }

            enum UpscalingFilterSelection
            {
                Auto = 0,
                Linear = 1,
                Point = 2,
                FSR = 3,
            }

            class UniversalRenderPipelineAsset : UnityEngine.Rendering.RenderPipelineAsset, UnityEngine.ISerializationCallbackReceiver
            {
                static int k_MinLutSize = 16;
                static int k_MaxLutSize = 65;
                static int k_ShadowCascadeMinCount = 1;
                static int k_ShadowCascadeMaxCount = 4;
                static /*0x0*/ int AdditionalLightsDefaultShadowResolutionTierLow;
                static /*0x4*/ int AdditionalLightsDefaultShadowResolutionTierMedium;
                static /*0x8*/ int AdditionalLightsDefaultShadowResolutionTierHigh;
                static /*0x10*/ UnityEngine.Experimental.Rendering.GraphicsFormat[][] s_LightCookieFormatList;
                /*0x18*/ UnityEngine.Shader m_DefaultShader;
                /*0x20*/ UnityEngine.Rendering.Universal.ScriptableRenderer[] m_Renderers;
                /*0x28*/ int k_AssetVersion;
                /*0x2c*/ int k_AssetPreviousVersion;
                /*0x30*/ UnityEngine.Rendering.Universal.RendererType m_RendererType;
                /*0x38*/ UnityEngine.Rendering.Universal.ScriptableRendererData m_RendererData;
                /*0x40*/ UnityEngine.Rendering.Universal.ScriptableRendererData[] m_RendererDataList;
                /*0x48*/ int m_DefaultRendererIndex;
                /*0x4c*/ bool m_RequireDepthTexture;
                /*0x4d*/ bool m_RequireOpaqueTexture;
                /*0x50*/ UnityEngine.Rendering.Universal.Downsampling m_OpaqueDownsampling;
                /*0x54*/ bool m_SupportsTerrainHoles;
                /*0x58*/ UnityEngine.Rendering.Universal.StoreActionsOptimization m_StoreActionsOptimization;
                /*0x5c*/ bool m_SupportsHDR;
                /*0x60*/ UnityEngine.Rendering.Universal.MsaaQuality m_MSAA;
                /*0x64*/ float m_RenderScale;
                /*0x68*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection m_UpscalingFilter;
                /*0x6c*/ bool m_FsrOverrideSharpness;
                /*0x70*/ float m_FsrSharpness;
                /*0x74*/ UnityEngine.Rendering.Universal.LightRenderingMode m_MainLightRenderingMode;
                /*0x78*/ bool m_MainLightShadowsSupported;
                /*0x7c*/ UnityEngine.Rendering.Universal.ShadowResolution m_MainLightShadowmapResolution;
                /*0x80*/ UnityEngine.Rendering.Universal.LightRenderingMode m_AdditionalLightsRenderingMode;
                /*0x84*/ int m_AdditionalLightsPerObjectLimit;
                /*0x88*/ bool m_AdditionalLightShadowsSupported;
                /*0x8c*/ UnityEngine.Rendering.Universal.ShadowResolution m_AdditionalLightsShadowmapResolution;
                /*0x90*/ int m_AdditionalLightsShadowResolutionTierLow;
                /*0x94*/ int m_AdditionalLightsShadowResolutionTierMedium;
                /*0x98*/ int m_AdditionalLightsShadowResolutionTierHigh;
                /*0x9c*/ bool m_ReflectionProbeBlending;
                /*0x9d*/ bool m_ReflectionProbeBoxProjection;
                /*0xa0*/ float m_ShadowDistance;
                /*0xa4*/ int m_ShadowCascadeCount;
                /*0xa8*/ float m_Cascade2Split;
                /*0xac*/ UnityEngine.Vector2 m_Cascade3Split;
                /*0xb4*/ UnityEngine.Vector3 m_Cascade4Split;
                /*0xc0*/ float m_CascadeBorder;
                /*0xc4*/ float m_ShadowDepthBias;
                /*0xc8*/ float m_ShadowNormalBias;
                /*0xcc*/ bool m_SoftShadowsSupported;
                /*0xcd*/ bool m_ConservativeEnclosingSphere;
                /*0xd0*/ int m_NumIterationsEnclosingSphere;
                /*0xd4*/ UnityEngine.Rendering.Universal.LightCookieResolution m_AdditionalLightsCookieResolution;
                /*0xd8*/ UnityEngine.Rendering.Universal.LightCookieFormat m_AdditionalLightsCookieFormat;
                /*0xdc*/ bool m_UseSRPBatcher;
                /*0xdd*/ bool m_SupportsDynamicBatching;
                /*0xde*/ bool m_MixedLightingSupported;
                /*0xdf*/ bool m_SupportsLightLayers;
                /*0xe0*/ UnityEngine.Rendering.Universal.PipelineDebugLevel m_DebugLevel;
                /*0xe4*/ bool m_UseAdaptivePerformance;
                /*0xe8*/ UnityEngine.Rendering.Universal.ColorGradingMode m_ColorGradingMode;
                /*0xec*/ int m_ColorGradingLutSize;
                /*0xf0*/ bool m_UseFastSRGBLinearConversion;
                /*0xf4*/ UnityEngine.Rendering.Universal.ShadowQuality m_ShadowType;
                /*0xf8*/ bool m_LocalShadowsSupported;
                /*0xfc*/ UnityEngine.Rendering.Universal.ShadowResolution m_LocalShadowsAtlasResolution;
                /*0x100*/ int m_MaxPixelLights;
                /*0x104*/ UnityEngine.Rendering.Universal.ShadowResolution m_ShadowAtlasResolution;
                /*0x108*/ UnityEngine.Rendering.Universal.ShaderVariantLogLevel m_ShaderVariantLogLevel;
                /*0x10c*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode;
                /*0x110*/ UnityEngine.Rendering.Universal.ShadowCascadesOption m_ShadowCascades;

                static /*0x26c72f0*/ UniversalRenderPipelineAsset();
                /*0x26c716c*/ UniversalRenderPipelineAsset();
                /*0x26c57ac*/ UnityEngine.Rendering.Universal.ScriptableRendererData LoadBuiltinRendererData(UnityEngine.Rendering.Universal.RendererType type);
                /*0x26c57e8*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
                /*0x26c5b48*/ void DestroyRenderers();
                /*0x26c5bac*/ void DestroyRenderer(ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x26c5bd0*/ void OnValidate();
                /*0x26c5bec*/ void OnDisable();
                /*0x26c59e0*/ void CreateRenderers();
                /*0x26c5c08*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DefaultMaterialType materialType);
                /*0x26c5c10*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x26c5efc*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(int index);
                /*0x26c5e3c*/ UnityEngine.Rendering.Universal.ScriptableRendererData get_scriptableRendererData();
                /*0x26c61b0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_additionalLightsCookieFormat();
                /*0x26c63e0*/ UnityEngine.Vector2Int get_additionalLightsCookieResolution();
                /*0x26c63ec*/ int[] get_rendererIndexList();
                /*0x26c6488*/ bool get_supportsCameraDepthTexture();
                /*0x26c6490*/ void set_supportsCameraDepthTexture(bool value);
                /*0x26c649c*/ bool get_supportsCameraOpaqueTexture();
                /*0x26c64a4*/ void set_supportsCameraOpaqueTexture(bool value);
                /*0x26c64b0*/ UnityEngine.Rendering.Universal.Downsampling get_opaqueDownsampling();
                /*0x26c64b8*/ bool get_supportsTerrainHoles();
                /*0x26c64c0*/ UnityEngine.Rendering.Universal.StoreActionsOptimization get_storeActionsOptimization();
                /*0x26c64c8*/ void set_storeActionsOptimization(UnityEngine.Rendering.Universal.StoreActionsOptimization value);
                /*0x26c64d0*/ bool get_supportsHDR();
                /*0x26c64d8*/ void set_supportsHDR(bool value);
                /*0x26c64e4*/ int get_msaaSampleCount();
                /*0x26c64ec*/ void set_msaaSampleCount(int value);
                /*0x26c64f4*/ float get_renderScale();
                /*0x26c64fc*/ void set_renderScale(float value);
                /*0x26c6590*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection get_upscalingFilter();
                /*0x26c6598*/ void set_upscalingFilter(UnityEngine.Rendering.Universal.UpscalingFilterSelection value);
                /*0x26c65a0*/ bool get_fsrOverrideSharpness();
                /*0x26c65a8*/ void set_fsrOverrideSharpness(bool value);
                /*0x26c65b4*/ float get_fsrSharpness();
                /*0x26c65bc*/ void set_fsrSharpness(float value);
                /*0x26c65c4*/ UnityEngine.Rendering.Universal.LightRenderingMode get_mainLightRenderingMode();
                /*0x26c65cc*/ void set_mainLightRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x26c65d4*/ bool get_supportsMainLightShadows();
                /*0x26c65dc*/ void set_supportsMainLightShadows(bool value);
                /*0x26c65e8*/ int get_mainLightShadowmapResolution();
                /*0x26c65f0*/ void set_mainLightShadowmapResolution(int value);
                /*0x26c65f8*/ UnityEngine.Rendering.Universal.LightRenderingMode get_additionalLightsRenderingMode();
                /*0x26c6600*/ void set_additionalLightsRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x26c6608*/ int get_maxAdditionalLightsCount();
                /*0x26c6610*/ void set_maxAdditionalLightsCount(int value);
                /*0x26c66c8*/ bool get_supportsAdditionalLightShadows();
                /*0x26c66d0*/ void set_supportsAdditionalLightShadows(bool value);
                /*0x26c66dc*/ int get_additionalLightsShadowmapResolution();
                /*0x26c66e4*/ void set_additionalLightsShadowmapResolution(int value);
                /*0x26c66ec*/ int get_additionalLightsShadowResolutionTierLow();
                /*0x26c66f4*/ void set_additionalLightsShadowResolutionTierLow(int value);
                /*0x26c66fc*/ int get_additionalLightsShadowResolutionTierMedium();
                /*0x26c6704*/ void set_additionalLightsShadowResolutionTierMedium(int value);
                /*0x26c670c*/ int get_additionalLightsShadowResolutionTierHigh();
                /*0x26c6714*/ void set_additionalLightsShadowResolutionTierHigh(int value);
                /*0x26c671c*/ int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier);
                /*0x26c67e4*/ bool get_reflectionProbeBlending();
                /*0x26c67ec*/ void set_reflectionProbeBlending(bool value);
                /*0x26c67f8*/ bool get_reflectionProbeBoxProjection();
                /*0x26c6800*/ void set_reflectionProbeBoxProjection(bool value);
                /*0x26c680c*/ float get_shadowDistance();
                /*0x26c6814*/ void set_shadowDistance(float value);
                /*0x26c6824*/ int get_shadowCascadeCount();
                /*0x26c682c*/ void set_shadowCascadeCount(int value);
                /*0x26c6914*/ float get_cascade2Split();
                /*0x26c691c*/ void set_cascade2Split(float value);
                /*0x26c6924*/ UnityEngine.Vector2 get_cascade3Split();
                /*0x26c692c*/ void set_cascade3Split(UnityEngine.Vector2 value);
                /*0x26c6934*/ UnityEngine.Vector3 get_cascade4Split();
                /*0x26c6940*/ void set_cascade4Split(UnityEngine.Vector3 value);
                /*0x26c694c*/ float get_cascadeBorder();
                /*0x26c6954*/ void set_cascadeBorder(float value);
                /*0x26c695c*/ float get_shadowDepthBias();
                /*0x26c6964*/ void set_shadowDepthBias(float value);
                /*0x26c69ec*/ float get_shadowNormalBias();
                /*0x26c69f4*/ void set_shadowNormalBias(float value);
                /*0x26c6a0c*/ bool get_supportsSoftShadows();
                /*0x26c6a14*/ void set_supportsSoftShadows(bool value);
                /*0x26c6a20*/ bool get_supportsDynamicBatching();
                /*0x26c6a28*/ void set_supportsDynamicBatching(bool value);
                /*0x26c6a34*/ bool get_supportsMixedLighting();
                /*0x26c6a3c*/ bool get_supportsLightLayers();
                /*0x26c6a44*/ UnityEngine.Rendering.Universal.ShaderVariantLogLevel get_shaderVariantLogLevel();
                /*0x26c6a4c*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.Universal.ShaderVariantLogLevel value);
                /*0x26c6a54*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x26c6a5c*/ UnityEngine.Rendering.Universal.PipelineDebugLevel get_debugLevel();
                /*0x26c6a64*/ bool get_useSRPBatcher();
                /*0x26c6a6c*/ void set_useSRPBatcher(bool value);
                /*0x26c6a78*/ UnityEngine.Rendering.Universal.ColorGradingMode get_colorGradingMode();
                /*0x26c6a80*/ void set_colorGradingMode(UnityEngine.Rendering.Universal.ColorGradingMode value);
                /*0x26c6a88*/ int get_colorGradingLutSize();
                /*0x26c6a90*/ void set_colorGradingLutSize(int value);
                /*0x26c6ab0*/ bool get_useFastSRGBLinearConversion();
                /*0x26c6ab8*/ bool get_useAdaptivePerformance();
                /*0x26c6ac0*/ void set_useAdaptivePerformance(bool value);
                /*0x26c6acc*/ bool get_conservativeEnclosingSphere();
                /*0x26c6ad4*/ void set_conservativeEnclosingSphere(bool value);
                /*0x26c6ae0*/ int get_numIterationsEnclosingSphere();
                /*0x26c6ae8*/ void set_numIterationsEnclosingSphere(int value);
                /*0x26c6af0*/ UnityEngine.Material get_defaultMaterial();
                /*0x26c6af8*/ UnityEngine.Material get_defaultParticleMaterial();
                /*0x26c6b00*/ UnityEngine.Material get_defaultLineMaterial();
                /*0x26c6b08*/ UnityEngine.Material get_defaultTerrainMaterial();
                /*0x26c6b10*/ UnityEngine.Material get_defaultUIMaterial();
                /*0x26c6b18*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
                /*0x26c6b20*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
                /*0x26c6b28*/ UnityEngine.Material get_default2DMaterial();
                /*0x26c6b30*/ UnityEngine.Material get_default2DMaskMaterial();
                /*0x26c6b38*/ UnityEngine.Material get_decalMaterial();
                /*0x26c6b40*/ UnityEngine.Shader get_defaultShader();
                /*0x26c6bec*/ string[] get_renderingLayerMaskNames();
                /*0x26c6c4c*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x26c6cac*/ string[] get_lightLayerMaskNames();
                /*0x26c6d0c*/ void OnBeforeSerialize();
                /*0x26c6d10*/ void OnAfterDeserialize();
                /*0x26c697c*/ float ValidateShadowBias(float value);
                /*0x26c6628*/ int ValidatePerObjectLights(int value);
                /*0x26c6514*/ float ValidateRenderScale(float value);
                /*0x26c6f50*/ bool ValidateRendererDataList(bool partial);
                /*0x26c6fd0*/ bool ValidateRendererData(int index);
                /*0x26c7074*/ UnityEngine.Rendering.Universal.ShadowCascadesOption get_shadowCascadeOption();
                /*0x26c70fc*/ void set_shadowCascadeOption(UnityEngine.Rendering.Universal.ShadowCascadesOption value);
            }

            class UniversalRenderPipelineEditorResources : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.MaterialResources materials;

                /*0x26c7534*/ UniversalRenderPipelineEditorResources();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader autodeskInteractivePS;
                    /*0x18*/ UnityEngine.Shader autodeskInteractiveTransparentPS;
                    /*0x20*/ UnityEngine.Shader autodeskInteractiveMaskedPS;
                    /*0x28*/ UnityEngine.Shader terrainDetailLitPS;
                    /*0x30*/ UnityEngine.Shader terrainDetailGrassPS;
                    /*0x38*/ UnityEngine.Shader terrainDetailGrassBillboardPS;
                    /*0x40*/ UnityEngine.Shader defaultSpeedTree7PS;
                    /*0x48*/ UnityEngine.Shader defaultSpeedTree8PS;

                    /*0x26c753c*/ ShaderResources();
                }

                class MaterialResources
                {
                    /*0x10*/ UnityEngine.Material lit;
                    /*0x18*/ UnityEngine.Material particleLit;
                    /*0x20*/ UnityEngine.Material terrainLit;
                    /*0x28*/ UnityEngine.Material decal;

                    /*0x26c7544*/ MaterialResources();
                }
            }

            class XRSystemData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.XRSystemData.ShaderResources shaders;

                /*0x26c754c*/ XRSystemData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader xrOcclusionMeshPS;
                    /*0x18*/ UnityEngine.Shader xrMirrorViewPS;

                    /*0x26c7554*/ ShaderResources();
                }
            }

            class DebugDisplaySettings : UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                static /*0x0*/ System.Lazy<UnityEngine.Rendering.Universal.DebugDisplaySettings> s_Instance;
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.Universal.IDebugDisplaySettingsData> m_Settings;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon <CommonSettings>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial <MaterialSettings>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering <RenderingSettings>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting <LightingSettings>k__BackingField;

                static /*0x26c83a4*/ DebugDisplaySettings();
                static /*0x26c755c*/ UnityEngine.Rendering.Universal.DebugDisplaySettings get_Instance();
                /*0x26c7a18*/ DebugDisplaySettings();
                /*0x26c75d4*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon get_CommonSettings();
                /*0x26c75dc*/ void set_CommonSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon value);
                /*0x26c75e4*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x26c75ec*/ void set_MaterialSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial value);
                /*0x26c75f4*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x26c75fc*/ void set_RenderingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering value);
                /*0x26c7604*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x26c760c*/ void set_LightingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting value);
                /*0x26c7614*/ bool get_AreAnySettingsActive();
                /*0x26c7704*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x26c77f0*/ bool get_IsLightingActive();
                /*0x26c789c*/ bool get_IsPostProcessingAllowed();
                TData Add<TData>(TData newData);
                /*0x26c7a9c*/ void Reset();
                /*0x26c824c*/ void ForEach(System.Action<UnityEngine.Rendering.Universal.IDebugDisplaySettingsData> onExecute);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettings.<> <>9;

                    static /*0x26c84ac*/ <>c();
                    /*0x26c8510*/ <>c();
                    /*0x26c8518*/ UnityEngine.Rendering.Universal.DebugDisplaySettings <.cctor>b__31_0();
                }
            }

            class DebugDisplaySettingsCommon : UnityEngine.Rendering.Universal.IDebugDisplaySettingsData, UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                /*0x26c7c64*/ DebugDisplaySettingsCommon();
                /*0x26c8570*/ bool get_AreAnySettingsActive();
                /*0x26c85c8*/ bool get_IsPostProcessingAllowed();
                /*0x26c8620*/ bool get_IsLightingActive();
                /*0x26c8678*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x26c86d8*/ UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class WidgetFactory
                {
                    static /*0x26c8e04*/ UnityEngine.Rendering.DebugUI.Widget CreateMissingDebugShadersWarning();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Func<bool> <>9__0_0;

                        static /*0x26c8f30*/ <>c();
                        /*0x26c8f94*/ <>c();
                        /*0x26c8f9c*/ bool <CreateMissingDebugShadersWarning>b__0_0();
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.Universal.DebugDisplaySettingsPanel
                {
                    static string k_GoToSectionString = "Go to Section...";

                    /*0x26c8730*/ SettingsPanel();
                    /*0x26c9064*/ string get_PanelName();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon.SettingsPanel.<> <>9;
                        static /*0x8*/ System.Action <>9__3_0;
                        static /*0x10*/ System.Action <>9__3_1;
                        static /*0x18*/ System.Action <>9__3_2;

                        static /*0x26ca438*/ <>c();
                        /*0x26ca49c*/ <>c();
                        /*0x26ca4a4*/ void <.ctor>b__3_0();
                        /*0x26ca508*/ void <.ctor>b__3_1();
                        /*0x26ca56c*/ void <.ctor>b__3_2();
                    }
                }
            }

            class DebugDisplaySettingsLighting : UnityEngine.Rendering.Universal.IDebugDisplaySettingsData, UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugLightingMode <DebugLightingMode>k__BackingField;
                /*0x14*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags <DebugLightingFeatureFlagsMask>k__BackingField;

                /*0x26c821c*/ DebugDisplaySettingsLighting();
                /*0x26ca5d0*/ UnityEngine.Rendering.Universal.DebugLightingMode get_DebugLightingMode();
                /*0x26ca5d8*/ void set_DebugLightingMode(UnityEngine.Rendering.Universal.DebugLightingMode value);
                /*0x26ca5e0*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags get_DebugLightingFeatureFlagsMask();
                /*0x26ca5e8*/ void set_DebugLightingFeatureFlagsMask(UnityEngine.Rendering.Universal.DebugLightingFeatureFlags value);
                /*0x26c7698*/ bool get_AreAnySettingsActive();
                /*0x26c7a04*/ bool get_IsPostProcessingAllowed();
                /*0x26c7894*/ bool get_IsLightingActive();
                /*0x26c77e8*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x26ca5f0*/ UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class Strings
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingDebugMode;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingFeatures;

                    static /*0x26ca750*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x26c9474*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);
                    static /*0x26c9720*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingFeatures(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data;

                        /*0x26ca814*/ <>c__DisplayClass0_0();
                        /*0x26ca824*/ int <CreateLightingDebugMode>b__0();
                        /*0x26ca840*/ int <CreateLightingDebugMode>b__2();
                        /*0x26ca85c*/ void <CreateLightingDebugMode>b__3(int value);
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<int> <>9__0_1;

                        static /*0x26ca878*/ <>c();
                        /*0x26ca8dc*/ <>c();
                        /*0x26ca8e4*/ void <CreateLightingDebugMode>b__0_1(int value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data;

                        /*0x26ca81c*/ <>c__DisplayClass1_0();
                        /*0x26ca8e8*/ System.Enum <CreateLightingFeatures>b__0();
                        /*0x26ca948*/ void <CreateLightingFeatures>b__1(System.Enum value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.Universal.DebugDisplaySettingsPanel
                {
                    /*0x26ca650*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);
                    /*0x26ca9c8*/ string get_PanelName();
                }
            }

            class DebugDisplaySettingsMaterial : UnityEngine.Rendering.Universal.IDebugDisplaySettingsData, UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset m_AlbedoDebugValidationPreset;
                /*0x1c*/ float AlbedoMinLuminance;
                /*0x20*/ float AlbedoMaxLuminance;
                /*0x24*/ float m_AlbedoHueTolerance;
                /*0x28*/ float m_AlbedoSaturationTolerance;
                /*0x2c*/ UnityEngine.Color AlbedoCompareColor;
                /*0x3c*/ float MetallicMinValue;
                /*0x40*/ float MetallicMaxValue;
                /*0x44*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode MaterialValidationMode;
                /*0x48*/ UnityEngine.Rendering.Universal.DebugMaterialMode <DebugMaterialModeData>k__BackingField;
                /*0x4c*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode <DebugVertexAttributeIndexData>k__BackingField;

                /*0x26c7c6c*/ DebugDisplaySettingsMaterial();
                /*0x26caa08*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset get_albedoDebugValidationPreset();
                /*0x26caa10*/ void set_albedoDebugValidationPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset value);
                /*0x26caa84*/ float get_AlbedoHueTolerance();
                /*0x26caa9c*/ void set_AlbedoHueTolerance(float value);
                /*0x26caaa4*/ float get_AlbedoSaturationTolerance();
                /*0x26caabc*/ void set_AlbedoSaturationTolerance(float value);
                /*0x26caac4*/ UnityEngine.Rendering.Universal.DebugMaterialMode get_DebugMaterialModeData();
                /*0x26caacc*/ void set_DebugMaterialModeData(UnityEngine.Rendering.Universal.DebugMaterialMode value);
                /*0x26caad4*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode get_DebugVertexAttributeIndexData();
                /*0x26caadc*/ void set_DebugVertexAttributeIndexData(UnityEngine.Rendering.Universal.DebugVertexAttributeMode value);
                /*0x26c7670*/ bool get_AreAnySettingsActive();
                /*0x26c79b4*/ bool get_IsPostProcessingAllowed();
                /*0x26c784c*/ bool get_IsLightingActive();
                /*0x26c7744*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x26caae4*/ UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable CreatePanel();

                enum AlbedoDebugValidationPreset
                {
                    DefaultLuminance = 0,
                    BlackAcrylicPaint = 1,
                    DarkSoil = 2,
                    WornAsphalt = 3,
                    DryClaySoil = 4,
                    GreenGrass = 5,
                    OldConcrete = 6,
                    RedClayTile = 7,
                    DrySand = 8,
                    NewConcrete = 9,
                    WhiteAcrylicPaint = 10,
                    FreshSnow = 11,
                    BlueSky = 12,
                    Foliage = 13,
                }

                struct AlbedoDebugValidationPresetData
                {
                    /*0x10*/ string name;
                    /*0x18*/ UnityEngine.Color color;
                    /*0x28*/ float minLuminance;
                    /*0x2c*/ float maxLuminance;
                }

                class Strings
                {
                    static string AlbedoSettingsContainerName = "Albedo Settings";
                    static string MetallicSettingsContainerName = "Metallic Settings";
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaterialOverride;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip VertexAttribute;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaterialValidationMode;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValidationPreset;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMinValue;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMaxValue;

                    static /*0x26caefc*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x26c91c8*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialOverride(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cb1b0*/ UnityEngine.Rendering.DebugUI.Widget CreateVertexAttribute(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cb464*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cb7a8*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cbaec*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMinLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cbc84*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMaxLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cbe1c*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoHueTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cc000*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoSaturationTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cc1e4*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMinValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    static /*0x26cc37c*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMaxValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cb1a8*/ <>c__DisplayClass0_0();
                        /*0x26cc514*/ int <CreateMaterialOverride>b__0();
                        /*0x26cc530*/ int <CreateMaterialOverride>b__2();
                        /*0x26cc54c*/ void <CreateMaterialOverride>b__3(int value);
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<int> <>9__0_1;
                        static /*0x10*/ System.Action<int> <>9__1_1;
                        static /*0x18*/ System.Action<int> <>9__2_1;
                        static /*0x20*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x28*/ System.Action<int> <>9__3_1;
                        static /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__3_4;

                        static /*0x26cc568*/ <>c();
                        /*0x26cc5cc*/ <>c();
                        /*0x26cc5d4*/ void <CreateMaterialOverride>b__0_1(int value);
                        /*0x26cc5d8*/ void <CreateVertexAttribute>b__1_1(int value);
                        /*0x26cc5dc*/ void <CreateMaterialValidationMode>b__2_1(int value);
                        /*0x26cc5e0*/ void <CreateMaterialValidationMode>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x26cc640*/ void <CreateAlbedoPreset>b__3_1(int value);
                        /*0x26cc644*/ void <CreateAlbedoPreset>b__3_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cb45c*/ <>c__DisplayClass1_0();
                        /*0x26cc6a4*/ int <CreateVertexAttribute>b__0();
                        /*0x26cc6c0*/ int <CreateVertexAttribute>b__2();
                        /*0x26cc6dc*/ void <CreateVertexAttribute>b__3(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cb7a0*/ <>c__DisplayClass2_0();
                        /*0x26cc6f8*/ int <CreateMaterialValidationMode>b__0();
                        /*0x26cc714*/ int <CreateMaterialValidationMode>b__2();
                        /*0x26cc730*/ void <CreateMaterialValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cbae4*/ <>c__DisplayClass3_0();
                        /*0x26cc74c*/ int <CreateAlbedoPreset>b__0();
                        /*0x26cc768*/ int <CreateAlbedoPreset>b__2();
                        /*0x26cc784*/ void <CreateAlbedoPreset>b__3(int value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cbc7c*/ <>c__DisplayClass4_0();
                        /*0x26cc79c*/ float <CreateAlbedoMinLuminance>b__0();
                        /*0x26cc7b8*/ void <CreateAlbedoMinLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cbe14*/ <>c__DisplayClass5_0();
                        /*0x26cc7d4*/ float <CreateAlbedoMaxLuminance>b__0();
                        /*0x26cc7f0*/ void <CreateAlbedoMaxLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cbff8*/ <>c__DisplayClass6_0();
                        /*0x26cc80c*/ float <CreateAlbedoHueTolerance>b__0();
                        /*0x26cc838*/ void <CreateAlbedoHueTolerance>b__1(float value);
                        /*0x26cc854*/ bool <CreateAlbedoHueTolerance>b__2();
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cc1dc*/ <>c__DisplayClass7_0();
                        /*0x26cc878*/ float <CreateAlbedoSaturationTolerance>b__0();
                        /*0x26cc8a4*/ void <CreateAlbedoSaturationTolerance>b__1(float value);
                        /*0x26cc8c0*/ bool <CreateAlbedoSaturationTolerance>b__2();
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cc374*/ <>c__DisplayClass8_0();
                        /*0x26cc8e4*/ float <CreateMetallicMinValue>b__0();
                        /*0x26cc900*/ void <CreateMetallicMinValue>b__1(float value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cc50c*/ <>c__DisplayClass9_0();
                        /*0x26cc91c*/ float <CreateMetallicMaxValue>b__0();
                        /*0x26cc938*/ void <CreateMetallicMaxValue>b__1(float value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.Universal.DebugDisplaySettingsPanel
                {
                    /*0x26cab44*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);
                    /*0x26cc954*/ string get_PanelName();

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x26cc994*/ <>c__DisplayClass2_0();
                        /*0x26cc99c*/ bool <.ctor>b__0();
                        /*0x26cc9c0*/ bool <.ctor>b__1();
                    }
                }
            }

            class DebugDisplaySettingsPanel : UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable, UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanel, System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> m_Widgets;

                /*0x26c90a4*/ DebugDisplaySettingsPanel();
                string get_PanelName();
                /*0x26cc9e4*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
                /*0x26c9120*/ void AddWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x26cca34*/ void Dispose();
            }

            class DebugDisplaySettingsRendering : UnityEngine.Rendering.Universal.IDebugDisplaySettingsData, UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.WireframeMode m_WireframeMode;
                /*0x14*/ bool m_Overdraw;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugFullScreenMode <debugFullScreenMode>k__BackingField;
                /*0x1c*/ int <debugFullScreenModeOutputSizeScreenPercent>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode <debugSceneOverrideMode>k__BackingField;
                /*0x24*/ UnityEngine.Rendering.Universal.DebugMipInfoMode <debugMipInfoMode>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode <debugPostProcessingMode>k__BackingField;
                /*0x2c*/ bool <enableMsaa>k__BackingField;
                /*0x2d*/ bool <enableHDR>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.Universal.DebugValidationMode <validationMode>k__BackingField;
                /*0x34*/ UnityEngine.Rendering.Universal.PixelValidationChannels <validationChannels>k__BackingField;
                /*0x38*/ float <ValidationRangeMin>k__BackingField;
                /*0x3c*/ float <ValidationRangeMax>k__BackingField;

                /*0x26c8224*/ DebugDisplaySettingsRendering();
                /*0x26ccaa4*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.WireframeMode get_wireframeMode();
                /*0x26ccaac*/ void set_wireframeMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.WireframeMode value);
                /*0x26ccaf4*/ bool get_overdraw();
                /*0x26ccafc*/ void set_overdraw(bool value);
                /*0x26ccad0*/ void UpdateDebugSceneOverrideMode();
                /*0x26ccb1c*/ UnityEngine.Rendering.Universal.DebugFullScreenMode get_debugFullScreenMode();
                /*0x26ccb24*/ void set_debugFullScreenMode(UnityEngine.Rendering.Universal.DebugFullScreenMode value);
                /*0x26ccb2c*/ int get_debugFullScreenModeOutputSizeScreenPercent();
                /*0x26ccb34*/ void set_debugFullScreenModeOutputSizeScreenPercent(int value);
                /*0x26ccb3c*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode get_debugSceneOverrideMode();
                /*0x26ccb44*/ void set_debugSceneOverrideMode(UnityEngine.Rendering.Universal.DebugSceneOverrideMode value);
                /*0x26ccb4c*/ UnityEngine.Rendering.Universal.DebugMipInfoMode get_debugMipInfoMode();
                /*0x26ccb54*/ void set_debugMipInfoMode(UnityEngine.Rendering.Universal.DebugMipInfoMode value);
                /*0x26ccb5c*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode get_debugPostProcessingMode();
                /*0x26ccb64*/ void set_debugPostProcessingMode(UnityEngine.Rendering.Universal.DebugPostProcessingMode value);
                /*0x26ccb6c*/ bool get_enableMsaa();
                /*0x26ccb74*/ void set_enableMsaa(bool value);
                /*0x26ccb80*/ bool get_enableHDR();
                /*0x26ccb88*/ void set_enableHDR(bool value);
                /*0x26ccb94*/ UnityEngine.Rendering.Universal.DebugValidationMode get_validationMode();
                /*0x26ccb9c*/ void set_validationMode(UnityEngine.Rendering.Universal.DebugValidationMode value);
                /*0x26ccba4*/ UnityEngine.Rendering.Universal.PixelValidationChannels get_validationChannels();
                /*0x26ccbac*/ void set_validationChannels(UnityEngine.Rendering.Universal.PixelValidationChannels value);
                /*0x26ccbb4*/ float get_ValidationRangeMin();
                /*0x26ccbbc*/ void set_ValidationRangeMin(float value);
                /*0x26ccbc4*/ float get_ValidationRangeMax();
                /*0x26ccbcc*/ void set_ValidationRangeMax(float value);
                /*0x26c76b8*/ bool get_AreAnySettingsActive();
                /*0x26c79dc*/ bool get_IsPostProcessingAllowed();
                /*0x26c7874*/ bool get_IsLightingActive();
                /*0x26c774c*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x26ccbd4*/ UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable CreatePanel();

                enum WireframeMode
                {
                    None = 0,
                    Wireframe = 1,
                    SolidWireframe = 2,
                    ShadedWireframe = 3,
                }

                class Strings
                {
                    static string RangeValidationSettingsContainerName = "Pixel Range Settings";
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MapOverlays;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MapSize;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AdditionalWireframeModes;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip Overdraw;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip PostProcessing;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MSAA;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDR;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip PixelValidationMode;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip Channels;
                    static /*0xa0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValueRangeMin;
                    static /*0xb0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValueRangeMax;

                    static /*0x26ccfa8*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x26cd324*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlays(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26cd5d8*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlaySize(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26c9e50*/ UnityEngine.Rendering.DebugUI.Widget CreateAdditionalWireframeShaderViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26ca18c*/ UnityEngine.Rendering.DebugUI.Widget CreateWireframeNotSupportedWarning(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26ca2b4*/ UnityEngine.Rendering.DebugUI.Widget CreateOverdraw(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26c9c04*/ UnityEngine.Rendering.DebugUI.Widget CreatePostProcessing(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26c9a80*/ UnityEngine.Rendering.DebugUI.Widget CreateMSAA(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26c98fc*/ UnityEngine.Rendering.DebugUI.Widget CreateHDR(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26cd904*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26cdc48*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationChannels(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26cdefc*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMin(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    static /*0x26ce094*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMax(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd5d0*/ <>c__DisplayClass0_0();
                        /*0x26ce22c*/ int <CreateMapOverlays>b__0();
                        /*0x26ce248*/ int <CreateMapOverlays>b__2();
                        /*0x26ce264*/ void <CreateMapOverlays>b__3(int value);
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<int> <>9__0_1;
                        static /*0x10*/ System.Func<int> <>9__1_2;
                        static /*0x18*/ System.Func<int> <>9__1_3;
                        static /*0x20*/ System.Action<int> <>9__2_1;
                        static /*0x28*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x30*/ System.Action<int> <>9__8_1;
                        static /*0x38*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__8_4;
                        static /*0x40*/ System.Action<int> <>9__9_1;

                        static /*0x26ce280*/ <>c();
                        /*0x26ce2e4*/ <>c();
                        /*0x26ce2ec*/ void <CreateMapOverlays>b__0_1(int value);
                        /*0x26ce2f0*/ int <CreateMapOverlaySize>b__1_2();
                        /*0x26ce2f8*/ int <CreateMapOverlaySize>b__1_3();
                        /*0x26ce300*/ void <CreateAdditionalWireframeShaderViews>b__2_1(int value);
                        /*0x26ce304*/ void <CreateAdditionalWireframeShaderViews>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x26ce364*/ void <CreatePixelValidationMode>b__8_1(int value);
                        /*0x26ce368*/ void <CreatePixelValidationMode>b__8_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x26ce3c8*/ void <CreatePixelValidationChannels>b__9_1(int value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8cc*/ <>c__DisplayClass1_0();
                        /*0x26ce3cc*/ int <CreateMapOverlaySize>b__0();
                        /*0x26ce3e8*/ void <CreateMapOverlaySize>b__1(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8d4*/ <>c__DisplayClass2_0();
                        /*0x26ce404*/ int <CreateAdditionalWireframeShaderViews>b__0();
                        /*0x26ce420*/ int <CreateAdditionalWireframeShaderViews>b__2();
                        /*0x26ce43c*/ void <CreateAdditionalWireframeShaderViews>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8dc*/ <>c__DisplayClass3_0();
                        /*0x26ce474*/ bool <CreateWireframeNotSupportedWarning>b__0();
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8e4*/ <>c__DisplayClass4_0();
                        /*0x26ce4c8*/ bool <CreateOverdraw>b__0();
                        /*0x26ce4e4*/ void <CreateOverdraw>b__1(bool value);
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8ec*/ <>c__DisplayClass5_0();
                        /*0x26ce518*/ int <CreatePostProcessing>b__0();
                        /*0x26ce534*/ void <CreatePostProcessing>b__1(int value);
                        /*0x26ce550*/ int <CreatePostProcessing>b__2();
                        /*0x26ce56c*/ void <CreatePostProcessing>b__3(int value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8f4*/ <>c__DisplayClass6_0();
                        /*0x26ce588*/ bool <CreateMSAA>b__0();
                        /*0x26ce5a4*/ void <CreateMSAA>b__1(bool value);
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cd8fc*/ <>c__DisplayClass7_0();
                        /*0x26ce5c4*/ bool <CreateHDR>b__0();
                        /*0x26ce5e0*/ void <CreateHDR>b__1(bool value);
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cdc40*/ <>c__DisplayClass8_0();
                        /*0x26ce600*/ int <CreatePixelValidationMode>b__0();
                        /*0x26ce61c*/ int <CreatePixelValidationMode>b__2();
                        /*0x26ce638*/ void <CreatePixelValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26cdef4*/ <>c__DisplayClass9_0();
                        /*0x26ce654*/ int <CreatePixelValidationChannels>b__0();
                        /*0x26ce670*/ int <CreatePixelValidationChannels>b__2();
                        /*0x26ce68c*/ void <CreatePixelValidationChannels>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26ce08c*/ <>c__DisplayClass10_0();
                        /*0x26ce6a8*/ float <CreatePixelValueRangeMin>b__0();
                        /*0x26ce6c4*/ void <CreatePixelValueRangeMin>b__1(float value);
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26ce224*/ <>c__DisplayClass11_0();
                        /*0x26ce6e0*/ float <CreatePixelValueRangeMax>b__0();
                        /*0x26ce6fc*/ void <CreatePixelValueRangeMax>b__1(float value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.Universal.DebugDisplaySettingsPanel
                {
                    /*0x26ccc34*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);
                    /*0x26ce718*/ string get_PanelName();

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x26ce758*/ <>c__DisplayClass2_0();
                        /*0x26ce760*/ bool <.ctor>b__0();
                    }
                }
            }

            class DebugDisplaySettingsUI : UnityEngine.Rendering.IDebugData
            {
                /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettings m_Settings;

                /*0x26ceeb8*/ DebugDisplaySettingsUI();
                /*0x26ce784*/ void Reset();
                /*0x26cece4*/ void RegisterDebug(UnityEngine.Rendering.Universal.DebugDisplaySettings settings);
                /*0x26ce814*/ void UnregisterDebug();
                /*0x26cee3c*/ System.Action GetReset();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugManager debugManager;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable> panels;

                    /*0x26cee34*/ <>c__DisplayClass3_0();
                    /*0x26ceec0*/ void <RegisterDebug>b__0(UnityEngine.Rendering.Universal.IDebugDisplaySettingsData data);
                }
            }

            class DebugHandler : UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                static /*0x0*/ int k_DebugColorInvalidModePropertyId;
                static /*0x4*/ int k_DebugColorPropertyId;
                static /*0x8*/ int k_DebugTexturePropertyId;
                static /*0xc*/ int k_DebugTextureNoStereoPropertyId;
                static /*0x10*/ int k_DebugTextureDisplayRect;
                static /*0x14*/ int k_DebugRenderTargetSupportsStereo;
                static /*0x18*/ int k_DebugMaterialModeId;
                static /*0x1c*/ int k_DebugVertexAttributeModeId;
                static /*0x20*/ int k_DebugMaterialValidationModeId;
                static /*0x24*/ int k_DebugMipInfoModeId;
                static /*0x28*/ int k_DebugSceneOverrideModeId;
                static /*0x2c*/ int k_DebugFullScreenModeId;
                static /*0x30*/ int k_DebugValidationModeId;
                static /*0x34*/ int k_DebugValidateBelowMinThresholdColorPropertyId;
                static /*0x38*/ int k_DebugValidateAboveMaxThresholdColorPropertyId;
                static /*0x3c*/ int k_DebugLightingModeId;
                static /*0x40*/ int k_DebugLightingFeatureFlagsId;
                static /*0x44*/ int k_DebugValidateAlbedoMinLuminanceId;
                static /*0x48*/ int k_DebugValidateAlbedoMaxLuminanceId;
                static /*0x4c*/ int k_DebugValidateAlbedoSaturationToleranceId;
                static /*0x50*/ int k_DebugValidateAlbedoHueToleranceId;
                static /*0x54*/ int k_DebugValidateAlbedoCompareColorId;
                static /*0x58*/ int k_DebugValidateMetallicMinValueId;
                static /*0x5c*/ int k_DebugValidateMetallicMaxValueId;
                static /*0x60*/ int k_ValidationChannelsId;
                static /*0x64*/ int k_RangeMinimumId;
                static /*0x68*/ int k_RangeMaximumId;
                /*0x10*/ UnityEngine.Material m_ReplacementMaterial;
                /*0x18*/ bool m_HasDebugRenderTarget;
                /*0x19*/ bool m_DebugRenderTargetSupportsStereo;
                /*0x1c*/ UnityEngine.Vector4 m_DebugRenderTargetPixelRect;
                /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier m_DebugRenderTargetIdentifier;
                /*0x58*/ UnityEngine.Rendering.Universal.DebugDisplaySettings m_DebugDisplaySettings;

                static /*0x26d04e0*/ DebugHandler();
                /*0x26cf290*/ DebugHandler(UnityEngine.Rendering.Universal.ScriptableRendererData scriptableRendererData);
                /*0x26cf100*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x26cf11c*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x26cf138*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x26cf154*/ bool get_AreAnySettingsActive();
                /*0x26cf16c*/ bool get_IsPostProcessingAllowed();
                /*0x26cf184*/ bool get_IsLightingActive();
                /*0x26cf19c*/ bool get_IsActiveModeUnsupportedForDeferred();
                /*0x26cf208*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x26cf220*/ UnityEngine.Material get_ReplacementMaterial();
                /*0x26cf228*/ UnityEngine.Rendering.Universal.DebugDisplaySettings get_DebugDisplaySettings();
                /*0x26cf230*/ bool get_IsScreenClearNeeded();
                /*0x26cf264*/ bool get_IsRenderPassSupported();
                /*0x26cf380*/ bool IsActiveForCamera(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26cf3b8*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode);
                /*0x26cf3d4*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode, ref int textureHeightPercent);
                /*0x26cf410*/ void SetupShaderProperties(UnityEngine.Rendering.CommandBuffer cmd, int passIndex);
                /*0x26cf820*/ void SetDebugRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, UnityEngine.Rect displayRect, bool supportsStereo);
                /*0x26cf8b4*/ void ResetDebugRenderTarget();
                /*0x26cf8bc*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isFinalPass);
                /*0x26cfab8*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26cfdfc*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.Universal.DebugRenderSetup> CreateDebugRenderSetupEnumerable(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer);
                /*0x26cfeb0*/ void DrawWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, UnityEngine.Rendering.Universal.DebugHandler.DrawFunction func);

                class DebugRenderPassEnumerable : System.Collections.Generic.IEnumerable<UnityEngine.Rendering.Universal.DebugRenderSetup>, System.Collections.IEnumerable
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                    /*0x18*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x20*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;

                    /*0x26cfe74*/ DebugRenderPassEnumerable(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer);
                    /*0x26d09e0*/ System.Collections.Generic.IEnumerator<UnityEngine.Rendering.Universal.DebugRenderSetup> GetEnumerator();
                    /*0x26d0acc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.Rendering.Universal.DebugRenderSetup>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                        /*0x18*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                        /*0x20*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;
                        /*0x28*/ int m_NumIterations;
                        /*0x2c*/ int m_Index;
                        /*0x30*/ UnityEngine.Rendering.Universal.DebugRenderSetup <Current>k__BackingField;

                        /*0x26d0a58*/ Enumerator(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer);
                        /*0x26d0ad0*/ UnityEngine.Rendering.Universal.DebugRenderSetup get_Current();
                        /*0x26d0ad8*/ void set_Current(UnityEngine.Rendering.Universal.DebugRenderSetup value);
                        /*0x26d0ae0*/ object System.Collections.IEnumerator.get_Current();
                        /*0x26d0ae8*/ bool MoveNext();
                        /*0x26d0bec*/ void Reset();
                        /*0x26d0c14*/ void Dispose();
                    }
                }

                class DrawFunction : System.MulticastDelegate
                {
                    /*0x26d0c24*/ DrawFunction(object object, nint method);
                    /*0x26d0ce8*/ void Invoke(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                    /*0x26d0cfc*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, System.AsyncCallback callback, object object);
                    /*0x26d0e48*/ void EndInvoke(ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, System.IAsyncResult result);
                }
            }

            class DebugRenderSetup : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                /*0x20*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;
                /*0x28*/ int m_Index;

                /*0x26d0ba4*/ DebugRenderSetup(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer, int index);
                /*0x26d0e70*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x26d0e94*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x26d0eb8*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x26d0edc*/ void Begin();
                /*0x26d0f70*/ void End();
                /*0x26d02cc*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.DrawingSettings drawingSettings);
                /*0x26d03a0*/ UnityEngine.Rendering.RenderStateBlock GetRenderStateBlock(UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x26d0ba0*/ void Dispose();
            }

            interface IDebugDisplaySettingsData : UnityEngine.Rendering.Universal.IDebugDisplaySettingsQuery
            {
                UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanelDisposable CreatePanel();
            }

            interface IDebugDisplaySettingsPanel
            {
                string get_PanelName();
                UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            }

            interface IDebugDisplaySettingsPanelDisposable : UnityEngine.Rendering.Universal.IDebugDisplaySettingsPanel, System.IDisposable
            {
            }

            interface IDebugDisplaySettingsQuery
            {
                bool get_AreAnySettingsActive();
                bool get_IsPostProcessingAllowed();
                bool get_IsLightingActive();
                bool TryGetScreenClearColor(ref UnityEngine.Color color);
            }

            class DecalDrawDBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x26d0fe0*/ DecalDrawDBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26d10f8*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DBufferRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ string[] s_DBufferNames;
                static /*0x8*/ string s_DBufferDepthName;
                /*0xd8*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem m_DrawSystem;
                /*0xe0*/ UnityEngine.Rendering.Universal.DBufferSettings m_Settings;
                /*0xe8*/ UnityEngine.Material m_DBufferClear;
                /*0xf0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x108*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x110*/ int m_DBufferCount;
                /*0x118*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x120*/ UnityEngine.Rendering.Universal.Internal.DeferredLights <deferredLights>k__BackingField;
                /*0x128*/ UnityEngine.Rendering.RenderTargetIdentifier[] <dBufferColorIndentifiers>k__BackingField;
                /*0x130*/ UnityEngine.Rendering.RenderTargetIdentifier <dBufferDepthIndentifier>k__BackingField;
                /*0x158*/ UnityEngine.Rendering.RenderTargetIdentifier <cameraDepthTextureIndentifier>k__BackingField;
                /*0x180*/ UnityEngine.Rendering.RenderTargetIdentifier <cameraDepthAttachmentIndentifier>k__BackingField;

                static /*0x26d23dc*/ DBufferRenderPass();
                /*0x26d11c0*/ DBufferRenderPass(UnityEngine.Material dBufferClear, UnityEngine.Rendering.Universal.DBufferSettings settings, UnityEngine.Rendering.Universal.DecalDrawDBufferSystem drawSystem);
                /*0x26d1110*/ UnityEngine.Rendering.Universal.Internal.DeferredLights get_deferredLights();
                /*0x26d1118*/ void set_deferredLights(UnityEngine.Rendering.Universal.Internal.DeferredLights value);
                /*0x26d1120*/ bool get_isDeferred();
                /*0x26d1130*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_dBufferColorIndentifiers();
                /*0x26d1138*/ void set_dBufferColorIndentifiers(UnityEngine.Rendering.RenderTargetIdentifier[] value);
                /*0x26d1140*/ UnityEngine.Rendering.RenderTargetIdentifier get_dBufferDepthIndentifier();
                /*0x26d1154*/ void set_dBufferDepthIndentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x26d1168*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthTextureIndentifier();
                /*0x26d1180*/ void set_cameraDepthTextureIndentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x26d1198*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthAttachmentIndentifier();
                /*0x26d11ac*/ void set_cameraDepthAttachmentIndentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x26d15bc*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26d1968*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26d1cf4*/ void ClearDBuffers(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26d21e8*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
            }

            class DecalDrawFowardEmissiveSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x26d2580*/ DecalDrawFowardEmissiveSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26d25d8*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalForwardEmissivePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xd8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xf8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x100*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DrawSystem;

                /*0x26d25f0*/ DecalForwardEmissivePass(UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem);
                /*0x26d2804*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class DecalDrawErrorSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x38*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;

                /*0x26d29ec*/ DecalDrawErrorSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, UnityEngine.Rendering.Universal.DecalTechnique technique);
                /*0x26d2a50*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x26d2ac0*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
            }

            class DecalPreviewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xd8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xf8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;

                /*0x26d2adc*/ DecalPreviewPass();
                /*0x26d2ce8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            enum DecalScaleMode
            {
                ScaleInvariant = 0,
                InheritFromHierarchy = 1,
            }

            class DecalProjector : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalAdd;
                static /*0x8*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalRemove;
                static /*0x10*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalPropertyChange;
                static /*0x18*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalMaterialChange;
                static /*0x20*/ UnityEngine.Material <defaultMaterial>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.Universal.DecalEntity <decalEntity>k__BackingField;
                /*0x20*/ UnityEngine.Material m_Material;
                /*0x28*/ float m_DrawDistance;
                /*0x2c*/ float m_FadeScale;
                /*0x30*/ float m_StartAngleFade;
                /*0x34*/ float m_EndAngleFade;
                /*0x38*/ UnityEngine.Vector2 m_UVScale;
                /*0x40*/ UnityEngine.Vector2 m_UVBias;
                /*0x48*/ UnityEngine.Rendering.Universal.DecalScaleMode m_ScaleMode;
                /*0x4c*/ UnityEngine.Vector3 m_Offset;
                /*0x58*/ UnityEngine.Vector3 m_Size;
                /*0x64*/ float m_FadeFactor;
                /*0x68*/ UnityEngine.Material m_OldMaterial;

                static /*0x26d2eb8*/ void add_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d2f70*/ void remove_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d3028*/ void add_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d30e4*/ void remove_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d31a0*/ void add_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d325c*/ void remove_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d3318*/ void add_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d33d4*/ void remove_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x26d3490*/ UnityEngine.Material get_defaultMaterial();
                static /*0x26d34d8*/ void set_defaultMaterial(UnityEngine.Material value);
                static /*0x26d3524*/ bool get_isSupported();
                /*0x26d3aac*/ DecalProjector();
                /*0x26d3574*/ UnityEngine.Rendering.Universal.DecalEntity get_decalEntity();
                /*0x26d357c*/ void set_decalEntity(UnityEngine.Rendering.Universal.DecalEntity value);
                /*0x26d3584*/ UnityEngine.Material get_material();
                /*0x26d358c*/ void set_material(UnityEngine.Material value);
                /*0x26d3684*/ float get_drawDistance();
                /*0x26d368c*/ void set_drawDistance(float value);
                /*0x26d369c*/ float get_fadeScale();
                /*0x26d36a4*/ void set_fadeScale(float value);
                /*0x26d36c0*/ float get_startAngleFade();
                /*0x26d36c8*/ void set_startAngleFade(float value);
                /*0x26d36e8*/ float get_endAngleFade();
                /*0x26d36f0*/ void set_endAngleFade(float value);
                /*0x26d3710*/ UnityEngine.Vector2 get_uvScale();
                /*0x26d3718*/ void set_uvScale(UnityEngine.Vector2 value);
                /*0x26d3720*/ UnityEngine.Vector2 get_uvBias();
                /*0x26d3728*/ void set_uvBias(UnityEngine.Vector2 value);
                /*0x26d3730*/ UnityEngine.Rendering.Universal.DecalScaleMode get_scaleMode();
                /*0x26d3738*/ void set_scaleMode(UnityEngine.Rendering.Universal.DecalScaleMode value);
                /*0x26d3740*/ UnityEngine.Vector3 get_pivot();
                /*0x26d374c*/ void set_pivot(UnityEngine.Vector3 value);
                /*0x26d3758*/ UnityEngine.Vector3 get_size();
                /*0x26d3764*/ void set_size(UnityEngine.Vector3 value);
                /*0x26d3770*/ float get_fadeFactor();
                /*0x26d3778*/ void set_fadeFactor(float value);
                /*0x26d3794*/ UnityEngine.Vector3 get_effectiveScale();
                /*0x26d3800*/ UnityEngine.Vector3 get_decalSize();
                /*0x26d380c*/ UnityEngine.Vector3 get_decalOffset();
                /*0x26d381c*/ UnityEngine.Vector4 get_uvScaleBias();
                /*0x26d3828*/ void InitMaterial();
                /*0x26d3888*/ void OnEnable();
                /*0x26d3904*/ void OnDisable();
                /*0x26d3594*/ void OnValidate();
                /*0x26d3970*/ bool IsValid();

                class DecalProjectorAction : System.MulticastDelegate
                {
                    /*0x26d3ae8*/ DecalProjectorAction(object object, nint method);
                    /*0x26d3c14*/ void Invoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                    /*0x26d3c28*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector, System.AsyncCallback callback, object object);
                    /*0x26d3c48*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class DecalShaderPassNames
            {
                static string DecalPreview = "DecalPreview";
                static string DBufferProjector = "DBufferProjector";
                static string DecalProjectorForwardEmissive = "DecalProjectorForwardEmissive";
                static string DecalScreenSpaceProjector = "DecalScreenSpaceProjector";
                static string DecalGBufferProjector = "DecalGBufferProjector";
                static string DBufferMesh = "DBufferMesh";
                static string DecalMeshForwardEmissive = "DecalMeshForwardEmissive";
                static string DecalScreenSpaceMesh = "DecalScreenSpaceMesh";
                static string DecalGBufferMesh = "DecalGBufferMesh";
            }

            class DecalChunk : System.IDisposable
            {
                /*0x10*/ int <count>k__BackingField;
                /*0x14*/ int <capacity>k__BackingField;
                /*0x18*/ Unity.Jobs.JobHandle <currentJobHandle>k__BackingField;

                /*0x26d3d68*/ DecalChunk();
                /*0x26d3c54*/ int get_count();
                /*0x26d3c5c*/ void set_count(int value);
                /*0x26d3c64*/ int get_capacity();
                /*0x26d3c6c*/ void set_capacity(int value);
                /*0x26d3c74*/ Unity.Jobs.JobHandle get_currentJobHandle();
                /*0x26d3c80*/ void set_currentJobHandle(Unity.Jobs.JobHandle value);
                /*0x26d3c88*/ void Push();
                void RemoveAtSwapBack(int index);
                void SetCapacity(int capacity);
                /*0x26d3c98*/ void Dispose();
                /*0x26d3c9c*/ void ResizeNativeArray(ref UnityEngine.Jobs.TransformAccessArray array, UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors, int capacity);
                void RemoveAtSwapBack<T>(ref Unity.Collections.NativeArray<T> array, int index, int count);
                void RemoveAtSwapBack<T>(ref T[] array, int index, int count);
            }

            struct DecalSubDrawCall
            {
                /*0x10*/ int start;
                /*0x14*/ int end;

                /*0x26d3d70*/ int get_count();
            }

            class DecalDrawCallChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecals;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                /*0x58*/ Unity.Collections.NativeArray<int> subCallCounts;

                /*0x26d3f80*/ DecalDrawCallChunk();
                /*0x26d3d7c*/ void set_subCallCount(int value);
                /*0x26d3d88*/ int get_subCallCount();
                /*0x26d3d94*/ void RemoveAtSwapBack(int entityIndex);
                /*0x26d3e48*/ void SetCapacity(int newCapacity);
                /*0x26d3edc*/ void Dispose();
            }

            class DecalCreateDrawCallSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ float m_MaxDrawDistance;

                /*0x26d3f98*/ DecalCreateDrawCallSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float maxDrawDistance);
                /*0x26d3f88*/ float get_maxDrawDistance();
                /*0x26d3f90*/ void set_maxDrawDistance(float value);
                /*0x26d403c*/ void Execute();
                /*0x26d4250*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk, int count);

                struct DrawCallJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                    /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> drawDistances;
                    /*0x50*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> angleFades;
                    /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> uvScaleBiases;
                    /*0x70*/ Unity.Collections.NativeArray<int> layerMasks;
                    /*0x80*/ Unity.Collections.NativeArray<ulong> sceneLayerMasks;
                    /*0x90*/ Unity.Collections.NativeArray<float> fadeFactors;
                    /*0xa0*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                    /*0xb0*/ UnityEngine.Vector3 cameraPosition;
                    /*0xc0*/ ulong sceneCullingMask;
                    /*0xc8*/ int cullingMask;
                    /*0xd0*/ Unity.Collections.NativeArray<int> visibleDecalIndices;
                    /*0xe0*/ int visibleDecalCount;
                    /*0xe4*/ float maxDrawDistance;
                    /*0xe8*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorldsDraw;
                    /*0xf8*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecalsDraw;
                    /*0x108*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                    /*0x118*/ Unity.Collections.NativeArray<int> subCallCount;

                    /*0x26d4448*/ void Execute();
                }
            }

            class DecalDrawSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Matrix4x4[] m_WorldToDecals;
                /*0x20*/ UnityEngine.Matrix4x4[] m_NormalToDecals;
                /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x30*/ UnityEngine.Material <overrideMaterial>k__BackingField;

                /*0x26d1038*/ DecalDrawSystem(string sampler, UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26d4824*/ UnityEngine.Material get_overrideMaterial();
                /*0x26d482c*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x26d1fc4*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26d499c*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
                int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x26d4834*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x26d4b98*/ void Draw(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x26d49b4*/ void DrawInstanced(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x26d4dc0*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26d4fe4*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x26d5350*/ void Draw(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
                /*0x26d5138*/ void DrawInstanced(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
            }

            class DecalEntityIndexer
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem> m_Entities;
                /*0x18*/ System.Collections.Generic.Queue<int> m_FreeIndices;

                /*0x26d5ab8*/ DecalEntityIndexer();
                /*0x26d5578*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x26d5600*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex);
                /*0x26d5788*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x26d5838*/ UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem GetItem(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x26d5898*/ void UpdateIndex(UnityEngine.Rendering.Universal.DecalEntity decalEntity, int newArrayIndex);
                /*0x26d5934*/ void RemapChunkIndices(System.Collections.Generic.List<int> remaper);
                /*0x26d5a48*/ void Clear();

                struct DecalEntityItem
                {
                    /*0x10*/ int chunkIndex;
                    /*0x14*/ int arrayIndex;
                    /*0x18*/ int version;
                }
            }

            struct DecalEntity
            {
                /*0x10*/ int index;
                /*0x14*/ int version;
            }

            class DecalEntityChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.Material material;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalEntity> decalEntities;
                /*0x40*/ UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors;
                /*0x48*/ UnityEngine.Jobs.TransformAccessArray transformAccessArray;

                /*0x26d6d3c*/ DecalEntityChunk();
                /*0x26d6b78*/ void Push();
                /*0x26d6b88*/ void RemoveAtSwapBack(int entityIndex);
                /*0x26d6c34*/ void SetCapacity(int newCapacity);
                /*0x26d6cd4*/ void Dispose();
            }

            class DecalEntityManager : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityChunk> entityChunks;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalCachedChunk> cachedChunks;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalCulledChunk> culledChunks;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalDrawCallChunk> drawCallChunks;
                /*0x30*/ int chunkCount;
                /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_AddDecalSampler;
                /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ResizeChunks;
                /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_SortChunks;
                /*0x50*/ UnityEngine.Rendering.Universal.DecalEntityIndexer m_DecalEntityIndexer;
                /*0x58*/ System.Collections.Generic.Dictionary<UnityEngine.Material, int> m_MaterialToChunkIndex;
                /*0x60*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks> m_CombinedChunks;
                /*0x68*/ System.Collections.Generic.List<int> m_CombinedChunkRemmap;
                /*0x70*/ UnityEngine.Material m_ErrorMaterial;
                /*0x78*/ UnityEngine.Mesh m_DecalProjectorMesh;

                /*0x26d6ec8*/ DecalEntityManager();
                /*0x26d6d44*/ UnityEngine.Material get_errorMaterial();
                /*0x26d6e10*/ UnityEngine.Mesh get_decalProjectorMesh();
                /*0x26d71c0*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x26d71dc*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x26d775c*/ int CreateChunkIndex(UnityEngine.Material material);
                /*0x26d7c70*/ void UpdateDecalEntityData(UnityEngine.Rendering.Universal.DecalEntity decalEntity, UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x26d7fe4*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x26d81cc*/ void Update();
                /*0x26d8b7c*/ void Dispose();

                struct CombinedChunks
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk;
                    /*0x20*/ UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk;
                    /*0x28*/ UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk;
                    /*0x30*/ int previousChunkIndex;
                    /*0x34*/ bool valid;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalEntityManager.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks> <>9__25_0;

                    static /*0x26d952c*/ <>c();
                    /*0x26d9590*/ <>c();
                    /*0x26d9598*/ int <Update>b__25_0(UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks a, UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks b);
                }
            }

            class DecalSkipCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Camera m_Camera;

                static /*0x26d9904*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x26d9650*/ DecalSkipCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26d96e4*/ void Execute(UnityEngine.Camera camera);
                /*0x26d9858*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalCachedChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.MaterialPropertyBlock propertyBlock;
                /*0x30*/ int passIndexDBuffer;
                /*0x34*/ int passIndexEmissive;
                /*0x38*/ int passIndexScreenSpace;
                /*0x3c*/ int passIndexGBuffer;
                /*0x40*/ int drawOrder;
                /*0x44*/ bool isCreated;
                /*0x48*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x58*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                /*0x68*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                /*0x78*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> drawDistances;
                /*0x88*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> angleFades;
                /*0x98*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> uvScaleBias;
                /*0xa8*/ Unity.Collections.NativeArray<int> layerMasks;
                /*0xb8*/ Unity.Collections.NativeArray<ulong> sceneLayerMasks;
                /*0xc8*/ Unity.Collections.NativeArray<float> fadeFactors;
                /*0xd8*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                /*0xe8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalScaleMode> scaleModes;
                /*0xf8*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                /*0x108*/ Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotation;
                /*0x118*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;
                /*0x128*/ Unity.Collections.NativeArray<bool> dirty;
                /*0x138*/ UnityEngine.BoundingSphere[] boundingSphereArray;

                /*0x26d7fd4*/ DecalCachedChunk();
                /*0x26d990c*/ void RemoveAtSwapBack(int entityIndex);
                /*0x26d9bd8*/ void SetCapacity(int newCapacity);
                /*0x26d9e1c*/ void Dispose();
            }

            class DecalUpdateCachedSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Rendering.ProfilingSampler m_SamplerJob;

                /*0x26da004*/ DecalUpdateCachedSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26da0cc*/ void Execute();
                /*0x26da28c*/ void Execute(UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, int count);

                struct UpdateTransformsJob : UnityEngine.Jobs.IJobParallelForTransform
                {
                    static /*0x0*/ Unity.Mathematics.quaternion k_MinusYtoZRotation;
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;
                    /*0x40*/ Unity.Collections.NativeArray<bool> dirty;
                    /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalScaleMode> scaleModes;
                    /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                    /*0x70*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                    /*0x80*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                    /*0x90*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                    /*0xa0*/ float minDistance;

                    static /*0x26dadf4*/ UpdateTransformsJob();
                    /*0x26da540*/ float DistanceBetweenQuaternions(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
                    /*0x26da570*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
                    /*0x26dabf4*/ UnityEngine.BoundingSphere GetDecalProjectBoundingSphere(UnityEngine.Matrix4x4 decalToWorld);
                }
            }

            class DecalUpdateCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                /*0x26daf5c*/ DecalUpdateCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26daff0*/ void Execute();
                /*0x26db158*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalCulledChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.Vector3 cameraPosition;
                /*0x38*/ ulong sceneCullingMask;
                /*0x40*/ int cullingMask;
                /*0x48*/ UnityEngine.CullingGroup cullingGroups;
                /*0x50*/ int[] visibleDecalIndexArray;
                /*0x58*/ Unity.Collections.NativeArray<int> visibleDecalIndices;
                /*0x68*/ int visibleDecalCount;

                /*0x26d7fdc*/ DecalCulledChunk();
                /*0x26db1f8*/ void RemoveAtSwapBack(int entityIndex);
                /*0x26db294*/ void SetCapacity(int newCapacity);
                /*0x26db354*/ void Dispose();
            }

            class DecalUpdateCullingGroupSystem
            {
                /*0x10*/ float[] m_BoundingDistance;
                /*0x18*/ UnityEngine.Camera m_Camera;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                static /*0x26db7fc*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x26db418*/ DecalUpdateCullingGroupSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float drawDistance);
                /*0x26db3c8*/ float get_boundingDistance();
                /*0x26db3f0*/ void set_boundingDistance(float value);
                /*0x26db4f4*/ void Execute(UnityEngine.Camera camera);
                /*0x26db6bc*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalDrawGBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x26db804*/ DecalDrawGBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26db860*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalGBufferRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xd8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xf8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x100*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem m_DrawSystem;
                /*0x108*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0x110*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0x118*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_GbufferAttachments;

                /*0x26db878*/ DecalGBufferRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem);
                /*0x26dc160*/ void Setup(UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                /*0x26dc168*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26dc4a0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26dc96c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
            }

            class DecalDrawScreenSpaceSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x26dca88*/ DecalDrawScreenSpaceSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x26dcae4*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalScreenSpaceRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xd8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xf8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x100*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DrawSystem;
                /*0x108*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;

                /*0x26dcafc*/ DecalScreenSpaceRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem);
                /*0x26dcd30*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26dd088*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
            }

            class DeferredShaderData : System.IDisposable
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.DeferredShaderData m_Instance;
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.PreTile> m_PreTiles;
                /*0x18*/ UnityEngine.ComputeBuffer[] m_Buffers;
                /*0x20*/ UnityEngine.Rendering.Universal.DeferredShaderData.ComputeBufferInfo[] m_BufferInfos;
                /*0x28*/ int m_BufferCount;
                /*0x2c*/ int m_CachedBufferIndex;
                /*0x30*/ uint m_FrameIndex;

                static /*0x26dd250*/ UnityEngine.Rendering.Universal.DeferredShaderData get_instance();
                static /*0x26dd764*/ bool IsLessCircular(uint a, uint b);
                static /*0x26dd86c*/ int Align(int s, int alignment);
                /*0x26dd1a4*/ DeferredShaderData();
                /*0x26dd2cc*/ void Dispose();
                /*0x26dd380*/ void ResetBuffers();
                /*0x26dd390*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.PreTile> GetPreTiles(int level, int count);
                UnityEngine.ComputeBuffer ReserveBuffer<T>(int count, bool asCBuffer);
                Unity.Collections.NativeArray<T> GetOrUpdateNativeArray<T>(ref Unity.Collections.NativeArray<T> nativeArrays, int level, int count);
                void DisposeNativeArrays<T>(ref Unity.Collections.NativeArray<T> nativeArrays);
                /*0x26dd3f4*/ UnityEngine.ComputeBuffer GetOrUpdateBuffer(int count, int stride, bool isConstantBuffer);
                /*0x26dd77c*/ void DisposeBuffers(UnityEngine.ComputeBuffer[,] buffers);

                struct ComputeBufferInfo
                {
                    /*0x10*/ uint frameUsed;
                    /*0x14*/ UnityEngine.ComputeBufferType type;
                }
            }

            class ScriptableRenderPass
            {
                /*0x10*/ UnityEngine.Rendering.Universal.RenderPassEvent <renderPassEvent>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions;
                /*0x20*/ UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction;
                /*0x28*/ bool[] m_OverriddenColorStoreActions;
                /*0x30*/ bool m_OverriddenDepthStoreAction;
                /*0x38*/ UnityEngine.Rendering.ProfilingSampler <profilingSampler>k__BackingField;
                /*0x40*/ bool <overrideCameraTarget>k__BackingField;
                /*0x41*/ bool <isBlitRenderPass>k__BackingField;
                /*0x42*/ bool <useNativeRenderPass>k__BackingField;
                /*0x44*/ int <renderTargetWidth>k__BackingField;
                /*0x48*/ int <renderTargetHeight>k__BackingField;
                /*0x4c*/ int <renderTargetSampleCount>k__BackingField;
                /*0x50*/ bool <depthOnly>k__BackingField;
                /*0x51*/ bool <isLastPass>k__BackingField;
                /*0x54*/ int <renderPassQueueIndex>k__BackingField;
                /*0x58*/ Unity.Collections.NativeArray<int> m_ColorAttachmentIndices;
                /*0x68*/ Unity.Collections.NativeArray<int> m_InputAttachmentIndices;
                /*0x78*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] <renderTargetFormat>k__BackingField;
                /*0x80*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_ColorAttachments;
                /*0x88*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_InputAttachments;
                /*0x90*/ bool[] m_InputAttachmentIsTransient;
                /*0x98*/ UnityEngine.Rendering.RenderTargetIdentifier m_DepthAttachment;
                /*0xc0*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput m_Input;
                /*0xc4*/ UnityEngine.Rendering.ClearFlag m_ClearFlag;
                /*0xc8*/ UnityEngine.Color m_ClearColor;

                static /*0x26de730*/ bool op_LessThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x26de758*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                /*0x26dbaa8*/ ScriptableRenderPass();
                /*0x26dd880*/ void FrameCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26dd88c*/ UnityEngine.Rendering.Universal.RenderPassEvent get_renderPassEvent();
                /*0x26dd894*/ void set_renderPassEvent(UnityEngine.Rendering.Universal.RenderPassEvent value);
                /*0x26dd89c*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachments();
                /*0x26dd8a4*/ UnityEngine.Rendering.RenderTargetIdentifier get_colorAttachment();
                /*0x26dd8d8*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthAttachment();
                /*0x26dd8f0*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
                /*0x26dd8f8*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
                /*0x26dd900*/ bool[] get_overriddenColorStoreActions();
                /*0x26dd908*/ bool get_overriddenDepthStoreAction();
                /*0x26dd910*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput get_input();
                /*0x26dd918*/ UnityEngine.Rendering.ClearFlag get_clearFlag();
                /*0x26dd920*/ UnityEngine.Color get_clearColor();
                /*0x26dd92c*/ UnityEngine.Rendering.ProfilingSampler get_profilingSampler();
                /*0x26dd934*/ void set_profilingSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x26dd93c*/ bool get_overrideCameraTarget();
                /*0x26dd944*/ void set_overrideCameraTarget(bool value);
                /*0x26dd950*/ bool get_isBlitRenderPass();
                /*0x26dd958*/ void set_isBlitRenderPass(bool value);
                /*0x26dd964*/ bool get_useNativeRenderPass();
                /*0x26dd96c*/ void set_useNativeRenderPass(bool value);
                /*0x26dd978*/ int get_renderTargetWidth();
                /*0x26dd980*/ void set_renderTargetWidth(int value);
                /*0x26dd988*/ int get_renderTargetHeight();
                /*0x26dd990*/ void set_renderTargetHeight(int value);
                /*0x26dd998*/ int get_renderTargetSampleCount();
                /*0x26dd9a0*/ void set_renderTargetSampleCount(int value);
                /*0x26dd9a8*/ bool get_depthOnly();
                /*0x26dd9b0*/ void set_depthOnly(bool value);
                /*0x26dd9bc*/ bool get_isLastPass();
                /*0x26dd9c4*/ void set_isLastPass(bool value);
                /*0x26dd9d0*/ int get_renderPassQueueIndex();
                /*0x26dd9d8*/ void set_renderPassQueueIndex(int value);
                /*0x26dd9e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_renderTargetFormat();
                /*0x26dd9e8*/ void set_renderTargetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                /*0x26dd9f0*/ UnityEngine.Rendering.Universal.DebugHandler GetActiveDebugHandler(UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26dda2c*/ void ConfigureInput(UnityEngine.Rendering.Universal.ScriptableRenderPassInput passInput);
                /*0x26dda34*/ void ConfigureColorStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction, uint attachmentIndex);
                /*0x26dda88*/ void ConfigureColorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] storeActions);
                /*0x26ddb6c*/ void ConfigureDepthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction);
                /*0x26ddb7c*/ void ConfigureInputAttachments(UnityEngine.Rendering.RenderTargetIdentifier input, bool isTransient);
                /*0x26ddbf0*/ void ConfigureInputAttachments(UnityEngine.Rendering.RenderTargetIdentifier[] inputs);
                /*0x26ddbf8*/ void ConfigureInputAttachments(UnityEngine.Rendering.RenderTargetIdentifier[] inputs, bool[] isTransient);
                /*0x26ddc00*/ void SetInputAttachmentTransient(int idx, bool isTransient);
                /*0x26ddc34*/ bool IsInputAttachmentTransient(int idx);
                /*0x26ddc64*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x26ddd88*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x26dc340*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x26ddf60*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat[] formats);
                /*0x26ddca4*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment);
                /*0x26ddde0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height, int sampleCount, bool depth);
                /*0x26ddff8*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments);
                /*0x26de050*/ void ConfigureClear(UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                /*0x26de060*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26de064*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x26de068*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26de06c*/ void OnFinishCameraStackRendering(UnityEngine.Rendering.CommandBuffer cmd);
                void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26de070*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex);
                /*0x26de4c4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Material material, int passIndex);
                /*0x26de604*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x26dc7c0*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
            }

            class ForwardRenderer : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static /*0x0*/ string k_ErrorMessage;

                static /*0x26df3b4*/ ForwardRenderer();
                /*0x26de780*/ ForwardRenderer(UnityEngine.Rendering.Universal.ForwardRendererData data);
                /*0x26df158*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26df1c4*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26df230*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26df29c*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26df308*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26df374*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
            }

            enum ShadowCascadesOption
            {
                NoCascades = 0,
                TwoCascades = 1,
                FourCascades = 2,
            }

            class ScriptableRenderer : System.IDisposable
            {
                static int kRenderPassMapSize = 10;
                static int kRenderPassMaxCount = 20;
                static int k_RenderPassBlockCount = 4;
                static /*0x0*/ UnityEngine.Rendering.Universal.ScriptableRenderer current;
                static /*0x8*/ bool m_UseOptimizedStoreActions;
                static /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_ActiveColorAttachments;
                static /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier m_ActiveDepthAttachment;
                static /*0x40*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ActiveColorStoreActions;
                static /*0x48*/ UnityEngine.Rendering.RenderBufferStoreAction m_ActiveDepthStoreAction;
                static /*0x50*/ UnityEngine.Rendering.RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies;
                static /*0x58*/ UnityEngine.Plane[] s_Planes;
                static /*0x60*/ UnityEngine.Vector4[] s_VectorPlanes;
                /*0x10*/ int m_LastBeginSubpassPassIndex;
                /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, System.Int32[]> m_MergeableRenderPassesMap;
                /*0x20*/ int[][] m_MergeableRenderPassesMapArrays;
                /*0x28*/ UnityEngine.Hash128[] m_PassIndexToPassHash;
                /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, int> m_RenderPassesAttachmentCount;
                /*0x38*/ UnityEngine.Rendering.AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors;
                /*0x40*/ UnityEngine.Rendering.AttachmentDescriptor m_ActiveDepthAttachmentDescriptor;
                /*0xb8*/ bool[] m_IsActiveColorAttachmentTransient;
                /*0xc0*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_FinalColorStoreAction;
                /*0xc8*/ UnityEngine.Rendering.RenderBufferStoreAction m_FinalDepthStoreAction;
                /*0xd0*/ UnityEngine.Rendering.ProfilingSampler <profilingExecute>k__BackingField;
                /*0xd8*/ UnityEngine.Rendering.Universal.DebugHandler <DebugHandler>k__BackingField;
                /*0xe0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures <supportedRenderingFeatures>k__BackingField;
                /*0xe8*/ UnityEngine.Rendering.GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField;
                /*0xf0*/ UnityEngine.Rendering.Universal.StoreActionsOptimization m_StoreActionsOptimizationSetting;
                /*0xf8*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> m_ActiveRenderPassQueue;
                /*0x100*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> m_RendererFeatures;
                /*0x108*/ UnityEngine.Rendering.RenderTargetIdentifier m_CameraColorTarget;
                /*0x130*/ UnityEngine.Rendering.RenderTargetIdentifier m_CameraDepthTarget;
                /*0x158*/ UnityEngine.Rendering.RenderTargetIdentifier m_CameraResolveTarget;
                /*0x180*/ bool m_FirstTimeCameraColorTargetIsBound;
                /*0x181*/ bool m_FirstTimeCameraDepthTargetIsBound;
                /*0x182*/ bool m_IsPipelineExecuting;
                /*0x183*/ bool isCameraColorTargetValid;
                /*0x184*/ bool disableNativeRenderPassInFeatures;
                /*0x185*/ bool useRenderPassEnabled;
                /*0x186*/ bool <useDepthPriming>k__BackingField;
                /*0x187*/ bool <stripShadowsOffVariants>k__BackingField;
                /*0x188*/ bool <stripAdditionalLightOffVariants>k__BackingField;

                static /*0x26e86a0*/ ScriptableRenderer();
                static /*0x26e2a00*/ uint GetSubPassAttachmentIndicesCount(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x26e2b64*/ bool AreAttachmentIndicesCompatible(UnityEngine.Rendering.Universal.ScriptableRenderPass lastSubPass, UnityEngine.Rendering.Universal.ScriptableRenderPass currentSubPass);
                static /*0x26e2d28*/ uint GetValidColorAttachmentCount(UnityEngine.Rendering.AttachmentDescriptor[] colorAttachments);
                static /*0x26e2c58*/ int GetValidInputAttachmentCount(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x26e1bd0*/ int FindAttachmentDescriptorIndexInList(int attachmentIdx, UnityEngine.Rendering.AttachmentDescriptor attachmentDescriptor, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x26e0bfc*/ int FindAttachmentDescriptorIndexInList(UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x26dfe70*/ int GetValidPassIndexCount(int[] array);
                static /*0x26e0ce0*/ bool PassHasInputAttachments(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x26e2e70*/ UnityEngine.Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex);
                static /*0x26dfdd4*/ UnityEngine.Hash128 CreateRenderPassHash(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex);
                static /*0x26e0b14*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultGraphicsFormat(UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x26e2ef8*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool setInverseMatrices);
                static /*0x26e3bbc*/ void CalculateBillboardProperties(ref UnityEngine.Matrix4x4 worldToCameraMatrix, ref UnityEngine.Vector3 billboardTangent, ref UnityEngine.Vector3 billboardNormal, ref float cameraXZAngle);
                static /*0x26e4514*/ void ConfigureActiveTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                static /*0x26e6508*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x26de1e8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x26e8090*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x26e8590*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x26e83a8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x26e7f70*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x26e5c5c*/ void SortStable(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> list);
                /*0x26de810*/ ScriptableRenderer(UnityEngine.Rendering.Universal.ScriptableRendererData data);
                /*0x26df414*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepth();
                /*0x26df428*/ void ResetNativeRenderPassFrameData();
                /*0x26df578*/ void SetupNativeRenderPassFrameData(UnityEngine.Rendering.Universal.CameraData cameraData, bool isRenderPassEnabled);
                /*0x26dfec4*/ void UpdateFinalStoreActions(int[] currentMergeablePasses, UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e00e0*/ void SetNativeRenderPassMRTAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool needCustomCameraColorClear, UnityEngine.Rendering.ClearFlag clearFlag);
                /*0x26e106c*/ bool IsDepthOnlyRenderTexture(UnityEngine.RenderTexture t);
                /*0x26e10c4*/ void SetNativeRenderPassAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RenderTargetIdentifier passColorAttachment, UnityEngine.Rendering.RenderTargetIdentifier passDepthAttachment, UnityEngine.Rendering.ClearFlag finalClearFlag, UnityEngine.Color finalClearColor);
                /*0x26e1cfc*/ void ConfigureNativeRenderPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e1f94*/ void ExecuteNativeRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e0d70*/ void SetupInputAttachmentIndices(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x26e0f58*/ void SetupTransientInputAttachments(int attachmentCount);
                /*0x26dfce8*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x26e2ea8*/ int SupportedCameraStackingTypes();
                /*0x26e2eb0*/ bool SupportsCameraStackingType(UnityEngine.Rendering.Universal.CameraRenderType cameraRenderType);
                /*0x26e2ee0*/ UnityEngine.Rendering.ProfilingSampler get_profilingExecute();
                /*0x26e2ee8*/ void set_profilingExecute(UnityEngine.Rendering.ProfilingSampler value);
                /*0x26e2ef0*/ UnityEngine.Rendering.Universal.DebugHandler get_DebugHandler();
                /*0x26e340c*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e39d8*/ void SetPerCameraBillboardProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e3f98*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e4238*/ void SetShaderTimeValues(UnityEngine.Rendering.CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime);
                /*0x26de56c*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraColorTarget();
                /*0x26e441c*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26e4458*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthTarget();
                /*0x26e44e4*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x26e44ec*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> get_activeRenderPassQueue();
                /*0x26e44f4*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures();
                /*0x26e44fc*/ void set_supportedRenderingFeatures(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures value);
                /*0x26e4504*/ UnityEngine.Rendering.GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes();
                /*0x26e450c*/ void set_unsupportedGraphicsDeviceTypes(UnityEngine.Rendering.GraphicsDeviceType[] value);
                /*0x26e46b0*/ bool get_useDepthPriming();
                /*0x26e46b8*/ void set_useDepthPriming(bool value);
                /*0x26e46c4*/ bool get_stripShadowsOffVariants();
                /*0x26e46cc*/ void set_stripShadowsOffVariants(bool value);
                /*0x26e46d8*/ bool get_stripAdditionalLightOffVariants();
                /*0x26e46e0*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x26e4938*/ void Dispose();
                /*0x26e4a68*/ void Dispose(bool disposing);
                /*0x26e4a6c*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget);
                /*0x26e4a94*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget, UnityEngine.Rendering.RenderTargetIdentifier resolveTarget);
                /*0x26e4ad0*/ void ConfigureCameraColorTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget);
                void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e4ae8*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e4aec*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e4af0*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26e4af4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e6454*/ void EnqueuePass(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x26e6664*/ void OnPreCullRenderPasses(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e6728*/ void AddRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e5940*/ void ClearRenderingState(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26e46fc*/ void Clear(UnityEngine.Rendering.Universal.CameraRenderType cameraType);
                /*0x26e5f40*/ void ExecuteBlock(int blockIndex, ref UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks renderBlocks, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool submit);
                /*0x26e6e74*/ bool IsRenderPassEnabled(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x26e6ac0*/ void ExecuteRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e6ea4*/ void SetRenderPassAttachments(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e604c*/ void BeginXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e6108*/ void EndXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26e8674*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x26e8678*/ void EnableSwapBufferMSAA(bool enable);
                /*0x26e867c*/ void DrawGizmos(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x26e8680*/ void DrawWireOverlay(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x26e5768*/ void InternalStartRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26e61b4*/ void InternalFinishRendering(UnityEngine.Rendering.ScriptableRenderContext context, bool resolveFinalTarget);

                class Profiling
                {
                    static string k_Name = "ScriptableRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setMRTAttachmentsList;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setAttachmentList;
                    static /*0x10*/ UnityEngine.Rendering.ProfilingSampler configure;
                    static /*0x18*/ UnityEngine.Rendering.ProfilingSampler execute;
                    static /*0x20*/ UnityEngine.Rendering.ProfilingSampler setupFrameData;
                    static /*0x28*/ UnityEngine.Rendering.ProfilingSampler setPerCameraShaderVariables;
                    static /*0x30*/ UnityEngine.Rendering.ProfilingSampler sortRenderPasses;
                    static /*0x38*/ UnityEngine.Rendering.ProfilingSampler setupLights;
                    static /*0x40*/ UnityEngine.Rendering.ProfilingSampler setupCamera;
                    static /*0x48*/ UnityEngine.Rendering.ProfilingSampler addRenderPasses;
                    static /*0x50*/ UnityEngine.Rendering.ProfilingSampler clearRenderingState;
                    static /*0x58*/ UnityEngine.Rendering.ProfilingSampler internalStartRendering;
                    static /*0x60*/ UnityEngine.Rendering.ProfilingSampler internalFinishRendering;
                    static /*0x68*/ UnityEngine.Rendering.ProfilingSampler drawGizmos;

                    static /*0x26e9694*/ Profiling();

                    class RenderBlock
                    {
                        static string k_Name = "RenderPassBlock";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beforeRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler mainRenderingOpaque;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler mainRenderingTransparent;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler afterRendering;

                        static /*0x26e9a30*/ RenderBlock();
                    }

                    class RenderPass
                    {
                        static string k_Name = "ScriptableRenderPass";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler configure;

                        static /*0x26e9b74*/ RenderPass();
                    }
                }

                struct RenderPassDescriptor
                {
                    /*0x10*/ int w;
                    /*0x14*/ int h;
                    /*0x18*/ int samples;
                    /*0x1c*/ int depthID;

                    /*0x26e2e9c*/ RenderPassDescriptor(int width, int height, int sampleCount, int rtID);
                }

                class RenderingFeatures
                {
                    /*0x10*/ bool <cameraStacking>k__BackingField;
                    /*0x11*/ bool <msaa>k__BackingField;

                    /*0x26e46ec*/ RenderingFeatures();
                    /*0x26e9c04*/ bool get_cameraStacking();
                    /*0x26e9c0c*/ void set_cameraStacking(bool value);
                    /*0x26e9c18*/ bool get_msaa();
                    /*0x26e9c20*/ void set_msaa(bool value);
                }

                class RenderPassBlock
                {
                    static /*0x0*/ int BeforeRendering;
                    static /*0x4*/ int MainRenderingOpaque;
                    static /*0x8*/ int MainRenderingTransparent;
                    static /*0xc*/ int AfterRendering;

                    static /*0x26e9c2c*/ RenderPassBlock();
                }

                struct RenderBlocks : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.RenderPassEvent> m_BlockEventLimits;
                    /*0x20*/ Unity.Collections.NativeArray<int> m_BlockRanges;
                    /*0x30*/ Unity.Collections.NativeArray<int> m_BlockRangeLengths;

                    /*0x26e5d80*/ RenderBlocks(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x26e9d84*/ void Dispose();
                    /*0x26e9c7c*/ void FillBlockRanges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x26e5f34*/ int GetLength(int index);
                    /*0x26e6a8c*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index);

                    struct BlockRange : System.IDisposable
                    {
                        /*0x10*/ int m_Current;
                        /*0x14*/ int m_End;

                        /*0x26e9dd8*/ BlockRange(int begin, int end);
                        /*0x26e6ab8*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator();
                        /*0x26e6e58*/ bool MoveNext();
                        /*0x26e9df4*/ int get_Current();
                        /*0x26e9dfc*/ void Dispose();
                    }
                }
            }

            class URPHelpURLAttribute : UnityEngine.Rendering.CoreRPHelpURLAttribute
            {
                /*0x26e9e00*/ URPHelpURLAttribute(string pageName);
            }

            class Documentation : UnityEngine.Rendering.DocumentationInfo
            {
                static string packageName = "com.unity.render-pipelines.universal";

                static /*0x26e9e5c*/ string GetPageLink(string pageName);
                /*0x26e9ea8*/ Documentation();
            }

            class ForwardRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData
            {
                static string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";
                /*0x40*/ UnityEngine.Rendering.Universal.ForwardRendererData.ShaderResources shaders;
                /*0x48*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x50*/ UnityEngine.Rendering.Universal.XRSystemData xrSystemData;
                /*0x58*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x5c*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x60*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x68*/ bool m_ShadowTransparentReceive;
                /*0x6c*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x70*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x74*/ bool m_AccurateGbufferNormals;
                /*0x75*/ bool m_ClusteredRendering;
                /*0x78*/ UnityEngine.Rendering.Universal.TileSize m_TileSize;

                /*0x26ea32c*/ ForwardRendererData();
                /*0x26e9eb0*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x26e9f6c*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x26e9fbc*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x26ea00c*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x26ea05c*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x26ea0ac*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x26ea0fc*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x26ea14c*/ bool get_shadowTransparentReceive();
                /*0x26ea19c*/ void set_shadowTransparentReceive(bool value);
                /*0x26ea1ec*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x26ea23c*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x26ea28c*/ bool get_accurateGbufferNormals();
                /*0x26ea2dc*/ void set_accurateGbufferNormals(bool value);

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader blitPS;
                    /*0x18*/ UnityEngine.Shader copyDepthPS;
                    /*0x20*/ UnityEngine.Shader screenSpaceShadowPS;
                    /*0x28*/ UnityEngine.Shader samplingPS;
                    /*0x30*/ UnityEngine.Shader stencilDeferredPS;
                    /*0x38*/ UnityEngine.Shader fallbackErrorPS;
                    /*0x40*/ UnityEngine.Shader materialErrorPS;
                    /*0x48*/ UnityEngine.Shader coreBlitPS;
                    /*0x50*/ UnityEngine.Shader coreBlitColorAndDepthPS;
                    /*0x58*/ UnityEngine.Shader cameraMotionVector;
                    /*0x60*/ UnityEngine.Shader objectMotionVector;

                    /*0x26ea334*/ ShaderResources();
                }
            }

            enum IntermediateTextureMode
            {
                Auto = 0,
                Always = 1,
            }

            class LightCookieManager : System.IDisposable
            {
                static int k_MaxCookieSizeDivisor = 16;
                static /*0x0*/ UnityEngine.Matrix4x4 s_DirLightProj;
                /*0x10*/ UnityEngine.Rendering.Texture2DAtlas m_AdditionalLightsCookieAtlas;
                /*0x18*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderData m_AdditionalLightsCookieShaderData;
                /*0x20*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings m_Settings;
                /*0x40*/ UnityEngine.Rendering.Universal.LightCookieManager.WorkMemory m_WorkMem;
                /*0x48*/ int[] m_VisibleLightIndexToShaderDataIndex;
                /*0x50*/ int m_CookieSizeDivisor;
                /*0x54*/ uint m_PrevCookieRequestPixelCount;
                /*0x58*/ bool <IsKeywordLightCookieEnabled>k__BackingField;

                static /*0x26ec504*/ LightCookieManager();
                /*0x26ea350*/ LightCookieManager(ref UnityEngine.Rendering.Universal.LightCookieManager.Settings settings);
                /*0x26ea33c*/ bool get_IsKeywordLightCookieEnabled();
                /*0x26ea344*/ void set_IsKeywordLightCookieEnabled(bool value);
                /*0x26ea3ec*/ void InitAdditionalLights(int size);
                /*0x26ea5cc*/ bool isInitialized();
                /*0x26ea5ec*/ void Dispose();
                /*0x26ea620*/ int GetLightCookieShaderDataIndex(int visibleLightIndex);
                /*0x26ea668*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext ctx, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                /*0x26ea8f4*/ bool SetupMainLight(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight visibleMainLight);
                /*0x26eaebc*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(UnityEngine.Experimental.Rendering.GraphicsFormat cookieFormat);
                /*0x26eaf90*/ void GetLightUVScaleOffset(ref UnityEngine.Rendering.Universal.UniversalAdditionalLightData additionalLightData, ref UnityEngine.Matrix4x4 uvTransform);
                /*0x26ead28*/ bool SetupAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                /*0x26eb0d0*/ int FilterAndValidateAdditionalLights(ref UnityEngine.Rendering.Universal.LightData lightData, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] validLightMappings);
                /*0x26eb48c*/ int UpdateAdditionalLightsAtlas(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects);
                /*0x26ebc9c*/ int FetchUVRects(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects, int cookieSizeDivisor);
                /*0x26ebb74*/ uint ComputeCookieRequestPixelCount(ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings);
                /*0x26ebc70*/ int ApproximateCookieSizeDivisor(float requestAtlasRatio);
                /*0x26ec058*/ UnityEngine.Vector4 Fetch2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x26ebef4*/ UnityEngine.Vector4 FetchCube(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x26ec354*/ int ComputeOctahedralCookieSize(UnityEngine.Texture cookie);
                /*0x26ec1b0*/ void AdjustUVRect(ref UnityEngine.Vector4 uvScaleOffset, UnityEngine.Texture cookie, ref UnityEngine.Vector2 cookieSize);
                /*0x26ec474*/ void ShrinkUVRect(ref UnityEngine.Vector4 uvScaleOffset, float amountPixels, ref UnityEngine.Vector2 cookieSize);
                /*0x26eb60c*/ void UploadAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Vector4> validUvRects);

                class ShaderProperty
                {
                    static /*0x0*/ int mainLightTexture;
                    static /*0x4*/ int mainLightWorldToLight;
                    static /*0x8*/ int mainLightCookieTextureFormat;
                    static /*0xc*/ int additionalLightsCookieAtlasTexture;
                    static /*0x10*/ int additionalLightsCookieAtlasTextureFormat;
                    static /*0x14*/ int additionalLightsCookieEnableBits;
                    static /*0x18*/ int additionalLightsCookieAtlasUVRectBuffer;
                    static /*0x1c*/ int additionalLightsCookieAtlasUVRects;
                    static /*0x20*/ int additionalLightsWorldToLightBuffer;
                    static /*0x24*/ int additionalLightsLightTypeBuffer;
                    static /*0x28*/ int additionalLightsWorldToLights;
                    static /*0x2c*/ int additionalLightsLightTypes;

                    static /*0x26ec58c*/ ShaderProperty();
                }

                enum LightCookieShaderFormat
                {
                    None = -1,
                    RGB = 0,
                    Alpha = 1,
                    Red = 2,
                }

                struct Settings
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings.AtlasSettings atlas;
                    /*0x20*/ int maxAdditionalLights;
                    /*0x24*/ float cubeOctahedralSizeScale;
                    /*0x28*/ bool useStructuredBuffer;

                    static /*0x26ec7f8*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings GetDefault();

                    struct AtlasSettings
                    {
                        /*0x10*/ UnityEngine.Vector2Int resolution;
                        /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;
                        /*0x1c*/ bool useMips;

                        /*0x26ea598*/ bool get_isPow2();
                        /*0x26ec8c4*/ bool get_isSquare();
                    }
                }

                struct Sorting
                {
                    static void QuickSort<T>(T[] data, System.Func<T, T, int> compare);
                    static void QuickSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                    static T Median3Pivot<T>(T[] data, int start, int pivot, int end, System.Func<T, T, int> compare);
                    static int Partition<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                    static void InsertionSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                    static void <Median3Pivot>g__Swap|2_0<T>(int a, int b, ref UnityEngine.Rendering.Universal.LightCookieManager.Sorting.<>c__DisplayClass2_0<T> );

                    struct <>c__DisplayClass2_0<T>
                    {
                        /*0x0*/ T[] data;
                    }
                }

                struct LightCookieMapping
                {
                    static /*0x0*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByCookieSize;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByBufferIndex;
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort lightBufferIndex;
                    /*0x18*/ UnityEngine.Light light;

                    static /*0x26ed8d4*/ LightCookieMapping();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping.<> <>9;

                        static /*0x26ed9ec*/ <>c();
                        /*0x26eda50*/ <>c();
                        /*0x26eda58*/ int <.cctor>b__6_0(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                        /*0x26edb24*/ int <.cctor>b__6_1(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                    }
                }

                struct WorkSlice<T>
                {
                    /*0x0*/ T[] m_Data;
                    /*0x0*/ int m_Start;
                    /*0x0*/ int m_Length;

                    WorkSlice(T[] src, int srcLen);
                    WorkSlice(T[] src, int srcStart, int srcLen);
                    T get_Item(int index);
                    void set_Item(int index, T value);
                    int get_length();
                    int get_capacity();
                    void Sort(System.Func<T, T, int> compare);
                }

                class WorkMemory
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] lightMappings;
                    /*0x18*/ UnityEngine.Vector4[] uvRects;

                    /*0x26edc58*/ WorkMemory();
                    /*0x26edb30*/ void Resize(int size);
                }

                struct ShaderBitArray
                {
                    static int k_BitsPerElement = 32;
                    static int k_ElementShift = 5;
                    static int k_ElementMask = 31;
                    /*0x10*/ float[] m_Data;

                    /*0x26edc60*/ int get_elemLength();
                    /*0x26edc78*/ int get_bitCapacity();
                    /*0x26edc94*/ float[] get_data();
                    /*0x26edc9c*/ void Resize(int bitCount);
                    /*0x26edde0*/ void Clear();
                    /*0x26ede30*/ void GetElementIndexAndBitOffset(int index, ref int elemIndex, ref int bitOffset);
                    /*0x26ede44*/ bool get_Item(int index);
                    /*0x26ede80*/ void set_Item(int index, bool value);
                    /*0x26edec8*/ string ToString();
                }

                class LightCookieShaderData : System.IDisposable
                {
                    /*0x10*/ int m_Size;
                    /*0x14*/ bool m_UseStructuredBuffer;
                    /*0x18*/ UnityEngine.Matrix4x4[] m_WorldToLightCpuData;
                    /*0x20*/ UnityEngine.Vector4[] m_AtlasUVRectCpuData;
                    /*0x28*/ float[] m_LightTypeCpuData;
                    /*0x30*/ UnityEngine.Rendering.Universal.LightCookieManager.ShaderBitArray m_CookieEnableBitsCpuData;
                    /*0x38*/ UnityEngine.ComputeBuffer m_WorldToLightBuffer;
                    /*0x40*/ UnityEngine.ComputeBuffer m_AtlasUVRectBuffer;
                    /*0x48*/ UnityEngine.ComputeBuffer m_LightTypeBuffer;
                    /*0x50*/ bool <isUploaded>k__BackingField;

                    /*0x26ee06c*/ LightCookieShaderData(int size, bool useStructuredBuffer);
                    /*0x26ee038*/ UnityEngine.Matrix4x4[] get_worldToLights();
                    /*0x26ee040*/ UnityEngine.Rendering.Universal.LightCookieManager.ShaderBitArray get_cookieEnableBits();
                    /*0x26ee048*/ UnityEngine.Vector4[] get_atlasUVRects();
                    /*0x26ee050*/ float[] get_lightTypes();
                    /*0x26ee058*/ bool get_isUploaded();
                    /*0x26ee060*/ void set_isUploaded(bool value);
                    /*0x26ee294*/ void Dispose();
                    /*0x26ee0a0*/ void Resize(int size);
                    /*0x26ee2e0*/ void Upload(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x26ee474*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd);
                }
            }

            class MotionVectorsPersistentData
            {
                /*0x10*/ UnityEngine.Matrix4x4[] m_ViewProjection;
                /*0x18*/ UnityEngine.Matrix4x4[] m_PreviousViewProjection;
                /*0x20*/ int[] m_LastFrameIndex;
                /*0x28*/ float[] m_PrevAspectRatio;

                /*0x26ee500*/ MotionVectorsPersistentData();
                /*0x26ee700*/ int get_lastFrameIndex();
                /*0x26ee728*/ UnityEngine.Matrix4x4 get_viewProjection();
                /*0x26ee75c*/ UnityEngine.Matrix4x4 get_previousViewProjection();
                /*0x26ee790*/ UnityEngine.Matrix4x4[] get_viewProjectionStereo();
                /*0x26ee798*/ UnityEngine.Matrix4x4[] get_previousViewProjectionStereo();
                /*0x26ee7a0*/ int GetXRMultiPassId(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26ee7dc*/ void Update(ref UnityEngine.Rendering.Universal.CameraData cameraData);
            }

            class Bloom : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.MinFloatParameter threshold;
                /*0x38*/ UnityEngine.Rendering.MinFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter scatter;
                /*0x48*/ UnityEngine.Rendering.MinFloatParameter clamp;
                /*0x50*/ UnityEngine.Rendering.ColorParameter tint;
                /*0x58*/ UnityEngine.Rendering.BoolParameter highQualityFiltering;
                /*0x60*/ UnityEngine.Rendering.ClampedIntParameter skipIterations;
                /*0x68*/ UnityEngine.Rendering.TextureParameter dirtTexture;
                /*0x70*/ UnityEngine.Rendering.MinFloatParameter dirtIntensity;

                /*0x26eef0c*/ Bloom();
                /*0x26eeed8*/ bool IsActive();
                /*0x26eef04*/ bool IsTileCompatible();
            }

            class ChannelMixer : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ClampedFloatParameter redOutRedIn;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter redOutGreenIn;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter redOutBlueIn;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter greenOutRedIn;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter greenOutGreenIn;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter greenOutBlueIn;
                /*0x60*/ UnityEngine.Rendering.ClampedFloatParameter blueOutRedIn;
                /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter blueOutGreenIn;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter blueOutBlueIn;

                /*0x26ef284*/ ChannelMixer();
                /*0x26ef14c*/ bool IsActive();
                /*0x26ef27c*/ bool IsTileCompatible();
            }

            class ChromaticAberration : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ClampedFloatParameter intensity;

                /*0x26ef4e4*/ ChromaticAberration();
                /*0x26ef4b0*/ bool IsActive();
                /*0x26ef4dc*/ bool IsTileCompatible();
            }

            class ColorAdjustments : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.FloatParameter postExposure;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter contrast;
                /*0x40*/ UnityEngine.Rendering.ColorParameter colorFilter;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter hueShift;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter saturation;

                /*0x26ef644*/ ColorAdjustments();
                /*0x26ef55c*/ bool IsActive();
                /*0x26ef63c*/ bool IsTileCompatible();
            }

            class ColorCurves : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.TextureCurveParameter master;
                /*0x38*/ UnityEngine.Rendering.TextureCurveParameter red;
                /*0x40*/ UnityEngine.Rendering.TextureCurveParameter green;
                /*0x48*/ UnityEngine.Rendering.TextureCurveParameter blue;
                /*0x50*/ UnityEngine.Rendering.TextureCurveParameter hueVsHue;
                /*0x58*/ UnityEngine.Rendering.TextureCurveParameter hueVsSat;
                /*0x60*/ UnityEngine.Rendering.TextureCurveParameter satVsSat;
                /*0x68*/ UnityEngine.Rendering.TextureCurveParameter lumVsSat;

                /*0x26ef7cc*/ ColorCurves();
                /*0x26ef7bc*/ bool IsActive();
                /*0x26ef7c4*/ bool IsTileCompatible();
            }

            class ColorLookup : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.TextureParameter texture;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter contribution;

                /*0x26f00b4*/ ColorLookup();
                /*0x26efe24*/ bool IsActive();
                /*0x26f00ac*/ bool IsTileCompatible();
                /*0x26efe64*/ bool ValidateLUT();
            }

            enum DepthOfFieldMode
            {
                Off = 0,
                Gaussian = 1,
                Bokeh = 2,
            }

            class DepthOfField : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.Universal.DepthOfFieldModeParameter mode;
                /*0x38*/ UnityEngine.Rendering.MinFloatParameter gaussianStart;
                /*0x40*/ UnityEngine.Rendering.MinFloatParameter gaussianEnd;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter gaussianMaxRadius;
                /*0x50*/ UnityEngine.Rendering.BoolParameter highQualitySampling;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter focusDistance;
                /*0x60*/ UnityEngine.Rendering.ClampedFloatParameter aperture;
                /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter focalLength;
                /*0x70*/ UnityEngine.Rendering.ClampedIntParameter bladeCount;
                /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter bladeCurvature;
                /*0x80*/ UnityEngine.Rendering.ClampedFloatParameter bladeRotation;

                /*0x26f01e4*/ DepthOfField();
                /*0x26f0164*/ bool IsActive();
                /*0x26f01dc*/ bool IsTileCompatible();
            }

            class DepthOfFieldModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.DepthOfFieldMode>
            {
                /*0x26f0468*/ DepthOfFieldModeParameter(UnityEngine.Rendering.Universal.DepthOfFieldMode value, bool overrideState);
            }

            enum FilmGrainLookup
            {
                Thin1 = 0,
                Thin2 = 1,
                Medium1 = 2,
                Medium2 = 3,
                Medium3 = 4,
                Medium4 = 5,
                Medium5 = 6,
                Medium6 = 7,
                Large01 = 8,
                Large02 = 9,
                Custom = 10,
            }

            class FilmGrain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.Universal.FilmGrainLookupParameter type;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter response;
                /*0x48*/ UnityEngine.Rendering.NoInterpTextureParameter texture;

                /*0x26f059c*/ FilmGrain();
                /*0x26f04c8*/ bool IsActive();
                /*0x26f0594*/ bool IsTileCompatible();
            }

            class FilmGrainLookupParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.FilmGrainLookup>
            {
                /*0x26f06b0*/ FilmGrainLookupParameter(UnityEngine.Rendering.Universal.FilmGrainLookup value, bool overrideState);
            }

            class LensDistortion : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter xMultiplier;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter yMultiplier;
                /*0x48*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter scale;

                /*0x26f0794*/ LensDistortion();
                /*0x26f0710*/ bool IsActive();
                /*0x26f078c*/ bool IsTileCompatible();
            }

            class LiftGammaGain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.Vector4Parameter lift;
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter gamma;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter gain;

                /*0x26f0988*/ LiftGammaGain();
                /*0x26f08d8*/ bool IsActive();
                /*0x26f0980*/ bool IsTileCompatible();
            }

            enum MotionBlurMode
            {
                CameraOnly = 0,
                CameraAndObjects = 1,
            }

            enum MotionBlurQuality
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class MotionBlur : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.Universal.MotionBlurModeParameter mode;
                /*0x38*/ UnityEngine.Rendering.Universal.MotionBlurQualityParameter quality;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter clamp;

                /*0x26f0ac0*/ MotionBlur();
                /*0x26f0a64*/ bool IsActive();
                /*0x26f0ab8*/ bool IsTileCompatible();
            }

            class MotionBlurModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurMode>
            {
                /*0x26f0bd4*/ MotionBlurModeParameter(UnityEngine.Rendering.Universal.MotionBlurMode value, bool overrideState);
            }

            class MotionBlurQualityParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurQuality>
            {
                /*0x26f0c34*/ MotionBlurQualityParameter(UnityEngine.Rendering.Universal.MotionBlurQuality value, bool overrideState);
            }

            class PaniniProjection : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ClampedFloatParameter distance;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter cropToFit;

                /*0x26f0cc8*/ PaniniProjection();
                /*0x26f0c94*/ bool IsActive();
                /*0x26f0cc0*/ bool IsTileCompatible();
            }

            class ShadowsMidtonesHighlights : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.Vector4Parameter shadows;
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter midtones;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter highlights;
                /*0x48*/ UnityEngine.Rendering.MinFloatParameter shadowsStart;
                /*0x50*/ UnityEngine.Rendering.MinFloatParameter shadowsEnd;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter highlightsStart;
                /*0x60*/ UnityEngine.Rendering.MinFloatParameter highlightsEnd;

                /*0x26f0e1c*/ ShadowsMidtonesHighlights();
                /*0x26f0d6c*/ bool IsActive();
                /*0x26f0e14*/ bool IsTileCompatible();
            }

            class SplitToning : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ColorParameter shadows;
                /*0x38*/ UnityEngine.Rendering.ColorParameter highlights;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter balance;

                /*0x26f1044*/ SplitToning();
                /*0x26f0fb4*/ bool IsActive();
                /*0x26f103c*/ bool IsTileCompatible();
            }

            enum TonemappingMode
            {
                None = 0,
                Neutral = 1,
                ACES = 2,
            }

            class Tonemapping : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.Universal.TonemappingModeParameter mode;

                /*0x26f1184*/ Tonemapping();
                /*0x26f1150*/ bool IsActive();
                /*0x26f117c*/ bool IsTileCompatible();
            }

            class TonemappingModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.TonemappingMode>
            {
                /*0x26f11f0*/ TonemappingModeParameter(UnityEngine.Rendering.Universal.TonemappingMode value, bool overrideState);
            }

            class Vignette : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ColorParameter color;
                /*0x38*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter smoothness;
                /*0x50*/ UnityEngine.Rendering.BoolParameter rounded;

                /*0x26f1284*/ Vignette();
                /*0x26f1250*/ bool IsActive();
                /*0x26f127c*/ bool IsTileCompatible();
            }

            class WhiteBalance : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x30*/ UnityEngine.Rendering.ClampedFloatParameter temperature;
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter tint;

                /*0x26f1450*/ WhiteBalance();
                /*0x26f13f4*/ bool IsActive();
                /*0x26f1448*/ bool IsTileCompatible();
            }

            class CapturePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string m_ProfilerTag = "Capture Pass";
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xd8*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_CameraColorHandle;

                static /*0x26f1968*/ CapturePass();
                /*0x26f1504*/ CapturePass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x26f1598*/ void Setup(UnityEngine.Rendering.Universal.RenderTargetHandle colorHandle);
                /*0x26f15b0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class DrawSkyboxPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x26f19f8*/ DrawSkyboxPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x26f1a8c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class InvokeOnRenderObjectCallbackPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x26f1e0c*/ InvokeOnRenderObjectCallbackPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x26f1ea0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            interface IPostProcessComponent
            {
                bool IsActive();
                bool IsTileCompatible();
            }

            enum ScriptableRenderPassInput
            {
                None = 0,
                Depth = 1,
                Normal = 2,
                Color = 4,
                Motion = 8,
            }

            enum RenderPassEvent
            {
                BeforeRendering = 0,
                BeforeRenderingShadows = 50,
                AfterRenderingShadows = 100,
                BeforeRenderingPrePasses = 150,
                BeforeRenderingPrepasses = 151,
                AfterRenderingPrePasses = 200,
                BeforeRenderingGbuffer = 210,
                AfterRenderingGbuffer = 220,
                BeforeRenderingDeferredLights = 230,
                AfterRenderingDeferredLights = 240,
                BeforeRenderingOpaques = 250,
                AfterRenderingOpaques = 300,
                BeforeRenderingSkybox = 350,
                AfterRenderingSkybox = 400,
                BeforeRenderingTransparents = 450,
                AfterRenderingTransparents = 500,
                BeforeRenderingPostProcessing = 550,
                AfterRenderingPostProcessing = 600,
                AfterRendering = 1000,
            }

            class TransparentSettingsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string m_ProfilerTag = "Transparent Settings Pass";
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xd8*/ bool m_shouldReceiveShadows;

                static /*0x26f216c*/ TransparentSettingsPass();
                /*0x26f1ebc*/ TransparentSettingsPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool shadowReceiveSupported);
                /*0x26f1f5c*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26f1f6c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class XROcclusionMeshPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x26f21fc*/ XROcclusionMeshPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x26f2290*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            struct PostProcessPasses : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass m_ColorGradingLutPass;
                /*0x18*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass m_PostProcessPass;
                /*0x20*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass m_FinalPostProcessPass;
                /*0x28*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_AfterPostProcessColor;
                /*0x58*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_ColorGradingLut;
                /*0x88*/ UnityEngine.Rendering.Universal.PostProcessData m_RendererPostProcessData;
                /*0x90*/ UnityEngine.Rendering.Universal.PostProcessData m_CurrentPostProcessData;
                /*0x98*/ UnityEngine.Material m_BlitMaterial;

                /*0x26f23e4*/ PostProcessPasses(UnityEngine.Rendering.Universal.PostProcessData rendererPostProcessData, UnityEngine.Material blitMaterial);
                /*0x26f233c*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x26f2344*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass get_postProcessPass();
                /*0x26f234c*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass get_finalPostProcessPass();
                /*0x26f2354*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_afterPostProcessColor();
                /*0x26f236c*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_colorGradingLut();
                /*0x26f2384*/ bool get_isCreated();
                /*0x26f24bc*/ void Recreate(UnityEngine.Rendering.Universal.PostProcessData data);
                /*0x26f268c*/ void Dispose();
            }

            class PostProcessUtils
            {
                static /*0x26f26d0*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x26f2734*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x26f2898*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x26f28fc*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x26f2b70*/ void SetSourceSize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor desc);

                class ShaderConstants
                {
                    static /*0x0*/ int _Grain_Texture;
                    static /*0x4*/ int _Grain_Params;
                    static /*0x8*/ int _Grain_TilingParams;
                    static /*0xc*/ int _BlueNoise_Texture;
                    static /*0x10*/ int _Dithering_Params;
                    static /*0x14*/ int _SourceSize;

                    static /*0x26f2c30*/ ShaderConstants();
                }
            }

            enum DecalSurfaceData
            {
                Albedo = 0,
                AlbedoNormal = 1,
                AlbedoNormalMAOS = 2,
            }

            enum DecalTechnique
            {
                Invalid = 0,
                DBuffer = 1,
                ScreenSpace = 2,
                GBuffer = 3,
            }

            enum DecalTechniqueOption
            {
                Automatic = 0,
                DBuffer = 1,
                ScreenSpace = 2,
            }

            class DBufferSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalSurfaceData surfaceData;

                /*0x26f2d8c*/ DBufferSettings();
            }

            enum DecalNormalBlend
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class DecalScreenSpaceSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalNormalBlend normalBlend;
                /*0x14*/ bool useGBuffer;

                /*0x26f2d9c*/ DecalScreenSpaceSettings();
            }

            class DecalSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalTechniqueOption technique;
                /*0x14*/ float maxDrawDistance;
                /*0x18*/ UnityEngine.Rendering.Universal.DBufferSettings dBufferSettings;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings screenSpaceSettings;

                /*0x26f2dac*/ DecalSettings();
            }

            class SharedDecalEntityManager : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x18*/ int m_ReferenceCounter;

                /*0x26f3280*/ SharedDecalEntityManager();
                /*0x26f2dbc*/ UnityEngine.Rendering.Universal.DecalEntityManager Get();
                /*0x26f3010*/ void Release(UnityEngine.Rendering.Universal.DecalEntityManager decalEntityManager);
                /*0x26f302c*/ void Dispose();
                /*0x26f3184*/ void OnDecalAdd(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x26f31d8*/ void OnDecalRemove(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x26f31fc*/ void OnDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x26f3258*/ void OnDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
            }

            class DecalRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalSettings m_Settings;
                /*0x28*/ UnityEngine.Shader m_CopyDepthPS;
                /*0x30*/ UnityEngine.Shader m_DBufferClear;
                /*0x38*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;
                /*0x40*/ UnityEngine.Rendering.Universal.DBufferSettings m_DBufferSettings;
                /*0x48*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_ScreenSpaceSettings;
                /*0x50*/ bool m_RecreateSystems;
                /*0x58*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_CopyDepthPass;
                /*0x60*/ UnityEngine.Rendering.Universal.DecalPreviewPass m_DecalPreviewPass;
                /*0x68*/ UnityEngine.Material m_CopyDepthMaterial;
                /*0x70*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x78*/ UnityEngine.Rendering.Universal.DecalUpdateCachedSystem m_DecalUpdateCachedSystem;
                /*0x80*/ UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem;
                /*0x88*/ UnityEngine.Rendering.Universal.DecalUpdateCulledSystem m_DecalUpdateCulledSystem;
                /*0x90*/ UnityEngine.Rendering.Universal.DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem;
                /*0x98*/ UnityEngine.Rendering.Universal.DecalDrawErrorSystem m_DrawErrorSystem;
                /*0xa0*/ UnityEngine.Rendering.Universal.DBufferRenderPass m_DBufferRenderPass;
                /*0xa8*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass m_ForwardEmissivePass;
                /*0xb0*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem m_DecalDrawDBufferSystem;
                /*0xb8*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem;
                /*0xc0*/ UnityEngine.Material m_DBufferClearMaterial;
                /*0xc8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass;
                /*0xd0*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem;
                /*0xd8*/ UnityEngine.Rendering.Universal.DecalSkipCulledSystem m_DecalSkipCulledSystem;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass m_GBufferRenderPass;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem m_DrawGBufferSystem;
                /*0xf0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                static /*0x26f4320*/ DecalRendererFeature();
                static /*0x26f3288*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager get_sharedDecalEntityManager();
                /*0x26f4298*/ DecalRendererFeature();
                /*0x26f32e0*/ bool get_intermediateRendering();
                /*0x26f32f0*/ void Create();
                /*0x26f3358*/ UnityEngine.Rendering.Universal.DBufferSettings GetDBufferSettings();
                /*0x26f33dc*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings GetScreenSpaceSettings();
                /*0x26f3464*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRendererData renderer);
                /*0x26f36e4*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x26f3584*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(bool isDeferred);
                /*0x26f37a0*/ bool IsAutomaticDBuffer();
                /*0x26f37d8*/ void RecreateSystemsIfNeeded(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26f3df0*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26f3ed8*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26f4180*/ bool SupportsNativeRenderPass();
                /*0x26f4194*/ void Dispose(bool disposing);
                /*0x26f4294*/ void ChangeAdaptivePerformanceDrawDistances();
            }

            class DisallowMultipleRendererFeature : System.Attribute
            {
                /*0x10*/ string <customTitle>k__BackingField;

                /*0x26f43a8*/ DisallowMultipleRendererFeature(string customTitle);
                /*0x26f4398*/ void set_customTitle(string value);
                /*0x26f43a0*/ string get_customTitle();
            }

            class ScreenSpaceAmbientOcclusionSettings
            {
                /*0x10*/ bool Downsample;
                /*0x11*/ bool AfterOpaque;
                /*0x14*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.DepthSource Source;
                /*0x18*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.NormalQuality NormalSamples;
                /*0x1c*/ float Intensity;
                /*0x20*/ float DirectLightingStrength;
                /*0x24*/ float Radius;
                /*0x28*/ int SampleCount;

                /*0x26f43d0*/ ScreenSpaceAmbientOcclusionSettings();

                enum DepthSource
                {
                    Depth = 0,
                    DepthNormals = 1,
                }

                enum NormalQuality
                {
                    Low = 0,
                    Medium = 1,
                    High = 2,
                }
            }

            class ScreenSpaceAmbientOcclusion : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceAmbientOcclusion";
                static string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
                static string k_NormalReconstructionLowKeyword = "_RECONSTRUCT_NORMAL_LOW";
                static string k_NormalReconstructionMediumKeyword = "_RECONSTRUCT_NORMAL_MEDIUM";
                static string k_NormalReconstructionHighKeyword = "_RECONSTRUCT_NORMAL_HIGH";
                static string k_SourceDepthKeyword = "_SOURCE_DEPTH";
                static string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
                /*0x20*/ UnityEngine.Shader m_Shader;
                /*0x28*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings m_Settings;
                /*0x30*/ UnityEngine.Material m_Material;
                /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass m_SSAOPass;

                /*0x26f4b88*/ ScreenSpaceAmbientOcclusion();
                /*0x26f43fc*/ bool get_afterOpaque();
                /*0x26f4418*/ void Create();
                /*0x26f4850*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26f4b2c*/ void Dispose(bool disposing);
                /*0x26f4704*/ bool GetMaterial();

                class ScreenSpaceAmbientOcclusionPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";
                    static string k_SSAOAmbientOcclusionParamName = "_AmbientOcclusionParam";
                    static /*0x0*/ int s_BaseMapID;
                    static /*0x4*/ int s_SSAOParamsID;
                    static /*0x8*/ int s_SSAOTexture1ID;
                    static /*0xc*/ int s_SSAOTexture2ID;
                    static /*0x10*/ int s_SSAOTexture3ID;
                    static /*0x14*/ int s_SSAOTextureFinalID;
                    static /*0x18*/ int s_CameraViewXExtentID;
                    static /*0x1c*/ int s_CameraViewYExtentID;
                    static /*0x20*/ int s_CameraViewZExtentID;
                    static /*0x24*/ int s_ProjectionParams2ID;
                    static /*0x28*/ int s_CameraViewProjectionsID;
                    static /*0x2c*/ int s_CameraViewTopLeftCornerID;
                    /*0xd8*/ bool m_SupportsR8RenderTextureFormat;
                    /*0xe0*/ UnityEngine.Material m_Material;
                    /*0xe8*/ UnityEngine.Vector4[] m_CameraTopLeftCorner;
                    /*0xf0*/ UnityEngine.Vector4[] m_CameraXExtent;
                    /*0xf8*/ UnityEngine.Vector4[] m_CameraYExtent;
                    /*0x100*/ UnityEngine.Vector4[] m_CameraZExtent;
                    /*0x108*/ UnityEngine.Matrix4x4[] m_CameraViewProjections;
                    /*0x110*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x118*/ UnityEngine.Rendering.Universal.ScriptableRenderer m_Renderer;
                    /*0x120*/ UnityEngine.Rendering.RenderTargetIdentifier m_SSAOTexture1Target;
                    /*0x148*/ UnityEngine.Rendering.RenderTargetIdentifier m_SSAOTexture2Target;
                    /*0x170*/ UnityEngine.Rendering.RenderTargetIdentifier m_SSAOTexture3Target;
                    /*0x198*/ UnityEngine.Rendering.RenderTargetIdentifier m_SSAOTextureFinalTarget;
                    /*0x1c0*/ UnityEngine.RenderTextureDescriptor m_AOPassDescriptor;
                    /*0x1f4*/ UnityEngine.RenderTextureDescriptor m_BlurPassesDescriptor;
                    /*0x228*/ UnityEngine.RenderTextureDescriptor m_FinalDescriptor;
                    /*0x260*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;

                    static /*0x26f6774*/ ScreenSpaceAmbientOcclusionPass();
                    /*0x26f4480*/ ScreenSpaceAmbientOcclusionPass();
                    /*0x26f4c1c*/ bool get_isRendererDeferred();
                    /*0x26f49cc*/ bool Setup(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings featureSettings, UnityEngine.Rendering.Universal.ScriptableRenderer renderer, UnityEngine.Material material);
                    /*0x26f4c88*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x26f5734*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x26f5e14*/ void Render(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                    /*0x26f5f5c*/ void RenderAndSetBaseMap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier baseMap, UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                    /*0x26f6614*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                    enum ShaderPasses
                    {
                        AO = 0,
                        BlurHorizontal = 1,
                        BlurVertical = 2,
                        BlurFinal = 3,
                        AfterOpaque = 4,
                    }
                }
            }

            class ScreenSpaceShadowsSettings
            {
                /*0x26f69e0*/ ScreenSpaceShadowsSettings();
            }

            class ScreenSpaceShadows : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";
                /*0x20*/ UnityEngine.Shader m_Shader;
                /*0x28*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_Settings;
                /*0x30*/ UnityEngine.Material m_Material;
                /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

                /*0x26f6f60*/ ScreenSpaceShadows();
                /*0x26f69e8*/ void Create();
                /*0x26f6c90*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26f6f04*/ void Dispose(bool disposing);
                /*0x26f6b44*/ bool LoadMaterial();

                class ScreenSpaceShadowsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static string k_SSShadowsTextureName = "_ScreenSpaceShadowmapTexture";
                    static /*0x0*/ string m_ProfilerTag;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0xd8*/ UnityEngine.Material m_Material;
                    /*0xe0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_CurrentSettings;
                    /*0xe8*/ UnityEngine.RenderTextureDescriptor m_RenderTextureDescriptor;
                    /*0x120*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_RenderTarget;

                    static /*0x26f7a0c*/ ScreenSpaceShadowsPass();
                    /*0x26f6aac*/ ScreenSpaceShadowsPass();
                    /*0x26f6e8c*/ bool Setup(UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings featureSettings, UnityEngine.Material material);
                    /*0x26f6fd0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x26f7338*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x26f79a0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class ScreenSpaceShadowsPostPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ string m_ProfilerTag;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;

                    static /*0x26f7d20*/ ScreenSpaceShadowsPostPass();
                    /*0x26f6b3c*/ ScreenSpaceShadowsPostPass();
                    /*0x26f7ac0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x26f7b0c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                }
            }

            class RenderingUtils
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_LegacyShaderPassNames;
                static /*0x8*/ UnityEngine.Rendering.AttachmentDescriptor s_EmptyAttachment;
                static /*0x80*/ UnityEngine.Mesh s_FullscreenMesh;
                static /*0x88*/ UnityEngine.Material s_ErrorMaterial;
                static /*0x90*/ int UNITY_STEREO_MATRIX_V;
                static /*0x94*/ int UNITY_STEREO_MATRIX_IV;
                static /*0x98*/ int UNITY_STEREO_MATRIX_P;
                static /*0x9c*/ int UNITY_STEREO_MATRIX_IP;
                static /*0xa0*/ int UNITY_STEREO_MATRIX_VP;
                static /*0xa4*/ int UNITY_STEREO_MATRIX_IVP;
                static /*0xa8*/ int UNITY_STEREO_CAMERA_PROJECTION;
                static /*0xac*/ int UNITY_STEREO_CAMERA_INV_PROJECTION;
                static /*0xb0*/ int UNITY_STEREO_VECTOR_CAMPOS;
                static /*0xb8*/ UnityEngine.Rendering.Universal.RenderingUtils.StereoConstants stereoConstants;
                static /*0xc0*/ System.Collections.Generic.Dictionary<UnityEngine.RenderTextureFormat, bool> m_RenderTextureFormatSupport;
                static /*0xc8*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.GraphicsFormat, System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.FormatUsage, bool>> m_GraphicsFormatSupport;

                static /*0x26f96d4*/ RenderingUtils();
                static /*0x26f7dd4*/ UnityEngine.Rendering.AttachmentDescriptor get_emptyAttachment();
                static /*0x26f603c*/ UnityEngine.Mesh get_fullscreenMesh();
                static /*0x26f7e38*/ bool get_useStructuredBuffer();
                static /*0x26f7e40*/ bool SupportsLightLayers(UnityEngine.Rendering.GraphicsDeviceType type);
                static /*0x26f7e4c*/ UnityEngine.Material get_errorMaterial();
                static /*0x26f7fe8*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x26f82cc*/ void SetStereoViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4[] viewMatrix, UnityEngine.Matrix4x4[] projMatrix, UnityEngine.Matrix4x4[] cameraProjMatrix, bool setInverseMatrices);
                static /*0x26f8874*/ void SetScaleBiasRt(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x26f89e0*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex, bool useDrawProcedural, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x26f8c94*/ void RenderObjectsWithError(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags);
                static /*0x26f8f34*/ void ClearSystemInfoCache();
                static /*0x26f8fd8*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
                static /*0x26f715c*/ bool SupportsGraphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
                static /*0x26f90d0*/ int GetLastValidColorBufferIndex(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x26f9188*/ uint GetValidColorBufferCount(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x26f9258*/ bool IsMRT(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x26f92b8*/ bool Contains(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x26f9364*/ int IndexOf(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x26f940c*/ uint CountDistinct(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x26f952c*/ int LastValid(UnityEngine.Rendering.RenderTargetIdentifier[] source);
                static /*0x26f95e8*/ bool Contains(UnityEngine.Rendering.ClearFlag a, UnityEngine.Rendering.ClearFlag b);
                static /*0x26f95f4*/ bool SequenceEqual(UnityEngine.Rendering.RenderTargetIdentifier[] left, UnityEngine.Rendering.RenderTargetIdentifier[] right);

                class StereoConstants
                {
                    /*0x10*/ UnityEngine.Matrix4x4[] viewProjMatrix;
                    /*0x18*/ UnityEngine.Matrix4x4[] invViewMatrix;
                    /*0x20*/ UnityEngine.Matrix4x4[] invProjMatrix;
                    /*0x28*/ UnityEngine.Matrix4x4[] invViewProjMatrix;
                    /*0x30*/ UnityEngine.Matrix4x4[] invCameraProjMatrix;
                    /*0x38*/ UnityEngine.Vector4[] worldSpaceCameraPos;

                    /*0x26f9d3c*/ StereoConstants();
                }
            }

            struct RenderTargetHandle
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.RenderTargetHandle CameraTarget;
                /*0x10*/ int <id>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier <rtid>k__BackingField;

                static /*0x26fa0b0*/ RenderTargetHandle();
                static /*0x26f9e40*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetCameraTarget(UnityEngine.Rendering.Universal.XRPass xr);
                static /*0x26fa04c*/ bool op_Equality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                static /*0x26fa07c*/ bool op_Inequality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                /*0x26f4160*/ RenderTargetHandle(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x26f9e00*/ void set_id(int value);
                /*0x26f9e08*/ int get_id();
                /*0x26f9e10*/ void set_rtid(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x26f9e28*/ UnityEngine.Rendering.RenderTargetIdentifier get_rtid();
                /*0x26f249c*/ void Init(string shaderProperty);
                /*0x26f9ee8*/ void Init(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x26f18d4*/ UnityEngine.Rendering.RenderTargetIdentifier Identifier();
                /*0x26f9f08*/ bool HasInternalRenderTargetId();
                /*0x26f9f18*/ bool Equals(UnityEngine.Rendering.Universal.RenderTargetHandle other);
                /*0x26f9fb4*/ bool Equals(object obj);
                /*0x26fa044*/ int GetHashCode();
            }

            enum SampleCount
            {
                One = 1,
                Two = 2,
                Four = 4,
            }

            class ScriptableRendererData : UnityEngine.ScriptableObject
            {
                /*0x18*/ bool <isInvalidated>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.ScriptableRendererData.DebugShaderResources debugShaders;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> m_RendererFeatures;
                /*0x30*/ System.Collections.Generic.List<long> m_RendererFeatureMap;
                /*0x38*/ bool m_UseNativeRenderPass;

                /*0x26fa178*/ ScriptableRendererData();
                /*0x26fa10c*/ bool get_isInvalidated();
                /*0x26fa114*/ void set_isInvalidated(bool value);
                UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x26fa120*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x26fa128*/ void SetDirty();
                /*0x26fa134*/ UnityEngine.Rendering.Universal.ScriptableRenderer InternalCreateRenderer();
                /*0x26fa144*/ void OnValidate();
                /*0x26fa150*/ void OnEnable();
                /*0x26fa15c*/ bool get_useNativeRenderPass();
                /*0x26fa164*/ void set_useNativeRenderPass(bool value);
                bool TryGetRendererFeature<T>(ref T rendererFeature);

                class DebugShaderResources
                {
                    /*0x10*/ UnityEngine.Shader debugReplacementPS;

                    /*0x26fa240*/ DebugShaderResources();
                }
            }

            class ScriptableRendererFeature : UnityEngine.ScriptableObject, System.IDisposable
            {
                /*0x18*/ bool m_Active;

                /*0x26f4310*/ ScriptableRendererFeature();
                /*0x26fa248*/ bool get_isActive();
                void Create();
                /*0x26fa250*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x26fa254*/ void OnEnable();
                /*0x26fa260*/ void OnValidate();
                /*0x26fa26c*/ bool SupportsNativeRenderPass();
                /*0x26fa274*/ void SetActive(bool active);
                /*0x26fa280*/ void Dispose();
                /*0x26fa2ec*/ void Dispose(bool disposing);
            }

            class ShaderData : System.IDisposable
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.ShaderData m_Instance;
                /*0x10*/ UnityEngine.ComputeBuffer m_LightDataBuffer;
                /*0x18*/ UnityEngine.ComputeBuffer m_LightIndicesBuffer;
                /*0x20*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer;
                /*0x28*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer;

                static /*0x26fa2f8*/ UnityEngine.Rendering.Universal.ShaderData get_instance();
                /*0x26fa2f0*/ ShaderData();
                /*0x26fa378*/ void Dispose();
                /*0x26fa3fc*/ UnityEngine.ComputeBuffer GetLightDataBuffer(int size);
                /*0x26fa458*/ UnityEngine.ComputeBuffer GetLightIndicesBuffer(int size);
                /*0x26fa4b4*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size);
                /*0x26fa510*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size);
                UnityEngine.ComputeBuffer GetOrUpdateBuffer<T>(ref UnityEngine.ComputeBuffer buffer, int size);
                /*0x26fa3d8*/ void DisposeBuffer(ref UnityEngine.ComputeBuffer buffer);
            }

            enum ShaderPathID
            {
                Lit = 0,
                SimpleLit = 1,
                Unlit = 2,
                TerrainLit = 3,
                ParticlesLit = 4,
                ParticlesSimpleLit = 5,
                ParticlesUnlit = 6,
                BakedLit = 7,
                SpeedTree7 = 8,
                SpeedTree7Billboard = 9,
                SpeedTree8 = 10,
            }

            class ShaderUtils
            {
                static /*0x0*/ string[] s_ShaderPaths;

                static /*0x26fa9a4*/ ShaderUtils();
                static /*0x26fa56c*/ string GetShaderPath(UnityEngine.Rendering.Universal.ShaderPathID id);
                static /*0x26fa80c*/ UnityEngine.Rendering.Universal.ShaderPathID GetEnumFromPath(string path);
                static /*0x26fa914*/ bool IsLWShader(UnityEngine.Shader shader);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ string path;

                    /*0x26fa90c*/ <>c__DisplayClass2_0();
                    /*0x26face4*/ bool <GetEnumFromPath>b__0(string m);
                }
            }

            struct ShadowSliceData
            {
                /*0x10*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 projectionMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 shadowTransform;
                /*0xd0*/ int offsetX;
                /*0xd4*/ int offsetY;
                /*0xd8*/ int resolution;
                /*0xdc*/ UnityEngine.Rendering.ShadowSplitData splitData;

                /*0x26facf8*/ void Clear();
            }

            class ShadowUtils
            {
                static /*0x0*/ bool m_ForceShadowPointSampling;

                static /*0x26fad88*/ ShadowUtils();
                static /*0x26fae1c*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix);
                static /*0x26faf4c*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x26fb3cc*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x26fb4dc*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x26fb63c*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x26fb770*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings);
                static /*0x26fb844*/ int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount);
                static /*0x26fb290*/ void ApplySliceTransform(ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight);
                static /*0x26fb870*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, ref UnityEngine.Rendering.Universal.ShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x26fbbac*/ void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, ref float scale, ref float bias);
                static /*0x26fbc00*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x26fbd74*/ UnityEngine.RenderTexture GetTemporaryShadowTexture(int width, int height, int bits);
                static /*0x26fb114*/ UnityEngine.Matrix4x4 GetShadowTransform(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
            }

            struct LightExtractionJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.LightType> lightTypes;
                /*0x30*/ Unity.Collections.NativeArray<float> radiuses;
                /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> directions;
                /*0x50*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                /*0x60*/ Unity.Collections.NativeArray<float> coneRadiuses;

                /*0x26fbef0*/ void Execute(int index);
            }

            struct LightMinMaxZ
            {
                /*0x10*/ float minZ;
                /*0x14*/ float maxZ;
            }

            struct MinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Mathematics.float4x4 worldToViewMatrix;
                /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.LightMinMaxZ> minMaxZs;
                /*0x70*/ Unity.Collections.NativeArray<float> meanZs;

                /*0x26fc074*/ void Execute(int index);
            }

            struct RadixSortJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<uint> keys;
                /*0x20*/ Unity.Collections.NativeArray<int> indices;

                /*0x26fc634*/ void Execute();
            }

            struct ReorderJob<T> : Unity.Jobs.IJobFor
            {
                /*0x0*/ Unity.Collections.NativeArray<int> indices;
                /*0x0*/ Unity.Collections.NativeArray<T> input;
                /*0x0*/ Unity.Collections.NativeArray<T> output;

                void Execute(int index);
            }

            struct SliceCombineJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Mathematics.int2 tileResolution;
                /*0x18*/ int wordsPerTile;
                /*0x20*/ Unity.Collections.NativeArray<uint> sliceLightMasksH;
                /*0x30*/ Unity.Collections.NativeArray<uint> sliceLightMasksV;
                /*0x40*/ Unity.Collections.NativeArray<uint> lightMasks;

                /*0x26fc7d4*/ void Execute(int idY);
            }

            struct SliceCullingJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ float scale;
                /*0x14*/ Unity.Mathematics.float3 viewOrigin;
                /*0x20*/ Unity.Mathematics.float3 viewForward;
                /*0x2c*/ Unity.Mathematics.float3 viewRight;
                /*0x38*/ Unity.Mathematics.float3 viewUp;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.LightType> lightTypes;
                /*0x58*/ Unity.Collections.NativeArray<float> radiuses;
                /*0x68*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> directions;
                /*0x78*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                /*0x88*/ Unity.Collections.NativeArray<float> coneRadiuses;
                /*0x98*/ int lightsPerTile;
                /*0xa0*/ Unity.Collections.NativeArray<uint> sliceLightMasks;

                static /*0x26fcc50*/ UnityEngine.Rendering.Universal.SliceCullingJob.Plane ComputePlane(Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2);
                static /*0x26fcd44*/ bool SphereBehindPlane(UnityEngine.Rendering.Universal.SliceCullingJob.Sphere sphere, UnityEngine.Rendering.Universal.SliceCullingJob.Plane plane);
                static /*0x26fcd6c*/ bool PointBehindPlane(Unity.Mathematics.float3 p, UnityEngine.Rendering.Universal.SliceCullingJob.Plane plane);
                static /*0x26fcd90*/ bool ConeBehindPlane(UnityEngine.Rendering.Universal.SliceCullingJob.Cone cone, UnityEngine.Rendering.Universal.SliceCullingJob.Plane plane);
                /*0x26fc854*/ void Execute(int index);
                /*0x26fca98*/ bool ContainsLight(UnityEngine.Rendering.Universal.SliceCullingJob.Plane leftPlane, UnityEngine.Rendering.Universal.SliceCullingJob.Plane rightPlane, int lightIndex);

                struct Cone
                {
                    /*0x10*/ Unity.Mathematics.float3 tip;
                    /*0x1c*/ Unity.Mathematics.float3 direction;
                    /*0x28*/ float height;
                    /*0x2c*/ float radius;
                }

                struct Sphere
                {
                    /*0x10*/ Unity.Mathematics.float3 center;
                    /*0x1c*/ float radius;
                }

                struct Plane
                {
                    /*0x10*/ Unity.Mathematics.float3 normal;
                    /*0x1c*/ float distanceToOrigin;
                }
            }

            enum TileSize
            {
                _8 = 8,
                _16 = 16,
                _32 = 32,
                _64 = 64,
            }

            class TileSizeExtensions
            {
                static /*0x26fcec4*/ bool IsValid(UnityEngine.Rendering.Universal.TileSize tileSize);
            }

            struct ZBin
            {
                /*0x10*/ ushort minIndex;
                /*0x12*/ ushort maxIndex;
            }

            struct ZBinningJob : Unity.Jobs.IJobFor
            {
                static int batchCount = 64;
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.ZBin> bins;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.LightMinMaxZ> minMaxZs;
                /*0x30*/ int binOffset;
                /*0x34*/ float zFactor;

                /*0x26fcef4*/ void Execute(int index);
            }

            enum CameraOverrideOption
            {
                Off = 0,
                On = 1,
                UsePipelineSettings = 2,
            }

            enum RendererOverrideOption
            {
                Custom = 0,
                UsePipelineSettings = 1,
            }

            enum AntialiasingMode
            {
                None = 0,
                FastApproximateAntialiasing = 1,
                SubpixelMorphologicalAntiAliasing = 2,
            }

            enum CameraRenderType
            {
                Base = 0,
                Overlay = 1,
            }

            enum AntialiasingQuality
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class CameraExtensions
            {
                static /*0x26fd0dc*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData GetUniversalAdditionalCameraData(UnityEngine.Camera camera);
                static /*0x26fd178*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(UnityEngine.Camera camera);
                static /*0x26fd194*/ void SetVolumeFrameworkUpdateMode(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode mode);
                static /*0x26fd358*/ void UpdateVolumeStack(UnityEngine.Camera camera);
                static /*0x26fd27c*/ void UpdateVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x26fd564*/ void DestroyVolumeStack(UnityEngine.Camera camera);
                static /*0x26fd578*/ void DestroyVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x26fd374*/ void GetVolumeLayerMaskAndTrigger(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData, ref UnityEngine.LayerMask layerMask, ref UnityEngine.Transform trigger);
            }

            class CameraTypeUtility
            {
                static /*0x0*/ string[] s_CameraTypeNames;

                static /*0x26fd650*/ CameraTypeUtility();
                static /*0x26fd5a4*/ string GetName(UnityEngine.Rendering.Universal.CameraRenderType type);
            }

            class UniversalAdditionalCameraData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IAdditionalData
            {
                static string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/";
                static string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
                static string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
                static string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png";
                static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData s_DefaultAdditionalCameraData;
                /*0x18*/ bool m_RenderShadows;
                /*0x1c*/ UnityEngine.Rendering.Universal.CameraOverrideOption m_RequiresDepthTextureOption;
                /*0x20*/ UnityEngine.Rendering.Universal.CameraOverrideOption m_RequiresOpaqueTextureOption;
                /*0x24*/ UnityEngine.Rendering.Universal.CameraRenderType m_CameraType;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;
                /*0x30*/ int m_RendererIndex;
                /*0x34*/ UnityEngine.LayerMask m_VolumeLayerMask;
                /*0x38*/ UnityEngine.Transform m_VolumeTrigger;
                /*0x40*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption;
                /*0x44*/ bool m_RenderPostProcessing;
                /*0x48*/ UnityEngine.Rendering.Universal.AntialiasingMode m_Antialiasing;
                /*0x4c*/ UnityEngine.Rendering.Universal.AntialiasingQuality m_AntialiasingQuality;
                /*0x50*/ bool m_StopNaN;
                /*0x51*/ bool m_Dithering;
                /*0x52*/ bool m_ClearDepth;
                /*0x53*/ bool m_AllowXRRendering;
                /*0x58*/ UnityEngine.Camera m_Camera;
                /*0x60*/ bool m_RequiresDepthTexture;
                /*0x61*/ bool m_RequiresColorTexture;
                /*0x64*/ float m_Version;
                /*0x68*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData m_MotionVectorsPersistentData;
                /*0x70*/ UnityEngine.Rendering.VolumeStack m_VolumeStack;

                static /*0x26fd744*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData get_defaultAdditionalCameraData();
                /*0x26fd7f4*/ UniversalAdditionalCameraData();
                /*0x26fd73c*/ float get_version();
                /*0x26fd8e0*/ UnityEngine.Camera get_camera();
                /*0x26fd988*/ bool get_renderShadows();
                /*0x26fd990*/ void set_renderShadows(bool value);
                /*0x26fd99c*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresDepthOption();
                /*0x26fd9a4*/ void set_requiresDepthOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x26fd9ac*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresColorOption();
                /*0x26fd9b4*/ void set_requiresColorOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x26fd9bc*/ UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x26fd9c4*/ void set_renderType(UnityEngine.Rendering.Universal.CameraRenderType value);
                /*0x26fd9cc*/ System.Collections.Generic.List<UnityEngine.Camera> get_cameraStack();
                /*0x26fdea0*/ void UpdateCameraStack();
                /*0x26fe1e0*/ bool get_clearDepth();
                /*0x26fe1e8*/ bool get_requiresDepthTexture();
                /*0x26fe26c*/ void set_requiresDepthTexture(bool value);
                /*0x26fe288*/ bool get_requiresColorTexture();
                /*0x26fe30c*/ void set_requiresColorTexture(bool value);
                /*0x26fdb50*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x26fe328*/ void SetRenderer(int index);
                /*0x26fe330*/ UnityEngine.LayerMask get_volumeLayerMask();
                /*0x26fe338*/ void set_volumeLayerMask(UnityEngine.LayerMask value);
                /*0x26fe340*/ UnityEngine.Transform get_volumeTrigger();
                /*0x26fe348*/ void set_volumeTrigger(UnityEngine.Transform value);
                /*0x26fe350*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x26fe358*/ void set_volumeFrameworkUpdateMode(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode value);
                /*0x26fd1fc*/ bool get_requiresVolumeFrameworkUpdate();
                /*0x26fe360*/ UnityEngine.Rendering.VolumeStack get_volumeStack();
                /*0x26fe368*/ void set_volumeStack(UnityEngine.Rendering.VolumeStack value);
                /*0x26fe370*/ bool get_renderPostProcessing();
                /*0x26fe378*/ void set_renderPostProcessing(bool value);
                /*0x26fe384*/ UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x26fe38c*/ void set_antialiasing(UnityEngine.Rendering.Universal.AntialiasingMode value);
                /*0x26fe394*/ UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x26fe39c*/ void set_antialiasingQuality(UnityEngine.Rendering.Universal.AntialiasingQuality value);
                /*0x26fe3a4*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData get_motionVectorsPersistentData();
                /*0x26fe3ac*/ bool get_stopNaN();
                /*0x26fe3b4*/ void set_stopNaN(bool value);
                /*0x26fe3c0*/ bool get_dithering();
                /*0x26fe3c8*/ void set_dithering(bool value);
                /*0x26fe3d4*/ bool get_allowXRRendering();
                /*0x26fe3dc*/ void set_allowXRRendering(bool value);
                /*0x26fe3e8*/ void OnBeforeSerialize();
                /*0x26fe3ec*/ void OnAfterDeserialize();
                /*0x26fe40c*/ void OnDrawGizmos();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Camera> <>9__46_0;

                    static /*0x26fe51c*/ <>c();
                    /*0x26fe580*/ <>c();
                    /*0x26fe588*/ bool <UpdateCameraStack>b__46_0(UnityEngine.Camera cam);
                }
            }

            enum LightLayerEnum
            {
                Nothing = 0,
                LightLayerDefault = 1,
                LightLayer1 = 2,
                LightLayer2 = 4,
                LightLayer3 = 8,
                LightLayer4 = 16,
                LightLayer5 = 32,
                LightLayer6 = 64,
                LightLayer7 = 128,
                Everything = 255,
            }

            class LightExtensions
            {
                static /*0x26fe5e4*/ UnityEngine.Rendering.Universal.UniversalAdditionalLightData GetUniversalAdditionalLightData(UnityEngine.Light light);
            }

            class UniversalAdditionalLightData : UnityEngine.MonoBehaviour, UnityEngine.Rendering.IAdditionalData
            {
                static /*0x0*/ int AdditionalLightsShadowResolutionTierCustom;
                static /*0x4*/ int AdditionalLightsShadowResolutionTierLow;
                static /*0x8*/ int AdditionalLightsShadowResolutionTierMedium;
                static /*0xc*/ int AdditionalLightsShadowResolutionTierHigh;
                static /*0x10*/ int AdditionalLightsShadowDefaultResolutionTier;
                static /*0x14*/ int AdditionalLightsShadowDefaultCustomResolution;
                static /*0x18*/ int AdditionalLightsShadowMinimumResolution;
                /*0x18*/ int m_Version;
                /*0x1c*/ bool m_UsePipelineSettings;
                /*0x20*/ int m_AdditionalLightsShadowResolutionTier;
                /*0x24*/ UnityEngine.Rendering.Universal.LightLayerEnum m_LightLayerMask;
                /*0x28*/ bool m_CustomShadowLayers;
                /*0x2c*/ UnityEngine.Rendering.Universal.LightLayerEnum m_ShadowLayerMask;
                /*0x30*/ UnityEngine.Vector2 m_LightCookieSize;
                /*0x38*/ UnityEngine.Vector2 m_LightCookieOffset;

                static /*0x26fe7d4*/ UniversalAdditionalLightData();
                /*0x26fe6f8*/ UniversalAdditionalLightData();
                /*0x26fe680*/ int get_version();
                /*0x26fe688*/ bool get_usePipelineSettings();
                /*0x26fe690*/ void set_usePipelineSettings(bool value);
                /*0x26fe69c*/ int get_additionalLightsShadowResolutionTier();
                /*0x26fe6a4*/ UnityEngine.Rendering.Universal.LightLayerEnum get_lightLayerMask();
                /*0x26fe6ac*/ void set_lightLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x26fe6b4*/ bool get_customShadowLayers();
                /*0x26fe6bc*/ void set_customShadowLayers(bool value);
                /*0x26fe6c8*/ UnityEngine.Rendering.Universal.LightLayerEnum get_shadowLayerMask();
                /*0x26fe6d0*/ void set_shadowLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x26fe6d8*/ UnityEngine.Vector2 get_lightCookieSize();
                /*0x26fe6e0*/ void set_lightCookieSize(UnityEngine.Vector2 value);
                /*0x26fe6e8*/ UnityEngine.Vector2 get_lightCookieOffset();
                /*0x26fe6f0*/ void set_lightCookieOffset(UnityEngine.Vector2 value);
            }

            enum RenderingMode
            {
                Forward = 0,
                Deferred = 1,
            }

            enum DepthPrimingMode
            {
                Disabled = 0,
                Auto = 1,
                Forced = 2,
            }

            class UniversalRenderer : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static int k_DepthStencilBufferBits = 24;
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormalsOnly;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.XR.XRDisplaySubsystem> displaySubsystemList;
                /*0x190*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass m_DepthPrepass;
                /*0x198*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass m_DepthNormalPrepass;
                /*0x1a0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_PrimedDepthCopyPass;
                /*0x1a8*/ UnityEngine.Rendering.Universal.Internal.MotionVectorRenderPass m_MotionVectorPass;
                /*0x1b0*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass m_MainLightShadowCasterPass;
                /*0x1b8*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;
                /*0x1c0*/ UnityEngine.Rendering.Universal.Internal.GBufferPass m_GBufferPass;
                /*0x1c8*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_GBufferCopyDepthPass;
                /*0x1d0*/ UnityEngine.Rendering.Universal.Internal.TileDepthRangePass m_TileDepthRangePass;
                /*0x1d8*/ UnityEngine.Rendering.Universal.Internal.TileDepthRangePass m_TileDepthRangeExtraPass;
                /*0x1e0*/ UnityEngine.Rendering.Universal.Internal.DeferredPass m_DeferredPass;
                /*0x1e8*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderOpaqueForwardOnlyPass;
                /*0x1f0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderOpaqueForwardPass;
                /*0x1f8*/ UnityEngine.Rendering.Universal.DrawSkyboxPass m_DrawSkyboxPass;
                /*0x200*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_CopyDepthPass;
                /*0x208*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass m_CopyColorPass;
                /*0x210*/ UnityEngine.Rendering.Universal.TransparentSettingsPass m_TransparentSettingsPass;
                /*0x218*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderTransparentForwardPass;
                /*0x220*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;
                /*0x228*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass m_FinalBlitPass;
                /*0x230*/ UnityEngine.Rendering.Universal.CapturePass m_CapturePass;
                /*0x238*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass m_XROcclusionMeshPass;
                /*0x240*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_XRCopyDepthPass;
                /*0x248*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem m_ColorBufferSystem;
                /*0x250*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_ActiveCameraColorAttachment;
                /*0x280*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_ColorFrontBuffer;
                /*0x2b0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_ActiveCameraDepthAttachment;
                /*0x2e0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_CameraDepthAttachment;
                /*0x310*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_DepthTexture;
                /*0x340*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_NormalsTexture;
                /*0x370*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_OpaqueColor;
                /*0x3a0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_DepthInfoTexture;
                /*0x3d0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_TileDepthInfoTexture;
                /*0x400*/ UnityEngine.Rendering.Universal.Internal.ForwardLights m_ForwardLights;
                /*0x408*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0x410*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x414*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x418*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x41c*/ bool m_DepthPrimingRecommended;
                /*0x41d*/ UnityEngine.Rendering.StencilState m_DefaultStencilState;
                /*0x430*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;
                /*0x438*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;
                /*0x440*/ UnityEngine.Material m_BlitMaterial;
                /*0x448*/ UnityEngine.Material m_CopyDepthMaterial;
                /*0x450*/ UnityEngine.Material m_SamplingMaterial;
                /*0x458*/ UnityEngine.Material m_TileDepthInfoMaterial;
                /*0x460*/ UnityEngine.Material m_TileDeferredMaterial;
                /*0x468*/ UnityEngine.Material m_StencilDeferredMaterial;
                /*0x470*/ UnityEngine.Material m_CameraMotionVecMaterial;
                /*0x478*/ UnityEngine.Material m_ObjectMotionVecMaterial;
                /*0x480*/ UnityEngine.Rendering.Universal.PostProcessPasses m_PostProcessPasses;

                static /*0x27029e0*/ UniversalRenderer();
                static /*0x26fe8d0*/ bool IsRunningXRMobile();
                /*0x26fea1c*/ UniversalRenderer(UnityEngine.Rendering.Universal.UniversalRendererData data);
                /*0x26fe838*/ int SupportedCameraStackingTypes();
                /*0x26fe854*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x26f3d8c*/ UnityEngine.Rendering.Universal.RenderingMode get_actualRenderingMode();
                /*0x26fe85c*/ bool get_accurateGbufferNormals();
                /*0x26fe87c*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x26fe884*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x26fe88c*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x26fe894*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass get_postProcessPass();
                /*0x26fe89c*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass get_finalPostProcessPass();
                /*0x26fe8a4*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_colorGradingLut();
                /*0x26fe8c8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights get_deferredLights();
                /*0x26ff81c*/ void Dispose(bool disposing);
                /*0x26ff948*/ void SetupFinalPassDebug(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26ffb5c*/ bool IsDepthPrimingEnabled(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26ffccc*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x27022c8*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x270232c*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x2702504*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x2702000*/ void EnqueueDeferred(ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool applyMainShadow, bool applyAdditionalShadow);
                /*0x2701600*/ UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x2702690*/ bool IsGLESDevice();
                /*0x270197c*/ void CreateCameraRenderTarget(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.RenderTextureDescriptor descriptor, bool primedDepth);
                /*0x27026c4*/ bool PlatformRequiresExplicitMsaaResolve();
                /*0x27017d0*/ bool RequiresIntermediateColorTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x26ffbec*/ bool CanCopyDepth(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x2702700*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x2702970*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x27029c0*/ void EnableSwapBufferMSAA(bool enable);

                class Profiling
                {
                    static string k_Name = "UniversalRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler createCameraRenderTarget;

                    static /*0x2702f80*/ Profiling();
                }

                struct RenderPassInputSummary
                {
                    /*0x10*/ bool requiresDepthTexture;
                    /*0x11*/ bool requiresDepthPrepass;
                    /*0x12*/ bool requiresNormalsTexture;
                    /*0x13*/ bool requiresColorTexture;
                    /*0x14*/ bool requiresColorTextureCreated;
                    /*0x15*/ bool requiresMotionVectors;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthNormalAtEvent;
                    /*0x1c*/ UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthTextureEarliestEvent;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderer.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__80_0;

                    static /*0x2703010*/ <>c();
                    /*0x2703074*/ <>c();
                    /*0x270307c*/ bool <Setup>b__80_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                }
            }

            enum CopyDepthMode
            {
                AfterOpaques = 0,
                ForcePrepass = 2,
            }

            class UniversalRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData, UnityEngine.ISerializationCallbackReceiver
            {
                static int k_LatestAssetVersion = 2;
                static UnityEngine.Rendering.Universal.TileSize k_DefaultTileSize = 32;
                /*0x40*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x48*/ UnityEngine.Rendering.Universal.XRSystemData xrSystemData;
                /*0x50*/ UnityEngine.Rendering.Universal.UniversalRendererData.ShaderResources shaders;
                /*0x58*/ int m_AssetVersion;
                /*0x5c*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x60*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x68*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x70*/ bool m_ShadowTransparentReceive;
                /*0x74*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x78*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x7c*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x80*/ bool m_AccurateGbufferNormals;
                /*0x81*/ bool m_ClusteredRendering;
                /*0x84*/ UnityEngine.Rendering.Universal.TileSize m_TileSize;
                /*0x88*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;

                /*0x2703390*/ UniversalRendererData();
                /*0x270309c*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x270310c*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x2703114*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x270313c*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x2703144*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x270316c*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x2703174*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x270319c*/ bool get_shadowTransparentReceive();
                /*0x27031a4*/ void set_shadowTransparentReceive(bool value);
                /*0x27031cc*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x27031d4*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x27031fc*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x2703204*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x270322c*/ UnityEngine.Rendering.Universal.CopyDepthMode get_copyDepthMode();
                /*0x2703234*/ void set_copyDepthMode(UnityEngine.Rendering.Universal.CopyDepthMode value);
                /*0x270325c*/ bool get_accurateGbufferNormals();
                /*0x2703264*/ void set_accurateGbufferNormals(bool value);
                /*0x270328c*/ bool get_clusteredRendering();
                /*0x2703294*/ void set_clusteredRendering(bool value);
                /*0x27032bc*/ UnityEngine.Rendering.Universal.TileSize get_tileSize();
                /*0x27032c4*/ void set_tileSize(UnityEngine.Rendering.Universal.TileSize value);
                /*0x27032ec*/ UnityEngine.Rendering.Universal.IntermediateTextureMode get_intermediateTextureMode();
                /*0x27032f4*/ void set_intermediateTextureMode(UnityEngine.Rendering.Universal.IntermediateTextureMode value);
                /*0x270331c*/ void OnValidate();
                /*0x270334c*/ void OnEnable();
                /*0x2703108*/ void ReloadAllNullProperties();
                /*0x2703354*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x2703360*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader blitPS;
                    /*0x18*/ UnityEngine.Shader copyDepthPS;
                    /*0x20*/ UnityEngine.Shader screenSpaceShadowPS;
                    /*0x28*/ UnityEngine.Shader samplingPS;
                    /*0x30*/ UnityEngine.Shader stencilDeferredPS;
                    /*0x38*/ UnityEngine.Shader fallbackErrorPS;
                    /*0x40*/ UnityEngine.Shader materialErrorPS;
                    /*0x48*/ UnityEngine.Shader coreBlitPS;
                    /*0x50*/ UnityEngine.Shader coreBlitColorAndDepthPS;
                    /*0x58*/ UnityEngine.Shader cameraMotionVector;
                    /*0x60*/ UnityEngine.Shader objectMotionVector;

                    /*0x2703434*/ ShaderResources();
                }
            }

            class UniversalRenderPipeline : UnityEngine.Rendering.RenderPipeline
            {
                static string k_ShaderTagName = "UniversalPipeline";
                static int k_MaxVisibleAdditionalLightsMobileShaderLevelLessThan45 = 16;
                static int k_MaxVisibleAdditionalLightsMobile = 32;
                static int k_MaxVisibleAdditionalLightsNonMobile = 256;
                static int k_DefaultRenderingLayerMask = 1;
                static /*0x0*/ UnityEngine.Rendering.Universal.XRSystem m_XRSystem;
                static /*0x8*/ UnityEngine.Vector4 k_DefaultLightPosition;
                static /*0x18*/ UnityEngine.Vector4 k_DefaultLightColor;
                static /*0x28*/ UnityEngine.Vector4 k_DefaultLightAttenuation;
                static /*0x38*/ UnityEngine.Vector4 k_DefaultLightSpotDirection;
                static /*0x48*/ UnityEngine.Vector4 k_DefaultLightsProbeChannel;
                static /*0x58*/ System.Collections.Generic.List<UnityEngine.Vector4> m_ShadowBiasData;
                static /*0x60*/ System.Collections.Generic.List<int> m_ShadowResolutionData;
                static /*0x68*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate lightsDelegate;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsUI m_DebugDisplaySettingsUI;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings m_GlobalSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset;
                /*0x30*/ System.Comparison<UnityEngine.Camera> cameraComparison;

                static /*0x270bfdc*/ UniversalRenderPipeline();
                static /*0x270343c*/ float get_maxShadowBias();
                static /*0x2703444*/ float get_minRenderScale();
                static /*0x2703450*/ float get_maxRenderScale();
                static /*0x2703458*/ int get_maxPerObjectLights();
                static /*0x270347c*/ int get_maxVisibleAdditionalLights();
                static /*0x2703540*/ int get_lightsPerTile();
                static /*0x27035a4*/ int get_maxZBins();
                static /*0x27035ac*/ int get_maxTileVec4s();
                static /*0x27065a4*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x2707254*/ bool TryGetCullingParameters(UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                static /*0x2706b08*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.CameraData cameraData, bool anyPostProcessingEnabled);
                static /*0x2704ae4*/ void RenderCameraStack(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera baseCamera);
                static /*0x27062c4*/ void UpdateVolumeFramework(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x2709620*/ bool CheckPostProcessForDepth(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x2703ac0*/ void SetSupportedRenderingFeatures();
                static /*0x2706744*/ void InitializeCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x270970c*/ void InitializeStackedCameraData(UnityEngine.Camera baseCamera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData baseAdditionalCameraData, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x27087b8*/ void InitializeAdditionalCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x270757c*/ void InitializeRenderingData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, ref UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Rendering.CullingResults cullResults, bool anyPostProcessingEnabled, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x270a97c*/ void InitializeShadowData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, ref UnityEngine.Rendering.Universal.ShadowData shadowData);
                static /*0x270b258*/ void InitializePostProcessingData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, ref UnityEngine.Rendering.Universal.PostProcessingData postProcessingData);
                static /*0x270a6b0*/ void InitializeLightData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, int mainLightIndex, ref UnityEngine.Rendering.Universal.LightData lightData);
                static /*0x27079dc*/ void CleanupLightData(ref UnityEngine.Rendering.Universal.LightData lightData);
                static /*0x2707dc8*/ void UpdateCameraStereoMatrices(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPass xr);
                static /*0x270b28c*/ UnityEngine.Rendering.PerObjectData GetPerObjectLightFlags(int additionalLightsCount);
                static /*0x270a448*/ int GetMainLightIndex(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x2704614*/ void SetupPerFrameShaderConstants();
                static /*0x270b3c8*/ void CheckAndApplyDebugSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x270a2f4*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter ResolveUpscalingFilterSelection(UnityEngine.Vector2 imageSize, float renderScale, UnityEngine.Rendering.Universal.UpscalingFilterSelection selection);
                static /*0x2704a04*/ bool IsGameCamera(UnityEngine.Camera camera);
                static /*0x270b728*/ bool IsStereoEnabled(UnityEngine.Camera camera);
                static /*0x27045a0*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset get_asset();
                static /*0x270b82c*/ bool IsMultiPassStereoEnabled(UnityEngine.Camera camera);
                static /*0x270b66c*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, bool needsAlpha);
                static /*0x270b8e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeUnormRenderTextureGraphicsFormat();
                static /*0x2709d70*/ UnityEngine.RenderTextureDescriptor CreateRenderTextureDescriptor(UnityEngine.Camera camera, float renderScale, bool isHdrEnabled, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture);
                static /*0x270b94c*/ void GetLightAttenuationAndSpotDirection(UnityEngine.LightType lightType, float lightRange, UnityEngine.Matrix4x4 lightLocalToWorldMatrix, float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x270bb5c*/ void InitializeLightConstants_Common(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel);
                /*0x27035d4*/ UniversalRenderPipeline(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset);
                /*0x27035b4*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();
                /*0x27035bc*/ string ToString();
                /*0x2703cf4*/ void Dispose(bool disposing);
                /*0x2703f14*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Camera[] cameras);
                /*0x2703fac*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x2704988*/ void SortCameras(System.Collections.Generic.List<UnityEngine.Camera> cameras);

                class Profiling
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProfilingSampler> s_HashSamplerCache;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler unknownSampler;

                    static /*0x270c384*/ Profiling();
                    static /*0x2707408*/ UnityEngine.Rendering.ProfilingSampler TryGetOrAddCameraSampler(UnityEngine.Camera camera);

                    class Pipeline
                    {
                        static string k_Name = "UniversalRenderPipeline";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginContextRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endContextRendering;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler beginCameraRendering;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler endCameraRendering;
                        static /*0x20*/ UnityEngine.Rendering.ProfilingSampler initializeCameraData;
                        static /*0x28*/ UnityEngine.Rendering.ProfilingSampler initializeStackedCameraData;
                        static /*0x30*/ UnityEngine.Rendering.ProfilingSampler initializeAdditionalCameraData;
                        static /*0x38*/ UnityEngine.Rendering.ProfilingSampler initializeRenderingData;
                        static /*0x40*/ UnityEngine.Rendering.ProfilingSampler initializeShadowData;
                        static /*0x48*/ UnityEngine.Rendering.ProfilingSampler initializeLightData;
                        static /*0x50*/ UnityEngine.Rendering.ProfilingSampler getPerObjectLightFlags;
                        static /*0x58*/ UnityEngine.Rendering.ProfilingSampler getMainLightIndex;
                        static /*0x60*/ UnityEngine.Rendering.ProfilingSampler setupPerFrameShaderConstants;

                        static /*0x270c460*/ Pipeline();

                        class Renderer
                        {
                            static string k_Name = "ScriptableRenderer";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setupCullingParameters;
                            static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setup;

                            static /*0x270c7c0*/ Renderer();
                        }

                        class Context
                        {
                            static string k_Name = "ScriptableRenderContext";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler submit;

                            static /*0x270c88c*/ Context();
                        }

                        class XR
                        {
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler mirrorView;

                            static /*0x270c91c*/ XR();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Camera> <>9__29_0;

                    static /*0x270c9ac*/ <>c();
                    /*0x270ca10*/ <>c();
                    /*0x270ca18*/ int <.ctor>b__29_0(UnityEngine.Camera camera1, UnityEngine.Camera camera2);
                    /*0x270ca80*/ void <.cctor>b__74_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }

            enum MixedLightingSetup
            {
                None = 0,
                ShadowMask = 1,
                Subtractive = 2,
            }

            enum ImageScalingMode
            {
                None = 0,
                Upscaling = 1,
                Downscaling = 2,
            }

            enum ImageUpscalingFilter
            {
                Linear = 0,
                Point = 1,
                FSR = 2,
            }

            struct RenderingData
            {
                /*0x10*/ UnityEngine.Rendering.CullingResults cullResults;
                /*0x20*/ UnityEngine.Rendering.Universal.CameraData cameraData;
                /*0x188*/ UnityEngine.Rendering.Universal.LightData lightData;
                /*0x1c0*/ UnityEngine.Rendering.Universal.ShadowData shadowData;
                /*0x210*/ UnityEngine.Rendering.Universal.PostProcessingData postProcessingData;
                /*0x21c*/ bool supportsDynamicBatching;
                /*0x220*/ UnityEngine.Rendering.PerObjectData perObjectData;
                /*0x224*/ bool postProcessingEnabled;
            }

            struct LightData
            {
                /*0x10*/ int mainLightIndex;
                /*0x14*/ int additionalLightsCount;
                /*0x18*/ int maxPerObjectAdditionalLightsCount;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights;
                /*0x30*/ Unity.Collections.NativeArray<int> originalIndices;
                /*0x40*/ bool shadeAdditionalLightsPerVertex;
                /*0x41*/ bool supportsMixedLighting;
                /*0x42*/ bool reflectionProbeBoxProjection;
                /*0x43*/ bool reflectionProbeBlending;
                /*0x44*/ bool supportsLightLayers;
                /*0x45*/ bool supportsAdditionalLights;
            }

            struct CameraData
            {
                /*0x10*/ UnityEngine.Matrix4x4 m_ViewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 m_ProjectionMatrix;
                /*0x90*/ UnityEngine.Camera camera;
                /*0x98*/ UnityEngine.Rendering.Universal.CameraRenderType renderType;
                /*0xa0*/ UnityEngine.RenderTexture targetTexture;
                /*0xa8*/ UnityEngine.RenderTextureDescriptor cameraTargetDescriptor;
                /*0xdc*/ UnityEngine.Rect pixelRect;
                /*0xec*/ int pixelWidth;
                /*0xf0*/ int pixelHeight;
                /*0xf4*/ float aspectRatio;
                /*0xf8*/ float renderScale;
                /*0xfc*/ UnityEngine.Rendering.Universal.ImageScalingMode imageScalingMode;
                /*0x100*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter upscalingFilter;
                /*0x104*/ bool fsrOverrideSharpness;
                /*0x108*/ float fsrSharpness;
                /*0x10c*/ bool clearDepth;
                /*0x110*/ UnityEngine.CameraType cameraType;
                /*0x114*/ bool isDefaultViewport;
                /*0x115*/ bool isHdrEnabled;
                /*0x116*/ bool requiresDepthTexture;
                /*0x117*/ bool requiresOpaqueTexture;
                /*0x118*/ bool postProcessingRequiresDepthTexture;
                /*0x119*/ bool xrRendering;
                /*0x11c*/ UnityEngine.Rendering.SortingCriteria defaultOpaqueSortFlags;
                /*0x120*/ UnityEngine.Rendering.Universal.XRPass xr;
                /*0x128*/ bool isStereoEnabled;
                /*0x12c*/ float maxShadowDistance;
                /*0x130*/ bool postProcessEnabled;
                /*0x138*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;
                /*0x140*/ UnityEngine.LayerMask volumeLayerMask;
                /*0x148*/ UnityEngine.Transform volumeTrigger;
                /*0x150*/ bool isStopNaNEnabled;
                /*0x151*/ bool isDitheringEnabled;
                /*0x154*/ UnityEngine.Rendering.Universal.AntialiasingMode antialiasing;
                /*0x158*/ UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality;
                /*0x160*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                /*0x168*/ bool resolveFinalTarget;
                /*0x16c*/ UnityEngine.Vector3 worldSpaceCameraPos;

                /*0x270a424*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x270cd40*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x270cdb4*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x270ce28*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x270d054*/ bool get_requireSrgbConversion();
                /*0x27073f8*/ bool get_isSceneViewCamera();
                /*0x270b65c*/ bool get_isPreviewCamera();
                /*0x270d170*/ bool get_isRenderPassSupportedCamera();
                /*0x270ce80*/ bool IsCameraProjectionMatrixFlipped();
            }

            struct ShadowData
            {
                /*0x10*/ bool supportsMainLightShadows;
                /*0x11*/ bool requiresScreenSpaceShadowResolve;
                /*0x14*/ int mainLightShadowmapWidth;
                /*0x18*/ int mainLightShadowmapHeight;
                /*0x1c*/ int mainLightShadowCascadesCount;
                /*0x20*/ UnityEngine.Vector3 mainLightShadowCascadesSplit;
                /*0x2c*/ float mainLightShadowCascadeBorder;
                /*0x30*/ bool supportsAdditionalLightShadows;
                /*0x34*/ int additionalLightsShadowmapWidth;
                /*0x38*/ int additionalLightsShadowmapHeight;
                /*0x3c*/ bool supportsSoftShadows;
                /*0x40*/ int shadowmapDepthBufferBits;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector4> bias;
                /*0x50*/ System.Collections.Generic.List<int> resolution;
                /*0x58*/ bool isKeywordAdditionalLightShadowsEnabled;
                /*0x59*/ bool isKeywordSoftShadowsEnabled;
            }

            struct PreTile
            {
                /*0x10*/ Unity.Mathematics.float4 planeLeft;
                /*0x20*/ Unity.Mathematics.float4 planeRight;
                /*0x30*/ Unity.Mathematics.float4 planeBottom;
                /*0x40*/ Unity.Mathematics.float4 planeTop;
            }

            struct TileData
            {
                /*0x10*/ uint tileID;
                /*0x14*/ uint listBitMask;
                /*0x18*/ uint relLightOffset;
                /*0x1c*/ uint unused;
            }

            struct PunctualLightData
            {
                /*0x10*/ UnityEngine.Vector3 wsPos;
                /*0x1c*/ float radius;
                /*0x20*/ UnityEngine.Vector4 color;
                /*0x30*/ UnityEngine.Vector4 attenuation;
                /*0x40*/ UnityEngine.Vector3 spotDirection;
                /*0x4c*/ int flags;
                /*0x50*/ UnityEngine.Vector4 occlusionProbeInfo;
                /*0x60*/ uint layerMask;
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int glossyEnvironmentColor;
                static /*0x4*/ int subtractiveShadowColor;
                static /*0x8*/ int glossyEnvironmentCubeMap;
                static /*0xc*/ int glossyEnvironmentCubeMapHDR;
                static /*0x10*/ int ambientSkyColor;
                static /*0x14*/ int ambientEquatorColor;
                static /*0x18*/ int ambientGroundColor;
                static /*0x1c*/ int time;
                static /*0x20*/ int sinTime;
                static /*0x24*/ int cosTime;
                static /*0x28*/ int deltaTime;
                static /*0x2c*/ int timeParameters;
                static /*0x30*/ int scaledScreenParams;
                static /*0x34*/ int worldSpaceCameraPos;
                static /*0x38*/ int screenParams;
                static /*0x3c*/ int projectionParams;
                static /*0x40*/ int zBufferParams;
                static /*0x44*/ int orthoParams;
                static /*0x48*/ int globalMipBias;
                static /*0x4c*/ int screenSize;
                static /*0x50*/ int viewMatrix;
                static /*0x54*/ int projectionMatrix;
                static /*0x58*/ int viewAndProjectionMatrix;
                static /*0x5c*/ int inverseViewMatrix;
                static /*0x60*/ int inverseProjectionMatrix;
                static /*0x64*/ int inverseViewAndProjectionMatrix;
                static /*0x68*/ int cameraProjectionMatrix;
                static /*0x6c*/ int inverseCameraProjectionMatrix;
                static /*0x70*/ int worldToCameraMatrix;
                static /*0x74*/ int cameraToWorldMatrix;
                static /*0x78*/ int cameraWorldClipPlanes;
                static /*0x7c*/ int billboardNormal;
                static /*0x80*/ int billboardTangent;
                static /*0x84*/ int billboardCameraParams;
                static /*0x88*/ int sourceTex;
                static /*0x8c*/ int scaleBias;
                static /*0x90*/ int scaleBiasRt;
                static /*0x94*/ int rendererColor;

                static /*0x270d18c*/ ShaderPropertyId();
            }

            struct PostProcessingData
            {
                /*0x10*/ UnityEngine.Rendering.Universal.ColorGradingMode gradingMode;
                /*0x14*/ int lutSize;
                /*0x18*/ bool useFastSRGBLinearConversion;
            }

            class ShaderKeywordStrings
            {
                static string MainLightShadows = "_MAIN_LIGHT_SHADOWS";
                static string MainLightShadowCascades = "_MAIN_LIGHT_SHADOWS_CASCADE";
                static string MainLightShadowScreen = "_MAIN_LIGHT_SHADOWS_SCREEN";
                static string CastingPunctualLightShadow = "_CASTING_PUNCTUAL_LIGHT_SHADOW";
                static string AdditionalLightsVertex = "_ADDITIONAL_LIGHTS_VERTEX";
                static string AdditionalLightsPixel = "_ADDITIONAL_LIGHTS";
                static string ClusteredRendering = "_CLUSTERED_RENDERING";
                static string AdditionalLightShadows = "_ADDITIONAL_LIGHT_SHADOWS";
                static string ReflectionProbeBoxProjection = "_REFLECTION_PROBE_BOX_PROJECTION";
                static string ReflectionProbeBlending = "_REFLECTION_PROBE_BLENDING";
                static string SoftShadows = "_SHADOWS_SOFT";
                static string MixedLightingSubtractive = "_MIXED_LIGHTING_SUBTRACTIVE";
                static string LightmapShadowMixing = "LIGHTMAP_SHADOW_MIXING";
                static string ShadowsShadowMask = "SHADOWS_SHADOWMASK";
                static string LightLayers = "_LIGHT_LAYERS";
                static string RenderPassEnabled = "_RENDER_PASS_ENABLED";
                static string BillboardFaceCameraPos = "BILLBOARD_FACE_CAMERA_POS";
                static string LightCookies = "_LIGHT_COOKIES";
                static string DepthNoMsaa = "_DEPTH_NO_MSAA";
                static string DepthMsaa2 = "_DEPTH_MSAA_2";
                static string DepthMsaa4 = "_DEPTH_MSAA_4";
                static string DepthMsaa8 = "_DEPTH_MSAA_8";
                static string LinearToSRGBConversion = "_LINEAR_TO_SRGB_CONVERSION";
                static string UseFastSRGBLinearConversion = "_USE_FAST_SRGB_LINEAR_CONVERSION";
                static string DBufferMRT1 = "_DBUFFER_MRT1";
                static string DBufferMRT2 = "_DBUFFER_MRT2";
                static string DBufferMRT3 = "_DBUFFER_MRT3";
                static string DecalNormalBlendLow = "_DECAL_NORMAL_BLEND_LOW";
                static string DecalNormalBlendMedium = "_DECAL_NORMAL_BLEND_MEDIUM";
                static string DecalNormalBlendHigh = "_DECAL_NORMAL_BLEND_HIGH";
                static string SmaaLow = "_SMAA_PRESET_LOW";
                static string SmaaMedium = "_SMAA_PRESET_MEDIUM";
                static string SmaaHigh = "_SMAA_PRESET_HIGH";
                static string PaniniGeneric = "_GENERIC";
                static string PaniniUnitDistance = "_UNIT_DISTANCE";
                static string BloomLQ = "_BLOOM_LQ";
                static string BloomHQ = "_BLOOM_HQ";
                static string BloomLQDirt = "_BLOOM_LQ_DIRT";
                static string BloomHQDirt = "_BLOOM_HQ_DIRT";
                static string UseRGBM = "_USE_RGBM";
                static string Distortion = "_DISTORTION";
                static string ChromaticAberration = "_CHROMATIC_ABERRATION";
                static string HDRGrading = "_HDR_GRADING";
                static string TonemapACES = "_TONEMAP_ACES";
                static string TonemapNeutral = "_TONEMAP_NEUTRAL";
                static string FilmGrain = "_FILM_GRAIN";
                static string Fxaa = "_FXAA";
                static string Dithering = "_DITHERING";
                static string ScreenSpaceOcclusion = "_SCREEN_SPACE_OCCLUSION";
                static string PointSampling = "_POINT_SAMPLING";
                static string Rcas = "_RCAS";
                static string Gamma20 = "_GAMMA_20";
                static string HighQualitySampling = "_HIGH_QUALITY_SAMPLING";
                static string DOWNSAMPLING_SIZE_2 = "DOWNSAMPLING_SIZE_2";
                static string DOWNSAMPLING_SIZE_4 = "DOWNSAMPLING_SIZE_4";
                static string DOWNSAMPLING_SIZE_8 = "DOWNSAMPLING_SIZE_8";
                static string DOWNSAMPLING_SIZE_16 = "DOWNSAMPLING_SIZE_16";
                static string _SPOT = "_SPOT";
                static string _DIRECTIONAL = "_DIRECTIONAL";
                static string _POINT = "_POINT";
                static string _DEFERRED_STENCIL = "_DEFERRED_STENCIL";
                static string _DEFERRED_FIRST_LIGHT = "_DEFERRED_FIRST_LIGHT";
                static string _DEFERRED_MAIN_LIGHT = "_DEFERRED_MAIN_LIGHT";
                static string _GBUFFER_NORMALS_OCT = "_GBUFFER_NORMALS_OCT";
                static string _DEFERRED_MIXED_LIGHTING = "_DEFERRED_MIXED_LIGHTING";
                static string LIGHTMAP_ON = "LIGHTMAP_ON";
                static string DYNAMICLIGHTMAP_ON = "DYNAMICLIGHTMAP_ON";
                static string _ALPHATEST_ON = "_ALPHATEST_ON";
                static string DIRLIGHTMAP_COMBINED = "DIRLIGHTMAP_COMBINED";
                static string _DETAIL_MULX2 = "_DETAIL_MULX2";
                static string _DETAIL_SCALED = "_DETAIL_SCALED";
                static string _CLEARCOAT = "_CLEARCOAT";
                static string _CLEARCOATMAP = "_CLEARCOATMAP";
                static string DEBUG_DISPLAY = "DEBUG_DISPLAY";
                static string _EMISSION = "_EMISSION";
                static string _RECEIVE_SHADOWS_OFF = "_RECEIVE_SHADOWS_OFF";
                static string _SURFACE_TYPE_TRANSPARENT = "_SURFACE_TYPE_TRANSPARENT";
                static string _ALPHAPREMULTIPLY_ON = "_ALPHAPREMULTIPLY_ON";
                static string _ALPHAMODULATE_ON = "_ALPHAMODULATE_ON";
                static string _NORMALMAP = "_NORMALMAP";
                static string EDITOR_VISUALIZATION = "EDITOR_VISUALIZATION";
                static string UseDrawProcedural = "_USE_DRAW_PROCEDURAL";
            }

            enum URPProfileId
            {
                UniversalRenderTotal = 0,
                UpdateVolumeFramework = 1,
                RenderCameraStack = 2,
                AdditionalLightsShadow = 3,
                ColorGradingLUT = 4,
                CopyColor = 5,
                CopyDepth = 6,
                DepthNormalPrepass = 7,
                DepthPrepass = 8,
                DrawOpaqueObjects = 9,
                DrawTransparentObjects = 10,
                LightCookies = 11,
                MainLightShadow = 12,
                ResolveShadows = 13,
                SSAO = 14,
                StopNaNs = 15,
                SMAA = 16,
                GaussianDepthOfField = 17,
                BokehDepthOfField = 18,
                MotionBlur = 19,
                PaniniProjection = 20,
                UberPostProcess = 21,
                Bloom = 22,
                LensFlareDataDriven = 23,
                MotionVectors = 24,
                FinalBlit = 25,
            }

            class UniversalRenderPipelineGlobalSettings : UnityEngine.Rendering.RenderPipelineGlobalSettings, UnityEngine.ISerializationCallbackReceiver
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings cachedInstance;
                static /*0x8*/ string defaultAssetName;
                static /*0x10*/ string[] k_DefaultLightLayerNames;
                /*0x18*/ int k_AssetVersion;
                /*0x20*/ string[] m_RenderingLayerNames;
                /*0x28*/ string[] m_PrefixedRenderingLayerNames;
                /*0x30*/ string[] m_PrefixedLightLayerNames;
                /*0x38*/ string lightLayerName0;
                /*0x40*/ string lightLayerName1;
                /*0x48*/ string lightLayerName2;
                /*0x50*/ string lightLayerName3;
                /*0x58*/ string lightLayerName4;
                /*0x60*/ string lightLayerName5;
                /*0x68*/ string lightLayerName6;
                /*0x70*/ string lightLayerName7;
                /*0x78*/ string[] m_LightLayerNames;
                /*0x80*/ bool m_StripDebugVariants;
                /*0x81*/ bool m_StripUnusedPostProcessingVariants;
                /*0x82*/ bool m_StripUnusedVariants;
                /*0x83*/ bool supportRuntimeDebugDisplay;

                static /*0x270e27c*/ UniversalRenderPipelineGlobalSettings();
                static /*0x2703994*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings get_instance();
                static /*0x270d878*/ void UpdateGraphicsSettings(UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings newSettings);
                /*0x270e178*/ UniversalRenderPipelineGlobalSettings();
                /*0x270d870*/ void OnBeforeSerialize();
                /*0x270d874*/ void OnAfterDeserialize();
                /*0x270d998*/ void Reset();
                /*0x270dd94*/ string[] get_renderingLayerNames();
                /*0x270ddb8*/ string[] get_prefixedRenderingLayerNames();
                /*0x270dddc*/ string[] get_renderingLayerMaskNames();
                /*0x270de00*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x270d99c*/ void UpdateRenderingLayerNames();
                /*0x270de24*/ string[] get_prefixedLightLayerNames();
                /*0x270de48*/ string[] get_lightLayerNames();
                /*0x270e054*/ void ResetRenderingLayerNames();
                /*0x270e13c*/ bool get_stripDebugVariants();
                /*0x270e144*/ void set_stripDebugVariants(bool value);
                /*0x270e150*/ bool get_stripUnusedPostProcessingVariants();
                /*0x270e158*/ void set_stripUnusedPostProcessingVariants(bool value);
                /*0x270e164*/ bool get_stripUnusedVariants();
                /*0x270e16c*/ void set_stripUnusedVariants(bool value);
            }

            struct XRLayout
            {
                /*0x10*/ UnityEngine.Camera camera;
                /*0x18*/ UnityEngine.Rendering.Universal.XRSystem xrSystem;

                /*0x270e534*/ UnityEngine.Rendering.Universal.XRPass CreatePass(UnityEngine.Rendering.Universal.XRPassCreateInfo passCreateInfo);
                /*0x270e90c*/ void AddViewToPass(UnityEngine.Rendering.Universal.XRViewCreateInfo viewCreateInfo, UnityEngine.Rendering.Universal.XRPass pass);
            }

            struct XRPassCreateInfo
            {
                /*0x10*/ int multipassId;
                /*0x14*/ int cullingPassId;
                /*0x18*/ UnityEngine.RenderTexture renderTarget;
                /*0x20*/ UnityEngine.RenderTextureDescriptor renderTargetDesc;
                /*0x54*/ bool renderTargetIsRenderTexture;
                /*0x58*/ UnityEngine.Rendering.ScriptableCullingParameters cullingParameters;
                /*0x680*/ UnityEngine.Rendering.Universal.XRPass.CustomMirrorView customMirrorView;
            }

            struct XRViewCreateInfo
            {
                /*0x10*/ UnityEngine.Matrix4x4 projMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x90*/ UnityEngine.Rect viewport;
                /*0xa0*/ int textureArraySlice;
            }

            struct XRView
            {
                /*0x10*/ UnityEngine.Matrix4x4 projMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x90*/ UnityEngine.Rect viewport;
                /*0xa0*/ UnityEngine.Mesh occlusionMesh;
                /*0xa8*/ int textureArraySlice;

                /*0x270ea44*/ XRView(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Rect vp, int dstSlice);
                /*0x270ea78*/ XRView(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
            }

            class XRPass
            {
                static string k_XRCustomMirrorTag = "XR Custom Mirror View";
                static string k_XROcclusionTag = "XR Occlusion Mesh";
                static /*0x0*/ UnityEngine.Rendering.RenderTargetIdentifier invalidRT;
                static /*0x28*/ UnityEngine.Rendering.ProfilingSampler _XRCustomMirrorProfilingSampler;
                static /*0x30*/ UnityEngine.Rendering.ProfilingSampler _XROcclusionProfilingSampler;
                static /*0x38*/ int UNITY_STEREO_MATRIX_V;
                static /*0x3c*/ int UNITY_STEREO_MATRIX_IV;
                static /*0x40*/ int UNITY_STEREO_MATRIX_VP;
                static /*0x44*/ int UNITY_STEREO_MATRIX_IVP;
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.XRView> views;
                /*0x18*/ bool <xrSdkEnabled>k__BackingField;
                /*0x19*/ bool <copyDepth>k__BackingField;
                /*0x1c*/ int <multipassId>k__BackingField;
                /*0x20*/ int <cullingPassId>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.RenderTargetIdentifier <renderTarget>k__BackingField;
                /*0x50*/ UnityEngine.RenderTextureDescriptor <renderTargetDesc>k__BackingField;
                /*0x84*/ bool <renderTargetIsRenderTexture>k__BackingField;
                /*0x85*/ bool <isLateLatchEnabled>k__BackingField;
                /*0x86*/ bool <canMarkLateLatch>k__BackingField;
                /*0x87*/ bool <hasMarkedLateLatch>k__BackingField;
                /*0x88*/ UnityEngine.Rendering.ScriptableCullingParameters <cullingParams>k__BackingField;
                /*0x6b0*/ UnityEngine.Material occlusionMeshMaterial;
                /*0x6b8*/ UnityEngine.Mesh occlusionMeshCombined;
                /*0x6c0*/ int occlusionMeshCombinedHashCode;
                /*0x6c8*/ UnityEngine.Rendering.Universal.XRPass.CustomMirrorView customMirrorView;
                /*0x6d0*/ UnityEngine.Matrix4x4[] stereoProjectionMatrix;
                /*0x6d8*/ UnityEngine.Matrix4x4[] stereoViewMatrix;
                /*0x6e0*/ UnityEngine.Matrix4x4[] stereoCameraProjectionMatrix;

                static /*0x2710898*/ XRPass();
                static /*0x270e608*/ UnityEngine.Rendering.Universal.XRPass Create(UnityEngine.Rendering.Universal.XRPassCreateInfo createInfo);
                static /*0x270f4a8*/ UnityEngine.Rendering.Universal.XRPass Create(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrRenderPass, int multipassId, UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, UnityEngine.Material occlusionMeshMaterial);
                static /*0x270f780*/ void Release(UnityEngine.Rendering.Universal.XRPass xrPass);
                /*0x27107d4*/ XRPass();
                /*0x27073a8*/ bool get_enabled();
                /*0x270eb90*/ bool get_xrSdkEnabled();
                /*0x270eb98*/ void set_xrSdkEnabled(bool value);
                /*0x270eba4*/ bool get_copyDepth();
                /*0x270ebac*/ void set_copyDepth(bool value);
                /*0x270ebb8*/ int get_multipassId();
                /*0x270ebc0*/ void set_multipassId(int value);
                /*0x270ebc8*/ int get_cullingPassId();
                /*0x270ebd0*/ void set_cullingPassId(int value);
                /*0x270ebd8*/ UnityEngine.Rendering.RenderTargetIdentifier get_renderTarget();
                /*0x270ebf0*/ void set_renderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x270ec08*/ UnityEngine.RenderTextureDescriptor get_renderTargetDesc();
                /*0x270ec24*/ void set_renderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x270ec40*/ bool get_renderTargetValid();
                /*0x270ecf0*/ bool get_renderTargetIsRenderTexture();
                /*0x270ecf8*/ void set_renderTargetIsRenderTexture(bool value);
                /*0x270ed04*/ bool get_isLateLatchEnabled();
                /*0x270ed0c*/ void set_isLateLatchEnabled(bool value);
                /*0x270ed18*/ bool get_canMarkLateLatch();
                /*0x270ed20*/ void set_canMarkLateLatch(bool value);
                /*0x270ed2c*/ bool get_hasMarkedLateLatch();
                /*0x270ed34*/ void set_hasMarkedLateLatch(bool value);
                /*0x270b4ec*/ UnityEngine.Matrix4x4 GetProjMatrix(int viewIndex);
                /*0x270b580*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x270ed40*/ int GetTextureArraySlice(int viewIndex);
                /*0x270edac*/ UnityEngine.Rect GetViewport(int viewIndex);
                /*0x270ee1c*/ UnityEngine.Rendering.ScriptableCullingParameters get_cullingParams();
                /*0x270ee2c*/ void set_cullingParams(UnityEngine.Rendering.ScriptableCullingParameters value);
                /*0x270b614*/ int get_viewCount();
                /*0x270b4d4*/ bool get_singlePassEnabled();
                /*0x270ee44*/ bool get_isOcclusionMeshSupported();
                /*0x270eec8*/ bool get_hasValidOcclusionMesh();
                /*0x270efbc*/ void SetCustomMirrorView(UnityEngine.Rendering.Universal.XRPass.CustomMirrorView callback);
                /*0x270efc4*/ void UpdateView(int viewId, UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrSdkRenderPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter xrSdkRenderParameter);
                /*0x270f100*/ void UpdateView(int viewId, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Rect vp, int textureArraySlice);
                /*0x270f264*/ void UpdateCullingParams(int cullingPassId, UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                /*0x270e9ac*/ void AddView(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Rect vp, int textureArraySlice);
                /*0x270f704*/ void AddView(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrSdkRenderPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter xrSdkRenderParameter);
                /*0x270f288*/ void AddViewInternal(UnityEngine.Rendering.Universal.XRView xrView);
                /*0x270f7ec*/ void UpdateOcclusionMesh();
                /*0x270f8ac*/ bool TryGetOcclusionMeshCombinedHashCode(ref int hashCode);
                /*0x270f9dc*/ void CreateOcclusionMeshCombined();
                /*0x270fd28*/ void StartSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x270ff5c*/ void StopSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x2707a24*/ void EndCamera(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x2710024*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x2710364*/ void UpdateGPUViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isRenderToTexture);
                /*0x271066c*/ void MarkLateLatchShaderProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x2710764*/ void UnmarkLateLatchShaderProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);

                class CustomMirrorView : System.MulticastDelegate
                {
                    /*0x2710a60*/ CustomMirrorView(object object, nint method);
                    /*0x2710b90*/ void Invoke(UnityEngine.Rendering.Universal.XRPass pass, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture rt, UnityEngine.Rect viewport);
                    /*0x2710ba4*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.XRPass pass, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture rt, UnityEngine.Rect viewport, System.AsyncCallback callback, object object);
                    /*0x2710c50*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class XRSystem
            {
                static string k_XRMirrorTag = "XR Mirror View";
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.XR.XRDisplaySubsystem> displayList;
                static /*0x8*/ int msaaLevel;
                static /*0x10*/ UnityEngine.Rendering.ProfilingSampler _XRMirrorProfilingSampler;
                /*0x10*/ UnityEngine.Rendering.Universal.XRPass emptyPass;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.XRPass> framePasses;
                /*0x20*/ UnityEngine.XR.XRDisplaySubsystem display;
                /*0x28*/ UnityEngine.Material occlusionMeshMaterial;
                /*0x30*/ UnityEngine.Material mirrorViewMaterial;
                /*0x38*/ UnityEngine.MaterialPropertyBlock mirrorViewMaterialProperty;
                /*0x40*/ UnityEngine.RenderTexture testRenderTexture;

                static /*0x2711594*/ XRSystem();
                static /*0x2710dcc*/ void GetDisplaySubsystem();
                static /*0x2710e68*/ void XRSystemInit();
                static /*0x2703ac4*/ void UpdateMSAALevel(int level);
                static /*0x271100c*/ int GetMSAALevel();
                static /*0x2703c00*/ void UpdateRenderScale(float renderScale);
                static /*0x27114a8*/ bool <CreateLayoutFromXrSdk>g__CanUseSinglePass|26_0(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, ref UnityEngine.Rendering.Universal.XRSystem.<> );
                /*0x270c1b8*/ XRSystem();
                /*0x2710c70*/ void InitializeXRSystemData(UnityEngine.Rendering.Universal.XRSystemData data);
                /*0x2710c5c*/ int GetMaxViews();
                /*0x2708718*/ void BeginLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPass xrPass);
                /*0x2708784*/ void EndLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPass xrPass);
                /*0x2707b64*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.XRPass> SetupFrame(UnityEngine.Camera camera, bool enableXRRendering);
                /*0x27094c4*/ void ReleaseFrame();
                /*0x270a094*/ bool RefreshXrSdk();
                /*0x2707f38*/ void UpdateCameraData(ref UnityEngine.Rendering.Universal.CameraData baseCameraData, ref UnityEngine.Rendering.Universal.XRPass xr);
                /*0x27084ac*/ void UpdateFromCamera(ref UnityEngine.Rendering.Universal.XRPass xrPass, UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x2711064*/ void CreateLayoutFromXrSdk(UnityEngine.Camera camera, bool singlePassAllowed);
                /*0x2703eac*/ void Dispose();
                /*0x270e858*/ void AddPassToFrame(UnityEngine.Rendering.Universal.XRPass xrPass);
                /*0x2708d2c*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
                /*0x27114a4*/ void OverrideForAutomatedTests(UnityEngine.Camera camera);

                class XRShaderIDs
                {
                    static /*0x0*/ int _SourceTexArraySlice;
                    static /*0x4*/ int _SRGBRead;
                    static /*0x8*/ int _SRGBWrite;

                    static /*0x2711680*/ XRShaderIDs();
                }

                struct <>c__DisplayClass26_0
                {
                    /*0x10*/ UnityEngine.Camera camera;
                }
            }

            namespace LibTessDotNet
            {
                class Dict<TValue>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.LessOrEqual<TValue> _leq;
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> _head;

                    Dict(UnityEngine.Rendering.Universal.LibTessDotNet.Dict.LessOrEqual<TValue> leq);
                    UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> Insert(TValue key);
                    UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> InsertBefore(UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> node, TValue key);
                    UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> Find(TValue key);
                    UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> Min();
                    void Remove(UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> node);

                    class Node<TValue>
                    {
                        /*0x0*/ TValue _key;
                        /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> _prev;
                        /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> _next;

                        Node();
                        TValue get_Key();
                        UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> get_Prev();
                        UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> get_Next();
                    }

                    class LessOrEqual<TValue> : System.MulticastDelegate
                    {
                        LessOrEqual(object object, nint method);
                        bool Invoke(TValue lhs, TValue rhs);
                        System.IAsyncResult BeginInvoke(TValue lhs, TValue rhs, System.AsyncCallback callback, object object);
                        bool EndInvoke(System.IAsyncResult result);
                    }
                }

                class Geom
                {
                    static /*0x2711748*/ bool IsWindingInside(UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule rule, int n);
                    static /*0x27117f4*/ bool VertCCW(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x2711844*/ bool VertEq(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex lhs, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x2711884*/ bool VertLeq(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex lhs, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x27118d0*/ float EdgeEval(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x2711940*/ float EdgeSign(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x27119a0*/ bool TransLeq(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex lhs, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x27119ec*/ float TransEval(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x2711a5c*/ float TransSign(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x2711abc*/ bool EdgeGoesLeft(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e);
                    static /*0x2711b00*/ bool EdgeGoesRight(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e);
                    static /*0x2711b24*/ float VertL1dist(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v);
                    static /*0x2711ba8*/ void AddWinding(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDst, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eSrc);
                    static /*0x2711bf0*/ float Interpolate(float a, float x, float b, float y);
                    static /*0x2711c4c*/ void Swap(ref UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex a, ref UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex b);
                    static /*0x2711c60*/ void EdgeIntersect(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex o1, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex d1, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex o2, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex d2, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v);
                }

                class Mesh : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.Mesh>
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _vHead;
                    /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _fHead;
                    /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eHead;
                    /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eHeadSym;

                    /*0x2711fb4*/ Mesh();
                    /*0x2712108*/ void Reset();
                    /*0x2712114*/ void OnFree();
                    /*0x271221c*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge MakeEdge();
                    /*0x2712420*/ void Splice(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDst);
                    /*0x2712634*/ void Delete(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDel);
                    /*0x27127f8*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge AddEdgeVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg);
                    /*0x2712860*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge SplitEdge(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg);
                    /*0x2712930*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge Connect(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDst);
                    /*0x27129f0*/ void ZapFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face fZap);
                    /*0x2712b0c*/ void MergeConvexFaces(int maxVertsPerFace);
                    /*0x2712cd0*/ void Check();
                }

                struct Vec3
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 Zero;
                    /*0x10*/ float X;
                    /*0x14*/ float Y;
                    /*0x18*/ float Z;

                    static /*0x27130cc*/ Vec3();
                    static /*0x2712e40*/ void Sub(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 lhs, ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 rhs, ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 result);
                    static /*0x2712e64*/ void Neg(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v);
                    static /*0x2712e80*/ void Dot(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 u, ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v, ref float dot);
                    static /*0x2712eac*/ void Normalize(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v);
                    static /*0x2712f48*/ int LongAxis(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v);
                    /*0x2712d68*/ float get_Item(int index);
                    /*0x2712dd4*/ void set_Item(int index, float value);
                    /*0x2713008*/ string ToString();
                }

                class MeshUtils
                {
                    static int Undef = -1;

                    static /*0x271226c*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge MakeEdge(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eNext);
                    static /*0x27125ec*/ void Splice(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge a, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge b);
                    static /*0x27122ec*/ void MakeVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrig, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vNext);
                    static /*0x2712380*/ void MakeFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrig, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face fNext);
                    static /*0x2712764*/ void KillEdge(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDel);
                    static /*0x27124dc*/ void KillVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vDel, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex newOrg);
                    static /*0x2712564*/ void KillFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face fDel, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face newLFace);
                    static /*0x27130fc*/ float FaceArea(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face f);

                    class Pooled<T>
                    {
                        static /*0x0*/ System.Collections.Generic.Stack<T> _stack;

                        static T Create();
                        Pooled();
                        void Reset();
                        void OnFree();
                        void Free();
                    }

                    class Vertex : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex>
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _prev;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _next;
                        /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _anEdge;
                        /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _coords;
                        /*0x34*/ float _s;
                        /*0x38*/ float _t;
                        /*0x3c*/ UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle _pqHandle;
                        /*0x40*/ int _n;
                        /*0x48*/ object _data;

                        /*0x27131d8*/ Vertex();
                        /*0x271315c*/ void Reset();
                    }

                    class Face : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face>
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _prev;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _next;
                        /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _anEdge;
                        /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _trail;
                        /*0x30*/ int _n;
                        /*0x34*/ bool _marked;
                        /*0x35*/ bool _inside;

                        /*0x2713230*/ Face();
                        /*0x2712c80*/ int get_VertsCount();
                        /*0x2713220*/ void Reset();
                    }

                    struct EdgePair
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _e;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eSym;

                        static /*0x271209c*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.EdgePair Create();
                        /*0x2713278*/ void Reset();
                    }

                    class Edge : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge>
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.EdgePair _pair;
                        /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _next;
                        /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _Sym;
                        /*0x30*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _Onext;
                        /*0x38*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _Lnext;
                        /*0x40*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _Org;
                        /*0x48*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _Lface;
                        /*0x50*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion _activeRegion;
                        /*0x58*/ int _winding;

                        static /*0x27130d0*/ void EnsureFirst(ref UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e);
                        /*0x27133cc*/ Edge();
                        /*0x271272c*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face get__Rface();
                        /*0x2712914*/ void set__Rface(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face value);
                        /*0x2711ae4*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex get__Dst();
                        /*0x27128f8*/ void set__Dst(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex value);
                        /*0x2712748*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Oprev();
                        /*0x2713280*/ void set__Oprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x2712cb4*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Lprev();
                        /*0x271329c*/ void set__Lprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x27132b8*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Dprev();
                        /*0x27132d4*/ void set__Dprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x27132f0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Rprev();
                        /*0x271330c*/ void set__Rprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x2713328*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Dnext();
                        /*0x271334c*/ void set__Dnext(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x2713370*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Rnext();
                        /*0x2713394*/ void set__Rnext(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x27133b8*/ void Reset();
                    }
                }

                struct PQHandle
                {
                    static /*0x0*/ int Invalid;
                    /*0x10*/ int _handle;

                    static /*0x2713414*/ PQHandle();
                }

                class PriorityHeap<TValue>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> _leq;
                    /*0x0*/ int[] _nodes;
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.HandleElem<TValue> _handles;
                    /*0x0*/ int _size;
                    /*0x0*/ int _max;
                    /*0x0*/ int _freeList;
                    /*0x0*/ bool _initialized;

                    PriorityHeap(int initialSize, UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> leq);
                    bool get_Empty();
                    void FloatDown(int curr);
                    void FloatUp(int curr);
                    void Init();
                    UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle Insert(TValue value);
                    TValue ExtractMin();
                    TValue Minimum();
                    void Remove(UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle handle);

                    class LessOrEqual<TValue> : System.MulticastDelegate
                    {
                        LessOrEqual(object object, nint method);
                        bool Invoke(TValue lhs, TValue rhs);
                        System.IAsyncResult BeginInvoke(TValue lhs, TValue rhs, System.AsyncCallback callback, object object);
                        bool EndInvoke(System.IAsyncResult result);
                    }

                    class HandleElem<TValue>
                    {
                        /*0x0*/ TValue _key;
                        /*0x0*/ int _node;

                        HandleElem();
                    }
                }

                class PriorityQueue<TValue>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> _leq;
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap<TValue> _heap;
                    /*0x0*/ TValue[] _keys;
                    /*0x0*/ int[] _order;
                    /*0x0*/ int _size;
                    /*0x0*/ int _max;
                    /*0x0*/ bool _initialized;

                    static void Swap(ref int a, ref int b);
                    PriorityQueue(int initialSize, UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> leq);
                    bool get_Empty();
                    void Init();
                    UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle Insert(TValue value);
                    TValue ExtractMin();
                    TValue Minimum();
                    void Remove(UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle handle);

                    class StackItem<TValue>
                    {
                        /*0x0*/ int p;
                        /*0x0*/ int r;

                        StackItem();
                    }
                }

                class Tess
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.Mesh _mesh;
                    /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _normal;
                    /*0x24*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _sUnit;
                    /*0x30*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _tUnit;
                    /*0x3c*/ float _bminX;
                    /*0x40*/ float _bminY;
                    /*0x44*/ float _bmaxX;
                    /*0x48*/ float _bmaxY;
                    /*0x4c*/ UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule _windingRule;
                    /*0x50*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict<UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion> _dict;
                    /*0x58*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityQueue<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex> _pq;
                    /*0x60*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _event;
                    /*0x68*/ UnityEngine.Rendering.Universal.LibTessDotNet.CombineCallback _combineCallback;
                    /*0x70*/ UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] _vertices;
                    /*0x78*/ int _vertexCount;
                    /*0x80*/ int[] _elements;
                    /*0x88*/ int _elementCount;
                    /*0x8c*/ float SUnitX;
                    /*0x90*/ float SUnitY;
                    /*0x94*/ float SentinelCoord;
                    /*0x98*/ bool NoEmptyPolygons;
                    /*0x99*/ bool UsePooling;

                    /*0x27156fc*/ Tess();
                    /*0x2713460*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion RegionBelow(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x2713488*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion RegionAbove(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x27134b0*/ bool EdgeLeq(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg1, UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg2);
                    /*0x27135ac*/ void DeleteRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x2713614*/ void FixUpperEdge(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge newEdge);
                    /*0x2713658*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion TopLeftRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x2713708*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion TopRightRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x271375c*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion AddRegionBelow(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regAbove, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eNewUp);
                    /*0x2713814*/ void ComputeWinding(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x2713868*/ void FinishRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x2713898*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge FinishLeftRegions(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regFirst, UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regLast);
                    /*0x27139b4*/ void AddRightEdges(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eFirst, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eLast, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eTopLeft, bool cleanUp);
                    /*0x2713f2c*/ void SpliceMergeVertices(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e1, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e2);
                    /*0x2713f44*/ void VertexWeights(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex isect, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex org, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex dst, ref float w0, ref float w1);
                    /*0x2714034*/ void GetIntersectData(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex isect, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex orgUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex dstUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex orgLo, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex dstLo);
                    /*0x2713b70*/ bool CheckForRightSplice(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x27142c0*/ bool CheckForLeftSplice(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x2714424*/ bool CheckForIntersect(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x2713cfc*/ void WalkDirtyRegions(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x27149c0*/ void ConnectRightVertex(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eBottomLeft);
                    /*0x2714bbc*/ void ConnectLeftDegenerate(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x2714d78*/ void ConnectLeftVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x2714cb4*/ void SweepEvent(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x2714f94*/ void AddSentinel(float smin, float smax, float t);
                    /*0x2715088*/ void InitEdgeDict();
                    /*0x271516c*/ void DoneEdgeDict();
                    /*0x27151ec*/ void RemoveDegenerateEdges();
                    /*0x2715324*/ void InitPriorityQ();
                    /*0x2715528*/ void DonePriorityQ();
                    /*0x2715530*/ void RemoveDegenerateFaces();
                    /*0x27155bc*/ void ComputeInterior();
                    /*0x27156c4*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 get_Normal();
                    /*0x27156d0*/ void set_Normal(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 value);
                    /*0x27156dc*/ UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] get_Vertices();
                    /*0x27156e4*/ int get_VertexCount();
                    /*0x27156ec*/ int[] get_Elements();
                    /*0x27156f4*/ int get_ElementCount();
                    /*0x27157a0*/ void ComputeNormal(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 norm);
                    /*0x2715db8*/ void CheckOrientation();
                    /*0x2715eb4*/ void ProjectPolygon();
                    /*0x271618c*/ void TessellateMonoRegion(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face face);
                    /*0x271636c*/ void TessellateInterior();
                    /*0x27163cc*/ void DiscardExterior();
                    /*0x2716428*/ void SetWindingNumber(int value, bool keepOnlyBoundary);
                    /*0x27164d4*/ int GetNeighbourFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge edge);
                    /*0x271650c*/ void OutputPolymesh(UnityEngine.Rendering.Universal.LibTessDotNet.ElementType elementType, int polySize);
                    /*0x2716924*/ void OutputContours();
                    /*0x2716b34*/ float SignedArea(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] vertices);
                    /*0x2716bc8*/ void AddContour(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] vertices);
                    /*0x2716bd0*/ void AddContour(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] vertices, UnityEngine.Rendering.Universal.LibTessDotNet.ContourOrientation forceOrientation);
                    /*0x2716da8*/ void Tessellate(UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule windingRule, UnityEngine.Rendering.Universal.LibTessDotNet.ElementType elementType, int polySize);
                    /*0x2716db0*/ void Tessellate(UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule windingRule, UnityEngine.Rendering.Universal.LibTessDotNet.ElementType elementType, int polySize, UnityEngine.Rendering.Universal.LibTessDotNet.CombineCallback combineCallback);

                    class ActiveRegion
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eUp;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion> _nodeUp;
                        /*0x20*/ int _windingNumber;
                        /*0x24*/ bool _inside;
                        /*0x25*/ bool _sentinel;
                        /*0x26*/ bool _dirty;
                        /*0x27*/ bool _fixUpperEdge;

                        /*0x2717ecc*/ ActiveRegion();
                    }
                }

                enum WindingRule
                {
                    EvenOdd = 0,
                    NonZero = 1,
                    Positive = 2,
                    Negative = 3,
                    AbsGeqTwo = 4,
                }

                enum ElementType
                {
                    Polygons = 0,
                    ConnectedPolygons = 1,
                    BoundaryContours = 2,
                }

                enum ContourOrientation
                {
                    Original = 0,
                    Clockwise = 1,
                    CounterClockwise = 2,
                }

                struct ContourVertex
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 Position;
                    /*0x20*/ object Data;

                    /*0x2717ed4*/ string ToString();
                }

                class CombineCallback : System.MulticastDelegate
                {
                    /*0x2717f6c*/ CombineCallback(object object, nint method);
                    /*0x2718030*/ object Invoke(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 position, object[] data, float[] weights);
                    /*0x2718044*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 position, object[] data, float[] weights, System.AsyncCallback callback, object object);
                    /*0x27180e0*/ object EndInvoke(System.IAsyncResult result);
                }
            }

            namespace Internal
            {
                class DeferredConfig
                {
                    static int kPreferredCBufferSize = 65536;
                    static int kPreferredStructuredBufferSize = 131072;
                    static int kTilePixelWidth = 16;
                    static int kTilePixelHeight = 16;
                    static int kTilerDepth = 3;
                    static int kTilerSubdivisions = 4;
                    static int kAvgLightPerTile = 32;
                    static int kTileDepthInfoIntermediateLevel = -1;
                    static bool kHasNativeQuadSupport = false;
                    static /*0x0*/ bool <IsOpenGL>k__BackingField;
                    static /*0x1*/ bool <IsDX10>k__BackingField;

                    static /*0x27180ec*/ bool get_IsOpenGL();
                    static /*0x2718134*/ void set_IsOpenGL(bool value);
                    static /*0x2718180*/ bool get_IsDX10();
                    static /*0x27181c8*/ void set_IsDX10(bool value);
                    static /*0x2718214*/ bool get_UseCBufferForDepthRange();
                    static /*0x2718254*/ bool get_UseCBufferForTileList();
                    static /*0x2718294*/ bool get_UseCBufferForLightData();
                    static /*0x271829c*/ bool get_UseCBufferForLightList();
                }

                enum LightFlag
                {
                    SubtractiveMixedLighting = 4,
                }

                class DeferredLights
                {
                    static /*0x0*/ string[] k_GBufferNames;
                    static /*0x8*/ string[] k_TileDeferredPassNames;
                    static /*0x10*/ string[] k_StencilDeferredPassNames;
                    static /*0x18*/ ushort k_InvalidLightOffset;
                    static /*0x20*/ string k_SetupLights;
                    static /*0x28*/ string k_DeferredPass;
                    static /*0x30*/ string k_TileDepthInfo;
                    static /*0x38*/ string k_DeferredTiledPass;
                    static /*0x40*/ string k_DeferredStencilPass;
                    static /*0x48*/ string k_DeferredFogPass;
                    static /*0x50*/ string k_ClearStencilPartial;
                    static /*0x58*/ string k_SetupLightConstants;
                    static /*0x60*/ float kStencilShapeGuard;
                    static /*0x68*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupLights;
                    static /*0x70*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDeferredPass;
                    static /*0x78*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingTileDepthInfo;
                    static /*0x80*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupLightConstants;
                    /*0x10*/ bool <UseRenderPass>k__BackingField;
                    /*0x11*/ bool <HasDepthPrepass>k__BackingField;
                    /*0x12*/ bool <HasNormalPrepass>k__BackingField;
                    /*0x13*/ bool <IsOverlay>k__BackingField;
                    /*0x14*/ bool m_AccurateGbufferNormals;
                    /*0x15*/ bool <TiledDeferredShading>k__BackingField;
                    /*0x18*/ UnityEngine.Rendering.Universal.MixedLightingSetup <MixedLightingSetup>k__BackingField;
                    /*0x1c*/ bool <UseJobSystem>k__BackingField;
                    /*0x20*/ int <RenderWidth>k__BackingField;
                    /*0x24*/ int <RenderHeight>k__BackingField;
                    /*0x28*/ UnityEngine.Rendering.Universal.RenderTargetHandle[] <GbufferAttachments>k__BackingField;
                    /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier[] <DeferredInputAttachments>k__BackingField;
                    /*0x38*/ bool[] <DeferredInputIsTransient>k__BackingField;
                    /*0x40*/ UnityEngine.Rendering.Universal.RenderTargetHandle <DepthAttachment>k__BackingField;
                    /*0x70*/ UnityEngine.Rendering.Universal.RenderTargetHandle <DepthCopyTexture>k__BackingField;
                    /*0xa0*/ UnityEngine.Rendering.Universal.RenderTargetHandle <DepthInfoTexture>k__BackingField;
                    /*0xd0*/ UnityEngine.Rendering.Universal.RenderTargetHandle <TileDepthInfoTexture>k__BackingField;
                    /*0x100*/ UnityEngine.Rendering.RenderTargetIdentifier[] <GbufferAttachmentIdentifiers>k__BackingField;
                    /*0x108*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] <GbufferFormats>k__BackingField;
                    /*0x110*/ UnityEngine.Rendering.RenderTargetIdentifier <DepthAttachmentIdentifier>k__BackingField;
                    /*0x138*/ UnityEngine.Rendering.RenderTargetIdentifier <DepthCopyTextureIdentifier>k__BackingField;
                    /*0x160*/ UnityEngine.Rendering.RenderTargetIdentifier <DepthInfoTextureIdentifier>k__BackingField;
                    /*0x188*/ UnityEngine.Rendering.RenderTargetIdentifier <TileDepthInfoTextureIdentifier>k__BackingField;
                    /*0x1b0*/ int m_CachedRenderWidth;
                    /*0x1b4*/ int m_CachedRenderHeight;
                    /*0x1b8*/ UnityEngine.Matrix4x4 m_CachedProjectionMatrix;
                    /*0x1f8*/ UnityEngine.Rendering.Universal.Internal.DeferredTiler[] m_Tilers;
                    /*0x200*/ int[] m_TileDataCapacities;
                    /*0x208*/ bool m_HasTileVisLights;
                    /*0x210*/ Unity.Collections.NativeArray<ushort> m_stencilVisLights;
                    /*0x220*/ Unity.Collections.NativeArray<ushort> m_stencilVisLightOffsets;
                    /*0x230*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;
                    /*0x238*/ UnityEngine.Mesh m_SphereMesh;
                    /*0x240*/ UnityEngine.Mesh m_HemisphereMesh;
                    /*0x248*/ UnityEngine.Mesh m_FullscreenMesh;
                    /*0x250*/ int m_MaxDepthRangePerBatch;
                    /*0x254*/ int m_MaxTilesPerBatch;
                    /*0x258*/ int m_MaxPunctualLightPerBatch;
                    /*0x25c*/ int m_MaxRelLightIndicesPerBatch;
                    /*0x260*/ UnityEngine.Material m_TileDepthInfoMaterial;
                    /*0x268*/ UnityEngine.Material m_TileDeferredMaterial;
                    /*0x270*/ UnityEngine.Material m_StencilDeferredMaterial;
                    /*0x278*/ int[] m_StencilDeferredPasses;
                    /*0x280*/ int[] m_TileDeferredPasses;
                    /*0x288*/ UnityEngine.Matrix4x4[] m_ScreenToWorld;
                    /*0x290*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredTiledPass;
                    /*0x298*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredStencilPass;
                    /*0x2a0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredFogPass;
                    /*0x2a8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerClearStencilPartialPass;
                    /*0x2b0*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;

                    static /*0x2722ec4*/ DeferredLights();
                    static /*0x271cda4*/ UnityEngine.Rendering.StencilState OverwriteStencil(UnityEngine.Rendering.StencilState s, int stencilWriteMask);
                    static /*0x271cf58*/ UnityEngine.Rendering.RenderStateBlock OverwriteStencil(UnityEngine.Rendering.RenderStateBlock block, int stencilWriteMask, int stencilRef);
                    static /*0x272210c*/ UnityEngine.Mesh CreateSphereMesh();
                    static /*0x27226f0*/ UnityEngine.Mesh CreateHemisphereMesh();
                    static /*0x271e550*/ UnityEngine.Mesh CreateFullscreenMesh();
                    static /*0x272083c*/ int Align(int s, int alignment);
                    static /*0x272087c*/ uint PackTileID(uint i, uint j);
                    static /*0x2722cb8*/ uint FloatToUInt(float val);
                    static /*0x2722e8c*/ uint Half2ToUInt(float x, float y);
                    /*0x27187cc*/ DeferredLights(UnityEngine.Rendering.Universal.Internal.DeferredLights.InitParams initParams, bool useNativeRenderPass);
                    /*0x27182dc*/ int get_GBufferAlbedoIndex();
                    /*0x27182e4*/ int get_GBufferSpecularMetallicIndex();
                    /*0x27182ec*/ int get_GBufferNormalSmoothnessIndex();
                    /*0x27182f4*/ int get_GBufferLightingIndex();
                    /*0x27182fc*/ int get_GbufferDepthIndex();
                    /*0x2718310*/ int get_GBufferShadowMask();
                    /*0x271833c*/ int get_GBufferRenderingLayers();
                    /*0x27183d0*/ int get_GBufferSliceCount();
                    /*0x2718404*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGBufferFormat(int index);
                    /*0x271832c*/ bool get_UseShadowMask();
                    /*0x2718370*/ bool get_UseRenderingLayers();
                    /*0x27184f4*/ bool get_UseRenderPass();
                    /*0x27184fc*/ void set_UseRenderPass(bool value);
                    /*0x2718508*/ bool get_HasDepthPrepass();
                    /*0x2718510*/ void set_HasDepthPrepass(bool value);
                    /*0x271851c*/ bool get_HasNormalPrepass();
                    /*0x2718524*/ void set_HasNormalPrepass(bool value);
                    /*0x2718530*/ bool get_IsOverlay();
                    /*0x2718538*/ void set_IsOverlay(bool value);
                    /*0x2718544*/ bool get_AccurateGbufferNormals();
                    /*0x271854c*/ void set_AccurateGbufferNormals(bool value);
                    /*0x27185d4*/ bool get_TiledDeferredShading();
                    /*0x27185dc*/ void set_TiledDeferredShading(bool value);
                    /*0x27185e8*/ UnityEngine.Rendering.Universal.MixedLightingSetup get_MixedLightingSetup();
                    /*0x27185f0*/ void set_MixedLightingSetup(UnityEngine.Rendering.Universal.MixedLightingSetup value);
                    /*0x27185f8*/ bool get_UseJobSystem();
                    /*0x2718600*/ void set_UseJobSystem(bool value);
                    /*0x271860c*/ int get_RenderWidth();
                    /*0x2718614*/ void set_RenderWidth(int value);
                    /*0x271861c*/ int get_RenderHeight();
                    /*0x2718624*/ void set_RenderHeight(int value);
                    /*0x271862c*/ UnityEngine.Rendering.Universal.RenderTargetHandle[] get_GbufferAttachments();
                    /*0x2718634*/ void set_GbufferAttachments(UnityEngine.Rendering.Universal.RenderTargetHandle[] value);
                    /*0x271863c*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_DeferredInputAttachments();
                    /*0x2718644*/ void set_DeferredInputAttachments(UnityEngine.Rendering.RenderTargetIdentifier[] value);
                    /*0x271864c*/ bool[] get_DeferredInputIsTransient();
                    /*0x2718654*/ void set_DeferredInputIsTransient(bool[] value);
                    /*0x271865c*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_DepthAttachment();
                    /*0x2718670*/ void set_DepthAttachment(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x2718684*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_DepthCopyTexture();
                    /*0x2718698*/ void set_DepthCopyTexture(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x27186ac*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_DepthInfoTexture();
                    /*0x27186c0*/ void set_DepthInfoTexture(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x27186d4*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_TileDepthInfoTexture();
                    /*0x27186e8*/ void set_TileDepthInfoTexture(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x27186fc*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_GbufferAttachmentIdentifiers();
                    /*0x2718704*/ void set_GbufferAttachmentIdentifiers(UnityEngine.Rendering.RenderTargetIdentifier[] value);
                    /*0x271870c*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_GbufferFormats();
                    /*0x2718714*/ void set_GbufferFormats(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                    /*0x271871c*/ UnityEngine.Rendering.RenderTargetIdentifier get_DepthAttachmentIdentifier();
                    /*0x2718730*/ void set_DepthAttachmentIdentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                    /*0x2718744*/ UnityEngine.Rendering.RenderTargetIdentifier get_DepthCopyTextureIdentifier();
                    /*0x271875c*/ void set_DepthCopyTextureIdentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                    /*0x2718774*/ UnityEngine.Rendering.RenderTargetIdentifier get_DepthInfoTextureIdentifier();
                    /*0x2718788*/ void set_DepthInfoTextureIdentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                    /*0x271879c*/ UnityEngine.Rendering.RenderTargetIdentifier get_TileDepthInfoTextureIdentifier();
                    /*0x27187b4*/ void set_TileDepthInfoTextureIdentifier(UnityEngine.Rendering.RenderTargetIdentifier value);
                    /*0x27193f8*/ ref UnityEngine.Rendering.Universal.Internal.DeferredTiler GetTiler(int i);
                    /*0x271942c*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271bf00*/ void ResolveMixedLightingMode(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271c1ac*/ void DisableFramebufferFetchInput();
                    /*0x271c074*/ void CreateGbufferAttachments();
                    /*0x271c1b4*/ bool IsRuntimeSupportedThisFrame();
                    /*0x271c268*/ void Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, UnityEngine.Rendering.Universal.RenderTargetHandle depthCopyTexture, UnityEngine.Rendering.Universal.RenderTargetHandle depthInfoTexture, UnityEngine.Rendering.Universal.RenderTargetHandle tileDepthInfoTexture, UnityEngine.Rendering.Universal.RenderTargetHandle depthAttachment, UnityEngine.Rendering.Universal.RenderTargetHandle colorAttachment);
                    /*0x271ca8c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x271d1b4*/ bool HasTileLights();
                    /*0x271d1bc*/ bool HasTileDepthRangeExtraPass();
                    /*0x271d24c*/ void ExecuteTileDepthInfoPass(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271ddc0*/ void ExecuteDownsampleBitmaskPass(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271e380*/ void ClearStencilPartial(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x271e69c*/ void ExecuteDeferredPass(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271b4a0*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272054c*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                    /*0x271e9ac*/ void SetupMatrixConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271b4a8*/ void SortLights(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight> prePunctualLights);
                    /*0x271c920*/ bool CheckHasTileLights(ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                    /*0x271ac4c*/ void PrecomputeLights(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight> prePunctualLights, ref Unity.Collections.NativeArray<ushort> stencilVisLights, ref Unity.Collections.NativeArray<ushort> stencilVisLightOffsets, ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLights, UnityEngine.Matrix4x4 view, bool isOrthographic, float zNear);
                    /*0x271f1f4*/ void RenderTileLights(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x271ed98*/ bool HasStencilLightsOfType(UnityEngine.LightType type);
                    /*0x271ef54*/ void RenderStencilLights(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2720c38*/ void RenderStencilDirectionalLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, int mainLightIndex);
                    /*0x272128c*/ void RenderStencilPointLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                    /*0x272194c*/ void RenderStencilSpotLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                    /*0x271ee10*/ void RenderSSAOBeforeShading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2720354*/ void RenderFog(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27207d8*/ int TrimLights(ref Unity.Collections.NativeArray<ushort> trimmedLights, ref Unity.Collections.NativeArray<ushort> tiles, int offset, int lightCount, ref UnityEngine.Rendering.Universal.Internal.BitArray usedLights);
                    /*0x272089c*/ void StorePunctualLightData(ref Unity.Collections.NativeArray<Unity.Mathematics.uint4> punctualLightBuffer, int storeIndex, ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, int index);
                    /*0x2720884*/ void StoreTileData(ref Unity.Collections.NativeArray<Unity.Mathematics.uint4> tileList, int storeIndex, uint tileID, uint listBitMask, ushort relLightOffset, ushort lightCount);
                    /*0x2722d68*/ bool IsTileLight(UnityEngine.Rendering.VisibleLight visibleLight);
                    /*0x2718dac*/ void InitTileDeferredMaterial();
                    /*0x2718fe0*/ void InitStencilDeferredMaterial();

                    class ShaderConstants
                    {
                        static /*0x0*/ int _LitStencilRef;
                        static /*0x4*/ int _LitStencilReadMask;
                        static /*0x8*/ int _LitStencilWriteMask;
                        static /*0xc*/ int _SimpleLitStencilRef;
                        static /*0x10*/ int _SimpleLitStencilReadMask;
                        static /*0x14*/ int _SimpleLitStencilWriteMask;
                        static /*0x18*/ int _StencilRef;
                        static /*0x1c*/ int _StencilReadMask;
                        static /*0x20*/ int _StencilWriteMask;
                        static /*0x24*/ int _LitPunctualStencilRef;
                        static /*0x28*/ int _LitPunctualStencilReadMask;
                        static /*0x2c*/ int _LitPunctualStencilWriteMask;
                        static /*0x30*/ int _SimpleLitPunctualStencilRef;
                        static /*0x34*/ int _SimpleLitPunctualStencilReadMask;
                        static /*0x38*/ int _SimpleLitPunctualStencilWriteMask;
                        static /*0x3c*/ int _LitDirStencilRef;
                        static /*0x40*/ int _LitDirStencilReadMask;
                        static /*0x44*/ int _LitDirStencilWriteMask;
                        static /*0x48*/ int _SimpleLitDirStencilRef;
                        static /*0x4c*/ int _SimpleLitDirStencilReadMask;
                        static /*0x50*/ int _SimpleLitDirStencilWriteMask;
                        static /*0x54*/ int _ClearStencilRef;
                        static /*0x58*/ int _ClearStencilReadMask;
                        static /*0x5c*/ int _ClearStencilWriteMask;
                        static /*0x60*/ int UDepthRanges;
                        static /*0x64*/ int _DepthRanges;
                        static /*0x68*/ int _DownsamplingWidth;
                        static /*0x6c*/ int _DownsamplingHeight;
                        static /*0x70*/ int _SourceShiftX;
                        static /*0x74*/ int _SourceShiftY;
                        static /*0x78*/ int _TileShiftX;
                        static /*0x7c*/ int _TileShiftY;
                        static /*0x80*/ int _tileXCount;
                        static /*0x84*/ int _DepthRangeOffset;
                        static /*0x88*/ int _BitmaskTex;
                        static /*0x8c*/ int UTileList;
                        static /*0x90*/ int _TileList;
                        static /*0x94*/ int UPunctualLightBuffer;
                        static /*0x98*/ int _PunctualLightBuffer;
                        static /*0x9c*/ int URelLightList;
                        static /*0xa0*/ int _RelLightList;
                        static /*0xa4*/ int _TilePixelWidth;
                        static /*0xa8*/ int _TilePixelHeight;
                        static /*0xac*/ int _InstanceOffset;
                        static /*0xb0*/ int _DepthTex;
                        static /*0xb4*/ int _DepthTexSize;
                        static /*0xb8*/ int _ScreenToWorld;
                        static /*0xbc*/ int _unproject0;
                        static /*0xc0*/ int _unproject1;
                        static /*0xc4*/ int _MainLightPosition;
                        static /*0xc8*/ int _MainLightColor;
                        static /*0xcc*/ int _MainLightLayerMask;
                        static /*0xd0*/ int _SpotLightScale;
                        static /*0xd4*/ int _SpotLightBias;
                        static /*0xd8*/ int _SpotLightGuard;
                        static /*0xdc*/ int _LightPosWS;
                        static /*0xe0*/ int _LightColor;
                        static /*0xe4*/ int _LightAttenuation;
                        static /*0xe8*/ int _LightOcclusionProbInfo;
                        static /*0xec*/ int _LightDirection;
                        static /*0xf0*/ int _LightFlags;
                        static /*0xf4*/ int _ShadowLightIndex;
                        static /*0xf8*/ int _LightLayerMask;
                        static /*0xfc*/ int _CookieLightIndex;

                        static /*0x2723578*/ ShaderConstants();
                    }

                    struct CullLightsJob : Unity.Jobs.IJob
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.Internal.DeferredTiler tiler;
                        /*0x88*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight> prePunctualLights;
                        /*0x98*/ Unity.Collections.NativeArray<ushort> coarseTiles;
                        /*0xa8*/ Unity.Collections.NativeArray<uint> coarseTileHeaders;
                        /*0xb8*/ int coarseHeaderOffset;
                        /*0xbc*/ int istart;
                        /*0xc0*/ int iend;
                        /*0xc4*/ int jstart;
                        /*0xc8*/ int jend;

                        /*0x271b578*/ void Execute();
                    }

                    struct DrawCall
                    {
                        /*0x10*/ UnityEngine.ComputeBuffer tileList;
                        /*0x18*/ UnityEngine.ComputeBuffer punctualLightBuffer;
                        /*0x20*/ UnityEngine.ComputeBuffer relLightList;
                        /*0x28*/ int tileListSize;
                        /*0x2c*/ int punctualLightBufferSize;
                        /*0x30*/ int relLightListSize;
                        /*0x34*/ int instanceOffset;
                        /*0x38*/ int instanceCount;
                    }

                    enum TileDeferredPasses
                    {
                        PunctualLit = 0,
                        PunctualSimpleLit = 1,
                    }

                    enum StencilDeferredPasses
                    {
                        StencilVolume = 0,
                        PunctualLit = 1,
                        PunctualSimpleLit = 2,
                        DirectionalLit = 3,
                        DirectionalSimpleLit = 4,
                        ClearStencilPartial = 5,
                        Fog = 6,
                        SSAOOnly = 7,
                    }

                    struct InitParams
                    {
                        /*0x10*/ UnityEngine.Material tileDepthInfoMaterial;
                        /*0x18*/ UnityEngine.Material tileDeferredMaterial;
                        /*0x20*/ UnityEngine.Material stencilDeferredMaterial;
                        /*0x28*/ UnityEngine.Rendering.Universal.LightCookieManager lightCookieManager;
                    }
                }

                class SortPrePunctualLight : System.Collections.Generic.IComparer<UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight>
                {
                    /*0x27206dc*/ SortPrePunctualLight();
                    /*0x2724714*/ int Compare(UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight a, UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight b);
                }

                struct BitArray : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.NativeArray<uint> m_Mem;
                    /*0x20*/ int m_BitCount;
                    /*0x24*/ int m_IntCount;

                    /*0x2720748*/ BitArray(int bitCount, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x2720bf0*/ void Dispose();
                    /*0x2720850*/ void Clear();
                    /*0x2722c98*/ bool IsSet(int bitIndex);
                    /*0x2720bc4*/ void Set(int bitIndex, bool val);
                }

                struct DeferredTiler
                {
                    /*0x10*/ int m_TilePixelWidth;
                    /*0x14*/ int m_TilePixelHeight;
                    /*0x18*/ int m_TileXCount;
                    /*0x1c*/ int m_TileYCount;
                    /*0x20*/ int m_TileHeaderSize;
                    /*0x24*/ int m_AvgLightPerTile;
                    /*0x28*/ int m_TilerLevel;
                    /*0x2c*/ UnityEngine.FrustumPlanes m_FrustumPlanes;
                    /*0x44*/ bool m_IsOrthographic;
                    /*0x48*/ Unity.Collections.NativeArray<int> m_Counters;
                    /*0x58*/ Unity.Collections.NativeArray<ushort> m_TileData;
                    /*0x68*/ Unity.Collections.NativeArray<uint> m_TileHeaders;
                    /*0x78*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.PreTile> m_PreTiles;

                    static /*0x27248a0*/ bool IntersectionLineSphere(Unity.Mathematics.float3 centre, float radius, Unity.Mathematics.float3 raySource, Unity.Mathematics.float3 rayDirection, ref float t0, ref float t1);
                    static /*0x27249e0*/ bool Clip(ref UnityEngine.Rendering.Universal.PreTile tile, Unity.Mathematics.float3 posVS, float radius);
                    static /*0x2724d20*/ UnityEngine.Rendering.Universal.Internal.DeferredTiler.ClipResult ClipPartial(Unity.Mathematics.float4 plane, Unity.Mathematics.float4 sidePlaneA, Unity.Mathematics.float4 sidePlaneB, Unity.Mathematics.float3 posVS, float radius, float radiusSq, ref int insideCount);
                    static /*0x2724e14*/ Unity.Mathematics.float4 MakePlane(Unity.Mathematics.float3 pb, Unity.Mathematics.float3 pc);
                    static /*0x2724ec4*/ Unity.Mathematics.float4 MakePlane(Unity.Mathematics.float3 pa, Unity.Mathematics.float3 pb, Unity.Mathematics.float3 pc);
                    static /*0x2724fbc*/ float DistanceToPlane(Unity.Mathematics.float4 plane, Unity.Mathematics.float3 p);
                    static /*0x2724fd8*/ float SignedSq(float f);
                    static /*0x2724ff4*/ float min2(float a, float b);
                    static /*0x2725000*/ float max2(float a, float b);
                    static /*0x272500c*/ float max3(float a, float b, float c);
                    static /*0x272502c*/ uint _f32tof16(float x);
                    static /*0x272508c*/ int Align(int s, int alignment);
                    /*0x27193b0*/ DeferredTiler(int tilePixelWidth, int tilePixelHeight, int avgLightPerTile, int tilerLevel);
                    /*0x2724734*/ int get_TilerLevel();
                    /*0x272473c*/ int get_TileXCount();
                    /*0x2724744*/ int get_TileYCount();
                    /*0x272474c*/ int get_TilePixelWidth();
                    /*0x2724754*/ int get_TilePixelHeight();
                    /*0x272475c*/ int get_TileHeaderSize();
                    /*0x27206e4*/ int get_MaxLightPerTile();
                    /*0x271cc34*/ int get_TileDataCapacity();
                    /*0x2724764*/ Unity.Collections.NativeArray<ushort> get_Tiles();
                    /*0x2724770*/ Unity.Collections.NativeArray<uint> get_TileHeaders();
                    /*0x272477c*/ void GetTileOffsetAndCount(int i, int j, ref int offset, ref int count);
                    /*0x27247a8*/ int GetTileHeaderOffset(int i, int j);
                    /*0x271ab34*/ void Setup(int tileDataCapacity);
                    /*0x271cc98*/ void OnCameraCleanup();
                    /*0x271a1e8*/ void PrecomputeTiles(UnityEngine.Matrix4x4 proj, bool isOrthographic, int renderWidth, int renderHeight);
                    /*0x271b5d0*/ void CullFinalLights(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight> punctualLights, ref Unity.Collections.NativeArray<ushort> lightIndices, int lightStartIndex, int lightCount, int istart, int iend, int jstart, int jend);
                    /*0x27240d4*/ void CullIntermediateLights(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.Internal.DeferredTiler.PrePunctualLight> punctualLights, ref Unity.Collections.NativeArray<ushort> lightIndices, int lightStartIndex, int lightCount, int istart, int iend, int jstart, int jend);
                    /*0x27247bc*/ int AddTileData(ushort* lightData, ref int size);

                    struct PrePunctualLight
                    {
                        /*0x10*/ Unity.Mathematics.float3 posVS;
                        /*0x1c*/ float radius;
                        /*0x20*/ float minDist;
                        /*0x24*/ Unity.Mathematics.float2 screenPos;
                        /*0x2c*/ ushort visLightIndex;
                    }

                    enum ClipResult
                    {
                        Unknown = 0,
                        In = 1,
                        Out = 2,
                    }
                }

                class AdditionalLightsShadowCasterPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_ShadowmapBufferBits = 16;
                    static float LightTypeIdentifierInShadowParams_Spot = 0;
                    static float LightTypeIdentifierInShadowParams_Point = 1;
                    static int kMinimumPunctualLightHardShadowResolution = 8;
                    static int kMinimumPunctualLightSoftShadowResolution = 16;
                    static /*0x0*/ int m_AdditionalShadowsBufferId;
                    static /*0x4*/ int m_AdditionalShadowsIndicesId;
                    static /*0x8*/ UnityEngine.Vector4 c_DefaultShadowParams;
                    static /*0x18*/ int m_AdditionalLightsWorldToShadow_SSBO;
                    static /*0x1c*/ int m_AdditionalShadowParams_SSBO;
                    /*0xd8*/ bool m_UseStructuredBuffer;
                    /*0xe0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_AdditionalLightsShadowmap;
                    /*0x110*/ UnityEngine.RenderTexture m_AdditionalLightsShadowmapTexture;
                    /*0x118*/ float m_MaxShadowDistanceSq;
                    /*0x11c*/ float m_CascadeBorder;
                    /*0x120*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_AdditionalLightsShadowSlices;
                    /*0x128*/ int[] m_VisibleLightIndexToAdditionalLightIndex;
                    /*0x130*/ int[] m_AdditionalLightIndexToVisibleLightIndex;
                    /*0x138*/ System.Collections.Generic.List<int> m_ShadowSliceToAdditionalLightIndex;
                    /*0x140*/ System.Collections.Generic.List<int> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;
                    /*0x148*/ UnityEngine.Vector4[] m_AdditionalLightIndexToShadowParams;
                    /*0x150*/ UnityEngine.Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;
                    /*0x158*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest> m_ShadowResolutionRequests;
                    /*0x160*/ float[] m_VisibleLightIndexToCameraSquareDistance;
                    /*0x168*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] m_SortedShadowResolutionRequests;
                    /*0x170*/ int[] m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;
                    /*0x178*/ System.Collections.Generic.List<UnityEngine.RectInt> m_UnusedAtlasSquareAreas;
                    /*0x180*/ bool m_CreateEmptyShadowmap;
                    /*0x188*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;
                    /*0x190*/ System.Collections.Generic.Dictionary<int, ulong> m_ShadowRequestsHashes;

                    static /*0x2728bcc*/ AdditionalLightsShadowCasterPass();
                    static /*0x27256fc*/ float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels);
                    static /*0x2725780*/ float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering);
                    /*0x27250a0*/ AdditionalLightsShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x27256dc*/ int GetPunctualLightShadowSlicesCount(ref UnityEngine.LightType lightType);
                    /*0x272576c*/ int MinimalPunctualLightShadowResolution(bool softShadow);
                    /*0x27258ac*/ void InsertionSort(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] array, int startIndex, int lastIndex);
                    /*0x2725b4c*/ int EstimateScaleFactorNeededToFitAllShadowsInAtlas(ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] shadowResolutionRequests, int endIndex, int atlasWidth);
                    /*0x2725bd4*/ void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor);
                    /*0x2725f14*/ ulong ResolutionLog2ForHash(int resolution);
                    /*0x2725f60*/ ulong ComputeShadowRequestHash(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2726370*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2727c80*/ bool SetupForEmptyRendering(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2727d8c*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x2727e24*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27287c4*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x27220cc*/ int GetShadowLightIndexFromLightIndex(int visibleLightIndex);
                    /*0x2727c18*/ void Clear();
                    /*0x2727e60*/ void SetEmptyAdditionalShadowmapAtlas(ref UnityEngine.Rendering.ScriptableRenderContext context);
                    /*0x2728080*/ void RenderAdditionalShadowmapAtlas(ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.LightData lightData, ref UnityEngine.Rendering.Universal.ShadowData shadowData);
                    /*0x272888c*/ void SetupAdditionalLightsShadowReceiverConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.ShadowData shadowData, bool softShadows);
                    /*0x27261f8*/ bool IsValidShadowCastingLight(ref UnityEngine.Rendering.Universal.LightData lightData, int i);

                    class AdditionalShadowsConstantBuffer
                    {
                        static /*0x0*/ int _AdditionalLightsWorldToShadow;
                        static /*0x4*/ int _AdditionalShadowParams;
                        static /*0x8*/ int _AdditionalShadowOffset0;
                        static /*0xc*/ int _AdditionalShadowOffset1;
                        static /*0x10*/ int _AdditionalShadowOffset2;
                        static /*0x14*/ int _AdditionalShadowOffset3;
                        static /*0x18*/ int _AdditionalShadowFadeParams;
                        static /*0x1c*/ int _AdditionalShadowmapSize;
                    }

                    struct ShadowResolutionRequest
                    {
                        /*0x10*/ int visibleLightIndex;
                        /*0x14*/ int perLightShadowSliceIndex;
                        /*0x18*/ int requestedResolution;
                        /*0x1c*/ bool softShadow;
                        /*0x1d*/ bool pointLightShadow;
                        /*0x20*/ int offsetX;
                        /*0x24*/ int offsetY;
                        /*0x28*/ int allocatedResolution;

                        /*0x2729c1c*/ ShadowResolutionRequest(int _visibleLightIndex, int _perLightShadowSliceIndex, int _requestedResolution, bool _softShadow, bool _pointLightShadow);
                    }
                }

                class ForwardLights
                {
                    static string k_SetupLightConstants = "Setup Light Constants";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x10*/ int m_AdditionalLightsBufferId;
                    /*0x14*/ int m_AdditionalLightsIndicesId;
                    /*0x18*/ UnityEngine.Rendering.Universal.MixedLightingSetup m_MixedLightingSetup;
                    /*0x20*/ UnityEngine.Vector4[] m_AdditionalLightPositions;
                    /*0x28*/ UnityEngine.Vector4[] m_AdditionalLightColors;
                    /*0x30*/ UnityEngine.Vector4[] m_AdditionalLightAttenuations;
                    /*0x38*/ UnityEngine.Vector4[] m_AdditionalLightSpotDirections;
                    /*0x40*/ UnityEngine.Vector4[] m_AdditionalLightOcclusionProbeChannels;
                    /*0x48*/ float[] m_AdditionalLightsLayerMasks;
                    /*0x50*/ bool m_UseStructuredBuffer;
                    /*0x51*/ bool m_UseClusteredRendering;
                    /*0x54*/ int m_DirectionalLightCount;
                    /*0x58*/ int m_ActualTileWidth;
                    /*0x5c*/ Unity.Mathematics.int2 m_TileResolution;
                    /*0x64*/ int m_RequestedTileWidth;
                    /*0x68*/ float m_ZBinFactor;
                    /*0x6c*/ int m_ZBinOffset;
                    /*0x70*/ Unity.Jobs.JobHandle m_CullingHandle;
                    /*0x80*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.ZBin> m_ZBins;
                    /*0x90*/ Unity.Collections.NativeArray<uint> m_TileLightMasks;
                    /*0xa0*/ UnityEngine.ComputeBuffer m_ZBinBuffer;
                    /*0xa8*/ UnityEngine.ComputeBuffer m_TileBuffer;
                    /*0xb0*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;

                    static /*0x272c92c*/ ForwardLights();
                    /*0x2729c40*/ ForwardLights();
                    /*0x2729d88*/ ForwardLights(UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams initParams);
                    /*0x272a220*/ void ProcessLights(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272b7c4*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272bf6c*/ void Cleanup();
                    /*0x272bfac*/ void InitializeLightConstants(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel, ref uint lightLayerMask);
                    /*0x272bf34*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272c188*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                    /*0x272c2a8*/ void SetupAdditionalLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272c76c*/ int SetupPerObjectLightIndices(UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.LightData lightData);

                    class LightConstantBuffer
                    {
                        static /*0x0*/ int _MainLightPosition;
                        static /*0x4*/ int _MainLightColor;
                        static /*0x8*/ int _MainLightOcclusionProbesChannel;
                        static /*0xc*/ int _MainLightLayerMask;
                        static /*0x10*/ int _AdditionalLightsCount;
                        static /*0x14*/ int _AdditionalLightsPosition;
                        static /*0x18*/ int _AdditionalLightsColor;
                        static /*0x1c*/ int _AdditionalLightsAttenuation;
                        static /*0x20*/ int _AdditionalLightsSpotDir;
                        static /*0x24*/ int _AdditionalLightOcclusionProbeChannel;
                        static /*0x28*/ int _AdditionalLightsLayerMasks;
                    }

                    struct InitParams
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager lightCookieManager;
                        /*0x18*/ bool clusteredRendering;
                        /*0x1c*/ int tileSize;

                        static /*0x2729c68*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams GetDefault();
                    }
                }

                class MotionVectorRendering
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Internal.MotionVectorRendering s_Instance;
                    /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Camera, UnityEngine.Rendering.Universal.Internal.PreviousFrameData> m_CameraFrameData;
                    /*0x18*/ uint m_FrameCount;
                    /*0x1c*/ float m_LastTime;
                    /*0x20*/ float m_Time;

                    static /*0x272ca3c*/ UnityEngine.Rendering.Universal.Internal.MotionVectorRendering get_instance();
                    /*0x272c9bc*/ MotionVectorRendering();
                    /*0x272cab8*/ void Clear();
                    /*0x272cb08*/ UnityEngine.Rendering.Universal.Internal.PreviousFrameData GetMotionDataForCamera(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.CameraData camData);
                    /*0x272cc0c*/ void CalculateTime();
                    /*0x272cc58*/ void UpdateMotionData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.Internal.PreviousFrameData motionData);
                }

                class NormalReconstruction
                {
                    static /*0x0*/ int s_NormalReconstructionMatrixID;
                    static /*0x8*/ UnityEngine.Matrix4x4[] s_NormalReconstructionMatrix;

                    static /*0x272d544*/ NormalReconstruction();
                    static /*0x272d1c0*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                }

                class ColorGradingLutPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Material m_LutBuilderLdr;
                    /*0xe0*/ UnityEngine.Material m_LutBuilderHdr;
                    /*0xe8*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_HdrLutFormat;
                    /*0xec*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_LdrLutFormat;
                    /*0xf0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_InternalLut;
                    /*0x120*/ bool m_AllowColorGradingACESHDR;

                    /*0x272d5e0*/ ColorGradingLutPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x272d8dc*/ void Setup(ref UnityEngine.Rendering.Universal.RenderTargetHandle internalLut);
                    /*0x272d8f0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272ea64*/ void OnFinishCameraStackRendering(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x272ea88*/ void Cleanup();
                    /*0x272d77c*/ UnityEngine.Material <.ctor>g__Load|6_0(UnityEngine.Shader shader);

                    class ShaderConstants
                    {
                        static /*0x0*/ int _Lut_Params;
                        static /*0x4*/ int _ColorBalance;
                        static /*0x8*/ int _ColorFilter;
                        static /*0xc*/ int _ChannelMixerRed;
                        static /*0x10*/ int _ChannelMixerGreen;
                        static /*0x14*/ int _ChannelMixerBlue;
                        static /*0x18*/ int _HueSatCon;
                        static /*0x1c*/ int _Lift;
                        static /*0x20*/ int _Gamma;
                        static /*0x24*/ int _Gain;
                        static /*0x28*/ int _Shadows;
                        static /*0x2c*/ int _Midtones;
                        static /*0x30*/ int _Highlights;
                        static /*0x34*/ int _ShaHiLimits;
                        static /*0x38*/ int _SplitShadows;
                        static /*0x3c*/ int _SplitHighlights;
                        static /*0x40*/ int _CurveMaster;
                        static /*0x44*/ int _CurveRed;
                        static /*0x48*/ int _CurveGreen;
                        static /*0x4c*/ int _CurveBlue;
                        static /*0x50*/ int _CurveHueVsHue;
                        static /*0x54*/ int _CurveHueVsSat;
                        static /*0x58*/ int _CurveLumVsSat;
                        static /*0x5c*/ int _CurveSatVsSat;

                        static /*0x272eaf0*/ ShaderConstants();
                    }
                }

                class CopyColorPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ int m_SampleOffsetShaderHandle;
                    /*0xe0*/ UnityEngine.Material m_SamplingMaterial;
                    /*0xe8*/ UnityEngine.Rendering.Universal.Downsampling m_DownsamplingMethod;
                    /*0xf0*/ UnityEngine.Material m_CopyColorMaterial;
                    /*0xf8*/ UnityEngine.Rendering.RenderTargetIdentifier <source>k__BackingField;
                    /*0x120*/ UnityEngine.Rendering.Universal.RenderTargetHandle <destination>k__BackingField;

                    /*0x272efcc*/ CopyColorPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material samplingMaterial, UnityEngine.Material copyColorMaterial);
                    /*0x272ef6c*/ UnityEngine.Rendering.RenderTargetIdentifier get_source();
                    /*0x272ef88*/ void set_source(UnityEngine.Rendering.RenderTargetIdentifier value);
                    /*0x272efa4*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_destination();
                    /*0x272efb8*/ void set_destination(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x272f0a4*/ void Setup(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.Universal.RenderTargetHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x272f0d4*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272f228*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272f8ec*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class CopyDepthPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Rendering.Universal.RenderTargetHandle <source>k__BackingField;
                    /*0x108*/ UnityEngine.Rendering.Universal.RenderTargetHandle <destination>k__BackingField;
                    /*0x138*/ bool <AllocateRT>k__BackingField;
                    /*0x13c*/ int <MssaSamples>k__BackingField;
                    /*0x140*/ UnityEngine.Material m_CopyDepthMaterial;

                    /*0x272faa8*/ CopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material copyDepthMaterial);
                    /*0x272fa24*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_source();
                    /*0x272fa3c*/ void set_source(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x272fa54*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_destination();
                    /*0x272fa6c*/ void set_destination(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x272fa84*/ bool get_AllocateRT();
                    /*0x272fa8c*/ void set_AllocateRT(bool value);
                    /*0x272fa98*/ int get_MssaSamples();
                    /*0x272faa0*/ void set_MssaSamples(int value);
                    /*0x272fb4c*/ void Setup(UnityEngine.Rendering.Universal.RenderTargetHandle source, UnityEngine.Rendering.Universal.RenderTargetHandle destination);
                    /*0x272fba4*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x272fd3c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2730578*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class DeferredPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                    /*0x2730650*/ DeferredPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x27306ec*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescripor);
                    /*0x27307dc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27307f8*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class DepthNormalOnlyPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormals;
                    /*0xd8*/ UnityEngine.RenderTextureDescriptor <normalDescriptor>k__BackingField;
                    /*0x10c*/ UnityEngine.RenderTextureDescriptor <depthDescriptor>k__BackingField;
                    /*0x140*/ bool <allocateDepth>k__BackingField;
                    /*0x141*/ bool <allocateNormal>k__BackingField;
                    /*0x148*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> <shaderTagIds>k__BackingField;
                    /*0x150*/ UnityEngine.Rendering.Universal.RenderTargetHandle <depthHandle>k__BackingField;
                    /*0x180*/ UnityEngine.Rendering.Universal.RenderTargetHandle <normalHandle>k__BackingField;
                    /*0x1b0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0x1c8*/ int m_RendererMSAASamples;

                    static /*0x27312ac*/ DepthNormalOnlyPass();
                    /*0x2730924*/ DepthNormalOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x2730814*/ UnityEngine.RenderTextureDescriptor get_normalDescriptor();
                    /*0x2730838*/ void set_normalDescriptor(UnityEngine.RenderTextureDescriptor value);
                    /*0x273085c*/ UnityEngine.RenderTextureDescriptor get_depthDescriptor();
                    /*0x273087c*/ void set_depthDescriptor(UnityEngine.RenderTextureDescriptor value);
                    /*0x273089c*/ bool get_allocateDepth();
                    /*0x27308a4*/ void set_allocateDepth(bool value);
                    /*0x27308b0*/ bool get_allocateNormal();
                    /*0x27308b8*/ void set_allocateNormal(bool value);
                    /*0x27308c4*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> get_shaderTagIds();
                    /*0x27308cc*/ void set_shaderTagIds(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> value);
                    /*0x27308d4*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_depthHandle();
                    /*0x27308e8*/ void set_depthHandle(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x27308fc*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_normalHandle();
                    /*0x2730910*/ void set_normalHandle(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x2730a54*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle depthHandle, UnityEngine.Rendering.Universal.RenderTargetHandle normalHandle);
                    /*0x2730bf0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2730f38*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2731140*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class DepthOnlyPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.Rendering.ShaderTagId k_ShaderTagId;
                    /*0xd8*/ UnityEngine.Rendering.Universal.RenderTargetHandle <depthAttachmentHandle>k__BackingField;
                    /*0x108*/ UnityEngine.RenderTextureDescriptor <descriptor>k__BackingField;
                    /*0x13c*/ bool <allocateDepth>k__BackingField;
                    /*0x140*/ UnityEngine.Rendering.ShaderTagId <shaderTagId>k__BackingField;
                    /*0x144*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;

                    static /*0x2731c08*/ DepthOnlyPass();
                    /*0x27314e8*/ DepthOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x2731454*/ UnityEngine.Rendering.Universal.RenderTargetHandle get_depthAttachmentHandle();
                    /*0x273146c*/ void set_depthAttachmentHandle(UnityEngine.Rendering.Universal.RenderTargetHandle value);
                    /*0x2731484*/ UnityEngine.RenderTextureDescriptor get_descriptor();
                    /*0x27314a4*/ void set_descriptor(UnityEngine.RenderTextureDescriptor value);
                    /*0x27314c4*/ bool get_allocateDepth();
                    /*0x27314cc*/ void set_allocateDepth(bool value);
                    /*0x27314d8*/ UnityEngine.Rendering.ShaderTagId get_shaderTagId();
                    /*0x27314e0*/ void set_shaderTagId(UnityEngine.Rendering.ShaderTagId value);
                    /*0x2731648*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle depthAttachmentHandle);
                    /*0x2731714*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27318bc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2731ac4*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class DrawObjectsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_DrawObjectPassDataPropID;
                    /*0xd8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0xf0*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;
                    /*0x160*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                    /*0x168*/ string m_ProfilerTag;
                    /*0x170*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x178*/ bool m_IsOpaque;
                    /*0x179*/ bool m_UseDepthPriming;

                    static /*0x2732700*/ DrawObjectsPass();
                    /*0x2731c84*/ DrawObjectsPass(string profilerTag, UnityEngine.Rendering.ShaderTagId[] shaderTagIds, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x2731f5c*/ DrawObjectsPass(string profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x27320dc*/ DrawObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x27321e0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27322b8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.Universal.DebugHandler.DrawFunction <>9__12_0;

                        static /*0x2732768*/ <>c();
                        /*0x27327cc*/ <>c();
                        /*0x27327d4*/ void <Execute>b__12_0(UnityEngine.Rendering.ScriptableRenderContext ctx, ref UnityEngine.Rendering.Universal.RenderingData data, ref UnityEngine.Rendering.DrawingSettings ds, ref UnityEngine.Rendering.FilteringSettings fs, ref UnityEngine.Rendering.RenderStateBlock rsb);
                    }
                }

                class FinalBlitPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Rendering.RenderTargetIdentifier m_Source;
                    /*0x100*/ UnityEngine.Material m_BlitMaterial;

                    /*0x27327f4*/ FinalBlitPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material blitMaterial);
                    /*0x2732894*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle colorHandle);
                    /*0x27328e0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                }

                class GBufferPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_CameraNormalsTextureID;
                    static /*0x4*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagLit;
                    static /*0x8*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagSimpleLit;
                    static /*0xc*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUnlit;
                    static /*0x10*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUniversalGBuffer;
                    static /*0x14*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUniversalMaterialType;
                    /*0xd8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0xe0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                    /*0xe8*/ UnityEngine.Rendering.ShaderTagId[] m_ShaderTagValues;
                    /*0xf0*/ UnityEngine.Rendering.RenderStateBlock[] m_RenderStateBlocks;
                    /*0xf8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0x110*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;

                    static /*0x2733e70*/ GBufferPass();
                    /*0x2733334*/ GBufferPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x27337d0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x2733a18*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2733dac*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class MainLightShadowCasterPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_MaxCascades = 4;
                    static int k_ShadowmapBufferBits = 16;
                    /*0xd8*/ float m_CascadeBorder;
                    /*0xdc*/ float m_MaxShadowDistanceSq;
                    /*0xe0*/ int m_ShadowCasterCascadesCount;
                    /*0xe8*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_MainLightShadowmap;
                    /*0x118*/ UnityEngine.RenderTexture m_MainLightShadowmapTexture;
                    /*0x120*/ UnityEngine.Matrix4x4[] m_MainLightShadowMatrices;
                    /*0x128*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_CascadeSlices;
                    /*0x130*/ UnityEngine.Vector4[] m_CascadeSplitDistances;
                    /*0x138*/ bool m_CreateEmptyShadowmap;
                    /*0x140*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;

                    /*0x2734010*/ MainLightShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x27343a0*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27347ac*/ bool SetupForEmptyRendering(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2734990*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x2734a28*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x27351b4*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x2734844*/ void Clear();
                    /*0x2734a5c*/ void SetEmptyMainLightCascadeShadowmap(ref UnityEngine.Rendering.ScriptableRenderContext context);
                    /*0x2734c78*/ void RenderMainLightCascadeShadowmap(ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.LightData lightData, ref UnityEngine.Rendering.Universal.ShadowData shadowData);
                    /*0x273527c*/ void SetupMainLightShadowReceiverConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.VisibleLight shadowLight, bool supportsSoftShadows);

                    class MainLightShadowConstantBuffer
                    {
                        static /*0x0*/ int _WorldToShadow;
                        static /*0x4*/ int _ShadowParams;
                        static /*0x8*/ int _CascadeShadowSplitSpheres0;
                        static /*0xc*/ int _CascadeShadowSplitSpheres1;
                        static /*0x10*/ int _CascadeShadowSplitSpheres2;
                        static /*0x14*/ int _CascadeShadowSplitSpheres3;
                        static /*0x18*/ int _CascadeShadowSplitSphereRadii;
                        static /*0x1c*/ int _ShadowOffset0;
                        static /*0x20*/ int _ShadowOffset1;
                        static /*0x24*/ int _ShadowOffset2;
                        static /*0x28*/ int _ShadowOffset3;
                        static /*0x2c*/ int _ShadowmapSize;
                    }
                }

                class MotionVectorRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static string kPreviousViewProjectionMatrix = "_PrevViewProjMatrix";
                    static string kPreviousViewProjectionMatrixStero = "_PrevViewProjMStereo";
                    static string kMotionVectorTexture = "_MotionVectorTexture";
                    static UnityEngine.Experimental.Rendering.GraphicsFormat m_TargetFormat = 46;
                    static /*0x0*/ string[] s_ShaderTags;
                    /*0xd8*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_MotionVectorHandle;
                    /*0x108*/ UnityEngine.Material m_CameraMaterial;
                    /*0x110*/ UnityEngine.Material m_ObjectMaterial;
                    /*0x118*/ UnityEngine.Rendering.Universal.Internal.PreviousFrameData m_MotionData;
                    /*0x120*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;

                    static /*0x27362b8*/ MotionVectorRenderPass();
                    /*0x27357b0*/ MotionVectorRenderPass(UnityEngine.Material cameraMaterial, UnityEngine.Material objectMaterial);
                    /*0x2735828*/ void Setup(UnityEngine.Rendering.Universal.Internal.PreviousFrameData frameData);
                    /*0x2735830*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x2735988*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2735f54*/ UnityEngine.Rendering.DrawingSettings GetDrawingSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2735d38*/ void DrawCameraMotionVectors(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
                    /*0x2735df0*/ void DrawObjectMotionVectors(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Camera camera);
                    /*0x273617c*/ void FrameCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x2735cf8*/ void ExecuteCommand(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd);
                }

                class PostProcessPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static string k_RenderPostProcessingTag = "Render PostProcessing Effects";
                    static string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";
                    static int k_MaxPyramidSize = 16;
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingRenderPostProcessing;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingRenderFinalPostProcessing;
                    static /*0x10*/ int kShaderPropertyId_ViewProjM;
                    static /*0x14*/ int kShaderPropertyId_PrevViewProjM;
                    static /*0x18*/ int kShaderPropertyId_ViewProjMStereo;
                    static /*0x1c*/ int kShaderPropertyId_PrevViewProjMStereo;
                    /*0xd8*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                    /*0x110*/ UnityEngine.Rendering.RenderTargetIdentifier m_Source;
                    /*0x138*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_Destination;
                    /*0x168*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_Depth;
                    /*0x198*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_InternalLut;
                    /*0x1c8*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass.MaterialLibrary m_Materials;
                    /*0x1d0*/ UnityEngine.Rendering.Universal.PostProcessData m_Data;
                    /*0x1d8*/ UnityEngine.Rendering.Universal.DepthOfField m_DepthOfField;
                    /*0x1e0*/ UnityEngine.Rendering.Universal.MotionBlur m_MotionBlur;
                    /*0x1e8*/ UnityEngine.Rendering.Universal.PaniniProjection m_PaniniProjection;
                    /*0x1f0*/ UnityEngine.Rendering.Universal.Bloom m_Bloom;
                    /*0x1f8*/ UnityEngine.Rendering.Universal.LensDistortion m_LensDistortion;
                    /*0x200*/ UnityEngine.Rendering.Universal.ChromaticAberration m_ChromaticAberration;
                    /*0x208*/ UnityEngine.Rendering.Universal.Vignette m_Vignette;
                    /*0x210*/ UnityEngine.Rendering.Universal.ColorLookup m_ColorLookup;
                    /*0x218*/ UnityEngine.Rendering.Universal.ColorAdjustments m_ColorAdjustments;
                    /*0x220*/ UnityEngine.Rendering.Universal.Tonemapping m_Tonemapping;
                    /*0x228*/ UnityEngine.Rendering.Universal.FilmGrain m_FilmGrain;
                    /*0x230*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_DefaultHDRFormat;
                    /*0x234*/ bool m_UseRGBM;
                    /*0x238*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_SMAAEdgeFormat;
                    /*0x23c*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_GaussianCoCFormat;
                    /*0x240*/ bool m_ResetHistory;
                    /*0x244*/ int m_DitheringTextureIndex;
                    /*0x248*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT2;
                    /*0x250*/ UnityEngine.Vector4[] m_BokehKernel;
                    /*0x258*/ int m_BokehHash;
                    /*0x25c*/ float m_BokehMaxRadius;
                    /*0x260*/ float m_BokehRCPAspect;
                    /*0x264*/ bool m_IsFinalPass;
                    /*0x265*/ bool m_HasFinalPass;
                    /*0x266*/ bool m_EnableSRGBConversionIfNeeded;
                    /*0x267*/ bool m_UseDrawProcedural;
                    /*0x268*/ bool m_UseFastSRGBLinearConversion;
                    /*0x269*/ bool m_ResolveToScreen;
                    /*0x26a*/ bool m_UseSwapBuffer;
                    /*0x270*/ UnityEngine.Material m_BlitMaterial;

                    static /*0x273ea18*/ PostProcessPass();
                    static /*0x273e4b8*/ float GetMaxBokehRadiusInPixels(float viewportHeight);
                    static /*0x273e4d0*/ float GetLensFlareLightAttenuation(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x2736378*/ PostProcessPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Material blitMaterial);
                    /*0x27366e8*/ void Cleanup();
                    /*0x2736704*/ void Setup(ref UnityEngine.RenderTextureDescriptor baseDescriptor, ref UnityEngine.Rendering.Universal.RenderTargetHandle source, bool resolveToScreen, ref UnityEngine.Rendering.Universal.RenderTargetHandle depth, ref UnityEngine.Rendering.Universal.RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion);
                    /*0x2736860*/ void Setup(ref UnityEngine.RenderTextureDescriptor baseDescriptor, ref UnityEngine.Rendering.Universal.RenderTargetHandle source, UnityEngine.Rendering.Universal.RenderTargetHandle destination, ref UnityEngine.Rendering.Universal.RenderTargetHandle depth, ref UnityEngine.Rendering.Universal.RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion);
                    /*0x2736968*/ void SetupFinalPass(ref UnityEngine.Rendering.Universal.RenderTargetHandle source, bool useSwapBuffer);
                    /*0x2736a28*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2736c10*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x2736cf0*/ void ResetHistory();
                    /*0x2736cfc*/ bool CanRunOnTile();
                    /*0x2736d04*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x2736b74*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor();
                    /*0x2739e20*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int depthBufferBits);
                    /*0x2739eb8*/ bool RequireSRGBConversionBlitToBackBuffer(UnityEngine.Rendering.Universal.CameraData cameraData);
                    /*0x2739eec*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex);
                    /*0x273a104*/ void DrawFullscreenMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int passIndex);
                    /*0x2737ed0*/ void Render(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x273cfb4*/ UnityEngine.Rendering.BuiltinRenderTextureType BlitDstDiscardContent(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rt);
                    /*0x273a698*/ void DoSubpixelMorphologicalAntialiasing(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination);
                    /*0x273aeec*/ void DoDepthOfField(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rect pixelRect);
                    /*0x273d040*/ void DoGaussianDepthOfField(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rect pixelRect);
                    /*0x273e270*/ void PrepareBokehKernel(float maxRadius, float rcpAspect);
                    /*0x273dad0*/ void DoBokehDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rect pixelRect);
                    /*0x273b450*/ void DoLensFlareDatadriven(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                    /*0x273e6d8*/ void UpdateMotionBlurMatrices(ref UnityEngine.Material material, UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPass xr);
                    /*0x273b018*/ void DoMotionBlur(UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination);
                    /*0x273b1f4*/ void DoPaniniProjection(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination);
                    /*0x273e968*/ UnityEngine.Vector2 CalcViewExtents(UnityEngine.Camera camera);
                    /*0x273e9c4*/ UnityEngine.Vector2 CalcCropExtents(UnityEngine.Camera camera, float d);
                    /*0x273b8b0*/ void SetupBloom(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Material uberMaterial);
                    /*0x273c5d4*/ void SetupLensDistortion(UnityEngine.Material material, bool isSceneView);
                    /*0x273c8a8*/ void SetupChromaticAberration(UnityEngine.Material material);
                    /*0x273c998*/ void SetupVignette(UnityEngine.Material material);
                    /*0x273cb34*/ void SetupColorGrading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Material material);
                    /*0x273ce78*/ void SetupGrain(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Material material);
                    /*0x273cf20*/ void SetupDithering(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Material material);
                    /*0x2737114*/ void RenderFinalPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x273a2c8*/ UnityEngine.Rendering.RenderTargetIdentifier <Render>g__GetSource|57_0(ref UnityEngine.Rendering.Universal.Internal.PostProcessPass.<> );
                    /*0x273a2dc*/ UnityEngine.Rendering.RenderTargetIdentifier <Render>g__GetDestination|57_1(ref UnityEngine.Rendering.Universal.Internal.PostProcessPass.<> );
                    /*0x273a53c*/ void <Render>g__Swap|57_2(ref UnityEngine.Rendering.Universal.ScriptableRenderer r, ref UnityEngine.Rendering.Universal.Internal.PostProcessPass.<> );

                    class MaterialLibrary
                    {
                        /*0x10*/ UnityEngine.Material stopNaN;
                        /*0x18*/ UnityEngine.Material subpixelMorphologicalAntialiasing;
                        /*0x20*/ UnityEngine.Material gaussianDepthOfField;
                        /*0x28*/ UnityEngine.Material bokehDepthOfField;
                        /*0x30*/ UnityEngine.Material cameraMotionBlur;
                        /*0x38*/ UnityEngine.Material paniniProjection;
                        /*0x40*/ UnityEngine.Material bloom;
                        /*0x48*/ UnityEngine.Material scalingSetup;
                        /*0x50*/ UnityEngine.Material easu;
                        /*0x58*/ UnityEngine.Material uber;
                        /*0x60*/ UnityEngine.Material finalPass;
                        /*0x68*/ UnityEngine.Material lensFlareDataDriven;

                        /*0x273eba4*/ MaterialLibrary(UnityEngine.Rendering.Universal.PostProcessData data);
                        /*0x273ecf0*/ UnityEngine.Material Load(UnityEngine.Shader shader);
                        /*0x273eecc*/ void Cleanup();
                    }

                    class ShaderConstants
                    {
                        static /*0x0*/ int _TempTarget;
                        static /*0x4*/ int _TempTarget2;
                        static /*0x8*/ int _StencilRef;
                        static /*0xc*/ int _StencilMask;
                        static /*0x10*/ int _FullCoCTexture;
                        static /*0x14*/ int _HalfCoCTexture;
                        static /*0x18*/ int _DofTexture;
                        static /*0x1c*/ int _CoCParams;
                        static /*0x20*/ int _BokehKernel;
                        static /*0x24*/ int _BokehConstants;
                        static /*0x28*/ int _PongTexture;
                        static /*0x2c*/ int _PingTexture;
                        static /*0x30*/ int _Metrics;
                        static /*0x34*/ int _AreaTexture;
                        static /*0x38*/ int _SearchTexture;
                        static /*0x3c*/ int _EdgeTexture;
                        static /*0x40*/ int _BlendTexture;
                        static /*0x44*/ int _ColorTexture;
                        static /*0x48*/ int _Params;
                        static /*0x4c*/ int _SourceTexLowMip;
                        static /*0x50*/ int _Bloom_Params;
                        static /*0x54*/ int _Bloom_RGBM;
                        static /*0x58*/ int _Bloom_Texture;
                        static /*0x5c*/ int _LensDirt_Texture;
                        static /*0x60*/ int _LensDirt_Params;
                        static /*0x64*/ int _LensDirt_Intensity;
                        static /*0x68*/ int _Distortion_Params1;
                        static /*0x6c*/ int _Distortion_Params2;
                        static /*0x70*/ int _Chroma_Params;
                        static /*0x74*/ int _Vignette_Params1;
                        static /*0x78*/ int _Vignette_Params2;
                        static /*0x7c*/ int _Lut_Params;
                        static /*0x80*/ int _UserLut_Params;
                        static /*0x84*/ int _InternalLut;
                        static /*0x88*/ int _UserLut;
                        static /*0x8c*/ int _DownSampleScaleFactor;
                        static /*0x90*/ int _FlareOcclusionTex;
                        static /*0x94*/ int _FlareOcclusionIndex;
                        static /*0x98*/ int _FlareTex;
                        static /*0x9c*/ int _FlareColorValue;
                        static /*0xa0*/ int _FlareData0;
                        static /*0xa4*/ int _FlareData1;
                        static /*0xa8*/ int _FlareData2;
                        static /*0xac*/ int _FlareData3;
                        static /*0xb0*/ int _FlareData4;
                        static /*0xb4*/ int _FlareData5;
                        static /*0xb8*/ int _FullscreenProjMat;
                        static /*0xbc*/ int _ScalingSetupTexture;
                        static /*0xc0*/ int _UpscaledTexture;
                        static /*0xc8*/ int[] _BloomMipUp;
                        static /*0xd0*/ int[] _BloomMipDown;

                        static /*0x273efa0*/ ShaderConstants();
                    }

                    struct <>c__DisplayClass57_0
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier source;
                        /*0x38*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass <>4__this;
                        /*0x40*/ UnityEngine.Rendering.RenderTargetIdentifier destination;
                        /*0x68*/ UnityEngine.Rendering.CommandBuffer cmd;
                        /*0x70*/ bool tempTargetUsed;
                        /*0x71*/ bool tempTarget2Used;
                        /*0x74*/ int amountOfPassesRemaining;
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.PostProcessPass.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__66_0;

                        static /*0x273f868*/ <>c();
                        /*0x273f8cc*/ <>c();
                        /*0x273f8d4*/ float <DoLensFlareDatadriven>b__66_0(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    }
                }

                class ScreenSpaceShadowResolvePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Material m_ScreenSpaceShadowsMaterial;
                    /*0xe0*/ UnityEngine.Rendering.Universal.RenderTargetHandle m_ScreenSpaceShadowmap;
                    /*0x110*/ UnityEngine.RenderTextureDescriptor m_RenderTextureDescriptor;

                    /*0x273f964*/ ScreenSpaceShadowResolvePass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material screenspaceShadowsMaterial);
                    /*0x273fa24*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor);
                    /*0x273fadc*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x273fbbc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x274008c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class TileDepthRangePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xd8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                    /*0xe0*/ int m_PassIndex;

                    /*0x27400f8*/ TileDepthRangePass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights, int passIndex);
                    /*0x27401a4*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x2740328*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x274035c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class PreviousFrameData
                {
                    /*0x10*/ bool m_IsFirstFrame;
                    /*0x14*/ int m_LastFrameActive;
                    /*0x18*/ UnityEngine.Matrix4x4 m_viewProjectionMatrix;
                    /*0x58*/ UnityEngine.Matrix4x4 m_PreviousViewProjectionMatrix;
                    /*0x98*/ UnityEngine.Matrix4x4[] m_ViewProjectionMatrixStereo;
                    /*0xa0*/ UnityEngine.Matrix4x4[] m_PreviousViewProjectionMatrixStereo;

                    /*0x2740454*/ PreviousFrameData();
                    /*0x2740530*/ bool get_isFirstFrame();
                    /*0x2740538*/ void set_isFirstFrame(bool value);
                    /*0x2740544*/ int get_lastFrameActive();
                    /*0x274054c*/ void set_lastFrameActive(int value);
                    /*0x2740554*/ UnityEngine.Matrix4x4 get_viewProjectionMatrix();
                    /*0x2740570*/ void set_viewProjectionMatrix(UnityEngine.Matrix4x4 value);
                    /*0x274058c*/ UnityEngine.Matrix4x4 get_previousViewProjectionMatrix();
                    /*0x27405a8*/ void set_previousViewProjectionMatrix(UnityEngine.Matrix4x4 value);
                    /*0x27405c4*/ UnityEngine.Matrix4x4[] get_previousViewProjectionMatrixStereo();
                    /*0x27405cc*/ void set_previousViewProjectionMatrixStereo(UnityEngine.Matrix4x4[] value);
                    /*0x27405d4*/ UnityEngine.Matrix4x4[] get_viewProjectionMatrixStereo();
                    /*0x27405dc*/ void set_viewProjectionMatrixStereo(UnityEngine.Matrix4x4[] value);
                }

                class RenderTargetBufferSystem
                {
                    static /*0x0*/ bool m_AisBackBuffer;
                    static /*0x4*/ UnityEngine.RenderTextureDescriptor m_Desc;
                    /*0x10*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer m_A;
                    /*0x48*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer m_B;
                    /*0x80*/ UnityEngine.FilterMode m_FilterMode;
                    /*0x84*/ bool m_AllowMSAA;
                    /*0x85*/ bool m_RTisAllocated;

                    static /*0x2740edc*/ RenderTargetBufferSystem();
                    /*0x2740704*/ RenderTargetBufferSystem(string name);
                    /*0x27405e4*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_backBuffer();
                    /*0x2740674*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_frontBuffer();
                    /*0x27407f4*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetBackBuffer();
                    /*0x2740828*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x27409b4*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x2740c5c*/ void Swap();
                    /*0x274087c*/ void Initialize(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x2740cbc*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x2740d4c*/ void SetCameraSettings(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filterMode);
                    /*0x2740e14*/ void SetCameraSettings(UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filterMode);
                    /*0x2740ebc*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetBufferA();
                    /*0x2740ed0*/ void EnableMSAA(bool enable);

                    struct SwapBuffer
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.RenderTargetHandle rt;
                        /*0x40*/ int name;
                        /*0x44*/ int msaa;
                    }
                }

                enum StencilUsage
                {
                    UserMask = 15,
                    StencilLight = 16,
                    MaterialMask = 96,
                    MaterialUnlit = 0,
                    MaterialLit = 32,
                    MaterialSimpleLit = 64,
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6;
    static /*0x10*/ <PrivateImplementationDetails> 18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34;
    static /*0x28*/ <PrivateImplementationDetails> 6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64;
    static /*0x3e8*/ <PrivateImplementationDetails> 8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80;
    static /*0x3f4*/ <PrivateImplementationDetails> 9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD;
    static /*0x400*/ <PrivateImplementationDetails> E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01;
    static /*0x7c0*/ int F896C3A5F9841B6E1F0A22BD35A6A1BC5EFB28AAA23B66301EC8098CE57CF99A;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=960
    {
    }
}
