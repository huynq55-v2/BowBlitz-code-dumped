class <Module>
{
}

namespace DG
{
    namespace Tweening
    {
        class DOTweenVisualManager : UnityEngine.MonoBehaviour
        {
            /*0x18*/ DG.Tweening.Core.VisualManagerPreset preset;
            /*0x1c*/ DG.Tweening.Core.OnEnableBehaviour onEnableBehaviour;
            /*0x20*/ DG.Tweening.Core.OnDisableBehaviour onDisableBehaviour;
            /*0x24*/ bool _requiresRestartFromSpawnPoint;
            /*0x28*/ DG.Tweening.Core.ABSAnimationComponent _animComponent;

            /*0xe2b6e8*/ DOTweenVisualManager();
            /*0xe2b330*/ void Awake();
            /*0xe2b380*/ void Update();
            /*0xe2b418*/ void OnEnable();
            /*0xe2b500*/ void OnDisable();
        }

        enum HandlesDrawMode
        {
            Orthographic = 0,
            Perspective = 1,
        }

        enum HandlesType
        {
            Free = 0,
            Full = 1,
        }

        enum DOTweenInspectorMode
        {
            Default = 0,
            InfoAndWaypointsOnly = 1,
            Developer = 2,
            OnlyPath = 3,
        }

        class DOTweenPath : DG.Tweening.Core.ABSAnimationComponent
        {
            static /*0x0*/ System.Action<DG.Tweening.DOTweenPath> OnReset;
            static /*0x8*/ System.Reflection.MethodInfo _miCreateTween;
            /*0x68*/ float delay;
            /*0x6c*/ float duration;
            /*0x70*/ DG.Tweening.Ease easeType;
            /*0x78*/ UnityEngine.AnimationCurve easeCurve;
            /*0x80*/ int loops;
            /*0x88*/ string id;
            /*0x90*/ DG.Tweening.LoopType loopType;
            /*0x94*/ DG.Tweening.Plugins.Options.OrientType orientType;
            /*0x98*/ UnityEngine.Transform lookAtTransform;
            /*0xa0*/ UnityEngine.Vector3 lookAtPosition;
            /*0xac*/ float lookAhead;
            /*0xb0*/ bool autoPlay;
            /*0xb1*/ bool autoKill;
            /*0xb2*/ bool relative;
            /*0xb3*/ bool isLocal;
            /*0xb4*/ bool isClosedPath;
            /*0xb8*/ int pathResolution;
            /*0xbc*/ DG.Tweening.PathMode pathMode;
            /*0xc0*/ DG.Tweening.AxisConstraint lockRotation;
            /*0xc4*/ bool assignForwardAndUp;
            /*0xc8*/ UnityEngine.Vector3 forwardDirection;
            /*0xd4*/ UnityEngine.Vector3 upDirection;
            /*0xe0*/ bool tweenRigidbody;
            /*0xe8*/ System.Collections.Generic.List<UnityEngine.Vector3> wps;
            /*0xf0*/ System.Collections.Generic.List<UnityEngine.Vector3> fullWps;
            /*0xf8*/ DG.Tweening.Plugins.Core.PathCore.Path path;
            /*0x100*/ DG.Tweening.DOTweenInspectorMode inspectorMode;
            /*0x104*/ DG.Tweening.PathType pathType;
            /*0x108*/ DG.Tweening.HandlesType handlesType;
            /*0x10c*/ bool livePreview;
            /*0x110*/ DG.Tweening.HandlesDrawMode handlesDrawMode;
            /*0x114*/ float perspectiveHandleSize;
            /*0x118*/ bool showIndexes;
            /*0x119*/ bool showWpLength;
            /*0x11c*/ UnityEngine.Color pathColor;
            /*0x12c*/ UnityEngine.Vector3 lastSrcPosition;
            /*0x138*/ UnityEngine.Quaternion lastSrcRotation;
            /*0x148*/ bool wpsDropdown;
            /*0x14c*/ float dropToFloorOffset;

