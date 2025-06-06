class <Module>
{
}

namespace UnityEngine
{
    namespace Playables
    {
        class PlayableDirector : UnityEngine.Behaviour, UnityEngine.IExposedPropertyTable
        {
            /*0x18*/ System.Action<UnityEngine.Playables.PlayableDirector> played;
            /*0x20*/ System.Action<UnityEngine.Playables.PlayableDirector> paused;
            /*0x28*/ System.Action<UnityEngine.Playables.PlayableDirector> stopped;

            /*0x28eba78*/ UnityEngine.Playables.PlayState get_state();
            /*0x28ebaf0*/ UnityEngine.Playables.DirectorWrapMode get_extrapolationMode();
            /*0x28ebb68*/ UnityEngine.Playables.PlayableAsset get_playableAsset();
            /*0x28ebc44*/ UnityEngine.Playables.PlayableGraph get_playableGraph();
            /*0x28ebc9c*/ void Play(UnityEngine.Playables.FrameRate frameRate);
            /*0x28ebd2c*/ void set_time(double value);
            /*0x28ebd78*/ double get_time();
            /*0x28ebdb4*/ void Evaluate();
            /*0x28ebce4*/ void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate);
            /*0x28ebe34*/ void Play();
            /*0x28ebe70*/ void Stop();
            /*0x28ebeac*/ void Pause();
            /*0x28ebee8*/ void ClearReferenceValue(UnityEngine.PropertyName id);
            /*0x28ebf74*/ void SetReferenceValue(UnityEngine.PropertyName id, UnityEngine.Object value);
            /*0x28ec020*/ UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
            /*0x28ec0cc*/ UnityEngine.Object GetGenericBinding(UnityEngine.Object key);
            /*0x28ebab4*/ UnityEngine.Playables.PlayState GetPlayState();
            /*0x28ebb2c*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode();
            /*0x28ebc48*/ UnityEngine.Playables.PlayableGraph GetGraphHandle();
            /*0x28ebc08*/ UnityEngine.ScriptableObject Internal_GetPlayableAsset();
            /*0x28ec154*/ void SendOnPlayableDirectorPlay();
            /*0x28ec174*/ void SendOnPlayableDirectorPause();
            /*0x28ec194*/ void SendOnPlayableDirectorStop();
            /*0x28ebdf0*/ void PlayOnFrame_Injected(ref UnityEngine.Playables.FrameRate frameRate);
            /*0x28ebf30*/ void ClearReferenceValue_Injected(ref UnityEngine.PropertyName id);
            /*0x28ebfcc*/ void SetReferenceValue_Injected(ref UnityEngine.PropertyName id, UnityEngine.Object value);
            /*0x28ec078*/ UnityEngine.Object GetReferenceValue_Injected(ref UnityEngine.PropertyName id, ref bool idValid);
            /*0x28ec110*/ void GetGraphHandle_Injected(ref UnityEngine.Playables.PlayableGraph ret);
        }
    }
}
