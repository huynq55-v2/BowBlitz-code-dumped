class <Module>
{
}

class ScreenAdaptationHelper
{
    static /*0x0*/ float DevelopWidth;
    static /*0x4*/ float DevelopHeigh;
    static /*0x8*/ float DevelopRate;
    static /*0xc*/ int curScreenWidth;
    static /*0x10*/ int curScreenHeight;
    static /*0x14*/ float ScreenRate;
    static /*0x18*/ float cameraRectHeightRate;
    static /*0x1c*/ float cameraRectWidthRate;

    static /*0x25f9ba0*/ ScreenAdaptationHelper();
    static /*0x25f9aa0*/ void CameraAdaptation(UnityEngine.Camera camera);
    static /*0x25f9b9c*/ void UIPanelAdaptation(UnityEngine.GameObject gameObject);
}

class StringHelper
{
    static /*0x0*/ char[] specialChar;

    static /*0x25fa1d8*/ StringHelper();
    static /*0x25f9ccc*/ System.Collections.Generic.List<int> SplitToIntList(string text, char[] separator);
    static /*0x25f9e40*/ System.Collections.Generic.List<float> SplitToFloatList(string text, char[] separator);
    static /*0x25f9fb4*/ string FilterName(string text);
    static /*0x25fa0e0*/ string FilterEmoji(string text);
}

class ClassInfo
{
    /*0x10*/ string nameSpace;
    /*0x18*/ string className;
    /*0x20*/ string funcName;

    /*0x25fa26c*/ ClassInfo();
}

class HotfixFunc
{
    static /*0x0*/ System.Func<ClassInfo, System.Reflection.BindingFlags, System.Object[], object, object> CrossDomainFunction;
    static /*0x8*/ System.Func<ClassInfo, System.Reflection.BindingFlags, object, object> CrossDomainProperty;
    static /*0x10*/ System.Func<ClassInfo, System.Reflection.BindingFlags, object, object> CrossDomainField;
    static /*0x18*/ System.Collections.Generic.Queue<ClassInfo> ClassInfos;

    static /*0x25fa998*/ HotfixFunc();
    static /*0x25fa274*/ ClassInfo GetClass(string nameSpace, string className, string fName);
    static /*0x25fa380*/ void PutClass(ClassInfo cls);
    static /*0x25fa400*/ object CallMethod(string nameSpace, string className, string funcName, System.Reflection.BindingFlags flag, object[] param, object instance);
    static /*0x25fa4fc*/ object CallPublicStaticMethod(string nameSpace, string className, string funcName, object[] param);
    static /*0x25fa5e8*/ object CallSingletonMethod(string nameSpace, string className, string instanceName, string funcName, object[] param);
    static /*0x25fa688*/ object CallProperty(string nameSpace, string className, string propertyName, System.Reflection.BindingFlags flag, object instance);
    static /*0x25fa774*/ object CallSingletonProperty(string nameSpace, string className, string instanceName, string propertyName, System.Reflection.BindingFlags flag);
    static /*0x25fa810*/ object CallField(string nameSpace, string className, string fieldName, System.Reflection.BindingFlags flag, object instance);
    static /*0x25fa8fc*/ object CallSingletonField(string nameSpace, string className, string instanceName, string fieldName, System.Reflection.BindingFlags flag);
}

interface IPoolObject
{
    void OnCreate();
    void OnRecycle();
    void Dispose();
}

class ReferenceCollection
{
    /*0x10*/ System.Collections.Generic.Queue<object> references;
    /*0x18*/ System.Type referenceType;
    /*0x20*/ int capacity;
    /*0x24*/ int usingReferenceCount;
    /*0x28*/ int allocateReferenceCount;
    /*0x2c*/ int recycleReferenceCount;
    /*0x30*/ int addReferenceCount;

    /*0x25faa8c*/ ReferenceCollection(System.Type referenceType);
    /*0x25faa24*/ int get_UnusedReferenceCount();
    /*0x25faa6c*/ int get_UsingReferenceCount();
    /*0x25faa74*/ int get_AllocateReferenceCount();
    /*0x25faa7c*/ int get_RecycleReferenceCount();
    /*0x25faa84*/ int get_AddReferenceCount();
    T Allocate<T>();
    /*0x25fab2c*/ object Allocate(System.Type type);
    /*0x25fad44*/ bool Recycle(object obj);
    /*0x25faf4c*/ bool Add(int count);
    /*0x25fb000*/ void Remove(int count);
    /*0x25fb090*/ void Dispose();
    /*0x25fb290*/ void SetCapacity(int capacity);
    /*0x25fac74*/ object Create();
}

class ReferencePool
{
    static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, ReferenceCollection> referencelCollections;

    static /*0x25fb7e8*/ ReferencePool();
    static void PreLoad<T>(int count, int capacity);
    static T Allocate<T>();
    static /*0x25fb298*/ object Allocate(System.Type type);
    static /*0x25fb490*/ bool Recycle(object obj);
    static bool Add<T>(int count);
    static void Remove<T>(int count);
    static void Dispose<T>();
    static /*0x25fb50c*/ void Dispose(System.Type type);
    static /*0x25fb56c*/ void DisposeAll();
    static /*0x25fb2fc*/ ReferenceCollection GetReferenceCollection(System.Type referenceType);
    /*0x25fb7e0*/ ReferencePool();
}

class ButtonEx : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler
{
    /*0x18*/ bool scalable;
    /*0x1c*/ UnityEngine.Vector3 downTo;
    /*0x28*/ UnityEngine.Vector3 upMidTo;
    /*0x34*/ UnityEngine.Vector3 upTo;
    /*0x40*/ float Duration;
    /*0x44*/ bool hasSound;
    /*0x48*/ string soundName;
    /*0x50*/ DG.Tweening.Tweener _startTweener;
    /*0x58*/ DG.Tweening.Tweener _midTweener;
    /*0x60*/ DG.Tweening.Tweener _endTweener;
    /*0x68*/ System.Func<string> SetSound;
    /*0x70*/ System.Action onPointDown;
    /*0x78*/ System.Action onPointUp;
    /*0x80*/ System.Action onPointEnter;
    /*0x88*/ System.Action onPointExit;
    /*0x90*/ bool scaleConfig;

    /*0x25fbd68*/ ButtonEx();
    /*0x25fb874*/ void Awake();
    /*0x25fb8f4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fb9e8*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fbb34*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fbcac*/ void OnDestroy();
    /*0x25fbcb0*/ void Clear();
    /*0x25fbd30*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fbd4c*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fbdec*/ void <OnPointerUp>b__18_0();
}

class EmptyGraphic : UnityEngine.UI.MaskableGraphic
{
    /*0x25fbed4*/ EmptyGraphic();
    /*0x25fbebc*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
}

class IgnoreEventRaycast : UnityEngine.MonoBehaviour
{
    /*0x25fbee4*/ IgnoreEventRaycast();
    /*0x25fbedc*/ void Start();
    /*0x25fbee0*/ void Update();
}

class ImgUVRoll : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.RawImage Image;
    /*0x20*/ float speed_x;
    /*0x24*/ float speed_y;

    /*0x25fc0ac*/ ImgUVRoll();
    /*0x25fbeec*/ void Start();
    /*0x25fbf3c*/ void Update();
}

class MainScrollEx : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler
{
    /*0x18*/ UnityEngine.UI.ScrollRect ScrollRect;
    /*0x20*/ UnityEngine.GameObject Content;
    /*0x28*/ bool FlickSnap;
    /*0x2c*/ float Speed;
    /*0x30*/ System.Action<int> OnScroll2Index;
    /*0x38*/ UnityEngine.RectTransform _contentRectTrans;
    /*0x40*/ UnityEngine.Vector3[] _corners;
    /*0x48*/ bool _dragging;
    /*0x49*/ bool _flicking;
    /*0x50*/ UnityEngine.Coroutine _coroutine;
    /*0x58*/ float[] pos;

    /*0x25fc624*/ MainScrollEx();
    /*0x25fc0c4*/ void Awake();
    /*0x25fc310*/ void LateUpdate();
    /*0x25fc4fc*/ void StartByIndex(int index);
    /*0x25fc554*/ void ScrollTo(int index);
    /*0x25fc474*/ System.Collections.IEnumerator ScrollTo(int index, float speed);
    /*0x25fc5d8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fc604*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fc610*/ void OnDestroy();

    class <ScrollTo>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ float speed;
        /*0x28*/ MainScrollEx <>4__this;
        /*0x30*/ int index;

        /*0x25fc5b0*/ <ScrollTo>d__15(int <>1__state);
        /*0x25fc6cc*/ void System.IDisposable.Dispose();
        /*0x25fc6d0*/ bool MoveNext();
        /*0x25fc88c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x25fc894*/ void System.Collections.IEnumerator.Reset();
        /*0x25fc8d4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class MainScrollNewEx : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IEndDragHandler
{
    /*0x18*/ Framework.ScrollerPro _scrollerPro;
    /*0x20*/ int _count;
    /*0x24*/ bool _flickSnap;
    /*0x28*/ System.Action<int> _flickFinish;
    /*0x30*/ bool _dragging;
    /*0x31*/ bool _flicking;

    /*0x25fca28*/ MainScrollNewEx();
    /*0x25fc8dc*/ void Init(Framework.ScrollerPro scrollerPro, int count, bool flickSnap, System.Action<int> flickFinish);
    /*0x25fc8f8*/ void LateUpdate();
    /*0x25fca10*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fca1c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
}

class PanerateMask : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IDragHandler
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> _rawRaycastResults;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.GameObject> TargetObj;

    /*0x25fd470*/ PanerateMask();
    /*0x25fca30*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fca34*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fcd58*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fd118*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
}

class TMPTextEx : TMPro.TextMeshProUGUI
{
    /*0x798*/ RTLTMPro.FastStringBuilder finalText;

    static /*0x25fd55c*/ bool HasArabic(string str);
    static /*0x25fd6c8*/ bool isArabic(char c);
    /*0x25fd710*/ TMPTextEx();
    /*0x25fd4ec*/ string get_text();
    /*0x25fd4f4*/ void set_text(string value);
    /*0x25fd600*/ string GetFixedText(string input);
}

class UIDragEvent : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IPointerUpHandler
{
    /*0x18*/ System.Action<UnityEngine.Vector2> OnUIStartDrag;
    /*0x20*/ System.Action<UnityEngine.Vector2> OnUIDrag;
    /*0x28*/ System.Action<UnityEngine.Vector2> OnUIEndDrag;

    /*0x25fd854*/ UIDragEvent();
    /*0x25fd7a0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fd7d8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fd810*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fd848*/ void ResetDragEvent();
}

class ClickEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.VoidDelegate>
{
    /*0x18*/ UIEventListener.VoidDelegate onClick;
    /*0x20*/ float clickInterval;
    /*0x24*/ float _lastClickTime;

    static /*0x25fd85c*/ IEventTrigger<UIEventListener.VoidDelegate> Get(UnityEngine.GameObject go);
    /*0x25fda9c*/ ClickEventTrigger();
    /*0x25fd91c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fd994*/ void AddListener(UIEventListener.VoidDelegate t);
    /*0x25fda14*/ void RemoveListener(UIEventListener.VoidDelegate t);
    /*0x25fda94*/ void RemoveListener();
}

class DoubleClickEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.IntDelegate>
{
    /*0x18*/ UIEventListener.IntDelegate onDoubleClick;
    /*0x20*/ float checkInterval;
    /*0x24*/ float _checkTime;

    static /*0x25fdab0*/ IEventTrigger<UIEventListener.IntDelegate> Get(UnityEngine.GameObject go);
    /*0x25fdd44*/ DoubleClickEventTrigger();
    /*0x25fdb70*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fdc08*/ void Update();
    /*0x25fdc3c*/ void AddListener(UIEventListener.IntDelegate t);
    /*0x25fdcbc*/ void RemoveListener(UIEventListener.IntDelegate t);
    /*0x25fdd3c*/ void RemoveListener();
}

class DragBeginEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.PointerEventDataDelegate>
{
    /*0x18*/ UIEventListener.PointerEventDataDelegate onDragBegin;

    static /*0x25fdd54*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> Get(UnityEngine.GameObject go);
    /*0x25fdf68*/ DragBeginEventTrigger();
    /*0x25fde14*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fde60*/ void AddListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fdee0*/ void RemoveListener();
    /*0x25fdee8*/ void RemoveListener(UIEventListener.PointerEventDataDelegate t);
}

class DragEndTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.PointerEventDataDelegate>
{
    /*0x18*/ UIEventListener.PointerEventDataDelegate onDragEnd;

    static /*0x25fdf70*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> Get(UnityEngine.GameObject go);
    /*0x25fe184*/ DragEndTrigger();
    /*0x25fe030*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fe07c*/ void AddListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fe0fc*/ void RemoveListener();
    /*0x25fe104*/ void RemoveListener(UIEventListener.PointerEventDataDelegate t);
}

class DragEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.PointerEventDataDelegate>
{
    /*0x18*/ UIEventListener.PointerEventDataDelegate onDrag;

    static /*0x25fe18c*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> Get(UnityEngine.GameObject go);
    /*0x25fe3a0*/ DragEventTrigger();
    /*0x25fe24c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fe298*/ void AddListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fe318*/ void RemoveListener();
    /*0x25fe320*/ void RemoveListener(UIEventListener.PointerEventDataDelegate t);
}

class EnterEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.PointerEventDataDelegate>
{
    /*0x18*/ UIEventListener.PointerEventDataDelegate onClick;

    static /*0x25fe3a8*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> Get(UnityEngine.GameObject go);
    /*0x25fe5bc*/ EnterEventTrigger();
    /*0x25fe468*/ void AddListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fe4e8*/ void RemoveListener();
    /*0x25fe4f0*/ void RemoveListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fe570*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
}

class LeaveEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IEventSystemHandler, IEventTrigger<UIEventListener.PointerEventDataDelegate>
{
    /*0x18*/ UIEventListener.PointerEventDataDelegate onClick;

    static /*0x25fe5c4*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> Get(UnityEngine.GameObject go);
    /*0x25fe7d8*/ LeaveEventTrigger();
    /*0x25fe684*/ void AddListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fe704*/ void RemoveListener();
    /*0x25fe70c*/ void RemoveListener(UIEventListener.PointerEventDataDelegate t);
    /*0x25fe78c*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
}

class LongClickEventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, IEventTrigger<UIEventListener.BoolDelegate>
{
    static float LongTime = 0.5;
    /*0x18*/ UIEventListener.BoolDelegate onClick;
    /*0x20*/ bool _isPress;
    /*0x24*/ float _timer;

    static /*0x25fe7e0*/ IEventTrigger<UIEventListener.BoolDelegate> Get(UnityEngine.GameObject go);
    /*0x25feaa0*/ LongClickEventTrigger();
    /*0x25fe8a0*/ void AddListener(UIEventListener.BoolDelegate t);
    /*0x25fe920*/ void RemoveListener();
    /*0x25fe928*/ void RemoveListener(UIEventListener.BoolDelegate t);
    /*0x25fe9a8*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fe9b8*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25fea24*/ void Update();
}

class UIEventListener
{
    static /*0x25feaa8*/ IEventTrigger<UIEventListener.VoidDelegate> OnClick(UnityEngine.GameObject go);
    static /*0x25feaac*/ IEventTrigger<UIEventListener.IntDelegate> OnDoubleClick(UnityEngine.GameObject go);
    static /*0x25feab0*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> OnDragBegin(UnityEngine.GameObject go);
    static /*0x25feab4*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> OnDrag(UnityEngine.GameObject go);
    static /*0x25feab8*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> OnDragEnd(UnityEngine.GameObject go);
    static /*0x25feabc*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> OnPointEnter(UnityEngine.GameObject go);
    static /*0x25feac0*/ IEventTrigger<UIEventListener.PointerEventDataDelegate> OnPointUp(UnityEngine.GameObject go);
    /*0x25feac4*/ UIEventListener();

    class VoidDelegate : System.MulticastDelegate
    {
        /*0x25feacc*/ VoidDelegate(object object, nint method);
        /*0x25feba0*/ void Invoke(UnityEngine.GameObject go);
        /*0x25febb4*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, System.AsyncCallback callback, object object);
        /*0x25febd4*/ void EndInvoke(System.IAsyncResult result);
    }

    class IntDelegate : System.MulticastDelegate
    {
        /*0x25febe0*/ IntDelegate(object object, nint method);
        /*0x25fecb8*/ void Invoke(UnityEngine.GameObject go, int value);
        /*0x25feccc*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, int value, System.AsyncCallback callback, object object);
        /*0x25fed60*/ void EndInvoke(System.IAsyncResult result);
    }

    class BoolDelegate : System.MulticastDelegate
    {
        /*0x25fed6c*/ BoolDelegate(object object, nint method);
        /*0x25fee44*/ void Invoke(UnityEngine.GameObject go, bool value);
        /*0x25fee5c*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, bool value, System.AsyncCallback callback, object object);
        /*0x25feef4*/ void EndInvoke(System.IAsyncResult result);
    }

    class PointerEventDataDelegate : System.MulticastDelegate
    {
        /*0x25fef00*/ PointerEventDataDelegate(object object, nint method);
        /*0x25fefd8*/ void Invoke(UnityEngine.GameObject go, UnityEngine.EventSystems.PointerEventData data);
        /*0x25fefec*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject go, UnityEngine.EventSystems.PointerEventData data, System.AsyncCallback callback, object object);
        /*0x25ff014*/ void EndInvoke(System.IAsyncResult result);
    }
}

interface IEventTrigger<T>
{
    void AddListener(T t);
    void RemoveListener();
    void RemoveListener(T t);
}

class ScrollRectParent : UnityEngine.UI.ScrollRect
{
    /*0x128*/ bool routeToParent;

    /*0x25ff4a8*/ ScrollRectParent();
    void DoForParents<T>(System.Action<T> action);
    /*0x25ff020*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25ff10c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25ff20c*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x25ff3a8*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);

    class <>c__DisplayClass2_0
    {
        /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

        /*0x25ff104*/ <>c__DisplayClass2_0();
        /*0x25ff4b0*/ void <OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent);
    }

    class <>c__DisplayClass3_0
    {
        /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

        /*0x25ff204*/ <>c__DisplayClass3_0();
        /*0x25ff558*/ void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent);
    }

    class <>c__DisplayClass4_0
    {
        /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

        /*0x25ff3a0*/ <>c__DisplayClass4_0();
        /*0x25ff600*/ void <OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent);
    }

    class <>c__DisplayClass5_0
    {
        /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

        /*0x25ff4a0*/ <>c__DisplayClass5_0();
        /*0x25ff6a8*/ void <OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent);
    }
}

class UIAnimCenter : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.List<UIAnimCenter.AnimValues> animCacheList;
    static /*0x8*/ System.Collections.Generic.List<UIAnimCenter.AnimValues> animList;
    static /*0x10*/ bool needUpdate;
    static /*0x18*/ UIAnimCenter instance;

    static /*0x2600d78*/ UIAnimCenter();
    static /*0x25ff750*/ UIAnimCenter CreateAnimCenter();
    static /*0x25ff7b8*/ void Clear();
    static /*0x25ff8b4*/ UIAnimCenter.AnimValues GetNewAnimValues(int instID, UnityEngine.Transform trans, CurveMethod method);
    static /*0x25ffc98*/ void StartAnim(int instID, UnityEngine.Transform trans, CurveMethod method, float duration, System.Action callback, bool isloop);
    static /*0x25fffc0*/ void StartAnim(int instID, UnityEngine.Transform trans, UnityEngine.Vector3 to, CurveMethod method, float duration, System.Action callback, bool isloop);
    static /*0x26000e8*/ void StartAnim(int instID, UnityEngine.Transform trans, UnityEngine.Vector3 from, UnityEngine.Vector3 to, CurveMethod method, float duration, System.Action callback, bool isloop);
    static /*0x2600210*/ void StartAnim(int instID, UnityEngine.Transform trans, float alphaForm, float alphaTo, CurveMethod method, float duration, System.Action callback, bool isloop);
    static /*0x2600310*/ void StopAnim(int instID);
    static /*0x2600434*/ void StopAnimByIndex(int index);
    static /*0x26009f4*/ void ResetAnim(int instID);
    static /*0x2600af4*/ void ResetAnimByIndex(int idx);
    /*0x2600d70*/ UIAnimCenter();
    /*0x2600724*/ void Update();

    class AnimValues
    {
        /*0x10*/ int instID;
        /*0x18*/ UnityEngine.Transform trans;
        /*0x20*/ float timer;
        /*0x24*/ float timerFactor;
        /*0x28*/ float duration;
        /*0x2c*/ bool isLoop;
        /*0x30*/ UnityEngine.Vector3 vFrom;
        /*0x3c*/ UnityEngine.Vector3 vTo;
        /*0x48*/ CurveMethod method;
        /*0x50*/ System.Action callback;
        /*0x58*/ UnityEngine.CanvasGroup group;
        /*0x60*/ float alphaFrom;
        /*0x64*/ float alphaTo;

        /*0x25ffc90*/ AnimValues();
        /*0x25ffe34*/ void StartAnim();
        /*0x2600870*/ bool UpdateAnim(float delta);
        /*0x26005c8*/ void StopAnim();
    }
}

enum CurveMethod
{
    Pos_Linear = 0,
    Pos_EaseIn = 1,
    Pos_EaseOut = 2,
    Pos_EaseInOut = 3,
    Pos_EaseOutElastic = 4,
    _Position_ = 5,
    Scale_Linear = 6,
    Scale_EastIn = 7,
    Scale_EastOut = 8,
    Scale_Appear = 9,
    Scale_ElasticAppear = 10,
    Scale_ElasticDisappear = 11,
    Scale_Jump = 12,
    Scale_Jump1 = 13,
    Scale_Breath = 14,
    Scale_Bounce = 15,
    _Scale_ = 16,
    Alpha_Linear = 17,
    Alpha_EaseIn = 18,
    Alpha_EaseOut = 19,
    Alpha_Breath = 20,
    _Alpha_ = 21,
}

class UIAnimCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool isLoop;
    /*0x1c*/ float timer;
    /*0x20*/ float timerFactor;
    /*0x24*/ float duration;
    /*0x28*/ UIAnimInfo animInfo;
    /*0x30*/ System.Action callBack;

    static /*0x26011c8*/ float UpdateFloat(float fromValue, float toValue, float factor, CurveMethod method);
    static /*0x2600e30*/ UnityEngine.Vector3 UpdateVector3(UnityEngine.Vector3 posFrom, UnityEngine.Vector3 posTo, float factor, CurveMethod method);
    static /*0x2600f60*/ UnityEngine.Vector3 UpdateScale(UnityEngine.Vector3 scaleFrom, UnityEngine.Vector3 scaleTo, float factor, CurveMethod method);
    /*0x26018c0*/ UIAnimCtrl();
    /*0x2601244*/ void PlayAnim(float time, System.Action callBack);
    /*0x2601424*/ void ClearAnim();
    /*0x26014cc*/ void PlayOver();
    /*0x26014e8*/ void Update();
}

class UIAnimInfo
{
    /*0x10*/ bool isWaitForLast;
    /*0x14*/ float delayTime;
    /*0x18*/ UnityEngine.Transform transTarget;
    /*0x20*/ UIAnimCtrl animCtrl;
    /*0x28*/ UIAnimType animType;
    /*0x30*/ string aniName;
    /*0x38*/ bool isLoop;
    /*0x3c*/ float animTime;
    /*0x40*/ float speed;
    /*0x48*/ string info;
    /*0x50*/ UnityEngine.CanvasGroup group;
    /*0x58*/ UnityEngine.Animation animation;
    /*0x60*/ bool isPlayOver;
    /*0x61*/ bool isPlaySingle;
    /*0x64*/ UnityEngine.Vector3 fromPos;
    /*0x70*/ UnityEngine.Vector3 toPos;
    /*0x7c*/ float m_alphaFade;
    /*0x80*/ UnityEngine.Vector3 m_constFromPos;
    /*0x8c*/ UnityEngine.Vector3 m_constToPos;

    /*0x2602dd8*/ UIAnimInfo();
    /*0x26018c8*/ float get_alphaFade();
    /*0x26018d0*/ void set_alphaFade(float value);
    /*0x26018e8*/ UnityEngine.Vector3 get_constFromPos();
    /*0x26018f4*/ void set_constFromPos(UnityEngine.Vector3 value);
    /*0x26019a4*/ UnityEngine.Vector3 get_constToPos();
    /*0x26019b0*/ void set_constToPos(UnityEngine.Vector3 value);
    /*0x2601a60*/ void InitAnim(bool isAutoPlay);
    /*0x26020fc*/ void PlayAnim(float time);
    /*0x2602a1c*/ void ResetAni(bool isForward, bool isAutoPlay);
    /*0x2602b4c*/ void ResetAni(float time, bool isAutoPlay);
    /*0x2602cc8*/ void SetAniSpeed(float speed);
    /*0x2602cd0*/ void Clear();
    /*0x2602dcc*/ void CallBack();
}

enum UIAnimType
{
    Animation = 0,
    LeftIn = 1,
    RightIn = 2,
    TopIn = 3,
    BottomIn = 4,
    PopUpWidth0_100 = 5,
    PopUpHeight0_100 = 6,
    PopUp0_100 = 7,
    PopUp100_120_100 = 8,
    PopUp100_104_100 = 9,
    BeatIn = 10,
    FadeIn = 11,
    FadeOut = 12,
    FadeBreath = 13,
    PosToPosFlat = 14,
    PopUp100_300 = 15,
    PopUpBounce = 16,
    PosToPosElastic = 20,
}

class UIAnimManager : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool isAutoPlay;
    /*0x20*/ System.Collections.Generic.List<UIAnimInfo> animSenquenceList;
    /*0x28*/ System.Action playOverCallBack;
    /*0x30*/ float startTime;
    /*0x34*/ float timer;
    /*0x38*/ int curIndex;
    /*0x3c*/ bool canUpdate;
    /*0x40*/ UIAnimInfo animInfo;
    /*0x48*/ UIAnimInfo lastAnimInfo;

    /*0x2603854*/ UIAnimManager();
    /*0x2602e6c*/ void BeginDrawListElement(int index);
    /*0x2602e70*/ void EndDrawListElement(int index);
    /*0x2602e74*/ void ChangeAnimSenquenceList();
    /*0x2602f34*/ void OnEnable();
    /*0x2602fa0*/ void OnDestroy();
    /*0x2603028*/ void Update();
    /*0x2602f44*/ void Play();
    /*0x2603374*/ void Play(int index, float time);
    /*0x26033ec*/ void InitAnim();
    /*0x2603560*/ void ResetAni(bool isForward, int index);
    /*0x26031b4*/ void ResetAni(float time, int index);
    /*0x2603710*/ System.Collections.IEnumerator PlayAniOnFramEnd();
    /*0x26037a0*/ void Stop();
    /*0x2603128*/ void SetSequenceAnimInfo(int index);
    /*0x26030ac*/ void UpdateAnim();
    /*0x26037d0*/ bool TryAnimPlay();

    class <PlayAniOnFramEnd>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UIAnimManager <>4__this;

        /*0x2603778*/ <PlayAniOnFramEnd>d__20(int <>1__state);
        /*0x260385c*/ void System.IDisposable.Dispose();
        /*0x2603860*/ bool MoveNext();
        /*0x26038b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x26038c0*/ void System.Collections.IEnumerator.Reset();
        /*0x2603900*/ object System.Collections.IEnumerator.get_Current();
    }
}

class DSDKAdInfo
{
    /*0x10*/ double revenueInUSD;
    /*0x18*/ string revenuePrecision;
    /*0x20*/ string countryCode;
    /*0x28*/ string networkName;
    /*0x30*/ string maxAdUnitId;
    /*0x38*/ string adFormat;
    /*0x40*/ string placement;
    /*0x48*/ string networkPlacement;
    /*0x50*/ string rewardLabel;
    /*0x58*/ int rewardAmount;

    /*0x2603908*/ DSDKAdInfo();
}

class DSDKOrderInfo
{
    /*0x10*/ string billNo;
    /*0x18*/ string orderId;
    /*0x20*/ string purchaseToken;
    /*0x28*/ DSDKProductInfo productInfo;

    /*0x2603910*/ DSDKOrderInfo();
}

class DSDKProductInfo
{
    /*0x10*/ string productId;
    /*0x18*/ ESDKProductType productType;
    /*0x20*/ string formatPriceStr;
    /*0x28*/ string priceCurrencyCode;
    /*0x30*/ double priceAmount;

    /*0x2603978*/ DSDKProductInfo();
}

class SDKConfig
{
    /*0x10*/ ESDKRunMode runMode;
    /*0x18*/ string unityObjName;
    /*0x20*/ string unityFuncName;
    /*0x28*/ bool enableLog;
    /*0x29*/ bool enableSdkConfirmOrder;
    /*0x30*/ string analyticsServerUrl;
    /*0x38*/ string analyticsAppId;
    /*0x40*/ string adjustFBAppId;
    /*0x48*/ string adjustAppToken;
    /*0x50*/ string adjustLoginEvtCode;
    /*0x58*/ string adjustIAPEvtCode;
    /*0x60*/ string adjustIAAEvtCode;
    /*0x68*/ bool disableAdjust;
    /*0x70*/ string accountGoogleWebClientId;
    /*0x78*/ string applovinAdId;

    /*0x2603980*/ SDKConfig();
}

enum ESDKAccountType
{
    Default = 0,
    Facebook = 1,
    Google = 2,
    Guest = 4,
    iOS = 8,
}

enum ESDKErrorCode
{
    Default = 0,
    Billing_Google_Service_Timeout = 100,
    Billing_Google_Feature_Not_Supported = 101,
    Billing_Google_Service_Disconnected = 102,
    Billing_Google_User_Canceled = 103,
    Billing_Google_Service_Unavailable = 104,
    Billing_Google_Billing_Unavailable = 105,
    Billing_Google_Item_Unavailable = 106,
    Billing_Google_Developer_Error = 107,
    Billing_Google_Error = 108,
    Billing_Google_Item_Already_Owned = 109,
    Billing_Google_Item_Not_Owned = 110,
    Billing_Google_Network_Error = 111,
    Ad_Ad_Not_Ready = 200,
}

enum ESDKLogLevel
{
    Verbose = 0,
    Debug = 1,
    Info = 2,
    Warn = 3,
    Error = 4,
}

enum ESDKPresetProperty
{
    String_Bundle_Id = 0,
    String_Carrier = 1,
    String_Device_Id = 2,
    String_Device_Model = 3,
    String_Manufacture = 4,
    String_Network_Type = 5,
    String_Os = 6,
    String_Os_Version = 7,
    Int_Screen_Height = 8,
    Int_Screen_Width = 9,
    String_System_Language = 10,
    Double_Zone_Offset = 11,
    String_App_Version = 12,
    String_Install_Time = 13,
    Boolean_Is_Simulator = 14,
    String_Ram = 15,
    String_Disk = 16,
    Int_Fps = 17,
    String_Device_Type = 18,
}

enum ESDKProductType
{
    Default = 0,
    SUBS = 1,
    INAPPConsumable = 2,
    INAPPNonConsumable = 3,
}

enum ESDKRunMode
{
    Debug = 0,
    Product = 1,
}

enum ESDKUnityMsg
{
    SDK2C_Base_Default = 0,
    SDK2C_Base_Log = 1,
    SDK2C_Billing_ConfirmPurchase = 100,
    SDK2C_Billing_ErrorCode = 101,
    SDK2C_Billing_StoreUnfinishedOrder = 102,
    SDK2C_Billing_DistributeRewards = 103,
    SDK2C_Billing_LaunchBillingFollow = 104,
    SDK2C_Billing_PurchaseSuccess = 105,
    SDK2C_Billing_PurchaseFail = 106,
    SDK2C_Billing_CheckOrders = 107,
    SDK2C_Billing_ProductDetails = 108,
    SDK2C_Billing_InnerError = 109,
    SDK2C_Billing_DisconnectGooglePlay = 110,
    SDK2C_Billing_ReceiveGooglePlayCountryCode = 111,
    SDK2C_Ad_ErrorCode = 200,
    SDK2C_Review_Complete = 300,
}

class ISDKAdListener : UnityEngine.AndroidJavaProxy
{
    /*0x20*/ System.Action<string> OnShowSuccess;
    /*0x28*/ System.Action<string> OnShowFail;

    /*0x2603988*/ ISDKAdListener();
    /*0x26039f8*/ void ShowSuccess(string adInfoJson);
    /*0x2603a14*/ void ShowFail(string maxAdUnitId);
}

class ISDKDynamicSuperPropertyGetter : UnityEngine.AndroidJavaProxy
{
    /*0x20*/ System.Func<string> OnGetPropertiesJson;

    /*0x2603a30*/ ISDKDynamicSuperPropertyGetter();
    /*0x2603aa0*/ string GetPropertiesJson();
}

class ISDKLoginListener : UnityEngine.AndroidJavaProxy
{
    /*0x20*/ System.Action<string, string> OnSuccess;
    /*0x28*/ System.Action OnCancel;
    /*0x30*/ System.Action<string> OnFail;

    /*0x2603ac0*/ ISDKLoginListener();
    /*0x2603b30*/ void Success(string userId, string token);
    /*0x2603b4c*/ void Cancel();
    /*0x2603b68*/ void Fail(string reason);
}

enum ESDKIOSMessageType
{
    FB_LOGIN_SUCC = 0,
    FB_LOGIN_FAIL = 1,
    FB_LOGIN_CANCEL = 2,
    IOS_LOGIN_SUCC = 3,
    IOS_LOGIN_FAIL = 4,
    IOS_LOGIN_CANCEL = 5,
    GUIDE_LOGIN_SUCC = 6,
    AD_SUCCESS = 7,
    AD_FAIL = 8,
    IAP_SERVER_VAILD = 9,
}

class IOSMsgTypeBase
{
    /*0x10*/ int sdk_msg_code;

    /*0x2603b84*/ IOSMsgTypeBase();
}

class FBLoginSuccMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string facebook_user_id;
    /*0x20*/ string facebook_token;

    /*0x2603b8c*/ FBLoginSuccMsg();
}

class FBLoginFailMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string facebook_login_error;

    /*0x2603b94*/ FBLoginFailMsg();
}

class FBLoginCancelMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string facebook_user_cancelled;

    /*0x2603b9c*/ FBLoginCancelMsg();
}

class IOSLoginSuccMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string iOS_user_id;
    /*0x20*/ string iOS_token;
    /*0x28*/ string iOS_code;

    /*0x2603ba4*/ IOSLoginSuccMsg();
}

class GuideLoginSuccMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string guide_user_id;

    /*0x2603bac*/ GuideLoginSuccMsg();
}

class ADSuccMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string ad_info_json;
    /*0x20*/ float ad_revenue;
    /*0x28*/ string ad_country_code;

    /*0x2603bb4*/ ADSuccMsg();
}

class ADFailMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string ad_unit_id;

    /*0x2603bbc*/ ADFailMsg();
}

class IAPServerVaildMsg
{
    /*0x10*/ int sdk_msg_code;
    /*0x18*/ string iap_transaction_id;
    /*0x20*/ string iap_product_id;
    /*0x28*/ string iap_bill_no;

    /*0x2603bc4*/ IAPServerVaildMsg();
}

class MSDKAdErrorCode
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ string errorDetail;
    /*0x20*/ ESDKErrorCode sdkErrorCode;

    /*0x2603bcc*/ MSDKAdErrorCode();
}

class MSDKBase
{
    /*0x10*/ ESDKUnityMsg msgType;

    /*0x2603bdc*/ MSDKBase();
}

class MSDKBillingDisconnectGooglePlay
{
    /*0x10*/ ESDKUnityMsg msg;

    /*0x2603be4*/ MSDKBillingDisconnectGooglePlay();
}

class MSDKBillingErrorCode
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ string errorDetail;
    /*0x20*/ int originalErrorCode;
    /*0x24*/ ESDKErrorCode sdkErrorCode;

    /*0x2603bf4*/ MSDKBillingErrorCode();
}

class MSDKBillingInnerError
{
    /*0x10*/ ESDKUnityMsg msg;

    /*0x2603c04*/ MSDKBillingInnerError();
}

class MSDKBillingReceiveGooglePlayCountryCode
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ string countryCode;

    /*0x2603c14*/ MSDKBillingReceiveGooglePlayCountryCode();
}

class MSDKFinishCheckOrders
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603c24*/ MSDKFinishCheckOrders();
}

class MSDKFinishConfirmPurchase
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603ca8*/ MSDKFinishConfirmPurchase();
}

class MSDKFinishLaunchBillingFollow
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603d2c*/ MSDKFinishLaunchBillingFollow();
}

class MSDKLog
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x14*/ ESDKLogLevel logLevel;
    /*0x18*/ string tag;
    /*0x20*/ string content;

    /*0x2603db0*/ MSDKLog();
}

class MSDKNotifyDistributeRewards
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603dc0*/ MSDKNotifyDistributeRewards();
}

class MSDKNotifyStoreUnfinishedOrders
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603e44*/ MSDKNotifyStoreUnfinishedOrders();
}

class MSDKProductDetails
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKProductInfo> productInfoList;

    /*0x2603ec8*/ MSDKProductDetails();
}

class MSDKPurchaseFail
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603f4c*/ MSDKPurchaseFail();
}

class MSDKPurchaseSuccess
{
    /*0x10*/ ESDKUnityMsg msg;
    /*0x18*/ System.Collections.Generic.List<DSDKOrderInfo> orderInfoList;

    /*0x2603fd0*/ MSDKPurchaseSuccess();
}

class MSDKReviewComplete
{
    /*0x10*/ ESDKUnityMsg msg;

    /*0x2604054*/ MSDKReviewComplete();
}

class SDKAPI
{
    static /*0x0*/ UnityEngine.AndroidJavaClass _androidAPI;
    static /*0x8*/ System.Action<string, string, UnityEngine.LogType> OnLog;
    static /*0x10*/ System.Action<object, System.UnhandledExceptionEventArgs> OnException;
    static /*0x18*/ bool _hasRegisteredException;
    static /*0x19*/ bool _enableTrackLogError;
    static /*0x1a*/ bool _enableTrackException;

    static /*0x2606ecc*/ SDKAPI();
    static /*0x2604064*/ void SetGamePlayerId(string playerId);
    static /*0x2604154*/ string GetDistinctId();
    static /*0x2604248*/ string GetUserId();
    static /*0x260433c*/ string GetToken();
    static /*0x2604430*/ ESDKAccountType GetCurrentAccountType();
    static /*0x2604524*/ void Logout();
    static /*0x2604600*/ void Login(ESDKAccountType accountType, ISDKLoginListener listener);
    static /*0x260474c*/ void ShowAd(ISDKAdListener listener);
    static /*0x260483c*/ string GetApplovinAdId();
    static /*0x2604930*/ string GetGAID();
    static /*0x2604a24*/ string GetAFID();
    static /*0x2604b18*/ void UserSetOnce(string propertiesJson);
    static /*0x2604c08*/ void UserSet(string propertiesJson);
    static /*0x2604cf8*/ void UserAdd(string propertiesJson);
    static /*0x2604de8*/ void SetDynamicSuperProperties(ISDKDynamicSuperPropertyGetter propertyGetter);
    static /*0x2604ed8*/ void Track(string evtName, string propertiesJson);
    static /*0x2605000*/ void TrackFirstEvent(string evtName, string propertiesJson);
    static /*0x2605128*/ void TrackException(string crashReason);
    static /*0x2605218*/ void TimeEvent(string evtName);
    static /*0x2605308*/ void CalibrateTime(long timeStamp);
    static /*0x2605420*/ void EnableAutoTrack();
    static /*0x26054fc*/ void Init(string cfgJson);
    static /*0x26055ec*/ double GetTimeZone();
    static /*0x2605754*/ string GetDeviceId();
    static /*0x2605848*/ string GetLocalRegion();
    static /*0x260593c*/ string GetPresetPropertyValue(ESDKPresetProperty propertyType);
    static /*0x2605a70*/ void LaunchReviewFlow();
    static /*0x2605b4c*/ void SendEmail(string receiverAddress);
    static /*0x2605c3c*/ void QueryProductDetails(string productInfoListJson);
    static /*0x2605d2c*/ void Purchase(string orderInfoJson);
    static /*0x2605e1c*/ void CheckOrders(string orderInfoJsonListJson);
    static /*0x2605f0c*/ void UpdateRecentPurchase();
    static /*0x2605fe8*/ string GetGooglePlayCountryCode();
    static /*0x26060dc*/ void SetAllowSDKConfirmOrder(bool allowSDKConfirmOrder);
    static /*0x26061f8*/ bool GetAllowSDKConfirmOrder();
    static /*0x26062ec*/ void InitException(bool enableTrackLogError, bool enableTrackException);
    static /*0x260649c*/ void Vibration();
    static /*0x26065b4*/ float GetRuntimeMemory();
    static /*0x2606358*/ void _RegisterException();
    static /*0x26066a8*/ void _LogHandler(string logString, string stackTrace, UnityEngine.LogType type);
    static /*0x2606a3c*/ void _UncaughtExceptionHandler(object sender, System.UnhandledExceptionEventArgs args);
    /*0x2606ec4*/ SDKAPI();
}

enum CSLogSeverity
{
    Log = 0,
    LogDebug = 1,
    LogInfo = 2,
    LogWarning = 3,
    LogAssert = 4,
    LogError = 5,
    LogException = 6,
}

class CrashSightAgent
{
    static /*0x0*/ string crashUploadUrl;
    static /*0x8*/ CrashSightAgent.LogCallbackDelegate _LogCallbackEventHandler;
    static /*0x10*/ bool _isInitialized;
    static /*0x14*/ CSLogSeverity _autoReportLogLevel;
    static /*0x18*/ bool _debugMode;
    static /*0x19*/ bool _autoQuitApplicationAfterReport;
    static /*0x1c*/ int EXCEPTION_TYPE_UNCAUGHT;
    static /*0x20*/ int EXCEPTION_TYPE_CAUGHT;
    static /*0x28*/ string _pluginVersion;
    static /*0x30*/ System.Func<System.Collections.Generic.Dictionary<string, string>> _LogCallbackExtrasHandler;
    static /*0x38*/ bool _uncaughtAutoReportOnce;

    static /*0x260bcf4*/ CrashSightAgent();
    static /*0x2606f5c*/ void ConfigCallbackType(int callbackType);
    static /*0x2606fb4*/ void ConfigCrashReporter(int type, int logLevel);
    static /*0x260700c*/ void RegisterCrashCallback(CrashSightCallback callback);
    static /*0x2607254*/ void UnregisterCrashCallback();
    static /*0x26072a4*/ void RegisterCrashLogCallback(CrashSightLogCallback callback);
    static /*0x260743c*/ void InitWithAppId(string appId);
    static /*0x26078b4*/ void InitContext(string userId, string version, string key);
    static /*0x2607b58*/ void EnableExceptionHandler();
    static /*0x2607ca4*/ void RegisterLogCallback(CrashSightAgent.LogCallbackDelegate handler);
    static /*0x2607e64*/ void SetLogCallbackExtrasHandler(System.Func<System.Collections.Generic.Dictionary<string, string>> handler);
    static /*0x2607f4c*/ void ReportException(System.Exception e, string message);
    static /*0x26086c0*/ void ReportException(string name, string message, string stackTrace);
    static /*0x2609290*/ void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, System.Collections.Generic.Dictionary<string, string> extInfo);
    static /*0x2609390*/ void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, System.Collections.Generic.Dictionary<string, string> extInfo, int dumpNativeType);
    static /*0x26094a4*/ void UnregisterLogCallback(CrashSightAgent.LogCallbackDelegate handler);
    static /*0x2609660*/ void SetUserId(string userId);
    static /*0x26097c8*/ void SetScene(int sceneId);
    static /*0x260994c*/ void AddSceneData(string key, string value);
    static /*0x2609ae4*/ void ConfigDebugMode(bool enable);
    static /*0x2609c44*/ void ConfigAutoQuitApplication(bool autoQuit);
    static /*0x2609ca0*/ void ConfigAutoReportLogLevel(CSLogSeverity level);
    static /*0x2609cf8*/ void ConfigDefault(string channel, string version, string user, long delay);
    static /*0x2609ecc*/ void ConfigCrashServerUrl(string crashServerUrl);
    static /*0x2609fd4*/ void SetAppVersion(string appVersion);
    static /*0x260a02c*/ void SetDeviceId(string deviceId);
    static /*0x260a084*/ void SetCustomizedDeviceID(string deviceId);
    static /*0x260a0dc*/ string GetSDKDefinedDeviceID();
    static /*0x260a12c*/ string GetSDKSessionID();
    static /*0x260a17c*/ void SetCustomizedMatchID(string matchId);
    static /*0x260a1d4*/ string GetCrashUuid();
    static /*0x260a224*/ void SetDeviceModel(string deviceModel);
    static /*0x260a27c*/ void SetLogPath(string logPath);
    static /*0x2607154*/ void DebugLog(string tag, string format, object[] args);
    static /*0x260a2d4*/ void PrintLog(CSLogSeverity level, string format, object[] args);
    static /*0x260a378*/ void ReRegistAllMonitors();
    static /*0x260a470*/ void ReportLogInfo(string msgType, string msg);
    static /*0x260a4d8*/ void SetCustomLogDir(string path);
    static /*0x2607d88*/ void add__LogCallbackEventHandler(CrashSightAgent.LogCallbackDelegate value);
    static /*0x2609584*/ void remove__LogCallbackEventHandler(CrashSightAgent.LogCallbackDelegate value);
    static /*0x260a530*/ string get_PluginVersion();
    static /*0x260a588*/ bool get_IsInitialized();
    static /*0x260a5e0*/ bool get_AutoQuitApplicationAfterReport();
    static /*0x2607674*/ void _RegisterExceptionHandler();
    static /*0x260a638*/ void _UnregisterExceptionHandler();
    static /*0x260a818*/ void _OnLogCallbackHandler(string condition, string stackTrace, UnityEngine.LogType type);
    static /*0x260a9b4*/ void _OnUncaughtExceptionHandler(object sender, System.UnhandledExceptionEventArgs args);
    static /*0x26080c0*/ void _HandleException(System.Exception e, string message, bool uncaught);
    static /*0x260ac18*/ void _reportException(bool uncaught, string name, string reason, string stackTrace);
    static /*0x2608868*/ void _HandleException(CSLogSeverity logLevel, string name, string message, string stackTrace, bool uncaught);
    static /*0x260b66c*/ void TestOomCrash();
    static /*0x260b7b8*/ void TestJavaCrash();
    static /*0x260b904*/ void TestOcCrash();
    static /*0x260ba50*/ void TestNativeCrash();
    static /*0x260bb9c*/ long GetCrashThreadId();
    /*0x260bcec*/ CrashSightAgent();

    class LogCallbackDelegate : System.MulticastDelegate
    {
        /*0x260bda0*/ LogCallbackDelegate(object object, nint method);
        /*0x260be78*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
        /*0x260be8c*/ System.IAsyncResult BeginInvoke(string condition, string stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, object object);
        /*0x260bf24*/ void EndInvoke(System.IAsyncResult result);
    }
}

