class <Module>
{
}

namespace DG
{
    namespace Tweening
    {
        enum AutoPlay
        {
            None = 0,
            AutoPlaySequences = 1,
            AutoPlayTweeners = 2,
            All = 3,
        }

        enum AxisConstraint
        {
            None = 0,
            X = 2,
            Y = 4,
            Z = 8,
            W = 16,
        }

        struct Color2
        {
            /*0x10*/ UnityEngine.Color ca;
            /*0x20*/ UnityEngine.Color cb;

            static /*0xdec630*/ DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0xdec648*/ DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0xdec660*/ DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, float f);
            /*0xdec61c*/ Color2(UnityEngine.Color ca, UnityEngine.Color cb);
        }

        class TweenCallback : System.MulticastDelegate
        {
            /*0xdec674*/ TweenCallback(object object, nint method);
            /*0xdec730*/ void Invoke();
            /*0xdec744*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0xdec764*/ void EndInvoke(System.IAsyncResult result);
        }

        class TweenCallback<T> : System.MulticastDelegate
        {
            TweenCallback(object object, nint method);
            void Invoke(T value);
            System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class EaseFunction : System.MulticastDelegate
        {
            /*0xdec770*/ EaseFunction(object object, nint method);
            /*0xdec834*/ float Invoke(float time, float duration, float overshootOrAmplitude, float period);
            /*0xdec848*/ System.IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, System.AsyncCallback callback, object object);
            /*0xdec90c*/ float EndInvoke(System.IAsyncResult result);
        }

        class DOCurve
        {
            class CubicBezier
            {
                static /*0xdec934*/ UnityEngine.Vector3 GetPointOnSegment(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, float factor);
                static /*0xdec9cc*/ UnityEngine.Vector3[] GetSegmentPointCloud(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, int resolution);
                static /*0xdecaf4*/ void GetSegmentPointCloud(System.Collections.Generic.List<UnityEngine.Vector3> addToList, UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, int resolution);
            }
        }

        class DOTween
        {
            static /*0x0*/ string Version;
            static /*0x8*/ bool useSafeMode;
            static /*0xc*/ DG.Tweening.Core.Enums.SafeModeLogBehaviour safeModeLogBehaviour;
            static /*0x10*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
            static /*0x14*/ bool showUnityEditorReport;
            static /*0x18*/ float timeScale;
            static /*0x1c*/ float unscaledTimeScale;
            static /*0x20*/ bool useSmoothDeltaTime;
            static /*0x24*/ float maxSmoothUnscaledTime;
            static /*0x28*/ DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
            static /*0x2c*/ DG.Tweening.LogBehaviour _logBehaviour;
            static /*0x30*/ System.Func<UnityEngine.LogType, object, bool> onWillLog;
            static /*0x38*/ bool drawGizmos;
            static /*0x39*/ bool debugMode;
            static /*0x3a*/ bool _fooDebugStoreTargetId;
            static /*0x3c*/ DG.Tweening.UpdateType defaultUpdateType;
            static /*0x40*/ bool defaultTimeScaleIndependent;
            static /*0x44*/ DG.Tweening.AutoPlay defaultAutoPlay;
            static /*0x48*/ bool defaultAutoKill;
            static /*0x4c*/ DG.Tweening.LoopType defaultLoopType;
            static /*0x50*/ bool defaultRecyclable;
            static /*0x54*/ DG.Tweening.Ease defaultEaseType;
            static /*0x58*/ float defaultEaseOvershootOrAmplitude;
            static /*0x5c*/ float defaultEasePeriod;
            static /*0x60*/ DG.Tweening.Core.DOTweenComponent instance;
            static /*0x68*/ bool _foo_isQuitting;
            static /*0x6c*/ int maxActiveTweenersReached;
            static /*0x70*/ int maxActiveSequencesReached;
            static /*0x74*/ DG.Tweening.Core.SafeModeReport safeModeReport;
            static /*0x88*/ System.Collections.Generic.List<DG.Tweening.TweenCallback> GizmosDelegates;
            static /*0x90*/ bool initialized;
            static /*0x94*/ int _isQuittingFrame;

