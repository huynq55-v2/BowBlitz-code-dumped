class <Module>
{
}

namespace EnhancedUI
{
    class SmallList<T>
    {
        /*0x0*/ T[] data;
        /*0x0*/ int Count;

        SmallList();
        T get_Item(int i);
        void set_Item(int i, T value);
        void ResizeArray();
        void Clear();
        T First();
        T Last();
        void Add(T item);
        void AddStart(T item);
        void Insert(T item, int index);
        T RemoveStart();
        T RemoveAt(int index);
        T Remove(T item);
        T RemoveEnd();
        bool Contains(T item);
    }

    namespace EnhancedScroller
    {
        class CellViewVisibilityChangedDelegate : System.MulticastDelegate
        {
            /*0xe30c14*/ CellViewVisibilityChangedDelegate(object object, nint method);
            /*0xe30d40*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe30d54*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView, System.AsyncCallback callback, object object);
            /*0xe30d74*/ void EndInvoke(System.IAsyncResult result);
        }

        class CellViewWillRecycleDelegate : System.MulticastDelegate
        {
            /*0xe30d80*/ CellViewWillRecycleDelegate(object object, nint method);
            /*0xe30eac*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe30ec0*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView, System.AsyncCallback callback, object object);
            /*0xe30ee0*/ void EndInvoke(System.IAsyncResult result);
        }

        class ScrollerScrolledDelegate : System.MulticastDelegate
        {
            /*0xe30eec*/ ScrollerScrolledDelegate(object object, nint method);
            /*0xe3101c*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition);
            /*0xe31030*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition, System.AsyncCallback callback, object object);
            /*0xe310f0*/ void EndInvoke(System.IAsyncResult result);
        }

        class ScrollerSnappedDelegate : System.MulticastDelegate
        {
            /*0xe310fc*/ ScrollerSnappedDelegate(object object, nint method);
            /*0xe3122c*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int cellIndex, int dataIndex, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe31240*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int cellIndex, int dataIndex, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView, System.AsyncCallback callback, object object);
            /*0xe312ec*/ void EndInvoke(System.IAsyncResult result);
        }

        class ScrollerScrollingChangedDelegate : System.MulticastDelegate
        {
            /*0xe312f8*/ ScrollerScrollingChangedDelegate(object object, nint method);
            /*0xe31428*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, bool scrolling);
            /*0xe31440*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, bool scrolling, System.AsyncCallback callback, object object);
            /*0xe314d8*/ void EndInvoke(System.IAsyncResult result);
        }

        class ScrollerTweeningChangedDelegate : System.MulticastDelegate
        {
            /*0xe314e4*/ ScrollerTweeningChangedDelegate(object object, nint method);
            /*0xe31614*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, bool tweening);
            /*0xe3162c*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, bool tweening, System.AsyncCallback callback, object object);
            /*0xe316c4*/ void EndInvoke(System.IAsyncResult result);
        }

        class CellViewInstantiated : System.MulticastDelegate
        {
            /*0xe316d0*/ CellViewInstantiated(object object, nint method);
            /*0xe31800*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe31814*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView, System.AsyncCallback callback, object object);
            /*0xe3183c*/ void EndInvoke(System.IAsyncResult result);
        }

        class CellViewReused : System.MulticastDelegate
        {
            /*0xe31848*/ CellViewReused(object object, nint method);
            /*0xe31978*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe3198c*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView, System.AsyncCallback callback, object object);
            /*0xe319b4*/ void EndInvoke(System.IAsyncResult result);
        }

        class EnhancedScroller : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler
        {
            /*0x18*/ EnhancedUI.EnhancedScroller.EnhancedScroller.ScrollDirectionEnum scrollDirection;
            /*0x1c*/ float spacing;
            /*0x20*/ UnityEngine.RectOffset padding;
            /*0x28*/ bool loop;
            /*0x29*/ bool loopWhileDragging;
            /*0x2c*/ float maxVelocity;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScroller.ScrollbarVisibilityEnum scrollbarVisibility;
            /*0x34*/ bool snapping;
            /*0x38*/ float snapVelocityThreshold;
            /*0x3c*/ float snapWatchOffset;
            /*0x40*/ float snapJumpToOffset;
            /*0x44*/ float snapCellCenterOffset;
            /*0x48*/ bool snapUseCellSpacing;
            /*0x4c*/ EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType snapTweenType;
            /*0x50*/ float snapTweenTime;
            /*0x54*/ bool snapWhileDragging;
            /*0x55*/ bool forceSnapOnEndDrag;
            /*0x56*/ bool interruptTweeningOnDrag;
            /*0x57*/ bool tweenPaused;
            /*0x58*/ float _lookAheadBefore;
            /*0x5c*/ float _lookAheadAfter;
            /*0x60*/ EnhancedUI.EnhancedScroller.CellViewVisibilityChangedDelegate cellViewVisibilityChanged;
            /*0x68*/ EnhancedUI.EnhancedScroller.CellViewWillRecycleDelegate cellViewWillRecycle;
            /*0x70*/ EnhancedUI.EnhancedScroller.ScrollerScrolledDelegate scrollerScrolled;
            /*0x78*/ EnhancedUI.EnhancedScroller.ScrollerSnappedDelegate scrollerSnapped;
            /*0x80*/ EnhancedUI.EnhancedScroller.ScrollerScrollingChangedDelegate scrollerScrollingChanged;
            /*0x88*/ EnhancedUI.EnhancedScroller.ScrollerTweeningChangedDelegate scrollerTweeningChanged;
            /*0x90*/ EnhancedUI.EnhancedScroller.CellViewInstantiated cellViewInstantiated;
            /*0x98*/ EnhancedUI.EnhancedScroller.CellViewReused cellViewReused;
            /*0xa0*/ bool <IsScrolling>k__BackingField;
            /*0xa1*/ bool <IsTweening>k__BackingField;
            /*0xa2*/ bool _initialized;
            /*0xa3*/ bool _updateSpacing;
            /*0xa8*/ UnityEngine.UI.ScrollRect _scrollRect;
            /*0xb0*/ UnityEngine.RectTransform _scrollRectTransform;
            /*0xb8*/ UnityEngine.UI.Scrollbar _scrollbar;
            /*0xc0*/ UnityEngine.RectTransform _container;
            /*0xc8*/ UnityEngine.UI.HorizontalOrVerticalLayoutGroup _layoutGroup;
            /*0xd0*/ EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate _delegate;
            /*0xd8*/ bool _reloadData;
            /*0xd9*/ bool _refreshActive;
            /*0xe0*/ EnhancedUI.SmallList<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView> _recycledCellViews;
            /*0xe8*/ UnityEngine.UI.LayoutElement _firstPadder;
            /*0xf0*/ UnityEngine.UI.LayoutElement _lastPadder;
            /*0xf8*/ UnityEngine.RectTransform _recycledCellViewContainer;
            /*0x100*/ EnhancedUI.SmallList<float> _cellViewSizeArray;
            /*0x108*/ EnhancedUI.SmallList<float> _cellViewOffsetArray;
            /*0x110*/ float _scrollPosition;
            /*0x118*/ EnhancedUI.SmallList<EnhancedUI.EnhancedScroller.EnhancedScrollerCellView> _activeCellViews;
            /*0x120*/ int _activeCellViewsStartIndex;
            /*0x124*/ int _activeCellViewsEndIndex;
            /*0x128*/ int _loopFirstCellIndex;
            /*0x12c*/ int _loopLastCellIndex;
            /*0x130*/ float _loopFirstScrollPosition;
            /*0x134*/ float _loopLastScrollPosition;
            /*0x138*/ float _loopFirstJumpTrigger;
            /*0x13c*/ float _loopLastJumpTrigger;
            /*0x140*/ float _lastScrollRectSize;
            /*0x144*/ bool _lastLoop;
            /*0x148*/ int _snapCellViewIndex;
            /*0x14c*/ int _snapDataIndex;
            /*0x150*/ bool _snapJumping;
            /*0x151*/ bool _snapInertia;
            /*0x154*/ EnhancedUI.EnhancedScroller.EnhancedScroller.ScrollbarVisibilityEnum _lastScrollbarVisibility;
            /*0x158*/ float _singleLoopGroupSize;
            /*0x15c*/ bool _snapBeforeDrag;
            /*0x15d*/ bool _loopBeforeDrag;
            /*0x15e*/ bool _ignoreLoopJump;
            /*0x160*/ int _dragFingerCount;
            /*0x164*/ bool _interruptTween;
            /*0x168*/ UnityEngine.Vector2 _dragPreviousPos;
            /*0x170*/ float _tweenTimeLeft;
            /*0x174*/ bool _tweenPauseToggledOff;
            /*0x178*/ float _tweenPauseNewTweenTime;

