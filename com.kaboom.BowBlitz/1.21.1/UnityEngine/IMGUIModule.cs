class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x28ec208*/ EmbeddedAttribute();
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
                /*0x28ec210*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    class GUILayoutEntry
    {
        static /*0x0*/ UnityEngine.Rect kDummyRect;
        static /*0x10*/ int indent;
        /*0x10*/ float minWidth;
        /*0x14*/ float maxWidth;
        /*0x18*/ float minHeight;
        /*0x1c*/ float maxHeight;
        /*0x20*/ UnityEngine.Rect rect;
        /*0x30*/ int stretchWidth;
        /*0x34*/ int stretchHeight;
        /*0x38*/ bool consideredForMargin;
        /*0x40*/ UnityEngine.GUIStyle m_Style;

        static /*0x28ecf0c*/ GUILayoutEntry();
        /*0x28ec348*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x28ec454*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options);
        /*0x28ec218*/ UnityEngine.GUIStyle get_style();
        /*0x28ec220*/ void set_style(UnityEngine.GUIStyle value);
        /*0x28ec230*/ int get_marginLeft();
        /*0x28ec258*/ int get_marginRight();
        /*0x28ec280*/ int get_marginTop();
        /*0x28ec2a8*/ int get_marginBottom();
        /*0x28ec2d0*/ int get_marginHorizontal();
        /*0x28ec30c*/ int get_marginVertical();
        /*0x28ec55c*/ void CalcWidth();
        /*0x28ec560*/ void CalcHeight();
        /*0x28ec564*/ void SetHorizontal(float x, float width);
        /*0x28ec598*/ void SetVertical(float y, float height);
        /*0x28ec5cc*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x28ec658*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x28ec92c*/ string ToString();
    }

    class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ UnityEngine.GUIContent m_Content;
        /*0x50*/ float m_ForcedMinHeight;
        /*0x54*/ float m_ForcedMaxHeight;

        /*0x28ecf8c*/ GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options);
        /*0x28ed0ec*/ void CalcWidth();
        /*0x28ed170*/ void CalcHeight();
    }

    class GUI
    {
        static /*0x0*/ int s_HotTextField;
        static /*0x4*/ int s_BoxHash;
        static /*0x8*/ int s_ButonHash;
        static /*0xc*/ int s_RepeatButtonHash;
        static /*0x10*/ int s_ToggleHash;
        static /*0x14*/ int s_ButtonGridHash;
        static /*0x18*/ int s_SliderHash;
        static /*0x1c*/ int s_BeginGroupHash;
        static /*0x20*/ int s_ScrollviewHash;
        static /*0x28*/ System.DateTime <nextScrollStepTime>k__BackingField;
        static /*0x30*/ UnityEngine.GUISkin s_Skin;
        static /*0x38*/ UnityEngine.Rect s_ToolTipRect;
        static /*0x48*/ UnityEngineInternal.GenericStack <scrollViewStates>k__BackingField;

        static /*0x28ed1e0*/ GUI();
        static /*0x28ed474*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x28ed4d0*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x28ed650*/ UnityEngine.GUISkin get_skin();
        static /*0x28ed5ac*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x28ed7f8*/ UnityEngine.Matrix4x4 get_matrix();
        static /*0x28ed8d0*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x28ed958*/ void Label(UnityEngine.Rect position, string text);
        static /*0x28edabc*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x28eddb8*/ void Box(UnityEngine.Rect position, string text);
        static /*0x28ede90*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x28edb54*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x28ee164*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x28ee1bc*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x28eebc4*/ UnityEngine.Color get_color();
        static /*0x28eec88*/ void set_color(UnityEngine.Color value);
        static /*0x28eed48*/ UnityEngine.Color get_backgroundColor();
        static /*0x28eee0c*/ void set_backgroundColor(UnityEngine.Color value);
        static /*0x28eeecc*/ UnityEngine.Color get_contentColor();
        static /*0x28eef90*/ void set_contentColor(UnityEngine.Color value);
        static /*0x28ef050*/ bool get_changed();
        static /*0x28ef078*/ void set_changed(bool value);
        static /*0x28ef0b4*/ bool get_enabled();
        static /*0x28ef0dc*/ void set_enabled(bool value);
        static /*0x28eec4c*/ void get_color_Injected(ref UnityEngine.Color ret);
        static /*0x28eed0c*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x28eedd0*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x28eee90*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        static /*0x28eef54*/ void get_contentColor_Injected(ref UnityEngine.Color ret);
        static /*0x28ef014*/ void set_contentColor_Injected(ref UnityEngine.Color value);

        class WindowFunction : System.MulticastDelegate
        {
            /*0x28ef118*/ WindowFunction(object object, nint method);
            /*0x28ef1dc*/ void Invoke(int id);
        }
    }

    enum ScaleMode
    {
        StretchToFill = 0,
        ScaleAndCrop = 1,
        ScaleToFit = 2,
    }

    enum FocusType
    {
        Native = 0,
        Keyboard = 1,
        Passive = 2,
    }

    class SliderState
    {
        /*0x28ef1f0*/ SliderState();
    }

    class GUIClip
    {
        static /*0x28ee11c*/ UnityEngine.Rect get_visibleRect();
        static /*0x28ef234*/ UnityEngine.Rect get_topmostRect();
        static /*0x28ef2b8*/ void Internal_Pop();
        static /*0x28ef2e0*/ int Internal_GetCount();
        static /*0x28ef308*/ UnityEngine.Rect GetTopRect();
        static /*0x28ef38c*/ UnityEngine.Vector2 Unclip_Vector2(UnityEngine.Vector2 pos);
        static /*0x28ef41c*/ UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos);
        static /*0x28ef4ac*/ UnityEngine.Vector2 ClipToWindow_Vector2(UnityEngine.Vector2 absolutePos);
        static /*0x28ed86c*/ UnityEngine.Matrix4x4 GetMatrix();
        static /*0x28ed91c*/ void SetMatrix(UnityEngine.Matrix4x4 m);
        static /*0x28ef5b4*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
        static /*0x28ef5f4*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect);
        static /*0x28ef6a4*/ void Internal_PopParentClip();
        static /*0x28ef6cc*/ UnityEngine.Vector2 Unclip(UnityEngine.Vector2 pos);
        static /*0x28ef6d0*/ UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos);
        static /*0x28ef6d4*/ UnityEngine.Vector2 ClipToWindow(UnityEngine.Vector2 absolutePos);
        static /*0x28ef1f8*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x28ef27c*/ void get_topmostRect_Injected(ref UnityEngine.Rect ret);
        static /*0x28ef350*/ void GetTopRect_Injected(ref UnityEngine.Rect ret);
        static /*0x28ef3d8*/ void Unclip_Vector2_Injected(ref UnityEngine.Vector2 pos, ref UnityEngine.Vector2 ret);
        static /*0x28ef468*/ void UnclipToWindow_Vector2_Injected(ref UnityEngine.Vector2 pos, ref UnityEngine.Vector2 ret);
        static /*0x28ef4f8*/ void ClipToWindow_Vector2_Injected(ref UnityEngine.Vector2 absolutePos, ref UnityEngine.Vector2 ret);
        static /*0x28ef53c*/ void GetMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        static /*0x28ef578*/ void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x28ef650*/ void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect);

        struct ParentClipScope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x28ef6d8*/ ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
            /*0x28ef72c*/ void Dispose();
        }
    }

    enum EventType
    {
        MouseDown = 0,
        MouseUp = 1,
        MouseMove = 2,
        MouseDrag = 3,
        KeyDown = 4,
        KeyUp = 5,
        ScrollWheel = 6,
        Repaint = 7,
        Layout = 8,
        DragUpdated = 9,
        DragPerform = 10,
        DragExited = 15,
        Ignore = 11,
        Used = 12,
        ValidateCommand = 13,
        ExecuteCommand = 14,
        ContextClick = 16,
        MouseEnterWindow = 20,
        MouseLeaveWindow = 21,
        TouchDown = 30,
        TouchUp = 31,
        TouchMove = 32,
        TouchEnter = 33,
        TouchLeave = 34,
        TouchStationary = 35,
        mouseDown = 0,
        mouseUp = 1,
        mouseMove = 2,
        mouseDrag = 3,
        keyDown = 4,
        keyUp = 5,
        scrollWheel = 6,
        repaint = 7,
        layout = 8,
        dragUpdated = 9,
        dragPerform = 10,
        ignore = 11,
        used = 12,
    }

    enum EventModifiers
    {
        None = 0,
        Shift = 1,
        Control = 2,
        Alt = 4,
        Command = 8,
        Numeric = 16,
        CapsLock = 32,
        FunctionKey = 64,
    }

    enum PointerType
    {
        Mouse = 0,
        Touch = 1,
        Pen = 2,
    }

    struct EventInterests
    {
        /*0x10*/ bool <wantsMouseMove>k__BackingField;
        /*0x11*/ bool <wantsMouseEnterLeaveWindow>k__BackingField;
        /*0x12*/ bool <wantsLessLayoutEvents>k__BackingField;

        /*0x28ef76c*/ bool get_wantsMouseMove();
        /*0x28ef774*/ void set_wantsMouseMove(bool value);
        /*0x28ef780*/ bool get_wantsMouseEnterLeaveWindow();
        /*0x28ef788*/ void set_wantsMouseEnterLeaveWindow(bool value);
        /*0x28ef794*/ bool get_wantsLessLayoutEvents();
        /*0x28ef79c*/ bool WantsEvent(UnityEngine.EventType type);
        /*0x28ef7cc*/ bool WantsLayoutPass(UnityEngine.EventType type);
    }

    class Event
    {
        static /*0x0*/ UnityEngine.Event s_Current;
        static /*0x8*/ UnityEngine.Event s_MasterEvent;
        /*0x10*/ nint m_Ptr;

        static /*0x28ee044*/ UnityEngine.Event get_current();
        static /*0x28efbf0*/ void set_current(UnityEngine.Event value);
        static /*0x28efe28*/ UnityEngine.Event KeyboardEvent(string key);
        static /*0x28ef8d4*/ nint Internal_Create(int displayIndex);
        static /*0x28efa80*/ void Internal_Destroy(nint ptr);
        static /*0x28f2ca0*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x28efc84*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x28f2cdc*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x28f2dd4*/ int GetDoubleClickTime();
        /*0x28ef888*/ Event();
        /*0x28ef910*/ Event(int displayIndex);
        /*0x28ef960*/ void Finalize();
        /*0x28efabc*/ void CopyFrom(UnityEngine.Event e);
        /*0x28efb70*/ bool get_shift();
        /*0x28efcc0*/ bool get_isKey();
        /*0x28efd0c*/ bool get_isMouse();
        /*0x28efd70*/ bool get_isDirectManipulationDevice();
        /*0x28f1b00*/ int GetHashCode();
        /*0x28f1c3c*/ bool Equals(object obj);
        /*0x28f1e70*/ string ToString();
        /*0x28f2700*/ void Use();
        /*0x28f2900*/ UnityEngine.EventType get_rawType();
        /*0x28ee0c8*/ UnityEngine.Vector2 get_mousePosition();
        /*0x28f2980*/ void set_mousePosition(UnityEngine.Vector2 value);
        /*0x28f2a0c*/ UnityEngine.Vector2 get_delta();
        /*0x28f2a9c*/ void set_delta(UnityEngine.Vector2 value);
        /*0x28efdec*/ UnityEngine.PointerType get_pointerType();
        /*0x28f2b28*/ int get_button();
        /*0x28efbb4*/ UnityEngine.EventModifiers get_modifiers();
        /*0x28f19f8*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x28f2b64*/ float get_pressure();
        /*0x28f2ba0*/ int get_clickCount();
        /*0x28f1ac4*/ char get_character();
        /*0x28f1a3c*/ void set_character(char value);
        /*0x28f1c00*/ UnityEngine.KeyCode get_keyCode();
        /*0x28f1a80*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x28f2bdc*/ int get_displayIndex();
        /*0x28f2c18*/ void set_displayIndex(int value);
        /*0x28ee08c*/ UnityEngine.EventType get_type();
        /*0x28f19b4*/ void set_type(UnityEngine.EventType value);
        /*0x28f26c4*/ string get_commandName();
        /*0x28f2c5c*/ void set_commandName(string value);
        /*0x28f28c4*/ void Internal_Use();
        /*0x28efb2c*/ void CopyFromPtr(nint ptr);
        /*0x28f293c*/ void get_mousePosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x28f29c8*/ void set_mousePosition_Injected(ref UnityEngine.Vector2 value);
        /*0x28f2a58*/ void get_delta_Injected(ref UnityEngine.Vector2 ret);
        /*0x28f2ae4*/ void set_delta_Injected(ref UnityEngine.Vector2 value);
    }

    class GUILayoutUtility
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows;
        static /*0x10*/ UnityEngine.GUILayoutUtility.LayoutCache current;
        static /*0x18*/ UnityEngine.Rect kDummyRect;
        static /*0x28*/ int <unbalancedgroupscount>k__BackingField;
        static /*0x30*/ UnityEngine.GUIStyle s_SpaceStyle;

        static /*0x28f499c*/ GUILayoutUtility();
        static /*0x28f2dfc*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x28f2ed0*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x28f2fa0*/ int get_unbalancedgroupscount();
        static /*0x28f2ff8*/ void set_unbalancedgroupscount(int value);
        static /*0x28ee4cc*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x28f3134*/ void Begin(int instanceID);
        static /*0x28f3308*/ void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache);
        static /*0x28ee74c*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28ee9cc*/ void Layout();
        static /*0x28f3828*/ void LayoutFromEditorWindow();
        static /*0x28f3a14*/ void LayoutFromContainer(float w, float h);
        static /*0x28f3494*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x28f3658*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x28f3b9c*/ UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType);
        static /*0x28f3cec*/ UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType);
        static /*0x28f4040*/ void EndLayoutGroup();
        static /*0x28f42ac*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28f4318*/ UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28f4658*/ UnityEngine.Rect GetRect(float width, float height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28f46dc*/ UnityEngine.Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28f48c0*/ UnityEngine.GUIStyle get_spaceStyle();
        static /*0x28f2e8c*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x28f2f5c*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x28f3054*/ LayoutCache(int instanceID);
            /*0x28f4ac4*/ void set_id(int value);
            /*0x28f4acc*/ void ResetCursor();
        }
    }

    class ScrollViewState
    {
        /*0x28f4db8*/ ScrollViewState();
    }

    class GUIUtility
    {
        static /*0x0*/ int s_ControlCount;
        static /*0x4*/ int s_SkinMode;
        static /*0x8*/ int s_OriginalID;
        static /*0x10*/ System.Action takeCapture;
        static /*0x18*/ System.Action releaseCapture;
        static /*0x20*/ System.Func<int, nint, bool> processEvent;
        static /*0x28*/ System.Action cleanupRoots;
        static /*0x30*/ System.Func<System.Exception, bool> endContainerGUIFromException;
        static /*0x38*/ System.Action guiChanged;
        static /*0x40*/ bool <guiIsExiting>k__BackingField;
        static /*0x48*/ System.Func<bool> s_HasCurrentWindowKeyFocusFunc;

        static /*0x28f4dc0*/ bool get_hasModalWindow();
        static /*0x28f346c*/ float get_pixelsPerPoint();
        static /*0x28f4de8*/ int get_guiDepth();
        static /*0x28f4e10*/ UnityEngine.Vector2 get_s_EditorScreenPointOffset();
        static /*0x28f4e90*/ void set_s_EditorScreenPointOffset(UnityEngine.Vector2 value);
        static /*0x28f4f0c*/ bool get_mouseUsed();
        static /*0x28f4f34*/ void set_mouseUsed(bool value);
        static /*0x28ef860*/ bool get_textFieldInput();
        static /*0x28f4f70*/ void set_textFieldInput(bool value);
        static /*0x28f4fac*/ bool get_manualTex2SRGBEnabled();
        static /*0x28f4fd4*/ void set_manualTex2SRGBEnabled(bool value);
        static /*0x28f5010*/ string get_systemCopyBuffer();
        static /*0x28f5038*/ void set_systemCopyBuffer(string value);
        static /*0x28f5074*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x28f5124*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x28f51bc*/ void BeginContainerFromOwner(UnityEngine.ScriptableObject owner);
        static /*0x28f51f8*/ void BeginContainer(UnityEngine.ObjectGUIState objectGUIState);
        static /*0x28f5234*/ void Internal_EndContainer();
        static /*0x28f525c*/ int GetPermanentControlID();
        static /*0x28f5284*/ int CheckForTabEvent(UnityEngine.Event evt);
        static /*0x28f52c0*/ void SetKeyboardControlToFirstControlId();
        static /*0x28f52e8*/ void SetKeyboardControlToLastControlId();
        static /*0x28f5310*/ bool HasFocusableControls();
        static /*0x28f5338*/ bool OwnsId(int id);
        static /*0x28f5374*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels);
        static /*0x28f543c*/ string get_compositionString();
        static /*0x28f5464*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x28f548c*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x28f54c8*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x28f5548*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x28f55c4*/ UnityEngine.Vector3 Internal_MultiplyPoint(UnityEngine.Vector3 point, UnityEngine.Matrix4x4 transform);
        static /*0x28f5680*/ bool GetChanged();
        static /*0x28f56a8*/ void SetChanged(bool changed);
        static /*0x28f56e4*/ void SetDidGUIWindowsEatLastEvent(bool value);
        static /*0x28f5720*/ int Internal_GetHotControl();
        static /*0x28f5748*/ int Internal_GetKeyboardControl();
        static /*0x28f5770*/ void Internal_SetHotControl(int value);
        static /*0x28f57ac*/ void Internal_SetKeyboardControl(int value);
        static /*0x28f57e8*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x28f5824*/ UnityEngine.Object Internal_GetBuiltinSkin(int skin);
        static /*0x28f5860*/ void Internal_ExitGUI();
        static /*0x28f5888*/ UnityEngine.Vector2 InternalWindowToScreenPoint(UnityEngine.Vector2 windowPoint);
        static /*0x28f5918*/ UnityEngine.Vector2 InternalScreenToWindowPoint(UnityEngine.Vector2 screenPoint);
        static /*0x28f59a8*/ void MarkGUIChanged();
        static /*0x28f5a0c*/ int GetControlID(UnityEngine.FocusType focus);
        static /*0x28f5a18*/ int GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus);
        static /*0x28f5a80*/ int GetControlID(UnityEngine.FocusType focus, UnityEngine.Rect position);
        static /*0x28f5a8c*/ int GetControlID(UnityEngine.GUIContent contents, UnityEngine.FocusType focus, UnityEngine.Rect position);
        static /*0x28ee018*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x28f5adc*/ object GetStateObject(System.Type t, int controlID);
        static /*0x28f5b44*/ object QueryStateObject(System.Type t, int controlID);
        static /*0x28f5bac*/ bool get_guiIsExiting();
        static /*0x28f5bf4*/ void set_guiIsExiting(bool value);
        static /*0x28f5c40*/ int get_hotControl();
        static /*0x28f5c68*/ void set_hotControl(int value);
        static /*0x28f5ca4*/ void TakeCapture();
        static /*0x28f5d08*/ void RemoveCapture();
        static /*0x28f5d6c*/ int get_keyboardControl();
        static /*0x28f5d94*/ void set_keyboardControl(int value);
        static /*0x28f5dd0*/ bool HasKeyFocus(int controlID);
        static /*0x28f5e70*/ void ExitGUI();
        static /*0x28f5eb0*/ UnityEngine.GUISkin GetDefaultSkin(int skinMode);
        static /*0x28ed6ac*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x28f5f2c*/ UnityEngine.GUISkin GetBuiltinSkin(int skin);
        static /*0x28f5fa8*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x28f602c*/ void EndContainer();
        static /*0x28f6074*/ void CleanupRoots();
        static /*0x28f60d8*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x28f6274*/ void EndGUI(int layoutType);
        static /*0x28f6504*/ bool EndGUIFromException(System.Exception exception);
        static /*0x28f6548*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x28f6174*/ void ResetGlobalState();
        static /*0x28f65b8*/ bool IsExitGUIException(System.Exception exception);
        static /*0x28f6544*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x28ed528*/ void CheckOnGUI();
        static /*0x28f663c*/ float RoundToPixelGrid(float v);
        static /*0x28f66a8*/ UnityEngine.Vector2 GUIToScreenPoint(UnityEngine.Vector2 guiPoint);
        static /*0x28f66b8*/ UnityEngine.Rect GUIToScreenRect(UnityEngine.Rect guiRect);
        static /*0x28f6730*/ UnityEngine.Vector2 ScreenToGUIPoint(UnityEngine.Vector2 screenPoint);
        static /*0x28f6740*/ UnityEngine.Rect ScreenToGUIRect(UnityEngine.Rect screenRect);
        static /*0x28f67b8*/ void RotateAroundPivot(float angle, UnityEngine.Vector2 pivotPoint);
        static /*0x28f6ac8*/ void ScaleAroundPivot(UnityEngine.Vector2 scale, UnityEngine.Vector2 pivotPoint);
        static /*0x28f6d3c*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect);
        static /*0x28f6d58*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x28f6dfc*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x28f6e04*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt);
        static /*0x28f4e54*/ void get_s_EditorScreenPointOffset_Injected(ref UnityEngine.Vector2 ret);
        static /*0x28f4ed0*/ void set_s_EditorScreenPointOffset_Injected(ref UnityEngine.Vector2 value);
        static /*0x28f50d0*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x28f53e0*/ void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels, ref UnityEngine.Rect ret);
        static /*0x28f550c*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x28f5588*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
        static /*0x28f562c*/ void Internal_MultiplyPoint_Injected(ref UnityEngine.Vector3 point, ref UnityEngine.Matrix4x4 transform, ref UnityEngine.Vector3 ret);
        static /*0x28f58d4*/ void InternalWindowToScreenPoint_Injected(ref UnityEngine.Vector2 windowPoint, ref UnityEngine.Vector2 ret);
        static /*0x28f5964*/ void InternalScreenToWindowPoint_Injected(ref UnityEngine.Vector2 screenPoint, ref UnityEngine.Vector2 ret);
        /*0x28f6e74*/ GUIUtility();
    }

    class ObjectGUIState : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x28f6ec4*/ nint Internal_Create();
        static /*0x28f7080*/ void Internal_Destroy(nint ptr);
        /*0x28f6e7c*/ ObjectGUIState();
        /*0x28f6eec*/ void Dispose();
        /*0x28f6fec*/ void Finalize();
        /*0x28f6f4c*/ void Destroy();
    }

    class GUIContent
    {
        static /*0x0*/ UnityEngine.GUIContent s_Text;
        static /*0x8*/ UnityEngine.GUIContent s_Image;
        static /*0x10*/ UnityEngine.GUIContent s_TextImage;
        static /*0x18*/ UnityEngine.GUIContent none;
        /*0x10*/ string m_Text;
        /*0x18*/ UnityEngine.Texture m_Image;
        /*0x20*/ string m_Tooltip;

        static /*0x28f7240*/ GUIContent();
        static /*0x28eda28*/ UnityEngine.GUIContent Temp(string t);
        static /*0x28f6464*/ void ClearStaticCache();
        /*0x28f70dc*/ GUIContent();
        /*0x28f7138*/ GUIContent(string text);
        /*0x28f719c*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x28ed068*/ GUIContent(UnityEngine.GUIContent src);
        /*0x28f70bc*/ string get_text();
        /*0x28f70c4*/ void set_text(string value);
        /*0x28f70cc*/ void set_image(UnityEngine.Texture value);
        /*0x28ee114*/ string get_tooltip();
        /*0x28f70d4*/ void set_tooltip(string value);
        /*0x28f5a38*/ int get_hash();
        /*0x28f7220*/ string ToString();
    }

    class TextEditor
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextEditor.TextEditOp> s_Keyactions;
        /*0x10*/ UnityEngine.TouchScreenKeyboard keyboardOnScreen;
        /*0x18*/ int controlID;
        /*0x20*/ UnityEngine.GUIStyle style;
        /*0x28*/ bool multiline;
        /*0x29*/ bool hasHorizontalCursorPos;
        /*0x2a*/ bool isPasswordField;
        /*0x2b*/ bool m_HasFocus;
        /*0x2c*/ UnityEngine.Vector2 scrollOffset;
        /*0x38*/ UnityEngine.GUIContent m_Content;
        /*0x40*/ UnityEngine.Rect m_Position;
        /*0x50*/ int m_CursorIndex;
        /*0x54*/ int m_SelectIndex;
        /*0x58*/ bool m_RevealCursor;
        /*0x5c*/ UnityEngine.Vector2 graphicalCursorPos;
        /*0x64*/ UnityEngine.Vector2 graphicalSelectCursorPos;
        /*0x6c*/ bool m_MouseDragSelectsWholeWords;
        /*0x70*/ int m_DblClickInitPos;
        /*0x74*/ UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap;
        /*0x75*/ bool m_bJustSelected;
        /*0x78*/ int m_iAltCursorPos;
        /*0x80*/ string oldText;
        /*0x88*/ int oldPos;
        /*0x8c*/ int oldSelectPos;

        static /*0x28fac50*/ string ReplaceNewlinesWithSpaces(string value);
        static /*0x28face4*/ void MapKey(string key, UnityEngine.TextEditor.TextEditOp action);
        /*0x28f7928*/ TextEditor();
        /*0x28f7310*/ string get_text();
        /*0x28f732c*/ void set_text(string value);
        /*0x28f73e4*/ UnityEngine.Rect get_position();
        /*0x28f73f0*/ void set_position(UnityEngine.Rect value);
        /*0x28f784c*/ UnityEngine.Rect get_localPosition();
        /*0x28f7858*/ int get_cursorIndex();
        /*0x28f7860*/ void set_cursorIndex(int value);
        /*0x28f78b8*/ int get_selectIndex();
        /*0x28f78c0*/ void set_selectIndex(int value);
        /*0x28f7910*/ void ClearCursorPos();
        /*0x28f7920*/ int get_altCursorPosition();
        /*0x28f7a20*/ void OnFocus();
        /*0x28f7aa8*/ void OnLostFocus();
        /*0x28f7afc*/ void GrabGraphicalCursorPos();
        /*0x28f7b80*/ bool HandleKeyEvent(UnityEngine.Event e, bool textIsReadOnly);
        /*0x28f8b68*/ bool DeleteLineBack();
        /*0x28f8d3c*/ bool DeleteWordBack();
        /*0x28f8e94*/ bool DeleteWordForward();
        /*0x28f90c0*/ bool Delete();
        /*0x28f9210*/ bool CanPaste();
        /*0x28f9254*/ bool Backspace();
        /*0x28f7a64*/ void SelectAll();
        /*0x28f93b4*/ void SelectNone();
        /*0x28f8c20*/ bool get_hasSelection();
        /*0x28f93d8*/ string get_SelectedText();
        /*0x28f8c30*/ bool DeleteSelection();
        /*0x28f9464*/ void ReplaceSelection(string replace);
        /*0x28f94e0*/ void Insert(char c);
        /*0x28f9514*/ void MoveSelectionToAltCursor();
        /*0x28f95d0*/ void MoveRight();
        /*0x28f9648*/ void MoveLeft();
        /*0x28f96a0*/ void MoveUp();
        /*0x28f9750*/ void MoveDown();
        /*0x28f9830*/ void MoveLineStart();
        /*0x28f98a4*/ void MoveLineEnd();
        /*0x28f9934*/ void MoveGraphicalLineStart();
        /*0x28f9a2c*/ void MoveGraphicalLineEnd();
        /*0x28f9b38*/ void MoveTextStart();
        /*0x28f9b58*/ void MoveTextEnd();
        /*0x28f9b98*/ int IndexOfEndOfLine(int startIndex);
        /*0x28f9be8*/ void MoveParagraphForward();
        /*0x28f9c68*/ void MoveParagraphBackward();
        /*0x28f9ce0*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x28f9d68*/ void MoveAltCursorToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x28f9df0*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x28fa0fc*/ void SelectLeft();
        /*0x28fa154*/ void SelectRight();
        /*0x28fa1ac*/ void SelectUp();
        /*0x28fa210*/ void SelectDown();
        /*0x28fa290*/ void SelectTextEnd();
        /*0x28fa2b4*/ void SelectTextStart();
        /*0x28fa2bc*/ void MouseDragSelectsWholeWords(bool on);
        /*0x28fa2d0*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x28f997c*/ int GetGraphicalLineStart(int p);
        /*0x28f9a74*/ int GetGraphicalLineEnd(int p);
        /*0x28fa2d8*/ int FindNextSeperator(int startPos);
        /*0x28fa458*/ int FindPrevSeperator(int startPos);
        /*0x28fa4f4*/ void MoveWordRight();
        /*0x28fa558*/ void MoveToStartOfNextWord();
        /*0x28fa5b8*/ void MoveToEndOfPreviousWord();
        /*0x28fa618*/ void SelectToStartOfNextWord();
        /*0x28fa644*/ void SelectToEndOfPreviousWord();
        /*0x28fa370*/ UnityEngine.TextEditor.CharacterType ClassifyChar(int index);
        /*0x28f8f10*/ int FindStartOfNextWord(int p);
        /*0x28f8dcc*/ int FindEndOfPreviousWord(int p);
        /*0x28fa670*/ void MoveWordLeft();
        /*0x28fa6b8*/ void SelectWordRight();
        /*0x28fa720*/ void SelectWordLeft();
        /*0x28fa788*/ void ExpandSelectGraphicalLineStart();
        /*0x28fa7ec*/ void ExpandSelectGraphicalLineEnd();
        /*0x28fa850*/ void SelectGraphicalLineStart();
        /*0x28fa87c*/ void SelectGraphicalLineEnd();
        /*0x28fa8a8*/ void SelectParagraphForward();
        /*0x28fa930*/ void SelectParagraphBackward();
        /*0x28fa9d4*/ void SelectCurrentWord();
        /*0x28f9fe8*/ int FindEndOfClassification(int p, UnityEngine.TextEditor.Direction dir);
        /*0x28faa40*/ void SelectCurrentParagraph();
        /*0x28f74a8*/ void UpdateScrollOffset();
        /*0x28f8790*/ bool PerformOperation(UnityEngine.TextEditor.TextEditOp operation, bool textIsReadOnly);
        /*0x28fac2c*/ void SaveBackup();
        /*0x28faacc*/ bool Cut();
        /*0x28faaf8*/ void Copy();
        /*0x28fab88*/ bool Paste();
        /*0x28f7d34*/ void InitKeyActions();
        /*0x28f963c*/ void DetectFocusChange();
        /*0x28fad70*/ void OnDetectFocusChange();
        /*0x28fae0c*/ void OnCursorIndexChange();
        /*0x28fae10*/ void OnSelectIndexChange();
        /*0x28fae14*/ void ClampTextIndex(ref int index);
        /*0x28f73a4*/ void EnsureValidCodePointIndex(ref int index);
        /*0x28fae50*/ bool IsValidCodePointIndex(int index);
        /*0x28f92f4*/ int PreviousCodePointIndex(int index);
        /*0x28f914c*/ int NextCodePointIndex(int index);

        enum DblClickSnapping
        {
            WORDS = 0,
            PARAGRAPHS = 1,
        }

        enum CharacterType
        {
            LetterLike = 0,
            Symbol = 1,
            Symbol2 = 2,
            WhiteSpace = 3,
        }

        enum Direction
        {
            Forward = 0,
            Backward = 1,
        }

        enum TextEditOp
        {
            MoveLeft = 0,
            MoveRight = 1,
            MoveUp = 2,
            MoveDown = 3,
            MoveLineStart = 4,
            MoveLineEnd = 5,
            MoveTextStart = 6,
            MoveTextEnd = 7,
            MovePageUp = 8,
            MovePageDown = 9,
            MoveGraphicalLineStart = 10,
            MoveGraphicalLineEnd = 11,
            MoveWordLeft = 12,
            MoveWordRight = 13,
            MoveParagraphForward = 14,
            MoveParagraphBackward = 15,
            MoveToStartOfNextWord = 16,
            MoveToEndOfPreviousWord = 17,
            SelectLeft = 18,
            SelectRight = 19,
            SelectUp = 20,
            SelectDown = 21,
            SelectTextStart = 22,
            SelectTextEnd = 23,
            SelectPageUp = 24,
            SelectPageDown = 25,
            ExpandSelectGraphicalLineStart = 26,
            ExpandSelectGraphicalLineEnd = 27,
            SelectGraphicalLineStart = 28,
            SelectGraphicalLineEnd = 29,
            SelectWordLeft = 30,
            SelectWordRight = 31,
            SelectToEndOfPreviousWord = 32,
            SelectToStartOfNextWord = 33,
            SelectParagraphBackward = 34,
            SelectParagraphForward = 35,
            Delete = 36,
            Backspace = 37,
            DeleteWordBack = 38,
            DeleteWordForward = 39,
            DeleteLineBack = 40,
            Cut = 41,
            Copy = 42,
            Paste = 43,
            SelectAll = 44,
            SelectNone = 45,
            ScrollStart = 46,
            ScrollEnd = 47,
            ScrollPageUp = 48,
            ScrollPageDown = 49,
        }
    }

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        /*0x28faf08*/ GUISettings();
    }

    class GUILayout
    {
        static /*0x28faf34*/ void Label(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28fafa4*/ void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28fb070*/ void Space(float pixels);
        static /*0x28fb298*/ void BeginVertical(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28fb308*/ void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x28fb4c0*/ void EndVertical();
        static /*0x28ee614*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x28fb50c*/ UnityEngine.GUILayoutOption MinWidth(float minWidth);
        static /*0x28fb5a8*/ UnityEngine.GUILayoutOption MaxWidth(float maxWidth);
        static /*0x28ee6b0*/ UnityEngine.GUILayoutOption Height(float height);
        static /*0x28fb644*/ UnityEngine.GUILayoutOption MinHeight(float minHeight);
        static /*0x28fb6e0*/ UnityEngine.GUILayoutOption MaxHeight(float maxHeight);
        static /*0x28fb77c*/ UnityEngine.GUILayoutOption ExpandWidth(bool expand);
        static /*0x28fb81c*/ UnityEngine.GUILayoutOption ExpandHeight(bool expand);
    }

    class GUITargetAttribute : System.Attribute
    {
        /*0x10*/ int displayMask;

        static /*0x28fb8bc*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
    }

    class GUISkin : UnityEngine.ScriptableObject
    {
        static /*0x0*/ UnityEngine.GUIStyle ms_Error;
        static /*0x8*/ UnityEngine.GUISkin.SkinChangedDelegate m_SkinChanged;
        static /*0x10*/ UnityEngine.GUISkin current;
        /*0x18*/ UnityEngine.Font m_Font;
        /*0x20*/ UnityEngine.GUIStyle m_box;
        /*0x28*/ UnityEngine.GUIStyle m_button;
        /*0x30*/ UnityEngine.GUIStyle m_toggle;
        /*0x38*/ UnityEngine.GUIStyle m_label;
        /*0x40*/ UnityEngine.GUIStyle m_textField;
        /*0x48*/ UnityEngine.GUIStyle m_textArea;
        /*0x50*/ UnityEngine.GUIStyle m_window;
        /*0x58*/ UnityEngine.GUIStyle m_horizontalSlider;
        /*0x60*/ UnityEngine.GUIStyle m_horizontalSliderThumb;
        /*0x68*/ UnityEngine.GUIStyle m_horizontalSliderThumbExtent;
        /*0x70*/ UnityEngine.GUIStyle m_verticalSlider;
        /*0x78*/ UnityEngine.GUIStyle m_verticalSliderThumb;
        /*0x80*/ UnityEngine.GUIStyle m_verticalSliderThumbExtent;
        /*0x88*/ UnityEngine.GUIStyle m_SliderMixed;
        /*0x90*/ UnityEngine.GUIStyle m_horizontalScrollbar;
        /*0x98*/ UnityEngine.GUIStyle m_horizontalScrollbarThumb;
        /*0xa0*/ UnityEngine.GUIStyle m_horizontalScrollbarLeftButton;
        /*0xa8*/ UnityEngine.GUIStyle m_horizontalScrollbarRightButton;
        /*0xb0*/ UnityEngine.GUIStyle m_verticalScrollbar;
        /*0xb8*/ UnityEngine.GUIStyle m_verticalScrollbarThumb;
        /*0xc0*/ UnityEngine.GUIStyle m_verticalScrollbarUpButton;
        /*0xc8*/ UnityEngine.GUIStyle m_verticalScrollbarDownButton;
        /*0xd0*/ UnityEngine.GUIStyle m_ScrollView;
        /*0xd8*/ UnityEngine.GUIStyle[] m_CustomStyles;
        /*0xe0*/ UnityEngine.GUISettings m_Settings;
        /*0xe8*/ System.Collections.Generic.Dictionary<string, UnityEngine.GUIStyle> m_Styles;

        static /*0x28fbb70*/ void CleanupRoots();
        static /*0x28fbe08*/ UnityEngine.GUIStyle get_error();
        /*0x28fba3c*/ GUISkin();
        /*0x28fbaf0*/ void OnEnable();
        /*0x28fbbbc*/ UnityEngine.Font get_font();
        /*0x28fbbc4*/ void set_font(UnityEngine.Font value);
        /*0x28ede88*/ UnityEngine.GUIStyle get_box();
        /*0x28fbc90*/ void set_box(UnityEngine.GUIStyle value);
        /*0x28edab4*/ UnityEngine.GUIStyle get_label();
        /*0x28fbc98*/ void set_label(UnityEngine.GUIStyle value);
        /*0x28fbca0*/ UnityEngine.GUIStyle get_textField();
        /*0x28fbca8*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x28fbcb0*/ UnityEngine.GUIStyle get_textArea();
        /*0x28fbcb8*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x28fbcc0*/ UnityEngine.GUIStyle get_button();
        /*0x28fbcc8*/ void set_button(UnityEngine.GUIStyle value);
        /*0x28fbcd0*/ UnityEngine.GUIStyle get_toggle();
        /*0x28fbcd8*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x28fbce0*/ UnityEngine.GUIStyle get_window();
        /*0x28fbce8*/ void set_window(UnityEngine.GUIStyle value);
        /*0x28fbcf0*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x28fbcf8*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x28fbd00*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x28fbd08*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x28fbd10*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x28fbd18*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x28fbd20*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x28fbd28*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x28fbd30*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x28fbd38*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x28fbd40*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x28fbd48*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x28fbd50*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x28fbd58*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x28fbd60*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x28fbd68*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x28fbd70*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x28fbd78*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x28fbd80*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x28fbd88*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x28fbd90*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x28fbd98*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x28fbda0*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x28fbda8*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x28fbdb0*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x28fbdb8*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x28fbdc0*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x28fbdc8*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x28fbdd0*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x28fbdd8*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x28fbde0*/ UnityEngine.GUIStyle get_scrollView();
        /*0x28fbde8*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x28fbdf0*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x28fbdf8*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x28fbe00*/ UnityEngine.GUISettings get_settings();
        /*0x28fbaf4*/ void Apply();
        /*0x28fbecc*/ void BuildStyleCache();
        /*0x28fca10*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x28fccdc*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x28ed744*/ void MakeCurrent();
        /*0x28fcd64*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0x28fde24*/ SkinChangedDelegate(object object, nint method);
            /*0x28fdee0*/ void Invoke();
        }
    }

    class GUILayoutGroup : UnityEngine.GUILayoutEntry
    {
        static /*0x0*/ UnityEngine.GUILayoutEntry none;
        /*0x48*/ System.Collections.Generic.List<UnityEngine.GUILayoutEntry> entries;
        /*0x50*/ bool isVertical;
        /*0x51*/ bool resetCoords;
        /*0x54*/ float spacing;
        /*0x58*/ bool sameSize;
        /*0x59*/ bool isWindow;
        /*0x5c*/ int windowID;
        /*0x60*/ int m_Cursor;
        /*0x64*/ int m_StretchableCountX;
        /*0x68*/ int m_StretchableCountY;
        /*0x6c*/ bool m_UserSpecifiedWidth;
        /*0x6d*/ bool m_UserSpecifiedHeight;
        /*0x70*/ float m_ChildMinWidth;
        /*0x74*/ float m_ChildMaxWidth;
        /*0x78*/ float m_ChildMinHeight;
        /*0x7c*/ float m_ChildMaxHeight;
        /*0x80*/ int m_MarginLeft;
        /*0x84*/ int m_MarginRight;
        /*0x88*/ int m_MarginTop;
        /*0x8c*/ int m_MarginBottom;

        static /*0x29008c0*/ GUILayoutGroup();
        /*0x28fdf14*/ GUILayoutGroup();
        /*0x28fdef4*/ int get_marginLeft();
        /*0x28fdefc*/ int get_marginRight();
        /*0x28fdf04*/ int get_marginTop();
        /*0x28fdf0c*/ int get_marginBottom();
        /*0x28fe0bc*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x28fe1e0*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x28fe300*/ void ResetCursor();
        /*0x28fe308*/ UnityEngine.GUILayoutEntry GetNext();
        /*0x28fe638*/ void Add(UnityEngine.GUILayoutEntry e);
        /*0x28fe6e0*/ void CalcWidth();
        /*0x28fee88*/ void SetHorizontal(float x, float width);
        /*0x28ff644*/ void CalcHeight();
        /*0x28ffcd0*/ void SetVertical(float y, float height);
        /*0x290049c*/ string ToString();
    }

    class GUIScrollGroup : UnityEngine.GUILayoutGroup
    {
        /*0x90*/ float calcMinWidth;
        /*0x94*/ float calcMaxWidth;
        /*0x98*/ float calcMinHeight;
        /*0x9c*/ float calcMaxHeight;
        /*0xa0*/ float clientWidth;
        /*0xa4*/ float clientHeight;
        /*0xa8*/ bool allowHorizontalScroll;
        /*0xa9*/ bool allowVerticalScroll;
        /*0xaa*/ bool needsHorizontalScrollbar;
        /*0xab*/ bool needsVerticalScrollbar;
        /*0xb0*/ UnityEngine.GUIStyle horizontalScrollbar;
        /*0xb8*/ UnityEngine.GUIStyle verticalScrollbar;

        /*0x2900990*/ GUIScrollGroup();
        /*0x29009ec*/ void CalcWidth();
        /*0x2900a68*/ void SetHorizontal(float x, float width);
        /*0x2900b8c*/ void CalcHeight();
        /*0x2900c88*/ void SetVertical(float y, float height);
    }

    class GUIStateObjects
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, object> s_StateCache;

        static /*0x2901060*/ GUIStateObjects();
        static /*0x2900e98*/ object GetStateObject(System.Type t, int controlID);
        static /*0x2900fa8*/ object QueryStateObject(System.Type t, int controlID);
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x2901184*/ nint Init();
        static /*0x290125c*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x29011e8*/ GUIStyleState();
        /*0x2901230*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x29010ec*/ void set_textColor(UnityEngine.Color value);
        /*0x29011ac*/ void Cleanup();
        /*0x29012cc*/ void Finalize();
        /*0x2901140*/ void set_textColor_Injected(ref UnityEngine.Color value);
    }

    class GUIStyle
    {
        static /*0x0*/ bool showKeyboardFocus;
        static /*0x8*/ UnityEngine.GUIStyle s_None;
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyleState m_Normal;
        /*0x20*/ UnityEngine.GUIStyleState m_Hover;
        /*0x28*/ UnityEngine.GUIStyleState m_Active;
        /*0x30*/ UnityEngine.GUIStyleState m_Focused;
        /*0x38*/ UnityEngine.GUIStyleState m_OnNormal;
        /*0x40*/ UnityEngine.GUIStyleState m_OnHover;
        /*0x48*/ UnityEngine.GUIStyleState m_OnActive;
        /*0x50*/ UnityEngine.GUIStyleState m_OnFocused;
        /*0x58*/ UnityEngine.RectOffset m_Border;
        /*0x60*/ UnityEngine.RectOffset m_Padding;
        /*0x68*/ UnityEngine.RectOffset m_Margin;
        /*0x70*/ UnityEngine.RectOffset m_Overflow;
        /*0x78*/ string m_Name;

        static /*0x29029e4*/ GUIStyle();
        static /*0x290175c*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x2901798*/ nint Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other);
        static /*0x29017dc*/ void Internal_Destroy(nint self);
        static /*0x29018f4*/ float Internal_GetLineHeight(nint target);
        static /*0x2902014*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x29020e4*/ bool IsTooltipActive(string tooltip);
        static /*0x2902120*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x28fe02c*/ UnityEngine.GUIStyle get_none();
        static /*0x29020a0*/ void SetMouseTooltip_Injected(string tooltip, ref UnityEngine.Rect screenRect);
        /*0x290215c*/ GUIStyle();
        /*0x29021e4*/ GUIStyle(UnityEngine.GUIStyle other);
        /*0x29013c4*/ string get_rawName();
        /*0x2901400*/ void set_rawName(string value);
        /*0x2901444*/ UnityEngine.Font get_font();
        /*0x2901480*/ void set_font(UnityEngine.Font value);
        /*0x29014c4*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x2901500*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x2901544*/ bool get_wordWrap();
        /*0x2901580*/ void set_wordWrap(bool value);
        /*0x29015c4*/ void set_clipping(UnityEngine.TextClipping value);
        /*0x28fee4c*/ float get_fixedWidth();
        /*0x28ffc94*/ float get_fixedHeight();
        /*0x28fee10*/ bool get_stretchWidth();
        /*0x2901608*/ void set_stretchWidth(bool value);
        /*0x28ffc58*/ bool get_stretchHeight();
        /*0x290164c*/ void set_stretchHeight(bool value);
        /*0x2901690*/ void set_fontSize(int value);
        /*0x29016d4*/ void set_fontStyle(UnityEngine.FontStyle value);
        /*0x2901718*/ void set_richText(bool value);
        /*0x2901818*/ nint GetStyleStatePtr(int idx);
        /*0x290185c*/ nint GetRectOffsetPtr(int idx);
        /*0x29018a0*/ void AssignRectOffset(int idx, nint srcRectOffset);
        /*0x2901930*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2901a40*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x2901b20*/ UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x2901c00*/ int Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition);
        /*0x2901cc0*/ string Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex);
        /*0x2901da0*/ UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content);
        /*0x2901e50*/ UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize);
        /*0x2901f10*/ float Internal_CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x2901f64*/ UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content);
        /*0x29022c8*/ void Finalize();
        /*0x290240c*/ string get_name();
        /*0x2902458*/ void set_name(string value);
        /*0x29024a0*/ UnityEngine.GUIStyleState get_normal();
        /*0x29024fc*/ UnityEngine.RectOffset get_border();
        /*0x28fe258*/ UnityEngine.RectOffset get_margin();
        /*0x28fed68*/ UnityEngine.RectOffset get_padding();
        /*0x29025a4*/ void set_padding(UnityEngine.RectOffset value);
        /*0x29025f4*/ float get_lineHeight();
        /*0x29026f0*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2902728*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x2902704*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x29027c8*/ UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x29027cc*/ int GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition);
        /*0x29027d0*/ UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content);
        /*0x29027d4*/ UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints);
        /*0x29027d8*/ float CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x290282c*/ bool get_isHeightDependantOnWidth();
        /*0x29028d8*/ void CalcMinMaxWidth(UnityEngine.GUIContent content, ref float minWidth, ref float maxWidth);
        /*0x2902900*/ string ToString();
        /*0x29019bc*/ void Internal_Draw_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2901ab4*/ void Internal_Draw2_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x2901b94*/ void Internal_GetCursorPixelPosition_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex, ref UnityEngine.Vector2 ret);
        /*0x2901c64*/ int Internal_GetCursorStringIndex_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, ref UnityEngine.Vector2 cursorPixelPosition);
        /*0x2901d34*/ string Internal_GetSelectedRenderedText_Injected(ref UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex);
        /*0x2901dfc*/ void Internal_CalcSize_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        /*0x2901eb4*/ void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, ref UnityEngine.Vector2 ret);
        /*0x2901fc0*/ void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
    }

    class ExitGUIException : System.Exception
    {
        /*0x2902a30*/ ExitGUIException();
        /*0x2902ac4*/ ExitGUIException(string message);
    }

    enum ImagePosition
    {
        ImageLeft = 0,
        ImageAbove = 1,
        ImageOnly = 2,
        TextOnly = 3,
    }

    enum TextClipping
    {
        Overflow = 0,
        Clip = 1,
    }

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x2902b68*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

        enum Type
        {
            fixedWidth = 0,
            fixedHeight = 1,
            minWidth = 2,
            maxWidth = 3,
            minHeight = 4,
            maxHeight = 5,
            stretchWidth = 6,
            stretchHeight = 7,
            alignStart = 8,
            alignMiddle = 9,
            alignEnd = 10,
            alignJustify = 11,
            equalSize = 12,
            spacing = 13,
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x2902b98*/ uint ComputeStringHash(string s);
}
