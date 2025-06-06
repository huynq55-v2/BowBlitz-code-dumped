class <Module>
{
}

namespace Coffee
{
    namespace UIParticleExtensions
    {
        class ModifiedMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<Coffee.UIParticleExtensions.ModifiedMaterial.MatEntry> s_Entries;

            static /*0xddfe78*/ ModifiedMaterial();
            static /*0xddf944*/ UnityEngine.Material Add(UnityEngine.Material baseMat, UnityEngine.Texture texture, int id);
            static /*0xddfc10*/ void Remove(UnityEngine.Material customMat);
            static /*0xddfdcc*/ void DestroyImmediate(UnityEngine.Object obj);
            /*0xddfe70*/ ModifiedMaterial();

            class MatEntry
            {
                /*0x10*/ UnityEngine.Material baseMat;
                /*0x18*/ UnityEngine.Material customMat;
                /*0x20*/ int count;
                /*0x28*/ UnityEngine.Texture texture;
                /*0x30*/ int id;

                /*0xddfc08*/ MatEntry();
            }
        }

        class Vector3Extensions
        {
            static /*0xddff04*/ UnityEngine.Vector3 Inverse(UnityEngine.Vector3 self);
            static /*0xddffe4*/ UnityEngine.Vector3 GetScaled(UnityEngine.Vector3 self, UnityEngine.Vector3 other1);
            static /*0xddfff4*/ UnityEngine.Vector3 GetScaled(UnityEngine.Vector3 self, UnityEngine.Vector3 other1, UnityEngine.Vector3 other2);
            static /*0xde0018*/ UnityEngine.Vector3 GetScaled(UnityEngine.Vector3 self, UnityEngine.Vector3 other1, UnityEngine.Vector3 other2, UnityEngine.Vector3 other3);
            static /*0xde0050*/ bool IsVisible(UnityEngine.Vector3 self);
        }

        class SpriteExtensions
        {
            static /*0xde0068*/ UnityEngine.Texture2D GetActualTexture(UnityEngine.Sprite self);
        }

        class ParticleSystemExtensions
        {
            static /*0x0*/ UnityEngine.ParticleSystem.Particle[] s_TmpParticles;

            static /*0xde0810*/ ParticleSystemExtensions();
            static /*0xde00e8*/ UnityEngine.ParticleSystem.Particle[] GetParticleArray(int size);
            static /*0xde0204*/ bool CanBakeMesh(UnityEngine.ParticleSystemRenderer self);
            static /*0xde02b4*/ UnityEngine.ParticleSystemSimulationSpace GetActualSimulationSpace(UnityEngine.ParticleSystem self);
            static /*0xde0360*/ void SortForRendering(System.Collections.Generic.List<UnityEngine.ParticleSystem> self, UnityEngine.Transform transform, bool sortByMaterial);
            static /*0xde0450*/ int GetIndex(System.Collections.Generic.IList<UnityEngine.ParticleSystem> list, UnityEngine.Object ps);
            static /*0xde05b8*/ UnityEngine.Texture2D GetTextureForSprite(UnityEngine.ParticleSystem self);
            static /*0xde06ec*/ void Exec(System.Collections.Generic.List<UnityEngine.ParticleSystem> self, System.Action<UnityEngine.ParticleSystem> action);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Transform transform;
                /*0x18*/ bool sortByMaterial;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> self;

                /*0xde0448*/ <>c__DisplayClass4_0();
                /*0xde0878*/ int <SortForRendering>b__0(UnityEngine.ParticleSystem a, UnityEngine.ParticleSystem b);
            }

            class <>c
            {
                static /*0x0*/ Coffee.UIParticleExtensions.ParticleSystemExtensions.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.ParticleSystem> <>9__7_0;