class CrashSightCallback
{
    /*0x260bf30*/ CrashSightCallback();
    string OnCrashBaseRetEvent(int methodId, int crashType);
}

class CrashSightLogCallback
{
    /*0x260bf38*/ CrashSightLogCallback();
    string OnSetLogPathEvent(int methodId, int crashType);
    void OnLogUploadResultEvent(int methodId, int crashType, int result);
}

interface ISDKTrace
{
    void Init();
    void UpdateStart();
    void VersionCheck();
    void UpdateEnd();
    void InitializationStart();
    void InitializationEnd();
    void EnterLoginStatus();
}

class SDKTraceAndroid : SDKTraceBase
{
    static string PROP_PLAYER_LEVEL = "player_level";
    static string PROP_ENERGY = "energy";
    static string PROP_MAX_NORMAL_CHAPTER_ID = "max_normalChapter_id";
    static string PROP_MAX_EXPEDITION_ID = "max_expedition_id";
    static string PROP_MAX_HARD_CHAPTER_ID = "max_hardChapter_id";
    static string PROP_BATTLE_PASS = "battlepass";
    static string PROP_END_POINT = "end_point";

    static /*0x260c648*/ string OnGetPropertiesJson();
    static /*0x260c20c*/ void UserSetOnce_InstallTime();
    /*0x260c900*/ SDKTraceAndroid();
    /*0x260bf40*/ void Init();
    /*0x260c3d8*/ void VersionCheck();
    /*0x260c440*/ void UpdateStart();
    /*0x260c4a8*/ void UpdateEnd();
    /*0x260c510*/ void InitializationStart();
    /*0x260c578*/ void InitializationEnd();
    /*0x260c5e0*/ void EnterLoginStatus();
}

class SDKJenkinsSetting
{
    /*0x10*/ string ReportAddr;
    /*0x18*/ bool IsDebugMode;
    /*0x19*/ bool DisableAdjust;
    /*0x20*/ string ReportAppId;

    /*0x260c910*/ SDKJenkinsSetting();
}

class SDKTrace
{
    static /*0x0*/ ISDKTrace mSDKTrace;

    static /*0x260c918*/ void Init();
    static /*0x260caf0*/ void VersionCheck();
    static /*0x260cbb4*/ void UpdateStart();
    static /*0x260cc78*/ void UpdateEnd();
    static /*0x260cd3c*/ void InitializationStart();
    static /*0x260ce00*/ void InitializationEnd();
    static /*0x260cec4*/ void EnterLoginStatus();
    /*0x260cf88*/ SDKTrace();
}

class SDKTraceEditor : ISDKTrace
{
    /*0x260cae8*/ SDKTraceEditor();
    /*0x260cf90*/ void Init();
    /*0x260cf94*/ void UpdateStart();
    /*0x260cf98*/ void VersionCheck();
    /*0x260cf9c*/ void UpdateEnd();
    /*0x260cfa0*/ void InitializationStart();
    /*0x260cfa4*/ void InitializationEnd();
    /*0x260cfa8*/ void EnterLoginStatus();
}

class SDKTraceBase : ISDKTrace
{
    /*0x260c908*/ SDKTraceBase();
    /*0x260cfac*/ void Init();
    /*0x260cfb0*/ void UpdateStart();
    /*0x260cfb4*/ void VersionCheck();
    /*0x260cfb8*/ void UpdateEnd();
    /*0x260cfbc*/ void InitializationStart();
    /*0x260cfc0*/ void InitializationEnd();
    /*0x260cfc4*/ void EnterLoginStatus();
}

class GameConfig
{
    /*0x10*/ System.Collections.Generic.Dictionary<string, Framework.Variable> configDict;

    /*0x260f1dc*/ GameConfig();
    /*0x260cfc8*/ long get_buildTime();
    /*0x260d030*/ void ReadBuild(string text);
    /*0x260d1ec*/ void AddConfig(string configName, object configValue);
    /*0x260d300*/ void AddConfig(string configName, int configValue);
    /*0x260d094*/ void AddConfig(string configName, long configValue);
    /*0x260d458*/ void AddConfig(string configName, string configValue);
    /*0x260d56c*/ void AddConfig(string configName, bool configValue);
    /*0x260d6c8*/ void AddConfig(string configName, float configValue);
    /*0x260d828*/ void AddConfig(string configName, UnityEngine.Vector3 configValue);
    void AddConfig<T>(string configName, System.Collections.Generic.List<T> configValue);
    T GetConfig<T>(string configName);
    T GetConfig<T>(string configName, T defaultValue);
    /*0x260d9a0*/ bool HasConfig(string configName);
    /*0x260d9f8*/ string get_defaultLanguage();
    /*0x260da78*/ System.Collections.Generic.List<string> get_languageNameList();
    /*0x260dae0*/ System.Collections.Generic.Dictionary<string, LanguageConfig> get_languageDict();
    /*0x260db48*/ System.Collections.Generic.Dictionary<string, UnityEngine.SystemLanguage> get_languageShortNameDict();
    /*0x260dbb0*/ string get_region();
    /*0x260dc18*/ System.Collections.Generic.List<string> get_regionList();
    /*0x260dc80*/ string GetLanguageShortName(UnityEngine.SystemLanguage lang);
    /*0x260dd48*/ UnityEngine.SystemLanguage GetLanguageName(string shortName);
    /*0x260dde4*/ void ReadLanguage(string text);
    /*0x260e5ec*/ int get_appVersion();
    /*0x260e654*/ int get_channel();
    /*0x260e6bc*/ int get_resVersion();
    /*0x260e724*/ string get_centerServerAddress();
    /*0x260e78c*/ bool get_isReleaseCenterServer();
    /*0x260e7f4*/ bool get_isRelease();
    /*0x260e85c*/ bool get_chargeDirect();
    /*0x260e8c4*/ bool get_selectServer();
    /*0x260e92c*/ bool get_checkResUpdate();
    /*0x260ca80*/ bool get_useSDK();
    /*0x260e994*/ bool get_useGM();
    /*0x260e9fc*/ void ReadVersion(string text);
}

class LanguageConfig
{
    /*0x10*/ string name;
    /*0x18*/ string font;
    /*0x20*/ string setName;
    /*0x28*/ string shortName;

    /*0x260f258*/ LanguageConfig();
}

class AnimEvent : UnityEngine.MonoBehaviour
{
    /*0x260f264*/ AnimEvent();
    /*0x260f260*/ void Attack();
}

class ContentSizeFitterExtend : UnityEngine.UI.ContentSizeFitter
{
    /*0x30*/ TMPro.TextMeshProUGUI mTxt;
    /*0x38*/ string mContent;
    /*0x40*/ bool mHasChanged;
    /*0x48*/ UnityEngine.Coroutine mCoroutine;

    /*0x260f41c*/ ContentSizeFitterExtend();
    /*0x260f26c*/ void Awake();
    /*0x260f2c8*/ void Update();
    /*0x260f35c*/ System.Collections.IEnumerator RebuildLayout();
    /*0x260f3ec*/ void OnDestroy();

    class <RebuildLayout>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ContentSizeFitterExtend <>4__this;

        /*0x260f3c4*/ <RebuildLayout>d__6(int <>1__state);
        /*0x260f424*/ void System.IDisposable.Dispose();
        /*0x260f428*/ bool MoveNext();
        /*0x260f55c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x260f564*/ void System.Collections.IEnumerator.Reset();
        /*0x260f5a4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class MoveCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Vector3 dir;
    /*0x24*/ UnityEngine.Vector3 startPos;
    /*0x30*/ UnityEngine.Vector3 endPos;
    /*0x3c*/ float duration;
    /*0x40*/ float speed;
    /*0x44*/ bool isMove;
    /*0x48*/ System.Action onDone;
    /*0x50*/ System.Action<UnityEngine.GameObject, float> onRun;
    /*0x58*/ float delay;
    /*0x60*/ UnityEngine.GameObject goRes;

    static /*0x260f79c*/ MoveCtrl PlayMove(UnityEngine.GameObject go, UnityEngine.Vector3 startPos, UnityEngine.Vector3 endPos, float duration, float delay, System.Action onDone, System.Action<UnityEngine.GameObject, float> onRun);
    /*0x260fce0*/ MoveCtrl();
    /*0x260f5ac*/ void _PlayMove(UnityEngine.GameObject go, UnityEngine.Vector3 startPos, UnityEngine.Vector3 endPos, float duration, float delay, System.Action onDone, System.Action<UnityEngine.GameObject, float> onRun);
    /*0x260f6a4*/ void Active();
    /*0x260f8e4*/ void FixedUpdate();
    /*0x260f69c*/ void CleanData();
    /*0x260fc14*/ void OnDone();
}

class NumberCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ double startNum;
    /*0x20*/ double curNum;
    /*0x28*/ double endNum;
    /*0x30*/ float duration;
    /*0x34*/ bool isNumChange;
    /*0x38*/ System.Action onDone;
    /*0x40*/ System.Action<double> onRun;
    /*0x48*/ float delay;

    static /*0x260fd24*/ NumberCtrl PlayNumChange(UnityEngine.GameObject go, double startNum, double endNum, float duration, float delay, System.Action onDone, System.Action<double> onRun);
    /*0x2610038*/ NumberCtrl();
    /*0x260fce8*/ void _PlayNumChange(double startNum, double endNum, float duration, float delay, System.Action onDone, System.Action<double> onRun);
    /*0x260fd10*/ void Active();
    /*0x260fe34*/ void FixedUpdate();
    /*0x260fd08*/ void CleanData();
    /*0x260fff8*/ void OnDone();
}

class SafeDestroyCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool isRun;
    /*0x1c*/ float duration;
    /*0x20*/ float timer;

    /*0x2610138*/ SafeDestroyCtrl();
    /*0x2610040*/ void StartRun(float duration);
    /*0x2610050*/ void Update();
}

class TailorParticle : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.Material> materials;
    /*0x20*/ UnityEngine.UI.Mask mask;
    /*0x28*/ UnityEngine.UI.RectMask2D rectmask2d;
    /*0x30*/ bool isMask;
    /*0x38*/ UnityEngine.Vector3[] corners;
    /*0x40*/ UnityEngine.Vector3[] cornerstemp;

    /*0x26106f8*/ TailorParticle();
    /*0x2610140*/ void Start();
    /*0x26103b0*/ void SetClip();
    /*0x26107a8*/ void <Start>b__3_0(UnityEngine.Vector2 v);
}

class TweenInt32 : UITweener
{
    /*0x70*/ float from;
    /*0x74*/ float to;
    /*0x78*/ float value;

    static /*0x26107cc*/ TweenInt32 Begin(UnityEngine.GameObject go, float duration, float to);
    /*0x2610890*/ TweenInt32();
    /*0x26107ac*/ void OnUpdate(float factor, bool isFinished);
    /*0x2610878*/ void SetStartToCurrentValue();
    /*0x2610884*/ void SetEndToCurrentValue();
}

class TweenOrthoSize : UITweener
{
    /*0x70*/ float from;
    /*0x74*/ float to;
    /*0x78*/ UnityEngine.Camera mCam;

    static /*0x2610998*/ TweenOrthoSize Begin(UnityEngine.GameObject go, float duration, float to);
    /*0x2610a70*/ TweenOrthoSize();
    /*0x26108a0*/ UnityEngine.Camera get_cachedCamera();
    /*0x2610934*/ float get_value();
    /*0x2610950*/ void set_value(float value);
    /*0x261097c*/ void OnUpdate(float factor, bool isFinished);
    /*0x2610a40*/ void SetStartToCurrentValue();
    /*0x2610a58*/ void SetEndToCurrentValue();
}

class TweenPosition : UITweener
{
    /*0x70*/ UnityEngine.Vector3 from;
    /*0x7c*/ UnityEngine.Vector3 to;
    /*0x88*/ bool worldSpace;
    /*0x90*/ UnityEngine.Transform mTrans;

    static /*0x2610bc0*/ TweenPosition Begin(UnityEngine.GameObject go, float duration, UnityEngine.Vector3 pos);
    static /*0x2610c80*/ TweenPosition Begin(UnityEngine.GameObject go, float duration, UnityEngine.Vector3 pos, float delay);
    static /*0x2610d4c*/ TweenPosition Begin(UnityEngine.GameObject go, float duration, UnityEngine.Vector3 pos, bool worldSpace);
    /*0x2610e58*/ TweenPosition();
    /*0x2610a80*/ UnityEngine.Transform get_cachedTransform();
    /*0x2610b00*/ UnityEngine.Vector3 get_value();
    /*0x2610b2c*/ void set_value(UnityEngine.Vector3 value);
    /*0x2610b88*/ void OnUpdate(float factor, bool isFinished);
    /*0x2610e20*/ void SetStartToCurrentValue();
    /*0x2610e3c*/ void SetEndToCurrentValue();
}

class TweenRotation : UITweener
{
    /*0x70*/ UnityEngine.Vector3 from;
    /*0x7c*/ UnityEngine.Vector3 to;
    /*0x88*/ bool quaternionLerp;
    /*0x90*/ UnityEngine.Transform mTrans;

    static /*0x261106c*/ TweenRotation Begin(UnityEngine.GameObject go, float duration, UnityEngine.Quaternion rot);
    /*0x261120c*/ TweenRotation();
    /*0x2610e60*/ UnityEngine.Transform get_cachedTransform();
    /*0x2610ee0*/ UnityEngine.Quaternion get_value();
    /*0x2610efc*/ void set_value(UnityEngine.Quaternion value);
    /*0x2610f48*/ void OnUpdate(float factor, bool isFinished);
    /*0x261118c*/ void SetStartToCurrentValue();
    /*0x26111cc*/ void SetEndToCurrentValue();
}

class TweenScale : UITweener
{
    /*0x70*/ UnityEngine.Vector3 from;
    /*0x7c*/ UnityEngine.Vector3 to;
    /*0x88*/ UnityEngine.Transform mTrans;

    static /*0x261132c*/ TweenScale Begin(UnityEngine.GameObject go, float duration, UnityEngine.Vector3 scale);
    /*0x2611424*/ TweenScale();
    /*0x2611214*/ UnityEngine.Transform get_cachedTransform();
    /*0x2611294*/ UnityEngine.Vector3 get_value();
    /*0x26112b0*/ void set_value(UnityEngine.Vector3 value);
    /*0x26112f4*/ void OnUpdate(float factor, bool isFinished);
    /*0x26113ec*/ void SetStartToCurrentValue();
    /*0x2611408*/ void SetEndToCurrentValue();
}

class UI3DSpriteCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ EmImageType type;
    /*0x1c*/ int id;
    /*0x20*/ System.Action OnLoadDone;
    /*0x28*/ string spriteName;
    /*0x30*/ bool isStarted;
    /*0x38*/ System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> spriteDict;
    /*0x40*/ UnityEngine.SpriteRenderer _image;
    /*0x48*/ UnityEngine.Material _material;

    /*0x2611da0*/ UI3DSpriteCtrl();
    /*0x2611498*/ UnityEngine.SpriteRenderer get_cacheImage();
    /*0x261152c*/ void Awake();
    /*0x2611534*/ void Start();
    /*0x2611758*/ void SetSpriteId(uint id);
    /*0x26119c0*/ void SetSpriteName(string name);
    /*0x261154c*/ void SetSprite();
    /*0x2611a1c*/ string GetSpriteName();
    /*0x2611a24*/ void LoadSpriteDone(string path, UnityEngine.Object obj);
}

enum EmImageType
{
    None = 0,
    Icon = 1,
    SLGIcon = 2,
}

class UIImageCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ EmImageType imageType;
    /*0x1c*/ int ImageID;
    /*0x20*/ UnityEngine.UI.Image _uiSprite;
    /*0x28*/ UISpriteCtrl _spriteCtrl;

    /*0x26126e4*/ UIImageCtrl();
    /*0x2611e28*/ UnityEngine.UI.Image get_uiSprite();
    /*0x2611f2c*/ void set_uiSprite(UnityEngine.UI.Image value);
    /*0x2611f34*/ UISpriteCtrl get_spriteCtrl();
    /*0x2612010*/ void SetImage(uint p_nImageID);
    /*0x2612310*/ void SetImage(int p_nImageID);
    /*0x26122b4*/ void HideImage();
    /*0x2612314*/ void SetGray(bool toGray);
    /*0x26124e8*/ void SetFlow(bool toFlow);
    /*0x2612210*/ void SetSprite(string name);
}

class UISpriteCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool hasDestroy;
    /*0x20*/ System.Action OnLoadDone;
    /*0x28*/ string spriteName;
    /*0x30*/ bool perfectSpirte;
    /*0x31*/ bool isGray;
    /*0x32*/ bool isFlow;
    /*0x33*/ bool isStarted;
    /*0x38*/ System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> spriteDict;
    /*0x40*/ UnityEngine.UI.Image _image;
    /*0x48*/ UnityEngine.Material _material;

    /*0x26131e4*/ UISpriteCtrl();
    /*0x26126f8*/ UnityEngine.UI.Image get_cacheImage();
    /*0x261278c*/ void Awake();
    /*0x2612794*/ void Start();
    /*0x26129dc*/ void OnDestroy();
    /*0x2612688*/ void SetSpriteName(string name);
    /*0x26127d4*/ void SetSprite();
    /*0x2612a8c*/ string GetSpriteName();
    /*0x2612a94*/ void LoadSpriteDone(string path, UnityEngine.Object obj);
    /*0x2612e18*/ void LoadMaterialDone(string path, UnityEngine.Object obj);
    /*0x2612368*/ void SetGray(bool toGray);
    /*0x2612508*/ void SetFlow(bool toFlow);
    /*0x26129e8*/ void SetPerfect();
}

class TextureData
{
    /*0x10*/ string textureName;
    /*0x18*/ float x;
    /*0x1c*/ float y;
    /*0x20*/ float w;
    /*0x24*/ float h;

    /*0x2613260*/ TextureData();
}

class UITextureCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ int textureID;
    /*0x1c*/ bool isShowOnStart;
    /*0x1d*/ bool perfectSize;
    /*0x1e*/ bool localTexture;
    /*0x1f*/ bool isStarted;
    /*0x20*/ TextureData _texdata;
    /*0x28*/ string _texName;
    /*0x30*/ UnityEngine.UI.RawImage _uiTexture;
    /*0x38*/ System.Action OnLoad;

    /*0x261394c*/ UITextureCtrl();
    /*0x2613268*/ UnityEngine.UI.RawImage get_uiTexture();
    /*0x261336c*/ void Awake();
    /*0x2613374*/ void Start();
    /*0x2613398*/ void SetTexture(int textureID);
    /*0x2613598*/ void SetTexture(string texName, TextureData textureData);
    /*0x2613840*/ void LoadTextureOver(string bundleName, UnityEngine.Object tex);
    /*0x26136b8*/ void SetTextureInfo(UnityEngine.Texture texture);
    /*0x2613940*/ void ReleaseTexture();
}

enum Direction
{
    Reverse = -1,
    Toggle = 0,
    Forward = 1,
}

