class <Module>
{
}

namespace UnityEngine
{
    namespace XR
    {
        class XRSettings
        {
            static /*0x2acd654*/ bool get_enabled();
            static /*0x2acd67c*/ bool get_isDeviceActive();
            static /*0x2acd6a4*/ float get_eyeTextureResolutionScale();
            static /*0x2acd6cc*/ void set_eyeTextureResolutionScale(float value);
            static /*0x2acd704*/ int get_eyeTextureWidth();
            static /*0x2acd72c*/ int get_eyeTextureHeight();
            static /*0x2acd754*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x2acd800*/ float get_renderViewportScale();
            static /*0x2acd828*/ float get_renderViewportScaleInternal();
            static /*0x2acd850*/ string get_loadedDeviceName();
            static /*0x2acd878*/ string[] get_supportedDevices();
            static /*0x2acd8a0*/ UnityEngine.XR.XRSettings.StereoRenderingMode get_stereoRenderingMode();
            static /*0x2acd7c4*/ void get_eyeTextureDesc_Injected(ref UnityEngine.RenderTextureDescriptor ret);

            enum StereoRenderingMode
            {
                MultiPass = 0,
                SinglePass = 1,
                SinglePassInstanced = 2,
                SinglePassMultiview = 3,
            }
        }

        class XRDevice
        {
            static /*0x0*/ System.Action<string> deviceLoaded;

            static /*0x2acd8c8*/ void InvokeDeviceLoaded(string loadedDeviceName);
        }
    }
}