            static /*0xe35394*/ float spring(float start, float end, float val);
            static /*0xe35444*/ float easeInQuad(float start, float end, float val);
            static /*0xe35458*/ float easeOutQuad(float start, float end, float val);
            static /*0xe35474*/ float easeInOutQuad(float start, float end, float val);
            static /*0xe354c8*/ float easeInCubic(float start, float end, float val);
            static /*0xe354e0*/ float easeOutCubic(float start, float end, float val);
            static /*0xe35508*/ float easeInOutCubic(float start, float end, float val);
            static /*0xe35560*/ float easeInQuart(float start, float end, float val);
            static /*0xe3557c*/ float easeOutQuart(float start, float end, float val);
            static /*0xe355a4*/ float easeInOutQuart(float start, float end, float val);
            static /*0xe35600*/ float easeInQuint(float start, float end, float val);
            static /*0xe35620*/ float easeOutQuint(float start, float end, float val);
            static /*0xe35650*/ float easeInOutQuint(float start, float end, float val);
            static /*0xe356b8*/ float easeInSine(float start, float end, float val);
            static /*0xe356f0*/ float easeOutSine(float start, float end, float val);
            static /*0xe35724*/ float easeInOutSine(float start, float end, float val);
            static /*0xe35768*/ float easeInExpo(float start, float end, float val);
            static /*0xe357a0*/ float easeOutExpo(float start, float end, float val);
            static /*0xe357d8*/ float easeInOutExpo(float start, float end, float val);
            static /*0xe35848*/ float easeInCirc(float start, float end, float val);
            static /*0xe35870*/ float easeOutCirc(float start, float end, float val);
            static /*0xe35898*/ float easeInOutCirc(float start, float end, float val);
            static /*0xe358ec*/ float easeInBounce(float start, float end, float val);
            static /*0xe35924*/ float easeOutBounce(float start, float end, float val);
            static /*0xe359ec*/ float easeInOutBounce(float start, float end, float val);
            static /*0xe35a6c*/ float easeInBack(float start, float end, float val);
            static /*0xe35a9c*/ float easeOutBack(float start, float end, float val);
            static /*0xe35adc*/ float easeInOutBack(float start, float end, float val);
            static /*0xe35b60*/ float easeInElastic(float start, float end, float val);
            static /*0xe35bf0*/ float easeOutElastic(float start, float end, float val);
            static /*0xe35c80*/ float easeInOutElastic(float start, float end, float val);
            /*0xe35d7c*/ EnhancedScroller();
            /*0xe319c0*/ float get_lookAheadBefore();
            /*0xe319c8*/ void set_lookAheadBefore(float value);
            /*0xe319d4*/ float get_lookAheadAfter();
            /*0xe319dc*/ void set_lookAheadAfter(float value);
            /*0xe319e8*/ EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate get_Delegate();
            /*0xe319f0*/ void set_Delegate(EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate value);
            /*0xe31a00*/ float get_ScrollPosition();
            /*0xe31a08*/ void set_ScrollPosition(float value);
            /*0xe31ac0*/ float get_ScrollSize();
            /*0xe31c00*/ float get_NormalizedScrollPosition();
            /*0xe31c2c*/ bool get_Loop();
            /*0xe31c34*/ void set_Loop(bool value);
            /*0xe321ac*/ EnhancedUI.EnhancedScroller.EnhancedScroller.ScrollbarVisibilityEnum get_ScrollbarVisibility();
            /*0xe3200c*/ void set_ScrollbarVisibility(EnhancedUI.EnhancedScroller.EnhancedScroller.ScrollbarVisibilityEnum value);
            /*0xe32208*/ UnityEngine.Vector2 get_Velocity();
            /*0xe32224*/ void set_Velocity(UnityEngine.Vector2 value);
            /*0xe32240*/ float get_LinearVelocity();
            /*0xe32270*/ void set_LinearVelocity(float value);
            /*0xe322a4*/ bool get_IsScrolling();
            /*0xe322ac*/ void set_IsScrolling(bool value);
            /*0xe322b8*/ bool get_IsTweening();
            /*0xe322c0*/ void set_IsTweening(bool value);
            /*0xe322cc*/ int get_StartCellViewIndex();
            /*0xe322d4*/ int get_EndCellViewIndex();
            /*0xe322dc*/ int get_StartDataIndex();
            /*0xe323a8*/ int get_EndDataIndex();
            /*0xe322f8*/ int get_NumberOfCells();
            /*0xe323c4*/ UnityEngine.UI.ScrollRect get_ScrollRect();
            /*0xe321b4*/ float get_ScrollRectSize();
            /*0xe323cc*/ UnityEngine.UI.LayoutElement get_FirstPadder();
            /*0xe323d4*/ UnityEngine.UI.LayoutElement get_LastPadder();
            /*0xe323dc*/ UnityEngine.RectTransform get_Container();
            /*0xe323e4*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellPrefab);
            /*0xe326cc*/ void ReloadData(float scrollPositionFactor);
            /*0xe329a4*/ void RefreshActiveCellViews();
            /*0xe32a28*/ void ClearAll();
            /*0xe32a40*/ void ClearActive();
            /*0xe32b20*/ void ClearRecycled();
            /*0xe32c00*/ void ToggleLoop();
            /*0xe32c10*/ void IgnoreLoopJump(bool ignore);
            /*0xe32c1c*/ void SetScrollPositionImmediately(float scrollPosition);
            /*0xe32c34*/ void JumpToDataIndex(int dataIndex, float scrollerOffset, float cellOffset, bool useSpacing, EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType tweenType, float tweenTime, System.Action jumpComplete, EnhancedUI.EnhancedScroller.EnhancedScroller.LoopJumpDirectionEnum loopJumpDirection, bool forceCalculateRange);
            /*0xe33394*/ void Snap();
            /*0xe330a0*/ float GetScrollPositionForCellViewIndex(int cellViewIndex, EnhancedUI.EnhancedScroller.EnhancedScroller.CellViewPositionEnum insertPosition);
            /*0xe331f8*/ float GetScrollPositionForDataIndex(int dataIndex, EnhancedUI.EnhancedScroller.EnhancedScroller.CellViewPositionEnum insertPosition);
            /*0xe331d4*/ int GetCellViewIndexAtPosition(float position);
            /*0xe33604*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellViewAtDataIndex(int dataIndex);
            /*0xe336bc*/ void ToggleTweenPaused(float newTweenTime);
            /*0xe31ca0*/ void _Resize(bool keepPosition);
            /*0xe33ca8*/ void _UpdateSpacing(float spacing);
            /*0xe336e4*/ float _AddCellViewSizes();
            /*0xe33884*/ void _DuplicateCellViewSizes(int numberOfTimes, int cellCount);
            /*0xe33968*/ void _CalculateCellViewOffsets();
            /*0xe325f4*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView _GetRecycledCellView(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellPrefab);
            /*0xe33a40*/ void _ResetVisibleCellViews();
            /*0xe3282c*/ void _RecycleAllCells();
            /*0xe33dac*/ void _RecycleCell(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe33ea4*/ void _AddCellView(int cellIndex, EnhancedUI.EnhancedScroller.EnhancedScroller.ListPositionEnum listPosition);
            /*0xe34210*/ void _SetPadders();
            /*0xe328a8*/ void _RefreshActive();
            /*0xe33cf8*/ void _CalculateCurrentActiveCellRange(ref int startIndex, ref int endIndex);
            /*0xe33500*/ int _GetCellIndexAtPosition(float position, int startIndex, int endIndex);
            /*0xe34460*/ void Awake();
            /*0xe34d18*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData data);
            /*0xe34d70*/ void OnDrag(UnityEngine.EventSystems.PointerEventData data);
            /*0xe34d8c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData data);
            /*0xe34dc0*/ void Update();
            /*0xe34f00*/ void OnValidate();
            /*0xe34f38*/ void LateUpdate();
            /*0xe34fbc*/ void OnEnable();
            /*0xe35064*/ void OnDisable();
            /*0xe35138*/ void _ScrollRect_OnValueChanged(UnityEngine.Vector2 val);
            /*0xe3525c*/ void SnapJumpComplete();
            /*0xe35128*/ void ResetSnap();
            /*0xe332dc*/ System.Collections.IEnumerator TweenPosition(EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType tweenType, float time, float start, float end, System.Action tweenComplete, bool forceCalculateRange);
            /*0xe35370*/ float linear(float start, float end, float val);

            enum ScrollDirectionEnum
            {
                Vertical = 0,
                Horizontal = 1,
            }

            enum CellViewPositionEnum
            {
                Before = 0,
                After = 1,
            }

            enum ScrollbarVisibilityEnum
            {
                OnlyIfNeeded = 0,
                Always = 1,
                Never = 2,
            }

            enum LoopJumpDirectionEnum
            {
                Closest = 0,
                Up = 1,
                Down = 2,
            }

            enum ListPositionEnum
            {
                First = 0,
                Last = 1,
            }

            enum TweenType
            {
                immediate = 0,
                linear = 1,
                spring = 2,
                easeInQuad = 3,
                easeOutQuad = 4,
                easeInOutQuad = 5,
                easeInCubic = 6,
                easeOutCubic = 7,
                easeInOutCubic = 8,
                easeInQuart = 9,
                easeOutQuart = 10,
                easeInOutQuart = 11,
                easeInQuint = 12,
                easeOutQuint = 13,
                easeInOutQuint = 14,
                easeInSine = 15,
                easeOutSine = 16,
                easeInOutSine = 17,
                easeInExpo = 18,
                easeOutExpo = 19,
                easeInOutExpo = 20,
                easeInCirc = 21,
                easeOutCirc = 22,
                easeInOutCirc = 23,
                easeInBounce = 24,
                easeOutBounce = 25,
                easeInOutBounce = 26,
                easeInBack = 27,
                easeOutBack = 28,
                easeInOutBack = 29,
                easeInElastic = 30,
                easeOutElastic = 31,
                easeInOutElastic = 32,
            }

            class <TweenPosition>d__176 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType tweenType;
                /*0x24*/ float time;
                /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller <>4__this;
                /*0x30*/ float start;
                /*0x34*/ float end;
                /*0x38*/ bool forceCalculateRange;
                /*0x40*/ System.Action tweenComplete;
                /*0x48*/ float <newPosition>5__2;

                /*0xe35348*/ <TweenPosition>d__176(int <>1__state);
                /*0xe35e8c*/ void System.IDisposable.Dispose();
                /*0xe35e90*/ bool MoveNext();
                /*0xe367c8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe367d0*/ void System.Collections.IEnumerator.Reset();
                /*0xe36810*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class EnhancedScrollerCellView : UnityEngine.MonoBehaviour
        {
            /*0x18*/ string cellIdentifier;
            /*0x20*/ int cellIndex;
            /*0x24*/ int dataIndex;
            /*0x28*/ bool active;

            /*0xe3681c*/ EnhancedScrollerCellView();
            /*0xe36818*/ void RefreshCellView();
        }