class UITweener : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UITweener current;
    /*0x18*/ UITweener.Method method;
    /*0x1c*/ UITweener.Style style;
    /*0x20*/ UnityEngine.AnimationCurve animationCurve;
    /*0x28*/ bool ignoreTimeScale;
    /*0x2c*/ float delay;
    /*0x30*/ float duration;
    /*0x34*/ bool steeperCurves;
    /*0x38*/ int tweenGroup;
    /*0x3c*/ bool useFixedUpdate;
    /*0x40*/ System.Action onFinished;
    /*0x48*/ UnityEngine.GameObject eventReceiver;
    /*0x50*/ string callWhenFinished;
    /*0x58*/ float timeScale;
    /*0x5c*/ bool mStarted;
    /*0x60*/ float mStartTime;
    /*0x64*/ float mDuration;
    /*0x68*/ float mAmountPerDelta;
    /*0x6c*/ float mFactor;

    static T Begin<T>(UnityEngine.GameObject go, float duration, float delay);
    /*0x2614164*/ UITweener();
    /*0x2613954*/ float get_amountPerDelta();
    /*0x26139ac*/ float get_tweenFactor();
    /*0x26139b4*/ void set_tweenFactor(float value);
    /*0x26139d0*/ Direction get_direction();
    /*0x2613a34*/ void Reset();
    /*0x2613a6c*/ void Start();
    /*0x2613d60*/ void Update();
    /*0x2613d70*/ void FixedUpdate();
    /*0x2613a70*/ void DoUpdate();
    /*0x2613ee4*/ void OnDisable();
    /*0x2613d80*/ void Sample(float factor, bool isFinished);
    /*0x2613eec*/ float BounceLogic(float val);
    /*0x2613fa4*/ void Play();
    /*0x2613fb4*/ void PlayForward();
    /*0x2613fc4*/ void PlayReverse();
    /*0x2613fd4*/ void Play(bool forward);
    /*0x2614074*/ void ResetToBeginning();
    /*0x26140e4*/ void Toggle();
    void OnUpdate(float factor, bool isFinished);
    /*0x261415c*/ void SetStartToCurrentValue();
    /*0x2614160*/ void SetEndToCurrentValue();

    enum Method
    {
        Linear = 0,
        EaseIn = 1,
        EaseOut = 2,
        EaseInOut = 3,
        BounceIn = 4,
        BounceOut = 5,
        InQuad = 6,
        OutQuad = 7,
    }

    enum Style
    {
        Once = 0,
        Loop = 1,
        PingPong = 2,
    }
}

class AnimationCurveCtrl : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.AnimationCurve> animationCurve;

    /*0x26142c8*/ AnimationCurveCtrl();
}

enum BattlePlatformType
{
    None = 0,
    LeftRightMove = 1,
    UPDownMove = 2,
    ClockwiseRot = 3,
    AnticlockwiseRot = 4,
}

class BattlePlatformConfig : UnityEngine.MonoBehaviour
{
    /*0x18*/ BattlePlatformType battlePlatformType;
    /*0x1c*/ float minX;
    /*0x20*/ float maxX;
    /*0x24*/ float minY;
    /*0x28*/ float maxY;
    /*0x2c*/ float waitTime;
    /*0x30*/ float speed;

    /*0x2614344*/ BattlePlatformConfig();
}

class FogEntity : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool Hide;
    /*0x20*/ UnityEngine.SpriteRenderer _sprite;
    /*0x28*/ UnityEngine.Animation _animation;

    /*0x261462c*/ FogEntity();
    /*0x2614360*/ UnityEngine.SpriteRenderer get_sprite();
    /*0x26143f4*/ UnityEngine.Animation get_animation();
    /*0x2614488*/ void Init();
    /*0x26144b4*/ void SetColor(UnityEngine.Color color);
    /*0x2614500*/ void SetSelect(bool isSelected);
    /*0x26145b8*/ void Unlock();
    /*0x2614628*/ void Update();
}

class FogGroup : UnityEngine.MonoBehaviour
{
    /*0x18*/ int FogID;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.Transform> children;
    /*0x28*/ System.Collections.Generic.List<UnityEngine.SpriteRenderer> sprites;
    /*0x30*/ TMPro.TextMeshPro costText;
    /*0x38*/ bool canShowUnlock;
    /*0x39*/ bool delayHide;
    /*0x3c*/ float timer;
    /*0x40*/ bool unlocking;

    /*0x2614a30*/ FogGroup();
    /*0x2614634*/ void Start();
    /*0x26146d4*/ void Hide();
    /*0x261486c*/ void Show();
    /*0x26149c8*/ bool get_IsUnlocking();
    /*0x26149d0*/ void Update();
    /*0x2614af0*/ void <Start>b__5_0(UnityEngine.Transform x);
}

class SLGFogs : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform CellRoot;
    /*0x20*/ UnityEngine.Transform GroupRoot;
    /*0x28*/ bool EditGrid;
    /*0x2c*/ UnityEngine.Vector2Int GridSize;
    /*0x34*/ UnityEngine.Vector2 CellSize;
    /*0x3c*/ float yOffsetBasedX;
    /*0x40*/ float xOffsetBasedY;

    /*0x2614bc0*/ SLGFogs();
}

class GestureAreaCtrl : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler
{
    /*0x18*/ UnityEngine.EventSystems.EventSystem eventSystem;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.Vector2> touchPoints;
    /*0x28*/ bool isDrawing;
    /*0x29*/ bool canThrough;
    /*0x30*/ System.Action OnDrawCircle;
    /*0x38*/ float CircleTolerance;

    /*0x2615498*/ GestureAreaCtrl();
    /*0x2614bdc*/ void Start();
    /*0x2614c38*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x2614e14*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x2614ed0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x2614f88*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x2615008*/ bool IsCircle(System.Collections.Generic.List<UnityEngine.Vector2> points);
    /*0x26152f4*/ UnityEngine.Vector2 GetCenter(System.Collections.Generic.List<UnityEngine.Vector2> points);
}

class LinerScroll : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.LineRenderer _lr;
    /*0x20*/ float _distance;
    /*0x24*/ float textureLengthScale;
    /*0x28*/ float textureScrollSpeed;
    /*0x30*/ UnityEngine.Material _material;

    /*0x2615808*/ LinerScroll();
    /*0x2615528*/ void Start();
    /*0x2615578*/ void Update();
    /*0x26157ac*/ void OnDestroy();
}

class UI3DDisplay : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler
{
    /*0x18*/ int m_RenderTextureDepthBuffer;
    /*0x20*/ UnityEngine.GameObject m_ShowObject;
    /*0x28*/ UnityEngine.UI.RawImage m_ShowImage;
    /*0x30*/ UnityEngine.Camera m_ShowCamera;
    /*0x38*/ UnityEngine.Vector3 m_ShowCameraDefPos;
    /*0x48*/ UI3DDisplayCamera m_ShowCameraCtrl;
    /*0x50*/ UnityEngine.Transform m_FitScaleRoot;
    /*0x58*/ int m_ResolutionX;
    /*0x5c*/ int m_ResolutionY;
    /*0x60*/ int m_ShowLayer;
    /*0x64*/ UnityEngine.Vector3 m_ShowOffset;
    /*0x70*/ UnityEngine.Vector3 m_ShowRotation;
    /*0x7c*/ UnityEngine.Vector3 m_ShowScale;
    /*0x88*/ bool m_CanDrag;
    /*0x8c*/ float m_DragSpeed;
    /*0x90*/ float m_DragRotation;
    /*0x98*/ UnityEngine.RenderTexture m_ShowTexture;
    /*0xa0*/ UnityEngine.Vector3 m_ShowPosition;
    /*0xac*/ float m_OrthographicSize;
    /*0xb0*/ UnityEngine.Vector3 m_ModelGlobalOffset;
    /*0xc0*/ UnityEngine.Camera m_UICamera;
    /*0xc8*/ System.Action<UnityEngine.GameObject> m_RecycleLastAction;
    /*0xd0*/ UnityEngine.Vector2 m_OnClickOffset;
    /*0xd8*/ UnityEngine.Vector2 m_OnClickDownPos;
    /*0xe0*/ UnityEngine.RaycastHit2D m_ClickRaycastHit;
    /*0x108*/ System.Action<UnityEngine.GameObject, UnityEngine.GameObject> m_OnClickEvent;
    /*0x110*/ UnityEngine.GameObject m_DragTarge;

    /*0x2617bbc*/ UI3DDisplay();
    /*0x2615824*/ UnityEngine.Camera get_UICamera();
    /*0x26158dc*/ void Awake();
    /*0x2615bcc*/ void Start();
    /*0x2615d20*/ void OnEnable();
    /*0x2615e70*/ void OnDisable();
    /*0x2615f94*/ void OnDestroy();
    /*0x2616194*/ void Update();
    /*0x26161f0*/ void SetAnimatorCullingMode(UnityEngine.Transform target);
    /*0x261629c*/ void SetAllAnimatorCullingMode(UnityEngine.Transform target);
    /*0x2616308*/ void RecycleLastShow(UnityEngine.GameObject lastShowObject);
    /*0x26163b8*/ void UpdateShowObject(UnityEngine.GameObject showObject);
    /*0x2616950*/ void UpdateLookCamera();
    /*0x2616a30*/ void SetTemporaryRenderTexture();
    /*0x2616af8*/ void AddClickEvent(System.Action<UnityEngine.GameObject, UnityEngine.GameObject> action);
    /*0x2616ba0*/ void RemoveClickEvent(System.Action<UnityEngine.GameObject, UnityEngine.GameObject> action);
    /*0x2616c48*/ bool Raycast(UnityEngine.Vector2 screenPoint, ref UnityEngine.RaycastHit2D hitInfo);
    /*0x2616e90*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x2617090*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x26170b4*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x26171e0*/ bool ClickSucceed(UnityEngine.Vector2 upPos);
    /*0x261728c*/ void AddRecycleLastAction(System.Action<UnityEngine.GameObject> action);
    /*0x2617334*/ void RemoveRecycleLastAction(System.Action<UnityEngine.GameObject> action);
    /*0x2615c48*/ void Show(UnityEngine.GameObject showObject);
    /*0x26173dc*/ void ClearShow();
    /*0x2617468*/ void ResetRotation();
    /*0x2617634*/ void SetRotation(UnityEngine.Vector3 rotation);
    /*0x2617810*/ void SetOffset(UnityEngine.Vector3 offset);
    /*0x2617900*/ void SetScale(UnityEngine.Vector3 scale);
    /*0x26179c4*/ void ChangeResolution(UnityEngine.Vector2 newResolution);
}

class UI3DDisplayCamera : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject m_ShowObject;
    /*0x20*/ int m_ShowLayer;

    /*0x2618210*/ UI3DDisplayCamera();
    /*0x2617ca0*/ UnityEngine.GameObject get_ShowObject();
    /*0x261608c*/ void set_ShowObject(UnityEngine.GameObject value);
    /*0x26180ec*/ int get_ShowLayer();
    /*0x26168ac*/ void set_ShowLayer(int value);
    /*0x2617ca8*/ void ResetRenderer(UnityEngine.Transform transform);
    /*0x2617ea0*/ void SetupRenderer(UnityEngine.Transform transform);
    /*0x26180f4*/ void OnEnable();
    /*0x2618184*/ void OnDisable();
}

class SkillShowClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ SkillShowClip.SkillShowType skillShowType;
    /*0x20*/ string animName;
    /*0x28*/ UnityEngine.Vector3 heroLocalMoveFrom;
    /*0x34*/ UnityEngine.Vector3 heroLocalMoveTo;
    /*0x40*/ float focusFov;
    /*0x44*/ UnityEngine.Vector3 focusOffset;
    /*0x50*/ UnityEngine.AnimationCurve focusCurve;
    /*0x58*/ UnityEngine.AnimationCurve resetCurve;
    /*0x60*/ bool toBlack;
    /*0x68*/ string mapSkillText;
    /*0x70*/ bool showHeroName;
    /*0x78*/ UnityEngine.AnimationCurve shakeCurve;
    /*0x80*/ string triggerEvent;

    /*0x26182f8*/ SkillShowClip();
    /*0x2618218*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
    /*0x2618220*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);

    enum SkillShowType
    {
        Animation = 0,
        HeroMove = 1,
        CamFocus = 2,
        CamShake = 3,
        ResetCamFocus = 4,
        MapMask = 5,
        MapSkillText = 6,
        TriggerEvent = 7,
    }
}

class SkillShowPlayableAsset : UnityEngine.Playables.PlayableAsset
{
    /*0x2618464*/ SkillShowPlayableAsset();
    /*0x26183c8*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class SkillShowPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    /*0x2618480*/ SkillShowPlayableBehaviour();
    /*0x261846c*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
    /*0x2618470*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
    /*0x2618474*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x2618478*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x261847c*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
}

class SkillShowTrack : UnityEngine.Timeline.TrackAsset
{
    /*0x2618488*/ SkillShowTrack();
}

class UIFlowerPanel : UnityEngine.MonoBehaviour
{
    static float showFlowerDelay = 1;
    static float showTipDelay = 2;
    static /*0x0*/ UIFlowerPanel Instance;
    /*0x18*/ UnityEngine.GameObject contenGo;
    /*0x20*/ TMPro.TextMeshProUGUI contentLabel;
    /*0x28*/ UnityEngine.GameObject contetnBg;
    /*0x30*/ float openedTimer;
    /*0x38*/ string content;
    /*0x40*/ System.Collections.Generic.List<UIFlowerPanel.FlowerFlagState> mFlagStates;

    /*0x2618f24*/ UIFlowerPanel();
    /*0x26184e0*/ bool get_IsShow();
    /*0x2618530*/ void Awake();
    /*0x26185dc*/ void OnDestroy();
    /*0x2618624*/ void Update();
    /*0x2618770*/ void UpdateFlower();
    /*0x26187c8*/ void UpdateShowTip();
    /*0x261887c*/ void SetTip(string text);
    /*0x261866c*/ void UpdateAutoClose(float dt);
    /*0x2618998*/ UIFlowerPanel.FlowerFlagState GetFlowerFlag(int type);
    /*0x2618afc*/ bool HasFlowerFlag(int type);
    /*0x2618c60*/ bool RemoveFlowerFlag(int type);
    /*0x2618d28*/ void ShowFlower(bool showFlower, int type, float autoCloseTime);
    /*0x261889c*/ void Hide();

    class FlowerFlagState
    {
        /*0x10*/ int <FlowerFlag>k__BackingField;
        /*0x14*/ float <TimeOutRemain>k__BackingField;

        /*0x2618ee4*/ FlowerFlagState(int type, float autoCloseTime);
        /*0x2618fa0*/ int get_FlowerFlag();
        /*0x2618fa8*/ void set_FlowerFlag(int value);
        /*0x2618fb0*/ float get_TimeOutRemain();
        /*0x2618fb8*/ void set_TimeOutRemain(float value);
        /*0x2618f1c*/ void Update(float TimeOutRemain);
    }
}

class BlackFadeMask : UnityEngine.MonoBehaviour
{
    /*0x18*/ float alpha;
    /*0x1c*/ bool isFadeIn;
    /*0x1d*/ bool isFading;
    /*0x20*/ System.Action fadeDel;
    /*0x28*/ UnityEngine.AnimationCurve fadeCurve;
    /*0x30*/ float timer;
    /*0x34*/ float fadeDuration;
    /*0x38*/ UnityEngine.UI.RawImage _image;

    /*0x2619518*/ BlackFadeMask();
    /*0x2618fc0*/ UnityEngine.UI.RawImage get_Image();
    /*0x2619064*/ void FadeIn(float duration, System.Action del, float start, bool black);
    /*0x26191e8*/ void FadeOut(float duration, System.Action del, float start, bool black);
    /*0x261925c*/ void FadeOutInternal(float duration, System.Action del, float start);
    /*0x26193d8*/ void Update();
}

class UIForeGround : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UIForeGround _instance;
    /*0x18*/ BlackFadeMask blackMask;

    static /*0x2619520*/ UIForeGround get_Instance();
    /*0x2619750*/ UIForeGround();
    /*0x2619568*/ void Awake();
    /*0x26195d4*/ void OnDestroy();
    /*0x261961c*/ void FadeIn(float duration, System.Action del, bool pingPong, float start, bool black);
    /*0x2619730*/ void FadeOut(float duration, System.Action del, bool black);

    class <>c__DisplayClass6_0
    {
        /*0x10*/ System.Action del;
        /*0x18*/ UIForeGround <>4__this;
        /*0x20*/ float duration;
        /*0x24*/ bool black;

        /*0x2619728*/ <>c__DisplayClass6_0();
        /*0x2619758*/ void <FadeIn>b__0();
    }
}

class UIMapPanel : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UIMapPanel Instance;
    /*0x18*/ UnityEngine.Animator animator;
    /*0x20*/ UnityEngine.AnimatorStateInfo curAnimInfo;

    /*0x26199dc*/ UIMapPanel();
    /*0x2619798*/ void Awake();
    /*0x2619800*/ void OnDestroy();
    /*0x2619848*/ void Update();
    /*0x2619898*/ void Hide();
    /*0x26198bc*/ System.Collections.IEnumerator OpenMask();
    /*0x261994c*/ System.Collections.IEnumerator ClearMask();

    class <OpenMask>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UIMapPanel <>4__this;

        /*0x2619924*/ <OpenMask>d__7(int <>1__state);
        /*0x26199e4*/ void System.IDisposable.Dispose();
        /*0x26199e8*/ bool MoveNext();
        /*0x2619b20*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x2619b28*/ void System.Collections.IEnumerator.Reset();
        /*0x2619b68*/ object System.Collections.IEnumerator.get_Current();
    }

    class <ClearMask>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UIMapPanel <>4__this;

        /*0x26199b4*/ <ClearMask>d__8(int <>1__state);
        /*0x2619b70*/ void System.IDisposable.Dispose();
        /*0x2619b74*/ bool MoveNext();
        /*0x2619c9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x2619ca4*/ void System.Collections.IEnumerator.Reset();
        /*0x2619ce4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class CloudLoadingPanel : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CloudLoadingPanel Instance;
    /*0x18*/ UnityEngine.Animation anim;

    /*0x2619ee4*/ CloudLoadingPanel();
    /*0x2619cec*/ void Awake();
    /*0x2619d54*/ void OnDestroy();
    /*0x2619d9c*/ void Update();
    /*0x2619da0*/ void Hide();
    /*0x2619dc4*/ System.Collections.IEnumerator OpenMask();
    /*0x2619e54*/ System.Collections.IEnumerator ClearMask();

    class <OpenMask>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ CloudLoadingPanel <>4__this;

        /*0x2619e2c*/ <OpenMask>d__6(int <>1__state);
        /*0x2619eec*/ void System.IDisposable.Dispose();
        /*0x2619ef0*/ bool MoveNext();
        /*0x261a1a8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x261a1b0*/ void System.Collections.IEnumerator.Reset();
        /*0x261a1f0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <ClearMask>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ CloudLoadingPanel <>4__this;

        /*0x2619ebc*/ <ClearMask>d__7(int <>1__state);
        /*0x261a1f8*/ void System.IDisposable.Dispose();
        /*0x261a1fc*/ bool MoveNext();
        /*0x261a464*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x261a46c*/ void System.Collections.IEnumerator.Reset();
        /*0x261a4ac*/ object System.Collections.IEnumerator.get_Current();
    }
}

class UIHandPanel : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UIHandPanel Instance;
    /*0x18*/ UnityEngine.Camera cam;
    /*0x20*/ UnityEngine.GameObject hand;

    static /*0x261aa08*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
    static /*0x261aad0*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
    static /*0x261ac84*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
    /*0x261adb0*/ UIHandPanel();
    /*0x261a4b4*/ void Awake();
    /*0x261a630*/ void Instance_CommonClickEvent(bool arg1, UnityEngine.GameObject arg2);
    /*0x261a6c8*/ void OnDestroy();
    /*0x261a848*/ void ShowHand(UnityEngine.Vector3 localPoint);
    /*0x261a634*/ void HideHand();
    /*0x261a8ec*/ bool IsPointerOverGameObject(UnityEngine.Vector2 mousePosition);
}

class UIScreenBackgroundMessage : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UIScreenBackgroundMessage Instance;
    /*0x18*/ System.Action<UnityEngine.Vector2, bool> PressEvent;
    /*0x20*/ System.Action<UnityEngine.Vector2> ClickEvent;
    /*0x28*/ System.Action<UnityEngine.Vector2> DragEvent;
    /*0x30*/ System.Action DragStartEvent;
    /*0x38*/ System.Action DragEndEvent;
    /*0x40*/ System.Action<float> ZoomEvent;
    /*0x48*/ System.Action<bool, UnityEngine.GameObject> CommonClickEvent;
    /*0x50*/ bool isZooming;
    /*0x54*/ float preABDistance;

    /*0x261bab0*/ UIScreenBackgroundMessage();
    /*0x261adb8*/ void add_PressEvent(System.Action<UnityEngine.Vector2, bool> value);
    /*0x261ae68*/ void remove_PressEvent(System.Action<UnityEngine.Vector2, bool> value);
    /*0x261af18*/ void add_ClickEvent(System.Action<UnityEngine.Vector2> value);
    /*0x261afc8*/ void remove_ClickEvent(System.Action<UnityEngine.Vector2> value);
    /*0x261b078*/ void add_DragEvent(System.Action<UnityEngine.Vector2> value);
    /*0x261b128*/ void remove_DragEvent(System.Action<UnityEngine.Vector2> value);
    /*0x261b1d8*/ void add_DragStartEvent(System.Action value);
    /*0x261b274*/ void remove_DragStartEvent(System.Action value);
    /*0x261b310*/ void add_DragEndEvent(System.Action value);
    /*0x261b3ac*/ void remove_DragEndEvent(System.Action value);
    /*0x261b448*/ void add_ZoomEvent(System.Action<float> value);
    /*0x261b4f8*/ void remove_ZoomEvent(System.Action<float> value);
    /*0x261a580*/ void add_CommonClickEvent(System.Action<bool, UnityEngine.GameObject> value);
    /*0x261a798*/ void remove_CommonClickEvent(System.Action<bool, UnityEngine.GameObject> value);
    /*0x261b5a8*/ void Awake();
    /*0x261b5f4*/ void Update();
    /*0x261b6ec*/ void Zooming();
    /*0x261b95c*/ void OnClick();
    /*0x261b98c*/ void OnPress(bool isDown);
    /*0x261b9d0*/ void OnDragStart();
    /*0x261b9ec*/ void OnDrag(UnityEngine.EventSystems.BaseEventData database);
    /*0x261ba94*/ void OnDragEnd();
    /*0x261b940*/ void OnZooming(float delta);
    /*0x261b7e0*/ UnityEngine.GameObject CheckRaycastResult();
}

namespace LccModel
{
    class UIAdapt : UnityEngine.MonoBehaviour
    {
        static float MinAdaptScal = 1.7777777910232544;
        static float MaxAdaptScal = 2.407407522201538;
        /*0x18*/ float leftOffset;
        /*0x1c*/ float rightOffset;
        /*0x20*/ int _scalerChangeFrameCount;
        /*0x28*/ UnityEngine.RectTransform _uiAdaptCanvasRoot;
        /*0x30*/ UnityEngine.RectTransform _uiUpCanvasRoot;
        /*0x38*/ UnityEngine.RectTransform _uiDownCanvasRoot;
        /*0x40*/ UnityEngine.RectTransform _uiLeftCanvasRoot;
        /*0x48*/ UnityEngine.RectTransform _uiRightCanvasRoot;
        /*0x50*/ UnityEngine.Camera _mainCamera;

