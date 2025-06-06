class <Module>
{
}

namespace TMPro
{
    class FastAction
    {
        /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

        /*0x2750488*/ FastAction();
        /*0x2750270*/ void Add(System.Action rhs);
        /*0x2750330*/ void Remove(System.Action rhs);
        /*0x27503f0*/ void Call();
    }

    class FastAction<A>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

        FastAction();
        void Add(System.Action<A> rhs);
        void Remove(System.Action<A> rhs);
        void Call(A a);
    }

    class FastAction<A, B>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

        FastAction();
        void Add(System.Action<A, B> rhs);
        void Remove(System.Action<A, B> rhs);
        void Call(A a, B b);
    }

    class FastAction<A, B, C>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

        FastAction();
        void Add(System.Action<A, B, C> rhs);
        void Remove(System.Action<A, B, C> rhs);
        void Call(A a, B b, C c);
    }

    interface ITextPreprocessor
    {
        string PreprocessText(string text);
    }

    class MaterialReferenceManager
    {
        static /*0x0*/ TMPro.MaterialReferenceManager s_Instance;
        /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
        /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
        /*0x28*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;

        static /*0x2750548*/ TMPro.MaterialReferenceManager get_instance();
        static /*0x275070c*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x27507f0*/ void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x27508d4*/ void AddSpriteAsset(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x27509d8*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
        static /*0x2750a70*/ void AddColorGradientPreset(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        static /*0x2750bfc*/ bool TryGetFontAsset(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x2750c98*/ bool TryGetSpriteAsset(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x2750d34*/ bool TryGetColorGradientPreset(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        static /*0x2750dd0*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
        /*0x27505c4*/ MaterialReferenceManager();
        /*0x275072c*/ void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset);
        /*0x2750810*/ void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset);
        /*0x2750904*/ void AddSpriteAssetInternal(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        /*0x2750a08*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
        /*0x2750aa0*/ void AddColorGradientPreset_Internal(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        /*0x2750b44*/ bool Contains(TMPro.TMP_FontAsset font);
        /*0x2750ba0*/ bool Contains(TMPro.TMP_SpriteAsset sprite);
        /*0x2750c2c*/ bool TryGetFontAssetInternal(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        /*0x2750cc8*/ bool TryGetSpriteAssetInternal(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        /*0x2750d64*/ bool TryGetColorGradientPresetInternal(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        /*0x2750e00*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
    }

    struct TMP_MaterialReference
    {
        /*0x10*/ UnityEngine.Material material;
        /*0x18*/ int referenceCount;
    }

    struct MaterialReference
    {
        /*0x10*/ int index;
        /*0x18*/ TMPro.TMP_FontAsset fontAsset;
        /*0x20*/ TMPro.TMP_SpriteAsset spriteAsset;
        /*0x28*/ UnityEngine.Material material;
        /*0x30*/ bool isDefaultMaterial;
        /*0x31*/ bool isFallbackMaterial;
        /*0x38*/ UnityEngine.Material fallbackMaterial;
        /*0x40*/ float padding;
        /*0x44*/ int referenceCount;

        static /*0x2750ee8*/ bool Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset);
        static /*0x2750fe4*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        static /*0x27511f0*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        /*0x2750e6c*/ MaterialReference(int index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
    }

    enum TextContainerAnchors
    {
        TopLeft = 0,
        Top = 1,
        TopRight = 2,
        Left = 3,
        Middle = 4,
        Right = 5,
        BottomLeft = 6,
        Bottom = 7,
        BottomRight = 8,
        Custom = 9,
    }

    class TextContainer : UnityEngine.EventSystems.UIBehaviour
    {
        static /*0x0*/ UnityEngine.Vector2 k_defaultSize;
        /*0x18*/ bool m_hasChanged;
        /*0x1c*/ UnityEngine.Vector2 m_pivot;
        /*0x24*/ TMPro.TextContainerAnchors m_anchorPosition;
        /*0x28*/ UnityEngine.Rect m_rect;
        /*0x38*/ bool m_isDefaultWidth;
        /*0x39*/ bool m_isDefaultHeight;
        /*0x3a*/ bool m_isAutoFitting;
        /*0x40*/ UnityEngine.Vector3[] m_corners;
        /*0x48*/ UnityEngine.Vector3[] m_worldCorners;
        /*0x50*/ UnityEngine.Vector4 m_margins;
        /*0x60*/ UnityEngine.RectTransform m_rectTransform;
        /*0x68*/ TMPro.TextMeshPro m_textMeshPro;

        static /*0x2752004*/ TextContainer();
        /*0x2751f94*/ TextContainer();
        /*0x27513c8*/ bool get_hasChanged();
        /*0x27513d0*/ void set_hasChanged(bool value);
        /*0x27513dc*/ UnityEngine.Vector2 get_pivot();
        /*0x27513e4*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x275167c*/ TMPro.TextContainerAnchors get_anchorPosition();
        /*0x2751684*/ void set_anchorPosition(TMPro.TextContainerAnchors value);
        /*0x2751738*/ UnityEngine.Rect get_rect();
        /*0x2751744*/ void set_rect(UnityEngine.Rect value);
        /*0x27517c0*/ UnityEngine.Vector2 get_size();
        /*0x27517fc*/ void set_size(UnityEngine.Vector2 value);
        /*0x2751924*/ float get_width();
        /*0x2751930*/ void set_width(float value);
        /*0x2751978*/ float get_height();
        /*0x2751984*/ void set_height(float value);
        /*0x27519c8*/ bool get_isDefaultWidth();
        /*0x27519d0*/ bool get_isDefaultHeight();
        /*0x27519d8*/ bool get_isAutoFitting();
        /*0x27519e0*/ void set_isAutoFitting(bool value);
        /*0x27519ec*/ UnityEngine.Vector3[] get_corners();
        /*0x27519f4*/ UnityEngine.Vector3[] get_worldCorners();
        /*0x27519fc*/ UnityEngine.Vector4 get_margins();
        /*0x2751a08*/ void set_margins(UnityEngine.Vector4 value);
        /*0x2751a64*/ UnityEngine.RectTransform get_rectTransform();
        /*0x2751af8*/ TMPro.TextMeshPro get_textMeshPro();
        /*0x2751b8c*/ void Awake();
        /*0x2751c54*/ void OnEnable();
        /*0x2751c58*/ void OnDisable();
        /*0x275152c*/ void OnContainerChanged();
        /*0x2751e34*/ void OnRectTransformDimensionsChange();
        /*0x27518a4*/ void SetRect(UnityEngine.Vector2 size);
        /*0x2751c5c*/ void UpdateCorners();
        /*0x27516c0*/ UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor);
        /*0x275143c*/ TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot);
    }

    class TextMeshPro : TMPro.TMP_Text, UnityEngine.UI.ILayoutElement
    {
        static /*0x0*/ Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;
        static /*0x38*/ Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;
        static /*0x40*/ Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;
        static /*0x48*/ Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;
        static /*0x50*/ Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;
        static /*0x58*/ Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;
        static /*0x60*/ Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;
        static /*0x68*/ Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;
        static /*0x70*/ Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;
        static /*0x78*/ Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;
        static /*0x80*/ Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;
        static /*0x88*/ Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        static /*0x90*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        static /*0x98*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        /*0x6c0*/ int _SortingLayer;
        /*0x6c4*/ int _SortingLayerID;
        /*0x6c8*/ int _SortingOrder;
        /*0x6d0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6d8*/ bool m_currentAutoSizeMode;
        /*0x6d9*/ bool m_hasFontAssetChanged;
        /*0x6dc*/ float m_previousLossyScaleY;
        /*0x6e0*/ UnityEngine.Renderer m_renderer;
        /*0x6e8*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x6f0*/ bool m_isFirstAllocation;
        /*0x6f4*/ int m_max_characters;
        /*0x6f8*/ int m_max_numberOfLines;
        /*0x700*/ TMPro.TMP_SubMesh[] m_subTextObjects;
        /*0x708*/ TMPro.MaskingTypes m_maskType;
        /*0x70c*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x750*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x758*/ bool m_isRegisteredForEvents;

        static /*0x2758364*/ TextMeshPro();
        /*0x27582a4*/ TextMeshPro();
        /*0x2752054*/ int get_sortingLayerID();
        /*0x275217c*/ void set_sortingLayerID(int value);
        /*0x275233c*/ int get_sortingOrder();
        /*0x27523d0*/ void set_sortingOrder(int value);
        /*0x2752590*/ bool get_autoSizeTextContainer();
        /*0x2752598*/ void set_autoSizeTextContainer(bool value);
        /*0x2752638*/ TMPro.TextContainer get_textContainer();
        /*0x2752640*/ UnityEngine.Transform get_transform();
        /*0x27520e8*/ UnityEngine.Renderer get_renderer();
        /*0x27526d4*/ UnityEngine.Mesh get_mesh();
        /*0x2752784*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x2752880*/ TMPro.MaskingTypes get_maskType();
        /*0x2752888*/ void set_maskType(TMPro.MaskingTypes value);
        /*0x27529d8*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords);
        /*0x2752ac0*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, float softnessX, float softnessY);
        /*0x2752c10*/ void SetVerticesDirty();
        /*0x2752cc0*/ void SetLayoutDirty();
        /*0x2752d90*/ void SetMaterialDirty();
        /*0x2752da0*/ void SetAllDirty();
        /*0x2752de4*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x2753128*/ void UpdateMaterial();
        /*0x275325c*/ void UpdateMeshPadding();
        /*0x275335c*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x2753370*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x27533dc*/ void ClearMesh(bool updateMesh);
        /*0x275349c*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x2753550*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x2753604*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x275361c*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x27537b4*/ void UpdateVertexData();
        /*0x275394c*/ void UpdateFontAsset();
        /*0x275395c*/ void CalculateLayoutInputHorizontal();
        /*0x2753960*/ void CalculateLayoutInputVertical();
        /*0x2753964*/ void Awake();
        /*0x2753d0c*/ void OnEnable();
        /*0x2753e08*/ void OnDisable();
        /*0x2753eb4*/ void OnDestroy();
        /*0x2753f80*/ void LoadFontAsset();
        /*0x27545f0*/ void UpdateEnvMapMatrix();
        /*0x2752890*/ void SetMask(TMPro.MaskingTypes maskType);
        /*0x2752a20*/ void SetMaskCoordinates(UnityEngine.Vector4 coords);
        /*0x2752b20*/ void SetMaskCoordinates(UnityEngine.Vector4 coords, float softX, float softY);
        /*0x275486c*/ void EnableMasking();
        /*0x27549e4*/ void DisableMasking();
        /*0x2754964*/ void UpdateMask();
        /*0x2754b9c*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x2754cac*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x2754e54*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x2754e8c*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x275501c*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x2755384*/ void SetOutlineThickness(float thickness);
        /*0x27554b0*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x27555d8*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x2754ad8*/ void CreateMaterialInstance();
        /*0x2755700*/ void SetShaderDepth();
        /*0x27557e8*/ void SetCulling();
        /*0x2755a90*/ void SetPerspectiveCorrection();
        /*0x2755b14*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x27575e4*/ void ComputeMarginSize();
        /*0x2757708*/ void OnDidApplyAnimationProperties();
        /*0x2757724*/ void OnTransformParentChanged();
        /*0x2757754*/ void OnRectTransformDimensionsChange();
        /*0x27578d0*/ void InternalUpdate();
        /*0x2752ecc*/ void OnPreRenderObject();
        /*0x2740f28*/ void GenerateTextMesh();
        /*0x2757c1c*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x2757cb8*/ void SetMeshFilters(bool state);
        /*0x2757e78*/ void SetActiveSubMeshes(bool state);
        /*0x2757af0*/ void SetActiveSubTextObjectRenderers(bool state);
        /*0x2757f80*/ void DestroySubMeshObjects();
        /*0x2752230*/ void UpdateSubMeshSortingLayerID(int id);
        /*0x2752484*/ void UpdateSubMeshSortingOrder(int order);
        /*0x275805c*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x275796c*/ void UpdateSDFScale(float scaleDelta);
    }

    class TextMeshProUGUI : TMPro.TMP_Text, UnityEngine.UI.ILayoutElement
    {
        static /*0x0*/ Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;
        static /*0x38*/ Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;
        static /*0x40*/ Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;
        static /*0x48*/ Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;
        static /*0x50*/ Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;
        static /*0x58*/ Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;
        static /*0x60*/ Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;
        static /*0x68*/ Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;
        static /*0x70*/ Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;
        static /*0x78*/ Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;
        static /*0x80*/ Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;
        static /*0x88*/ Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        static /*0x90*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        static /*0x98*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        /*0x6c0*/ bool m_isRebuildingLayout;
        /*0x6c8*/ UnityEngine.Coroutine m_DelayedGraphicRebuild;
        /*0x6d0*/ UnityEngine.Coroutine m_DelayedMaterialRebuild;
        /*0x6d8*/ UnityEngine.Rect m_ClipRect;
        /*0x6e8*/ bool m_ValidRect;
        /*0x6f0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6f8*/ bool m_hasFontAssetChanged;
        /*0x700*/ TMPro.TMP_SubMeshUI[] m_subTextObjects;
        /*0x708*/ float m_previousLossyScaleY;
        /*0x710*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x718*/ UnityEngine.CanvasRenderer m_canvasRenderer;
        /*0x720*/ UnityEngine.Canvas m_canvas;
        /*0x728*/ float m_CanvasScaleFactor;
        /*0x72c*/ bool m_isFirstAllocation;
        /*0x730*/ int m_max_characters;
        /*0x738*/ UnityEngine.Material m_baseMaterial;
        /*0x740*/ bool m_isScrollRegionSet;
        /*0x744*/ UnityEngine.Vector4 m_maskOffset;
        /*0x754*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x794*/ bool m_isRegisteredForEvents;

        static /*0x275f570*/ TextMeshProUGUI();
        /*0x275f4b8*/ TextMeshProUGUI();
        /*0x2758820*/ UnityEngine.Material get_materialForRendering();
        /*0x2758880*/ bool get_autoSizeTextContainer();
        /*0x2758888*/ void set_autoSizeTextContainer(bool value);
        /*0x2758928*/ UnityEngine.Mesh get_mesh();
        /*0x2758930*/ UnityEngine.CanvasRenderer get_canvasRenderer();
        /*0x27589c4*/ void CalculateLayoutInputHorizontal();
        /*0x27589c8*/ void CalculateLayoutInputVertical();
        /*0x27589cc*/ void SetVerticesDirty();
        /*0x2758ab0*/ void SetLayoutDirty();
        /*0x2758ba0*/ void SetMaterialDirty();
        /*0x2758c8c*/ void SetAllDirty();
        /*0x2758cd0*/ System.Collections.IEnumerator DelayedGraphicRebuild();
        /*0x2758d60*/ System.Collections.IEnumerator DelayedMaterialRebuild();
        /*0x2758df0*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x2759160*/ void UpdateSubObjectPivot();
        /*0x2759234*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x2759334*/ void UpdateMaterial();
        /*0x2759420*/ UnityEngine.Vector4 get_maskOffset();
        /*0x2759434*/ void set_maskOffset(UnityEngine.Vector4 value);
        /*0x27597b0*/ void RecalculateClipping();
        /*0x27597b8*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x27599d8*/ void UpdateCulling();
        /*0x2759ba4*/ void UpdateMeshPadding();
        /*0x2759ca4*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x2759d70*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x2759e0c*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x2759eb4*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x2759f9c*/ void ClearMesh();
        /*0x275a08c*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x275a140*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x275a1f4*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x275a26c*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x275a44c*/ void UpdateVertexData();
        /*0x275a628*/ void UpdateFontAsset();
        /*0x275a638*/ void Awake();
        /*0x275a9c0*/ void OnEnable();
        /*0x275ac54*/ void OnDisable();
        /*0x275adf8*/ void OnDestroy();
        /*0x275af54*/ void LoadFontAsset();
        /*0x275aaf0*/ UnityEngine.Canvas GetCanvas();
        /*0x275b514*/ void UpdateEnvMapMatrix();
        /*0x275b790*/ void EnableMasking();
        /*0x275b934*/ void DisableMasking();
        /*0x2759460*/ void UpdateMask();
        /*0x275b938*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x275ba7c*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x275bc2c*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x275bc64*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x275bdf4*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x275c1a0*/ void SetOutlineThickness(float thickness);
        /*0x275c364*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x275c494*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x275c5c4*/ void SetShaderDepth();
        /*0x275c6e8*/ void SetCulling();
        /*0x275c9b4*/ void SetPerspectiveCorrection();
        /*0x275ca38*/ void SetMeshArrays(int size);
        /*0x275ca9c*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x275e6a0*/ void ComputeMarginSize();
        /*0x275e7c4*/ void OnDidApplyAnimationProperties();
        /*0x275e7fc*/ void OnCanvasHierarchyChanged();
        /*0x275e914*/ void OnTransformParentChanged();
        /*0x275e958*/ void OnRectTransformDimensionsChange();
        /*0x275eb54*/ void InternalUpdate();
        /*0x2758ed8*/ void OnPreRenderCanvas();
        /*0x27487a0*/ void GenerateTextMesh();
        /*0x275ee00*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x275ee9c*/ void SetActiveSubMeshes(bool state);
        /*0x275efa4*/ void DestroySubMeshObjects();
        /*0x275f080*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x275f2c8*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x275ebf0*/ void UpdateSDFScale(float scaleDelta);

        class <DelayedGraphicRebuild>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x2758d38*/ <DelayedGraphicRebuild>d__18(int <>1__state);
            /*0x275fa2c*/ void System.IDisposable.Dispose();
            /*0x275fa30*/ bool MoveNext();
            /*0x275fae8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x275faf0*/ void System.Collections.IEnumerator.Reset();
            /*0x275fb30*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DelayedMaterialRebuild>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x2758dc8*/ <DelayedMaterialRebuild>d__19(int <>1__state);
            /*0x275fb38*/ void System.IDisposable.Dispose();
            /*0x275fb3c*/ bool MoveNext();
            /*0x275fbfc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x275fc04*/ void System.Collections.IEnumerator.Reset();
            /*0x275fc44*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum Compute_DistanceTransform_EventTypes
    {
        Processing = 0,
        Completed = 1,
    }

    class TMPro_EventManager
    {
        static /*0x0*/ TMPro.FastAction<object, TMPro.Compute_DT_EventArgs> COMPUTE_DT_EVENT;
        static /*0x8*/ TMPro.FastAction<bool, UnityEngine.Material> MATERIAL_PROPERTY_EVENT;
        static /*0x10*/ TMPro.FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT;
        static /*0x18*/ TMPro.FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT;
        static /*0x20*/ TMPro.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT;
        static /*0x28*/ TMPro.FastAction<UnityEngine.GameObject, UnityEngine.Material, UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT;
        static /*0x30*/ TMPro.FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;
        static /*0x38*/ TMPro.FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT;
        static /*0x40*/ TMPro.FastAction TMP_SETTINGS_PROPERTY_EVENT;
        static /*0x48*/ TMPro.FastAction RESOURCE_LOAD_EVENT;
        static /*0x50*/ TMPro.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;
        static /*0x58*/ TMPro.FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT;

        static /*0x2760284*/ TMPro_EventManager();
        static /*0x275fc4c*/ void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, UnityEngine.Material mat);
        static /*0x275fcdc*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x275fd6c*/ void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x275fdfc*/ void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x275fe8c*/ void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial);
        static /*0x275ff24*/ void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged);
        static /*0x275ffa4*/ void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj);
        static /*0x2760024*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        static /*0x27600a4*/ void ON_TMP_SETTINGS_CHANGED();
        static /*0x2760104*/ void ON_RESOURCES_LOADED();
        static /*0x2760164*/ void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x27601f4*/ void ON_COMPUTE_DT_EVENT(object Sender, TMPro.Compute_DT_EventArgs e);
    }

    class Compute_DT_EventArgs
    {
        /*0x10*/ TMPro.Compute_DistanceTransform_EventTypes EventType;
        /*0x14*/ float ProgressPercentage;
        /*0x18*/ UnityEngine.Color[] Colors;

        /*0x2760580*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, float progress);
        /*0x27605b8*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors);
    }

    class TMPro_ExtensionMethods
    {
        static /*0x27605e8*/ int[] ToIntArray(string text);
        static /*0x276069c*/ string ArrayToString(char[] chars);
        static /*0x2760748*/ string IntToString(int[] unicodes);
        static /*0x27607f8*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
        static /*0x27608d0*/ string IntToString(int[] unicodes, int start, int length);
        static int FindInstanceID<T>(System.Collections.Generic.List<T> list, T target);
        static /*0x27609e8*/ bool Compare(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x27609f8*/ bool CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x2760a08*/ bool Compare(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x2760a38*/ bool CompareRGB(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x2760a60*/ UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x2760b20*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x2760be0*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, float tint);
        static /*0x2760cbc*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
        static /*0x2760cc8*/ bool Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, int accuracy);
        static /*0x2760d5c*/ bool Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, int accuracy);
    }

    class TMP_Math
    {
        static float FLOAT_MAX = 32767;
        static float FLOAT_MIN = -32767;
        static int INT_MAX = 2147483647;
        static int INT_MIN = -2147483647;
        static float FLOAT_UNSET = -32767;
        static int INT_UNSET = -32767;
        static /*0x0*/ UnityEngine.Vector2 MAX_16BIT;
        static /*0x8*/ UnityEngine.Vector2 MIN_16BIT;

        static /*0x2761e60*/ TMP_Math();
        static /*0x2761e1c*/ bool Approximately(float a, float b);
        static /*0x2761e4c*/ int Mod(int a, int b);
    }

    enum TMP_VertexDataUpdateFlags
    {
        None = 0,
        Vertices = 1,
        Uv0 = 2,
        Uv2 = 4,
        Uv4 = 8,
        Colors32 = 16,
        All = 255,
    }

    struct VertexGradient
    {
        /*0x10*/ UnityEngine.Color topLeft;
        /*0x20*/ UnityEngine.Color topRight;
        /*0x30*/ UnityEngine.Color bottomLeft;
        /*0x40*/ UnityEngine.Color bottomRight;

        /*0x2761ecc*/ VertexGradient(UnityEngine.Color color);
        /*0x2761ef0*/ VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    struct TMP_PageInfo
    {
        /*0x10*/ int firstCharacterIndex;
        /*0x14*/ int lastCharacterIndex;
        /*0x18*/ float ascender;
        /*0x1c*/ float baseLine;
        /*0x20*/ float descender;
    }

    struct TMP_LinkInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int hashCode;
        /*0x1c*/ int linkIdFirstCharacterIndex;
        /*0x20*/ int linkIdLength;
        /*0x24*/ int linkTextfirstCharacterIndex;
        /*0x28*/ int linkTextLength;
        /*0x30*/ char[] linkID;

        /*0x2761f0c*/ void SetLinkID(char[] text, int startIndex, int length);
        /*0x2761fe0*/ string GetLinkText();
        /*0x27620bc*/ string GetLinkID();
    }

    struct TMP_WordInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int firstCharacterIndex;
        /*0x1c*/ int lastCharacterIndex;
        /*0x20*/ int characterCount;

        /*0x2762164*/ string GetWord();
    }

    struct TMP_SpriteInfo
    {
        /*0x10*/ int spriteIndex;
        /*0x14*/ int characterIndex;
        /*0x18*/ int vertexIndex;
    }

    struct Extents
    {
        static /*0x0*/ TMPro.Extents zero;
        static /*0x10*/ TMPro.Extents uninitialized;
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        static /*0x27624f8*/ Extents();
        /*0x2762240*/ Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x276224c*/ string ToString();
    }

    struct Mesh_Extents
    {
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        /*0x276258c*/ Mesh_Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x2762598*/ string ToString();
    }

    struct WordWrapState
    {
        /*0x10*/ int previous_WordBreak;
        /*0x14*/ int total_CharacterCount;
        /*0x18*/ int visible_CharacterCount;
        /*0x1c*/ int visible_SpriteCount;
        /*0x20*/ int visible_LinkCount;
        /*0x24*/ int firstCharacterIndex;
        /*0x28*/ int firstVisibleCharacterIndex;
        /*0x2c*/ int lastCharacterIndex;
        /*0x30*/ int lastVisibleCharIndex;
        /*0x34*/ int lineNumber;
        /*0x38*/ float maxCapHeight;
        /*0x3c*/ float maxAscender;
        /*0x40*/ float maxDescender;
        /*0x44*/ float startOfLineAscender;
        /*0x48*/ float maxLineAscender;
        /*0x4c*/ float maxLineDescender;
        /*0x50*/ float pageAscender;
        /*0x54*/ TMPro.HorizontalAlignmentOptions horizontalAlignment;
        /*0x58*/ float marginLeft;
        /*0x5c*/ float marginRight;
        /*0x60*/ float xAdvance;
        /*0x64*/ float preferredWidth;
        /*0x68*/ float preferredHeight;
        /*0x6c*/ float previousLineScale;
        /*0x70*/ int wordCount;
        /*0x74*/ TMPro.FontStyles fontStyle;
        /*0x78*/ int italicAngle;
        /*0x7c*/ float fontScaleMultiplier;
        /*0x80*/ float currentFontSize;
        /*0x84*/ float baselineOffset;
        /*0x88*/ float lineOffset;
        /*0x8c*/ bool isDrivenLineSpacing;
        /*0x90*/ float glyphHorizontalAdvanceAdjustment;
        /*0x94*/ float cSpace;
        /*0x98*/ float mSpace;
        /*0xa0*/ TMPro.TMP_TextInfo textInfo;
        /*0xa8*/ TMPro.TMP_LineInfo lineInfo;
        /*0x104*/ UnityEngine.Color32 vertexColor;
        /*0x108*/ UnityEngine.Color32 underlineColor;
        /*0x10c*/ UnityEngine.Color32 strikethroughColor;
        /*0x110*/ UnityEngine.Color32 highlightColor;
        /*0x114*/ TMPro.TMP_FontStyleStack basicStyleStack;
        /*0x120*/ TMPro.TMP_TextProcessingStack<int> italicAngleStack;
        /*0x140*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> colorStack;
        /*0x160*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> underlineColorStack;
        /*0x180*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;
        /*0x1a0*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> highlightColorStack;
        /*0x1c0*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> highlightStateStack;
        /*0x1f0*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> colorGradientStack;
        /*0x218*/ TMPro.TMP_TextProcessingStack<float> sizeStack;
        /*0x238*/ TMPro.TMP_TextProcessingStack<float> indentStack;
        /*0x258*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> fontWeightStack;
        /*0x278*/ TMPro.TMP_TextProcessingStack<int> styleStack;
        /*0x298*/ TMPro.TMP_TextProcessingStack<float> baselineStack;
        /*0x2b8*/ TMPro.TMP_TextProcessingStack<int> actionStack;
        /*0x2d8*/ TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> materialReferenceStack;
        /*0x330*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> lineJustificationStack;
        /*0x350*/ int spriteAnimationID;
        /*0x358*/ TMPro.TMP_FontAsset currentFontAsset;
        /*0x360*/ TMPro.TMP_SpriteAsset currentSpriteAsset;
        /*0x368*/ UnityEngine.Material currentMaterial;
        /*0x370*/ int currentMaterialIndex;
        /*0x374*/ TMPro.Extents meshExtents;
        /*0x384*/ bool tagNoParsing;
        /*0x385*/ bool isNonBreakingSpace;
    }

    struct TagAttribute
    {
        /*0x10*/ int startIndex;
        /*0x14*/ int length;
        /*0x18*/ int hashCode;
    }

    struct RichTextTagAttribute
    {
        /*0x10*/ int nameHashCode;
        /*0x14*/ int valueHashCode;
        /*0x18*/ TMPro.TagValueType valueType;
        /*0x1c*/ int valueStartIndex;
        /*0x20*/ int valueLength;
        /*0x24*/ TMPro.TagUnitType unitType;
    }

    class TMP_Asset : UnityEngine.ScriptableObject
    {
        /*0x18*/ int m_InstanceID;
        /*0x1c*/ int hashCode;
        /*0x20*/ UnityEngine.Material material;
        /*0x28*/ int materialHashCode;

        /*0x276286c*/ TMP_Asset();
        /*0x2762844*/ int get_instanceID();
    }

    class TMP_Character : TMPro.TMP_TextElement
    {
        /*0x2762874*/ TMP_Character();
        /*0x276289c*/ TMP_Character(uint unicode, UnityEngine.TextCore.Glyph glyph);
        /*0x27628f0*/ TMP_Character(uint unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
        /*0x2762950*/ TMP_Character(uint unicode, uint glyphIndex);
    }

    struct TMP_Vertex
    {
        static /*0x0*/ TMPro.TMP_Vertex k_Zero;
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ UnityEngine.Vector2 uv;
        /*0x24*/ UnityEngine.Vector2 uv2;
        /*0x2c*/ UnityEngine.Vector2 uv4;
        /*0x34*/ UnityEngine.Color32 color;

        static /*0x27629f8*/ TMP_Vertex();
        static /*0x2762990*/ TMPro.TMP_Vertex get_zero();
    }

    struct TMP_Offset
    {
        static /*0x0*/ TMPro.TMP_Offset k_ZeroOffset;
        /*0x10*/ float m_Left;
        /*0x14*/ float m_Right;
        /*0x18*/ float m_Top;
        /*0x1c*/ float m_Bottom;

        static /*0x2762d50*/ TMP_Offset();
        static /*0x2762a5c*/ TMPro.TMP_Offset get_zero();
        static /*0x2762ad0*/ bool op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x2762b00*/ bool op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x2762bb8*/ TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, float b);
        /*0x2762ab8*/ TMP_Offset(float left, float right, float top, float bottom);
        /*0x2762ac4*/ TMP_Offset(float horizontal, float vertical);
        /*0x27629fc*/ float get_left();
        /*0x2762a04*/ void set_left(float value);
        /*0x2762a0c*/ float get_right();
        /*0x2762a14*/ void set_right(float value);
        /*0x2762a1c*/ float get_top();
        /*0x2762a24*/ void set_top(float value);
        /*0x2762a2c*/ float get_bottom();
        /*0x2762a34*/ void set_bottom(float value);
        /*0x2762a3c*/ float get_horizontal();
        /*0x2762a44*/ void set_horizontal(float value);
        /*0x2762a4c*/ float get_vertical();
        /*0x2762a54*/ void set_vertical(float value);
        /*0x2762bcc*/ int GetHashCode();
        /*0x2762c30*/ bool Equals(object obj);
        /*0x2762ca8*/ bool Equals(TMPro.TMP_Offset other);
    }

    struct HighlightState
    {
        /*0x10*/ UnityEngine.Color32 color;
        /*0x14*/ TMPro.TMP_Offset padding;

        static /*0x2762da8*/ bool op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        static /*0x2762e70*/ bool op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        /*0x2762d98*/ HighlightState(UnityEngine.Color32 color, TMPro.TMP_Offset padding);
        /*0x2762eb8*/ int GetHashCode();
        /*0x2762f24*/ bool Equals(object obj);
        /*0x2762fa4*/ bool Equals(TMPro.HighlightState other);
    }

    struct TMP_CharacterInfo
    {
        /*0x10*/ char character;
        /*0x14*/ int index;
        /*0x18*/ int stringLength;
        /*0x1c*/ TMPro.TMP_TextElementType elementType;
        /*0x20*/ TMPro.TMP_TextElement textElement;
        /*0x28*/ TMPro.TMP_FontAsset fontAsset;
        /*0x30*/ TMPro.TMP_SpriteAsset spriteAsset;
        /*0x38*/ int spriteIndex;
        /*0x40*/ UnityEngine.Material material;
        /*0x48*/ int materialReferenceIndex;
        /*0x4c*/ bool isUsingAlternateTypeface;
        /*0x50*/ float pointSize;
        /*0x54*/ int lineNumber;
        /*0x58*/ int pageNumber;
        /*0x5c*/ int vertexIndex;
        /*0x60*/ TMPro.TMP_Vertex vertex_BL;
        /*0x88*/ TMPro.TMP_Vertex vertex_TL;
        /*0xb0*/ TMPro.TMP_Vertex vertex_TR;
        /*0xd8*/ TMPro.TMP_Vertex vertex_BR;
        /*0x100*/ UnityEngine.Vector3 topLeft;
        /*0x10c*/ UnityEngine.Vector3 bottomLeft;
        /*0x118*/ UnityEngine.Vector3 topRight;
        /*0x124*/ UnityEngine.Vector3 bottomRight;
        /*0x130*/ float origin;
        /*0x134*/ float xAdvance;
        /*0x138*/ float ascender;
        /*0x13c*/ float baseLine;
        /*0x140*/ float descender;
        /*0x144*/ float adjustedAscender;
        /*0x148*/ float adjustedDescender;
        /*0x14c*/ float aspectRatio;
        /*0x150*/ float scale;
        /*0x154*/ UnityEngine.Color32 color;
        /*0x158*/ UnityEngine.Color32 underlineColor;
        /*0x15c*/ int underlineVertexIndex;
        /*0x160*/ UnityEngine.Color32 strikethroughColor;
        /*0x164*/ int strikethroughVertexIndex;
        /*0x168*/ UnityEngine.Color32 highlightColor;
        /*0x16c*/ TMPro.HighlightState highlightState;
        /*0x180*/ TMPro.FontStyles style;
        /*0x184*/ bool isVisible;
    }

    enum ColorMode
    {
        Single = 0,
        HorizontalGradient = 1,
        VerticalGradient = 2,
        FourCornersGradient = 3,
    }

    class TMP_ColorGradient : UnityEngine.ScriptableObject
    {
        static TMPro.ColorMode k_DefaultColorMode = 3;
        static /*0x0*/ UnityEngine.Color k_DefaultColor;
        /*0x18*/ TMPro.ColorMode colorMode;
        /*0x1c*/ UnityEngine.Color topLeft;
        /*0x2c*/ UnityEngine.Color topRight;
        /*0x3c*/ UnityEngine.Color bottomLeft;
        /*0x4c*/ UnityEngine.Color bottomRight;

        static /*0x27631f4*/ TMP_ColorGradient();
        /*0x2763048*/ TMP_ColorGradient();
        /*0x27630e4*/ TMP_ColorGradient(UnityEngine.Color color);
        /*0x2763150*/ TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    class TMP_Compatibility
    {
        static /*0x2763240*/ TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue);

        enum AnchorPositions
        {
            TopLeft = 0,
            Top = 1,
            TopRight = 2,
            Left = 3,
            Center = 4,
            Right = 5,
            BottomLeft = 6,
            Bottom = 7,
            BottomRight = 8,
            BaseLine = 9,
            None = 10,
        }
    }

    interface ITweenValue
    {
        void TweenValue(float floatPercentage);
        bool get_ignoreTimeScale();
        float get_duration();
        bool ValidTarget();
    }

    struct ColorTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.ColorTween.ColorTweenCallback m_Target;
        /*0x18*/ UnityEngine.Color m_StartColor;
        /*0x28*/ UnityEngine.Color m_TargetColor;
        /*0x38*/ TMPro.ColorTween.ColorTweenMode m_TweenMode;
        /*0x3c*/ float m_Duration;
        /*0x40*/ bool m_IgnoreTimeScale;

        /*0x2763264*/ UnityEngine.Color get_startColor();
        /*0x2763270*/ void set_startColor(UnityEngine.Color value);
        /*0x276327c*/ UnityEngine.Color get_targetColor();
        /*0x2763288*/ void set_targetColor(UnityEngine.Color value);
        /*0x2763294*/ TMPro.ColorTween.ColorTweenMode get_tweenMode();
        /*0x276329c*/ void set_tweenMode(TMPro.ColorTween.ColorTweenMode value);
        /*0x27632a4*/ float get_duration();
        /*0x27632ac*/ void set_duration(float value);
        /*0x27632b4*/ bool get_ignoreTimeScale();
        /*0x27632bc*/ void set_ignoreTimeScale(bool value);
        /*0x27632c8*/ void TweenValue(float floatPercentage);
        /*0x27633b4*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
        /*0x2763484*/ bool GetIgnoreTimescale();
        /*0x276348c*/ float GetDuration();
        /*0x27633a4*/ bool ValidTarget();

        enum ColorTweenMode
        {
            All = 0,
            RGB = 1,
            Alpha = 2,
        }

        class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
        {
            /*0x276343c*/ ColorTweenCallback();
        }
    }

    struct FloatTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.FloatTween.FloatTweenCallback m_Target;
        /*0x18*/ float m_StartValue;
        /*0x1c*/ float m_TargetValue;
        /*0x20*/ float m_Duration;
        /*0x24*/ bool m_IgnoreTimeScale;

        /*0x2763494*/ float get_startValue();
        /*0x276349c*/ void set_startValue(float value);
        /*0x27634a4*/ float get_targetValue();
        /*0x27634ac*/ void set_targetValue(float value);
        /*0x27634b4*/ float get_duration();
        /*0x27634bc*/ void set_duration(float value);
        /*0x27634c4*/ bool get_ignoreTimeScale();
        /*0x27634cc*/ void set_ignoreTimeScale(bool value);
        /*0x27634d8*/ void TweenValue(float floatPercentage);
        /*0x2763574*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
        /*0x2763644*/ bool GetIgnoreTimescale();
        /*0x276364c*/ float GetDuration();
        /*0x2763564*/ bool ValidTarget();

        class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
        {
            /*0x27635fc*/ FloatTweenCallback();
        }
    }

    class TweenRunner<T>
    {
        /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
        /*0x0*/ System.Collections.IEnumerator m_Tween;

        static System.Collections.IEnumerator Start(T tweenInfo);
        TweenRunner();
        void Init(UnityEngine.MonoBehaviour coroutineContainer);
        void StartTween(T info);
        void StopTween();

        class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T tweenInfo;
            /*0x0*/ float <elapsedTime>5__2;

            <Start>d__2(int <>1__state);
            void System.IDisposable.Dispose();
            bool MoveNext();
            object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            void System.Collections.IEnumerator.Reset();
            object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_DefaultControls
    {
        static float kWidth = 160;
        static float kThickHeight = 30;
        static float kThinHeight = 20;
        static /*0x0*/ UnityEngine.Vector2 s_TextElementSize;
        static /*0x8*/ UnityEngine.Vector2 s_ThickElementSize;
        static /*0x10*/ UnityEngine.Vector2 s_ThinElementSize;
        static /*0x18*/ UnityEngine.Color s_DefaultSelectableColor;
        static /*0x28*/ UnityEngine.Color s_TextColor;

        static /*0x27658c4*/ TMP_DefaultControls();
        static /*0x2763654*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size);
        static /*0x27636fc*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent);
        static /*0x27638bc*/ void SetDefaultTextValues(TMPro.TMP_Text lbl);
        static /*0x2763944*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
        static /*0x27637bc*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
        static /*0x2763954*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
        static /*0x2763a38*/ UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x2763cfc*/ UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x2763fbc*/ UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x276405c*/ UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x276485c*/ UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources);

        struct Resources
        {
            /*0x10*/ UnityEngine.Sprite standard;
            /*0x18*/ UnityEngine.Sprite background;
            /*0x20*/ UnityEngine.Sprite inputField;
            /*0x28*/ UnityEngine.Sprite knob;
            /*0x30*/ UnityEngine.Sprite checkmark;
            /*0x38*/ UnityEngine.Sprite dropdown;
            /*0x40*/ UnityEngine.Sprite mask;
        }
    }

    class TMP_Dropdown : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
    {
        static /*0x0*/ TMPro.TMP_Dropdown.OptionData s_NoOptionData;
        /*0xf8*/ UnityEngine.RectTransform m_Template;
        /*0x100*/ TMPro.TMP_Text m_CaptionText;
        /*0x108*/ UnityEngine.UI.Image m_CaptionImage;
        /*0x110*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x118*/ TMPro.TMP_Text m_ItemText;
        /*0x120*/ UnityEngine.UI.Image m_ItemImage;
        /*0x128*/ int m_Value;
        /*0x130*/ TMPro.TMP_Dropdown.OptionDataList m_Options;
        /*0x138*/ TMPro.TMP_Dropdown.DropdownEvent m_OnValueChanged;
        /*0x140*/ float m_AlphaFadeSpeed;
        /*0x148*/ UnityEngine.GameObject m_Dropdown;
        /*0x150*/ UnityEngine.GameObject m_Blocker;
        /*0x158*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> m_Items;
        /*0x160*/ TMPro.TweenRunner<TMPro.FloatTween> m_AlphaTweenRunner;
        /*0x168*/ bool validTemplate;
        /*0x170*/ UnityEngine.Coroutine m_Coroutine;

        static /*0x2768684*/ TMP_Dropdown();
        static T GetOrAddComponent<T>(UnityEngine.GameObject go);
        /*0x2765b94*/ TMP_Dropdown();
        /*0x2765954*/ UnityEngine.RectTransform get_template();
        /*0x2765650*/ void set_template(UnityEngine.RectTransform value);
        /*0x276595c*/ TMPro.TMP_Text get_captionText();
        /*0x2765658*/ void set_captionText(TMPro.TMP_Text value);
        /*0x2765964*/ UnityEngine.UI.Image get_captionImage();
        /*0x276596c*/ void set_captionImage(UnityEngine.UI.Image value);
        /*0x2765974*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x276597c*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x2765984*/ TMPro.TMP_Text get_itemText();
        /*0x2765660*/ void set_itemText(TMPro.TMP_Text value);
        /*0x276598c*/ UnityEngine.UI.Image get_itemImage();
        /*0x2765994*/ void set_itemImage(UnityEngine.UI.Image value);
        /*0x2765668*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
        /*0x276599c*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        /*0x27659b8*/ TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged();
        /*0x27659c0*/ void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value);
        /*0x27659c8*/ float get_alphaFadeSpeed();
        /*0x27659d0*/ void set_alphaFadeSpeed(float value);
        /*0x27659d8*/ int get_value();
        /*0x27659e0*/ void set_value(int value);
        /*0x2765b2c*/ void SetValueWithoutNotify(int input);
        /*0x27659e8*/ void SetValue(int value, bool sendCallback);
        /*0x2765b34*/ bool get_IsExpanded();
        /*0x2765d60*/ void Awake();
        /*0x2765e5c*/ void Start();
        /*0x2765ef0*/ void OnDisable();
        /*0x276568c*/ void RefreshShownValue();
        /*0x276611c*/ void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options);
        /*0x2766184*/ void AddOptions(System.Collections.Generic.List<string> options);
        /*0x2766304*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
        /*0x2766484*/ void ClearOptions();
        /*0x2766534*/ void SetupTemplate();
        /*0x2766b90*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x27677ec*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x27677f0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x2766b94*/ void Show();
        /*0x2767d24*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
        /*0x27681f0*/ void DestroyBlocker(UnityEngine.GameObject blocker);
        /*0x2768248*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
        /*0x27682b4*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
        /*0x276830c*/ TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate);
        /*0x2768378*/ void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item);
        /*0x2767910*/ TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, bool selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items);
        /*0x276837c*/ void AlphaFadeList(float duration, float alpha);
        /*0x2767c00*/ void AlphaFadeList(float duration, float start, float end);
        /*0x27683fc*/ void SetAlpha(float alpha);
        /*0x27677f4*/ void Hide();
        /*0x27684b0*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
        /*0x2765f84*/ void ImmediateDestroyDropdownList();
        /*0x2768550*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

        class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x18*/ TMPro.TMP_Text m_Text;
            /*0x20*/ UnityEngine.UI.Image m_Image;
            /*0x28*/ UnityEngine.RectTransform m_RectTransform;
            /*0x30*/ UnityEngine.UI.Toggle m_Toggle;

            /*0x2768864*/ DropdownItem();
            /*0x27686fc*/ TMPro.TMP_Text get_text();
            /*0x2768704*/ void set_text(TMPro.TMP_Text value);
            /*0x276870c*/ UnityEngine.UI.Image get_image();
            /*0x2768714*/ void set_image(UnityEngine.UI.Image value);
            /*0x276871c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x2768724*/ void set_rectTransform(UnityEngine.RectTransform value);
            /*0x276872c*/ UnityEngine.UI.Toggle get_toggle();
            /*0x2768734*/ void set_toggle(UnityEngine.UI.Toggle value);
            /*0x276873c*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x27687b8*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class OptionData
        {
            /*0x10*/ string m_Text;
            /*0x18*/ UnityEngine.Sprite m_Image;

            /*0x2765684*/ OptionData();
            /*0x27662dc*/ OptionData(string text);
            /*0x276645c*/ OptionData(UnityEngine.Sprite image);
            /*0x276888c*/ OptionData(string text, UnityEngine.Sprite image);
            /*0x276886c*/ string get_text();
            /*0x2768874*/ void set_text(string value);
            /*0x276887c*/ UnityEngine.Sprite get_image();
            /*0x2768884*/ void set_image(UnityEngine.Sprite value);
        }

        class OptionDataList
        {
            /*0x10*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options;

            /*0x2765c98*/ OptionDataList();
            /*0x27688b8*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
            /*0x27688c0*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        }

        class DropdownEvent : UnityEngine.Events.UnityEvent<int>
        {
            /*0x2765d18*/ DropdownEvent();
        }

        class <>c__DisplayClass69_0
        {
            /*0x10*/ TMPro.TMP_Dropdown.DropdownItem item;
            /*0x18*/ TMPro.TMP_Dropdown <>4__this;

            /*0x2767908*/ <>c__DisplayClass69_0();
            /*0x27688c8*/ void <Show>b__0(bool x);
        }

        class <DelayedDestroyDropdownList>d__81 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delay;
            /*0x28*/ TMPro.TMP_Dropdown <>4__this;

            /*0x2768528*/ <DelayedDestroyDropdownList>d__81(int <>1__state);
            /*0x27688ec*/ void System.IDisposable.Dispose();
            /*0x27688f0*/ bool MoveNext();
            /*0x276899c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x27689a4*/ void System.Collections.IEnumerator.Reset();
            /*0x27689e4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum AtlasPopulationMode
    {
        Static = 0,
        Dynamic = 1,
    }

    class TMP_FontAsset : TMPro.TMP_Asset
    {
        static /*0x0*/ Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
        static /*0x38*/ string s_DefaultMaterialSuffix;
        static /*0x40*/ System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
        static /*0x48*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
        static /*0x50*/ System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
        static /*0x58*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue;
        static /*0x60*/ System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
        static /*0x68*/ uint[] k_GlyphIndexArray;
        /*0x30*/ string m_Version;
        /*0x38*/ string m_SourceFontFileGUID;
        /*0x40*/ UnityEngine.Font m_SourceFontFile;
        /*0x48*/ TMPro.AtlasPopulationMode m_AtlasPopulationMode;
        /*0x50*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
        /*0xb0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;
        /*0xb8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
        /*0xc0*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharacterTable;
        /*0xc8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> m_CharacterLookupDictionary;
        /*0xd0*/ UnityEngine.Texture2D m_AtlasTexture;
        /*0xd8*/ UnityEngine.Texture2D[] m_AtlasTextures;
        /*0xe0*/ int m_AtlasTextureIndex;
        /*0xe4*/ bool m_IsMultiAtlasTexturesEnabled;
        /*0xe5*/ bool m_ClearDynamicDataOnBuild;
        /*0xe8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
        /*0xf0*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
        /*0xf8*/ TMPro.FaceInfo_Legacy m_fontInfo;
        /*0x100*/ UnityEngine.Texture2D atlas;
        /*0x108*/ int m_AtlasWidth;
        /*0x10c*/ int m_AtlasHeight;
        /*0x110*/ int m_AtlasPadding;
        /*0x114*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
        /*0x118*/ System.Collections.Generic.List<TMPro.TMP_Glyph> m_glyphInfoList;
        /*0x120*/ TMPro.KerningTable m_KerningTable;
        /*0x128*/ TMPro.TMP_FontFeatureTable m_FontFeatureTable;
        /*0x130*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets;
        /*0x138*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_FallbackFontAssetTable;
        /*0x140*/ TMPro.FontAssetCreationSettings m_CreationSettings;
        /*0x198*/ TMPro.TMP_FontWeightPair[] m_FontWeightTable;
        /*0x1a0*/ TMPro.TMP_FontWeightPair[] fontWeights;
        /*0x1a8*/ float normalStyle;
        /*0x1ac*/ float normalSpacingOffset;
        /*0x1b0*/ float boldStyle;
        /*0x1b4*/ float boldSpacing;
        /*0x1b8*/ byte italicStyle;
        /*0x1b9*/ byte tabSize;
        /*0x1ba*/ bool IsFontAssetLookupTablesDirty;
        /*0x1c0*/ System.Collections.Generic.HashSet<int> FallbackSearchQueryLookup;
        /*0x1c8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
        /*0x1d0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
        /*0x1d8*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
        /*0x1e0*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
        /*0x1e8*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
        /*0x1f0*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
        /*0x1f8*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharactersToAdd;
        /*0x200*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
        /*0x208*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
        /*0x210*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;

        static /*0x2770f9c*/ TMP_FontAsset();
        static /*0x2768e78*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font);
        static /*0x2768ef4*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x276ce54*/ string GetCharacters(TMPro.TMP_FontAsset fontAsset);
        static /*0x276cf34*/ int[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset);
        static /*0x276d130*/ void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x276d264*/ void UpdateFontFeaturesForFontAssetsInQueue();
        static /*0x276d6f4*/ void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x276d828*/ void UpdateAtlasTexturesForFontAssetsInQueue();
        /*0x2770c08*/ TMP_FontAsset();
        /*0x27689ec*/ string get_version();
        /*0x27689f4*/ void set_version(string value);
        /*0x27689fc*/ UnityEngine.Font get_sourceFontFile();
        /*0x2768a04*/ void set_sourceFontFile(UnityEngine.Font value);
        /*0x2768a0c*/ TMPro.AtlasPopulationMode get_atlasPopulationMode();
        /*0x2768a14*/ void set_atlasPopulationMode(TMPro.AtlasPopulationMode value);
        /*0x2768a1c*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x2768a2c*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x2768a44*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
        /*0x2768a4c*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
        /*0x2768a54*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
        /*0x2768cb0*/ System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable();
        /*0x2768cb8*/ void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value);
        /*0x2768cc0*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> get_characterLookupTable();
        /*0x2768ce4*/ UnityEngine.Texture2D get_atlasTexture();
        /*0x2768d74*/ UnityEngine.Texture2D[] get_atlasTextures();
        /*0x2768d7c*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
        /*0x2768d84*/ int get_atlasTextureCount();
        /*0x2768d90*/ bool get_isMultiAtlasTexturesEnabled();
        /*0x2768d98*/ void set_isMultiAtlasTexturesEnabled(bool value);
        /*0x2768da4*/ bool get_clearDynamicDataOnBuild();
        /*0x2768dac*/ void set_clearDynamicDataOnBuild(bool value);
        /*0x2768db8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
        /*0x2768dc0*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x2768dc8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
        /*0x2768dd0*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x2768dd8*/ TMPro.FaceInfo_Legacy get_fontInfo();
        /*0x2768de0*/ int get_atlasWidth();
        /*0x2768de8*/ void set_atlasWidth(int value);
        /*0x2768df0*/ int get_atlasHeight();
        /*0x2768df8*/ void set_atlasHeight(int value);
        /*0x2768e00*/ int get_atlasPadding();
        /*0x2768e08*/ void set_atlasPadding(int value);
        /*0x2768e10*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
        /*0x2768e18*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
        /*0x2768e20*/ TMPro.TMP_FontFeatureTable get_fontFeatureTable();
        /*0x2768e28*/ void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value);
        /*0x2768e30*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable();
        /*0x2768e38*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value);
        /*0x2768e40*/ TMPro.FontAssetCreationSettings get_creationSettings();
        /*0x2768e50*/ void set_creationSettings(TMPro.FontAssetCreationSettings value);
        /*0x2768e68*/ TMPro.TMP_FontWeightPair[] get_fontWeightTable();
        /*0x2768e70*/ void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value);
        /*0x2769418*/ void Awake();
        /*0x2768a78*/ void ReadFontAssetDefinition();
        /*0x276a0f4*/ void InitializeDictionaryLookupTables();
        /*0x276a418*/ void InitializeGlyphLookupDictionary();
        /*0x276a6a0*/ void InitializeCharacterLookupDictionary();
        /*0x276a8c8*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
        /*0x276a114*/ void AddSynthesizedCharactersAndFaceMetrics();
        /*0x276addc*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
        /*0x276b030*/ void AddCharacterToLookupCache(uint unicode, TMPro.TMP_Character character);
        /*0x276b0e8*/ void SortCharacterTable();
        /*0x276b224*/ void SortGlyphTable();
        /*0x276b360*/ void SortFontFeatureTable();
        /*0x276b564*/ void SortAllTables();
        /*0x276b58c*/ bool HasCharacter(int character);
        /*0x276b5ec*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
        /*0x276c3e4*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
        /*0x276c600*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
        /*0x276c7a8*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
        /*0x276cda0*/ bool HasCharacters(string text);
        /*0x276d018*/ uint GetGlyphIndex(uint unicode);
        /*0x276d9a0*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
        /*0x276d9c0*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
        /*0x276ea7c*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
        /*0x276ea9c*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
        /*0x276baac*/ bool TryAddCharacterInternal(uint unicode, ref TMPro.TMP_Character character);
        /*0x276f8c0*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref TMPro.TMP_Character character);
        /*0x276d99c*/ void TryAddGlyphsToAtlasTextures();
        /*0x276e5f0*/ bool TryAddGlyphsToNewAtlasTexture();
        /*0x276f688*/ void SetupNewAtlasTexture();
        /*0x276fe74*/ void UpdateAtlasTexture();
        /*0x276d3dc*/ void UpdateGlyphAdjustmentRecords();
        /*0x2770164*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
        /*0x2770454*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
        /*0x2770458*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes);
        void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
        /*0x277045c*/ void ClearFontAssetData(bool setAtlasSizeToZero);
        /*0x2770a64*/ void ClearFontAssetDataInternal();
        /*0x2770a80*/ void UpdateFontAssetData();
        /*0x277048c*/ void ClearFontAssetTables();
        /*0x27706a0*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
        /*0x27694a0*/ void UpgradeFontAsset();
        /*0x276aa90*/ void UpgradeGlyphAdjustmentTableToFontFeatureTable();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_Character, uint> <>9__124_0;
            static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__125_0;

            static /*0x277127c*/ <>c();
            /*0x27712e0*/ <>c();
            /*0x27712e8*/ uint <SortCharacterTable>b__124_0(TMPro.TMP_Character c);
            /*0x2771300*/ uint <SortGlyphTable>b__125_0(UnityEngine.TextCore.Glyph c);
        }
    }

    class FaceInfo_Legacy
    {
        /*0x10*/ string Name;
        /*0x18*/ float PointSize;
        /*0x1c*/ float Scale;
        /*0x20*/ int CharacterCount;
        /*0x24*/ float LineHeight;
        /*0x28*/ float Baseline;
        /*0x2c*/ float Ascender;
        /*0x30*/ float CapHeight;
        /*0x34*/ float Descender;
        /*0x38*/ float CenterLine;
        /*0x3c*/ float SuperscriptOffset;
        /*0x40*/ float SubscriptOffset;
        /*0x44*/ float SubSize;
        /*0x48*/ float Underline;
        /*0x4c*/ float UnderlineThickness;
        /*0x50*/ float strikethrough;
        /*0x54*/ float strikethroughThickness;
        /*0x58*/ float TabWidth;
        /*0x5c*/ float Padding;
        /*0x60*/ float AtlasWidth;
        /*0x64*/ float AtlasHeight;

        /*0x2771318*/ FaceInfo_Legacy();
    }

    class TMP_Glyph : TMPro.TMP_TextElement_Legacy
    {
        static /*0x2771320*/ TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source);
        /*0x277139c*/ TMP_Glyph();
    }

    struct FontAssetCreationSettings
    {
        /*0x10*/ string sourceFontFileName;
        /*0x18*/ string sourceFontFileGUID;
        /*0x20*/ int pointSizeSamplingMode;
        /*0x24*/ int pointSize;
        /*0x28*/ int padding;
        /*0x2c*/ int packingMode;
        /*0x30*/ int atlasWidth;
        /*0x34*/ int atlasHeight;
        /*0x38*/ int characterSetSelectionMode;
        /*0x40*/ string characterSequence;
        /*0x48*/ string referencedFontAssetGUID;
        /*0x50*/ string referencedTextAssetGUID;
        /*0x58*/ int fontStyle;
        /*0x5c*/ float fontStyleModifier;
        /*0x60*/ int renderMode;
        /*0x64*/ bool includeFontFeatures;

        /*0x27713a4*/ FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode);
    }

    struct TMP_FontWeightPair
    {
        /*0x10*/ TMPro.TMP_FontAsset regularTypeface;
        /*0x18*/ TMPro.TMP_FontAsset italicTypeface;
    }

    struct KerningPairKey
    {
        /*0x10*/ uint ascii_Left;
        /*0x14*/ uint ascii_Right;
        /*0x18*/ uint key;

        /*0x2771478*/ KerningPairKey(uint ascii_left, uint ascii_right);
    }

    struct GlyphValueRecord_Legacy
    {
        /*0x10*/ float xPlacement;
        /*0x14*/ float yPlacement;
        /*0x18*/ float xAdvance;
        /*0x1c*/ float yAdvance;

        static /*0x27714e8*/ TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b);
        /*0x2771488*/ GlyphValueRecord_Legacy(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
    }

    class KerningPair
    {
        static /*0x0*/ TMPro.KerningPair empty;
        /*0x10*/ uint m_FirstGlyph;
        /*0x14*/ TMPro.GlyphValueRecord_Legacy m_FirstGlyphAdjustments;
        /*0x24*/ uint m_SecondGlyph;
        /*0x28*/ TMPro.GlyphValueRecord_Legacy m_SecondGlyphAdjustments;
        /*0x38*/ float xOffset;
        /*0x3c*/ bool m_IgnoreSpacingAdjustments;

        static /*0x277162c*/ KerningPair();
        /*0x277153c*/ KerningPair();
        /*0x2771560*/ KerningPair(uint left, uint right, float offset);
        /*0x27715a0*/ KerningPair(uint firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments);
        /*0x27714fc*/ uint get_firstGlyph();
        /*0x2771504*/ void set_firstGlyph(uint value);
        /*0x277150c*/ TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments();
        /*0x2771518*/ uint get_secondGlyph();
        /*0x2771520*/ void set_secondGlyph(uint value);
        /*0x2771528*/ TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments();
        /*0x2771534*/ bool get_ignoreSpacingAdjustments();
        /*0x2771620*/ void ConvertLegacyKerningData();
    }

    class KerningTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.KerningPair> kerningPairs;

        /*0x2770f1c*/ KerningTable();
        /*0x27716a4*/ void AddKerningPair();
        /*0x2771878*/ int AddKerningPair(uint first, uint second, float offset);
        /*0x2771a38*/ int AddGlyphPairAdjustmentRecord(uint first, TMPro.GlyphValueRecord_Legacy firstAdjustments, uint second, TMPro.GlyphValueRecord_Legacy secondAdjustments);
        /*0x2771c38*/ void RemoveKerningPair(int left, int right);
        /*0x2771d60*/ void RemoveKerningPair(int index);
        /*0x2771db8*/ void SortKerningPairs();

        class <>c__DisplayClass3_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x2771a30*/ <>c__DisplayClass3_0();
            /*0x2771fa4*/ bool <AddKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x2771c30*/ <>c__DisplayClass4_0();
            /*0x2771fe0*/ bool <AddGlyphPairAdjustmentRecord>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ int left;
            /*0x14*/ int right;

            /*0x2771d58*/ <>c__DisplayClass5_0();
            /*0x277201c*/ bool <RemoveKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c
        {
            static /*0x0*/ TMPro.KerningTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.KerningPair, uint> <>9__7_0;
            static /*0x10*/ System.Func<TMPro.KerningPair, uint> <>9__7_1;

            static /*0x2772058*/ <>c();
            /*0x27720bc*/ <>c();
            /*0x27720c4*/ uint <SortKerningPairs>b__7_0(TMPro.KerningPair s);
            /*0x27720dc*/ uint <SortKerningPairs>b__7_1(TMPro.KerningPair s);
        }
    }

    class TMP_FontUtilities
    {
        static /*0x0*/ System.Collections.Generic.List<int> k_searchedFontAssets;

        static /*0x27720f4*/ TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x2772468*/ TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
        static /*0x27721d8*/ TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x277246c*/ TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
    }

    class TMP_FontAssetUtilities
    {
        static /*0x0*/ TMPro.TMP_FontAssetUtilities s_Instance;
        static /*0x8*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;
        static /*0x10*/ bool k_IsFontEngineInitialized;

        static /*0x277255c*/ TMP_FontAssetUtilities();
        static /*0x27725c8*/ TMPro.TMP_FontAssetUtilities get_instance();
        static /*0x2772620*/ TMPro.TMP_Character GetCharacterFromFontAsset(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x2772778*/ TMPro.TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x2772b54*/ TMPro.TMP_Character GetCharacterFromFontAssets(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x2772dac*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        static /*0x27730b8*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        /*0x27725c0*/ TMP_FontAssetUtilities();
    }

    enum FontFeatureLookupFlags
    {
        None = 0,
        IgnoreLigatures = 4,
        IgnoreSpacingAdjustments = 256,
    }

    struct TMP_GlyphValueRecord
    {
        /*0x10*/ float m_XPlacement;
        /*0x14*/ float m_YPlacement;
        /*0x18*/ float m_XAdvance;
        /*0x1c*/ float m_YAdvance;

        static /*0x2773340*/ TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b);
        /*0x2770ba4*/ TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);
        /*0x27732d4*/ TMP_GlyphValueRecord(TMPro.GlyphValueRecord_Legacy valueRecord);
        /*0x27732e0*/ TMP_GlyphValueRecord(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
        /*0x2773294*/ float get_xPlacement();
        /*0x277329c*/ void set_xPlacement(float value);
        /*0x27732a4*/ float get_yPlacement();
        /*0x27732ac*/ void set_yPlacement(float value);
        /*0x27732b4*/ float get_xAdvance();
        /*0x27732bc*/ void set_xAdvance(float value);
        /*0x27732c4*/ float get_yAdvance();
        /*0x27732cc*/ void set_yAdvance(float value);
    }

    struct TMP_GlyphAdjustmentRecord
    {
        /*0x10*/ uint m_GlyphIndex;
        /*0x14*/ TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;

        /*0x2770bb0*/ TMP_GlyphAdjustmentRecord(uint glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord);
        /*0x277337c*/ TMP_GlyphAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord);
        /*0x2773354*/ uint get_glyphIndex();
        /*0x277335c*/ void set_glyphIndex(uint value);
        /*0x2773364*/ TMPro.TMP_GlyphValueRecord get_glyphValueRecord();
        /*0x2773370*/ void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value);
    }

    class TMP_GlyphPairAdjustmentRecord
    {
        /*0x10*/ TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;
        /*0x24*/ TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;
        /*0x38*/ TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;

        /*0x2770bc0*/ TMP_GlyphPairAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord);
        /*0x27700b0*/ TMP_GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord);
        /*0x27733d0*/ TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord();
        /*0x27733e4*/ void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x27733f8*/ TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord();
        /*0x277340c*/ void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x2773420*/ TMPro.FontFeatureLookupFlags get_featureLookupFlags();
        /*0x2773428*/ void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value);
    }

    struct GlyphPairKey
    {
        /*0x10*/ uint firstGlyphIndex;
        /*0x14*/ uint secondGlyphIndex;
        /*0x18*/ uint key;

        /*0x2773430*/ GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex);
        /*0x276adb4*/ GlyphPairKey(TMPro.TMP_GlyphPairAdjustmentRecord record);
    }

    class TMP_FontFeatureTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
        /*0x18*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;

        /*0x276ffec*/ TMP_FontFeatureTable();
        /*0x2773440*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
        /*0x2773448*/ void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> value);
        /*0x276b378*/ void SortGlyphPairAdjustmentRecords();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontFeatureTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0;
            static /*0x10*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1;

            static /*0x2773450*/ <>c();
            /*0x27734b4*/ <>c();
            /*0x27734bc*/ uint <SortGlyphPairAdjustmentRecords>b__6_0(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x27734d4*/ uint <SortGlyphPairAdjustmentRecords>b__6_1(TMPro.TMP_GlyphPairAdjustmentRecord s);
        }
    }

    class TMP_InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.EventSystems.IScrollHandler
    {
        static float kHScrollSpeed = 0.05000000074505806;
        static float kVScrollSpeed = 0.10000000149011612;
        static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
        static /*0x0*/ char[] kSeparators;
        /*0xf8*/ UnityEngine.TouchScreenKeyboard m_SoftKeyboard;
        /*0x100*/ UnityEngine.RectTransform m_RectTransform;
        /*0x108*/ UnityEngine.RectTransform m_TextViewport;
        /*0x110*/ UnityEngine.UI.RectMask2D m_TextComponentRectMask;
        /*0x118*/ UnityEngine.UI.RectMask2D m_TextViewportRectMask;
        /*0x120*/ UnityEngine.Rect m_CachedViewportRect;
        /*0x130*/ TMPro.TMP_Text m_TextComponent;
        /*0x138*/ UnityEngine.RectTransform m_TextComponentRectTransform;
        /*0x140*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x148*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        /*0x150*/ TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;
        /*0x158*/ bool m_IsDrivenByLayoutComponents;
        /*0x160*/ UnityEngine.UI.LayoutGroup m_LayoutGroup;
        /*0x168*/ UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent;
        /*0x170*/ float m_ScrollPosition;
        /*0x174*/ float m_ScrollSensitivity;
        /*0x178*/ TMPro.TMP_InputField.ContentType m_ContentType;
        /*0x17c*/ TMPro.TMP_InputField.InputType m_InputType;
        /*0x180*/ char m_AsteriskChar;
        /*0x184*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
        /*0x188*/ TMPro.TMP_InputField.LineType m_LineType;
        /*0x18c*/ bool m_HideMobileInput;
        /*0x18d*/ bool m_HideSoftKeyboard;
        /*0x190*/ TMPro.TMP_InputField.CharacterValidation m_CharacterValidation;
        /*0x198*/ string m_RegexValue;
        /*0x1a0*/ float m_GlobalPointSize;
        /*0x1a4*/ int m_CharacterLimit;
        /*0x1a8*/ TMPro.TMP_InputField.SubmitEvent m_OnEndEdit;
        /*0x1b0*/ TMPro.TMP_InputField.SubmitEvent m_OnSubmit;
        /*0x1b8*/ TMPro.TMP_InputField.SelectionEvent m_OnSelect;
        /*0x1c0*/ TMPro.TMP_InputField.SelectionEvent m_OnDeselect;
        /*0x1c8*/ TMPro.TMP_InputField.TextSelectionEvent m_OnTextSelection;
        /*0x1d0*/ TMPro.TMP_InputField.TextSelectionEvent m_OnEndTextSelection;
        /*0x1d8*/ TMPro.TMP_InputField.OnChangeEvent m_OnValueChanged;
        /*0x1e0*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;
        /*0x1e8*/ TMPro.TMP_InputField.OnValidateInput m_OnValidateInput;
        /*0x1f0*/ UnityEngine.Color m_CaretColor;
        /*0x200*/ bool m_CustomCaretColor;
        /*0x204*/ UnityEngine.Color m_SelectionColor;
        /*0x218*/ string m_Text;
        /*0x220*/ float m_CaretBlinkRate;
        /*0x224*/ int m_CaretWidth;
        /*0x228*/ bool m_ReadOnly;
        /*0x229*/ bool m_RichText;
        /*0x22c*/ int m_StringPosition;
        /*0x230*/ int m_StringSelectPosition;
        /*0x234*/ int m_CaretPosition;
        /*0x238*/ int m_CaretSelectPosition;
        /*0x240*/ UnityEngine.RectTransform caretRectTrans;
        /*0x248*/ UnityEngine.UIVertex[] m_CursorVerts;
        /*0x250*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
        /*0x258*/ UnityEngine.Vector2 m_LastPosition;
        /*0x260*/ UnityEngine.Mesh m_Mesh;
        /*0x268*/ bool m_AllowInput;
        /*0x269*/ bool m_ShouldActivateNextUpdate;
        /*0x26a*/ bool m_UpdateDrag;
        /*0x26b*/ bool m_DragPositionOutOfBounds;
        /*0x26c*/ bool m_CaretVisible;
        /*0x270*/ UnityEngine.Coroutine m_BlinkCoroutine;
        /*0x278*/ float m_BlinkStartTime;
        /*0x280*/ UnityEngine.Coroutine m_DragCoroutine;
        /*0x288*/ string m_OriginalText;
        /*0x290*/ bool m_WasCanceled;
        /*0x291*/ bool m_HasDoneFocusTransition;
        /*0x298*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
        /*0x2a0*/ bool m_PreventCallback;
        /*0x2a1*/ bool m_TouchKeyboardAllowsInPlaceEditing;
        /*0x2a2*/ bool m_IsTextComponentUpdateRequired;
        /*0x2a3*/ bool m_isLastKeyBackspace;
        /*0x2a4*/ float m_PointerDownClickStartTime;
        /*0x2a8*/ float m_KeyDownStartTime;
        /*0x2ac*/ float m_DoubleClickDelay;
        /*0x2b0*/ bool m_IsCompositionActive;
        /*0x2b1*/ bool m_ShouldUpdateIMEWindowPosition;
        /*0x2b4*/ int m_PreviousIMEInsertionLine;
        /*0x2b8*/ TMPro.TMP_FontAsset m_GlobalFontAsset;
        /*0x2c0*/ bool m_OnFocusSelectAll;
        /*0x2c1*/ bool m_isSelectAll;
        /*0x2c2*/ bool m_ResetOnDeActivation;
        /*0x2c3*/ bool m_SelectionStillActive;
        /*0x2c4*/ bool m_ReleaseSelection;
        /*0x2c8*/ UnityEngine.GameObject m_PreviouslySelectedObject;
        /*0x2d0*/ bool m_RestoreOriginalTextOnEscape;
        /*0x2d1*/ bool m_isRichTextEditingAllowed;
        /*0x2d4*/ int m_LineLimit;
        /*0x2d8*/ TMPro.TMP_InputValidator m_InputValidator;
        /*0x2e0*/ bool m_isSelected;
        /*0x2e1*/ bool m_IsStringPositionDirty;
        /*0x2e2*/ bool m_IsCaretPositionDirty;
        /*0x2e3*/ bool m_forceRectTransformAdjustment;
        /*0x2e8*/ UnityEngine.Event m_ProcessingEvent;

        static /*0x277f0d8*/ TMP_InputField();
        static /*0x2777488*/ string get_clipboard();
        static /*0x2777490*/ void set_clipboard(string value);
        /*0x27736bc*/ TMP_InputField();
        /*0x27734ec*/ UnityEngine.EventSystems.BaseInput get_inputSystem();
        /*0x27735fc*/ string get_compositionString();
        /*0x2773690*/ int get_compositionLength();
        /*0x27739e0*/ UnityEngine.Mesh get_mesh();
        /*0x2773a88*/ bool get_shouldHideMobileInput();
        /*0x2773ad0*/ void set_shouldHideMobileInput(bool value);
        /*0x2773b5c*/ bool get_shouldHideSoftKeyboard();
        /*0x2773bf0*/ void set_shouldHideSoftKeyboard(bool value);
        /*0x2773d04*/ bool isKeyboardUsingEvents();
        /*0x2773d58*/ string get_text();
        /*0x2773d60*/ void set_text(string value);
        /*0x2773e9c*/ void SetTextWithoutNotify(string input);
        /*0x2773d68*/ void SetText(string value, bool sendCallback);
        /*0x277441c*/ bool get_isFocused();
        /*0x2774424*/ float get_caretBlinkRate();
        /*0x277442c*/ void set_caretBlinkRate(float value);
        /*0x27744fc*/ int get_caretWidth();
        /*0x2774504*/ void set_caretWidth(int value);
        /*0x27745d0*/ UnityEngine.RectTransform get_textViewport();
        /*0x27646b8*/ void set_textViewport(UnityEngine.RectTransform value);
        /*0x27745d8*/ TMPro.TMP_Text get_textComponent();
        /*0x2764710*/ void set_textComponent(TMPro.TMP_Text value);
        /*0x27745e0*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x2764784*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x27745e8*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
        /*0x27745f0*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
        /*0x27747a8*/ float get_scrollSensitivity();
        /*0x27747b0*/ void set_scrollSensitivity(float value);
        /*0x2774824*/ UnityEngine.Color get_caretColor();
        /*0x2774868*/ void set_caretColor(UnityEngine.Color value);
        /*0x2774894*/ bool get_customCaretColor();
        /*0x277489c*/ void set_customCaretColor(bool value);
        /*0x27748b8*/ UnityEngine.Color get_selectionColor();
        /*0x27748cc*/ void set_selectionColor(UnityEngine.Color value);
        /*0x27748f8*/ TMPro.TMP_InputField.SubmitEvent get_onEndEdit();
        /*0x2774900*/ void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x2774958*/ TMPro.TMP_InputField.SubmitEvent get_onSubmit();
        /*0x2774960*/ void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x27749b8*/ TMPro.TMP_InputField.SelectionEvent get_onSelect();
        /*0x27749c0*/ void set_onSelect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x2774a18*/ TMPro.TMP_InputField.SelectionEvent get_onDeselect();
        /*0x2774a20*/ void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x2774a78*/ TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection();
        /*0x2774a80*/ void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x2774ad8*/ TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection();
        /*0x2774ae0*/ void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x2774b38*/ TMPro.TMP_InputField.OnChangeEvent get_onValueChanged();
        /*0x2774b40*/ void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value);
        /*0x2774b98*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged();
        /*0x2774ba0*/ void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value);
        /*0x2774bf8*/ TMPro.TMP_InputField.OnValidateInput get_onValidateInput();
        /*0x2774c00*/ void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value);
        /*0x2774c58*/ int get_characterLimit();
        /*0x2774c60*/ void set_characterLimit(int value);
        /*0x2774d20*/ float get_pointSize();
        /*0x2774d28*/ void set_pointSize(float value);
        /*0x2774ec4*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x27647dc*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x2774fac*/ bool get_onFocusSelectAll();
        /*0x2774fb4*/ void set_onFocusSelectAll(bool value);
        /*0x2774fc0*/ bool get_resetOnDeActivation();
        /*0x2774fc8*/ void set_resetOnDeActivation(bool value);
        /*0x2774fd4*/ bool get_restoreOriginalTextOnEscape();
        /*0x2774fdc*/ void set_restoreOriginalTextOnEscape(bool value);
        /*0x2774fe8*/ bool get_isRichTextEditingAllowed();
        /*0x2774ff0*/ void set_isRichTextEditingAllowed(bool value);
        /*0x2774ffc*/ TMPro.TMP_InputField.ContentType get_contentType();
        /*0x2775004*/ void set_contentType(TMPro.TMP_InputField.ContentType value);
        /*0x2775134*/ TMPro.TMP_InputField.LineType get_lineType();
        /*0x277513c*/ void set_lineType(TMPro.TMP_InputField.LineType value);
        /*0x2775254*/ int get_lineLimit();
        /*0x277525c*/ void set_lineLimit(int value);
        /*0x27752c8*/ TMPro.TMP_InputField.InputType get_inputType();
        /*0x27752d0*/ void set_inputType(TMPro.TMP_InputField.InputType value);
        /*0x277536c*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
        /*0x2775374*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
        /*0x27753f8*/ TMPro.TMP_InputField.CharacterValidation get_characterValidation();
        /*0x2775400*/ void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value);
        /*0x2775484*/ TMPro.TMP_InputValidator get_inputValidator();
        /*0x277548c*/ void set_inputValidator(TMPro.TMP_InputValidator value);
        /*0x2775528*/ bool get_readOnly();
        /*0x2775530*/ void set_readOnly(bool value);
        /*0x277553c*/ bool get_richText();
        /*0x2775544*/ void set_richText(bool value);
        /*0x27755d8*/ bool get_multiLine();
        /*0x27755ec*/ char get_asteriskChar();
        /*0x27755f4*/ void set_asteriskChar(char value);
        /*0x2775668*/ bool get_wasCanceled();
        /*0x2775670*/ void ClampStringPos(ref int pos);
        /*0x27756a8*/ void ClampCaretPos(ref int pos);
        /*0x27756ec*/ int get_caretPositionInternal();
        /*0x2775704*/ void set_caretPositionInternal(int value);
        /*0x2775714*/ int get_stringPositionInternal();
        /*0x277572c*/ void set_stringPositionInternal(int value);
        /*0x2775764*/ int get_caretSelectPositionInternal();
        /*0x277577c*/ void set_caretSelectPositionInternal(int value);
        /*0x277578c*/ int get_stringSelectPositionInternal();
        /*0x27757a4*/ void set_stringSelectPositionInternal(int value);
        /*0x27757dc*/ bool get_hasSelection();
        /*0x2775818*/ int get_caretPosition();
        /*0x2775830*/ void set_caretPosition(int value);
        /*0x27758dc*/ int get_selectionAnchorPosition();
        /*0x2775864*/ void set_selectionAnchorPosition(int value);
        /*0x27758f4*/ int get_selectionFocusPosition();
        /*0x27758a0*/ void set_selectionFocusPosition(int value);
        /*0x277590c*/ int get_stringPosition();
        /*0x2775924*/ void set_stringPosition(int value);
        /*0x2775a08*/ int get_selectionStringAnchorPosition();
        /*0x2775958*/ void set_selectionStringAnchorPosition(int value);
        /*0x2775a20*/ int get_selectionStringFocusPosition();
        /*0x27759b0*/ void set_selectionStringFocusPosition(int value);
        /*0x2775a38*/ void OnEnable();
        /*0x277665c*/ void OnDisable();
        /*0x2776b48*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        /*0x2776db8*/ System.Collections.IEnumerator CaretBlink();
        /*0x2776e20*/ void SetCaretVisible();
        /*0x27744a8*/ void SetCaretActive();
        /*0x2776e58*/ void OnFocus();
        /*0x2776e68*/ void SelectAll();
        /*0x2776ea4*/ void MoveTextEnd(bool shift);
        /*0x277703c*/ void MoveTextStart(bool shift);
        /*0x2777178*/ void MoveToEndOfLine(bool shift, bool ctrl);
        /*0x27772f8*/ void MoveToStartOfLine(bool shift, bool ctrl);
        /*0x2777498*/ bool InPlaceEditing();
        /*0x277755c*/ void UpdateStringPositionFromKeyboard();
        /*0x27776a4*/ void LateUpdate();
        /*0x277897c*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x2778a80*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x2778aa0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x2778d34*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x2778da8*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x2778dc4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x27794fc*/ TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt);
        /*0x277a92c*/ bool IsValidChar(char c);
        /*0x277a94c*/ void ProcessEvent(UnityEngine.Event e);
        /*0x277a950*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x277ab4c*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x277ad0c*/ float GetScrollPositionRelativeToViewport();
        /*0x2779ebc*/ string GetSelectedString();
        /*0x277afec*/ int FindNextWordBegin();
        /*0x277a500*/ void MoveRight(bool shift, bool ctrl);
        /*0x277b0c0*/ int FindPrevWordBegin();
        /*0x277a150*/ void MoveLeft(bool shift, bool ctrl);
        /*0x277b178*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x277b2c8*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x277b414*/ int PageUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x277b620*/ int PageDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x277a908*/ void MoveDown(bool shift);
        /*0x277b82c*/ void MoveDown(bool shift, bool goToLastChar);
        /*0x277a8fc*/ void MoveUp(bool shift);
        /*0x277b9f0*/ void MoveUp(bool shift, bool goToFirstChar);
        /*0x277a914*/ void MovePageUp(bool shift);
        /*0x277bba0*/ void MovePageUp(bool shift, bool goToFirstChar);
        /*0x277a920*/ void MovePageDown(bool shift);
        /*0x277be88*/ void MovePageDown(bool shift, bool goToLastChar);
        /*0x2779f7c*/ void Delete();
        /*0x2779c98*/ void DeleteKey();
        /*0x2779910*/ void Backspace();
        /*0x277c184*/ void Append(string input);
        /*0x277c234*/ void Append(char input);
        /*0x277c470*/ void Insert(char c);
        /*0x277a114*/ void UpdateTouchKeyboardFromEditChanges();
        /*0x2778964*/ void SendOnValueChangedAndUpdateLabel();
        /*0x27743c0*/ void SendOnValueChanged();
        /*0x277c570*/ void SendOnEndEdit();
        /*0x277aaf0*/ void SendOnSubmit();
        /*0x277c5cc*/ void SendOnFocus();
        /*0x277c628*/ void SendOnFocusLost();
        /*0x277c684*/ void SendOnTextSelection();
        /*0x277c72c*/ void SendOnEndTextSelection();
        /*0x277811c*/ void SendTouchScreenKeyboardStatusChanged();
        /*0x2773ea4*/ void UpdateLabel();
        /*0x2776ccc*/ void UpdateScrollbar();
        /*0x277c7c8*/ void OnScrollbarValueChange(float value);
        /*0x2776658*/ void UpdateMaskRegions();
        /*0x277ae1c*/ void AdjustTextPositionRelativeToViewport(float relativePosition);
        /*0x2776c5c*/ int GetCaretPositionFromStringIndex(int stringIndex);
        /*0x277c804*/ int GetMinCaretPositionFromStringIndex(int stringIndex);
        /*0x277c878*/ int GetMaxCaretPositionFromStringIndex(int stringIndex);
        /*0x2776fdc*/ int GetStringIndexFromCaretPosition(int caretPosition);
        /*0x277c8e8*/ void ForceLabelUpdate();
        /*0x2774578*/ void MarkGeometryAsDirty();
        /*0x277c8ec*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x277c9b0*/ void LayoutComplete();
        /*0x277c9b4*/ void GraphicUpdateComplete();
        /*0x277c8fc*/ void UpdateGeometry();
        /*0x2776158*/ void AssignPositioningIfNeeded();
        /*0x277c9b8*/ void OnFillVBO(UnityEngine.Mesh vbo);
        /*0x277cd10*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x277e5b0*/ void CreateCursorVerts();
        /*0x277dcf4*/ void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x277e700*/ void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, float height, bool isCharVisible);
        /*0x2778190*/ char Validate(string text, int pos, char ch);
        /*0x277ec30*/ void ActivateInputField();
        /*0x2777cf0*/ void ActivateInputFieldInternal();
        /*0x277ed44*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x277ed68*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x277ed8c*/ void OnControlClick();
        /*0x27780f0*/ void ReleaseSelection();
        /*0x277698c*/ void DeactivateInputField(bool clearSelection);
        /*0x277ed90*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x277edc8*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x2775078*/ void EnforceContentType();
        /*0x277394c*/ void SetTextComponentWrapMode();
        /*0x2775550*/ void SetTextComponentRichTextMode();
        /*0x27751fc*/ void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes);
        /*0x2775354*/ void SetToCustom();
        /*0x2775510*/ void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x277ee1c*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
        /*0x277ee48*/ void CalculateLayoutInputHorizontal();
        /*0x277ee4c*/ void CalculateLayoutInputVertical();
        /*0x277ee50*/ float get_minWidth();
        /*0x277ee58*/ float get_preferredWidth();
        /*0x277ef88*/ float get_flexibleWidth();
        /*0x277ef90*/ float get_minHeight();
        /*0x277ef98*/ float get_preferredHeight();
        /*0x277f0c8*/ float get_flexibleHeight();
        /*0x277f0d0*/ int get_layoutPriority();
        /*0x2774ddc*/ void SetGlobalPointSize(float pointSize);
        /*0x2774ecc*/ void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset);
        /*0x277f16c*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

        enum ContentType
        {
            Standard = 0,
            Autocorrected = 1,
            IntegerNumber = 2,
            DecimalNumber = 3,
            Alphanumeric = 4,
            Name = 5,
            EmailAddress = 6,
            Password = 7,
            Pin = 8,
            Custom = 9,
        }

        enum InputType
        {
            Standard = 0,
            AutoCorrect = 1,
            Password = 2,
        }

        enum CharacterValidation
        {
            None = 0,
            Digit = 1,
            Integer = 2,
            Decimal = 3,
            Alphanumeric = 4,
            Name = 5,
            Regex = 6,
            EmailAddress = 7,
            CustomValidator = 8,
        }

        enum LineType
        {
            SingleLine = 0,
            MultiLineSubmit = 1,
            MultiLineNewline = 2,
        }

        class OnValidateInput : System.MulticastDelegate
        {
            /*0x279b070*/ OnValidateInput(object object, nint method);
            /*0x279b148*/ char Invoke(string text, int charIndex, char addedChar);
            /*0x279b15c*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
            /*0x279b21c*/ char EndInvoke(System.IAsyncResult result);
        }

        class SubmitEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x279b244*/ SubmitEvent();
        }

        class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x279b28c*/ OnChangeEvent();
        }

        class SelectionEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x279b2d4*/ SelectionEvent();
        }

        class TextSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0x279b31c*/ TextSelectionEvent();
        }

        class TouchScreenKeyboardEvent : UnityEngine.Events.UnityEvent<UnityEngine.TouchScreenKeyboard.Status>
        {
            /*0x279b364*/ TouchScreenKeyboardEvent();
        }

        enum EditState
        {
            Continue = 0,
            Finish = 1,
        }

        class <CaretBlink>d__276 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;

            /*0x279b3ac*/ <CaretBlink>d__276(int <>1__state);
            /*0x279b3d4*/ void System.IDisposable.Dispose();
            /*0x279b3d8*/ bool MoveNext();
            /*0x279b4e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x279b4ec*/ void System.Collections.IEnumerator.Reset();
            /*0x279b52c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <MouseDragOutsideRect>d__294 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;
            /*0x28*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x279b534*/ <MouseDragOutsideRect>d__294(int <>1__state);
            /*0x279b55c*/ void System.IDisposable.Dispose();
            /*0x279b560*/ bool MoveNext();
            /*0x279b7b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x279b7c0*/ void System.Collections.IEnumerator.Reset();
            /*0x279b800*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class SetPropertyUtility
    {
        static /*0x279b808*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
        static bool SetEquatableStruct<T>(ref T currentValue, T newValue);
        static bool SetStruct<T>(ref T currentValue, T newValue);
        static bool SetClass<T>(ref T currentValue, T newValue);
    }

    class TMP_InputValidator : UnityEngine.ScriptableObject
    {
        /*0x279b850*/ TMP_InputValidator();
        char Validate(ref string text, ref int pos, char ch);
    }

    struct TMP_LineInfo
    {
        /*0x10*/ int controlCharacterCount;
        /*0x14*/ int characterCount;
        /*0x18*/ int visibleCharacterCount;
        /*0x1c*/ int spaceCount;
        /*0x20*/ int wordCount;
        /*0x24*/ int firstCharacterIndex;
        /*0x28*/ int firstVisibleCharacterIndex;
        /*0x2c*/ int lastCharacterIndex;
        /*0x30*/ int lastVisibleCharacterIndex;
        /*0x34*/ float length;
        /*0x38*/ float lineHeight;
        /*0x3c*/ float ascender;
        /*0x40*/ float baseline;
        /*0x44*/ float descender;
        /*0x48*/ float maxAdvance;
        /*0x4c*/ float width;
        /*0x50*/ float marginLeft;
        /*0x54*/ float marginRight;
        /*0x58*/ TMPro.HorizontalAlignmentOptions alignment;
        /*0x5c*/ TMPro.Extents lineExtents;
    }

    class TMP_ListPool<T>
    {
        static /*0x0*/ TMPro.TMP_ObjectPool<System.Collections.Generic.List<T>> s_ListPool;

        static TMP_ListPool();
        static System.Collections.Generic.List<T> Get();
        static void Release(System.Collections.Generic.List<T> toRelease);

        class <>c<T>
        {
            static /*0x0*/ TMPro.TMP_ListPool.<>c<T> <>9;

            static <>c();
            <>c();
            void <.cctor>b__3_0(System.Collections.Generic.List<T> l);
        }
    }

    class TMP_MaterialManager
    {
        static /*0x0*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;
        static /*0x8*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, long> m_fallbackMaterialLookup;
        static /*0x18*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;
        static /*0x20*/ bool isFallbackListDirty;

        static /*0x279b858*/ TMP_MaterialManager();
        static /*0x279ba18*/ void OnPreRender();
        static /*0x279bca4*/ UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, int stencilID);
        static /*0x279cb4c*/ void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x279cd48*/ UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial);
        static /*0x279ceb4*/ UnityEngine.Material SetStencil(UnityEngine.Material material, int stencilID);
        static /*0x279cf70*/ void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, int stencilID);
        static /*0x279d1ec*/ void RemoveStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x279d354*/ void ReleaseBaseMaterial(UnityEngine.Material baseMaterial);
        static /*0x279d888*/ void ClearMaterials();
        static /*0x279da44*/ int GetStencilID(UnityEngine.GameObject obj);
        static /*0x279deb0*/ UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial);
        static /*0x279dd10*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
        static /*0x279e0ac*/ UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
        static /*0x279e5f0*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
        static /*0x279ea10*/ void AddFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x279eb54*/ void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x279ba90*/ void CleanupFallbackMaterials();
        static /*0x279ed28*/ void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial);
        static /*0x279e37c*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);

        class FallbackMaterial
        {
            /*0x10*/ long fallbackID;
            /*0x18*/ UnityEngine.Material sourceMaterial;
            /*0x20*/ int sourceMaterialCRC;
            /*0x28*/ UnityEngine.Material fallbackMaterial;
            /*0x30*/ int count;

            /*0x279e5e8*/ FallbackMaterial();
        }

        class MaskingMaterial
        {
            /*0x10*/ UnityEngine.Material baseMaterial;
            /*0x18*/ UnityEngine.Material stencilMaterial;
            /*0x20*/ int count;
            /*0x24*/ int stencilID;

            /*0x279cb44*/ MaskingMaterial();
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x279ceac*/ <>c__DisplayClass9_0();
            /*0x279ef1c*/ bool <GetBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x279d1e4*/ <>c__DisplayClass11_0();
            /*0x279ef8c*/ bool <AddMaskingMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x279d34c*/ <>c__DisplayClass12_0();
            /*0x279effc*/ bool <RemoveStencilMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ UnityEngine.Material baseMaterial;

            /*0x279d880*/ <>c__DisplayClass13_0();
            /*0x279f06c*/ bool <ReleaseBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }
    }

    enum VertexSortingOrder
    {
        Normal = 0,
        Reverse = 1,
    }

    struct TMP_MeshInfo
    {
        static /*0x0*/ UnityEngine.Color32 s_DefaultColor;
        static /*0x4*/ UnityEngine.Vector3 s_DefaultNormal;
        static /*0x10*/ UnityEngine.Vector4 s_DefaultTangent;
        static /*0x20*/ UnityEngine.Bounds s_DefaultBounds;
        /*0x10*/ UnityEngine.Mesh mesh;
        /*0x18*/ int vertexCount;
        /*0x20*/ UnityEngine.Vector3[] vertices;
        /*0x28*/ UnityEngine.Vector3[] normals;
        /*0x30*/ UnityEngine.Vector4[] tangents;
        /*0x38*/ UnityEngine.Vector2[] uvs0;
        /*0x40*/ UnityEngine.Vector2[] uvs2;
        /*0x48*/ UnityEngine.Color32[] colors32;
        /*0x50*/ int[] triangles;
        /*0x58*/ UnityEngine.Material material;

        static /*0x27a158c*/ TMP_MeshInfo();
        /*0x279f0dc*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size);
        /*0x279f5d4*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size, bool isVolumetric);
        /*0x279fd58*/ void ResizeMeshInfo(int size);
        /*0x27a01cc*/ void ResizeMeshInfo(int size, bool isVolumetric);
        /*0x27a0aa0*/ void Clear();
        /*0x27a0b44*/ void Clear(bool uploadChanges);
        /*0x27a0c7c*/ void ClearUnusedVertices();
        /*0x27a0cb8*/ void ClearUnusedVertices(int startIndex);
        /*0x27a0cec*/ void ClearUnusedVertices(int startIndex, bool updateMesh);
        /*0x27a0db0*/ void SortGeometry(TMPro.VertexSortingOrder order);
        /*0x27a13b8*/ void SortGeometry(System.Collections.Generic.IList<int> sortingOrder);
        /*0x27a0e2c*/ void SwapVertexData(int src, int dst);
    }

    class TMP_ObjectPool<T>
    {
        /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        /*0x0*/ int <countAll>k__BackingField;

        TMP_ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease);
        int get_countAll();
        void set_countAll(int value);
        int get_countActive();
        int get_countInactive();
        T Get();
        void Release(T element);
    }

    class TMP_ResourceManager
    {
        static /*0x0*/ TMPro.TMP_ResourceManager s_instance;
        static /*0x8*/ TMPro.TMP_Settings s_TextSettings;
        static /*0x10*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> s_FontAssetReferences;
        static /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> s_FontAssetReferenceLookup;

        static /*0x27a160c*/ TMP_ResourceManager();
        static /*0x27a1710*/ TMPro.TMP_Settings GetTextSettings();
        static /*0x27a1820*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x27a1974*/ bool TryGetFontAsset(int hashcode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x27a1a08*/ void RebuildFontAssetCache(int instanceID);
        /*0x27a1708*/ TMP_ResourceManager();
    }

    enum MarkupTag
    {
        BOLD = 66,
        SLASH_BOLD = 1613,
        ITALIC = 73,
        SLASH_ITALIC = 1606,
        UNDERLINE = 85,
        SLASH_UNDERLINE = 1626,
        STRIKETHROUGH = 83,
        SLASH_STRIKETHROUGH = 1628,
        MARK = 2699125,
        SLASH_MARK = 57644506,
        SUBSCRIPT = 92132,
        SLASH_SUBSCRIPT = 1770219,
        SUPERSCRIPT = 92150,
        SLASH_SUPERSCRIPT = 1770233,
        COLOR = 81999901,
        SLASH_COLOR = 1909026194,
        ALPHA = 75165780,
        A = 65,
        SLASH_A = 1614,
        SIZE = 3061285,
        SLASH_SIZE = 58429962,
        SPRITE = -991527447,
        NO_BREAK = 2856657,
        SLASH_NO_BREAK = 57477502,
        STYLE = 100252951,
        SLASH_STYLE = 1927738392,
        FONT = 2586451,
        SLASH_FONT = 57747708,
        SLASH_MATERIAL = -1100708252,
        LINK = 2656128,
        SLASH_LINK = 57686191,
        FONT_WEIGHT = -1889896162,
        SLASH_FONT_WEIGHT = -757976431,
        NO_PARSE = -408011596,
        SLASH_NO_PARSE = -294095813,
        POSITION = 85420,
        SLASH_POSITION = 1777699,
        VERTICAL_OFFSET = 1952379995,
        SLASH_VERTICAL_OFFSET = -11107948,
        SPACE = 100083556,
        SLASH_SPACE = 1927873067,
        PAGE = 2808691,
        SLASH_PAGE = 58683868,
        ALIGN = 75138797,
        SLASH_ALIGN = 1916026786,
        WIDTH = 105793766,
        SLASH_WIDTH = 1923459625,
        GRADIENT = -1999759898,
        SLASH_GRADIENT = -1854491959,
        CHARACTER_SPACE = -1584382009,
        SLASH_CHARACTER_SPACE = -1394426712,
        MONOSPACE = -1340221943,
        SLASH_MONOSPACE = -1638865562,
        CLASS = 82115566,
        INDENT = -1514123076,
        SLASH_INDENT = -1496889389,
        LINE_INDENT = -844305121,
        SLASH_LINE_INDENT = 93886352,
        MARGIN = -1355614050,
        SLASH_MARGIN = -1649644303,
        MARGIN_LEFT = -272933656,
        MARGIN_RIGHT = -447416589,
        LINE_HEIGHT = -799081892,
        SLASH_LINE_HEIGHT = 200452819,
        ACTION = -1827519330,
        SLASH_ACTION = -1187217679,
        SCALE = 100553336,
        SLASH_SCALE = 1928413879,
        ROTATE = -1000007783,
        SLASH_ROTATE = -764695562,
        LOWERCASE = -1506899689,
        SLASH_LOWERCASE = -1451284584,
        ALLCAPS = 218273952,
        SLASH_ALLCAPS = -797437649,
        UPPERCASE = -305409418,
        SLASH_UPPERCASE = -582368199,
        SMALLCAPS = -766062114,
        SLASH_SMALLCAPS = 199921873,
        LIGA = 2655971,
        SLASH_LIGA = 57686604,
        FRAC = 2598518,
        SLASH_FRAC = 57774681,
        NAME = 2875623,
        INDEX = 84268030,
        TINT = 2960519,
        ANIM = 2283339,
        MATERIAL = 825491659,
        HREF = 2535353,
        ANGLE = 75347905,
        RED = 91635,
        GREEN = 87065851,
        BLUE = 2457214,
        YELLOW = -882444668,
        ORANGE = -1108587920,
        BLACK = 81074727,
        WHITE = 105680263,
        PURPLE = -1250222130,
        BR = 2256,
        ZWSP = 3288238,
        NBSP = 2869039,
        SHY = 92674,
        LEFT = 2660507,
        RIGHT = 99937376,
        CENTER = -1591113269,
        JUSTIFIED = 817091359,
        FLUSH = 85552164,
        NONE = 2857034,
        PLUS = 43,
        MINUS = 45,
        PX = 2568,
        PLUS_PX = 49507,
        MINUS_PX = 47461,
        EM = 2216,
        PLUS_EM = 49091,
        MINUS_EM = 46789,
        PCT = 85031,
        PLUS_PCT = 1634348,
        MINUS_PCT = 1567082,
        PERCENTAGE = 37,
        PLUS_PERCENTAGE = 1454,
        MINUS_PERCENTAGE = 1512,
        TRUE = 2932022,
        FALSE = 85422813,
        INVALID = 1585415185,
        NORMAL = -1183493901,
        DEFAULT = -620974005,
    }

    enum TagValueType
    {
        None = 0,
        NumericalValue = 1,
        StringValue = 2,
        ColorValue = 4,
    }

    enum TagUnitType
    {
        Pixels = 0,
        FontUnits = 1,
        Percentage = 2,
    }

    class CodePoint
    {
        static uint SPACE = 32;
        static uint DOUBLE_QUOTE = 34;
        static uint NUMBER_SIGN = 35;
        static uint PERCENTAGE = 37;
        static uint PLUS = 43;
        static uint MINUS = 45;
        static uint PERIOD = 46;
        static uint HYPHEN_MINUS = 45;
        static uint SOFT_HYPHEN = 173;
        static uint HYPHEN = 8208;
        static uint NON_BREAKING_HYPHEN = 8209;
        static uint ZERO_WIDTH_SPACE = 8203;
        static uint RIGHT_SINGLE_QUOTATION = 8217;
        static uint APOSTROPHE = 39;
        static uint WORD_JOINER = 8288;
        static uint HIGH_SURROGATE_START = 55296;
        static uint HIGH_SURROGATE_END = 56319;
        static uint LOW_SURROGATE_START = 56320;
        static uint LOW_SURROGATE_END = 57343;
        static uint UNICODE_PLANE01_START = 65536;
    }

    class TMP_ScrollbarEventHandler : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler
    {
        /*0x18*/ bool isSelected;

        /*0x27a1c74*/ TMP_ScrollbarEventHandler();
        /*0x27a1b20*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x27a1b88*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x27a1c00*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
    }

    class TMP_SelectionCaret : UnityEngine.UI.MaskableGraphic
    {
        /*0x27a1d50*/ TMP_SelectionCaret();
        /*0x27a1c7c*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x27a1d4c*/ void UpdateGeometry();
    }

    class TMP_Settings : UnityEngine.ScriptableObject
    {
        static /*0x0*/ TMPro.TMP_Settings s_Instance;
        /*0x18*/ bool m_enableWordWrapping;
        /*0x19*/ bool m_enableKerning;
        /*0x1a*/ bool m_enableExtraPadding;
        /*0x1b*/ bool m_enableTintAllSprites;
        /*0x1c*/ bool m_enableParseEscapeCharacters;
        /*0x1d*/ bool m_EnableRaycastTarget;
        /*0x1e*/ bool m_GetFontFeaturesAtRuntime;
        /*0x20*/ int m_missingGlyphCharacter;
        /*0x24*/ bool m_warningsDisabled;
        /*0x28*/ TMPro.TMP_FontAsset m_defaultFontAsset;
        /*0x30*/ string m_defaultFontAssetPath;
        /*0x38*/ float m_defaultFontSize;
        /*0x3c*/ float m_defaultAutoSizeMinRatio;
        /*0x40*/ float m_defaultAutoSizeMaxRatio;
        /*0x44*/ UnityEngine.Vector2 m_defaultTextMeshProTextContainerSize;
        /*0x4c*/ UnityEngine.Vector2 m_defaultTextMeshProUITextContainerSize;
        /*0x54*/ bool m_autoSizeTextContainer;
        /*0x55*/ bool m_IsTextObjectScaleStatic;
        /*0x58*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_fallbackFontAssets;
        /*0x60*/ bool m_matchMaterialPreset;
        /*0x68*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x70*/ string m_defaultSpriteAssetPath;
        /*0x78*/ bool m_enableEmojiSupport;
        /*0x7c*/ uint m_MissingCharacterSpriteUnicode;
        /*0x80*/ string m_defaultColorGradientPresetsPath;
        /*0x88*/ TMPro.TMP_StyleSheet m_defaultStyleSheet;
        /*0x90*/ string m_StyleSheetsResourcePath;
        /*0x98*/ UnityEngine.TextAsset m_leadingCharacters;
        /*0xa0*/ UnityEngine.TextAsset m_followingCharacters;
        /*0xa8*/ TMPro.TMP_Settings.LineBreakingTable m_linebreakingRules;
        /*0xb0*/ bool m_UseModernHangulLineBreakingRules;

        static /*0x27a1d58*/ string get_version();
        static /*0x27a1d98*/ bool get_enableWordWrapping();
        static /*0x27a1e80*/ bool get_enableKerning();
        static /*0x27a1e9c*/ bool get_enableExtraPadding();
        static /*0x27a1eb8*/ bool get_enableTintAllSprites();
        static /*0x27a1ed4*/ bool get_enableParseEscapeCharacters();
        static /*0x27a1ef0*/ bool get_enableRaycastTarget();
        static /*0x27a1f0c*/ bool get_getFontFeaturesAtRuntime();
        static /*0x27a1f28*/ int get_missingGlyphCharacter();
        static /*0x27a1f44*/ void set_missingGlyphCharacter(int value);
        static /*0x27a1f64*/ bool get_warningsDisabled();
        static /*0x27a1f80*/ TMPro.TMP_FontAsset get_defaultFontAsset();
        static /*0x27a1f9c*/ string get_defaultFontAssetPath();
        static /*0x27a1fb8*/ float get_defaultFontSize();
        static /*0x27a1fd4*/ float get_defaultTextAutoSizingMinRatio();
        static /*0x27a1ff0*/ float get_defaultTextAutoSizingMaxRatio();
        static /*0x27a200c*/ UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize();
        static /*0x27a2028*/ UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize();
        static /*0x27a2044*/ bool get_autoSizeTextContainer();
        static /*0x27a2060*/ bool get_isTextObjectScaleStatic();
        static /*0x27a207c*/ void set_isTextObjectScaleStatic(bool value);
        static /*0x27a20a0*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets();
        static /*0x27a20bc*/ bool get_matchMaterialPreset();
        static /*0x27a20d8*/ TMPro.TMP_SpriteAsset get_defaultSpriteAsset();
        static /*0x27a20f4*/ string get_defaultSpriteAssetPath();
        static /*0x27a2110*/ bool get_enableEmojiSupport();
        static /*0x27a212c*/ void set_enableEmojiSupport(bool value);
        static /*0x27a2150*/ uint get_missingCharacterSpriteUnicode();
        static /*0x27a216c*/ void set_missingCharacterSpriteUnicode(uint value);
        static /*0x27a218c*/ string get_defaultColorGradientPresetsPath();
        static /*0x27a21a8*/ TMPro.TMP_StyleSheet get_defaultStyleSheet();
        static /*0x27a21c4*/ string get_styleSheetsResourcePath();
        static /*0x27a21e0*/ UnityEngine.TextAsset get_leadingCharacters();
        static /*0x27a21fc*/ UnityEngine.TextAsset get_followingCharacters();
        static /*0x27a2218*/ TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules();
        static /*0x27a2358*/ bool get_useModernHangulLineBreakingRules();
        static /*0x27a2374*/ void set_useModernHangulLineBreakingRules(bool value);
        static /*0x27a1db4*/ TMPro.TMP_Settings get_instance();
        static /*0x27a2398*/ TMPro.TMP_Settings LoadDefaultSettings();
        static /*0x27a2490*/ TMPro.TMP_Settings GetSettings();
        static /*0x27a250c*/ TMPro.TMP_FontAsset GetFontAsset();
        static /*0x27a2590*/ TMPro.TMP_SpriteAsset GetSpriteAsset();
        static /*0x27a2614*/ TMPro.TMP_StyleSheet GetStyleSheet();
        static /*0x27a2248*/ void LoadLinebreakingRules();
        static /*0x27a26a0*/ System.Collections.Generic.Dictionary<int, char> GetCharacters(UnityEngine.TextAsset file);
        /*0x27a27c0*/ TMP_Settings();

        class LineBreakingTable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, char> leadingCharacters;
            /*0x18*/ System.Collections.Generic.Dictionary<int, char> followingCharacters;

            /*0x27a2698*/ LineBreakingTable();
        }
    }

    class ShaderUtilities
    {
        static /*0x0*/ int ID_MainTex;
        static /*0x4*/ int ID_FaceTex;
        static /*0x8*/ int ID_FaceColor;
        static /*0xc*/ int ID_FaceDilate;
        static /*0x10*/ int ID_Shininess;
        static /*0x14*/ int ID_UnderlayColor;
        static /*0x18*/ int ID_UnderlayOffsetX;
        static /*0x1c*/ int ID_UnderlayOffsetY;
        static /*0x20*/ int ID_UnderlayDilate;
        static /*0x24*/ int ID_UnderlaySoftness;
        static /*0x28*/ int ID_UnderlayOffset;
        static /*0x2c*/ int ID_UnderlayIsoPerimeter;
        static /*0x30*/ int ID_WeightNormal;
        static /*0x34*/ int ID_WeightBold;
        static /*0x38*/ int ID_OutlineTex;
        static /*0x3c*/ int ID_OutlineWidth;
        static /*0x40*/ int ID_OutlineSoftness;
        static /*0x44*/ int ID_OutlineColor;
        static /*0x48*/ int ID_Outline2Color;
        static /*0x4c*/ int ID_Outline2Width;
        static /*0x50*/ int ID_Padding;
        static /*0x54*/ int ID_GradientScale;
        static /*0x58*/ int ID_ScaleX;
        static /*0x5c*/ int ID_ScaleY;
        static /*0x60*/ int ID_PerspectiveFilter;
        static /*0x64*/ int ID_Sharpness;
        static /*0x68*/ int ID_TextureWidth;
        static /*0x6c*/ int ID_TextureHeight;
        static /*0x70*/ int ID_BevelAmount;
        static /*0x74*/ int ID_GlowColor;
        static /*0x78*/ int ID_GlowOffset;
        static /*0x7c*/ int ID_GlowPower;
        static /*0x80*/ int ID_GlowOuter;
        static /*0x84*/ int ID_GlowInner;
        static /*0x88*/ int ID_LightAngle;
        static /*0x8c*/ int ID_EnvMap;
        static /*0x90*/ int ID_EnvMatrix;
        static /*0x94*/ int ID_EnvMatrixRotation;
        static /*0x98*/ int ID_MaskCoord;
        static /*0x9c*/ int ID_ClipRect;
        static /*0xa0*/ int ID_MaskSoftnessX;
        static /*0xa4*/ int ID_MaskSoftnessY;
        static /*0xa8*/ int ID_VertexOffsetX;
        static /*0xac*/ int ID_VertexOffsetY;
        static /*0xb0*/ int ID_UseClipRect;
        static /*0xb4*/ int ID_StencilID;
        static /*0xb8*/ int ID_StencilOp;
        static /*0xbc*/ int ID_StencilComp;
        static /*0xc0*/ int ID_StencilReadMask;
        static /*0xc4*/ int ID_StencilWriteMask;
        static /*0xc8*/ int ID_ShaderFlags;
        static /*0xcc*/ int ID_ScaleRatio_A;
        static /*0xd0*/ int ID_ScaleRatio_B;
        static /*0xd4*/ int ID_ScaleRatio_C;
        static /*0xd8*/ string Keyword_Bevel;
        static /*0xe0*/ string Keyword_Glow;
        static /*0xe8*/ string Keyword_Underlay;
        static /*0xf0*/ string Keyword_Ratios;
        static /*0xf8*/ string Keyword_MASK_SOFT;
        static /*0x100*/ string Keyword_MASK_HARD;
        static /*0x108*/ string Keyword_MASK_TEX;
        static /*0x110*/ string Keyword_Outline;
        static /*0x118*/ string ShaderTag_ZTestMode;
        static /*0x120*/ string ShaderTag_CullMode;
        static /*0x128*/ float m_clamp;
        static /*0x12c*/ bool isInitialized;
        static /*0x130*/ UnityEngine.Shader k_ShaderRef_MobileSDF;
        static /*0x138*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;

        static /*0x27a29c8*/ ShaderUtilities();
        static /*0x27a27d0*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
        static /*0x27a28cc*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
        static /*0x279c058*/ void GetShaderPropertyIDs();
        static /*0x27a2b58*/ void UpdateShaderRatios(UnityEngine.Material mat);
        static /*0x27a2fb4*/ UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material);
        static /*0x27a2ff8*/ bool IsMaskingEnabled(UnityEngine.Material material);
        static /*0x27a3194*/ float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold);
        static /*0x27a383c*/ float GetPadding(UnityEngine.Material[] materials, bool enableExtraPadding, bool isBold);
    }

    class TMP_Sprite : TMPro.TMP_TextElement_Legacy
    {
        /*0x38*/ string name;
        /*0x40*/ int hashCode;
        /*0x44*/ int unicode;
        /*0x48*/ UnityEngine.Vector2 pivot;
        /*0x50*/ UnityEngine.Sprite sprite;

        /*0x27a40bc*/ TMP_Sprite();
    }

    class TMP_SpriteAnimator : UnityEngine.MonoBehaviour
    {
        /*0x18*/ System.Collections.Generic.Dictionary<int, bool> m_animations;
        /*0x20*/ TMPro.TMP_Text m_TextComponent;

        /*0x27a4330*/ TMP_SpriteAnimator();
        /*0x27a40cc*/ void Awake();
        /*0x27a411c*/ void OnEnable();
        /*0x27a4120*/ void OnDisable();
        /*0x27a4124*/ void StopAllAnimations();
        /*0x27a4180*/ void DoSpriteAnimation(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);
        /*0x27a4268*/ System.Collections.IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);

        class <DoSpriteAnimationInternal>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_SpriteAnimator <>4__this;
            /*0x28*/ int start;
            /*0x2c*/ int end;
            /*0x30*/ TMPro.TMP_SpriteAsset spriteAsset;
            /*0x38*/ int currentCharacter;
            /*0x3c*/ int framerate;
            /*0x40*/ int <currentFrame>5__2;
            /*0x48*/ TMPro.TMP_CharacterInfo <charInfo>5__3;
            /*0x1c0*/ int <materialIndex>5__4;
            /*0x1c4*/ int <vertexIndex>5__5;
            /*0x1c8*/ TMPro.TMP_MeshInfo <meshInfo>5__6;
            /*0x218*/ float <baseSpriteScale>5__7;
            /*0x21c*/ float <elapsedTime>5__8;
            /*0x220*/ float <targetTime>5__9;

            /*0x27a4308*/ <DoSpriteAnimationInternal>d__7(int <>1__state);
            /*0x27a43b0*/ void System.IDisposable.Dispose();
            /*0x27a43b4*/ bool MoveNext();
            /*0x27a4cb8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x27a4cc0*/ void System.Collections.IEnumerator.Reset();
            /*0x27a4d00*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_SpriteAsset : TMPro.TMP_Asset
    {
        static /*0x0*/ System.Collections.Generic.HashSet<int> k_searchedSpriteAssets;
        /*0x30*/ System.Collections.Generic.Dictionary<int, int> m_NameLookup;
        /*0x38*/ System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
        /*0x40*/ string m_Version;
        /*0x48*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
        /*0xa8*/ UnityEngine.Texture spriteSheet;
        /*0xb0*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> m_SpriteCharacterTable;
        /*0xb8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> m_SpriteCharacterLookup;
        /*0xc0*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> m_SpriteGlyphTable;
        /*0xc8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteGlyph> m_SpriteGlyphLookup;
        /*0xd0*/ System.Collections.Generic.List<TMPro.TMP_Sprite> spriteInfoList;
        /*0xd8*/ System.Collections.Generic.List<TMPro.TMP_SpriteAsset> fallbackSpriteAssets;
        /*0xe0*/ bool m_IsSpriteAssetLookupTablesDirty;

        static /*0x27a5b50*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x27a5d78*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x27a5f18*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x27a5fc8*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex);
        static /*0x27a62e8*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
        static /*0x27a6488*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
        /*0x27a6864*/ TMP_SpriteAsset();
        /*0x27a4d08*/ string get_version();
        /*0x27a4d10*/ void set_version(string value);
        /*0x27a4d18*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x27a4d28*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x27a4c94*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable();
        /*0x27a5264*/ void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value);
        /*0x27a526c*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable();
        /*0x27a5290*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> value);
        /*0x27a5298*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable();
        /*0x27a52a0*/ void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value);
        /*0x27a52a8*/ void Awake();
        /*0x27a586c*/ UnityEngine.Material GetDefaultSpriteMaterial();
        /*0x27a4d40*/ void UpdateLookupTables();
        /*0x27a5954*/ int GetSpriteIndexFromHashcode(int hashCode);
        /*0x27a59dc*/ int GetSpriteIndexFromUnicode(uint unicode);
        /*0x27a5a70*/ int GetSpriteIndexFromName(string name);
        /*0x27a6538*/ void SortGlyphTable();
        /*0x27a6670*/ void SortCharacterTable();
        /*0x27a67ac*/ void SortGlyphAndCharacterTables();
        /*0x27a5330*/ void UpgradeSpriteAsset();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_SpriteAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_SpriteGlyph, uint> <>9__40_0;
            static /*0x10*/ System.Func<TMPro.TMP_SpriteCharacter, uint> <>9__41_0;

            static /*0x27a6924*/ <>c();
            /*0x27a6988*/ <>c();
            /*0x27a6990*/ uint <SortGlyphTable>b__40_0(TMPro.TMP_SpriteGlyph item);
            /*0x27a69a8*/ uint <SortCharacterTable>b__41_0(TMPro.TMP_SpriteCharacter c);
        }
    }

    class TMP_SpriteCharacter : TMPro.TMP_TextElement
    {
        /*0x30*/ string m_Name;
        /*0x38*/ int m_HashCode;

        /*0x27a67cc*/ TMP_SpriteCharacter();
        /*0x27a6a44*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteGlyph glyph);
        /*0x27a6a98*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph);
        /*0x27a6af8*/ TMP_SpriteCharacter(uint unicode, uint glyphIndex);
        /*0x27a69c0*/ string get_name();
        /*0x27a67ec*/ void set_name(string value);
        /*0x27a6a34*/ int get_hashCode();
    }

    class TMP_SpriteGlyph : UnityEngine.TextCore.Glyph
    {
        /*0x48*/ UnityEngine.Sprite sprite;

        /*0x27a67c4*/ TMP_SpriteGlyph();
        /*0x27a6b38*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
        /*0x27a6bf4*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.Sprite sprite);
    }

    class TMP_Style
    {
        static /*0x0*/ TMPro.TMP_Style k_NormalStyle;
        /*0x10*/ string m_Name;
        /*0x18*/ int m_HashCode;
        /*0x20*/ string m_OpeningDefinition;
        /*0x28*/ string m_ClosingDefinition;
        /*0x30*/ int[] m_OpeningTagArray;
        /*0x38*/ int[] m_ClosingTagArray;
        /*0x40*/ uint[] m_OpeningTagUnicodeArray;
        /*0x48*/ uint[] m_ClosingTagUnicodeArray;

        static /*0x27a6cb8*/ TMPro.TMP_Style get_NormalStyle();
        /*0x27a6d74*/ TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
        /*0x27a6e04*/ string get_name();
        /*0x27a6e0c*/ void set_name(string value);
        /*0x27a6e44*/ int get_hashCode();
        /*0x27a6e4c*/ void set_hashCode(int value);
        /*0x27a6e60*/ string get_styleOpeningDefinition();
        /*0x27a6e68*/ string get_styleClosingDefinition();
        /*0x27a6e70*/ int[] get_styleOpeningTagArray();
        /*0x27a6e78*/ int[] get_styleClosingTagArray();
        /*0x27a6f3c*/ void RefreshStyle();
    }

    class TMP_StyleSheet : UnityEngine.ScriptableObject
    {
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_Style> m_StyleLookupDictionary;

        /*0x27a759c*/ TMP_StyleSheet();
        /*0x27a7134*/ System.Collections.Generic.List<TMPro.TMP_Style> get_styles();
        /*0x27a713c*/ void Reset();
        /*0x27a7458*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x27a74e0*/ TMPro.TMP_Style GetStyle(string name);
        /*0x27a7598*/ void RefreshStyles();
        /*0x27a7140*/ void LoadStyleDictionaryInternal();
    }

    class TMP_SubMesh : UnityEngine.MonoBehaviour
    {
        /*0x18*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0x20*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x28*/ UnityEngine.Material m_material;
        /*0x30*/ UnityEngine.Material m_sharedMaterial;
        /*0x38*/ UnityEngine.Material m_fallbackMaterial;
        /*0x40*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x48*/ bool m_isDefaultMaterial;
        /*0x4c*/ float m_padding;
        /*0x50*/ UnityEngine.Renderer m_renderer;
        /*0x58*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x60*/ UnityEngine.Mesh m_mesh;
        /*0x68*/ TMPro.TextMeshPro m_TextComponent;
        /*0x70*/ bool m_isRegisteredForEvents;

        static /*0x27a7da0*/ TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference);
        /*0x27a8844*/ TMP_SubMesh();
        /*0x27a761c*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x27a7624*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x27a762c*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x27a7634*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x27a763c*/ UnityEngine.Material get_material();
        /*0x27a776c*/ void set_material(UnityEngine.Material value);
        /*0x27a7908*/ UnityEngine.Material get_sharedMaterial();
        /*0x27a7910*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x27a7950*/ UnityEngine.Material get_fallbackMaterial();
        /*0x27a7958*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x27a7a90*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x27a7a98*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x27a7aa0*/ bool get_isDefaultMaterial();
        /*0x27a7aa8*/ void set_isDefaultMaterial(bool value);
        /*0x27a7ab4*/ float get_padding();
        /*0x27a7abc*/ void set_padding(float value);
        /*0x27a7ac4*/ UnityEngine.Renderer get_renderer();
        /*0x27a7b58*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x27a7c54*/ UnityEngine.Mesh get_mesh();
        /*0x27a7d04*/ void set_mesh(UnityEngine.Mesh value);
        /*0x27a7d0c*/ TMPro.TMP_Text get_textComponent();
        /*0x27a8164*/ void OnEnable();
        /*0x27a8290*/ void OnDisable();
        /*0x27a8344*/ void OnDestroy();
        /*0x27a848c*/ void DestroySelf();
        /*0x27a7644*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x27a84fc*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x27a85bc*/ UnityEngine.Material GetSharedMaterial();
        /*0x27a7930*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x27a77e0*/ float GetPaddingForMaterial();
        /*0x27a8660*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x27a7854*/ void SetVerticesDirty();
        /*0x27a7904*/ void SetMaterialDirty();
        /*0x27a86d4*/ void UpdateMaterial();
    }

    class TMP_SubMeshUI : UnityEngine.UI.MaskableGraphic
    {
        /*0xd0*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0xd8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0xe0*/ UnityEngine.Material m_material;
        /*0xe8*/ UnityEngine.Material m_sharedMaterial;
        /*0xf0*/ UnityEngine.Material m_fallbackMaterial;
        /*0xf8*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x100*/ bool m_isDefaultMaterial;
        /*0x104*/ float m_padding;
        /*0x108*/ UnityEngine.Mesh m_mesh;
        /*0x110*/ TMPro.TextMeshProUGUI m_TextComponent;
        /*0x118*/ bool m_isRegisteredForEvents;
        /*0x119*/ bool m_materialDirty;
        /*0x11c*/ int m_materialReferenceIndex;
        /*0x120*/ UnityEngine.Transform m_RootCanvasTransform;

        static /*0x27a8f14*/ TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference);
        /*0x27a9c8c*/ TMP_SubMeshUI();
        /*0x27a884c*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x27a8854*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x27a885c*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x27a8864*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x27a886c*/ UnityEngine.Texture get_mainTexture();
        /*0x27a8928*/ UnityEngine.Material get_material();
        /*0x27a8a24*/ void set_material(UnityEngine.Material value);
        /*0x27a8b80*/ UnityEngine.Material get_sharedMaterial();
        /*0x27a8b88*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x27a8be8*/ UnityEngine.Material get_fallbackMaterial();
        /*0x27a8bf0*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x27a8d38*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x27a8d40*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x27a8d48*/ UnityEngine.Material get_materialForRendering();
        /*0x27a8da4*/ bool get_isDefaultMaterial();
        /*0x27a8dac*/ void set_isDefaultMaterial(bool value);
        /*0x27a8db8*/ float get_padding();
        /*0x27a8dc0*/ void set_padding(float value);
        /*0x27a8dc8*/ UnityEngine.Mesh get_mesh();
        /*0x27a8e78*/ void set_mesh(UnityEngine.Mesh value);
        /*0x27a8e80*/ TMPro.TMP_Text get_textComponent();
        /*0x27a92c4*/ void OnEnable();
        /*0x27a9334*/ void OnDisable();
        /*0x27a93dc*/ void OnDestroy();
        /*0x27a9588*/ void OnTransformParentChanged();
        /*0x27a95dc*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x27a8b0c*/ float GetPaddingForMaterial();
        /*0x27a96dc*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x27a9750*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x27a97c4*/ void SetAllDirty();
        /*0x27a97c8*/ void SetVerticesDirty();
        /*0x27a987c*/ void SetLayoutDirty();
        /*0x27a9880*/ void SetMaterialDirty();
        /*0x27a98c4*/ void SetPivotDirty();
        /*0x27a992c*/ UnityEngine.Transform GetRootCanvasTransform();
        /*0x27a99cc*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x27a99d0*/ void UpdateGeometry();
        /*0x27a99d4*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x27a9a0c*/ void RefreshMaterial();
        /*0x27a9a1c*/ void UpdateMaterial();
        /*0x27a9b9c*/ void RecalculateClipping();
        /*0x27a9ba4*/ UnityEngine.Material GetMaterial();
        /*0x27a8930*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x27a9bac*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x27a9c6c*/ UnityEngine.Material GetSharedMaterial();
        /*0x27a8bb8*/ void SetSharedMaterial(UnityEngine.Material mat);
    }

    interface ITextElement
    {
        UnityEngine.Material get_sharedMaterial();
        void Rebuild(UnityEngine.UI.CanvasUpdate update);
        int GetInstanceID();
    }

    enum TextAlignmentOptions
    {
        TopLeft = 257,
        Top = 258,
        TopRight = 260,
        TopJustified = 264,
        TopFlush = 272,
        TopGeoAligned = 288,
        Left = 513,
        Center = 514,
        Right = 516,
        Justified = 520,
        Flush = 528,
        CenterGeoAligned = 544,
        BottomLeft = 1025,
        Bottom = 1026,
        BottomRight = 1028,
        BottomJustified = 1032,
        BottomFlush = 1040,
        BottomGeoAligned = 1056,
        BaselineLeft = 2049,
        Baseline = 2050,
        BaselineRight = 2052,
        BaselineJustified = 2056,
        BaselineFlush = 2064,
        BaselineGeoAligned = 2080,
        MidlineLeft = 4097,
        Midline = 4098,
        MidlineRight = 4100,
        MidlineJustified = 4104,
        MidlineFlush = 4112,
        MidlineGeoAligned = 4128,
        CaplineLeft = 8193,
        Capline = 8194,
        CaplineRight = 8196,
        CaplineJustified = 8200,
        CaplineFlush = 8208,
        CaplineGeoAligned = 8224,
        Converted = 65535,
    }

    enum HorizontalAlignmentOptions
    {
        Left = 1,
        Center = 2,
        Right = 4,
        Justified = 8,
        Flush = 16,
        Geometry = 32,
    }

    enum VerticalAlignmentOptions
    {
        Top = 256,
        Middle = 512,
        Bottom = 1024,
        Baseline = 2048,
        Geometry = 4096,
        Capline = 8192,
    }

    enum TextRenderFlags
    {
        DontRender = 0,
        Render = 255,
    }

    enum TMP_TextElementType
    {
        Character = 0,
        Sprite = 1,
    }

    enum MaskingTypes
    {
        MaskOff = 0,
        MaskHard = 1,
        MaskSoft = 2,
    }

    enum TextOverflowModes
    {
        Overflow = 0,
        Ellipsis = 1,
        Masking = 2,
        Truncate = 3,
        ScrollRect = 4,
        Page = 5,
        Linked = 6,
    }

    enum MaskingOffsetMode
    {
        Percentage = 0,
        Pixel = 1,
    }

    enum TextureMappingOptions
    {
        Character = 0,
        Line = 1,
        Paragraph = 2,
        MatchAspect = 3,
    }

    enum FontStyles
    {
        Normal = 0,
        Bold = 1,
        Italic = 2,
        Underline = 4,
        LowerCase = 8,
        UpperCase = 16,
        SmallCaps = 32,
        Strikethrough = 64,
        Superscript = 128,
        Subscript = 256,
        Highlight = 512,
    }

    enum FontWeight
    {
        Thin = 100,
        ExtraLight = 200,
        Light = 300,
        Regular = 400,
        Medium = 500,
        SemiBold = 600,
        Bold = 700,
        Heavy = 800,
        Black = 900,
    }

    class TMP_Text : UnityEngine.UI.MaskableGraphic
    {
        static /*0x0*/ TMPro.MaterialReference[] m_materialReferences;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, int> m_materialReferenceIndexLookup;
        static /*0x10*/ TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> m_materialReferenceStack;
        static /*0x68*/ UnityEngine.Color32 s_colorWhite;
        static /*0x70*/ System.Func<int, string, TMPro.TMP_FontAsset> OnFontAssetRequest;
        static /*0x78*/ System.Func<int, string, TMPro.TMP_SpriteAsset> OnSpriteAssetRequest;
        static /*0x80*/ char[] m_htmlTag;
        static /*0x88*/ TMPro.RichTextTagAttribute[] m_xmlAttribute;
        static /*0x90*/ float[] m_attributeParameterValues;
        static /*0x98*/ TMPro.WordWrapState m_SavedWordWrapState;
        static /*0x410*/ TMPro.WordWrapState m_SavedLineState;
        static /*0x788*/ TMPro.WordWrapState m_SavedEllipsisState;
        static /*0xb00*/ TMPro.WordWrapState m_SavedLastValidState;
        static /*0xe78*/ TMPro.WordWrapState m_SavedSoftLineBreakState;
        static /*0x11f0*/ TMPro.TMP_TextProcessingStack<TMPro.WordWrapState> m_EllipsisInsertionCandidateStack;
        static /*0x1588*/ Unity.Profiling.ProfilerMarker k_ParseTextMarker;
        static /*0x1590*/ Unity.Profiling.ProfilerMarker k_InsertNewLineMarker;
        static /*0x1598*/ UnityEngine.Vector2 k_LargePositiveVector2;
        static /*0x15a0*/ UnityEngine.Vector2 k_LargeNegativeVector2;
        static /*0x15a8*/ float k_LargePositiveFloat;
        static /*0x15ac*/ float k_LargeNegativeFloat;
        static /*0x15b0*/ int k_LargePositiveInt;
        static /*0x15b4*/ int k_LargeNegativeInt;
        /*0xd0*/ string m_text;
        /*0xd8*/ bool m_IsTextBackingStringDirty;
        /*0xe0*/ TMPro.ITextPreprocessor m_TextPreprocessor;
        /*0xe8*/ bool m_isRightToLeft;
        /*0xf0*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0xf8*/ TMPro.TMP_FontAsset m_currentFontAsset;
        /*0x100*/ bool m_isSDFShader;
        /*0x108*/ UnityEngine.Material m_sharedMaterial;
        /*0x110*/ UnityEngine.Material m_currentMaterial;
        /*0x118*/ int m_currentMaterialIndex;
        /*0x120*/ UnityEngine.Material[] m_fontSharedMaterials;
        /*0x128*/ UnityEngine.Material m_fontMaterial;
        /*0x130*/ UnityEngine.Material[] m_fontMaterials;
        /*0x138*/ bool m_isMaterialDirty;
        /*0x13c*/ UnityEngine.Color32 m_fontColor32;
        /*0x140*/ UnityEngine.Color m_fontColor;
        /*0x150*/ UnityEngine.Color32 m_underlineColor;
        /*0x154*/ UnityEngine.Color32 m_strikethroughColor;
        /*0x158*/ bool m_enableVertexGradient;
        /*0x15c*/ TMPro.ColorMode m_colorMode;
        /*0x160*/ TMPro.VertexGradient m_fontColorGradient;
        /*0x1a0*/ TMPro.TMP_ColorGradient m_fontColorGradientPreset;
        /*0x1a8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x1b0*/ bool m_tintAllSprites;
        /*0x1b1*/ bool m_tintSprite;
        /*0x1b4*/ UnityEngine.Color32 m_spriteColor;
        /*0x1b8*/ TMPro.TMP_StyleSheet m_StyleSheet;
        /*0x1c0*/ TMPro.TMP_Style m_TextStyle;
        /*0x1c8*/ int m_TextStyleHashCode;
        /*0x1cc*/ bool m_overrideHtmlColors;
        /*0x1d0*/ UnityEngine.Color32 m_faceColor;
        /*0x1d4*/ UnityEngine.Color32 m_outlineColor;
        /*0x1d8*/ float m_outlineWidth;
        /*0x1dc*/ float m_fontSize;
        /*0x1e0*/ float m_currentFontSize;
        /*0x1e4*/ float m_fontSizeBase;
        /*0x1e8*/ TMPro.TMP_TextProcessingStack<float> m_sizeStack;
        /*0x208*/ TMPro.FontWeight m_fontWeight;
        /*0x20c*/ TMPro.FontWeight m_FontWeightInternal;
        /*0x210*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> m_FontWeightStack;
        /*0x230*/ bool m_enableAutoSizing;
        /*0x234*/ float m_maxFontSize;
        /*0x238*/ float m_minFontSize;
        /*0x23c*/ int m_AutoSizeIterationCount;
        /*0x240*/ int m_AutoSizeMaxIterationCount;
        /*0x244*/ bool m_IsAutoSizePointSizeSet;
        /*0x248*/ float m_fontSizeMin;
        /*0x24c*/ float m_fontSizeMax;
        /*0x250*/ TMPro.FontStyles m_fontStyle;
        /*0x254*/ TMPro.FontStyles m_FontStyleInternal;
        /*0x258*/ TMPro.TMP_FontStyleStack m_fontStyleStack;
        /*0x262*/ bool m_isUsingBold;
        /*0x264*/ TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;
        /*0x268*/ TMPro.VerticalAlignmentOptions m_VerticalAlignment;
        /*0x26c*/ TMPro.TextAlignmentOptions m_textAlignment;
        /*0x270*/ TMPro.HorizontalAlignmentOptions m_lineJustification;
        /*0x278*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;
        /*0x298*/ UnityEngine.Vector3[] m_textContainerLocalCorners;
        /*0x2a0*/ float m_characterSpacing;
        /*0x2a4*/ float m_cSpacing;
        /*0x2a8*/ float m_monoSpacing;
        /*0x2ac*/ float m_wordSpacing;
        /*0x2b0*/ float m_lineSpacing;
        /*0x2b4*/ float m_lineSpacingDelta;
        /*0x2b8*/ float m_lineHeight;
        /*0x2bc*/ bool m_IsDrivenLineSpacing;
        /*0x2c0*/ float m_lineSpacingMax;
        /*0x2c4*/ float m_paragraphSpacing;
        /*0x2c8*/ float m_charWidthMaxAdj;
        /*0x2cc*/ float m_charWidthAdjDelta;
        /*0x2d0*/ bool m_enableWordWrapping;
        /*0x2d1*/ bool m_isCharacterWrappingEnabled;
        /*0x2d2*/ bool m_isNonBreakingSpace;
        /*0x2d3*/ bool m_isIgnoringAlignment;
        /*0x2d4*/ float m_wordWrappingRatios;
        /*0x2d8*/ TMPro.TextOverflowModes m_overflowMode;
        /*0x2dc*/ int m_firstOverflowCharacterIndex;
        /*0x2e0*/ TMPro.TMP_Text m_linkedTextComponent;
        /*0x2e8*/ TMPro.TMP_Text parentLinkedComponent;
        /*0x2f0*/ bool m_isTextTruncated;
        /*0x2f1*/ bool m_enableKerning;
        /*0x2f4*/ float m_GlyphHorizontalAdvanceAdjustment;
        /*0x2f8*/ bool m_enableExtraPadding;
        /*0x2f9*/ bool checkPaddingRequired;
        /*0x2fa*/ bool m_isRichText;
        /*0x2fb*/ bool m_parseCtrlCharacters;
        /*0x2fc*/ bool m_isOverlay;
        /*0x2fd*/ bool m_isOrthographic;
        /*0x2fe*/ bool m_isCullingEnabled;
        /*0x2ff*/ bool m_isMaskingEnabled;
        /*0x300*/ bool isMaskUpdateRequired;
        /*0x301*/ bool m_ignoreCulling;
        /*0x304*/ TMPro.TextureMappingOptions m_horizontalMapping;
        /*0x308*/ TMPro.TextureMappingOptions m_verticalMapping;
        /*0x30c*/ float m_uvLineOffset;
        /*0x310*/ TMPro.TextRenderFlags m_renderMode;
        /*0x314*/ TMPro.VertexSortingOrder m_geometrySortingOrder;
        /*0x318*/ bool m_IsTextObjectScaleStatic;
        /*0x319*/ bool m_VertexBufferAutoSizeReduction;
        /*0x31c*/ int m_firstVisibleCharacter;
        /*0x320*/ int m_maxVisibleCharacters;
        /*0x324*/ int m_maxVisibleWords;
        /*0x328*/ int m_maxVisibleLines;
        /*0x32c*/ bool m_useMaxVisibleDescender;
        /*0x330*/ int m_pageToDisplay;
        /*0x334*/ bool m_isNewPage;
        /*0x338*/ UnityEngine.Vector4 m_margin;
        /*0x348*/ float m_marginLeft;
        /*0x34c*/ float m_marginRight;
        /*0x350*/ float m_marginWidth;
        /*0x354*/ float m_marginHeight;
        /*0x358*/ float m_width;
        /*0x360*/ TMPro.TMP_TextInfo m_textInfo;
        /*0x368*/ bool m_havePropertiesChanged;
        /*0x369*/ bool m_isUsingLegacyAnimationComponent;
        /*0x370*/ UnityEngine.Transform m_transform;
        /*0x378*/ UnityEngine.RectTransform m_rectTransform;
        /*0x380*/ UnityEngine.Vector2 m_PreviousRectTransformSize;
        /*0x388*/ UnityEngine.Vector2 m_PreviousPivotPosition;
        /*0x390*/ bool <autoSizeTextContainer>k__BackingField;
        /*0x391*/ bool m_autoSizeTextContainer;
        /*0x398*/ UnityEngine.Mesh m_mesh;
        /*0x3a0*/ bool m_isVolumetricText;
        /*0x3a8*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x3b0*/ TMPro.TMP_SpriteAnimator m_spriteAnimator;
        /*0x3b8*/ float m_flexibleHeight;
        /*0x3bc*/ float m_flexibleWidth;
        /*0x3c0*/ float m_minWidth;
        /*0x3c4*/ float m_minHeight;
        /*0x3c8*/ float m_maxWidth;
        /*0x3cc*/ float m_maxHeight;
        /*0x3d0*/ UnityEngine.UI.LayoutElement m_LayoutElement;
        /*0x3d8*/ float m_preferredWidth;
        /*0x3dc*/ float m_renderedWidth;
        /*0x3e0*/ bool m_isPreferredWidthDirty;
        /*0x3e4*/ float m_preferredHeight;
        /*0x3e8*/ float m_renderedHeight;
        /*0x3ec*/ bool m_isPreferredHeightDirty;
        /*0x3ed*/ bool m_isCalculatingPreferredValues;
        /*0x3f0*/ int m_layoutPriority;
        /*0x3f4*/ bool m_isLayoutDirty;
        /*0x3f5*/ bool m_isAwake;
        /*0x3f6*/ bool m_isWaitingOnResourceLoad;
        /*0x3f8*/ TMPro.TMP_Text.TextInputSources m_inputSource;
        /*0x3fc*/ float m_fontScaleMultiplier;
        /*0x400*/ float tag_LineIndent;
        /*0x404*/ float tag_Indent;
        /*0x408*/ TMPro.TMP_TextProcessingStack<float> m_indentStack;
        /*0x428*/ bool tag_NoParsing;
        /*0x429*/ bool m_isParsingText;
        /*0x42c*/ UnityEngine.Matrix4x4 m_FXMatrix;
        /*0x46c*/ bool m_isFXMatrixSet;
        /*0x470*/ TMPro.TMP_Text.UnicodeChar[] m_TextProcessingArray;
        /*0x478*/ int m_InternalTextProcessingArraySize;
        /*0x480*/ TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;
        /*0x488*/ int m_totalCharacterCount;
        /*0x48c*/ int m_characterCount;
        /*0x490*/ int m_firstCharacterOfLine;
        /*0x494*/ int m_firstVisibleCharacterOfLine;
        /*0x498*/ int m_lastCharacterOfLine;
        /*0x49c*/ int m_lastVisibleCharacterOfLine;
        /*0x4a0*/ int m_lineNumber;
        /*0x4a4*/ int m_lineVisibleCharacterCount;
        /*0x4a8*/ int m_pageNumber;
        /*0x4ac*/ float m_PageAscender;
        /*0x4b0*/ float m_maxTextAscender;
        /*0x4b4*/ float m_maxCapHeight;
        /*0x4b8*/ float m_ElementAscender;
        /*0x4bc*/ float m_ElementDescender;
        /*0x4c0*/ float m_maxLineAscender;
        /*0x4c4*/ float m_maxLineDescender;
        /*0x4c8*/ float m_startOfLineAscender;
        /*0x4cc*/ float m_startOfLineDescender;
        /*0x4d0*/ float m_lineOffset;
        /*0x4d4*/ TMPro.Extents m_meshExtents;
        /*0x4e4*/ UnityEngine.Color32 m_htmlColor;
        /*0x4e8*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_colorStack;
        /*0x508*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_underlineColorStack;
        /*0x528*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_strikethroughColorStack;
        /*0x548*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> m_HighlightStateStack;
        /*0x578*/ TMPro.TMP_ColorGradient m_colorGradientPreset;
        /*0x580*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> m_colorGradientStack;
        /*0x5a8*/ bool m_colorGradientPresetIsTinted;
        /*0x5ac*/ float m_tabSpacing;
        /*0x5b0*/ float m_spacing;
        /*0x5b8*/ TMPro.TMP_TextProcessingStack<int> m_TextStyleStacks;
        /*0x5c0*/ int m_TextStyleStackDepth;
        /*0x5c8*/ TMPro.TMP_TextProcessingStack<int> m_ItalicAngleStack;
        /*0x5e8*/ int m_ItalicAngle;
        /*0x5f0*/ TMPro.TMP_TextProcessingStack<int> m_actionStack;
        /*0x610*/ float m_padding;
        /*0x614*/ float m_baselineOffset;
        /*0x618*/ TMPro.TMP_TextProcessingStack<float> m_baselineOffsetStack;
        /*0x638*/ float m_xAdvance;
        /*0x63c*/ TMPro.TMP_TextElementType m_textElementType;
        /*0x640*/ TMPro.TMP_TextElement m_cached_TextElement;
        /*0x648*/ TMPro.TMP_Text.SpecialCharacter m_Ellipsis;
        /*0x668*/ TMPro.TMP_Text.SpecialCharacter m_Underline;
        /*0x688*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x690*/ TMPro.TMP_SpriteAsset m_currentSpriteAsset;
        /*0x698*/ int m_spriteCount;
        /*0x69c*/ int m_spriteIndex;
        /*0x6a0*/ int m_spriteAnimationID;
        /*0x6a4*/ bool m_ignoreActiveState;
        /*0x6a8*/ TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;
        /*0x6b8*/ decimal[] k_Power;

        static /*0x279ad4c*/ TMP_Text();
        static /*0x2782864*/ void add_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x2782958*/ void remove_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x2782a4c*/ void add_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        static /*0x2782b40*/ void remove_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        /*0x279a01c*/ TMP_Text();
        /*0x2780174*/ string get_text();
        /*0x278025c*/ void set_text(string value);
        /*0x27802f4*/ TMPro.ITextPreprocessor get_textPreprocessor();
        /*0x27802fc*/ void set_textPreprocessor(TMPro.ITextPreprocessor value);
        /*0x2780304*/ bool get_isRightToLeftText();
        /*0x278030c*/ void set_isRightToLeftText(bool value);
        /*0x2780360*/ TMPro.TMP_FontAsset get_font();
        /*0x2780368*/ void set_font(TMPro.TMP_FontAsset value);
        /*0x2780430*/ UnityEngine.Material get_fontSharedMaterial();
        /*0x2780438*/ void set_fontSharedMaterial(UnityEngine.Material value);
        /*0x2780500*/ UnityEngine.Material[] get_fontSharedMaterials();
        /*0x2780510*/ void set_fontSharedMaterials(UnityEngine.Material[] value);
        /*0x278055c*/ UnityEngine.Material get_fontMaterial();
        /*0x2780570*/ void set_fontMaterial(UnityEngine.Material value);
        /*0x278066c*/ UnityEngine.Material[] get_fontMaterials();
        /*0x2780680*/ void set_fontMaterials(UnityEngine.Material[] value);
        /*0x27806cc*/ UnityEngine.Color get_color();
        /*0x27806e0*/ void set_color(UnityEngine.Color value);
        /*0x2780758*/ float get_alpha();
        /*0x2780760*/ void set_alpha(float value);
        /*0x278078c*/ bool get_enableVertexGradient();
        /*0x2780794*/ void set_enableVertexGradient(bool value);
        /*0x27807c4*/ TMPro.VertexGradient get_colorGradient();
        /*0x27807d8*/ void set_colorGradient(TMPro.VertexGradient value);
        /*0x2780800*/ TMPro.TMP_ColorGradient get_colorGradientPreset();
        /*0x2780808*/ void set_colorGradientPreset(TMPro.TMP_ColorGradient value);
        /*0x2780824*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x278082c*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x2780868*/ bool get_tintAllSprites();
        /*0x2780870*/ void set_tintAllSprites(bool value);
        /*0x27808a0*/ TMPro.TMP_StyleSheet get_styleSheet();
        /*0x27808a8*/ void set_styleSheet(TMPro.TMP_StyleSheet value);
        /*0x27808e4*/ TMPro.TMP_Style get_textStyle();
        /*0x2780a0c*/ void set_textStyle(TMPro.TMP_Style value);
        /*0x2780a58*/ bool get_overrideColorTags();
        /*0x2780a60*/ void set_overrideColorTags(bool value);
        /*0x2780a90*/ UnityEngine.Color32 get_faceColor();
        /*0x2780e08*/ void set_faceColor(UnityEngine.Color32 value);
        /*0x2780e90*/ UnityEngine.Color32 get_outlineColor();
        /*0x2781208*/ void set_outlineColor(UnityEngine.Color32 value);
        /*0x278127c*/ float get_outlineWidth();
        /*0x2781338*/ void set_outlineWidth(float value);
        /*0x2781398*/ float get_fontSize();
        /*0x27813a0*/ void set_fontSize(float value);
        /*0x2781400*/ TMPro.FontWeight get_fontWeight();
        /*0x2781408*/ void set_fontWeight(TMPro.FontWeight value);
        /*0x2781458*/ float get_pixelsPerUnit();
        /*0x27815c8*/ bool get_enableAutoSizing();
        /*0x27815d0*/ void set_enableAutoSizing(bool value);
        /*0x278161c*/ float get_fontSizeMin();
        /*0x2781624*/ void set_fontSizeMin(float value);
        /*0x278166c*/ float get_fontSizeMax();
        /*0x2781674*/ void set_fontSizeMax(float value);
        /*0x27816bc*/ TMPro.FontStyles get_fontStyle();
        /*0x27816c4*/ void set_fontStyle(TMPro.FontStyles value);
        /*0x2781714*/ bool get_isUsingBold();
        /*0x278171c*/ TMPro.HorizontalAlignmentOptions get_horizontalAlignment();
        /*0x2781724*/ void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value);
        /*0x2781750*/ TMPro.VerticalAlignmentOptions get_verticalAlignment();
        /*0x2781758*/ void set_verticalAlignment(TMPro.VerticalAlignmentOptions value);
        /*0x2781784*/ TMPro.TextAlignmentOptions get_alignment();
        /*0x2781794*/ void set_alignment(TMPro.TextAlignmentOptions value);
        /*0x27817d8*/ float get_characterSpacing();
        /*0x27817e0*/ void set_characterSpacing(float value);
        /*0x2781830*/ float get_wordSpacing();
        /*0x2781838*/ void set_wordSpacing(float value);
        /*0x2781888*/ float get_lineSpacing();
        /*0x2781890*/ void set_lineSpacing(float value);
        /*0x27818e0*/ float get_lineSpacingAdjustment();
        /*0x27818e8*/ void set_lineSpacingAdjustment(float value);
        /*0x2781938*/ float get_paragraphSpacing();
        /*0x2781940*/ void set_paragraphSpacing(float value);
        /*0x2781990*/ float get_characterWidthAdjustment();
        /*0x2781998*/ void set_characterWidthAdjustment(float value);
        /*0x27819e8*/ bool get_enableWordWrapping();
        /*0x27819f0*/ void set_enableWordWrapping(bool value);
        /*0x2781a44*/ float get_wordWrappingRatios();
        /*0x2781a4c*/ void set_wordWrappingRatios(float value);
        /*0x2781a9c*/ TMPro.TextOverflowModes get_overflowMode();
        /*0x2781aa4*/ void set_overflowMode(TMPro.TextOverflowModes value);
        /*0x2781af4*/ bool get_isTextOverflowing();
        /*0x2781b04*/ int get_firstOverflowCharacterIndex();
        /*0x2781b0c*/ TMPro.TMP_Text get_linkedTextComponent();
        /*0x2781b14*/ void set_linkedTextComponent(TMPro.TMP_Text value);
        /*0x2781df8*/ bool get_isTextTruncated();
        /*0x2781e00*/ bool get_enableKerning();
        /*0x2781e08*/ void set_enableKerning(bool value);
        /*0x2781e5c*/ bool get_extraPadding();
        /*0x2781e64*/ void set_extraPadding(bool value);
        /*0x2781eb8*/ bool get_richText();
        /*0x2781ec0*/ void set_richText(bool value);
        /*0x2781f14*/ bool get_parseCtrlCharacters();
        /*0x2781f1c*/ void set_parseCtrlCharacters(bool value);
        /*0x2781f70*/ bool get_isOverlay();
        /*0x2781f78*/ void set_isOverlay(bool value);
        /*0x2781fcc*/ bool get_isOrthographic();
        /*0x2781fd4*/ void set_isOrthographic(bool value);
        /*0x2782004*/ bool get_enableCulling();
        /*0x278200c*/ void set_enableCulling(bool value);
        /*0x2782048*/ bool get_ignoreVisibility();
        /*0x2782050*/ void set_ignoreVisibility(bool value);
        /*0x2782070*/ TMPro.TextureMappingOptions get_horizontalMapping();
        /*0x2782078*/ void set_horizontalMapping(TMPro.TextureMappingOptions value);
        /*0x27820a4*/ TMPro.TextureMappingOptions get_verticalMapping();
        /*0x27820ac*/ void set_verticalMapping(TMPro.TextureMappingOptions value);
        /*0x27820d8*/ float get_mappingUvLineOffset();
        /*0x27820e0*/ void set_mappingUvLineOffset(float value);
        /*0x278210c*/ TMPro.TextRenderFlags get_renderMode();
        /*0x2782114*/ void set_renderMode(TMPro.TextRenderFlags value);
        /*0x2782130*/ TMPro.VertexSortingOrder get_geometrySortingOrder();
        /*0x2782138*/ void set_geometrySortingOrder(TMPro.VertexSortingOrder value);
        /*0x2782154*/ bool get_isTextObjectScaleStatic();
        /*0x278215c*/ void set_isTextObjectScaleStatic(bool value);
        /*0x27821dc*/ bool get_vertexBufferAutoSizeReduction();
        /*0x27821e4*/ void set_vertexBufferAutoSizeReduction(bool value);
        /*0x2782204*/ int get_firstVisibleCharacter();
        /*0x278220c*/ void set_firstVisibleCharacter(int value);
        /*0x2782238*/ int get_maxVisibleCharacters();
        /*0x2782240*/ void set_maxVisibleCharacters(int value);
        /*0x278226c*/ int get_maxVisibleWords();
        /*0x2782274*/ void set_maxVisibleWords(int value);
        /*0x27822a0*/ int get_maxVisibleLines();
        /*0x27822a8*/ void set_maxVisibleLines(int value);
        /*0x27822d4*/ bool get_useMaxVisibleDescender();
        /*0x27822dc*/ void set_useMaxVisibleDescender(bool value);
        /*0x278230c*/ int get_pageToDisplay();
        /*0x2782314*/ void set_pageToDisplay(int value);
        /*0x2782340*/ UnityEngine.Vector4 get_margin();
        /*0x2782354*/ void set_margin(UnityEngine.Vector4 value);
        /*0x27823f0*/ TMPro.TMP_TextInfo get_textInfo();
        /*0x27823f8*/ bool get_havePropertiesChanged();
        /*0x2782400*/ void set_havePropertiesChanged(bool value);
        /*0x2782428*/ bool get_isUsingLegacyAnimationComponent();
        /*0x2782430*/ void set_isUsingLegacyAnimationComponent(bool value);
        /*0x278243c*/ UnityEngine.Transform get_transform();
        /*0x27824d0*/ UnityEngine.RectTransform get_rectTransform();
        /*0x2782564*/ bool get_autoSizeTextContainer();
        /*0x278256c*/ void set_autoSizeTextContainer(bool value);
        /*0x2782578*/ UnityEngine.Mesh get_mesh();
        /*0x2782580*/ bool get_isVolumetricText();
        /*0x2782588*/ void set_isVolumetricText(bool value);
        /*0x27825f0*/ UnityEngine.Bounds get_bounds();
        /*0x27826a0*/ UnityEngine.Bounds get_textBounds();
        /*0x2782c34*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x2782ce8*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x2782d9c*/ TMPro.TMP_SpriteAnimator get_spriteAnimator();
        /*0x2782e88*/ float get_flexibleHeight();
        /*0x2782e90*/ float get_flexibleWidth();
        /*0x2782e98*/ float get_minWidth();
        /*0x2782ea0*/ float get_minHeight();
        /*0x2782ea8*/ float get_maxWidth();
        /*0x2782eb0*/ float get_maxHeight();
        /*0x2782eb8*/ UnityEngine.UI.LayoutElement get_layoutElement();
        /*0x2782f4c*/ float get_preferredWidth();
        /*0x27830a4*/ float get_preferredHeight();
        /*0x2783248*/ float get_renderedWidth();
        /*0x2783250*/ float get_renderedHeight();
        /*0x2783278*/ int get_layoutPriority();
        /*0x2783280*/ void LoadFontAsset();
        /*0x2783284*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x2783288*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x2783290*/ void SetFontBaseMaterial(UnityEngine.Material mat);
        /*0x2783294*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x278329c*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x27832a0*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x27832a8*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x2783368*/ void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient);
        /*0x2783420*/ void SetTextSortingOrder(TMPro.VertexSortingOrder order);
        /*0x2783424*/ void SetTextSortingOrder(int[] order);
        /*0x2783428*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x278342c*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x2783430*/ void SetOutlineThickness(float thickness);
        /*0x2783434*/ void SetShaderDepth();
        /*0x2783438*/ void SetCulling();
        /*0x278343c*/ void UpdateCulling();
        /*0x2783440*/ float GetPaddingForMaterial();
        /*0x2783560*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x2783660*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x2783668*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x278366c*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x2783670*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x2783674*/ void UpdateVertexData();
        /*0x2783678*/ void SetVertices(UnityEngine.Vector3[] vertices);
        /*0x278367c*/ void UpdateMeshPadding();
        /*0x2783680*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x2783708*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x278375c*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x2783760*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x2783764*/ void ParseInputText();
        /*0x2783864*/ void PopulateTextBackingArray(string sourceText);
        /*0x27842ec*/ void PopulateTextBackingArray(string sourceText, int start, int length);
        /*0x27843e4*/ void PopulateTextBackingArray(System.Text.StringBuilder sourceText, int start, int length);
        /*0x278450c*/ void PopulateTextBackingArray(char[] sourceText, int start, int length);
        /*0x278387c*/ void PopulateTextProcessingArray();
        /*0x27858b4*/ void SetTextInternal(string sourceText);
        /*0x2785900*/ void SetText(string sourceText, bool syncTextInputBox);
        /*0x278597c*/ void SetText(string sourceText, float arg0);
        /*0x2785c5c*/ void SetText(string sourceText, float arg0, float arg1);
        /*0x2785c78*/ void SetText(string sourceText, float arg0, float arg1, float arg2);
        /*0x2785c90*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3);
        /*0x2785ca4*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4);
        /*0x2785cb4*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
        /*0x2785cc0*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);
        /*0x278599c*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);
        /*0x2785fa4*/ void SetText(System.Text.StringBuilder sourceText);
        /*0x2785fe8*/ void SetText(System.Text.StringBuilder sourceText, int start, int length);
        /*0x2786044*/ void SetText(char[] sourceText);
        /*0x27860b8*/ void SetText(char[] sourceText, int start, int length);
        /*0x27860bc*/ void SetCharArray(char[] sourceText);
        /*0x278605c*/ void SetCharArray(char[] sourceText, int start, int length);
        /*0x278091c*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x2784cdc*/ bool ReplaceOpeningStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x27864dc*/ bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x27850fc*/ void ReplaceClosingStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x27868fc*/ void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x2784620*/ bool InsertOpeningStyleTag(TMPro.TMP_Style style, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x27854ec*/ void InsertClosingStyleTag(ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x27863c0*/ int GetMarkupTagHashCode(int[] tagDefinition, int readIndex);
        /*0x2784bd0*/ int GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, int readIndex);
        /*0x2786cec*/ int GetStyleHashCode(ref int[] text, int index, ref int closeIndex);
        /*0x27860d4*/ int GetStyleHashCode(ref TMPro.TMP_Text.TextBackingContainer text, int index, ref int closeIndex);
        void ResizeInternalArray<T>(ref T[] array);
        void ResizeInternalArray<T>(ref T[] array, int size);
        /*0x2785cc8*/ void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex);
        /*0x2786dc8*/ void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex);
        /*0x2780188*/ string InternalTextBackingArrayToString();
        /*0x2786ef8*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x2786f00*/ UnityEngine.Vector2 GetPreferredValues();
        /*0x2786f4c*/ UnityEngine.Vector2 GetPreferredValues(float width, float height);
        /*0x2787100*/ UnityEngine.Vector2 GetPreferredValues(string text);
        /*0x2787228*/ UnityEngine.Vector2 GetPreferredValues(string text, float width, float height);
        /*0x2782f64*/ float GetPreferredWidth();
        /*0x2786ff8*/ float GetPreferredWidth(UnityEngine.Vector2 margin);
        /*0x27830bc*/ float GetPreferredHeight();
        /*0x2787054*/ float GetPreferredHeight(UnityEngine.Vector2 margin);
        /*0x27872ec*/ UnityEngine.Vector2 GetRenderedValues();
        /*0x278732c*/ UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters);
        /*0x278324c*/ float GetRenderedWidth();
        /*0x278754c*/ float GetRenderedWidth(bool onlyVisibleCharacters);
        /*0x2783264*/ float GetRenderedHeight();
        /*0x2787554*/ float GetRenderedHeight(bool onlyVisibleCharacters);
        /*0x278756c*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled);
        /*0x278fc40*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x278fc4c*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x27826e4*/ UnityEngine.Bounds GetTextBounds();
        /*0x2787370*/ UnityEngine.Bounds GetTextBounds(bool onlyVisibleCharacters);
        /*0x278fc54*/ void AdjustLineOffset(int startIndex, int endIndex, float offset);
        /*0x278fe0c*/ void ResizeLineExtents(int size);
        /*0x278ffb4*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x278ffbc*/ void ComputeMarginSize();
        /*0x278ffc0*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender);
        /*0x278f980*/ void SaveWordWrappingState(ref TMPro.WordWrapState state, int index, int count);
        /*0x278f698*/ int RestoreWordWrappingState(ref TMPro.WordWrapState state);
        /*0x279048c*/ void SaveGlyphVertexInfo(float padding, float style_padding, UnityEngine.Color32 vertexColor);
        /*0x279376c*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor);
        /*0x27959ac*/ void FillCharacterVertexBuffers(int i, int index_X4);
        /*0x2796084*/ void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric);
        /*0x2796b68*/ void FillSpriteVertexBuffers(int i, int index_X4);
        /*0x2797240*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor);
        /*0x27981b0*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, UnityEngine.Color32 highlightColor);
        /*0x2798688*/ void LoadDefaultSettings();
        /*0x27988fc*/ void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset);
        /*0x2798924*/ void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x2798000*/ void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x2798b68*/ void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c);
        /*0x2798be0*/ TMPro.TMP_FontAsset GetFontAssetForWeight(int fontWeight);
        /*0x2798c58*/ TMPro.TMP_TextElement GetTextElement(uint unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isUsingAlternativeTypeface);
        /*0x279903c*/ void SetActiveSubMeshes(bool state);
        /*0x2799040*/ void DestroySubMeshObjects();
        /*0x2799044*/ void ClearMesh();
        /*0x2799048*/ void ClearMesh(bool uploadGeometry);
        /*0x279904c*/ string GetParsedText();
        /*0x2781d18*/ bool IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent);
        /*0x2781c00*/ void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent);
        /*0x2798150*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
        /*0x2799144*/ float PackUV(float x, float y);
        /*0x27991a4*/ void InternalUpdate();
        /*0x27991a8*/ int HexToInt(char hex);
        /*0x27991d4*/ int GetUTF16(string text, int i);
        /*0x27861e0*/ int GetUTF16(int[] text, int i);
        /*0x279927c*/ int GetUTF16(uint[] text, int i);
        /*0x2799324*/ int GetUTF16(System.Text.StringBuilder text, int i);
        /*0x27849f0*/ int GetUTF16(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x27993cc*/ int GetUTF32(string text, int i);
        /*0x2786288*/ int GetUTF32(int[] text, int i);
        /*0x2799504*/ int GetUTF32(uint[] text, int i);
        /*0x279963c*/ int GetUTF32(System.Text.StringBuilder text, int i);
        /*0x2784a98*/ int GetUTF32(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x2799774*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
        /*0x2799b88*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
        /*0x2799dd4*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
        /*0x279a004*/ float ConvertToFloat(char[] chars, int startIndex, int length);
        /*0x2799e80*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
        /*0x2789618*/ bool ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, int startIndex, ref int endIndex);

        struct CharacterSubstitution
        {
            /*0x10*/ int index;
            /*0x14*/ uint unicode;

            /*0x27a9c94*/ CharacterSubstitution(int index, uint unicode);
        }

        enum TextInputSources
        {
            TextInputBox = 0,
            SetText = 1,
            SetTextArray = 2,
            TextString = 3,
        }

        struct UnicodeChar
        {
            /*0x10*/ int unicode;
            /*0x14*/ int stringIndex;
            /*0x18*/ int length;
        }

        struct SpecialCharacter
        {
            /*0x10*/ TMPro.TMP_Character character;
            /*0x18*/ TMPro.TMP_FontAsset fontAsset;
            /*0x20*/ UnityEngine.Material material;
            /*0x28*/ int materialIndex;

            /*0x27a9c9c*/ SpecialCharacter(TMPro.TMP_Character character, int materialIndex);
        }

        struct TextBackingContainer
        {
            /*0x10*/ uint[] m_Array;
            /*0x18*/ int m_Count;

            /*0x27a9ea8*/ TextBackingContainer(int size);
            /*0x27a9d88*/ int get_Capacity();
            /*0x27a9da4*/ int get_Count();
            /*0x27a9dac*/ void set_Count(int value);
            /*0x27a9db4*/ uint get_Item(int index);
            /*0x27a9de4*/ void set_Item(int index, uint value);
            /*0x27a9e44*/ void Resize(int size);
        }

        class <>c
        {
            static /*0x0*/ TMPro.TMP_Text.<> <>9;
            static /*0x8*/ System.Action<TMPro.TMP_TextInfo> <>9__622_0;

            static /*0x27a9f08*/ <>c();
            /*0x27a9f6c*/ <>c();
            /*0x27a9f74*/ void <.ctor>b__622_0(TMPro.TMP_TextInfo <p0>);
        }
    }

    enum TextElementType
    {
        Character = 1,
        Sprite = 2,
    }

    class TMP_TextElement
    {
        /*0x10*/ TMPro.TextElementType m_ElementType;
        /*0x14*/ uint m_Unicode;
        /*0x18*/ TMPro.TMP_Asset m_TextAsset;
        /*0x20*/ UnityEngine.TextCore.Glyph m_Glyph;
        /*0x28*/ uint m_GlyphIndex;
        /*0x2c*/ float m_Scale;

        /*0x27a6a3c*/ TMP_TextElement();
        /*0x27a9f78*/ TMPro.TextElementType get_elementType();
        /*0x27a9f80*/ uint get_unicode();
        /*0x27a9f88*/ void set_unicode(uint value);
        /*0x27a9f90*/ TMPro.TMP_Asset get_textAsset();
        /*0x27a9f98*/ void set_textAsset(TMPro.TMP_Asset value);
        /*0x27a9fa0*/ UnityEngine.TextCore.Glyph get_glyph();
        /*0x27a9fa8*/ void set_glyph(UnityEngine.TextCore.Glyph value);
        /*0x27a9fb0*/ uint get_glyphIndex();
        /*0x27a9fb8*/ void set_glyphIndex(uint value);
        /*0x27a9fc0*/ float get_scale();
        /*0x27a9fc8*/ void set_scale(float value);
    }

    class TMP_TextElement_Legacy
    {
        /*0x10*/ int id;
        /*0x14*/ float x;
        /*0x18*/ float y;
        /*0x1c*/ float width;
        /*0x20*/ float height;
        /*0x24*/ float xOffset;
        /*0x28*/ float yOffset;
        /*0x2c*/ float xAdvance;
        /*0x30*/ float scale;

        /*0x27a40c4*/ TMP_TextElement_Legacy();
    }

    class TMP_TextInfo
    {
        static /*0x0*/ UnityEngine.Vector2 k_InfinityVectorPositive;
        static /*0x8*/ UnityEngine.Vector2 k_InfinityVectorNegative;
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int characterCount;
        /*0x1c*/ int spriteCount;
        /*0x20*/ int spaceCount;
        /*0x24*/ int wordCount;
        /*0x28*/ int linkCount;
        /*0x2c*/ int lineCount;
        /*0x30*/ int pageCount;
        /*0x34*/ int materialCount;
        /*0x38*/ TMPro.TMP_CharacterInfo[] characterInfo;
        /*0x40*/ TMPro.TMP_WordInfo[] wordInfo;
        /*0x48*/ TMPro.TMP_LinkInfo[] linkInfo;
        /*0x50*/ TMPro.TMP_LineInfo[] lineInfo;
        /*0x58*/ TMPro.TMP_PageInfo[] pageInfo;
        /*0x60*/ TMPro.TMP_MeshInfo[] meshInfo;
        /*0x68*/ TMPro.TMP_MeshInfo[] m_CachedMeshInfo;

        static /*0x27aaca4*/ TMP_TextInfo();
        static void Resize<T>(ref T[] array, int size);
        static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
        /*0x27a9fd0*/ TMP_TextInfo();
        /*0x27aa0f8*/ TMP_TextInfo(int characterCount);
        /*0x27aa224*/ TMP_TextInfo(TMPro.TMP_Text textComponent);
        /*0x27aa390*/ void Clear();
        /*0x27aa3ec*/ void ClearAllData();
        /*0x27aa518*/ void ClearMeshInfo(bool updateMesh);
        /*0x27aa588*/ void ClearAllMeshInfo();
        /*0x27aa5ec*/ void ResetVertexLayout(bool isVolumetric);
        /*0x27aa660*/ void ClearUnusedVertices(TMPro.MaterialReference[] materials);
        /*0x27aa6c4*/ void ClearLineInfo();
        /*0x27aa844*/ void ClearPageInfo();
        /*0x27aa8dc*/ TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData();
    }

    class TMP_TextParsingUtilities
    {
        static string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ TMPro.TMP_TextParsingUtilities s_Instance;

        static /*0x27aad10*/ TMP_TextParsingUtilities();
        static /*0x27aad7c*/ TMPro.TMP_TextParsingUtilities get_instance();
        static /*0x27a6e80*/ int GetHashCode(string s);
        static /*0x27a69c8*/ int GetHashCodeCaseSensitive(string s);
        static /*0x27aae48*/ char ToLowerASCIIFast(char c);
        static /*0x27aadd4*/ char ToUpperASCIIFast(char c);
        static /*0x27aaebc*/ uint ToUpperASCIIFast(uint c);
        static /*0x27aaf30*/ uint ToLowerASCIIFast(uint c);
        static /*0x27aafa4*/ bool IsHighSurrogate(uint c);
        static /*0x27aafb8*/ bool IsLowSurrogate(uint c);
        static /*0x27aafcc*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
        /*0x27aad74*/ TMP_TextParsingUtilities();
    }

    struct TMP_FontStyleStack
    {
        /*0x10*/ byte bold;
        /*0x11*/ byte italic;
        /*0x12*/ byte underline;
        /*0x13*/ byte strikethrough;
        /*0x14*/ byte highlight;
        /*0x15*/ byte superscript;
        /*0x16*/ byte subscript;
        /*0x17*/ byte uppercase;
        /*0x18*/ byte lowercase;
        /*0x19*/ byte smallcaps;

        /*0x27aafe0*/ void Clear();
        /*0x27aafec*/ byte Add(TMPro.FontStyles style);
        /*0x27ab0e8*/ byte Remove(TMPro.FontStyles style);
    }

    struct TMP_TextProcessingStack<T>
    {
        static int k_DefaultCapacity = 4;
        /*0x0*/ T[] itemStack;
        /*0x0*/ int index;
        /*0x0*/ T m_DefaultItem;
        /*0x0*/ int m_Capacity;
        /*0x0*/ int m_RolloverSize;
        /*0x0*/ int m_Count;

        static void SetDefault(TMPro.TMP_TextProcessingStack<T> stack, T item);
        TMP_TextProcessingStack(T[] stack);
        TMP_TextProcessingStack(int capacity);
        TMP_TextProcessingStack(int capacity, int rolloverSize);
        int get_Count();
        T get_current();
        int get_rolloverSize();
        void set_rolloverSize(int value);
        void Clear();
        void SetDefault(T item);
        void Add(T item);
        T Remove();
        void Push(T item);
        T Pop();
        T Peek();
        T CurrentItem();
        T PreviousItem();
    }

    enum CaretPosition
    {
        None = 0,
        Left = 1,
        Right = 2,
    }

    struct CaretInfo
    {
        /*0x10*/ int index;
        /*0x14*/ TMPro.CaretPosition position;

        /*0x27ab208*/ CaretInfo(int index, TMPro.CaretPosition position);
    }

    class TMP_TextUtilities
    {
        static string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ UnityEngine.Vector3[] m_rectWorldCorners;

        static /*0x27adf30*/ TMP_TextUtilities();
        static /*0x27ab210*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27ab8ac*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, ref TMPro.CaretPosition cursor);
        static /*0x27aba8c*/ int FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27abc0c*/ int FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, int line, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x27ac10c*/ bool IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27ac228*/ int FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x27ab374*/ int FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x27ac434*/ int FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27ac848*/ int FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27ace10*/ int FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27acf68*/ int FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27ad2a4*/ int FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x27abf84*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
        static /*0x27ab6b0*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x27ad9c0*/ bool IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, ref UnityEngine.Vector3 intersectingPoint);
        static /*0x27ac044*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
        static /*0x27adb2c*/ char ToLowerFast(char c);
        static /*0x27adba0*/ char ToUpperFast(char c);
        static /*0x27adc14*/ uint ToUpperASCIIFast(uint c);
        static /*0x27adc88*/ int GetHashCode(string s);
        static /*0x27a5ae4*/ int GetSimpleHashCode(string s);
        static /*0x27add44*/ uint GetSimpleHashCodeLowercase(string s);
        static /*0x27ade00*/ int HexToInt(char hex);
        static /*0x27ade2c*/ int StringHexToInt(string s);

        struct LineSegment
        {
            /*0x10*/ UnityEngine.Vector3 Point1;
            /*0x1c*/ UnityEngine.Vector3 Point2;

            /*0x27adf98*/ LineSegment(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
        }
    }

    class TMP_UpdateManager
    {
        static /*0x0*/ TMPro.TMP_UpdateManager s_Instance;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_RegisterTextObjectForUpdateMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_UnregisterTextObjectForUpdateMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;
        /*0x10*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Text> m_LayoutRebuildQueue;
        /*0x20*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;
        /*0x28*/ System.Collections.Generic.List<TMPro.TMP_Text> m_GraphicRebuildQueue;
        /*0x30*/ System.Collections.Generic.HashSet<int> m_InternalUpdateLookup;
        /*0x38*/ System.Collections.Generic.List<TMPro.TMP_Text> m_InternalUpdateQueue;
        /*0x40*/ System.Collections.Generic.HashSet<int> m_CullingUpdateLookup;
        /*0x48*/ System.Collections.Generic.List<TMPro.TMP_Text> m_CullingUpdateQueue;

        static /*0x27aecec*/ TMP_UpdateManager();
        static /*0x27adfa8*/ TMPro.TMP_UpdateManager get_instance();
        static /*0x27ae21c*/ void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x27ae390*/ void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        static /*0x27ae504*/ void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        static /*0x27ae678*/ void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        static /*0x27aea44*/ void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x27aeb3c*/ void UnRegisterTextElementForRebuild(TMPro.TMP_Text element);
        /*0x27ae050*/ TMP_UpdateManager();
        /*0x27ae27c*/ void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        /*0x27ae3f0*/ void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x27ae564*/ void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x27ae6d8*/ void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        /*0x27ae7ec*/ void OnCameraPreCull();
        /*0x27ae7f0*/ void DoRebuilds();
        /*0x27aebbc*/ void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x27aec54*/ void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x27aeaa4*/ void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
    }

    class TMP_UpdateRegistry
    {
        static /*0x0*/ TMPro.TMP_UpdateRegistry s_Instance;
        /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        /*0x18*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        /*0x28*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;

        static /*0x27aee50*/ TMPro.TMP_UpdateRegistry get_instance();
        static /*0x27af028*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x27af1a4*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x27af5e4*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x27aeecc*/ TMP_UpdateRegistry();
        /*0x27af048*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x27af1c4*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x27af320*/ void PerformUpdateForCanvasRendererObjects();
        /*0x27af57c*/ void PerformUpdateForMeshRendererObjects();
        /*0x27af614*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x27af6f0*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
    }

    namespace SpriteAssetUtilities
    {
        enum SpriteAssetImportFormats
        {
            None = 0,
            TexturePackerJsonArray = 1,
        }

        class TexturePacker_JsonArray
        {
            /*0x27af7cc*/ TexturePacker_JsonArray();

            struct SpriteFrame
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float w;
                /*0x1c*/ float h;

                /*0x27af7d4*/ string ToString();
            }

            struct SpriteSize
            {
                /*0x10*/ float w;
                /*0x14*/ float h;

                /*0x27afa4c*/ string ToString();
            }

            struct Frame
            {
                /*0x10*/ string filename;
                /*0x18*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrame frame;
                /*0x28*/ bool rotated;
                /*0x29*/ bool trimmed;
                /*0x2c*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrame spriteSourceSize;
                /*0x3c*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSize sourceSize;
                /*0x44*/ UnityEngine.Vector2 pivot;
            }

            struct Meta
            {
                /*0x10*/ string app;
                /*0x18*/ string version;
                /*0x20*/ string image;
                /*0x28*/ string format;
                /*0x30*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSize size;
                /*0x38*/ float scale;
                /*0x40*/ string smartupdate;
            }

            class SpriteDataObject
            {
                /*0x10*/ System.Collections.Generic.List<TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Frame> frames;
                /*0x18*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Meta meta;

                /*0x27afaf8*/ SpriteDataObject();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

    struct __StaticArrayInitTypeSize=12
    {
    }
}
