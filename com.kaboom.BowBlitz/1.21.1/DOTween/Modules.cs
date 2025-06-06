class <Module>
{
}

namespace DG
{
    namespace Tweening
    {
        class DOTweenModuleAudio
        {
            static /*0xe056c8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0xe05864*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOPitch(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0xe059d8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration);
            static /*0xe05b50*/ int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks);
            static /*0xe05bb8*/ int DOKill(UnityEngine.Audio.AudioMixer target, bool complete);
            static /*0xe05c20*/ int DOFlip(UnityEngine.Audio.AudioMixer target);
            static /*0xe05c78*/ int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay);
            static /*0xe05cf0*/ int DOPause(UnityEngine.Audio.AudioMixer target);
            static /*0xe05d48*/ int DOPlay(UnityEngine.Audio.AudioMixer target);
            static /*0xe05da0*/ int DOPlayBackwards(UnityEngine.Audio.AudioMixer target);
            static /*0xe05df8*/ int DOPlayForward(UnityEngine.Audio.AudioMixer target);
            static /*0xe05e50*/ int DORestart(UnityEngine.Audio.AudioMixer target);
            static /*0xe05eb0*/ int DORewind(UnityEngine.Audio.AudioMixer target);
            static /*0xe05f0c*/ int DOSmoothRewind(UnityEngine.Audio.AudioMixer target);
            static /*0xe05f64*/ int DOTogglePause(UnityEngine.Audio.AudioMixer target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0xe0585c*/ <>c__DisplayClass0_0();
                /*0xe05fbc*/ float <DOFade>b__0();
                /*0xe05fd8*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0xe059d0*/ <>c__DisplayClass1_0();
                /*0xe05ff4*/ float <DOPitch>b__0();
                /*0xe06010*/ void <DOPitch>b__1(float x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Audio.AudioMixer target;
                /*0x18*/ string floatName;

                /*0xe05b48*/ <>c__DisplayClass2_0();
                /*0xe0602c*/ float <DOSetFloat>b__0();
                /*0xe06060*/ void <DOSetFloat>b__1(float x);
            }
        }

        class DOTweenModulePhysics
        {
            static /*0xe06084*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0xe0622c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0xe063c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0xe06564*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0xe06700*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0xe068a4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0xe06afc*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0xe06fdc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0xe07240*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0xe074b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0xe07674*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe06224*/ <>c__DisplayClass0_0();
                /*0xe07844*/ UnityEngine.Vector3 <DOMove>b__0();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe063c0*/ <>c__DisplayClass1_0();
                /*0xe07860*/ UnityEngine.Vector3 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe0655c*/ <>c__DisplayClass2_0();
                /*0xe0787c*/ UnityEngine.Vector3 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe066f8*/ <>c__DisplayClass3_0();
                /*0xe07898*/ UnityEngine.Vector3 <DOMoveZ>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe0689c*/ <>c__DisplayClass4_0();
                /*0xe078b4*/ UnityEngine.Quaternion <DORotate>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe06af4*/ <>c__DisplayClass5_0();
                /*0xe078d0*/ UnityEngine.Quaternion <DOLookAt>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0xe06fd4*/ <>c__DisplayClass6_0();
                /*0xe078ec*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0xe07908*/ void <DOJump>b__1();
                /*0xe07930*/ UnityEngine.Vector3 <DOJump>b__2();
                /*0xe0794c*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0xe07968*/ void <DOJump>b__4();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe07238*/ <>c__DisplayClass7_0();
                /*0xe07a1c*/ UnityEngine.Vector3 <DOPath>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0xe074a8*/ <>c__DisplayClass8_0();
                /*0xe07a38*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0xe07a54*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0xe0766c*/ <>c__DisplayClass9_0();
                /*0xe07b40*/ UnityEngine.Vector3 <DOPath>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0xe0783c*/ <>c__DisplayClass10_0();
                /*0xe07b5c*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0xe07b78*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }
        }

        class DOTweenModulePhysics2D
        {
            static /*0xe07c64*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe07e04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0xe07f9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0xe08134*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration);
            static /*0xe082b4*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0xe086bc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0xe0899c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0xe08c94*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0xe08e50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0xe07dfc*/ <>c__DisplayClass0_0();
                /*0xe09024*/ UnityEngine.Vector2 <DOMove>b__0();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0xe07f94*/ <>c__DisplayClass1_0();
                /*0xe09040*/ UnityEngine.Vector2 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0xe0812c*/ <>c__DisplayClass2_0();
                /*0xe0905c*/ UnityEngine.Vector2 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0xe082ac*/ <>c__DisplayClass3_0();
                /*0xe09078*/ float <DORotate>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector2 endValue;
                /*0x38*/ DG.Tweening.Tween yTween;

