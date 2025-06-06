class <Module>
{
}

namespace UnityEngine
{
    namespace Yoga
    {
        enum YogaPositionType
        {
            Relative = 0,
            Absolute = 1,
        }

        class YogaNode : System.Collections.Generic.IEnumerable<UnityEngine.Yoga.YogaNode>, System.Collections.IEnumerable
        {
            /*0x10*/ nint _ygNode;
            /*0x18*/ UnityEngine.Yoga.YogaConfig _config;
            /*0x20*/ System.WeakReference _parent;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Yoga.YogaNode> _children;
            /*0x30*/ UnityEngine.Yoga.MeasureFunction _measureFunction;
            /*0x38*/ UnityEngine.Yoga.BaselineFunction _baselineFunction;
            /*0x40*/ object _data;

            static /*0x2abbb90*/ UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
            static /*0x2abbc0c*/ float BaselineInternal(UnityEngine.Yoga.YogaNode node, float width, float height);
            /*0x2ab9d24*/ YogaNode(UnityEngine.Yoga.YogaConfig config);
            /*0x2ab9318*/ void set_Left(UnityEngine.Yoga.YogaValue value);
            /*0x2ab93a8*/ void set_Top(UnityEngine.Yoga.YogaValue value);
            /*0x2ab93b4*/ void set_Right(UnityEngine.Yoga.YogaValue value);
            /*0x2ab93c0*/ void set_Bottom(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9324*/ void SetStylePosition(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value);
            /*0x2ab9484*/ void set_MarginLeft(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9558*/ void set_MarginTop(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9564*/ void set_MarginRight(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9570*/ void set_MarginBottom(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9490*/ void SetStyleMargin(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value);
            /*0x2ab9668*/ void set_PaddingLeft(UnityEngine.Yoga.YogaValue value);
            /*0x2ab96f8*/ void set_PaddingTop(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9704*/ void set_PaddingRight(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9710*/ void set_PaddingBottom(UnityEngine.Yoga.YogaValue value);
            /*0x2ab9674*/ void SetStylePadding(UnityEngine.Yoga.YogaEdge edge, UnityEngine.Yoga.YogaValue value);
            /*0x2ab97c4*/ void set_BorderLeftWidth(float value);
            /*0x2ab9868*/ void set_BorderTopWidth(float value);
            /*0x2ab98b8*/ void set_BorderRightWidth(float value);
            /*0x2ab9908*/ void set_BorderBottomWidth(float value);
            /*0x2ab9958*/ float get_LayoutMarginLeft();
            /*0x2ab99dc*/ float get_LayoutMarginTop();
            /*0x2ab9a1c*/ float get_LayoutMarginRight();
            /*0x2ab9a5c*/ float get_LayoutMarginBottom();
            /*0x2ab9a9c*/ float get_LayoutPaddingLeft();
            /*0x2ab9b20*/ float get_LayoutPaddingTop();
            /*0x2ab9b60*/ float get_LayoutPaddingRight();
            /*0x2ab9ba0*/ float get_LayoutPaddingBottom();
            /*0x2ab9be0*/ float get_LayoutBorderLeft();
            /*0x2ab9c64*/ float get_LayoutBorderTop();
            /*0x2ab9ca4*/ float get_LayoutBorderRight();
            /*0x2ab9ce4*/ float get_LayoutBorderBottom();
            /*0x2ab9e98*/ void Finalize();
            /*0x2ab9fbc*/ void set_Config(UnityEngine.Yoga.YogaConfig value);
            /*0x2aba0b0*/ bool get_IsDirty();
            /*0x2aba128*/ void MarkDirty();
            /*0x2aba1a0*/ bool get_HasNewLayout();
            /*0x2aba218*/ bool get_IsMeasureDefined();
            /*0x2aba228*/ bool get_IsBaselineDefined();
            /*0x2aba238*/ void CopyStyle(UnityEngine.Yoga.YogaNode srcNode);
            /*0x2aba2c8*/ void set_FlexDirection(UnityEngine.Yoga.YogaFlexDirection value);
            /*0x2aba350*/ void set_JustifyContent(UnityEngine.Yoga.YogaJustify value);
            /*0x2aba3d8*/ void set_Display(UnityEngine.Yoga.YogaDisplay value);
            /*0x2aba460*/ void set_AlignItems(UnityEngine.Yoga.YogaAlign value);
            /*0x2aba4e8*/ void set_AlignSelf(UnityEngine.Yoga.YogaAlign value);
            /*0x2aba570*/ void set_AlignContent(UnityEngine.Yoga.YogaAlign value);
            /*0x2aba5f8*/ void set_PositionType(UnityEngine.Yoga.YogaPositionType value);
            /*0x2aba680*/ void set_Wrap(UnityEngine.Yoga.YogaWrap value);
            /*0x2aba708*/ void set_Flex(float value);
            /*0x2aba7a0*/ void set_FlexGrow(float value);
            /*0x2aba838*/ void set_FlexShrink(float value);
            /*0x2aba8d0*/ void set_FlexBasis(UnityEngine.Yoga.YogaValue value);
            /*0x2abaa60*/ void set_Width(UnityEngine.Yoga.YogaValue value);
            /*0x2ababf0*/ void set_Height(UnityEngine.Yoga.YogaValue value);
            /*0x2abad80*/ void set_MaxWidth(UnityEngine.Yoga.YogaValue value);
            /*0x2abae94*/ void set_MaxHeight(UnityEngine.Yoga.YogaValue value);
            /*0x2abafa8*/ void set_MinWidth(UnityEngine.Yoga.YogaValue value);
            /*0x2abb0bc*/ void set_MinHeight(UnityEngine.Yoga.YogaValue value);
            /*0x2abb1d0*/ float get_LayoutX();
            /*0x2abb248*/ float get_LayoutY();
            /*0x2abb2c0*/ float get_LayoutRight();
            /*0x2abb338*/ float get_LayoutBottom();
            /*0x2abb3b0*/ float get_LayoutWidth();
            /*0x2abb428*/ float get_LayoutHeight();
            /*0x2abb4a0*/ void set_Overflow(UnityEngine.Yoga.YogaOverflow value);
            /*0x2abb528*/ int get_Count();
            /*0x2abb574*/ void MarkLayoutSeen();
            /*0x2abb5f8*/ void Insert(int index, UnityEngine.Yoga.YogaNode node);
            /*0x2abb770*/ void RemoveAt(int index);
            /*0x2abb87c*/ void Clear();
            /*0x2abb8e0*/ void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction measureFunction);
            /*0x2abba74*/ void CalculateLayout(float width, float height);
            /*0x2abbc80*/ System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator();
            /*0x2abbdac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        enum YogaDirection
        {
            Inherit = 0,
            LTR = 1,
            RTL = 2,
        }

        enum YogaAlign
        {
            Auto = 0,
            FlexStart = 1,
            Center = 2,
            FlexEnd = 3,
            Stretch = 4,
            Baseline = 5,
            SpaceBetween = 6,
            SpaceAround = 7,
        }

        enum YogaFlexDirection
        {
            Column = 0,
            ColumnReverse = 1,
            Row = 2,
            RowReverse = 3,
        }

        class Native
        {
            static /*0x2ab9e5c*/ nint YGNodeNewWithConfig(nint config);
            static /*0x2ab9f30*/ void YGNodeFree(nint ygNode);
            static /*0x2abbed8*/ void YGNodeFreeInternal(nint ygNode);
            static /*0x2abb9b8*/ void YGSetManagedObject(nint ygNode, UnityEngine.Yoga.YogaNode node);
            static /*0x2aba06c*/ void YGNodeSetConfig(nint ygNode, nint config);
            static /*0x2abbf14*/ nint YGConfigGetDefault();
            static /*0x2abbf3c*/ nint YGConfigNew();
            static /*0x2abbf64*/ void YGConfigFree(nint config);
            static /*0x2abbff0*/ void YGConfigFreeInternal(nint config);
            static /*0x2abc02c*/ void YGConfigSetUseWebDefaults(nint config, bool useWebDefaults);
            static /*0x2abc070*/ bool YGConfigGetUseWebDefaults(nint config);
            static /*0x2abc0ac*/ void YGConfigSetPointScaleFactor(nint config, float pixelsInPoint);
            static /*0x2abb71c*/ void YGNodeInsertChild(nint node, nint child, uint index);
            static /*0x2abb838*/ void YGNodeRemoveChild(nint node, nint child);
            static /*0x2abbb34*/ void YGNodeCalculateLayout(nint node, float availableWidth, float availableHeight, UnityEngine.Yoga.YogaDirection parentDirection);
            static /*0x2aba164*/ void YGNodeMarkDirty(nint node);
            static /*0x2aba0ec*/ bool YGNodeIsDirty(nint node);
            static /*0x2aba284*/ void YGNodeCopyStyle(nint dstNode, nint srcNode);
            static /*0x2abba38*/ void YGNodeSetMeasureFunc(nint node);
            static /*0x2abb9fc*/ void YGNodeRemoveMeasureFunc(nint node);
            static /*0x2abc0f8*/ void YGNodeMeasureInvoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode, nint returnValueAddress);
            static /*0x2abc15c*/ void YGNodeBaselineInvoke(UnityEngine.Yoga.YogaNode node, float width, float height, nint returnValueAddress);
            static /*0x2abb5b4*/ void YGNodeSetHasNewLayout(nint node, bool hasNewLayout);
            static /*0x2aba1dc*/ bool YGNodeGetHasNewLayout(nint node);
            static /*0x2abbaf8*/ UnityEngine.Yoga.YogaDirection YGNodeStyleGetDirection(nint node);
            static /*0x2aba30c*/ void YGNodeStyleSetFlexDirection(nint node, UnityEngine.Yoga.YogaFlexDirection flexDirection);
            static /*0x2aba394*/ void YGNodeStyleSetJustifyContent(nint node, UnityEngine.Yoga.YogaJustify justifyContent);
            static /*0x2aba5b4*/ void YGNodeStyleSetAlignContent(nint node, UnityEngine.Yoga.YogaAlign alignContent);
            static /*0x2aba4a4*/ void YGNodeStyleSetAlignItems(nint node, UnityEngine.Yoga.YogaAlign alignItems);
            static /*0x2aba52c*/ void YGNodeStyleSetAlignSelf(nint node, UnityEngine.Yoga.YogaAlign alignSelf);
            static /*0x2aba63c*/ void YGNodeStyleSetPositionType(nint node, UnityEngine.Yoga.YogaPositionType positionType);
            static /*0x2aba6c4*/ void YGNodeStyleSetFlexWrap(nint node, UnityEngine.Yoga.YogaWrap flexWrap);
            static /*0x2abb4e4*/ void YGNodeStyleSetOverflow(nint node, UnityEngine.Yoga.YogaOverflow flexWrap);
            static /*0x2aba41c*/ void YGNodeStyleSetDisplay(nint node, UnityEngine.Yoga.YogaDisplay display);
            static /*0x2aba754*/ void YGNodeStyleSetFlex(nint node, float flex);
            static /*0x2aba7ec*/ void YGNodeStyleSetFlexGrow(nint node, float flexGrow);
            static /*0x2aba884*/ void YGNodeStyleSetFlexShrink(nint node, float flexShrink);
            static /*0x2abaa14*/ void YGNodeStyleSetFlexBasis(nint node, float flexBasis);
            static /*0x2aba98c*/ void YGNodeStyleSetFlexBasisPercent(nint node, float flexBasis);
            static /*0x2aba9d8*/ void YGNodeStyleSetFlexBasisAuto(nint node);
            static /*0x2ababa4*/ void YGNodeStyleSetWidth(nint node, float width);
            static /*0x2abab1c*/ void YGNodeStyleSetWidthPercent(nint node, float width);
            static /*0x2abab68*/ void YGNodeStyleSetWidthAuto(nint node);
            static /*0x2abad34*/ void YGNodeStyleSetHeight(nint node, float height);
            static /*0x2abacac*/ void YGNodeStyleSetHeightPercent(nint node, float height);
            static /*0x2abacf8*/ void YGNodeStyleSetHeightAuto(nint node);
            static /*0x2abb070*/ void YGNodeStyleSetMinWidth(nint node, float minWidth);
            static /*0x2abb024*/ void YGNodeStyleSetMinWidthPercent(nint node, float minWidth);
            static /*0x2abb184*/ void YGNodeStyleSetMinHeight(nint node, float minHeight);
            static /*0x2abb138*/ void YGNodeStyleSetMinHeightPercent(nint node, float minHeight);
            static /*0x2abae48*/ void YGNodeStyleSetMaxWidth(nint node, float maxWidth);
            static /*0x2abadfc*/ void YGNodeStyleSetMaxWidthPercent(nint node, float maxWidth);
            static /*0x2abaf5c*/ void YGNodeStyleSetMaxHeight(nint node, float maxHeight);
            static /*0x2abaf10*/ void YGNodeStyleSetMaxHeightPercent(nint node, float maxHeight);
            static /*0x2ab9430*/ void YGNodeStyleSetPosition(nint node, UnityEngine.Yoga.YogaEdge edge, float position);
            static /*0x2ab93dc*/ void YGNodeStyleSetPositionPercent(nint node, UnityEngine.Yoga.YogaEdge edge, float position);
            static /*0x2ab9614*/ void YGNodeStyleSetMargin(nint node, UnityEngine.Yoga.YogaEdge edge, float margin);
            static /*0x2ab957c*/ void YGNodeStyleSetMarginPercent(nint node, UnityEngine.Yoga.YogaEdge edge, float margin);
            static /*0x2ab95d0*/ void YGNodeStyleSetMarginAuto(nint node, UnityEngine.Yoga.YogaEdge edge);
            static /*0x2ab9770*/ void YGNodeStyleSetPadding(nint node, UnityEngine.Yoga.YogaEdge edge, float padding);
            static /*0x2ab971c*/ void YGNodeStyleSetPaddingPercent(nint node, UnityEngine.Yoga.YogaEdge edge, float padding);
            static /*0x2ab9814*/ void YGNodeStyleSetBorder(nint node, UnityEngine.Yoga.YogaEdge edge, float border);
            static /*0x2abb20c*/ float YGNodeLayoutGetLeft(nint node);
            static /*0x2abb284*/ float YGNodeLayoutGetTop(nint node);
            static /*0x2abb2fc*/ float YGNodeLayoutGetRight(nint node);
            static /*0x2abb374*/ float YGNodeLayoutGetBottom(nint node);
            static /*0x2abb3ec*/ float YGNodeLayoutGetWidth(nint node);
            static /*0x2abb464*/ float YGNodeLayoutGetHeight(nint node);
            static /*0x2ab9998*/ float YGNodeLayoutGetMargin(nint node, UnityEngine.Yoga.YogaEdge edge);
            static /*0x2ab9adc*/ float YGNodeLayoutGetPadding(nint node, UnityEngine.Yoga.YogaEdge edge);
            static /*0x2ab9c20*/ float YGNodeLayoutGetBorder(nint node, UnityEngine.Yoga.YogaEdge edge);
        }

        class YogaConstants
        {
            static /*0x2abc1a8*/ bool IsUndefined(float value);
        }

        enum YogaWrap
        {
            NoWrap = 0,
            Wrap = 1,
            WrapReverse = 2,
        }

        class MeasureOutput
        {
            static /*0x2abc20c*/ UnityEngine.Yoga.YogaSize Make(float width, float height);
        }

        class YogaConfig
        {
            static /*0x0*/ UnityEngine.Yoga.YogaConfig Default;
            /*0x10*/ nint _ygConfig;
            /*0x18*/ UnityEngine.Yoga.Logger _logger;

            static /*0x2abc4ec*/ YogaConfig();
            /*0x2abc210*/ YogaConfig(nint ygConfig);
            /*0x2abc2d4*/ YogaConfig();
            /*0x2abc318*/ void Finalize();
            /*0x2ab9e54*/ nint get_Handle();
            /*0x2abc420*/ bool get_UseWebDefaults();
            /*0x2abc45c*/ void set_UseWebDefaults(bool value);
            /*0x2abc4a0*/ void set_PointScaleFactor(float value);
        }

        enum YogaUnit
        {
            Undefined = 0,
            Point = 1,
            Percent = 2,
            Auto = 3,
        }

        struct YogaValue
        {
            /*0x10*/ float value;
            /*0x14*/ UnityEngine.Yoga.YogaUnit unit;

            static /*0x2abc57c*/ UnityEngine.Yoga.YogaValue Point(float value);
            static /*0x2abc6b4*/ UnityEngine.Yoga.YogaValue Auto();
            static /*0x2abc6c0*/ UnityEngine.Yoga.YogaValue Percent(float value);
            static /*0x2abc6e8*/ UnityEngine.Yoga.YogaValue op_Implicit(float pointValue);
            /*0x2ab93cc*/ UnityEngine.Yoga.YogaUnit get_Unit();
            /*0x2ab93d4*/ float get_Value();
            /*0x2abc5a0*/ bool Equals(UnityEngine.Yoga.YogaValue other);
            /*0x2abc600*/ bool Equals(object obj);
            /*0x2abc678*/ int GetHashCode();
        }

        enum YogaEdge
        {
            Left = 0,
            Top = 1,
            Right = 2,
            Bottom = 3,
            Start = 4,
            End = 5,
            Horizontal = 6,
            Vertical = 7,
            All = 8,
        }

        struct YogaSize
        {
            /*0x10*/ float width;
            /*0x14*/ float height;
        }

        class MeasureFunction : System.MulticastDelegate
        {
            /*0x2abc714*/ MeasureFunction(object object, nint method);
            /*0x2abc844*/ UnityEngine.Yoga.YogaSize Invoke(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
        }

        enum YogaLogLevel
        {
            Error = 0,
            Warn = 1,
            Info = 2,
            Debug = 3,
            Verbose = 4,
            Fatal = 5,
        }

        enum YogaDisplay
        {
            Flex = 0,
            None = 1,
        }

        enum YogaMeasureMode
        {
            Undefined = 0,
            Exactly = 1,
            AtMost = 2,
        }

        enum YogaJustify
        {
            FlexStart = 0,
            Center = 1,
            FlexEnd = 2,
            SpaceBetween = 3,
            SpaceAround = 4,
        }

        class BaselineFunction : System.MulticastDelegate
        {
            /*0x2abc858*/ BaselineFunction(object object, nint method);
            /*0x2abc988*/ float Invoke(UnityEngine.Yoga.YogaNode node, float width, float height);
        }

        enum YogaOverflow
        {
            Visible = 0,
            Hidden = 1,
            Scroll = 2,
        }

        class Logger : System.MulticastDelegate
        {
            /*0x2abc99c*/ Logger(object object, nint method);
            /*0x2abcacc*/ void Invoke(UnityEngine.Yoga.YogaConfig config, UnityEngine.Yoga.YogaNode node, UnityEngine.Yoga.YogaLogLevel level, string message);
        }
    }

    namespace UIElements
    {
        class UIElementsRuntimeUtilityNative
        {
            static /*0x0*/ System.Action RepaintOverlayPanelsCallback;
            static /*0x8*/ System.Action UpdateRuntimePanelsCallback;

            static /*0x2abcae0*/ void RepaintOverlayPanels();
            static /*0x2abcb44*/ void UpdateRuntimePanels();
            static /*0x2abcba8*/ void RegisterPlayerloopCallback();
            static /*0x2abcbd0*/ void UnregisterPlayerloopCallback();
            static /*0x2abcbf8*/ void VisualElementCreation();
        }

        struct TextNativeSettings
        {
            /*0x10*/ string text;
            /*0x18*/ UnityEngine.Font font;
            /*0x20*/ int size;
            /*0x24*/ float scaling;
            /*0x28*/ UnityEngine.FontStyle style;
            /*0x2c*/ UnityEngine.Color color;
            /*0x3c*/ UnityEngine.TextAnchor anchor;
            /*0x40*/ bool wordWrap;
            /*0x44*/ float wordWrapWidth;
            /*0x48*/ bool richText;
        }

        struct TextVertex
        {
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Color32 color;
            /*0x20*/ UnityEngine.Vector2 uv0;
        }

        class TextNative
        {
            static /*0x2abcc20*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, int cursorIndex);
            static /*0x2abcdcc*/ float ComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abcf10*/ float ComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abd054*/ Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abd2a0*/ UnityEngine.Vector2 GetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect screenRect);
            static /*0x2abd42c*/ float ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, float pixelsPerPoint);
            static /*0x2abced4*/ float DoComputeTextWidth(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abd018*/ float DoComputeTextHeight(UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abcd64*/ UnityEngine.Vector2 DoGetCursorPosition(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect, int cursorPosition);
            static /*0x2abd244*/ void GetVertices(UnityEngine.UIElements.TextNativeSettings settings, nint buffer, int vertexSize, ref int vertexCount);
            static /*0x2abd3d0*/ UnityEngine.Vector2 DoGetOffset(UnityEngine.UIElements.TextNativeSettings settings, UnityEngine.Rect rect);
            static /*0x2abd528*/ float DoComputeTextWidth_Injected(ref UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abd564*/ float DoComputeTextHeight_Injected(ref UnityEngine.UIElements.TextNativeSettings settings);
            static /*0x2abd5a0*/ void DoGetCursorPosition_Injected(ref UnityEngine.UIElements.TextNativeSettings settings, ref UnityEngine.Rect rect, int cursorPosition, ref UnityEngine.Vector2 ret);
            static /*0x2abd5fc*/ void GetVertices_Injected(ref UnityEngine.UIElements.TextNativeSettings settings, nint buffer, int vertexSize, ref int vertexCount);
            static /*0x2abd658*/ void DoGetOffset_Injected(ref UnityEngine.UIElements.TextNativeSettings settings, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 ret);
        }

        namespace UIR
        {
            struct GfxUpdateBufferRange
            {
                /*0x10*/ uint offsetFromWriteStart;
                /*0x14*/ uint size;
                /*0x18*/ nuint source;
            }

            struct DrawBufferRange
            {
                /*0x10*/ int firstIndex;
                /*0x14*/ int indexCount;
                /*0x18*/ int minIndexVal;
                /*0x1c*/ int vertsReferenced;
            }

            class Utility
            {
                static /*0x0*/ System.Action<bool> GraphicsResourcesRecreate;
                static /*0x8*/ System.Action EngineUpdate;
                static /*0x10*/ System.Action FlushPendingResources;
                static /*0x18*/ System.Action<UnityEngine.Camera> RegisterIntermediateRenderers;
                static /*0x20*/ System.Action<nint> RenderNodeAdd;
                static /*0x28*/ System.Action<nint> RenderNodeExecute;
                static /*0x30*/ System.Action<nint> RenderNodeCleanup;
                static /*0x38*/ Unity.Profiling.ProfilerMarker s_MarkerRaiseEngineUpdate;

                static /*0x2abec2c*/ Utility();
                static void SetVectorArray<T>(UnityEngine.MaterialPropertyBlock props, int name, Unity.Collections.NativeSlice<T> vector4s);
                static /*0x2abd6ac*/ void add_GraphicsResourcesRecreate(System.Action<bool> value);
                static /*0x2abd79c*/ void remove_GraphicsResourcesRecreate(System.Action<bool> value);
                static /*0x2abd88c*/ void add_EngineUpdate(System.Action value);
                static /*0x2abd968*/ void remove_EngineUpdate(System.Action value);
                static /*0x2abda44*/ void add_FlushPendingResources(System.Action value);
                static /*0x2abdb20*/ void remove_FlushPendingResources(System.Action value);
                static /*0x2abdbfc*/ void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value);
                static /*0x2abdcf0*/ void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value);
                static /*0x2abdde4*/ void add_RenderNodeExecute(System.Action<nint> value);
                static /*0x2abded8*/ void remove_RenderNodeExecute(System.Action<nint> value);
                static /*0x2abdfcc*/ void RaiseGraphicsResourcesRecreate(bool recreate);
                static /*0x2abe048*/ void RaiseEngineUpdate();
                static /*0x2abe0dc*/ void RaiseFlushPendingResources();
                static /*0x2abe150*/ void RaiseRegisterIntermediateRenderers(UnityEngine.Camera camera);
                static /*0x2abe1cc*/ void RaiseRenderNodeAdd(nint userData);
                static /*0x2abe248*/ void RaiseRenderNodeExecute(nint userData);
                static /*0x2abe2c4*/ void RaiseRenderNodeCleanup(nint userData);
                static /*0x2abe340*/ nint AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer);
                static /*0x2abe394*/ void FreeBuffer(nint buffer);
                static /*0x2abe3d0*/ void UpdateBufferRanges(nint buffer, nint ranges, int rangeCount, int writeRangeStart, int writeRangeEnd);
                static /*0x2abe43c*/ void SetVectorArray(UnityEngine.MaterialPropertyBlock props, int name, nint vector4s, int count);
                static /*0x2abe498*/ nint GetVertexDeclaration(UnityEngine.Rendering.VertexAttributeDescriptor[] vertexAttributes);
                static /*0x2abe4d4*/ void RegisterIntermediateRenderer(UnityEngine.Camera camera, UnityEngine.Material material, UnityEngine.Matrix4x4 transform, UnityEngine.Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, nint userData, int userDataSize);
                static /*0x2abe680*/ void DrawRanges(nint ib, nint* vertexStreams, int streamCount, nint ranges, int rangeCount, nint vertexDecl);
                static /*0x2abe6f4*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock props);
                static /*0x2abe730*/ void SetScissorRect(UnityEngine.RectInt scissorRect);
                static /*0x2abe7ec*/ void DisableScissor();
                static /*0x2abe814*/ nint CreateStencilState(UnityEngine.Rendering.StencilState stencilState);
                static /*0x2abe8d4*/ void SetStencilState(nint stencilState, int stencilRef);
                static /*0x2abe918*/ bool HasMappedBufferRange();
                static /*0x2abe940*/ uint InsertCPUFence();
                static /*0x2abe968*/ bool CPUFencePassed(uint fence);
                static /*0x2abe9a4*/ void WaitForCPUFencePassed(uint fence);
                static /*0x2abe9e0*/ void SyncRenderThread();
                static /*0x2abea08*/ UnityEngine.RectInt GetActiveViewport();
                static /*0x2abeac8*/ void ProfileDrawChainBegin();
                static /*0x2abeaf0*/ void ProfileDrawChainEnd();
                static /*0x2abeb18*/ void NotifyOfUIREvents(bool subscribe);
                static /*0x2abeb54*/ UnityEngine.Matrix4x4 GetUnityProjectionMatrix();
                static /*0x2abe5c0*/ void RegisterIntermediateRenderer_Injected(UnityEngine.Camera camera, UnityEngine.Material material, ref UnityEngine.Matrix4x4 transform, ref UnityEngine.Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, nint userData, int userDataSize);
                static /*0x2abe7b0*/ void SetScissorRect_Injected(ref UnityEngine.RectInt scissorRect);
                static /*0x2abe898*/ nint CreateStencilState_Injected(ref UnityEngine.Rendering.StencilState stencilState);
                static /*0x2abea8c*/ void GetActiveViewport_Injected(ref UnityEngine.RectInt ret);
                static /*0x2abebf0*/ void GetUnityProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 ret);

                enum GPUBufferType
                {
                    Vertex = 0,
                    Index = 1,
                }

                class GPUBuffer<T> : System.IDisposable
                {
                    /*0x0*/ nint buffer;
                    /*0x0*/ int elemCount;
                    /*0x0*/ int elemStride;

                    GPUBuffer(int elementCount, UnityEngine.UIElements.UIR.Utility.GPUBufferType type);
                    void Dispose();
                    void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax);
                    int get_ElementStride();
                    nint get_BufferPointer();
                }
            }
        }
    }
}
