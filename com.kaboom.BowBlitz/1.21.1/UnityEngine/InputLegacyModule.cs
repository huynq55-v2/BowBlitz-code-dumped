class <Module>
{
}

namespace UnityEngine
{
    enum TouchPhase
    {
        Began = 0,
        Moved = 1,
        Stationary = 2,
        Ended = 3,
        Canceled = 4,
    }

    enum IMECompositionMode
    {
        Auto = 0,
        On = 1,
        Off = 2,
    }

    enum TouchType
    {
        Direct = 0,
        Indirect = 1,
        Stylus = 2,
    }

    struct Touch
    {
        /*0x10*/ int m_FingerId;
        /*0x14*/ UnityEngine.Vector2 m_Position;
        /*0x1c*/ UnityEngine.Vector2 m_RawPosition;
        /*0x24*/ UnityEngine.Vector2 m_PositionDelta;
        /*0x2c*/ float m_TimeDelta;
        /*0x30*/ int m_TapCount;
        /*0x34*/ UnityEngine.TouchPhase m_Phase;
        /*0x38*/ UnityEngine.TouchType m_Type;
        /*0x3c*/ float m_Pressure;
        /*0x40*/ float m_maximumPossiblePressure;
        /*0x44*/ float m_Radius;
        /*0x48*/ float m_RadiusVariance;
        /*0x4c*/ float m_AltitudeAngle;
        /*0x50*/ float m_AzimuthAngle;

        /*0x2902c14*/ int get_fingerId();
        /*0x2902c1c*/ void set_fingerId(int value);
        /*0x2902c24*/ UnityEngine.Vector2 get_position();
        /*0x2902c2c*/ void set_position(UnityEngine.Vector2 value);
        /*0x2902c34*/ UnityEngine.Vector2 get_rawPosition();
        /*0x2902c3c*/ void set_rawPosition(UnityEngine.Vector2 value);
        /*0x2902c44*/ UnityEngine.Vector2 get_deltaPosition();
        /*0x2902c4c*/ void set_deltaPosition(UnityEngine.Vector2 value);
        /*0x2902c54*/ float get_deltaTime();
        /*0x2902c5c*/ void set_deltaTime(float value);
        /*0x2902c64*/ int get_tapCount();
        /*0x2902c6c*/ void set_tapCount(int value);
        /*0x2902c74*/ UnityEngine.TouchPhase get_phase();
        /*0x2902c7c*/ void set_phase(UnityEngine.TouchPhase value);
        /*0x2902c84*/ float get_pressure();
        /*0x2902c8c*/ void set_pressure(float value);
        /*0x2902c94*/ float get_maximumPossiblePressure();
        /*0x2902c9c*/ void set_maximumPossiblePressure(float value);
        /*0x2902ca4*/ UnityEngine.TouchType get_type();
        /*0x2902cac*/ void set_type(UnityEngine.TouchType value);
        /*0x2902cb4*/ float get_altitudeAngle();
        /*0x2902cbc*/ void set_altitudeAngle(float value);
        /*0x2902cc4*/ float get_azimuthAngle();
        /*0x2902ccc*/ void set_azimuthAngle(float value);
        /*0x2902cd4*/ float get_radius();
        /*0x2902cdc*/ void set_radius(float value);
        /*0x2902ce4*/ float get_radiusVariance();
        /*0x2902cec*/ void set_radiusVariance(float value);
    }

    enum DeviceOrientation
    {
        Unknown = 0,
        Portrait = 1,
        PortraitUpsideDown = 2,
        LandscapeLeft = 3,
        LandscapeRight = 4,
        FaceUp = 5,
        FaceDown = 6,
    }

    struct AccelerationEvent
    {
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float m_TimeDelta;
    }

    class Gyroscope
    {
        /*0x10*/ int m_GyroIndex;

