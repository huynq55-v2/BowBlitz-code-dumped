class <Module>
{
}

namespace UnityEngine
{
    enum AudioDataLoadState
    {
        Unloaded = 0,
        Loading = 1,
        Loaded = 2,
        Failed = 3,
    }

    enum AudioClipLoadType
    {
        DecompressOnLoad = 0,
        CompressedInMemory = 1,
        Streaming = 2,
    }

    enum AudioVelocityUpdateMode
    {
        Auto = 0,
        Fixed = 1,
        Dynamic = 2,
    }

    enum FFTWindow
    {
        Rectangular = 0,
        Triangle = 1,
        Hamming = 2,
        Hanning = 3,
        Blackman = 4,
        BlackmanHarris = 5,
    }

    enum AudioRolloffMode
    {
        Logarithmic = 0,
        Linear = 1,
        Custom = 2,
    }

    enum AudioSourceCurveType
    {
        CustomRolloff = 0,
        SpatialBlend = 1,
        ReverbZoneMix = 2,
        Spread = 3,
    }

    class AudioSettings
    {
        static /*0x0*/ UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;
        static /*0x8*/ System.Action OnAudioSystemShuttingDown;
        static /*0x10*/ System.Action OnAudioSystemStartedUp;

        static /*0x28065c0*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0x280662c*/ void InvokeOnAudioSystemShuttingDown();
        static /*0x2806690*/ void InvokeOnAudioSystemStartedUp();
        static /*0x28066f4*/ bool StartAudioOutput();
        static /*0x280671c*/ bool StopAudioOutput();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0x2806744*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0x2806808*/ void Invoke(bool deviceWasChanged);
        }

        class Mobile
        {
            static /*0x0*/ bool <muteState>k__BackingField;
            static /*0x1*/ bool _stopAudioOutputOnMute;
            static /*0x8*/ System.Action<bool> OnMuteStateChanged;