                /*0xe086b4*/ <>c__DisplayClass4_0();
                /*0xe09094*/ UnityEngine.Vector2 <DOJump>b__0();
                /*0xe090b0*/ void <DOJump>b__1(UnityEngine.Vector2 x);
                /*0xe090cc*/ void <DOJump>b__2();
                /*0xe090f4*/ UnityEngine.Vector2 <DOJump>b__3();
                /*0xe09110*/ void <DOJump>b__4(UnityEngine.Vector2 x);
                /*0xe0912c*/ void <DOJump>b__5();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0xe08994*/ <>c__DisplayClass5_0();
                /*0xe091d8*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0xe091fc*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0xe08c8c*/ <>c__DisplayClass6_0();
                /*0xe09218*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0xe09234*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0xe08e48*/ <>c__DisplayClass7_0();
                /*0xe09318*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0xe0933c*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0xe0901c*/ <>c__DisplayClass8_0();
                /*0xe09358*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0xe09374*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }
        }

        class DOTweenModuleSprite
        {
            static /*0xe09458*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);
            static /*0xe095f4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration);
            static /*0xe09768*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration);
            static /*0xe09944*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0xe095ec*/ <>c__DisplayClass0_0();
                /*0xe09b3c*/ UnityEngine.Color <DOColor>b__0();
                /*0xe09b58*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0xe09760*/ <>c__DisplayClass1_0();
                /*0xe09b74*/ UnityEngine.Color <DOFade>b__0();
                /*0xe09b90*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.SpriteRenderer target;

                /*0xe09b34*/ <>c__DisplayClass3_0();
                /*0xe09bac*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe09bb8*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }
        }

        class DOTweenModuleUI
        {
            static /*0xe09c24*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, float endValue, float duration);
            static /*0xe09d98*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0xe09f34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, float endValue, float duration);
            static /*0xe0a0a8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0xe0a244*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0xe0a3b8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0xe0a550*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration);
            static /*0xe0a734*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0a8d0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0aa6c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0ac08*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration);
            static /*0xe0ada4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, float endValue, float duration);
            static /*0xe0af18*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration);
            static /*0xe0b09c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0b238*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0xe0b3cc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0xe0b560*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0xe0b704*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0xe0b89c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0xe0ba34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0xe0bbcc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0bd68*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0bf04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration);
            static /*0xe0c088*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0xe0c210*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0xe0c398*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0c534*/ DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0xe0c6d8*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xe0c8b4*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0xe0ca98*/ DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0xe0cea4*/ DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0xe0d034*/ DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0xe0d1b4*/ DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0xe0d334*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping);
            static /*0xe0d4c0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0xe0d65c*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator, System.Globalization.CultureInfo culture);
            static /*0xe0d838*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, float endValue, float duration);
            static /*0xe0d9ac*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0xe0dbcc*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0xe0ddcc*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0xe0dfcc*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0xe0e1cc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> DOShapeCircle(UnityEngine.RectTransform target, UnityEngine.Vector2 center, float endValueDegrees, float duration, bool relativeCenter, bool snapping);

            class Utils
            {
                static /*0xe0e3a8*/ UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to);
            }

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.CanvasGroup target;

                /*0xe09d90*/ <>c__DisplayClass0_0();
                /*0xe0e5d8*/ float <DOFade>b__0();
                /*0xe0e5f4*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0xe09f2c*/ <>c__DisplayClass1_0();
                /*0xe0e610*/ UnityEngine.Color <DOColor>b__0();
                /*0xe0e634*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0xe0a0a0*/ <>c__DisplayClass2_0();
                /*0xe0e658*/ UnityEngine.Color <DOFade>b__0();
                /*0xe0e67c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0xe0a23c*/ <>c__DisplayClass3_0();
                /*0xe0e6a0*/ UnityEngine.Color <DOColor>b__0();
                /*0xe0e6c4*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0xe0a3b0*/ <>c__DisplayClass4_0();
                /*0xe0e6e8*/ UnityEngine.Color <DOFade>b__0();
                /*0xe0e70c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0xe0a548*/ <>c__DisplayClass5_0();
                /*0xe0e730*/ float <DOFillAmount>b__0();
                /*0xe0e74c*/ void <DOFillAmount>b__1(float x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0xe0a8c8*/ <>c__DisplayClass7_0();
                /*0xe0e768*/ UnityEngine.Vector2 <DOFlexibleSize>b__0();
                /*0xe0e7c0*/ void <DOFlexibleSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0xe0aa64*/ <>c__DisplayClass8_0();
                /*0xe0e810*/ UnityEngine.Vector2 <DOMinSize>b__0();
                /*0xe0e868*/ void <DOMinSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0xe0ac00*/ <>c__DisplayClass9_0();
                /*0xe0e8b8*/ UnityEngine.Vector2 <DOPreferredSize>b__0();
                /*0xe0e910*/ void <DOPreferredSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0xe0ad9c*/ <>c__DisplayClass10_0();
                /*0xe0e960*/ UnityEngine.Color <DOColor>b__0();
                /*0xe0e980*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0xe0af10*/ <>c__DisplayClass11_0();
                /*0xe0e99c*/ UnityEngine.Color <DOFade>b__0();
                /*0xe0e9bc*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0xe0b094*/ <>c__DisplayClass12_0();
                /*0xe0e9d8*/ UnityEngine.Vector2 <DOScale>b__0();
                /*0xe0e9f4*/ void <DOScale>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0b230*/ <>c__DisplayClass13_0();
                /*0xe0ea10*/ UnityEngine.Vector2 <DOAnchorPos>b__0();
                /*0xe0ea2c*/ void <DOAnchorPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0b3c4*/ <>c__DisplayClass14_0();
                /*0xe0ea48*/ UnityEngine.Vector2 <DOAnchorPosX>b__0();
                /*0xe0ea64*/ void <DOAnchorPosX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0b558*/ <>c__DisplayClass15_0();
                /*0xe0ea80*/ UnityEngine.Vector2 <DOAnchorPosY>b__0();
                /*0xe0ea9c*/ void <DOAnchorPosY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0b6fc*/ <>c__DisplayClass16_0();
                /*0xe0eab8*/ UnityEngine.Vector3 <DOAnchorPos3D>b__0();
                /*0xe0ead4*/ void <DOAnchorPos3D>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0b894*/ <>c__DisplayClass17_0();
                /*0xe0eaf0*/ UnityEngine.Vector3 <DOAnchorPos3DX>b__0();
                /*0xe0eb0c*/ void <DOAnchorPos3DX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0ba2c*/ <>c__DisplayClass18_0();
                /*0xe0eb28*/ UnityEngine.Vector3 <DOAnchorPos3DY>b__0();
                /*0xe0eb44*/ void <DOAnchorPos3DY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0bbc4*/ <>c__DisplayClass19_0();
                /*0xe0eb60*/ UnityEngine.Vector3 <DOAnchorPos3DZ>b__0();
                /*0xe0eb7c*/ void <DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0bd60*/ <>c__DisplayClass20_0();
                /*0xe0eb98*/ UnityEngine.Vector2 <DOAnchorMax>b__0();
                /*0xe0ebb4*/ void <DOAnchorMax>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0befc*/ <>c__DisplayClass21_0();
                /*0xe0ebd0*/ UnityEngine.Vector2 <DOAnchorMin>b__0();
                /*0xe0ebec*/ void <DOAnchorMin>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0c080*/ <>c__DisplayClass22_0();
                /*0xe0ec08*/ UnityEngine.Vector2 <DOPivot>b__0();
                /*0xe0ec24*/ void <DOPivot>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0c208*/ <>c__DisplayClass23_0();
                /*0xe0ec40*/ UnityEngine.Vector2 <DOPivotX>b__0();
                /*0xe0ec5c*/ void <DOPivotX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0c390*/ <>c__DisplayClass24_0();
                /*0xe0ec78*/ UnityEngine.Vector2 <DOPivotY>b__0();
                /*0xe0ec94*/ void <DOPivotY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0c52c*/ <>c__DisplayClass25_0();
                /*0xe0ecb0*/ UnityEngine.Vector2 <DOSizeDelta>b__0();
                /*0xe0eccc*/ void <DOSizeDelta>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0c6d0*/ <>c__DisplayClass26_0();
                /*0xe0ece8*/ UnityEngine.Vector3 <DOPunchAnchorPos>b__0();
                /*0xe0ed0c*/ void <DOPunchAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0c8ac*/ <>c__DisplayClass27_0();
                /*0xe0ed28*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0xe0ed4c*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0ca90*/ <>c__DisplayClass28_0();
                /*0xe0ed68*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0xe0ed8c*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.RectTransform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector2 endValue;

                /*0xe0ce9c*/ <>c__DisplayClass29_0();
                /*0xe0eda8*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__0();
                /*0xe0edc4*/ void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x);
                /*0xe0ede0*/ void <DOJumpAnchorPos>b__2();
                /*0xe0ee08*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__3();
                /*0xe0ee24*/ void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x);
                /*0xe0ee40*/ void <DOJumpAnchorPos>b__5();
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0xe0d02c*/ <>c__DisplayClass30_0();
                /*0xe0eee8*/ UnityEngine.Vector2 <DONormalizedPos>b__0();
                /*0xe0ef30*/ void <DONormalizedPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0xe0d1ac*/ <>c__DisplayClass31_0();
                /*0xe0ef70*/ float <DOHorizontalNormalizedPos>b__0();
                /*0xe0ef8c*/ void <DOHorizontalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0xe0d32c*/ <>c__DisplayClass32_0();
                /*0xe0efa8*/ float <DOVerticalNormalizedPos>b__0();
                /*0xe0efc4*/ void <DOVerticalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.UI.Slider target;

                /*0xe0d4b8*/ <>c__DisplayClass33_0();
                /*0xe0efe0*/ float <DOValue>b__0();
                /*0xe0f004*/ void <DOValue>b__1(float x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0xe0d654*/ <>c__DisplayClass34_0();
                /*0xe0f028*/ UnityEngine.Color <DOColor>b__0();
                /*0xe0f04c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ int v;
                /*0x18*/ UnityEngine.UI.Text target;
                /*0x20*/ bool addThousandsSeparator;
                /*0x28*/ System.Globalization.CultureInfo cInfo;

                /*0xe0d830*/ <>c__DisplayClass35_0();
                /*0xe0f070*/ int <DOCounter>b__0();
                /*0xe0f078*/ void <DOCounter>b__1(int x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0xe0d9a4*/ <>c__DisplayClass36_0();
                /*0xe0f108*/ UnityEngine.Color <DOFade>b__0();
                /*0xe0f12c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0xe0dbc4*/ <>c__DisplayClass37_0();
                /*0xe0f150*/ string <DOText>b__0();
                /*0xe0f174*/ void <DOText>b__1(string x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Graphic target;

                /*0xe0ddc4*/ <>c__DisplayClass38_0();
                /*0xe0f198*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe0f1a4*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Image target;

                /*0xe0dfc4*/ <>c__DisplayClass39_0();
                /*0xe0f220*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe0f22c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Text target;

                /*0xe0e1c4*/ <>c__DisplayClass40_0();
                /*0xe0f2a8*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0xe0f2b4*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0xe0e3a0*/ <>c__DisplayClass41_0();
                /*0xe0f330*/ UnityEngine.Vector2 <DOShapeCircle>b__0();
                /*0xe0f34c*/ void <DOShapeCircle>b__1(UnityEngine.Vector2 x);
            }
        }

        class DOTweenModuleUnityVersion
        {
            static /*0xe0f368*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration);
            static /*0xe0f548*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration);
            static /*0xe0f734*/ UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0xe0f81c*/ UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0xe0f904*/ UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0xe0f9ec*/ UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction);
            static /*0xe0fae4*/ UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction);
            static /*0xe0fbec*/ UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0xe0fcd4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0xe0fec8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0xe100bc*/ System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t);
            static /*0xe10184*/ System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t);
            static /*0xe1024c*/ System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t);
            static /*0xe10314*/ System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0xe103ec*/ System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, float position);
            static /*0xe104c4*/ System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0xe0fec0*/ <>c__DisplayClass8_0();
                /*0xe1058c*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0xe105b0*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0xe100b4*/ <>c__DisplayClass9_0();
                /*0xe105d4*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0xe105f8*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            struct <AsyncWaitForCompletion>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0xe1061c*/ void MoveNext();
                /*0xe10854*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForRewind>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0xe10860*/ void MoveNext();
                /*0xe10abc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForKill>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0xe10ac8*/ void MoveNext();
                /*0xe10cec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForElapsedLoops>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ int elapsedLoops;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0xe10cf8*/ void MoveNext();
                /*0xe10f38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForPosition>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ float position;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0xe10f44*/ void MoveNext();
                /*0xe1119c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForStart>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0xe111a8*/ void MoveNext();
                /*0xe113d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DOTweenCYInstruction
        {
            class WaitForCompletion : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0xe0f7f4*/ WaitForCompletion(DG.Tweening.Tween tween);
                /*0xe113e0*/ bool get_keepWaiting();
            }

            class WaitForRewind : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0xe0f8dc*/ WaitForRewind(DG.Tweening.Tween tween);
                /*0xe11410*/ bool get_keepWaiting();
            }

            class WaitForKill : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0xe0f9c4*/ WaitForKill(DG.Tweening.Tween tween);
                /*0xe11470*/ bool get_keepWaiting();
            }

            class WaitForElapsedLoops : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ int elapsedLoops;

                /*0xe0fab4*/ WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops);
                /*0xe1148c*/ bool get_keepWaiting();
            }

            class WaitForPosition : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ float position;

                /*0xe0fbb4*/ WaitForPosition(DG.Tweening.Tween tween, float position);
                /*0xe114cc*/ bool get_keepWaiting();
            }

            class WaitForStart : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0xe0fcac*/ WaitForStart(DG.Tweening.Tween tween);
                /*0xe11524*/ bool get_keepWaiting();
            }
        }

        class DOTweenModuleUtils
        {
            static /*0x0*/ bool _initialized;

            static /*0xe11558*/ void Init();
            static /*0xe1160c*/ void Preserver();

            class Physics
            {
                static /*0xe116b4*/ void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
                static /*0xe117b4*/ bool HasRigidbody2D(UnityEngine.Component target);
                static /*0xe11840*/ bool HasRigidbody(UnityEngine.Component target);
                static /*0xe118cc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            }
        }
    }
}
