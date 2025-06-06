class <Module>
{
}

class AOTGenericReferences : UnityEngine.MonoBehaviour
{
    /*0xdcde1c*/ AOTGenericReferences();
    /*0xdcde18*/ void RefMethods();
}

class EnemySpawnClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ int enemyid;
    /*0x1c*/ int offset1;
    /*0x20*/ int offset2;
    /*0x24*/ bool isRandom;
    /*0x28*/ float hp;
    /*0x2c*/ float atk;
    /*0x30*/ int count;
    /*0x34*/ bool immediate;

    /*0xdcdf40*/ EnemySpawnClip();
    /*0xdcde24*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
    /*0xdcde2c*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class EnemySpawnPlayableAsset : UnityEngine.Playables.PlayableAsset
{
    /*0xdce010*/ EnemySpawnPlayableAsset();
    /*0xdcdf74*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class EnemySpawnPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    /*0x10*/ int id;
    /*0x14*/ int offset1;
    /*0x18*/ int offset2;
    /*0x1c*/ bool isRandom;
    /*0x20*/ float hp;
    /*0x24*/ float atk;
    /*0x28*/ int count;
    /*0x2c*/ bool immediate;
    /*0x30*/ System.Collections.Generic.List<double> times;

    /*0xdcea94*/ EnemySpawnPlayableBehaviour();
    /*0xdce018*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
    /*0xdce01c*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
    /*0xdce020*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0xdce690*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0xdce6e0*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0xdce800*/ void Spawn();
    /*0xdce50c*/ void ExecCommand(string gmCommand);
}

class EnemySpawnTrack : UnityEngine.Timeline.TrackAsset
{
    /*0xdceb20*/ EnemySpawnTrack();
}

class ChatController : UnityEngine.MonoBehaviour
{
    /*0x18*/ TMPro.TMP_InputField ChatInputField;
    /*0x20*/ TMPro.TMP_Text ChatDisplayOutput;
    /*0x28*/ UnityEngine.UI.Scrollbar ChatScrollbar;

    /*0xdcf0d0*/ ChatController();
    /*0xdceb78*/ void OnEnable();
    /*0xdcec20*/ void OnDisable();
    /*0xdcecc8*/ void AddToChatOutput(string newText);
}

class DropdownSample : UnityEngine.MonoBehaviour
{
    /*0x18*/ TMPro.TextMeshProUGUI text;
    /*0x20*/ TMPro.TMP_Dropdown dropdownWithoutPlaceholder;
    /*0x28*/ TMPro.TMP_Dropdown dropdownWithPlaceholder;

    /*0xdcf1e0*/ DropdownSample();
    /*0xdcf0d8*/ void OnButtonClick();
}

class EnvMapAnimator : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Vector3 RotationSpeeds;
    /*0x28*/ TMPro.TMP_Text m_textMeshPro;
    /*0x30*/ UnityEngine.Material m_material;

    /*0xdcf2e4*/ EnvMapAnimator();
    /*0xdcf1e8*/ void Awake();
    /*0xdcf254*/ System.Collections.IEnumerator Start();

    class <Start>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ EnvMapAnimator <>4__this;
        /*0x28*/ UnityEngine.Matrix4x4 <matrix>5__2;

        /*0xdcf2bc*/ <Start>d__4(int <>1__state);
        /*0xdcf2ec*/ void System.IDisposable.Dispose();
        /*0xdcf2f0*/ bool MoveNext();
        /*0xdcf4f4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdcf4fc*/ void System.Collections.IEnumerator.Reset();
        /*0xdcf53c*/ object System.Collections.IEnumerator.get_Current();
    }
}

namespace TMPro
{
    class TMP_DigitValidator : TMPro.TMP_InputValidator
    {
        /*0xdcf5b8*/ TMP_DigitValidator();
        /*0xdcf544*/ char Validate(ref string text, ref int pos, char ch);
    }

    class TMP_PhoneNumberValidator : TMPro.TMP_InputValidator
    {
        /*0xdcf9b0*/ TMP_PhoneNumberValidator();
        /*0xdcf5c0*/ char Validate(ref string text, ref int pos, char ch);
    }

    class TMP_TextEventHandler : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        /*0x18*/ TMPro.TMP_TextEventHandler.CharacterSelectionEvent m_OnCharacterSelection;
        /*0x20*/ TMPro.TMP_TextEventHandler.SpriteSelectionEvent m_OnSpriteSelection;
        /*0x28*/ TMPro.TMP_TextEventHandler.WordSelectionEvent m_OnWordSelection;
        /*0x30*/ TMPro.TMP_TextEventHandler.LineSelectionEvent m_OnLineSelection;
        /*0x38*/ TMPro.TMP_TextEventHandler.LinkSelectionEvent m_OnLinkSelection;
        /*0x40*/ TMPro.TMP_Text m_TextComponent;
        /*0x48*/ UnityEngine.Camera m_Camera;
        /*0x50*/ UnityEngine.Canvas m_Canvas;
        /*0x58*/ int m_selectedLink;
        /*0x5c*/ int m_lastCharIndex;
        /*0x60*/ int m_lastWordIndex;
        /*0x64*/ int m_lastLineIndex;