            static /*0x2806820*/ bool get_muteState();
            static /*0x2806868*/ void set_muteState(bool value);
            static /*0x28068b4*/ bool get_stopAudioOutputOnMute();
            static /*0x28068fc*/ void InvokeOnMuteStateChanged(bool mute);
            static /*0x2806ac8*/ bool InvokeIsStopAudioOutputOnMuteEnabled();
            static /*0x2806aa0*/ void StartAudioOutput();
            static /*0x2806a78*/ void StopAudioOutput();
        }
    }

    class AudioClip : UnityEngine.Object
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        static /*0x2806b6c*/ bool GetData(UnityEngine.AudioClip clip, float[] data, int numSamples, int samplesOffset);
        static /*0x2806bc8*/ bool SetData(UnityEngine.AudioClip clip, float[] data, int numsamples, int samplesOffset);
        static /*0x2806c24*/ UnityEngine.AudioClip Construct_Internal();
        static /*0x2807380*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream);
        static /*0x28073a0*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback);
        static /*0x280756c*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback);
        static /*0x2807390*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream);
        static /*0x280757c*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback);
        static /*0x28073b0*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback);
        /*0x2806b10*/ AudioClip();
        /*0x2806c4c*/ string GetName();
        /*0x2806c88*/ void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream);
        /*0x2806cfc*/ float get_length();
        /*0x2806d38*/ int get_samples();
        /*0x2806d74*/ int get_channels();
        /*0x2806db0*/ int get_frequency();
        /*0x2806dec*/ bool get_isReadyToPlay();
        /*0x2806e28*/ UnityEngine.AudioClipLoadType get_loadType();
        /*0x2806e64*/ bool LoadAudioData();
        /*0x2806ea0*/ bool UnloadAudioData();
        /*0x2806edc*/ bool get_preloadAudioData();
        /*0x2806f18*/ bool get_ambisonic();
        /*0x2806f54*/ bool get_loadInBackground();
        /*0x2806f90*/ UnityEngine.AudioDataLoadState get_loadState();
        /*0x2806fcc*/ bool GetData(float[] data, int offsetSamples);
        /*0x2807154*/ bool SetData(float[] data, int offsetSamples);
        /*0x2807588*/ void add_m_PCMReaderCallback(UnityEngine.AudioClip.PCMReaderCallback value);
        /*0x28076c0*/ void remove_m_PCMReaderCallback(UnityEngine.AudioClip.PCMReaderCallback value);
        /*0x2807624*/ void add_m_PCMSetPositionCallback(UnityEngine.AudioClip.PCMSetPositionCallback value);
        /*0x280775c*/ void remove_m_PCMSetPositionCallback(UnityEngine.AudioClip.PCMSetPositionCallback value);
        /*0x28077f8*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0x2807814*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0x2807830*/ PCMReaderCallback(object object, nint method);
            /*0x2807904*/ void Invoke(float[] data);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0x2807918*/ PCMSetPositionCallback(object object, nint method);
            /*0x28079dc*/ void Invoke(int position);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
        /*0x28079f0*/ AudioBehaviour();
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0x28079f8*/ float GetPitch(UnityEngine.AudioSource source);
        static /*0x2807a34*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0x2807a80*/ void PlayHelper(UnityEngine.AudioSource source, ulong delay);
        static /*0x2807b10*/ void PlayOneShotHelper(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, float volumeScale);
        static /*0x2807ba8*/ void SetCustomCurveHelper(UnityEngine.AudioSource source, UnityEngine.AudioSourceCurveType type, UnityEngine.AnimationCurve curve);
        static /*0x2807bfc*/ UnityEngine.AnimationCurve GetCustomCurveHelper(UnityEngine.AudioSource source, UnityEngine.AudioSourceCurveType type);
        static /*0x2807c40*/ void GetOutputDataHelper(UnityEngine.AudioSource source, float[] samples, int channel);
        static /*0x2807c94*/ void GetSpectrumDataHelper(UnityEngine.AudioSource source, float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x2808414*/ void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position);
        static /*0x280841c*/ void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position, float volume);
        /*0x280972c*/ AudioSource();
        /*0x2807ac4*/ void Play(double delay);
        /*0x2807b64*/ void Stop(bool stopOneShots);
        /*0x2807cf0*/ float get_volume();
        /*0x2807d2c*/ void set_volume(float value);
        /*0x2807d78*/ float get_pitch();
        /*0x2807db4*/ void set_pitch(float value);
        /*0x2807e00*/ float get_time();
        /*0x2807e3c*/ void set_time(float value);
        /*0x2807e88*/ int get_timeSamples();
        /*0x2807ec4*/ void set_timeSamples(int value);
        /*0x2807f08*/ UnityEngine.AudioClip get_clip();
        /*0x2807f44*/ void set_clip(UnityEngine.AudioClip value);
        /*0x2807f88*/ UnityEngine.Audio.AudioMixerGroup get_outputAudioMixerGroup();
        /*0x2807fc4*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
        /*0x2808008*/ void Play();
        /*0x2808048*/ void Play(ulong delay);
        /*0x280808c*/ void PlayDelayed(float delay);
        /*0x28080f0*/ void PlayScheduled(double time);
        /*0x2808148*/ void PlayOneShot(UnityEngine.AudioClip clip);
        /*0x2808150*/ void PlayOneShot(UnityEngine.AudioClip clip, float volumeScale);
        /*0x280824c*/ void SetScheduledStartTime(double time);
        /*0x2808298*/ void SetScheduledEndTime(double time);
        /*0x28082e4*/ void Stop();
        /*0x2808324*/ void Pause();
        /*0x2808360*/ void UnPause();
        /*0x280839c*/ bool get_isPlaying();
        /*0x28083d8*/ bool get_isVirtual();
        /*0x28086e8*/ bool get_loop();
        /*0x2808724*/ void set_loop(bool value);
        /*0x2808768*/ bool get_ignoreListenerVolume();
        /*0x28087a4*/ void set_ignoreListenerVolume(bool value);
        /*0x28087e8*/ bool get_playOnAwake();
        /*0x2808824*/ void set_playOnAwake(bool value);
        /*0x2808868*/ bool get_ignoreListenerPause();
        /*0x28088a4*/ void set_ignoreListenerPause(bool value);
        /*0x28088e8*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode();
        /*0x2808924*/ void set_velocityUpdateMode(UnityEngine.AudioVelocityUpdateMode value);
        /*0x2808968*/ float get_panStereo();
        /*0x28089a4*/ void set_panStereo(float value);
        /*0x28089f0*/ float get_spatialBlend();
        /*0x280869c*/ void set_spatialBlend(float value);
        /*0x2808a2c*/ bool get_spatialize();
        /*0x2808a68*/ void set_spatialize(bool value);
        /*0x2808aac*/ bool get_spatializePostEffects();
        /*0x2808ae8*/ void set_spatializePostEffects(bool value);
        /*0x2808b2c*/ void SetCustomCurve(UnityEngine.AudioSourceCurveType type, UnityEngine.AnimationCurve curve);
        /*0x2808b80*/ UnityEngine.AnimationCurve GetCustomCurve(UnityEngine.AudioSourceCurveType type);
        /*0x2808bc4*/ float get_reverbZoneMix();
        /*0x2808c00*/ void set_reverbZoneMix(float value);
        /*0x2808c4c*/ bool get_bypassEffects();
        /*0x2808c88*/ void set_bypassEffects(bool value);
        /*0x2808ccc*/ bool get_bypassListenerEffects();
        /*0x2808d08*/ void set_bypassListenerEffects(bool value);
        /*0x2808d4c*/ bool get_bypassReverbZones();
        /*0x2808d88*/ void set_bypassReverbZones(bool value);
        /*0x2808dcc*/ float get_dopplerLevel();
        /*0x2808e08*/ void set_dopplerLevel(float value);
        /*0x2808e54*/ float get_spread();
        /*0x2808e90*/ void set_spread(float value);
        /*0x2808edc*/ int get_priority();
        /*0x2808f18*/ void set_priority(int value);
        /*0x2808f5c*/ bool get_mute();
        /*0x2808f98*/ void set_mute(bool value);
        /*0x2808fdc*/ float get_minDistance();
        /*0x2809018*/ void set_minDistance(float value);
        /*0x2809064*/ float get_maxDistance();
        /*0x28090a0*/ void set_maxDistance(float value);
        /*0x28090ec*/ UnityEngine.AudioRolloffMode get_rolloffMode();
        /*0x2809128*/ void set_rolloffMode(UnityEngine.AudioRolloffMode value);
        /*0x280916c*/ float[] GetOutputData(int numSamples, int channel);
        /*0x2809200*/ void GetOutputData(float[] samples, int channel);
        /*0x2809254*/ float[] GetSpectrumData(int numSamples, int channel, UnityEngine.FFTWindow window);
        /*0x28092f8*/ void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window);
        /*0x2809354*/ float get_minVolume();
        /*0x28093c4*/ void set_minVolume(float value);
        /*0x280942c*/ float get_maxVolume();
        /*0x280949c*/ void set_maxVolume(float value);
        /*0x2809504*/ float get_rolloffFactor();
        /*0x2809574*/ void set_rolloffFactor(float value);
        /*0x28095dc*/ bool SetSpatializerFloat(int index, float value);
        /*0x2809630*/ bool GetSpatializerFloat(int index, ref float value);
        /*0x2809684*/ bool GetAmbisonicDecoderFloat(int index, ref float value);
        /*0x28096d8*/ bool SetAmbisonicDecoderFloat(int index, float value);
    }

    namespace Audio
    {
        struct AudioPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x2809734*/ UnityEngine.Audio.AudioPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.AudioSource target);
            static /*0x2809830*/ UnityEngine.Audio.AudioPlayableOutput get_Null();
            static /*0x28099bc*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Audio.AudioPlayableOutput output);
            static /*0x28099ec*/ UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x2809a30*/ void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.AudioSource target);
            static /*0x2809ab8*/ void InternalSetEvaluateOnSeek(ref UnityEngine.Playables.PlayableOutputHandle output, bool value);
            /*0x28098ac*/ AudioPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x28099b0*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x280996c*/ void SetTarget(UnityEngine.AudioSource value);
            /*0x2809a74*/ void SetEvaluateOnSeek(bool value);
        }

        class AudioMixerGroup : UnityEngine.Object, UnityEngine.Internal.ISubAssetNotDuplicatable
        {
            /*0x2809afc*/ AudioMixerGroup();
            /*0x2809b54*/ UnityEngine.Audio.AudioMixer get_audioMixer();
        }

        class AudioPlayableBinding
        {
            static /*0x2809b90*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key);
            static /*0x2809ccc*/ UnityEngine.Playables.PlayableOutput CreateAudioOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }

        enum AudioMixerUpdateMode
        {
            Normal = 0,
            UnscaledTime = 1,
        }

        class AudioMixer : UnityEngine.Object
        {
            /*0x2809d0c*/ AudioMixer();
            /*0x2809d64*/ UnityEngine.Audio.AudioMixerGroup get_outputAudioMixerGroup();
            /*0x2809da0*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
            /*0x2809de4*/ UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(string name);
            /*0x2809e28*/ UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(string subPath);
            /*0x2809e6c*/ void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach);
            /*0x280a178*/ void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach);
            /*0x280a1cc*/ void TransitionToSnapshots(UnityEngine.Audio.AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);
            /*0x280a230*/ UnityEngine.Audio.AudioMixerUpdateMode get_updateMode();
            /*0x280a26c*/ void set_updateMode(UnityEngine.Audio.AudioMixerUpdateMode value);
            /*0x280a2b0*/ bool SetFloat(string name, float value);
            /*0x280a304*/ bool ClearFloat(string name);
            /*0x280a348*/ bool GetFloat(string name, ref float value);
        }

        class AudioPlayableGraphExtensions
        {
            static /*0x28097dc*/ bool InternalCreateAudioOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
        }

        class AudioMixerSnapshot : UnityEngine.Object, UnityEngine.Internal.ISubAssetNotDuplicatable
        {
            /*0x280a39c*/ AudioMixerSnapshot();
            /*0x280a13c*/ UnityEngine.Audio.AudioMixer get_audioMixer();
            /*0x280a3f4*/ void TransitionTo(float timeToReach);
        }

        struct AudioClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x280a450*/ UnityEngine.Audio.AudioClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, bool looping);
            static /*0x280a574*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, bool looping);
            static /*0x280a76c*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioClipPlayable playable);
            static /*0x280a79c*/ UnityEngine.Audio.AudioClipPlayable op_Explicit(UnityEngine.Playables.Playable playable);
            static /*0x280a930*/ void SetVolumeInternal(ref UnityEngine.Playables.PlayableHandle hdl, float volume);
            static /*0x280aa58*/ void SetStereoPanInternal(ref UnityEngine.Playables.PlayableHandle hdl, float stereoPan);
            static /*0x280ab7c*/ void SetSpatialBlendInternal(ref UnityEngine.Playables.PlayableHandle hdl, float spatialBlend);
            static /*0x280acfc*/ void SetStartDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl, double delay);
            static /*0x280ad48*/ void SetPauseDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl, double delay);
            static /*0x280a704*/ bool InternalCreateAudioClipPlayable(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, bool looping, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x280a644*/ AudioClipPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x280a760*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x280a7e0*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
            /*0x280a858*/ void SetVolume(float value);
            /*0x280a97c*/ void SetStereoPan(float value);
            /*0x280aaa4*/ void SetSpatialBlend(float value);
            /*0x280abc8*/ void Seek(double startTime, double startDelay, double duration);
        }

        struct AudioMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x280ad94*/ UnityEngine.Audio.AudioMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool normalizeInputVolumes);
            static /*0x280add0*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool normalizeInputVolumes);
            static /*0x280afcc*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioMixerPlayable playable);
            static /*0x280af6c*/ bool CreateAudioMixerPlayableInternal(ref UnityEngine.Playables.PlayableGraph graph, bool normalizeInputVolumes, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x280aeac*/ AudioMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x280afc0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x280affc*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }
    }

    namespace Experimental
    {
        namespace Audio
        {
            class AudioSampleProvider
            {
                /*0x10*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
                /*0x18*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

                /*0x280b074*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0x280b09c*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0x280b0c4*/ SampleFramesHandler(object object, nint method);
                    /*0x280b1f4*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                }
            }
        }
    }
}
