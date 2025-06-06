class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestTexture
        {
            static /*0x2acd220*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri);
            static /*0x2acd228*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
        }

        class DownloadHandlerTexture : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;
            /*0x28*/ UnityEngine.Texture2D mTexture;
            /*0x30*/ bool mHasTexture;
            /*0x31*/ bool mNonReadable;

            static /*0x2acd348*/ nint Create(UnityEngine.Networking.DownloadHandlerTexture obj, bool readable);
            /*0x2acd2e8*/ DownloadHandlerTexture(bool readable);
            /*0x2acd38c*/ void InternalCreateTexture(bool readable);
            /*0x2acd3d8*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x2acd3e4*/ void Dispose();
            /*0x2acd408*/ UnityEngine.Texture2D get_texture();
            /*0x2acd40c*/ UnityEngine.Texture2D InternalGetTexture();
            /*0x2acd5dc*/ UnityEngine.Texture2D InternalGetTextureNative();
            /*0x2acd618*/ void ClearNativeTexture();
        }
    }
}