        /*0x261c3b8*/ UIAdapt();
        /*0x261bab8*/ float get_ScreenRatio();
        /*0x261bae4*/ void Start();
        /*0x261c1a0*/ void Update();
        /*0x261c1ec*/ void UIOffset(float offect);
        /*0x261bd30*/ void AdaptUIRoot(bool adaptScreenRatio, bool adaptSafeArea, float leftOffset, float rightOffset);
        /*0x261c1fc*/ void SetAdaptUIRoot(float up, float down, float left, float right);
        /*0x261c344*/ void SetTransOffset(UnityEngine.RectTransform rectTrans, float up, float down, float left, float right);
        /*0x261c3c8*/ void <AdaptUIRoot>b__16_0(UnityEngine.Camera subCamera);
    }
}

namespace Hotfix
{
    class RedDot : UnityEngine.MonoBehaviour
    {
        /*0x18*/ string key;
        /*0x20*/ System.Action<string, int> action;
        /*0x28*/ bool isShowCount;
        /*0x29*/ bool isRedDotActive;
        /*0x30*/ UnityEngine.GameObject redDot;
        /*0x38*/ TMPro.TextMeshProUGUI redDotCount;
        /*0x40*/ UnityEngine.Vector3 scale;
        /*0x4c*/ UnityEngine.Vector2 offset;

        /*0x261cd2c*/ RedDot();
        /*0x261c3f8*/ void Awake();
        /*0x261c930*/ void SetRedDotKey(string key, int id);
        /*0x261ca78*/ void OnChangedAction(string key, int count);
        /*0x261cac8*/ void Show(int count);
        /*0x261c894*/ void Hide();
        /*0x261cb70*/ void RefreshRedDotCount(int count);
        /*0x261cc18*/ void OnDestroy();
    }
}

namespace AD
{
    class ParallaxBackground : UnityEngine.MonoBehaviour
    {
        /*0x18*/ AD.ParallaxCamera parallaxCamera;
        /*0x20*/ System.Collections.Generic.List<AD.ParallaxLayer> parallaxLayers;

        /*0x261d54c*/ ParallaxBackground();
        /*0x261cdc4*/ void Start();
        /*0x261d088*/ void SetLayers();
        /*0x261d27c*/ void ResetAll();
        /*0x261d37c*/ void Move(float delta);

        class <>c
        {
            static /*0x0*/ AD.ParallaxBackground.<> <>9;
            static /*0x8*/ System.Action<AD.ParallaxLayer> <>9__4_0;

            static /*0x261d5c8*/ <>c();
            /*0x261d62c*/ <>c();
            /*0x261d634*/ void <ResetAll>b__4_0(AD.ParallaxLayer x);
        }
    }

    class ParallaxCamera : UnityEngine.MonoBehaviour
    {
        /*0x18*/ AD.ParallaxCamera.ParallaxCameraDelegate onCameraTranslate;
        /*0x20*/ System.Action ResetAll;
        /*0x28*/ float oldPosition;
        /*0x2c*/ bool skip;

        /*0x261d7d4*/ ParallaxCamera();
        /*0x261d6ac*/ void Start();
        /*0x261d6d8*/ void Update();
        /*0x261d774*/ void SetEnable(bool enable);
        /*0x261d7b8*/ void ResetBackground();

        class ParallaxCameraDelegate : System.MulticastDelegate
        {
            /*0x261cfc4*/ ParallaxCameraDelegate(object object, nint method);
            /*0x261d7dc*/ void Invoke(float deltaMovement);
            /*0x261d7f0*/ System.IAsyncResult BeginInvoke(float deltaMovement, System.AsyncCallback callback, object object);
            /*0x261d874*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class ParallaxLayer : UnityEngine.MonoBehaviour
    {
        /*0x18*/ float parallaxFactor;
        /*0x1c*/ float startX;

        /*0x261d8ac*/ ParallaxLayer();
        /*0x261d880*/ void Start();
        /*0x261d648*/ void Reset();
        /*0x261d4d4*/ void Move(float delta);
    }
}

namespace GCloud
{
    namespace UQM
    {
        class OnUQMRetEventHandler<T> : System.MulticastDelegate
        {
            OnUQMRetEventHandler(object object, nint method);
            void Invoke(T ret);
            System.IAsyncResult BeginInvoke(T ret, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class OnUQMStringRetEventHandler<T> : System.MulticastDelegate
        {
            OnUQMStringRetEventHandler(object object, nint method);
            string Invoke(T ret, T crashType);
            System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, object object);
            string EndInvoke(System.IAsyncResult result);
        }

        class OnUQMStringRetSetLogPathEventHandler<T> : System.MulticastDelegate
        {
            OnUQMStringRetSetLogPathEventHandler(object object, nint method);
            string Invoke(T ret, T crashType);
            System.IAsyncResult BeginInvoke(T ret, T crashType, System.AsyncCallback callback, object object);
            string EndInvoke(System.IAsyncResult result);
        }

        class OnUQMRetLogUploadEventHandler<T> : System.MulticastDelegate
        {
            OnUQMRetLogUploadEventHandler(object object, nint method);
            void Invoke(T ret, T crashType, T result);
            System.IAsyncResult BeginInvoke(T ret, T crashType, T result, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class UQM
        {
            static string LibName = "CrashSight";
            static /*0x0*/ bool initialized;
            static /*0x1*/ bool isDebug;

            static /*0x261dacc*/ UQM();
            static /*0x261d8b4*/ void Init();
            /*0x261dac4*/ UQM();
        }

        enum UQMCrashLevel
        {
            CSLogLevelSilent = 0,
            CSLogLevelError = 1,
            CSLogLevelWarn = 2,
            CSLogLevelInfo = 3,
            CSLogLevelDebug = 4,
            CSLogLevelVerbose = 5,
        }

        class UQMCrash
        {
            static /*0x0*/ GCloud.UQM.OnUQMStringRetEventHandler<int> CrashBaseRetEvent;
            static /*0x8*/ GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent;
            static /*0x10*/ GCloud.UQM.OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent;
            static /*0x18*/ UnityEngine.AndroidJavaClass _gameAgentClass;
            static /*0x20*/ bool _isLoadedSo;
            static /*0x24*/ int _gameType;
            static /*0x28*/ string GAME_AGENT_CLASS;

            static /*0x2624320*/ UQMCrash();
            static /*0x261db18*/ void cs_configAutoReportLogLevelAdapter(int level);
            static /*0x261db94*/ void cs_configGameTypeAdapter(int gameType);
            static /*0x261dc10*/ void cs_configCallbackTypeAdapter(int callbackType);
            static /*0x261dc8c*/ void cs_configDefaultAdapter(string channel, string version, string user, long delay);
            static /*0x261dd64*/ void cs_configCrashServerUrlAdapter(string serverUrl);
            static /*0x261ddf0*/ void cs_configDebugModeAdapter(bool enable);
            static /*0x261de6c*/ void cs_initWithAppIdAdapter(string appId);
            static /*0x261def8*/ void cs_logRecordAdapter(int level, string message);
            static /*0x261df90*/ void cs_addSceneDataAdapter(string k, string v);
            static /*0x261e03c*/ void cs_reportExceptionV1Adapter(int type, string name, string message, string stackTrace, string extras, bool quitProgram);
            static /*0x261e140*/ void cs_reportExceptionV2Adapter(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int dumpNativeType);
            static /*0x261e244*/ void cs_setUserIdAdapter(string userId);
            static /*0x261e2d0*/ void cs_setSceneAdapter(int sceneId);
            static /*0x261e34c*/ void cs_unityCrashCallback();
            static /*0x261e3b0*/ void cs_unregisterUnityCrashCallback();
            static /*0x261e414*/ void cs_unityCrashLogCallback();
            static /*0x261e478*/ void cs_reRegistAllMonitorsAdapter();
            static /*0x261e4dc*/ void cs_reportLogInfo(string msgType, string msg);
            static /*0x261e584*/ void cs_setAppVersionAdapter(string appVersion);
            static /*0x261e610*/ void cs_setDeviceIdAdapter(string deviceId);
            static /*0x261e69c*/ void cs_setCustomizedDeviceIDAdapter(string deviceId);
            static /*0x261e728*/ nint cs_getSDKDefinedDeviceIDAdapter();
            static /*0x261e790*/ void cs_setCustomizedMatchIDAdapter(string matchId);
            static /*0x261e81c*/ nint cs_getSDKSessionIDAdapter();
            static /*0x261e884*/ nint cs_getCrashUuidAdapter();
            static /*0x261e8ec*/ void cs_setDeviceModelAdapter(string deviceModel);
            static /*0x261e978*/ void cs_setLogPathAdapter(string logPath);
            static /*0x261ea04*/ void cs_testOomCrashAdapter();
            static /*0x261ea68*/ void cs_testJavaCrashAdapter();
            static /*0x261eacc*/ void cs_testOcCrashAdapter();
            static /*0x261eb30*/ void cs_testNativeCrashAdapter();
            static /*0x261eb94*/ long cs_getCrashThreadId();
            static /*0x261ebfc*/ void add_CrashBaseRetEvent(GCloud.UQM.OnUQMStringRetEventHandler<int> value);
            static /*0x261ecec*/ void remove_CrashBaseRetEvent(GCloud.UQM.OnUQMStringRetEventHandler<int> value);
            static /*0x261eddc*/ void add_CrashSetLogPathRetEvent(GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<int> value);
            static /*0x261eed0*/ void remove_CrashSetLogPathRetEvent(GCloud.UQM.OnUQMStringRetSetLogPathEventHandler<int> value);
            static /*0x261efc4*/ void add_CrashLogUploadRetEvent(GCloud.UQM.OnUQMRetLogUploadEventHandler<int> value);
            static /*0x261f0b8*/ void remove_CrashLogUploadRetEvent(GCloud.UQM.OnUQMRetLogUploadEventHandler<int> value);
            static /*0x261f1ac*/ UnityEngine.AndroidJavaClass get_CrashSightPlatform();
            static /*0x261f278*/ void LoadCrashSightCoreSo();
            static /*0x261f568*/ void ConfigCallbackType(int callbackType);
            static /*0x261f738*/ void ConfigGameType(int gameType);
            static /*0x261f91c*/ void ConfigAutoReportLogLevel(int level);
            static /*0x261faec*/ void ConfigCrashServerUrl(string serverUrl);
            static /*0x261fca8*/ void ConfigDebugMode(bool enable);
            static /*0x261fed8*/ void ConfigDefault(string channel, string version, string user, long delay);
            static /*0x262031c*/ void InitWithAppId(string appId);
            static /*0x2620510*/ void InitContext(string userId, string version, string key);
            static /*0x2620698*/ void LogRecord(int level, string message);
            static /*0x262088c*/ void AddSceneData(string k, string v);
            static /*0x2620a78*/ void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram);
            static /*0x2620cd8*/ void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, System.Collections.Generic.Dictionary<string, string> extInfo);
            static /*0x2620f38*/ void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, System.Collections.Generic.Dictionary<string, string> extInfo, int dumpNativeType);
            static /*0x26211a4*/ void SetUserId(string userId);
            static /*0x2621360*/ void SetScene(int sceneId);
            static /*0x2621530*/ void ReRegistAllMonitors();
            static /*0x26216cc*/ void ReportLogInfo(string msgType, string msg);
            static /*0x2621888*/ void SetAppVersion(string appVersion);
            static /*0x2621a44*/ void SetDeviceId(string deviceId);
            static /*0x2621c00*/ void SetCustomizedDeviceID(string deviceId);
            static /*0x2621dbc*/ string GetSDKDefinedDeviceID();
            static /*0x2621fb0*/ void SetCustomizedMatchID(string matchId);
            static /*0x262216c*/ string GetSDKSessionID();
            static /*0x2622360*/ string GetCrashUuid();
            static /*0x2622554*/ void SetDeviceModel(string deviceModel);
            static /*0x2622710*/ void SetLogPath(string logPath);
            static /*0x26228cc*/ void SetCrashCallback();
            static /*0x2622a64*/ void UnsetCrashCallback();
            static /*0x2622bfc*/ void SetCrashLogCallback();
            static /*0x2622d94*/ string OnCrashCallbackMessage(int methodId, int crashType);
            static /*0x2622fcc*/ string OnCrashCallbackData(int methodId, int crashType);
            static /*0x2623204*/ string OnCrashSetLogPathMessage(int methodId, int crashType);
            static /*0x262343c*/ string OnCrashLogUploadMessage(int methodId, int crashType, int result);
            static /*0x2623678*/ void ConfigCallBack();
            static /*0x26239ec*/ void UnregisterCallBack();
            static /*0x2623ab4*/ void ConfigLogCallBack();
            static /*0x2623b10*/ void SetCustomLogDir(string path);
            static /*0x2623b14*/ void TestOomCrash();
            static /*0x2623cb0*/ void TestJavaCrash();
            static /*0x2623e4c*/ void TestOcCrash();
            static /*0x2623fe8*/ void TestNativeCrash();
            static /*0x2624184*/ long GetCrashThreadId();
        }

        enum UQMMethodNameID
        {
            UQM_CRASH_CALLBACK_EXTRA_DATA = 1011,
            UQM_CRASH_CALLBACK_EXTRA_MESSAGE = 1012,
            UQM_CRASH_CALLBACK_SET_LOG_PATH = 1013,
            UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT = 1014,
        }

        class UQMLog
        {
            static string header = "[CrashSightPlugin-Unity]";
            static /*0x0*/ GCloud.UQM.UQMLog.Level level;

            static /*0x2624670*/ UQMLog();
            static /*0x262438c*/ void SetLevel(GCloud.UQM.UQMLog.Level l);
            static /*0x261d9fc*/ void Log(string message);
            static /*0x26243e8*/ void LogWarning(string message);
            static /*0x261f4a0*/ void LogError(string message);
            static /*0x26244b0*/ void FullLog(string message);
            /*0x2624668*/ UQMLog();

            enum Level
            {
                None = 0,
                Log = 1,
                Warning = 2,
                Error = 3,
            }
        }

        class RetArgsWrapper
        {
            /*0x10*/ int methodId;
            /*0x18*/ string retJson;
            /*0x20*/ int crashType;
            /*0x24*/ int logUploadResult;

            /*0x26246dc*/ RetArgsWrapper(int _methodId, string _retJson, int _crashType, int _logUploadResult);
            /*0x26246bc*/ int get_MethodId();
            /*0x26246c4*/ string get_RetJson();
            /*0x26246cc*/ int get_CrashType();
            /*0x26246d4*/ int get_LogUploadResult();
        }

        class UQMMessageCenter : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ bool initialzed;
            static /*0x8*/ GCloud.UQM.UQMMessageCenter instance;

            static /*0x2624720*/ string OnUQMRet(int methodId, int crashType, int logUploadResult);
            static /*0x2624bdc*/ void cs_setUnityCallback(GCloud.UQM.UQMMessageCenter.UQMRetJsonEventHandler eventHandler);
            static /*0x26236d4*/ GCloud.UQM.UQMMessageCenter get_Instance();
            static /*0x2624880*/ string SynchronousDelegate(object arg);
            /*0x2624d20*/ UQMMessageCenter();
            /*0x26238ec*/ void Init();
            /*0x2623a48*/ void Uninit();

            class UQMRetJsonEventHandler : System.MulticastDelegate
            {
                /*0x2624c5c*/ UQMRetJsonEventHandler(object object, nint method);
                /*0x2624d28*/ string Invoke(int methodId, int callType, int logUploadResult);
                /*0x2624d3c*/ System.IAsyncResult BeginInvoke(int methodId, int callType, int logUploadResult, System.AsyncCallback callback, object object);
                /*0x2624dec*/ string EndInvoke(System.IAsyncResult result);
            }
        }

        namespace MiniJSON
        {
            class Json
            {
                static /*0x2624df8*/ object Deserialize(string json);
                static /*0x2620f34*/ string Serialize(object obj);

                class Parser : System.IDisposable
                {
                    static string WORD_BREAK = "{}[],:"";
                    /*0x10*/ System.IO.StringReader json;

                    static /*0x2625014*/ bool IsWordBreak(char c);
                    static /*0x2624e04*/ object Parse(string jsonString);
                    /*0x26250b0*/ Parser(string jsonString);
                    /*0x2625148*/ void Dispose();
                    /*0x2625170*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                    /*0x26256b8*/ System.Collections.Generic.List<object> ParseArray();
                    /*0x262512c*/ object ParseValue();
                    /*0x26257dc*/ object ParseByToken(GCloud.UQM.MiniJSON.Json.Parser.TOKEN token);
                    /*0x2625458*/ string ParseString();
                    /*0x26258c4*/ object ParseNumber();
                    /*0x2625ab8*/ void EatWhitespace();
                    /*0x2625b5c*/ char get_PeekChar();
                    /*0x2625994*/ char get_NextChar();
                    /*0x2625a0c*/ string get_NextWord();
                    /*0x2625294*/ GCloud.UQM.MiniJSON.Json.Parser.TOKEN get_NextToken();

                    enum TOKEN
                    {
                        NONE = 0,
                        CURLY_OPEN = 1,
                        CURLY_CLOSE = 2,
                        SQUARED_OPEN = 3,
                        SQUARED_CLOSE = 4,
                        COLON = 5,
                        COMMA = 6,
                        STRING = 7,
                        NUMBER = 8,
                        TRUE = 9,
                        FALSE = 10,
                        NULL = 11,
                    }
                }

                class Serializer
                {
                    /*0x10*/ System.Text.StringBuilder builder;

                    static /*0x2624fa0*/ string Serialize(object obj);
                    /*0x2625bd4*/ Serializer();
                    /*0x2625c40*/ void SerializeValue(object value);
                    /*0x262642c*/ void SerializeObject(System.Collections.IDictionary obj);
                    /*0x26260cc*/ void SerializeArray(System.Collections.IList anArray);
                    /*0x2625e10*/ void SerializeString(string str);
                    /*0x26268b8*/ void SerializeOther(object value);
                }
            }
        }
    }
}

namespace CrashSightSDKEditor
{
    namespace XUPorterJSON
    {
        class MiniJSON
        {
            static int TOKEN_NONE = 0;
            static int TOKEN_CURLY_OPEN = 1;
            static int TOKEN_CURLY_CLOSE = 2;
            static int TOKEN_SQUARED_OPEN = 3;
            static int TOKEN_SQUARED_CLOSE = 4;
            static int TOKEN_COLON = 5;
            static int TOKEN_COMMA = 6;
            static int TOKEN_STRING = 7;
            static int TOKEN_NUMBER = 8;
            static int TOKEN_TRUE = 9;
            static int TOKEN_FALSE = 10;
            static int TOKEN_NULL = 11;
            static int BUILDER_CAPACITY = 2000;
            static /*0x0*/ int lastErrorIndex;
            static /*0x8*/ string lastDecode;

            static /*0x2628c80*/ MiniJSON();
            static /*0x2626b34*/ object jsonDecode(string json);
            static /*0x2626e98*/ string jsonEncode(object json);
            static /*0x26273cc*/ bool lastDecodeSuccessful();
            static /*0x262742c*/ int getLastErrorIndex();
            static /*0x2627484*/ string getLastErrorSnippet();
            static /*0x26275b8*/ System.Collections.Hashtable parseObject(char[] json, ref int index);
            static /*0x2627e04*/ System.Collections.ArrayList parseArray(char[] json, ref int index);
            static /*0x2626c30*/ object parseValue(char[] json, ref int index, ref bool success);
            static /*0x2627a78*/ string parseString(char[] json, ref int index);
            static /*0x2627f70*/ double parseNumber(char[] json, ref int index);
            static /*0x26280f4*/ int getLastIndexOfNumber(char[] json, int index);
            static /*0x2628054*/ void eatWhitespace(char[] json, ref int index);
            static /*0x2627a0c*/ int lookAhead(char[] json, int index);
            static /*0x2627764*/ int nextToken(char[] json, ref int index);
            static /*0x262819c*/ bool serializeObjectOrArray(object objectOrArray, System.Text.StringBuilder builder);
            static /*0x2628308*/ bool serializeObject(System.Collections.Hashtable anObject, System.Text.StringBuilder builder);
            static /*0x26289ac*/ bool serializeDictionary(System.Collections.Generic.Dictionary<string, string> dict, System.Text.StringBuilder builder);
            static /*0x26285bc*/ bool serializeArray(System.Collections.ArrayList anArray, System.Text.StringBuilder builder);
            static /*0x2626f48*/ bool serializeValue(object value, System.Text.StringBuilder builder);
            static /*0x262871c*/ void serializeString(string aString, System.Text.StringBuilder builder);
            static /*0x2628bfc*/ void serializeNumber(double number, System.Text.StringBuilder builder);
            /*0x2628c78*/ MiniJSON();
        }

        class MiniJsonExtensions
        {
            static /*0x2628ce8*/ string toJson(System.Collections.Hashtable obj);
            static /*0x2628d3c*/ string toJson(System.Collections.Generic.Dictionary<string, string> obj);
            static /*0x2628d90*/ System.Collections.ArrayList arrayListFromJson(string json);
            static /*0x2628e34*/ System.Collections.Hashtable hashtableFromJson(string json);
        }
    }
}

namespace Framework
{
    class ByteExpand
    {
        static /*0x2628ed8*/ string ToHex(byte b);
        static /*0x2628f28*/ string ToHex(byte[] bytes);
        static /*0x262901c*/ string ToHex(byte[] bytes, string format);
        static /*0x2629100*/ string ToHex(byte[] bytes, int offset, int count);
        static /*0x26291f4*/ string ToStr(byte[] bytes);
        static /*0x2629224*/ string ToStr(byte[] bytes, int index, int count);
        static /*0x262926c*/ string Utf8ToStr(byte[] bytes);
        static /*0x262929c*/ string Utf8ToStr(byte[] bytes, int index, int count);
        static /*0x26292e4*/ void WriteTo(byte[] bytes, int offset, uint num);
        static /*0x2629364*/ void WriteTo(byte[] bytes, int offset, int num);
        static /*0x26293e4*/ void WriteTo(byte[] bytes, int offset, byte num);
        static /*0x2629410*/ void WriteTo(byte[] bytes, int offset, short num);
        static /*0x2629458*/ void WriteTo(byte[] bytes, int offset, ushort num);
        static /*0x26294a0*/ void WriteTo(byte[] bytes, int offset, long num);
        static /*0x26294fc*/ byte[] ByteXOR(byte[] srcBytes, byte[] xor);
    }