        interface IEnhancedScrollerDelegate
        {
            int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Tween : UnityEngine.MonoBehaviour
        {
            /*0x18*/ float _tweenTimeLeft;

            static /*0xe36920*/ float spring(float start, float end, float val);
            static /*0xe369d0*/ float easeInQuad(float start, float end, float val);
            static /*0xe369e4*/ float easeOutQuad(float start, float end, float val);
            static /*0xe36a00*/ float easeInOutQuad(float start, float end, float val);
            static /*0xe36a54*/ float easeInCubic(float start, float end, float val);
            static /*0xe36a6c*/ float easeOutCubic(float start, float end, float val);
            static /*0xe36a94*/ float easeInOutCubic(float start, float end, float val);
            static /*0xe36aec*/ float easeInQuart(float start, float end, float val);
            static /*0xe36b08*/ float easeOutQuart(float start, float end, float val);
            static /*0xe36b30*/ float easeInOutQuart(float start, float end, float val);
            static /*0xe36b8c*/ float easeInQuint(float start, float end, float val);
            static /*0xe36bac*/ float easeOutQuint(float start, float end, float val);
            static /*0xe36bdc*/ float easeInOutQuint(float start, float end, float val);
            static /*0xe36c44*/ float easeInSine(float start, float end, float val);
            static /*0xe36c7c*/ float easeOutSine(float start, float end, float val);
            static /*0xe36cb0*/ float easeInOutSine(float start, float end, float val);
            static /*0xe36cf4*/ float easeInExpo(float start, float end, float val);
            static /*0xe36d2c*/ float easeOutExpo(float start, float end, float val);
            static /*0xe36d64*/ float easeInOutExpo(float start, float end, float val);
            static /*0xe36dd4*/ float easeInCirc(float start, float end, float val);
            static /*0xe36dfc*/ float easeOutCirc(float start, float end, float val);
            static /*0xe36e24*/ float easeInOutCirc(float start, float end, float val);
            static /*0xe36e78*/ float easeInBounce(float start, float end, float val);
            static /*0xe36eb0*/ float easeOutBounce(float start, float end, float val);
            static /*0xe36f78*/ float easeInOutBounce(float start, float end, float val);
            static /*0xe36ff8*/ float easeInBack(float start, float end, float val);
            static /*0xe37028*/ float easeOutBack(float start, float end, float val);
            static /*0xe37068*/ float easeInOutBack(float start, float end, float val);
            static /*0xe370ec*/ float easeInElastic(float start, float end, float val);
            static /*0xe3717c*/ float easeOutElastic(float start, float end, float val);
            static /*0xe3720c*/ float easeInOutElastic(float start, float end, float val);
            /*0xe37308*/ Tween();
            /*0xe36824*/ System.Collections.IEnumerator TweenPosition(EnhancedUI.EnhancedScroller.Tween.TweenType tweenType, float time, float start, float end, System.Action<float, float> tweenUpdated, System.Action tweenComplete);
            /*0xe368fc*/ float linear(float start, float end, float val);

            enum TweenType
            {
                immediate = 0,
                linear = 1,
                spring = 2,
                easeInQuad = 3,
                easeOutQuad = 4,
                easeInOutQuad = 5,
                easeInCubic = 6,
                easeOutCubic = 7,
                easeInOutCubic = 8,
                easeInQuart = 9,
                easeOutQuart = 10,
                easeInOutQuart = 11,
                easeInQuint = 12,
                easeOutQuint = 13,
                easeInOutQuint = 14,
                easeInSine = 15,
                easeOutSine = 16,
                easeInOutSine = 17,
                easeInExpo = 18,
                easeOutExpo = 19,
                easeInOutExpo = 20,
                easeInCirc = 21,
                easeOutCirc = 22,
                easeInOutCirc = 23,
                easeInBounce = 24,
                easeOutBounce = 25,
                easeInOutBounce = 26,
                easeInBack = 27,
                easeOutBack = 28,
                easeInOutBack = 29,
                easeInElastic = 30,
                easeOutElastic = 31,
                easeInOutElastic = 32,
            }

            class <TweenPosition>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedUI.EnhancedScroller.Tween.TweenType tweenType;
                /*0x24*/ float time;
                /*0x28*/ EnhancedUI.EnhancedScroller.Tween <>4__this;
                /*0x30*/ float start;
                /*0x34*/ float end;
                /*0x38*/ System.Action<float, float> tweenUpdated;
                /*0x40*/ System.Action tweenComplete;
                /*0x48*/ float <newPosition>5__2;
                /*0x4c*/ float <lastPosition>5__3;

                /*0xe368d4*/ <TweenPosition>d__2(int <>1__state);
                /*0xe37310*/ void System.IDisposable.Dispose();
                /*0xe37314*/ bool MoveNext();
                /*0xe37b2c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe37b34*/ void System.Collections.IEnumerator.Reset();
                /*0xe37b74*/ object System.Collections.IEnumerator.get_Current();
            }
        }
    }
}

namespace EnhancedScollerDemos
{
    namespace MainMenu
    {
        class MainMenu : UnityEngine.MonoBehaviour
        {
            /*0xe37bd4*/ MainMenu();
            /*0xe37b7c*/ void SceneButton_OnClick(string sceneName);
        }
    }
}

namespace EnhancedScrollerDemos
{
    namespace MainMenu
    {
        class ReturnToMainMenu : UnityEngine.MonoBehaviour
        {
            /*0xe37c44*/ ReturnToMainMenu();
            /*0xe37bdc*/ void ReturnToMainMenuButton_OnClick();
        }
    }