            static /*0xe2b6f0*/ void add_OnReset(System.Action<DG.Tweening.DOTweenPath> value);
            static /*0xe2b7bc*/ void remove_OnReset(System.Action<DG.Tweening.DOTweenPath> value);
            static /*0xe2b888*/ void Dispatch_OnReset(DG.Tweening.DOTweenPath path);
            /*0xe2cd88*/ DOTweenPath();
            /*0xe2b8f4*/ void Awake();
            /*0xe2c738*/ void Reset();
            /*0xe2c834*/ void OnDestroy();
            /*0xe2c864*/ void DOPlay();
            /*0xe2c8ac*/ void DOPlayById(string id);
            /*0xe2c928*/ void DOPlayAllById(string id);
            /*0xe2c980*/ void DOPlayBackwards();
            /*0xe2c98c*/ void DOPlayForward();
            /*0xe2c998*/ void DOPause();
            /*0xe2c9e0*/ void DOTogglePause();
            /*0xe2c9ec*/ void DORewind();
            /*0xe2c9fc*/ void DORestart();
            /*0xe2ca0c*/ void DORestart(bool fromHere);
            /*0xe2cab4*/ void DOComplete();
            /*0xe2cac0*/ void DOKill();
            /*0xe2cad0*/ void DOKillAllById(string id);
            /*0xe2cb2c*/ DG.Tweening.Tween GetTween();
            /*0xe2cbb0*/ UnityEngine.Vector3[] GetDrawPoints();
            /*0xe2cc30*/ UnityEngine.Vector3[] GetFullWps();
            /*0xe2c5dc*/ void ReEvaluateRelativeTween();
            /*0xe2d014*/ void <Awake>b__44_0();
        }

        class DOTweenPro
        {
            static /*0x0*/ string Version;

            static /*0xe2d024*/ DOTweenPro();
            /*0xe2d01c*/ DOTweenPro();
        }

        enum SpiralMode
        {
            Expand = 0,
            ExpandThenContract = 1,
        }

        namespace Plugins
        {
            struct SpiralOptions : DG.Tweening.Plugins.Options.IPlugOptions
            {
                /*0x10*/ float depth;
                /*0x14*/ float frequency;
                /*0x18*/ float speed;
                /*0x1c*/ DG.Tweening.SpiralMode mode;
                /*0x20*/ bool snapping;
                /*0x24*/ float unit;
                /*0x28*/ UnityEngine.Quaternion axisQ;

                /*0xe2d084*/ void Reset();
            }

            class SpiralPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>
            {
                static /*0x0*/ UnityEngine.Vector3 DefaultDirection;

                static /*0xe2d504*/ SpiralPlugin();
                static /*0xe2d09c*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> Get();
                /*0xe2d4bc*/ SpiralPlugin();
                /*0xe2d090*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> t);
                /*0xe2d094*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> t, bool isRelative);
                /*0xe2d098*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0xe2d0dc*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> t, UnityEngine.Vector3 value);
                /*0xe2d0e0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> t);
                /*0xe2d0e4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> t);
                /*0xe2d194*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.SpiralOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0xe2d198*/ void EvaluateAndApply(DG.Tweening.Plugins.SpiralOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }
        }

        namespace Core
        {
            class ABSAnimationComponent : UnityEngine.MonoBehaviour
            {
                /*0x18*/ DG.Tweening.UpdateType updateType;
                /*0x1c*/ bool isSpeedBased;
                /*0x1d*/ bool hasOnStart;
                /*0x1e*/ bool hasOnPlay;
                /*0x1f*/ bool hasOnUpdate;
                /*0x20*/ bool hasOnStepComplete;
                /*0x21*/ bool hasOnComplete;
                /*0x22*/ bool hasOnTweenCreated;
                /*0x23*/ bool hasOnRewind;
                /*0x28*/ UnityEngine.Events.UnityEvent onStart;
                /*0x30*/ UnityEngine.Events.UnityEvent onPlay;
                /*0x38*/ UnityEngine.Events.UnityEvent onUpdate;
                /*0x40*/ UnityEngine.Events.UnityEvent onStepComplete;
                /*0x48*/ UnityEngine.Events.UnityEvent onComplete;
                /*0x50*/ UnityEngine.Events.UnityEvent onTweenCreated;
                /*0x58*/ UnityEngine.Events.UnityEvent onRewind;
                /*0x60*/ DG.Tweening.Tween tween;

                /*0xe2d00c*/ ABSAnimationComponent();
                void DOPlay();
                void DOPlayBackwards();
                void DOPlayForward();
                void DOPause();
                void DOTogglePause();
                void DORewind();
                void DORestart();
                void DORestart(bool fromHere);
                void DOComplete();
                void DOKill();
            }

            enum OnDisableBehaviour
            {
                None = 0,
                Pause = 1,
                Rewind = 2,
                Kill = 3,
                KillAndComplete = 4,
                DestroyGameObject = 5,
            }

            enum OnEnableBehaviour
            {
                None = 0,
                Play = 1,
                Restart = 2,
                RestartFromSpawnPoint = 3,
            }

            enum VisualManagerPreset
            {
                Custom = 0,
                PoolingSystem = 1,
            }
        }
    }
}