    class StringExpand
    {
        static /*0x2629570*/ byte[] GetBytes(string s);
        static /*0x26295a0*/ UnityEngine.GameObject GetGameObjectToName(string name);
        static /*0x26295a8*/ UnityEngine.GameObject GetGameObjectToTag(string tag);
        static /*0x26295b0*/ UnityEngine.GameObject[] GetGameObjectsToTag(string tag);
    }

    class TransformExpand
    {
        static /*0x26295b8*/ UnityEngine.Vector2 SizeDelta(UnityEngine.RectTransform rectTransform);
        static /*0x2629628*/ UnityEngine.GameObject GetChildGameObject(UnityEngine.Transform transform, string[] childs);
        static /*0x26297a4*/ void SafeDestroy(UnityEngine.Transform transform);
        static T GetChildComponent<T>(UnityEngine.Transform transform, string[] childs);
        static T AddChildComponent<T>(UnityEngine.Transform transform, string[] childs);
        static void SafeDestroy<T>(UnityEngine.Transform transform);
        static /*0x2629848*/ void ResetTransform(UnityEngine.Transform transform, UnityEngine.Transform parent);
        static /*0x26299a0*/ void ResetTransform(UnityEngine.Transform trans);
        static /*0x2629ad8*/ void SetRectSize(UnityEngine.RectTransform transform, UnityEngine.Vector2 size);
        static /*0x2629b18*/ void SetHorizontalOrVerticalLayoutGroup(UnityEngine.UI.HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup, float spacing, bool controlChildSizeX, bool controlChildSizeY, bool useChildScaleX, bool useChildScaleY, bool childForceExpandX, bool childForceExpandY);
    }

    class DirectoryHelper
    {
        static /*0x2629bd0*/ System.IO.DirectoryInfo CreateDirectory(string path);
        static /*0x2629c00*/ bool SubDirectoryExist(System.IO.DirectoryInfo directoryInfo);
        static /*0x2629c44*/ System.IO.DirectoryInfo[] GetDirectorys(System.IO.DirectoryInfo directoryInfo, System.Collections.Generic.List<System.IO.DirectoryInfo> directoryInfoList);
        static /*0x2629d4c*/ void CopyFolder(string sourcePath, string destPath);

        class <>c__DisplayClass3_0
        {
            /*0x10*/ string destPath;

            /*0x262a02c*/ <>c__DisplayClass3_0();
            /*0x262a034*/ void <CopyFolder>b__0(string c);
            /*0x262a148*/ void <CopyFolder>b__1(string c);
        }
    }

    class FileHelper
    {
        static /*0x262a254*/ bool FileExist(System.IO.DirectoryInfo directoryInfo);
        static /*0x262a298*/ long GetFileSize(string path);
        static /*0x262a320*/ System.IO.FileInfo[] GetFiles(System.IO.DirectoryInfo directoryInfo, System.Collections.Generic.List<System.IO.FileInfo> fileInfoList);
        static /*0x262a428*/ void SaveAsset(string path, byte[] bytes);
        static /*0x262a5f8*/ void SaveAsset(string path, string value);
        static /*0x262a618*/ void SaveAsset(string path, string name, byte[] bytes);
        static /*0x262a680*/ void SaveAsset(string path, string name, string value);
        static /*0x262a6f8*/ byte[] GetAsset(string path);
        static /*0x262a924*/ byte[] GetAsset(string path, string name);
    }

    class JsonHelper
    {
        static /*0x262a984*/ string ToJson(object obj);
        static /*0x262a9e0*/ object ToObject(System.Type type, string json);
        static /*0x262ab58*/ LitJson.JsonData ToObject(string json);
        static T ToObject<T>(string json);
    }

    class PathHelper
    {
        static /*0x262abb0*/ string get_PlatformForAssetBundle();
        static /*0x262ac50*/ string GetDataPath(string[] folders);
        static /*0x262ad84*/ string GetPersistentDataPath(string[] folders);
        static /*0x262aeb8*/ string GetStreamingAssetsPath(string[] folders);
        static /*0x262afec*/ string GetStreamingAssetsPathWeb(string[] folders);
    }

    enum PathType
    {
        DataPath = 0,
        StreamingAssetsPath = 1,
        PersistentDataPath = 2,
    }

    class RijndaelHelper
    {
        static /*0x262b0dc*/ byte[] RijndaelEncrypt(byte[] keyBytes, byte[] valueBytes);
        static /*0x262b228*/ byte[] RijndaelEncrypt(string key, byte[] valueBytes);
        static /*0x262b240*/ string RijndaelEncrypt(string key, string value);
        static /*0x262b2d0*/ byte[] RijndaelDecrypt(byte[] keyBytes, byte[] valueBytes);
        static /*0x262b41c*/ byte[] RijndaelDecrypt(string key, byte[] valueBytes);
        static /*0x262b434*/ string RijndaelDecrypt(string key, string value);
    }

    class StreamingAssetsHelper
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, bool> _cacheData;
        static /*0x8*/ UnityEngine.AndroidJavaClass _unityPlayerClass;
        static /*0x10*/ UnityEngine.AndroidJavaObject _currentActivity;

