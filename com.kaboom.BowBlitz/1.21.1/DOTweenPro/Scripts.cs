class <Module>
{
}

namespace DG
{
    namespace Tweening
    {
        class DOTweenAnimation : DG.Tweening.Core.ABSAnimationComponent
        {
            static /*0x0*/ System.Action<DG.Tweening.DOTweenAnimation> OnReset;
            /*0x68*/ bool targetIsSelf;
            /*0x70*/ UnityEngine.GameObject targetGO;
            /*0x78*/ bool tweenTargetIsTargetGO;
            /*0x7c*/ float delay;
            /*0x80*/ float duration;
            /*0x84*/ DG.Tweening.Ease easeType;
            /*0x88*/ UnityEngine.AnimationCurve easeCurve;
            /*0x90*/ DG.Tweening.LoopType loopType;
            /*0x94*/ int loops;
            /*0x98*/ string id;
            /*0xa0*/ bool isRelative;
            /*0xa1*/ bool isFrom;
            /*0xa2*/ bool isIndependentUpdate;
            /*0xa3*/ bool autoKill;
            /*0xa4*/ bool autoGenerate;
            /*0xa5*/ bool isActive;
            /*0xa6*/ bool isValid;
            /*0xa8*/ UnityEngine.Component target;
            /*0xb0*/ DG.Tweening.DOTweenAnimation.AnimationType animationType;
            /*0xb4*/ DG.Tweening.DOTweenAnimation.TargetType targetType;
            /*0xb8*/ DG.Tweening.DOTweenAnimation.TargetType forcedTargetType;
            /*0xbc*/ bool autoPlay;
            /*0xbd*/ bool useTargetAsV3;
            /*0xc0*/ float endValueFloat;
            /*0xc4*/ UnityEngine.Vector3 endValueV3;
            /*0xd0*/ UnityEngine.Vector2 endValueV2;
            /*0xd8*/ UnityEngine.Color endValueColor;
            /*0xe8*/ string endValueString;
            /*0xf0*/ UnityEngine.Rect endValueRect;
            /*0x100*/ UnityEngine.Transform endValueTransform;
            /*0x108*/ bool optionalBool0;
            /*0x109*/ bool optionalBool1;
            /*0x10c*/ float optionalFloat0;
            /*0x110*/ int optionalInt0;
            /*0x114*/ DG.Tweening.RotateMode optionalRotationMode;
            /*0x118*/ DG.Tweening.ScrambleMode optionalScrambleMode;
            /*0x11c*/ DG.Tweening.ShakeRandomnessMode optionalShakeRandomnessMode;
            /*0x120*/ string optionalString;
            /*0x128*/ bool _tweenAutoGenerationCalled;
            /*0x12c*/ int _playCount;