    namespace FlickSnap
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;

            /*0xe37c78*/ CellView();
            /*0xe37c4c*/ void SetData(EnhancedScrollerDemos.FlickSnap.Data data);
        }

        class Data
        {
            /*0x10*/ string someText;

            /*0xe37c80*/ Data();
        }

        class DemoController : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.FlickSnap.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x30*/ EnhancedScrollerDemos.FlickSnap.FlickSnap flickSnap;
            /*0x38*/ float cellViewSize;

            /*0xe37f70*/ DemoController();
            /*0xe37c88*/ void Start();
            /*0xe37cc0*/ void LoadData();
            /*0xe37e30*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe37e4c*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe37e54*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class FlickSnap : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler
        {
            /*0x18*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType snapTweenType;
            /*0x24*/ float snapTweenTime;
            /*0x28*/ int <MaxDataElements>k__BackingField;
            /*0x2c*/ bool _isDragging;
            /*0x30*/ UnityEngine.Vector2 _dragStartPosition;
            /*0x38*/ int _currentIndex;

            /*0xe3807c*/ FlickSnap();
            /*0xe37f78*/ int get_MaxDataElements();
            /*0xe37f80*/ void set_MaxDataElements(int value);
            /*0xe37f88*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData data);
            /*0xe37fdc*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData data);
        }
    }

    namespace Chat
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;
            /*0x38*/ UnityEngine.RectTransform textRectTransform;
            /*0x40*/ UnityEngine.RectOffset textBuffer;