        /*0xdd025c*/ TMP_TextEventHandler();
        /*0xdcf9b8*/ TMPro.TMP_TextEventHandler.CharacterSelectionEvent get_onCharacterSelection();
        /*0xdcf9c0*/ void set_onCharacterSelection(TMPro.TMP_TextEventHandler.CharacterSelectionEvent value);
        /*0xdcf9c8*/ TMPro.TMP_TextEventHandler.SpriteSelectionEvent get_onSpriteSelection();
        /*0xdcf9d0*/ void set_onSpriteSelection(TMPro.TMP_TextEventHandler.SpriteSelectionEvent value);
        /*0xdcf9d8*/ TMPro.TMP_TextEventHandler.WordSelectionEvent get_onWordSelection();
        /*0xdcf9e0*/ void set_onWordSelection(TMPro.TMP_TextEventHandler.WordSelectionEvent value);
        /*0xdcf9e8*/ TMPro.TMP_TextEventHandler.LineSelectionEvent get_onLineSelection();
        /*0xdcf9f0*/ void set_onLineSelection(TMPro.TMP_TextEventHandler.LineSelectionEvent value);
        /*0xdcf9f8*/ TMPro.TMP_TextEventHandler.LinkSelectionEvent get_onLinkSelection();
        /*0xdcfa00*/ void set_onLinkSelection(TMPro.TMP_TextEventHandler.LinkSelectionEvent value);
        /*0xdcfa08*/ void Awake();
        /*0xdcfb80*/ void LateUpdate();
        /*0xdd0254*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        /*0xdd0258*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0xdcfff8*/ void SendOnCharacterSelection(char character, int characterIndex);
        /*0xdd006c*/ void SendOnSpriteSelection(char character, int characterIndex);
        /*0xdd00e0*/ void SendOnWordSelection(string word, int charIndex, int length);
        /*0xdd015c*/ void SendOnLineSelection(string line, int charIndex, int length);
        /*0xdd01d8*/ void SendOnLinkSelection(string linkID, string linkText, int linkIndex);

        class CharacterSelectionEvent : UnityEngine.Events.UnityEvent<char, int>
        {
            /*0xdd0378*/ CharacterSelectionEvent();
        }

        class SpriteSelectionEvent : UnityEngine.Events.UnityEvent<char, int>
        {
            /*0xdd03c0*/ SpriteSelectionEvent();
        }

