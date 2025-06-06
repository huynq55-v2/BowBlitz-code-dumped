class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x29060ec*/ EmbeddedAttribute();
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
                /*0x29060f4*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    class ParticleSystem : UnityEngine.Component
    {
        static /*0x2907698*/ void ResetPreMappedBufferMemory();
        static /*0x29076c0*/ void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount);
        static /*0x2907928*/ Unity.Jobs.JobHandle ScheduleManagedJob(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData);
        static /*0x29079d8*/ void CopyManagedJobData(void* systemPtr, ref UnityEngine.ParticleSystemJobs.NativeParticleData particleData);
        static /*0x2907984*/ void ScheduleManagedJob_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData, ref Unity.Jobs.JobHandle ret);
        /*0x2909138*/ ParticleSystem();
        /*0x29060fc*/ bool get_isPlaying();
        /*0x2906138*/ bool get_isEmitting();
        /*0x2906174*/ bool get_isStopped();
        /*0x29061b0*/ bool get_isPaused();
        /*0x29061ec*/ int get_particleCount();
        /*0x2906228*/ float get_time();
        /*0x2906264*/ void set_time(float value);
        /*0x29062b0*/ uint get_randomSeed();
        /*0x29062ec*/ void set_randomSeed(uint value);
        /*0x2906330*/ bool get_useAutoRandomSeed();
        /*0x290636c*/ void set_useAutoRandomSeed(bool value);
        /*0x29063b0*/ bool get_proceduralSimulationSupported();
        /*0x29063ec*/ float GetParticleCurrentSize(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x2906430*/ UnityEngine.Vector3 GetParticleCurrentSize3D(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x29064e8*/ UnityEngine.Color32 GetParticleCurrentColor(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x2906598*/ int GetParticleMeshIndex(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x29065dc*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x2906638*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x2906690*/ void SetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x29066dc*/ void SetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x2906748*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x29067f8*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x2906800*/ void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x290680c*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset);
        /*0x2906868*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size);
        /*0x29068c0*/ int GetParticles(UnityEngine.ParticleSystem.Particle[] particles);
        /*0x290690c*/ int GetParticlesWithNativeArray(nint particles, int particlesLength, int size, int offset);
        /*0x2906978*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset);
        /*0x2906a28*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size);
        /*0x2906a30*/ int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles);
        /*0x2906a3c*/ void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x2906a90*/ int GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex);
        /*0x2906ae4*/ UnityEngine.ParticleSystem.PlaybackState GetPlaybackState();
        /*0x2906ba0*/ void SetPlaybackState(UnityEngine.ParticleSystem.PlaybackState playbackState);
        /*0x2906c28*/ void GetTrailDataInternal(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x2906c6c*/ UnityEngine.ParticleSystem.Trails GetTrails();
        /*0x2906df8*/ int GetTrails(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x2906e78*/ void SetTrails(UnityEngine.ParticleSystem.Trails trailData);
        /*0x2906f00*/ void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep);
        /*0x2906f6c*/ void Simulate(float t, bool withChildren, bool restart);
        /*0x2906fd4*/ void Simulate(float t, bool withChildren);
        /*0x2907030*/ void Simulate(float t);
        /*0x2907088*/ void Play(bool withChildren);
        /*0x29070cc*/ void Play();
        /*0x290710c*/ void Pause(bool withChildren);
        /*0x2907150*/ void Pause();
        /*0x2907190*/ void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior);
        /*0x29071e4*/ void Stop(bool withChildren);
        /*0x290722c*/ void Stop();
        /*0x2907270*/ void Clear(bool withChildren);
        /*0x29072b4*/ void Clear();
        /*0x29072f4*/ bool IsAlive(bool withChildren);
        /*0x2907338*/ bool IsAlive();
        /*0x2907378*/ void Emit(int count);
        /*0x29073bc*/ void Emit_Internal(int count);
        /*0x2907400*/ void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x29074a8*/ void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle);
        /*0x29074ec*/ void TriggerSubEmitter(int subEmitterIndex);
        /*0x2907588*/ void TriggerSubEmitter(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        /*0x29075f0*/ void TriggerSubEmitterForParticle(int subEmitterIndex, UnityEngine.ParticleSystem.Particle particle);
        /*0x2907534*/ void TriggerSubEmitter(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        /*0x2907704*/ void AllocateAxisOfRotationAttribute();
        /*0x2907740*/ void AllocateMeshIndexAttribute();
        /*0x290777c*/ void AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData stream);
        /*0x29077c0*/ void* GetManagedJobData();
        /*0x29077fc*/ Unity.Jobs.JobHandle GetManagedJobHandle();
        /*0x2907894*/ void SetManagedJobHandle(Unity.Jobs.JobHandle handle);
        /*0x2907a1c*/ UnityEngine.ParticleSystem.MainModule get_main();
        /*0x2907a28*/ UnityEngine.ParticleSystem.EmissionModule get_emission();
        /*0x2907a34*/ UnityEngine.ParticleSystem.ShapeModule get_shape();
        /*0x2907a40*/ UnityEngine.ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime();
        /*0x2907a4c*/ UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime();
        /*0x2907a58*/ UnityEngine.ParticleSystem.InheritVelocityModule get_inheritVelocity();
        /*0x2907a64*/ UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed();
        /*0x2907a70*/ UnityEngine.ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime();
        /*0x2907a7c*/ UnityEngine.ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime();
        /*0x2907a88*/ UnityEngine.ParticleSystem.ColorBySpeedModule get_colorBySpeed();
        /*0x2907a94*/ UnityEngine.ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime();
        /*0x2907aa0*/ UnityEngine.ParticleSystem.SizeBySpeedModule get_sizeBySpeed();
        /*0x2907aac*/ UnityEngine.ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime();
        /*0x2907ab8*/ UnityEngine.ParticleSystem.RotationBySpeedModule get_rotationBySpeed();
        /*0x2907ac4*/ UnityEngine.ParticleSystem.ExternalForcesModule get_externalForces();
        /*0x2907ad0*/ UnityEngine.ParticleSystem.NoiseModule get_noise();
        /*0x2907adc*/ UnityEngine.ParticleSystem.CollisionModule get_collision();
        /*0x2907ae8*/ UnityEngine.ParticleSystem.TriggerModule get_trigger();
        /*0x2907af4*/ UnityEngine.ParticleSystem.SubEmittersModule get_subEmitters();
        /*0x2907b00*/ UnityEngine.ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation();
        /*0x2907b0c*/ UnityEngine.ParticleSystem.LightsModule get_lights();
        /*0x2907b18*/ UnityEngine.ParticleSystem.TrailModule get_trails();
        /*0x2907b24*/ UnityEngine.ParticleSystem.CustomDataModule get_customData();
        /*0x2907b30*/ void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color);
        /*0x2907cd0*/ void Emit(UnityEngine.ParticleSystem.Particle particle);
        /*0x2907d14*/ float get_startDelay();
        /*0x2907d90*/ void set_startDelay(float value);
        /*0x2907e24*/ bool get_loop();
        /*0x2907ea4*/ void set_loop(bool value);
        /*0x2907f30*/ bool get_playOnAwake();
        /*0x2907fb0*/ void set_playOnAwake(bool value);
        /*0x290803c*/ float get_duration();
        /*0x29080b8*/ float get_playbackSpeed();
        /*0x2908134*/ void set_playbackSpeed(float value);
        /*0x29081c8*/ bool get_enableEmission();
        /*0x2908248*/ void set_enableEmission(bool value);
        /*0x29082d4*/ float get_emissionRate();
        /*0x2908350*/ void set_emissionRate(float value);
        /*0x29083fc*/ float get_startSpeed();
        /*0x2908478*/ void set_startSpeed(float value);
        /*0x290850c*/ float get_startSize();
        /*0x2908588*/ void set_startSize(float value);
        /*0x290861c*/ UnityEngine.Color get_startColor();
        /*0x29086fc*/ void set_startColor(UnityEngine.Color value);
        /*0x29087b8*/ float get_startRotation();
        /*0x2908834*/ void set_startRotation(float value);
        /*0x29088c8*/ UnityEngine.Vector3 get_startRotation3D();
        /*0x2908a30*/ void set_startRotation3D(UnityEngine.Vector3 value);
        /*0x2908bc4*/ float get_startLifetime();
        /*0x2908c40*/ void set_startLifetime(float value);
        /*0x2908cd4*/ float get_gravityModifier();
        /*0x2908d50*/ void set_gravityModifier(float value);
        /*0x2908de4*/ int get_maxParticles();
        /*0x2908e60*/ void set_maxParticles(int value);
        /*0x2908eec*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
        /*0x2908f68*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
        /*0x2908ff4*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
        /*0x2909070*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
        /*0x29090fc*/ bool get_automaticCullingEnabled();
        /*0x2906494*/ void GetParticleCurrentSize3D_Injected(ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Vector3 ret);
        /*0x2906544*/ void GetParticleCurrentColor_Injected(ref UnityEngine.ParticleSystem.Particle particle, ref UnityEngine.Color32 ret);
        /*0x2906b5c*/ void GetPlaybackState_Injected(ref UnityEngine.ParticleSystem.PlaybackState ret);
        /*0x2906be4*/ void SetPlaybackState_Injected(ref UnityEngine.ParticleSystem.PlaybackState playbackState);
        /*0x2906ebc*/ void SetTrails_Injected(ref UnityEngine.ParticleSystem.Trails trailData);
        /*0x2907454*/ void Emit_Injected(ref UnityEngine.ParticleSystem.EmitParams emitParams, int count);
        /*0x2907644*/ void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle);
        /*0x2907850*/ void GetManagedJobHandle_Injected(ref Unity.Jobs.JobHandle ret);
        /*0x29078e4*/ void SetManagedJobHandle_Injected(ref Unity.Jobs.JobHandle handle);

        struct MainModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x290919c*/ void get_emitterVelocity_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x2909234*/ void set_emitterVelocity_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.Vector3 value);
            static /*0x2909278*/ float get_duration_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909300*/ void set_duration_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290934c*/ bool get_loop_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909388*/ void set_loop_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x2909408*/ bool get_prewarm_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909488*/ void set_prewarm_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x290952c*/ void get_startDelay_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x29095b4*/ void set_startDelay_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x29095f8*/ float get_startDelayMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909634*/ void set_startDelayMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x29096e0*/ void get_startLifetime_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x2909768*/ void set_startLifetime_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x29097ac*/ float get_startLifetimeMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x29097e8*/ void set_startLifetimeMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x2909894*/ void get_startSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290991c*/ void set_startSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x2909960*/ float get_startSpeedMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290999c*/ void set_startSpeedMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x2909a24*/ bool get_startSize3D_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909aa4*/ void set_startSize3D_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x2909b48*/ void get_startSize_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x2909bd0*/ void set_startSize_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x2909c14*/ float get_startSizeMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909c50*/ void set_startSizeMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x2909cfc*/ void get_startSizeX_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x2909d84*/ void set_startSizeX_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x2909e04*/ float get_startSizeXMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x2909e8c*/ void set_startSizeXMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x2909f38*/ void get_startSizeY_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x2909fc0*/ void set_startSizeY_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290a040*/ float get_startSizeYMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290a0c8*/ void set_startSizeYMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290a174*/ void get_startSizeZ_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290a1fc*/ void set_startSizeZ_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290a27c*/ float get_startSizeZMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290a304*/ void set_startSizeZMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290a38c*/ bool get_startRotation3D_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290a40c*/ void set_startRotation3D_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x290a4b0*/ void get_startRotation_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290a538*/ void set_startRotation_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290a57c*/ float get_startRotationMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290a5b8*/ void set_startRotationMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290a664*/ void get_startRotationX_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290a6ec*/ void set_startRotationX_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290a730*/ float get_startRotationXMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290a76c*/ void set_startRotationXMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290a818*/ void get_startRotationY_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290a8a0*/ void set_startRotationY_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290a8e4*/ float get_startRotationYMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290a920*/ void set_startRotationYMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290a9cc*/ void get_startRotationZ_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290aa54*/ void set_startRotationZ_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290aa98*/ float get_startRotationZMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290aad4*/ void set_startRotationZMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290ab5c*/ float get_flipRotation_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290abe4*/ void set_flipRotation_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290ac30*/ void get_startColor_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradient ret);
            static /*0x290ac74*/ void set_startColor_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxGradient value);
            static /*0x290ad18*/ void get_gravityModifier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290ada0*/ void set_gravityModifier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290ade4*/ float get_gravityModifierMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290ae20*/ void set_gravityModifierMultiplier_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290ae6c*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290aea8*/ void set_simulationSpace_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemSimulationSpace value);
            static /*0x290af28*/ UnityEngine.Transform get_customSimulationSpace_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290afa8*/ void set_customSimulationSpace_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.Transform value);
            static /*0x290afec*/ float get_simulationSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b028*/ void set_simulationSpeed_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, float value);
            static /*0x290b0b0*/ bool get_useUnscaledTime_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b130*/ void set_useUnscaledTime_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x290b174*/ UnityEngine.ParticleSystemScalingMode get_scalingMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b1b0*/ void set_scalingMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemScalingMode value);
            static /*0x290b1f4*/ bool get_playOnAwake_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b230*/ void set_playOnAwake_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, bool value);
            static /*0x290b274*/ int get_maxParticles_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b2b0*/ void set_maxParticles_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, int value);
            static /*0x290b330*/ UnityEngine.ParticleSystemEmitterVelocityMode get_emitterVelocityMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b3b0*/ void set_emitterVelocityMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemEmitterVelocityMode value);
            static /*0x290b430*/ UnityEngine.ParticleSystemStopAction get_stopAction_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b4b0*/ void set_stopAction_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemStopAction value);
            static /*0x290b530*/ UnityEngine.ParticleSystemRingBufferMode get_ringBufferMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b5b0*/ void set_ringBufferMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemRingBufferMode value);
            static /*0x290b640*/ void get_ringBufferLoopRange_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.Vector2 ret);
            static /*0x290b6cc*/ void set_ringBufferLoopRange_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, ref UnityEngine.Vector2 value);
            static /*0x290b74c*/ UnityEngine.ParticleSystemCullingMode get_cullingMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self);
            static /*0x290b7cc*/ void set_cullingMode_Injected(ref UnityEngine.ParticleSystem.MainModule _unity_self, UnityEngine.ParticleSystemCullingMode value);
            /*0x2907a20*/ MainModule(UnityEngine.ParticleSystem particleSystem);
            /*0x2909140*/ UnityEngine.Vector3 get_emitterVelocity();
            /*0x29091e0*/ void set_emitterVelocity(UnityEngine.Vector3 value);
            /*0x290807c*/ float get_duration();
            /*0x29092b4*/ void set_duration(float value);
            /*0x2907e68*/ bool get_loop();
            /*0x2907eec*/ void set_loop(bool value);
            /*0x29093cc*/ bool get_prewarm();
            /*0x2909444*/ void set_prewarm(bool value);
            /*0x29094cc*/ UnityEngine.ParticleSystem.MinMaxCurve get_startDelay();
            /*0x2909570*/ void set_startDelay(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x2907d54*/ float get_startDelayMultiplier();
            /*0x2907dd8*/ void set_startDelayMultiplier(float value);
            /*0x2909680*/ UnityEngine.ParticleSystem.MinMaxCurve get_startLifetime();
            /*0x2909724*/ void set_startLifetime(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x2908c04*/ float get_startLifetimeMultiplier();
            /*0x2908c88*/ void set_startLifetimeMultiplier(float value);
            /*0x2909834*/ UnityEngine.ParticleSystem.MinMaxCurve get_startSpeed();
            /*0x29098d8*/ void set_startSpeed(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x290843c*/ float get_startSpeedMultiplier();
            /*0x29084c0*/ void set_startSpeedMultiplier(float value);
            /*0x29099e8*/ bool get_startSize3D();
            /*0x2909a60*/ void set_startSize3D(bool value);
            /*0x2909ae8*/ UnityEngine.ParticleSystem.MinMaxCurve get_startSize();
            /*0x2909b8c*/ void set_startSize(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x290854c*/ float get_startSizeMultiplier();
            /*0x29085d0*/ void set_startSizeMultiplier(float value);
            /*0x2909c9c*/ UnityEngine.ParticleSystem.MinMaxCurve get_startSizeX();
            /*0x2909d40*/ void set_startSizeX(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x2909dc8*/ float get_startSizeXMultiplier();
            /*0x2909e40*/ void set_startSizeXMultiplier(float value);
            /*0x2909ed8*/ UnityEngine.ParticleSystem.MinMaxCurve get_startSizeY();
            /*0x2909f7c*/ void set_startSizeY(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x290a004*/ float get_startSizeYMultiplier();
            /*0x290a07c*/ void set_startSizeYMultiplier(float value);
            /*0x290a114*/ UnityEngine.ParticleSystem.MinMaxCurve get_startSizeZ();
            /*0x290a1b8*/ void set_startSizeZ(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x290a240*/ float get_startSizeZMultiplier();
            /*0x290a2b8*/ void set_startSizeZMultiplier(float value);
            /*0x290a350*/ bool get_startRotation3D();
            /*0x290a3c8*/ void set_startRotation3D(bool value);
            /*0x290a450*/ UnityEngine.ParticleSystem.MinMaxCurve get_startRotation();
            /*0x290a4f4*/ void set_startRotation(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x29087f8*/ float get_startRotationMultiplier();
            /*0x290887c*/ void set_startRotationMultiplier(float value);
            /*0x290a604*/ UnityEngine.ParticleSystem.MinMaxCurve get_startRotationX();
            /*0x290a6a8*/ void set_startRotationX(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x290897c*/ float get_startRotationXMultiplier();
            /*0x2908ae0*/ void set_startRotationXMultiplier(float value);
            /*0x290a7b8*/ UnityEngine.ParticleSystem.MinMaxCurve get_startRotationY();
            /*0x290a85c*/ void set_startRotationY(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x29089b8*/ float get_startRotationYMultiplier();
            /*0x2908b2c*/ void set_startRotationYMultiplier(float value);
            /*0x290a96c*/ UnityEngine.ParticleSystem.MinMaxCurve get_startRotationZ();
            /*0x290aa10*/ void set_startRotationZ(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x29089f4*/ float get_startRotationZMultiplier();
            /*0x2908b78*/ void set_startRotationZMultiplier(float value);
            /*0x290ab20*/ float get_flipRotation();
            /*0x290ab98*/ void set_flipRotation(float value);
            /*0x2908678*/ UnityEngine.ParticleSystem.MinMaxGradient get_startColor();
            /*0x2908774*/ void set_startColor(UnityEngine.ParticleSystem.MinMaxGradient value);
            /*0x290acb8*/ UnityEngine.ParticleSystem.MinMaxCurve get_gravityModifier();
            /*0x290ad5c*/ void set_gravityModifier(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x2908d14*/ float get_gravityModifierMultiplier();
            /*0x2908d98*/ void set_gravityModifierMultiplier(float value);
            /*0x2908f2c*/ UnityEngine.ParticleSystemSimulationSpace get_simulationSpace();
            /*0x2908fb0*/ void set_simulationSpace(UnityEngine.ParticleSystemSimulationSpace value);
            /*0x290aeec*/ UnityEngine.Transform get_customSimulationSpace();
            /*0x290af64*/ void set_customSimulationSpace(UnityEngine.Transform value);
            /*0x29080f8*/ float get_simulationSpeed();
            /*0x290817c*/ void set_simulationSpeed(float value);
            /*0x290b074*/ bool get_useUnscaledTime();
            /*0x290b0ec*/ void set_useUnscaledTime(bool value);
            /*0x2909034*/ UnityEngine.ParticleSystemScalingMode get_scalingMode();
            /*0x29090b8*/ void set_scalingMode(UnityEngine.ParticleSystemScalingMode value);
            /*0x2907f74*/ bool get_playOnAwake();
            /*0x2907ff8*/ void set_playOnAwake(bool value);
            /*0x2908e24*/ int get_maxParticles();
            /*0x2908ea8*/ void set_maxParticles(int value);
            /*0x290b2f4*/ UnityEngine.ParticleSystemEmitterVelocityMode get_emitterVelocityMode();
            /*0x290b36c*/ void set_emitterVelocityMode(UnityEngine.ParticleSystemEmitterVelocityMode value);
            /*0x290b3f4*/ UnityEngine.ParticleSystemStopAction get_stopAction();
            /*0x290b46c*/ void set_stopAction(UnityEngine.ParticleSystemStopAction value);
            /*0x290b4f4*/ UnityEngine.ParticleSystemRingBufferMode get_ringBufferMode();
            /*0x290b56c*/ void set_ringBufferMode(UnityEngine.ParticleSystemRingBufferMode value);
            /*0x290b5f4*/ UnityEngine.Vector2 get_ringBufferLoopRange();
            /*0x290b684*/ void set_ringBufferLoopRange(UnityEngine.Vector2 value);
            /*0x290b710*/ UnityEngine.ParticleSystemCullingMode get_cullingMode();
            /*0x290b788*/ void set_cullingMode(UnityEngine.ParticleSystemCullingMode value);
            /*0x290b810*/ float get_randomizeRotationDirection();
            /*0x290b84c*/ void set_randomizeRotationDirection(float value);
        }

        struct EmissionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x290b898*/ bool get_enabled_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self);
            static /*0x290b8d4*/ void set_enabled_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, bool value);
            static /*0x290b918*/ void set_rateOverTime_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve value);
            static /*0x290b95c*/ float get_rateOverTimeMultiplier_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self);
            static /*0x290b9f8*/ void get_rateOverDistance_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, ref UnityEngine.ParticleSystem.MinMaxCurve ret);
            static /*0x290ba78*/ float get_rateOverDistanceMultiplier_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self);
            /*0x2907a2c*/ EmissionModule(UnityEngine.ParticleSystem particleSystem);
            /*0x290820c*/ bool get_enabled();
            /*0x2908290*/ void set_enabled(bool value);
            /*0x29083b8*/ void set_rateOverTime(UnityEngine.ParticleSystem.MinMaxCurve value);
            /*0x2908314*/ float get_rateOverTimeMultiplier();
            /*0x290b998*/ UnityEngine.ParticleSystem.MinMaxCurve get_rateOverDistance();
            /*0x290ba3c*/ float get_rateOverDistanceMultiplier();
        }

        struct ShapeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a38*/ ShapeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct VelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a44*/ VelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LimitVelocityOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a50*/ LimitVelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct InheritVelocityModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a5c*/ InheritVelocityModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct LifetimeByEmitterSpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a68*/ LifetimeByEmitterSpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ForceOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a74*/ ForceOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a80*/ ColorOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ColorBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a8c*/ ColorBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907a98*/ SizeOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SizeBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907aa4*/ SizeBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationOverLifetimeModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907ab0*/ RotationOverLifetimeModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct RotationBySpeedModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907abc*/ RotationBySpeedModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct ExternalForcesModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907ac8*/ ExternalForcesModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct NoiseModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907ad4*/ NoiseModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct CollisionModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907ae0*/ CollisionModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TriggerModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907aec*/ TriggerModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct SubEmittersModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x290baf0*/ int get_subEmittersCount_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self);
            static /*0x290bb70*/ UnityEngine.ParticleSystem GetSubEmitterSystem_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index);
            /*0x2907af8*/ SubEmittersModule(UnityEngine.ParticleSystem particleSystem);
            /*0x290bab4*/ int get_subEmittersCount();
            /*0x290bb2c*/ UnityEngine.ParticleSystem GetSubEmitterSystem(int index);
        }

        struct TextureSheetAnimationModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x290bbf0*/ bool get_enabled_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x290bc68*/ UnityEngine.ParticleSystemAnimationMode get_mode_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x290bce0*/ UnityEngine.Rendering.UVChannelFlags get_uvChannelMask_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x290bd60*/ void set_uvChannelMask_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, UnityEngine.Rendering.UVChannelFlags value);
            static /*0x290bde0*/ int get_spriteCount_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self);
            static /*0x290be60*/ UnityEngine.Sprite GetSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, int index);
            /*0x2907b04*/ TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem);
            /*0x290bbb4*/ bool get_enabled();
            /*0x290bc2c*/ UnityEngine.ParticleSystemAnimationMode get_mode();
            /*0x290bca4*/ UnityEngine.Rendering.UVChannelFlags get_uvChannelMask();
            /*0x290bd1c*/ void set_uvChannelMask(UnityEngine.Rendering.UVChannelFlags value);
            /*0x290bda4*/ int get_spriteCount();
            /*0x290be1c*/ UnityEngine.Sprite GetSprite(int index);
        }

        struct LightsModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907b10*/ LightsModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct TrailModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            static /*0x290bee0*/ bool get_enabled_Injected(ref UnityEngine.ParticleSystem.TrailModule _unity_self);
            static /*0x290bf58*/ bool get_worldSpace_Injected(ref UnityEngine.ParticleSystem.TrailModule _unity_self);
            /*0x2907b1c*/ TrailModule(UnityEngine.ParticleSystem particleSystem);
            /*0x290bea4*/ bool get_enabled();
            /*0x290bf1c*/ bool get_worldSpace();
        }

        struct CustomDataModule
        {
            /*0x10*/ UnityEngine.ParticleSystem m_ParticleSystem;

            /*0x2907b28*/ CustomDataModule(UnityEngine.ParticleSystem particleSystem);
        }

        struct MinMaxCurve
        {
            /*0x10*/ UnityEngine.ParticleSystemCurveMode m_Mode;
            /*0x14*/ float m_CurveMultiplier;
            /*0x18*/ UnityEngine.AnimationCurve m_CurveMin;
            /*0x20*/ UnityEngine.AnimationCurve m_CurveMax;
            /*0x28*/ float m_ConstantMin;
            /*0x2c*/ float m_ConstantMax;

            static /*0x29083a4*/ UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(float constant);
            /*0x290bf94*/ MinMaxCurve(float constant);
            /*0x290bfa8*/ MinMaxCurve(float multiplier, UnityEngine.AnimationCurve curve);
            /*0x290bfc0*/ MinMaxCurve(float multiplier, UnityEngine.AnimationCurve min, UnityEngine.AnimationCurve max);
            /*0x290bfd8*/ MinMaxCurve(float min, float max);
            /*0x290bff4*/ UnityEngine.ParticleSystemCurveMode get_mode();
            /*0x290bffc*/ void set_mode(UnityEngine.ParticleSystemCurveMode value);
            /*0x290c004*/ float get_curveMultiplier();
            /*0x290c00c*/ void set_curveMultiplier(float value);
            /*0x290c014*/ UnityEngine.AnimationCurve get_curveMax();
            /*0x290c01c*/ void set_curveMax(UnityEngine.AnimationCurve value);
            /*0x290c024*/ UnityEngine.AnimationCurve get_curveMin();
            /*0x290c02c*/ void set_curveMin(UnityEngine.AnimationCurve value);
            /*0x290c034*/ float get_constantMax();
            /*0x290c03c*/ void set_constantMax(float value);
            /*0x290c044*/ float get_constantMin();
            /*0x290c04c*/ void set_constantMin(float value);
            /*0x290c054*/ float get_constant();
            /*0x290c05c*/ void set_constant(float value);
            /*0x290c064*/ UnityEngine.AnimationCurve get_curve();
            /*0x290c06c*/ void set_curve(UnityEngine.AnimationCurve value);
            /*0x290c074*/ float Evaluate(float time);
            /*0x290c07c*/ float Evaluate(float time, float lerpFactor);
        }

        struct MinMaxGradient
        {
            /*0x10*/ UnityEngine.ParticleSystemGradientMode m_Mode;
            /*0x18*/ UnityEngine.Gradient m_GradientMin;
            /*0x20*/ UnityEngine.Gradient m_GradientMax;
            /*0x28*/ UnityEngine.Color m_ColorMin;
            /*0x38*/ UnityEngine.Color m_ColorMax;

            static /*0x2908758*/ UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color);
            /*0x290c164*/ MinMaxGradient(UnityEngine.Color color);
            /*0x29086f0*/ UnityEngine.Color get_color();
        }

        struct Particle
        {
            /*0x10*/ UnityEngine.Vector3 m_Position;
            /*0x1c*/ UnityEngine.Vector3 m_Velocity;
            /*0x28*/ UnityEngine.Vector3 m_AnimatedVelocity;
            /*0x34*/ UnityEngine.Vector3 m_InitialVelocity;
            /*0x40*/ UnityEngine.Vector3 m_AxisOfRotation;
            /*0x4c*/ UnityEngine.Vector3 m_Rotation;
            /*0x58*/ UnityEngine.Vector3 m_AngularVelocity;
            /*0x64*/ UnityEngine.Vector3 m_StartSize;
            /*0x70*/ UnityEngine.Color32 m_StartColor;
            /*0x74*/ uint m_RandomSeed;
            /*0x78*/ uint m_ParentRandomSeed;
            /*0x7c*/ float m_Lifetime;
            /*0x80*/ float m_StartLifetime;
            /*0x84*/ int m_MeshIndex;
            /*0x88*/ float m_EmitAccumulator0;
            /*0x8c*/ float m_EmitAccumulator1;
            /*0x90*/ uint m_Flags;

            /*0x290c180*/ UnityEngine.Vector3 get_position();
            /*0x2907c34*/ void set_position(UnityEngine.Vector3 value);
            /*0x290c18c*/ UnityEngine.Vector3 get_velocity();
            /*0x2907c40*/ void set_velocity(UnityEngine.Vector3 value);
            /*0x290c198*/ float get_remainingLifetime();
            /*0x290c1a0*/ void set_remainingLifetime(float value);
            /*0x290c1a8*/ float get_startLifetime();
            /*0x2907c54*/ void set_startLifetime(float value);
            /*0x2907cc0*/ void set_startColor(UnityEngine.Color32 value);
            /*0x2907cc8*/ void set_randomSeed(uint value);
            /*0x2907c5c*/ void set_startSize(float value);
            /*0x2907c68*/ void set_rotation3D(UnityEngine.Vector3 value);
            /*0x2907c94*/ void set_angularVelocity3D(UnityEngine.Vector3 value);
            /*0x2907c4c*/ void set_lifetime(float value);
        }

        struct EmitParams
        {
            /*0x10*/ UnityEngine.ParticleSystem.Particle m_Particle;
            /*0x94*/ bool m_PositionSet;
            /*0x95*/ bool m_VelocitySet;
            /*0x96*/ bool m_AxisOfRotationSet;
            /*0x97*/ bool m_RotationSet;
            /*0x98*/ bool m_AngularVelocitySet;
            /*0x99*/ bool m_StartSizeSet;
            /*0x9a*/ bool m_StartColorSet;
            /*0x9b*/ bool m_RandomSeedSet;
            /*0x9c*/ bool m_StartLifetimeSet;
            /*0x9d*/ bool m_MeshIndexSet;
            /*0x9e*/ bool m_ApplyShapeToPosition;
        }

        struct PlaybackState
        {
            /*0x10*/ float m_AccumulatedDt;
            /*0x14*/ float m_StartDelay;
            /*0x18*/ float m_PlaybackTime;
            /*0x1c*/ int m_RingBufferIndex;
            /*0x20*/ UnityEngine.ParticleSystem.PlaybackState.Emission m_Emission;
            /*0x38*/ UnityEngine.ParticleSystem.PlaybackState.Initial m_Initial;
            /*0x78*/ UnityEngine.ParticleSystem.PlaybackState.Shape m_Shape;
            /*0xd4*/ UnityEngine.ParticleSystem.PlaybackState.Force m_Force;
            /*0x114*/ UnityEngine.ParticleSystem.PlaybackState.Collision m_Collision;
            /*0x154*/ UnityEngine.ParticleSystem.PlaybackState.Noise m_Noise;
            /*0x158*/ UnityEngine.ParticleSystem.PlaybackState.Lights m_Lights;
            /*0x16c*/ UnityEngine.ParticleSystem.PlaybackState.Trail m_Trail;

            struct Seed
            {
                /*0x10*/ uint x;
                /*0x14*/ uint y;
                /*0x18*/ uint z;
                /*0x1c*/ uint w;
            }

            struct Seed4
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed x;
                /*0x20*/ UnityEngine.ParticleSystem.PlaybackState.Seed y;
                /*0x30*/ UnityEngine.ParticleSystem.PlaybackState.Seed z;
                /*0x40*/ UnityEngine.ParticleSystem.PlaybackState.Seed w;
            }

            struct Emission
            {
                /*0x10*/ float m_ParticleSpacing;
                /*0x14*/ float m_ToEmitAccumulator;
                /*0x18*/ UnityEngine.ParticleSystem.PlaybackState.Seed m_Random;
            }

            struct Initial
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
            }

            struct Shape
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
                /*0x50*/ float m_RadiusTimer;
                /*0x54*/ float m_RadiusTimerPrev;
                /*0x58*/ float m_ArcTimer;
                /*0x5c*/ float m_ArcTimerPrev;
                /*0x60*/ float m_MeshSpawnTimer;
                /*0x64*/ float m_MeshSpawnTimerPrev;
                /*0x68*/ int m_OrderedMeshVertexIndex;
            }

            struct Force
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
            }

            struct Collision
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random;
            }

            struct Noise
            {
                /*0x10*/ float m_ScrollOffset;
            }

            struct Lights
            {
                /*0x10*/ UnityEngine.ParticleSystem.PlaybackState.Seed m_Random;
                /*0x20*/ float m_ParticleEmissionCounter;
            }

            struct Trail
            {
                /*0x10*/ float m_Timer;
            }
        }

        struct Trails
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Vector4> positions;
            /*0x18*/ System.Collections.Generic.List<int> frontPositions;
            /*0x20*/ System.Collections.Generic.List<int> backPositions;
            /*0x28*/ System.Collections.Generic.List<int> positionCounts;
            /*0x30*/ int maxTrailCount;
            /*0x34*/ int maxPositionsPerTrailCount;

            /*0x2906ce0*/ void Allocate();
        }

        struct ColliderData
        {
            /*0x10*/ UnityEngine.Component[] colliders;
            /*0x18*/ int[] colliderIndices;
            /*0x20*/ int[] particleStartIndices;
        }
    }

    struct ParticleCollisionEvent
    {
        /*0x10*/ UnityEngine.Vector3 m_Intersection;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ UnityEngine.Vector3 m_Velocity;
        /*0x34*/ int m_ColliderInstanceID;

        static /*0x290c1b0*/ UnityEngine.Component InstanceIDToColliderComponent(int instanceID);
        /*0x290c1ec*/ UnityEngine.Vector3 get_intersection();
        /*0x290c1f8*/ UnityEngine.Vector3 get_normal();
        /*0x290c204*/ UnityEngine.Vector3 get_velocity();
        /*0x290c210*/ UnityEngine.Component get_colliderComponent();
    }

    class ParticleSystemExtensionsImpl
    {
        static /*0x290c24c*/ int GetSafeCollisionEventSize(UnityEngine.ParticleSystem ps);
        static /*0x290c288*/ int GetCollisionEventsDeprecated(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, UnityEngine.ParticleCollisionEvent[] collisionEvents);
        static /*0x290c2dc*/ int GetSafeTriggerParticlesSize(UnityEngine.ParticleSystem ps, int type);
        static /*0x290c320*/ int GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents);
        static /*0x290c374*/ int GetTriggerParticles(UnityEngine.ParticleSystem ps, int type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        static /*0x290c3c8*/ int GetTriggerParticlesWithData(UnityEngine.ParticleSystem ps, int type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, ref UnityEngine.ParticleSystem.ColliderData colliderData);
        static /*0x290c424*/ void SetTriggerParticles(UnityEngine.ParticleSystem ps, int type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, int offset, int count);
        /*0x290c490*/ ParticleSystemExtensionsImpl();
    }

    class ParticlePhysicsExtensions
    {
        static /*0x290c498*/ int GetSafeCollisionEventSize(UnityEngine.ParticleSystem ps);
        static /*0x290c4d4*/ int GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents);
        static /*0x290c528*/ int GetSafeTriggerParticlesSize(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type);
        static /*0x290c56c*/ int GetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        static /*0x290c5c0*/ int GetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, ref UnityEngine.ParticleSystem.ColliderData colliderData);
        static /*0x290c6a4*/ void SetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, int offset, int count);
        static /*0x290c818*/ void SetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles);
        static /*0x290c8a0*/ int GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, UnityEngine.ParticleCollisionEvent[] collisionEvents);
    }

    class ParticleSystemForceField : UnityEngine.Behaviour
    {
        /*0x290d97c*/ ParticleSystemForceField();
        /*0x290c9b4*/ UnityEngine.ParticleSystemForceFieldShape get_shape();
        /*0x290c9f0*/ void set_shape(UnityEngine.ParticleSystemForceFieldShape value);
        /*0x290ca34*/ float get_startRange();
        /*0x290ca70*/ void set_startRange(float value);
        /*0x290cabc*/ float get_endRange();
        /*0x290caf8*/ void set_endRange(float value);
        /*0x290cb44*/ float get_length();
        /*0x290cb80*/ void set_length(float value);
        /*0x290cbcc*/ float get_gravityFocus();
        /*0x290cc08*/ void set_gravityFocus(float value);
        /*0x290cc54*/ UnityEngine.Vector2 get_rotationRandomness();
        /*0x290cce4*/ void set_rotationRandomness(UnityEngine.Vector2 value);
        /*0x290cd70*/ bool get_multiplyDragByParticleSize();
        /*0x290cdac*/ void set_multiplyDragByParticleSize(bool value);
        /*0x290cdf0*/ bool get_multiplyDragByParticleVelocity();
        /*0x290ce2c*/ void set_multiplyDragByParticleVelocity(bool value);
        /*0x290ce70*/ UnityEngine.Texture3D get_vectorField();
        /*0x290ceac*/ void set_vectorField(UnityEngine.Texture3D value);
        /*0x290cef0*/ UnityEngine.ParticleSystem.MinMaxCurve get_directionX();
        /*0x290cf94*/ void set_directionX(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d01c*/ UnityEngine.ParticleSystem.MinMaxCurve get_directionY();
        /*0x290d0c0*/ void set_directionY(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d148*/ UnityEngine.ParticleSystem.MinMaxCurve get_directionZ();
        /*0x290d1ec*/ void set_directionZ(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d274*/ UnityEngine.ParticleSystem.MinMaxCurve get_gravity();
        /*0x290d318*/ void set_gravity(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d3a0*/ UnityEngine.ParticleSystem.MinMaxCurve get_rotationSpeed();
        /*0x290d444*/ void set_rotationSpeed(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d4cc*/ UnityEngine.ParticleSystem.MinMaxCurve get_rotationAttraction();
        /*0x290d570*/ void set_rotationAttraction(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d5f8*/ UnityEngine.ParticleSystem.MinMaxCurve get_drag();
        /*0x290d69c*/ void set_drag(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d724*/ UnityEngine.ParticleSystem.MinMaxCurve get_vectorFieldSpeed();
        /*0x290d7c8*/ void set_vectorFieldSpeed(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d850*/ UnityEngine.ParticleSystem.MinMaxCurve get_vectorFieldAttraction();
        /*0x290d8f4*/ void set_vectorFieldAttraction(UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290cca0*/ void get_rotationRandomness_Injected(ref UnityEngine.Vector2 ret);
        /*0x290cd2c*/ void set_rotationRandomness_Injected(ref UnityEngine.Vector2 value);
        /*0x290cf50*/ void get_directionX_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290cfd8*/ void set_directionX_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d07c*/ void get_directionY_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d104*/ void set_directionY_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d1a8*/ void get_directionZ_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d230*/ void set_directionZ_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d2d4*/ void get_gravity_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d35c*/ void set_gravity_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d400*/ void get_rotationSpeed_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d488*/ void set_rotationSpeed_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d52c*/ void get_rotationAttraction_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d5b4*/ void set_rotationAttraction_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d658*/ void get_drag_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d6e0*/ void set_drag_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d784*/ void get_vectorFieldSpeed_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d80c*/ void set_vectorFieldSpeed_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
        /*0x290d8b0*/ void get_vectorFieldAttraction_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve ret);
        /*0x290d938*/ void set_vectorFieldAttraction_Injected(ref UnityEngine.ParticleSystem.MinMaxCurve value);
    }

    class ParticleSystemRenderer : UnityEngine.Renderer
    {
        /*0x290f8b8*/ ParticleSystemRenderer();
        /*0x290d984*/ UnityEngine.ParticleSystemRenderSpace get_alignment();
        /*0x290d9c0*/ void set_alignment(UnityEngine.ParticleSystemRenderSpace value);
        /*0x290da04*/ UnityEngine.ParticleSystemRenderMode get_renderMode();
        /*0x290da40*/ void set_renderMode(UnityEngine.ParticleSystemRenderMode value);
        /*0x290da84*/ UnityEngine.ParticleSystemMeshDistribution get_meshDistribution();
        /*0x290dac0*/ void set_meshDistribution(UnityEngine.ParticleSystemMeshDistribution value);
        /*0x290db04*/ UnityEngine.ParticleSystemSortMode get_sortMode();
        /*0x290db40*/ void set_sortMode(UnityEngine.ParticleSystemSortMode value);
        /*0x290db84*/ float get_lengthScale();
        /*0x290dbc0*/ void set_lengthScale(float value);
        /*0x290dc0c*/ float get_velocityScale();
        /*0x290dc48*/ void set_velocityScale(float value);
        /*0x290dc94*/ float get_cameraVelocityScale();
        /*0x290dcd0*/ void set_cameraVelocityScale(float value);
        /*0x290dd1c*/ float get_normalDirection();
        /*0x290dd58*/ void set_normalDirection(float value);
        /*0x290dda4*/ float get_shadowBias();
        /*0x290dde0*/ void set_shadowBias(float value);
        /*0x290de2c*/ float get_sortingFudge();
        /*0x290de68*/ void set_sortingFudge(float value);
        /*0x290deb4*/ float get_minParticleSize();
        /*0x290def0*/ void set_minParticleSize(float value);
        /*0x290df3c*/ float get_maxParticleSize();
        /*0x290df78*/ void set_maxParticleSize(float value);
        /*0x290dfc4*/ UnityEngine.Vector3 get_pivot();
        /*0x290e064*/ void set_pivot(UnityEngine.Vector3 value);
        /*0x290e0fc*/ UnityEngine.Vector3 get_flip();
        /*0x290e19c*/ void set_flip(UnityEngine.Vector3 value);
        /*0x290e234*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x290e270*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x290e2b4*/ UnityEngine.Material get_trailMaterial();
        /*0x290e2f0*/ void set_trailMaterial(UnityEngine.Material value);
        /*0x290e334*/ void set_oldTrailMaterial(UnityEngine.Material value);
        /*0x290e378*/ bool get_enableGPUInstancing();
        /*0x290e3b4*/ void set_enableGPUInstancing(bool value);
        /*0x290e3f8*/ bool get_allowRoll();
        /*0x290e434*/ void set_allowRoll(bool value);
        /*0x290e478*/ bool get_freeformStretching();
        /*0x290e4b4*/ void set_freeformStretching(bool value);
        /*0x290e4f8*/ bool get_rotateWithStretchDirection();
        /*0x290e534*/ void set_rotateWithStretchDirection(bool value);
        /*0x290e578*/ UnityEngine.Mesh get_mesh();
        /*0x290e5b4*/ void set_mesh(UnityEngine.Mesh value);
        /*0x290e5f8*/ int GetMeshes(UnityEngine.Mesh[] meshes);
        /*0x290e63c*/ void SetMeshes(UnityEngine.Mesh[] meshes, int size);
        /*0x290e690*/ void SetMeshes(UnityEngine.Mesh[] meshes);
        /*0x290e6ec*/ int GetMeshWeightings(float[] weightings);
        /*0x290e730*/ void SetMeshWeightings(float[] weightings, int size);
        /*0x290e784*/ void SetMeshWeightings(float[] weightings);
        /*0x290e7e0*/ int get_meshCount();
        /*0x290e81c*/ void BakeMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x290e880*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x290e8dc*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x290e940*/ void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x290e99c*/ int get_activeVertexStreamsCount();
        /*0x290e9d8*/ void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x290ea1c*/ void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams);
        /*0x290ea60*/ void EnableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x290f614*/ void DisableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x290f61c*/ bool AreVertexStreamsEnabled(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x290f8b4*/ UnityEngine.ParticleSystemVertexStreams GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x290ea68*/ void Internal_SetVertexStreams(UnityEngine.ParticleSystemVertexStreams streams, bool enabled);
        /*0x290f638*/ UnityEngine.ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams);
        /*0x290e020*/ void get_pivot_Injected(ref UnityEngine.Vector3 ret);
        /*0x290e0b8*/ void set_pivot_Injected(ref UnityEngine.Vector3 value);
        /*0x290e158*/ void get_flip_Injected(ref UnityEngine.Vector3 ret);
        /*0x290e1f0*/ void set_flip_Injected(ref UnityEngine.Vector3 value);
    }

    enum ParticleSystemVertexStreams
    {
        Position = 1,
        Normal = 2,
        Tangent = 4,
        Color = 8,
        UV = 16,
        UV2BlendAndFrame = 32,
        CenterAndVertexID = 64,
        Size = 128,
        Rotation = 256,
        Velocity = 512,
        Lifetime = 1024,
        Custom1 = 2048,
        Custom2 = 4096,
        Random = 8192,
        None = 0,
        All = 2147483647,
    }

    enum ParticleSystemRenderMode
    {
        Billboard = 0,
        Stretch = 1,
        HorizontalBillboard = 2,
        VerticalBillboard = 3,
        Mesh = 4,
        None = 5,
    }

    enum ParticleSystemMeshDistribution
    {
        UniformRandom = 0,
        NonUniformRandom = 1,
    }

    enum ParticleSystemSortMode
    {
        None = 0,
        Distance = 1,
        OldestInFront = 2,
        YoungestInFront = 3,
        Depth = 4,
    }

    enum ParticleSystemCollisionQuality
    {
        High = 0,
        Medium = 1,
        Low = 2,
    }

    enum ParticleSystemRenderSpace
    {
        View = 0,
        World = 1,
        Local = 2,
        Facing = 3,
        Velocity = 4,
    }

    enum ParticleSystemCurveMode
    {
        Constant = 0,
        Curve = 1,
        TwoCurves = 2,
        TwoConstants = 3,
    }

    enum ParticleSystemGradientMode
    {
        Color = 0,
        Gradient = 1,
        TwoColors = 2,
        TwoGradients = 3,
        RandomColor = 4,
    }

    enum ParticleSystemShapeType
    {
        Sphere = 0,
        SphereShell = 1,
        Hemisphere = 2,
        HemisphereShell = 3,
        Cone = 4,
        Box = 5,
        Mesh = 6,
        ConeShell = 7,
        ConeVolume = 8,
        ConeVolumeShell = 9,
        Circle = 10,
        CircleEdge = 11,
        SingleSidedEdge = 12,
        MeshRenderer = 13,
        SkinnedMeshRenderer = 14,
        BoxShell = 15,
        BoxEdge = 16,
        Donut = 17,
        Rectangle = 18,
        Sprite = 19,
        SpriteRenderer = 20,
    }

    enum ParticleSystemMeshShapeType
    {
        Vertex = 0,
        Edge = 1,
        Triangle = 2,
    }

    enum ParticleSystemShapeTextureChannel
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Alpha = 3,
    }

    enum ParticleSystemAnimationMode
    {
        Grid = 0,
        Sprites = 1,
    }

    enum ParticleSystemAnimationTimeMode
    {
        Lifetime = 0,
        Speed = 1,
        FPS = 2,
    }

    enum ParticleSystemAnimationType
    {
        WholeSheet = 0,
        SingleRow = 1,
    }

    enum ParticleSystemAnimationRowMode
    {
        Custom = 0,
        Random = 1,
        MeshIndex = 2,
    }

    enum ParticleSystemCollisionType
    {
        Planes = 0,
        World = 1,
    }

    enum ParticleSystemCollisionMode
    {
        Collision3D = 0,
        Collision2D = 1,
    }

    enum ParticleSystemOverlapAction
    {
        Ignore = 0,
        Kill = 1,
        Callback = 2,
    }

    enum ParticleSystemColliderQueryMode
    {
        Disabled = 0,
        One = 1,
        All = 2,
    }

    enum ParticleSystemSimulationSpace
    {
        Local = 0,
        World = 1,
        Custom = 2,
    }

    enum ParticleSystemStopBehavior
    {
        StopEmittingAndClear = 0,
        StopEmitting = 1,
    }

    enum ParticleSystemScalingMode
    {
        Hierarchy = 0,
        Local = 1,
        Shape = 2,
    }

    enum ParticleSystemStopAction
    {
        None = 0,
        Disable = 1,
        Destroy = 2,
        Callback = 3,
    }

    enum ParticleSystemCullingMode
    {
        Automatic = 0,
        PauseAndCatchup = 1,
        Pause = 2,
        AlwaysSimulate = 3,
    }

    enum ParticleSystemEmitterVelocityMode
    {
        Transform = 0,
        Rigidbody = 1,
        Custom = 2,
    }

    enum ParticleSystemInheritVelocityMode
    {
        Initial = 0,
        Current = 1,
    }

    enum ParticleSystemTriggerEventType
    {
        Inside = 0,
        Outside = 1,
        Enter = 2,
        Exit = 3,
    }

    enum ParticleSystemVertexStream
    {
        Position = 0,
        Normal = 1,
        Tangent = 2,
        Color = 3,
        UV = 4,
        UV2 = 5,
        UV3 = 6,
        UV4 = 7,
        AnimBlend = 8,
        AnimFrame = 9,
        Center = 10,
        VertexID = 11,
        SizeX = 12,
        SizeXY = 13,
        SizeXYZ = 14,
        Rotation = 15,
        Rotation3D = 16,
        RotationSpeed = 17,
        RotationSpeed3D = 18,
        Velocity = 19,
        Speed = 20,
        AgePercent = 21,
        InvStartLifetime = 22,
        StableRandomX = 23,
        StableRandomXY = 24,
        StableRandomXYZ = 25,
        StableRandomXYZW = 26,
        VaryingRandomX = 27,
        VaryingRandomXY = 28,
        VaryingRandomXYZ = 29,
        VaryingRandomXYZW = 30,
        Custom1X = 31,
        Custom1XY = 32,
        Custom1XYZ = 33,
        Custom1XYZW = 34,
        Custom2X = 35,
        Custom2XY = 36,
        Custom2XYZ = 37,
        Custom2XYZW = 38,
        NoiseSumX = 39,
        NoiseSumXY = 40,
        NoiseSumXYZ = 41,
        NoiseImpulseX = 42,
        NoiseImpulseXY = 43,
        NoiseImpulseXYZ = 44,
        MeshIndex = 45,
    }

    enum ParticleSystemCustomData
    {
        Custom1 = 0,
        Custom2 = 1,
    }

    enum ParticleSystemCustomDataMode
    {
        Disabled = 0,
        Vector = 1,
        Color = 2,
    }

    enum ParticleSystemNoiseQuality
    {
        Low = 0,
        Medium = 1,
        High = 2,
    }

    enum ParticleSystemSubEmitterType
    {
        Birth = 0,
        Collision = 1,
        Death = 2,
        Trigger = 3,
        Manual = 4,
    }

    enum ParticleSystemSubEmitterProperties
    {
        InheritNothing = 0,
        InheritEverything = 31,
        InheritColor = 1,
        InheritSize = 2,
        InheritRotation = 4,
        InheritLifetime = 8,
        InheritDuration = 16,
    }

    enum ParticleSystemTrailMode
    {
        PerParticle = 0,
        Ribbon = 1,
    }

    enum ParticleSystemTrailTextureMode
    {
        Stretch = 0,
        Tile = 1,
        DistributePerSegment = 2,
        RepeatPerSegment = 3,
    }

    enum ParticleSystemShapeMultiModeValue
    {
        Random = 0,
        Loop = 1,
        PingPong = 2,
        BurstSpread = 3,
    }

    enum ParticleSystemRingBufferMode
    {
        Disabled = 0,
        PauseUntilReplaced = 1,
        LoopUntilReplaced = 2,
    }

    enum ParticleSystemGameObjectFilter
    {
        LayerMask = 0,
        List = 1,
        LayerMaskAndList = 2,
    }

    enum ParticleSystemForceFieldShape
    {
        Sphere = 0,
        Hemisphere = 1,
        Cylinder = 2,
        Box = 3,
    }

    enum ParticleSystemEmissionType
    {
        Time = 0,
        Distance = 1,
    }

    namespace Rendering
    {
        enum UVChannelFlags
        {
            UV0 = 1,
            UV1 = 2,
            UV2 = 4,
            UV3 = 8,
        }
    }

    namespace ParticleSystemJobs
    {
        interface IJobParticleSystem
        {
            void Execute(UnityEngine.ParticleSystemJobs.ParticleSystemJobData jobData);
        }

        interface IJobParticleSystemParallelFor
        {
            void Execute(UnityEngine.ParticleSystemJobs.ParticleSystemJobData jobData, int index);
        }

        interface IJobParticleSystemParallelForBatch
        {
            void Execute(UnityEngine.ParticleSystemJobs.ParticleSystemJobData jobData, int startIndex, int count);
        }

        class IParticleSystemJobExtensions
        {
            static Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.ParticleSystem ps, Unity.Jobs.JobHandle dependsOn);
            static Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.ParticleSystem ps, int minIndicesPerJobCount, Unity.Jobs.JobHandle dependsOn);
            static Unity.Jobs.JobHandle ScheduleBatch<T>(T jobData, UnityEngine.ParticleSystem ps, int innerLoopBatchCount, Unity.Jobs.JobHandle dependsOn);
            static Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, UnityEngine.ParticleSystem ps, Unity.Jobs.JobHandle dependsOn, nint jobReflectionData);
        }

        struct ParticleSystemNativeArray3
        {
            /*0x10*/ Unity.Collections.NativeArray<float> x;
            /*0x20*/ Unity.Collections.NativeArray<float> y;
            /*0x30*/ Unity.Collections.NativeArray<float> z;

            /*0x290f8c0*/ UnityEngine.Vector3 get_Item(int index);
            /*0x290f8dc*/ void set_Item(int index, UnityEngine.Vector3 value);
        }

        struct ParticleSystemNativeArray4
        {
            /*0x10*/ Unity.Collections.NativeArray<float> x;
            /*0x20*/ Unity.Collections.NativeArray<float> y;
            /*0x30*/ Unity.Collections.NativeArray<float> z;
            /*0x40*/ Unity.Collections.NativeArray<float> w;

            /*0x290f8f8*/ UnityEngine.Vector4 get_Item(int index);
            /*0x290f91c*/ void set_Item(int index, UnityEngine.Vector4 value);
        }

        struct ParticleSystemJobData
        {
            /*0x10*/ int <count>k__BackingField;
            /*0x18*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <positions>k__BackingField;
            /*0x48*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <velocities>k__BackingField;
            /*0x78*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <axisOfRotations>k__BackingField;
            /*0xa8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotations>k__BackingField;
            /*0xd8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField;
            /*0x108*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <sizes>k__BackingField;
            /*0x138*/ Unity.Collections.NativeArray<UnityEngine.Color32> <startColors>k__BackingField;
            /*0x148*/ Unity.Collections.NativeArray<float> <aliveTimePercent>k__BackingField;
            /*0x158*/ Unity.Collections.NativeArray<float> <inverseStartLifetimes>k__BackingField;
            /*0x168*/ Unity.Collections.NativeArray<uint> <randomSeeds>k__BackingField;
            /*0x178*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData1>k__BackingField;
            /*0x1b8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData2>k__BackingField;
            /*0x1f8*/ Unity.Collections.NativeArray<int> <meshIndices>k__BackingField;

            /*0x290fa44*/ ParticleSystemJobData(ref UnityEngine.ParticleSystemJobs.NativeParticleData nativeData);
            /*0x290f940*/ int get_count();
            /*0x290f948*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 get_positions();
            /*0x290f960*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 get_velocities();
            /*0x290f978*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 get_axisOfRotations();
            /*0x290f990*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 get_rotations();
            /*0x290f9a8*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 get_rotationalSpeeds();
            /*0x290f9c0*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 get_sizes();
            /*0x290f9d8*/ Unity.Collections.NativeArray<UnityEngine.Color32> get_startColors();
            /*0x290f9e4*/ Unity.Collections.NativeArray<float> get_aliveTimePercent();
            /*0x290f9f0*/ Unity.Collections.NativeArray<float> get_inverseStartLifetimes();
            /*0x290f9fc*/ Unity.Collections.NativeArray<uint> get_randomSeeds();
            /*0x290fa08*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 get_customData1();
            /*0x290fa20*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 get_customData2();
            /*0x290fa38*/ Unity.Collections.NativeArray<int> get_meshIndices();
            Unity.Collections.NativeArray<T> CreateNativeArray<T>(void* src, int count);
            /*0x290fcb0*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 CreateNativeArray3(ref UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 ptrs, int count);
            /*0x290fd74*/ UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 CreateNativeArray4(ref UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 ptrs, int count);
        }

        struct NativeParticleData
        {
            /*0x10*/ int count;
            /*0x18*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 positions;
            /*0x30*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 velocities;
            /*0x48*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 axisOfRotations;
            /*0x60*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 rotations;
            /*0x78*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 rotationalSpeeds;
            /*0x90*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 sizes;
            /*0xa8*/ void* startColors;
            /*0xb0*/ void* aliveTimePercent;
            /*0xb8*/ void* inverseStartLifetimes;
            /*0xc0*/ void* randomSeeds;
            /*0xc8*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 customData1;
            /*0xe8*/ UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 customData2;
            /*0x108*/ void* meshIndices;

            struct Array3
            {
                /*0x10*/ float* x;
                /*0x18*/ float* y;
                /*0x20*/ float* z;
            }

            struct Array4
            {
                /*0x10*/ float* x;
                /*0x18*/ float* y;
                /*0x20*/ float* z;
                /*0x28*/ float* w;
            }
        }

        struct NativeListData
        {
            /*0x10*/ void* system;
            /*0x18*/ int length;
            /*0x1c*/ int capacity;
        }

        struct ParticleSystemJobStruct<T>
        {
            static /*0x0*/ nint jobReflectionData;

            static nint Initialize();
            static void Execute(ref T data, nint listDataPtr, nint unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

            class ExecuteJobFunction<T> : System.MulticastDelegate
            {
                ExecuteJobFunction(object object, nint method);
                void Invoke(ref T data, nint listDataPtr, nint unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
            }
        }

        struct ParticleSystemParallelForJobStruct<T>
        {
            static /*0x0*/ nint jobReflectionData;

            static nint Initialize();
            static void Execute(ref T data, nint listDataPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

            class ExecuteJobFunction<T> : System.MulticastDelegate
            {
                ExecuteJobFunction(object object, nint method);
                void Invoke(ref T data, nint listDataPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
            }
        }

        struct ParticleSystemParallelForBatchJobStruct<T>
        {
            static /*0x0*/ nint jobReflectionData;

            static nint Initialize();
            static void Execute(ref T data, nint listDataPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

            class ExecuteJobFunction<T> : System.MulticastDelegate
            {
                ExecuteJobFunction(object object, nint method);
                void Invoke(ref T data, nint listDataPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
            }
        }
    }
}
