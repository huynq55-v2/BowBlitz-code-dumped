class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x27e5994*/ EmbeddedAttribute();
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
                /*0x27e599c*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    class AnimationClipPair
    {
        /*0x10*/ UnityEngine.AnimationClip originalClip;
        /*0x18*/ UnityEngine.AnimationClip overrideClip;

        /*0x27e59a4*/ AnimationClipPair();
    }

    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x27e5a50*/ void Internal_Create(UnityEngine.AnimatorOverrideController self, UnityEngine.RuntimeAnimatorController controller);
        static /*0x27e6670*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);
        /*0x27e59ac*/ AnimatorOverrideController();
        /*0x27e5a94*/ AnimatorOverrideController(UnityEngine.RuntimeAnimatorController controller);
        /*0x27e5ae4*/ UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController();
        /*0x27e5b20*/ void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value);
        /*0x27e5b64*/ UnityEngine.AnimationClip get_Item(string name);
        /*0x27e5c00*/ void set_Item(string name, UnityEngine.AnimationClip value);
        /*0x27e5bac*/ UnityEngine.AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip);
        /*0x27e5c54*/ void Internal_SetClipByName(string name, UnityEngine.AnimationClip clip);
        /*0x27e5ca8*/ UnityEngine.AnimationClip get_Item(UnityEngine.AnimationClip clip);
        /*0x27e5d44*/ void set_Item(UnityEngine.AnimationClip clip, UnityEngine.AnimationClip value);
        /*0x27e5cf0*/ UnityEngine.AnimationClip GetClip(UnityEngine.AnimationClip originalClip, bool returnEffectiveClip);
        /*0x27e5d9c*/ void SetClip(UnityEngine.AnimationClip originalClip, UnityEngine.AnimationClip overrideClip, bool notify);
        /*0x27e5df8*/ void SendNotification();
        /*0x27e5e34*/ UnityEngine.AnimationClip GetOriginalClip(int index);
        /*0x27e5e78*/ UnityEngine.AnimationClip GetOverrideClip(UnityEngine.AnimationClip originalClip);
        /*0x27e5ebc*/ int get_overridesCount();
        /*0x27e5ef8*/ void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides);
        /*0x27e6160*/ void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides);
        /*0x27e63c0*/ UnityEngine.AnimationClipPair[] get_clips();
        /*0x27e6568*/ void set_clips(UnityEngine.AnimationClipPair[] value);
        /*0x27e6634*/ void PerformOverrideClipListCleanup();

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0x27e66a0*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x27e675c*/ void Invoke();
        }
    }

    struct SkeletonBone
    {
        /*0x10*/ string name;
        /*0x18*/ string parentName;
        /*0x20*/ UnityEngine.Vector3 position;
        /*0x2c*/ UnityEngine.Quaternion rotation;
        /*0x3c*/ UnityEngine.Vector3 scale;

        /*0x27e6770*/ int get_transformModified();
        /*0x27e6778*/ void set_transformModified(int value);
    }

    struct HumanLimit
    {
        /*0x10*/ UnityEngine.Vector3 m_Min;
        /*0x1c*/ UnityEngine.Vector3 m_Max;
        /*0x28*/ UnityEngine.Vector3 m_Center;
        /*0x34*/ float m_AxisLength;
        /*0x38*/ int m_UseDefaultValues;

        /*0x27e677c*/ bool get_useDefaultValues();
        /*0x27e678c*/ void set_useDefaultValues(bool value);
        /*0x27e6798*/ UnityEngine.Vector3 get_min();
        /*0x27e67a4*/ void set_min(UnityEngine.Vector3 value);
        /*0x27e67b0*/ UnityEngine.Vector3 get_max();
        /*0x27e67bc*/ void set_max(UnityEngine.Vector3 value);
        /*0x27e67c8*/ UnityEngine.Vector3 get_center();
        /*0x27e67d4*/ void set_center(UnityEngine.Vector3 value);
        /*0x27e67e0*/ float get_axisLength();
        /*0x27e67e8*/ void set_axisLength(float value);
    }

    struct HumanBone
    {
        /*0x10*/ string m_BoneName;
        /*0x18*/ string m_HumanName;
        /*0x20*/ UnityEngine.HumanLimit limit;

        /*0x27e67f0*/ string get_boneName();
        /*0x27e67f8*/ void set_boneName(string value);
        /*0x27e6800*/ string get_humanName();
        /*0x27e6808*/ void set_humanName(string value);
    }

    struct HumanDescription
    {
        /*0x10*/ UnityEngine.HumanBone[] human;
        /*0x18*/ UnityEngine.SkeletonBone[] skeleton;
        /*0x20*/ float m_ArmTwist;
        /*0x24*/ float m_ForeArmTwist;
        /*0x28*/ float m_UpperLegTwist;
        /*0x2c*/ float m_LegTwist;
        /*0x30*/ float m_ArmStretch;
        /*0x34*/ float m_LegStretch;
        /*0x38*/ float m_FeetSpacing;
        /*0x3c*/ float m_GlobalScale;
        /*0x40*/ string m_RootMotionBoneName;
        /*0x48*/ bool m_HasTranslationDoF;
        /*0x49*/ bool m_HasExtraRoot;
        /*0x4a*/ bool m_SkeletonHasParents;

        /*0x27e6810*/ float get_upperArmTwist();
        /*0x27e6818*/ void set_upperArmTwist(float value);
        /*0x27e6820*/ float get_lowerArmTwist();
        /*0x27e6828*/ void set_lowerArmTwist(float value);
        /*0x27e6830*/ float get_upperLegTwist();
        /*0x27e6838*/ void set_upperLegTwist(float value);
        /*0x27e6840*/ float get_lowerLegTwist();
        /*0x27e6848*/ void set_lowerLegTwist(float value);
        /*0x27e6850*/ float get_armStretch();
        /*0x27e6858*/ void set_armStretch(float value);
        /*0x27e6860*/ float get_legStretch();
        /*0x27e6868*/ void set_legStretch(float value);
        /*0x27e6870*/ float get_feetSpacing();
        /*0x27e6878*/ void set_feetSpacing(float value);
        /*0x27e6880*/ bool get_hasTranslationDoF();
        /*0x27e6888*/ void set_hasTranslationDoF(bool value);
    }

    class AvatarBuilder
    {
        static /*0x27e6894*/ UnityEngine.Avatar BuildHumanAvatar(UnityEngine.GameObject go, UnityEngine.HumanDescription humanDescription);
        static /*0x27e6984*/ UnityEngine.Avatar BuildHumanAvatarInternal(UnityEngine.GameObject go, UnityEngine.HumanDescription humanDescription);
        static /*0x27e6a0c*/ UnityEngine.Avatar BuildGenericAvatar(UnityEngine.GameObject go, string rootMotionTransformName);
        static /*0x27e69c8*/ UnityEngine.Avatar BuildHumanAvatarInternal_Injected(UnityEngine.GameObject go, ref UnityEngine.HumanDescription humanDescription);
        /*0x27e6a50*/ AvatarBuilder();
    }

    enum BodyDof
    {
        SpineFrontBack = 0,
        SpineLeftRight = 1,
        SpineRollLeftRight = 2,
        ChestFrontBack = 3,
        ChestLeftRight = 4,
        ChestRollLeftRight = 5,
        UpperChestFrontBack = 6,
        UpperChestLeftRight = 7,
        UpperChestRollLeftRight = 8,
        LastBodyDof = 9,
    }

    enum HeadDof
    {
        NeckFrontBack = 0,
        NeckLeftRight = 1,
        NeckRollLeftRight = 2,
        HeadFrontBack = 3,
        HeadLeftRight = 4,
        HeadRollLeftRight = 5,
        LeftEyeDownUp = 6,
        LeftEyeInOut = 7,
        RightEyeDownUp = 8,
        RightEyeInOut = 9,
        JawDownUp = 10,
        JawLeftRight = 11,
        LastHeadDof = 12,
    }

    enum LegDof
    {
        UpperLegFrontBack = 0,
        UpperLegInOut = 1,
        UpperLegRollInOut = 2,
        LegCloseOpen = 3,
        LegRollInOut = 4,
        FootCloseOpen = 5,
        FootInOut = 6,
        ToesUpDown = 7,
        LastLegDof = 8,
    }

    enum ArmDof
    {
        ShoulderDownUp = 0,
        ShoulderFrontBack = 1,
        ArmDownUp = 2,
        ArmFrontBack = 3,
        ArmRollInOut = 4,
        ForeArmCloseOpen = 5,
        ForeArmRollInOut = 6,
        HandDownUp = 7,
        HandInOut = 8,
        LastArmDof = 9,
    }

    enum FingerDof
    {
        ProximalDownUp = 0,
        ProximalInOut = 1,
        IntermediateCloseOpen = 2,
        DistalCloseOpen = 3,
        LastFingerDof = 4,
    }

    enum HumanPartDof
    {
        Body = 0,
        Head = 1,
        LeftLeg = 2,
        RightLeg = 3,
        LeftArm = 4,
        RightArm = 5,
        LeftThumb = 6,
        LeftIndex = 7,
        LeftMiddle = 8,
        LeftRing = 9,
        LeftLittle = 10,
        RightThumb = 11,
        RightIndex = 12,
        RightMiddle = 13,
        RightRing = 14,
        RightLittle = 15,
        LastHumanPartDof = 16,
    }

    enum Dof
    {
        BodyDofStart = 0,
        HeadDofStart = 9,
        LeftLegDofStart = 21,
        RightLegDofStart = 29,
        LeftArmDofStart = 37,
        RightArmDofStart = 46,
        LeftThumbDofStart = 55,
        LeftIndexDofStart = 59,
        LeftMiddleDofStart = 63,
        LeftRingDofStart = 67,
        LeftLittleDofStart = 71,
        RightThumbDofStart = 75,
        RightIndexDofStart = 79,
        RightMiddleDofStart = 83,
        RightRingDofStart = 87,
        RightLittleDofStart = 91,
        LastDof = 95,
    }

    enum HumanBodyBones
    {
        Hips = 0,
        LeftUpperLeg = 1,
        RightUpperLeg = 2,
        LeftLowerLeg = 3,
        RightLowerLeg = 4,
        LeftFoot = 5,
        RightFoot = 6,
        Spine = 7,
        Chest = 8,
        UpperChest = 54,
        Neck = 9,
        Head = 10,
        LeftShoulder = 11,
        RightShoulder = 12,
        LeftUpperArm = 13,
        RightUpperArm = 14,
        LeftLowerArm = 15,
        RightLowerArm = 16,
        LeftHand = 17,
        RightHand = 18,
        LeftToes = 19,
        RightToes = 20,
        LeftEye = 21,
        RightEye = 22,
        Jaw = 23,
        LeftThumbProximal = 24,
        LeftThumbIntermediate = 25,
        LeftThumbDistal = 26,
        LeftIndexProximal = 27,
        LeftIndexIntermediate = 28,
        LeftIndexDistal = 29,
        LeftMiddleProximal = 30,
        LeftMiddleIntermediate = 31,
        LeftMiddleDistal = 32,
        LeftRingProximal = 33,
        LeftRingIntermediate = 34,
        LeftRingDistal = 35,
        LeftLittleProximal = 36,
        LeftLittleIntermediate = 37,
        LeftLittleDistal = 38,
        RightThumbProximal = 39,
        RightThumbIntermediate = 40,
        RightThumbDistal = 41,
        RightIndexProximal = 42,
        RightIndexIntermediate = 43,
        RightIndexDistal = 44,
        RightMiddleProximal = 45,
        RightMiddleIntermediate = 46,
        RightMiddleDistal = 47,
        RightRingProximal = 48,
        RightRingIntermediate = 49,
        RightRingDistal = 50,
        RightLittleProximal = 51,
        RightLittleIntermediate = 52,
        RightLittleDistal = 53,
        LastBone = 55,
    }

    enum HumanParameter
    {
        UpperArmTwist = 0,
        LowerArmTwist = 1,
        UpperLegTwist = 2,
        LowerLegTwist = 3,
        ArmStretch = 4,
        LegStretch = 5,
        FeetSpacing = 6,
    }

    class Avatar : UnityEngine.Object
    {
        /*0x27e6a58*/ Avatar();
        /*0x27e6ab0*/ bool get_isValid();
        /*0x27e6aec*/ bool get_isHuman();
        /*0x27e6b28*/ UnityEngine.HumanDescription get_humanDescription();
        /*0x27e6bd8*/ void SetMuscleMinMax(int muscleId, float min, float max);
        /*0x27e6c34*/ void SetParameter(int parameterId, float value);
        /*0x27e6c88*/ float GetAxisLength(int humanId);
        /*0x27e6d78*/ UnityEngine.Quaternion GetPreRotation(int humanId);
        /*0x27e6e24*/ UnityEngine.Quaternion GetPostRotation(int humanId);
        /*0x27e6ed0*/ UnityEngine.Quaternion GetZYPostQ(int humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q);
        /*0x27e6ff4*/ UnityEngine.Quaternion GetZYRoll(int humanId, UnityEngine.Vector3 uvw);
        /*0x27e70d4*/ UnityEngine.Vector3 GetLimitSign(int humanId);
        /*0x27e6d34*/ float Internal_GetAxisLength(int humanId);
        /*0x27e6dc4*/ UnityEngine.Quaternion Internal_GetPreRotation(int humanId);
        /*0x27e6e70*/ UnityEngine.Quaternion Internal_GetPostRotation(int humanId);
        /*0x27e6f7c*/ UnityEngine.Quaternion Internal_GetZYPostQ(int humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q);
        /*0x27e7068*/ UnityEngine.Quaternion Internal_GetZYRoll(int humanId, UnityEngine.Vector3 uvw);
        /*0x27e7120*/ UnityEngine.Vector3 Internal_GetLimitSign(int humanId);
        /*0x27e6b94*/ void get_humanDescription_Injected(ref UnityEngine.HumanDescription ret);
        /*0x27e7184*/ void Internal_GetPreRotation_Injected(int humanId, ref UnityEngine.Quaternion ret);
        /*0x27e71d8*/ void Internal_GetPostRotation_Injected(int humanId, ref UnityEngine.Quaternion ret);
        /*0x27e722c*/ void Internal_GetZYPostQ_Injected(int humanId, ref UnityEngine.Quaternion parentQ, ref UnityEngine.Quaternion q, ref UnityEngine.Quaternion ret);
        /*0x27e7298*/ void Internal_GetZYRoll_Injected(int humanId, ref UnityEngine.Vector3 uvw, ref UnityEngine.Quaternion ret);
        /*0x27e72f4*/ void Internal_GetLimitSign_Injected(int humanId, ref UnityEngine.Vector3 ret);
    }

    class AnimatorUtility
    {
        static /*0x27e7348*/ void OptimizeTransformHierarchy(UnityEngine.GameObject go, string[] exposedTransforms);
        static /*0x27e738c*/ void DeoptimizeTransformHierarchy(UnityEngine.GameObject go);
        /*0x27e73c8*/ AnimatorUtility();
    }

    enum AvatarMaskBodyPart
    {
        Root = 0,
        Body = 1,
        Head = 2,
        LeftLeg = 3,
        RightLeg = 4,
        LeftArm = 5,
        RightArm = 6,
        LeftFingers = 7,
        RightFingers = 8,
        LeftFootIK = 9,
        RightFootIK = 10,
        LeftHandIK = 11,
        RightHandIK = 12,
        LastBodyPart = 13,
    }

    class AvatarMask : UnityEngine.Object
    {
        static /*0x27e7450*/ void Internal_Create(UnityEngine.AvatarMask self);
        /*0x27e73d0*/ AvatarMask();
        /*0x27e748c*/ int get_humanoidBodyPartCount();
        /*0x27e7494*/ bool GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index);
        /*0x27e74d8*/ void SetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index, bool value);
        /*0x27e752c*/ int get_transformCount();
        /*0x27e7568*/ void set_transformCount(int value);
        /*0x27e75ac*/ void AddTransformPath(UnityEngine.Transform transform);
        /*0x27e75f4*/ void AddTransformPath(UnityEngine.Transform transform, bool recursive);
        /*0x27e7648*/ void RemoveTransformPath(UnityEngine.Transform transform);
        /*0x27e7690*/ void RemoveTransformPath(UnityEngine.Transform transform, bool recursive);
        /*0x27e76e4*/ string GetTransformPath(int index);
        /*0x27e7728*/ void SetTransformPath(int index, string path);
        /*0x27e777c*/ float GetTransformWeight(int index);
        /*0x27e77c0*/ void SetTransformWeight(int index, float weight);
        /*0x27e7814*/ bool GetTransformActive(int index);
        /*0x27e7868*/ void SetTransformActive(int index, bool value);
        /*0x27e78d0*/ bool get_hasFeetIK();
        /*0x27e790c*/ void Copy(UnityEngine.AvatarMask other);
    }

    class AnimatorControllerParameter
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.AnimatorControllerParameterType m_Type;
        /*0x1c*/ float m_DefaultFloat;
        /*0x20*/ int m_DefaultInt;
        /*0x24*/ bool m_DefaultBool;

        /*0x27e7cd0*/ AnimatorControllerParameter();
        /*0x27e7b10*/ string get_name();
        /*0x27e7b18*/ int get_nameHash();
        /*0x27e7b90*/ UnityEngine.AnimatorControllerParameterType get_type();
        /*0x27e7b98*/ void set_type(UnityEngine.AnimatorControllerParameterType value);
        /*0x27e7ba0*/ float get_defaultFloat();
        /*0x27e7ba8*/ void set_defaultFloat(float value);
        /*0x27e7bb0*/ int get_defaultInt();
        /*0x27e7bb8*/ void set_defaultInt(int value);
        /*0x27e7bc0*/ bool get_defaultBool();
        /*0x27e7bc8*/ void set_defaultBool(bool value);
        /*0x27e7bd4*/ bool Equals(object o);
        /*0x27e7cb0*/ int GetHashCode();
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
        /*0x27e59f8*/ RuntimeAnimatorController();
        /*0x27e7d20*/ UnityEngine.AnimationClip[] get_animationClips();
    }

    enum PlayMode
    {
        StopSameLayer = 0,
        StopAll = 4,
    }

    enum QueueMode
    {
        CompleteOthers = 0,
        PlayNow = 2,
    }

    enum AnimationBlendMode
    {
        Blend = 0,
        Additive = 1,
    }

    enum AnimationPlayMode
    {
        Stop = 0,
        Queue = 1,
        Mix = 2,
    }

    enum AnimationCullingType
    {
        AlwaysAnimate = 0,
        BasedOnRenderers = 1,
        BasedOnClipBounds = 2,
        BasedOnUserBounds = 3,
    }

    enum AnimationEventSource
    {
        NoSource = 0,
        Legacy = 1,
        Animator = 2,
    }

    class Animation : UnityEngine.Behaviour, System.Collections.IEnumerable
    {
        /*0x27e8f6c*/ Animation();
        /*0x27e7d5c*/ UnityEngine.AnimationClip get_clip();
        /*0x27e7d98*/ void set_clip(UnityEngine.AnimationClip value);
        /*0x27e7ddc*/ bool get_playAutomatically();
        /*0x27e7e18*/ void set_playAutomatically(bool value);
        /*0x27e7e5c*/ UnityEngine.WrapMode get_wrapMode();
        /*0x27e7e98*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x27e7edc*/ void Stop();
        /*0x27e7f18*/ void Stop(string name);
        /*0x27e7f5c*/ void StopNamed(string name);
        /*0x27e7fa0*/ void Rewind();
        /*0x27e7fdc*/ void Rewind(string name);
        /*0x27e8020*/ void RewindNamed(string name);
        /*0x27e8064*/ void Sample();
        /*0x27e80a0*/ bool get_isPlaying();
        /*0x27e80dc*/ bool IsPlaying(string name);
        /*0x27e8120*/ UnityEngine.AnimationState get_Item(string name);
        /*0x27e81a8*/ bool Play();
        /*0x27e81e8*/ bool Play(UnityEngine.PlayMode mode);
        /*0x27e822c*/ bool PlayDefaultAnimation(UnityEngine.PlayMode mode);
        /*0x27e8270*/ bool Play(string animation);
        /*0x27e82b8*/ bool Play(string animation, UnityEngine.PlayMode mode);
        /*0x27e830c*/ void CrossFade(string animation);
        /*0x27e835c*/ void CrossFade(string animation, float fadeLength);
        /*0x27e83b4*/ void CrossFade(string animation, float fadeLength, UnityEngine.PlayMode mode);
        /*0x27e8418*/ void Blend(string animation);
        /*0x27e8468*/ void Blend(string animation, float targetWeight);
        /*0x27e84c4*/ void Blend(string animation, float targetWeight, float fadeLength);
        /*0x27e8520*/ UnityEngine.AnimationState CrossFadeQueued(string animation);
        /*0x27e8574*/ UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength);
        /*0x27e85d0*/ UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue);
        /*0x27e8638*/ UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode);
        /*0x27e86a4*/ UnityEngine.AnimationState PlayQueued(string animation);
        /*0x27e86f0*/ UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue);
        /*0x27e8748*/ UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode);
        /*0x27e87a4*/ void AddClip(UnityEngine.AnimationClip clip, string newName);
        /*0x27e8804*/ void AddClip(UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame);
        /*0x27e8874*/ void AddClip(UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame);
        /*0x27e88e8*/ void RemoveClip(UnityEngine.AnimationClip clip);
        /*0x27e892c*/ void RemoveClip(string clipName);
        /*0x27e8970*/ void RemoveClipNamed(string clipName);
        /*0x27e89b4*/ int GetClipCount();
        /*0x27e89f0*/ bool Play(UnityEngine.AnimationPlayMode mode);
        /*0x27e8a34*/ bool Play(string animation, UnityEngine.AnimationPlayMode mode);
        /*0x27e8a88*/ void SyncLayer(int layer);
        /*0x27e8acc*/ System.Collections.IEnumerator GetEnumerator();
        /*0x27e8164*/ UnityEngine.AnimationState GetState(string name);
        /*0x27e8b68*/ UnityEngine.AnimationState GetStateAtIndex(int index);
        /*0x27e8bac*/ int GetStateCount();
        /*0x27e8be8*/ UnityEngine.AnimationClip GetClip(string name);
        /*0x27e8cb8*/ bool get_animatePhysics();
        /*0x27e8cf4*/ void set_animatePhysics(bool value);
        /*0x27e8d38*/ bool get_animateOnlyIfVisible();
        /*0x27e8d74*/ void set_animateOnlyIfVisible(bool value);
        /*0x27e8db8*/ UnityEngine.AnimationCullingType get_cullingType();
        /*0x27e8df4*/ void set_cullingType(UnityEngine.AnimationCullingType value);
        /*0x27e8e38*/ UnityEngine.Bounds get_localBounds();
        /*0x27e8ee4*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x27e8ea0*/ void get_localBounds_Injected(ref UnityEngine.Bounds ret);
        /*0x27e8f28*/ void set_localBounds_Injected(ref UnityEngine.Bounds value);

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Animation m_Outer;
            /*0x18*/ int m_CurrentIndex;

            /*0x27e8b38*/ Enumerator(UnityEngine.Animation outer);
            /*0x27e8f74*/ object get_Current();
            /*0x27e8fc0*/ bool MoveNext();
            /*0x27e9020*/ void Reset();
        }
    }

    class AnimationState : UnityEngine.TrackedReference
    {
        /*0x27e9670*/ AnimationState();
        /*0x27e902c*/ bool get_enabled();
        /*0x27e9068*/ void set_enabled(bool value);
        /*0x27e90ac*/ float get_weight();
        /*0x27e90e8*/ void set_weight(float value);
        /*0x27e9134*/ UnityEngine.WrapMode get_wrapMode();
        /*0x27e9170*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x27e91b4*/ float get_time();
        /*0x27e91f0*/ void set_time(float value);
        /*0x27e923c*/ float get_normalizedTime();
        /*0x27e9278*/ void set_normalizedTime(float value);
        /*0x27e92c4*/ float get_speed();
        /*0x27e9300*/ void set_speed(float value);
        /*0x27e934c*/ float get_normalizedSpeed();
        /*0x27e9388*/ void set_normalizedSpeed(float value);
        /*0x27e93d4*/ float get_length();
        /*0x27e9410*/ int get_layer();
        /*0x27e944c*/ void set_layer(int value);
        /*0x27e8c7c*/ UnityEngine.AnimationClip get_clip();
        /*0x27e9490*/ string get_name();
        /*0x27e94cc*/ void set_name(string value);
        /*0x27e9510*/ UnityEngine.AnimationBlendMode get_blendMode();
        /*0x27e954c*/ void set_blendMode(UnityEngine.AnimationBlendMode value);
        /*0x27e9590*/ void AddMixingTransform(UnityEngine.Transform mix);
        /*0x27e95d8*/ void AddMixingTransform(UnityEngine.Transform mix, bool recursive);
        /*0x27e962c*/ void RemoveMixingTransform(UnityEngine.Transform mix);
    }

    class AnimationEvent
    {
        /*0x10*/ float m_Time;
        /*0x18*/ string m_FunctionName;
        /*0x20*/ string m_StringParameter;
        /*0x28*/ UnityEngine.Object m_ObjectReferenceParameter;
        /*0x30*/ float m_FloatParameter;
        /*0x34*/ int m_IntParameter;
        /*0x38*/ int m_MessageOptions;
        /*0x3c*/ UnityEngine.AnimationEventSource m_Source;
        /*0x40*/ UnityEngine.AnimationState m_StateSender;
        /*0x48*/ UnityEngine.AnimatorStateInfo m_AnimatorStateInfo;
        /*0x6c*/ UnityEngine.AnimatorClipInfo m_AnimatorClipInfo;

        /*0x27e9678*/ AnimationEvent();
        /*0x27e96dc*/ string get_data();
        /*0x27e96e4*/ void set_data(string value);
        /*0x27e96ec*/ string get_stringParameter();
        /*0x27e96f4*/ void set_stringParameter(string value);
        /*0x27e96fc*/ float get_floatParameter();
        /*0x27e9704*/ void set_floatParameter(float value);
        /*0x27e970c*/ int get_intParameter();
        /*0x27e9714*/ void set_intParameter(int value);
        /*0x27e971c*/ UnityEngine.Object get_objectReferenceParameter();
        /*0x27e9724*/ void set_objectReferenceParameter(UnityEngine.Object value);
        /*0x27e972c*/ string get_functionName();
        /*0x27e9734*/ void set_functionName(string value);
        /*0x27e973c*/ float get_time();
        /*0x27e9744*/ void set_time(float value);
        /*0x27e974c*/ UnityEngine.SendMessageOptions get_messageOptions();
        /*0x27e9754*/ void set_messageOptions(UnityEngine.SendMessageOptions value);
        /*0x27e975c*/ bool get_isFiredByLegacy();
        /*0x27e976c*/ bool get_isFiredByAnimator();
        /*0x27e977c*/ UnityEngine.AnimationState get_animationState();
        /*0x27e97fc*/ UnityEngine.AnimatorStateInfo get_animatorStateInfo();
        /*0x27e9890*/ UnityEngine.AnimatorClipInfo get_animatorClipInfo();
        /*0x27e9910*/ int GetHash();
    }

    class Motion : UnityEngine.Object
    {
        /*0x18*/ bool <isAnimatorMotion>k__BackingField;

        /*0x27e9964*/ Motion();
        /*0x27e99bc*/ float get_averageDuration();
        /*0x27e99f8*/ float get_averageAngularSpeed();
        /*0x27e9a34*/ UnityEngine.Vector3 get_averageSpeed();
        /*0x27e9ad4*/ float get_apparentSpeed();
        /*0x27e9b10*/ bool get_isLooping();
        /*0x27e9b4c*/ bool get_legacy();
        /*0x27e9b88*/ bool get_isHumanMotion();
        /*0x27e9bc4*/ bool ValidateIfRetargetable(bool val);
        /*0x27e9bcc*/ bool get_isAnimatorMotion();
        /*0x27e9a90*/ void get_averageSpeed_Injected(ref UnityEngine.Vector3 ret);
    }

    class HumanTrait
    {
        static /*0x27e9bd4*/ int get_MuscleCount();
        static /*0x27e6cf8*/ int GetBoneIndexFromMono(int humanId);
        static /*0x27e9bfc*/ int GetBoneIndexToMono(int boneIndex);
        static /*0x27e9c38*/ string[] get_MuscleName();
        static /*0x27e9c60*/ int get_BoneCount();
        static /*0x27e9c88*/ string[] get_BoneName();
        static /*0x27e9cb0*/ int MuscleFromBone(int i, int dofIndex);
        static /*0x27e9d20*/ int Internal_MuscleFromBone(int i, int dofIndex);
        static /*0x27e9d64*/ int BoneFromMuscle(int i);
        static /*0x27e9dcc*/ int Internal_BoneFromMuscle(int i);
        static /*0x27e9e08*/ bool RequiredBone(int i);
        static /*0x27e9e70*/ bool Internal_RequiredBone(int i);
        static /*0x27e9eac*/ int get_RequiredBoneCount();
        static /*0x27e9ed4*/ float GetMuscleDefaultMin(int i);
        static /*0x27e9f10*/ float GetMuscleDefaultMax(int i);
        static /*0x27e9f4c*/ float GetBoneDefaultHierarchyMass(int i);
        static /*0x27e9ff0*/ int GetParentBone(int i);
        static /*0x27e9fb4*/ float Internal_GetBoneHierarchyMass(int i);
        static /*0x27ea098*/ int Internal_GetParent(int i);
        /*0x27ea0d4*/ HumanTrait();
    }

    enum AvatarTarget
    {
        Root = 0,
        Body = 1,
        LeftFoot = 2,
        RightFoot = 3,
        LeftHand = 4,
        RightHand = 5,
    }

    enum AvatarIKGoal
    {
        LeftFoot = 0,
        RightFoot = 1,
        LeftHand = 2,
        RightHand = 3,
    }

    enum AvatarIKHint
    {
        LeftKnee = 0,
        RightKnee = 1,
        LeftElbow = 2,
        RightElbow = 3,
    }

    enum AnimatorControllerParameterType
    {
        Float = 1,
        Int = 3,
        Bool = 4,
        Trigger = 9,
    }

    enum TransitionType
    {
        Normal = 1,
        Entry = 2,
        Exit = 4,
    }

    enum StateInfoIndex
    {
        CurrentState = 0,
        NextState = 1,
        ExitState = 2,
        InterruptedState = 3,
    }

    enum AnimatorRecorderMode
    {
        Offline = 0,
        Playback = 1,
        Record = 2,
    }

    enum DurationUnit
    {
        Fixed = 0,
        Normalized = 1,
    }

    enum AnimatorCullingMode
    {
        AlwaysAnimate = 0,
        CullUpdateTransforms = 1,
        CullCompletely = 2,
    }

    enum AnimatorUpdateMode
    {
        Normal = 0,
        AnimatePhysics = 1,
        UnscaledTime = 2,
    }

    struct AnimatorClipInfo
    {
        /*0x10*/ int m_ClipInstanceID;
        /*0x14*/ float m_Weight;

        static /*0x27ea12c*/ UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(int instanceID);
        /*0x27ea0dc*/ UnityEngine.AnimationClip get_clip();
        /*0x27ea168*/ float get_weight();
    }

    struct AnimatorStateInfo
    {
        /*0x10*/ int m_Name;
        /*0x14*/ int m_Path;
        /*0x18*/ int m_FullPath;
        /*0x1c*/ float m_NormalizedTime;
        /*0x20*/ float m_Length;
        /*0x24*/ float m_Speed;
        /*0x28*/ float m_SpeedMultiplier;
        /*0x2c*/ int m_Tag;
        /*0x30*/ int m_Loop;

        /*0x27ea170*/ bool IsName(string name);
        /*0x27ea1e0*/ int get_fullPathHash();
        /*0x27ea1e8*/ int get_nameHash();
        /*0x27ea1f0*/ int get_shortNameHash();
        /*0x27ea1f8*/ float get_normalizedTime();
        /*0x27ea200*/ float get_length();
        /*0x27ea208*/ float get_speed();
        /*0x27ea210*/ float get_speedMultiplier();
        /*0x27ea218*/ int get_tagHash();
        /*0x27ea220*/ bool IsTag(string tag);
        /*0x27ea270*/ bool get_loop();
    }

    struct AnimatorTransitionInfo
    {
        /*0x10*/ int m_FullPath;
        /*0x14*/ int m_UserName;
        /*0x18*/ int m_Name;
        /*0x1c*/ bool m_HasFixedDuration;
        /*0x20*/ float m_Duration;
        /*0x24*/ float m_NormalizedTime;
        /*0x28*/ bool m_AnyState;
        /*0x2c*/ int m_TransitionType;

        /*0x27ea280*/ bool IsName(string name);
        /*0x27ea308*/ bool IsUserName(string name);
        /*0x27ea358*/ int get_fullPathHash();
        /*0x27ea360*/ int get_nameHash();
        /*0x27ea368*/ int get_userNameHash();
        /*0x27ea370*/ UnityEngine.DurationUnit get_durationUnit();
        /*0x27ea37c*/ float get_duration();
        /*0x27ea384*/ float get_normalizedTime();
        /*0x27ea38c*/ bool get_anyState();
        /*0x27ea394*/ bool get_entry();
        /*0x27ea3a0*/ bool get_exit();
    }

    struct MatchTargetWeightMask
    {
        /*0x10*/ UnityEngine.Vector3 m_PositionXYZWeight;
        /*0x1c*/ float m_RotationWeight;

        /*0x27ea3ac*/ MatchTargetWeightMask(UnityEngine.Vector3 positionXYZWeight, float rotationWeight);
        /*0x27ea3b8*/ UnityEngine.Vector3 get_positionXYZWeight();
        /*0x27ea3c4*/ void set_positionXYZWeight(UnityEngine.Vector3 value);
        /*0x27ea3d0*/ float get_rotationWeight();
        /*0x27ea3d8*/ void set_rotationWeight(float value);
    }

    class Animator : UnityEngine.Behaviour
    {
        static T[] ConvertStateMachineBehaviour<T>(UnityEngine.ScriptableObject[] rawObjects);
        static /*0x27e7b54*/ int StringToHash(string name);
        /*0x27ef628*/ Animator();
        /*0x27ea3e0*/ bool get_isOptimizable();
        /*0x27ea41c*/ bool get_isHuman();
        /*0x27ea458*/ bool get_hasRootMotion();
        /*0x27ea494*/ bool get_isRootPositionOrRotationControlledByCurves();
        /*0x27ea4d0*/ float get_humanScale();
        /*0x27ea50c*/ bool get_isInitialized();
        /*0x27ea548*/ float GetFloat(string name);
        /*0x27ea5d0*/ float GetFloat(int id);
        /*0x27ea658*/ void SetFloat(string name, float value);
        /*0x27ea700*/ void SetFloat(string name, float value, float dampTime, float deltaTime);
        /*0x27ea7d8*/ void SetFloat(int id, float value);
        /*0x27ea880*/ void SetFloat(int id, float value, float dampTime, float deltaTime);
        /*0x27ea958*/ bool GetBool(string name);
        /*0x27ea9e0*/ bool GetBool(int id);
        /*0x27eaa68*/ void SetBool(string name, bool value);
        /*0x27eab10*/ void SetBool(int id, bool value);
        /*0x27eabb8*/ int GetInteger(string name);
        /*0x27eac40*/ int GetInteger(int id);
        /*0x27eacc8*/ void SetInteger(string name, int value);
        /*0x27ead70*/ void SetInteger(int id, int value);
        /*0x27eae18*/ void SetTrigger(string name);
        /*0x27eaea0*/ void SetTrigger(int id);
        /*0x27eaf28*/ void ResetTrigger(string name);
        /*0x27eafb0*/ void ResetTrigger(int id);
        /*0x27eb038*/ bool IsParameterControlledByCurve(string name);
        /*0x27eb0c0*/ bool IsParameterControlledByCurve(int id);
        /*0x27eb148*/ UnityEngine.Vector3 get_deltaPosition();
        /*0x27eb1e8*/ UnityEngine.Quaternion get_deltaRotation();
        /*0x27eb284*/ UnityEngine.Vector3 get_velocity();
        /*0x27eb324*/ UnityEngine.Vector3 get_angularVelocity();
        /*0x27eb3c4*/ UnityEngine.Vector3 get_rootPosition();
        /*0x27eb464*/ void set_rootPosition(UnityEngine.Vector3 value);
        /*0x27eb4fc*/ UnityEngine.Quaternion get_rootRotation();
        /*0x27eb598*/ void set_rootRotation(UnityEngine.Quaternion value);
        /*0x27eb630*/ bool get_applyRootMotion();
        /*0x27eb66c*/ void set_applyRootMotion(bool value);
        /*0x27eb6b0*/ bool get_linearVelocityBlending();
        /*0x27eb6ec*/ void set_linearVelocityBlending(bool value);
        /*0x27eb730*/ bool get_animatePhysics();
        /*0x27eb7b4*/ void set_animatePhysics(bool value);
        /*0x27eb778*/ UnityEngine.AnimatorUpdateMode get_updateMode();
        /*0x27eb800*/ void set_updateMode(UnityEngine.AnimatorUpdateMode value);
        /*0x27eb844*/ bool get_hasTransformHierarchy();
        /*0x27eb880*/ bool get_allowConstantClipSamplingOptimization();
        /*0x27eb8bc*/ void set_allowConstantClipSamplingOptimization(bool value);
        /*0x27eb900*/ float get_gravityWeight();
        /*0x27eb93c*/ UnityEngine.Vector3 get_bodyPosition();
        /*0x27eba80*/ void set_bodyPosition(UnityEngine.Vector3 value);
        /*0x27eba24*/ UnityEngine.Vector3 get_bodyPositionInternal();
        /*0x27ebac0*/ void set_bodyPositionInternal(UnityEngine.Vector3 value);
        /*0x27ebb9c*/ UnityEngine.Quaternion get_bodyRotation();
        /*0x27ebc0c*/ void set_bodyRotation(UnityEngine.Quaternion value);
        /*0x27ebbb4*/ UnityEngine.Quaternion get_bodyRotationInternal();
        /*0x27ebc54*/ void set_bodyRotationInternal(UnityEngine.Quaternion value);
        /*0x27ebd30*/ UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal);
        /*0x27ebd58*/ UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal);
        /*0x27ebe10*/ void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x27ebe60*/ void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x27ebf10*/ UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal);
        /*0x27ebf38*/ UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal);
        /*0x27ebfec*/ void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x27ec044*/ void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x27ec0f4*/ float GetIKPositionWeight(UnityEngine.AvatarIKGoal goal);
        /*0x27ec13c*/ float GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal);
        /*0x27ec180*/ void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x27ec1d8*/ void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, float value);
        /*0x27ec22c*/ float GetIKRotationWeight(UnityEngine.AvatarIKGoal goal);
        /*0x27ec274*/ float GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal);
        /*0x27ec2b8*/ void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x27ec310*/ void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, float value);
        /*0x27ec364*/ UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x27ec38c*/ UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x27ec444*/ void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x27ec494*/ void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x27ec544*/ float GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint);
        /*0x27ec58c*/ float GetHintWeightPosition(UnityEngine.AvatarIKHint hint);
        /*0x27ec5d0*/ void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, float value);
        /*0x27ec628*/ void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, float value);
        /*0x27ec67c*/ void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition);
        /*0x27ec6bc*/ void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition);
        /*0x27ec754*/ void SetLookAtWeight(float weight);
        /*0x27ec830*/ void SetLookAtWeight(float weight, float bodyWeight);
        /*0x27ec894*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
        /*0x27ec904*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
        /*0x27ec978*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x27ec7b4*/ void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x27ec9f8*/ void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation);
        /*0x27eca78*/ void SetBoneLocalRotationInternal(int humanBoneId, UnityEngine.Quaternion rotation);
        /*0x27ecb28*/ UnityEngine.ScriptableObject GetBehaviour(System.Type type);
        T GetBehaviour<T>();
        T[] GetBehaviours<T>();
        /*0x27ecb6c*/ UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type);
        /*0x27ecbb0*/ UnityEngine.StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex);
        /*0x27ecc8c*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, System.Type type);
        /*0x27ecce8*/ bool get_stabilizeFeet();
        /*0x27ecd24*/ void set_stabilizeFeet(bool value);
        /*0x27ecd68*/ int get_layerCount();
        /*0x27ecda4*/ string GetLayerName(int layerIndex);
        /*0x27ecde8*/ int GetLayerIndex(string layerName);
        /*0x27ece2c*/ float GetLayerWeight(int layerIndex);
        /*0x27ece70*/ void SetLayerWeight(int layerIndex, float weight);
        /*0x27ecec4*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x27ecf20*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x27ecfa0*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        /*0x27ed020*/ void GetAnimatorTransitionInfo(int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        /*0x27ed074*/ UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
        /*0x27ed0e4*/ int GetAnimatorClipInfoCount(int layerIndex, bool current);
        /*0x27ed138*/ int GetCurrentAnimatorClipInfoCount(int layerIndex);
        /*0x27ed180*/ int GetNextAnimatorClipInfoCount(int layerIndex);
        /*0x27ed1c8*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        /*0x27ed20c*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
        /*0x27ed250*/ void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x27ed2f8*/ void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);
        /*0x27ed354*/ void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x27ed3fc*/ bool IsInTransition(int layerIndex);
        /*0x27ed440*/ UnityEngine.AnimatorControllerParameter[] get_parameters();
        /*0x27ed47c*/ int get_parameterCount();
        /*0x27ed4b8*/ UnityEngine.AnimatorControllerParameter GetParameter(int index);
        /*0x27ed5e8*/ float get_feetPivotActive();
        /*0x27ed624*/ void set_feetPivotActive(float value);
        /*0x27ed670*/ float get_pivotWeight();
        /*0x27ed6ac*/ UnityEngine.Vector3 get_pivotPosition();
        /*0x27ed74c*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, int targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x27ed874*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime);
        /*0x27ed8a8*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);
        /*0x27ed8c8*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x27ed8e8*/ void InterruptMatchTarget();
        /*0x27ed928*/ void InterruptMatchTarget(bool completeMatch);
        /*0x27ed96c*/ bool get_isMatchingTarget();
        /*0x27ed9a8*/ float get_speed();
        /*0x27ed9e4*/ void set_speed(float value);
        /*0x27eda30*/ void ForceStateNormalizedTime(float normalizedTime);
        /*0x27edae8*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration);
        /*0x27edbf0*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer);
        /*0x27edc88*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x27edd24*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x27eddcc*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x27ede3c*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer);
        /*0x27edea8*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration);
        /*0x27edb74*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x27edf08*/ void WriteDefaultValues();
        /*0x27edf44*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x27edff4*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer);
        /*0x27ee004*/ void CrossFade(string stateName, float normalizedTransitionDuration);
        /*0x27edf4c*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x27ee018*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x27ee094*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x27ee104*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer);
        /*0x27ee174*/ void CrossFade(int stateHashName, float normalizedTransitionDuration);
        /*0x27ee1d8*/ void PlayInFixedTime(string stateName, int layer);
        /*0x27ee274*/ void PlayInFixedTime(string stateName);
        /*0x27ee1e4*/ void PlayInFixedTime(string stateName, int layer, float fixedTime);
        /*0x27ee284*/ void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
        /*0x27ee2e8*/ void PlayInFixedTime(int stateNameHash, int layer);
        /*0x27ee344*/ void PlayInFixedTime(int stateNameHash);
        /*0x27ee394*/ void Play(string stateName, int layer);
        /*0x27ee430*/ void Play(string stateName);
        /*0x27ee3a0*/ void Play(string stateName, int layer, float normalizedTime);
        /*0x27eda84*/ void Play(int stateNameHash, int layer, float normalizedTime);
        /*0x27ee440*/ void Play(int stateNameHash, int layer);
        /*0x27ee49c*/ void Play(int stateNameHash);
        /*0x27ee4ec*/ void SetTarget(UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        /*0x27ee540*/ UnityEngine.Vector3 get_targetPosition();
        /*0x27ee5e0*/ UnityEngine.Quaternion get_targetRotation();
        /*0x27ee67c*/ bool IsControlled(UnityEngine.Transform transform);
        /*0x27ee684*/ bool IsBoneTransform(UnityEngine.Transform transform);
        /*0x27ee6c8*/ UnityEngine.Transform get_avatarRoot();
        /*0x27ee704*/ UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId);
        /*0x27ee80c*/ UnityEngine.Transform GetBoneTransformInternal(int humanBoneId);
        /*0x27ee850*/ UnityEngine.AnimatorCullingMode get_cullingMode();
        /*0x27ee88c*/ void set_cullingMode(UnityEngine.AnimatorCullingMode value);
        /*0x27ee8d0*/ void StartPlayback();
        /*0x27ee90c*/ void StopPlayback();
        /*0x27ee948*/ float get_playbackTime();
        /*0x27ee984*/ void set_playbackTime(float value);
        /*0x27ee9d0*/ void StartRecording(int frameCount);
        /*0x27eea14*/ void StopRecording();
        /*0x27eea50*/ float get_recorderStartTime();
        /*0x27eeac8*/ void set_recorderStartTime(float value);
        /*0x27eea8c*/ float GetRecorderStartTime();
        /*0x27eeacc*/ float get_recorderStopTime();
        /*0x27eeb44*/ void set_recorderStopTime(float value);
        /*0x27eeb08*/ float GetRecorderStopTime();
        /*0x27eeb48*/ UnityEngine.AnimatorRecorderMode get_recorderMode();
        /*0x27eeb84*/ UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController();
        /*0x27eebc0*/ void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value);
        /*0x27eec04*/ bool get_hasBoundPlayables();
        /*0x27eec40*/ void ClearInternalControllerPlayable();
        /*0x27eec7c*/ bool HasState(int layerIndex, int stateID);
        /*0x27eecd0*/ UnityEngine.Avatar get_avatar();
        /*0x27eed0c*/ void set_avatar(UnityEngine.Avatar value);
        /*0x27eed50*/ string GetStats();
        /*0x27eed8c*/ UnityEngine.Playables.PlayableGraph get_playableGraph();
        /*0x27eede0*/ void GetCurrentGraph(ref UnityEngine.Playables.PlayableGraph graph);
        /*0x27eb954*/ void CheckIfInIKPass();
        /*0x27eee60*/ bool IsInIKPass();
        /*0x27ea6ac*/ void SetFloatString(string name, float value);
        /*0x27ea82c*/ void SetFloatID(int id, float value);
        /*0x27ea58c*/ float GetFloatString(string name);
        /*0x27ea614*/ float GetFloatID(int id);
        /*0x27eaabc*/ void SetBoolString(string name, bool value);
        /*0x27eab64*/ void SetBoolID(int id, bool value);
        /*0x27ea99c*/ bool GetBoolString(string name);
        /*0x27eaa24*/ bool GetBoolID(int id);
        /*0x27ead1c*/ void SetIntegerString(string name, int value);
        /*0x27eadc4*/ void SetIntegerID(int id, int value);
        /*0x27eabfc*/ int GetIntegerString(string name);
        /*0x27eac84*/ int GetIntegerID(int id);
        /*0x27eae5c*/ void SetTriggerString(string name);
        /*0x27eaee4*/ void SetTriggerID(int id);
        /*0x27eaf6c*/ void ResetTriggerString(string name);
        /*0x27eaff4*/ void ResetTriggerID(int id);
        /*0x27eb07c*/ bool IsParameterControlledByCurveString(string name);
        /*0x27eb104*/ bool IsParameterControlledByCurveID(int id);
        /*0x27ea76c*/ void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);
        /*0x27ea8ec*/ void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);
        /*0x27eee9c*/ bool get_layersAffectMassCenter();
        /*0x27eeed8*/ void set_layersAffectMassCenter(bool value);
        /*0x27eef1c*/ float get_leftFeetBottomHeight();
        /*0x27eef58*/ float get_rightFeetBottomHeight();
        /*0x27eef94*/ bool get_supportsOnAnimatorMove();
        /*0x27eefd0*/ void OnUpdateModeChanged();
        /*0x27ef00c*/ void OnCullingModeChanged();
        /*0x27ef048*/ void WriteDefaultPose();
        /*0x27ef084*/ void Update(float deltaTime);
        /*0x27ef0d0*/ void Rebind();
        /*0x27ef110*/ void Rebind(bool writeDefaultValues);
        /*0x27ef154*/ void ApplyBuiltinRootMotion();
        /*0x27ef190*/ void EvaluateController();
        /*0x27ef1d0*/ void EvaluateController(float deltaTime);
        /*0x27ef21c*/ string GetCurrentStateName(int layerIndex);
        /*0x27ef2b8*/ string GetNextStateName(int layerIndex);
        /*0x27ef264*/ string GetAnimatorStateName(int layerIndex, bool current);
        /*0x27ef300*/ string ResolveHash(int hash);
        /*0x27eee24*/ bool get_logWarnings();
        /*0x27ef344*/ void set_logWarnings(bool value);
        /*0x27ef388*/ bool get_fireEvents();
        /*0x27ef3c4*/ void set_fireEvents(bool value);
        /*0x27ef408*/ bool get_keepAnimatorControllerStateOnDisable();
        /*0x27ef480*/ void set_keepAnimatorControllerStateOnDisable(bool value);
        /*0x27ef444*/ bool get_keepAnimatorStateOnDisable();
        /*0x27ef4c4*/ void set_keepAnimatorStateOnDisable(bool value);
        /*0x27ef508*/ UnityEngine.Vector3 GetVector(string name);
        /*0x27ef54c*/ UnityEngine.Vector3 GetVector(int id);
        /*0x27ef590*/ void SetVector(string name, UnityEngine.Vector3 value);
        /*0x27ef594*/ void SetVector(int id, UnityEngine.Vector3 value);
        /*0x27ef598*/ UnityEngine.Quaternion GetQuaternion(string name);
        /*0x27ef5dc*/ UnityEngine.Quaternion GetQuaternion(int id);
        /*0x27ef620*/ void SetQuaternion(string name, UnityEngine.Quaternion value);
        /*0x27ef624*/ void SetQuaternion(int id, UnityEngine.Quaternion value);
        /*0x27eb1a4*/ void get_deltaPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x27eb240*/ void get_deltaRotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x27eb2e0*/ void get_velocity_Injected(ref UnityEngine.Vector3 ret);
        /*0x27eb380*/ void get_angularVelocity_Injected(ref UnityEngine.Vector3 ret);
        /*0x27eb420*/ void get_rootPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x27eb4b8*/ void set_rootPosition_Injected(ref UnityEngine.Vector3 value);
        /*0x27eb554*/ void get_rootRotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x27eb5ec*/ void set_rootRotation_Injected(ref UnityEngine.Quaternion value);
        /*0x27ebb14*/ void get_bodyPositionInternal_Injected(ref UnityEngine.Vector3 ret);
        /*0x27ebb58*/ void set_bodyPositionInternal_Injected(ref UnityEngine.Vector3 value);
        /*0x27ebca8*/ void get_bodyRotationInternal_Injected(ref UnityEngine.Quaternion ret);
        /*0x27ebcec*/ void set_bodyRotationInternal_Injected(ref UnityEngine.Quaternion value);
        /*0x27ebdbc*/ void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 ret);
        /*0x27ebebc*/ void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 goalPosition);
        /*0x27ebf98*/ void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion ret);
        /*0x27ec0a0*/ void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion goalRotation);
        /*0x27ec3f0*/ void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 ret);
        /*0x27ec4f0*/ void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 hintPosition);
        /*0x27ec710*/ void SetLookAtPositionInternal_Injected(ref UnityEngine.Vector3 lookAtPosition);
        /*0x27ecad4*/ void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref UnityEngine.Quaternion rotation);
        /*0x27ed708*/ void get_pivotPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x27ed7e8*/ void MatchTarget_Injected(ref UnityEngine.Vector3 matchPosition, ref UnityEngine.Quaternion matchRotation, int targetBodyPart, ref UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x27ee59c*/ void get_targetPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x27ee638*/ void get_targetRotation_Injected(ref UnityEngine.Quaternion ret);
    }

    class AnimationClip : UnityEngine.Motion
    {
        static /*0x27ef670*/ void Internal_CreateAnimationClip(UnityEngine.AnimationClip self);
        static /*0x27ef774*/ void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode);
        /*0x27ef630*/ AnimationClip();
        /*0x27ef6ac*/ void SampleAnimation(UnityEngine.GameObject go, float time);
        /*0x27ef7d8*/ float get_length();
        /*0x27ef814*/ float get_startTime();
        /*0x27ef850*/ float get_stopTime();
        /*0x27ef88c*/ float get_frameRate();
        /*0x27ef8c8*/ void set_frameRate(float value);
        /*0x27ef914*/ void SetCurve(string relativePath, System.Type type, string propertyName, UnityEngine.AnimationCurve curve);
        /*0x27ef980*/ void EnsureQuaternionContinuity();
        /*0x27ef9bc*/ void ClearCurves();
        /*0x27ef738*/ UnityEngine.WrapMode get_wrapMode();
        /*0x27ef9f8*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x27efa3c*/ UnityEngine.Bounds get_localBounds();
        /*0x27efae8*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x27efb70*/ bool get_legacy();
        /*0x27efbac*/ void set_legacy(bool value);
        /*0x27efbf0*/ bool get_humanMotion();
        /*0x27efc2c*/ bool get_empty();
        /*0x27efc68*/ bool get_hasGenericRootTransform();
        /*0x27efca4*/ bool get_hasMotionFloatCurves();
        /*0x27efce0*/ bool get_hasMotionCurves();
        /*0x27efd1c*/ bool get_hasRootCurves();
        /*0x27efd58*/ bool get_hasRootMotion();
        /*0x27efd94*/ void AddEvent(UnityEngine.AnimationEvent evt);
        /*0x27efe28*/ void AddEventInternal(object evt);
        /*0x27efe6c*/ UnityEngine.AnimationEvent[] get_events();
        /*0x27eff34*/ void set_events(UnityEngine.AnimationEvent[] value);
        /*0x27eff78*/ void SetEventsInternal(System.Array value);
        /*0x27efef8*/ System.Array GetEventsInternal();
        /*0x27efaa4*/ void get_localBounds_Injected(ref UnityEngine.Bounds ret);
        /*0x27efb2c*/ void set_localBounds_Injected(ref UnityEngine.Bounds value);
    }

    struct HumanPose
    {
        /*0x10*/ UnityEngine.Vector3 bodyPosition;
        /*0x1c*/ UnityEngine.Quaternion bodyRotation;
        /*0x30*/ float[] muscles;

        /*0x27effbc*/ void Init();
    }

    class HumanPoseHandler : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x27f00f4*/ nint Internal_CreateFromRoot(UnityEngine.Avatar avatar, UnityEngine.Transform root);
        static /*0x27f0138*/ nint Internal_CreateFromJointPaths(UnityEngine.Avatar avatar, string[] jointPaths);
        static /*0x27f017c*/ void Internal_Destroy(nint ptr);
        /*0x27f049c*/ HumanPoseHandler(UnityEngine.Avatar avatar, UnityEngine.Transform root);
        /*0x27f06c8*/ HumanPoseHandler(UnityEngine.Avatar avatar, string[] jointPaths);
        /*0x27f01b8*/ void GetHumanPose(ref UnityEngine.Vector3 bodyPosition, ref UnityEngine.Quaternion bodyRotation, float[] muscles);
        /*0x27f0214*/ void SetHumanPose(ref UnityEngine.Vector3 bodyPosition, ref UnityEngine.Quaternion bodyRotation, float[] muscles);
        /*0x27f0270*/ void GetInternalHumanPose(ref UnityEngine.Vector3 bodyPosition, ref UnityEngine.Quaternion bodyRotation, float[] muscles);
        /*0x27f02cc*/ void SetInternalHumanPose(ref UnityEngine.Vector3 bodyPosition, ref UnityEngine.Quaternion bodyRotation, float[] muscles);
        /*0x27f0328*/ void GetInternalAvatarPose(void* avatarPose, int avatarPoseLength);
        /*0x27f037c*/ void SetInternalAvatarPose(void* avatarPose, int avatarPoseLength);
        /*0x27f03d0*/ void Dispose();
        /*0x27f08cc*/ void GetHumanPose(ref UnityEngine.HumanPose humanPose);
        /*0x27f09c0*/ void SetHumanPose(ref UnityEngine.HumanPose humanPose);
        /*0x27f0ab4*/ void GetInternalHumanPose(ref UnityEngine.HumanPose humanPose);
        /*0x27f0ba8*/ void SetInternalHumanPose(ref UnityEngine.HumanPose humanPose);
        /*0x27f0c9c*/ void GetInternalAvatarPose(Unity.Collections.NativeArray<float> avatarPose);
        /*0x27f0da8*/ void SetInternalAvatarPose(Unity.Collections.NativeArray<float> avatarPose);
    }

    class SharedBetweenAnimatorsAttribute : System.Attribute
    {
        /*0x27f0eb4*/ SharedBetweenAnimatorsAttribute();
    }

    class StateMachineBehaviour : UnityEngine.ScriptableObject
    {
        /*0x27f0ef4*/ StateMachineBehaviour();
        /*0x27f0ebc*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x27f0ec0*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x27f0ec4*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x27f0ec8*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x27f0ecc*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x27f0ed0*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x27f0ed4*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x27f0ed8*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x27f0edc*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x27f0ee0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x27f0ee4*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x27f0ee8*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x27f0eec*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x27f0ef0*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
    }

    interface IAnimationClipSource
    {
        void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results);
    }

    namespace Playables
    {
        class AnimationPlayableUtilities
        {
            static /*0x27f0efc*/ void Play(UnityEngine.Animator animator, UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableGraph graph);
            static /*0x27f10c0*/ UnityEngine.Animations.AnimationClipPlayable PlayClip(UnityEngine.Animator animator, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableGraph graph);
            static /*0x27f11d4*/ UnityEngine.Animations.AnimationMixerPlayable PlayMixer(UnityEngine.Animator animator, int inputCount, ref UnityEngine.Playables.PlayableGraph graph);
            static /*0x27f1378*/ UnityEngine.Animations.AnimationLayerMixerPlayable PlayLayerMixer(UnityEngine.Animator animator, int inputCount, ref UnityEngine.Playables.PlayableGraph graph);
            static /*0x27f14f4*/ UnityEngine.Animations.AnimatorControllerPlayable PlayAnimatorController(UnityEngine.Animator animator, UnityEngine.RuntimeAnimatorController controller, ref UnityEngine.Playables.PlayableGraph graph);
        }
    }

    namespace Experimental
    {
        namespace Animations
        {
            enum AnimationStreamSource
            {
                DefaultValues = 0,
                PreviousInputs = 1,
            }

            class AnimationPlayableOutputExtensions
            {
                static /*0x27f1698*/ UnityEngine.Experimental.Animations.AnimationStreamSource GetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output);
                static /*0x27f16e8*/ void SetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource);
                static /*0x27f173c*/ ushort GetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output);
                static /*0x27f178c*/ void SetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output, ushort sortingOrder);
                static /*0x27f16a8*/ UnityEngine.Experimental.Animations.AnimationStreamSource InternalGetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output);
                static /*0x27f16ec*/ void InternalSetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource);
                static /*0x27f174c*/ int InternalGetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output);
                static /*0x27f1794*/ void InternalSetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output, int sortingOrder);
                static /*0x27f17e4*/ UnityEngine.Experimental.Animations.AnimationStreamSource InternalGetAnimationStreamSource_Injected(ref UnityEngine.Playables.PlayableOutputHandle output);
                static /*0x27f1820*/ void InternalSetAnimationStreamSource_Injected(ref UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource);
                static /*0x27f1864*/ int InternalGetSortingOrder_Injected(ref UnityEngine.Playables.PlayableOutputHandle output);
                static /*0x27f18a0*/ void InternalSetSortingOrder_Injected(ref UnityEngine.Playables.PlayableOutputHandle output, int sortingOrder);
            }
        }
    }

    namespace Animations
    {
        struct AnimationRemoveScalePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x27f1d74*/ AnimationRemoveScalePlayable();
            static /*0x27f18e4*/ UnityEngine.Animations.AnimationRemoveScalePlayable get_Null();
            static /*0x27f193c*/ UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x27f19d4*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x27f1c10*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable);
            static /*0x27f1c40*/ UnityEngine.Animations.AnimationRemoveScalePlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x27f1b78*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f1d30*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x27f1ab8*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x27f1c04*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x27f1c84*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimatorControllerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimatorControllerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x27f5620*/ AnimatorControllerPlayable();
            static /*0x27f1e10*/ UnityEngine.Animations.AnimatorControllerPlayable get_Null();
            static /*0x27f1600*/ UnityEngine.Animations.AnimatorControllerPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller);
            static /*0x27f1e68*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller);
            static /*0x27f2168*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimatorControllerPlayable playable);
            static /*0x27f2198*/ UnityEngine.Animations.AnimatorControllerPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x27f3a5c*/ void GetAnimatorClipInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, bool isCurrent, object clips);
            static /*0x27f1fb8*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f54e8*/ UnityEngine.RuntimeAnimatorController GetAnimatorControllerInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f3178*/ int GetLayerCountInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f3238*/ string GetLayerNameInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f3300*/ int GetLayerIndexInternal(ref UnityEngine.Playables.PlayableHandle handle, string layerName);
            static /*0x27f33c8*/ float GetLayerWeightInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f34a0*/ void SetLayerWeightInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, float weight);
            static /*0x27f3588*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f36d0*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f380c*/ UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f3938*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f3c20*/ int GetAnimatorClipInfoCountInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, bool current);
            static /*0x27f3d80*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f5450*/ string ResolveHashInternal(ref UnityEngine.Playables.PlayableHandle handle, int hash);
            static /*0x27f3e48*/ bool IsInTransitionInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex);
            static /*0x27f4034*/ UnityEngine.AnimatorControllerParameter[] GetParametersArrayInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f3f00*/ int GetParameterCountInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f4138*/ int StringToHash(string name);
            static /*0x27f4174*/ void CrossFadeInFixedTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime);
            static /*0x27f4628*/ void CrossFadeInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime);
            static /*0x27f4ad8*/ void PlayInFixedTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, int layer, float fixedTime);
            static /*0x27f4f40*/ void PlayInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, int layer, float normalizedTime);
            static /*0x27f5378*/ bool HasStateInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, int stateID);
            static /*0x27f2478*/ void SetFloatString(ref UnityEngine.Playables.PlayableHandle handle, string name, float value);
            static /*0x27f2560*/ void SetFloatID(ref UnityEngine.Playables.PlayableHandle handle, int id, float value);
            static /*0x27f22d8*/ float GetFloatString(ref UnityEngine.Playables.PlayableHandle handle, string name);
            static /*0x27f23a0*/ float GetFloatID(ref UnityEngine.Playables.PlayableHandle handle, int id);
            static /*0x27f27d0*/ void SetBoolString(ref UnityEngine.Playables.PlayableHandle handle, string name, bool value);
            static /*0x27f28b0*/ void SetBoolID(ref UnityEngine.Playables.PlayableHandle handle, int id, bool value);
            static /*0x27f2638*/ bool GetBoolString(ref UnityEngine.Playables.PlayableHandle handle, string name);
            static /*0x27f2700*/ bool GetBoolID(ref UnityEngine.Playables.PlayableHandle handle, int id);
            static /*0x27f2b20*/ void SetIntegerString(ref UnityEngine.Playables.PlayableHandle handle, string name, int value);
            static /*0x27f2c00*/ void SetIntegerID(ref UnityEngine.Playables.PlayableHandle handle, int id, int value);
            static /*0x27f2988*/ int GetIntegerString(ref UnityEngine.Playables.PlayableHandle handle, string name);
            static /*0x27f2a50*/ int GetIntegerID(ref UnityEngine.Playables.PlayableHandle handle, int id);
            static /*0x27f2cd8*/ void SetTriggerString(ref UnityEngine.Playables.PlayableHandle handle, string name);
            static /*0x27f2da0*/ void SetTriggerID(ref UnityEngine.Playables.PlayableHandle handle, int id);
            static /*0x27f2e68*/ void ResetTriggerString(ref UnityEngine.Playables.PlayableHandle handle, string name);
            static /*0x27f2f30*/ void ResetTriggerID(ref UnityEngine.Playables.PlayableHandle handle, int id);
            static /*0x27f2ff8*/ bool IsParameterControlledByCurveString(ref UnityEngine.Playables.PlayableHandle handle, string name);
            static /*0x27f30c0*/ bool IsParameterControlledByCurveID(ref UnityEngine.Playables.PlayableHandle handle, int id);
            static /*0x27f5494*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f5524*/ void GetCurrentAnimatorStateInfoInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, ref UnityEngine.AnimatorStateInfo ret);
            static /*0x27f5578*/ void GetNextAnimatorStateInfoInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, ref UnityEngine.AnimatorStateInfo ret);
            static /*0x27f55cc*/ void GetAnimatorTransitionInfoInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, ref UnityEngine.AnimatorTransitionInfo ret);
            /*0x27f1f40*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x27f215c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x27f2054*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0x27f21dc*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
            /*0x27f2254*/ float GetFloat(string name);
            /*0x27f231c*/ float GetFloat(int id);
            /*0x27f23e4*/ void SetFloat(string name, float value);
            /*0x27f24cc*/ void SetFloat(int id, float value);
            /*0x27f25b4*/ bool GetBool(string name);
            /*0x27f267c*/ bool GetBool(int id);
            /*0x27f2744*/ void SetBool(string name, bool value);
            /*0x27f2824*/ void SetBool(int id, bool value);
            /*0x27f2904*/ int GetInteger(string name);
            /*0x27f29cc*/ int GetInteger(int id);
            /*0x27f2a94*/ void SetInteger(string name, int value);
            /*0x27f2b74*/ void SetInteger(int id, int value);
            /*0x27f2c54*/ void SetTrigger(string name);
            /*0x27f2d1c*/ void SetTrigger(int id);
            /*0x27f2de4*/ void ResetTrigger(string name);
            /*0x27f2eac*/ void ResetTrigger(int id);
            /*0x27f2f74*/ bool IsParameterControlledByCurve(string name);
            /*0x27f303c*/ bool IsParameterControlledByCurve(int id);
            /*0x27f3104*/ int GetLayerCount();
            /*0x27f31b4*/ string GetLayerName(int layerIndex);
            /*0x27f327c*/ int GetLayerIndex(string layerName);
            /*0x27f3344*/ float GetLayerWeight(int layerIndex);
            /*0x27f340c*/ void SetLayerWeight(int layerIndex, float weight);
            /*0x27f34f4*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
            /*0x27f363c*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
            /*0x27f3784*/ UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
            /*0x27f38b4*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
            /*0x27f397c*/ void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
            /*0x27f3ab8*/ void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
            /*0x27f3b98*/ int GetCurrentAnimatorClipInfoCount(int layerIndex);
            /*0x27f3c74*/ int GetNextAnimatorClipInfoCount(int layerIndex);
            /*0x27f3cfc*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
            /*0x27f3dc4*/ bool IsInTransition(int layerIndex);
            /*0x27f3e8c*/ int GetParameterCount();
            /*0x27f3f3c*/ UnityEngine.AnimatorControllerParameter GetParameter(int index);
            /*0x27f4070*/ void CrossFadeInFixedTime(string stateName, float transitionDuration);
            /*0x27f41e0*/ void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer);
            /*0x27f42ac*/ void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime);
            /*0x27f437c*/ void CrossFadeInFixedTime(int stateNameHash, float transitionDuration);
            /*0x27f4418*/ void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer);
            /*0x27f44b8*/ void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime);
            /*0x27f455c*/ void CrossFade(string stateName, float transitionDuration);
            /*0x27f4694*/ void CrossFade(string stateName, float transitionDuration, int layer);
            /*0x27f4764*/ void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime);
            /*0x27f4834*/ void CrossFade(int stateNameHash, float transitionDuration);
            /*0x27f48d4*/ void CrossFade(int stateNameHash, float transitionDuration, int layer);
            /*0x27f4978*/ void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime);
            /*0x27f4a1c*/ void PlayInFixedTime(string stateName);
            /*0x27f4b3c*/ void PlayInFixedTime(string stateName, int layer);
            /*0x27f4bfc*/ void PlayInFixedTime(string stateName, int layer, float fixedTime);
            /*0x27f4cc4*/ void PlayInFixedTime(int stateNameHash);
            /*0x27f4d54*/ void PlayInFixedTime(int stateNameHash, int layer);
            /*0x27f4de8*/ void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
            /*0x27f4e84*/ void Play(string stateName);
            /*0x27f4fa4*/ void Play(string stateName, int layer);
            /*0x27f5064*/ void Play(string stateName, int layer, float normalizedTime);
            /*0x27f512c*/ void Play(int stateNameHash);
            /*0x27f51bc*/ void Play(int stateNameHash, int layer);
            /*0x27f5250*/ void Play(int stateNameHash, int layer, float normalizedTime);
            /*0x27f52ec*/ bool HasState(int layerIndex, int stateID);
            /*0x27f53cc*/ string ResolveHash(int hash);
        }

        struct AnimationOffsetPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x27f6120*/ AnimationOffsetPlayable();
            static /*0x27f56bc*/ UnityEngine.Animations.AnimationOffsetPlayable get_Null();
            static /*0x27f5714*/ UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x27f5804*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x27f5ab0*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable);
            static /*0x27f5ae0*/ UnityEngine.Animations.AnimationOffsetPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x27f5a00*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f5c24*/ UnityEngine.Vector3 GetPositionInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f5d34*/ void SetPositionInternal(ref UnityEngine.Playables.PlayableHandle handle, UnityEngine.Vector3 value);
            static /*0x27f5e14*/ UnityEngine.Quaternion GetRotationInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f5f28*/ void SetRotationInternal(ref UnityEngine.Playables.PlayableHandle handle, UnityEngine.Quaternion value);
            static /*0x27f5fb4*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f6010*/ void GetPositionInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, ref UnityEngine.Vector3 ret);
            static /*0x27f6054*/ void SetPositionInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, ref UnityEngine.Vector3 value);
            static /*0x27f6098*/ void GetRotationInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, ref UnityEngine.Quaternion ret);
            static /*0x27f60dc*/ void SetRotationInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, ref UnityEngine.Quaternion value);
            /*0x27f5940*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x27f5aa4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x27f5b24*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
            /*0x27f5bd0*/ UnityEngine.Vector3 GetPosition();
            /*0x27f5cb8*/ void SetPosition(UnityEngine.Vector3 value);
            /*0x27f5dc0*/ UnityEngine.Quaternion GetRotation();
            /*0x27f5ea4*/ void SetRotation(UnityEngine.Quaternion value);
        }

        class AnimationPlayableExtensions
        {
            static void SetAnimatedProperties<U>(U playable, UnityEngine.AnimationClip clip);
            static /*0x27f61bc*/ void SetAnimatedPropertiesInternal(ref UnityEngine.Playables.PlayableHandle playable, UnityEngine.AnimationClip animatedProperties);
        }

        class AnimationPlayableGraphExtensions
        {
            static /*0x27f1070*/ void SyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animator animator);
            static /*0x27f6244*/ void DestroyOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x27f62d0*/ bool InternalCreateAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x27f6200*/ void InternalSyncUpdateAndTimeMode(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animator animator);
            static /*0x27f628c*/ void InternalDestroyOutput(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x27f6324*/ int InternalAnimationOutputCount(ref UnityEngine.Playables.PlayableGraph graph);
            static /*0x27f6360*/ bool InternalGetAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, int index, ref UnityEngine.Playables.PlayableOutputHandle handle);
        }

        class LookAtConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x27f63f8*/ void Internal_Create(UnityEngine.Animations.LookAtConstraint self);
            static /*0x27f69f0*/ int GetSourceCountInternal(UnityEngine.Animations.LookAtConstraint self);
            static /*0x27f6b04*/ void SetSourcesInternal(UnityEngine.Animations.LookAtConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x27f63b4*/ LookAtConstraint();
            /*0x27f6434*/ float get_weight();
            /*0x27f6470*/ void set_weight(float value);
            /*0x27f64bc*/ float get_roll();
            /*0x27f64f8*/ void set_roll(float value);
            /*0x27f6544*/ bool get_constraintActive();
            /*0x27f6580*/ void set_constraintActive(bool value);
            /*0x27f65c4*/ bool get_locked();
            /*0x27f6600*/ void set_locked(bool value);
            /*0x27f6644*/ UnityEngine.Vector3 get_rotationAtRest();
            /*0x27f66e4*/ void set_rotationAtRest(UnityEngine.Vector3 value);
            /*0x27f677c*/ UnityEngine.Vector3 get_rotationOffset();
            /*0x27f681c*/ void set_rotationOffset(UnityEngine.Vector3 value);
            /*0x27f68b4*/ UnityEngine.Transform get_worldUpObject();
            /*0x27f68f0*/ void set_worldUpObject(UnityEngine.Transform value);
            /*0x27f6934*/ bool get_useUpObject();
            /*0x27f6970*/ void set_useUpObject(bool value);
            /*0x27f69b4*/ int get_sourceCount();
            /*0x27f6a2c*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x27f6a70*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x27f6b48*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x27f6bdc*/ void RemoveSource(int index);
            /*0x27f6da0*/ void RemoveSourceInternal(int index);
            /*0x27f6de4*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x27f6e0c*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x27f6ebc*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x27f6efc*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x27f6c24*/ void ValidateSourceIndex(int index);
            /*0x27f66a0*/ void get_rotationAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x27f6738*/ void set_rotationAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x27f67d8*/ void get_rotationOffset_Injected(ref UnityEngine.Vector3 ret);
            /*0x27f6870*/ void set_rotationOffset_Injected(ref UnityEngine.Vector3 value);
            /*0x27f6b98*/ int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source);
            /*0x27f6e68*/ void GetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource ret);
            /*0x27f6f54*/ void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source);
        }

        struct AnimationScriptPlayable : UnityEngine.Animations.IAnimationJobPlayable, UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x27f74fc*/ AnimationScriptPlayable();
            static /*0x27f6fa8*/ UnityEngine.Animations.AnimationScriptPlayable get_Null();
            static UnityEngine.Animations.AnimationScriptPlayable Create<T>(UnityEngine.Playables.PlayableGraph graph, T jobData, int inputCount);
            static UnityEngine.Playables.PlayableHandle CreateHandle<T>(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x27f70cc*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationScriptPlayable playable);
            static /*0x27f70fc*/ UnityEngine.Animations.AnimationScriptPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x27f738c*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle, nint jobReflectionData);
            static /*0x27f7224*/ void SetProcessInputsInternal(UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27f7308*/ bool GetProcessInputsInternal(UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f7428*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle, nint jobReflectionData);
            static /*0x27f747c*/ void SetProcessInputsInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27f74c0*/ bool GetProcessInputsInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle);
            /*0x27f7000*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x27f70c0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            void CheckJobTypeValidity<T>();
            T GetJobData<T>();
            void SetJobData<T>(T jobData);
            /*0x27f7140*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
            /*0x27f71b8*/ void SetProcessInputs(bool value);
            /*0x27f72ac*/ bool GetProcessInputs();
        }

        struct AnimationLayerMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x27f801c*/ AnimationLayerMixerPlayable();
            static /*0x27f7598*/ UnityEngine.Animations.AnimationLayerMixerPlayable get_Null();
            static /*0x27f1484*/ UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x27f75f0*/ UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool singleLayerOptimization);
            static /*0x27f7698*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x27f796c*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable);
            static /*0x27f799c*/ UnityEngine.Animations.AnimationLayerMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x27f7890*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27f7bb0*/ bool IsLayerAdditiveInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex);
            static /*0x27f7d50*/ void SetLayerAdditiveInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, bool value);
            static /*0x27f791c*/ void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27f7f84*/ void SetLayerMaskFromAvatarMaskInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, UnityEngine.AvatarMask mask);
            static /*0x27f7fd8*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x27f777c*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization);
            /*0x27f7960*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x27f79e4*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
            /*0x27f7a5c*/ bool IsLayerAdditive(uint layerIndex);
            /*0x27f7bf4*/ void SetLayerAdditive(uint layerIndex, bool value);
            /*0x27f7da4*/ void SetLayerMaskFromAvatarMask(uint layerIndex, UnityEngine.AvatarMask mask);
        }

        enum BindType
        {
            Unbound = 0,
            Float = 5,
            Bool = 6,
            GameObjectActive = 7,
            ObjectReference = 9,
            Int = 10,
            DiscreetInt = 11,
        }

        struct TransformStreamHandle
        {
            /*0x10*/ uint m_AnimatorBindingsVersion;
            /*0x14*/ int handleIndex;
            /*0x18*/ int skeletonIndex;

            static /*0x27f9004*/ void ResolveInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27f9048*/ void GetPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 ret);
            static /*0x27f909c*/ void SetPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position);
            static /*0x27f90f0*/ void GetRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion ret);
            static /*0x27f9144*/ void SetRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion rotation);
            static /*0x27f9198*/ void GetLocalPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 ret);
            static /*0x27f91ec*/ void SetLocalPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position);
            static /*0x27f9240*/ void GetLocalRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion ret);
            static /*0x27f9294*/ void SetLocalRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion rotation);
            static /*0x27f92e8*/ void GetLocalScaleInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 ret);
            static /*0x27f933c*/ void SetLocalScaleInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 scale);
            static /*0x27f9390*/ bool GetPositionReadMaskInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27f93d4*/ bool GetRotationReadMaskInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27f9418*/ bool GetScaleReadMaskInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27f945c*/ void GetLocalTRSInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
            static /*0x27f94c8*/ void SetLocalTRSInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale, bool useMask);
            static /*0x27f953c*/ void GetGlobalTRInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            static /*0x27f9598*/ void SetGlobalTRInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, bool useMask);
            /*0x27f80bc*/ bool IsValid(UnityEngine.Animations.AnimationStream stream);
            /*0x27f80f4*/ bool IsValidInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f820c*/ bool get_createdByNative();
            /*0x27f8234*/ bool IsSameVersionAsStream(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f821c*/ bool get_hasHandleIndex();
            /*0x27f8250*/ bool get_hasSkeletonIndex();
            /*0x27f8260*/ void set_animatorBindingsVersion(uint value);
            /*0x27f822c*/ uint get_animatorBindingsVersion();
            /*0x27f8268*/ void Resolve(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8380*/ bool IsResolved(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8384*/ bool IsResolvedInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f826c*/ void CheckIsValidAndResolve(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8484*/ UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8510*/ void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position);
            /*0x27f85bc*/ UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8644*/ void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation);
            /*0x27f86f8*/ UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8784*/ void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position);
            /*0x27f8830*/ UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream);
            /*0x27f88b8*/ void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation);
            /*0x27f896c*/ UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream);
            /*0x27f89f8*/ void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale);
            /*0x27f8aa4*/ bool GetPositionReadMask(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8b30*/ bool GetRotationReadMask(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8bbc*/ bool GetScaleReadMask(UnityEngine.Animations.AnimationStream stream);
            /*0x27f8c48*/ void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
            /*0x27f8d24*/ void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, bool useMask);
            /*0x27f8e48*/ void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            /*0x27f8f04*/ void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, bool useMask);
            /*0x27f8440*/ void ResolveInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f84ac*/ UnityEngine.Vector3 GetPositionInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8560*/ void SetPositionInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position);
            /*0x27f85e4*/ UnityEngine.Quaternion GetRotationInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f869c*/ void SetRotationInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation);
            /*0x27f8720*/ UnityEngine.Vector3 GetLocalPositionInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f87d4*/ void SetLocalPositionInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position);
            /*0x27f8858*/ UnityEngine.Quaternion GetLocalRotationInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8910*/ void SetLocalRotationInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation);
            /*0x27f8994*/ UnityEngine.Vector3 GetLocalScaleInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8a48*/ void SetLocalScaleInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale);
            /*0x27f8aec*/ bool GetPositionReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8b78*/ bool GetRotationReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8c04*/ bool GetScaleReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f8cb8*/ void GetLocalTRSInternal(ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
            /*0x27f8dbc*/ void SetLocalTRSInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, bool useMask);
            /*0x27f8ea8*/ void GetGlobalTRInternal(ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            /*0x27f8f8c*/ void SetGlobalTRInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, bool useMask);
        }

        struct PropertyStreamHandle
        {
            /*0x10*/ uint m_AnimatorBindingsVersion;
            /*0x14*/ int handleIndex;
            /*0x18*/ int valueArrayIndex;
            /*0x1c*/ int bindType;

            static /*0x27f9f10*/ void ResolveInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27f9f54*/ float GetFloatInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27f9f98*/ void SetFloatInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, float value);
            static /*0x27f9fec*/ int GetIntInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fa030*/ void SetIntInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, int value);
            static /*0x27fa084*/ bool GetBoolInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fa0c8*/ void SetBoolInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, bool value);
            static /*0x27fa11c*/ bool GetReadMaskInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f9604*/ bool IsValid(UnityEngine.Animations.AnimationStream stream);
            /*0x27f9648*/ bool IsValidInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f968c*/ bool get_createdByNative();
            /*0x27f96c4*/ bool IsSameVersionAsStream(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f969c*/ bool get_hasHandleIndex();
            /*0x27f96d8*/ bool get_hasValueArrayIndex();
            /*0x27f96ac*/ bool get_hasBindType();
            /*0x27f96e8*/ void set_animatorBindingsVersion(uint value);
            /*0x27f96bc*/ uint get_animatorBindingsVersion();
            /*0x27f96f0*/ void Resolve(UnityEngine.Animations.AnimationStream stream);
            /*0x27f9810*/ bool IsResolved(UnityEngine.Animations.AnimationStream stream);
            /*0x27f9814*/ bool IsResolvedInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f96f4*/ void CheckIsValidAndResolve(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f98bc*/ float GetFloat(UnityEngine.Animations.AnimationStream stream);
            /*0x27f99a0*/ void SetFloat(UnityEngine.Animations.AnimationStream stream, float value);
            /*0x27f9aa4*/ int GetInt(UnityEngine.Animations.AnimationStream stream);
            /*0x27f9b8c*/ void SetInt(UnityEngine.Animations.AnimationStream stream, int value);
            /*0x27f9c94*/ bool GetBool(UnityEngine.Animations.AnimationStream stream);
            /*0x27f9d7c*/ void SetBool(UnityEngine.Animations.AnimationStream stream, bool value);
            /*0x27f9e84*/ bool GetReadMask(UnityEngine.Animations.AnimationStream stream);
            /*0x27f9878*/ void ResolveInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f995c*/ float GetFloatInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f9a50*/ void SetFloatInternal(ref UnityEngine.Animations.AnimationStream stream, float value);
            /*0x27f9b48*/ int GetIntInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f9c40*/ void SetIntInternal(ref UnityEngine.Animations.AnimationStream stream, int value);
            /*0x27f9d38*/ bool GetBoolInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27f9e30*/ void SetBoolInternal(ref UnityEngine.Animations.AnimationStream stream, bool value);
            /*0x27f9ecc*/ bool GetReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream);
        }

        struct TransformSceneHandle
        {
            /*0x10*/ uint valid;
            /*0x14*/ int transformSceneHandleDefinitionIndex;

            static /*0x27fa784*/ bool HasValidTransform_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fa7c8*/ void GetPositionInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 ret);
            static /*0x27fa81c*/ void GetLocalPositionInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 ret);
            static /*0x27fa870*/ void GetRotationInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion ret);
            static /*0x27fa8c4*/ void GetLocalRotationInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion ret);
            static /*0x27fa918*/ void GetLocalScaleInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 ret);
            static /*0x27fa96c*/ void GetLocalTRSInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
            static /*0x27fa9d8*/ void GetGlobalTRInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            /*0x27fa160*/ bool IsValid(UnityEngine.Animations.AnimationStream stream);
            /*0x27fa1d4*/ bool get_createdByNative();
            /*0x27fa1e4*/ bool get_hasTransformSceneHandleDefinitionIndex();
            /*0x27fa238*/ void CheckIsValid(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa324*/ UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream);
            /*0x27fa3b0*/ void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position);
            /*0x27fa3b4*/ UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream);
            /*0x27fa440*/ void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position);
            /*0x27fa444*/ UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream);
            /*0x27fa4cc*/ void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation);
            /*0x27fa4d0*/ UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream);
            /*0x27fa558*/ void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation);
            /*0x27fa55c*/ UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream);
            /*0x27fa5e8*/ void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
            /*0x27fa6c4*/ void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
            /*0x27fa780*/ void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale);
            /*0x27fa1f4*/ bool HasValidTransform(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa34c*/ UnityEngine.Vector3 GetPositionInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa3dc*/ UnityEngine.Vector3 GetLocalPositionInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa46c*/ UnityEngine.Quaternion GetRotationInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa4f8*/ UnityEngine.Quaternion GetLocalRotationInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa584*/ UnityEngine.Vector3 GetLocalScaleInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fa658*/ void GetLocalTRSInternal(ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
            /*0x27fa724*/ void GetGlobalTRInternal(ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        }

        struct PropertySceneHandle
        {
            /*0x10*/ uint valid;
            /*0x14*/ int handleIndex;

            static /*0x27faed8*/ bool HasValidTransform_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27faf1c*/ bool IsBound_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27faf60*/ void ResolveInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fafa4*/ float GetFloatInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fafe8*/ int GetIntInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fb02c*/ bool GetBoolInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream);
            /*0x27faa34*/ bool IsValid(UnityEngine.Animations.AnimationStream stream);
            /*0x27faa38*/ bool IsValidInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27faaac*/ bool get_createdByNative();
            /*0x27faabc*/ bool get_hasHandleIndex();
            /*0x27fab10*/ void Resolve(UnityEngine.Animations.AnimationStream stream);
            /*0x27fac88*/ bool IsResolved(UnityEngine.Animations.AnimationStream stream);
            /*0x27fab58*/ void CheckIsValid(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fad28*/ float GetFloat(UnityEngine.Animations.AnimationStream stream);
            /*0x27fadb4*/ void SetFloat(UnityEngine.Animations.AnimationStream stream, float value);
            /*0x27fadb8*/ int GetInt(UnityEngine.Animations.AnimationStream stream);
            /*0x27fae44*/ void SetInt(UnityEngine.Animations.AnimationStream stream, int value);
            /*0x27fae48*/ bool GetBool(UnityEngine.Animations.AnimationStream stream);
            /*0x27faed4*/ void SetBool(UnityEngine.Animations.AnimationStream stream, bool value);
            /*0x27faacc*/ bool HasValidTransform(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27face4*/ bool IsBound(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fac44*/ void ResolveInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fad70*/ float GetFloatInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fae00*/ int GetIntInternal(ref UnityEngine.Animations.AnimationStream stream);
            /*0x27fae90*/ bool GetBoolInternal(ref UnityEngine.Animations.AnimationStream stream);
        }

        class AnimationSceneHandleUtility
        {
            static /*0x27fb070*/ void ReadInts(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<int> buffer);
            static /*0x27fb1e4*/ void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<float> buffer);
            static int ValidateAndGetArrayCount<T0, T1>(ref UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<T0> handles, Unity.Collections.NativeArray<T1> buffer);
            static /*0x27fb188*/ void ReadSceneIntsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertySceneHandles, void* intBuffer, int count);
            static /*0x27fb2fc*/ void ReadSceneFloatsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count);
        }

        class AnimationStreamHandleUtility
        {
            static /*0x27fb358*/ void WriteInts(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer, bool useMask);
            static /*0x27fb4f8*/ void WriteFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer, bool useMask);
            static /*0x27fb698*/ void ReadInts(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer);
            static /*0x27fb814*/ void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer);
            static /*0x27fb7b8*/ void ReadStreamIntsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count);
            static /*0x27fb934*/ void ReadStreamFloatsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count);
            static /*0x27fb48c*/ void WriteStreamIntsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count, bool useMask);
            static /*0x27fb62c*/ void WriteStreamFloatsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask);
        }

        enum CustomStreamPropertyType
        {
            Float = 5,
            Bool = 6,
            Int = 10,
        }

        class AnimatorJobExtensions
        {
            static /*0x27fb990*/ void AddJobDependency(UnityEngine.Animator animator, Unity.Jobs.JobHandle jobHandle);
            static /*0x27fb9e4*/ UnityEngine.Animations.TransformStreamHandle BindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform);
            static /*0x27fba9c*/ UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property);
            static /*0x27fbb28*/ UnityEngine.Animations.PropertyStreamHandle BindCustomStreamProperty(UnityEngine.Animator animator, string property, UnityEngine.Animations.CustomStreamPropertyType type);
            static /*0x27fbaa4*/ UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference);
            static /*0x27fbc64*/ UnityEngine.Animations.TransformSceneHandle BindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform);
            static /*0x27fbd14*/ UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property);
            static /*0x27fbd8c*/ UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference);
            static /*0x27fbe7c*/ bool OpenAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fbf04*/ void CloseAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fbf8c*/ void ResolveAllStreamHandles(UnityEngine.Animator animator);
            static /*0x27fc004*/ void ResolveAllSceneHandles(UnityEngine.Animator animator);
            static /*0x27fc07c*/ void UnbindAllHandles(UnityEngine.Animator animator);
            static /*0x27fc158*/ void UnbindAllStreamHandles(UnityEngine.Animator animator);
            static /*0x27fc194*/ void UnbindAllSceneHandles(UnityEngine.Animator animator);
            static /*0x27fb994*/ void InternalAddJobDependency(UnityEngine.Animator animator, Unity.Jobs.JobHandle jobHandle);
            static /*0x27fba48*/ void InternalBindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, ref UnityEngine.Animations.TransformStreamHandle transformStreamHandle);
            static /*0x27fbbf0*/ void InternalBindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference, ref UnityEngine.Animations.PropertyStreamHandle propertyStreamHandle);
            static /*0x27fbb94*/ void InternalBindCustomStreamProperty(UnityEngine.Animator animator, string property, UnityEngine.Animations.CustomStreamPropertyType propertyType, ref UnityEngine.Animations.PropertyStreamHandle propertyStreamHandle);
            static /*0x27fbcc0*/ void InternalBindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, ref UnityEngine.Animations.TransformSceneHandle transformSceneHandle);
            static /*0x27fbe08*/ void InternalBindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference, ref UnityEngine.Animations.PropertySceneHandle propertySceneHandle);
            static /*0x27fbec0*/ bool InternalOpenAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fbf48*/ void InternalCloseAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream);
            static /*0x27fbfc8*/ void InternalResolveAllStreamHandles(UnityEngine.Animator animator);
            static /*0x27fc040*/ void InternalResolveAllSceneHandles(UnityEngine.Animator animator);
            static /*0x27fc0e0*/ void InternalUnbindAllStreamHandles(UnityEngine.Animator animator);
            static /*0x27fc11c*/ void InternalUnbindAllSceneHandles(UnityEngine.Animator animator);
            static /*0x27fc1d0*/ void InternalAddJobDependency_Injected(UnityEngine.Animator animator, ref Unity.Jobs.JobHandle jobHandle);
        }

        struct AnimationClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x27f119c*/ UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x27fc214*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x27fc3ec*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable);
            static /*0x27fc41c*/ UnityEngine.Animations.AnimationClipPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x27fc384*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fc514*/ UnityEngine.AnimationClip GetAnimationClipInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fc58c*/ bool GetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fc60c*/ void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27fc68c*/ bool GetApplyPlayableIKInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fc70c*/ void SetApplyPlayableIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27fc78c*/ bool GetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fc80c*/ void SetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27fc88c*/ bool GetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fc90c*/ void SetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27fc98c*/ bool GetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fca0c*/ void SetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x27fca8c*/ float GetSampleRateInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x27fcb14*/ void SetSampleRateInternal(ref UnityEngine.Playables.PlayableHandle handle, float value);
            static /*0x27fcb60*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x27fc2c4*/ AnimationClipPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x27fc3e0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x27fc460*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
            /*0x27fc4d8*/ UnityEngine.AnimationClip GetAnimationClip();
            /*0x27fc550*/ bool GetApplyFootIK();
            /*0x27fc5c8*/ void SetApplyFootIK(bool value);
            /*0x27fc650*/ bool GetApplyPlayableIK();
            /*0x27fc6c8*/ void SetApplyPlayableIK(bool value);
            /*0x27fc750*/ bool GetRemoveStartOffset();
            /*0x27fc7c8*/ void SetRemoveStartOffset(bool value);
            /*0x27fc850*/ bool GetOverrideLoopTime();
            /*0x27fc8c8*/ void SetOverrideLoopTime(bool value);
            /*0x27fc950*/ bool GetLoopTime();
            /*0x27fc9c8*/ void SetLoopTime(bool value);
            /*0x27fca50*/ float GetSampleRate();
            /*0x27fcac8*/ void SetSampleRate(float value);
        }

        class AimConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x27fcbf8*/ void Internal_Create(UnityEngine.Animations.AimConstraint self);
            static /*0x27fd590*/ int GetSourceCountInternal(UnityEngine.Animations.AimConstraint self);
            static /*0x27fd6a4*/ void SetSourcesInternal(UnityEngine.Animations.AimConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x27fcbb4*/ AimConstraint();
            /*0x27fcc34*/ float get_weight();
            /*0x27fcc70*/ void set_weight(float value);
            /*0x27fccbc*/ bool get_constraintActive();
            /*0x27fccf8*/ void set_constraintActive(bool value);
            /*0x27fcd3c*/ bool get_locked();
            /*0x27fcd78*/ void set_locked(bool value);
            /*0x27fcdbc*/ UnityEngine.Vector3 get_rotationAtRest();
            /*0x27fce5c*/ void set_rotationAtRest(UnityEngine.Vector3 value);
            /*0x27fcef4*/ UnityEngine.Vector3 get_rotationOffset();
            /*0x27fcf94*/ void set_rotationOffset(UnityEngine.Vector3 value);
            /*0x27fd02c*/ UnityEngine.Animations.Axis get_rotationAxis();
            /*0x27fd068*/ void set_rotationAxis(UnityEngine.Animations.Axis value);
            /*0x27fd0ac*/ UnityEngine.Vector3 get_aimVector();
            /*0x27fd14c*/ void set_aimVector(UnityEngine.Vector3 value);
            /*0x27fd1e4*/ UnityEngine.Vector3 get_upVector();
            /*0x27fd284*/ void set_upVector(UnityEngine.Vector3 value);
            /*0x27fd31c*/ UnityEngine.Vector3 get_worldUpVector();
            /*0x27fd3bc*/ void set_worldUpVector(UnityEngine.Vector3 value);
            /*0x27fd454*/ UnityEngine.Transform get_worldUpObject();
            /*0x27fd490*/ void set_worldUpObject(UnityEngine.Transform value);
            /*0x27fd4d4*/ UnityEngine.Animations.AimConstraint.WorldUpType get_worldUpType();
            /*0x27fd510*/ void set_worldUpType(UnityEngine.Animations.AimConstraint.WorldUpType value);
            /*0x27fd554*/ int get_sourceCount();
            /*0x27fd5cc*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x27fd610*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x27fd6e8*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x27fd77c*/ void RemoveSource(int index);
            /*0x27fd940*/ void RemoveSourceInternal(int index);
            /*0x27fd984*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x27fd9ac*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x27fda5c*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x27fda9c*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x27fd7c4*/ void ValidateSourceIndex(int index);
            /*0x27fce18*/ void get_rotationAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x27fceb0*/ void set_rotationAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x27fcf50*/ void get_rotationOffset_Injected(ref UnityEngine.Vector3 ret);
            /*0x27fcfe8*/ void set_rotationOffset_Injected(ref UnityEngine.Vector3 value);
            /*0x27fd108*/ void get_aimVector_Injected(ref UnityEngine.Vector3 ret);
            /*0x27fd1a0*/ void set_aimVector_Injected(ref UnityEngine.Vector3 value);
            /*0x27fd240*/ void get_upVector_Injected(ref UnityEngine.Vector3 ret);
            /*0x27fd2d8*/ void set_upVector_Injected(ref UnityEngine.Vector3 value);
            /*0x27fd378*/ void get_worldUpVector_Injected(ref UnityEngine.Vector3 ret);
            /*0x27fd410*/ void set_worldUpVector_Injected(ref UnityEngine.Vector3 value);
            /*0x27fd738*/ int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source);
            /*0x27fda08*/ void GetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource ret);
            /*0x27fdaf4*/ void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source);

            enum WorldUpType
            {
                SceneUp = 0,
                ObjectUp = 1,
                ObjectRotationUp = 2,
                Vector = 3,
                None = 4,
            }
        }

        struct MuscleHandle
        {
            /*0x10*/ UnityEngine.HumanPartDof <humanPartDof>k__BackingField;
            /*0x14*/ int <dof>k__BackingField;

            static /*0x27fdd2c*/ int get_muscleHandleCount();
            static /*0x27fdd7c*/ void GetMuscleHandles(UnityEngine.Animations.MuscleHandle[] muscleHandles);
            static /*0x27fdd54*/ int GetMuscleHandleCount();
            static /*0x27fddb8*/ string GetName_Injected(ref UnityEngine.Animations.MuscleHandle _unity_self);
            /*0x27fdb68*/ MuscleHandle(UnityEngine.BodyDof bodyDof);
            /*0x27fdb70*/ MuscleHandle(UnityEngine.HeadDof headDof);
            /*0x27fdb7c*/ MuscleHandle(UnityEngine.HumanPartDof partDof, UnityEngine.LegDof legDof);
            /*0x27fdbe4*/ MuscleHandle(UnityEngine.HumanPartDof partDof, UnityEngine.ArmDof armDof);
            /*0x27fdc4c*/ MuscleHandle(UnityEngine.HumanPartDof partDof, UnityEngine.FingerDof fingerDof);
            /*0x27fdb48*/ UnityEngine.HumanPartDof get_humanPartDof();
            /*0x27fdb50*/ void set_humanPartDof(UnityEngine.HumanPartDof value);
            /*0x27fdb58*/ int get_dof();
            /*0x27fdb60*/ void set_dof(int value);
            /*0x27fdcb4*/ string get_name();
            /*0x27fdcf0*/ string GetName();
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;

            static /*0x27ff538*/ float GetHumanScale_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self);
            static /*0x27ff574*/ float GetFootHeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, bool left);
            static /*0x27ff5b8*/ void InternalResetToStancePose_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self);
            static /*0x27ff5f4*/ void InternalGetGoalPositionFromPose_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 ret);
            static /*0x27ff648*/ void InternalGetGoalRotationFromPose_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion ret);
            static /*0x27ff69c*/ void InternalGetBodyLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x27ff6e0*/ void InternalSetBodyLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 value);
            static /*0x27ff724*/ void InternalGetBodyLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Quaternion ret);
            static /*0x27ff768*/ void InternalSetBodyLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Quaternion value);
            static /*0x27ff7ac*/ void InternalGetBodyPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x27ff7f0*/ void InternalSetBodyPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 value);
            static /*0x27ff834*/ void InternalGetBodyRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Quaternion ret);
            static /*0x27ff878*/ void InternalSetBodyRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Quaternion value);
            static /*0x27ff8bc*/ float InternalGetMuscle_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Animations.MuscleHandle muscle);
            static /*0x27ff900*/ void InternalSetMuscle_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Animations.MuscleHandle muscle, float value);
            static /*0x27ff954*/ void GetLeftFootVelocity_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x27ff998*/ void GetRightFootVelocity_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x27ff9dc*/ void InternalGetGoalLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 ret);
            static /*0x27ffa30*/ void InternalSetGoalLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 pos);
            static /*0x27ffa84*/ void InternalGetGoalLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion ret);
            static /*0x27ffad8*/ void InternalSetGoalLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion rot);
            static /*0x27ffb2c*/ void InternalGetGoalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 ret);
            static /*0x27ffb80*/ void InternalSetGoalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 pos);
            static /*0x27ffbd4*/ void InternalGetGoalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion ret);
            static /*0x27ffc28*/ void InternalSetGoalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion rot);
            static /*0x27ffc7c*/ void InternalSetGoalWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, float value);
            static /*0x27ffcd0*/ void InternalSetGoalWeightRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, float value);
            static /*0x27ffd24*/ float InternalGetGoalWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index);
            static /*0x27ffd68*/ float InternalGetGoalWeightRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index);
            static /*0x27ffdac*/ void InternalGetHintPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index, ref UnityEngine.Vector3 ret);
            static /*0x27ffe00*/ void InternalSetHintPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index, ref UnityEngine.Vector3 pos);
            static /*0x27ffe54*/ void InternalSetHintWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index, float value);
            static /*0x27ffea8*/ float InternalGetHintWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index);
            static /*0x27ffeec*/ void InternalSetLookAtPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 lookAtPosition);
            static /*0x27fff30*/ void InternalSetLookAtClampWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight);
            static /*0x27fff7c*/ void InternalSetLookAtBodyWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight);
            static /*0x27fffc8*/ void InternalSetLookAtHeadWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight);
            static /*0x2800014*/ void InternalSetLookAtEyesWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight);
            static /*0x2800060*/ void InternalSolveIK_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self);
            /*0x27fddf4*/ bool get_isValid();
            /*0x27fde48*/ void ThrowIfInvalid();
            /*0x27fdea8*/ float get_humanScale();
            /*0x27fdf24*/ float get_leftFootHeight();
            /*0x27fdfac*/ float get_rightFootHeight();
            /*0x27fdff0*/ UnityEngine.Vector3 get_bodyLocalPosition();
            /*0x27fe064*/ void set_bodyLocalPosition(UnityEngine.Vector3 value);
            /*0x27fe0f8*/ UnityEngine.Quaternion get_bodyLocalRotation();
            /*0x27fe168*/ void set_bodyLocalRotation(UnityEngine.Quaternion value);
            /*0x27fe204*/ UnityEngine.Vector3 get_bodyPosition();
            /*0x27fe278*/ void set_bodyPosition(UnityEngine.Vector3 value);
            /*0x27fe30c*/ UnityEngine.Quaternion get_bodyRotation();
            /*0x27fe37c*/ void set_bodyRotation(UnityEngine.Quaternion value);
            /*0x27fe418*/ float GetMuscle(UnityEngine.Animations.MuscleHandle muscle);
            /*0x27fe4b8*/ void SetMuscle(UnityEngine.Animations.MuscleHandle muscle, float value);
            /*0x27fe578*/ UnityEngine.Vector3 get_leftFootVelocity();
            /*0x27fe5ec*/ UnityEngine.Vector3 get_rightFootVelocity();
            /*0x27fe660*/ void ResetToStancePose();
            /*0x27fe6dc*/ UnityEngine.Vector3 GetGoalPositionFromPose(UnityEngine.AvatarIKGoal index);
            /*0x27fe768*/ UnityEngine.Quaternion GetGoalRotationFromPose(UnityEngine.AvatarIKGoal index);
            /*0x27fe7f0*/ UnityEngine.Vector3 GetGoalLocalPosition(UnityEngine.AvatarIKGoal index);
            /*0x27fe87c*/ void SetGoalLocalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos);
            /*0x27fe928*/ UnityEngine.Quaternion GetGoalLocalRotation(UnityEngine.AvatarIKGoal index);
            /*0x27fe9b0*/ void SetGoalLocalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot);
            /*0x27fea64*/ UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal index);
            /*0x27feaf0*/ void SetGoalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos);
            /*0x27feb9c*/ UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal index);
            /*0x27fec24*/ void SetGoalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot);
            /*0x27fecd8*/ void SetGoalWeightPosition(UnityEngine.AvatarIKGoal index, float value);
            /*0x27fed84*/ void SetGoalWeightRotation(UnityEngine.AvatarIKGoal index, float value);
            /*0x27fee30*/ float GetGoalWeightPosition(UnityEngine.AvatarIKGoal index);
            /*0x27feebc*/ float GetGoalWeightRotation(UnityEngine.AvatarIKGoal index);
            /*0x27fef48*/ UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint index);
            /*0x27fefd4*/ void SetHintPosition(UnityEngine.AvatarIKHint index, UnityEngine.Vector3 pos);
            /*0x27ff080*/ void SetHintWeightPosition(UnityEngine.AvatarIKHint index, float value);
            /*0x27ff12c*/ float GetHintWeightPosition(UnityEngine.AvatarIKHint index);
            /*0x27ff1b8*/ void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition);
            /*0x27ff24c*/ void SetLookAtClampWeight(float weight);
            /*0x27ff2e8*/ void SetLookAtBodyWeight(float weight);
            /*0x27ff384*/ void SetLookAtHeadWeight(float weight);
            /*0x27ff420*/ void SetLookAtEyesWeight(float weight);
            /*0x27ff4bc*/ void SolveIK();
            /*0x27fdee8*/ float GetHumanScale();
            /*0x27fdf68*/ float GetFootHeight(bool left);
            /*0x27fe6a0*/ void InternalResetToStancePose();
            /*0x27fe704*/ UnityEngine.Vector3 InternalGetGoalPositionFromPose(UnityEngine.AvatarIKGoal index);
            /*0x27fe790*/ UnityEngine.Quaternion InternalGetGoalRotationFromPose(UnityEngine.AvatarIKGoal index);
            /*0x27fe008*/ UnityEngine.Vector3 InternalGetBodyLocalPosition();
            /*0x27fe0a4*/ void InternalSetBodyLocalPosition(UnityEngine.Vector3 value);
            /*0x27fe110*/ UnityEngine.Quaternion InternalGetBodyLocalRotation();
            /*0x27fe1b0*/ void InternalSetBodyLocalRotation(UnityEngine.Quaternion value);
            /*0x27fe21c*/ UnityEngine.Vector3 InternalGetBodyPosition();
            /*0x27fe2b8*/ void InternalSetBodyPosition(UnityEngine.Vector3 value);
            /*0x27fe324*/ UnityEngine.Quaternion InternalGetBodyRotation();
            /*0x27fe3c4*/ void InternalSetBodyRotation(UnityEngine.Quaternion value);
            /*0x27fe470*/ float InternalGetMuscle(UnityEngine.Animations.MuscleHandle muscle);
            /*0x27fe518*/ void InternalSetMuscle(UnityEngine.Animations.MuscleHandle muscle, float value);
            /*0x27fe590*/ UnityEngine.Vector3 GetLeftFootVelocity();
            /*0x27fe604*/ UnityEngine.Vector3 GetRightFootVelocity();
            /*0x27fe818*/ UnityEngine.Vector3 InternalGetGoalLocalPosition(UnityEngine.AvatarIKGoal index);
            /*0x27fe8cc*/ void InternalSetGoalLocalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos);
            /*0x27fe950*/ UnityEngine.Quaternion InternalGetGoalLocalRotation(UnityEngine.AvatarIKGoal index);
            /*0x27fea08*/ void InternalSetGoalLocalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot);
            /*0x27fea8c*/ UnityEngine.Vector3 InternalGetGoalPosition(UnityEngine.AvatarIKGoal index);
            /*0x27feb40*/ void InternalSetGoalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos);
            /*0x27febc4*/ UnityEngine.Quaternion InternalGetGoalRotation(UnityEngine.AvatarIKGoal index);
            /*0x27fec7c*/ void InternalSetGoalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot);
            /*0x27fed30*/ void InternalSetGoalWeightPosition(UnityEngine.AvatarIKGoal index, float value);
            /*0x27feddc*/ void InternalSetGoalWeightRotation(UnityEngine.AvatarIKGoal index, float value);
            /*0x27fee78*/ float InternalGetGoalWeightPosition(UnityEngine.AvatarIKGoal index);
            /*0x27fef04*/ float InternalGetGoalWeightRotation(UnityEngine.AvatarIKGoal index);
            /*0x27fef70*/ UnityEngine.Vector3 InternalGetHintPosition(UnityEngine.AvatarIKHint index);
            /*0x27ff024*/ void InternalSetHintPosition(UnityEngine.AvatarIKHint index, UnityEngine.Vector3 pos);
            /*0x27ff0d8*/ void InternalSetHintWeightPosition(UnityEngine.AvatarIKHint index, float value);
            /*0x27ff174*/ float InternalGetHintWeightPosition(UnityEngine.AvatarIKHint index);
            /*0x27ff1f8*/ void InternalSetLookAtPosition(UnityEngine.Vector3 lookAtPosition);
            /*0x27ff29c*/ void InternalSetLookAtClampWeight(float weight);
            /*0x27ff338*/ void InternalSetLookAtBodyWeight(float weight);
            /*0x27ff3d4*/ void InternalSetLookAtHeadWeight(float weight);
            /*0x27ff470*/ void InternalSetLookAtEyesWeight(float weight);
            /*0x27ff4fc*/ void InternalSolveIK();
        }

        struct AnimationPosePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2800978*/ AnimationPosePlayable();
            static /*0x280009c*/ UnityEngine.Animations.AnimationPosePlayable get_Null();
            static /*0x28000f4*/ UnityEngine.Animations.AnimationPosePlayable Create(UnityEngine.Playables.PlayableGraph graph);
            static /*0x2800184*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph);
            static /*0x28003ac*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationPosePlayable playable);
            static /*0x28003dc*/ UnityEngine.Animations.AnimationPosePlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x2800314*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x2800540*/ bool GetMustReadPreviousPoseInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x2800600*/ void SetMustReadPreviousPoseInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x28006b8*/ bool GetReadDefaultPoseInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x2800778*/ void SetReadDefaultPoseInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x2800830*/ bool GetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x28008f0*/ void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x2800934*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x2800254*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x28003a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x2800420*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
            /*0x28004cc*/ bool GetMustReadPreviousPose();
            /*0x280057c*/ void SetMustReadPreviousPose(bool value);
            /*0x2800644*/ bool GetReadDefaultPose();
            /*0x28006f4*/ void SetReadDefaultPose(bool value);
            /*0x28007bc*/ bool GetApplyFootIK();
            /*0x280086c*/ void SetApplyFootIK(bool value);
        }

        class ParentConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x2800a58*/ void Internal_Create(UnityEngine.Animations.ParentConstraint self);
            static /*0x2800c58*/ int GetSourceCountInternal(UnityEngine.Animations.ParentConstraint self);
            static /*0x2801718*/ void SetSourcesInternal(UnityEngine.Animations.ParentConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2800a14*/ ParentConstraint();
            /*0x2800a94*/ float get_weight();
            /*0x2800ad0*/ void set_weight(float value);
            /*0x2800b1c*/ bool get_constraintActive();
            /*0x2800b58*/ void set_constraintActive(bool value);
            /*0x2800b9c*/ bool get_locked();
            /*0x2800bd8*/ void set_locked(bool value);
            /*0x2800c1c*/ int get_sourceCount();
            /*0x2800c94*/ UnityEngine.Vector3 get_translationAtRest();
            /*0x2800d34*/ void set_translationAtRest(UnityEngine.Vector3 value);
            /*0x2800dcc*/ UnityEngine.Vector3 get_rotationAtRest();
            /*0x2800e6c*/ void set_rotationAtRest(UnityEngine.Vector3 value);
            /*0x2800f04*/ UnityEngine.Vector3[] get_translationOffsets();
            /*0x2800f40*/ void set_translationOffsets(UnityEngine.Vector3[] value);
            /*0x2800f84*/ UnityEngine.Vector3[] get_rotationOffsets();
            /*0x2800fc0*/ void set_rotationOffsets(UnityEngine.Vector3[] value);
            /*0x2801004*/ UnityEngine.Animations.Axis get_translationAxis();
            /*0x2801040*/ void set_translationAxis(UnityEngine.Animations.Axis value);
            /*0x2801084*/ UnityEngine.Animations.Axis get_rotationAxis();
            /*0x28010c0*/ void set_rotationAxis(UnityEngine.Animations.Axis value);
            /*0x2801104*/ UnityEngine.Vector3 GetTranslationOffset(int index);
            /*0x280130c*/ void SetTranslationOffset(int index, UnityEngine.Vector3 value);
            /*0x28012a8*/ UnityEngine.Vector3 GetTranslationOffsetInternal(int index);
            /*0x280135c*/ void SetTranslationOffsetInternal(int index, UnityEngine.Vector3 value);
            /*0x2801460*/ UnityEngine.Vector3 GetRotationOffset(int index);
            /*0x28014ec*/ void SetRotationOffset(int index, UnityEngine.Vector3 value);
            /*0x2801488*/ UnityEngine.Vector3 GetRotationOffsetInternal(int index);
            /*0x280153c*/ void SetRotationOffsetInternal(int index, UnityEngine.Vector3 value);
            /*0x280112c*/ void ValidateSourceIndex(int index);
            /*0x2801640*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2801684*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x280175c*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x28017f0*/ void RemoveSource(int index);
            /*0x2801838*/ void RemoveSourceInternal(int index);
            /*0x280187c*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x28018a4*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x2801954*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x2801994*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x2800cf0*/ void get_translationAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x2800d88*/ void set_translationAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x2800e28*/ void get_rotationAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x2800ec0*/ void set_rotationAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x28013b8*/ void GetTranslationOffsetInternal_Injected(int index, ref UnityEngine.Vector3 ret);
            /*0x280140c*/ void SetTranslationOffsetInternal_Injected(int index, ref UnityEngine.Vector3 value);
            /*0x2801598*/ void GetRotationOffsetInternal_Injected(int index, ref UnityEngine.Vector3 ret);
            /*0x28015ec*/ void SetRotationOffsetInternal_Injected(int index, ref UnityEngine.Vector3 value);
            /*0x28017ac*/ int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source);
            /*0x2801900*/ void GetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource ret);
            /*0x28019ec*/ void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source);
        }

        enum Axis
        {
            None = 0,
            X = 1,
            Y = 2,
            Z = 4,
        }

        struct ConstraintSource
        {
            /*0x10*/ UnityEngine.Transform m_SourceTransform;
            /*0x18*/ float m_Weight;

            /*0x2801a40*/ UnityEngine.Transform get_sourceTransform();
            /*0x2801a48*/ void set_sourceTransform(UnityEngine.Transform value);
            /*0x2801a50*/ float get_weight();
            /*0x2801a58*/ void set_weight(float value);
        }

        interface IConstraint
        {
            float get_weight();
            void set_weight(float value);
            bool get_constraintActive();
            void set_constraintActive(bool value);
            bool get_locked();
            void set_locked(bool value);
            int get_sourceCount();
            int AddSource(UnityEngine.Animations.ConstraintSource source);
            void RemoveSource(int index);
            UnityEngine.Animations.ConstraintSource GetSource(int index);
            void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
        }

        interface IConstraintInternal
        {
        }

        class PositionConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x2801aa4*/ void Internal_Create(UnityEngine.Animations.PositionConstraint self);
            static /*0x2801f94*/ int GetSourceCountInternal(UnityEngine.Animations.PositionConstraint self);
            static /*0x28020a8*/ void SetSourcesInternal(UnityEngine.Animations.PositionConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2801a60*/ PositionConstraint();
            /*0x2801ae0*/ float get_weight();
            /*0x2801b1c*/ void set_weight(float value);
            /*0x2801b68*/ UnityEngine.Vector3 get_translationAtRest();
            /*0x2801c08*/ void set_translationAtRest(UnityEngine.Vector3 value);
            /*0x2801ca0*/ UnityEngine.Vector3 get_translationOffset();
            /*0x2801d40*/ void set_translationOffset(UnityEngine.Vector3 value);
            /*0x2801dd8*/ UnityEngine.Animations.Axis get_translationAxis();
            /*0x2801e14*/ void set_translationAxis(UnityEngine.Animations.Axis value);
            /*0x2801e58*/ bool get_constraintActive();
            /*0x2801e94*/ void set_constraintActive(bool value);
            /*0x2801ed8*/ bool get_locked();
            /*0x2801f14*/ void set_locked(bool value);
            /*0x2801f58*/ int get_sourceCount();
            /*0x2801fd0*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2802014*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x28020ec*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x2802180*/ void RemoveSource(int index);
            /*0x2802344*/ void RemoveSourceInternal(int index);
            /*0x2802388*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x28023b0*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x2802460*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x28024a0*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x28021c8*/ void ValidateSourceIndex(int index);
            /*0x2801bc4*/ void get_translationAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x2801c5c*/ void set_translationAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x2801cfc*/ void get_translationOffset_Injected(ref UnityEngine.Vector3 ret);
            /*0x2801d94*/ void set_translationOffset_Injected(ref UnityEngine.Vector3 value);
            /*0x280213c*/ int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source);
            /*0x280240c*/ void GetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource ret);
            /*0x28024f8*/ void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source);
        }

        class RotationConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x2802590*/ void Internal_Create(UnityEngine.Animations.RotationConstraint self);
            static /*0x2802a80*/ int GetSourceCountInternal(UnityEngine.Animations.RotationConstraint self);
            static /*0x2802b94*/ void SetSourcesInternal(UnityEngine.Animations.RotationConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x280254c*/ RotationConstraint();
            /*0x28025cc*/ float get_weight();
            /*0x2802608*/ void set_weight(float value);
            /*0x2802654*/ UnityEngine.Vector3 get_rotationAtRest();
            /*0x28026f4*/ void set_rotationAtRest(UnityEngine.Vector3 value);
            /*0x280278c*/ UnityEngine.Vector3 get_rotationOffset();
            /*0x280282c*/ void set_rotationOffset(UnityEngine.Vector3 value);
            /*0x28028c4*/ UnityEngine.Animations.Axis get_rotationAxis();
            /*0x2802900*/ void set_rotationAxis(UnityEngine.Animations.Axis value);
            /*0x2802944*/ bool get_constraintActive();
            /*0x2802980*/ void set_constraintActive(bool value);
            /*0x28029c4*/ bool get_locked();
            /*0x2802a00*/ void set_locked(bool value);
            /*0x2802a44*/ int get_sourceCount();
            /*0x2802abc*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2802b00*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2802bd8*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x2802c6c*/ void RemoveSource(int index);
            /*0x2802e30*/ void RemoveSourceInternal(int index);
            /*0x2802e74*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x2802e9c*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x2802f4c*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x2802f8c*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x2802cb4*/ void ValidateSourceIndex(int index);
            /*0x28026b0*/ void get_rotationAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x2802748*/ void set_rotationAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x28027e8*/ void get_rotationOffset_Injected(ref UnityEngine.Vector3 ret);
            /*0x2802880*/ void set_rotationOffset_Injected(ref UnityEngine.Vector3 value);
            /*0x2802c28*/ int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source);
            /*0x2802ef8*/ void GetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource ret);
            /*0x2802fe4*/ void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source);
        }

        class ScaleConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x280307c*/ void Internal_Create(UnityEngine.Animations.ScaleConstraint self);
            static /*0x280356c*/ int GetSourceCountInternal(UnityEngine.Animations.ScaleConstraint self);
            static /*0x2803680*/ void SetSourcesInternal(UnityEngine.Animations.ScaleConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x2803038*/ ScaleConstraint();
            /*0x28030b8*/ float get_weight();
            /*0x28030f4*/ void set_weight(float value);
            /*0x2803140*/ UnityEngine.Vector3 get_scaleAtRest();
            /*0x28031e0*/ void set_scaleAtRest(UnityEngine.Vector3 value);
            /*0x2803278*/ UnityEngine.Vector3 get_scaleOffset();
            /*0x2803318*/ void set_scaleOffset(UnityEngine.Vector3 value);
            /*0x28033b0*/ UnityEngine.Animations.Axis get_scalingAxis();
            /*0x28033ec*/ void set_scalingAxis(UnityEngine.Animations.Axis value);
            /*0x2803430*/ bool get_constraintActive();
            /*0x280346c*/ void set_constraintActive(bool value);
            /*0x28034b0*/ bool get_locked();
            /*0x28034ec*/ void set_locked(bool value);
            /*0x2803530*/ int get_sourceCount();
            /*0x28035a8*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x28035ec*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x28036c4*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x2803758*/ void RemoveSource(int index);
            /*0x280391c*/ void RemoveSourceInternal(int index);
            /*0x2803960*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x2803988*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x2803a38*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x2803a78*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x28037a0*/ void ValidateSourceIndex(int index);
            /*0x280319c*/ void get_scaleAtRest_Injected(ref UnityEngine.Vector3 ret);
            /*0x2803234*/ void set_scaleAtRest_Injected(ref UnityEngine.Vector3 value);
            /*0x28032d4*/ void get_scaleOffset_Injected(ref UnityEngine.Vector3 ret);
            /*0x280336c*/ void set_scaleOffset_Injected(ref UnityEngine.Vector3 value);
            /*0x2803714*/ int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source);
            /*0x28039e4*/ void GetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource ret);
            /*0x2803ad0*/ void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source);
        }

        struct AnimationMotionXToDeltaPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x28040ec*/ AnimationMotionXToDeltaPlayable();
            static /*0x2803b24*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable get_Null();
            static /*0x2803b7c*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph);
            static /*0x2803c0c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph);
            static /*0x2803e44*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable);
            static /*0x2803e74*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x2803dac*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x2803fa4*/ bool IsAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x2804064*/ void SetAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x28040a8*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x2803cec*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x2803e38*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x2803eb8*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
            /*0x2803f30*/ bool IsAbsoluteMotion();
            /*0x2803fe0*/ void SetAbsoluteMotion(bool value);
        }

        struct AnimationMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x28045b8*/ AnimationMixerPlayable();
            static /*0x2804188*/ UnityEngine.Animations.AnimationMixerPlayable get_Null();
            static /*0x28041e0*/ UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool normalizeWeights);
            static /*0x27f12e0*/ UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x280424c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x2804488*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable);
            static /*0x28044b8*/ UnityEngine.Animations.AnimationMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x28043f0*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x2804574*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x2804330*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x280447c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x28044fc*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
        }

        enum AnimatorBindingsVersion
        {
            kInvalidNotNative = 0,
            kInvalidUnresolved = 1,
            kValidMinVersion = 2,
        }

        struct AnimationStream
        {
            static int InvalidIndex = -1;
            /*0x10*/ uint m_AnimatorBindingsVersion;
            /*0x18*/ nint constant;
            /*0x20*/ nint input;
            /*0x28*/ nint output;
            /*0x30*/ nint workspace;
            /*0x38*/ nint inputStreamAccessor;
            /*0x40*/ nint animationHandleBinder;

            static /*0x2804f3c*/ void CopyAnimationStreamMotionInternal_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Animations.AnimationStream animationStream);
            static /*0x2804f80*/ float GetDeltaTime_Injected(ref UnityEngine.Animations.AnimationStream _unity_self);
            static /*0x2804fbc*/ bool GetIsHumanStream_Injected(ref UnityEngine.Animations.AnimationStream _unity_self);
            static /*0x2804ff8*/ void GetVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x280503c*/ void SetVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 velocity);
            static /*0x2805080*/ void GetAngularVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x28050c4*/ void SetAngularVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 velocity);
            static /*0x2805108*/ void GetRootMotionPosition_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x280514c*/ void GetRootMotionRotation_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Quaternion ret);
            static /*0x2805190*/ int GetInputStreamCount_Injected(ref UnityEngine.Animations.AnimationStream _unity_self);
            static /*0x28051cc*/ void InternalGetInputStream_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, int index, ref UnityEngine.Animations.AnimationStream ret);
            static /*0x2805220*/ float InternalGetInputWeight_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, int index);
            static /*0x2805264*/ void GetHumanStream_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Animations.AnimationHumanStream ret);
            static /*0x28052a8*/ void InternalReadSceneTransforms_Injected(ref UnityEngine.Animations.AnimationStream _unity_self);
            static /*0x28052e4*/ void InternalWriteSceneTransforms_Injected(ref UnityEngine.Animations.AnimationStream _unity_self);
            /*0x27f8248*/ uint get_animatorBindingsVersion();
            /*0x27f812c*/ bool get_isValid();
            /*0x27f83e0*/ void CheckIsValid();
            /*0x2804654*/ float get_deltaTime();
            /*0x28046d0*/ UnityEngine.Vector3 get_velocity();
            /*0x2804744*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x28047d8*/ UnityEngine.Vector3 get_angularVelocity();
            /*0x280484c*/ void set_angularVelocity(UnityEngine.Vector3 value);
            /*0x28048e0*/ UnityEngine.Vector3 get_rootMotionPosition();
            /*0x2804954*/ UnityEngine.Quaternion get_rootMotionRotation();
            /*0x28049c4*/ bool get_isHumanStream();
            /*0x2804a40*/ UnityEngine.Animations.AnimationHumanStream AsHuman();
            /*0x2804b54*/ int get_inputStreamCount();
            /*0x2804bd0*/ UnityEngine.Animations.AnimationStream GetInputStream(int index);
            /*0x2804d00*/ float GetInputWeight(int index);
            /*0x2804d8c*/ void CopyAnimationStreamMotion(UnityEngine.Animations.AnimationStream animationStream);
            /*0x2804e44*/ void ReadSceneTransforms();
            /*0x2804ec0*/ void WriteSceneTransforms();
            /*0x2804e00*/ void CopyAnimationStreamMotionInternal(UnityEngine.Animations.AnimationStream animationStream);
            /*0x2804694*/ float GetDeltaTime();
            /*0x2804a04*/ bool GetIsHumanStream();
            /*0x28046e8*/ UnityEngine.Vector3 GetVelocity();
            /*0x2804784*/ void SetVelocity(UnityEngine.Vector3 velocity);
            /*0x28047f0*/ UnityEngine.Vector3 GetAngularVelocity();
            /*0x280488c*/ void SetAngularVelocity(UnityEngine.Vector3 velocity);
            /*0x28048f8*/ UnityEngine.Vector3 GetRootMotionPosition();
            /*0x280496c*/ UnityEngine.Quaternion GetRootMotionRotation();
            /*0x2804b94*/ int GetInputStreamCount();
            /*0x2804c78*/ UnityEngine.Animations.AnimationStream InternalGetInputStream(int index);
            /*0x2804d48*/ float InternalGetInputWeight(int index);
            /*0x2804b08*/ UnityEngine.Animations.AnimationHumanStream GetHumanStream();
            /*0x2804e84*/ void InternalReadSceneTransforms();
            /*0x2804f00*/ void InternalWriteSceneTransforms();
        }

        struct AnimationPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x27f0fc8*/ UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.Animator target);
            static /*0x2805320*/ UnityEngine.Animations.AnimationPlayableOutput get_Null();
            static /*0x28054a0*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output);
            static /*0x28054d0*/ UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x2805550*/ UnityEngine.Animator InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x280558c*/ void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle, UnityEngine.Animator target);
            /*0x280539c*/ AnimationPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x27f169c*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x2805514*/ UnityEngine.Animator GetTarget();
            /*0x280545c*/ void SetTarget(UnityEngine.Animator value);
        }

        interface IAnimationJob
        {
            void ProcessAnimation(UnityEngine.Animations.AnimationStream stream);
            void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream);
        }

        interface IAnimationJobPlayable : UnityEngine.Playables.IPlayable
        {
            T GetJobData<T>();
            void SetJobData<T>(T jobData);
        }

        interface IAnimationWindowPreview
        {
            void StartPreview();
            void StopPreview();
            void UpdatePreviewGraph(UnityEngine.Playables.PlayableGraph graph);
            UnityEngine.Playables.Playable BuildPreviewGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable inputPlayable);
        }

        class DiscreteEvaluationAttribute : System.Attribute
        {
            /*0x28055d0*/ DiscreteEvaluationAttribute();
        }

        enum JobMethodIndex
        {
            ProcessRootMotionMethodIndex = 0,
            ProcessAnimationMethodIndex = 1,
            MethodIndexCount = 2,
        }

        struct ProcessAnimationJobStruct<T>
        {
            static /*0x0*/ nint jobReflectionData;

            static nint GetJobReflectionData();
            static void Execute(ref T data, nint animationStreamPtr, nint methodIndex, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

            class ExecuteJobFunction<T> : System.MulticastDelegate
            {
                ExecuteJobFunction(object object, nint method);
                void Invoke(ref T data, nint animationStreamPtr, nint unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
            }
        }

        class NotKeyableAttribute : System.Attribute
        {
            /*0x28055d8*/ NotKeyableAttribute();
        }

        class AnimationPlayableBinding
        {
            static /*0x28055e0*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key);
            static /*0x280571c*/ UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }
    }
}