        static /*0x2902d1c*/ UnityEngine.Vector3 rotationRate_Internal(int idx);
        static /*0x2902dbc*/ UnityEngine.Vector3 rotationRateUnbiased_Internal(int idx);
        static /*0x2902e5c*/ UnityEngine.Vector3 gravity_Internal(int idx);
        static /*0x2902efc*/ UnityEngine.Vector3 userAcceleration_Internal(int idx);
        static /*0x2902f9c*/ UnityEngine.Quaternion attitude_Internal(int idx);
        static /*0x2903038*/ bool getEnabled_Internal(int idx);
        static /*0x2903074*/ void setEnabled_Internal(int idx, bool enabled);
        static /*0x29030b8*/ float getUpdateInterval_Internal(int idx);
        static /*0x29030f4*/ void setUpdateInterval_Internal(int idx, float interval);
        static /*0x2902d78*/ void rotationRate_Internal_Injected(int idx, ref UnityEngine.Vector3 ret);
        static /*0x2902e18*/ void rotationRateUnbiased_Internal_Injected(int idx, ref UnityEngine.Vector3 ret);
        static /*0x2902eb8*/ void gravity_Internal_Injected(int idx, ref UnityEngine.Vector3 ret);
        static /*0x2902f58*/ void userAcceleration_Internal_Injected(int idx, ref UnityEngine.Vector3 ret);
        static /*0x2902ff4*/ void attitude_Internal_Injected(int idx, ref UnityEngine.Quaternion ret);
        /*0x2902cf4*/ Gyroscope(int index);
        /*0x2903140*/ UnityEngine.Vector3 get_rotationRate();
        /*0x2903148*/ UnityEngine.Vector3 get_rotationRateUnbiased();
        /*0x2903150*/ UnityEngine.Vector3 get_gravity();
        /*0x2903158*/ UnityEngine.Vector3 get_userAcceleration();
        /*0x2903160*/ UnityEngine.Quaternion get_attitude();
        /*0x2903168*/ bool get_enabled();
        /*0x29031a4*/ void set_enabled(bool value);
        /*0x29031e8*/ float get_updateInterval();
        /*0x2903224*/ void set_updateInterval(float value);
    }

    class LocationService
    {
        /*0x2903270*/ LocationService();
    }

    class Compass
    {
        /*0x2903278*/ Compass();
    }