            static /*0xdf11f4*/ DOTween();
            static /*0xdecc48*/ DG.Tweening.LogBehaviour get_logBehaviour();
            static /*0xdecca0*/ void set_logBehaviour(DG.Tweening.LogBehaviour value);
            static /*0xdecd04*/ bool get_debugStoreTargetId();
            static /*0xdecda4*/ void set_debugStoreTargetId(bool value);
            static /*0xdece00*/ bool get_isQuitting();
            static /*0xdecec8*/ void set_isQuitting(bool value);
            static /*0xdecf60*/ DG.Tweening.IDOTweenInit Init(System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0xded730*/ void AutoInit();
            static /*0xded0bc*/ DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0xded828*/ void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity);
            static /*0xded890*/ void Clear(bool destroy);
            static /*0xded8e8*/ void Clear(bool destroy, bool isApplicationQuitting);
            static /*0xdeda58*/ void ClearCachedTweens();
            static /*0xdedaa8*/ int Validate();
            static /*0xdedaf8*/ void ManualUpdate(float deltaTime, float unscaledDeltaTime);
            static /*0xdedc88*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration);
            static /*0xdedd20*/ DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, double endValue, float duration);
            static /*0xdeddb8*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, int endValue, float duration);
            static /*0xdede50*/ DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, uint endValue, float duration);
            static /*0xdedee8*/ DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, long endValue, float duration);
            static /*0xdedf80*/ DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, ulong endValue, float duration);
            static /*0xdee018*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, string endValue, float duration);
            static /*0xdee0b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, float duration);
            static /*0xdee158*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0xdee208*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, float duration);
            static /*0xdee2c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0xdee378*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration);
            static /*0xdee438*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, float duration);
            static /*0xdee4f8*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, float duration);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration);
            static /*0xdee590*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float endValue, float duration, DG.Tweening.AxisConstraint axisConstraint);
            static /*0xdee644*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float endValue, float duration);
            static /*0xdee718*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<float> setter, float startValue, float endValue, float duration);
            static /*0xdee888*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, float duration, int vibrato, float elasticity);
            static /*0xdeee9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, float strength, int vibrato, float randomness, bool ignoreZAxis, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdef794*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdeef64*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdeec78*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, float[] durations);
            static /*0xdef860*/ DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, float duration);
            static /*0xdef914*/ DG.Tweening.Sequence Sequence();
            static /*0xdefa70*/ DG.Tweening.Sequence Sequence(object target);
            static /*0xdefae0*/ int CompleteAll(bool withCallbacks);
            static /*0xdefb68*/ int Complete(object targetOrId, bool withCallbacks);
            static /*0xdefc0c*/ int CompleteAndReturnKilledTot();
            static /*0xdefc78*/ int CompleteAndReturnKilledTot(object targetOrId);
            static /*0xdefcfc*/ int CompleteAndReturnKilledTot(object target, object id);
            static /*0xdefd88*/ int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds);
            static /*0xdefdf8*/ int FlipAll();
            static /*0xdefe64*/ int Flip(object targetOrId);
            static /*0xdefee8*/ int GotoAll(float to, bool andPlay);
            static /*0xdeff64*/ int Goto(object targetOrId, float to, bool andPlay);
            static /*0xdefffc*/ int KillAll(bool complete);
            static /*0xdf0090*/ int KillAll(bool complete, object[] idsOrTargetsToExclude);
            static /*0xdf0190*/ int Kill(object targetOrId, bool complete);
            static /*0xdf0254*/ int Kill(object target, object id, bool complete);
            static /*0xdf0328*/ int PauseAll();
            static /*0xdf0394*/ int Pause(object targetOrId);
            static /*0xdf0418*/ int PlayAll();
            static /*0xdf0484*/ int Play(object targetOrId);
            static /*0xdf0508*/ int Play(object target, object id);
            static /*0xdf0594*/ int PlayBackwardsAll();
            static /*0xdf0600*/ int PlayBackwards(object targetOrId);
            static /*0xdf0684*/ int PlayBackwards(object target, object id);
            static /*0xdf0710*/ int PlayForwardAll();
            static /*0xdf077c*/ int PlayForward(object targetOrId);
            static /*0xdf0800*/ int PlayForward(object target, object id);
            static /*0xdf088c*/ int RestartAll(bool includeDelay);
            static /*0xdf08fc*/ int Restart(object targetOrId, bool includeDelay, float changeDelayTo);
            static /*0xdf0994*/ int Restart(object target, object id, bool includeDelay, float changeDelayTo);
            static /*0xdf0a40*/ int RewindAll(bool includeDelay);
            static /*0xdf0ab0*/ int Rewind(object targetOrId, bool includeDelay);
            static /*0xdf0b38*/ int SmoothRewindAll();
            static /*0xdf0ba4*/ int SmoothRewind(object targetOrId);
            static /*0xdf0c28*/ int TogglePauseAll();
            static /*0xdf0c94*/ int TogglePause(object targetOrId);
            static /*0xdf0d18*/ bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying);
            static /*0xdf0da0*/ int TotalActiveTweens();
            static /*0xdf0df8*/ int TotalActiveTweeners();
            static /*0xdf0e50*/ int TotalActiveSequences();
            static /*0xdf0ea8*/ int TotalPlayingTweens();
            static /*0xdf0ef8*/ int TotalTweensById(object id, bool playingOnly);
            static /*0xdf0f6c*/ System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0xdf0ffc*/ System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0xdf108c*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0xdf1148*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0xdedbec*/ void InitCheck();
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            /*0xdf11ec*/ DOTween();

            class <>c__DisplayClass67_0
            {
                /*0x10*/ float v;
                /*0x18*/ DG.Tweening.Core.DOSetter<float> setter;

                /*0xdee880*/ <>c__DisplayClass67_0();
                /*0xdf1328*/ float <To>b__0();
                /*0xdf1330*/ void <To>b__1(float x);
            }
        }

        class DOVirtual
        {
            static /*0xdf1358*/ DG.Tweening.Tweener Float(float from, float to, float duration, DG.Tweening.TweenCallback<float> onVirtualUpdate);
            static /*0xdf151c*/ DG.Tweening.Tweener Int(int from, int to, float duration, DG.Tweening.TweenCallback<int> onVirtualUpdate);
            static /*0xdf16e0*/ DG.Tweening.Tweener Vector3(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float duration, DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate);
            static /*0xdf18d0*/ DG.Tweening.Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate);
            static /*0xdf1ad4*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0xdf1b70*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0xdf1c14*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0xdf1c58*/ float EasedValue(float from, float to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0xdf1d6c*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0xdf1e40*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0xdf1f1c*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0xdf1f90*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0xdf20dc*/ DG.Tweening.Tween DelayedCall(float delay, DG.Tweening.TweenCallback callback, bool ignoreTimeScale);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ float val;
                /*0x18*/ DG.Tweening.TweenCallback<float> onVirtualUpdate;

                /*0xdf1514*/ <>c__DisplayClass0_0();
                /*0xdf21fc*/ float <Float>b__0();
                /*0xdf2204*/ void <Float>b__1(float x);
                /*0xdf220c*/ void <Float>b__2();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ int val;
                /*0x18*/ DG.Tweening.TweenCallback<int> onVirtualUpdate;

                /*0xdf16d8*/ <>c__DisplayClass1_0();
                /*0xdf2234*/ int <Int>b__0();
                /*0xdf223c*/ void <Int>b__1(int x);
                /*0xdf2244*/ void <Int>b__2();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Vector3 val;
                /*0x20*/ DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate;

                /*0xdf18c8*/ <>c__DisplayClass2_0();
                /*0xdf226c*/ UnityEngine.Vector3 <Vector3>b__0();
                /*0xdf2278*/ void <Vector3>b__1(UnityEngine.Vector3 x);
                /*0xdf2284*/ void <Vector3>b__2();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Color val;
                /*0x20*/ DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate;

                /*0xdf1acc*/ <>c__DisplayClass3_0();
                /*0xdf22b0*/ UnityEngine.Color <Color>b__0();
                /*0xdf22bc*/ void <Color>b__1(UnityEngine.Color x);
                /*0xdf22c8*/ void <Color>b__2();
            }
        }

        enum Ease
        {
            Unset = 0,
            Linear = 1,
            InSine = 2,
            OutSine = 3,
            InOutSine = 4,
            InQuad = 5,
            OutQuad = 6,
            InOutQuad = 7,
            InCubic = 8,
            OutCubic = 9,
            InOutCubic = 10,
            InQuart = 11,
            OutQuart = 12,
            InOutQuart = 13,
            InQuint = 14,
            OutQuint = 15,
            InOutQuint = 16,
            InExpo = 17,
            OutExpo = 18,
            InOutExpo = 19,
            InCirc = 20,
            OutCirc = 21,
            InOutCirc = 22,
            InElastic = 23,
            OutElastic = 24,
            InOutElastic = 25,
            InBack = 26,
            OutBack = 27,
            InOutBack = 28,
            InBounce = 29,
            OutBounce = 30,
            InOutBounce = 31,
            Flash = 32,
            InFlash = 33,
            OutFlash = 34,
            InOutFlash = 35,
            INTERNAL_Zero = 36,
            INTERNAL_Custom = 37,
        }

        class EaseFactory
        {
            static /*0xdf22f4*/ DG.Tweening.EaseFunction StopMotion(int motionFps, System.Nullable<DG.Tweening.Ease> ease);
            static /*0xdf2470*/ DG.Tweening.EaseFunction StopMotion(int motionFps, UnityEngine.AnimationCurve animCurve);
            static /*0xdf23ac*/ DG.Tweening.EaseFunction StopMotion(int motionFps, DG.Tweening.EaseFunction customEase);
            /*0xdf2530*/ EaseFactory();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ float motionDelay;
                /*0x18*/ DG.Tweening.EaseFunction customEase;

                /*0xdf2528*/ <>c__DisplayClass2_0();
                /*0xdf2538*/ float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period);
            }
        }

        interface IDOTweenInit
        {
            DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
        }

        enum LinkBehaviour
        {
            PauseOnDisable = 0,
            PauseOnDisablePlayOnEnable = 1,
            PauseOnDisableRestartOnEnable = 2,
            PlayOnEnable = 3,
            RestartOnEnable = 4,
            KillOnDisable = 5,
            KillOnDestroy = 6,
            CompleteOnDisable = 7,
            CompleteAndKillOnDisable = 8,
            RewindOnDisable = 9,
            RewindAndKillOnDisable = 10,
        }

        enum PathMode
        {
            Ignore = 0,
            Full3D = 1,
            TopDown2D = 2,
            Sidescroller2D = 3,
        }

        enum PathType
        {
            Linear = 0,
            CatmullRom = 1,
            CubicBezier = 2,
        }

        enum RotateMode
        {
            Fast = 0,
            FastBeyond360 = 1,
            WorldAxisAdd = 2,
            LocalAxisAdd = 3,
        }

        enum ScrambleMode
        {
            None = 0,
            All = 1,
            Uppercase = 2,
            Lowercase = 3,
            Numerals = 4,
            Custom = 5,
        }

        enum ShakeRandomnessMode
        {
            Full = 0,
            Harmonic = 1,
        }

        class TweenExtensions
        {
            static /*0xdf25a8*/ void Complete(DG.Tweening.Tween t);
            static /*0xdf25b0*/ void Complete(DG.Tweening.Tween t, bool withCallbacks);
            static /*0xdf272c*/ void Flip(DG.Tweening.Tween t);
            static /*0xdf2894*/ void ForceInit(DG.Tweening.Tween t);
            static /*0xdf2a00*/ void Goto(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0xdf2bf4*/ void GotoWithCallbacks(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0xdf2a0c*/ void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks);
            static /*0xdf2c00*/ void Kill(DG.Tweening.Tween t, bool complete);
            static /*0xdf2d74*/ void ManualUpdate(DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime);
            static T Pause<T>(T t);
            static T Play<T>(T t);
            static /*0xdf2f08*/ void PlayBackwards(DG.Tweening.Tween t);
            static /*0xdf3070*/ void PlayForward(DG.Tweening.Tween t);
            static /*0xdf31d8*/ void Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
            static /*0xdf3368*/ void Rewind(DG.Tweening.Tween t, bool includeDelay);
            static /*0xdf34d8*/ void SmoothRewind(DG.Tweening.Tween t);
            static /*0xdf3640*/ void TogglePause(DG.Tweening.Tween t);
            static /*0xdf37a8*/ void GotoWaypoint(DG.Tweening.Tween t, int waypointIndex, bool andPlay);
            static /*0xdf3b28*/ UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t);
            static /*0xdf3c0c*/ UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t);
            static /*0xdf3cf0*/ UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t);
            static /*0xdf3dd4*/ UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0xdf3ec0*/ UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, float position);
            static /*0xdf3fb8*/ UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t);
            static /*0xdf409c*/ int CompletedLoops(DG.Tweening.Tween t);
            static /*0xdf4118*/ float Delay(DG.Tweening.Tween t);
            static /*0xdf41a0*/ float ElapsedDelay(DG.Tweening.Tween t);
            static /*0xdf4228*/ float Duration(DG.Tweening.Tween t, bool includeLoops);
            static /*0xdf42dc*/ float Elapsed(DG.Tweening.Tween t, bool includeLoops);
            static /*0xdf4388*/ float ElapsedPercentage(DG.Tweening.Tween t, bool includeLoops);
            static /*0xdf4458*/ float ElapsedDirectionalPercentage(DG.Tweening.Tween t);
            static /*0xdf4530*/ bool IsActive(DG.Tweening.Tween t);
            static /*0xdf4544*/ bool IsBackwards(DG.Tweening.Tween t);
            static /*0xdf45c8*/ bool IsComplete(DG.Tweening.Tween t);
            static /*0xdf464c*/ bool IsInitialized(DG.Tweening.Tween t);
            static /*0xdf46d0*/ bool IsPlaying(DG.Tweening.Tween t);
            static /*0xdf4754*/ int Loops(DG.Tweening.Tween t);
            static /*0xdf47d0*/ UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, float pathPercentage);
            static /*0xdf4a64*/ UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, int subdivisionsXSegment);
            static /*0xdf4ca4*/ float PathLength(DG.Tweening.Tween t);
        }

        enum LoopType
        {
            Restart = 0,
            Yoyo = 1,
            Incremental = 2,
        }

        class Sequence : DG.Tweening.Tween
        {
            /*0x120*/ System.Collections.Generic.List<DG.Tweening.Tween> sequencedTweens;
            /*0x128*/ System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> _sequencedObjs;
            /*0x130*/ float lastTweenInsertTime;

            static /*0xdf5004*/ DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t);
            static /*0xdf5124*/ DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, float atPosition);
            static /*0xdf5344*/ DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0xdf536c*/ DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0xdf5440*/ DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, float atPosition);
            static /*0xdef99c*/ void Setup(DG.Tweening.Sequence s);
            static /*0xdf575c*/ bool DoStartup(DG.Tweening.Sequence s);
            static /*0xdf59b0*/ bool DoApplyTween(DG.Tweening.Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0xdf5e80*/ bool ApplyInternalCycle(DG.Tweening.Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep);
            static /*0xdf5d50*/ void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list);
            static /*0xdf5cf0*/ bool IsAnyCallbackSet(DG.Tweening.Sequence s);
            /*0xdf4ef0*/ Sequence();
            /*0xdf5544*/ float UpdateDelay(float elapsed);
            /*0xdf5570*/ void Reset();
            /*0xdf56a8*/ bool Validate();
            /*0xdf5758*/ bool Startup();
            /*0xdf59a8*/ bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class ShortcutExtensions
        {
            static /*0xdf6780*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, float endValue, float duration);
            static /*0xdf68f0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, float duration);
            static /*0xdf6a88*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0xdf6bf8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, float endValue, float duration);
            static /*0xdf6d68*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0xdf6ed8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, float endValue, float duration);
            static /*0xdf7048*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0xdf71e0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0xdf7378*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdf75e4*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdf7868*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdf7ad4*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdf7d58*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0xdf7ef0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, float endValue, float duration);
            static /*0xdf8060*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, float endValue, float duration);
            static /*0xdf81d0*/ DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, float duration);
            static /*0xdf8360*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0xdf84f8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0xdf86fc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0xdf8904*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, float duration);
            static /*0xdf8a74*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0xdf8c50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0xdf8e30*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0xdf900c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0xdf91ec*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0xdf936c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0xdf9558*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0xdf96d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0xdf98c4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, string property, float duration);
            static /*0xdf9ac8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, int propertyID, float duration);
            static /*0xdf9cd0*/ DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, float toStartWidth, float toEndWidth, float duration);
            static /*0xdf9e44*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, float endValue, float duration);
            static /*0xdf9fb4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0xdfa170*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0xdfa328*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0xdfa4c4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0xdfa660*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0xdfa804*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0xdfa9a0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0xdfab3c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0xdfacd8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0xdfae74*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0xdfb040*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0xdfb1dc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0xdfb3a8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration);
            static /*0xdfb530*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, float endValue, float duration);
            static /*0xdfb6a8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, float endValue, float duration);
            static /*0xdfb83c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, float endValue, float duration);
            static /*0xdfb9d0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, float endValue, float duration);
            static /*0xdfbb64*/ DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0xdfbdd8*/ DG.Tweening.Tweener DODynamicLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0xdfbb6c*/ DG.Tweening.Tweener LookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up, bool dynamic);
            static /*0xdfbde8*/ DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0xdfc048*/ DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0xdfc290*/ DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0xdfc4d8*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdfc74c*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdfc9d4*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdfcc40*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdfcec4*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdfd1a0*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xdfd424*/ DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0xdfd988*/ DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0xdfde64*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0xdfe09c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0xdfe2dc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0xdfe48c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0xdfe644*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, float endValue, float duration);
            static /*0xdfe7b4*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0xdfe9a8*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0xdfeb9c*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0xdfee20*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0xdff0a8*/ DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0xdff2a0*/ DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0xdff498*/ DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0xdff680*/ DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0xdff868*/ DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0xdffb0c*/ DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration);
            static /*0xdffcec*/ int DOComplete(UnityEngine.Component target, bool withCallbacks);
            static /*0xdffd50*/ int DOComplete(UnityEngine.Material target, bool withCallbacks);
            static /*0xdffdb4*/ int DOKill(UnityEngine.Component target, bool complete);
            static /*0xdffe18*/ int DOKill(UnityEngine.Material target, bool complete);
            static /*0xdffe7c*/ int DOFlip(UnityEngine.Component target);
            static /*0xdffed0*/ int DOFlip(UnityEngine.Material target);
            static /*0xdfff24*/ int DOGoto(UnityEngine.Component target, float to, bool andPlay);
            static /*0xdfff98*/ int DOGoto(UnityEngine.Material target, float to, bool andPlay);
            static /*0xe0000c*/ int DOPause(UnityEngine.Component target);
            static /*0xe00060*/ int DOPause(UnityEngine.Material target);
            static /*0xe000b4*/ int DOPlay(UnityEngine.Component target);
            static /*0xe00108*/ int DOPlay(UnityEngine.Material target);
            static /*0xe0015c*/ int DOPlayBackwards(UnityEngine.Component target);
            static /*0xe001b0*/ int DOPlayBackwards(UnityEngine.Material target);
            static /*0xe00204*/ int DOPlayForward(UnityEngine.Component target);
            static /*0xe00258*/ int DOPlayForward(UnityEngine.Material target);
            static /*0xe002ac*/ int DORestart(UnityEngine.Component target, bool includeDelay);
            static /*0xe00314*/ int DORestart(UnityEngine.Material target, bool includeDelay);
            static /*0xe0037c*/ int DORewind(UnityEngine.Component target, bool includeDelay);
            static /*0xe003e0*/ int DORewind(UnityEngine.Material target, bool includeDelay);
            static /*0xe00444*/ int DOSmoothRewind(UnityEngine.Component target);
            static /*0xe00498*/ int DOSmoothRewind(UnityEngine.Material target);
            static /*0xe004ec*/ int DOTogglePause(UnityEngine.Component target);
            static /*0xe00540*/ int DOTogglePause(UnityEngine.Material target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf68e8*/ <>c__DisplayClass0_0();
                /*0xe00594*/ float <DOAspect>b__0();
                /*0xe005b0*/ void <DOAspect>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf6a80*/ <>c__DisplayClass1_0();
                /*0xe005cc*/ UnityEngine.Color <DOColor>b__0();
                /*0xe005e8*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf6bf0*/ <>c__DisplayClass2_0();
                /*0xe00604*/ float <DOFarClipPlane>b__0();
                /*0xe00620*/ void <DOFarClipPlane>b__1(float x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf6d60*/ <>c__DisplayClass3_0();
                /*0xe0063c*/ float <DOFieldOfView>b__0();
                /*0xe00658*/ void <DOFieldOfView>b__1(float x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf6ed0*/ <>c__DisplayClass4_0();
                /*0xe00674*/ float <DONearClipPlane>b__0();
                /*0xe00690*/ void <DONearClipPlane>b__1(float x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf7040*/ <>c__DisplayClass5_0();
                /*0xe006ac*/ float <DOOrthoSize>b__0();
                /*0xe006c8*/ void <DOOrthoSize>b__1(float x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf71d8*/ <>c__DisplayClass6_0();
                /*0xe006e4*/ UnityEngine.Rect <DOPixelRect>b__0();
                /*0xe00700*/ void <DOPixelRect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf7370*/ <>c__DisplayClass7_0();
                /*0xe0071c*/ UnityEngine.Rect <DORect>b__0();
                /*0xe00738*/ void <DORect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf75dc*/ <>c__DisplayClass8_0();
                /*0xe00754*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0xe0077c*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf7860*/ <>c__DisplayClass9_0();
                /*0xe007cc*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0xe007f4*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf7acc*/ <>c__DisplayClass10_0();
                /*0xe00844*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0xe0086c*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0xdf7d50*/ <>c__DisplayClass11_0();
                /*0xe008d4*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0xe008fc*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0xdf7ee8*/ <>c__DisplayClass12_0();
                /*0xe00964*/ UnityEngine.Color <DOColor>b__0();
                /*0xe00980*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0xdf8058*/ <>c__DisplayClass13_0();
                /*0xe0099c*/ float <DOIntensity>b__0();
                /*0xe009b8*/ void <DOIntensity>b__1(float x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0xdf81c8*/ <>c__DisplayClass14_0();
                /*0xe009d4*/ float <DOShadowStrength>b__0();
                /*0xe009f0*/ void <DOShadowStrength>b__1(float x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ DG.Tweening.Color2 startValue;
                /*0x30*/ UnityEngine.LineRenderer target;

                /*0xdf8358*/ <>c__DisplayClass15_0();
                /*0xe00a0c*/ DG.Tweening.Color2 <DOColor>b__0();
                /*0xe00a18*/ void <DOColor>b__1(DG.Tweening.Color2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0xdf84f0*/ <>c__DisplayClass16_0();
                /*0xe00a44*/ UnityEngine.Color <DOColor>b__0();
                /*0xe00a60*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0xdf86f4*/ <>c__DisplayClass17_0();
                /*0xe00a7c*/ UnityEngine.Color <DOColor>b__0();
                /*0xe00aa0*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0xdf88fc*/ <>c__DisplayClass18_0();
                /*0xe00ac4*/ UnityEngine.Color <DOColor>b__0();
                /*0xe00ae8*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0xdf8a6c*/ <>c__DisplayClass19_0();
                /*0xe00b0c*/ UnityEngine.Color <DOFade>b__0();
                /*0xe00b28*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0xdf8c48*/ <>c__DisplayClass20_0();
                /*0xe00b44*/ UnityEngine.Color <DOFade>b__0();
                /*0xe00b68*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0xdf8e28*/ <>c__DisplayClass21_0();
                /*0xe00b8c*/ UnityEngine.Color <DOFade>b__0();
                /*0xe00bb0*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0xdf9004*/ <>c__DisplayClass22_0();
                /*0xe00bd4*/ float <DOFloat>b__0();
                /*0xe00bf8*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0xdf91e4*/ <>c__DisplayClass23_0();
                /*0xe00c1c*/ float <DOFloat>b__0();
                /*0xe00c40*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0xdf9364*/ <>c__DisplayClass24_0();
                /*0xe00c64*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0xe00c80*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0xdf9550*/ <>c__DisplayClass25_0();
                /*0xe00c9c*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0xe00cc0*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0xdf96d0*/ <>c__DisplayClass26_0();
                /*0xe00ce4*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0xe00d00*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0xdf98bc*/ <>c__DisplayClass27_0();
                /*0xe00d1c*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0xe00d40*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0xdf9ac0*/ <>c__DisplayClass28_0();
                /*0xe00d64*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0xe00d88*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0xdf9cc8*/ <>c__DisplayClass29_0();
                /*0xe00dac*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0xe00dd0*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0xdf9e3c*/ <>c__DisplayClass30_0();
                /*0xe00df4*/ UnityEngine.Vector2 <DOResize>b__0();
                /*0xe00e3c*/ void <DOResize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0xdf9fac*/ <>c__DisplayClass31_0();
                /*0xe00e7c*/ float <DOTime>b__0();
                /*0xe00e98*/ void <DOTime>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfa150*/ <>c__DisplayClass32_0();
                /*0xe00eb4*/ UnityEngine.Vector3 <DOMove>b__0();
                /*0xe00ed0*/ void <DOMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfa304*/ <>c__DisplayClass33_0();
                /*0xe00eec*/ UnityEngine.Vector3 <DOMoveX>b__0();
                /*0xe00f08*/ void <DOMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfa4bc*/ <>c__DisplayClass34_0();
                /*0xe00f24*/ UnityEngine.Vector3 <DOMoveY>b__0();
                /*0xe00f40*/ void <DOMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfa658*/ <>c__DisplayClass35_0();
                /*0xe00f5c*/ UnityEngine.Vector3 <DOMoveZ>b__0();
                /*0xe00f78*/ void <DOMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfa7fc*/ <>c__DisplayClass36_0();
                /*0xe00f94*/ UnityEngine.Vector3 <DOLocalMove>b__0();
                /*0xe00fb0*/ void <DOLocalMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfa998*/ <>c__DisplayClass37_0();
                /*0xe00fcc*/ UnityEngine.Vector3 <DOLocalMoveX>b__0();
                /*0xe00fe8*/ void <DOLocalMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfab34*/ <>c__DisplayClass38_0();
                /*0xe01004*/ UnityEngine.Vector3 <DOLocalMoveY>b__0();
                /*0xe01020*/ void <DOLocalMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfacd0*/ <>c__DisplayClass39_0();
                /*0xe0103c*/ UnityEngine.Vector3 <DOLocalMoveZ>b__0();
                /*0xe01058*/ void <DOLocalMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfae6c*/ <>c__DisplayClass40_0();
                /*0xe01074*/ UnityEngine.Quaternion <DORotate>b__0();
                /*0xe01090*/ void <DORotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb038*/ <>c__DisplayClass41_0();
                /*0xe010ac*/ UnityEngine.Quaternion <DORotateQuaternion>b__0();
                /*0xe010c8*/ void <DORotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass42_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb1d4*/ <>c__DisplayClass42_0();
                /*0xe010e4*/ UnityEngine.Quaternion <DOLocalRotate>b__0();
                /*0xe01100*/ void <DOLocalRotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb3a0*/ <>c__DisplayClass43_0();
                /*0xe0111c*/ UnityEngine.Quaternion <DOLocalRotateQuaternion>b__0();
                /*0xe01138*/ void <DOLocalRotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass44_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb528*/ <>c__DisplayClass44_0();
                /*0xe01154*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0xe01170*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb6a0*/ <>c__DisplayClass45_0();
                /*0xe0118c*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0xe011a8*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass46_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb834*/ <>c__DisplayClass46_0();
                /*0xe011c4*/ UnityEngine.Vector3 <DOScaleX>b__0();
                /*0xe011e0*/ void <DOScaleX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfb9c8*/ <>c__DisplayClass47_0();
                /*0xe011fc*/ UnityEngine.Vector3 <DOScaleY>b__0();
                /*0xe01218*/ void <DOScaleY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfbb5c*/ <>c__DisplayClass48_0();
                /*0xe01234*/ UnityEngine.Vector3 <DOScaleZ>b__0();
                /*0xe01250*/ void <DOScaleZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfbde0*/ <>c__DisplayClass51_0();
                /*0xe0126c*/ UnityEngine.Quaternion <LookAt>b__0();
                /*0xe01288*/ void <LookAt>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfc028*/ <>c__DisplayClass52_0();
                /*0xe012a4*/ UnityEngine.Vector3 <DOPunchPosition>b__0();
                /*0xe012c0*/ void <DOPunchPosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfc288*/ <>c__DisplayClass53_0();
                /*0xe012dc*/ UnityEngine.Vector3 <DOPunchScale>b__0();
                /*0xe012f8*/ void <DOPunchScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass54_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfc4d0*/ <>c__DisplayClass54_0();
                /*0xe01314*/ UnityEngine.Vector3 <DOPunchRotation>b__0();
                /*0xe01330*/ void <DOPunchRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass55_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfc744*/ <>c__DisplayClass55_0();
                /*0xe0136c*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0xe01388*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfc9cc*/ <>c__DisplayClass56_0();
                /*0xe013a4*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0xe013c0*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass57_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfcc38*/ <>c__DisplayClass57_0();
                /*0xe013dc*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0xe013f8*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfcebc*/ <>c__DisplayClass58_0();
                /*0xe01434*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0xe01450*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfd198*/ <>c__DisplayClass59_0();
                /*0xe0148c*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0xe014a8*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfd41c*/ <>c__DisplayClass60_0();
                /*0xe014c4*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0xe014e0*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0xdfd8f8*/ <>c__DisplayClass61_0();
                /*0xe014fc*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0xe01518*/ void <DOJump>b__1(UnityEngine.Vector3 x);
                /*0xe01534*/ void <DOJump>b__2();
                /*0xe0155c*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0xe01578*/ void <DOJump>b__4(UnityEngine.Vector3 x);
                /*0xe01594*/ UnityEngine.Vector3 <DOJump>b__5();
                /*0xe015b0*/ void <DOJump>b__6(UnityEngine.Vector3 x);
                /*0xe015cc*/ void <DOJump>b__7();
            }

            class <>c__DisplayClass62_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0xdfde5c*/ <>c__DisplayClass62_0();
                /*0xe01678*/ UnityEngine.Vector3 <DOLocalJump>b__0();
                /*0xe01694*/ void <DOLocalJump>b__1(UnityEngine.Vector3 x);
                /*0xe016b0*/ void <DOLocalJump>b__2();
                /*0xe016d8*/ UnityEngine.Vector3 <DOLocalJump>b__3();
                /*0xe016f4*/ void <DOLocalJump>b__4(UnityEngine.Vector3 x);
                /*0xe01710*/ UnityEngine.Vector3 <DOLocalJump>b__5();
                /*0xe0172c*/ void <DOLocalJump>b__6(UnityEngine.Vector3 x);
                /*0xe01748*/ void <DOLocalJump>b__7();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfe094*/ <>c__DisplayClass63_0();
                /*0xe017f4*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0xe01810*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfe2d4*/ <>c__DisplayClass64_0();
                /*0xe0182c*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0xe01848*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfe484*/ <>c__DisplayClass65_0();
                /*0xe01864*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0xe01880*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xdfe63c*/ <>c__DisplayClass66_0();
                /*0xe0189c*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0xe018b8*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ DG.Tweening.Tween target;

                /*0xdfe7ac*/ <>c__DisplayClass67_0();
                /*0xe018d4*/ float <DOTimeScale>b__0();
                /*0xe018f0*/ void <DOTimeScale>b__1(float x);
            }

            class <>c__DisplayClass68_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Light target;

                /*0xdfe9a0*/ <>c__DisplayClass68_0();
                /*0xe0190c*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe01918*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass69_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;

                /*0xdfeb94*/ <>c__DisplayClass69_0();
                /*0xe01984*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe01990*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ string property;

                /*0xdfee18*/ <>c__DisplayClass70_0();
                /*0xe019fc*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe01a08*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass71_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ int propertyID;

                /*0xdff0a0*/ <>c__DisplayClass71_0();
                /*0xe01a88*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe01a94*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0xdff298*/ <>c__DisplayClass72_0();
                /*0xe01b14*/ UnityEngine.Vector3 <DOBlendableMoveBy>b__0();
                /*0xe01b20*/ void <DOBlendableMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass73_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0xdff490*/ <>c__DisplayClass73_0();
                /*0xe01b84*/ UnityEngine.Vector3 <DOBlendableLocalMoveBy>b__0();
                /*0xe01b90*/ void <DOBlendableLocalMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass74_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0xdff678*/ <>c__DisplayClass74_0();
                /*0xe01bf4*/ UnityEngine.Quaternion <DOBlendableRotateBy>b__0();
                /*0xe01c00*/ void <DOBlendableRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass75_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0xdff860*/ <>c__DisplayClass75_0();
                /*0xe01e7c*/ UnityEngine.Quaternion <DOBlendableLocalRotateBy>b__0();
                /*0xe01e88*/ void <DOBlendableLocalRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass76_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0xdffb04*/ <>c__DisplayClass76_0();
                /*0xe02104*/ UnityEngine.Vector3 <DOBlendablePunchRotation>b__0();
                /*0xe02110*/ void <DOBlendablePunchRotation>b__1(UnityEngine.Vector3 v);
            }

            class <>c__DisplayClass77_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0xdffce4*/ <>c__DisplayClass77_0();
                /*0xe023dc*/ UnityEngine.Vector3 <DOBlendableScaleBy>b__0();
                /*0xe023e8*/ void <DOBlendableScaleBy>b__1(UnityEngine.Vector3 x);
            }
        }

        class TweenParams
        {
            static /*0x0*/ DG.Tweening.TweenParams Params;
            /*0x10*/ object id;
            /*0x18*/ string stringId;
            /*0x20*/ int intId;
            /*0x28*/ object target;
            /*0x30*/ DG.Tweening.UpdateType updateType;
            /*0x34*/ bool isIndependentUpdate;
            /*0x38*/ DG.Tweening.TweenCallback onStart;
            /*0x40*/ DG.Tweening.TweenCallback onPlay;
            /*0x48*/ DG.Tweening.TweenCallback onRewind;
            /*0x50*/ DG.Tweening.TweenCallback onUpdate;
            /*0x58*/ DG.Tweening.TweenCallback onStepComplete;
            /*0x60*/ DG.Tweening.TweenCallback onComplete;
            /*0x68*/ DG.Tweening.TweenCallback onKill;
            /*0x70*/ DG.Tweening.TweenCallback<int> onWaypointChange;
            /*0x78*/ bool isRecyclable;
            /*0x79*/ bool isSpeedBased;
            /*0x7a*/ bool autoKill;
            /*0x7c*/ int loops;
            /*0x80*/ DG.Tweening.LoopType loopType;
            /*0x84*/ float delay;
            /*0x88*/ bool isRelative;
            /*0x8c*/ DG.Tweening.Ease easeType;
            /*0x90*/ DG.Tweening.EaseFunction customEase;
            /*0x98*/ float easeOvershootOrAmplitude;
            /*0x9c*/ float easePeriod;

            static /*0xe028ac*/ TweenParams();
            /*0xe0244c*/ TweenParams();
            /*0xe02470*/ DG.Tweening.TweenParams Clear();
            /*0xe02538*/ DG.Tweening.TweenParams SetAutoKill(bool autoKillOnCompletion);
            /*0xe02544*/ DG.Tweening.TweenParams SetId(object objectId);
            /*0xe0254c*/ DG.Tweening.TweenParams SetId(string stringId);
            /*0xe02554*/ DG.Tweening.TweenParams SetId(int intId);
            /*0xe0255c*/ DG.Tweening.TweenParams SetTarget(object target);
            /*0xe02564*/ DG.Tweening.TweenParams SetLoops(int loops, System.Nullable<DG.Tweening.LoopType> loopType);
            /*0xe025f4*/ DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<float> overshootOrAmplitude, System.Nullable<float> period);
            /*0xe026ec*/ DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve);
            /*0xe027ac*/ DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase);
            /*0xe027bc*/ DG.Tweening.TweenParams SetRecyclable(bool recyclable);
            /*0xe027c8*/ DG.Tweening.TweenParams SetUpdate(bool isIndependentUpdate);
            /*0xe0283c*/ DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            /*0xe0284c*/ DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action);
            /*0xe02854*/ DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action);
            /*0xe0285c*/ DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action);
            /*0xe02864*/ DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action);
            /*0xe0286c*/ DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action);
            /*0xe02874*/ DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action);
            /*0xe0287c*/ DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action);
            /*0xe02884*/ DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<int> action);
            /*0xe0288c*/ DG.Tweening.TweenParams SetDelay(float delay);
            /*0xe02894*/ DG.Tweening.TweenParams SetRelative(bool isRelative);
            /*0xe028a0*/ DG.Tweening.TweenParams SetSpeedBased(bool isSpeedBased);
        }

        class TweenSettingsExtensions
        {
            static T SetAutoKill<T>(T t);
            static T SetAutoKill<T>(T t, bool autoKillOnCompletion);
            static T SetId<T>(T t, object objectId);
            static T SetId<T>(T t, string stringId);
            static T SetId<T>(T t, int intId);
            static T SetLink<T>(T t, UnityEngine.GameObject gameObject);
            static T SetLink<T>(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour);
            static T SetTarget<T>(T t, object target);
            static T SetLoops<T>(T t, int loops);
            static T SetLoops<T>(T t, int loops, DG.Tweening.LoopType loopType);
            static T SetEase<T>(T t, DG.Tweening.Ease ease);
            static T SetEase<T>(T t, DG.Tweening.Ease ease, float overshoot);
            static T SetEase<T>(T t, DG.Tweening.Ease ease, float amplitude, float period);
            static T SetEase<T>(T t, UnityEngine.AnimationCurve animCurve);
            static T SetEase<T>(T t, DG.Tweening.EaseFunction customEase);
            static T SetRecyclable<T>(T t);
            static T SetRecyclable<T>(T t, bool recyclable);
            static T SetUpdate<T>(T t, bool isIndependentUpdate);
            static T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType);
            static T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            static T SetInverted<T>(T t);
            static T SetInverted<T>(T t, bool inverted);
            static T OnStart<T>(T t, DG.Tweening.TweenCallback action);
            static T OnPlay<T>(T t, DG.Tweening.TweenCallback action);
            static T OnPause<T>(T t, DG.Tweening.TweenCallback action);
            static T OnRewind<T>(T t, DG.Tweening.TweenCallback action);
            static T OnUpdate<T>(T t, DG.Tweening.TweenCallback action);
            static T OnStepComplete<T>(T t, DG.Tweening.TweenCallback action);
            static T OnComplete<T>(T t, DG.Tweening.TweenCallback action);
            static T OnKill<T>(T t, DG.Tweening.TweenCallback action);
            static T OnWaypointChange<T>(T t, DG.Tweening.TweenCallback<int> action);
            static T SetAs<T>(T t, DG.Tweening.Tween asTween);
            static T SetAs<T>(T t, DG.Tweening.TweenParams tweenParams);
            static /*0xdfd900*/ DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0xe029ac*/ DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0xdfd944*/ DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0xe029e4*/ DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t);
            static /*0xdf21b0*/ DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, float interval);
            static /*0xe02a2c*/ DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, float interval);
            static /*0xe02a68*/ DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0xe02ab4*/ DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0xe02af8*/ DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, float atPosition, DG.Tweening.TweenCallback callback);
            static /*0xe02920*/ bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween);
            static T From<T>(T t);
            static T From<T>(T t, bool isRelative);
            static T From<T>(T t, bool setImmediately, bool isRelative);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
            static /*0xe02b48*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, float fromAlphaValue, bool setImmediately, bool isRelative);
            static /*0xe02bf0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, float fromValue, bool setImmediately, bool isRelative);
            static /*0xe02c94*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, float fromValueDegrees, bool setImmediately, bool isRelative);
            static T SetDelay<T>(T t, float delay);
            static T SetDelay<T>(T t, float delay, bool asPrependedIntervalIfSequence);
            static T SetRelative<T>(T t);
            static T SetRelative<T>(T t, bool isRelative);
            static T SetSpeedBased<T>(T t);
            static T SetSpeedBased<T>(T t, bool isSpeedBased);
            static /*0xe02d34*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool snapping);
            static /*0xe02d4c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0xe02d64*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0xdfa158*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0xdfa30c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0xe02d80*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0xe02d98*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0xe02db4*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool useShortest360Route);
            static /*0xdee700*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool alphaOnly);
            static /*0xe02dd0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool snapping);
            static /*0xe02de8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0xdfc030*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool snapping);
            static /*0xe02ec4*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0xe02ee0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, float endValueDegrees, bool relativeCenter, bool snapping);
            static /*0xe02f08*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0xe02f24*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0xe02f44*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0xe0300c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, bool stableZRotation);
            static /*0xe03044*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0xe03104*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, bool stableZRotation);
            static /*0xe03194*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0xe03240*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, bool stableZRotation);
            static /*0xe02f7c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Options.OrientType orientType, UnityEngine.Vector3 lookAtPosition, UnityEngine.Transform lookAtTransform, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up, bool stableZRotation);
            static /*0xe032d0*/ void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
        }

        enum LogBehaviour
        {
            Default = 0,
            Verbose = 1,
            ErrorsOnly = 2,
        }

        class Tween : DG.Tweening.Core.ABSSequentiable
        {
            /*0x28*/ float timeScale;
            /*0x2c*/ bool isBackwards;
            /*0x2d*/ bool isInverted;
            /*0x30*/ object id;
            /*0x38*/ string stringId;
            /*0x40*/ int intId;
            /*0x48*/ object target;
            /*0x50*/ DG.Tweening.UpdateType updateType;
            /*0x54*/ bool isIndependentUpdate;
            /*0x58*/ DG.Tweening.TweenCallback onPlay;
            /*0x60*/ DG.Tweening.TweenCallback onPause;
            /*0x68*/ DG.Tweening.TweenCallback onRewind;
            /*0x70*/ DG.Tweening.TweenCallback onUpdate;
            /*0x78*/ DG.Tweening.TweenCallback onStepComplete;
            /*0x80*/ DG.Tweening.TweenCallback onComplete;
            /*0x88*/ DG.Tweening.TweenCallback onKill;
            /*0x90*/ DG.Tweening.TweenCallback<int> onWaypointChange;
            /*0x98*/ bool isFrom;
            /*0x99*/ bool isBlendable;
            /*0x9a*/ bool isRecyclable;
            /*0x9b*/ bool isSpeedBased;
            /*0x9c*/ bool autoKill;
            /*0xa0*/ float duration;
            /*0xa4*/ int loops;
            /*0xa8*/ DG.Tweening.LoopType loopType;
            /*0xac*/ float delay;
            /*0xb0*/ bool <isRelative>k__BackingField;
            /*0xb4*/ DG.Tweening.Ease easeType;
            /*0xb8*/ DG.Tweening.EaseFunction customEase;
            /*0xc0*/ float easeOvershootOrAmplitude;
            /*0xc4*/ float easePeriod;
            /*0xc8*/ string debugTargetId;
            /*0xd0*/ System.Type typeofT1;
            /*0xd8*/ System.Type typeofT2;
            /*0xe0*/ System.Type typeofTPlugOptions;
            /*0xe8*/ bool <active>k__BackingField;
            /*0xe9*/ bool isSequenced;
            /*0xf0*/ DG.Tweening.Sequence sequenceParent;
            /*0xf8*/ int activeId;
            /*0xfc*/ DG.Tweening.Core.Enums.SpecialStartupMode specialStartupMode;
            /*0x100*/ bool creationLocked;
            /*0x101*/ bool startupDone;
            /*0x102*/ bool <playedOnce>k__BackingField;
            /*0x104*/ float <position>k__BackingField;
            /*0x108*/ float fullDuration;
            /*0x10c*/ int completedLoops;
            /*0x110*/ bool isPlaying;
            /*0x111*/ bool isComplete;
            /*0x114*/ float elapsedDelay;
            /*0x118*/ bool delayComplete;
            /*0x11c*/ int miscInt;

            static /*0xe0366c*/ bool DoGoto(DG.Tweening.Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0xdf65b0*/ bool OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t);
            static bool OnTweenCallback<T>(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param);
            /*0xdf4fe0*/ Tween();
            /*0xe03604*/ bool get_isRelative();
            /*0xe0360c*/ void set_isRelative(bool value);
            /*0xe03618*/ bool get_active();
            /*0xe03620*/ void set_active(bool value);
            /*0xe0362c*/ float get_fullPosition();
            /*0xe03634*/ void set_fullPosition(float value);
            /*0xdf3b0c*/ bool get_hasLoops();
            /*0xe03640*/ bool get_playedOnce();
            /*0xe03648*/ void set_playedOnce(bool value);
            /*0xe03654*/ float get_position();
            /*0xe0365c*/ void set_position(float value);
            /*0xdf561c*/ void Reset();
            bool Validate();
            /*0xe03664*/ float UpdateDelay(float elapsed);
            bool Startup();
            bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class Tweener : DG.Tweening.Tween
        {
            /*0x120*/ bool hasManuallySetStartValue;
            /*0x121*/ bool isFromAllowed;

            static bool Setup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            static float DoUpdateDelay<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, float elapsed);
            static bool DoStartup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration);
            static bool DOStartupSpecials<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static void DOStartupDurationBased<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            /*0xe039cc*/ Tweener();
            DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
            DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
            DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
            DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
            DG.Tweening.Tweener SetFrom(bool relative);
        }

        enum TweenType
        {
            Tweener = 0,
            Sequence = 1,
            Callback = 2,
        }

        enum UpdateType
        {
            Normal = 0,
            Late = 1,
            Fixed = 2,
            Manual = 3,
        }

        namespace Plugins
        {
            struct CircleOptions : DG.Tweening.Plugins.Options.IPlugOptions
            {
                /*0x10*/ float endValueDegrees;
                /*0x14*/ bool relativeCenter;
                /*0x15*/ bool snapping;
                /*0x18*/ UnityEngine.Vector2 center;
                /*0x20*/ float radius;
                /*0x24*/ float startValueDegrees;
                /*0x28*/ bool initialized;

                /*0xe039f4*/ void Reset();
                /*0xe03a08*/ void Initialize(UnityEngine.Vector2 startValue, UnityEngine.Vector2 endValue);
            }

            class CirclePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>
            {
                static /*0xe03e28*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> Get();
                /*0xe04000*/ CirclePlugin();
                /*0xe03ad4*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0xe03ad8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, bool isRelative);
                /*0xe03d30*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0xe03e68*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 value);
                /*0xe03e6c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0xe03eb4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0xe03f00*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.CircleOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0xe03f08*/ void EvaluateAndApply(DG.Tweening.Plugins.CircleOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0xe03b94*/ UnityEngine.Vector2 GetPositionOnCircle(DG.Tweening.Plugins.CircleOptions options, float degrees);
            }

            class Color2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0xe04680*/ Color2Plugin();
                /*0xe04048*/ void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0xe0404c*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0xe041b0*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, bool setImmediately, bool isRelative);
                /*0xe04390*/ DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value);
                /*0xe0439c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0xe043c8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0xe043f4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, DG.Tweening.Color2 changeValue);
                /*0xe04400*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, float elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class DoublePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<double, double, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0xe11cd8*/ DoublePlugin();
                /*0xe11aa0*/ void Reset(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe11aa4*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0xe11b14*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double fromValue, bool setImmediately, bool isRelative);
                /*0xe11ba8*/ double ConvertToStartValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double value);
                /*0xe11bac*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe11bcc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe11bec*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, double changeValue);
                /*0xe11c04*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class LongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<long, long, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0xe12024*/ LongPlugin();
                /*0xe11d20*/ void Reset(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe11d24*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0xe11d88*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long fromValue, bool setImmediately, bool isRelative);
                /*0xe11e10*/ long ConvertToStartValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long value);
                /*0xe11e18*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe11e38*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe11e58*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, long changeValue);
                /*0xe11e70*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UlongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0xe12338*/ UlongPlugin();
                /*0xe1206c*/ void Reset(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe12070*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0xe120d4*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative);
                /*0xe1215c*/ ulong ConvertToStartValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong value);
                /*0xe12164*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe12184*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe121a4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, ulong changeValue);
                /*0xe121c0*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3ArrayPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>
            {
                /*0xe12f78*/ Vector3ArrayPlugin();
                /*0xe12380*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0xe1239c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool isRelative);
                /*0xe123a0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, bool setImmediately, bool isRelative);
                /*0xe123a4*/ UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value);
                /*0xe124a4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0xe1258c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0xe12684*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, float unitsXSecond, UnityEngine.Vector3[] changeValue);
                /*0xe12794*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class PathPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>
            {
                static float MinLookAhead = 0.00009999999747378752;

                static /*0xe13108*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> Get();
                /*0xe14abc*/ PathPlugin();
                /*0xe12fc0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0xe13100*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool isRelative);
                /*0xe13104*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, bool setImmediately, bool isRelative);
                /*0xe13148*/ DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value);
                /*0xe13160*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0xe13218*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0xe13738*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, float unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue);
                /*0xe13754*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0xe13ff0*/ void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, float pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0xe149bc*/ UnityEngine.Vector3 DivideVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector);
                /*0xe14aac*/ UnityEngine.Vector3 MultiplyVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector);
            }

            class ColorPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0xe14ee0*/ ColorPlugin();
                /*0xe14b04*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0xe14b08*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0xe14be4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative);
                /*0xe14cf0*/ UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value);
                /*0xe14cf4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0xe14d18*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0xe14d3c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue);
                /*0xe14d48*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class IntPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<int, int, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0xe15230*/ IntPlugin();
                /*0xe14f28*/ void Reset(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe14f2c*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0xe14f94*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int fromValue, bool setImmediately, bool isRelative);
                /*0xe1501c*/ int ConvertToStartValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int value);
                /*0xe15024*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe15048*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe1506c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, int changeValue);
                /*0xe15084*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class QuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>
            {
                /*0xe16324*/ QuaternionPlugin();
                /*0xe15278*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0xe1527c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool isRelative);
                /*0xe158c8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0xe159f4*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value);
                /*0xe15a20*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0xe15a58*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0xe15c58*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0xe15cd8*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0xe1564c*/ UnityEngine.Vector3 GetEulerValForCalculations(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 val, UnityEngine.Vector3 counterVal);
                /*0xe1630c*/ UnityEngine.Vector3 FlipEulerAngles(UnityEngine.Vector3 euler);
            }

            class RectOffsetPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ UnityEngine.RectOffset _r;

                static /*0xe17240*/ RectOffsetPlugin();
                /*0xe171f8*/ RectOffsetPlugin();
                /*0xe1636c*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe16388*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0xe164d4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, bool setImmediately, bool isRelative);
                /*0xe166f0*/ UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value);
                /*0xe167b0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe168bc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe16a10*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.RectOffset changeValue);
                /*0xe16acc*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, float elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>
            {
                /*0xe18354*/ RectPlugin();
                /*0xe172b8*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0xe172bc*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool isRelative);
                /*0xe1768c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, bool setImmediately, bool isRelative);
                /*0xe17b34*/ UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value);
                /*0xe17b38*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0xe17c14*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0xe17d10*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, float unitsXSecond, UnityEngine.Rect changeValue);
                /*0xe17db4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, float elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UintPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<uint, uint, DG.Tweening.Plugins.Options.UintOptions>
            {
                /*0xe186e8*/ UintPlugin();
                /*0xe1839c*/ void Reset(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0xe183a0*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, bool isRelative);
                /*0xe18408*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint fromValue, bool setImmediately, bool isRelative);
                /*0xe18490*/ uint ConvertToStartValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint value);
                /*0xe18498*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0xe184bc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0xe184f0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, float unitsXSecond, uint changeValue);
                /*0xe1850c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0xe19048*/ Vector2Plugin();
                /*0xe18730*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe18734*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0xe18918*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0xe18b74*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value);
                /*0xe18b78*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe18b9c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe18c04*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0xe18c78*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector4Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0xe1a074*/ Vector4Plugin();
                /*0xe19090*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe19094*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0xe193dc*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, bool setImmediately, bool isRelative);
                /*0xe197c0*/ UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value);
                /*0xe197c4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe197e8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe198d0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector4 changeValue);
                /*0xe19964*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, float elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class StringPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<string, string, DG.Tweening.Plugins.Options.StringOptions>
            {
                static /*0x0*/ System.Text.StringBuilder _Buffer;
                static /*0x8*/ System.Collections.Generic.List<char> _OpenedTags;

                static /*0xe1b2b4*/ StringPlugin();
                /*0xe1b26c*/ StringPlugin();
                /*0xe1a0bc*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool isRelative);
                /*0xe1a114*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string fromValue, bool setImmediately, bool isRelative);
                /*0xe1a1f0*/ void Reset(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0xe1a244*/ string ConvertToStartValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string value);
                /*0xe1a24c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0xe1a250*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0xe1a4b0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, float unitsXSecond, string changeValue);
                /*0xe1a4f0*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0xe1a990*/ System.Text.StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled);
                /*0xe1b058*/ char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options);
            }

            class StringPluginExtensions
            {
                static /*0x0*/ char[] ScrambledCharsAll;
                static /*0x8*/ char[] ScrambledCharsUppercase;
                static /*0x10*/ char[] ScrambledCharsLowercase;
                static /*0x18*/ char[] ScrambledCharsNumerals;
                static /*0x20*/ int _lastRndSeed;

                static /*0xe1b378*/ StringPluginExtensions();
                static /*0xe1b4fc*/ void ScrambleChars(char[] chars);
                static /*0xe1b144*/ System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, int length, char[] chars);
            }

            class FloatPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<float, float, DG.Tweening.Plugins.Options.FloatOptions>
            {
                /*0xe1ba38*/ FloatPlugin();
                /*0xe1b59c*/ void Reset(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0xe1b5a0*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool isRelative);
                /*0xe1b6cc*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float fromValue, bool setImmediately, bool isRelative);
                /*0xe1b820*/ float ConvertToStartValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float value);
                /*0xe1b824*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0xe1b848*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0xe1b86c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, float unitsXSecond, float changeValue);
                /*0xe1b880*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0xe1c6f0*/ Vector3Plugin();
                /*0xe1ba80*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe1ba84*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0xe1bd1c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0xe1c03c*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value);
                /*0xe1c040*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe1c078*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0xe1c11c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0xe1c19c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Options
            {
                interface IPlugOptions
                {
                    void Reset();
                }

                enum OrientType
                {
                    None = 0,
                    ToPath = 1,
                    LookAtTransform = 2,
                    LookAtPosition = 3,
                }

                struct PathOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.PathMode mode;
                    /*0x14*/ DG.Tweening.Plugins.Options.OrientType orientType;
                    /*0x18*/ DG.Tweening.AxisConstraint lockPositionAxis;
                    /*0x1c*/ DG.Tweening.AxisConstraint lockRotationAxis;
                    /*0x20*/ bool isClosedPath;
                    /*0x24*/ UnityEngine.Vector3 lookAtPosition;
                    /*0x30*/ UnityEngine.Transform lookAtTransform;
                    /*0x38*/ float lookAhead;
                    /*0x3c*/ bool hasCustomForwardDirection;
                    /*0x40*/ UnityEngine.Quaternion forward;
                    /*0x50*/ bool useLocalPosition;
                    /*0x58*/ UnityEngine.Transform parent;
                    /*0x60*/ bool isRigidbody;
                    /*0x61*/ bool isRigidbody2D;
                    /*0x62*/ bool stableZRotation;
                    /*0x64*/ UnityEngine.Quaternion startupRot;
                    /*0x74*/ float startupZRot;
                    /*0x78*/ bool addedExtraStartWp;
                    /*0x79*/ bool addedExtraEndWp;

                    /*0xe1c738*/ void Reset();
                }

                struct QuaternionOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.RotateMode rotateMode;
                    /*0x14*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x18*/ UnityEngine.Vector3 up;
                    /*0x24*/ bool dynamicLookAt;
                    /*0x28*/ UnityEngine.Vector3 dynamicLookAtWorldPosition;

                    /*0xe1c7fc*/ void Reset();
                }

                struct UintOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool isNegativeChangeValue;

                    /*0xe1c870*/ void Reset();
                }

                struct Vector3ArrayOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;
                    /*0x18*/ float[] durations;

                    /*0xe1c878*/ void Reset();
                }

                struct NoOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0xe1c888*/ void Reset();
                }

                struct ColorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool alphaOnly;

                    /*0xe1c88c*/ void Reset();
                }

                struct FloatOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0xe1c894*/ void Reset();
                }

                struct RectOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0xe1c89c*/ void Reset();
                }

                struct StringOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool richTextEnabled;
                    /*0x14*/ DG.Tweening.ScrambleMode scrambleMode;
                    /*0x18*/ char[] scrambledChars;
                    /*0x20*/ int startValueStrippedLength;
                    /*0x24*/ int changeValueStrippedLength;

                    /*0xe1c8a4*/ void Reset();
                }

                struct VectorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;

                    /*0xe1c8b8*/ void Reset();
                }
            }

            namespace Core
            {
                interface ITPlugin<T1, T2, TPlugOptions, TPlugin>
                {
                }

                class SpecialPluginsUtils
                {
                    static /*0xe161e8*/ bool SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                    static /*0xe1c8c4*/ bool SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0xe1c9f8*/ bool SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0xe1ca28*/ bool SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                }

                interface IPlugSetter<T1, T2, TPlugin, TPlugOptions>
                {
                    DG.Tweening.Core.DOGetter<T1> Getter();
                    DG.Tweening.Core.DOSetter<T1> Setter();
                    T2 EndValue();
                    TPlugOptions GetOptions();
                }

                interface ITweenPlugin
                {
                }

                class ABSTweenPlugin<T1, T2, TPlugOptions> : DG.Tweening.Plugins.Core.ITweenPlugin
                {
                    ABSTweenPlugin();
                    void Reset(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
                    T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T1 value);
                    void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetChangeValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
                    void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                }

                class PluginsManager
                {
                    static int _MaxCustomPlugins = 20;
                    static /*0x0*/ DG.Tweening.Plugins.Core.ITweenPlugin _floatPlugin;
                    static /*0x8*/ DG.Tweening.Plugins.Core.ITweenPlugin _doublePlugin;
                    static /*0x10*/ DG.Tweening.Plugins.Core.ITweenPlugin _intPlugin;
                    static /*0x18*/ DG.Tweening.Plugins.Core.ITweenPlugin _uintPlugin;
                    static /*0x20*/ DG.Tweening.Plugins.Core.ITweenPlugin _longPlugin;
                    static /*0x28*/ DG.Tweening.Plugins.Core.ITweenPlugin _ulongPlugin;
                    static /*0x30*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector2Plugin;
                    static /*0x38*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector3Plugin;
                    static /*0x40*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector4Plugin;
                    static /*0x48*/ DG.Tweening.Plugins.Core.ITweenPlugin _quaternionPlugin;
                    static /*0x50*/ DG.Tweening.Plugins.Core.ITweenPlugin _colorPlugin;
                    static /*0x58*/ DG.Tweening.Plugins.Core.ITweenPlugin _rectPlugin;
                    static /*0x60*/ DG.Tweening.Plugins.Core.ITweenPlugin _rectOffsetPlugin;
                    static /*0x68*/ DG.Tweening.Plugins.Core.ITweenPlugin _stringPlugin;
                    static /*0x70*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector3ArrayPlugin;
                    static /*0x78*/ DG.Tweening.Plugins.Core.ITweenPlugin _color2Plugin;
                    static /*0x80*/ System.Collections.Generic.Dictionary<System.Type, DG.Tweening.Plugins.Core.ITweenPlugin> _customPlugins;

                    static DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>();
                    static DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>();
                    static /*0xe1cbd8*/ void PurgeAll();
                }

                namespace PathCore
                {
                    class CubicBezierDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0xe1d834*/ CubicBezierDecoder();
                        /*0xe1d824*/ CubicBezierDecoder();
                        /*0xe1cc68*/ int get_minInputWaypoints();
                        /*0xe1cc70*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0xe1d69c*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0xe1d168*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0xe1d360*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    struct ControlPoint
                    {
                        /*0x10*/ UnityEngine.Vector3 a;
                        /*0x1c*/ UnityEngine.Vector3 b;

                        static /*0xe1d8d0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v);
                        /*0xe1d158*/ ControlPoint(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                        /*0xe1d900*/ string ToString();
                    }

                    class ABSPathDecoder
                    {
                        /*0xe1d82c*/ ABSPathDecoder();
                        void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        int get_minInputWaypoints();
                    }

                    class CatmullRomDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0xe1e580*/ CatmullRomDecoder();
                        /*0xe1e578*/ CatmullRomDecoder();
                        /*0xe1daa4*/ int get_minInputWaypoints();
                        /*0xe1daac*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0xe1e304*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0xe1dd18*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0xe1df10*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class LinearDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        /*0xe1ea0c*/ LinearDecoder();
                        /*0xe1e61c*/ int get_minInputWaypoints();
                        /*0xe1e624*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0xe1e860*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0xe1e650*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0xe1ea08*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class Path
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder _catmullRomDecoder;
                        static /*0x8*/ DG.Tweening.Plugins.Core.PathCore.LinearDecoder _linearDecoder;
                        static /*0x10*/ DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder _cubicBezierDecoder;
                        /*0x10*/ float[] wpLengths;
                        /*0x18*/ UnityEngine.Vector3[] wps;
                        /*0x20*/ DG.Tweening.PathType type;
                        /*0x24*/ int subdivisionsXSegment;
                        /*0x28*/ int subdivisions;
                        /*0x30*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints;
                        /*0x38*/ float length;
                        /*0x3c*/ bool isFinalized;
                        /*0x40*/ float[] timesTable;
                        /*0x48*/ float[] lengthsTable;
                        /*0x50*/ int linearWPIndex;
                        /*0x54*/ bool addedExtraStartWp;
                        /*0x55*/ bool addedExtraEndWp;
                        /*0x58*/ DG.Tweening.Plugins.Options.PathOptions plugOptions;
                        /*0xc8*/ DG.Tweening.Plugins.Core.PathCore.Path _incrementalClone;
                        /*0xd0*/ int _incrementalIndex;
                        /*0xd8*/ DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder _decoder;
                        /*0xe0*/ bool _changed;
                        /*0xe8*/ UnityEngine.Vector3[] nonLinearDrawWps;
                        /*0xf0*/ UnityEngine.Vector3 targetPosition;
                        /*0xfc*/ System.Nullable<UnityEngine.Vector3> lookAtPosition;
                        /*0x10c*/ UnityEngine.Color gizmoColor;

                        static /*0xe1ee54*/ UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, int drawSubdivisionsXSegment);
                        static /*0xe1ef30*/ void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0xe1f02c*/ void Draw(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0xe1f44c*/ UnityEngine.Vector3 ConvertToDrawPoint(UnityEngine.Vector3 wp, DG.Tweening.Plugins.Options.PathOptions plugOptions);
                        /*0xe1ea14*/ Path(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, int subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor);
                        /*0xe1ee34*/ Path();
                        /*0xe13674*/ int get_minInputWaypoints();
                        /*0xe13694*/ void FinalizePath(bool isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal);
                        /*0xe13fb4*/ UnityEngine.Vector3 GetPoint(float perc, bool convertToConstantPerc);
                        /*0xe13ea0*/ float ConvertToConstantPathPerc(float perc);
                        /*0xe14914*/ int GetWaypointIndexFromPerc(float perc, bool isMovingForward);
                        /*0xe12fec*/ void Destroy();
                        /*0xe13a20*/ DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(int loopIncrement);
                        /*0xe1ec14*/ void AssignWaypoints(UnityEngine.Vector3[] newWps, bool cloneWps);
                        /*0xe1ecf4*/ void AssignDecoder(DG.Tweening.PathType pathType);
                        /*0xe1f028*/ void Draw();
                    }
                }
            }
        }

        namespace CustomPlugins
        {
            class PureQuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;

                static /*0xe1f510*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug();
                /*0xe1f58c*/ PureQuaternionPlugin();
                /*0xe1f5d4*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe1f5d8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0xe1f6ec*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, bool setImmediately, bool isRelative);
                /*0xe1f8a0*/ UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value);
                /*0xe1f8a4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe1f958*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0xe1f97c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.Quaternion changeValue);
                /*0xe1fa30*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }
        }

        namespace Core
        {
            class ABSSequentiable
            {
                /*0x10*/ DG.Tweening.TweenType tweenType;
                /*0x14*/ float sequencedPosition;
                /*0x18*/ float sequencedEndPosition;
                /*0x20*/ DG.Tweening.TweenCallback onStart;

                /*0xe1fadc*/ ABSSequentiable();
            }

            class DOGetter<T> : System.MulticastDelegate
            {
                DOGetter(object object, nint method);
                T Invoke();
                System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                T EndInvoke(System.IAsyncResult result);
            }

            class DOSetter<T> : System.MulticastDelegate
            {
                DOSetter(object object, nint method);
                void Invoke(T pNewValue);
                System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, object object);
                void EndInvoke(System.IAsyncResult result);
            }

            class Debugger
            {
                static string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>";
                static /*0x0*/ int _logPriority;

                static /*0xe1fae4*/ int get_logPriority();
                static /*0xe1fb2c*/ void Log(object message);
                static /*0xe1fc50*/ void LogWarning(object message, DG.Tweening.Tween t);
                static /*0xe1fe40*/ void LogError(object message, DG.Tweening.Tween t);
                static /*0xe1ffd0*/ void LogSafeModeCapturedError(object message, DG.Tweening.Tween t);
                static /*0xe201e4*/ void LogReport(object message);
                static /*0xe2030c*/ void LogSafeModeReport(object message);
                static /*0xe20434*/ void LogInvalidTween(DG.Tweening.Tween t);
                static /*0xe20478*/ void LogNestedTween(DG.Tweening.Tween t);
                static /*0xe204c0*/ void LogNullTween(DG.Tweening.Tween t);
                static /*0xe20504*/ void LogNonPathTween(DG.Tweening.Tween t);
                static /*0xe2054c*/ void LogMissingMaterialProperty(string propertyName);
                static /*0xe205a0*/ void LogMissingMaterialProperty(int propertyId);
                static /*0xe20628*/ void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0xe20688*/ void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0xe206e8*/ void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour);
                static /*0xe2075c*/ bool ShouldLogSafeModeCapturedError();
                static /*0xe1fde0*/ string GetDebugDataMessage(DG.Tweening.Tween t);
                static /*0xe207fc*/ void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t);

                class Sequence
                {
                    static /*0xe209a0*/ void LogAddToNullSequence();
                    static /*0xe209e4*/ void LogAddToInactiveSequence();
                    static /*0xe20a28*/ void LogAddToLockedSequence();
                    static /*0xe20a6c*/ void LogAddNullTween();
                    static /*0xe20ab0*/ void LogAddInactiveTween(DG.Tweening.Tween t);
                    static /*0xe20af8*/ void LogAddAlreadySequencedTween(DG.Tweening.Tween t);
                }
            }

            class DOTweenComponent : UnityEngine.MonoBehaviour, DG.Tweening.IDOTweenInit
            {
                /*0x18*/ int inspectorUpdater;
                /*0x1c*/ float _unscaledTime;
                /*0x20*/ float _unscaledDeltaTime;
                /*0x24*/ bool _paused;
                /*0x28*/ float _pausedTime;
                /*0x2c*/ bool _isQuitting;
                /*0x2d*/ bool _duplicateToDestroy;

                static /*0xe220e4*/ void Create();
                static /*0xe22228*/ void DestroyInstance();
                /*0xe22328*/ DOTweenComponent();
                /*0xe20b40*/ void Awake();
                /*0xe20d50*/ void Start();
                /*0xe20e28*/ void Update();
                /*0xe21320*/ void LateUpdate();
                /*0xe21434*/ void FixedUpdate();
                /*0xe215a8*/ void OnDrawGizmos();
                /*0xe216e8*/ void OnDestroy();
                /*0xe21b58*/ void OnApplicationPause(bool pauseStatus);
                /*0xe21bb4*/ void OnApplicationQuit();
                /*0xe21c14*/ DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
                /*0xe21d64*/ System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t);
                /*0xe21df4*/ System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t);
                /*0xe21e84*/ System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t);
                /*0xe21f14*/ System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
                /*0xe21fb4*/ System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, float position);
                /*0xe22054*/ System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t);

                class <WaitForCompletion>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0xe21dcc*/ <WaitForCompletion>d__17(int <>1__state);
                    /*0xe22330*/ void System.IDisposable.Dispose();
                    /*0xe22334*/ bool MoveNext();
                    /*0xe22388*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xe22390*/ void System.Collections.IEnumerator.Reset();
                    /*0xe223d0*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForRewind>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0xe21e5c*/ <WaitForRewind>d__18(int <>1__state);
                    /*0xe223d8*/ void System.IDisposable.Dispose();
                    /*0xe223dc*/ bool MoveNext();
                    /*0xe2244c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xe22454*/ void System.Collections.IEnumerator.Reset();
                    /*0xe22494*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForKill>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0xe21eec*/ <WaitForKill>d__19(int <>1__state);
                    /*0xe2249c*/ void System.IDisposable.Dispose();
                    /*0xe224a0*/ bool MoveNext();
                    /*0xe224ec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xe224f4*/ void System.Collections.IEnumerator.Reset();
                    /*0xe22534*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForElapsedLoops>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ int elapsedLoops;

                    /*0xe21f8c*/ <WaitForElapsedLoops>d__20(int <>1__state);
                    /*0xe2253c*/ void System.IDisposable.Dispose();
                    /*0xe22540*/ bool MoveNext();
                    /*0xe2259c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xe225a4*/ void System.Collections.IEnumerator.Reset();
                    /*0xe225e4*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForPosition>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ float position;

                    /*0xe2202c*/ <WaitForPosition>d__21(int <>1__state);
                    /*0xe225ec*/ void System.IDisposable.Dispose();
                    /*0xe225f0*/ bool MoveNext();
                    /*0xe2265c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xe22664*/ void System.Collections.IEnumerator.Reset();
                    /*0xe226a4*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForStart>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0xe220bc*/ <WaitForStart>d__22(int <>1__state);
                    /*0xe226ac*/ void System.IDisposable.Dispose();
                    /*0xe226b0*/ bool MoveNext();
                    /*0xe22704*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xe2270c*/ void System.Collections.IEnumerator.Reset();
                    /*0xe2274c*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DOTweenSettings : UnityEngine.ScriptableObject
            {
                static string AssetName = "DOTweenSettings";
                static string AssetFullFilename = "DOTweenSettings.asset";
                /*0x18*/ bool useSafeMode;
                /*0x20*/ DG.Tweening.Core.DOTweenSettings.SafeModeOptions safeModeOptions;
                /*0x28*/ float timeScale;
                /*0x2c*/ float unscaledTimeScale;
                /*0x30*/ bool useSmoothDeltaTime;
                /*0x34*/ float maxSmoothUnscaledTime;
                /*0x38*/ DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
                /*0x3c*/ bool showUnityEditorReport;
                /*0x40*/ DG.Tweening.LogBehaviour logBehaviour;
                /*0x44*/ bool drawGizmos;
                /*0x45*/ bool defaultRecyclable;
                /*0x48*/ DG.Tweening.AutoPlay defaultAutoPlay;
                /*0x4c*/ DG.Tweening.UpdateType defaultUpdateType;
                /*0x50*/ bool defaultTimeScaleIndependent;
                /*0x54*/ DG.Tweening.Ease defaultEaseType;
                /*0x58*/ float defaultEaseOvershootOrAmplitude;
                /*0x5c*/ float defaultEasePeriod;
                /*0x60*/ bool defaultAutoKill;
                /*0x64*/ DG.Tweening.LoopType defaultLoopType;
                /*0x68*/ bool debugMode;
                /*0x69*/ bool debugStoreTargetId;
                /*0x6a*/ bool showPreviewPanel;
                /*0x6c*/ DG.Tweening.Core.DOTweenSettings.SettingsLocation storeSettingsLocation;
                /*0x70*/ DG.Tweening.Core.DOTweenSettings.ModulesSetup modules;
                /*0x78*/ bool createASMDEF;
                /*0x79*/ bool showPlayingTweens;
                /*0x7a*/ bool showPausedTweens;

                /*0xe22754*/ DOTweenSettings();

                enum SettingsLocation
                {
                    AssetsDirectory = 0,
                    DOTweenDirectory = 1,
                    DemigiantDirectory = 2,
                }

                class SafeModeOptions
                {
                    /*0x10*/ DG.Tweening.Core.Enums.SafeModeLogBehaviour logBehaviour;
                    /*0x14*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;

                    /*0xe2284c*/ SafeModeOptions();
                }

                class ModulesSetup
                {
                    /*0x10*/ bool showPanel;
                    /*0x11*/ bool audioEnabled;
                    /*0x12*/ bool physicsEnabled;
                    /*0x13*/ bool physics2DEnabled;
                    /*0x14*/ bool spriteEnabled;
                    /*0x15*/ bool uiEnabled;
                    /*0x16*/ bool textMeshProEnabled;
                    /*0x17*/ bool tk2DEnabled;
                    /*0x18*/ bool deAudioEnabled;
                    /*0x19*/ bool deUnityExtendedEnabled;
                    /*0x1a*/ bool epoOutlineEnabled;

                    /*0xe2285c*/ ModulesSetup();
                }
            }

            class Extensions
            {
                static T SetSpecialStartupMode<T>(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode);
                static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            }

            class DOTweenExternalCommand
            {
                static /*0x0*/ System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> SetOrientationOnPath;

                static /*0xe22870*/ void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0xe2293c*/ void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0xe149cc*/ void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
            }

            struct SafeModeReport
            {
                /*0x10*/ int <totMissingTargetOrFieldErrors>k__BackingField;
                /*0x14*/ int <totCallbackErrors>k__BackingField;
                /*0x18*/ int <totStartupErrors>k__BackingField;
                /*0x1c*/ int <totUnsetErrors>k__BackingField;

                /*0xe22a08*/ int get_totMissingTargetOrFieldErrors();
                /*0xe22a10*/ void set_totMissingTargetOrFieldErrors(int value);
                /*0xe22a18*/ int get_totCallbackErrors();
                /*0xe22a20*/ void set_totCallbackErrors(int value);
                /*0xe22a28*/ int get_totStartupErrors();
                /*0xe22a30*/ void set_totStartupErrors(int value);
                /*0xe22a38*/ int get_totUnsetErrors();
                /*0xe22a40*/ void set_totUnsetErrors(int value);
                /*0xe22a48*/ void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type);
                /*0xe21b48*/ int GetTotErrors();

                enum SafeModeReportType
                {
                    Unset = 0,
                    TargetOrFieldMissing = 1,
                    Callback = 2,
                    StartupFailure = 3,
                }
            }

            class SequenceCallback : DG.Tweening.Core.ABSSequentiable
            {
                /*0xe22a84*/ SequenceCallback(float sequencedPosition, DG.Tweening.TweenCallback callback);
            }

            class TweenLink
            {
                /*0x10*/ UnityEngine.GameObject target;
                /*0x18*/ DG.Tweening.LinkBehaviour behaviour;
                /*0x1c*/ bool lastSeenActive;

                /*0xe22ac4*/ TweenLink(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour);
            }

            class TweenManager
            {
                static int _DefaultMaxTweeners = 200;
                static int _DefaultMaxSequences = 50;
                static string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";
                static float _EpsilonVsTimeCheck = 9.999999974752427e-7;
                static /*0x0*/ bool isUnityEditor;
                static /*0x1*/ bool isDebugBuild;
                static /*0x4*/ int maxActive;
                static /*0x8*/ int maxTweeners;
                static /*0xc*/ int maxSequences;
                static /*0x10*/ bool hasActiveTweens;
                static /*0x11*/ bool hasActiveDefaultTweens;
                static /*0x12*/ bool hasActiveLateTweens;
                static /*0x13*/ bool hasActiveFixedTweens;
                static /*0x14*/ bool hasActiveManualTweens;
                static /*0x18*/ int totActiveTweens;
                static /*0x1c*/ int totActiveDefaultTweens;
                static /*0x20*/ int totActiveLateTweens;
                static /*0x24*/ int totActiveFixedTweens;
                static /*0x28*/ int totActiveManualTweens;
                static /*0x2c*/ int totActiveTweeners;
                static /*0x30*/ int totActiveSequences;
                static /*0x34*/ int totPooledTweeners;
                static /*0x38*/ int totPooledSequences;
                static /*0x3c*/ int totTweeners;
                static /*0x40*/ int totSequences;
                static /*0x44*/ bool isUpdateLoop;
                static /*0x48*/ DG.Tweening.Tween[] _activeTweens;
                static /*0x50*/ DG.Tweening.Tween[] _pooledTweeners;
                static /*0x58*/ System.Collections.Generic.Stack<DG.Tweening.Tween> _PooledSequences;
                static /*0x60*/ System.Collections.Generic.List<DG.Tweening.Tween> _KillList;
                static /*0x68*/ System.Collections.Generic.Dictionary<DG.Tweening.Tween, DG.Tweening.Core.TweenLink> _TweenLinks;
                static /*0x70*/ int _totTweenLinks;
                static /*0x74*/ int _maxActiveLookupId;
                static /*0x78*/ bool _requiresActiveReorganization;
                static /*0x7c*/ int _reorganizeFromId;
                static /*0x80*/ int _minPooledTweenerId;
                static /*0x84*/ int _maxPooledTweenerId;
                static /*0x88*/ bool _despawnAllCalledFromUpdateLoopCallback;

                static /*0xe22b10*/ TweenManager();
                static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>();
                static /*0xe22cd0*/ DG.Tweening.Sequence GetSequence();
                static /*0xe234a8*/ void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
                static /*0xe236cc*/ void AddActiveTweenToSequence(DG.Tweening.Tween t);
                static /*0xe23b90*/ int DespawnAll();
                static /*0xe23d20*/ void Despawn(DG.Tweening.Tween t, bool modifyActiveLists);
                static /*0xe241f0*/ void PurgeAll(bool isApplicationQuitting);
                static /*0xe2433c*/ void PurgePools();
                static /*0xe2445c*/ void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink);
                static /*0xe246a0*/ void RemoveTweenLink(DG.Tweening.Tween t);
                static /*0xe24408*/ void ResetCapacities();
                static /*0xe21c84*/ void SetCapacities(int tweenersCapacity, int sequencesCapacity);
                static /*0xe2477c*/ int Validate();
                static /*0xe21110*/ void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime);
                static /*0xe24cd4*/ bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate);
                static /*0xe25188*/ int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray);
                static /*0xe25b18*/ bool Complete(DG.Tweening.Tween t, bool modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0xe25bf8*/ bool Flip(DG.Tweening.Tween t);
                static /*0xe25a68*/ void ForceInit(DG.Tweening.Tween t, bool isSequenced);
                static /*0xe25c20*/ bool Goto(DG.Tweening.Tween t, float to, bool andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0xe24660*/ bool Pause(DG.Tweening.Tween t);
                static /*0xe245e0*/ bool Play(DG.Tweening.Tween t);
                static /*0xe25d5c*/ bool PlayBackwards(DG.Tweening.Tween t);
                static /*0xe25e34*/ bool PlayForward(DG.Tweening.Tween t);
                static /*0xe25edc*/ bool Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
                static /*0xe25fa4*/ bool Rewind(DG.Tweening.Tween t, bool includeDelay);
                static /*0xe260c4*/ bool SmoothRewind(DG.Tweening.Tween t);
                static /*0xe261c0*/ bool TogglePause(DG.Tweening.Tween t);
                static /*0xe262d0*/ int TotalPooledTweens();
                static /*0xe2632c*/ int TotalPlayingTweens();
                static /*0xe26438*/ int TotalTweensById(object id, bool playingOnly);
                static /*0xe26764*/ System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(bool playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0xe2696c*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0xe26508*/ int DoGetTweensById(object id, bool playingOnly, bool addToList, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0xe26abc*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0xe24afc*/ void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate);
                static /*0xe24f44*/ void EvaluateTweenLink(DG.Tweening.Tween t);
                static /*0xe22fb8*/ void AddActiveTween(DG.Tweening.Tween t);
                static /*0xe24900*/ void ReorganizeActiveTweens();
                static /*0xe24c1c*/ void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens);
                static /*0xe23720*/ void RemoveActiveTween(DG.Tweening.Tween t);
                static /*0xe241bc*/ void ClearTweenArray(DG.Tweening.Tween[] tweens);
                static /*0xe2328c*/ void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode);
                static /*0xe26230*/ void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind);

                enum CapacityIncreaseMode
                {
                    TweenersAndSequences = 0,
                    TweenersOnly = 1,
                    SequencesOnly = 2,
                }
            }

            class DOTweenUtils
            {
                static /*0x0*/ System.Reflection.Assembly[] _loadedAssemblies;
                static /*0x8*/ string[] _defAssembliesToQuery;

                static /*0xe28288*/ DOTweenUtils();
                static /*0xe27cd8*/ UnityEngine.Vector3 Vector3FromAngle(float degrees, float magnitude);
                static /*0xe27d20*/ float Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
                static /*0xe27e6c*/ UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation);
                static /*0xe27ec8*/ UnityEngine.Vector2 GetPointOnCircle(UnityEngine.Vector2 center, float radius, float degrees);
                static /*0xe27f30*/ bool Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                static /*0xe28030*/ System.Type GetLooseScriptType(string typeName);
            }

            class TweenerCore<T1, T2, TPlugOptions> : DG.Tweening.Tweener
            {
                static string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";
                /*0x0*/ T2 startValue;
                /*0x0*/ T2 endValue;
                /*0x0*/ T2 changeValue;
                /*0x0*/ TPlugOptions plugOptions;
                /*0x0*/ DG.Tweening.Core.DOGetter<T1> getter;
                /*0x0*/ DG.Tweening.Core.DOSetter<T1> setter;
                /*0x0*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
                /*0x0*/ System.Type _colorType;
                /*0x0*/ System.Type _color32Type;

                TweenerCore();
                DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration);
                DG.Tweening.Tweener SetFrom(bool relative);
                DG.Tweening.Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative);
                void Reset();
                bool Validate();
                bool ValidateChangeValueType(System.Type newType, ref bool isColor32ToColor);
                float UpdateDelay(float elapsed);
                bool Startup();
                bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Enums
            {
                enum FilterType
                {
                    All = 0,
                    TargetOrId = 1,
                    TargetAndId = 2,
                    AllExceptTargetsOrIds = 3,
                    DOGetter = 4,
                }

                enum NestedTweenFailureBehaviour
                {
                    TryToPreserveSequence = 0,
                    KillWholeSequence = 1,
                }

                enum OperationType
                {
                    Complete = 0,
                    Despawn = 1,
                    Flip = 2,
                    Goto = 3,
                    Pause = 4,
                    Play = 5,
                    PlayForward = 6,
                    PlayBackwards = 7,
                    Rewind = 8,
                    SmoothRewind = 9,
                    Restart = 10,
                    TogglePause = 11,
                    IsTweening = 12,
                }

                enum SafeModeLogBehaviour
                {
                    None = 0,
                    Normal = 1,
                    Warning = 2,
                    Error = 3,
                }

                enum SpecialStartupMode
                {
                    None = 0,
                    SetLookAt = 1,
                    SetShake = 2,
                    SetPunch = 3,
                    SetCameraShakePosition = 4,
                }

                enum UpdateNotice
                {
                    None = 0,
                    RewindStep = 1,
                }

                enum UpdateMode
                {
                    Update = 0,
                    Goto = 1,
                    IgnoreOnUpdate = 2,
                    IgnoreOnComplete = 3,
                }

                enum RewindCallbackMode
                {
                    FireIfPositionChanged = 0,
                    FireAlwaysWithRewind = 1,
                    FireAlways = 2,
                }
            }

            namespace Easing
            {
                class Bounce
                {
                    static /*0xe283c8*/ float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0xe283e4*/ float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0xe284a0*/ float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                }

                class EaseManager
                {
                    static float _PiOver2 = 1.5707963705062866;
                    static float _TwoPi = 6.2831854820251465;

                    static /*0xe284f0*/ float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0xe28510*/ float Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0xe29234*/ DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease);
                    static /*0xe2a428*/ bool IsFlashEase(DG.Tweening.Ease ease);

                    class <>c
                    {
                        static /*0x0*/ DG.Tweening.Core.Easing.EaseManager.<> <>9;
                        static /*0x8*/ DG.Tweening.EaseFunction <>9__4_0;
                        static /*0x10*/ DG.Tweening.EaseFunction <>9__4_1;
                        static /*0x18*/ DG.Tweening.EaseFunction <>9__4_2;
                        static /*0x20*/ DG.Tweening.EaseFunction <>9__4_3;
                        static /*0x28*/ DG.Tweening.EaseFunction <>9__4_4;
                        static /*0x30*/ DG.Tweening.EaseFunction <>9__4_5;
                        static /*0x38*/ DG.Tweening.EaseFunction <>9__4_6;
                        static /*0x40*/ DG.Tweening.EaseFunction <>9__4_7;
                        static /*0x48*/ DG.Tweening.EaseFunction <>9__4_8;
                        static /*0x50*/ DG.Tweening.EaseFunction <>9__4_9;
                        static /*0x58*/ DG.Tweening.EaseFunction <>9__4_10;
                        static /*0x60*/ DG.Tweening.EaseFunction <>9__4_11;
                        static /*0x68*/ DG.Tweening.EaseFunction <>9__4_12;
                        static /*0x70*/ DG.Tweening.EaseFunction <>9__4_13;
                        static /*0x78*/ DG.Tweening.EaseFunction <>9__4_14;
                        static /*0x80*/ DG.Tweening.EaseFunction <>9__4_15;
                        static /*0x88*/ DG.Tweening.EaseFunction <>9__4_16;
                        static /*0x90*/ DG.Tweening.EaseFunction <>9__4_17;
                        static /*0x98*/ DG.Tweening.EaseFunction <>9__4_18;
                        static /*0xa0*/ DG.Tweening.EaseFunction <>9__4_19;
                        static /*0xa8*/ DG.Tweening.EaseFunction <>9__4_20;
                        static /*0xb0*/ DG.Tweening.EaseFunction <>9__4_21;
                        static /*0xb8*/ DG.Tweening.EaseFunction <>9__4_22;
                        static /*0xc0*/ DG.Tweening.EaseFunction <>9__4_23;
                        static /*0xc8*/ DG.Tweening.EaseFunction <>9__4_24;
                        static /*0xd0*/ DG.Tweening.EaseFunction <>9__4_25;
                        static /*0xd8*/ DG.Tweening.EaseFunction <>9__4_26;
                        static /*0xe0*/ DG.Tweening.EaseFunction <>9__4_27;
                        static /*0xe8*/ DG.Tweening.EaseFunction <>9__4_28;
                        static /*0xf0*/ DG.Tweening.EaseFunction <>9__4_29;
                        static /*0xf8*/ DG.Tweening.EaseFunction <>9__4_30;
                        static /*0x100*/ DG.Tweening.EaseFunction <>9__4_31;
                        static /*0x108*/ DG.Tweening.EaseFunction <>9__4_32;
                        static /*0x110*/ DG.Tweening.EaseFunction <>9__4_33;
                        static /*0x118*/ DG.Tweening.EaseFunction <>9__4_34;
                        static /*0x120*/ DG.Tweening.EaseFunction <>9__4_35;

                        static /*0xe2a438*/ <>c();
                        /*0xe2a49c*/ <>c();
                        /*0xe2a4a4*/ float <ToEaseFunction>b__4_0(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a4ac*/ float <ToEaseFunction>b__4_1(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a52c*/ float <ToEaseFunction>b__4_2(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a5a4*/ float <ToEaseFunction>b__4_3(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a62c*/ float <ToEaseFunction>b__4_4(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a638*/ float <ToEaseFunction>b__4_5(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a64c*/ float <ToEaseFunction>b__4_6(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a690*/ float <ToEaseFunction>b__4_7(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a6a0*/ float <ToEaseFunction>b__4_8(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a6c0*/ float <ToEaseFunction>b__4_9(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a708*/ float <ToEaseFunction>b__4_10(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a71c*/ float <ToEaseFunction>b__4_11(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a740*/ float <ToEaseFunction>b__4_12(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a78c*/ float <ToEaseFunction>b__4_13(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a7a4*/ float <ToEaseFunction>b__4_14(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a7cc*/ float <ToEaseFunction>b__4_15(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a824*/ float <ToEaseFunction>b__4_16(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a8b0*/ float <ToEaseFunction>b__4_17(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2a93c*/ float <ToEaseFunction>b__4_18(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2aa34*/ float <ToEaseFunction>b__4_19(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2aab0*/ float <ToEaseFunction>b__4_20(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2ab28*/ float <ToEaseFunction>b__4_21(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2abdc*/ float <ToEaseFunction>b__4_22(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2ad24*/ float <ToEaseFunction>b__4_23(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2ae6c*/ float <ToEaseFunction>b__4_24(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b02c*/ float <ToEaseFunction>b__4_25(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b04c*/ float <ToEaseFunction>b__4_26(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b078*/ float <ToEaseFunction>b__4_27(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b0e4*/ float <ToEaseFunction>b__4_28(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b100*/ float <ToEaseFunction>b__4_29(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b104*/ float <ToEaseFunction>b__4_30(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b108*/ float <ToEaseFunction>b__4_31(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b10c*/ float <ToEaseFunction>b__4_32(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b110*/ float <ToEaseFunction>b__4_33(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b114*/ float <ToEaseFunction>b__4_34(float time, float duration, float overshootOrAmplitude, float period);
                        /*0xe2b118*/ float <ToEaseFunction>b__4_35(float time, float duration, float overshootOrAmplitude, float period);
                    }
                }

                class EaseCurve
                {
                    /*0x10*/ UnityEngine.AnimationCurve _animCurve;

                    /*0xe2b12c*/ EaseCurve(UnityEngine.AnimationCurve animCurve);
                    /*0xe2b154*/ float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod);
                }

                class Flash
                {
                    static /*0xe28ebc*/ float Ease(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0xe28f88*/ float EaseIn(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0xe29058*/ float EaseOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0xe29130*/ float EaseInOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0xe2b1f0*/ float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663;
    static /*0x32*/ <PrivateImplementationDetails> 921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055;
    static /*0x46*/ <PrivateImplementationDetails> A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678;
    static /*0xbe*/ <PrivateImplementationDetails> C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020;

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=50
    {
    }

    struct __StaticArrayInitTypeSize=120
    {
    }
}