            /*0xe38108*/ CellView();
            /*0xe380dc*/ void SetData(EnhancedScrollerDemos.Chat.Data data);
        }

        class Chat : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.Chat.Data> _data;
            /*0x20*/ float _totalCellSize;
            /*0x24*/ float _oldScrollPosition;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x30*/ UnityEngine.UI.InputField myInputField;
            /*0x38*/ UnityEngine.UI.InputField otherInputField;
            /*0x40*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView myTextCellViewPrefab;
            /*0x48*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView otherTextCellViewPrefab;
            /*0x50*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView spacerCellViewPrefab;
            /*0x58*/ int characterWidth;
            /*0x5c*/ int characterHeight;

            /*0xe38b50*/ Chat();
            /*0xe38110*/ void Start();
            /*0xe38470*/ void Update();
            /*0xe385c4*/ void AddNewRow(EnhancedScrollerDemos.Chat.Data.CellType cellType, string text);
            /*0xe38264*/ void ResizeScroller();
            /*0xe3884c*/ void ResetSpacer();
            /*0xe384cc*/ void SendButton_Click();
            /*0xe38548*/ void OtherSendButton_Click();
            /*0xe388dc*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe38924*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe38988*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ EnhancedScrollerDemos.Chat.Data.CellType cellType;
            /*0x18*/ string someText;
            /*0x20*/ float cellSize;

            /*0xe3825c*/ Data();

            enum CellType
            {
                Spacer = 0,
                MyText = 1,
                OtherText = 2,
            }
        }
    }

    namespace ExpandingCells
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedUI.EnhancedScroller.Tween tween;
            /*0x38*/ UnityEngine.UI.LayoutElement layoutElement;
            /*0x40*/ EnhancedScrollerDemos.ExpandingCells.Data data;
            /*0x48*/ UnityEngine.UI.Text dataIndexText;
            /*0x50*/ UnityEngine.UI.Text headerText;
            /*0x58*/ UnityEngine.UI.Text descriptionText;
            /*0x60*/ System.Action<int, int> initializeTween;
            /*0x68*/ System.Action<int, int, float, float> updateTween;
            /*0x70*/ System.Action<int, int> endTween;

            /*0xe38fbc*/ CellView();
            /*0xe38b64*/ void Start();
            /*0xe38be0*/ void SetData(EnhancedScrollerDemos.ExpandingCells.Data data, int dataIndex, float collapsedSize, float expandedSize, System.Action<int, int> initializeTween, System.Action<int, int, float, float> updateTween, System.Action<int, int> endTween);
            /*0xe38c98*/ void CellButton_Clicked();
            /*0xe38cb8*/ void BeginTween();
            /*0xe38f2c*/ void TweenUpdated(float newValue, float delta);
            /*0xe38ed4*/ void TweenCompleted();
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.ExpandingCells.Data> _data;
            /*0x20*/ bool _lastPadderActive;
            /*0x24*/ float _lastPadderSize;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;

            /*0xe3994c*/ Controller();
            /*0xe38fc4*/ void Start();
            /*0xe39008*/ void LoadData();
            /*0xe39268*/ void InitializeTween(int dataIndex, int cellViewIndex);
            /*0xe395b0*/ void TweenUpdated(int dataIndex, int cellViewIndex, float newValue, float delta);
            /*0xe39604*/ void TweenEnd(int dataIndex, int cellViewIndex);
            /*0xe39660*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3967c*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe39710*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ bool isExpanded;
            /*0x18*/ string headerText;
            /*0x20*/ string descriptionText;
            /*0x28*/ float collapsedSize;
            /*0x2c*/ float expandedSize;
            /*0x30*/ EnhancedUI.EnhancedScroller.Tween.TweenType tweenType;
            /*0x34*/ float tweenTimeExpand;
            /*0x38*/ float tweenTimeCollapse;

            /*0xe39260*/ Data();
            /*0xe396f4*/ float get_Size();
            /*0xe395a4*/ float get_SizeDifference();
        }
    }

    namespace KeyControlGrid
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.KeyControlGrid.RowCellView[] rowCellViews;

            /*0xe39b58*/ CellView();
            /*0xe39954*/ void SetData(ref EnhancedUI.SmallList<EnhancedScrollerDemos.KeyControlGrid.Data> data, int startingIndex);
            /*0xe39a88*/ void RefreshCellView();
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.KeyControlGrid.Data> _data;
            /*0x20*/ int _selectedIndex;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x30*/ int numberOfCellsPerRow;
            /*0x38*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;

            /*0xe3a09c*/ Controller();
            /*0xe39b60*/ void Start();
            /*0xe39cdc*/ void Update();
            /*0xe39b98*/ void LoadData();
            /*0xe39eb8*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe39f40*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe39f4c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ bool isSelected;
            /*0x18*/ string someText;

            /*0xe39eb0*/ Data();
        }

        class RowCellView : UnityEngine.MonoBehaviour
        {
            /*0x18*/ EnhancedScrollerDemos.KeyControlGrid.Data _data;
            /*0x20*/ UnityEngine.GameObject container;
            /*0x28*/ UnityEngine.UI.Image backgroundImage;
            /*0x30*/ UnityEngine.UI.Text someTextText;
            /*0x38*/ UnityEngine.Color selectedColor;
            /*0x48*/ UnityEngine.Color unselectedColor;

            /*0xe3a0ac*/ RowCellView();
            /*0xe39a28*/ void SetData(EnhancedScrollerDemos.KeyControlGrid.Data data);
            /*0xe39ae4*/ void RefreshCellView();
        }
    }

    namespace KeyControl
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.KeyControl.Data _data;
            /*0x38*/ UnityEngine.UI.Image backgroundImage;
            /*0x40*/ UnityEngine.UI.Text someTextText;
            /*0x48*/ UnityEngine.Color selectedColor;
            /*0x58*/ UnityEngine.Color unselectedColor;

            /*0xe3a164*/ CellView();
            /*0xe3a0b4*/ void SetData(EnhancedScrollerDemos.KeyControl.Data data);
            /*0xe3a0f8*/ void RefreshCellView();
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.KeyControl.Data> _data;
            /*0x20*/ int _selectedIndex;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;

            /*0xe3a5cc*/ Controller();
            /*0xe3a16c*/ void Start();
            /*0xe3a310*/ void Update();
            /*0xe3a1a4*/ void LoadData();
            /*0xe3a47c*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3a498*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3a4b0*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ bool isSelected;
            /*0x18*/ string someText;

            /*0xe3a474*/ Data();
        }
    }

    namespace Pagination
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;

            /*0xe3a600*/ CellView();
            /*0xe3a5d4*/ void SetData(EnhancedScrollerDemos.Pagination.Data data);
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.Pagination.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedScrollerDemos.Pagination.CellView cellViewPrefab;
            /*0x30*/ EnhancedScrollerDemos.Pagination.LoadingCellView loadingCellViewPrefab;
            /*0x38*/ int cellHeight;
            /*0x3c*/ int pageCount;
            /*0x40*/ bool _loadingNew;

            /*0xe3ab34*/ Controller();
            /*0xe3a608*/ void Start();
            /*0xe3a6f4*/ void LoadData(int pageStartIndex);
            /*0xe3a850*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3a870*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3a87c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe3aa30*/ void ScrollerScrolled(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition);
            /*0xe3aaa4*/ System.Collections.IEnumerator FakeDelay();

            class <FakeDelay>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedScrollerDemos.Pagination.Controller <>4__this;

                /*0xe3ab0c*/ <FakeDelay>d__13(int <>1__state);
                /*0xe3ab3c*/ void System.IDisposable.Dispose();
                /*0xe3ab40*/ bool MoveNext();
                /*0xe3abec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe3abf4*/ void System.Collections.IEnumerator.Reset();
                /*0xe3ac34*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class Data
        {
            /*0x10*/ string someText;

            /*0xe3a848*/ Data();
        }

        class LoadingCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0xe3ac3c*/ LoadingCellView();
        }
    }

    namespace NestedLinkedScrollers
    {
        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.NestedLinkedScrollers.MasterData> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller masterScroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView masterCellViewPrefab;
            /*0x30*/ UnityEngine.UI.Scrollbar HScrollbar;

            /*0xe3b380*/ Controller();
            /*0xe3ac44*/ void Start();
            /*0xe3ac7c*/ void LoadData();
            /*0xe3af38*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3af80*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3af8c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe3b190*/ void DetailScrollerScrolled(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition);
            /*0xe3b358*/ void HScrollbarOnValueChanged(float value);
            /*0xe3b1d0*/ void UpdateDetailScrollers(float normalizedScrollPosition);
        }

        class DetailCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;

            /*0xe3b3b4*/ DetailCellView();
            /*0xe3b388*/ void SetData(EnhancedScrollerDemos.NestedLinkedScrollers.DetailData data);
        }

        class DetailData
        {
            /*0x10*/ string someText;

            /*0xe3af30*/ DetailData();
        }

        class MasterCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x29*/ bool reloadDataNextFrame;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScroller detailScroller;
            /*0x38*/ EnhancedScrollerDemos.NestedLinkedScrollers.MasterData _data;
            /*0x40*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView detailCellViewPrefab;
            /*0x48*/ EnhancedUI.EnhancedScroller.ScrollerScrolledDelegate detailScrollerScrolledDelegate;

            /*0xe3b650*/ MasterCellView();
            /*0xe3b0f0*/ void SetData(EnhancedScrollerDemos.NestedLinkedScrollers.MasterData data);
            /*0xe3b3bc*/ void Update();
            /*0xe3b3f4*/ void RefreshCellView();
            /*0xe3b430*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3b480*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3b48c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe3b5b0*/ void ScrollerScrolled(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition);
        }

        class MasterData
        {
            /*0x10*/ float normalizedScrollPosition;
            /*0x14*/ float linkedScrollPosition;
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.NestedLinkedScrollers.DetailData> childData;

            /*0xe3af28*/ MasterData();
        }

        class ScrollRectEx : UnityEngine.UI.ScrollRect
        {
            /*0x128*/ bool routeToParent;

            /*0xe3bae0*/ ScrollRectEx();
            void DoForParents<T>(System.Action<T> action);
            /*0xe3b658*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xe3b744*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xe3b844*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xe3b9e0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3b73c*/ <>c__DisplayClass2_0();
                /*0xe3bae8*/ void <OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3b83c*/ <>c__DisplayClass3_0();
                /*0xe3bb90*/ void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3b9d8*/ <>c__DisplayClass4_0();
                /*0xe3bc38*/ void <OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3bad8*/ <>c__DisplayClass5_0();
                /*0xe3bce0*/ void <OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent);
            }
        }
    }

    namespace NestedScrollers
    {
        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.NestedScrollers.MasterData> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller masterScroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView masterCellViewPrefab;

            /*0xe3c28c*/ Controller();
            /*0xe3bd88*/ void Start();
            /*0xe3bdc0*/ void LoadData();
            /*0xe3c07c*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3c0c4*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3c0d0*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class DetailCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;

            /*0xe3c2c0*/ DetailCellView();
            /*0xe3c294*/ void SetData(EnhancedScrollerDemos.NestedScrollers.DetailData data);
        }

        class DetailData
        {
            /*0x10*/ string someText;

            /*0xe3c074*/ DetailData();
        }

        class MasterCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x29*/ bool reloadDataNextFrame;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScroller detailScroller;
            /*0x38*/ EnhancedScrollerDemos.NestedScrollers.MasterData _data;
            /*0x40*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView detailCellViewPrefab;

            /*0xe3c4c4*/ MasterCellView();
            /*0xe3c1ec*/ void SetData(EnhancedScrollerDemos.NestedScrollers.MasterData data);
            /*0xe3c2c8*/ void Update();
            /*0xe3c300*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3c350*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3c35c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe3c480*/ void ScrollerScrolled(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition);
        }

        class MasterData
        {
            /*0x10*/ float normalizedScrollPosition;
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.NestedScrollers.DetailData> childData;

            /*0xe3c06c*/ MasterData();
        }

        class ScrollRectEx : UnityEngine.UI.ScrollRect
        {
            /*0x128*/ bool routeToParent;

            /*0xe3c954*/ ScrollRectEx();
            void DoForParents<T>(System.Action<T> action);
            /*0xe3c4cc*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xe3c5b8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xe3c6b8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xe3c854*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3c5b0*/ <>c__DisplayClass2_0();
                /*0xe3c95c*/ void <OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3c6b0*/ <>c__DisplayClass3_0();
                /*0xe3ca04*/ void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3c84c*/ <>c__DisplayClass4_0();
                /*0xe3caac*/ void <OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

                /*0xe3c94c*/ <>c__DisplayClass5_0();
                /*0xe3cb54*/ void <OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent);
            }
        }
    }

    namespace PullDownRefresh
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;

            /*0xe3cc28*/ CellView();
            /*0xe3cbfc*/ void SetData(EnhancedScrollerDemos.PullDownRefresh.Data data);
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.PullDownRefresh.Data> _data;
            /*0x20*/ bool _dragging;
            /*0x21*/ bool _pullToRefresh;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x38*/ float pullDownThreshold;
            /*0x40*/ UnityEngine.UI.Text pullDownToRefreshText;
            /*0x48*/ UnityEngine.UI.Text releaseToRefreshText;

            /*0xe3d178*/ Controller();
            /*0xe3cc30*/ void Start();
            /*0xe3cccc*/ void LoadLargeData();
            /*0xe3ce2c*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3ce48*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3ce60*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe3cf7c*/ void ScrollerScrolled(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, UnityEngine.Vector2 val, float scrollPosition);
            /*0xe3d01c*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData data);
            /*0xe3d028*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData data);
        }

        class Data
        {
            /*0x10*/ string someText;

            /*0xe3ce24*/ Data();
        }
    }

    namespace GridSelection
    {
        class SelectedDelegate : System.MulticastDelegate
        {
            /*0xe3d180*/ SelectedDelegate(object object, nint method);
            /*0xe3d2ac*/ void Invoke(EnhancedScrollerDemos.GridSelection.RowCellView rowCellView);
            /*0xe3d2c0*/ System.IAsyncResult BeginInvoke(EnhancedScrollerDemos.GridSelection.RowCellView rowCellView, System.AsyncCallback callback, object object);
            /*0xe3d2e0*/ void EndInvoke(System.IAsyncResult result);
        }

        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.GridSelection.RowCellView[] rowCellViews;

            /*0xe3d5e0*/ CellView();
            /*0xe3d2ec*/ void SetData(ref EnhancedUI.SmallList<EnhancedScrollerDemos.GridSelection.Data> data, int startingIndex, EnhancedScrollerDemos.GridSelection.SelectedDelegate selected);
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.GridSelection.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x30*/ int numberOfCellsPerRow;

            /*0xe3db14*/ Controller();
            /*0xe3d5e8*/ void Start();
            /*0xe3d620*/ void LoadData();
            /*0xe3d7a8*/ void CellViewSelected(EnhancedScrollerDemos.GridSelection.RowCellView cellView);
            /*0xe3d8e0*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3d968*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3d974*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class SelectedChangedDelegate : System.MulticastDelegate
        {
            /*0xe3db24*/ SelectedChangedDelegate(object object, nint method);
            /*0xe3dbe8*/ void Invoke(bool val);
            /*0xe3dc00*/ System.IAsyncResult BeginInvoke(bool val, System.AsyncCallback callback, object object);
            /*0xe3dc88*/ void EndInvoke(System.IAsyncResult result);
        }

        class Data
        {
            /*0x10*/ string someText;
            /*0x18*/ EnhancedScrollerDemos.GridSelection.SelectedChangedDelegate selectedChanged;
            /*0x20*/ bool _selected;

            /*0xe3d7a0*/ Data();
            /*0xe3dc94*/ bool get_Selected();
            /*0xe3d8ac*/ void set_Selected(bool value);
        }

        class RowCellView : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.GameObject container;
            /*0x20*/ UnityEngine.UI.Text text;
            /*0x28*/ UnityEngine.UI.Image selectionPanel;
            /*0x30*/ UnityEngine.Color selectedColor;
            /*0x40*/ UnityEngine.Color unSelectedColor;
            /*0x50*/ int <DataIndex>k__BackingField;
            /*0x58*/ EnhancedScrollerDemos.GridSelection.SelectedDelegate selected;
            /*0x60*/ EnhancedScrollerDemos.GridSelection.Data _data;

            /*0xe3ddf4*/ RowCellView();
            /*0xe3dc9c*/ int get_DataIndex();
            /*0xe3dca4*/ void set_DataIndex(int value);
            /*0xe3dcac*/ void OnDestroy();
            /*0xe3d3d8*/ void SetData(int dataIndex, EnhancedScrollerDemos.GridSelection.Data data, EnhancedScrollerDemos.GridSelection.SelectedDelegate selected);
            /*0xe3dd70*/ void SelectedChanged(bool selected);
            /*0xe3ddd4*/ void OnSelected();
        }
    }

    namespace GridSimulation
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.GridSimulation.RowCellView[] rowCellViews;

            /*0xe3df30*/ CellView();
            /*0xe3ddfc*/ void SetData(ref EnhancedUI.SmallList<EnhancedScrollerDemos.GridSimulation.Data> data, int startingIndex);
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.GridSimulation.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x30*/ int numberOfCellsPerRow;

            /*0xe3e28c*/ Controller();
            /*0xe3df38*/ void Start();
            /*0xe3df70*/ void LoadData();
            /*0xe3e0a8*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3e130*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3e13c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ string someText;

            /*0xe3e0a0*/ Data();
        }

        class RowCellView : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.GameObject container;
            /*0x20*/ UnityEngine.UI.Text text;

            /*0xe3e29c*/ RowCellView();
            /*0xe3ded0*/ void SetData(EnhancedScrollerDemos.GridSimulation.Data data);
        }
    }

    namespace CellEvents
    {
        class CellButtonTextClickedDelegate : System.MulticastDelegate
        {
            /*0xe3e2a4*/ CellButtonTextClickedDelegate(object object, nint method);
            /*0xe3e378*/ void Invoke(string value);
            /*0xe3e38c*/ System.IAsyncResult BeginInvoke(string value, System.AsyncCallback callback, object object);
            /*0xe3e3ac*/ void EndInvoke(System.IAsyncResult result);
        }

        class CellButtonIntegerClickedDelegate : System.MulticastDelegate
        {
            /*0xe3e3b8*/ CellButtonIntegerClickedDelegate(object object, nint method);
            /*0xe3e47c*/ void Invoke(int value);
            /*0xe3e490*/ System.IAsyncResult BeginInvoke(int value, System.AsyncCallback callback, object object);
            /*0xe3e514*/ void EndInvoke(System.IAsyncResult result);
        }

        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.CellEvents.Data _data;
            /*0x38*/ UnityEngine.UI.Text someTextText;
            /*0x40*/ EnhancedScrollerDemos.CellEvents.CellButtonTextClickedDelegate cellButtonTextClicked;
            /*0x48*/ EnhancedScrollerDemos.CellEvents.CellButtonIntegerClickedDelegate cellButtonFixedIntegerClicked;
            /*0x50*/ EnhancedScrollerDemos.CellEvents.CellButtonIntegerClickedDelegate cellButtonDataIntegerClicked;

            /*0xe3e640*/ CellView();
            /*0xe3e520*/ void SetData(EnhancedScrollerDemos.CellEvents.Data data);
            /*0xe3e5d0*/ void CellButtonText_OnClick(string value);
            /*0xe3e5ec*/ void CellButtonFixedInteger_OnClick(int value);
            /*0xe3e608*/ void CellButtonDataInteger_OnClick();
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.CellEvents.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x30*/ float cellSize;

            /*0xe3eb8c*/ Controller();
            /*0xe3e648*/ void Start();
            /*0xe3e680*/ void LoadData();
            /*0xe3e7d4*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3e81c*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3e824*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe3e9c0*/ void CellButtonTextClicked(string value);
            /*0xe3ea4c*/ void CellButtonFixedIntegerClicked(int value);
            /*0xe3eaec*/ void CellButtonDataIntegerClicked(int value);
        }

        class Data
        {
            /*0x10*/ int hour;

            /*0xe3e7cc*/ Data();
        }
    }

    namespace ViewDrivenCellSizes
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;
            /*0x38*/ UnityEngine.RectTransform textRectTransform;
            /*0x40*/ UnityEngine.RectOffset textBuffer;

            /*0xe3ec5c*/ CellView();
            /*0xe3eb94*/ void SetData(EnhancedScrollerDemos.ViewDrivenCellSizes.Data data, bool calculateLayout);
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.ViewDrivenCellSizes.Data> _data;
            /*0x20*/ bool _calculateLayout;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;

            /*0xe3fa58*/ Controller();
            /*0xe3ec64*/ void Start();
            /*0xe3ec9c*/ void LoadData();
            /*0xe3f60c*/ void AddNewRow();
            /*0xe3f548*/ void ResizeScroller();
            /*0xe3f8d0*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe3f918*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe3f97c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ string someText;
            /*0x18*/ float cellSize;

            /*0xe40a60*/ Data();
        }
    }

    namespace RefreshDemo
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.RefreshDemo.Data _data;
            /*0x38*/ UnityEngine.UI.Text someTextText;

            /*0xe40b00*/ CellView();
            /*0xe40a68*/ UnityEngine.RectTransform get_RectTransform();
            /*0xe40ac0*/ void SetData(EnhancedScrollerDemos.RefreshDemo.Data data);
            /*0xe40ad0*/ void RefreshCellView();
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.RefreshDemo.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;

            /*0xe41108*/ Controller();
            /*0xe40b08*/ void Start();
            /*0xe40c9c*/ void Update();
            /*0xe40b40*/ void LoadLargeData();
            /*0xe40e0c*/ void LoadSmallData();
            /*0xe40fa4*/ void LoadLargeDataButton_OnClick();
            /*0xe40fa8*/ void LoadSmallDataButton_OnClick();
            /*0xe40fac*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe40fc8*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe40fe0*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ string someText;

            /*0xe40e04*/ Data();
        }
    }

    namespace SnappingDemo
    {
        class PlayWin : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.Transform _transform;
            /*0x20*/ float _timeLeft;
            /*0x28*/ UnityEngine.UI.Text scoreText;
            /*0x30*/ float zoomTime;
            /*0x34*/ float holdTime;
            /*0x38*/ float unZoomTime;

            /*0xe41458*/ PlayWin();
            /*0xe41110*/ void Awake();
            /*0xe41180*/ void Play(int score);
            /*0xe412a8*/ System.Collections.IEnumerator PlayZoom();
            /*0xe41338*/ System.Collections.IEnumerator PlayHold();
            /*0xe413c8*/ System.Collections.IEnumerator PlayUnZoom();

            class <PlayZoom>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedScrollerDemos.SnappingDemo.PlayWin <>4__this;

                /*0xe41310*/ <PlayZoom>d__8(int <>1__state);
                /*0xe41460*/ void System.IDisposable.Dispose();
                /*0xe41464*/ bool MoveNext();
                /*0xe4160c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe41614*/ void System.Collections.IEnumerator.Reset();
                /*0xe41654*/ object System.Collections.IEnumerator.get_Current();
            }

            class <PlayHold>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedScrollerDemos.SnappingDemo.PlayWin <>4__this;

                /*0xe413a0*/ <PlayHold>d__9(int <>1__state);
                /*0xe4165c*/ void System.IDisposable.Dispose();
                /*0xe41660*/ bool MoveNext();
                /*0xe416f0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe416f8*/ void System.Collections.IEnumerator.Reset();
                /*0xe41738*/ object System.Collections.IEnumerator.get_Current();
            }

            class <PlayUnZoom>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedScrollerDemos.SnappingDemo.PlayWin <>4__this;

                /*0xe41430*/ <PlayUnZoom>d__10(int <>1__state);
                /*0xe41740*/ void System.IDisposable.Dispose();
                /*0xe41744*/ bool MoveNext();
                /*0xe418cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe418d4*/ void System.Collections.IEnumerator.Reset();
                /*0xe41914*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class SlotCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Image slotImage;

            /*0xe419f4*/ SlotCellView();
            /*0xe4191c*/ void SetData(EnhancedScrollerDemos.SnappingDemo.SlotData data);
        }

        class SlotController : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.SnappingDemo.SlotData> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView slotCellViewPrefab;

            /*0xe41cd0*/ SlotController();
            /*0xe419fc*/ void Awake();
            /*0xe41a70*/ void Start();
            /*0xe41a90*/ void Reload(UnityEngine.Sprite[] sprites);
            /*0xe41bb0*/ void AddVelocity(float amount);
            /*0xe41bcc*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe41be8*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe41bf4*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class SlotData
        {
            /*0x10*/ UnityEngine.Sprite sprite;

            /*0xe41ba8*/ SlotData();
        }

        class SnappingDemo : UnityEngine.MonoBehaviour
        {
            /*0x18*/ EnhancedScrollerDemos.SnappingDemo.SlotController[] _slotControllers;
            /*0x20*/ int[] _snappedDataIndices;
            /*0x28*/ int _credits;
            /*0x2c*/ int _snapCount;
            /*0x30*/ EnhancedScrollerDemos.SnappingDemo.SnappingDemo.GameStateEnum _gameState;
            /*0x34*/ float minVelocity;
            /*0x38*/ float maxVelocity;
            /*0x3c*/ int cherryIndex;
            /*0x40*/ int sevenIndex;
            /*0x44*/ int tripleBarIndex;
            /*0x48*/ int bigWinIndex;
            /*0x4c*/ int blankIndex;
            /*0x50*/ UnityEngine.Sprite[] slotSprites;
            /*0x58*/ UnityEngine.UI.Button pullLeverButton;
            /*0x60*/ UnityEngine.UI.Text creditsText;
            /*0x68*/ int startingCredits;
            /*0x70*/ UnityEngine.GameObject playingPanel;
            /*0x78*/ UnityEngine.GameObject gameOverPanel;
            /*0x80*/ EnhancedScrollerDemos.SnappingDemo.PlayWin playWin;

            /*0xe422d8*/ SnappingDemo();
            /*0xe41cd8*/ int get_Credits();
            /*0xe41ce0*/ void set_Credits(int value);
            /*0xe41dbc*/ EnhancedScrollerDemos.SnappingDemo.SnappingDemo.GameStateEnum get_GameState();
            /*0xe41dc4*/ void set_GameState(EnhancedScrollerDemos.SnappingDemo.SnappingDemo.GameStateEnum value);
            /*0xe41e88*/ void Awake();
            /*0xe41fc8*/ void Start();
            /*0xe4202c*/ void LateUpdate();
            /*0xe42040*/ void PullLeverButton_OnClick();
            /*0xe42124*/ void ResetButton_OnClick();
            /*0xe4212c*/ void ScrollerSnapped(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int cellIndex, int dataIndex, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe421c4*/ void TallyScore();

            enum GameStateEnum
            {
                Initializing = 0,
                Playing = 1,
                GameOver = 2,
            }
        }
    }

    namespace RemoteResourcesDemo
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Image cellImage;
            /*0x38*/ UnityEngine.Sprite defaultSprite;
            /*0x40*/ UnityEngine.Coroutine _loadImageCoroutine;

            /*0xe423dc*/ CellView();
            /*0xe422e0*/ void SetData(EnhancedScrollerDemos.RemoteResourcesDemo.Data data);
            /*0xe42308*/ System.Collections.IEnumerator LoadRemoteImage(EnhancedScrollerDemos.RemoteResourcesDemo.Data data);
            /*0xe423a4*/ void ClearImage();
            /*0xe423c8*/ void WillRecycle();

            class <LoadRemoteImage>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ EnhancedScrollerDemos.RemoteResourcesDemo.Data data;
                /*0x28*/ EnhancedScrollerDemos.RemoteResourcesDemo.CellView <>4__this;
                /*0x30*/ string <path>5__2;
                /*0x38*/ UnityEngine.Texture2D <texture>5__3;
                /*0x40*/ UnityEngine.Networking.UnityWebRequest <webRequest>5__4;

                /*0xe4237c*/ <LoadRemoteImage>d__4(int <>1__state);
                /*0xe423e4*/ void System.IDisposable.Dispose();
                /*0xe423e8*/ bool MoveNext();
                /*0xe42640*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xe42648*/ void System.Collections.IEnumerator.Reset();
                /*0xe42688*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.RemoteResourcesDemo.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x30*/ bool preloadCells;
            /*0x38*/ string[] imageURLList;

            /*0xe42b70*/ Controller();
            /*0xe42690*/ void Start();
            /*0xe428e0*/ void HandleCellViewWillRecycleDelegate(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe428e4*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe42900*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe4290c*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
            /*0xe429f8*/ void CellViewVisibilityChanged(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe42ae0*/ void CellViewWillRecycle(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
        }

        class Data
        {
            /*0x10*/ UnityEngine.Vector2 imageDimensions;
            /*0x18*/ string imageUrl;

            /*0xe428d8*/ Data();
        }

        class RemoteImageList
        {
            /*0x10*/ EnhancedScrollerDemos.RemoteResourcesDemo.RemoteImage[] images;

            /*0xe42b78*/ RemoteImageList();
        }

        class RemoteImage
        {
            /*0x10*/ string url;
            /*0x18*/ EnhancedScrollerDemos.RemoteResourcesDemo.RemoteImageSize size;

            /*0xe42b80*/ RemoteImage();
        }

        class RemoteImageSize
        {
            /*0x10*/ float x;
            /*0x14*/ float y;

            /*0xe42b88*/ RemoteImageSize();
        }
    }

    namespace JumpToDemo
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text cellText;

            /*0xe42bbc*/ CellView();
            /*0xe42b90*/ void SetData(EnhancedScrollerDemos.JumpToDemo.Data data);
        }

        class Controller : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ System.Collections.Generic.List<EnhancedScrollerDemos.JumpToDemo.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller vScroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller hScroller;
            /*0x30*/ UnityEngine.UI.InputField jumpIndexInput;
            /*0x38*/ UnityEngine.UI.Toggle useSpacingToggle;
            /*0x40*/ UnityEngine.UI.Slider scrollerOffsetSlider;
            /*0x48*/ UnityEngine.UI.Slider cellOffsetSlider;
            /*0x50*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;
            /*0x58*/ EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType vScrollerTweenType;
            /*0x5c*/ float vScrollerTweenTime;
            /*0x60*/ EnhancedUI.EnhancedScroller.EnhancedScroller.TweenType hScrollerTweenType;
            /*0x64*/ float hScrollerTweenTime;

            /*0xe43148*/ Controller();
            /*0xe42bc4*/ void Start();
            /*0xe42db8*/ void JumpButton_OnClick();
            /*0xe42f48*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe42f90*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe43028*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }

        class Data
        {
            /*0x10*/ string cellText;

            /*0xe42db0*/ Data();
        }
    }

    namespace SelectionDemo
    {
        class SelectedDelegate : System.MulticastDelegate
        {
            /*0xe43150*/ SelectedDelegate(object object, nint method);
            /*0xe4327c*/ void Invoke(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe43290*/ System.IAsyncResult BeginInvoke(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView, System.AsyncCallback callback, object object);
            /*0xe432b0*/ void EndInvoke(System.IAsyncResult result);
        }

        class InventoryCellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.SelectionDemo.InventoryData _data;
            /*0x38*/ UnityEngine.UI.Image selectionPanel;
            /*0x40*/ UnityEngine.UI.Text itemNameText;
            /*0x48*/ UnityEngine.UI.Text itemCostText;
            /*0x50*/ UnityEngine.UI.Text itemDamageText;
            /*0x58*/ UnityEngine.UI.Text itemDefenseText;
            /*0x60*/ UnityEngine.UI.Text itemWeightText;
            /*0x68*/ UnityEngine.UI.Text itemDescriptionText;
            /*0x70*/ UnityEngine.UI.Image image;
            /*0x78*/ UnityEngine.Color selectedColor;
            /*0x88*/ UnityEngine.Color unSelectedColor;
            /*0x98*/ int <DataIndex>k__BackingField;
            /*0xa0*/ EnhancedScrollerDemos.SelectionDemo.SelectedDelegate selected;

            /*0xe4391c*/ InventoryCellView();
            /*0xe432bc*/ int get_DataIndex();
            /*0xe432c4*/ void set_DataIndex(int value);
            /*0xe432cc*/ void OnDestroy();
            /*0xe43454*/ void SetData(int dataIndex, EnhancedScrollerDemos.SelectionDemo.InventoryData data, bool isVertical);
            /*0xe43898*/ void SelectedChanged(bool selected);
            /*0xe438fc*/ void OnSelected();
        }

        class SelectedChangedDelegate : System.MulticastDelegate
        {
            /*0xe43390*/ SelectedChangedDelegate(object object, nint method);
            /*0xe43924*/ void Invoke(bool val);
            /*0xe4393c*/ System.IAsyncResult BeginInvoke(bool val, System.AsyncCallback callback, object object);
            /*0xe439c4*/ void EndInvoke(System.IAsyncResult result);
        }

        class InventoryData
        {
            /*0x10*/ string itemName;
            /*0x18*/ int itemCost;
            /*0x1c*/ int itemDamage;
            /*0x20*/ int itemDefense;
            /*0x24*/ int itemWeight;
            /*0x28*/ string itemDescription;
            /*0x30*/ string spritePath;
            /*0x38*/ EnhancedScrollerDemos.SelectionDemo.SelectedChangedDelegate selectedChanged;
            /*0x40*/ bool _selected;

            /*0xe43a0c*/ InventoryData();
            /*0xe439d0*/ bool get_Selected();
            /*0xe439d8*/ void set_Selected(bool value);
        }

        class SelectionDemo : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.SelectionDemo.InventoryData> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller vScroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScroller hScroller;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView vCellViewPrefab;
            /*0x38*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView hCellViewPrefab;
            /*0x40*/ UnityEngine.UI.Image selectedImage;
            /*0x48*/ UnityEngine.UI.Text selectedImageText;
            /*0x50*/ string resourcePath;

            /*0xe447c4*/ SelectionDemo();
            /*0xe43a14*/ void Awake();
            /*0xe43e0c*/ void Start();
            /*0xe43e4c*/ void Reload();
            /*0xe43bac*/ void CellViewSelected(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
            /*0xe43ae4*/ void MaskToggle_OnValueChanged(bool val);
            /*0xe43b68*/ void LoopToggle_OnValueChanged(bool val);
            /*0xe444c4*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe444e0*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe44568*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }
    }

    namespace MultipleCellTypesDemo
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ EnhancedScrollerDemos.MultipleCellTypesDemo.Data _data;

            /*0xe447d4*/ CellView();
            /*0xe447cc*/ void SetData(EnhancedScrollerDemos.MultipleCellTypesDemo.Data data);
        }

        class CellViewFooter : EnhancedScrollerDemos.MultipleCellTypesDemo.CellView
        {
            /*0xe447dc*/ CellViewFooter();
        }

        class CellViewHeader : EnhancedScrollerDemos.MultipleCellTypesDemo.CellView
        {
            /*0x38*/ EnhancedScrollerDemos.MultipleCellTypesDemo.HeaderData _headerData;
            /*0x40*/ UnityEngine.UI.Text categoryText;

            /*0xe4488c*/ CellViewHeader();
            /*0xe447e4*/ void SetData(EnhancedScrollerDemos.MultipleCellTypesDemo.Data data);
        }

        class CellViewRow : EnhancedScrollerDemos.MultipleCellTypesDemo.CellView
        {
            /*0x38*/ EnhancedScrollerDemos.MultipleCellTypesDemo.RowData _rowData;
            /*0x40*/ UnityEngine.UI.Text userNameText;
            /*0x48*/ UnityEngine.UI.Image userAvatarImage;
            /*0x50*/ UnityEngine.UI.Text userHighScoreText;

            /*0xe44a00*/ CellViewRow();
            /*0xe44894*/ void SetData(EnhancedScrollerDemos.MultipleCellTypesDemo.Data data);
        }

        class Data
        {
            /*0xe44a08*/ Data();
        }

        class HeaderData : EnhancedScrollerDemos.MultipleCellTypesDemo.Data
        {
            /*0x10*/ string category;

            /*0xe44a10*/ HeaderData();
        }

        class RowData : EnhancedScrollerDemos.MultipleCellTypesDemo.Data
        {
            /*0x10*/ string userName;
            /*0x18*/ string userAvatarSpritePath;
            /*0x20*/ ulong userHighScore;

            /*0xe44a18*/ RowData();
        }

        class FooterData : EnhancedScrollerDemos.MultipleCellTypesDemo.Data
        {
            /*0xe44a20*/ FooterData();
        }

        class MultipleCellTypesDemo : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.MultipleCellTypesDemo.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView headerCellViewPrefab;
            /*0x30*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView rowCellViewPrefab;
            /*0x38*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView footerCellViewPrefab;
            /*0x40*/ string resourcePath;

            /*0xe45704*/ MultipleCellTypesDemo();
            /*0xe44a28*/ void Start();
            /*0xe44a60*/ void LoadData();
            /*0xe4528c*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe452a8*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe453c4*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }
    }

    namespace SuperSimpleDemo
    {
        class CellView : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
        {
            /*0x30*/ UnityEngine.UI.Text someTextText;

            /*0xe45738*/ CellView();
            /*0xe4570c*/ void SetData(EnhancedScrollerDemos.SuperSimpleDemo.Data data);
        }

        class Data
        {
            /*0x10*/ string someText;

            /*0xe45740*/ Data();
        }

        class SimpleDemo : UnityEngine.MonoBehaviour, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
        {
            /*0x18*/ EnhancedUI.SmallList<EnhancedScrollerDemos.SuperSimpleDemo.Data> _data;
            /*0x20*/ EnhancedUI.EnhancedScroller.EnhancedScroller scroller;
            /*0x28*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellViewPrefab;

            /*0xe45bd0*/ SimpleDemo();
            /*0xe45748*/ void Start();
            /*0xe45780*/ void LoadLargeData();
            /*0xe458dc*/ void LoadSmallData();
            /*0xe45a74*/ void LoadLargeDataButton_OnClick();
            /*0xe45a78*/ void LoadSmallDataButton_OnClick();
            /*0xe45a7c*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
            /*0xe45a98*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
            /*0xe45ab0*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        }
    }
}