    class CameraRaycastHelper
    {
        static /*0x2903280*/ UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x2903348*/ UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x29032e4*/ UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x29033ac*/ UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask);
    }

    class Input
    {
        static /*0x0*/ UnityEngine.LocationService locationServiceInstance;
        static /*0x8*/ UnityEngine.Compass compassInstance;
        static /*0x10*/ UnityEngine.Gyroscope s_MainGyro;

        static /*0x2903410*/ bool GetKeyInt(UnityEngine.KeyCode key);
        static /*0x290344c*/ bool GetKeyString(string name);
        static /*0x2903488*/ bool GetKeyUpInt(UnityEngine.KeyCode key);
        static /*0x29034c4*/ bool GetKeyUpString(string name);
        static /*0x2903500*/ bool GetKeyDownInt(UnityEngine.KeyCode key);
        static /*0x290353c*/ bool GetKeyDownString(string name);
        static /*0x2903578*/ float GetAxis(string axisName);
        static /*0x29035b4*/ float GetAxisRaw(string axisName);
        static /*0x29035f0*/ bool GetButton(string buttonName);
        static /*0x290362c*/ bool GetButtonDown(string buttonName);
        static /*0x2903668*/ bool GetButtonUp(string buttonName);
        static /*0x29036a4*/ bool GetMouseButton(int button);
        static /*0x29036e0*/ bool GetMouseButtonDown(int button);
        static /*0x290371c*/ bool GetMouseButtonUp(int button);
        static /*0x2903758*/ void ResetInputAxes();
        static /*0x2903780*/ string[] GetJoystickNames();
        static /*0x29037a8*/ UnityEngine.Touch GetTouch(int index);
        static /*0x290385c*/ UnityEngine.AccelerationEvent GetAccelerationEvent(int index);
        static /*0x29038f8*/ bool GetKey(UnityEngine.KeyCode key);
        static /*0x2903934*/ bool GetKey(string name);
        static /*0x2903970*/ bool GetKeyUp(UnityEngine.KeyCode key);
        static /*0x29039ac*/ bool GetKeyUp(string name);
        static /*0x29039e8*/ bool GetKeyDown(UnityEngine.KeyCode key);
        static /*0x2903a24*/ bool GetKeyDown(string name);
        static /*0x2903a60*/ void SimulateTouch(UnityEngine.Touch touch);
        static /*0x2903a64*/ void SimulateTouchInternal(UnityEngine.Touch touch, long timestamp);
        static /*0x2903aec*/ bool get_simulateMouseWithTouches();
        static /*0x2903b14*/ void set_simulateMouseWithTouches(bool value);
        static /*0x2903b50*/ bool get_anyKey();
        static /*0x2903b78*/ bool get_anyKeyDown();
        static /*0x2903ba0*/ string get_inputString();
        static /*0x2903bc8*/ UnityEngine.Vector3 get_mousePosition();
        static /*0x2903c50*/ UnityEngine.Vector2 get_mouseScrollDelta();
        static /*0x2903cd0*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
        static /*0x2903cf8*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x2903d34*/ string get_compositionString();
        static /*0x2903d5c*/ bool get_imeIsSelected();
        static /*0x2903d84*/ UnityEngine.Vector2 get_compositionCursorPos();
        static /*0x2903e04*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x2903e80*/ bool get_eatKeyPressOnTextFieldFocus();
        static /*0x2903ea8*/ void set_eatKeyPressOnTextFieldFocus(bool value);
        static /*0x2903ee4*/ bool get_mousePresent();
        static /*0x2903f0c*/ int get_touchCount();
        static /*0x2903f34*/ bool get_touchPressureSupported();
        static /*0x2903f5c*/ bool get_stylusTouchSupported();
        static /*0x2903f84*/ bool get_touchSupported();
        static /*0x2903fac*/ bool get_multiTouchEnabled();
        static /*0x2903fd4*/ void set_multiTouchEnabled(bool value);
        static /*0x2904010*/ bool get_isGyroAvailable();
        static /*0x2904038*/ UnityEngine.DeviceOrientation get_deviceOrientation();
        static /*0x2904060*/ UnityEngine.Vector3 get_acceleration();
        static /*0x29040e8*/ bool get_compensateSensors();
        static /*0x2904110*/ void set_compensateSensors(bool value);
        static /*0x290414c*/ int get_accelerationEventCount();
        static /*0x2904174*/ bool get_backButtonLeavesApp();
        static /*0x290419c*/ void set_backButtonLeavesApp(bool value);
        static /*0x29041d8*/ UnityEngine.LocationService get_location();
        static /*0x290426c*/ UnityEngine.Compass get_compass();
        static /*0x29042f8*/ int GetGyroInternal();
        static /*0x2904320*/ UnityEngine.Gyroscope get_gyro();
        static /*0x29043dc*/ UnityEngine.Touch[] get_touches();
        static /*0x290451c*/ UnityEngine.AccelerationEvent[] get_accelerationEvents();
        static /*0x29045ec*/ bool CheckDisabled();
        static /*0x2903818*/ void GetTouch_Injected(int index, ref UnityEngine.Touch ret);
        static /*0x29038b4*/ void GetAccelerationEvent_Injected(int index, ref UnityEngine.AccelerationEvent ret);
        static /*0x2903aa8*/ void SimulateTouchInternal_Injected(ref UnityEngine.Touch touch, long timestamp);
        static /*0x2903c14*/ void get_mousePosition_Injected(ref UnityEngine.Vector3 ret);
        static /*0x2903c94*/ void get_mouseScrollDelta_Injected(ref UnityEngine.Vector2 ret);
        static /*0x2903dc8*/ void get_compositionCursorPos_Injected(ref UnityEngine.Vector2 ret);
        static /*0x2903e44*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
        static /*0x29040ac*/ void get_acceleration_Injected(ref UnityEngine.Vector3 ret);
        /*0x2904614*/ Input();
    }

    class SendMouseEvents
    {
        static /*0x0*/ bool s_MouseUsed;
        static /*0x8*/ UnityEngine.SendMouseEvents.HitInfo[] m_LastHit;
        static /*0x10*/ UnityEngine.SendMouseEvents.HitInfo[] m_MouseDownHit;
        static /*0x18*/ UnityEngine.SendMouseEvents.HitInfo[] m_CurrentHit;
        static /*0x20*/ UnityEngine.Camera[] m_Cameras;
        static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<int, UnityEngine.Vector2>> s_GetMouseState;
        static /*0x30*/ UnityEngine.Vector2 s_MousePosition;
        static /*0x38*/ bool s_MouseButtonPressedThisFrame;
        static /*0x39*/ bool s_MouseButtonIsPressed;

        static /*0x2905720*/ SendMouseEvents();
        static /*0x290461c*/ void UpdateMouse();
        static /*0x29047e0*/ void SetMouseMoved();
        static /*0x290483c*/ void DoSendMouseEvents(int skipRTCameras);
        static /*0x2905188*/ void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit);

        struct HitInfo
        {
            /*0x10*/ UnityEngine.GameObject target;
            /*0x18*/ UnityEngine.Camera camera;

            static /*0x29055a8*/ bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists);
            static /*0x290566c*/ bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs);
            /*0x2905648*/ void SendMessage(string name);
        }
    }
}