        static /*0x262b7f4*/ StreamingAssetsHelper();
        static /*0x262b4b8*/ UnityEngine.AndroidJavaClass get_UnityPlayerClass();
        static /*0x262b590*/ UnityEngine.AndroidJavaObject get_CurrentActivity();
        static /*0x262b668*/ bool FileExists(string filePath);
    }

    class DictionaryList<TKey, TValue>
    {
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> _dataDic;
        /*0x0*/ System.Collections.Generic.List<TKey> _dataKeyList;
        /*0x0*/ System.Collections.Generic.List<TValue> _dataValueList;

        DictionaryList();
        int get_Count();
        System.Collections.Generic.List<TKey> get_KeyList();
        System.Collections.Generic.List<TValue> get_ValueList();
        void Add(TKey key, TValue val);
        void Remove(TKey key);
        bool TryGetValue(TKey key, ref TValue val);
        void Clear();
        bool ContainsKey(TKey key);
        int GetIdx(TKey key);
        void set_Item(TKey key, TValue value);
        TValue get_Item(TKey key);
    }

    class DoubleMap<K, V>
    {
        /*0x0*/ System.Collections.Generic.Dictionary<K, V> kv;
        /*0x0*/ System.Collections.Generic.Dictionary<V, K> vk;

        DoubleMap();
        DoubleMap(int capacity);
        void ForEach(System.Action<K, V> action);
        System.Collections.Generic.List<K> get_Keys();
        System.Collections.Generic.List<V> get_Values();
        void Add(K key, V value);
        V GetValueByKey(K key);
        K GetKeyByValue(V value);
        void RemoveByKey(K key);
        void RemoveByValue(V value);
        void Clear();
        bool ContainsKey(K key);
        bool ContainsValue(V value);
        bool Contains(K key, V value);
    }

    struct LinkedListRange<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        /*0x0*/ System.Collections.Generic.LinkedListNode<T> m_First;
        /*0x0*/ System.Collections.Generic.LinkedListNode<T> m_Terminal;

        LinkedListRange(System.Collections.Generic.LinkedListNode<T> first, System.Collections.Generic.LinkedListNode<T> terminal);
        bool get_IsValid();
        System.Collections.Generic.LinkedListNode<T> get_First();
        System.Collections.Generic.LinkedListNode<T> get_Terminal();
        int get_Count();
        bool Contains(T value);
        Framework.LinkedListRange.Enumerator<T> GetEnumerator();
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ Framework.LinkedListRange<T> _mLinkedListRange;
            /*0x0*/ System.Collections.Generic.LinkedListNode<T> m_Current;
            /*0x0*/ T m_CurrentValue;

            Enumerator(Framework.LinkedListRange<T> range);
            T get_Current();
            object System.Collections.IEnumerator.get_Current();
            void Dispose();
            bool MoveNext();
            void System.Collections.IEnumerator.Reset();
        }
    }

    class MultiDictionary<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, Framework.LinkedListRange<TValue>>>, System.Collections.IEnumerable
    {
        /*0x0*/ System.Collections.Generic.LinkedList<TValue> m_LinkedList;
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, Framework.LinkedListRange<TValue>> m_Dictionary;

        MultiDictionary();
        int get_Count();
        Framework.LinkedListRange<TValue> get_Item(TKey key);
        void Clear();
        bool Contains(TKey key);
        bool Contains(TKey key, TValue value);
        bool TryGetValue(TKey key, ref Framework.LinkedListRange<TValue> range);
        void Add(TKey key, TValue value);
        bool Remove(TKey key, TValue value);
        bool RemoveAll(TKey key);
        Framework.MultiDictionary.Enumerator<TKey, TValue> GetEnumerator();
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, Framework.LinkedListRange<TValue>>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,Framework.LinkedListRange<TValue>>>.GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, Framework.LinkedListRange<TValue>>>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<TKey, Framework.LinkedListRange<TValue>> m_Enumerator;

            Enumerator(System.Collections.Generic.Dictionary<TKey, Framework.LinkedListRange<TValue>> dictionary);
            System.Collections.Generic.KeyValuePair<TKey, Framework.LinkedListRange<TValue>> get_Current();
            object System.Collections.IEnumerator.get_Current();
            void Dispose();
            bool MoveNext();
            void System.Collections.IEnumerator.Reset();
        }
    }

    class StackList<T>
    {
        /*0x0*/ System.Collections.Generic.Stack<T> DataStack;
        /*0x0*/ System.Collections.Generic.List<T> DataList;

        StackList();
        int get_Count();
        void Push(T t);
        T Pop();
        T Peek();
        void RemoveData(T t);
        bool Contains(T t);
        void Clear();
        void RemoveFromStack(T t);
        void RemoveFromList(T t);
    }

    class UnOrderMultiMapSet<T, K> : System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<K>>
    {
        UnOrderMultiMapSet();
        System.Collections.Generic.HashSet<K> get_Item(T t);
        System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<K>> GetDictionary();
        void Add(T t, K k);
        bool Remove(T t, K k);
        bool Contains(T t, K k);
        int get_Count();
    }

    class VarBoolean : Framework.Variable<bool>
    {
        static /*0x262b8cc*/ Framework.VarBoolean op_Implicit(bool value);
        static /*0x262b954*/ bool op_Implicit(Framework.VarBoolean value);
        /*0x262b884*/ VarBoolean();
    }

    class VarByte : Framework.Variable<byte>
    {
        static /*0x262b9e0*/ Framework.VarByte op_Implicit(byte value);
        static /*0x262ba64*/ byte op_Implicit(Framework.VarByte value);
        /*0x262b998*/ VarByte();
    }

    class VarByteArray : Framework.Variable<System.Byte[]>
    {
        static /*0x262baf0*/ Framework.VarByteArray op_Implicit(byte[] value);
        static /*0x262bb74*/ byte[] op_Implicit(Framework.VarByteArray value);
        /*0x262baa8*/ VarByteArray();
    }

    class VarChar : Framework.Variable<char>
    {
        static /*0x262bc00*/ Framework.VarChar op_Implicit(char value);
        static /*0x262bc84*/ char op_Implicit(Framework.VarChar value);
        /*0x262bbb8*/ VarChar();
    }

    class VarCharArray : Framework.Variable<System.Char[]>
    {
        static /*0x262bd10*/ Framework.VarCharArray op_Implicit(char[] value);
        static /*0x262bd94*/ char[] op_Implicit(Framework.VarCharArray value);
        /*0x262bcc8*/ VarCharArray();
    }

    class VarColor : Framework.Variable<UnityEngine.Color>
    {
        static /*0x262be20*/ Framework.VarColor op_Implicit(UnityEngine.Color value);
        static /*0x262bec4*/ UnityEngine.Color op_Implicit(Framework.VarColor value);
        /*0x262bdd8*/ VarColor();
    }

    class VarColor32 : Framework.Variable<UnityEngine.Color32>
    {
        static /*0x262bf54*/ Framework.VarColor32 op_Implicit(UnityEngine.Color32 value);
        static /*0x262bfd8*/ UnityEngine.Color32 op_Implicit(Framework.VarColor32 value);
        /*0x262bf0c*/ VarColor32();
    }

    class VarDateTime : Framework.Variable<System.DateTime>
    {
        static /*0x262c064*/ Framework.VarDateTime op_Implicit(System.DateTime value);
        static /*0x262c0e8*/ System.DateTime op_Implicit(Framework.VarDateTime value);
        /*0x262c01c*/ VarDateTime();
    }

    class VarDecimal : Framework.Variable<decimal>
    {
        static /*0x262c174*/ Framework.VarDecimal op_Implicit(decimal value);
        static /*0x262c204*/ decimal op_Implicit(Framework.VarDecimal value);
        /*0x262c12c*/ VarDecimal();
    }

    class VarDict<K, V> : Framework.VariableDict<K, V>
    {
        static Framework.VarDict<K, V> op_Implicit(System.Collections.Generic.Dictionary<K, V> value);
        static System.Collections.Generic.Dictionary<K, V> op_Implicit(Framework.VarDict<K, V> value);
        VarDict();
    }

    class VarDouble : Framework.Variable<double>
    {
        static /*0x262c290*/ Framework.VarDouble op_Implicit(double value);
        static /*0x262c31c*/ double op_Implicit(Framework.VarDouble value);
        /*0x262c248*/ VarDouble();
    }

    class VarGameObject : Framework.Variable<UnityEngine.GameObject>
    {
        static /*0x262c3a8*/ Framework.VarGameObject op_Implicit(UnityEngine.GameObject value);
        static /*0x262c42c*/ UnityEngine.GameObject op_Implicit(Framework.VarGameObject value);
        /*0x262c360*/ VarGameObject();
    }

    class VarInt16 : Framework.Variable<short>
    {
        static /*0x262c4b8*/ Framework.VarInt16 op_Implicit(short value);
        static /*0x262c53c*/ short op_Implicit(Framework.VarInt16 value);
        /*0x262c470*/ VarInt16();
    }

    class VarInt32 : Framework.Variable<int>
    {
        static /*0x262c5c8*/ Framework.VarInt32 op_Implicit(int value);
        static /*0x262c64c*/ int op_Implicit(Framework.VarInt32 value);
        /*0x262c580*/ VarInt32();
    }

    class VarInt64 : Framework.Variable<long>
    {
        static /*0x262c6d8*/ Framework.VarInt64 op_Implicit(long value);
        static /*0x262c75c*/ long op_Implicit(Framework.VarInt64 value);
        /*0x262c690*/ VarInt64();
    }

    class VarList<T> : Framework.VariableList<T>
    {
        static Framework.VarList<T> op_Implicit(System.Collections.Generic.List<T> value);
        static System.Collections.Generic.List<T> op_Implicit(Framework.VarList<T> value);
        VarList();
    }

    class VarMaterial : Framework.Variable<UnityEngine.Material>
    {
        static /*0x262c7e8*/ Framework.VarMaterial op_Implicit(UnityEngine.Material value);
        static /*0x262c86c*/ UnityEngine.Material op_Implicit(Framework.VarMaterial value);
        /*0x262c7a0*/ VarMaterial();
    }

    class VarObject : Framework.Variable<object>
    {
        /*0x262c8b0*/ VarObject();
    }

    class VarQuaternion : Framework.Variable<UnityEngine.Quaternion>
    {
        static /*0x262c940*/ Framework.VarQuaternion op_Implicit(UnityEngine.Quaternion value);
        static /*0x262c9e4*/ UnityEngine.Quaternion op_Implicit(Framework.VarQuaternion value);
        /*0x262c8f8*/ VarQuaternion();
    }

    class VarRect : Framework.Variable<UnityEngine.Rect>
    {
        static /*0x262ca74*/ Framework.VarRect op_Implicit(UnityEngine.Rect value);
        static /*0x262cb18*/ UnityEngine.Rect op_Implicit(Framework.VarRect value);
        /*0x262ca2c*/ VarRect();
    }

    class VarSByte : Framework.Variable<sbyte>
    {
        static /*0x262cba8*/ Framework.VarSByte op_Implicit(sbyte value);
        static /*0x262cc2c*/ sbyte op_Implicit(Framework.VarSByte value);
        /*0x262cb60*/ VarSByte();
    }

    class VarSingle : Framework.Variable<float>
    {
        static /*0x262ccb8*/ Framework.VarSingle op_Implicit(float value);
        static /*0x262cd44*/ float op_Implicit(Framework.VarSingle value);
        /*0x262cc70*/ VarSingle();
    }

    class VarString : Framework.Variable<string>
    {
        static /*0x262cdd0*/ Framework.VarString op_Implicit(string value);
        static /*0x262ce54*/ string op_Implicit(Framework.VarString value);
        /*0x262cd88*/ VarString();
    }

    class VarTexture : Framework.Variable<UnityEngine.Texture>
    {
        static /*0x262cee0*/ Framework.VarTexture op_Implicit(UnityEngine.Texture value);
        static /*0x262cf64*/ UnityEngine.Texture op_Implicit(Framework.VarTexture value);
        /*0x262ce98*/ VarTexture();
    }

    class VarTransform : Framework.Variable<UnityEngine.Transform>
    {
        static /*0x262cff0*/ Framework.VarTransform op_Implicit(UnityEngine.Transform value);
        static /*0x262d074*/ UnityEngine.Transform op_Implicit(Framework.VarTransform value);
        /*0x262cfa8*/ VarTransform();
    }

    class VarUInt16 : Framework.Variable<ushort>
    {
        static /*0x262d100*/ Framework.VarUInt16 op_Implicit(ushort value);
        static /*0x262d184*/ ushort op_Implicit(Framework.VarUInt16 value);
        /*0x262d0b8*/ VarUInt16();
    }

    class VarUInt32 : Framework.Variable<uint>
    {
        static /*0x262d210*/ Framework.VarUInt32 op_Implicit(uint value);
        static /*0x262d294*/ uint op_Implicit(Framework.VarUInt32 value);
        /*0x262d1c8*/ VarUInt32();
    }

    class VarUInt64 : Framework.Variable<ulong>
    {
        static /*0x262d320*/ Framework.VarUInt64 op_Implicit(ulong value);
        static /*0x262d3a4*/ ulong op_Implicit(Framework.VarUInt64 value);
        /*0x262d2d8*/ VarUInt64();
    }

    class VarUnityObject : Framework.Variable<UnityEngine.Object>
    {
        static /*0x262d430*/ Framework.VarUnityObject op_Implicit(UnityEngine.Object value);
        static /*0x262d4b4*/ UnityEngine.Object op_Implicit(Framework.VarUnityObject value);
        /*0x262d3e8*/ VarUnityObject();
    }

    class VarVector2 : Framework.Variable<UnityEngine.Vector2>
    {
        static /*0x262d540*/ Framework.VarVector2 op_Implicit(UnityEngine.Vector2 value);
        static /*0x262d5d0*/ UnityEngine.Vector2 op_Implicit(Framework.VarVector2 value);
        /*0x262d4f8*/ VarVector2();
    }

    class VarVector3 : Framework.Variable<UnityEngine.Vector3>
    {
        static /*0x262d65c*/ Framework.VarVector3 op_Implicit(UnityEngine.Vector3 value);
        static /*0x262d6fc*/ UnityEngine.Vector3 op_Implicit(Framework.VarVector3 value);
        /*0x262d614*/ VarVector3();
    }

    class VarVector4 : Framework.Variable<UnityEngine.Vector4>
    {
        static /*0x262d78c*/ Framework.VarVector4 op_Implicit(UnityEngine.Vector4 value);
        static /*0x262d830*/ UnityEngine.Vector4 op_Implicit(Framework.VarVector4 value);
        /*0x262d744*/ VarVector4();
    }

    class Variable<T> : Framework.Variable
    {
        /*0x0*/ T m_Value;

        Variable();
        System.Type get_Type();
        T get_Value();
        void set_Value(T value);
        object GetValue();
        void SetValue(object value);
        void Clear();
        string ToString();
    }

    class VariableDict<K, V> : Framework.Variable
    {
        /*0x0*/ System.Collections.Generic.Dictionary<K, V> m_Value;

        VariableDict();
        System.Type get_Type();
        System.Collections.Generic.Dictionary<K, V> get_Value();
        void set_Value(System.Collections.Generic.Dictionary<K, V> value);
        void set_Item(K k, V value);
        V get_Item(K k);
        void Add(K k, V v);
        void Remove(K k);
        bool ContainsKey(K k);
        object GetValue();
        void SetValue(object value);
        void Clear();
        string ToString();
    }

    class VariableList<T> : Framework.Variable
    {
        /*0x0*/ System.Collections.Generic.List<T> m_Value;

        VariableList();
        System.Type get_Type();
        System.Collections.Generic.List<T> get_Value();
        void set_Value(System.Collections.Generic.List<T> value);
        void set_Item(int index, T value);
        T get_Item(int index);
        void Add(T t);
        void Remove(T t);
        void RemoveAt(int index);
        int Count();
        object GetValue();
        void SetValue(object value);
        void Clear();
        string ToString();
    }

    class Variable
    {
        /*0x262d878*/ Variable();
        System.Type get_Type();
        object GetValue();
        void SetValue(object value);
        void Clear();
    }

    class SingletonMono<T> : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ T _Instance;

        static T get_Instance();
        static T GetInstance();
        static bool get_haveInstance();
        SingletonMono();
    }

    interface IStateNode
    {
        void OnCreate(Framework.StateMachine machine);
        void OnEnter();
        void OnUpdate();
        void OnExit();
    }

    class StateMachine
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, object> _blackboard;
        /*0x18*/ System.Collections.Generic.Dictionary<string, Framework.IStateNode> _nodes;
        /*0x20*/ Framework.IStateNode _curNode;
        /*0x28*/ Framework.IStateNode _preNode;
        /*0x30*/ object <Owner>k__BackingField;

        /*0x262d988*/ StateMachine();
        /*0x262da50*/ StateMachine(object owner);
        /*0x262d880*/ void set_Owner(object value);
        /*0x262d888*/ object get_Owner();
        /*0x262d890*/ string get_CurrentNode();
        /*0x262d90c*/ string get_PreviousNode();
        /*0x262db2c*/ void Update();
        void Run<TNode>();
        /*0x262dbd8*/ void Run(System.Type entryNode);
        /*0x262dc10*/ void Run(string entryNode);
        void AddNode<TNode>();
        /*0x262dd90*/ void AddNode(Framework.IStateNode stateNode);
        void ChangeState<TNode>();
        /*0x262df54*/ void ChangeState(System.Type nodeType);
        /*0x262df8c*/ void ChangeState(string nodeName);
        /*0x262e224*/ void SetBlackboardValue(string key, object value);
        /*0x262e2f0*/ object GetBlackboardValue(string key);
        /*0x262dd20*/ Framework.IStateNode TryGetNode(string nodeName);
    }

    class AStaticMethod
    {
        /*0x262e3c8*/ AStaticMethod();
        void Run(object[] param);
    }

    class MonoStaticMethod : Framework.AStaticMethod
    {
        /*0x10*/ System.Reflection.MethodInfo mMethodInfo;
        /*0x18*/ object[] mParam;

        /*0x262e3d0*/ MonoStaticMethod(System.Reflection.Assembly assembly, string typeName, string methodName);
        /*0x262e5ac*/ void Run(object[] param);
    }

    class SwitchClickEvent : UnityEngine.Events.UnityEvent<bool>
    {
        /*0x262e74c*/ SwitchClickEvent();
    }

    class SwitchClickButton : UnityEngine.UI.Button
    {
        /*0x100*/ Framework.SwitchClickEvent switchClick;

        /*0x262e87c*/ SwitchClickButton();
        /*0x262e794*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x262e804*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x262e874*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class GroupBase : EnhancedUI.EnhancedScroller.EnhancedScrollerCellView
    {
        /*0x2c*/ int groupIndex;
        /*0x30*/ int groupStart;
        /*0x34*/ int groupEnd;
        /*0x38*/ int gridCount;
        /*0x3c*/ UnityEngine.Vector3 groupSize;
        /*0x48*/ Framework.ScrollerPro scrollerPro;

        /*0x262eb48*/ GroupBase();
        /*0x262e884*/ void InitGroup(Framework.ScrollerPro scrollerPro, UnityEngine.Transform itemPrefab);
        /*0x262e9d8*/ void SetGroup(int groupIndex, int groupStart, int groupEnd);
        /*0x262e9e4*/ void RefreshCellView();
    }

    enum PivotHorizontal
    {
        Left = 0,
        Center = 1,
        Middle = 2,
        Right = 3,
    }

    enum PivotVerticle
    {
        Top = 0,
        Center = 1,
        Middle = 2,
        Bottom = 3,
    }

    class ScrollerPro : EnhancedUI.EnhancedScroller.EnhancedScroller, EnhancedUI.EnhancedScroller.IEnhancedScrollerDelegate
    {
        /*0x180*/ System.Action<Framework.GroupBase, int, int> GetObjectHandler;
        /*0x188*/ System.Action<int> ReturnObjectHandler;
        /*0x190*/ System.Action<int> ProvideDataHandler;
        /*0x198*/ System.Func<int, int> GetGroupSizeHandler;
        /*0x1a0*/ System.Func<int> GetDataCountHandler;
        /*0x1a8*/ Framework.PivotHorizontal pivotHorizontal;
        /*0x1ac*/ Framework.PivotVerticle pivotVertical;
        /*0x1b0*/ bool needScroller;
        /*0x1b8*/ Framework.GroupBase groupPrefab;
        /*0x1c0*/ UnityEngine.Vector2 _groupSize;
        /*0x1c8*/ bool isGrid;
        /*0x1cc*/ int _numberOfCellsPerRow;

        /*0x262f16c*/ ScrollerPro();
        /*0x262eb50*/ UnityEngine.Vector2 get_GroupSize();
        /*0x262ec30*/ int get_NumberOfCellsPerRow();
        /*0x262e9d4*/ EnhancedUI.EnhancedScroller.EnhancedScroller get_Scroller();
        /*0x262ec60*/ void Awake();
        /*0x262ed4c*/ void SetScroll(bool enable);
        /*0x262ee08*/ EnhancedUI.EnhancedScroller.EnhancedScrollerCellView GetCellView(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex, int cellIndex);
        /*0x262efd4*/ float GetCellViewSize(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, int dataIndex);
        /*0x262f00c*/ int GetNumberOfCells(EnhancedUI.EnhancedScroller.EnhancedScroller scroller);
        /*0x262f0c4*/ void CellViewVisibilityChanged(EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
        /*0x262f140*/ void CellViewInstantiated(EnhancedUI.EnhancedScroller.EnhancedScroller scroller, EnhancedUI.EnhancedScroller.EnhancedScrollerCellView cellView);
    }

    class ScrollerProEx : UnityEngine.UI.ScrollRect
    {
        /*0x128*/ bool routeToParent;

        /*0x262f658*/ ScrollerProEx();
        void DoForParents<T>(System.Action<T> action);
        /*0x262f1d0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x262f2bc*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x262f3bc*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x262f558*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);

        class <>c__DisplayClass2_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x262f2b4*/ <>c__DisplayClass2_0();
            /*0x262f660*/ void <OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x262f3b4*/ <>c__DisplayClass3_0();
            /*0x262f708*/ void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x262f550*/ <>c__DisplayClass4_0();
            /*0x262f7b0*/ void <OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x262f650*/ <>c__DisplayClass5_0();
            /*0x262f858*/ void <OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent);
        }
    }

    class Init : UnityEngine.MonoBehaviour
    {
        /*0x2630274*/ Init();
        /*0x262f900*/ void Start();
        /*0x262fe94*/ void OnAndroidCallback(string jsonstr);
        /*0x263016c*/ void OnIOSCallback(string jsonStr);
        /*0x2630028*/ void HandleLog(MSDKLog msg);
    }

    class BundleStream : System.IO.FileStream
    {
        static byte KEY = 64;

        /*0x263027c*/ BundleStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, bool useAsync);
        /*0x263031c*/ BundleStream(string path, System.IO.FileMode mode);
        /*0x263038c*/ int Read(byte[] array, int offset, int count);
    }

    class FsmClearCache : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x2630874*/ FsmClearCache();
        /*0x26303ec*/ void OnCreate(Framework.StateMachine machine);
        /*0x26303f4*/ void OnEnter();
        /*0x263081c*/ void OnUpdate();
        /*0x2630820*/ void OnExit();
        /*0x2630824*/ void Operation_Completed(YooAsset.AsyncOperationBase obj);
    }

    class FsmCreateDownloader : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x2630a20*/ FsmCreateDownloader();
        /*0x263087c*/ void OnCreate(Framework.StateMachine machine);
        /*0x2630884*/ void OnEnter();
        /*0x26309f0*/ void OnUpdate();
        /*0x26309f4*/ void OnExit();
        /*0x2630988*/ System.Collections.IEnumerator CreateDownloader();

        class <CreateDownloader>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmCreateDownloader <>4__this;

            /*0x26309f8*/ <CreateDownloader>d__5(int <>1__state);
            /*0x2630a28*/ void System.IDisposable.Dispose();
            /*0x2630a2c*/ bool MoveNext();
            /*0x2630e54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2630e5c*/ void System.Collections.IEnumerator.Reset();
            /*0x2630e9c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FsmDownloadFiles : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x2631048*/ FsmDownloadFiles();
        /*0x2630ea4*/ void OnCreate(Framework.StateMachine machine);
        /*0x2630eac*/ void OnEnter();
        /*0x2631018*/ void OnUpdate();
        /*0x263101c*/ void OnExit();
        /*0x2630fb0*/ System.Collections.IEnumerator BeginDownload();

        class <BeginDownload>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmDownloadFiles <>4__this;
            /*0x28*/ YooAsset.ResourceDownloaderOperation <downloader>5__2;

            /*0x2631020*/ <BeginDownload>d__5(int <>1__state);
            /*0x2631050*/ void System.IDisposable.Dispose();
            /*0x2631054*/ bool MoveNext();
            /*0x263123c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2631244*/ void System.Collections.IEnumerator.Reset();
            /*0x2631284*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FsmDownloadOver : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x26312ec*/ FsmDownloadOver();
        /*0x263128c*/ void OnCreate(Framework.StateMachine machine);
        /*0x2631294*/ void OnEnter();
        /*0x26312e4*/ void OnUpdate();
        /*0x26312e8*/ void OnExit();
    }

    class FsmGetNotice : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x263176c*/ FsmGetNotice();
        /*0x26312f4*/ void OnCreate(Framework.StateMachine machine);
        /*0x26312fc*/ void OnEnter();
        /*0x2631684*/ System.Collections.IEnumerator GetNoticeInfo();
        /*0x2631714*/ void NextState();
        /*0x2631764*/ void OnUpdate();
        /*0x2631768*/ void OnExit();

        class <GetNoticeInfo>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmGetNotice <>4__this;

            /*0x26316ec*/ <GetNoticeInfo>d__3(int <>1__state);
            /*0x2631774*/ void System.IDisposable.Dispose();
            /*0x2631778*/ bool MoveNext();
            /*0x2631874*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263187c*/ void System.Collections.IEnumerator.Reset();
            /*0x26318bc*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class ABEncrypt
    {
        static string EncryptHead = "AceAce";
        static int EncryptHeadLength = 6;
        static /*0x0*/ byte[] key;

        static /*0x2631cdc*/ ABEncrypt();
        static /*0x26318c4*/ byte[] EncryptFile(string path);
        static /*0x26319ac*/ byte[] EncryptFile(byte[] bytes);
        static /*0x2631a84*/ byte[] DecodeFile(string path);
        static /*0x2631bbc*/ byte[] DecodeFile(byte[] bytes);
    }

    class FsmInitialize : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;
        /*0x18*/ YooAsset.EPlayMode <mPlayMode>k__BackingField;

        /*0x263240c*/ FsmInitialize();
        /*0x2631d54*/ void set_mPlayMode(YooAsset.EPlayMode value);
        /*0x2631d5c*/ YooAsset.EPlayMode get_mPlayMode();
        /*0x2631d64*/ void OnCreate(Framework.StateMachine machine);
        /*0x2631d6c*/ void OnEnter();
        /*0x2631ed8*/ void OnUpdate();
        /*0x2631edc*/ void OnExit();
        /*0x2631e70*/ System.Collections.IEnumerator InitPackage();
        /*0x2631f08*/ string GetHostServerURL();

        class <InitPackage>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmInitialize <>4__this;
            /*0x28*/ YooAsset.InitializationOperation <initializationOperation>5__2;

            /*0x2631ee0*/ <InitPackage>d__9(int <>1__state);
            /*0x263241c*/ void System.IDisposable.Dispose();
            /*0x2632420*/ bool MoveNext();
            /*0x2632a44*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2632a4c*/ void System.Collections.IEnumerator.Reset();
            /*0x2632a8c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FileQueryServices : YooAsset.IQueryServices
    {
        /*0x26329a4*/ FileQueryServices();
        /*0x2632a94*/ bool QueryStreamingAssets(string fileName);
    }

    class FileDecryptionServices : YooAsset.IDecryptionServices
    {
        /*0x263299c*/ FileDecryptionServices();
        /*0x2632b44*/ ulong LoadFromFileOffset(YooAsset.DecryptFileInfo fileInfo);
        /*0x2632b4c*/ byte[] LoadFromMemory(YooAsset.DecryptFileInfo fileInfo);
        /*0x2632ba0*/ System.IO.Stream LoadFromStream(YooAsset.DecryptFileInfo fileInfo);
        /*0x2632c04*/ uint GetManagedReadBufferSize();
    }

    class FileEncryptionServices : YooAsset.IEncryptionServices
    {
        static string abPath = "Assets/Resources/ABEncrypt.json";

        /*0x2633674*/ FileEncryptionServices();
        /*0x2632c0c*/ YooAsset.EncryptResult Encrypt(YooAsset.EncryptFileInfo fileInfo);
    }

    class FsmPatchDone : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x26348c0*/ FsmPatchDone();
        /*0x263367c*/ void OnCreate(Framework.StateMachine machine);
        /*0x2633684*/ void OnEnter();
        /*0x2633754*/ void OnUpdate();
        /*0x2633758*/ void OnExit();
        /*0x26336ec*/ System.Collections.IEnumerator LoadInitialize();
        /*0x2633784*/ void RestartApplication();
        /*0x2633dc0*/ void LoadAndRun();
        /*0x2634788*/ void Run();

        class <LoadInitialize>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmPatchDone <>4__this;

            /*0x263375c*/ <LoadInitialize>d__5(int <>1__state);
            /*0x26348c8*/ void System.IDisposable.Dispose();
            /*0x26348cc*/ bool MoveNext();
            /*0x26354e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x26354f0*/ void System.Collections.IEnumerator.Reset();
            /*0x2635530*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FsmUpdateManifest : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x26356dc*/ FsmUpdateManifest();
        /*0x2635538*/ void OnCreate(Framework.StateMachine machine);
        /*0x2635540*/ void OnEnter();
        /*0x26356ac*/ void OnUpdate();
        /*0x26356b0*/ void OnExit();
        /*0x2635644*/ System.Collections.IEnumerator UpdateManifest();

        class <UpdateManifest>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmUpdateManifest <>4__this;
            /*0x28*/ YooAsset.UpdatePackageManifestOperation <operation>5__2;

            /*0x26356b4*/ <UpdateManifest>d__5(int <>1__state);
            /*0x26356e4*/ void System.IDisposable.Dispose();
            /*0x26356e8*/ bool MoveNext();
            /*0x2635a14*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2635a1c*/ void System.Collections.IEnumerator.Reset();
            /*0x2635a5c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FsmUpdateVersion : Framework.IStateNode
    {
        /*0x10*/ Framework.StateMachine _machine;

        /*0x2635c08*/ FsmUpdateVersion();
        /*0x2635a64*/ void OnCreate(Framework.StateMachine machine);
        /*0x2635a6c*/ void OnEnter();
        /*0x2635bd8*/ void OnUpdate();
        /*0x2635bdc*/ void OnExit();
        /*0x2635b70*/ System.Collections.IEnumerator GetStaticVersion();

        class <GetStaticVersion>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.FsmUpdateVersion <>4__this;
            /*0x28*/ YooAsset.UpdatePackageVersionOperation <operation>5__2;

            /*0x2635be0*/ <GetStaticVersion>d__5(int <>1__state);
            /*0x2635c10*/ void System.IDisposable.Dispose();
            /*0x2635c14*/ bool MoveNext();
            /*0x2635ef8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2635f00*/ void System.Collections.IEnumerator.Reset();
            /*0x2635f40*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class Launcher : Framework.SingletonMono<Framework.Launcher>, Framework.IEventListener
    {
        static bool UseACE_AnoSdk = false;
        static string CrashSightUploadUrlAndroid_wetest = "https://android.crashsight.wetest.net/pb/async";
        static string CrashSightUploadUrlAndroid_qq = "https://android.crashsight.qq.com/pb/async";
        static string CrashSightAppIDForAndroid = "99d32aed33";
        static string CrashSightUploadUrlIOS_wetest = "https://ios.crashsight.wetest.net/pb/sync";
        static string CrashSightAppIDForIOS = "5a68396f8d";
        static string configBuild = "GameConfig_Build.txt";
        static string configVersion = "GameConfig_Version.txt";
        static string configLanguage = "GameConfig_Language.txt";
        static int FPS_HIGH = 60;
        static int FPS_DEFAULT = 60;
        static int FPS_PVE = 30;
        static int FPS_LOADING = 15;
        static string DefaultPackage = "GamePackage";
        static string ALLLanguageKey = "ALLLanguage";
        static string CacheLanguageKey = "MutiLanguage";
        static string DefaultFont = "Alibaba-PuHuiTi-Heavy SDF";
        static /*0x0*/ Framework.EInitRunMode RunMode;
        /*0x18*/ System.Action ActionFixedUpdate;
        /*0x20*/ System.Action ActionUpdate;
        /*0x28*/ System.Action ActionLateUpdate;
        /*0x30*/ System.Action<bool> ApplicationPause;
        /*0x38*/ System.Action<bool> ApplicationFocus;
        /*0x40*/ System.Action ActionClose;
        /*0x48*/ System.Action ActionOnDrawGizmos;
        /*0x50*/ GameConfig mGameConfig;
        /*0x58*/ float standardDeltaTime;
        /*0x5c*/ bool reCheckVersionUpdate;
        /*0x60*/ int mSvrChannel;
        /*0x64*/ int mSvrVersion;
        /*0x68*/ string mSvrLoginServer;
        /*0x70*/ System.Collections.Generic.List<string> mSvrLoginServerList;
        /*0x78*/ string mSvrResourceServerUrl;
        /*0x80*/ int mSvrResVersion;
        /*0x88*/ string mSvrAppForceUpdateUrl;
        /*0x90*/ string noticeUrl;
        /*0x98*/ int mWebRequestErrorCnt;
        /*0x9c*/ int mCenterServerIndex;
        /*0xa0*/ int RequestCenterServerAcc;
        /*0xa8*/ System.Collections.Generic.List<string> mCenterServerAddressLsit;
        /*0xb0*/ bool RequestCenterServerSucc;
        /*0xb1*/ bool mRestartOver;
        /*0xb8*/ UnityEngine.Coroutine mCoroutine;
        /*0xc0*/ Framework.LauncherStartState <LStartState>k__BackingField;
        /*0xc4*/ bool <GameStarted>k__BackingField;
        /*0xc8*/ System.Reflection.Assembly hotfixAssembly;
        /*0xd0*/ System.Collections.Generic.Dictionary<string, System.Type> HotfixTypeDict;
        /*0xd8*/ string <PackageVersion>k__BackingField;
        /*0xe0*/ YooAsset.ResourceDownloaderOperation <Downloader>k__BackingField;
        /*0xe8*/ Framework.StateMachine mUpdateFSM;
        /*0xf0*/ string _languageTxt;
        /*0xf8*/ bool _localizationHasBeenSet;
        /*0x100*/ System.Collections.Generic.Dictionary<string, string> _languageDict;
        /*0x108*/ string _curLanguage;
        /*0x110*/ System.Collections.Generic.List<string> languages;
        /*0x118*/ string AnnouncementSave;
        /*0x120*/ bool NoticeSucc;
        /*0x128*/ string NoticeBoardSave;
        /*0x130*/ bool NoticeBoardSucc;
        /*0x138*/ string NoticeWhiteListSave;
        /*0x140*/ bool NoticeWhiteListSucc;
        /*0x141*/ bool IgnoreNoticeBoardOnce;
        /*0x148*/ string forceUpdateDesc;

        static /*0x2636028*/ void InitCrashSightAndroid();
        static /*0x2636250*/ void InitCrashSightIOS();
        static /*0x2636254*/ void CheckCrashSightInit(int mode);
        static /*0x26323bc*/ GameConfig get_GameConfig();
        static /*0x2637604*/ bool IsInGameTest();
        /*0x2639648*/ Launcher();
        /*0x2635f48*/ void InitACE();
        /*0x2635f4c*/ void AnoUserLogin(int accountType, string account);
        /*0x2635f50*/ void AnoSdkHandleApplicationPause(bool pause);
        /*0x2635f54*/ void AnoPrivacyIoctl();
        /*0x2635f58*/ void AnoCloseIoctl();
        /*0x2635f5c*/ void FixedUpdate();
        /*0x2635f78*/ void Update();
        /*0x2635f94*/ void LateUpdate();
        /*0x2635fb0*/ void OnApplicationPause(bool pause);
        /*0x2635fd0*/ void OnApplicationFocus(bool focus);
        /*0x2635ff0*/ void OnApplicationQuit();
        /*0x263600c*/ void OnDrawGizmos();
        /*0x2636364*/ System.Collections.IEnumerator InitGameConfig();
        /*0x26363f4*/ System.Collections.IEnumerator LoadBuildConfig();
        /*0x2636484*/ System.Collections.IEnumerator LoadVersionConfig();
        /*0x2636514*/ System.Collections.IEnumerator LoadLanguageConfig();
        /*0x26365a4*/ void ChangeFPS();
        /*0x26365d8*/ string GetCenterServerAddress();
        /*0x2636778*/ void ResetCenterServerAddress();
        /*0x2636780*/ System.Collections.IEnumerator RequestCenterServer();
        /*0x2636810*/ System.Collections.IEnumerator GetRemoteVersionList();
        /*0x26368a0*/ void ReadChannelListConfig(string text);
        /*0x2636e20*/ void ReadVersionListConfig(string text);
        /*0x2635158*/ string GetClientVersion();
        /*0x2632944*/ bool IsAuditServer();
        /*0x26375c0*/ void set_LStartState(Framework.LauncherStartState value);
        /*0x26375c8*/ Framework.LauncherStartState get_LStartState();
        /*0x26375d0*/ void set_GameStarted(bool value);
        /*0x26375dc*/ bool get_GameStarted();
        /*0x26375e4*/ void set_PackageVersion(string value);
        /*0x26375ec*/ string get_PackageVersion();
        /*0x26375f4*/ void set_Downloader(YooAsset.ResourceDownloaderOperation value);
        /*0x26375fc*/ YooAsset.ResourceDownloaderOperation get_Downloader();
        /*0x262f9d0*/ void Init();
        /*0x2637654*/ void StartSplash();
        /*0x2637674*/ void StartLoad();
        /*0x2637694*/ System.Collections.IEnumerator LoadLocalConfig();
        /*0x2637724*/ void StartServerLoad();
        /*0x2637764*/ System.Collections.IEnumerator LoadCoroutine();
        /*0x26377f4*/ void StartDownloadUpdate();
        /*0x2637c04*/ string GetPlatform();
        /*0x2637c90*/ void HandleEvent(Framework.EventType eventType, Framework.IEventArgs args1, Framework.IEventArgs args2, Framework.IEventArgs args3, Framework.IEventArgs args4);
        /*0x2637d94*/ void Restart();
        /*0x2637dd4*/ System.Collections.IEnumerator ReStartCoroutine();
        /*0x2637e64*/ System.Collections.IEnumerator ReCheckVersionCoroutine();
        /*0x2637ef4*/ void LoadFinish();
        /*0x2637fa8*/ System.Collections.IEnumerator InitLanguage();
        /*0x2638038*/ string get_curLanguage();
        /*0x2638040*/ void set_curLanguage(string value);
        /*0x263809c*/ UnityEngine.SystemLanguage get_curLanguageType();
        /*0x2638124*/ void GetALLLanguages();
        /*0x2634eb4*/ string GetSelectedLanguage();
        /*0x263847c*/ UnityEngine.SystemLanguage GetSystemLanguage();
        /*0x2638484*/ bool SetLanguage(string newLanguage);
        /*0x26350e4*/ System.Collections.IEnumerator UpdateLanguage(string languageName);
        /*0x2638690*/ void OnLanguageAssetLoad(string languageTxt);
        /*0x2638ce4*/ void Set(string languageName);
        /*0x2638974*/ System.Collections.Generic.Dictionary<string, string> ReadDictionary(string txt);
        /*0x2630584*/ string GetLanguage(string key, string[] args);
        /*0x2638cf0*/ void InitFontAsset();
        /*0x2639020*/ void OpenGameNotice(System.Action callback);
        /*0x2639120*/ void OpenGameNoticeBoard(System.Action callback);
        /*0x26390ac*/ System.Collections.IEnumerator GetNotice(System.Action callback);
        /*0x26391b0*/ bool CheckNoticeBoard();
        /*0x263180c*/ System.Collections.IEnumerator GetNoticeBoard();
        /*0x2639404*/ System.Collections.IEnumerator GetNoticeWhiteList();
        /*0x26375b8*/ void SetUpdateInfo(int version, string downloadPackageUrl, string desc);
        /*0x2639494*/ void UpdateNewVersion();
        /*0x26394a0*/ void ForceUpdate();
        /*0x2639600*/ bool CheckIfAppShouldUpdate();
        /*0x2639774*/ void <ForceUpdate>b__143_0();

        class <InitGameConfig>d__34 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;

            /*0x26363cc*/ <InitGameConfig>d__34(int <>1__state);
            /*0x2639780*/ void System.IDisposable.Dispose();
            /*0x2639784*/ bool MoveNext();
            /*0x2639888*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2639890*/ void System.Collections.IEnumerator.Reset();
            /*0x26398d0*/ object System.Collections.IEnumerator.get_Current();
        }

        class <LoadBuildConfig>d__35 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ UnityEngine.Networking.UnityWebRequest <req>5__2;

            /*0x263645c*/ <LoadBuildConfig>d__35(int <>1__state);
            /*0x26398d8*/ void System.IDisposable.Dispose();
            /*0x26398dc*/ bool MoveNext();
            /*0x2639c08*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2639c10*/ void System.Collections.IEnumerator.Reset();
            /*0x2639c50*/ object System.Collections.IEnumerator.get_Current();
        }

        class <LoadVersionConfig>d__36 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ UnityEngine.Networking.UnityWebRequest <req>5__2;

            /*0x26364ec*/ <LoadVersionConfig>d__36(int <>1__state);
            /*0x2639c58*/ void System.IDisposable.Dispose();
            /*0x2639c5c*/ bool MoveNext();
            /*0x2639ff4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2639ffc*/ void System.Collections.IEnumerator.Reset();
            /*0x263a03c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <LoadLanguageConfig>d__37 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ UnityEngine.Networking.UnityWebRequest <req>5__2;

            /*0x263657c*/ <LoadLanguageConfig>d__37(int <>1__state);
            /*0x263a044*/ void System.IDisposable.Dispose();
            /*0x263a048*/ bool MoveNext();
            /*0x263a370*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263a378*/ void System.Collections.IEnumerator.Reset();
            /*0x263a3b8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <RequestCenterServer>d__60 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ string <url>5__2;
            /*0x30*/ UnityEngine.Networking.UnityWebRequest <web>5__3;
            /*0x38*/ int <i>5__4;

            /*0x26367e8*/ <RequestCenterServer>d__60(int <>1__state);
            /*0x263a3c0*/ void System.IDisposable.Dispose();
            /*0x263a3c4*/ bool MoveNext();
            /*0x263ab14*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263ab1c*/ void System.Collections.IEnumerator.Reset();
            /*0x263ab5c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <GetRemoteVersionList>d__61 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ string <url>5__2;
            /*0x30*/ UnityEngine.Networking.UnityWebRequest <web>5__3;
            /*0x38*/ int <i>5__4;

            /*0x2636878*/ <GetRemoteVersionList>d__61(int <>1__state);
            /*0x263ab64*/ void System.IDisposable.Dispose();
            /*0x263ab68*/ bool MoveNext();
            /*0x263b28c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263b294*/ void System.Collections.IEnumerator.Reset();
            /*0x263b2d4*/ object System.Collections.IEnumerator.get_Current();
        }

        class <>c
        {
            static /*0x0*/ Framework.Launcher.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__90_0;

            static /*0x263b2dc*/ <>c();
            /*0x263b340*/ <>c();
            /*0x263b348*/ void <Init>b__90_0(object sender, System.UnhandledExceptionEventArgs e);
        }

        class <LoadLocalConfig>d__93 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;

            /*0x26376fc*/ <LoadLocalConfig>d__93(int <>1__state);
            /*0x263b3c4*/ void System.IDisposable.Dispose();
            /*0x263b3c8*/ bool MoveNext();
            /*0x263bcdc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263bce4*/ void System.Collections.IEnumerator.Reset();
            /*0x263bd24*/ object System.Collections.IEnumerator.get_Current();
        }

        class <LoadCoroutine>d__95 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;

            /*0x26377cc*/ <LoadCoroutine>d__95(int <>1__state);
            /*0x263bd2c*/ void System.IDisposable.Dispose();
            /*0x263bd30*/ bool MoveNext();
            /*0x263c170*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263c178*/ void System.Collections.IEnumerator.Reset();
            /*0x263c1b8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <ReStartCoroutine>d__100 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;

            /*0x2637e3c*/ <ReStartCoroutine>d__100(int <>1__state);
            /*0x263c1c0*/ void System.IDisposable.Dispose();
            /*0x263c1c4*/ bool MoveNext();
            /*0x263c5f4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263c5fc*/ void System.Collections.IEnumerator.Reset();
            /*0x263c63c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <ReCheckVersionCoroutine>d__101 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ bool <isHotfixGameStarted>5__2;

            /*0x2637ecc*/ <ReCheckVersionCoroutine>d__101(int <>1__state);
            /*0x263c644*/ void System.IDisposable.Dispose();
            /*0x263c648*/ bool MoveNext();
            /*0x263cbd8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263cbe0*/ void System.Collections.IEnumerator.Reset();
            /*0x263cc20*/ object System.Collections.IEnumerator.get_Current();
        }

        class <InitLanguage>d__111 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ UnityEngine.ResourceRequest <txtRes>5__2;

            /*0x2638010*/ <InitLanguage>d__111(int <>1__state);
            /*0x263cc28*/ void System.IDisposable.Dispose();
            /*0x263cc2c*/ bool MoveNext();
            /*0x263ce78*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263ce80*/ void System.Collections.IEnumerator.Reset();
            /*0x263cec0*/ object System.Collections.IEnumerator.get_Current();
        }

        class <UpdateLanguage>d__121 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ string languageName;
            /*0x28*/ Framework.Launcher <>4__this;
            /*0x30*/ string <txtBundle>5__2;
            /*0x38*/ UnityEngine.ResourceRequest <txtRes>5__3;

            /*0x2638668*/ <UpdateLanguage>d__121(int <>1__state);
            /*0x263cec8*/ void System.IDisposable.Dispose();
            /*0x263cecc*/ bool MoveNext();
            /*0x263d118*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263d120*/ void System.Collections.IEnumerator.Reset();
            /*0x263d160*/ object System.Collections.IEnumerator.get_Current();
        }

        class <GetNotice>d__135 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ System.Action callback;
            /*0x30*/ string <url>5__2;
            /*0x38*/ UnityEngine.Networking.UnityWebRequest <web>5__3;

            /*0x26393b4*/ <GetNotice>d__135(int <>1__state);
            /*0x263d168*/ void System.IDisposable.Dispose();
            /*0x263d16c*/ bool MoveNext();
            /*0x263d484*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263d48c*/ void System.Collections.IEnumerator.Reset();
            /*0x263d4cc*/ object System.Collections.IEnumerator.get_Current();
        }

        class <GetNoticeBoard>d__138 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ string <url>5__2;
            /*0x30*/ UnityEngine.Networking.UnityWebRequest <web>5__3;

            /*0x26393dc*/ <GetNoticeBoard>d__138(int <>1__state);
            /*0x263d4d4*/ void System.IDisposable.Dispose();
            /*0x263d4d8*/ bool MoveNext();
            /*0x263d80c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263d814*/ void System.Collections.IEnumerator.Reset();
            /*0x263d854*/ object System.Collections.IEnumerator.get_Current();
        }

        class <GetNoticeWhiteList>d__139 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Framework.Launcher <>4__this;
            /*0x28*/ string <url>5__2;
            /*0x30*/ UnityEngine.Networking.UnityWebRequest <web>5__3;

            /*0x263946c*/ <GetNoticeWhiteList>d__139(int <>1__state);
            /*0x263d85c*/ void System.IDisposable.Dispose();
            /*0x263d860*/ bool MoveNext();
            /*0x263db54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x263db5c*/ void System.Collections.IEnumerator.Reset();
            /*0x263db9c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum LauncherStartState
    {
        Official = 0,
        Fetch = 1,
    }

    enum EInitRunMode
    {
        IRM_Normal = 0,
        IRM_InGameTest = 1,
    }

    class AssetDependency
    {
        /*0x10*/ string <ResPath>k__BackingField;
        /*0x18*/ System.Type <ResType>k__BackingField;
        /*0x20*/ YooAsset.AssetOperationHandle <OpHandle>k__BackingField;
        /*0x28*/ UnityEngine.Object mObjectRef;
        /*0x30*/ System.Action<string, UnityEngine.Object> CompleteAction;

        /*0x263df0c*/ AssetDependency();
        /*0x263dba4*/ string get_ResPath();
        /*0x263dbac*/ void set_ResPath(string value);
        /*0x263dbb4*/ System.Type get_ResType();
        /*0x263dbbc*/ void set_ResType(System.Type value);
        /*0x263dbc4*/ YooAsset.AssetOperationHandle get_OpHandle();
        /*0x263dbcc*/ void set_OpHandle(YooAsset.AssetOperationHandle value);
        /*0x263dbd4*/ UnityEngine.Object get_AssetObjectRef();
        /*0x263dbdc*/ UnityEngine.GameObject get_GameObjectRef();
        /*0x263dc3c*/ void UnLoad();
        void SetInfo<T>(string path, System.Action<string, UnityEngine.Object> onComplete);
        /*0x263dce0*/ void AsyncLoad();
        /*0x263de28*/ void OnAsyncLoadEnd(YooAsset.AssetOperationHandle callback);
        void SetInfo<T>(string path);
        /*0x263de74*/ void SyncLoad();
    }

    class AssetDependencyMonoRecord : UnityEngine.MonoBehaviour
    {
        /*0x18*/ System.Collections.Generic.Dictionary<string, Framework.AssetDependency> RecordDic;
        /*0x20*/ int RecordCountDebug;

        /*0x263e184*/ AssetDependencyMonoRecord();
        /*0x263df14*/ void OnDestroy();
        Framework.AssetDependency AsyncLoad<T>(string path, System.Action<string, UnityEngine.Object> onComplete);
        Framework.AssetDependency SyncLoad<T>(string path);
        /*0x263df20*/ void UnLoad(string path);
        /*0x263dfe0*/ void UnLoadAll();
    }

    class AssetManager : Framework.SingletonMono<Framework.AssetManager>
    {
        static string DefaultPackage = "GamePackage";

        /*0x263e5b4*/ AssetManager();
        /*0x263ddc0*/ YooAsset.ResourcePackage get_Package();
        /*0x263cb98*/ void ForceUnloadAllAssets();
        /*0x263e200*/ void UnloadUnusedAssets();
        Framework.AssetDependency StartLoadRes<T>(UnityEngine.GameObject loader, string path, System.Action<string, UnityEngine.Object> onComplete);
        /*0x263e29c*/ Framework.AssetDependency StartLoadGameObject(UnityEngine.GameObject loader, string path, System.Action<string, UnityEngine.Object> onComplete);
        Framework.AssetDependency SyncLoadRes<T>(UnityEngine.GameObject loader, string path);
        /*0x263e30c*/ Framework.AssetDependency SyncLoadGameObject(UnityEngine.GameObject loader, string path);
        /*0x263e36c*/ YooAsset.AssetInfo GetAssetInfo(string path);
        /*0x263e390*/ void LoadRawAssetAsync(string path, System.Action<YooAsset.RawFileOperationHandle> callback);
        /*0x263e44c*/ void UnLoadAsset(UnityEngine.GameObject loader, string path);
        /*0x263e504*/ void UnLoadAll(UnityEngine.GameObject loader);
    }

    class AssetSuffix
    {
        static string Bytes = ".bytes";
        static string Mp3 = ".mp3";
        static string Mp4 = ".mp4";
        static string Txt = ".txt";
        static string Png = ".png";
        static string Prefab = ".prefab";
        static string Unity = ".unity";
        static string Arc = ".arc";
        static string Asset = ".asset";

        /*0x263e5fc*/ AssetSuffix();
    }

    class AssetType
    {
        static string Game = "Game";
        static string DLL = "DLL";
        static string Config = "Config";
        static string Font = "Font";
        static string Video = "Video";
        static string Audio = "Audio";
        static string Prefab = "Prefab";
        static string Scene = "Scene";
        static string Tool = "Tool";
        static string SkillConfig = "SkillConfig";
        static string Panel = "Panel";
        static string Execution = "Execution";
        static string Item = "Item";
        static string Skill = "Skill";
        static string Status = "Status";
        static string Character = "Character";
        static string Effect = "Effect";

        /*0x263e604*/ AssetType();
    }

    class EventArgs<T> : Framework.IEventArgs
    {
        /*0x0*/ T arg;

        static Framework.IEventArgs CreateEventArgs(T value);
        EventArgs(T arg);
    }

    class EventArgsExtend
    {
        static T GetValue<T>(Framework.IEventArgs args);
    }

    class EventManager : Framework.SingletonMono<Framework.EventManager>
    {
        /*0x18*/ System.Collections.Generic.Dictionary<Framework.EventType, System.Collections.Generic.List<Framework.IEventListener>> _eventDic;

        /*0x263e768*/ EventManager();
        /*0x2631528*/ void AddListener(Framework.EventType eventType, Framework.IEventListener listener);
        /*0x2635420*/ void RemoveListener(Framework.EventType eventType, Framework.IEventListener listener);
        /*0x2637bb4*/ void RemoveAllListener();
        /*0x263e60c*/ void Publish(Framework.EventType eventType);
        void Publish<T1>(Framework.EventType eventType, T1 args1);
        void Publish<T1, T2>(Framework.EventType eventType, T1 args1, T2 args2);
        void Publish<T1, T2, T3>(Framework.EventType eventType, T1 args1, T2 args2, T3 args3);
        void Publish<T1, T2, T3, T4>(Framework.EventType eventType, T1 args1, T2 args2, T3 args3, T4 args4);
    }

    enum EventType
    {
        InitializeFailed = 0,
        PatchStatesChange = 1,
        FoundUpdateFiles = 2,
        DownloadProgressUpdate = 3,
        PackageVersionUpdateFailed = 4,
        PatchManifestUpdateFailed = 5,
        WebFileDownloadFailed = 6,
        UserTryInitialize = 7,
        UserBeginDownloadWebFiles = 8,
        UserTryUpdatePackageVersion = 9,
        UserTryUpdatePatchManifest = 10,
        UserTryDownloadWebFiles = 11,
    }

    interface IEventArgs
    {
    }

    interface IEventListener
    {
        void HandleEvent(Framework.EventType eventType, Framework.IEventArgs args1, Framework.IEventArgs args2, Framework.IEventArgs args3, Framework.IEventArgs args4);
    }

    class DownClickEvent : UnityEngine.Events.UnityEvent
    {
        /*0x263e7f8*/ DownClickEvent();
    }

    class DownClickButton : UnityEngine.UI.Button
    {
        /*0x100*/ Framework.DownClickEvent downClick;
        /*0x108*/ Framework.DownClickEvent exitClick;
        /*0x110*/ bool down;

        /*0x263e898*/ DownClickButton();
        /*0x263e800*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x263e830*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x263e864*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class MessageBox
    {
        /*0x10*/ UnityEngine.GameObject cloneObject;
        /*0x18*/ TMPro.TextMeshProUGUI infoText;
        /*0x20*/ UnityEngine.UI.Button confirmBtn;
        /*0x28*/ System.Action completed;
        /*0x30*/ bool confirmHide;

        /*0x263eb28*/ MessageBox();
        /*0x263e8a0*/ bool get_ActiveSelf();
        /*0x263e8bc*/ void Create(UnityEngine.GameObject cloneObject);
        /*0x263ea00*/ void Show(string info, System.Action completed, bool confirmHide);
        /*0x263ea70*/ void Hide();
        /*0x263eaec*/ void OnConfirm();
    }

    class UILoadingPanel : UnityEngine.MonoBehaviour, Framework.IEventListener
    {
        static /*0x0*/ Framework.UILoadingPanel Instance;
        /*0x18*/ float currentPercent;
        /*0x1c*/ float targetPercent;
        /*0x20*/ float updateRate;
        /*0x28*/ UnityEngine.UI.RawImage backTex;
        /*0x30*/ UnityEngine.UI.Slider progress;
        /*0x38*/ TMPro.TMP_Text progressText;
        /*0x40*/ TMPro.TMP_Text tipsText;
        /*0x48*/ TMPro.TextMeshProUGUI text;
        /*0x50*/ UnityEngine.GameObject messageBox;
        /*0x58*/ System.Collections.Generic.List<Framework.MessageBox> msgBoxList;

        /*0x263f9ec*/ UILoadingPanel();
        /*0x263eb30*/ void Awake();
        /*0x263eb7c*/ void OnDestroy();
        /*0x263ebc4*/ void Update();
        /*0x263bc38*/ void SetStartLoadingBg();
        /*0x2630c7c*/ void UpdateLoadingPercent(int from, int to, float rate);
        /*0x263c0c4*/ void Show(string text);
        /*0x26353fc*/ void SetText(string text);
        /*0x263ecb8*/ void ClearText();
        /*0x2637f78*/ void Hide();
        /*0x263458c*/ void ShowMessageBox(string info, System.Action completed, bool confirmHide);
        /*0x263ed30*/ void HandleEvent(Framework.EventType eventType, Framework.IEventArgs args1, Framework.IEventArgs args2, Framework.IEventArgs args3, Framework.IEventArgs args4);
        /*0x263edb0*/ void <HandleEvent>g__InitializeFailed|21_0(ref Framework.UILoadingPanel.<> );
        /*0x263ef3c*/ void <HandleEvent>g__PatchStatesChange|21_1(ref Framework.UILoadingPanel.<> );
        /*0x263efb8*/ void <HandleEvent>g__FoundUpdateFiles|21_2(ref Framework.UILoadingPanel.<> );
        /*0x263f228*/ void <HandleEvent>g__DownloadProgressUpdate|21_3(ref Framework.UILoadingPanel.<> );
        /*0x263f50c*/ void <HandleEvent>g__PackageVersionUpdateFailed|21_4(ref Framework.UILoadingPanel.<> );
        /*0x263f698*/ void <HandleEvent>g__PatchManifestUpdateFailed|21_5(ref Framework.UILoadingPanel.<> );
        /*0x263f824*/ void <HandleEvent>g__WebFileDownloadFailed|21_6(ref Framework.UILoadingPanel.<> );

        struct <>c__DisplayClass21_0
        {
            /*0x10*/ Framework.UILoadingPanel <>4__this;
            /*0x18*/ Framework.IEventArgs args1;
        }

        class <>c
        {
            static /*0x0*/ Framework.UILoadingPanel.<> <>9;
            static /*0x8*/ System.Action <>9__21_7;
            static /*0x10*/ System.Action <>9__21_8;
            static /*0x18*/ System.Action <>9__21_9;
            static /*0x20*/ System.Action <>9__21_10;
            static /*0x28*/ System.Action <>9__21_11;

            static /*0x263fa68*/ <>c();
            /*0x263facc*/ <>c();
            /*0x263fad4*/ void <HandleEvent>b__21_7();
            /*0x263fb70*/ void <HandleEvent>b__21_8();
            /*0x263fc0c*/ void <HandleEvent>b__21_9();
            /*0x263fca8*/ void <HandleEvent>b__21_10();
            /*0x263fd44*/ void <HandleEvent>b__21_11();
        }
    }

    namespace UserEvent
    {
        class UserTryInitialize
        {
            static /*0x263fad8*/ void Publish();
            /*0x263fde0*/ UserTryInitialize();
        }

        class UserBeginDownloadWebFiles
        {
            static /*0x263fb74*/ void Publish();
            /*0x263fde8*/ UserBeginDownloadWebFiles();
        }

        class UserTryUpdatePackageVersion
        {
            static /*0x263fc10*/ void Publish();
            /*0x263fdf0*/ UserTryUpdatePackageVersion();
        }

        class UserTryUpdatePatchManifest
        {
            static /*0x263fcac*/ void Publish();
            /*0x263fdf8*/ UserTryUpdatePatchManifest();
        }

        class UserTryDownloadWebFiles
        {
            static /*0x263fd48*/ void Publish();
            /*0x263fe00*/ UserTryDownloadWebFiles();
        }
    }

    namespace UpdateEvent
    {
        class InitializeFailed
        {
            static /*0x26329ac*/ void Publish();
            /*0x263fe08*/ InitializeFailed();
        }

        class PatchStatesChange
        {
            /*0x10*/ string Tips;

            static /*0x263077c*/ void Publish(string tips);
            /*0x263fe10*/ PatchStatesChange();
        }

        class FoundUpdateFiles
        {
            /*0x10*/ int TotalCount;
            /*0x18*/ long TotalSizeBytes;

            static /*0x2630da4*/ void Publish(int totalCount, long totalSizeBytes);
            /*0x263fe18*/ FoundUpdateFiles();
        }

        class DownloadProgressUpdate
        {
            /*0x10*/ int TotalDownloadCount;
            /*0x14*/ int CurrentDownloadCount;
            /*0x18*/ long TotalDownloadSizeBytes;
            /*0x20*/ long CurrentDownloadSizeBytes;

            static /*0x263fe20*/ void Publish(int totalDownloadCount, int currentDownloadCount, long totalDownloadSizeBytes, long currentDownloadSizeBytes);
            /*0x263fee0*/ DownloadProgressUpdate();
        }

        class PackageVersionUpdateFailed
        {
            static /*0x2635e60*/ void Publish();
            /*0x263fee8*/ PackageVersionUpdateFailed();
        }

        class PatchManifestUpdateFailed
        {
            static /*0x263597c*/ void Publish();
            /*0x263fef0*/ PatchManifestUpdateFailed();
        }

        class WebFileDownloadFailed
        {
            /*0x10*/ string FileName;
            /*0x18*/ string Error;

            static /*0x263fef8*/ void Publish(string fileName, string error);
            /*0x263ffa4*/ WebFileDownloadFailed();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> D14B0B62074B0182034179C5EE12FF2735C7FA5BCD23C5B03D76CFC8787557D3;
    static /*0x14*/ <PrivateImplementationDetails> EA187CEB88DB7110BCD470F0A3FA350AEF2290283F259875DD00AA36C01792A7;

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }
}
