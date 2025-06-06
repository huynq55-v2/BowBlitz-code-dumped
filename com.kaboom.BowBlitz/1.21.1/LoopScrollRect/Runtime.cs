class <Module>
{
}

namespace UnityEngine
{
    namespace UI
    {
        class LoopHorizontalScrollRect : UnityEngine.UI.LoopScrollRect
        {
            /*0x1e97434*/ LoopHorizontalScrollRect();
            /*0x1e95d60*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x1e96074*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x1e9607c*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x1e96080*/ UnityEngine.Vector2 GetVector(float value);
            /*0x1e9608c*/ void Awake();
            /*0x1e961b4*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        class LoopHorizontalScrollRectMulti : UnityEngine.UI.LoopScrollRectMulti
        {
            /*0x1e97ea4*/ LoopHorizontalScrollRectMulti();
            /*0x1e9743c*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x1e97508*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x1e97510*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x1e97514*/ UnityEngine.Vector2 GetVector(float value);
            /*0x1e97520*/ void Awake();
            /*0x1e97648*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        interface LoopScrollDataSource
        {
            void ProvideData(UnityEngine.Transform transform, int idx);
        }

        interface LoopScrollMultiDataSource
        {
            void ProvideData(UnityEngine.Transform transform, int index);
        }

        interface LoopScrollPrefabSource
        {
            UnityEngine.GameObject GetObject(int index);
            void ReturnObject(UnityEngine.Transform trans);
        }

        class LoopScrollRect : UnityEngine.UI.LoopScrollRectBase
        {
            /*0x1e97438*/ LoopScrollRect();
            /*0x1e97eac*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x1e97ed0*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            /*0x1e97fb4*/ void ReturnToTempPool(bool fromStart, int count);
            /*0x1e98098*/ void ClearTempPool();
        }

        class LoopScrollRectBase : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ System.Func<int, UnityEngine.GameObject> GetObjectHandler;
            /*0x20*/ System.Action<UnityEngine.Transform, int> ReturnObjectHandler;
            /*0x28*/ System.Action<UnityEngine.Transform, int> ProvideDataHandler;
            /*0x30*/ System.Action<int> FlickSnapOver;
            /*0x38*/ int _currentIndex;
            /*0x3c*/ bool EnableFlickSnap;
            /*0x3d*/ bool _moveEndFlickSnap;
            /*0x3e*/ bool _flickSnapMoving;
            /*0x40*/ int totalCount;
            /*0x48*/ UnityEngine.UI.LoopScrollSizeHelper sizeHelper;
            /*0x50*/ float threshold;
            /*0x54*/ bool reverseDirection;
            /*0x58*/ int itemTypeStart;
            /*0x5c*/ int itemTypeEnd;
            /*0x60*/ UnityEngine.UI.LoopScrollRectBase.LoopScrollRectDirection direction;
            /*0x64*/ bool m_ContentSpaceInit;
            /*0x68*/ float m_ContentSpacing;
            /*0x6c*/ float m_ContentLeftPadding;
            /*0x70*/ float m_ContentRightPadding;
            /*0x74*/ float m_ContentTopPadding;
            /*0x78*/ float m_ContentBottomPadding;
            /*0x80*/ UnityEngine.UI.GridLayoutGroup m_GridLayout;
            /*0x88*/ bool m_ContentConstraintCountInit;
            /*0x8c*/ int m_ContentConstraintCount;
            /*0x90*/ UnityEngine.RectTransform m_Content;
            /*0x98*/ bool m_Horizontal;
            /*0x99*/ bool m_Vertical;
            /*0x9c*/ UnityEngine.UI.LoopScrollRectBase.MovementType m_MovementType;
            /*0xa0*/ float m_Elasticity;
            /*0xa4*/ bool m_Inertia;
            /*0xa8*/ float m_DecelerationRate;
            /*0xac*/ float m_ScrollSensitivity;
            /*0xb0*/ UnityEngine.RectTransform m_Viewport;
            /*0xb8*/ UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
            /*0xc0*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
            /*0xc8*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility m_HorizontalScrollbarVisibility;
            /*0xcc*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility m_VerticalScrollbarVisibility;
            /*0xd0*/ float m_HorizontalScrollbarSpacing;
            /*0xd4*/ float m_VerticalScrollbarSpacing;
            /*0xd8*/ UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent m_OnValueChanged;
            /*0xe0*/ UnityEngine.Vector2 m_PointerStartLocalCursor;
            /*0xe8*/ UnityEngine.Vector2 m_ContentStartPosition;
            /*0xf0*/ UnityEngine.RectTransform m_ViewRect;
            /*0xf8*/ UnityEngine.Bounds m_ContentBounds;
            /*0x110*/ UnityEngine.Bounds m_ViewBounds;
            /*0x128*/ UnityEngine.Vector2 m_Velocity;
            /*0x130*/ bool m_Dragging;
            /*0x131*/ bool m_Scrolling;
            /*0x134*/ UnityEngine.Vector2 m_PrevPosition;
            /*0x13c*/ UnityEngine.Bounds m_PrevContentBounds;
            /*0x154*/ UnityEngine.Bounds m_PrevViewBounds;
            /*0x16c*/ bool m_HasRebuiltLayout;
            /*0x16d*/ bool m_HSliderExpand;
            /*0x16e*/ bool m_VSliderExpand;
            /*0x170*/ float m_HSliderHeight;
            /*0x174*/ float m_VSliderWidth;
            /*0x178*/ UnityEngine.RectTransform m_Rect;
            /*0x180*/ UnityEngine.RectTransform m_HorizontalScrollbarRect;
            /*0x188*/ UnityEngine.RectTransform m_VerticalScrollbarRect;
            /*0x190*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x194*/ int deletedItemTypeStart;
            /*0x198*/ int deletedItemTypeEnd;
            /*0x1a0*/ UnityEngine.Vector3[] m_Corners;

