class <Module>
{
}

namespace UnityEngine
{
    namespace Timeline
    {
        class ActivationMixerPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;
            /*0x14*/ bool m_BoundGameObjectInitialStateIsActive;
            /*0x18*/ UnityEngine.GameObject m_BoundGameObject;

            static /*0x27afb00*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationMixerPlayable> Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            /*0x27afe18*/ ActivationMixerPlayable();
            /*0x27afb84*/ UnityEngine.Timeline.ActivationTrack.PostPlaybackState get_postPlaybackState();
            /*0x27afb8c*/ void set_postPlaybackState(UnityEngine.Timeline.ActivationTrack.PostPlaybackState value);
            /*0x27afb94*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x27afc54*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
        }

        class ActivationPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
        {
            /*0x27afe94*/ ActivationPlayableAsset();
            /*0x27afe20*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x27afe28*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
        }

        class ActivationTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0xa0*/ UnityEngine.Timeline.ActivationTrack.PostPlaybackState m_PostPlaybackState;
            /*0xa8*/ UnityEngine.Timeline.ActivationMixerPlayable m_ActivationMixer;

            /*0x27b03b4*/ ActivationTrack();
            /*0x27afe9c*/ bool CanCompileClips();
            /*0x27affa8*/ UnityEngine.Timeline.ActivationTrack.PostPlaybackState get_postPlaybackState();
            /*0x27affb0*/ void set_postPlaybackState(UnityEngine.Timeline.ActivationTrack.PostPlaybackState value);
            /*0x27affd8*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x27affc4*/ void UpdateTrackMode();
            /*0x27b00bc*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x27b0360*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);

            enum PostPlaybackState
            {
                Active = 0,
                Inactive = 1,
                Revert = 2,
                LeaveAsIs = 3,
            }
        }

        class AnimationOutputWeightProcessor : UnityEngine.Timeline.ITimelineEvaluateCallback
        {
            /*0x10*/ UnityEngine.Animations.AnimationPlayableOutput m_Output;
            /*0x20*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_MotionXPlayable;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo> m_Mixers;

            /*0x27b04e0*/ AnimationOutputWeightProcessor(UnityEngine.Animations.AnimationPlayableOutput output);
            /*0x27b05a0*/ void FindMixers();
            /*0x27b0688*/ void FindMixers(UnityEngine.Playables.Playable parent, int port, UnityEngine.Playables.Playable node);
            /*0x27b0950*/ void Evaluate();

            struct WeightInfo
            {
                /*0x10*/ UnityEngine.Playables.Playable mixer;
                /*0x20*/ UnityEngine.Playables.Playable parentMixer;
                /*0x30*/ int port;
            }
        }

        class AnimationPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.IPropertyPreview, UnityEngine.ISerializationCallbackReceiver
        {
            static /*0x0*/ int k_LatestVersion;
            /*0x18*/ UnityEngine.AnimationClip m_Clip;
            /*0x20*/ UnityEngine.Vector3 m_Position;
            /*0x2c*/ UnityEngine.Vector3 m_EulerAngles;
            /*0x38*/ bool m_UseTrackMatchFields;
            /*0x3c*/ UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;
            /*0x40*/ bool m_RemoveStartOffset;
            /*0x41*/ bool m_ApplyFootIK;
            /*0x44*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode m_Loop;
            /*0x48*/ UnityEngine.Timeline.AppliedOffsetMode <appliedOffsetMode>k__BackingField;
            /*0x4c*/ int m_Version;
            /*0x50*/ UnityEngine.Quaternion m_Rotation;

            static /*0x27b1868*/ AnimationPlayableAsset();
            static /*0x27b0fc8*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, bool removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, bool applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop);
            static /*0x27b13b0*/ bool ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip);
            static /*0x27b1390*/ bool ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x27b0c1c*/ bool HasRootTransforms(UnityEngine.AnimationClip clip);
            /*0x27b1764*/ AnimationPlayableAsset();
            /*0x27b0a8c*/ UnityEngine.Vector3 get_position();
            /*0x27b0a98*/ void set_position(UnityEngine.Vector3 value);
            /*0x27b0aa4*/ UnityEngine.Quaternion get_rotation();
            /*0x27b0ac8*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x27b0b04*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x27b0b10*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x27b0b1c*/ bool get_useTrackMatchFields();
            /*0x27b0b24*/ void set_useTrackMatchFields(bool value);
            /*0x27b0b30*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x27b0b38*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x27b0b40*/ bool get_removeStartOffset();
            /*0x27b0b48*/ void set_removeStartOffset(bool value);
            /*0x27b0b54*/ bool get_applyFootIK();
            /*0x27b0b5c*/ void set_applyFootIK(bool value);
            /*0x27b0b68*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_loop();
            /*0x27b0b70*/ void set_loop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x27b0b78*/ bool get_hasRootTransforms();
            /*0x27b0ce8*/ UnityEngine.Timeline.AppliedOffsetMode get_appliedOffsetMode();
            /*0x27b0cf0*/ void set_appliedOffsetMode(UnityEngine.Timeline.AppliedOffsetMode value);
            /*0x27b0cf8*/ UnityEngine.AnimationClip get_clip();
            /*0x27b0d00*/ void set_clip(UnityEngine.AnimationClip value);
            /*0x27b0dc0*/ double get_duration();
            /*0x27b0e44*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27b0ef0*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x27b1424*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x27b150c*/ void ResetOffsets();
            /*0x27b1578*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x27b1624*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x27b1684*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x27b1708*/ void OnUpgradeFromVersion(int oldVersion);

            enum LoopMode
            {
                UseSourceAsset = 0,
                On = 1,
                Off = 2,
            }

            enum Versions
            {
                Initial = 0,
                RotationAsEuler = 1,
            }

