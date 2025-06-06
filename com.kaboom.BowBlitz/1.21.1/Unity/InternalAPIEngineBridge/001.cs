class <Module>
{
}

namespace UnityEngine
{
    namespace U2D
    {
        namespace Common
        {
            class InternalEngineBridge
            {
                static /*0x252cd3c*/ void SetLocalAABB(UnityEngine.SpriteRenderer spriteRenderer, UnityEngine.Bounds aabb);
                static /*0x252cd6c*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src);
                static /*0x252cd74*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, nint buffer);
                static /*0x252cd7c*/ UnityEngine.Vector2 GUIUnclip(UnityEngine.Vector2 v);
                static /*0x252cd84*/ UnityEngine.Rect GetGUIClipTopMostRect();
                static /*0x252cd8c*/ UnityEngine.Rect GetGUIClipTopRect();
                static /*0x252cd94*/ UnityEngine.Rect GetGUIClipVisibleRect();
                static /*0x252cd9c*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
            }
        }
    }
}
