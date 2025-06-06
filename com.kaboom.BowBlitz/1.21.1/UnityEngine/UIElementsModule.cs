class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x29bb6fc*/ EmbeddedAttribute();
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
                /*0x29bb704*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    namespace UIElements
    {
        class ProjectionUtils
        {
            static /*0x29bb70c*/ UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far);
        }

        class VisualElement : UnityEngine.UIElements.Focusable, UnityEngine.UIElements.IVisualElementScheduler, UnityEngine.UIElements.IStylePropertyAnimations, UnityEngine.UIElements.ITransform, UnityEngine.UIElements.IExperimentalFeatures, UnityEngine.UIElements.Experimental.ITransitionAnimations, UnityEngine.UIElements.IResolvedStyle
        {
            static string k_RootVisualContainerName = "rootVisualContainer";
            static /*0x0*/ UnityEngine.PropertyName tooltipPropertyKey;
            static /*0x4*/ uint s_NextId;
            static /*0x8*/ System.Collections.Generic.List<string> s_EmptyClassList;
            static /*0x10*/ UnityEngine.PropertyName userDataPropertyKey;
            static /*0x18*/ string disabledUssClassName;
            static /*0x20*/ UnityEngine.Rect s_InfiniteRect;
            static /*0x30*/ UnityEngine.Material s_runtimeMaterial;
            static /*0x38*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.UIElements.VisualElement.TypeData> s_TypeData;
            static /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> s_EmptyList;
            static /*0x48*/ UnityEngine.UIElements.VisualElement.CustomStyleAccess s_CustomStyleAccess;
            static /*0x50*/ System.Text.RegularExpressions.Regex s_InternalStyleSheetPath;
            /*0x24*/ int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField;
            /*0x28*/ int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField;
            /*0x30*/ string m_Name;
            /*0x38*/ System.Collections.Generic.List<string> m_ClassList;
            /*0x40*/ System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.PropertyName, object>> m_PropertyBag;
            /*0x48*/ UnityEngine.UIElements.VisualElementFlags m_Flags;
            /*0x50*/ string m_ViewDataKey;
            /*0x58*/ UnityEngine.UIElements.RenderHints m_RenderHints;
            /*0x5c*/ UnityEngine.Rect lastLayout;
            /*0x6c*/ UnityEngine.Rect lastPseudoPadding;
            /*0x80*/ UnityEngine.UIElements.UIR.RenderChainVEData renderChainData;
            /*0x1d8*/ UnityEngine.Rect m_Layout;
            /*0x1e8*/ UnityEngine.Rect m_BoundingBox;
            /*0x1f8*/ UnityEngine.Rect m_WorldBoundingBox;
            /*0x208*/ UnityEngine.Matrix4x4 m_WorldTransformCache;
            /*0x248*/ UnityEngine.Matrix4x4 m_WorldTransformInverseCache;
            /*0x288*/ UnityEngine.Rect m_WorldClip;
            /*0x298*/ UnityEngine.Rect m_WorldClipMinusGroup;
            /*0x2a8*/ bool m_WorldClipIsInfinite;
            /*0x2ac*/ UnityEngine.UIElements.PseudoStates triggerPseudoMask;
            /*0x2b0*/ UnityEngine.UIElements.PseudoStates dependencyPseudoMask;
            /*0x2b4*/ UnityEngine.UIElements.PseudoStates m_PseudoStates;
            /*0x2b8*/ int <containedPointerIds>k__BackingField;
            /*0x2bc*/ UnityEngine.UIElements.PickingMode <pickingMode>k__BackingField;
            /*0x2c0*/ UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField;
            /*0x2c8*/ UnityEngine.UIElements.ComputedStyle m_Style;
            /*0x320*/ UnityEngine.UIElements.StyleVariableContext variableContext;
            /*0x328*/ int inheritedStylesHash;
            /*0x32c*/ uint controlid;
            /*0x330*/ int imguiContainerDescendantCount;
            /*0x334*/ bool <enabledSelf>k__BackingField;
            /*0x338*/ System.Action<UnityEngine.UIElements.MeshGenerationContext> <generateVisualContent>k__BackingField;
            /*0x340*/ Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker;
            /*0x348*/ UnityEngine.UIElements.VisualElement.RenderTargetMode m_SubRenderTargetMode;
            /*0x350*/ UnityEngine.Material m_defaultMaterial;
            /*0x358*/ UnityEngine.UIElements.VisualElement.TypeData m_TypeData;
            /*0x360*/ UnityEngine.UIElements.VisualElement.Hierarchy <hierarchy>k__BackingField;
            /*0x368*/ bool <isRootVisualContainer>k__BackingField;
            /*0x369*/ bool <cacheAsBitmap>k__BackingField;
            /*0x370*/ UnityEngine.UIElements.VisualElement m_PhysicalParent;
            /*0x378*/ UnityEngine.UIElements.VisualElement m_LogicalParent;
            /*0x380*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> m_Children;
            /*0x388*/ UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField;
            /*0x390*/ UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource;
            /*0x398*/ UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess;
            /*0x3a0*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> styleSheetList;
            /*0x3a8*/ System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_RunningAnimations;

            static /*0x29ca1e8*/ VisualElement();
            static /*0x29bde3c*/ float Min(float a, float b, float c, float d);
            static /*0x29bde58*/ float Max(float a, float b, float c, float d);
            static /*0x29bdff8*/ UnityEngine.Rect CalculateConservativeRect(ref UnityEngine.Matrix4x4 matrix, UnityEngine.Rect rect);
            static /*0x29be4a0*/ void TransformAlignedRect(ref UnityEngine.Matrix4x4 matrix, ref UnityEngine.Rect rect);
            static /*0x29be3cc*/ void OrderMinMaxRect(ref UnityEngine.Rect rect);
            static /*0x29be534*/ UnityEngine.Vector2 MultiplyMatrix44Point2(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector2 point);
            static /*0x29be558*/ UnityEngine.Vector2 MultiplyVector2(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector2 vector);
            static /*0x29be574*/ void MultiplyMatrix34(ref UnityEngine.Matrix4x4 lhs, ref UnityEngine.Matrix4x4 rhs, ref UnityEngine.Matrix4x4 res);
            static /*0x29be74c*/ void TranslateMatrix34(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector3 rhs, ref UnityEngine.Matrix4x4 res);
            static /*0x29be838*/ void TranslateMatrix34InPlace(ref UnityEngine.Matrix4x4 lhs, UnityEngine.Vector3 rhs);
            static /*0x29c1b14*/ UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect position, UnityEngine.Matrix4x4 mat);
            static /*0x29c57b4*/ void CheckUserKeyArgument(UnityEngine.PropertyName key);
            static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation<T>(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement, T> fromValueGetter, T to, int durationMs, System.Action<UnityEngine.UIElements.VisualElement, T> onValueChanged);
            static /*0x29c7738*/ void AssignStyleValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues src);
            /*0x29c2184*/ VisualElement();
            /*0x29bb77c*/ string get_tooltip();
            /*0x29bb890*/ void set_tooltip(string value);
            /*0x29bba94*/ UnityEngine.UIElements.IVisualElementScheduler get_schedule();
            /*0x29bba98*/ UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
            /*0x29bbbc0*/ UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action updateEvent);
            /*0x29bbccc*/ bool get_hasRunningAnimations();
            /*0x29bbd7c*/ bool get_hasCompletedAnimations();
            /*0x29bbe28*/ int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount();
            /*0x29bbe30*/ void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value);
            /*0x29bbe38*/ int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount();
            /*0x29bbe40*/ void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value);
            /*0x29bbe48*/ UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem();
            /*0x29bbd78*/ UnityEngine.UIElements.IStylePropertyAnimations get_styleAnimation();
            /*0x29bbe64*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bbf68*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc084*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc2b4*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc404*/ bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc520*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc678*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc7a8*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bc8c4*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bca50*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bcb80*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bcd5c*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bcee4*/ bool UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29bd0c0*/ void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x29bd190*/ void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations();
            /*0x29bd270*/ void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x29bd338*/ void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
            /*0x29bc1bc*/ bool TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.Length from, ref UnityEngine.UIElements.Length to);
            /*0x29bd094*/ bool TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin from, ref UnityEngine.UIElements.TransformOrigin to);
            /*0x29bcd30*/ bool TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate from, ref UnityEngine.UIElements.Translate to);
            /*0x29bd424*/ UnityEngine.Vector3 get_positionWithLayout();
            /*0x29bd764*/ void GetPivotedMatrixWithLayout(ref UnityEngine.Matrix4x4 result);
            /*0x29bdd64*/ bool get_hasDefaultRotationAndScale();
            /*0x29bde74*/ void TransformAlignedRectToParentSpace(ref UnityEngine.Rect rect);
            /*0x29be894*/ bool get_isCompositeRoot();
            /*0x29be8a0*/ void set_isCompositeRoot(bool value);
            /*0x29be8cc*/ bool get_isHierarchyDisplayed();
            /*0x29be8d8*/ void set_isHierarchyDisplayed(bool value);
            /*0x29be904*/ string get_viewDataKey();
            /*0x29be90c*/ void set_viewDataKey(string value);
            /*0x29be99c*/ bool get_enableViewDataPersistence();
            /*0x29be9a8*/ void set_enableViewDataPersistence(bool value);
            /*0x29be9d4*/ object get_userData();
            /*0x29beb34*/ void set_userData(object value);
            /*0x29bedf8*/ bool get_canGrabFocus();
            /*0x29befec*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x29bf0a4*/ UnityEngine.UIElements.UsageHints get_usageHints();
            /*0x29bf0d0*/ void set_usageHints(UnityEngine.UIElements.UsageHints value);
            /*0x29bf0c8*/ UnityEngine.UIElements.RenderHints get_renderHints();
            /*0x29bf154*/ void set_renderHints(UnityEngine.UIElements.RenderHints value);
            /*0x29bf1a0*/ void MarkRenderHintsClean();
            /*0x29bf1b0*/ UnityEngine.UIElements.ITransform get_transform();
            /*0x29bf1b4*/ UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_position();
            /*0x29bf254*/ void UnityEngine.UIElements.ITransform.set_position(UnityEngine.Vector3 value);
            /*0x29bf430*/ UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_scale();
            /*0x29bf4e4*/ bool get_isLayoutManual();
            /*0x29bf4f0*/ void set_isLayoutManual(bool value);
            /*0x29bf51c*/ float get_scaledPixelsPerPoint();
            /*0x29bd6bc*/ UnityEngine.Rect get_layout();
            /*0x29bf530*/ void set_layout(UnityEngine.Rect value);
            /*0x29bfe00*/ UnityEngine.Rect get_contentRect();
            /*0x29c0014*/ UnityEngine.Rect get_paddingRect();
            /*0x29c0294*/ bool get_isBoundingBoxDirty();
            /*0x29c02a0*/ void set_isBoundingBoxDirty(bool value);
            /*0x29c02cc*/ bool get_isWorldBoundingBoxDirty();
            /*0x29c02d8*/ void set_isWorldBoundingBoxDirty(bool value);
            /*0x29c0304*/ UnityEngine.Rect get_boundingBox();
            /*0x29c06ec*/ UnityEngine.Rect get_worldBoundingBox();
            /*0x29c0828*/ UnityEngine.Rect get_boundingBoxInParentSpace();
            /*0x29c0340*/ void UpdateBoundingBox();
            /*0x29c072c*/ void UpdateWorldBoundingBox();
            /*0x29c0a0c*/ UnityEngine.Rect get_worldBound();
            /*0x29c0adc*/ UnityEngine.Rect get_localBound();
            /*0x29c0228*/ UnityEngine.Rect get_rect();
            /*0x29c0c70*/ bool get_isWorldTransformDirty();
            /*0x29c0c7c*/ void set_isWorldTransformDirty(bool value);
            /*0x29c0ca8*/ bool get_isWorldTransformInverseDirty();
            /*0x29c0cb4*/ void set_isWorldTransformInverseDirty(bool value);
            /*0x29c0ce0*/ UnityEngine.Matrix4x4 get_worldTransform();
            /*0x29c09e8*/ ref UnityEngine.Matrix4x4 get_worldTransformRef();
            /*0x29c0fc4*/ ref UnityEngine.Matrix4x4 get_worldTransformInverse();
            /*0x29c0d20*/ void UpdateWorldTransform();
            /*0x29c0fec*/ void UpdateWorldTransformInverse();
            /*0x29c1044*/ bool get_isWorldClipDirty();
            /*0x29c1050*/ void set_isWorldClipDirty(bool value);
            /*0x29c107c*/ UnityEngine.Rect get_worldClip();
            /*0x29c1338*/ UnityEngine.Rect get_worldClipMinusGroup();
            /*0x29c1374*/ bool get_worldClipIsInfinite();
            /*0x29c13a4*/ void EnsureWorldTransformAndClipUpToDate();
            /*0x29c10b8*/ void UpdateWorldClip();
            /*0x29c1a1c*/ UnityEngine.Rect CombineClipRects(UnityEngine.Rect rect, UnityEngine.Rect parentRect);
            /*0x29c13e0*/ UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect worldRect);
            /*0x29c1ce4*/ UnityEngine.UIElements.PseudoStates get_pseudoStates();
            /*0x29c1cec*/ void set_pseudoStates(UnityEngine.UIElements.PseudoStates value);
            /*0x29c1d70*/ int get_containedPointerIds();
            /*0x29c1d78*/ void set_containedPointerIds(int value);
            /*0x29c1d80*/ void UpdateHoverPseudoState();
            /*0x29c1e4c*/ UnityEngine.UIElements.PickingMode get_pickingMode();
            /*0x29c1e54*/ void set_pickingMode(UnityEngine.UIElements.PickingMode value);
            /*0x29c1e5c*/ string get_name();
            /*0x29c1e64*/ void set_name(string value);
            /*0x29c1ebc*/ string get_fullTypeName();
            /*0x29c2048*/ string get_typeName();
            /*0x29c20fc*/ UnityEngine.Yoga.YogaNode get_yogaNode();
            /*0x29c2104*/ void set_yogaNode(UnityEngine.Yoga.YogaNode value);
            /*0x29bde34*/ ref UnityEngine.UIElements.ComputedStyle get_computedStyle();
            /*0x29c210c*/ bool get_hasInlineStyle();
            /*0x29c211c*/ bool get_styleInitialized();
            /*0x29c2128*/ void set_styleInitialized(bool value);
            /*0x29c2154*/ void ChangeIMGUIContainerCount(int delta);
            /*0x29c243c*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x29c2e48*/ UnityEngine.Rect GetTooltipRect();
            /*0x29c2d6c*/ void SetTooltip(UnityEngine.UIElements.TooltipEvent e);
            /*0x29c2e4c*/ void Focus();
            /*0x29c2ea0*/ void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel p);
            /*0x29c390c*/ void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel destinationPanel);
            /*0x29c3ae8*/ void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel prevPanel);
            /*0x29c3ee0*/ void SendEvent(UnityEngine.UIElements.EventBase e);
            /*0x29c3ef8*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x29be974*/ void IncrementVersion(UnityEngine.UIElements.VersionChangeType changeType);
            /*0x29c3f0c*/ void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType changeType);
            /*0x29c3f2c*/ bool SetEnabledFromHierarchyPrivate(bool state);
            /*0x29c42a8*/ bool get_isParentEnabledInHierarchy();
            /*0x29befdc*/ bool get_enabledInHierarchy();
            /*0x29c4618*/ bool get_enabledSelf();
            /*0x29c4620*/ void set_enabledSelf(bool value);
            /*0x29c2418*/ void SetEnabled(bool value);
            /*0x29c462c*/ void PropagateEnabledToChildren(bool value);
            /*0x29bef2c*/ bool get_visible();
            /*0x29c46dc*/ void set_visible(bool value);
            /*0x29c47c0*/ void MarkDirtyRepaint();
            /*0x29c47e4*/ System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent();
            /*0x29c47ec*/ void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value);
            /*0x29c47f4*/ void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x29c4a28*/ void GetFullHierarchicalViewDataKey(System.Text.StringBuilder key);
            /*0x29c4abc*/ string GetFullHierarchicalViewDataKey();
            /*0x29c4b30*/ void OverwriteFromViewData(object obj, string key);
            /*0x29c4e50*/ void SaveViewData();
            /*0x29c4ecc*/ bool IsViewDataPersitenceSupportedOnChildren(bool existingState);
            /*0x29c4f40*/ void OnViewDataReady(bool enablePersistence);
            /*0x29c4f78*/ void OnViewDataReady();
            /*0x29c4f7c*/ bool ContainsPoint(UnityEngine.Vector2 localPoint);
            /*0x29c4fc4*/ bool get_requireMeasureFunction();
            /*0x29c4fd0*/ void set_requireMeasureFunction(bool value);
            /*0x29c5040*/ void AssignMeasureFunction();
            /*0x29c50cc*/ void RemoveMeasureFunction();
            /*0x29c50ec*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x29c50fc*/ UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode node, float width, UnityEngine.Yoga.YogaMeasureMode widthMode, float height, UnityEngine.Yoga.YogaMeasureMode heightMode);
            /*0x29c5224*/ void FinalizeLayout();
            /*0x29c5270*/ void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule);
            /*0x29c5300*/ void SetComputedStyle(ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x29c54cc*/ string ToString();
            /*0x29c5704*/ System.Collections.Generic.List<string> GetClassesForIteration();
            /*0x29c4404*/ void AddToClassList(string className);
            /*0x29c42dc*/ void RemoveFromClassList(string className);
            /*0x29c460c*/ void EnableInClassList(string className, bool enable);
            /*0x29c570c*/ bool ClassListContains(string cls);
            /*0x29bb810*/ object GetProperty(UnityEngine.PropertyName key);
            /*0x29bba1c*/ void SetProperty(UnityEngine.PropertyName key, object value);
            /*0x29bb99c*/ bool HasProperty(UnityEngine.PropertyName key);
            /*0x29bea4c*/ bool TryGetPropertyInternal(UnityEngine.PropertyName key, ref object value);
            /*0x29beba4*/ void SetPropertyInternal(UnityEngine.PropertyName key, object value);
            /*0x29c2ae4*/ void UpdateCursorStyle(long eventType);
            /*0x29c591c*/ UnityEngine.UIElements.VisualElement.RenderTargetMode get_subRenderTargetMode();
            /*0x29c5924*/ UnityEngine.Material get_defaultMaterial();
            /*0x29c1ed4*/ UnityEngine.UIElements.VisualElement.TypeData get_typeData();
            /*0x29c5998*/ UnityEngine.UIElements.IExperimentalFeatures get_experimental();
            /*0x29c599c*/ UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation();
            /*0x29c59a0*/ UnityEngine.UIElements.VisualElement.Hierarchy get_hierarchy();
            /*0x29c59a8*/ void set_hierarchy(UnityEngine.UIElements.VisualElement.Hierarchy value);
            /*0x29c59b0*/ bool get_isRootVisualContainer();
            /*0x29c59b8*/ void set_isRootVisualContainer(bool value);
            /*0x29c59c4*/ bool get_disableClipping();
            /*0x29c59d0*/ void set_disableClipping(bool value);
            /*0x29c09bc*/ bool ShouldClip();
            /*0x29bef24*/ UnityEngine.UIElements.VisualElement get_parent();
            /*0x29c59fc*/ UnityEngine.UIElements.BaseVisualElementPanel get_elementPanel();
            /*0x29c5a04*/ void set_elementPanel(UnityEngine.UIElements.BaseVisualElementPanel value);
            /*0x29bf09c*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x29c5a0c*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x29c5a10*/ void set_visualTreeAssetSource(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x29c5a18*/ void Add(UnityEngine.UIElements.VisualElement child);
            /*0x29c5b44*/ void Insert(int index, UnityEngine.UIElements.VisualElement element);
            /*0x29c5eec*/ void Clear();
            /*0x29c6294*/ UnityEngine.UIElements.VisualElement ElementAt(int index);
            /*0x29c6298*/ UnityEngine.UIElements.VisualElement get_Item(int key);
            /*0x29c636c*/ int get_childCount();
            /*0x29c6420*/ int IndexOf(UnityEngine.UIElements.VisualElement element);
            /*0x29c64fc*/ UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<int> childIndexes);
            /*0x29c66a4*/ bool FindElementInTree(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<int> outChildIndexes);
            /*0x29c678c*/ void BringToFront();
            /*0x29c6878*/ void SendToBack();
            /*0x29c6948*/ void PlaceBehind(UnityEngine.UIElements.VisualElement sibling);
            /*0x29c6b0c*/ void RemoveFromHierarchy();
            /*0x29c6c38*/ bool Contains(UnityEngine.UIElements.VisualElement child);
            /*0x29c3834*/ void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements);
            /*0x29c6c6c*/ UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement other);
            /*0x29c6d84*/ UnityEngine.UIElements.VisualElement GetRoot();
            /*0x29c6e44*/ UnityEngine.UIElements.VisualElement GetRootVisualContainer();
            /*0x29c6e7c*/ UnityEngine.UIElements.VisualElement GetNextElementDepthFirst();
            /*0x29c6f6c*/ UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst();
            /*0x29c7054*/ UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement retargetAgainst);
            /*0x29bf3c0*/ UnityEngine.UIElements.IStyle get_style();
            /*0x29c70b8*/ UnityEngine.UIElements.ICustomStyle get_customStyle();
            /*0x29c7138*/ UnityEngine.UIElements.VisualElementStyleSheetSet get_styleSheets();
            /*0x29c715c*/ void AddStyleSheetPath(string sheetPath);
            /*0x29c7390*/ UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length length, bool isRow);
            /*0x29bd488*/ UnityEngine.Vector3 ResolveTranslate();
            /*0x29bd934*/ UnityEngine.Vector3 ResolveTransformOrigin();
            /*0x29bdcf4*/ UnityEngine.Quaternion ResolveRotation();
            /*0x29bdd3c*/ UnityEngine.Vector3 ResolveScale();
            /*0x29c7520*/ UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem();
            /*0x29c75b4*/ void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x29c76c0*/ void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x29c3da4*/ void UnregisterRunningAnimations();
            /*0x29c3e74*/ void RegisterRunningAnimations();
            /*0x29c8d18*/ UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues targetValuesToRead);
            /*0x29c9bfc*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues to, int durationMs);
            /*0x29c9ccc*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues to, int durationMs);
            /*0x29befd8*/ UnityEngine.UIElements.IResolvedStyle get_resolvedStyle();
            /*0x29c9e50*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor();
            /*0x29c9e5c*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor();
            /*0x29c9e68*/ float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius();
            /*0x29c9e84*/ float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius();
            /*0x29c9ea0*/ float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth();
            /*0x29c9ebc*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor();
            /*0x29c9ec8*/ float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth();
            /*0x29c9ee4*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor();
            /*0x29c9ef0*/ float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth();
            /*0x29c9f0c*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor();
            /*0x29c9f18*/ float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius();
            /*0x29c9f34*/ float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius();
            /*0x29c9f50*/ float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth();
            /*0x29c9f6c*/ float UnityEngine.UIElements.IResolvedStyle.get_bottom();
            /*0x29c9f88*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_color();
            /*0x29c9f94*/ UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display();
            /*0x29c9fa0*/ float UnityEngine.UIElements.IResolvedStyle.get_flexGrow();
            /*0x29c9fac*/ float UnityEngine.UIElements.IResolvedStyle.get_flexShrink();
            /*0x29c9fb8*/ float UnityEngine.UIElements.IResolvedStyle.get_height();
            /*0x29c9fd4*/ float UnityEngine.UIElements.IResolvedStyle.get_left();
            /*0x29c9ff0*/ float UnityEngine.UIElements.IResolvedStyle.get_marginBottom();
            /*0x29ca00c*/ float UnityEngine.UIElements.IResolvedStyle.get_marginLeft();
            /*0x29ca028*/ float UnityEngine.UIElements.IResolvedStyle.get_marginRight();
            /*0x29ca044*/ float UnityEngine.UIElements.IResolvedStyle.get_marginTop();
            /*0x29ca060*/ UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight();
            /*0x29ca088*/ UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth();
            /*0x29ca0b0*/ float UnityEngine.UIElements.IResolvedStyle.get_opacity();
            /*0x29ca0bc*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom();
            /*0x29ca0d8*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft();
            /*0x29ca0f4*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingRight();
            /*0x29ca110*/ float UnityEngine.UIElements.IResolvedStyle.get_paddingTop();
            /*0x29ca12c*/ float UnityEngine.UIElements.IResolvedStyle.get_right();
            /*0x29ca148*/ UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.get_scale();
            /*0x29ca154*/ float UnityEngine.UIElements.IResolvedStyle.get_top();
            /*0x29ca170*/ UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin();
            /*0x29ca174*/ UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate();
            /*0x29ca178*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor();
            /*0x29ca184*/ int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft();
            /*0x29ca190*/ int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight();
            /*0x29ca19c*/ UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor();
            /*0x29ca1a8*/ float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth();
            /*0x29ca1b4*/ UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility();
            /*0x29ca1c0*/ UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace();
            /*0x29ca1cc*/ float UnityEngine.UIElements.IResolvedStyle.get_width();
            /*0x29ca478*/ UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__281_0(UnityEngine.Yoga.YogaNode node, float f, UnityEngine.Yoga.YogaMeasureMode mode, float f1, UnityEngine.Yoga.YogaMeasureMode heightMode);

            class BaseVisualElementScheduledItem : UnityEngine.UIElements.ScheduledItem, UnityEngine.UIElements.IVisualElementScheduledItem, UnityEngine.UIElements.IVisualElementPanelActivatable
            {
                /*0x38*/ UnityEngine.UIElements.VisualElement <element>k__BackingField;
                /*0x40*/ bool isScheduled;
                /*0x48*/ UnityEngine.UIElements.VisualElementPanelActivator m_Activator;

                /*0x29ca48c*/ BaseVisualElementScheduledItem(UnityEngine.UIElements.VisualElement handler);
                /*0x29ca47c*/ UnityEngine.UIElements.VisualElement get_element();
                /*0x29ca484*/ void set_element(UnityEngine.UIElements.VisualElement value);
                /*0x29ca55c*/ UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(long delayMs);
                /*0x29ca564*/ UnityEngine.UIElements.IVisualElementScheduledItem Every(long intervalMs);
                /*0x29ca608*/ void OnItemUnscheduled();
                /*0x29bbba4*/ void Resume();
                /*0x29ca980*/ void Pause();
                /*0x29ca99c*/ void ExecuteLater(long delayMs);
                /*0x29ca9d8*/ void OnPanelActivate();
                /*0x29caac8*/ void OnPanelDeactivate();
                /*0x29caba4*/ bool CanBeActivated();
            }

            class VisualElementScheduledItem<ActionType> : UnityEngine.UIElements.VisualElement.BaseVisualElementScheduledItem
            {
                /*0x0*/ ActionType updateEvent;

                VisualElementScheduledItem(UnityEngine.UIElements.VisualElement handler, ActionType upEvent);
            }

            class TimerStateScheduledItem : UnityEngine.UIElements.VisualElement.VisualElementScheduledItem<System.Action<UnityEngine.UIElements.TimerState>>
            {
                /*0x29bbb44*/ TimerStateScheduledItem(UnityEngine.UIElements.VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent);
                /*0x29cabe0*/ void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
            }

            class SimpleScheduledItem : UnityEngine.UIElements.VisualElement.VisualElementScheduledItem<System.Action>
            {
                /*0x29bbc6c*/ SimpleScheduledItem(UnityEngine.UIElements.VisualElement handler, System.Action updateEvent);
                /*0x29cac14*/ void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
            }

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement.UxmlTraits>
            {
                /*0x29cac48*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.UxmlTraits
            {
                /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
                /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_ViewDataKey;
                /*0x28*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.PickingMode> m_PickingMode;
                /*0x30*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Tooltip;
                /*0x38*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.UsageHints> m_UsageHints;
                /*0x40*/ UnityEngine.UIElements.UxmlIntAttributeDescription <focusIndex>k__BackingField;
                /*0x48*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_TabIndex;
                /*0x50*/ UnityEngine.UIElements.UxmlBoolAttributeDescription <focusable>k__BackingField;
                /*0x58*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Class;
                /*0x60*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_ContentContainer;
                /*0x68*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Style;

                /*0x29caf28*/ UxmlTraits();
                /*0x29cac90*/ UnityEngine.UIElements.UxmlIntAttributeDescription get_focusIndex();
                /*0x29cac98*/ UnityEngine.UIElements.UxmlBoolAttributeDescription get_focusable();
                /*0x29caca0*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            enum MeasureMode
            {
                Undefined = 0,
                Exactly = 1,
                AtMost = 2,
            }

            enum RenderTargetMode
            {
                None = 0,
                NoColorConversion = 1,
                LinearToGamma = 2,
                GammaToLinear = 3,
            }

            class TypeData
            {
                /*0x10*/ System.Type <type>k__BackingField;
                /*0x18*/ string m_FullTypeName;
                /*0x20*/ string m_TypeName;

                /*0x29c592c*/ TypeData(System.Type type);
                /*0x29cb3f8*/ System.Type get_type();
                /*0x29c2000*/ string get_fullTypeName();
                /*0x29c2060*/ string get_typeName();
            }

            struct Hierarchy
            {
                static string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";
                /*0x10*/ UnityEngine.UIElements.VisualElement m_Owner;

                static /*0x29cba30*/ bool op_Equality(UnityEngine.UIElements.VisualElement.Hierarchy x, UnityEngine.UIElements.VisualElement.Hierarchy y);
                /*0x29c2410*/ Hierarchy(UnityEngine.UIElements.VisualElement element);
                /*0x29bef08*/ UnityEngine.UIElements.VisualElement get_parent();
                /*0x29c5ac8*/ void Add(UnityEngine.UIElements.VisualElement child);
                /*0x29c5bd0*/ void Insert(int index, UnityEngine.UIElements.VisualElement child);
                /*0x29c6b44*/ void Remove(UnityEngine.UIElements.VisualElement child);
                /*0x29cb568*/ void RemoveAt(int index);
                /*0x29c5f50*/ void Clear();
                /*0x29c67c4*/ void BringToFront(UnityEngine.UIElements.VisualElement child);
                /*0x29c68b0*/ void SendToBack(UnityEngine.UIElements.VisualElement child);
                /*0x29c6a34*/ void PlaceBehind(UnityEngine.UIElements.VisualElement child, UnityEngine.UIElements.VisualElement over);
                /*0x29cb908*/ void MoveChildElement(UnityEngine.UIElements.VisualElement child, int currentIndex, int nextIndex);
                /*0x29c63d0*/ int get_childCount();
                /*0x29c630c*/ UnityEngine.UIElements.VisualElement get_Item(int key);
                /*0x29c649c*/ int IndexOf(UnityEngine.UIElements.VisualElement element);
                /*0x29cba1c*/ UnityEngine.UIElements.VisualElement ElementAt(int index);
                /*0x29cb540*/ void SetParent(UnityEngine.UIElements.VisualElement value);
                /*0x29cb400*/ void PutChildAtIndex(UnityEngine.UIElements.VisualElement child, int index);
                /*0x29cb7ac*/ void RemoveChildAtIndex(int index);
                /*0x29cb828*/ void ReleaseChildList();
                /*0x29cba20*/ bool Equals(UnityEngine.UIElements.VisualElement.Hierarchy other);
                /*0x29cba3c*/ bool Equals(object obj);
                /*0x29cbab4*/ int GetHashCode();
            }

            class CustomStyleAccess : UnityEngine.UIElements.ICustomStyle
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties;
                /*0x18*/ float m_DpiScaling;

                static /*0x29cbe2c*/ void LogCustomPropertyWarning(string propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp);
                /*0x29ca470*/ CustomStyleAccess();
                /*0x29c712c*/ void SetContext(System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, float dpiScaling);
                /*0x29cbacc*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<float> property, ref float value);
                /*0x29cbc20*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<int> property, ref int value);
                /*0x29cbce0*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, ref UnityEngine.Color value);
                /*0x29cbf30*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, ref UnityEngine.Texture2D value);
                /*0x29cc030*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, ref UnityEngine.Sprite value);
                /*0x29cc130*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, ref UnityEngine.UIElements.VectorImage value);
                /*0x29cc230*/ bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<string> property, ref string value);
                /*0x29cbb68*/ bool TryGetValue(string propertyName, UnityEngine.UIElements.StyleValueType valueType, ref UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp);
            }

            class <>c__DisplayClass435_0
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement <>4__this;
                /*0x18*/ UnityEngine.UIElements.Experimental.StyleValues to;

                /*0x29c9cc4*/ <>c__DisplayClass435_0();
                /*0x29cc2f4*/ UnityEngine.UIElements.Experimental.StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(UnityEngine.UIElements.VisualElement e);
            }
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ int m_MaxSize;

            ObjectPool(int maxSize);
            int get_maxSize();
            void set_maxSize(int value);
            int Size();
            T Get();
            void Release(T element);
        }

        interface IVisualElementScheduledItem
        {
            void Resume();
            void Pause();
            void ExecuteLater(long delayMs);
            UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(long delayMs);
            UnityEngine.UIElements.IVisualElementScheduledItem Every(long intervalMs);
        }

        interface IVisualElementScheduler
        {
            UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
            UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action updateEvent);
        }

        interface IVisualElementPanelActivatable
        {
            UnityEngine.UIElements.VisualElement get_element();
            bool CanBeActivated();
            void OnPanelActivate();
            void OnPanelDeactivate();
        }

        class VisualElementPanelActivator
        {
            /*0x10*/ UnityEngine.UIElements.IVisualElementPanelActivatable m_Activatable;
            /*0x18*/ bool <isActive>k__BackingField;
            /*0x19*/ bool <isDetaching>k__BackingField;

            /*0x29ca534*/ VisualElementPanelActivator(UnityEngine.UIElements.IVisualElementPanelActivatable activatable);
            /*0x29cc310*/ bool get_isActive();
            /*0x29cc318*/ void set_isActive(bool value);
            /*0x29cc324*/ bool get_isDetaching();
            /*0x29cc32c*/ void set_isDetaching(bool value);
            /*0x29ca644*/ void SetActive(bool action);
            /*0x29cc338*/ void SendActivation();
            /*0x29cc450*/ void SendDeactivation();
            /*0x29cc568*/ void OnEnter(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x29cc578*/ void OnLeave(UnityEngine.UIElements.DetachFromPanelEvent evt);
        }

        enum VisualTreeUpdatePhase
        {
            ViewData = 0,
            Bindings = 1,
            Animation = 2,
            Styles = 3,
            Layout = 4,
            TransformClip = 5,
            Repaint = 6,
            Count = 7,
        }

        class VisualTreeUpdater : System.IDisposable
        {
            /*0x10*/ UnityEngine.UIElements.BaseVisualElementPanel m_Panel;
            /*0x18*/ UnityEngine.UIElements.VisualTreeUpdater.UpdaterArray m_UpdaterArray;

            /*0x29cc5ec*/ VisualTreeUpdater(UnityEngine.UIElements.BaseVisualElementPanel panel);
            /*0x29cc800*/ void Dispose();
            /*0x29cc8fc*/ void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x29ccb84*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            void SetUpdater<T>(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x29ccc6c*/ UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x29cc6c4*/ void SetDefaultUpdaters();

            class UpdaterArray
            {
                /*0x10*/ UnityEngine.UIElements.IVisualTreeUpdater[] m_VisualTreeUpdaters;

                /*0x29cc668*/ UpdaterArray();
                /*0x29ccc84*/ void set_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase, UnityEngine.UIElements.IVisualTreeUpdater value);
                /*0x29ccb54*/ UnityEngine.UIElements.IVisualTreeUpdater get_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
                /*0x29cc8cc*/ UnityEngine.UIElements.IVisualTreeUpdater get_Item(int index);
            }
        }

        interface IVisualTreeUpdater : System.IDisposable
        {
            void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value);
            Unity.Profiling.ProfilerMarker get_profilerMarker();
            void Update();
            void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
        }

        class BaseVisualTreeUpdater : UnityEngine.UIElements.IVisualTreeUpdater, System.IDisposable
        {
            /*0x10*/ System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelChanged;
            /*0x18*/ UnityEngine.UIElements.BaseVisualElementPanel m_Panel;

            /*0x29ccf04*/ BaseVisualTreeUpdater();
            /*0x29ccce8*/ void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x29ccd98*/ void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x29cce48*/ UnityEngine.UIElements.BaseVisualElementPanel get_panel();
            /*0x29cce50*/ void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value);
            /*0x29cce70*/ UnityEngine.UIElements.VisualElement get_visualTree();
            Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x29cce94*/ void Dispose();
            /*0x29ccf00*/ void Dispose(bool disposing);
            void Update();
            void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
        }

        class ClickDetector
        {
            static /*0x0*/ int <s_DoubleClickTime>k__BackingField;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus> m_ClickStatus;

            static /*0x29ce010*/ ClickDetector();
            static /*0x29ccf0c*/ int get_s_DoubleClickTime();
            static /*0x29ccf64*/ void set_s_DoubleClickTime(int value);
            static /*0x29cd8d8*/ bool ContainsPointer(UnityEngine.UIElements.VisualElement element, UnityEngine.Vector2 position);
            /*0x29ccfc0*/ ClickDetector();
            /*0x29cd228*/ void StartClickTracking(UnityEngine.UIElements.EventBase evt);
            /*0x29cd4f4*/ void SendClickEvent(UnityEngine.UIElements.EventBase evt);
            /*0x29cd9f8*/ void CancelClickTracking(UnityEngine.UIElements.EventBase evt);
            /*0x29cdaf4*/ void ProcessEvent(UnityEngine.UIElements.EventBase evt);

            class ButtonClickStatus
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement m_Target;
                /*0x18*/ UnityEngine.Vector3 m_PointerDownPosition;
                /*0x28*/ long m_LastPointerDownTime;
                /*0x30*/ int m_ClickCount;

                /*0x29cd220*/ ButtonClickStatus();
                /*0x29cd490*/ void Reset();
            }
        }

        class DropdownUtility
        {
            static /*0x0*/ System.Func<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc;

            static /*0x29ce05c*/ UnityEngine.UIElements.IGenericMenu CreateDropdown();
        }

        class AtlasBase
        {
            /*0x10*/ UnityEngine.UIElements.TextureRegistry textureRegistry;

            static /*0x29ce1a0*/ void RepaintTexturedElements(UnityEngine.UIElements.IPanel panel);
            /*0x29ce2ac*/ AtlasBase();
            /*0x29ce0f4*/ bool TryGetAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, ref UnityEngine.UIElements.TextureId atlas, ref UnityEngine.RectInt atlasRect);
            /*0x29ce168*/ void ReturnAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas);
            /*0x29ce16c*/ void Reset();
            /*0x29ce170*/ void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel);
            /*0x29ce174*/ void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel);
            /*0x29ce178*/ void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel);
            /*0x29ce17c*/ void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel panel);
            /*0x29ce188*/ void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel panel);
            /*0x29ce194*/ void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel);
            /*0x29ce28c*/ void SetDynamicTexture(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture);
        }

        enum DynamicAtlasFilters
        {
            None = 0,
            Readability = 1,
            Size = 2,
            Format = 4,
            ColorSpace = 8,
            FilterMode = 16,
        }

        class DynamicAtlasCustomFilter : System.MulticastDelegate
        {
            /*0x29ce344*/ DynamicAtlasCustomFilter(object object, nint method);
            /*0x29ce41c*/ bool Invoke(UnityEngine.Texture2D texture, ref UnityEngine.UIElements.DynamicAtlasFilters filtersToApply);
        }

        class DynamicAtlas : UnityEngine.UIElements.AtlasBase
        {
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.UIElements.DynamicAtlas.TextureInfo> m_Database;
            /*0x20*/ UnityEngine.UIElements.DynamicAtlasPage m_PointPage;
            /*0x28*/ UnityEngine.UIElements.DynamicAtlasPage m_BilinearPage;
            /*0x30*/ UnityEngine.ColorSpace m_ColorSpace;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.IPanel> m_Panels;
            /*0x40*/ int m_MinAtlasSize;
            /*0x44*/ int m_MaxAtlasSize;
            /*0x48*/ int m_MaxSubTextureSize;
            /*0x4c*/ UnityEngine.UIElements.DynamicAtlasFilters m_ActiveFilters;
            /*0x50*/ UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter;

            static /*0x29cece4*/ bool IsTextureFormatSupported(UnityEngine.TextureFormat format);
            static /*0x29cee80*/ UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters();
            /*0x29cef10*/ DynamicAtlas();
            /*0x29ce430*/ bool get_isInitialized();
            /*0x29ce450*/ void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel);
            /*0x29ce520*/ void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel);
            /*0x29ce630*/ void Reset();
            /*0x29ce6dc*/ void InitPages();
            /*0x29ce5b8*/ void DestroyPages();
            /*0x29ce7e4*/ bool TryGetAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, ref UnityEngine.UIElements.TextureId atlas, ref UnityEngine.RectInt atlasRect);
            /*0x29ceb40*/ void ReturnAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas);
            /*0x29cec7c*/ void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel);
            /*0x29ced18*/ bool IsTextureValid(UnityEngine.Texture2D texture, UnityEngine.FilterMode atlasFilterMode);
            /*0x29cee40*/ void set_minAtlasSize(int value);
            /*0x29cee60*/ void set_maxAtlasSize(int value);
            /*0x29cee88*/ void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value);
            /*0x29cee38*/ int get_maxSubTextureSize();
            /*0x29ceea8*/ void set_maxSubTextureSize(int value);
            /*0x29ceec8*/ void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value);

            class TextureInfo : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.DynamicAtlas.TextureInfo>
            {
                static /*0x0*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.DynamicAtlas.TextureInfo> pool;
                /*0x18*/ UnityEngine.UIElements.DynamicAtlasPage page;
                /*0x20*/ int counter;
                /*0x28*/ UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc;
                /*0x58*/ UnityEngine.RectInt rect;

                static /*0x29cf0ac*/ TextureInfo();
                static /*0x29cefdc*/ UnityEngine.UIElements.DynamicAtlas.TextureInfo Create();
                static /*0x29cf07c*/ void Reset(UnityEngine.UIElements.DynamicAtlas.TextureInfo info);
                /*0x29cf034*/ TextureInfo();
            }
        }

        class DefaultEventSystem
        {
            static /*0x0*/ System.Func<bool> IsEditorRemoteConnected;
            /*0x10*/ UnityEngine.UIElements.DefaultEventSystem.IInput m_Input;
            /*0x18*/ string m_HorizontalAxis;
            /*0x20*/ string m_VerticalAxis;
            /*0x28*/ string m_SubmitButton;
            /*0x30*/ string m_CancelButton;
            /*0x38*/ float m_InputActionsPerSecond;
            /*0x3c*/ float m_RepeatDelay;
            /*0x40*/ bool m_SendingTouchEvents;
            /*0x48*/ UnityEngine.Event m_Event;
            /*0x50*/ UnityEngine.UIElements.BaseRuntimePanel m_FocusedPanel;
            /*0x58*/ int m_ConsecutiveMoveCount;
            /*0x5c*/ UnityEngine.Vector2 m_LastMoveVector;
            /*0x64*/ float m_PrevActionTime;

            static /*0x29d0a00*/ DefaultEventSystem();
            static /*0x29d04c4*/ UnityEngine.UIElements.EventBase MakeTouchEvent(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers);
            static /*0x29d017c*/ UnityEngine.Vector2 GetLocalScreenPosition(UnityEngine.Event evt, ref System.Nullable<int> targetDisplay);
            /*0x29d090c*/ DefaultEventSystem();
            /*0x29cf1dc*/ bool get_isAppFocused();
            /*0x29cf1e4*/ UnityEngine.UIElements.DefaultEventSystem.IInput get_input();
            /*0x29cf208*/ UnityEngine.UIElements.DefaultEventSystem.IInput GetDefaultInput();
            /*0x29cf3ac*/ bool ShouldIgnoreEventsOnAppNotFocused();
            /*0x29cf3cc*/ UnityEngine.UIElements.BaseRuntimePanel get_focusedPanel();
            /*0x29cf3d4*/ void set_focusedPanel(UnityEngine.UIElements.BaseRuntimePanel value);
            /*0x29cf4a4*/ void Update(UnityEngine.UIElements.DefaultEventSystem.UpdateMode updateMode);
            /*0x29cf960*/ void SendIMGUIEvents();
            /*0x29cfe20*/ void SendInputEvents();
            void SendFocusBasedEvent<TArg>(System.Func<TArg, UnityEngine.UIElements.EventBase> evtFactory, TArg arg);
            void SendPositionBasedEvent<TArg>(UnityEngine.Vector3 mousePosition, UnityEngine.Vector3 delta, int pointerId, System.Nullable<int> targetDisplay, System.Func<UnityEngine.Vector3, UnityEngine.Vector3, TArg, UnityEngine.UIElements.EventBase> evtFactory, TArg arg, bool deselectIfNoTarget);
            /*0x29d0450*/ void UpdateFocusedPanel(UnityEngine.UIElements.BaseRuntimePanel runtimePanel);
            /*0x29cf510*/ bool ProcessTouchEvents();
            /*0x29d0654*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x29d0198*/ bool ShouldSendMoveFromInput();

            enum UpdateMode
            {
                Always = 0,
                IgnoreIfAppNotFocused = 1,
            }

            interface IInput
            {
                bool GetButtonDown(string button);
                float GetAxisRaw(string axis);
                int get_touchCount();
                UnityEngine.Touch GetTouch(int index);
                bool get_mousePresent();
            }

            class Input : UnityEngine.UIElements.DefaultEventSystem.IInput
            {
                /*0x29cf39c*/ Input();
                /*0x29d0ac4*/ bool GetButtonDown(string button);
                /*0x29d0ad0*/ float GetAxisRaw(string axis);
                /*0x29d0adc*/ int get_touchCount();
                /*0x29d0ae4*/ UnityEngine.Touch GetTouch(int index);
                /*0x29d0b1c*/ bool get_mousePresent();
            }

            class NoInput : UnityEngine.UIElements.DefaultEventSystem.IInput
            {
                /*0x29cf3a4*/ NoInput();
                /*0x29d0b24*/ bool GetButtonDown(string button);
                /*0x29d0b2c*/ float GetAxisRaw(string axis);
                /*0x29d0b34*/ int get_touchCount();
                /*0x29d0b3c*/ UnityEngine.Touch GetTouch(int index);
                /*0x29d0b50*/ bool get_mousePresent();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.DefaultEventSystem.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__23_0;
                static /*0x10*/ System.Func<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__23_1;
                static /*0x18*/ System.Func<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__23_2;
                static /*0x20*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__24_0;
                static /*0x28*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__24_1;
                static /*0x30*/ System.Func<UnityEngine.UIElements.DefaultEventSystem, UnityEngine.UIElements.EventBase> <>9__24_2;
                static /*0x38*/ System.Func<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Touch, UnityEngine.UIElements.EventBase> <>9__30_0;

                static /*0x29d0b58*/ <>c();
                /*0x29d0bbc*/ <>c();
                /*0x29d0bc4*/ UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__23_0(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x29d0c28*/ UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__23_1(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.UIElements.DefaultEventSystem self);
                /*0x29d0cb4*/ UnityEngine.UIElements.EventBase <SendIMGUIEvents>b__23_2(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.UIElements.DefaultEventSystem self);
                /*0x29d0d68*/ UnityEngine.UIElements.EventBase <SendInputEvents>b__24_0(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x29d0d88*/ UnityEngine.UIElements.EventBase <SendInputEvents>b__24_1(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x29d0dec*/ UnityEngine.UIElements.EventBase <SendInputEvents>b__24_2(UnityEngine.UIElements.DefaultEventSystem self);
                /*0x29d0e50*/ UnityEngine.UIElements.EventBase <ProcessTouchEvents>b__30_0(UnityEngine.Vector3 panelPosition, UnityEngine.Vector3 panelDelta, UnityEngine.Touch _touch);
                /*0x29d0f1c*/ bool <.cctor>b__41_0();
            }
        }

        interface IStylePainter
        {
            void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
            void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
            void DrawImmediate(System.Action callback, bool cullingEnabled);
        }

        struct CursorPositionStylePainterParameters
        {
            /*0x10*/ UnityEngine.Rect rect;
            /*0x20*/ string text;
            /*0x28*/ UnityEngine.Font font;
            /*0x30*/ int fontSize;
            /*0x34*/ UnityEngine.FontStyle fontStyle;
            /*0x38*/ UnityEngine.TextAnchor anchor;
            /*0x3c*/ float wordWrapWidth;
            /*0x40*/ bool richText;
            /*0x44*/ int cursorIndex;

            static /*0x29d0f24*/ UnityEngine.UIElements.CursorPositionStylePainterParameters GetDefault(UnityEngine.UIElements.VisualElement ve, string text);
            /*0x29d106c*/ UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(float scaling);
        }

        class VisualElementAnimationSystem : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            static /*0x10*/ string s_StylePropertyAnimationDescription;
            static /*0x18*/ Unity.Profiling.ProfilerMarker s_StylePropertyAnimationProfilerMarker;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList;
            /*0x30*/ bool m_HasNewAnimations;
            /*0x31*/ bool m_IterationListDirty;
            /*0x38*/ long lastUpdate;

            static /*0x29d1b34*/ VisualElementAnimationSystem();
            static /*0x29d1114*/ Unity.Profiling.ProfilerMarker get_stylePropertyAnimationProfilerMarker();
            /*0x29d1a70*/ VisualElementAnimationSystem();
            /*0x29d10bc*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x29d116c*/ void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x29d11d0*/ void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims);
            /*0x29d1348*/ void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim);
            /*0x29d13ac*/ void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims);
            /*0x29d1524*/ void Update();
            /*0x29d1a6c*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
        }

        class AlignmentUtils
        {
            static /*0x29d1c04*/ float RoundToPixelGrid(float v, float pixelsPerPoint, float offset);
            static /*0x29d1c20*/ float CeilToPixelGrid(float v, float pixelsPerPoint, float offset);
        }

        enum MouseButton
        {
            LeftMouse = 0,
            RightMouse = 1,
            MiddleMouse = 2,
        }

        class PointerCaptureHelper
        {
            static /*0x29d1c34*/ UnityEngine.UIElements.PointerDispatchState GetStateFor(UnityEngine.UIElements.IEventHandler handler);
            static /*0x29d1d4c*/ bool HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            static /*0x29d1dbc*/ void CapturePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            static /*0x29d1f30*/ void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            static /*0x29d1fa4*/ UnityEngine.UIElements.IEventHandler GetCapturingElement(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x29d209c*/ void ReleasePointer(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x29d2190*/ void ActivateCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x29d2288*/ void PreventCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, int pointerId);
            static /*0x29d237c*/ bool ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.IPointerEvent evt);
            static /*0x29d25d4*/ void ProcessPointerCapture(UnityEngine.UIElements.IPanel panel, int pointerId);
        }

        class PointerDispatchState
        {
            /*0x10*/ UnityEngine.UIElements.IEventHandler[] m_PendingPointerCapture;
            /*0x18*/ UnityEngine.UIElements.IEventHandler[] m_PointerCapture;
            /*0x20*/ bool[] m_ShouldSendCompatibilityMouseEvents;

            /*0x29d2ff0*/ PointerDispatchState();
            /*0x29d30c8*/ void Reset();
            /*0x29d206c*/ UnityEngine.UIElements.IEventHandler GetCapturingElement(int pointerId);
            /*0x29d1d84*/ bool HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            /*0x29d1df4*/ void CapturePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            /*0x29d2160*/ void ReleasePointer(int pointerId);
            /*0x29d1f68*/ void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, int pointerId);
            /*0x29d2698*/ void ProcessPointerCapture(int pointerId);
            /*0x29d2254*/ void ActivateCompatibilityMouseEvents(int pointerId);
            /*0x29d234c*/ void PreventCompatibilityMouseEvents(int pointerId);
            /*0x29d24a0*/ bool ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent evt);
        }

        class ContextualMenuManager
        {
            /*0x10*/ bool <displayMenuHandledOSX>k__BackingField;

            void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IEventHandler eventHandler);
            void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.EventBase triggerEvent);
        }

        class TemplateContainer : UnityEngine.UIElements.BindableElement
        {
            /*0x3c0*/ string <templateId>k__BackingField;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_ContentContainer;
            /*0x3d0*/ UnityEngine.UIElements.VisualTreeAsset m_TemplateSource;

            /*0x29d3170*/ TemplateContainer();
            /*0x29d318c*/ TemplateContainer(string templateId);
            /*0x29d3158*/ string get_templateId();
            /*0x29d3160*/ void set_templateId(string value);
            /*0x29d3168*/ void set_templateSource(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x29d320c*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x29d3214*/ void SetContentContainer(UnityEngine.UIElements.VisualElement content);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TemplateContainer, UnityEngine.UIElements.TemplateContainer.UxmlTraits>
            {
                /*0x29d32d0*/ UxmlFactory();
                /*0x29d321c*/ string get_uxmlName();
                /*0x29d325c*/ string get_uxmlQualifiedName();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Template;

                /*0x29d37e8*/ UxmlTraits();
                /*0x29d3318*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        interface ITransform
        {
            UnityEngine.Vector3 get_position();
            void set_position(UnityEngine.Vector3 value);
            UnityEngine.Vector3 get_scale();
        }

        interface IStylePropertyAnimations
        {
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            void UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
            void CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void CancelAllAnimations();
            int get_runningAnimationCount();
            void set_runningAnimationCount(int value);
            int get_completedAnimationCount();
            void set_completedAnimationCount(int value);
        }

        class UIElementsPackageUtility
        {
            static /*0x0*/ string EditorResourcesBasePath;
            static /*0x8*/ bool IsUIEPackageLoaded;

            static /*0x29d38f8*/ UIElementsPackageUtility();
        }

        struct ManipulatorActivationFilter : System.IEquatable<UnityEngine.UIElements.ManipulatorActivationFilter>
        {
            /*0x10*/ UnityEngine.UIElements.MouseButton <button>k__BackingField;
            /*0x14*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x18*/ int <clickCount>k__BackingField;

            /*0x29d3964*/ UnityEngine.UIElements.MouseButton get_button();
            /*0x29d396c*/ void set_button(UnityEngine.UIElements.MouseButton value);
            /*0x29d3974*/ UnityEngine.EventModifiers get_modifiers();
            /*0x29d397c*/ int get_clickCount();
            /*0x29d3984*/ bool Equals(object obj);
            /*0x29d3a1c*/ bool Equals(UnityEngine.UIElements.ManipulatorActivationFilter other);
            /*0x29d3a50*/ int GetHashCode();
            /*0x29d3ad0*/ bool Matches(UnityEngine.UIElements.IMouseEvent e);
            /*0x29d3c28*/ bool HasModifiers(UnityEngine.UIElements.IMouseEvent e);
            /*0x29d3e70*/ bool Matches(UnityEngine.UIElements.IPointerEvent e);
            /*0x29d3fc8*/ bool HasModifiers(UnityEngine.UIElements.IPointerEvent e);
            /*0x29d3e1c*/ bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command);
        }

        class VisualTreeTransformClipUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ uint m_Version;
            /*0x24*/ uint m_LastVersion;

            static /*0x29d4774*/ VisualTreeTransformClipUpdater();
            static /*0x29d4308*/ void DirtyHierarchy(UnityEngine.UIElements.VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip);
            static /*0x29d445c*/ void DirtyBoundingBoxHierarchy(UnityEngine.UIElements.VisualElement ve);
            /*0x29d4768*/ VisualTreeTransformClipUpdater();
            /*0x29d41bc*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x29d4214*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x29d4504*/ void Update();
        }

        enum HierarchyChangeType
        {
            Add = 0,
            Remove = 1,
            Move = 2,
        }

        class BaseVisualTreeHierarchyTrackerUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            /*0x20*/ UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.State m_State;
            /*0x28*/ UnityEngine.UIElements.VisualElement m_CurrentChangeElement;
            /*0x30*/ UnityEngine.UIElements.VisualElement m_CurrentChangeParent;

            /*0x29d4a64*/ BaseVisualTreeHierarchyTrackerUpdater();
            void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type);
            /*0x29d4800*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x29d49d0*/ void Update();
            /*0x29d482c*/ void ProcessNewChange(UnityEngine.UIElements.VisualElement ve);
            /*0x29d4914*/ void ProcessAddOrMove(UnityEngine.UIElements.VisualElement ve);
            /*0x29d48b0*/ void ProcessRemove(UnityEngine.UIElements.VisualElement ve);

            enum State
            {
                Waiting = 0,
                TrackingAddOrMove = 1,
                TrackingRemove = 2,
            }
        }

        class ClampedDragger<T> : UnityEngine.UIElements.Clickable
        {
            /*0x0*/ System.Action dragging;
            /*0x0*/ UnityEngine.UIElements.ClampedDragger.DragDirection<T> <dragDirection>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.BaseSlider<T> <slider>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <startMousePosition>k__BackingField;

            ClampedDragger(UnityEngine.UIElements.BaseSlider<T> slider, System.Action clickHandler, System.Action dragHandler);
            void add_dragging(System.Action value);
            void remove_dragging(System.Action value);
            UnityEngine.UIElements.ClampedDragger.DragDirection<T> get_dragDirection();
            void set_dragDirection(UnityEngine.UIElements.ClampedDragger.DragDirection<T> value);
            void set_slider(UnityEngine.UIElements.BaseSlider<T> value);
            UnityEngine.Vector2 get_startMousePosition();
            void set_startMousePosition(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_delta();
            void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, int pointerId);
            void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition);

            enum DragDirection<T>
            {
                None = 0,
                LowToHigh = 1,
                HighToLow = 2,
                Free = 4,
            }
        }

        struct TextShadow : System.IEquatable<UnityEngine.UIElements.TextShadow>
        {
            /*0x10*/ UnityEngine.Vector2 offset;
            /*0x18*/ float blurRadius;
            /*0x1c*/ UnityEngine.Color color;

            static /*0x29d4c58*/ bool op_Equality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2);
            static /*0x29d4c88*/ bool op_Inequality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2);
            static /*0x29d4dc4*/ UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, float t);
            /*0x29d4a70*/ bool Equals(object obj);
            /*0x29d4b00*/ bool Equals(UnityEngine.UIElements.TextShadow other);
            /*0x29d4b80*/ int GetHashCode();
            /*0x29d4cd0*/ string ToString();
        }

        struct StylePropertyName : System.IEquatable<UnityEngine.UIElements.StylePropertyName>
        {
            /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId <id>k__BackingField;
            /*0x18*/ string <name>k__BackingField;

            static /*0x29d4e2c*/ UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(string name);
            static /*0x29d4fac*/ bool op_Equality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs);
            static /*0x29d4fb8*/ bool op_Inequality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs);
            static /*0x29d4fc4*/ UnityEngine.UIElements.StylePropertyName op_Implicit(string name);
            /*0x29d4ecc*/ StylePropertyName(UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId);
            /*0x29d4f78*/ StylePropertyName(string name);
            /*0x29d4e1c*/ UnityEngine.UIElements.StyleSheets.StylePropertyId get_id();
            /*0x29d4e24*/ string get_name();
            /*0x29d4fe4*/ int GetHashCode();
            /*0x29d4fec*/ bool Equals(object other);
            /*0x29d5064*/ bool Equals(UnityEngine.UIElements.StylePropertyName other);
            /*0x29d5074*/ string ToString();
        }

        class MouseManipulator : UnityEngine.UIElements.Manipulator
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.ManipulatorActivationFilter m_currentActivator;

            /*0x29d508c*/ MouseManipulator();
            /*0x29d507c*/ System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators();
            /*0x29d5084*/ void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value);
            /*0x29d510c*/ bool CanStartManipulation(UnityEngine.UIElements.IMouseEvent e);
            /*0x29d5288*/ bool CanStopManipulation(UnityEngine.UIElements.IMouseEvent e);
        }

        class VisualElementFocusChangeDirection : UnityEngine.UIElements.FocusChangeDirection
        {
            static /*0x0*/ UnityEngine.UIElements.VisualElementFocusChangeDirection s_Left;
            static /*0x8*/ UnityEngine.UIElements.VisualElementFocusChangeDirection s_Right;

            static /*0x29d5458*/ VisualElementFocusChangeDirection();
            static /*0x29d5340*/ UnityEngine.UIElements.FocusChangeDirection get_left();
            static /*0x29d5398*/ UnityEngine.UIElements.FocusChangeDirection get_right();
            /*0x29d53f0*/ VisualElementFocusChangeDirection(int value);
        }

        class VisualElementFocusChangeTarget : UnityEngine.UIElements.FocusChangeDirection
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool;
            /*0x18*/ UnityEngine.UIElements.Focusable <target>k__BackingField;

            static /*0x29d5780*/ VisualElementFocusChangeTarget();
            static /*0x29d55a0*/ UnityEngine.UIElements.VisualElementFocusChangeTarget GetPooled(UnityEngine.UIElements.Focusable target);
            /*0x29d56d0*/ VisualElementFocusChangeTarget();
            /*0x29d5628*/ void Dispose();
            /*0x29d56ac*/ void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f);
            /*0x29d5770*/ UnityEngine.UIElements.Focusable get_target();
            /*0x29d5778*/ void set_target(UnityEngine.UIElements.Focusable value);
        }

        class VisualElementFocusRing : UnityEngine.UIElements.IFocusRing
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement root;
            /*0x18*/ UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder <defaultFocusOrder>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_FocusRing;

            static /*0x29d67e0*/ UnityEngine.UIElements.FocusChangeDirection GetKeyDownFocusChangeDirection(UnityEngine.UIElements.EventBase e);
            static /*0x29d6dd4*/ UnityEngine.UIElements.Focusable GetNextFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable);
            static /*0x29d6e70*/ UnityEngine.UIElements.Focusable GetPreviousFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable);
            /*0x29d5810*/ VisualElementFocusRing(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder dfo);
            /*0x29d58a8*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x29d58cc*/ UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder get_defaultFocusOrder();
            /*0x29d58d4*/ void set_defaultFocusOrder(UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder value);
            /*0x29d58dc*/ int FocusRingAutoIndexSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b);
            /*0x29d5d2c*/ int FocusRingSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b);
            /*0x29d5e1c*/ void DoUpdate();
            /*0x29d5ef4*/ void BuildRingForScopeRecursive(UnityEngine.UIElements.VisualElement ve, ref int scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList);
            /*0x29d61ec*/ void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList);
            /*0x29d64bc*/ int GetFocusableInternalIndex(UnityEngine.UIElements.Focusable f);
            /*0x29d6564*/ UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e);
            /*0x29d69e4*/ UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction);

            enum DefaultFocusOrder
            {
                ChildOrder = 0,
                PositionXY = 1,
                PositionYX = 2,
            }

            class FocusRingRecord
            {
                /*0x10*/ int m_AutoIndex;
                /*0x18*/ UnityEngine.UIElements.Focusable m_Focusable;
                /*0x20*/ bool m_IsSlot;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder;

                /*0x29d64b4*/ FocusRingRecord();
            }
        }

        struct Spacing
        {
            /*0x10*/ float left;
            /*0x14*/ float top;
            /*0x18*/ float right;
            /*0x1c*/ float bottom;

            static /*0x29d6f7c*/ UnityEngine.Rect op_Subtraction(UnityEngine.Rect r, UnityEngine.UIElements.Spacing a);
            /*0x29d6f70*/ Spacing(float left, float top, float right, float bottom);
            /*0x29d6f50*/ float get_horizontal();
            /*0x29d6f60*/ float get_vertical();
        }

        class BindableElement : UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.IBindable
        {
            /*0x3b0*/ UnityEngine.UIElements.IBinding <binding>k__BackingField;
            /*0x3b8*/ string <bindingPath>k__BackingField;

            /*0x29d31b4*/ BindableElement();
            /*0x29d7044*/ UnityEngine.UIElements.IBinding get_binding();
            /*0x29d704c*/ void set_bindingPath(string value);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.BindableElement.UxmlTraits>
            {
                /*0x29d7054*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_PropertyPath;

                /*0x29d3870*/ UxmlTraits();
                /*0x29d36b4*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        enum GradientType
        {
            Linear = 0,
            Radial = 1,
        }

        enum AddressMode
        {
            Wrap = 0,
            Clamp = 1,
            Mirror = 2,
        }

        struct VectorImageVertex
        {
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Color32 tint;
            /*0x20*/ UnityEngine.Vector2 uv;
            /*0x28*/ uint settingIndex;
        }

        struct GradientSettings
        {
            /*0x10*/ UnityEngine.UIElements.GradientType gradientType;
            /*0x14*/ UnityEngine.UIElements.AddressMode addressMode;
            /*0x18*/ UnityEngine.Vector2 radialFocus;
            /*0x20*/ UnityEngine.RectInt location;
        }

        class VectorImage : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Texture2D atlas;
            /*0x20*/ UnityEngine.UIElements.VectorImageVertex[] vertices;
            /*0x28*/ ushort[] indices;
            /*0x30*/ UnityEngine.UIElements.GradientSettings[] settings;
            /*0x38*/ UnityEngine.Vector2 size;

            /*0x29d709c*/ VectorImage();
        }

        class Clickable : UnityEngine.UIElements.PointerManipulator
        {
            /*0x30*/ System.Action<UnityEngine.UIElements.EventBase> clickedWithEventInfo;
            /*0x38*/ System.Action clicked;
            /*0x40*/ long m_Delay;
            /*0x48*/ long m_Interval;
            /*0x50*/ bool <active>k__BackingField;
            /*0x54*/ UnityEngine.Vector2 <lastMousePosition>k__BackingField;
            /*0x5c*/ int m_ActivePointerId;
            /*0x60*/ bool m_AcceptClicksIfDisabled;
            /*0x68*/ UnityEngine.UIElements.IVisualElementScheduledItem m_Repeater;

            static /*0x29d87c0*/ bool IsNotMouseEvent(int pointerId);
            /*0x29d7134*/ Clickable(System.Action handler, long delay, long interval);
            /*0x29d7228*/ Clickable(System.Action<UnityEngine.UIElements.EventBase> handler);
            /*0x29d7160*/ Clickable(System.Action handler);
            /*0x29d7100*/ bool get_active();
            /*0x29d7108*/ void set_active(bool value);
            /*0x29d7114*/ UnityEngine.Vector2 get_lastMousePosition();
            /*0x29d711c*/ void set_lastMousePosition(UnityEngine.Vector2 value);
            /*0x29d7124*/ bool get_acceptClicksIfDisabled();
            /*0x29d712c*/ UnityEngine.UIElements.InvokePolicy get_invokePolicy();
            /*0x29d72f4*/ void OnTimer(UnityEngine.UIElements.TimerState timerState);
            /*0x29d73a0*/ bool IsRepeatable();
            /*0x29d74a4*/ void RegisterCallbacksOnTarget();
            /*0x29d79c4*/ void UnregisterCallbacksFromTarget();
            /*0x29d7ec0*/ void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt);
            /*0x29d7f78*/ void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt);
            /*0x29d7fe4*/ void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x29d80a4*/ void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt);
            /*0x29d8128*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x29d8440*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x29d8558*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x29d8738*/ void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x29d8824*/ void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt);
            /*0x29d73c4*/ bool ContainsPointer(int pointerId);
            /*0x29d744c*/ void Invoke(UnityEngine.UIElements.EventBase evt);
            /*0x29d88b8*/ void SimulateSingleClick(UnityEngine.UIElements.EventBase evt, int delayMs);
            /*0x29d8a8c*/ void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, int pointerId);
            /*0x29d8dec*/ void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition);
            /*0x29d8e60*/ void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, int pointerId);
            /*0x29d9008*/ void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, int pointerId);
            /*0x29d9174*/ void <SimulateSingleClick>b__43_0();
        }

        struct Cursor : System.IEquatable<UnityEngine.UIElements.Cursor>
        {
            /*0x10*/ UnityEngine.Texture2D <texture>k__BackingField;
            /*0x18*/ UnityEngine.Vector2 <hotspot>k__BackingField;
            /*0x20*/ int <defaultCursorId>k__BackingField;

            static /*0x29d93f0*/ bool op_Equality(UnityEngine.UIElements.Cursor style1, UnityEngine.UIElements.Cursor style2);
            /*0x29d91a8*/ UnityEngine.Texture2D get_texture();
            /*0x29d91b0*/ void set_texture(UnityEngine.Texture2D value);
            /*0x29d91b8*/ UnityEngine.Vector2 get_hotspot();
            /*0x29d91c0*/ void set_hotspot(UnityEngine.Vector2 value);
            /*0x29d91c8*/ int get_defaultCursorId();
            /*0x29d91d0*/ void set_defaultCursorId(int value);
            /*0x29d91d8*/ bool Equals(object obj);
            /*0x29d9268*/ bool Equals(UnityEngine.UIElements.Cursor other);
            /*0x29d9318*/ int GetHashCode();
            /*0x29d9420*/ string ToString();
        }

        interface ICursorManager
        {
            void SetCursor(UnityEngine.UIElements.Cursor cursor);
            void ResetCursor();
        }

        class CursorManager : UnityEngine.UIElements.ICursorManager
        {
            /*0x10*/ bool <isCursorOverriden>k__BackingField;

            /*0x29d9614*/ CursorManager();
            /*0x29d94a8*/ bool get_isCursorOverriden();
            /*0x29d94b0*/ void set_isCursorOverriden(bool value);
            /*0x29d94bc*/ void SetCursor(UnityEngine.UIElements.Cursor cursor);
            /*0x29d95ac*/ void ResetCursor();
        }

        interface ITextElement
        {
            string get_text();
        }

        class TextElement : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.ITextElement, UnityEngine.UIElements.INotifyValueChanged<string>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ int maxTextVertices;
            static /*0x10*/ string k_EllipsisText;
            /*0x3c0*/ UnityEngine.UIElements.ITextHandle m_TextHandle;
            /*0x3c8*/ string m_Text;
            /*0x3d0*/ bool m_EnableRichText;
            /*0x3d1*/ bool m_DisplayTooltipWhenElided;
            /*0x3d2*/ bool <isElided>k__BackingField;
            /*0x3d3*/ bool m_WasElided;
            /*0x3d4*/ bool m_UpdateTextParams;
            /*0x3d8*/ UnityEngine.UIElements.MeshGenerationContextUtils.TextParams m_TextParams;
            /*0x470*/ int m_PreviousTextParamsHashCode;

            static /*0x29da814*/ TextElement();
            /*0x29d961c*/ TextElement();
            /*0x29d97d4*/ UnityEngine.UIElements.ITextHandle get_textHandle();
            /*0x29d97dc*/ void set_textHandle(UnityEngine.UIElements.ITextHandle value);
            /*0x29d97e4*/ void HandleEvent(UnityEngine.UIElements.EventBase evt);
            /*0x29d9960*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e);
            /*0x29d9ae0*/ string get_text();
            /*0x29d9b74*/ void set_text(string value);
            /*0x29d9c1c*/ bool get_enableRichText();
            /*0x29d9c24*/ void set_enableRichText(bool value);
            /*0x29d9c44*/ bool get_displayTooltipWhenElided();
            /*0x29d9c4c*/ void set_displayTooltipWhenElided(bool value);
            /*0x29d9c88*/ bool get_isElided();
            /*0x29d9c90*/ void set_isElided(bool value);
            /*0x29d9c9c*/ void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x29d9f50*/ string ElideText(string drawText, string ellipsisText, float width, UnityEngine.UIElements.TextOverflowPosition textOverflowPosition);
            /*0x29d9ee4*/ void UpdateTooltip();
            /*0x29d9964*/ void UpdateVisibleText();
            /*0x29d9dbc*/ bool ShouldElide();
            /*0x29d9e24*/ bool TextLibraryCanElide();
            /*0x29da41c*/ UnityEngine.Vector2 MeasureTextSize(string textToMeasure, float width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x29da428*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x29da488*/ string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value();
            /*0x29da4dc*/ void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value);
            /*0x29da7a8*/ void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TextElement, UnityEngine.UIElements.TextElement.UxmlTraits>
            {
                /*0x29da8d4*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x80*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_EnableRichText;
                /*0x88*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;

                /*0x29daaa8*/ UxmlTraits();
                /*0x29da91c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class StyleCache
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<long, UnityEngine.UIElements.ComputedStyle> s_ComputedStyleCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.UIElements.StyleVariableContext> s_StyleVariableContextCache;
            static /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.UIElements.ComputedTransitionProperty[]> s_ComputedTransitionsCache;

            static /*0x29daf5c*/ StyleCache();
            static /*0x29dabc8*/ bool TryGetValue(long hash, ref UnityEngine.UIElements.ComputedStyle data);
            static /*0x29dac58*/ void SetValue(long hash, ref UnityEngine.UIElements.ComputedStyle data);
            static /*0x29dad1c*/ bool TryGetValue(int hash, ref UnityEngine.UIElements.StyleVariableContext data);
            static /*0x29dadac*/ void SetValue(int hash, UnityEngine.UIElements.StyleVariableContext data);
            static /*0x29dae3c*/ bool TryGetValue(int hash, ref UnityEngine.UIElements.ComputedTransitionProperty[] data);
            static /*0x29daecc*/ void SetValue(int hash, UnityEngine.UIElements.ComputedTransitionProperty[] data);
        }

        class VisualTreeStyleUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ApplyStyleUpdateList;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_TransitionPropertyUpdateList;
            /*0x30*/ bool m_IsApplyingStyles;
            /*0x34*/ uint m_Version;
            /*0x38*/ uint m_LastVersion;
            /*0x40*/ UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal;

            static /*0x29dbc6c*/ VisualTreeStyleUpdater();
            /*0x29db990*/ VisualTreeStyleUpdater();
            /*0x29db080*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x29db0d8*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x29db220*/ void Update();
            /*0x29db52c*/ void ApplyStyles();
        }

        class StyleMatchingContext
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_StyleSheetStack;
            /*0x18*/ UnityEngine.UIElements.StyleVariableContext variableContext;
            /*0x20*/ UnityEngine.UIElements.VisualElement currentElement;
            /*0x28*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult;

            /*0x29dbd40*/ StyleMatchingContext(System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult);
            /*0x29dbcf8*/ int get_styleSheetCount();
            /*0x29dbe04*/ void AddStyleSheet(UnityEngine.UIElements.StyleSheet sheet);
            /*0x29dbef0*/ void RemoveStyleSheetRange(int index, int count);
            /*0x29dbf58*/ UnityEngine.UIElements.StyleSheet GetStyleSheetAt(int index);
        }

        class VisualTreeStyleUpdaterTraversal : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
        {
            /*0x10*/ UnityEngine.UIElements.StyleVariableContext m_ProcessVarContext;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> m_TempMatchResults;
            /*0x30*/ float <currentPixelsPerPoint>k__BackingField;
            /*0x38*/ UnityEngine.UIElements.StyleMatchingContext m_StyleMatchingContext;
            /*0x40*/ UnityEngine.UIElements.StyleSheets.StylePropertyReader m_StylePropertyReader;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> m_AnimatedProperties;

            static /*0x29dc13c*/ void OnProcessMatchResult(UnityEngine.UIElements.VisualElement current, UnityEngine.UIElements.StyleSheets.MatchResultInfo info);
            /*0x29dba64*/ VisualTreeStyleUpdaterTraversal();
            /*0x29dbfb0*/ float get_currentPixelsPerPoint();
            /*0x29dbfb8*/ void set_currentPixelsPerPoint(float value);
            /*0x29db988*/ void PrepareTraversal(float pixelsPerPoint);
            /*0x29db1a0*/ void AddChangedElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x29db60c*/ void Clear();
            /*0x29dbfc0*/ void PropagateToChildren(UnityEngine.UIElements.VisualElement ve);
            /*0x29dc094*/ void PropagateToParents(UnityEngine.UIElements.VisualElement ve);
            /*0x29dc16c*/ void TraverseRecursive(UnityEngine.UIElements.VisualElement element, int depth);
            /*0x29dcfac*/ void ProcessTransitions(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle oldStyle, ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x29dd090*/ void ForceUpdateTransitions(UnityEngine.UIElements.VisualElement element);
            /*0x29db6b0*/ void CancelAnimationsWithNoTransitionProperty(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x29dc76c*/ bool ShouldSkipElement(UnityEngine.UIElements.VisualElement element);
            /*0x29dc7f0*/ UnityEngine.UIElements.ComputedStyle ProcessMatchedRules(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors);
            /*0x29dd324*/ void ProcessMatchedVariables(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> <>9__24_0;

                static /*0x29dd420*/ <>c();
                /*0x29dd484*/ <>c();
                /*0x29dd48c*/ int <ProcessMatchedRules>b__24_0(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b);
            }
        }

        class VisualElementExtensions
        {
            static /*0x29dd4d0*/ UnityEngine.Vector2 WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p);
            static /*0x29dd5bc*/ UnityEngine.Vector2 LocalToWorld(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p);
            static /*0x29dd6a8*/ UnityEngine.Rect WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Rect r);
            static /*0x29dd794*/ void AddManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator);
            static /*0x29dd840*/ void RemoveManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator);
        }

        enum PseudoStates
        {
            Active = 1,
            Hover = 2,
            Checked = 8,
            Disabled = 32,
            Focus = 64,
            Root = 128,
        }

        enum VisualElementFlags
        {
            WorldTransformDirty = 1,
            WorldTransformInverseDirty = 2,
            WorldClipDirty = 4,
            BoundingBoxDirty = 8,
            WorldBoundingBoxDirty = 16,
            LayoutManual = 32,
            CompositeRoot = 64,
            RequireMeasureFunction = 128,
            EnableViewDataPersistence = 256,
            DisableClipping = 512,
            NeedsAttachToPanelEvent = 1024,
            HierarchyDisplayed = 2048,
            StyleInitialized = 4096,
            Init = 2079,
        }

        enum PickingMode
        {
            Position = 0,
            Ignore = 1,
        }

        class VisualElementListPool
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>> pool;

            static /*0x29ddb28*/ VisualElementListPool();
            static /*0x29dd8e8*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements);
            static /*0x29dd994*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(int initialCapacity);
            static /*0x29dda74*/ void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements);
        }

        class ObjectListPool<T>
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>> pool;

            static ObjectListPool();
            static System.Collections.Generic.List<T> Get();
            static void Release(System.Collections.Generic.List<T> elements);
        }

        class PointerManipulator : UnityEngine.UIElements.MouseManipulator
        {
            /*0x2c*/ int m_CurrentPointerId;

            /*0x29d72f0*/ PointerManipulator();
            /*0x29d824c*/ bool CanStartManipulation(UnityEngine.UIElements.IPointerEvent e);
            /*0x29d8684*/ bool CanStopManipulation(UnityEngine.UIElements.IPointerEvent e);
        }

        enum KeyboardNavigationOperation
        {
            None = 0,
            SelectAll = 1,
            Cancel = 2,
            Submit = 3,
            Previous = 4,
            Next = 5,
            PageUp = 6,
            PageDown = 7,
            Begin = 8,
            End = 9,
        }

        class KeyboardNavigationManipulator : UnityEngine.UIElements.Manipulator
        {
            /*0x18*/ System.Action<UnityEngine.UIElements.KeyboardNavigationOperation, UnityEngine.UIElements.EventBase> m_Action;

            static /*0x29de208*/ UnityEngine.UIElements.KeyboardNavigationOperation <OnRuntimeKeyDown>g__GetOperation|5_0(ref UnityEngine.UIElements.KeyboardNavigationManipulator.<> );
            static /*0x29de2e4*/ UnityEngine.UIElements.KeyboardNavigationOperation <OnEditorKeyDown>g__GetOperation|6_0(ref UnityEngine.UIElements.KeyboardNavigationManipulator.<> );
            /*0x29ddbb8*/ KeyboardNavigationManipulator(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation, UnityEngine.UIElements.EventBase> action);
            /*0x29ddbe0*/ void RegisterCallbacksOnTarget();
            /*0x29dde34*/ void UnregisterCallbacksFromTarget();
            /*0x29de088*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x29de1bc*/ void OnRuntimeKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x29de170*/ void OnEditorKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x29de3d8*/ void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent evt);
            /*0x29de3fc*/ void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt);
            /*0x29de420*/ void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent evt);
            /*0x29de2c4*/ void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation operation, UnityEngine.UIElements.EventBase evt);

            struct <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UIElements.KeyDownEvent evt;
            }

            struct <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.UIElements.KeyDownEvent evt;
            }
        }

        interface IStylePropertyAnimationSystem
        {
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            void CancelAllAnimations();
            void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner);
            void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds);
            void Update();
        }

        class StylePropertyAnimationSystem : UnityEngine.UIElements.IStylePropertyAnimationSystem
        {
            /*0x10*/ long m_CurrentTimeMs;
            /*0x18*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFloat m_Floats;
            /*0x20*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesInt m_Ints;
            /*0x28*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesLength m_Lengths;
            /*0x30*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesColor m_Colors;
            /*0x38*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesBackground m_Backgrounds;
            /*0x40*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions;
            /*0x48*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFont m_Fonts;
            /*0x50*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows;
            /*0x58*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesScale m_Scale;
            /*0x60*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesRotate m_Rotate;
            /*0x68*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTranslate m_Translate;
            /*0x70*/ UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin;
            /*0x78*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_AllValues;
            /*0x80*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_PropertyToValues;

            /*0x29de488*/ StylePropertyAnimationSystem();
            T GetOrCreate<T>(ref T values);
            bool StartTransition<T>(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values);
            /*0x29de57c*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29de644*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29de71c*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29de7f4*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29de904*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29de9fc*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29deaec*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29debc4*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29decdc*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29dedcc*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29deee4*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29deffc*/ bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x29df114*/ void CancelAllAnimations();
            /*0x29df264*/ void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner);
            /*0x29df518*/ void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x29df5a8*/ void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x29df638*/ void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds);
            void UpdateTracking<T>(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values);
            /*0x29df790*/ long CurrentTimeMs();
            /*0x29df798*/ void Update();

            enum TransitionState
            {
                None = 0,
                Running = 1,
                Started = 2,
                Ended = 4,
                Canceled = 8,
            }

            struct AnimationDataSet<TTimingData, TStyleData>
            {
                /*0x0*/ UnityEngine.UIElements.VisualElement[] elements;
                /*0x0*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] properties;
                /*0x0*/ TTimingData[] timing;
                /*0x0*/ TStyleData[] style;
                /*0x0*/ int count;
                /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair, int> indices;

                static UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData> Create();
                int get_capacity();
                void set_capacity(int value);
                void LocalInit();
                bool IndexOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, ref int index);
                void Add(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TTimingData timingData, TStyleData styleData);
                void Remove(int cancelledIndex);
                void Replace(int index, TTimingData timingData, TStyleData styleData);
                void RemoveAll(UnityEngine.UIElements.VisualElement ve);
                void RemoveAll();
                void GetActivePropertiesForElement(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties);
            }

            struct ElementPropertyPair
            {
                static /*0x0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair> Comparer;
                /*0x10*/ UnityEngine.UIElements.VisualElement element;
                /*0x18*/ UnityEngine.UIElements.StyleSheets.StylePropertyId property;

                static /*0x29df878*/ ElementPropertyPair();
                /*0x29df86c*/ ElementPropertyPair(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId property);

                class EqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair>
                {
                    /*0x29df8f0*/ EqualityComparer();
                    /*0x29df8f8*/ bool Equals(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair x, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair y);
                    /*0x29df910*/ int GetHashCode(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair obj);
                }
            }

            class Values
            {
                /*0x29df944*/ Values();
                void CancelAllAnimations();
                void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve);
                void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
                void Update(long currentTimeMs);
                void UpdateValues();
                void UpdateComputedStyle();
                void UpdateComputedStyle(int i);
            }

            class Values<T> : UnityEngine.UIElements.StylePropertyAnimationSystem.Values
            {
                /*0x0*/ long m_CurrentTimeMs;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_CurrentFrameEventsState;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_NextFrameEventsState;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TimingData<T>, UnityEngine.UIElements.StylePropertyAnimationSystem.Values.StyleData<T>> running;
                /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>, T> completed;

                Values();
                bool get_isEmpty();
                System.Func<T, T, bool> get_SameFunc();
                void SwapFrameStates();
                void QueueEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp);
                void ClearEventQueue(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp);
                void QueueTransitionRunEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex);
                void QueueTransitionStartEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex);
                void QueueTransitionEndEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex);
                void QueueTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex, long panelElapsedMs);
                void SendTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, int runningIndex, long panelElapsedMs);
                void CancelAllAnimations();
                void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve);
                void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds);
                float ComputeReversingShorteningFactor(int oldIndex);
                int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor);
                int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor);
                bool StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<float, float> easingCurve, long currentTimeMs);
                void ForceComputedStyleEndValue(int runningIndex);
                void Update(long currentTimeMs);
                void ProcessEventQueue();
                void UpdateProgress(long currentTimeMs);

                class TransitionEventsFrameState<T>
                {
                    static /*0x0*/ UnityEngine.Pool.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> k_EventQueuePool;
                    /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair, UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta;
                    /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair, System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> elementPropertyQueuedEvents;
                    /*0x0*/ UnityEngine.UIElements.IPanel panel;
                    /*0x0*/ int m_ChangesCount;

                    static TransitionEventsFrameState();
                    static System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue();
                    TransitionEventsFrameState();
                    void RegisterChange();
                    void UnregisterChange();
                    bool StateChanged();
                    void Clear();

                    class <>c<T>
                    {
                        static /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> <>9;

                        static <>c();
                        <>c();
                        System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> <.cctor>b__11_0();
                    }
                }

                struct TimingData<T>
                {
                    /*0x0*/ long startTimeMs;
                    /*0x0*/ int durationMs;
                    /*0x0*/ System.Func<float, float> easingCurve;
                    /*0x0*/ float easedProgress;
                    /*0x0*/ float reversingShorteningFactor;
                    /*0x0*/ bool isStarted;
                    /*0x0*/ int delayMs;
                }

                struct StyleData<T>
                {
                    /*0x0*/ T startValue;
                    /*0x0*/ T endValue;
                    /*0x0*/ T reversingAdjustedStartValue;
                    /*0x0*/ T currentValue;
                }

                struct EmptyData<T>
                {
                    static /*0x0*/ UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T> Default;

                    static EmptyData();
                }
            }

            class ValuesFloat : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<float>
            {
                /*0x88*/ System.Func<float, float, bool> <SameFunc>k__BackingField;

                static /*0x29df954*/ bool IsSame(float a, float b);
                static /*0x29df9dc*/ float Lerp(float a, float b, float t);
                /*0x29dfbe0*/ ValuesFloat();
                /*0x29df94c*/ System.Func<float, float, bool> get_SameFunc();
                /*0x29df9ec*/ void UpdateValues();
                /*0x29dfa6c*/ void UpdateComputedStyle();
                /*0x29dfb38*/ void UpdateComputedStyle(int i);
            }

            class ValuesInt : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<int>
            {
                /*0x88*/ System.Func<int, int, bool> <SameFunc>k__BackingField;

                static /*0x29dfc80*/ bool IsSame(int a, int b);
                static /*0x29dfc8c*/ int Lerp(int a, int b, float t);
                /*0x29dff84*/ ValuesInt();
                /*0x29dfc78*/ System.Func<int, int, bool> get_SameFunc();
                /*0x29dfd78*/ void UpdateValues();
                /*0x29dfe10*/ void UpdateComputedStyle();
                /*0x29dfedc*/ void UpdateComputedStyle(int i);
            }

            class ValuesLength : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Length>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, bool> <SameFunc>k__BackingField;

                static /*0x29e0024*/ bool IsSame(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b);
                static /*0x29e00c4*/ UnityEngine.UIElements.Length Lerp(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b, float t);
                /*0x29e0330*/ ValuesLength();
                /*0x29e001c*/ System.Func<UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, bool> get_SameFunc();
                /*0x29e0100*/ void UpdateValues();
                /*0x29e01bc*/ void UpdateComputedStyle();
                /*0x29e0288*/ void UpdateComputedStyle(int i);
            }

            class ValuesColor : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.Color>
            {
                /*0x88*/ System.Func<UnityEngine.Color, UnityEngine.Color, bool> <SameFunc>k__BackingField;

                static /*0x29e03d0*/ bool IsSame(UnityEngine.Color c, UnityEngine.Color d);
                static /*0x29e0508*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
                /*0x29e0740*/ ValuesColor();
                /*0x29e03c8*/ System.Func<UnityEngine.Color, UnityEngine.Color, bool> get_SameFunc();
                /*0x29e0540*/ void UpdateValues();
                /*0x29e05c4*/ void UpdateComputedStyle();
                /*0x29e0694*/ void UpdateComputedStyle(int i);
            }

            class ValuesDiscrete<T> : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T>
            {
                /*0x0*/ System.Func<T, T, bool> <SameFunc>k__BackingField;

                static bool IsSame(T a, T b);
                static T Lerp(T a, T b, float t);
                ValuesDiscrete();
                System.Func<T, T, bool> get_SameFunc();
                void UpdateValues();
            }

            class ValuesBackground : UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesDiscrete<UnityEngine.UIElements.Background>
            {
                /*0x29e0970*/ ValuesBackground();
                /*0x29e07d8*/ void UpdateComputedStyle();
                /*0x29e08b4*/ void UpdateComputedStyle(int i);
            }

            class ValuesFontDefinition : UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesDiscrete<UnityEngine.UIElements.FontDefinition>
            {
                /*0x29e0b2c*/ ValuesFontDefinition();
                /*0x29e09b8*/ void UpdateComputedStyle();
                /*0x29e0a84*/ void UpdateComputedStyle(int i);
            }

            class ValuesFont : UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesDiscrete<UnityEngine.Font>
            {
                /*0x29e0ce8*/ ValuesFont();
                /*0x29e0b74*/ void UpdateComputedStyle();
                /*0x29e0c40*/ void UpdateComputedStyle(int i);
            }

            class ValuesTextShadow : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.TextShadow>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, bool> <SameFunc>k__BackingField;

                static /*0x29e0d38*/ bool IsSame(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b);
                static /*0x29e0d7c*/ UnityEngine.UIElements.TextShadow Lerp(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, float t);
                /*0x29e1064*/ ValuesTextShadow();
                /*0x29e0d30*/ System.Func<UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, bool> get_SameFunc();
                /*0x29e0dd4*/ void UpdateValues();
                /*0x29e0ea0*/ void UpdateComputedStyle();
                /*0x29e0f90*/ void UpdateComputedStyle(int i);
            }

            class ValuesScale : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Scale>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, bool> <SameFunc>k__BackingField;

                static /*0x29e1104*/ bool IsSame(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b);
                static /*0x29e1280*/ UnityEngine.UIElements.Scale Lerp(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b, float t);
                /*0x29e138c*/ ValuesScale();
                /*0x29e10fc*/ System.Func<UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, bool> get_SameFunc();
                /*0x29e110c*/ void UpdateComputedStyle();
                /*0x29e11d8*/ void UpdateComputedStyle(int i);
                /*0x29e12f0*/ void UpdateValues();
            }

            class ValuesRotate : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Rotate>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, bool> <SameFunc>k__BackingField;

                static /*0x29e142c*/ bool IsSame(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b);
                static /*0x29e1628*/ UnityEngine.UIElements.Rotate Lerp(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b, float t);
                /*0x29e1784*/ ValuesRotate();
                /*0x29e1424*/ System.Func<UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, bool> get_SameFunc();
                /*0x29e1474*/ void UpdateComputedStyle();
                /*0x29e155c*/ void UpdateComputedStyle(int i);
                /*0x29e16a8*/ void UpdateValues();
            }

            class ValuesTranslate : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.Translate>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, bool> <SameFunc>k__BackingField;

                static /*0x29e1824*/ bool IsSame(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b);
                static /*0x29e1a20*/ UnityEngine.UIElements.Translate Lerp(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b, float t);
                /*0x29e1bd0*/ ValuesTranslate();
                /*0x29e181c*/ System.Func<UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, bool> get_SameFunc();
                /*0x29e186c*/ void UpdateComputedStyle();
                /*0x29e1954*/ void UpdateComputedStyle(int i);
                /*0x29e1af4*/ void UpdateValues();
            }

            class ValuesTransformOrigin : UnityEngine.UIElements.StylePropertyAnimationSystem.Values<UnityEngine.UIElements.TransformOrigin>
            {
                /*0x88*/ System.Func<UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, bool> <SameFunc>k__BackingField;

                static /*0x29e1c70*/ bool IsSame(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b);
                static /*0x29e1e6c*/ UnityEngine.UIElements.TransformOrigin Lerp(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b, float t);
                /*0x29e201c*/ ValuesTransformOrigin();
                /*0x29e1c68*/ System.Func<UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, bool> get_SameFunc();
                /*0x29e1cb8*/ void UpdateComputedStyle();
                /*0x29e1da0*/ void UpdateComputedStyle(int i);
                /*0x29e1f40*/ void UpdateValues();
            }
        }

        class ImmediateModeException : System.Exception
        {
            /*0x29e20b4*/ ImmediateModeException(System.Exception inner);
        }

        interface IExperimentalFeatures
        {
            UnityEngine.UIElements.Experimental.ITransitionAnimations get_animation();
        }

        struct VisualElementStyleSheetSet : System.IEquatable<UnityEngine.UIElements.VisualElementStyleSheetSet>
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement m_Element;

            /*0x29e2134*/ VisualElementStyleSheetSet(UnityEngine.UIElements.VisualElement element);
            /*0x29e213c*/ void Add(UnityEngine.UIElements.StyleSheet styleSheet);
            /*0x29e230c*/ bool Remove(UnityEngine.UIElements.StyleSheet styleSheet);
            /*0x29e2440*/ bool Equals(UnityEngine.UIElements.VisualElementStyleSheetSet other);
            /*0x29e244c*/ bool Equals(object obj);
            /*0x29e24c8*/ int GetHashCode();
        }

        interface IGroupManager
        {
            void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption);
            void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option);
            void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option);
        }

        class DefaultGroupManager : UnityEngine.UIElements.IGroupManager
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption> m_GroupOptions;
            /*0x18*/ UnityEngine.UIElements.IGroupBoxOption m_SelectedOption;

            /*0x29e27dc*/ DefaultGroupManager();
            /*0x29e24e0*/ void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption);
            /*0x29e26b0*/ void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option);
            /*0x29e2784*/ void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option);
        }

        enum ContextType
        {
            Player = 0,
            Editor = 1,
        }

        enum VersionChangeType
        {
            Bindings = 1,
            ViewData = 2,
            Hierarchy = 4,
            Layout = 8,
            StyleSheet = 16,
            Styles = 32,
            Overflow = 64,
            BorderRadius = 128,
            BorderWidth = 256,
            Transform = 512,
            Size = 1024,
            Repaint = 2048,
            Opacity = 4096,
            Color = 8192,
            RenderHints = 16384,
            TransitionProperty = 32768,
        }

        enum UsageHints
        {
            None = 0,
            DynamicTransform = 1,
            GroupTransform = 2,
            MaskContainer = 4,
            DynamicColor = 8,
        }

        enum RenderHints
        {
            None = 0,
            GroupTransform = 1,
            BoneTransform = 2,
            ClipWithScissors = 4,
            MaskContainer = 8,
            DynamicColor = 16,
            DirtyOffset = 5,
            DirtyGroupTransform = 32,
            DirtyBoneTransform = 64,
            DirtyClipWithScissors = 128,
            DirtyMaskContainer = 256,
            DirtyAll = 480,
        }

        struct PanelClearSettings
        {
            /*0x10*/ bool clearDepthStencil;
            /*0x11*/ bool clearColor;
            /*0x14*/ UnityEngine.Color color;
        }

        class RepaintData
        {
            /*0x10*/ UnityEngine.Matrix4x4 <currentOffset>k__BackingField;
            /*0x50*/ UnityEngine.Vector2 <mousePosition>k__BackingField;
            /*0x58*/ UnityEngine.Rect <currentWorldClip>k__BackingField;
            /*0x68*/ UnityEngine.Event <repaintEvent>k__BackingField;

            /*0x29e2888*/ RepaintData();
            /*0x29e2858*/ UnityEngine.Matrix4x4 get_currentOffset();
            /*0x29e286c*/ UnityEngine.Rect get_currentWorldClip();
            /*0x29e2878*/ UnityEngine.Event get_repaintEvent();
            /*0x29e2880*/ void set_repaintEvent(UnityEngine.Event value);
        }

        class HierarchyEvent : System.MulticastDelegate
        {
            /*0x29e28e8*/ HierarchyEvent(object object, nint method);
            /*0x29e2a18*/ void Invoke(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType);
        }

        interface IPanel : System.IDisposable
        {
            UnityEngine.UIElements.VisualElement get_visualTree();
            UnityEngine.UIElements.EventDispatcher get_dispatcher();
            UnityEngine.UIElements.ContextType get_contextType();
            UnityEngine.UIElements.FocusController get_focusController();
            UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point);
        }

        class BaseVisualElementPanel : UnityEngine.UIElements.IPanel, System.IDisposable, UnityEngine.UIElements.IGroupBox
        {
            /*0x10*/ System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelDisposed;
            /*0x18*/ float m_Scale;
            /*0x20*/ UnityEngine.Yoga.YogaConfig yogaConfig;
            /*0x28*/ float m_PixelsPerPoint;
            /*0x2c*/ UnityEngine.UIElements.PanelClearSettings <clearSettings>k__BackingField;
            /*0x40*/ bool <duringLayoutPhase>k__BackingField;
            /*0x48*/ UnityEngine.UIElements.RepaintData <repaintData>k__BackingField;
            /*0x50*/ UnityEngine.UIElements.ICursorManager <cursorManager>k__BackingField;
            /*0x58*/ UnityEngine.UIElements.ContextualMenuManager <contextualMenuManager>k__BackingField;
            /*0x60*/ bool <disposed>k__BackingField;
            /*0x68*/ UnityEngine.UIElements.ElementUnderPointer m_TopElementUnderPointers;
            /*0x70*/ System.Action standardShaderChanged;
            /*0x78*/ System.Action standardWorldSpaceShaderChanged;
            /*0x80*/ System.Action atlasChanged;
            /*0x88*/ System.Action<UnityEngine.Material> updateMaterial;
            /*0x90*/ UnityEngine.UIElements.HierarchyEvent hierarchyChanged;
            /*0x98*/ System.Action<UnityEngine.UIElements.IPanel> beforeUpdate;

            /*0x29e2b8c*/ BaseVisualElementPanel();
            UnityEngine.EventInterests get_IMGUIEventInterests();
            void set_IMGUIEventInterests(UnityEngine.EventInterests value);
            UnityEngine.ScriptableObject get_ownerObject();
            void set_ownerObject(UnityEngine.ScriptableObject value);
            UnityEngine.UIElements.SavePersistentViewData get_saveViewData();
            UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary();
            int get_IMGUIContainersCount();
            void set_IMGUIContainersCount(int value);
            UnityEngine.UIElements.FocusController get_focusController();
            void set_focusController(UnityEngine.UIElements.FocusController value);
            UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer();
            /*0x29e2a2c*/ void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x29e2adc*/ void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value);
            /*0x29e2c74*/ void Dispose();
            /*0x29e2ce4*/ void Dispose(bool disposing);
            void Repaint(UnityEngine.Event e);
            void ValidateLayout();
            void UpdateAnimations();
            void UpdateBindings();
            void ApplyStyles();
            /*0x29e2e20*/ float get_scale();
            /*0x29e2e28*/ void set_scale(float value);
            /*0x29e2f34*/ void set_pixelsPerPoint(float value);
            /*0x29db978*/ float get_scaledPixelsPerPoint();
            /*0x29e3040*/ UnityEngine.UIElements.PanelClearSettings get_clearSettings();
            /*0x29e3054*/ void set_clearSettings(UnityEngine.UIElements.PanelClearSettings value);
            /*0x29e3068*/ bool get_duringLayoutPhase();
            /*0x29e3070*/ void set_duringLayoutPhase(bool value);
            uint get_version();
            uint get_hierarchyVersion();
            void OnVersionChanged(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.VersionChangeType changeTypeFlag);
            /*0x29e307c*/ UnityEngine.UIElements.RepaintData get_repaintData();
            /*0x29e3084*/ void set_repaintData(UnityEngine.UIElements.RepaintData value);
            /*0x29e308c*/ UnityEngine.UIElements.ICursorManager get_cursorManager();
            /*0x29e3094*/ void set_cursorManager(UnityEngine.UIElements.ICursorManager value);
            /*0x29e309c*/ UnityEngine.UIElements.ContextualMenuManager get_contextualMenuManager();
            /*0x29e30a4*/ void set_contextualMenuManager(UnityEngine.UIElements.ContextualMenuManager value);
            UnityEngine.UIElements.VisualElement get_visualTree();
            UnityEngine.UIElements.EventDispatcher get_dispatcher();
            void set_dispatcher(UnityEngine.UIElements.EventDispatcher value);
            /*0x29e30ac*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode);
            UnityEngine.UIElements.IScheduler get_scheduler();
            UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem();
            void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value);
            UnityEngine.UIElements.ContextType get_contextType();
            void set_contextType(UnityEngine.UIElements.ContextType value);
            UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point);
            UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            /*0x29e3170*/ bool get_disposed();
            /*0x29e3178*/ void set_disposed(bool value);
            UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
            /*0x29d889c*/ UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(int pointerId);
            /*0x29e3184*/ UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(int pointerId, UnityEngine.Vector2 pointerPos, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x29e32b8*/ void ClearCachedElementUnderPointer(int pointerId, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x29e32e0*/ void CommitElementUnderPointers();
            UnityEngine.Shader get_standardShader();
            /*0x29e333c*/ UnityEngine.Shader get_standardWorldSpaceShader();
            /*0x29e3344*/ void add_standardShaderChanged(System.Action value);
            /*0x29e33e0*/ void remove_standardShaderChanged(System.Action value);
            /*0x29e347c*/ void add_standardWorldSpaceShaderChanged(System.Action value);
            /*0x29e3518*/ void remove_standardWorldSpaceShaderChanged(System.Action value);
            /*0x29e35b4*/ void add_atlasChanged(System.Action value);
            /*0x29e3650*/ void remove_atlasChanged(System.Action value);
            /*0x29e36ec*/ void InvokeAtlasChanged();
            UnityEngine.UIElements.AtlasBase get_atlas();
            void set_atlas(UnityEngine.UIElements.AtlasBase value);
            /*0x29e3708*/ void InvokeUpdateMaterial(UnityEngine.Material mat);
            /*0x29e3724*/ void add_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value);
            /*0x29e37c0*/ void remove_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value);
            /*0x29e385c*/ void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType);
            /*0x29e3878*/ void InvokeBeforeUpdate();
            /*0x29d4568*/ void UpdateElementUnderPointers();
            /*0x29e3898*/ void Update();
        }

        class LoadResourceFunction : System.MulticastDelegate
        {
            /*0x29e398c*/ LoadResourceFunction(object object, nint method);
            /*0x29e3a64*/ UnityEngine.Object Invoke(string pathName, System.Type type, float dpiScaling);
        }

        class TimeMsFunction : System.MulticastDelegate
        {
            /*0x29e3a78*/ TimeMsFunction(object object, nint method);
            /*0x29e3b34*/ long Invoke();
        }

        class GetViewDataDictionary : System.MulticastDelegate
        {
            /*0x29e3b48*/ GetViewDataDictionary(object object, nint method);
            /*0x29e3c04*/ UnityEngine.UIElements.ISerializableJsonDictionary Invoke();
        }

        class SavePersistentViewData : System.MulticastDelegate
        {
            /*0x29e3c18*/ SavePersistentViewData(object object, nint method);
            /*0x29e3cd4*/ void Invoke();
        }

        class Panel : UnityEngine.UIElements.BaseVisualElementPanel
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerPickAll;
            static /*0x8*/ UnityEngine.UIElements.LoadResourceFunction <loadResourceFunc>k__BackingField;
            static /*0x10*/ UnityEngine.UIElements.TimeMsFunction <TimeSinceStartup>k__BackingField;
            static /*0x18*/ System.Action<UnityEngine.UIElements.Panel> beforeAnyRepaint;
            /*0xa0*/ UnityEngine.UIElements.VisualElement m_RootContainer;
            /*0xa8*/ UnityEngine.UIElements.VisualTreeUpdater m_VisualTreeUpdater;
            /*0xb0*/ UnityEngine.UIElements.IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;
            /*0xb8*/ string m_PanelName;
            /*0xc0*/ uint m_Version;
            /*0xc4*/ uint m_RepaintVersion;
            /*0xc8*/ uint m_HierarchyVersion;
            /*0xd0*/ Unity.Profiling.ProfilerMarker m_MarkerBeforeUpdate;
            /*0xd8*/ Unity.Profiling.ProfilerMarker m_MarkerUpdate;
            /*0xe0*/ Unity.Profiling.ProfilerMarker m_MarkerLayout;
            /*0xe8*/ Unity.Profiling.ProfilerMarker m_MarkerBindings;
            /*0xf0*/ Unity.Profiling.ProfilerMarker m_MarkerAnimations;
            /*0xf8*/ UnityEngine.UIElements.EventDispatcher <dispatcher>k__BackingField;
            /*0x100*/ UnityEngine.UIElements.TimerEventScheduler m_Scheduler;
            /*0x108*/ UnityEngine.ScriptableObject <ownerObject>k__BackingField;
            /*0x110*/ UnityEngine.UIElements.ContextType <contextType>k__BackingField;
            /*0x118*/ UnityEngine.UIElements.SavePersistentViewData <saveViewData>k__BackingField;
            /*0x120*/ UnityEngine.UIElements.GetViewDataDictionary <getViewDataDictionary>k__BackingField;
            /*0x128*/ UnityEngine.UIElements.FocusController <focusController>k__BackingField;
            /*0x130*/ UnityEngine.EventInterests <IMGUIEventInterests>k__BackingField;
            /*0x134*/ int <IMGUIContainersCount>k__BackingField;
            /*0x138*/ UnityEngine.UIElements.IMGUIContainer <rootIMGUIContainer>k__BackingField;
            /*0x140*/ UnityEngine.Shader m_StandardShader;
            /*0x148*/ UnityEngine.UIElements.AtlasBase m_Atlas;
            /*0x150*/ bool m_ValidatingLayout;

            static /*0x29e5364*/ Panel();
            static /*0x29e3e8c*/ UnityEngine.UIElements.LoadResourceFunction get_loadResourceFunc();
            static /*0x29e3ee4*/ UnityEngine.Object LoadResource(string pathName, System.Type type, float dpiScaling);
            static /*0x29e426c*/ UnityEngine.UIElements.TimeMsFunction get_TimeSinceStartup();
            static /*0x29d1990*/ long TimeSinceStartupMs();
            static /*0x29e4764*/ long DefaultTimeSinceStartupMs();
            static /*0x29e479c*/ UnityEngine.UIElements.VisualElement PickAll(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            static /*0x29e4818*/ UnityEngine.UIElements.VisualElement PerformPick(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            static /*0x29e4d48*/ UnityEngine.Vector2Int <Pick>g__PixelOf|99_0(UnityEngine.Vector2 p);
            /*0x29e4370*/ Panel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.EventDispatcher dispatcher);
            /*0x29e3ce8*/ UnityEngine.UIElements.VisualElement get_visualTree();
            /*0x29e3cf0*/ UnityEngine.UIElements.EventDispatcher get_dispatcher();
            /*0x29e3cf8*/ void set_dispatcher(UnityEngine.UIElements.EventDispatcher value);
            /*0x29e3d00*/ UnityEngine.UIElements.TimerEventScheduler get_timerEventScheduler();
            /*0x29e3d6c*/ UnityEngine.UIElements.IScheduler get_scheduler();
            /*0x29e3d70*/ UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem();
            /*0x29e3d78*/ void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value);
            /*0x29e3e2c*/ UnityEngine.ScriptableObject get_ownerObject();
            /*0x29e3e34*/ void set_ownerObject(UnityEngine.ScriptableObject value);
            /*0x29e3e3c*/ UnityEngine.UIElements.ContextType get_contextType();
            /*0x29e3e44*/ void set_contextType(UnityEngine.UIElements.ContextType value);
            /*0x29e3e4c*/ UnityEngine.UIElements.SavePersistentViewData get_saveViewData();
            /*0x29e3e54*/ UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary();
            /*0x29e3e5c*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x29e3e64*/ void set_focusController(UnityEngine.UIElements.FocusController value);
            /*0x29e3e6c*/ UnityEngine.EventInterests get_IMGUIEventInterests();
            /*0x29e3e7c*/ void set_IMGUIEventInterests(UnityEngine.EventInterests value);
            /*0x29cf478*/ void Focus();
            /*0x29cf44c*/ void Blur();
            /*0x29e4010*/ string get_name();
            /*0x29e4018*/ void set_name(string value);
            /*0x29e4020*/ void CreateMarkers();
            /*0x29e42c4*/ int get_IMGUIContainersCount();
            /*0x29e42cc*/ void set_IMGUIContainersCount(int value);
            /*0x29e42d4*/ UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer();
            /*0x29e42dc*/ uint get_version();
            /*0x29e42e4*/ uint get_hierarchyVersion();
            /*0x29e42ec*/ UnityEngine.Shader get_standardShader();
            /*0x29e42f4*/ UnityEngine.UIElements.AtlasBase get_atlas();
            /*0x29e42fc*/ void set_atlas(UnityEngine.UIElements.AtlasBase value);
            /*0x29e46fc*/ void Dispose(bool disposing);
            /*0x29e4afc*/ UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked);
            /*0x29e4bd4*/ UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point);
            /*0x29e4e40*/ void ValidateLayout();
            /*0x29e4ea4*/ void UpdateAnimations();
            /*0x29e4ec4*/ void UpdateBindings();
            /*0x29e4ee4*/ void ApplyStyles();
            /*0x29e4f04*/ void UpdateForRepaint();
            /*0x29e4f78*/ void Repaint(UnityEngine.Event e);
            /*0x29e52fc*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x29e5348*/ UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase);
        }

        class BaseRuntimePanel : UnityEngine.UIElements.Panel
        {
            static /*0x0*/ int s_CurrentRuntimePanelCounter;
            static /*0x8*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> DefaultScreenToPanelSpace;
            /*0x158*/ UnityEngine.GameObject m_SelectableGameObject;
            /*0x160*/ int m_RuntimePanelCreationIndex;
            /*0x164*/ float m_SortingPriority;
            /*0x168*/ System.Action destroyed;
            /*0x170*/ UnityEngine.Shader m_StandardWorldSpaceShader;
            /*0x178*/ bool m_DrawToCameras;
            /*0x180*/ UnityEngine.RenderTexture targetTexture;
            /*0x188*/ UnityEngine.Matrix4x4 panelToWorld;
            /*0x1c8*/ int <targetDisplay>k__BackingField;
            /*0x1d0*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> m_ScreenToPanelSpace;

            static /*0x2a12b60*/ BaseRuntimePanel();
            /*0x2a12270*/ BaseRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.EventDispatcher dispatcher);
            /*0x2a11c04*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x2a11c0c*/ void set_selectableGameObject(UnityEngine.GameObject value);
            /*0x2a11fd4*/ float get_sortingPriority();
            /*0x2a11fdc*/ void set_sortingPriority(float value);
            /*0x2a12130*/ void add_destroyed(System.Action value);
            /*0x2a121d0*/ void remove_destroyed(System.Action value);
            /*0x2a12380*/ void Dispose(bool disposing);
            /*0x2a123d8*/ UnityEngine.Shader get_standardWorldSpaceShader();
            /*0x2a123e0*/ bool get_drawToCameras();
            /*0x2a123e8*/ void set_drawToCameras(bool value);
            /*0x2a12498*/ int get_targetDisplay();
            /*0x2a124a0*/ void set_targetDisplay(int value);
            /*0x2a124a8*/ int get_screenRenderingWidth();
            /*0x2a12574*/ int get_screenRenderingHeight();
            /*0x2a12640*/ void Repaint(UnityEngine.Event e);
            /*0x2a12828*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> get_screenToPanelSpace();
            /*0x2a12830*/ void set_screenToPanelSpace(System.Func<UnityEngine.Vector2, UnityEngine.Vector2> value);
            /*0x2a128a8*/ UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2 screen);
            /*0x2a128fc*/ bool ScreenToPanel(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenDelta, ref UnityEngine.Vector2 panelPosition, ref UnityEngine.Vector2 panelDelta, bool allowOutside);
            /*0x2a11ca8*/ void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x2a12a00*/ void PointerLeavesPanel(int pointerId, UnityEngine.Vector2 position);
            /*0x2a12ac0*/ void PointerEntersPanel(int pointerId, UnityEngine.Vector2 position);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.BaseRuntimePanel.<> <>9;

                static /*0x2a12c38*/ <>c();
                /*0x2a12c9c*/ <>c();
                /*0x2a12ca4*/ UnityEngine.Vector2 <.cctor>b__44_0(UnityEngine.Vector2 p);
            }
        }

        interface IRuntimePanelComponent
        {
            void set_panel(UnityEngine.UIElements.IPanel value);
        }

        class DisposeHelper
        {
            static /*0x2a12ca8*/ void NotifyDisposedUsed(System.IDisposable disposable);
        }

        class Focusable : UnityEngine.UIElements.CallbackEventHandler
        {
            /*0x18*/ bool <focusable>k__BackingField;
            /*0x1c*/ int <tabIndex>k__BackingField;
            /*0x20*/ bool m_DelegatesFocus;
            /*0x21*/ bool m_ExcludeFromFocusRing;
            /*0x22*/ bool isIMGUIContainer;

            static /*0x2a1325c*/ UnityEngine.UIElements.Focusable GetFirstFocusableChild(UnityEngine.UIElements.VisualElement ve);
            /*0x2a12d70*/ Focusable();
            UnityEngine.UIElements.FocusController get_focusController();
            /*0x2a12d98*/ bool get_focusable();
            /*0x2a12da0*/ void set_focusable(bool value);
            /*0x2a12dac*/ int get_tabIndex();
            /*0x2a12db4*/ void set_tabIndex(int value);
            /*0x2a12dbc*/ bool get_delegatesFocus();
            /*0x2a12dc4*/ void set_delegatesFocus(bool value);
            /*0x2a12ea8*/ bool get_excludeFromFocusRing();
            /*0x2a12eb0*/ void set_excludeFromFocusRing(bool value);
            /*0x2a12f94*/ bool get_canGrabFocus();
            /*0x2a12f9c*/ void Focus();
            /*0x2a13194*/ void Blur();
            /*0x2a13224*/ void BlurImmediately();
            /*0x2a1304c*/ UnityEngine.UIElements.Focusable GetFocusDelegate();
            /*0x2a1337c*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x2a13408*/ void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt);
            /*0x2a133a8*/ void ProcessEvent(UnityEngine.UIElements.EventBase evt);
        }

        class FocusChangeDirection : System.IDisposable
        {
            static /*0x0*/ UnityEngine.UIElements.FocusChangeDirection <unspecified>k__BackingField;
            static /*0x8*/ UnityEngine.UIElements.FocusChangeDirection <none>k__BackingField;
            static /*0x10*/ UnityEngine.UIElements.FocusChangeDirection <lastValue>k__BackingField;
            /*0x10*/ int m_Value;

            static /*0x2a13b28*/ FocusChangeDirection();
            static /*0x2a13720*/ UnityEngine.UIElements.FocusChangeDirection get_unspecified();
            static /*0x2a13778*/ UnityEngine.UIElements.FocusChangeDirection get_none();
            static /*0x2a137d0*/ UnityEngine.UIElements.FocusChangeDirection get_lastValue();
            static /*0x2a13850*/ int op_Implicit(UnityEngine.UIElements.FocusChangeDirection fcd);
            /*0x2a13828*/ FocusChangeDirection(int value);
            /*0x2a1385c*/ void System.IDisposable.Dispose();
            /*0x2a13868*/ void Dispose();
            /*0x2a1386c*/ void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f);
        }

        interface IFocusRing
        {
            UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e);
            UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction);
        }

        class FocusController
        {
            /*0x10*/ UnityEngine.UIElements.IFocusRing <focusRing>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.FocusController.FocusedElement> m_FocusedElements;
            /*0x20*/ UnityEngine.UIElements.Focusable m_LastFocusedElement;
            /*0x28*/ UnityEngine.UIElements.Focusable m_LastPendingFocusedElement;
            /*0x30*/ int m_PendingFocusCount;
            /*0x34*/ int <imguiKeyboardControl>k__BackingField;

            /*0x2a13bf8*/ FocusController(UnityEngine.UIElements.IFocusRing focusRing);
            /*0x2a13c90*/ UnityEngine.UIElements.IFocusRing get_focusRing();
            /*0x2a13c98*/ UnityEngine.UIElements.Focusable get_focusedElement();
            /*0x2a13f1c*/ bool IsFocused(UnityEngine.UIElements.Focusable f);
            /*0x2a13cdc*/ UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement retargetAgainst);
            /*0x2a14090*/ UnityEngine.UIElements.Focusable GetLeafFocusedElement();
            /*0x2a13ee0*/ bool IsLocalElement(UnityEngine.UIElements.Focusable f);
            /*0x2a14134*/ bool IsPendingFocus(UnityEngine.UIElements.Focusable f);
            /*0x2a141e4*/ void SetFocusToLastFocusedElement();
            /*0x2a1426c*/ void BlurLastFocusedElement();
            /*0x2a142f4*/ void DoFocusChange(UnityEngine.UIElements.Focusable f);
            /*0x2a14484*/ UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection direction);
            /*0x2a14570*/ void AboutToReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a14734*/ void ReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a148f8*/ void AboutToGrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a14abc*/ void GrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a131cc*/ void Blur(UnityEngine.UIElements.Focusable focusable, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a130dc*/ void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a13894*/ void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, UnityEngine.UIElements.FocusChangeDirection direction, bool bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a13434*/ UnityEngine.UIElements.Focusable SwitchFocusOnEvent(UnityEngine.UIElements.EventBase e);
            /*0x2a14c8c*/ void ReevaluateFocus();
            /*0x2a14d4c*/ bool GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable target, ref UnityEngine.UIElements.Focusable effectiveTarget);
            /*0x2a14e50*/ int get_imguiKeyboardControl();
            /*0x2a14e58*/ void set_imguiKeyboardControl(int value);
            /*0x2a14e60*/ void SyncIMGUIFocus(int imguiKeyboardControlID, UnityEngine.UIElements.Focusable imguiContainerHavingKeyboardControl, bool forceSwitch);

            struct FocusedElement
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement m_SubTreeRoot;
                /*0x18*/ UnityEngine.UIElements.Focusable m_FocusedElement;
            }
        }

        enum SelectionType
        {
            None = 0,
            Single = 1,
            Multiple = 2,
        }

        enum Position
        {
            Relative = 0,
            Absolute = 1,
        }

        enum OverflowInternal
        {
            Visible = 0,
            Hidden = 1,
            Scroll = 2,
        }

        enum OverflowClipBox
        {
            PaddingBox = 0,
            ContentBox = 1,
        }

        enum FlexDirection
        {
            Column = 0,
            ColumnReverse = 1,
            Row = 2,
            RowReverse = 3,
        }

        enum Wrap
        {
            NoWrap = 0,
            Wrap = 1,
            WrapReverse = 2,
        }

        enum Align
        {
            Auto = 0,
            FlexStart = 1,
            Center = 2,
            FlexEnd = 3,
            Stretch = 4,
        }

        enum Justify
        {
            FlexStart = 0,
            Center = 1,
            FlexEnd = 2,
            SpaceBetween = 3,
            SpaceAround = 4,
        }

        enum TextOverflowPosition
        {
            End = 0,
            Start = 1,
            Middle = 2,
        }

        enum TextOverflow
        {
            Clip = 0,
            Ellipsis = 1,
        }

        enum TransformOriginOffset
        {
            Left = 1,
            Right = 2,
            Top = 3,
            Bottom = 4,
            Center = 5,
        }

        enum Visibility
        {
            Visible = 0,
            Hidden = 1,
        }

        enum WhiteSpace
        {
            Normal = 0,
            NoWrap = 1,
        }

        enum DisplayStyle
        {
            Flex = 0,
            None = 1,
        }

        interface IUIElementsUtility
        {
            bool TakeCapture();
            bool ReleaseCapture();
            bool ProcessEvent(int instanceID, nint nativeEventPtr, ref bool eventHandled);
            bool CleanupRoots();
            bool EndContainerGUIFromException(System.Exception exception);
            bool MakeCurrentIMGUIContainerDirty();
        }

        class UIEventRegistration
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility> s_Utilities;

            static /*0x2a14f2c*/ UIEventRegistration();
            static /*0x2a153d8*/ void RegisterUIElementSystem(UnityEngine.UIElements.IUIElementsUtility utility);
            static /*0x2a1545c*/ void TakeCapture();
            static /*0x2a15634*/ void ReleaseCapture();
            static /*0x2a15810*/ bool EndContainerGUIFromException(System.Exception exception);
            static /*0x2a15a28*/ bool ProcessEvent(int instanceID, nint nativeEventPtr);
            static /*0x2a15c4c*/ void CleanupRoots();
            static /*0x2a15e28*/ void MakeCurrentIMGUIContainerDirty();

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UIEventRegistration.<> <>9;

                static /*0x2a16004*/ <>c();
                /*0x2a16068*/ <>c();
                /*0x2a16070*/ void <.cctor>b__1_0();
                /*0x2a160bc*/ void <.cctor>b__1_1();
                /*0x2a16108*/ bool <.cctor>b__1_2(int i, nint ptr);
                /*0x2a1616c*/ void <.cctor>b__1_3();
                /*0x2a161b8*/ bool <.cctor>b__1_4(System.Exception exception);
                /*0x2a1620c*/ void <.cctor>b__1_5();
            }
        }

        class UIElementsUtility : UnityEngine.UIElements.IUIElementsUtility
        {
            static /*0x0*/ System.Collections.Generic.Stack<UnityEngine.UIElements.IMGUIContainer> s_ContainerStack;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.UIElements.Panel> s_UIElementsCache;
            static /*0x10*/ UnityEngine.Event s_EventInstance;
            static /*0x18*/ UnityEngine.Color editorPlayModeTintColor;
            static /*0x28*/ float singleLineHeight;
            static /*0x30*/ UnityEngine.UIElements.UIElementsUtility s_Instance;
            static /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_PanelsIterationList;
            static /*0x40*/ string s_RepaintProfilerMarkerName;
            static /*0x48*/ string s_EventProfilerMarkerName;
            static /*0x50*/ Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker;
            static /*0x58*/ Unity.Profiling.ProfilerMarker s_EventProfilerMarker;

            static /*0x2a17ad4*/ UIElementsUtility();
            static /*0x2a16ee8*/ void RegisterCachedPanel(int instanceID, UnityEngine.UIElements.Panel panel);
            static /*0x2a16f78*/ void RemoveCachedPanel(int instanceID);
            static /*0x2a16ff8*/ bool TryGetPanel(int instanceID, ref UnityEngine.UIElements.Panel panel);
            static /*0x2a17088*/ void BeginContainerGUI(UnityEngine.GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, UnityEngine.UIElements.IMGUIContainer container);
            static /*0x2a172f8*/ void EndContainerGUI(UnityEngine.Event evt, UnityEngine.Rect layoutSize);
            static /*0x2a1751c*/ UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent);
            static /*0x2a17590*/ UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType);
            static /*0x2a16738*/ bool DoDispatch(UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x2a1782c*/ void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, UnityEngine.UIElements.ContextType contextType);
            static /*0x2a17984*/ System.Collections.Generic.Dictionary.Enumerator<int, UnityEngine.UIElements.Panel> GetPanelsIterator();
            static /*0x2a17a2c*/ float PixelsPerUnitScaleForElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.Sprite sprite);
            /*0x2a16258*/ UIElementsUtility();
            /*0x2a162b8*/ bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty();
            /*0x2a163a4*/ bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture();
            /*0x2a165f0*/ bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture();
            /*0x2a165f8*/ bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, nint nativeEventPtr, ref bool eventHandled);
            /*0x2a16dc8*/ bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots();
            /*0x2a16e28*/ bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(System.Exception exception);
        }

        class VisualTreeViewDataUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList;
            /*0x30*/ uint m_Version;
            /*0x34*/ uint m_LastVersion;

            static /*0x2a181a8*/ VisualTreeViewDataUpdater();
            /*0x2a18108*/ VisualTreeViewDataUpdater();
            /*0x2a17ce4*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x2a17d3c*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x2a17e74*/ void Update();
            /*0x2a17fb8*/ void ValidateViewDataOnSubTree(UnityEngine.UIElements.VisualElement ve, bool enablePersistence);
            /*0x2a17dcc*/ void PropagateToParents(UnityEngine.UIElements.VisualElement ve);
        }

        interface IManipulator
        {
            void set_target(UnityEngine.UIElements.VisualElement value);
        }

        class Manipulator : UnityEngine.UIElements.IManipulator
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement m_Target;

            /*0x2a18290*/ Manipulator();
            void RegisterCallbacksOnTarget();
            void UnregisterCallbacksFromTarget();
            /*0x2a18234*/ UnityEngine.UIElements.VisualElement get_target();
            /*0x2a1823c*/ void set_target(UnityEngine.UIElements.VisualElement value);
        }

        class IMGUIContainer : UnityEngine.UIElements.VisualElement, System.IDisposable
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string ussFoldoutChildDepthClassName;
            static /*0x10*/ System.Collections.Generic.List<string> ussFoldoutChildDepthClassNames;
            static /*0x18*/ Unity.Profiling.ProfilerMarker k_OnGUIMarker;
            static /*0x20*/ Unity.Profiling.ProfilerMarker k_ImmediateCallbackMarker;
            static /*0x28*/ UnityEngine.Event s_DefaultMeasureEvent;
            static /*0x30*/ UnityEngine.Event s_MeasureEvent;
            static /*0x38*/ UnityEngine.Event s_CurrentEvent;
            /*0x3b0*/ System.Action m_OnGUIHandler;
            /*0x3b8*/ UnityEngine.ObjectGUIState m_ObjectGUIState;
            /*0x3c0*/ bool useOwnerObjectGUIState;
            /*0x3c4*/ UnityEngine.Rect <lastWorldClip>k__BackingField;
            /*0x3d4*/ bool m_CullingEnabled;
            /*0x3d5*/ bool m_IsFocusDelegated;
            /*0x3d6*/ bool m_RefreshCachedLayout;
            /*0x3d8*/ UnityEngine.GUILayoutUtility.LayoutCache m_Cache;
            /*0x3e0*/ UnityEngine.Rect m_CachedClippingRect;
            /*0x3f0*/ UnityEngine.Matrix4x4 m_CachedTransform;
            /*0x430*/ UnityEngine.UIElements.ContextType <contextType>k__BackingField;
            /*0x434*/ bool lostFocus;
            /*0x435*/ bool receivedFocus;
            /*0x438*/ UnityEngine.UIElements.FocusChangeDirection focusChangeDirection;
            /*0x440*/ bool hasFocusableControls;
            /*0x444*/ int newKeyboardFocusControlID;
            /*0x448*/ bool <focusOnlyIfHasFocusableControls>k__BackingField;
            /*0x44c*/ UnityEngine.UIElements.IMGUIContainer.GUIGlobals m_GUIGlobals;

            static /*0x2a18420*/ IMGUIContainer();
            static /*0x2a1aa88*/ bool IsDockAreaMouseUp(UnityEngine.UIElements.EventBase evt);
            static /*0x2a1ace4*/ void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer container, UnityEngine.Event evt, ref UnityEngine.Matrix4x4 transform, ref UnityEngine.Rect clipRect);
            /*0x2a187ec*/ IMGUIContainer();
            /*0x2a187f4*/ IMGUIContainer(System.Action onGUIHandler);
            /*0x2a18298*/ System.Action get_onGUIHandler();
            /*0x2a182a0*/ void set_onGUIHandler(System.Action value);
            /*0x2a17254*/ UnityEngine.ObjectGUIState get_guiState();
            /*0x2a182f8*/ UnityEngine.Rect get_lastWorldClip();
            /*0x2a1830c*/ void set_lastWorldClip(UnityEngine.Rect value);
            /*0x2a18320*/ bool get_cullingEnabled();
            /*0x2a18328*/ UnityEngine.GUILayoutUtility.LayoutCache get_cache();
            /*0x2a18398*/ float get_layoutMeasuredWidth();
            /*0x2a183c0*/ float get_layoutMeasuredHeight();
            /*0x2a183e8*/ UnityEngine.UIElements.ContextType get_contextType();
            /*0x2a183f0*/ void set_contextType(UnityEngine.UIElements.ContextType value);
            /*0x2a183f8*/ bool get_focusOnlyIfHasFocusableControls();
            /*0x2a18400*/ bool get_canGrabFocus();
            /*0x2a18a2c*/ void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x2a18b58*/ void SaveGlobals();
            /*0x2a18c68*/ void RestoreGlobals();
            /*0x2a18d80*/ void DoOnGUI(UnityEngine.Event evt, UnityEngine.Matrix4x4 parentTransform, UnityEngine.Rect clippingRect, bool isComputingLayout, UnityEngine.Rect layoutSize, System.Action onGUIHandler, bool canAffectFocus);
            /*0x2a16390*/ void MarkDirtyLayout();
            /*0x2a19a9c*/ void HandleEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a19dc8*/ void DoIMGUIRepaint();
            /*0x2a19b2c*/ bool SendEventToIMGUI(UnityEngine.UIElements.EventBase evt, bool canAffectFocus, bool verifyBounds);
            /*0x2a1a450*/ bool SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase evt, bool canAffectFocus, bool verifyBounds);
            /*0x2a1a550*/ bool VerifyBounds(UnityEngine.UIElements.EventBase evt);
            /*0x2a1a5f0*/ bool IsContainerCapturingTheMouse();
            /*0x2a1a704*/ bool IsLocalEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a1a908*/ bool IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase evt);
            /*0x2a1a5e0*/ bool HandleIMGUIEvent(UnityEngine.Event e, bool canAffectFocus);
            /*0x2a1ac18*/ bool HandleIMGUIEvent(UnityEngine.Event e, System.Action onGUIHandler, bool canAffectFocus);
            /*0x2a1a158*/ bool HandleIMGUIEvent(UnityEngine.Event e, UnityEngine.Matrix4x4 worldTransform, UnityEngine.Rect clippingRect, System.Action onGUIHandler, bool canAffectFocus);
            /*0x2a1aea8*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x2a1b190*/ void SetFoldoutDepthClass();
            /*0x2a1b3dc*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x2a1abac*/ UnityEngine.Rect GetCurrentClipRect();
            /*0x2a1b634*/ void Dispose();
            /*0x2a1b6a4*/ void Dispose(bool disposeManaged);
            /*0x2a1b6bc*/ void <DoOnGUI>b__56_0();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.IMGUIContainer, UnityEngine.UIElements.IMGUIContainer.UxmlTraits>
            {
                /*0x2a1b6c8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x2a1b710*/ UxmlTraits();
            }

            struct GUIGlobals
            {
                /*0x10*/ UnityEngine.Matrix4x4 matrix;
                /*0x50*/ UnityEngine.Color color;
                /*0x60*/ UnityEngine.Color contentColor;
                /*0x70*/ UnityEngine.Color backgroundColor;
                /*0x80*/ bool enabled;
                /*0x81*/ bool changed;
                /*0x84*/ int displayIndex;
            }
        }

        class MouseCaptureController
        {
            static /*0x2a1adf8*/ bool HasMouseCapture(UnityEngine.UIElements.IEventHandler handler);
            static /*0x2a16510*/ void CaptureMouse(UnityEngine.UIElements.IEventHandler handler);
            static /*0x2a1b780*/ void ReleaseMouse(UnityEngine.UIElements.IEventHandler handler);
        }

        enum DispatchMode
        {
            Default = 1,
            Queued = 1,
            Immediate = 2,
        }

        struct EventDispatcherGate : System.IDisposable, System.IEquatable<UnityEngine.UIElements.EventDispatcherGate>
        {
            /*0x10*/ UnityEngine.UIElements.EventDispatcher m_Dispatcher;

            /*0x2a1b860*/ EventDispatcherGate(UnityEngine.UIElements.EventDispatcher d);
            /*0x2a1b8dc*/ void Dispose();
            /*0x2a1b97c*/ bool Equals(UnityEngine.UIElements.EventDispatcherGate other);
            /*0x2a1b988*/ bool Equals(object obj);
            /*0x2a1ba04*/ int GetHashCode();
        }

        class EventDispatcher
        {
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>> k_EventQueuePool;
            static /*0x8*/ UnityEngine.UIElements.IEventDispatchingStrategy[] s_EditorStrategies;
            /*0x10*/ UnityEngine.UIElements.ClickDetector m_ClickDetector;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.IEventDispatchingStrategy> m_DispatchingStrategies;
            /*0x20*/ System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue;
            /*0x28*/ UnityEngine.UIElements.PointerDispatchState <pointerState>k__BackingField;
            /*0x30*/ uint m_GateCount;
            /*0x38*/ System.Collections.Generic.Stack<UnityEngine.UIElements.EventDispatcher.DispatchContext> m_DispatchContexts;
            /*0x40*/ bool m_Immediate;
            /*0x41*/ bool <processingEvents>k__BackingField;

            static /*0x2a1c888*/ EventDispatcher();
            static /*0x2a1ba24*/ UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies);
            /*0x2a1ba84*/ EventDispatcher(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies);
            /*0x2a1ba1c*/ UnityEngine.UIElements.PointerDispatchState get_pointerState();
            /*0x2a1bc30*/ bool get_dispatchImmediately();
            /*0x2a1bc50*/ void set_processingEvents(bool value);
            /*0x2a1bc5c*/ void Dispatch(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a1b8cc*/ void CloseGate();
            /*0x2a1b8f4*/ void OpenGate();
            /*0x2a1c190*/ void ProcessEventQueue();
            /*0x2a1bdc0*/ void ProcessEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
            /*0x2a1c558*/ void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, bool imguiEventIsInitiallyUsed);

            struct EventRecord
            {
                /*0x10*/ UnityEngine.UIElements.EventBase m_Event;
                /*0x18*/ UnityEngine.UIElements.IPanel m_Panel;
            }

            struct DispatchContext
            {
                /*0x10*/ uint m_GateCount;
                /*0x18*/ System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue;
            }
        }

        interface ISerializableJsonDictionary
        {
            void Set<T>(string key, T value);
            void Overwrite(object obj, string key);
            bool ContainsKey(string key);
        }

        class VisualElementUtils
        {
            static /*0x0*/ System.Collections.Generic.HashSet<string> s_usedNames;
            static /*0x8*/ System.Type s_FoldoutType;

            static /*0x2a1ce0c*/ VisualElementUtils();
            static /*0x2a1cbe4*/ string GetUniqueName(string nameBase);
            static /*0x2a1b2f8*/ int GetFoldoutDepth(UnityEngine.UIElements.VisualElement element);
            static /*0x2a1ccf8*/ int GetListAndFoldoutDepth(UnityEngine.UIElements.VisualElement element);
        }

        class GroupBoxUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox, UnityEngine.UIElements.IGroupManager> s_GroupManagers;
            static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption, UnityEngine.UIElements.IGroupManager> s_GroupOptionManagerCache;
            static /*0x10*/ System.Type k_GenericGroupBoxType;

            static /*0x2a1d864*/ GroupBoxUtility();
            static void RegisterGroupBoxOptionCallbacks<T>(T option);
            static void OnOptionSelected<T>(T selectedOption);
            static /*0x2a1cef4*/ void OnOptionAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            static /*0x2a1d520*/ void OnOptionDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            static /*0x2a1d140*/ UnityEngine.UIElements.IGroupManager FindOrCreateGroupManager(UnityEngine.UIElements.IGroupBox groupBox);
            static /*0x2a1d6d4*/ void OnGroupBoxDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            static /*0x2a1d788*/ void OnPanelDestroyed(UnityEngine.UIElements.BaseVisualElementPanel panel);
        }

        struct RuleMatcher
        {
            /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
            /*0x18*/ UnityEngine.UIElements.StyleComplexSelector complexSelector;

            /*0x2a1d998*/ string ToString();
        }

        class UQuery
        {
            interface IVisualPredicateWrapper
            {
                bool Predicate(object e);
            }

            class IsOfType<T> : UnityEngine.UIElements.UQuery.IVisualPredicateWrapper
            {
                static /*0x0*/ UnityEngine.UIElements.UQuery.IsOfType<T> s_Instance;

                static IsOfType();
                IsOfType();
                bool Predicate(object e);
            }

            class UQueryMatcher : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;

                static /*0x2a1d9d0*/ void NoProcessResult(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i);
                /*0x2a1d9b8*/ UQueryMatcher();
                /*0x2a1d9c0*/ void Traverse(UnityEngine.UIElements.VisualElement element);
                /*0x2a1d9c8*/ bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
                /*0x2a1d9d4*/ void TraverseRecursive(UnityEngine.UIElements.VisualElement element, int depth);
                /*0x2a1dbd0*/ void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers);

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UQuery.UQueryMatcher.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> <>9__5_0;

                    static /*0x2a1dbe0*/ <>c();
                    /*0x2a1dc44*/ <>c();
                    /*0x2a1dc4c*/ void <TraverseRecursive>b__5_0(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i);
                }
            }

            class SingleQueryMatcher : UnityEngine.UIElements.UQuery.UQueryMatcher
            {
                /*0x18*/ UnityEngine.UIElements.VisualElement <match>k__BackingField;

                /*0x2a1dc94*/ SingleQueryMatcher();
                /*0x2a1dc50*/ UnityEngine.UIElements.VisualElement get_match();
                /*0x2a1dc58*/ void set_match(UnityEngine.UIElements.VisualElement value);
                /*0x2a1dc60*/ void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers);
                /*0x2a1dc84*/ bool IsInUse();
                UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew();
            }

            class FirstQueryMatcher : UnityEngine.UIElements.UQuery.SingleQueryMatcher
            {
                static /*0x0*/ UnityEngine.UIElements.UQuery.FirstQueryMatcher Instance;

                static /*0x2a1dd14*/ FirstQueryMatcher();
                /*0x2a1dd0c*/ FirstQueryMatcher();
                /*0x2a1dc9c*/ bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
                /*0x2a1dcb0*/ UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew();
            }
        }

        struct UQueryState<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<UnityEngine.UIElements.UQueryState<T>>
        {
            static /*0x0*/ UnityEngine.UIElements.UQueryState.ActionQueryMatcher<T> s_Action;
            static /*0x0*/ UnityEngine.UIElements.UQueryState.ListQueryMatcher<T, T> s_List;
            static /*0x0*/ UnityEngine.UIElements.UQueryState.ListQueryMatcher<T, UnityEngine.UIElements.VisualElement> s_EnumerationList;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_Element;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;

            static UQueryState();
            UQueryState(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers);
            UnityEngine.UIElements.UQueryState<T> RebuildOn(UnityEngine.UIElements.VisualElement element);
            T Single(UnityEngine.UIElements.UQuery.SingleQueryMatcher matcher);
            T First();
            void ToList(System.Collections.Generic.List<T> results);
            UnityEngine.UIElements.UQueryState.Enumerator<T> GetEnumerator();
            System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            bool Equals(UnityEngine.UIElements.UQueryState<T> other);
            bool Equals(object obj);
            int GetHashCode();

            class ListQueryMatcher`1<T, TElement> : UnityEngine.UIElements.UQuery.UQueryMatcher
            {
                /*0x0*/ System.Collections.Generic.List<TElement> <matches>k__BackingField;

                ListQueryMatcher`1();
                System.Collections.Generic.List<TElement> get_matches();
                void set_matches(System.Collections.Generic.List<TElement> value);
                bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
                void Reset();
            }

            class ActionQueryMatcher<T> : UnityEngine.UIElements.UQuery.UQueryMatcher
            {
                /*0x0*/ System.Action<T> <callBack>k__BackingField;

                ActionQueryMatcher();
                System.Action<T> get_callBack();
                bool OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element);
            }

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> iterationList;
                /*0x0*/ int currentIndex;

                Enumerator(UnityEngine.UIElements.UQueryState<T> queryState);
                T get_Current();
                object System.Collections.IEnumerator.get_Current();
                bool MoveNext();
                void Reset();
                void Dispose();
            }
        }

        struct UQueryBuilder<T> : System.IEquatable<UnityEngine.UIElements.UQueryBuilder<T>>
        {
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> m_StyleSelectors;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> m_Parts;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_Element;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;
            /*0x0*/ UnityEngine.UIElements.StyleSelectorRelationship m_Relationship;
            /*0x0*/ int pseudoStatesMask;
            /*0x0*/ int negatedPseudoStatesMask;

            UQueryBuilder(UnityEngine.UIElements.VisualElement visualElement);
            System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors();
            System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts();
            UnityEngine.UIElements.UQueryBuilder<T> Class(string classname);
            UnityEngine.UIElements.UQueryBuilder<T> Name(string id);
            UnityEngine.UIElements.UQueryBuilder<T2> OfType<T2>(string name, string className);
            UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType();
            void AddClass(string c);
            void AddName(string id);
            void AddType<T2>();
            UnityEngine.UIElements.UQueryBuilder<T2> AddRelationship<T2>(UnityEngine.UIElements.StyleSelectorRelationship relationship);
            void AddPseudoStatesRuleIfNecessasy();
            void FinishSelector();
            bool CurrentSelectorEmpty();
            void FinishCurrentSelector();
            UnityEngine.UIElements.UQueryState<T> Build();
            void ToList(System.Collections.Generic.List<T> results);
            bool Equals(UnityEngine.UIElements.UQueryBuilder<T> other);
            bool Equals(object obj);
            int GetHashCode();
        }

        class UQueryExtensions
        {
            static /*0x0*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementEmptyQuery;
            static /*0x10*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameQuery;
            static /*0x20*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementClassQuery;
            static /*0x30*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameAndClassQuery;
            static /*0x40*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeQuery;
            static /*0x50*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameQuery;
            static /*0x60*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndClassQuery;
            static /*0x70*/ UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameAndClassQuery;

            static /*0x2a1e158*/ UQueryExtensions();
            static T Q<T>(UnityEngine.UIElements.VisualElement e, string name, string className);
            static /*0x2a1dd78*/ UnityEngine.UIElements.VisualElement Q(UnityEngine.UIElements.VisualElement e, string name, string className);
            static UnityEngine.UIElements.UQueryBuilder<T> Query<T>(UnityEngine.UIElements.VisualElement e, string name, string className);
        }

        class UIElementsRuntimeUtility
        {
            static /*0x0*/ System.Action<UnityEngine.UIElements.BaseRuntimePanel> onCreatePanel;
            static /*0x8*/ bool s_RegisteredPlayerloopCallback;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels;
            static /*0x18*/ bool s_PanelOrderingDirty;
            static /*0x20*/ string s_RepaintProfilerMarkerName;
            static /*0x28*/ Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker;
            static /*0x30*/ int currentOverlayIndex;
            static /*0x38*/ UnityEngine.Object <activeEventSystem>k__BackingField;
            static /*0x40*/ UnityEngine.UIElements.DefaultEventSystem s_DefaultEventSystem;
            static /*0x48*/ System.Collections.Generic.List<UnityEngine.UIElements.PanelSettings> s_PotentiallyEmptyPanelSettings;

            static /*0x2a1e810*/ UIElementsRuntimeUtility();
            static /*0x2a1e630*/ void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value);
            static /*0x2a1e720*/ void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value);
            static /*0x2a1eb44*/ UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent);
            static /*0x2a1ebb8*/ UnityEngine.UIElements.BaseRuntimePanel FindOrCreateRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate);
            static /*0x2a1efa8*/ void DisposeRuntimePanel(UnityEngine.ScriptableObject ownerObject);
            static /*0x2a1ee84*/ void RegisterCachedPanelInternal(int instanceID, UnityEngine.UIElements.IPanel panel);
            static /*0x2a1ed54*/ void RemoveCachedPanelInternal(int instanceID);
            static /*0x2a1f164*/ void RepaintOverlayPanel(UnityEngine.UIElements.BaseRuntimePanel panel);
            static /*0x2a1f324*/ void BeginRenderOverlays(int displayIndex);
            static /*0x2a1f37c*/ void RenderOverlaysBeforePriority(int displayIndex, float maxPriority);
            static /*0x2a1f5b4*/ void EndRenderOverlays(int displayIndex);
            static /*0x2a1f624*/ UnityEngine.Object get_activeEventSystem();
            static /*0x2a1f67c*/ void set_activeEventSystem(UnityEngine.Object value);
            static /*0x2a1f6d8*/ bool get_useDefaultEventSystem();
            static /*0x2a1f794*/ void RegisterEventSystem(UnityEngine.Object eventSystem);
            static /*0x2a1f9b0*/ void UnregisterEventSystem(UnityEngine.Object eventSystem);
            static /*0x2a1fac4*/ UnityEngine.UIElements.DefaultEventSystem get_defaultEventSystem();
            static /*0x2a1fb70*/ void UpdateRuntimePanels();
            static /*0x2a1ff90*/ void MarkPotentiallyEmpty(UnityEngine.UIElements.PanelSettings settings);
            static /*0x2a1fd8c*/ void RemoveUnusedPanels();
            static /*0x2a1f078*/ void RegisterPlayerloopCallback();
            static /*0x2a1f114*/ void UnregisterPlayerloopCallback();
            static /*0x2a120d4*/ void SetPanelOrderingDirty();
            static /*0x2a1f52c*/ System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels();
            static /*0x2a200a4*/ void SortPanels();
            static /*0x2a20268*/ UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x2a202e8*/ UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x2a2043c*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
            static /*0x2a20520*/ UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta);

            class CreateRuntimePanelDelegate : System.MulticastDelegate
            {
                /*0x2a20528*/ CreateRuntimePanelDelegate(object object, nint method);
                /*0x2a20654*/ UnityEngine.UIElements.BaseRuntimePanel Invoke(UnityEngine.ScriptableObject ownerObject);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UIElementsRuntimeUtility.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.UIElements.Panel> <>9__46_0;

                static /*0x2a20668*/ <>c();
                /*0x2a206cc*/ <>c();
                /*0x2a206d4*/ void <.cctor>b__9_0();
                /*0x2a206d8*/ void <.cctor>b__9_1(int displayIndex, int sortOrder);
                /*0x2a2073c*/ int <SortPanels>b__46_0(UnityEngine.UIElements.Panel a, UnityEngine.UIElements.Panel b);
            }
        }

        interface IGroupBoxOption
        {
            void SetSelected(bool selected);
        }

        interface IGroupBox
        {
        }

        interface IGroupBox<T> : UnityEngine.UIElements.IGroupBox
        {
        }

        struct TimerState : System.IEquatable<UnityEngine.UIElements.TimerState>
        {
            /*0x10*/ long <start>k__BackingField;
            /*0x18*/ long <now>k__BackingField;

            /*0x2a208ac*/ long get_start();
            /*0x2a208b4*/ void set_start(long value);
            /*0x2a208bc*/ long get_now();
            /*0x2a208c4*/ void set_now(long value);
            /*0x2a208cc*/ long get_deltaTime();
            /*0x2a208d8*/ bool Equals(object obj);
            /*0x2a20960*/ bool Equals(UnityEngine.UIElements.TimerState other);
            /*0x2a20984*/ int GetHashCode();
        }

        interface IScheduler
        {
            void Unschedule(UnityEngine.UIElements.ScheduledItem item);
            void Schedule(UnityEngine.UIElements.ScheduledItem item);
            void UpdateScheduledEvents();
        }

        class ScheduledItem
        {
            static /*0x0*/ System.Func<bool> OnceCondition;
            static /*0x8*/ System.Func<bool> ForeverCondition;
            /*0x10*/ System.Func<bool> timerUpdateStopCondition;
            /*0x18*/ long <startMs>k__BackingField;
            /*0x20*/ long <delayMs>k__BackingField;
            /*0x28*/ long <intervalMs>k__BackingField;
            /*0x30*/ long <endTimeMs>k__BackingField;

            static /*0x2a20b2c*/ ScheduledItem();
            /*0x2a20a38*/ ScheduledItem();
            /*0x2a20a00*/ long get_startMs();
            /*0x2a20a08*/ void set_startMs(long value);
            /*0x2a20a10*/ long get_delayMs();
            /*0x2a20a18*/ void set_delayMs(long value);
            /*0x2a20a20*/ long get_intervalMs();
            /*0x2a20a28*/ void set_intervalMs(long value);
            /*0x2a20a30*/ long get_endTimeMs();
            /*0x2a20aac*/ void ResetStartTime();
            void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
            /*0x2a20b08*/ void OnItemUnscheduled();
            /*0x2a20b0c*/ bool ShouldUnschedule();

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.ScheduledItem.<> <>9;

                static /*0x2a20c44*/ <>c();
                /*0x2a20ca8*/ <>c();
                /*0x2a20cb0*/ bool <.cctor>b__25_0();
                /*0x2a20cb8*/ bool <.cctor>b__25_1();
            }
        }

        class TimerEventScheduler : UnityEngine.UIElements.IScheduler
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduledItems;
            /*0x18*/ bool m_TransactionMode;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduleTransactions;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.ScheduledItem> m_UnscheduleTransactions;
            /*0x30*/ bool disableThrottling;
            /*0x34*/ int m_LastUpdatedIndex;

            /*0x2a21448*/ TimerEventScheduler();
            /*0x2a20cc0*/ void Schedule(UnityEngine.UIElements.ScheduledItem item);
            /*0x2a20e88*/ bool RemovedScheduledItemAt(int index);
            /*0x2a20ef4*/ void Unschedule(UnityEngine.UIElements.ScheduledItem item);
            /*0x2a21098*/ bool PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem sItem);
            /*0x2a21138*/ void UpdateScheduledEvents();
        }

        class DropdownMenuEventInfo
        {
            /*0x10*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x14*/ UnityEngine.Vector2 <mousePosition>k__BackingField;
            /*0x1c*/ UnityEngine.Vector2 <localMousePosition>k__BackingField;
            /*0x24*/ char <character>k__BackingField;
            /*0x28*/ UnityEngine.KeyCode <keyCode>k__BackingField;

            /*0x2a21538*/ DropdownMenuEventInfo(UnityEngine.UIElements.EventBase e);
        }

        class DropdownMenuItem
        {
            /*0x2a21854*/ DropdownMenuItem();
        }

        class DropdownMenuSeparator : UnityEngine.UIElements.DropdownMenuItem
        {
            /*0x10*/ string <subMenuPath>k__BackingField;

            /*0x2a2185c*/ DropdownMenuSeparator(string subMenuPath);
        }

        class DropdownMenuAction : UnityEngine.UIElements.DropdownMenuItem
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.DropdownMenuAction.Status <status>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.DropdownMenuEventInfo <eventInfo>k__BackingField;
            /*0x28*/ object <userData>k__BackingField;
            /*0x30*/ System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback;
            /*0x38*/ System.Func<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback;

            /*0x2a2189c*/ DropdownMenuAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData);
            /*0x2a21884*/ void set_status(UnityEngine.UIElements.DropdownMenuAction.Status value);
            /*0x2a2188c*/ void set_eventInfo(UnityEngine.UIElements.DropdownMenuEventInfo value);
            /*0x2a21894*/ void set_userData(object value);
            /*0x2a218e0*/ void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo eventInfo);

            enum Status
            {
                None = 0,
                Normal = 1,
                Disabled = 2,
                Checked = 4,
                Hidden = 8,
            }
        }

        class DropdownMenu
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems;
            /*0x18*/ UnityEngine.UIElements.DropdownMenuEventInfo m_DropdownMenuEventInfo;

            /*0x2a2191c*/ System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems();
            /*0x2a21924*/ void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData);
            /*0x2a21a28*/ void InsertSeparator(string subMenuPath, int atIndex);
            /*0x2a21b68*/ void PrepareForDisplay(UnityEngine.UIElements.EventBase e);
        }

        class ListViewReorderableDragAndDropController : UnityEngine.UIElements.BaseReorderableDragAndDropController
        {
            /*0x28*/ UnityEngine.UIElements.ListView m_ListView;

            /*0x2a21e24*/ ListViewReorderableDragAndDropController(UnityEngine.UIElements.ListView view);
            /*0x2a21e88*/ UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
            /*0x2a22024*/ void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
        }

        class BaseReorderableDragAndDropController : UnityEngine.UIElements.ICollectionDragAndDropController, UnityEngine.UIElements.IDragAndDropController<UnityEngine.UIElements.IListDragAndDropArgs>, UnityEngine.UIElements.IReorderable
        {
            /*0x10*/ UnityEngine.UIElements.BaseVerticalCollectionView m_View;
            /*0x18*/ System.Collections.Generic.List<int> m_SelectedIndices;
            /*0x20*/ bool <enableReordering>k__BackingField;

            /*0x2a21e58*/ BaseReorderableDragAndDropController(UnityEngine.UIElements.BaseVerticalCollectionView view);
            /*0x2a222ac*/ bool get_enableReordering();
            /*0x2a222b4*/ void set_enableReordering(bool value);
            /*0x2a222c0*/ bool CanStartDrag(System.Collections.Generic.IEnumerable<int> itemIndices);
            /*0x2a222c8*/ UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<int> itemIndices, bool skipText);
            UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
            void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args);
        }

        interface IListDragAndDropArgs
        {
            int get_insertAtIndex();
            UnityEngine.UIElements.IDragAndDropData get_dragAndDropData();
            UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition();
        }

        struct ListDragAndDropArgs : UnityEngine.UIElements.IListDragAndDropArgs
        {
            /*0x10*/ object <target>k__BackingField;
            /*0x18*/ int <insertAtIndex>k__BackingField;
            /*0x1c*/ UnityEngine.UIElements.DragAndDropPosition <dragAndDropPosition>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.IDragAndDropData <dragAndDropData>k__BackingField;

            /*0x2a22c64*/ void set_target(object value);
            /*0x2a22c6c*/ int get_insertAtIndex();
            /*0x2a22c74*/ void set_insertAtIndex(int value);
            /*0x2a22c7c*/ UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition();
            /*0x2a22c84*/ void set_dragAndDropPosition(UnityEngine.UIElements.DragAndDropPosition value);
            /*0x2a22c8c*/ UnityEngine.UIElements.IDragAndDropData get_dragAndDropData();
            /*0x2a22c94*/ void set_dragAndDropData(UnityEngine.UIElements.IDragAndDropData value);
        }

        enum DragAndDropPosition
        {
            OverItem = 0,
            BetweenItems = 1,
            OutsideItems = 2,
        }

        interface IDragAndDropController<TArgs>
        {
            bool CanStartDrag(System.Collections.Generic.IEnumerable<int> itemIndices);
            UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<int> itemIndices, bool skipText);
            UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(TArgs args);
            void OnDrop(TArgs args);
        }

        enum DragVisualMode
        {
            None = 0,
            Copy = 1,
            Move = 2,
            Rejected = 3,
        }

        class StartDragArgs
        {
            /*0x10*/ string <title>k__BackingField;
            /*0x18*/ object <userData>k__BackingField;
            /*0x20*/ System.Collections.Hashtable m_GenericData;
            /*0x28*/ System.Collections.Generic.IEnumerable<UnityEngine.Object> <unityObjectReferences>k__BackingField;

            /*0x2a22be4*/ StartDragArgs(string title, object userData);
            /*0x2a22c9c*/ object get_userData();
        }

        class ListViewDragger : UnityEngine.UIElements.DragEventsProcessor
        {
            /*0x38*/ UnityEngine.UIElements.ListViewDragger.DragPosition m_LastDragPosition;
            /*0x50*/ UnityEngine.UIElements.VisualElement m_DragHoverBar;
            /*0x58*/ UnityEngine.UIElements.ICollectionDragAndDropController <dragAndDropController>k__BackingField;

            /*0x2a22d4c*/ ListViewDragger(UnityEngine.UIElements.BaseVerticalCollectionView listView);
            /*0x2a22ca4*/ UnityEngine.UIElements.BaseVerticalCollectionView get_targetListView();
            /*0x2a22d20*/ UnityEngine.UIElements.ScrollView get_targetScrollView();
            /*0x2a22d3c*/ UnityEngine.UIElements.ICollectionDragAndDropController get_dragAndDropController();
            /*0x2a22d44*/ void set_dragAndDropController(UnityEngine.UIElements.ICollectionDragAndDropController value);
            /*0x2a22e8c*/ bool CanStartDrag(UnityEngine.Vector3 pointerPosition);
            /*0x2a23460*/ UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition);
            /*0x2a2361c*/ UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3 pointerPosition);
            /*0x2a23688*/ UnityEngine.UIElements.DragVisualMode GetVisualMode(UnityEngine.Vector3 pointerPosition, ref UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x2a24158*/ void OnDrop(UnityEngine.Vector3 pointerPosition);
            /*0x2a23dcc*/ void HandleDragAndScroll(UnityEngine.Vector2 pointerPosition);
            /*0x2a237ec*/ void ApplyDragAndDropUI(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x2a245d0*/ bool TryGetDragPosition(UnityEngine.Vector2 pointerPosition, ref UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x2a24008*/ UnityEngine.UIElements.ListDragAndDropArgs MakeDragAndDropArgs(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
            /*0x2a24514*/ void PlaceHoverBarAtElement(UnityEngine.UIElements.VisualElement element);
            /*0x2a24390*/ void PlaceHoverBarAt(float top);
            /*0x2a249f0*/ void ClearDragAndDropUI();
            /*0x2a230c8*/ UnityEngine.UIElements.ReusableCollectionItem GetRecycledItem(UnityEngine.Vector3 pointerPosition);
            /*0x2a24e00*/ void <ApplyDragAndDropUI>b__22_0(UnityEngine.UIElements.GeometryChangedEvent e);

            struct DragPosition : System.IEquatable<UnityEngine.UIElements.ListViewDragger.DragPosition>
            {
                /*0x10*/ int insertAtIndex;
                /*0x18*/ UnityEngine.UIElements.ReusableCollectionItem recycledItem;
                /*0x20*/ UnityEngine.UIElements.DragAndDropPosition dragAndDropPosition;

                /*0x2a24338*/ bool Equals(UnityEngine.UIElements.ListViewDragger.DragPosition other);
                /*0x2a24f08*/ bool Equals(object obj);
                /*0x2a24fa4*/ int GetHashCode();
            }
        }

        class ListViewDraggerExtension
        {
            static /*0x2a2289c*/ UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromIndex(UnityEngine.UIElements.BaseVerticalCollectionView listView, int index);
        }

        class ListViewDraggerAnimated : UnityEngine.UIElements.ListViewDragger
        {
            /*0x60*/ int m_DragStartIndex;
            /*0x64*/ int m_CurrentIndex;
            /*0x68*/ float m_SelectionHeight;
            /*0x6c*/ float m_LocalOffsetOnStart;
            /*0x70*/ UnityEngine.Vector3 m_CurrentPointerPosition;
            /*0x80*/ UnityEngine.UIElements.ReusableCollectionItem m_Item;
            /*0x88*/ UnityEngine.UIElements.ReusableCollectionItem m_OffsetItem;

            /*0x2a2500c*/ ListViewDraggerAnimated(UnityEngine.UIElements.BaseVerticalCollectionView listView);
            /*0x2a24fec*/ bool get_isDragging();
            /*0x2a24ffc*/ UnityEngine.UIElements.ReusableCollectionItem get_draggedItem();
            /*0x2a25004*/ bool get_supportsDragEvents();
            /*0x2a25010*/ UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition);
            /*0x2a25a30*/ UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3 pointerPosition);
            /*0x2a256f0*/ void Animate(UnityEngine.UIElements.ReusableCollectionItem element, float paddingTop);
            /*0x2a262c4*/ void OnDrop(UnityEngine.Vector3 pointerPosition);
            /*0x2a265c4*/ void ClearDragAndDropUI();
            /*0x2a265c8*/ bool TryGetDragPosition(UnityEngine.Vector2 pointerPosition, ref UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition);
        }

        interface ICollectionDragAndDropController : UnityEngine.UIElements.IDragAndDropController<UnityEngine.UIElements.IListDragAndDropArgs>, UnityEngine.UIElements.IReorderable
        {
        }

        class DragAndDropUtility
        {
            static /*0x0*/ System.Func<UnityEngine.UIElements.IDragAndDrop> s_MakeClientFunc;
            static /*0x8*/ UnityEngine.UIElements.IDragAndDrop s_DragAndDrop;

            static /*0x2a24944*/ UnityEngine.UIElements.IDragAndDrop get_dragAndDrop();
        }

        class DefaultDragAndDropClient : UnityEngine.UIElements.IDragAndDrop, UnityEngine.UIElements.IDragAndDropData
        {
            /*0x10*/ UnityEngine.UIElements.StartDragArgs m_StartDragArgs;

            /*0x2a265e8*/ DefaultDragAndDropClient();
            /*0x2a265f0*/ object get_userData();
            /*0x2a26608*/ void StartDrag(UnityEngine.UIElements.StartDragArgs args);
            /*0x2a24940*/ UnityEngine.UIElements.IDragAndDropData get_data();
        }

        interface IDragAndDrop
        {
            void StartDrag(UnityEngine.UIElements.StartDragArgs args);
            UnityEngine.UIElements.IDragAndDropData get_data();
        }

        interface IDragAndDropData
        {
            object get_userData();
        }

        interface IReorderable
        {
            bool get_enableReordering();
            void set_enableReordering(bool value);
        }

        class DragEventsProcessor
        {
            /*0x10*/ bool m_IsRegistered;
            /*0x14*/ UnityEngine.UIElements.DragEventsProcessor.DragState m_DragState;
            /*0x18*/ UnityEngine.Vector3 m_Start;
            /*0x28*/ UnityEngine.UIElements.VisualElement m_Target;
            /*0x30*/ UnityEngine.UIElements.DefaultDragAndDropClient dragAndDropClient;

            /*0x2a22d50*/ DragEventsProcessor(UnityEngine.UIElements.VisualElement target);
            /*0x2a26610*/ bool get_supportsDragEvents();
            /*0x2a24910*/ bool get_useDragEvents();
            /*0x2a26618*/ bool get_isEditorContext();
            /*0x2a269e4*/ void RegisterCallbacksFromTarget(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x2a26738*/ void RegisterCallbacksFromTarget();
            /*0x2a269e8*/ void UnregisterCallbacksFromTarget(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x2a269f0*/ void UnregisterCallbacksFromTarget(bool unregisterPanelEvents);
            bool CanStartDrag(UnityEngine.Vector3 pointerPosition);
            UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition);
            UnityEngine.UIElements.DragVisualMode UpdateDrag(UnityEngine.Vector3 pointerPosition);
            void OnDrop(UnityEngine.Vector3 pointerPosition);
            void ClearDragAndDropUI();
            /*0x2a26d88*/ void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x2a26e1c*/ void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x2a26ee0*/ void OnPointerLeaveEvent(UnityEngine.UIElements.PointerLeaveEvent evt);
            /*0x2a26f24*/ void OnPointerCancelEvent(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x2a26f64*/ void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent evt);

            enum DragState
            {
                None = 0,
                CanStartDrag = 1,
                Dragging = 2,
            }
        }

        class UxmlRootElementFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlRootElementTraits>
        {
            /*0x2a27264*/ UxmlRootElementFactory();
            /*0x2a271a8*/ string get_uxmlName();
            /*0x2a271e8*/ string get_uxmlQualifiedName();
            /*0x2a2725c*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlRootElementTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
            /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Class;

            /*0x2a272ac*/ UxmlRootElementTraits();
        }

        class UxmlStyleFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlStyleTraits>
        {
            /*0x2a274e0*/ UxmlStyleFactory();
            /*0x2a27424*/ string get_uxmlName();
            /*0x2a27464*/ string get_uxmlQualifiedName();
            /*0x2a274d8*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlStyleTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
            /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Path;
            /*0x28*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Src;

            /*0x2a27528*/ UxmlStyleTraits();
        }

        class UxmlTemplateFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlTemplateTraits>
        {
            /*0x2a276d4*/ UxmlTemplateFactory();
            /*0x2a27618*/ string get_uxmlName();
            /*0x2a27658*/ string get_uxmlQualifiedName();
            /*0x2a276cc*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlTemplateTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
            /*0x20*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Path;
            /*0x28*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Src;

            /*0x2a2771c*/ UxmlTemplateTraits();
        }

        class UxmlAttributeOverridesFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UxmlAttributeOverridesTraits>
        {
            /*0x2a278d0*/ UxmlAttributeOverridesFactory();
            /*0x2a27814*/ string get_uxmlName();
            /*0x2a27854*/ string get_uxmlQualifiedName();
            /*0x2a278c8*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlAttributeOverridesTraits : UnityEngine.UIElements.UxmlTraits
        {
            /*0x18*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_ElementName;

            /*0x2a27918*/ UxmlAttributeOverridesTraits();
        }

        class UxmlTypeRestriction : System.IEquatable<UnityEngine.UIElements.UxmlTypeRestriction>
        {
            /*0x2a279ac*/ UxmlTypeRestriction();
            /*0x2a279a0*/ bool Equals(UnityEngine.UIElements.UxmlTypeRestriction other);
        }

        class UxmlEnumeration : UnityEngine.UIElements.UxmlTypeRestriction
        {
            /*0x10*/ System.Collections.Generic.List<string> m_Values;

            /*0x2a27b64*/ UxmlEnumeration();
            /*0x2a279b4*/ System.Collections.Generic.IEnumerable<string> get_values();
            /*0x2a279bc*/ void set_values(System.Collections.Generic.IEnumerable<string> value);
            /*0x2a27a18*/ bool Equals(UnityEngine.UIElements.UxmlTypeRestriction other);
        }

        class UxmlAttributeDescription
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ string[] m_ObsoleteNames;
            /*0x20*/ string <type>k__BackingField;
            /*0x28*/ string <typeNamespace>k__BackingField;
            /*0x30*/ UnityEngine.UIElements.UxmlAttributeDescription.Use <use>k__BackingField;
            /*0x38*/ UnityEngine.UIElements.UxmlTypeRestriction <restriction>k__BackingField;

            /*0x2a27be0*/ UxmlAttributeDescription();
            /*0x2a27c04*/ string get_name();
            /*0x2a27c0c*/ void set_name(string value);
            /*0x2a27c14*/ void set_obsoleteNames(System.Collections.Generic.IEnumerable<string> value);
            /*0x2a27c70*/ void set_type(string value);
            /*0x2a27c78*/ void set_typeNamespace(string value);
            /*0x2a27c80*/ void set_use(UnityEngine.UIElements.UxmlAttributeDescription.Use value);
            /*0x2a27c88*/ void set_restriction(UnityEngine.UIElements.UxmlTypeRestriction value);
            /*0x2a27c90*/ bool TryGetValueFromBagAsString(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref string value);
            bool TryGetValueFromBag<T>(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<string, T, T> converterFunc, T defaultValue, ref T value);
            T GetValueFromBag<T>(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<string, T, T> converterFunc, T defaultValue);

            enum Use
            {
                None = 0,
                Optional = 1,
                Prohibited = 2,
                Required = 3,
            }
        }

        class TypedUxmlAttributeDescription<T> : UnityEngine.UIElements.UxmlAttributeDescription
        {
            /*0x0*/ T <defaultValue>k__BackingField;

            TypedUxmlAttributeDescription();
            T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            T get_defaultValue();
            void set_defaultValue(T value);
        }

        class UxmlStringAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<string>
        {
            /*0x2a27368*/ UxmlStringAttributeDescription();
            /*0x2a28104*/ string GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, string, string> <>9__3_0;

                static /*0x2a28268*/ <>c();
                /*0x2a282cc*/ <>c();
                /*0x2a282d4*/ string <GetValueFromBag>b__3_0(string s, string t);
            }
        }

        class UxmlFloatAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<float>
        {
            static /*0x2a284dc*/ float ConvertValueToFloat(string v, float defaultValue);
            /*0x2a282dc*/ UxmlFloatAttributeDescription();
            /*0x2a28378*/ float GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlFloatAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, float, float> <>9__3_0;

                static /*0x2a28578*/ <>c();
                /*0x2a285dc*/ <>c();
                /*0x2a285e4*/ float <GetValueFromBag>b__3_0(string s, float f);
            }
        }

        class UxmlIntAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<int>
        {
            static /*0x2a28964*/ int ConvertValueToInt(string v, int defaultValue);
            /*0x2a285ec*/ UxmlIntAttributeDescription();
            /*0x2a28688*/ int GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            /*0x2a287ec*/ bool TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref int value);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlIntAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, int, int> <>9__3_0;
                static /*0x10*/ System.Func<string, int, int> <>9__4_0;

                static /*0x2a289a0*/ <>c();
                /*0x2a28a04*/ <>c();
                /*0x2a28a0c*/ int <GetValueFromBag>b__3_0(string s, int i);
                /*0x2a28a4c*/ int <TryGetValueFromBag>b__4_0(string s, int i);
            }
        }

        class UxmlLongAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<long>
        {
            static /*0x2a28c8c*/ long ConvertValueToLong(string v, long defaultValue);
            /*0x2a28a8c*/ UxmlLongAttributeDescription();
            /*0x2a28b28*/ long GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlLongAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, long, long> <>9__3_0;

                static /*0x2a28cc8*/ <>c();
                /*0x2a28d2c*/ <>c();
                /*0x2a28d34*/ long <GetValueFromBag>b__3_0(string s, long l);
            }
        }

        class UxmlBoolAttributeDescription : UnityEngine.UIElements.TypedUxmlAttributeDescription<bool>
        {
            static /*0x2a2a0f0*/ bool ConvertValueToBool(string v, bool defaultValue);
            /*0x2a29d74*/ UxmlBoolAttributeDescription();
            /*0x2a29e10*/ bool GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            /*0x2a29f78*/ bool TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref bool value);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription.<> <>9;
                static /*0x8*/ System.Func<string, bool, bool> <>9__3_0;
                static /*0x10*/ System.Func<string, bool, bool> <>9__4_0;

                static /*0x2a2a178*/ <>c();
                /*0x2a2a1dc*/ <>c();
                /*0x2a2a1e4*/ bool <GetValueFromBag>b__3_0(string s, bool b);
                /*0x2a2a1f4*/ bool <TryGetValueFromBag>b__4_0(string s, bool b);
            }
        }

        class UxmlEnumAttributeDescription<T> : UnityEngine.UIElements.TypedUxmlAttributeDescription<T>
        {
            static U ConvertValueToEnum<U>(string v, U defaultValue);
            UxmlEnumAttributeDescription();
            T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            bool TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, ref T value);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.UIElements.UxmlEnumAttributeDescription.<>c<T> <>9;
                static /*0x0*/ System.Func<string, T, T> <>9__3_0;
                static /*0x0*/ System.Func<string, T, T> <>9__4_0;

                static <>c();
                <>c();
                T <GetValueFromBag>b__3_0(string s, T convertible);
                T <TryGetValueFromBag>b__4_0(string s, T convertible);
            }
        }

        class UxmlTraits
        {
            /*0x10*/ bool <canHaveAnyAttribute>k__BackingField;

            /*0x2a2a204*/ UxmlTraits();
            /*0x2a2a224*/ void set_canHaveAnyAttribute(bool value);
            /*0x2a2a230*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        interface IUxmlFactory
        {
            string get_uxmlQualifiedName();
            bool AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlFactory<TCreatedType, TTraits> : UnityEngine.UIElements.IUxmlFactory
        {
            /*0x0*/ TTraits m_Traits;

            UxmlFactory();
            string get_uxmlName();
            string get_uxmlNamespace();
            string get_uxmlQualifiedName();
            bool AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class UxmlFactory<TCreatedType> : UnityEngine.UIElements.UxmlFactory<TCreatedType, UnityEngine.UIElements.VisualElement.UxmlTraits>
        {
            UxmlFactory();
        }

        interface IUxmlAttributes
        {
            bool TryGetAttributeValue(string attributeName, ref string value);
        }

        class TemplateAsset : UnityEngine.UIElements.VisualElementAsset
        {
            /*0x60*/ string m_TemplateAlias;
            /*0x68*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> m_AttributeOverrides;
            /*0x70*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> m_SlotUsages;

            /*0x2a2a234*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides();
            /*0x2a2a2b4*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> get_slotUsages();

            struct AttributeOverride
            {
                /*0x10*/ string m_ElementName;
                /*0x18*/ string m_AttributeName;
                /*0x20*/ string m_Value;
            }
        }

        class VisualElementFactoryRegistry
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_Factories;

            static /*0x2a2a2bc*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories();
            static /*0x2a2b168*/ void RegisterFactory(UnityEngine.UIElements.IUxmlFactory factory);
            static /*0x2a2b5d8*/ bool TryGetValue(string fullTypeName, ref System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory> factoryList);
            static /*0x2a2a36c*/ void RegisterEngineFactories();
            static /*0x2a2ae98*/ void RegisterUserFactories();
        }

        class VisualTreeAsset : UnityEngine.ScriptableObject
        {
            static /*0x0*/ string LinkedVEAInTemplatePropertyName;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> s_TemporarySlotInsertionPoints;
            /*0x18*/ bool m_ImportedWithErrors;
            /*0x19*/ bool m_ImportedWithWarnings;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> m_Usings;
            /*0x28*/ UnityEngine.UIElements.StyleSheet inlineSheet;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> m_VisualElementAssets;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> m_TemplateAssets;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> m_Slots;
            /*0x48*/ int m_ContentContainerId;
            /*0x4c*/ int m_ContentHash;

            static /*0x2a2dab0*/ VisualTreeAsset();
            static /*0x2a2d4b4*/ int CompareForOrder(UnityEngine.UIElements.VisualElementAsset a, UnityEngine.UIElements.VisualElementAsset b);
            static /*0x2a2ce34*/ UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.CreationContext ctx);
            static /*0x2a2c3b4*/ void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element);
            static /*0x2a2c420*/ void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element);
            static /*0x2a2d774*/ UnityEngine.UIElements.VisualElement <Create>g__CreateError|49_0(ref UnityEngine.UIElements.VisualTreeAsset.<> );
            /*0x2a2daa8*/ VisualTreeAsset();
            /*0x2a2b758*/ bool get_importedWithErrors();
            /*0x2a2b760*/ void set_importedWithErrors(bool value);
            /*0x2a2b76c*/ bool get_importedWithWarnings();
            /*0x2a2b774*/ void set_importedWithWarnings(bool value);
            /*0x2a2b780*/ int GetNextChildSerialNumber();
            /*0x2a2b7e0*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies();
            /*0x2a2b888*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets();
            /*0x2a2b930*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets();
            /*0x2a2b938*/ void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value);
            /*0x2a2b940*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets();
            /*0x2a2b948*/ void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value);
            /*0x2a2b950*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots();
            /*0x2a2b958*/ void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value);
            /*0x2a2b960*/ int get_contentContainerId();
            /*0x2a2b968*/ void set_contentContainerId(int value);
            /*0x2a2b970*/ UnityEngine.UIElements.TemplateContainer Instantiate();
            /*0x2a2c170*/ UnityEngine.UIElements.TemplateContainer Instantiate(string bindingPath);
            /*0x2a2c190*/ UnityEngine.UIElements.TemplateContainer CloneTree();
            /*0x2a2c194*/ UnityEngine.UIElements.TemplateContainer CloneTree(string bindingPath);
            /*0x2a2c1b4*/ void CloneTree(UnityEngine.UIElements.VisualElement target);
            /*0x2a2c1d0*/ void CloneTree(UnityEngine.UIElements.VisualElement target, ref int firstElementIndex, ref int elementAddedCount);
            /*0x2a2baf0*/ void CloneTree(UnityEngine.UIElements.VisualElement target, System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides);
            /*0x2a2c5ec*/ UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset root, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, UnityEngine.UIElements.CreationContext context);
            /*0x2a2d3f4*/ bool TryGetSlotInsertionPoint(int insertionPointId, ref string slotName);
            /*0x2a2d4f0*/ UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(string templateName);
            /*0x2a2da98*/ int get_contentHash();
            /*0x2a2daa0*/ void set_contentHash(int value);

            struct UsingEntry
            {
                static /*0x0*/ System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> comparer;
                /*0x10*/ string alias;
                /*0x18*/ string path;
                /*0x20*/ UnityEngine.UIElements.VisualTreeAsset asset;

                static /*0x2a2db68*/ UsingEntry();
                /*0x2a2d760*/ UsingEntry(string alias, string path);
            }

            class UsingEntryComparer : System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry>
            {
                /*0x2a2dbe0*/ UsingEntryComparer();
                /*0x2a2dbe8*/ int Compare(UnityEngine.UIElements.VisualTreeAsset.UsingEntry x, UnityEngine.UIElements.VisualTreeAsset.UsingEntry y);
            }

            struct SlotDefinition
            {
                /*0x10*/ string name;
                /*0x18*/ int insertionPointId;
            }

            struct SlotUsageEntry
            {
                /*0x10*/ string slotName;
                /*0x18*/ int assetId;
            }

            class <get_templateDependencies>d__17 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.VisualTreeAsset <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.UIElements.VisualTreeAsset <>4__this;
                /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualTreeAsset> <sent>5__1;
                /*0x38*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> <>s__2;
                /*0x60*/ UnityEngine.UIElements.VisualTreeAsset.UsingEntry <entry>5__3;
                /*0x78*/ UnityEngine.UIElements.VisualTreeAsset <vta>5__4;

                /*0x2a2b844*/ <get_templateDependencies>d__17(int <>1__state);
                /*0x2a2dbf8*/ void System.IDisposable.Dispose();
                /*0x2a2dc24*/ bool MoveNext();
                /*0x2a2e104*/ void <>m__Finally1();
                /*0x2a2e154*/ UnityEngine.UIElements.VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current();
                /*0x2a2e15c*/ void System.Collections.IEnumerator.Reset();
                /*0x2a2e19c*/ object System.Collections.IEnumerator.get_Current();
                /*0x2a2e1a4*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator();
                /*0x2a2e244*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <get_stylesheets>d__21 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.StyleSheet <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.UIElements.VisualTreeAsset <>4__this;
                /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheet> <sent>5__1;
                /*0x38*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.VisualElementAsset> <>s__2;
                /*0x50*/ UnityEngine.UIElements.VisualElementAsset <vea>5__3;
                /*0x58*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StyleSheet> <>s__4;
                /*0x70*/ UnityEngine.UIElements.StyleSheet <stylesheet>5__5;
                /*0x78*/ System.Collections.Generic.List.Enumerator<string> <>s__6;
                /*0x90*/ string <stylesheetPath>5__7;
                /*0x98*/ UnityEngine.UIElements.StyleSheet <stylesheet>5__8;

                /*0x2a2b8ec*/ <get_stylesheets>d__21(int <>1__state);
                /*0x2a2e248*/ void System.IDisposable.Dispose();
                /*0x2a2e334*/ bool MoveNext();
                /*0x2a2e990*/ void <>m__Finally1();
                /*0x2a2e8f0*/ void <>m__Finally2();
                /*0x2a2e940*/ void <>m__Finally3();
                /*0x2a2e9e0*/ UnityEngine.UIElements.StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current();
                /*0x2a2e9e8*/ void System.Collections.IEnumerator.Reset();
                /*0x2a2ea28*/ object System.Collections.IEnumerator.get_Current();
                /*0x2a2ea30*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator();
                /*0x2a2ead0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.UIElements.VisualElementAsset childVea;

                /*0x2a2d4ac*/ <>c__DisplayClass45_0();
                /*0x2a2ead4*/ bool <CloneSetupRecursively>b__0(UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry u);
            }

            struct <>c__DisplayClass49_0
            {
                /*0x10*/ UnityEngine.UIElements.VisualElementAsset asset;
            }
        }

        struct CreationContext : System.IEquatable<UnityEngine.UIElements.CreationContext>
        {
            static /*0x0*/ UnityEngine.UIElements.CreationContext Default;
            /*0x10*/ UnityEngine.UIElements.VisualElement <target>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.VisualTreeAsset <visualTreeAsset>k__BackingField;
            /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> <slotInsertionPoints>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> <attributeOverrides>k__BackingField;

            static /*0x2a2eda0*/ CreationContext();
            /*0x2a2c5e0*/ CreationContext(System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target);
            /*0x2a2eaf8*/ UnityEngine.UIElements.VisualElement get_target();
            /*0x2a2eb00*/ void set_target(UnityEngine.UIElements.VisualElement value);
            /*0x2a2eb08*/ UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset();
            /*0x2a2eb10*/ void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x2a2eb18*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> get_slotInsertionPoints();
            /*0x2a2eb20*/ void set_slotInsertionPoints(System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.VisualElement> value);
            /*0x2a2eb28*/ System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides();
            /*0x2a2eb30*/ void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value);
            /*0x2a2eb38*/ bool Equals(object obj);
            /*0x2a2ebc0*/ bool Equals(UnityEngine.UIElements.CreationContext other);
            /*0x2a2ecb0*/ int GetHashCode();
        }

        class VisualElementAsset : UnityEngine.UIElements.IUxmlAttributes, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ string m_Name;
            /*0x18*/ int m_Id;
            /*0x1c*/ int m_OrderInDocument;
            /*0x20*/ int m_ParentId;
            /*0x24*/ int m_RuleIndex;
            /*0x28*/ string m_Text;
            /*0x30*/ UnityEngine.UIElements.PickingMode m_PickingMode;
            /*0x38*/ string m_FullTypeName;
            /*0x40*/ string[] m_Classes;
            /*0x48*/ System.Collections.Generic.List<string> m_StylesheetPaths;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_Stylesheets;
            /*0x58*/ System.Collections.Generic.List<string> m_Properties;

            /*0x2a2c5d8*/ int get_id();
            /*0x2a2d4e8*/ int get_orderInDocument();
            /*0x2a2c3ac*/ int get_parentId();
            /*0x2a2d4a4*/ int get_ruleIndex();
            /*0x2a2d76c*/ string get_fullTypeName();
            /*0x2a2d970*/ string[] get_classes();
            /*0x2a2d988*/ System.Collections.Generic.List<string> get_stylesheetPaths();
            /*0x2a2d978*/ bool get_hasStylesheetPaths();
            /*0x2a2da18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets();
            /*0x2a2da08*/ bool get_hasStylesheets();
            /*0x2a2edec*/ void OnBeforeSerialize();
            /*0x2a2edf0*/ void OnAfterDeserialize();
            /*0x2a2ef78*/ void AddProperty(string propertyName, string propertyValue);
            /*0x2a2ef7c*/ void SetOrAddProperty(string propertyName, string propertyValue);
            /*0x2a2f18c*/ bool TryGetAttributeValue(string propertyName, ref string value);
        }

        class UIDocumentList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments;

            /*0x2a2f630*/ UIDocumentList();
            /*0x2a2f25c*/ void RemoveFromListAndFromVisualTree(UnityEngine.UIElements.UIDocument uiDocument);
            /*0x2a2f2dc*/ void AddToListAndToVisualTree(UnityEngine.UIElements.UIDocument uiDocument, UnityEngine.UIElements.VisualElement visualTree, int firstInsertIndex);
        }

        class UIDocument : UnityEngine.MonoBehaviour
        {
            static string k_RootStyleClassName = "unity-ui-document__root";
            static string k_VisualElementNameSuffix = "-container";
            static int k_DefaultSortingOrder = 0;
            static /*0x0*/ int s_CurrentUIDocumentCounter;
            /*0x18*/ int m_UIDocumentCreationIndex;
            /*0x20*/ UnityEngine.UIElements.PanelSettings m_PanelSettings;
            /*0x28*/ UnityEngine.UIElements.PanelSettings m_PreviousPanelSettings;
            /*0x30*/ UnityEngine.UIElements.UIDocument m_ParentUI;
            /*0x38*/ UnityEngine.UIElements.UIDocumentList m_ChildrenContent;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_ChildrenContentCopy;
            /*0x48*/ UnityEngine.UIElements.VisualTreeAsset sourceAsset;
            /*0x50*/ UnityEngine.UIElements.VisualElement m_RootVisualElement;
            /*0x58*/ int m_FirstChildInsertIndex;
            /*0x5c*/ float m_SortingOrder;

            /*0x2a2ff84*/ UIDocument();
            /*0x2a2f6ac*/ UnityEngine.UIElements.PanelSettings get_panelSettings();
            /*0x2a2f6b4*/ void set_panelSettings(UnityEngine.UIElements.PanelSettings value);
            /*0x2a2fa60*/ UnityEngine.UIElements.UIDocument get_parentUI();
            /*0x2a2fa68*/ void set_parentUI(UnityEngine.UIElements.UIDocument value);
            /*0x2a2fa70*/ UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset();
            /*0x2a2fa78*/ void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value);
            /*0x2a2f2d4*/ UnityEngine.UIElements.VisualElement get_rootVisualElement();
            /*0x2a2fe84*/ int get_firstChildInserIndex();
            /*0x2a2fe8c*/ float get_sortingOrder();
            /*0x2a2fe94*/ void set_sortingOrder(float value);
            /*0x2a2feac*/ void ApplySortingOrder();
            /*0x2a2fff4*/ void Awake();
            /*0x2a30088*/ void OnEnable();
            /*0x2a2fff8*/ void SetupFromHierarchy();
            /*0x2a30158*/ UnityEngine.UIElements.UIDocument FindUIDocumentParent();
            /*0x2a30228*/ void Reset();
            /*0x2a3032c*/ void AddChildAndInsertContentToVisualTree(UnityEngine.UIElements.UIDocument child);
            /*0x2a30148*/ void RemoveChild(UnityEngine.UIElements.UIDocument child);
            /*0x2a2fa80*/ void RecreateUI();
            /*0x2a30488*/ void SetupRootClassList();
            /*0x2a2feb0*/ void AddRootVisualElementToTree();
            /*0x2a303bc*/ void RemoveFromHierarchy();
            /*0x2a30524*/ void OnDisable();
            /*0x2a30544*/ void OnTransformChildrenChanged();
            /*0x2a307f8*/ void OnTransformParentChanged();
            /*0x2a30754*/ void ReactToHierarchyChanged();
        }

        enum DynamicAtlasFiltersInternal
        {
            None = 0,
            Readability = 1,
            Size = 2,
            Format = 4,
            ColorSpace = 8,
            FilterMode = 16,
        }

        class DynamicAtlasSettings
        {
            /*0x10*/ int m_MinAtlasSize;
            /*0x14*/ int m_MaxAtlasSize;
            /*0x18*/ int m_MaxSubTextureSize;
            /*0x1c*/ UnityEngine.UIElements.DynamicAtlasFiltersInternal m_ActiveFilters;
            /*0x20*/ UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter;

            static /*0x2a3083c*/ UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters();
            static /*0x2a30854*/ UnityEngine.UIElements.DynamicAtlasSettings get_defaults();
            /*0x2a308d4*/ DynamicAtlasSettings();
            /*0x2a307fc*/ int get_minAtlasSize();
            /*0x2a30804*/ void set_minAtlasSize(int value);
            /*0x2a3080c*/ int get_maxAtlasSize();
            /*0x2a30814*/ void set_maxAtlasSize(int value);
            /*0x2a3081c*/ int get_maxSubTextureSize();
            /*0x2a30824*/ void set_maxSubTextureSize(int value);
            /*0x2a3082c*/ UnityEngine.UIElements.DynamicAtlasFilters get_activeFilters();
            /*0x2a30834*/ void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value);
            /*0x2a30844*/ UnityEngine.UIElements.DynamicAtlasCustomFilter get_customFilter();
            /*0x2a3084c*/ void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value);
        }

        class RuntimePanel : UnityEngine.UIElements.BaseRuntimePanel
        {
            static /*0x0*/ UnityEngine.UIElements.EventDispatcher s_EventDispatcher;
            /*0x1d8*/ UnityEngine.UIElements.PanelSettings m_PanelSettings;

            static /*0x2a3123c*/ RuntimePanel();
            static /*0x2a308e4*/ UnityEngine.UIElements.RuntimePanel Create(UnityEngine.ScriptableObject ownerObject);
            /*0x2a30944*/ RuntimePanel(UnityEngine.ScriptableObject ownerObject);
            /*0x2a308dc*/ UnityEngine.UIElements.PanelSettings get_panelSettings();
            /*0x2a30bc0*/ void Update();
        }

        class RuntimeEventDispatcher
        {
            static /*0x2a31288*/ UnityEngine.UIElements.EventDispatcher Create();
        }

        class NavigateFocusRing : UnityEngine.UIElements.IFocusRing
        {
            static /*0x0*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Left;
            static /*0x8*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Right;
            static /*0x10*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Up;
            static /*0x18*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Down;
            static /*0x20*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Next;
            static /*0x28*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Previous;
            /*0x10*/ UnityEngine.UIElements.VisualElement m_Root;
            /*0x18*/ UnityEngine.UIElements.VisualElementFocusRing m_Ring;

            static /*0x2a3282c*/ NavigateFocusRing();
            static /*0x2a32518*/ bool IsActive(UnityEngine.UIElements.VisualElement v);
            static /*0x2a325f0*/ bool IsFocusable(UnityEngine.UIElements.Focusable focusable);
            static /*0x2a32630*/ bool IsLeaf(UnityEngine.UIElements.Focusable focusable);
            static /*0x2a32670*/ bool IsFocusRoot(UnityEngine.UIElements.VisualElement focusable);
            static /*0x2a324b8*/ UnityEngine.UIElements.VisualElement GetLeafFocusable(UnityEngine.UIElements.VisualElement v);
            static /*0x2a32720*/ UnityEngine.UIElements.VisualElement GetLeafFocusableRecursive(UnityEngine.UIElements.VisualElement v);
            static /*0x2a322f4*/ UnityEngine.UIElements.VisualElement GetRootFocusable(UnityEngine.UIElements.VisualElement v);
            /*0x2a30b3c*/ NavigateFocusRing(UnityEngine.UIElements.VisualElement root);
            /*0x2a31654*/ UnityEngine.UIElements.FocusController get_focusController();
            /*0x2a31678*/ UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e);
            /*0x2a31ab0*/ UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction);
            /*0x2a31d64*/ UnityEngine.UIElements.Focusable GetNextFocusable2D(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction);

            class ChangeDirection : UnityEngine.UIElements.FocusChangeDirection
            {
                /*0x2a32958*/ ChangeDirection(int i);
            }

            struct FocusableHierarchyTraversal
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement currentFocusable;
                /*0x18*/ UnityEngine.Rect validRect;
                /*0x28*/ bool firstPass;
                /*0x30*/ UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction;

                /*0x2a329c0*/ bool ValidateHierarchyTraversal(UnityEngine.UIElements.VisualElement v);
                /*0x2a32a70*/ bool ValidateElement(UnityEngine.UIElements.VisualElement v);
                /*0x2a32b34*/ int Order(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b);
                /*0x2a32f48*/ int StrictOrder(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b);
                /*0x2a32c20*/ int StrictOrder(UnityEngine.Rect ra, UnityEngine.Rect rb);
                /*0x2a32e14*/ int TieBreaker(UnityEngine.Rect ra, UnityEngine.Rect rb);
                /*0x2a3237c*/ UnityEngine.UIElements.VisualElement GetBestOverall(UnityEngine.UIElements.VisualElement candidate, UnityEngine.UIElements.VisualElement bestSoFar);
            }
        }

        enum PanelScaleMode
        {
            ConstantPixelSize = 0,
            ConstantPhysicalSize = 1,
            ScaleWithScreenSize = 2,
        }

        enum PanelScreenMatchMode
        {
            MatchWidthOrHeight = 0,
            Shrink = 1,
            Expand = 2,
        }

        class PanelSettings : UnityEngine.ScriptableObject
        {
            static int k_DefaultSortingOrder = 0;
            static float k_DefaultScaleValue = 1;
            static string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";
            static float DefaultDpi = 96;
            /*0x18*/ UnityEngine.UIElements.ThemeStyleSheet themeUss;
            /*0x20*/ UnityEngine.RenderTexture m_TargetTexture;
            /*0x28*/ UnityEngine.UIElements.PanelScaleMode m_ScaleMode;
            /*0x2c*/ float m_Scale;
            /*0x30*/ float m_ReferenceDpi;
            /*0x34*/ float m_FallbackDpi;
            /*0x38*/ UnityEngine.Vector2Int m_ReferenceResolution;
            /*0x40*/ UnityEngine.UIElements.PanelScreenMatchMode m_ScreenMatchMode;
            /*0x44*/ float m_Match;
            /*0x48*/ float m_SortingOrder;
            /*0x4c*/ int m_TargetDisplay;
            /*0x50*/ bool m_ClearDepthStencil;
            /*0x51*/ bool m_ClearColor;
            /*0x54*/ UnityEngine.Color m_ColorClearValue;
            /*0x68*/ UnityEngine.UIElements.PanelSettings.RuntimePanelAccess m_PanelAccess;
            /*0x70*/ UnityEngine.UIElements.UIDocumentList m_AttachedUIDocumentsList;
            /*0x78*/ UnityEngine.UIElements.DynamicAtlasSettings m_DynamicAtlasSettings;
            /*0x80*/ UnityEngine.Shader m_AtlasBlitShader;
            /*0x88*/ UnityEngine.Shader m_RuntimeShader;
            /*0x90*/ UnityEngine.Shader m_RuntimeWorldShader;
            /*0x98*/ UnityEngine.UIElements.PanelTextSettings textSettings;
            /*0xa0*/ UnityEngine.Rect m_TargetRect;
            /*0xb0*/ float m_ResolvedScale;
            /*0xb8*/ UnityEngine.UIElements.StyleSheet m_OldThemeUss;
            /*0xc0*/ int m_EmptyPanelCounter;
            /*0xc4*/ float <ScreenDPI>k__BackingField;
            /*0xc8*/ System.Func<UnityEngine.Vector2, UnityEngine.Vector2> m_AssignedScreenToPanel;

            /*0x2a33508*/ PanelSettings();
            /*0x2a32fcc*/ UnityEngine.UIElements.ThemeStyleSheet get_themeStyleSheet();
            /*0x2a32fd4*/ void set_themeStyleSheet(UnityEngine.UIElements.ThemeStyleSheet value);
            /*0x2a3313c*/ UnityEngine.RenderTexture get_targetTexture();
            /*0x2a33144*/ void set_targetTexture(UnityEngine.RenderTexture value);
            /*0x2a331a0*/ UnityEngine.UIElements.PanelScaleMode get_scaleMode();
            /*0x2a331a8*/ void set_scaleMode(UnityEngine.UIElements.PanelScaleMode value);
            /*0x2a331b0*/ float get_scale();
            /*0x2a331b8*/ void set_scale(float value);
            /*0x2a331c0*/ float get_referenceDpi();
            /*0x2a331c8*/ void set_referenceDpi(float value);
            /*0x2a331f4*/ float get_fallbackDpi();
            /*0x2a331fc*/ void set_fallbackDpi(float value);
            /*0x2a33228*/ UnityEngine.Vector2Int get_referenceResolution();
            /*0x2a33230*/ void set_referenceResolution(UnityEngine.Vector2Int value);
            /*0x2a33238*/ UnityEngine.UIElements.PanelScreenMatchMode get_screenMatchMode();
            /*0x2a33240*/ void set_screenMatchMode(UnityEngine.UIElements.PanelScreenMatchMode value);
            /*0x2a33248*/ float get_match();
            /*0x2a33250*/ void set_match(float value);
            /*0x2a33258*/ float get_sortingOrder();
            /*0x2a33260*/ void set_sortingOrder(float value);
            /*0x2a33280*/ void ApplySortingOrder();
            /*0x2a332cc*/ int get_targetDisplay();
            /*0x2a332d4*/ void set_targetDisplay(int value);
            /*0x2a33330*/ bool get_clearDepthStencil();
            /*0x2a33338*/ void set_clearDepthStencil(bool value);
            /*0x2a33344*/ float get_depthClearValue();
            /*0x2a33350*/ bool get_clearColor();
            /*0x2a33358*/ void set_clearColor(bool value);
            /*0x2a33364*/ UnityEngine.Color get_colorClearValue();
            /*0x2a33370*/ void set_colorClearValue(UnityEngine.Color value);
            /*0x2a3337c*/ UnityEngine.UIElements.BaseRuntimePanel get_panel();
            /*0x2a334cc*/ UnityEngine.UIElements.VisualElement get_visualTree();
            /*0x2a334f8*/ UnityEngine.UIElements.DynamicAtlasSettings get_dynamicAtlasSettings();
            /*0x2a33500*/ void set_dynamicAtlasSettings(UnityEngine.UIElements.DynamicAtlasSettings value);
            /*0x2a335e4*/ void Reset();
            /*0x2a335e8*/ void OnEnable();
            /*0x2a3387c*/ void OnDisable();
            /*0x2a338c8*/ void DisposePanel();
            /*0x2a338f4*/ float get_ScreenDPI();
            /*0x2a338fc*/ void set_ScreenDPI(float value);
            /*0x2a336f0*/ void UpdateScreenDPI();
            /*0x2a32fe0*/ void ApplyThemeStyleSheet(UnityEngine.UIElements.VisualElement root);
            /*0x2a3370c*/ void InitializeShaders();
            /*0x2a30c40*/ void ApplyPanelSettings();
            /*0x2a33be8*/ void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2, UnityEngine.Vector2> screentoPanelSpaceFunction);
            /*0x2a33ad0*/ float ResolveScale(UnityEngine.Rect targetRect, float screenDpi);
            /*0x2a33914*/ UnityEngine.Rect GetDisplayRect();
            /*0x2a2f9cc*/ void AttachAndInsertUIDocumentToVisualTree(UnityEngine.UIElements.UIDocument uiDocument);
            /*0x2a2f950*/ void DetachUIDocument(UnityEngine.UIElements.UIDocument uiDocument);

            class RuntimePanelAccess
            {
                /*0x10*/ UnityEngine.UIElements.PanelSettings m_Settings;
                /*0x18*/ UnityEngine.UIElements.BaseRuntimePanel m_RuntimePanel;

                /*0x2a335bc*/ RuntimePanelAccess(UnityEngine.UIElements.PanelSettings settings);
                /*0x2a33904*/ bool get_isInitialized();
                /*0x2a33394*/ UnityEngine.UIElements.BaseRuntimePanel get_panel();
                /*0x2a338a8*/ void DisposePanel();
                /*0x2a33178*/ void SetTargetTexture();
                /*0x2a33298*/ void SetSortingPriority();
                /*0x2a33308*/ void SetTargetDisplay();
                /*0x2a33c74*/ UnityEngine.UIElements.BaseRuntimePanel CreateRelatedRuntimePanel();
                /*0x2a33d6c*/ void DisposeRelatedPanel();
                /*0x2a33c18*/ void MarkPotentiallyEmpty();
            }
        }

        class PopupWindow : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string contentUssClassName;
            /*0x478*/ UnityEngine.UIElements.VisualElement m_ContentContainer;

            static /*0x2a33efc*/ PopupWindow();
            /*0x2a33dc8*/ PopupWindow();
            /*0x2a33ef4*/ UnityEngine.UIElements.VisualElement get_contentContainer();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.PopupWindow, UnityEngine.UIElements.PopupWindow.UxmlTraits>
            {
                /*0x2a2b6c8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x2a33f9c*/ UxmlTraits();
            }
        }

        class TreeView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string s_ListViewName;
            static /*0x8*/ string s_ItemName;
            static /*0x10*/ string s_ItemToggleName;
            static /*0x18*/ string s_ItemIndentsContainerName;
            static /*0x20*/ string s_ItemIndentName;
            static /*0x28*/ string s_ItemContentContainerName;
            /*0x3b0*/ System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;
            /*0x3b8*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onItemsChosen;
            /*0x3c0*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onSelectionChange;
            /*0x3c8*/ System.Collections.Generic.List<UnityEngine.UIElements.ITreeViewItem> m_SelectedItems;
            /*0x3d0*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> m_BindItem;
            /*0x3d8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> <unbindItem>k__BackingField;
            /*0x3e0*/ System.Collections.Generic.IList<UnityEngine.UIElements.ITreeViewItem> m_RootItems;
            /*0x3e8*/ System.Collections.Generic.List<int> m_ExpandedItemIds;
            /*0x3f0*/ System.Collections.Generic.List<UnityEngine.UIElements.TreeView.TreeViewItemWrapper> m_ItemWrappers;
            /*0x3f8*/ UnityEngine.UIElements.ListView m_ListView;
            /*0x400*/ UnityEngine.UIElements.ScrollView m_ScrollView;

            static /*0x2a370fc*/ TreeView();
            static /*0x2a346a0*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> GetAllItems(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems);
            /*0x2a34024*/ TreeView();
            /*0x2a33fa4*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> get_unbindItem();
            /*0x2a33fac*/ void set_itemHeight(int value);
            /*0x2a33fcc*/ void set_showBorder(bool value);
            /*0x2a33fec*/ void set_selectionType(UnityEngine.UIElements.SelectionType value);
            /*0x2a34008*/ void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value);
            /*0x2a34578*/ void RefreshItems();
            /*0x2a34640*/ void Rebuild();
            /*0x2a34664*/ void OnViewDataReady();
            /*0x2a34748*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x2a34624*/ void ListViewRefresh();
            /*0x2a34df4*/ void OnItemsChosen(System.Collections.Generic.IEnumerable<object> chosenItems);
            /*0x2a35214*/ void OnSelectionChange(System.Collections.Generic.IEnumerable<object> selectedListItems);
            /*0x2a35668*/ void OnTreeViewMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x2a356a0*/ void OnItemMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x2a35e9c*/ UnityEngine.UIElements.VisualElement MakeTreeItem();
            /*0x2a3637c*/ void UnbindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x2a36498*/ void BindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x2a367f4*/ int GetItemId(int index);
            /*0x2a34804*/ bool IsExpandedByIndex(int index);
            /*0x2a34ba8*/ void CollapseItemByIndex(int index);
            /*0x2a348a0*/ void ExpandItemByIndex(int index);
            /*0x2a36e28*/ void ToggleExpandedState(UnityEngine.UIElements.ChangeEvent<bool> evt);
            /*0x2a36908*/ void CreateWrappers(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> treeViewItems, int depth, ref System.Collections.Generic.List<UnityEngine.UIElements.TreeView.TreeViewItemWrapper> wrappers);
            /*0x2a3459c*/ void RegenerateWrappers();
            /*0x2a36fac*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TreeView, UnityEngine.UIElements.TreeView.UxmlTraits>
            {
                /*0x2a2b710*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_ItemHeight;
                /*0x78*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;
                /*0x88*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

                /*0x2a37468*/ UxmlTraits();
                /*0x2a37208*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            struct TreeViewItemWrapper
            {
                /*0x10*/ int depth;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem item;

                /*0x2a36868*/ int get_id();
            }

            class <GetAllItems>d__64 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems;
                /*0x30*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> <>3__rootItems;
                /*0x38*/ System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>> <iteratorStack>5__1;
                /*0x40*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> <currentIterator>5__2;
                /*0x48*/ bool <hasNext>5__3;
                /*0x50*/ UnityEngine.UIElements.ITreeViewItem <currentItem>5__4;

                /*0x2a34704*/ <GetAllItems>d__64(int <>1__state);
                /*0x2a37670*/ void System.IDisposable.Dispose();
                /*0x2a37674*/ bool MoveNext();
                /*0x2a37a6c*/ UnityEngine.UIElements.ITreeViewItem System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>.get_Current();
                /*0x2a37a74*/ void System.Collections.IEnumerator.Reset();
                /*0x2a37ab4*/ object System.Collections.IEnumerator.get_Current();
                /*0x2a37abc*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>.GetEnumerator();
                /*0x2a37b5c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class Label : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;

            static /*0x2a37bb0*/ Label();
            /*0x2a37b60*/ Label();
            /*0x2a2d8b8*/ Label(string text);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Label, UnityEngine.UIElements.Label.UxmlTraits>
            {
                /*0x2a2b638*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x2a37c10*/ UxmlTraits();
            }
        }

        class Slider : UnityEngine.UIElements.BaseSlider<float>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;

            static /*0x2a38314*/ Slider();
            /*0x2a37c18*/ Slider();
            /*0x2a37d7c*/ Slider(float start, float end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            /*0x2a37c30*/ Slider(string label, float start, float end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            /*0x2a37d88*/ float SliderLerpUnclamped(float a, float b, float interpolant);
            /*0x2a38038*/ float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue);
            /*0x2a38048*/ float ParseStringToValue(string stringValue);
            /*0x2a38118*/ void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<float> sliderKey, bool isShift);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Slider, UnityEngine.UIElements.Slider.UxmlTraits>
            {
                /*0x2a2b680*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<float, UnityEngine.UIElements.UxmlFloatAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;
                /*0x90*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;
                /*0x98*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_PageSize;
                /*0xa0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowInputField;
                /*0xa8*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;
                /*0xb0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Inverted;

                /*0x2a38698*/ UxmlTraits();
                /*0x2a383e4*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class KeyboardTextEditorEventHandler : UnityEngine.UIElements.TextEditorEventHandler
        {
            /*0x20*/ bool m_Changed;
            /*0x21*/ bool m_Dragged;
            /*0x22*/ bool m_DragToPosition;
            /*0x23*/ bool m_SelectAllOnMouseUp;
            /*0x28*/ string m_PreDrawCursorText;
            /*0x30*/ bool m_IsClicking;
            /*0x34*/ UnityEngine.Vector2 m_ClickStartPosition;
            /*0x40*/ UnityEngine.Event m_ImguiEvent;

            /*0x2a388fc*/ KeyboardTextEditorEventHandler(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField);
            /*0x2a388c0*/ bool get_isClicking();
            /*0x2a388c8*/ void set_isClicking(bool value);
            /*0x2a3897c*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x2a38f38*/ void OnFocus(UnityEngine.UIElements.FocusEvent _);
            /*0x2a390c8*/ void OnBlur(UnityEngine.UIElements.BlurEvent _);
            /*0x2a390d4*/ void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt);
            /*0x2a394c8*/ void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x2a39630*/ void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt);
            /*0x2a3a700*/ void ProcessDragMove(UnityEngine.UIElements.MouseMoveEvent evt);
            /*0x2a3a6dc*/ bool MoveDistanceQualifiesForDrag(UnityEngine.Vector2 start, UnityEngine.Vector2 current);
            /*0x2a39778*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x2a39d80*/ void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent evt);
            /*0x2a3a0e4*/ void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent evt);
            /*0x2a3a834*/ void PreDrawCursor(string newText);
            /*0x2a3ab74*/ void PostDrawCursor();
        }

        enum ScrollViewMode
        {
            Vertical = 0,
            Horizontal = 1,
            VerticalAndHorizontal = 2,
        }

        enum ScrollerVisibility
        {
            Auto = 0,
            AlwaysVisible = 1,
            Hidden = 2,
        }

        class ScrollView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ float k_DefaultScrollDecelerationRate;
            static /*0x4*/ float k_DefaultElasticity;
            static /*0x8*/ string ussClassName;
            static /*0x10*/ string viewportUssClassName;
            static /*0x18*/ string contentAndVerticalScrollUssClassName;
            static /*0x20*/ string contentUssClassName;
            static /*0x28*/ string hScrollerUssClassName;
            static /*0x30*/ string vScrollerUssClassName;
            static /*0x38*/ string horizontalVariantUssClassName;
            static /*0x40*/ string verticalVariantUssClassName;
            static /*0x48*/ string verticalHorizontalVariantUssClassName;
            static /*0x50*/ string scrollVariantUssClassName;
            /*0x3b0*/ UnityEngine.UIElements.ScrollerVisibility m_HorizontalScrollerVisibility;
            /*0x3b4*/ UnityEngine.UIElements.ScrollerVisibility m_VerticalScrollerVisibility;
            /*0x3b8*/ UnityEngine.UIElements.VisualElement m_AttachedRootVisualContainer;
            /*0x3c0*/ float m_SingleLineHeight;
            /*0x3c4*/ float m_HorizontalPageSize;
            /*0x3c8*/ float m_VerticalPageSize;
            /*0x3cc*/ float m_ScrollDecelerationRate;
            /*0x3d0*/ float m_Elasticity;
            /*0x3d4*/ UnityEngine.UIElements.ScrollView.TouchScrollBehavior m_TouchScrollBehavior;
            /*0x3d8*/ UnityEngine.UIElements.ScrollView.NestedInteractionKind m_NestedInteractionKind;
            /*0x3e0*/ UnityEngine.UIElements.VisualElement <contentViewport>k__BackingField;
            /*0x3e8*/ UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField;
            /*0x3f0*/ UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField;
            /*0x3f8*/ UnityEngine.UIElements.VisualElement m_ContentContainer;
            /*0x400*/ UnityEngine.UIElements.VisualElement m_ContentAndVerticalScrollContainer;
            /*0x408*/ UnityEngine.UIElements.ScrollViewMode m_Mode;
            /*0x40c*/ int m_ScrollingPointerId;
            /*0x410*/ UnityEngine.Vector2 m_StartPosition;
            /*0x418*/ UnityEngine.Vector2 m_PointerStartPosition;
            /*0x420*/ UnityEngine.Vector2 m_Velocity;
            /*0x428*/ UnityEngine.Vector2 m_SpringBackVelocity;
            /*0x430*/ UnityEngine.Vector2 m_LowBounds;
            /*0x438*/ UnityEngine.Vector2 m_HighBounds;
            /*0x440*/ float m_LastVelocityLerpTime;
            /*0x444*/ bool m_StartedMoving;
            /*0x445*/ bool m_TouchStoppedVelocity;
            /*0x448*/ UnityEngine.UIElements.VisualElement m_CapturedTarget;
            /*0x450*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerMoveEvent> m_CapturedTargetPointerMoveCallback;
            /*0x458*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent> m_CapturedTargetPointerUpCallback;
            /*0x460*/ UnityEngine.UIElements.IVisualElementScheduledItem m_PostPointerUpAnimation;

            static /*0x2a3fb20*/ ScrollView();
            static /*0x2a3e150*/ float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit);
            /*0x2a3c5c8*/ ScrollView();
            /*0x2a3c5d0*/ ScrollView(UnityEngine.UIElements.ScrollViewMode scrollViewMode);
            /*0x2a3ab98*/ UnityEngine.UIElements.ScrollerVisibility get_horizontalScrollerVisibility();
            /*0x2a3aba0*/ void set_horizontalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value);
            /*0x2a3b1c4*/ UnityEngine.UIElements.ScrollerVisibility get_verticalScrollerVisibility();
            /*0x2a3b1cc*/ void set_verticalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value);
            /*0x2a3b25c*/ void set_showHorizontal(bool value);
            /*0x2a3b278*/ void set_showVertical(bool value);
            /*0x2a3ac2c*/ bool get_needsHorizontal();
            /*0x2a3ac6c*/ bool get_needsVertical();
            /*0x2a3b39c*/ bool get_isVerticalScrollDisplayed();
            /*0x2a3b45c*/ bool get_isHorizontalScrollDisplayed();
            /*0x2a3b51c*/ UnityEngine.Vector2 get_scrollOffset();
            /*0x2a3b564*/ void set_scrollOffset(UnityEngine.Vector2 value);
            /*0x2a3b850*/ void set_horizontalPageSize(float value);
            /*0x2a3ba64*/ void set_verticalPageSize(float value);
            /*0x2a3b294*/ float get_scrollableWidth();
            /*0x2a3b318*/ float get_scrollableHeight();
            /*0x2a3bc78*/ bool get_hasInertia();
            /*0x2a3bc88*/ float get_scrollDecelerationRate();
            /*0x2a3bc90*/ void set_scrollDecelerationRate(float value);
            /*0x2a3bca0*/ float get_elasticity();
            /*0x2a3bca8*/ void set_elasticity(float value);
            /*0x2a3bcb8*/ UnityEngine.UIElements.ScrollView.TouchScrollBehavior get_touchScrollBehavior();
            /*0x2a3bcc0*/ void set_touchScrollBehavior(UnityEngine.UIElements.ScrollView.TouchScrollBehavior value);
            /*0x2a3bd58*/ UnityEngine.UIElements.ScrollView.NestedInteractionKind get_nestedInteractionKind();
            /*0x2a3bd60*/ void set_nestedInteractionKind(UnityEngine.UIElements.ScrollView.NestedInteractionKind value);
            /*0x2a3bd68*/ void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a3bdfc*/ void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a3b858*/ void UpdateHorizontalSliderPageSize();
            /*0x2a3ba6c*/ void UpdateVerticalSliderPageSize();
            /*0x2a3b5e8*/ void UpdateContentViewTransform();
            /*0x2a3be90*/ void ScrollTo(UnityEngine.UIElements.VisualElement child);
            /*0x2a3c2c8*/ float GetXDeltaOffset(UnityEngine.UIElements.VisualElement child);
            /*0x2a3c050*/ float GetYDeltaOffset(UnityEngine.UIElements.VisualElement child);
            /*0x2a3c540*/ float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax);
            /*0x2a3c590*/ UnityEngine.UIElements.VisualElement get_contentViewport();
            /*0x2a3c598*/ void set_contentViewport(UnityEngine.UIElements.VisualElement value);
            /*0x2a3c5a0*/ UnityEngine.UIElements.Scroller get_horizontalScroller();
            /*0x2a3c5a8*/ void set_horizontalScroller(UnityEngine.UIElements.Scroller value);
            /*0x2a3c5b0*/ UnityEngine.UIElements.Scroller get_verticalScroller();
            /*0x2a3c5b8*/ void set_verticalScroller(UnityEngine.UIElements.Scroller value);
            /*0x2a3c5c0*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x2a3d138*/ UnityEngine.UIElements.ScrollViewMode get_mode();
            /*0x2a3d140*/ void set_mode(UnityEngine.UIElements.ScrollViewMode value);
            /*0x2a3cfd0*/ void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode mode);
            /*0x2a3d154*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x2a3d714*/ void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x2a3db74*/ void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent evt);
            /*0x2a3dc70*/ void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt);
            /*0x2a3dffc*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a3e23c*/ void ComputeInitialSpringBackVelocity();
            /*0x2a3e338*/ void SpringBack();
            /*0x2a3e4c4*/ void ApplyScrollInertia();
            /*0x2a3e67c*/ void PostPointerUpAnimation();
            /*0x2a3e7cc*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x2a3eb40*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x2a3f128*/ void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x2a3f188*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x2a3ea04*/ void InitTouchScrolling(UnityEngine.Vector2 position);
            /*0x2a3ed3c*/ UnityEngine.UIElements.ScrollView.TouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2 position);
            /*0x2a3f230*/ bool ApplyTouchScrolling(UnityEngine.Vector2 newScrollOffset);
            /*0x2a3dd30*/ bool ReleaseScrolling(int pointerId, UnityEngine.UIElements.IEventHandler target);
            /*0x2a3f444*/ void AdjustScrollers();
            /*0x2a3acac*/ void UpdateScrollers(bool displayHorizontal, bool displayVertical);
            /*0x2a3f5e0*/ void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a3f790*/ void OnScrollWheel(UnityEngine.UIElements.WheelEvent evt);
            /*0x2a3fb1c*/ void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt);
            /*0x2a3d608*/ void ReadSingleLineHeight();
            /*0x2a3fd58*/ void <.ctor>b__103_0(float value);
            /*0x2a3fd88*/ void <.ctor>b__103_1(float value);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ScrollView, UnityEngine.UIElements.ScrollView.UxmlTraits>
            {
                /*0x2a3fdb8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollViewMode> m_ScrollViewMode;
                /*0x78*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.NestedInteractionKind> m_NestedInteractionKind;
                /*0x80*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowHorizontal;
                /*0x88*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowVertical;
                /*0x90*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_HorizontalScrollerVisibility;
                /*0x98*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_VerticalScrollerVisibility;
                /*0xa0*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HorizontalPageSize;
                /*0xa8*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_VerticalPageSize;
                /*0xb0*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.TouchScrollBehavior> m_TouchScrollBehavior;
                /*0xb8*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_ScrollDecelerationRate;
                /*0xc0*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_Elasticity;

                /*0x2a40190*/ UxmlTraits();
                /*0x2a3fe00*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            enum TouchScrollBehavior
            {
                Unrestricted = 0,
                Elastic = 1,
                Clamped = 2,
            }

            enum NestedInteractionKind
            {
                Default = 0,
                StopScrolling = 1,
                ForwardScrolling = 2,
            }

            enum TouchScrollingResult
            {
                Apply = 0,
                Forward = 1,
                Block = 2,
            }
        }

        class RepeatButton : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;
            /*0x478*/ UnityEngine.UIElements.Clickable m_Clickable;

            static /*0x2a40710*/ RepeatButton();
            /*0x2a40598*/ RepeatButton();
            /*0x2a4062c*/ RepeatButton(System.Action clickEvent, long delay, long interval);
            /*0x2a4066c*/ void SetAction(System.Action clickEvent, long delay, long interval);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.RepeatButton, UnityEngine.UIElements.RepeatButton.UxmlTraits>
            {
                /*0x2a40770*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x90*/ UnityEngine.UIElements.UxmlLongAttributeDescription m_Delay;
                /*0x98*/ UnityEngine.UIElements.UxmlLongAttributeDescription m_Interval;

                /*0x2a408ec*/ UxmlTraits();
                /*0x2a407b8*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class DropdownField : UnityEngine.UIElements.BaseField<string>
        {
            static /*0x0*/ string ussClassNameBasePopupField;
            static /*0x8*/ string textUssClassNameBasePopupField;
            static /*0x10*/ string arrowUssClassNameBasePopupField;
            static /*0x18*/ string labelUssClassNameBasePopupField;
            static /*0x20*/ string inputUssClassNameBasePopupField;
            static /*0x28*/ string ussClassNamePopupField;
            static /*0x30*/ string labelUssClassNamePopupField;
            static /*0x38*/ string inputUssClassNamePopupField;
            /*0x408*/ System.Collections.Generic.List<string> m_Choices;
            /*0x410*/ UnityEngine.UIElements.TextElement m_TextElement;
            /*0x418*/ UnityEngine.UIElements.VisualElement m_ArrowElement;
            /*0x420*/ System.Func<string, string> m_FormatSelectedValueCallback;
            /*0x428*/ System.Func<string, string> m_FormatListItemCallback;
            /*0x430*/ System.Func<UnityEngine.UIElements.IGenericMenu> createMenuCallback;
            /*0x438*/ int m_Index;

            static /*0x2a41aa4*/ DropdownField();
            /*0x2a40b8c*/ DropdownField();
            /*0x2a40b94*/ DropdownField(string label);
            /*0x2a409b0*/ UnityEngine.UIElements.TextElement get_textElement();
            /*0x2a409b8*/ string GetValueToDisplay();
            /*0x2a40a44*/ string GetListItemToDisplay(string value);
            /*0x2a40af0*/ void set_index(int value);
            /*0x2a40ea4*/ void AddMenuItems(UnityEngine.UIElements.IGenericMenu menu);
            /*0x2a411b4*/ void ChangeValueFromMenu(string menuItem);
            /*0x2a411c4*/ void set_choices(System.Collections.Generic.List<string> value);
            /*0x2a41234*/ string get_value();
            /*0x2a4127c*/ void set_value(string value);
            /*0x2a41300*/ void SetValueWithoutNotify(string newValue);
            /*0x2a41410*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x2a41590*/ void ShowMenu();
            /*0x2a419e4*/ void UpdateMixedValueContent();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.DropdownField, UnityEngine.UIElements.DropdownField.UxmlTraits>
            {
                /*0x2a41c34*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseField.UxmlTraits<string>
            {
                /*0x80*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_Index;
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Choices;

                /*0x2a41df8*/ UxmlTraits();
                /*0x2a41c7c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            class PopupTextElement : UnityEngine.UIElements.TextElement
            {
                /*0x2a40e4c*/ PopupTextElement();
                /*0x2a41ee4*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ string item;
                /*0x18*/ UnityEngine.UIElements.DropdownField <>4__this;

                /*0x2a411ac*/ <>c__DisplayClass38_0();
                /*0x2a41f88*/ void <AddMenuItems>b__0();
            }
        }

        class TextField : UnityEngine.UIElements.TextInputBaseField<string>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;

            static /*0x2a425b8*/ TextField();
            /*0x2a42124*/ TextField();
            /*0x2a4213c*/ TextField(string label);
            /*0x2a42150*/ TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar);
            /*0x2a41fb4*/ UnityEngine.UIElements.TextField.TextInput get_textInput();
            /*0x2a42038*/ void set_multiline(bool value);
            /*0x2a42374*/ string get_value();
            /*0x2a423bc*/ void set_value(string value);
            /*0x2a42460*/ void SetValueWithoutNotify(string newValue);
            /*0x2a42504*/ void OnViewDataReady();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TextField, UnityEngine.UIElements.TextField.UxmlTraits>
            {
                /*0x2a42688*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextInputBaseField.UxmlTraits<string>
            {
                /*0xb8*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Multiline;

                /*0x2a427e4*/ UxmlTraits();
                /*0x2a426d0*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            class TextInput : UnityEngine.UIElements.TextInputBaseField.TextInputBase<string>
            {
                /*0x410*/ bool m_Multiline;

                /*0x2a4232c*/ TextInput();
                /*0x2a42884*/ UnityEngine.UIElements.TextField get_parentTextField();
                /*0x2a42904*/ bool get_multiline();
                /*0x2a42058*/ void set_multiline(bool value);
                /*0x2a4290c*/ void SetTextAlign();
                /*0x2a429ac*/ void set_isPasswordField(bool value);
                /*0x2a42a08*/ string StringToValue(string str);
                /*0x2a42a10*/ void SyncTextEngine();
                /*0x2a42aa0*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
                /*0x2a431d0*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            }
        }

        class Scroller : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string horizontalVariantUssClassName;
            static /*0x10*/ string verticalVariantUssClassName;
            static /*0x18*/ string sliderUssClassName;
            static /*0x20*/ string lowButtonUssClassName;
            static /*0x28*/ string highButtonUssClassName;
            /*0x3b0*/ System.Action<float> valueChanged;
            /*0x3b8*/ UnityEngine.UIElements.Slider <slider>k__BackingField;
            /*0x3c0*/ UnityEngine.UIElements.RepeatButton <lowButton>k__BackingField;
            /*0x3c8*/ UnityEngine.UIElements.RepeatButton <highButton>k__BackingField;

            static /*0x2a43f68*/ Scroller();
            /*0x2a43898*/ Scroller();
            /*0x2a438ac*/ Scroller(float lowValue, float highValue, System.Action<float> valueChanged, UnityEngine.UIElements.SliderDirection direction);
            /*0x2a4335c*/ void add_valueChanged(System.Action<float> value);
            /*0x2a43410*/ void remove_valueChanged(System.Action<float> value);
            /*0x2a434c4*/ UnityEngine.UIElements.Slider get_slider();
            /*0x2a434cc*/ void set_slider(UnityEngine.UIElements.Slider value);
            /*0x2a434d4*/ UnityEngine.UIElements.RepeatButton get_lowButton();
            /*0x2a434dc*/ void set_lowButton(UnityEngine.UIElements.RepeatButton value);
            /*0x2a434e4*/ UnityEngine.UIElements.RepeatButton get_highButton();
            /*0x2a434ec*/ void set_highButton(UnityEngine.UIElements.RepeatButton value);
            /*0x2a434f4*/ float get_value();
            /*0x2a43518*/ void set_value(float value);
            /*0x2a4353c*/ float get_lowValue();
            /*0x2a4358c*/ void set_lowValue(float value);
            /*0x2a435ec*/ float get_highValue();
            /*0x2a4363c*/ void set_highValue(float value);
            /*0x2a4369c*/ void set_direction(UnityEngine.UIElements.SliderDirection value);
            /*0x2a43c54*/ void Adjust(float factor);
            /*0x2a43ccc*/ void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<float> evt);
            /*0x2a43d68*/ void ScrollPageUp();
            /*0x2a43e68*/ void ScrollPageDown();
            /*0x2a43d70*/ void ScrollPageUp(float factor);
            /*0x2a43e70*/ void ScrollPageDown(float factor);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Scroller, UnityEngine.UIElements.Scroller.UxmlTraits>
            {
                /*0x2a440d8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;
                /*0x78*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_Value;

                /*0x2a4430c*/ UxmlTraits();
                /*0x2a44120*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class Box : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;

            static /*0x2a445fc*/ Box();
            /*0x2a44568*/ Box();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Box>
            {
                /*0x2a4465c*/ UxmlFactory();
            }
        }

        class BaseBoolField : UnityEngine.UIElements.BaseField<bool>
        {
            /*0x408*/ UnityEngine.UIElements.Label m_Label;
            /*0x410*/ UnityEngine.UIElements.VisualElement m_CheckMark;
            /*0x418*/ UnityEngine.UIElements.Clickable m_Clickable;
            /*0x420*/ string m_OriginalText;

            /*0x2a446a4*/ BaseBoolField(string label);
            /*0x2a449c8*/ void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt);
            /*0x2a449fc*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x2a44b10*/ string get_text();
            /*0x2a44940*/ void set_text(string value);
            /*0x2a44b2c*/ void InitLabel();
            /*0x2a44bc0*/ void SetValueWithoutNotify(bool newValue);
            /*0x2a44ca0*/ void OnClickEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a44f28*/ void ToggleValue();
            /*0x2a44f60*/ void UpdateMixedValueContent();
        }

        enum ListViewReorderMode
        {
            Simple = 0,
            Animated = 1,
        }

        class ListView : UnityEngine.UIElements.BaseVerticalCollectionView
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string itemUssClassName;
            static /*0x10*/ string emptyLabelUssClassName;
            static /*0x18*/ string reorderableUssClassName;
            static /*0x20*/ string reorderableItemUssClassName;
            static /*0x28*/ string reorderableItemContainerUssClassName;
            static /*0x30*/ string reorderableItemHandleUssClassName;
            static /*0x38*/ string reorderableItemHandleBarUssClassName;
            static /*0x40*/ string footerUssClassName;
            static /*0x48*/ string foldoutHeaderUssClassName;
            static /*0x50*/ string arraySizeFieldUssClassName;
            static /*0x58*/ string listViewWithHeaderUssClassName;
            static /*0x60*/ string listViewWithFooterUssClassName;
            static /*0x68*/ string scrollViewWithFooterUssClassName;
            static /*0x70*/ string footerAddButtonName;
            static /*0x78*/ string footerRemoveButtonName;
            /*0x494*/ bool m_ShowBoundCollectionSize;
            /*0x495*/ bool m_ShowFoldoutHeader;
            /*0x498*/ string m_HeaderTitle;
            /*0x4a0*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsAdded;
            /*0x4a8*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsRemoved;
            /*0x4b0*/ UnityEngine.UIElements.Label m_EmptyListLabel;
            /*0x4b8*/ UnityEngine.UIElements.Foldout m_Foldout;
            /*0x4c0*/ UnityEngine.UIElements.TextField m_ArraySizeField;
            /*0x4c8*/ UnityEngine.UIElements.VisualElement m_Footer;
            /*0x4d0*/ UnityEngine.UIElements.Button m_AddButton;
            /*0x4d8*/ UnityEngine.UIElements.Button m_RemoveButton;
            /*0x4e0*/ System.Action<System.Collections.Generic.IEnumerable<int>> m_ItemAddedCallback;
            /*0x4e8*/ System.Action<System.Collections.Generic.IEnumerable<int>> m_ItemRemovedCallback;
            /*0x4f0*/ System.Action m_ItemsSourceSizeChangedCallback;
            /*0x4f8*/ UnityEngine.UIElements.ListViewController m_ListViewController;
            /*0x500*/ UnityEngine.UIElements.ListViewReorderMode m_ReorderMode;

            static /*0x2a46a4c*/ ListView();
            /*0x2a4698c*/ ListView();
            /*0x2a450e4*/ bool get_showBoundCollectionSize();
            /*0x2a450ec*/ void set_showBoundCollectionSize(bool value);
            /*0x2a452dc*/ bool get_sourceIncludesArraySize();
            /*0x2a45304*/ bool get_showFoldoutHeader();
            /*0x2a4530c*/ void set_showFoldoutHeader(bool value);
            /*0x2a45108*/ void SetupArraySizeField();
            /*0x2a45e6c*/ void set_headerTitle(string value);
            /*0x2a45ac0*/ bool get_showAddRemoveFooter();
            /*0x2a45e84*/ void set_showAddRemoveFooter(bool value);
            /*0x2a45ad0*/ void EnableFooter(bool enabled);
            /*0x2a46054*/ void AddItems(int itemCount);
            /*0x2a46078*/ void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<string> evt);
            /*0x2a45dfc*/ void UpdateArraySizeField();
            /*0x2a45904*/ void UpdateEmpty();
            /*0x2a46180*/ void OnAddClicked();
            /*0x2a463cc*/ void OnRemoveClicked();
            /*0x2a46598*/ UnityEngine.UIElements.ListViewController get_viewController();
            /*0x2a465a0*/ void CreateVirtualizationController();
            /*0x2a465e8*/ void CreateViewController();
            /*0x2a4664c*/ void SetViewController(UnityEngine.UIElements.ListViewController controller);
            /*0x2a46808*/ void OnItemAdded(System.Collections.Generic.IEnumerable<int> indices);
            /*0x2a46824*/ void OnItemsRemoved(System.Collections.Generic.IEnumerable<int> indices);
            /*0x2a46840*/ void OnItemsSourceSizeChanged();
            /*0x2a46848*/ UnityEngine.UIElements.ListViewReorderMode get_reorderMode();
            /*0x2a46850*/ void set_reorderMode(UnityEngine.UIElements.ListViewReorderMode value);
            /*0x2a46888*/ UnityEngine.UIElements.ListViewDragger CreateDragger();
            /*0x2a46928*/ UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController();
            /*0x2a46a28*/ void PostRefresh();
            /*0x2a46d98*/ void <OnAddClicked>b__35_0();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ListView, UnityEngine.UIElements.ListView.UxmlTraits>
            {
                /*0x2a46e68*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedItemHeight;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.CollectionVirtualizationMethod> m_VirtualizationMethod;
                /*0x88*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;
                /*0x90*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;
                /*0x98*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;
                /*0xa0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowFoldoutHeader;
                /*0xa8*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_HeaderTitle;
                /*0xb0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowAddRemoveFooter;
                /*0xb8*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Reorderable;
                /*0xc0*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ListViewReorderMode> m_ReorderMode;
                /*0xc8*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBoundCollectionSize;
                /*0xd0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;

                /*0x2a47284*/ UxmlTraits();
                /*0x2a46eb0*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        interface IGenericMenu
        {
            void AddItem(string itemName, bool isChecked, System.Action action);
            void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, bool anchored);
        }

        class GenericDropdownMenu : UnityEngine.UIElements.IGenericMenu
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string itemUssClassName;
            static /*0x10*/ string labelUssClassName;
            static /*0x18*/ string containerInnerUssClassName;
            static /*0x20*/ string containerOuterUssClassName;
            static /*0x28*/ string checkmarkUssClassName;
            static /*0x30*/ string separatorUssClassName;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.GenericDropdownMenu.MenuItem> m_Items;
            /*0x18*/ UnityEngine.UIElements.VisualElement m_MenuContainer;
            /*0x20*/ UnityEngine.UIElements.VisualElement m_OuterContainer;
            /*0x28*/ UnityEngine.UIElements.ScrollView m_ScrollView;
            /*0x30*/ UnityEngine.UIElements.VisualElement m_PanelRootVisualContainer;
            /*0x38*/ UnityEngine.UIElements.VisualElement m_TargetElement;
            /*0x40*/ UnityEngine.Rect m_DesiredRect;
            /*0x50*/ UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator;
            /*0x58*/ UnityEngine.Vector2 m_MousePosition;

            static /*0x2a49df0*/ GenericDropdownMenu();
            /*0x2a41710*/ GenericDropdownMenu();
            /*0x2a477a0*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x2a477c4*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x2a47bfc*/ void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x2a47fa0*/ void Hide();
            /*0x2a48088*/ void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent);
            /*0x2a480c4*/ bool Apply(UnityEngine.UIElements.KeyboardNavigationOperation op);
            /*0x2a4844c*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x2a486a0*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x2a487cc*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x2a48908*/ void OnFocusOut(UnityEngine.UIElements.FocusOutEvent evt);
            /*0x2a48a50*/ void OnParentResized(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a48578*/ void UpdateSelection(UnityEngine.UIElements.VisualElement target);
            /*0x2a48a54*/ void ChangeSelectedIndex(int newIndex, int previousIndex);
            /*0x2a48248*/ int GetSelectedIndex();
            /*0x2a48b88*/ void AddItem(string itemName, bool isChecked, System.Action action);
            /*0x2a48ef0*/ void AddSeparator(string path);
            /*0x2a48bb0*/ UnityEngine.UIElements.GenericDropdownMenu.MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data);
            /*0x2a48fa8*/ void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, bool anchored);
            /*0x2a49de8*/ void OnTargetElementDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x2a49dec*/ void OnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a49704*/ void EnsureVisibilityInParent();
            /*0x2a48390*/ void <Apply>g__UpdateSelectionDown|27_0(int newIndex, ref UnityEngine.UIElements.GenericDropdownMenu.<> );
            /*0x2a482e8*/ void <Apply>g__UpdateSelectionUp|27_1(int newIndex, ref UnityEngine.UIElements.GenericDropdownMenu.<> );

            class MenuItem
            {
                /*0x10*/ string name;
                /*0x18*/ UnityEngine.UIElements.VisualElement element;
                /*0x20*/ System.Action action;
                /*0x28*/ System.Action<object> actionUserData;

                /*0x2a48fa0*/ MenuItem();
            }

            struct <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.UIElements.GenericDropdownMenu <>4__this;
                /*0x18*/ int selectedIndex;
            }
        }

        class RadioButton : UnityEngine.UIElements.BaseBoolField, UnityEngine.UIElements.IGroupBoxOption
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;
            static /*0x18*/ string checkmarkBackgroundUssClassName;
            static /*0x20*/ string checkmarkUssClassName;
            static /*0x28*/ string textUssClassName;
            /*0x428*/ UnityEngine.UIElements.VisualElement m_CheckmarkBackground;

            static /*0x2a4a514*/ RadioButton();
            /*0x2a4a1ac*/ RadioButton();
            /*0x2a4a1b4*/ RadioButton(string label);
            /*0x2a49f90*/ bool get_value();
            /*0x2a49fd8*/ void set_value(bool value);
            /*0x2a4a38c*/ void InitLabel();
            /*0x2a4a404*/ void ToggleValue();
            /*0x2a4a444*/ void SetSelected(bool selected);
            /*0x2a4a458*/ void SetValueWithoutNotify(bool newValue);
            /*0x2a4a0b8*/ void UpdateCheckmark();
            /*0x2a4a474*/ void UpdateMixedValueContent();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.RadioButton, UnityEngine.UIElements.RadioButton.UxmlTraits>
            {
                /*0x2a4a684*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<bool, UnityEngine.UIElements.UxmlBoolAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;

                /*0x2a4a7e4*/ UxmlTraits();
                /*0x2a4a6cc*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class Image : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> s_ImageProperty;
            static /*0x10*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> s_SpriteProperty;
            static /*0x18*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> s_VectorImageProperty;
            static /*0x20*/ UnityEngine.UIElements.CustomStyleProperty<string> s_ScaleModeProperty;
            static /*0x28*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_TintColorProperty;
            /*0x3b0*/ UnityEngine.ScaleMode m_ScaleMode;
            /*0x3b8*/ UnityEngine.Texture m_Image;
            /*0x3c0*/ UnityEngine.Sprite m_Sprite;
            /*0x3c8*/ UnityEngine.UIElements.VectorImage m_VectorImage;
            /*0x3d0*/ UnityEngine.Rect m_UV;
            /*0x3e0*/ UnityEngine.Color m_TintColor;
            /*0x3f0*/ bool m_ImageIsInline;
            /*0x3f1*/ bool m_ScaleModeIsInline;
            /*0x3f2*/ bool m_TintColorIsInline;

            static /*0x2a4ba2c*/ Image();
            /*0x2a4ab14*/ Image();
            /*0x2a4a884*/ UnityEngine.Texture get_image();
            /*0x2a4a88c*/ UnityEngine.Sprite get_sprite();
            /*0x2a4a894*/ UnityEngine.UIElements.VectorImage get_vectorImage();
            /*0x2a4a89c*/ UnityEngine.Rect get_sourceRect();
            /*0x2a4aae4*/ UnityEngine.Rect get_uv();
            /*0x2a4aaf8*/ UnityEngine.ScaleMode get_scaleMode();
            /*0x2a4ab00*/ UnityEngine.Color get_tintColor();
            /*0x2a4acfc*/ UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Texture texture);
            /*0x2a4add8*/ UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Sprite sprite);
            /*0x2a4aee0*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
            /*0x2a4b124*/ void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
            /*0x2a4b610*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
            /*0x2a4ba08*/ void SetScaleMode(UnityEngine.ScaleMode mode);
            /*0x2a4a8a0*/ UnityEngine.Rect GetSourceRect();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Image, UnityEngine.UIElements.Image.UxmlTraits>
            {
                /*0x2a4bc08*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x2a4bc50*/ UxmlTraits();
            }
        }

        interface IBindable
        {
            UnityEngine.UIElements.IBinding get_binding();
            void set_bindingPath(string value);
        }

        interface IBinding
        {
            void PreUpdate();
            void Update();
            void Release();
        }

        interface IInternalListViewBinding
        {
        }

        class Foldout : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.INotifyValueChanged<bool>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string toggleUssClassName;
            static /*0x10*/ string contentUssClassName;
            static /*0x18*/ string inputUssClassName;
            static /*0x20*/ string checkmarkUssClassName;
            static /*0x28*/ string textUssClassName;
            static /*0x30*/ string ussFoldoutDepthClassName;
            static /*0x38*/ int ussFoldoutMaxDepth;
            /*0x3c0*/ UnityEngine.UIElements.Toggle m_Toggle;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_Container;
            /*0x3d0*/ bool m_Value;

            static /*0x2a4c170*/ Foldout();
            /*0x2a454b0*/ Foldout();
            /*0x2a4bc58*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x2a457e0*/ void set_text(string value);
            /*0x2a4bc60*/ bool get_value();
            /*0x2a4bc68*/ void set_value(bool value);
            /*0x2a4be48*/ void SetValueWithoutNotify(bool newValue);
            /*0x2a4bf68*/ void OnViewDataReady();
            /*0x2a4bfb0*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x2a4c318*/ void <.ctor>b__23_0(UnityEngine.UIElements.ChangeEvent<bool> evt);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Foldout, UnityEngine.UIElements.Foldout.UxmlTraits>
            {
                /*0x2a4c368*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x80*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Value;

                /*0x2a4c4e0*/ UxmlTraits();
                /*0x2a4c3b0*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class TextEditorEngine : UnityEngine.TextEditor
        {
            /*0x90*/ UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction m_DetectFocusChangeFunction;
            /*0x98*/ UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction m_IndexChangeFunction;

            /*0x2a4c5cc*/ TextEditorEngine(UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction detectFocusChange, UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction indexChangeFunction);
            /*0x2a4c5f8*/ UnityEngine.Rect get_localPosition();
            /*0x2a4c680*/ void OnDetectFocusChange();
            /*0x2a4c6a4*/ void OnCursorIndexChange();
            /*0x2a4c6c8*/ void OnSelectIndexChange();

            class OnDetectFocusChangeFunction : System.MulticastDelegate
            {
                /*0x2a4c6ec*/ OnDetectFocusChangeFunction(object object, nint method);
                /*0x2a4c7a8*/ void Invoke();
            }

            class OnIndexChangeFunction : System.MulticastDelegate
            {
                /*0x2a4c7bc*/ OnIndexChangeFunction(object object, nint method);
                /*0x2a4c878*/ void Invoke();
            }
        }

        class Toggle : UnityEngine.UIElements.BaseBoolField
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;
            static /*0x18*/ string noTextVariantUssClassName;
            static /*0x20*/ string checkmarkUssClassName;
            static /*0x28*/ string textUssClassName;

            static /*0x2a4ca00*/ Toggle();
            /*0x2a4bfa8*/ Toggle();
            /*0x2a4c88c*/ Toggle(string label);
            /*0x2a4c988*/ void InitLabel();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Toggle, UnityEngine.UIElements.Toggle.UxmlTraits>
            {
                /*0x2a4cb70*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<bool, UnityEngine.UIElements.UxmlBoolAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;

                /*0x2a4ccd0*/ UxmlTraits();
                /*0x2a4cbb8*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class TextEditorEventHandler
        {
            /*0x10*/ UnityEngine.UIElements.TextEditorEngine <editorEngine>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.ITextInputField <textInputField>k__BackingField;

            /*0x2a4cd90*/ TextEditorEventHandler(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField);
            /*0x2a4cd70*/ UnityEngine.UIElements.TextEditorEngine get_editorEngine();
            /*0x2a4cd78*/ void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value);
            /*0x2a4cd80*/ UnityEngine.UIElements.ITextInputField get_textInputField();
            /*0x2a4cd88*/ void set_textInputField(UnityEngine.UIElements.ITextInputField value);
            /*0x2a4ce50*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x2a4ce54*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
        }

        interface ITextInputField : UnityEngine.UIElements.IEventHandler, UnityEngine.UIElements.ITextElement
        {
            bool get_hasFocus();
            bool get_doubleClickSelectsWord();
            bool get_tripleClickSelectsLine();
            bool get_isReadOnly();
            bool get_isDelayed();
            bool get_isPasswordField();
            UnityEngine.UIElements.TextEditorEngine get_editorEngine();
            void SyncTextEngine();
            bool AcceptCharacter(char c);
            string CullString(string s);
            void UpdateText(string value);
            void UpdateValueFromText();
        }

        class TextInputBaseField<TValueType> : UnityEngine.UIElements.BaseField<TValueType>
        {
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty;
            static /*0x0*/ string ussClassName;
            static /*0x0*/ string labelUssClassName;
            static /*0x0*/ string inputUssClassName;
            static /*0x0*/ string singleLineInputUssClassName;
            static /*0x0*/ string multilineInputUssClassName;
            static /*0x0*/ string textInputUssName;
            /*0x0*/ int m_VisualInputTabIndex;
            /*0x0*/ UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> m_TextInputBase;
            /*0x0*/ UnityEngine.UIElements.ITextHandle <iTextHandle>k__BackingField;
            /*0x0*/ System.Action<bool> onIsReadOnlyChanged;

            static TextInputBaseField();
            TextInputBaseField(string label, int maxLength, char maskChar, UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInputBase);
            UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> get_textInputBase();
            void set_iTextHandle(UnityEngine.UIElements.ITextHandle value);
            void set_text(string value);
            void set_isReadOnly(bool value);
            void set_isPasswordField(bool value);
            void set_maxLength(int value);
            bool get_isDelayed();
            void set_isDelayed(bool value);
            void set_maskChar(char value);
            void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e);
            void OnFieldCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
            void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            void UpdateMixedValueContent();

            class UxmlTraits<TValueType> : UnityEngine.UIElements.BaseFieldTraits<string, UnityEngine.UIElements.UxmlStringAttributeDescription>
            {
                /*0x0*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_MaxLength;
                /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Password;
                /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_MaskCharacter;
                /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsReadOnly;
                /*0x0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsDelayed;

                UxmlTraits();
                void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            class TextInputBase<TValueType> : UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITextInputField, UnityEngine.UIElements.IEventHandler, UnityEngine.UIElements.ITextElement
            {
                /*0x0*/ string m_OriginalText;
                /*0x0*/ bool <isReadOnly>k__BackingField;
                /*0x0*/ int <maxLength>k__BackingField;
                /*0x0*/ char <maskChar>k__BackingField;
                /*0x0*/ bool <isPasswordField>k__BackingField;
                /*0x0*/ bool <doubleClickSelectsWord>k__BackingField;
                /*0x0*/ bool <tripleClickSelectsLine>k__BackingField;
                /*0x0*/ bool <isDelayed>k__BackingField;
                /*0x0*/ bool <isDragging>k__BackingField;
                /*0x0*/ bool m_TouchScreenTextFieldInitialized;
                /*0x0*/ UnityEngine.UIElements.IVisualElementScheduledItem m_HardwareKeyboardPoller;
                /*0x0*/ UnityEngine.Color m_SelectionColor;
                /*0x0*/ UnityEngine.Color m_CursorColor;
                /*0x0*/ UnityEngine.UIElements.TextEditorEventHandler <editorEventHandler>k__BackingField;
                /*0x0*/ UnityEngine.UIElements.TextEditorEngine <editorEngine>k__BackingField;
                /*0x0*/ UnityEngine.UIElements.ITextHandle m_TextHandle;
                /*0x0*/ string m_Text;

                static void SyncGUIStyle(UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInput, UnityEngine.GUIStyle style);
                static bool IsLayoutUsingPercent(UnityEngine.UIElements.VisualElement ve);
                static void AssignRect(UnityEngine.RectOffset rect, int left, int top, int right, int bottom);
                TextInputBase();
                void ResetValueAndText();
                void SaveValueAndText();
                void RestoreValueAndText();
                void UpdateText(string value);
                TValueType StringToValue(string str);
                void UpdateValueFromText();
                bool UnityEngine.UIElements.ITextInputField.get_isReadOnly();
                bool get_isReadOnly();
                void set_isReadOnly(bool value);
                int get_maxLength();
                void set_maxLength(int value);
                char get_maskChar();
                void set_maskChar(char value);
                bool get_isPasswordField();
                void set_isPasswordField(bool value);
                bool get_doubleClickSelectsWord();
                void set_doubleClickSelectsWord(bool value);
                bool get_tripleClickSelectsLine();
                void set_tripleClickSelectsLine(bool value);
                bool get_isDelayed();
                void set_isDelayed(bool value);
                bool get_isDragging();
                bool get_touchScreenTextField();
                bool get_touchScreenTextFieldChanged();
                UnityEngine.Color get_selectionColor();
                UnityEngine.Color get_cursorColor();
                bool get_hasFocus();
                UnityEngine.UIElements.TextEditorEventHandler get_editorEventHandler();
                void set_editorEventHandler(UnityEngine.UIElements.TextEditorEventHandler value);
                UnityEngine.UIElements.TextEditorEngine get_editorEngine();
                void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value);
                string get_text();
                void set_text(string value);
                void InitTextEditorEventHandler();
                UnityEngine.UIElements.DropdownMenuAction.Status CutActionStatus(UnityEngine.UIElements.DropdownMenuAction a);
                UnityEngine.UIElements.DropdownMenuAction.Status CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction a);
                UnityEngine.UIElements.DropdownMenuAction.Status PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction a);
                void ProcessMenuCommand(string command);
                void Cut(UnityEngine.UIElements.DropdownMenuAction a);
                void Copy(UnityEngine.UIElements.DropdownMenuAction a);
                void Paste(UnityEngine.UIElements.DropdownMenuAction a);
                void OnInputCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
                void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent attachEvent);
                void SyncTextEngine();
                string CullString(string s);
                void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc);
                void DrawWithTextSelectionAndCursor(UnityEngine.UIElements.MeshGenerationContext mgc, string newText, float pixelsPerPoint);
                bool AcceptCharacter(char c);
                void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent evt);
                void OnDetectFocusChange();
                void OnCursorIndexChange();
                UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);
                void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt);
                void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
                void ProcessEventAtTarget(UnityEngine.UIElements.EventBase evt);
                void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
                bool UnityEngine.UIElements.ITextInputField.get_hasFocus();
                void UnityEngine.UIElements.ITextInputField.SyncTextEngine();
                bool UnityEngine.UIElements.ITextInputField.AcceptCharacter(char c);
                string UnityEngine.UIElements.ITextInputField.CullString(string s);
                void UnityEngine.UIElements.ITextInputField.UpdateText(string value);
                UnityEngine.UIElements.TextEditorEngine UnityEngine.UIElements.ITextInputField.get_editorEngine();
                bool UnityEngine.UIElements.ITextInputField.get_isDelayed();
                void UnityEngine.UIElements.ITextInputField.UpdateValueFromText();
                void DeferGUIStyleRectSync();
                void OnPercentResolved(UnityEngine.UIElements.GeometryChangedEvent evt);
                void <ProcessEventAtTarget>b__99_0();
            }
        }

        enum SliderDirection
        {
            Horizontal = 0,
            Vertical = 1,
        }

        class BaseSlider<TValueType> : UnityEngine.UIElements.BaseField<TValueType>
        {
            static /*0x0*/ string ussClassName;
            static /*0x0*/ string labelUssClassName;
            static /*0x0*/ string inputUssClassName;
            static /*0x0*/ string horizontalVariantUssClassName;
            static /*0x0*/ string verticalVariantUssClassName;
            static /*0x0*/ string dragContainerUssClassName;
            static /*0x0*/ string trackerUssClassName;
            static /*0x0*/ string draggerUssClassName;
            static /*0x0*/ string draggerBorderUssClassName;
            static /*0x0*/ string textFieldClassName;
            /*0x0*/ UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.TextField <inputTextField>k__BackingField;
            /*0x0*/ TValueType m_LowValue;
            /*0x0*/ TValueType m_HighValue;
            /*0x0*/ float m_PageSize;
            /*0x0*/ bool m_ShowInputField;
            /*0x0*/ bool <clamped>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.ClampedDragger<TValueType> <clampedDragger>k__BackingField;
            /*0x0*/ UnityEngine.Rect m_DragElementStartPos;
            /*0x0*/ UnityEngine.UIElements.SliderDirection m_Direction;
            /*0x0*/ bool m_Inverted;

            static BaseSlider();
            static float GetClosestPowerOfTen(float positiveNumber);
            static float RoundToMultipleOf(float value, float roundingValue);
            BaseSlider(string label, TValueType start, TValueType end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            UnityEngine.UIElements.VisualElement get_dragContainer();
            void set_dragContainer(UnityEngine.UIElements.VisualElement value);
            UnityEngine.UIElements.VisualElement get_dragElement();
            void set_dragElement(UnityEngine.UIElements.VisualElement value);
            UnityEngine.UIElements.VisualElement get_dragBorderElement();
            void set_dragBorderElement(UnityEngine.UIElements.VisualElement value);
            UnityEngine.UIElements.TextField get_inputTextField();
            void set_inputTextField(UnityEngine.UIElements.TextField value);
            TValueType get_lowValue();
            void set_lowValue(TValueType value);
            TValueType get_highValue();
            void set_highValue(TValueType value);
            void SetHighValueWithoutNotify(TValueType newHighValue);
            float get_pageSize();
            void set_pageSize(float value);
            bool get_showInputField();
            void set_showInputField(bool value);
            bool get_clamped();
            void set_clamped(bool value);
            UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger();
            void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value);
            TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound);
            TValueType GetClampedValue(TValueType newValue);
            TValueType get_value();
            void set_value(TValueType value);
            void SetValueWithoutNotify(TValueType newValue);
            UnityEngine.UIElements.SliderDirection get_direction();
            void set_direction(UnityEngine.UIElements.SliderDirection value);
            bool get_inverted();
            void set_inverted(bool value);
            void ClampValue();
            TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);
            float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);
            TValueType ParseStringToValue(string stringValue);
            void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> sliderKey, bool isShift);
            TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant);
            void SetSliderValueFromDrag();
            void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos);
            void SetSliderValueFromClick();
            void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos);
            void AdjustDragElement(float factor);
            void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt);
            void OnViewDataReady();
            bool SameValues(float a, float b, float epsilon);
            void UpdateDragElementPosition();
            void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            void UpdateTextFieldVisibility();
            void UpdateTextFieldValue();
            void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent evt);
            void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<string> evt);
            void UpdateMixedValueContent();

            enum SliderKey<TValueType>
            {
                None = 0,
                Lowest = 1,
                LowerPage = 2,
                Lower = 3,
                Higher = 4,
                HigherPage = 5,
                Highest = 6,
            }
        }

        class ButtonStripField : UnityEngine.UIElements.BaseField<int>
        {
            /*0x408*/ System.Collections.Generic.List<UnityEngine.UIElements.Button> m_Buttons;

            /*0x2a4d0a0*/ ButtonStripField();
            /*0x2a4cfac*/ System.Collections.Generic.List<UnityEngine.UIElements.Button> get_buttons();
            /*0x2a4d160*/ void SetValueWithoutNotify(int newValue);
            /*0x2a4d1e8*/ void RefreshButtonsState();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ButtonStripField, UnityEngine.UIElements.ButtonStripField.UxmlTraits>
            {
                /*0x2a4d2c8*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseField.UxmlTraits<int>
            {
                /*0x2a4d310*/ UxmlTraits();
            }
        }

        class MinMaxSlider : UnityEngine.UIElements.BaseField<UnityEngine.Vector2>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;
            static /*0x18*/ string trackerUssClassName;
            static /*0x20*/ string draggerUssClassName;
            static /*0x28*/ string minThumbUssClassName;
            static /*0x30*/ string maxThumbUssClassName;
            /*0x408*/ UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;
            /*0x410*/ UnityEngine.UIElements.VisualElement <dragMinThumb>k__BackingField;
            /*0x418*/ UnityEngine.UIElements.VisualElement <dragMaxThumb>k__BackingField;
            /*0x420*/ UnityEngine.UIElements.ClampedDragger<float> <clampedDragger>k__BackingField;
            /*0x428*/ UnityEngine.Vector2 m_DragElementStartPos;
            /*0x430*/ UnityEngine.Vector2 m_ValueStartPos;
            /*0x438*/ UnityEngine.Rect m_DragMinThumbRect;
            /*0x448*/ UnityEngine.Rect m_DragMaxThumbRect;
            /*0x458*/ UnityEngine.UIElements.MinMaxSlider.DragState m_DragState;
            /*0x45c*/ float m_MinLimit;
            /*0x460*/ float m_MaxLimit;

            static /*0x2a4fd7c*/ MinMaxSlider();
            /*0x2a4ee84*/ MinMaxSlider();
            /*0x2a4eea4*/ MinMaxSlider(string label, float minValue, float maxValue, float minLimit, float maxLimit);
            /*0x2a4d358*/ UnityEngine.UIElements.VisualElement get_dragElement();
            /*0x2a4d360*/ void set_dragElement(UnityEngine.UIElements.VisualElement value);
            /*0x2a4d368*/ UnityEngine.UIElements.VisualElement get_dragMinThumb();
            /*0x2a4d370*/ void set_dragMinThumb(UnityEngine.UIElements.VisualElement value);
            /*0x2a4d378*/ UnityEngine.UIElements.VisualElement get_dragMaxThumb();
            /*0x2a4d380*/ void set_dragMaxThumb(UnityEngine.UIElements.VisualElement value);
            /*0x2a4d388*/ UnityEngine.UIElements.ClampedDragger<float> get_clampedDragger();
            /*0x2a4d390*/ void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<float> value);
            /*0x2a4d398*/ float get_minValue();
            /*0x2a4d3a8*/ void set_minValue(float value);
            /*0x2a4d488*/ float get_maxValue();
            /*0x2a4d4a8*/ void set_maxValue(float value);
            /*0x2a4d550*/ UnityEngine.Vector2 get_value();
            /*0x2a4d598*/ void set_value(UnityEngine.Vector2 value);
            /*0x2a4d624*/ void SetValueWithoutNotify(UnityEngine.Vector2 newValue);
            /*0x2a4eb94*/ float get_lowLimit();
            /*0x2a4eb9c*/ void set_lowLimit(float value);
            /*0x2a4ed0c*/ float get_highLimit();
            /*0x2a4ed14*/ void set_highLimit(float value);
            /*0x2a4d450*/ UnityEngine.Vector2 ClampValues(UnityEngine.Vector2 valueToClamp);
            /*0x2a4f3cc*/ void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a4d6b8*/ void UpdateDragElementPosition();
            /*0x2a4f470*/ float SliderLerpUnclamped(float a, float b, float interpolant);
            /*0x2a4f460*/ float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue);
            /*0x2a4f480*/ float ComputeValueFromPosition(float positionToConvert);
            /*0x2a4f640*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x2a4f74c*/ void SetSliderValueFromDrag();
            /*0x2a4f984*/ void SetSliderValueFromClick();
            /*0x2a4fcd8*/ void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos);
            /*0x2a4f7e0*/ void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos);
            /*0x2a4fd78*/ void UpdateMixedValueContent();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.MinMaxSlider, UnityEngine.UIElements.MinMaxSlider.UxmlTraits>
            {
                /*0x2a4ff1c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseField.UxmlTraits<UnityEngine.Vector2>
            {
                /*0x80*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_MinValue;
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_MaxValue;
                /*0x90*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowLimit;
                /*0x98*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighLimit;

                /*0x2a50120*/ UxmlTraits();
                /*0x2a4ff64*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            enum DragState
            {
                NoThumb = 0,
                MinThumb = 1,
                MiddleThumb = 2,
                MaxThumb = 3,
            }
        }

        enum HelpBoxMessageType
        {
            None = 0,
            Info = 1,
            Warning = 2,
            Error = 3,
        }

        class HelpBox : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string iconUssClassName;
            static /*0x18*/ string iconInfoUssClassName;
            static /*0x20*/ string iconwarningUssClassName;
            static /*0x28*/ string iconErrorUssClassName;
            /*0x3b0*/ UnityEngine.UIElements.HelpBoxMessageType m_HelpBoxMessageType;
            /*0x3b8*/ UnityEngine.UIElements.VisualElement m_Icon;
            /*0x3c0*/ string m_IconClass;
            /*0x3c8*/ UnityEngine.UIElements.Label m_Label;

            static /*0x2a505dc*/ HelpBox();
            /*0x2a50380*/ HelpBox();
            /*0x2a503d4*/ HelpBox(string text, UnityEngine.UIElements.HelpBoxMessageType messageType);
            /*0x2a50290*/ void set_text(string value);
            /*0x2a502b4*/ void set_messageType(UnityEngine.UIElements.HelpBoxMessageType value);
            /*0x2a50524*/ string GetIconClass(UnityEngine.UIElements.HelpBoxMessageType messageType);
            /*0x2a502cc*/ void UpdateIcon(UnityEngine.UIElements.HelpBoxMessageType messageType);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.HelpBox, UnityEngine.UIElements.HelpBox.UxmlTraits>
            {
                /*0x2a50748*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
                /*0x78*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType> m_MessageType;

                /*0x2a508e4*/ UxmlTraits();
                /*0x2a50790*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class GroupBox : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.IGroupBox
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            /*0x3c0*/ UnityEngine.UIElements.Label m_TitleLabel;

            static /*0x2a50b88*/ GroupBox();
            /*0x2a50af8*/ GroupBox();
            /*0x2a50b00*/ GroupBox(string text);
            /*0x2a509e0*/ void set_text(string value);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.GroupBox, UnityEngine.UIElements.GroupBox.UxmlTraits>
            {
                /*0x2a50c28*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;

                /*0x2a50d68*/ UxmlTraits();
                /*0x2a50c70*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class AbstractProgressBar : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.INotifyValueChanged<float>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string containerUssClassName;
            static /*0x10*/ string titleUssClassName;
            static /*0x18*/ string titleContainerUssClassName;
            static /*0x20*/ string progressUssClassName;
            static /*0x28*/ string backgroundUssClassName;
            /*0x3c0*/ UnityEngine.UIElements.VisualElement m_Background;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_Progress;
            /*0x3d0*/ UnityEngine.UIElements.Label m_Title;
            /*0x3d8*/ float m_LowValue;
            /*0x3dc*/ float m_HighValue;
            /*0x3e0*/ float m_Value;

            static /*0x2a515b8*/ AbstractProgressBar();
            /*0x2a50f64*/ AbstractProgressBar();
            /*0x2a50dec*/ void set_title(string value);
            /*0x2a50e10*/ float get_lowValue();
            /*0x2a50e18*/ void set_lowValue(float value);
            /*0x2a50f4c*/ float get_highValue();
            /*0x2a50f54*/ void set_highValue(float value);
            /*0x2a51204*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e);
            /*0x2a51228*/ float get_value();
            /*0x2a51230*/ void set_value(float value);
            /*0x2a5148c*/ void SetValueWithoutNotify(float newValue);
            /*0x2a50e28*/ void SetProgress(float p);
            /*0x2a514b4*/ float CalculateProgressWidth(float width);

            class UxmlTraits : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x78*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;
                /*0x80*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;
                /*0x88*/ UnityEngine.UIElements.UxmlFloatAttributeDescription m_Value;
                /*0x90*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Title;

                /*0x2a51900*/ UxmlTraits();
                /*0x2a51728*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class ProgressBar : UnityEngine.UIElements.AbstractProgressBar
        {
            /*0x2a51a94*/ ProgressBar();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.ProgressBar, UnityEngine.UIElements.AbstractProgressBar.UxmlTraits>
            {
                /*0x2a51ae8*/ UxmlFactory();
            }
        }

        class SliderInt : UnityEngine.UIElements.BaseSlider<int>
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string labelUssClassName;
            static /*0x10*/ string inputUssClassName;

            static /*0x2a52558*/ SliderInt();
            /*0x2a51b30*/ SliderInt();
            /*0x2a51b48*/ SliderInt(string label, int start, int end, UnityEngine.UIElements.SliderDirection direction, float pageSize);
            /*0x2a51c94*/ float get_pageSize();
            /*0x2a51cdc*/ void set_pageSize(float value);
            /*0x2a51df4*/ int SliderLerpUnclamped(int a, int b, float interpolant);
            /*0x2a51ee0*/ float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue);
            /*0x2a51efc*/ int ParseStringToValue(string stringValue);
            /*0x2a51f28*/ void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos);
            /*0x2a52288*/ void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<int> sliderKey, bool isShift);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.SliderInt, UnityEngine.UIElements.SliderInt.UxmlTraits>
            {
                /*0x2a52628*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<int, UnityEngine.UIElements.UxmlIntAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_LowValue;
                /*0x90*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_HighValue;
                /*0x98*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_PageSize;
                /*0xa0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowInputField;
                /*0xa8*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;
                /*0xb0*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_Inverted;

                /*0x2a52930*/ UxmlTraits();
                /*0x2a52670*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class Button : UnityEngine.UIElements.TextElement
        {
            static /*0x0*/ string ussClassName;
            static /*0x8*/ string NonEmptyString;
            /*0x478*/ UnityEngine.UIElements.Clickable m_Clickable;

            static /*0x2a52de0*/ Button();
            /*0x2a52bcc*/ Button();
            /*0x2a45e8c*/ Button(System.Action clickEvent);
            /*0x2a52b60*/ UnityEngine.UIElements.Clickable get_clickable();
            /*0x2a52b68*/ void set_clickable(UnityEngine.UIElements.Clickable value);
            /*0x2a52bd4*/ void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt);
            /*0x2a52c0c*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x2a52d24*/ UnityEngine.Vector2 DoMeasure(float desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.Button, UnityEngine.UIElements.Button.UxmlTraits>
            {
                /*0x2a52e6c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits
            {
                /*0x2a52eb4*/ UxmlTraits();
            }
        }

        class TwoPaneSplitViewResizer : UnityEngine.UIElements.PointerManipulator
        {
            /*0x30*/ UnityEngine.Vector3 m_Start;
            /*0x3c*/ bool m_Active;
            /*0x40*/ UnityEngine.UIElements.TwoPaneSplitView m_SplitView;
            /*0x48*/ int m_Direction;
            /*0x4c*/ UnityEngine.UIElements.TwoPaneSplitViewOrientation m_Orientation;

            /*0x2a5316c*/ TwoPaneSplitViewResizer(UnityEngine.UIElements.TwoPaneSplitView splitView, int dir, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation);
            /*0x2a52f0c*/ UnityEngine.UIElements.VisualElement get_fixedPane();
            /*0x2a52f28*/ UnityEngine.UIElements.VisualElement get_flexedPane();
            /*0x2a52f44*/ float get_fixedPaneMinDimension();
            /*0x2a53058*/ float get_flexedPaneMinDimension();
            /*0x2a53244*/ void RegisterCallbacksOnTarget();
            /*0x2a53410*/ void UnregisterCallbacksFromTarget();
            /*0x2a535dc*/ void ApplyDelta(float delta);
            /*0x2a53bdc*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e);
            /*0x2a53ca4*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e);
            /*0x2a53d5c*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e);
        }

        interface INotifyValueChanged<T>
        {
            T get_value();
            void set_value(T value);
            void SetValueWithoutNotify(T newValue);
        }

        class INotifyValueChangedExtensions
        {
            static bool RegisterValueChangedCallback<T>(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback);
            static bool UnregisterValueChangedCallback<T>(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback);
        }

        class BaseField<TValueType> : UnityEngine.UIElements.BindableElement, UnityEngine.UIElements.INotifyValueChanged<TValueType>
        {
            static /*0x0*/ string ussClassName;
            static /*0x0*/ string labelUssClassName;
            static /*0x0*/ string inputUssClassName;
            static /*0x0*/ string noLabelVariantUssClassName;
            static /*0x0*/ string labelDraggerVariantUssClassName;
            static /*0x0*/ string mixedValueLabelUssClassName;
            static /*0x0*/ string alignedFieldUssClassName;
            static /*0x0*/ string inspectorFieldUssClassName;
            static /*0x0*/ string mixedValueString;
            static /*0x0*/ UnityEngine.PropertyName serializedPropertyCopyName;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<float> s_LabelWidthRatioProperty;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<float> s_LabelExtraPaddingProperty;
            static /*0x0*/ UnityEngine.UIElements.CustomStyleProperty<float> s_LabelBaseMinWidthProperty;
            /*0x0*/ float m_LabelWidthRatio;
            /*0x0*/ float m_LabelExtraPadding;
            /*0x0*/ float m_LabelBaseMinWidth;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_VisualInput;
            /*0x0*/ TValueType m_Value;
            /*0x0*/ UnityEngine.UIElements.Label <labelElement>k__BackingField;
            /*0x0*/ bool m_ShowMixedValue;
            /*0x0*/ UnityEngine.UIElements.Label m_MixedValueLabel;
            /*0x0*/ UnityEngine.UIElements.VisualElement m_CachedInspectorElement;
            /*0x0*/ int m_CachedListAndFoldoutDepth;

            static BaseField();
            BaseField(string label);
            BaseField(string label, UnityEngine.UIElements.VisualElement visualInput);
            UnityEngine.UIElements.VisualElement get_visualInput();
            void set_visualInput(UnityEngine.UIElements.VisualElement value);
            TValueType get_rawValue();
            void set_rawValue(TValueType value);
            TValueType get_value();
            void set_value(TValueType value);
            UnityEngine.UIElements.Label get_labelElement();
            void set_labelElement(UnityEngine.UIElements.Label value);
            string get_label();
            void set_label(string value);
            bool get_showMixedValue();
            UnityEngine.UIElements.Label get_mixedValueLabel();
            void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e);
            void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt);
            void OnInspectorFieldGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e);
            void AlignLabel();
            void UpdateMixedValueContent();
            void SetValueWithoutNotify(TValueType newValue);
            void OnViewDataReady();
            UnityEngine.Rect GetTooltipRect();

            class UxmlTraits<TValueType> : UnityEngine.UIElements.BindableElement.UxmlTraits
            {
                /*0x0*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Label;

                static System.Collections.Generic.List<string> ParseChoiceList(string choicesFromBag);
                UxmlTraits();
                void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : UnityEngine.UIElements.BaseField.UxmlTraits<TValueType>
        {
            /*0x0*/ TValueUxmlAttributeType m_Value;

            BaseFieldTraits();
            void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
        }

        class TouchScreenTextEditorEventHandler : UnityEngine.UIElements.TextEditorEventHandler
        {
            static /*0x0*/ UnityEngine.TouchScreenKeyboard s_KeyboardOnScreen;
            /*0x20*/ UnityEngine.UIElements.IVisualElementScheduledItem m_TouchKeyboardPoller;
            /*0x28*/ UnityEngine.UIElements.VisualElement m_LastPointerDownTarget;

            /*0x2a53e08*/ TouchScreenTextEditorEventHandler(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField);
            /*0x2a53e10*/ void PollTouchScreenKeyboard();
            /*0x2a5406c*/ void DoPollTouchScreenKeyboard();
            /*0x2a54794*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
        }

        class RadioButtonGroup : UnityEngine.UIElements.BaseField<int>, UnityEngine.UIElements.IGroupBox
        {
            static /*0x0*/ string ussClassName;
            /*0x408*/ System.Collections.Generic.IEnumerable<string> m_Choices;
            /*0x410*/ System.Collections.Generic.List<UnityEngine.UIElements.RadioButton> m_RadioButtons;
            /*0x418*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

            static /*0x2a55784*/ RadioButtonGroup();
            /*0x2a55468*/ RadioButtonGroup();
            /*0x2a55474*/ RadioButtonGroup(string label, System.Collections.Generic.List<string> radioButtonChoices);
            /*0x2a54ce4*/ void set_choices(System.Collections.Generic.IEnumerable<string> value);
            /*0x2a5562c*/ void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<bool> evt);
            /*0x2a55724*/ void SetValueWithoutNotify(int newValue);
            /*0x2a5527c*/ void UpdateRadioButtons();

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.RadioButtonGroup, UnityEngine.UIElements.RadioButtonGroup.UxmlTraits>
            {
                /*0x2a557e4*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.BaseFieldTraits<int, UnityEngine.UIElements.UxmlIntAttributeDescription>
            {
                /*0x88*/ UnityEngine.UIElements.UxmlStringAttributeDescription m_Choices;

                /*0x2a55964*/ UxmlTraits();
                /*0x2a5582c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        class TwoPaneSplitView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string s_UssClassName;
            static /*0x8*/ string s_ContentContainerClassName;
            static /*0x10*/ string s_HandleDragLineClassName;
            static /*0x18*/ string s_HandleDragLineVerticalClassName;
            static /*0x20*/ string s_HandleDragLineHorizontalClassName;
            static /*0x28*/ string s_HandleDragLineAnchorClassName;
            static /*0x30*/ string s_HandleDragLineAnchorVerticalClassName;
            static /*0x38*/ string s_HandleDragLineAnchorHorizontalClassName;
            static /*0x40*/ string s_VerticalClassName;
            static /*0x48*/ string s_HorizontalClassName;
            /*0x3b0*/ UnityEngine.UIElements.VisualElement m_LeftPane;
            /*0x3b8*/ UnityEngine.UIElements.VisualElement m_RightPane;
            /*0x3c0*/ UnityEngine.UIElements.VisualElement m_FixedPane;
            /*0x3c8*/ UnityEngine.UIElements.VisualElement m_FlexedPane;
            /*0x3d0*/ float m_FixedPaneDimension;
            /*0x3d8*/ UnityEngine.UIElements.VisualElement m_DragLine;
            /*0x3e0*/ UnityEngine.UIElements.VisualElement m_DragLineAnchor;
            /*0x3e8*/ bool m_CollapseMode;
            /*0x3f0*/ UnityEngine.UIElements.VisualElement m_Content;
            /*0x3f8*/ UnityEngine.UIElements.TwoPaneSplitViewOrientation m_Orientation;
            /*0x3fc*/ int m_FixedPaneIndex;
            /*0x400*/ float m_FixedPaneInitialDimension;
            /*0x408*/ UnityEngine.UIElements.TwoPaneSplitViewResizer m_Resizer;

            static /*0x2a57838*/ TwoPaneSplitView();
            /*0x2a55a6c*/ TwoPaneSplitView();
            /*0x2a55a04*/ UnityEngine.UIElements.VisualElement get_fixedPane();
            /*0x2a55a0c*/ UnityEngine.UIElements.VisualElement get_flexedPane();
            /*0x2a55a14*/ int get_fixedPaneIndex();
            /*0x2a55a1c*/ float get_fixedPaneDimension();
            /*0x2a55a50*/ void set_fixedPaneDimension(float value);
            /*0x2a55c7c*/ void Init(int fixedPaneIndex, float fixedPaneInitialDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation);
            /*0x2a56ec8*/ void OnPostDisplaySetup(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a55f58*/ void PostDisplaySetup();
            /*0x2a56fd0*/ void OnSizeChange(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a56fd4*/ void OnSizeChange();
            /*0x2a577f4*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x2a577fc*/ void OnViewDataReady();
            /*0x2a575a4*/ void SetDragLineOffset(float offset);
            /*0x2a576cc*/ void SetFixedPaneDimension(float dimension);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.TwoPaneSplitView, UnityEngine.UIElements.TwoPaneSplitView.UxmlTraits>
            {
                /*0x2a579d4*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedPaneIndex;
                /*0x78*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedPaneInitialDimension;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation> m_Orientation;

                /*0x2a57b88*/ UxmlTraits();
                /*0x2a57a1c*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }
        }

        enum TwoPaneSplitViewOrientation
        {
            Horizontal = 0,
            Vertical = 1,
        }

        enum AlternatingRowBackground
        {
            None = 0,
            ContentOnly = 1,
            All = 2,
        }

        enum CollectionVirtualizationMethod
        {
            FixedHeight = 0,
            DynamicHeight = 1,
        }

        class BaseVerticalCollectionView : UnityEngine.UIElements.BindableElement, UnityEngine.ISerializationCallbackReceiver
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.ReusableCollectionItem> k_EmptyItems;
            static /*0x8*/ int s_DefaultItemHeight;
            static /*0x10*/ UnityEngine.UIElements.CustomStyleProperty<int> s_ItemHeightProperty;
            static /*0x18*/ string ussClassName;
            static /*0x20*/ string borderUssClassName;
            static /*0x28*/ string itemUssClassName;
            static /*0x30*/ string dragHoverBarUssClassName;
            static /*0x38*/ string itemDragHoverUssClassName;
            static /*0x40*/ string itemSelectedVariantUssClassName;
            static /*0x48*/ string itemAlternativeBackgroundUssClassName;
            static /*0x50*/ string listScrollViewUssClassName;
            static /*0x58*/ string backgroundFillUssClassName;
            /*0x3c0*/ System.Action<System.Collections.Generic.IEnumerable<object>> onItemsChosen;
            /*0x3c8*/ System.Action<System.Collections.Generic.IEnumerable<object>> onSelectionChange;
            /*0x3d0*/ System.Action<System.Collections.Generic.IEnumerable<int>> onSelectedIndicesChange;
            /*0x3d8*/ System.Action<int, int> itemIndexChanged;
            /*0x3e0*/ System.Action itemsSourceChanged;
            /*0x3e8*/ System.Func<int, int> m_GetItemId;
            /*0x3f0*/ System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;
            /*0x3f8*/ System.Action<UnityEngine.UIElements.VisualElement, int> m_BindItem;
            /*0x400*/ System.Action<UnityEngine.UIElements.VisualElement, int> <unbindItem>k__BackingField;
            /*0x408*/ System.Action<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField;
            /*0x410*/ UnityEngine.UIElements.SelectionType m_SelectionType;
            /*0x414*/ bool m_HorizontalScrollingEnabled;
            /*0x418*/ UnityEngine.UIElements.AlternatingRowBackground m_ShowAlternatingRowBackgrounds;
            /*0x41c*/ float m_FixedItemHeight;
            /*0x420*/ bool m_ItemHeightIsInline;
            /*0x424*/ UnityEngine.UIElements.CollectionVirtualizationMethod m_VirtualizationMethod;
            /*0x428*/ UnityEngine.UIElements.ScrollView m_ScrollView;
            /*0x430*/ UnityEngine.UIElements.CollectionViewController m_ViewController;
            /*0x438*/ UnityEngine.UIElements.CollectionVirtualizationController m_VirtualizationController;
            /*0x440*/ UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator;
            /*0x448*/ UnityEngine.Vector2 m_ScrollOffset;
            /*0x450*/ System.Collections.Generic.List<int> m_SelectedIds;
            /*0x458*/ System.Collections.Generic.List<int> m_SelectedIndices;
            /*0x460*/ System.Collections.Generic.List<object> m_SelectedItems;
            /*0x468*/ float m_LastHeight;
            /*0x46c*/ bool m_IsRangeSelectionDirectionUp;
            /*0x470*/ UnityEngine.UIElements.ListViewDragger m_Dragger;
            /*0x478*/ System.Action<int, int> m_ItemIndexChangedCallback;
            /*0x480*/ System.Action m_ItemsSourceChangedCallback;
            /*0x488*/ UnityEngine.Vector3 m_TouchDownPosition;

            static /*0x2a5d82c*/ BaseVerticalCollectionView();
            /*0x2a58be8*/ BaseVerticalCollectionView();
            /*0x2a57cd4*/ void add_onItemsChosen(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x2a57d88*/ void remove_onItemsChosen(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x2a57e3c*/ void add_onSelectionChange(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x2a57ef0*/ void remove_onSelectionChange(System.Action<System.Collections.Generic.IEnumerable<object>> value);
            /*0x2a57fa4*/ System.Func<int, int> get_getItemId();
            /*0x2a57fac*/ void set_getItemId(System.Func<int, int> value);
            /*0x2a58020*/ System.Collections.IList get_itemsSource();
            /*0x2a58038*/ void set_itemsSource(System.Collections.IList value);
            /*0x2a580b4*/ bool get_sourceIncludesArraySize();
            /*0x2a580bc*/ System.Func<UnityEngine.UIElements.VisualElement> get_makeItem();
            /*0x2a580c4*/ void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value);
            /*0x2a58138*/ System.Action<UnityEngine.UIElements.VisualElement, int> get_bindItem();
            /*0x2a58140*/ void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement, int> value);
            /*0x2a58148*/ System.Action<UnityEngine.UIElements.VisualElement, int> get_unbindItem();
            /*0x2a58150*/ void set_unbindItem(System.Action<UnityEngine.UIElements.VisualElement, int> value);
            /*0x2a58158*/ System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem();
            /*0x2a58160*/ void set_destroyItem(System.Action<UnityEngine.UIElements.VisualElement> value);
            /*0x2a58168*/ UnityEngine.UIElements.VisualElement get_contentContainer();
            /*0x2a58170*/ UnityEngine.UIElements.SelectionType get_selectionType();
            /*0x2a58178*/ void set_selectionType(UnityEngine.UIElements.SelectionType value);
            /*0x2a58338*/ int get_selectedIndex();
            /*0x2a583ac*/ void set_selectedIndex(int value);
            /*0x2a583b0*/ System.Collections.Generic.IEnumerable<int> get_selectedIndices();
            /*0x2a583b8*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems();
            /*0x2a58430*/ UnityEngine.UIElements.ScrollView get_scrollView();
            /*0x2a58438*/ UnityEngine.UIElements.ListViewDragger get_dragger();
            /*0x2a58440*/ UnityEngine.UIElements.CollectionViewController get_viewController();
            /*0x2a58448*/ UnityEngine.UIElements.CollectionVirtualizationController get_virtualizationController();
            /*0x2a584a8*/ float ResolveItemHeight(float height);
            /*0x2a58560*/ void set_showBorder(bool value);
            /*0x2a585e0*/ bool get_reorderable();
            /*0x2a586d0*/ void set_reorderable(bool value);
            /*0x2a58890*/ void set_horizontalScrollingEnabled(bool value);
            /*0x2a588d8*/ UnityEngine.UIElements.AlternatingRowBackground get_showAlternatingRowBackgrounds();
            /*0x2a588e0*/ void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value);
            /*0x2a588f8*/ UnityEngine.UIElements.CollectionVirtualizationMethod get_virtualizationMethod();
            /*0x2a58900*/ void set_virtualizationMethod(UnityEngine.UIElements.CollectionVirtualizationMethod value);
            /*0x2a5893c*/ float get_fixedItemHeight();
            /*0x2a58944*/ void set_fixedItemHeight(float value);
            /*0x2a58a40*/ float get_lastHeight();
            /*0x2a58a48*/ void CreateVirtualizationController();
            /*0x2a58478*/ UnityEngine.UIElements.CollectionVirtualizationController GetOrCreateVirtualizationController();
            void CreateVirtualizationController<T>();
            /*0x2a58084*/ UnityEngine.UIElements.CollectionViewController GetOrCreateViewController();
            /*0x2a58a90*/ void CreateViewController();
            /*0x2a58af4*/ void SetViewController(UnityEngine.UIElements.CollectionViewController controller);
            /*0x2a58b84*/ UnityEngine.UIElements.ListViewDragger CreateDragger();
            /*0x2a58818*/ void InitializeDragAndDropController();
            UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController();
            /*0x2a59188*/ bool HasValidDataAndBindings();
            /*0x2a591c0*/ void OnItemIndexChanged(int srcIndex, int dstIndex);
            /*0x2a593a4*/ void OnItemsSourceChanged();
            /*0x2a57fb4*/ void RefreshItems();
            /*0x2a580cc*/ void Rebuild();
            /*0x2a5941c*/ void RefreshSelection();
            /*0x2a596b4*/ void PostRefresh();
            /*0x2a59880*/ void ScrollToItem(int index);
            /*0x2a5990c*/ void OnScroll(UnityEngine.Vector2 offset);
            /*0x2a597e0*/ void Resize(UnityEngine.Vector2 size, int layoutPass);
            /*0x2a599a0*/ void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt);
            /*0x2a59cfc*/ void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt);
            /*0x2a59fc4*/ bool Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, bool shiftKey);
            /*0x2a5aa90*/ void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent);
            /*0x2a5ab9c*/ void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt);
            /*0x2a5b610*/ void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt);
            /*0x2a5b6cc*/ void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt);
            /*0x2a5b758*/ void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt);
            /*0x2a5b218*/ void ProcessPointerDown(UnityEngine.UIElements.IPointerEvent evt);
            /*0x2a5ac24*/ void ProcessPointerUp(UnityEngine.UIElements.IPointerEvent evt);
            /*0x2a5b814*/ void DoSelect(UnityEngine.Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey);
            /*0x2a5bb8c*/ void DoRangeSelection(int rangeSelectionFinalIndex);
            /*0x2a5bab0*/ void ProcessSingleClick(int clickedIndex);
            /*0x2a5a378*/ void SelectAll();
            /*0x2a5bb14*/ void AddToSelection(int index);
            /*0x2a5c088*/ void AddToSelection(System.Collections.Generic.IList<int> indexes);
            /*0x2a5c494*/ void AddToSelectionWithoutValidation(int index);
            /*0x2a5bab4*/ void RemoveFromSelection(int index);
            /*0x2a5c974*/ void RemoveFromSelectionWithoutValidation(int index);
            /*0x2a582b0*/ void SetSelection(int index);
            /*0x2a5cd80*/ void SetSelection(System.Collections.Generic.IEnumerable<int> indices);
            /*0x2a5d0c4*/ void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<int> indices);
            /*0x2a5cd88*/ void SetSelectionInternal(System.Collections.Generic.IEnumerable<int> indices, bool sendNotification);
            /*0x2a5c418*/ void NotifyOfSelectionChange();
            /*0x2a5821c*/ void ClearSelection();
            /*0x2a5bd28*/ void ClearSelectionWithoutValidation();
            /*0x2a5d0cc*/ void OnViewDataReady();
            /*0x2a5d100*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x2a5d480*/ void OnSizeChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            /*0x2a5d638*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);
            /*0x2a5d824*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x2a5d828*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x2a5dad8*/ void <.ctor>b__143_0(float v);
            /*0x2a5a95c*/ void <Apply>g__HandleSelectionAndScroll|164_0(int index, ref UnityEngine.UIElements.BaseVerticalCollectionView.<> );

            struct <>c__DisplayClass164_0
            {
                /*0x10*/ UnityEngine.UIElements.BaseVerticalCollectionView <>4__this;
                /*0x18*/ bool shiftKey;
            }
        }

        interface ITextHandle
        {
            UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, float scaling);
            float ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            float ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            float GetLineHeight(int characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
            UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
            bool IsLegacy();
            bool IsElided();
            void set_MeasuredSizes(UnityEngine.Vector2 value);
            void set_RoundedSizes(UnityEngine.Vector2 value);
        }

        struct TextCoreHandle : UnityEngine.UIElements.ITextHandle
        {
            static /*0x0*/ UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings;
            static /*0x8*/ UnityEngine.TextCore.Text.TextInfo s_TextInfoLayout;
            /*0x10*/ UnityEngine.Vector2 <MeasuredSizes>k__BackingField;
            /*0x18*/ UnityEngine.Vector2 <RoundedSizes>k__BackingField;
            /*0x20*/ UnityEngine.Vector2 m_PreferredSize;
            /*0x28*/ int m_PreviousGenerationSettingsHash;
            /*0x30*/ UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings;
            /*0x38*/ UnityEngine.TextCore.Text.TextInfo m_TextInfoMesh;
            /*0x40*/ bool isDirty;

            static /*0x2a5e670*/ TextCoreHandle();
            static /*0x2a5db04*/ UnityEngine.UIElements.ITextHandle New();
            static /*0x2a5dc30*/ UnityEngine.TextCore.Text.TextInfo get_textInfoLayout();
            static /*0x2a5e3f0*/ UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams);
            static /*0x2a5e16c*/ void UpdateGenerationSettingsCommon(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings);
            /*0x2a5dae4*/ UnityEngine.Vector2 get_MeasuredSizes();
            /*0x2a5daec*/ void set_MeasuredSizes(UnityEngine.Vector2 value);
            /*0x2a5daf4*/ UnityEngine.Vector2 get_RoundedSizes();
            /*0x2a5dafc*/ void set_RoundedSizes(UnityEngine.Vector2 value);
            /*0x2a5dbc4*/ UnityEngine.TextCore.Text.TextInfo get_textInfoMesh();
            /*0x2a5dcf0*/ bool IsLegacy();
            /*0x2a5dcf8*/ bool IsDirty(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms);
            /*0x2a5dd3c*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, float scaling);
            /*0x2a5dd64*/ float ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x2a5dec8*/ float ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x2a5defc*/ float GetLineHeight(int characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
            /*0x2a5df64*/ UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
            /*0x2a5dd98*/ void UpdatePreferredValues(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms);
            /*0x2a5e60c*/ bool IsElided();
        }

        struct TextNativeHandle : UnityEngine.UIElements.ITextHandle
        {
            /*0x10*/ UnityEngine.Vector2 <MeasuredSizes>k__BackingField;
            /*0x18*/ UnityEngine.Vector2 <RoundedSizes>k__BackingField;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> textVertices;
            /*0x30*/ int m_PreviousTextParamsHash;

            static /*0x2a5e708*/ UnityEngine.UIElements.ITextHandle New();
            /*0x2a5e6e8*/ UnityEngine.Vector2 get_MeasuredSizes();
            /*0x2a5e6f0*/ void set_MeasuredSizes(UnityEngine.Vector2 value);
            /*0x2a5e6f8*/ UnityEngine.Vector2 get_RoundedSizes();
            /*0x2a5e700*/ void set_RoundedSizes(UnityEngine.Vector2 value);
            /*0x2a5e764*/ bool IsLegacy();
            /*0x2a5e76c*/ float GetLineHeight(int characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
            /*0x2a5e840*/ UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
            /*0x2a5e8b0*/ Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x2a5eac0*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, float scaling);
            /*0x2a5eb18*/ float ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x2a5e7dc*/ float ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, float scaling);
            /*0x2a5eb98*/ bool IsElided();
        }

        class TextUtilities
        {
            static /*0x2a5eba0*/ float ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, float pixelsPerPoint);
            static /*0x2a5ec9c*/ UnityEngine.Vector2 MeasureVisualElementTextSize(UnityEngine.UIElements.VisualElement ve, string textToMeasure, float width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, float height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode, UnityEngine.UIElements.ITextHandle textHandle);
            static /*0x2a5e4e4*/ UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam);
            static /*0x2a5f1c8*/ UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a5f3f8*/ UnityEngine.Font GetFont(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam);
            static /*0x2a5f4e8*/ UnityEngine.Font GetFont(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a5f0f8*/ bool IsFontAssigned(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a5f644*/ bool IsFontAssigned(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams);
            static /*0x2a5f334*/ UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a5e42c*/ UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam);
            static /*0x2a5f7fc*/ UnityEngine.UIElements.UIR.TextCoreSettings GetTextCoreSettingsForElement(UnityEngine.UIElements.VisualElement ve);
        }

        class PanelTextSettings : UnityEngine.TextCore.Text.TextSettings
        {
            static /*0x0*/ UnityEngine.UIElements.PanelTextSettings s_DefaultPanelTextSettings;
            static /*0x8*/ System.Func<string, UnityEngine.Object> EditorGUIUtilityLoad;
            static /*0x10*/ System.Func<UnityEngine.SystemLanguage> GetCurrentLanguage;
            static /*0x18*/ string s_DefaultEditorPanelTextSettingPath;

            static /*0x2a60078*/ PanelTextSettings();
            static /*0x2a5f6c8*/ UnityEngine.UIElements.PanelTextSettings get_defaultPanelTextSettings();
            static /*0x2a5fbb0*/ void UpdateLocalizationFontAsset();
            /*0x2a60070*/ PanelTextSettings();
            /*0x2a5f1c0*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font);
        }

        interface IPointerCaptureEventInternal
        {
            int get_pointerId();
        }

        class PointerCaptureEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IPointerCaptureEventInternal
        {
            /*0x0*/ UnityEngine.UIElements.IEventHandler <relatedTarget>k__BackingField;
            /*0x0*/ int <pointerId>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.IEventHandler relatedTarget, int pointerId);
            PointerCaptureEventBase();
            void set_relatedTarget(UnityEngine.UIElements.IEventHandler value);
            int get_pointerId();
            void set_pointerId(int value);
            void Init();
            void LocalInit();
        }

        class PointerCaptureOutEvent : UnityEngine.UIElements.PointerCaptureEventBase<UnityEngine.UIElements.PointerCaptureOutEvent>
        {
            /*0x2a600d8*/ PointerCaptureOutEvent();
        }

        class PointerCaptureEvent : UnityEngine.UIElements.PointerCaptureEventBase<UnityEngine.UIElements.PointerCaptureEvent>
        {
            /*0x2a60120*/ PointerCaptureEvent();
        }

        class MouseCaptureEventBase<T> : UnityEngine.UIElements.PointerCaptureEventBase<T>
        {
            MouseCaptureEventBase();
            void Init();
        }

        class MouseCaptureOutEvent : UnityEngine.UIElements.MouseCaptureEventBase<UnityEngine.UIElements.MouseCaptureOutEvent>
        {
            /*0x2a60168*/ MouseCaptureOutEvent();
        }

        class MouseCaptureEvent : UnityEngine.UIElements.MouseCaptureEventBase<UnityEngine.UIElements.MouseCaptureEvent>
        {
            /*0x2a601b0*/ MouseCaptureEvent();
        }

        class ElementUnderPointer
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement[] m_PendingTopElementUnderPointer;
            /*0x18*/ UnityEngine.UIElements.VisualElement[] m_TopElementUnderPointer;
            /*0x20*/ UnityEngine.UIElements.IPointerEvent[] m_TriggerPointerEvent;
            /*0x28*/ UnityEngine.UIElements.IMouseEvent[] m_TriggerMouseEvent;
            /*0x30*/ UnityEngine.Vector2[] m_PickingPointerPositions;
            /*0x38*/ bool[] m_IsPickingPointerTemporaries;

            /*0x2a61bd8*/ ElementUnderPointer();
            /*0x2a601f8*/ UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(int pointerId, ref UnityEngine.Vector2 pickPosition, ref bool isTemporary);
            /*0x2a6026c*/ UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(int pointerId);
            /*0x2a6029c*/ void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.Vector2 pointerPos);
            /*0x2a603fc*/ UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase triggerEvent);
            /*0x2a605b4*/ void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x2a60808*/ void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.UIElements.EventBase triggerEvent);
            /*0x2a605bc*/ void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, int pointerId, UnityEngine.UIElements.EventBase triggerEvent, bool temporary);
            /*0x2a60810*/ void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher dispatcher, UnityEngine.UIElements.ContextType contextType);
        }

        class IMGUIEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.IMGUIEvent>
        {
            static /*0x2a61d34*/ UnityEngine.UIElements.IMGUIEvent GetPooled(UnityEngine.Event systemEvent);
            /*0x2a61ecc*/ IMGUIEvent();
            /*0x2a61e6c*/ void Init();
            /*0x2a61ec0*/ void LocalInit();
        }

        class PointerDeviceState
        {
            static /*0x0*/ UnityEngine.UIElements.PointerDeviceState.PointerLocation[] s_PlayerPointerLocations;
            static /*0x8*/ int[] s_PressedButtons;
            static /*0x10*/ UnityEngine.UIElements.IPanel[] s_PlayerPanelWithSoftPointerCapture;

            static /*0x2a62864*/ PointerDeviceState();
            static /*0x2a61f44*/ void RemovePanelData(UnityEngine.UIElements.IPanel panel);
            static /*0x2a6222c*/ void SavePointerPosition(int pointerId, UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.ContextType contextType);
            static /*0x2a622d4*/ void PressButton(int pointerId, int buttonId);
            static /*0x2a623b0*/ void ReleaseButton(int pointerId, int buttonId);
            static /*0x2a6248c*/ void ReleaseAllButtons(int pointerId);
            static /*0x2a61464*/ UnityEngine.Vector2 GetPointerPosition(int pointerId, UnityEngine.UIElements.ContextType contextType);
            static /*0x2a62508*/ UnityEngine.UIElements.IPanel GetPanel(int pointerId, UnityEngine.UIElements.ContextType contextType);
            static /*0x2a62588*/ bool HasFlagFast(UnityEngine.UIElements.PointerDeviceState.LocationFlag flagSet, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag);
            static /*0x2a62594*/ bool HasLocationFlag(int pointerId, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag);
            static /*0x2a62628*/ int GetPressedButtons(int pointerId);
            static /*0x2a626a4*/ bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId);
            static /*0x2a6273c*/ void SetPlayerPanelWithSoftPointerCapture(int pointerId, UnityEngine.UIElements.IPanel panel);
            static /*0x2a627e8*/ UnityEngine.UIElements.IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId);

            enum LocationFlag
            {
                None = 0,
                OutsidePanel = 1,
            }

            struct PointerLocation
            {
                /*0x10*/ UnityEngine.Vector2 <Position>k__BackingField;
                /*0x18*/ UnityEngine.UIElements.IPanel <Panel>k__BackingField;
                /*0x20*/ UnityEngine.UIElements.PointerDeviceState.LocationFlag <Flags>k__BackingField;

                /*0x2a62968*/ UnityEngine.Vector2 get_Position();
                /*0x2a62970*/ void set_Position(UnityEngine.Vector2 value);
                /*0x2a62978*/ UnityEngine.UIElements.IPanel get_Panel();
                /*0x2a62980*/ void set_Panel(UnityEngine.UIElements.IPanel value);
                /*0x2a62988*/ UnityEngine.UIElements.PointerDeviceState.LocationFlag get_Flags();
                /*0x2a62990*/ void set_Flags(UnityEngine.UIElements.PointerDeviceState.LocationFlag value);
                /*0x2a62120*/ void SetLocation(UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel);
            }
        }

        class PointerCaptureDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a63048*/ PointerCaptureDispatchingStrategy();
            /*0x2a62998*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a629ec*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        enum TrickleDown
        {
            NoTrickleDown = 0,
            TrickleDown = 1,
        }

        enum CallbackPhase
        {
            TargetAndBubbleUp = 1,
            TrickleDownAndTarget = 2,
        }

        enum InvokePolicy
        {
            Default = 0,
            IncludeDisabled = 1,
        }

        class EventCallbackListPool
        {
            /*0x10*/ System.Collections.Generic.Stack<UnityEngine.UIElements.EventCallbackList> m_Stack;

            /*0x2a63484*/ EventCallbackListPool();
            /*0x2a63050*/ UnityEngine.UIElements.EventCallbackList Get(UnityEngine.UIElements.EventCallbackList initializer);
            /*0x2a633b4*/ void Release(UnityEngine.UIElements.EventCallbackList element);
        }

        class EventCallbackList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase> m_List;
            /*0x18*/ int <trickleDownCallbackCount>k__BackingField;
            /*0x1c*/ int <bubbleUpCallbackCount>k__BackingField;

            /*0x2a631a4*/ EventCallbackList();
            /*0x2a63114*/ EventCallbackList(UnityEngine.UIElements.EventCallbackList source);
            /*0x2a63500*/ int get_trickleDownCallbackCount();
            /*0x2a63508*/ void set_trickleDownCallbackCount(int value);
            /*0x2a63510*/ int get_bubbleUpCallbackCount();
            /*0x2a63518*/ void set_bubbleUpCallbackCount(int value);
            /*0x2a63520*/ bool Contains(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x2a63538*/ UnityEngine.UIElements.EventCallbackFunctorBase Find(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x2a63620*/ bool Remove(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x2a63740*/ void Add(UnityEngine.UIElements.EventCallbackFunctorBase item);
            /*0x2a63224*/ void AddRange(UnityEngine.UIElements.EventCallbackList list);
            /*0x2a6381c*/ int get_Count();
            /*0x2a63864*/ UnityEngine.UIElements.EventCallbackFunctorBase get_Item(int i);
            /*0x2a63418*/ void Clear();
        }

        class EventCallbackRegistry
        {
            static /*0x0*/ UnityEngine.UIElements.EventCallbackListPool s_ListPool;
            /*0x10*/ UnityEngine.UIElements.EventCallbackList m_Callbacks;
            /*0x18*/ UnityEngine.UIElements.EventCallbackList m_TemporaryCallbacks;
            /*0x20*/ int m_IsInvoking;

            static /*0x2a63cb8*/ EventCallbackRegistry();
            static /*0x2a638bc*/ UnityEngine.UIElements.EventCallbackList GetCallbackList(UnityEngine.UIElements.EventCallbackList initializer);
            static /*0x2a63924*/ void ReleaseCallbackList(UnityEngine.UIElements.EventCallbackList toRelease);
            /*0x2a6398c*/ EventCallbackRegistry();
            /*0x2a639a8*/ UnityEngine.UIElements.EventCallbackList GetCallbackListForWriting();
            /*0x2a63a58*/ UnityEngine.UIElements.EventCallbackList GetCallbackListForReading();
            /*0x2a63a74*/ bool UnregisterCallback(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown, UnityEngine.UIElements.InvokePolicy invokePolicy);
            bool UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            /*0x2a63ac8*/ void InvokeCallbacks(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase);
            /*0x2a63c78*/ bool HasTrickleDownHandlers();
            /*0x2a63c98*/ bool HasBubbleHandlers();
        }

        class KeyboardEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a649cc*/ KeyboardEventDispatchingStrategy();
            /*0x2a63d2c*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a63d80*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class MouseEventsHelper
        {
            static void SendEnterLeave<TLeaveEvent, TEnterEvent>(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition);
            static /*0x2a61864*/ void SendMouseOverMouseOut(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition);
        }

        class PointerEventsHelper
        {
            static void SendEnterLeave<TLeaveEvent, TEnterEvent>(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, int pointerId);
            static /*0x2a614e4*/ void SendOverOut(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, int pointerId);
        }

        class PropagationPaths
        {
            static int k_DefaultPropagationDepth = 16;
            static int k_DefaultTargetCount = 4;
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.PropagationPaths> s_Pool;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> trickleDownPath;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> targetElements;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> bubbleUpPath;

            static /*0x2a64f88*/ PropagationPaths();
            static /*0x2a64aa0*/ UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths paths);
            static /*0x2a64b80*/ UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement elem, UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths.Type pathTypesRequested);
            /*0x2a649d4*/ PropagationPaths();
            /*0x2a64e78*/ void Release();

            enum Type
            {
                None = 0,
                TrickleDown = 1,
                BubbleUp = 2,
            }
        }

        class DefaultDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a6529c*/ DefaultDispatchingStrategy();
            /*0x2a65018*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a65090*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class TooltipEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.TooltipEvent>
        {
            /*0x80*/ string <tooltip>k__BackingField;
            /*0x88*/ UnityEngine.Rect <rect>k__BackingField;

            /*0x2a653c0*/ TooltipEvent();
            /*0x2a652a4*/ void set_tooltip(string value);
            /*0x2a652ac*/ void set_rect(UnityEngine.Rect value);
            /*0x2a652b8*/ void Init();
            /*0x2a65348*/ void LocalInit();
        }

        class MouseCaptureDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a65bfc*/ MouseCaptureDispatchingStrategy();
            /*0x2a65474*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a65508*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);

            enum EventBehavior
            {
                None = 0,
                IsCapturable = 1,
                IsSentExclusivelyToCapturingElement = 2,
            }
        }

        class EventBase : System.IDisposable
        {
            static /*0x0*/ long s_LastTypeId;
            static /*0x8*/ ulong s_NextEventId;
            /*0x10*/ long <timestamp>k__BackingField;
            /*0x18*/ ulong <eventId>k__BackingField;
            /*0x20*/ ulong <triggerEventId>k__BackingField;
            /*0x28*/ UnityEngine.UIElements.EventBase.EventPropagation <propagation>k__BackingField;
            /*0x30*/ UnityEngine.UIElements.PropagationPaths m_Path;
            /*0x38*/ UnityEngine.UIElements.EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField;
            /*0x40*/ UnityEngine.UIElements.IEventHandler <leafTarget>k__BackingField;
            /*0x48*/ UnityEngine.UIElements.IEventHandler m_Target;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> <skipElements>k__BackingField;
            /*0x58*/ UnityEngine.UIElements.PropagationPhase <propagationPhase>k__BackingField;
            /*0x60*/ UnityEngine.UIElements.IEventHandler m_CurrentTarget;
            /*0x68*/ UnityEngine.Event m_ImguiEvent;
            /*0x70*/ UnityEngine.Vector2 <originalMousePosition>k__BackingField;

            static /*0x2a65c04*/ long RegisterEventType();
            /*0x2a66278*/ EventBase();
            /*0x2a65c54*/ long get_eventTypeId();
            /*0x2a65c5c*/ long get_timestamp();
            /*0x2a65c64*/ void set_timestamp(long value);
            /*0x2a65c6c*/ ulong get_eventId();
            /*0x2a65c74*/ void set_eventId(ulong value);
            /*0x2a65c7c*/ void set_triggerEventId(ulong value);
            /*0x2a65c84*/ void SetTriggerEventId(ulong id);
            /*0x2a65c8c*/ UnityEngine.UIElements.EventBase.EventPropagation get_propagation();
            /*0x2a65c94*/ void set_propagation(UnityEngine.UIElements.EventBase.EventPropagation value);
            /*0x2a65c9c*/ UnityEngine.UIElements.PropagationPaths get_path();
            /*0x2a65d94*/ void set_path(UnityEngine.UIElements.PropagationPaths value);
            /*0x2a65df8*/ UnityEngine.UIElements.EventBase.LifeCycleStatus get_lifeCycleStatus();
            /*0x2a65e00*/ void set_lifeCycleStatus(UnityEngine.UIElements.EventBase.LifeCycleStatus value);
            /*0x2a65e08*/ void PreDispatch();
            /*0x2a65e0c*/ void PreDispatch(UnityEngine.UIElements.IPanel panel);
            /*0x2a65e18*/ void PostDispatch();
            /*0x2a65e1c*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
            /*0x2a65d88*/ bool get_bubbles();
            /*0x2a65d7c*/ bool get_tricklesDown();
            /*0x2a63c6c*/ bool get_skipDisabledElements();
            /*0x2a62ff4*/ void set_skipDisabledElements(bool value);
            /*0x2a64e1c*/ bool get_ignoreCompositeRoots();
            /*0x2a653a4*/ void set_ignoreCompositeRoots(bool value);
            /*0x2a65e60*/ UnityEngine.UIElements.IEventHandler get_leafTarget();
            /*0x2a65e68*/ void set_leafTarget(UnityEngine.UIElements.IEventHandler value);
            /*0x2a5d478*/ UnityEngine.UIElements.IEventHandler get_target();
            /*0x2a62fdc*/ void set_target(UnityEngine.UIElements.IEventHandler value);
            /*0x2a65e70*/ System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements();
            /*0x2a63ff8*/ bool Skip(UnityEngine.UIElements.IEventHandler h);
            /*0x2a6479c*/ bool get_isPropagationStopped();
            /*0x2a65e78*/ void set_isPropagationStopped(bool value);
            /*0x2a5ab74*/ void StopPropagation();
            /*0x2a63c60*/ bool get_isImmediatePropagationStopped();
            /*0x2a65e94*/ void set_isImmediatePropagationStopped(bool value);
            /*0x2a65eb0*/ void StopImmediatePropagation();
            /*0x2a65ec0*/ bool get_isDefaultPrevented();
            /*0x2a65ecc*/ void set_isDefaultPrevented(bool value);
            /*0x2a5ab84*/ void PreventDefault();
            /*0x2a65ee8*/ UnityEngine.UIElements.PropagationPhase get_propagationPhase();
            /*0x2a65ef0*/ void set_propagationPhase(UnityEngine.UIElements.PropagationPhase value);
            /*0x2a65ef8*/ UnityEngine.UIElements.IEventHandler get_currentTarget();
            /*0x2a65f00*/ void set_currentTarget(UnityEngine.UIElements.IEventHandler value);
            /*0x2a65fe4*/ bool get_dispatch();
            /*0x2a62fbc*/ void set_dispatch(bool value);
            /*0x2a6600c*/ void MarkReceivedByDispatcher();
            /*0x2a66094*/ bool get_dispatched();
            /*0x2a65ff0*/ void set_dispatched(bool value);
            /*0x2a660a0*/ bool get_processed();
            /*0x2a65e44*/ void set_processed(bool value);
            /*0x2a660ac*/ bool get_processedByFocusController();
            /*0x2a660b8*/ void set_processedByFocusController(bool value);
            /*0x2a660d4*/ bool get_stopDispatch();
            /*0x2a63010*/ void set_stopDispatch(bool value);
            /*0x2a65290*/ bool get_propagateToIMGUI();
            /*0x2a6302c*/ void set_propagateToIMGUI(bool value);
            /*0x2a660e0*/ bool get_imguiEventIsValid();
            /*0x2a660ec*/ void set_imguiEventIsValid(bool value);
            /*0x2a654f0*/ UnityEngine.Event get_imguiEvent();
            /*0x2a61db8*/ void set_imguiEvent(UnityEngine.Event value);
            /*0x2a66108*/ UnityEngine.Vector2 get_originalMousePosition();
            /*0x2a66110*/ void set_originalMousePosition(UnityEngine.Vector2 value);
            /*0x2a66118*/ void Init();
            /*0x2a6611c*/ void LocalInit();
            /*0x2a66300*/ bool get_pooled();
            /*0x2a6625c*/ void set_pooled(bool value);
            void Acquire();
            void Dispose();

            enum EventPropagation
            {
                None = 0,
                Bubbles = 1,
                TricklesDown = 2,
                Cancellable = 4,
                SkipDisabledElements = 8,
                IgnoreCompositeRoots = 16,
            }

            enum LifeCycleStatus
            {
                None = 0,
                PropagationStopped = 1,
                ImmediatePropagationStopped = 2,
                DefaultPrevented = 4,
                Dispatching = 8,
                Pooled = 16,
                IMGUIEventIsValid = 32,
                StopDispatch = 64,
                PropagateToIMGUI = 128,
                Dispatched = 512,
                Processed = 1024,
                ProcessedByFocusController = 2048,
            }
        }

        class EventBase<T> : UnityEngine.UIElements.EventBase
        {
            static /*0x0*/ long s_TypeId;
            static /*0x0*/ UnityEngine.UIElements.ObjectPool<T> s_Pool;
            /*0x0*/ int m_RefCount;

            static EventBase();
            static long TypeId();
            static T GetPooled();
            static T GetPooled(UnityEngine.UIElements.EventBase e);
            static void ReleasePooled(T evt);
            EventBase();
            void Init();
            void Acquire();
            void Dispose();
            long get_eventTypeId();
        }

        class ChangeEvent<T> : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.ChangeEvent<T>>
        {
            /*0x0*/ T <previousValue>k__BackingField;
            /*0x0*/ T <newValue>k__BackingField;

            static UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue);
            ChangeEvent();
            T get_previousValue();
            void set_previousValue(T value);
            T get_newValue();
            void set_newValue(T value);
            void Init();
            void LocalInit();
        }

        class EventCallback<TEventType> : System.MulticastDelegate
        {
            EventCallback(object object, nint method);
            void Invoke(TEventType evt);
        }

        class EventCallbackFunctorBase
        {
            /*0x10*/ UnityEngine.UIElements.CallbackPhase <phase>k__BackingField;
            /*0x14*/ UnityEngine.UIElements.InvokePolicy <invokePolicy>k__BackingField;

            /*0x2a6631c*/ EventCallbackFunctorBase(UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy);
            /*0x2a6630c*/ UnityEngine.UIElements.CallbackPhase get_phase();
            /*0x2a66314*/ UnityEngine.UIElements.InvokePolicy get_invokePolicy();
            void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase);
            bool IsEquivalentTo(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
            /*0x2a66348*/ bool PhaseMatches(UnityEngine.UIElements.PropagationPhase propagationPhase);
        }

        class EventCallbackFunctor<TEventType> : UnityEngine.UIElements.EventCallbackFunctorBase
        {
            /*0x0*/ UnityEngine.UIElements.EventCallback<TEventType> m_Callback;
            /*0x0*/ long m_EventTypeId;

            EventCallbackFunctor(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy);
            void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase);
            bool IsEquivalentTo(long eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase);
        }

        class PointerEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            static /*0x2a6664c*/ void SendEventToTarget(UnityEngine.UIElements.EventBase evt);
            static /*0x2a66410*/ void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
            static /*0x2a66670*/ void UpdateElementUnderPointer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, ref UnityEngine.UIElements.VisualElement elementUnderPointer);
            /*0x2a6691c*/ PointerEventDispatchingStrategy();
            /*0x2a66384*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a663d8*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        struct StylePropertyNameCollection : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> propertiesList;

            /*0x2a66924*/ StylePropertyNameCollection(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list);
            /*0x2a6692c*/ UnityEngine.UIElements.StylePropertyNameCollection.Enumerator GetEnumerator();
            /*0x2a669a8*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator();
            /*0x2a66a10*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            struct Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> m_Enumerator;

                /*0x2a6699c*/ Enumerator(System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> enumerator);
                /*0x2a66a78*/ bool MoveNext();
                /*0x2a66ac0*/ UnityEngine.UIElements.StylePropertyName get_Current();
                /*0x2a66afc*/ object System.Collections.IEnumerator.get_Current();
                /*0x2a66b78*/ void Reset();
                /*0x2a66b7c*/ void Dispose();
            }
        }

        class TransitionEventBase<T> : UnityEngine.UIElements.EventBase<T>
        {
            /*0x0*/ UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField;
            /*0x0*/ double <elapsedTime>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.StylePropertyName stylePropertyName, double elapsedTime);
            TransitionEventBase();
            UnityEngine.UIElements.StylePropertyNameCollection get_stylePropertyNames();
            void set_elapsedTime(double value);
            void Init();
            void LocalInit();
        }

        class TransitionRunEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionRunEvent>
        {
            /*0x2a66bc4*/ TransitionRunEvent();
        }

        class TransitionStartEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionStartEvent>
        {
            /*0x2a66c0c*/ TransitionStartEvent();
        }

        class TransitionEndEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionEndEvent>
        {
            /*0x2a66c54*/ TransitionEndEvent();
        }

        class TransitionCancelEvent : UnityEngine.UIElements.TransitionEventBase<UnityEngine.UIElements.TransitionCancelEvent>
        {
            /*0x2a66c9c*/ TransitionCancelEvent();
        }

        class NavigationEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a66e7c*/ NavigationEventDispatchingStrategy();
            /*0x2a66ce4*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a66d38*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class PointerType
        {
            static /*0x0*/ string mouse;
            static /*0x8*/ string touch;
            static /*0x10*/ string pen;
            static /*0x18*/ string unknown;

            static /*0x2a66fac*/ PointerType();
            static /*0x2a66e84*/ string GetPointerType(int pointerId);
            static /*0x2a66f20*/ bool IsDirectManipulationDevice(string pointerType);
        }

        class PointerId
        {
            static /*0x0*/ int maxPointers;
            static /*0x4*/ int invalidPointerId;
            static /*0x8*/ int mousePointerId;
            static /*0xc*/ int touchPointerIdBase;
            static /*0x10*/ int touchPointerCount;
            static /*0x14*/ int penPointerIdBase;
            static /*0x18*/ int penPointerCount;
            static /*0x20*/ int[] hoveringPointers;

            static /*0x2a67078*/ PointerId();
        }

        interface IPointerEvent
        {
            int get_pointerId();
            string get_pointerType();
            bool get_isPrimary();
            int get_button();
            int get_pressedButtons();
            UnityEngine.Vector3 get_position();
            UnityEngine.Vector3 get_localPosition();
            UnityEngine.Vector3 get_deltaPosition();
            float get_deltaTime();
            int get_clickCount();
            float get_pressure();
            float get_tangentialPressure();
            float get_altitudeAngle();
            float get_azimuthAngle();
            float get_twist();
            UnityEngine.Vector2 get_radius();
            UnityEngine.Vector2 get_radiusVariance();
            UnityEngine.EventModifiers get_modifiers();
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool get_actionKey();
        }

        interface IPointerEventInternal
        {
            bool get_triggeredByOS();
            void set_triggeredByOS(bool value);
            bool get_recomputeTopElementUnderPointer();
            void set_recomputeTopElementUnderPointer(bool value);
        }

        class PointerEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IPointerEvent, UnityEngine.UIElements.IPointerEventInternal
        {
            /*0x0*/ int <pointerId>k__BackingField;
            /*0x0*/ string <pointerType>k__BackingField;
            /*0x0*/ bool <isPrimary>k__BackingField;
            /*0x0*/ int <button>k__BackingField;
            /*0x0*/ int <pressedButtons>k__BackingField;
            /*0x0*/ UnityEngine.Vector3 <position>k__BackingField;
            /*0x0*/ UnityEngine.Vector3 <localPosition>k__BackingField;
            /*0x0*/ UnityEngine.Vector3 <deltaPosition>k__BackingField;
            /*0x0*/ float <deltaTime>k__BackingField;
            /*0x0*/ int <clickCount>k__BackingField;
            /*0x0*/ float <pressure>k__BackingField;
            /*0x0*/ float <tangentialPressure>k__BackingField;
            /*0x0*/ float <altitudeAngle>k__BackingField;
            /*0x0*/ float <azimuthAngle>k__BackingField;
            /*0x0*/ float <twist>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <radius>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
            /*0x0*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField;

            static bool IsMouse(UnityEngine.Event systemEvent);
            static T GetPooled(UnityEngine.Event systemEvent);
            static T GetPooled(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers);
            static T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, int pointerId);
            static T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent);
            PointerEventBase();
            int get_pointerId();
            void set_pointerId(int value);
            string get_pointerType();
            void set_pointerType(string value);
            bool get_isPrimary();
            void set_isPrimary(bool value);
            int get_button();
            void set_button(int value);
            int get_pressedButtons();
            void set_pressedButtons(int value);
            UnityEngine.Vector3 get_position();
            void set_position(UnityEngine.Vector3 value);
            UnityEngine.Vector3 get_localPosition();
            void set_localPosition(UnityEngine.Vector3 value);
            UnityEngine.Vector3 get_deltaPosition();
            void set_deltaPosition(UnityEngine.Vector3 value);
            float get_deltaTime();
            void set_deltaTime(float value);
            int get_clickCount();
            void set_clickCount(int value);
            float get_pressure();
            void set_pressure(float value);
            float get_tangentialPressure();
            void set_tangentialPressure(float value);
            float get_altitudeAngle();
            void set_altitudeAngle(float value);
            float get_azimuthAngle();
            void set_azimuthAngle(float value);
            float get_twist();
            void set_twist(float value);
            UnityEngine.Vector2 get_radius();
            void set_radius(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_radiusVariance();
            void set_radiusVariance(UnityEngine.Vector2 value);
            UnityEngine.EventModifiers get_modifiers();
            void set_modifiers(UnityEngine.EventModifiers value);
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool get_actionKey();
            bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS();
            void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value);
            bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer();
            void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value);
            void Init();
            void LocalInit();
            UnityEngine.UIElements.IEventHandler get_currentTarget();
            void set_currentTarget(UnityEngine.UIElements.IEventHandler value);
            void PreDispatch(UnityEngine.UIElements.IPanel panel);
            void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerDownEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerDownEvent>
        {
            /*0x2a67278*/ PointerDownEvent();
            /*0x2a67124*/ void Init();
            /*0x2a67174*/ void LocalInit();
            /*0x2a672c8*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerMoveEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerMoveEvent>
        {
            /*0xea*/ bool <isHandledByDraggable>k__BackingField;

            /*0x2a676a0*/ PointerMoveEvent();
            /*0x2a67530*/ bool get_isHandledByDraggable();
            /*0x2a67538*/ void set_isHandledByDraggable(bool value);
            /*0x2a67544*/ void Init();
            /*0x2a67594*/ void LocalInit();
            /*0x2a676f0*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerStationaryEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerStationaryEvent>
        {
            /*0x2a67e9c*/ PointerStationaryEvent();
            /*0x2a67d48*/ void Init();
            /*0x2a67d98*/ void LocalInit();
        }

        class PointerUpEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerUpEvent>
        {
            /*0x2a68040*/ PointerUpEvent();
            /*0x2a67eec*/ void Init();
            /*0x2a67f3c*/ void LocalInit();
            /*0x2a68090*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class PointerCancelEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerCancelEvent>
        {
            /*0x2a68514*/ PointerCancelEvent();
            /*0x2a683c0*/ void Init();
            /*0x2a68410*/ void LocalInit();
            /*0x2a68564*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class ClickEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.ClickEvent>
        {
            static /*0x2a6894c*/ UnityEngine.UIElements.ClickEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent, int clickCount);
            /*0x2a688f8*/ ClickEvent();
            /*0x2a68898*/ void Init();
            /*0x2a688ec*/ void LocalInit();
        }

        class PointerEnterEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerEnterEvent>
        {
            /*0x2a68a1c*/ PointerEnterEvent();
            /*0x2a689bc*/ void Init();
            /*0x2a68a10*/ void LocalInit();
        }

        class PointerLeaveEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerLeaveEvent>
        {
            /*0x2a68ad0*/ PointerLeaveEvent();
            /*0x2a68a70*/ void Init();
            /*0x2a68ac4*/ void LocalInit();
        }

        class PointerOverEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerOverEvent>
        {
            /*0x2a68b24*/ PointerOverEvent();
        }

        class PointerOutEvent : UnityEngine.UIElements.PointerEventBase<UnityEngine.UIElements.PointerOutEvent>
        {
            /*0x2a68b6c*/ PointerOutEvent();
        }

        class CustomStyleResolvedEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.CustomStyleResolvedEvent>
        {
            /*0x2a68bb4*/ CustomStyleResolvedEvent();
            /*0x2a5d79c*/ UnityEngine.UIElements.ICustomStyle get_customStyle();
        }

        interface IEventHandler
        {
            void SendEvent(UnityEngine.UIElements.EventBase e);
            void HandleEvent(UnityEngine.UIElements.EventBase evt);
        }

        class CallbackEventHandler : UnityEngine.UIElements.IEventHandler
        {
            /*0x10*/ UnityEngine.UIElements.EventCallbackRegistry m_CallbackRegistry;

            /*0x2a68ef0*/ CallbackEventHandler();
            void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.InvokePolicy invokePolicy, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown);
            void SendEvent(UnityEngine.UIElements.EventBase e);
            void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode);
            /*0x2a65b90*/ void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase evt);
            /*0x2a68c20*/ void HandleEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a64e28*/ bool HasTrickleDownHandlers();
            /*0x2a64e50*/ bool HasBubbleUpHandlers();
            /*0x2a68ee0*/ void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x2a68ee4*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x2a68ee8*/ void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt);
            /*0x2a68eec*/ void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt);
        }

        class GeometryChangedEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.GeometryChangedEvent>
        {
            /*0x7c*/ UnityEngine.Rect <oldRect>k__BackingField;
            /*0x8c*/ UnityEngine.Rect <newRect>k__BackingField;
            /*0x9c*/ int <layoutPass>k__BackingField;

            static /*0x2a68ef8*/ UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect oldRect, UnityEngine.Rect newRect);
            /*0x2a6907c*/ GeometryChangedEvent();
            /*0x2a68fb8*/ void Init();
            /*0x2a69008*/ void LocalInit();
            /*0x2a6903c*/ UnityEngine.Rect get_oldRect();
            /*0x2a69048*/ void set_oldRect(UnityEngine.Rect value);
            /*0x2a69054*/ UnityEngine.Rect get_newRect();
            /*0x2a69060*/ void set_newRect(UnityEngine.Rect value);
            /*0x2a6906c*/ int get_layoutPass();
            /*0x2a69074*/ void set_layoutPass(int value);
        }

        interface IMouseEvent
        {
            UnityEngine.EventModifiers get_modifiers();
            UnityEngine.Vector2 get_mousePosition();
            UnityEngine.Vector2 get_localMousePosition();
            UnityEngine.Vector2 get_mouseDelta();
            int get_clickCount();
            int get_button();
            int get_pressedButtons();
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
        }

        interface IMouseEventInternal
        {
            bool get_triggeredByOS();
            void set_triggeredByOS(bool value);
            bool get_recomputeTopElementUnderMouse();
            void set_recomputeTopElementUnderMouse(bool value);
            UnityEngine.UIElements.IPointerEvent get_sourcePointerEvent();
            void set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value);
        }

        class MouseEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IMouseEvent, UnityEngine.UIElements.IMouseEventInternal
        {
            /*0x0*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <mousePosition>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <localMousePosition>k__BackingField;
            /*0x0*/ UnityEngine.Vector2 <mouseDelta>k__BackingField;
            /*0x0*/ int <clickCount>k__BackingField;
            /*0x0*/ int <button>k__BackingField;
            /*0x0*/ int <pressedButtons>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField;
            /*0x0*/ bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField;

            static T GetPooled(UnityEngine.Event systemEvent);
            static T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition, bool recomputeTopElementUnderMouse);
            static T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent);
            static T GetPooled(UnityEngine.UIElements.IPointerEvent pointerEvent);
            MouseEventBase();
            UnityEngine.EventModifiers get_modifiers();
            void set_modifiers(UnityEngine.EventModifiers value);
            UnityEngine.Vector2 get_mousePosition();
            void set_mousePosition(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_localMousePosition();
            void set_localMousePosition(UnityEngine.Vector2 value);
            UnityEngine.Vector2 get_mouseDelta();
            void set_mouseDelta(UnityEngine.Vector2 value);
            int get_clickCount();
            void set_clickCount(int value);
            int get_button();
            void set_button(int value);
            int get_pressedButtons();
            void set_pressedButtons(int value);
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS();
            void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value);
            bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse();
            void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value);
            UnityEngine.UIElements.IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent();
            void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value);
            void Init();
            void LocalInit();
            UnityEngine.UIElements.IEventHandler get_currentTarget();
            void set_currentTarget(UnityEngine.UIElements.IEventHandler value);
            void PreDispatch(UnityEngine.UIElements.IPanel panel);
            void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseDownEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseDownEvent>
        {
            static /*0x2a691a4*/ UnityEngine.UIElements.MouseDownEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent);
            static /*0x2a6752c*/ UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerDownEvent pointerEvent);
            static /*0x2a67cf8*/ UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent);
            /*0x2a69150*/ MouseDownEvent();
            /*0x2a690f0*/ void Init();
            /*0x2a69144*/ void LocalInit();
        }

        class MouseUpEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseUpEvent>
        {
            static /*0x2a693e4*/ UnityEngine.UIElements.MouseUpEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent);
            static /*0x2a683bc*/ UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent);
            static /*0x2a67cfc*/ UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent);
            static /*0x2a68894*/ UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerCancelEvent pointerEvent);
            /*0x2a69390*/ MouseUpEvent();
            /*0x2a69330*/ void Init();
            /*0x2a69384*/ void LocalInit();
        }

        class MouseMoveEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseMoveEvent>
        {
            static /*0x2a67d00*/ UnityEngine.UIElements.MouseMoveEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent);
            /*0x2a695d0*/ MouseMoveEvent();
            /*0x2a69570*/ void Init();
            /*0x2a695c4*/ void LocalInit();
        }

        class ContextClickEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.ContextClickEvent>
        {
            /*0x2a69624*/ ContextClickEvent();
        }

        class WheelEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.WheelEvent>
        {
            /*0xb0*/ UnityEngine.Vector3 <delta>k__BackingField;

            static /*0x2a69684*/ UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Event systemEvent);
            static /*0x2a69700*/ UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Vector3 delta, UnityEngine.UIElements.IPointerEvent pointerEvent);
            /*0x2a69828*/ WheelEvent();
            /*0x2a6966c*/ UnityEngine.Vector3 get_delta();
            /*0x2a69678*/ void set_delta(UnityEngine.Vector3 value);
            /*0x2a69778*/ void Init();
            /*0x2a697c8*/ void LocalInit();
        }

        class MouseEnterEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseEnterEvent>
        {
            /*0x2a698d8*/ MouseEnterEvent();
            /*0x2a69878*/ void Init();
            /*0x2a698cc*/ void LocalInit();
        }

        class MouseLeaveEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseLeaveEvent>
        {
            /*0x2a6998c*/ MouseLeaveEvent();
            /*0x2a6992c*/ void Init();
            /*0x2a69980*/ void LocalInit();
        }

        class MouseEnterWindowEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseEnterWindowEvent>
        {
            /*0x2a69a40*/ MouseEnterWindowEvent();
            /*0x2a699e0*/ void Init();
            /*0x2a69a34*/ void LocalInit();
            /*0x2a69a94*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseLeaveWindowEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseLeaveWindowEvent>
        {
            static /*0x2a69d34*/ UnityEngine.UIElements.MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent);
            /*0x2a69ce4*/ MouseLeaveWindowEvent();
            /*0x2a69bf0*/ void Init();
            /*0x2a69c40*/ void LocalInit();
            /*0x2a69de8*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseOverEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseOverEvent>
        {
            /*0x2a69f44*/ MouseOverEvent();
        }

        class MouseOutEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.MouseOutEvent>
        {
            /*0x2a69f8c*/ MouseOutEvent();
        }

        class ContextualMenuPopulateEvent : UnityEngine.UIElements.MouseEventBase<UnityEngine.UIElements.ContextualMenuPopulateEvent>
        {
            /*0xb0*/ UnityEngine.UIElements.DropdownMenu <menu>k__BackingField;
            /*0xb8*/ UnityEngine.UIElements.EventBase <triggerEvent>k__BackingField;
            /*0xc0*/ UnityEngine.UIElements.ContextualMenuManager m_ContextualMenuManager;

            /*0x2a6a098*/ ContextualMenuPopulateEvent();
            /*0x2a69fd4*/ UnityEngine.UIElements.DropdownMenu get_menu();
            /*0x2a69fdc*/ void set_menu(UnityEngine.UIElements.DropdownMenu value);
            /*0x2a69fe4*/ UnityEngine.UIElements.EventBase get_triggerEvent();
            /*0x2a69fec*/ void set_triggerEvent(UnityEngine.UIElements.EventBase value);
            /*0x2a69ff4*/ void Init();
            /*0x2a6a064*/ void LocalInit();
            /*0x2a6a108*/ void PostDispatch(UnityEngine.UIElements.IPanel panel);
        }

        interface ICommandEvent
        {
        }

        class CommandEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.ICommandEvent
        {
            /*0x0*/ string m_CommandName;

            static T GetPooled(UnityEngine.Event systemEvent);
            static T GetPooled(string commandName);
            CommandEventBase();
            string get_commandName();
            void set_commandName(string value);
            void Init();
            void LocalInit();
        }

        class ValidateCommandEvent : UnityEngine.UIElements.CommandEventBase<UnityEngine.UIElements.ValidateCommandEvent>
        {
            /*0x2a6a198*/ ValidateCommandEvent();
        }

        class ExecuteCommandEvent : UnityEngine.UIElements.CommandEventBase<UnityEngine.UIElements.ExecuteCommandEvent>
        {
            /*0x2a6a1e0*/ ExecuteCommandEvent();
        }

        class FocusEventBase<T> : UnityEngine.UIElements.EventBase<T>
        {
            /*0x0*/ UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.FocusController <focusController>k__BackingField;
            /*0x0*/ bool <IsFocusDelegated>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.Focusable relatedTarget, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.FocusController focusController, bool bIsFocusDelegated);
            FocusEventBase();
            UnityEngine.UIElements.Focusable get_relatedTarget();
            void set_relatedTarget(UnityEngine.UIElements.Focusable value);
            UnityEngine.UIElements.FocusChangeDirection get_direction();
            void set_direction(UnityEngine.UIElements.FocusChangeDirection value);
            UnityEngine.UIElements.FocusController get_focusController();
            void set_focusController(UnityEngine.UIElements.FocusController value);
            bool get_IsFocusDelegated();
            void set_IsFocusDelegated(bool value);
            void Init();
            void LocalInit();
        }

        class FocusOutEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.FocusOutEvent>
        {
            /*0x2a6a288*/ FocusOutEvent();
            /*0x2a6a228*/ void Init();
            /*0x2a6a27c*/ void LocalInit();
        }

        class BlurEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.BlurEvent>
        {
            /*0x2a6a358*/ BlurEvent();
            /*0x2a6a2dc*/ void PreDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class FocusInEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.FocusInEvent>
        {
            /*0x2a6a400*/ FocusInEvent();
            /*0x2a6a3a0*/ void Init();
            /*0x2a6a3f4*/ void LocalInit();
        }

        class FocusEvent : UnityEngine.UIElements.FocusEventBase<UnityEngine.UIElements.FocusEvent>
        {
            /*0x2a6a4fc*/ FocusEvent();
            /*0x2a6a454*/ void PreDispatch(UnityEngine.UIElements.IPanel panel);
        }

        class MouseEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            static /*0x2a6a740*/ bool SendEventToTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x2a6a77c*/ bool SendEventToRegularTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x2a6a7b4*/ bool SendEventToIMGUIContainer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x2a6a6a0*/ void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel);
            static /*0x2a6a9d4*/ void UpdateElementUnderMouse(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel, ref UnityEngine.UIElements.VisualElement elementUnderMouse);
            static /*0x2a6a98c*/ bool IsDone(UnityEngine.UIElements.EventBase evt);
            /*0x2a6acd0*/ MouseEventDispatchingStrategy();
            /*0x2a6a544*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a6a598*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel iPanel);
        }

        class IMGUIEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a6ae10*/ IMGUIEventDispatchingStrategy();
            /*0x2a6acd8*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a6ad50*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        interface IKeyboardEvent
        {
            UnityEngine.EventModifiers get_modifiers();
            char get_character();
            UnityEngine.KeyCode get_keyCode();
        }

        class KeyboardEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.IKeyboardEvent
        {
            /*0x0*/ UnityEngine.EventModifiers <modifiers>k__BackingField;
            /*0x0*/ char <character>k__BackingField;
            /*0x0*/ UnityEngine.KeyCode <keyCode>k__BackingField;

            static T GetPooled(char c, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers);
            static T GetPooled(UnityEngine.Event systemEvent);
            KeyboardEventBase();
            UnityEngine.EventModifiers get_modifiers();
            void set_modifiers(UnityEngine.EventModifiers value);
            char get_character();
            void set_character(char value);
            UnityEngine.KeyCode get_keyCode();
            void set_keyCode(UnityEngine.KeyCode value);
            bool get_shiftKey();
            bool get_ctrlKey();
            bool get_commandKey();
            bool get_altKey();
            bool get_actionKey();
            void Init();
            void LocalInit();
        }

        class KeyDownEvent : UnityEngine.UIElements.KeyboardEventBase<UnityEngine.UIElements.KeyDownEvent>
        {
            /*0x2a6aed8*/ KeyDownEvent();
            /*0x2a6ae18*/ void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent);
        }

        class KeyUpEvent : UnityEngine.UIElements.KeyboardEventBase<UnityEngine.UIElements.KeyUpEvent>
        {
            /*0x2a6af20*/ KeyUpEvent();
        }

        class PanelChangedEventBase<T> : UnityEngine.UIElements.EventBase<T>
        {
            /*0x0*/ UnityEngine.UIElements.IPanel <originPanel>k__BackingField;
            /*0x0*/ UnityEngine.UIElements.IPanel <destinationPanel>k__BackingField;

            static T GetPooled(UnityEngine.UIElements.IPanel originPanel, UnityEngine.UIElements.IPanel destinationPanel);
            PanelChangedEventBase();
            UnityEngine.UIElements.IPanel get_originPanel();
            void set_originPanel(UnityEngine.UIElements.IPanel value);
            UnityEngine.UIElements.IPanel get_destinationPanel();
            void set_destinationPanel(UnityEngine.UIElements.IPanel value);
            void Init();
            void LocalInit();
        }

        class AttachToPanelEvent : UnityEngine.UIElements.PanelChangedEventBase<UnityEngine.UIElements.AttachToPanelEvent>
        {
            /*0x2a6af68*/ AttachToPanelEvent();
        }

        class DetachFromPanelEvent : UnityEngine.UIElements.PanelChangedEventBase<UnityEngine.UIElements.DetachFromPanelEvent>
        {
            /*0x2a6afb0*/ DetachFromPanelEvent();
        }

        class InputEvent : UnityEngine.UIElements.EventBase<UnityEngine.UIElements.InputEvent>
        {
            /*0x80*/ string <previousData>k__BackingField;
            /*0x88*/ string <newData>k__BackingField;

            static /*0x2a6b070*/ UnityEngine.UIElements.InputEvent GetPooled(string previousData, string newData);
            /*0x2a6b0f4*/ InputEvent();
            /*0x2a6aff8*/ void set_previousData(string value);
            /*0x2a6b000*/ void set_newData(string value);
            /*0x2a6b008*/ void Init();
            /*0x2a6b060*/ void LocalInit();
        }

        interface INavigationEvent
        {
        }

        class NavigationEventBase<T> : UnityEngine.UIElements.EventBase<T>, UnityEngine.UIElements.INavigationEvent
        {
            NavigationEventBase();
            void Init();
            void LocalInit();
        }

        class NavigationMoveEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationMoveEvent>
        {
            /*0x7c*/ UnityEngine.UIElements.NavigationMoveEvent.Direction <direction>k__BackingField;
            /*0x80*/ UnityEngine.Vector2 <move>k__BackingField;

            static /*0x2a6b170*/ UnityEngine.UIElements.NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x2a6b1dc*/ UnityEngine.UIElements.NavigationMoveEvent GetPooled(UnityEngine.Vector2 moveVector);
            /*0x2a6b344*/ NavigationMoveEvent();
            /*0x2a6b1c4*/ UnityEngine.UIElements.NavigationMoveEvent.Direction get_direction();
            /*0x2a6b1cc*/ void set_direction(UnityEngine.UIElements.NavigationMoveEvent.Direction value);
            /*0x2a6b1d4*/ void set_move(UnityEngine.Vector2 value);
            /*0x2a6b2bc*/ void Init();

            enum Direction
            {
                None = 0,
                Left = 1,
                Up = 2,
                Right = 3,
                Down = 4,
            }
        }

        class NavigationTabEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationTabEvent>
        {
            /*0x7c*/ UnityEngine.UIElements.NavigationTabEvent.Direction <direction>k__BackingField;

            static /*0x2a6b3a4*/ UnityEngine.UIElements.NavigationTabEvent.Direction DetermineMoveDirection(int moveValue);
            static /*0x2a6b3c0*/ UnityEngine.UIElements.NavigationTabEvent GetPooled(int moveValue);
            /*0x2a6b49c*/ NavigationTabEvent();
            /*0x2a6b39c*/ void set_direction(UnityEngine.UIElements.NavigationTabEvent.Direction value);
            /*0x2a6b44c*/ void Init();

            enum Direction
            {
                None = 0,
                Next = 1,
                Previous = 2,
            }
        }

        class NavigationCancelEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationCancelEvent>
        {
            /*0x2a6b4f4*/ NavigationCancelEvent();
        }

        class NavigationSubmitEvent : UnityEngine.UIElements.NavigationEventBase<UnityEngine.UIElements.NavigationSubmitEvent>
        {
            /*0x2a6b53c*/ NavigationSubmitEvent();
        }

        class CommandEventDispatchingStrategy : UnityEngine.UIElements.IEventDispatchingStrategy
        {
            /*0x2a6b934*/ CommandEventDispatchingStrategy();
            /*0x2a6b584*/ bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            /*0x2a6b5d8*/ void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        enum PropagationPhase
        {
            None = 0,
            TrickleDown = 1,
            AtTarget = 2,
            DefaultActionAtTarget = 5,
            BubbleUp = 3,
            DefaultAction = 4,
        }

        interface IEventDispatchingStrategy
        {
            bool CanDispatchEvent(UnityEngine.UIElements.EventBase evt);
            void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class EventDispatchUtilities
        {
            static /*0x2a64050*/ void PropagateEvent(UnityEngine.UIElements.EventBase evt);
            static /*0x2a647a8*/ void PropagateToIMGUIContainer(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.EventBase evt);
            static /*0x2a6b93c*/ void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel);
        }

        class StyleComplexSelector
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector.PseudoStateData> s_PseudoStates;
            /*0x10*/ int m_Specificity;
            /*0x18*/ UnityEngine.UIElements.StyleRule <rule>k__BackingField;
            /*0x20*/ UnityEngine.UIElements.StyleSelector[] m_Selectors;
            /*0x28*/ int ruleIndex;
            /*0x30*/ UnityEngine.UIElements.StyleComplexSelector nextInTable;
            /*0x38*/ int orderInStyleSheet;

            /*0x2a6c24c*/ StyleComplexSelector();
            /*0x2a6bae4*/ int get_specificity();
            /*0x2a6baec*/ UnityEngine.UIElements.StyleRule get_rule();
            /*0x2a6baf4*/ void set_rule(UnityEngine.UIElements.StyleRule value);
            /*0x2a6bafc*/ UnityEngine.UIElements.StyleSelector[] get_selectors();
            /*0x2a6bb04*/ void set_selectors(UnityEngine.UIElements.StyleSelector[] value);
            /*0x2a6bb0c*/ void CachePseudoStateMasks();
            /*0x2a6c0dc*/ string ToString();

            struct PseudoStateData
            {
                /*0x10*/ UnityEngine.UIElements.PseudoStates state;
                /*0x14*/ bool negate;

                /*0x2a80b90*/ PseudoStateData(UnityEngine.UIElements.PseudoStates state, bool negate);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.StyleComplexSelector.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UIElements.StyleSelector, string> <>9__20_0;

                static /*0x2a80ba0*/ <>c();
                /*0x2a80c04*/ <>c();
                /*0x2a80c0c*/ string <ToString>b__20_0(UnityEngine.UIElements.StyleSelector x);
            }
        }

        class StyleProperty
        {
            /*0x10*/ string m_Name;
            /*0x18*/ int m_Line;
            /*0x20*/ UnityEngine.UIElements.StyleValueHandle[] m_Values;
            /*0x28*/ bool isCustomProperty;
            /*0x29*/ bool requireVariableResolve;

            /*0x2a80c3c*/ StyleProperty();
            /*0x2a80c2c*/ string get_name();
            /*0x2a80c34*/ UnityEngine.UIElements.StyleValueHandle[] get_values();
        }

        enum StyleValueType
        {
            Invalid = 0,
            Keyword = 1,
            Float = 2,
            Dimension = 3,
            Color = 4,
            ResourcePath = 5,
            AssetReference = 6,
            Enum = 7,
            Variable = 8,
            String = 9,
            Function = 10,
            CommaSeparator = 11,
            ScalableImage = 12,
            MissingAssetReference = 13,
        }

        struct StyleSelectorPart
        {
            /*0x10*/ string m_Value;
            /*0x18*/ UnityEngine.UIElements.StyleSelectorType m_Type;
            /*0x20*/ object tempData;

            static /*0x2a80d6c*/ UnityEngine.UIElements.StyleSelectorPart CreateClass(string className);
            static /*0x2a80d84*/ UnityEngine.UIElements.StyleSelectorPart CreateId(string Id);
            static /*0x2a80d9c*/ UnityEngine.UIElements.StyleSelectorPart CreatePredicate(object predicate);
            /*0x2a80c44*/ string get_value();
            /*0x2a80c4c*/ UnityEngine.UIElements.StyleSelectorType get_type();
            /*0x2a80c54*/ void set_type(UnityEngine.UIElements.StyleSelectorType value);
            /*0x2a80c5c*/ string ToString();
        }

        struct StyleVariable
        {
            /*0x10*/ string name;
            /*0x18*/ UnityEngine.UIElements.StyleSheet sheet;
            /*0x20*/ UnityEngine.UIElements.StyleValueHandle[] handles;

            /*0x2a80db4*/ StyleVariable(string name, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles);
            /*0x2a80dc0*/ int GetHashCode();
        }

        class StyleVariableContext
        {
            static /*0x0*/ UnityEngine.UIElements.StyleVariableContext none;
            /*0x10*/ int m_VariableHash;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleVariable> m_Variables;
            /*0x20*/ System.Collections.Generic.List<int> m_SortedHash;

            static /*0x2a81414*/ StyleVariableContext();
            /*0x2a8116c*/ StyleVariableContext();
            /*0x2a81234*/ StyleVariableContext(UnityEngine.UIElements.StyleVariableContext other);
            /*0x2a80e38*/ void Add(UnityEngine.UIElements.StyleVariable sv);
            /*0x2a80fd8*/ void AddInitialRange(UnityEngine.UIElements.StyleVariableContext other);
            /*0x2a810d0*/ void Clear();
            /*0x2a81320*/ bool TryFindVariable(string name, ref UnityEngine.UIElements.StyleVariable v);
            /*0x2a8140c*/ int GetVariableHash();
        }

        class StyleVariableResolver
        {
            static int kMaxResolves = 100;
            static /*0x0*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser;
            /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues;
            /*0x20*/ System.Collections.Generic.Stack<string> m_ResolvedVarStack;
            /*0x28*/ UnityEngine.UIElements.StyleProperty m_Property;
            /*0x30*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleVariableResolver.ResolveContext> m_ContextStack;
            /*0x38*/ UnityEngine.UIElements.StyleVariableResolver.ResolveContext m_CurrentContext;
            /*0x48*/ UnityEngine.UIElements.StyleVariableContext <variableContext>k__BackingField;

            static /*0x2a822b8*/ StyleVariableResolver();
            static /*0x2a817ac*/ void ParseVarFunction(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles, ref int index, ref int argCount, ref string variableName);
            /*0x2a82184*/ StyleVariableResolver();
            /*0x2a81474*/ UnityEngine.UIElements.StyleSheet get_currentSheet();
            /*0x2a8147c*/ UnityEngine.UIElements.StyleValueHandle[] get_currentHandles();
            /*0x2a81484*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues();
            /*0x2a8148c*/ UnityEngine.UIElements.StyleVariableContext get_variableContext();
            /*0x2a81494*/ void set_variableContext(UnityEngine.UIElements.StyleVariableContext value);
            /*0x2a8149c*/ void Init(UnityEngine.UIElements.StyleProperty property, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles);
            /*0x2a8154c*/ void PushContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles);
            /*0x2a815b8*/ void PopContext();
            /*0x2a81634*/ void AddValue(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a816e0*/ bool ResolveVarFunction(ref int index);
            /*0x2a8185c*/ UnityEngine.UIElements.StyleVariableResolver.Result ResolveVarFunction(ref int index, int argc, string varName);
            /*0x2a81ebc*/ bool ValidateResolvedValues();
            /*0x2a819b8*/ UnityEngine.UIElements.StyleVariableResolver.Result ResolveVariable(string variableName);
            /*0x2a81c38*/ UnityEngine.UIElements.StyleVariableResolver.Result ResolveFallback(ref int index);

            enum Result
            {
                Valid = 0,
                Invalid = 1,
                NotFound = 2,
            }

            struct ResolveContext
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ UnityEngine.UIElements.StyleValueHandle[] handles;
            }
        }

        enum StyleSelectorRelationship
        {
            None = 0,
            Child = 1,
            Descendent = 2,
        }

        class StyleSelector
        {
            /*0x10*/ UnityEngine.UIElements.StyleSelectorPart[] m_Parts;
            /*0x18*/ UnityEngine.UIElements.StyleSelectorRelationship m_PreviousRelationship;
            /*0x1c*/ int pseudoStateMask;
            /*0x20*/ int negatedPseudoStateMask;

            /*0x2a82490*/ StyleSelector();
            /*0x2a82330*/ UnityEngine.UIElements.StyleSelectorPart[] get_parts();
            /*0x2a82338*/ void set_parts(UnityEngine.UIElements.StyleSelectorPart[] value);
            /*0x2a82340*/ UnityEngine.UIElements.StyleSelectorRelationship get_previousRelationship();
            /*0x2a82348*/ void set_previousRelationship(UnityEngine.UIElements.StyleSelectorRelationship value);
            /*0x2a82350*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.StyleSelector.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UIElements.StyleSelectorPart, string> <>9__10_0;

                static /*0x2a824a0*/ <>c();
                /*0x2a82504*/ <>c();
                /*0x2a8250c*/ string <ToString>b__10_0(UnityEngine.UIElements.StyleSelectorPart p);
            }
        }

        class ThemeStyleSheet : UnityEngine.UIElements.StyleSheet
        {
            /*0x2a82694*/ ThemeStyleSheet();
            /*0x2a82514*/ void OnEnable();
        }

        enum StyleValueFunction
        {
            Unknown = 0,
            Var = 1,
            Env = 2,
            LinearGradient = 3,
        }

        class StyleValueFunctionExtension
        {
            static /*0x2a826f4*/ string ToUssString(UnityEngine.UIElements.StyleValueFunction svf);
        }

        class StyleRule
        {
            /*0x10*/ UnityEngine.UIElements.StyleProperty[] m_Properties;
            /*0x18*/ int line;
            /*0x1c*/ int customPropertiesCount;

            /*0x2a827f0*/ StyleRule();
            /*0x2a827e8*/ UnityEngine.UIElements.StyleProperty[] get_properties();
        }

        struct StyleValueHandle
        {
            /*0x10*/ UnityEngine.UIElements.StyleValueType m_ValueType;
            /*0x14*/ int valueIndex;

            /*0x2a81c30*/ UnityEngine.UIElements.StyleValueType get_valueType();
            /*0x2a827f8*/ void set_valueType(UnityEngine.UIElements.StyleValueType value);
        }

        class StyleSheet : UnityEngine.ScriptableObject
        {
            static /*0x0*/ string kCustomPropertyMarker;
            /*0x18*/ bool m_ImportedWithErrors;
            /*0x19*/ bool m_ImportedWithWarnings;
            /*0x20*/ UnityEngine.UIElements.StyleRule[] m_Rules;
            /*0x28*/ UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors;
            /*0x30*/ float[] floats;
            /*0x38*/ UnityEngine.UIElements.StyleSheets.Dimension[] dimensions;
            /*0x40*/ UnityEngine.Color[] colors;
            /*0x48*/ string[] strings;
            /*0x50*/ UnityEngine.Object[] assets;
            /*0x58*/ UnityEngine.UIElements.StyleSheet.ImportStruct[] imports;
            /*0x60*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_FlattenedImportedStyleSheets;
            /*0x68*/ int m_ContentHash;
            /*0x70*/ UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages;
            /*0x78*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector> orderedNameSelectors;
            /*0x80*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector> orderedTypeSelectors;
            /*0x88*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleComplexSelector> orderedClassSelectors;
            /*0x90*/ bool m_IsDefaultStyleSheet;

            static /*0x2a83b94*/ StyleSheet();
            static bool TryCheckAccess<T>(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle, ref T value);
            static T CheckAccess<T>(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle);
            static /*0x2a82f88*/ bool CustomStartsWith(string originalString, string pattern);
            /*0x2a826ec*/ StyleSheet();
            /*0x2a82800*/ bool get_importedWithErrors();
            /*0x2a82808*/ void set_importedWithErrors(bool value);
            /*0x2a82814*/ bool get_importedWithWarnings();
            /*0x2a8281c*/ void set_importedWithWarnings(bool value);
            /*0x2a82828*/ UnityEngine.UIElements.StyleRule[] get_rules();
            /*0x2a82830*/ void set_rules(UnityEngine.UIElements.StyleRule[] value);
            /*0x2a82d94*/ UnityEngine.UIElements.StyleComplexSelector[] get_complexSelectors();
            /*0x2a82d9c*/ void set_complexSelectors(UnityEngine.UIElements.StyleComplexSelector[] value);
            /*0x2a82da4*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports();
            /*0x2a82dac*/ int get_contentHash();
            /*0x2a82db4*/ void set_contentHash(int value);
            /*0x2a82dbc*/ bool get_isDefaultStyleSheet();
            /*0x2a82530*/ void set_isDefaultStyleSheet(bool value);
            /*0x2a82690*/ void OnEnable();
            /*0x2a82dc4*/ void FlattenImportedStyleSheetsRecursive();
            /*0x2a82e40*/ void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet sheet);
            /*0x2a82838*/ void SetupReferences();
            /*0x2a8304c*/ UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a8202c*/ float ReadFloat(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a83054*/ bool TryReadFloat(UnityEngine.UIElements.StyleValueHandle handle, ref float value);
            /*0x2a83148*/ UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a83238*/ bool TryReadDimension(UnityEngine.UIElements.StyleValueHandle handle, ref UnityEngine.UIElements.StyleSheets.Dimension value);
            /*0x2a83354*/ UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a833d8*/ bool TryReadColor(UnityEngine.UIElements.StyleValueHandle handle, ref UnityEngine.Color value);
            /*0x2a83464*/ string ReadString(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a834e8*/ bool TryReadString(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x2a83574*/ string ReadEnum(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a835f8*/ bool TryReadEnum(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x2a82100*/ string ReadVariable(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a83684*/ bool TryReadVariable(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x2a83710*/ string ReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a83794*/ bool TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle, ref string value);
            /*0x2a83820*/ UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a838a4*/ string ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a83928*/ bool TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle, ref UnityEngine.Object value);
            /*0x2a839b4*/ UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a839bc*/ string ReadFunctionName(UnityEngine.UIElements.StyleValueHandle handle);
            /*0x2a83b10*/ UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle handle);

            struct ImportStruct
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet styleSheet;
                /*0x18*/ string[] mediaQueries;
            }
        }

        enum StyleValueKeyword
        {
            Inherit = 0,
            Initial = 1,
            Auto = 2,
            Unset = 3,
            True = 4,
            False = 5,
            None = 6,
        }

        class StyleValueKeywordExtension
        {
            static /*0x2a83bf4*/ string ToUssString(UnityEngine.UIElements.StyleValueKeyword svk);
        }

        enum StyleSelectorType
        {
            Unknown = 0,
            Wildcard = 1,
            Type = 2,
            Class = 3,
            PseudoClass = 4,
            RecursivePseudoClass = 5,
            ID = 6,
            Predicate = 7,
        }

        struct StyleScale : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Scale>, System.IEquatable<UnityEngine.UIElements.StyleScale>
        {
            /*0x10*/ UnityEngine.UIElements.Scale m_Value;
            /*0x20*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a83d68*/ bool op_Equality(UnityEngine.UIElements.StyleScale lhs, UnityEngine.UIElements.StyleScale rhs);
            static /*0x2a83e2c*/ UnityEngine.UIElements.StyleScale op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a83d50*/ StyleScale(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a83d5c*/ StyleScale(UnityEngine.UIElements.Scale v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a83d14*/ UnityEngine.UIElements.Scale get_value();
            /*0x2a83d48*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a83e38*/ bool Equals(UnityEngine.UIElements.StyleScale other);
            /*0x2a83eac*/ bool Equals(object obj);
            /*0x2a83f7c*/ int GetHashCode();
            /*0x2a83ff0*/ string ToString();
        }

        struct FontDefinition : System.IEquatable<UnityEngine.UIElements.FontDefinition>
        {
            /*0x10*/ UnityEngine.Font m_Font;
            /*0x18*/ UnityEngine.TextCore.Text.FontAsset m_FontAsset;

            static /*0x2a84088*/ UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font f);
            static /*0x2a84090*/ UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset f);
            static /*0x2a8409c*/ UnityEngine.UIElements.FontDefinition FromObject(object obj);
            static /*0x2a8447c*/ bool op_Equality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right);
            static /*0x2a844a8*/ bool op_Inequality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right);
            /*0x2a84078*/ UnityEngine.Font get_font();
            /*0x2a84080*/ UnityEngine.TextCore.Text.FontAsset get_fontAsset();
            /*0x2a841b4*/ bool IsEmpty();
            /*0x2a8424c*/ string ToString();
            /*0x2a842dc*/ bool Equals(UnityEngine.UIElements.FontDefinition other);
            /*0x2a84324*/ bool Equals(object obj);
            /*0x2a8439c*/ int GetHashCode();
        }

        enum EasingMode
        {
            Ease = 0,
            EaseIn = 1,
            EaseOut = 2,
            EaseInOut = 3,
            Linear = 4,
            EaseInSine = 5,
            EaseOutSine = 6,
            EaseInOutSine = 7,
            EaseInCubic = 8,
            EaseOutCubic = 9,
            EaseInOutCubic = 10,
            EaseInCirc = 11,
            EaseOutCirc = 12,
            EaseInOutCirc = 13,
            EaseInElastic = 14,
            EaseOutElastic = 15,
            EaseInOutElastic = 16,
            EaseInBack = 17,
            EaseOutBack = 18,
            EaseInOutBack = 19,
            EaseInBounce = 20,
            EaseOutBounce = 21,
            EaseInOutBounce = 22,
        }

        struct EasingFunction : System.IEquatable<UnityEngine.UIElements.EasingFunction>
        {
            /*0x10*/ UnityEngine.UIElements.EasingMode m_Mode;

            static /*0x2a844e8*/ UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode easingMode);
            static /*0x2a844f0*/ bool op_Equality(UnityEngine.UIElements.EasingFunction lhs, UnityEngine.UIElements.EasingFunction rhs);
            /*0x2a844e0*/ EasingFunction(UnityEngine.UIElements.EasingMode mode);
            /*0x2a844d8*/ UnityEngine.UIElements.EasingMode get_mode();
            /*0x2a844fc*/ bool Equals(UnityEngine.UIElements.EasingFunction other);
            /*0x2a8450c*/ bool Equals(object obj);
            /*0x2a84584*/ string ToString();
            /*0x2a845ec*/ int GetHashCode();
        }

        struct ComputedTransitionProperty
        {
            /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId id;
            /*0x14*/ int durationMs;
            /*0x18*/ int delayMs;
            /*0x20*/ System.Func<float, float> easingCurve;
        }

        class ComputedTransitionUtils
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer;

            static /*0x2a86138*/ ComputedTransitionUtils();
            static /*0x2a845f4*/ void UpdateComputedTransitions(ref UnityEngine.UIElements.ComputedStyle computedStyle);
            static /*0x2a847fc*/ bool HasTransitionProperty(ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            static /*0x2a848c8*/ bool GetTransitionProperty(ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedTransitionProperty result);
            static /*0x2a84658*/ UnityEngine.UIElements.ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref UnityEngine.UIElements.ComputedStyle computedStyle);
            static /*0x2a84a04*/ int GetTransitionHashCode(ref UnityEngine.UIElements.ComputedStyle cs);
            static /*0x2a85148*/ bool SameTransitionProperty(ref UnityEngine.UIElements.ComputedStyle x, ref UnityEngine.UIElements.ComputedStyle y);
            static /*0x2a85288*/ bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b);
            static /*0x2a85374*/ bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b);
            static /*0x2a84ea0*/ void ComputeTransitionPropertyData(ref UnityEngine.UIElements.ComputedStyle computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData);
            static T GetWrappingTransitionData<T>(System.Collections.Generic.List<T> list, int i, T defaultValue);
            static /*0x2a8549c*/ int ConvertTransitionTime(UnityEngine.UIElements.TimeValue time);
            static /*0x2a85590*/ System.Func<float, float> ConvertTransitionFunction(UnityEngine.UIElements.EasingMode mode);

            class <>c
            {
                static /*0x0*/ UnityEngine.UIElements.ComputedTransitionUtils.<> <>9;
                static /*0x8*/ System.Func<float, float> <>9__12_0;
                static /*0x10*/ System.Func<float, float> <>9__12_1;
                static /*0x18*/ System.Func<float, float> <>9__12_2;
                static /*0x20*/ System.Func<float, float> <>9__12_3;
                static /*0x28*/ System.Func<float, float> <>9__12_4;
                static /*0x30*/ System.Func<float, float> <>9__12_5;
                static /*0x38*/ System.Func<float, float> <>9__12_6;
                static /*0x40*/ System.Func<float, float> <>9__12_7;
                static /*0x48*/ System.Func<float, float> <>9__12_8;
                static /*0x50*/ System.Func<float, float> <>9__12_9;
                static /*0x58*/ System.Func<float, float> <>9__12_10;
                static /*0x60*/ System.Func<float, float> <>9__12_11;
                static /*0x68*/ System.Func<float, float> <>9__12_12;
                static /*0x70*/ System.Func<float, float> <>9__12_13;
                static /*0x78*/ System.Func<float, float> <>9__12_14;
                static /*0x80*/ System.Func<float, float> <>9__12_15;
                static /*0x88*/ System.Func<float, float> <>9__12_16;
                static /*0x90*/ System.Func<float, float> <>9__12_17;
                static /*0x98*/ System.Func<float, float> <>9__12_18;
                static /*0xa0*/ System.Func<float, float> <>9__12_19;
                static /*0xa8*/ System.Func<float, float> <>9__12_20;
                static /*0xb0*/ System.Func<float, float> <>9__12_21;
                static /*0xb8*/ System.Func<float, float> <>9__12_22;

                static /*0x2a861c4*/ <>c();
                /*0x2a86228*/ <>c();
                /*0x2a86230*/ float <ConvertTransitionFunction>b__12_0(float t);
                /*0x2a86260*/ float <ConvertTransitionFunction>b__12_1(float t);
                /*0x2a86268*/ float <ConvertTransitionFunction>b__12_2(float t);
                /*0x2a86270*/ float <ConvertTransitionFunction>b__12_3(float t);
                /*0x2a86278*/ float <ConvertTransitionFunction>b__12_4(float t);
                /*0x2a86280*/ float <ConvertTransitionFunction>b__12_5(float t);
                /*0x2a86288*/ float <ConvertTransitionFunction>b__12_6(float t);
                /*0x2a86290*/ float <ConvertTransitionFunction>b__12_7(float t);
                /*0x2a86298*/ float <ConvertTransitionFunction>b__12_8(float t);
                /*0x2a862a0*/ float <ConvertTransitionFunction>b__12_9(float t);
                /*0x2a862a8*/ float <ConvertTransitionFunction>b__12_10(float t);
                /*0x2a862b0*/ float <ConvertTransitionFunction>b__12_11(float t);
                /*0x2a862b8*/ float <ConvertTransitionFunction>b__12_12(float t);
                /*0x2a862c0*/ float <ConvertTransitionFunction>b__12_13(float t);
                /*0x2a862c8*/ float <ConvertTransitionFunction>b__12_14(float t);
                /*0x2a862d0*/ float <ConvertTransitionFunction>b__12_15(float t);
                /*0x2a862d8*/ float <ConvertTransitionFunction>b__12_16(float t);
                /*0x2a862e0*/ float <ConvertTransitionFunction>b__12_17(float t);
                /*0x2a862e8*/ float <ConvertTransitionFunction>b__12_18(float t);
                /*0x2a862f0*/ float <ConvertTransitionFunction>b__12_19(float t);
                /*0x2a862f8*/ float <ConvertTransitionFunction>b__12_20(float t);
                /*0x2a86300*/ float <ConvertTransitionFunction>b__12_21(float t);
                /*0x2a86308*/ float <ConvertTransitionFunction>b__12_22(float t);
            }
        }

        struct StyleColor : UnityEngine.UIElements.IStyleValue<UnityEngine.Color>, System.IEquatable<UnityEngine.UIElements.StyleColor>
        {
            /*0x10*/ UnityEngine.Color m_Value;
            /*0x20*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a86360*/ bool op_Equality(UnityEngine.UIElements.StyleColor lhs, UnityEngine.UIElements.StyleColor rhs);
            static /*0x2a863c4*/ UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color v);
            /*0x2a86340*/ StyleColor(UnityEngine.Color v);
            /*0x2a86350*/ StyleColor(UnityEngine.Color v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a86310*/ UnityEngine.Color get_value();
            /*0x2a86338*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a863d4*/ bool Equals(UnityEngine.UIElements.StyleColor other);
            /*0x2a86438*/ bool Equals(object obj);
            /*0x2a864c8*/ int GetHashCode();
            /*0x2a86560*/ string ToString();
        }

        struct StyleTranslate : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Translate>, System.IEquatable<UnityEngine.UIElements.StyleTranslate>
        {
            /*0x10*/ UnityEngine.UIElements.Translate m_Value;
            /*0x28*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a86684*/ bool op_Equality(UnityEngine.UIElements.StyleTranslate lhs, UnityEngine.UIElements.StyleTranslate rhs);
            static /*0x2a86794*/ UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a867a4*/ UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.Translate v);
            /*0x2a86634*/ StyleTranslate(UnityEngine.UIElements.Translate v);
            /*0x2a86674*/ StyleTranslate(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8665c*/ StyleTranslate(UnityEngine.UIElements.Translate v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a865e8*/ UnityEngine.UIElements.Translate get_value();
            /*0x2a8662c*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a867bc*/ bool Equals(UnityEngine.UIElements.StyleTranslate other);
            /*0x2a86800*/ bool Equals(object obj);
            /*0x2a868a0*/ int GetHashCode();
            /*0x2a86938*/ string ToString();
        }

        struct StyleCursor : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Cursor>, System.IEquatable<UnityEngine.UIElements.StyleCursor>
        {
            /*0x10*/ UnityEngine.UIElements.Cursor m_Value;
            /*0x28*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a86a34*/ bool op_Equality(UnityEngine.UIElements.StyleCursor lhs, UnityEngine.UIElements.StyleCursor rhs);
            static /*0x2a86a94*/ UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a86a0c*/ StyleCursor(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a86a1c*/ StyleCursor(UnityEngine.UIElements.Cursor v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a869c0*/ UnityEngine.UIElements.Cursor get_value();
            /*0x2a86a04*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a86aa4*/ bool Equals(UnityEngine.UIElements.StyleCursor other);
            /*0x2a86b24*/ bool Equals(object obj);
            /*0x2a86bac*/ int GetHashCode();
            /*0x2a86bd4*/ string ToString();
        }

        struct Background : System.IEquatable<UnityEngine.UIElements.Background>
        {
            /*0x10*/ UnityEngine.Texture2D m_Texture;
            /*0x18*/ UnityEngine.Sprite m_Sprite;
            /*0x20*/ UnityEngine.RenderTexture m_RenderTexture;
            /*0x28*/ UnityEngine.UIElements.VectorImage m_VectorImage;

            static /*0x2a86e64*/ UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D t);
            static /*0x2a86e98*/ UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture rt);
            static /*0x2a86ecc*/ UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite s);
            static /*0x2a86f00*/ UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage vi);
            static /*0x2a86f34*/ UnityEngine.UIElements.Background FromObject(object obj);
            static /*0x2a8718c*/ bool op_Equality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs);
            static /*0x2a87294*/ bool op_Inequality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs);
            /*0x2a86c54*/ UnityEngine.Texture2D get_texture();
            /*0x2a86c5c*/ void set_texture(UnityEngine.Texture2D value);
            /*0x2a86cd8*/ UnityEngine.Sprite get_sprite();
            /*0x2a86ce0*/ void set_sprite(UnityEngine.Sprite value);
            /*0x2a86d5c*/ UnityEngine.RenderTexture get_renderTexture();
            /*0x2a86d64*/ void set_renderTexture(UnityEngine.RenderTexture value);
            /*0x2a86de0*/ UnityEngine.UIElements.VectorImage get_vectorImage();
            /*0x2a86de8*/ void set_vectorImage(UnityEngine.UIElements.VectorImage value);
            /*0x2a872cc*/ bool Equals(UnityEngine.UIElements.Background other);
            /*0x2a87300*/ bool Equals(object obj);
            /*0x2a87390*/ int GetHashCode();
            /*0x2a87428*/ string ToString();
        }

        struct StyleEnum<T> : UnityEngine.UIElements.IStyleValue<T>, System.IEquatable<UnityEngine.UIElements.StyleEnum<T>>
        {
            /*0x0*/ T m_Value;
            /*0x0*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static bool op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs);
            static bool op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs);
            static UnityEngine.UIElements.StyleEnum<T> op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v);
            StyleEnum(T v);
            StyleEnum(UnityEngine.UIElements.StyleKeyword keyword);
            StyleEnum(T v, UnityEngine.UIElements.StyleKeyword keyword);
            T get_value();
            UnityEngine.UIElements.StyleKeyword get_keyword();
            bool Equals(UnityEngine.UIElements.StyleEnum<T> other);
            bool Equals(object obj);
            int GetHashCode();
            string ToString();
        }

        struct Rotate : System.IEquatable<UnityEngine.UIElements.Rotate>
        {
            /*0x10*/ UnityEngine.UIElements.Angle m_Angle;
            /*0x18*/ UnityEngine.Vector3 m_Axis;
            /*0x24*/ bool m_IsNone;

            static /*0x2a875c0*/ UnityEngine.UIElements.Rotate Initial();
            static /*0x2a87654*/ UnityEngine.UIElements.Rotate None();
            static /*0x2a876d4*/ bool op_Equality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs);
            static /*0x2a87780*/ bool op_Inequality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs);
            /*0x2a87560*/ Rotate(UnityEngine.UIElements.Angle angle);
            /*0x2a876c4*/ UnityEngine.UIElements.Angle get_angle();
            /*0x2a876cc*/ void set_angle(UnityEngine.UIElements.Angle value);
            /*0x2a877c8*/ bool Equals(UnityEngine.UIElements.Rotate other);
            /*0x2a8780c*/ bool Equals(object obj);
            /*0x2a878ac*/ int GetHashCode();
            /*0x2a8796c*/ string ToString();
            /*0x2a87bac*/ UnityEngine.Quaternion ToQuaternion();
        }

        struct ComputedStyle
        {
            /*0x10*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.InheritedData> inheritedData;
            /*0x18*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.LayoutData> layoutData;
            /*0x20*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.RareData> rareData;
            /*0x28*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransformData> transformData;
            /*0x30*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransitionData> transitionData;
            /*0x38*/ UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.VisualData> visualData;
            /*0x40*/ UnityEngine.Yoga.YogaNode yogaNode;
            /*0x48*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties;
            /*0x50*/ long matchingRulesHash;
            /*0x58*/ float dpiScaling;
            /*0x60*/ UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions;

            static /*0x2a6ede8*/ UnityEngine.UIElements.VersionChangeType CompareChanges(ref UnityEngine.UIElements.ComputedStyle x, ref UnityEngine.UIElements.ComputedStyle y);
            static /*0x2a6f3ec*/ bool StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleTranslate translate, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            static /*0x2a700b8*/ UnityEngine.UIElements.ComputedStyle Create(ref UnityEngine.UIElements.ComputedStyle parentStyle);
            static /*0x2a70228*/ UnityEngine.UIElements.ComputedStyle CreateInitial();
            static /*0x2a751e4*/ bool StartAnimation(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle oldStyle, ref UnityEngine.UIElements.ComputedStyle newStyle, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            static /*0x2a79628*/ bool StartAnimationAllProperty(UnityEngine.UIElements.VisualElement element, ref UnityEngine.UIElements.ComputedStyle oldStyle, ref UnityEngine.UIElements.ComputedStyle newStyle, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            static /*0x2a7d094*/ bool StartAnimationInline(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StyleValue sv, int durationMs, int delayMs, System.Func<float, float> easingCurve);
            /*0x2a6c254*/ int get_customPropertiesCount();
            /*0x2a6c2ac*/ bool get_hasTransition();
            /*0x2a6c2cc*/ void FinalizeApply(ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a6c41c*/ void SyncWithLayout(UnityEngine.Yoga.YogaNode targetNode);
            /*0x2a6d2a0*/ bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a6d3a8*/ bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleKeyword keyword, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a6eaa4*/ void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader);
            /*0x2a6eb50*/ void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader);
            /*0x2a6ec40*/ void ApplyAllPropertyInitial();
            /*0x2a6ede0*/ void ResetComputedTransitions();
            /*0x2a6d110*/ UnityEngine.UIElements.Align get_alignContent();
            /*0x2a6d160*/ UnityEngine.UIElements.Align get_alignItems();
            /*0x2a6cf30*/ UnityEngine.UIElements.Align get_alignSelf();
            /*0x2a6f604*/ UnityEngine.Color get_backgroundColor();
            /*0x2a6f658*/ UnityEngine.UIElements.Background get_backgroundImage();
            /*0x2a6f6b8*/ UnityEngine.Color get_borderBottomColor();
            /*0x2a6f0d0*/ UnityEngine.UIElements.Length get_borderBottomLeftRadius();
            /*0x2a6f120*/ UnityEngine.UIElements.Length get_borderBottomRightRadius();
            /*0x2a6cda0*/ float get_borderBottomWidth();
            /*0x2a6f70c*/ UnityEngine.Color get_borderLeftColor();
            /*0x2a6ccb0*/ float get_borderLeftWidth();
            /*0x2a6f760*/ UnityEngine.Color get_borderRightColor();
            /*0x2a6cd50*/ float get_borderRightWidth();
            /*0x2a6f7b4*/ UnityEngine.Color get_borderTopColor();
            /*0x2a6f170*/ UnityEngine.UIElements.Length get_borderTopLeftRadius();
            /*0x2a6f1c0*/ UnityEngine.UIElements.Length get_borderTopRightRadius();
            /*0x2a6cd00*/ float get_borderTopWidth();
            /*0x2a6c9e0*/ UnityEngine.UIElements.Length get_bottom();
            /*0x2a6f808*/ UnityEngine.Color get_color();
            /*0x2a6f85c*/ UnityEngine.UIElements.Cursor get_cursor();
            /*0x2a6d250*/ UnityEngine.UIElements.DisplayStyle get_display();
            /*0x2a6c8a0*/ UnityEngine.UIElements.Length get_flexBasis();
            /*0x2a6d0c0*/ UnityEngine.UIElements.FlexDirection get_flexDirection();
            /*0x2a6c800*/ float get_flexGrow();
            /*0x2a6c850*/ float get_flexShrink();
            /*0x2a6d200*/ UnityEngine.UIElements.Wrap get_flexWrap();
            /*0x2a6c3cc*/ UnityEngine.UIElements.Length get_fontSize();
            /*0x2a6ce40*/ UnityEngine.UIElements.Length get_height();
            /*0x2a6d1b0*/ UnityEngine.UIElements.Justify get_justifyContent();
            /*0x2a6c8f0*/ UnityEngine.UIElements.Length get_left();
            /*0x2a6f8c4*/ UnityEngine.UIElements.Length get_letterSpacing();
            /*0x2a6cb20*/ UnityEngine.UIElements.Length get_marginBottom();
            /*0x2a6ca30*/ UnityEngine.UIElements.Length get_marginLeft();
            /*0x2a6cad0*/ UnityEngine.UIElements.Length get_marginRight();
            /*0x2a6ca80*/ UnityEngine.UIElements.Length get_marginTop();
            /*0x2a6cfd0*/ UnityEngine.UIElements.Length get_maxHeight();
            /*0x2a6cf80*/ UnityEngine.UIElements.Length get_maxWidth();
            /*0x2a6d070*/ UnityEngine.UIElements.Length get_minHeight();
            /*0x2a6d020*/ UnityEngine.UIElements.Length get_minWidth();
            /*0x2a6f210*/ float get_opacity();
            /*0x2a6cee0*/ UnityEngine.UIElements.OverflowInternal get_overflow();
            /*0x2a6cc60*/ UnityEngine.UIElements.Length get_paddingBottom();
            /*0x2a6cb70*/ UnityEngine.UIElements.Length get_paddingLeft();
            /*0x2a6cc10*/ UnityEngine.UIElements.Length get_paddingRight();
            /*0x2a6cbc0*/ UnityEngine.UIElements.Length get_paddingTop();
            /*0x2a6ce90*/ UnityEngine.UIElements.Position get_position();
            /*0x2a6c990*/ UnityEngine.UIElements.Length get_right();
            /*0x2a6f384*/ UnityEngine.UIElements.Rotate get_rotate();
            /*0x2a6f330*/ UnityEngine.UIElements.Scale get_scale();
            /*0x2a6f914*/ UnityEngine.UIElements.TextOverflow get_textOverflow();
            /*0x2a6f964*/ UnityEngine.UIElements.TextShadow get_textShadow();
            /*0x2a6c940*/ UnityEngine.UIElements.Length get_top();
            /*0x2a6f260*/ UnityEngine.UIElements.TransformOrigin get_transformOrigin();
            /*0x2a6f9cc*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay();
            /*0x2a6fa1c*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration();
            /*0x2a6fa6c*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty();
            /*0x2a6fabc*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction();
            /*0x2a6f2c8*/ UnityEngine.UIElements.Translate get_translate();
            /*0x2a6fb0c*/ UnityEngine.Color get_unityBackgroundImageTintColor();
            /*0x2a6fb60*/ UnityEngine.ScaleMode get_unityBackgroundScaleMode();
            /*0x2a6fbb0*/ UnityEngine.Font get_unityFont();
            /*0x2a6fc00*/ UnityEngine.UIElements.FontDefinition get_unityFontDefinition();
            /*0x2a6fc54*/ UnityEngine.FontStyle get_unityFontStyleAndWeight();
            /*0x2a6fca4*/ UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox();
            /*0x2a6fcf4*/ UnityEngine.UIElements.Length get_unityParagraphSpacing();
            /*0x2a6fd44*/ int get_unitySliceBottom();
            /*0x2a6fd94*/ int get_unitySliceLeft();
            /*0x2a6fde4*/ int get_unitySliceRight();
            /*0x2a6fe34*/ int get_unitySliceTop();
            /*0x2a6fe84*/ UnityEngine.TextAnchor get_unityTextAlign();
            /*0x2a6fed4*/ UnityEngine.Color get_unityTextOutlineColor();
            /*0x2a6ff28*/ float get_unityTextOutlineWidth();
            /*0x2a6ff78*/ UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition();
            /*0x2a6ffc8*/ UnityEngine.UIElements.Visibility get_visibility();
            /*0x2a70018*/ UnityEngine.UIElements.WhiteSpace get_whiteSpace();
            /*0x2a6cdf0*/ UnityEngine.UIElements.Length get_width();
            /*0x2a70068*/ UnityEngine.UIElements.Length get_wordSpacing();
            /*0x2a70360*/ UnityEngine.UIElements.ComputedStyle Acquire();
            /*0x2a70478*/ void Release();
            /*0x2a6eca0*/ void CopyFrom(ref UnityEngine.UIElements.ComputedStyle other);
            /*0x2a70578*/ void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a7175c*/ void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a722e0*/ void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged sv, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a72688*/ void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor);
            /*0x2a726f0*/ void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow st);
            /*0x2a72760*/ void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle other);
            /*0x2a73620*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length newValue);
            /*0x2a73d40*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, float newValue);
            /*0x2a74010*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, int newValue);
            /*0x2a74524*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color newValue);
            /*0x2a747b8*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background newValue);
            /*0x2a748f8*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font newValue);
            /*0x2a74a34*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition newValue);
            /*0x2a74b7c*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow newValue);
            /*0x2a74ccc*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate newValue);
            /*0x2a74e14*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin newValue);
            /*0x2a74f5c*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate newValue);
            /*0x2a7509c*/ void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale newValue);
            /*0x2a8078c*/ void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin st);
            /*0x2a807f4*/ void ApplyStyleTranslate(UnityEngine.UIElements.Translate translateValue);
            /*0x2a8085c*/ void ApplyStyleRotate(UnityEngine.UIElements.Rotate rotateValue);
            /*0x2a808c4*/ void ApplyStyleScale(UnityEngine.UIElements.Scale scaleValue);
            /*0x2a6d340*/ void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader);
            /*0x2a6d3cc*/ void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x2a6d37c*/ void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle parentStyle);
            /*0x2a80924*/ void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle parentStyle);
        }

        struct StyleFloat : UnityEngine.UIElements.IStyleValue<float>, System.IEquatable<UnityEngine.UIElements.StyleFloat>
        {
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a87c90*/ bool op_Equality(UnityEngine.UIElements.StyleFloat lhs, UnityEngine.UIElements.StyleFloat rhs);
            static /*0x2a87cb8*/ UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a87cc0*/ UnityEngine.UIElements.StyleFloat op_Implicit(float v);
            /*0x2a87c70*/ StyleFloat(float v);
            /*0x2a87c88*/ StyleFloat(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a87c7c*/ StyleFloat(float v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a87c50*/ float get_value();
            /*0x2a87c68*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a87cc8*/ bool Equals(UnityEngine.UIElements.StyleFloat other);
            /*0x2a87cf0*/ bool Equals(object obj);
            /*0x2a87d7c*/ int GetHashCode();
            /*0x2a87da4*/ string ToString();
        }

        struct StyleLength : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Length>, System.IEquatable<UnityEngine.UIElements.StyleLength>
        {
            /*0x10*/ UnityEngine.UIElements.Length m_Value;
            /*0x18*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a87edc*/ bool op_Equality(UnityEngine.UIElements.StyleLength lhs, UnityEngine.UIElements.StyleLength rhs);
            static /*0x2a87f3c*/ UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a87f48*/ UnityEngine.UIElements.StyleLength op_Implicit(float v);
            /*0x2a87e3c*/ StyleLength(float v);
            /*0x2a87eb0*/ StyleLength(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a87e90*/ StyleLength(UnityEngine.UIElements.Length v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a87e1c*/ UnityEngine.UIElements.Length get_value();
            /*0x2a87e34*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a87f70*/ bool Equals(UnityEngine.UIElements.StyleLength other);
            /*0x2a87fb0*/ bool Equals(object obj);
            /*0x2a88054*/ int GetHashCode();
            /*0x2a880ac*/ string ToString();
        }

        interface IStyleValue<T>
        {
            T get_value();
            UnityEngine.UIElements.StyleKeyword get_keyword();
        }

        enum StyleKeyword
        {
            Undefined = 0,
            Null = 1,
            Auto = 2,
            None = 3,
            Initial = 4,
        }

        class StyleValueExtensions
        {
            static string DebugString<T>(UnityEngine.UIElements.IStyleValue<T> styleValue);
            static /*0x2a88134*/ UnityEngine.Yoga.YogaValue ToYogaValue(UnityEngine.UIElements.Length length);
            static /*0x2a88280*/ UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a88398*/ UnityEngine.UIElements.Rotate ToRotate(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a88514*/ UnityEngine.UIElements.Scale ToScale(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a88630*/ UnityEngine.UIElements.Translate ToTranslate(UnityEngine.UIElements.StyleKeyword keyword);
            static /*0x2a8879c*/ UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleLength styleLength);
            static void CopyFrom<T>(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other);
        }

        struct Translate : System.IEquatable<UnityEngine.UIElements.Translate>
        {
            /*0x10*/ UnityEngine.UIElements.Length m_X;
            /*0x18*/ UnityEngine.UIElements.Length m_Y;
            /*0x20*/ float m_Z;
            /*0x24*/ bool m_isNone;

            static /*0x2a88780*/ UnityEngine.UIElements.Translate None();
            static /*0x2a86718*/ bool op_Equality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs);
            static /*0x2a887e4*/ bool op_Inequality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs);
            /*0x2a887bc*/ Translate(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, float z);
            /*0x2a887cc*/ UnityEngine.UIElements.Length get_x();
            /*0x2a887d4*/ UnityEngine.UIElements.Length get_y();
            /*0x2a887dc*/ float get_z();
            /*0x2a8885c*/ bool Equals(UnityEngine.UIElements.Translate other);
            /*0x2a888d8*/ bool Equals(object obj);
            /*0x2a868c4*/ int GetHashCode();
            /*0x2a88968*/ string ToString();
        }

        enum AngleUnit
        {
            Degree = 0,
            Gradian = 1,
            Radian = 2,
            Turn = 3,
        }

        struct Angle : System.IEquatable<UnityEngine.UIElements.Angle>
        {
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.Angle.Unit m_Unit;

            static /*0x2a88cf4*/ UnityEngine.UIElements.Angle None();
            static /*0x2a8764c*/ UnityEngine.UIElements.Angle op_Implicit(float value);
            static /*0x2a87758*/ bool op_Equality(UnityEngine.UIElements.Angle lhs, UnityEngine.UIElements.Angle rhs);
            /*0x2a88d10*/ Angle(float value, UnityEngine.UIElements.AngleUnit unit);
            /*0x2a88cfc*/ Angle(float value, UnityEngine.UIElements.Angle.Unit unit);
            /*0x2a88d08*/ float get_value();
            /*0x2a87bcc*/ float ToDegrees();
            /*0x2a88d1c*/ bool Equals(UnityEngine.UIElements.Angle other);
            /*0x2a88d44*/ bool Equals(object obj);
            /*0x2a87944*/ int GetHashCode();
            /*0x2a879d4*/ string ToString();

            enum Unit
            {
                Degree = 0,
                Gradian = 1,
                Radian = 2,
                Turn = 3,
                None = 4,
            }
        }

        struct CustomStyleProperty<T> : System.IEquatable<UnityEngine.UIElements.CustomStyleProperty<T>>
        {
            /*0x0*/ string <name>k__BackingField;

            CustomStyleProperty(string propertyName);
            string get_name();
            void set_name(string value);
            bool Equals(object obj);
            bool Equals(UnityEngine.UIElements.CustomStyleProperty<T> other);
            int GetHashCode();
        }

        interface ICustomStyle
        {
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<float> property, ref float value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<int> property, ref int value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, ref UnityEngine.Color value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, ref UnityEngine.Texture2D value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, ref UnityEngine.Sprite value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, ref UnityEngine.UIElements.VectorImage value);
            bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<string> property, ref string value);
        }

        class StyleValueCollection
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values;

            /*0x2a892dc*/ StyleValueCollection();
            /*0x2a88dd0*/ UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x2a89004*/ UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x2a8905c*/ UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x2a88e44*/ bool TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.StyleSheets.StyleValue value);
            /*0x2a890e0*/ void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value);
        }

        class InlineStyleAccess : UnityEngine.UIElements.StyleValueCollection, UnityEngine.UIElements.IStyle
        {
            static /*0x0*/ UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged;
            /*0x20*/ UnityEngine.UIElements.VisualElement <ve>k__BackingField;
            /*0x28*/ bool m_HasInlineCursor;
            /*0x30*/ UnityEngine.UIElements.StyleCursor m_InlineCursor;
            /*0x50*/ bool m_HasInlineTextShadow;
            /*0x54*/ UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow;
            /*0x74*/ bool m_HasInlineTransformOrigin;
            /*0x78*/ UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin;
            /*0x90*/ bool m_HasInlineTranslate;
            /*0x94*/ UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation;
            /*0xb0*/ bool m_HasInlineRotate;
            /*0xb4*/ UnityEngine.UIElements.StyleRotate m_InlineRotateOperation;
            /*0xd0*/ bool m_HasInlineScale;
            /*0xd4*/ UnityEngine.UIElements.StyleScale m_InlineScale;
            /*0xe8*/ UnityEngine.UIElements.InlineStyleAccess.InlineRule m_InlineRule;

            static /*0x2a8c590*/ InlineStyleAccess();
            /*0x2a89368*/ InlineStyleAccess(UnityEngine.UIElements.VisualElement ve);
            /*0x2a89358*/ UnityEngine.UIElements.VisualElement get_ve();
            /*0x2a89360*/ void set_ve(UnityEngine.UIElements.VisualElement value);
            /*0x2a8938c*/ void Finalize();
            /*0x2a894d4*/ void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule);
            /*0x2a89f7c*/ bool IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x2a89568*/ void ApplyInlineStyles(ref UnityEngine.UIElements.ComputedStyle computedStyle);
            /*0x2a8a364*/ UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.get_cursor();
            /*0x2a8a3d8*/ UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow();
            /*0x2a8a46c*/ UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin();
            /*0x2a8a4e8*/ UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.get_translate();
            /*0x2a8a568*/ void UnityEngine.UIElements.IStyle.set_translate(UnityEngine.UIElements.StyleTranslate value);
            /*0x2a8a6f8*/ UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.get_rotate();
            /*0x2a8a788*/ UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.get_scale();
            /*0x2a8a7e4*/ bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleLength inlineValue);
            /*0x2a8ace0*/ bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleFloat inlineValue);
            /*0x2a8adf0*/ bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleColor inlineValue);
            bool SetStyleValue<T>(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue);
            /*0x2a8a5bc*/ bool SetInlineTranslate(UnityEngine.UIElements.StyleTranslate inlineValue);
            /*0x2a8af2c*/ void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate translate);
            /*0x2a8aa00*/ void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value);
            /*0x2a8a910*/ bool RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            /*0x2a8b160*/ void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.ComputedStyle newStyle);
            /*0x2a8a3b8*/ bool TryGetInlineCursor(ref UnityEngine.UIElements.StyleCursor value);
            /*0x2a8a430*/ bool TryGetInlineTextShadow(ref UnityEngine.UIElements.StyleTextShadow value);
            /*0x2a8a4b4*/ bool TryGetInlineTransformOrigin(ref UnityEngine.UIElements.StyleTransformOrigin value);
            /*0x2a8a538*/ bool TryGetInlineTranslate(ref UnityEngine.UIElements.StyleTranslate value);
            /*0x2a8a748*/ bool TryGetInlineRotate(ref UnityEngine.UIElements.StyleRotate value);
            /*0x2a8a7bc*/ bool TryGetInlineScale(ref UnityEngine.UIElements.StyleScale value);
            /*0x2a8b380*/ void UnityEngine.UIElements.IStyle.set_backgroundColor(UnityEngine.UIElements.StyleColor value);
            /*0x2a8b3d8*/ void UnityEngine.UIElements.IStyle.set_borderBottomColor(UnityEngine.UIElements.StyleColor value);
            /*0x2a8b434*/ void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value);
            /*0x2a8b47c*/ void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value);
            /*0x2a8b4c4*/ void UnityEngine.UIElements.IStyle.set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8b530*/ void UnityEngine.UIElements.IStyle.set_borderLeftColor(UnityEngine.UIElements.StyleColor value);
            /*0x2a8b58c*/ void UnityEngine.UIElements.IStyle.set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8b5f8*/ void UnityEngine.UIElements.IStyle.set_borderRightColor(UnityEngine.UIElements.StyleColor value);
            /*0x2a8b654*/ void UnityEngine.UIElements.IStyle.set_borderRightWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8b6c0*/ void UnityEngine.UIElements.IStyle.set_borderTopColor(UnityEngine.UIElements.StyleColor value);
            /*0x2a8b718*/ void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value);
            /*0x2a8b760*/ void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value);
            /*0x2a8b7a8*/ void UnityEngine.UIElements.IStyle.set_borderTopWidth(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8b814*/ void UnityEngine.UIElements.IStyle.set_bottom(UnityEngine.UIElements.StyleLength value);
            /*0x2a8b890*/ void UnityEngine.UIElements.IStyle.set_color(UnityEngine.UIElements.StyleColor value);
            /*0x2a8b8e8*/ UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display();
            /*0x2a8b980*/ void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value);
            /*0x2a8ba3c*/ void UnityEngine.UIElements.IStyle.set_flexBasis(UnityEngine.UIElements.StyleLength value);
            /*0x2a8bab8*/ void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value);
            /*0x2a8bb74*/ void UnityEngine.UIElements.IStyle.set_flexGrow(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8bbe0*/ void UnityEngine.UIElements.IStyle.set_flexShrink(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8bc4c*/ void UnityEngine.UIElements.IStyle.set_fontSize(UnityEngine.UIElements.StyleLength value);
            /*0x2a8bc90*/ UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_height();
            /*0x2a8bcac*/ void UnityEngine.UIElements.IStyle.set_height(UnityEngine.UIElements.StyleLength value);
            /*0x2a8bd28*/ void UnityEngine.UIElements.IStyle.set_left(UnityEngine.UIElements.StyleLength value);
            /*0x2a8bda4*/ void UnityEngine.UIElements.IStyle.set_marginBottom(UnityEngine.UIElements.StyleLength value);
            /*0x2a8be20*/ void UnityEngine.UIElements.IStyle.set_marginLeft(UnityEngine.UIElements.StyleLength value);
            /*0x2a8be9c*/ void UnityEngine.UIElements.IStyle.set_marginRight(UnityEngine.UIElements.StyleLength value);
            /*0x2a8bf18*/ void UnityEngine.UIElements.IStyle.set_marginTop(UnityEngine.UIElements.StyleLength value);
            /*0x2a8bf94*/ void UnityEngine.UIElements.IStyle.set_minWidth(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c010*/ void UnityEngine.UIElements.IStyle.set_opacity(UnityEngine.UIElements.StyleFloat value);
            /*0x2a8c050*/ void UnityEngine.UIElements.IStyle.set_paddingBottom(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c0cc*/ void UnityEngine.UIElements.IStyle.set_paddingLeft(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c148*/ void UnityEngine.UIElements.IStyle.set_paddingRight(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c1c4*/ UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_paddingTop();
            /*0x2a8c1e0*/ void UnityEngine.UIElements.IStyle.set_paddingTop(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c25c*/ void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value);
            /*0x2a8c318*/ void UnityEngine.UIElements.IStyle.set_right(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c394*/ void UnityEngine.UIElements.IStyle.set_top(UnityEngine.UIElements.StyleLength value);
            /*0x2a8c410*/ void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value);
            /*0x2a8c46c*/ void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value);
            /*0x2a8c4f8*/ UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_width();
            /*0x2a8c514*/ void UnityEngine.UIElements.IStyle.set_width(UnityEngine.UIElements.StyleLength value);

            struct InlineRule
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ UnityEngine.UIElements.StyleRule rule;
                /*0x20*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds;
            }
        }

        enum LengthUnit
        {
            Pixel = 0,
            Percent = 1,
        }

        struct Length : System.IEquatable<UnityEngine.UIElements.Length>
        {
            static float k_MaxValue = 8388608;
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.Length.Unit m_Unit;

            static /*0x2a8c608*/ UnityEngine.UIElements.Length Percent(float value);
            static /*0x2a88388*/ UnityEngine.UIElements.Length Auto();
            static /*0x2a88390*/ UnityEngine.UIElements.Length None();
            static /*0x2a8c6bc*/ UnityEngine.UIElements.Length op_Implicit(float value);
            static /*0x2a87f14*/ bool op_Equality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs);
            static /*0x2a8c6e0*/ bool op_Inequality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs);
            /*0x2a8c694*/ Length(float value);
            /*0x2a87e68*/ Length(float value, UnityEngine.UIElements.LengthUnit unit);
            /*0x2a8c630*/ Length(float value, UnityEngine.UIElements.Length.Unit unit);
            /*0x2a8c658*/ float get_value();
            /*0x2a8c660*/ void set_value(float value);
            /*0x2a8c684*/ UnityEngine.UIElements.LengthUnit get_unit();
            /*0x2a8c68c*/ void set_unit(UnityEngine.UIElements.LengthUnit value);
            /*0x2a87ebc*/ bool IsAuto();
            /*0x2a87ecc*/ bool IsNone();
            /*0x2a8c708*/ bool Equals(UnityEngine.UIElements.Length other);
            /*0x2a8c730*/ bool Equals(object obj);
            /*0x2a88084*/ int GetHashCode();
            /*0x2a88b34*/ string ToString();

            enum Unit
            {
                Pixel = 0,
                Percent = 1,
                Auto = 2,
                None = 3,
            }
        }

        struct StyleDataRef<T> : System.IEquatable<UnityEngine.UIElements.StyleDataRef<T>>
        {
            /*0x0*/ UnityEngine.UIElements.StyleDataRef.RefCounted<T> m_Ref;

            static UnityEngine.UIElements.StyleDataRef<T> Create();
            static bool op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs);
            UnityEngine.UIElements.StyleDataRef<T> Acquire();
            void Release();
            void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other);
            ref T Read();
            ref T Write();
            int GetHashCode();
            bool Equals(UnityEngine.UIElements.StyleDataRef<T> other);
            bool Equals(object obj);

            class RefCounted<T>
            {
                static /*0x0*/ uint m_NextId;
                /*0x0*/ int m_RefCount;
                /*0x0*/ uint m_Id;
                /*0x0*/ T value;

                static RefCounted();
                RefCounted();
                int get_refCount();
                void Acquire();
                void Release();
                UnityEngine.UIElements.StyleDataRef.RefCounted<T> Copy();
            }
        }

        struct StyleTransformOrigin : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.TransformOrigin>, System.IEquatable<UnityEngine.UIElements.StyleTransformOrigin>
        {
            /*0x10*/ UnityEngine.UIElements.TransformOrigin m_Value;
            /*0x24*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a8c7e8*/ bool op_Equality(UnityEngine.UIElements.StyleTransformOrigin lhs, UnityEngine.UIElements.StyleTransformOrigin rhs);
            static /*0x2a8a4dc*/ UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8c7c4*/ StyleTransformOrigin(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8c7d0*/ StyleTransformOrigin(UnityEngine.UIElements.TransformOrigin v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8a2e0*/ UnityEngine.UIElements.TransformOrigin get_value();
            /*0x2a8c7bc*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a8c8c4*/ bool Equals(UnityEngine.UIElements.StyleTransformOrigin other);
            /*0x2a8c950*/ bool Equals(object obj);
            /*0x2a8c9e0*/ int GetHashCode();
            /*0x2a8ca78*/ string ToString();
        }

        struct TransformOrigin : System.IEquatable<UnityEngine.UIElements.TransformOrigin>
        {
            /*0x10*/ UnityEngine.UIElements.Length m_X;
            /*0x18*/ UnityEngine.UIElements.Length m_Y;
            /*0x20*/ float m_Z;

            static /*0x2a8cb0c*/ UnityEngine.UIElements.TransformOrigin Initial();
            static /*0x2a8c864*/ bool op_Equality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs);
            static /*0x2a8cb3c*/ bool op_Inequality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs);
            /*0x2a8cb00*/ TransformOrigin(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, float z);
            /*0x2a8cb24*/ UnityEngine.UIElements.Length get_x();
            /*0x2a8cb2c*/ UnityEngine.UIElements.Length get_y();
            /*0x2a8cb34*/ float get_z();
            /*0x2a8cba8*/ bool Equals(UnityEngine.UIElements.TransformOrigin other);
            /*0x2a8cc14*/ bool Equals(object obj);
            /*0x2a8ca04*/ int GetHashCode();
            /*0x2a8cce4*/ string ToString();
        }

        struct Scale : System.IEquatable<UnityEngine.UIElements.Scale>
        {
            /*0x10*/ UnityEngine.Vector3 m_Scale;
            /*0x1c*/ bool m_IsNone;

            static /*0x2a8cec4*/ UnityEngine.UIElements.Scale Initial();
            static /*0x2a88618*/ UnityEngine.UIElements.Scale None();
            static /*0x2a83dd8*/ bool op_Equality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs);
            static /*0x2a8cf14*/ bool op_Inequality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs);
            /*0x2a8ceb0*/ Scale(UnityEngine.Vector3 scale);
            /*0x2a8cf08*/ UnityEngine.Vector3 get_value();
            /*0x2a8cf68*/ bool Equals(UnityEngine.UIElements.Scale other);
            /*0x2a8cfb4*/ bool Equals(object obj);
            /*0x2a83fa0*/ int GetHashCode();
            /*0x2a8d070*/ string ToString();
        }

        struct StyleTextShadow : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.TextShadow>, System.IEquatable<UnityEngine.UIElements.StyleTextShadow>
        {
            /*0x10*/ UnityEngine.UIElements.StyleKeyword m_Keyword;
            /*0x14*/ UnityEngine.UIElements.TextShadow m_Value;

            static /*0x2a8d0b0*/ bool op_Equality(UnityEngine.UIElements.StyleTextShadow lhs, UnityEngine.UIElements.StyleTextShadow rhs);
            static /*0x2a8a454*/ UnityEngine.UIElements.StyleTextShadow op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8d078*/ StyleTextShadow(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8d090*/ StyleTextShadow(UnityEngine.UIElements.TextShadow v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8a294*/ UnityEngine.UIElements.TextShadow get_value();
            /*0x2a8a28c*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a8d118*/ bool Equals(UnityEngine.UIElements.StyleTextShadow other);
            /*0x2a8d14c*/ bool Equals(object obj);
            /*0x2a8d1dc*/ int GetHashCode();
            /*0x2a8d224*/ string ToString();
        }

        struct StyleRotate : UnityEngine.UIElements.IStyleValue<UnityEngine.UIElements.Rotate>, System.IEquatable<UnityEngine.UIElements.StyleRotate>
        {
            /*0x10*/ UnityEngine.UIElements.Rotate m_Value;
            /*0x28*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a8d2d4*/ bool op_Equality(UnityEngine.UIElements.StyleRotate lhs, UnityEngine.UIElements.StyleRotate rhs);
            static /*0x2a8a778*/ UnityEngine.UIElements.StyleRotate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8d2ac*/ StyleRotate(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8d2bc*/ StyleRotate(UnityEngine.UIElements.Rotate v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8a320*/ UnityEngine.UIElements.Rotate get_value();
            /*0x2a8d2a4*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a8d330*/ bool Equals(UnityEngine.UIElements.StyleRotate other);
            /*0x2a8d3ac*/ bool Equals(object obj);
            /*0x2a8d43c*/ int GetHashCode();
            /*0x2a8d460*/ string ToString();
        }

        enum TimeUnit
        {
            Second = 0,
            Millisecond = 1,
        }

        struct TimeValue : System.IEquatable<UnityEngine.UIElements.TimeValue>
        {
            /*0x10*/ float m_Value;
            /*0x14*/ UnityEngine.UIElements.TimeUnit m_Unit;

            static /*0x2a8d504*/ UnityEngine.UIElements.TimeValue op_Implicit(float value);
            static /*0x2a8d50c*/ bool op_Equality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs);
            static /*0x2a85468*/ bool op_Inequality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs);
            /*0x2a85490*/ TimeValue(float value);
            /*0x2a8d4f8*/ TimeValue(float value, UnityEngine.UIElements.TimeUnit unit);
            /*0x2a8d4e8*/ float get_value();
            /*0x2a8d4f0*/ UnityEngine.UIElements.TimeUnit get_unit();
            /*0x2a8d534*/ bool Equals(UnityEngine.UIElements.TimeValue other);
            /*0x2a8d55c*/ bool Equals(object obj);
            /*0x2a85120*/ int GetHashCode();
            /*0x2a8d5e8*/ string ToString();
        }

        struct StyleInt : UnityEngine.UIElements.IStyleValue<int>, System.IEquatable<UnityEngine.UIElements.StyleInt>
        {
            /*0x10*/ int m_Value;
            /*0x14*/ UnityEngine.UIElements.StyleKeyword m_Keyword;

            static /*0x2a8d6e8*/ bool op_Equality(UnityEngine.UIElements.StyleInt lhs, UnityEngine.UIElements.StyleInt rhs);
            static /*0x2a890d8*/ UnityEngine.UIElements.StyleInt op_Implicit(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8d6e0*/ StyleInt(UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a890d0*/ StyleInt(int v, UnityEngine.UIElements.StyleKeyword keyword);
            /*0x2a8b960*/ int get_value();
            /*0x2a8b978*/ UnityEngine.UIElements.StyleKeyword get_keyword();
            /*0x2a8d708*/ bool Equals(UnityEngine.UIElements.StyleInt other);
            /*0x2a8d728*/ bool Equals(object obj);
            /*0x2a8d7ac*/ int GetHashCode();
            /*0x2a8d7c0*/ string ToString();
        }

        class UIRAtlasAllocator : System.IDisposable
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerTryAllocate;
            /*0x10*/ int <maxAtlasSize>k__BackingField;
            /*0x14*/ int <maxImageWidth>k__BackingField;
            /*0x18*/ int <maxImageHeight>k__BackingField;
            /*0x1c*/ int <virtualWidth>k__BackingField;
            /*0x20*/ int <virtualHeight>k__BackingField;
            /*0x24*/ int <physicalWidth>k__BackingField;
            /*0x28*/ int <physicalHeight>k__BackingField;
            /*0x30*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode m_FirstUnpartitionedArea;
            /*0x38*/ UnityEngine.UIElements.UIRAtlasAllocator.Row[] m_OpenRows;
            /*0x40*/ int m_1SidePadding;
            /*0x44*/ int m_2SidePadding;
            /*0x48*/ bool <disposed>k__BackingField;

            static /*0x2a8e6c8*/ UIRAtlasAllocator();
            static /*0x2a8dab0*/ int GetLog2OfNextPower(int n);
            /*0x2a8dbe0*/ UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding);
            /*0x2a8d838*/ int get_maxAtlasSize();
            /*0x2a8d840*/ int get_maxImageWidth();
            /*0x2a8d848*/ int get_maxImageHeight();
            /*0x2a8d850*/ int get_virtualWidth();
            /*0x2a8d858*/ void set_virtualWidth(int value);
            /*0x2a8d860*/ int get_virtualHeight();
            /*0x2a8d868*/ void set_virtualHeight(int value);
            /*0x2a8d870*/ int get_physicalWidth();
            /*0x2a8d878*/ void set_physicalWidth(int value);
            /*0x2a8d880*/ int get_physicalHeight();
            /*0x2a8d888*/ void set_physicalHeight(int value);
            /*0x2a8d890*/ bool get_disposed();
            /*0x2a8d898*/ void set_disposed(bool value);
            /*0x2a8d8a4*/ void Dispose();
            /*0x2a8d910*/ void Dispose(bool disposing);
            /*0x2a8df50*/ bool TryAllocate(int width, int height, ref UnityEngine.RectInt location);
            /*0x2a8e330*/ bool TryPartitionArea(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth);
            /*0x2a8de44*/ void BuildAreas();

            class Row
            {
                static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.Row> s_Pool;
                /*0x10*/ int <offsetX>k__BackingField;
                /*0x14*/ int <offsetY>k__BackingField;
                /*0x18*/ int <width>k__BackingField;
                /*0x1c*/ int <height>k__BackingField;
                /*0x20*/ int Cursor;

                static /*0x2a8e77c*/ Row();
                static /*0x2a8e548*/ UnityEngine.UIElements.UIRAtlasAllocator.Row Acquire(int offsetX, int offsetY, int width, int height);
                /*0x2a8e774*/ Row();
                /*0x2a8e73c*/ int get_offsetX();
                /*0x2a8e744*/ void set_offsetX(int value);
                /*0x2a8e74c*/ int get_offsetY();
                /*0x2a8e754*/ void set_offsetY(int value);
                /*0x2a8e75c*/ int get_width();
                /*0x2a8e764*/ void set_width(int value);
                /*0x2a8e76c*/ void set_height(int value);
                /*0x2a8d9a0*/ void Release();
            }

            class AreaNode
            {
                static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.AreaNode> s_Pool;
                /*0x10*/ UnityEngine.RectInt rect;
                /*0x20*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous;
                /*0x28*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode next;

                static /*0x2a8e814*/ AreaNode();
                static /*0x2a8ddac*/ UnityEngine.UIElements.UIRAtlasAllocator.AreaNode Acquire(UnityEngine.RectInt rect);
                /*0x2a8e80c*/ AreaNode();
                /*0x2a8da30*/ void Release();
                /*0x2a8e5f4*/ void RemoveFromChain();
                /*0x2a8e61c*/ void AddAfter(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous);
            }
        }

        class UIRRepaintUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            /*0x20*/ UnityEngine.UIElements.BaseVisualElementPanel attachedPanel;
            /*0x28*/ UnityEngine.UIElements.UIR.RenderChain renderChain;
            /*0x30*/ bool <drawStats>k__BackingField;
            /*0x31*/ bool <breakBatches>k__BackingField;
            /*0x32*/ bool <disposed>k__BackingField;

            static /*0x2a8ec84*/ UIRRepaintUpdater();
            static /*0x2a8ed90*/ void OnGraphicsResourcesRecreate(bool recreate);
            /*0x2a8e8a4*/ UIRRepaintUpdater();
            /*0x2a8e934*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x2a8e98c*/ bool get_drawStats();
            /*0x2a8e994*/ bool get_breakBatches();
            /*0x2a8e99c*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x2a8ea94*/ void Update();
            /*0x2a8ec0c*/ UnityEngine.UIElements.UIR.RenderChain CreateRenderChain();
            /*0x2a8efb0*/ void OnPanelChanged(UnityEngine.UIElements.BaseVisualElementPanel obj);
            /*0x2a8f16c*/ void AttachToPanel();
            /*0x2a8efc8*/ void DetachFromPanel();
            /*0x2a8eb50*/ void InitRenderChain();
            /*0x2a8ef60*/ void DestroyRenderChain();
            /*0x2a8f738*/ void OnPanelAtlasChanged();
            /*0x2a8f73c*/ void OnPanelHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType);
            /*0x2a8f360*/ void OnPanelStandardShaderChanged();
            /*0x2a8f504*/ void OnPanelStandardWorldSpaceShaderChanged();
            /*0x2a8f6a8*/ void ResetAllElementsDataRecursive(UnityEngine.UIElements.VisualElement ve);
            /*0x2a8f774*/ bool get_disposed();
            /*0x2a8f77c*/ void set_disposed(bool value);
            /*0x2a8f788*/ void Dispose(bool disposing);
        }

        class UIRUtility
        {
            static /*0x0*/ string k_DefaultShaderName;
            static /*0x8*/ string k_DefaultWorldSpaceShaderName;

            static /*0x2a8fcbc*/ UIRUtility();
            static /*0x2a8f7b4*/ bool ShapeWindingIsClockwise(int maskDepth, int stencilRef);
            static /*0x2a8f840*/ bool IsRoundRect(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a8fa44*/ bool IsVectorImageBackground(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a8fad4*/ bool IsElementSelfHidden(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a8fb94*/ void Destroy(UnityEngine.Object obj);
            static /*0x2a8fc3c*/ int GetPrevPow2(int n);
            static /*0x2a8fc70*/ int GetNextPow2(int n);
            static /*0x2a8fc8c*/ int GetNextPow2Exp(int n);
        }

        class UIRLayoutUpdater : UnityEngine.UIElements.BaseVisualTreeUpdater
        {
            static /*0x0*/ string s_Description;
            static /*0x8*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;

            static /*0x2a908f0*/ UIRLayoutUpdater();
            /*0x2a908e8*/ UIRLayoutUpdater();
            /*0x2a8fd4c*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x2a8fda4*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x2a8fdec*/ void Update();
            /*0x2a900d8*/ void UpdateSubTree(UnityEngine.UIElements.VisualElement ve, int currentLayoutPass, bool isDisplayed);
        }

        struct Vertex
        {
            static /*0x0*/ float nearZ;
            /*0x10*/ UnityEngine.Vector3 position;
            /*0x1c*/ UnityEngine.Color32 tint;
            /*0x20*/ UnityEngine.Vector2 uv;
            /*0x28*/ UnityEngine.Color32 xformClipPages;
            /*0x2c*/ UnityEngine.Color32 ids;
            /*0x30*/ UnityEngine.Color32 flags;
            /*0x34*/ UnityEngine.Color32 opacityColorPages;
            /*0x38*/ UnityEngine.Vector4 circle;
            /*0x48*/ float textureId;
        }

        class MeshWriteData
        {
            /*0x10*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices;
            /*0x20*/ Unity.Collections.NativeSlice<ushort> m_Indices;
            /*0x30*/ UnityEngine.Rect m_UVRegion;
            /*0x40*/ int currentIndex;
            /*0x44*/ int currentVertex;

            /*0x2a9097c*/ MeshWriteData();
            /*0x2a90984*/ int get_vertexCount();
            /*0x2a909cc*/ int get_indexCount();
            /*0x2a90a14*/ UnityEngine.Rect get_uvRegion();
            /*0x2a90a20*/ void SetNextVertex(UnityEngine.UIElements.Vertex vertex);
            /*0x2a90abc*/ void SetNextIndex(ushort index);
            /*0x2a90b20*/ void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices);
            /*0x2a90bf8*/ void SetAllIndices(ushort[] indices);
            /*0x2a90cd0*/ void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<ushort> indices);
            /*0x2a90d1c*/ void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<ushort> indices, UnityEngine.Rect uvRegion);
        }

        struct ColorPage
        {
            /*0x10*/ bool isValid;
            /*0x14*/ UnityEngine.Color32 pageAndID;

            static /*0x2a90d34*/ UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.BMPAlloc alloc);
        }

        class MeshGenerationContextUtils
        {
            static /*0x2a90d94*/ void Rectangle(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
            static /*0x2a90e94*/ void Text(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
            static /*0x2a90fc8*/ UnityEngine.Vector2 ConvertBorderRadiusPercentToPoints(UnityEngine.Vector2 borderRectSize, UnityEngine.UIElements.Length length);
            static /*0x2a91004*/ void GetVisualElementRadii(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.Vector2 topLeft, ref UnityEngine.Vector2 bottomLeft, ref UnityEngine.Vector2 topRight, ref UnityEngine.Vector2 bottomRight);
            static /*0x2a912a0*/ void AdjustBackgroundSizeForBorders(UnityEngine.UIElements.VisualElement visualElement, ref UnityEngine.Rect rect);

            struct BorderParams
            {
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ UnityEngine.Color playmodeTintColor;
                /*0x30*/ UnityEngine.Color leftColor;
                /*0x40*/ UnityEngine.Color topColor;
                /*0x50*/ UnityEngine.Color rightColor;
                /*0x60*/ UnityEngine.Color bottomColor;
                /*0x70*/ float leftWidth;
                /*0x74*/ float topWidth;
                /*0x78*/ float rightWidth;
                /*0x7c*/ float bottomWidth;
                /*0x80*/ UnityEngine.Vector2 topLeftRadius;
                /*0x88*/ UnityEngine.Vector2 topRightRadius;
                /*0x90*/ UnityEngine.Vector2 bottomRightRadius;
                /*0x98*/ UnityEngine.Vector2 bottomLeftRadius;
                /*0xa0*/ UnityEngine.Material material;
                /*0xa8*/ UnityEngine.UIElements.ColorPage leftColorPage;
                /*0xb0*/ UnityEngine.UIElements.ColorPage topColorPage;
                /*0xb8*/ UnityEngine.UIElements.ColorPage rightColorPage;
                /*0xc0*/ UnityEngine.UIElements.ColorPage bottomColorPage;
            }

            struct RectangleParams
            {
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ UnityEngine.Rect uv;
                /*0x30*/ UnityEngine.Color color;
                /*0x40*/ UnityEngine.Texture texture;
                /*0x48*/ UnityEngine.Sprite sprite;
                /*0x50*/ UnityEngine.UIElements.VectorImage vectorImage;
                /*0x58*/ UnityEngine.Material material;
                /*0x60*/ UnityEngine.ScaleMode scaleMode;
                /*0x64*/ UnityEngine.Color playmodeTintColor;
                /*0x74*/ UnityEngine.Vector2 topLeftRadius;
                /*0x7c*/ UnityEngine.Vector2 topRightRadius;
                /*0x84*/ UnityEngine.Vector2 bottomRightRadius;
                /*0x8c*/ UnityEngine.Vector2 bottomLeftRadius;
                /*0x94*/ int leftSlice;
                /*0x98*/ int topSlice;
                /*0x9c*/ int rightSlice;
                /*0xa0*/ int bottomSlice;
                /*0xa4*/ float sliceScale;
                /*0xa8*/ UnityEngine.Rect spriteGeomRect;
                /*0xb8*/ UnityEngine.UIElements.ColorPage colorPage;
                /*0xc0*/ UnityEngine.UIElements.MeshGenerationContext.MeshFlags meshFlags;

                static /*0x2a916f4*/ void AdjustUVsForScaleMode(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, ref UnityEngine.Rect rectOut, ref UnityEngine.Rect uvOut);
                static /*0x2a91a18*/ void AdjustSpriteUVsForScaleMode(UnityEngine.Rect containerRect, UnityEngine.Rect srcRect, UnityEngine.Rect spriteGeomRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, ref UnityEngine.Rect rectOut, ref UnityEngine.Rect uvOut);
                static /*0x2a92174*/ UnityEngine.Rect RectIntersection(UnityEngine.Rect a, UnityEngine.Rect b);
                static /*0x2a92294*/ UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite sprite);
                static /*0x2a9236c*/ UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite sprite);
                static /*0x2a92444*/ UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect uv, UnityEngine.SpritePackingRotation rotation);
                static /*0x2a92570*/ UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext);
                static /*0x2a926dc*/ UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeSprite(UnityEngine.Rect containerRect, UnityEngine.Rect subRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext, bool hasRadius, ref UnityEngine.Vector4 slices);
                static /*0x2a92ebc*/ UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeVectorTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.UIElements.VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext);
                /*0x2a92fd8*/ bool HasRadius(float epsilon);
            }

            struct TextParams
            {
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ string text;
                /*0x28*/ UnityEngine.Font font;
                /*0x30*/ UnityEngine.UIElements.FontDefinition fontDefinition;
                /*0x40*/ int fontSize;
                /*0x44*/ UnityEngine.UIElements.Length letterSpacing;
                /*0x4c*/ UnityEngine.UIElements.Length wordSpacing;
                /*0x54*/ UnityEngine.UIElements.Length paragraphSpacing;
                /*0x5c*/ UnityEngine.FontStyle fontStyle;
                /*0x60*/ UnityEngine.Color fontColor;
                /*0x70*/ UnityEngine.TextAnchor anchor;
                /*0x74*/ bool wordWrap;
                /*0x78*/ float wordWrapWidth;
                /*0x7c*/ bool richText;
                /*0x80*/ UnityEngine.Color playmodeTintColor;
                /*0x90*/ UnityEngine.UIElements.TextOverflow textOverflow;
                /*0x94*/ UnityEngine.UIElements.TextOverflowPosition textOverflowPosition;
                /*0x98*/ UnityEngine.UIElements.OverflowInternal overflow;
                /*0xa0*/ UnityEngine.UIElements.IPanel panel;

                static /*0x2a932ec*/ UnityEngine.UIElements.MeshGenerationContextUtils.TextParams MakeStyleBased(UnityEngine.UIElements.VisualElement ve, string text);
                static /*0x2a93694*/ UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, float scaling);
                /*0x2a9304c*/ int GetHashCode();
            }
        }

        class MeshGenerationContext
        {
            /*0x10*/ UnityEngine.UIElements.IStylePainter painter;

            /*0x2a93768*/ MeshGenerationContext(UnityEngine.UIElements.IStylePainter painter);

            enum MeshFlags
            {
                None = 0,
                UVisDisplacement = 1,
                SkipDynamicAtlas = 2,
            }
        }

        struct TextureId
        {
            static /*0x0*/ UnityEngine.UIElements.TextureId invalid;
            /*0x10*/ int m_Index;

            static /*0x2a938f0*/ TextureId();
            static /*0x2a93880*/ bool op_Equality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right);
            static /*0x2a9388c*/ bool op_Inequality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right);
            /*0x2a93790*/ TextureId(int index);
            /*0x2a9379c*/ int get_index();
            /*0x2a937a8*/ float ConvertToGpu();
            /*0x2a937b8*/ bool Equals(object obj);
            /*0x2a93860*/ int GetHashCode();
        }

        class TextureRegistry
        {
            static int maxTextures = 2048;
            static /*0x0*/ UnityEngine.UIElements.TextureRegistry <instance>k__BackingField;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.TextureRegistry.TextureInfo> m_Textures;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.UIElements.TextureId> m_TextureToId;
            /*0x20*/ System.Collections.Generic.Stack<UnityEngine.UIElements.TextureId> m_FreeIds;

            static /*0x2a94330*/ TextureRegistry();
            static /*0x2a93938*/ UnityEngine.UIElements.TextureRegistry get_instance();
            /*0x2a94224*/ TextureRegistry();
            /*0x2a93990*/ UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId id);
            /*0x2a93acc*/ UnityEngine.UIElements.TextureId AllocAndAcquireDynamic();
            /*0x2a93d48*/ void UpdateDynamic(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture);
            /*0x2a93ae8*/ UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture texture, bool dynamic);
            /*0x2a93ef4*/ UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture tex);
            /*0x2a94034*/ void Release(UnityEngine.UIElements.TextureId id);

            struct TextureInfo
            {
                /*0x10*/ UnityEngine.Texture texture;
                /*0x18*/ bool dynamic;
                /*0x1c*/ int refCount;
            }
        }

        class DynamicAtlasPage : System.IDisposable
        {
            static /*0x0*/ int s_TextureCounter;
            /*0x10*/ UnityEngine.UIElements.TextureId <textureId>k__BackingField;
            /*0x18*/ UnityEngine.RenderTexture <atlas>k__BackingField;
            /*0x20*/ UnityEngine.RenderTextureFormat <format>k__BackingField;
            /*0x24*/ UnityEngine.FilterMode <filterMode>k__BackingField;
            /*0x28*/ UnityEngine.Vector2Int <minSize>k__BackingField;
            /*0x30*/ UnityEngine.Vector2Int <maxSize>k__BackingField;
            /*0x38*/ int m_1Padding;
            /*0x3c*/ int m_2Padding;
            /*0x40*/ UnityEngine.UIElements.UIR.Allocator2D m_Allocator;
            /*0x48*/ UnityEngine.UIElements.UIR.TextureBlitter m_Blitter;
            /*0x50*/ UnityEngine.Vector2Int m_CurrentSize;
            /*0x58*/ bool <disposed>k__BackingField;

            /*0x2a943c0*/ DynamicAtlasPage(UnityEngine.RenderTextureFormat format, UnityEngine.FilterMode filterMode, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize);
            /*0x2a94390*/ UnityEngine.UIElements.TextureId get_textureId();
            /*0x2a94398*/ void set_textureId(UnityEngine.UIElements.TextureId value);
            /*0x2a943a0*/ UnityEngine.RenderTexture get_atlas();
            /*0x2a943a8*/ void set_atlas(UnityEngine.RenderTexture value);
            /*0x2a943b0*/ UnityEngine.RenderTextureFormat get_format();
            /*0x2a943b8*/ UnityEngine.FilterMode get_filterMode();
            /*0x2a945c8*/ bool get_disposed();
            /*0x2a945d0*/ void set_disposed(bool value);
            /*0x2a945dc*/ void Dispose();
            /*0x2a94648*/ void Dispose(bool disposing);
            /*0x2a94888*/ bool TryAdd(UnityEngine.Texture2D image, ref UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc, ref UnityEngine.RectInt rect);
            /*0x2a94a6c*/ void Update(UnityEngine.Texture2D image, UnityEngine.RectInt rect);
            /*0x2a94dac*/ void Remove(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc);
            /*0x2a94ea8*/ void Commit();
            /*0x2a94ee8*/ void UpdateAtlasTexture();
            /*0x2a95354*/ UnityEngine.RenderTexture CreateAtlasTexture();
        }

        interface IBindingRequest
        {
            void Bind(UnityEngine.UIElements.VisualElement element);
        }

        class VisualTreeBindingsUpdater : UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater
        {
            static /*0x0*/ UnityEngine.PropertyName s_BindingRequestObjectVEPropertyName;
            static /*0x4*/ UnityEngine.PropertyName s_AdditionalBindingObjectVEPropertyName;
            static /*0x8*/ string s_Description;
            static /*0x10*/ Unity.Profiling.ProfilerMarker s_ProfilerMarker;
            static /*0x18*/ Unity.Profiling.ProfilerMarker s_ProfilerBindingRequestsMarker;
            static /*0x20*/ Unity.Profiling.ProfilerMarker s_MarkerUpdate;
            static /*0x28*/ Unity.Profiling.ProfilerMarker s_MarkerPoll;
            static /*0x30*/ bool <disableBindingsThrottling>k__BackingField;
            /*0x38*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsWithBindings;
            /*0x40*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToAdd;
            /*0x48*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToRemove;
            /*0x50*/ long m_LastUpdateTime;
            /*0x58*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToBind;
            /*0x60*/ System.Collections.Generic.Dictionary<object, object> <temporaryObjectCache>k__BackingField;
            /*0x68*/ System.Collections.Generic.List<UnityEngine.UIElements.IBinding> updatedBindings;

            static /*0x2a96b2c*/ VisualTreeBindingsUpdater();
            static /*0x2a95700*/ UnityEngine.UIElements.IBinding GetAdditionalBinding(UnityEngine.UIElements.VisualElement ve);
            static /*0x2a95bc4*/ long CurrentTime();
            /*0x2a969cc*/ VisualTreeBindingsUpdater();
            /*0x2a95570*/ Unity.Profiling.ProfilerMarker get_profilerMarker();
            /*0x2a955c8*/ UnityEngine.UIElements.IBinding GetBindingObjectFromElement(UnityEngine.UIElements.VisualElement ve);
            /*0x2a95788*/ void StartTracking(UnityEngine.UIElements.VisualElement ve);
            /*0x2a95808*/ void StopTracking(UnityEngine.UIElements.VisualElement ve);
            /*0x2a95888*/ System.Collections.Generic.Dictionary<object, object> get_temporaryObjectCache();
            /*0x2a95890*/ void StartTrackingRecursive(UnityEngine.UIElements.VisualElement ve);
            /*0x2a959a8*/ void StopTrackingRecursive(UnityEngine.UIElements.VisualElement ve);
            /*0x2a95ab4*/ void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType);
            /*0x2a95bac*/ void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type);
            /*0x2a95c14*/ void PerformTrackingOperations();
            /*0x2a95e98*/ void Update();
            /*0x2a96498*/ void UpdateBindings();
        }

        interface ITreeViewItem
        {
            int get_id();
            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> get_children();
            bool get_hasChildren();
        }

        class InternalTreeView : UnityEngine.UIElements.VisualElement
        {
            static /*0x0*/ string s_ListViewName;
            static /*0x8*/ string s_ItemToggleName;
            static /*0x10*/ string s_ItemIndentsContainerName;
            static /*0x18*/ string s_ItemIndentName;
            static /*0x20*/ string s_ItemContentContainerName;
            static /*0x28*/ string itemUssClassName;
            /*0x3b0*/ System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;
            /*0x3b8*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onItemsChosen;
            /*0x3c0*/ System.Action<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>> onSelectionChange;
            /*0x3c8*/ System.Collections.Generic.List<UnityEngine.UIElements.ITreeViewItem> m_SelectedItems;
            /*0x3d0*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> m_BindItem;
            /*0x3d8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> <unbindItem>k__BackingField;
            /*0x3e0*/ System.Collections.Generic.IList<UnityEngine.UIElements.ITreeViewItem> m_RootItems;
            /*0x3e8*/ System.Collections.Generic.List<int> m_ExpandedItemIds;
            /*0x3f0*/ System.Collections.Generic.List<UnityEngine.UIElements.InternalTreeView.TreeViewItemWrapper> m_ItemWrappers;
            /*0x3f8*/ UnityEngine.UIElements.ListView m_ListView;
            /*0x400*/ UnityEngine.UIElements.ScrollView m_ScrollView;

            static /*0x2a99e40*/ InternalTreeView();
            static /*0x2a973c4*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> GetAllItems(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems);
            /*0x2a96d48*/ InternalTreeView();
            /*0x2a96cc8*/ System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ITreeViewItem> get_unbindItem();
            /*0x2a96cd0*/ void set_itemHeight(int value);
            /*0x2a96cf0*/ void set_showBorder(bool value);
            /*0x2a96d10*/ void set_selectionType(UnityEngine.UIElements.SelectionType value);
            /*0x2a96d2c*/ void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value);
            /*0x2a9729c*/ void RefreshItems();
            /*0x2a97364*/ void Rebuild();
            /*0x2a97388*/ void OnViewDataReady();
            /*0x2a9746c*/ void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt);
            /*0x2a97348*/ void ListViewRefresh();
            /*0x2a97b18*/ void OnItemsChosen(System.Collections.Generic.IEnumerable<object> chosenItems);
            /*0x2a97f38*/ void OnSelectionChange(System.Collections.Generic.IEnumerable<object> selectedListItems);
            /*0x2a9838c*/ void OnTreeViewMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x2a983c4*/ void OnItemMouseUp(UnityEngine.UIElements.MouseUpEvent evt);
            /*0x2a98bc0*/ UnityEngine.UIElements.VisualElement MakeTreeItem();
            /*0x2a990a0*/ void UnbindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x2a991dc*/ void BindTreeItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x2a99538*/ int GetItemId(int index);
            /*0x2a97528*/ bool IsExpandedByIndex(int index);
            /*0x2a978cc*/ void CollapseItemByIndex(int index);
            /*0x2a975c4*/ void ExpandItemByIndex(int index);
            /*0x2a99b6c*/ void ToggleExpandedState(UnityEngine.UIElements.ChangeEvent<bool> evt);
            /*0x2a9964c*/ void CreateWrappers(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> treeViewItems, int depth, ref System.Collections.Generic.List<UnityEngine.UIElements.InternalTreeView.TreeViewItemWrapper> wrappers);
            /*0x2a972c0*/ void RegenerateWrappers();
            /*0x2a99cf0*/ void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e);

            class UxmlFactory : UnityEngine.UIElements.UxmlFactory<UnityEngine.UIElements.InternalTreeView, UnityEngine.UIElements.InternalTreeView.UxmlTraits>
            {
                /*0x2a99f4c*/ UxmlFactory();
            }

            class UxmlTraits : UnityEngine.UIElements.VisualElement.UxmlTraits
            {
                /*0x70*/ UnityEngine.UIElements.UxmlIntAttributeDescription m_ItemHeight;
                /*0x78*/ UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;
                /*0x80*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;
                /*0x88*/ UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

                /*0x2a9a1f4*/ UxmlTraits();
                /*0x2a99f94*/ void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc);
            }

            struct TreeViewItemWrapper
            {
                /*0x10*/ int depth;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem item;

                /*0x2a995ac*/ int get_id();
            }

            class <GetAllItems>d__64 : System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.UIElements.ITreeViewItem <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> rootItems;
                /*0x30*/ System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem> <>3__rootItems;
                /*0x38*/ System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>> <iteratorStack>5__1;
                /*0x40*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> <currentIterator>5__2;
                /*0x48*/ bool <hasNext>5__3;
                /*0x50*/ UnityEngine.UIElements.ITreeViewItem <currentItem>5__4;

                /*0x2a97428*/ <GetAllItems>d__64(int <>1__state);
                /*0x2a9a400*/ void System.IDisposable.Dispose();
                /*0x2a9a404*/ bool MoveNext();
                /*0x2a9a7fc*/ UnityEngine.UIElements.ITreeViewItem System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem>.get_Current();
                /*0x2a9a804*/ void System.Collections.IEnumerator.Reset();
                /*0x2a9a844*/ object System.Collections.IEnumerator.get_Current();
                /*0x2a9a84c*/ System.Collections.Generic.IEnumerator<UnityEngine.UIElements.ITreeViewItem> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ITreeViewItem>.GetEnumerator();
                /*0x2a9a8ec*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        struct EventDebuggerLogCall : System.IDisposable
        {
            /*0x2a9a8f0*/ EventDebuggerLogCall(System.Delegate callback, UnityEngine.UIElements.EventBase evt);
            /*0x2a9a8f4*/ void Dispose();
        }

        struct EventDebuggerLogIMGUICall : System.IDisposable
        {
            /*0x2a9a8f8*/ EventDebuggerLogIMGUICall(UnityEngine.UIElements.EventBase evt);
            /*0x2a9a8fc*/ void Dispose();
        }

        struct EventDebuggerLogExecuteDefaultAction : System.IDisposable
        {
            /*0x2a9a900*/ EventDebuggerLogExecuteDefaultAction(UnityEngine.UIElements.EventBase evt);
            /*0x2a9a904*/ void Dispose();
        }

        class EventDebugger
        {
            static /*0x2a9a908*/ void LogPropagationPaths(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths paths);
        }

        interface IStyleDataGroup<T>
        {
            T Copy();
            void CopyFrom(ref T other);
        }

        struct InheritedData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.InheritedData>, System.IEquatable<UnityEngine.UIElements.InheritedData>
        {
            /*0x10*/ UnityEngine.Color color;
            /*0x20*/ UnityEngine.UIElements.Length fontSize;
            /*0x28*/ UnityEngine.UIElements.Length letterSpacing;
            /*0x30*/ UnityEngine.UIElements.TextShadow textShadow;
            /*0x50*/ UnityEngine.Font unityFont;
            /*0x58*/ UnityEngine.UIElements.FontDefinition unityFontDefinition;
            /*0x68*/ UnityEngine.FontStyle unityFontStyleAndWeight;
            /*0x6c*/ UnityEngine.UIElements.Length unityParagraphSpacing;
            /*0x74*/ UnityEngine.TextAnchor unityTextAlign;
            /*0x78*/ UnityEngine.Color unityTextOutlineColor;
            /*0x88*/ float unityTextOutlineWidth;
            /*0x8c*/ UnityEngine.UIElements.Visibility visibility;
            /*0x90*/ UnityEngine.UIElements.WhiteSpace whiteSpace;
            /*0x94*/ UnityEngine.UIElements.Length wordSpacing;

            static /*0x2a9a93c*/ bool op_Equality(UnityEngine.UIElements.InheritedData lhs, UnityEngine.UIElements.InheritedData rhs);
            /*0x2a9a90c*/ UnityEngine.UIElements.InheritedData Copy();
            /*0x2a9a928*/ void CopyFrom(ref UnityEngine.UIElements.InheritedData other);
            /*0x2a9ab3c*/ bool Equals(UnityEngine.UIElements.InheritedData other);
            /*0x2a9ab88*/ bool Equals(object obj);
            /*0x2a9ac30*/ int GetHashCode();
        }

        struct LayoutData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.LayoutData>, System.IEquatable<UnityEngine.UIElements.LayoutData>
        {
            /*0x10*/ UnityEngine.UIElements.Align alignContent;
            /*0x14*/ UnityEngine.UIElements.Align alignItems;
            /*0x18*/ UnityEngine.UIElements.Align alignSelf;
            /*0x1c*/ float borderBottomWidth;
            /*0x20*/ float borderLeftWidth;
            /*0x24*/ float borderRightWidth;
            /*0x28*/ float borderTopWidth;
            /*0x2c*/ UnityEngine.UIElements.Length bottom;
            /*0x34*/ UnityEngine.UIElements.DisplayStyle display;
            /*0x38*/ UnityEngine.UIElements.Length flexBasis;
            /*0x40*/ UnityEngine.UIElements.FlexDirection flexDirection;
            /*0x44*/ float flexGrow;
            /*0x48*/ float flexShrink;
            /*0x4c*/ UnityEngine.UIElements.Wrap flexWrap;
            /*0x50*/ UnityEngine.UIElements.Length height;
            /*0x58*/ UnityEngine.UIElements.Justify justifyContent;
            /*0x5c*/ UnityEngine.UIElements.Length left;
            /*0x64*/ UnityEngine.UIElements.Length marginBottom;
            /*0x6c*/ UnityEngine.UIElements.Length marginLeft;
            /*0x74*/ UnityEngine.UIElements.Length marginRight;
            /*0x7c*/ UnityEngine.UIElements.Length marginTop;
            /*0x84*/ UnityEngine.UIElements.Length maxHeight;
            /*0x8c*/ UnityEngine.UIElements.Length maxWidth;
            /*0x94*/ UnityEngine.UIElements.Length minHeight;
            /*0x9c*/ UnityEngine.UIElements.Length minWidth;
            /*0xa4*/ UnityEngine.UIElements.Length paddingBottom;
            /*0xac*/ UnityEngine.UIElements.Length paddingLeft;
            /*0xb4*/ UnityEngine.UIElements.Length paddingRight;
            /*0xbc*/ UnityEngine.UIElements.Length paddingTop;
            /*0xc4*/ UnityEngine.UIElements.Position position;
            /*0xc8*/ UnityEngine.UIElements.Length right;
            /*0xd0*/ UnityEngine.UIElements.Length top;
            /*0xd8*/ UnityEngine.UIElements.Length width;

            static /*0x2a9aeac*/ bool op_Equality(UnityEngine.UIElements.LayoutData lhs, UnityEngine.UIElements.LayoutData rhs);
            /*0x2a9ae7c*/ UnityEngine.UIElements.LayoutData Copy();
            /*0x2a9ae98*/ void CopyFrom(ref UnityEngine.UIElements.LayoutData other);
            /*0x2a9b12c*/ bool Equals(UnityEngine.UIElements.LayoutData other);
            /*0x2a9b178*/ bool Equals(object obj);
            /*0x2a9b220*/ int GetHashCode();
        }

        struct RareData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.RareData>, System.IEquatable<UnityEngine.UIElements.RareData>
        {
            /*0x10*/ UnityEngine.UIElements.Cursor cursor;
            /*0x28*/ UnityEngine.UIElements.TextOverflow textOverflow;
            /*0x2c*/ UnityEngine.Color unityBackgroundImageTintColor;
            /*0x3c*/ UnityEngine.ScaleMode unityBackgroundScaleMode;
            /*0x40*/ UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox;
            /*0x44*/ int unitySliceBottom;
            /*0x48*/ int unitySliceLeft;
            /*0x4c*/ int unitySliceRight;
            /*0x50*/ int unitySliceTop;
            /*0x54*/ UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition;

            static /*0x2a9b4b4*/ bool op_Equality(UnityEngine.UIElements.RareData lhs, UnityEngine.UIElements.RareData rhs);
            /*0x2a9b484*/ UnityEngine.UIElements.RareData Copy();
            /*0x2a9b4a0*/ void CopyFrom(ref UnityEngine.UIElements.RareData other);
            /*0x2a9b5d4*/ bool Equals(UnityEngine.UIElements.RareData other);
            /*0x2a9b618*/ bool Equals(object obj);
            /*0x2a9b6b8*/ int GetHashCode();
        }

        struct TransformData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.TransformData>, System.IEquatable<UnityEngine.UIElements.TransformData>
        {
            /*0x10*/ UnityEngine.UIElements.Rotate rotate;
            /*0x28*/ UnityEngine.UIElements.Scale scale;
            /*0x38*/ UnityEngine.UIElements.TransformOrigin transformOrigin;
            /*0x4c*/ UnityEngine.UIElements.Translate translate;

            static /*0x2a9b7e0*/ bool op_Equality(UnityEngine.UIElements.TransformData lhs, UnityEngine.UIElements.TransformData rhs);
            /*0x2a9b7b0*/ UnityEngine.UIElements.TransformData Copy();
            /*0x2a9b7cc*/ void CopyFrom(ref UnityEngine.UIElements.TransformData other);
            /*0x2a9b908*/ bool Equals(UnityEngine.UIElements.TransformData other);
            /*0x2a9b94c*/ bool Equals(object obj);
            /*0x2a9b9ec*/ int GetHashCode();
        }

        struct TransitionData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.TransitionData>, System.IEquatable<UnityEngine.UIElements.TransitionData>
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDelay;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDuration;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> transitionProperty;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction;

            static /*0x2a9bcf4*/ bool op_Equality(UnityEngine.UIElements.TransitionData lhs, UnityEngine.UIElements.TransitionData rhs);
            /*0x2a9ba50*/ UnityEngine.UIElements.TransitionData Copy();
            /*0x2a9bb94*/ void CopyFrom(ref UnityEngine.UIElements.TransitionData other);
            /*0x2a9bd40*/ bool Equals(UnityEngine.UIElements.TransitionData other);
            /*0x2a9bd8c*/ bool Equals(object obj);
            /*0x2a9be3c*/ int GetHashCode();
        }

        struct VisualData : UnityEngine.UIElements.IStyleDataGroup<UnityEngine.UIElements.VisualData>, System.IEquatable<UnityEngine.UIElements.VisualData>
        {
            /*0x10*/ UnityEngine.Color backgroundColor;
            /*0x20*/ UnityEngine.UIElements.Background backgroundImage;
            /*0x40*/ UnityEngine.Color borderBottomColor;
            /*0x50*/ UnityEngine.UIElements.Length borderBottomLeftRadius;
            /*0x58*/ UnityEngine.UIElements.Length borderBottomRightRadius;
            /*0x60*/ UnityEngine.Color borderLeftColor;
            /*0x70*/ UnityEngine.Color borderRightColor;
            /*0x80*/ UnityEngine.Color borderTopColor;
            /*0x90*/ UnityEngine.UIElements.Length borderTopLeftRadius;
            /*0x98*/ UnityEngine.UIElements.Length borderTopRightRadius;
            /*0xa0*/ float opacity;
            /*0xa4*/ UnityEngine.UIElements.OverflowInternal overflow;

            static /*0x2a9bf08*/ bool op_Equality(UnityEngine.UIElements.VisualData lhs, UnityEngine.UIElements.VisualData rhs);
            /*0x2a9bed8*/ UnityEngine.UIElements.VisualData Copy();
            /*0x2a9bef4*/ void CopyFrom(ref UnityEngine.UIElements.VisualData other);
            /*0x2a9c0f4*/ bool Equals(UnityEngine.UIElements.VisualData other);
            /*0x2a9c140*/ bool Equals(object obj);
            /*0x2a9c1e8*/ int GetHashCode();
        }

        interface IStyle
        {
            void set_backgroundColor(UnityEngine.UIElements.StyleColor value);
            void set_borderBottomColor(UnityEngine.UIElements.StyleColor value);
            void set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value);
            void set_borderLeftColor(UnityEngine.UIElements.StyleColor value);
            void set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value);
            void set_borderRightColor(UnityEngine.UIElements.StyleColor value);
            void set_borderRightWidth(UnityEngine.UIElements.StyleFloat value);
            void set_borderTopColor(UnityEngine.UIElements.StyleColor value);
            void set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value);
            void set_borderTopWidth(UnityEngine.UIElements.StyleFloat value);
            void set_bottom(UnityEngine.UIElements.StyleLength value);
            void set_color(UnityEngine.UIElements.StyleColor value);
            UnityEngine.UIElements.StyleCursor get_cursor();
            UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> get_display();
            void set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value);
            void set_flexBasis(UnityEngine.UIElements.StyleLength value);
            void set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value);
            void set_flexGrow(UnityEngine.UIElements.StyleFloat value);
            void set_flexShrink(UnityEngine.UIElements.StyleFloat value);
            void set_fontSize(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleLength get_height();
            void set_height(UnityEngine.UIElements.StyleLength value);
            void set_left(UnityEngine.UIElements.StyleLength value);
            void set_marginBottom(UnityEngine.UIElements.StyleLength value);
            void set_marginLeft(UnityEngine.UIElements.StyleLength value);
            void set_marginRight(UnityEngine.UIElements.StyleLength value);
            void set_marginTop(UnityEngine.UIElements.StyleLength value);
            void set_minWidth(UnityEngine.UIElements.StyleLength value);
            void set_opacity(UnityEngine.UIElements.StyleFloat value);
            void set_paddingBottom(UnityEngine.UIElements.StyleLength value);
            void set_paddingLeft(UnityEngine.UIElements.StyleLength value);
            void set_paddingRight(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleLength get_paddingTop();
            void set_paddingTop(UnityEngine.UIElements.StyleLength value);
            void set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value);
            void set_right(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleRotate get_rotate();
            UnityEngine.UIElements.StyleScale get_scale();
            UnityEngine.UIElements.StyleTextShadow get_textShadow();
            void set_top(UnityEngine.UIElements.StyleLength value);
            UnityEngine.UIElements.StyleTransformOrigin get_transformOrigin();
            UnityEngine.UIElements.StyleTranslate get_translate();
            void set_translate(UnityEngine.UIElements.StyleTranslate value);
            void set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value);
            void set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value);
            UnityEngine.UIElements.StyleLength get_width();
            void set_width(UnityEngine.UIElements.StyleLength value);
        }

        interface IResolvedStyle
        {
            UnityEngine.Color get_backgroundColor();
            UnityEngine.Color get_borderBottomColor();
            float get_borderBottomLeftRadius();
            float get_borderBottomRightRadius();
            float get_borderBottomWidth();
            UnityEngine.Color get_borderLeftColor();
            float get_borderLeftWidth();
            UnityEngine.Color get_borderRightColor();
            float get_borderRightWidth();
            UnityEngine.Color get_borderTopColor();
            float get_borderTopLeftRadius();
            float get_borderTopRightRadius();
            float get_borderTopWidth();
            float get_bottom();
            UnityEngine.Color get_color();
            UnityEngine.UIElements.DisplayStyle get_display();
            float get_flexGrow();
            float get_flexShrink();
            float get_height();
            float get_left();
            float get_marginBottom();
            float get_marginLeft();
            float get_marginRight();
            float get_marginTop();
            UnityEngine.UIElements.StyleFloat get_minHeight();
            UnityEngine.UIElements.StyleFloat get_minWidth();
            float get_opacity();
            float get_paddingBottom();
            float get_paddingLeft();
            float get_paddingRight();
            float get_paddingTop();
            float get_right();
            UnityEngine.UIElements.Scale get_scale();
            float get_top();
            UnityEngine.Vector3 get_transformOrigin();
            UnityEngine.Vector3 get_translate();
            UnityEngine.Color get_unityBackgroundImageTintColor();
            int get_unitySliceLeft();
            int get_unitySliceRight();
            UnityEngine.Color get_unityTextOutlineColor();
            float get_unityTextOutlineWidth();
            UnityEngine.UIElements.Visibility get_visibility();
            UnityEngine.UIElements.WhiteSpace get_whiteSpace();
            float get_width();
        }

        class ListViewController : UnityEngine.UIElements.CollectionViewController
        {
            /*0x30*/ System.Action itemsSourceSizeChanged;
            /*0x38*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsAdded;
            /*0x40*/ System.Action<System.Collections.Generic.IEnumerable<int>> itemsRemoved;

            static /*0x2a9d6bc*/ System.Array AddToArray(System.Array source, int itemCount);
            static /*0x2a9deb8*/ System.Array RemoveFromArray(System.Array source, System.Collections.Generic.List<int> indicesToRemove);
            /*0x2a9e088*/ ListViewController();
            /*0x2a9c468*/ void add_itemsSourceSizeChanged(System.Action value);
            /*0x2a9c504*/ void remove_itemsSourceSizeChanged(System.Action value);
            /*0x2a9c5a0*/ void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0x2a9c650*/ void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0x2a9c700*/ void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0x2a9c7b0*/ void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<int>> value);
            /*0x2a9c860*/ UnityEngine.UIElements.ListView get_listView();
            /*0x2a9c8dc*/ void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem);
            /*0x2a9cd58*/ void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, int index);
            /*0x2a9d048*/ bool NeedsDragHandle(int index);
            /*0x2a9d084*/ void AddItems(int itemCount);
            /*0x2a9d7f8*/ void Move(int index, int newIndex);
            /*0x2a9daa8*/ void RemoveItem(int index);
            /*0x2a9dc58*/ void RemoveItems(System.Collections.Generic.List<int> indices);
            /*0x2a9d7dc*/ void RaiseOnSizeChanged();
            /*0x2a9d7c0*/ void RaiseItemsAdded(System.Collections.Generic.IEnumerable<int> indices);
            /*0x2a9e06c*/ void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<int> indices);
            /*0x2a9d894*/ void Swap(int lhs, int rhs);
            /*0x2a9d5a4*/ void EnsureItemSourceCanBeResized();
        }

        class CollectionViewController
        {
            /*0x10*/ UnityEngine.UIElements.BaseVerticalCollectionView m_View;
            /*0x18*/ System.Collections.IList m_ItemsSource;
            /*0x20*/ System.Action itemsSourceChanged;
            /*0x28*/ System.Action<int, int> itemIndexChanged;

            /*0x2a9e090*/ CollectionViewController();
            /*0x2a9e098*/ void add_itemsSourceChanged(System.Action value);
            /*0x2a9e134*/ void remove_itemsSourceChanged(System.Action value);
            /*0x2a9e1d0*/ void add_itemIndexChanged(System.Action<int, int> value);
            /*0x2a9e280*/ void remove_itemIndexChanged(System.Action<int, int> value);
            /*0x2a9e330*/ System.Collections.IList get_itemsSource();
            /*0x2a9d794*/ void set_itemsSource(System.Collections.IList value);
            /*0x2a9e354*/ UnityEngine.UIElements.BaseVerticalCollectionView get_view();
            /*0x2a9e35c*/ void SetView(UnityEngine.UIElements.BaseVerticalCollectionView view);
            /*0x2a9e3f0*/ int GetItemCount();
            /*0x2a9e4a0*/ int GetIdForIndex(int index);
            /*0x2a9e4d8*/ object GetItemForIndex(int index);
            /*0x2a9e614*/ void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem);
            /*0x2a9cf80*/ void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, int index);
            /*0x2a9e64c*/ void InvokeUnbindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, int index);
            /*0x2a9e670*/ void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem);
            /*0x2a9e694*/ UnityEngine.UIElements.VisualElement MakeItem();
            /*0x2a9e770*/ void BindItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x2a9e940*/ void UnbindItem(UnityEngine.UIElements.VisualElement element, int index);
            /*0x2a9e974*/ void DestroyItem(UnityEngine.UIElements.VisualElement element);
            /*0x2a9e338*/ void RaiseItemsSourceChanged();
            /*0x2a9da8c*/ void RaiseItemIndexChanged(int srcIndex, int dstIndex);
        }

        class DynamicHeightVirtualizationController<T> : UnityEngine.UIElements.VerticalVirtualizationController<T>
        {
            static /*0x0*/ int InitialAverageHeight;
            /*0x0*/ System.Collections.Generic.Dictionary<int, float> m_ItemHeightCache;
            /*0x0*/ System.Collections.Generic.HashSet<int> m_WaitingCache;
            /*0x0*/ int m_ForcedFirstVisibleItem;
            /*0x0*/ int m_ForcedLastVisibleItem;
            /*0x0*/ bool m_StickToBottom;
            /*0x0*/ float m_AverageHeight;
            /*0x0*/ float m_AccumulatedHeight;
            /*0x0*/ float m_StoredPadding;
            /*0x0*/ System.Action m_FillCallback;
            /*0x0*/ System.Action<UnityEngine.UIElements.ReusableCollectionItem> m_GeometryChangedCallback;
            /*0x0*/ UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledItem;
            /*0x0*/ System.Predicate<int> m_IndexOutOfBoundsPredicate;

            static DynamicHeightVirtualizationController();
            DynamicHeightVirtualizationController(UnityEngine.UIElements.BaseVerticalCollectionView collectionView);
            void Refresh(bool rebuild);
            void ScrollToItem(int index);
            void Resize(UnityEngine.Vector2 size, int layoutPass);
            void OnScroll(UnityEngine.Vector2 scrollOffset);
            bool NeedsFill();
            void Fill();
            int GetIndexFromPosition(UnityEngine.Vector2 position);
            float GetItemHeight(int index);
            int GetFirstVisibleItem(float offset);
            void UpdateScrollViewContainer(int index, float previousHeight, float newHeight);
            void ApplyScrollViewUpdate();
            void OnViewportGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
            float GetContentHeight();
            float GetContentHeightForIndex(int lastIndex);
            void RegisterItemHeight(int index, float height);
            void UnregisterItemHeight(int index, float height);
            void OnRecycledItemGeometryChanged(UnityEngine.UIElements.ReusableCollectionItem item);
            T GetOrMakeItem();
            void ReplaceActiveItem(int index);
            void ReleaseItem(int activeItemsIndex);
            bool IsIndexOutOfBounds(int i);
            void <.ctor>b__13_0(UnityEngine.UIElements.VisualElement element);
        }

        class FixedHeightVirtualizationController<T> : UnityEngine.UIElements.VerticalVirtualizationController<T>
        {
            FixedHeightVirtualizationController(UnityEngine.UIElements.BaseVerticalCollectionView collectionView);
            float get_resolvedItemHeight();
            bool VisibleItemPredicate(T i);
            int GetIndexFromPosition(UnityEngine.Vector2 position);
            float GetItemHeight(int index);
            void ScrollToItem(int index);
            void Resize(UnityEngine.Vector2 size, int layoutPass);
            void OnScroll(UnityEngine.Vector2 scrollOffset);
            T GetOrMakeItem();
        }

        class ReusableListViewItem : UnityEngine.UIElements.ReusableCollectionItem
        {
            /*0x38*/ UnityEngine.UIElements.VisualElement m_Container;
            /*0x40*/ UnityEngine.UIElements.VisualElement m_DragHandle;
            /*0x48*/ UnityEngine.UIElements.VisualElement m_ItemContainer;

            /*0x2a9ef08*/ ReusableListViewItem();
            /*0x2a9e9a8*/ UnityEngine.UIElements.VisualElement get_rootElement();
            /*0x2a9cd48*/ void Init(UnityEngine.UIElements.VisualElement item, bool usesAnimatedDragger);
            /*0x2a9e9c8*/ void UpdateHierarchy(bool usesAnimatedDragger);
            /*0x2a9ce44*/ void UpdateDragHandle(bool needsDragHandle);
            /*0x2a9ec3c*/ void PreAttachElement();
            /*0x2a9ed84*/ void DetachElement();
        }

        class VerticalVirtualizationController<T> : UnityEngine.UIElements.CollectionVirtualizationController
        {
            /*0x0*/ UnityEngine.UIElements.BaseVerticalCollectionView m_ListView;
            /*0x0*/ UnityEngine.Pool.ObjectPool<T> m_Pool;
            /*0x0*/ System.Collections.Generic.List<T> m_ActiveItems;
            /*0x0*/ int m_LastFocusedElementIndex;
            /*0x0*/ System.Collections.Generic.List<int> m_LastFocusedElementTreeChildIndexes;
            /*0x0*/ int m_FirstVisibleIndex;
            /*0x0*/ System.Func<T, bool> m_VisibleItemPredicateDelegate;
            /*0x0*/ System.Collections.Generic.List<T> m_ScrollInsertionList;
            /*0x0*/ UnityEngine.UIElements.VisualElement k_EmptyRows;

            VerticalVirtualizationController(UnityEngine.UIElements.BaseVerticalCollectionView collectionView);
            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems();
            bool VisibleItemPredicate(T i);
            T get_firstVisibleItem();
            T get_lastVisibleItem();
            int get_visibleItemCount();
            int get_lastVisibleIndex();
            float get_lastHeight();
            void Refresh(bool rebuild);
            void Setup(T recycledItem, int newIndex);
            void OnFocus(UnityEngine.UIElements.VisualElement leafTarget);
            void OnBlur(UnityEngine.UIElements.VisualElement willFocus);
            void HandleFocus(UnityEngine.UIElements.ReusableCollectionItem recycledItem, int previousIndex);
            void UpdateBackground();
            void ReplaceActiveItem(int index);
            T GetOrMakeItem();
            void ReleaseItem(int activeItemsIndex);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.UIElements.VerticalVirtualizationController.<>c<T> <>9;
                static /*0x0*/ System.Func<T> <>9__25_0;
                static /*0x0*/ System.Action<T> <>9__25_1;

                static <>c();
                <>c();
                T <.ctor>b__25_0();
                void <.ctor>b__25_1(T i);
            }
        }

        class CollectionVirtualizationController
        {
            /*0x10*/ UnityEngine.UIElements.ScrollView m_ScrollView;

            /*0x2a9ef9c*/ CollectionVirtualizationController(UnityEngine.UIElements.ScrollView scrollView);
            int get_lastVisibleIndex();
            int get_visibleItemCount();
            void Refresh(bool rebuild);
            void ScrollToItem(int id);
            void Resize(UnityEngine.Vector2 size, int layoutPass);
            void OnScroll(UnityEngine.Vector2 offset);
            int GetIndexFromPosition(UnityEngine.Vector2 position);
            float GetItemHeight(int index);
            void OnFocus(UnityEngine.UIElements.VisualElement leafTarget);
            void OnBlur(UnityEngine.UIElements.VisualElement willFocus);
            void UpdateBackground();
            System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems();
            void ReplaceActiveItem(int index);
        }

        class ReusableCollectionItem
        {
            /*0x10*/ UnityEngine.UIElements.VisualElement <bindableElement>k__BackingField;
            /*0x18*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> <animator>k__BackingField;
            /*0x20*/ int <index>k__BackingField;
            /*0x24*/ int <id>k__BackingField;
            /*0x28*/ System.Action<UnityEngine.UIElements.ReusableCollectionItem> onGeometryChanged;
            /*0x30*/ UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent> m_GeometryChangedEventCallback;

            /*0x2a9ef0c*/ ReusableCollectionItem();
            /*0x2a9efc4*/ UnityEngine.UIElements.VisualElement get_rootElement();
            /*0x2a9efcc*/ UnityEngine.UIElements.VisualElement get_bindableElement();
            /*0x2a9efd4*/ void set_bindableElement(UnityEngine.UIElements.VisualElement value);
            /*0x2a9efdc*/ UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator();
            /*0x2a9efe4*/ void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value);
            /*0x2a9efec*/ int get_index();
            /*0x2a9eff4*/ void set_index(int value);
            /*0x2a9effc*/ int get_id();
            /*0x2a9f004*/ void set_id(int value);
            /*0x2a9f00c*/ void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value);
            /*0x2a9f0bc*/ void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value);
            /*0x2a9e9c0*/ void Init(UnityEngine.UIElements.VisualElement item);
            /*0x2a9ecc8*/ void PreAttachElement();
            /*0x2a9ee10*/ void DetachElement();
            /*0x2a9f16c*/ void SetSelected(bool selected);
            /*0x2a9f25c*/ void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt);
        }

        namespace UIR
        {
            enum OwnedState
            {
                Inherited = 0,
                Owned = 1,
            }

            struct BMPAlloc
            {
                static /*0x0*/ UnityEngine.UIElements.UIR.BMPAlloc Invalid;
                /*0x10*/ int page;
                /*0x14*/ ushort pageLine;
                /*0x16*/ byte bitIndex;
                /*0x17*/ UnityEngine.UIElements.UIR.OwnedState ownedState;

                static /*0x2a9f3b8*/ BMPAlloc();
                /*0x2a9f27c*/ bool Equals(UnityEngine.UIElements.UIR.BMPAlloc other);
                /*0x2a9f2b4*/ bool IsValid();
                /*0x2a9f2c4*/ string ToString();
            }

            struct BitmapAllocator32
            {
                /*0x10*/ int m_PageHeight;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.BitmapAllocator32.Page> m_Pages;
                /*0x20*/ System.Collections.Generic.List<uint> m_AllocMap;
                /*0x28*/ int m_EntryWidth;
                /*0x2c*/ int m_EntryHeight;

                static /*0x2a9fafc*/ byte CountTrailingZeroes(uint val);
                /*0x2a9f404*/ void Construct(int pageHeight, int entryWidth, int entryHeight);
                /*0x2a9f514*/ void ForceFirstAlloc(ushort firstPageX, ushort firstPageY);
                /*0x2a9f6e0*/ UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage storage);
                /*0x2a9fb60*/ void Free(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2a9fca4*/ int get_entryWidth();
                /*0x2a9fcac*/ int get_entryHeight();
                /*0x2a9fcb4*/ void GetAllocPageAtlasLocation(int page, ref ushort x, ref ushort y);

                struct Page
                {
                    /*0x10*/ ushort x;
                    /*0x12*/ ushort y;
                    /*0x14*/ int freeSlots;
                }
            }

            struct UIRVEShaderInfoAllocator
            {
                static /*0x0*/ UnityEngine.Vector2Int identityTransformTexel;
                static /*0x8*/ UnityEngine.Vector2Int infiniteClipRectTexel;
                static /*0x10*/ UnityEngine.Vector2Int fullOpacityTexel;
                static /*0x18*/ UnityEngine.Vector2Int clearColorTexel;
                static /*0x20*/ UnityEngine.Vector2Int defaultTextCoreSettingsTexel;
                static /*0x28*/ UnityEngine.Matrix4x4 identityTransformValue;
                static /*0x68*/ UnityEngine.Vector4 identityTransformRow0Value;
                static /*0x78*/ UnityEngine.Vector4 identityTransformRow1Value;
                static /*0x88*/ UnityEngine.Vector4 identityTransformRow2Value;
                static /*0x98*/ UnityEngine.Vector4 infiniteClipRectValue;
                static /*0xa8*/ UnityEngine.Vector4 fullOpacityValue;
                static /*0xb8*/ UnityEngine.Vector4 clearColorValue;
                static /*0xc8*/ UnityEngine.UIElements.UIR.TextCoreSettings defaultTextCoreSettingsValue;
                static /*0x108*/ UnityEngine.UIElements.UIR.BMPAlloc identityTransform;
                static /*0x110*/ UnityEngine.UIElements.UIR.BMPAlloc infiniteClipRect;
                static /*0x118*/ UnityEngine.UIElements.UIR.BMPAlloc fullOpacity;
                static /*0x120*/ UnityEngine.UIElements.UIR.BMPAlloc clearColor;
                static /*0x128*/ UnityEngine.UIElements.UIR.BMPAlloc defaultTextCoreSettings;
                /*0x10*/ UnityEngine.UIElements.UIR.BaseShaderInfoStorage m_Storage;
                /*0x18*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator;
                /*0x38*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator;
                /*0x58*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator;
                /*0x78*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator;
                /*0x98*/ UnityEngine.UIElements.UIR.BitmapAllocator32 m_TextSettingsAllocator;
                /*0xb8*/ bool m_StorageReallyCreated;
                /*0xb9*/ bool m_VertexTexturingEnabled;
                /*0xc0*/ Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.Transform3x4> m_Transforms;
                /*0xd0*/ Unity.Collections.NativeArray<UnityEngine.Vector4> m_ClipRects;

                static /*0x2aa1978*/ UIRVEShaderInfoAllocator();
                static /*0x2a9fd2c*/ int get_pageWidth();
                static /*0x2a9fd34*/ int get_pageHeight();
                static /*0x2a9fd3c*/ UnityEngine.Vector2Int AllocToTexelCoord(ref UnityEngine.UIElements.UIR.BitmapAllocator32 allocator, UnityEngine.UIElements.UIR.BMPAlloc alloc);
                static /*0x2a9fd8c*/ int AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                static /*0x2a9fdf4*/ bool AtlasRectMatchesPage(ref UnityEngine.UIElements.UIR.BitmapAllocator32 allocator, UnityEngine.UIElements.UIR.BMPAlloc defAlloc, UnityEngine.RectInt atlasRect);
                /*0x2a9feec*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants();
                /*0x2a9ff34*/ Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants();
                /*0x2a9ff7c*/ UnityEngine.Texture get_atlas();
                /*0x2aa000c*/ void Construct();
                /*0x2aa0294*/ void ReallyCreateStorage();
                /*0x2aa0e64*/ void Dispose();
                /*0x2aa0fa0*/ void IssuePendingStorageChanges();
                /*0x2aa0fb8*/ UnityEngine.UIElements.UIR.BMPAlloc AllocTransform();
                /*0x2aa10a0*/ UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect();
                /*0x2aa1188*/ UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity();
                /*0x2aa11b0*/ UnityEngine.UIElements.UIR.BMPAlloc AllocColor();
                /*0x2aa11d8*/ UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings settings);
                /*0x2aa07e8*/ void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Matrix4x4 xform);
                /*0x2aa09fc*/ void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Vector4 clipRect);
                /*0x2aa0b34*/ void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, float opacity);
                /*0x2aa0c10*/ void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Color color);
                /*0x2aa0d00*/ void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.UIElements.UIR.TextCoreSettings settings);
                /*0x2aa1200*/ void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa1274*/ void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa12e8*/ void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa135c*/ void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa13d0*/ void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa1444*/ UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa1564*/ UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa1684*/ UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa1780*/ UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa187c*/ UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc);
            }

            class GradientSettingsAtlas : System.IDisposable
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerWrite;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerCommit;
                static /*0x10*/ int s_TextureCounter;
                /*0x10*/ int m_Length;
                /*0x14*/ int m_ElemWidth;
                /*0x18*/ UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator;
                /*0x20*/ UnityEngine.Texture2D m_Atlas;
                /*0x28*/ UnityEngine.UIElements.UIR.GradientSettingsAtlas.RawTexture m_RawAtlas;
                /*0x38*/ bool <disposed>k__BackingField;
                /*0x39*/ bool <MustCommit>k__BackingField;

                static /*0x2aa25dc*/ GradientSettingsAtlas();
                /*0x2aa1c3c*/ GradientSettingsAtlas(int length);
                /*0x2aa1b3c*/ int get_length();
                /*0x2aa1b44*/ bool get_disposed();
                /*0x2aa1b4c*/ void set_disposed(bool value);
                /*0x2aa1b58*/ void Dispose();
                /*0x2aa1bc4*/ void Dispose(bool disposing);
                /*0x2aa1c6c*/ void Reset();
                /*0x2aa1d38*/ UnityEngine.Texture2D get_atlas();
                /*0x2aa1d40*/ UnityEngine.UIElements.UIR.Alloc Add(int count);
                /*0x2aa1e2c*/ void Write(UnityEngine.UIElements.UIR.Alloc alloc, UnityEngine.UIElements.GradientSettings[] settings, UnityEngine.UIElements.UIR.GradientRemap remap);
                /*0x2aa23fc*/ bool get_MustCommit();
                /*0x2aa2404*/ void set_MustCommit(bool value);
                /*0x2aa2410*/ void Commit();
                /*0x2aa2474*/ void PrepareAtlas();

                struct RawTexture
                {
                    /*0x10*/ UnityEngine.Color32[] rgba;
                    /*0x18*/ int width;
                    /*0x1c*/ int height;

                    /*0x2aa2374*/ void WriteRawInt2Packed(int v0, int v1, int destX, int destY);
                    /*0x2aa22cc*/ void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY);
                }
            }

            class BaseShaderInfoStorage : System.IDisposable
            {
                static /*0x0*/ int s_TextureCounter;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerCopyTexture;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerGetTextureData;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_MarkerUpdateTexture;
                /*0x10*/ bool <disposed>k__BackingField;

                static /*0x2aa26c4*/ BaseShaderInfoStorage();
                /*0x2aa26bc*/ BaseShaderInfoStorage();
                UnityEngine.Texture2D get_texture();
                bool AllocateRect(int width, int height, ref UnityEngine.RectInt uvs);
                void SetTexel(int x, int y, UnityEngine.Color color);
                void UpdateTexture();
                /*0x2aa2690*/ bool get_disposed();
                /*0x2aa2698*/ void set_disposed(bool value);
                /*0x2aa0f34*/ void Dispose();
                /*0x2aa26a4*/ void Dispose(bool disposing);
            }

            class ShaderInfoStorage<T> : UnityEngine.UIElements.UIR.BaseShaderInfoStorage
            {
                /*0x0*/ int m_InitialSize;
                /*0x0*/ int m_MaxSize;
                /*0x0*/ UnityEngine.TextureFormat m_Format;
                /*0x0*/ System.Func<UnityEngine.Color, T> m_Convert;
                /*0x0*/ UnityEngine.UIElements.UIRAtlasAllocator m_Allocator;
                /*0x0*/ UnityEngine.Texture2D m_Texture;
                /*0x0*/ Unity.Collections.NativeArray<T> m_Texels;

                static void CpuBlit(Unity.Collections.NativeArray<T> src, int srcWidth, int srcHeight, Unity.Collections.NativeArray<T> dst, int dstWidth, int dstHeight);
                ShaderInfoStorage(UnityEngine.TextureFormat format, System.Func<UnityEngine.Color, T> convert, int initialSize, int maxSize);
                void Dispose(bool disposing);
                UnityEngine.Texture2D get_texture();
                bool AllocateRect(int width, int height, ref UnityEngine.RectInt uvs);
                void SetTexel(int x, int y, UnityEngine.Color color);
                void UpdateTexture();
                void CreateOrExpandTexture();
            }

            class ShaderInfoStorageRGBA32 : UnityEngine.UIElements.UIR.ShaderInfoStorage<UnityEngine.Color32>
            {
                static /*0x0*/ System.Func<UnityEngine.Color, UnityEngine.Color32> s_Convert;

                static /*0x2aa27b0*/ ShaderInfoStorageRGBA32();
                /*0x2aa0754*/ ShaderInfoStorageRGBA32(int initialSize, int maxSize);

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32.<> <>9;

                    static /*0x2aa2874*/ <>c();
                    /*0x2aa28d8*/ <>c();
                    /*0x2aa28e0*/ UnityEngine.Color32 <.cctor>b__2_0(UnityEngine.Color c);
                }
            }

            class ShaderInfoStorageRGBAFloat : UnityEngine.UIElements.UIR.ShaderInfoStorage<UnityEngine.Color>
            {
                static /*0x0*/ System.Func<UnityEngine.Color, UnityEngine.Color> s_Convert;

                static /*0x2aa2ba4*/ ShaderInfoStorageRGBAFloat();
                /*0x2aa06c0*/ ShaderInfoStorageRGBAFloat(int initialSize, int maxSize);

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat.<> <>9;

                    static /*0x2aa2c68*/ <>c();
                    /*0x2aa2ccc*/ <>c();
                    /*0x2aa2cd4*/ UnityEngine.Color <.cctor>b__2_0(UnityEngine.Color c);
                }
            }

            class TextureBlitter : System.IDisposable
            {
                static /*0x0*/ int[] k_TextureIds;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_CommitSampler;
                /*0x10*/ UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo[] m_SingleBlit;
                /*0x18*/ UnityEngine.Material m_BlitMaterial;
                /*0x20*/ UnityEngine.MaterialPropertyBlock m_Properties;
                /*0x28*/ UnityEngine.RectInt m_Viewport;
                /*0x38*/ UnityEngine.RenderTexture m_PrevRT;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> m_PendingBlits;
                /*0x48*/ bool <disposed>k__BackingField;

                static /*0x2aa2d68*/ TextureBlitter();
                /*0x2a94514*/ TextureBlitter(int capacity);
                /*0x2aa2cd8*/ bool get_disposed();
                /*0x2aa2ce0*/ void set_disposed(bool value);
                /*0x2a9481c*/ void Dispose();
                /*0x2aa2cec*/ void Dispose(bool disposing);
                /*0x2a94c08*/ void QueueBlit(UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, bool addBorder, UnityEngine.Color tint);
                /*0x2a9548c*/ void BlitOneNow(UnityEngine.RenderTexture dst, UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, bool addBorder, UnityEngine.Color tint);
                /*0x2a95268*/ void Commit(UnityEngine.RenderTexture dst);
                /*0x2aa2e94*/ void BeginBlit(UnityEngine.RenderTexture dst);
                /*0x2aa3090*/ void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, int startIndex);
                /*0x2aa35ac*/ void EndBlit();

                struct BlitInfo
                {
                    /*0x10*/ UnityEngine.Texture src;
                    /*0x18*/ UnityEngine.RectInt srcRect;
                    /*0x28*/ UnityEngine.Vector2Int dstPos;
                    /*0x30*/ int border;
                    /*0x34*/ UnityEngine.Color tint;
                }
            }

            struct ChainBuilderStats
            {
                /*0x10*/ uint elementsAdded;
                /*0x14*/ uint elementsRemoved;
                /*0x18*/ uint recursiveClipUpdates;
                /*0x1c*/ uint recursiveClipUpdatesExpanded;
                /*0x20*/ uint nonRecursiveClipUpdates;
                /*0x24*/ uint recursiveTransformUpdates;
                /*0x28*/ uint recursiveTransformUpdatesExpanded;
                /*0x2c*/ uint recursiveOpacityUpdates;
                /*0x30*/ uint recursiveOpacityUpdatesExpanded;
                /*0x34*/ uint colorUpdates;
                /*0x38*/ uint colorUpdatesExpanded;
                /*0x3c*/ uint recursiveVisualUpdates;
                /*0x40*/ uint recursiveVisualUpdatesExpanded;
                /*0x44*/ uint nonRecursiveVisualUpdates;
                /*0x48*/ uint dirtyProcessed;
                /*0x4c*/ uint nudgeTransformed;
                /*0x50*/ uint boneTransformed;
                /*0x54*/ uint skipTransformed;
                /*0x58*/ uint visualUpdateTransformed;
                /*0x5c*/ uint updatedMeshAllocations;
                /*0x60*/ uint newMeshAllocations;
                /*0x64*/ uint groupTransformElementsChanged;
                /*0x68*/ uint immedateRenderersActive;
                /*0x6c*/ uint textUpdates;
            }

            class RenderChain : System.IDisposable
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker s_MarkerProcess;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerClipProcessing;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerOpacityProcessing;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_MarkerColorsProcessing;
                static /*0x20*/ Unity.Profiling.ProfilerMarker s_MarkerTransformProcessing;
                static /*0x28*/ Unity.Profiling.ProfilerMarker s_MarkerVisualsProcessing;
                static /*0x30*/ Unity.Profiling.ProfilerMarker s_MarkerTextRegen;
                static /*0x38*/ System.Action OnPreRender;
                /*0x10*/ UnityEngine.UIElements.UIR.RenderChainCommand m_FirstCommand;
                /*0x18*/ UnityEngine.UIElements.UIR.RenderChain.DepthOrderedDirtyTracking m_DirtyTracker;
                /*0x40*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.RenderChainCommand> m_CommandPool;
                /*0x48*/ UnityEngine.UIElements.UIR.BasicNodePool<UnityEngine.UIElements.UIR.TextureEntry> m_TexturePool;
                /*0x50*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain.RenderNodeData> m_RenderNodesData;
                /*0x58*/ UnityEngine.Shader m_DefaultShader;
                /*0x60*/ UnityEngine.Shader m_DefaultWorldSpaceShader;
                /*0x68*/ UnityEngine.Material m_DefaultMat;
                /*0x70*/ UnityEngine.Material m_DefaultWorldSpaceMat;
                /*0x78*/ bool m_BlockDirtyRegistration;
                /*0x7c*/ int m_StaticIndex;
                /*0x80*/ int m_ActiveRenderNodes;
                /*0x84*/ int m_CustomMaterialCommands;
                /*0x88*/ UnityEngine.UIElements.UIR.ChainBuilderStats m_Stats;
                /*0xe8*/ uint m_StatsElementsAdded;
                /*0xec*/ uint m_StatsElementsRemoved;
                /*0xf0*/ UnityEngine.UIElements.VisualElement m_FirstTextElement;
                /*0xf8*/ UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter m_TextUpdatePainter;
                /*0x100*/ int m_TextElementCount;
                /*0x104*/ int m_DirtyTextStartIndex;
                /*0x108*/ int m_DirtyTextRemaining;
                /*0x10c*/ bool m_FontWasReset;
                /*0x110*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> m_LastGroupTransformElementScale;
                /*0x118*/ UnityEngine.UIElements.TextureRegistry m_TextureRegistry;
                /*0x120*/ bool <disposed>k__BackingField;
                /*0x128*/ UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField;
                /*0x130*/ UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField;
                /*0x138*/ UnityEngine.UIElements.AtlasBase <atlas>k__BackingField;
                /*0x140*/ UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField;
                /*0x148*/ UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator shaderInfoAllocator;
                /*0x218*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter <painter>k__BackingField;
                /*0x220*/ bool <drawStats>k__BackingField;
                /*0x221*/ bool <drawInCameras>k__BackingField;

                static /*0x2aa368c*/ RenderChain();
                static /*0x2aa6eb8*/ UnityEngine.UIElements.UIR.RenderChain.RenderNodeData AccessRenderNodeData(nint obj);
                static /*0x2aa6f90*/ void OnRenderNodeExecute(nint obj);
                static /*0x2aa7038*/ void OnRegisterIntermediateRenderers(UnityEngine.Camera camera);
                static /*0x2aa7498*/ void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel rtp, UnityEngine.UIElements.UIR.RenderChain renderChain, ref UnityEngine.UIElements.UIR.RenderChain.RenderNodeData rnd, UnityEngine.Camera camera, int sameDistanceSortPriority);
                static /*0x2aa42c0*/ UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa393c*/ RenderChain(UnityEngine.UIElements.BaseVisualElementPanel panel);
                /*0x2aa3cf4*/ void Constructor(UnityEngine.UIElements.BaseVisualElementPanel panelObj, UnityEngine.UIElements.UIR.UIRenderDevice deviceObj, UnityEngine.UIElements.AtlasBase atlas, UnityEngine.UIElements.UIR.VectorImageManager vectorImageMan);
                /*0x2aa407c*/ void Destructor();
                /*0x2aa4414*/ bool get_disposed();
                /*0x2aa441c*/ void set_disposed(bool value);
                /*0x2aa4428*/ void Dispose();
                /*0x2aa4498*/ void Dispose(bool disposing);
                /*0x2aa44c4*/ void ProcessChanges();
                /*0x2aa4cc0*/ void Render();
                /*0x2aa4a90*/ void ProcessTextRegen(bool timeSliced);
                /*0x2aa5f58*/ void UIEOnChildAdded(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa62e0*/ void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6498*/ void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6598*/ void StopTrackingGroupTransformElement(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa65f0*/ void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6124*/ void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement ve, bool hierarchical);
                /*0x2aa61b8*/ void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement ve, bool hierarchical);
                /*0x2aa6690*/ void UIEOnColorChanged(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6718*/ void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement ve, bool transformChanged, bool clipRectSizeChanged);
                /*0x2aa624c*/ void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement ve, bool hierarchical);
                /*0x2aa67b0*/ UnityEngine.UIElements.BaseVisualElementPanel get_panel();
                /*0x2aa67b8*/ void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value);
                /*0x2aa67c0*/ UnityEngine.UIElements.UIR.UIRenderDevice get_device();
                /*0x2aa67c8*/ void set_device(UnityEngine.UIElements.UIR.UIRenderDevice value);
                /*0x2aa67d0*/ UnityEngine.UIElements.AtlasBase get_atlas();
                /*0x2aa67d8*/ void set_atlas(UnityEngine.UIElements.AtlasBase value);
                /*0x2aa67e0*/ UnityEngine.UIElements.UIR.VectorImageManager get_vectorImageManager();
                /*0x2aa67e8*/ void set_vectorImageManager(UnityEngine.UIElements.UIR.VectorImageManager value);
                /*0x2aa67f0*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter get_painter();
                /*0x2aa67f8*/ void set_painter(UnityEngine.UIElements.UIR.Implementation.UIRStylePainter value);
                /*0x2aa6800*/ bool get_drawStats();
                /*0x2aa6808*/ void set_drawStats(bool value);
                /*0x2aa6814*/ bool get_drawInCameras();
                /*0x2aa681c*/ void set_drawInCameras(bool value);
                /*0x2aa6828*/ void set_defaultShader(UnityEngine.Shader value);
                /*0x2aa68d8*/ void set_defaultWorldSpaceShader(UnityEngine.Shader value);
                /*0x2aa4ff8*/ UnityEngine.Material GetStandardMaterial();
                /*0x2aa6988*/ UnityEngine.Material GetStandardWorldSpaceMaterial();
                /*0x2aa6a74*/ void EnsureFitsDepth(int depth);
                /*0x2aa6a80*/ void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6b38*/ UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand();
                /*0x2aa6ba0*/ void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd);
                /*0x2aa6c50*/ void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand command);
                /*0x2aa6cdc*/ void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand firstCommand, UnityEngine.UIElements.UIR.RenderChainCommand lastCommand);
                /*0x2aa6d04*/ void AddTextElement(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6d38*/ void RemoveTextElement(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa6d8c*/ void OnGroupTransformElementChangedTransform(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa77ec*/ void RepaintTexturedElements();
                /*0x2aa78cc*/ void OnFontReset(UnityEngine.Font font);
                /*0x2aa78d8*/ void AppendTexture(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture src, UnityEngine.UIElements.TextureId id, bool isAtlas);
                /*0x2aa4308*/ void ResetTextures(UnityEngine.UIElements.VisualElement ve);
                /*0x2aa50e4*/ void DrawStats();

                struct DepthOrderedDirtyTracking
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> heads;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> tails;
                    /*0x20*/ int[] minDepths;
                    /*0x28*/ int[] maxDepths;
                    /*0x30*/ uint dirtyID;

                    /*0x2aa8980*/ void EnsureFits(int maxDepth);
                    /*0x2aa8a9c*/ void RegisterDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses dirtyTypeClass);
                    /*0x2aa8c58*/ void ClearDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypesInverse);
                    /*0x2aa8de8*/ void Reset();
                }

                struct RenderChainStaticIndexAllocator
                {
                    static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain> renderChains;

                    static /*0x2aa90b4*/ RenderChainStaticIndexAllocator();
                    static /*0x2aa8e60*/ int AllocateIndex(UnityEngine.UIElements.UIR.RenderChain renderChain);
                    static /*0x2aa8fb0*/ void FreeIndex(int index);
                    static /*0x2aa9034*/ UnityEngine.UIElements.UIR.RenderChain AccessIndex(int index);
                }

                struct RenderNodeData
                {
                    /*0x10*/ UnityEngine.Material standardMaterial;
                    /*0x18*/ UnityEngine.Material initialMaterial;
                    /*0x20*/ UnityEngine.MaterialPropertyBlock matPropBlock;
                    /*0x28*/ UnityEngine.UIElements.UIR.RenderChainCommand firstCommand;
                    /*0x30*/ UnityEngine.UIElements.UIR.UIRenderDevice device;
                    /*0x38*/ UnityEngine.Texture vectorAtlas;
                    /*0x40*/ UnityEngine.Texture shaderInfoAtlas;
                    /*0x48*/ float dpiScale;
                    /*0x50*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transformConstants;
                    /*0x60*/ Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRectConstants;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.RenderChain.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__37_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__37_1;

                    static /*0x2aa9144*/ <>c();
                    /*0x2aa91a8*/ <>c();
                    /*0x2aa91b0*/ UnityEngine.UIElements.UIR.RenderChainCommand <.ctor>b__37_0();
                    /*0x2aa920c*/ void <.ctor>b__37_1(UnityEngine.UIElements.UIR.RenderChainCommand cmd);
                }
            }

            enum RenderDataDirtyTypes
            {
                None = 0,
                Transform = 1,
                ClipRectSize = 2,
                Clipping = 4,
                ClippingHierarchy = 8,
                Visuals = 16,
                VisualsHierarchy = 32,
                Opacity = 64,
                OpacityHierarchy = 128,
                Color = 256,
            }

            enum RenderDataDirtyTypeClasses
            {
                Clipping = 0,
                Opacity = 1,
                Color = 2,
                TransformSize = 3,
                Visuals = 4,
                Count = 5,
            }

            struct RenderChainVEData
            {
                /*0x10*/ UnityEngine.UIElements.VisualElement prev;
                /*0x18*/ UnityEngine.UIElements.VisualElement next;
                /*0x20*/ UnityEngine.UIElements.VisualElement groupTransformAncestor;
                /*0x28*/ UnityEngine.UIElements.VisualElement boneTransformAncestor;
                /*0x30*/ UnityEngine.UIElements.VisualElement prevDirty;
                /*0x38*/ UnityEngine.UIElements.VisualElement nextDirty;
                /*0x40*/ int hierarchyDepth;
                /*0x44*/ UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtiedValues;
                /*0x48*/ uint dirtyID;
                /*0x50*/ UnityEngine.UIElements.UIR.RenderChainCommand firstCommand;
                /*0x58*/ UnityEngine.UIElements.UIR.RenderChainCommand lastCommand;
                /*0x60*/ UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand;
                /*0x68*/ UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand;
                /*0x70*/ bool isInChain;
                /*0x71*/ bool isHierarchyHidden;
                /*0x72*/ bool localFlipsWinding;
                /*0x73*/ bool localTransformScaleZero;
                /*0x74*/ bool worldFlipsWinding;
                /*0x78*/ UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod;
                /*0x7c*/ int childrenStencilRef;
                /*0x80*/ int childrenMaskDepth;
                /*0x84*/ bool disableNudging;
                /*0x85*/ bool usesLegacyText;
                /*0x88*/ UnityEngine.UIElements.UIR.MeshHandle data;
                /*0x90*/ UnityEngine.UIElements.UIR.MeshHandle closingData;
                /*0x98*/ UnityEngine.Matrix4x4 verticesSpace;
                /*0xd8*/ int displacementUVStart;
                /*0xdc*/ int displacementUVEnd;
                /*0xe0*/ UnityEngine.UIElements.UIR.BMPAlloc transformID;
                /*0xe8*/ UnityEngine.UIElements.UIR.BMPAlloc clipRectID;
                /*0xf0*/ UnityEngine.UIElements.UIR.BMPAlloc opacityID;
                /*0xf8*/ UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID;
                /*0x100*/ UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID;
                /*0x108*/ UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID;
                /*0x110*/ UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID;
                /*0x118*/ UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID;
                /*0x120*/ UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID;
                /*0x128*/ UnityEngine.UIElements.UIR.BMPAlloc tintColorID;
                /*0x130*/ float compositeOpacity;
                /*0x134*/ UnityEngine.Color backgroundColor;
                /*0x148*/ UnityEngine.UIElements.VisualElement prevText;
                /*0x150*/ UnityEngine.UIElements.VisualElement nextText;
                /*0x158*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChainTextEntry> textEntries;
                /*0x160*/ UnityEngine.UIElements.UIR.BasicNode<UnityEngine.UIElements.UIR.TextureEntry> textures;

                static /*0x2aa9228*/ bool AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                static /*0x2aa925c*/ bool InheritsID(UnityEngine.UIElements.UIR.BMPAlloc alloc);
                /*0x2aa9210*/ UnityEngine.UIElements.UIR.RenderChainCommand get_lastClosingOrLastCommand();
            }

            struct RenderChainTextEntry
            {
                /*0x10*/ UnityEngine.UIElements.UIR.RenderChainCommand command;
                /*0x18*/ int firstVertex;
                /*0x1c*/ int vertexCount;
            }

            struct TextureEntry
            {
                /*0x10*/ UnityEngine.Texture source;
                /*0x18*/ UnityEngine.UIElements.TextureId actual;
                /*0x1c*/ bool replaced;
            }

            class LinkedPoolItem<T>
            {
                /*0x0*/ T poolNext;

                LinkedPoolItem();
            }

            class LinkedPool<T>
            {
                /*0x0*/ System.Func<T> m_CreateFunc;
                /*0x0*/ System.Action<T> m_ResetAction;
                /*0x0*/ int m_Limit;
                /*0x0*/ T m_PoolFirst;
                /*0x0*/ int <Count>k__BackingField;

                LinkedPool(System.Func<T> createFunc, System.Action<T> resetAction, int limit);
                int get_Count();
                void set_Count(int value);
                void Clear();
                T Get();
                void Return(T item);
            }

            class BasicNode<T> : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.BasicNode<T>>
            {
                /*0x0*/ UnityEngine.UIElements.UIR.BasicNode<T> next;
                /*0x0*/ T data;

                BasicNode();
                void AppendTo(ref UnityEngine.UIElements.UIR.BasicNode<T> first);
            }

            class BasicNodePool<T> : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.BasicNode<T>>
            {
                static void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node);
                static UnityEngine.UIElements.UIR.BasicNode<T> Create();
                BasicNodePool();
            }

            class MeshBuilder
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker s_VectorGraphics9Slice;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_VectorGraphicsSplitTriangle;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_VectorGraphicsScaleTriangle;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_VectorGraphicsStretch;
                static /*0x20*/ int s_MaxTextMeshVertices;
                static /*0x28*/ ushort[] slicedQuadIndices;
                static /*0x30*/ float[] k_TexCoordSlicesX;
                static /*0x38*/ float[] k_TexCoordSlicesY;
                static /*0x40*/ float[] k_PositionSlicesX;
                static /*0x48*/ float[] k_PositionSlicesY;
                static /*0x50*/ UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge[] s_AllClipEdges;

                static /*0x2ab0f58*/ MeshBuilder();
                static /*0x2aa928c*/ void MakeBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2aa95c8*/ void MakeSolidRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2aaa1b0*/ void MakeTexturedRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage);
                static /*0x2aabbc4*/ UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, int index, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.VertexFlags flags, bool isDynamicColor);
                static /*0x2aabcd4*/ UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, UnityEngine.Vector2 offset);
                static /*0x2aabd0c*/ int LimitTextVertices(int vertexCount, bool logTruncation);
                static /*0x2aabe3c*/ void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.UIR.VertexFlags flags, bool isDynamicColor);
                static /*0x2aac198*/ void MakeText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2aac45c*/ void UpdateText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.Matrix4x4 transform, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 flags, UnityEngine.Color32 opacityPageSettingIndex, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices);
                static /*0x2aaa4c4*/ void MakeQuad(UnityEngine.Rect rcPosition, UnityEngine.Rect rcTexCoord, UnityEngine.Color color, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage);
                static /*0x2aab21c*/ void MakeSlicedQuad(ref UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2aac614*/ void MakeVectorGraphics(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, ref int finalVertexCount, ref int finalIndexCount);
                static /*0x2aac9c4*/ void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, UnityEngine.Rect targetRect, UnityEngine.Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, int settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, ref int finalVertexCount, ref int finalIndexCount);
                static /*0x2aaeb44*/ void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, UnityEngine.Vector4 sliceLTRB, int sliceIndex);
                static /*0x2aaf78c*/ void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB);
                static /*0x2aad9b0*/ void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB, bool stretch, UnityEngine.Color tint, int settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2aae55c*/ UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, UnityEngine.Vector4 clipRectMinMax);
                static /*0x2aae708*/ void RectClip(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts cc, ref int newVertexCount);
                static /*0x2aafa10*/ void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, ushort* it, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, ref ushort nextNewVertex);
                static /*0x2ab056c*/ UnityEngine.Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, float x, float y);
                static /*0x2ab0628*/ UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, float x, float y, UnityEngine.Vector3 uvw);
                static /*0x2ab0b40*/ UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, int e0, int e1, float t);
                static /*0x2ab0aa4*/ float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy);

                struct AllocMeshData
                {
                    /*0x10*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator alloc;
                    /*0x18*/ UnityEngine.Texture texture;
                    /*0x20*/ UnityEngine.UIElements.TextureId svgTexture;
                    /*0x28*/ UnityEngine.Material material;
                    /*0x30*/ UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags;
                    /*0x34*/ UnityEngine.UIElements.UIR.BMPAlloc colorAlloc;

                    /*0x2aac170*/ UnityEngine.UIElements.MeshWriteData Allocate(uint vertexCount, uint indexCount);

                    class Allocator : System.MulticastDelegate
                    {
                        /*0x2ab11d8*/ Allocator(object object, nint method);
                        /*0x2ab129c*/ UnityEngine.UIElements.MeshWriteData Invoke(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    }
                }

                struct ClipCounts
                {
                    /*0x10*/ int firstClippedIndex;
                    /*0x14*/ int firstDegenerateIndex;
                    /*0x18*/ int lastClippedIndex;
                    /*0x1c*/ int clippedTriangles;
                    /*0x20*/ int addedTriangles;
                    /*0x24*/ int degenerateTriangles;
                }

                enum VertexClipEdge
                {
                    None = 0,
                    Left = 1,
                    Top = 2,
                    Right = 4,
                    Bottom = 8,
                }
            }

            class TextureSlotManager
            {
                static /*0x0*/ int k_SlotCount;
                static /*0x8*/ int[] slotIds;
                static /*0x10*/ int textureTableId;
                /*0x10*/ UnityEngine.UIElements.TextureId[] m_Textures;
                /*0x18*/ int[] m_Tickets;
                /*0x20*/ int m_CurrentTicket;
                /*0x24*/ int m_FirstUsedTicket;
                /*0x28*/ UnityEngine.Vector4[] m_GpuTextures;
                /*0x30*/ int <FreeSlots>k__BackingField;
                /*0x38*/ UnityEngine.UIElements.TextureRegistry textureRegistry;

                static /*0x2ab12b0*/ TextureSlotManager();
                /*0x2ab1438*/ TextureSlotManager();
                /*0x2ab15a0*/ void Reset();
                /*0x2ab16cc*/ void StartNewBatch();
                /*0x2ab1738*/ int IndexOf(UnityEngine.UIElements.TextureId id);
                /*0x2ab180c*/ void MarkUsed(int slotIndex);
                /*0x2ab1864*/ int get_FreeSlots();
                /*0x2ab186c*/ void set_FreeSlots(int value);
                /*0x2ab1874*/ int FindOldestSlot();
                /*0x2ab1944*/ void Bind(UnityEngine.UIElements.TextureId id, int slot, UnityEngine.MaterialPropertyBlock mat);
            }

            class Tessellation
            {
                static /*0x0*/ float kEpsilon;
                static /*0x4*/ float kUnusedArc;
                static /*0x8*/ ushort kSubdivisions;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerTessellateRect;
                static /*0x18*/ Unity.Profiling.ProfilerMarker s_MarkerTessellateBorder;
                static /*0x20*/ UnityEngine.UIElements.UIR.Tessellation.Edges[] s_AllEdges;

                static /*0x2ab91d0*/ Tessellation();
                static /*0x2aa9ea8*/ void TessellateRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, bool computeUVs);
                static /*0x2aa971c*/ void TessellateQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2aa934c*/ void TessellateBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, float posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc);
                static /*0x2ab1b5c*/ void TessellateRoundedCorners(ref UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab2d08*/ void TessellateRoundedBorders(ref UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams border, float posZ, UnityEngine.UIElements.MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab3bd0*/ void TessellateRoundedCorner(UnityEngine.Rect rect, UnityEngine.Color32 color, float posZ, UnityEngine.Vector2 radius, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab4220*/ void TessellateRoundedBorder(UnityEngine.Rect rect, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.Vector2 radius, float leftWidth, float topWidth, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab7b2c*/ UnityEngine.Vector2 IntersectLines(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3);
                static /*0x2ab7020*/ int LooseCompare(float a, float b);
                static /*0x2ab7440*/ void TessellateComplexBorderCorner(UnityEngine.Rect rect, UnityEngine.Vector2 radius, float leftWidth, float topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab8420*/ void TessellateQuad(UnityEngine.Rect rect, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab2c1c*/ void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab875c*/ int EdgesCount(UnityEngine.UIElements.UIR.Tessellation.Edges edges);
                static /*0x2ab7c30*/ void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Vector2* offsets, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab8ca4*/ void EncodeStraightArc(ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex center, float radius);
                static /*0x2ab8e2c*/ void ExpandTriangle(ref UnityEngine.Vector3 v0, ref UnityEngine.Vector3 v1, UnityEngine.Vector3 center, float factor);
                static /*0x2ab8780*/ void TessellateQuadSingleEdge(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, UnityEngine.Color32 color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab512c*/ void TessellateStraightBorder(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, float miterOffset, UnityEngine.Color color, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab9018*/ UnityEngine.Vector4 GetInterpolatedCircle(UnityEngine.Vector2 p, ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex v2);
                static /*0x2ab9130*/ void ComputeBarycentricCoordinates(UnityEngine.Vector2 p, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, ref float u, ref float v, ref float w);
                static /*0x2ab49a4*/ void TessellateFilledFan(UnityEngine.Vector2 center, UnityEngine.Vector2 radius, UnityEngine.Vector2 miterOffset, float leftWidth, float topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab70c0*/ void TessellateBorderedFan(UnityEngine.Vector2 center, UnityEngine.Vector2 outerRadius, float leftWidth, float topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, float posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly);
                static /*0x2ab3f14*/ void MirrorVertices(UnityEngine.Rect rect, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal);
                static /*0x2ab4138*/ void FlipWinding(Unity.Collections.NativeSlice<ushort> indices, int indexStart, int indexCount);
                static /*0x2ab29c0*/ void ComputeUVs(UnityEngine.Rect tessellatedRect, UnityEngine.Rect textureRect, UnityEngine.Rect uvRegion, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices);

                enum Edges
                {
                    None = 0,
                    Left = 1,
                    Top = 2,
                    Right = 4,
                    Bottom = 8,
                    All = 15,
                }
            }

            class Allocator2D
            {
                /*0x10*/ UnityEngine.Vector2Int m_MinSize;
                /*0x18*/ UnityEngine.Vector2Int m_MaxSize;
                /*0x20*/ UnityEngine.Vector2Int m_MaxAllocSize;
                /*0x28*/ int m_RowHeightBias;
                /*0x30*/ UnityEngine.UIElements.UIR.Allocator2D.Row[] m_Rows;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> m_Areas;

                static /*0x29e55f0*/ void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize);
                static /*0x29e5860*/ UnityEngine.Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, int rowHeightBias);
                static /*0x29e597c*/ UnityEngine.UIElements.UIR.Allocator2D.Row[] BuildRowArray(int maxRowHeight, int rowHeightBias);
                /*0x29e53d8*/ Allocator2D(UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize, int rowHeightBias);
                /*0x29e5a04*/ bool TryAllocate(int width, int height, ref UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D);
                /*0x29e617c*/ void Free(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D);

                class Area
                {
                    /*0x10*/ UnityEngine.RectInt rect;
                    /*0x20*/ UnityEngine.UIElements.UIR.BestFitAllocator allocator;

                    /*0x29e65f0*/ Area(UnityEngine.RectInt rect);
                }

                class Row : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.Allocator2D.Row>
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.Allocator2D.Row> pool;
                    /*0x18*/ UnityEngine.RectInt rect;
                    /*0x28*/ UnityEngine.UIElements.UIR.Allocator2D.Area area;
                    /*0x30*/ UnityEngine.UIElements.UIR.BestFitAllocator allocator;
                    /*0x38*/ UnityEngine.UIElements.UIR.Alloc alloc;
                    /*0x50*/ UnityEngine.UIElements.UIR.Allocator2D.Row next;

                    static /*0x29e674c*/ Row();
                    static /*0x29e6684*/ UnityEngine.UIElements.UIR.Allocator2D.Row Create();
                    static /*0x29e6724*/ void Reset(UnityEngine.UIElements.UIR.Allocator2D.Row row);
                    /*0x29e66dc*/ Row();
                }

                struct Alloc2D
                {
                    /*0x10*/ UnityEngine.RectInt rect;
                    /*0x20*/ UnityEngine.UIElements.UIR.Allocator2D.Row row;
                    /*0x28*/ UnityEngine.UIElements.UIR.Alloc alloc;

                    /*0x29e6030*/ Alloc2D(UnityEngine.UIElements.UIR.Allocator2D.Row row, UnityEngine.UIElements.UIR.Alloc alloc, int width, int height);
                }
            }

            struct TextCoreSettings : System.IEquatable<UnityEngine.UIElements.UIR.TextCoreSettings>
            {
                /*0x10*/ UnityEngine.Color faceColor;
                /*0x20*/ UnityEngine.Color outlineColor;
                /*0x30*/ float outlineWidth;
                /*0x34*/ UnityEngine.Color underlayColor;
                /*0x44*/ UnityEngine.Vector2 underlayOffset;
                /*0x4c*/ float underlaySoftness;

                /*0x29e687c*/ bool Equals(object obj);
                /*0x29e690c*/ bool Equals(UnityEngine.UIElements.UIR.TextCoreSettings other);
                /*0x29e69f4*/ int GetHashCode();
            }

            class Shaders
            {
                static /*0x0*/ string k_AtlasBlit;
                static /*0x8*/ string k_Editor;
                static /*0x10*/ string k_Runtime;
                static /*0x18*/ string k_RuntimeWorld;
                static /*0x20*/ string k_GraphView;

                static /*0x29e6b8c*/ Shaders();
            }

            class VectorImageRenderInfoPool : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.VectorImageRenderInfo>
            {
                /*0x29e6d38*/ VectorImageRenderInfoPool();

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.VectorImageRenderInfoPool.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_1;

                    static /*0x29e6ec0*/ <>c();
                    /*0x29e6f24*/ <>c();
                    /*0x29e6f2c*/ UnityEngine.UIElements.UIR.VectorImageRenderInfo <.ctor>b__0_0();
                    /*0x29e6fcc*/ void <.ctor>b__0_1(UnityEngine.UIElements.UIR.VectorImageRenderInfo vectorImageInfo);
                }
            }

            class VectorImageRenderInfo : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.VectorImageRenderInfo>
            {
                /*0x18*/ int useCount;
                /*0x20*/ UnityEngine.UIElements.UIR.GradientRemap firstGradientRemap;
                /*0x28*/ UnityEngine.UIElements.UIR.Alloc gradientSettingsAlloc;

                /*0x29e6f84*/ VectorImageRenderInfo();
                /*0x29e6fec*/ void Reset();
            }

            class GradientRemapPool : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.GradientRemap>
            {
                /*0x29e6ffc*/ GradientRemapPool();

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.GradientRemapPool.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_1;

                    static /*0x29e7184*/ <>c();
                    /*0x29e71e8*/ <>c();
                    /*0x29e71f0*/ UnityEngine.UIElements.UIR.GradientRemap <.ctor>b__0_0();
                    /*0x29e7290*/ void <.ctor>b__0_1(UnityEngine.UIElements.UIR.GradientRemap gradientRemap);
                }
            }

            class GradientRemap : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.GradientRemap>
            {
                /*0x18*/ int origIndex;
                /*0x1c*/ int destIndex;
                /*0x20*/ UnityEngine.RectInt location;
                /*0x30*/ UnityEngine.UIElements.UIR.GradientRemap next;
                /*0x38*/ UnityEngine.UIElements.TextureId atlas;

                /*0x29e7248*/ GradientRemap();
                /*0x29e72a4*/ void Reset();
            }

            class VectorImageManager : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.VectorImageManager> instances;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_MarkerRegister;
                static /*0x10*/ Unity.Profiling.ProfilerMarker s_MarkerUnregister;
                /*0x10*/ UnityEngine.UIElements.AtlasBase m_Atlas;
                /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.VectorImage, UnityEngine.UIElements.UIR.VectorImageRenderInfo> m_Registered;
                /*0x20*/ UnityEngine.UIElements.UIR.VectorImageRenderInfoPool m_RenderInfoPool;
                /*0x28*/ UnityEngine.UIElements.UIR.GradientRemapPool m_GradientRemapPool;
                /*0x30*/ UnityEngine.UIElements.UIR.GradientSettingsAtlas m_GradientSettingsAtlas;
                /*0x38*/ bool m_LoggedExhaustedSettingsAtlas;
                /*0x39*/ bool <disposed>k__BackingField;

                static /*0x29e7bdc*/ VectorImageManager();
                /*0x29e7320*/ VectorImageManager(UnityEngine.UIElements.AtlasBase atlas);
                /*0x29e730c*/ UnityEngine.Texture2D get_atlas();
                /*0x29e74dc*/ bool get_disposed();
                /*0x29e74e4*/ void set_disposed(bool value);
                /*0x29e74f0*/ void Dispose();
                /*0x29e755c*/ void Dispose(bool disposing);
                /*0x29e7674*/ void Commit();
                /*0x29e76a4*/ UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context);
                /*0x29e77a8*/ UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context);
            }

            struct Transform3x4
            {
                /*0x10*/ UnityEngine.Vector4 v0;
                /*0x20*/ UnityEngine.Vector4 v1;
                /*0x30*/ UnityEngine.Vector4 v2;
            }

            class MeshHandle : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.MeshHandle>
            {
                /*0x18*/ UnityEngine.UIElements.UIR.Alloc allocVerts;
                /*0x30*/ UnityEngine.UIElements.UIR.Alloc allocIndices;
                /*0x48*/ uint triangleCount;
                /*0x50*/ UnityEngine.UIElements.UIR.Page allocPage;
                /*0x58*/ uint allocTime;
                /*0x5c*/ uint updateAllocID;

                /*0x29e7ce4*/ MeshHandle();
            }

            class UIRenderDevice : System.IDisposable
            {
                static /*0x0*/ System.Collections.Generic.LinkedList<UnityEngine.UIElements.UIR.UIRenderDevice.DeviceToFree> m_DeviceFreeQueue;
                static /*0x8*/ int m_ActiveDeviceCount;
                static /*0xc*/ bool m_SubscribedToNotifications;
                static /*0xd*/ bool m_SynchronousFree;
                static /*0x10*/ int s_FontTexPropID;
                static /*0x14*/ int s_FontTexSDFScaleID;
                static /*0x18*/ int s_GradientSettingsTexID;
                static /*0x1c*/ int s_ShaderInfoTexID;
                static /*0x20*/ int s_TransformsPropID;
                static /*0x24*/ int s_ClipRectsPropID;
                static /*0x28*/ int s_ClipSpaceParamsID;
                static /*0x30*/ Unity.Profiling.ProfilerMarker s_MarkerAllocate;
                static /*0x38*/ Unity.Profiling.ProfilerMarker s_MarkerFree;
                static /*0x40*/ Unity.Profiling.ProfilerMarker s_MarkerAdvanceFrame;
                static /*0x48*/ Unity.Profiling.ProfilerMarker s_MarkerFence;
                static /*0x50*/ Unity.Profiling.ProfilerMarker s_MarkerBeforeDraw;
                static /*0x58*/ System.Nullable<bool> s_VertexTexturingIsAvailable;
                static /*0x5a*/ System.Nullable<bool> s_ShaderModelIs35;
                static /*0x60*/ UnityEngine.Texture2D s_DefaultShaderInfoTexFloat;
                static /*0x68*/ UnityEngine.Texture2D s_DefaultShaderInfoTexARGB8;
                /*0x10*/ bool m_MockDevice;
                /*0x18*/ nint m_DefaultStencilState;
                /*0x20*/ nint m_VertexDecl;
                /*0x28*/ UnityEngine.UIElements.UIR.Page m_FirstPage;
                /*0x30*/ uint m_NextPageVertexCount;
                /*0x34*/ uint m_LargeMeshVertexCount;
                /*0x38*/ float m_IndexToVertexCountRatio;
                /*0x40*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToFree>> m_DeferredFrees;
                /*0x48*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate>> m_Updates;
                /*0x50*/ uint[] m_Fences;
                /*0x58*/ UnityEngine.MaterialPropertyBlock m_StandardMatProps;
                /*0x60*/ uint m_FrameIndex;
                /*0x64*/ uint m_NextUpdateID;
                /*0x68*/ UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics m_DrawStats;
                /*0x90*/ UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.MeshHandle> m_MeshHandles;
                /*0x98*/ UnityEngine.UIElements.UIR.DrawParams m_DrawParams;
                /*0xa0*/ UnityEngine.UIElements.UIR.TextureSlotManager m_TextureSlotManager;
                /*0xa8*/ uint <maxVerticesPerPage>k__BackingField;
                /*0xac*/ bool <breakBatches>k__BackingField;
                /*0xad*/ bool <disposed>k__BackingField;

                static /*0x29e7d48*/ UIRenderDevice();
                static /*0x29e8810*/ UnityEngine.Texture2D get_defaultShaderInfoTexFloat();
                static /*0x29e8ba4*/ UnityEngine.Texture2D get_defaultShaderInfoTexARGB8();
                static /*0x29e8e70*/ bool get_vertexTexturingIsAvailable();
                static /*0x29e9054*/ bool get_shaderModelIs35();
                static /*0x29ebb74*/ UnityEngine.Vector4 GetClipSpaceParams();
                static Unity.Collections.NativeSlice<T> PtrToSlice<T>(void* p, int count);
                static /*0x29eedc0*/ void PrepareForGfxDeviceRecreate();
                static /*0x29eef48*/ void WrapUpGfxDeviceRecreate();
                static /*0x29eefa8*/ void FlushAllPendingDeviceDisposes();
                static /*0x29e984c*/ void ProcessDeviceFreeQueue();
                static /*0x29ef038*/ void OnEngineUpdateGlobal();
                static /*0x29ef084*/ void OnFlushPendingResources();
                /*0x29e8100*/ UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity);
                /*0x29e8108*/ UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice);
                /*0x29e7d2c*/ uint get_maxVerticesPerPage();
                /*0x29e7d34*/ bool get_breakBatches();
                /*0x29e7d3c*/ void set_breakBatches(bool value);
                /*0x29e9238*/ void InitVertexDeclaration();
                /*0x29e94a0*/ void CompleteCreation();
                /*0x29e9644*/ bool get_fullyCreated();
                /*0x29e9654*/ bool get_disposed();
                /*0x29e965c*/ void set_disposed(bool value);
                /*0x29e9668*/ void Dispose();
                /*0x29e96d4*/ void Dispose(bool disposing);
                /*0x29e9be8*/ UnityEngine.UIElements.UIR.MeshHandle Allocate(uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, ref ushort indexOffset);
                /*0x29ea2dc*/ void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, uint vertexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData);
                /*0x29eaba8*/ void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, ref ushort indexOffset);
                /*0x29ead40*/ void UpdateCopyBackIndices(UnityEngine.UIElements.UIR.MeshHandle mesh, bool copyBackIndices);
                /*0x29eae5c*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(UnityEngine.UIElements.UIR.MeshHandle mesh);
                /*0x29eaed0*/ bool TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.Alloc va, ref UnityEngine.UIElements.UIR.Alloc ia, bool shortLived);
                /*0x29e9ca8*/ void Allocate(UnityEngine.UIElements.UIR.MeshHandle meshHandle, uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, bool shortLived);
                /*0x29ea4a4*/ void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle mesh, uint vertexCount, uint indexCount, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertexData, ref Unity.Collections.NativeSlice<ushort> indexData, ref ushort indexOffset, ref UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices);
                /*0x29eb328*/ void Free(UnityEngine.UIElements.UIR.MeshHandle mesh);
                /*0x29ebc3c*/ void OnFrameRenderingBegin();
                /*0x29ec694*/ void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand cmd, int textureSlot, UnityEngine.Material newMat, bool newMatDiffers, bool newFontDiffers, ref UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState st);
                /*0x29ec8b8*/ void ApplyBatchState(ref UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState st, bool allowMaterialChange);
                /*0x29eca3c*/ void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand head, UnityEngine.Material initialMat, UnityEngine.Material defaultMat, UnityEngine.Texture gradientSettings, UnityEngine.Texture shaderInfo, float pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, UnityEngine.MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref System.Exception immediateException);
                /*0x29eeb24*/ void UpdateFenceValue();
                /*0x29edd20*/ void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, UnityEngine.UIElements.UIR.Page curPage);
                void DrawRanges<I, T>(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges);
                /*0x29eebf0*/ void WaitOnCpuFence(uint fence);
                /*0x29ebce0*/ void AdvanceFrame();
                /*0x29eec78*/ void PruneUnusedPages();
                /*0x29ef020*/ UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics GatherDrawStatistics();

                struct AllocToUpdate
                {
                    /*0x10*/ uint id;
                    /*0x14*/ uint allocTime;
                    /*0x18*/ UnityEngine.UIElements.UIR.MeshHandle meshHandle;
                    /*0x20*/ UnityEngine.UIElements.UIR.Alloc permAllocVerts;
                    /*0x38*/ UnityEngine.UIElements.UIR.Alloc permAllocIndices;
                    /*0x50*/ UnityEngine.UIElements.UIR.Page permPage;
                    /*0x58*/ bool copyBackIndices;
                }

                struct AllocToFree
                {
                    /*0x10*/ UnityEngine.UIElements.UIR.Alloc alloc;
                    /*0x28*/ UnityEngine.UIElements.UIR.Page page;
                    /*0x30*/ bool vertices;
                }

                struct DeviceToFree
                {
                    /*0x10*/ uint handle;
                    /*0x18*/ UnityEngine.UIElements.UIR.Page page;

                    /*0x29e9820*/ void Dispose();
                }

                struct EvaluationState
                {
                    /*0x10*/ UnityEngine.MaterialPropertyBlock stateMatProps;
                    /*0x18*/ UnityEngine.Material defaultMat;
                    /*0x20*/ UnityEngine.UIElements.UIR.State curState;
                    /*0x40*/ UnityEngine.UIElements.UIR.Page curPage;
                    /*0x48*/ bool mustApplyMaterial;
                    /*0x49*/ bool mustApplyCommonBlock;
                    /*0x4a*/ bool mustApplyStateBlock;
                    /*0x4b*/ bool mustApplyStencil;
                }

                struct DrawStatistics
                {
                    /*0x10*/ int currentFrameIndex;
                    /*0x14*/ uint totalIndices;
                    /*0x18*/ uint commandCount;
                    /*0x1c*/ uint drawCommandCount;
                    /*0x20*/ uint materialSetCount;
                    /*0x24*/ uint drawRangeCount;
                    /*0x28*/ uint drawRangeCallCount;
                    /*0x2c*/ uint immediateDraws;
                    /*0x30*/ uint stencilRefChanges;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.UIElements.UIR.UIRenderDevice.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.UIElements.UIR.MeshHandle> <>9__53_0;
                    static /*0x10*/ System.Action<UnityEngine.UIElements.UIR.MeshHandle> <>9__53_1;

                    static /*0x29ef0e0*/ <>c();
                    /*0x29ef144*/ <>c();
                    /*0x29ef14c*/ UnityEngine.UIElements.UIR.MeshHandle <.ctor>b__53_0();
                    /*0x29ef1a4*/ void <.ctor>b__53_1(UnityEngine.UIElements.UIR.MeshHandle mh);
                }
            }

            struct Alloc
            {
                /*0x10*/ uint start;
                /*0x14*/ uint size;
                /*0x18*/ object handle;
                /*0x20*/ bool shortLived;
            }

            class BestFitAllocator
            {
                /*0x10*/ uint <totalSize>k__BackingField;
                /*0x18*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block m_FirstBlock;
                /*0x20*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block m_FirstAvailableBlock;
                /*0x28*/ UnityEngine.UIElements.UIR.BestFitAllocator.BlockPool m_BlockPool;
                /*0x30*/ uint m_HighWatermark;

                /*0x29e60d4*/ BestFitAllocator(uint size);
                /*0x29ef298*/ uint get_totalSize();
                /*0x29e65e8*/ uint get_highWatermark();
                /*0x29e5e9c*/ UnityEngine.UIElements.UIR.Alloc Allocate(uint size);
                /*0x29e638c*/ void Free(UnityEngine.UIElements.UIR.Alloc alloc);
                /*0x29ef3d8*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block CoalesceBlockWithPrevious(UnityEngine.UIElements.UIR.BestFitAllocator.Block block);
                /*0x29ef2a0*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block BestFitFindAvailableBlock(uint size);
                /*0x29ef2ec*/ void SplitBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block, uint size);

                class BlockPool : UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.BestFitAllocator.Block>
                {
                    static /*0x29ef4e0*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block CreateBlock();
                    static /*0x29ef580*/ void ResetBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block);
                    /*0x29ef1a8*/ BlockPool();
                }

                class Block : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.BestFitAllocator.Block>
                {
                    /*0x18*/ uint start;
                    /*0x1c*/ uint end;
                    /*0x20*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block prev;
                    /*0x28*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block next;
                    /*0x30*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block prevAvailable;
                    /*0x38*/ UnityEngine.UIElements.UIR.BestFitAllocator.Block nextAvailable;
                    /*0x40*/ bool allocated;

                    /*0x29ef538*/ Block();
                    /*0x29ef2e0*/ uint get_size();
                }
            }

            class GPUBufferAllocator
            {
                /*0x10*/ UnityEngine.UIElements.UIR.BestFitAllocator m_Low;
                /*0x18*/ UnityEngine.UIElements.UIR.BestFitAllocator m_High;

                /*0x29ef584*/ GPUBufferAllocator(uint maxSize);
                /*0x29eafd4*/ UnityEngine.UIElements.UIR.Alloc Allocate(uint size, bool shortLived);
                /*0x29eb110*/ void Free(UnityEngine.UIElements.UIR.Alloc alloc);
                /*0x29ef650*/ bool get_isEmpty();
                /*0x29ef618*/ bool HighLowCollide();
            }

            class Page : System.IDisposable
            {
                /*0x10*/ bool <disposed>k__BackingField;
                /*0x18*/ UnityEngine.UIElements.UIR.Page.DataSet<UnityEngine.UIElements.Vertex> vertices;
                /*0x20*/ UnityEngine.UIElements.UIR.Page.DataSet<ushort> indices;
                /*0x28*/ UnityEngine.UIElements.UIR.Page next;
                /*0x30*/ int framesEmpty;

                /*0x29eb194*/ Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage);
                /*0x29ef68c*/ bool get_disposed();
                /*0x29ef694*/ void set_disposed(bool value);
                /*0x29eed54*/ void Dispose();
                /*0x29ef6a0*/ void Dispose(bool disposing);
                /*0x29eb2e0*/ bool get_isEmpty();

                class DataSet<T> : System.IDisposable
                {
                    /*0x0*/ bool <disposed>k__BackingField;
                    /*0x0*/ UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> gpuData;
                    /*0x0*/ Unity.Collections.NativeArray<T> cpuData;
                    /*0x0*/ Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> updateRanges;
                    /*0x0*/ UnityEngine.UIElements.UIR.GPUBufferAllocator allocator;
                    /*0x0*/ uint m_UpdateRangePoolSize;
                    /*0x0*/ uint m_ElemStride;
                    /*0x0*/ uint m_UpdateRangeMin;
                    /*0x0*/ uint m_UpdateRangeMax;
                    /*0x0*/ uint m_UpdateRangesEnqueued;
                    /*0x0*/ uint m_UpdateRangesBatchStart;
                    /*0x0*/ bool m_UpdateRangesSaturated;

                    DataSet(UnityEngine.UIElements.UIR.Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer);
                    bool get_disposed();
                    void set_disposed(bool value);
                    void Dispose();
                    void Dispose(bool disposing);
                    void RegisterUpdate(uint start, uint size);
                    bool HasMappedBufferRange();
                    void SendUpdates();
                    void SendFullRange();
                    void SendPartialRanges();
                    void ResetUpdateState();
                }
            }

            enum VertexFlags
            {
                IsSolid = 0,
                IsText = 1,
                IsTextured = 2,
                IsDynamic = 3,
                IsSvgGradients = 4,
                LastType = 10,
                IsGraphViewEdge = 10,
            }

            struct State
            {
                /*0x10*/ UnityEngine.Material material;
                /*0x18*/ UnityEngine.Texture font;
                /*0x20*/ float fontTexSDFScale;
                /*0x24*/ UnityEngine.UIElements.TextureId texture;
                /*0x28*/ int stencilRef;
            }

            enum CommandType
            {
                Draw = 0,
                ImmediateCull = 1,
                Immediate = 2,
                PushView = 3,
                PopView = 4,
                PushScissor = 5,
                PopScissor = 6,
                PushRenderTexture = 7,
                PopRenderTexture = 8,
                BlitToPreviousRT = 9,
                PushDefaultMaterial = 10,
                PopDefaultMaterial = 11,
            }

            class DrawParams
            {
                static /*0x0*/ UnityEngine.Rect k_UnlimitedRect;
                static /*0x10*/ UnityEngine.Rect k_FullNormalizedRect;
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.Matrix4x4> view;
                /*0x18*/ System.Collections.Generic.Stack<UnityEngine.Rect> scissor;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.RenderTexture> renderTexture;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Material> defaultMaterial;

                static /*0x29ef730*/ DrawParams();
                /*0x29e86b8*/ DrawParams();
                /*0x29edb54*/ void Reset();
            }

            class RenderChainCommand : UnityEngine.UIElements.UIR.LinkedPoolItem<UnityEngine.UIElements.UIR.RenderChainCommand>
            {
                static /*0x0*/ int k_ID_MainTex;
                static /*0x8*/ Unity.Profiling.ProfilerMarker s_ImmediateOverheadMarker;
                /*0x18*/ UnityEngine.UIElements.VisualElement owner;
                /*0x20*/ UnityEngine.UIElements.UIR.RenderChainCommand prev;
                /*0x28*/ UnityEngine.UIElements.UIR.RenderChainCommand next;
                /*0x30*/ bool closing;
                /*0x34*/ UnityEngine.UIElements.UIR.CommandType type;
                /*0x38*/ UnityEngine.UIElements.UIR.State state;
                /*0x58*/ UnityEngine.UIElements.UIR.MeshHandle mesh;
                /*0x60*/ int indexOffset;
                /*0x64*/ int indexCount;
                /*0x68*/ System.Action callback;

                static /*0x29eff74*/ RenderChainCommand();
                static /*0x29efc04*/ UnityEngine.Rect CombineScissorRects(UnityEngine.Rect r0, UnityEngine.Rect r1);
                static /*0x29ef800*/ UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect rect, float pixelsPerPoint);
                /*0x29eff2c*/ RenderChainCommand();
                /*0x29ef7dc*/ void Reset();
                /*0x29edf68*/ void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams drawParams, float pixelsPerPoint, ref System.Exception immediateException);
                /*0x29efdbc*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture destination, float depth);
            }

            namespace Implementation
            {
                enum ClipMethod
                {
                    Undetermined = 0,
                    NotClipped = 1,
                    Scissor = 2,
                    ShaderDiscard = 3,
                    Stencil = 4,
                }

                class RenderEvents
                {
                    static /*0x0*/ float VisibilityTreshold;

                    static /*0x29f33d4*/ RenderEvents();
                    static /*0x29f001c*/ void ProcessOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f05e4*/ void ProcessOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f0a4c*/ void ProcessOnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f0ca0*/ void ProcessOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f10e4*/ void ProcessOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f1608*/ void ProcessRegenText(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter painter, UnityEngine.UIElements.UIR.UIRenderDevice device, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f1664*/ UnityEngine.Matrix4x4 GetTransformIDTransformInfo(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f17b4*/ UnityEngine.Vector4 GetClipRectIDClipInfo(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f1970*/ uint DepthFirstOnChildAdded(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, int index, bool resetState);
                    static /*0x29f28c4*/ uint DepthFirstOnChildRemoving(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f0108*/ void DepthFirstOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UnityEngine.UIElements.UIR.UIRenderDevice device, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f06c8*/ void DepthFirstOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, float parentCompositeOpacity, UnityEngine.UIElements.VisualElement ve, uint dirtyID, bool hierarchical, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats, bool isDoingFullVertexRegeneration);
                    static /*0x29f0ad4*/ void OnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f0d60*/ void DepthFirstOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, uint dirtyID, UnityEngine.UIElements.UIR.UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f12a8*/ void DepthFirstOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29f2e2c*/ bool UpdateTextCoreSettings(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f11e8*/ bool IsElementHierarchyHidden(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f1fcc*/ UnityEngine.UIElements.VisualElement GetLastDeepestChild(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f2d20*/ UnityEngine.UIElements.UIR.Implementation.ClipMethod DetermineSelfClipMethod(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f1e98*/ bool UpdateLocalFlipsWinding(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f337c*/ void UpdateWorldFlipsWinding(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f3204*/ void UpdateZeroScaling(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f204c*/ bool NeedsTransformID(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f2088*/ bool NeedsColorID(UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f20a8*/ bool InitColorIDs(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                    static /*0x29f24ec*/ void SetColorValues(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                }

                class UIRStylePainter : UnityEngine.UIElements.IStylePainter, System.IDisposable
                {
                    /*0x10*/ UnityEngine.UIElements.UIR.RenderChain m_Owner;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> m_Entries;
                    /*0x20*/ UnityEngine.UIElements.AtlasBase m_Atlas;
                    /*0x28*/ UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager;
                    /*0x30*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry m_CurrentEntry;
                    /*0x90*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo m_ClosingInfo;
                    /*0xc8*/ int m_MaskDepth;
                    /*0xcc*/ int m_StencilRef;
                    /*0xd0*/ UnityEngine.UIElements.UIR.BMPAlloc m_ClipRectID;
                    /*0xd8*/ int m_SVGBackgroundEntryIndex;
                    /*0xe0*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<UnityEngine.UIElements.Vertex> m_VertsPool;
                    /*0x108*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<ushort> m_IndicesPool;
                    /*0x130*/ System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool;
                    /*0x138*/ int m_NextMeshWriteDataPoolItem;
                    /*0x140*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate;
                    /*0x148*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate;
                    /*0x150*/ UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate;
                    /*0x158*/ UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField;
                    /*0x160*/ UnityEngine.UIElements.VisualElement <currentElement>k__BackingField;
                    /*0x168*/ int <totalVertices>k__BackingField;
                    /*0x16c*/ int <totalIndices>k__BackingField;
                    /*0x170*/ bool <disposed>k__BackingField;

                    /*0x29f3df8*/ UIRStylePainter(UnityEngine.UIElements.UIR.RenderChain renderChain);
                    /*0x29f3424*/ UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData();
                    /*0x29f3544*/ UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    /*0x29f3600*/ UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    /*0x29f3ae4*/ UnityEngine.UIElements.MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData allocatorData);
                    /*0x29f4160*/ UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext();
                    /*0x29f4168*/ UnityEngine.UIElements.VisualElement get_currentElement();
                    /*0x29f4170*/ void set_currentElement(UnityEngine.UIElements.VisualElement value);
                    /*0x29f4178*/ System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries();
                    /*0x29f4180*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo get_closingInfo();
                    /*0x29f419c*/ int get_totalVertices();
                    /*0x29f41a4*/ void set_totalVertices(int value);
                    /*0x29f41ac*/ int get_totalIndices();
                    /*0x29f41b4*/ void set_totalIndices(int value);
                    /*0x29f41bc*/ bool get_disposed();
                    /*0x29f41c4*/ void set_disposed(bool value);
                    /*0x29f41d0*/ void Dispose();
                    /*0x29f4234*/ void Dispose(bool disposing);
                    /*0x29f42b8*/ void Begin(UnityEngine.UIElements.VisualElement ve);
                    /*0x29f47c8*/ void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd);
                    /*0x29f483c*/ void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<ushort> indices, int indexOffset);
                    /*0x29f3af4*/ UnityEngine.UIElements.MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, UnityEngine.UIElements.TextureId texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags);
                    /*0x29f3614*/ UnityEngine.UIElements.MeshWriteData DrawMesh(int vertexCount, int indexCount, UnityEngine.Texture texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags);
                    /*0x29f48d8*/ void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                    /*0x29f4a10*/ void DrawTextNative(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                    /*0x29f4e48*/ void DrawTextCore(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                    /*0x29f5470*/ void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x29f61c8*/ void DrawBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams);
                    /*0x29f62a8*/ void DrawImmediate(System.Action callback, bool cullingEnabled);
                    /*0x29f6424*/ UnityEngine.UIElements.VisualElement get_visualElement();
                    /*0x29f642c*/ void DrawVisualElementBackground();
                    /*0x29f7264*/ void DrawVisualElementBorder();
                    /*0x29f7bd8*/ void ApplyVisualElementClipping();
                    /*0x29f8bb4*/ ushort[] AdjustSpriteWinding(UnityEngine.Vector2[] vertices, ushort[] indices);
                    /*0x29f5b70*/ void DrawSprite(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x29f570c*/ void DrawVectorImage(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x29f8ed4*/ void Reset();
                    /*0x29f8fb8*/ void ValidateMeshWriteData();
                    /*0x29f8198*/ void GenerateStencilClipEntryForRoundedRectBackground();
                    /*0x29f7e24*/ void GenerateStencilClipEntryForSVGBackground();

                    struct Entry
                    {
                        /*0x10*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices;
                        /*0x20*/ Unity.Collections.NativeSlice<ushort> indices;
                        /*0x30*/ UnityEngine.Material material;
                        /*0x38*/ UnityEngine.Texture custom;
                        /*0x40*/ UnityEngine.Texture font;
                        /*0x48*/ float fontTexSDFScale;
                        /*0x4c*/ UnityEngine.UIElements.TextureId texture;
                        /*0x50*/ UnityEngine.UIElements.UIR.RenderChainCommand customCommand;
                        /*0x58*/ UnityEngine.UIElements.UIR.BMPAlloc clipRectID;
                        /*0x60*/ UnityEngine.UIElements.UIR.VertexFlags addFlags;
                        /*0x64*/ bool uvIsDisplacement;
                        /*0x65*/ bool isTextEntry;
                        /*0x66*/ bool isClipRegisterEntry;
                        /*0x68*/ int stencilRef;
                        /*0x6c*/ int maskDepth;
                    }

                    struct ClosingInfo
                    {
                        /*0x10*/ bool needsClosing;
                        /*0x11*/ bool popViewMatrix;
                        /*0x12*/ bool popScissorClip;
                        /*0x13*/ bool blitAndPopRenderTexture;
                        /*0x14*/ bool PopDefaultMaterial;
                        /*0x18*/ UnityEngine.UIElements.UIR.RenderChainCommand clipUnregisterDrawCommand;
                        /*0x20*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> clipperRegisterVertices;
                        /*0x30*/ Unity.Collections.NativeSlice<ushort> clipperRegisterIndices;
                        /*0x40*/ int clipperRegisterIndexOffset;
                        /*0x44*/ int maskStencilRef;
                    }

                    struct TempDataAlloc<T> : System.IDisposable
                    {
                        /*0x0*/ int maxPoolElemCount;
                        /*0x0*/ Unity.Collections.NativeArray<T> pool;
                        /*0x0*/ System.Collections.Generic.List<Unity.Collections.NativeArray<T>> excess;
                        /*0x0*/ uint takenFromPool;

                        TempDataAlloc(int maxPoolElems);
                        void Dispose();
                        Unity.Collections.NativeSlice<T> Alloc(uint count);
                        void SessionDone();
                    }
                }

                class UIRTextUpdatePainter : UnityEngine.UIElements.IStylePainter, System.IDisposable
                {
                    /*0x10*/ UnityEngine.UIElements.VisualElement m_CurrentElement;
                    /*0x18*/ int m_TextEntryIndex;
                    /*0x20*/ Unity.Collections.NativeArray<UnityEngine.UIElements.Vertex> m_DudVerts;
                    /*0x30*/ Unity.Collections.NativeArray<ushort> m_DudIndices;
                    /*0x40*/ Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_MeshDataVerts;
                    /*0x50*/ UnityEngine.Color32 m_XFormClipPages;
                    /*0x54*/ UnityEngine.Color32 m_IDs;
                    /*0x58*/ UnityEngine.Color32 m_Flags;
                    /*0x5c*/ UnityEngine.Color32 m_OpacityColorPages;
                    /*0x60*/ UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField;

                    /*0x29f94b4*/ UIRTextUpdatePainter();
                    /*0x29f94ac*/ UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext();
                    /*0x29f9524*/ void Begin(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device);
                    /*0x29f9768*/ void End();
                    /*0x29f97f4*/ void Dispose();
                    /*0x29f98b8*/ void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams);
                    /*0x29f98bc*/ void DrawImmediate(System.Action callback, bool cullingEnabled);
                    /*0x29f98c0*/ void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, float pixelsPerPoint);
                }

                class CommandGenerator
                {
                    static /*0x0*/ Unity.Profiling.ProfilerMarker k_ConvertEntriesToCommandsMarker;
                    static /*0x8*/ Unity.Profiling.ProfilerMarker k_NudgeVerticesMarker;
                    static /*0x10*/ Unity.Profiling.ProfilerMarker k_ComputeTransformMatrixMarker;
                    static /*0x18*/ UnityEngine.Material s_blitMaterial_LinearToGamma;
                    static /*0x20*/ UnityEngine.Material s_blitMaterial_GammaToLinear;
                    static /*0x28*/ UnityEngine.Material s_blitMaterial_NoChange;
                    static /*0x30*/ UnityEngine.Shader s_blitShader;

                    static /*0x29fd1f4*/ CommandGenerator();
                    static /*0x29f9c28*/ void GetVerticesTransformInfo(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.Matrix4x4 transform);
                    static /*0x29f9db4*/ void ComputeTransformMatrix(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement ancestor, ref UnityEngine.Matrix4x4 result);
                    static /*0x29f9ee0*/ bool IsParentOrAncestorOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement child);
                    static /*0x29f9f5c*/ UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo PaintElement(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29fc8c4*/ UnityEngine.Material CreateBlitShader(float colorConversion);
                    static /*0x29fc53c*/ UnityEngine.Material GetBlitMaterial(UnityEngine.UIElements.VisualElement.RenderTargetMode mode);
                    static /*0x29fcacc*/ void ClosePaintElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo closingInfo, UnityEngine.UIElements.UIR.RenderChain renderChain, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29fb78c*/ void UpdateOrAllocate(ref UnityEngine.UIElements.UIR.MeshHandle data, int vertexCount, int indexCount, UnityEngine.UIElements.UIR.UIRenderDevice device, ref Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> verts, ref Unity.Collections.NativeSlice<ushort> indices, ref ushort indexOffset, ref UnityEngine.UIElements.UIR.ChainBuilderStats stats);
                    static /*0x29fbcb8*/ void CopyTransformVertsPos(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, bool isText, float textureId);
                    static /*0x29fba48*/ void CopyTransformVertsPosAndVec(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, bool isText, float textureId);
                    static /*0x29fbfcc*/ void CopyTriangleIndicesFlipWindingOrder(Unity.Collections.NativeSlice<ushort> source, Unity.Collections.NativeSlice<ushort> target, int indexOffset);
                    static /*0x29fbf00*/ void CopyTriangleIndices(Unity.Collections.NativeSlice<ushort> source, Unity.Collections.NativeSlice<ushort> target, int indexOffset);
                    static /*0x29fcc5c*/ bool NudgeVerticesToNewSpace(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device);
                    static /*0x29fcf14*/ void DoNudgeVertices(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.MeshHandle mesh, ref UnityEngine.Matrix4x4 nudgeTransform);
                    static /*0x29fc170*/ UnityEngine.UIElements.UIR.RenderChainCommand InjectMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdPrev, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, int indexCount, int indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, int stencilRef);
                    static /*0x29fc7dc*/ UnityEngine.UIElements.UIR.RenderChainCommand InjectClosingMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdPrev, ref UnityEngine.UIElements.UIR.RenderChainCommand cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, int indexCount, int indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, int stencilRef);
                    static /*0x29fb888*/ void FindCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x29fc2e8*/ void FindClosingCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x29fc250*/ void InjectCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x29fc454*/ void InjectClosingCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, ref UnityEngine.UIElements.UIR.RenderChainCommand prev, ref UnityEngine.UIElements.UIR.RenderChainCommand next);
                    static /*0x29fb454*/ void ResetCommands(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve);
                }
            }
        }

        namespace Experimental
        {
            class Easing
            {
                static /*0x29fd2e0*/ float Linear(float t);
                static /*0x29fd2e4*/ float InSine(float t);
                static /*0x29fd310*/ float OutSine(float t);
                static /*0x29fd320*/ float InOutSine(float t);
                static /*0x29fd354*/ float InQuad(float t);
                static /*0x29fd35c*/ float OutQuad(float t);
                static /*0x29fd36c*/ float InOutQuad(float t);
                static /*0x29fd3ac*/ float InCubic(float t);
                static /*0x29fd3bc*/ float OutCubic(float t);
                static /*0x29fd418*/ float InOutCubic(float t);
                static /*0x29fd3b4*/ float InPower(float t, int power);
                static /*0x29fd3e0*/ float OutPower(float t, int power);
                static /*0x29fd460*/ float InOutPower(float t, int power);
                static /*0x29fd4c8*/ float InBounce(float t);
                static /*0x29fd4ec*/ float OutBounce(float t);
                static /*0x29fd5a4*/ float InOutBounce(float t);
                static /*0x29fd5f8*/ float InElastic(float t);
                static /*0x29fd670*/ float OutElastic(float t);
                static /*0x29fd6e8*/ float InOutElastic(float t);
                static /*0x29fd7ec*/ float InBack(float t);
                static /*0x29fd810*/ float OutBack(float t);
                static /*0x29fd840*/ float InOutBack(float t);
                static /*0x29fd8bc*/ float InCirc(float t);
                static /*0x29fd8dc*/ float OutCirc(float t);
                static /*0x29fd8f8*/ float InOutCirc(float t);
            }

            struct StyleValues
            {
                /*0x10*/ UnityEngine.UIElements.StyleValueCollection m_StyleValues;

                /*0x29fd940*/ void set_top(float value);
                /*0x29fd9d0*/ void set_left(float value);
                /*0x29fd9dc*/ void set_width(float value);
                /*0x29fd9e8*/ void set_height(float value);
                /*0x29fd9f4*/ void set_right(float value);
                /*0x29fda00*/ void set_bottom(float value);
                /*0x29fda0c*/ void set_color(UnityEngine.Color value);
                /*0x29fda98*/ void set_backgroundColor(UnityEngine.Color value);
                /*0x29fdaa0*/ void set_unityBackgroundImageTintColor(UnityEngine.Color value);
                /*0x29fdaac*/ void set_borderColor(UnityEngine.Color value);
                /*0x29fdab8*/ void set_marginLeft(float value);
                /*0x29fdac4*/ void set_marginTop(float value);
                /*0x29fdad0*/ void set_marginRight(float value);
                /*0x29fdadc*/ void set_marginBottom(float value);
                /*0x29fdae8*/ void set_paddingLeft(float value);
                /*0x29fdaf4*/ float get_paddingTop();
                /*0x29fdb9c*/ void set_paddingTop(float value);
                /*0x29fdba8*/ void set_paddingRight(float value);
                /*0x29fdbb4*/ void set_paddingBottom(float value);
                /*0x29fdbc0*/ void set_borderLeftWidth(float value);
                /*0x29fdbcc*/ void set_borderRightWidth(float value);
                /*0x29fdbd8*/ void set_borderTopWidth(float value);
                /*0x29fdbe4*/ void set_borderBottomWidth(float value);
                /*0x29fdbf0*/ void set_borderTopLeftRadius(float value);
                /*0x29fdbfc*/ void set_borderTopRightRadius(float value);
                /*0x29fdc08*/ void set_borderBottomLeftRadius(float value);
                /*0x29fdc14*/ void set_borderBottomRightRadius(float value);
                /*0x29fdc20*/ void set_opacity(float value);
                /*0x29fdc2c*/ void set_flexGrow(float value);
                /*0x29fdc38*/ void set_flexShrink(float value);
                /*0x29fd94c*/ void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float value);
                /*0x29fda14*/ void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color value);
                /*0x29fdb30*/ UnityEngine.UIElements.StyleValueCollection Values();
            }

            interface ITransitionAnimations
            {
                UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues to, int durationMs);
            }

            class Lerp
            {
                static /*0x29fdc44*/ float Interpolate(float start, float end, float ratio);
                static /*0x29fdc54*/ UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, float ratio);
                static /*0x29fdc8c*/ UnityEngine.UIElements.Experimental.StyleValues Interpolate(UnityEngine.UIElements.Experimental.StyleValues start, UnityEngine.UIElements.Experimental.StyleValues end, float ratio);
            }

            interface IValueAnimationUpdate
            {
                void Tick(long currentTimeMs);
            }

            class ValueAnimation<T> : UnityEngine.UIElements.Experimental.IValueAnimationUpdate
            {
                static /*0x0*/ UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.Experimental.ValueAnimation<T>> sObjectPool;
                /*0x0*/ long m_StartTimeMs;
                /*0x0*/ int m_DurationMs;
                /*0x0*/ System.Func<float, float> <easingCurve>k__BackingField;
                /*0x0*/ bool <isRunning>k__BackingField;
                /*0x0*/ System.Action <onAnimationCompleted>k__BackingField;
                /*0x0*/ bool <autoRecycle>k__BackingField;
                /*0x0*/ bool <recycled>k__BackingField;
                /*0x0*/ UnityEngine.UIElements.VisualElement <owner>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.UIElements.VisualElement, T> <valueUpdated>k__BackingField;
                /*0x0*/ System.Func<UnityEngine.UIElements.VisualElement, T> <initialValue>k__BackingField;
                /*0x0*/ System.Func<T, T, float, T> <interpolator>k__BackingField;
                /*0x0*/ T _from;
                /*0x0*/ bool fromValueSet;
                /*0x0*/ T <to>k__BackingField;

                static ValueAnimation();
                static UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement e, System.Func<T, T, float, T> interpolator);
                ValueAnimation();
                int get_durationMs();
                void set_durationMs(int value);
                System.Func<float, float> get_easingCurve();
                void set_easingCurve(System.Func<float, float> value);
                bool get_isRunning();
                void set_isRunning(bool value);
                System.Action get_onAnimationCompleted();
                void set_onAnimationCompleted(System.Action value);
                bool get_autoRecycle();
                void set_autoRecycle(bool value);
                bool get_recycled();
                void set_recycled(bool value);
                UnityEngine.UIElements.VisualElement get_owner();
                void set_owner(UnityEngine.UIElements.VisualElement value);
                System.Action<UnityEngine.UIElements.VisualElement, T> get_valueUpdated();
                void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement, T> value);
                System.Func<UnityEngine.UIElements.VisualElement, T> get_initialValue();
                void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement, T> value);
                System.Func<T, T, float, T> get_interpolator();
                void set_interpolator(System.Func<T, T, float, T> value);
                T get_from();
                void set_from(T value);
                T get_to();
                void set_to(T value);
                void Start();
                void Stop();
                void Recycle();
                void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs);
                void SetDefaultValues();
                void Unregister();
                void Register();
                void SetOwner(UnityEngine.UIElements.VisualElement e);
                void CheckNotRecycled();
                UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive();
            }
        }

        namespace StyleSheets
        {
            class HierarchyTraversal
            {
                /*0x29fe15c*/ HierarchyTraversal();
                /*0x29fe07c*/ void Traverse(UnityEngine.UIElements.VisualElement element);
                void TraverseRecursive(UnityEngine.UIElements.VisualElement element, int depth);
                /*0x29fe08c*/ void Recurse(UnityEngine.UIElements.VisualElement element, int depth);
            }

            class ShorthandApplicator
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDelayList;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDurationList;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> s_TransitionPropertyList;
                static /*0x18*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList;

                static /*0x29ffbdc*/ ShorthandApplicator();
                static /*0x29fe164*/ bool CompileFlexShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref float grow, ref float shrink, ref UnityEngine.UIElements.Length basis);
                static /*0x29fe660*/ void CompileBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.Length top, ref UnityEngine.UIElements.Length right, ref UnityEngine.UIElements.Length bottom, ref UnityEngine.UIElements.Length left);
                static /*0x29fe7a8*/ void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.Length top, ref UnityEngine.UIElements.Length right, ref UnityEngine.UIElements.Length bottom, ref UnityEngine.UIElements.Length left);
                static /*0x29fe904*/ void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref float top, ref float right, ref float bottom, ref float left);
                static /*0x29fe9bc*/ void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.Color top, ref UnityEngine.Color right, ref UnityEngine.Color bottom, ref UnityEngine.Color left);
                static /*0x29fec28*/ void CompileTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.Color outlineColor, ref float outlineWidth);
                static /*0x29fecc8*/ void CompileTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> outDelay, ref System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> outDuration, ref System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> outProperty, ref System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> outTimingFunction);
                static /*0x29ff454*/ void ApplyBorderColor(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ff548*/ void ApplyBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ff638*/ void ApplyBorderWidth(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ff724*/ void ApplyFlex(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ff7f4*/ void ApplyMargin(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ff8e4*/ void ApplyPadding(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ff9d4*/ void ApplyTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
                static /*0x29ffb24*/ void ApplyUnityTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ref UnityEngine.UIElements.ComputedStyle computedStyle);
            }

            class StyleSheetExtensions
            {
                static /*0x29ffd2c*/ string ReadAsString(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle);
                static /*0x2a0029c*/ bool IsVarFunction(UnityEngine.UIElements.StyleValueHandle handle);
            }

            struct StylePropertyValue
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ UnityEngine.UIElements.StyleValueHandle handle;
            }

            struct ImageSource
            {
                /*0x10*/ UnityEngine.Texture2D texture;
                /*0x18*/ UnityEngine.Sprite sprite;
                /*0x20*/ UnityEngine.UIElements.VectorImage vectorImage;
                /*0x28*/ UnityEngine.RenderTexture renderTexture;

                /*0x2a002d0*/ bool IsNull();
            }

            class StylePropertyReader
            {
                static /*0x0*/ UnityEngine.UIElements.StyleSheets.StylePropertyReader.GetCursorIdFunction getCursorIdFunc;
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values;
                /*0x18*/ System.Collections.Generic.List<int> m_ValueCount;
                /*0x20*/ UnityEngine.UIElements.StyleVariableResolver m_Resolver;
                /*0x28*/ UnityEngine.UIElements.StyleSheet m_Sheet;
                /*0x30*/ UnityEngine.UIElements.StyleProperty[] m_Properties;
                /*0x38*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] m_PropertyIds;
                /*0x40*/ int m_CurrentValueIndex;
                /*0x44*/ int m_CurrentPropertyIndex;
                /*0x48*/ UnityEngine.UIElements.StyleProperty <property>k__BackingField;
                /*0x50*/ UnityEngine.UIElements.StyleSheets.StylePropertyId <propertyId>k__BackingField;
                /*0x54*/ int <valueCount>k__BackingField;
                /*0x58*/ float <dpiScaling>k__BackingField;

                static /*0x2a01128*/ UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue zVvalue);
                static /*0x2a03618*/ UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue value, ref bool isVertical, ref bool isHorizontal);
                static /*0x2a00d6c*/ UnityEngine.UIElements.Translate ReadTranslate(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3);
                static /*0x2a015dc*/ UnityEngine.UIElements.Scale ReadScale(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3);
                static /*0x2a01410*/ UnityEngine.UIElements.Rotate ReadRotate(int valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3, UnityEngine.UIElements.StyleSheets.StylePropertyValue val4);
                static /*0x2a03770*/ int ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue value);
                static /*0x2a03838*/ UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue value);
                static /*0x2a02528*/ bool TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue propertyValue, float dpiScaling, ref UnityEngine.UIElements.StyleSheets.ImageSource source);
                /*0x2a03954*/ StylePropertyReader();
                /*0x2a003b8*/ UnityEngine.UIElements.StyleProperty get_property();
                /*0x2a003c0*/ void set_property(UnityEngine.UIElements.StyleProperty value);
                /*0x2a003c8*/ UnityEngine.UIElements.StyleSheets.StylePropertyId get_propertyId();
                /*0x2a003d0*/ void set_propertyId(UnityEngine.UIElements.StyleSheets.StylePropertyId value);
                /*0x2a003d8*/ int get_valueCount();
                /*0x2a003e0*/ void set_valueCount(int value);
                /*0x2a003e8*/ float get_dpiScaling();
                /*0x2a003f0*/ void set_dpiScaling(float value);
                /*0x2a003f8*/ void SetContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleComplexSelector selector, UnityEngine.UIElements.StyleVariableContext varContext, float dpiScaling);
                /*0x2a00a94*/ void SetInlineContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleProperty[] properties, UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds, float dpiScaling);
                /*0x2a00aa4*/ UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty();
                /*0x2a00b80*/ UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(int index);
                /*0x29fe484*/ UnityEngine.UIElements.StyleValueType GetValueType(int index);
                /*0x29fe34c*/ bool IsValueType(int index, UnityEngine.UIElements.StyleValueType type);
                /*0x29fe3e0*/ bool IsKeyword(int index, UnityEngine.UIElements.StyleValueKeyword keyword);
                /*0x29ff3f4*/ string ReadAsString(int index);
                /*0x29fe504*/ UnityEngine.UIElements.Length ReadLength(int index);
                /*0x29ff35c*/ UnityEngine.UIElements.TimeValue ReadTimeValue(int index);
                /*0x2a00c3c*/ UnityEngine.UIElements.Translate ReadTranslate(int index);
                /*0x2a00ff4*/ UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(int index);
                /*0x2a012ec*/ UnityEngine.UIElements.Rotate ReadRotate(int index);
                /*0x2a014dc*/ UnityEngine.UIElements.Scale ReadScale(int index);
                /*0x29fe5f8*/ float ReadFloat(int index);
                /*0x2a017d8*/ int ReadInt(int index);
                /*0x29feb24*/ UnityEngine.Color ReadColor(int index);
                /*0x2a01950*/ int ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, int index);
                /*0x2a01a4c*/ UnityEngine.UIElements.FontDefinition ReadFontDefinition(int index);
                /*0x2a01f74*/ UnityEngine.Font ReadFont(int index);
                /*0x2a022b8*/ UnityEngine.UIElements.Background ReadBackground(int index);
                /*0x2a02bdc*/ UnityEngine.UIElements.Cursor ReadCursor(int index);
                /*0x2a02e88*/ UnityEngine.UIElements.TextShadow ReadTextShadow(int index);
                /*0x2a030fc*/ void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, int index);
                /*0x2a032ec*/ void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, int index);
                /*0x2a03480*/ void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, int index);
                /*0x2a00660*/ void LoadProperties();
                /*0x2a00ad0*/ void SetCurrentProperty();

                class GetCursorIdFunction : System.MulticastDelegate
                {
                    /*0x2a03a44*/ GetCursorIdFunction(object object, nint method);
                    /*0x2a03b74*/ int Invoke(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle);
                }
            }

            struct StyleValue
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId id;
                /*0x14*/ UnityEngine.UIElements.StyleKeyword keyword;
                /*0x18*/ float number;
                /*0x18*/ UnityEngine.UIElements.Length length;
                /*0x18*/ UnityEngine.Color color;
                /*0x18*/ System.Runtime.InteropServices.GCHandle resource;
            }

            struct StyleValueManaged
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.StylePropertyId id;
                /*0x14*/ UnityEngine.UIElements.StyleKeyword keyword;
                /*0x18*/ object value;
            }

            struct MatchResultInfo
            {
                /*0x10*/ bool success;
                /*0x14*/ UnityEngine.UIElements.PseudoStates triggerPseudoMask;
                /*0x18*/ UnityEngine.UIElements.PseudoStates dependencyPseudoMask;

                /*0x2a03b88*/ MatchResultInfo(bool success, UnityEngine.UIElements.PseudoStates triggerPseudoMask, UnityEngine.UIElements.PseudoStates dependencyPseudoMask);
            }

            struct SelectorMatchRecord
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheet sheet;
                /*0x18*/ int styleSheetIndexInStack;
                /*0x20*/ UnityEngine.UIElements.StyleComplexSelector complexSelector;

                static /*0x2a03bac*/ int Compare(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b);
                /*0x2a03b98*/ SelectorMatchRecord(UnityEngine.UIElements.StyleSheet sheet, int styleSheetIndexInStack);
            }

            class StyleSelectorHelper
            {
                static /*0x2a03c94*/ UnityEngine.UIElements.StyleSheets.MatchResultInfo MatchesSelector(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSelector selector);
                static /*0x2a03f50*/ bool MatchRightToLeft(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult);
                static /*0x2a04118*/ void FastLookup(System.Collections.Generic.IDictionary<string, UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, UnityEngine.UIElements.StyleMatchingContext context, string input, ref UnityEngine.UIElements.StyleSheets.SelectorMatchRecord record);
                static /*0x2a042dc*/ void FindMatches(UnityEngine.UIElements.StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, int parentSheetIndex);
            }

            struct Dimension : System.IEquatable<UnityEngine.UIElements.StyleSheets.Dimension>
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.Dimension.Unit unit;
                /*0x14*/ float value;

                static /*0x2a04640*/ bool op_Equality(UnityEngine.UIElements.StyleSheets.Dimension lhs, UnityEngine.UIElements.StyleSheets.Dimension rhs);
                /*0x2a04634*/ Dimension(float value, UnityEngine.UIElements.StyleSheets.Dimension.Unit unit);
                /*0x2a00bdc*/ UnityEngine.UIElements.Length ToLength();
                /*0x2a00c0c*/ UnityEngine.UIElements.TimeValue ToTime();
                /*0x2a038b0*/ UnityEngine.UIElements.Angle ToAngle();
                /*0x2a04668*/ bool Equals(UnityEngine.UIElements.StyleSheets.Dimension other);
                /*0x2a04690*/ bool Equals(object obj);
                /*0x2a0471c*/ int GetHashCode();
                /*0x2a00008*/ string ToString();

                enum Unit
                {
                    Unitless = 0,
                    Pixel = 1,
                    Percent = 2,
                    Second = 3,
                    Millisecond = 4,
                    Degree = 5,
                    Gradian = 6,
                    Radian = 7,
                    Turn = 8,
                }
            }

            struct ScalableImage
            {
                /*0x10*/ UnityEngine.Texture2D normalImage;
                /*0x18*/ UnityEngine.Texture2D highResolutionImage;

                /*0x2a00138*/ string ToString();
            }

            class StyleSheetColor
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, UnityEngine.Color32> s_NameToColor;

                static /*0x2a04778*/ StyleSheetColor();
                static /*0x2a0185c*/ bool TryGetColor(string name, ref UnityEngine.Color color);
                static /*0x2a04764*/ UnityEngine.Color32 HexToColor32(uint color);
            }

            class StyleSheetCache
            {
                static /*0x0*/ UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKeyComparer s_Comparer;
                static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey, UnityEngine.UIElements.StyleSheets.StylePropertyId[]> s_RulePropertyIdsCache;

                static /*0x2a063a0*/ StyleSheetCache();
                static /*0x2a004b0*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleSheet sheet, int ruleIndex);
                static /*0x2a062c0*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleRule rule);
                static /*0x2a061cc*/ UnityEngine.UIElements.StyleSheets.StylePropertyId GetPropertyId(UnityEngine.UIElements.StyleRule rule, int index);

                struct SheetHandleKey
                {
                    /*0x10*/ int sheetInstanceID;
                    /*0x14*/ int index;

                    /*0x2a06474*/ SheetHandleKey(UnityEngine.UIElements.StyleSheet sheet, int index);
                }

                class SheetHandleKeyComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey>
                {
                    /*0x2a06508*/ SheetHandleKeyComparer();
                    /*0x2a064a8*/ bool Equals(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey x, UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey y);
                    /*0x2a064c8*/ int GetHashCode(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey key);
                }
            }

            class StylePropertyUtil
            {
                static /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheets.StylePropertyId> s_AnimatablePropertiesHash;
                static /*0x8*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyId> s_NameToId;
                static /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, string> s_IdToName;
                static /*0x18*/ UnityEngine.UIElements.StyleSheets.StylePropertyId[] s_AnimatableProperties;

                static /*0x2a06510*/ StylePropertyUtil();
                static /*0x2a083c8*/ bool IsAnimatable(UnityEngine.UIElements.StyleSheets.StylePropertyId id);
                static /*0x2a08448*/ bool TryGetEnumIntValue(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, string value, ref int intValue);
                static /*0x2a091e0*/ bool IsMatchingShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyId shorthand, UnityEngine.UIElements.StyleSheets.StylePropertyId id);
            }

            class StylePropertyCache
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_PropertySyntaxCache;
                static /*0x8*/ System.Collections.Generic.Dictionary<string, string> s_NonTerminalValues;

                static /*0x2a09430*/ StylePropertyCache();
                static /*0x2a09310*/ bool TryGetSyntax(string name, ref string syntax);
                static /*0x2a093a0*/ bool TryGetNonTerminalValue(string name, ref string syntax);
            }

            enum MatchResultErrorCode
            {
                None = 0,
                Syntax = 1,
                EmptyValue = 2,
                ExpectedEndOfValue = 3,
            }

            struct MatchResult
            {
                /*0x10*/ UnityEngine.UIElements.StyleSheets.MatchResultErrorCode errorCode;
                /*0x18*/ string errorValue;

                /*0x2a0a714*/ bool get_success();
            }

            class BaseStyleMatcher
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex s_CustomIdentRegex;
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext> m_ContextStack;
                /*0x18*/ UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext m_CurrentContext;

                static /*0x2a0b3a8*/ BaseStyleMatcher();
                /*0x2a0b32c*/ BaseStyleMatcher();
                bool MatchKeyword(string keyword);
                bool MatchNumber();
                bool MatchInteger();
                bool MatchLength();
                bool MatchPercentage();
                bool MatchColor();
                bool MatchResource();
                bool MatchUrl();
                bool MatchTime();
                bool MatchAngle();
                bool MatchCustomIdent();
                int get_valueCount();
                bool get_isCurrentVariable();
                bool get_isCurrentComma();
                /*0x2a0a724*/ bool get_hasCurrent();
                /*0x2a0a74c*/ int get_currentIndex();
                /*0x2a0a754*/ void set_currentIndex(int value);
                /*0x2a0a75c*/ int get_matchedVariableCount();
                /*0x2a0a764*/ void set_matchedVariableCount(int value);
                /*0x2a0a76c*/ void Initialize();
                /*0x2a0a7c0*/ void MoveNext();
                /*0x2a0a804*/ void SaveContext();
                /*0x2a0a858*/ void RestoreContext();
                /*0x2a0a8b0*/ void DropContext();
                /*0x2a0a900*/ bool Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0a9bc*/ bool MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0aad0*/ bool MatchExpressionWithMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0ade4*/ bool MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0ac1c*/ bool MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0ae98*/ bool MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0af68*/ bool MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0af80*/ bool MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0b01c*/ int MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0b19c*/ int MatchManyByOrder(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, int* matchOrder);
                /*0x2a0afb0*/ bool MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);
                /*0x2a0ace8*/ bool MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp);

                struct MatchContext
                {
                    /*0x10*/ int valueIndex;
                    /*0x14*/ int matchedVariableCount;
                }
            }

            class StylePropertyValueMatcher : UnityEngine.UIElements.StyleSheets.BaseStyleMatcher
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values;

                /*0x2a0bdc8*/ StylePropertyValueMatcher();
                /*0x2a0b43c*/ UnityEngine.UIElements.StyleSheets.StylePropertyValue get_current();
                /*0x2a0b4c0*/ int get_valueCount();
                /*0x2a0b508*/ bool get_isCurrentVariable();
                /*0x2a0b510*/ bool get_isCurrentComma();
                /*0x2a0b5b8*/ UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values);
                /*0x2a0b734*/ bool MatchKeyword(string keyword);
                /*0x2a0b7e8*/ bool MatchNumber();
                /*0x2a0b81c*/ bool MatchInteger();
                /*0x2a0b850*/ bool MatchLength();
                /*0x2a0b944*/ bool MatchPercentage();
                /*0x2a0ba38*/ bool MatchColor();
                /*0x2a0bb18*/ bool MatchResource();
                /*0x2a0bb4c*/ bool MatchUrl();
                /*0x2a0bb8c*/ bool MatchTime();
                /*0x2a0bbec*/ bool MatchCustomIdent();
                /*0x2a0bccc*/ bool MatchAngle();
            }

            class InitialStyle
            {
                static /*0x0*/ UnityEngine.UIElements.ComputedStyle s_InitialStyle;

                static /*0x2a0bf1c*/ InitialStyle();
                static /*0x2a0be1c*/ ref UnityEngine.UIElements.ComputedStyle Get();
                static /*0x2a0be70*/ UnityEngine.UIElements.ComputedStyle Acquire();
                static /*0x2a0cc68*/ UnityEngine.UIElements.Align get_alignContent();
                static /*0x2a0cce0*/ UnityEngine.UIElements.Align get_alignItems();
                static /*0x2a0cd58*/ UnityEngine.UIElements.Align get_alignSelf();
                static /*0x2a0cdd0*/ UnityEngine.Color get_backgroundColor();
                static /*0x2a0ce4c*/ UnityEngine.UIElements.Background get_backgroundImage();
                static /*0x2a0cecc*/ UnityEngine.Color get_borderBottomColor();
                static /*0x2a0cf48*/ UnityEngine.UIElements.Length get_borderBottomLeftRadius();
                static /*0x2a0cfc0*/ UnityEngine.UIElements.Length get_borderBottomRightRadius();
                static /*0x2a0d038*/ float get_borderBottomWidth();
                static /*0x2a0d0b0*/ UnityEngine.Color get_borderLeftColor();
                static /*0x2a0d12c*/ float get_borderLeftWidth();
                static /*0x2a0d1a4*/ UnityEngine.Color get_borderRightColor();
                static /*0x2a0d220*/ float get_borderRightWidth();
                static /*0x2a0d298*/ UnityEngine.Color get_borderTopColor();
                static /*0x2a0d314*/ UnityEngine.UIElements.Length get_borderTopLeftRadius();
                static /*0x2a0d38c*/ UnityEngine.UIElements.Length get_borderTopRightRadius();
                static /*0x2a0d404*/ float get_borderTopWidth();
                static /*0x2a0d47c*/ UnityEngine.UIElements.Length get_bottom();
                static /*0x2a0d4f4*/ UnityEngine.Color get_color();
                static /*0x2a0d56c*/ UnityEngine.UIElements.Cursor get_cursor();
                static /*0x2a0d5f4*/ UnityEngine.UIElements.DisplayStyle get_display();
                static /*0x2a0d66c*/ UnityEngine.UIElements.Length get_flexBasis();
                static /*0x2a0d6e4*/ UnityEngine.UIElements.FlexDirection get_flexDirection();
                static /*0x2a0d75c*/ float get_flexGrow();
                static /*0x2a0d7d4*/ float get_flexShrink();
                static /*0x2a0d84c*/ UnityEngine.UIElements.Wrap get_flexWrap();
                static /*0x2a0d8c4*/ UnityEngine.UIElements.Length get_fontSize();
                static /*0x2a0d938*/ UnityEngine.UIElements.Length get_height();
                static /*0x2a0d9b0*/ UnityEngine.UIElements.Justify get_justifyContent();
                static /*0x2a0da28*/ UnityEngine.UIElements.Length get_left();
                static /*0x2a0daa0*/ UnityEngine.UIElements.Length get_letterSpacing();
                static /*0x2a0db14*/ UnityEngine.UIElements.Length get_marginBottom();
                static /*0x2a0db8c*/ UnityEngine.UIElements.Length get_marginLeft();
                static /*0x2a0dc04*/ UnityEngine.UIElements.Length get_marginRight();
                static /*0x2a0dc7c*/ UnityEngine.UIElements.Length get_marginTop();
                static /*0x2a0dcf4*/ UnityEngine.UIElements.Length get_maxHeight();
                static /*0x2a0dd6c*/ UnityEngine.UIElements.Length get_maxWidth();
                static /*0x2a0dde4*/ UnityEngine.UIElements.Length get_minHeight();
                static /*0x2a0de5c*/ UnityEngine.UIElements.Length get_minWidth();
                static /*0x2a0ded4*/ float get_opacity();
                static /*0x2a0df4c*/ UnityEngine.UIElements.OverflowInternal get_overflow();
                static /*0x2a0dfc4*/ UnityEngine.UIElements.Length get_paddingBottom();
                static /*0x2a0e03c*/ UnityEngine.UIElements.Length get_paddingLeft();
                static /*0x2a0e0b4*/ UnityEngine.UIElements.Length get_paddingRight();
                static /*0x2a0e12c*/ UnityEngine.UIElements.Length get_paddingTop();
                static /*0x2a0e1a4*/ UnityEngine.UIElements.Position get_position();
                static /*0x2a0e21c*/ UnityEngine.UIElements.Length get_right();
                static /*0x2a0e294*/ UnityEngine.UIElements.Rotate get_rotate();
                static /*0x2a0e31c*/ UnityEngine.UIElements.Scale get_scale();
                static /*0x2a0e398*/ UnityEngine.UIElements.TextOverflow get_textOverflow();
                static /*0x2a0e410*/ UnityEngine.UIElements.TextShadow get_textShadow();
                static /*0x2a0e494*/ UnityEngine.UIElements.Length get_top();
                static /*0x2a0e50c*/ UnityEngine.UIElements.TransformOrigin get_transformOrigin();
                static /*0x2a0e594*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay();
                static /*0x2a0e60c*/ System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration();
                static /*0x2a0e684*/ System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty();
                static /*0x2a0e6fc*/ System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction();
                static /*0x2a0e774*/ UnityEngine.UIElements.Translate get_translate();
                static /*0x2a0e7fc*/ UnityEngine.Color get_unityBackgroundImageTintColor();
                static /*0x2a0e878*/ UnityEngine.ScaleMode get_unityBackgroundScaleMode();
                static /*0x2a0e8f0*/ UnityEngine.Font get_unityFont();
                static /*0x2a0e964*/ UnityEngine.UIElements.FontDefinition get_unityFontDefinition();
                static /*0x2a0e9dc*/ UnityEngine.FontStyle get_unityFontStyleAndWeight();
                static /*0x2a0ea50*/ UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox();
                static /*0x2a0eac8*/ UnityEngine.UIElements.Length get_unityParagraphSpacing();
                static /*0x2a0eb3c*/ int get_unitySliceBottom();
                static /*0x2a0ebb4*/ int get_unitySliceLeft();
                static /*0x2a0ec2c*/ int get_unitySliceRight();
                static /*0x2a0eca4*/ int get_unitySliceTop();
                static /*0x2a0ed1c*/ UnityEngine.TextAnchor get_unityTextAlign();
                static /*0x2a0ed90*/ UnityEngine.Color get_unityTextOutlineColor();
                static /*0x2a0ee08*/ float get_unityTextOutlineWidth();
                static /*0x2a0ee7c*/ UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition();
                static /*0x2a0eef4*/ UnityEngine.UIElements.Visibility get_visibility();
                static /*0x2a0ef68*/ UnityEngine.UIElements.WhiteSpace get_whiteSpace();
                static /*0x2a0efdc*/ UnityEngine.UIElements.Length get_width();
                static /*0x2a0f054*/ UnityEngine.UIElements.Length get_wordSpacing();
            }

            enum StyleEnumType
            {
                Align = 0,
                DisplayStyle = 1,
                EasingMode = 2,
                FlexDirection = 3,
                FontStyle = 4,
                Justify = 5,
                Overflow = 6,
                OverflowClipBox = 7,
                OverflowInternal = 8,
                Position = 9,
                ScaleMode = 10,
                TextAnchor = 11,
                TextOverflow = 12,
                TextOverflowPosition = 13,
                TransformOriginOffset = 14,
                Visibility = 15,
                WhiteSpace = 16,
                Wrap = 17,
            }

            enum StylePropertyId
            {
                Unknown = 0,
                Custom = -1,
                AlignContent = 131072,
                AlignItems = 131073,
                AlignSelf = 131074,
                All = 262144,
                BackgroundColor = 458752,
                BackgroundImage = 458753,
                BorderBottomColor = 458754,
                BorderBottomLeftRadius = 458755,
                BorderBottomRightRadius = 458756,
                BorderBottomWidth = 131075,
                BorderColor = 262145,
                BorderLeftColor = 458757,
                BorderLeftWidth = 131076,
                BorderRadius = 262146,
                BorderRightColor = 458758,
                BorderRightWidth = 131077,
                BorderTopColor = 458759,
                BorderTopLeftRadius = 458760,
                BorderTopRightRadius = 458761,
                BorderTopWidth = 131078,
                BorderWidth = 262147,
                Bottom = 131079,
                Color = 65536,
                Cursor = 196608,
                Display = 131080,
                Flex = 262148,
                FlexBasis = 131081,
                FlexDirection = 131082,
                FlexGrow = 131083,
                FlexShrink = 131084,
                FlexWrap = 131085,
                FontSize = 65537,
                Height = 131086,
                JustifyContent = 131087,
                Left = 131088,
                LetterSpacing = 65538,
                Margin = 262149,
                MarginBottom = 131089,
                MarginLeft = 131090,
                MarginRight = 131091,
                MarginTop = 131092,
                MaxHeight = 131093,
                MaxWidth = 131094,
                MinHeight = 131095,
                MinWidth = 131096,
                Opacity = 458762,
                Overflow = 458763,
                Padding = 262150,
                PaddingBottom = 131097,
                PaddingLeft = 131098,
                PaddingRight = 131099,
                PaddingTop = 131100,
                Position = 131101,
                Right = 131102,
                Rotate = 327680,
                Scale = 327681,
                TextOverflow = 196609,
                TextShadow = 65539,
                Top = 131103,
                TransformOrigin = 327682,
                Transition = 262151,
                TransitionDelay = 393216,
                TransitionDuration = 393217,
                TransitionProperty = 393218,
                TransitionTimingFunction = 393219,
                Translate = 327683,
                UnityBackgroundImageTintColor = 196610,
                UnityBackgroundScaleMode = 196611,
                UnityFont = 65540,
                UnityFontDefinition = 65541,
                UnityFontStyleAndWeight = 65542,
                UnityOverflowClipBox = 196612,
                UnityParagraphSpacing = 65543,
                UnitySliceBottom = 196613,
                UnitySliceLeft = 196614,
                UnitySliceRight = 196615,
                UnitySliceTop = 196616,
                UnityTextAlign = 65544,
                UnityTextOutline = 262152,
                UnityTextOutlineColor = 65545,
                UnityTextOutlineWidth = 65546,
                UnityTextOverflowPosition = 196617,
                Visibility = 65547,
                WhiteSpace = 65548,
                Width = 131104,
                WordSpacing = 65549,
            }

            namespace Syntax
            {
                enum StyleSyntaxTokenType
                {
                    Unknown = 0,
                    String = 1,
                    Number = 2,
                    Space = 3,
                    SingleBar = 4,
                    DoubleBar = 5,
                    DoubleAmpersand = 6,
                    Comma = 7,
                    SingleQuote = 8,
                    Asterisk = 9,
                    Plus = 10,
                    QuestionMark = 11,
                    HashMark = 12,
                    ExclamationPoint = 13,
                    OpenBracket = 14,
                    CloseBracket = 15,
                    OpenBrace = 16,
                    CloseBrace = 17,
                    LessThan = 18,
                    GreaterThan = 19,
                    End = 20,
                }

                struct StyleSyntaxToken
                {
                    /*0x10*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type;
                    /*0x18*/ string text;
                    /*0x20*/ int number;

                    /*0x2a0f0c8*/ StyleSyntaxToken(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType t);
                    /*0x2a0f0d8*/ StyleSyntaxToken(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, string text);
                    /*0x2a0f0e8*/ StyleSyntaxToken(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, int number);
                }

                class StyleSyntaxTokenizer
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens;
                    /*0x18*/ int m_CurrentTokenIndex;

                    static /*0x2a1009c*/ bool IsNextCharacter(string s, int index, char c);
                    static /*0x2a10178*/ bool IsNextLetterOrDash(string s, int index);
                    static /*0x2a100e0*/ bool IsNextNumber(string s, int index);
                    static /*0x2a10060*/ int GlobCharacter(string s, int index, char c);
                    /*0x2a10238*/ StyleSyntaxTokenizer();
                    /*0x2a0f0f8*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken get_current();
                    /*0x2a0f1a4*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext();
                    /*0x2a0f2b8*/ UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext();
                    /*0x2a0f368*/ void Tokenize(string syntax);
                }

                class StyleSyntaxParser
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ProcessExpressionList;
                    /*0x18*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ExpressionStack;
                    /*0x20*/ System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator> m_CombinatorStack;
                    /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ParsedExpressionCache;

                    static /*0x2a1148c*/ void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    static /*0x2a10eb4*/ bool IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token);
                    static /*0x2a11478*/ bool IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token);
                    static /*0x2a1190c*/ bool IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token);
                    /*0x2a11a58*/ StyleSyntaxParser();
                    /*0x2a102bc*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(string syntax);
                    /*0x2a10454*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x2a10bc4*/ void ProcessCombinatorStack();
                    /*0x2a106d4*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x2a10a6c*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x2a10844*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x2a10f18*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x2a114cc*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(string syntax);
                    /*0x2a11620*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer);
                    /*0x2a112fc*/ void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, ref UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier);
                    /*0x2a11934*/ void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, ref int min, ref int max);
                }

                class Expression
                {
                    /*0x10*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type;
                    /*0x14*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier;
                    /*0x20*/ UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType;
                    /*0x24*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator combinator;
                    /*0x28*/ UnityEngine.UIElements.StyleSheets.Syntax.Expression[] subExpressions;
                    /*0x30*/ string keyword;

                    /*0x2a10ed4*/ Expression(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type);
                }

                enum ExpressionType
                {
                    Unknown = 0,
                    Data = 1,
                    Keyword = 2,
                    Combinator = 3,
                }

                enum DataType
                {
                    None = 0,
                    Number = 1,
                    Integer = 2,
                    Length = 3,
                    Percentage = 4,
                    Color = 5,
                    Resource = 6,
                    Url = 7,
                    Time = 8,
                    Angle = 9,
                    CustomIdent = 10,
                }

                enum ExpressionCombinator
                {
                    None = 0,
                    Or = 1,
                    OrOr = 2,
                    AndAnd = 3,
                    Juxtaposition = 4,
                    Group = 5,
                }

                enum ExpressionMultiplierType
                {
                    None = 0,
                    ZeroOrMore = 1,
                    OneOrMore = 2,
                    ZeroOrOne = 3,
                    Ranges = 4,
                    OneOrMoreComma = 5,
                    GroupAtLeastOne = 6,
                }

                struct ExpressionMultiplier
                {
                    static int Infinity = 100;
                    /*0x10*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType m_Type;
                    /*0x14*/ int min;
                    /*0x18*/ int max;

                    /*0x2a11ba0*/ ExpressionMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type);
                    /*0x2a0a9b4*/ UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType get_type();
                    /*0x2a11930*/ void set_type(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value);
                    /*0x2a11bb0*/ void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2658253827592C8000DF6C48FD5487B674D9E695DB670A56FDEAB2B7F291523E;

    struct __StaticArrayInitTypeSize=108
    {
    }
}