            class AnimationPlayableAssetUpgrade
            {
                static /*0x27b1718*/ void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset);
            }

            class <get_outputs>d__45 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationPlayableAsset <>4__this;

                /*0x27b0ebc*/ <get_outputs>d__45(int <>1__state);
                /*0x27b18b4*/ void System.IDisposable.Dispose();
                /*0x27b18b8*/ bool MoveNext();
                /*0x27b1948*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x27b1958*/ void System.Collections.IEnumerator.Reset();
                /*0x27b1998*/ object System.Collections.IEnumerator.get_Current();
                /*0x27b19f8*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x27b1a9c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class AnimationPreviewUpdateCallback : UnityEngine.Timeline.ITimelineEvaluateCallback
        {
            /*0x10*/ UnityEngine.Animations.AnimationPlayableOutput m_Output;
            /*0x20*/ UnityEngine.Playables.PlayableGraph m_Graph;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Animations.IAnimationWindowPreview> m_PreviewComponents;

            /*0x27b1aa0*/ AnimationPreviewUpdateCallback(UnityEngine.Animations.AnimationPlayableOutput output);
            /*0x27b1b68*/ void Evaluate();
            /*0x27b1d40*/ void FetchPreviewComponents();
        }

        enum MatchTargetFields
        {
            PositionX = 1,
            PositionY = 2,
            PositionZ = 4,
            RotationX = 8,
            RotationY = 16,
            RotationZ = 32,
        }

        enum TrackOffset
        {
            ApplyTransformOffsets = 0,
            ApplySceneOffsets = 1,
            Auto = 2,
        }

        enum AppliedOffsetMode
        {
            NoRootTransform = 0,
            TransformOffset = 1,
            SceneOffset = 2,
            TransformOffsetLegacy = 3,
            SceneOffsetLegacy = 4,
            SceneOffsetEditor = 5,
            SceneOffsetLegacyEditor = 6,
        }

        class MatchTargetFieldConstants
        {
            static /*0x0*/ UnityEngine.Timeline.MatchTargetFields All;
            static /*0x4*/ UnityEngine.Timeline.MatchTargetFields None;
            static /*0x8*/ UnityEngine.Timeline.MatchTargetFields Position;
            static /*0xc*/ UnityEngine.Timeline.MatchTargetFields Rotation;

            static /*0x27b1ee0*/ MatchTargetFieldConstants();
            static /*0x27b1e64*/ bool HasAny(UnityEngine.Timeline.MatchTargetFields me, UnityEngine.Timeline.MatchTargetFields fields);
            static /*0x27b1ed8*/ UnityEngine.Timeline.MatchTargetFields Toggle(UnityEngine.Timeline.MatchTargetFields me, UnityEngine.Timeline.MatchTargetFields flag);
        }

        class AnimationTrack : UnityEngine.Timeline.TrackAsset, UnityEngine.Timeline.ILayerable
        {
            static string k_DefaultInfiniteClipName = "Recorded";
            static string k_DefaultRecordableClipName = "Recorded";
            static /*0x0*/ System.Collections.Generic.Queue<UnityEngine.Transform> s_CachedQueue;
            /*0xa0*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;
            /*0xa4*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;
            /*0xa8*/ UnityEngine.Vector3 m_InfiniteClipOffsetPosition;
            /*0xb4*/ UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles;
            /*0xc0*/ double m_InfiniteClipTimeOffset;
            /*0xc8*/ bool m_InfiniteClipRemoveOffset;
            /*0xc9*/ bool m_InfiniteClipApplyFootIK;
            /*0xcc*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode mInfiniteClipLoop;
            /*0xd0*/ UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;
            /*0xd4*/ UnityEngine.Vector3 m_Position;
            /*0xe0*/ UnityEngine.Vector3 m_EulerAngles;
            /*0xf0*/ UnityEngine.AvatarMask m_AvatarMask;
            /*0xf8*/ bool m_ApplyAvatarMask;
            /*0xfc*/ UnityEngine.Timeline.TrackOffset m_TrackOffset;
            /*0x100*/ UnityEngine.AnimationClip m_InfiniteClip;
            /*0x108*/ UnityEngine.Quaternion m_OpenClipOffsetRotation;
            /*0x118*/ UnityEngine.Quaternion m_Rotation;
            /*0x128*/ bool m_ApplyOffsets;

            static /*0x27b61a0*/ AnimationTrack();
            static /*0x27b4cc0*/ bool UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x27b47c0*/ UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            static /*0x27b5c30*/ UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, string name);
            /*0x27b6010*/ AnimationTrack();
            /*0x27b1f30*/ UnityEngine.Vector3 get_position();
            /*0x27b1f3c*/ void set_position(UnityEngine.Vector3 value);
            /*0x27b1f48*/ UnityEngine.Quaternion get_rotation();
            /*0x27b1f6c*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x27b1fa8*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x27b1fb4*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x27b1fc0*/ bool get_applyOffsets();
            /*0x27b1fc8*/ void set_applyOffsets(bool value);
            /*0x27b1fcc*/ UnityEngine.Timeline.TrackOffset get_trackOffset();
            /*0x27b1fd4*/ void set_trackOffset(UnityEngine.Timeline.TrackOffset value);
            /*0x27b1fdc*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x27b1fe4*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x27b2054*/ UnityEngine.AnimationClip get_infiniteClip();
            /*0x27b205c*/ void set_infiniteClip(UnityEngine.AnimationClip value);
            /*0x27b2064*/ bool get_infiniteClipRemoveOffset();
            /*0x27b206c*/ void set_infiniteClipRemoveOffset(bool value);
            /*0x27b2078*/ UnityEngine.AvatarMask get_avatarMask();
            /*0x27b2080*/ void set_avatarMask(UnityEngine.AvatarMask value);
            /*0x27b2088*/ bool get_applyAvatarMask();
            /*0x27b2090*/ void set_applyAvatarMask(bool value);
            /*0x27b209c*/ bool CanCompileClips();
            /*0x27b2158*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27b2204*/ bool get_inClipMode();
            /*0x27b22e8*/ UnityEngine.Vector3 get_infiniteClipOffsetPosition();
            /*0x27b22f4*/ void set_infiniteClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x27b2300*/ UnityEngine.Quaternion get_infiniteClipOffsetRotation();
            /*0x27b2324*/ void set_infiniteClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x27b2360*/ UnityEngine.Vector3 get_infiniteClipOffsetEulerAngles();
            /*0x27b236c*/ void set_infiniteClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x27b2378*/ bool get_infiniteClipApplyFootIK();
            /*0x27b2380*/ void set_infiniteClipApplyFootIK(bool value);
            /*0x27b238c*/ double get_infiniteClipTimeOffset();
            /*0x27b2394*/ void set_infiniteClipTimeOffset(double value);
            /*0x27b239c*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation();
            /*0x27b23a4*/ void set_infiniteClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x27b23ac*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation();
            /*0x27b23b4*/ void set_infiniteClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x27b23bc*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_infiniteClipLoop();
            /*0x27b23c4*/ void set_infiniteClipLoop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x27b23cc*/ void ResetOffsets();
            /*0x27b243c*/ UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip);
            /*0x27b2738*/ void CreateInfiniteClip(string infiniteClipName);
            /*0x27b283c*/ UnityEngine.Timeline.TimelineClip CreateRecordableClip(string animClipName);
            /*0x27b2b2c*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x27b2cf4*/ int CalculateItemsHash();
            /*0x27b2438*/ void UpdateClipOffsets();
            /*0x27b2edc*/ UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x27b38f8*/ UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x27b3948*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x27b47b8*/ int GetDefaultBlendCount();
            /*0x27b4cbc*/ void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, bool requireOffset);
            /*0x27b4cd8*/ UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x27b4bac*/ bool RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject);
            /*0x27b5014*/ bool HasController(UnityEngine.GameObject gameObject);
            /*0x27b4e30*/ UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x27b4830*/ UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x27b3740*/ UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x27b5160*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x27b5458*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x27b24e4*/ void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip);
            /*0x27b56c8*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x27b56cc*/ void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips);
            /*0x27b4748*/ UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, bool animatesRootTransform);
            /*0x27b44cc*/ bool IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode);
            /*0x27b42e4*/ UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject);
            /*0x27b335c*/ bool AnimatesRootTransform();
            /*0x27b5e08*/ UnityEngine.Vector3 get_openClipOffsetPosition();
            /*0x27b5e14*/ void set_openClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x27b5e20*/ UnityEngine.Quaternion get_openClipOffsetRotation();
            /*0x27b5e44*/ void set_openClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x27b5e48*/ UnityEngine.Vector3 get_openClipOffsetEulerAngles();
            /*0x27b5e54*/ void set_openClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x27b5e60*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPreExtrapolation();
            /*0x27b5e68*/ void set_openClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x27b5e70*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPostExtrapolation();
            /*0x27b5e78*/ void set_openClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x27b5e80*/ void OnUpgradeFromVersion(int oldVersion);

            class AnimationTrackUpgrade
            {
                static /*0x27b5ed0*/ void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track);
                static /*0x27b5f6c*/ void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track);
                static /*0x27b5ff0*/ void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track);
            }

            class <get_outputs>d__49 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationTrack <>4__this;

                /*0x27b21d0*/ <get_outputs>d__49(int <>1__state);
                /*0x27b6230*/ void System.IDisposable.Dispose();
                /*0x27b6234*/ bool MoveNext();
                /*0x27b62c4*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x27b62d4*/ void System.Collections.IEnumerator.Reset();
                /*0x27b6314*/ object System.Collections.IEnumerator.get_Current();
                /*0x27b6374*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x27b6418*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        interface ICurvesOwner
        {
            UnityEngine.AnimationClip get_curves();
            bool get_hasCurves();
            double get_duration();
            void CreateCurves(string curvesClipName);
            string get_defaultCurvesName();
            UnityEngine.Object get_asset();
            UnityEngine.Object get_assetOwner();
            UnityEngine.Timeline.TrackAsset get_targetTrack();
        }

        class TimelineClip : UnityEngine.Timeline.ICurvesOwner, UnityEngine.ISerializationCallbackReceiver
        {
            static int k_LatestVersion = 1;
            static /*0x0*/ UnityEngine.Timeline.ClipCaps kDefaultClipCaps;
            static /*0x4*/ float kDefaultClipDurationInSeconds;
            static /*0x8*/ double kTimeScaleMin;
            static /*0x10*/ double kTimeScaleMax;
            static /*0x18*/ string kDefaultCurvesName;
            static /*0x20*/ double kMinDuration;
            static /*0x28*/ double kMaxTimeValue;
            /*0x10*/ int m_Version;
            /*0x18*/ double m_Start;
            /*0x20*/ double m_ClipIn;
            /*0x28*/ UnityEngine.Object m_Asset;
            /*0x30*/ double m_Duration;
            /*0x38*/ double m_TimeScale;
            /*0x40*/ UnityEngine.Timeline.TrackAsset m_ParentTrack;
            /*0x48*/ double m_EaseInDuration;
            /*0x50*/ double m_EaseOutDuration;
            /*0x58*/ double m_BlendInDuration;
            /*0x60*/ double m_BlendOutDuration;
            /*0x68*/ UnityEngine.AnimationCurve m_MixInCurve;
            /*0x70*/ UnityEngine.AnimationCurve m_MixOutCurve;
            /*0x78*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendInCurveMode;
            /*0x7c*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendOutCurveMode;
            /*0x80*/ System.Collections.Generic.List<string> m_ExposedParameterNames;
            /*0x88*/ UnityEngine.AnimationClip m_AnimationCurves;
            /*0x90*/ bool m_Recordable;
            /*0x94*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PostExtrapolationMode;
            /*0x98*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PreExtrapolationMode;
            /*0xa0*/ double m_PostExtrapolationTime;
            /*0xa8*/ double m_PreExtrapolationTime;
            /*0xb0*/ string m_DisplayName;

            static /*0x27b84ac*/ TimelineClip();
            static /*0x27b74ac*/ UnityEngine.AnimationCurve GetDefaultMixInCurve();
            static /*0x27b75bc*/ UnityEngine.AnimationCurve GetDefaultMixOutCurve();
            static /*0x27b68b0*/ double SanitizeTimeValue(double value, double defaultValue);
            static /*0x27b7bf0*/ double GetExtrapolatedTime(double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, double duration);
            static /*0x27b83e0*/ double CalculateEasingRatio(double easeIn, double easeOut);
            /*0x27b6490*/ TimelineClip(UnityEngine.Timeline.TrackAsset parent);
            /*0x27b641c*/ void UpgradeToLatestVersion();
            /*0x27b65c0*/ bool get_hasPreExtrapolation();
            /*0x27b65e0*/ bool get_hasPostExtrapolation();
            /*0x27b6600*/ double get_timeScale();
            /*0x27b67c8*/ void set_timeScale(double value);
            /*0x27b68a8*/ double get_start();
            /*0x27b297c*/ void set_start(double value);
            /*0x27b6a50*/ double get_duration();
            /*0x27b2a80*/ void set_duration(double value);
            /*0x27b6a58*/ double get_end();
            /*0x27b6a68*/ double get_clipIn();
            /*0x27b6a88*/ void set_clipIn(double value);
            /*0x27b6b60*/ string get_displayName();
            /*0x27b6b68*/ void set_displayName(string value);
            /*0x27b6b70*/ double get_clipAssetDuration();
            /*0x27b6c30*/ UnityEngine.AnimationClip get_curves();
            /*0x27b6c38*/ void set_curves(UnityEngine.AnimationClip value);
            /*0x27b6c40*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x27b6c98*/ bool get_hasCurves();
            /*0x27b6d24*/ UnityEngine.Object get_asset();
            /*0x27b6d2c*/ void set_asset(UnityEngine.Object value);
            /*0x27b6d34*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x27b6d3c*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x27b6d44*/ UnityEngine.Object get_underlyingAsset();
            /*0x27b6d4c*/ void set_underlyingAsset(UnityEngine.Object value);
            /*0x27b6d50*/ UnityEngine.Timeline.TrackAsset get_parentTrack();
            /*0x27b6d58*/ void set_parentTrack(UnityEngine.Timeline.TrackAsset value);
            /*0x27b6d5c*/ UnityEngine.Timeline.TrackAsset GetParentTrack();
            /*0x27b64cc*/ void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack);
            /*0x27b6e98*/ double get_easeInDuration();
            /*0x27b6f80*/ void set_easeInDuration(double value);
            /*0x27b7078*/ double get_easeOutDuration();
            /*0x27b7160*/ void set_easeOutDuration(double value);
            /*0x27b7258*/ double get_eastOutTime();
            /*0x27b7284*/ double get_easeOutTime();
            /*0x27b72b0*/ double get_blendInDuration();
            /*0x27b72d0*/ void set_blendInDuration(double value);
            /*0x27b7358*/ double get_blendOutDuration();
            /*0x27b7378*/ void set_blendOutDuration(double value);
            /*0x27b7400*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode get_blendInCurveMode();
            /*0x27b7408*/ void set_blendInCurveMode(UnityEngine.Timeline.TimelineClip.BlendCurveMode value);
            /*0x27b7410*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode get_blendOutCurveMode();
            /*0x27b7418*/ void set_blendOutCurveMode(UnityEngine.Timeline.TimelineClip.BlendCurveMode value);
            /*0x27b7134*/ bool get_hasBlendIn();
            /*0x27b6f54*/ bool get_hasBlendOut();
            /*0x27b7420*/ UnityEngine.AnimationCurve get_mixInCurve();
            /*0x27b74c4*/ void set_mixInCurve(UnityEngine.AnimationCurve value);
            /*0x27b74cc*/ float get_mixInPercentage();
            /*0x27b74ec*/ double get_mixInDuration();
            /*0x27b7530*/ UnityEngine.AnimationCurve get_mixOutCurve();
            /*0x27b75d4*/ void set_mixOutCurve(UnityEngine.AnimationCurve value);
            /*0x27b75dc*/ double get_mixOutTime();
            /*0x27b7608*/ double get_mixOutDuration();
            /*0x27b764c*/ float get_mixOutPercentage();
            /*0x27b766c*/ bool get_recordable();
            /*0x27b7674*/ void set_recordable(bool value);
            /*0x27b7680*/ System.Collections.Generic.List<string> get_exposedParameters();
            /*0x27b66d8*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x27b7700*/ int Hash();
            /*0x27b78ec*/ float EvaluateMixOut(double time);
            /*0x27b79e0*/ float EvaluateMixIn(double time);
            /*0x27b7ab4*/ double ToLocalTime(double time);
            /*0x27b7d60*/ double ToLocalTimeUnbound(double time);
            /*0x27b7db0*/ double FromLocalTimeUnbound(double time);
            /*0x27b7df4*/ UnityEngine.AnimationClip get_animationClip();
            /*0x27b7eec*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_postExtrapolationMode();
            /*0x27b2cc0*/ void set_postExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x27b7f10*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_preExtrapolationMode();
            /*0x27b2c8c*/ void set_preExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x27b7f34*/ void SetPostExtrapolationTime(double time);
            /*0x27b7f3c*/ void SetPreExtrapolationTime(double time);
            /*0x27b7f44*/ bool IsExtrapolatedTime(double sequenceTime);
            /*0x27b7ba0*/ bool IsPreExtrapolatedTime(double sequenceTime);
            /*0x27b7d08*/ bool IsPostExtrapolatedTime(double sequenceTime);
            /*0x27b7f80*/ double get_extrapolatedStart();
            /*0x27b7f98*/ double get_extrapolatedDuration();
            /*0x27b8064*/ void CreateCurves(string curvesClipName);
            /*0x27b8130*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x27b813c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x27b8174*/ string ToString();
            /*0x27b8350*/ void ConformEaseValues();
            /*0x27b68a4*/ void UpdateDirty(double oldValue, double newValue);

            enum Versions
            {
                Initial = 0,
                ClipInFromGlobalToLocal = 1,
            }

            class TimelineClipUpgrade
            {
                static /*0x27b6454*/ void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip);
            }

            enum ClipExtrapolation
            {
                None = 0,
                Hold = 1,
                Loop = 2,
                PingPong = 3,
                Continue = 4,
            }

            enum BlendCurveMode
            {
                Auto = 0,
                Manual = 1,
            }
        }

        class TimelineAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.IPropertyPreview
        {
            static int k_LatestVersion = 0;
            /*0x18*/ int m_Version;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Tracks;
            /*0x28*/ double m_FixedDuration;
            /*0x30*/ UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> m_CacheRootTracks;
            /*0x40*/ UnityEngine.Timeline.TrackAsset[] m_CacheFlattenedTracks;
            /*0x48*/ UnityEngine.Timeline.TimelineAsset.EditorSettings m_EditorSettings;
            /*0x50*/ UnityEngine.Timeline.TimelineAsset.DurationMode m_DurationMode;
            /*0x58*/ UnityEngine.Timeline.MarkerTrack m_MarkerTrack;

            static /*0x27b936c*/ double GetValidFrameRate(double frameRate);
            static /*0x27b9640*/ void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, ref System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> allTracks);
            /*0x27bb9bc*/ TimelineAsset();
            /*0x27b8530*/ void UpgradeToLatestVersion();
            /*0x27b8534*/ UnityEngine.Timeline.TimelineAsset.EditorSettings get_editorSettings();
            /*0x27b853c*/ double get_duration();
            /*0x27b87d0*/ double get_fixedDuration();
            /*0x27b88a4*/ void set_fixedDuration(double value);
            /*0x27b8914*/ UnityEngine.Timeline.TimelineAsset.DurationMode get_durationMode();
            /*0x27b891c*/ void set_durationMode(UnityEngine.Timeline.TimelineAsset.DurationMode value);
            /*0x27b8924*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27b89d0*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x27b8d38*/ int get_outputTrackCount();
            /*0x27b8f84*/ int get_rootTrackCount();
            /*0x27b9344*/ void OnValidate();
            /*0x27b9430*/ UnityEngine.Timeline.TrackAsset GetRootTrack(int index);
            /*0x27b8d20*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks();
            /*0x27b9490*/ UnityEngine.Timeline.TrackAsset GetOutputTrack(int index);
            /*0x27b94d4*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks();
            /*0x27b8fd4*/ void UpdateRootTrackCache();
            /*0x27b8d5c*/ void UpdateOutputTrackCache();
            /*0x27b94ec*/ UnityEngine.Timeline.TrackAsset[] get_flattenedTracks();
            /*0x27b998c*/ UnityEngine.Timeline.MarkerTrack get_markerTrack();
            /*0x27b9994*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_trackObjects();
            /*0x27b999c*/ void AddTrackInternal(UnityEngine.Timeline.TrackAsset track);
            /*0x27b9a60*/ void RemoveTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x27b9be4*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x27b9da8*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x27b9db0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x27b9dbc*/ void __internalAwake();
            /*0x27b9f24*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x27ba3cc*/ void CreateMarkerTrack();
            /*0x27b9a54*/ void Invalidate();
            /*0x27ba498*/ void UpdateFixedDurationWithItemsDuration();
            /*0x27b85f0*/ UnityEngine.Timeline.DiscreteTime CalculateItemsDuration();
            /*0x27ba634*/ UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, string name);
            T CreateTrack<T>(UnityEngine.Timeline.TrackAsset parent, string trackName);
            T CreateTrack<T>(string trackName);
            T CreateTrack<T>();
            /*0x27bad2c*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x27bb050*/ bool DeleteTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x27bb6dc*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x27baab4*/ UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, string trackName, System.Type trackType);
            /*0x27bb590*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track);
            /*0x27baef8*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip);

            enum Versions
            {
                Initial = 0,
            }

            class TimelineAssetUpgrade
            {
            }

            enum MediaType
            {
                Animation = 0,
                Audio = 1,
                Texture = 2,
                Video = 2,
                Script = 3,
                Hybrid = 4,
                Group = 5,
            }

            enum DurationMode
            {
                BasedOnClips = 0,
                FixedLength = 1,
            }

            class EditorSettings
            {
                static /*0x0*/ double kMinFrameRate;
                static /*0x8*/ double kMaxFrameRate;
                static /*0x10*/ double kDefaultFrameRate;
                /*0x10*/ double m_Framerate;
                /*0x18*/ bool m_ScenePreview;

                static /*0x27bbc5c*/ EditorSettings();
                /*0x27bba20*/ EditorSettings();
                /*0x27bba90*/ float get_fps();
                /*0x27bba9c*/ void set_fps(float value);
                /*0x27bbb24*/ double get_frameRate();
                /*0x27b9418*/ void set_frameRate(double value);
                /*0x27bbb2c*/ void SetStandardFrameRate(UnityEngine.Timeline.StandardFrameRates enumValue);
                /*0x27bbc48*/ bool get_scenePreview();
                /*0x27bbc50*/ void set_scenePreview(bool value);
            }

            class <get_outputs>d__27 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TimelineAsset <>4__this;
                /*0x48*/ System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TrackAsset> <>7__wrap1;
                /*0x50*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> <>7__wrap2;

                /*0x27b899c*/ <get_outputs>d__27(int <>1__state);
                /*0x27bbce0*/ void System.IDisposable.Dispose();
                /*0x27bbd98*/ bool MoveNext();
                /*0x27bc2b0*/ void <>m__Finally1();
                /*0x27bc200*/ void <>m__Finally2();
                /*0x27bc360*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x27bc370*/ void System.Collections.IEnumerator.Reset();
                /*0x27bc3b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x27bc410*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x27bc4b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TrackAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ICurvesOwner
        {
            static int k_LatestVersion = 3;
            static string kDefaultCurvesName = "Track Parameters";
            static /*0x0*/ UnityEngine.Timeline.TrackAsset.TransientBuildData s_BuildData;
            static /*0x18*/ System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> OnClipPlayableCreate;
            static /*0x20*/ System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate;
            static /*0x28*/ UnityEngine.Timeline.TrackAsset[] s_EmptyCache;
            static /*0x30*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Timeline.TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;
            /*0x18*/ int m_Version;
            /*0x20*/ UnityEngine.AnimationClip m_AnimClip;
            /*0x28*/ bool m_Locked;
            /*0x29*/ bool m_Muted;
            /*0x30*/ string m_CustomPlayableFullTypename;
            /*0x38*/ UnityEngine.AnimationClip m_Curves;
            /*0x40*/ UnityEngine.Playables.PlayableAsset m_Parent;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Children;
            /*0x50*/ int m_ItemsHash;
            /*0x58*/ UnityEngine.Timeline.TimelineClip[] m_ClipsCache;
            /*0x60*/ UnityEngine.Timeline.DiscreteTime m_Start;
            /*0x68*/ UnityEngine.Timeline.DiscreteTime m_End;
            /*0x70*/ bool m_CacheSorted;
            /*0x71*/ System.Nullable<bool> m_SupportsNotifications;
            /*0x78*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> m_ChildTrackCache;
            /*0x80*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> m_Clips;
            /*0x88*/ UnityEngine.Timeline.MarkerList m_Markers;

            static /*0x27c25d4*/ TrackAsset();
            static /*0x27bca84*/ void add_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x27bcb78*/ void remove_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x27bcc6c*/ void add_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x27bcd60*/ void remove_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x27b2d68*/ int GetAnimationClipHash(UnityEngine.AnimationClip clip);
            /*0x27b0410*/ TrackAsset();
            /*0x27bc4b8*/ void OnBeforeTrackSerialize();
            /*0x27bc4bc*/ void OnAfterTrackDeserialize();
            /*0x27bc4c0*/ void OnUpgradeFromVersion(int oldVersion);
            /*0x27bc4c4*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x27bc620*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x27bca64*/ void UpgradeToLatestVersion();
            /*0x27bce54*/ double get_start();
            /*0x27ba56c*/ double get_end();
            /*0x27bcfc0*/ double get_duration();
            /*0x27bd028*/ bool get_muted();
            /*0x27bd030*/ void set_muted(bool value);
            /*0x27ba240*/ bool get_mutedInHierarchy();
            /*0x27ba948*/ UnityEngine.Timeline.TimelineAsset get_timelineAsset();
            /*0x27bd03c*/ UnityEngine.Playables.PlayableAsset get_parent();
            /*0x27bd044*/ void set_parent(UnityEngine.Playables.PlayableAsset value);
            /*0x27b5e04*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips();
            /*0x27b2238*/ UnityEngine.Timeline.TimelineClip[] get_clips();
            /*0x27bd04c*/ bool get_isEmpty();
            /*0x27afef8*/ bool get_hasClips();
            /*0x27bd0b8*/ bool get_hasCurves();
            /*0x27b2b6c*/ bool get_isSubTrack();
            /*0x27bd14c*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27b4730*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks();
            /*0x27bd404*/ string get_customPlayableTypename();
            /*0x27bd40c*/ void set_customPlayableTypename(string value);
            /*0x27bd414*/ UnityEngine.AnimationClip get_curves();
            /*0x27bd41c*/ void set_curves(UnityEngine.AnimationClip value);
            /*0x27bd424*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x27bd464*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_asset();
            /*0x27bd468*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x27bd46c*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x27bd470*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_subTracksObjects();
            /*0x27bd478*/ bool get_locked();
            /*0x27bd480*/ void set_locked(bool value);
            /*0x27bd48c*/ bool get_lockedInHierarchy();
            /*0x27bd618*/ bool get_supportsNotifications();
            /*0x27bd6cc*/ void __internalAwake();
            /*0x27bd798*/ void CreateCurves(string curvesClipName);
            /*0x27bd84c*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x27bd8bc*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x27bd90c*/ UnityEngine.Timeline.TimelineClip CreateDefaultClip();
            UnityEngine.Timeline.TimelineClip CreateClip<T>();
            /*0x27bdc08*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x27bdd1c*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time);
            T CreateMarker<T>(double time);
            /*0x27be028*/ bool DeleteMarker(UnityEngine.Timeline.IMarker marker);
            /*0x27bca68*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x27bd144*/ int GetMarkerCount();
            /*0x27be27c*/ UnityEngine.Timeline.IMarker GetMarker(int idx);
            /*0x27be2e4*/ UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType);
            /*0x27bdbd8*/ UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType);
            /*0x27be694*/ UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType);
            /*0x27beb1c*/ UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset);
            /*0x27be878*/ UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset);
            /*0x27beffc*/ System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw();
            /*0x27bf004*/ void ClearMarkers();
            /*0x27bf07c*/ void AddMarker(UnityEngine.ScriptableObject e);
            /*0x27bf170*/ bool DeleteMarkerRaw(UnityEngine.ScriptableObject marker);
            /*0x27bf264*/ int GetTimeRangeHash();
            /*0x27b6dc4*/ void AddClip(UnityEngine.Timeline.TimelineClip newClip);
            /*0x27bf578*/ UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable);
            /*0x27bfbc8*/ UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable);
            /*0x27c029c*/ UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x27c0820*/ void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks);
            /*0x27bf848*/ void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers);
            /*0x27c0c28*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x27c06c4*/ void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend);
            /*0x27c11d0*/ void SortClips();
            /*0x27c12f8*/ void ClearClipsInternal();
            /*0x27c1370*/ void ClearSubTracksInternal();
            /*0x27b6a48*/ void OnClipMove();
            /*0x27beda0*/ UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal();
            /*0x27bb8b8*/ void AddChild(UnityEngine.Timeline.TrackAsset child);
            /*0x27c13e8*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x27b9b68*/ bool RemoveSubTrack(UnityEngine.Timeline.TrackAsset child);
            /*0x27b6d64*/ void RemoveClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x27b51fc*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x27b5554*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x27c15f4*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x27b01e8*/ UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x27be414*/ bool ValidateClipType(System.Type clipType);
            /*0x27b03b0*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x27bceb4*/ void UpdateDuration();
            /*0x27b2e54*/ int CalculateItemsHash();
            /*0x27c1e30*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip);
            /*0x27bc9dc*/ void Invalidate();
            /*0x27b5564*/ double GetNotificationDuration();
            /*0x27aff4c*/ bool CanCompileClips();
            /*0x27c20d4*/ bool CanCreateTrackMixer();
            /*0x27c20e4*/ bool IsCompilable();
            /*0x27bd1f8*/ void UpdateChildTrackCache();
            /*0x27c24b0*/ int Hash();
            /*0x27c1cc8*/ int GetClipsHash();
            /*0x27c15d8*/ bool HasNotifications();
            /*0x27c0bf4*/ bool CanCompileNotifications();
            /*0x27bfe88*/ bool CanCreateMixerRecursive();

            enum Versions
            {
                Initial = 0,
                RotationAsEuler = 1,
                RootMotionUpgrade = 2,
                AnimatedTrackProperties = 3,
            }

            class TrackAssetUpgrade
            {
            }

            struct TransientBuildData
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> trackList;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> clipList;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markerList;

                static /*0x27c26bc*/ UnityEngine.Timeline.TrackAsset.TransientBuildData Create();
                /*0x27c01bc*/ void Clear();
            }

            class <get_outputs>d__65 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TrackAsset <>4__this;

                /*0x27bd1c4*/ <get_outputs>d__65(int <>1__state);
                /*0x27c27c8*/ void System.IDisposable.Dispose();
                /*0x27c27cc*/ bool MoveNext();
                /*0x27c2a10*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x27c2a20*/ void System.Collections.IEnumerator.Reset();
                /*0x27c2a60*/ object System.Collections.IEnumerator.get_Current();
                /*0x27c2ac0*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x27c2b64*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TrackAsset.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__121_0;

                static /*0x27c2b68*/ <>c();
                /*0x27c2bcc*/ <>c();
                /*0x27c2bd4*/ int <SortClips>b__121_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }
        }

        class TimelineHelpURLAttribute : System.Attribute
        {
            /*0x27c2c08*/ TimelineHelpURLAttribute(System.Type type);
        }

        class TrackColorAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.Color m_Color;

            /*0x27c2c1c*/ TrackColorAttribute(float r, float g, float b);
            /*0x27c2c10*/ UnityEngine.Color get_color();
        }

        class AudioClipProperties : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ float volume;

            /*0x27c2c60*/ AudioClipProperties();
        }

        class AudioMixerProperties : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ float volume;
            /*0x14*/ float stereoPan;
            /*0x18*/ float spatialBlend;

            /*0x27c2ea4*/ AudioMixerProperties();
            /*0x27c2c70*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
        }

        class AudioPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
        {
            /*0x18*/ UnityEngine.AudioClip m_Clip;
            /*0x20*/ bool m_Loop;
            /*0x24*/ float m_bufferingTime;
            /*0x28*/ UnityEngine.Timeline.AudioClipProperties m_ClipProperties;

            /*0x27c3170*/ AudioPlayableAsset();
            /*0x27c2eb4*/ float get_bufferingTime();
            /*0x27c2ebc*/ void set_bufferingTime(float value);
            /*0x27c2ec4*/ UnityEngine.AudioClip get_clip();
            /*0x27c2ecc*/ void set_clip(UnityEngine.AudioClip value);
            /*0x27c2ed4*/ bool get_loop();
            /*0x27c2edc*/ void set_loop(bool value);
            /*0x27c2ee8*/ double get_duration();
            /*0x27c2f9c*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27c3048*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x27c3164*/ UnityEngine.Timeline.ClipCaps get_clipCaps();

            class <get_outputs>d__16 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AudioPlayableAsset <>4__this;

                /*0x27c3014*/ <get_outputs>d__16(int <>1__state);
                /*0x27c31ec*/ void System.IDisposable.Dispose();
                /*0x27c31f0*/ bool MoveNext();
                /*0x27c3280*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x27c3290*/ void System.Collections.IEnumerator.Reset();
                /*0x27c32d0*/ object System.Collections.IEnumerator.get_Current();
                /*0x27c3330*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x27c33d4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class AudioTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0xa0*/ UnityEngine.Timeline.AudioMixerProperties m_TrackProperties;

            /*0x27c3cc8*/ AudioTrack();
            /*0x27c33d8*/ UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AudioClip clip);
            /*0x27c350c*/ UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x27c3bc4*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27c3c70*/ void OnValidate();

            class <get_outputs>d__4 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AudioTrack <>4__this;

                /*0x27c3c3c*/ <get_outputs>d__4(int <>1__state);
                /*0x27c3d58*/ void System.IDisposable.Dispose();
                /*0x27c3d5c*/ bool MoveNext();
                /*0x27c3dec*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x27c3dfc*/ void System.Collections.IEnumerator.Reset();
                /*0x27c3e3c*/ object System.Collections.IEnumerator.get_Current();
                /*0x27c3e9c*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x27c3f40*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        enum ClipCaps
        {
            None = 0,
            Looping = 1,
            Extrapolation = 2,
            ClipIn = 4,
            SpeedMultiplier = 8,
            Blending = 16,
            AutoScale = 40,
            All = -1,
        }

        class TimelineClipCapsExtensions
        {
            static /*0x27c3f44*/ bool SupportsLooping(UnityEngine.Timeline.TimelineClip clip);
            static /*0x27c3f5c*/ bool SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip);
            static /*0x27c3f74*/ bool SupportsClipIn(UnityEngine.Timeline.TimelineClip clip);
            static /*0x27c3f8c*/ bool SupportsSpeedMultiplier(UnityEngine.Timeline.TimelineClip clip);
            static /*0x27c3fa4*/ bool SupportsBlending(UnityEngine.Timeline.TimelineClip clip);
            static /*0x27c3fbc*/ bool HasAll(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags);
            static /*0x27b67bc*/ bool HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags);
        }

        class ControlPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ITimelineClipAsset
        {
            static int k_MaxRandInt = 10000;
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> k_EmptyParticlesList;
            static /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> s_SubEmitterCollector;
            static /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors;
            static /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.GameObject> s_CreatedPrefabs;
            /*0x18*/ UnityEngine.ExposedReference<UnityEngine.GameObject> sourceGameObject;
            /*0x28*/ UnityEngine.GameObject prefabGameObject;
            /*0x30*/ bool updateParticle;
            /*0x34*/ uint particleRandomSeed;
            /*0x38*/ bool updateDirector;
            /*0x39*/ bool updateITimeControl;
            /*0x3a*/ bool searchHierarchy;
            /*0x3b*/ bool active;
            /*0x3c*/ UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;
            /*0x40*/ UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset;
            /*0x48*/ double m_Duration;
            /*0x50*/ bool m_SupportLoop;
            /*0x51*/ bool <controllingDirectors>k__BackingField;
            /*0x52*/ bool <controllingParticles>k__BackingField;

            static /*0x27c7cc0*/ ControlPlayableAsset();
            static /*0x27c6194*/ UnityEngine.Playables.Playable ConnectPlayablesToMixer(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables);
            static /*0x27c5d68*/ void SearchHierarchyAndConnectControlableScripts(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> controlableScripts, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables);
            static /*0x27c62fc*/ void ConnectMixerAndPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixer, UnityEngine.Playables.Playable playable, int portIndex);
            static /*0x27c5cf0*/ System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> GetControlableScripts(UnityEngine.GameObject root);
            static /*0x27c6674*/ void GetControllableParticleSystems(UnityEngine.Transform t, System.Collections.Generic.ICollection<UnityEngine.ParticleSystem> roots, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters);
            static /*0x27c685c*/ void CacheSubEmitters(UnityEngine.ParticleSystem ps, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters);
            static /*0x27c6c7c*/ void PreviewParticles(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles);
            static /*0x27c70dc*/ void PreviewActivation(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.GameObject> objects);
            static /*0x27c7458*/ void PreviewTimeControl(UnityEngine.Timeline.IPropertyCollector driver, UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> scripts);
            static /*0x27c7874*/ void PreviewDirectors(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors);
            /*0x27c7c3c*/ ControlPlayableAsset();
            /*0x27c3fc8*/ bool get_controllingDirectors();
            /*0x27c3fd0*/ void set_controllingDirectors(bool value);
            /*0x27c3fdc*/ bool get_controllingParticles();
            /*0x27c3fe4*/ void set_controllingParticles(bool value);
            /*0x27c3ff0*/ void OnEnable();
            /*0x27c401c*/ double get_duration();
            /*0x27c4024*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x27c4030*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x27c52b4*/ void CreateActivationPlayable(UnityEngine.GameObject root, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables);
            /*0x27c58b8*/ void SearchHierarchyAndConnectParticleSystem(System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particleSystems, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables);
            /*0x27c540c*/ void SearchHierarchyAndConnectDirector(System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables, bool disableSelfReferences);
            System.Collections.Generic.IList<T> GetComponent<T>(UnityEngine.GameObject gameObject);
            /*0x27c49a8*/ void UpdateDurationAndLoopFlag(System.Collections.Generic.IList<UnityEngine.Playables.PlayableDirector> directors, System.Collections.Generic.IList<UnityEngine.ParticleSystem> particleSystems);
            /*0x27c4838*/ System.Collections.Generic.IList<UnityEngine.ParticleSystem> GetControllableParticleSystems(UnityEngine.GameObject go);
            /*0x27c6970*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);

            class <GetControlableScripts>d__39 : System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.MonoBehaviour <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ UnityEngine.GameObject root;
                /*0x30*/ UnityEngine.GameObject <>3__root;
                /*0x38*/ UnityEngine.MonoBehaviour[] <>7__wrap1;
                /*0x40*/ int <>7__wrap2;

                /*0x27c6634*/ <GetControlableScripts>d__39(int <>1__state);
                /*0x27c7e84*/ void System.IDisposable.Dispose();
                /*0x27c7e88*/ bool MoveNext();
                /*0x27c7fc4*/ UnityEngine.MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.get_Current();
                /*0x27c7fcc*/ void System.Collections.IEnumerator.Reset();
                /*0x27c800c*/ object System.Collections.IEnumerator.get_Current();
                /*0x27c8014*/ System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator();
                /*0x27c80b8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ControlTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x27c80bc*/ ControlTrack();
        }

        struct DiscreteTime : System.IComparable
        {
            static double k_Tick = 1e-12;
            static /*0x0*/ UnityEngine.Timeline.DiscreteTime kMaxTime;
            /*0x10*/ long m_DiscreteTime;

            static /*0x27c8890*/ DiscreteTime();
            static /*0x27c8110*/ double get_tickValue();
            static /*0x27c8418*/ UnityEngine.Timeline.DiscreteTime FromTicks(long ticks);
            static /*0x27c8194*/ long DoubleToDiscreteTime(double time);
            static /*0x27c82a0*/ long FloatToDiscreteTime(float time);
            static /*0x27c8344*/ long IntToDiscreteTime(int time);
            static /*0x27c8530*/ double ToDouble(long time);
            static /*0x27c8544*/ float ToFloat(long time);
            static /*0x27b8770*/ double op_Explicit(UnityEngine.Timeline.DiscreteTime b);
            static /*0x27c85a8*/ float op_Explicit(UnityEngine.Timeline.DiscreteTime b);
            static /*0x27c85fc*/ long op_Explicit(UnityEngine.Timeline.DiscreteTime b);
            static /*0x27b8888*/ UnityEngine.Timeline.DiscreteTime op_Explicit(double time);
            static /*0x27c8600*/ UnityEngine.Timeline.DiscreteTime op_Explicit(float time);
            static /*0x27b8738*/ UnityEngine.Timeline.DiscreteTime op_Implicit(int time);
            static /*0x27c861c*/ UnityEngine.Timeline.DiscreteTime op_Explicit(long time);
            static /*0x27c8620*/ bool op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c862c*/ bool op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c8690*/ bool op_GreaterThan(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c869c*/ bool op_LessThan(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27b8758*/ bool op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c86a8*/ bool op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c86b4*/ UnityEngine.Timeline.DiscreteTime op_Addition(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27bd020*/ UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c86fc*/ UnityEngine.Timeline.DiscreteTime Min(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27ba5cc*/ UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x27c8764*/ double SnapToNearestTick(double time);
            static /*0x27c87d4*/ float SnapToNearestTick(float time);
            static /*0x27c8834*/ long GetNearestTick(double time);
            /*0x27c811c*/ DiscreteTime(UnityEngine.Timeline.DiscreteTime time);
            /*0x27c8124*/ DiscreteTime(long time);
            /*0x27c812c*/ DiscreteTime(double time);
            /*0x27c8238*/ DiscreteTime(float time);
            /*0x27ba504*/ DiscreteTime(int time);
            /*0x27c8398*/ DiscreteTime(int frame, double fps);
            /*0x27b8764*/ UnityEngine.Timeline.DiscreteTime OneTickBefore();
            /*0x27c6668*/ UnityEngine.Timeline.DiscreteTime OneTickAfter();
            /*0x27c8410*/ long GetTick();
            /*0x27c841c*/ int CompareTo(object obj);
            /*0x27c84a8*/ bool Equals(UnityEngine.Timeline.DiscreteTime other);
            /*0x27c84b8*/ bool Equals(object obj);
            /*0x27c86bc*/ string ToString();
            /*0x27c86dc*/ int GetHashCode();
        }

        class InfiniteRuntimeClip : UnityEngine.Timeline.RuntimeElement
        {
            static /*0x0*/ long kIntervalEnd;
            /*0x18*/ UnityEngine.Playables.Playable m_Playable;

            static /*0x27c8a7c*/ InfiniteRuntimeClip();
            /*0x27b5134*/ InfiniteRuntimeClip(UnityEngine.Playables.Playable playable);
            /*0x27c88e4*/ long get_intervalStart();
            /*0x27c88ec*/ long get_intervalEnd();
            /*0x27c8944*/ void set_enable(bool value);
            /*0x27c89b8*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x27c8a10*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IInterval
        {
            long get_intervalStart();
            long get_intervalEnd();
        }

        struct IntervalTreeNode
        {
            /*0x10*/ long center;
            /*0x18*/ int first;
            /*0x1c*/ int last;
            /*0x20*/ int left;
            /*0x24*/ int right;
        }

        class IntervalTree<T>
        {
            static int kMinNodeSize = 10;
            static int kInvalidNode = -1;
            static long kCenterUnknown = 9223372036854775807;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Timeline.IntervalTree.Entry<T>> m_Entries;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Timeline.IntervalTreeNode> m_Nodes;
            /*0x0*/ bool <dirty>k__BackingField;

            IntervalTree();
            bool get_dirty();
            void set_dirty(bool value);
            void Add(T item);
            void IntersectsWith(long value, System.Collections.Generic.List<T> results);
            void IntersectsWithRange(long start, long end, System.Collections.Generic.List<T> results);
            void UpdateIntervals();
            void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long value, System.Collections.Generic.List<T> results);
            void QueryRange(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long start, long end, System.Collections.Generic.List<T> results);
            void Rebuild();
            int Rebuild(int start, int end);
            void Clear();

            struct Entry<T>
            {
                /*0x0*/ long intervalStart;
                /*0x0*/ long intervalEnd;
                /*0x0*/ T item;
            }
        }

        class RuntimeClip : UnityEngine.Timeline.RuntimeClipBase
        {
            /*0x18*/ UnityEngine.Timeline.TimelineClip m_Clip;
            /*0x20*/ UnityEngine.Playables.Playable m_Playable;
            /*0x30*/ UnityEngine.Playables.Playable m_ParentMixer;

            /*0x27b3300*/ RuntimeClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x27c8b2c*/ double get_start();
            /*0x27c8b58*/ double get_duration();
            /*0x27c8b78*/ void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x27c8bfc*/ UnityEngine.Timeline.TimelineClip get_clip();
            /*0x27c8c04*/ UnityEngine.Playables.Playable get_mixer();
            /*0x27c8c10*/ UnityEngine.Playables.Playable get_playable();
            /*0x27c8c1c*/ void set_enable(bool value);
            /*0x27c8d50*/ void SetTime(double time);
            /*0x27c8da8*/ void SetDuration(double duration);
            /*0x27c8e00*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x27c8ff8*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        class RuntimeClipBase : UnityEngine.Timeline.RuntimeElement
        {
            /*0x27c8b70*/ RuntimeClipBase();
            double get_start();
            double get_duration();
            /*0x27c9150*/ long get_intervalStart();
            /*0x27c91c0*/ long get_intervalEnd();
        }

        class RuntimeElement : UnityEngine.Timeline.IInterval
        {
            /*0x10*/ int <intervalBit>k__BackingField;

            /*0x27c88dc*/ RuntimeElement();
            long get_intervalStart();
            long get_intervalEnd();
            /*0x27c9244*/ int get_intervalBit();
            /*0x27c924c*/ void set_intervalBit(int value);
            void set_enable(bool value);
            void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        class ScheduleRuntimeClip : UnityEngine.Timeline.RuntimeClipBase
        {
            /*0x18*/ UnityEngine.Timeline.TimelineClip m_Clip;
            /*0x20*/ UnityEngine.Playables.Playable m_Playable;
            /*0x30*/ UnityEngine.Playables.Playable m_ParentMixer;
            /*0x40*/ double m_StartDelay;
            /*0x48*/ double m_FinishTail;
            /*0x50*/ bool m_Started;

            /*0x27c3b50*/ ScheduleRuntimeClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, double startDelay, double finishTail);
            /*0x27c9254*/ double get_start();
            /*0x27c92cc*/ double get_duration();
            /*0x27c9318*/ void SetTime(double time);
            /*0x27c9370*/ UnityEngine.Timeline.TimelineClip get_clip();
            /*0x27c9378*/ UnityEngine.Playables.Playable get_mixer();
            /*0x27c9384*/ UnityEngine.Playables.Playable get_playable();
            /*0x27c9390*/ void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer, double startDelay, double finishTail);
            /*0x27c9428*/ void set_enable(bool value);
            /*0x27c952c*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x27c9794*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IMarker
        {
            double get_time();
            void set_time(double value);
            UnityEngine.Timeline.TrackAsset get_parent();
            void Initialize(UnityEngine.Timeline.TrackAsset parent);
        }

        interface INotificationOptionProvider
        {
            UnityEngine.Timeline.NotificationFlags get_flags();
        }

        class Marker : UnityEngine.ScriptableObject, UnityEngine.Timeline.IMarker
        {
            /*0x18*/ double m_Time;
            /*0x20*/ UnityEngine.Timeline.TrackAsset <parent>k__BackingField;

            /*0x27c9980*/ Marker();
            /*0x27c97a4*/ UnityEngine.Timeline.TrackAsset get_parent();
            /*0x27c97ac*/ void set_parent(UnityEngine.Timeline.TrackAsset value);
            /*0x27c97b4*/ double get_time();
            /*0x27c97bc*/ void set_time(double value);
            /*0x27c982c*/ void UnityEngine.Timeline.IMarker.Initialize(UnityEngine.Timeline.TrackAsset parentTrack);
            /*0x27c997c*/ void OnInitialize(UnityEngine.Timeline.TrackAsset aPent);
        }

        struct MarkerList : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Objects;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> m_Cache;
            /*0x20*/ bool m_CacheDirty;
            /*0x21*/ bool m_HasNotifications;

            /*0x27c2500*/ MarkerList(int capacity);
            /*0x27c9988*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> get_markers();
            /*0x27bf084*/ void Add(UnityEngine.ScriptableObject item);
            /*0x27be030*/ bool Remove(UnityEngine.Timeline.IMarker item);
            /*0x27bf1a4*/ bool Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty);
            /*0x27bf00c*/ void Clear();
            /*0x27c9c78*/ bool Contains(UnityEngine.ScriptableObject item);
            /*0x27be214*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x27be22c*/ int get_Count();
            /*0x27be284*/ UnityEngine.Timeline.IMarker get_Item(int idx);
            /*0x27c9cd0*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList();
            /*0x27bdd28*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time, UnityEngine.Timeline.TrackAsset owner);
            /*0x27c24e8*/ bool HasNotifications();
            /*0x27c9cd8*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x27c9cdc*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x27c99a0*/ void BuildCache();
        }

        class MarkerTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x27c9ecc*/ MarkerTrack();
            /*0x27c9ce8*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class CustomSignalEventDrawer : UnityEngine.PropertyAttribute
        {
            /*0x27c9f20*/ CustomSignalEventDrawer();
        }

        class SignalAsset : UnityEngine.ScriptableObject
        {
            static /*0x0*/ System.Action<UnityEngine.Timeline.SignalAsset> OnEnableCallback;

            static /*0x27c9f28*/ void add_OnEnableCallback(System.Action<UnityEngine.Timeline.SignalAsset> value);
            static /*0x27c9ff4*/ void remove_OnEnableCallback(System.Action<UnityEngine.Timeline.SignalAsset> value);
            /*0x27ca12c*/ SignalAsset();
            /*0x27ca0c0*/ void OnEnable();
        }

        class SignalEmitter : UnityEngine.Timeline.Marker, UnityEngine.Playables.INotification, UnityEngine.Timeline.INotificationOptionProvider
        {
            /*0x28*/ bool m_Retroactive;
            /*0x29*/ bool m_EmitOnce;
            /*0x30*/ UnityEngine.Timeline.SignalAsset m_Asset;

            /*0x27ca248*/ SignalEmitter();
            /*0x27ca134*/ bool get_retroactive();
            /*0x27ca13c*/ void set_retroactive(bool value);
            /*0x27ca148*/ bool get_emitOnce();
            /*0x27ca150*/ void set_emitOnce(bool value);
            /*0x27ca15c*/ UnityEngine.Timeline.SignalAsset get_asset();
            /*0x27ca164*/ void set_asset(UnityEngine.Timeline.SignalAsset value);
            /*0x27ca16c*/ UnityEngine.PropertyName UnityEngine.Playables.INotification.get_id();
            /*0x27ca22c*/ UnityEngine.Timeline.NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags();
        }

        class SignalReceiver : UnityEngine.MonoBehaviour, UnityEngine.Playables.INotificationReceiver
        {
            /*0x18*/ UnityEngine.Timeline.SignalReceiver.EventKeyValue m_Events;

            /*0x27caee0*/ SignalReceiver();
            /*0x27ca250*/ void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
            /*0x27ca418*/ void AddReaction(UnityEngine.Timeline.SignalAsset asset, UnityEngine.Events.UnityEvent reaction);
            /*0x27ca680*/ int AddEmptyReaction(UnityEngine.Events.UnityEvent reaction);
            /*0x27ca6ec*/ void Remove(UnityEngine.Timeline.SignalAsset asset);
            /*0x27ca86c*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.SignalAsset> GetRegisteredSignals();
            /*0x27ca888*/ UnityEngine.Events.UnityEvent GetReaction(UnityEngine.Timeline.SignalAsset key);
            /*0x27ca8b8*/ int Count();
            /*0x27ca908*/ void ChangeSignalAtIndex(int idx, UnityEngine.Timeline.SignalAsset newKey);
            /*0x27cab60*/ void RemoveAtIndex(int idx);
            /*0x27cac98*/ void ChangeReactionAtIndex(int idx, UnityEngine.Events.UnityEvent reaction);
            /*0x27cad64*/ UnityEngine.Events.UnityEvent GetReactionAtIndex(int idx);
            /*0x27cae20*/ UnityEngine.Timeline.SignalAsset GetSignalAssetAtIndex(int idx);
            /*0x27caedc*/ void OnEnable();

            class EventKeyValue
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> m_Signals;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.UnityEvent> m_Events;

                /*0x27caf44*/ EventKeyValue();
                /*0x27ca368*/ bool TryGetValue(UnityEngine.Timeline.SignalAsset key, ref UnityEngine.Events.UnityEvent value);
                /*0x27ca558*/ void Append(UnityEngine.Timeline.SignalAsset key, UnityEngine.Events.UnityEvent value);
                /*0x27cac04*/ void Remove(int idx);
                /*0x27ca7ac*/ void Remove(UnityEngine.Timeline.SignalAsset key);
                /*0x27cb004*/ System.Collections.Generic.List<UnityEngine.Timeline.SignalAsset> get_signals();
                /*0x27cb00c*/ System.Collections.Generic.List<UnityEngine.Events.UnityEvent> get_events();
            }
        }

        class SignalTrack : UnityEngine.Timeline.MarkerTrack
        {
            /*0x27cb014*/ SignalTrack();
        }

        class TrackAssetExtensions
        {
            static /*0x27cb018*/ UnityEngine.Timeline.GroupTrack GetGroup(UnityEngine.Timeline.TrackAsset asset);
            static /*0x27cb0dc*/ void SetGroup(UnityEngine.Timeline.TrackAsset asset, UnityEngine.Timeline.GroupTrack group);
        }

        class GroupTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x27cb46c*/ GroupTrack();
            /*0x27cb40c*/ bool CanCompileClips();
            /*0x27cb414*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        interface ILayerable
        {
            UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
        }

        class ActivationControlPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.GameObject gameObject;
            /*0x18*/ UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback;
            /*0x1c*/ UnityEngine.Timeline.ActivationControlPlayable.InitialState m_InitialState;

            static /*0x27c63c4*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ActivationControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlaybackState);
            /*0x27cb7d8*/ ActivationControlPlayable();
            /*0x27cb4c0*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cb548*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cb5f0*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object userData);
            /*0x27cb678*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x27cb70c*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);

            enum PostPlaybackState
            {
                Active = 0,
                Inactive = 1,
                Revert = 2,
            }

            enum InitialState
            {
                Unset = 0,
                Active = 1,
                Inactive = 2,
            }
        }

        class BasicPlayableBehaviour : UnityEngine.ScriptableObject, UnityEngine.Playables.IPlayableAsset, UnityEngine.Playables.IPlayableBehaviour
        {
            /*0x27cb95c*/ BasicPlayableBehaviour();
            /*0x27cb7e8*/ double get_duration();
            /*0x27cb840*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x27cb898*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x27cb89c*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x27cb8a0*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x27cb8a4*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x27cb8a8*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cb8ac*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cb8b0*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cb8b4*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x27cb8b8*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
        }

        class DirectorControlPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.Playables.PlayableDirector director;
            /*0x18*/ bool m_SyncTime;
            /*0x20*/ double m_AssetDuration;

            static /*0x27c6504*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.DirectorControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableDirector director);
            /*0x27cc60c*/ DirectorControlPlayable();
            /*0x27cb964*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x27cba24*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cbed8*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cbfac*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cc0ac*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x27cbcec*/ void SyncSpeed(double speed);
            /*0x27cbe18*/ void SyncStart(UnityEngine.Playables.PlayableGraph graph, double time);
            /*0x27cc588*/ void SyncStop(UnityEngine.Playables.PlayableGraph graph, double time);
            /*0x27cbbd8*/ bool DetectDiscontinuity(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cc2ac*/ bool DetectOutOfSync(UnityEngine.Playables.Playable playable);
            /*0x27cc3f8*/ void UpdateTime(UnityEngine.Playables.Playable playable);
        }

        interface ITimeControl
        {
            void SetTime(double time);
            void OnControlTimeStart();
            void OnControlTimeStop();
        }

        enum NotificationFlags
        {
            TriggerInEditMode = 1,
            Retroactive = 2,
            TriggerOnce = 4,
        }

        class ParticleControlPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            static float kUnsetTime = 3.4028234663852886e+38;
            /*0x10*/ float m_LastPlayableTime;
            /*0x14*/ float m_LastParticleTime;
            /*0x18*/ uint m_RandomSeed;
            /*0x20*/ UnityEngine.ParticleSystem <particleSystem>k__BackingField;

            static /*0x27cd61c*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.ParticleControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component, uint randomSeed);
            static /*0x27cd7f0*/ void SetRandomSeed(UnityEngine.ParticleSystem particleSystem, uint randomSeed);
            /*0x27cdbbc*/ ParticleControlPlayable();
            /*0x27cd7e0*/ UnityEngine.ParticleSystem get_particleSystem();
            /*0x27cd7e8*/ void set_particleSystem(UnityEngine.ParticleSystem value);
            /*0x27cd760*/ void Initialize(UnityEngine.ParticleSystem ps, uint randomSeed);
            /*0x27cd92c*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data);
            /*0x27cdba4*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cdbb0*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cdae0*/ void Simulate(float time, bool restart);
        }

        class PrefabControlPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.GameObject m_Instance;

            static /*0x27cdbd8*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.PrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform);
            static /*0x27cdfac*/ void SetHideFlagsRecursive(UnityEngine.GameObject gameObject);
            /*0x27ce4d0*/ PrefabControlPlayable();
            /*0x27cdfa4*/ UnityEngine.GameObject get_prefabInstance();
            /*0x27cdd1c*/ UnityEngine.GameObject Initialize(UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform);
            /*0x27ce2f4*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x27ce3a0*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27ce428*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
        }

        class TimeControlPlayable : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ UnityEngine.Timeline.ITimeControl m_timeControl;
            /*0x18*/ bool m_started;

            static /*0x27ce4d8*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.ITimeControl timeControl);
            /*0x27ce82c*/ TimeControlPlayable();
            /*0x27ce5cc*/ void Initialize(UnityEngine.Timeline.ITimeControl timeControl);
            /*0x27ce5d4*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27ce6c8*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27ce77c*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
        }

        class TimeNotificationBehaviour : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> m_Notifications;
            /*0x18*/ double m_PreviousTime;
            /*0x20*/ bool m_NeedSortNotifications;
            /*0x28*/ UnityEngine.Playables.Playable m_TimeSource;

            static /*0x27ce83c*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, double duration, UnityEngine.Playables.DirectorWrapMode loopMode);
            static /*0x27cf584*/ bool CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, double currentTime, double previousTime);
            static /*0x27ceedc*/ void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            static /*0x27cf5e0*/ void Restore_internal(ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            /*0x27cf600*/ TimeNotificationBehaviour();
            /*0x27ce834*/ void set_timeSource(UnityEngine.Playables.Playable value);
            /*0x27ce958*/ void AddNotification(double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags);
            /*0x27cea50*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x27ced30*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cef64*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27cec14*/ void SortNotifications();
            /*0x27cf3c4*/ void TriggerNotificationsInRange(double start, double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, bool checkState);
            /*0x27cf2c0*/ void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable);

            struct NotificationEntry
            {
                /*0x10*/ double time;
                /*0x18*/ UnityEngine.Playables.INotification payload;
                /*0x20*/ bool notificationFired;
                /*0x22*/ UnityEngine.Timeline.NotificationFlags flags;

                /*0x27cf5f4*/ bool get_triggerInEditor();
                /*0x27cf5e8*/ bool get_prewarm();
                /*0x27ced24*/ bool get_triggerOnce();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TimeNotificationBehaviour.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> <>9__12_0;

                static /*0x27cf67c*/ <>c();
                /*0x27cf6e0*/ <>c();
                /*0x27cf6e8*/ int <SortNotifications>b__12_0(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry x, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry y);
            }
        }

        class PlayableTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x27cf790*/ PlayableTrack();
            /*0x27cf6f8*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
        }

        class TrackMediaType : System.Attribute
        {
            /*0x10*/ UnityEngine.Timeline.TimelineAsset.MediaType m_MediaType;

            /*0x27cf7e8*/ TrackMediaType(UnityEngine.Timeline.TimelineAsset.MediaType mt);
        }

        class TrackClipTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type inspectedType;
            /*0x18*/ bool allowAutoCreate;

            /*0x27cf810*/ TrackClipTypeAttribute(System.Type clipClass);
            /*0x27cf840*/ TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate);
        }

        class NotKeyableAttribute : System.Attribute
        {
            /*0x27cf868*/ NotKeyableAttribute();
        }

        enum TrackBindingFlags
        {
            None = 0,
            AllowCreateComponent = 1,
            All = 1,
        }

        class TrackBindingTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;
            /*0x18*/ UnityEngine.Timeline.TrackBindingFlags flags;

            /*0x27cf870*/ TrackBindingTypeAttribute(System.Type type);
            /*0x27cf8a0*/ TrackBindingTypeAttribute(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags);
        }

        class SupportsChildTracksAttribute : System.Attribute
        {
            /*0x10*/ System.Type childType;
            /*0x18*/ int levels;

            /*0x27cf8d0*/ SupportsChildTracksAttribute(System.Type childType, int levels);
        }

        class IgnoreOnPlayableTrackAttribute : System.Attribute
        {
            /*0x27cf900*/ IgnoreOnPlayableTrackAttribute();
        }

        class TimeFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x14*/ UnityEngine.Timeline.TimeFieldAttribute.UseEditMode <useEditMode>k__BackingField;

            /*0x27cf910*/ TimeFieldAttribute(UnityEngine.Timeline.TimeFieldAttribute.UseEditMode useEditMode);
            /*0x27cf908*/ UnityEngine.Timeline.TimeFieldAttribute.UseEditMode get_useEditMode();

            enum UseEditMode
            {
                None = 0,
                ApplyEditMode = 1,
            }
        }

        class FrameRateFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x27cf938*/ FrameRateFieldAttribute();
        }

        class HideInMenuAttribute : System.Attribute
        {
            /*0x27cf940*/ HideInMenuAttribute();
        }

        class CustomStyleAttribute : System.Attribute
        {
            /*0x10*/ string ussStyle;

            /*0x27cf948*/ CustomStyleAttribute(string ussStyle);
        }

        class MenuCategoryAttribute : System.Attribute
        {
            /*0x10*/ string category;

            /*0x27cf970*/ MenuCategoryAttribute(string category);
        }

        interface ITimelineClipAsset
        {
            UnityEngine.Timeline.ClipCaps get_clipCaps();
        }

        interface ITimelineEvaluateCallback
        {
            void Evaluate();
        }

        class TimelinePlayable : UnityEngine.Playables.PlayableBehaviour
        {
            static /*0x0*/ bool muteAudioScrubbing;
            /*0x10*/ UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> m_IntervalTree;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClips;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips;
            /*0x28*/ int m_ActiveBit;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> m_EvaluateCallbacks;
            /*0x38*/ System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset, UnityEngine.Playables.Playable> m_PlayableCache;

            static /*0x27d16dc*/ TimelinePlayable();
            static /*0x27cf9dc*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            static /*0x27d1530*/ void ForAOTCompilationOnly();
            /*0x27d1594*/ TimelinePlayable();
            /*0x27cfbfc*/ void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x27cfe8c*/ void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool createOutputs);
            /*0x27d0648*/ void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, int port);
            /*0x27d0cc8*/ void EvaluateWeightsForAnimationPlayableOutput(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput);
            /*0x27d0db8*/ void EvaluateAnimationPreviewUpdateCallback(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput);
            /*0x27d0228*/ UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, bool createOutputs);
            /*0x27d0f18*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x27d0f44*/ void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData);
            /*0x27d0ea8*/ void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable, int port, UnityEngine.Playables.Playable parent);
        }

        class Extrapolation
        {
            static /*0x0*/ double kMinExtrapolationTime;

            static /*0x27d1c70*/ Extrapolation();
            static /*0x27d1728*/ void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset);
            static /*0x27d1b34*/ UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.Extrapolation.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;

                static /*0x27d1cf4*/ <>c();
                /*0x27d1d58*/ <>c();
                /*0x27d1d60*/ int <SortClipsByStartTime>b__2_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }
        }

        class HashUtility
        {
            static /*0x27d1d94*/ int CombineHash(int h1, int h2);
            static /*0x27d1db0*/ int CombineHash(int h1, int h2, int h3);
            static /*0x27d1ddc*/ int CombineHash(int h1, int h2, int h3, int h4);
            static /*0x27d1e18*/ int CombineHash(int h1, int h2, int h3, int h4, int h5);
            static /*0x27d1e64*/ int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6);
            static /*0x27d1ec0*/ int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6, int h7);
            static /*0x27d1eec*/ int CombineHash(int[] hashes);
        }

        interface IPropertyCollector
        {
            void PushActiveGameObject(UnityEngine.GameObject gameObject);
            void PopActiveGameObject();
            void AddFromClip(UnityEngine.AnimationClip clip);
            void AddFromClips(System.Collections.Generic.IEnumerable<UnityEngine.AnimationClip> clips);
            void AddFromName<T>(string name);
            void AddFromName(string name);
            void AddFromClip(UnityEngine.GameObject obj, UnityEngine.AnimationClip clip);
            void AddFromClips(UnityEngine.GameObject obj, System.Collections.Generic.IEnumerable<UnityEngine.AnimationClip> clips);
            void AddFromName<T>(UnityEngine.GameObject obj, string name);
            void AddFromName(UnityEngine.GameObject obj, string name);
            void AddFromName(UnityEngine.Component component, string name);
            void AddFromComponent(UnityEngine.GameObject obj, UnityEngine.Component component);
            void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip);
        }

        interface IPropertyPreview
        {
            void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
        }

        class NotificationUtilities
        {
            static /*0x27d1f58*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, double duration, UnityEngine.Playables.DirectorWrapMode extrapolationMode);
            static /*0x27d2638*/ bool TrackTypeSupportsNotifications(System.Type type);
        }

        class TimelineClipExtensions
        {
            static /*0x0*/ string k_UndoSetParentTrackText;

            static /*0x27d2fd0*/ TimelineClipExtensions();
            static /*0x27d27c4*/ void MoveToTrack(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Timeline.TrackAsset destinationTrack);
            static /*0x27d2ca8*/ bool TryMoveToTrack(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Timeline.TrackAsset destinationTrack);
            static /*0x27d2b88*/ void MoveToTrack_Impl(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Timeline.TrackAsset destinationTrack, UnityEngine.Object asset, UnityEngine.Timeline.TrackAsset parentTrack);
        }

        class TimelineCreateUtilities
        {
            static /*0x27d3030*/ string GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, string name);
            static /*0x27d2e4c*/ void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x27d2f34*/ void RemoveAssetFromObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x27d3330*/ UnityEngine.AnimationClip CreateAnimationClipForTrack(string name, UnityEngine.Timeline.TrackAsset track, bool isLegacy);
            static /*0x27d34e8*/ bool ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ string name;

                /*0x27d3320*/ <>c__DisplayClass0_0();
                /*0x27d3808*/ bool <GenerateUniqueActorName>b__0(UnityEngine.ScriptableObject x);
            }

            class <>c__DisplayClass0_1
            {
                /*0x10*/ string result;

                /*0x27d3328*/ <>c__DisplayClass0_1();
                /*0x27d3838*/ bool <GenerateUniqueActorName>b__1(UnityEngine.ScriptableObject x);
            }
        }

        class TimelineUndo
        {
            static /*0x27d3868*/ void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy);
            static /*0x27d38f0*/ void PushUndo(UnityEngine.Object[] thingsToDirty, string operation);
            static /*0x27d38f4*/ void PushUndo(UnityEngine.Object thingToDirty, string operation);
            static /*0x27d38f8*/ void RegisterCreatedObjectUndo(UnityEngine.Object thingCreated, string operation);
            static /*0x27d38fc*/ string UndoName(string name);
        }

        enum StandardFrameRates
        {
            Fps24 = 0,
            Fps23_97 = 1,
            Fps25 = 2,
            Fps30 = 3,
            Fps29_97 = 4,
            Fps50 = 5,
            Fps60 = 6,
            Fps59_94 = 7,
        }

        class TimeUtility
        {
            static /*0x0*/ double kTimeEpsilon;
            static /*0x8*/ double kFrameRateEpsilon;
            static /*0x10*/ double k_MaxTimelineDurationInSeconds;
            static /*0x18*/ double kFrameRateRounding;

            static /*0x27d5490*/ TimeUtility();
            static /*0x27d3948*/ void ValidateFrameRate(double frameRate);
            static /*0x27d3a00*/ int ToFrames(double time, double frameRate);
            static /*0x27d3bbc*/ double ToExactFrames(double time, double frameRate);
            static /*0x27d3c24*/ double FromFrames(int frames, double frameRate);
            static /*0x27d3c90*/ double FromFrames(double frames, double frameRate);
            static /*0x27d3cf8*/ bool OnFrameBoundary(double time, double frameRate);
            static /*0x27d3b14*/ double GetEpsilon(double time, double frameRate);
            static /*0x27d3d6c*/ bool OnFrameBoundary(double time, double frameRate, double epsilon);
            static /*0x27d3e8c*/ double RoundToFrame(double time, double frameRate);
            static /*0x27d3f68*/ string TimeAsFrames(double timeValue, double frameRate, string format);
            static /*0x27d4038*/ string TimeAsTimeCode(double timeValue, double frameRate, string format);
            static /*0x27d44d4*/ double ParseTimeCode(string timeCode, double frameRate, double defaultValue);
            static /*0x27d4ab4*/ double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue);
            static /*0x27d4e2c*/ double GetAnimationClipLength(UnityEngine.AnimationClip clip);
            static /*0x27d49e4*/ string RemoveChar(string str, System.Func<char, bool> charToRemoveFunc);
            static /*0x27d4f90*/ UnityEngine.Playables.FrameRate GetClosestFrameRate(double frameRate);
            static /*0x27d5080*/ UnityEngine.Playables.FrameRate ToFrameRate(UnityEngine.Timeline.StandardFrameRates enumValue);
            static /*0x27d51e8*/ bool ToStandardFrameRate(UnityEngine.Playables.FrameRate rate, ref UnityEngine.Timeline.StandardFrameRates standard);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TimeUtility.<> <>9;
                static /*0x8*/ System.Func<char, bool> <>9__15_0;
                static /*0x10*/ System.Func<char, bool> <>9__15_1;
                static /*0x18*/ System.Func<char, bool> <>9__16_0;

                static /*0x27d54e8*/ <>c();
                /*0x27d554c*/ <>c();
                /*0x27d5554*/ bool <ParseTimeCode>b__15_0(char c);
                /*0x27d55ac*/ bool <ParseTimeCode>b__15_1(char c);
                /*0x27d55c8*/ bool <ParseTimeSeconds>b__16_0(char c);
            }
        }

        class WeightUtility
        {
            static /*0x27d5620*/ float NormalizeMixer(UnityEngine.Playables.Playable mixer);
        }
    }
}
