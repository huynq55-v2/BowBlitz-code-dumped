class <Module>
{
}

namespace UnityEngine
{
    namespace Rendering
    {
        namespace Universal
        {
            enum DebugMaterialMode
            {
                None = 0,
                Albedo = 1,
                Specular = 2,
                Alpha = 3,
                Smoothness = 4,
                AmbientOcclusion = 5,
                Emission = 6,
                NormalWorldSpace = 7,
                NormalTangentSpace = 8,
                LightingComplexity = 9,
                Metallic = 10,
                SpriteMask = 11,
            }

            enum DebugVertexAttributeMode
            {
                None = 0,
                Texcoord0 = 1,
                Texcoord1 = 2,
                Texcoord2 = 3,
                Texcoord3 = 4,
                Color = 5,
                Tangent = 6,
                Normal = 7,
            }

            enum DebugMaterialValidationMode
            {
                None = 0,
                Albedo = 1,
                Metallic = 2,
            }

            enum DebugFullScreenMode
            {
                None = 0,
                Depth = 1,
                AdditionalLightsShadowMap = 2,
                MainLightShadowMap = 3,
            }

            enum DebugSceneOverrideMode
            {
                None = 0,
                Overdraw = 1,
                Wireframe = 2,
                SolidWireframe = 3,
                ShadedWireframe = 4,
            }

            enum DebugMipInfoMode
            {
                None = 0,
                Level = 1,
                Count = 2,
                Ratio = 3,
            }

            enum DebugPostProcessingMode
            {
                Disabled = 0,
                Auto = 1,
                Enabled = 2,
            }

            enum DebugValidationMode
            {
                None = 0,
                HighlightNanInfNegative = 1,
                HighlightOutsideOfRange = 2,
            }

            enum PixelValidationChannels
            {
                RGB = 0,
                R = 1,
                G = 2,
                B = 3,
                A = 4,
            }

            enum DebugLightingMode
            {
                None = 0,
                ShadowCascades = 1,
                LightingWithoutNormalMaps = 2,
                LightingWithNormalMaps = 3,
                Reflections = 4,
                ReflectionsWithSmoothness = 5,
            }

            enum DebugLightingFeatureFlags
            {
                None = 0,
                GlobalIllumination = 1,
                MainLight = 2,
                AdditionalLights = 4,
                VertexLighting = 8,
                Emission = 16,
                AmbientOcclusion = 32,
            }

            class ShaderInput
            {
                struct ShadowData
                {
                    /*0x10*/ UnityEngine.Matrix4x4 worldToShadowMatrix;
                    /*0x50*/ UnityEngine.Vector4 shadowParams;
                }

                struct LightData
                {
                    /*0x10*/ UnityEngine.Vector4 position;
                    /*0x20*/ UnityEngine.Vector4 color;
                    /*0x30*/ UnityEngine.Vector4 attenuation;
                    /*0x40*/ UnityEngine.Vector4 spotDirection;
                    /*0x50*/ UnityEngine.Vector4 occlusionProbeChannels;
                    /*0x60*/ uint layerMask;
                }
            }
        }
    }
}