                static /*0xde0c84*/ <>c();
                /*0xde0ce8*/ <>c();
                /*0xde0cf0*/ bool <Exec>b__7_0(UnityEngine.ParticleSystem p);
            }
        }
    }

    namespace UIExtensions
    {
        class AnimatableProperty : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ string m_Name;
            /*0x18*/ Coffee.UIExtensions.AnimatableProperty.ShaderPropertyType m_Type;
            /*0x1c*/ int <id>k__BackingField;

            /*0xde0f70*/ AnimatableProperty();
            /*0xde0d54*/ int get_id();
            /*0xde0d5c*/ void set_id(int value);
            /*0xde0d64*/ Coffee.UIExtensions.AnimatableProperty.ShaderPropertyType get_type();
            /*0xde0d6c*/ void UpdateMaterialProperties(UnityEngine.Material material, UnityEngine.MaterialPropertyBlock mpb);
            /*0xde0f4c*/ void OnBeforeSerialize();
            /*0xde0f50*/ void OnAfterDeserialize();

            enum ShaderPropertyType
            {
                Color = 0,
                Vector = 1,
                Float = 2,
                Range = 3,
                Texture = 4,
            }
        }

        class UIParticle : UnityEngine.UI.MaskableGraphic
        {
            /*0xd0*/ bool m_IsTrail;
            /*0xd4*/ UnityEngine.Vector3 m_Scale3D;
            /*0xe0*/ Coffee.UIExtensions.AnimatableProperty[] m_AnimatableProperties;
            /*0xe8*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> m_Particles;
            /*0xf0*/ Coffee.UIExtensions.UIParticle.MeshSharing m_MeshSharing;
            /*0xf4*/ int m_GroupId;
            /*0xf8*/ int m_GroupMaxId;
            /*0xfc*/ bool m_AbsoluteMode;
            /*0x100*/ System.Collections.Generic.List<Coffee.UIExtensions.UIParticleRenderer> m_Renderers;
            /*0x108*/ UnityEngine.DrivenRectTransformTracker _tracker;
            /*0x110*/ UnityEngine.Camera _orthoCamera;
            /*0x118*/ int _groupId;
            /*0x11c*/ bool <isPaused>k__BackingField;

            /*0xde4474*/ UIParticle();
            /*0xde0fc8*/ bool get_raycastTarget();
            /*0xde0fd0*/ void set_raycastTarget(bool value);
            /*0xde0fd4*/ Coffee.UIExtensions.UIParticle.MeshSharing get_meshSharing();
            /*0xde0fdc*/ void set_meshSharing(Coffee.UIExtensions.UIParticle.MeshSharing value);
            /*0xde0fe4*/ int get_groupId();
            /*0xde0fec*/ void set_groupId(int value);
            /*0xde1060*/ int get_groupMaxId();
            /*0xde1068*/ void set_groupMaxId(int value);
            /*0xde10a8*/ bool get_absoluteMode();
            /*0xde10b0*/ void set_absoluteMode(bool value);
            /*0xde10bc*/ bool get_useMeshSharing();
            /*0xde10cc*/ bool get_isPrimary();
            /*0xde10e0*/ bool get_canSimulate();
            /*0xde1104*/ bool get_canRender();
            /*0xde112c*/ float get_scale();
            /*0xde1134*/ void set_scale(float value);
            /*0xde1140*/ UnityEngine.Vector3 get_scale3D();
            /*0xde114c*/ void set_scale3D(UnityEngine.Vector3 value);
            /*0xde1158*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> get_particles();
            /*0xde1160*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_materials();
            /*0xde120c*/ UnityEngine.Material get_materialForRendering();
            /*0xde1214*/ bool get_isPaused();
            /*0xde121c*/ void set_isPaused(bool value);
            /*0xde1228*/ void Play();
            /*0xde1338*/ void Pause();
            /*0xde144c*/ void Resume();
            /*0xde1454*/ void Stop();
            /*0xde1568*/ void Clear();
            /*0xde167c*/ void SetParticleSystemInstance(UnityEngine.GameObject instance);
            /*0xde1684*/ void SetParticleSystemInstance(UnityEngine.GameObject instance, bool destroyOldParticles);
            /*0xde1d24*/ void SetParticleSystemPrefab(UnityEngine.GameObject prefab);
            /*0xde1df8*/ void RefreshParticles();
            /*0xde1a98*/ void RefreshParticles(UnityEngine.GameObject root);
            /*0xde1e18*/ void RefreshParticles(System.Collections.Generic.List<UnityEngine.ParticleSystem> particles);
            /*0xde2638*/ void UpdateTransformScale();
            /*0xde2704*/ void UpdateRenderers();
            /*0xde3abc*/ void UpdateParticleCount();
            /*0xde3c18*/ void OnEnable();
            /*0xde1030*/ void ResetGroupId();
            /*0xde3e64*/ void OnDisable();
            /*0xde40c0*/ void UpdateMaterial();
            /*0xde40c4*/ void UpdateGeometry();
            /*0xde40c8*/ void OnDidApplyAnimationProperties();
            /*0xde40cc*/ void UpdateRendererMaterial();
            /*0xde201c*/ Coffee.UIExtensions.UIParticleRenderer GetRenderer(int index);
            /*0xde28e8*/ UnityEngine.Camera GetBakeCamera();
            /*0xde4570*/ bool <RefreshParticles>b__61_0(UnityEngine.ParticleSystem x);

            enum MeshSharing
            {
                None = 0,
                Auto = 1,
                Primary = 2,
                PrimarySimulator = 3,
                Reprica = 4,
            }

            class <get_materials>d__45 : System.Collections.Generic.IEnumerable<UnityEngine.Material>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Material>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Material <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ Coffee.UIExtensions.UIParticle <>4__this;
                /*0x30*/ int <i>5__2;

                /*0xde11d8*/ <get_materials>d__45(int <>1__state);
                /*0xde4600*/ void System.IDisposable.Dispose();
                /*0xde4604*/ bool MoveNext();
                /*0xde4788*/ UnityEngine.Material System.Collections.Generic.IEnumerator<UnityEngine.Material>.get_Current();
                /*0xde4790*/ void System.Collections.IEnumerator.Reset();
                /*0xde47d0*/ object System.Collections.IEnumerator.get_Current();
                /*0xde47d8*/ System.Collections.Generic.IEnumerator<UnityEngine.Material> System.Collections.Generic.IEnumerable<UnityEngine.Material>.GetEnumerator();
                /*0xde487c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <>c
            {
                static /*0x0*/ Coffee.UIExtensions.UIParticle.<> <>9;
                static /*0x8*/ System.Action<UnityEngine.ParticleSystem> <>9__52_0;
                static /*0x10*/ System.Action<UnityEngine.ParticleSystem> <>9__53_0;
                static /*0x18*/ System.Action<UnityEngine.ParticleSystem> <>9__55_0;
                static /*0x20*/ System.Action<UnityEngine.ParticleSystem> <>9__56_0;
                static /*0x28*/ System.Func<Coffee.UIExtensions.UIParticleRenderer, bool> <>9__64_0;
                static /*0x30*/ System.Action<Coffee.UIExtensions.UIParticleRenderer> <>9__68_0;

                static /*0xde4880*/ <>c();
                /*0xde48e4*/ <>c();
                /*0xde48ec*/ void <Play>b__52_0(UnityEngine.ParticleSystem p);
                /*0xde4910*/ void <Pause>b__53_0(UnityEngine.ParticleSystem p);
                /*0xde4928*/ void <Stop>b__55_0(UnityEngine.ParticleSystem p);
                /*0xde4940*/ void <Clear>b__56_0(UnityEngine.ParticleSystem p);
                /*0xde4958*/ bool <UpdateRenderers>b__64_0(Coffee.UIExtensions.UIParticleRenderer x);
                /*0xde49bc*/ void <OnDisable>b__68_0(Coffee.UIExtensions.UIParticleRenderer r);
            }
        }

        class UIParticleAttractor : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.ParticleSystem m_ParticleSystem;
            /*0x20*/ float m_DestinationRadius;
            /*0x24*/ float m_DelayRate;
            /*0x28*/ float m_MaxSpeed;
            /*0x2c*/ Coffee.UIExtensions.UIParticleAttractor.Movement m_Movement;
            /*0x30*/ UnityEngine.Events.UnityEvent m_OnAttracted;
            /*0x38*/ Coffee.UIExtensions.UIParticle _uiParticle;

            /*0xde5564*/ UIParticleAttractor();
            /*0xde49d4*/ float get_delay();
            /*0xde49dc*/ void set_delay(float value);
            /*0xde49e4*/ float get_maxSpeed();
            /*0xde49ec*/ void set_maxSpeed(float value);
            /*0xde49f4*/ Coffee.UIExtensions.UIParticleAttractor.Movement get_movement();
            /*0xde49fc*/ void set_movement(Coffee.UIExtensions.UIParticleAttractor.Movement value);
            /*0xde4a04*/ void OnEnable();
            /*0xde4c80*/ void OnDisable();
            /*0xde4d98*/ void Attract();
            /*0xde51b0*/ UnityEngine.Vector3 GetDestinationPosition();
            /*0xde53b0*/ UnityEngine.Vector3 GetAttractedPosition(UnityEngine.Vector3 current, UnityEngine.Vector3 target, float duration, float time);

            enum Movement
            {
                Linear = 0,
                Smooth = 1,
                Sphere = 2,
            }
        }

        class UIParticleRenderer : UnityEngine.UI.MaskableGraphic
        {
            static /*0x0*/ UnityEngine.CombineInstance[] s_CombineInstances;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Material> s_Materials;
            static /*0x10*/ UnityEngine.MaterialPropertyBlock s_Mpb;
            static /*0x18*/ System.Collections.Generic.List<Coffee.UIExtensions.UIParticleRenderer> s_Renderers;
            static /*0x20*/ UnityEngine.Vector3[] s_Corners;
            /*0xd0*/ UnityEngine.ParticleSystemRenderer _renderer;
            /*0xd8*/ UnityEngine.ParticleSystem _particleSystem;
            /*0xe0*/ int _prevParticleCount;
            /*0xe8*/ Coffee.UIExtensions.UIParticle _parent;
            /*0xf0*/ int _index;
            /*0xf4*/ bool _isTrail;
            /*0xf8*/ UnityEngine.Material _modifiedMaterial;
            /*0x100*/ UnityEngine.Vector3 _prevScale;
            /*0x10c*/ UnityEngine.Vector3 _prevPsPos;
            /*0x118*/ UnityEngine.Vector2Int _prevScreenSize;
            /*0x120*/ bool _delay;
            /*0x121*/ bool _prewarm;
            /*0x128*/ UnityEngine.Material _currentMaterialForRendering;
            /*0x130*/ UnityEngine.Bounds _lastBounds;

            static /*0xde6d44*/ UIParticleRenderer();
            static /*0xde41dc*/ Coffee.UIExtensions.UIParticleRenderer AddRenderer(Coffee.UIExtensions.UIParticle parent, int index);
            /*0xde6d3c*/ UIParticleRenderer();
            /*0xde5578*/ UnityEngine.Texture get_mainTexture();
            /*0xde55e8*/ bool get_raycastTarget();
            /*0xde55f0*/ UnityEngine.Rect get_rootCanvasRect();
            /*0xde5ad8*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0xde24c8*/ void Clear(int index);
            /*0xde21d4*/ void Set(Coffee.UIExtensions.UIParticle parent, UnityEngine.ParticleSystem particleSystem, bool isTrail);
            /*0xde2c54*/ void UpdateMesh(UnityEngine.Camera bakeCamera);
            /*0xde3b9c*/ void UpdateParticleCount();
            /*0xde69c0*/ void OnEnable();
            /*0xde6b28*/ void OnDisable();
            /*0xde6b98*/ void UpdateGeometry();
            /*0xde6b9c*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0xde5c48*/ UnityEngine.Vector3 GetWorldScale();
            /*0xde639c*/ UnityEngine.Matrix4x4 GetWorldMatrix(UnityEngine.Vector3 psPos, UnityEngine.Vector3 scale);
            /*0xde5c9c*/ void ResolveResolutionChange(UnityEngine.Vector3 psPos, UnityEngine.Vector3 scale);
            /*0xde5f80*/ void Simulate(UnityEngine.Vector3 scale, bool paused);
            /*0xde67c0*/ void UpdateMaterialProperties();
        }

        class UIParticleUpdater
        {
            static /*0x0*/ System.Collections.Generic.List<Coffee.UIExtensions.UIParticle> s_ActiveParticles;
            static /*0x8*/ System.Collections.Generic.List<Coffee.UIExtensions.UIParticleAttractor> s_ActiveAttractors;
            static /*0x10*/ System.Collections.Generic.HashSet<int> s_UpdatedGroupIds;
            static /*0x18*/ int frameCount;

            static /*0xde75f4*/ UIParticleUpdater();
            static /*0xde6e80*/ int get_uiParticleCount();
            static /*0xde3d60*/ void Register(Coffee.UIExtensions.UIParticle particle);
            static /*0xde4000*/ void Unregister(Coffee.UIExtensions.UIParticle particle);
            static /*0xde4b7c*/ void Register(Coffee.UIExtensions.UIParticleAttractor attractor);
            static /*0xde4cd8*/ void Unregister(Coffee.UIExtensions.UIParticleAttractor attractor);
            static /*0xde6ef0*/ void InitializeOnLoad();
            static /*0xde6f98*/ void Refresh();
            static /*0xde6620*/ void GetGroupedRenderers(int groupId, int index, System.Collections.Generic.List<Coffee.UIExtensions.UIParticleRenderer> results);
            static /*0xde74a8*/ Coffee.UIExtensions.UIParticle GetPrimary(int groupId);
        }
    }
}