            static /*0xe2d588*/ void add_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value);
            static /*0xe2d654*/ void remove_OnReset(System.Action<DG.Tweening.DOTweenAnimation> value);
            static /*0xe2d720*/ void Dispatch_OnReset(DG.Tweening.DOTweenAnimation anim);
            static /*0xe2ee98*/ DG.Tweening.DOTweenAnimation.TargetType TypeToDOTargetType(System.Type t);
            /*0xe30234*/ DOTweenAnimation();
            /*0xe2d78c*/ void Awake();
            /*0xe2ed84*/ void Start();
            /*0xe2edc4*/ void Reset();
            /*0xe2edc8*/ void OnDestroy();
            /*0xe2edf8*/ void RewindThenRecreateTween();
            /*0xe2ee30*/ void RewindThenRecreateTweenAndPlay();
            /*0xe2ee68*/ void RecreateTween();
            /*0xe2ee74*/ void RecreateTweenAndPlay();
            /*0xe2d7d8*/ void CreateTween(bool regenerateIfExists, bool andPlay);
            /*0xe2f0c8*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweens();
            /*0xe2f21c*/ void SetAnimationTarget(UnityEngine.Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations);
            /*0xe2f2ec*/ void DOPlay();
            /*0xe2f36c*/ void DOPlayBackwards();
            /*0xe2f3ec*/ void DOPlayForward();
            /*0xe2f46c*/ void DOPause();
            /*0xe2f4ec*/ void DOTogglePause();
            /*0xe2f56c*/ void DORewind();
            /*0xe2f650*/ void DORestart();
            /*0xe2f660*/ void DORestart(bool fromHere);
            /*0xe2f9c0*/ void DOComplete();
            /*0xe2fa44*/ void DOKill();
            /*0xe2fad0*/ void DOPlayById(string id);
            /*0xe2fb58*/ void DOPlayAllById(string id);
            /*0xe2fbb0*/ void DOPauseAllById(string id);
            /*0xe2fc08*/ void DOPlayBackwardsById(string id);
            /*0xe2fc90*/ void DOPlayBackwardsAllById(string id);
            /*0xe2fce8*/ void DOPlayForwardById(string id);
            /*0xe2fd70*/ void DOPlayForwardAllById(string id);
            /*0xe2fdc8*/ void DOPlayNext();
            /*0xe2ff04*/ void DORewindAndPlayNext();
            /*0xe2ff98*/ void DORewindAllById(string id);
            /*0xe30008*/ void DORestartById(string id);
            /*0xe300a0*/ void DORestartAllById(string id);
            /*0xe30114*/ void DOKillById(string id);
            /*0xe301a0*/ void DOKillAllById(string id);
            /*0xe301fc*/ DG.Tweening.Tween CreateEditorPreview();
            /*0xe2ee80*/ UnityEngine.GameObject GetTweenGO();
            /*0xe2f0a8*/ UnityEngine.GameObject GetTweenTarget();
            /*0xe2f76c*/ void ReEvaluateRelativeTween();
            /*0xe303fc*/ void <CreateTween>b__54_0();

            enum AnimationType
            {
                None = 0,
                Move = 1,
                LocalMove = 2,
                Rotate = 3,
                LocalRotate = 4,
                Scale = 5,
                Color = 6,
                Fade = 7,
                Text = 8,
                PunchPosition = 9,
                PunchRotation = 10,
                PunchScale = 11,
                ShakePosition = 12,
                ShakeRotation = 13,
                ShakeScale = 14,
                CameraAspect = 15,
                CameraBackgroundColor = 16,
                CameraFieldOfView = 17,
                CameraOrthoSize = 18,
                CameraPixelRect = 19,
                CameraRect = 20,
                UIWidthHeight = 21,
            }

            enum TargetType
            {
                Unset = 0,
                Camera = 1,
                CanvasGroup = 2,
                Image = 3,
                Light = 4,
                RectTransform = 5,
                Renderer = 6,
                SpriteRenderer = 7,
                Rigidbody = 8,
                Rigidbody2D = 9,
                Text = 10,
                Transform = 11,
                tk2dBaseSprite = 12,
                tk2dTextMesh = 13,
                TextMeshPro = 14,
                TextMeshProUGUI = 15,
            }
        }

        class DOTweenAnimationExtensions
        {
            static bool IsSameOrSubclassOf<T>(UnityEngine.Component t);
        }

        class DOTweenProShortcuts
        {
            static /*0xe30404*/ DOTweenProShortcuts();
            static /*0xe30454*/ DG.Tweening.Tweener DOSpiral(UnityEngine.Transform target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode, float speed, float frequency, float depth, bool snapping);
            static /*0xe30808*/ DG.Tweening.Tweener DOSpiral(UnityEngine.Rigidbody target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode, float speed, float frequency, float depth, bool snapping);

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0xe30800*/ <>c__DisplayClass1_0();
                /*0xe30bc0*/ UnityEngine.Vector3 <DOSpiral>b__0();
                /*0xe30bdc*/ void <DOSpiral>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe30bb8*/ <>c__DisplayClass2_0();
                /*0xe30bf8*/ UnityEngine.Vector3 <DOSpiral>b__0();
            }
        }
    }
}