        class WordSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0xdd0408*/ WordSelectionEvent();
        }

        class LineSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0xdd0450*/ LineSelectionEvent();
        }

        class LinkSelectionEvent : UnityEngine.Events.UnityEvent<string, string, int>
        {
            /*0xdd0498*/ LinkSelectionEvent();
        }
    }

    namespace Examples
    {
        class Benchmark01 : UnityEngine.MonoBehaviour
        {
            static string label01 = "The <#0050FF>count is: </color>{0}";
            static string label02 = "The <color=#0050FF>count is: </color>";
            /*0x18*/ int BenchmarkType;
            /*0x20*/ TMPro.TMP_FontAsset TMProFont;
            /*0x28*/ UnityEngine.Font TextMeshFont;
            /*0x30*/ TMPro.TextMeshPro m_textMeshPro;
            /*0x38*/ TMPro.TextContainer m_textContainer;
            /*0x40*/ UnityEngine.TextMesh m_textMesh;
            /*0x48*/ UnityEngine.Material m_material01;
            /*0x50*/ UnityEngine.Material m_material02;

            /*0xdd0570*/ Benchmark01();
            /*0xdd04e0*/ System.Collections.IEnumerator Start();

            class <Start>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.Benchmark01 <>4__this;
                /*0x28*/ int <i>5__2;

                /*0xdd0548*/ <Start>d__10(int <>1__state);
                /*0xdd0578*/ void System.IDisposable.Dispose();
                /*0xdd057c*/ bool MoveNext();
                /*0xdd0ac0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd0ac8*/ void System.Collections.IEnumerator.Reset();
                /*0xdd0b08*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class Benchmark01_UGUI : UnityEngine.MonoBehaviour
        {
            static string label01 = "The <#0050FF>count is: </color>";
            static string label02 = "The <color=#0050FF>count is: </color>";
            /*0x18*/ int BenchmarkType;
            /*0x20*/ UnityEngine.Canvas canvas;
            /*0x28*/ TMPro.TMP_FontAsset TMProFont;
            /*0x30*/ UnityEngine.Font TextMeshFont;
            /*0x38*/ TMPro.TextMeshProUGUI m_textMeshPro;
            /*0x40*/ UnityEngine.UI.Text m_textMesh;
            /*0x48*/ UnityEngine.Material m_material01;
            /*0x50*/ UnityEngine.Material m_material02;

            /*0xdd0ba0*/ Benchmark01_UGUI();
            /*0xdd0b10*/ System.Collections.IEnumerator Start();

            class <Start>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.Benchmark01_UGUI <>4__this;
                /*0x28*/ int <i>5__2;

                /*0xdd0b78*/ <Start>d__10(int <>1__state);
                /*0xdd0ba8*/ void System.IDisposable.Dispose();
                /*0xdd0bac*/ bool MoveNext();
                /*0xdd0fec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd0ff4*/ void System.Collections.IEnumerator.Reset();
                /*0xdd1034*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class Benchmark02 : UnityEngine.MonoBehaviour
        {
            /*0x18*/ int SpawnType;
            /*0x1c*/ int NumberOfNPC;
            /*0x20*/ bool IsTextObjectScaleStatic;
            /*0x28*/ TMPro.Examples.TextMeshProFloatingText floatingText_Script;

            /*0xdd1604*/ Benchmark02();
            /*0xdd103c*/ void Start();
        }

        class Benchmark03 : UnityEngine.MonoBehaviour
        {
            /*0x18*/ int NumberOfSamples;
            /*0x1c*/ TMPro.Examples.Benchmark03.BenchmarkType Benchmark;
            /*0x20*/ UnityEngine.Font SourceFont;

            /*0xdd1a54*/ Benchmark03();
            /*0xdd1614*/ void Awake();
            /*0xdd1618*/ void Start();

            enum BenchmarkType
            {
                TMP_SDF_MOBILE = 0,
                TMP_SDF__MOBILE_SSD = 1,
                TMP_SDF = 2,
                TMP_BITMAP_MOBILE = 3,
                TEXTMESH_BITMAP = 4,
            }
        }

        class Benchmark04 : UnityEngine.MonoBehaviour
        {
            /*0x18*/ int SpawnType;
            /*0x1c*/ int MinPointSize;
            /*0x20*/ int MaxPointSize;
            /*0x24*/ int Steps;
            /*0x28*/ UnityEngine.Transform m_Transform;

            /*0xdd1d64*/ Benchmark04();
            /*0xdd1a64*/ void Start();
        }

        class CameraController : UnityEngine.MonoBehaviour
        {
            static string event_SmoothingValue = "Slider - Smoothing Value";
            static string event_FollowDistance = "Slider - Camera Zoom";
            /*0x18*/ UnityEngine.Transform cameraTransform;
            /*0x20*/ UnityEngine.Transform dummyTarget;
            /*0x28*/ UnityEngine.Transform CameraTarget;
            /*0x30*/ float FollowDistance;
            /*0x34*/ float MaxFollowDistance;
            /*0x38*/ float MinFollowDistance;
            /*0x3c*/ float ElevationAngle;
            /*0x40*/ float MaxElevationAngle;
            /*0x44*/ float MinElevationAngle;
            /*0x48*/ float OrbitalAngle;
            /*0x4c*/ TMPro.Examples.CameraController.CameraModes CameraMode;
            /*0x50*/ bool MovementSmoothing;
            /*0x51*/ bool RotationSmoothing;
            /*0x52*/ bool previousSmoothing;
            /*0x54*/ float MovementSmoothingValue;
            /*0x58*/ float RotationSmoothingValue;
            /*0x5c*/ float MoveSensitivity;
            /*0x60*/ UnityEngine.Vector3 currentVelocity;
            /*0x6c*/ UnityEngine.Vector3 desiredPosition;
            /*0x78*/ float mouseX;
            /*0x7c*/ float mouseY;
            /*0x80*/ UnityEngine.Vector3 moveVector;
            /*0x8c*/ float mouseWheel;

            /*0xdd29e8*/ CameraController();
            /*0xdd1d80*/ void Awake();
            /*0xdd1df0*/ void Start();
            /*0xdd1eb0*/ void LateUpdate();
            /*0xdd21e4*/ void GetPlayerInput();

            enum CameraModes
            {
                Follow = 0,
                Isometric = 1,
                Free = 2,
            }
        }

        class ObjectSpin : UnityEngine.MonoBehaviour
        {
            /*0x18*/ float SpinSpeed;
            /*0x1c*/ int RotationRange;
            /*0x20*/ UnityEngine.Transform m_transform;
            /*0x28*/ float m_time;
            /*0x2c*/ UnityEngine.Vector3 m_prevPOS;
            /*0x38*/ UnityEngine.Vector3 m_initial_Rotation;
            /*0x44*/ UnityEngine.Vector3 m_initial_Position;
            /*0x50*/ UnityEngine.Color32 m_lightColor;
            /*0x54*/ int frames;
            /*0x58*/ TMPro.Examples.ObjectSpin.MotionType Motion;

            /*0xdd2f90*/ ObjectSpin();
            /*0xdd2a74*/ void Awake();
            /*0xdd2e48*/ void Update();

            enum MotionType
            {
                Rotation = 0,
                BackAndForth = 1,
                Translation = 2,
            }
        }

        class ShaderPropAnimator : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.Renderer m_Renderer;
            /*0x20*/ UnityEngine.Material m_Material;
            /*0x28*/ UnityEngine.AnimationCurve GlowCurve;
            /*0x30*/ float m_frame;

            /*0xdd30b8*/ ShaderPropAnimator();
            /*0xdd2fa4*/ void Awake();
            /*0xdd3008*/ void Start();
            /*0xdd3028*/ System.Collections.IEnumerator AnimateProperties();

            class <AnimateProperties>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.ShaderPropAnimator <>4__this;

                /*0xdd3090*/ <AnimateProperties>d__6(int <>1__state);
                /*0xdd30c0*/ void System.IDisposable.Dispose();
                /*0xdd30c4*/ bool MoveNext();
                /*0xdd321c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd3224*/ void System.Collections.IEnumerator.Reset();
                /*0xdd3264*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class SimpleScript : UnityEngine.MonoBehaviour
        {
            static string label = "The <#0050FF>count is: </color>{0:2}";
            /*0x18*/ TMPro.TextMeshPro m_textMeshPro;
            /*0x20*/ float m_frame;

            /*0xdd33ac*/ SimpleScript();
            /*0xdd326c*/ void Start();
            /*0xdd3320*/ void Update();
        }

        class SkewTextExample : UnityEngine.MonoBehaviour
        {
            /*0x18*/ TMPro.TMP_Text m_TextComponent;
            /*0x20*/ UnityEngine.AnimationCurve VertexCurve;
            /*0x28*/ float CurveScale;
            /*0x2c*/ float ShearAmount;

            /*0xdd3544*/ SkewTextExample();
            /*0xdd33b4*/ void Awake();
            /*0xdd3414*/ void Start();
            /*0xdd349c*/ UnityEngine.AnimationCurve CopyAnimationCurve(UnityEngine.AnimationCurve curve);
            /*0xdd3434*/ System.Collections.IEnumerator WarpText();

            class <WarpText>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.SkewTextExample <>4__this;
                /*0x28*/ float <old_CurveScale>5__2;
                /*0x2c*/ float <old_ShearValue>5__3;
                /*0x30*/ UnityEngine.AnimationCurve <old_curve>5__4;

                /*0xdd351c*/ <WarpText>d__7(int <>1__state);
                /*0xdd3774*/ void System.IDisposable.Dispose();
                /*0xdd3778*/ bool MoveNext();
                /*0xdd406c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd4074*/ void System.Collections.IEnumerator.Reset();
                /*0xdd40b4*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class TeleType : UnityEngine.MonoBehaviour
        {
            /*0x18*/ string label01;
            /*0x20*/ string label02;
            /*0x28*/ TMPro.TMP_Text m_textMeshPro;

            /*0xdd41dc*/ TeleType();
            /*0xdd40bc*/ void Awake();
            /*0xdd414c*/ System.Collections.IEnumerator Start();

            class <Start>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.TeleType <>4__this;
                /*0x28*/ int <totalVisibleCharacters>5__2;
                /*0x2c*/ int <counter>5__3;

                /*0xdd41b4*/ <Start>d__4(int <>1__state);
                /*0xdd4250*/ void System.IDisposable.Dispose();
                /*0xdd4254*/ bool MoveNext();
                /*0xdd443c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd4444*/ void System.Collections.IEnumerator.Reset();
                /*0xdd4484*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class TextConsoleSimulator : UnityEngine.MonoBehaviour
        {
            /*0x18*/ TMPro.TMP_Text m_TextComponent;
            /*0x20*/ bool hasTextChanged;

            /*0xdd47e0*/ TextConsoleSimulator();
            /*0xdd448c*/ void Awake();
            /*0xdd44ec*/ void Start();
            /*0xdd4584*/ void OnEnable();
            /*0xdd4650*/ void OnDisable();
            /*0xdd471c*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
            /*0xdd4510*/ System.Collections.IEnumerator RevealCharacters(TMPro.TMP_Text textComponent);
            /*0xdd4750*/ System.Collections.IEnumerator RevealWords(TMPro.TMP_Text textComponent);

            class <RevealCharacters>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.TMP_Text textComponent;
                /*0x28*/ TMPro.Examples.TextConsoleSimulator <>4__this;
                /*0x30*/ TMPro.TMP_TextInfo <textInfo>5__2;
                /*0x38*/ int <totalVisibleCharacters>5__3;
                /*0x3c*/ int <visibleCount>5__4;

                /*0xdd4728*/ <RevealCharacters>d__7(int <>1__state);
                /*0xdd47e8*/ void System.IDisposable.Dispose();
                /*0xdd47ec*/ bool MoveNext();
                /*0xdd4944*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd494c*/ void System.Collections.IEnumerator.Reset();
                /*0xdd498c*/ object System.Collections.IEnumerator.get_Current();
            }

            class <RevealWords>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.TMP_Text textComponent;
                /*0x28*/ int <totalWordCount>5__2;
                /*0x2c*/ int <totalVisibleCharacters>5__3;
                /*0x30*/ int <counter>5__4;
                /*0x34*/ int <visibleCount>5__5;

                /*0xdd47b8*/ <RevealWords>d__8(int <>1__state);
                /*0xdd4994*/ void System.IDisposable.Dispose();
                /*0xdd4998*/ bool MoveNext();
                /*0xdd4b54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd4b5c*/ void System.Collections.IEnumerator.Reset();
                /*0xdd4b9c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class TextMeshProFloatingText : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ UnityEngine.WaitForEndOfFrame k_WaitForEndOfFrame;
            static /*0x8*/ UnityEngine.WaitForSeconds[] k_WaitForSecondsRandom;
            /*0x18*/ UnityEngine.Font TheFont;
            /*0x20*/ UnityEngine.GameObject m_floatingText;
            /*0x28*/ TMPro.TextMeshPro m_textMeshPro;
            /*0x30*/ UnityEngine.TextMesh m_textMesh;
            /*0x38*/ UnityEngine.Transform m_transform;
            /*0x40*/ UnityEngine.Transform m_floatingText_Transform;
            /*0x48*/ UnityEngine.Transform m_cameraTransform;
            /*0x50*/ UnityEngine.Vector3 lastPOS;
            /*0x5c*/ UnityEngine.Quaternion lastRotation;
            /*0x6c*/ int SpawnType;
            /*0x70*/ bool IsTextObjectScaleStatic;

            static /*0xdd5204*/ TextMeshProFloatingText();
            /*0xdd516c*/ TextMeshProFloatingText();
            /*0xdd4ba4*/ void Awake();
            /*0xdd4c6c*/ void Start();
            /*0xdd504c*/ System.Collections.IEnumerator DisplayTextMeshProFloatingText();
            /*0xdd50b4*/ System.Collections.IEnumerator DisplayTextMeshFloatingText();

            class <DisplayTextMeshProFloatingText>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.TextMeshProFloatingText <>4__this;
                /*0x28*/ float <CountDuration>5__2;
                /*0x2c*/ float <starting_Count>5__3;
                /*0x30*/ float <current_Count>5__4;
                /*0x34*/ UnityEngine.Vector3 <start_pos>5__5;
                /*0x40*/ UnityEngine.Color32 <start_color>5__6;
                /*0x44*/ float <alpha>5__7;
                /*0x48*/ float <fadeDuration>5__8;

                /*0xdd511c*/ <DisplayTextMeshProFloatingText>d__15(int <>1__state);
                /*0xdd581c*/ void System.IDisposable.Dispose();
                /*0xdd5820*/ bool MoveNext();
                /*0xdd5efc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd5f04*/ void System.Collections.IEnumerator.Reset();
                /*0xdd5f44*/ object System.Collections.IEnumerator.get_Current();
            }

            class <DisplayTextMeshFloatingText>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.TextMeshProFloatingText <>4__this;
                /*0x28*/ float <CountDuration>5__2;
                /*0x2c*/ float <starting_Count>5__3;
                /*0x30*/ float <current_Count>5__4;
                /*0x34*/ UnityEngine.Vector3 <start_pos>5__5;
                /*0x40*/ UnityEngine.Color32 <start_color>5__6;
                /*0x44*/ float <alpha>5__7;
                /*0x48*/ float <fadeDuration>5__8;

                /*0xdd5144*/ <DisplayTextMeshFloatingText>d__16(int <>1__state);
                /*0xdd5f4c*/ void System.IDisposable.Dispose();
                /*0xdd5f50*/ bool MoveNext();
                /*0xdd6614*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdd661c*/ void System.Collections.IEnumerator.Reset();
                /*0xdd665c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class TextMeshSpawner : UnityEngine.MonoBehaviour
        {
            /*0x18*/ int SpawnType;
            /*0x1c*/ int NumberOfNPC;
            /*0x20*/ UnityEngine.Font TheFont;
            /*0x28*/ TMPro.Examples.TextMeshProFloatingText floatingText_Script;

            /*0xdd6944*/ TextMeshSpawner();
            /*0xdd6664*/ void Awake();
            /*0xdd6668*/ void Start();
        }

        class TMPro_InstructionOverlay : UnityEngine.MonoBehaviour
        {
            static string instructions = "Camera Control - <#ffff00>Shift + RMB
</color>Zoom - <#ffff00>Mouse wheel.";
            /*0x18*/ TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions AnchorPosition;
            /*0x20*/ TMPro.TextMeshPro m_TextMeshPro;
            /*0x28*/ TMPro.TextContainer m_textContainer;
            /*0x30*/ UnityEngine.Transform m_frameCounter_transform;
            /*0x38*/ UnityEngine.Camera m_camera;

            /*0xdd6cec*/ TMPro_InstructionOverlay();
            /*0xdd6954*/ void Awake();
            /*0xdd6bd8*/ void Set_FrameCounter_Position(TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions anchor_position);

            enum FpsCounterAnchorPositions
            {
                TopLeft = 0,
                BottomLeft = 1,
                TopRight = 2,
                BottomRight = 3,
            }
        }

        class TMP_ExampleScript_01 : UnityEngine.MonoBehaviour
        {
            static string k_label = "The count is <#0080ff>{0}</color>";
            /*0x18*/ TMPro.Examples.TMP_ExampleScript_01.objectType ObjectType;
            /*0x1c*/ bool isStatic;
            /*0x20*/ TMPro.TMP_Text m_text;
            /*0x28*/ int count;

            /*0xdd6fac*/ TMP_ExampleScript_01();
            /*0xdd6cfc*/ void Awake();
            /*0xdd6f18*/ void Update();

            enum objectType
            {
                TextMeshPro = 0,
                TextMeshProUGUI = 1,
            }
        }

        class TMP_FrameRateCounter : UnityEngine.MonoBehaviour
        {
            static string fpsLabel = "{0:2}</color> <#8080ff>FPS 
<#FF8000>{1:2} <#8080ff>MS";
            /*0x18*/ float UpdateInterval;
            /*0x1c*/ float m_LastInterval;
            /*0x20*/ int m_Frames;
            /*0x24*/ TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions AnchorPosition;
            /*0x28*/ string htmlColorTag;
            /*0x30*/ TMPro.TextMeshPro m_TextMeshPro;
            /*0x38*/ UnityEngine.Transform m_frameCounter_transform;
            /*0x40*/ UnityEngine.Camera m_camera;
            /*0x48*/ TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;

            /*0xdd7524*/ TMP_FrameRateCounter();
            /*0xdd6fb4*/ void Awake();
            /*0xdd73bc*/ void Start();
            /*0xdd73dc*/ void Update();
            /*0xdd71e0*/ void Set_FrameCounter_Position(TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions anchor_position);

            enum FpsCounterAnchorPositions
            {
                TopLeft = 0,
                BottomLeft = 1,
                TopRight = 2,
                BottomRight = 3,
            }
        }

        class TMP_TextEventCheck : UnityEngine.MonoBehaviour
        {
            /*0x18*/ TMPro.TMP_TextEventHandler TextEventHandler;
            /*0x20*/ TMPro.TMP_Text m_TextComponent;

            /*0xdd859c*/ TMP_TextEventCheck();
            /*0xdd753c*/ void OnEnable();
            /*0xdd7800*/ void OnDisable();
            /*0xdd7a9c*/ void OnCharacterSelection(char c, int index);
            /*0xdd7c80*/ void OnSpriteSelection(char c, int index);
            /*0xdd7e64*/ void OnWordSelection(string word, int firstCharacterIndex, int length);
            /*0xdd80b0*/ void OnLineSelection(string lineText, int firstCharacterIndex, int length);
            /*0xdd82fc*/ void OnLinkSelection(string linkID, string linkText, int linkIndex);
        }

        class TMP_TextInfoDebugTool : UnityEngine.MonoBehaviour
        {
            /*0xdd85a4*/ TMP_TextInfoDebugTool();
        }

        class TMP_TextSelector_A : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler
        {
            /*0x18*/ TMPro.TextMeshPro m_TextMeshPro;
            /*0x20*/ UnityEngine.Camera m_Camera;
            /*0x28*/ bool m_isHoveringObject;
            /*0x2c*/ int m_selectedLink;
            /*0x30*/ int m_lastCharIndex;
            /*0x34*/ int m_lastWordIndex;

            /*0xdd8dc8*/ TMP_TextSelector_A();
            /*0xdd85ac*/ void Awake();
            /*0xdd8638*/ void LateUpdate();
            /*0xdd8cdc*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xdd8d54*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class TMP_TextSelector_B : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerUpHandler
        {
            static string k_LinkText = "You have selected link <#ffff00>";
            static string k_WordText = "Word Index: <#ffff00>";
            /*0x18*/ UnityEngine.RectTransform TextPopup_Prefab_01;
            /*0x20*/ UnityEngine.RectTransform m_TextPopup_RectTransform;
            /*0x28*/ TMPro.TextMeshProUGUI m_TextPopup_TMPComponent;
            /*0x30*/ TMPro.TextMeshProUGUI m_TextMeshPro;
            /*0x38*/ UnityEngine.Canvas m_Canvas;
            /*0x40*/ UnityEngine.Camera m_Camera;
            /*0x48*/ bool isHoveringObject;
            /*0x4c*/ int m_selectedWord;
            /*0x50*/ int m_selectedLink;
            /*0x54*/ int m_lastIndex;
            /*0x58*/ UnityEngine.Matrix4x4 m_matrix;
            /*0x98*/ TMPro.TMP_MeshInfo[] m_cachedMeshInfoVertexData;

            /*0xdda67c*/ TMP_TextSelector_B();
            /*0xdd8de0*/ void Awake();
            /*0xdd8f60*/ void OnEnable();
            /*0xdd902c*/ void OnDisable();
            /*0xdd90f8*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
            /*0xdd918c*/ void LateUpdate();
            /*0xdda660*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xdda66c*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xdda674*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xdda678*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0xdd9ddc*/ void RestoreCachedVertexAttributes(int index);
        }

        class TMP_UiFrameRateCounter : UnityEngine.MonoBehaviour
        {
            static string fpsLabel = "{0:2}</color> <#8080ff>FPS 
<#FF8000>{1:2} <#8080ff>MS";
            /*0x18*/ float UpdateInterval;
            /*0x1c*/ float m_LastInterval;
            /*0x20*/ int m_Frames;
            /*0x24*/ TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions AnchorPosition;
            /*0x28*/ string htmlColorTag;
            /*0x30*/ TMPro.TextMeshProUGUI m_TextMeshPro;
            /*0x38*/ UnityEngine.RectTransform m_frameCounter_transform;
            /*0x40*/ TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;

            /*0xddac38*/ TMP_UiFrameRateCounter();
            /*0xdda694*/ void Awake();
            /*0xddaad0*/ void Start();
            /*0xddaaf0*/ void Update();
            /*0xdda898*/ void Set_FrameCounter_Position(TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions anchor_position);

            enum FpsCounterAnchorPositions
            {
                TopLeft = 0,
                BottomLeft = 1,
                TopRight = 2,
                BottomRight = 3,
            }
        }

        class VertexColorCycler : UnityEngine.MonoBehaviour
        {
            /*0x18*/ TMPro.TMP_Text m_TextComponent;

            /*0xddad50*/ VertexColorCycler();
            /*0xddac50*/ void Awake();
            /*0xddaca0*/ void Start();
            /*0xddacc0*/ System.Collections.IEnumerator AnimateVertexColors();

            class <AnimateVertexColors>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.VertexColorCycler <>4__this;
                /*0x28*/ TMPro.TMP_TextInfo <textInfo>5__2;
                /*0x30*/ int <currentCharacter>5__3;

                /*0xddad28*/ <AnimateVertexColors>d__3(int <>1__state);
                /*0xddad58*/ void System.IDisposable.Dispose();
                /*0xddad5c*/ bool MoveNext();
                /*0xddb074*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xddb07c*/ void System.Collections.IEnumerator.Reset();
                /*0xddb0bc*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class VertexJitter : UnityEngine.MonoBehaviour
        {
            /*0x18*/ float AngleMultiplier;
            /*0x1c*/ float SpeedMultiplier;
            /*0x20*/ float CurveScale;
            /*0x28*/ TMPro.TMP_Text m_TextComponent;
            /*0x30*/ bool hasTextChanged;

            /*0xddb3d8*/ VertexJitter();
            /*0xddb0c4*/ void Awake();
            /*0xddb114*/ void OnEnable();
            /*0xddb1e0*/ void OnDisable();
            /*0xddb2ac*/ void Start();
            /*0xddb334*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
            /*0xddb2cc*/ System.Collections.IEnumerator AnimateVertexColors();

            struct VertexAnim
            {
                /*0x10*/ float angleRange;
                /*0x14*/ float angle;
                /*0x18*/ float speed;
            }

            class <AnimateVertexColors>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.VertexJitter <>4__this;
                /*0x28*/ TMPro.TMP_TextInfo <textInfo>5__2;
                /*0x30*/ int <loopCount>5__3;
                /*0x38*/ TMPro.Examples.VertexJitter.VertexAnim[] <vertexAnim>5__4;
                /*0x40*/ TMPro.TMP_MeshInfo[] <cachedMeshInfo>5__5;

                /*0xddb3b0*/ <AnimateVertexColors>d__11(int <>1__state);
                /*0xddb3f0*/ void System.IDisposable.Dispose();
                /*0xddb3f4*/ bool MoveNext();
                /*0xddbcc4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xddbccc*/ void System.Collections.IEnumerator.Reset();
                /*0xddbd0c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class VertexShakeA : UnityEngine.MonoBehaviour
        {
            /*0x18*/ float AngleMultiplier;
            /*0x1c*/ float SpeedMultiplier;
            /*0x20*/ float ScaleMultiplier;
            /*0x24*/ float RotationMultiplier;
            /*0x28*/ TMPro.TMP_Text m_TextComponent;
            /*0x30*/ bool hasTextChanged;

            /*0xddc018*/ VertexShakeA();
            /*0xddbd14*/ void Awake();
            /*0xddbd64*/ void OnEnable();
            /*0xddbe30*/ void OnDisable();
            /*0xddbefc*/ void Start();
            /*0xddbf84*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
            /*0xddbf1c*/ System.Collections.IEnumerator AnimateVertexColors();

            class <AnimateVertexColors>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.VertexShakeA <>4__this;
                /*0x28*/ TMPro.TMP_TextInfo <textInfo>5__2;
                /*0x30*/ UnityEngine.Vector3[][] <copyOfVertices>5__3;

                /*0xddbff0*/ <AnimateVertexColors>d__11(int <>1__state);
                /*0xddc028*/ void System.IDisposable.Dispose();
                /*0xddc02c*/ bool MoveNext();
                /*0xddca18*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xddca20*/ void System.Collections.IEnumerator.Reset();
                /*0xddca60*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class VertexShakeB : UnityEngine.MonoBehaviour
        {
            /*0x18*/ float AngleMultiplier;
            /*0x1c*/ float SpeedMultiplier;
            /*0x20*/ float CurveScale;
            /*0x28*/ TMPro.TMP_Text m_TextComponent;
            /*0x30*/ bool hasTextChanged;

            /*0xddcd6c*/ VertexShakeB();
            /*0xddca68*/ void Awake();
            /*0xddcab8*/ void OnEnable();
            /*0xddcb84*/ void OnDisable();
            /*0xddcc50*/ void Start();
            /*0xddccd8*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
            /*0xddcc70*/ System.Collections.IEnumerator AnimateVertexColors();

            class <AnimateVertexColors>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.VertexShakeB <>4__this;
                /*0x28*/ TMPro.TMP_TextInfo <textInfo>5__2;
                /*0x30*/ UnityEngine.Vector3[][] <copyOfVertices>5__3;

                /*0xddcd44*/ <AnimateVertexColors>d__10(int <>1__state);
                /*0xddcd84*/ void System.IDisposable.Dispose();
                /*0xddcd88*/ bool MoveNext();
                /*0xdddc68*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xdddc70*/ void System.Collections.IEnumerator.Reset();
                /*0xdddcb0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class VertexZoom : UnityEngine.MonoBehaviour
        {
            /*0x18*/ float AngleMultiplier;
            /*0x1c*/ float SpeedMultiplier;
            /*0x20*/ float CurveScale;
            /*0x28*/ TMPro.TMP_Text m_TextComponent;
            /*0x30*/ bool hasTextChanged;

            /*0xdddfcc*/ VertexZoom();
            /*0xdddcb8*/ void Awake();
            /*0xdddd08*/ void OnEnable();
            /*0xddddd4*/ void OnDisable();
            /*0xdddea0*/ void Start();
            /*0xdddf28*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
            /*0xdddec0*/ System.Collections.IEnumerator AnimateVertexColors();

            class <>c__DisplayClass10_0
            {
                /*0x10*/ System.Collections.Generic.List<float> modifiedCharScale;
                /*0x18*/ System.Comparison<int> <>9__0;

                /*0xdddfe4*/ <>c__DisplayClass10_0();
                /*0xdddfec*/ int <AnimateVertexColors>b__0(int a, int b);
            }

            class <AnimateVertexColors>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.VertexZoom <>4__this;
                /*0x28*/ TMPro.Examples.VertexZoom.<> <>8__1;
                /*0x30*/ TMPro.TMP_TextInfo <textInfo>5__2;
                /*0x38*/ TMPro.TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;
                /*0x40*/ System.Collections.Generic.List<int> <scaleSortingOrder>5__4;

                /*0xdddfa4*/ <AnimateVertexColors>d__10(int <>1__state);
                /*0xdde07c*/ void System.IDisposable.Dispose();
                /*0xdde080*/ bool MoveNext();
                /*0xddec94*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xddec9c*/ void System.Collections.IEnumerator.Reset();
                /*0xddecdc*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class WarpTextExample : UnityEngine.MonoBehaviour
        {
            /*0x18*/ TMPro.TMP_Text m_TextComponent;
            /*0x20*/ UnityEngine.AnimationCurve VertexCurve;
            /*0x28*/ float AngleMultiplier;
            /*0x2c*/ float SpeedMultiplier;
            /*0x30*/ float CurveScale;

            /*0xddee74*/ WarpTextExample();
            /*0xddece4*/ void Awake();
            /*0xdded44*/ void Start();
            /*0xddedcc*/ UnityEngine.AnimationCurve CopyAnimationCurve(UnityEngine.AnimationCurve curve);
            /*0xdded64*/ System.Collections.IEnumerator WarpText();

            class <WarpText>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ TMPro.Examples.WarpTextExample <>4__this;
                /*0x28*/ float <old_CurveScale>5__2;
                /*0x30*/ UnityEngine.AnimationCurve <old_curve>5__3;

                /*0xddee4c*/ <WarpText>d__8(int <>1__state);
                /*0xddf0ac*/ void System.IDisposable.Dispose();
                /*0xddf0b0*/ bool MoveNext();
                /*0xddf8f4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xddf8fc*/ void System.Collections.IEnumerator.Reset();
                /*0xddf93c*/ object System.Collections.IEnumerator.get_Current();
            }
        }
    }
}