            static /*0x1e9b4c4*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x1e9d02c*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x1e9d120*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x1e9d1cc*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x1e9d4b0*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.LoopScrollRectBase.MovementType movementType, ref UnityEngine.Vector2 delta, float deltaDimension, int itemTypeStart, int itemTypeEnd, int totalCount);
            /*0x1e9809c*/ LoopScrollRectBase();
            /*0x1e981b0*/ int get_ItemTypeStart();
            float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            float GetDimension(UnityEngine.Vector2 vector);
            float GetAbsDimension(UnityEngine.Vector2 vector);
            UnityEngine.Vector2 GetVector(float value);
            /*0x1e95e2c*/ float get_contentSpacing();
            /*0x1e96a98*/ int get_contentConstraintCount();
            /*0x1e981b8*/ int get_StartLine();
            /*0x1e96a10*/ int get_CurrentLines();
            /*0x1e98234*/ int get_TotalLines();
            /*0x1e982b0*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
            /*0x1e982b8*/ UnityEngine.RectTransform get_content();
            /*0x1e982c0*/ void set_content(UnityEngine.RectTransform value);
            /*0x1e982c8*/ bool get_horizontal();
            /*0x1e982d0*/ void set_horizontal(bool value);
            /*0x1e982dc*/ bool get_vertical();
            /*0x1e982e4*/ void set_vertical(bool value);
            /*0x1e982f0*/ UnityEngine.UI.LoopScrollRectBase.MovementType get_movementType();
            /*0x1e982f8*/ void set_movementType(UnityEngine.UI.LoopScrollRectBase.MovementType value);
            /*0x1e98300*/ float get_elasticity();
            /*0x1e98308*/ void set_elasticity(float value);
            /*0x1e98310*/ bool get_inertia();
            /*0x1e98318*/ void set_inertia(bool value);
            /*0x1e98324*/ float get_decelerationRate();
            /*0x1e9832c*/ void set_decelerationRate(float value);
            /*0x1e98334*/ float get_scrollSensitivity();
            /*0x1e9833c*/ void set_scrollSensitivity(float value);
            /*0x1e98344*/ UnityEngine.RectTransform get_viewport();
            /*0x1e9834c*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x1e9840c*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x1e98414*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x1e98588*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x1e98590*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x1e98704*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x1e9870c*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility value);
            /*0x1e98714*/ UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x1e9871c*/ void set_verticalScrollbarVisibility(UnityEngine.UI.LoopScrollRectBase.ScrollbarVisibility value);
            /*0x1e98724*/ float get_horizontalScrollbarSpacing();
            /*0x1e9872c*/ void set_horizontalScrollbarSpacing(float value);
            /*0x1e987bc*/ float get_verticalScrollbarSpacing();
            /*0x1e987c4*/ void set_verticalScrollbarSpacing(float value);
            /*0x1e987cc*/ UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent get_onValueChanged();
            /*0x1e987d4*/ void set_onValueChanged(UnityEngine.UI.LoopScrollRectBase.ScrollRectEvent value);
            /*0x1e987dc*/ UnityEngine.RectTransform get_viewRect();
            /*0x1e988cc*/ UnityEngine.Vector2 get_velocity();
            /*0x1e988d8*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x1e988e4*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1e989c0*/ void ClearCells();
            /*0x1e98a20*/ int GetFirstItem(ref float offset);
            /*0x1e98be0*/ int GetLastItem(ref float offset);
            /*0x1e98dcc*/ void SrollToCell(int index, float speed);
            /*0x1e992b8*/ void SrollToCellWithinTime(int index, float time);
            /*0x1e99230*/ System.Collections.IEnumerator ScrollToCellCoroutine(int index, float speed);
            void ProvideData(UnityEngine.Transform transform, int index);
            /*0x1e99678*/ void RefreshCells(bool resize);
            /*0x1e997e8*/ void RefreshCells(int index, bool resize);
            /*0x1e99790*/ void RefreshPosition();
            /*0x1e99fe0*/ void RefillCellsFromEnd(int endItem, bool alignStart);
            /*0x1e98f70*/ void RefillCells(int startItem, bool fillViewRect, float contentOffset);
            /*0x1e972a4*/ float NewItemAtStart(bool includeSpacing);
            /*0x1e96e54*/ float DeleteItemAtStart();
            /*0x1e970a8*/ float NewItemAtEnd(bool includeSpacing);
            /*0x1e96bd8*/ float DeleteItemAtEnd();
            UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            void ReturnToTempPool(bool fromStart, int count);
            void ClearTempPool();
            /*0x1e9a3b0*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x1e9a7b4*/ void LayoutComplete();
            /*0x1e9a7b8*/ void GraphicUpdateComplete();
            /*0x1e9a43c*/ void UpdateCachedData();
            /*0x1e9a7bc*/ void OnEnable();
            /*0x1e9a968*/ void OnDisable();
            /*0x1e9ab98*/ bool IsActive();
            /*0x1e9ac18*/ void EnsureLayoutHasRebuilt();
            /*0x1e9ac8c*/ void StopMovement();
            /*0x1e9acf0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x1e9aed0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1e9af30*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1e9b070*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1e9b0a0*/ void FlickSnap();
            /*0x1e9b2c4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1e9b500*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x1e9b5b8*/ void LateUpdate();
            /*0x1e9a2c0*/ void UpdatePrevData();
            /*0x1e9bbb8*/ void GetHorizonalOffsetAndSize(ref float totalSize, ref float offset);
            /*0x1e9be34*/ void GetVerticalOffsetAndSize(ref float totalSize, ref float offset);
            /*0x1e99df0*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x1e9bb48*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x1e9c220*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x1e9c0b0*/ float get_horizontalNormalizedPosition();
            /*0x1e9c268*/ void set_horizontalNormalizedPosition(float value);
            /*0x1e9c168*/ float get_verticalNormalizedPosition();
            /*0x1e9c27c*/ void set_verticalNormalizedPosition(float value);
            /*0x1e9c290*/ void SetHorizontalNormalizedPosition(float value);
            /*0x1e9c2a4*/ void SetVerticalNormalizedPosition(float value);
            /*0x1e9c2b8*/ void SetNormalizedPosition(float value, int axis);
            /*0x1e9c5a4*/ void OnRectTransformDimensionsChange();
            /*0x1e9c5a8*/ bool get_hScrollingNeeded();
            /*0x1e9c604*/ bool get_vScrollingNeeded();
            /*0x1e9c660*/ void CalculateLayoutInputHorizontal();
            /*0x1e9c664*/ void CalculateLayoutInputVertical();
            /*0x1e9c668*/ float get_minWidth();
            /*0x1e9c670*/ float get_preferredWidth();
            /*0x1e9c678*/ float get_flexibleWidth();
            /*0x1e9c680*/ float get_minHeight();
            /*0x1e9c688*/ float get_preferredHeight();
            /*0x1e9c690*/ float get_flexibleHeight();
            /*0x1e9c698*/ int get_layoutPriority();
            /*0x1e9c6a0*/ void SetLayoutHorizontal();
            /*0x1e9ccf8*/ void SetLayoutVertical();
            /*0x1e9bb78*/ void UpdateScrollbarVisibility();
            /*0x1e9cdd8*/ void UpdateScrollbarLayout();
            /*0x1e998e4*/ void UpdateBounds(bool updateItems);
            /*0x1e9cbfc*/ UnityEngine.Bounds GetBounds();
            /*0x1e9d324*/ UnityEngine.Bounds GetBounds4Item(int index);
            /*0x1e9ae50*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x1e98734*/ void SetDirty();
            /*0x1e98354*/ void SetDirtyCaching();
            /*0x1e9d67c*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
            /*0x1e9b108*/ int <FlickSnap>g__FindIndex|171_0();

