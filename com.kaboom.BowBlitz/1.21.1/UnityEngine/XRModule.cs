class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2acd934*/ EmbeddedAttribute();
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
                /*0x2acd93c*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    namespace XR
    {
        enum XRNode
        {
            LeftEye = 0,
            RightEye = 1,
            CenterEye = 2,
            Head = 3,
            LeftHand = 4,
            RightHand = 5,
            GameController = 6,
            TrackingReference = 7,
            HardwareTracker = 8,
        }

        enum InputFeatureType
        {
            Custom = 0,
            Binary = 1,
            DiscreteStates = 2,
            Axis1D = 3,
            Axis2D = 4,
            Axis3D = 5,
            Rotation = 6,
            Hand = 7,
            Bone = 8,
            Eyes = 9,
            kUnityXRInputFeatureTypeInvalid = 4294967295,
        }

        enum ConnectionChangeType
        {
            Connected = 0,
            Disconnected = 1,
            ConfigChange = 2,
        }

        struct InputFeatureUsage : System.IEquatable<UnityEngine.XR.InputFeatureUsage>
        {
            /*0x10*/ string m_Name;
            /*0x18*/ UnityEngine.XR.InputFeatureType m_InternalType;

            /*0x2acd944*/ string get_name();
            /*0x2acd94c*/ UnityEngine.XR.InputFeatureType get_internalType();
            /*0x2acd954*/ bool Equals(object obj);
            /*0x2acd9dc*/ bool Equals(UnityEngine.XR.InputFeatureUsage other);
            /*0x2acda1c*/ int GetHashCode();
        }

        struct InputDevice : System.IEquatable<UnityEngine.XR.InputDevice>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ bool m_Initialized;

            /*0x2acda6c*/ InputDevice(ulong deviceId);
            /*0x2acda7c*/ ulong get_deviceId();
            /*0x2acda94*/ bool Equals(object obj);
            /*0x2acdb28*/ bool Equals(UnityEngine.XR.InputDevice other);
            /*0x2acdb50*/ int GetHashCode();
        }

        struct Hand : System.IEquatable<UnityEngine.XR.Hand>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x2acdb84*/ ulong get_deviceId();
            /*0x2acdb8c*/ uint get_featureIndex();
            /*0x2acdb94*/ bool Equals(object obj);
            /*0x2acdc1c*/ bool Equals(UnityEngine.XR.Hand other);
            /*0x2acdc40*/ int GetHashCode();
        }

        struct Eyes : System.IEquatable<UnityEngine.XR.Eyes>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x2acdc8c*/ ulong get_deviceId();
            /*0x2acdc94*/ uint get_featureIndex();
            /*0x2acdc9c*/ bool Equals(object obj);
            /*0x2acdd24*/ bool Equals(UnityEngine.XR.Eyes other);
            /*0x2acdd48*/ int GetHashCode();
        }

        struct Bone : System.IEquatable<UnityEngine.XR.Bone>
        {
            /*0x10*/ ulong m_DeviceId;
            /*0x18*/ uint m_FeatureIndex;

            /*0x2acdd94*/ ulong get_deviceId();
            /*0x2acdd9c*/ uint get_featureIndex();
            /*0x2acdda4*/ bool Equals(object obj);
            /*0x2acde2c*/ bool Equals(UnityEngine.XR.Bone other);
            /*0x2acde50*/ int GetHashCode();
        }

        class InputDevices
        {
            static /*0x0*/ System.Action<UnityEngine.XR.InputDevice> deviceConnected;
            static /*0x8*/ System.Action<UnityEngine.XR.InputDevice> deviceDisconnected;
            static /*0x10*/ System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged;

            static /*0x2acde9c*/ void InvokeConnectionEvent(ulong deviceId, UnityEngine.XR.ConnectionChangeType change);
        }

        class InputTracking
        {
            static /*0x0*/ System.Action<UnityEngine.XR.XRNodeState> trackingAcquired;
            static /*0x8*/ System.Action<UnityEngine.XR.XRNodeState> trackingLost;
            static /*0x10*/ System.Action<UnityEngine.XR.XRNodeState> nodeAdded;
            static /*0x18*/ System.Action<UnityEngine.XR.XRNodeState> nodeRemoved;

            static /*0x2acdf48*/ void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, long uniqueID, bool tracked);

            enum TrackingStateEventType
            {
                NodeAdded = 0,
                NodeRemoved = 1,
                TrackingAcquired = 2,
                TrackingLost = 3,
            }
        }

        enum AvailableTrackingData
        {
            None = 0,
            PositionAvailable = 1,
            RotationAvailable = 2,
            VelocityAvailable = 4,
            AngularVelocityAvailable = 8,
            AccelerationAvailable = 16,
            AngularAccelerationAvailable = 32,
        }

        struct XRNodeState
        {
            /*0x10*/ UnityEngine.XR.XRNode m_Type;
            /*0x14*/ UnityEngine.XR.AvailableTrackingData m_AvailableFields;
            /*0x18*/ UnityEngine.Vector3 m_Position;
            /*0x24*/ UnityEngine.Quaternion m_Rotation;
            /*0x34*/ UnityEngine.Vector3 m_Velocity;
            /*0x40*/ UnityEngine.Vector3 m_AngularVelocity;
            /*0x4c*/ UnityEngine.Vector3 m_Acceleration;
            /*0x58*/ UnityEngine.Vector3 m_AngularAcceleration;
            /*0x64*/ int m_Tracked;
            /*0x68*/ ulong m_UniqueID;

            /*0x2ace0e0*/ void set_uniqueID(ulong value);
            /*0x2ace0e8*/ void set_nodeType(UnityEngine.XR.XRNode value);
            /*0x2ace0f0*/ void set_tracked(bool value);
        }

        class XRInputSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRInputSubsystem>
        {
            /*0x2ace0fc*/ XRInputSubsystemDescriptor();
        }

        class XRInputSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRInputSubsystemDescriptor>
        {
            /*0x20*/ System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated;
            /*0x28*/ System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged;

            static /*0x2ace144*/ void InvokeTrackingOriginUpdatedEvent(nint internalPtr);
            static /*0x2ace208*/ void InvokeBoundaryChangedEvent(nint internalPtr);
            /*0x2ace2cc*/ XRInputSubsystem();
        }

        class XRMeshSubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRMeshSubsystem>
        {
            /*0x2ace314*/ XRMeshSubsystemDescriptor();
        }

        struct MeshId : System.IEquatable<UnityEngine.XR.MeshId>
        {
            static /*0x0*/ UnityEngine.XR.MeshId s_InvalidId;
            /*0x10*/ ulong m_SubId1;
            /*0x18*/ ulong m_SubId2;

            static /*0x2ace4d0*/ MeshId();
            /*0x2ace35c*/ string ToString();
            /*0x2ace3f0*/ int GetHashCode();
            /*0x2ace424*/ bool Equals(object obj);
            /*0x2ace4ac*/ bool Equals(UnityEngine.XR.MeshId other);
        }

        enum MeshGenerationStatus
        {
            Success = 0,
            InvalidMeshId = 1,
            GenerationAlreadyInProgress = 2,
            Canceled = 3,
            UnknownError = 4,
        }

        class HashCodeHelper
        {
            static /*0x2ace518*/ int Combine(int hash1, int hash2);
            static /*0x2ace528*/ int Combine(int hash1, int hash2, int hash3);
            static /*0x2ace53c*/ int Combine(int hash1, int hash2, int hash3, int hash4);
            static /*0x2ace554*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5);
            static /*0x2ace570*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6);
            static /*0x2ace590*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7);
            static /*0x2ace5b4*/ int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8);
        }

        struct MeshGenerationResult : System.IEquatable<UnityEngine.XR.MeshGenerationResult>
        {
            /*0x10*/ UnityEngine.XR.MeshId <MeshId>k__BackingField;
            /*0x20*/ UnityEngine.Mesh <Mesh>k__BackingField;
            /*0x28*/ UnityEngine.MeshCollider <MeshCollider>k__BackingField;
            /*0x30*/ UnityEngine.XR.MeshGenerationStatus <Status>k__BackingField;
            /*0x34*/ UnityEngine.XR.MeshVertexAttributes <Attributes>k__BackingField;
            /*0x38*/ ulong <Timestamp>k__BackingField;
            /*0x40*/ UnityEngine.Vector3 <Position>k__BackingField;
            /*0x4c*/ UnityEngine.Quaternion <Rotation>k__BackingField;
            /*0x5c*/ UnityEngine.Vector3 <Scale>k__BackingField;

            /*0x2ace5dc*/ UnityEngine.XR.MeshId get_MeshId();
            /*0x2ace5e8*/ UnityEngine.Mesh get_Mesh();
            /*0x2ace5f0*/ UnityEngine.MeshCollider get_MeshCollider();
            /*0x2ace5f8*/ UnityEngine.XR.MeshGenerationStatus get_Status();
            /*0x2ace600*/ UnityEngine.XR.MeshVertexAttributes get_Attributes();
            /*0x2ace608*/ UnityEngine.Vector3 get_Position();
            /*0x2ace614*/ UnityEngine.Quaternion get_Rotation();
            /*0x2ace620*/ UnityEngine.Vector3 get_Scale();
            /*0x2ace62c*/ bool Equals(object obj);
            /*0x2ace6bc*/ bool Equals(UnityEngine.XR.MeshGenerationResult other);
            /*0x2ace840*/ int GetHashCode();
        }

        enum MeshVertexAttributes
        {
            None = 0,
            Normals = 1,
            Tangents = 2,
            UVs = 4,
            Colors = 8,
        }

        class XRMeshSubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRMeshSubsystemDescriptor>
        {
            /*0x2aceaa0*/ XRMeshSubsystem();
            /*0x2acea48*/ void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete);

            struct MeshTransformList : System.IDisposable
            {
                /*0x10*/ nint m_Self;

                static /*0x2aceb24*/ void Dispose(nint self);
                /*0x2aceae8*/ void Dispose();
            }
        }

        class XRDisplaySubsystemDescriptor : UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRDisplaySubsystem>
        {
            /*0x2aceb60*/ XRDisplaySubsystemDescriptor();
        }

        class XRDisplaySubsystem : UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRDisplaySubsystemDescriptor>
        {
            /*0x20*/ System.Action<bool> displayFocusChanged;

            /*0x2acf3a8*/ XRDisplaySubsystem();
            /*0x2aceba8*/ void InvokeDisplayFocusChanged(bool focus);
            /*0x2acebc8*/ void set_scaleOfAllRenderTargets(float value);
            /*0x2acec14*/ void set_zNear(float value);
            /*0x2acec60*/ void set_zFar(float value);
            /*0x2acecac*/ void set_sRGB(bool value);
            /*0x2acecf0*/ void set_textureLayout(UnityEngine.XR.XRDisplaySubsystem.TextureLayout value);
            /*0x2aced34*/ void SetMSAALevel(int level);
            /*0x2aced78*/ void set_disableLegacyRenderer(bool value);
            /*0x2acedbc*/ int GetRenderPassCount();
            /*0x2acedf8*/ void GetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x2aceea0*/ bool Internal_TryGetRenderPass(int renderPassIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
            /*0x2aceef4*/ void EndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x2acefd8*/ bool Internal_TryEndRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x2acf01c*/ void BeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x2acf100*/ bool Internal_TryBeginRecordingIfLateLatched(UnityEngine.Camera camera);
            /*0x2acf144*/ void GetCullingParameters(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x2acf258*/ bool Internal_TryGetCullingParams(UnityEngine.Camera camera, int cullingPassIndex, ref UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters);
            /*0x2acf2b4*/ int GetPreferredMirrorBlitMode();
            /*0x2acf2f0*/ bool GetMirrorViewBlitDesc(UnityEngine.RenderTexture mirrorRt, ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode);
            /*0x2acf34c*/ bool AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);

            enum TextureLayout
            {
                Texture2DArray = 1,
                SingleTexture2D = 2,
                SeparateTexture2Ds = 4,
            }

            struct XRRenderParameter
            {
                /*0x10*/ UnityEngine.Matrix4x4 view;
                /*0x50*/ UnityEngine.Matrix4x4 projection;
                /*0x90*/ UnityEngine.Rect viewport;
                /*0xa0*/ UnityEngine.Mesh occlusionMesh;
                /*0xa8*/ int textureArraySlice;
                /*0xac*/ UnityEngine.Matrix4x4 previousView;
                /*0xec*/ bool isPreviousViewValid;
            }

            struct XRRenderPass
            {
                /*0x10*/ nint displaySubsystemInstance;
                /*0x18*/ int renderPassIndex;
                /*0x20*/ UnityEngine.Rendering.RenderTargetIdentifier renderTarget;
                /*0x48*/ UnityEngine.RenderTextureDescriptor renderTargetDesc;
                /*0x7c*/ bool hasMotionVectorPass;
                /*0x80*/ UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget;
                /*0xa8*/ UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc;
                /*0xdc*/ bool shouldFillOutDepth;
                /*0xe0*/ int cullingPassIndex;

                static /*0x2acf44c*/ void GetRenderParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self, UnityEngine.Camera camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                static /*0x2acf4e4*/ int GetRenderParameterCount_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self);
                /*0x2acf3f0*/ void GetRenderParameter(UnityEngine.Camera camera, int renderParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                /*0x2acf4a8*/ int GetRenderParameterCount();
            }

            struct XRBlitParams
            {
                /*0x10*/ UnityEngine.RenderTexture srcTex;
                /*0x18*/ int srcTexArraySlice;
                /*0x1c*/ UnityEngine.Rect srcRect;
                /*0x2c*/ UnityEngine.Rect destRect;
            }

            struct XRMirrorViewBlitDesc
            {
                /*0x10*/ nint displaySubsystemInstance;
                /*0x18*/ bool nativeBlitAvailable;
                /*0x19*/ bool nativeBlitInvalidStates;
                /*0x1c*/ int blitParamsCount;

                static /*0x2acf574*/ void GetBlitParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter);
                /*0x2acf520*/ void GetBlitParameter(int blitParameterIndex, ref UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter);
            }
        }
    }
}
