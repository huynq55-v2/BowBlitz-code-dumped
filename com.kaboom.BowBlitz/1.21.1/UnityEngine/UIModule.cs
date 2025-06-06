class <Module>
{
}

namespace UnityEngine
{
    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x2ac1020*/ RectTransformUtility();
        static /*0x2abfca0*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x2abfda0*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x2abfe94*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x2abffa0*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint);
        static /*0x2ac0010*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x2ac00e4*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x2ac0190*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x2ac05ac*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x2ac047c*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x2ac06ac*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x2ac075c*/ UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child);
        static /*0x2ac0a74*/ UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans);
        static /*0x2ac0afc*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x2ac0dc0*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x2ac1010*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x2abfd44*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, ref UnityEngine.Vector2 ret);
        static /*0x2abfe40*/ void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, ref UnityEngine.Rect ret);
        static /*0x2abff3c*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, ref UnityEngine.Vector4 offset);
        /*0x2abff98*/ RectTransformUtility();
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x2ac1b48*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x2ac1c3c*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x2ac1dec*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x2ac1f00*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x2ac2038*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x2ac2148*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x2ac1da8*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x2ac1d0c*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x2ac1f9c*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        /*0x2ac2c28*/ CanvasRenderer();
        /*0x2ac1088*/ bool get_hasPopInstruction();
        /*0x2ac10c4*/ void set_hasPopInstruction(bool value);
        /*0x2ac1108*/ int get_materialCount();
        /*0x2ac1144*/ void set_materialCount(int value);
        /*0x2ac1188*/ int get_popMaterialCount();
        /*0x2ac11c4*/ void set_popMaterialCount(int value);
        /*0x2ac1208*/ int get_absoluteDepth();
        /*0x2ac1244*/ bool get_hasMoved();
        /*0x2ac1280*/ bool get_cullTransparentMesh();
        /*0x2ac12bc*/ void set_cullTransparentMesh(bool value);
        /*0x2ac1300*/ bool get_hasRectClipping();
        /*0x2ac133c*/ int get_relativeDepth();
        /*0x2ac1378*/ bool get_cull();
        /*0x2ac13b4*/ void set_cull(bool value);
        /*0x2ac13f8*/ bool get_isMask();
        /*0x2ac1400*/ void set_isMask(bool value);
        /*0x2ac140c*/ void SetColor(UnityEngine.Color color);
        /*0x2ac14a4*/ UnityEngine.Color GetColor();
        /*0x2ac1540*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x2ac15d8*/ UnityEngine.Vector2 get_clippingSoftness();
        /*0x2ac1668*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x2ac16f4*/ void DisableRectClipping();
        /*0x2ac1730*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x2ac1784*/ UnityEngine.Material GetMaterial(int index);
        /*0x2ac17c8*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x2ac181c*/ UnityEngine.Material GetPopMaterial(int index);
        /*0x2ac1860*/ void SetTexture(UnityEngine.Texture texture);
        /*0x2ac18a4*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x2ac18e8*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x2ac192c*/ void Clear();
        /*0x2ac1968*/ float GetAlpha();
        /*0x2ac197c*/ void SetAlpha(float alpha);
        /*0x2ac19a4*/ float GetInheritedAlpha();
        /*0x2ac19e0*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x2ac1b08*/ UnityEngine.Material GetMaterial();
        /*0x2ac21e4*/ void SetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x2ac2254*/ void SetVertices(UnityEngine.UIVertex[] vertices, int size);
        /*0x2ac1460*/ void SetColor_Injected(ref UnityEngine.Color color);
        /*0x2ac14fc*/ void GetColor_Injected(ref UnityEngine.Color ret);
        /*0x2ac1594*/ void EnableRectClipping_Injected(ref UnityEngine.Rect rect);
        /*0x2ac1624*/ void get_clippingSoftness_Injected(ref UnityEngine.Vector2 ret);
        /*0x2ac16b0*/ void set_clippingSoftness_Injected(ref UnityEngine.Vector2 value);
    }

    enum RenderMode
    {
        ScreenSpaceOverlay = 0,
        ScreenSpaceCamera = 1,
        WorldSpace = 2,
    }

    enum AdditionalCanvasShaderChannels
    {
        None = 0,
        TexCoord1 = 1,
        TexCoord2 = 2,
        TexCoord3 = 4,
        Normal = 8,
        Tangent = 16,
    }

    class Canvas : UnityEngine.Behaviour
    {
        static /*0x0*/ UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases;
        static /*0x8*/ UnityEngine.Canvas.WillRenderCanvases willRenderCanvases;
        static /*0x10*/ System.Action<int> <externBeginRenderOverlays>k__BackingField;
        static /*0x18*/ System.Action<int, int> <externRenderOverlaysBefore>k__BackingField;
        static /*0x20*/ System.Action<int> <externEndRenderOverlays>k__BackingField;

        static /*0x2ac2c30*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2ac2ce8*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2ac2da0*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2ac2e5c*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2ac374c*/ System.Action<int> get_externBeginRenderOverlays();
        static /*0x2ac3794*/ void set_externBeginRenderOverlays(System.Action<int> value);
        static /*0x2ac37e0*/ System.Action<int, int> get_externRenderOverlaysBefore();
        static /*0x2ac3828*/ void set_externRenderOverlaysBefore(System.Action<int, int> value);
        static /*0x2ac3874*/ System.Action<int> get_externEndRenderOverlays();
        static /*0x2ac38bc*/ void set_externEndRenderOverlays(System.Action<int> value);
        static /*0x2ac3908*/ void SetExternalCanvasEnabled(bool enabled);
        static /*0x2ac3acc*/ UnityEngine.Material GetDefaultCanvasTextMaterial();
        static /*0x2ac3af4*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x2ac3b1c*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x2ac3b88*/ void ForceUpdateCanvases();
        static /*0x2ac3b98*/ void SendPreWillRenderCanvases();
        static /*0x2ac3bfc*/ void SendWillRenderCanvases();
        static /*0x2ac3c60*/ void BeginRenderExtraOverlays(int displayIndex);
        static /*0x2ac3ccc*/ void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder);
        static /*0x2ac3d40*/ void EndRenderExtraOverlays(int displayIndex);
        /*0x2ac3dac*/ Canvas();
        /*0x2ac2f18*/ UnityEngine.RenderMode get_renderMode();
        /*0x2ac2f54*/ void set_renderMode(UnityEngine.RenderMode value);
        /*0x2ac2f98*/ bool get_isRootCanvas();
        /*0x2ac2fd4*/ UnityEngine.Rect get_pixelRect();
        /*0x2ac3070*/ float get_scaleFactor();
        /*0x2ac30ac*/ void set_scaleFactor(float value);
        /*0x2ac30f8*/ float get_referencePixelsPerUnit();
        /*0x2ac3134*/ void set_referencePixelsPerUnit(float value);
        /*0x2ac3180*/ bool get_overridePixelPerfect();
        /*0x2ac31bc*/ void set_overridePixelPerfect(bool value);
        /*0x2ac3200*/ bool get_pixelPerfect();
        /*0x2ac323c*/ void set_pixelPerfect(bool value);
        /*0x2ac3280*/ float get_planeDistance();
        /*0x2ac32bc*/ void set_planeDistance(float value);
        /*0x2ac3308*/ int get_renderOrder();
        /*0x2ac3344*/ bool get_overrideSorting();
        /*0x2ac3380*/ void set_overrideSorting(bool value);
        /*0x2ac33c4*/ int get_sortingOrder();
        /*0x2ac3400*/ void set_sortingOrder(int value);
        /*0x2ac3444*/ int get_targetDisplay();
        /*0x2ac3480*/ void set_targetDisplay(int value);
        /*0x2ac34c4*/ int get_sortingLayerID();
        /*0x2ac3500*/ void set_sortingLayerID(int value);
        /*0x2ac3544*/ int get_cachedSortingLayerValue();
        /*0x2ac3580*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels();
        /*0x2ac35bc*/ void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value);
        /*0x2ac3600*/ string get_sortingLayerName();
        /*0x2ac363c*/ void set_sortingLayerName(string value);
        /*0x2ac3680*/ UnityEngine.Canvas get_rootCanvas();
        /*0x2ac36bc*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x2ac3944*/ UnityEngine.Camera get_worldCamera();
        /*0x2ac3980*/ void set_worldCamera(UnityEngine.Camera value);
        /*0x2ac39c4*/ float get_normalizedSortingGridSize();
        /*0x2ac3a00*/ void set_normalizedSortingGridSize(float value);
        /*0x2ac3a4c*/ int get_sortingGridNormalizedSize();
        /*0x2ac3a88*/ void set_sortingGridNormalizedSize(int value);
        /*0x2ac3b44*/ void UpdateCanvasRectTransform(bool alignWithCamera);
        /*0x2ac302c*/ void get_pixelRect_Injected(ref UnityEngine.Rect ret);
        /*0x2ac3708*/ void get_renderingDisplaySize_Injected(ref UnityEngine.Vector2 ret);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0x2ac3db4*/ WillRenderCanvases(object object, nint method);
            /*0x2ac3e70*/ void Invoke();
        }
    }

    class UISystemProfilerApi
    {
        static /*0x2ac3e84*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x2ac3ec0*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x2ac3efc*/ void AddMarker(string name, UnityEngine.Object obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }

    interface ICanvasRaycastFilter
    {
        bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasGroup : UnityEngine.Behaviour, UnityEngine.ICanvasRaycastFilter
    {
        /*0x2ac4184*/ CanvasGroup();
        /*0x2ac3f40*/ float get_alpha();
        /*0x2ac3f7c*/ void set_alpha(float value);
        /*0x2ac3fc8*/ bool get_interactable();
        /*0x2ac4004*/ void set_interactable(bool value);
        /*0x2ac4048*/ bool get_blocksRaycasts();
        /*0x2ac4084*/ void set_blocksRaycasts(bool value);
        /*0x2ac40c8*/ bool get_ignoreParentGroups();
        /*0x2ac4104*/ void set_ignoreParentGroups(bool value);
        /*0x2ac4148*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }
}