            enum LoopScrollRectDirection
            {
                Vertical = 0,
                Horizontal = 1,
            }

            enum MovementType
            {
                Unrestricted = 0,
                Elastic = 1,
                Clamped = 2,
            }

            enum ScrollbarVisibility
            {
                Permanent = 0,
                AutoHide = 1,
                AutoHideAndExpandViewport = 2,
            }

            class ScrollRectEvent : UnityEngine.Events.UnityEvent<UnityEngine.Vector2>
            {
                /*0x1e98978*/ ScrollRectEvent();
            }

            class <ScrollToCellCoroutine>d__142 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.LoopScrollRectBase <>4__this;
                /*0x28*/ int index;
                /*0x2c*/ float speed;
                /*0x30*/ bool <needMoving>5__2;

                /*0x1e99650*/ <ScrollToCellCoroutine>d__142(int <>1__state);
                /*0x1e9d684*/ void System.IDisposable.Dispose();
                /*0x1e9d688*/ bool MoveNext();
                /*0x1e9dac8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x1e9dad0*/ void System.Collections.IEnumerator.Reset();
                /*0x1e9db10*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LoopScrollRectMulti : UnityEngine.UI.LoopScrollRectBase
        {
            /*0x1e97ea8*/ LoopScrollRectMulti();
            /*0x1e9db18*/ void ProvideData(UnityEngine.Transform transform, int index);
            /*0x1e9db3c*/ UnityEngine.RectTransform GetFromTempPool(int itemIdx);
            /*0x1e9dc20*/ void ReturnToTempPool(bool fromStart, int count);
            /*0x1e9dd04*/ void ClearTempPool();
        }

        interface LoopScrollSizeHelper
        {
            UnityEngine.Vector2 GetItemsSize(int itemsCount);
        }

        class LoopVerticalScrollRect : UnityEngine.UI.LoopScrollRect
        {
            /*0x1e9e754*/ LoopVerticalScrollRect();
            /*0x1e9dd08*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x1e9ddd4*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x1e9dddc*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x1e9dde4*/ UnityEngine.Vector2 GetVector(float value);
            /*0x1e9ddf0*/ void Awake();
            /*0x1e9df14*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }

        class LoopVerticalScrollRectMulti : UnityEngine.UI.LoopScrollRectMulti
        {
            /*0x1e9f1a4*/ LoopVerticalScrollRectMulti();
            /*0x1e9e758*/ float GetSize(UnityEngine.RectTransform item, bool includeSpacing);
            /*0x1e9e824*/ float GetDimension(UnityEngine.Vector2 vector);
            /*0x1e9e82c*/ float GetAbsDimension(UnityEngine.Vector2 vector);
            /*0x1e9e834*/ UnityEngine.Vector2 GetVector(float value);
            /*0x1e9e840*/ void Awake();
            /*0x1e9e964*/ bool UpdateItems(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds);
        }
    }
}
